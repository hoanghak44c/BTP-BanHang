using System;
using System.Collections.Generic;
using System.Text;
using QLBH.Core.Infors;

// Người tạo: Lê Mạnh Tuấn
// Ngày tạo :
// Ngày sửa cuối:

namespace QLBanHang.Modules.BanHang.Infors
{
    public class SuDungHoaDonInfor
    {
        public int IdQuyen { get; set; }

        public int IdNhanVien { get; set; }

        public string MaNhanVien { get; set; }

        public string TenNhanVien { get; set; }

        public string KyHieu { get; set; }

        //public int QuyenSo { get; set; }

        //public string KyHieuDau { get; set; }

        public int SoBatDau { get; set; }

        public int SoKetThuc { get; set; }

        public int SoHienTai { get; set; }

        public int SoConLai { get; set; }

        public bool Modified { get; set; }

        public string TrangThai { get; set; }
    }
}
