using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.BanHang.Infors;
using QLBH.Common;
using QLBH.Core.Data;

namespace QLBanHang.Modules.BanHang.DAO
{
    public class BHangDoiMaChiTietHHDAO:BaseDAO
    {
        private static BHangDoiMaChiTietHHDAO instance;
        public static BHangDoiMaChiTietHHDAO Instance
        {
            get
            {
                if (instance == null) instance = new BHangDoiMaChiTietHHDAO();
                return instance;
            }
        }

        internal void DeleteChiTietHangHoa(ChungTuBanHangChiTietHangHoaInfor chiTietHangHoaInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuDoiMaHHDelete,
                           chiTietHangHoaInfo.IdChungTuChiTiet, chiTietHangHoaInfo.IdChiTietHangHoa);
        }
    }
}
