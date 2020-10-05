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
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmXacNhanNhapHangTraLai : DevExpress.XtraEditors.XtraForm
    {
        private int IdTrungTam, IdKho, IdKhachHang;
        private List<NhapHangTraMuaInfor> liChungTu = new List<NhapHangTraMuaInfor>();
        private List<NhapHangTraMuaInfor> liTimKiem = new List<NhapHangTraMuaInfor>();
        public TimKiemChungTuFilterInfor filter = new TimKiemChungTuFilterInfor();
        protected NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
        private int SoLuongHienTai = 0;

        public frmXacNhanNhapHangTraLai()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }
        #region Actions
        private void LoadTrangThai()
        {
            List<TrangThaiBH> liDraft = Common.GetListTinhTrangDonHang();
            List<TrangThaiBH> liTrangThaiDH = Common.GetListTrangThaiDonHangTraLai();
            List<TrangThaiBH> liLoaiDH = Common.GetListLoaiDonHangTraLai();
            //load trang thai cho grid
            repDraft.DataSource = liDraft;
            repTrangThai.DataSource = liTrangThaiDH;
            repLoaiChungTu.DataSource = liLoaiDH;

            List<TrangThaiBH> liTrangThaiDH1 = new List<TrangThaiBH>();
            liTrangThaiDH1.Add(new TrangThaiBH { Id = -1, Name = "Tất cả" });
            //liTrangThaiDH1.AddRange(liTrangThaiDH);
            lueTrangthai.Properties.DataSource = liTrangThaiDH1;
            lueTrangthai.EditValue = -1;
        }

        private void LoadDuLieu()
        {
            filter.SoBatDau = SoLuongHienTai;
            filter.SoKetThuc = SoLuongTimKiem != -1 ? SoLuongHienTai + SoLuongTimKiem : -1;
            filter.UserName = Declare.UserName;

            liTimKiem = DNNhapTraHangMuaDataProvider.Instance.GetListAllChungTuNhapTraKTPg(filter);

            if(filter.SoKetThuc == -1) liChungTu.Clear();

            liChungTu.AddRange(liTimKiem);

            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            frmProgress.Instance.IsCompleted = true;
            frmProgress.Instance.Description = "Đã xong";
        }
        private void GetFilter()
        {
            if (filter == null)
                filter = new TimKiemChungTuFilterInfor();
            filter.TrangThai = Common.IntValue(lueTrangthai.EditValue);
            filter.SoPhieu = txtSoGiaoDich.Text.Trim();
            filter.IdTrungTam = txtTrungTam.Tag != null ? ((DMTrungTamInfor)txtTrungTam.Tag).IdTrungTam : -1;
            filter.IdKho = txtKhoNhap.Tag != null ? ((DMKhoInfo)txtKhoNhap.Tag).IdKho : -1;
            filter.TuNgay = Convert.ToDateTime(dteStart.EditValue);
            filter.DenNgay = Convert.ToDateTime(dteEnd.EditValue);
            filter.IdDoiTuong = txtKhachHang.Tag != null ? ((DMDoiTuongInfo)txtKhachHang.Tag).IdDoiTuong : -1;
            filter.UserName = "";//"chkCuaToi.Checked ? nguoiDung.TenDangNhap : "";
        }
        private void LoadDataSource()
        {
            try
            {
                GetFilter();
                frmProgress.Instance.Description = Common.MsgProgress(SoLuongTimKiem);
                frmProgress.Instance.MaxValue = SoLuongTimKiem;
                frmProgress.Instance.Value = 0;
                frmProgress.Instance.DoWork(LoadDuLieu);

                grcDanhSach.DataSource = new BindingList<NhapHangTraMuaInfor>(liChungTu);
                //gvListChungTu.Columns["ParentName"].GroupIndex = 0;
                grvDanhSach.ExpandAllGroups();
                //selector.View = grvDanhSach;
                //selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                //selector.CheckMarkColumn.VisibleIndex = 0;
                ((BindingList<NhapHangTraMuaInfor>)grcDanhSach.DataSource).ResetBindings();
                SoLuongHienTai = liChungTu.Count;
                //selector.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực hiện: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditValue(int rowhandle)
        {
            if (rowhandle < 0) return;
            NhapHangTraMuaInfor item = (NhapHangTraMuaInfor)grvDanhSach.GetRow(rowhandle);
            if (item.LoaiChungTu == (int)TransactionType.NHAPTRAHANGMUA)
            {
                frmChiTietXacNhapHangTraLai frm = new frmChiTietXacNhapHangTraLai(item);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadDataSource();
                }
            }                
            else 
            {
                if (nguoiDung.SupperUser == 1 || nguoiDung.SuaChungTu == 1)
                {
                    frmChiTietXacNhapLaiKhac frm = new frmChiTietXacNhapLaiKhac(item);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadDataSource();
                    }                                    
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền thực hiện xác nhận đơn hàng này");
                }
            }
        }
        #endregion

        #region Events
        private void frmDMDnTraHangMua_Load(object sender, EventArgs e)
        {
            LoadTrangThai();
            CommonFuns.Instance.LoadComboBoxPages(cboPage);
            btnTimkiem_Click(sender, e);
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

        private void frmXacNhanNhapHangTraLai_Activated(object sender, EventArgs e)
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