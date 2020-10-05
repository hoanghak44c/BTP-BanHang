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
    public class ChungTuBanHangChiTietHangHoaBCInfor
    {
        public string TenTrungTam { get; set; }
        public string TenKho { get; set; }
        public string TenDoiTuong { get; set; }
        public string TenNhanVien { get; set; }

        public int IdChungTu { get; set; }
        public int LoaiChungTu { get; set; }
        public string SoChungTu { get; set; }
        public DateTime NgayLap { get; set; }        
        public string SoSeri { get; set; }
        public DateTime NgayHoaDon { get; set; }        
        public string HoTen { get; set; }
        public string SoPhieuXuat { get; set; }
        public DateTime NgayXuatHang { get; set; }

        public int IdChungTuChiTiet { get; set; }        
        public int IdSanPham { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string DonViTinh { get; set; }
        public int IdChiTietHangHoa { get; set; }        
        public string MaVach { get; set; }
        public int SoLuong { get; set; }
        public int TrungMaVach { get; set; }
        public int ChietKhau { get; set; }
        public int TrangThai { get; set; }
        public int LoaiHangKem { get; set; }//0-khuyen mai; 1-ban kem
        public string TenLoaiHangKem { get; set; }//0-khuyen mai; 1-ban kem
        public string LoaiSanPham { get; set; }
        public string GhiChu { get; set; }
        public int SoLuongDaXuat { get; set; }
        public int SoLuongChuaXuat { get; set; }
        public double DonGia { get; set; }
        public double TienChietKhau { get; set; }
        public double TienSauChietKhau { get; set; }
        public double TienVAT { get; set; }
        public double ThanhTien { get; set; }
        public int IdLyDoGiaoDich { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiSua { get; set; }
    }
}
