using System;
using System.Collections;
using System.Collections.Generic;
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

    public class SuDungHoaDonDataProvider
    {
        private static SuDungHoaDonDataProvider instance;
        public static SuDungHoaDonDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new SuDungHoaDonDataProvider();
                return instance;
            }
        }

        public List<SuDungHoaDonInfor> LoadSuDungHoaDonByUser(int idNhanVien)
        {
            return SuDungHoaDonDAO.Instance.LoadSuDungHoaDonByUser(idNhanVien);
        }
        public List<SuDungHoaDonInfor> SearchSuDungHoaDonByUser(int idNhanVien, string kyHieu, int soserie, int chuaSuDung)
        {
            return SuDungHoaDonDAO.Instance.SearchSuDungHoaDonByUser(idNhanVien, kyHieu, soserie, chuaSuDung);
        }
        public List<SuDungHoaDonInfor> SearchSuDungHoaDon(int idTrungTam, int idNhanVien, string kyHieu, int soHoaDon)
        {
            return SuDungHoaDonDAO.Instance.SearchSuDungHoaDon(idTrungTam, idNhanVien, kyHieu, soHoaDon);
        }
        public List<SuDungHoaDonInfor> LoadSuDungHoaDonByKyHieu(int idNhanVien, string kyHieu)
        {
            return SuDungHoaDonDAO.Instance.LoadSuDungHoaDonByKyHieu(idNhanVien, kyHieu);
        }
        public List<SuDungHoaDonInfor> LoadSuDungHoaDonEmpty(int idNhanVien)
        {
            return SuDungHoaDonDAO.Instance.LoadSuDungHoaDonEmpty(idNhanVien);
        }
        public bool IsUsedByUser(int idNhanVien, string kyHieu, int soBatDau, int soKetThuc)
        {
            return SuDungHoaDonDAO.Instance.IsUsedByUser(idNhanVien, kyHieu, soBatDau, soKetThuc);
        }
        public bool IsUsedByQuyen(int idQuyen, string kyHieu, int soBatDau, int soKetThuc)
        {
            return SuDungHoaDonDAO.Instance.IsUsedByQuyen(idQuyen, kyHieu, soBatDau, soKetThuc);
        }
        public int Insert(SuDungHoaDonInfor hoaDon)
        {
            return SuDungHoaDonDAO.Instance.Insert(hoaDon);
        }
        public void Update(SuDungHoaDonInfor hoaDon)
        {
            SuDungHoaDonDAO.Instance.Update(hoaDon);
        }

        public bool IsInUsed(SuDungHoaDonInfor hoaDon)
        {
            List<SuDungHoaDonInfor> li = SuDungHoaDonDAO.Instance.LoadHoaDonDangSuDung(hoaDon.KyHieu, hoaDon.SoBatDau, hoaDon.SoKetThuc);
            if (li.Count > 0)
                return true;
            else
                return false;
        }

        public bool IsInUsed(int quyen, int sohientai)
        {
            return SuDungHoaDonDAO.Instance.IsInUsed(quyen, sohientai);
        }

        public void Delete(SuDungHoaDonInfor hoaDon)
        {
            SuDungHoaDonDAO.Instance.Delete(hoaDon);
        }
        public void DeleteByUser(int idNhanVien)
        {
            SuDungHoaDonDAO.Instance.DeleteByUser(idNhanVien);
        }

        public static bool CheckHoaDon(string soSerie, int quyen)
        {
            bool rs = false;
            try
            {
                if (soSerie.Length == Declare.DoDaiHoaDon)
                {
                    //string kytudau = soSerie.Substring(0, 3);
                    int sohientai = Common.IntValue(soSerie);
                    string sql = "select KyHieu from tbl_SuDung_HoaDon where QuyenSo=" + quyen +
                                 " and Sobatdau<=" + sohientai + " and SoKetThuc>=" + sohientai; 
                                    //+" and KyHieuDau='" + kytudau + "'";
                    if (DBTools.getValue(sql).Length > 0)
                        rs = true;
                }
            }
            catch (Exception ex) { }
            return rs;
        }

        /// <summary>
        /// Kiểm tra xem số HD có hợp lệ hay không
        /// Dựa vào quyển số, số Hóa đơn, chứng từ hiện tại
        /// </summary>
        /// <param name="quyen"></param>
        /// <param name="soHoaDon"></param>
        /// <param name="idChungTu"></param>
        /// <returns></returns>
        public static bool CheckSoHoaDon(int soHoaDon, int idChungTu, string hoaDon, string kyHieu)
        {
            List<SuDungHoaDonInfor> liHD = SuDungHoaDonDAO.Instance.LoadSuDungHoaDonBySoHD(soHoaDon, idChungTu, hoaDon, kyHieu);
            if (liHD != null && liHD.Count>0)
                return true;

            return false;
        }

        

        /// <summary>
        /// Trả về ngày dư đầu của từng kho
        /// </summary>
        /// <param name="soSerie">Số serie cập nhật</param>
        public static void UpdateNextSoHoaDon(int quyen, int soHoaDon)
        {
            SuDungHoaDonDAO.Instance.UpdateNextSoHoaDon(quyen, soHoaDon);
        }
    }
}
