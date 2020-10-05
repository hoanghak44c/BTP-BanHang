using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.BanHang.Infors;

namespace QLBanHang.Modules.BanHang.DAO
{
    public class BangGiaDAO :BaseDAO
    {
        private static BangGiaDAO instance;
        private BangGiaDAO()
        {
            CRUDTableName = Declare.TableNamespace.BangGia;
            //UseCaching = true;
        }
        public static BangGiaDAO Instance
        {
            get
            {
                if (instance == null) instance = new BangGiaDAO();
                return instance;
            }
        }
        #region bang gia header load
        public List<BangGiaInfor> LoadAll()
        {
            return GetListCommand<BangGiaInfor>(Declare.StoreProcedureNamespace.spBangGiaSelectAll);
        }
        public List<BangGiaInfor> LoadBGiaByNSD(string nguoiDung)
        {
            return GetListCommand<BangGiaInfor>(Declare.StoreProcedureNamespace.spBangGiaSelectByNSD, nguoiDung);
        }
        public List<BangGiaInfor> SearchBGiaByNSD(string nguoiDung, int idTrungTam, string soBangGia, int draft, int duyet, DateTime tuNgay, DateTime denNgay)
        {
            return GetListCommand<BangGiaInfor>(Declare.StoreProcedureNamespace.spBangGiaSearchByNSD, nguoiDung,
                                                idTrungTam, soBangGia, draft, duyet, clsUtils.DateValue(tuNgay), clsUtils.DateValue(denNgay));
        }
        public List<BangGiaInfor> SearchBGiaByNSDPg(string nguoiDung, int idTrungTam, string soBangGia, int draft, int duyet, DateTime tuNgay, DateTime denNgay, int soBatDau, int soKetThuc)
        {
            return GetListCommand<BangGiaInfor>(Declare.StoreProcedureNamespace.spBangGiaSearchByNSDPg, nguoiDung,
                                                idTrungTam, soBangGia, draft, duyet, clsUtils.DateValue(tuNgay), clsUtils.DateValue(denNgay), soBatDau, soKetThuc);
        }

        public List<BangGiaInfor> LoadAllBGChuaDuyet()
        {
            return GetListCommand<BangGiaInfor>(Declare.StoreProcedureNamespace.spBangGiaSelectAllChuaDuyet);
        }
        public List<BangGiaInfor> LoadAllBGChuaDuyetByNND(int idNhomDuyet)
        {
            return GetListCommand<BangGiaInfor>(Declare.StoreProcedureNamespace.spBangGiaGetNoDuyetByNND, idNhomDuyet);
        }
        public List<BangGiaInfor> LoadAllBGChuaDuyetByNNDPg(int idNhomDuyet, int soBatDau, int soKetThuc)
        {
            return GetListCommand<BangGiaInfor>(Declare.StoreProcedureNamespace.spBangGiaGetNoDuyetByNNDPg, idNhomDuyet, soBatDau, soKetThuc);
        }
        //get bang gia
        public BangGiaInfor GetBangGiaInfor(int idBangGia)
        {
            return GetObjectCommand<BangGiaInfor>(Declare.StoreProcedureNamespace.spBangGiaSelectById, idBangGia);
        }
        public BangGiaInfor GetBangGiaInfor(string soBangGia)
        {
            return GetObjectCommand<BangGiaInfor>(Declare.StoreProcedureNamespace.spBangGiaGetBySoBangGia, soBangGia);
        }
        public BangGiaInfor GetBangGiaChuaDuyetInfor(string soBangGia, int idNhomDuyet)
        {
            return GetObjectCommand<BangGiaInfor>(Declare.StoreProcedureNamespace.spBangGiaGetNoDuyetBySBG, soBangGia, idNhomDuyet);
        }
        public BangGiaInfor LoadBangGiaBanInfor(int idTrungTam, int idLoaiDT)
        {
            return GetObjectCommand<BangGiaInfor>(Declare.StoreProcedureNamespace.spBangGiaLoadBangGiaBan, idTrungTam, idLoaiDT);
        }

        #endregion

