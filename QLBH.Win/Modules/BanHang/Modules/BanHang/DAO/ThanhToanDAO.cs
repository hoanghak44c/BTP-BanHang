using System;
using System.Collections.Generic;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.BanHang.Infors;

namespace QLBanHang.Modules.BanHang.DAO
{
    public class BaoCaoTongHopCongNoKhachHangDao : Base3Dao
    {
        private static BaoCaoTongHopCongNoKhachHangDao instance;

        public static BaoCaoTongHopCongNoKhachHangDao Instance
        {
            get { return instance ?? (instance = new BaoCaoTongHopCongNoKhachHangDao()); }
        }
        public List<CongNoBanHangInfor> LoadCongNoKhachHang(int idKhachHang, int soBatDau, int soKetThuc)
        {
            if (idKhachHang > 0)
            {
                return
                    GetListCommand<CongNoBanHangInfor>(
                        @"select dt.iddoituong, dt.madoituong, dt.tendoituong, dt.giatrimuahang, 
                            dt.hanmuctindung AS TongHanMucTinDung, dt.hanmuctdconlai AS HanMucTinDungConLai, 
                            dt.congnokhachhang AS CongNoBanHang, dt.Ngaycapnhatcongno AS NgayCapNhat
                         from tbl_DM_DoiTuong dt where dt.iddoituong = :idDoiTuong",
                        idKhachHang);
            }
            return
                GetListCommand<CongNoBanHangInfor>(
                    @"select dt.iddoituong, dt.madoituong, dt.tendoituong, dt.giatrimuahang, 
                            dt.hanmuctindung AS TongHanMucTinDung, dt.hanmuctdconlai AS HanMucTinDungConLai, 
                            dt.congnokhachhang AS CongNoBanHang, dt.Ngaycapnhatcongno AS NgayCapNhat
                         from tbl_DM_DoiTuong dt where dt.iddoituong between :soBatDau and :soKetThuc",
                    soBatDau, soKetThuc);
        }
        public int GetMaxValue()
        {
            return GetObjectCommand<int>("select max(dt.iddoituong) from tbl_dm_doituong dt");
        }

    }
    public class BaoCaoTongHopCongNoTrungTamDao : Base3Dao
    {
        private static BaoCaoTongHopCongNoTrungTamDao instance;

        public static BaoCaoTongHopCongNoTrungTamDao Instance
        {
            get { return instance ?? (instance = new BaoCaoTongHopCongNoTrungTamDao()); }
        }
        public List<CongNoBanHangInfor> LoadCongNoTrungTam(int idTrungTam, int idKhachHang, int soBatDau, int soKetThuc)
        {
            if(idKhachHang > 0)
            {
                return
                    GetListCommand<CongNoBanHangInfor>(
                        @"SELECT tt.idtrungtam,
			                 tt.matrungtam,
			                 tt.tentrungtam,
			                 dt.iddoituong,
			                 dt.madoituong,
			                 dt.tendoituong,
			                 dt.giatrimuahang,
			                 dt.hanmuctindung AS TongHanMucTinDung,
			                 cn.congno        AS CongNoBanHang,
			                 cn.last_update   AS NgayCapNhat
	                FROM tbl_CongNo_BanHang cn
                 INNER JOIN Tbl_Dm_Trungtam tt
		                ON cn.idtrungtam = tt.idtrungtam
                 INNER JOIN tbl_dm_doituong dt
		                ON cn.iddoituong = dt.iddoituong
                 WHERE tt.idtrungtam = :idTrungTam
	                 AND dt.iddoituong = :idDoiTuong",
                        idTrungTam, idKhachHang);
            }
            return
                GetListCommand<CongNoBanHangInfor>(
                    @"SELECT tt.idtrungtam,
			                 tt.matrungtam,
			                 tt.tentrungtam,
			                 dt.iddoituong,
			                 dt.madoituong,
			                 dt.tendoituong,
			                 dt.giatrimuahang,
			                 dt.hanmuctindung AS TongHanMucTinDung,
			                 cn.congno        AS CongNoBanHang,
			                 cn.last_update   AS NgayCapNhat
	                FROM tbl_CongNo_BanHang cn
                 INNER JOIN Tbl_Dm_Trungtam tt
		                ON cn.idtrungtam = tt.idtrungtam
                 INNER JOIN tbl_dm_doituong dt
		                ON cn.iddoituong = dt.iddoituong
                 WHERE tt.idtrungtam = :idTrungTam
	                 AND dt.iddoituong between :soBatDau and :soKetThuc",
                    idTrungTam, soBatDau, soKetThuc);
        }
        public int GetMaxValue()
        {
            return GetObjectCommand<int>("select max(dt.iddoituong) from tbl_dm_doituong dt");
        }

    }
    public class ThanhToanDAO : BaseDAO
    {
        private static ThanhToanDAO instance;
        private ThanhToanDAO()
        {
            //CRUDTableName = Declare.TableNamespace.BangGia;
            //UseCaching = true;
        }
        public static ThanhToanDAO Instance
        {
            get
            {
                if (instance == null) instance = new ThanhToanDAO();
                return instance;
            }
        }

