using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class BangGiaChinhSachInfor
    {
        public int IdChinhSach { get; set; }

        public string SoChinhSach { get; set; }

        public DateTime NgayLap { get; set; }

        public string NguoiLap { get; set; }

        public int DaDuyet { get; set; }

        public string DaDuyetTT { get; set; }

        public DateTime NgayDuyet { get; set; }

        public string NguoiDuyet { get; set; }

        public DateTime NgayHieuLuc { get; set; }

        public DateTime HanHieuLuc { get; set; }

        public string HanHieuLucTT { get; set; }

        public int DuyNhatCMND { get; set; }

        public int DuyNhatSDT { get; set; }

        public int GioiTinh { get; set; }

        public int DoTuoiTu { get; set; }

        public int DoTuoiDen { get; set; }

        public double GiaTriHDToiThieu { get; set; }

        public int IdNgheNghiep { get; set; }

        public string GhiChu { get; set; }

        public int Draft { get; set; }

        public int IdTinh { get; set; }

        public int IdHuyen { get; set; }

        public int CachGiaoHang { get; set; }

        public double GiaTriDHDaMua { get; set; }

        public int ThoiHanMua { get; set; }

        public int DoUuTien { get; set; }

        public double ThanhToanToiThieu { get; set; }

        public double SoTienTToanToiThieu { get; set; }

        public int SoKhachDauNgay { get; set; }

        public string NguoiTao { get; set; }

        public DateTime NgayTao { get; set; }

        public string NguoiCapNhat { get; set; }

        public DateTime NgayCapNhat { get; set; }

        public int IdDKMua { get; set; }

        public double GiaTriMuaToiThieu { get; set; }//gia tri hang chinh + hang kem toi thieu

        public double TyLePhanBo { get; set; }

        public int LoaiDoiTuong { get; set; }//1: online;0- thuong        
        
        public int MacDinh { get; set; }//1: luon ap dung; 0- thuong

        public int ApDungKemMacDinh { get; set; }//1: duoc phep ap dung kem cac chinh sach mac dinh; 0- khong ap dung

        public List<BangGiaADShopInfor> ListBangGiaADShop { get; set; }

        public List<BangGiaADKhachInfor> ListBangGiaADKhach { get; set; }

        public List<BangGiaADBankInfor> ListBangGiaADThanhToan { get; set; }

        public List<BangGiaADTimeInfor> ListBangGiaADThoiGian { get; set; }

        public List<BangGiaADDKMuaInfor> ListBangGiaADDKMua { get; set; }

        public string ChinhSachAD { get; set; }
        public string SieuThiAD { get; set; }
        public string DoiTuongAD { get; set; }
        public string ThoiGianAD { get; set; }
        public string ThanhToanAD { get; set; }
        public string MotaKhac { get; set; }
        public string MatHangKhongApDung { get; set; }
        public int InHoaDon { get; set; }
        public double TyLeDiemThuong { get; set; }//ty le diem thuong
        public int SoDiemThuong { get; set; }//so diem thuong tuyet doi (uu tien hon ty le diem thuong)
    }
}
