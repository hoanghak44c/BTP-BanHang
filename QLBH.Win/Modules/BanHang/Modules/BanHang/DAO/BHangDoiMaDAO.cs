using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.BanHang.Infors;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.KhoHang.Infors;

namespace QLBanHang.Modules.BanHang.DAO
{
    public class BHangDoiMaDAO:BaseDAO
    {
       private static BHangDoiMaDAO instance;
       public static BHangDoiMaDAO Instance
        {
            get
            {
                if (instance == null) instance = new BHangDoiMaDAO();
                return instance;
            }
        }
       internal List<BHangDoiMaInfor> SearchChungTuBanHangByMaVach(string mavach)
        {
            return GetListCommand<BHangDoiMaInfor>(Declare.StoreProcedureNamespace.spChungTuNhapTraHangMuaGetByMaVach, mavach);

        }

        internal List<ChungTuBanHangInfor> SearchChungTuBanHangBySoPhieu(string sophieuxuat, string sochungtu, string sohoadon)
        {
            return
                GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuDoiHangMuaGetByPX,
                                                    sophieuxuat, sochungtu, sohoadon);
        }
        internal List<BHangDoiMaChiTietHHInfor> GetListAllChiTietHDByIdChungTu(int idchungtu, int loai)
        {
            if (loai == 1)
                return
                    GetListCommand<BHangDoiMaChiTietHHInfor>(
                        Declare.StoreProcedureNamespace.spChungTuNhapTraHangGetChiTiet, idchungtu,
                        Common.IntValue(TransactionType.DOIMAHANGMUA));
            else
                return
                    GetListCommand<BHangDoiMaChiTietHHInfor>(
                        Declare.StoreProcedureNamespace.spChungTuNhapTraHangGetChiTietDN, idchungtu);
        }

        internal List<BHangDoiMaChiTietHHInfor> GetListAllChiTietHDByIdChungTu(int idchungtu)
        {
            return
                GetListCommand<BHangDoiMaChiTietHHInfor>(
                    Declare.StoreProcedureNamespace.spChungTuDoiHangGetChiTietDN, idchungtu);
        }

        internal List<BHangDoiMaChiTietHHInfor> GetListAllChiTietHDByIdChungTuXN(int idchungtu)
        {
            return
                GetListCommand<BHangDoiMaChiTietHHInfor>(
                    Declare.StoreProcedureNamespace.spChungTuDoiHangGetChiTietXN, idchungtu);
        }

