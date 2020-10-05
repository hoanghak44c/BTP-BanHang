using System;
using System.Collections;
using System.Collections.Generic;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Data;
using QLBH.Common;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.DAO;

// <Remarks>
// Tạo BangGiaDataProvider
// Người tạo: Lê Mạnh Tuấn
// Ngày tạo : 24/07/2012
// Người sửa cuối:
// </remarks>

namespace QLBanHang.Modules.BanHang.Providers
{

    public class GiaoNhanDataProvider
    {
        private static GiaoNhanDataProvider instance;
        public static GiaoNhanDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new GiaoNhanDataProvider();
                return instance;
            }
        }

        #region chungtu giao nhan
        public ChungTuGiaoNhanInfor GetChungTuGiaoNhanGetById(int idGiaoNhan)
        {
            return GiaoNhanDAO.Instance.GetChungTuGiaoNhanGetById(idGiaoNhan);
        }

        public ChungTuGiaoNhanInfor GetChungTuGiaoNhanGetByCT(int idChungTu)
        {
            return GiaoNhanDAO.Instance.GetChungTuGiaoNhanGetByCT(idChungTu);
        }

        public List<ChungTuBanHangInfor> GetAllChungTuByIdGiaoNhan(int idGiaoNhan)
        {
            return GiaoNhanDAO.Instance.GetAllChungTuByIdGiaoNhan(idGiaoNhan);
        }

        public ChungTuBanHangInfor GetDonHangGiaoNhanBySoPCGN(string soPCGN)
        {
            return GiaoNhanDAO.Instance.GetDonHangGiaoNhanBySoPCGN(soPCGN);
        }

        public void DeleteAllChungTuGiaoNhan(int idGiaoNhan)
        {
            GiaoNhanDAO.Instance.DeleteAllChungTuGiaoNhan(idGiaoNhan);
        }

        public void DeleteChungTuGiaoNhanByCT(int idChungTu)
        {
            GiaoNhanDAO.Instance.DeleteChungTuGiaoNhanByCT(idChungTu);
        }

        public int InsertChungTuGiaoNhan(ChungTuGiaoNhanInfor chungTuGiaoNhan)
        {
            return GiaoNhanDAO.Instance.InsertChungTuGiaoNhan(chungTuGiaoNhan);
        }
        public void UpdateChungTuGiaoNhan(ChungTuGiaoNhanInfor chungTuGiaoNhan)
        {
            GiaoNhanDAO.Instance.UpdateChungTuGiaoNhan(chungTuGiaoNhan);
        }
        public void XacNhanTThaiGNhanCTuGoc(int idPhieuGN, string listIdChungTu, string nguoisua, string maysua)
        {
            GiaoNhanDAO.Instance.XacNhanTThaiGNhanCTuGoc(idPhieuGN, listIdChungTu, nguoisua, maysua);
        }
        public void XacNhanTThaiPhanDonGNhan(int idPhieuGN, int trangThai, string listIdChungTu, string nguoisua, string maysua)
        {
            GiaoNhanDAO.Instance.XacNhanTThaiPhanDonGNhan(idPhieuGN, trangThai, listIdChungTu, nguoisua, maysua);
        }
        public void TangSoLanInGiaoNhan(int idGiaoNhan)
        {
            GiaoNhanDAO.Instance.TangSoLanInGiaoNhan(idGiaoNhan);
        }
        #endregion

        #region chungtu giao nhan chitiet
        public List<ChungTuGiaoNhanChiTietInfor> GetListChungTuGNhanChiTietGetById(int idGiaoNhan)
        {
            return GiaoNhanDAO.Instance.GetListChungTuGNhanChiTietGetById(idGiaoNhan);
        }
        public List<ChungTuGiaoNhanChiTietInfor> GetListChungTuGNhanChiTietGetByCT(int idChungTu)
        {
            return GiaoNhanDAO.Instance.GetListChungTuGNhanChiTietGetByCT(idChungTu);
        }
        public List<DMNhanVienInfo> GetListNhanVienByGiaoNhan(int idChungTu)
        {
            return GiaoNhanDAO.Instance.GetListNhanVienByGiaoNhan(idChungTu);
        }
        public List<DMDoiTuongInfo> GetListDoiTacByGiaoNhan(int idChungTu)
        {
            return GiaoNhanDAO.Instance.GetListDoiTacByGiaoNhan(idChungTu);
        }
        public void InsertChungTuGiaoNhanChiTiet(ChungTuGiaoNhanChiTietInfor gnct)
        {
            GiaoNhanDAO.Instance.InsertChungTuGiaoNhanChiTiet(gnct);
        }
        public void DeleteChungTuGiaoNhanChiTiet(int idGiaoNhan)
        {
            GiaoNhanDAO.Instance.DeleteChungTuGiaoNhanChiTiet(idGiaoNhan);
        }
        public void UpdateTinhTrangGiaoNhan(ChungTuGiaoNhanInfor chungTuGiaoNhan)
        {
            GiaoNhanDAO.Instance.UpdateTinhTrangGiaoNhan(chungTuGiaoNhan);
        }

        #endregion

    }
}
