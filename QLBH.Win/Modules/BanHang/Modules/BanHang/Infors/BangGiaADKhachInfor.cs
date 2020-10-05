using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class BangGiaADKhachInfor
    {
        public int IdChinhSach { get; set; }
        public int IdLoaiDT { get; set; }
        public string MaLoaiDT { get; set; }
        public string TenLoaiDT { get; set; }
        public int IdDoiTuong { get; set; }
        public string MaDoiTuong { get; set; }
        public string TenDoiTuong { get; set; }

    }
}
