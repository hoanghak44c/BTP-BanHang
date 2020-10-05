using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using QLBanHang.Class;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QLBanHang.Modules.BanHang.Reports;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.KhoHang.Infors;
using QLBanHang.Modules.KhoHang.Providers;
using QLBH.Common;
using QLBH.Common.Providers;
using QLBH.Core.Data;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.BanHang.Bussiness;
using QLBH.Core.Form;
using QLBH.Core.Providers;
using DmSanPhamProvider = QLBanHang.Modules.DanhMuc.Providers.DmSanPhamProvider;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBH_BangGiaBanHang_LichSu : DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"
        List<BangGiaChiTietLichSuInfor> liSanPham = new List<BangGiaChiTietLichSuInfor>();
        private List<BangGiaChiTietLichSuInfor> liTimKiem = new List<BangGiaChiTietLichSuInfor>();

        private int _IdTrungTam = 0;
        private int _IdSanPham = 0;
        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
        private int SoLuongHienTai = 0;

#endregion

#region "Các phương thức khởi tạo"
        public frmBH_BangGiaBanHang_LichSu()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this._IdTrungTam = 0;
            this._IdSanPham = 0;

        }
        public frmBH_BangGiaBanHang_LichSu(int idTrungTam, int idSanPham)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this._IdTrungTam = idTrungTam;
            this._IdSanPham = idSanPham;
        }
#endregion

