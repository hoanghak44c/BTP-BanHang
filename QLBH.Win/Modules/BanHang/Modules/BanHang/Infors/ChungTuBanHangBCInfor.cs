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
    public class ChungTuBanHangBCInfor
    {
        public int IdChungTu { get; set; }
        public string SoChungTu { get; set; }
        public DateTime NgayLap { get; set; }
        public int LoaiChungTu { get; set; }
        public int IdTrungTamHachToan { get; set; }
        public int IdKho { get; set; }
        public int IdNhanVien { get; set; }
        public int TrangThai { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiSua { get; set; }
        public string SoSeri { get; set; }
        public string KyHieu { get; set; }
        public string HoTen { get; set; }
        public string MaKhach { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string MaSoThue { get; set; }
        public string SoTaiKhoan { get; set; }
        public double TongTienHang { get; set; }
        public double TongTienChietKhau { get; set; }
        public double TongTienSauChietKhau { get; set; }
        public double TongTienVAT { get; set; }
        public double TongTienThanhToan { get; set; }
        public double TienThanhToanThuc { get; set; }
        public double TienConNo { get; set; }
        public string GhiChu { get; set; }
        public string SoChungTuGoc { get; set; }
        public string SoCMND { get; set; }
        public int GiaoNhan { get; set; }
        public DateTime NgayHenGiaoHang { get; set; }
        public DateTime NgayGiaoHang { get; set; }
        public DateTime NgayGiaoXongHang { get; set; }
        public int Draft { get; set; }
        public string DiaChiHoaDon { get; set; }
        public string DiaChiGiaoHang { get; set; }
        public string SoHDDaMua { get; set; }
        public int IdLyDoGiaoDich { get; set; }
        public string SoPhieuDC { get; set; }
        public string CongTy { get; set; }
        public string TenTrungTam { get; set; }
        public string TenKho { get; set; }
        public string MaKho { get; set; }
        public string TenDoiTuong { get; set; }
        public string TenNhanVien { get; set; }
        public string SanPhamBan { get; set; }
        public int TuHuy { get; set; }
        public int IdGiaoNhan { get; set; }
        public string SoPhieuPhanCong { get; set; }
        public DateTime NgayPhanCong { get; set; }
        public DateTime NgayHoanThanh { get; set; }
        public int TinhTrangGiaoNhan { get; set; }
        public string ListIdChungTu { get; set; }
        public int DraftGN { get; set; }
        public string QuanHuyen { get; set; }
        public string GioGiaoHang { get; set; }
        public int SoLanIn { get; set; }
        public int DaPhanDon { get; set; }
    }
}

