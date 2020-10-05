using System;
using System.Collections.Generic;
using QLBH.Common;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;

namespace QLBanHang.Modules.BanHang
{
    public class frmBH_ListDonHangDatTruoc : frmBH_ListChungTuBase
    {
        #region Declaration
        #endregion

        #region Constructor
        public frmBH_ListDonHangDatTruoc()
        {
            Common.LoadStyle(this);
            this.Text = Common.GetEnumInfor(LoaiGiaoDichBanHang.LAP_DONHANG_DATTRUOC);
            Common.SetEDControl(false, false, tsslChuaDuyet, tsslChuaDuyetClr);
            tsslTuChoi.Text = "Chưa xác nhận đơn hàng bán";
        }
        #endregion

        #region Event
        protected override bool GetFromAction()
        {
            return Common.GetFormStatus("frmBH_LapDonHangBanDatTruoc");
        }
        protected override void AddChungTuInstance()
        {
            //if (!Common.IsOpenForm("frmBH_LapDonHangBanDatTruoc"))
            //{
            //    frmBH_LapDonHangBanDatTruoc frm = new frmBH_LapDonHangBanDatTruoc();
            //    frm.Show();
            //}
            Common.SetFormStatus("frmBH_LapDonHangBanDatTruoc", false);
            frmBH_LapDonHangBanDatTruoc frm = new frmBH_LapDonHangBanDatTruoc();
            frm.ShowDialog();
        }

        protected override void EditChungTuInstance(ChungTuBanHangInfor ct)
        {
            //if (!Common.IsOpenForm("frmBH_LapDonHangBanDatTruoc"))
            //{
            //    frmBH_LapDonHangBanDatTruoc frm = new frmBH_LapDonHangBanDatTruoc(ct);
            //    frm.Show();
            //}
            Common.SetFormStatus("frmBH_LapDonHangBanDatTruoc", false);
            frmBH_LapDonHangBanDatTruoc frm = new frmBH_LapDonHangBanDatTruoc(ct);
            frm.ShowDialog();
        }

        #endregion
        #region Data
        protected override List<TrangThaiBH> GetListTrangThaiDonHang()
        {
            return Common.GetListTrangThaiDonHang(LoaiGiaoDichBanHang.LAP_DONHANG_DATTRUOC);
        }
        protected override List<ChungTuBanHangInfor> LoadAllChungTuInstances(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien)
        {
            return BanHangDataProvider.Instance.LoadAllChungTuDatTruocHangMua(nguoiDung.TenDangNhap, idTrungTam, idKho, idDoiTuong, tuNgay, denNgay, loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien); 
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
                    if (ct.Draft == 1 && ct.TrangThai == (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC)
                    {
                        e.Appearance.BackColor = tsslTuChoiClr.BackColor;
                        e.Appearance.ForeColor = tsslTuChoiClr.ForeColor;
                    }
                    else if (ct.TrangThai == (int)OrderStatus.HUY_DON_HANG_DAT_TRUOC)
                    {
                        e.Appearance.BackColor = tsslHuyClr.BackColor;
                        e.Appearance.ForeColor = tsslHuyClr.ForeColor;
                    }
                }
            }
        }
        #endregion
    }
}
