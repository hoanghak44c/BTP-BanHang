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
    public class KichHoatBaoHanhMobileInfor
    {
        public int IdChiTietHangHoa { get; set; }
        public int IdSanPham { get; set; }
        public string IndexNo { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string MaVach { get; set; }
        public string SoSeri { get; set; }
        public DateTime NgayBan { get; set; }
        public DateTime NgayKichHoat { get; set; }
        public string TenTrungTam { get; set; }
        public string DienThoai { get; set; }
        public string Model { get; set; }
        public string TenNhaCungCap { get; set; }
        public int IdChiTietChungTu { get; set; }
        public string GhiChu { get; set; }
    }
}
