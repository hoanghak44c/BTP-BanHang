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
    public class ImportChungTuDataProvider : BusinessProviderBase, IBussinessKhoProvider<ChungTuBanHangInfor, ChungTuBanHangChiTietInfor, ChungTuBanHangChiTietHangHoaInfor>
        , IBussinessKeToanKhoProvider<ChungTuBanHangInfor, ChungTuBanHangChiTietInfor>
    {
        private static ImportChungTuDataProvider instance;
        public static ImportChungTuDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new ImportChungTuDataProvider();
                return instance;
            }
        }

        #region chungtu

        public ChungTuBanHangInfor LoadChungTuBySoChungTuGoc(string soChungTuGoc)
        {
            return ImportChungTuDAO.Instance.LoadChungTuBySoChungTuGoc(soChungTuGoc);
        }
        public ChungTuBanHangInfor LoadChungTuBanBySoChungTuGoc(string soChungTuGoc)
        {
            return ImportChungTuDAO.Instance.LoadChungTuBanBySoChungTuGoc(soChungTuGoc);
        }

        public void DeleteChungTuById(int idChungTu)
        {
            ImportChungTuDAO.Instance.DeleteChungTuById(idChungTu);
        }

        public void DeleteChungTuDate(DateTime tuNgay, DateTime denNgay)
        {
            ImportChungTuDAO.Instance.DeleteChungTuDate(tuNgay, denNgay);
        }

        public void DeleteChungTu(int idChungTu)
        {
            ImportChungTuDAO.Instance.DeleteChungTu(idChungTu);
        }

        public void UpdateChungTu(ChungTuBanHangInfor chungTu)
        {
            ImportChungTuDAO.Instance.UpdateChungTu(chungTu);
        }

        public int InsertChungTu(ChungTuBanHangInfor chungTu)
        {
            return ImportChungTuDAO.Instance.InsertChungTu(chungTu);
        }
        #endregion

        #region chungtu chitiet
        public List<ChungTuBanHangChiTietInfor> GetListChiTietChungTuBySoChungTuGoc(string soChungTuGoc)
        {
            return ImportChungTuDAO.Instance.GetListChiTietChungTuBySoChungTuGoc(soChungTuGoc);
        }

        public List<ChungTuBanHangChiTietInfor> GetListChiTietChungTuByIdChungTu(int idChungTu)
        {
            return Origin(ImportChungTuDAO.Instance.GetListChiTietChungTuByIdChungTu(idChungTu));
        }

        public int InsertChiTietChungTu(ChungTuBanHangChiTietInfor chiTietChungTu)
        {
            return ImportChungTuDAO.Instance.InsertChiTietChungTu(chiTietChungTu);
        }

        public void DeleteChiTietChungTu(ChungTuBanHangChiTietInfor chiTietChungTu)
        {
            ImportChungTuDAO.Instance.DeleteChiTietChungTu(chiTietChungTu);
        }

        public void UpdateChiTietChungTu(ChungTuBanHangChiTietInfor chiTietChungTu)
        {
            ImportChungTuDAO.Instance.UpdateChiTietChungTu(chiTietChungTu);
        }
        #endregion

        #region chungtu chitiet hang hoa
        public List<ChungTuBanHangChiTietHangHoaInfor> GetListChiTietHangHoaBySoChungTuGoc(string soChungTuGoc, int idKho)
        {
            return ImportChungTuDAO.Instance.GetListChiTietHangHoaBySoChungTuGoc(soChungTuGoc, idKho);
        }

        public List<ChungTuBanHangChiTietHangHoaInfor> GetListChiTietHangHoaByIdChungTu(int idChungTu)
        {
            return Origin(ImportChungTuDAO.Instance.GetListChiTietHangHoaByIdChungTu(idChungTu));
        }

        public void DeleteChiTietHangHoa(ChungTuBanHangChiTietHangHoaInfor chiTietHangHoaInfo)
        {
            ImportChungTuDAO.Instance.DeleteChiTietHangHoa(chiTietHangHoaInfo);
        }

        public void InsertChiTietHangHoa(ChungTuBanHangChiTietHangHoaInfor chiTietHangHoaInfo)
        {
            ImportChungTuDAO.Instance.InsertChiTietHangHoa(chiTietHangHoaInfo);
        }

        public void UpdateChiTietHangHoa(ChungTuBanHangChiTietHangHoaInfor chiTietHangHoaInfo)
        {
            ImportChungTuDAO.Instance.UpdateChiTietHangHoa(chiTietHangHoaInfo);
        }
        #endregion

        #region chungtu thanh toan
        public List<ChungTuThanhToanInfor> GetListChungTuThanhToanBySoChungTuGoc(string soChungTuGoc)
        {
            return ImportChungTuDAO.Instance.GetListChungTuThanhToanBySoChungTuGoc(soChungTuGoc);
        }
        public List<ChungTuThanhToanInfor> GetListChungTuThanhToanThemBySoChungTuGoc(string soChungTuGoc, int idChungTu)
        {
            return ImportChungTuDAO.Instance.GetListChungTuThanhToanThemBySoChungTuGoc(soChungTuGoc, idChungTu);
        }
        public ChungTuThanhToanInfor GetChungTuThanhToanThemBySoChungTuGoc(string soChungTuGoc, int idChungTu, string soPhieuThu)
        {
            return ImportChungTuDAO.Instance.GetChungTuThanhToanThemBySoChungTuGoc(soChungTuGoc, idChungTu, soPhieuThu);
        }
        public void DeleteChungTuThanhToanByIdChungTu(int idChungTu)
        {
            ImportChungTuDAO.Instance.DeleteChungTuThanhToanByIdChungTu(idChungTu);
        }

        public void InsertChungTuThanhToan(ChungTuThanhToanInfor chungTuThanhToan)
        {
            ImportChungTuDAO.Instance.InsertChungTuThanhToan(chungTuThanhToan);
        }
        #endregion

        #region bang gia
        public void ImportBangGiaChiTiet(int idTrungTam, string maSanPham)
        {
            ImportChungTuDAO.Instance.ImportBangGiaChiTiet(idTrungTam, maSanPham);
        }
        #endregion
    }
}
