using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using QLBH.Core.Data;
using QLBH.Common;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.DAO;

// <Remarks>
// Tạo BangGiaDataProvider
// Người tạo: Lê Mạnh Tuấn
// Ngày tạo : 24/07/2012
// Người sửa cuối:
// </remarks>

namespace QLBanHang.Modules.BanHang.Providers
{

    public class BangGiaDiemThuongDataProvider
    {
        private static BangGiaDiemThuongDataProvider instance;
        public static BangGiaDiemThuongDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new BangGiaDiemThuongDataProvider();
                return instance;
            }
        }

        public List<BangGiaDiemThuongInfor> LoadAllLinhVucNganhLoai()
        {
            return BangGiaDiemThuongDAO.Instance.LoadAllLinhVucNganhLoai();
        }

        public List<BangGiaDiemThuongInfor> LoadAllKhoangDiemThuong()
        {
            return BangGiaDiemThuongDAO.Instance.LoadAllKhoangDiemThuong();
        }

        public void Update(BangGiaDiemThuongInfor info)
        {
            BangGiaDiemThuongDAO.Instance.Update(info);
        }

        public void Delete(BangGiaDiemThuongInfor info)
        {
            BangGiaDiemThuongDAO.Instance.Delete(info);
        }

        public bool ValidData(BangGiaADDKMuaInfor dkm)
        {
            if (dkm.TyLeDiemThuong == 0 && dkm.SoDiemThuong == 0)
                return true;
            return BangGiaDiemThuongDAO.Instance.ValidData(dkm);
        }
    }
}
