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
    public class ImportCTuDChuyenCTietHHoaInfor : ChungTuChiTietHangHoaBaseInfo
    {
        public string TenSanPham { get; set; }
        public string MaSanPham { get; set; }
        public string DonViTinh { get; set; }
        public int TrungMaVach { get; set; }
    }
}
