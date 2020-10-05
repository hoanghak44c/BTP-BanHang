using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using QLBH.Common;
using QLBH.Core.Infors;

// Người tạo: Lê Mạnh Tuấn
// Ngày tạo :
// Ngày sửa cuối:

namespace QLBanHang.Modules.BanHang.Infors
{
    public class TimKiemPhieuThuFilterInfor
    {
        public string SoPhieu { get; set; }
        public int LoaiDonHang { get; set; }
        public int LoaiPhieu { get; set; }
        public int IdTrungTam { get; set; }
        public string NhanVien { get; set; }
        public string ThuNgan { get; set; }
        public string KhachHang { get; set; }
        public string SoTaiKhoan { get; set; }
        public string ChuTaiKhoan { get; set; }
        public DateTime TuNgay { get; set; }
        public DateTime DenNgay { get; set; }
        public double DoanhThuTu { get; set; }
        public double DoanhThuDen { get; set; }
        public double SoTienThuTu { get; set; }
        public double SoTienThuDen { get; set; }
        public int IdHinhThucThanhToan { get; set; }
        public int IdThoiHanThanhToan { get; set; }
        public int IdNganHang { get; set; }
        public string GhiChu { get; set; }
        public string UserName { get; set; }
        public int SoBatDau { get; set; }
        public int SoKetThuc { get; set; }
        public string TaiKhoanQuy { get; set; }
        public int IdNhanVien { get; set; }

        public TimKiemPhieuThuFilterInfor()
        {
            SoPhieu = null;
            LoaiDonHang = -1;
            LoaiPhieu = -1;
            IdTrungTam = -1;
            NhanVien = null;
            ThuNgan = null;
            KhachHang = null;
            TuNgay = (DateTime)SqlDateTime.Null;
            DenNgay = (DateTime)SqlDateTime.Null;
            DoanhThuTu = 0;
            DoanhThuDen = 0;
            SoTienThuTu = 0;
            SoTienThuDen = 0;
            IdHinhThucThanhToan = 0;
            IdThoiHanThanhToan = 0;
            IdNganHang = 0;
            GhiChu = null;
            UserName = null;
            SoBatDau = 0;
            SoKetThuc = Declare.SOLUONG_TIMKIEM;
            TaiKhoanQuy = "";
            IdNhanVien = -1;
        }
    }
}
