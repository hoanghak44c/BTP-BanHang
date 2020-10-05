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
    public class ChungTuGiaoNhanInfor
    {
        public int IdGiaoNhan { get; set; }

        public string SoPhieuPhanCong { get; set; }

        public DateTime NgayPhanCong { get; set; }

        public DateTime NgayXacNhan { get; set; }

        public DateTime NgayHoanThanh { get; set; }

        public DateTime ThoiGianGiaoTu { get; set; }

        public DateTime ThoiGianGiaoDen { get; set; }

        public int TinhTrang { get; set; }

        public string GhiChu { get; set; }

        public string ListIdChungTu { get; set; }

        public int Draft { get; set; }

        public List<ChungTuGiaoNhanChiTietInfor> ListChiTietGiaoNhan { get; set; }

        public string NguoiTao { get; set; }

        public DateTime NgayTao { get; set; }

        public string NguoiSua { get; set; }

        public DateTime NgaySua { get; set; }
    }
}
