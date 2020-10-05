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
using QLBH.Common.Providers;
using QLBH.Core.Data;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.BanHang.Bussiness;
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBC_GiaoNhanThongKeKThuat : DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"

        private List<ChungTuBanHangGNhanKThuatInfor> liChungTuBanHang = new List<ChungTuBanHangGNhanKThuatInfor>();
        private List<ChungTuBanHangGNhanKThuatInfor> liTimKiem = new List<ChungTuBanHangGNhanKThuatInfor>();
        private TimKiemGiaoNhanFilterInfor filter = new TimKiemGiaoNhanFilterInfor();
        private List<DMPhuongTienGiaoNhanInfor> liPhuongTienGN = new List<DMPhuongTienGiaoNhanInfor>();
        private List<DMVungMienKhachInfor> liVungMien = new List<DMVungMienKhachInfor>();
        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
        private int SoLuongHienTai = 0;

#endregion

#region "Các phương thức khởi tạo"
        public frmBC_GiaoNhanThongKeKThuat()
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
                //LoadNamThang();
                LoadAllTrangThai();
                LoadPhuongTienGiaoNhan();
                LoadVungMienKhach();
                CommonFuns.Instance.LoadComboBoxPages(cboPage);
                CommonFuns.Instance.LoadTrungTam(bteTrungTam, nguoiDung);                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //private void LoadNamThang()
        //{
        //    DateTime time = CommonProvider.Instance.GetSysDate();
        //    int ind = 0;
        //    cboThang.Items.Clear();
        //    for (int i=1;i<=12;i++)
        //    {
        //        cboThang.Items.Add(i.ToString());
        //        if (i == time.Month)
        //            ind = i - 1;
        //    }
        //    cboThang.SelectedIndex = ind;

        //    cboNam.Items.Clear();
        //    for (int i = 2012; i <= 2020; i++)
        //    {
        //        cboNam.Items.Add(i.ToString());
        //        if (i == time.Year)
        //            ind = i - 2012;
        //    }
        //    cboNam.SelectedIndex = ind;
        //}
        private void LoadPhuongTienGiaoNhan()
        {
            liPhuongTienGN = DMPhuongTienGiaoNhanDataProvider.Instance.GetListPhuongTienGiaoNhanInfors();
            liPhuongTienGN.Insert(0, new DMPhuongTienGiaoNhanInfor()
                                         {
                                             MaPhuongTien = "",
                                             TenPhuongTien = "Tất cả",
                                             SuDung = 1,
                                             GhiChu = ""
                                         });
            cboPhuongTienGN.DataSource = liPhuongTienGN;
            cboPhuongTienGN.DisplayMember = "TenPhuongTien";
            cboPhuongTienGN.ValueMember = "MaPhuongTien";
            cboPhuongTienGN.SelectedIndex = 0;
        }
        private void LoadVungMienKhach()
        {
            liVungMien = DMVungMienKhachDataProvider.Instance.GetListVungMienKhachInfors();
            liVungMien.Insert(0, new DMVungMienKhachInfor()
                                     {
                                         MaVung = "",
                                         TenVungMien = "Tất cả",
                                         SuDung = 1
                                     });
            cboVungMienKhach.DataSource = liVungMien;
            cboVungMienKhach.DisplayMember = "TenVungMien";
            cboVungMienKhach.ValueMember = "MaVung";
            cboVungMienKhach.SelectedIndex = 0;
        }
        private void LoadAllTrangThai()
        {
            List<TrangThaiBH> liDraft = Common.GetListTinhTrangDonHang();
            List<TrangThaiBH> liLoaiDH = Common.GetListLoaiDonHang();
            List<TrangThaiBH> liTrangThaiDH = Common.GetListTrangThaiDonHang();
            List<TrangThaiBH> liTrangThaiGN = Common.GetListTrangThaiGiaoVan();
            //load trang thai cho grid
            repDraft.DataSource = liDraft;
            repLoaiDonHang.DataSource = liLoaiDH;
            repTrangThaiDH.DataSource = liTrangThaiDH;
            repTinhTrangGN.DataSource = liTrangThaiGN;

            List<TrangThaiBH> liLoaiDH1 = new List<TrangThaiBH>();
            liLoaiDH1.Add(new TrangThaiBH { Id = -1, Name = "Tất cả" });
            liLoaiDH1.AddRange(liLoaiDH);
            lueLoaiDH.Properties.DataSource = liLoaiDH1;
            lueLoaiDH.EditValue = -1;

            List<TrangThaiBH> liTrangThaiDH1 = new List<TrangThaiBH>();
            liTrangThaiDH1.Add(new TrangThaiBH { Id = -2, Name = "Tất cả" });
            liTrangThaiDH1.AddRange(liTrangThaiGN);
            lueTrangThaiDH.Properties.DataSource = liTrangThaiDH1;
            lueTrangThaiDH.EditValue = -2;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            SoLuongHienTai = 0;
            SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
            liChungTuBanHang = new List<ChungTuBanHangGNhanKThuatInfor>();

            TimKiemChungTu();
        }

        private void GetFilter()
        {
            if (filter == null)
                filter = new TimKiemGiaoNhanFilterInfor();
            filter.SoPhieu = txtSoGiaoDich.Text.Trim();
            filter.LoaiDonHang = Common.IntValue(lueLoaiDH.EditValue);
            filter.TrangThai = Common.IntValue(lueTrangThaiDH.EditValue);
            filter.IdTrungTam = CommonFuns.Instance.GetIdTrungTam(bteTrungTam, nguoiDung);
            filter.IdKho = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : -1;
            filter.SanPham = txtSanPham.Text.Trim();
            filter.NhanVien = bteThuongVien.Tag != null ? ((DMNhanVienInfo)bteThuongVien.Tag).IdNhanVien : -1;
            filter.DoiTac = bteDoiTac.Tag != null ? ((DMNhanVienInfo)bteDoiTac.Tag).IdNhanVien : -1;
            DateTime time = CommonProvider.Instance.GetSysDate();
            filter.TuNgay = Convert.ToDateTime(dteStart.EditValue);
            filter.DenNgay = Convert.ToDateTime(dteEnd.EditValue);
            filter.QuanHuyen = bteQuanHuyen.Tag != null ? ((DMHuyenInfor)bteQuanHuyen.Tag).IdHuyen : -1;
            filter.PhuongTien = cboPhuongTienGN.SelectedIndex >= 0 && liPhuongTienGN.Count > 0
                                    ? liPhuongTienGN[cboPhuongTienGN.SelectedIndex].MaPhuongTien
                                    : "";
            filter.VungMien = cboVungMienKhach.SelectedIndex >= 0 && liVungMien.Count > 0
                                  ? liVungMien[cboVungMienKhach.SelectedIndex].MaVung
                                  : "";
            filter.UserName = CommonFuns.Instance.GetUserName();//"chkCuaToi.Checked ? nguoiDung.TenDangNhap : "";
            filter.IdNhanVien = nguoiDung.IdNhanVien;
        }

        private void LoadDuLieu()
        {
            filter.SoBatDau = SoLuongHienTai;
            filter.SoKetThuc = SoLuongTimKiem != -1 ? SoLuongHienTai + SoLuongTimKiem : -1;
            liTimKiem = BanHangDataProvider.Instance.TimKiemChungTuGiaoNhanThongKeKThuatCTPg(filter);
            liChungTuBanHang.AddRange(liTimKiem);

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
                gListChungTu.DataSource = new BindingList<ChungTuBanHangGNhanKThuatInfor>(liChungTuBanHang);

                //gvListChungTu.Columns["ParentName"].GroupIndex = 0;
                gvListChungTu.ExpandAllGroups();
                //selector.View = gvListChungTu;
                //selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                //selector.CheckMarkColumn.VisibleIndex = 0;
                ((BindingList<ChungTuBanHangGNhanKThuatInfor>)gListChungTu.DataSource).ResetBindings();
                SoLuongHienTai = liChungTuBanHang.Count;
                //selector.ClearSelection();

                this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + liChungTuBanHang.Count + " phiếu)";
                //if (gvListChungTu.RowCount == 0)
                //{
                //    MessageBox.Show("Không có chứng từ nào thỏa mãn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}
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
                    this.cmdExport_Click(sender, e);
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
            //Common.DevExport2Excel(gvListChungTu, "BCGiaoNhanChiTiet");
            Common.Export2ExcelFromDevGrid<ChungTuBanHangGNhanKThuatInfor>(gvListChungTu, "BCGiaoNhanKyThuat");
        }

        private void gvListChungTu_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            //ChungTuBanHangGNhanKThuatInfor ct = (ChungTuBanHangGNhanKThuatInfor)gvListChungTu.GetRow(e.RowHandle);
            //if (ct != null)
            //{
            //    if (e.Column.FieldName.Equals("TinhTrangGiaoNhan"))
            //    {
            //        if (ct.TinhTrangGiaoNhan == -1)
            //            e.Appearance.BackColor = tsslChuaPC.BackColor;
            //        else if (ct.TinhTrangGiaoNhan == 0)
            //            e.Appearance.BackColor = tsslDaPhanCong.BackColor;
            //        else if (ct.TinhTrangGiaoNhan == 1)
            //            e.Appearance.BackColor = tsslDangGiaoHang.BackColor;
            //        else if (ct.TinhTrangGiaoNhan == 2)
            //            e.Appearance.BackColor = tsslDaGiaoXong.BackColor;
            //        else if (ct.TinhTrangGiaoNhan == 3)
            //            e.Appearance.BackColor = tsslHuyClr.BackColor;
            //        else if (ct.TinhTrangGiaoNhan == 4)
            //            e.Appearance.BackColor = tsslNLaiClr.BackColor;
            //    }
            //}
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

            TimKiemChungTu();
        }

        private void bteThuongVien_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteNhanVien_ButtonClick(sender, e, bteThuongVien, -1, nguoiDung.IdNguoiDung);
        }

        private void bteThuongVien_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteNhanVien_KeyDown(sender, e, bteThuongVien, -1, nguoiDung.IdNguoiDung);
        }

        private void bteThuongVien_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteThuongVien);
        }

        private void bteDoiTac_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteNhaCungCap_ButtonClick(sender, e, bteDoiTac, true);
        }

        private void bteDoiTac_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteNhaCungCap_KeyDown(sender, e, bteDoiTac, true);
        }

        private void bteDoiTac_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteDoiTac);
        }

        private void bteQuanHuyen_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteQuanHuyen_ButtonClick(sender, e, bteQuanHuyen);
        }

        private void bteQuanHuyen_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteQuanHuyen_KeyDown(sender, e, bteQuanHuyen);
        }

        private void bteQuanHuyen_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteQuanHuyen);
        }
    }
}