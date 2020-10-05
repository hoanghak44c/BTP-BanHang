using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.BanHang.Infors;

namespace QLBanHang.Modules.BanHang.DAO
{
    public class BangGiaDiemThuongDAO :BaseDAO
    {
        private static BangGiaDiemThuongDAO instance;
        private BangGiaDiemThuongDAO()
        {
            //CRUDTableName = Declare.TableNamespace.BangGia;
            //UseCaching = true;
        }
        public static BangGiaDiemThuongDAO Instance
        {
            get
            {
                if (instance == null) instance = new BangGiaDiemThuongDAO();
                return instance;
            }
        }

        public List<BangGiaDiemThuongInfor> LoadAllLinhVucNganhLoai()
        {
            return GetListCommand<BangGiaDiemThuongInfor>(Declare.StoreProcedureNamespace.spBangGiaDiemThuongGetDmuc);
        }

        public List<BangGiaDiemThuongInfor> LoadAllKhoangDiemThuong()
        {
            return GetListCommand<BangGiaDiemThuongInfor>(Declare.StoreProcedureNamespace.spBangGiaDiemThuongGetAll);
        }

        public void Update(BangGiaDiemThuongInfor info)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaDiemThuongUpdate, info.MaNganhHang, info.MaLoai,
                           info.TyLeThuongTu, info.TyLeThuongDen);
        }

        public void Delete(BangGiaDiemThuongInfor info)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaDiemThuongDelete, info.MaNganhHang, info.MaLoai);
        }

        public bool ValidData(BangGiaADDKMuaInfor dkm)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaDiemThuongCheck, dkm.LoaiHangMua, dkm.MaHangMua, dkm.TyLeDiemThuong, dkm.SoDiemThuong);
            int count = Common.IntValue(Parameters["p_Valid"].Value);
            return (count > 0 ? true : false);
        }
    }
}
