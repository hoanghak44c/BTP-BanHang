using System;
using System.Collections.Generic;
using QLBanHang.Modules.BanHang.Infors;
using QLBH.Common;
using QLBH.Core.Data;

namespace QLBanHang.Modules.BanHang.DAO
{
    public class CongNoPosAr0400Dao : BaseDAO
    {

        private static CongNoPosAr0400Dao instance;

        private CongNoPosAr0400Dao()
        {
        }

        public static CongNoPosAr0400Dao Instance
        {
            get { return instance ?? (instance = new CongNoPosAr0400Dao()); }
        }

        public List<CongNoPosAr0400Info> GetReport(int idDoiTuong, int idNhanVien, int idKho, int idTrungTam, DateTime runningDate, int conNo)
        {
            return GetListCommand<CongNoPosAr0400Info>(
                Declare.StoreProcedureNamespace.spCongNoPosAr0400,
                idDoiTuong, idNhanVien, idKho, idTrungTam, runningDate, runningDate, conNo);
        }
    }
}