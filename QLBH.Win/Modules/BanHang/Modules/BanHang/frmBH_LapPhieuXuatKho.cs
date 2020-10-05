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
using QLBanHang.Modules.HeThong;
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
using QLBH.Core.Exceptions;
using QLBH.Core.Providers;


namespace QLBanHang.Modules.BanHang
{
    public partial class frmBH_LapPhieuXuatKho : DevExpress.XtraEditors.XtraForm
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
        private int LoaiChungTu = (int) TransactionType.XUAT_KHO_HANG_BAN;

        private LapPhieuXuatKhoBusiness Business = new LapPhieuXuatKhoBusiness();

        //luu danh sach san pham ban
        private ChungTuBanHangInfor ChungTuBanHang = new ChungTuBanHangInfor();
        private List<ChungTuBanHangInfor> liPhieuXuat = new List<ChungTuBanHangInfor>();
        private List<DanhSachHangXuatBanInfor> liDanhSachHangBanChiTiet = new List<DanhSachHangXuatBanInfor>();
        private List<DanhSachHangXuatBanInfor> liDanhSachHangBanChiTietOld = new List<DanhSachHangXuatBanInfor>();
        private List<ChungTuBanHangChiTietHangHoaInfor> liSanPhamBan = new List<ChungTuBanHangChiTietHangHoaInfor>();
        private bool IsInHoaDon = false;
        private bool IsView = false;

        #endregion

