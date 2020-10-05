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
using QLBH.Core.Business;
using QLBH.Core.Data;
using QLBH.Core.Exceptions;
using QLBH.Core.Infors;
using QLBH.Core.Providers;
using QLBanHang.Modules.DanhMuc;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBH_LapDonHangGiaoNhan : DevExpress.XtraEditors.XtraForm
    {
        #region "Khai báo biến"
        private int Draft = -1;//-1:chua ton tai; 1-save, 0-confirm
        private bool IsAdded = false;
        private bool Updating = false;//false: chua sua, tao moi; 1:dang sua, tao moi
        private bool IsGNhan = false;
        private bool UpdGN = false;
        private bool ChoPhepSua = false;
        
        private int _IdKho = Declare.IdKho;
        private int _IdTrungTam = Declare.IdTrungTam;
        private int _IdTrungTamHachToan = Declare.IdTrungTamHachToan;
        private int _IdLoaiKhachHang = Declare.IdLoaiKhachHang;
                
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor) Declare.USER_INFOR
                                               : new NguoiDungInfor();

        private int TrangThaiDonHang = (int)OrderStatus.PHAN_CONG_GIAO_NHAN;
        private int LoaiChungTu = (int) TransactionType.DON_HANG_GIAO_NHAN;
        private string ListIdChungTu = "";

        private List<ChungTuBanHangInfor> LstPhieuPCGN = new List<ChungTuBanHangInfor>();
        private List<HangBanGiaoNhanChiTietInfor> liHangGiaoNhan = new List<HangBanGiaoNhanChiTietInfor>();
        private PhanCongGiaoNhanBusiness Business;
        private ChungTuGiaoNhanInfor GiaoNhan;
        private bool IsInHoaDon = false;
        #endregion

        #region "Các phương thức khởi tạo"
        public frmBH_LapDonHangGiaoNhan()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            Business = new PhanCongGiaoNhanBusiness(LoaiChungTu, nguoiDung.IdNhanVien, _IdKho);
            GiaoNhan = new ChungTuGiaoNhanInfor();
            IsGNhan = false;
            Common.SetEDControl(false, false, tsbSuaGN, tsbXacNhanGN);
        }

        public frmBH_LapDonHangGiaoNhan(List<ChungTuBanHangInfor> lstPhieuPCGN)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.LstPhieuPCGN = lstPhieuPCGN;
            Business = new PhanCongGiaoNhanBusiness(LoaiChungTu, nguoiDung.IdNhanVien, _IdKho);
            GiaoNhan = new ChungTuGiaoNhanInfor();
            IsGNhan = false;
            Common.SetEDControl(false, false, tsbSuaGN, tsbXacNhanGN);
        }
        public frmBH_LapDonHangGiaoNhan(bool coHoaDon, List<ChungTuBanHangInfor> lstPhieuPCGN)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.LstPhieuPCGN = lstPhieuPCGN;
            Business = new PhanCongGiaoNhanBusiness(LoaiChungTu, nguoiDung.IdNhanVien, _IdKho);
            GiaoNhan = new ChungTuGiaoNhanInfor();
            IsGNhan = false;
            Common.SetEDControl(false, false, tsbSuaGN, tsbXacNhanGN);
        }
        public frmBH_LapDonHangGiaoNhan(List<ChungTuBanHangInfor> lstPhieuPCGN, bool ChoPhepSua)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.LstPhieuPCGN = lstPhieuPCGN;
            Business = new PhanCongGiaoNhanBusiness(LoaiChungTu, nguoiDung.IdNhanVien, _IdKho);
            GiaoNhan = new ChungTuGiaoNhanInfor();
            this.ChoPhepSua = ChoPhepSua;
        }
        public void HideMenu(bool isInHoaDon)
        {
            bool enable = ValidEditChungTu();
            //toolStrip1.Enabled = nguoiDung.SupperUser != 1 ? false : true;

            tsbEdit.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbUpdate.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbDelete.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbConfirm.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbSearch.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbSuaGN.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbXacNhanGN.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbPrint.Enabled = true;

            //btnTimOrderKH.Enabled = nguoiDung.SupperUser != 1 ? false : true;
            //btnTimOrderKH.Visible = false;
            this.IsInHoaDon = isInHoaDon;
            Updating = nguoiDung.SupperUser != 1 ? false : enable;
            setEDItems();
        }
        #endregion

        #region "Các phương thức"
        private void LoadKhoXuat()
        {
            try
            {
                DMKhoInfo dmKho = DMKhoDataProvider.GetKhoByIdInfo(_IdKho);
                if (dmKho != null)
                {
                    bteKhoXuat.Text = dmKho.TenKho;
                    bteKhoXuat.Tag = dmKho;
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
        }

        /// <summary>
        /// Khoi tao don hang
        /// </summary>
        /// <returns></returns>
        private void ResetChungTuInfor()
        {
            LoadKhoXuat();

            //reset phan cong giao nhan
            txtSoPhieuPCGN.ResetText();
            cboTinhTrangGN.SelectedIndex = 0;
            mstNgayPhanCong.Value = CommonProvider.Instance.GetSysDate();
            mstThoiGianGiaoTu.Value = mstNgayPhanCong.Value;
            mstThoiGianGiaoDen.Value = mstNgayPhanCong.Value;
            mstNgayHoanThanh.Value = mstNgayPhanCong.Value;
            txtGhiChuPNGN.ResetText();
            gPhanCongGiaoNhan.DataSource = null;

            //thong tin don hang
            //IdPhieuXuat = 0;
            //TrangThaiDonHang = (int) OrderStatus.DON_HANG_BAN_TAI_SHOP;
            txtSoOrderKH.ResetText();
            mstNgayLapPhieu.Value = CommonProvider.Instance.GetSysDate();//.ResetText();//.Text = DateTime.Today.ToString("dd/MM/yyyy");
            txtGhiChu.ResetText();
            gHangGiaoVan.DataSource = null;
            txtMaSanPham.Text = "";
            txtMaSanPham.Focus();
            txtMaSanPham.SelectAll();
        }

        private bool ValidChungTuInfor()
        {
            //Kiem tra trung so phieu
            if (this.txtSoPhieuPCGN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Số phiếu phân công chưa nhập." + "\nHãy nhập số phiếu", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                xtabHangGiaoNhan.SelectedTabPage = xtabPhanCongGiaoNhan;
                this.txtSoPhieuPCGN.Focus();
                return false;
            }
            //Kiem tra trung so phieu
            if (BanHangDataProvider.Instance.ExistChungTu((int)TransactionType.PHAN_CONG_GIAO_NHAN, txtSoPhieuPCGN.Text.Trim(), (int)SearchOrderType.SOCHUNGTU, GiaoNhan.IdGiaoNhan))//trung sochungtu
            {
                MessageBox.Show("Số phiếu này đã có." + "\nHãy nhập lại", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                xtabHangGiaoNhan.SelectedTabPage = xtabPhanCongGiaoNhan;
                this.txtSoPhieuPCGN.Focus();
                return false;
            }
            if (mstNgayPhanCong.Value > mstNgayHoanThanh.Value)
            {
                MessageBox.Show("Ngày hoàn thành không thể trước ngày phân công được." + "\nHãy nhập lại ngày hoàn thành", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.mstNgayHoanThanh.Focus();
                return false;
            }
            if (mstNgayPhanCong.Value > mstThoiGianGiaoTu.Value)
            {
                MessageBox.Show("Thời gian phân công không thể trước Thời gian bắt đầu thực hiện được." + "\nHãy nhập lại ngày hoàn thành", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.mstThoiGianGiaoTu.Focus();
                return false;
            }
            if (mstThoiGianGiaoTu.Value > mstThoiGianGiaoDen.Value)
            {
                MessageBox.Show("Thời gian bắt đầu phải nhỏ hơn thời gian kết thúc." + "\nHãy nhập lại", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.mstThoiGianGiaoTu.Focus();
                return false;
            }
            //
            //Kiểm tra thông tin chi tiết phân công
            //
            if (this.gvPhanCongGiaoNhan.RowCount == 0)
            {
                MessageBox.Show("Không có dữ liệu phân công giao nhận.", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                xtabHangGiaoNhan.SelectedTabPage = xtabPhanCongGiaoNhan;
                return false;
            }
            if (this.gvHangGiaoNhan.RowCount > 0)
            {
                if (this.bteKhoXuat.Tag == null)
                {
                    MessageBox.Show("Chưa chọn kho xuất." + "\n" + "-Hãy chọn kho", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    xtabHangGiaoNhan.SelectedTabPage = xtabHangKemGiaoNhan;
                    this.bteKhoXuat.Focus();
                    return false;
                }
                //Kiem tra trung so phieu
                if (this.txtSoOrderKH.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Số giao dịch chưa nhập." + "\nHãy nhập số giao dịch", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    xtabHangGiaoNhan.SelectedTabPage = xtabHangKemGiaoNhan;
                    this.txtSoOrderKH.Focus();
                    return false;
                }
                //Kiem tra trung so phieu
                if (BanHangDataProvider.Instance.ExistChungTu(Business.ChungTu.LoaiChungTu, txtSoOrderKH.Text.Trim(), (int)SearchOrderType.SOCHUNGTU, Business.ChungTu.IdChungTu))//trung sochungtu
                {
                    MessageBox.Show("Số phiếu này đã có." + "\nHãy nhập lại", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    xtabHangGiaoNhan.SelectedTabPage = xtabHangKemGiaoNhan;
                    this.txtSoOrderKH.Focus();
                    return false;
                }  
                //Kiem tra nhan vien di nhan hang giao nhan
                if (this.cboNhanVien.SelectedIndex < 0)
                {
                    MessageBox.Show("Chưa chọn nhân viên nhận hàng giao nhận." + "\nHãy chọn nhân viên", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    xtabHangGiaoNhan.SelectedTabPage = xtabHangKemGiaoNhan;
                    this.cboNhanVien.Focus();
                    return false;
                }            
            }
            foreach (ChungTuBanHangInfor ct in LstPhieuPCGN)
            {
                if (ct.NgayLap > mstNgayPhanCong.Value)
                {
                    MessageBox.Show("Ngày phân công không thể trước ngày lập phiếu được." + "\nHãy nhập lại ngày phân công", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.mstNgayPhanCong.Focus();
                    return false;                    
                }
                if (ct.NgayLap > mstNgayHoanThanh.Value)
                {
                    MessageBox.Show("Ngày hoàn thành không thể trước ngày lập phiếu được." + "\nHãy nhập lại ngày hoàn thành", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.mstNgayHoanThanh.Focus();
                    return false;
                }
                if (this.gvHangGiaoNhan.RowCount > 0 && ct.NgayLap > mstNgayLapPhieu.Value)
                {
                    MessageBox.Show("Ngày lập đơn hàng giao nhận không thể trước ngày lập phiếu được." + "\nHãy nhập lại ngày đơn hàng giao nhận", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.mstNgayLapPhieu.Focus();
                    return false;
                }
            }
            return true;
        }

        private void LoadAllChiTietHangBan()
        {
            ListIdChungTu = "";
            foreach (ChungTuBanHangInfor ct in LstPhieuPCGN)
            {
                ListIdChungTu = ListIdChungTu + ct.IdChungTu.ToString() + ",";
            }
            if (ListIdChungTu.Length > 0)
                ListIdChungTu = ListIdChungTu.TrimEnd(",".ToCharArray());
//                ListIdChungTu = ListIdChungTu.Substring(0, ListIdChungTu.Length - 1);

            List<TrangThaiBH> liLoaiDH = Common.GetListLoaiDonHang();
            repLoaiDonHang.DataSource = liLoaiDH;

            liHangGiaoNhan = BanHangDataProvider.Instance.GetListChiTietChungTuByListIdChungTu(ListIdChungTu);
            gHangCanXuat.DataSource = new BindingList<HangBanGiaoNhanChiTietInfor>(liHangGiaoNhan);
            gvHangCanXuat.ExpandAllGroups();
        }
        private void LoadChungTuInstance()
        {
            if (GiaoNhan != null)
            {
                LoadPhieuGiaoNhanInfor();
                LoadDonHangGiaoNhanInfor();
            }
            else
            {
                ResetChungTuInfor();
            }
        }
        private void LoadPhieuGiaoNhanInfor()
        {
            LoadPhieuGiaoNhanHeader();
            LoadPhieuGiaoNhanDetails();

        }
        private void LoadPhieuGiaoNhanHeader()
        {
            cboTinhTrangGN.SelectedIndex = GiaoNhan.TinhTrang;
            Draft = GiaoNhan.Draft;
            txtSoPhieuPCGN.Text = GiaoNhan.SoPhieuPhanCong;
            mstNgayPhanCong.Value = GiaoNhan.NgayPhanCong;
            mstThoiGianGiaoTu.Value = Common.DateValue(GiaoNhan.ThoiGianGiaoTu);
            mstThoiGianGiaoDen.Value = Common.DateValue(GiaoNhan.ThoiGianGiaoDen);
            mstNgayHoanThanh.Value = GiaoNhan.TinhTrang > 1
                                         ? GiaoNhan.NgayHoanThanh
                                         : CommonProvider.Instance.GetSysDate();//da xong thi lay ngay hoan thanh, nguoc lai lay ngay he thong
            txtGhiChuPNGN.Text = GiaoNhan.GhiChu;
        }

        private void LoadPhieuGiaoNhanDetails()
        {
            GiaoNhan.ListChiTietGiaoNhan = GiaoNhanDataProvider.Instance.GetListChungTuGNhanChiTietGetById(GiaoNhan.IdGiaoNhan);
            gPhanCongGiaoNhan.DataSource = new BindingList<ChungTuGiaoNhanChiTietInfor>(GiaoNhan.ListChiTietGiaoNhan);
            UpdateNhanVien();
        }  
 
        private void LoadDonHangGiaoNhanInfor()
        {
            ChungTuBanHangInfor dhgn = GiaoNhanDataProvider.Instance.GetDonHangGiaoNhanBySoPCGN(GiaoNhan.SoPhieuPhanCong);
            if (dhgn != null)
            {
                Business = new PhanCongGiaoNhanBusiness(dhgn);
                LoadDonHangGiaoNhanHeader();
                LoadDonHangGiaoNhanDetails();                
            }
        }

        private void LoadDonHangGiaoNhanHeader()
        {
            LoaiChungTu = Business.ChungTu.LoaiChungTu;
            TrangThaiDonHang = Business.ChungTu.TrangThai;
            Draft = Business.ChungTu.Draft;

            _IdTrungTam = Business.ChungTu.IdTrungTam;
            _IdTrungTamHachToan = Business.ChungTu.IdTrungTamHachToan;

            bteKhoXuat.Tag = DMKhoDataProvider.GetKhoByIdInfo(Business.ChungTu.IdKho);
            bteKhoXuat.Text = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).TenKho : "";
            cboNhanVien.SelectedValue = Business.ChungTu.IdNhanVien;

            txtSoOrderKH.Text = Business.ChungTu.SoChungTu;
            mstNgayLapPhieu.Value = Business.ChungTu.NgayLap;
            txtGhiChu.Text = Business.ChungTu.GhiChu;
        }

        private void LoadDonHangGiaoNhanDetails()
        {
            //Load danh sach hang ban
            gHangGiaoVan.DataSource = new BindingList<ChungTuBanHangChiTietInfor>(Business.ListChiTietChungTu);
        }
        #endregion

        private void ShowInfors()
        {
            this.Text = CommonFuns.Instance.GetOrderInfor(Business.ChungTu, Updating, LoaiGiaoDichBanHang.PHANCONG_GIAONHAN);
            tsslTrangThai.Text = Common.GetOrderStatus(TrangThaiDonHang, Draft);
            tslInfor.Text = Common.GetEnumInfor((TransactionType) LoaiChungTu);
        }

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            try
            {
                LoadKhoXuat();
                if (LstPhieuPCGN.Count == 0) return;
                GiaoNhan = GiaoNhanDataProvider.Instance.GetChungTuGiaoNhanGetByCT(LstPhieuPCGN[0].IdChungTu);
                if (GiaoNhan != null)//sua => tim danh sach cac chung tu co cung phan cong giao nhan
                {
                    List<ChungTuBanHangInfor> liChungTu =
                        GiaoNhanDataProvider.Instance.GetAllChungTuByIdGiaoNhan(GiaoNhan.IdGiaoNhan);
                    LstPhieuPCGN = new List<ChungTuBanHangInfor>(liChungTu);
                    LoadChungTuInstance();
                    if (GiaoNhan.Draft == 1)
                    {
                        tsbEdit_Click(sender, e);
                    }
                    else
                    {
                        IsAdded = false;
                        Updating = false;
                        setEDItems();
                        setEDFunctions();

                        IsGNhan = true;
                        Common.SetEDControl(true,true,tsbSuaGN);
                        Common.SetEDControl(true, false, tsbXacNhanGN);
                        btnGhiChu.Visible = true;
                        //btnGhiChu.Enabled = true;
                        //btnPhanCongGN.Enabled = true;
                        //btnXoaPCGN.Enabled = true;
                        //btnXoaPCGN.Visible = false;
                        //btnPhanCongGN.Text = "Ghi chú giao nhận";
                    }
                }
                else
                {
                    ThemMoiGiaoNhan();

                    Updating = true;
                    setEDItems();
                    setEDFunctions();
                    ShowInfors();
                    Common.SetEDControl(false, false, tsbSuaGN, tsbXacNhanGN);
                }

                LoadAllChiTietHangBan();
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
            txtMaSanPham.Focus();           
        }

        private void ThemMoiGiaoNhan()
        {
            Draft = -1;
            IsAdded = true;
            ResetChungTuInfor();
            txtSoPhieuPCGN.Prefix = Declare.Prefix.PhieuPhanCongGiaoNhan;
            txtSoPhieuPCGN.ReSet();//.Text = CommonProvider.Instance.GetSoPhieu(Declare.Prefix.PhieuPhanCongGiaoNhan);

            GiaoNhan = new ChungTuGiaoNhanInfor();
            GiaoNhan.ListChiTietGiaoNhan = new List<ChungTuGiaoNhanChiTietInfor>();
            gPhanCongGiaoNhan.DataSource = new BindingList<ChungTuGiaoNhanChiTietInfor>(GiaoNhan.ListChiTietGiaoNhan);

            txtSoOrderKH.Prefix = Declare.Prefix.DonHangGiaoNhan;
            txtSoOrderKH.ReSet();//.Text = CommonProvider.Instance.GetSoPhieu(Declare.Prefix.DonHangGiaoNhan);
            _IdTrungTamHachToan = nguoiDung.IdTrungTamHachToan == 0 ? Declare.IdTrungTamHachToan : nguoiDung.IdTrungTamHachToan;

            Business.ListChiTietChungTu = new List<ChungTuBanHangChiTietInfor>();
            gHangGiaoVan.DataSource = new BindingList<ChungTuBanHangChiTietInfor>(Business.ListChiTietChungTu);
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

        private void InputDataFromCode(string code)
        {
            try
            {
                int IdKhoSelected = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : 0;
                DMTrungTamInfor ttamInfor = DMTrungTamDataProvider.GetTrungTamByIdKho(IdKhoSelected);
                int IdTTamSelected = ttamInfor != null ? ttamInfor.IdTrungTam : 0;

                if (_IdTrungTam == 0 || bteKhoXuat.Tag == null || _IdLoaiKhachHang == 0)
                {
                    MessageBox.Show("Phải chọn kho và khách hàng");
                    return;
                }

                BangGiaBanChiTietInfor spb = null;
                if (!code.Equals(""))
                {
                    spb = BangGiaDataProvider.Instance.GetGiaBan(IdTTamSelected, IdKhoSelected, code);
                }
                if (spb == null)
                {
                    frmLookUp_HangHoa frm = new frmLookUp_HangHoa(false,
                                                                  (Common.Int2Bool(nguoiDung.SupperUser)
                                                                       ? -1
                                                                       : nguoiDung.IdNhomNguoiDung), 1, -1,
                                                                  IdKhoSelected);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        spb = BangGiaDataProvider.Instance.GetGiaBan(IdTTamSelected, IdKhoSelected, frm.SelectedItem.MaSanPham);
                    }
                    else
                    {
                        return;
                    }
                }
                if (spb == null)
                {
                    MessageBox.Show("Giá chưa thiết lập!");
                    return;
                }
                else if (spb.TonKho == 0)
                {
                    MessageBox.Show("Hàng đã hết tồn kho!");
                    return;
                }
                ChungTuBanHangChiTietInfor ctu =
                    Business.ListChiTietChungTu.Find(delegate(ChungTuBanHangChiTietInfor match)
                    { return match.MaSanPham == spb.MaSanPham; });
                if (ctu != null)
                {
                    if (spb.TonKho < ctu.SoLuong + 1)
                    {
                        MessageBox.Show("Không đủ hàng để xuất!");
                        return;
                    }
                    ctu.SoLuong += 1;
                }
                else
                {
                    //add san pham ban
                    ChungTuBanHangChiTietInfor ct = BanHangDataProvider.Instance.ConvertBG2SanPhamBan(spb);
                    ct.IdChungTu = Business.ChungTu.IdChungTu;
                    ((BindingList<ChungTuBanHangChiTietInfor>)gHangGiaoVan.DataSource).Add(ct);
                }
                ((BindingList<ChungTuBanHangChiTietInfor>)gHangGiaoVan.DataSource).ResetBindings();
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

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            InputDataFromCode(txtMaSanPham.Text.Trim());
        }

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
                    ShowInfors();
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

        private bool ValidEditChungTu()
        {
            if (GiaoNhan.IdGiaoNhan == 0 || GiaoNhan.IdGiaoNhan > 0 && (Draft != 0 || nguoiDung.SupperUser == 1))
            {
                return true;
            }
            return false;
        }
        
        private void setEDItems()
        {
            //phan cong giao nhan
            txtSoPhieuPCGN.Enabled = Updating;// && CommonFuns.IsEditSoChungTu();
            mstNgayPhanCong.Enabled = Updating;
            mstNgayHoanThanh.Enabled = Updating;
            mstThoiGianGiaoTu.Enabled = Updating;
            mstThoiGianGiaoDen.Enabled = Updating;
            txtGhiChuPNGN.ReadOnly = !Updating;
            btnPhanCongGN.Enabled = Updating;
            btnXoaPCGN.Enabled = Updating;

            //don hang pcgn
            txtSoOrderKH.Enabled = Updating;
            mstNgayLapPhieu.Enabled = Updating;
            bteKhoXuat.Enabled = Updating;
            txtGhiChu.Enabled = Updating;
            cboTinhTrangGN.Enabled = Updating;

            txtMaSanPham.Enabled = Updating;
            btnThemHang.Enabled = Updating;
            btnXoaMaHang.Enabled = Updating;
        }

        private void setEDFunctions()
        {
            tsbEdit.Enabled = !Updating && (Common.Int2Bool(Draft)  || nguoiDung.SupperUser == 1 || ChoPhepSua);
            tsbUpdate.Enabled = Updating;//cap nhat
            tsbDelete.Enabled = !Updating && (Common.Int2Bool(Draft) || nguoiDung.SupperUser == 1 || ChoPhepSua);//xoa, huy don hang online, dat truoc
            tsbConfirm.Enabled = Updating;//xac nhan
            //tsbPrint.Enabled = !Updating && GiaoNhan.IdGiaoNhan > 0;
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

        private bool UpdateChungTu()
        {
            int oldId = Business.ChungTu.IdChungTu;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (ValidChungTuInfor())
                {
                    ConnectionUtil.Instance.BeginTransaction();
                    SaveChungTuInstance();
                    if (gvHangGiaoNhan.RowCount > 0)
                    {
                        Business.SaveChungTu();
                    }
                    else
                    {
                        if (Business.ChungTu.IdChungTu > 0)
                            Business.DeleteChungTu();
                    }
                    
                    ConnectionUtil.Instance.CommitTransaction();
                    if (IsAdded)
                    {
                        MessageBox.Show("Lập phiếu phân công giao nhận thành công!");
                    }                        
                    else
                    {
                        MessageBox.Show("Cập nhật phiếu phân công giao nhận thành công!");
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
            Common.SetFormStatus(this.Name, true);
            Cursor.Current = Cursors.Default;
            return false;
        }

        private void SaveChungTuInstance()
        {
            //save phan cong giao nhan
            UpdatePhieuGiaoNhanInfor();
            //save don hang giao nhan
            UpdateDonHangGiaoNhanInfor();
        }
        private void UpdatePhieuGiaoNhanInfor()
        {
            UpdatePhieuGiaoNhanHeader();
            UpdatePhieuGiaoNhanDetails();
        }
        private void UpdatePhieuGiaoNhanHeader()
        {
            GiaoNhan.TinhTrang = cboTinhTrangGN.SelectedIndex;
            GiaoNhan.Draft = Draft;
            GiaoNhan.SoPhieuPhanCong = txtSoPhieuPCGN.Text.Trim();
            GiaoNhan.NgayPhanCong = mstNgayPhanCong.Value;
            GiaoNhan.ThoiGianGiaoTu = mstThoiGianGiaoTu.Value;
            GiaoNhan.ThoiGianGiaoDen = mstThoiGianGiaoDen.Value;
            GiaoNhan.NgayHoanThanh = mstNgayHoanThanh.Value;
            GiaoNhan.GhiChu = txtGhiChuPNGN.Text.Trim();
            GiaoNhan.ListIdChungTu = ListIdChungTu;
            if (GiaoNhan.IdGiaoNhan == 0)
            {
                GiaoNhan.NguoiTao = nguoiDung.TenDangNhap;

                GiaoNhan.NguoiSua = nguoiDung.TenDangNhap;
                GiaoNhan.IdGiaoNhan = GiaoNhanDataProvider.Instance.InsertChungTuGiaoNhan(GiaoNhan);
            }                
            else
            {
                GiaoNhan.NguoiSua = nguoiDung.TenDangNhap;
                GiaoNhanDataProvider.Instance.UpdateChungTuGiaoNhan(GiaoNhan);
            }

            GiaoNhanDataProvider.Instance.XacNhanTThaiGNhanCTuGoc(GiaoNhan.IdGiaoNhan, GiaoNhan.ListIdChungTu,
                                                                   nguoiDung.TenDangNhap, Declare.TenMay);
                
        }
        private void UpdatePhieuGiaoNhanDetails()
        {
            //xoa chi tiet giao nhan cu
            GiaoNhanDataProvider.Instance.DeleteChungTuGiaoNhanChiTiet(GiaoNhan.IdGiaoNhan);
            if (gvPhanCongGiaoNhan.RowCount > 0)
            {
                //insert giao nhan moi
                foreach (ChungTuGiaoNhanChiTietInfor gnct in (BindingList<ChungTuGiaoNhanChiTietInfor>)gPhanCongGiaoNhan.DataSource)
                {
                    gnct.IdGiaoNhan = GiaoNhan.IdGiaoNhan;
                    GiaoNhanDataProvider.Instance.InsertChungTuGiaoNhanChiTiet(gnct);
                }                
            }
        }
        private void UpdateDonHangGiaoNhanInfor()
        {
            if (gvHangGiaoNhan.RowCount > 0)
            {
                UpdateDonHangGiaoNhanHeader();
                UpdateDonHangGiaoNhanDetails();                
            }
        }
        private void UpdateDonHangGiaoNhanHeader()
        {
            Business.ChungTu.LoaiChungTu = LoaiChungTu;
            Business.ChungTu.TrangThai = TrangThaiDonHang;
            Business.ChungTu.Draft = Draft;
            Business.ChungTu.SoChungTu = txtSoOrderKH.Text;
            Business.ChungTu.IdTrungTam = _IdTrungTam;
            Business.ChungTu.IdTrungTamHachToan = _IdTrungTamHachToan;
            Business.ChungTu.IdKho = ((DMKhoInfo) bteKhoXuat.Tag).IdKho;
            Business.ChungTu.NgayLap = mstNgayLapPhieu.Value;
            Business.ChungTu.GhiChu = txtGhiChu.Text;
            Business.ChungTu.SoChungTuGoc = GiaoNhan.SoPhieuPhanCong;
            Business.ChungTu.IdNhanVien = Common.IntValue(cboNhanVien.SelectedValue);

            if (Business.ChungTu.IdChungTu == 0)
            {
                Business.ChungTu.NguoiTao = nguoiDung.TenDangNhap;
                Business.ChungTu.TenMayTao = Declare.TenMay;
                Business.ChungTu.NguoiSua = nguoiDung.TenDangNhap;
                Business.ChungTu.TenMaySua = Declare.TenMay;
            }
            else
            {
                Business.ChungTu.NguoiSua = nguoiDung.TenDangNhap;
                Business.ChungTu.TenMaySua = Declare.TenMay;
            }
        }
        private void UpdateDonHangGiaoNhanDetails()
        {

        }

        private bool ValidDeleteChungTu()
        {
            if (GiaoNhan.IdGiaoNhan == 0 || GiaoNhan.IdGiaoNhan > 0 && (Draft != 0 || nguoiDung.SupperUser == 1) &&
                (Business.ChungTu.IdChungTu == 0 || Business.ChungTu.IdChungTu > 0 && Business.ChungTu.TrangThai != (int)OrderStatus.XAC_NHAN_DON_HANG_GIAO_NHAN))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Trạng thái đơn hàng đã thay đỏi. Không thể xóa được.\nChuyển sang các trạng thái khác để xóa");
                return false;
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidDeleteChungTu())
                {
                    MessageBox.Show("Đơn hàng này đã được xác nhận, không thể xóa được!");
                }
                else
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

        private void DeleteChungTu()
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa đơn hàng này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ConnectionUtil.Instance.BeginTransaction();
                    //xoa giao nhan
                    GiaoNhanDataProvider.Instance.DeleteAllChungTuGiaoNhan(GiaoNhan.IdGiaoNhan);
                    //xoa don hang
                    Business.DeleteChungTu();
                    //BanHangDataProvider.Instance.DeleteChungTu(Business.ChungTu.IdChungTu);
                    ConnectionUtil.Instance.CommitTransaction();
                    MessageBox.Show("Xóa phiếu giao nhận thành công!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                ConnectionUtil.Instance.RollbackTransaction();
                throw;
#if DEBUG
                MessageBox.Show("Lỗi thực hiện Xóa đơn hàng\n" + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi thực hiện Xóa đơn hàng", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }
        private void tsbPrint_Click(object sender, EventArgs e)
        {
            if (gvHangCanXuat.RowCount == 0)
            {
                MessageBox.Show("Không có hàng bán!");
                return;
            }
            //if (gvPhanCongGiaoNhan.RowCount == 0)
            //{
            //    MessageBox.Show("Chưa phân công giao vận!");
            //    return;
            //}
            InPhieuGiaoNhan();
        }

        private void InPhieuGiaoNhan()
        {
            if (LstPhieuPCGN.Count == 0) return;
            HoaDonPCGNInfo hd = new HoaDonPCGNInfo();
            double tongtien = 0, thuctra = 0, tienno = 0;
            string sochungtu = "";
            string sohoadon = "";
            string ghichu = "";
            foreach (ChungTuBanHangInfor ct in LstPhieuPCGN)
            {
                sochungtu = sochungtu + ct.SoChungTu + ",";
                sohoadon = sohoadon + ct.SoSeri + ",";
                ghichu = ghichu + ct.GhiChu + ",";
                tongtien += ct.TongTienThanhToan;
                thuctra += ct.TienThanhToanThuc;
                tienno += ct.TienConNo;
            }
            if (LstPhieuPCGN.Count > 0)
            {
                DMNhanVienInfo nv = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(LstPhieuPCGN[0].IdNhanVien);
                hd.ThuongVien = (nv != null ? nv.HoTen : "");
            }

            hd.SoChungTu = sochungtu;
            hd.SoHoaDon = sohoadon;
            hd.NgayLap = LstPhieuPCGN[0].NgayLap;
            hd.KhachHang = LstPhieuPCGN[0].TenDoiTuong;
            hd.CongTy = LstPhieuPCGN[0].CongTy;
            hd.HoTen = LstPhieuPCGN[0].HoTen;
            hd.DiaChiHoaDon = LstPhieuPCGN[0].DiaChiHoaDon;
            hd.DiaChiGiaoHang = LstPhieuPCGN[0].DiaChiGiaoHang;
            hd.DienThoai = LstPhieuPCGN[0].DienThoai;
            DMKhoInfo dmKho = DMKhoDataProvider.GetKhoByIdInfo(LstPhieuPCGN[0].IdKho);
            if (dmKho != null)
            {
                hd.KhoXuat = dmKho.MaKho;
            }
            
            //hd.HinhThucThanhToan = LstPhieuPCGN[0];
            hd.CachGiaoHang = LstPhieuPCGN[0].GiaoNhan != 0 ? "Giao tại nhà khách" : "Giao tại công ty";
            hd.TongTienHang = tongtien;
            hd.TienThanhToanThuc = thuctra;
            hd.TienConNo = tienno;

            //if (ListIdChungTu.Length > 0)
            //    ListIdChungTu = ListIdChungTu.Substring(0, ListIdChungTu.Length - 1);

            hd.NhanVienKinhDoanh = "";
            foreach (ChungTuGiaoNhanChiTietInfor ct in (BindingList<ChungTuGiaoNhanChiTietInfor>)gPhanCongGiaoNhan.DataSource)
            {
                hd.NhanVienKinhDoanh += String.Format("{0}(Phương tiện: {1})",ct.HoTen, ct.TenPhuongTien) +
                                        (String.IsNullOrEmpty(ct.BienSoXe) ? "" : "/" + ct.BienSoXe) + ";";
            }
            hd.GhiChu = ghichu;
            CommonFuns.Instance.InPhieuGiaoNhan(hd, liHangGiaoNhan);
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
                if (GiaoNhan.IdGiaoNhan > 0 && GiaoNhan.Draft == 1 && MessageBox.Show("Đơn hàng mới lưu nháp, chưa được xác nhận!!\n\nCác bộ phận khác sẽ không nhìn thấy được!!!\n\nBạn có đồng ý thoát chức năng này không? (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                } 

                this.Close();
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
            catch(ManagedException ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show(ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif                
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

        private void btnXoaMaVach_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng hàng này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gvHangGiaoNhan.DeleteSelectedRows();
            }
        }

        private void gvHangDaXuat_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
        }

        private void btnPhanCongGN_Click(object sender, EventArgs e)
        {
            //if (!IsGNhan)
            //{
                frmBH_ChonPhanCongGiaoNhan frm = new frmBH_ChonPhanCongGiaoNhan();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (GiaoNhan.ListChiTietGiaoNhan.Exists(delegate(ChungTuGiaoNhanChiTietInfor match)
                    {
                        return match.IdNhanVien == frm.ChiTietGiaoNhan.IdNhanVien;
                    }))
                    {
                        MessageBox.Show("Nhân viên này đã được phân công!");
                        return;
                    }

                    frm.ChiTietGiaoNhan.IdGiaoNhan = GiaoNhan.IdGiaoNhan;
                    ((BindingList<ChungTuGiaoNhanChiTietInfor>)gPhanCongGiaoNhan.DataSource).Add(frm.ChiTietGiaoNhan);
                    UpdateNhanVien();
                }                
            //}
            //else//trang thai phan cong giao nhan
            //{
            //    frmBH_LapDonHangGiaoNhan_AddNote frm = new frmBH_LapDonHangGiaoNhan_AddNote();
            //    if (frm.ShowDialog() == DialogResult.OK)
            //    {
            //        txtGhiChuPNGN.Text += frm.Comment;
            //    }                
            //}
        }

        private void UpdateNhanVien()
        {
            cboNhanVien.DataSource = null;
            List<DMNhanVienInfo> liNhanVien = new List<DMNhanVienInfo>();
            foreach (ChungTuGiaoNhanChiTietInfor ct in (BindingList<ChungTuGiaoNhanChiTietInfor>)gPhanCongGiaoNhan.DataSource)
            {
                DMNhanVienInfo nv = new DMNhanVienInfo();
                nv.IdNhanVien = ct.IdNhanVien;
                nv.MaNhanVien = ct.MaNhanVien;
                nv.HoTen = ct.HoTen;
                liNhanVien.Add(nv);
            }
            cboNhanVien.DataSource = liNhanVien;
            cboNhanVien.DisplayMember = "HoTen";
            cboNhanVien.ValueMember = "IdNhanVien";
            cboNhanVien.SelectedIndex = -1;
        }

        private void ResetData()
        {
            Business.ListChiTietChungTu = new List<ChungTuBanHangChiTietInfor>();
            gHangGiaoVan.DataSource = new BindingList<ChungTuBanHangChiTietInfor>(Business.ListChiTietChungTu);
        }

        private void bteKhoXuat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (UtilFunctions.bteKhoXuat_ButtonClick(sender, e, bteKhoXuat, _IdTrungTam, nguoiDung.IdNhanVien))
            {
                if (MessageBox.Show("Dữ liệu đang nhập, nếu chuyển thông tin thì dữ liệu đã nhập sẽ bị xóa\nBạn có đồng ý đổi thông tin hay không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ResetData();
                }
                else
                {
                    LoadKhoXuat();
                }
            }
        }

        private void bteKhoXuat_KeyDown(object sender, KeyEventArgs e)
        {
            if (UtilFunctions.bteKhoXuat_KeyDown(sender, e, bteKhoXuat, _IdTrungTam, nguoiDung.IdNhanVien))
            {
                if (MessageBox.Show("Dữ liệu đang nhập, nếu chuyển thông tin thì dữ liệu đã nhập sẽ bị xóa\nBạn có đồng ý đổi thông tin hay không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ResetData();
                }
                else
                {
                    LoadKhoXuat();
                }
            }
        }

        private void bteKhoXuat_TextChanged(object sender, EventArgs e)
        {
            if (UtilFunctions.bteItem_TextChanged(sender, e, bteKhoXuat))
            {
                if (MessageBox.Show("Dữ liệu đang nhập, nếu chuyển thông tin thì dữ liệu đã nhập sẽ bị xóa\nBạn có đồng ý đổi thông tin hay không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ResetData();
                }
                else
                {
                    LoadKhoXuat();
                }
            }
        }

        private void btnXoaPCGN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng phân công này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gvPhanCongGiaoNhan.DeleteSelectedRows();
            }
            UpdateNhanVien();
        }

        private void setItemGNStatus()
        {
            mstNgayHoanThanh.Enabled = UpdGN;
            cboTinhTrangGN.Enabled = UpdGN;
            tsbSuaGN.Enabled = !UpdGN;
            tsbXacNhanGN.Enabled = UpdGN;

            btnGhiChu.Enabled = UpdGN;
            btnPhanCongGN.Enabled = UpdGN;
            btnXoaPCGN.Enabled = UpdGN;
        }
        private void tsbSuaGN_Click(object sender, EventArgs e)
        {
            UpdGN = true;
            setItemGNStatus();
        }

        private void tsbXacNhanGN_Click(object sender, EventArgs e)
        {
            try
            {
                if (GiaoNhan != null)
                {
                    ConnectionUtil.Instance.BeginTransaction();

                    GiaoNhan.TinhTrang = cboTinhTrangGN.SelectedIndex;
                    GiaoNhan.NgayHoanThanh = mstNgayHoanThanh.Value;
                    GiaoNhan.GhiChu = txtGhiChuPNGN.Text;
                    GiaoNhanDataProvider.Instance.UpdateTinhTrangGiaoNhan(GiaoNhan);

                    UpdatePhieuGiaoNhanDetails();

                    ConnectionUtil.Instance.CommitTransaction();

                    UpdGN = false;
                    setItemGNStatus();

                    MessageBox.Show("Cập nhật tình trạng giao nhận thành công!");
                }
            }
            catch (Exception ex)
            {
                ConnectionUtil.Instance.RollbackTransaction();
#if DEBUG
                MessageBox.Show("Lỗi thao tác\n" + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi thao tác", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }   
        }

        private void btnGhiChu_Click(object sender, EventArgs e)
        {
            frmBH_LapDonHangGiaoNhan_AddNote frm = new frmBH_LapDonHangGiaoNhan_AddNote();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtGhiChuPNGN.Text += (String.IsNullOrEmpty(txtGhiChuPNGN.Text) ? "" : "\r\n") + frm.Comment;
            }  
        }

        private void mstThoiGianGiaoDen_ValueChanged(object sender, EventArgs e)
        {
            mstNgayHoanThanh.Value = mstThoiGianGiaoDen.Value;
        }
    }
}