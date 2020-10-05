using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.BanHang.DAO;
using QLBanHang.Modules.BanHang.Infors;
using QLBH.Core.Business;
using QLBH.Core.Providers;

namespace QLBanHang.Modules.BanHang.Providers
{
    public class XacNhanNhapLaiKhacDataProvider : BusinessProviderBase, IBussinessKhoProvider<ChungTuBanHangInfor, NhapHangTraChiTietHHInfor, ChungTuBanHangChiTietHangHoaInfor>
        , IBussinessKeToanKhoProvider<ChungTuBanHangInfor, NhapHangTraChiTietHHInfor>
    {
        private static XacNhanNhapLaiKhacDataProvider instance;
        public static XacNhanNhapLaiKhacDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new XacNhanNhapLaiKhacDataProvider();
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
            BanHangDAO.Instance.DeleteChungTu(idChungTu);
        }

        public List<NhapHangTraChiTietHHInfor> GetListChiTietChungTuByIdChungTu(int idChungTu)
        {
            return NhapHangTraMuaDAO.Instance.GetListChiTietChungTuByIdChungTu(idChungTu);
        }

        public int InsertChiTietChungTu(NhapHangTraChiTietHHInfor chiTietChungTu)
        {
            return NhapHangTraMuaDAO.Instance.InsertChungTuChiTiet(chiTietChungTu);
        }

        public void DeleteChiTietChungTu(NhapHangTraChiTietHHInfor chiTietChungTu)
        {
            NhapHangTraMuaDAO.Instance.DeleteChiTietChungTu(chiTietChungTu);
        }

        public void UpdateChiTietChungTu(NhapHangTraChiTietHHInfor chiTietChungTu)
        {
            BanHangDAO.Instance.UpdateChiTietChungTu(chiTietChungTu);
        }

        public List<ChungTuBanHangChiTietHangHoaInfor> GetListChiTietHangHoaByIdChungTu(int idChungTu)
        {
            return BanHangDAO.Instance.GetListChiTietHangHoaByIdChungTu(idChungTu);
        }

        public void DeleteChiTietHangHoa(ChungTuBanHangChiTietHangHoaInfor chiTietHangHoaInfo)
        {
            BanHangDAO.Instance.DeleteChiTietHangHoa(chiTietHangHoaInfo);
        }

        public void InsertChiTietHangHoa(ChungTuBanHangChiTietHangHoaInfor chiTietHangHoaInfo)
        {
           BanHangDAO.Instance.InsertChiTietHangHoa(chiTietHangHoaInfo);
        }

        public void UpdateChiTietHangHoa(ChungTuBanHangChiTietHangHoaInfor chiTietHangHoaInfo)
        {
            BanHangDAO.Instance.UpdateChiTietHangHoa(chiTietHangHoaInfo);
        }

        //public int InsertChiTietChungTu(ChungTuBanHangChiTietInfor chiTietChungTu)
        //{
        //    return BanHangDAO.Instance.InsertChiTietChungTu(chiTietChungTu);
        //}

        //public void DeleteChiTietChungTu(ChungTuBanHangChiTietInfor chiTietChungTu)
        //{
        //    BanHangDAO.Instance.DeleteChiTietChungTu(chiTietChungTu);
        //}

        //public void UpdateChiTietChungTu(ChungTuBanHangChiTietInfor chiTietChungTu)
        //{
        //    BanHangDAO.Instance.UpdateChiTietChungTu(chiTietChungTu);
        //}
        public void InsertChungTuThanhToan(ChungTuThanhToanInfor chungtuthanhtoan)
        {
            BanHangDAO.Instance.InsertChungTuThanhToan(chungtuthanhtoan);
        }
        public void DeleteChungTuThanhToan(ChungTuThanhToanInfor chungtuthanhtoan)
        {
            BanHangDAO.Instance.DeleteChungTuThanhToanByIdChungTu(chungtuthanhtoan.IdChungTu);
        }
        //loai hàng hóa : hàng bán,hàng khuyến mãi
        public List<NhapHangTraMuaInfor> SearchChungTuBanHangByMaVach(string mavach)
        {
            return NhapHangTraMuaDAO.Instance.SearchChungTuBanHangByMaVach(mavach);
        }

        internal List<ChungTuBanHangInfor> SearchChungTuBanHangBySoPhieu(string sophieuxuat, string sochungtu, string sohoadon)
        {
            return NhapHangTraMuaDAO.Instance.SearchChungTuBanHangBySoPhieu(sophieuxuat, sochungtu, sohoadon);
        }
        internal ChungTuBanHangInfor SearchChungTuBanHangChuaTLBySoPhieu(int idChungTu, string sochungtu)
        {
            return NhapHangTraMuaDAO.Instance.SearchChungTuBanHangChuaTLBySoPhieu(idChungTu, sochungtu);
        }

        /// <summary>
        /// tìm chi tiết
        /// </summary>
        /// <param name="idchungtu">id chung tu</param>
        /// <param name="loai">1: search with tbl_chungTu_ChiTiet_HangHoa; 0: search without tbl_chungTu_ChiTiet_HangHoa</param>
        /// <returns></returns>
        internal List<NhapHangTraChiTietHHInfor> GetListAllChiTietHDByIdChungTu(int idchungtu,int loai)
        {
            return NhapHangTraMuaDAO.Instance.GetListAllChiTietHDByIdChungTu(idchungtu,loai);
        }
        internal void UpdateDraft(int idchungtu, int draft)
        {
            NhapHangTraMuaDAO.Instance.UpdateDraft(idchungtu, draft);
        }

        internal ChungTuBanHangInfor SearchChungTuBanHangByPNKT(string sochungtu, int loaichungtu,int trangthai,int draft)
        {
            return NhapHangTraMuaDAO.Instance.SearchChungTuBanHangByPNKT(sochungtu, loaichungtu,trangthai,draft);
        }
        internal NhapHangTraMuaInfor SearchChungTuBanHangByPN(string sochungtu, int loaichungtu)
        {
            return NhapHangTraMuaDAO.Instance.SearchChungTuBanHangByPN(sochungtu, loaichungtu);
        }

        internal ChungTuBanHangInfor SearchChungTuBanHangBySoCTGoc(string sochungtugoc)
        {
            return NhapHangTraMuaDAO.Instance.SearchChungTuBanHangBySoCTGoc(sochungtugoc);
        }
    }
}
