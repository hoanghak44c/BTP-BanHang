using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class ItemGiaBanInfor
    {
        public int IdTrungTam { get; set; }
        public string TenTrungTam { get; set; }
        public double GiaBanLe { get; set; }
        public double GiaBanBuon { get; set; }
        public double GiaBanDemo { get; set; }
    }
}
