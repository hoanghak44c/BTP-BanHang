using System;
using System.Collections.Generic;
using QLBanHang.Modules.BanHang.DAO;
using QLBanHang.Modules.BanHang.Infors;
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang.Providers
{
    public class DonHangChiTietDataProvider : IBcDataProvider<ChungTuBanHangChiTietBCInfor>
    {

        private static DonHangChiTietDataProvider instance;

        private DonHangChiTietDataProvider()
        {
        }

        public static DonHangChiTietDataProvider Instance
        {
            get { return instance ?? (instance = new DonHangChiTietDataProvider()); }
        }

        #region Implementation of IBcDataProvider<ChungTuBanHangChiTietBCInfor>

        public List<StorageInfor1> GetListComputedStorage(DateTime date, int idTrungTam)
        {
            return DonHangChiTietDAO.Instance.GetListComputedStorage(date, idTrungTam);
        }

        public List<ChungTuBanHangChiTietBCInfor> Search(IFilter filter)
        {
            return DonHangChiTietDAO.Instance.Search(filter as TimKiemChungTuChiTietFilterInfor);
        }

        #endregion
    }
}