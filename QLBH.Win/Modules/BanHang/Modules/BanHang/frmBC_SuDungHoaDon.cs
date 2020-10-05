using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QLBanHang.Modules.BanHang;
using QLBanHang.Modules.HeThong;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBC_SuDungHoaDon : Form
    {
        List<SuDungHoaDonInfor> liSuDungHD = new List<SuDungHoaDonInfor>();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private objGridMarkSelection selector = new objGridMarkSelection();
        public frmBC_SuDungHoaDon()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        private void frmMoSo_Load(object sender, EventArgs e)
        {
            //LoadAllHoaDon();
            btnThemCT.Enabled = (nguoiDung.SupperUser == 1) ? true : false;
            btnSua.Enabled = (nguoiDung.SupperUser == 1) ? true : false;
            cmdXoaChiTiet.Enabled = (nguoiDung.SupperUser == 1) ? true : false;
        }

        public void LoadAllHoaDon()
        {
            try
            {
                int idTrungTam = bteTrungTam.Tag != null ? ((DMTrungTamInfor) bteTrungTam.Tag).IdTrungTam : -1;
                int idNhanVien = bteThuongVien.Tag != null ? ((DMNhanVienInfo)bteThuongVien.Tag).IdNhanVien : -1;
                int soHoaDon = Common.IntValue(txtSoHoaDon.Text);
                liSuDungHD = SuDungHoaDonDataProvider.Instance.SearchSuDungHoaDon(idTrungTam, idNhanVien, txtKyHieu.Text, soHoaDon);

                gHoaDon.DataSource = null;
                gHoaDon.DataSource = new BindingList<SuDungHoaDonInfor>(liSuDungHD);
                selector.View = gvHoaDon;
                selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                selector.CheckMarkColumn.VisibleIndex = 0;
                ((BindingList<SuDungHoaDonInfor>)gHoaDon.DataSource).ResetBindings();
            }
            catch (Exception)
            {
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            string str = "";
            try
            {
                SuDungHoaDonDataProvider.Instance.DeleteByUser(nguoiDung.IdNhanVien);
                foreach (SuDungHoaDonInfor hd in (BindingList<SuDungHoaDonInfor>)gHoaDon.DataSource)
                {
                    SuDungHoaDonDataProvider.Instance.Insert(hd);
                }

                MessageBox.Show("Cập nhật sử hóa đơn thành công", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cmdXoaChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvHoaDon.FocusedRowHandle < 0) return;
                if (MessageBox.Show("Bạn có chắc chắn xóa mục này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (selector.SelectedCount > 0)
                    {
                        foreach (SuDungHoaDonInfor hd in selector.selection)
                        {
                            if (!SuDungHoaDonDataProvider.Instance.IsInUsed(hd))
                            {
                                SuDungHoaDonDataProvider.Instance.Delete(hd);
                                ((BindingList<SuDungHoaDonInfor>) gHoaDon.DataSource).Remove(hd);
                            }
                        }
                    }
                    else
                    {
                        if (gvHoaDon.FocusedRowHandle >= 0)
                        {
                            SuDungHoaDonInfor hd = (SuDungHoaDonInfor)gvHoaDon.GetRow(gvHoaDon.FocusedRowHandle);
                            if (!SuDungHoaDonDataProvider.Instance.IsInUsed(hd))
                            {
                                SuDungHoaDonDataProvider.Instance.Delete(hd);
                                ((BindingList<SuDungHoaDonInfor>) gHoaDon.DataSource).Remove(hd);
                            }
                        }
                    }
                    //int[] indx = gvHoaDon.GetSelectedRows();
                    //for (int i = indx.Length-1; i>=0; i--)
                    //{
                    //    SuDungHoaDonInfor hd = (SuDungHoaDonInfor) gvHoaDon.GetRow(indx[i]);
                    //    if (!SuDungHoaDonDataProvider.Instance.IsInUsed(hd))
                    //    {
                    //        SuDungHoaDonDataProvider.Instance.Delete(hd);
                    //        gvHoaDon.DeleteRow(indx[i]);
                    //    }                            
                    //}
                }
            }
            catch { }
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            frmCS_KhaiBaoHoaDonByUser frm = new frmCS_KhaiBaoHoaDonByUser();
            frm.ShowDialog();
            LoadAllHoaDon();
        }

        private void gvHoaDon_DoubleClick(object sender, EventArgs e)
        {
            Point pt = gHoaDon.PointToClient(MousePosition);
            GridHitInfo hitInfo = gvHoaDon.CalcHitInfo(pt);
            if (hitInfo.InRow)
                EditObject(hitInfo.RowHandle);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                EditObject(gvHoaDon.FocusedRowHandle);
            }
            catch { }
        }
        private void EditObject(int rowHandle)
        {
            if (rowHandle < 0) return;
            SuDungHoaDonInfor hoadon = (SuDungHoaDonInfor)gvHoaDon.GetRow(rowHandle);
            EditObject(hoadon);

        }
        private void EditObject(SuDungHoaDonInfor hoadon)
        {
            frmCS_KhaiBaoHoaDonByUser frm = new frmCS_KhaiBaoHoaDonByUser(hoadon);
            frm.ShowDialog();
            LoadAllHoaDon();
        }

        private void bteTrungTam_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteTrungTam_ButtonClick(sender, e, bteTrungTam, nguoiDung.IdNhanVien);
        }

        private void bteTrungTam_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteTrungTam_KeyDown(sender, e, bteTrungTam, nguoiDung.IdNhanVien);
        }

        private void bteTrungTam_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteTrungTam);
        }

        private void bteThuongVien_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteNhanVien_ButtonClick(sender, e, bteThuongVien, -1, nguoiDung.IdNguoiDung);
        }

        private void bteThuongVien_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteNhanVien_KeyDown(sender, e, bteThuongVien, -1, nguoiDung.IdNguoiDung);
        }

        private void bteThuongVien_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteThuongVien);
        }

        private void cmdExport_Click(object sender, EventArgs e)
        {
            Common.DevExport2Excel(gvHoaDon);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadAllHoaDon();
        }

        private void frmBC_SuDungHoaDon_Activated(object sender, EventArgs e)
        {
            //LoadAllHoaDon();
        }
    }
}