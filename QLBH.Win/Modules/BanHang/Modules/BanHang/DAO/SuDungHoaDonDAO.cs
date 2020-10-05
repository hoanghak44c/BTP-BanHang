using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.BanHang.Infors;

namespace QLBanHang.Modules.BanHang.DAO
{
    public class SuDungHoaDonDAO :BaseDAO
    {
        private static SuDungHoaDonDAO instance;
        private SuDungHoaDonDAO()
        {
            CRUDTableName = Declare.TableNamespace.SuDungHoaDon;
            UseCaching = false;
        }
        public static SuDungHoaDonDAO Instance
        {
            get
            {
                if (instance == null) instance = new SuDungHoaDonDAO();
                return instance;
            }
        }

        public List<SuDungHoaDonInfor> LoadSuDungHoaDonByUser(int idNhanVien)
        {
            return GetListCommand<SuDungHoaDonInfor>(Declare.StoreProcedureNamespace.spSuDungHoaDonGetByUser, idNhanVien);
        }

        public List<SuDungHoaDonInfor> SearchSuDungHoaDonByUser(int idNhanVien, string kyHieu, int soserie, int chuaSuDung)
        {
            return GetListCommand<SuDungHoaDonInfor>(Declare.StoreProcedureNamespace.spSuDungHoaDonSrcByUser, idNhanVien, kyHieu, soserie, chuaSuDung);
        }

        public List<SuDungHoaDonInfor> SearchSuDungHoaDon(int idTrungTam, int idNhanVien, string kyHieu, int soHoaDon)
        {
            return GetListCommand<SuDungHoaDonInfor>(Declare.StoreProcedureNamespace.spSuDungHoaDonSearchHD, idTrungTam, idNhanVien, kyHieu, soHoaDon);
        }

        public List<SuDungHoaDonInfor> LoadHoaDonDangSuDung(string kyHieu, int soBatDau, int soKeThuc)
        {
            return GetListCommand<SuDungHoaDonInfor>(Declare.StoreProcedureNamespace.spSuDungHoaDonLoadInUsed, kyHieu, soBatDau, soKeThuc);
        }

        public List<SuDungHoaDonInfor> LoadSuDungHoaDonByKyHieu(int idNhanVien, string kyHieu)
        {
            return GetListCommand<SuDungHoaDonInfor>(Declare.StoreProcedureNamespace.spSuDungHoaDonGetByKyHieu, idNhanVien, kyHieu);
        }
        public List<SuDungHoaDonInfor> LoadSuDungHoaDonEmpty(int idNhanVien)
        {
            return GetListCommand<SuDungHoaDonInfor>(Declare.StoreProcedureNamespace.spSuDungHoaDonGetEmpty, idNhanVien);
        }
        public List<SuDungHoaDonInfor> LoadSuDungHoaDonBySoHD(int soHoaDon, int idChungTu, string hoaDon, string kyHieu)
        {
            return GetListCommand<SuDungHoaDonInfor>(Declare.StoreProcedureNamespace.spSuDungHoaDonGetBySDHoaDon, soHoaDon, idChungTu, hoaDon, kyHieu);
        }

        public bool IsUsedByUser(int idNhanVien, string kyHieu, int soBatDau, int soKetThuc)
        {
            return GetObjectCommand<int>(
                @"Select count(*)
			From tbl_SuDung_HoaDon hd
		 Where hd.IdNhanVien != :idNhanVien
			 and hd.kyhieu = :kyHieu
			 and (hd.sobatdau <= :SoBatDau and :SoBatDau <= hd.soketthuc or
					 hd.sobatdau <= :SoKetThuc and :SoKetThuc <= hd.soketthuc or
					 :SoBatDau <= hd.sobatdau and hd.sobatdau <= :SoKetThuc or
					 :SoBatDau <= hd.soketthuc and hd.soketthuc <= :SoKetThuc)",
                idNhanVien, kyHieu, soBatDau, soKetThuc) > 0;
        }

        public bool IsUsedByQuyen(int idQuyen, string kyHieu, int soBatDau, int soKetThuc)
        {
            return GetObjectCommand<int>(
                @"Select count(*)
			From tbl_SuDung_HoaDon hd
		 Where hd.idquyen != :idQuyen
			 and hd.kyhieu = :kyHieu
			 and (hd.sobatdau <= :SoBatDau and :SoBatDau <= hd.soketthuc or
					 hd.sobatdau <= :SoKetThuc and :SoKetThuc <= hd.soketthuc or
					 :SoBatDau <= hd.sobatdau and hd.sobatdau <= :SoKetThuc or
					 :SoBatDau <= hd.soketthuc and hd.soketthuc <= :SoKetThuc)",
                idQuyen, kyHieu, soBatDau, soKetThuc) > 0;
        }

        public int Insert(SuDungHoaDonInfor hoaDon)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spSuDungHoaDonInSert, hoaDon.IdQuyen, hoaDon.IdNhanVien,
                            hoaDon.KyHieu, hoaDon.SoBatDau, hoaDon.SoKetThuc, hoaDon.SoHienTai, hoaDon.SoConLai);

            return Common.IntValue(Parameters["p_IdQuyen"].Value);
        }

        public void Update(SuDungHoaDonInfor hoaDon)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spSuDungHoaDonUpdate, hoaDon.IdQuyen, hoaDon.SoHienTai, hoaDon.SoKetThuc, hoaDon.SoConLai);
        }

        public void UpdateNextSoHoaDon(int idQuyen, int soHoaDon)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spSuDungHoaDonUpdNextSHD, idQuyen, soHoaDon);
        }

        public void Delete(SuDungHoaDonInfor hoaDon)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spSuDungHoaDonDelte, hoaDon.IdQuyen);
        }

        public void DeleteByUser(int idNhanVien)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spSuDungHoaDonDelByUser, idNhanVien);
        }

        public bool IsInUsed(int quyen, int sohientai)
        {
            return GetObjectCommand<int>(
                "select count(*) from tbl_chungtu where quyenso = :quyen and cast(soseri as number) = :sohientai",
                quyen, sohientai) > 0;
        }
    }
}
