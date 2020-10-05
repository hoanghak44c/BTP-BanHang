using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using QLBanHang.Class;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.BanHang.Bussiness;
using QLBH.Core.Form;
using QLBH.Core.Providers;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmCS_ListChinhSachKM : DevExpress.XtraEditors.XtraForm
    {
        #region Declaration

        private List<BangGiaChinhSachInfor> liChinhSach = new List<BangGiaChinhSachInfor>();
        private List<BangGiaChinhSachInfor> liTimKiem = new List<BangGiaChinhSachInfor>();
        //private BangGiaChinhSachInfor chinhSach = new BangGiaChinhSachInfor();
        public TimKiemBangGiaFilterInfor filter = new TimKiemBangGiaFilterInfor();
        private objGridMarkSelection selector = new objGridMarkSelection();
        //private bool DuyetBangGia = false;

        protected NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
        private int SoLuongHienTai = 0;
        #endregion

        #region Constructor
        public frmCS_ListChinhSachKM()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }
        public frmCS_ListChinhSachKM(bool duyetBangGia)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            //this.DuyetBangGia = duyetBangGia;
            //Common.SetEDControl(!DuyetBangGia, !DuyetBangGia, tsbAdd, tsbDelete);
            //tsbEdit.Text = DuyetBangGia ? "&Duyệt (F6)" : "&Sửa (F6)";
        }
        #endregion

        #region Event

        private void frmBH_TimChungTu_Load(object sender, EventArgs e)
        {
            try
            {
                setEDFunctions(null);
                ShowInfors(null);
                LoadAllTrangThai();
                CommonFuns.Instance.LoadComboBoxPages(cboPage);
                btnTimkiem_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gListChungTu_KeyDown(object sender, KeyEventArgs e)
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

        private void gvListChungTu_DoubleClick(object sender, EventArgs e)
        {
            Point pt = gChinhSach.PointToClient(MousePosition);
            GridHitInfo hitInfo = gvChinhSach.CalcHitInfo(pt);
            if (hitInfo.InRow)
                EditOrder(hitInfo.RowHandle);
        }

        private void frmBH_TimChungTu_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //if (e.KeyCode==Keys.Enter)   
                //{
                //    if (!this.gListChungTu.Focused)
                //    {
                //        SendKeys.Send("{TAB}");
                //        e.Handled = true;
                //        return;
                //    }
                //}
                if (e.KeyCode == Keys.F5 && tsbAdd.Enabled)
                    this.tsbAdd_Click(sender, e);
                else if (e.KeyCode == Keys.F6 && tsbEdit.Enabled)
                    this.tsbEdit_Click(sender, e);
                else if (e.KeyCode == Keys.F8 && tsbDelete.Enabled)
                    this.tsbDelete_Click(sender, e);
                else if (e.KeyCode == Keys.F9 && btnStop.Enabled)
                    this.btnStop_Click(sender, e);
                //else if (e.KeyCode == Keys.F10 && tsbSearch.Enabled)
                //    this.tsbSearch_Click(sender, e);
                else if (e.KeyCode == Keys.F12 && tsbClose.Enabled)
                    this.tsbClose_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvListChungTu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvChinhSach.FocusedRowHandle < 0) return;
            BangGiaChinhSachInfor chinhSach = (BangGiaChinhSachInfor)gvChinhSach.GetRow(gvChinhSach.FocusedRowHandle);
            setEDFunctions(chinhSach);
            ShowInfors(chinhSach);
        }
 
        private void bteTrungTam_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteTrungTam_ButtonClick(sender, e, bteTrungTam, nguoiDung.IdNhanVien);
        }

        private void bteTrungTam_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteTrungTam_KeyDown(sender, e, bteTrungTam, nguoiDung.IdNhanVien);
        }

        private void bteTrungTam_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteTrungTam);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            SoLuongHienTai = 0;
            SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
            liChinhSach = new List<BangGiaChinhSachInfor>();

            LoadAllBangGia();
        }

        //private void tsbSearch_Click(object sender, EventArgs e)
        //{
        //    frmCS_TimKiem_BangGia frm = new frmCS_TimKiem_BangGia();
        //    frm.ShowDialog();
        //}

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            frmCS_LapChinhSachKM frm = new frmCS_LapChinhSachKM();
            frm.ShowDialog();
            btnTimkiem_Click(sender, e);
        }

        private void EditOrder(int rowHandle)
        {
            if (rowHandle < 0) return;
            BangGiaChinhSachInfor ct = (BangGiaChinhSachInfor)gvChinhSach.GetRow(rowHandle);

            frmCS_LapChinhSachKM frm = new frmCS_LapChinhSachKM(ct);
            frm.ShowDialog();                

            btnTimkiem_Click(null, null);
        }
        private void tsbEdit_Click(object sender, EventArgs e)
        {
            EditOrder(gvChinhSach.FocusedRowHandle);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selector.selection != null && selector.selection.Count == 0) return;
                if (MessageBox.Show("Bạn có chắc chắn xóa các chính sách này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (BangGiaChinhSachInfor cs in selector.selection)
                    {
                        if (cs != null && (cs.Draft == 1 || nguoiDung.SupperUser == 1))
                            ChinhSachDataProvider.Instance.DeleteBangGiaChinhSach(cs.IdChinhSach);
                    }
                }
                btnTimkiem_Click(sender, e);
            }
            catch (Exception ex)
            {
                EventLogProvider.Instance.WriteLog(ex.ToString()
                                    + "\nUser: " + nguoiDung.TenDangNhap
                                    + "\nMay: " + Declare.TenMay,
                                    this.Name);
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void chkChonDuyet_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChonDuyet.Checked == true)
            {
                selector.SelectAll();
            }
            else
            {
                selector.ClearSelection();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (DuyetBangGia)
            //{
            //    btnTimkiem_Click(sender, e);
            //}
        }
        #endregion

        #region Data

        private void LoadAllTrangThai()
        {
            List<TrangThaiBH> liLoaiChinhSach = Common.GetLoaiChinhSachGia();
            repLoaiCS.DataSource = liLoaiChinhSach;            

            List<TrangThaiBH> liLoaiKhachHang = Common.GetListLoaiKhachHang();
            repDoiTuongAD.DataSource = liLoaiKhachHang;

            cboTrangThai.Enabled = true;
            cboTrangThai.SelectedIndex = 1;

            cboDuyet.Enabled = true;
            cboDuyet.SelectedIndex = 3;

            List<TrangThaiBH> liLoaiChinhSach1 = new List<TrangThaiBH>();
            liLoaiChinhSach1.Add(new TrangThaiBH() {Id = -1, Name = "Tất cả"});
            liLoaiChinhSach1.AddRange(liLoaiChinhSach);
            cboLoaiCS.DataSource = liLoaiChinhSach1;
            cboLoaiCS.DisplayMember = "Name";
            cboLoaiCS.ValueMember = "Id";
        }

        private void LoadDuLieu()
        {
            filter.SoBatDau = SoLuongHienTai;
            filter.SoKetThuc = SoLuongTimKiem != -1 ? SoLuongHienTai + SoLuongTimKiem : -1;           

            liTimKiem = ChinhSachDataProvider.Instance.TimKiemChinhSachGiaPg(filter);
            liChinhSach.AddRange(liTimKiem);

            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            frmProgress.Instance.IsCompleted = true;
            frmProgress.Instance.Description = "Đã xong";
        }

        private void GetFilter()
        {
            if (filter == null)
                filter = new TimKiemBangGiaFilterInfor();

            filter.SoBangGia = txtSoBangGia.Text.Trim();
            filter.Draft = cboTrangThai.SelectedIndex - 1;
            filter.DaDuyet = cboDuyet.SelectedIndex - 2;
            filter.LoaiBangGia = cboLoaiCS.SelectedIndex - 1;
            filter.IdTrungTam = bteTrungTam.Tag != null ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam : 0;
            filter.NgayHieuLuc = Convert.ToDateTime(dteStart.EditValue);
            filter.HanHieuLuc = Convert.ToDateTime(dteEnd.EditValue);
            filter.NguoiTao = nguoiDung.SupperUser == 1 ? "" : nguoiDung.TenDangNhap;
            filter.MatHang = txtMatHang.Text.Trim();
        }

        private void LoadAllBangGia()
        {
            try
            {
                GetFilter();
                frmProgress.Instance.Description = Common.MsgProgress(SoLuongTimKiem);
                frmProgress.Instance.MaxValue = SoLuongTimKiem;
                frmProgress.Instance.Value = 0;
                frmProgress.Instance.DoWork(LoadDuLieu);

                gChinhSach.DataSource = null;
                gChinhSach.DataSource = new BindingList<BangGiaChinhSachInfor>(liChinhSach);
                gvChinhSach.ExpandAllGroups();

                selector.View = gvChinhSach;
                selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                selector.CheckMarkColumn.VisibleIndex = 0;
                selector.ClearSelection();

                chkChonDuyet.Checked = false;
                ((BindingList<BangGiaChinhSachInfor>)gChinhSach.DataSource).ResetBindings();

                grpKetQuaTimKiem.Text = "Tổng số (" + liChinhSach.Count + " chính sách khuyến mại)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected void setEDFunctions(BangGiaChinhSachInfor chinhSach)
        {
            btnDefault.Enabled = (chinhSach != null) && (chinhSach.IdChinhSach > 0) && (chinhSach.MacDinh == 0) &&
                                 (nguoiDung.TenDangNhap.Equals(chinhSach.NguoiTao) || nguoiDung.SupperUser == 1) && ConnectionUtil.Instance.IsUAT != 1;
            btnStop.Enabled = (chinhSach != null) && (chinhSach.IdChinhSach > 0) && chinhSach.Draft == 0 &&
                              (chinhSach.DaDuyet == 1 || chinhSach.DaDuyet == -1) && (nguoiDung.TenDangNhap.Equals(chinhSach.NguoiTao) || nguoiDung.SupperUser == 1);
            btnStop.Text = (chinhSach != null && chinhSach.DaDuyet == -1) ? "Kích hoạt(F11)" : "Tạm &dừng (F11)";
            tsbEdit.Enabled = chinhSach != null && (nguoiDung.TenDangNhap.Equals(chinhSach.NguoiTao) &&
                                chinhSach.Draft == 1 || nguoiDung.SupperUser == 1);
            tsbDelete.Enabled = chinhSach != null && (nguoiDung.TenDangNhap.Equals(chinhSach.NguoiTao) && 
                                chinhSach.Draft == 1 || nguoiDung.SupperUser == 1);
        }

        private void ShowInfors(BangGiaChinhSachInfor chinhSach)
        {
            if (chinhSach != null)
            {
                tsslTrangThai.Text = chinhSach.DaDuyetTT;
                tsslDraft.Text = Common.Int2Bool(chinhSach.Draft) ? "Bản nháp {chưa xác nhận}" : "";                
            }
        }
        #endregion

        private void frmCS_ListBangGia_Activated(object sender, EventArgs e)
        {
            //LoadAllBangGia();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SoLuongHienTai = liChinhSach.Count;
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

            LoadAllBangGia();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            BangGiaChinhSachInfor chinhSach = (BangGiaChinhSachInfor)gvChinhSach.GetRow(gvChinhSach.FocusedRowHandle);
            try
            {
                if (chinhSach != null && MessageBox.Show("Bạn có chắc chắn muốn dừng chính sách giá này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string msg = "";
                    if (chinhSach.DaDuyet == 1)
                    {
                        chinhSach.DaDuyet = -1;
                        msg = "Tạm dừng chính sách giá thành công!";
                    }
                    else if (chinhSach.DaDuyet == -1)
                    {
                        chinhSach.DaDuyet = 1;
                        msg = "Kích hoạt chính sách giá thành công!";
                    }

                    chinhSach.NguoiDuyet = nguoiDung.TenDangNhap;

                    ChinhSachDataProvider.Instance.DuyetBangGiaChinhSach(chinhSach);
                    ((BindingList<BangGiaChinhSachInfor>)gChinhSach.DataSource).ResetBindings();
                    MessageBox.Show(msg);
                }
            }
            catch (Exception ex)
            {
                EventLogProvider.Instance.WriteLog(ex.ToString()
                                    + "\nUser: " + nguoiDung.TenDangNhap
                                    + "\nMay: " + Declare.TenMay,
                                    this.Name);
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            BangGiaChinhSachInfor chinhSach = (BangGiaChinhSachInfor)gvChinhSach.GetRow(gvChinhSach.FocusedRowHandle);
            try
            {
                if (chinhSach != null && MessageBox.Show("Bạn có chắc chắn muốn thiết lập mặc định cho chính sách này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    chinhSach.MacDinh = 1;
                    ChinhSachDataProvider.Instance.ThietLapMacDinhChinhSach(chinhSach);
                    ((BindingList<BangGiaChinhSachInfor>)gChinhSach.DataSource).ResetBindings();
                    MessageBox.Show("Đã thiết lập chính sách khuyến mại mặc định thành công!");
                }
            }
            catch (Exception ex)
            {
                EventLogProvider.Instance.WriteLog(ex.ToString()
                                    + "\nUser: " + nguoiDung.TenDangNhap
                                    + "\nMay: " + Declare.TenMay,
                                    this.Name);
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }
    }
}