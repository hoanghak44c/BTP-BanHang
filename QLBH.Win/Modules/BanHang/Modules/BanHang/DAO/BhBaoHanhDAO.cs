using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.BanHang.Infors;
using QLBH.Common;
using QLBH.Core.Data;

namespace QLBanHang.Modules.BanHang.DAO
{
    class BhBaoHanhDAO:BaseDAO
    {
        private static BhBaoHanhDAO instance;
        private BhBaoHanhDAO()
        {
            CRUDTableName = Declare.TableNamespace.BhBaoHanh;
            //UseCaching = true;
        }
        public static BhBaoHanhDAO Instance
        {
            get
            {
                if (instance == null) instance = new BhBaoHanhDAO();
                return instance;
            }
        }
        public List<BhBaoHanhInfor> GetBhBaoHanhInfor(int iddoituong, string serialnumber)
        {
            return GetListCommand<BhBaoHanhInfor>(Declare.StoreProcedureNamespace.spBhBaoHanhGetListDtMV, iddoituong,
                                                    serialnumber);
        }
        internal List<BhBaoHanhInfor> GetBhBaoHanhByChungTu(int idchungtuxuat,string mavach)
        {
            return GetListCommand<BhBaoHanhInfor>(Declare.StoreProcedureNamespace.spBhBaoHanhGetByChungTu, idchungtuxuat,
                                                  mavach);
        }
        internal void UpdateMaVachBaoHanh(int idbaohanh, string mavachdoi)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBhBaoHanhUpdateMaVach, idbaohanh,
                                                  mavachdoi);
        }

        internal BhBaoHanhInfor SearchMaVach(string mavach, string soCtuGoc)
        {
            return GetObjectCommand<BhBaoHanhInfor>(Declare.StoreProcedureNamespace.spBhBaoHanhSearchMaVach, mavach, soCtuGoc);
        }
        public void KichHoatBaoHanh(KichHoatBaoHanhHangInfor khbh)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBhBaoHanhUpdateMaVach, khbh.IdChiTietChungTu,
                           khbh.IdChiTietHangHoa, khbh.IdSanPham, khbh.MaVach, khbh.SalesDate, khbh.GhiChu);
        }
        public void KichHoatBaoHanh(KichHoatBaoHanhMobileInfor khbh)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBhBaoHanhUpdateMaVach, khbh.IdChiTietChungTu,
                           khbh.IdChiTietHangHoa, khbh.IdSanPham, khbh.MaVach, khbh.NgayKichHoat, khbh.GhiChu);
        }
    }
}
