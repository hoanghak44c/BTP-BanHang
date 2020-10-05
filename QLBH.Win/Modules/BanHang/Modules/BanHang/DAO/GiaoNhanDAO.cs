using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.BanHang.Infors;

namespace QLBanHang.Modules.BanHang.DAO
{
    public class GiaoNhanDAO :BaseDAO
    {
        private static GiaoNhanDAO instance;
        private GiaoNhanDAO()
        {
            //CRUDTableName = Declare.TableNamespace.BangGia;
            //UseCaching = true;
        }
        public static GiaoNhanDAO Instance
        {
            get
            {
                if (instance == null) instance = new GiaoNhanDAO();
                return instance;
            }
        }

        #region chungtu giao nhan
        public ChungTuGiaoNhanInfor GetChungTuGiaoNhanGetById(int idGiaoNhan)
        {
            return GetObjectCommand<ChungTuGiaoNhanInfor>(Declare.StoreProcedureNamespace.spChungTuGiaoNhanGetAll, idGiaoNhan);
        }

        public ChungTuGiaoNhanInfor GetChungTuGiaoNhanGetByCT(int idChungTu)
        {
            return GetObjectCommand<ChungTuGiaoNhanInfor>(Declare.StoreProcedureNamespace.spChungTuGiaoNhanGetByCT, idChungTu);
        }

