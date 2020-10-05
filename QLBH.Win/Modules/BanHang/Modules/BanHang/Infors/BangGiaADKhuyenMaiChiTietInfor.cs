using System;
using System.Collections.Generic;
using System.Text;
using QLBH.Core.Infors;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class BangGiaADKhuyenMaiChiTietInfor : NotifyInfo
    {
        public BangGiaADKhuyenMaiChiTietInfor()
        {
            
        }
        public BangGiaADKhuyenMaiChiTietInfor(BangGiaADKhuyenMaiChiTietInfor kmct)
        {
            this.IdChiTiet = kmct.IdChiTiet;
            this.IdKhuyenMai = kmct.IdKhuyenMai;
            this.IdHangKM = kmct.IdHangKM;
            this.MaHangKM = kmct.MaHangKM;
            this.TenHangKM = kmct.TenHangKM;
            this.SoLuong = kmct.SoLuong;
            this.SoTienKM = kmct.SoTienKM;
            this.GhiChu = kmct.GhiChu;
            this.InKemHD = kmct.InKemHD;
            this.HetTonDungKM = kmct.HetTonDungKM;
            this.TyLeKM = kmct.TyLeKM;
            this.LoaiHangKM = kmct.LoaiHangKM;
            this.TenLoaiHangKM = kmct.TenLoaiHangKM;
            this.MaHangSX = kmct.MaHangSX;
            this.TenHangSX = kmct.TenHangSX;
            this.SuDung = kmct.SuDung;
            this.ChietKhau = kmct.ChietKhau;
            this.TonKho = kmct.TonKho;
            this.NoKhuyenMai = kmct.NoKhuyenMai;
            this.SoTienYeuCau = kmct.SoTienYeuCau;
            this.SoLuongOld = kmct.SoLuongOld;
            this.TyLeThanhToan = kmct.TyLeThanhToan;
            this.SoLuongOld = kmct.SoLuongOld;
            this.DongBoWebSite = kmct.DongBoWebSite;
            this.TyLeDiemThuong = kmct.TyLeDiemThuong;
            this.SoDiemThuong = kmct.SoDiemThuong;
        }
        private int idChiTiet;
        public int IdChiTiet
        {
            get { return idChiTiet; }
            set
            {
                if (idChiTiet != value) NotifyChange();
                idChiTiet = value;
            }
        }

        private int idKhuyenMai;
        public int IdKhuyenMai
        {
            get { return idKhuyenMai; }
            set
            {
                if (idKhuyenMai != value) NotifyChange();
                idKhuyenMai = value;
            }
        }

        private int _idHangKM;
        public int IdHangKM
        {
            get { return _idHangKM; }
            set
            {
                if (_idHangKM != value) NotifyChange();
                _idHangKM = value;
            }
        }


        private string _maHangKM;
        public string MaHangKM
        {
            get { return _maHangKM; }
            set
            {
                if (_maHangKM != value) NotifyChange();
                _maHangKM = value;
            }
        }

        private string _tenHangKM;
        public string TenHangKM
        {
            get { return _tenHangKM; }
            set
            {
                if (_tenHangKM != value) NotifyChange();
                _tenHangKM = value;
            }
        }

        private int _soLuong;
        public int SoLuong
        {
            get { return _soLuong; }
            set
            {
                if (_soLuong != value) NotifyChange();
                _soLuong = value;
            }
        }

        private double _soTienKM;
        public double SoTienKM
        {
            get { return _soTienKM; }
            set
            {
                if (_soTienKM != value) NotifyChange();
                _soTienKM = value;
            }
        }

        private string ghiChu;
        public string GhiChu
        {
            get { return ghiChu; }
            set
            {
                if (ghiChu != value) NotifyChange();
                ghiChu = value;
            }
        }

        private int inKemHD;
        public int InKemHD
        {
            get { return inKemHD; }
            set
            {
                if (inKemHD != value) NotifyChange();
                inKemHD = value;
            }
        }

        private int hetTonDungKM;
        public int HetTonDungKM
        {
            get { return hetTonDungKM; }
            set
            {
                if (hetTonDungKM != value) NotifyChange();
                hetTonDungKM = value;
            }
        }

        private double _tyLeKM;
        public double TyLeKM
        {
            get { return _tyLeKM; }
            set
            {
                if (_tyLeKM != value) NotifyChange();
                _tyLeKM = value;
            }
        }

        private int _loaiHangKM;
        public int LoaiHangKM
        {
            get { return _loaiHangKM; }
            set
            {
                if (_loaiHangKM != value) NotifyChange();
                _loaiHangKM = value;
            }
        }

        public string TenLoaiHangKM { get; set; }

        private string _maHangSX;
        public string MaHangSX
        {
            get { return _maHangSX; }
            set
            {
                if (_maHangSX != value) NotifyChange();
                _maHangSX = value;
            }
        }

        private string _tenHangSX;
        public string TenHangSX
        {
            get { return _tenHangSX; }
            set
            {
                if (_tenHangSX != value) NotifyChange();
                _tenHangSX = value;
            }
        }

        private int _suDung;
        public int SuDung
        {
            get { return _suDung; }
            set
            {
                if (_suDung != value) NotifyChange();
                _suDung = value;
            }
        }

        public int ChietKhau { get; set; }

        public int TonKho { get; set; }

        public int TongAll { get; set; }

        public int NoKhuyenMai { get; set; }

        private double _soTienYeuCau;
        public double SoTienYeuCau
        {
            get { return _soTienYeuCau; }
            set
            {
                if (_soTienYeuCau != value) NotifyChange();
                _soTienYeuCau = value;
            }
        }

        private int _soLuongOld;
        public int SoLuongOld
        {
            get { return _soLuongOld; }
            set
            {
                if (_soLuongOld != value) NotifyChange();
                _soLuongOld = value;
            }
        }

        private double _tyLeThanhToan;
        public double TyLeThanhToan
        {
            get { return _tyLeThanhToan; }
            set
            {
                if (_tyLeThanhToan != value) NotifyChange();
                _tyLeThanhToan = value;
            }
        }
        private int _dongBoWebSite;
        public int DongBoWebSite
        {
            get { return _dongBoWebSite; }
            set
            {
                if (_dongBoWebSite != value) NotifyChange();
                _dongBoWebSite = value;
            }
        }

        public string ChinhSachKhuyenMai { get; set; }
        public double GiaVon { get; set; }
        public double TyLeDiemThuong { get; set; }//ty le diem thuong
        public int SoDiemThuong { get; set; }//so diem thuong tuyet doi (uu tien hon ty le diem thuong)
    }
}
