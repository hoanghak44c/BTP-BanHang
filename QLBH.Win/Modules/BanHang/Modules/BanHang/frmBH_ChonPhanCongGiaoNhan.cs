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
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;
using QLBH.Core.Exceptions;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBH_ChonPhanCongGiaoNhan : DevExpress.XtraEditors.XtraForm
    {
        public ChungTuGiaoNhanChiTietInfor ChiTietGiaoNhan = new ChungTuGiaoNhanChiTietInfor();
        List<DMVungMienKhachInfor> liVungMien = new List<DMVungMienKhachInfor>();
        List<DMHuyenInfor> liHuyenHD = new List<DMHuyenInfor>();
        List<DMPhuongTienGiaoNhanInfor> liPhuongTienGN = new List<DMPhuongTienGiaoNhanInfor>();
        private int IdQuanHuyen = 0;
        private bool IsPhanDon = false;
        private List<string> liLoaiCongViec = new List<string>() { "Giao hàng & lắp đặt", "Giao hàng", "Lắp đặt", "Hỗ trợ", "Bảo hành tại chỗ" };
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();

        public frmBH_ChonPhanCongGiaoNhan()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }
        public frmBH_ChonPhanCongGiaoNhan(bool isPhanDon)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.IsPhanDon = isPhanDon;
        }

        public frmBH_ChonPhanCongGiaoNhan(ChungTuGiaoNhanChiTietInfor chiTietGiaoNhan, bool isPhanDon)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.ChiTietGiaoNhan = chiTietGiaoNhan;
            this.IsPhanDon = isPhanDon;
        }

        public frmBH_ChonPhanCongGiaoNhan(int idHuyen)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.IdQuanHuyen = idHuyen;
        }
        private void LoadLoaiCongViec()
        {
            cboLoaiCongViec.DataSource = liLoaiCongViec;
            cboLoaiCongViec.SelectedIndex = -1;
            if (!String.IsNullOrEmpty(ChiTietGiaoNhan.LoaiCongViec))
            {
                for (int i = 0; i < liLoaiCongViec.Count; i++)
                    if (ChiTietGiaoNhan.LoaiCongViec.Equals(liLoaiCongViec[i]))
                        cboLoaiCongViec.SelectedIndex = i;
            }
        }

        private void LoadNhanVienGiaoNhan()
        {
            //load nhan vien
            int idNhanVien = ChiTietGiaoNhan.IdNhanVien > 0 ? ChiTietGiaoNhan.IdNhanVien : nguoiDung.IdNhanVien;
            DMNhanVienInfo nhanVien = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(idNhanVien);
            if (nhanVien != null)
            {
                bteThuongVien.Tag = nhanVien;
                bteThuongVien.Text = nhanVien.HoTen;
                txtMaNhanVien.Text = nhanVien.MaNhanVien;
            }
            if (ChiTietGiaoNhan.IdNhanVien2 > 0)
            {
                DMNhanVienInfo nv = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(ChiTietGiaoNhan.IdNhanVien2);
                if (nv != null)
                {
                    bteThuongVien2.Tag = nv;
                    bteThuongVien2.Text = nv.HoTen;
                    txtMaNhanVien2.Text = nv.MaNhanVien;
                }                
            }
            if (ChiTietGiaoNhan.IdNhanVien3 > 0)
            {
                DMNhanVienInfo nv = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(ChiTietGiaoNhan.IdNhanVien3);
                if (nv != null)
                {
                    bteThuongVien3.Tag = nv;
                    bteThuongVien3.Text = nv.HoTen;
                    txtMaNhanVien3.Text = nv.MaNhanVien;
                }
            }
            //load lai xe
            if (ChiTietGiaoNhan.IdLaiXe > 0)
            {
                DMNhanVienInfo nv = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(ChiTietGiaoNhan.IdLaiXe);
                if (nv != null)
                {
                    bteLaiXe.Tag = nv;
                    bteLaiXe.Text = nv.HoTen;
                }
            }
            //load doi tac
            if (ChiTietGiaoNhan.IdDoiTac > 0)
            {
                DMNhanVienInfo dt = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(ChiTietGiaoNhan.IdDoiTac);
                if (dt != null)
                {
                    bteDoiTac.Tag = dt;
                    bteDoiTac.Text = dt.HoTen;
                }
            }
            txtNhanVienDoiTac.Text = ChiTietGiaoNhan.NhanVienDoiTac;
        }
        private void LoadVungMienKhach()
        {
            liVungMien = DMVungMienKhachDataProvider.Instance.GetListVungMienKhachInfors();
            cboVungMienKhach.DataSource = liVungMien;
            cboVungMienKhach.DisplayMember = "TenVungMien";
            cboVungMienKhach.ValueMember = "MaVung";
            cboVungMienKhach.SelectedIndex = -1;
            if (!String.IsNullOrEmpty(ChiTietGiaoNhan.MaVungMien))
            {
                for (int i=0; i< liVungMien.Count; i++)
                    if (ChiTietGiaoNhan.MaVungMien.Equals(liVungMien[i].MaVung))
                        cboVungMienKhach.SelectedIndex = i;
            }
        }

        private void LoadPhuongTienGiaoNhan()
        {
            liPhuongTienGN = DMPhuongTienGiaoNhanDataProvider.Instance.GetListPhuongTienGiaoNhanInfors();
            cboPhuongTienGN.DataSource = liPhuongTienGN;
            cboPhuongTienGN.DisplayMember = "TenPhuongTien";
            cboPhuongTienGN.ValueMember = "MaPhuongTien";
            cboPhuongTienGN.SelectedIndex = -1;
            if (!String.IsNullOrEmpty(ChiTietGiaoNhan.MaPhuongTien))
            {
                for (int i = 0; i < liPhuongTienGN.Count; i++)
                    if (ChiTietGiaoNhan.MaPhuongTien.Equals(liPhuongTienGN[i].MaPhuongTien))
                        cboPhuongTienGN.SelectedIndex = i;
            }
        }

        //private void LoadDMHuyenHD()
        //{
        //    liHuyenHD = DMHuyenDataProvider.Instance.GetListHuyenByTinhInfors(-1);
        //    cboHuyenHD.DataSource = liHuyenHD;
        //    cboHuyenHD.DisplayMember = "TenHuyen";
        //    cboHuyenHD.ValueMember = "IdHuyen";
        //    cboHuyenHD.SelectedIndex = -1;
        //    //cboHuyenHD.SelectedValue = IdQuanHuyen;
        //}
        private void LoadBienXe()
        {
            if (cboPhuongTienGN.SelectedIndex >= 0 && liPhuongTienGN[cboPhuongTienGN.SelectedIndex].GhiChu!=null)
            {
                string []arrBienSo = liPhuongTienGN[cboPhuongTienGN.SelectedIndex].GhiChu.Split("/".ToCharArray());
                for (int i=0; i< arrBienSo.Length; i++)
                {
                    txtBienSoXe.Items.Add(arrBienSo[i]);
                }
            }
        }

        private void LoadQuanHuyen()
        {
            if (ChiTietGiaoNhan.IdQuanHuyen > 0)
            {
                DMHuyenInfor qh = DMHuyenDataProvider.Instance.GetQuanHuyenById(ChiTietGiaoNhan.IdQuanHuyen);
                if (qh != null)
                {
                    bteQuanHuyen.Tag = qh;
                    bteQuanHuyen.Text = qh.TenHuyen;
                }
            }
        }
        private void frmPhieuXuat_TraTienThua_Load(object sender, EventArgs e)
        {
            //LoadDMHuyenHD();
            LoadQuanHuyen();
            LoadLoaiCongViec();
            LoadNhanVienGiaoNhan();
            LoadVungMienKhach();
            LoadPhuongTienGiaoNhan();
            cboLoaiCongViec.Focus();
            txtGhiChu.Text = ChiTietGiaoNhan.GhiChu;
            txtBienSoXe.Text = ChiTietGiaoNhan.BienSoXe;
            //cboVungMienKhach.SelectedIndex = -1;
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
                if (ValidData())
                {
                    ChiTietGiaoNhan.IdNhanVien = bteThuongVien.Tag != null ? ((DMNhanVienInfo) bteThuongVien.Tag).IdNhanVien : 0;
                    ChiTietGiaoNhan.MaNhanVien = bteThuongVien.Tag != null ? ((DMNhanVienInfo)bteThuongVien.Tag).MaNhanVien : "";
                    ChiTietGiaoNhan.HoTen = bteThuongVien.Tag != null ? ((DMNhanVienInfo)bteThuongVien.Tag).HoTen : "";
                    ChiTietGiaoNhan.IdNhanVien2 = bteThuongVien2.Tag != null ? ((DMNhanVienInfo)bteThuongVien2.Tag).IdNhanVien : 0;
                    ChiTietGiaoNhan.MaNhanVien2 = bteThuongVien2.Tag != null ? ((DMNhanVienInfo)bteThuongVien2.Tag).MaNhanVien : "";
                    ChiTietGiaoNhan.HoTen2 = bteThuongVien2.Tag != null ? ((DMNhanVienInfo)bteThuongVien2.Tag).HoTen : "";
                    ChiTietGiaoNhan.IdNhanVien3 = bteThuongVien3.Tag != null ? ((DMNhanVienInfo)bteThuongVien3.Tag).IdNhanVien : 0;
                    ChiTietGiaoNhan.MaNhanVien3 = bteThuongVien3.Tag != null ? ((DMNhanVienInfo)bteThuongVien3.Tag).MaNhanVien : "";
                    ChiTietGiaoNhan.HoTen3 = bteThuongVien3.Tag != null ? ((DMNhanVienInfo)bteThuongVien3.Tag).HoTen : "";
                    ChiTietGiaoNhan.MaVungMien = liVungMien[cboVungMienKhach.SelectedIndex].MaVung;
                    ChiTietGiaoNhan.TenVungMien = liVungMien[cboVungMienKhach.SelectedIndex].TenVungMien;
                    ChiTietGiaoNhan.IdQuanHuyen = bteQuanHuyen.Tag != null ? ((DMHuyenInfor)bteQuanHuyen.Tag).IdHuyen : 0;
                    ChiTietGiaoNhan.TenQuanHuyen = bteQuanHuyen.Tag != null ? ((DMHuyenInfor)bteQuanHuyen.Tag).TenHuyen : "";
                    ChiTietGiaoNhan.LoaiCongViec = liLoaiCongViec[cboLoaiCongViec.SelectedIndex];
                    ChiTietGiaoNhan.MaPhuongTien = liPhuongTienGN[cboPhuongTienGN.SelectedIndex].MaPhuongTien;
                    ChiTietGiaoNhan.TenPhuongTien = liPhuongTienGN[cboPhuongTienGN.SelectedIndex].TenPhuongTien;
                    ChiTietGiaoNhan.BienSoXe = String.IsNullOrEmpty(txtBienSoXe.Text) ? String.Empty : txtBienSoXe.Text.Trim();
                    ChiTietGiaoNhan.IdLaiXe = bteLaiXe.Tag != null ? ((DMNhanVienInfo)bteLaiXe.Tag).IdNhanVien : 0;
                    ChiTietGiaoNhan.MaLaiXe = bteLaiXe.Tag != null ? ((DMNhanVienInfo)bteLaiXe.Tag).MaNhanVien : "";
                    ChiTietGiaoNhan.TenLaiXe = bteLaiXe.Tag != null ? ((DMNhanVienInfo)bteLaiXe.Tag).HoTen : "";
                    ChiTietGiaoNhan.IdDoiTac = bteDoiTac.Tag != null ? ((DMDoiTuongInfo)bteDoiTac.Tag).IdDoiTuong : 0;
                    ChiTietGiaoNhan.MaDoiTac = bteDoiTac.Tag != null ? ((DMDoiTuongInfo)bteDoiTac.Tag).MaDoiTuong : "";
                    ChiTietGiaoNhan.TenDoiTac = bteDoiTac.Tag != null ? ((DMDoiTuongInfo)bteDoiTac.Tag).TenDoiTuong : "";
                    ChiTietGiaoNhan.NhanVienDoiTac = String.IsNullOrEmpty(txtNhanVienDoiTac.Text) ? String.Empty : txtNhanVienDoiTac.Text.Trim();
                    ChiTietGiaoNhan.GhiChu = String.IsNullOrEmpty(txtGhiChu.Text) ? String.Empty : txtGhiChu.Text.Trim();

                    try
                    {
                        ChiTietGiaoNhan.DonGiaVanChuyen = String.IsNullOrEmpty(txtDonGiaVanChuyen.Text)
                                                              ? 0
                                                              : Convert.ToDouble(txtDonGiaVanChuyen.Text);
                    }
                    catch (Exception)
                    {
                        txtDonGiaVanChuyen.Focus();

                        throw new ManagedException("Đơn giá vận chuyển không đúng định dạng số");
                    }

                    try
                    {
                        ChiTietGiaoNhan.DonGiaLapDat = String.IsNullOrEmpty(txtDonGiaLapDat.Text)
                                                              ? 0
                                                              : Convert.ToDouble(txtDonGiaLapDat.Text);
                    }
                    catch (Exception)
                    {
                        txtDonGiaLapDat.Focus();

                        throw new ManagedException("Đơn giá lắp đặt không đúng định dạng số");
                    }

                    try
                    {
                        ChiTietGiaoNhan.PhuCapVuotTroi = String.IsNullOrEmpty(txtPhuCapVuotTroi.Text)
                                                              ? 0
                                                              : Convert.ToDouble(txtPhuCapVuotTroi.Text);
                    }
                    catch (Exception)
                    {
                        txtPhuCapVuotTroi.Focus();

                        throw new ManagedException("Phụ cấp vượt trội không đúng định dạng số");
                    }

                    this.DialogResult = DialogResult.OK;                    
                }
            }
            catch (ManagedException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
        }

        private bool ValidData()
        {
            if (cboLoaiCongViec.SelectedIndex < 0)
            {
                MessageBox.Show("Chọn loại công việc");
                cboLoaiCongViec.Focus();
                return false;
            }
            if (bteThuongVien.Tag == null && bteThuongVien2.Tag == null && bteThuongVien3.Tag == null && bteDoiTac.Tag == null)
            {
                MessageBox.Show("Chọn nhân viên giao nhân");
                //bteThuongVien.Focus();
                return false;
            }
            if (cboVungMienKhach.SelectedIndex < 0)
            {
                MessageBox.Show("Chọn vùng miền giao nhận");
                cboVungMienKhach.Focus();
                return false;
            }
            if (cboPhuongTienGN.SelectedIndex < 0)
            {
                MessageBox.Show("Chọn phương tiện giao nhân");
                cboPhuongTienGN.Focus();
                return false;
            }

            return true;
        }

        private void bteThuongVien_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteNhanVien_ButtonClick(sender, e, bteThuongVien, -1, nguoiDung.IdNguoiDung);
            txtMaNhanVien.Text = bteThuongVien.Tag != null ? ((DMNhanVienInfo)bteThuongVien.Tag).MaNhanVien : "";
        }

        private void bteThuongVien_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteNhanVien_KeyDown(sender, e, bteThuongVien, -1, nguoiDung.IdNguoiDung);
            txtMaNhanVien.Text = bteThuongVien.Tag != null ? ((DMNhanVienInfo)bteThuongVien.Tag).MaNhanVien : "";
        }

        private void bteThuongVien_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteThuongVien);
            txtMaNhanVien.Text = bteThuongVien.Tag != null ? ((DMNhanVienInfo) bteThuongVien.Tag).MaNhanVien : "";
        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            //bteThuongVien.Text = txtMaNhanVien.Text;
            //UtilFunctions.bteItem_TextChanged(sender, e, bteThuongVien);
        }

        private void cboPhuongTienGN_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBienXe();
        }

        private void txtMaNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtMaNhanVien_Leave(sender, e);
            }
        }

        private void bteQuanHuyen_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteQuanHuyen_ButtonClick(sender, e, bteQuanHuyen);
        }

        private void bteQuanHuyen_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteQuanHuyen_KeyDown(sender, e, bteQuanHuyen);
        }

        private void bteQuanHuyen_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteQuanHuyen);
        }

        private void bteDoiTac_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteNhaCungCap_ButtonClick(sender, e, bteDoiTac, true);
        }

        private void bteDoiTac_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteNhaCungCap_KeyDown(sender, e, bteDoiTac, true);
        }

        private void bteDoiTac_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteDoiTac);
        }

        private void txtMaNhanVien_Leave(object sender, EventArgs e)
        {
            DMNhanVienInfo nhanvien = DmNhanVienDataProvider.GetNhanVienByText(txtMaNhanVien.Text);
            if (nhanvien != null)
            {
                txtMaNhanVien.Text = nhanvien.MaNhanVien;
                bteThuongVien.Tag = nhanvien;
                bteThuongVien.Text = nhanvien.HoTen;
            }
            else
            {
                txtMaNhanVien.Text = "";
                bteThuongVien.Tag = null;
                bteThuongVien.Text = "";
                //bteThuongVien_KeyDown(null, null);
            } 
        }

        private void bteThuongVien2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteNhanVien_ButtonClick(sender, e, bteThuongVien2, -1, nguoiDung.IdNguoiDung);
            txtMaNhanVien2.Text = bteThuongVien2.Tag != null ? ((DMNhanVienInfo)bteThuongVien2.Tag).MaNhanVien : "";
        }

        private void bteThuongVien2_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteNhanVien_KeyDown(sender, e, bteThuongVien2, -1, nguoiDung.IdNguoiDung);
            txtMaNhanVien2.Text = bteThuongVien2.Tag != null ? ((DMNhanVienInfo)bteThuongVien2.Tag).MaNhanVien : "";
        }

        private void bteThuongVien2_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteThuongVien2);
            txtMaNhanVien2.Text = bteThuongVien2.Tag != null ? ((DMNhanVienInfo)bteThuongVien2.Tag).MaNhanVien : "";
        }

        private void bteThuongVien3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteNhanVien_ButtonClick(sender, e, bteThuongVien3, -1, nguoiDung.IdNguoiDung);
            txtMaNhanVien3.Text = bteThuongVien3.Tag != null ? ((DMNhanVienInfo)bteThuongVien3.Tag).MaNhanVien : "";
        }

        private void bteThuongVien3_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteNhanVien_KeyDown(sender, e, bteThuongVien3, -1, nguoiDung.IdNguoiDung);
            txtMaNhanVien3.Text = bteThuongVien3.Tag != null ? ((DMNhanVienInfo)bteThuongVien3.Tag).MaNhanVien : "";
        }

        private void bteThuongVien3_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteThuongVien3);
            txtMaNhanVien3.Text = bteThuongVien3.Tag != null ? ((DMNhanVienInfo)bteThuongVien3.Tag).MaNhanVien : "";
        }

        private void txtMaNhanVien2_Leave(object sender, EventArgs e)
        {
            DMNhanVienInfo nhanvien = DmNhanVienDataProvider.GetNhanVienByText(txtMaNhanVien2.Text);
            if (nhanvien != null)
            {
                txtMaNhanVien2.Text = nhanvien.MaNhanVien;
                bteThuongVien2.Tag = nhanvien;
                bteThuongVien2.Text = nhanvien.HoTen;
            }
            else
            {
                txtMaNhanVien2.Text = "";
                bteThuongVien2.Tag = null;
                bteThuongVien2.Text = "";
                //bteThuongVien_KeyDown(null, null);
            } 
        }

        private void txtMaNhanVien2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtMaNhanVien2_Leave(sender, e);
            }
        }

        private void txtMaNhanVien3_Leave(object sender, EventArgs e)
        {
            DMNhanVienInfo nhanvien = DmNhanVienDataProvider.GetNhanVienByText(txtMaNhanVien3.Text);
            if (nhanvien != null)
            {
                txtMaNhanVien3.Text = nhanvien.MaNhanVien;
                bteThuongVien3.Tag = nhanvien;
                bteThuongVien3.Text = nhanvien.HoTen;
            }
            else
            {
                txtMaNhanVien3.Text = "";
                bteThuongVien3.Tag = null;
                bteThuongVien3.Text = "";
                //bteThuongVien_KeyDown(null, null);
            } 
        }

        private void txtMaNhanVien3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtMaNhanVien3_Leave(sender, e);
            }
        }

        private void bteLaiXe_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteNhanVien_ButtonClick(sender, e, bteLaiXe, -1, nguoiDung.IdNguoiDung);
        }

        private void bteLaiXe_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteNhanVien_KeyDown(sender, e, bteLaiXe, -1, nguoiDung.IdNguoiDung);
        }

        private void bteLaiXe_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteLaiXe);
        }
    }
}