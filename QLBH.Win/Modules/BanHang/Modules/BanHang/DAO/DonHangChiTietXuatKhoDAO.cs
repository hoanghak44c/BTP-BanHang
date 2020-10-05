using System;
using System.Collections.Generic;
using System.Data;
using QLBanHang.Modules.BanHang.Infors;
using QLBH.Common;
using QLBH.Core.Data;

namespace QLBanHang.Modules.BanHang.DAO
{
    public class DonHangChiTietXuatKhoDAO : Base3Dao
    {

        private static DonHangChiTietXuatKhoDAO instance;

        private DonHangChiTietXuatKhoDAO()
        {
        }

        public static DonHangChiTietXuatKhoDAO Instance
        {
            get { return instance ?? (instance = new DonHangChiTietXuatKhoDAO()); }
        }

        public List<StorageInfor> GetListComputedStorage(string belongTo, DateTime runningDate, int runningTrungTam, int runningKho)
        {
            var lstParams = new List<object>();
            var result = new List<StorageInfor>();

            string cmdText =
                @"select distinct ct.idtrungtam, to_date(:runningDate, 'dd/mm/rrrr') runningdate
	                    from tbl_chungtu ct 
                        inner join tbl_chungtu dh on ct.sochungtugoc = dh.sochungtu
                        inner join tbl_dm_kho kho on dh.idkho = kho.idkho
                     where ct.loaichungtu = 49 and dh.loaichungtu in (8, 9, 10, 35, 36)";

            if (belongTo == "ngaylap")
                
                cmdText +=
                    @" and dh.ngaylap >= to_date(:runningDate, 'dd/mm/rrrr')
                         and dh.ngaylap < to_date(:runningDate, 'dd/mm/rrrr') + 1";
            else

                cmdText +=
                    @" and ct.ngayxuathang >= to_date(:runningDate, 'dd/mm/rrrr')
                         and ct.ngayxuathang < to_date(:runningDate, 'dd/mm/rrrr') + 1";

            lstParams.Add(runningDate.ToString("dd/MM/yyyy"));

            if (runningTrungTam > 0)
            {
                cmdText += " and (dh.idtrungtam = :runningTrungTam or kho.idtrungtam = :runningTrungTam)";

                lstParams.Add(runningTrungTam);
            }

            if (runningKho > 0)
            {
                cmdText += " and dh.idkho = :runningKho";

                lstParams.Add(runningKho);
            }

            result.AddRange(GetListCommand<StorageInfor>(cmdText, lstParams.ToArray()));

            cmdText =
                @" select distinct ct.idtrungtam, 
                    to_date(:runningDate, 'dd/mm/rrrr') runningdate
	                from tbl_chungtu ct 
                    inner join tbl_dm_kho kho on ct.idkho = kho.idkho
                    where ct.loaichungtu in (33, 34, 42)";

            if (belongTo == "ngaylap")

                cmdText +=
                    @" and ct.ngaylap >= to_date(:runningDate, 'dd/mm/rrrr')
                         and ct.ngaylap < to_date(:runningDate, 'dd/mm/rrrr') + 1";
            else

                cmdText +=
                    @" and ct.ngayxuathang >= to_date(:runningDate, 'dd/mm/rrrr')
                         and ct.ngayxuathang < to_date(:runningDate, 'dd/mm/rrrr') + 1";

            if (runningTrungTam > 0)
            {
                cmdText += " and (ct.idtrungtam = :runningTrungTam or kho.idtrungtam = :runningTrungTam)";
            }

            if (runningKho > 0)
            {
                cmdText += " and ct.idkho = :runningKho";
            }

            result.AddRange(GetListCommand<StorageInfor>(cmdText, lstParams.ToArray()));

            for (var i = 0; i < result.Count; i++)
            {
                for (var j = i + 1; j < result.Count; j++)
                {
                    if (result[i].IdKho == result[j].IdKho &&
                        result[i].IdTrungTam == result[j].IdTrungTam)
                    {
                        result.RemoveAt(j);
                        j--;
                    }
                    
                }
            }

            return result;
        }

        public void TimKiemChungTuChiTietMaVachPg(TimKiemChungTuChiTietFilterInfor filter, DataTable dataTable)
        {
            FillToDataTable(dataTable, Declare.StoreProcedureNamespace.spChungTuBanHangSearchCTietMVachPg,
                            filter.SoPhieu, filter.LoaiDonHang, filter.IdTrungTam, filter.IdKho, filter.SanPham,
                            filter.NhanVien,
                            clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
                            clsUtils.DateValue(filter.NXTuNgay), clsUtils.DateValue(filter.NXDenNgay), filter.KhachHang,
                            filter.GhiChu, filter.UserName, filter.MaVach, filter.TrangThai, filter.SoBatDau,
                            filter.SoKetThuc, filter.IdNhanVien, filter.IdNhomNguoiDung);
        }
    }
}