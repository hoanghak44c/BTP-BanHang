using System;
using System.Collections.Generic;
using QLBanHang.Modules.BanHang.DAO;
using QLBanHang.Modules.BanHang.Infors;

namespace QLBanHang.Modules.BanHang.Providers
{
    public class CongNoPosAr0400Provider
    {

        private static CongNoPosAr0400Provider instance;

        private CongNoPosAr0400Provider()
        {
        }

        public static CongNoPosAr0400Provider Instance
        {
            get { return instance ?? (instance = new CongNoPosAr0400Provider()); }
        }

        public List<CongNoPosAr0400Info> GetReport(int idDoiTuong, int idNhanVien, int idKho, int idTrungTam, DateTime runningDate, int conNo)
        {
            return CongNoPosAr0400Dao.Instance.GetReport(idDoiTuong, idNhanVien, idKho, idTrungTam, runningDate, conNo);
        }
    }
}