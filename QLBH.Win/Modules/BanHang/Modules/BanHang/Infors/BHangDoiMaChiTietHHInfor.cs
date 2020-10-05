using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.BanHang.Infors;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class BHangDoiMaChiTietHHInfor : ChungTuBanHangChiTietInfor
    {
        public string MaVach { get; set; }
        public string MaVachDoi { get; set; }
        public int IdKho { get; set; }//idkho goc neu chua doi ma, idkhodieuchuyen neu da doi ma
        public int IdCtietHhoaGoc { get; set; }//idchitiet cua ma vach goc
        public BHangDoiMaChiTietHHInfor()
        {
            
        }
        public BHangDoiMaChiTietHHInfor(BHangDoiMaChiTietHHInfor ct)
        {
            this.IdChungTu = ct.IdChungTu;
            this.IdChungTuChiTiet = ct.IdChungTuChiTiet;
            this.IdSanPham = ct.IdSanPham;
            this.MaSanPham = ct.MaSanPham;
            this.TenSanPham = ct.TenSanPham;
            this.DonViTinh = ct.DonViTinh;
            this.SoLuong = ct.SoLuong;
            this.TrungMaVach = ct.TrungMaVach;
            this.DonGia = ct.DonGia;
            this.TyleChietKhau = ct.TyleChietKhau;
            this.TienChietKhau = ct.TienChietKhau;
            this.TienSauChietKhau = ct.TienSauChietKhau;
            this.TyleVAT = ct.TyleVAT;
            this.TienVAT = ct.TienVAT;
            this.ThanhTien = ct.ThanhTien;
            this.GiaTheoBangGia = ct.GiaTheoBangGia;
            this.GiaNiemYet = ct.GiaNiemYet;
            this.GiaWebSite = ct.GiaWebSite;
            this.ThuongNong = ct.ThuongNong;
            this.GhiChu = ct.GhiChu;
            this.IdSanPhamBan = ct.IdSanPhamBan;
            this.LoaiHangKem = ct.LoaiHangKem;
            this.MaVach = ct.MaVach;
            this.MaVachDoi = ct.MaVachDoi;
            this.IdKho = ct.IdKho;
        }
    }
}
