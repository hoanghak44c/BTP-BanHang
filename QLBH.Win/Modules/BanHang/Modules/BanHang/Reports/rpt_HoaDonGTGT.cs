using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using QLBH.Common.Providers;
using QLBanHang.Modules.BanHang.Infors;
using QLBH.Core.Data;

namespace QLBanHang.Modules.BanHang.Reports
{
    public partial class rpt_HoaDonGTGT : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_HoaDonGTGT(HoaDonGTGTInfo hd)
        {
            InitializeComponent();
            //this.frm = frm;
            lblhoTen.Text = hd.NguoiMuaHang;
            lblKhoHang.Text = hd.KhoXuat;
            lblMaSoThue.Text = hd.MaSoThue;
            lblNhanVien.Text = hd.NhanVien;
            lblTenDonVi.Text = hd.TenDonVi;
            lblDiaChi.Text = hd.DiaChi;
            lblNgay.Text = hd.NgayLap.Day.ToString();
            lblThang.Text = hd.NgayLap.Month.ToString();
            lblNam.Text = hd.NgayLap.Year.ToString();
            lblSoChungTu.Text = hd.SoChungTu;
            lblngay1.Text = hd.NgayLap.Day.ToString();
            lblthang1.Text = hd.NgayLap.Month.ToString();
            lblnam1.Text = hd.NgayLap.Year.ToString();
            lbltien.Text = hd.SoTienChu;
            lblNguoiLap.Text = hd.NguoiLap;

            lblTongTienChuaVAT.Text = String.IsNullOrEmpty(hd.TongTienChuaVAT)
                                          ? hd.TongTienChuaVAT
                                          : String.Format("{0:0,0}", Convert.ToDouble(hd.TongTienChuaVAT));
            lblTongTienVAT.Text = String.IsNullOrEmpty(hd.TongTienVAT)
                                      ? hd.TongTienVAT
                                      : String.Format("{0:0,0}", Convert.ToDouble(hd.TongTienVAT));
            lblTongTienThanhToan.Text = String.IsNullOrEmpty(hd.TongTienThanhToan)
                                            ? hd.TongTienThanhToan
                                            : String.Format("{0:0,0}", Convert.ToDouble(hd.TongTienThanhToan));
            lblTienChuaVAT0.Text = String.IsNullOrEmpty(hd.TongTienChuaVAT0)
                                       ? hd.TongTienChuaVAT0
                                       : String.Format("{0:0,0}", Convert.ToDouble(hd.TongTienChuaVAT0));
            lblTienChuaVAT5.Text = String.IsNullOrEmpty(hd.TongTienChuaVAT5)
                                       ? hd.TongTienChuaVAT5
                                       : String.Format("{0:0,0}", Convert.ToDouble(hd.TongTienChuaVAT5));
            lblTienChuaVAT10.Text = String.IsNullOrEmpty(hd.TongTienChuaVAT10)
                                        ? hd.TongTienChuaVAT10
                                        : String.Format("{0:0,0}", Convert.ToDouble(hd.TongTienChuaVAT10));
            lblTienVAT0.Text = String.IsNullOrEmpty(hd.TongTienVAT0)
                                   ? hd.TongTienVAT0
                                   : String.Format("{0:0,0}", Convert.ToDouble(hd.TongTienVAT0));
            lblTienVAT5.Text = String.IsNullOrEmpty(hd.TongTienVAT5)
                                   ? hd.TongTienVAT5
                                   : String.Format("{0:0,0}", Convert.ToDouble(hd.TongTienVAT5));
            lblTienVAT10.Text = String.IsNullOrEmpty(hd.TongTienVAT10)
                                    ? hd.TongTienVAT10
                                    : String.Format("{0:0,0}", Convert.ToDouble(hd.TongTienVAT10));
            lblTienThucTra.Text = String.IsNullOrEmpty(hd.SoTienThucTra)
                                      ? hd.SoTienThucTra
                                      : String.Format("{0:0,0}", Convert.ToDouble(hd.SoTienThucTra));
            lblTienConNo.Text = String.IsNullOrEmpty(hd.SoTienConNo)
                                    ? hd.SoTienConNo
                                    : String.Format("{0:0,0}", Convert.ToDouble(hd.SoTienConNo)); 

            lblPBTest.Visible = ConnectionUtil.Instance.IsUAT != 1 ? true : false;
        }

        private void xrLabel4_TextChanged(object sender, EventArgs e)
        {
            if (xrLabel4.Text.StartsWith(".00"))

                xrLabel4.Text = xrLabel4.Text.TrimEnd(".00".ToCharArray());
        }
    }
}
