using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using QLBanHang.Modules.BanHang.Infors;
using QLBH.Common;
using QLBH.Core.Data;

namespace QLBanHang.Modules.BanHang.Reports
{
    public partial class rpt_PhieuThuTien : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_PhieuThuTien(ChungTuThanhToanInfor tt, string trungTam, string hangHoa, double tongTienDonHang, double tienConNo)
        {
            InitializeComponent();
            lblSoPhieu.Text = tt.SoPhieu;
            lblNguoiNopTien.Text = tt.HoTen;
            lblNgayLap.Text = Common.Date2String(tt.NgayLap);
            lblDienThoai.Text = tt.DienThoai;
            lblDiaChi.Text = tt.DiaChi;
            lblTongTien.Text = Common.Double2Str(tt.SoTienThanhToan);
            lblTongTienChu.Text = tt.SoTienChu;
            lblNoiDungNop.Text = tt.NoiDungThanhToan;
            lblSoChungTuGoc.Text = tt.SoChungTuGoc;
            lblSoTienNhan.Text = Common.Double2Str(tt.SoTienThanhToan);
            lblTKQuy.Text = tt.TaiKhoanQuy;
            lblNguoiLap.Text = tt.TenThuNgan;
            lblTrungTam.Text = trungTam;
            lblHangHoa.Text = hangHoa;
            lblPBTest.Visible = ConnectionUtil.Instance.IsUAT != 1 ? true : false;
            lblTongTienDonHang.Text = Common.Double2Str(tongTienDonHang);
            lblTienConNo.Text = Common.Double2Str(tienConNo);
        }
    }
}
