using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;
using QLBH.Common.Providers;
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBH_ListPhieuChi : DevExpress.XtraEditors.XtraForm
    {
        protected List<NhapHangTraMuaInfor> liChungTu = new List<NhapHangTraMuaInfor>();
        private List<NhapHangTraMuaInfor> liTimKiem = new List<NhapHangTraMuaInfor>();
        private int IdTrungTam, IdKho, IdKhachHang;
        protected NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
        private int SoLuongHienTai = 0;

        public frmBH_ListPhieuChi()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            Common.SetEDControl(false, false, tsslHuy, tsslHuyClr, tsslTuChoi, tsslTuChoiClr);
            tsslChuaDuyet.Text = "Còn nợ khách";
        }
        #region Actions
        private void LoadTrangThai()
        {
            List<TrangThaiBH> liDraft = Common.GetListTinhTrangDonHang();
            List<TrangThaiBH> liTrangThaiDH = Common.GetListTrangThaiBCTraLai();
            //load trang thai cho grid
            repDraft.DataSource = liDraft;
            repTrangThai.DataSource = liTrangThaiDH;

            List<TrangThaiBH> liTrangThaiDH1 = new List<TrangThaiBH>();
            liTrangThaiDH1.Add(new TrangThaiBH { Id = -1, Name = "Tất cả" });
            //liTrangThaiDH1.AddRange(liTrangThaiDH);
            lueTrangthai.Properties.DataSource = liTrangThaiDH1;
            lueTrangthai.EditValue = -1;
        }

        private void LoadDuLieu()
        {
            int soBatDau = SoLuongHienTai;
            int soKetThuc = SoLuongTimKiem != -1 ? SoLuongHienTai + SoLuongTimKiem : -1;

            DateTime startDate = Convert.ToDateTime(dteStart.EditValue);
            DateTime endDate = Convert.ToDateTime(dteEnd.EditValue);
            string user = nguoiDung.SupperUser == 1 ? "" : nguoiDung.TenDangNhap;
            string soPhieu = txtSoGiaoDich.Text.Trim();

            //IdTrungTam = txtTrungTam.Tag != null ? ((DMTrungTamInfor)txtTrungTam.Tag).IdTrungTam : 0;
            IdKho = txtKhoNhap.Tag != null ? ((DMKhoInfo)txtKhoNhap.Tag).IdKho : -1;
            IdKhachHang = txtKhachHang.Tag != null ? ((DMDoiTuongInfo)txtKhachHang.Tag).IdDoiTuong : -1;
            liTimKiem = DNNhapTraHangMuaDataProvider.Instance.GetListAllChungTuNhapTraChiTienPg(soPhieu, user, IdKho, IdKhachHang, startDate, endDate,
                        -1, Common.IntValue(lueTrangthai.EditValue), -1, "", "", soBatDau, soKetThuc);
            
            if(soKetThuc == -1) liChungTu.Clear();

            liChungTu.AddRange(liTimKiem);

            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            frmProgress.Instance.IsCompleted = true;
            frmProgress.Instance.Description = "Đã xong";
        }

        private void LoadDataSource()
        {
            try
            {
                frmProgress.Instance.Description = Common.MsgProgress(SoLuongTimKiem);
                frmProgress.Instance.MaxValue = SoLuongTimKiem;
                frmProgress.Instance.Value = 0;
                frmProgress.Instance.DoWork(LoadDuLieu);
                //LoadDuLieu();

                grcDanhSach.DataSource = null;
                grcDanhSach.DataSource = new BindingList<NhapHangTraMuaInfor>(liChungTu);
                grvDanhSach.ExpandAllGroups();
                ((BindingList<NhapHangTraMuaInfor>)grcDanhSach.DataSource).ResetBindings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditValue(int rowhandle)
        {
            if (rowhandle < 0) return;
            NhapHangTraMuaInfor item = (NhapHangTraMuaInfor)grvDanhSach.GetRow(rowhandle);
            frmBH_LapPhieuChi frm = new frmBH_LapPhieuChi(item);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                LoadDataSource();
            }
        }
        #endregion

        #region Events
        private void frmDMDnTraHangMua_Load(object sender, EventArgs e)
        {

            try
            {
                LoadTrangThai();
                CommonFuns.Instance.LoadComboBoxPages(cboPage);
                dteStart.EditValue = CommonProvider.Instance.GetSysDate();
                dteEnd.EditValue = dteStart.EditValue;
                btnTimkiem_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDMDnTraHangMua_KeyDown(object sender, KeyEventArgs e)
        {
            QLBH.Core.QLBHUtils.PerformShortCutKey(this, e.KeyCode);
            if(e.KeyCode==Keys.Escape)
                this.Close();
        }

        private void grvDanhSach_DoubleClick(object sender, EventArgs e)
        {
            EditValue(grvDanhSach.FocusedRowHandle);
        }

        private void txtTrungTam_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (UtilFunctions.bteTrungTam_ButtonClick(sender, e, txtTrungTam, nguoiDung.IdNhanVien))
                ResetTrungTam();
        }

        private void smiEdit_Click(object sender, EventArgs e)
        {
            EditValue(grvDanhSach.FocusedRowHandle);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            SoLuongHienTai = 0;
            SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
            liChungTu = new List<NhapHangTraMuaInfor>();

            LoadDataSource();
        }

        private void txtKhoNhap_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int idTrungTam = txtTrungTam.Tag != null ? ((DMTrungTamInfor)txtTrungTam.Tag).IdTrungTam : 0;
            UtilFunctions.bteKhoXuat_ButtonClick(sender, e, txtKhoNhap, idTrungTam, nguoiDung.IdNhanVien);
        }

        private void txtKhachHang_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteKhachHang_ButtonClick(sender, e, txtKhachHang, Declare.IdLoaiKhachHang);
        }

        private void ResetTrungTam()
        {
            txtKhoNhap.ResetText();
            txtKhoNhap.Tag = null;
        }
        private void txtTrungTam_KeyDown(object sender, KeyEventArgs e)
        {
            if (UtilFunctions.bteTrungTam_KeyDown(sender, e, txtTrungTam, nguoiDung.IdNhanVien))
                ResetTrungTam();
        }

        private void txtTrungTam_TextChanged(object sender, EventArgs e)
        {
            if (UtilFunctions.bteItem_TextChanged(sender, e, txtTrungTam))
                ResetTrungTam();
        }

        private void txtKhoNhap_KeyDown(object sender, KeyEventArgs e)
        {
            int idTrungTam = txtTrungTam.Tag != null ? ((DMTrungTamInfor)txtTrungTam.Tag).IdTrungTam : 0;
            UtilFunctions.bteKhoXuat_KeyDown(sender, e, txtKhoNhap, idTrungTam, nguoiDung.IdNhanVien);
        }

        private void txtKhoNhap_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, txtKhoNhap);
        }

        private void txtKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteKhachHang_KeyDown(sender, e, txtKhachHang, Declare.IdLoaiKhachHang);
        }

        private void txtKhachHang_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, txtKhachHang);
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void frmBH_ListPhieuChi_Activated(object sender, EventArgs e)
        {
            //LoadDataSource();
        }

        private void grvDanhSach_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)grvDanhSach.GetRow(e.RowHandle);
            if (ct != null)
            {
                if (e.Column.FieldName.Equals("TrangThai"))
                {
                    if (ct.TienConNo > 0)
                    {
                        e.Appearance.BackColor = tsslChuaDuyetClr.BackColor;
                        e.Appearance.ForeColor = tsslChuaDuyetClr.ForeColor;
                    }
                }
            }
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

            LoadDataSource();
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {

        }
    }
}