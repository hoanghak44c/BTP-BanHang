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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
    public partial class frmBH_LapPhanDonGiaoNhan : DevExpress.XtraEditors.XtraForm
    {
        #region "Khai báo biến"
        private int Draft = -1;//-1:chua ton tai; 1-save, 0-confirm
        private bool IsAdded = false;
        private bool Updating = false;//false: chua sua, tao moi; 1:dang sua, tao moi
        private bool IsGNhan = false;
        private bool UpdGN = false;
        private bool ChoPhepSua = false;
        
        private int _IdKho = Declare.IdKho;
                
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor) Declare.USER_INFOR
                                               : new NguoiDungInfor();

        private int TrangThaiDonHang = (int)OrderStatus.PHAN_CONG_GIAO_NHAN;
        private int TrangThaiPhanDon = (int) TrangThaiPhanDonGiaoNhan.CHUA_PHAN_DON;
        private int LoaiChungTu = (int) TransactionType.DON_HANG_GIAO_NHAN;
        private string ListIdChungTu = "";

        private List<ChungTuBanHangInfor> LstPhieuPCGN = new List<ChungTuBanHangInfor>();
        private List<HangBanGiaoNhanChiTietInfor> liHangGiaoNhan = new List<HangBanGiaoNhanChiTietInfor>();
        private ChungTuGiaoNhanInfor GiaoNhan;
        private bool IsInHoaDon = false;
        private bool DuyetPhanDon = false;
        #endregion

        #region "Các phương thức khởi tạo"
        public frmBH_LapPhanDonGiaoNhan()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            GiaoNhan = new ChungTuGiaoNhanInfor();
            IsGNhan = false;
        }

        public frmBH_LapPhanDonGiaoNhan(List<ChungTuBanHangInfor> lstPhieuPCGN)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.LstPhieuPCGN = lstPhieuPCGN;
            GiaoNhan = new ChungTuGiaoNhanInfor();
            this.IsGNhan = false;
        }
        public frmBH_LapPhanDonGiaoNhan(List<ChungTuBanHangInfor> lstPhieuPCGN, bool duyetPhanDon)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.LstPhieuPCGN = lstPhieuPCGN;
            GiaoNhan = new ChungTuGiaoNhanInfor();
            this.IsGNhan = false;
            this.DuyetPhanDon = duyetPhanDon;
            if (DuyetPhanDon)
            {
                this.Text = "Xác nhận phân đơn hàng giao nhân";
                tsbDelete.Text = "Từ chối";
                Common.SetEDControl(false, false, tsbEdit);
            }                
            else
            {
                this.Text = "Phân đơn hàng giao nhận";
                Common.SetEDControl(false, false, tsbEdit);
            }                
        }
        public frmBH_LapPhanDonGiaoNhan(List<ChungTuBanHangInfor> lstPhieuPCGN, bool duyetPhanDon, bool ChoPhepSua)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.LstPhieuPCGN = lstPhieuPCGN;
            GiaoNhan = new ChungTuGiaoNhanInfor();
            this.DuyetPhanDon = duyetPhanDon;
            this.ChoPhepSua = ChoPhepSua;
            if (DuyetPhanDon)
            {
                this.Text = "Xác nhận phân đơn hàng giao nhân";
                tsbDelete.Text = "Từ chối";
                Common.SetEDControl(false, false, tsbEdit);
            }
            else
                this.Text = "Phân đơn hàng giao nhận";
        }
        public void HideMenu(bool isInHoaDon)
        {
            bool enable = ValidEditChungTu();
            //toolStrip1.Enabled = nguoiDung.SupperUser != 1 ? false : true;

            tsbEdit.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbDelete.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbConfirm.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbSearch.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbPrint.Enabled = true;

            //btnTimOrderKH.Enabled = nguoiDung.SupperUser != 1 ? false : true;
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
            //reset phan cong giao nhan
            txtSoPhieuPCGN.ResetText();
            cboTinhTrangGN.SelectedIndex = 0;
            mstNgayPhanCong.Value = CommonProvider.Instance.GetSysDate();
            mstThoiGianGiaoTu.Value = mstNgayPhanCong.Value;
            mstThoiGianGiaoDen.Value = mstNgayPhanCong.Value;
            mstNgayHoanThanh.Value = mstNgayPhanCong.Value;
            txtGhiChuPNGN.ResetText();
            gPhanCongGiaoNhan.DataSource = null;
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
            foreach (ChungTuBanHangInfor ct in LstPhieuPCGN)
            {
                if (ct.NgayLap > mstNgayPhanCong.Value)
                {
                    MessageBox.Show("Ngày phân công không thể trước ngày lập phiếu được." + "\nHãy nhập lại ngày phân công", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.mstNgayPhanCong.Focus();
                    return false;                    
                }
                //if (ct.NgayLap > mstNgayHoanThanh.Value)
                //{
                //    MessageBox.Show("Ngày hoàn thành không thể trước ngày lập phiếu được." + "\nHãy nhập lại ngày hoàn thành", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    this.mstNgayHoanThanh.Focus();
                //    return false;
                //}
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
            cboTinhTrangGN.SelectedIndex = -1;// GiaoNhan.TinhTrang;
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
        }   
        #endregion

        private void ShowInfors()
        {
            this.Text = "";// CommonFuns.Instance.GetOrderInfor(Business.ChungTu, Updating, LoaiGiaoDichBanHang.PHANCONG_GIAONHAN);
            tsslTrangThai.Text = Common.GetOrderStatus(TrangThaiDonHang, Draft);
            tslInfor.Text = Common.GetEnumInfor((TransactionType) LoaiChungTu);
        }

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            try
            {
                if (LstPhieuPCGN.Count == 0) return;
                GiaoNhan = GiaoNhanDataProvider.Instance.GetChungTuGiaoNhanGetByCT(LstPhieuPCGN[0].IdChungTu);
                if (GiaoNhan != null)//sua => tim danh sach cac chung tu co cung phan cong giao nhan
                {
                    List<ChungTuBanHangInfor> liChungTu =
                        GiaoNhanDataProvider.Instance.GetAllChungTuByIdGiaoNhan(GiaoNhan.IdGiaoNhan);
                    LstPhieuPCGN = new List<ChungTuBanHangInfor>(liChungTu);
                    LoadChungTuInstance();
                    //if (GiaoNhan.Draft == 1)
                    //{
                    //    tsbEdit_Click(sender, e);
                    //}
                    //else
                    //{
                    //    IsAdded = false;
                    TrangThaiPhanDon = LstPhieuPCGN[0].DaPhanDon;
                    Updating = TrangThaiPhanDon != (int)TrangThaiPhanDonGiaoNhan.XAC_NHAN_PHAN_DON;// false;
                    setEDItems();
                    setEDFunctions();

                    IsGNhan = true;
                    btnGhiChu.Visible = true;
                    //}
                }
                else
                {
                    ThemMoiGiaoNhan();

                    Updating = true;
                    setEDItems();
                    setEDFunctions();
                    ShowInfors();
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
        }

        private void ThemMoiGiaoNhan()
        {
            TrangThaiPhanDon = (int)TrangThaiPhanDonGiaoNhan.CHUA_PHAN_DON;
            Draft = -1;
            IsAdded = true;
            ResetChungTuInfor();
            txtSoPhieuPCGN.Prefix = Declare.Prefix.PhieuPhanCongGiaoNhan;
            txtSoPhieuPCGN.ReSet();//.Text = CommonProvider.Instance.GetSoPhieu(Declare.Prefix.PhieuPhanCongGiaoNhan);

            GiaoNhan = new ChungTuGiaoNhanInfor();
            GiaoNhan.ListChiTietGiaoNhan = new List<ChungTuGiaoNhanChiTietInfor>();
            gPhanCongGiaoNhan.DataSource = new BindingList<ChungTuGiaoNhanChiTietInfor>(GiaoNhan.ListChiTietGiaoNhan);
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
            mstNgayHoanThanh.Enabled = false;
            mstThoiGianGiaoTu.Enabled = Updating;
            mstThoiGianGiaoDen.Enabled = Updating;
            txtGhiChuPNGN.ReadOnly = !Updating;
            btnPhanCongGN.Enabled = Updating;
            btnXoaPCGN.Enabled = Updating;
            btnSuaPhanCongGN.Enabled = Updating;

            //don hang pcgn
            cboTinhTrangGN.Enabled = false;// Updating;
        }

        private void setEDFunctions()
        {
            tsbEdit.Enabled = !Updating && (Common.Int2Bool(Draft)  || nguoiDung.SupperUser == 1 || ChoPhepSua);
            tsbDelete.Enabled = Updating;// && (Common.Int2Bool(Draft) || nguoiDung.SupperUser == 1 || ChoPhepSua);//xoa, huy don hang online, dat truoc
            tsbConfirm.Enabled = Updating;//xac nhan
            tsbPrint.Enabled = !Updating && GiaoNhan.IdGiaoNhan > 0;
        }

        private bool UpdateChungTu()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (ValidChungTuInfor())
                {
                    ConnectionUtil.Instance.BeginTransaction();
                    SaveChungTuInstance();
                    
                    ConnectionUtil.Instance.CommitTransaction();
                    if (IsAdded)
                    {
                        MessageBox.Show("Lập phiếu phân đơn giao nhận thành công!");
                    }                        
                    else
                    {
                        MessageBox.Show("Cập nhật phiếu phân đơn giao nhận thành công!");
                    }
                        
                    return true;
                }                
            }
            catch (Exception)
            {
                ConnectionUtil.Instance.RollbackTransaction();
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
        }
        private void UpdatePhieuGiaoNhanInfor()
        {
            UpdatePhieuGiaoNhanHeader();
            UpdatePhieuGiaoNhanDetails();
        }
        private void UpdatePhieuGiaoNhanHeader()
        {
            GiaoNhan.TinhTrang = -1;// cboTinhTrangGN.SelectedIndex;
            GiaoNhan.Draft = Draft;
            GiaoNhan.SoPhieuPhanCong = txtSoPhieuPCGN.Text.Trim();
            GiaoNhan.NgayPhanCong = mstNgayPhanCong.Value;
            GiaoNhan.ThoiGianGiaoTu = mstThoiGianGiaoTu.Value;
            GiaoNhan.ThoiGianGiaoDen = mstThoiGianGiaoDen.Value;
            GiaoNhan.NgayXacNhan = mstNgayHoanThanh.Value;
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

            TrangThaiPhanDon = DuyetPhanDon ? 3 : 1;
            GiaoNhanDataProvider.Instance.XacNhanTThaiPhanDonGNhan(GiaoNhan.IdGiaoNhan, TrangThaiPhanDon, GiaoNhan.ListIdChungTu,
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

        private bool ValidDeleteChungTu()
        {
            if (TrangThaiPhanDon != (int)TrangThaiPhanDonGiaoNhan.XAC_NHAN_PHAN_DON)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidDeleteChungTu())
                {
                    MessageBox.Show("Trạng thái phân đơn đơn hàng đã thay đổi. Không thể xóa được.");
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
                if (MessageBox.Show("Bạn có chắc chắn muốn thực hiện thao tác này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (GiaoNhan.IdGiaoNhan > 0)
                    {
                        ConnectionUtil.Instance.BeginTransaction();
                        //xoa giao nhan
                        GiaoNhanDataProvider.Instance.DeleteAllChungTuGiaoNhan(GiaoNhan.IdGiaoNhan);
                        //BanHangDataProvider.Instance.DeleteChungTu(Business.ChungTu.IdChungTu);
                        TrangThaiPhanDon = DuyetPhanDon ? 2 : 0;
                        GiaoNhanDataProvider.Instance.XacNhanTThaiPhanDonGNhan(GiaoNhan.IdGiaoNhan, TrangThaiPhanDon,
                                                                               GiaoNhan.ListIdChungTu,
                                                                               nguoiDung.TenDangNhap, Declare.TenMay);
                        ConnectionUtil.Instance.CommitTransaction();
                    }
                    MessageBox.Show("Thực hiện giao dịch thành công!");
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
            if (TrangThaiPhanDon == 0)
            {
                MessageBox.Show("Không thể in đơn hàng chưa phân giao vận. Hãy phân đơn trước  khi in!");
                return;
            }
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
            //In phieu giao nha
            CommonFuns.Instance.InPhieuGiaoNhan(hd, liHangGiaoNhan, GiaoNhan.IdGiaoNhan);
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

        private void btnPhanCongGN_Click(object sender, EventArgs e)
        {
            //if (!IsGNhan)
            //{
                frmBH_ChonPhanCongGiaoNhan frm = new frmBH_ChonPhanCongGiaoNhan(true);
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

        private void btnXoaPCGN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng phân công này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gvPhanCongGiaoNhan.DeleteSelectedRows();
            }
            //UpdateNhanVien();
        }

        private void setItemGNStatus()
        {
            mstNgayHoanThanh.Enabled = UpdGN;
            cboTinhTrangGN.Enabled = UpdGN;

            btnGhiChu.Enabled = UpdGN;
            btnPhanCongGN.Enabled = UpdGN;
            btnXoaPCGN.Enabled = UpdGN;
        }

        private void btnGhiChu_Click(object sender, EventArgs e)
        {
            frmBH_LapDonHangGiaoNhan_AddNote frm = new frmBH_LapDonHangGiaoNhan_AddNote();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtGhiChuPNGN.Text += (String.IsNullOrEmpty(txtGhiChuPNGN.Text) ? "" : "\r\n") + frm.Comment;
            }  
        }

        private void EditOrder(int rowHandle)
        {
            if (rowHandle < 0) return;
            ChungTuGiaoNhanChiTietInfor ct = (ChungTuGiaoNhanChiTietInfor)gvPhanCongGiaoNhan.GetRow(rowHandle);
            if (ct != null)
            {
                frmBH_ChonPhanCongGiaoNhan frm = new frmBH_ChonPhanCongGiaoNhan(ct, true);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ((BindingList<ChungTuGiaoNhanChiTietInfor>)gPhanCongGiaoNhan.DataSource).ResetBindings();
                }
            }
        }

        private void btnSuaPhanCongGN_Click(object sender, EventArgs e)
        {
            try
            {
                EditOrder(gvPhanCongGiaoNhan.FocusedRowHandle);
            }
            catch (ManagedException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }

        }

        private void gvPhanCongGiaoNhan_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Point pt = gPhanCongGiaoNhan.PointToClient(MousePosition);
                GridHitInfo hitInfo = gvPhanCongGiaoNhan.CalcHitInfo(pt);
                if (hitInfo.InRow)
                    EditOrder(hitInfo.RowHandle);
            }
            catch (ManagedException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
        }

        private void mstThoiGianGiaoDen_ValueChanged(object sender, EventArgs e)
        {
            mstNgayHoanThanh.Value = mstThoiGianGiaoDen.Value;
        }
    }
}