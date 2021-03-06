using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using QLBanHang.Modules.BanHang.Reports;
using CrystalDecisions.Shared;
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
using QLBH.Core.Providers;
//

namespace QLBanHang.Modules.BanHang
{
    public partial class frmCS_DuyetBangGia : DevExpress.XtraEditors.XtraForm
    {
        #region declare
        private bool Updating = false;//false: chua sua, tao moi; 1:dang sua, tao moi
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private BangGiaInfor bangGia = null;
        #endregion

        public frmCS_DuyetBangGia()
        {
            InitializeComponent();
            Common.LoadStyle(this);  
            bangGia = new BangGiaInfor();
        }
        public frmCS_DuyetBangGia(BangGiaInfor bangGia)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.bangGia = bangGia;
        }

        private bool UpdateBangGia()
        {
            int truocUpdate = bangGia.DaDuyet;
            lblStatus.Text = "Đang duyệt bảng giá .....";
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

                    //dong bo gia website
                    bangGia = BangGiaDataProvider.Instance.GetBangGiaInfor(bangGia.IdBangGia);
                    if (truocUpdate == 0 && bangGia.DaDuyet == 1)//bang gia vua duoc duyet => day len website
                    {
                        if (MessageBox.Show("Bảng giá đã duyệt thành công. Bạn có muốn đẩy giá lên website không?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            lblStatus.Text = "Đang đồng bộ giá lên website .....";
                            DayGia2WebSite(bangGia);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật bảng giá thành công!");
                    }
                    lblStatus.Text = "Đã duyệt xong bảng giá";

                    this.Close();
                }
            }
            catch (Exception)
            {
                ConnectionUtil.Instance.RollbackTransaction();
                throw;
            }
            Cursor.Current = Cursors.Default;
            return false;
        }

        private void DayGia2WebSite(BangGiaInfor bangGia)
        {
            List<BangGiaBanChiTietBCInfor> liBGiaCTiet = BangGiaDataProvider.Instance.GetAllBangGiaChiTietTon(bangGia.IdBangGia);
            string[] arrTT = bangGia.ListIdTrungTam.Split(",".ToCharArray());
            DongBoGiaWebsite sync = new DongBoGiaWebsite(/*bangGia.IdTrungTam*/Common.IntValue(arrTT[0]), bangGia.NgayLap, liBGiaCTiet);
            sync.BangGiaSync();
        }

        private void UpdateBangGiaDetails()
        {
            gvSanPham.RefreshData(); 
            //them tung cai moi;
            if (bangGia.ListBangGiaChiTiet != null)
            {
                foreach (BangGiaChiTietInfor bgChiTiet in bangGia.ListBangGiaChiTiet)
                {
                    //if (!bgChiTiet.IsOrigin)//voi nhung chi tiet them hoac sua
                    //{
                        //cap nhat bang gia chi tiet
                        bgChiTiet.IdBangGia = bangGia.IdBangGia;
                        bgChiTiet.NguoiCapNhat = nguoiDung.TenDangNhap;// nguoiDung.TenNhanVien + "(" + nguoiDung.TenDangNhap + ")";
                        BangGiaDataProvider.Instance.UpdateBangGiaChiTiet(bgChiTiet);
                    //}
                }
                //duyet bang gia
                BangGiaDataProvider.Instance.DuyetBangGia(bangGia);        
            }
        }

        private void UpdateBangGiaHeader()
        {
            bangGia.GhiChu = txtGhiChu.Text;

            bangGia.NguoiCapNhat = nguoiDung.TenDangNhap;// nguoiDung.TenNhanVien + "(" + nguoiDung.TenDangNhap + ")";
            BangGiaDataProvider.Instance.UpdateBangGia(bangGia);
        }