        #region bang gia detail load
        public List<BangGiaChiTietInfor> GetAllBangGiaChiTietInfors(int idBangGia)
        {
            return GetListCommand<BangGiaChiTietInfor>(Declare.StoreProcedureNamespace.spBangGiaChiTietSelect, idBangGia);
        }
        public List<BangGiaBanChiTietBCInfor> GetAllBangGiaChiTietTon(int idBangGia)
        {
            return GetListCommand<BangGiaBanChiTietBCInfor>(Declare.StoreProcedureNamespace.spBangGiaChiTietGetTon, idBangGia);
        }
        public List<BangGiaChiTietInfor> GetAllBGChiTietChuaDuyetInfors(int idBangGia, int idNhomNguoiDung)
        {
            return GetListCommand<BangGiaChiTietInfor>(Declare.StoreProcedureNamespace.spBangGiaChiTietGetNoDuyet, idBangGia, idNhomNguoiDung);
        }
        public List<BangGiaChiTietNoDuyetInfor> GetAllBangGiaChiTietNoDuyetInfors()
        {
            return GetListCommand<BangGiaChiTietNoDuyetInfor>(Declare.StoreProcedureNamespace.spBangGiaChiTietGetAllNoDuyet);
        }
        public BangGiaNhapChiTietInfor GetGiaNhapChiTietInfor(string maSanPham, int idTrungTam, int type, int idNhomNguoiDung)//1: gia nhap, 2:gia demo
        {
            return GetObjectCommand<BangGiaNhapChiTietInfor>(Declare.StoreProcedureNamespace.spBangGiaGiaNhapSelect, maSanPham, idTrungTam, type, idNhomNguoiDung);
        }
        public BangGiaDungSaiMinMaxInfor GetGiaDungSaiMinMaxInfor(string maSanPham, int idNhomNguoiDung)//1: gia nhap, 2:gia demo
        {
            return GetObjectCommand<BangGiaDungSaiMinMaxInfor>(Declare.StoreProcedureNamespace.spBangGiaGiaMinMaxSelect, maSanPham, idNhomNguoiDung);
        }
        public BangGiaNhomNguoiDuyetInfor GetNhomNguoiDuyetBangGiaInfor(string maSanPham, double donGiaChuaVAT, double giaNhapHDCuoi, double tienCKQK, double tienKM, double tyleLNBQ)
        {
            return GetObjectCommand<BangGiaNhomNguoiDuyetInfor>(Declare.StoreProcedureNamespace.spBangGiaChiTietGetNhomDuyet, maSanPham, donGiaChuaVAT, giaNhapHDCuoi, tienCKQK, tienKM, tyleLNBQ);
        }

        #endregion

        #region bang gia header search
        public List<BangGiaInfor> SearchBangGia(string thamso)
        {
            return GetListCommand<BangGiaInfor>(Declare.StoreProcedureNamespace.spBangGiaSearch);
        }