#region "Các sự kiên"
        private void frmBH_TimChungTu_Load(object sender, EventArgs e)
        {
            try
            {
                bool view = true;
                LoadNganhHang();
                CommonFuns.Instance.LoadComboBoxPages(cboPage);
                if (_IdTrungTam == 0)
                {
                    _IdTrungTam = Declare.IdTrungTam;
                    view = false;
                }

                DMTrungTamInfor tt = DMTrungTamDataProvider.GetTrungTamByIdInfo(_IdTrungTam);
                if (tt != null)
                {
                    bteTrungTam.Text = tt.TenTrungTam;
                    bteTrungTam.Tag = tt;
                    bteTrungTam.Enabled = !view;
                }

                DMSanPhamInfo sp = DmSanPhamProvider.GetSanPhamById(_IdSanPham);
                if (sp != null)
                {
                    bteSanPham.Text = sp.TenSanPham;
                    bteSanPham.Tag = sp;
                    bteSanPham.Enabled = !view;
                }
                btnDeleteLS.Enabled = nguoiDung.SupperUser == 1 ? true : false;
                btnDeleteAllLS.Enabled = nguoiDung.SupperUser == 1 ? true : false;

                if (_IdSanPham > 0)
                    btnTim_Click(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadNganhHang()
        {
            //int idNND = Common.Int2Bool(nguoiDung.SupperUser) ? -1 : nguoiDung.IdNhomNguoiDung;
            List<TimKiemItemInfor> liNganh = TimKiemItemDataProvider.Instance.GetAllItemsByType(-1, 1, -1, -1);//type=1: nganh hang
            liNganh.Insert(0, new TimKiemItemInfor()
            {
                Id = 0,
                Ma = "",
                Ten = "Tất cả"
            });
            lueNganhHang.Properties.DataSource = liNganh;
            lueNganhHang.Properties.DisplayMember = "Ten";
            lueNganhHang.Properties.ValueMember = "Ma";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            SoLuongHienTai = 0;
            SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
            liSanPham = new List<BangGiaChiTietLichSuInfor>();

            TimKiemBangGia();
        }

        private void LoadDuLieu()
        {
            int soBatDau = SoLuongHienTai;
            int soKetThuc = SoLuongTimKiem != -1 ? SoLuongHienTai + SoLuongTimKiem : -1;

            int idTrungTam = bteTrungTam.Tag != null
                                 ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam
                                 : Declare.IdTrungTam;
            string maSanPham = bteSanPham.Text;//.Tag != null ? ((DMSanPhamInfo)bteSanPham.Tag).IdSanPham : 0;
            DateTime tuNgay = Convert.ToDateTime(dteStart.EditValue);
            DateTime denNgay = Convert.ToDateTime(dteEnd.EditValue);

            liTimKiem = BangGiaDataProvider.Instance.GetAllLichSuThayDoiGiaBanPg(idTrungTam,
                                                                                 lueNganhHang.EditValue.ToString(),
                                                                                 maSanPham, tuNgay, denNgay, soBatDau,
                                                                                 soKetThuc);

            liSanPham.AddRange(liTimKiem);

            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            frmProgress.Instance.IsCompleted = true;
            frmProgress.Instance.Description = "Đã xong";
        }

        private void TimKiemBangGia()
        {
            try
            {
                frmProgress.Instance.Description = Common.MsgProgress(SoLuongTimKiem);
                frmProgress.Instance.MaxValue = SoLuongTimKiem;
                frmProgress.Instance.Value = 0;
                frmProgress.Instance.DoWork(LoadDuLieu);

                gListSanPham.DataSource = null;
                gListSanPham.DataSource = new BindingList<BangGiaChiTietLichSuInfor>(liSanPham); ;
                //gvListChungTu.Columns["ParentName"].GroupIndex = 0;
                gvListSanPham.ExpandAllGroups();
                selector.View = gvListSanPham;
                selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                selector.CheckMarkColumn.VisibleIndex = 0;

                ((BindingList<BangGiaChiTietLichSuInfor>)gListSanPham.DataSource).ResetBindings();
                SoLuongHienTai = liSanPham.Count;

                this.grpKetQuaTimKiem.Text = "Tổng số mã hàng: " + liSanPham.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

#endregion


        private void frmBH_TimChungTu_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode==Keys.Enter)   
                {
                    if (!this.gListSanPham.Focused)
                    {
                        SendKeys.Send("{TAB}");
                        e.Handled = true;
                        return;
                    }
                }
                if (e.KeyCode == Keys.F3)
                    this.btnTim_Click(sender, e);
                else if (e.KeyCode == Keys.Escape)
                    this.btnDong_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void bteSanPham_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteSanPham_ButtonClick(sender, e, bteSanPham);
        }

        private void bteSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteSanPham_KeyDown(sender, e, bteSanPham);
        }

        private void bteSanPham_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteSanPham);
        }

        private void btnDeleteLS_Click(object sender, EventArgs e)
        {
            if (selector.selection.Count == 0) return;
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa các dữ liệu này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ConnectionUtil.Instance.BeginTransaction();
                    ArrayList liSanPham = new ArrayList();
                    liSanPham.AddRange(selector.selection);
                    foreach (BangGiaChiTietLichSuInfor bg in liSanPham)
                    {
                        BangGiaDataProvider.Instance.DeleteLichSuThayDoiGiaBanById(bg.IdLichSu);
                    }
                    ConnectionUtil.Instance.CommitTransaction();
                    MessageBox.Show("Xóa dữ liệu lịch sử thành công!");
                }
            }
            catch (Exception ex)
            {
                ConnectionUtil.Instance.RollbackTransaction();

                EventLogProvider.Instance.WriteLog(ex.ToString()
                                    + "\nUser: " + nguoiDung.TenDangNhap
                                    + "\nMay: " + Declare.TenMay,
                                    this.Name);
#if DEBUG
                MessageBox.Show("Lỗi thực hiện Xóa dữ liệu lịch sử\n" + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi thực hiện Xóa dữ liệu lịch sử", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            } 
        }

        private void btnDeleteAllLS_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn toàn bộ dữ liệu này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ConnectionUtil.Instance.BeginTransaction();
                    foreach (BangGiaChiTietLichSuInfor bg in (List<BangGiaChiTietLichSuInfor>)gListSanPham.DataSource)
                    {
                        BangGiaDataProvider.Instance.DeleteLichSuThayDoiGiaBanById(bg.IdLichSu);
                    }
                    ConnectionUtil.Instance.CommitTransaction();
                    MessageBox.Show("Xóa dữ liệu lịch sử thành công!");
                }
            }
            catch (Exception ex)
            {
                ConnectionUtil.Instance.RollbackTransaction();

                EventLogProvider.Instance.WriteLog(ex.ToString()
                                    + "\nUser: " + nguoiDung.TenDangNhap
                                    + "\nMay: " + Declare.TenMay,
                                    this.Name);
#if DEBUG
                MessageBox.Show("Lỗi thực hiện Xóa dữ liệu lịch sử\n" + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi thực hiện Xóa dữ liệu lịch sử", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            } 
        }

        private void cmdExport_Click(object sender, EventArgs e)
        {
            Common.Export2ExcelFromDevGrid<BangGiaChiTietLichSuInfor>(gvListSanPham, "BCLichSuThayDoiGiaBan");
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