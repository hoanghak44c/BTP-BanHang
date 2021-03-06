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
    public partial class frmCS_BangGia_SanPhamDaMua : DevExpress.XtraEditors.XtraForm
    {
        private bool Enabled = true;//xem hoac sua
        private BangGiaADDKMuaInfor bgDKMua = new BangGiaADDKMuaInfor();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();

        public frmCS_BangGia_SanPhamDaMua()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        public frmCS_BangGia_SanPhamDaMua(BangGiaADDKMuaInfor dkm, bool enabled)
        {
            InitializeComponent();
            bgDKMua = dkm;
            Enabled = enabled;
            Common.LoadStyle(this);
        }

        private bool UpdateBGiaSanPhamDaMuaInfors()
        {
            string sanPhamDaMuaMa = "";
            string sanPhamDaMua = "";
            foreach (BangGiaADSPDaMuaInfor spdm in bgDKMua.ListSanPhamDaMua)
            {
                sanPhamDaMua += spdm.TenLoaiHangDaMua.Substring(0, Math.Min(spdm.TenLoaiHangDaMua.Length, 30)) + "{" + (String.IsNullOrEmpty(spdm.TenHangDaMua) ? "" : "SPMua:" + spdm.TenHangDaMua)
                                + (String.IsNullOrEmpty(spdm.TenHangSX) ? "" : ";HangSX:" + spdm.TenHangSX)
                                + (spdm.SoLuong > 1 ? (";SLuong:" + spdm.SoLuong) : "") + "}\r\n";

                sanPhamDaMuaMa += spdm.LoaiHangDaMua + "{" + (String.IsNullOrEmpty(spdm.MaHangDaMua) ? "" : "SPMua:" + spdm.MaHangDaMua)
                                + (String.IsNullOrEmpty(spdm.MaHangSX) ? "" : ";HangSX:" + spdm.MaHangSX)
                                + (spdm.SoLuong > 1 ? (";SLuong:" + spdm.SoLuong) : "") + "}\r\n"; 
            }
            bgDKMua.SanPhamDaMuaMa = sanPhamDaMuaMa;
            bgDKMua.SanPhamDaMua = sanPhamDaMua;
            return true;
        }

        private void frm_ThietLapKM_Load(object sender, EventArgs e)
        {
            cboLoaiMatHang.SelectedIndex = 6;
            LoadSanPhamInfor();
            LoadDSSanPhamDaMua();
            SetEDItems();
        }
        private void SetEDItems()
        {
            SoLuong.OptionsColumn.AllowEdit = Enabled;

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

        private void LoadDSSanPhamDaMua()
        {
            if (bgDKMua.ListSanPhamDaMua == null)
            {
                //load all danh sach san pham da mua
                bgDKMua.ListSanPhamDaMua = KhuyenMaiDataProvider.Instance.GetAllSanPhamDaMuaInfors(bgDKMua.IdDKMua);
            }

            gSanPham.DataSource = new BindingList<BangGiaADSPDaMuaInfor>(bgDKMua.ListSanPhamDaMua);
            gSanPham.Focus();
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
                if (!UpdateBGiaSanPhamDaMuaInfors())
                    return;
                //MessageBox.Show("Thiết lập thông tin sản phẩm mua kèm thành công!");
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
                    gSanPham.DataSource = new BindingList<BangGiaADSPDaMuaInfor>();
                }

                foreach (MatHangInfor mh in liMatHang)
                {
                    if (!ExistMaSanPham(mh.LoaiMatHang, mh.MaMatHang, mh.MaHangSX))
                    {

                        ((BindingList<BangGiaADSPDaMuaInfor>)gSanPham.DataSource).Add(new BangGiaADSPDaMuaInfor()
                        {
                            IdDKMua = bgDKMua.IdDKMua,
                            LoaiHangDaMua = mh.LoaiMatHang,
                            TenLoaiHangDaMua = mh.TenLoaiMatHang,
                            MaHangDaMua = mh.MaMatHang,
                            TenHangDaMua = mh.TenMatHang,
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
            foreach (BangGiaADSPDaMuaInfor dk in (BindingList<BangGiaADSPDaMuaInfor>)gSanPham.DataSource)
            {
                if (dk.LoaiHangDaMua == loaiMH && dk.MaHangDaMua.Equals(maMH) && dk.MaHangSX.Equals(maHSX))
                    return true;
            }
            return false;
        }
    }
}