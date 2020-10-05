using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.BanHang.Infors;
using QLBH.Common;
using QLBH.Core.Data;

namespace QLBanHang.Modules.BanHang.DAO
{
    public class ImportChungTuDAO : BaseDAO
    {
        private static ImportChungTuDAO instance;
        private ImportChungTuDAO()
        {
            //CRUDTableName = Declare.TableNamespace.tbl_ChungTu_ChiTiet;
            //UseCaching = true;
        }

        public static ImportChungTuDAO Instance
        {
            get
            {
                if (instance == null) instance = new ImportChungTuDAO();
                return instance;
            }
        }
        #region chungtu
        public ChungTuBanHangInfor LoadChungTuBySoChungTuGoc(string soChungTuGoc)
        {
            return GetObjectCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spImportLoadCTuBySoCTuGoc, soChungTuGoc);
        }
        public ChungTuBanHangInfor LoadChungTuBanBySoChungTuGoc(string soChungTuGoc)
        {
            return GetObjectCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spImportLoadCTuImportBySoCTuGoc, soChungTuGoc);
        }
        public void DeleteChungTuById(int idChungTu)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spXoaChungTuBanHangByIdCT, idChungTu);
        }
        public void DeleteChungTuDate(DateTime tuNgay, DateTime denNgay)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spXoaChungTuBanHangByDate, clsUtils.DateValue(tuNgay), clsUtils.DateValue(denNgay));
        }
        public void DeleteChungTu(int idChungTu)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangDelete, idChungTu);
        }
        public void UpdateChungTu(ChungTuBanHangInfor chungTu)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangUpdate, chungTu.IdChungTu,
                           chungTu.LoaiChungTu, chungTu.QuyenSo,
                           chungTu.SoSeri, chungTu.KyHieu, chungTu.SoChungTu, chungTu.NgayLap, chungTu.IdKho,
                           chungTu.IdNhanVien,
                           chungTu.IdDoiTuong, chungTu.HoTen,
                           chungTu.DoTuoi, chungTu.GioiTinh, chungTu.DiaChi, chungTu.DienThoai, chungTu.MaSoThue,
                           chungTu.SoTaiKhoan, chungTu.NganHang,
                           chungTu.OrderType, chungTu.BillTo, chungTu.ShipTo, chungTu.TongTienHang,
                           chungTu.TongTienChietKhau, chungTu.TongTienSauChietKhau,
                           chungTu.TongTienVAT, chungTu.TongTienThanhToan, chungTu.IdTienTe, chungTu.TyGia,
                           chungTu.TienThanhToanThuc, chungTu.TienConNo,
                           chungTu.TongTienChu, chungTu.HinhThucTra, chungTu.GhiChu, chungTu.NguoiSua, chungTu.TenMaySua,
                           chungTu.IdBangKeThue, chungTu.IdLoaiHdBanHang,
                           chungTu.IdDuAn, chungTu.SoChungTuGoc, chungTu.IdThuNgan, chungTu.SoCMND, chungTu.TrangThai,
                           chungTu.GiaoNhan, chungTu.IdTruongCa,
                           chungTu.LoaiTheKhachHang, chungTu.SoTienTichLuy, chungTu.CaBanHang,
                           chungTu.SoPhieuXuat, chungTu.NgayXuatHang, chungTu.NgayHenGiaoHang, chungTu.IdKhachLe,
                           chungTu.Draft,
                           chungTu.IdTinhHD, chungTu.IdHuyenHD, chungTu.DiaChiHD, chungTu.DiaChiHoaDon,
                           chungTu.IdTinhGH, chungTu.IdHuyenGH, chungTu.DiaChiGH, chungTu.DiaChiGiaoHang,
                           chungTu.Email, chungTu.Website, chungTu.SoHDDaMua, chungTu.IdNgheNghiep,
                           chungTu.IdLyDoGiaoDich, chungTu.SoPhieuDC, chungTu.CongTy, chungTu.IdTrungTam, chungTu.IdTrungTamHachToan);
        }
        public int InsertChungTu(ChungTuBanHangInfor chungTu)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangInsert, chungTu.IdChungTu,
                          chungTu.LoaiChungTu, chungTu.QuyenSo,
                          chungTu.SoSeri, chungTu.KyHieu, chungTu.SoChungTu, chungTu.NgayLap, chungTu.IdKho,
                          chungTu.IdNhanVien,
                          chungTu.IdDoiTuong, chungTu.HoTen,
                          chungTu.DoTuoi, chungTu.GioiTinh, chungTu.DiaChi, chungTu.DienThoai, chungTu.MaSoThue,
                          chungTu.SoTaiKhoan, chungTu.NganHang,
                          chungTu.OrderType, chungTu.BillTo, chungTu.ShipTo, chungTu.TongTienHang,
                          chungTu.TongTienChietKhau, chungTu.TongTienSauChietKhau,
                          chungTu.TongTienVAT, chungTu.TongTienThanhToan, chungTu.IdTienTe, chungTu.TyGia,
                          chungTu.TienThanhToanThuc, chungTu.TienConNo,
                          chungTu.TongTienChu, chungTu.HinhThucTra, chungTu.GhiChu, chungTu.NguoiTao, chungTu.TenMayTao,
                          chungTu.NguoiSua, chungTu.TenMaySua,
                          chungTu.IdBangKeThue, chungTu.IdLoaiHdBanHang,
                          chungTu.IdDuAn, chungTu.SoChungTuGoc, chungTu.IdThuNgan, chungTu.SoCMND, chungTu.TrangThai,
                          chungTu.GiaoNhan, chungTu.IdTruongCa,
                          chungTu.LoaiTheKhachHang, chungTu.SoTienTichLuy, chungTu.CaBanHang,
                          chungTu.SoPhieuXuat, chungTu.NgayXuatHang, chungTu.NgayHenGiaoHang, chungTu.IdKhachLe,
                          chungTu.Draft,
                          chungTu.IdTinhHD, chungTu.IdHuyenHD, chungTu.DiaChiHD, chungTu.DiaChiHoaDon,
                          chungTu.IdTinhGH, chungTu.IdHuyenGH, chungTu.DiaChiGH, chungTu.DiaChiGiaoHang,
                          chungTu.Email, chungTu.Website, chungTu.SoHDDaMua, chungTu.IdNgheNghiep,
                          chungTu.IdLyDoGiaoDich, chungTu.SoPhieuDC, chungTu.CongTy, chungTu.IdTrungTam, chungTu.IdTrungTamHachToan);
            return Common.IntValue(Parameters["p_IdChungTu"].Value);
        }
        #endregion

        #region chungtu chitiet
        public List<ChungTuBanHangChiTietInfor> GetListChiTietChungTuBySoChungTuGoc(string soChungTuGoc)
        {
            return
                GetListCommand<ChungTuBanHangChiTietInfor>(
                    Declare.StoreProcedureNamespace.spImportLoadCTuCTietBySoCTuGoc, soChungTuGoc);
        }
        public List<ChungTuBanHangChiTietInfor> GetListChiTietChungTuByIdChungTu(int idChungTu)
        {
            return
                GetListCommand<ChungTuBanHangChiTietInfor>(
                    Declare.StoreProcedureNamespace.spChungTuBanHangCTietGetByCT, idChungTu);
        }
        public int InsertChiTietChungTu(ChungTuBanHangChiTietInfor chiTietChungTu)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangCTietInsert, chiTietChungTu.IdChungTuChiTiet,
                           chiTietChungTu.IdChungTu, chiTietChungTu.IdSanPham, chiTietChungTu.SoLuong, chiTietChungTu.DonGia,
                           chiTietChungTu.TyleChietKhau, chiTietChungTu.TienChietKhau, chiTietChungTu.ThanhTien,
                           chiTietChungTu.TienSauChietKhau, chiTietChungTu.TyleVAT, chiTietChungTu.TienVAT,
                           chiTietChungTu.TyleThuong, chiTietChungTu.ThuongNong, chiTietChungTu.GiaTheoBangGia,
                           chiTietChungTu.IdSanPhamBan, chiTietChungTu.NoKhuyenMai, chiTietChungTu.GiaNiemYet, chiTietChungTu.GiaWebSite,
                           chiTietChungTu.GhiChu, chiTietChungTu.CungDongDonHangChinh, chiTietChungTu.LoaiHangKem, chiTietChungTu.TyLePhanBo, chiTietChungTu.TyLeThanhToan, chiTietChungTu.ListIdChinhSach);
            return Convert.ToInt32(Parameters["p_IdChiTiet"].Value.ToString());
        }

        public void DeleteChiTietChungTu(ChungTuBanHangChiTietInfor chiTietChungTu)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangCTietDelete, chiTietChungTu.IdChungTuChiTiet);
        }
        public void DeleteChiTietChungTu(int idChiTietChungTu)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangCTietDelete, idChiTietChungTu);
        }
        public void UpdateChiTietChungTu(ChungTuBanHangChiTietInfor chiTietChungTu)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangCTietUpdate, chiTietChungTu.IdChungTuChiTiet,
                           chiTietChungTu.IdChungTu, chiTietChungTu.IdSanPham, chiTietChungTu.SoLuong, chiTietChungTu.DonGia,
                           chiTietChungTu.TyleChietKhau, chiTietChungTu.TienChietKhau, chiTietChungTu.ThanhTien,
                           chiTietChungTu.TienSauChietKhau, chiTietChungTu.TyleVAT, chiTietChungTu.TienVAT,
                           chiTietChungTu.TyleThuong, chiTietChungTu.ThuongNong, chiTietChungTu.GiaTheoBangGia,
                           chiTietChungTu.IdSanPhamBan, chiTietChungTu.NoKhuyenMai, chiTietChungTu.GiaNiemYet, chiTietChungTu.GiaWebSite,
                           chiTietChungTu.GhiChu, chiTietChungTu.CungDongDonHangChinh, chiTietChungTu.LoaiHangKem, chiTietChungTu.TyLePhanBo, chiTietChungTu.TyLeThanhToan, chiTietChungTu.ListIdChinhSach);
        }
        #endregion

        #region chungtu chitiet hang hoa
        public List<ChungTuBanHangChiTietHangHoaInfor> GetListChiTietHangHoaBySoChungTuGoc(string soChungTuGoc, int idKho)
        {
            return GetListCommand<ChungTuBanHangChiTietHangHoaInfor>(Declare.StoreProcedureNamespace.spImportLoadCTuCTietHHoaBySoCTuGoc, soChungTuGoc, idKho);
        }
        public List<ChungTuBanHangChiTietHangHoaInfor> GetListChiTietHangHoaByIdChungTu(int idChungTu)
        {
            return GetListCommand<ChungTuBanHangChiTietHangHoaInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangCTietHHoaGetByCTu, idChungTu);
        }

        public void DeleteChiTietHangHoa(ChungTuBanHangChiTietHangHoaInfor chiTietHangHoa)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangCTietHHoaDelete, chiTietHangHoa.IdChungTuChiTiet, chiTietHangHoa.IdChiTietHangHoa);
        }

        public void InsertChiTietHangHoa(ChungTuBanHangChiTietHangHoaInfor chiTietHangHoa)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangCTietHHoaInsert, chiTietHangHoa.IdChungTuChiTiet,
                           chiTietHangHoa.IdChiTietHangHoa, chiTietHangHoa.SoLuong, chiTietHangHoa.TienChietKhau, chiTietHangHoa.TienVAT,
                           chiTietHangHoa.ThuongNong, chiTietHangHoa.GhiChu);
        }

        public void UpdateChiTietHangHoa(ChungTuBanHangChiTietHangHoaInfor chiTietHangHoa)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangCTietHHoaUpdate, chiTietHangHoa.IdChungTuChiTiet,
                           chiTietHangHoa.IdChiTietHangHoa, chiTietHangHoa.SoLuong, chiTietHangHoa.TienChietKhau, chiTietHangHoa.TienVAT,
                           chiTietHangHoa.ThuongNong, chiTietHangHoa.GhiChu);
        }
        #endregion

        #region chungtu thanh toan
        public List<ChungTuThanhToanInfor> GetListChungTuThanhToanBySoChungTuGoc(string soChungTuGoc)
        {
            return GetListCommand<ChungTuThanhToanInfor>(Declare.StoreProcedureNamespace.spImportLoadCTuTToanBySoCTuGoc, soChungTuGoc);
        }
        public List<ChungTuThanhToanInfor> GetListChungTuThanhToanThemBySoChungTuGoc(string soChungTuGoc, int idChungTu)
        {
            return GetListCommand<ChungTuThanhToanInfor>(Declare.StoreProcedureNamespace.spImportLoadCTuTToanAddLstBySoCTuGoc, soChungTuGoc, idChungTu);
        }

        public ChungTuThanhToanInfor GetChungTuThanhToanThemBySoChungTuGoc(string soChungTuGoc, int idChungTu, string soPhieuThu)
        {
            return GetObjectCommand<ChungTuThanhToanInfor>(Declare.StoreProcedureNamespace.spImportLoadCTuTToanAddBySoCTuGoc, soChungTuGoc, idChungTu, soPhieuThu);
        }

        public void DeleteChungTuThanhToanByIdChungTu(int idChungTu)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuThanhToanDeleteAll, idChungTu);
        }

        public void InsertChungTuThanhToan(ChungTuThanhToanInfor chungTuThanhToan)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuThanhToanInsert, chungTuThanhToan.IdThanhToan,
                            chungTuThanhToan.IdChungTu, chungTuThanhToan.SoPhieu, chungTuThanhToan.NgayLap,
                            chungTuThanhToan.IdThuNgan, chungTuThanhToan.IdHinhThucThanhToan, chungTuThanhToan.HoTen,
                            chungTuThanhToan.DiaChi, chungTuThanhToan.DienThoai, chungTuThanhToan.SoTaiKhoan,
                            chungTuThanhToan.IdNganHangThanhToan, chungTuThanhToan.MaThe, chungTuThanhToan.DuoiThe,
                            chungTuThanhToan.IdNganHangPhatHanhThe, chungTuThanhToan.NoiDungThanhToan, chungTuThanhToan.SoTienThanhToan,
                            chungTuThanhToan.IdTienTe, chungTuThanhToan.TyGia, chungTuThanhToan.SoTienChu, chungTuThanhToan.IdThoiHanThanhToan,
                            chungTuThanhToan.NguoiTao, chungTuThanhToan.TenMayTao, chungTuThanhToan.NguoiSua, chungTuThanhToan.TenMaySua,
                            chungTuThanhToan.LoaiPhieu, chungTuThanhToan.LoaiGiaoDich, chungTuThanhToan.TaiKhoanQuy, chungTuThanhToan.IdTrungTamThu, chungTuThanhToan.TenThuNgan, chungTuThanhToan.ChuTaiKhoan);
        }
        #endregion

        #region bang gia
        public void ImportBangGiaChiTiet(int idTrungTam, string maSanPham)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spImportBangGiaBanHangChiTiet, idTrungTam, maSanPham);
        }
        #endregion
    }
}
