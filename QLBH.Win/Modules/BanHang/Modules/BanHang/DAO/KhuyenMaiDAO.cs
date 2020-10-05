using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.BanHang.Infors;

namespace QLBanHang.Modules.BanHang.DAO
{
    public class KhuyenMaiDAO : BaseDAO
    {
        private static KhuyenMaiDAO instance;
        private KhuyenMaiDAO()
        {
            CRUDTableName = Declare.TableNamespace.BangGia;
            //UseCaching = true;
        }
        public static KhuyenMaiDAO Instance
        {
            get
            {
                if (instance == null) instance = new KhuyenMaiDAO();
                return instance;
            }
        }
        #region bang gia dieu kien mua load
        public List<BangGiaADDKMuaInfor> GetAllBangGiaADDKMuaInfors(int idChinhSach)
        {
            return GetListCommand<BangGiaADDKMuaInfor>(Declare.StoreProcedureNamespace.spBangGiaChinhSachDKMuaSelect, idChinhSach);
        }
        public List<BangGiaADDKMuaInfor> GetBangGiaADDKMuaInforsById(int idDKMua)
        {
            return GetListCommand<BangGiaADDKMuaInfor>(Declare.StoreProcedureNamespace.spBangGiaChinhSachDKMuaGetById, idDKMua);
        }
        public List<BangGiaADKhuyenMaiInfor> GetAllBangGiaKhuyenMaiInfors(int idDKMua)
        {
            return GetListCommand<BangGiaADKhuyenMaiInfor>(Declare.StoreProcedureNamespace.spBangGiaKhuyenMaiSelect, idDKMua);
        }
        public List<BangGiaADKhuyenMaiInfor> GetAllBangGiaKhuyenMaiADInfors(int idDKMua)
        {
            return GetListCommand<BangGiaADKhuyenMaiInfor>(Declare.StoreProcedureNamespace.spBangGiaKhuyenMaiGetAD, idDKMua);
        }
        public List<BangGiaADKhuyenMaiChiTietInfor> GetAllKhuyenMaiChiTietInfors(int idKhuyenMai)
        {
            return GetListCommand<BangGiaADKhuyenMaiChiTietInfor>(Declare.StoreProcedureNamespace.spBangGiaKMChiTietSelect, idKhuyenMai);
        }

        public List<BangGiaADKhuyenMaiChiTietInfor> GetAllKhuyenMaiChiTietADInfors(int idKhuyenMai, int idKho)
        {
            return GetListCommand<BangGiaADKhuyenMaiChiTietInfor>(Declare.StoreProcedureNamespace.spBangGiaKMChiTietGetAD, idKhuyenMai, idKho);
        }

        public List<BangGiaADKhuyenMaiChiTietInfor> GetAllKhuyenMaiWebCTietInfors(int idKhuyenMai)
        {
            return GetListCommand<BangGiaADKhuyenMaiChiTietInfor>(Declare.StoreProcedureNamespace.spBangGiaKMWebCTietGetADGia, idKhuyenMai);
        }

        public List<BangGiaADKhuyenMaiChiTietInfor> GetAllKhuyenMaiChiTietADInfors(int idKhuyenMai, int idKho, double giaBan)
        {
            return GetListCommand<BangGiaADKhuyenMaiChiTietInfor>(Declare.StoreProcedureNamespace.spBangGiaKMChiTietGetADGia, idKhuyenMai, idKho, giaBan);
        }
        public List<BangGiaADKhuyenMaiChiTietInfor> GetAllKhuyenMaiChiTietADTTInfors(int idKhuyenMai, int idKho, double giaBan)
        {
            return GetListCommand<BangGiaADKhuyenMaiChiTietInfor>(Declare.StoreProcedureNamespace.spBangGiaKMChiTietGetADTTGia, idKhuyenMai, idKho, giaBan);
        }
        public List<BangGiaHangKhuyenMaiInfor> GetHangKhuyenMaiInfors(int idBangGiaChiTiet)
        {
            return GetListCommand<BangGiaHangKhuyenMaiInfor>(Declare.StoreProcedureNamespace.spBangGiaKhuyenMaiLoadSP, idBangGiaChiTiet);
        }
        public List<BangGiaHangKhuyenMaiChiTietInfor> GetHangKhuyenMaiChiTietInfors(int idKhuyenMai, int idKho)
        {
            return GetListCommand<BangGiaHangKhuyenMaiChiTietInfor>(Declare.StoreProcedureNamespace.spBangGiaKMChiTietLoadSP, idKhuyenMai, idKho);
        }
        public List<BangGiaADSPKemInfor> GetAllSanPhamKemInfors(int idDKMua)
        {
            return GetListCommand<BangGiaADSPKemInfor>(Declare.StoreProcedureNamespace.spBangGiaChiTietSPKemSelect, idDKMua);
        }
        public List<BangGiaADSPKemInfor> GetAllSanPhamKemADInfors(int idDKMua, int idKho)
        {
            return GetListCommand<BangGiaADSPKemInfor>(Declare.StoreProcedureNamespace.spBangGiaChiTietSPKemApDung, idDKMua, idKho);
        }
        public List<BangGiaADSPDaMuaInfor> GetAllSanPhamDaMuaInfors(int idDKMua)
        {
            return GetListCommand<BangGiaADSPDaMuaInfor>(Declare.StoreProcedureNamespace.spBangGiaChiTietSPDaMuaSelect, idDKMua);
        }
        public List<BangGiaADSPNoADInfor> GetAllSanPhamNoADInfors(int idDKMua, int isApDung)
        {
            return GetListCommand<BangGiaADSPNoADInfor>(Declare.StoreProcedureNamespace.spBangGiaChiTietSPNoADSelect, idDKMua, isApDung);
        }
        #endregion

