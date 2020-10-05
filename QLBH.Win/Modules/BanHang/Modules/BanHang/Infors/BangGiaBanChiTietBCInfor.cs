using System;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class BangGiaBanChiTietBCInfor
    {
        public int IdChiTietBangGia { get; set; }
        public int IdTrungTam { get; set; }
        public int IdSanPham { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string MaDonViTinh { get; set; }
        public string TenDonViTinh { get; set; }
        public double GiaNhapHDCuoi { get; set; }
        public double GiaNhapDemoCuoi { get; set; }
        public double GiaTonKhoBQ { get; set; }
        public double DonGiaChuaVAT { get; set; }
        public double TyLeVAT { get; set; }
        public double TienVAT { get; set; }
        public double DonGiaCoVAT { get; set; }
        public double GiaBanBuon { get; set; }
        public double GiaBanDemo { get; set; }        
        public double TyLeThuong { get; set; }
        public double ThuongNong { get; set; }
        public int TrungMaVach { get; set; }
        public int ChietKhau { get; set; }
        public double GiaNiemYet { get; set; }
        public double GiaWebSite { get; set; }
        public int TonKho { get; set; }
        public int TonAo { get; set; }
        public string LinhVuc { get; set; }
        public string Nganh { get; set; }
        public string Model { get; set; }
        public string ChinhSachKhuyenMai { get; set; }
        public DateTime NgayCapNhatCuoi { get; set; }
        public double GiaNhapHDCuoiOld { get; set; }
        public double GiaNhapDemoCuoiOld { get; set; }
        public double GiaTonKhoBQOld { get; set; }
        public double DonGiaChuaVATOld { get; set; }
        public double TyLeVATOld { get; set; }
        public double TienVATOld { get; set; }
        public double DonGiaCoVATOld { get; set; }
        public double GiaBanBuonOld { get; set; }
        public double GiaBanDemoOld { get; set; }
        public string GhiChu { get; set; }
        public string KhuyenMai { get; set; }
        public int HangKhuyenMai { get; set; }
        public double TyLeDiemThuongMacDinh { get; set; }
        public double TyLeDiemThuong { get; set; }//ty le diem thuong toi da (tinh theo so diem thuong/dongia)
        public int SoDiemThuong { get; set; }//so diem thuong toi da duong thuong
    }




}
