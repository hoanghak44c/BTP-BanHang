using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class BangGiaChiTietLichSuInfor
    {
        public int IdLichSu { get; set; }
        public int IdChiTietBangGia { get; set; }
        public int IdTrungTam { get; set; }
        public int IdSanPham { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string MaDonViTinh { get; set; }
        public string TenDonViTinh { get; set; }
        public double GiaNhapHDCuoi { get; set; }
        public double GiaNhapDemoCuoi { get; set; }
        public double GiaTonKhoBQ { get; set; }
        public double DonGiaChuaVAT { get; set; }
        public double TyLeVAT { get; set; }
        public double TienVAT { get; set; }
        public double DonGiaCoVAT { get; set; }
        public double GiaBanBuon { get; set; }
        public double GiaBanDemo { get; set; }
        public double TyLeThuong { get; set; }
        public double ThuongNong { get; set; }
        public int TrungMaVach { get; set; }
        public int ChietKhau { get; set; }
        public double GiaNiemYet { get; set; }
        public double GiaWebSite { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public string LinhVuc { get; set; }
        public string Nganh { get; set; }
        public string Loai { get; set; }
        public string Chung { get; set; }
        public string Nhom { get; set; }
        public string Hang { get; set; }
        public string Model { get; set; }
    }

}
