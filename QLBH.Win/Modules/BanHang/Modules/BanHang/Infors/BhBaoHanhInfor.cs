using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class BhBaoHanhInfor
    {
        public int IdBaoHanh { get; set; }
        public string SerialNumber { get; set; }
        public int IdPhieuXuat { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string GhiChu { get; set; }
        public DateTime NgayMua { get; set; }
        public int IdKhoXuat { get; set; }
        public string TenKhoXuat { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public int IdDoiTuong { get; set; }
        public int IdSanPham { get; set; }
        public int IdLoaiSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string TenLoaiSanPham { get; set; }
        public string SoChungTu { get; set; }
        public string MaSanPham { get; set; }
        public DateTime HanNCC { get; set; }
        public string TenDoiTuong { get; set; }
        public int LoaiChungTu { get; set; }
        public double GiaGoc { get; set; }
        public DateTime NgayNhapTA { get; set; }
    }
}
