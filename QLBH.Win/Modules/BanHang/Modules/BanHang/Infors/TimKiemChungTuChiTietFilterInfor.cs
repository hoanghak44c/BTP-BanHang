using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using QLBH.Common;
using QLBH.Core.Form;
using QLBH.Core.Infors;

// Người tạo: Lê Mạnh Tuấn
// Ngày tạo :
// Ngày sửa cuối:

namespace QLBanHang.Modules.BanHang.Infors
{
    public class TimKiemChungTuChiTietFilterInfor : IFilter, IFilter2
    {
        public string SoPhieu { get; set; }
        public string DienThoai { get; set; }
        public int LoaiDonHang { get; set; }
        public int TrangThai { get; set; }
        public int IdTrungTam { get; set; }
        public int IdKho { get; set; }
        public int IdSanPham { get; set; }
        public string Nganh { get; set; }
        public string SanPham { get; set; }
        public string MaHang { get; set; }
        public int LoaiMaHang { get; set; }
        public string NhanVien { get; set; }
        public DateTime TuNgay { get; set; }
        public DateTime DenNgay { get; set; }
        public DateTime NXTuNgay { get; set; }
        public DateTime NXDenNgay { get; set; }
        public string KhachHang { get; set; }
        public string GhiChu { get; set; }
        public string UserName { get; set; }
        public string MaVach { get; set; }
        public int LoaiMaVach { get; set; }
        public string HangSanXuat { get; set; }
        public int SoBatDau { get; set; }
        public int SoKetThuc { get; set; }
        public int SoTon { get; set; }
        public int IdNhanVien { get; set; }
        public string NgheNghiep { get; set; }
        public int GioiTinh { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public int IdNhomNguoiDung { get; set; }

        public TimKiemChungTuChiTietFilterInfor() 
        {
            SoPhieu = null;
            LoaiDonHang = -1;
            TrangThai = -1;
            IdTrungTam = -1;
            IdKho = -1;
            SanPham = null;
            MaHang = null;
            LoaiMaHang = -1;
            NhanVien = null;
            TuNgay = (DateTime)SqlDateTime.Null;
            DenNgay = (DateTime)SqlDateTime.Null;
            NXTuNgay = (DateTime)SqlDateTime.Null;
            NXDenNgay = (DateTime)SqlDateTime.Null;
            KhachHang = null;
            GhiChu = null;
            UserName = null;
            MaVach = null;
            LoaiMaVach = -1;
            HangSanXuat = null;
            SoBatDau = 0;
            SoKetThuc = Declare.SOLUONG_TIMKIEM;
            IdNhanVien = -1;
            IdNhomNguoiDung = 0;
        }
    }
}
