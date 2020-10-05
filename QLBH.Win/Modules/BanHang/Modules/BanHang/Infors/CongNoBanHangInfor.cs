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
    public class CongNoBanHangInfor
    {
        public int IdTrungTam { get; set; }
        public string MaTrungTam { get; set; }
        public string TenTrungTam { get; set; }
        public int IdDoiTuong { get; set; }
        public string MaDoiTuong { get; set; }
        public string TenDoiTuong { get; set; }
        public double GiaTriMuaHang { get; set; }
        public double TongHanMucTinDung { get; set; }
        public double HanMucTinDungConLai { get; set; }
        public double CongNoBanHang { get; set; }
        public DateTime NgayCapNhat { get; set; }        
    }
}
