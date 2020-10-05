using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class BangGiaInfor
    {
        public BangGiaInfor()
        {
            
        }
        public BangGiaInfor(BangGiaSearchInfor bgs)
        {
            IdTrungTam = bgs.IdTrungTam;
            TenTrungTam = bgs.TenTrungTam;
            IdBangGia = bgs.IdBangGia;
            SoBangGia = bgs.SoBangGia;
            NgayLap = bgs.NgayLap;
            NguoiLap = bgs.NguoiLap;
            DaDuyet = bgs.DaDuyet;
            NgayDuyet = bgs.NgayDuyet;
            GhiChu = bgs.GhiChu;
            Draft = bgs.Draft;
            ListIdTrungTam = bgs.ListIdTrungTam;
            ListMaTrungTam = bgs.ListMaTrungTam;
            ListBangGiaChiTiet = bgs.ListBangGiaChiTiet;
        }
        public int IdTrungTam { get; set; }

        public string TenTrungTam { get; set; }

        public int IdBangGia { get; set; }

        public string SoBangGia { get; set; }

        public DateTime NgayLap { get; set; }

        public string NguoiLap { get; set; }

        public int DaDuyet { get; set; }

        public DateTime NgayDuyet { get; set; }

        public string GhiChu { get; set; }

        public int Draft { get; set; }

        public string NguoiTao { get; set; }

        public DateTime NgayTao { get; set; }

        public string NguoiCapNhat { get; set; }

        public DateTime NgayCapNhat { get; set; }

        public int TongSoMatHang { get; set; }

        public int SoMatHangChuaDuyet { get; set; }

        public int SoMatHangDaDuyet { get; set; }

        public List<BangGiaChiTietInfor> ListBangGiaChiTiet { get; set; }

        public string ListIdTrungTam { get; set; }

        public string ListMaTrungTam { get; set; }
    }
}
