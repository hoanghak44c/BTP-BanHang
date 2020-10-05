using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using QLBanHang.Class;
//using QLBanHang.Class.Objects;
using QLBanHang.Forms;
using QLBanHang.Modules.BanHang.Reports;
using QLBH.Common;
using QLBH.Common.Providers;
using QLBH.Core.Data;
using QLBH.Common.Objects;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.BanHang.Bussiness;


namespace QLBanHang.Modules.BanHang
{
    public partial class frmBH_XuatKhoHangBan : DevExpress.XtraEditors.XtraForm
    {
        #region "Khai báo biến"
        private int IndexCT = 0;//thu tu bang gia
        private int Draft = -1;//-1:chua ton tai; 1-save, 0-confirm
        private bool IsAdded = false;
        private bool Updating = false;//false: chua sua, tao moi; 1:dang sua, tao moi

        private int IdKhoSelected = Declare.IdKho;
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor) Declare.USER_INFOR
                                               : new NguoiDungInfor();

        private int TrangThaiDonHang = (int) OrderStatus.XUAT_KHO;
        private int LoaiChungTu = (int) TransactionType.DON_HANG_TAI_SHOP;

        private XuatKhoHangBanBusiness Business;

        //luu danh sach san pham ban
        List<DanhSachHangBanChiTietInfor> liDanhSachHangBanChiTiet = new List<DanhSachHangBanChiTietInfor>();
        List<ChungTuBanHangChiTietHangHoaInfor> liSanPhamBan = new List<ChungTuBanHangChiTietHangHoaInfor>();


        #endregion

