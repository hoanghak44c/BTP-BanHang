using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
    public partial class frmCS_BangGia_ChinhSach : DevExpress.XtraEditors.XtraForm
    {
        #region declare
        List<BangGiaChinhSachInfor> liChinhSach = new List<BangGiaChinhSachInfor>();
        //private int IdBangGia = 0;//id bang gia
        private int IndexBG = 0;//thu tu bang gia
        private int Draft = -1;//-1:chua ton tai; 1-save, 0-confirm
        private bool IsAdded = false;
        private bool Updating = false;//false: chua sua, tao moi; 1:dang sua, tao moi
        private bool isView = false;
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private BangGiaChinhSachInfor chinhSach = null;
        private objGridMarkSelection selector = new objGridMarkSelection();
        private frmCS_TimKiem_ChinhSachGia frmCS = null;
        //private objGridMarkSelection selectorCS = new objGridMarkSelection();
        #endregion

        Utils ut = new Utils();

        public frmCS_BangGia_ChinhSach()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        public frmCS_BangGia_ChinhSach(BangGiaChinhSachInfor chinhSach)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.chinhSach = chinhSach;
        }

        public frmCS_BangGia_ChinhSach(BangGiaChinhSachInfor chinhSach, List<BangGiaChinhSachInfor> liChinhSach, bool isView,frmCS_TimKiem_ChinhSachGia frmCS)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.chinhSach = chinhSach;
            this.liChinhSach = liChinhSach;
            this.isView = isView;
            this.frmCS = frmCS;
        }

        public void HideMenu()
        {
            //toolStrip1.Visible = false;
            toolStrip1.Enabled = false;
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
        private bool UpdateBangGia()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (ValidBangGiaInfor())
                {
                    ConnectionUtil.Instance.BeginTransaction();
                    //update infor
                    UpdateChinhSachTHInfor();
                    //update header
                    UpdateBangGiaHeader();
                    //update shop
                    UpdateBangGiaADShop();
                    //update customer
                    UpdateBangGiaADKhach();
                    //update thoi gian
                    UpdateBangGiaADThoiGian();
                    //update thanh toan
                    UpdateBangGiaADThanhToan();
                    //Update san pham
                    UpdateBangGiaADDKMua();
                    ConnectionUtil.Instance.CommitTransaction();

                    if (IsAdded)
                    {
                        LoadAllBangGia();
                        LoadIndexBG();
                        MessageBox.Show("Thêm mới chính sách giá thành công!");
                    }
                    else
                    {
                        BangGiaChinhSachInfor cs = ChinhSachDataProvider.Instance.GetBangGiaChinhSachInforById(chinhSach.IdChinhSach);
                        chinhSach.DaDuyetTT = cs.DaDuyetTT;
                        txtTrangThai.Text = chinhSach.DaDuyetTT;

                        MessageBox.Show("Cập nhật chính sách giá thành công!");
                    }
                        
                    //LoadAllBangGia();

                    return true;                    
                }
            }
            catch (Exception)
            {
                ConnectionUtil.Instance.RollbackTransaction();
                if (IsAdded && chinhSach != null)
                    chinhSach.IdChinhSach = 0;              
                throw;
            }
            Cursor.Current = Cursors.Default;
            return false;
        }

        private void UpdateChinhSachTHInfor()
        {
            chinhSach.ChinhSachAD = chinhSach != null ? chinhSach.GhiChu : txtGhiChu.Text;
            //update sieu thị AD
            chinhSach.SieuThiAD = "";
            if (chinhSach.ListBangGiaADShop != null)
            {
                foreach (BangGiaADShopInfor bgShop in chinhSach.ListBangGiaADShop)
                {
                    chinhSach.SieuThiAD += bgShop.TenTrungTam + (!String.IsNullOrEmpty(bgShop.MaKho) ? String.Format("({0});", bgShop.MaKho) : "") + "\r\n";
                }
            }

            //update doi tuong AD
            chinhSach.DoiTuongAD = "";
            if (chinhSach.ListBangGiaADKhach != null)
            {
                foreach (BangGiaADKhachInfor bgKhach in chinhSach.ListBangGiaADKhach)
                {
                    chinhSach.DoiTuongAD += bgKhach.TenLoaiDT + (!String.IsNullOrEmpty(bgKhach.MaDoiTuong) ? String.Format("({0});", bgKhach.MaDoiTuong) : "") + "\r\n";
                }
            }

            //update thoi gian AD
            chinhSach.ThoiGianAD = String.Format("HieuLuc: {0}-{1}", chinhSach.NgayHieuLuc.ToString(),
                                                  chinhSach.HanHieuLuc.ToString());
            if (chinhSach.ListBangGiaADThoiGian != null)
            {
                foreach (BangGiaADTimeInfor bgTime in chinhSach.ListBangGiaADThoiGian)
                {
                    chinhSach.ThoiGianAD += !String.IsNullOrEmpty(bgTime.DayOfMonth) ? String.Format("DayOfMonth: {0} |", bgTime.DayOfMonth) : "";
                    chinhSach.ThoiGianAD += !String.IsNullOrEmpty(bgTime.DayOfWeek) ? String.Format("DayOfWeek: {0} |", bgTime.DayOfWeek) : "";
                    chinhSach.ThoiGianAD += bgTime.Thu != 0 ? String.Format("Thu: {0} |", bgTime.Thu) : "";
                    chinhSach.ThoiGianAD += bgTime.Ngay != 0 ? String.Format("Ngay: {0} |", bgTime.Ngay) : "";
                    chinhSach.ThoiGianAD += !String.IsNullOrEmpty(bgTime.GioTu) ? String.Format("TuGio: {0} |", bgTime.GioTu) : "";
                    chinhSach.ThoiGianAD += !String.IsNullOrEmpty(bgTime.GioDen) ? String.Format("DenGio: {0} |", bgTime.GioDen) : "" + "\r\n";
                }
            }

            //update thanh toan;
            chinhSach.ThanhToanAD = "";
            if (chinhSach.ListBangGiaADThanhToan != null)
            {
                foreach (BangGiaADBankInfor bgBank in chinhSach.ListBangGiaADThanhToan)
                {
                    chinhSach.ThanhToanAD += bgBank.HinhThucThanhToan + (!String.IsNullOrEmpty(bgBank.TenNganHang) ? String.Format("(NHangTToan:{0});", bgBank.TenNganHang) : "");
                    chinhSach.ThanhToanAD += !String.IsNullOrEmpty(bgBank.TenNganHangPH) ? String.Format("(NHangPHanh:{0});", bgBank.TenNganHangPH) : "";
                    chinhSach.ThanhToanAD += (!String.IsNullOrEmpty(bgBank.ThoiHanThanhToan) ? String.Format("(THanTToan:{0});", bgBank.ThoiHanThanhToan) : "");
                    chinhSach.ThanhToanAD += (bgBank.TyLeThanhToan == 0 ? String.Format("(TLeTToan:{0}%);", bgBank.TyLeThanhToan) : "") + "\r\n";
                }
            }

            //update mota khac
            chinhSach.MotaKhac = "";
            chinhSach.MotaKhac += (chinhSach.DuyNhatCMND == 1 ? "Duy nhất CMND;" : "");
            chinhSach.MotaKhac += (chinhSach.DuyNhatSDT == 1 ? "Duy nhất Số ĐT;" : "");
            chinhSach.MotaKhac += (chinhSach.GiaTriHDToiThieu != 0 ? String.Format("Giá trị HĐ tối thiểu: {0};",Common.Double2Str(chinhSach.GiaTriHDToiThieu)) : "");
            chinhSach.MotaKhac += (chinhSach.ThanhToanToiThieu != 0 ? String.Format("Thanh toán tối thiểu: {0};",Common.Double2Str(chinhSach.ThanhToanToiThieu)) : "");
            chinhSach.MotaKhac += (chinhSach.GiaTriDHDaMua != 0 ? String.Format("Giá trị HĐ đã mua: {0};",Common.Double2Str(chinhSach.GiaTriDHDaMua)) : "");
            chinhSach.MotaKhac += (chinhSach.ThoiHanMua != 0 ? String.Format("Thời hạn đã mua: {0} ngày;",Common.Double2Str(chinhSach.ThoiHanMua)) : "");
        }

        private void UpdateBangGiaADShop()
        {
            //xoa het cai cu
            ChinhSachDataProvider.Instance.DeleteBangGiaADShop(chinhSach.IdChinhSach);

            //them tung cai moi;
            if (chinhSach.ListBangGiaADShop != null)
            {
                foreach (BangGiaADShopInfor bgShop in chinhSach.ListBangGiaADShop)
                {
                    bgShop.IdChinhSach = chinhSach.IdChinhSach;
                    ChinhSachDataProvider.Instance.InsertBangGiaADShop(bgShop);
                }                
            }
        }
        private void UpdateBangGiaADKhach()
        {
            //xoa het cai cu
            ChinhSachDataProvider.Instance.DeleteBangGiaADKhach(chinhSach.IdChinhSach);

            //them tung cai moi;
            if (chinhSach.ListBangGiaADKhach != null)
            {
                foreach (BangGiaADKhachInfor bgKhach in chinhSach.ListBangGiaADKhach)
                {
                    bgKhach.IdChinhSach = chinhSach.IdChinhSach;
                    ChinhSachDataProvider.Instance.InsertBangGiaADKhach(bgKhach);
                }
            }
        }

        private void UpdateBangGiaADThoiGian()
        {
            //xoa het cai cu
            ChinhSachDataProvider.Instance.DeleteBangGiaADThoiGian(chinhSach.IdChinhSach);

            //them tung cai moi;
            if (chinhSach.ListBangGiaADThoiGian != null)
            {
                foreach (BangGiaADTimeInfor bgTime in chinhSach.ListBangGiaADThoiGian)
                {
                    bgTime.IdChinhSach = chinhSach.IdChinhSach;
                    ChinhSachDataProvider.Instance.InsertBangGiaADThoiGian(bgTime);
                }
            }
        }

        private void UpdateBangGiaADThanhToan()
        {
            //xoa het cai cu
            ChinhSachDataProvider.Instance.DeleteBangGiaADThanhToan(chinhSach.IdChinhSach);

            //them tung cai moi;
            if (chinhSach.ListBangGiaADThanhToan != null)
            {
                foreach (BangGiaADBankInfor bgBank in chinhSach.ListBangGiaADThanhToan)
                {
                    bgBank.IdChinhSach = chinhSach.IdChinhSach;
                    ChinhSachDataProvider.Instance.InsertBangGiaADThanhToan(bgBank);
                }
            }
        }

        private void UpdateBangGiaHeader()
        {
            chinhSach.Draft = Draft;
            chinhSach.SoChinhSach = txtSoChinhSachGia.Text;
            chinhSach.NgayLap = mstNgayLap.Value;
            chinhSach.NguoiLap = txtNguoiLap.Text;
            chinhSach.GhiChu = txtGhiChu.Text;
            chinhSach.DoUuTien = Common.IntValue(nudDoUuTien.Value);
            chinhSach.LoaiDoiTuong = Common.Bool2Int(chkOnline.Checked);
            chinhSach.MacDinh = Common.Bool2Int(chkDefault.Checked);

            chinhSach.NgayHieuLuc = mstNgayHieuLuc.Value;
            chinhSach.HanHieuLuc = mstHanHieuLuc.Value;
            chinhSach.SoKhachDauNgay = Common.IntValue(txtSoKhachDauNgay.Text);

            chinhSach.ThanhToanToiThieu = Common.DoubleValue(txtThanhToanToiThieu.Text);
            chinhSach.SoTienTToanToiThieu = Common.DoubleValue(txtSoTienTToanTThieu.Text);

            chinhSach.DuyNhatCMND = Common.Bool2Int(chkDuyNhatCMND.Checked);
            chinhSach.DuyNhatSDT = Common.Bool2Int(chkDuyNhatSDT.Checked);
            chinhSach.GioiTinh = cboGioiTinh.SelectedIndex;
            chinhSach.DoTuoiTu = Common.IntValue(txtTuoiTu.Text.Trim());
            chinhSach.DoTuoiDen = Common.IntValue(txtTuoiDen.Text.Trim());
            chinhSach.GiaTriHDToiThieu = Common.DoubleValue(txtGiaTriHDToiThieu.Text.Trim());
            chinhSach.GiaTriDHDaMua = Common.DoubleValue(txtGiaTriDHDaMua.Text.Trim());
            chinhSach.IdNgheNghiep = Common.IntValue(cboNgheNghiep.SelectedValue);
            chinhSach.IdTinh = Common.IntValue(cboTinh.SelectedValue);
            chinhSach.IdHuyen = Common.IntValue(cboHuyen.SelectedValue);
            
            if (chinhSach.IdChinhSach == 0)
            {
                chinhSach.NguoiTao = nguoiDung.TenDangNhap;
                chinhSach.IdChinhSach = ChinhSachDataProvider.Instance.InsertBangGiaChinhSach(chinhSach);
            }
            else
            {
                chinhSach.NguoiCapNhat = nguoiDung.TenDangNhap;
                ChinhSachDataProvider.Instance.UpdateBangGiaChinhSach(chinhSach);
            }

        }

        private void UpdateBangGiaADDKMua()
        {
            //them tung cai moi;
            if (chinhSach.ListBangGiaADDKMua != null)
            {
                int stt = 0;
                //xoa khuyen mai cu
                KhuyenMaiDataProvider.Instance.DeleteBGKhuyenMaiByChinhSach(chinhSach.IdChinhSach);

                List<BangGiaADDKMuaInfor> oldListDKM = KhuyenMaiDataProvider.Instance.GetAllBangGiaADDKMuaInfors(chinhSach.IdChinhSach);
                foreach (BangGiaADDKMuaInfor dkm in oldListDKM)
                {
                    if (!chinhSach.ListBangGiaADDKMua.Exists(delegate(BangGiaADDKMuaInfor dk)
                                                                 {
                                                                     return dk.IdDKMua == dkm.IdDKMua;
                                                                 }))
                        KhuyenMaiDataProvider.Instance.DeleteBangGiaADDKMua(dkm);
                }

                foreach (BangGiaADDKMuaInfor bgDKMua in chinhSach.ListBangGiaADDKMua)
                {
                    if (!bgDKMua.IsOrigin || IsAdded)//voi nhung chi tiet them hoac sua
                    {
                        //cap nhat bang gia chi tiet
                        bgDKMua.IdChinhSach = chinhSach.IdChinhSach;
                        if (bgDKMua.IdDKMua == 0 || IsAdded)
                            bgDKMua.IdDKMua = KhuyenMaiDataProvider.Instance.InsertBangGiaADDKMua(bgDKMua);
                        else
                            KhuyenMaiDataProvider.Instance.UpdateBangGiaADDKMua(bgDKMua);

                        //cap nhat khuyen mai
                        //KhuyenMaiDataProvider.Instance.DeleteBGKhuyenMaiByDKMua(bgDKMua.IdDKMua);
                        //them khuyen mai moi);
                        if (bgDKMua.ListKhuyenMai != null)
                        {
                            foreach (BangGiaADKhuyenMaiInfor bgkm in bgDKMua.ListKhuyenMai)
                            {
                                //insert km header
                                bgkm.IdDKMua = bgDKMua.IdDKMua;
                                bgkm.SoKhuyenMai = Common.GetSoPhieuKM(chinhSach.SoChinhSach, ++stt);
                                bgkm.IdKhuyenMai = KhuyenMaiDataProvider.Instance.InsertBGKhuyenMai(bgkm);
                                //insert km detail
                                foreach (BangGiaADKhuyenMaiChiTietInfor kmct in bgkm.ListKhuyenMaiChiTiet)
                                {
                                    kmct.IdKhuyenMai = bgkm.IdKhuyenMai;
                                    kmct.IdChiTiet = KhuyenMaiDataProvider.Instance.InsertKhuyenMaiChiTiet(kmct);
                                }
                                //if (!bgkm.IsOrigin || IsAdded)
                                //{
                                //    //cap nhat khuyen mai header
                                //    bgkm.IdDKMua = bgDKMua.IdDKMua;
                                //    if (bgkm.IdKhuyenMai == 0 || IsAdded)
                                //        bgkm.IdKhuyenMai = KhuyenMaiDataProvider.Instance.InsertBGKhuyenMai(bgkm);
                                //    else
                                //        KhuyenMaiDataProvider.Instance.UpdateBGKhuyenMai(bgkm);

                                //    //cap nhat khuyen mai detail  
                                //    if (bgkm.ListKhuyenMaiChiTiet != null)
                                //    {
                                //        foreach (BangGiaADKhuyenMaiChiTietInfor kmct in bgkm.ListKhuyenMaiChiTiet)
                                //        {
                                //            if (!kmct.IsOrigin || IsAdded)
                                //            {
                                //                kmct.IdKhuyenMai = bgkm.IdKhuyenMai;
                                //                if (kmct.IdChiTiet == 0 || IsAdded)
                                //                    kmct.IdChiTiet = KhuyenMaiDataProvider.Instance.InsertKhuyenMaiChiTiet(kmct);
                                //                else
                                //                    KhuyenMaiDataProvider.Instance.UpdateKhuyenMaiChiTiet(kmct);
                                //            }
                                //        }
                                //    }
                                //}
                            }
                        }

                        //cap nhat san pham kem
                        //xoa du lieu cu
                        KhuyenMaiDataProvider.Instance.DeleteBGiaChiTietSanPhamKem(bgDKMua.IdDKMua);
                        if (bgDKMua.ListSanPhamKem != null)
                        {
                            //them du lieu moi
                            foreach (BangGiaADSPKemInfor spk in bgDKMua.ListSanPhamKem)
                            {
                                spk.IdDKMua = bgDKMua.IdDKMua;
                                KhuyenMaiDataProvider.Instance.InsertBGiaADSanPhamKem(spk);
                            }
                        }
                        //cap nhat san pham da mua
                        //xoa du lieu cu
                        KhuyenMaiDataProvider.Instance.DeleteBGiaChiTietSanPhamDaMua(bgDKMua.IdDKMua);
                        if (bgDKMua.ListSanPhamDaMua != null)
                        {
                            //them du lieu moi
                            foreach (BangGiaADSPDaMuaInfor spdm in bgDKMua.ListSanPhamDaMua)
                            {
                                spdm.IdDKMua = bgDKMua.IdDKMua;
                                KhuyenMaiDataProvider.Instance.InsertBGiaADSanPhamDaMua(spdm);
                            }
                        }
                    }
                }
            }            
        }

        private void LoadAllDanhMuc()
        {
            LoadDMNgheNghiep();
            LoadDMCachGiaoHang();
            LoadDMTinh();
        }

        private void frm_BangGia_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAllDanhMuc();
                if (liChinhSach == null || liChinhSach.Count == 0)
                    LoadAllBangGia();
                //gan bang gia hien tai
                if (chinhSach != null)
                {
                    LoadIndexBG();
                }
                else if (liChinhSach.Count > 0)
                {
                    IndexBG = 0;
                    chinhSach = liChinhSach[IndexBG];
                }
                //hien thi thong tin bang gia hien tai
                LoadChinhSachInfor();
                //Thiet lap trang thai item
                Updating = false;
                setEDItems();
                setEDFunctions();
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

        /// <summary>
        /// Load all bảng giá. 
        /// Nếu count > 1 => hiển thị bảng giá số 0 hoặc bảng giá hiện tại (nếu chọn từ form tìm kiếm)
        /// </summary>
        private void LoadAllBangGia()
        {
            if (Common.Int2Bool(nguoiDung.SupperUser))
                liChinhSach = ChinhSachDataProvider.Instance.LoadAllChinhSach();
            else
                liChinhSach = ChinhSachDataProvider.Instance.LoadChinhSachByNSD(nguoiDung.TenDangNhap);
        }

        private void LoadIndexBG()
        {
            if (chinhSach != null && liChinhSach != null)
            {
                for (int i = 0; i < liChinhSach.Count; i++)
                {
                    if (liChinhSach[i].IdChinhSach == chinhSach.IdChinhSach)
                    {
                        IndexBG = i;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Enable, disable các ô nhập liệu
        /// </summary>
        private void setEDItems()
        {
            //bool status = Updating ? true : false;
            txtSoChinhSachGia.ReadOnly = !Updating;
            nudDoUuTien.Enabled = Updating;
            //chkDaDuyet.Enabled = Updating && Common.Int2Bool(nguoiDung.SupperUser);
            chkOnline.Enabled = Updating;
            mstNgayLap.Enabled = Updating;
            txtNguoiLap.ReadOnly = !Updating;
            //txtNgayDuyet.Enabled = Updating;
            //txtNguoiDuyet.Enabled = Updating;
            txtGhiChu.Enabled = Updating;

            //gSieuThiAD.Enabled = Updating;
            btnAddST.Enabled = Updating;
            btnDeleteST.Enabled = Updating;

            //selectorKH.CheckMarkColumn.VisibleIndex = Updating ? 0 : -1;
            //gDoiTuong.Enabled = Updating;
            btnAddKH.Enabled = Updating;
            btnDelKH.Enabled = Updating;

            //gThoiGianAD.Enabled = Updating;
            mstNgayHieuLuc.Enabled = Updating;
            mstHanHieuLuc.Enabled = Updating;// && chkVoHan.Checked;
            //chkVoHan.Enabled = Updating;
            txtSoKhachDauNgay.Enabled = Updating;
            btnAddTG.Enabled = Updating;
            btnDelTG.Enabled = Updating;

            //gThanhToan.Enabled = Updating;
            btnAddTT.Enabled = Updating;
            btnDelTT.Enabled = Updating;
            txtThanhToanToiThieu.Enabled = Updating;

            chkDuyNhatCMND.Enabled = Updating;
            chkDuyNhatSDT.Enabled = Updating;
            txtTuoiTu.Enabled = Updating;
            txtTuoiDen.Enabled = Updating;
            txtGiaTriHDToiThieu.Enabled = Updating;
            txtGiaTriDHDaMua.Enabled = Updating;
            txtThoiHanMua.Enabled = Updating;
            cboNgheNghiep.Enabled = Updating;
            cboGiaoHang.Enabled = Updating;
            cboGioiTinh.Enabled = Updating;
            cboTinh.Enabled = Updating;
            cboHuyen.Enabled = Updating;

            cboLoaiMatHang.Enabled = Updating;
            txtMaMatHang.Enabled = Updating;
            txtHangSX.Enabled = Updating;

            GiaMuaTu.OptionsColumn.ReadOnly = !Updating;
            GiaMuaDen.OptionsColumn.ReadOnly = !Updating;
            TyLeChietKhau.OptionsColumn.ReadOnly = !Updating;
            TienChietKhau.OptionsColumn.ReadOnly = !Updating;
            SoLuongDuocMua.OptionsColumn.ReadOnly = !Updating;
            SoLuongToiDaDH.OptionsColumn.ReadOnly = !Updating;
            SoLuongPhaiMua.OptionsColumn.ReadOnly = !Updating;
            KhuyenMaiWeb.OptionsColumn.ReadOnly = !Updating;

            btnThemCT.Enabled = Updating;
            cmdXoaChiTiet.Enabled = Updating;
            btnThietLapSPDaMua.Enabled = Updating;
            btnThietLapSPKem.Enabled = Updating;
            cmdThietLapKM.Enabled = Updating;
        }
        /// <summary>
        /// Enable, disable các menu chức năng: Add, Save, Updade,...
        /// </summary>
        private void setEDFunctions()
        {
            btnTruoc.Enabled = IndexBG > 0;// ? true : false;
            btnSau.Enabled = IndexBG < (liChinhSach.Count - 1);// ? true : false;
            btnThem.Enabled = !Updating && !isView;
            btnSaoChep.Enabled = !Updating && (chinhSach != null && chinhSach.IdChinhSach > 0) && !isView;
            btnSua.Enabled = !Updating && (chinhSach != null && chinhSach.IdChinhSach > 0) && (Common.Int2Bool(Draft) || Common.Int2Bool(nguoiDung.SupperUser)) && !isView;
            btnCapNhat.Enabled = Updating && !isView;
            //btnXoa.Enabled = !Updating && (Common.Int2Bool(Draft) || Common.Int2Bool(nguoiDung.SupperUser)) && (liChinhSach.Count > 0);
            btnXoa.Enabled = (Common.Int2Bool(Draft) || Common.Int2Bool(nguoiDung.SupperUser)) && !isView;
            btnConfirm.Enabled = Updating;
            //btnTimKiem.Enabled = !Updating;
            btnStop.Enabled = !Updating && !Common.Int2Bool(Draft) && (chinhSach != null) && (chinhSach.IdChinhSach > 0) &&
                              (chinhSach.DaDuyet == 1 || chinhSach.DaDuyet == -1);
            btnStop.Text = (chinhSach != null && chinhSach.DaDuyet == -1) ? "Kích hoạt(F11)" : "Tạm &dừng (F11)";
            btnTimKiem.Enabled = !isView;
            groupBox1.Text = String.Format("Thông tin chung: Chính sách thứ [{0}]/[{1}]", IndexBG+1, liChinhSach.Count);
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidEditBangGia())
                {
                    MessageBox.Show("Bảng giá này đã được xác nhận, không thể xóa được!");
                }
                else
                {
                    DeleteBangGia();
                }
                Updating = false;
                setEDItems();
                setEDFunctions();
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

        private void DeleteBangGia()
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa chính sách giá này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (chinhSach.IdChinhSach > 0)
                        ChinhSachDataProvider.Instance.DeleteBangGiaChinhSach(chinhSach.IdChinhSach);
                    LoadAllBangGia();

                    if (liChinhSach.Count > 0)
                    {
                        if (IndexBG == liChinhSach.Count)
                            IndexBG = liChinhSach.Count - 1;
                        chinhSach = liChinhSach[IndexBG];
                    }
                    else
                        chinhSach = null;
                    //hien thi thong tin bang gia hien tai
                    LoadChinhSachInfor();
                    MessageBox.Show("Xóa bảng giá thành công!");
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


        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                ThemMoiBangGia();

                Updating = true;
                setEDItems();
                setEDFunctions();
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

        private void ThemMoiBangGia()
        {
            //khoi tao tham so bang gia
            //Draft = -1;
            IsAdded = true;
            cboLoaiMatHang.SelectedIndex = 6;
            //tao bang gia moi
            //IdBangGia = 0;
            
            chinhSach = new BangGiaChinhSachInfor();
            ResetBangGiaInfor();
            txtSoChinhSachGia.Text = CommonProvider.Instance.GetSoPhieu(Declare.Prefix.ChinhSachBanHang, "tbl_BangGia_ChinhSach", "SoChinhSach");

            //
            chinhSach.ListBangGiaADShop = new List<BangGiaADShopInfor>();
            gSieuThiAD.DataSource = new BindingList<BangGiaADShopInfor>(chinhSach.ListBangGiaADShop);

            chinhSach.ListBangGiaADKhach = new List<BangGiaADKhachInfor>();
            gDoiTuong.DataSource = new BindingList<BangGiaADKhachInfor>(chinhSach.ListBangGiaADKhach);

            chinhSach.ListBangGiaADThoiGian = new List<BangGiaADTimeInfor>();
            gThoiGianAD.DataSource = new BindingList<BangGiaADTimeInfor>(chinhSach.ListBangGiaADThoiGian);

            chinhSach.ListBangGiaADThanhToan = new List<BangGiaADBankInfor>();
            gThanhToan.DataSource = new BindingList<BangGiaADBankInfor>(chinhSach.ListBangGiaADThanhToan);

            chinhSach.ListBangGiaADDKMua = new List<BangGiaADDKMuaInfor>();
            gSanPham.DataSource = null;
            gSanPham.DataSource = new BindingList<BangGiaADDKMuaInfor>(chinhSach.ListBangGiaADDKMua);

            selector.View = null;
            selector.View = gvSanPham;
            selector.CheckMarkColumn.Fixed = FixedStyle.Left;
            selector.CheckMarkColumn.VisibleIndex = 0;
        }

        private void ResetBangGiaInfor()
        {
            txtSoChinhSachGia.ResetText();
            nudDoUuTien.Value = 0;
            txtTrangThai.ResetText();
            chkDaDuyet.Checked = false;
            chkOnline.Checked = false;
            mstNgayLap.Value = CommonProvider.Instance.GetSysDate();
            txtNguoiLap.Text = nguoiDung.TenNhanVien;
            txtNgayDuyet.ResetText();
            //txtNguoiDuyet.ResetText();
            txtGhiChu.ResetText();

            //chkAllDT.Checked = false;
            mstNgayHieuLuc.Value = CommonProvider.Instance.GetSysDate();
            mstHanHieuLuc.Value = CommonProvider.Instance.GetSysDate().AddDays(1) ;
            //chkVoHan.Checked = false;
            txtSoKhachDauNgay.ResetText();
            
            txtThanhToanToiThieu.ResetText();

            chkDuyNhatCMND.Checked = false;
            chkDuyNhatSDT.Checked = false;
            cboGioiTinh.SelectedIndex = 0;
            cboGiaoHang.SelectedIndex = -1;
            txtTuoiTu.ResetText();
            txtTuoiDen.ResetText();
            txtGiaTriHDToiThieu.ResetText();
            txtGiaTriDHDaMua.ResetText();
            txtThoiHanMua.ResetText();
            cboNgheNghiep.SelectedIndex = -1;
            cboTinh.SelectedIndex = -1;
            cboHuyen.SelectedIndex = -1;

            gSieuThiAD.DataSource = null;
            //selectorKH.ClearSelection();
            //gDoiTuong.DataSource = null;
            gThoiGianAD.DataSource = null;
            gThanhToan.DataSource = null;
            gSanPham.DataSource = null;
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidEditBangGia())
                {
                    MessageBox.Show("Bảng giá này đã được xác nhận, không thể sửa được!");
                }
                else
                {
                    IsAdded = false;
                    Updating = true;
                    setEDItems();
                    setEDFunctions();
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

        private bool ValidEditBangGia()
        {
            if (chinhSach.IdChinhSach > 0 && Draft == 0 && !Common.Int2Bool(nguoiDung.SupperUser))//bang gia da xac nhan
            {
                return false;
            }
            return true;
        }

        private bool ValidBangGiaInfor()
        {
            //Kiem tra thong tin day du
            if (!ut.isStringNotEmpty(txtSoChinhSachGia.Text))
            {
                MessageBox.Show("Số chính sách giá chưa có.Xin mời nhập!");
                txtSoChinhSachGia.Focus();
                return false;
            }

            if (ut.getDate(mstHanHieuLuc.Value) < ut.getDate(mstNgayHieuLuc.Value))
            {
                MessageBox.Show("Hạn hiêu lực không được trước ngày hiệu lực!");
                mstHanHieuLuc.Focus();
                return false;
            }
            //Kiem tra trung So bang gia
            if (ChinhSachDataProvider.Instance.ExistBangGiaChinhSach(txtSoChinhSachGia.Text.Trim(), chinhSach.IdChinhSach))
            {
                MessageBox.Show("Số chính sách giá đã tồn tại. Mời nhập lại!");
                txtSoChinhSachGia.Focus();
                return false;
            }
            if (gvSanPham.RowCount == 0)
            {
                MessageBox.Show("Bảng giá không có dữ liệu. Mời nhập lại!");
                return false;
            }
            if (gvSieuThiAD.RowCount == 0)
            {
                MessageBox.Show("Bảng giá chưa áp dụng cho siêu thị nào. Mời nhập lại!");
                tabChinhSach.SelectedTab = tabSieuThiAD;
                return false;
            }
            if (gvDoiTuong.RowCount == 0)
            {
                MessageBox.Show("Bảng giá chưa áp dụng cho đối tượng nào. Mời nhập lại!");
                tabChinhSach.SelectedTab = tabKhachHangAD;
                return false;
            }
            //kiem tra su hop le cua tung item
            for (int i=0; i<chinhSach.ListBangGiaADDKMua.Count; i++)
            {
                if (chinhSach.ListBangGiaADDKMua[i].GiaMuaTu == chinhSach.ListBangGiaADDKMua[i].GiaMuaDen && chinhSach.ListBangGiaADDKMua[i].GiaMuaTu != 0)
                {
                    MessageBox.Show(String.Format("Khoảng giá [{0}, {0}] trùng nhau. Xin mời nhập lại",
                                                  chinhSach.ListBangGiaADDKMua[i].GiaMuaTu));
                    return false;
                }
                for (int j=0; j<chinhSach.ListBangGiaADDKMua.Count; j++)
                {
                    if (i!=j && chinhSach.ListBangGiaADDKMua[i].MaHangMua.Equals(chinhSach.ListBangGiaADDKMua[j].MaHangMua) &&
                        chinhSach.ListBangGiaADDKMua[i].LoaiHangMua == chinhSach.ListBangGiaADDKMua[j].LoaiHangMua &&
                        (chinhSach.ListBangGiaADDKMua[i].MaHangSX == null && chinhSach.ListBangGiaADDKMua[j].MaHangSX == null || 
                            chinhSach.ListBangGiaADDKMua[i].MaHangSX != null && chinhSach.ListBangGiaADDKMua[i].MaHangSX.Equals(chinhSach.ListBangGiaADDKMua[j].MaHangSX)) &&
                        (chinhSach.ListBangGiaADDKMua[i].GiaMuaTu <= chinhSach.ListBangGiaADDKMua[j].GiaMuaTu && chinhSach.ListBangGiaADDKMua[j].GiaMuaTu <= chinhSach.ListBangGiaADDKMua[i].GiaMuaDen && chinhSach.ListBangGiaADDKMua[j].GiaMuaTu != 0 ||
                        chinhSach.ListBangGiaADDKMua[i].GiaMuaTu <= chinhSach.ListBangGiaADDKMua[j].GiaMuaDen && chinhSach.ListBangGiaADDKMua[j].GiaMuaDen <= chinhSach.ListBangGiaADDKMua[i].GiaMuaDen && chinhSach.ListBangGiaADDKMua[j].GiaMuaDen !=0))
                    {
                        string msg =
                            String.Format(
                                "Mặt hàng: {0}, hãng: {1} có 2 khoảng giá trùng nhau [{2}, {3}] và [{4}, {5}]. Xin mời thiết lập lại!",
                                chinhSach.ListBangGiaADDKMua[i].TenHangMua,
                                chinhSach.ListBangGiaADDKMua[i].TenHangSX, chinhSach.ListBangGiaADDKMua[i].GiaMuaTu,
                                chinhSach.ListBangGiaADDKMua[i].GiaMuaDen,
                                chinhSach.ListBangGiaADDKMua[j].GiaMuaTu, chinhSach.ListBangGiaADDKMua[j].GiaMuaDen);
                        MessageBox.Show(msg);
                        return false;
                    }
                }
            }
            //kiem tra so luong don hang
            int sum = 0;
            foreach (BangGiaADShopInfor shopInfor in (BindingList<BangGiaADShopInfor>)gSieuThiAD.DataSource)
            {
                if (shopInfor.IdTrungTam > 0 && shopInfor.IdKho == 0)
                    sum += shopInfor.SoLuongDonHang;
            }
            if (sum > Common.IntValue(txtSoKhachDauNgay.Text))
            {
                MessageBox.Show("Tổng số đơn hàng trên toàn siêu thị không được nhỏ hơn số lượng đơn hàng trên 1 siêu thị!");
                return false;
            }

            return true;
        }


        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            try
            {
                SaoChepBangGia();

                Updating = true;
                setEDItems();
                setEDFunctions();
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
        private void SaoChepBangGia()
        {
            //Draft = -1;
            IsAdded = true;
            //IdBangGia = 0;

            chinhSach.IdChinhSach = 0;//de sao chep
            chinhSach.NguoiTao = nguoiDung.TenDangNhap;
            txtSoChinhSachGia.Text = CommonProvider.Instance.GetSoPhieu(Declare.Prefix.ChinhSachBanHang, "tbl_BangGia_ChinhSach", "SoChinhSach");
            mstNgayHieuLuc.Value = CommonProvider.Instance.GetSysDate();
            mstHanHieuLuc.Value = CommonProvider.Instance.GetSysDate().AddDays(1);
            //chkVoHan.Checked = false;
            //chkBanBuon.Checked = false;
            chkDaDuyet.Checked = false;
            chkOnline.Checked = false;
            mstNgayLap.Value = CommonProvider.Instance.GetSysDate();
            txtNguoiLap.Text = nguoiDung.TenNhanVien;
            txtNgayDuyet.ResetText();
            //txtNguoiDuyet.ResetText();
            txtGhiChu.ResetText();

            //LoadChinhSachKhuyenMai();//load thong tin chi tiet chinh sach khuyen mai
        }
        private void LoadChiTietKhuyenMai()
        {
            foreach (BangGiaADDKMuaInfor bgDKMua in chinhSach.ListBangGiaADDKMua)
            {
                //load khuyen mai
                if (bgDKMua.ListKhuyenMai == null)
                {
                    //load all danh sach khuyen mai
                    bgDKMua.ListKhuyenMai = KhuyenMaiDataProvider.Instance.GetAllBangGiaKhuyenMaiInfors(bgDKMua.IdDKMua);
                    for (int i = 0; i < bgDKMua.ListKhuyenMai.Count; i++)
                    {
                        bgDKMua.ListKhuyenMai[i].ListKhuyenMaiChiTiet = KhuyenMaiDataProvider.Instance.GetAllKhuyenMaiChiTietInfors(bgDKMua.ListKhuyenMai[i].IdKhuyenMai);
                    }
                }
                //foreach (BangGiaADKhuyenMaiInfor km in bgDKMua.ListKhuyenMai)
                //{
                //    km.SoKhuyenMai = "";
                //}
                //load san pham kem
                if (bgDKMua.ListSanPhamKem == null)
                {
                    bgDKMua.ListSanPhamKem = KhuyenMaiDataProvider.Instance.GetAllSanPhamKemInfors(bgDKMua.IdDKMua);
                }
                //load all danh sach san pham da mua
                if (bgDKMua.ListSanPhamDaMua == null)
                {                    
                    bgDKMua.ListSanPhamDaMua = KhuyenMaiDataProvider.Instance.GetAllSanPhamDaMuaInfors(bgDKMua.IdDKMua);
                }                
            }            
        }

        private void frm_BangGia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5 && btnThem.Enabled) 
                this.btnThem_Click(sender, e);
            else if (e.KeyCode == Keys.F6 && btnSua.Enabled)
                this.btnSua_Click(sender, e);
            else if (e.KeyCode == Keys.F7 && btnCapNhat.Enabled)
                this.cmdCapNhat_Click(sender, e);
            else if (e.KeyCode == Keys.F8 && btnXoa.Enabled)
                this.cmdXoa_Click(sender, e);
            else if (e.KeyCode == Keys.F9 && btnXoa.Enabled)
                this.btnSaoChep_Click(sender, e);
            else if (e.KeyCode == Keys.F11 && btnXoa.Enabled)
                this.btnStop_Click(sender, e);
            else if (e.KeyCode == Keys.F12 && btnDong.Enabled)
                this.btnDong_Click(sender, e);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void chkVoHan_CheckedChanged(object sender, EventArgs e)
        {
            //mstHanHieuLuc.Enabled = chkVoHan.Checked;
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {

            try
            {
                Draft = 0;
                if (UpdateBangGia())
                {
                    Updating = false;
                    setEDItems();
                    setEDFunctions();
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


        #region Show chinh sach infor
        private void LoadChinhSachInfor()
        {
            if (chinhSach != null)
            {
                //load thong tin chung
                LoadChinhSachHeader();
                //load sieu thi ap dung
                LoadSieuThiApDung();
                //load khach hang ap dung
                LoadKhachHangApDung();
                //load thoi gian ap dung
                LoadThoiGianApDung();
                //load thanh toan ap dung
                LoadThanhToanApDung();
                //load chi tiet san pham mua
                LoadSanPhamMuaApDung();
            }
            else
            {
                ResetBangGiaInfor();
            }
        }
        private void LoadChinhSachHeader()
        {
            //thong tin chung
            Draft = chinhSach.Draft;
            txtSoChinhSachGia.Text = chinhSach.SoChinhSach;
            mstNgayLap.Value = chinhSach.NgayLap;
            txtNguoiLap.Text = chinhSach.NguoiLap;
            txtGhiChu.Text = chinhSach.GhiChu;
            nudDoUuTien.Value = chinhSach.DoUuTien;
            txtTrangThai.Text = chinhSach.DaDuyetTT;
            chkDaDuyet.Checked = Common.Int2Bool(chinhSach.DaDuyet);
            chkOnline.Checked = Common.Int2Bool(chinhSach.LoaiDoiTuong);
            chkDefault.Checked = Common.Int2Bool(chinhSach.MacDinh);

            txtSoKhachDauNgay.Text = chinhSach.SoKhachDauNgay.ToString();
            txtThanhToanToiThieu.Text = chinhSach.ThanhToanToiThieu.ToString();
            txtSoTienTToanTThieu.Text = Common.Double2Str(chinhSach.SoTienTToanToiThieu);

            //dieu kien khac
            chkDuyNhatCMND.Checked = Common.Int2Bool(chinhSach.DuyNhatCMND);
            chkDuyNhatSDT.Checked = Common.Int2Bool(chinhSach.DuyNhatSDT);
            txtTuoiTu.Text = chinhSach.DoTuoiTu.ToString();
            txtTuoiDen.Text = chinhSach.DoTuoiDen.ToString();
            cboGiaoHang.SelectedValue = chinhSach.CachGiaoHang;
            cboGioiTinh.SelectedIndex = chinhSach.GioiTinh;
            cboTinh.SelectedValue = chinhSach.IdTinh;
            cboHuyen.SelectedValue = chinhSach.IdHuyen;
            cboNgheNghiep.SelectedValue = chinhSach.IdNgheNghiep;
            txtGiaTriHDToiThieu.Text = Common.Double2Str(chinhSach.GiaTriHDToiThieu);
            txtGiaTriDHDaMua.Text = Common.Double2Str(chinhSach.GiaTriDHDaMua);
            txtThoiHanMua.Text = chinhSach.ThoiHanMua.ToString();

        }
        private void LoadSanPhamMuaApDung()
        {
            chinhSach.ListBangGiaADDKMua = KhuyenMaiDataProvider.Instance.GetAllBangGiaADDKMuaInfors(chinhSach.IdChinhSach);
            gSanPham.DataSource = new BindingList<BangGiaADDKMuaInfor>(chinhSach.ListBangGiaADDKMua);
            selector.View = gvSanPham;
            selector.CheckMarkColumn.Fixed = FixedStyle.Left;
            selector.CheckMarkColumn.VisibleIndex = 0;
            LoadChiTietKhuyenMai();//load chi tiet san pham mua
        }
        private void LoadSieuThiApDung()
        {
            chinhSach.ListBangGiaADShop = ChinhSachDataProvider.Instance.GetBangGiaADShopInfor(chinhSach.IdChinhSach);
            gSieuThiAD.DataSource = new BindingList<BangGiaADShopInfor>(chinhSach.ListBangGiaADShop);
        }
        private void LoadThoiGianApDung()
        {
            mstNgayHieuLuc.Value = chinhSach.NgayHieuLuc;
            mstHanHieuLuc.Value = chinhSach.HanHieuLuc;
            txtSoKhachDauNgay.Text = chinhSach.SoKhachDauNgay.ToString();

            chinhSach.ListBangGiaADThoiGian = ChinhSachDataProvider.Instance.GetBangGiaADThoiGianInfor(chinhSach.IdChinhSach);
            gThoiGianAD.DataSource = new BindingList<BangGiaADTimeInfor>(chinhSach.ListBangGiaADThoiGian);
        }
        private void LoadThanhToanApDung()
        {
            txtThanhToanToiThieu.Text = chinhSach.ThanhToanToiThieu.ToString();
            chinhSach.ListBangGiaADThanhToan = ChinhSachDataProvider.Instance.GetBangGiaADThanhToanInfor(chinhSach.IdChinhSach);
            gThanhToan.DataSource = new BindingList<BangGiaADBankInfor>(chinhSach.ListBangGiaADThanhToan);
        }
        private void LoadKhachHangApDung()
        {
            chinhSach.ListBangGiaADKhach = ChinhSachDataProvider.Instance.GetBangGiaADKhachInfor(chinhSach.IdChinhSach);
            gDoiTuong.DataSource = new BindingList<BangGiaADKhachInfor>(chinhSach.ListBangGiaADKhach);
        }

        #endregion
        private void btnAddST_Click(object sender, EventArgs e)
        {
            frmCS_BangGia_ApDungST frm = new frmCS_BangGia_ApDungST();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (chinhSach.ListBangGiaADShop == null)
                {
                    chinhSach.ListBangGiaADShop = new List<BangGiaADShopInfor>();
                    gSieuThiAD.DataSource = new BindingList<BangGiaADShopInfor>(chinhSach.ListBangGiaADShop);
                }

                foreach (BangGiaADShopInfor bgShop in frm.LstBangGiaADShop)
                {
                    if (!chinhSach.ListBangGiaADShop.Exists(delegate (BangGiaADShopInfor match)
                                                               {
                                                                   return
                                                                       match.IdTrungTam ==
                                                                       bgShop.IdTrungTam && match.IdKho == bgShop.IdKho || match.IdTrungTam == 0;
                                                               }))
                    {
                        if (bgShop.IdTrungTam == 0)
                        {
                            chinhSach.ListBangGiaADShop = new List<BangGiaADShopInfor>();
                            gSieuThiAD.DataSource = new BindingList<BangGiaADShopInfor>(chinhSach.ListBangGiaADShop);                            
                        }
                        bgShop.IdChinhSach = chinhSach.IdChinhSach;
                        ((BindingList<BangGiaADShopInfor>)gSieuThiAD.DataSource).Add(bgShop);
                    } 
                }
                UpdateSoLuongDonHang();
            }
        }

        private void UpdateSoLuongDonHang()
        {
            int sum = 0;
            foreach (BangGiaADShopInfor shopInfor in (BindingList<BangGiaADShopInfor>)gSieuThiAD.DataSource)
            {
                if (shopInfor.IdTrungTam > 0 && shopInfor.IdKho == 0)
                    sum += shopInfor.SoLuongDonHang;
            }
            if (sum > Common.IntValue(txtSoKhachDauNgay.Text))
                txtSoKhachDauNgay.Text = sum.ToString();
        }

        private void btnDeleteST_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvSieuThiAD.FocusedRowHandle < 0) return;

                if (MessageBox.Show("Bạn có chắc chắn xóa dữ liệu này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gvSieuThiAD.DeleteSelectedRows();
                    UpdateSoLuongDonHang();
                }
            }
            catch { }
        }

        private void btnAddTT_Click(object sender, EventArgs e)
        {
            frmCS_BangGia_ApDungTT frm = new frmCS_BangGia_ApDungTT();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BangGiaADBankInfor thanhToan = frm.ThanhToan;
                thanhToan.IdChinhSach = chinhSach.IdChinhSach;
                ((BindingList<BangGiaADBankInfor>)gThanhToan.DataSource).Add(thanhToan);
            }
        }

        private void btnDelTT_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvThanhToan.FocusedRowHandle < 0) return;

                if (MessageBox.Show("Bạn có chắc chắn xóa dữ liệu này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gvThanhToan.DeleteSelectedRows();
                }
            }
            catch { }
        }

        private void btnAddTG_Click(object sender, EventArgs e)
        {
            frmCS_BangGia_ApDungTG frm = new frmCS_BangGia_ApDungTG();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BangGiaADTimeInfor time = frm.Time;
                time.IdChinhSach = chinhSach.IdChinhSach;
                ((BindingList<BangGiaADTimeInfor>)gThoiGianAD.DataSource).Add(time);
            }
        }

        private void btnDelTG_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvThoiGianAD.FocusedRowHandle < 0) return;

                if (MessageBox.Show("Bạn có chắc chắn xóa dữ liệu này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gvThoiGianAD.DeleteSelectedRows();
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

        private void LoadDMNgheNghiep()
        {
            try
            {
                List<DmNgheNghiepInfor> liNgheNghiep = DMNgheNghiepDataProvider.Instance.GetListNgheNghiepInfors();
                cboNgheNghiep.DataSource = liNgheNghiep;
                cboNgheNghiep.DisplayMember = "TenNgheNghiep";
                cboNgheNghiep.ValueMember = "IdNgheNghiep";
                cboNgheNghiep.SelectedIndex = -1;
            }
            catch
            {
            }
        }

        private void LoadDMCachGiaoHang()
        {
            try
            {
                List<DMCachGiaoHangInfo> liGiaoHang = DMCachGiaoHangDataProvider.Instance.GetListCachGiaoHangInfo();
                cboGiaoHang.DataSource = liGiaoHang;
                cboGiaoHang.DisplayMember = "Ten";
                cboGiaoHang.ValueMember = "IdCachGiaoHang";
                cboGiaoHang.SelectedIndex = -1;
            }
            catch
            {
            }
        }

        private void LoadDMTinh()
        {
            try
            {
                List<DMTinhInfor> liTinh = DMTinhDataProvider.Instance.GetListTinhInfors();
                cboTinh.DataSource = liTinh;
                cboTinh.DisplayMember = "TenTinh";
                cboTinh.ValueMember = "IdTinh";
                cboTinh.SelectedIndex = -1;
            }
            catch
            {
            }           
        }

        private void LoadDMHuyen()
        {
            try
            {

                List<DMHuyenInfor> liHuyen = DMHuyenDataProvider.Instance.GetListHuyenByTinhInfors(Common.IntValue(cboTinh.SelectedValue));
                cboHuyen.DataSource = liHuyen;
                cboHuyen.DisplayMember = "TenHuyen";
                cboHuyen.ValueMember = "IdHuyen";
                cboHuyen.SelectedIndex = -1;
            }
            catch
            {
            }
        }

        private void cboTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDMHuyen();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn dừng chính sách giá này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string msg = "";
                    if (chinhSach.DaDuyet == 1)
                    {
                        chinhSach.DaDuyet = -1;
                        msg = "Tạm dừng chính sách giá thành công!";
                    }                       
                    else if (chinhSach.DaDuyet == -1)
                    {
                        chinhSach.DaDuyet = 1;
                        msg = "Kích hoạt chính sách giá thành công!";
                    }

                    chinhSach.NguoiDuyet = nguoiDung.TenDangNhap;

                    ChinhSachDataProvider.Instance.DuyetBangGiaChinhSach(chinhSach);
                    BangGiaChinhSachInfor cs = ChinhSachDataProvider.Instance.GetBangGiaChinhSachInforById(chinhSach.IdChinhSach);
                    chinhSach.DaDuyetTT = cs.DaDuyetTT;
                    txtTrangThai.Text = chinhSach.DaDuyetTT;
                    Updating = false;
                    setEDItems();
                    setEDFunctions();
                    MessageBox.Show(msg);
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

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            List<MatHangInfor> liMatHang = new List<MatHangInfor>();
            int idNND = Common.Int2Bool(nguoiDung.SupperUser) ? -1 : nguoiDung.IdNhomNguoiDung;
            TimKiemItemInfor item = TimKiemItemDataProvider.Instance.GetItemByTypeandCode(idNND, cboLoaiMatHang.SelectedIndex, txtMaMatHang.Text.Trim());

            if (item != null)
            {
                MatHangInfor mh = new MatHangInfor();
                mh.MaMatHang = item.Ma;
                mh.TenMatHang = item.Ten;
                mh.LoaiMatHang = cboLoaiMatHang.SelectedIndex;
                mh.TenLoaiMatHang = cboLoaiMatHang.SelectedItem.ToString();
                mh.IdMatHang = item.Id;
                mh.ChietKhau = item.ChietKhau;
                mh.MaHangSX = "";
                mh.TenHangSX = "";

                TimKiemItemInfor hsx = TimKiemItemDataProvider.Instance.GetItemByTypeandCode(idNND, 7, txtHangSX.Text);
                if (hsx != null)
                {
                    mh.MaHangSX = hsx.Ma;
                    mh.TenHangSX = hsx.Ten;
                }
                liMatHang.Add(mh);                
            }
            else
            {
                frmLookUp_MatHang frm = new frmLookUp_MatHang();
                if (frm.ShowDialog() == DialogResult.OK && frm.SelectedItems.Count > 0)
                {
                    liMatHang.AddRange(frm.SelectedItems);
                }                
            }

            if (liMatHang.Count > 0)
            {
                if (gvSanPham.DataSource == null)
                {
                    chinhSach.ListBangGiaADDKMua = new List<BangGiaADDKMuaInfor>();
                    gSanPham.DataSource = new BindingList<BangGiaADDKMuaInfor>(chinhSach.ListBangGiaADDKMua)
                    {
                        AllowEdit = true,
                        AllowNew = true,
                        AllowRemove = true,
                        RaiseListChangedEvents = true
                    };
                }

                foreach (MatHangInfor mh in liMatHang)
                {
                    if (!ExistMaSanPham(mh.LoaiMatHang, mh.MaMatHang, mh.MaHangSX))
                    {

                        ((BindingList<BangGiaADDKMuaInfor>)gSanPham.DataSource).Add(new BangGiaADDKMuaInfor()
                                                                                        {
                                                                                            IdChinhSach = chinhSach.IdChinhSach,
                                                                                            LoaiHangMua = mh.LoaiMatHang,
                                                                                            TenLoaiHangMua = mh.TenLoaiMatHang,
                                                                                            MaHangMua = mh.MaMatHang,
                                                                                            TenHangMua = mh.TenMatHang,
                                                                                            MaHangSX = mh.MaHangSX,
                                                                                            TenHangSX = mh.TenHangSX,
                                                                                            TyLePhanBo = 100
                                                                                        });
                    }
                }
                //((BindingList<BangGiaChiTietInfor>)gSanPham.DataSource).ResetBindings();
            }
        }

        private bool ExistMaSanPham(int loaiMH, string maMH, string maHSX)
        {
            //foreach (BangGiaADDKMuaInfor dk in (BindingList<BangGiaADDKMuaInfor>)gSanPham.DataSource)
            //{
            //    if (dk.LoaiHangMua == loaiMH && dk.MaHangMua.Equals(maMH) && dk.MaHangSX.Equals(maHSX))
            //        return true;
            //}
            return false;
        }

        private void cmdXoaChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                if (selector.SelectedCount > 0)
                {
                    if (MessageBox.Show("Bạn có chắc chắn xóa các items này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        foreach (BangGiaADDKMuaInfor dkm in selector.selection)
                        {
                            ((BindingList<BangGiaADDKMuaInfor>) gSanPham.DataSource).Remove(dkm);
                        }
                    }
                }
                else
                {
                    if (gvSanPham.FocusedRowHandle >= 0)
                    {
                        if (MessageBox.Show("Bạn có chắc chắn xóa các items này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            BangGiaADDKMuaInfor dkm = (BangGiaADDKMuaInfor)gvSanPham.GetRow(gvSanPham.FocusedRowHandle);
                            ((BindingList<BangGiaADDKMuaInfor>)gSanPham.DataSource).Remove(dkm);
                        }
                    }
                }
                //if (gvSanPham.FocusedRowHandle < 0) return;
                //if (MessageBox.Show("Bạn có chắc chắn xóa các items này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                //{
                //    gvSanPham.DeleteSelectedRows();
                //}
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

        private void btnThietLapSPKem_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvSanPham.FocusedRowHandle >= 0)
                {
                    BangGiaADDKMuaInfor dkm = (BangGiaADDKMuaInfor)gvSanPham.GetRow(gvSanPham.FocusedRowHandle);
                    frmCS_BangGia_SanPhamKem frm = new frmCS_BangGia_SanPhamKem(dkm, btnThietLapSPKem.Enabled);
                    frm.ShowDialog();
                    //                    if (frm.ShowDialog() == DialogResult.OK)
                    ((BindingList<BangGiaADDKMuaInfor>)gSanPham.DataSource).ResetBindings();
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

        private void cmdThietLapKM_Click(object sender, EventArgs e)
        {
            try
            {
                List<BangGiaADDKMuaInfor> liDKMua = new List<BangGiaADDKMuaInfor>();
                if (selector.SelectedCount > 0)
                {
                    foreach (BangGiaADDKMuaInfor dkm in selector.selection)
                    {
                        liDKMua.Add(dkm);
                    }
                }
                else
                {
                    if (gvSanPham.FocusedRowHandle >= 0)
                    {
                        BangGiaADDKMuaInfor dkm = (BangGiaADDKMuaInfor)gvSanPham.GetRow(gvSanPham.FocusedRowHandle);
                        liDKMua.Add(dkm);
                    }
                }
                frmCS_BangGia_KhuyenMai frm = new frmCS_BangGia_KhuyenMai(liDKMua, cmdThietLapKM.Enabled, txtSoChinhSachGia.Text, chkDefault.Checked);
                frm.ShowDialog();
                //                    if (frm.ShowDialog() == DialogResult.OK)
                ((BindingList<BangGiaADDKMuaInfor>)gvSanPham.DataSource).ResetBindings();
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

        private void btnSau_Click(object sender, EventArgs e)
        {
            try
            {
                if (IndexBG < liChinhSach.Count - 1)
                {
                    if (Updating)
                    {
                        if (MessageBox.Show("Dữ liệu đang cập nhật, bạn có muốn hủy bỏ không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                            return;
                    }

                    IndexBG++;
                    IsAdded = false;
                    chinhSach = liChinhSach[IndexBG];
                    LoadChinhSachInfor();

                    Updating = false;
                    setEDItems();
                    setEDFunctions();
                    if (frmCS != null)
                        frmCS.setRowFocus(IndexBG);
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
                    chinhSach = liChinhSach[IndexBG];
                    LoadChinhSachInfor();

                    Updating = false;
                    setEDItems();
                    setEDFunctions();
                    if (frmCS != null)
                        frmCS.setRowFocus(IndexBG);
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
            frmCS_TimKiem_ChinhSachGia frm = new frmCS_TimKiem_ChinhSachGia(1);
            if (frm.ShowDialog() == DialogResult.OK && frm.ChinhSach != null)
            {
                chinhSach = frm.ChinhSach;
                LoadIndexBG();
                //hien thi thong tin bang gia hien tai
                LoadChinhSachInfor();
                //Thiet lap trang thai item
                Updating = false;
                setEDItems();
                setEDFunctions();
            }
        }

        private void btnAddKH_Click(object sender, EventArgs e)
        {
            frmCS_BangGia_ApDungKH frm = new frmCS_BangGia_ApDungKH();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (chinhSach.ListBangGiaADKhach == null)
                {
                    chinhSach.ListBangGiaADKhach = new List<BangGiaADKhachInfor>();
                    gDoiTuong.DataSource = new BindingList<BangGiaADKhachInfor>(chinhSach.ListBangGiaADKhach);
                }

                foreach (BangGiaADKhachInfor bgKhach in frm.LstBangGiaADKhach)
                {
                    if (!chinhSach.ListBangGiaADKhach.Exists(delegate(BangGiaADKhachInfor match)
                                                                 {
                                                                     return
                                                                         match.IdLoaiDT ==
                                                                         bgKhach.IdLoaiDT &&
                                                                         match.IdDoiTuong == bgKhach.IdDoiTuong || match.IdLoaiDT == 0;
                                                                 }))
                    {
                        if (bgKhach.IdLoaiDT == 0)
                        {
                            chinhSach.ListBangGiaADKhach = new List<BangGiaADKhachInfor>();
                            gDoiTuong.DataSource = new BindingList<BangGiaADKhachInfor>(chinhSach.ListBangGiaADKhach);                            
                        }
                        bgKhach.IdChinhSach = chinhSach.IdChinhSach;
                        ((BindingList<BangGiaADKhachInfor>) gDoiTuong.DataSource).Add(bgKhach);
                    }
                }
            }
        }

        private void btnDelKH_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvDoiTuong.FocusedRowHandle < 0) return;

                if (MessageBox.Show("Bạn có chắc chắn xóa dữ liệu này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gvDoiTuong.DeleteSelectedRows();
                }
            }
            catch { }
        }

        private void gvSanPham_DoubleClick(object sender, EventArgs e)
        {
            Point pt = gSanPham.PointToClient(MousePosition);
            GridHitInfo hitInfo = gvSanPham.CalcHitInfo(pt);
            if (hitInfo.InRow)
            {
                if (hitInfo.Column.FieldName == "KhuyenMai")
                    cmdThietLapKM_Click(sender, e);
                else if (hitInfo.Column.FieldName == "SanPhamKem")
                    btnThietLapSPKem_Click(sender, e);
                else if (hitInfo.Column.FieldName == "SanPhamDaMua")
                    btnThietLapSPDaMua_Click(sender, e);
            }
        }

        private void btnThietLapSPDaMua_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvSanPham.FocusedRowHandle >= 0)
                {
                    BangGiaADDKMuaInfor dkm = (BangGiaADDKMuaInfor)gvSanPham.GetRow(gvSanPham.FocusedRowHandle);
                    frmCS_BangGia_SanPhamDaMua frm = new frmCS_BangGia_SanPhamDaMua(dkm, btnThietLapSPDaMua.Enabled);
                    frm.ShowDialog();
                    //                    if (frm.ShowDialog() == DialogResult.OK)
                    ((BindingList<BangGiaADDKMuaInfor>)gSanPham.DataSource).ResetBindings();
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

        private void gtidButton1_Click(object sender, EventArgs e)
        {
            foreach (BangGiaChinhSachInfor cs in liChinhSach)
            {
                cs.ChinhSachAD = cs != null ? cs.GhiChu : txtGhiChu.Text;
                //update sieu thị AD
                cs.SieuThiAD = "";
                if (cs.ListBangGiaADShop != null)
                {
                    foreach (BangGiaADShopInfor bgShop in cs.ListBangGiaADShop)
                    {
                        cs.SieuThiAD += bgShop.TenTrungTam + (!String.IsNullOrEmpty(bgShop.MaKho) ? String.Format("({0});", bgShop.MaKho) : "") + "\r\n";
                    }
                }

                //update doi tuong AD
                cs.DoiTuongAD = "";
                if (cs.ListBangGiaADKhach != null)
                {
                    foreach (BangGiaADKhachInfor bgKhach in chinhSach.ListBangGiaADKhach)
                    {
                        cs.DoiTuongAD += bgKhach.TenLoaiDT + (!String.IsNullOrEmpty(bgKhach.MaDoiTuong) ? String.Format("({0});", bgKhach.MaDoiTuong) : "") + "\r\n";
                    }
                }

                //update thoi gian AD
                cs.ThoiGianAD = "";
                if (cs.ListBangGiaADThoiGian != null)
                {
                    foreach (BangGiaADTimeInfor bgTime in chinhSach.ListBangGiaADThoiGian)
                    {
                        cs.ThoiGianAD += !String.IsNullOrEmpty(bgTime.DayOfMonth) ? String.Format("DayOfMonth: {0} |", bgTime.DayOfMonth) : "";
                        cs.ThoiGianAD += !String.IsNullOrEmpty(bgTime.DayOfWeek) ? String.Format("DayOfWeek: {0} |", bgTime.DayOfWeek) : "";
                        cs.ThoiGianAD += bgTime.Thu != 0 ? String.Format("Thu: {0} |", bgTime.Thu) : "";
                        cs.ThoiGianAD += bgTime.Ngay != 0 ? String.Format("Ngay: {0} |", bgTime.Ngay) : "";
                        cs.ThoiGianAD += !String.IsNullOrEmpty(bgTime.GioTu) ? String.Format("From: {0} |", bgTime.GioTu) : "";
                        cs.ThoiGianAD += !String.IsNullOrEmpty(bgTime.GioDen) ? String.Format("To: {0} |", bgTime.GioDen) : "" + "\r\n";
                    }
                }

                //update thanh toan;
                cs.ThanhToanAD = "";
                if (chinhSach.ListBangGiaADThanhToan != null)
                {
                    foreach (BangGiaADBankInfor bgBank in chinhSach.ListBangGiaADThanhToan)
                    {
                        cs.ThanhToanAD += bgBank.HinhThucThanhToan + (!String.IsNullOrEmpty(bgBank.TenNganHang) ? String.Format("(NHangTToan:{0});", bgBank.TenNganHang) : "");
                        cs.ThanhToanAD += !String.IsNullOrEmpty(bgBank.TenNganHangPH) ? String.Format("(NHangPHanh:{0});", bgBank.TenNganHangPH) : "";
                        cs.ThanhToanAD += (!String.IsNullOrEmpty(bgBank.ThoiHanThanhToan) ? String.Format("(THanTToan:{0});", bgBank.ThoiHanThanhToan) : "");
                        cs.ThanhToanAD += (bgBank.TyLeThanhToan == 0 ? String.Format("(TLeTToan:{0}%);", bgBank.TyLeThanhToan) : "") + "\r\n";
                    }
                }

                //update mota khac
                cs.MotaKhac = "";
                cs.MotaKhac += (chinhSach.DuyNhatCMND == 1 ? "Duy nhất CMND;" : "");
                cs.MotaKhac += (chinhSach.DuyNhatSDT == 1 ? "Duy nhất Số ĐT;" : "");
                cs.MotaKhac += (chinhSach.GiaTriHDToiThieu != 0 ? String.Format("Giá trị HĐ tối thiểu: {0};", Common.Double2Str(chinhSach.GiaTriHDToiThieu)) : "");
                cs.MotaKhac += (chinhSach.ThanhToanToiThieu != 0 ? String.Format("Thanh toán tối thiểu: {0};", Common.Double2Str(chinhSach.ThanhToanToiThieu)) : "");
                cs.MotaKhac += (chinhSach.GiaTriDHDaMua != 0 ? String.Format("Giá trị HĐ đã mua: {0};", Common.Double2Str(chinhSach.GiaTriDHDaMua)) : "");
                cs.MotaKhac += (chinhSach.ThoiHanMua != 0 ? String.Format("Thời hạn đã mua: {0} ngày;", Common.Double2Str(chinhSach.ThoiHanMua)) : "");

                ChinhSachDataProvider.Instance.UpdateBangGiaChinhSach(cs);

                //cs.ListBangGiaADDKMua = KhuyenMaiDataProvider.Instance.GetAllBangGiaADDKMuaInfors(cs.IdChinhSach);
                //foreach (BangGiaADDKMuaInfor dkm in cs.ListBangGiaADDKMua)
                //{
                //    dkm.ListKhuyenMai = KhuyenMaiDataProvider.Instance.GetAllBangGiaKhuyenMaiInfors(dkm.IdDKMua);
                //    for (int i = 0; i < dkm.ListKhuyenMai.Count; i++)
                //    {
                //        dkm.ListKhuyenMai[i].ListKhuyenMaiChiTiet =
                //            KhuyenMaiDataProvider.Instance.GetAllKhuyenMaiChiTietInfors(
                //                dkm.ListKhuyenMai[i].IdKhuyenMai);

                //        string khuyenMaiMa = "";
                //        string khuyenMai = "";
                //        foreach (BangGiaADKhuyenMaiChiTietInfor kmct in dkm.ListKhuyenMai[i].ListKhuyenMaiChiTiet)
                //        {
                //            khuyenMai += kmct.TenHangKM +
                //                         (kmct.SoLuong > 1 ? (";SLuong:" + kmct.SoLuong) : "") +
                //                         (kmct.SoTienKM > 0 ? (";TienKM:" + kmct.SoTienKM) : "") +
                //                         (kmct.TyLeKM > 0 ? (";TyleKM:" + kmct.TyLeKM + "%") : "") +
                //                         (kmct.SoTienYeuCau > 0 ? (";TienYC:" + kmct.SoTienYeuCau) : "") +
                //                         (";ThanhToan:" + kmct.TyLeThanhToan) + "\r\n";

                //            khuyenMaiMa += kmct.MaHangKM +
                //                           (kmct.SoLuong > 1 ? (";SLuong:" + kmct.SoLuong) : "") +
                //                           (kmct.SoTienKM > 0 ? (";TienKM:" + kmct.SoTienKM) : "") +
                //                           (kmct.TyLeKM > 0 ? (";TyleKM:" + kmct.TyLeKM + "%") : "") +
                //                           (kmct.SoTienYeuCau > 0 ? (";TienYC:" + kmct.SoTienYeuCau) : "") +
                //                           (";ThanhToan:" + kmct.TyLeThanhToan) + "\r\n";
                //        }
                //        dkm.KhuyenMaiMa = khuyenMaiMa;
                //        dkm.KhuyenMai = khuyenMai;
                //    }
                //}             
            }
        }
    }
}