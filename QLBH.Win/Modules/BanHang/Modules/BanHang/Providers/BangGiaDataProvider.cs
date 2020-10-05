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

    public class BangGiaDataProvider : BusinessProviderBase
    {

        private static BangGiaDataProvider instance;
        public static BangGiaDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new BangGiaDataProvider();
                return instance;
            }
        }
        #region bang gia header load
        public List<BangGiaInfor> LoadAll()
        {
            return BangGiaDAO.Instance.LoadAll();
        }
        public List<BangGiaInfor> LoadBGiaByNSD(string nguoiDung)
        {
            return BangGiaDAO.Instance.LoadBGiaByNSD(nguoiDung);
        }
        public List<BangGiaInfor> SearchBGiaByNSD(string nguoiDung, int idTrungTam, string soBangGia, int draft, int duyet, DateTime tuNgay, DateTime denNgay)
        {
            return BangGiaDAO.Instance.SearchBGiaByNSD(nguoiDung, idTrungTam, soBangGia, draft, duyet, tuNgay, denNgay);
        }
        public List<BangGiaInfor> SearchBGiaByNSDPg(string nguoiDung, int idTrungTam, string soBangGia, int draft, int duyet, DateTime tuNgay, DateTime denNgay, int soBatDau, int soKetThuc)
        {
            return BangGiaDAO.Instance.SearchBGiaByNSDPg(nguoiDung, idTrungTam, soBangGia, draft, duyet, tuNgay, denNgay, soBatDau, soKetThuc);
        }

        public List<BangGiaInfor> LoadAllBGChuaDuyet()
        {
            return BangGiaDAO.Instance.LoadAllBGChuaDuyet();
        }
        public List<BangGiaInfor> LoadAllBGChuaDuyetByNND(int idNhomDuyet)
        {
            return BangGiaDAO.Instance.LoadAllBGChuaDuyetByNND(idNhomDuyet);
        }
        public List<BangGiaInfor> LoadAllBGChuaDuyetByNNDPg(int idNhomDuyet, int soBatDau, int soKetThuc)
        {
            return BangGiaDAO.Instance.LoadAllBGChuaDuyetByNNDPg(idNhomDuyet, soBatDau, soKetThuc);
        }

        public BangGiaInfor GetBangGiaInfor(int idBangGia)
        {
            return BangGiaDAO.Instance.GetBangGiaInfor(idBangGia);
        }
        public BangGiaInfor GetBangGiaInfor(string soBangGia)
        {
            return BangGiaDAO.Instance.GetBangGiaInfor(soBangGia);
        }
        public BangGiaInfor GetBangGiaChuaDuyetInfor(string soBangGia, int idNhomDuyet)
        {
            return BangGiaDAO.Instance.GetBangGiaChuaDuyetInfor(soBangGia, idNhomDuyet);
        }

        public BangGiaInfor LoadBangGiaBanInfor(int idTrungTam, int idLoaiDT)
        {
            return BangGiaDAO.Instance.LoadBangGiaBanInfor(idTrungTam, idLoaiDT);
        }
        #endregion

        #region bang gia detail load
        public List<BangGiaChiTietInfor> GetAllBangGiaChiTietInfors(int idBangGia)
        {
            return Origin(BangGiaDAO.Instance.GetAllBangGiaChiTietInfors(idBangGia));
        }
        public List<BangGiaBanChiTietBCInfor> GetAllBangGiaChiTietTon(int idBangGia)
        {
            return BangGiaDAO.Instance.GetAllBangGiaChiTietTon(idBangGia);
        }
        public List<BangGiaChiTietInfor> GetAllBGChiTietChuaDuyetInfors(int idBangGia, int idNhomNguoiDung)
        {
            return Origin(BangGiaDAO.Instance.GetAllBGChiTietChuaDuyetInfors(idBangGia, idNhomNguoiDung));
        }
        public List<BangGiaChiTietNoDuyetInfor> GetAllBangGiaChiTietNoDuyetInfors()
        {
            return BangGiaDAO.Instance.GetAllBangGiaChiTietNoDuyetInfors();
        }
        public BangGiaNhapChiTietInfor GetGiaNhapChiTietInfor(string maSanPham, int idTrungTam, int idNhomNguoiDung)
        {
            return BangGiaDAO.Instance.GetGiaNhapChiTietInfor(maSanPham, idTrungTam, 1, idNhomNguoiDung);//1: gia nhap, 2:gia demo
        }

        public BangGiaDungSaiMinMaxInfor GetGiaDungSaiMinMaxInfor(string maSanPham, int idNhomNguoiDung)
        {
            return BangGiaDAO.Instance.GetGiaDungSaiMinMaxInfor(maSanPham, idNhomNguoiDung);//1: gia nhap, 2:gia demo
        }
        public BangGiaNhomNguoiDuyetInfor GetNhomNguoiDuyetBangGiaInfor(string maSanPham, double donGiaChuaVAT, double giaNhapHDCuoi, double tienCKQK, double tienKM, double tyleLNBQ)
        {
            return BangGiaDAO.Instance.GetNhomNguoiDuyetBangGiaInfor(maSanPham, donGiaChuaVAT, giaNhapHDCuoi, tienCKQK, tienKM, tyleLNBQ);
        }

        public void UpdateGiaNhap2BGiaCTiet(BangGiaNhapChiTietInfor gn, ref BangGiaChiTietInfor ct)
        {
            ct.IdSanPham = gn.IdSanPham;
            ct.MaSanPham = gn.MaSanPham;
            ct.TenSanPham = gn.TenSanPham;
            ct.DonViTinh = gn.DonViTinh;
            ct.LoaiSanPham = gn.LoaiSanPham;
            ct.GiaNhapHDCuoi = gn.GiaNhapHDCuoi;
            ct.GiaTonKhoBQ = gn.GiaTonKhoBQ;
            ct.TienChietKhauQK = gn.TienChietKhauQK;
            ct.TyLeLNBQ = gn.TyLeLNBQ;
            ct.SoLuongBanBQ = gn.SoLuongBanBQ;
            ct.GiaNhapDemoCuoi = gn.GiaNhapDemoCuoi;
        }

        #endregion

        #region bang gia header search
        public List<BangGiaInfor> SearchBangGia(string thamso)
        {
            return BangGiaDAO.Instance.SearchBangGia(thamso);
        }

        public List<BangGiaSearchInfor> TimKiemBangGia(TimKiemBangGiaFilterInfor filter)
        {
            return BangGiaDAO.Instance.TimKiemBangGia(filter);
        }
        public List<BangGiaSearchInfor> TimKiemBangGiaPg(TimKiemBangGiaFilterInfor filter)
        {
            return BangGiaDAO.Instance.TimKiemBangGiaPg(filter);
        }

        public List<BangGiaSearchInfor> TimKiemBangGiaChuaDuyet(TimKiemBangGiaFilterInfor filter)
        {
            return BangGiaDAO.Instance.TimKiemBangGiaChuaDuyet(filter);
        }
        public List<BangGiaSearchInfor> TimKiemBangGiaChuaDuyetPg(TimKiemBangGiaFilterInfor filter)
        {
            return BangGiaDAO.Instance.TimKiemBangGiaChuaDuyetPg(filter);
        }
        public bool ExistBangGia(string soBangGia, int idBangGia)
        {
            bool rs = false;
            if (BangGiaDAO.Instance.ExistBangGia(soBangGia, idBangGia).Count > 0)
                rs = true;
            return rs;
        }

        #endregion

        #region bang gia header update
        public void UpdateBangGia(BangGiaInfor bangGia)
        {
            BangGiaDAO.Instance.UpdateBangGia(bangGia);
        }
        public void UpdateBangGiaDuyet(BangGiaInfor bangGia)
        {
            BangGiaDAO.Instance.UpdateBangGiaDuyet(bangGia);
        }

        public int InsertBangGia(BangGiaInfor bangGia)
        {
            return BangGiaDAO.Instance.InsertBangGia(bangGia);
        }

        public void InsertBangGiaTrungTam(int idBangGia, int idTrungTam)
        {
            BangGiaDAO.Instance.InsertBangGiaTrungTam(idBangGia, idTrungTam);
        }

        public void DeleteBangGia(int idBangGia)
        {
            BangGiaDAO.Instance.DeleteBangGia(idBangGia);
        }

        public void DeleteBangGiaTrungTam(int idBangGia)
        {
            BangGiaDAO.Instance.DeleteBangGiaTrungTam(idBangGia);
        }

        public void DuyetBangGia(BangGiaInfor bangGia)
        {
            BangGiaDAO.Instance.DuyetBangGia(bangGia);
        }
        public void CapNhatNhomDuyetBangGia(BangGiaInfor bangGia)
        {
            BangGiaDAO.Instance.CapNhatNhomDuyetBangGia(bangGia);
        }

        #endregion

        #region bang gia chi tiet update
        public void UpdateBangGiaChiTiet(BangGiaChiTietInfor bgct)
        {
            BangGiaDAO.Instance.UpdateBangGiaChiTiet(bgct);
        }

        public int InsertBangGiaChiTiet(BangGiaChiTietInfor bgct)
        {
            return BangGiaDAO.Instance.InsertBangGiaChiTiet(bgct);
        }

        public void DeleteBangGiaChiTiet(BangGiaChiTietInfor bgct)
        {
            BangGiaDAO.Instance.DeleteBangGiaChiTiet(bgct);
        }

        public void DuyetBangGiaChiTiet(BangGiaChiTietInfor bgct)
        {
            BangGiaDAO.Instance.DuyetBangGiaChiTiet(bgct);
        }
        #endregion


        #region bang gia ban
        public BangGiaBanChiTietInfor GetGiaBanTheoThoiGian(int idTrungTam, DateTime thoiGian, string maSanPham)
        {
            return BangGiaDAO.Instance.GetGiaBanTheoThoiGian(idTrungTam, thoiGian, maSanPham);
        }
        public BangGiaBanChiTietInfor GetGiaBan(int idTrungTam, int idKho, string maSanPham)
        {
            return BangGiaDAO.Instance.GetGiaBan(idTrungTam, idKho, maSanPham);
        }
        public List<BangGiaBanChiTietBCInfor> GetBangGiaBan(int idTrungTam)
        {
            return BangGiaDAO.Instance.GetBangGiaBan(idTrungTam);
        }
        public List<BangGiaBanChiTietBCInfor> GetBangGiaBan(int idTrungTam, int coTon)
        {
            return BangGiaDAO.Instance.GetBangGiaBan(idTrungTam, coTon);
        }
        public List<BangGiaBanChiTietBCInfor> GetBangGiaBanPg(int idTrungTam, int coTon, int soBatDau, int soKetThuc, string maSanPham, string nganh, int maxton, int idNhomNDung)
        {
            return BangGiaDAO.Instance.GetBangGiaBanPg(idTrungTam, coTon, soBatDau, soKetThuc, maSanPham, nganh, maxton, idNhomNDung);
        }
        
        //public List<BangGiaBanChiTietBCInfor> GetBangGiaBanOnline(int idTrungTam, int coTon, string maSanPham, string nganh, int maxton, DateTime lastSync)
        //{
        //    return BangGiaDAO.Instance.GetBangGiaBanOnline(idTrungTam, coTon, maSanPham, nganh, maxton, lastSync);
        //}

        public bool IsBangGiaBanOnlineChanged(DateTime lastSync)
        {
            return BangGiaDAO.Instance.IsBangGiaBanOnlineChanged(lastSync);
        }

        public List<SanPhamKhongCoGiaBCInfor> GetSanPhamKhongCoGia(int idTrungTam)
        {
            return BangGiaDAO.Instance.GetSanPhamKhongCoGia(idTrungTam);
        }

        public List<BangGiaBanChiTietBCInfor> GetChinhSachGiaBan(int idTrungTam, int idSanPham)
        {
            return BangGiaDAO.Instance.GetChinhSachGiaBan(idTrungTam, idSanPham);
        }
        public List<BangGiaBanChiTietBCInfor> GetChinhSachGiaBanPg(int idTrungTam, int soBatDau, int soKetThuc, string sanPham, string nganhHang, int diemThuong,int hieuLuc)
        {
            return BangGiaDAO.Instance.GetChinhSachGiaBanPg(idTrungTam, soBatDau, soKetThuc, sanPham, nganhHang, diemThuong, hieuLuc);
        }
        public List<BangGiaBanChiTietInfor> LoadGiaSanPham(int idNguoiDung, int idTrungTam, int idKho, int idLoaiDT, string maSanPham)
        {
            List<BangGiaBanChiTietInfor> liBangGiaChiTiet = BangGiaDAO.Instance.LoadGiaSanPham(idNguoiDung, idTrungTam, idKho, idLoaiDT, maSanPham);
            //if (liBangGiaChiTiet != null && liBangGiaChiTiet.Count>0)
            //{
            //    foreach (BangGiaBanChiTietInfor bgct in liBangGiaChiTiet)
            //    {
            //        bgct.BangGia = GetBangGiaInforByIdCTiet(bgct.IdChiTietBangGia);
            //        if (bgct.BangGia != null)
            //            bgct.BangGia.ChinhSach = GetBangGiaChinhSachInforByIdBG(bgct.BangGia.IdBangGia);
            //    }
            //}
            return liBangGiaChiTiet;
        }
        public List<ItemGiaBanInfor> LoadGiaSanPhamTheoTrungTam(string maSanPham)
        {
            return BangGiaDAO.Instance.LoadGiaSanPhamTheoTrungTam(maSanPham);
        }
        #endregion

        #region bang gia ban lich su
        public List<BangGiaChiTietLichSuInfor> GetAllLichSuThayDoiGiaBan(int idTrungTam, int idSanPham, DateTime tuNgay, DateTime denNgay)
        {
            return BangGiaDAO.Instance.GetAllLichSuThayDoiGiaBan(idTrungTam, idSanPham, tuNgay, denNgay);
        }
        public List<BangGiaChiTietLichSuInfor> GetAllLichSuThayDoiGiaBanPg(int idTrungTam, string nganhHang, string maSanPham, DateTime tuNgay, DateTime denNgay, int soBatDau, int soKetThuc)
        {
            return BangGiaDAO.Instance.GetAllLichSuThayDoiGiaBanPg(idTrungTam, nganhHang, maSanPham, tuNgay, denNgay, soBatDau, soKetThuc);
        }

        public void DeleteLichSuThayDoiGiaBanById(int idLichSu)
        {
            BangGiaDAO.Instance.DeleteLichSuThayDoiGiaBanById(idLichSu);
        }
        public void DeleteLichSuThayDoiGiaBanAll(int idTrungTam, int idSanPham, DateTime tuNgay, DateTime denNgay)
        {
            BangGiaDAO.Instance.DeleteLichSuThayDoiGiaBanAll(idTrungTam, idSanPham, tuNgay, denNgay);
        }
        #endregion

        #region Day khuyen mai
        public void DongBoKhuyenMai(string maSanPham, double tienKhuyenMai, int idDKMua)
        {
            BangGiaDAO.Instance.DongBoKhuyenMai(maSanPham, tienKhuyenMai, idDKMua);
        }

        public void DongBoKhuyenMai(int idTrungTam, string maSanPham,  double tienKhuyenMai, int idDKMua)
        {
            BangGiaDAO.Instance.DongBoKhuyenMai(idTrungTam, maSanPham, tienKhuyenMai, idDKMua);
        }

        /// <summary>
        /// Load danh sach cac san pham can dong bo CK sang Oracle
        /// </summary>
        /// <param name="idtrungtam"></param>
        /// <returns></returns>
        public List<BangGiaBanChiTietBCInfor> LoadSanPhamChuaDayKhuyenMaiOrc(int idtrungtam)
        {
            return BangGiaDAO.Instance.LoadSanPhamChuaDayKhuyenMaiOrc(idtrungtam);
        }

        /// <summary>
        /// Load danh sach cac san pham can dong bo CK sang Website
        /// </summary>
        /// <returns></returns>
        public List<BangGiaBanChiTietBCInfor> LoadSanPhamChuaDayKhuyenMaiWeb()
        {
            return BangGiaDAO.Instance.LoadSanPhamChuaDayKhuyenMaiWeb();
        }

        public void UpdateTrangThaiDayWeb(string maSanPham, int dongbo)
        {
            BangGiaDAO.Instance.UpdateTrangThaiDayWeb(maSanPham, dongbo);
        }
        #endregion

        public BangGiaBanChiTietBCInfor GetSanPham(string maSanPham, string maTrungTam)
        {
            return BangGiaDAO.Instance.GetSanPham(maSanPham, maTrungTam);
        }
    }

    public class BaoCaoBangGiaHienTaiDataProvider
    {
        private static BaoCaoBangGiaHienTaiDataProvider instance;

        public static BaoCaoBangGiaHienTaiDataProvider Instance
        {
            get { return instance ?? (instance = new BaoCaoBangGiaHienTaiDataProvider()); }
        }

        public List<BangGiaBanChiTietBCInfor> GetBangGiaBanPg(int idTrungTam, int coTon, int soBatDau, int soKetThuc, string maSanPham, string nganh, int maxton, int idNhomNDung)
        {
            return BaoCaoBangGiaHienTaiDao.Instance.GetBangGiaBanPg(idTrungTam, coTon, soBatDau, soKetThuc, maSanPham, nganh, maxton, idNhomNDung);
        }
    }

    public class BaoCaoBangGiaOnlineDataProvider
    {
        private static BaoCaoBangGiaOnlineDataProvider instance;

        public static BaoCaoBangGiaOnlineDataProvider Instance
        {
            get { return instance ?? (instance = new BaoCaoBangGiaOnlineDataProvider()); }
        }

        public List<BangGiaBanChiTietBCInfor> GetBangGiaBanOnline(int idTrungTam, int coTon, string maSanPham, string nganh, int maxton, DateTime lastSync)
        {
            return BaoCaoBangGiaOnlineDao.Instance.GetBangGiaBanOnline(idTrungTam, coTon, maSanPham, nganh, maxton, lastSync);
        }
    }
}
