using System;
using System.Collections.Generic;
using QLBH.Common;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;

namespace QLBanHang.Modules.BanHang
{
    public class frmBH_ListDonHangOnline : frmBH_ListChungTuBase
    {
        #region Declaration
        #endregion

        #region Constructor
        public frmBH_ListDonHangOnline()
        {
            Common.LoadStyle(this);
            this.Text = Common.GetEnumInfor(LoaiGiaoDichBanHang.LAP_DONHANG_ONLINE);
            tsslChuaDuyet.Text = "Từ chối duyệt đơn hàng  Online";
            tsslTuChoi.Text = "Chưa xác nhận đơn hàng Online";
        }
        #endregion

        #region Event
        protected override bool GetFromAction()
        {
            return Common.GetFormStatus("frmBH_LapDonHangBanOnline");
        }

        protected override void AddChungTuInstance()
        {
            //if (!Common.IsOpenForm("frmBH_LapDonHangBanOnline"))
            //{
            //    frmBH_LapDonHangBanOnline frm = new frmBH_LapDonHangBanOnline();
            //    frm.Show();
            //}
            Common.SetFormStatus("frmBH_LapDonHangBanOnline", false);
            frmBH_LapDonHangBanOnline frm = new frmBH_LapDonHangBanOnline();
            frm.Show();
        }

        protected override void EditChungTuInstance(ChungTuBanHangInfor ct)
        {
            //if (!Common.IsOpenForm("frmBH_LapDonHangBanOnline"))
            //{
            //    frmBH_LapDonHangBanOnline frm = new frmBH_LapDonHangBanOnline(ct);
            //    frm.Show();
            //}
            Common.SetFormStatus("frmBH_LapDonHangBanOnline", false);
            frmBH_LapDonHangBanOnline frm = new frmBH_LapDonHangBanOnline(ct);
            frm.ShowDialog();
        }

        #endregion
        #region Data
        protected override List<TrangThaiBH> GetListTrangThaiDonHang()
        {
            return Common.GetListTrangThaiDonHang(LoaiGiaoDichBanHang.LAP_DONHANG_ONLINE);
        }
        protected override List<ChungTuBanHangInfor> LoadAllChungTuInstances(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien)
        {
            return BanHangDataProvider.Instance.LoadAllChungTuDatHangOnline(userName, idTrungTam, idKho, idDoiTuong, tuNgay, denNgay, loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien);
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
                    if (ct.TrangThai == (int)OrderStatus.REJECT_DON_HANG_ONLINE)
                    {
                        e.Appearance.BackColor = tsslChuaDuyetClr.BackColor;
                        e.Appearance.ForeColor = tsslChuaDuyetClr.ForeColor;
                    }
                    else if (ct.Draft == 1 && ct.TrangThai == (int)OrderStatus.TAO_DON_HANG_ONLINE)
                    {
                        e.Appearance.BackColor = tsslTuChoiClr.BackColor;
                        e.Appearance.ForeColor = tsslTuChoiClr.ForeColor;
                    }
                    else if (ct.TrangThai == (int)OrderStatus.HUY_DON_HANG_ONLINE)
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
