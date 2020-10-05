using System;
using System.Collections.Generic;
using QLBanHang.Modules.BanHang.DAO;
using QLBanHang.Modules.BanHang.Infors;
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang.Providers
{
    public class BaoCaoChiTietGiaoNhanDataProvider : IBcDataProvider<ChungTuBanHangGNhanCTietInfor>
    {

        private static BaoCaoChiTietGiaoNhanDataProvider instance;

        private BaoCaoChiTietGiaoNhanDataProvider() { }

        public static BaoCaoChiTietGiaoNhanDataProvider Instance
        {
            get { return instance ?? (instance = new BaoCaoChiTietGiaoNhanDataProvider()); }
        }

        #region Implementation of IBcDataProvider

        List<StorageInfor1> IBcDataProvider<ChungTuBanHangGNhanCTietInfor>.GetListComputedStorage(DateTime date, int idTrungTam)
        {
            return BaoCaoChiTietGiaoNhanDao.Instance.GetListComputedStorage(date, idTrungTam);
        }

        List<ChungTuBanHangGNhanCTietInfor> IBcDataProvider<ChungTuBanHangGNhanCTietInfor>.Search(IFilter filter)
        {
            return BaoCaoChiTietGiaoNhanDao.Instance.Search(filter as TimKiemChungTuFilterInfor);
        }

        #endregion
    }

    public class BaoCaoChiTietKyThuatGiaoNhanDataProvider : IBcDataProvider<ChungTuBanHangGNhanCTietInfor>
    {

        private static BaoCaoChiTietKyThuatGiaoNhanDataProvider instance;

        private BaoCaoChiTietKyThuatGiaoNhanDataProvider() { }

        public static BaoCaoChiTietKyThuatGiaoNhanDataProvider Instance
        {
            get { return instance ?? (instance = new BaoCaoChiTietKyThuatGiaoNhanDataProvider()); }
        }

        public List<ChungTuBanHangGNhanCTietInfor> Search(IFilter filter)
        {
            return BaoCaoChiTietKyThuatGiaoNhanDao.Instance.Search(filter as TimKiemGiaoNhanFilterInfor);
        }

        #region Implementation of IBcDataProvider<ChungTuBanHangGNhanCTietInfor>

        List<StorageInfor1> IBcDataProvider<ChungTuBanHangGNhanCTietInfor>.GetListComputedStorage(DateTime date, int idTrungTam)
        {
            return BaoCaoChiTietKyThuatGiaoNhanDao.Instance.GetListComputedStorage(date, idTrungTam);
        }

        #endregion
    }
}