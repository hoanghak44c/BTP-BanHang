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
    public class ChungTuThanhToanInfor
    {
        public int IdChungTu { get; set; }
        public int IdThanhToan { get; set; }
        public string SoPhieu { get; set; }
        public DateTime NgayLap { get; set; }
        public int IdThuNgan { get; set; }
        public string TenThuNgan { get; set; }
        public int IdHinhThucThanhToan { get; set; }
        public string HinhThucThanhToan { get; set; }
        public string ThoiHanThanhToan { get; set; }
        public int IdThoiHanThanhToan { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string SoTaiKhoan { get; set; }
        public string ChuTaiKhoan { get; set; }
        public string NganHangThanhToan { get; set; }
        public int IdNganHangThanhToan { get; set; }
        public string MaThe { get; set; }
        public string DuoiThe { get; set; }
        public string NganHangPhatHanhThe { get; set; }
        public int IdNganHangPhatHanhThe { get; set; }
        public string NoiDungThanhToan { get; set; }
        public double SoTienThanhToan { get; set; }
        public int IdTienTe { get; set; }
        public double TyGia { get; set; }
        public string SoTienChu { get; set; }
        public string NguoiTao { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public string TenMayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime ThoiGianSua { get; set; }
        public string TenMaySua { get; set; }
        public int LoaiPhieu { get; set; }
        public int LoaiGiaoDich { get; set; }
        public string SoChungTuGoc { get; set; }
        public string TaiKhoanQuy { get; set; }
        public int IdTrungTamThu { get; set; }
        public string TrungTamThu { get; set; }
        public string TenTrungTam { get; set; }
        public string MaDoiTuong { get; set; }
        public string TenDoiTuong { get; set; }
        public int LoaiChungTu { get; set; }
        public DateTime NgayLapHoaDon { get; set; }
        public string SoChungTu { get; set; }
        public string SoSeri { get; set; }
        public string TenNhanVien { get; set; }
        public double TongTienThanhToan { get; set; }
        public int LoaiThanhToan { get; set; }

        public ChungTuThanhToanInfor()
        {
            
        }
        public ChungTuThanhToanInfor(ChungTuThanhToanInfor tt)
        {
            this.IdChungTu = tt.IdChungTu;
            this.IdThanhToan = tt.IdThanhToan;
            this.SoPhieu = tt.SoPhieu;
            this.NgayLap = tt.NgayLap;
            this.IdThuNgan = tt.IdThuNgan;
            this.TenThuNgan = tt.TenThuNgan;
            this.IdHinhThucThanhToan = tt.IdHinhThucThanhToan;
            this.HinhThucThanhToan = tt.HinhThucThanhToan;
            this.ThoiHanThanhToan = tt.ThoiHanThanhToan;
            this.IdThoiHanThanhToan = tt.IdThoiHanThanhToan;
            this.HoTen = tt.HoTen;
            this.DiaChi = tt.DiaChi;
            this.DienThoai = tt.DienThoai;
            this.SoTaiKhoan = tt.SoTaiKhoan;
            this.ChuTaiKhoan = tt.ChuTaiKhoan;
            this.NganHangThanhToan = tt.NganHangThanhToan;
            this.IdNganHangThanhToan = tt.IdNganHangThanhToan;
            this.MaThe = tt.MaThe;
            this.DuoiThe = tt.DuoiThe;
            this.NganHangPhatHanhThe = tt.NganHangPhatHanhThe;
            this.IdNganHangPhatHanhThe = tt.IdNganHangPhatHanhThe;
            this.NoiDungThanhToan = tt.NoiDungThanhToan;
            this.SoTienThanhToan = tt.SoTienThanhToan;
            this.IdTienTe = tt.IdTienTe;
            this.TyGia = tt.TyGia;
            this.SoTienChu = tt.SoTienChu;
            this.LoaiPhieu = tt.LoaiPhieu;
            this.LoaiGiaoDich = tt.LoaiGiaoDich;
            this.SoChungTuGoc = tt.SoChungTuGoc;
            this.TaiKhoanQuy = tt.TaiKhoanQuy;
            this.IdTrungTamThu = tt.IdTrungTamThu;
            this.TrungTamThu = tt.TrungTamThu;
            this.TenTrungTam = tt.TenTrungTam;
            this.MaDoiTuong = tt.MaDoiTuong;
            this.TenDoiTuong = tt.TenDoiTuong;
            this.LoaiChungTu = tt.LoaiChungTu;
            this.NgayLapHoaDon = tt.NgayLapHoaDon;
            this.SoChungTu = tt.SoChungTu;
            this.SoSeri = tt.SoSeri;
            this.TenNhanVien = tt.TenNhanVien;
            this.TongTienThanhToan = tt.TongTienThanhToan;
            this.LoaiThanhToan = tt.LoaiThanhToan;
        }
    }
}
