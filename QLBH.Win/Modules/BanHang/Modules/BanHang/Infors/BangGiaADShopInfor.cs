using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class BangGiaADShopInfor
    {
        public int IdChinhSach { get; set; }
        public int IdTrungTam { get; set; }
        public string MaTrungTam { get; set; }
        public string TenTrungTam { get; set; }
        public int IdKho { get; set; }
        public string MaKho { get; set; }
        public string TenKho { get; set; }
        public int SoLuongDonHang { get; set; }

        //public int LoaiShop { get; set; }//1(kho); 2(trung tam)
    }
}
