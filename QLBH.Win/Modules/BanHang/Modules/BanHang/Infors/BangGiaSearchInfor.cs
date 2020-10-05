using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class BangGiaSearchInfor
    {
        public int IdTrungTam { get; set; }

        public string MaTrungTam { get; set; }

        public string TenTrungTam { get; set; }

        public int IdBangGia { get; set; }

        public string SoBangGia { get; set; }

        public DateTime NgayLap { get; set; }

        public string NguoiLap { get; set; }

        public string NguoiTao { get; set; }

        public int DaDuyet { get; set; }

        public DateTime NgayDuyet { get; set; }

        public string GhiChu { get; set; }

        public int Draft { get; set; }

        public string ListIdTrungTam { get; set; }

        public string ListMaTrungTam { get; set; }

        public List<BangGiaChiTietInfor> ListBangGiaChiTiet { get; set; }
    }
}
