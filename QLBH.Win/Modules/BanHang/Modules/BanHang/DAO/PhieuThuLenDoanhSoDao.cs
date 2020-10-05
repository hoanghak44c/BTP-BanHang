using System;
using System.Collections.Generic;
using System.Data;
using QLBanHang.Modules.BanHang.Infors;
using QLBH.Common;
using QLBH.Core.Data;

namespace QLBanHang.Modules.BanHang.DAO
{
    public class StorageInfor
    {
        public int IdKho { get; set; }

        public int IdTrungTam { get; set; }

        public DateTime RunningDate { get; set; }
    }

    public class PhieuThuLenDoanhSoDao : Base3Dao
    {

        private static PhieuThuLenDoanhSoDao instance;

        private PhieuThuLenDoanhSoDao()
        {
        }

        public static PhieuThuLenDoanhSoDao Instance
        {
            get { return instance ?? (instance = new PhieuThuLenDoanhSoDao()); }
        }

        public List<StorageInfor> GetListComputedStorage(DateTime runningDate, int runningTrungTam, int runningKho)
        {
            var lstParams = new List<object>();

            string cmdText =
                @"select distinct ct.idkho, ct.idtrungtam, to_date(:runningDate, 'dd/mm/rrrr') runningdate
	                    from tbl_chungtu ct
                     where ((ct.loaichungtu in (8, 9, 10, 35, 36, 50)
	                     and ct.ngaylap >= to_date(:runningDate, 'dd/mm/rrrr')
                         and ct.ngaylap < to_date(:runningDate, 'dd/mm/rrrr') + 1)                         
                         or (ct.loaichungtu in (33, 42)
                         and ct.ngayxuathang >= to_date(:runningDate, 'dd/mm/rrrr')
                         and ct.ngayxuathang < to_date(:runningDate, 'dd/mm/rrrr') + 1))";

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

        public void TimKiemDoanhSoCTietPg(TimKiemChungTuFilterInfor filter, DataTable dataTable)
        {
            FillToDataTable(dataTable, Declare.StoreProcedureNamespace.spChungTuBanHangTKiemDoanhSoPg,
                                                        filter.SoPhieu, filter.LoaiDonHang, filter.TrangThai, filter.IdTrungTam,
                                                        filter.IdKho, filter.SanPham, filter.MaHang, filter.LoaiMaHang, filter.NhanVien,
                                                        filter.KhachHang, clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
                                                        filter.UserName, filter.IdNhanVien, filter.SoBatDau, filter.SoKetThuc, filter.IdNhomNguoiDung);
        }
    }
}