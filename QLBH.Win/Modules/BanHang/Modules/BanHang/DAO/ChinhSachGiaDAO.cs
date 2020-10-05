using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.BanHang.Infors;

namespace QLBanHang.Modules.BanHang.DAO
{
    public class ChinhSachGiaDAO :BaseDAO
    {
        private static ChinhSachGiaDAO instance;
        private ChinhSachGiaDAO()
        {
            CRUDTableName = Declare.TableNamespace.BangGia;
            //UseCaching = true;
        }
        public static ChinhSachGiaDAO Instance
        {
            get
            {
                if (instance == null) instance = new ChinhSachGiaDAO();
                return instance;
            }
        }
        #region chinh sach gia load
        public List<BangGiaChinhSachInfor> LoadAllChinhSach()
        {
            return GetListCommand<BangGiaChinhSachInfor>(Declare.StoreProcedureNamespace.spBangGiaChinhSachSelectAll);
        }
        public List<BangGiaChinhSachInfor> LoadChinhSachByNSD(string nguoiDung)
        {
            return GetListCommand<BangGiaChinhSachInfor>(Declare.StoreProcedureNamespace.spBangGiaChinhSachGetByNSD, nguoiDung);
        }
        public List<BangGiaChinhSachInfor> LoadChinhSachByIdDKMua(string lstIdDKMua)
        {
            return GetListCommand<BangGiaChinhSachInfor>(Declare.StoreProcedureNamespace.spBangGiaChinhSachGetByIdDKMua, lstIdDKMua);
        }
        public List<BangGiaChinhSachInfor> LoadChinhSachByTT(string nguoiDung, int draft)
        {
            return GetListCommand<BangGiaChinhSachInfor>(Declare.StoreProcedureNamespace.spBangGiaChinhSachGetByNSDTT,
                                                         nguoiDung, draft);
        }
        public BangGiaChinhSachInfor GetBangGiaChinhSachInforById(int idChinhSach)
        {
            return GetObjectCommand<BangGiaChinhSachInfor>(Declare.StoreProcedureNamespace.spBangGiaChinhSachGetById, idChinhSach);
        }
        public List<BangGiaChinhSachInfor> TimKiemChinhSachGia(TimKiemBangGiaFilterInfor filter)
        {
            return GetListCommand<BangGiaChinhSachInfor>(Declare.StoreProcedureNamespace.spBangGiaChinhSachTimKiem, filter.IdTrungTam,
                                filter.IdLoaiDoiTuong, filter.SoBangGia, filter.HieuLucVoHan, clsUtils.DateValue(filter.NgayHieuLuc), clsUtils.DateValue(filter.HanHieuLuc), filter.NguoiLap,
                                filter.Draft, filter.DaDuyet, filter.NguoiTao, filter.MatHang);
        }
        public List<BangGiaChinhSachInfor> LoadChinhSachGiaNoDuyetPg(TimKiemBangGiaFilterInfor filter)
        {
            return GetListCommand<BangGiaChinhSachInfor>(Declare.StoreProcedureNamespace.spBangGiaChinhSachNoDuyetPg, filter.IdTrungTam,
                                filter.IdLoaiDoiTuong, filter.SoBangGia, clsUtils.DateValue(filter.NgayHieuLuc), clsUtils.DateValue(filter.HanHieuLuc), 
                                filter.MatHang, filter.SoBatDau, filter.SoKetThuc, filter.LoaiBangGia, filter.IdNhomDuyet);
        }
        public List<BangGiaChinhSachInfor> SearchChinhSachGiaPg(TimKiemBangGiaFilterInfor filter)
        {
            return GetListCommand<BangGiaChinhSachInfor>(Declare.StoreProcedureNamespace.spBangGiaChinhSachSearchPg, filter.IdTrungTam,
                                filter.IdLoaiDoiTuong, filter.SoBangGia, clsUtils.DateValue(filter.NgayHieuLuc), clsUtils.DateValue(filter.HanHieuLuc), filter.NguoiLap,
                                filter.Draft, filter.DaDuyet, filter.NguoiTao, filter.MatHang, filter.SoBatDau, filter.SoKetThuc, filter.LoaiBangGia);
        }
        public List<BangGiaChinhSachInfor> TimKiemChinhSachGiaPg(TimKiemBangGiaFilterInfor filter)
        {
            return GetListCommand<BangGiaChinhSachInfor>(Declare.StoreProcedureNamespace.spBangGiaChinhSachTimKiemPg, filter.IdTrungTam,
                                filter.IdLoaiDoiTuong, filter.SoBangGia, clsUtils.DateValue(filter.NgayHieuLuc), clsUtils.DateValue(filter.HanHieuLuc), filter.NguoiLap,
                                filter.Draft, filter.DaDuyet, filter.NguoiTao, filter.MatHang, filter.SoBatDau, filter.SoKetThuc, filter.LoaiBangGia);
        }
        public List<BangGiaChinhSachBCInfor> TimKiemChinhSachGiaTongHop(TimKiemBangGiaFilterInfor filter)
        {
            return GetListCommand<BangGiaChinhSachBCInfor>(Declare.StoreProcedureNamespace.spBangGiaChinhSachTongHop, filter.IdTrungTam,
                                filter.SoBangGia, clsUtils.DateValue(filter.NgayHieuLuc), clsUtils.DateValue(filter.HanHieuLuc), filter.NguoiLap,
                                filter.Draft, filter.DaDuyet, filter.MatHang);
        }
        public List<BangGiaChinhSachBCInfor> TimKiemChinhSachGiaTongHopPg(TimKiemBangGiaFilterInfor filter)
        {
            return GetListCommand<BangGiaChinhSachBCInfor>(Declare.StoreProcedureNamespace.spBangGiaChinhSachTongHopPg, filter.IdTrungTam,
                                filter.SoBangGia, clsUtils.DateValue(filter.NgayHieuLuc), clsUtils.DateValue(filter.HanHieuLuc), filter.NguoiLap,
                                filter.Draft, filter.DaDuyet, filter.MatHang, filter.SoBatDau, filter.SoKetThuc);
        }

