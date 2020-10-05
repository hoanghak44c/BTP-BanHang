using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.KhoHang.Infors;
using QLBH.Common;
using QLBH.Common.Providers;

namespace QLBanHang.Modules.BanHang.Reports
{
    public partial class rpt_BC_DeNghiDoiMa : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_BC_DeNghiDoiMa()
        {
            InitializeComponent();
        }
        public rpt_BC_DeNghiDoiMa(HoaDonPCGNInfo hd)
        {
            InitializeComponent();
            //this.frm = frm;
            lblSoChungTu.Text = hd.SoChungTu;
            lblNgayLap.Text = String.Format("Ngày {0} tháng {1} năm {2}", hd.NgayLap.Day, hd.NgayLap.Month,
                                            hd.NgayLap.Year);
            lblKhachHang.Text = hd.KhachHang;
            lblHoTen.Text = hd.HoTen;
            lblCongTy.Text = hd.CongTy;
            lblDiaChiHD.Text = hd.DiaChiHoaDon;
            lblDiaChiGH.Text = hd.DiaChiGiaoHang;
            lblDienThoai.Text = hd.DienThoai;
            lblHinhThucTT.Text = hd.HinhThucThanhToan;
            lblKhoXuat.Text = hd.KhoXuat;
            lblCachGiaoHang.Text = hd.CachGiaoHang;
            lblTienChu.Text = Common.ReadNumner_(Common.Double2Str(hd.TongTienHang));
            lblTongTien.Text = Common.Double2Str(hd.TongTienHang);
            lblTienThucTra.Text = Common.Double2Str(hd.TienThanhToanThuc);
            lblTienConNo.Text = Common.Double2Str(hd.TienConNo);

            lblGhiChu.Text = hd.GhiChu;
            lblSoHoaDon.Text = hd.SoHoaDon;
            lblNguoiLap.Text = hd.NguoiLap;
            lblNVKD.Text = hd.NhanVienKinhDoanh;
        }
    }
}