        public List<ChungTuThanhToanInfor> LoadAllThanhToan()
        {
            return GetListCommand<ChungTuThanhToanInfor>(Declare.StoreProcedureNamespace.spChungTuThanhToanGetAll);
        }
        public List<ChungTuThanhToanInfor> LoadAllThanhToanByCTu(int idChungTu)
        {
            return GetListCommand<ChungTuThanhToanInfor>(Declare.StoreProcedureNamespace.spChungTuThanhToanGetByCT, idChungTu);
        }
        public ChungTuThanhToanInfor LoadThanhToanById(int idThanhToan)
        {
            return GetObjectCommand<ChungTuThanhToanInfor>(Declare.StoreProcedureNamespace.spChungTuThanhToanGetByTT, idThanhToan);
        }

        public void Update(ChungTuThanhToanInfor thanhToan)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuThanhToanUpdate, thanhToan.IdThanhToan, thanhToan.IdChungTu, thanhToan.SoPhieu,
                            thanhToan.NgayLap, thanhToan.IdThuNgan, thanhToan.IdHinhThucThanhToan, thanhToan.HoTen, thanhToan.DiaChi, thanhToan.DienThoai,
                            thanhToan.SoTaiKhoan, thanhToan.IdNganHangThanhToan, thanhToan.MaThe, thanhToan.DuoiThe, thanhToan.IdNganHangPhatHanhThe,
                            thanhToan.NoiDungThanhToan, thanhToan.SoTienThanhToan, thanhToan.IdTienTe, thanhToan.TyGia, thanhToan.SoTienChu, thanhToan.IdThoiHanThanhToan,
                            thanhToan.NguoiSua, thanhToan.TenMaySua, thanhToan.LoaiPhieu, thanhToan.LoaiGiaoDich,
                            thanhToan.TaiKhoanQuy, thanhToan.IdTrungTamThu, thanhToan.TenThuNgan, thanhToan.ChuTaiKhoan);
        }

        public int Insert(ChungTuThanhToanInfor thanhToan)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuThanhToanInsert, thanhToan.IdThanhToan, thanhToan.IdChungTu, thanhToan.SoPhieu,
                            thanhToan.NgayLap, thanhToan.IdThuNgan, thanhToan.IdHinhThucThanhToan, thanhToan.HoTen, thanhToan.DiaChi, thanhToan.DienThoai,
                            thanhToan.SoTaiKhoan, thanhToan.IdNganHangThanhToan, thanhToan.MaThe, thanhToan.DuoiThe, thanhToan.IdNganHangPhatHanhThe,
                            thanhToan.NoiDungThanhToan, thanhToan.SoTienThanhToan, thanhToan.IdTienTe, thanhToan.TyGia, thanhToan.SoTienChu, thanhToan.IdThoiHanThanhToan,
                            thanhToan.NguoiTao, thanhToan.TenMayTao, thanhToan.NguoiSua, thanhToan.TenMaySua, thanhToan.LoaiPhieu, thanhToan.LoaiGiaoDich, 
                            thanhToan.TaiKhoanQuy, thanhToan.IdTrungTamThu, thanhToan.TenThuNgan, thanhToan.ChuTaiKhoan);

            return Common.IntValue(Parameters["p_IdThanhToan"].Value);
        }

        public void Delete(int idThanhToan)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuThanhToanDelete, idThanhToan);
        }

        public void DeleteAll(int idChungTu)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuThanhToanDeleteAll, idChungTu);
        }
        public bool ExistSoPhieuThanhToan(string soPhieu)
        {
            return Convert.ToInt32(ExecuteScalar(
                @"select count(*) from tbl_chungtu_thanhtoan where sophieu = :sophieu", soPhieu)) > 0;
        }
    }
}