        public List<BangGiaCSachCKhauInfor> GetCSachCKhauApDung(int idTrungTam, int idKho, int idLoaiDT)
        {
            return GetListCommand<BangGiaCSachCKhauInfor>(Declare.StoreProcedureNamespace.spBangGiaGetCSachCKhauAD, idTrungTam, idKho, idLoaiDT);
        }

        public List<BangGiaChinhSachInfor> GetAllChinhSachApDung(int idTrungTam, int idKho, int idLoaiDT, string maSanPham, int loaiKhachHang)
        {
            return GetListCommand<BangGiaChinhSachInfor>(Declare.StoreProcedureNamespace.spBangGiaGetChinhSachAD, idTrungTam, idKho, idLoaiDT, maSanPham, loaiKhachHang);
        }
        public List<BangGiaChinhSachInfor> GetAllChinhSachApDungAll(int idTrungTam, string maSanPham)
        {
            return GetListCommand<BangGiaChinhSachInfor>(Declare.StoreProcedureNamespace.spBangGiaGetChinhSachAll, idTrungTam, maSanPham);
        }
        public List<BangGiaChinhSachInfor> GetAllChinhSachDaApDung(int idTrungTam, string maSanPham, DateTime ngayTao)
        {
            return GetListCommand<BangGiaChinhSachInfor>(Declare.StoreProcedureNamespace.spBangGiaGetChinhSachDaAD, idTrungTam, maSanPham, ngayTao);
        }
        public List<MatHangInfor> GetAllMatHangKhongApDung(string lstMatHang)
        {
            return GetListCommand<MatHangInfor>(Declare.StoreProcedureNamespace.spBangGiaGetMatHangKhongApDung, lstMatHang);
        }
        public List<BangGiaCSachCTietInfor> LoadSanPhamAnhHuong(int idChinhSach)
        {
            return GetListCommand<BangGiaCSachCTietInfor>(Declare.StoreProcedureNamespace.spBangGiaCSachCTietLoad, idChinhSach);
        }
        #endregion
        #region chinh sach ap dung load
        public List<BangGiaADShopInfor> GetBangGiaADShopInfor(int idChinhSach)
        {
            return GetListCommand<BangGiaADShopInfor>(Declare.StoreProcedureNamespace.spBangGiaTrungTamLoad, idChinhSach);
        }
        public List<BangGiaADKhachInfor> GetBangGiaADKhachInfor(int idChinhSach)
        {
            return GetListCommand<BangGiaADKhachInfor>(Declare.StoreProcedureNamespace.spBangGiaDoiTuongLoad, idChinhSach);
        }
        public List<BangGiaADTimeInfor> GetBangGiaADThoiGianInfor(int idChinhSach)
        {
            return GetListCommand<BangGiaADTimeInfor>(Declare.StoreProcedureNamespace.spBangGiaThoiGianLoad, idChinhSach);
        }
        public List<BangGiaADBankInfor> GetBangGiaADThanhToanInfor(int idChinhSach)
        {
            return GetListCommand<BangGiaADBankInfor>(Declare.StoreProcedureNamespace.spBangGiaThanhToanLoad, idChinhSach);
        }
        #endregion

