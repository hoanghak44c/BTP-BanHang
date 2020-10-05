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
public class ChungTuBanHangChiTietInfor : ChungTuChiTietBaseInfo, ICloneable
    {
        public object Clone() { return this.MemberwiseClone(); }
        public static List<ChungTuBanHangChiTietInfor> CopyList(List<ChungTuBanHangChiTietInfor> src)
        {
            List<ChungTuBanHangChiTietInfor> dest = new List<ChungTuBanHangChiTietInfor>();
            if (src.Count > 0)
            {
                foreach (ChungTuBanHangChiTietInfor ct in src)
                {
                    dest.Add((ChungTuBanHangChiTietInfor)ct.Clone());
                }
            }

            return dest;
        }
        public ChungTuBanHangChiTietInfor()
        {

        }
        public ChungTuBanHangChiTietInfor(ChungTuBanHangChiTietHangHoaInfor ct)
        {
            this.IdChungTuChiTiet = ct.IdChungTuChiTiet;
            this.IdSanPham = ct.IdSanPham;
            this.MaSanPham = ct.MaSanPham;
            this.TenSanPham = ct.TenSanPham;
            this.DonViTinh = ct.DonViTinh;
            this.SoLuong = ct.SoLuong;
            this.TrungMaVach = ct.TrungMaVach;
            this.TienChietKhau = ct.TienChietKhau;
            this.TienVAT = ct.TienVAT;
            this.ThuongNong = ct.ThuongNong;
            this.GhiChu = ct.GhiChu;
            this.IdSanPhamBan = ct.IdSanPhamBan;
            this.LoaiHangKem = ct.LoaiHangKem;
        }

        private double _donGia;
        public double DonGia
        {
            get { return _donGia; }
            set
            {
                if (_donGia != value)
                {
                    NotifyChange();
                }
                _donGia = value;
            }
        }

        private double _tyleChietKhau;
        public double TyleChietKhau
        {
            get { return _tyleChietKhau; }
            set
            {
                if (_tyleChietKhau != value)
                {
                    NotifyChange();
                }
                _tyleChietKhau = value;
            }
        }

        private double _tienChietKhau;
        public double TienChietKhau
        {
            get { return _tienChietKhau; }
            set
            {
                if (_tienChietKhau != value)
                {
                    NotifyChange();
                }
                _tienChietKhau = value;
            }
        }

        private double _tienSauChietKhau;
        public double TienSauChietKhau
        {
            get { return _tienSauChietKhau; }
            set
            {
                if (_tienSauChietKhau != value)
                {
                    NotifyChange();
                }
                _tienSauChietKhau = value;
            }
        }

        private double _tyleVAT;
        public double TyleVAT
        {
            get { return _tyleVAT; }
            set
            {
                if (_tyleVAT != value)
                {
                    NotifyChange();
                }
                _tyleVAT = value;
            }
        }

        private double _tienVAT;
        public double TienVAT
        {
            get { return _tienVAT; }
            set
            {
                if (_tienVAT != value)
                {
                    NotifyChange();
                }
                _tienVAT = value;
            }
        }

        private double _thanhTien;
        public double ThanhTien
        {
            get { return _thanhTien; }
            set
            {
                if (_thanhTien != value)
                {
                    NotifyChange();
                }
                _thanhTien = value;
            }
        }

        private double _tyleThuong;
        public double TyleThuong
        {
            get { return _tyleThuong; }
            set
            {
                if (_tyleThuong != value)
                {
                    NotifyChange();
                }
                _tyleThuong = value;
            }
        }

        private double _thuongNong;
        public double ThuongNong
        {
            get { return _thuongNong; }
            set
            {
                if (_thuongNong != value)
                {
                    NotifyChange();
                }
                _thuongNong = value;
            }
        }

        private double _giaTheoBangGia;
        public double GiaTheoBangGia
        {
            get { return _giaTheoBangGia; }
            set
            {
                if (_giaTheoBangGia != value)
                {
                    NotifyChange();
                }
                _giaTheoBangGia = value;
            }
        }

        public double GiaNiemYet { get; set; }

        public double GiaWebSite { get; set; }

        public int IdSanPhamBan { get; set; }

        public string TenSanPhamBan { get; set; }

        public string DonViTinh { get; set; }

        public string GhiChu { get; set; }

        public int TrungMaVach { get; set; }
        public int ChietKhau { get; set; }
        public double TyLeCSachChietKhau { get; set; }//danh dau da tinh chiet khau (-1) hay chua

        public int NoKhuyenMai { get; set; }
        public int SoLuongKhuyenMai { get; set; }
        public double TyLePhanBo { get; set; }
        public double DonGiaCoVat { get; set; }
        public int TonKho { get; set; }
        public int CungDongDonHangChinh { get; set; }//0-khuyen mai; 1-ban kem
        public int LoaiHangKem { get; set; }//0-khuyen mai; 1-ban kem
        public string TenLoaiHangKem { get; set; }//0-khuyen mai; 1-ban kem
        public string LinhVuc { get; set; }
        public string Nganh { get; set; }
        public string Loai { get; set; }
        public string Chung { get; set; }
        public string Nhom { get; set; }
        public string Hang { get; set; }
        public string Model { get; set; }
        public BangGiaChinhSachInfor ChinhSach { get; set; }
        public BangGiaCSachCKhauInfor CSachChietKhau { get; set; }
        public double TyLeThanhToan { get; set; }
        public int SoLuongOld { get; set; }//dung de tinh lai sotien,chietkhau,... khi thay doi soluong chinh
        public int DaInHoaDon { get; set; }//dung de in hoa don
        public int InHoaDon { get; set; }//ap dung voi ma hang CK: 0-khong in hoa don thuong,1-in hoa don thuong,2-khong in hoa don CK, 3-in hoa don ck
        public string TyLeVATText { get; set; }
        //public int IdChinhSach { get; set; }//id chinh sach gia
        public List<BangGiaChinhSachInfor> ListChinhSachDefault { get; set; }
        public string ListIdChinhSach { get; set; }//id chinh sach gia
        public string ListSoChinhSach { get; set; }//so chinh sach gia
        public bool ApDungChietKhau { get; set; }//co ap dung chiet khau hay khong
        public double TyLeDiemThuong { get; set; }//ty le diem thuong
        public int SoDiemThuong { get; set; }//so diem thuong tuyet doi (uu tien hon ty le diem thuong)
        public double TyLeDiemThuongMacDinh { get; set; }//so diem thuong mac dinh(dung trong truong hop ko co chinh sach gia va he thong cho phep ap dung diem mac dinh)
    }
}
