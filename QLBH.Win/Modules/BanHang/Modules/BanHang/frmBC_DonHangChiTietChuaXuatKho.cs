using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;
using QLBanHang.Modules.BanHang.Infors;
using QLBH.Core.Exceptions;
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBC_DonHangChiTietChuaXuatKho : FrmBcBase1<ChungTuBanHangChiTietHangHoaBCInfor>
        //DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"
        private List<ChungTuBanHangChiTietHangHoaBCInfor> liChungTuChiTiet = new List<ChungTuBanHangChiTietHangHoaBCInfor>();
        private List<ChungTuBanHangChiTietHangHoaBCInfor> liTimKiem = new List<ChungTuBanHangChiTietHangHoaBCInfor>();
        public TimKiemChungTuChiTietFilterInfor filter = new TimKiemChungTuChiTietFilterInfor();
        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
        private int SoLuongHienTai = 0;

#endregion

#region "Các phương thức khởi tạo"
        public frmBC_DonHangChiTietChuaXuatKho()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            DataProvider = BaoCaoDonHangChuaXuatDuDataProvider.Instance;
            filter = new TimKiemChungTuChiTietFilterInfor();
            gListChungTu.DataSource = DataSource;
        }
#endregion

#region "Các sự kiên"
        private void frmBH_TimChungTu_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAllTrangThai();
                CommonFuns.Instance.LoadTrungTam(bteTrungTam, nguoiDung);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadAllTrangThai()
        {
            List<TrangThaiBH> liLoaiDH = Common.GetListBCLoaiDonHang();
            List<TrangThaiBH> liTrangThaiDH = Common.GetListBCTrangThaiDonHang();
            //load trang thai cho grid
            repLoaiDonHang.DataSource = liLoaiDH;
            repTrangThaiDH.DataSource = liTrangThaiDH;

            List<TrangThaiBH> liLoaiDH1 = new List<TrangThaiBH>();
            liLoaiDH1.Add(new TrangThaiBH { Id = -1, Name = "Tất cả" });
            liLoaiDH1.AddRange(liLoaiDH);
            lueLoaiDH.Properties.DataSource = liLoaiDH1;
            lueLoaiDH.EditValue = -1;

            List<TrangThaiBH> liTrangThaiDH1 = new List<TrangThaiBH>();
            liTrangThaiDH1.Add(new TrangThaiBH { Id = -1, Name = "Tất cả" });
            liTrangThaiDH1.Add(new TrangThaiBH { Id = 0, Name = "Chưa xuất kho" });
            liTrangThaiDH1.Add(new TrangThaiBH { Id = 1, Name = "Đã xuất kho" });
            lueTrangThaiDH.Properties.DataSource = liTrangThaiDH1;
            lueTrangThaiDH.EditValue = -1;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                if(dteStart.EditValue == null || dteEnd.EditValue == null)

                    throw new ManagedException("Bạn chưa chọn ngày lập đơn hàng");

                if (dteNgayXuatTu.EditValue == null)

                    dteNgayXuatTu.EditValue = dteStart.EditValue;

                if (dteNgayXuatDen.EditValue == null)

                    dteNgayXuatDen.EditValue = dteEnd.EditValue;

                TimKiemChungTu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected override bool DivCondition()
        {
            return String.IsNullOrEmpty(filter.SoPhieu);
        }

        protected override void RefreshDataSource()
        {
            gListChungTu.RefreshDataSource();
            gvListChungTu.ExpandAllGroups();
            grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + DataSource.Count + " mặt hàng)";
        }

        protected override IFilter GetFilter()
        {
            if (filter == null)
                filter = new TimKiemChungTuChiTietFilterInfor();
            filter.SoPhieu = txtSoGiaoDich.Text.Trim();
            filter.LoaiDonHang = Common.IntValue(lueLoaiDH.EditValue);
            filter.TrangThai = Common.IntValue(lueTrangThaiDH.EditValue);
            filter.IdTrungTam = CommonFuns.Instance.GetIdTrungTam(bteTrungTam, nguoiDung);
            filter.IdKho = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : -1;
            filter.SanPham = txtSanPham.Text.Trim();
            //filter.NhanVien = txtNhanVien.Text.Trim();
            filter.TuNgay = dteStart.DateTime;
            filter.DenNgay = dteEnd.DateTime;
            filter.NXTuNgay = dteNgayXuatTu.DateTime;
            filter.NXDenNgay = dteNgayXuatDen.DateTime;
            filter.KhachHang = txtHoTenKhachHang.Text.Trim();
            filter.GhiChu = "";
            filter.UserName = CommonFuns.Instance.GetUserName();//"chkCuaToi.Checked ? nguoiDung.TenDangNhap : "";
            //filter.MaVach = txtMaVach.Text;
            filter.IdNhanVien = nguoiDung.IdNhanVien;
            filter.IdNhomNguoiDung = nguoiDung.SupperUser == 1 ? -1 : nguoiDung.IdNhomNguoiDung;

            return filter;
        }

        private void LoadDuLieu()
        {

            liChungTuChiTiet.AddRange(BanHangDataProvider.Instance.TimKiemChungTuChiTietChuaXuatDuPg(filter));

            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            frmProgress.Instance.IsCompleted = true;
            frmProgress.Instance.Description = "Đã xong";
        }

        //private void TimKiemChungTu()
        //{
        //    try
        //    {
        //        GetFilter();
        //        liChungTuChiTiet.Clear();
        //        gListChungTu.RefreshDataSource();
        //        gvListChungTu.ExpandAllGroups();
        //        this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + liChungTuChiTiet.Count + " mặt hàng)";

        //        frmProgress.Instance.Caption = Text;
        //        frmProgress.Instance.Description = "Đang tổng hợp số liệu...";
        //        frmProgress.Instance.Value = 0;
        //        frmProgress.Instance.DoWork(LoadDuLieu);

        //        selector.View = gvListChungTu;
        //        selector.CheckMarkColumn.Fixed = FixedStyle.Left;
        //        selector.CheckMarkColumn.VisibleIndex = 0;
        //        selector.ClearSelection();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

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

        private void gvListChungTu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
        }


        private void cmdExport_Click(object sender, EventArgs e)
        {
            //Common.DevExport2Excel(gvListChungTu, "BCDonHangChiTietXuatKho");
            Common.Export2ExcelFromDevGrid<ChungTuBanHangChiTietHangHoaBCInfor>(gvListChungTu, "BCDonHangChuaXuatKho");
        }

        private void gvListChungTu_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {

        }
    }
}