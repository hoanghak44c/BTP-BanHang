using System;
using System.Collections.Generic;
using QLBanHang.Modules.BanHang.Infors;
using QLBH.Common;
using QLBH.Core.Data;
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang.DAO
{
    public class BaoCaoChiTietGiaoNhanDao: Base3Dao
    {

        private static BaoCaoChiTietGiaoNhanDao instance;

        private BaoCaoChiTietGiaoNhanDao()
        {
        }

        public static BaoCaoChiTietGiaoNhanDao Instance
        {
            get { return instance ?? (instance = new BaoCaoChiTietGiaoNhanDao()); }
        }

        internal List<StorageInfor1> GetListComputedStorage(DateTime runningDate, int filterIdTrungTam)
        {
            var paras = new List<object>();

            string sqlCmd = @"select distinct idtrungtam, to_date(:runningDate, 'dd/mm/rrrr') as runningDate from tbl_chungtu t
                where t.loaichungtu in (8,9,10,35,36)
                 and t.ngaylap >= to_date(:runningDate, 'dd/mm/rrrr')
                 and t.ngaylap < to_date(:runningDate, 'dd/mm/rrrr') + 1";

            paras.Add(runningDate.ToString("dd/MM/yyyy"));
            
            if(filterIdTrungTam > 0)
            {
                sqlCmd += " and t.idtrungtam = :filterIdTrungTam";

                paras.Add(filterIdTrungTam);
            }

            var result = GetListCommand<StorageInfor1>(sqlCmd, paras.ToArray());

            //phong kinh doanh thi truong

            if (!result.Exists(delegate(StorageInfor1 match) { return match.IdTrungTam == 3; }))

                result.Add(new StorageInfor1 { IdTrungTam = 3, RunningDate = runningDate });

            //kho tong

            if (!result.Exists(delegate(StorageInfor1 match) { return match.IdTrungTam == 9; }))

                result.Add(new StorageInfor1 { IdTrungTam = 9, RunningDate = runningDate });

            return result;
        }

        internal List<ChungTuBanHangGNhanCTietInfor> Search(TimKiemChungTuFilterInfor filter)
        {
            return
                GetListCommand<ChungTuBanHangGNhanCTietInfor>(
                    Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemCTGNCTiet,
                    filter.SoPhieu, filter.LoaiDonHang, filter.TrangThai, filter.IdTrungTam,
                    filter.IdKho, filter.SanPham, filter.MaHang, filter.LoaiMaHang, filter.NhanVien, filter.IdNhanVien,
                    clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
                    filter.KhachHang, filter.DiaChi, filter.CMND, filter.DienThoai, filter.GhiChu, filter.UserName);
        }
    }

    public class BaoCaoChiTietKyThuatGiaoNhanDao : Base3Dao
    {

        private static BaoCaoChiTietKyThuatGiaoNhanDao instance;

        private BaoCaoChiTietKyThuatGiaoNhanDao()
        {
        }

        public static BaoCaoChiTietKyThuatGiaoNhanDao Instance
        {
            get { return instance ?? (instance = new BaoCaoChiTietKyThuatGiaoNhanDao()); }
        }

        internal List<StorageInfor1> GetListComputedStorage(DateTime runningDate, int filterIdTrungTam)
        {
            var paras = new List<object>();

            string sqlCmd = @"select distinct idtrungtam, to_date(:runningDate, 'dd/mm/rrrr') as runningDate from tbl_chungtu t
                inner join Tbl_Chungtu_Giaonhan gn on t.idphieugiaonhan = gn.idgiaonhan
                where (t.loaichungtu in (10,35,36)
                    or t.loaichungtu = 8 and (t.trangthai NOT IN (5,20) and t.sochungtugoc is not null)
                    or t.loaichungtu = 9 and (t.trangthai not in (1,3,19) and t.sochungtugoc is not null))
                 and (t.trangthai in (9,11,12,22,26))
                 and nvl(gn.ngayhoanthanh, sysdate) >= to_date(:runningDate, 'dd/mm/rrrr')
                 and nvl(gn.ngayhoanthanh, sysdate) < to_date(:runningDate, 'dd/mm/rrrr') + 1";

            paras.Add(runningDate.ToString("dd/MM/yyyy"));

            if (filterIdTrungTam > 0)
            {
                sqlCmd += " and t.idtrungtam = :filterIdTrungTam";

                paras.Add(filterIdTrungTam);
            }
            var result = GetListCommand<StorageInfor1>(sqlCmd, paras.ToArray());
            
            //phong kinh doanh thi truong
            
            if (!result.Exists(delegate(StorageInfor1 match) { return match.IdTrungTam == 3; }))

                result.Add(new StorageInfor1 { IdTrungTam = 3, RunningDate = runningDate });

            //kho tong

            if (!result.Exists(delegate(StorageInfor1 match) { return match.IdTrungTam == 9; }))

                result.Add(new StorageInfor1 { IdTrungTam = 9, RunningDate = runningDate });

            return result;
        }

        internal List<ChungTuBanHangGNhanCTietInfor> Search(TimKiemGiaoNhanFilterInfor filter)
        {
            return
                GetListCommand<ChungTuBanHangGNhanCTietInfor>(
                    Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemCTGNCTietKThuatCTPg,
                    filter.SoPhieu, filter.LoaiDonHang, filter.TrangThai, filter.IdTrungTam,
                    filter.IdKho, filter.SanPham, filter.NhanVien, filter.DoiTac, clsUtils.DateValue(filter.TuNgay),
                    clsUtils.DateValue(filter.DenNgay),
                    filter.QuanHuyen, filter.PhuongTien, filter.VungMien, filter.UserName, filter.SoBatDau,
                    filter.SoKetThuc, filter.IdNhanVien);
        }
    }
}