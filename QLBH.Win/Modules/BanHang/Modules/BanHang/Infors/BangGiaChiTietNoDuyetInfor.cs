using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QLBH.Core.Infors;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class BangGiaChiTietNoDuyetInfor
    {
        public string TenTrungTam { get; set; }
        public string SoBangGia { get; set; }
        public int IdChiTiet { get; set; }
        public int IdBangGia { get; set; }
        public int IdSanPham { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string DonViTinh { get; set; }
        public string LoaiSanPham { get; set; }
        public string NganhHang { get; set; }
        public double GiaNhapHDCuoi { get; set; }
        public double GiaTonKhoBQ { get; set; }
        public double TienChietKhauQK { get; set; }
        public double TienKhuyenMai { get; set; }
        public double TyLeLNBQ { get; set; }
        public double DungSaiMin { get; set; }
        public double DungSaiMax { get; set; }
        public double GiaMin { get; set; }
        public double GiaMax { get; set; }
        public double GiaBanAnToan { get; set; }
        public double SoLuongBanBQ { get; set; }
        public double DungSaiSLBQ { get; set; }
        public double DonGiaChuaVAT { get; set; }
        public double TyLeChietKhau { get; set; }
        public double TienChietKhau { get; set; }
        public double TyLeVAT { get; set; }
        public double TienVAT { get; set; }
        public double DonGiaCoVAT { get; set; }
        public double LoiNhuan { get; set; }
        public double LoiNhuanTon { get; set; }
        public double TyLeThuong { get; set; }
        public double ThuongNong { get; set; }
        public string NguoiCapNhat { get; set; }
        public int DaDuyet { get; set; }
        public string NguoiDuyet { get; set; }
        public double GiaNiemYet { get; set; }
        public double GiaWebSite { get; set; }
        public double GiaBanBuon { get; set; }
        public double LoiNhuanBB { get; set; }
        public double LoiNhuanTonBB { get; set; }
        public double DonViDoanhThu { get; set; }
        public double TrongSoDoanhThu { get; set; }
        public double DonViLoiNhuan { get; set; }
        public double TrongSoLoiNhuan { get; set; }
        public double DonViKhoanTon { get; set; }
        public double TrongSoKhoanTon { get; set; }
        public int TonKho { get; set; }
        public int IdNhomDuyet { get; set; }
        public string NhomDuyet { get; set; }
        public int Draft { get; set; }
        public double GiaNhapDemoCuoi { get; set; }
        public double GiaBanDemo { get; set; }
        public double LoiNhuanDemo { get; set; }
    }
}
