using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QLBH.Core.Infors;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class BangGiaCSachCTietInfor : BangGiaChiTietInfor
    {
        public BangGiaCSachCTietInfor()
        {
            
        }
        public BangGiaCSachCTietInfor(BangGiaNhapChiTietInfor gn)
            : base(gn)
        {
        }

        public int IdChinhSach { get; set; }
        public int IdSPKem { get; set; }
        public int SoThuTu { get; set; }
        public BangGiaADDKMuaInfor ChinhSachDKMua { get; set; }
    }
}
