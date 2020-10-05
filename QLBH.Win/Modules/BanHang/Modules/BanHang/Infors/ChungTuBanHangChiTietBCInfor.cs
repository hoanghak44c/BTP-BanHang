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
    public class ChungTuBanHangChiTietBCInfor
    {
        public string TenTrungTam { get; set; }
        public string TenKho { get; set; }
        public int IdChungTu { get; set; } 
        public string SoChungTu { get; set; }
        public string SoChungTuGoc { get; set; }
        public DateTime NgayLap { get; set; }
        public string LoaiChungTu { get; set; }
        public string SoSeri { get; set; }
        public DateTime NgayHoaDon { get; set; }
        public string MaDoiTuong { get; set; }
        public string HoTen { get; set; }
        public string DienThoai { get; set; }
        public string DiaChiGiaoHang { get; set; }
        public string DiaChiHoaDon { get; set; }
        public string SoCMND { get; set; }
        public string SoPhieuXuat { get; set; }
        public DateTime NgayXuatHang { get; set; }
        public string TenDoiTuong { get; set; }
        public string TenNhanVien { get; set; }

        public int IdChungTuChiTiet { get; set; }        
        public int IdSanPham { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
        public double TyleChietKhau { get; set; }
        public double TienChietKhau { get; set; }
        public double TienSauChietKhau { get; set; }
        public double TyLeVAT { get; set; }
        public double TienVAT { get; set; }
        public double ThanhTien { get; set; }
        public double TyleThuong { get; set; }
        public double ThuongNong { get; set; }
        public double GiaTheoBangGia { get; set; }
        public double GiaNiemYet { get; set; }
        public double GiaWebSite { get; set; }
        public int IdSanPhamBan { get; set; }
        public string TenSanPhamBan { get; set; }
        public string DonViTinh { get; set; }
        public string GhiChu { get; set; }
        public int TrungMaVach { get; set; }
        public int ChietKhau { get; set; }
        public int NoKhuyenMai { get; set; }
        public int XoaNoKM { get; set; }
        public string GhichuNoKM { get; set; }
        public double TyLePhanBo { get; set; }
        public int CungDongDonHangChinh { get; set; }//0-khuyen mai; 1-ban kem
        public int LoaiHangKem { get; set; }//0-khuyen mai; 1-ban kem
        public string TenLoaiHangKem { get; set; }//0-khuyen mai; 1-ban kem
        public string LinhVuc { get; set; }
        public string Nganh { get; set; }
        public string Loai { get; set; }
        public string Chung { get; set; }
        public string Nhom { get; set; }
        public string Hang { get; set; }
        public string Model { get; set; }
        public double TyLeThanhToan { get; set; }
        public string NguoiTao { get; set; }
        public int TrangThai { get; set; }
        public int IdLyDoGiaoDich { get; set; }
        public string LyDoTraHang { get; set; }
        public string TinhHD { get; set; }
        public string QuanHuyenHD { get; set; }
        public string TinhGH { get; set; }
        public string QuanHuyenGH { get; set; }
        public string WebSite { get; set; }
        public string Email { get; set; }
        public string ListIdChinhSach { get; set; }//id chinh sach gia
        public string ListSoChinhSach { get; set; }//so chinh sach gia
        public string DienGiai { get; set; }
        public double TyLeDiemThuong { get; set; }//ty le diem thuong
        public int SoDiemThuong { get; set; }//so diem thuong tuyet doi (uu tien hon ty le diem thuong)
        public double TyLeDiemThuongMacDinh { get; set; }//so diem thuong mac dinh(dung trong truong hop ko co chinh sach gia va he thong cho phep ap dung diem mac dinh)
    }
}
