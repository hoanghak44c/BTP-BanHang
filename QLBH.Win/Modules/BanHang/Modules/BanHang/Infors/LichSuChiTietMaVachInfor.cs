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
    public class LichSuChiTietMaVachInfor
    {
        public int IdSanPham { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string MaVach { get; set; }
        public string DonViTinh { get; set; }
        public DateTime Ngay { get; set; }//ngay nhap, ngay thuc hien giao dich
        public string TrangThai { get; set; }
        public string Kho { get; set; }
        public string MaKho { get; set; }
        public string TrungTam { get; set; }
        public string SoChungTu { get; set; }//so chung tu nhap POS
        public string SoSeri { get; set; }//so hoa don hoac so PO
        public string SoChungTuGoc { get; set; }//so phieu nhap Oracle
        public int SoLuong { get; set; }
        public int NgayTon { get; set; }//tuoi ton kho
        public string LinhVuc { get; set; }
        public string Nganh { get; set; }
        public string Loai { get; set; }
        public string Chung { get; set; }
        public string Nhom { get; set; }
        public string Hang { get; set; }
        public string Model { get; set; } 
        public string LoaiSanPham { get; set; }
        public string TenNhaCungCap { get; set; }
        public string LoaiGiaoDich { get; set; }
        public int LoaiChungTu { get; set; }
        public int TrungChuyen { get; set; }
    }
}
