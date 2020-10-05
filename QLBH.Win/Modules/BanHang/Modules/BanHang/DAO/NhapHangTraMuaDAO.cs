using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.BanHang.DAO;
using QLBanHang.Modules.BanHang.Infors;
using QLBH.Common;
using QLBH.Core.Data;

namespace QLBanHang.Modules.BanHang.DAO
{
    public class NhapHangTraMuaDAO:BaseDAO 
    {
        private static NhapHangTraMuaDAO instance;
        public static NhapHangTraMuaDAO Instance
        {
            get
            {
                if (instance == null) instance = new NhapHangTraMuaDAO();
                return instance;
            }
        }
        internal List<NhapHangTraMuaInfor> SearchChungTuBanHangByMaVach(string mavach)
        {
            return GetListCommand<NhapHangTraMuaInfor>(Declare.StoreProcedureNamespace.spChungTuNhapTraHangMuaGetByMaVach, mavach);

        }

        internal List<ChungTuBanHangInfor> SearchChungTuBanHangBySoPhieu(string sophieuxuat, string sochungtu, string sohoadon)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuNhapTraHangMuaGetByPX, sophieuxuat, sochungtu, sohoadon);
        }
        internal ChungTuBanHangInfor SearchChungTuBanHangChuaTLBySoPhieu(int idChungTu, string sochungtu)
        {
            return GetObjectCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuNhapTraHangLaiMuaGetByPX, idChungTu, sochungtu);
        }

        internal List<NhapHangTraChiTietHHInfor> GetListAllChiTietHDByIdChungTu(int idchungtu, int loai)
        {
            if (loai == 1)
                return
                    GetListCommand<NhapHangTraChiTietHHInfor>(
                        Declare.StoreProcedureNamespace.spChungTuNhapTraHangGetChiTiet, idchungtu);
            else
            {
                return
                    GetListCommand<NhapHangTraChiTietHHInfor>(
                        Declare.StoreProcedureNamespace.spChungTuNhapTraHangGetChiTietDN, idchungtu);
            }
        }

        public void UpdateDraft(int idchungtu, int draft)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBHChungTuUpdateDraft, idchungtu, draft);
        }
        internal void UpdateTrangThaiChungTu(int idchungtu, int trangthai)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBhXuatTraBHUpdateTrangThai, idchungtu, trangthai);
        }
        public int InsertChungTuChiTiet(NhapHangTraChiTietHHInfor oSave)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuNhapTraHangInsertChiTiet, oSave.IdChungTu,
                           oSave.IdSanPham, oSave.SoLuong, oSave.DonGia, oSave.TyleChietKhau, oSave.TienChietKhau,
                           oSave.ThanhTien, oSave.TienSauChietKhau, oSave.TyleVAT, oSave.TienVAT, oSave.TyleThuong,
                           oSave.ThuongNong, oSave.GiaTheoBangGia, oSave.IdSanPhamBan, oSave.NoKhuyenMai,
                           oSave.GiaNiemYet, oSave.GiaWebSite,oSave.GhiChu, oSave.MaVach,oSave.LoaiHangKem);
            return Common.IntValue(Parameters["p_IdChiTiet"].Value);
        }
        public List<NhapHangTraChiTietHHInfor> GetListChiTietChungTuByIdChungTu(int idChungTu)
        {
            return
                GetListCommand<NhapHangTraChiTietHHInfor>(
                    Declare.StoreProcedureNamespace.spChungTuNhapHangTraLaiCTietGetByCT, idChungTu);

        }

        //public void UpdateChiTietChungTu(NhapHangTraChiTietHHInfor chiTietChungTu)
        //{
        //    ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangCTietUpdate, chiTietChungTu.IdChungTuChiTiet,
        //                   chiTietChungTu.IdChungTu, chiTietChungTu.IdSanPham, chiTietChungTu.SoLuongTra,
        //                   chiTietChungTu.DonGia, chiTietChungTu.TyleChietKhau, chiTietChungTu.TienChietKhau,
        //                   chiTietChungTu.ThanhTien, chiTietChungTu.TienSauChietKhau, chiTietChungTu.TyleVAT, chiTietChungTu.TienVAT,
        //                   chiTietChungTu.TyleThuong,
        //                   chiTietChungTu.ThuongNong, chiTietChungTu.GiaTheoBangGia, chiTietChungTu.IdSanPhamBan, chiTietChungTu.NoKhuyenMai,
        //                   chiTietChungTu.GiaNiemYet, chiTietChungTu.GhiChu, chiTietChungTu.IdChinhSach);
        //}
        public void DeleteChiTietChungTu(NhapHangTraChiTietHHInfor chiTietHhInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBHChungTuChiTietDelete, chiTietHhInfor.IdChungTuChiTiet);
        }
        internal ChungTuBanHangInfor SearchChungTuBanHangByPNKT(string sochungtu, int loaichungtu, int trangthai, int draft)
        {
            return
                 GetObjectCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuNhapTraHangMuaGetByPN,
                                                     sochungtu,loaichungtu,trangthai,draft);
        }
        internal NhapHangTraMuaInfor SearchChungTuBanHangByPN(string sochungtu, int loaichungtu)
        {
            return
                GetObjectCommand<NhapHangTraMuaInfor>(Declare.StoreProcedureNamespace.spChungTuNhapTraHangMuaGetByPN,
                                                      sochungtu, loaichungtu);
        }

        internal ChungTuBanHangInfor SearchChungTuBanHangBySoCTGoc( string sochungtugoc)
        {
            return GetObjectCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuNhapTraHangMuaGetByPXGoc, sochungtugoc);
        }

        internal List<NhapHangTraMuaInfor> GetListAllChungTuNhapTra(int idtrungtam, int idkho, int idkhachhang, DateTime start, DateTime end, int loaichungtu, int trangthai, string username)
        {
            return
               GetListCommand<NhapHangTraMuaInfor>(Declare.StoreProcedureNamespace.spChungTuNhapTraHangMuaGetAll,
                                                     idtrungtam, idkho, idkhachhang, clsUtils.DateValue(start), clsUtils.DateValue(end), loaichungtu, trangthai, username);
        }

        internal List<NhapHangTraMuaInfor> GetListAllChungTuNhapTraPg(TimKiemChungTuFilterInfor filter)
        {
            return GetListCommand<NhapHangTraMuaInfor>(Declare.StoreProcedureNamespace.spChungTuNhapTraHangMuaGetAllPg, filter.IdTrungTam, filter.IdKho, filter.IdDoiTuong,
                    clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay), filter.LoaiDonHang, filter.TrangThai, filter.SoPhieu, filter.UserName, filter.SoBatDau, filter.SoKetThuc);
        }

        internal List<NhapHangTraMuaInfor> GetListAllChungTuNhapTraKT(int idtrungtam, int idkho, int idkhachhang, DateTime start, DateTime end, int loaichungtu, int trangthai, string username)
        {
            return
               GetListCommand<NhapHangTraMuaInfor>(Declare.StoreProcedureNamespace.spChungTuNhapTraHangMuaGetAllKT,
                                                     idtrungtam, idkho, idkhachhang, clsUtils.DateValue(start), clsUtils.DateValue(end), loaichungtu, trangthai, username);
        }

        internal List<NhapHangTraMuaInfor> GetListAllChungTuNhapTraKTPg(TimKiemChungTuFilterInfor filter)
        {
            return
                GetListCommand<NhapHangTraMuaInfor>(Declare.StoreProcedureNamespace.spChungTuNhapTraHangMuaGetAllKTPg, filter.IdTrungTam, filter.IdKho, filter.IdDoiTuong,
                                                    clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay), filter.LoaiDonHang, filter.TrangThai, filter.SoPhieu, filter.UserName, filter.SoBatDau, filter.SoKetThuc);
        }

        internal List<NhapHangTraMuaInfor> GetListAllChungTuNhapTraChiTien(int idtrungtam, int idkho, int idkhachhang, DateTime start, DateTime end, int loaichungtu, int trangthai, string username)
        {
            return
               GetListCommand<NhapHangTraMuaInfor>(Declare.StoreProcedureNamespace.spChungTuNhapTraHangMuaGetAllChiTien,
                                                     idtrungtam, idkho, idkhachhang, clsUtils.DateValue(start), clsUtils.DateValue(end), loaichungtu, trangthai, username);
        }
        internal List<NhapHangTraMuaInfor> GetListAllChungTuNhapTraChiTienPg(string sophieu, string username, int idkho, int idkhachhang, DateTime start, DateTime end, int loaichungtu, int trangthai, int draft, string ghichu, string nganh, int soBatDau, int soKetThuc)
        {
            return
               GetListCommand<NhapHangTraMuaInfor>(Declare.StoreProcedureNamespace.spChungTuNhapTraHangMuaGetAllChiTienPg, sophieu, username,
                                                     idkho, idkhachhang, clsUtils.DateValue(start), clsUtils.DateValue(end), loaichungtu, trangthai, draft, ghichu, nganh, soBatDau, soKetThuc);
        }
        internal void DeleteChungTu(int idchungtu)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBHChungTuDelete, idchungtu);
        }
    }
}