        private void UpdateAllDataValue()
        {
            double tongLoiNhuan = 0;
            if (gSanPham.DataSource == null) return;
            string[] arIdTrungTam = bangGia.ListIdTrungTam.Split(",".ToCharArray());
            string khuyemai = "";
            int iddkmua = 0;
            foreach (BangGiaChiTietInfor bgct in (BindingList<BangGiaChiTietInfor>)gSanPham.DataSource)
            {
                bgct.TienKhuyenMai = CommonFuns.Instance.GetTienKhuyenMai(Common.IntValue(arIdTrungTam[0]), bgct.IdSanPham, bgct.MaSanPham,
                                                                          mstNgayLap.Value,
                                                                          Common.MaxValues(bgct.DonGiaCoVAT,
                                                                                           bgct.GiaBanBuon,
                                                                                           bgct.GiaBanDemo,
                                                                                           bgct.GiaNhapDemoCuoi,
                                                                                           bgct.GiaTonKhoBQ,
                                                                                           bgct.GiaNhapHDCuoi),
                                                                          bgct.DonGiaCoVAT, bgct.TyLeVAT, ref khuyemai, ref iddkmua);
                bgct.IdDKMua = iddkmua;
                bgct.KhuyenMai = khuyemai;
                bgct.GiaMin = (bgct.GiaNhapHDCuoi - bgct.TienChietKhauQK + bgct.TienKhuyenMai) *
                              (1 + bgct.TyLeLNBQ * (1 - bgct.DungSaiMin / 100) / 100);
                bgct.GiaMax = (bgct.GiaNhapHDCuoi - bgct.TienChietKhauQK + bgct.TienKhuyenMai) *
                              (1 + bgct.TyLeLNBQ * (1 + bgct.DungSaiMax / 100) / 100);
                bgct.GiaBanAnToan = (bgct.GiaNhapHDCuoi - bgct.TienChietKhauQK + bgct.TienKhuyenMai) *
                                    (1 + bgct.TyLeLNBQ / 100);
                bgct.DonGiaChuaVAT = bgct.DonGiaCoVAT / (1 + bgct.TyLeVAT / 100) / (1 - bgct.TyLeChietKhau / 100);
                bgct.TienChietKhau = bgct.DonGiaChuaVAT * bgct.TyLeChietKhau / 100;
                bgct.TienVAT = bgct.DonGiaCoVAT - bgct.DonGiaChuaVAT + bgct.TienChietKhau;
                bgct.LoiNhuan = bgct.DonGiaChuaVAT - bgct.GiaNhapHDCuoi + bgct.TienChietKhauQK - bgct.TienKhuyenMai - bgct.ThuongNong;// * bgct.SoLuongBanBQ * (1 + bgct.DungSaiSLBQ / 100);
                bgct.LoiNhuanTon = bgct.DonGiaChuaVAT - bgct.GiaTonKhoBQ + bgct.TienChietKhauQK - bgct.TienKhuyenMai - bgct.ThuongNong;
                //bgct.GiaNiemYet = bgct.DonGiaCoVAT;
                //bgct.GiaWebSite = bgct.DonGiaCoVAT;
                double giaBanBuonChuaVat = bgct.GiaBanBuon / (1 + bgct.TyLeVAT / 100) / (1 - bgct.TyLeChietKhau / 100);
                bgct.LoiNhuanBB = giaBanBuonChuaVat - bgct.GiaNhapHDCuoi + bgct.TienChietKhauQK - bgct.TienKhuyenMai - bgct.ThuongNong;// * bgct.SoLuongBanBQ * (1 + bgct.DungSaiSLBQ / 100);
                bgct.LoiNhuanTon = giaBanBuonChuaVat - bgct.GiaTonKhoBQ + bgct.TienChietKhauQK - bgct.TienKhuyenMai - bgct.ThuongNong;
                double giaBanDemoChuaVat = bgct.GiaBanDemo / (1 + bgct.TyLeVAT / 100) / (1 - bgct.TyLeChietKhau / 100);
                bgct.LoiNhuanDemo = giaBanDemoChuaVat - bgct.GiaNhapDemoCuoi - bgct.ThuongNong;// * bgct.SoLuongBanBQ * (1 + bgct.DungSaiSLBQ / 100);

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

                if (bgct.DonGiaChuaVAT > bgct.GiaMax || bgct.DonGiaChuaVAT < bgct.GiaMin)
                {
                    //Common.SetGridViewRowErrorStyle(dgvSanPham.CurrentRow);
                    bgct.DaDuyet = 0;
                }
                else
                {
                    //Common.SetGridViewRowStyle(dgvSanPham.CurrentRow);
                    bgct.DaDuyet = 1;
                }
                //update loi nhuan
                tongLoiNhuan += bgct.LoiNhuan;
            }
            //((BindingList<BangGiaChiTietInfor>)dgvSanPham.DataSource).ResetBindings();

            txtTongLoiNhuan.Text = Common.Double2Str(tongLoiNhuan);            
        }

