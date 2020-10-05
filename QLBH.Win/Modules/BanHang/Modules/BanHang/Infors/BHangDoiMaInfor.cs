using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.BanHang;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class BHangDoiMaInfor : NhapHangTraMuaInfor
    {
        public string MaVachDoi { get; set; }
    }
}
