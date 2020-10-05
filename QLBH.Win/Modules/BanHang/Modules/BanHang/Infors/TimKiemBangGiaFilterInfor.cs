using System;
using System.Collections.Generic;
using System.Text;
using QLBH.Common;
using QLBH.Core.Infors;

// Người tạo: Lê Mạnh Tuấn
// Ngày tạo :
// Ngày sửa cuối:

namespace QLBanHang.Modules.BanHang.Infors
{
    public class TimKiemBangGiaFilterInfor
    {
        public string SoBangGia { get; set; }
        public string NguoiLap { get; set; }
        public int Draft { get; set; }
        public int DaDuyet { get; set; }
        public int IdTrungTam { get; set; }
        public int IdLoaiDoiTuong { get; set; }
        public int LoaiBangGia { get; set; }
        public DateTime NgayHieuLuc { get; set; }
        public DateTime HanHieuLuc { get; set; }
        public int HieuLucVoHan { get; set; }
        public string GhiChu { get; set; }
        public string MatHang { get; set; }
        public string NguoiTao { get; set; }
        public int IdNhomDuyet { get; set; }
        public int SoBatDau { get; set; }
        public int SoKetThuc { get; set; }

        public TimKiemBangGiaFilterInfor()
        {
            IdTrungTam = -1;
            GhiChu = null;
            SoBatDau = 0;
            SoKetThuc = Declare.SOLUONG_TIMKIEM;
        }
    }
}
