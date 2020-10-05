using System;
using System.Collections.Generic;
using QLBanHang.Modules.BanHang.Infors;
using QLBH.Common;
using QLBH.Core.Data;

namespace QLBanHang.Modules.BanHang.DAO
{
    public class KichHoatBaoHanhDao : Base3Dao
    {

        private static KichHoatBaoHanhDao instance;

        private KichHoatBaoHanhDao()
        {
        }

        public static KichHoatBaoHanhDao Instance
        {
            get { return instance ?? (instance = new KichHoatBaoHanhDao()); }
        }

        public List<StorageInfor> GetListComputedStorage(DateTime runningDate, int runningTrungTam, int runningKho)
        {
            var lstParams = new List<object>();

            string cmdText =
                @"select distinct ct.idkho, ct.idtrungtam, to_date(:runningDate, 'dd/mm/rrrr') runningdate
	                    from tbl_chungtu ct
                     where ct.loaichungtu in (49,33,42)
	                     and ct.ngaylap >= to_date(:runningDate, 'dd/mm/rrrr')
                         and ct.ngaylap < to_date(:runningDate, 'dd/mm/rrrr') + 1";

            lstParams.Add(runningDate.ToString("dd/MM/yyyy"));

            if (runningTrungTam > 0)
            {
                cmdText += " and ct.idtrungtam = :runningTrungTam";

                lstParams.Add(runningTrungTam);
            }

            if (runningKho > 0)
            {
                cmdText += " and ct.idkho = :runningKho";

                lstParams.Add(runningKho);
            }

            return GetListCommand<StorageInfor>(cmdText, lstParams.ToArray());
        }

        public List<ChungTuBanHangChiTietHangHoaBHInfor> TimKiemChungTuChiTietMaVachBaoHanhPg(TimKiemChungTuChiTietFilterInfor filter)
        {
            return GetListCommand<ChungTuBanHangChiTietHangHoaBHInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangSearchCTietMVachBHanhPg,
                                                       filter.SoPhieu, filter.IdTrungTam, filter.IdKho, filter.SanPham, filter.Nganh,
                                                       clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay), filter.KhachHang, filter.UserName, filter.MaVach, filter.HangSanXuat, filter.SoBatDau, filter.SoKetThuc, filter.LoaiDonHang, filter.LoaiMaVach);
        }
    }
}