        #region bang gia dieu kien mua update
        public void UpdateBangGiaADDKMua(BangGiaADDKMuaInfor bgDKMua)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaChinhSachDKMuaUpdate, bgDKMua.IdDKMua,
                           bgDKMua.IdChinhSach, bgDKMua.MaHangMua, bgDKMua.SoLuongDuocMua, bgDKMua.SoLuongPhaiMua,
                           bgDKMua.TyLePhanBo, bgDKMua.LoaiHangMua, bgDKMua.MaHangSX, bgDKMua.GiaMuaTu,
                           bgDKMua.GiaMuaDen, bgDKMua.KhuyenMai, bgDKMua.KhuyenMaiMa, bgDKMua.SanPhamKem, bgDKMua.SanPhamKemMa, 
                           bgDKMua.SanPhamDaMua, bgDKMua.SanPhamDaMuaMa, bgDKMua.SoLuongToiDaDH, bgDKMua.TyLeChietKhau, bgDKMua.TienChietKhau,
                           bgDKMua.KhuyenMaiWeb, bgDKMua.GiaTriMuaToiThieu, bgDKMua.SanPhamNoAD, bgDKMua.SanPhamNoADMa, bgDKMua.SanPhamYesAD,
                           bgDKMua.SanPhamYesADMa, bgDKMua.InHoaDon, bgDKMua.SoLuongToiDaCK, bgDKMua.TyLeDiemThuong, bgDKMua.SoDiemThuong);
        }
        public int InsertBangGiaADDKMua(BangGiaADDKMuaInfor bgDKMua)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaChinhSachDKMuaInsert, bgDKMua.IdDKMua,
                           bgDKMua.IdChinhSach, bgDKMua.MaHangMua, bgDKMua.SoLuongDuocMua, bgDKMua.SoLuongPhaiMua,
                           bgDKMua.TyLePhanBo, bgDKMua.LoaiHangMua, bgDKMua.MaHangSX, bgDKMua.GiaMuaTu,
                           bgDKMua.GiaMuaDen, bgDKMua.KhuyenMai, bgDKMua.KhuyenMaiMa, bgDKMua.SanPhamKem, bgDKMua.SanPhamKemMa, 
                           bgDKMua.SanPhamDaMua, bgDKMua.SanPhamDaMuaMa, bgDKMua.SoLuongToiDaDH, bgDKMua.TyLeChietKhau, bgDKMua.TienChietKhau,
                           bgDKMua.KhuyenMaiWeb, bgDKMua.GiaTriMuaToiThieu, bgDKMua.SanPhamNoAD, bgDKMua.SanPhamNoADMa, bgDKMua.SanPhamYesAD,
                           bgDKMua.SanPhamYesADMa, bgDKMua.InHoaDon, bgDKMua.SoLuongToiDaCK, bgDKMua.TyLeDiemThuong, bgDKMua.SoDiemThuong);
            return Common.IntValue(Parameters["p_IdDKMua"].Value);
        }
        public void DeleteBangGiaADDKMua(BangGiaADDKMuaInfor bgDKMua)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaChinhSachDKMuaDelete, bgDKMua.IdDKMua);
        }
        #endregion

        #region bang gia khuyen mai update
        public List<BangGiaInfor> ExistKhuyenMai(string soKhuyenMai, int idKhuyenMai)
        {
            return GetListCommand<BangGiaInfor>(Declare.StoreProcedureNamespace.spBangGiaKhuyenMaiExist, soKhuyenMai, idKhuyenMai);
        }

        public void UpdateBGKhuyenMai(BangGiaADKhuyenMaiInfor bgkm)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaKhuyenMaiUpdate, bgkm.IdKhuyenMai,
                           bgkm.IdDKMua, bgkm.SoKhuyenMai, bgkm.GhiChu, bgkm.DoUuTien, bgkm.SuDung);
        }
        public int InsertBGKhuyenMai(BangGiaADKhuyenMaiInfor bgkm)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaKhuyenMaiInsert, bgkm.IdKhuyenMai,
                           bgkm.IdDKMua, bgkm.SoKhuyenMai, bgkm.GhiChu, bgkm.DoUuTien, bgkm.SuDung);
            return Common.IntValue(Parameters["p_IdKhuyenMai"].Value);
        }
        public void DeleteBGKhuyenMai(BangGiaADKhuyenMaiInfor bgkm)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaKhuyenMaiDelete, bgkm.IdKhuyenMai);
        }
        public void DeleteBGKhuyenMaiByDKMua(int idDKMua)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaKhuyenMaiDelByDKM, idDKMua);
        }
        public void DeleteBGKhuyenMaiByChinhSach(int idChinhSach)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaKhuyenMaiDelByCSG, idChinhSach);
        }
        #endregion

        #region bang gia khuyen mai chi tiet update
        public void UpdateKhuyenMaiChiTiet(BangGiaADKhuyenMaiChiTietInfor kmct)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaKMChiTietUpdate, kmct.IdChiTiet, kmct.IdKhuyenMai,
                           kmct.MaHangKM, kmct.SoLuong, kmct.SoTienKM, kmct.GhiChu, kmct.InKemHD, kmct.HetTonDungKM,
                           kmct.TyLeKM, kmct.LoaiHangKM, kmct.MaHangSX, kmct.SuDung, kmct.SoTienYeuCau, kmct.TyLeThanhToan, kmct.DongBoWebSite);
        }
        public int InsertKhuyenMaiChiTiet(BangGiaADKhuyenMaiChiTietInfor kmct)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaKMChiTietInsert, kmct.IdChiTiet, kmct.IdKhuyenMai,
                           kmct.MaHangKM, kmct.SoLuong, kmct.SoTienKM, kmct.GhiChu, kmct.InKemHD, kmct.HetTonDungKM,
                           kmct.TyLeKM, kmct.LoaiHangKM, kmct.MaHangSX, kmct.SuDung, kmct.SoTienYeuCau, kmct.TyLeThanhToan, kmct.DongBoWebSite);
            return Common.IntValue(Parameters["p_IdChiTiet"].Value);
        }
        #endregion

        #region bang gia chinh sach san pham kem update
        public void InsertBGiaADSanPhamKem(BangGiaADSPKemInfor spk)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaChiTietSPKemInsert, spk.IdDKMua, spk.MaHangKem,
                           spk.SoLuong, spk.TyLePhanBo, spk.LoaiHangKem, spk.MaHangSX, spk.TyLeChietKhau,
                           spk.TienChietKhau, spk.GiaMuaTu, spk.GiaMuaDen);
        }
        public void DeleteBGiaChiTietSanPhamKem(int idDKMua)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaChiTietSPKemDelete, idDKMua);
        }
        #endregion

        #region bang gia chinh sach san pham da mua update
        public void InsertBGiaADSanPhamDaMua(BangGiaADSPDaMuaInfor spdm)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaChiTietSPDaMuaInsert, spdm.IdDKMua, spdm.MaHangDaMua, spdm.SoLuong, spdm.LoaiHangDaMua, spdm.MaHangSX);
        }
        public void DeleteBGiaChiTietSanPhamDaMua(int idDKMua)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaChiTietSPDaMuaDelete, idDKMua);
        }
        #endregion

        #region bang gia chinh sach san pham khong ap dung update
        public void InsertBGiaADSanPhamNoAD(BangGiaADSPNoADInfor noad, int isApDung)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaChiTietSPNoADInsert, noad.IdDKMua, noad.MaHangNoAD,
                           noad.LoaiHangNoAD, noad.MaHangSX, isApDung, noad.GiaMuaTu, noad.GiaMuaDen);
        }
        public void DeleteBGiaChiTietSanPhamNoAD(int idDKMua)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangGiaChiTietSPNoADDelete, idDKMua);
        }
        #endregion
    }
}
