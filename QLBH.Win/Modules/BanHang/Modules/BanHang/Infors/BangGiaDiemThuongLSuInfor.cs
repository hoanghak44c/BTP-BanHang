using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class BangGiaDiemThuongLSuInfor
    {
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public string MaNganhHang { get; set; }
        public string TenNganhHang { get; set; }
        public string MaLinhVuc { get; set; }
        public string TenLinhVuc { get; set; }
        public double TyLeThuongTu { get; set; }
        public double TyLeThuongDen { get; set; }
        public string HanhDong { get; set; }
        public DateTime NgayCapNhat { get; set; }
    }
}
