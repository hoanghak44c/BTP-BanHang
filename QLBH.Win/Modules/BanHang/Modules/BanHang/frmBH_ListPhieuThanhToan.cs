using System;
using System.Collections.Generic;
using QLBH.Common;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;

namespace QLBanHang.Modules.BanHang
{
    public class frmBH_ListPhieuThanhToan : frmBH_ListChungTuBase
    {
        #region Declaration
        #endregion

        #region Constructor
        public frmBH_ListPhieuThanhToan()
        {
            Common.LoadStyle(this);
            this.Text = Common.GetEnumInfor(LoaiGiaoDichBanHang.LAP_PHIEUTHU);
            Common.SetEDControl(false, false, tsbAdd);
            Common.SetEDControl(false, false, tsslHuy, tsslHuyClr, tsslTuChoi, tsslTuChoiClr);
            tsslChuaDuyet.Text = "Chưa thu đủ tiền";
        }
        #endregion

        #region Event

        protected override void EditChungTuInstance(ChungTuBanHangInfor ct)
        {
            //if (!Common.IsOpenForm("frmBH_LapPhieuThu"))
            //{
            //    frmBH_LapPhieuThu frm = new frmBH_LapPhieuThu(ct);
            //    frm.Show();
            //}
            frmBH_LapPhieuThu frm = new frmBH_LapPhieuThu(ct);
            frm.ShowDialog();
        }

        #endregion
        #region Data
        protected override List<TrangThaiBH> GetListTrangThaiDonHang()
        {
            return Common.GetListTrangThaiDonHang(LoaiGiaoDichBanHang.LAP_PHIEUTHU);
        }
        protected override List<ChungTuBanHangInfor> LoadAllChungTuInstances(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien)
        {
            if (soKetThuc== -1) liChungTu.Clear();

            return BanHangDataProvider.Instance.LoadAllChungTuCanThuTien(nguoiDung.TenDangNhap, idTrungTam, idKho, idDoiTuong, tuNgay, denNgay, loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien); 
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
        }

        protected override void SetListChungTuStatus(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(e.RowHandle);
            if (ct != null)
            {
                if (e.Column.FieldName.Equals("TrangThai"))
                {
                    if (ct.TienConNo > 0)
                    {
                        e.Appearance.BackColor = tsslChuaDuyetClr.BackColor;
                        e.Appearance.ForeColor = tsslChuaDuyetClr.ForeColor;
                    }
                }
            }
        }
        #endregion 
    }
}
