using System;
using System.Collections.Generic;
using QLBanHang.Modules.BanHang.DAO;
using QLBanHang.Modules.BanHang.Infors;

namespace QLBanHang.Modules.BanHang.Providers
{
    public class KichHoatBaoHanhDataProvider
    {

        private static KichHoatBaoHanhDataProvider instance;

        private KichHoatBaoHanhDataProvider()
        {
        }

        public static KichHoatBaoHanhDataProvider Instance
        {
            get { return instance ?? (instance = new KichHoatBaoHanhDataProvider()); }
        }

        public List<StorageInfor> GetListComputedStorage(DateTime runningDate, int runningTrungTam, int runningKho)
        {
            return KichHoatBaoHanhDao.Instance.GetListComputedStorage(runningDate, runningTrungTam, runningKho);
        }
        public List<ChungTuBanHangChiTietHangHoaBHInfor> TimKiemChungTuChiTietMaVachBaoHanhPg(TimKiemChungTuChiTietFilterInfor filter)
        {
            return KichHoatBaoHanhDao.Instance.TimKiemChungTuChiTietMaVachBaoHanhPg(filter);
        }
    }
}