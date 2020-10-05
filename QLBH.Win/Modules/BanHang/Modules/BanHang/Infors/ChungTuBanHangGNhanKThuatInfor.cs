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
    public class ChungTuBanHangGNhanKThuatInfor
    {
        public string TrungTam { get; set; }
        public string LoaiDoiTuong { get; set; }
        public string MaDoiTuong { get; set; }
        public string TenPhuongTien { get; set; }
        public string TenDoiTuong { get; set; }
        public int Ngay { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public int SoLuongDonHang { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int SoLuong { get; set; }
    }
}

