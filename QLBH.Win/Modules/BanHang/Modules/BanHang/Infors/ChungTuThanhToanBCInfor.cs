using System;
using System.Collections.Generic;
using System.Text;
using QLBH.Core.Infors;

// Người tạo: Lê Mạnh Tuấn
// Ngày tạo :
// Ngày sửa cuối:

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class ChungTuThanhToanBCInfor
    {
        public int TrangThai { get; set; }
        public int LoaiChungTu { get; set; }
        public DateTime NgayLap { get; set; }
        public DateTime NgayHuy { get; set; }
        public DateTime NgayXuatNhap { get; set; }
        public string SoChungTu { get; set; }
        public string SoChungTuGoc { get; set; }
        public string MaTrungTam { get; set; }
        public string TenTrungTam { get; set; }
        public string MaKho { get; set; }
        public string SoSeri { get; set; }
        public string ThuongVien { get; set; }
        public string KhachHang { get; set; }
        public string DienThoai { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string DonViTinh { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
        public double TyleChietKhau { get; set; }
        public double TienChietKhau { get; set; }
        public double TienSauChietKhau { get; set; }
        public double TyleVAT { get; set; }
        public double TienVAT { get; set; }
        public double TyleThanhToan { get; set; }
        public double ThanhTien { get; set; }
        public double TyleThuong { get; set; }
        public double ThuongNong { get; set; }
        //public string TenSanPhamBan { get; set; }
        public int NoKhuyenMai { get; set; }
        public double TylePhanBo { get; set; }
        public int TrungMaVach { get; set; }
        public int ChietKhau { get; set; }
        public int CungDongHangChinh { get; set; }
        public string LoaiHangKem { get; set; }
        public string NguoiTao { get; set; }
        public string LinhVuc { get; set; }
        public string NganhHang { get; set; }
        public string Loai { get; set; }
        public string Chung { get; set; }
        public string Nhom { get; set; }
        public string Hang { get; set; }
        public string Model { get; set; }
        public int SoDiemThuong { get; set; }//so diem thuong toi da duong thuong
        public int IdLyDoGiaoDich { get; set; }
    }
}
