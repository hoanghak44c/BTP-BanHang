using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class InPhieuBaoHanhInfor
    {
        public int IdChungTu { get; set; }
        public string SoPhieuXuat { get; set; }
        public string TenDoiTuong { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string MaRieng { get; set; }
        public string DiaChi { get; set; }
        public string NhomKH { get; set; }
    }
}
