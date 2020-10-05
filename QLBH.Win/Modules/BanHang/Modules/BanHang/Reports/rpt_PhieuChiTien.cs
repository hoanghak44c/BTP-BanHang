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
    public partial class rpt_PhieuChiTien : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_PhieuChiTien(ChungTuThanhToanInfor tt)
        {
            InitializeComponent();
            lblSoPhieu.Text = tt.SoPhieu;
            lblNgayLap.Text = Common.Date2String(tt.NgayLap);
            lblNguoiNopTien.Text = tt.HoTen;
            lblDiaChi.Text = tt.DiaChi;
            lblTongTien.Text = Common.Double2Str(tt.SoTienThanhToan);
            lblTongTienChu.Text = tt.SoTienChu;
            lblNoiDungNop.Text = tt.NoiDungThanhToan;
            lblChungTuGoc.Text = tt.SoChungTuGoc;
            lblSoTienNhan.Text = Common.Double2Str(tt.SoTienThanhToan);
            lblTaiKhoanQuy.Text = tt.TaiKhoanQuy;
            lblNguoiLap.Text = tt.TenThuNgan;
            lblPBTest.Visible = ConnectionUtil.Instance.IsUAT != 1 ? true : false;
        }

    }
}
