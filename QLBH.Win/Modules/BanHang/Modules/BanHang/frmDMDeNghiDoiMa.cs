using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBanHang.Modules.BanHang.Bussiness;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;
using QLBH.Core.Data;
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmDMDeNghiDoiMa : DevExpress.XtraEditors.XtraForm
    {
        private int IdTrungTam, IdKho, IdKhachHang;
        private List<BHangDoiMaInfor> liChungTu = new List<BHangDoiMaInfor>();
        private List<BHangDoiMaInfor> liTimKiem = new List<BHangDoiMaInfor>();
        protected NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
        private int SoLuongHienTai = 0;

        public frmDMDeNghiDoiMa()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        #region Actions
        private void LoadTrangThai()
        {
            List<TrangThaiBH> liDraft = Common.GetListTinhTrangDonHang();
            List<TrangThaiBH> liTrangThaiDH = Common.GetListTrangThaiDonHangDoiMaVach();
            //load trang thai cho grid
            repDraft.DataSource = liDraft;
            repTrangThai.DataSource = liTrangThaiDH;

            List<TrangThaiBH> liTrangThaiDH1 = new List<TrangThaiBH>();
            liTrangThaiDH1.Add(new TrangThaiBH { Id = -1, Name = "Tất cả" });
            liTrangThaiDH1.AddRange(liTrangThaiDH);
            lueTrangthai.Properties.DataSource = liTrangThaiDH1;
            lueTrangthai.EditValue = -1;
        }

        private void LoadDuLieu()
        {
            int soBatDau = SoLuongHienTai;
            int soKetThuc = SoLuongTimKiem != -1 ? SoLuongHienTai + SoLuongTimKiem : -1;

            DateTime startDate = Convert.ToDateTime(dteStart.EditValue);
            DateTime endDate = Convert.ToDateTime(dteEnd.EditValue);
            string soPhieu = txtSoGiaoDich.Text.Trim();
            int trangThai = Common.IntValue(lueTrangthai.EditValue);
            string userName = "";

            IdTrungTam = CommonFuns.Instance.GetIdTrungTam(txtTrungTam, nguoiDung); 
            IdKho = txtKhoNhap.Tag != null ? ((DMKhoInfo)txtKhoNhap.Tag).IdKho : -1;
            IdKhachHang = txtKhachHang.Tag != null ? ((DMDoiTuongInfo)txtKhachHang.Tag).IdDoiTuong : -1;
            liTimKiem = BHangDoiMaDataProvider.Instance.GetListAllDoiMaPg(IdTrungTam, IdKho, IdKhachHang, startDate, endDate,
                                        soPhieu, trangThai, userName, soBatDau, soKetThuc);

            liChungTu.AddRange(liTimKiem);

            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            frmProgress.Instance.IsCompleted = true;
            frmProgress.Instance.Description = "Đã xong";
        }
        private void LoadDataSource()
        {
            frmProgress.Instance.Description = Common.MsgProgress(SoLuongTimKiem);
            frmProgress.Instance.MaxValue = SoLuongTimKiem;
            frmProgress.Instance.Value = 0;
            frmProgress.Instance.DoWork(LoadDuLieu);

            grcDanhSach.DataSource = new BindingList<BHangDoiMaInfor>(liChungTu);
            grvDanhSach.ExpandAllGroups();
            ((BindingList<BHangDoiMaInfor>)grcDanhSach.DataSource).ResetBindings();
            SoLuongHienTai = liChungTu.Count;
        }

        private void EditValue(int rowhandle)
        {
            if (rowhandle < 0) return;
            BHangDoiMaInfor item = (BHangDoiMaInfor)grvDanhSach.GetRow(rowhandle);
            frmChiTietDeNghiDoiMa frm = new frmChiTietDeNghiDoiMa(item);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                LoadDataSource();
            }
        }

        private void AddNew()
        {
            frmChiTietDeNghiDoiMa frm = new frmChiTietDeNghiDoiMa();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                LoadDataSource();
            }
        }

        private void Delete(int rowhandle)
        {
            if(rowhandle<0) return;
            if (clsUtils.MsgXoa("Bạn có muốn xóa dữ liệu này không?") == System.Windows.Forms.DialogResult.Yes)
            {
                BHangDoiMaInfor item = (BHangDoiMaInfor) grvDanhSach.GetRow(rowhandle);
                if(item.Draft == 0)
                    throw new InvalidOperationException("Đề nghị đã được xác nhận, không thể xóa!");
                ChungTuBanHangInfor odel = new ChungTuBanHangInfor();
                odel.IdChungTu = item.IdChungTu;

                DoiMaBussiness bussiness = new DoiMaBussiness(odel);
                bussiness.DeleteChungTu();
                clsUtils.MsgThongBao(Declare.msgDeleteSucc);
                LoadDataSource();
            }
        }
        #endregion

        #region Events
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

        private void smiAdd_Click(object sender, EventArgs e)
        {
            AddNew();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            SoLuongHienTai = 0;
            SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
            liChungTu = new List<BHangDoiMaInfor>();

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

        private void frmDMDeNghiDoiMa_Load(object sender, EventArgs e)
        {
            CommonFuns.Instance.LoadTrungTam(txtTrungTam, nguoiDung);
            CommonFuns.Instance.LoadComboBoxPages(cboPage);
            LoadTrangThai();
            btnTimkiem_Click(sender, e);
            //LoadDataSource();
        }

        private void frmDMDeNghiDoiMa_KeyDown(object sender, KeyEventArgs e)
        {
            QLBH.Core.QLBHUtils.PerformShortCutKey(this, e.KeyCode);
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void msiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void smiDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionUtil.Instance.BeginTransaction();
                Delete(grvDanhSach.FocusedRowHandle);
                ConnectionUtil.Instance.CommitTransaction();
            }
            catch(Exception ex)
            {
                ConnectionUtil.Instance.RollbackTransaction();
                clsUtils.MsgCanhBao(ex.ToString());
            }
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

        private void frmDMDeNghiDoiMa_Activated(object sender, EventArgs e)
        {
            //LoadDataSource();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            //btnTimkiem_Click(sender, e);
        }

    }
}