using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;
using QLBH.Core.Data;
using QLBH.Core.Form;

//using QLBanHang.Class;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmCS_TimKiem_BangGia : DevExpress.XtraEditors.XtraForm
    {
        List<BangGiaSearchInfor> liResult = new List<BangGiaSearchInfor>();
        private List<BangGiaSearchInfor> liTimKiem = new List<BangGiaSearchInfor>();
        public TimKiemBangGiaFilterInfor filter = new TimKiemBangGiaFilterInfor();
        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        public BangGiaInfor BangGia = null;
        private int SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
        private int SoLuongHienTai = 0;
        private int KieuTimKiem = 0;//0: gọi từ menu, 1: gọi từ form bảng giá, 2: gọi từ form duyệt bảng giá
        public frmCS_TimKiem_BangGia()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }
        public frmCS_TimKiem_BangGia(int callByBG)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            KieuTimKiem = callByBG;
        }
        private void frm_TimKiem_BangGia_Load(object sender, EventArgs e)
        {
            if (KieuTimKiem == 2)
            {
                cboTrangThai.Enabled = false;
                cboTrangThai.SelectedIndex = 1;

                cboDuyet.Enabled = false;
                cboDuyet.SelectedIndex = 1;
                //TimKiemBangGia();
                chkCuaToi.Checked = false;
                chkCuaToi.Enabled = false;
            }
            else
            {
                cboTrangThai.Enabled = true;
                cboTrangThai.SelectedIndex = 0;

                cboDuyet.Enabled = true;
                cboDuyet.SelectedIndex = 0;
                chkCuaToi.Checked = true;
                chkCuaToi.Enabled = true;
            }
            chkDaDuyet.Checked = false;
            mstNgayHieuLuc.Enabled = false;
            mstHanHieuLuc.Enabled = false;
            CommonFuns.Instance.LoadComboBoxPages(cboPage);
        }

        private void cmdTimKiem_Click(object sender, EventArgs e)
        {
            SoLuongHienTai = 0;
            SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
            liResult = new List<BangGiaSearchInfor>();

            TimKiemBangGia();
        }
        private void LoadDuLieu()
        {
            filter.SoBatDau = SoLuongHienTai;
            filter.SoKetThuc = SoLuongTimKiem != -1 ? SoLuongHienTai + SoLuongTimKiem : -1;           

            if (KieuTimKiem != 2)
            {
                liTimKiem = BangGiaDataProvider.Instance.TimKiemBangGiaPg(filter);
            }
            else//tim cac bang gia chua duyet
            {
                liTimKiem = BangGiaDataProvider.Instance.TimKiemBangGiaChuaDuyetPg(filter);
            }
            liResult.AddRange(liTimKiem);

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

                gListBangGia.DataSource = new BindingList<BangGiaSearchInfor>(liResult); 
                //gvListChungTu.Columns["ParentName"].GroupIndex = 0;
                gvListBangGia.ExpandAllGroups();
                selector.View = gvListBangGia;
                ((BindingList<BangGiaSearchInfor>)gListBangGia.DataSource).ResetBindings();
                SoLuongHienTai = liResult.Count;
                selector.ClearSelection();
                //selector.CheckMarkColumn.VisibleIndex = 0;

                this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + gvListBangGia.RowCount + " bảng giá)";
                if (gvListBangGia.RowCount == 0)
                {
                    MessageBox.Show("Không có bảng giá nào thỏa mãn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            filter.DaDuyet = cboDuyet.SelectedIndex - 1;
            filter.IdTrungTam = bteTrungTam.Tag != null ? ((DMTrungTamInfor) bteTrungTam.Tag).IdTrungTam : 0;
            filter.NgayHieuLuc = mstNgayHieuLuc.Value;
            filter.HanHieuLuc = mstHanHieuLuc.Value;
            filter.HieuLucVoHan = chkDaDuyet.Checked ? 0 : 1;
            //filter.NguoiTao = (KieuTimKiem == 2 || Common.Int2Bool(nguoiDung.SupperUser)) ? "" : nguoiDung.TenDangNhap;
            filter.NguoiTao = chkCuaToi.Checked ? nguoiDung.TenDangNhap : "";
            filter.GhiChu = txtGhiChu.Text.Trim();
            filter.MatHang = txtMatHang.Text.Trim();
            filter.IdNhomDuyet = nguoiDung.IdNhomNguoiDung;
        }

        private void cmdThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            EditOrder(gvListBangGia.FocusedRowHandle);
        }
        private void EditOrder(int rowHandle)
        {
            if (rowHandle < 0) return;
            BangGiaSearchInfor bgs = (BangGiaSearchInfor)gvListBangGia.GetRow(rowHandle);
            BangGia = new BangGiaInfor(bgs);
            if (KieuTimKiem>0 && BangGia != null)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.None;
                frmCS_LapBangGia frm = new frmCS_LapBangGia(BangGia);
                frm.HideMenu();
                frm.ShowDialog();
            }
            //ChungTuBanHangInfor ctbh = BangGiaDataProvider.Instance.LoadBangGiaBan(ChungTuById(ct.IdChungTu));
        }

        private void frm_TimKiem_BangGia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6 && cmdSua.Enabled)
                this.cmdSua_Click(sender, e);
            else if (e.KeyCode == Keys.F10 && cmdTimKiem.Enabled)
                this.cmdTimKiem_Click(sender, e);
            else if (e.KeyCode == Keys.F12 && cmdThoat.Enabled)
                this.cmdThoat_Click(sender, e);
        }


        private void gListBangGia_DoubleClick(object sender, EventArgs e)
        {
            Point pt = gListBangGia.PointToClient(MousePosition);
            GridHitInfo hitInfo = gvListBangGia.CalcHitInfo(pt);
            if (hitInfo.InRow)
                EditOrder(hitInfo.RowHandle);

        }

        private void gListBangGia_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter && gvListBangGia.RowCount > 0)
                {
                    EditOrder(gvListBangGia.FocusedRowHandle);
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void chkDaDuyet_CheckedChanged(object sender, EventArgs e)
        {
            mstNgayHieuLuc.Enabled = chkDaDuyet.Checked;
            mstHanHieuLuc.Enabled = chkDaDuyet.Checked;
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
            //Common.DevExport2Excel(gvListBangGia);
            Common.Export2ExcelFromDevGrid<BangGiaSearchInfor>(gvListBangGia, "DanhSachBangGia");
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