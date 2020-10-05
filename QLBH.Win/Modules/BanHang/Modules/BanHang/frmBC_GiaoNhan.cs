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
using QLBH.Core.Exceptions;
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBC_GiaoNhan : FrmBcBase1<ChungTuBanHangBCInfor>
        //DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"

        private TimKiemChungTuFilterInfor filter;
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
#endregion

#region "Các phương thức khởi tạo"
        public frmBC_GiaoNhan()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            DataProvider = BaoCaoGiaoNhanDataProvider.Instance;
            filter = new TimKiemChungTuFilterInfor();
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
                dteStart.DateTime = dteEnd.DateTime = CommonProvider.Instance.GetSysDate();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAllTrangThai()
        {
            List<TrangThaiBH> liDraft = Common.GetListTinhTrangDonHang();
            List<TrangThaiBH> liLoaiDH = Common.GetListLoaiDonHang();
            List<TrangThaiBH> liTrangThaiDH = Common.GetListTrangThaiDonHang();
            List<TrangThaiBH> liTrangThaiGN = Common.GetListTrangThaiGiaoVan();
            List<TrangThaiBH> liTrangThaiPD = Common.GetListTrangThaiPhanDon();
            List<TrangThaiBH> liGiaoNhan = Common.GetListLoaiGiaoVan();
            
            //load trang thai cho grid
            repDraft.DataSource = liDraft;
            repLoaiDonHang.DataSource = liLoaiDH;
            repTrangThaiDH.DataSource = liTrangThaiDH;
            repTinhTrangGN.DataSource = liTrangThaiGN;
            repTrangThaiPD.DataSource = liTrangThaiPD;
            repGiaoNhan.DataSource = liGiaoNhan;

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
            try
            {
                TimKiemChungTu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected override IFilter GetFilter()
        {
            if (filter == null)
                filter = new TimKiemChungTuFilterInfor();
            filter.SoPhieu = txtSoGiaoDich.Text.Trim();
            filter.LoaiDonHang = Common.IntValue(lueLoaiDH.EditValue);
            //filter.GiaoNhan = cboGiaoNhan.SelectedIndex < 0 ? -1 : arLoaiDongHang[cboGiaoNhan.SelectedIndex];
            filter.TrangThai = Common.IntValue(lueTrangThaiDH.EditValue);
            filter.IdTrungTam = CommonFuns.Instance.GetIdTrungTam(bteTrungTam, nguoiDung);
            filter.IdKho = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : -1;
            filter.LoaiMaHang = cboLoaiMaHang.SelectedIndex;
            filter.MaHang = bteNganh.Text;
            filter.NhanVien = txtNhanVien.Text.Trim();
            if (dteStart.EditValue == null)
            {
                dteStart.Focus();
                
                throw new ManagedException("Bạn chưa chọn ngày bắt đầu");
            }
            filter.TuNgay = dteStart.DateTime;

            if (dteEnd.EditValue == null)
            {
                dteEnd.Focus();

                throw new ManagedException("Bạn chưa chọn ngày kết thúc");
            }
            filter.DenNgay = dteEnd.DateTime;
            //filter.IdDoiTuong = bteKhachHang.Tag != null ? ((DMDoiTuongInfo)bteKhachHang.Tag).IdDoiTuong : -1;
            filter.KhachHang = txtHoTenKhachHang.Text.Trim();
            filter.DiaChi = txtDiaChi.Text.Trim();
            filter.CMND = txtCMND.Text.Trim();
            filter.DienThoai = txtDienThoai.Text.Trim();
            filter.GhiChu = txtGhiChu.Text.Trim();
            filter.UserName = CommonFuns.Instance.GetUserName();//"chkCuaToi.Checked ? nguoiDung.TenDangNhap : "";
            filter.IdNhanVien = nguoiDung.IdNhanVien;
            //filter.Draft = Common.IntValue(lueDraft.EditValue);

            return filter;
        }

        protected override void RefreshDataSource()
        {
            gListChungTu.RefreshDataSource();

            if (gvListChungTu.RowCount > 0)

                gvListChungTu.FocusedRowHandle = 0;

            grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + DataSource.Count + " phiếu)";
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
            if (rowHandle < 0) return;
            ChungTuBanHangBCInfor ct = (ChungTuBanHangBCInfor)gvListChungTu.GetRow(rowHandle);

            if (ct != null)
            {
                frmBC_GiaoNhan_ChiTiet frm = new frmBC_GiaoNhan_ChiTiet(ct.ListIdChungTu, ct.IdGiaoNhan);
                frm.ShowDialog();
            }
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
            //Common.DevExport2Excel(gvListChungTu, "BCGiaoNhan");
            Common.Export2ExcelFromDevGrid<ChungTuBanHangBCInfor>(gvListChungTu, "BCGiaoNhan");
        }

        private void gvListChungTu_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            ChungTuBanHangBCInfor ct = (ChungTuBanHangBCInfor)gvListChungTu.GetRow(e.RowHandle);
            if (ct != null)
            {
                if (e.Column.FieldName.Equals("TinhTrangGiaoNhan"))
                {
                    if (ct.TinhTrangGiaoNhan == -1)
                    {
                        e.Appearance.BackColor = tsslChuaPC.BackColor;
                        e.Appearance.ForeColor = tsslChuaPC.ForeColor;
                    }                        
                    else if (ct.TinhTrangGiaoNhan == 0)
                    {
                        e.Appearance.BackColor = tsslDaPhanCong.BackColor;
                        e.Appearance.ForeColor = tsslDaPhanCong.ForeColor;
                    }  
                    else if (ct.TinhTrangGiaoNhan == 1)
                    {
                        e.Appearance.BackColor = tsslDangGiaoHang.BackColor;
                        e.Appearance.ForeColor = tsslDangGiaoHang.ForeColor;
                    }  
                    else if (ct.TinhTrangGiaoNhan == 2)
                    {
                        e.Appearance.BackColor = tsslDaGiaoXong.BackColor;
                        e.Appearance.ForeColor = tsslDaGiaoXong.ForeColor;
                    }  
                    else if (ct.TinhTrangGiaoNhan == 3)
                    {
                        e.Appearance.BackColor = tsslHuyClr.BackColor;
                        e.Appearance.ForeColor = tsslHuyClr.ForeColor;
                    }  
                    else if (ct.TinhTrangGiaoNhan == 4)
                    {
                        e.Appearance.BackColor = tsslNLaiClr.BackColor;
                        e.Appearance.ForeColor = tsslNLaiClr.ForeColor;
                    }  
                }
                if (e.Column.FieldName.Equals("DaPhanDon"))
                {
                    if (ct.DaPhanDon == (int)TrangThaiPhanDonGiaoNhan.CHUA_PHAN_DON)
                    {
                        e.Appearance.BackColor = tsslChuaPC.BackColor;
                        e.Appearance.ForeColor = tsslChuaPC.ForeColor;
                    }  
                    else if (ct.DaPhanDon == (int)TrangThaiPhanDonGiaoNhan.TU_CHOI_PHAN_DON)
                    {
                        e.Appearance.BackColor = tsslHuyClr.BackColor;
                        e.Appearance.ForeColor = tsslHuyClr.ForeColor;
                    }  
                }                
            }
        }

        private void cmsChiTietGN_Click(object sender, EventArgs e)
        {
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTuBanHangBCInfor ct = (ChungTuBanHangBCInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
            if (ct != null)
            {
                if (ct.TinhTrangGiaoNhan != -1)
                {
                    frmBC_GiaoNhan_ChiTiet frm = new frmBC_GiaoNhan_ChiTiet(ct.ListIdChungTu, ct.IdGiaoNhan);
                    frm.ShowDialog();                    
                }
                else
                {
                    ChungTuBanHangInfor ctu = BanHangDataProvider.Instance.LoadChungTuById(ct.IdChungTu);
                    frmBH_ViewDonHangBan frm = new frmBH_ViewDonHangBan(ctu);
                    frm.ShowDialog();
                }
            }
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

        private void cmsInPhieuGN_Click(object sender, EventArgs e)
        {
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTuBanHangBCInfor ct = (ChungTuBanHangBCInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
            CommonFuns.Instance.InPhieuGiaoNhan(ct);
        }
    }
}