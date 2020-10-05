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
    public partial class frmBC_NoKhuyenMai : DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"
        private LoaiGiaoDichBanHang LoaiGiaoDich;
        private DataTable dsChungTuChiTiet;
        private List<ChungTuBanHangChiTietBCInfor> liChungTuChiTiet = new List<ChungTuBanHangChiTietBCInfor>();
        private List<ChungTuBanHangChiTietBCInfor> liTimKiem = new List<ChungTuBanHangChiTietBCInfor>();
        public TimKiemChungTuChiTietFilterInfor filter = new TimKiemChungTuChiTietFilterInfor();
        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
        private int SoLuongHienTai = 0;
        private bool XoaNoKM = false;

#endregion

#region "Các phương thức khởi tạo"
        public frmBC_NoKhuyenMai()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }
        public frmBC_NoKhuyenMai(bool xoaNoKM)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.XoaNoKM = xoaNoKM;
            if (XoaNoKM)
                this.Text = "Xóa nợ khuyến mại";
        }
#endregion

#region "Các sự kiên"
        private void frmBH_TimChungTu_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAllTrangThai();
                cboLoaiMaHang.SelectedIndex = 6;
                CommonFuns.Instance.LoadComboBoxPages(cboPage);
                //TimKiemChungTu();
                btnXoaNoKhuyenMai.Visible = (nguoiDung.SupperUser == 1 || XoaNoKM) ? true : false;
                btnXoaNoKhuyenMai.Enabled = (nguoiDung.SupperUser == 1 || XoaNoKM) ? true : false;

                btnKhoiPhucNoKM.Visible = (nguoiDung.SupperUser == 1 || XoaNoKM) ? true : false;
                btnKhoiPhucNoKM.Enabled = (nguoiDung.SupperUser == 1 || XoaNoKM) ? true : false;
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
            SoLuongHienTai = 0;
            SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
            liChungTuChiTiet = new List<ChungTuBanHangChiTietBCInfor>();

            TimKiemChungTu();
        }

        private void GetFilter()
        {
            if (filter == null)
                filter = new TimKiemChungTuChiTietFilterInfor();
            filter.SoPhieu = txtSoGiaoDich.Text.Trim();
            filter.LoaiDonHang = Common.IntValue(lueLoaiDH.EditValue);
            filter.IdTrungTam = bteTrungTam.Tag != null ? ((DMTrungTamInfor) bteTrungTam.Tag).IdTrungTam : -1;
            filter.IdKho = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : -1;
            filter.LoaiMaHang = cboLoaiMaHang.SelectedIndex;
            filter.MaHang = txtSanPham.Text.Trim();
            filter.NhanVien = txtNhanVien.Text.Trim();
            filter.TuNgay = Convert.ToDateTime(dteStart.EditValue);
            filter.DenNgay = Convert.ToDateTime(dteEnd.EditValue);
            filter.KhachHang = txtHoTenKhachHang.Text.Trim();
            filter.GhiChu = "";
            filter.UserName = CommonFuns.Instance.GetUserName();//"chkCuaToi.Checked ? nguoiDung.TenDangNhap : "";
        }
        private void LoadDuLieu()
        {
            filter.SoBatDau = SoLuongHienTai;
            filter.SoKetThuc = SoLuongTimKiem != -1 ? SoLuongHienTai + SoLuongTimKiem : -1;
            liTimKiem = BanHangDataProvider.Instance.TimKiemChungTuChiTietNoKMPg(filter);
            
            if(filter.SoKetThuc == -1) liChungTuChiTiet.Clear();

            liChungTuChiTiet.AddRange(liTimKiem);

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

                gListChungTu.DataSource = new BindingList<ChungTuBanHangChiTietBCInfor>(liChungTuChiTiet);// dsChungTuChiTiet;// liChungTuChiTiet;
                //gvListChungTu.Columns["ParentName"].GroupIndex = 0;
                gvListChungTu.ExpandAllGroups();
                selector.View = gvListChungTu;
                selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                selector.CheckMarkColumn.VisibleIndex = 0;
                ((BindingList<ChungTuBanHangChiTietBCInfor>)gListChungTu.DataSource).ResetBindings();
                SoLuongHienTai = liChungTuChiTiet.Count;
                selector.ClearSelection();

                this.grpKetQuaTimKiem.Text = String.Format("Kết quả tìm kiếm {0} mặt hàng", liChungTuChiTiet.Count);

                //this.grpKetQuaTimKiem.Text = String.Format("Kết quả tìm kiếm {0} mặt hàng",
                //                                           (dsChungTuChiTiet != null ? dsChungTuChiTiet.Rows.Count : 0));
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
            Common.Export2ExcelFromDevGrid<ChungTuBanHangChiTietBCInfor>(gvListChungTu, "BCNoKhuyenMai");
        }

        private void gvListChungTu_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle < 0) return;
            ChungTuBanHangChiTietBCInfor ct = (ChungTuBanHangChiTietBCInfor)gvListChungTu.GetRow(e.RowHandle);
            if (ct != null && ct.XoaNoKM > 0)
            {
                if (e.Column.FieldName.Equals("GhichuNoKM"))
                {
                    e.Appearance.BackColor = Color.Yellow;
                    e.Appearance.ForeColor = Color.Red;
                    e.Appearance.Font = new Font("Tahoma", 9, FontStyle.Bold);
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

        private void btnXoaNoKhuyenMai_Click(object sender, EventArgs e)
        {
            try
            {
                if (selector.selection.Count > 0)
                {
                    foreach (ChungTuBanHangChiTietBCInfor ct in selector.selection)
                    {
                        if (ct.NoKhuyenMai > 0)
                            BanHangDataProvider.Instance.XoaKhuyenMai(ct.IdChungTuChiTiet, 1);//xoa
                    }
                    MessageBox.Show("Xóa nợ khuyến mại thành công!");
                    btnTim_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKhoiPhucNoKM_Click(object sender, EventArgs e)
        {
            try
            {                
                if (selector.selection.Count > 0)
                {
                    foreach (ChungTuBanHangChiTietBCInfor ct in selector.selection)
                    {
                        if (ct.XoaNoKM > 0)
                            BanHangDataProvider.Instance.XoaKhuyenMai(ct.IdChungTuChiTiet, 2);//khoi phuc
                    }
                    MessageBox.Show("Khôi phục nợ khuyến mại thành công!");
                    btnTim_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}