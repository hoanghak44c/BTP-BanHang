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

namespace QLBanHang.Modules.BanHang
{
    public partial class frmCS_ListBangGia : DevExpress.XtraEditors.XtraForm
    {
        #region Declaration

        private List<BangGiaInfor> liBangGia = new List<BangGiaInfor>();
        private List<BangGiaInfor> liTimKiem = new List<BangGiaInfor>();
        private BangGiaInfor bangGia = new BangGiaInfor();
        private objGridMarkSelection selector = new objGridMarkSelection();
        private bool DuyetBangGia = false;

        protected NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
        private int SoLuongHienTai = 0;
        #endregion

        #region Constructor
        public frmCS_ListBangGia()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }
        public frmCS_ListBangGia(bool duyetBangGia)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.DuyetBangGia = duyetBangGia;
            Common.SetEDControl(!DuyetBangGia, !DuyetBangGia, tsbAdd, tsbDelete);
            tsbEdit.Text = DuyetBangGia ? "&Duyệt (F6)" : "&Sửa (F6)";
            chkCuaToi.Visible = !DuyetBangGia;
        }
        #endregion

        #region Event

        private void frmBH_TimChungTu_Load(object sender, EventArgs e)
        {
            try
            {
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

        private void gvListChungTu_DoubleClick(object sender, EventArgs e)
        {
            Point pt = gListBangGia.PointToClient(MousePosition);
            GridHitInfo hitInfo = gvListBangGia.CalcHitInfo(pt);
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
                else if (e.KeyCode == Keys.F9 && tsbPrint.Enabled)
                    this.tsbPrint_Click(sender, e);
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
            if (gvListBangGia.FocusedRowHandle < 0) return;
            bangGia = (BangGiaInfor)gvListBangGia.GetRow(gvListBangGia.FocusedRowHandle);
            if (bangGia != null)
            {
                setEDFunctions();
                ShowInfors();
            }
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
            liBangGia = new List<BangGiaInfor>();

            LoadAllBangGia();
        }

        //private void tsbSearch_Click(object sender, EventArgs e)
        //{
        //    frmCS_TimKiem_BangGia frm = new frmCS_TimKiem_BangGia();
        //    frm.ShowDialog();
        //}

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            if (!DuyetBangGia)
            {
                frmCS_LapBangGia frm = new frmCS_LapBangGia();
                frm.ShowDialog();
                btnTimkiem_Click(sender, e);
            }
        }

        private void EditOrder(int rowHandle)
        {
            if (rowHandle < 0) return;
            BangGiaInfor ct = (BangGiaInfor)gvListBangGia.GetRow(rowHandle);
            if (DuyetBangGia)
            {
                frmCS_DuyetBangGia frm = new frmCS_DuyetBangGia(ct);
                frm.ShowDialog();
            }
            else
            {
                frmCS_LapBangGia frm = new frmCS_LapBangGia(ct);
                frm.ShowDialog();                
            }
            btnTimkiem_Click(null, null);
        }
        private void tsbEdit_Click(object sender, EventArgs e)
        {
            EditOrder(gvListBangGia.FocusedRowHandle);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (selector.selection != null && selector.selection.Count == 0) return;
            if (MessageBox.Show("Bạn có chắc chắn xóa các bảng giá này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (BangGiaInfor bg in selector.selection)
                {
                    if (bg != null && (bg.DaDuyet == 0 || bg.DaDuyet == 2 || nguoiDung.SupperUser == 1))
                        BangGiaDataProvider.Instance.DeleteBangGia(bg.IdBangGia);
                }
            }
            btnTimkiem_Click(sender, e);
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
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
            List<TrangThaiBH> liDraft = Common.GetListTinhTrangDonHang();
            List<TrangThaiBH> liDuyet = Common.GetListTinhTrangDuyet();
            //load trang thai cho grid
            repDraft.DataSource = liDraft;
            repTrangThai.DataSource = liDuyet;

            //load trang thai draft
            List<TrangThaiBH> liDraft1 = new List<TrangThaiBH>();
            liDraft1.Add(new TrangThaiBH { Id = -1, Name = "Tất cả" });
            liDraft1.AddRange(liDraft);
            lueDraft.Properties.DataSource = liDraft1;
            lueDraft.EditValue = DuyetBangGia ? 0 : -1;
            lueDraft.Enabled = !DuyetBangGia;

            List<TrangThaiBH> liDuyet1 = new List<TrangThaiBH>();
            liDuyet1.Add(new TrangThaiBH { Id = -1, Name = "Tất cả" });
            liDuyet1.AddRange(liDuyet);
            lueDuyet.Properties.DataSource = liDuyet1;
            lueDuyet.EditValue = -1;
        }

        private void LoadDuLieu()
        {
            int soBatDau = SoLuongHienTai;
            int soKetThuc = SoLuongTimKiem != -1 ? SoLuongHienTai + SoLuongTimKiem : -1;

            if (DuyetBangGia)
            {
                liTimKiem = BangGiaDataProvider.Instance.LoadAllBGChuaDuyetByNNDPg(nguoiDung.IdNhomNguoiDung, soBatDau, soKetThuc);

                if (liBangGia.Count > 0)
                    tslInfor.Text = "Danh sách bảng giá cần duyệt";
                else
                    tslInfor.Text = "";
            }
            else
            {
                tslInfor.Text = "Danh sách bảng giá";
                int idTrungTam = bteTrungTam.Tag != null ? ((DMTrungTamInfor) bteTrungTam.Tag).IdTrungTam : -1;
                DateTime tuNgay = Common.DateValue(dteStart.EditValue);
                DateTime denNgay = Common.DateValue(dteEnd.EditValue);
                int duyet = Common.IntValue(lueDuyet.EditValue);
                int draft = Common.IntValue(lueDraft.EditValue);
                string soBangGia = txtSoBangGia.Text.Trim();
                string nguoiTao = chkCuaToi.Checked ? nguoiDung.TenDangNhap : "";
                liTimKiem = BangGiaDataProvider.Instance.SearchBGiaByNSDPg(nguoiTao, idTrungTam, soBangGia, draft, duyet,
                                                                         tuNgay, denNgay, soBatDau, soKetThuc);
            }
            liBangGia.AddRange(liTimKiem);

            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            frmProgress.Instance.IsCompleted = true;
            frmProgress.Instance.Description = "Đã xong";
        }
        private void LoadAllBangGia()
        {
            try
            {
                //if (SoLuongHienTai < liBangGia.Count) return;
                frmProgress.Instance.Description = Common.MsgProgress(SoLuongTimKiem);
                frmProgress.Instance.MaxValue = SoLuongTimKiem;
                frmProgress.Instance.Value = 0;
                frmProgress.Instance.DoWork(LoadDuLieu);
                //LoadDuLieu();

                gListBangGia.DataSource = null;
                gListBangGia.DataSource = new BindingList<BangGiaInfor>(liBangGia);
                gvListBangGia.ExpandAllGroups();

                selector.View = gvListBangGia;
                selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                selector.CheckMarkColumn.VisibleIndex = 0;
                selector.ClearSelection();

                chkChonDuyet.Checked = false;
                ((BindingList<BangGiaInfor>)gListBangGia.DataSource).ResetBindings();

                grpKetQuaTimKiem.Text = "Tổng số (" + liBangGia.Count + " bảng giá)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected void setEDFunctions()
        {
            tsbEdit.Enabled = bangGia != null && (bangGia.Draft == 1 || nguoiDung.SupperUser == 1) && !DuyetBangGia;
            tsbDelete.Enabled = bangGia != null && (bangGia.Draft == 1 || nguoiDung.SupperUser == 1) && !DuyetBangGia;
        }

        private void ShowInfors()
        {
            if (bangGia == null)
            {
                tsslTrangThai.Text = "";
                tsslDraft.Text = "";
            }
            else
            {
                tsslTrangThai.Text = Common.Int2Bool(bangGia.Draft) ? "Đã duyệt" : "Chưa duyệt";
                tsslDraft.Text = Common.Int2Bool(bangGia.Draft) ? "Bản nháp {chưa xác nhận}" : "";
            }
        }
        #endregion

        private void frmCS_ListBangGia_Activated(object sender, EventArgs e)
        {
            //LoadAllBangGia();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SoLuongHienTai = liBangGia.Count;
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

        private void gvListBangGia_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            BangGiaInfor bg = (BangGiaInfor)gvListBangGia.GetRow(e.RowHandle);
            if (bg != null)
            {
                if (e.Column.FieldName.Equals("DaDuyet"))
                {
                    if (bg.DaDuyet == (int)TinhTrangDuyetGia.DA_DUYET)
                    {
                        e.Appearance.BackColor = tsslDaPhanCong.BackColor;
                        e.Appearance.ForeColor = tsslDaPhanCong.ForeColor;
                    }
                    else if (bg.DaDuyet == (int)TinhTrangDuyetGia.TU_CHOI)
                    {
                        e.Appearance.BackColor = tsslHuyClr.BackColor;
                        e.Appearance.ForeColor = tsslHuyClr.ForeColor;
                    }
                }
            }
        }
    }
}