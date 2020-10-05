using System;
using System.Collections.Generic;
using QLBanHang.Modules.BanHang.Infors;
using QLBH.Common;
using QLBH.Core.Data;
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang.DAO
{
    public class DonHangChiTietDAO : Base3Dao
    {

        private static DonHangChiTietDAO instance;

        private DonHangChiTietDAO()
        {
        }

        public static DonHangChiTietDAO Instance
        {
            get { return instance ?? (instance = new DonHangChiTietDAO()); }
        }

        public List<StorageInfor1> GetListComputedStorage(DateTime runningDate, int filterIdTrungTam)
        {
            var lstParams = new List<object>();

            var cmdText = @"select distinct t.idtrungtam, to_date(:runningDate, 'dd/mm/rrrr') runningdate
                from tbl_chungtu t where t.loaichungtu in (8,9,10,33,34,35,36,42,50)
                    and (t.loaichungtu IN (8,9,10,35,36,50) AND t.ngaylap >= to_date(:runningDate,'dd/MM/rrrr')
                        OR t.loaichungtu IN (33,34,42) AND t.ngayxuathang >= to_date(:runningDate,'dd/MM/rrrr'))
                    and (t.loaichungtu IN (8,9,10,35,36,50) AND t.ngaylap < to_date(:runningDate,'dd/MM/rrrr')+1
                        OR t.loaichungtu IN (33,34,42) AND t.ngayxuathang < to_date(:runningDate,'dd/MM/rrrr')+1)";

            lstParams.Add(runningDate.ToString("dd/MM/yyyy"));

            if (filterIdTrungTam > 0)
            {
                cmdText += " and t.idtrungtam = :runningTrungTam";

                lstParams.Add(filterIdTrungTam);
            }
            var result = GetListCommand<StorageInfor1>(cmdText, lstParams.ToArray());

            if (!result.Exists(delegate(StorageInfor1 match) { return match.IdTrungTam == 3; }))

                result.Add(new StorageInfor1 {IdTrungTam = 3, RunningDate = runningDate});

            return result;
        }

        public List<ChungTuBanHangChiTietBCInfor> Search(TimKiemChungTuChiTietFilterInfor filter)
        {
            return
                GetListCommand<ChungTuBanHangChiTietBCInfor>(
                    Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemCTietPg,
                    filter.SoPhieu, filter.LoaiDonHang, filter.TrangThai, filter.IdTrungTam, filter.IdKho,
                    filter.SanPham, filter.MaHang, filter.LoaiMaHang, filter.NhanVien,
                    clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay), filter.KhachHang,
                    filter.GhiChu, filter.UserName, filter.SoBatDau, filter.SoKetThuc, filter.IdNhanVien,
                    filter.IdNhomNguoiDung);
        }
    }
}