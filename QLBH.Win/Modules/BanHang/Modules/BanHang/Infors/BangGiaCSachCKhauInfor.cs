using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class BangGiaCSachCKhauInfor
    {
        public int IdChinhSach { get; set; }
        public int IdDKMua { get; set; }
        public string SoChinhSach { get; set; }
        public DateTime NgayHieuLuc { get; set; }
        public DateTime HanHieuLuc { get; set; }
        public int IdSanPham { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string DonViTinh { get; set; }
        public double TienChietKhau { get; set; }
        public double TyLeChietKhau { get; set; }
        public int SoLuong { get; set; }
        public double TongTienChietKhau { get; set; }
        public double TyLeVAT { get; set; }
        public double GiaTriHDToiThieu { get; set; }
        public int SoLuongDuocMua { get; set; }
        public int SoLuongPhaiMua { get; set; }
        public int SoLuongToiDaDH { get; set; }
        public int DuyNhatCMND { get; set; }
        public int DuyNhatSDT { get; set; }
        public int InHoaDon { get; set; }
        //public int DuocTichLuyDiem { get; set; }//1: duoc ap dung tich diem; 0- khong ap dung
    }
}
