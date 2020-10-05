using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QLBH.Core.Infors;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class BangGiaADDKMuaInfor : NotifyInfo
    {
        private int _idDKMua;
        public int IdDKMua
        {
            get { return _idDKMua; }
            set
            {
                if (_idDKMua != value) NotifyChange();
                _idDKMua = value;
            }
        }

        private int _idChinhSach;
        public int IdChinhSach
        {
            get { return _idChinhSach; }
            set
            {
                if (_idChinhSach != value) NotifyChange();
                _idChinhSach = value;
            }
        }

        private int _idHangMua;
        public int IdHangMua
        {
            get { return _idHangMua; }
            set
            {
                if (_idHangMua != value) NotifyChange();
                _idHangMua = value;
            }
        }


        private string _maHangMua;
        public string MaHangMua
        {
            get { return _maHangMua; }
            set
            {
                if (_maHangMua != value) NotifyChange();
                _maHangMua = value;
            }
        }

        private string _tenHangMua;
        public string TenHangMua
        {
            get { return _tenHangMua; }
            set
            {
                if (_tenHangMua != value) NotifyChange();
                _tenHangMua = value;
            }
        }

        private int _soLuongDuocMua;
        public int SoLuongDuocMua
        {
            get { return _soLuongDuocMua; }
            set
            {
                if (_soLuongDuocMua != value) NotifyChange();
                _soLuongDuocMua = value;
            }
        }

        private int _soLuongPhaiMua;
        public int SoLuongPhaiMua
        {
            get { return _soLuongPhaiMua; }
            set
            {
                if (_soLuongPhaiMua != value) NotifyChange();
                _soLuongPhaiMua = value;
            }
        }

        private double _tyLePhanBo;
        public double TyLePhanBo
        {
            get { return _tyLePhanBo; }
            set
            {
                if (_tyLePhanBo != value) NotifyChange();
                _tyLePhanBo = value;
            }
        }

        private int _loaiHangMua;
        public int LoaiHangMua
        {
            get { return _loaiHangMua; }
            set
            {
                if (_loaiHangMua != value) NotifyChange();
                _loaiHangMua = value;
            }
        }

        public string TenLoaiHangMua { get; set; }

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

        private double _giaMuaTu;
        public double GiaMuaTu
        {
            get { return _giaMuaTu; }
            set
            {
                if (_giaMuaTu != value) NotifyChange();
                _giaMuaTu = value;
            }
        }

        private double _giaMuaDen;
        public double GiaMuaDen
        {
            get { return _giaMuaDen; }
            set
            {
                if (_giaMuaDen != value) NotifyChange();
                _giaMuaDen = value;
            }
        }

        public string KhuyenMai { get; set; }

        public string KhuyenMaiMa { get; set; }

        public string SanPhamKem { get; set; }

        public string SanPhamKemMa { get; set; }

        public string SanPhamDaMua { get; set; }

        public string SanPhamDaMuaMa { get; set; }

        public string SanPhamNoAD { get; set; }

        public string SanPhamNoADMa { get; set; }

        public string SanPhamYesAD { get; set; }

        public string SanPhamYesADMa { get; set; }

        private List<BangGiaADSPKemInfor> _listSanPhamKem;
        public List<BangGiaADSPKemInfor> ListSanPhamKem
        {
            get { return _listSanPhamKem; }
            set
            {
                if (_listSanPhamKem != value) NotifyChange();
                _listSanPhamKem = value;
            }
        }

        private List<BangGiaADKhuyenMaiInfor> _listKhuyenMai;
        public List<BangGiaADKhuyenMaiInfor> ListKhuyenMai
        {
            get { return _listKhuyenMai; }
            set
            {
                if (_listKhuyenMai != value) NotifyChange();
                _listKhuyenMai = value;
            }
        }

        private List<BangGiaADSPDaMuaInfor> _listSanPhamDaMua;
        public List<BangGiaADSPDaMuaInfor> ListSanPhamDaMua
        {
            get { return _listSanPhamDaMua; }
            set
            {
                if (_listSanPhamDaMua != value) NotifyChange();
                _listSanPhamDaMua = value;
            }
        }

        private List<BangGiaADSPNoADInfor> _listSanPhamNoAD;
        public List<BangGiaADSPNoADInfor> ListSanPhamNoAD
        {
            get { return _listSanPhamNoAD; }
            set
            {
                if (_listSanPhamNoAD != value) NotifyChange();
                _listSanPhamNoAD = value;
            }
        }

        private List<BangGiaADSPNoADInfor> _listSanPhamYesAD;
        public List<BangGiaADSPNoADInfor> ListSanPhamYesAD
        {
            get { return _listSanPhamYesAD; }
            set
            {
                if (_listSanPhamYesAD != value) NotifyChange();
                _listSanPhamYesAD = value;
            }
        }

        private int _soLuongToiDaDH;
        public int SoLuongToiDaDH
        {
            get { return _soLuongToiDaDH; }
            set
            {
                if (_soLuongToiDaDH != value) NotifyChange();
                _soLuongToiDaDH = value;
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

        private int _soLuongToiDaCK;
        public int SoLuongToiDaCK
        {
            get { return _soLuongToiDaCK; }
            set
            {
                if (_soLuongToiDaCK != value) NotifyChange();
                _soLuongToiDaCK = value;
            }
        }

        private double _tyLeDiemThuong;
        public double TyLeDiemThuong
        {
            get { return _tyLeDiemThuong; }
            set
            {
                if (_tyLeDiemThuong != value) NotifyChange();
                _tyLeDiemThuong = value;
            }
        }

        private int _soDiemThuong;//so diem thuong tuyet doi (uu tien hon ty le diem thuong)
        public int SoDiemThuong
        {
            get { return _soDiemThuong; }
            set
            {
                if (_soDiemThuong != value) NotifyChange();
                _soDiemThuong = value;
            }
        }

        private string _khuyenMaiWeb;
        public string KhuyenMaiWeb
        {
            get { return _khuyenMaiWeb; }
            set
            {
                if (_khuyenMaiWeb != value) NotifyChange();
                _khuyenMaiWeb = value;
            }
        }

        private double _giaTriMuaToiThieu;
        public double GiaTriMuaToiThieu
        {
            get { return _giaTriMuaToiThieu; }
            set
            {
                if (_giaTriMuaToiThieu != value) NotifyChange();
                _giaTriMuaToiThieu = value;
            }
        }

        private int _inHoaDon;
        public int InHoaDon
        {
            get { return _inHoaDon; }
            set
            {
                if (_inHoaDon != value) NotifyChange();
                _inHoaDon = value;
            }
        }

        public int SoThuTu { get; set; }

        private string _maVachApDung;
        public string MaVachApDung
        {
            get { return _maVachApDung; }
            set
            {
                if (_maVachApDung != value) NotifyChange();
                _maVachApDung = value;
            }
        }
    }
}
