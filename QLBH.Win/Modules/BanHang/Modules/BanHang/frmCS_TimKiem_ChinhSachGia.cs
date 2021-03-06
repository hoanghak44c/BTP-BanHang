using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraExport;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;
using QLBH.Core.Data;
using DevExpress.XtraExport;
using DevExpress.XtraGrid.Export;
using DevExpress.XtraEditors;
using QLBH.Core.Form;

//using QLBanHang.Class;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmCS_TimKiem_ChinhSachGia : DevExpress.XtraEditors.XtraForm
    {
        List<BangGiaChinhSachInfor> liResult = new List<BangGiaChinhSachInfor>();
        private List<BangGiaChinhSachInfor> liTimKiem = new List<BangGiaChinhSachInfor>();
        public TimKiemBangGiaFilterInfor filter = new TimKiemBangGiaFilterInfor();
        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        public BangGiaChinhSachInfor ChinhSach = null;
        private int SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
        private int SoLuongHienTai = 0;
        private int KieuTimKiem = 0;//0: gọi từ menu, 1: gọi từ form bảng giá, 2: gọi từ form duyệt bảng giá
        public frmCS_TimKiem_ChinhSachGia()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }
        public frmCS_TimKiem_ChinhSachGia(int callByBG)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            KieuTimKiem = callByBG;
        }
        private void LoadComboBoxData()
        {
            LoadNhomDoiTuong();
            LoadLoaiDoiTuong();
        }
        private void LoadLoaiDoiTuong()
        {
            List<TrangThaiBH> liLoaiChinhSach = Common.GetLoaiChinhSachGia();
            repLoaiCS.DataSource = liLoaiChinhSach;

            List<TrangThaiBH> liLoaiKhachHang = Common.GetListLoaiKhachHang();
            repDoiTuongAD.DataSource = liLoaiKhachHang;

            List<TrangThaiBH> liLoaiChinhSach1 = new List<TrangThaiBH>();
            liLoaiChinhSach1.Add(new TrangThaiBH() { Id = -1, Name = "Tất cả" });
            liLoaiChinhSach1.AddRange(liLoaiChinhSach);
            cboLoaiCS.DataSource = liLoaiChinhSach1;
            cboLoaiCS.DisplayMember = "Name";
            cboLoaiCS.ValueMember = "Id";
        }

        private void LoadNhomDoiTuong()
        {
            List<DmLoaiDoiTuongInfor> liLoaiDT = DmLoaiDoiTuongDataProvider.GetListLoaiDoiTuongInfor();
            liLoaiDT.Insert(0, new DmLoaiDoiTuongInfor()
                                   {
                                       IdLoaiDT = 0,
                                       MaLoaiDT = "",
                                       TenLoaiDT="Tất cả",
                                       SuDung = 1
                                   });
            cboLoaiDoiTuong.DataSource = liLoaiDT;
            cboLoaiDoiTuong.DisplayMember = "TenLoaiDT";
            cboLoaiDoiTuong.ValueMember = "IdLoaiDT";
            cboLoaiDoiTuong.SelectedIndex = 0;
        }
        private void frm_TimKiem_BangGia_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
            //if (KieuTimKiem == 2)
            //{
            //    cboTrangThai.Enabled = false;
            //    cboTrangThai.SelectedIndex = 1;

            //    cboDuyet.Enabled = false;
            //    cboDuyet.SelectedIndex = 3;
            //}
            //else
            //{
                cboTrangThai.Enabled = true;
                cboTrangThai.SelectedIndex = 1;

                cboDuyet.Enabled = true;
                cboDuyet.SelectedIndex = 3;
            //}
            CommonFuns.Instance.LoadComboBoxPages(cboPage);
            chkCuaToi.Checked = true;
            //chkCuaToi.Enabled = KieuTimKiem != 0 ? false : true;
            //mstNgayHieuLuc.Enabled = false;
            //mstHanHieuLuc.Checked = false;
        }

        private void cmdTimKiem_Click(object sender, EventArgs e)
        {
            SoLuongHienTai = 0;
            SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
            liResult = new List<BangGiaChinhSachInfor>();

            TimKiemBangGia();
        }
        private void LoadDuLieu()
        {
            filter.SoBatDau = SoLuongHienTai;
            filter.SoKetThuc = SoLuongTimKiem != -1 ? SoLuongHienTai + SoLuongTimKiem : -1;           

            if (KieuTimKiem != 2)
            {
                liTimKiem = ChinhSachDataProvider.Instance.TimKiemChinhSachGiaPg(filter);
                liResult.AddRange(liTimKiem);
            }            

            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            frmProgress.Instance.IsCompleted = true;
            frmProgress.Instance.Description = "Đã xong";
        }
        private void TimKiemBangGia()
        {
            try
            {
                GetFilter();
                frmProgress.Instance.Description = Common.MsgProgress(SoLuongTimKiem);
                frmProgress.Instance.MaxValue = SoLuongTimKiem;
                frmProgress.Instance.Value = 0;
                frmProgress.Instance.DoWork(LoadDuLieu);

                //else//tim cac bang gia chua duyet
                //{
                //    List<BangGiaSearchInfor> libg = BangGiaDataProvider.Instance.TimKiemBangGiaChuaDuyet(filter);
                //    liResult = new List<BangGiaSearchInfor>();
                //    foreach (BangGiaSearchInfor bg in libg)
                //    {
                //        List<BangGiaChiTietInfor> liCT = BangGiaDataProvider.Instance.GetAllBGChiTietChuaDuyetInfors(bg.IdBangGia, nguoiDung.IdNhomNguoiDung);
                //        if (liCT != null && liCT.Count > 0)
                //            liResult.Add(bg);
                //    }
                //}
                
                //List<BangGiaChinhSachInfor> liChinhSach = ChinhSachDataProvider.Instance.LoadChinhSachByNSD(nguoiDung.TenDangNhap);
                gChinhSach.DataSource = new BindingList<BangGiaChinhSachInfor>(liResult); 
                gvChinhSach.ExpandAllGroups();
                selector.View = gvChinhSach;
                ((BindingList<BangGiaChinhSachInfor>)gChinhSach.DataSource).ResetBindings();
                SoLuongHienTai = liResult.Count;
                selector.ClearSelection();

                //selector.CheckMarkColumn.VisibleIndex = 0;

                this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + gvChinhSach.RowCount + " chính sách giá)";
                if (gvChinhSach.RowCount == 0)
                {
                    MessageBox.Show("Không có kết quả nào thỏa mãn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GetFilter()
        {
            if (filter == null)
                filter = new TimKiemBangGiaFilterInfor();
            filter.SoBangGia = txtSoBangGia.Text.Trim();
            filter.NguoiLap = txtNguoiLap.Text;
            filter.Draft = cboTrangThai.SelectedIndex - 1;
            filter.DaDuyet = cboDuyet.SelectedIndex - 2;
            filter.LoaiBangGia = cboLoaiCS.SelectedIndex - 1;
            filter.IdTrungTam = bteTrungTam.Tag != null ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam : 0;
            filter.IdLoaiDoiTuong = Common.IntValue(cboLoaiDoiTuong.SelectedValue);
            filter.NgayHieuLuc = Convert.ToDateTime(dteStart.EditValue);
            filter.HanHieuLuc = Convert.ToDateTime(dteEnd.EditValue);
            //filter.HieuLucVoHan = chkDaDuyet.Checked ? 0 : 1;
            filter.NguoiTao = chkCuaToi.Checked ? nguoiDung.TenDangNhap : "";
            filter.GhiChu = txtGhiChu.Text.Trim();
            filter.MatHang = txtMatHang.Text.Trim();
        }

        private void cmdThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void cmdSua_Click(object sender, EventArgs e)
        {
            EditOrder(gvChinhSach.FocusedRowHandle);
        }
        private void EditOrder(int rowHandle)
        {
            if (rowHandle < 0) return;
            ChinhSach = (BangGiaChinhSachInfor)gvChinhSach.GetRow(rowHandle);
            if (KieuTimKiem > 0 && ChinhSach != null)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.None;
                frmCS_List_ChinhSachKM_View frm = new frmCS_List_ChinhSachKM_View(ChinhSach, liResult, true, this);
                //frm.HideMenu();
                frm.Show();
            }
        }

        public void setRowFocus(int index)
        {
            if (index >= 0 && index < gvChinhSach.RowCount)
                gvChinhSach.FocusedRowHandle = index;
        }

        private void frm_TimKiem_BangGia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6 && cmdSua.Enabled)
                this.cmdSua_Click(sender, e);
            else if (e.KeyCode == Keys.F10 && cmdTimKiem.Enabled)
                this.cmdTimKiem_Click(sender, e);
            else if (e.KeyCode == Keys.F12 && cmdExport.Enabled)
                this.cmdExport_Click(sender, e);
            else if (e.KeyCode == Keys.Escape && cmdThoat.Enabled)
                this.cmdThoat_Click(sender, e);
        }


        private void gChinhSach_DoubleClick(object sender, EventArgs e)
        {
            Point pt = gChinhSach.PointToClient(MousePosition);
            GridHitInfo hitInfo = gvChinhSach.CalcHitInfo(pt);
            if (hitInfo.InRow)
                EditOrder(hitInfo.RowHandle);
        }

        private void gChinhSach_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter && gvChinhSach.RowCount > 0)
                {
                    EditOrder(gvChinhSach.FocusedRowHandle);
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void bteTrungTam_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteTrungTam);
        }

        private void bteTrungTam_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteTrungTam_KeyDown(sender, e, bteTrungTam, nguoiDung.IdNhanVien);
        }

        private void bteTrungTam_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteTrungTam_ButtonClick(sender, e, bteTrungTam, nguoiDung.IdNhanVien);
        }

        private void cmdExport_Click(object sender, EventArgs e)
        {
            //gChinhSach.ShowPrintPreview();
            //Common.DevExport2Excel(gvChinhSach);
            Common.Export2ExcelFromDevGrid<BangGiaChinhSachInfor>(gvChinhSach, "DanhSachChinhSachKM");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SoLuongTimKiem = Common.IntValue(cboPage.SelectedItem);
            if (SoLuongTimKiem == 0)
                SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
            if (cboPage.SelectedItem.Equals("Tất cả"))
            {
                if (MessageBox.Show(Declare.msgLoadDataWrn, "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SoLuongTimKiem = -1;
                }
                else
                {
                    return;
                }
            } 

            TimKiemBangGia();
        }
    }
}