        #region "Các phương thức khởi tạo"
        public frmBH_LapPhieuXuatKho()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            Business = new LapPhieuXuatKhoBusiness(LoaiChungTu, nguoiDung.IdNhanVien, IdKhoSelected);
        }

        public frmBH_LapPhieuXuatKho(int loaiChungTu)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.LoaiChungTu = loaiChungTu;
            Business = new LapPhieuXuatKhoBusiness(LoaiChungTu, nguoiDung.IdNhanVien, IdKhoSelected);
        }

        public frmBH_LapPhieuXuatKho(ChungTuBanHangInfor chungTuBanHangInfor)
        {
            InitializeComponent();
            Common.LoadStyle(this);

            ChungTuBanHang = BanHangDataProvider.Instance.GetChungTuBySoChungTu<ChungTuBanHangInfor>(
                    chungTuBanHangInfor.SoChungTu) ?? chungTuBanHangInfor;

            Business = new LapPhieuXuatKhoBusiness(chungTuBanHangInfor.LoaiChungTu, nguoiDung.IdNhanVien, chungTuBanHangInfor.IdKho);
            //Business = new LapPhieuXuatKhoBusiness(chungTuBanHangInfor);
        }

        public frmBH_LapPhieuXuatKho(ChungTuBanHangInfor chungTuBanHangInfor, bool IsView)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            ChungTuBanHang = chungTuBanHangInfor;
            Business = new LapPhieuXuatKhoBusiness(chungTuBanHangInfor.LoaiChungTu, nguoiDung.IdNhanVien, chungTuBanHangInfor.IdKho);
            //Business = new LapPhieuXuatKhoBusiness(chungTuBanHangInfor);
            this.IsView = IsView;
        }

        public void HideMenu(bool isInHoaDon)
        {
            bool enable = ValidEditChungTu();
            //toolStrip1.Enabled = nguoiDung.SupperUser != 1 ? false : true;
            tsbAdd.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbEdit.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            //tsbUpdate.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbDelete.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbConfirm.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbSearch.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbPrint.Enabled = true;
            tsbPrintBH.Enabled = true;

            btnTimOrderKH.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            //btnTimOrderKH.Visible = false;
            this.IsInHoaDon = isInHoaDon;
            Updating = nguoiDung.SupperUser != 1 ? false : enable;
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
            LoadNguoiLap();
            //thong tin don hang
            //IdPhieuXuat = 0;
            //TrangThaiDonHang = (int) OrderStatus.DON_HANG_BAN_TAI_SHOP;
            //txtSoPhieu.ResetText();
            //mstNgayXuat.Value = CommonProvider.Instance.GetSysDate();//.ResetText();//.Text = DateTime.Today.ToString("dd/MM/yyyy");
            txtSoPhieu.ResetText();
            mstNgayXuat.Value = CommonProvider.Instance.GetSysDate();
            //bteNhanVien.Tag = null;
            //bteNhanVien.ResetText();
            cboNhanVien.SelectedIndex = -1;
            cboDoiTac.SelectedIndex = -1;
            txtGhiChuXuat.ResetText();

            //thong tin san pham
            gHangDaXuat.DataSource = null;
            txtMaSanPham.Text = "";
            txtMaSanPham.Focus();
            txtMaSanPham.SelectAll();
        }

        private bool ValidChungTuInfor()
        {
            //Kiem tra dung trang thai don hang hay khong
            if (!BanHangDataProvider.Instance.CheckValid_TrangThai_ChungTu(ChungTuBanHang.IdChungTu, "4,6,7,9,22"))//trang thai dang xuat hoac da xuat
            {
                MessageBox.Show("Trạng thái đơn hàng đã thay đổi!\nKhông thể thực hiện giao dịch này được", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!BanHangDataProvider.Instance.CheckValid_ChungTu_TraLai(ChungTuBanHang.IdChungTu))//trang thai dang xuat hoac da xuat
            {
                MessageBox.Show("Đơn hàng gốc đã bị trả lại!\nKhông thể thực hiện giao dịch này được", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

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

            if (cboNhanVien.Items.Count > 0 && cboNhanVien.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên giao nhận");
                cboNhanVien.Focus();
                return false;
            }

            if (cboDoiTac.Items.Count > 0 && cboDoiTac.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn đối tác giao nhận");
                cboDoiTac.Focus();
                return false;                
            }

            //Nếu không chọn sẽ không đồng bộ được
            if(bteNhanVien.Tag == null)
            {
                MessageBox.Show("Chưa có thông tin người lập phiếu", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.bteNhanVien.Focus();
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

            foreach (DanhSachHangXuatBanInfor ct in (BindingList<DanhSachHangXuatBanInfor>)gHangCanXuat.DataSource)
            {
                if (ct.SoLuongChuaXuat < ct.SoLuongDangXuat)
                {
                    MessageBox.Show("Không được xuất vượt quá số lượng còn lại trên đơn hàng bán. Vui lòng kiểm tra lại.", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtMaSanPham.Focus();
                    return false;
                }
            }
            //kiem tra so luong xuat so voi so luong can xuat
            foreach (DanhSachHangXuatBanInfor ct in liDanhSachHangBanChiTietOld)
            {
                int sl = 0;

                foreach (ChungTuBanHangChiTietHangHoaInfor cthh in Business.ListChiTietHangHoa)
                {
                    if (cthh.IdSanPham == ct.IdSanPham)
                        sl += cthh.SoLuong;
                }
                if (ct.SoLuongChuaXuat < sl)
                {
                    string msg = String.Format("Sản phẩm [{0}] đang xuất [{1}] là vượt quá số lượng đơn hàng [{2}]. Vui lòng kiểm tra lại!", ct.TenSanPham, sl, ct.SoLuongChuaXuat);
                    MessageBox.Show(msg, Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtMaSanPham.Focus();
                    return false;
                }
            }

            return true;
        }

        private void LoadSanPhamBan()
        {
            liSanPhamBan = LapPhieuXuatKhoDataProvider.Instance.GetAllListChiTietHangHoaByMaxMaVach(ChungTuBanHang.IdChungTu, ChungTuBanHang.IdKho);
        }

        private void LoadChungTuInstance()
        {
            if (ChungTuBanHang.IdChungTu!=0)
            {
                LoadNhanVien();
                LoadDoiTacGiaoNhan();
                LoadChungTuHeader();
                LoadChungTuDetails();
                LoadDanhSachPhieuXuat();
            }
            else
            {
                ResetChungTuInfor();
            }
        }
        private void LoadNguoiLap()
        {
            DMNhanVienInfo nv = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(nguoiDung.IdNhanVien);
            if (nv != null)
            {
                bteNhanVien.Text = nv.HoTen;
                bteNhanVien.Tag = nv;
            }
        }
        private void LoadNhanVien()
        {
            List<DMNhanVienInfo> liNhanVien = GiaoNhanDataProvider.Instance.GetListNhanVienByGiaoNhan(ChungTuBanHang.IdChungTu);
            if (liNhanVien != null)
            {
                cboNhanVien.DataSource = liNhanVien;
                cboNhanVien.DisplayMember = "HoTen";
                cboNhanVien.ValueMember = "IdNhanVien";
                cboNhanVien.SelectedIndex = -1;                
            }
        }

        private void LoadDoiTacGiaoNhan()
        {
            List<DMDoiTuongInfo> liDoiTac = GiaoNhanDataProvider.Instance.GetListDoiTacByGiaoNhan(ChungTuBanHang.IdChungTu);
            if (liDoiTac != null)
            {
                cboDoiTac.DataSource = liDoiTac;
                cboDoiTac.DisplayMember = "TenDoiTuong";
                cboDoiTac.ValueMember = "IdDoiTuong";
                cboDoiTac.SelectedIndex = -1;
            }
        }

        private void LoadChungTuHeader()
        {
            LoaiChungTu = ChungTuBanHang.LoaiChungTu;
            TrangThaiDonHang = ChungTuBanHang.TrangThai;
            Draft = ChungTuBanHang.Draft;

            IdKhoSelected = ChungTuBanHang.IdKho;
            bteKhoXuat.Tag = DMKhoDataProvider.GetKhoByIdInfo(ChungTuBanHang.IdKho);
            bteKhoXuat.Text = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).TenKho : "";
            bteKhachHang.Tag = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(ChungTuBanHang.IdDoiTuong);
            bteKhachHang.Text = bteKhachHang.Tag != null ? ((DMDoiTuongInfo)bteKhachHang.Tag).TenDoiTuong : "";
            IdKhoSelected = ChungTuBanHang.IdKho;
            txtGhiChu.Text = ChungTuBanHang.GhiChu;

            txtSoOrderKH.Text = ChungTuBanHang.SoChungTu;
            mstNgayLapPhieu.Value = ChungTuBanHang.NgayLap;
            //txtSoPhieu.Text = Business.ChungTu.SoPhieuXuat;
            //try
            //{
            //    mstNgayXuat.Value = Business.ChungTu.NgayXuatHang;
            //}
            //catch
            //{
            //    mstNgayXuat.Value = DateTime.Now;
            //}

            cboNhanVien.SelectedValue = Business.ChungTu.IdNhanVienGiao;
            cboDoiTac.SelectedValue = Business.ChungTu.IdDuAn;
            //bteNhanVien.Tag = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(Business.ChungTu.IdNhanVienGiao);
            //bteNhanVien.Text = bteNhanVien.Tag != null ? ((DMNhanVienInfo)bteNhanVien.Tag).HoTen : "";
            txtDienThoai.Text = ChungTuBanHang.DienThoai;
            txtHoTenKhachHang.Text = ChungTuBanHang.HoTen;
            txtDiaChi.Text = ChungTuBanHang.DiaChi;
        }

        private void LoadChungTuDetails()
        {
            //Load danh sach hang ban
            liDanhSachHangBanChiTiet = BanHangDataProvider.Instance.GetAllChiTietXuatKhoByIdChungTu(ChungTuBanHang.IdChungTu);
            gHangCanXuat.DataSource = new BindingList<DanhSachHangXuatBanInfor>(liDanhSachHangBanChiTiet);
            ((BindingList<DanhSachHangXuatBanInfor>)gHangCanXuat.DataSource).ResetBindings();

            //luu lai danh sach goc
            liDanhSachHangBanChiTietOld = new List<DanhSachHangXuatBanInfor>();
            foreach (DanhSachHangXuatBanInfor ct in liDanhSachHangBanChiTiet)
            {
                DanhSachHangXuatBanInfor cto = new DanhSachHangXuatBanInfor()
                                                   {
                                                       IdSanPham = ct.IdSanPham,
                                                       ChietKhau = ct.ChietKhau,
                                                       DonViTinh = ct.DonViTinh,
                                                       MaSanPham = ct.MaSanPham,
                                                       SoLuongBan = ct.SoLuongBan,
                                                       SoLuongChuaXuat = ct.SoLuongChuaXuat,
                                                       SoLuongDangXuat = ct.SoLuongDangXuat,
                                                       SoLuongDaXuat = ct.SoLuongDaXuat,
                                                       TenSanPham = ct.TenSanPham,
                                                       TrungMaVach = ct.TrungMaVach
                                                   };
                liDanhSachHangBanChiTietOld.Add(cto);
            }
        }

        private void LoadDanhSachPhieuXuat()
        {
            liPhieuXuat = LapPhieuXuatKhoDataProvider.Instance.LoadAllPhieuXuat(ChungTuBanHang.IdChungTu);
            gPhieuXuat.DataSource = new BindingList<ChungTuBanHangInfor>(liPhieuXuat);
            //if (liPhieuXuat.Count > 0)
            //{
            //    gvPhieuXuat.FocusedRowHandle = 0;
            //}
        }

        private void LoadPhieuXuatInstance()
        {
            if (Business.ChungTu != null)
            {
                LoadPhieuXuatHeader();
                LoadPhieuXuatDetails();
            }
        }

        private void LoadPhieuXuatHeader()
        {
            txtSoPhieu.Text = Business.ChungTu.SoChungTu;
            try
            {
                mstNgayXuat.Value = Business.ChungTu.NgayLap;
            }
            catch
            {
                mstNgayXuat.Value = DateTime.Now;
            }
            bteNhanVien.Tag = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(Business.ChungTu.IdNhanVien);
            bteNhanVien.Text = bteNhanVien.Tag != null ? ((DMNhanVienInfo)bteNhanVien.Tag).HoTen : "";
            cboNhanVien.SelectedValue = Business.ChungTu.IdNhanVienGiao;
            cboDoiTac.SelectedValue = Business.ChungTu.IdDuAn;
            txtGhiChuXuat.Text = Business.ChungTu.GhiChu;
        }

        private void LoadPhieuXuatDetails()
        {
            //Load danh sach ma vach da xuat
            if (Business.ListChiTietHangHoa == null)
            {
                Business.ListChiTietHangHoa = new List<ChungTuBanHangChiTietHangHoaInfor>();
            }

            //tich hop voi phieu dieu chuyen => load cac mavach duoc map san
            if (!IsView && (TrangThaiDonHang != (int)OrderStatus.XUAT_KHO && TrangThaiDonHang != (int)OrderStatus.DANG_XUAT_KHO && ChungTuBanHang.SoPhieuDC != null && !ChungTuBanHang.SoPhieuDC.Equals("")))
            {
                LoadMaVachTuPhieuDieuChuyen();
            }
            gHangDaXuat.DataSource = new BindingList<ChungTuBanHangChiTietHangHoaInfor>(Business.ListChiTietHangHoa);
            ((BindingList<ChungTuBanHangChiTietHangHoaInfor>)gHangDaXuat.DataSource).ResetBindings();
            
            SoLuong.OptionsColumn.ReadOnly = Business.ChungTu != null && Business.ChungTu.IdChungTu > 0 && Business.ChungTu.Draft == 0;
            
            UpdateDetailStatus();            
        }
        //tich hop voi phieu dieu chuyen => load cac mavach duoc map san
        private void LoadMaVachTuPhieuDieuChuyen()
        {
            Business.ListChiTietHangHoa =
                LapPhieuXuatKhoDataProvider.Instance.GetListChiTietHangHoaByPhieuDC(ChungTuBanHang.SoPhieuDC, ChungTuBanHang.SoChungTu);
        }

        private void UpdateDetailStatus()
        {
            foreach (DanhSachHangXuatBanInfor ct in (BindingList<DanhSachHangXuatBanInfor>)gHangCanXuat.DataSource)
            {
                if (!Common.Int2Bool(ct.ChietKhau))
                    ct.SoLuongDangXuat = 0;                
            }
            //foreach (ChungTuBanHangChiTietHangHoaInfor cthh in (BindingList<ChungTuBanHangChiTietHangHoaInfor>)gHangDaXuat.DataSource)
            //{
            //    UpdateMaVach(cthh);
            //}
        }

        private bool UpdateMaVach(ChungTuBanHangChiTietHangHoaInfor cthh)
        {
            //tim trong danh sach hang ban chinh neu co => gan ma vach cho hang ban
            DanhSachHangXuatBanInfor ct = null;
            ct = liDanhSachHangBanChiTiet.Find(
                delegate(DanhSachHangXuatBanInfor t)
                    {
                        return t.IdSanPham == cthh.IdSanPham && t.SoLuongChuaXuat > t.SoLuongDangXuat;
                    });
            if (ct != null && (ct.SoLuongDangXuat + cthh.SoLuong <= ct.SoLuongChuaXuat))
            {
                ct.SoLuongDangXuat += cthh.SoLuong;
            }
            else
            {
                MessageBox.Show("Không đúng sản phẩm cần xuất hoặc đã xuất đủ hàng. Vui lòng chọn lại!");
                return false;
            }
            ((BindingList<DanhSachHangXuatBanInfor>)gHangCanXuat.DataSource).ResetBindings();
            return true;
        }

        //private int GetTrangThaiDonHang()
        //{
        //    bool dangXuat = false;
        //    foreach (DanhSachHangXuatBanInfor ct in (BindingList<DanhSachHangXuatBanInfor>)gHangCanXuat.DataSource)
        //    {
        //        if (ct.SoLuongDaXuat == 0 && ct.SoLuongDangXuat != 0 || ct.SoLuongDaXuat > 0)
        //        {
        //            dangXuat = true;
        //            break;
        //        }
        //    }
        //    if (!dangXuat)
        //        return -1;
        //    else
        //    {
        //        bool xuatHet = true;
        //        foreach (DanhSachHangXuatBanInfor ct in (BindingList<DanhSachHangXuatBanInfor>)gHangCanXuat.DataSource)
        //        {
        //            if (ct.SoLuongChuaXuat != ct.SoLuongDangXuat)
        //            {
        //                xuatHet = false;
        //                break;
        //            }
        //        }
        //        if (xuatHet)
        //            return (int)OrderStatus.XUAT_KHO;
        //        else
        //            return (int)OrderStatus.DANG_XUAT_KHO;                
        //    }
        //}
        private int GetTrangThaiDonHang(List<DanhSachHangXuatBanInfor> liHangBan)
        {
            int soLuongBan = 0;
            int soLuongXuat = 0;

            foreach (DanhSachHangXuatBanInfor ct in liHangBan)
            {
                if (ct.ChietKhau != 1)
                {
                    soLuongBan += ct.SoLuongBan;
                    soLuongXuat += ct.SoLuongDaXuat;
                }
            }
            if (soLuongBan == soLuongXuat)
                return (int)OrderStatus.XUAT_KHO;
            else if (soLuongBan != 0 && soLuongXuat != 0)
                return (int) OrderStatus.DANG_XUAT_KHO;

            return -1;
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
                tsbUpdate.Enabled = false;

                if (ChungTuBanHang != null)
                {
                    LoadChungTuInstance();
                    if (IsView)
                    {
                        //if (liPhieuXuat.Count > 0)
                        //{
                        //    gvPhieuXuat.FocusedRowHandle = 0;
                        //    gvPhieuXuat_FocusedRowChanged(null, null);
                        //}
                        IsAdded = false;
                        Updating = false;
                        setEDItems();
                        setEDFunctions();                        
                    }
                    else
                    {
                        int trangThai = GetTrangThaiDonHang(liDanhSachHangBanChiTiet);
                        //Thiet lap trang thai item                    
                        if (trangThai != (int)OrderStatus.XUAT_KHO)
                        {
                            tsbAdd_Click(sender, e);
                        }
                        else
                        {
                            //if (liPhieuXuat.Count > 0)
                            //{
                            //    gvPhieuXuat.FocusedRowHandle = 0;
                            //    gvPhieuXuat_FocusedRowChanged(null, null);
                            //}

                            IsAdded = false;
                            Updating = false;
                            setEDItems();
                            setEDFunctions();
                        }                        
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
                else if (e.KeyCode == Keys.F11 && tsbPrintBH.Enabled)
                    this.tsbPrintBH_Click(sender, e);
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
                if (String.IsNullOrEmpty(code) ||
                    
                    String.IsNullOrEmpty(code.Trim())) return;

                List<ChungTuBanHangChiTietHangHoaInfor> liCT = liSanPhamBan.FindAll(delegate(ChungTuBanHangChiTietHangHoaInfor match)
                                                                               {
                                                                                   return match.MaVach.Equals(code) &&
                                                                                          match.SoLuong > 0;
                                                                               });

                ChungTuBanHangChiTietHangHoaInfor ct = null;
                if (liCT != null && liCT.Count == 1)
                {
                    ct = liCT[0];
                }
                else
                {
                    if (liCT == null || liCT.Count == 0)
                        liCT = liSanPhamBan;

                    frmLookUp_MaVach frm = new frmLookUp_MaVach(false, liCT, true);
                    
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        if (frm.SelectedItem.MaVach.ToLower() == frm.SearchValue.ToLower())
                            ct = frm.SelectedItem;
                    }
                }

                if (ct != null)
                {
                    //if (!CheckMaVachTheoChinhSach(ChungTuBanHang.IdChungTu, ct.IdSanPham, ct.MaVach))
                    //{
                    //    MessageBox.Show("Mã vạch này không nằm trong danh sách các mã vạch được áp dụng chính sách ưu đãi!");
                    //    return;
                    //}

                    liCT.Sort(delegate(ChungTuBanHangChiTietHangHoaInfor cmp1, ChungTuBanHangChiTietHangHoaInfor cmp2)
                                  {
                                      return cmp1.TuoiTon < cmp2.TuoiTon ? 1 :
                                          cmp1.TuoiTon == cmp2.TuoiTon ? 0 : -1;
                                  });
                    
                    var liTmp = new List<ChungTuBanHangChiTietHangHoaInfor>();

                    int tuoiton = 0;
                    int changed = LapPhieuXuatKhoDataProvider.Instance.GetAmountPermission(ct.IdSanPham, ChungTuBanHang.IdKho);
                    int amount = changed;

                    foreach (var infor in liCT)
                    {
                        if(ct.IdSanPham == infor.IdSanPham)
                        {
                            if (tuoiton != 0 && tuoiton != infor.TuoiTon)
                            {
                                changed--;
                            }
                            tuoiton = infor.TuoiTon;

                            if (changed > 0)

                                liTmp.Add(infor);

                            else

                                break;                            
                        }
                    }

                    if (!liTmp.Exists(delegate(ChungTuBanHangChiTietHangHoaInfor match)
                    {
                        return ct.IdSanPham == match.IdSanPham && match.MaVach == ct.MaVach;
                    }))
                    {
                        MessageBox.Show(String.Format("Bạn chưa chọn đúng mã vạch thuộc {0} tuổi tồn lâu nhất!", amount));

                        return;
                    }

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
                            { return match.MaVach.Equals(cthh.MaVach) && match.IdSanPham == cthh.IdSanPham; });

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

                txtMaSanPham.Text = String.Empty;
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
            InputDataFromCode(txtMaSanPham.Text);
        }
        private bool CheckMaVachTheoChinhSach(int idChungTu, int idSanPham, string maVach)
        {
            try
            {
                if (Business.ListChiTietHangHoa.Exists(delegate(ChungTuBanHangChiTietHangHoaInfor hh)
                {
                    return hh.IdSanPham == idSanPham && hh.MaVach.Equals(maVach);
                }))
                {
                    return true;
                }

                List<ChungTuBanHangChiTietInfor> liCT = BanHangDataProvider.Instance.GetListChiTietChungTuKhuyenMai(idChungTu, idSanPham);
                if (liCT.Count == 0) return true;

                foreach (ChungTuBanHangChiTietInfor ct in liCT)
                {
                    string lstIdDKMua = ct.ListIdChinhSach.Replace(";", ",");
                    lstIdDKMua = lstIdDKMua.TrimStart(",".ToCharArray());
                    lstIdDKMua = lstIdDKMua.TrimEnd(",".ToCharArray());
                    if (lstIdDKMua.Length > 0)
                    {
                        if (BanHangDataProvider.Instance.ValidMaVach(lstIdDKMua, maVach))
                            return true;
                    }
                }
            }
            catch
            {
                return true;
            }

            return false;
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
            if (Business.ChungTu.IdChungTu == 0 || Business.ChungTu.IdChungTu > 0 && (Draft != 0 /*|| nguoiDung.SupperUser == 1*/))
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
            //mstNgayXuat.Enabled = Updating;
            bteNhanVien.Enabled = Updating;
            cboNhanVien.Enabled = Updating;
            cboDoiTac.Enabled = Updating;
            txtGhiChuXuat.Enabled = Updating;
            //txtDienThoai.Enabled = Updating;
            //txtHoTenKhachHang.Enabled = Updating;
            //txtDiaChi.Enabled = Updating;

            txtMaSanPham.Enabled = Updating;
            btnThemHang.Enabled = Updating;
            btnXoaMaVach.Enabled = Updating;
        }

        private void setEDFunctions()
        {
            int tthai = gHangCanXuat.DataSource != null ? GetTrangThaiDonHang(liDanhSachHangBanChiTiet) : 0;
            tsbAdd.Enabled = !Updating && (tthai != (int)OrderStatus.XUAT_KHO);//them moi, chuyen don hang online, don dat hang truoc
            tsbEdit.Enabled = !Updating && (Business.ChungTu.IdChungTu == 0 || Business.ChungTu.IdChungTu > 0 && (Common.Int2Bool(Draft)  || nguoiDung.SupperUser == 1));
            //tsbUpdate.Enabled = Updating;//cap nhat
            //tsbDelete.Enabled = (TrangThaiDonHang == (int)OrderStatus.XUAT_KHO);//xoa, huy don hang online, dat truoc
            tsbConfirm.Enabled = Updating;//xac nhan
            tsbPrint.Enabled = !Updating && (Business.ChungTu.IdChungTu > 0);
            tsbPrintBH.Enabled = !Updating && (Business.ChungTu.IdChungTu > 0);
        }

        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                return;
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
            int oldId = Business.ChungTu.IdChungTu;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (ValidChungTuInfor())
                {
                    ConnectionUtil.Instance.BeginTransaction();
                    //cap nhat phieu xuat kho
                    SaveChungTuInstance();
                    Business.SaveChungTu();

                    //cap nhat trang thai don hang chinh
                    List<DanhSachHangXuatBanInfor> liHangBan = BanHangDataProvider.Instance.GetAllChiTietXuatKhoByIdChungTu(ChungTuBanHang.IdChungTu);
                    int trangThaiXuat = GetTrangThaiDonHang(liHangBan);
                    if (trangThaiXuat != -1)
                    {
                        int result = SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(), CommandType.Text,
                                                  String.Format(
                                                      "update tbl_chungtu t set t.trangthai = {0} where idchungtu = {1} and lockid = 1 and lockaccount='{2}' and lockmachine='{3}' and processid='{4}'",
                                                      trangThaiXuat, ChungTuBanHang.IdChungTu, ChungTuBanHang.LockAccount, ChungTuBanHang.LockMachine, ChungTuBanHang.ProcessId));
                        if(result == 0)
                        {
                            throw new ManagedException("Lock chứng từ không còn hiệu lực, không thể thực hiện giao dịch.");
                        }
                        //update tinh trang giao nhan
                        SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(), CommandType.Text,
                                                  String.Format("update tbl_chungtu_giaonhan set tinhtrang=1 where idgiaonhan in (select idphieugiaonhan from tbl_chungtu where idchungtu = {0})", ChungTuBanHang.IdChungTu));
                    }

                    ConnectionUtil.Instance.CommitTransaction();
                    if (IsAdded)
                    {
                        liPhieuXuat.Add(Business.ChungTu);
                        ((BindingList<ChungTuBanHangInfor>)gPhieuXuat.DataSource).ResetBindings();
                        LoadChungTuDetails();
                        MessageBox.Show("Lập phiếu xuất kho thành công!");
                    }                        
                    else
                    {
                        ((BindingList<ChungTuBanHangInfor>)gPhieuXuat.DataSource).ResetBindings();
                        LoadChungTuDetails();
                        MessageBox.Show("Cập nhật phiếu xuất kho thành công!");
                    }
                        
                    return true;
                }                
            }
            catch (Exception)
            {
                ConnectionUtil.Instance.RollbackTransaction();
                Business.ChungTu.IdChungTu = oldId;
                throw;
            }
            Cursor.Current = Cursors.Default;
            return false;
        }

        private void SaveChungTuInstance()
        {
            UpdatePhieuXuatHeader();
            UpdatePhieuXuatDetails();
        }
        private void UpdatePhieuXuatHeader()
        {
            //update trang thai don hang
            TrangThaiDonHang = (int)OrderStatus.XUAT_KHO;
            //update header
            Business.ChungTu.IdKho = ChungTuBanHang.IdKho;
            Business.ChungTu.IdTrungTam = ChungTuBanHang.IdTrungTam;
            Business.ChungTu.SoChungTu = txtSoPhieu.Text;
            Business.ChungTu.SoChungTuGoc = ChungTuBanHang.SoChungTu;
            Business.ChungTu.SoSeri = ChungTuBanHang.SoSeri;
            Business.ChungTu.KyHieu = ChungTuBanHang.KyHieu;
            Business.ChungTu.GiaoNhan = ChungTuBanHang.GiaoNhan;
            Business.ChungTu.IdDoiTuong = ChungTuBanHang.IdDoiTuong;
            Business.ChungTu.IdKhachLe = ChungTuBanHang.IdKhachLe;
            Business.ChungTu.IdNhanVien = bteNhanVien.Tag != null ? ((DMNhanVienInfo)bteNhanVien.Tag).IdNhanVien : 0;
            Business.ChungTu.IdNhanVienGiao = Common.IntValue(cboNhanVien.SelectedValue);
            Business.ChungTu.IdDuAn = Common.IntValue(cboDoiTac.SelectedValue);//doi tac giao nhan
            Business.ChungTu.GhiChu = txtGhiChuXuat.Text.Trim();
            Business.ChungTu.LoaiChungTu = (int) TransactionType.XUAT_KHO_HANG_BAN;
            Business.ChungTu.TrangThai = (int)OrderStatus.XUAT_KHO;
            Business.ChungTu.Draft = Draft;

            if (Business.ChungTu.IdChungTu == 0)
            {
                Business.ChungTu.NguoiTao = nguoiDung.TenDangNhap;
                Business.ChungTu.TenMayTao = Declare.TenMay;
                Business.ChungTu.NguoiSua = nguoiDung.TenDangNhap;
                Business.ChungTu.TenMaySua = Declare.TenMay;
                mstNgayXuat.Value = CommonProvider.Instance.GetSysDate();
            }
            else
            {
                Business.ChungTu.NguoiSua = nguoiDung.TenDangNhap;
                Business.ChungTu.TenMaySua = Declare.TenMay;
            }

            Business.ChungTu.NgayLap = mstNgayXuat.Value;
            Business.ChungTu.NgayXuatHang = mstNgayXuat.Value;
        }
        private void UpdatePhieuXuatDetails()
        {
            if (Business.ListChiTietChungTu == null)
            {
                Business.ListChiTietChungTu = new List<ChungTuBanHangChiTietInfor>();
            }
            foreach (ChungTuBanHangChiTietHangHoaInfor cthh in Business.ListChiTietHangHoa)
            {
                ChungTuBanHangChiTietInfor ct = Business.ListChiTietChungTu.Find(delegate(ChungTuBanHangChiTietInfor match)
                                                                               {
                                                                                   return match.IdSanPham == cthh.IdSanPham;
                                                                               });
                if (ct == null)
                {
                    ct = new ChungTuBanHangChiTietInfor(cthh);
                    Business.ListChiTietChungTu.Add(ct);
                }
                else
                {
                    ct.SoLuong += cthh.SoLuong;
                }
            }
        }
        private bool ValidDeleteChungTu()
        {
            if (Draft != 0 || nguoiDung.SupperUser == 1)// && TrangThaiDonHang == (int)OrderStatus.XUAT_KHO)
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
                return;

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

        private int RestoreTrangThaiChungTu()
        {
            int trangthai = GetTrangThaiDonHang(liDanhSachHangBanChiTiet);
            if (trangthai != -1) return -1;//neu dang xuat thi giu nguyen ko doi trang thai
            //neu xoa ve chua xuat thi khoi phuc lai trang thai
            //if (TrangThaiDonHang == (int)OrderStatus.XUAT_KHO)
            //{
                if (ChungTuBanHang.GiaoNhan == 1)
                {
                    return (int) OrderStatus.XAC_NHAN_DON_HANG_GIAO_NHAN;
                }
                else
                {
                    if (ChungTuBanHang.LoaiChungTu == (int)TransactionType.DON_HANG_TAI_SHOP || ChungTuBanHang.LoaiChungTu == (int)TransactionType.DON_HANG_BU_KHUYEN_MAI)
                        return (int) OrderStatus.DON_HANG_BAN_TAI_SHOP;
                    else if (ChungTuBanHang.LoaiChungTu == (int)TransactionType.DON_HANG_DAT_TRUOC)
                        return (int) OrderStatus.DON_HANG_BAN_DAT_TRUOC;
                    else if (ChungTuBanHang.LoaiChungTu == (int)TransactionType.DON_HANG_ONLINE)
                        return (int) OrderStatus.DON_HANG_BAN_ONLINE;
                    else if (ChungTuBanHang.LoaiChungTu == (int)TransactionType.DON_HANG_GIAO_NHAN)
                        return (int)OrderStatus.XAC_NHAN_DON_HANG_GIAO_NHAN;
                }                
            //}
            return -1;
        }
        private void DeleteChungTu()
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn hủy phiếu xuất này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Business.ChungTu.IdChungTu > 0)
                    {
                        ConnectionUtil.Instance.BeginTransaction();
                        ////khoi phuc trang thai chungtu
                        //RestoreTrangThaiChungTu();

                        ////restore trang thai don hang cu
                        //Business.ChungTu.TrangThai = TrangThaiDonHang;
                        //Business.ChungTu.SoPhieuXuat = "";
                        //Business.ChungTu.Draft = 0;
                        //Business.SaveChungTu();//cap nhat trang thai

                        Business.DeleteChungTu();//xoa chung tu kho, khoi phuc ton kho

                        LoadChungTuInstance();

                        int trangThai = RestoreTrangThaiChungTu();
                        if (trangThai != -1)
                        {
                            SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(), CommandType.Text,
                                                      String.Format("update tbl_chungtu t set t.trangthai = {0} where idchungtu = {1}", trangThai, ChungTuBanHang.IdChungTu));
                            
                        }
                        ConnectionUtil.Instance.CommitTransaction();
                    }
                    MessageBox.Show("Hủy phiếu xuất thành công!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                ConnectionUtil.Instance.RollbackTransaction();
#if DEBUG
                MessageBox.Show("Lỗi thực hiện Xóa đơn hàng\n" + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi thực hiện Xóa đơn hàng", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }
        private void tsbPrint_Click(object sender, EventArgs e)
        {
            if (ChungTuBanHang.IdChungTu == 0 || ChungTuBanHang.Draft == 1)
            {
                MessageBox.Show("Đơn hàng chưa được xác nhận. Không thể in được!");
                return;
            }
            if (gvHangDaXuat.RowCount == 0)
            {
                MessageBox.Show("Chưa có sản phẩm xuất bán");
                return;
            }
            InPhieuXuatKho();
            //if (MessageBox.Show("Có in kèm phiếu bảo hành hay không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    InPhieuBaoHanh();
            //}
        }

        private void InPhieuXuatKho()
        {
            ChungTuBanHangInfor ctu = BanHangDataProvider.Instance.LoadChungTuBySoChTu(
                Business.ChungTu.SoChungTuGoc);
            rpt_PhieuXuatKho rp = new rpt_PhieuXuatKho(ctu, Business.ChungTu.SoChungTu);
            //foreach (ChungTuBanHangChiTietInfor ct in Business.ListChiTietChungTu)
            //{
            //    ct.DonGiaCoVat = ct.DonGia + ct.TienVAT;
            //}
            rp.DataSource = Business.ListChiTietHangHoa;
            rp.ShowPreview();
        }

        private void InPhieuBaoHanh()
        {
            ChungTuBanHangInfor ctu = BanHangDataProvider.Instance.LoadChungTuBySoChTu(
                 Business.ChungTu.SoChungTuGoc);
            frmIn_PhieuBaoHanh frm = new frmIn_PhieuBaoHanh(ctu);
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
                    Business = new LapPhieuXuatKhoBusiness(ctu);
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
                InputDataFromCode(txtMaSanPham.Text);
            }
        }

        private void txtMaSanPham_Enter(object sender, EventArgs e)
        {
            this.txtMaSanPham.Focus();
            this.txtMaSanPham.SelectAll();
        }

        private void txtMaSanPham_Leave(object sender, EventArgs e)
        {
            InputDataFromCode(txtMaSanPham.Text);
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
                ((BindingList<DanhSachHangXuatBanInfor>)gHangCanXuat.DataSource).ResetBindings();
            }
        }

        private void gvHangDaXuat_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            UpdateDetailStatus();
        }

        private void gvPhieuXuat_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ChungTuBanHangInfor phieuXuat = (ChungTuBanHangInfor) gvPhieuXuat.GetRow(gvPhieuXuat.FocusedRowHandle);
            if (phieuXuat != null)
            {
                Business = new LapPhieuXuatKhoBusiness(phieuXuat);
                LoadPhieuXuatInstance();

                IsAdded = false;
                Updating = false;
                setEDItems();
                setEDFunctions();
            }
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ThemMoiDonHang();

                Updating = true;
                setEDItems();
                setEDFunctions();
                LoadSanPhamBan();
                ShowInfors();
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

        private void ThemMoiDonHang()
        {
            Draft = -1;
            IsAdded = true;
            ResetChungTuInfor();
            Business = new LapPhieuXuatKhoBusiness(LoaiChungTu, nguoiDung.IdNhanVien, ((DMKhoInfo)bteKhoXuat.Tag).IdKho);

            txtSoPhieu.Prefix = Declare.Prefix.PhieuXuatKhoHangBan;
            txtSoPhieu.ReSet();//.Text = CommonProvider.Instance.GetSoPhieu(Declare.Prefix.PhieuXuatKhoHangBan);

            Business.ListChiTietChungTu = new List<ChungTuBanHangChiTietInfor>();

            Business.ListChiTietHangHoa = new List<ChungTuBanHangChiTietHangHoaInfor>();
            gHangDaXuat.DataSource = new BindingList<ChungTuBanHangChiTietHangHoaInfor>(Business.ListChiTietHangHoa);            
        }

        private void bteNhanVien_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int IdKhoSelected = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : 0;
            UtilFunctions.bteNhanVien_ButtonClick(sender, e, bteNhanVien, IdKhoSelected);
        }

        private void bteNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            int IdKhoSelected = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : 0;
            UtilFunctions.bteNhanVien_KeyDown(sender, e, bteNhanVien, IdKhoSelected);
        }

        private void bteNhanVien_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteNhanVien);
        }

        private void tsbPrintBH_Click(object sender, EventArgs e)
        {
            if (ChungTuBanHang.IdChungTu == 0 || ChungTuBanHang.Draft == 1)
            {
                MessageBox.Show("Đơn hàng chưa được xác nhận. Không thể in được!");
                return;
            }
            if (gvHangDaXuat.RowCount == 0)
            {
                MessageBox.Show("Chưa có sản phẩm xuất bán");
                return;
            }
            InPhieuBaoHanh();
        }
    }
}