using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class BangGiaChinhSachBCInfor
    {
        public int IdDKMua { get; set; }
        public int IdChinhSach { get; set; }
        public int IdHangMua { get; set; }
        public string MaHangMua { get; set; }
        public string TenHangMua { get; set; }
        public int SoLuongDuocMua { get; set; }
        public int SoLuongPhaiMua { get; set; }
        public double TyLePhanBo { get; set; }
        public int LoaiHangMua { get; set; }
        public string TenLoaiHangMua { get; set; }
        public string MaHangSX { get; set; }
        public string TenHangSX { get; set; }
        public double GiaMuaTu { get; set; }
        public double GiaMuaDen { get; set; }
        public string KhuyenMai { get; set; }
        public string KhuyenMaiMa { get; set; }
        public string SanPhamKem { get; set; }
        public string SanPhamDaMua { get; set; }
        public int SoLuongToiDaDH { get; set; }
        public double TyLeChietKhau { get; set; }
        public double TienChietKhau { get; set; }
        public string ChinhSachAD { get; set; }
        public string SieuThiAD { get; set; }
        public string DoiTuongAD { get; set; }
        public string ThoiGianAD { get; set; }
        public string ThanhToanAD { get; set; }
        public string MotaKhac { get; set; }
        public string SoChinhSach { get; set; }
        public DateTime NgayLap { get; set; }
        public DateTime NgayHieuLuc { get; set; }
        public DateTime HanHieuLuc { get; set; }
        public string TrangThai { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public int DuocTichLuyDiem { get; set; }//1: duoc ap dung tich diem; 0- khong ap dung
    }
}
