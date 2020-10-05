using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QLBanHang.Modules.BanHang.Infors;
using QLBH.Common;
using System.Drawing;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBH_ChonHangKhuyenMai : DevExpress.XtraEditors.XtraForm
    {
        List<ChungTuBanHangChiTietInfor> liChungTuChiTiet = new List<ChungTuBanHangChiTietInfor>();
        public ChungTuBanHangChiTietInfor ChungTuChiTiet = null;

        public frmBH_ChonHangKhuyenMai(List<ChungTuBanHangChiTietInfor> liCT)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.liChungTuChiTiet = liCT;
        }

        private void frm_HoaDonBan_ChonTyleVAT_Load(object sender, EventArgs e)
        {
            gSanPhamBan.DataSource = null;
            gSanPhamBan.DataSource = liChungTuChiTiet;
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
            ChungTuChiTiet = (ChungTuBanHangChiTietInfor)gvSanPhamBan.GetRow(rowHandle);
            if (ChungTuChiTiet == null)
            {
                MessageBox.Show("Phải chọn một sản phẩm chính!");
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
    }
}