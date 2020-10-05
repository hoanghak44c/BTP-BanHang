using System;
using System.Collections.Generic;
using System.Data;
using QLBanHang.Modules.BanHang.DAO;
using QLBanHang.Modules.BanHang.Infors;

namespace QLBanHang.Modules.BanHang.Providers
{
    public class PhieuThuLenDoanhSoDataProvider
    {

        private static PhieuThuLenDoanhSoDataProvider instance;

        private PhieuThuLenDoanhSoDataProvider()
        {
        }

        public static PhieuThuLenDoanhSoDataProvider Instance
        {
            get { return instance ?? (instance = new PhieuThuLenDoanhSoDataProvider()); }
        }

        public List<StorageInfor> GetListComputedStorage(DateTime runningDate, int runningTrungTam, int runningKho)
        {
            return PhieuThuLenDoanhSoDao.Instance.GetListComputedStorage(runningDate, runningTrungTam, runningKho);
        }

        public void TimKiemDoanhSoCTietPg(TimKiemChungTuFilterInfor filter, DataTable dataTable)
        {
            PhieuThuLenDoanhSoDao.Instance.TimKiemDoanhSoCTietPg(filter, dataTable);

            if (dataTable.PrimaryKey.Length == 0)
            {
                dataTable.PrimaryKey = new[] { dataTable.Columns["idchitiet"] };
            }
        }
    }
}