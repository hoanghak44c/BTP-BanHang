using System;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class LichSuGiaBanInfor
    {
        public string MaTrungTam { get; set; }
        public string MaSanPham { get; set; }
        public DateTime AtTime { get; set; }
        public double GiaBan { get; set; }
        public double KhuyenMai { get; set; }
    }
}