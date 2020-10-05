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
    public partial class frmBH_TimKhachMuaHang : FrmBcBase1<ChungTuBanHangInfor>
        //DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"

        public TimKiemChungTuFilterInfor filter;
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        public ChungTuBanHangInfor ChungTu = null;

#endregion

#region "Các phương thức khởi tạo"
        public frmBH_TimKhachMuaHang()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            dteStart.DateTime = Declare.SYSDATE;
            dteEnd.DateTime = Declare.SYSDATE;
            DataProvider = TimKiemKhachMuaHangDataProvider.Instance;
            filter = new TimKiemChungTuFilterInfor();
            gListChungTu.DataSource = DataSource;
        }
        public frmBH_TimKhachMuaHang(List<ChungTuBanHangInfor> liChungTuBanHang, string dienThoai, string cmnd, string maSoThue)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.DataSource = liChungTuBanHang;
            txtDienThoai.Text = dienThoai;
            txtCMND.Text = cmnd;
            txtMaSoThue.Text = maSoThue;
            dteStart.DateTime = Declare.SYSDATE;
            dteEnd.DateTime = Declare.SYSDATE;
            DataProvider = TimKiemKhachMuaHangDataProvider.Instance;
            filter = new TimKiemChungTuFilterInfor();
            gListChungTu.DataSource = DataSource;
        }
#endregion

#region "Các sự kiên"
        private void frmBH_TimChungTu_Load(object sender, EventArgs e)
        {
            try
            {
                CommonFuns.Instance.LoadTrungTam(bteTrungTam, nguoiDung);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            return base.DivCondition() && String.IsNullOrEmpty(filter.MaSoThue) && String.IsNullOrEmpty(filter.CMND);
        }

        protected override IFilter GetFilter()
        {
            if (filter == null)
                filter = new TimKiemChungTuFilterInfor();
            filter.SoPhieu = txtSoGiaoDich.Text.Trim();
            filter.IdTrungTam = CommonFuns.Instance.GetIdTrungTam(bteTrungTam, nguoiDung);
            filter.IdKho = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : -1;
            filter.NhanVien = txtNhanVien.Text.Trim();
            filter.TuNgay = Convert.ToDateTime(dteStart.EditValue);
            filter.DenNgay = Convert.ToDateTime(dteEnd.EditValue);
            filter.KhachHang = txtHoTenKhachHang.Text.Trim();
            filter.CMND = txtCMND.Text.Trim();
            filter.DienThoai = txtDienThoai.Text.Trim();
            filter.MaSoThue = txtMaSoThue.Text.Trim();

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
            //if (gvListChungTu.FocusedRowHandle < 0) return;
            //ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
        }

        private void cmdExport_Click(object sender, EventArgs e)
        {
            EditOrder(gvListChungTu.FocusedRowHandle);
        }

        private void gvListChungTu_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {

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
            Point pt = gListChungTu.PointToClient(MousePosition);
            GridHitInfo hitInfo = gvListChungTu.CalcHitInfo(pt);
            if (hitInfo.InRow)
                EditOrder(hitInfo.RowHandle);
        }

        private void gvListChungTu_KeyDown(object sender, KeyEventArgs e)
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
    }
}