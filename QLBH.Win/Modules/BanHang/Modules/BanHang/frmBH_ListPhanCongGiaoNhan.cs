using System;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;
using QLBH.Common;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;

namespace QLBanHang.Modules.BanHang
{
    public class frmBH_ListPhanCongGiaoNhan : frmBH_ListChungTuBase
    {
        #region Declaration
        #endregion

        #region Constructor
        public frmBH_ListPhanCongGiaoNhan()
        {
            Common.LoadStyle(this);
            this.Text = Common.GetEnumInfor(LoaiGiaoDichBanHang.PHANCONG_GIAONHAN);
            Common.SetEDControl(false, false, tsbAdd);
            tsslChuaDuyet.Text = "Từ chối đơn hàng giao nhận";
            tsslTuChoi.Text = "Chưa xác nhận phân công giao nhận";
        }
        #endregion

        #region Event
        protected override bool GetFromAction()
        {
            return Common.GetFormStatus("frmBH_LapDonHangGiaoNhan");
        }
        protected override void EditChungTuInstance(ChungTuBanHangInfor ct)
        {
            //if (!Common.IsOpenForm("frmBH_LapDonHangGiaoNhan"))
            //{
                List<ChungTuBanHangInfor> liPCGN = new List<ChungTuBanHangInfor>();
                if (selector.selection.Count > 0)
                {
                    foreach (ChungTuBanHangInfor tt in selector.selection)
                    {
                        if (String.IsNullOrEmpty(tt.SoSeri))
                        {
                            MessageBox.Show("Đơn hàng " + tt.SoChungTu + " chưa xuất hóa đơn. Chỉ xem không phân công giao nhận được");
                            return;                                                
                        }
                        if (Declare.GiaoNhanCungKhachHang && liPCGN.Exists(delegate(ChungTuBanHangInfor h)
                        {
                            return !tt.HoTen.Equals(h.HoTen) || !tt.DiaChiGiaoHang.Equals(h.DiaChiGiaoHang);
                        }))
                        {
                            MessageBox.Show("Hệ thống chỉ cho phép phân công cho các đơn hàng của cùng khách hàng");
                            return;
                        }
                        else if (String.IsNullOrEmpty(tt.SoSeri))
                        {
                            MessageBox.Show("Đơn hàng " + tt.SoChungTu + " chưa xuất hóa đơn. Chỉ xem không phân công giao nhận được");
                            return;                            
                        }
                        else
                        {
                            liPCGN.Add(tt);
                        }
                    }
                }
                else if (String.IsNullOrEmpty(ct.SoSeri))
                {
                    MessageBox.Show("Đơn hàng " + ct.SoChungTu + " chưa xuất hóa đơn. Chỉ xem không phân công giao nhận được");
                    return;                                                
                }
                else
                    liPCGN.Add(ct);
                Common.SetFormStatus("frmBH_LapDonHangGiaoNhan", false);
                frmBH_LapDonHangGiaoNhan frm = new frmBH_LapDonHangGiaoNhan(true, liPCGN);
                frm.ShowDialog();
                //frm.Show();
            //}
        }

        #endregion
        #region Data
        protected override void InitLoadForm()
        {
            dteStart.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            dteStart.Properties.EditFormat.FormatString = "dd/MM/yyyy HH:mm";
            dteStart.Properties.EditMask = "dd/MM/yyyy HH:mm";
            dteStart.EditValue = null;

            dteEnd.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            dteEnd.Properties.EditFormat.FormatString = "dd/MM/yyyy HH:mm";
            dteEnd.Properties.EditMask = "dd/MM/yyyy HH:mm";
            dteEnd.EditValue = null;            
        }
        protected override bool IsShowSelector()
        {
            return true;
        }
        protected override List<TrangThaiBH> GetListTrangThaiDonHang()
        {
            return Common.GetListTrangThaiDonHang(LoaiGiaoDichBanHang.PHANCONG_GIAONHAN);
        }
        protected override List<ChungTuBanHangInfor> LoadAllChungTuInstances(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien)
        {
            return BanHangDataProvider.Instance.LoadAllChungTuPhanCongGiaoNhan(userName, idTrungTam, idKho, idDoiTuong, tuNgay, denNgay, loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien, -1); 
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
                    if (ct.TrangThai == (int)OrderStatus.REJECT_DON_HANG_GIAO_NHAN)
                    {
                        e.Appearance.BackColor = tsslChuaDuyetClr.BackColor;
                        e.Appearance.ForeColor = tsslChuaDuyetClr.ForeColor;
                    }
                    else if (ct.Draft == 1 && ct.TrangThai == (int)OrderStatus.PHAN_CONG_GIAO_NHAN)
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
