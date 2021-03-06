using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraExport;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;
using QLBH.Core.Data;
using DevExpress.XtraExport;
using DevExpress.XtraGrid.Export;
using DevExpress.XtraEditors;
using QLBH.Core.Form;

//using QLBanHang.Class;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBC_ChinhSachGia : DevExpress.XtraEditors.XtraForm
    {
        List<BangGiaChinhSachBCInfor> liResult = new List<BangGiaChinhSachBCInfor>();
        private List<BangGiaChinhSachBCInfor> liTimKiem = new List<BangGiaChinhSachBCInfor>();
        public TimKiemBangGiaFilterInfor filter = new TimKiemBangGiaFilterInfor();
        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        public BangGiaChinhSachInfor ChinhSach = null;
        private int SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
        private int SoLuongHienTai = 0;

        public frmBC_ChinhSachGia()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }
        private void LoadComboBoxData()
        {
            LoadLoaiDoiTuong();
        }
        private void LoadLoaiDoiTuong()
        {
            List<TrangThaiBH> liLoaiKhachHang = Common.GetListLoaiKhachHang();
            repDoiTuongAD.DataSource = liLoaiKhachHang;
        }

        private void frm_TimKiem_BangGia_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
        }

        private void cmdTimKiem_Click(object sender, EventArgs e)
        {
            SoLuongHienTai = 0;
            SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
            liResult = new List<BangGiaChinhSachBCInfor>();

            TimKiemBangGia();
        }
        private void LoadDuLieu()
        {
            filter.SoBatDau = SoLuongHienTai;
            filter.SoKetThuc = SoLuongTimKiem != -1 ? SoLuongHienTai + SoLuongTimKiem : -1;
            liTimKiem = ChinhSachDataProvider.Instance.TimKiemChinhSachGiaTongHopPg(filter);
            liResult.AddRange(liTimKiem);

            //liResult = ChinhSachDataProvider.Instance.TimKiemChinhSachGiaTongHop(filter);

            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            frmProgress.Instance.IsCompleted = true;
            frmProgress.Instance.Description = "Đã xong";
        }
        private void TimKiemBangGia()
        {
            try
            {
                GetFilter();
                frmProgress.Instance.Description = SoLuongTimKiem != -1
                                                       ? String.Format("Đang lấy {0} chứng từ tiếp theo...",
                                                                       SoLuongTimKiem)
                                                       : "Đang lấy toàn bộ chứng từ...";
                frmProgress.Instance.MaxValue = SoLuongTimKiem;
                frmProgress.Instance.Value = 0;
                frmProgress.Instance.DoWork(LoadDuLieu);
                //List<BangGiaChinhSachInfor> liChinhSach = ChinhSachDataProvider.Instance.LoadChinhSachByNSD(nguoiDung.TenDangNhap);
                gChinhSach.DataSource = new BindingList<BangGiaChinhSachBCInfor>(liResult); 
                gvChinhSach.ExpandAllGroups();
                selector.View = gvChinhSach;
                ((BindingList<BangGiaChinhSachBCInfor>)gChinhSach.DataSource).ResetBindings();
                SoLuongHienTai = liResult.Count;
                selector.ClearSelection();

                //selector.CheckMarkColumn.VisibleIndex = 0;
                this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + gvChinhSach.RowCount + " chính sách giá)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GetFilter()
        {
            if (filter == null)
                filter = new TimKiemBangGiaFilterInfor();
            filter.SoBangGia = txtSoBangGia.Text.Trim();
            filter.NguoiLap = txtNguoiLap.Text;
            filter.Draft = cboTrangThai.SelectedIndex - 1;
            filter.DaDuyet = cboDuyet.SelectedIndex - 2;
            filter.IdTrungTam = bteTrungTam.Tag != null ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam : 0;
            filter.NgayHieuLuc = Convert.ToDateTime(dteStart.EditValue);
            filter.HanHieuLuc = Convert.ToDateTime(dteEnd.EditValue);
            //filter.HieuLucVoHan = chkDaDuyet.Checked ? 0 : 1;
            filter.GhiChu = txtGhiChu.Text.Trim();
            filter.MatHang = txtMatHang.Text.Trim();
        }

        private void cmdThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            EditOrder(gvChinhSach.FocusedRowHandle);
        }
        private void EditOrder(int rowHandle)
        {
            if (rowHandle < 0) return;
            ChinhSach = (BangGiaChinhSachInfor)gvChinhSach.GetRow(rowHandle);

        }

        public void setRowFocus(int index)
        {
            if (index >= 0 && index < gvChinhSach.RowCount)
                gvChinhSach.FocusedRowHandle = index;
        }

        private void frm_TimKiem_BangGia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10 && cmdTimKiem.Enabled)
                this.cmdTimKiem_Click(sender, e);
            else if (e.KeyCode == Keys.F12 && cmdExport.Enabled)
                this.cmdExport_Click(sender, e);
            else if (e.KeyCode == Keys.Escape && cmdThoat.Enabled)
                this.cmdThoat_Click(sender, e);
        }


        private void gChinhSach_DoubleClick(object sender, EventArgs e)
        {
            Point pt = gChinhSach.PointToClient(MousePosition);
            GridHitInfo hitInfo = gvChinhSach.CalcHitInfo(pt);
            if (hitInfo.InRow)
                EditOrder(hitInfo.RowHandle);

        }

        private void gChinhSach_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter && gvChinhSach.RowCount > 0)
                {
                    EditOrder(gvChinhSach.FocusedRowHandle);
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void bteTrungTam_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteTrungTam);
        }

        private void bteTrungTam_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteTrungTam_KeyDown(sender, e, bteTrungTam, nguoiDung.IdNhanVien);
        }

        private void bteTrungTam_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteTrungTam_ButtonClick(sender, e, bteTrungTam, nguoiDung.IdNhanVien);
        }

        private void cmdExport_Click(object sender, EventArgs e)
        {
            //gChinhSach.ShowPrintPreview();
            //Common.DevExport2Excel(gvChinhSach);
            Common.Export2ExcelFromDevGrid<BangGiaChinhSachBCInfor>(gvChinhSach, "BCChinhSachKM");
        }
    }
}