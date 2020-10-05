using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using QLBanHang.Class;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.BanHang.Bussiness;
using QLBH.Core.Exceptions;
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBH_TimChungTu : FrmBcBase1<ChungTuBanHangInfor>
        //DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"

        private LoaiGiaoDichBanHang LoaiGiaoDich;
        public TimKiemChungTuFilterInfor filter;
        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        int[] arLoaiDongHang = {(int)TransactionType.DON_HANG_ONLINE,
                                (int)TransactionType.DON_HANG_DAT_TRUOC,
                                (int)TransactionType.DON_HANG_TAI_SHOP};
        public ChungTuBanHangInfor ChungTu = null;
        private string err;
        private bool TimKiem = false;

#endregion

#region "Các phương thức khởi tạo"
        public frmBH_TimChungTu()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            DataProvider = TimKiemDonHangDataProvider.Instance;
            filter = new TimKiemChungTuFilterInfor();
            gListChungTu.DataSource = DataSource;
        }
        public frmBH_TimChungTu(LoaiGiaoDichBanHang loaiGiaoDich)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            LoaiGiaoDich = loaiGiaoDich;
            DataProvider = TimKiemDonHangDataProvider.Instance;
            filter = new TimKiemChungTuFilterInfor();
            gListChungTu.DataSource = DataSource;
        }
        public frmBH_TimChungTu(bool timKiem)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            TimKiem = timKiem;
            DataProvider = TimKiemDonHangDataProvider.Instance;
            filter = new TimKiemChungTuFilterInfor();
            gListChungTu.DataSource = DataSource;
        }
#endregion

