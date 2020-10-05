using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.BanHang.DAO;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.KhoHang.Infors;
using QLBH.Core.Business;
using QLBH.Core.Providers;

namespace QLBanHang.Modules.BanHang.Providers
{
    public class BHangXacNhanDoiMaDataProvider : BusinessProviderBase,
        IBussinessKeToanKhoProvider<ChungTuBanHangInfor, BHangDoiMaChiTietHHInfor>,
        IBussinessKhoProvider<ChungTuBanHangInfor, BHangDoiMaChiTietHHInfor, ChungTuBanHangChiTietHangHoaInfor>
    {
        private static BHangXacNhanDoiMaDataProvider instance;
        public static BHangXacNhanDoiMaDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new BHangXacNhanDoiMaDataProvider();
                return instance;
            }
        }

        public void UpdateChungTu(ChungTuBanHangInfor chungTu)
        {
            BanHangDAO.Instance.UpdateChungTu(chungTu);
        }

        public int InsertChungTu(ChungTuBanHangInfor chungTu)
        {
            return BanHangDAO.Instance.InsertChungTu(chungTu);
        }

        public void DeleteChungTu(int idChungTu)
        {
            BHangDoiMaDAO.Instance.DeleteChungTu(idChungTu);
        }

        public List<BHangDoiMaChiTietHHInfor> GetListChiTietChungTuByIdChungTu(int idChungTu)
        {
            return BHangDoiMaDAO.Instance.GetListChiTietChungTuByIdChungTu(idChungTu);
        }

        public int InsertChiTietChungTu(BHangDoiMaChiTietHHInfor chiTietChungTu)
        {
            return BHangDoiMaDAO.Instance.InsertChungTuChiTiet(chiTietChungTu);
        }

        public void DeleteChiTietChungTu(BHangDoiMaChiTietHHInfor chiTietChungTu)
        {
            BHangDoiMaDAO.Instance.DeleteChungTuChiTiet(chiTietChungTu);
        }

        public void UpdateChiTietChungTu(BHangDoiMaChiTietHHInfor chiTietChungTu)
        {
            BanHangDAO.Instance.UpdateChiTietChungTu(chiTietChungTu);
        }

        public List<ChungTuBanHangChiTietHangHoaInfor> GetListChiTietHangHoaByIdChungTu(int idChungTu)
        {
            return BanHangDAO.Instance.GetListChiTietHangHoaByIdChungTu(idChungTu);
        }

        public void DeleteChiTietHangHoa(ChungTuBanHangChiTietHangHoaInfor chiTietHangHoaInfo)
        {
            BHangDoiMaChiTietHHDAO.Instance.DeleteChiTietHangHoa(chiTietHangHoaInfo);
        }

        public void InsertChiTietHangHoa(ChungTuBanHangChiTietHangHoaInfor chiTietHangHoaInfo)
        {
            BHangDoiMaDAO.Instance.InsertChiTietHangHoa(chiTietHangHoaInfo);
        }

        public void UpdateChiTietHangHoa(ChungTuBanHangChiTietHangHoaInfor chiTietHangHoaInfo)
        {
            BanHangDAO.Instance.UpdateChiTietHangHoa(chiTietHangHoaInfo);
        }

        public void InsertChungTuThanhToan(ChungTuThanhToanInfor chungtuthanhtoan)
        {
            BanHangDAO.Instance.InsertChungTuThanhToan(chungtuthanhtoan);
        }
        public void DeleteChungTuThanhToan(ChungTuThanhToanInfor chungtuthanhtoan)
        {
            BanHangDAO.Instance.DeleteChungTuThanhToanByIdChungTu(chungtuthanhtoan.IdChungTu);
        }
        //loai hàng hóa : hàng bán,hàng khuyến mãi
        public List<BHangDoiMaInfor> SearchChungTuBanHangByMaVach(string mavach)
        {
            return BHangDoiMaDAO.Instance.SearchChungTuBanHangByMaVach(mavach);
        }

        internal List<ChungTuBanHangInfor> SearchChungTuBanHangBySoPhieu(string sophieuxuat, string sochungtu, string sohoadon)
        {
            return BHangDoiMaDAO.Instance.SearchChungTuBanHangBySoPhieu(sophieuxuat, sochungtu, sohoadon);
        }
        /// <summary>
        /// tìm chi tiết
        /// </summary>
        /// <param name="idchungtu">id chung tu</param>
        /// <param name="loai">1: search with tbl_chungTu_ChiTiet_HangHoa; 0: search without tbl_chungTu_ChiTiet_HangHoa</param>
        /// <returns></returns>
        internal List<BHangDoiMaChiTietHHInfor> GetListAllChiTietHDByIdChungTu(int idchungtu, int loai)
        {
            return BHangDoiMaDAO.Instance.GetListAllChiTietHDByIdChungTu(idchungtu, loai);
        }

        internal List<BHangDoiMaChiTietHHInfor> GetListAllChiTietHDByIdChungTu(int idchungtu)
        {
            return BHangDoiMaDAO.Instance.GetListAllChiTietHDByIdChungTu(idchungtu);
        }

        internal List<BHangDoiMaChiTietHHInfor> GetListAllChiTietHDByIdChungTuXN(int idchungtu)
        {
            return BHangDoiMaDAO.Instance.GetListAllChiTietHDByIdChungTuXN(idchungtu);
        }

        internal int GetIdKhoNhapDoiMa(string maVach, int idSanPham, string soChungTu)
        {
            return BHangDoiMaDAO.Instance.GetIdKhoNhapDoiMa(maVach, idSanPham, soChungTu);
        }

        internal void UpdateDraft(int idchungtu, int draft)
        {
            BHangDoiMaDAO.Instance.UpdateDraft(idchungtu, draft);
        }

        internal ChungTuBanHangInfor SearchChungTuBanHangByPNKT(string sochungtu, int loaichungtu, int trangthai, int draft)
        {
            return BHangDoiMaDAO.Instance.SearchChungTuBanHangByPNKT(sochungtu, loaichungtu, trangthai, draft);
        }
        internal BHangDoiMaInfor SearchChungTuBanHangByPN(string sochungtu, int loaichungtu)
        {
            return BHangDoiMaDAO.Instance.SearchChungTuBanHangByPN(sochungtu, loaichungtu);
        }

        internal ChungTuBanHangInfor SearchChungTuBanHangBySoCTGoc(string sochungtugoc)
        {
            return BHangDoiMaDAO.Instance.SearchChungTuBanHangBySoCTGoc(sochungtugoc);
        }

        //internal BhDoiMaHangHoaChiTietInfor GetHangHoaChiTietInfor(string mavach, int idsanpham, int idkho)
        // {
        //     return BHangDoiMaDAO.Instance.GetHangHoaChiTietInfor(mavach, idsanpham, idkho);
        // }
        public List<BHangDoiMaInfor> GetListAllDoiMa(int idtrungtam, int idkho, int idkhachhang, DateTime start, DateTime end, int loaichungtu, int trangthai, string username)
         {
             return BHangDoiMaDAO.Instance.GetListAllDoiMa(idtrungtam, idkho, idkhachhang, start, end, loaichungtu, trangthai, username);
         }
        public List<BHangDoiMaInfor> GetListAllDoiMaPg(int idtrungtam, int idkho, int idkhachhang, DateTime start, DateTime end, string sophieu, int trangthai, string username, int sobatdau, int soketthuc)
        {
            return BHangDoiMaDAO.Instance.GetListAllDoiMaPg(idtrungtam, idkho, idkhachhang, start, end, sophieu, trangthai, username, sobatdau, soketthuc);
        }
        public List<BHangDoiMaInfor> GetListAllXNDoiMaPg(int idtrungtam, int idkho, int idkhachhang, DateTime start, DateTime end, string sophieu, int trangthai, string username, int sobatdau, int soketthuc)
        {
            return BHangDoiMaDAO.Instance.GetListAllXNDoiMaPg(idtrungtam, idkho, idkhachhang, start, end, sophieu, trangthai, username, sobatdau, soketthuc);
        }

        public List<BHangDoiMaInfor> GetListAllDoiMaKT(int idtrungtam, int idkho, int idkhachhang, DateTime start, DateTime end, int loaichungtu, int trangthai, string username)
         {
             return BHangDoiMaDAO.Instance.GetListAllDoiMaKT(idtrungtam, idkho, idkhachhang, start, end, loaichungtu, trangthai, username);
         }
        internal void UpdateHangHoaChiTiet(HangHoaChiTietInfo hangHoaChiTietInfo)
        {
            BHangDoiMaDAO.Instance.UpdateHangHoaChiTiet(hangHoaChiTietInfo);
        }
        
        internal void UpdateHangHoaChiTiet(int idchitiet,int soluong, int idchitietgoc)
        {
            BHangDoiMaDAO.Instance.UpdateHangHoaChiTiet(idchitiet, soluong, idchitietgoc);
        }
        public void InsertLichSuDoiMa(LichSuDoiMaInfor lsdm)
        {
            BHangDoiMaDAO.Instance.InsertLichSuDoiMa(lsdm);
        }
        internal void InsertHangHoaChiTiet(BhDoiMaHangHoaChiTietInfor hhct)
        {
            BHangDoiMaDAO.Instance.InsertHangHoaChiTiet(hhct);
        }

        internal int CheckSoLuongHangHoaChiTiet(int idkho,int idsanpham,string mavach)
        {
            return BHangDoiMaDAO.Instance.CheckSoLuongHangHoaChiTiet(idkho, idsanpham, mavach);
        }

        internal ChungTuBanHangChiTietHangHoaInfor GetChiTietHHBan(string mavach, int idsanpham, int idkho)
        {
            return BHangDoiMaDAO.Instance.GetChiTietHHBan(mavach, idsanpham, idkho);
        }

        //internal void UpdateChungTuChiTietHHDoiMa(int idchitietchungtu,int idhanghoachitietban,int idhanghoachitietdoi, int idKhoDoi)
        //{
        //    BHangDoiMaDAO.Instance.UpdateChungTuChiTietHHDoiMa(idchitietchungtu, idhanghoachitietban,
        //                                                              idhanghoachitietdoi, idKhoDoi);
        //}
    }
}
