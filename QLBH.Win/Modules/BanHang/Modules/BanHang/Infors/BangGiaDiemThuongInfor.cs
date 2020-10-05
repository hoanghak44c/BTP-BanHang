using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class BangGiaDiemThuongInfor
    {
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public string MaNganhHang { get; set; }
        public string TenNganhHang { get; set; }
        public string MaLinhVuc { get; set; }
        public string TenLinhVuc { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public double TyLeThuongTu { get; set; }
        public double TyLeThuongDen { get; set; }
    }
}
