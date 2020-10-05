using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QLBanHang.Modules.BanHang.Infors;
using QLBH.Common;
using System.Drawing;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBH_ChonHangChietKhau : DevExpress.XtraEditors.XtraForm
    {
        private List<BangGiaCSachCKhauInfor> liChietKhau = new List<BangGiaCSachCKhauInfor>();
        public BangGiaCSachCKhauInfor ChietKhau = null;

        public frmBH_ChonHangChietKhau(List<BangGiaCSachCKhauInfor> lstCKhau)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.liChietKhau = lstCKhau;
        }

        private void frm_HoaDonBan_ChonTyleVAT_Load(object sender, EventArgs e)
        {
            gSanPhamBan.DataSource = null;
            gSanPhamBan.DataSource = new BindingList<BangGiaCSachCKhauInfor>(liChietKhau);
        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            try
            {
                EditOrder(gvSanPhamBan.FocusedRowHandle);
            }
            catch (System.Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
        }

        private void cmdDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvSanPhamBan_DoubleClick(object sender, EventArgs e)
        {
            Point pt = gSanPhamBan.PointToClient(MousePosition);
            GridHitInfo hitInfo = gvSanPhamBan.CalcHitInfo(pt);
            if (hitInfo.InRow)
                EditOrder(hitInfo.RowHandle);
        }

        private void EditOrder(int rowHandle)
        {
            if (rowHandle < 0) return;
            ChietKhau = (BangGiaCSachCKhauInfor)gvSanPhamBan.GetRow(rowHandle);
            if (ChietKhau == null)
            {
                MessageBox.Show("Phải chọn một mặt hàng chiết khấu!");
                return;
            }
            if (ChietKhau.SoLuong <=0)
            {
                MessageBox.Show("Số lượng phải >= 1!");
                return;                
            }
            this.DialogResult = DialogResult.OK;
        }

        private void gvSanPhamBan_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter && gvSanPhamBan.RowCount > 0)
                {
                    EditOrder(gvSanPhamBan.FocusedRowHandle);
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void gvSanPhamBan_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "SoLuong" && e.RowHandle >= 0)
            {
                BangGiaCSachCKhauInfor ck = (BangGiaCSachCKhauInfor)gvSanPhamBan.GetRow(e.RowHandle);
                ck.TongTienChietKhau = ck.TienChietKhau*ck.SoLuong;
            } 
        }

        private void gvSanPhamBan_ShowingEditor(object sender, CancelEventArgs e)
        {
            try
            {
                if (gvSanPhamBan.FocusedRowHandle < 0) return;
                if (gvSanPhamBan.FocusedColumn.FieldName == "SoLuong")
                {
                    BangGiaCSachCKhauInfor ck = (BangGiaCSachCKhauInfor)gvSanPhamBan.GetRow(gvSanPhamBan.FocusedRowHandle);
                    if (ck != null && ck.TienChietKhau == 0)
                        e.Cancel = true;
                }
            }
            catch
            {
            }

        }
    }
}