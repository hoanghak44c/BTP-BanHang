using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using QLBanHang.Modules.BanHang.Reports;
using CrystalDecisions.Shared;
using QLBanHang.Modules.DanhMuc;
using QLBH.Common;
using QLBH.Common.Objects;
using QLBH.Common.Providers;
using QLBH.Core.Data;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.DongBoERP;
//

namespace QLBanHang.Modules.BanHang
{
    public partial class frmCS_Duyet_BangGia : DevExpress.XtraEditors.XtraForm
    {
        #region declare
        List<BangGiaInfor> liBangGia = new List<BangGiaInfor>();
        //private int IdBangGia = 0;//id bang gia
        private int IndexBG = 0;//thu tu bang gia
        private int Draft = -1;//-1:chua ton tai; 1-save, 0-confirm
        private bool IsAdded = false;
        private bool Updating = false;//false: chua sua, tao moi; 1:dang sua, tao moi
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private BangGiaInfor bangGia = null;
        #endregion

        public frmCS_Duyet_BangGia()
        {
            InitializeComponent();
            Common.LoadStyle(this);            
        }
        public frmCS_Duyet_BangGia(BangGiaInfor bangGia)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.bangGia = bangGia;
        }

        private void cmdCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                Draft = 1;
                if (UpdateBangGia())
                {
                    Updating = false;
                    setEDItems();
                    setEDFunctions();                   
                }
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi thao tác\n" + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi thao tác", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }   
        }
        private bool UpdateBangGia()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (ValidBangGiaInfor())
                {
                    ConnectionUtil.Instance.BeginTransaction();
                    //update header
                    UpdateBangGiaHeader();
                    //update detail
                    UpdateBangGiaDetails();
                    ConnectionUtil.Instance.CommitTransaction();

                    if (IsAdded)
                    {
                        liBangGia.Insert(IndexBG, bangGia);
                        MessageBox.Show("Thêm mới bảng giá thành công!");
                    }
                    else
                        MessageBox.Show("Duyệt bảng giá thành công!");

                    return true;                    
                }
            }
            catch (Exception)
            {
                ConnectionUtil.Instance.RollbackTransaction();
                if (IsAdded && bangGia != null)
                    bangGia.IdBangGia = 0;              
                throw;
            }
            Cursor.Current = Cursors.Default;
            return false;
        }

        private void UpdateBangGiaDetails()
        {
            gvSanPham.RefreshData(); 
            //them tung cai moi;
            if (bangGia.ListBangGiaChiTiet != null)
            {
                foreach (BangGiaChiTietInfor bgChiTiet in bangGia.ListBangGiaChiTiet)
                {
                    if (!bgChiTiet.IsOrigin)//voi nhung chi tiet them hoac sua
                    {
                        //cap nhat bang gia chi tiet
                        bgChiTiet.IdBangGia = bangGia.IdBangGia;
                        bgChiTiet.NguoiCapNhat = nguoiDung.TenDangNhap;// nguoiDung.TenNhanVien + "(" + nguoiDung.TenDangNhap + ")";
                        if (bgChiTiet.IdChiTiet == 0 || IsAdded)
                            bgChiTiet.IdChiTiet = BangGiaDataProvider.Instance.InsertBangGiaChiTiet(bgChiTiet);
                        else
                            BangGiaDataProvider.Instance.UpdateBangGiaChiTiet(bgChiTiet);

                    }
                }
                //duyet bang gia
                BangGiaDataProvider.Instance.DuyetBangGia(bangGia);        
            }
        }

        private void UpdateBangGiaHeader()
        {
            //bg.IdBangGia = IdBangGia;
            //bangGia.Draft = Draft;
            //bangGia.SoBangGia = txtSoBangGia.Text;
            //bangGia.NgayLap = mstNgayLap.Value;
            //bangGia.NguoiLap = txtNguoiLap.Text;
            bangGia.GhiChu = txtGhiChu.Text;

            //if (bangGia.IdBangGia == 0)
            //{
            //    bangGia.NguoiTao = nguoiDung.TenDangNhap;
            //    bangGia.IdBangGia = BangGiaDataProvider.Instance.InsertBangGia(bangGia);
            //}
            //else
            //{
            bangGia.NguoiCapNhat = nguoiDung.TenDangNhap;// nguoiDung.TenNhanVien + "(" + nguoiDung.TenDangNhap + ")";
            BangGiaDataProvider.Instance.UpdateBangGia(bangGia);
            //}
        }

        //private void UpdateAllDataValue()
        //{
        //    double tongLoiNhuan = 0;
        //    if (gSanPham.DataSource == null) return;
        //    foreach (BangGiaChiTietInfor bgct in (BindingList<BangGiaChiTietInfor>)gSanPham.DataSource)
        //    {
        //        bgct.TienKhuyenMai = CommonFuns.Instance.GetTienKhuyenMai(bangGia.IdTrungTam, bgct.MaSanPham, Common.MaxValues(bgct.DonGiaCoVAT, bgct.GiaBanBuon, bgct.GiaBanDemo));
        //        bgct.GiaMin = (bgct.GiaNhapHDCuoi - bgct.TienChietKhauQK + bgct.TienKhuyenMai) *
        //                      (1 + bgct.TyLeLNBQ * (1 - bgct.DungSaiMin / 100) / 100);
        //        bgct.GiaMax = (bgct.GiaNhapHDCuoi - bgct.TienChietKhauQK + bgct.TienKhuyenMai) *
        //                      (1 + bgct.TyLeLNBQ * (1 + bgct.DungSaiMax / 100) / 100);
        //        bgct.GiaBanAnToan = (bgct.GiaNhapHDCuoi - bgct.TienChietKhauQK + bgct.TienKhuyenMai) *
        //                            (1 + bgct.TyLeLNBQ / 100);
        //        bgct.DonGiaChuaVAT = bgct.DonGiaCoVAT / (1 + bgct.TyLeVAT / 100) / (1 - bgct.TyLeChietKhau / 100);
        //        bgct.TienChietKhau = bgct.DonGiaChuaVAT * bgct.TyLeChietKhau / 100;
        //        bgct.TienVAT = bgct.DonGiaCoVAT - bgct.DonGiaChuaVAT + bgct.TienChietKhau;
        //        bgct.LoiNhuan = bgct.DonGiaChuaVAT - bgct.GiaNhapHDCuoi + bgct.TienChietKhauQK - bgct.TienKhuyenMai - bgct.ThuongNong;// * bgct.SoLuongBanBQ * (1 + bgct.DungSaiSLBQ / 100);
        //        bgct.LoiNhuanTon = bgct.DonGiaChuaVAT - bgct.GiaTonKhoBQ + bgct.TienChietKhauQK - bgct.TienKhuyenMai - bgct.ThuongNong;
        //        //bgct.GiaNiemYet = bgct.DonGiaCoVAT;
        //        //bgct.GiaWebSite = bgct.DonGiaCoVAT;
        //        double giaBanBuonChuaVat = bgct.GiaBanBuon / (1 + bgct.TyLeVAT / 100) / (1 - bgct.TyLeChietKhau / 100);
        //        bgct.LoiNhuanBB = giaBanBuonChuaVat - bgct.GiaNhapHDCuoi + bgct.TienChietKhauQK - bgct.TienKhuyenMai - bgct.ThuongNong;// * bgct.SoLuongBanBQ * (1 + bgct.DungSaiSLBQ / 100);
        //        bgct.LoiNhuanTon = giaBanBuonChuaVat - bgct.GiaTonKhoBQ + bgct.TienChietKhauQK - bgct.TienKhuyenMai - bgct.ThuongNong;


        //        //tinh thuong nhan vien
        //        bgct.TyLeThuong = (bgct.DonViDoanhThu != 0 ? bgct.DonGiaCoVAT * bgct.TrongSoDoanhThu / bgct.DonViDoanhThu : 0) +
        //                          (bgct.DonViLoiNhuan != 0
        //                               ? (bgct.DonGiaChuaVAT - bgct.TienChietKhau - bgct.TienKhuyenMai -
        //                                  bgct.GiaTonKhoBQ) *
        //                                 bgct.TrongSoLoiNhuan / bgct.DonViLoiNhuan
        //                               : 0) +
        //                          (bgct.DonViKhoanTon != 0
        //                               ? bgct.TonKho * bgct.GiaTonKhoBQ * bgct.TrongSoKhoanTon / bgct.DonViKhoanTon
        //                               : 0);

        //        if (bgct.DonGiaChuaVAT > bgct.GiaMax || bgct.DonGiaChuaVAT < bgct.GiaMin)
        //        {
        //            //Common.SetGridViewRowErrorStyle(dgvSanPham.CurrentRow);
        //            bgct.DaDuyet = 0;
        //        }
        //        else
        //        {
        //            //Common.SetGridViewRowStyle(dgvSanPham.CurrentRow);
        //            bgct.DaDuyet = 1;

        //        }
        //        //update loi nhuan
        //        tongLoiNhuan += bgct.LoiNhuan;
        //    }
        //    //((BindingList<BangGiaChiTietInfor>)dgvSanPham.DataSource).ResetBindings();

        //    txtTongLoiNhuan.Text = Common.Double2Str(tongLoiNhuan);
            
        //}
        private void UpdateDataValue(BangGiaChiTietInfor bgct)
        {
            if (bgct == null) return;
            bgct.TienKhuyenMai = CommonFuns.Instance.GetTienKhuyenMai(bangGia.IdTrungTam, bgct.MaSanPham, mstNgayLap.Value, Common.MaxValues(bgct.DonGiaCoVAT, bgct.GiaBanBuon, bgct.GiaBanDemo, bgct.GiaNhapDemoCuoi, bgct.GiaTonKhoBQ, bgct.GiaNhapHDCuoi));
            bgct.GiaMin = (bgct.GiaNhapHDCuoi - bgct.TienChietKhauQK + bgct.TienKhuyenMai) *
                          (1 + bgct.TyLeLNBQ * (1 - bgct.DungSaiMin / 100) / 100);
            bgct.GiaMax = (bgct.GiaNhapHDCuoi - bgct.TienChietKhauQK + bgct.TienKhuyenMai) *
                          (1 + bgct.TyLeLNBQ * (1 + bgct.DungSaiMax / 100) / 100);
            bgct.GiaBanAnToan = (bgct.GiaNhapHDCuoi - bgct.TienChietKhauQK + bgct.TienKhuyenMai) *
                                (1 + bgct.TyLeLNBQ / 100);
            bgct.DonGiaChuaVAT = bgct.DonGiaCoVAT / (1 + bgct.TyLeVAT / 100) / (1 - bgct.TyLeChietKhau / 100);
            bgct.TienChietKhau = bgct.DonGiaChuaVAT * bgct.TyLeChietKhau / 100;
            bgct.TienVAT = bgct.DonGiaCoVAT - bgct.DonGiaChuaVAT + bgct.TienChietKhau;
            //bgct.DonGiaCoVAT = bgct.DonGiaChuaVAT - bgct.TienChietKhau + bgct.TienVAT;
            bgct.LoiNhuan = bgct.DonGiaChuaVAT - bgct.GiaNhapHDCuoi + bgct.TienChietKhauQK - bgct.TienKhuyenMai - bgct.ThuongNong;// * bgct.SoLuongBanBQ * (1 + bgct.DungSaiSLBQ / 100);
            bgct.LoiNhuanTon = bgct.DonGiaChuaVAT - bgct.GiaTonKhoBQ + bgct.TienChietKhauQK - bgct.TienKhuyenMai - bgct.ThuongNong;
            bgct.GiaNiemYet = bgct.DonGiaCoVAT;
            bgct.GiaWebSite = bgct.DonGiaCoVAT;
            double giaBanBuonChuaVat = bgct.GiaBanBuon / (1 + bgct.TyLeVAT / 100) / (1 - bgct.TyLeChietKhau / 100);
            bgct.LoiNhuanBB = giaBanBuonChuaVat - bgct.GiaNhapHDCuoi + bgct.TienChietKhauQK - bgct.TienKhuyenMai - bgct.ThuongNong;// * bgct.SoLuongBanBQ * (1 + bgct.DungSaiSLBQ / 100);
            bgct.LoiNhuanTon = giaBanBuonChuaVat - bgct.GiaTonKhoBQ + bgct.TienChietKhauQK - bgct.TienKhuyenMai - bgct.ThuongNong;

            BangGiaNhomNguoiDuyetInfor nnd = BangGiaDataProvider.Instance.GetNhomNguoiDuyetBangGiaInfor(bgct.MaSanPham, bgct.DonGiaChuaVAT, bgct.GiaNhapHDCuoi,
                                                                                                        bgct.TienChietKhauQK, bgct.TienKhuyenMai, bgct.TyLeLNBQ);
            if (nnd != null)
            {
                bgct.IdNhomDuyet = nnd.IdNhomNguoiDung;
                bgct.NhomDuyet = nnd.TenNhomNguoiDung;
            }
            else
            {
                bgct.IdNhomDuyet = 0;
                bgct.NhomDuyet = "Chưa phân nhóm duyệt";
            }

            //tinh thuong nhan vien
            bgct.TyLeThuong = (bgct.DonViDoanhThu != 0 ? bgct.DonGiaCoVAT * bgct.TrongSoDoanhThu / bgct.DonViDoanhThu : 0) +
                              (bgct.DonViLoiNhuan != 0
                                   ? (bgct.DonGiaChuaVAT - bgct.TienChietKhau - bgct.TienKhuyenMai -
                                      bgct.GiaTonKhoBQ) *
                                     bgct.TrongSoLoiNhuan / bgct.DonViLoiNhuan
                                   : 0) +
                              (bgct.DonViKhoanTon != 0
                                   ? bgct.TonKho * bgct.GiaTonKhoBQ * bgct.TrongSoKhoanTon / bgct.DonViKhoanTon
                                   : 0);


            if (bgct.DonGiaChuaVAT > bgct.GiaMax || bgct.DonGiaChuaVAT<bgct.GiaMin)
            {
                //Common.SetGridViewRowErrorStyle(dgvSanPham.CurrentRow);
                bgct.DaDuyet = 0;
            }
            else
            {
                //Common.SetGridViewRowStyle(dgvSanPham.CurrentRow);
                bgct.DaDuyet = 1;
                
            }
            //update lai datagrid
            //((BindingList<BangGiaChiTietInfor>)dgvSanPham.DataSource).ResetBindings();
            //UpdateTongLoiNhuan();                   
        }
                    
        private void UpdateTongLoiNhuan()
        {
            double tongLoiNhuan = 0;
            foreach (BangGiaChiTietInfor bgChiTiet in  (BindingList<BangGiaChiTietInfor>)gSanPham.DataSource)
            {
                tongLoiNhuan += bgChiTiet.LoiNhuan;
            }
            txtTongLoiNhuan.Text = Common.Double2Str(tongLoiNhuan);
        }

        private void frm_BangGia_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAllBangGia();
                //gan bang gia hien tai
                if (bangGia != null)
                {
                    LoadIndexBG();
                }
                else if (liBangGia.Count > 0)
                {
                    IndexBG = 0;
                    bangGia = liBangGia[IndexBG];
                }
                //hien thi thong tin bang gia hien tai
                LoadBangGiaInfor();
                //Thiet lap trang thai item
                setEDItems();
                setEDFunctions();
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        /// <summary>
        /// Load all bảng giá chưa duyệt và có item cần duyệt của NSD
        /// </summary>
        private void LoadAllBangGia()
        {
            liBangGia = BangGiaDataProvider.Instance.LoadAllBGChuaDuyetByNND(nguoiDung.IdNhomNguoiDung);
            if (liBangGia.Count > 0)
                tsbInfors.Text = string.Format("Có {0} bảng giá cần duyệt", liBangGia.Count);
            else
                tsbInfors.Text = "";
        }
        private void LoadIndexBG()
        {
            if (bangGia != null && liBangGia != null)
            {
                for (int i = 0; i < liBangGia.Count; i++)
                {
                    if (liBangGia[i].IdBangGia == bangGia.IdBangGia)
                    {
                        IndexBG = i;
                        break;
                    }
                }
            }            
        }

        private void LoadBangGiaInfor()
        {
            if (bangGia != null)
            {
                //load bang gia infor
                LoadBGHeader();
                LoadBGDetais();               
            }
            else
            {
                ResetBangGiaInfor();
            }

        }

        private void LoadBGHeader()
        {
            Draft = bangGia.Draft;
            txtSoBangGia.Text = bangGia.SoBangGia;
            txtTenTrungTam.Text = bangGia.TenTrungTam;
            chkDaDuyet.Checked = Common.Int2Bool(bangGia.DaDuyet);
            mstNgayLap.Value = bangGia.NgayLap;
            txtNguoiLap.Text = bangGia.NguoiLap;
            txtNgayDuyet.Text = Common.Date2LongString(bangGia.NgayDuyet);
            txtGhiChu.Text = bangGia.GhiChu;
        }

        private void LoadBGDetais()
        {
            bangGia.ListBangGiaChiTiet = BangGiaDataProvider.Instance.GetAllBGChiTietChuaDuyetInfors(bangGia.IdBangGia, nguoiDung.IdNhomNguoiDung);
            gSanPham.DataSource = new BindingList<BangGiaChiTietInfor>(bangGia.ListBangGiaChiTiet)
                                        {
                                            AllowEdit = true,
                                            AllowNew = true,
                                            AllowRemove = true,
                                            RaiseListChangedEvents = true                                            
                                        };
            gvSanPham.Columns["NganhHang"].GroupIndex = 0;
            gvSanPham.ExpandAllGroups();

            UpdateTongLoiNhuan();
            label3.Text = "Tổng số mã cần duyệt: " + bangGia.ListBangGiaChiTiet.Count.ToString();
        }

        /// <summary>
        /// Enable, disable các ô nhập liệu
        /// </summary>
        private void setEDItems()
        {
            //bool status = Updating ? true : false;
            //txtSoBangGia.Enabled = Updating;
            //chkDaDuyet.Enabled = Updating && Common.Int2Bool(nguoiDung.SupperUser);
            //mstNgayLap.Enabled = Updating;
            //txtNguoiLap.Enabled = Updating;
            //txtNgayDuyet.Enabled = Updating;
            //txtNguoiDuyet.Enabled = Updating;
            //txtTenTrungTam.Enabled = Updating;
            DaDuyet.OptionsColumn.AllowEdit = Updating;
            chkChonDuyet.Enabled = Updating;
            txtGhiChu.Enabled = Updating;
        }
        /// <summary>
        /// Enable, disable các menu chức năng: Add, Save, Updade,...
        /// </summary>
        private void setEDFunctions()
        {
            btnTruoc.Enabled = IndexBG > 0;// ? true : false;
            btnSau.Enabled = IndexBG < (liBangGia.Count - 1);// ? true : false;
            btnSua.Enabled = !Updating && (liBangGia.Count > 0);
            //btnCapNhat.Enabled = Updating;
            btnConfirm.Enabled = Updating;
            //btnTimKiem.Enabled = !Updating;
            btnIn.Enabled = !Updating && (liBangGia.Count > 0);
            btnExport.Enabled = !Updating && (liBangGia.Count > 0);

            groupBox2.Text = String.Format("Thông tin chung: Chính sách thứ [{0}]/[{1}]", IndexBG + 1, liBangGia.Count);
        }

        private void frm_BangGia_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Common.LogAction("Đóng form", "Đóng form " + this.Name, Declare.IdKho);
        }


        private void ResetBangGiaInfor()
        {
            txtSoBangGia.ResetText();
            chkDaDuyet.Checked = false;
            mstNgayLap.Value = CommonProvider.Instance.GetSysDate();
            txtNguoiLap.Text = nguoiDung.TenNhanVien;
            txtNgayDuyet.ResetText();
            txtTenTrungTam.ResetText();
            txtGhiChu.ResetText();
            label3.ResetText();
            gSanPham.DataSource = null;
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                //if (!ValidEditBangGia())
                //{
                //    MessageBox.Show("Bảng giá này đã được xác nhận, không thể sửa được!");
                //}
                //else
                //{
                    IsAdded = false;
                    Updating = true;
                    setEDItems();
                    setEDFunctions();
                //}
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi thao tác\n" + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi thao tác", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }   

            //g1Sua = true;
            //KhoiTao();
            //HienCapNhat(true);
        }

        private bool ValidEditBangGia()
        {
            if (bangGia.IdBangGia > 0 && Draft ==0)//bang gia da xac nhan
            {
                return false;
            }
            return true;
        }

        private bool ValidBangGiaInfor()
        {
            //Kiem tra thong tin day du
            //if (!ut.isStringNotEmpty(txtSoBangGia.Text))
            //{
            //    MessageBox.Show("Số bảng giá chưa có.Xin mời nhập!");
            //    txtSoBangGia.Focus();
            //    return false;
            //}

            ////Kiem tra trung So bang gia
            //if (BangGiaDataProvider.Instance.ExistBangGia(txtSoBangGia.Text.Trim(), bangGia.IdBangGia))
            //{
            //    MessageBox.Show("Số bảng giá đã tồn tại. Mời nhập lại!");
            //    txtSoBangGia.Focus();
            //    return false;
            //}
            if (gvSanPham.RowCount==0)
            {
                MessageBox.Show("Bảng giá không có dữ liệu. Mời nhập lại!");
                return false;                
            }
            return true;
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            try
            {
                if (IndexBG < liBangGia.Count - 1)
                {
                    if (Updating)
                    {
                        if (MessageBox.Show("Dữ liệu đang cập nhật, bạn có muốn hủy bỏ không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                            return;
                    }

                    IndexBG++;
                    IsAdded = false;
                    //IdBangGia = liBangGia[IndexBG].IdBangGia;
                    bangGia = liBangGia[IndexBG];
                    LoadBangGiaInfor();

                    Updating = false;
                    setEDItems();
                    setEDFunctions();
                }            
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi thao tác\n" + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi thao tác", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }            
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            try
            {
                if (IndexBG > 0)
                {
                    if (Updating)
                    {
                        if (MessageBox.Show("Dữ liệu đang cập nhật, bạn có muốn hủy bỏ không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                            return;
                    }

                    IndexBG--;
                    IsAdded = false;
                    //IdBangGia = liBangGia[IndexBG].IdBangGia;
                    bangGia = liBangGia[IndexBG];
                    LoadBangGiaInfor();

                    Updating = false;
                    setEDItems();
                    setEDFunctions();
                }
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi thao tác\n" + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi thao tác", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }


        private void sExportToExcel(int LuaChon)
        {

            //Cursor.Current = Cursors.WaitCursor; 
            ////Tao thu muc C:\Temp neu chu co
            //string tmpDir=Declare.TempDirectory;
            //if (!Directory.Exists(tmpDir))
            //    Directory.CreateDirectory(tmpDir);
            //string FileName = string.Format(@"{1}\BangGia{0}.xls", DateTime.Now.Ticks, tmpDir);
            //string FileTemplate = string.Format(@"{0}\MauBangGia.xls", Application.StartupPath + "\\Temp");
            //string kq;
            //if (LuaChon==1)
            //    kq=clsExcel.ExportToExcel(g1BG,FileName,FileTemplate,"","",0);
            //else
            //    kq = clsExcel.ExportToExcel(g1BG, FileName, FileTemplate, txtMaSP.Text, txtTenSP.Text, ut.getInt(cboNganh.SelectedValue));
            //Cursor.Current = Cursors.Default;
            //if (kq != "")
            //{
            //    if (MessageBox.Show("Đã hoàn thành Export. File được export tại '" + kq + "'. Bạn có muốn mở file này không (Yes/No)?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //        Process.Start(FileName);
            //}
            //else
            //    MessageBox.Show("Lỗi Export ra excel!");

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (Updating)
            {
                if (MessageBox.Show("Dữ liệu đang cập nhật, bạn có muốn hủy bỏ không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            }
            search();
        }
        private void search()
        {
            frmCS_TimKiem_BangGia frm = new frmCS_TimKiem_BangGia(2);
            if (frm.ShowDialog() == DialogResult.OK && frm.BangGia != null)
            {
                bangGia = frm.BangGia;
                LoadIndexBG();
                //hien thi thong tin bang gia hien tai
                LoadBangGiaInfor();
                //Thiet lap trang thai item
                Updating = false;
                setEDItems();
                setEDFunctions();
            }     
        }

        private void btnExport1_Click(object sender, EventArgs e)
        {
            sExportToExcel(1);
        }

        private void btnExport2_Click(object sender, EventArgs e)
        {
            sExportToExcel(2);
        }

        private void frm_BangGia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3 && btnTruoc.Enabled)
                this.btnTruoc_Click(sender, e);
            else if (e.KeyCode == Keys.F4 && btnSau.Enabled)
                this.btnSau_Click(sender, e);
            else if (e.KeyCode == Keys.F6 && btnSua.Enabled)
                this.btnSua_Click(sender, e);
            else if (e.KeyCode == Keys.F2 && btnConfirm.Enabled)
            {
                txtSoBangGia.Focus();
                this.btnConfirm_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F10 && btnTimKiem.Enabled)
                this.btnTimKiem_Click(sender, e);
            else if (e.KeyCode == Keys.F12 && btnDong.Enabled)
                this.btnDong_Click(sender, e);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sImport(bool pAddNew)
        {
            //BangGia BG=new BangGia();
            //if (!pAddNew)
            //    BG = g1BG;
            //frm_BangGia_Import frm = new frm_BangGia_Import(BG);
            //int kq = (int)frm.ShowDialog();
            //if (kq == (int)DialogResult.OK)
            //{
            //    g1BG = BG;
            //    g1Sua = !pAddNew;
            //    HienCapNhat(true);
            //    if (!g1Sua)
            //    {
            //        txtSoBangGia.Text = LaySoPhieu();
            //        //txtNguoiKy.Text = "";
            //        mstNgayHieuLuc.Value = DateTime.Today;
            //        mstHanHieuLuc.Value = DateTime.Today;
            //        txtGhiChu.Text = "";
            //        txtMaSP.Text = ""; txtTenSP.Text = "";
            //    }
            //    dgvSanPham.DataSource = null;
            //    dgvSanPham.DataSource =g1BG.LstSanPham;
            //    dgvSanPham.AllowUserToAddRows = true;
            //    dgvSanPham.AllowUserToDeleteRows = true;
            //    //btnThemCT.Visible = true;
            //    //cmdXoaChiTiet.Visible = true;
            //    dgvSanPham.Refresh();
            //    foreach (DataGridViewRow r in dgvSanPham.Rows)
            //    {
            //        r.Cells["colVAT"].Value = "Không chịu thuế";
            //    }
            //}
        }
        

        private bool ExistMaSanPham(string maSP)
        {
            foreach (BangGiaChiTietInfor bg in (BindingList<BangGiaChiTietInfor>)gSanPham.DataSource)
            {
                if (bg.MaSanPham.Equals(maSP))
                    return true;
            }
            return false;
        }


        private void btnIn_Click(object sender, EventArgs e)
        {
            gSanPham.ShowPrintPreview();
            //try
            //{
            //    Cursor.Current = Cursors.WaitCursor;
            //    DataSet Ds = ut.getDataSet("Select MaSanPham,TenSanPham,1000 as GiaBan, 'KM' as KhuyenMai FROM tbl_SanPham Where 1=0", "vBC_InBangGia");
            //    foreach (DataGridViewRow gr in dgvSanPham.Rows)
            //    {
            //        DataRow r = Ds.Tables[0].NewRow();
            //        r["MaSanPham"] = gr.Cells["colMaSanPham"].Value.ToString();
            //        r["TenSanPham"] = gr.Cells["colTenSanPham"].Value.ToString();
            //        r["GiaBan"] = ut.getDouble(gr.Cells["colThanhTien"].Value);
            //        r["KhuyenMai"] = gr.Cells["colKhuyenMai"].Value.ToString();
            //        Ds.Tables[0].Rows.Add(r);
            //    }
            //    rpt_BC_InBangGia rpt = new rpt_BC_InBangGia();
            //    rpt.SetDataSource(Ds);
            //    ParameterFields myParams = new ParameterFields();
            //    frm_rptPhuong frm = new frm_rptPhuong(rpt, myParams);
            //    Cursor.Current = Cursors.Default;
            //    frm.ShowDialog();
            //}
            //catch (System.Exception ex)
            //{
            //    Cursor.Current = Cursors.Default;
            //}
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            try
            {
                //Draft = 0;
                if (UpdateBangGia())
                {
                    LoadAllBangGia();
                    if (liBangGia.Count > 0)
                    {
                        if (IndexBG == liBangGia.Count)
                            IndexBG = liBangGia.Count - 1;
                        bangGia = liBangGia[IndexBG];
                    }
                    //hien thi thong tin bang gia hien tai
                    LoadBangGiaInfor();
                    
                    Updating = false;
                    setEDItems();
                    setEDFunctions();
                    if (liBangGia.Count==0)
                    {
                        txtNguoiLap.ResetText();
                        groupBox2.Text = "Thông tin chung:";
                    }                    
                }
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi thao tác\n" + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi thao tác", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }   
        }

        private void gvSanPham_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (gvSanPham.FocusedRowHandle < 0) return;
            if (e.Column.FieldName == "DonGiaCoVAT" || e.Column.FieldName == "GiaBanBuon" || e.Column.FieldName == "ThuongNong")
            {
                BangGiaChiTietInfor bgct = (BangGiaChiTietInfor)gvSanPham.GetRow(gvSanPham.FocusedRowHandle);
                UpdateDataValue(bgct);
                UpdateTongLoiNhuan();
            }
        }

        private void btnTimBangGia_Click(object sender, EventArgs e)
        {
            if (liBangGia == null) return;
            bool found = false;
            for (int i=0; i<liBangGia.Count; i++)
            {
                if (liBangGia[i].SoBangGia.Equals(txtSoBangGia.Text))
                {
                    found = true;
                    IndexBG = i;
                    bangGia = liBangGia[i];
                    LoadBangGiaInfor();
                    break;
                }
            }
            if (!found)
            {
                MessageBox.Show("Không có bảng giá này");
                if (!Updating && bangGia!= null)
                    txtSoBangGia.Text = bangGia.SoBangGia;
            }
        }

        private void chkChonDuyet_CheckedChanged(object sender, EventArgs e)
        {
            foreach (BangGiaChiTietInfor bgct in (BindingList<BangGiaChiTietInfor>)gSanPham.DataSource)
            {
                bgct.DaDuyet = Common.Bool2Int(chkChonDuyet.Checked);
            }
            ((BindingList<BangGiaChiTietInfor>) gSanPham.DataSource).ResetBindings();
        }

        private void tsbInfors_Click(object sender, EventArgs e)
        {
            btnTimBangGia_Click(sender, e);
        }

        private void btnChinhSachGia_Click(object sender, EventArgs e)
        {
            LoadChinhSachGia();
        }

        private void gvSanPham_DoubleClick(object sender, EventArgs e)
        {
            LoadChinhSachGia();
        }
        private void LoadChinhSachGia()
        {
            try
            {
                BangGiaChiTietInfor bgct = (BangGiaChiTietInfor)gvSanPham.GetRow(gvSanPham.FocusedRowHandle);

                List<BangGiaChinhSachInfor> liChinhSach =
                    ChinhSachDataProvider.Instance.GetAllChinhSachDaApDung(bangGia.IdTrungTam, bgct.MaSanPham,
                                                                           mstNgayLap.Value);

                //if (Updating)
                //    liChinhSach = ChinhSachDataProvider.Instance.GetAllChinhSachApDung(bangGia.IdTrungTam, -1, 0, bgct.MaSanPham);
                //else
                //    liChinhSach = ChinhSachDataProvider.Instance.GetAllChinhSachDaApDung(bangGia.IdTrungTam, bgct.MaSanPham, bangGia.NgayCapNhat);
                if (liChinhSach != null && liChinhSach.Count > 0)
                {
                    frmCS_BangGia_ViewKhuyenMai frm = new frmCS_BangGia_ViewKhuyenMai(liChinhSach, bgct);
                    frm.ShowDialog();
                }
            }
            catch { }
        }
    }
}