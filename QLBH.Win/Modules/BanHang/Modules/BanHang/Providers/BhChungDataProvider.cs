using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.BanHang.DAO;
using QLBanHang.Modules.BanHang.Infors;

namespace QLBanHang.Modules.BanHang.Providers
{
    public class BhChungDataProvider
    {
        private static BhChungDataProvider instance;
        public static BhChungDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new BhChungDataProvider();
                return instance;
            }
        }

        internal InPhieuBaoHanhInfor GetPhieuBaoHanh(string sophieuxuat)
        {
            return BhChungDAO.Instance.GetPhieuBaoHanh(sophieuxuat);
        }

        internal List<InPhieuBaoHanhChiTietInfor> GetPhieuBaoHanhChiTiet(string soChungTuGoc)
        {
            return BhChungDAO.Instance.GetPhieuBaoHanhChiTiet(soChungTuGoc);
        }
        internal List<InPhieuBaoHanhChiTietInfor> GetListLinhKienBaoHanh(string maVachThanhPham, int idSanPham, int idKho, DateTime ngayMua)
        {
            return BhChungDAO.Instance.GetListLinhKienBaoHanh(maVachThanhPham, idSanPham, idKho, ngayMua);
        }

    }
}
