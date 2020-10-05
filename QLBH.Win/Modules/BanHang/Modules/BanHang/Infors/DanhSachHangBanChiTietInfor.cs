using System;
using System.Collections.Generic;
using System.Text;
using QLBH.Core.Infors;

// Người tạo: Lê Mạnh Tuấn
// Ngày tạo :
// Ngày sửa cuối:

namespace QLBanHang.Modules.BanHang.Infors
{
    public class DanhSachHangBanChiTietInfor
    {
        public int IdChiTietChungTu { get; set; }

        public int IdSanPham { get; set; }

        public string MaSanPham { get; set; }

        public string TenSanPham { get; set; }

        public int IdSanPhamBan { get; set; }

        public string TenSanPhamBan { get; set; }

        public string LoaiHangHoa { get; set; }

        public int TypeHangHoa { get; set; }

        public string DonViTinh { get; set; }

        public int SoLuongBan { get; set; }

        public int SoLuongXuat { get; set; }

        public int TrungMaVach { get; set; }

        public int ChietKhau { get; set; }
    }
}
