using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class TimKiemItemInfor
    {
        public int Id { get; set; }

        public string Ma { get; set; }

        public string Ten { get; set; }

        public string Nhom { get; set; }

        public int ChietKhau { get; set; }
    }
}
