using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class NhapHangTraChiTietHHInfor : ChungTuBanHangChiTietInfor
    {
        public NhapHangTraChiTietHHInfor()
        {

        }

        public NhapHangTraChiTietHHInfor(DMSanPhamBriefInfo spb)
        {
            this.IdSanPham = spb.IdSanPham;
            this.MaSanPham = spb.MaSanPham;
            this.TenSanPham = spb.TenSanPham;
            this.DonViTinh = spb.TenDonViTinh;
            this.TrungMaVach = spb.TrungMaVach;
            this.ChietKhau = spb.ChietKhau;
            this.TyleVAT = spb.TyLeVAT;
            this.Nganh = spb.NganhHang;
            this.SoLuong = 1;
            this.SoLuongTra = 1;
        }
        public NhapHangTraChiTietHHInfor(NhapHangTraChiTietHHInfor spb)
        {
            this.IdSanPham = spb.IdSanPham;
            this.MaSanPham = spb.MaSanPham;
            this.TenSanPham = spb.TenSanPham;
            this.DonViTinh = spb.DonViTinh;
            this.TrungMaVach = spb.TrungMaVach;
            this.ChietKhau = spb.ChietKhau;
            this.TyleVAT = spb.TyleVAT;
            this.Nganh = spb.Nganh;
            this.MaVach = spb.MaVach;
            this.SoLuong = spb.SoLuong;
            this.SoLuongTra = spb.SoLuongTra;
            this.DaTra = spb.DaTra;
            this.DonGia = spb.DonGia;
            this.DonGiaCoVat = spb.DonGiaCoVat;
            this.TyleChietKhau = spb.TyleChietKhau;
            this.TienChietKhau = spb.TienChietKhau;
            this.TienSauChietKhau = spb.TienSauChietKhau;
            this.TienVAT = spb.TienVAT;
            this.ThanhTien = spb.ThanhTien;
            this.GiaNiemYet = spb.GiaNiemYet;
            this.GiaWebSite = spb.GiaWebSite;
            this.GiaTheoBangGia = spb.GiaTheoBangGia;
        }
        public int SoLuongTra { get; set; }
        public string MaVach { get; set; }
        public int DaTra { get; set; }
    }
}
