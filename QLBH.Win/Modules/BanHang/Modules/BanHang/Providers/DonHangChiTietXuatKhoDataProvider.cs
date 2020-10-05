using System;
using System.Collections.Generic;
using System.Data;
using QLBanHang.Modules.BanHang.DAO;
using QLBanHang.Modules.BanHang.Infors;

namespace QLBanHang.Modules.BanHang.Providers
{
    public class DonHangChiTietXuatKhoDataProvider
    {

        private static DonHangChiTietXuatKhoDataProvider instance;

        private DonHangChiTietXuatKhoDataProvider()
        {
        }

        public static DonHangChiTietXuatKhoDataProvider Instance
        {
            get { return instance ?? (instance = new DonHangChiTietXuatKhoDataProvider()); }
        }

        public List<StorageInfor> GetListComputedStorage(string belongTo, DateTime runningDate, int runningIdTrungTam, int runningIdKho)
        {
            return DonHangChiTietXuatKhoDAO.Instance.GetListComputedStorage(belongTo, runningDate, runningIdTrungTam, runningIdKho);
        }
        public void TimKiemChungTuChiTietMaVachPg(TimKiemChungTuChiTietFilterInfor filter, DataTable dataTable)
        {
            DonHangChiTietXuatKhoDAO.Instance.TimKiemChungTuChiTietMaVachPg(filter, dataTable);

            if (dataTable.PrimaryKey.Length == 0)
            {
                dataTable.PrimaryKey = new[]
                                           {
                                               dataTable.Columns["IDCHUNGTUCHITIET"],

                                               dataTable.Columns["IDCHITIETHANGHOA"]
                                           };
            }
        }
    }
}