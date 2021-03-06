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
    public partial class frmCS_BangGia_SanPhamKem : DevExpress.XtraEditors.XtraForm
    {
        private bool Enabled = true;//xem hoac sua
        private BangGiaADDKMuaInfor bgDKMua = new BangGiaADDKMuaInfor();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();

        public frmCS_BangGia_SanPhamKem()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        public frmCS_BangGia_SanPhamKem(BangGiaADDKMuaInfor dkm, bool enabled)
        {
            InitializeComponent();
            bgDKMua = dkm;
            Enabled = enabled;
            Common.LoadStyle(this);
        }

        private bool UpdateBGiaSanPhamKemInfors()
        {
            string sanPhamKemMa = "";
            string sanPhamKem = "";
            double tyLePhanBo = 0;
            foreach (BangGiaADSPKemInfor spk in bgDKMua.ListSanPhamKem)
            {
                tyLePhanBo += spk.TyLePhanBo;
                sanPhamKem += spk.TenLoaiHangKem.Substring(0, Math.Min(spk.TenLoaiHangKem.Length, 30)) + "{" + (String.IsNullOrEmpty(spk.TenHangKem) ? "" : "HangKem:" + spk.TenHangKem)
                                + (String.IsNullOrEmpty(spk.TenHangSX) ? "" : ";HangSX:" + spk.TenHangSX)
                                + (String.Format(";Gia:{0} - {1}", spk.GiaMuaTu, spk.GiaMuaDen))
                                + (spk.SoLuong > 1 ? (";SLng:" + spk.SoLuong) : "") 
                                + (spk.TienChietKhau > 0 ? (";TienCK" + spk.TienChietKhau) : "")
                                + (spk.TyLeChietKhau > 0 ? (";TyleCK" + spk.TyLeChietKhau + "%") : "") + "}\r\n";

                sanPhamKemMa += spk.LoaiHangKem + "{" + (Common.IsEmptyValue(spk.MaHangKem) ? "" : "HangKem:" + spk.MaHangKem)
                                + (String.IsNullOrEmpty(spk.MaHangSX) ? "" : ";HangSX:" + spk.MaHangSX )
                                + (spk.SoLuong > 1 ? (";SLng:" + spk.SoLuong) : "")
                                + (spk.TienChietKhau > 0 ? (";TienCK" + spk.TienChietKhau) : "")
                                + (spk.TyLeChietKhau > 0 ? (";TyleCK" + spk.TyLeChietKhau + "%") : "") + "}\r\n";

            }
            if (tyLePhanBo>100)
            {
                MessageBox.Show("Tỷ lệ phân bổ không hợp lý. Tổng các sản phẩm kèm vượt quá 100%. \nXin mời nhập lại");
                return false;
            }
            bgDKMua.SanPhamKemMa = sanPhamKemMa;
            bgDKMua.SanPhamKem = sanPhamKem;
            bgDKMua.TyLePhanBo = 100 - tyLePhanBo;
            return true;
        }

        private void frm_ThietLapKM_Load(object sender, EventArgs e)
        {
            cboLoaiMatHang.SelectedIndex = 6;
            LoadSanPhamInfor();
            LoadDSSanPhamKem();
            SetEDItems();
        }
        private void SetEDItems()
        {
            SoLuong.OptionsColumn.AllowEdit = Enabled;
            TyLePhanBo.OptionsColumn.AllowEdit = Enabled;

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

        private  void LoadDSSanPhamKem()
        {
            if (bgDKMua.ListSanPhamKem == null)
            {
                //load all danh sach khuyen mai
                bgDKMua.ListSanPhamKem = KhuyenMaiDataProvider.Instance.GetAllSanPhamKemInfors(bgDKMua.IdDKMua);
            }

            gSanPham.DataSource = new BindingList<BangGiaADSPKemInfor>(bgDKMua.ListSanPhamKem);
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
                if (!UpdateBGiaSanPhamKemInfors())
                    return;
                //MessageBox.Show("Thiết lập thông tin sản phẩm mua kèm thành công!");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception e1)
            {
#if DEBUG
                MessageBox.Show(e1.ToString());
#else
                MessageBox.Show(e1.Message);
#endif
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
            int idNND = Common.Int2Bool(nguoiDung.SupperUser) ? -1 : nguoiDung.IdNhomNguoiDung;
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
                frmLookUp_MatHang frm = new frmLookUp_MatHang();
                if (frm.ShowDialog() == DialogResult.OK && frm.SelectedItems.Count > 0)
                {
                    liMatHang.AddRange(frm.SelectedItems);
                }
            }
            
            if (liMatHang.Count > 0)
            {
                if (gvSanPham.DataSource == null)
                {
                    gSanPham.DataSource = new BindingList<BangGiaADSPKemInfor>();
                }

                foreach (MatHangInfor mh in liMatHang)
                {
                    if (!ExistMaSanPham(mh.LoaiMatHang, mh.MaMatHang, mh.MaHangSX))
                    {

                        ((BindingList<BangGiaADSPKemInfor>)gSanPham.DataSource).Add(new BangGiaADSPKemInfor()
                        {
                            IdDKMua = bgDKMua.IdDKMua,
                            LoaiHangKem = mh.LoaiMatHang,
                            TenLoaiHangKem = mh.TenLoaiMatHang,
                            MaHangKem = mh.MaMatHang,
                            TenHangKem = mh.TenMatHang,
                            MaHangSX = mh.MaHangSX,
                            TenHangSX = mh.TenHangSX,
                            SoLuong = 1
                        });
                    }
                }
                //((BindingList<BangGiaChiTietInfor>)gSanPham.DataSource).ResetBindings();
            }
        }

        private bool ExistMaSanPham(int loaiMH, string maMH, string maHSX)
        {
            foreach (BangGiaADSPKemInfor dk in (BindingList<BangGiaADSPKemInfor>)gSanPham.DataSource)
            {
                if (dk.LoaiHangKem == loaiMH && dk.MaHangKem.Equals(maMH) && dk.MaHangSX.Equals(maHSX))
                    return true;
            }
            return false;
        }
    }
}