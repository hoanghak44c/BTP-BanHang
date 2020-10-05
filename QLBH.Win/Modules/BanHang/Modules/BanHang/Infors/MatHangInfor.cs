using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class MatHangInfor
    {
        public MatHangInfor()
        {
            MaMatHang = "";
            TenMatHang = "";
            MaHangSX = "";
            TenHangSX = "";
            LoaiMatHang = 6;
            TenLoaiMatHang = "Sản phẩm";
        }
        public int IdMatHang { get; set; }

        public string MaMatHang { get; set; }

        public string TenMatHang { get; set; }

        public string MaHangSX { get; set; }

        public string TenHangSX { get; set; }

        public int LoaiMatHang { get; set; }

        public string TenLoaiMatHang { get; set; }

        public int ChietKhau { get; set; }
    }
}
