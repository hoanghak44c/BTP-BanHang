using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using QLBanHang.Class;
//using QLBanHang.Class.Objects;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmCS_BangGia_ApDungTG : DevExpress.XtraEditors.XtraForm
    {
        public BangGiaADTimeInfor Time = new BangGiaADTimeInfor();

        public frmCS_BangGia_ApDungTG()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void frmPhieuXuat_TraTienThua_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkKhungGio.Checked && !Common.CompareHours(nudGioTu.Text,nudGioDen.Text))
                {
                    MessageBox.Show("Khoảng thời gian không đúng. Thời gian bắt đầu phải nhỏ hơn thời gian kết thúc!");
                    return;
                }
                Time.DayOfWeek = cboThu.SelectedItem != null ? cboThu.SelectedItem.ToString() : "";
                Time.Thu = cboThu.SelectedIndex;
                Time.Ngay = cboNgay.SelectedIndex;
                Time.DayOfMonth = cboNgay.SelectedItem != null ? cboNgay.SelectedItem.ToString() : "";
                Time.GioTu = chkKhungGio.Checked ? nudGioTu.Text : "";
                Time.GioDen = chkKhungGio.Checked ? nudGioDen.Text : "";

                this.DialogResult = DialogResult.OK;                    
            }
            catch (Exception)
            {
                MessageBox.Show("Thông tin thanh toán không hợp lệ. Xin mời nhập lại!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            nudGioTu.Enabled = chkKhungGio.Checked;
            nudGioDen.Enabled = chkKhungGio.Checked;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmCS_BangGia_ApDungTG_Load(object sender, EventArgs e)
        {
            chkKhungGio.Checked = false;
            nudGioTu.Enabled = chkKhungGio.Checked;
            nudGioDen.Enabled = chkKhungGio.Checked;
        }
    }
}