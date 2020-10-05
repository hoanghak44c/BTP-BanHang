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
    public class ChungTuBanHangGNhanCTietInfor : ChungTuBanHangBCInfor
    {
        public string NhanVienGiaoNhan { get; set; }
        public string NhanVienGiaoNhan2 { get; set; }
        public string NhanVienGiaoNhan3 { get; set; }
        public string TenVungMien { get; set; }
        public string TenPhuongTien { get; set; }
        public string LoaiCongViec { get; set; }
        public string BienSoXe { get; set; }
        public string LaiXe { get; set; }
        public string GhiChuGN { get; set; }
        public string TenQuanHuyen { get; set; }
        public string DoiTacGiaoNhan { get; set; }
        public string NhanVienDoiTac { get; set; }
        public string MaSanPham { get; set; }
        public int SoLuong { get; set; }
        public double DonGiaVanChuyen { get; set; }
        public double DonGiaLapDat { get; set; }
        public double PhuCapVuotTroi { get; set; }
    }
}

