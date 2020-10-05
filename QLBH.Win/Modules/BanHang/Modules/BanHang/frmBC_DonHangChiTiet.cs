using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
//using QLBanHang.Class;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBC_DonHangChiTiet : FrmBcBase1<ChungTuBanHangChiTietBCInfor>
        //DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"
        private LoaiGiaoDichBanHang LoaiGiaoDich;
        private DataTable dsChungTuChiTiet;
        private List<ChungTuBanHangChiTietBCInfor> liChungTuChiTiet = new List<ChungTuBanHangChiTietBCInfor>();
        private List<ChungTuBanHangChiTietBCInfor> liTimKiem = new List<ChungTuBanHangChiTietBCInfor>();
        public TimKiemChungTuChiTietFilterInfor filter;
        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
        private int SoLuongHienTai = 0;

#endregion

#region "Các phương thức khởi tạo"
        public frmBC_DonHangChiTiet()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            DataProvider = DonHangChiTietDataProvider.Instance;
            filter = new TimKiemChungTuChiTietFilterInfor();
            gListChungTu.DataSource = DataSource;
        }
#endregion

#region "Các sự kiên"
        private void frmBH_TimChungTu_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAllTrangThai();
                cboLoaiMaHang.SelectedIndex = 6;
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
            List<TrangThaiBH> liTrangThaiDH = Common.GetListBCTrangThaiDonHang();
            //load trang thai cho grid
            repLoaiDonHang.DataSource = liLoaiDH;
            repTrangThaiDH.DataSource = liTrangThaiDH;

            List<TrangThaiBH> liLoaiDH1 = new List<TrangThaiBH>();
            liLoaiDH1.Add(new TrangThaiBH { Id = -1, Name = "Tất cả" });
            liLoaiDH1.AddRange(liLoaiDH);
            lueLoaiDH.Properties.DataSource = liLoaiDH1;
            lueLoaiDH.EditValue = -1;

            List<TrangThaiBH> liTrangThaiDH1 = new List<TrangThaiBH>();
            liTrangThaiDH1.Add(new TrangThaiBH { Id = -1, Name = "Tất cả" });
            liTrangThaiDH1.AddRange(Common.GetListTrangThaiDonHang(LoaiGiaoDich));
            lueTrangThaiDH.Properties.DataSource = liTrangThaiDH1;
            lueTrangThaiDH.EditValue = -1;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                //SoLuongHienTai = 0;
                //SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
                //liChungTuChiTiet = new List<ChungTuBanHangChiTietBCInfor>();

                TimKiemChungTu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        protected override bool DivCondition()
        {
            return String.IsNullOrEmpty(filter.SoPhieu);
        }
        protected override IFilter GetFilter()
        {
            if (filter == null)
                filter = new TimKiemChungTuChiTietFilterInfor();
            filter.SoPhieu = txtSoGiaoDich.Text.Trim();
            filter.LoaiDonHang = Common.IntValue(lueLoaiDH.EditValue);
            filter.TrangThai = Common.IntValue(lueTrangThaiDH.EditValue);
            filter.IdTrungTam = CommonFuns.Instance.GetIdTrungTam(bteTrungTam, nguoiDung);
            filter.IdKho = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : -1;
            filter.LoaiMaHang = cboLoaiMaHang.SelectedIndex;
            filter.MaHang = bteNganh.Text;
            filter.NhanVien = txtNhanVien.Text.Trim();
            filter.TuNgay = Convert.ToDateTime(dteStart.EditValue);
            filter.DenNgay = Convert.ToDateTime(dteEnd.EditValue);
            filter.KhachHang = txtHoTenKhachHang.Text.Trim();
            filter.GhiChu = "";
            filter.UserName = CommonFuns.Instance.GetUserName();//"chkCuaToi.Checked ? nguoiDung.TenDangNhap : "";
            filter.UserName = String.IsNullOrEmpty(filter.UserName) && filter.IdTrungTam > 0 &&
                              filter.IdTrungTam == nguoiDung.IdTrungTamHachToan
                                  ? nguoiDung.TenDangNhap
                                  : String.Empty;

            filter.IdNhanVien = nguoiDung.IdNhanVien;
            filter.IdNhomNguoiDung = nguoiDung.SupperUser == 1 ? -1 : nguoiDung.IdNhomNguoiDung;
            return filter;
        }

        protected override void RefreshDataSource()
        {
            gListChungTu.RefreshDataSource();

            if (gvListChungTu.RowCount > 0)

                gvListChungTu.FocusedRowHandle = 0;

            this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + DataSource.Count + " phiếu)";
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
            return;
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
            bteKhoXuat.ResetText();
            bteKhoXuat.Tag = null;
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

        private void bteKhoXuat_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteKhoXuat);
        }

        private void bteKhoXuat_KeyDown(object sender, KeyEventArgs e)
        {
            int idTrungTam = bteTrungTam.Tag != null ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam : 0;
            UtilFunctions.bteKhoXuat_KeyDown(sender, e, bteKhoXuat, idTrungTam, nguoiDung.IdNhanVien);
        }

        private void bteKhoXuat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int idTrungTam = bteTrungTam.Tag != null ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam : 0;
            UtilFunctions.bteKhoXuat_ButtonClick(sender, e, bteKhoXuat, idTrungTam, nguoiDung.IdNhanVien);
        }

        private void gvListChungTu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
        }


        private void cmdExport_Click(object sender, EventArgs e)
        {
            //Common.DevExport2Excel(gvListChungTu, "BCDonHangChiTiet");
            //Common.Export2ExcelFromDataSource(gvListChungTu, "BCDonHangChiTiet");
            //Common.Export2ExcelFromDevGrid<ChungTuBanHangChiTietBCInfor>(gvListChungTu, "BCDonHangChiTiet");
            Common.Export2ExcelFromDevGridTest<ChungTuBanHangChiTietBCInfor>(gvListChungTu, "BCDonHangChiTiet");
        }

        private void gvListChungTu_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            var ct = (ChungTuBanHangChiTietBCInfor)gvListChungTu.GetRow(e.RowHandle);
            if (ct != null)
            {
                if (e.Column.FieldName.Equals("TrangThai"))
                {
                    if (Convert.ToInt32(ct.TrangThai) == (int)OrderStatus.REJECT_DON_HANG_ONLINE || Convert.ToInt32(ct.TrangThai) == (int)OrderStatus.REJECT_DON_HANG_GIAO_NHAN)
                    {
                        e.Appearance.BackColor = tsslTuChoiClr.BackColor;
                        e.Appearance.ForeColor = tsslTuChoiClr.ForeColor;
                    }
                    else if (Convert.ToInt32(ct.TrangThai) == (int)OrderStatus.HUY_DON_HANG || Convert.ToInt32(ct.TrangThai) == (int)OrderStatus.HUY_DON_HANG_ONLINE ||
                        Convert.ToInt32(ct.TrangThai) == (int)OrderStatus.HUY_DON_HANG_DAT_TRUOC || Convert.ToInt32(ct.TrangThai) == (int)OrderStatus.KHOA_DON_HANG_DAT_TRUOC)
                    {
                        e.Appearance.BackColor = tsslHuyClr.BackColor;
                        e.Appearance.ForeColor = tsslHuyClr.ForeColor;
                    }
                }

                if (e.Column.FieldName.Equals("XoaNoKM") && ct.XoaNoKM > 0)
                {
                    e.Appearance.BackColor = tsslHuyClr.BackColor;
                    e.Appearance.ForeColor = tsslHuyClr.ForeColor;                    
                }                
            }
        }

        //private void gtidButton1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        GetFilter();
        //        liChungTuChiTiet = BanHangDataProvider.Instance.TimKiemChungTuChiTiet(filter);

        //        gListChungTu.DataSource = liChungTuChiTiet;
        //        //gvListChungTu.Columns["ParentName"].GroupIndex = 0;
        //        gvListChungTu.ExpandAllGroups();
        //        selector.View = gvListChungTu;
        //        selector.CheckMarkColumn.Fixed = FixedStyle.Left;
        //        selector.CheckMarkColumn.VisibleIndex = 0;

        //        this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + liChungTuChiTiet.Count + " mặt hàng)";
        //        //if (gvListChungTu.RowCount == 0)
        //        //{
        //        //    MessageBox.Show("Không có chứng từ nào thỏa mãn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        //    return;
        //        //}
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void btnExportAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Declare.msgLoadDataWrn, "Cảnh báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            Cursor.Current = Cursors.WaitCursor;
            try
            {

                //DataSet ds = BanHangDataProvider.Instance.TimKiemChungTuChiTietAll(filter);
                //Common.Export2ExcelFromDataSource(ds, "BCDonHangChiTiet");
                Common.Export2ExcelFromDataSource(gvListChungTu, "BCDonHangChiTiet");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
        }

        private void bteNganh_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteItemSegment_ButtonClick(sender, e, bteNganh, cboLoaiMaHang.SelectedIndex);
        }

        private void bteNganh_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteItemSegment_KeyDown(sender, e, bteNganh, cboLoaiMaHang.SelectedIndex);
        }

        private void bteNganh_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteNganh);
        }

        private void tsbChinhSachGia_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvListChungTu.FocusedRowHandle < 0) return;
                ChungTuBanHangChiTietBCInfor ct = (ChungTuBanHangChiTietBCInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
                if (ct != null && ct.ListIdChinhSach != null && ct.ListIdChinhSach.Length > 2)
                {
                    string lstIdDKMua = ct.ListIdChinhSach.Replace(";", ",");
                    lstIdDKMua = lstIdDKMua.TrimStart(",".ToCharArray());
                    lstIdDKMua = lstIdDKMua.TrimEnd(",".ToCharArray());
                    List<BangGiaChinhSachInfor> liCSG = ChinhSachDataProvider.Instance.LoadChinhSachByIdDKMua(lstIdDKMua);
                    if (liCSG.Count > 0)
                    {
                        frmCS_List_ChinhSachKM_View frm = new frmCS_List_ChinhSachKM_View(liCSG[0], liCSG, true, null);
                        frm.Show();
                        frm.HideMenu();
                    }
                }
                else
                {
                    MessageBox.Show("Không có chính sách khuyến mại đi kèm");
                }
            }
            catch
            {
            }
            CommonFuns.Instance.ShowChinhSachKM(gvListChungTu);
        }
    }
}