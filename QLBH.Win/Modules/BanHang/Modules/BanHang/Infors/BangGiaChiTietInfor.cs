using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QLBH.Core.Infors;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class BangGiaChiTietInfor : NotifyInfo
    {
        public BangGiaChiTietInfor()
        {
            
        }
        public BangGiaChiTietInfor(BangGiaNhapChiTietInfor gn)
        {
            this.NganhHang = gn.NganhHang;
            this.IdSanPham = gn.IdSanPham;
            this.MaSanPham = gn.MaSanPham;
            this.TenSanPham = gn.TenSanPham;
            this.DonViTinh = gn.DonViTinh;
            this.LoaiSanPham = gn.LoaiSanPham;
            this.GiaNhapHDCuoi = gn.GiaNhapHDCuoi;
            this.GiaTonKhoBQ = gn.GiaTonKhoBQ;
            this.TienChietKhauQK = gn.TienChietKhauQK;
            this.TyLeLNBQ = gn.TyLeLNBQ;
            this.SoLuongBanBQ = gn.SoLuongBanBQ;
            this.DungSaiMin = gn.DungSaiMin;
            this.DungSaiMax = gn.DungSaiMax;
            this.TyLeVAT = gn.TyLeVAT;
            this.DonViDoanhThu = gn.DonViDoanhThu;
            this.TrongSoDoanhThu = gn.TrongSoDoanhThu;
            this.DonViLoiNhuan = gn.DonViLoiNhuan;
            this.TrongSoLoiNhuan = gn.TrongSoLoiNhuan;
            this.DonViKhoanTon = gn.DonViKhoanTon;
            this.TrongSoKhoanTon = gn.TrongSoKhoanTon;
            this.TonKho = gn.TonKho;
            this.GiaNhapDemoCuoi = gn.GiaNhapDemoCuoi;
            this.HangKhuyenMai = gn.HangKhuyenMai;
        }

        private int _idChiTiet;
        public int IdChiTiet
        {
            get { return _idChiTiet; }
            set
            {
                if (_idChiTiet != value) NotifyChange();
                _idChiTiet = value;
            }
        }

        private int _idBangGia;
        public int IdBangGia
        {
            get { return _idBangGia; }
            set
            {
                if (_idBangGia != value) NotifyChange();
                _idBangGia = value;
            }
        }

        private int _idSanPham;
        public int IdSanPham
        {
            get { return _idSanPham; }
            set
            {
                if (_idSanPham != value) NotifyChange();
                _idSanPham = value;
            }
        }

        private string _maSanPham;
        public string MaSanPham
        {
            get { return _maSanPham; }
            set
            {
                if (_maSanPham != value) NotifyChange();
                _maSanPham = value;
            }
        }

        public string TenSanPham { get; set; }

        public string DonViTinh { get; set; }

        public string LoaiSanPham { get; set; }

        public string NganhHang { get; set; }

        private double _giaNhapHDCuoi;
        public double GiaNhapHDCuoi
        {
            get { return _giaNhapHDCuoi; }
            set
            {
                if (_giaNhapHDCuoi != value) NotifyChange();
                _giaNhapHDCuoi = value;
            }
        }

        private double _giaTonKhoBQ;
        public double GiaTonKhoBQ
        {
            get { return _giaTonKhoBQ; }
            set
            {
                if (_giaTonKhoBQ != value) NotifyChange();
                _giaTonKhoBQ = value;
            }
        }

        private double _tienChietKhauQK;
        public double TienChietKhauQK
        {
            get { return _tienChietKhauQK; }
            set
            {
                if (_tienChietKhauQK != value) NotifyChange();
                _tienChietKhauQK = value;
            }
        }

        private double _tienKhuyenMai;
        public double TienKhuyenMai
        {
            get { return _tienKhuyenMai; }
            set
            {
                if (_tienKhuyenMai != value) NotifyChange();
                _tienKhuyenMai = value;
            }
        }

        private double _tyLeLNBQ;
        public double TyLeLNBQ
        {
            get { return _tyLeLNBQ; }
            set
            {
                if (_tyLeLNBQ != value) NotifyChange();
                _tyLeLNBQ = value;
            }
        }

        private double _dungSaiMin;
        public double DungSaiMin
        {
            get { return _dungSaiMin; }
            set
            {
                if (_dungSaiMin != value) NotifyChange();
                _dungSaiMin = value;
            }
        }

        private double _dungSaiMax;
        public double DungSaiMax
        {
            get { return _dungSaiMax; }
            set
            {
                if (_dungSaiMax != value) NotifyChange();
                _dungSaiMax = value;
            }
        }

        private double _giaMin;
        public double GiaMin
        {
            get { return _giaMin; }
            set
            {
                if (_giaMin != value) NotifyChange();
                _giaMin = value;
            }
        }

        private double _giaMax;
        public double GiaMax
        {
            get { return _giaMax; }
            set
            {
                if (_giaMax != value) NotifyChange();
                _giaMax = value;
            }
        }

        private double _giaBanAnToan;
        public double GiaBanAnToan
        {
            get { return _giaBanAnToan; }
            set
            {
                if (_giaBanAnToan != value) NotifyChange();
                _giaBanAnToan = value;
            }
        }

        private double _soLuongBanBQ;
        public double SoLuongBanBQ
        {
            get { return _soLuongBanBQ; }
            set
            {
                if (_soLuongBanBQ != value) NotifyChange();
                _soLuongBanBQ = value;
            }
        }

        private double _dungSaiSLBQ;
        public double DungSaiSLBQ
        {
            get { return _dungSaiSLBQ; }
            set
            {
                if (_dungSaiSLBQ != value) NotifyChange();
                _dungSaiSLBQ = value;
            }
        }

        private double _donGiaChuaVAT;
        public double DonGiaChuaVAT
        {
            get { return _donGiaChuaVAT; }
            set
            {
                if (_donGiaChuaVAT != value) NotifyChange();
                _donGiaChuaVAT = value;
            }
        }

        private double _tyLeChietKhau;
        public double TyLeChietKhau
        {
            get { return _tyLeChietKhau; }
            set
            {
                if (_tyLeChietKhau != value) NotifyChange();
                _tyLeChietKhau = value;
            }
        }

        private double _tienChietKhau;
        public double TienChietKhau
        {
            get { return _tienChietKhau; }
            set
            {
                if (_tienChietKhau != value) NotifyChange();
                _tienChietKhau = value;
            }
        }

        private double _tyLeVAT;
        public double TyLeVAT
        {
            get { return _tyLeVAT; }
            set
            {
                if (_tyLeVAT != value) NotifyChange();
                _tyLeVAT = value;
            }
        }

        private double _tienVAT;
        public double TienVAT
        {
            get { return _tienVAT; }
            set
            {
                if (_tienVAT != value) NotifyChange();
                _tienVAT = value;
            }
        }

        private double _donGiaCoVAT;
        public double DonGiaCoVAT
        {
            get { return _donGiaCoVAT; }
            set
            {
                if (_donGiaCoVAT != value) NotifyChange();
                _donGiaCoVAT = value;
            }
        }

        public double LoiNhuan { get; set; }

        public double LoiNhuanTon { get; set; }

        private double _tyLeThuong;
        public double TyLeThuong
        {
            get { return _tyLeThuong; }
            set
            {
                if (_tyLeThuong != value) NotifyChange();
                _tyLeThuong = value;
            }
        }

        private double _thuongNong;
        public double ThuongNong
        {
            get { return _thuongNong; }
            set
            {
                if (_thuongNong != value) NotifyChange();
                _thuongNong = value;
            }
        }

        public string NguoiCapNhat { get; set; }

        private int _daDuyet;
        public int DaDuyet
        {
            get { return _daDuyet; }
            set
            {
                if (_daDuyet != value) NotifyChange();
                _daDuyet = value;
            }
        }

        public string NguoiDuyet { get; set; }

        private double _giaNiemYet;
        public double GiaNiemYet
        {
            get { return _giaNiemYet; }
            set
            {
                if (_giaNiemYet != value) NotifyChange();
                _giaNiemYet = value;
            }
        }

        private double _giaWebSite;
        public double GiaWebSite
        {
            get { return _giaWebSite; }
            set
            {
                if (_giaWebSite != value) NotifyChange();
                _giaWebSite = value;
            }
        }

        private double _giaBanBuon;
        public double GiaBanBuon
        {
            get { return _giaBanBuon; }
            set
            {
                if (_giaBanBuon != value) NotifyChange();
                _giaBanBuon = value;
            }
        }

        public double LoiNhuanBB { get; set; }

        public double LoiNhuanTonBB { get; set; }

        public double DonViDoanhThu { get; set; }

        public double TrongSoDoanhThu { get; set; }

        public double DonViLoiNhuan { get; set; }

        public double TrongSoLoiNhuan { get; set; }

        public double DonViKhoanTon { get; set; }

        public double TrongSoKhoanTon { get; set; }

        public int TonKho { get; set; }

        public int IdNhomDuyet { get; set; }

        public string NhomDuyet { get; set; }

        private double _giaNhapDemoCuoi;
        public double GiaNhapDemoCuoi
        {
            get { return _giaNhapDemoCuoi; }
            set
            {
                if (_giaNhapDemoCuoi != value) NotifyChange();
                _giaNhapDemoCuoi = value;
            }
        }

        private double _giaBanDemo;
        public double GiaBanDemo
        {
            get { return _giaBanDemo; }
            set
            {
                if (_giaBanDemo != value) NotifyChange();
                _giaBanDemo = value;
            }
        }

        public double LoiNhuanDemo { get; set; }
        public string KhuyenMai { get; set; }
        public int IdDKMua { get; set; }
        public int HangKhuyenMai { get; set; }
    }
}
