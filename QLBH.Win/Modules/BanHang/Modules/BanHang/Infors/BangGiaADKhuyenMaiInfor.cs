using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QLBH.Core.Infors;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class BangGiaADKhuyenMaiInfor : NotifyInfo
    {
        public BangGiaADKhuyenMaiInfor()
        {
            
        }
        public BangGiaADKhuyenMaiInfor(BangGiaADKhuyenMaiInfor obj)
        {
            this.IdDKMua = obj.IdDKMua;
            this.IdKhuyenMai = obj.IdKhuyenMai;
            this.SoKhuyenMai = obj.SoKhuyenMai;
            this.GhiChu = obj.GhiChu;
            this.DoUuTien = obj.DoUuTien;
            this.SuDung = obj.SuDung;
            if (obj.ListKhuyenMaiChiTiet != null)
            {
                this.ListKhuyenMaiChiTiet = new List<BangGiaADKhuyenMaiChiTietInfor>();
                foreach (BangGiaADKhuyenMaiChiTietInfor kmct in obj.ListKhuyenMaiChiTiet)
                {
                    BangGiaADKhuyenMaiChiTietInfor km = new BangGiaADKhuyenMaiChiTietInfor(kmct);
                    this.ListKhuyenMaiChiTiet.Add(km);
                }
            }
        }
        private int _idKhuyenMai;
        public int IdKhuyenMai
        {
            get { return _idKhuyenMai; }
            set
            {
                if (_idKhuyenMai != value) NotifyChange();
                _idKhuyenMai = value;
            }
        }

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

        private string _soKhuyenMai;
        public string SoKhuyenMai
        {
            get { return _soKhuyenMai; }
            set
            {
                if (_soKhuyenMai != value) NotifyChange();
                _soKhuyenMai = value;
            }
        }

        private string _ghiChu;
        public string GhiChu
        {
            get { return _ghiChu; }
            set
            {
                if (_ghiChu != value) NotifyChange();
                _ghiChu = value;
            }
        }

        private int _doUuTien;
        public int DoUuTien
        {
            get { return _doUuTien; }
            set
            {
                if (_doUuTien != value) NotifyChange();
                _doUuTien = value;
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

        private List<BangGiaADKhuyenMaiChiTietInfor> _listKhuyenMaiChiTiet;
        public List<BangGiaADKhuyenMaiChiTietInfor> ListKhuyenMaiChiTiet
        {
            get { return _listKhuyenMaiChiTiet; }
            set
            {
                if (_listKhuyenMaiChiTiet != value) NotifyChange();
                _listKhuyenMaiChiTiet = value;
            }
        }
    }
}
