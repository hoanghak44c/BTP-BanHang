using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.BanHang.Infors;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class ChungTuBanHangTraInfor : ChungTuBanHangInfor
    {
        public string TenThuongVienNhap { get; set; }
        public string SoPhieuNhap { get; set; }
        public DateTime NgayNhap { get; set; }
    }
}
