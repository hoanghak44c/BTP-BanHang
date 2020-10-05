using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.BanHang.DAO;
using QLBanHang.Modules.BanHang.Infors;

namespace QLBanHang.Modules.BanHang.Providers
{
    public class BhBaoHanhDataProvider
    {
        private static BhBaoHanhDataProvider instance;
        public static BhBaoHanhDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new BhBaoHanhDataProvider();
                return instance;
            }
        }
        public List<BhBaoHanhInfor> GetBhBaoHanhInfor(int iddoituong,string serialnumber)
        {
            return BhBaoHanhDAO.Instance.GetBhBaoHanhInfor(iddoituong, serialnumber);
        }
        internal List<BhBaoHanhInfor> GetBhBaoHanhByChungTu(int idchungtuxuat,string mavach)
        {
            return BhBaoHanhDAO.Instance.GetBhBaoHanhByChungTu(idchungtuxuat,mavach);
        }
        internal void UpdateMaVachBaoHanh(int idbaohanh, string mavachdoi)
        {
            BhBaoHanhDAO.Instance.UpdateMaVachBaoHanh(idbaohanh, mavachdoi);
        }
        internal BhBaoHanhInfor SearchMaVach(string mavach, string soCtuGoc)
        {
            return BhBaoHanhDAO.Instance.SearchMaVach(mavach, soCtuGoc);
        }
        public void KichHoatBaoHanh(KichHoatBaoHanhHangInfor khbh)
        {
            BhBaoHanhDAO.Instance.KichHoatBaoHanh(khbh);
        }
        public void KichHoatBaoHanh(KichHoatBaoHanhMobileInfor khbh)
        {
            BhBaoHanhDAO.Instance.KichHoatBaoHanh(khbh);
        }
    }
}
