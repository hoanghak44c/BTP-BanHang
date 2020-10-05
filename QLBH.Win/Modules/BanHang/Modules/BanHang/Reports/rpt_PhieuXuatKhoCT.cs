using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using QLBanHang.Modules.BanHang.Infors;
using QLBH.Common.Providers;

namespace QLBanHang.Modules.BanHang.Reports
{
    public partial class rpt_PhieuXuatKhoCT : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_PhieuXuatKhoCT(ChungTuBanHangInfor hoadon)
        {
            InitializeComponent();
            //txtNguoiMua.Text = hoadon.HoTen;
            //txtDiaChi.Text = hoadon.DiaChiHoaDon;
            //txtSoPhieu.Text = hoadon.SoChungTu;
            //txtNgay.Text = string.Format("{0:dd/MM/yyyy}", hoadon.NgayLap);
            //xrLabel26.Text = hoadon.SoSeri;
            //lblCongTy.Text = hoadon.CongTy;
        }
    }
}
