using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class BangGiaNhomNguoiDuyetInfor
    {
        public string MaSanPham { get; set; }
        public double DonGiaChuaVat { get; set; }
        public double GiaNhapHDCuoi { get; set; }
        public double TienChietKhauQK { get; set; }
        public double TienKhuyenMai { get; set; }
        public double TyLeLNBQ { get; set; }
        public int IdNhomNguoiDung { get; set; }
        public string TenNhomNguoiDung { get; set; }
    }
}
