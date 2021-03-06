using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using QLBH.Common;
using QLBH.Common.Objects;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.HeThong.Infors;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmCS_BangGia_SanPhamNoAD : DevExpress.XtraEditors.XtraForm
    {
        private bool Enabled = true;//xem hoac sua
        private BangGiaADDKMuaInfor bgDKMua = new BangGiaADDKMuaInfor();
        private bool IsApDung = false;//sản phẩm được áp dụng hay loại trừ
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();

        public frmCS_BangGia_SanPhamNoAD()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        public frmCS_BangGia_SanPhamNoAD(BangGiaADDKMuaInfor dkm, bool enabled, bool isApDung)
        {
            InitializeComponent();
            bgDKMua = dkm;
            Enabled = enabled;
            IsApDung = isApDung;
            Common.LoadStyle(this);
            if (IsApDung)
            {
                this.Text = "Thiết lập sản phẩm được áp dụng";
                groupBox1.Text = "Danh sách mặt hàng được áp dụng";
                TenHangNoAD.Caption = "Tên hàng được áp dụng";
            }            
        }

        private bool UpdateBGiaSanPhamNoApDung()
        {
            string sanPhamNoADMa = "";
            string sanPhamNoAD = "";
            foreach (BangGiaADSPNoADInfor noad in bgDKMua.ListSanPhamNoAD)
            {
                sanPhamNoAD += noad.TenLoaiHangNoAD + "{" + (String.IsNullOrEmpty(noad.TenHangNoAD) ? "" : "SPNoAD:" + noad.TenHangNoAD)
                                + (String.IsNullOrEmpty(noad.TenHangSX) ? "" : ";HangSX:" + noad.TenHangSX)
                                + (String.Format(";Gia:{0} - {1}", noad.GiaMuaTu, noad.GiaMuaDen)) + "}\r\n";

                sanPhamNoADMa += noad.LoaiHangNoAD + "{" + (String.IsNullOrEmpty(noad.MaHangNoAD) ? "" : "SPNoAD:" + noad.MaHangNoAD)
                                + (String.IsNullOrEmpty(noad.MaHangSX) ? "" : ";HangSX:" + noad.MaHangSX) + "}\r\n"; 
            }
            bgDKMua.SanPhamNoADMa = sanPhamNoADMa;
            bgDKMua.SanPhamNoAD = sanPhamNoAD;
            return true;
        }

        private bool UpdateBGiaSanPhamYesApDung()
        {
            string sanPhamYesADMa = "";
            string sanPhamYesAD = "";
            foreach (BangGiaADSPNoADInfor noad in bgDKMua.ListSanPhamYesAD)
            {
                sanPhamYesAD += noad.TenLoaiHangNoAD.Substring(0, Math.Min(noad.TenLoaiHangNoAD.Length, 30)) + "{" + (String.IsNullOrEmpty(noad.TenHangNoAD) ? "" : "SPYesAD:" + noad.TenHangNoAD)
                                + (String.IsNullOrEmpty(noad.TenHangSX) ? "" : ";HangSX:" + noad.TenHangSX) + "}\r\n";

                sanPhamYesADMa += noad.LoaiHangNoAD + "{" + (String.IsNullOrEmpty(noad.MaHangNoAD) ? "" : "SPYesAD:" + noad.MaHangNoAD)
                                + (String.IsNullOrEmpty(noad.MaHangSX) ? "" : ";HangSX:" + noad.MaHangSX) + "}\r\n";
            }
            bgDKMua.SanPhamYesADMa = sanPhamYesADMa;
            bgDKMua.SanPhamYesAD = sanPhamYesAD;
            return true;
        }

        private void frm_ThietLapKM_Load(object sender, EventArgs e)
        {
            cboLoaiMatHang.SelectedIndex = 6;
            LoadSanPhamInfor();
            LoadDSSanPhamApDung();
            SetEDItems();

        }
        private void SetEDItems()
        {
            cboLoaiMatHang.Enabled = Enabled;
            txtMaMatHang.Enabled = Enabled;
            txtHangSX.Enabled = Enabled;

            btnThemChiTietKM.Enabled = Enabled;
            cmdXoaChiTietKM.Enabled = Enabled;
            cmdGhiKM.Enabled = Enabled;
        }

        private void LoadSanPhamInfor()
        {
            txtSanPham.Text = bgDKMua.TenLoaiHangMua + ":" + bgDKMua.MaHangMua + " - " + bgDKMua.TenHangMua +
                              (!String.IsNullOrEmpty(bgDKMua.TenHangSX) ? "[" + bgDKMua.TenHangSX + "]" : "");
        }

        private void LoadDSSanPhamApDung()
        {
            if (IsApDung)
            {
                if (bgDKMua.ListSanPhamYesAD == null)
                {
                    //load all danh sach san pham da mua
                    bgDKMua.ListSanPhamYesAD = KhuyenMaiDataProvider.Instance.GetAllSanPhamNoADInfors(bgDKMua.IdDKMua, 1);
                }

                gSanPham.DataSource = new BindingList<BangGiaADSPNoADInfor>(bgDKMua.ListSanPhamYesAD);
                gSanPham.Focus();                
            }
            else
            {
                if (bgDKMua.ListSanPhamNoAD == null)
                {
                    //load all danh sach san pham da mua
                    bgDKMua.ListSanPhamNoAD = KhuyenMaiDataProvider.Instance.GetAllSanPhamNoADInfors(bgDKMua.IdDKMua, 0);
                }

                gSanPham.DataSource = new BindingList<BangGiaADSPNoADInfor>(bgDKMua.ListSanPhamNoAD);
                gSanPham.Focus();                
            }
        }

        private void cmdDong_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            //this.Close();
        }

        private void cmdGhiKM_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsApDung)
                {
                    if (!UpdateBGiaSanPhamYesApDung())
                        return;
                }
                else
                {
                    if (!UpdateBGiaSanPhamNoApDung())
                        return;
                }
                this.DialogResult = DialogResult.OK;                                        
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        
        private void cmdXoaChiTietKM_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvSanPham.FocusedRowHandle < 0) return;
                if (MessageBox.Show("Bạn có chắc chắn xóa các items này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gvSanPham.DeleteSelectedRows();
                }
            }
            catch { }
        }



        private void frm_ThietLapKM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7 && cmdGhiKM.Enabled)
                this.cmdGhiKM_Click(sender, e);
            else if (e.KeyCode == Keys.F5 && btnThemChiTietKM.Enabled)
                this.btnThemChiTietKM_Click(sender, e);
            else if (e.KeyCode == Keys.F8 && cmdXoaChiTietKM.Enabled)
                this.cmdXoaChiTietKM_Click(sender, e);
            else if (e.KeyCode == Keys.Escape && cmdDong.Enabled)
                this.cmdDong_Click(sender, e);
        }

        private void btnThemChiTietKM_Click(object sender, EventArgs e)
        {
            List<MatHangInfor> liMatHang = new List<MatHangInfor>();
            int idNND = -1;// Common.Int2Bool(nguoiDung.SupperUser) ? -1 : nguoiDung.IdNhomNguoiDung;
            TimKiemItemInfor item = TimKiemItemDataProvider.Instance.GetItemByTypeandCode(idNND, cboLoaiMatHang.SelectedIndex, txtMaMatHang.Text.Trim());

            if (item != null)
            {
                MatHangInfor mh = new MatHangInfor();
                mh.MaMatHang = item.Ma;
                mh.TenMatHang = item.Ten;
                mh.LoaiMatHang = cboLoaiMatHang.SelectedIndex;
                mh.TenLoaiMatHang = cboLoaiMatHang.SelectedItem.ToString();
                mh.IdMatHang = item.Id;
                mh.ChietKhau = item.ChietKhau;
                mh.MaHangSX = "";
                mh.TenHangSX = "";

                TimKiemItemInfor hsx = TimKiemItemDataProvider.Instance.GetItemByTypeandCode(idNND, 7, txtHangSX.Text);
                if (hsx != null)
                {
                    mh.MaHangSX = hsx.Ma;
                    mh.TenHangSX = hsx.Ten;
                }
                liMatHang.Add(mh);
            }
            else
            {
                frmLookUp_MatHang frm = new frmLookUp_MatHang(true);
                if (frm.ShowDialog() == DialogResult.OK && frm.SelectedItems.Count > 0)
                {
                    liMatHang.AddRange(frm.SelectedItems);
                }
            }
            
            if (liMatHang.Count > 0)
            {
                if (gvSanPham.DataSource == null)
                {
                    gSanPham.DataSource = new BindingList<BangGiaADSPNoADInfor>();
                }

                foreach (MatHangInfor mh in liMatHang)
                {
                    if (!ExistMaSanPham(mh.LoaiMatHang, mh.MaMatHang, mh.MaHangSX))
                    {

                        ((BindingList<BangGiaADSPNoADInfor>)gSanPham.DataSource).Add(new BangGiaADSPNoADInfor()
                        {
                            IdDKMua = bgDKMua.IdDKMua,
                            LoaiHangNoAD = mh.LoaiMatHang,
                            TenLoaiHangNoAD = mh.TenLoaiMatHang,
                            MaHangNoAD = mh.MaMatHang,
                            TenHangNoAD = mh.TenMatHang,
                            MaHangSX = mh.MaHangSX,
                            TenHangSX = mh.TenHangSX
                        });
                    }
                }
                //((BindingList<BangGiaChiTietInfor>)gSanPham.DataSource).ResetBindings();
            }
        }

        private bool ExistMaSanPham(int loaiMH, string maMH, string maHSX)
        {
            foreach (BangGiaADSPNoADInfor dk in (BindingList<BangGiaADSPNoADInfor>)gSanPham.DataSource)
            {
                if (dk.LoaiHangNoAD == loaiMH && dk.MaHangNoAD.Equals(maMH) && dk.MaHangSX.Equals(maHSX))
                    return true;
            }
            return false;
        }
    }
}