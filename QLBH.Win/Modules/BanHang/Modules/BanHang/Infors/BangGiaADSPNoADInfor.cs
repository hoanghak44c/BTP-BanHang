using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QLBH.Core.Infors;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class BangGiaADSPNoADInfor : NotifyInfo
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

        private int _idHangNoAD;
        public int IdHangNoAD
        {
            get { return _idHangNoAD; }
            set
            {
                if (_idHangNoAD != value) NotifyChange();
                _idHangNoAD = value;
            }
        }


        private string _maHangNoAD;
        public string MaHangNoAD
        {
            get { return _maHangNoAD; }
            set
            {
                if (_maHangNoAD != value) NotifyChange();
                _maHangNoAD = value;
            }
        }

        private string _tenHangNoAD;
        public string TenHangNoAD
        {
            get { return _tenHangNoAD; }
            set
            {
                if (_tenHangNoAD != value) NotifyChange();
                _tenHangNoAD = value;
            }
        }

        private int _loaiHangNoAD;
        public int LoaiHangNoAD
        {
            get { return _loaiHangNoAD; }
            set
            {
                if (_loaiHangNoAD != value) NotifyChange();
                _loaiHangNoAD = value;
            }
        }

        public string TenLoaiHangNoAD { get; set; }

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
    }
}
