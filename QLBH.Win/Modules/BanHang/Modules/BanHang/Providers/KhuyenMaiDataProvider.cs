using System;
using System.Collections;
using System.Collections.Generic;
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

    public class KhuyenMaiDataProvider : BusinessProviderBase
    {

        private static KhuyenMaiDataProvider instance;
        public static KhuyenMaiDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new KhuyenMaiDataProvider();
                return instance;
            }
        }

        #region bang gia dieu kien mua load
        public List<BangGiaADDKMuaInfor> GetAllBangGiaADDKMuaInfors(int idChinhSach)
        {
            return Origin(KhuyenMaiDAO.Instance.GetAllBangGiaADDKMuaInfors(idChinhSach));
        }
        public List<BangGiaADDKMuaInfor> GetBangGiaADDKMuaInforsById(int idDKMua)
        {
            return Origin(KhuyenMaiDAO.Instance.GetBangGiaADDKMuaInforsById(idDKMua));
        }
        public List<BangGiaADKhuyenMaiInfor> GetAllBangGiaKhuyenMaiInfors(int idDKMua)
        {
            return Origin(KhuyenMaiDAO.Instance.GetAllBangGiaKhuyenMaiInfors(idDKMua));
        }
        public List<BangGiaADKhuyenMaiInfor> GetAllBangGiaKhuyenMaiADInfors(int idDKMua)
        {
            return Origin(KhuyenMaiDAO.Instance.GetAllBangGiaKhuyenMaiADInfors(idDKMua));
        }
        public List<BangGiaADKhuyenMaiChiTietInfor> GetAllKhuyenMaiChiTietInfors(int idKhuyenMai)
        {
            return Origin(KhuyenMaiDAO.Instance.GetAllKhuyenMaiChiTietInfors(idKhuyenMai));
        }
        //dung de view chinh sach gia, khuyen mai
        public List<BangGiaADKhuyenMaiChiTietInfor> GetAllKhuyenMaiChiTietADInfors1(int idKhuyenMai, int idKho)
        {
            return Origin(KhuyenMaiDAO.Instance.GetAllKhuyenMaiChiTietADInfors(idKhuyenMai, idKho));
        }
        //dung khi ban hang thi load km
        public List<BangGiaADKhuyenMaiChiTietInfor> GetAllKhuyenMaiWebCTietInfors(int idKhuyenMai)
        {
            return Origin(KhuyenMaiDAO.Instance.GetAllKhuyenMaiWebCTietInfors(idKhuyenMai));
        }

        public List<BangGiaADKhuyenMaiChiTietInfor> GetAllKhuyenMaiChiTietADInfors(int idKhuyenMai, int idKho, double giaBan)
        {
            return Origin(KhuyenMaiDAO.Instance.GetAllKhuyenMaiChiTietADInfors(idKhuyenMai, idKho, giaBan));
        }

        public List<BangGiaADKhuyenMaiChiTietInfor> GetAllKhuyenMaiChiTietADTTInfors(int idKhuyenMai, int idKho, double giaBan)
        {
            return Origin(KhuyenMaiDAO.Instance.GetAllKhuyenMaiChiTietADTTInfors(idKhuyenMai, idKho, giaBan));
        }
        public List<BangGiaHangKhuyenMaiInfor> GetHangKhuyenMaiInfors(int idDKMua)
        {
            return KhuyenMaiDAO.Instance.GetHangKhuyenMaiInfors(idDKMua);
        }
        public List<BangGiaHangKhuyenMaiChiTietInfor> GetHangKhuyenMaiChiTietInfors(int idKhuyenMai, int idKho)
        {
            return KhuyenMaiDAO.Instance.GetHangKhuyenMaiChiTietInfors(idKhuyenMai, idKho);
        }
        public List<BangGiaADSPKemInfor> GetAllSanPhamKemInfors(int idDKMua)
        {
            return KhuyenMaiDAO.Instance.GetAllSanPhamKemInfors(idDKMua);
        }
        public List<BangGiaADSPKemInfor> GetAllSanPhamKemADInfors(int idDKMua, int idKho)
        {
            return KhuyenMaiDAO.Instance.GetAllSanPhamKemADInfors(idDKMua, idKho);
        }
        public List<BangGiaADSPDaMuaInfor> GetAllSanPhamDaMuaInfors(int idDKMua)
        {
            return KhuyenMaiDAO.Instance.GetAllSanPhamDaMuaInfors(idDKMua);
        }
        public List<BangGiaADSPNoADInfor> GetAllSanPhamNoADInfors(int idDKMua, int isApDung)
        {
            return KhuyenMaiDAO.Instance.GetAllSanPhamNoADInfors(idDKMua, isApDung);
        }
        #endregion

        #region bang gia dieu kien mua update
        public void UpdateBangGiaADDKMua(BangGiaADDKMuaInfor bgDKMua)
        {
            KhuyenMaiDAO.Instance.UpdateBangGiaADDKMua(bgDKMua);
        }
        public int InsertBangGiaADDKMua(BangGiaADDKMuaInfor bgDKMua)
        {
            return KhuyenMaiDAO.Instance.InsertBangGiaADDKMua(bgDKMua);
        }
        public void DeleteBangGiaADDKMua(BangGiaADDKMuaInfor bgDKMua)
        {
            KhuyenMaiDAO.Instance.DeleteBangGiaADDKMua(bgDKMua);
        }
        #endregion

        #region bang gia khuyen mai update
        public bool ExistKhuyenMai(string soKhuyenMai, int idKhuyenMai)
        {
            bool rs = false;
            if (KhuyenMaiDAO.Instance.ExistKhuyenMai(soKhuyenMai, idKhuyenMai).Count > 0)
                rs = true;
            return rs;
        }

        public void UpdateBGKhuyenMai(BangGiaADKhuyenMaiInfor bgkm)
        {
            KhuyenMaiDAO.Instance.UpdateBGKhuyenMai(bgkm);
        }
        public int InsertBGKhuyenMai(BangGiaADKhuyenMaiInfor bgkm)
        {
            return KhuyenMaiDAO.Instance.InsertBGKhuyenMai(bgkm);
        }
        public void DeleteBGKhuyenMai(BangGiaADKhuyenMaiInfor bgkm)
        {
            KhuyenMaiDAO.Instance.DeleteBGKhuyenMai(bgkm);
        }
        public void DeleteBGKhuyenMaiByDKMua(int idDKMua)
        {
            KhuyenMaiDAO.Instance.DeleteBGKhuyenMaiByDKMua(idDKMua);
        }
        public void DeleteBGKhuyenMaiByChinhSach(int idChinhSach)
        {
            KhuyenMaiDAO.Instance.DeleteBGKhuyenMaiByChinhSach(idChinhSach);
        }
        #endregion

        #region bang gia khuyen mai chi tiet update
        public void UpdateKhuyenMaiChiTiet(BangGiaADKhuyenMaiChiTietInfor kmct)
        {
            KhuyenMaiDAO.Instance.UpdateKhuyenMaiChiTiet(kmct);
        }
        public int InsertKhuyenMaiChiTiet(BangGiaADKhuyenMaiChiTietInfor kmct)
        {
            return KhuyenMaiDAO.Instance.InsertKhuyenMaiChiTiet(kmct);
        }
        #endregion

        #region bang gia chinh sach san pham kem update
        public void InsertBGiaADSanPhamKem(BangGiaADSPKemInfor spk)
        {
            KhuyenMaiDAO.Instance.InsertBGiaADSanPhamKem(spk);
        }
        public void DeleteBGiaChiTietSanPhamKem(int idDKMua)
        {
            KhuyenMaiDAO.Instance.DeleteBGiaChiTietSanPhamKem(idDKMua);
        }
        #endregion

        #region bang gia chinh sach san pham da mua update
        public void InsertBGiaADSanPhamDaMua(BangGiaADSPDaMuaInfor spdm)
        {
            KhuyenMaiDAO.Instance.InsertBGiaADSanPhamDaMua(spdm);
        }
        public void DeleteBGiaChiTietSanPhamDaMua(int idDKMua)
        {
            KhuyenMaiDAO.Instance.DeleteBGiaChiTietSanPhamDaMua(idDKMua);
        }
        #endregion

        #region bang gia chinh sach san pham khong ap dung update
        public void InsertBGiaADSanPhamNoAD(BangGiaADSPNoADInfor noad, int isApDung)
        {
            KhuyenMaiDAO.Instance.InsertBGiaADSanPhamNoAD(noad, isApDung);
        }
        public void DeleteBGiaChiTietSanPhamNoAD(int idDKMua)
        {
            KhuyenMaiDAO.Instance.DeleteBGiaChiTietSanPhamNoAD(idDKMua);
        }
        #endregion
    }
}
