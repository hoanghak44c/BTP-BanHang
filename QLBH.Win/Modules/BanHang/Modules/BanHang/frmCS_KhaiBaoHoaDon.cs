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
    public partial class frmCS_KhaiBaoHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public SuDungHoaDonInfor HoaDon = null;
        public int IdQuyen = 0;
        public string KyHieu;
        public int SoBatDau;
        public int SoKetThuc;
        public int SoHienTai;
        public int SoConLai;

        public frmCS_KhaiBaoHoaDon()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        public frmCS_KhaiBaoHoaDon(SuDungHoaDonInfor hd)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.HoaDon = hd;
        }

        private void frmPhieuXuat_TraTienThua_Load(object sender, EventArgs e)
        {
            if (HoaDon != null)
            {
                IdQuyen = HoaDon.IdQuyen;
                txtKyHieu.Text = HoaDon.KyHieu;
                txtSoBatDau.Text = HoaDon.SoBatDau.ToString();
                txtSoKetThuc.Text = HoaDon.SoKetThuc.ToString();
                txtSoHienTai.Text = HoaDon.SoHienTai.ToString();
                txtSoConLai.Text = HoaDon.SoConLai.ToString();

                txtKyHieu.ReadOnly = true;

                if (HoaDon.IdQuyen > 0)
                {
                    //txtSoHienTai.ReadOnly = true;

                    txtSoBatDau.ReadOnly = true;

                    TinhSoConLai();
                }
            }
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
                    if (HoaDon == null)
                    {
                        HoaDon = new SuDungHoaDonInfor();

                        HoaDon.KyHieu = txtKyHieu.Text.Trim().ToUpper();
                        HoaDon.SoBatDau = Common.IntValue(txtSoBatDau.Text);
                        HoaDon.SoKetThuc = Common.IntValue(txtSoKetThuc.Text);
                        HoaDon.SoHienTai = Common.IntValue(txtSoHienTai.Text);
                        HoaDon.SoConLai = Common.IntValue(txtSoConLai.Text);
                    }

                    KyHieu = txtKyHieu.Text.Trim().ToUpper();
                    SoBatDau = Common.IntValue(txtSoBatDau.Text);
                    SoKetThuc = Common.IntValue(txtSoKetThuc.Text);
                    SoHienTai = Common.IntValue(txtSoHienTai.Text);
                    SoConLai = Common.IntValue(txtSoConLai.Text);                       

                    this.DialogResult = DialogResult.OK;                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thông tin thanh toán không hợp lệ. Xin mời nhập lại!");
            }

        }
        private bool ValidData()
        {
            if (txtKyHieu.Text.Trim().Equals(""))
            {
                MessageBox.Show("Phải nhập vào ký hiệu!");
                txtKyHieu.Focus();
                return false;
            }

            if (Common.IntValue(txtSoBatDau.Text) == 0)
            {
                MessageBox.Show("Số bắt đầu phải > 0!");
                txtSoBatDau.Focus();
                return false;
            }
            if (Common.IntValue(txtSoKetThuc.Text) == 0)
            {
                MessageBox.Show("Số kết thúc phải > 0!");
                txtSoKetThuc.Focus();
                return false;
            }
            if (Common.IntValue(txtSoHienTai.Text) == 0)
            {
                MessageBox.Show("Số hiện tại phải > 0!");
                txtSoHienTai.Focus();
                return false;
            }
            if (Common.IntValue(txtSoBatDau.Text) > Common.IntValue(txtSoKetThuc.Text))
            {
                MessageBox.Show("Số bắt đầu phải nhỏ hơn Số kết thúc!");
                txtSoKetThuc.Focus();
                return false;
            }
            if (Common.IntValue(txtSoBatDau.Text) > Common.IntValue(txtSoHienTai.Text) || Common.IntValue(txtSoKetThuc.Text) < Common.IntValue(txtSoHienTai.Text))
            {
                MessageBox.Show("Số hiện tại phải nằm trong khoảng số bắt đầu và số kết thúc!");
                txtSoKetThuc.Focus();
                return false;
            }

            return true;
        }

        private bool changed;
 
        private void txtSoBatDau_TextChanged(object sender, EventArgs e)
        {
            //if (HoaDon == null)

            //    txtSoHienTai.Text = txtSoBatDau.Text;

            //TinhSoConLai();

            changed = true;
        }

        private void txtSoBatDau_Leave(object sender, EventArgs e)
        {
            if (HoaDon == null)

                txtSoHienTai.Text = txtSoBatDau.Text;

            TinhSoConLai();
        }

        private void txtSoKetThuc_TextChanged(object sender, EventArgs e)
        {
            //TinhSoConLai();
            changed = true;
        }

        private void txtSoKetThuc_Leave(object sender, EventArgs e)
        {
            if (Common.IntValue(txtSoKetThuc.Text) < Common.IntValue(txtSoHienTai.Text))
            {
                MessageBox.Show("Số kết thúc không được nhỏ hơn số hiện  tại", "Thông báo");

                txtSoKetThuc.Focus();

                txtSoKetThuc.SelectAll();

                return;
            }

            TinhSoConLai();
        }

        private void txtSoHienTai_TextChanged(object sender, EventArgs e)
        {
            //TinhSoConLai();
            changed = true;
        }

        private void txtSoHienTai_Leave(object sender, EventArgs e)
        {
            if (Common.IntValue(txtSoHienTai.Text) < Common.IntValue(txtSoBatDau.Text))
            {
                MessageBox.Show("Số hiện tại không được nhỏ hơn số bắt đầu", "Thông báo");

                txtSoHienTai.Focus();

                txtSoHienTai.SelectAll();

                return;
            }

            TinhSoConLai();
        }

        private void TinhSoConLai()
        {
            if(!changed) return;

            changed = false;

            if (Common.IntValue(txtSoBatDau.Text) == 0 || Common.IntValue(txtSoKetThuc.Text) == 0 || Common.IntValue(txtSoHienTai.Text) == 0)
            {
                txtSoConLai.Text = "0";
            }
            else
            {
                int conlai = Common.IntValue(txtSoKetThuc.Text) - Common.IntValue(txtSoHienTai.Text) + 1;

                if(HoaDon != null && HoaDon.IdQuyen > 0)
                {
                    if (SuDungHoaDonDataProvider.Instance.IsInUsed(HoaDon.IdQuyen, Common.IntValue(txtSoHienTai.Text)))

                        conlai -= 1;
                }

                txtSoConLai.Text = conlai.ToString();
            }
        }
    }
}