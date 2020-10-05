using System;
using System.Collections.Generic;
using System.Text;
using QLBH.Core.Infors;

// Người tạo: Lê Mạnh Tuấn
// Ngày tạo :
// Ngày sửa cuối:

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class ImportCTuDChuyenCTietInfor : ChungTuChiTietBaseInfo
    {
        public string DonViTinh { get; set; }
        public string GhiChu { get; set; }
        public int TrungMaVach { get; set; }
    }
}
