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
    public class ImportCTuDChuyenInfor : ChungTuBaseInfo
    {
        public string SoHoaDon { get; set; }        
        public string TenKhoDi { get; set; }
        public int IdKhoDen { get; set; }
        public string TenKhoDen { get; set; }
        public int IdNguoiVanChuyen { get; set; }
        public string TenNguoiVanChuyen { get; set; }
        public int IdNguoiUyNhiem { get; set; }
        public string TenNguoiUyNhiem { get; set; }
        public string NguoiLap { get; set; }
        public string GhiChu { get; set; }        
        public string PhuongTien { get; set; }
        public DateTime NgayNhapXuatKho { get; set; }
        public int IdNguoiNhapXuatKho { get; set; }
        public string NguoiNhapXuatKho { get; set; }
        public string SoChungTuGoc { get; set; }
        public int IdChungTuGoc { get; set; }
    }
}
