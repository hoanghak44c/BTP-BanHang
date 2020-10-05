using System;
using System.Collections.Generic;
using System.Text;
using QLBH.Core.Infors;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class BangGiaHangKhuyenMaiChiTietInfor
    {
        public int IdChiTiet { get; set; }

        public int IdKhuyenMai { get; set; }

        public int IdSanPham { get; set; }

        public string MaSanPham { get; set; }

        public string TenSanPham { get; set; }

        public string DonViTinh { get; set; }

        public int SoLuongKM { get; set; }

        public double SoTienCK { get; set; }

        public double TyLeCK { get; set; }

        public int DuHang { get; set; }

        public int TrungMaVach { get; set; }

        public int ChietKhau { get; set; }

        public int HetTonDungKM { get; set; }

        public int SuDung { get; set; }
    }
}
