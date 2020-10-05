using System;
using System.Collections.Generic;
using System.Text;
using QLBH.Core.Infors;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class HoaDonGTGTInfo : ChungTuBaseInfo
    {
        public string TenDonVi { get; set; }
        public string DiaChi { get; set; }
        public string NguoiMuaHang { get; set; }
        public string MaSoThue { get; set; }
        public string KhoXuat { get; set; }
        public string NhanVien { get; set; }
        public string SoTienChu { get; set; }
        public string NguoiLap { get; set; }
        public string TongTienChuaVAT0 { get; set; }
        public string TongTienChuaVAT5 { get; set; }
        public string TongTienChuaVAT10 { get; set; }
        public string TongTienVAT0 { get; set; }
        public string TongTienVAT5 { get; set; }
        public string TongTienVAT10 { get; set; }
        public string TongTienChuaVAT { get; set; }
        public string TongTienVAT { get; set; }
        public string TongTienThanhToan { get; set; }
        public string SoTienThucTra { get; set; }
        public string SoTienConNo { get; set; }

    }
}
