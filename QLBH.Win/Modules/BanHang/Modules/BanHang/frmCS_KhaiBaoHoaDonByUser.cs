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
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmCS_KhaiBaoHoaDonByUser : DevExpress.XtraEditors.XtraForm
    {
        public SuDungHoaDonInfor HoaDon = new SuDungHoaDonInfor();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();

        public frmCS_KhaiBaoHoaDonByUser()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        public frmCS_KhaiBaoHoaDonByUser(SuDungHoaDonInfor hd)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.HoaDon = hd;
        }

        private void LoadNhanVien()
        {
            DMNhanVienInfo nv = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(HoaDon.IdNhanVien);
            if (nv != null)
            {
                bteThuongVien.Text = nv.HoTen;
                bteThuongVien.Tag = nv;
                bteThuongVien.Enabled = false;
            }
        }


        private void frmPhieuXuat_TraTienThua_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
            txtKyHieu.Text = HoaDon.KyHieu;
            txtSoBatDau.Text = HoaDon.SoBatDau.ToString();
            txtSoKetThuc.Text = HoaDon.SoKetThuc.ToString();
            txtSoHienTai.Text = HoaDon.SoHienTai.ToString();
            txtSoConLai.Text = HoaDon.SoConLai.ToString();

            if (HoaDon.IdQuyen > 0)
            {
                txtKyHieu.ReadOnly = true;
                txtSoBatDau.ReadOnly = true;
                //txtSoHienTai.ReadOnly = true;
                TinhSoConLai();
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
                    if (HoaDon.IdQuyen > 0)
                        SuDungHoaDonDataProvider.Instance.Delete(HoaDon);

                    HoaDon = new SuDungHoaDonInfor();

                    HoaDon.IdNhanVien = ((DMNhanVienInfo) bteThuongVien.Tag).IdNhanVien;
                    HoaDon.KyHieu = txtKyHieu.Text.ToUpper();
                    HoaDon.SoBatDau = Common.IntValue(txtSoBatDau.Text);
                    HoaDon.SoKetThuc = Common.IntValue(txtSoKetThuc.Text);
                    HoaDon.SoHienTai = Common.IntValue(txtSoHienTai.Text);
                    HoaDon.SoConLai = Common.IntValue(txtSoConLai.Text);
                    
                    if (HoaDon.IdQuyen == 0)
                    
                        SuDungHoaDonDataProvider.Instance.Insert(HoaDon);

                    else

                        SuDungHoaDonDataProvider.Instance.Update(HoaDon);

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
            if (bteThuongVien.Tag == null)
            {
                MessageBox.Show("Phải chọn nhân viên", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
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
                MessageBox.Show("Số kết hiện tại phải > 0!");
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

            if (String.Format("{0}({1};{2})", HoaDon.KyHieu, HoaDon.SoBatDau, HoaDon.SoKetThuc).Length > 30)
            {
                MessageBox.Show(String.Format("Khai báo sử dụng hóa đơn {0} không hợp lệ!",
                    String.Format("{0}({1};{2})", HoaDon.KyHieu, HoaDon.SoBatDau, HoaDon.SoKetThuc)));
                return false;
            }

            if (nguoiDung.NhomNguoiDung != "TNBTCKT" && nguoiDung.SupperUser != 1)
            {
                if (SuDungHoaDonDataProvider.Instance.IsUsedByUser(HoaDon.IdNhanVien, txtKyHieu.Text, Common.IntValue(txtSoBatDau.Text), Common.IntValue(txtSoKetThuc.Text)))
                {
                    MessageBox.Show(String.Format("Số hóa đơn [{0}, {1}] đã được sử dụng bởi người khác", txtSoBatDau.Text, txtSoKetThuc.Text));
                    return false;
                }
                
                if (SuDungHoaDonDataProvider.Instance.IsUsedByQuyen(HoaDon.IdQuyen, txtKyHieu.Text, Common.IntValue(txtSoBatDau.Text), Common.IntValue(txtSoKetThuc.Text)))
                {
                    MessageBox.Show(String.Format("Số hóa đơn [{0}, {1}] đã được sử dụng bởi quyển khác", txtSoBatDau.Text, txtSoKetThuc.Text));
                    return false;
                }
            }

            return true;
        }

        private bool changed;

        private void txtSoBatDau_TextChanged(object sender, EventArgs e)
        {
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
            if (!changed) return;

            changed = false;

            if (Common.IntValue(txtSoBatDau.Text) == 0 || Common.IntValue(txtSoKetThuc.Text) == 0 || Common.IntValue(txtSoHienTai.Text) == 0)
            {
                txtSoConLai.Text = "0";
            }
            else
            {
                int conlai = Common.IntValue(txtSoKetThuc.Text) - Common.IntValue(txtSoHienTai.Text) + 1;

                if (HoaDon != null && HoaDon.IdQuyen > 0)
                {
                    if (SuDungHoaDonDataProvider.Instance.IsInUsed(HoaDon.IdQuyen, Common.IntValue(txtSoHienTai.Text)))

                        conlai -= 1;
                }

                txtSoConLai.Text = conlai.ToString();
            }
        }

        private void bteThuongVien_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteNhanVien_ButtonClick(sender, e, bteThuongVien, -1, nguoiDung.IdNguoiDung);
        }
    }
}