        #region "Các phương thức khởi tạo"
        public frmBH_XuatKhoHangBan()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            Business = new XuatKhoHangBanBusiness(LoaiChungTu, nguoiDung.IdNhanVien, IdKhoSelected);
        }

        public frmBH_XuatKhoHangBan(int loaiChungTu)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.LoaiChungTu = loaiChungTu;
            Business = new XuatKhoHangBanBusiness(LoaiChungTu, nguoiDung.IdNhanVien, IdKhoSelected);
        }

        public frmBH_XuatKhoHangBan(ChungTuBanHangInfor chungTuBanHangInfor)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            Business = new XuatKhoHangBanBusiness(chungTuBanHangInfor);
        }
        public void HideMenu()
        {
            toolStrip1.Enabled = nguoiDung.SupperUser != 1 ? false : true;
            btnTimOrderKH.Enabled = nguoiDung.SupperUser != 1 ? false : true;
            //btnTimOrderKH.Visible = false;
            Updating = nguoiDung.SupperUser != 1 ? false : true;
            setEDItems();
        }
        #endregion

        #region "Các phương thức"
        /// <summary>
        /// Khoi tao don hang
        /// </summary>
        /// <returns></returns>
        private void ResetChungTuInfor()
        {
            //thong tin don hang
            //IdPhieuXuat = 0;
            //TrangThaiDonHang = (int) OrderStatus.DON_HANG_BAN_TAI_SHOP;
            txtSoOrderKH.ResetText();
            mstNgayLapPhieu.Value = CommonProvider.Instance.GetSysDate();//.ResetText();//.Text = DateTime.Today.ToString("dd/MM/yyyy");
            txtSoPhieu.ResetText();
            mstNgayXuat.Value = CommonProvider.Instance.GetSysDate();
            bteNhanVien.Tag = null;
            bteNhanVien.ResetText();
            txtDienThoai.ResetText();
            txtHoTenKhachHang.ResetText();
            txtDiaChi.ResetText();

            //thong tin san pham
            gHangDaXuat.DataSource = null;
            txtMaSanPham.Text = "";
            txtMaSanPham.Focus();
            txtMaSanPham.SelectAll();
        }

        private bool ValidChungTuInfor()
        {

            //Kiem tra trung so phieu
            if (BanHangDataProvider.Instance.ExistChungTu(Business.ChungTu.LoaiChungTu, txtSoPhieu.Text.Trim(), 3, Business.ChungTu.IdChungTu))//trung sochungtu
            {
                MessageBox.Show("Số phiếu này đã có." + "\n" + "-Hãy nhập lại", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoPhieu.Focus();
                return false;
            }

            //Kiem tra hop le cua ngay xuat
            if (mstNgayXuat.Value < mstNgayLapPhieu.Value)
            {
                MessageBox.Show("Ngày xuất kho luôn phải lớn hơn ngày lập đơn hàng." + "\nHãy nhập lại ngày xuất kho", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.mstNgayXuat.Focus();
                return false;
            }

            //
            //Sự hợp lệ của thông tin chi tiết phiếu xuất
            //
            if (this.gvHangDaXuat.RowCount == 0)
            {
                MessageBox.Show("Không có dữ liệu chi tiết đơn hàng.", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtMaSanPham.Focus();
                return false;
            }

            //
            //Sự hợp lệ của thông tin chi tiết phiếu xuất
            //
            if (this.gvHangDaXuat.RowCount == 0)
            {
                MessageBox.Show("Không có dữ liệu chi tiết đơn hàng.", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtMaSanPham.Focus();
                return false;
            }

            foreach (DanhSachHangBanChiTietInfor ct in (BindingList<DanhSachHangBanChiTietInfor>)gHangCanXuat.DataSource)
            {
                if (ct.SoLuongBan != ct.SoLuongXuat)
                {
                    MessageBox.Show("Hàng xuất kho chưa khớp với đơn hàng bán. Vui lòng kiểm tra lại.", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtMaSanPham.Focus();
                    return false;
                }
            }
            return true;
        }

        private void LoadSanPhamBan()
        {
            liSanPhamBan = XuatKhoDataProvider.Instance.GetAllListChiTietHangHoaByMaxMaVach(Business.ChungTu.IdChungTu, Business.ChungTu.IdKho);
        }

        private void LoadChungTuInstance()
        {
            if (Business.ChungTu.IdChungTu!=0)
            {
                LoadNhanVien();
                LoadChungTuHeader();
                LoadChungTuDetails();
            }
            else
            {
                ResetChungTuInfor();
            }
        }

        private void LoadNhanVien()
        {
            List<DMNhanVienInfo> liNhanVien = GiaoNhanDataProvider.Instance.GetListNhanVienByGiaoNhan(Business.ChungTu.IdChungTu);
            if (liNhanVien != null)
            {
                cboNhanVien.DataSource = liNhanVien;
                cboNhanVien.DisplayMember = "HoTen";
                cboNhanVien.ValueMember = "IdNhanVien";
                cboNhanVien.SelectedIndex = -1;                
            }
        }

        private void LoadChungTuHeader()
        {
            LoaiChungTu = Business.ChungTu.LoaiChungTu;
            TrangThaiDonHang = Business.ChungTu.TrangThai;
            Draft = Business.ChungTu.Draft;

            bteKhoXuat.Tag = DMKhoDataProvider.GetKhoByIdInfo(Business.ChungTu.IdKho);
            bteKhoXuat.Text = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).TenKho : "";
            bteKhachHang.Tag = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(Business.ChungTu.IdDoiTuong);
            bteKhachHang.Text = bteKhachHang.Tag != null ? ((DMDoiTuongInfo)bteKhachHang.Tag).TenDoiTuong : "";
            IdKhoSelected = Business.ChungTu.IdKho;
            txtGhiChu.Text = Business.ChungTu.GhiChu;

            txtSoOrderKH.Text = Business.ChungTu.SoChungTu;
            mstNgayLapPhieu.Value = Business.ChungTu.NgayLap;
            txtSoPhieu.Text = Business.ChungTu.SoPhieuXuat;
            try
            {
                mstNgayXuat.Value = Business.ChungTu.NgayXuatHang;
            }
            catch
            {
                mstNgayXuat.Value = DateTime.Now;
            }

            cboNhanVien.SelectedValue = Business.ChungTu.IdNhanVienGiao;
            bteNhanVien.Tag = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(Business.ChungTu.IdNhanVienGiao);
            bteNhanVien.Text = bteNhanVien.Tag != null ? ((DMNhanVienInfo)bteNhanVien.Tag).HoTen : "";
            txtDienThoai.Text = Business.ChungTu.DienThoai;
            txtHoTenKhachHang.Text = Business.ChungTu.HoTen;
            txtDiaChi.Text = Business.ChungTu.DiaChi;
        }

        private void LoadChungTuDetails()
        {
            //Load danh sach hang ban
            BanHangDataProvider.Instance.ConvertListChiTiet2HangBan(Business.ListChiTietChungTu,
                                                                    ref liDanhSachHangBanChiTiet);
            gHangCanXuat.DataSource = new BindingList<DanhSachHangBanChiTietInfor>(liDanhSachHangBanChiTiet);

            //Load danh sach ma vach da xuat
            if (Business.ListChiTietHangHoa == null)
            {
                Business.ListChiTietHangHoa = new List<ChungTuBanHangChiTietHangHoaInfor>();
            }

            //tich hop voi phieu dieu chuyen => load cac mavach duoc map san
            if (TrangThaiDonHang != (int)OrderStatus.XUAT_KHO && Business.ChungTu.SoPhieuDC != null && !Business.ChungTu.SoPhieuDC.Equals(""))
            {
                LoadMaVachTuPhieuDieuChuyen();
            }
            gHangDaXuat.DataSource = new BindingList<ChungTuBanHangChiTietHangHoaInfor>(Business.ListChiTietHangHoa);
            UpdateDetailStatus();
        }  
        //tich hop voi phieu dieu chuyen => load cac mavach duoc map san
        private void LoadMaVachTuPhieuDieuChuyen()
        {
            Business.ListChiTietHangHoa =
                XuatKhoDataProvider.Instance.GetListChiTietHangHoaByPhieuDC(Business.ChungTu.SoPhieuDC,
                                                                            Business.ChungTu.SoChungTu);
        }
        private void UpdateDetailStatus()
        {
            foreach (DanhSachHangBanChiTietInfor ct in (BindingList<DanhSachHangBanChiTietInfor>)gHangCanXuat.DataSource)
            {
                if (!Common.Int2Bool(ct.ChietKhau))
                    ct.SoLuongXuat = 0;                
            }
            foreach (ChungTuBanHangChiTietHangHoaInfor cthh in (BindingList<ChungTuBanHangChiTietHangHoaInfor>)gHangDaXuat.DataSource)
            {
                UpdateMaVach(cthh);
            }
        }
        private bool UpdateMaVach(ChungTuBanHangChiTietHangHoaInfor cthh)
        {
            //tim trong danh sach hang ban chinh neu co => gan ma vach cho hang ban
            DanhSachHangBanChiTietInfor ct = null;
            ct = liDanhSachHangBanChiTiet.Find(
                delegate(DanhSachHangBanChiTietInfor t)
                    {
                        return t.TypeHangHoa == 0 && t.MaSanPham == cthh.MaSanPham &&
                               t.SoLuongBan != t.SoLuongXuat;
                    });
            if (ct != null && (ct.SoLuongXuat + cthh.SoLuong <= ct.SoLuongBan))
            {
                ct.SoLuongXuat += cthh.SoLuong;
                cthh.IdChungTuChiTiet = ct.IdChiTietChungTu;
                cthh.LoaiHangHoa = Declare.DescHangBan;
                cthh.IdSanPhamBan = ct.IdSanPhamBan;
                cthh.LoaiHangKem = 0;
            }
            else
            {
                //tim trong danh sach hang mua kem
                ct = liDanhSachHangBanChiTiet.Find(
                    delegate(DanhSachHangBanChiTietInfor t)
                    {
                        return t.TypeHangHoa == 1 && t.MaSanPham == cthh.MaSanPham &&
                               t.SoLuongBan != t.SoLuongXuat;
                    });
                if (ct != null && (ct.SoLuongXuat + cthh.SoLuong <= ct.SoLuongBan))
                {
                    ct.SoLuongXuat += cthh.SoLuong;
                    cthh.IdChungTuChiTiet = ct.IdChiTietChungTu;
                    cthh.LoaiHangHoa = Declare.DescHangKem;
                    cthh.IdSanPhamBan = ct.IdSanPhamBan;
                    cthh.LoaiHangKem = 1;
                }
                else
                {
                    //tim trong danh sach hang khuyen mai
                    ct = liDanhSachHangBanChiTiet.Find(
                        delegate(DanhSachHangBanChiTietInfor t)
                        {
                            return t.TypeHangHoa == 2 && t.MaSanPham == cthh.MaSanPham &&
                                   t.SoLuongBan != t.SoLuongXuat;
                        });
                    if (ct != null && (ct.SoLuongXuat + cthh.SoLuong <= ct.SoLuongBan))
                    {
                        ct.SoLuongXuat += cthh.SoLuong;
                        cthh.IdChungTuChiTiet = ct.IdChiTietChungTu;
                        cthh.LoaiHangHoa = Declare.DescKhuyenMai;
                        cthh.IdSanPhamBan = ct.IdSanPhamBan;
                        cthh.LoaiHangKem = 0;
                    }
                    else
                    {
                        //tim trong danh sach hang kem giao nhan
                        ct = liDanhSachHangBanChiTiet.Find(
                            delegate(DanhSachHangBanChiTietInfor t)
                            {
                                return t.TypeHangHoa == -1 && t.MaSanPham == cthh.MaSanPham &&
                                       t.SoLuongBan != t.SoLuongXuat;
                            });
                        if (ct != null && (ct.SoLuongXuat + cthh.SoLuong <= ct.SoLuongBan))
                        {
                            ct.SoLuongXuat += cthh.SoLuong;
                            cthh.IdChungTuChiTiet = ct.IdChiTietChungTu;
                            cthh.LoaiHangHoa = Declare.DescGiaoNhan;
                            cthh.IdSanPhamBan = ct.IdSanPhamBan;
                            cthh.LoaiHangKem = 0;
                        }
                        else
                        {
                            MessageBox.Show("Không đúng sản phẩm cần xuất. Vui lòng chọn lại!");
                            return false;
                        }
                    }                    
                }
            }
            ((BindingList<DanhSachHangBanChiTietInfor>)gHangCanXuat.DataSource).ResetBindings();
            return true;
        }
        #endregion

        private void ShowInfors()
        {
            tslInfor.Text = Common.GetEnumInfor((TransactionType) LoaiChungTu);

            tsslTrangThai.Text = "Trạng thái đơn hàng: " + Common.GetEnumInfor((OrderStatus)TrangThaiDonHang);

            if (Updating)
                tsslTrangThai.Text += " { Đang cập nhật đơn hàng ... }";

            if (Common.Int2Bool(Draft))
                tsslDraft.Text = "Bản nháp {chưa xác nhận}";
            else
                tsslDraft.Text = "";
        }

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            try
            {
                if (Business.ChungTu.IdChungTu > 0)
                {
                    LoadChungTuInstance();
                    //Thiet lap trang thai item                    
                    if (Business.ChungTu.Draft == 1 || nguoiDung.SupperUser == 1 || Business.ChungTu.TrangThai != (int)OrderStatus.XUAT_KHO)
                    {
                        if (Business.ChungTu.TrangThai != (int)OrderStatus.XUAT_KHO)
                        {
                            mstNgayXuat.Value = CommonProvider.Instance.GetSysDate();
                            txtSoPhieu.Text = CommonProvider.Instance.GetSoPhieu(Declare.Prefix.PhieuXuatKhoHangBan);                            
                        }
                        tsbEdit_Click(sender, e);
                    }                        
                    else
                    {
                        IsAdded = false;
                        Updating = false;
                        setEDItems();
                        setEDFunctions();
                    }
                }
                else
                {
                    setEDItems();
                    setEDFunctions();
                    ShowInfors();                    
                }
            }
            catch (System.Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            } 
            txtMaSanPham.Focus();           
        }

        private void frmPhieuXuat_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //if (!this.txtGhiChu.Focused && !this.dgvSanPhamBan.Focused && !this.txtMaVach.Focused && !this.dgvHangKhuyenMai.Focused)
                //{
                //    if (e.KeyCode == Keys.Enter)
                //    {
                //        SendKeys.Send("{TAB}");
                //        e.Handled = true;
                //        return;
                //    }
                //    else if (e.KeyCode == Keys.F2)
                //    {
                //        if (this.WindowState == FormWindowState.Maximized)
                //            this.WindowState = FormWindowState.Normal;
                //        else
                //            this.WindowState = FormWindowState.Maximized;
                //        e.Handled = true;
                //        return;
                //    }
                //}
                if (e.KeyCode == Keys.F6 && tsbEdit.Enabled)
                    this.tsbEdit_Click(sender, e);
                else if (e.KeyCode == Keys.F7 && tsbUpdate.Enabled)
                    this.tsbUpdate_Click(sender, e);
                else if (e.KeyCode == Keys.F8 && tsbDelete.Enabled)
                    this.tsbDelete_Click(sender, e);
                else if (e.KeyCode == Keys.F9 && tsbPrint.Enabled)
                    this.tsbPrint_Click(sender, e);
                else if (e.KeyCode == Keys.F10 && tsbSearch.Enabled)
                    this.tsbSearch_Click(sender, e);
                else if (e.KeyCode == Keys.F12 && tsbClose.Enabled)
                    this.tsbClose_Click(sender, e);
            }
            catch (System.Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void InputDataFromCode(string code)
        {
            try
            {
                ChungTuBanHangChiTietHangHoaInfor ct = liSanPhamBan.Find(delegate(ChungTuBanHangChiTietHangHoaInfor match)
                                                                               {
                                                                                   return match.MaVach.Equals(code) &&
                                                                                          match.SoLuong > 0;
                                                                               });

                if (ct == null)
                {
                    frmLookUp_MaVach frm = new frmLookUp_MaVach(false, liSanPhamBan, true);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        ct = frm.SelectedItem;
                    }
                }

                if (ct != null)
                {
                    ChungTuBanHangChiTietHangHoaInfor cthh = new ChungTuBanHangChiTietHangHoaInfor(ct);
                    //kiem tra xem da nhap chua (voi truong hop trung ma vach)
                    if (Business.ListChiTietHangHoa.Exists(delegate (ChungTuBanHangChiTietHangHoaInfor hh)
                                                               {
                                                                   return !Common.Int2Bool(cthh.TrungMaVach) &&
                                                                          hh.MaVach.Equals(cthh.MaVach);
                                                               }))
                    {
                        MessageBox.Show("Sản phẩm đã được nhập rôi.\nBạn hãy nhập sản phẩm khác");
                        return;
                    }

                    //cap nhat ma vach theo danh sach hang can xuat                    
                    cthh.SoLuong = 1;
                    if (UpdateMaVach(cthh))
                    {
                        //cap nhat danh sach ma vach duoc xuat
                        ChungTuBanHangChiTietHangHoaInfor ctu =
                            Business.ListChiTietHangHoa.Find(delegate(ChungTuBanHangChiTietHangHoaInfor match)
                            { return match.MaVach.Equals(cthh.MaVach) && match.LoaiHangHoa.Equals(cthh.LoaiHangHoa); });

                        if (ctu != null)//neu da co thi tang so luong (voi truong hop nhap trung ma vach)
                        {
                            ctu.SoLuong += 1;
                        }
                        else//neu chua co thi them dong moi
                        {
                            ((BindingList<ChungTuBanHangChiTietHangHoaInfor>)gHangDaXuat.DataSource).Add(cthh);
                        }
                        ((BindingList<ChungTuBanHangChiTietHangHoaInfor>)gHangDaXuat.DataSource).ResetBindings();
                        ((BindingList<ChungTuBanHangChiTietHangHoaInfor>)gHangCanXuat.DataSource).ResetBindings();

                        //neu cap nhat ma vach thanh cong => cap nhat lai ton
                        ct.SoLuong -= cthh.SoLuong;
                        if (ct.SoLuong == 0)
                            liSanPhamBan.Remove(ct);
                    }
                }
            }
            catch (System.Exception ex)
            {
#if DEBUG
                //MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                //MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            InputDataFromCode(txtMaSanPham.Text.Trim());
        }

        //private void ThemMoiDonHang()
        //{
        //    Draft = -1;
        //    IsAdded = true;
        //    //LoaiChungTu = (int) TransactionType.DON_HANG_TAI_SHOP;
        //    //TrangThaiDonHang = (int) OrderStatus.DON_HANG_BAN_TAI_SHOP;
        //    //Business = new XuatKhoHangBanBusiness(LoaiChungTu, nguoiDung.IdNhanVien, IdKhoSelected);
        //    LoadSanPhamBan();
        //    ResetChungTuInfor();
        //    txtSoPhieu.Text = CommonProvider.Instance.GetSoPhieu(Declare.Prefix.PhieuXuatKhoHangBan);

        //    Business.ListChiTietHangHoa = new List<ChungTuBanHangChiTietHangHoaInfor>();
        //    gHangDaXuat.DataSource = new BindingList<ChungTuBanHangChiTietHangHoaInfor>(Business.ListChiTietHangHoa);
        //}

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidEditChungTu())
                {
                    MessageBox.Show("Phiếu xuất này đã được xác nhận, không thể sửa được!");
                }
                else
                {
                    IsAdded = false;
                    Updating = true;
                    setEDItems();
                    setEDFunctions();
                    LoadSanPhamBan();
                    ShowInfors();
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

        private bool ValidEditChungTu()
        {
            if (Business.ChungTu.IdChungTu > 0 && (
                Draft == 0 && Business.ChungTu.TrangThai != (int)OrderStatus.XUAT_KHO ||
                (Draft != 0 || nguoiDung.SupperUser == 1) && Business.ChungTu.TrangThai == (int)OrderStatus.XUAT_KHO))
            {
                return true;
            }
            return false;
        }

        
        private void setEDItems()
        {
            //txtSoOrderKH.Enabled = Updating;
            //mstNgayLapPhieu.Enabled = Updating;
            txtSoPhieu.Enabled = Updating;
            mstNgayXuat.Enabled = Updating;
            bteNhanVien.Enabled = Updating;
            //txtDienThoai.Enabled = Updating;
            //txtHoTenKhachHang.Enabled = Updating;
            //txtDiaChi.Enabled = Updating;

            txtMaSanPham.Enabled = Updating;
            btnThemHang.Enabled = Updating;
            btnXoaMaVach.Enabled = Updating;
        }

        private void setEDFunctions()
        {
            tsbEdit.Enabled = !Updating && (Business.ChungTu.IdChungTu > 0) && ((Common.Int2Bool(Draft)  || nguoiDung.SupperUser == 1) &&
                              TrangThaiDonHang == (int) OrderStatus.XUAT_KHO || TrangThaiDonHang != (int) OrderStatus.XUAT_KHO);
            tsbUpdate.Enabled = Updating;//cap nhat
            tsbDelete.Enabled = (TrangThaiDonHang == (int)OrderStatus.XUAT_KHO);//xoa, huy don hang online, dat truoc
            tsbConfirm.Enabled = Updating;//xac nhan
            tsbPrint.Enabled = !Updating && (Business.ChungTu.IdChungTu > 0);
        }

        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Draft = 1;
                if (UpdateChungTu())
                {
                    Updating = false;
                    setEDItems();
                    setEDFunctions();
                    ShowInfors();                    
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

        private bool UpdateChungTu()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (ValidChungTuInfor())
                {
                    SaveChungTuInstance();
                    Business.SaveChungTu();

                    if (IsAdded)
                    {
                        MessageBox.Show("Lập phiếu xuất kho thành công!");
                    }                        
                    else
                    {
                        MessageBox.Show("Cập nhật phiếu xuất kho thành công!");
                    }
                        
                    return true;
                }                
            }
            catch (Exception)
            {
                throw;
            }
            Cursor.Current = Cursors.Default;
            return false;
        }

        private void SaveChungTuInstance()
        {
            //update trang thai don hang
            TrangThaiDonHang = (int)OrderStatus.XUAT_KHO;
            //update header
            Business.ChungTu.SoPhieuXuat = txtSoPhieu.Text;
            Business.ChungTu.NgayXuatHang = mstNgayXuat.Value;
            Business.ChungTu.LoaiChungTu = LoaiChungTu;
            Business.ChungTu.TrangThai = TrangThaiDonHang;
            Business.ChungTu.Draft = Draft;

            Business.ChungTu.NguoiSua = nguoiDung.TenDangNhap;
            Business.ChungTu.TenMaySua = Declare.TenMay;
        }

        private bool ValidDeleteChungTu()
        {
            if ((Draft != 0 || nguoiDung.SupperUser == 1) && TrangThaiDonHang == (int)OrderStatus.XUAT_KHO)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Đơn hàng chưa xuất kho, không thể hủy được");
                return false;
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidDeleteChungTu())
                {
                    DeleteChungTu();
                }
                Updating = false;
                setEDItems();
                setEDFunctions();
                ShowInfors();
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

        private void RestoreTrangThaiChungTu()
        {
            if (TrangThaiDonHang == (int)OrderStatus.XUAT_KHO)
            {
                if (Business.ChungTu.GiaoNhan == 1)
                {
                    TrangThaiDonHang = (int) OrderStatus.XAC_NHAN_DON_HANG_GIAO_NHAN;
                }
                else
                {
                    if (LoaiChungTu == (int)TransactionType.DON_HANG_TAI_SHOP || LoaiChungTu == (int)TransactionType.DON_HANG_BU_KHUYEN_MAI)
                        TrangThaiDonHang = (int) OrderStatus.DON_HANG_BAN_TAI_SHOP;
                    else if (LoaiChungTu == (int)TransactionType.DON_HANG_DAT_TRUOC)
                        TrangThaiDonHang = (int) OrderStatus.DON_HANG_BAN_DAT_TRUOC;
                    else if (LoaiChungTu == (int)TransactionType.DON_HANG_ONLINE)
                        TrangThaiDonHang = (int) OrderStatus.DON_HANG_BAN_ONLINE;
                    else if (LoaiChungTu == (int)TransactionType.DON_HANG_GIAO_NHAN)
                        TrangThaiDonHang = (int)OrderStatus.XAC_NHAN_DON_HANG_GIAO_NHAN;
                }
                
            }
        }
        private void DeleteChungTu()
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn hủy phiếu xuất này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Business.ChungTu.IdChungTu > 0)
                    {
                        //khoi phuc trang thai chungtu
                        RestoreTrangThaiChungTu();

                        //restore trang thai don hang cu
                        Business.ChungTu.TrangThai = TrangThaiDonHang;
                        Business.ChungTu.SoPhieuXuat = "";
                        Business.ChungTu.Draft = 0;
                        Business.SaveChungTu();//cap nhat trang thai

                        Business.DeleteChungTu();//xoa chung tu kho, khoi phuc ton kho
                    }
                    MessageBox.Show("Hủy phiếu xuất thành công!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi thực hiện Xóa đơn hàng\n" + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi thực hiện Xóa đơn hàng", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }
        private void tsbPrint_Click(object sender, EventArgs e)
        {
            if (gvHangDaXuat.RowCount == 0)
            {
                MessageBox.Show("Chưa có sản phẩm xuất bán");
                return;
            }
            InPhieuXuatKho();
            if (MessageBox.Show("Có in kèm phiếu bảo hành hay không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                InPhieuBaoHanh();
            }
        }

        private void InPhieuXuatKho()
        {
            rpt_PhieuXuatKho rp = new rpt_PhieuXuatKho(Business.ChungTu);
            foreach (ChungTuBanHangChiTietInfor ct in Business.ListChiTietChungTu)
            {
                ct.DonGiaCoVat = ct.DonGia + ct.TienVAT;
            }
            rp.DataSource = Business.ListChiTietChungTu;
            rp.ShowPreview();
        }

        private void InPhieuBaoHanh()
        {
            frmIn_PhieuBaoHanh frm = new frmIn_PhieuBaoHanh(Business.ChungTu);
            frm.ShowDialog();
        }
        private void tsbSearch_Click(object sender, EventArgs e)
        {
            search();
            ShowInfors();
        }

        private void search()
        {
            //int[] IdPhieu = new int[] { 0 };
            //frmBH_TimChungTu frm = new frmBH_TimChungTu((int)TransactionType.XUAT_BAN, IdPhieu);
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    if (IdPhieu[0] > 0) {
            //        this.IdPhieuXuat = IdPhieu[0];
            //        if (dtPhieuXuat.PrimaryKey.Length == 0)
            //            dtPhieuXuat.PrimaryKey = new DataColumn[] { dtPhieuXuat.Columns["IdPhieuXuat"] };
            //        IndexPX = dtPhieuXuat.Rows.IndexOf(dtPhieuXuat.Rows.Find(this.IdPhieuXuat));
            //        //LoadQuyen();
            //        this.LoadPhieuXuat(this.IdPhieuXuat);
            //        setEDFunctions();
            //        if (ChuaDayOracle)
            //            tsbEdit_Click(this, null);
            //    }
            //}
            ////frm.MdiParent = this.ParentForm;
            ////this.Close();            
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (System.Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void btnTimOrderKH_Click(object sender, EventArgs e)
        {
            try
            {
                if (Updating)
                {
                    if (MessageBox.Show("Dữ liệu đang cập nhật, bạn có muốn hủy bỏ không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;
                }
                ChungTuBanHangInfor ctu = BanHangDataProvider.Instance.LoadChungTu(-1, txtSoOrderKH.Text.Trim(), 1, 0);
                if (ctu != null)
                {
                    Business = new XuatKhoHangBanBusiness(ctu);
                    LoadChungTuInstance();

                    Updating = false;
                    setEDItems();
                    setEDFunctions();
                    ShowInfors();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy chứng từ thích hợp!");
                    txtSoOrderKH.Text = Business.ChungTu.SoChungTu;
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

        private void txtSoOrderKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnTimOrderKH_Click(sender, e);
            }
        }
 
        private void txtMaSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                InputDataFromCode(txtMaSanPham.Text.Trim());
            }
        }

        private void txtMaSanPham_Enter(object sender, EventArgs e)
        {
            this.txtMaSanPham.Focus();
            this.txtMaSanPham.SelectAll();
        }

        private void txtMaSanPham_Leave(object sender, EventArgs e)
        {
            if (!txtMaSanPham.Text.Trim().Equals(""))
            {
                InputDataFromCode(txtMaSanPham.Text.Trim());
            }
        }

        private void tsbConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Draft = 0;
                if (UpdateChungTu())
                {
                    Updating = false;
                    setEDItems();
                    setEDFunctions();
                    ShowInfors();
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

        private void btnXoaMaVach_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng hàng này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gvHangDaXuat.DeleteSelectedRows();
                UpdateDetailStatus();
                ((BindingList<DanhSachHangBanChiTietInfor>)gHangCanXuat.DataSource).ResetBindings();
            }
        }

        private void gvHangDaXuat_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            UpdateDetailStatus();
        }
    }
}