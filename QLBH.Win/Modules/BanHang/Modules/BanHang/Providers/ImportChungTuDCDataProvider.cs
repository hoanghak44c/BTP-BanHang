using System;
using System.Collections;
using System.Collections.Generic;
using QLBH.Core.Business;
using QLBH.Core.Data;
using QLBH.Common;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.DAO;
using QLBH.Core.Providers;

// <Remarks>
// Tạo BangGiaDataProvider
// Người tạo: Lê Mạnh Tuấn
// Ngày tạo : 24/07/2012
// Người sửa cuối:
// </remarks>

namespace QLBanHang.Modules.BanHang.Providers
{
    public class ImportChungTuDCDataProvider : BusinessProviderBase, IBussinessKhoProvider<ImportCTuDChuyenInfor, ImportCTuDChuyenCTietInfor, ImportCTuDChuyenCTietHHoaInfor>
        , IBussinessKeToanKhoProvider<ImportCTuDChuyenInfor, ImportCTuDChuyenCTietInfor>
    {
        private static ImportChungTuDCDataProvider instance;
        public static ImportChungTuDCDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new ImportChungTuDCDataProvider();
                return instance;
            }
        }

        #region chungtu

        public ImportCTuDChuyenInfor LoadChungTuBySoChungTuGoc(string soChungTuGoc)
        {
            return ImportChungTuDCDAO.Instance.LoadChungTuBySoChungTuGoc(soChungTuGoc);
        }

        public void DeleteChungTuById(int idChungTu)
        {
            ImportChungTuDCDAO.Instance.DeleteChungTuById(idChungTu);
        }

        public void DeleteChungTuDate(DateTime tuNgay, DateTime denNgay)
        {
            ImportChungTuDCDAO.Instance.DeleteChungTuDate(tuNgay, denNgay);
        }

        public void DeleteChungTu(int idChungTu)
        {
            ImportChungTuDCDAO.Instance.DeleteChungTu(idChungTu);
        }

        public void UpdateChungTu(ImportCTuDChuyenInfor chungTu)
        {
            ImportChungTuDCDAO.Instance.UpdateChungTu(chungTu);
        }

        public int InsertChungTu(ImportCTuDChuyenInfor chungTu)
        {
            return ImportChungTuDCDAO.Instance.InsertChungTu(chungTu);
        }
        #endregion

        #region chungtu chitiet
        public List<ImportCTuDChuyenCTietInfor> GetListChiTietChungTuBySoChungTuGoc(string soChungTuGoc)
        {
            return ImportChungTuDCDAO.Instance.GetListChiTietChungTuBySoChungTuGoc(soChungTuGoc);
        }

        public List<ImportCTuDChuyenCTietInfor> GetListChiTietChungTuByIdChungTu(int idChungTu)
        {
            return Origin(ImportChungTuDCDAO.Instance.GetListChiTietChungTuByIdChungTu(idChungTu));
        }

        public int InsertChiTietChungTu(ImportCTuDChuyenCTietInfor chiTietChungTu)
        {
            return ImportChungTuDCDAO.Instance.InsertChiTietChungTu(chiTietChungTu);
        }

        public void DeleteChiTietChungTu(ImportCTuDChuyenCTietInfor chiTietChungTu)
        {
            ImportChungTuDCDAO.Instance.DeleteChiTietChungTu(chiTietChungTu);
        }

        public void UpdateChiTietChungTu(ImportCTuDChuyenCTietInfor chiTietChungTu)
        {
            ImportChungTuDCDAO.Instance.UpdateChiTietChungTu(chiTietChungTu);
        }
        #endregion

        #region chungtu chitiet hang hoa
        public List<ImportCTuDChuyenCTietHHoaInfor> GetListChiTietHangHoaBySoChungTuGoc(string soChungTuGoc, int idKho)
        {
            return ImportChungTuDCDAO.Instance.GetListChiTietHangHoaBySoChungTuGoc(soChungTuGoc, idKho);
        }

        public List<ImportCTuDChuyenCTietHHoaInfor> GetListChiTietHangHoaByIdChungTu(int idChungTu)
        {
            return Origin(ImportChungTuDCDAO.Instance.GetListChiTietHangHoaByIdChungTu(idChungTu));
        }

        public void DeleteChiTietHangHoa(ImportCTuDChuyenCTietHHoaInfor chiTietHangHoaInfo)
        {
            ImportChungTuDCDAO.Instance.DeleteChiTietHangHoa(chiTietHangHoaInfo);
        }

        public void InsertChiTietHangHoa(ImportCTuDChuyenCTietHHoaInfor chiTietHangHoaInfo)
        {
            ImportChungTuDCDAO.Instance.InsertChiTietHangHoa(chiTietHangHoaInfo);
        }

        public void UpdateChiTietHangHoa(ImportCTuDChuyenCTietHHoaInfor chiTietHangHoaInfo)
        {
            ImportChungTuDCDAO.Instance.UpdateChiTietHangHoa(chiTietHangHoaInfo);
        }
        #endregion
    }
}