        internal int GetIdKhoNhapDoiMa(string maVach, int idSanPham, string soChungTu)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuGetIdKhoDoiHang, maVach, idSanPham, soChungTu);
            return Convert.ToInt32(Parameters["p_IdKhoDoiMa"].Value.ToString());
        }

        public void UpdateDraft(int idchungtu, int draft)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBHChungTuUpdateDraft, idchungtu, draft);
        }
        internal void UpdateTrangThaiChungTu(int idchungtu, int trangthai)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBhXuatTraBHUpdateTrangThai, idchungtu, trangthai);
        }
        public int InsertChungTuChiTiet(BHangDoiMaChiTietHHInfor oSave)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuNhapTraHangInsertChiTiet, oSave.IdChungTu,
                           oSave.IdSanPham, oSave.SoLuong, oSave.DonGia, oSave.TyleChietKhau, oSave.TienChietKhau,
                           oSave.ThanhTien, oSave.TienSauChietKhau, oSave.TyleVAT, oSave.TienVAT, oSave.TyleThuong,
                           oSave.ThuongNong, oSave.GiaTheoBangGia, oSave.IdSanPhamBan, oSave.NoKhuyenMai,
                           oSave.GiaNiemYet, oSave.GiaWebSite, oSave.GhiChu, oSave.MaVach, oSave.LoaiHangKem);
            return Common.IntValue(Parameters["p_IdChiTiet"].Value);
        }
        public List<BHangDoiMaChiTietHHInfor> GetListChiTietChungTuByIdChungTu(int idChungTu)
        {
            return
                GetListCommand<BHangDoiMaChiTietHHInfor>(
                    Declare.StoreProcedureNamespace.spChungTuBanHangCTietGetByCT, idChungTu);

        }

        //public void UpdateChiTietChungTu(BHangDoiMaChiTietHHInfor chiTietChungTu)
        //{
        //    ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangCTietUpdate, chiTietChungTu.IdChungTuChiTiet,
        //                   chiTietChungTu.IdChungTu, chiTietChungTu.IdSanPham, chiTietChungTu.SoLuong,
        //                   chiTietChungTu.DonGia, chiTietChungTu.TyleChietKhau, chiTietChungTu.TienChietKhau,
        //                   chiTietChungTu.ThanhTien, chiTietChungTu.TienSauChietKhau, chiTietChungTu.TyleVAT, chiTietChungTu.TienVAT,
        //                   chiTietChungTu.TyleThuong,
        //                   chiTietChungTu.ThuongNong, chiTietChungTu.GiaTheoBangGia, chiTietChungTu.IdSanPhamBan, chiTietChungTu.NoKhuyenMai,
        //                   chiTietChungTu.GiaNiemYet, chiTietChungTu.GhiChu, chiTietChungTu.IdChinhSach);
        //}
        public void DeleteChiTietChungTu(BHangDoiMaChiTietHHInfor chiTietHhInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangCTietDelete, chiTietHhInfor.IdChungTuChiTiet);
        }
        internal ChungTuBanHangInfor SearchChungTuBanHangByPNKT(string sochungtu, int loaichungtu, int trangthai, int draft)
        {
            return
                 GetObjectCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuDoiHangMuaGetByPX,
                                                     sochungtu, loaichungtu, trangthai, draft);
        }
        internal BHangDoiMaInfor SearchChungTuBanHangByPN(string sochungtu, int loaichungtu)
        {
            return
                GetObjectCommand<BHangDoiMaInfor>(Declare.StoreProcedureNamespace.spChungTuDoiHangMuaGetByPN,
                                                      sochungtu, loaichungtu);
        }

        internal ChungTuBanHangInfor SearchChungTuBanHangBySoCTGoc(string sochungtugoc)
        {
            return
                GetObjectCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuDoiHangMuaGetByPXGoc, sochungtugoc);
        }

        internal List<BHangDoiMaInfor> GetListAllDoiMa(int idtrungtam, int idkho, int idkhachhang, DateTime start, DateTime end, int loaichungtu, int trangthai, string username)
        {
            return
               GetListCommand<BHangDoiMaInfor>(Declare.StoreProcedureNamespace.spChungTuNhapTraHangMuaGetAll,
                                                     idtrungtam, idkho, idkhachhang, clsUtils.DateValue(start), clsUtils.DateValue(end), loaichungtu, trangthai, username);
        }

        internal List<BHangDoiMaInfor> GetListAllDoiMaPg(int idtrungtam, int idkho, int idkhachhang, DateTime start, DateTime end, string sophieu, int trangthai, string username, int sobatdau, int soketthuc)
        {
            return
               GetListCommand<BHangDoiMaInfor>(Declare.StoreProcedureNamespace.spChungTuNhapTraHangMuaGetDoiMaPg,
                                                     idtrungtam, idkho, idkhachhang, clsUtils.DateValue(start), clsUtils.DateValue(end), sophieu, trangthai, username, sobatdau, soketthuc);
        }

        internal List<BHangDoiMaInfor> GetListAllXNDoiMaPg(int idtrungtam, int idkho, int idkhachhang, DateTime start, DateTime end, string sophieu, int trangthai, string username, int sobatdau, int soketthuc)
        {
            return
               GetListCommand<BHangDoiMaInfor>(Declare.StoreProcedureNamespace.spChungTuNhapTraHangMuaGetXNDoiMaPg,
                                                     idtrungtam, idkho, idkhachhang, clsUtils.DateValue(start), clsUtils.DateValue(end), sophieu, trangthai, username, sobatdau, soketthuc);
        }

        internal List<BHangDoiMaInfor> GetListAllDoiMaKT(int idtrungtam, int idkho, int idkhachhang, DateTime start, DateTime end, int loaichungtu, int trangthai, string username)
        {
            return
               GetListCommand<BHangDoiMaInfor>(Declare.StoreProcedureNamespace.spChungTuNhapTraHangMuaGetAllKT,
                                                     idtrungtam, idkho, idkhachhang, clsUtils.DateValue(start), clsUtils.DateValue(end), loaichungtu, trangthai, username);
        }

        internal BhDoiMaHangHoaChiTietInfor GetHangHoaChiTietInfor(string mavach, int idsanpham, string soCTuGoc)
        {
            return GetObjectCommand<BhDoiMaHangHoaChiTietInfor>(Declare.StoreProcedureNamespace.spGetHangHoaChiTietByMaVachCTGoc,
                                                        mavach, idsanpham, soCTuGoc);
        }

        internal void UpdateHangHoaChiTiet(HangHoaChiTietInfo hangHoaChiTietInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spUpdateHangHoaChiTietByInfo);
        }

        internal void UpdateHangHoaChiTiet(int idchitiet,int soluong, int idchitietgoc)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spUpdateHangHoaChiTietByIdChiTiet, idchitiet, soluong, idchitietgoc);
        }

        public void InsertChiTietHangHoa(ChungTuBanHangChiTietHangHoaInfor chiTietHangHoa)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangCTietHHoaInsertDM, chiTietHangHoa.IdChungTuChiTiet,
                           chiTietHangHoa.IdChiTietHangHoa, chiTietHangHoa.IdChiTietHangHoaGoc, chiTietHangHoa.SoLuong, chiTietHangHoa.TienChietKhau, chiTietHangHoa.TienVAT,
                           chiTietHangHoa.ThuongNong, chiTietHangHoa.GhiChu);
        }

        public void InsertLichSuDoiMa(LichSuDoiMaInfor lsdm)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangLichSuDoiMaInsert, lsdm.ID, lsdm.SoChungTuGoc,
                           lsdm.SoChungTuDoiMa, lsdm.NgayDoiMa, lsdm.IdSanPhamCu, lsdm.MaVachCu, lsdm.IdSanPhamMoi, lsdm.MaVachMoi);
        }
        internal void InsertHangHoaChiTiet(BhDoiMaHangHoaChiTietInfor hhct)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spInsertHangHoaChiTietByIdChiTiet, hhct.IdChiTiet,
                           hhct.IdDuDauKy, hhct.IdKho, hhct.IdSanPham, hhct.MaVach, hhct.SoLuong, hhct.GhiChu,
                           hhct.IdTrungTam,
                           hhct.BaoHanhHangTu, hhct.BaoHanhHangDen);
        }
        internal int CheckSoLuongHangHoaChiTiet(int idkho, int idsanpham, string mavach)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spHangHoaChiTietCheckSoLuong, idkho, idsanpham, mavach);
            return Common.IntValue(Parameters["p_Count"].Value);
        }
        //chua viet store
        internal ChungTuBanHangChiTietHangHoaInfor GetChiTietHHBan(string mavach, int idsanpham, int idkho)
        {
            return GetObjectCommand<ChungTuBanHangChiTietHangHoaInfor>(Declare.StoreProcedureNamespace.spChungTuDoiMaHHGetInfor, mavach, idsanpham, idkho);
        }

        internal void UpdateChungTuChiTietHHDoiMa(string mavach, string mavachdoi, int idsanpham, int idkhodoi, string sochungtugoc)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuDoiMaVachDHGocUpdate, mavach, mavachdoi, idsanpham,
                           idkhodoi, sochungtugoc);
        }

        internal void DeleteChungTu(int idchungtu)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBHChungTuDelete, idchungtu);
        }

        internal void DeleteChungTuChiTiet(ChungTuBanHangChiTietInfor chiTietChungTu)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBHChungTuChiTietDelete, chiTietChungTu.IdChungTuChiTiet);
        }
    }
}
