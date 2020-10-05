using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class BangGiaADBankInfor
    {
        public int IdChinhSach { get; set; }
        public int IdHinhThucTT { get; set; }
        public string HinhThucThanhToan { get; set; }
        public int IdNganHang { get; set; }
        public string MaNganHang { get; set; }
        public string TenNganHang { get; set; }
        public int IdNganHangPH { get; set; }
        public string MaNganHangPH { get; set; }
        public string TenNganHangPH { get; set; }
        public int IdThoiHanTT { get; set; }
        public string ThoiHanThanhToan { get; set; }
        public double TyLeThanhToan { get; set; }
        public string GhiChu { get; set; }
    }
}
