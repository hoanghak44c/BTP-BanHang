using System;
using System.Collections.Generic;
using QLBanHang.Modules.BanHang.Infors;
using QLBH.Common;
using QLBH.Core.Data;

namespace QLBanHang.Modules.BanHang.DAO
{
    public class LichSuGiaBanDAO : BaseDAO
    {
        private static LichSuGiaBanDAO instance;

        private LichSuGiaBanDAO()
        {
        }

        public static LichSuGiaBanDAO Instance
        {
            get { return instance ?? (instance = new LichSuGiaBanDAO()); }
        }

        public List<LichSuGiaBanInfor> GetLichSuGia(string maTrungTam, string maSanPham)
        {
            return GetListCommand<LichSuGiaBanInfor>(Declare.StoreProcedureNamespace.spGetLichSuGia, maTrungTam,
                                                     maSanPham);
        }

        public List<LichSuGiaBanInfor> GetLichSuThayDoiGia()
        {
            return GetListCommand<LichSuGiaBanInfor>(Declare.StoreProcedureNamespace.spGetLichSuThayDoiGia);
        }
    }
}