        #region bang gia chinh sach update
        public void UpdateBangGiaChinhSach(BangGiaChinhSachInfor bgcs)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaChinhSachUpdate, bgcs.IdChinhSach, bgcs.SoChinhSach, bgcs.NgayLap,
                            bgcs.NguoiLap, bgcs.NgayHieuLuc, bgcs.HanHieuLuc, bgcs.GhiChu, bgcs.DuyNhatCMND, bgcs.DuyNhatSDT, bgcs.GioiTinh,
                            bgcs.DoTuoiTu, bgcs.DoTuoiDen, bgcs.GiaTriHDToiThieu, bgcs.IdNgheNghiep, bgcs.Draft, bgcs.IdTinh, bgcs.IdHuyen, 
                            bgcs.CachGiaoHang, bgcs.GiaTriDHDaMua, bgcs.ThoiHanMua, bgcs.DoUuTien, bgcs.ThanhToanToiThieu, bgcs.SoKhachDauNgay,
                            bgcs.NguoiCapNhat, bgcs.LoaiDoiTuong, bgcs.MacDinh, bgcs.ChinhSachAD, bgcs.SieuThiAD, bgcs.DoiTuongAD, bgcs.ThoiGianAD, 
                            bgcs.ThanhToanAD, bgcs.MotaKhac, bgcs.SoTienTToanToiThieu, bgcs.MatHangKhongApDung);
        }

        public void UpdateBangGiaChinhSachNoDuyet(BangGiaChinhSachInfor bgcs)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaChinhSachNoDuyetUpdate, bgcs.IdChinhSach, bgcs.SoChinhSach, bgcs.NgayLap,
                            bgcs.NguoiLap, bgcs.NgayHieuLuc, bgcs.HanHieuLuc, bgcs.GhiChu, bgcs.DuyNhatCMND, bgcs.DuyNhatSDT, bgcs.GioiTinh,
                            bgcs.DoTuoiTu, bgcs.DoTuoiDen, bgcs.GiaTriHDToiThieu, bgcs.IdNgheNghiep, bgcs.Draft, bgcs.IdTinh, bgcs.IdHuyen,
                            bgcs.CachGiaoHang, bgcs.GiaTriDHDaMua, bgcs.ThoiHanMua, bgcs.DoUuTien, bgcs.ThanhToanToiThieu, bgcs.SoKhachDauNgay,
                            bgcs.NguoiCapNhat, bgcs.LoaiDoiTuong, bgcs.MacDinh, bgcs.ChinhSachAD, bgcs.SieuThiAD, bgcs.DoiTuongAD, bgcs.ThoiGianAD,
                            bgcs.ThanhToanAD, bgcs.MotaKhac, bgcs.SoTienTToanToiThieu, bgcs.MatHangKhongApDung, bgcs.DaDuyet, bgcs.NguoiDuyet,
                            Declare.IdQuanLyTrucTiep, bgcs.ApDungKemMacDinh);
        }

        public int InsertBangGiaChinhSach(BangGiaChinhSachInfor bgcs)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaChinhSachInsert, bgcs.IdChinhSach, bgcs.SoChinhSach, bgcs.NgayLap,
                            bgcs.NguoiLap, bgcs.NgayHieuLuc, bgcs.HanHieuLuc, bgcs.GhiChu, bgcs.DuyNhatCMND, bgcs.DuyNhatSDT, bgcs.GioiTinh,
                            bgcs.DoTuoiTu, bgcs.DoTuoiDen, bgcs.GiaTriHDToiThieu, bgcs.IdNgheNghiep, bgcs.Draft, bgcs.IdTinh, bgcs.IdHuyen,
                            bgcs.CachGiaoHang, bgcs.GiaTriDHDaMua, bgcs.ThoiHanMua, bgcs.DoUuTien, bgcs.ThanhToanToiThieu, bgcs.SoKhachDauNgay,
                            bgcs.NguoiTao, bgcs.LoaiDoiTuong, bgcs.MacDinh, bgcs.ChinhSachAD, bgcs.SieuThiAD, bgcs.DoiTuongAD, bgcs.ThoiGianAD,
                            bgcs.ThanhToanAD, bgcs.MotaKhac, bgcs.SoTienTToanToiThieu, bgcs.MatHangKhongApDung);
            return Common.IntValue(Parameters["p_IdChinhSach"].Value);
        }

        public int InsertBangGiaChinhSachNoDuyet(BangGiaChinhSachInfor bgcs)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaChinhSachNoDuyetInsert, bgcs.IdChinhSach, bgcs.SoChinhSach, bgcs.NgayLap,
                            bgcs.NguoiLap, bgcs.NgayHieuLuc, bgcs.HanHieuLuc, bgcs.GhiChu, bgcs.DuyNhatCMND, bgcs.DuyNhatSDT, bgcs.GioiTinh,
                            bgcs.DoTuoiTu, bgcs.DoTuoiDen, bgcs.GiaTriHDToiThieu, bgcs.IdNgheNghiep, bgcs.Draft, bgcs.IdTinh, bgcs.IdHuyen,
                            bgcs.CachGiaoHang, bgcs.GiaTriDHDaMua, bgcs.ThoiHanMua, bgcs.DoUuTien, bgcs.ThanhToanToiThieu, bgcs.SoKhachDauNgay,
                            bgcs.NguoiTao, bgcs.LoaiDoiTuong, bgcs.MacDinh, bgcs.ChinhSachAD, bgcs.SieuThiAD, bgcs.DoiTuongAD, bgcs.ThoiGianAD,
                            bgcs.ThanhToanAD, bgcs.MotaKhac, bgcs.SoTienTToanToiThieu, bgcs.MatHangKhongApDung, bgcs.DaDuyet, bgcs.NguoiDuyet,
                            Declare.IdQuanLyTrucTiep, bgcs.ApDungKemMacDinh);
            return Common.IntValue(Parameters["p_IdChinhSach"].Value);
        }

        public void DeleteBangGiaChinhSach(int idChinhSach)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaChinhSachDelete, idChinhSach);
        }

        public List<BangGiaInfor> ExistBangGiaChinhSach(string soChinhSach, int idChinhSach)
        {
            return GetListCommand<BangGiaInfor>(Declare.StoreProcedureNamespace.spBangGiaChinhSachExist, soChinhSach, idChinhSach);
        }

        public void DuyetBangGiaChinhSach(BangGiaChinhSachInfor bgcs)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaChinhSachDuyet, bgcs.IdChinhSach, bgcs.DaDuyet, bgcs.NguoiDuyet);
        }
        public void ThietLapMacDinhChinhSach(BangGiaChinhSachInfor bgcs)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaChinhSachMacDinh, bgcs.IdChinhSach, bgcs.MacDinh);
        }
        #endregion

        #region bang gia doi tuong ap dung update
        public void InsertBangGiaADShop(BangGiaADShopInfor bgShop)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaTrungTamInsert, bgShop.IdChinhSach, bgShop.IdTrungTam, bgShop.IdKho, bgShop.SoLuongDonHang);
        }

        public void InsertBangGiaADKhach(BangGiaADKhachInfor bgKhach)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaDoiTuongInsert, bgKhach.IdChinhSach, bgKhach.IdDoiTuong, bgKhach.IdLoaiDT);//1(kho); 2(trung tam); 3(khach hang)
        }

        public void InsertBangGiaADThoiGian(BangGiaADTimeInfor bgTime)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaThoiGianInsert, bgTime.IdChinhSach, bgTime.Thu,
                           bgTime.DayOfWeek, bgTime.Ngay, bgTime.DayOfMonth, bgTime.GioTu, bgTime.GioDen);
        }

        public void InsertBangGiaADThanhToan(BangGiaADBankInfor bgBank)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaThanhToanInsert, bgBank.IdChinhSach,
                           bgBank.IdHinhThucTT, bgBank.IdNganHang, bgBank.IdThoiHanTT, bgBank.IdNganHangPH,
                           bgBank.TyLeThanhToan);
        }

        public void InsertSanPhamAnhHuong(BangGiaCSachCTietInfor bg)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaCSachCTietInsert, bg.IdChiTiet, bg.IdChinhSach,
                           bg.ChinhSachDKMua.IdDKMua,
                           bg.IdSPKem, bg.IdSanPham, bg.DonGiaChuaVAT, bg.TyLeChietKhau, bg.TienChietKhau, bg.TyLeVAT,
                           bg.TienVAT, bg.DonGiaCoVAT, bg.TyLeThuong,
                           bg.ThuongNong, bg.NguoiCapNhat, bg.GiaNhapHDCuoi, bg.GiaTonKhoBQ, bg.TienChietKhauQK,
                           bg.TyLeLNBQ, bg.DungSaiMin, bg.DungSaiMax, bg.GiaMin, bg.GiaMax,
                           bg.GiaBanAnToan, bg.SoLuongBanBQ, bg.DungSaiSLBQ, bg.LoiNhuan, bg.TienKhuyenMai,
                           bg.LoiNhuanTon, bg.GiaBanBuon, bg.LoiNhuanBB,
                           bg.LoiNhuanTonBB, bg.GiaNhapDemoCuoi, bg.GiaBanDemo, bg.LoiNhuanDemo);
        }

        public void DeleteBangGiaADShop(int idChinhSach)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaTrungTamDelete, idChinhSach);
        }

        public void DeleteBangGiaADKhach(int idChinhSach)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaDoiTuongDelete, idChinhSach);
        }
        public void DeleteBangGiaADThoiGian(int idChinhSach)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaThoiGianDelete, idChinhSach);
        }

        public void DeleteBangGiaADThanhToan(int idChinhSach)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaThanhToanDelete, idChinhSach);
        }

        public void DeleteSanPhamAnhHuong(int idChinhSach)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaCSachCTietDelete, idChinhSach);
        }

        #endregion
    }
}
