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
    public class ChungTuGiaoNhanChiTietInfor
    {
        public int IdGiaoNhan { get; set; }
        public int IdNhanVien { get; set; }
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public int IdNhanVien2 { get; set; }
        public string MaNhanVien2 { get; set; }
        public string HoTen2 { get; set; }
        public int IdNhanVien3 { get; set; }
        public string MaNhanVien3 { get; set; }
        public string HoTen3 { get; set; }
        public string MaVungMien { get; set; }
        public string TenVungMien { get; set; }
        public string MaPhuongTien { get; set; }
        public string TenPhuongTien { get; set; }
        public string LoaiCongViec { get; set; }
        public string BienSoXe { get; set; }
        public int IdLaiXe { get; set; }
        public string MaLaiXe { get; set; }
        public string TenLaiXe { get; set; }
        public string GhiChu { get; set; }
        public int IdQuanHuyen { get; set; }
        public string TenQuanHuyen { get; set; }
        public int IdDoiTac { get; set; }
        public string MaDoiTac { get; set; }
        public string TenDoiTac { get; set; }
        public string NhanVienDoiTac { get; set; }
        public double DonGiaLapDat { get; set; }
        public double DonGiaVanChuyen { get; set; }
        public double PhuCapVuotTroi { get; set; }
    }
}
