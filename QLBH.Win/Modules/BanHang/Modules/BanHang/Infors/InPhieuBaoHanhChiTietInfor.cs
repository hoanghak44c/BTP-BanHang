using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class InPhieuBaoHanhChiTietInfor
    {
        public string TenSanPham { get; set; }
        public string MaVach { get; set; }
        public DateTime NgayMua { get; set; }
        public string NoiMua { get; set; }
        public int ThoiGianBH { get; set; }
        public DateTime TuNgay { get; set; }
        public DateTime DenNgay { get; set; }
        public int IdSanPham { get; set; }
        public int IdKho { get; set; }
        public int IdSanPhamGoc { get; set; }
        public string MaVachGoc { get; set; }//ma vach thanh pham, su dung voi truong hop linh kien
        public int IdKhoGoc { get; set; }
    }
}
