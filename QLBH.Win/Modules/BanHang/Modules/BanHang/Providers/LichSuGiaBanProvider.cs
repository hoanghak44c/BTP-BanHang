using System;
using System.Collections.Generic;
using QLBanHang.Modules.BanHang.DAO;
using QLBanHang.Modules.BanHang.Infors;

namespace QLBanHang.Modules.BanHang.Providers
{
    public class LichSuGiaBanProvider
    {

        private static LichSuGiaBanProvider instance;

        private LichSuGiaBanProvider()
        {
        }

        public static LichSuGiaBanProvider Instance
        {
            get { return instance ?? (instance = new LichSuGiaBanProvider()); }
        }

        public List<LichSuGiaBanInfor> GetLichSuGia(string maTrungTam, string maSanPham)
        {
            return LichSuGiaBanDAO.Instance.GetLichSuGia(maTrungTam, maSanPham);
        }

        public List<LichSuGiaBanInfor> GetLichSuThayDoiGia()
        {
            return LichSuGiaBanDAO.Instance.GetLichSuThayDoiGia();
        }
    }
}