        public List<BangGiaSearchInfor> TimKiemBangGia(TimKiemBangGiaFilterInfor filter)
        {
            return GetListCommand<BangGiaSearchInfor>(Declare.StoreProcedureNamespace.spBangGiaTimKiem, filter.IdTrungTam,
                                filter.SoBangGia, filter.HieuLucVoHan, filter.NgayHieuLuc, filter.HanHieuLuc, filter.NguoiLap,
                                filter.Draft, filter.DaDuyet, filter.NguoiTao, filter.MatHang);
        }
        public List<BangGiaSearchInfor> TimKiemBangGiaPg(TimKiemBangGiaFilterInfor filter)
        {
            return GetListCommand<BangGiaSearchInfor>(Declare.StoreProcedureNamespace.spBangGiaTimKiemPg, filter.IdTrungTam,
                                filter.SoBangGia, filter.HieuLucVoHan, filter.NgayHieuLuc, filter.HanHieuLuc, filter.NguoiLap,
                                filter.Draft, filter.DaDuyet, filter.NguoiTao, filter.MatHang, filter.SoBatDau, filter.SoKetThuc);
        }
        public List<BangGiaSearchInfor> TimKiemBangGiaChuaDuyet(TimKiemBangGiaFilterInfor filter)
        {
            return GetListCommand<BangGiaSearchInfor>(Declare.StoreProcedureNamespace.spBangGiaSearchChuaDuyet, filter.IdTrungTam,
                                filter.SoBangGia, filter.HieuLucVoHan, filter.NgayHieuLuc, filter.HanHieuLuc, filter.NguoiLap,
                                filter.NguoiTao, filter.MatHang, filter.IdNhomDuyet);
        }
        public List<BangGiaSearchInfor> TimKiemBangGiaChuaDuyetPg(TimKiemBangGiaFilterInfor filter)
        {
            return GetListCommand<BangGiaSearchInfor>(Declare.StoreProcedureNamespace.spBangGiaSearchChuaDuyetPg, filter.IdTrungTam,
                                filter.SoBangGia, filter.HieuLucVoHan, filter.NgayHieuLuc, filter.HanHieuLuc, filter.NguoiLap,
                                filter.NguoiTao, filter.MatHang, filter.IdNhomDuyet, filter.SoBatDau, filter.SoKetThuc);
        }
        public List<BangGiaInfor> ExistBangGia(string soBangGia, int idBangGia)
        {
            return GetListCommand<BangGiaInfor>(Declare.StoreProcedureNamespace.spBangGiaExist, soBangGia, idBangGia);
        }
        #endregion

