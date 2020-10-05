using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QLBH.Core.Infors;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class BangGiaHangKhuyenMaiInfor
    {
        public int IdKhuyenMai { get; set; }

        public string KhuyenMai { get; set; }

        public int DoUuTien { get; set; }

        public List<BangGiaHangKhuyenMaiChiTietInfor> ListKhuyenMaiChiTiet { get; set; }
    }
}