        public List<ChungTuBanHangInfor> GetAllChungTuByIdGiaoNhan(int idGiaoNhan)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuGiaoNhanGetAllChungTu, idGiaoNhan);
        }

        public ChungTuBanHangInfor GetDonHangGiaoNhanBySoPCGN(string soPCGN)
        {
            return GetObjectCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuGiaoNhanGetDonHangByPCGN, soPCGN);
        }

        public void DeleteAllChungTuGiaoNhan(int idGiaoNhan)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuGiaoNhanDeleteAll, idGiaoNhan);
        }

        public void DeleteChungTuGiaoNhanByCT(int idChungTu)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuGiaoNhanDeleteByCT, idChungTu);
        }

        public int InsertChungTuGiaoNhan(ChungTuGiaoNhanInfor chungTuGiaoNhan)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuGiaoNhanInsert, chungTuGiaoNhan.IdGiaoNhan,
                           chungTuGiaoNhan.SoPhieuPhanCong, chungTuGiaoNhan.NgayPhanCong, chungTuGiaoNhan.ThoiGianGiaoTu,
                           chungTuGiaoNhan.ThoiGianGiaoDen, chungTuGiaoNhan.NgayHoanThanh, chungTuGiaoNhan.NgayXacNhan,
                           chungTuGiaoNhan.TinhTrang, chungTuGiaoNhan.GhiChu, chungTuGiaoNhan.ListIdChungTu,
                           chungTuGiaoNhan.Draft, chungTuGiaoNhan.NguoiTao);
            return Common.IntValue(Parameters["p_IdGiaoNhan"].Value);
        }

        public void UpdateChungTuGiaoNhan(ChungTuGiaoNhanInfor chungTuGiaoNhan)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuGiaoNhanUpdate, chungTuGiaoNhan.IdGiaoNhan,
                           chungTuGiaoNhan.SoPhieuPhanCong, chungTuGiaoNhan.NgayPhanCong, chungTuGiaoNhan.ThoiGianGiaoTu,
                           chungTuGiaoNhan.ThoiGianGiaoDen, chungTuGiaoNhan.NgayHoanThanh, chungTuGiaoNhan.NgayXacNhan,
                           chungTuGiaoNhan.TinhTrang, chungTuGiaoNhan.GhiChu, chungTuGiaoNhan.ListIdChungTu,
                           chungTuGiaoNhan.Draft, chungTuGiaoNhan.NguoiSua);
        }

        public void XacNhanTThaiGNhanCTuGoc(int idPhieuGN, string listIdChungTu, string nguoisua, string maysua)
        {
            //update trang thai giao nhan
            string sql =
                String.Format(
                    "update tbl_ChungTu set nguoisua = '{0}', tenmaysua = '{1}', thoigiansua=sysdate, idphieugiaonhan = {2}, NgayGiaoXongHang = (select ngayhoanthanh from tbl_ChungTu_GiaoNhan where idgiaonhan={2}) where idchungtu in ({3}) and loaichungtu in (8,9,10,35,36)",
                    nguoisua, maysua, idPhieuGN, listIdChungTu);

            SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(), CommandType.Text, sql);

            //update trang thai chungtu goc
            sql =
                String.Format(
                    "update tbl_ChungTu set nguoisua = '{0}', tenmaysua = '{1}', thoigiansua=sysdate, trangthai = {2}, DAPHANDON = {3} where idchungtu in ({4}) and loaichungtu in (8,9,10,35,36) and trangthai < {5}",
                    nguoisua, maysua, (int)OrderStatus.XAC_NHAN_DON_HANG_GIAO_NHAN, (int)TrangThaiPhanDonGiaoNhan.XAC_NHAN_PHAN_DON, listIdChungTu, (int)OrderStatus.XAC_NHAN_DON_HANG_GIAO_NHAN);

            SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(), CommandType.Text, sql);
        }
        public void XacNhanTThaiPhanDonGNhan(int idPhieuGN, int trangThai, string listIdChungTu, string nguoisua, string maysua)
        {
            int idGiaoNhan = idPhieuGN;
            if (trangThai == (int)TrangThaiPhanDonGiaoNhan.CHUA_PHAN_DON || trangThai == (int)TrangThaiPhanDonGiaoNhan.TU_CHOI_PHAN_DON)
                idGiaoNhan = 0;
            //update trang thai phan don chungtu goc
            string sql =
                String.Format(
                    "update tbl_ChungTu set nguoisua = '{0}', tenmaysua = '{1}', thoigiansua=sysdate, DAPHANDON = {2}, idphieugiaonhan = {3}  where idchungtu in ({4}) and loaichungtu in (8,9,10,35,36)",
                    nguoisua, maysua, trangThai, idGiaoNhan, listIdChungTu);

            SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(), CommandType.Text, sql);
        }
        public void TangSoLanInGiaoNhan(int idGiaoNhan)
        {
            //update trang thai phan don chungtu goc
            string sql =
                String.Format(
                    "update tbl_ChungTu_GiaoNhan set SOLANIN = nvl(SOLANIN,0) + 1 where idgiaonhan = {0}", idGiaoNhan);

            SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(), CommandType.Text, sql);
        }
        #endregion

        #region chungtu giao nhan chitiet
        public List<ChungTuGiaoNhanChiTietInfor> GetListChungTuGNhanChiTietGetById(int idGiaoNhan)
        {
            return GetListCommand<ChungTuGiaoNhanChiTietInfor>(Declare.StoreProcedureNamespace.spChungTuGiaoNhanChiTietGetById, idGiaoNhan);
        }
        public List<ChungTuGiaoNhanChiTietInfor> GetListChungTuGNhanChiTietGetByCT(int idChungTu)
        {
            return GetListCommand<ChungTuGiaoNhanChiTietInfor>(Declare.StoreProcedureNamespace.spChungTuGiaoNhanChiTietGetByCT, idChungTu);
        }
        public List<DMNhanVienInfo> GetListNhanVienByGiaoNhan(int idChungTu)
        {
            return GetListCommand<DMNhanVienInfo>(Declare.StoreProcedureNamespace.spChungTuGiaoNhanGetListNhanVien, idChungTu);
        }
        public List<DMDoiTuongInfo> GetListDoiTacByGiaoNhan(int idChungTu)
        {
            return GetListCommand<DMDoiTuongInfo>(Declare.StoreProcedureNamespace.spChungTuGiaoNhanGetListDoiTac, idChungTu);
        }
        public void InsertChungTuGiaoNhanChiTiet(ChungTuGiaoNhanChiTietInfor gnct)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuGiaoNhanChiTietInsert, gnct.IdGiaoNhan,
                            gnct.IdNhanVien, gnct.IdNhanVien2, gnct.IdNhanVien3, gnct.MaVungMien, gnct.MaPhuongTien, gnct.LoaiCongViec, gnct.BienSoXe, 
                            gnct.GhiChu, gnct.IdQuanHuyen, gnct.IdDoiTac, gnct.NhanVienDoiTac, gnct.IdLaiXe,
                            gnct.DonGiaVanChuyen, gnct.DonGiaLapDat, gnct.PhuCapVuotTroi);
        }
        public void DeleteChungTuGiaoNhanChiTiet(int idGiaoNhan)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuGiaoNhanChiTietDelete, idGiaoNhan);
        }
        public void UpdateTinhTrangGiaoNhan(ChungTuGiaoNhanInfor gn)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuGiaoNhanUpdateTTGN, gn.IdGiaoNhan, gn.NgayHoanThanh, gn.TinhTrang, gn.GhiChu);
            if (gn.TinhTrang > 1)//dã giao xong, hoặc hủy, hoặc trả lại
            {
                //string sql =
                //    String.Format(
                //        "update tbl_ChungTu set NgayGiaoXongHang = (select ngayhoanthanh from tbl_ChungTu_GiaoNhan where idgiaonhan={0}) where idchungtu in ({1}) and loaichungtu in (8,9,10,35,36)",
                //        gn.IdGiaoNhan, gn.ListIdChungTu);

                //SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(), CommandType.Text, sql);                

                ExecuteCommand(
                    @"update tbl_ChungTu 
                        set NgayGiaoXongHang = (select ngayhoanthanh from tbl_ChungTu_GiaoNhan 
                            where idgiaonhan=:idGiaoNhan) 
                        where instr(:listIdChungTu, ',' || idchungtu || ',') > 0 
                            and loaichungtu in (8,9,10,35,36)",
                    gn.IdGiaoNhan, String.Format(",{0},", gn.ListIdChungTu));
            }
        }
        #endregion
    }
}