        private void UpdateDataValue(BangGiaChiTietInfor bgct)
        {
            if (bgct == null) return;
            string[] arIdTrungTam = bangGia.ListIdTrungTam.Split(",".ToCharArray());
            string khuyemai = "";
            int iddkmua = 0;
            bgct.TienKhuyenMai = CommonFuns.Instance.GetTienKhuyenMai(Common.IntValue(arIdTrungTam[0]), bgct.IdSanPham, bgct.MaSanPham,
                                                                      mstNgayLap.Value,
                                                                      Common.MaxValues(bgct.DonGiaCoVAT, bgct.GiaBanBuon,
                                                                                       bgct.GiaBanDemo,
                                                                                       bgct.GiaNhapDemoCuoi,
                                                                                       bgct.GiaTonKhoBQ,
                                                                                       bgct.GiaNhapHDCuoi),
                                                                      bgct.DonGiaCoVAT, bgct.TyLeVAT, ref khuyemai, ref iddkmua);
            bgct.IdDKMua = iddkmua;
            bgct.KhuyenMai = khuyemai;
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
            double giaBanDemoChuaVat = bgct.GiaBanDemo / (1 + bgct.TyLeVAT / 100) / (1 - bgct.TyLeChietKhau / 100);
            bgct.LoiNhuanDemo = giaBanDemoChuaVat - bgct.GiaNhapDemoCuoi - bgct.ThuongNong;// * bgct.SoLuongBanBQ * (1 + bgct.DungSaiSLBQ / 100);

            BangGiaNhomNguoiDuyetInfor nnd = BangGiaDataProvider.Instance.GetNhomNguoiDuyetBangGiaInfor(bgct.MaSanPham, bgct.DonGiaCoVAT, bgct.GiaNhapHDCuoi,
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
                //hien thi thong tin bang gia hien tai
                LoadBangGiaInfor();
                //Thiet lap trang thai item
                Updating = true;
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
            txtSoBangGia.Text = bangGia.SoBangGia;
            txtTenTrungTam.Text = bangGia.ListMaTrungTam;
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
            tsbInfors.Text = "Số mã cần duyệt: " + bangGia.ListBangGiaChiTiet.Count.ToString();
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
            //txtGhiChu.Enabled = Updating;
        }
        /// <summary>
        /// Enable, disable các menu chức năng: Add, Save, Updade,...
        /// </summary>
        private void setEDFunctions()
        {
            //btnCapNhat.Enabled = Updating;
            btnConfirm.Enabled = Updating;
            //btnTimKiem.Enabled = !Updating;
            //btnIn.Enabled = !Updating && (bangGia.IdBangGia > 0);
            //btnExport.Enabled = !Updating && (liBangGia.Count > 0);

            //groupBox2.Text = String.Format("Thông tin chung: Chính sách thứ [{0}]/[{1}]", IndexBG + 1, liBangGia.Count);
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
            gSanPham.DataSource = null;
            tsbInfors.Text = "";
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
                //hien thi thong tin bang gia hien tai
                LoadBangGiaInfor();
                //Thiet lap trang thai item
                Updating = true;
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

            if (e.KeyCode == Keys.F2 && btnConfirm.Enabled)
            {
                txtSoBangGia.Focus();
                this.btnConfirm_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F10 && btnTimKiem.Enabled)
                this.btnTimKiem_Click(sender, e);
            else if (e.KeyCode == Keys.F12 && btnDong.Enabled)
                this.btnDong_Click(sender, e);
            else if (e.KeyCode == Keys.F8 && tsbTuChoi.Enabled)
                this.tsbTuChoi_Click(sender, e);
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
                if (UpdateBangGia())
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                EventLogProvider.Instance.WriteLog(ex.ToString()
                                    + "\nUser: " + nguoiDung.TenDangNhap
                                    + "\nMay: " + Declare.TenMay,
                                    this.Name);
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void gvSanPham_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (gvSanPham.FocusedRowHandle < 0) return;
            if (e.Column.FieldName == "DonGiaCoVAT" || e.Column.FieldName == "GiaBanBuon" || e.Column.FieldName == "GiaBanDemo" || e.Column.FieldName == "ThuongNong")
            {
                BangGiaChiTietInfor bgct = (BangGiaChiTietInfor)gvSanPham.GetRow(gvSanPham.FocusedRowHandle);
                UpdateDataValue(bgct);
                UpdateTongLoiNhuan();
            }
        }

        private void btnTimBangGia_Click(object sender, EventArgs e)
        {
            BangGiaInfor bg = BangGiaDataProvider.Instance.GetBangGiaChuaDuyetInfor(txtSoBangGia.Text, nguoiDung.IdNhomNguoiDung);

            if (bg == null)
            {
                MessageBox.Show("Không có bảng giá này");
                txtSoBangGia.Text = bangGia.SoBangGia;
            }
            else
            {
                bangGia = bg;
                LoadBangGiaInfor();
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
                if (liChinhSach != null && liChinhSach.Count > 0)
                {
                    frmCS_BangGia_ViewKhuyenMai frm = new frmCS_BangGia_ViewKhuyenMai(liChinhSach, bgct);
                    frm.ShowDialog();
                }            
            }
            catch { }
        }

        private void btnAddGhiChu_Click(object sender, EventArgs e)
        {
            if (bangGia != null)
            {
                frmCS_LapBangGia_AddComment frm = new frmCS_LapBangGia_AddComment(bangGia);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    txtGhiChu.Text += frm.Comment;
                }
            }
        }

        private void tsbTuChoi_Click(object sender, EventArgs e)
        {
            if (RejectBangGia())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private bool RejectBangGia()
        {
            bool rs = false;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (ValidBangGiaInfor())
                {
                    bangGia.DaDuyet = (int)TinhTrangDuyetGia.TU_CHOI;
                    bangGia.GhiChu = txtGhiChu.Text;

                    bangGia.NguoiCapNhat = nguoiDung.TenDangNhap;// nguoiDung.TenNhanVien + "(" + nguoiDung.TenDangNhap + ")";
                    BangGiaDataProvider.Instance.UpdateBangGiaDuyet(bangGia);

                    MessageBox.Show("Từ chối duyệt bảng giá thành công!");
                    rs = true;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực hiện: " + ex.ToString());
            }
            Cursor.Current = Cursors.Default;
            return rs;
        }
    }
}