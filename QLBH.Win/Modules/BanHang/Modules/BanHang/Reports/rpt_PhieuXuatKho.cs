using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using QLBanHang.Modules.BanHang.Infors;
using QLBH.Common.Providers;
using QLBH.Core.Data;

namespace QLBanHang.Modules.BanHang.Reports
{
    public partial class rpt_PhieuXuatKho : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_PhieuXuatKho(ChungTuBanHangInfor hoadon)
        {
            InitializeComponent();
            txtNguoiMua.Text = hoadon.HoTen;
            txtDiaChi.Text = hoadon.DiaChiHoaDon;
            txtSoPhieu.Text = hoadon.SoChungTu;
            txtNgay.Text = string.Format("{0:dd/MM/yyyy}", hoadon.NgayLap);
            lblSoHD.Text = hoadon.SoSeri;
            lblCongTy.Text = hoadon.CongTy;
            lblKhoXuat.Text = hoadon.MaKho;
            lblNVBH.Text = hoadon.TenNhanVien;
            lblPBTest.Visible = ConnectionUtil.Instance.IsUAT != 1 ? true : false;
        }
        public rpt_PhieuXuatKho(ChungTuBanHangInfor hoadon, string sophieuxuat)
        {
            InitializeComponent();
            txtNguoiMua.Text = hoadon.HoTen;
            txtDiaChi.Text = hoadon.DiaChiHoaDon;
            lblSoChungTu.Text = hoadon.SoChungTu;
            txtSoPhieu.Text = sophieuxuat;
            txtNgay.Text = string.Format("{0:dd/MM/yyyy}", hoadon.NgayLap);
            lblSoHD.Text = hoadon.SoSeri;
            lblCongTy.Text = hoadon.CongTy;
            lblKhoXuat.Text = hoadon.MaKho;
            lblNVBH.Text = hoadon.TenNhanVien;
            lblPBTest.Visible = ConnectionUtil.Instance.IsUAT != 1 ? true : false;
        }

    }
}
