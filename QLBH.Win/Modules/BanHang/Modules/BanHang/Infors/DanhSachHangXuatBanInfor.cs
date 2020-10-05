using System;
using System.Collections.Generic;
using System.Text;
using QLBH.Core.Infors;

// Người tạo: Lê Mạnh Tuấn
// Ngày tạo :
// Ngày sửa cuối:

namespace QLBanHang.Modules.BanHang.Infors
{
    public class DanhSachHangXuatBanInfor
    {
        public int IdSanPham { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string DonViTinh { get; set; }
        public int SoLuongBan { get; set; }
        public int SoLuongDaXuat { get; set; }
        public int SoLuongChuaXuat { get; set; }
        public int SoLuongDangXuat { get; set; }
        public int TrungMaVach { get; set; }
        public int ChietKhau { get; set; }
    }
}
