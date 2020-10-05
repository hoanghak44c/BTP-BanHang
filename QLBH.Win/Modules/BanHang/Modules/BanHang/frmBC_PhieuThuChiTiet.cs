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
    public partial class frmBC_PhieuThuChiTiet : DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"

        private List<ChungTuThanhToanInfor> liChungTuThanhToan = new List<ChungTuThanhToanInfor>();
        private List<ChungTuThanhToanInfor> liTimKiem = new List<ChungTuThanhToanInfor>();
        public TimKiemPhieuThuFilterInfor filter = new TimKiemPhieuThuFilterInfor();
        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
        private int SoLuongHienTai = 0;

#endregion

#region "Các phương thức khởi tạo"
        public frmBC_PhieuThuChiTiet()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }
#endregion

#region "Các sự kiên"
        private void frmBH_TimChungTu_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAllTrangThai();
                LoadHinhThucThanhToan();
                LoadTaiKhoanQuy();
                LoadNganHang();
                CommonFuns.Instance.LoadTrungTam(bteTrungTam, nguoiDung);
                //TimKiemChungTu();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadAllTrangThai()
        {
            List<TrangThaiBH> liLoaiDH = Common.GetListBCLoaiDonHang();
            //load trang thai cho grid
            repLoaiDonHang.DataSource = liLoaiDH;

            List<TrangThaiBH> liLoaiPhieu = new List<TrangThaiBH>();
            liLoaiPhieu.Add(new TrangThaiBH { Id = 0, Name = "Phiếu thu" });
            liLoaiPhieu.Add(new TrangThaiBH { Id = 1, Name = "Phiếu chi" });
            repLoaiPhieu.DataSource = liLoaiPhieu;

            List<TrangThaiBH> liLoaiPhieu1 = new List<TrangThaiBH>();
            liLoaiPhieu1.Add(new TrangThaiBH { Id = -1, Name = "Tất cả" });
            liLoaiPhieu1.AddRange(liLoaiPhieu);
            lueLoaiDH.Properties.DataSource = liLoaiPhieu1;
            lueLoaiDH.EditValue = -1;
        }

        private void LoadHinhThucThanhToan()
        {
            List<DMThanhToanInfor> liThanhToan = DMThanhToanDataProvider.GetListDMThanhToanInfo();
            liThanhToan.Insert(0, new DMThanhToanInfor()
                                      {
                                          IdThanhToan = 0,
                                          Ma = "",
                                          Ten = "Tất cả",
                                          SuDung = 1
                                      });
            cboHinhThucTT.DataSource = liThanhToan;
            cboHinhThucTT.DisplayMember = "Ten";
            cboHinhThucTT.ValueMember = "IdThanhToan";
            if (liThanhToan.Count > 0)
                cboHinhThucTT.SelectedIndex = 0;
        }
        private void LoadTaiKhoanQuy()
        {
            List<DMTaiKhoanQuyInfo> liTaiKhoanQuy = DMTaiKhoanQuyDataProvider.Instance.GetListTaiKhoanQuyByTrungTam(-1);
            liTaiKhoanQuy.Insert(0, new DMTaiKhoanQuyInfo()
                                      {
                                          TaiKhoanQuy = "",
                                          SuDung = 1
                                      });
            cboTaiKhoanQuy.DataSource = liTaiKhoanQuy;
            cboTaiKhoanQuy.DisplayMember = "TaiKhoanQuy";
            cboTaiKhoanQuy.ValueMember = "TaiKhoanQuy";
        }

        private void LoadNganHang()
        {
            List<DMNganHangInfor> liNganHangTT = DMNganHangDataProvider.Instance.GetListNganHangInfors();
            liNganHangTT.Insert(0, new DMNganHangInfor()
                                       {
                                           IdNganHang = 0,
                                           MaNganHang = "",
                                           TenNganHang = "Tất cả",
                                           SuDung = 1
                                       });
            cboNganHangTT.DataSource = liNganHangTT;
            cboNganHangTT.DisplayMember = "TenNganHang";
            cboNganHangTT.ValueMember = "IdNganHang";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            SoLuongHienTai = 0;
            SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
            liChungTuThanhToan = new List<ChungTuThanhToanInfor>();

            TimKiemChungTu();
        }

        private void GetFilter()
        {
            if (filter == null)
                filter = new TimKiemPhieuThuFilterInfor();
            filter.SoPhieu = txtSoGiaoDich.Text.Trim();
            //filter.LoaiDonHang = Common.IntValue(lueLoaiDH.EditValue);
            filter.IdTrungTam = CommonFuns.Instance.GetIdTrungTam(bteTrungTam, nguoiDung);
            filter.NhanVien = txtNhanVien.Text.Trim();
            filter.ThuNgan = txtThuNgan.Text.Trim();
            filter.KhachHang = txtHoTenKhachHang.Text.Trim();
            filter.SoTaiKhoan = txtSoTaiKhoan.Text.Trim();
            filter.ChuTaiKhoan = txtChuTaiKhoan.Text.Trim();
            filter.TuNgay = Convert.ToDateTime(dteStart.EditValue);
            filter.DenNgay = Convert.ToDateTime(dteEnd.EditValue);
            filter.DoanhThuTu = Common.DoubleValue(txtDoanhThuTu.Text);
            filter.DoanhThuDen = Common.DoubleValue(txtDoanhThuDen.Text);
            filter.IdHinhThucThanhToan = Common.IntValue(cboHinhThucTT.SelectedValue);
            //filter.IdThoiHanThanhToan = Common.IntValue(cboThoiHanTT.SelectedValue);
            filter.IdNganHang = Common.IntValue(cboNganHangTT.SelectedValue);
            filter.GhiChu = "";
            filter.UserName = CommonFuns.Instance.GetUserName();//"chkCuaToi.Checked ? nguoiDung.TenDangNhap : "";
            filter.LoaiPhieu = Common.IntValue(lueLoaiDH.EditValue);
            filter.TaiKhoanQuy = cboTaiKhoanQuy.SelectedValue != null ? cboTaiKhoanQuy.SelectedValue.ToString() : "";
            filter.IdNhanVien = nguoiDung.IdNhanVien;
        }
        private void LoadDuLieu()
        {
            filter.SoBatDau = SoLuongHienTai;
            filter.SoKetThuc = SoLuongTimKiem != -1 ? SoLuongHienTai + SoLuongTimKiem : -1;
            liTimKiem = BaoCaoChiTietPhieuThuChiDataProvider.Instance.TimKiemPThuCTietPg(filter);
            liChungTuThanhToan.AddRange(liTimKiem);

            //liChungTuChiTiet = BanHangDataProvider.Instance.TimKiemChungTuChiTiet(filter);
            //dsChungTuChiTiet = BanHangDataProvider.Instance.TimKiemChungTuChiTietOld(filter);

            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            frmProgress.Instance.IsCompleted = true;
            frmProgress.Instance.Description = "Đã xong";
        }
        private void TimKiemChungTu()
        {
            try
            {
                GetFilter();
                frmProgress.Instance.Description = Common.MsgProgress(SoLuongTimKiem);
                frmProgress.Instance.MaxValue = SoLuongTimKiem;
                frmProgress.Instance.Value = 0;
                frmProgress.Instance.DoWork(LoadDuLieu);

                gListChungTu.DataSource = new BindingList<ChungTuThanhToanInfor>(liChungTuThanhToan);
                //gvListChungTu.Columns["ParentName"].GroupIndex = 0;
                gvListChungTu.ExpandAllGroups();
                selector.View = gvListChungTu;
                selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                selector.CheckMarkColumn.VisibleIndex = 0;
                ((BindingList<ChungTuThanhToanInfor>)gListChungTu.DataSource).ResetBindings();
                SoLuongHienTai = liChungTuThanhToan.Count;
                selector.ClearSelection();

                this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + liChungTuThanhToan.Count + " phiếu)";
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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            EditOrder(gvListChungTu.FocusedRowHandle);
        }

        private void gListChungTu_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter && gvListChungTu.RowCount > 0)
                {
                    EditOrder(gvListChungTu.FocusedRowHandle);
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
        private void EditOrder(int rowHandle)
        {
            //if (rowHandle < 0) return;
            //ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(rowHandle);

            //if ((int)LoaiGiaoDich > 0 && ct != null)
            //{
            //    this.DialogResult = DialogResult.OK;
            //}
            //else if (ct != null)
            //{
            //    if (ct.TrangThai == (int)OrderStatus.TAO_DON_HANG_ONLINE || ct.TrangThai == (int)OrderStatus.REJECT_DON_HANG_ONLINE)
            //    {
            //        frmBH_LapDonHangBanOnline frm = new frmBH_LapDonHangBanOnline(ct);
            //        frm.HideMenu();
            //        frm.ShowDialog();
            //    }
            //}
        }


        private void gListChungTu_DoubleClick(object sender, EventArgs e)
        {
            Point pt = gListChungTu.PointToClient(MousePosition);
            GridHitInfo hitInfo = gvListChungTu.CalcHitInfo(pt);
            if (hitInfo.InRow)
                EditOrder(hitInfo.RowHandle);
        }

#endregion

        private void frmBH_TimChungTu_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode==Keys.Enter)   
                {
                    if (!this.gListChungTu.Focused)
                    {
                        SendKeys.Send("{TAB}");
                        e.Handled = true;
                        return;
                    }
                }
                if (e.KeyCode == Keys.F3)
                    this.btnTim_Click(sender, e);
                else if (e.KeyCode == Keys.F6)
                    this.btnCapNhat_Click(sender, e);
                else if (e.KeyCode == Keys.F12)
                    this.btnDong_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }


        private void ResetTrungTam()
        {
            //bteKhoXuat.ResetText();
            //bteKhoXuat.Tag = null;
        }

        private void bteTrungTam_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (UtilFunctions.bteTrungTam_ButtonClick(sender, e, bteTrungTam, nguoiDung.IdNhanVien))
                ResetTrungTam();
        }

        private void bteTrungTam_KeyDown(object sender, KeyEventArgs e)
        {
            if (UtilFunctions.bteTrungTam_KeyDown(sender, e, bteTrungTam, nguoiDung.IdNhanVien))
                ResetTrungTam();
        }

        private void bteTrungTam_TextChanged(object sender, EventArgs e)
        {
            if (UtilFunctions.bteItem_TextChanged(sender, e, bteTrungTam))
                ResetTrungTam();
        }

        private void gvListChungTu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
        }

        private void cmdExport_Click(object sender, EventArgs e)
        {
            //Common.DevExport2Excel(gvListChungTu);
            Common.Export2ExcelFromDevGrid<ChungTuThanhToanInfor>(gvListChungTu, "BCPhieuThuChiTiet");
        }

        private void gvListChungTu_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
        }
    }
}