using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.BanHang.Infors;
using QLBH.Common;
using QLBH.Core.Data;

namespace QLBanHang.Modules.BanHang.DAO
{
    public class BhChungDAO : BaseDAO
    {
        private static BhChungDAO instance;
        private BhChungDAO()
        {
            //CRUDTableName = Declare.TableNamespace.BhBangKe;
            UseCaching = true;
        }
        public static BhChungDAO Instance
        {
            get
            {
                if (instance == null) instance = new BhChungDAO();
                return instance;
            }
        }

        internal InPhieuBaoHanhInfor GetPhieuBaoHanh(string sophieuxuat)
        {
            return GetObjectCommand<InPhieuBaoHanhInfor>(Declare.StoreProcedureNamespace.spInPhieuBaoHanhGet, sophieuxuat);
        }
        internal List<InPhieuBaoHanhChiTietInfor> GetPhieuBaoHanhChiTiet(string soChungTuGoc)
        {
            return GetListCommand<InPhieuBaoHanhChiTietInfor>(Declare.StoreProcedureNamespace.spInPhieuBaoHanhChiTiet, soChungTuGoc);
        }
        internal List<InPhieuBaoHanhChiTietInfor> GetListLinhKienBaoHanh(string maVachThanhPham, int idSanPham, int idKho, DateTime ngayMua)
        {
            return GetListCommand<InPhieuBaoHanhChiTietInfor>(Declare.StoreProcedureNamespace.spInPhieuBaoHanhGetLinhKien, maVachThanhPham, idSanPham, idKho, ngayMua);
        }
    }
}
