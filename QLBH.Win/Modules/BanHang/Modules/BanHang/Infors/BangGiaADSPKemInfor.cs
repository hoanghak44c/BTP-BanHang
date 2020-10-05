using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QLBH.Core.Infors;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class BangGiaADSPKemInfor : NotifyInfo
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

        private int _idHangKem;
        public int IdHangKem
        {
            get { return _idHangKem; }
            set
            {
                if (_idHangKem != value) NotifyChange();
                _idHangKem = value;
            }
        }


        private string _maHangKem;
        public string MaHangKem
        {
            get { return _maHangKem; }
            set
            {
                if (_maHangKem != value) NotifyChange();
                _maHangKem = value;
            }
        }

        private string _tenHangKem;
        public string TenHangKem
        {
            get { return _tenHangKem; }
            set
            {
                if (_tenHangKem != value) NotifyChange();
                _tenHangKem = value;
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

        private int _loaiHangKem;
        public int LoaiHangKem
        {
            get { return _loaiHangKem; }
            set
            {
                if (_loaiHangKem != value) NotifyChange();
                _loaiHangKem = value;
            }
        }

        public string TenLoaiHangKem { get; set; }

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
        public int TonKho { get; set; }

        public int TrangThaiTon { get; set; }

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

        public string GhiChu { get; set; }
    }
}
