using System;
using System.Collections.Generic;
using System.Text;
using QLBH.Core.Infors;

// Người tạo: Lê Mạnh Tuấn
// Ngày tạo :
// Ngày sửa cuối:

namespace QLBanHang.Modules.BanHang.Infors
{
    public class HangBanGiaoNhanChiTietInfor
    {
        public string KhachHang { get; set; }
        public int LoaiChungTu { get; set; }
        public DateTime NgayLap { get; set; }
        public DateTime NgayHenGiaoHang { get; set; }
        public int IdChungTu { get; set; }
        public string SoChungTu { get; set; }
        public int IdChungTuChiTiet { get; set; }
        public int IdSanPham { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int IdSanPhamBan { get; set; }
        public string TenSanPhamBan { get; set; }
        public string LoaiHangHoa { get; set; }
        public string DonViTinh { get; set; }
        public int SoLuong { get; set; }
        public int TrungMaVach { get; set; }
        public double DonGia { get; set; }
        public double TyLeVAT { get; set; }
        public double TienVAT { get; set; }
        public double ThanhTien { get; set; }

    }
}