        #region bang gia header update
        public void UpdateBangGia(BangGiaInfor bangGia)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaUpdate, bangGia.IdBangGia, bangGia.SoBangGia,
                           bangGia.NgayLap, bangGia.NguoiLap, bangGia.GhiChu, bangGia.Draft, bangGia.NguoiCapNhat, bangGia.ListIdTrungTam, bangGia.ListMaTrungTam);
        }

        public void UpdateBangGiaDuyet(BangGiaInfor bangGia)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaUpdateDuyet, bangGia.IdBangGia, bangGia.DaDuyet,
                           bangGia.NgayLap, bangGia.NguoiLap, bangGia.GhiChu, bangGia.Draft, bangGia.NguoiCapNhat, bangGia.ListIdTrungTam, bangGia.ListMaTrungTam);
        }

        public int InsertBangGia(BangGiaInfor bangGia)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaInsert, bangGia.IdBangGia, bangGia.SoBangGia,
                           bangGia.NgayLap, bangGia.NguoiLap, bangGia.GhiChu, bangGia.Draft, bangGia.NguoiTao, bangGia.ListIdTrungTam, bangGia.ListMaTrungTam);
            return Common.IntValue(Parameters["p_IdBangGia"].Value);
        }
        public void InsertBangGiaTrungTam(int idBangGia, int idTrungTam)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaTTamInsert, idBangGia, idTrungTam);
        }

        public void DeleteBangGia(int idBangGia)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaDelete, idBangGia);
        }

        public void DeleteBangGiaTrungTam(int idBangGia)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaTTamDelete, idBangGia);
        }

        public void DuyetBangGia(BangGiaInfor bangGia)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaDuyet, bangGia.IdBangGia);
        }
        public void CapNhatNhomDuyetBangGia(BangGiaInfor bangGia)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaChiTietUpdateNhomDuyet, bangGia.IdBangGia);
        }
        #endregion

        #region bang gia chi tiet update
        public void UpdateBangGiaChiTiet(BangGiaChiTietInfor bgct)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaChiTietUpdate, bgct.IdChiTiet, bgct.IdBangGia, bgct.IdSanPham,
                           bgct.GiaNhapHDCuoi, bgct.GiaTonKhoBQ, bgct.TienChietKhauQK, bgct.TienKhuyenMai, bgct.TyLeLNBQ, bgct.DungSaiMin, bgct.DungSaiMax,
                           bgct.GiaMin, bgct.GiaMax, bgct.GiaBanAnToan, bgct.DonGiaChuaVAT, bgct.SoLuongBanBQ, bgct.DungSaiSLBQ,
                           bgct.TyLeChietKhau, bgct.TienChietKhau, bgct.TyLeVAT, bgct.TienVAT, bgct.DonGiaCoVAT, bgct.TyLeThuong,
                           bgct.ThuongNong, bgct.NguoiCapNhat, bgct.GiaNiemYet, bgct.GiaWebSite, bgct.LoiNhuan, bgct.LoiNhuanTon, bgct.GiaBanBuon,
                           bgct.LoiNhuanBB, bgct.LoiNhuanTonBB, bgct.DaDuyet, bgct.IdNhomDuyet, bgct.NhomDuyet, bgct.GiaNhapDemoCuoi, bgct.GiaBanDemo, bgct.LoiNhuanDemo, bgct.KhuyenMai, bgct.IdDKMua);
        }
        public int InsertBangGiaChiTiet(BangGiaChiTietInfor bgct)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaChiTietInsert, bgct.IdChiTiet, bgct.IdBangGia, bgct.IdSanPham,
                           bgct.GiaNhapHDCuoi, bgct.GiaTonKhoBQ, bgct.TienChietKhauQK, bgct.TienKhuyenMai, bgct.TyLeLNBQ, bgct.DungSaiMin, bgct.DungSaiMax,
                           bgct.GiaMin, bgct.GiaMax, bgct.GiaBanAnToan, bgct.DonGiaChuaVAT, bgct.SoLuongBanBQ, bgct.DungSaiSLBQ,
                           bgct.TyLeChietKhau, bgct.TienChietKhau, bgct.TyLeVAT, bgct.TienVAT, bgct.DonGiaCoVAT, bgct.TyLeThuong,
                           bgct.ThuongNong, bgct.NguoiCapNhat, bgct.GiaNiemYet, bgct.GiaWebSite, bgct.LoiNhuan, bgct.LoiNhuanTon, bgct.GiaBanBuon,
                           bgct.LoiNhuanBB, bgct.LoiNhuanTonBB, bgct.DaDuyet, bgct.IdNhomDuyet, bgct.NhomDuyet, bgct.GiaNhapDemoCuoi, bgct.GiaBanDemo, bgct.LoiNhuanDemo, bgct.KhuyenMai, bgct.IdDKMua);
            return Common.IntValue(Parameters["p_IdChiTiet"].Value);
        }
        public void DeleteBangGiaChiTiet(BangGiaChiTietInfor bgct)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaChiTietDelete, bgct.IdChiTiet);
        }
        public void DuyetBangGiaChiTiet(BangGiaChiTietInfor bgct)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaChiTietDuyet, bgct.IdChiTiet, bgct.NguoiDuyet, bgct.DaDuyet, bgct.IdBangGia);
        }
        #endregion

        #region bang gia ban
        public BangGiaBanChiTietInfor GetGiaBanTheoThoiGian(int idTrungTam, DateTime thoiGian, string maSanPham)
        {
            return GetObjectCommand<BangGiaBanChiTietInfor>(Declare.StoreProcedureNamespace.spBangGiaGetGiaBanThoiGian, idTrungTam, thoiGian, maSanPham);
        }
        public BangGiaBanChiTietInfor GetGiaBan(int idTrungTam, int idKho, string maSanPham)
        {
            return GetObjectCommand<BangGiaBanChiTietInfor>(Declare.StoreProcedureNamespace.spBangGiaGetGiaBan, idTrungTam, idKho, maSanPham);
        }
        public List<BangGiaBanChiTietBCInfor> GetBangGiaBan(int idTrungTam)
        {
            return GetListCommand<BangGiaBanChiTietBCInfor>(Declare.StoreProcedureNamespace.spBangGiaGetBangGiaBan, idTrungTam);
        }
        public List<BangGiaBanChiTietBCInfor> GetBangGiaBan(int idTrungTam, int coTon)
        {
            return GetListCommand<BangGiaBanChiTietBCInfor>(Declare.StoreProcedureNamespace.spBangGiaGetBangGiaBanTon, idTrungTam, coTon);
        }
        public List<BangGiaBanChiTietBCInfor> GetBangGiaBanPg(int idTrungTam, int coTon, int soBatDau, int soKetThuc, string maSanPham, string nganh, int maxton, int idNhomNDung)
        {
            return GetListCommand<BangGiaBanChiTietBCInfor>(Declare.StoreProcedureNamespace.spBangGiaGetBangGiaBanTonPg, idTrungTam, coTon, soBatDau, soKetThuc, maSanPham, nganh, maxton, idNhomNDung);
        }
        //public List<BangGiaBanChiTietBCInfor> GetBangGiaBanOnline(int idTrungTam, int coTon, string maSanPham, string nganh, int maxton, DateTime lastSync)
        //{
        //    return GetListCommand<BangGiaBanChiTietBCInfor>(Declare.StoreProcedureNamespace.spBangGiaGetBangGiaBanTonOnline, idTrungTam, coTon, maSanPham, nganh, maxton, lastSync);
        //}
        public bool IsBangGiaBanOnlineChanged(DateTime lastSync)
        {
            int result =
                Convert.ToInt32(ExecuteScalar("select count(*) from tbl_banggia_banhang where ngaycapnhat > :lastSync",
                                              lastSync));
            if (result > 0) return true;

            result =
                Convert.ToInt32(ExecuteScalar("select count(*) from tbl_hangtonkho where last_update_date > :lastSync",
                                              lastSync));
            if (result > 0) return true;

            return false;
        }
        public List<SanPhamKhongCoGiaBCInfor> GetSanPhamKhongCoGia(int idTrungTam)
        {
            return GetListCommand<SanPhamKhongCoGiaBCInfor>(Declare.StoreProcedureNamespace.spBangGiaGetSanPhamChuaCoGia, idTrungTam);
        }
        public List<BangGiaBanChiTietBCInfor> GetChinhSachGiaBan(int idTrungTam, int idSanPham)
        {
            return GetListCommand<BangGiaBanChiTietBCInfor>(Declare.StoreProcedureNamespace.spBangGiaGetChinhSachGiaBan, idTrungTam, idSanPham);
        }
        public List<BangGiaBanChiTietBCInfor> GetChinhSachGiaBanPg(int idTrungTam, int soBatDau, int soKetThuc, string sanPham, string nganhHang, int diemThuong, int hieuLuc)
        {
            return GetListCommand<BangGiaBanChiTietBCInfor>(Declare.StoreProcedureNamespace.spBangGiaGetChinhSachGiaBanPg, idTrungTam, soBatDau, soKetThuc, sanPham, nganhHang, diemThuong, hieuLuc);
        }
        //public BangGiaChinhSachInfor GetChinhSachAD(int idTrungTam, int idKho, string maSanPham)
        //{
        //    return GetObjectCommand<BangGiaChinhSachInfor>(Declare.StoreProcedureNamespace.spBangGiaGetGiaBan, idTrungTam, idKho, maSanPham);
        //}
        public List<BangGiaBanChiTietInfor> LoadGiaSanPham(int idNguoiDung, int idTrungTam, int idKho, int idLoaiDT, string maSanPham)
        {
            return GetListCommand<BangGiaBanChiTietInfor>(Declare.StoreProcedureNamespace.spBangGiaLoadGiaBanByNSD, idNguoiDung, idTrungTam, idKho, idLoaiDT, maSanPham);
        }
        public List<ItemGiaBanInfor> LoadGiaSanPhamTheoTrungTam(string maSanPham)
        {
            return GetListCommand<ItemGiaBanInfor>(Declare.StoreProcedureNamespace.spBangGiaLoadGiaBanByOrg, maSanPham);
        }
        #endregion

        #region bang gia ban lich su
        public List<BangGiaChiTietLichSuInfor> GetAllLichSuThayDoiGiaBan(int idTrungTam, int idSanPham, DateTime tuNgay, DateTime denNgay)
        {
            return GetListCommand<BangGiaChiTietLichSuInfor>(Declare.StoreProcedureNamespace.spBangGiaBanHangLichSuSearch, idTrungTam, idSanPham, clsUtils.DateValue(tuNgay), clsUtils.DateValue(denNgay));
        }
        public List<BangGiaChiTietLichSuInfor> GetAllLichSuThayDoiGiaBanPg(int idTrungTam, string nganhHang, string maSanPham, DateTime tuNgay, DateTime denNgay, int soBatDau, int soKetThuc)
        {
            return GetListCommand<BangGiaChiTietLichSuInfor>(Declare.StoreProcedureNamespace.spBangGiaBanHangLichSuSearchPg, idTrungTam, nganhHang, maSanPham, clsUtils.DateValue(tuNgay), clsUtils.DateValue(denNgay), soBatDau, soKetThuc);
        }
        public void DeleteLichSuThayDoiGiaBanById(int idLichSu)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaBanHangLichSuDelete, idLichSu);
        }
        public void DeleteLichSuThayDoiGiaBanAll(int idTrungTam, int idSanPham, DateTime tuNgay, DateTime denNgay)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaBanHangLichSuDelete, idTrungTam, idSanPham, clsUtils.DateValue(tuNgay), clsUtils.DateValue(denNgay));
        }
        #endregion

        #region Day khuyen mai
        public void DongBoKhuyenMai(string maSanPham, double tienKhuyenMai, int idDKMua)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaDongBoKhuyenMai, maSanPham, tienKhuyenMai, idDKMua);
        }

        public void DongBoKhuyenMai(int idTrungTam, string maSanPham, double tienKhuyenMai, int idDKMua)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaDongBoKhuyenMaiTTam, idTrungTam, maSanPham, tienKhuyenMai, idDKMua);
        }

        public List<BangGiaBanChiTietBCInfor> LoadSanPhamChuaDayKhuyenMaiOrc(int idtrungtam)
        {
            return GetListCommand<BangGiaBanChiTietBCInfor>(Declare.StoreProcedureNamespace.spSanPhamSelectChuaDayKMOrc, idtrungtam);
        }

        public List<BangGiaBanChiTietBCInfor> LoadSanPhamChuaDayKhuyenMaiWeb()
        {
            return GetListCommand<BangGiaBanChiTietBCInfor>(Declare.StoreProcedureNamespace.spSanPhamSelectChuaDayKMWeb);
        }

        public void UpdateTrangThaiDayWeb(string maSanPham, int dongbo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spSanPhamUpdateTrangThaiDayKMWeb, maSanPham, dongbo);
        }
        #endregion

        public BangGiaBanChiTietBCInfor GetSanPham(string maSanPham, string maTrungTam)
        {
            return GetObjectCommand<BangGiaBanChiTietBCInfor>(Declare.StoreProcedureNamespace.spSanPhamSelectCheckKM, maTrungTam, maSanPham);
        }
    }

    public class BaoCaoBangGiaHienTaiDao : Base3Dao
    {
        private static BaoCaoBangGiaHienTaiDao instance;

        private BaoCaoBangGiaHienTaiDao() { }

        public static BaoCaoBangGiaHienTaiDao Instance
        {
            get { return instance ?? (instance = new BaoCaoBangGiaHienTaiDao()); }
        }
        public List<BangGiaBanChiTietBCInfor> GetBangGiaBanPg(int idTrungTam, int coTon, int soBatDau, int soKetThuc, string maSanPham, string nganh, int maxton, int idNhomNDung)
        {
            return GetListCommand<BangGiaBanChiTietBCInfor>(Declare.StoreProcedureNamespace.spBangGiaGetBangGiaBanTonPg, idTrungTam, coTon, soBatDau, soKetThuc, maSanPham, nganh, maxton, idNhomNDung);
        }
    }
    public class BaoCaoBangGiaOnlineDao : Base3Dao
    {
        private static BaoCaoBangGiaOnlineDao instance;

        private BaoCaoBangGiaOnlineDao() { }

        public static BaoCaoBangGiaOnlineDao Instance
        {
            get { return instance ?? (instance = new BaoCaoBangGiaOnlineDao()); }
        }
        public List<BangGiaBanChiTietBCInfor> GetBangGiaBanOnline(int idTrungTam, int coTon, string maSanPham, string nganh, int maxton, DateTime lastSync)
        {
            return GetListCommand<BangGiaBanChiTietBCInfor>(Declare.StoreProcedureNamespace.spBangGiaGetBangGiaBanTonOnline, idTrungTam, coTon, maSanPham, nganh, maxton, lastSync);
        }
    }
}
