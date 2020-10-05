using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class BangGiaPairInfor
    {
        public int IdBangGia { get; set; }

        public string SoBangGia { get; set; }

        public DateTime NgayLap { get; set; }

        public string NguoiLap { get; set; }

        public DateTime NgayHieuLuc { get; set; }

        public DateTime HanHieuLuc { get; set; }

        public int HieuLucVoHan { get; set; }

        public int DaDuyet { get; set; }

        public string SieuThiApDung { get; set; }

        public string KhachHangApDung { get; set; }
    }
}