#region "Các sự kiên"
        private void frmBH_TimChungTu_Load(object sender, EventArgs e)
        {
            try
            {
                btnXoaDL.Visible = btnXoaDL.Enabled = false;
                //btnXoaDL.Visible = nguoiDung.SupperUser == 1 ? true : false;
                //btnXoaDL.Enabled = nguoiDung.SupperUser == 1 ? true : false;

                LoadAllTrangThai();
                cboLoaiMaHang.SelectedIndex = 6;
                CommonFuns.Instance.LoadTrungTam(bteTrungTam, nguoiDung);
                dteStart.DateTime = dteEnd.DateTime = Declare.SYSDATE;

                if ((int)LoaiGiaoDich != 0)
                    btnTim_Click(sender, e);
                if (TimKiem)
                {
                    this.Text = "Chọn đơn hàng sao chép";
                    cmdExport.Text = "Đồ&ng ý (F6)";
                    btnDong.Text = "H&ủy (F12)";
                    //btnXoaDL.Visible = false;
                    //btnXoaDL.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadAllTrangThai()
        {
            List<TrangThaiBH> liDraft = Common.GetListTinhTrangDonHang();
            List<TrangThaiBH> liLoaiDH = Common.GetListBCLoaiDonHang();
            List<TrangThaiBH> liTrangThaiDH = Common.GetListBCTrangThaiDonHang();
            //load trang thai cho grid
            repDraft.DataSource = liDraft;
            repLoaiDonHang.DataSource = liLoaiDH;
            repTrangThaiDH.DataSource = liTrangThaiDH;

            //load trang thai draft
            List<TrangThaiBH> liDraft1 = new List<TrangThaiBH>();
            liDraft1.Add(new TrangThaiBH { Id = -1, Name = "Tất cả" });
            liDraft1.AddRange(liDraft);
            lueDraft.Properties.DataSource = liDraft1;
            lueDraft.EditValue = -1;

            List<TrangThaiBH> liLoaiDH1 = new List<TrangThaiBH>();
            liLoaiDH1.Add(new TrangThaiBH { Id = -1, Name = "Tất cả" });
            liLoaiDH1.AddRange(liLoaiDH);
            lueLoaiDH.Properties.DataSource = liLoaiDH1;
            lueLoaiDH.EditValue = -1;

            List<TrangThaiBH> liTrangThaiDH1 = new List<TrangThaiBH>();
            liTrangThaiDH1.Add(new TrangThaiBH { Id = -1, Name = "Tất cả" });
            liTrangThaiDH1.AddRange(liTrangThaiDH);//Common.GetListTrangThaiDonHang(LoaiGiaoDich));
            lueTrangThaiDH.Properties.DataSource = liTrangThaiDH1;
            lueTrangThaiDH.EditValue = -1;
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                TimKiemChungTu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected override bool DivCondition()
        {
            return base.DivCondition() && String.IsNullOrEmpty(filter.DiaChi) && String.IsNullOrEmpty(filter.CMND);
        }

        protected override IFilter GetFilter()
        {
            if (filter == null)
                filter = new TimKiemChungTuFilterInfor();
            filter.SoPhieu = txtSoGiaoDich.Text.Trim();
            filter.LoaiDonHang = Common.IntValue(lueLoaiDH.EditValue);
            filter.GiaoNhan = cboGiaoNhan.SelectedIndex < 0 ? -1 : arLoaiDongHang[cboGiaoNhan.SelectedIndex];
            filter.TrangThai = Common.IntValue(lueTrangThaiDH.EditValue);
            filter.IdTrungTam = CommonFuns.Instance.GetIdTrungTam(bteTrungTam, nguoiDung);
            filter.IdKho = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : -1;
            filter.LoaiMaHang = cboLoaiMaHang.SelectedIndex;
            filter.MaHang = bteNganh.Text;
            filter.NhanVien = txtNhanVien.Text.Trim();
            if (dteStart.EditValue == null)
            {
                dteStart.Focus();
                throw new ManagedException("Bạn chưa chọn ngày bắt đầu");
            }
            filter.TuNgay = dteStart.DateTime;

            if (dteEnd.EditValue == null)
            {
                dteEnd.Focus();
                throw new ManagedException("Bạn chưa chọn ngày kết thúc");
            }
            filter.DenNgay = dteEnd.DateTime;

            filter.IdDoiTuong = bteKhachHang.Tag != null ? ((DMDoiTuongInfo)bteKhachHang.Tag).IdDoiTuong : -1;
            filter.KhachHang = txtHoTenKhachHang.Text.Trim();
            filter.DiaChi = txtMaSoThue.Text.Trim();
            filter.CMND = txtCMND.Text.Trim();
            filter.DienThoai = txtDienThoai.Text.Trim();
            filter.GhiChu = txtGhiChu.Text.Trim();
            filter.UserName = CommonFuns.Instance.GetUserName();//chkCuaToi.Checked ? nguoiDung.TenDangNhap : "";
            filter.IdNhanVien = nguoiDung.IdNhanVien;
            filter.Draft = Common.IntValue(lueDraft.EditValue);
            return filter;
        }

        protected override void RefreshDataSource()
        {
            gListChungTu.RefreshDataSource();

            if (gvListChungTu.RowCount > 0)

                gvListChungTu.FocusedRowHandle = 0;

            this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + DataSource.Count + " phiếu)";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }


#endregion


        private void frmBH_TimChungTu_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode==Keys.Enter)   
                {
                    if (!this.gListChungTu.Focused)
                    {
                        SendKeys.Send("{TAB}");
                        e.Handled = true;
                        return;
                    }
                }
                if (e.KeyCode == Keys.F3)
                    this.btnTim_Click(sender, e);
                else if (e.KeyCode == Keys.F6)
                    this.cmdExport_Click(sender, e);
                //else if (e.KeyCode == Keys.F8 && btnXoaDL.Visible)
                //    this.btnXoaDL_Click(sender, e);
                else if (e.KeyCode == Keys.F12)
                    this.btnDong_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }


        private void ResetTrungTam()
        {
            bteKhoXuat.ResetText();
            bteKhoXuat.Tag = null;
        }

        private void bteTrungTam_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (UtilFunctions.bteTrungTam_ButtonClick(sender, e, bteTrungTam, nguoiDung.IdNhanVien))
                ResetTrungTam();
        }

        private void bteTrungTam_KeyDown(object sender, KeyEventArgs e)
        {
            if (UtilFunctions.bteTrungTam_KeyDown(sender, e, bteTrungTam, nguoiDung.IdNhanVien))
                ResetTrungTam();
        }

        private void bteTrungTam_TextChanged(object sender, EventArgs e)
        {
            if (UtilFunctions.bteItem_TextChanged(sender, e, bteTrungTam))
                ResetTrungTam();
        }

        private void bteKhoXuat_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteKhoXuat);
        }

        private void bteKhoXuat_KeyDown(object sender, KeyEventArgs e)
        {
            int idTrungTam = bteTrungTam.Tag != null ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam : 0;
            UtilFunctions.bteKhoXuat_KeyDown(sender, e, bteKhoXuat, idTrungTam, nguoiDung.IdNhanVien);
        }

        private void bteKhoXuat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int idTrungTam = bteTrungTam.Tag != null ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam : 0;
            UtilFunctions.bteKhoXuat_ButtonClick(sender, e, bteKhoXuat, idTrungTam, nguoiDung.IdNhanVien);
        }

        private void bteKhachHang_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteKhachHang);
        }

        private void bteKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteKhachHang_KeyDown(sender, e, bteKhachHang, -1);
        }

        private void bteKhachHang_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteKhachHang_ButtonClick(sender, e, bteKhachHang, -1);
        }

        private void gvListChungTu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);

            gListChungTu.ContextMenuStrip.Items.Clear();
            if (ct == null || TimKiem) return;

            //gListChungTu.ContextMenuStrip.Items.Add("Đơn hàng Online", null, btnLapDonHangOnline_Click);
            //gListChungTu.ContextMenuStrip.Items.Add("Duyệt đơn hàng Online", null, btnDuyetDonHangOnline_Click);
            //gListChungTu.ContextMenuStrip.Items.Add("Đơn hàng đặt trước", null, btnLapDonHangBanDatTruoc_Click);
            //gListChungTu.ContextMenuStrip.Items.Add("Đơn hàng bán tại shop", null, btnLapDonHangBan_Click);
            //gListChungTu.ContextMenuStrip.Items.Add("Đơn hàng giao nhận", null, btnLapDonHangGiaoNhan_Click);
            //gListChungTu.ContextMenuStrip.Items.Add("Phiếu xuất kho hàng bán", null, btnXuatKhoHangBan_Click);
            //gListChungTu.ContextMenuStrip.Items.Add("Đơn hàng xuất bù khuyến mại", null, btnXuatBuKhuyenMai_Click);

            if (ct.TrangThai == (int)OrderStatus.TAO_DON_HANG_ONLINE || ct.TrangThai == (int)OrderStatus.REJECT_DON_HANG_ONLINE ||
                ct.TrangThai == (int)OrderStatus.XAC_NHAN_DON_HANG_ONLINE && ct.SoChungTu.IndexOf(Declare.Prefix.XacNhanDonHangOnline) == -1)
            {
                gListChungTu.ContextMenuStrip.Items.Add("Đơn hàng Online", null, btnLapDonHangOnline_Click);
                if (ct.TrangThai == (int)OrderStatus.TAO_DON_HANG_ONLINE || ct.TrangThai == (int)OrderStatus.REJECT_DON_HANG_ONLINE)
                    gListChungTu.ContextMenuStrip.Items.Add("Duyệt đơn hàng Online", null, btnDuyetDonHangOnline_Click);
            }
            else if (ct.TrangThai == (int)OrderStatus.XAC_NHAN_DON_HANG_ONLINE && ct.SoChungTu.IndexOf(Declare.Prefix.XacNhanDonHangOnline) >= 0)
            {
                //gListChungTu.ContextMenuStrip.Items.Add("Đơn hàng Online", null, btnLapDonHangOnline_Click);
                gListChungTu.ContextMenuStrip.Items.Add("Duyệt đơn hàng Online", null, btnDuyetDonHangOnline_Click);
            }
            else if (ct.TrangThai == (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC ||
                    ct.TrangThai == (int)OrderStatus.DON_HANG_BAN_DAT_TRUOC && ct.SoChungTu.IndexOf(Declare.Prefix.DonHangBanDatTruoc) == -1)
            {
                gListChungTu.ContextMenuStrip.Items.Add("Đơn hàng đặt trước", null, btnLapDonHangBanDatTruoc_Click);
                if (ct.TrangThai == (int)OrderStatus.DON_HANG_BAN_DAT_TRUOC)
                    gListChungTu.ContextMenuStrip.Items.Add("Đơn hàng bán tại shop", null, btnLapDonHangBan_Click);
            }
            else
            {
                if (ct.LoaiChungTu == (int)TransactionType.DON_HANG_ONLINE)
                {
                    //gListChungTu.ContextMenuStrip.Items.Add("Đơn hàng Online", null, btnLapDonHangOnline_Click);
                    gListChungTu.ContextMenuStrip.Items.Add("Duyệt đơn hàng Online", null, btnDuyetDonHangOnline_Click);
                    gListChungTu.ContextMenuStrip.Items.Add("Đơn hàng bán tại shop", null, btnLapDonHangBan_Click);
                }
                else if (ct.LoaiChungTu == (int)TransactionType.DON_HANG_DAT_TRUOC)
                {
                    //gListChungTu.ContextMenuStrip.Items.Add("Đơn hàng đặt trước", null, btnLapDonHangBanDatTruoc_Click);
                    gListChungTu.ContextMenuStrip.Items.Add("Đơn hàng bán tại shop", null, btnLapDonHangBan_Click);
                }
                else if (ct.LoaiChungTu == (int)TransactionType.DON_HANG_TAI_SHOP)
                {
                    gListChungTu.ContextMenuStrip.Items.Add("Đơn hàng bán tại shop", null, btnLapDonHangBan_Click);
                }
                else if (ct.LoaiChungTu == (int)TransactionType.DON_HANG_GIAO_NHAN)
                {
                    gListChungTu.ContextMenuStrip.Items.Add("Đơn hàng giao nhận", null, btnLapDonHangGiaoNhan_Click);
                }
                else if (ct.LoaiChungTu == (int)TransactionType.DON_HANG_BU_KHUYEN_MAI)
                {
                    gListChungTu.ContextMenuStrip.Items.Add("Đơn hàng xuất bù khuyến mại", null, btnXuatBuKhuyenMai_Click);
                }
                else if (ct.LoaiChungTu == (int)TransactionType.NHAPTRAHANGMUA)
                {
                    gListChungTu.ContextMenuStrip.Items.Add("Đơn hàng nhập lại có hóa đơn gốc", null, btnLapDonHangTraLai_Click);
                }
                else if (ct.LoaiChungTu == (int)TransactionType.DOIMAHANGMUA)
                {
                    gListChungTu.ContextMenuStrip.Items.Add("Đề nghị đổi mã vạch hàng bán", null, btnLapDonHangDoiMa_Click);
                    if (ct.TrangThai == (int)OrderStatus.XAC_NHAN_DOI_MA_VACH)
                        gListChungTu.ContextMenuStrip.Items.Add("Xác nhận đổi mã vạch hàng bán", null,
                                                                btnLapDonHangDoiMaXN_Click);
                }
                else if (ct.LoaiChungTu == (int)TransactionType.DON_HANG_NHAP_LAI)
                {
                    gListChungTu.ContextMenuStrip.Items.Add("Đơn hàng nhập lại không có hóa đơn gốc", null, btnLapDonHangNLaiKhac_Click);
                }
                else if (ct.LoaiChungTu == (int)TransactionType.TRA_LAI_DON_HANG_BAN)
                {
                    gListChungTu.ContextMenuStrip.Items.Add("Nhập lại đơn hàng chưa xuất kho", null, btnNhapLaiDonHangBan_Click);
                }

                if (ct.LoaiChungTu != (int)TransactionType.DON_HANG_GIAO_NHAN && ct.TrangThai == (int)OrderStatus.XAC_NHAN_DON_HANG_GIAO_NHAN)
                {
                    gListChungTu.ContextMenuStrip.Items.Add("Phiếu phân công giao nhận", null, btnPhanCongGiaoNhan_Click);
                }
                if (ct.TrangThai == (int)OrderStatus.XUAT_KHO || ct.TrangThai == (int)OrderStatus.DANG_XUAT_KHO)
                {
                    gListChungTu.ContextMenuStrip.Items.Add("Phiếu xuất kho hàng bán", null, btnXuatKhoHangBan_Click);
                }
            }
        }

        private void btnLapDonHangOnline_Click(object sender, EventArgs e)
        {
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
            if (ct != null)
            {
                frmBH_LapDonHangBanOnline frm = new frmBH_LapDonHangBanOnline(ct);
                frm.Show();
                frm.HideMenu(true);
            }
        }

        private void btnDuyetDonHangOnline_Click(object sender, EventArgs e)
        {
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
            if (ct != null)
            {
                frmBH_DuyetDonHangBanOnline frm = new frmBH_DuyetDonHangBanOnline(ct);
                frm.Show();
                frm.HideMenu(true);
            }
        }

        private void btnLapDonHangBanDatTruoc_Click(object sender, EventArgs e)
        {
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
            if (ct != null)
            {
                frmBH_LapDonHangBanDatTruoc frm = new frmBH_LapDonHangBanDatTruoc(ct);
                frm.Show();
                frm.HideMenu(true);
            }
        }

        private void btnLapDonHangBan_Click(object sender, EventArgs e)
        {
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
            if (ct != null)
            {
                frmBH_LapDonHangBanTheTVien frm = new frmBH_LapDonHangBanTheTVien(ct);
                frm.Show();
                frm.HideMenu(true);
            }
        }

        private void btnLapDonHangGiaoNhan_Click(object sender, EventArgs e)
        {
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
            if (ct != null)
            {
                frmBH_LapDonHangBanTheTVien frm = new frmBH_LapDonHangBanTheTVien(ct);
                frm.Show();
                frm.HideMenu(true);
            }
        }

        private void btnPhanCongGiaoNhan_Click(object sender, EventArgs e)
        {
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
            if (ct != null)
            {
                List<ChungTuBanHangInfor> liCT = new List<ChungTuBanHangInfor>();
                liCT.Add(ct);
                frmBH_LapDonHangGiaoNhan frm = new frmBH_LapDonHangGiaoNhan(true, liCT);
                frm.Show();
                frm.HideMenu(true);
            }
        }

        private void btnXuatKhoHangBan_Click(object sender, EventArgs e)
        {
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
            if (ct != null)
            {
                frmBH_LapPhieuXuatKho frm = new frmBH_LapPhieuXuatKho(ct, true);
                frm.Show();
                frm.HideMenu(true);
            }
        }

        private void btnXuatBuKhuyenMai_Click(object sender, EventArgs e)
        {
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
            if (ct != null)
            {
                frmBH_LapDonHangBanKhuyenMai frm = new frmBH_LapDonHangBanKhuyenMai(ct);
                frm.Show();
                frm.HideMenu(true);
            }
        }

        private void btnLapDonHangTraLai_Click(object sender, EventArgs e)
        {
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
            if (ct != null)
            {
                frmChiTietYeuCauNhapLaiHangMua frm = new frmChiTietYeuCauNhapLaiHangMua(ct);
                frm.Show();
                frm.HideMenu();
            }
        }
        private void btnLapDonHangTraLaiXN_Click(object sender, EventArgs e)
        {
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
            if (ct != null)
            {
                frmChiTietXacNhapHangTraLai frm = new frmChiTietXacNhapHangTraLai(ct);
                frm.Show();
                frm.HideMenu();
            }
        }

        private void btnLapDonHangNLaiKhac_Click(object sender, EventArgs e)
        {
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
            if (ct != null)
            {
                frmChiTietYeuCauNhapLaiKhac frm = new frmChiTietYeuCauNhapLaiKhac(ct);
                frm.Show();
                frm.HideMenu();
            }
        }
        private void btnLapDonHangNLaiKhacXN_Click(object sender, EventArgs e)
        {
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
            if (ct != null)
            {
                frmChiTietXacNhapLaiKhac frm = new frmChiTietXacNhapLaiKhac(ct);
                frm.Show();
                frm.HideMenu();
            }
        }

        private void btnNhapLaiDonHangBan_Click(object sender, EventArgs e)
        {
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
            if (ct != null)
            {
                frmBH_LapDonHangTraLai frm = new frmBH_LapDonHangTraLai(ct);
                frm.Show();
                frm.HideMenu();
            }
        }

        private void btnLapDonHangDoiMa_Click(object sender, EventArgs e)
        {
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
            if (ct != null)
            {
                frmChiTietDeNghiDoiMa frm = new frmChiTietDeNghiDoiMa(ct);
                frm.Show();
                frm.HideMenu();
            }
        }
        private void btnLapDonHangDoiMaXN_Click(object sender, EventArgs e)
        {
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
            if (ct != null)
            {
                frmChiTietXacNhanDoiMa frm = new frmChiTietXacNhanDoiMa(ct);
                frm.Show();
                frm.HideMenu();
            }
        }
        private void cmdExport_Click(object sender, EventArgs e)
        {
            if (TimKiem)
                EditOrder(gvListChungTu.FocusedRowHandle);
            else
                Common.Export2ExcelFromDevGrid<ChungTuBanHangInfor>(gvListChungTu, "DanhSachDonHang");            
        }

        private void gvListChungTu_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(e.RowHandle);
            if (ct != null)
            {
                if (e.Column.FieldName.Equals("TrangThai"))
                {
                    if (ct.TrangThai == (int)OrderStatus.REJECT_DON_HANG_ONLINE || ct.TrangThai == (int)OrderStatus.REJECT_DON_HANG_GIAO_NHAN)
                    {
                        e.Appearance.BackColor = tsslTuChoiClr.BackColor;
                        e.Appearance.ForeColor = tsslTuChoiClr.ForeColor;
                    }
                    else if (ct.TrangThai == (int)OrderStatus.HUY_DON_HANG || ct.TrangThai == (int)OrderStatus.HUY_DON_HANG_ONLINE ||
                        ct.TrangThai == (int)OrderStatus.HUY_DON_HANG_DAT_TRUOC || ct.TrangThai == (int)OrderStatus.KHOA_DON_HANG_DAT_TRUOC)
                    {
                        e.Appearance.BackColor = tsslHuyClr.BackColor;
                        e.Appearance.ForeColor = tsslHuyClr.ForeColor;
                    }
                }
            }
        }

        private void frmBH_TimChungTu_Activated(object sender, EventArgs e)
        {
            //if (liChungTuBanHang.Count > 0 && liTimKiem.Count > 0)
            //{
            //    liChungTuBanHang.RemoveRange(liChungTuBanHang.Count - liTimKiem.Count, liTimKiem.Count);
            //    SoLuongHienTai = liChungTuBanHang.Count - liTimKiem.Count;
            //    TimKiemChungTu();                
            //}
        }

        private void btnXoaDL_Click(object sender, EventArgs e)
        {
            try
            {
                //if (selector.selection.Count > 0)
                //{
                //    if (MessageBox.Show("Bạn có chắc chắn muốn xóa các đơn hàng này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                //    {
                //        frmProgress.Instance.Description = "Đang xoa dữ liệu ....";
                //        frmProgress.Instance.MaxValue = selector.selection.Count;
                //        frmProgress.Instance.DoWork(XoaChungTu);

                //        selector.View = gvListChungTu;
                //        selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                //        selector.CheckMarkColumn.VisibleIndex = 0;
                //        ((BindingList<ChungTuBanHangInfor>)gListChungTu.DataSource).ResetBindings();

                //        if (!String.IsNullOrEmpty(err))
                //            MessageBox.Show(err);
                //        else
                //        {
                //            MessageBox.Show("Đã xóa xong các chứng từ");
                //            btnTim_Click(sender, e);
                //        }                        
                //    }
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa chứng từ:\n" + ex.ToString());
            }
        }

        private void XoaChungTu()
        {
            //err = "";
            //foreach (ChungTuBanHangInfor ctu in selector.selection)
            //{
            //    frmProgress.Instance.Description = String.Format("Đang xóa chứng từ {0} ....", ctu.SoChungTu);
            //    try
            //    {
            //        ImportChungTuDataProvider.Instance.DeleteChungTuById(ctu.IdChungTu);
            //        frmProgress.Instance.Description = String.Format("Đã xóa xong chứng từ [{0}] ....", ctu.SoChungTu);
            //        //liChungTuBanHang.Remove(ctu);
            //    }
            //    catch (Exception e)
            //    {
            //        err += String.Format("Lỗi xóa chứng từ [{0}]\n{1}\n", ctu.SoChungTu, e.ToString());
            //    }
            //    frmProgress.Instance.Value += 1;
            //}
            //frmProgress.Instance.IsCompleted = true;
            //frmProgress.Instance.Description = String.Format("Đã xóa xong {0} chứng từ", selector.selection.Count);
        }

        private void bteNganh_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteItemSegment_ButtonClick(sender, e, bteNganh, cboLoaiMaHang.SelectedIndex);
        }

        private void bteNganh_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteItemSegment_KeyDown(sender, e, bteNganh, cboLoaiMaHang.SelectedIndex);
        }

        private void bteNganh_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteNganh);
        }

        private void EditOrder(int rowHandle)
        {
            if (rowHandle < 0)
            {
                //MessageBox.Show("Chưa có đơn hàng nào được chọn! Vui lòng chọn một đơn hàng");
                return;
            }
            ChungTu = (ChungTuBanHangInfor)gvListChungTu.GetRow(rowHandle);
            this.DialogResult = DialogResult.OK;
        }

        private void gvListChungTu_DoubleClick(object sender, EventArgs e)
        {
            if (!TimKiem) return;
            Point pt = gListChungTu.PointToClient(MousePosition);
            GridHitInfo hitInfo = gvListChungTu.CalcHitInfo(pt);
            if (hitInfo.InRow)
                EditOrder(hitInfo.RowHandle);
        }

        private void gvListChungTu_KeyDown(object sender, KeyEventArgs e)
        {
            if (!TimKiem) return;
            try
            {
                if (e.KeyData == Keys.Enter && gvListChungTu.RowCount > 0)
                {
                    EditOrder(gvListChungTu.FocusedRowHandle);
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
    }
}