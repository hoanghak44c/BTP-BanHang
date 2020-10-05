using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QLBH.Core.Infors;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class BangGiaNhapChiTietInfor
    {
        public int IdSanPham { get; set; }

        public string MaSanPham { get; set; }

        public string TenSanPham { get; set; }

        public string DonViTinh { get; set; }

        public double TyLeVAT { get; set; }

        public string LoaiSanPham { get; set; }

        public string NganhHang { get; set; }

        public double GiaNhapHDCuoi { get; set; }

        public double GiaTonKhoBQ { get; set; }

        public double TienChietKhauQK { get; set; }

        public double TyLeLNBQ { get; set; }

        public double SoLuongBanBQ { get; set; }

        public double DungSaiMin { get; set; }

        public double DungSaiMax { get; set; }

        public double DonViDoanhThu { get; set; }

        public double TrongSoDoanhThu { get; set; }

        public double DonViLoiNhuan { get; set; }

        public double TrongSoLoiNhuan { get; set; }

        public double DonViKhoanTon { get; set; }

        public double TrongSoKhoanTon { get; set; }

        public int TonKho { get; set; }

        public double GiaNhapDemoCuoi { get; set; }

        public int HangKhuyenMai { get; set; }
    }





}
