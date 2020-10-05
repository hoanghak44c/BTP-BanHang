using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QLBH.Common;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;

namespace QLBanHang.Modules.BanHang
{
    public class frmBH_ListDonHangBanTheTVien : frmBH_ListChungTuBase
    {
        #region Declaration
        private bool XuatBuKhuyenMai = false;
        #endregion

        #region Constructor
        public frmBH_ListDonHangBanTheTVien()
        {
            Common.LoadStyle(this);
        }
        public frmBH_ListDonHangBanTheTVien(bool xuatBuKhuyenMai)
        {
            Common.LoadStyle(this);            
            this.XuatBuKhuyenMai = xuatBuKhuyenMai;

            if (XuatBuKhuyenMai)
                this.Text = Common.GetEnumInfor(LoaiGiaoDichBanHang.XUAT_BU_KHUYEN_MAI);
            else
                this.Text = Common.GetEnumInfor(LoaiGiaoDichBanHang.LAP_DONHANG_BAN);

            tsslChuaDuyet.Text = "Chưa chuyển đơn hàng bán";
            tsslTuChoi.Text = "Chưa xác nhận đơn hàng bán";
        }
        #endregion

        #region Event
        protected override bool GetFromAction()
        {
            if (XuatBuKhuyenMai)
                return Common.GetFormStatus("frmBH_LapDonHangBanKhuyenMai");
            else
                return Common.GetFormStatus("frmBH_LapDonHangBanTheTVien");
        }
        protected override void AddChungTuInstance()
        {
            //if (!Common.IsOpenForm("frmBH_LapDonHangBan"))
            //{
            //    frmBH_LapDonHangBan frm = new frmBH_LapDonHangBan();
            //    frm.Show();                                
            //}
            if (XuatBuKhuyenMai)
            {
                Common.SetFormStatus("frmBH_LapDonHangBanKhuyenMai", false);
                frmBH_LapDonHangBanKhuyenMai frm = new frmBH_LapDonHangBanKhuyenMai();
                frm.ShowDialog();                
            }
            else
            {
                Common.SetFormStatus("frmBH_LapDonHangBanTheTVien", false);
                frmBH_LapDonHangBanTheTVien frm = new frmBH_LapDonHangBanTheTVien();
                frm.ShowDialog();                 
            }
        }

        protected override void EditChungTuInstance(ChungTuBanHangInfor ct)
        {
            if (ct.LoaiChungTu == (int)TransactionType.DON_HANG_BU_KHUYEN_MAI)
            {
                //if (!Common.IsOpenForm("frmBH_LapDonHangBanKhuyenMai"))
                //{
                //    frmBH_LapDonHangBanKhuyenMai frm = new frmBH_LapDonHangBanKhuyenMai(ct);
                //    frm.Show();
                //}
                Common.SetFormStatus("frmBH_LapDonHangBanKhuyenMai", false);
                frmBH_LapDonHangBanKhuyenMai frm = new frmBH_LapDonHangBanKhuyenMai(ct);
                frm.ShowDialog();              
            }
            else
            {
                //if (!Common.IsOpenForm("frmBH_LapDonHangBan"))
                //{
                //    frmBH_LapDonHangBan frm = new frmBH_LapDonHangBan(ct);
                //    frm.Show();
                //}
                Common.SetFormStatus("frmBH_LapDonHangBanTheTVien", false);
                frmBH_LapDonHangBanTheTVien frm = new frmBH_LapDonHangBanTheTVien(ct);
                frm.ShowDialog();                 
            }
        }

        #endregion
        #region Data
        protected override List<TrangThaiBH> GetListTrangThaiDonHang()
        {
            return Common.GetListTrangThaiDonHang(LoaiGiaoDichBanHang.LAP_DONHANG_BAN);
        }
        protected override List<ChungTuBanHangInfor> LoadAllChungTuInstances(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien)
        {
            if (XuatBuKhuyenMai)
                return BanHangDataProvider.Instance.LoadAllChungTuBuXuatBuKhuyenMai(nguoiDung.TenDangNhap, idTrungTam, idKho, idDoiTuong, tuNgay, denNgay, loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien);
            else
                return BanHangDataProvider.Instance.LoadAllChungTuDatHangTaiShop(nguoiDung.TenDangNhap, idTrungTam, idKho, idDoiTuong, tuNgay, denNgay, loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien);
        }
        protected override void setEDFunctions()
        {
            //tsbAdd.Enabled = (ChungTu.IdChungTu > 0) && 
            //                        ChungTu.LoaiChungTu == (int)TransactionType.DON_HANG_TAI_SHOP &&
            //                        ChungTu.TrangThai != (int)OrderStatus.PHAN_CONG_GIAO_NHAN;
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
                    if (ct.TrangThai == (int)OrderStatus.XAC_NHAN_DON_HANG_ONLINE || ct.TrangThai == (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC ||
                        ct.TrangThai == (int)OrderStatus.PHAN_CONG_GIAO_NHAN)
                    {
                        e.Appearance.BackColor = tsslChuaDuyetClr.BackColor;
                        e.Appearance.ForeColor = tsslChuaDuyetClr.ForeColor;
                    }
                    else if (ct.Draft == 1 && (ct.TrangThai == (int)OrderStatus.DON_HANG_BAN_ONLINE || ct.TrangThai == (int)OrderStatus.DON_HANG_BAN_DAT_TRUOC ||
                        ct.TrangThai == (int)OrderStatus.DON_HANG_BAN_TAI_SHOP || ct.TrangThai == (int)OrderStatus.XAC_NHAN_DON_HANG_GIAO_NHAN))
                    {
                        e.Appearance.BackColor = tsslTuChoiClr.BackColor;
                        e.Appearance.ForeColor = tsslTuChoiClr.ForeColor;
                    }
                    else if (ct.TrangThai == (int)OrderStatus.HUY_DON_HANG)
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
