using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QLBH.Core.Infors;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class BangGiaADSPDaMuaInfor : NotifyInfo
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

        private int _idHangDaMua;
        public int IdHangDaMua
        {
            get { return _idHangDaMua; }
            set
            {
                if (_idHangDaMua != value) NotifyChange();
                _idHangDaMua = value;
            }
        }


        private string _maHangDaMua;
        public string MaHangDaMua
        {
            get { return _maHangDaMua; }
            set
            {
                if (_maHangDaMua != value) NotifyChange();
                _maHangDaMua = value;
            }
        }

        private string _tenHangDaMua;
        public string TenHangDaMua
        {
            get { return _tenHangDaMua; }
            set
            {
                if (_tenHangDaMua != value) NotifyChange();
                _tenHangDaMua = value;
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

        private int _loaiHangDaMua;
        public int LoaiHangDaMua
        {
            get { return _loaiHangDaMua; }
            set
            {
                if (_loaiHangDaMua != value) NotifyChange();
                _loaiHangDaMua = value;
            }
        }

        public string TenLoaiHangDaMua { get; set; }

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
    }
}
