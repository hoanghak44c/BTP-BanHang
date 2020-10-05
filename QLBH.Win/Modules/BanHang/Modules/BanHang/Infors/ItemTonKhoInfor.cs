using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class ItemTonKhoInfor
    {
        public int IdTrungTam { get; set; }
        public string TenTrungTam { get; set; }
        public int IdKho { get; set; }
        public string MaKho { get; set; }
        public string TenKho { get; set; }
        public int IdSanPham { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string DonViTinh { get; set; }
        public int TonThat { get; set; }
        public int TonAo { get; set; }
    }
}
