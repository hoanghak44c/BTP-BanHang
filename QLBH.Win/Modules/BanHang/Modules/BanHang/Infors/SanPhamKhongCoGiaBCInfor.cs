using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QLBH.Core.Infors;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class SanPhamKhongCoGiaBCInfor
    {
        public int IdSanPham { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string MaDonViTinh { get; set; }
        public string TenDonViTinh { get; set; }
        public int TrungMaVach { get; set; }
        public int ChietKhau { get; set; }
        public int SuDung { get; set; }
        public int TonKho { get; set; }
        public int TonAo { get; set; }
        public string LinhVuc { get; set; }
        public string Nganh { get; set; }
    }




}
