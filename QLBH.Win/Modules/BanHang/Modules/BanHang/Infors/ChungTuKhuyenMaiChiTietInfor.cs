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
    public class ChungTuKhuyenMaiChiTietInfor : ChungTuChiTietBaseInfo
    {
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
    }
}
