using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class BangGiaADTimeInfor
    {
        public int IdChinhSach { get; set; }
        public int Thu { get; set; }
        public string DayOfWeek { get; set; }
        public int Ngay { get; set; }
        public string DayOfMonth { get; set; }
        public string GioTu { get; set; }
        public string GioDen { get; set; }
    }
}
