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
    public class ChungTuBanHangKHInfor
    {
        public int IdChungTu { get; set; }
        public string SoChungTu { get; set; }
        public DateTime NgayLap { get; set; }
        public int LoaiChungTu { get; set; }
        public int IdTrungTamHachToan { get; set; }
        public int IdKho { get; set; }
        public int IdKhachLe { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public int IdTinhHD { get; set; }
        public int IdHuyenHD { get; set; }
        public string DiaChiHD { get; set; }
        public string DiaChiHoaDon { get; set; }
        public int IdTinhGH { get; set; }
        public int IdHuyenGH { get; set; }
        public string DiaChiGH { get; set; }
        public string DiaChiGiaoHang { get; set; }
        public string SoHDDaMua { get; set; }
        public int IdNgheNghiep { get; set; }
        public string CongTy { get; set; }
        public int IdTrungTam { get; set; }
        public string TenTrungTam { get; set; }
        public string TenKho { get; set; }
        public string TenDoiTuong { get; set; }
        public string TenNhanVien { get; set; }
    }
}

