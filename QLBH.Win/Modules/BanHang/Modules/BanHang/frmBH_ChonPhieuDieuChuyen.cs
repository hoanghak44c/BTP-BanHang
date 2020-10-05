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

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBH_ChonPhieuDieuChuyen : DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"

        //public ChungTuBanHangInfor DonHangChinh;
        public string ListPhieuDieuChuyen = "";
        private List<ChungTuBanHangInfor> liChungTuBanHang = new List<ChungTuBanHangInfor>();
        public objGridMarkSelection selector = new objGridMarkSelection();
        private int IdKhoDen;
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
#endregion

#region "Các phương thức khởi tạo"
        public frmBH_ChonPhieuDieuChuyen()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }
        public frmBH_ChonPhieuDieuChuyen(string soPhieuDC, int idKhoDi, int idKhoDen)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            txtSoPhieuDC.Text = soPhieuDC;
            IdKhoDen = idKhoDen;

            DMKhoInfo dmKho = DMKhoDataProvider.GetKhoByIdInfo(idKhoDi);
            if (dmKho != null)
            {
                bteKhoXuat.Text = dmKho.TenKho;
                bteKhoXuat.Tag = dmKho;

                DMTrungTamInfor ttamInfor = DMTrungTamDataProvider.GetTrungTamByIdKho(idKhoDi);
                bteTrungTam.Text = ttamInfor.TenTrungTam;
                bteTrungTam.Tag = ttamInfor;
            }
        }
#endregion

#region "Các sự kiên"
        private void frmBH_TimChungTu_Load(object sender, EventArgs e)
        {
            try
            {
                TimKiemChungTu();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            TimKiemChungTu();
        }

        private void TimKiemChungTu()
        {
            try
            {
                int idKhoDi = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : -1;
                DateTime tuNgay = Convert.ToDateTime(dteStart.EditValue);
                DateTime denNgay = Convert.ToDateTime(dteEnd.EditValue);

                liChungTuBanHang = BanHangDataProvider.Instance.SearchChungTuDieuChuyen(txtSoPhieuDC.Text,
                                                                                        txtSoHoaDonDC.Text,
                                                                                        txtNhanVien.Text,
                                                                                        txtSanPham.Text, idKhoDi,
                                                                                        IdKhoDen, tuNgay, denNgay, -1, -1);//tim like
                gListChungTu.DataSource = liChungTuBanHang;
                //gvListChungTu.Columns["ParentName"].GroupIndex = 0;
                gvListChungTu.ExpandAllGroups();

                selector.View = gvListChungTu;
                selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                selector.CheckMarkColumn.VisibleIndex = 0;

                this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + liChungTuBanHang.Count + " phiếu)";
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
            if (selector.selection.Count > 0)
            {
                ListPhieuDieuChuyen = "";
                foreach (ChungTuBanHangInfor tt in selector.selection)
                {
                    ListPhieuDieuChuyen += tt.SoChungTu + ";";
                }
                if (ListPhieuDieuChuyen.Length > 0)
                    ListPhieuDieuChuyen = ListPhieuDieuChuyen.TrimEnd(";".ToCharArray());
            }
            else
            {
                if (rowHandle < 0) return;
                ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(rowHandle);
                ListPhieuDieuChuyen = ct.SoChungTu;                
            }
            this.DialogResult = DialogResult.OK;
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
    }
}