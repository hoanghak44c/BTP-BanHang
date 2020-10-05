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
    public class ChungTuBanHangChiTietHangHoaBHInfor
    {
        public string TenTrungTam { get; set; }
        public string TenKho { get; set; }
        public string ChannelCode { get; set; }

        public int IdChungTu { get; set; }
        public int LoaiChungTu { get; set; }
        public int LoaiGiaoDich { get; set; }
        public string SoChungTu { get; set; }
        public DateTime NgayLap { get; set; }        
        public string SoSeri { get; set; }
        public string HoTen { get; set; }
        public string SoPhieuXuat { get; set; }
        public DateTime NgayXuatHang { get; set; }
        public string DienThoai { get; set; }

        public int IdChungTuChiTiet { get; set; }        
        public int IdSanPham { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string DonViTinh { get; set; }
        public int IdChiTietHangHoa { get; set; }        
        public string MaVach { get; set; }
        public string LoaiMaVach { get; set; }
        public int SoLuong { get; set; }
        public string TrangThai { get; set; }
        public DateTime NgayKichHoat { get; set; }
        public string GhiChu { get; set; }
        public string LinhVuc { get; set; }
        public string Nganh { get; set; }
        public string Loai { get; set; }
        public string Chung { get; set; }
        public string Nhom { get; set; }
        public string Hang { get; set; }
        public string Model { get; set; }
        public string LoaiSanPham { get; set; }
        public string TenNhaCungCap { get; set; }
    }
}
