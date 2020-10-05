using System;
using System.Collections.Generic;
using System.Text;
using QLBH.Core.Infors;

// Người tạo: Lê Mạnh Tuấn
// Ngày tạo :
// Ngày sửa cuối:

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class ChungTuBanHangBCTheoGioInfor
    {
        public string MaTrungTam { get; set; }
        public string TenTrungTam { get; set; }
        public string Thang { get; set; }
        public string Tuan { get; set; }
        public string Thu { get; set; }
        public string Ngay { get; set; }
        public string KhungGio { get; set; }
        public string MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string SoChungTu { get; set; }
        public string SoHoaDon { get; set; }
        public string LinhVuc { get; set; }
        public string NganhHang { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public int SoLuong { get; set; }
        public double ThanhTienTruocVAT { get; set; }
        public double TienVAT { get; set; }
        public double ThanhTienSauVAT { get; set; }
    }
}

