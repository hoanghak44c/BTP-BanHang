using System;
using System.Collections.Generic;
using System.Text;
using QLBH.Core.Infors;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class HoaDonPCGNInfo : ChungTuBaseInfo
    {
        public string SoChungTuGoc { get; set; }
        public DateTime NgayBan { get; set; }
        public string KhachHang { get; set; }
        public string HoTen { get; set; }
        public string CongTy { get; set; }
        public string DiaChiHoaDon { get; set; }
        public string DiaChiGiaoHang { get; set; }
        public string DienThoai { get; set; }
        public string HinhThucThanhToan { get; set; }
        public string MaSoThue { get; set; }
        public string TrungTam { get; set; }
        public string KhoXuat { get; set; }
        public string MaKhoNhapLai { get; set; }
        public string TenKhoNhapLai { get; set; }
        public string CachGiaoHang { get; set; }
        public double TongTienHang { get; set; }
        public double TienThanhToanThuc { get; set; }
        public double TienConNo { get; set; }
        public string SoHoaDon { get; set; }
        public string GhiChu { get; set; }
        public string NguoiLap { get; set; }
        public string NhanVienKinhDoanh { get; set; }
        public string ThuongVien { get; set; }
        public string LyDoNhapLai { get; set; }
    }
}
