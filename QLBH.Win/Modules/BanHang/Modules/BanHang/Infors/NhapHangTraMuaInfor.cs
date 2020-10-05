using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.BanHang.Infors;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class NhapHangTraMuaInfor : ChungTuBanHangInfor 
    {
        public string TenSanPham { get; set; }
        public string MaThuongVien { get; set; }
        public string TenThuongVien { get; set; }
        public string MaTruongCa { get; set; }
        public string TenTruongCa { get; set; }
        public string MaThuNgan { get; set; }
        public string TenThuNgan { get; set; }
        public string GHangTinh { get; set; }
        public string GHQuan { get; set; }
        public string HDTinh { get; set; }
        public string HDQuan { get; set; }
        public string LoaiHDThue { get; set; }
        public string LoaiHDBHang { get; set; }
        public string DuAn { get; set; }
        public DateTime NgayXuat { get; set; }
        public string SoChungTuXuat { get; set; }
        public string KhachHang { get; set; }        
    }
}
