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
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBC_DonHang : DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"

        private LoaiGiaoDichBanHang LoaiGiaoDich;
        private List<ChungTuBanHangInfor> liChungTuBanHang = new List<ChungTuBanHangInfor>();
        private List<ChungTuBanHangInfor> liTimKiem = new List<ChungTuBanHangInfor>();
        public TimKiemChungTuFilterInfor filter = new TimKiemChungTuFilterInfor();
        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        int[] arLoaiDongHang = {(int)TransactionType.DON_HANG_ONLINE,
                                (int)TransactionType.DON_HANG_DAT_TRUOC,
                                (int)TransactionType.DON_HANG_TAI_SHOP};
        private int SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
        private int SoLuongHienTai = 0;

#endregion

#region "Các phương thức khởi tạo"
        public frmBC_DonHang()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }
#endregion

#region "Các sự kiên"
        private void frmBH_TimChungTu_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAllTrangThai();
                LoadCaBanHang();
                cboLoaiMaHang.SelectedIndex = 6;
                CommonFuns.Instance.LoadTrungTam(bteTrungTam, nguoiDung);
                //TimKiemChungTu();
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
            repTTTichDiem.DataSource = Common.GetListTrangThaiTichDiem();
            repGioiTinh.DataSource = Common.GetGioiTinh();

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
            liTrangThaiDH1.AddRange(Common.GetListTrangThaiDonHang(LoaiGiaoDich));
            lueTrangThaiDH.Properties.DataSource = liTrangThaiDH1;
            lueTrangThaiDH.EditValue = -1;
        }

        private void LoadCaBanHang()
        {
            List<DmCaBanHangInfor> liCaBanHang = DMCaBanHangDataProvider.Instance.GetListCaBanHangInfors();
            List<TrangThaiBH> liTTCaBanHang = new List<TrangThaiBH>();

            if (liCaBanHang != null)
            {
                for (int i=0; i<liCaBanHang.Count; i++)
                {
                    liTTCaBanHang.Add(new TrangThaiBH()
                                          {
                                              Id = i,
                                              Name = liCaBanHang[i].CaBanHang
                                          });
                }
            }
            repCaBanHang.DataSource = liTTCaBanHang;
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            SoLuongHienTai = 0;
            SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
            liChungTuBanHang = new List<ChungTuBanHangInfor>();

            TimKiemChungTu();
        }

        private void GetFilter()
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
            filter.TuNgay = Convert.ToDateTime(dteStart.EditValue);
            filter.DenNgay = Convert.ToDateTime(dteEnd.EditValue);
            filter.IdDoiTuong = bteKhachHang.Tag != null ? ((DMDoiTuongInfo)bteKhachHang.Tag).IdDoiTuong : -1;
            filter.KhachHang = txtHoTenKhachHang.Text.Trim();
            filter.DiaChi = txtDiaChi.Text.Trim();
            filter.CMND = txtCMND.Text.Trim();
            filter.DienThoai = txtDienThoai.Text.Trim();
            filter.GhiChu = txtGhiChu.Text.Trim();
            filter.UserName = CommonFuns.Instance.GetUserName();//"chkCuaToi.Checked ? nguoiDung.TenDangNhap : "";
            filter.Draft = Common.IntValue(lueDraft.EditValue);
            filter.IdNhanVien = nguoiDung.IdNhanVien;
            filter.IdNhomNguoiDung = nguoiDung.SupperUser == 1 ? -1 : nguoiDung.IdNhomNguoiDung;
        }

        private void LoadDuLieu()
        {
            filter.SoBatDau = SoLuongHienTai;
            filter.SoKetThuc = SoLuongTimKiem != -1 ? SoLuongHienTai + SoLuongTimKiem : -1;
            liTimKiem = BaoCaoDanhSachDonHangBanDataProvider.Instance.TimKiemDonHangPg(filter);
            liChungTuBanHang.AddRange(liTimKiem);

            //liChungTuBanHang = BanHangDataProvider.Instance.TimKiemChungTu(filter);

            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            frmProgress.Instance.IsCompleted = true;
            frmProgress.Instance.Description = "Đã xong";           
        }

        private void TimKiemChungTu()
        {
            try
            {
                GetFilter();
                frmProgress.Instance.Description = Common.MsgProgress(SoLuongTimKiem); 
                frmProgress.Instance.MaxValue = SoLuongTimKiem;
                frmProgress.Instance.Value = 0;
                frmProgress.Instance.DoWork(LoadDuLieu);

                gListChungTu.DataSource = null;
                gListChungTu.DataSource = new BindingList<ChungTuBanHangInfor>(liChungTuBanHang); 
                //gvListChungTu.Columns["ParentName"].GroupIndex = 0;
                gvListChungTu.ExpandAllGroups();
                selector.View = gvListChungTu;
                selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                selector.CheckMarkColumn.VisibleIndex = 0;
                ((BindingList<ChungTuBanHangInfor>)gListChungTu.DataSource).ResetBindings();
                SoLuongHienTai = liChungTuBanHang.Count;
                selector.ClearSelection();

                this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + liChungTuBanHang.Count + " phiếu)";
                //if (gvListChungTu.RowCount == 0)
                //{
                //    MessageBox.Show("Không có chứng từ nào thỏa mãn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            EditOrder(gvListChungTu.FocusedRowHandle);
        }

        private void gListChungTu_KeyDown(object sender, KeyEventArgs e)
        {
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
        private void EditOrder(int rowHandle)
        {
            return;
            if (rowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(rowHandle);

            if ((int)LoaiGiaoDich > 0 && ct != null)
            {
                this.DialogResult = DialogResult.OK;
            }
            else if (ct != null)
            {
                if (ct.TrangThai == (int)OrderStatus.TAO_DON_HANG_ONLINE || ct.TrangThai == (int)OrderStatus.REJECT_DON_HANG_ONLINE)
                {
                    frmBH_LapDonHangBanOnline frm = new frmBH_LapDonHangBanOnline(ct);
                    frm.HideMenu(true);
                    frm.ShowDialog();
                }
                else if (ct.TrangThai == (int)OrderStatus.XAC_NHAN_DON_HANG_ONLINE)
                {
                    frmBH_DuyetDonHangBanOnline frm = new frmBH_DuyetDonHangBanOnline(ct);
                    frm.HideMenu(true);
                    frm.ShowDialog();
                }
                else if (ct.TrangThai == (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC)
                {
                    frmBH_LapDonHangBanDatTruoc frm = new frmBH_LapDonHangBanDatTruoc(ct);
                    frm.HideMenu(true);
                    frm.ShowDialog();
                }
                else if (ct.TrangThai == (int)OrderStatus.DON_HANG_BAN_DAT_TRUOC || ct.TrangThai == (int)OrderStatus.DON_HANG_BAN_ONLINE ||
                        ct.TrangThai == (int)OrderStatus.DON_HANG_BAN_TAI_SHOP || ct.TrangThai == (int)OrderStatus.HUY_DON_HANG || ct.TrangThai == (int)OrderStatus.XAC_NHAN_DON_HANG_GIAO_NHAN)
                {
                    if (ct.LoaiChungTu == (int)TransactionType.DON_HANG_BU_KHUYEN_MAI)
                    {
                        frmBH_LapDonHangBanKhuyenMai frm = new frmBH_LapDonHangBanKhuyenMai(ct);
                        frm.HideMenu(true);
                        frm.ShowDialog();
                       
                    }
                    else
                    {
                        frmBH_LapDonHangBanTheTVien frm = new frmBH_LapDonHangBanTheTVien(ct);
                        frm.HideMenu(true);
                        frm.ShowDialog();
                    }
                }
                else if (ct.TrangThai == (int)OrderStatus.PHAN_CONG_GIAO_NHAN || ct.TrangThai == (int)OrderStatus.REJECT_DON_HANG_GIAO_NHAN)
                {
                    List<ChungTuBanHangInfor> lstPhieuPCGN = new List<ChungTuBanHangInfor>();
                    lstPhieuPCGN.Add(ct);
                    frmBH_LapDonHangGiaoNhan frm = new frmBH_LapDonHangGiaoNhan(true, lstPhieuPCGN);
                    frm.HideMenu(true);
                    frm.ShowDialog();
                }
                else if (ct.TrangThai == (int)OrderStatus.XUAT_KHO)
                {
                    frmBH_XuatKhoHangBan frm = new frmBH_XuatKhoHangBan(ct);
                    frm.HideMenu();
                    frm.ShowDialog();
                }
                else
                {
                    frmBH_LapDonHangBanTheTVien frm = new frmBH_LapDonHangBanTheTVien(ct);
                    frm.HideMenu(true);
                    frm.ShowDialog();
                }

            }
        }


        private void gListChungTu_DoubleClick(object sender, EventArgs e)
        {
            Point pt = gListChungTu.PointToClient(MousePosition);
            GridHitInfo hitInfo = gvListChungTu.CalcHitInfo(pt);
            if (hitInfo.InRow)
                EditOrder(hitInfo.RowHandle);
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
                    this.btnCapNhat_Click(sender, e);
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
            return;
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);

            gListChungTu.ContextMenuStrip.Items.Clear();
            if (ct == null) return;

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
                    gListChungTu.ContextMenuStrip.Items.Add("Đơn hàng đổi mã vạch hàng bán", null, btnLapDonHangDoiMa_Click);
                }
                else if (ct.LoaiChungTu == (int)TransactionType.DON_HANG_NHAP_LAI)
                {
                    gListChungTu.ContextMenuStrip.Items.Add("Đơn hàng nhập lại không có hóa đơn gốc", null, btnLapDonHangNLaiKhac_Click);
                }

                if (ct.LoaiChungTu != (int)TransactionType.DON_HANG_GIAO_NHAN && ct.TrangThai == (int)OrderStatus.XAC_NHAN_DON_HANG_GIAO_NHAN)
                {
                    gListChungTu.ContextMenuStrip.Items.Add("Phiếu phân công giao nhận", null, btnPhanCongGiaoNhan_Click);
                }
                if (ct.TrangThai == (int)OrderStatus.XUAT_KHO)
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
                frm.HideMenu(true);
                frm.ShowDialog();
            }
        }

        private void btnDuyetDonHangOnline_Click(object sender, EventArgs e)
        {
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
            if (ct != null)
            {
                frmBH_DuyetDonHangBanOnline frm = new frmBH_DuyetDonHangBanOnline(ct);
                frm.HideMenu(true);
                frm.ShowDialog();
            }
        }

        private void btnLapDonHangBanDatTruoc_Click(object sender, EventArgs e)
        {
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
            if (ct != null)
            {
                frmBH_LapDonHangBanDatTruoc frm = new frmBH_LapDonHangBanDatTruoc(ct);
                frm.HideMenu(true);
                frm.ShowDialog();
            }
        }

        private void btnLapDonHangBan_Click(object sender, EventArgs e)
        {
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
            if (ct != null)
            {
                frmBH_LapDonHangBanTheTVien frm = new frmBH_LapDonHangBanTheTVien(ct);
                frm.HideMenu(true);
                frm.ShowDialog();
            }
        }

        private void btnLapDonHangGiaoNhan_Click(object sender, EventArgs e)
        {
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
            if (ct != null)
            {
                List<ChungTuBanHangInfor> liCT = new List<ChungTuBanHangInfor>();
                liCT.Add(ct);
                frmBH_LapDonHangGiaoNhan frm = new frmBH_LapDonHangGiaoNhan(true, liCT);
                frm.HideMenu(true);
                frm.ShowDialog();
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
                frm.HideMenu(true);
                frm.ShowDialog();
            }
        }

        private void btnXuatKhoHangBan_Click(object sender, EventArgs e)
        {
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
            if (ct != null)
            {
                frmBH_LapPhieuXuatKho frm = new frmBH_LapPhieuXuatKho(ct);
                frm.HideMenu(true);
                frm.ShowDialog();
            }
        }

        private void btnXuatBuKhuyenMai_Click(object sender, EventArgs e)
        {
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
            if (ct != null)
            {
                frmBH_LapDonHangBanKhuyenMai frm = new frmBH_LapDonHangBanKhuyenMai(ct);
                frm.HideMenu(true);
                frm.ShowDialog();
            }
        }

        private void btnLapDonHangTraLai_Click(object sender, EventArgs e)
        {
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
            if (ct != null)
            {
                frmChiTietYeuCauNhapLaiHangMua frm = new frmChiTietYeuCauNhapLaiHangMua(ct);
                frm.HideMenu();
                frm.ShowDialog();
            }
        }

        private void btnLapDonHangNLaiKhac_Click(object sender, EventArgs e)
        {
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
            if (ct != null)
            {
                frmChiTietYeuCauNhapLaiKhac frm = new frmChiTietYeuCauNhapLaiKhac(ct);
                frm.HideMenu();
                frm.ShowDialog();
            }
        }

        private void btnLapDonHangDoiMa_Click(object sender, EventArgs e)
        {
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
            if (ct != null)
            {
                frmChiTietDeNghiDoiMa frm = new frmChiTietDeNghiDoiMa(ct);
                frm.HideMenu();
                frm.ShowDialog();
            }
        }

        private void cmdExport_Click(object sender, EventArgs e)
        {
            //Common.DevExport2Excel(gvListChungTu, "BCDonHang");
            Common.Export2ExcelFromDevGridTest<ChungTuBanHangInfor>(gvListChungTu, "BCDonHang");
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
    }
}