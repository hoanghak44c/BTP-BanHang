using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using QLBanHang.Class;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QLBanHang.Modules.DanhMuc.Base;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.KhoHang.DAO;
using QLBH.Common;
using QLBH.Common.Providers;
using QLBH.Core.Data;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.BanHang.Bussiness;
using QLBH.Core.Form;
using QLBH.Core.Providers;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBC_TongHopKhungGioTuan : DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"

        private List<ChungTuBanHangBCTheoGioInfor> liChungTuThanhToan = new List<ChungTuBanHangBCTheoGioInfor>();
        private List<ChungTuBanHangBCTheoGioInfor> liTimKiem = new List<ChungTuBanHangBCTheoGioInfor>();
        public TimKiemChungTuFilterInfor filter;
        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
        private int SoLuongHienTai = 0;

#endregion

#region "Các phương thức khởi tạo"
        public frmBC_TongHopKhungGioTuan()
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
                CommonFuns.Instance.LoadTrungTam(bteTrungTam, nguoiDung);
                gListChungTu.DataSource = liChungTuThanhToan;
                //TimKiemChungTu();
                dteStart.EditValue = CommonProvider.Instance.GetSysDate();
                dteEnd.EditValue = dteStart.DateTime;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadAllTrangThai()
        {
            List<TrangThaiBH> liLoaiDH = Common.GetListBCLoaiDonHang();
            List<TrangThaiBH> liTrangThaiDH = Common.GetListBCTrangThaiDonHang();
            List<TrangThaiBH> liKhungGio = Common.GetListKhungGio();
            List<TrangThaiBH> liThu = Common.GetListThuTuan();
            
            //load trang thai cho grid
            repLoaiDonHang.DataSource = liLoaiDH;
            repTrangThai.DataSource = liTrangThaiDH;
            repKhungGio.DataSource = liKhungGio;
            repThu.DataSource = liThu;

            List<TrangThaiBH> liLoaiDH1 = new List<TrangThaiBH>();
            liLoaiDH1.Add(new TrangThaiBH { Id = -1, Name = "Tất cả" });
            liLoaiDH1.AddRange(liLoaiDH);
            lueLoaiDH.Properties.DataSource = liLoaiDH1;
            lueLoaiDH.EditValue = -1;

            List<TrangThaiBH> liKhungGio1 = new List<TrangThaiBH>();
            liKhungGio1.Add(new TrangThaiBH { Id = -1, Name = "Tất cả" });
            liKhungGio1.AddRange(liKhungGio);
            lueKhungGio.Properties.DataSource = liKhungGio1;
            lueKhungGio.EditValue = -1;

            List<TrangThaiBH> liThu1 = new List<TrangThaiBH>();
            liThu1.Add(new TrangThaiBH { Id = -1, Name = "Tất cả" });
            liThu1.AddRange(liThu);
            lueThu.Properties.DataSource = liThu1;
            lueThu.EditValue = -1;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                SoLuongHienTai = 0;
                SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
                liChungTuThanhToan = new List<ChungTuBanHangBCTheoGioInfor>();

                TimKiemChungTu();
            }
            catch (Exception ex)
            {
                EventLogProvider.Instance.WriteOfflineLog(ex.ToString(), "Báo cáo tổng hợp bán hàng theo khung giờ.");
#if (DEBUG)
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
        }

        private void GetFilter()
        {
            if (dteStart.EditValue == null)
                   dteStart.EditValue = CommonProvider.Instance.GetSysDate();
            if (dteEnd.EditValue == null)
                dteEnd.EditValue = dteStart.DateTime;

            if (filter == null)
                filter = new TimKiemChungTuFilterInfor();
            filter.LoaiDonHang = Common.IntValue(lueLoaiDH.EditValue);
            filter.IdTrungTam = CommonFuns.Instance.GetIdTrungTam(bteTrungTam, nguoiDung);
            filter.MaHang = bteNganh.Text;
            filter.TuNgay = Convert.ToDateTime(dteStart.EditValue);
            filter.DenNgay = Convert.ToDateTime(dteEnd.EditValue);
            filter.KhungGio = Common.IntValue(lueKhungGio.EditValue);
            filter.Thu = Common.IntValue(lueThu.EditValue);
            filter.UserName = CommonFuns.Instance.GetUserName();//"chkCuaToi.Checked ? nguoiDung.TenDangNhap : "";
            filter.IdNhanVien = nguoiDung.IdNhanVien;
            filter.IdNhomNguoiDung = nguoiDung.SupperUser == 1 ? -1 : nguoiDung.IdNhomNguoiDung;
        }

        private void LoadDuLieu()
        {
            filter.SoBatDau = SoLuongHienTai;
            filter.SoKetThuc = SoLuongTimKiem != -1 ? SoLuongHienTai + SoLuongTimKiem : -1;
            liTimKiem = BanHangDataProvider.Instance.TimKiemBanHangKhungGioTuanPg(filter);
            liChungTuThanhToan.AddRange(liTimKiem);

            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            frmProgress.Instance.IsCompleted = true;
            frmProgress.Instance.Description = "Đã xong";
        }

        private void TimKiemChungTu()
        {
            try
            {
                GetFilter();
                frmProgress.Instance.Description = "Đang nạp dữ liệu ...";
                frmProgress.Instance.MaxValue = SoLuongTimKiem;
                frmProgress.Instance.Value = 0;
                frmProgress.Instance.DoWork(LoadDuLieu);

                gListChungTu.DataSource = new BindingList<ChungTuBanHangBCTheoGioInfor>(liChungTuThanhToan);
                //gvListChungTu.Columns["ParentName"].GroupIndex = 0;
                gvListChungTu.ExpandAllGroups();
                selector.View = gvListChungTu;
                selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                selector.CheckMarkColumn.VisibleIndex = 0;
                ((BindingList<ChungTuBanHangBCTheoGioInfor>)gListChungTu.DataSource).ResetBindings();
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
            //Common.Export2ExcelFromDevGrid<ChungTuThanhToanBCInfor>(gvListChungTu, "BCDoanhThuBanHang");
            Common.Export2ExcelFromDevGridTest<ChungTuThanhToanBCInfor>(gvListChungTu, "BCBanHangTheoGio");
        }

        private void gvListChungTu_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
        }

        private void bteNganh_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteItemSegment_ButtonClick(sender, e, bteNganh, 1);//ngành
        }

        private void bteNganh_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteItemSegment_KeyDown(sender, e, bteNganh, 1);
        }

        private void bteNganh_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteNganh);
        }
    }
}