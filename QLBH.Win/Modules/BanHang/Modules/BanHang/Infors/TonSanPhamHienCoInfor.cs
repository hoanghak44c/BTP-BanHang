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
    public class TonSanPhamHienCoInfor
    {
        public int IdSanPham { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string DonViTinh { get; set; }
        public string Kho { get; set; }
        public string MaKho { get; set; }
        public int IdKho { get; set; }
        public string TrungTam { get; set; }
        public int IdTrungTam { get; set; }
        public int TonThat { get; set; }
        public int TonAo { get; set; }
        public string LinhVuc { get; set; }
        public string Nganh { get; set; }
        public string Loai { get; set; }
        public string Chung { get; set; }
        public string Nhom { get; set; }
        public string Hang { get; set; }
        public string Model { get; set; } 
        public string LoaiSanPham { get; set; }
        public int TonTrungChuyen { get; set; }
    }
}
