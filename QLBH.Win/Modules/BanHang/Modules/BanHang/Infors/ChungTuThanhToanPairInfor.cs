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
    public class ChungTuThanhToanPairInfor
    {
        public int IdHinhThucThanhToan { get; set; }

        public string HinhThucThanhToan { get; set; }

        public double SoTienThanhToan { get; set; }

        public string ThoiHanThanhToan { get; set; }

        public int IdThoiHanThanhToan { get; set; }

        public string SoTaiKhoan { get; set; }

        public string NganHangThanhToan { get; set; }

        public int IdNganHangThanhToan { get; set; }

        public string MaThe { get; set; }

        public string DuoiThe { get; set; }

        public string NganHangPhatHanhThe { get; set; }

        public int IdNganHangPhatHanhThe { get; set; }

        public DateTime NgayLap { get; set; }

        public int LoaiPhieu { get; set; }

        public int LoaiGiaoDich { get; set; }
    }
}
