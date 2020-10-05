using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.BanHang.Infors;
using QLBH.Common;
using QLBH.Core.Data;

namespace QLBanHang.Modules.BanHang.DAO
{
    public class ImportChungTuDCDAO : BaseDAO
    {
        private static ImportChungTuDCDAO instance;
        private ImportChungTuDCDAO()
        {
            //CRUDTableName = Declare.TableNamespace.tbl_ChungTu_ChiTiet;
            //UseCaching = true;
        }

        public static ImportChungTuDCDAO Instance
        {
            get
            {
                if (instance == null) instance = new ImportChungTuDCDAO();
                return instance;
            }
        }
        #region chungtu
        public ImportCTuDChuyenInfor LoadChungTuBySoChungTuGoc(string soChungTuGoc)
        {
            return GetObjectCommand<ImportCTuDChuyenInfor>(Declare.StoreProcedureNamespace.spImportLoadCTuDCBySoPDC, soChungTuGoc);
        }
        public void DeleteChungTuById(int idChungTu)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spXoaChungTuDieuChuyenByIdCT, idChungTu);
        }
        public void DeleteChungTuDate(DateTime tuNgay, DateTime denNgay)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spXoaChungTuDieuChuyenByDate, clsUtils.DateValue(tuNgay), clsUtils.DateValue(denNgay));
        }
        public void DeleteChungTu(int idChungTu)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spImportChungTuDCDelete, idChungTu);
        }
        public void UpdateChungTu(ImportCTuDChuyenInfor chungTu)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spImportChungTuDCInsert, chungTu.IdChungTu,
                           chungTu.SoChungTu, chungTu.IdKho, chungTu.IdNguoiNhapXuatKho, chungTu.LoaiChungTu,
                           chungTu.NgayLap, chungTu.TrangThai, chungTu.IdKhoDen, chungTu.GhiChu, chungTu.IdNguoiVanChuyen,
                           chungTu.IdNguoiUyNhiem, chungTu.SoHoaDon, chungTu.PhuongTien, chungTu.NguoiTao, chungTu.TenMayTao,
                           chungTu.NguoiSua, chungTu.TenMaySua, clsUtils.DateValue(chungTu.NgayNhapXuatKho), chungTu.SoChungTuGoc);
        }
        public int InsertChungTu(ImportCTuDChuyenInfor chungTu)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spImportChungTuDCInsert, chungTu.IdChungTu,
                           chungTu.SoChungTu, chungTu.IdKho, chungTu.IdNguoiNhapXuatKho, chungTu.LoaiChungTu,
                           chungTu.NgayLap, chungTu.TrangThai, chungTu.IdKhoDen, chungTu.GhiChu, chungTu.IdNguoiVanChuyen,
                           chungTu.IdNguoiUyNhiem, chungTu.SoHoaDon, chungTu.PhuongTien, chungTu.NguoiTao, chungTu.TenMayTao,
                           chungTu.NguoiSua, chungTu.TenMaySua, clsUtils.DateValue(chungTu.NgayNhapXuatKho), chungTu.SoChungTuGoc);
            return Common.IntValue(Parameters["p_IdChungTu"].Value);
        }
        #endregion

        #region chungtu chitiet
        public List<ImportCTuDChuyenCTietInfor> GetListChiTietChungTuBySoChungTuGoc(string soChungTuGoc)
        {
            return
                GetListCommand<ImportCTuDChuyenCTietInfor>(
                    Declare.StoreProcedureNamespace.spImportLoadCTuDCCTietBySoCTuGoc, soChungTuGoc);
        }
        public List<ImportCTuDChuyenCTietInfor> GetListChiTietChungTuByIdChungTu(int idChungTu)
        {
            return
                GetListCommand<ImportCTuDChuyenCTietInfor>(
                    Declare.StoreProcedureNamespace.spImportChungTuCTietDCGetByCT, idChungTu);
        }

        public void DeleteChiTietChungTu(ImportCTuDChuyenCTietInfor chiTietChungTu)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spImportChungTuCTietDCDelete, chiTietChungTu.IdChungTuChiTiet);
        }
        public void DeleteChiTietChungTu(int idChiTietChungTu)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spImportChungTuCTietDCDelete, idChiTietChungTu);
        }
        public int InsertChiTietChungTu(ImportCTuDChuyenCTietInfor chiTietChungTu)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spImportChungTuCTietDCInsert, chiTietChungTu.IdChungTuChiTiet,
                           chiTietChungTu.IdChungTu, chiTietChungTu.IdSanPham, chiTietChungTu.SoLuong);
            return Convert.ToInt32(Parameters["p_IdChiTiet"].Value.ToString());
        }
        public void UpdateChiTietChungTu(ImportCTuDChuyenCTietInfor chiTietChungTu)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spImportChungTuCTietDCUpdate, chiTietChungTu.IdChungTuChiTiet,
                           chiTietChungTu.IdChungTu, chiTietChungTu.IdSanPham, chiTietChungTu.SoLuong);
        }
        #endregion

        #region chungtu chitiet hang hoa
        public List<ImportCTuDChuyenCTietHHoaInfor> GetListChiTietHangHoaBySoChungTuGoc(string soChungTuGoc, int idKho)
        {
            return GetListCommand<ImportCTuDChuyenCTietHHoaInfor>(Declare.StoreProcedureNamespace.spImportLoadCTuDCCTietHHoaBySoCTuGoc, soChungTuGoc, idKho);
        }
        public List<ImportCTuDChuyenCTietHHoaInfor> GetListChiTietHangHoaByIdChungTu(int idChungTu)
        {
            return GetListCommand<ImportCTuDChuyenCTietHHoaInfor>(Declare.StoreProcedureNamespace.spImportChungTuCTietHHoaDCGetByCT, idChungTu);
        }

        public void DeleteChiTietHangHoa(ImportCTuDChuyenCTietHHoaInfor chiTietHangHoa)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spImportChungTuCTietHHoaDCDelete, chiTietHangHoa.IdChungTuChiTiet, chiTietHangHoa.IdChiTietHangHoa);
        }

        public void InsertChiTietHangHoa(ImportCTuDChuyenCTietHHoaInfor chiTietHangHoa)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spImportChungTuCTietHHoaDCInsert, chiTietHangHoa.IdChungTuChiTiet,
                           chiTietHangHoa.IdChiTietHangHoa, chiTietHangHoa.SoLuong);
        }

        public void UpdateChiTietHangHoa(ImportCTuDChuyenCTietHHoaInfor chiTietHangHoa)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spImportChungTuCTietHHoaDCUpdate, chiTietHangHoa.IdChungTuChiTiet,
                           chiTietHangHoa.IdChiTietHangHoa, chiTietHangHoa.SoLuong);
        }
        #endregion
    }
}
