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
    public class LichSuDoiMaInfor
    {
        public int ID { get; set; }
        public string SoPhieuXuat { get; set; }
        public string SoChungTuGoc { get; set; }
        public string MaVachCu { get; set; }
        public int IdSanPhamCu { get; set; }
        public string MaVachMoi { get; set; }
        public int IdSanPhamMoi { get; set; }
        public string SoChungTuDoiMa { get; set; }
        public DateTime NgayDoiMa { get; set; }
        public DateTime NgayXuatHang { get; set; }
    }
}
