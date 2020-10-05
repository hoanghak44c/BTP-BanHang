using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.KhoHang.Infors;
using QLBH.Common;
using QLBH.Common.Providers;
using QLBH.Core.Data;

namespace QLBanHang.Modules.BanHang.Reports
{
    public partial class rpt_BC_PhieuDoiMaVach : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_BC_PhieuDoiMaVach()
        {
            InitializeComponent();
        }
        public rpt_BC_PhieuDoiMaVach(HoaDonPCGNInfo hd)
        {
            InitializeComponent();
            //this.frm = frm;
            lblKhachHang.Text = hd.KhachHang;
            lblHoTen.Text = hd.HoTen;
            lblDienThoai.Text = hd.DienThoai;
            lblCongTy.Text = hd.CongTy;
            lblMaSoThue.Text = hd.HinhThucThanhToan;
            lblDiaChiHD.Text = hd.DiaChiHoaDon;
            lblDiaChiGH.Text = hd.DiaChiGiaoHang;

            lblNgayLap.Text = String.Format("Ngày {0} tháng {1} năm {2}", hd.NgayLap.Day, hd.NgayLap.Month,
                                            hd.NgayLap.Year);
            lblSoChungTu.Text = hd.SoChungTuGoc;
            lblSoHoaDon.Text = hd.SoHoaDon;
            lblNgayBan.Text = String.Format("{0}/{1}/{2}", hd.NgayBan.Day, hd.NgayBan.Month,
                                            hd.NgayBan.Year);
            lblKhoXuat.Text = hd.KhoXuat;
            lblSoPhieuNhapLai.Text = hd.SoChungTu;
            lblKhoNhap.Text = hd.MaKhoNhapLai;
            lblTenKhoNhapLai.Text = hd.TenKhoNhapLai;
            lblLyDoNhap.Text = hd.LyDoNhapLai;
            lblGhiChu.Text = hd.GhiChu;
            //lblCachGiaoHang.Text = hd.CachGiaoHang;

            //lblTienChu.Text = Common.ReadNumner_(Common.Double2Str(hd.TongTienHang));
            //lblTongTien.Text = Common.Double2Str(hd.TongTienHang);
            //lblTienThucTra.Text = Common.Double2Str(hd.TienThanhToanThuc);
            //lblTienConNo.Text = Common.Double2Str(hd.TienConNo);

            lblVNVienKDoanh.Text = hd.NhanVienKinhDoanh;
            lblPBTest.Visible = ConnectionUtil.Instance.IsUAT != 1 ? true : false;
        }
    }
}
