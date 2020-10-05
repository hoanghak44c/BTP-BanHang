using System;
using System.Collections.Generic;
using System.Text;
using QLBH.Core.Infors;

// Người tạo: Lê Mạnh Tuấn
// Ngày tạo :
// Ngày sửa cuối:

namespace QLBanHang.Modules.BanHang.Infors
{
    public class ChungTuTimKiemInfor
    {
        public string TenTrungTam { get; set; }
        public string TenKho { get; set; }
        public string LoaiChungTu { get; set; }
        public string SoChungTu { get; set; }
        public string SoHoaDon { get; set; }
        public DateTime NgayLap { get; set; }
        public string SoPhieuXuat { get; set; }
        public DateTime NgayXuat { get; set; }
        public string TrangThai { get; set; }
        public double TongTienThanhToan { get; set; }
        public double TienThanhToanThuc { get; set; }
        public double TienConNo { get; set; }
        public string TenKhachHang { get; set; }
        public string GiaoNhan { get; set; }
        public DateTime NgayGiaoHang { get; set; }
        public string NoiGiaoHang { get; set; }
        public string GhiChu { get; set; }
        public int IdChungTu { get; set; }
        public int DongBoOracle { get; set; }


    }
}
