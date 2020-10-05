using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using QLBH.Common;
using QLBH.Common.Providers;
using QLBH.Core.Form;
using QLBH.Core.Infors;

// Người tạo: Lê Mạnh Tuấn
// Ngày tạo :
// Ngày sửa cuối:

namespace QLBanHang.Modules.BanHang.Infors
{
    public class TimKiemGiaoNhanFilterInfor : IFilter
    {
        public string SoPhieu { get; set; }
        public string DienThoai { get; set; }
        public int LoaiDonHang { get; set; }
        public int TrangThai { get; set; }
        public int IdTrungTam { get; set; }
        public int IdKho { get; set; }
        public string SanPham { get; set; }
        public int NhanVien { get; set; }
        public int DoiTac { get; set; }
        public DateTime TuNgay { get; set; }
        public DateTime DenNgay { get; set; }
        public string KhachHang { get; set; }
        public int QuanHuyen { get; set; }
        public string DiaChi { get; set; }
        public string PhuongTien { get; set; }
        public string VungMien { get; set; }
        public string UserName { get; set; }
        public int SoBatDau { get; set; }
        public int SoKetThuc { get; set; }
        public int IdNhanVien { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }

        public TimKiemGiaoNhanFilterInfor()
        {
            SoPhieu = null;
            LoaiDonHang = -1;
            TrangThai = -1;
            IdTrungTam = -1;
            IdKho = -1;
            SanPham = null;
            NhanVien = -1;
            DoiTac = -1;
            TuNgay = (DateTime)SqlDateTime.Null;
            DenNgay = (DateTime)SqlDateTime.Null;
            KhachHang = null;
            DiaChi = null;
            PhuongTien = null;
            VungMien = null;
            UserName = null;
            SoBatDau = 0;
            SoKetThuc = Declare.SOLUONG_TIMKIEM;
            IdNhanVien = -1;
            DateTime time = CommonProvider.Instance.GetSysDate();
            Thang = time.Month;
            Nam = time.Year;
        }
    }
}
