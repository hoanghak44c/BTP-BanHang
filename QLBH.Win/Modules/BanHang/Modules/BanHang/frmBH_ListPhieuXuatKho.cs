using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QLBH.Common;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;

namespace QLBanHang.Modules.BanHang
{
    public class frmBH_ListPhieuXuatKho : frmBH_ListChungTuBase
    {
        #region Declaration
        #endregion

        #region Constructor
        public frmBH_ListPhieuXuatKho()
        {
            Common.LoadStyle(this);
            this.Text = Common.GetEnumInfor(LoaiGiaoDichBanHang.XUATKHO_HANGBAN);
            Common.SetEDControl(false, false, tsbAdd);
            Common.SetEDControl(false, false, tsslHuy, tsslHuyClr);
            tsslChuaDuyet.Text = "Chưa xuất kho";
            tsslTuChoi.Text = "Chưa xác nhận xuất kho";
        }
        #endregion

        #region Event

        protected override void EditChungTuInstance(ChungTuBanHangInfor ct)
        {
            //if (!Common.IsOpenForm("frmBH_XuatKhoHangBan"))
            //{
            //    frmBH_LapPhieuXuatKho frm = new frmBH_LapPhieuXuatKho(ct);
            //    frm.Show();
            //}
            if (String.IsNullOrEmpty(ct.SoSeri))
            {
                MessageBox.Show("Đơn hàng " + ct.SoChungTu + " chưa xuất hóa đơn. Chỉ xem không xuất kho được");
                return;                                                
            }
            frmBH_LapPhieuXuatKho frm = new frmBH_LapPhieuXuatKho(ct);
            frm.ShowDialog();
        }

        #endregion
        #region Data
        protected override List<TrangThaiBH> GetListTrangThaiDonHang()
        {
            return Common.GetListTrangThaiDonHang(LoaiGiaoDichBanHang.XUATKHO_HANGBAN);
        }
        protected override List<ChungTuBanHangInfor> LoadAllChungTuInstances(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien)
        {
            return BanHangDataProvider.Instance.LoadAllChungTuXuatKhoBan(nguoiDung.TenDangNhap, idTrungTam, idKho, idDoiTuong, tuNgay, denNgay, loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien); 
        }

        protected override void setEDFunctions()
        {
            tsbEdit.Enabled = (ChungTu.IdChungTu > 0);/* && (Common.Int2Bool(ChungTu.Draft) &&
                              (ChungTu.TrangThai != (int)OrderStatus.PHAN_CONG_GIAO_NHAN) ||
                              ChungTu.LoaiChungTu == (int)TransactionType.DON_HANG_ONLINE &&
                              (ChungTu.TrangThai == (int)OrderStatus.XAC_NHAN_DON_HANG_ONLINE) ||
                              ChungTu.LoaiChungTu == (int)TransactionType.DON_HANG_DAT_TRUOC &&
                              (ChungTu.TrangThai == (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC));*/
            tsbDelete.Enabled = ChungTu.IdChungTu > 0;// && Common.Int2Bool(ChungTu.Draft);//xoa, huy don hang online, dat truoc
            gListChungTu.ContextMenuStrip.Items.Clear();
            gListChungTu.ContextMenuStrip.Items.Add("Chi tiết đơn hàng", null, btnViewDonHang_Click);
        }

        private void btnViewDonHang_Click(object sender, EventArgs e)
        {
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
            if (ct != null)
            {
                frmBH_ViewDonHangBan frm = new frmBH_ViewDonHangBan(ct);
                frm.ShowDialog();
            }
        }
        protected override void SetListChungTuStatus(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(e.RowHandle);
            if (ct != null)
            {
                if (e.Column.FieldName.Equals("TrangThai"))
                {
                    if (ct.TrangThai != (int)OrderStatus.XUAT_KHO)
                    {
                        e.Appearance.BackColor = tsslChuaDuyetClr.BackColor;
                        e.Appearance.ForeColor = tsslChuaDuyetClr.ForeColor;
                    }
                    else if (ct.Draft == 1 && ct.TrangThai == (int)OrderStatus.XUAT_KHO)
                    {
                        e.Appearance.BackColor = tsslTuChoiClr.BackColor;
                        e.Appearance.ForeColor = tsslTuChoiClr.ForeColor;
                    }
                }
            }
        }
        #endregion 
    }
}
