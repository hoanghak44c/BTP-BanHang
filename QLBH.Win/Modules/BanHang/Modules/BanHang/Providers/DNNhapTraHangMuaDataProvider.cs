using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.BanHang.DAO;
using QLBanHang.Modules.BanHang.Infors;
using QLBH.Core.Business;
using QLBH.Core.Providers;

namespace QLBanHang.Modules.BanHang.Providers
{
    public class DNNhapTraHangMuaDataProvider : BusinessProviderBase, IBussinessKeToanKhoProvider<ChungTuBanHangInfor, NhapHangTraChiTietHHInfor>
    {
        private static DNNhapTraHangMuaDataProvider instance;
        public static DNNhapTraHangMuaDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DNNhapTraHangMuaDataProvider();
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
            NhapHangTraMuaDAO.Instance.DeleteChungTu(idChungTu);
        }

        public List<NhapHangTraChiTietHHInfor> GetListChiTietChungTuByIdChungTu(int idChungTu)
        {
            return Origin(NhapHangTraMuaDAO.Instance.GetListChiTietChungTuByIdChungTu(idChungTu));
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

        public void UpdateTrangThaiChungTu(int idchungtu, int trangthai)
        {
            NhapHangTraMuaDAO.Instance.UpdateTrangThaiChungTu(idchungtu, trangthai);
        }

        public List<NhapHangTraMuaInfor> GetListAllChungTuNhapTra(int idtrungtam, int idkho, int idkhachhang, DateTime start, DateTime end, int loaichungtu, int trangthai, string username)
        {
            return NhapHangTraMuaDAO.Instance.GetListAllChungTuNhapTra(idtrungtam, idkho, idkhachhang, start, end, loaichungtu, trangthai, username);
        }
        public List<NhapHangTraMuaInfor> GetListAllChungTuNhapTraPg(TimKiemChungTuFilterInfor filter)
        {
            return NhapHangTraMuaDAO.Instance.GetListAllChungTuNhapTraPg(filter);
        }

        public List<NhapHangTraMuaInfor> GetListAllChungTuNhapTraKT(int idtrungtam, int idkho, int idkhachhang, DateTime start, DateTime end, int loaichungtu, int trangthai, string username)
        {
            return NhapHangTraMuaDAO.Instance.GetListAllChungTuNhapTraKT(idtrungtam, idkho, idkhachhang, start, end, loaichungtu, trangthai, username);
        }

        public List<NhapHangTraMuaInfor> GetListAllChungTuNhapTraKTPg(TimKiemChungTuFilterInfor filter)
        {
            return NhapHangTraMuaDAO.Instance.GetListAllChungTuNhapTraKTPg(filter);
        }

        public List<NhapHangTraMuaInfor> GetListAllChungTuNhapTraChiTien(int idtrungtam, int idkho, int idkhachhang, DateTime start, DateTime end, int loaichungtu, int trangthai, string username)
        {
            return NhapHangTraMuaDAO.Instance.GetListAllChungTuNhapTraChiTien(idtrungtam, idkho, idkhachhang, start, end, loaichungtu, trangthai, username);
        }
        public List<NhapHangTraMuaInfor> GetListAllChungTuNhapTraChiTienPg(string sophieu, string username, int idkho, int idkhachhang, DateTime start, DateTime end, int loaichungtu, int trangthai, int draft, string ghichu, string nganh, int soBatDau, int soKetThuc)
        {
            return NhapHangTraMuaDAO.Instance.GetListAllChungTuNhapTraChiTienPg(sophieu, username, idkho, idkhachhang, start, end, loaichungtu, trangthai, draft, ghichu, nganh, soBatDau, soKetThuc);
        }

    }
}
