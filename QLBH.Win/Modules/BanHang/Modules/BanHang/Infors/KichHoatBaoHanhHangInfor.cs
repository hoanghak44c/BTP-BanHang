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
    public class KichHoatBaoHanhHangInfor
    {
        public int STT { get; set; }
        public DateTime SalesDate { get; set; }
        public string FromChannelCode { get; set; }
        public string ToChannelCode { get; set; }
        public string PromoterId { get; set; }
        public string MaVach { get; set; }
        public string EndUserName { get; set; }
        public string DienThoai { get; set; }
        public int IdChiTietChungTu { get; set; }
        public int IdChiTietHangHoa { get; set; }
        public int IdSanPham { get; set; }
        public string GhiChu { get; set; }
    }
}
