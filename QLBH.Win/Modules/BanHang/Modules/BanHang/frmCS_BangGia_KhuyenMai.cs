using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QLBH.Common;
using QLBH.Common.Objects;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common.Providers;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmCS_BangGia_KhuyenMai : DevExpress.XtraEditors.XtraForm
    {
        Utils ut = new Utils();
        private int IdKhuyenMai = 0;
        private bool ChinhSachDefault = false;
        private bool Enabled = true;//xem hoac sua
        private bool IsAdded = false;
        private bool Updating = false;//false: chua sua, tao moi; 1:dang sua, tao moi
        private string SoChinhSach = "CSG";
        private List<BangGiaADDKMuaInfor> liDKMua = new List<BangGiaADDKMuaInfor>();
        private List<BangGiaADKhuyenMaiInfor> ListKhuyenMai = new List<BangGiaADKhuyenMaiInfor>();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();

        public frmCS_BangGia_KhuyenMai()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        public frmCS_BangGia_KhuyenMai(List<BangGiaADDKMuaInfor> dkm, bool enabled, string soChinhSach, bool csdf)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            liDKMua = dkm;
            ListKhuyenMai = liDKMua[0].ListKhuyenMai;
            Enabled = enabled;
            ChinhSachDefault = csdf;
            if (!String.IsNullOrEmpty(soChinhSach))
                SoChinhSach = soChinhSach;
        }

        private bool ValidKhuyenMai()
        {
            //Kiem tra thong tin day du
            if (!ut.isStringNotEmpty(txtSoKhuyenMai.Text))
            {
                MessageBox.Show("Thông tin về khuyến mại chưa đủ. Mời nhập lại!");
                return false;
            }
            if (gvSanPham.RowCount==0)
            {
                MessageBox.Show("Chưa có khuyến mại nào. Xin mời nhập!");
                return false;
            }
            ////Kiem tra trung So khuyến mại
            //int idKhuyenMai = IsAdded
            //                      ? 0
            //                      : ((BangGiaADKhuyenMaiInfor) gvKhuyenMai.GetRow(gvKhuyenMai.FocusedRowHandle)).IdKhuyenMai;
            //if (KhuyenMaiDataProvider.Instance.ExistKhuyenMai(txtSoKhuyenMai.Text.Trim(), idKhuyenMai))
            //{
            //    MessageBox.Show("Số khuyến mại đã tồn tại. Mời nhập lại!");
            //    return false;
            //}
            return true;
        }
        private void UpdateKhuyenMai()
        {
            BangGiaADKhuyenMaiInfor km;
            if (IsAdded)
            {
                //tao khuyen mai
                km = new BangGiaADKhuyenMaiInfor();
                km.SoKhuyenMai = txtSoKhuyenMai.Text;
                km.GhiChu = txtGhiChu.Text;
                km.DoUuTien = Common.IntValue(nudDoUuTien.Value);
                km.SuDung = Common.Bool2Int(chkSuDung.Checked);
                km.ListKhuyenMaiChiTiet = new List<BangGiaADKhuyenMaiChiTietInfor>((BindingList<BangGiaADKhuyenMaiChiTietInfor>)gSanPham.DataSource);

                //add vao danh sach khuyen mai
                ((BindingList<BangGiaADKhuyenMaiInfor>)gKhuyenMai.DataSource).Add(km);                    
            }
            else
            {
                km = (BangGiaADKhuyenMaiInfor)gvKhuyenMai.GetRow(gvKhuyenMai.FocusedRowHandle);
                //km.IdDKMua = bgDKMua.IdDKMua;
                km.SoKhuyenMai = txtSoKhuyenMai.Text;
                km.GhiChu = txtGhiChu.Text;
                km.DoUuTien = Common.IntValue(nudDoUuTien.Value);
                km.SuDung = Common.Bool2Int(chkSuDung.Checked);
            }
            ((BindingList<BangGiaADKhuyenMaiInfor>)gKhuyenMai.DataSource).ResetBindings();
            //UpdateBGiaKhuyenMaiInfors();
        }

        private void frm_ThietLapKM_Load(object sender, EventArgs e)
        {
            cboLoaiMatHang.SelectedIndex = 6;
            LoadSanPhamInfor();
            LoadDSKhuyenMai();
            Updating = false;
            SetEDItems();
        }

        private void LoadSanPhamInfor()
        {
            txtSanPham.Text = "";
            foreach (BangGiaADDKMuaInfor bgDKMua in liDKMua)
            {
                txtSanPham.Text += bgDKMua.TenLoaiHangMua + ":" + bgDKMua.MaHangMua + " - " + bgDKMua.TenHangMua +
                                  (!String.IsNullOrEmpty(bgDKMua.TenHangSX) ? "[" + bgDKMua.TenHangSX + "]" : "") + "\r\n";
            }
            if (liDKMua != null && liDKMua.Count > 0)
                txtKhuyenMaiWeb.Text = liDKMua[0].KhuyenMaiWeb;
        }

        private  void LoadDSKhuyenMai()
        {
            if (ListKhuyenMai == null)
            {
                //load all danh sach khuyen mai
                ListKhuyenMai = KhuyenMaiDataProvider.Instance.GetAllBangGiaKhuyenMaiInfors(liDKMua[0].IdDKMua);
                for (int i = 0; i < ListKhuyenMai.Count; i++)
                {
                    ListKhuyenMai[i].ListKhuyenMaiChiTiet =
                        KhuyenMaiDataProvider.Instance.GetAllKhuyenMaiChiTietInfors(
                            ListKhuyenMai[i].IdKhuyenMai);
                }
            }

            gKhuyenMai.DataSource = new BindingList<BangGiaADKhuyenMaiInfor>(ListKhuyenMai);
            gKhuyenMai.Focus();
            if (ListKhuyenMai.Count > 0)
            {
                gvKhuyenMai.SelectRow(0);
            }
        }

        private void LoadKhuyenMaiChiTiet(BangGiaADKhuyenMaiInfor bgKMai)
        {
            IdKhuyenMai = bgKMai.IdKhuyenMai;
            txtSoKhuyenMai.Text = bgKMai.SoKhuyenMai;
            txtGhiChu.Text = bgKMai.GhiChu;
            nudDoUuTien.Value = bgKMai.DoUuTien;
            chkSuDung.Checked = Common.Int2Bool(bgKMai.SuDung);
            //load chi tiet KM
            gSanPham.DataSource = new BindingList<BangGiaADKhuyenMaiChiTietInfor>(bgKMai.ListKhuyenMaiChiTiet)
            {
                AllowEdit = true,
                AllowNew = true,
                AllowRemove = true,
                RaiseListChangedEvents = true
            }; 
        }

        private void cmdDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdThemKM_Click(object sender, EventArgs e)
        {
            IsAdded = true;
            IdKhuyenMai = 0;
            txtSoKhuyenMai.Text = Common.GetSoPhieuKM(SoChinhSach, gvKhuyenMai.RowCount + 1);
            txtGhiChu.Text = "";
            txtGhiChu.Focus();
            nudDoUuTien.Value = 0;
            chkSuDung.Checked = true;
            gSanPham.DataSource = new BindingList<BangGiaADKhuyenMaiChiTietInfor>()
            {
                AllowEdit = true,
                AllowNew = true,
                AllowRemove = true,
                RaiseListChangedEvents = true
            };
            cboLoaiMatHang.SelectedIndex = 6;
            //dgvKMChiTiet.Rows.Clear();
            Updating = true;
            SetEDItems();
        }

        private void cmdXoaKM_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvKhuyenMai.FocusedRowHandle < 0) return;
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa mục này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gvKhuyenMai.DeleteSelectedRows();
                    if (gvKhuyenMai.RowCount == 0)
                        gSanPham.DataSource = null;
                    MessageBox.Show("Khuyến mại đã được xóa");
                    Updating = false;
                    SetEDItems();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void cmdGhiKM_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidKhuyenMai())
                {
                    UpdateKhuyenMai();
                    Updating = false;
                    SetEDItems();
                }
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void cmdSuaKM_Click(object sender, EventArgs e)
        {
            IsAdded = false;
            Updating = true;
            SetEDItems();
        }
        private void SetEDItems()
        {
            txtKhuyenMaiWeb.ReadOnly = !Enabled;
            txtSoKhuyenMai.ReadOnly = !Updating || !Enabled;
            txtGhiChu.ReadOnly = !Updating || !Enabled;
            chkSuDung.Enabled = Updating && Enabled;
            nudDoUuTien.Enabled = Updating && Enabled;
            SoLuong.OptionsColumn.AllowEdit = Updating && Enabled;
            SoTienKM.OptionsColumn.AllowEdit = Updating && Enabled;
            TyLeKM.OptionsColumn.AllowEdit = Updating && Enabled;
            InKemHD.OptionsColumn.AllowEdit = Updating && Enabled;
            SuDungKM.OptionsColumn.AllowEdit = Updating && Enabled;
            TyleThanhToan.OptionsColumn.AllowEdit = Updating && Enabled;
            

            cboLoaiMatHang.Enabled = Updating && Enabled;
            txtMaMatHang.Enabled = Updating && Enabled;
            txtHangSX.Enabled = Updating && Enabled;

            //dgvKhuyenMai.Enabled = Updating;
            cmdSuaKM.Enabled = !Updating && (gvKhuyenMai.RowCount > 0) && Enabled;
            cmdThemKM.Enabled = !Updating && Enabled &&
                                (!ChinhSachDefault || ChinhSachDefault && gvKhuyenMai.RowCount < 1);
            cmdXoaKM.Enabled = (gvKhuyenMai.RowCount > 0) && Enabled;
            cmdGhiKM.Enabled = Updating && Enabled;
            btnXacNhan.Enabled = !Updating && Enabled;
            btnThemChiTietKM.Enabled = Updating && Enabled;
            cmdXoaChiTietKM.Enabled = Updating && Enabled;
            cmdDung.Enabled = Updating && Enabled;
        }

        private void cmdDung_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn hủy dữ liệu không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    LoadDSKhuyenMai();
                    Updating = false;
                    SetEDItems();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }            
        }

        private void frm_ThietLapKM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3 && btnThemChiTietKM.Enabled)
                this.btnThemChiTietKM_Click(sender, e);
            else if (e.KeyCode == Keys.F4 && cmdXoaChiTietKM.Enabled)
                this.cmdXoaChiTietKM_Click(sender, e);
            else if (e.KeyCode == Keys.F5 && cmdThemKM.Enabled)
                this.cmdThemKM_Click(sender, e);
            else if (e.KeyCode == Keys.F6 && cmdSuaKM.Enabled)
                this.cmdSuaKM_Click(sender, e);
            else if (e.KeyCode == Keys.F7 && cmdGhiKM.Enabled)
            {
                cmdGhiKM.Focus();
                this.cmdGhiKM_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F8 && cmdXoaKM.Enabled)
                this.cmdXoaKM_Click(sender, e);
            else if (e.KeyCode == Keys.F10 && cmdDung.Enabled)
                this.cmdDung_Click(sender, e);
            else if (e.KeyCode == Keys.F12 && cmdDong.Enabled)
                this.cmdDong_Click(sender, e);
            else if (e.KeyCode == Keys.F2 && btnXacNhan.Enabled)
                this.btnXacNhan_Click(sender, e);
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
                    gSanPham.DataSource = new BindingList<BangGiaADKhuyenMaiChiTietInfor>();
                }

                foreach (MatHangInfor mh in liMatHang)
                {
                    if (!ExistMaSanPham(mh.LoaiMatHang, mh.MaMatHang, mh.MaHangSX))
                    {

                        ((BindingList<BangGiaADKhuyenMaiChiTietInfor>)gSanPham.DataSource).Add(new BangGiaADKhuyenMaiChiTietInfor()
                        {
                            IdKhuyenMai = this.IdKhuyenMai,                                                        
                            LoaiHangKM = mh.LoaiMatHang,
                            TenLoaiHangKM = mh.TenLoaiMatHang,
                            MaHangKM = mh.MaMatHang,
                            TenHangKM = mh.TenMatHang,
                            MaHangSX = mh.MaHangSX,
                            TenHangSX = mh.TenHangSX,
                            ChietKhau = mh.ChietKhau,
                            SuDung = 1,
                            SoLuong = 1,
                            SoTienKM = 0,
                            TyLeKM = 0,
                            SoTienYeuCau = 0,
                            TyLeThanhToan = 100
                        });
                    }
                }
                //((BindingList<BangGiaChiTietInfor>)gSanPham.DataSource).ResetBindings();
            }
        }

        private bool ExistMaSanPham(int loaiMH, string maMH, string maHSX)
        {
            foreach (BangGiaADKhuyenMaiChiTietInfor dk in (BindingList<BangGiaADKhuyenMaiChiTietInfor>)gSanPham.DataSource)
            {
                if (dk.LoaiHangKM == loaiMH && dk.MaHangKM.Equals(maMH) && dk.MaHangSX.Equals(maHSX))
                    return true;
            }
            return false;
        }

        //private void dgvKMChiTiet_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        //{
        //    if (Common.Int2Bool(((BangGiaKhuyenMaiChiTietInfor)dgvKMChiTiet.Rows[e.RowIndex].DataBoundItem).ChietKhau))
        //    {
        //        dgvKMChiTiet.Rows[e.RowIndex].Cells["colSoLuong"].ReadOnly = true;
        //        dgvKMChiTiet.Rows[e.RowIndex].Cells["colTienKM"].ReadOnly = false;
        //    }
        //    else
        //    {
        //        dgvKMChiTiet.Rows[e.RowIndex].Cells["colSoLuong"].ReadOnly = false;
        //        dgvKMChiTiet.Rows[e.RowIndex].Cells["colTienKM"].ReadOnly = false;
        //    }
        //    Common.SetGridViewRowStyle(dgvKMChiTiet.Rows[e.RowIndex]);
        //}

        private void gvKhuyenMai_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvKhuyenMai.FocusedRowHandle <0) return;
            BangGiaADKhuyenMaiInfor bgkm = (BangGiaADKhuyenMaiInfor)gvKhuyenMai.GetRow(gvKhuyenMai.FocusedRowHandle);
            LoadKhuyenMaiChiTiet(bgkm);
        }

        private void gvSanPham_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "SoLuong")
                {
                    if (IsChietKhau(e.RowHandle))
                    {
                        e.Appearance.Options.UseBackColor = false;
                        e.Appearance.BackColor = Color.Silver;
                        //e.Appearance.ForeColor = Color.Black;
                    }
                    else
                    {
                        e.Appearance.Options.UseBackColor = true;
                        e.Appearance.BackColor = Color.White;
                        e.Appearance.ForeColor = Color.Black;
                    }
                }
            }
            catch {
            }
        }

        private void gvSanPham_ShowingEditor(object sender, CancelEventArgs e)
        {
            try
            {
                if (gvSanPham.FocusedColumn.FieldName == "SoLuong" && IsChietKhau(gvSanPham.FocusedRowHandle))
                {
                    e.Cancel = true;
                }
            }
            catch 
            {
            }
        }

        private bool IsChietKhau(int row)
        {
            BangGiaADKhuyenMaiChiTietInfor kmct = (BangGiaADKhuyenMaiChiTietInfor)gvSanPham.GetRow(gvSanPham.FocusedRowHandle);
            if (kmct != null)
                return Common.Int2Bool(kmct.ChietKhau);
            return false;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            foreach (BangGiaADDKMuaInfor bgDKMua in liDKMua)
            {
                bgDKMua.KhuyenMaiWeb = txtKhuyenMaiWeb.Text;
                bgDKMua.ListKhuyenMai = new List<BangGiaADKhuyenMaiInfor>();
                foreach (BangGiaADKhuyenMaiInfor km in ListKhuyenMai)
                {
                    BangGiaADKhuyenMaiInfor bgkm = new BangGiaADKhuyenMaiInfor(km);
                    bgDKMua.ListKhuyenMai.Add(bgkm);
                }                    
                UpdateBGiaKhuyenMaiInfors(bgDKMua);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void UpdateBGiaKhuyenMaiInfors(BangGiaADDKMuaInfor bgDKMua)
        {
            string khuyenMaiMa = "";
            string khuyenMai = "";
            foreach (BangGiaADKhuyenMaiInfor bgkm in bgDKMua.ListKhuyenMai)
            {
                if (!String.IsNullOrEmpty(khuyenMai))
                {
                    khuyenMai += "---\r\n";
                    khuyenMaiMa += "---\r\n";
                }
                    
                foreach (BangGiaADKhuyenMaiChiTietInfor kmct in bgkm.ListKhuyenMaiChiTiet)
                {
                    khuyenMai += kmct.TenHangKM.Substring(0, Math.Min(kmct.TenHangKM.Length, 30)) +
                                 (kmct.SoLuong > 1 ? (";SLng:" + kmct.SoLuong) : "") +
                                 (kmct.SoTienKM > 0 ? (";KM:" + kmct.SoTienKM) : "") +
                                 (kmct.TyLeKM > 0 ? (";TLeKM:" + kmct.TyLeKM + "%") : "") +
                                 (kmct.SoTienYeuCau > 0 ? (";TienYC:" + kmct.SoTienYeuCau) : "") +
                                 (";TLeTToan:" + kmct.TyLeThanhToan) + "\r\n";

                    khuyenMaiMa += kmct.MaHangKM +
                                   (kmct.SoLuong > 1 ? (";SLng:" + kmct.SoLuong) : "") +
                                   (kmct.SoTienKM > 0 ? (";KM:" + kmct.SoTienKM) : "") +
                                   (kmct.TyLeKM > 0 ? (";TLeKM:" + kmct.TyLeKM + "%") : "") +
                                   (kmct.SoTienYeuCau > 0 ? (";TienYC:" + kmct.SoTienYeuCau) : "") +
                                   (";TLeTToan:" + kmct.TyLeThanhToan) + "\r\n";
                }

                //khuyenMai += "\r\n";
                //khuyenMaiMa += "\r\n";
            }
            bgDKMua.KhuyenMaiMa = khuyenMaiMa;
            bgDKMua.KhuyenMai = khuyenMai;
        }

        private void gvSanPham_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gvSanPham.FocusedRowHandle < 0) return;
            int soluong = Common.IntValue(e.Value);
            if ((gvSanPham.FocusedColumn.Name.Equals("SoLuong") || gvSanPham.FocusedColumn.Name.Equals("SoTienKM") || gvSanPham.FocusedColumn.Name.Equals("TyLeKM")) &&  soluong < 0)
            {
                MessageBox.Show("Không được nhập giá trị âm. Vui lòng kiểm tra lại!");
                e.Valid = false;
            }
        }
    }
}