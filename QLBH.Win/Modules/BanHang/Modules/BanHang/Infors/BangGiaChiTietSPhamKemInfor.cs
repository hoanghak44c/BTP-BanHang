using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.KhoHang.Infors;
using QLBH.Core.Infors;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class BangGiaChiTietSPhamKemInfor
    {
        public int IdChiTietBangGia { get; set; }

        public int IdSanPham { get; set; }

        public string MaSanPham { get; set; }

        public string TenSanPham { get; set; }

        public string DonViTinh { get; set; }

        public int SoLuong { get; set; }

        public double PhanBoKhuyenMai { get; set; }
    }
}
