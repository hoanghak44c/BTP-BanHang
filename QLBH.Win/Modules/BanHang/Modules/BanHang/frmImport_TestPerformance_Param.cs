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
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmImport_TestPerformance_Param : DevExpress.XtraEditors.XtraForm
    {
        public int SoUser;
        public int SoLanLap;
        public int ThoiGian;
        public int KichBanTest;
        public string SoChungTu;

        public frmImport_TestPerformance_Param()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        public frmImport_TestPerformance_Param(int soUser, int soLanLap, int thoiGian, int kichBanTest, string soChungTu)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.SoUser = soUser;
            this.SoLanLap = soLanLap;
            this.ThoiGian = thoiGian;
            this.KichBanTest = kichBanTest;
            this.SoChungTu = soChungTu;
        }

        private void frmPhieuXuat_TraTienThua_Load(object sender, EventArgs e)
        {
            txtSoUser.Text = SoUser > 0 ? Common.Double2Str(SoUser) : "10";
            txtSoLanLap.Text = SoLanLap > 0 ? Common.Double2Str(SoLanLap) : "1";
            txtThoiGianHanhDong.Text = ThoiGian > 0 ? Common.Double2Str(ThoiGian) : "10";
            cboKichBanTest.SelectedIndex = KichBanTest;
            txtSoChungTu.Text = SoChungTu;
            if (KichBanTest > 1)
                lblSoCT.Text = "Số chứng từ gốc";
            else
                lblSoCT.Text = "Số lượng dữ liệu";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidData())
                {
                    SoUser = Common.IntValue(txtSoUser.Text);
                    SoLanLap = Common.IntValue(txtSoLanLap.Text);                    
                    ThoiGian = Common.IntValue(txtThoiGianHanhDong.Text);
                    KichBanTest = cboKichBanTest.SelectedIndex;
                    SoChungTu = txtSoChungTu.Text;

                    this.DialogResult = DialogResult.OK;                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thông tin không hợp lệ. Xin mời nhập lại!");
            }

        }
        private bool ValidData()
        {
            if (txtSoUser.Text.Trim().Equals(""))
            {
                MessageBox.Show("Phải nhập vào số user!");
                txtSoUser.Focus();
                return false;
            }

            if (Common.IntValue(txtSoUser.Text) == 0)
            {
                MessageBox.Show("Số user phải > 0!");
                txtSoUser.Focus();
                return false;
            }

            if (txtSoLanLap.Text.Trim().Equals(""))
            {
                MessageBox.Show("Phải nhập vào số lần lặp!");
                txtSoLanLap.Focus();
                return false;
            }

            if (Common.IntValue(txtSoLanLap.Text) == 0)
            {
                MessageBox.Show("Số lần lặp phải > 0!");
                txtSoLanLap.Focus();
                return false;
            }

            if (txtThoiGianHanhDong.Text.Trim().Equals(""))
            {
                MessageBox.Show("Phải nhập vào khoảng thời gian!");
                txtThoiGianHanhDong.Focus();
                return false;
            }

            if (Common.IntValue(txtThoiGianHanhDong.Text) == 0)
            {
                MessageBox.Show("Khoảng thời gian phải > 0!");
                txtThoiGianHanhDong.Focus();
                return false;
            }

            if (cboKichBanTest.SelectedIndex < 0)
            {
                MessageBox.Show("Phải chọn kịch bản test thực hiện!");
                cboKichBanTest.Focus();
                return false;
            }

            if (cboKichBanTest.SelectedIndex < 0)
            {
                MessageBox.Show("Phải chọn kịch bản test thực hiện!");
                cboKichBanTest.Focus();
                return false;
            }
            return true;
        }

        private void cboKichBanTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (KichBanTest > 1)
                lblSoCT.Text = "Số chứng từ gốc";
            else
                lblSoCT.Text = "Số lượng dữ liệu";
        }
    }
}