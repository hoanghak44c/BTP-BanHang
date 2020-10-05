using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;
using QLBH.Core.Data;
using QLBH.Core.Form;
using ItemTonKhoInfor = QLBanHang.Modules.BanHang.Infors.ItemTonKhoInfor;

namespace QLBanHang.Modules.BanHang.DAO
{
    public class BanHangDAO : BaseDAO
    {
        private static BanHangDAO instance;
        private BanHangDAO()
        {
            //CRUDTableName = Declare.TableNamespace.tbl_ChungTu_ChiTiet;
            //UseCaching = true;
        }

        public static BanHangDAO Instance
        {
            get
            {
                if (instance == null) instance = new BanHangDAO();
                return instance;
            }
        }
        #region chungtu
        public List<ChungTuBanHangInfor> LoadAllChungTu(int loaiChungTu)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangGetAll, loaiChungTu);
        }

        public List<ChungTuBanHangInfor> LoadAllPhieuXuat(int idChungTu)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangGetAllPX, idChungTu);
        }

        public List<ChungTuBanHangInfor> LoadAllChungTuByLoaiCT(int loaiChungTu, string userName, int idKho)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangGetByLoaiCT, loaiChungTu, userName, idKho);
        }

        public List<ChungTuBanHangInfor> LoadAllChungTuDatHangOnline(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangGetDHOLPg, userName,
                                                       idTrungTam, idKho, idDoiTuong, clsUtils.DateValue(tuNgay),
                                                       clsUtils.DateValue(denNgay), loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien);
        }
        public List<ChungTuBanHangInfor> LoadAllChungTuXacNhanDHOL(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangGetXNDHOLPg, userName,
                                                       idTrungTam, idKho, idDoiTuong, clsUtils.DateValue(tuNgay),
                                                       clsUtils.DateValue(denNgay), loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien);
        }
        public List<ChungTuBanHangInfor> LoadAllChungTuDatTruocHangMua(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangGetDTHMPg, userName,
                                                       idTrungTam, idKho, idDoiTuong, clsUtils.DateValue(tuNgay),
                                                       clsUtils.DateValue(denNgay), loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien);
        }
        public List<ChungTuBanHangInfor> LoadAllChungTuDatHangTaiShop(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangGetDHTSPg, userName,
                                                       idTrungTam, idKho, idDoiTuong, clsUtils.DateValue(tuNgay),
                                                       clsUtils.DateValue(denNgay), loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien);
        }
        public List<ChungTuBanHangInfor> LoadAllChungTuBuXuatBuKhuyenMai(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangGetXBKMPg, userName,
                                                       idTrungTam, idKho, idDoiTuong, clsUtils.DateValue(tuNgay),
                                                       clsUtils.DateValue(denNgay), loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien);
        }

        public List<ChungTuBanHangInfor> LoadAllChungTuCanThuTien(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangGetTToanPg, userName,
                                                       idTrungTam, idKho, idDoiTuong, clsUtils.DateValue(tuNgay),
                                                       clsUtils.DateValue(denNgay), loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien);
        }
        public List<ChungTuBanHangInfor> LoadAllChungTuPhanCongGiaoNhan(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien, int idHuyen)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangGetPCGNPg, userName,
                                                       idTrungTam, idKho, idDoiTuong, clsUtils.DateValue(tuNgay),
                                                       clsUtils.DateValue(denNgay), loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien, idHuyen);
        }
        public List<ChungTuBanHangInfor> LoadAllChungTuPhanDonGiaoNhan(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien, int idHuyen)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangGetPDGNPg, userName,
                                                       idTrungTam, idKho, idDoiTuong, clsUtils.DateValue(tuNgay),
                                                       clsUtils.DateValue(denNgay), loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien, idHuyen);
        }
        public List<ChungTuBanHangInfor> LoadAllXacNhanPhanDonGiaoNhan(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien, int idHuyen)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangGetXNGNPg, userName,
                                                       idTrungTam, idKho, idDoiTuong, clsUtils.DateValue(tuNgay),
                                                       clsUtils.DateValue(denNgay), loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien, idHuyen);
        }
        //public List<ChungTuBanHangInfor> LoadAllChungTuTTPhanCongGiaoNhan(string userName, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu)
        //{
        //    return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangGetTTPCGN, userName,
        //                                               idKho, idDoiTuong, clsUtils.DateValue(tuNgay),
        //                                               clsUtils.DateValue(denNgay), loaiDH, trangThaiDH, draft, ghiChu);
        //}
        public List<ChungTuBanHangInfor> LoadAllChungTuTTPhanCongGiaoNhan(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangGetTTPCGNPg, userName,
                                                       idTrungTam, idKho, idDoiTuong, clsUtils.DateValue(tuNgay),
                                                       clsUtils.DateValue(denNgay), loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien);
        }
        public List<ChungTuBanHangInfor> LoadAllChungTuTTPhanCongGiaoNhanS(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangGetTTPCGNPgS, userName,
                                                       idTrungTam, idKho, idDoiTuong, clsUtils.DateValue(tuNgay),
                                                       clsUtils.DateValue(denNgay), loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien);
        }
        public List<ChungTuBanHangInfor> LoadAllChungTuXuatKhoBan(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangGetXuatKhoBanPg, userName,
                                                       idTrungTam, idKho, idDoiTuong, clsUtils.DateValue(tuNgay),
                                                       clsUtils.DateValue(denNgay), loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien);
        }
        public List<ChungTuBanHangInfor> LoadAllChungTuTraLaiHangBan(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangGetHDTLPg, userName,
                                                       idTrungTam, idKho, idDoiTuong, clsUtils.DateValue(tuNgay),
                                                       clsUtils.DateValue(denNgay), loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien);
        }

        public ChungTuBanHangInfor LoadChungTuById(int idChungTu)
        {
            return GetObjectCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangGetById, idChungTu);
        }
        public List<ChungTuBanHangInfor> LoadAllPhieuXuatByIdCTuGoc(int idChungTu)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangGetListPXById, idChungTu);
        }
        public ChungTuBanHangInfor LoadChungTuBySoChungTu(string soChungTu, int idLoaiChungTu)
        {
            return GetObjectCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangGetBySoCT, soChungTu, idLoaiChungTu);
        }
        public ChungTuBanHangInfor LoadChungTuBySoChungTu(string soChungTu, string soHoaDon)
        {
            return GetObjectCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangGetBySoCTHD, soChungTu, soHoaDon);
        }
        public ChungTuBanHangInfor LoadChungTuBySoChTu(string soChungTu)
        {
            return GetObjectCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangGetBySoCTu, soChungTu);
        }

        public void DeleteChungTu(int idChungTu)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangDelete, idChungTu);
        }

        public void DeleteAllChungTu(int idChungTu)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangDeleteAll, idChungTu);
        }

        public void UpdateDaTichDiem(int idChungTu, int daTichDiem, int idTheTVien, string tenLoaiThe, int soDiemTichLuy)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangUpdateTichDiem, idChungTu, daTichDiem, idTheTVien, tenLoaiThe, soDiemTichLuy);
        }

        public void UpdateCongNoKhachHang(int idKhachLe, int idKhachHang, double tongTien, double tienNo, double tongTienOld, double tienNoOld, int loaiChungTu)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangUpdateCongNo, idKhachLe, idKhachHang, tongTien, tienNo, tongTienOld, tienNoOld, loaiChungTu);
        }

        public void KhoaChungTu(int idChungTu, int trangThai)
        {
            NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangKhoaDonHang, idChungTu, trangThai, nguoiDung.TenDangNhap, Declare.TenMay);
        }
        public void UpdateTrangThaiChungTu(int idChungTu, int trangThai)
        {
            NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangUpdateTThai, idChungTu, trangThai, nguoiDung.TenDangNhap, Declare.TenMay);
        }
        public void UpdateTrangThaiChungTu(string soChungTu, int trangThai)
        {
            NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangUpdateTThaiSCT, soChungTu, trangThai, nguoiDung.TenDangNhap, Declare.TenMay);
        }
        /// <summary>
        /// hah bo sung 
        /// </summary>
        /// <param name="idChungTu"></param>
        /// <returns></returns>
        public bool CheckValid_TrangThai_Draft(int idChungTu)
        {
            if (idChungTu == 0) return true;
            string sql = String.Format("Select IdChungTu From tbl_ChungTu Where idchungtu = {0} and nvl(draft, 0) = 1", idChungTu);
            DataTable dt = DBTools.getData("tmp", sql).Tables["tmp"];
            if (dt != null && dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public bool CheckValid_TrangThai_ChungTu(int idChungTu, string trangThai)
        {
            if (idChungTu == 0) return true;
            string sql = String.Format("Select IdChungTu From tbl_ChungTu Where idchungtu = {0} and trangthai in ({1})", idChungTu, trangThai);
            DataTable dt = DBTools.getData("tmp", sql).Tables["tmp"];
            if (dt != null && dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public bool CheckValid_ChungTu_TraLai(int idChungTu)
        {
            if (idChungTu == 0) return true;
            string sql = String.Format("Select IdChungTu From tbl_ChungTu Where loaichungtu in (33,50) and sochungtugoc in (select sochungtu from tbl_chungtu where idchungtu = {0} and loaichungtu in (8,9,10,35,36))", idChungTu);
            DataTable dt = DBTools.getData("tmp", sql).Tables["tmp"];
            if (dt != null && dt.Rows.Count > 0)//neu co don hang tra lai
            {
                return false;
            }
            return true;
        }

        public void UpdateChungTu(ChungTuBanHangInfor chungTu)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangUpdateThe, chungTu.IdChungTu,
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
                           chungTu.IdLyDoGiaoDich, chungTu.SoPhieuDC, chungTu.CongTy, chungTu.IdTrungTam,
                           chungTu.IdTrungTamHachToan, chungTu.TuHuy, chungTu.IdNhanVienGiao, chungTu.NgayHoaDon,
                           chungTu.DaTichDiem, chungTu.NguoiXacNhan, chungTu.IdTheThanhVien, chungTu.DoUuTien,
                           chungTu.TheThanhVien, chungTu.SoDiemBiTru, chungTu.SoTienQuyDoi, chungTu.SoDiemTichLuy);
        }

        public int InsertChungTu(ChungTuBanHangInfor chungTu)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangInsertThe, chungTu.IdChungTu,
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
                           chungTu.IdLyDoGiaoDich, chungTu.SoPhieuDC, chungTu.CongTy, chungTu.IdTrungTam,
                           chungTu.IdTrungTamHachToan, chungTu.TuHuy, chungTu.IdNhanVienGiao, chungTu.NgayHoaDon,
                           chungTu.DaTichDiem, chungTu.NguoiXacNhan, chungTu.IdTheThanhVien, chungTu.DoUuTien,
                           chungTu.TheThanhVien, chungTu.SoDiemBiTru, chungTu.SoTienQuyDoi, chungTu.SoDiemTichLuy);

            return Common.IntValue(Parameters["p_IdChungTu"].Value);
        }

        public void CapNhatNgayInHoaDon(int idChungTu, string nguoiSua, string maySua, DateTime ngayHoaDon)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangUpdateNgayHoaDon, idChungTu, nguoiSua, maySua, ngayHoaDon);
        }

        public List<ChungTuBanHangChiTietInfor> SearchNoKhuyenMai(string soChungTu, string maSanPham, int idSanPhamBan, int soLuong)
        {
            return GetListCommand<ChungTuBanHangChiTietInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangCTietKMSearch,
                                                       soChungTu, maSanPham, idSanPhamBan, soLuong);
        }

        public bool ExistNoKhuyenMai(string soChungTu, string maSanPham, int idSanPhamBan, int soLuong)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangCTietKMExist,
                                                       soChungTu, maSanPham, idSanPhamBan, soLuong);

            return Convert.ToInt32(Parameters["p_Count"].Value.ToString()) > 0;
        }
        
        public List<ChungTuBanHangInfor> SearchChungTu(int loaiChungTu, string soChungTu, int loaiTruong, int idChungTu)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangSearch,
                                                       loaiChungTu, soChungTu, loaiTruong, idChungTu);
        }
        public bool ExistChungTu(int loaiChungTu, string soChungTu, int loaiTruong, int idChungTu)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangExists,
                          loaiChungTu, soChungTu, loaiTruong, idChungTu);

            return Convert.ToInt32(Parameters["p_Count"].Value.ToString()) > 0;
        }

        public List<ChungTuBanHangInfor> SearchChungTuByDate(int loaiChungTu, string soChungTu, int loaiTruong, int idChungTu, DateTime tuNgay, DateTime denNgay)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangSearchByDate,
                                                       loaiChungTu, soChungTu, loaiTruong, idChungTu, tuNgay, denNgay);
        }

        public bool ExistsChungTuByDate(int loaiChungTu, string soChungTu, int loaiTruong, int idChungTu, DateTime tuNgay, DateTime denNgay)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangExistsByDate,
                          loaiChungTu, soChungTu, loaiTruong, idChungTu, tuNgay, denNgay);

            return Convert.ToInt32(Parameters["p_Count"].Value.ToString()) > 0;
        }

        public List<ChungTuBanHangInfor> SearchChungTuDaMua(int loaiChungTu, string soChungTu, string soCMND, string soDienThoai, double giatriHD, int ngayTruocDo, int idChungTu)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangSearchDaMua,
                                                       loaiChungTu, soChungTu, soCMND, soDienThoai, giatriHD, ngayTruocDo, idChungTu);
        }

        public bool ExistChungTuDaMua(int loaiChungTu, string soChungTu, string soCMND, string soDienThoai, double giatriHD, int ngayTruocDo, int idChungTu)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangExistDaMua,
                           loaiChungTu, soChungTu, soCMND, soDienThoai, giatriHD, ngayTruocDo, idChungTu);

            return Convert.ToInt32(Parameters["p_Count"].Value.ToString()) > 0;
        }
        
        public List<ChungTuThanhToanInfor> TimKiemPhieuThu(TimKiemPhieuThuFilterInfor filter)
        {
            return GetListCommand<ChungTuThanhToanInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemPT,
                                                       filter.SoPhieu, filter.LoaiDonHang, filter.IdTrungTam, filter.NhanVien, filter.ThuNgan,
                                                       filter.KhachHang, clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
                                                       filter.DoanhThuTu, filter.DoanhThuDen, filter.SoTienThuTu, filter.SoTienThuDen,
                                                       filter.IdHinhThucThanhToan, filter.IdThoiHanThanhToan, filter.IdNganHang, filter.GhiChu, filter.UserName);
        }
        //public List<ChungTuThanhToanInfor> TimKiemPThuCTietPg(TimKiemPhieuThuFilterInfor filter)
        //{
        //    return GetListCommand<ChungTuThanhToanInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemPTCTietPg,
        //                                               filter.SoPhieu, filter.LoaiDonHang, filter.IdTrungTam, filter.NhanVien, filter.ThuNgan,
        //                                               filter.KhachHang, clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
        //                                               filter.DoanhThuTu, filter.DoanhThuDen, filter.SoTienThuTu, filter.SoTienThuDen, filter.IdHinhThucThanhToan, filter.IdThoiHanThanhToan, 
        //                                               filter.IdNganHang, filter.GhiChu, filter.UserName, filter.LoaiPhieu, filter.TaiKhoanQuy, filter.SoBatDau, filter.SoKetThuc, filter.IdNhanVien);
        //}

        public List<ChungTuThanhToanBCInfor> TimKiemDoanhSoTongHopPg(TimKiemChungTuFilterInfor filter)
        {
            return
                GetListCommand<ChungTuThanhToanBCInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTKiemDoanhSoTongHopPg,
                                                        filter.LoaiDonHang, filter.IdTrungTam, filter.IdKho, 
                                                        clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),filter.MaHang,
                                                        filter.UserName, filter.IdNhanVien, filter.IdNhomNguoiDung);
        }

        public List<ChungTuBanHangBCTheoGioInfor> TimKiemBanHangKhungGioNganhPg(TimKiemChungTuFilterInfor filter)
        {
            return
                GetListCommand<ChungTuBanHangBCTheoGioInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangKhungGioTheoNganhPg,
                                                        filter.LoaiDonHang, filter.IdTrungTam, filter.KhungGio,
                                                        clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay), filter.MaHang,
                                                        filter.UserName, filter.IdNhanVien, filter.IdNhomNguoiDung);
        }

        public List<ChungTuBanHangBCTheoGioInfor> TimKiemBanHangKhungGioTuanPg(TimKiemChungTuFilterInfor filter)
        {
            return
                GetListCommand<ChungTuBanHangBCTheoGioInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangKhungGioTheoTuanPg,
                                                        filter.LoaiDonHang, filter.IdTrungTam, filter.KhungGio, filter.Thu,
                                                        clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay), filter.MaHang,
                                                        filter.UserName, filter.IdNhanVien, filter.IdNhomNguoiDung);
        }

        public List<ChungTuThanhToanBCInfor> TimKiemDoanhSoCTietPg(TimKiemChungTuFilterInfor filter)
        {
            return
                GetListCommand<ChungTuThanhToanBCInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTKiemDoanhSoPg,
                                                        filter.SoPhieu, filter.LoaiDonHang, filter.TrangThai,filter.IdTrungTam,
                                                        filter.IdKho, filter.SanPham, filter.MaHang, filter.LoaiMaHang, filter.NhanVien,
                                                        filter.KhachHang, clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
                                                        filter.UserName, filter.IdNhanVien, filter.SoBatDau, filter.SoKetThuc, filter.IdNhomNguoiDung);
        }

        //public void TimKiemDoanhSoCTietPg(TimKiemChungTuFilterInfor filter, DataTable dataTable)
        //{
        //    FillToDataTable(dataTable, Declare.StoreProcedureNamespace.spChungTuBanHangTKiemDoanhSoPg,
        //                                                filter.SoPhieu, filter.LoaiDonHang, filter.TrangThai, filter.IdTrungTam,
        //                                                filter.IdKho, filter.SanPham, filter.MaHang, filter.LoaiMaHang, filter.NhanVien,
        //                                                filter.KhachHang, clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
        //                                                filter.UserName, filter.IdNhanVien, filter.SoBatDau, filter.SoKetThuc, filter.IdNhomNguoiDung);
        //}
        
        public List<ChungTuBanHangInfor> TimKiemChungTu(TimKiemChungTuFilterInfor filter)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemCT,
                                                       filter.SoPhieu, filter.LoaiDonHang, filter.GiaoNhan, filter.TrangThai, filter.IdTrungTam,
                                                        filter.IdKho, filter.SanPham, filter.MaHang, filter.LoaiMaHang, filter.NhanVien, clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
                                                        filter.IdDoiTuong, filter.KhachHang, filter.DiaChi, filter.CMND, filter.DienThoai, filter.GhiChu, filter.UserName, filter.Draft, filter.DoanhThuTu,
                                                        filter.DoanhThuDen, filter.TinhTrangThanhToan);
        }
        public List<DMSanPhamPairInfo> ValidMaChietKhau(int idDKMua, int idsanpham, double giaBan)
        {
            return GetListCommand<DMSanPhamPairInfo>(Declare.StoreProcedureNamespace.spChungTuBanHangValidChietKhau, idDKMua, idsanpham, giaBan);
        }
        public List<ChungTuBanHangChiTietInfor> TimKiemChungTuChinhSach(TimKiemChungTuFilterInfor filter)
        {
            return GetListCommand<ChungTuBanHangChiTietInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemCTCSach,
                                                       filter.IdTrungTam, filter.IdKho, filter.SanPham, filter.MaHang, filter.LoaiMaHang, clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
                                                        filter.IdDoiTuong, filter.KhachHang, filter.DiaChi, filter.CMND, filter.DienThoai, filter.IdChinhSach);
        }
        public List<ChungTuBanHangInfor> TimKiemChungTuChinhSachThe(string maTrungTam, int idLoaiDoiTuong, int idChinhSachThe)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemCTCSachThe,
                                                       maTrungTam, idLoaiDoiTuong, idChinhSachThe);
        }
        //public List<ChungTuBanHangInfor> TimKiemKhachHangPg(TimKiemChungTuFilterInfor filter)
        //{
        //    return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemKHPg,
        //                                               filter.SoPhieu, filter.IdTrungTam, filter.IdKho, filter.NhanVien, clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
        //                                               filter.KhachHang, filter.CMND, filter.DienThoai, filter.MaSoThue, filter.SoBatDau, filter.SoKetThuc);
        //}
        //public List<ChungTuBanHangInfor> TimKiemChungTuPg(TimKiemChungTuFilterInfor filter)
        //{
        //    return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemCTPg,
        //                                               filter.SoPhieu, filter.LoaiDonHang, filter.GiaoNhan, filter.TrangThai, filter.IdTrungTam,
        //                                                filter.IdKho, filter.SanPham, filter.MaHang, filter.LoaiMaHang, filter.NhanVien, clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
        //                                                filter.IdDoiTuong, filter.KhachHang, filter.DiaChi, filter.CMND, filter.DienThoai, filter.GhiChu, filter.UserName, filter.Draft, filter.DoanhThuTu,
        //                                                filter.DoanhThuDen, filter.TinhTrangThanhToan, filter.SoBatDau, filter.SoKetThuc);
        //}
        //public List<ChungTuBanHangInfor> TimKiemDonHangPg(TimKiemChungTuFilterInfor filter)
        //{
        //    return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemDHPg,
        //                                               filter.SoPhieu, filter.LoaiDonHang, filter.GiaoNhan, filter.TrangThai, filter.IdTrungTam,
        //                                                filter.IdKho, filter.SanPham, filter.MaHang, filter.LoaiMaHang, filter.NhanVien, clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
        //                                                filter.IdDoiTuong, filter.KhachHang, filter.DiaChi, filter.CMND, filter.DienThoai, filter.GhiChu, filter.UserName, filter.Draft, filter.DoanhThuTu,
        //                                                filter.DoanhThuDen, filter.TinhTrangThanhToan, filter.SoBatDau, filter.SoKetThuc, filter.IdNhanVien, filter.IdNhomNguoiDung);
        //}
        public List<ChungTuBanHangInfor> TimKiemKhoaDonHangPg(TimKiemChungTuFilterInfor filter)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemKhoaDHPg,
                                                       filter.SoPhieu, filter.IdTrungTam, filter.IdKho, filter.SanPham, filter.MaHang, filter.LoaiMaHang, clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
                                                        filter.IdDoiTuong, filter.KhachHang, filter.CMND, filter.DienThoai, filter.UserName, filter.Draft, filter.SoBatDau, filter.SoKetThuc, filter.IdNhanVien);
        }
        public List<ChungTuBanHangInfor> TimKiemDonHangTheThanhVien(int idKhachLe)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemTheTVien, idKhachLe);
        }
        public List<ChungTuBanHangInfor> TimKiemDonHangKhachHang(int idKhachHang)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemKhachHang, idKhachHang);
        }
        //public List<ChungTuBanHangInfor> TimKiemPhieuThuPg(TimKiemChungTuFilterInfor filter)
        //{
        //    return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemPThuPg,
        //                                               filter.SoPhieu, filter.LoaiDonHang, filter.GiaoNhan, filter.TrangThai, filter.IdTrungTam,
        //                                                filter.IdKho, filter.SanPham, filter.MaHang, filter.LoaiMaHang, filter.NhanVien, clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
        //                                                filter.IdDoiTuong, filter.KhachHang, filter.DiaChi, filter.CMND, filter.DienThoai, filter.GhiChu, filter.UserName, filter.Draft, filter.DoanhThuTu,
        //                                                filter.DoanhThuDen, filter.TinhTrangThanhToan, filter.SoBatDau, filter.SoKetThuc, filter.IdNhanVien);
        //}
        public List<ChungTuBanHangInfor> TimKiemCongNoPg(TimKiemChungTuFilterInfor filter)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemCNoPg,
                                                       filter.SoPhieu, filter.LoaiDonHang, filter.GiaoNhan, filter.TrangThai, filter.IdTrungTam,
                                                        filter.IdKho, filter.SanPham, filter.MaHang, filter.LoaiMaHang, filter.NhanVien, clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
                                                        filter.IdDoiTuong, filter.KhachHang, filter.DiaChi, filter.CMND, filter.DienThoai, filter.GhiChu, filter.UserName, filter.Draft, filter.DoanhThuTu,
                                                        filter.DoanhThuDen, filter.TinhTrangThanhToan, filter.SoBatDau, filter.SoKetThuc, filter.IdNhanVien);
        }
        public List<ChungTuBanHangBCInfor> TimKiemChungTuGiaoNhan(TimKiemChungTuFilterInfor filter)
        {
            return GetListCommand<ChungTuBanHangBCInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemCTGN,
                                                       filter.SoPhieu, filter.LoaiDonHang, filter.TrangThai, filter.IdTrungTam,
                                                        filter.IdKho, filter.SanPham, filter.MaHang, filter.LoaiMaHang, filter.NhanVien, clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
                                                        filter.KhachHang, filter.DiaChi, filter.CMND, filter.DienThoai, filter.GhiChu, filter.UserName);
        }

        //public List<ChungTuBanHangBCInfor> TimKiemChungTuGiaoNhanPg(TimKiemChungTuFilterInfor filter)
        //{
        //    return GetListCommand<ChungTuBanHangBCInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemCTGNPg,
        //                                               filter.SoPhieu, filter.LoaiDonHang, filter.TrangThai, filter.IdTrungTam,
        //                                                filter.IdKho, filter.SanPham, filter.MaHang, filter.LoaiMaHang, filter.NhanVien, clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
        //                                                filter.KhachHang, filter.DiaChi, filter.CMND, filter.DienThoai, filter.GhiChu, filter.UserName, filter.SoBatDau, filter.SoKetThuc, filter.IdNhanVien);
        //}

        //public List<ChungTuBanHangGNhanCTietInfor> TimKiemChungTuGiaoNhanCTiet(TimKiemChungTuFilterInfor filter)
        //{
        //    return GetListCommand<ChungTuBanHangGNhanCTietInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemCTGNCTiet,
        //                                               filter.SoPhieu, filter.LoaiDonHang, filter.TrangThai, filter.IdTrungTam,
        //                                                filter.IdKho, filter.SanPham, filter.MaHang, filter.LoaiMaHang, filter.NhanVien, clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
        //                                                filter.KhachHang, filter.DiaChi, filter.CMND, filter.DienThoai, filter.GhiChu, filter.UserName);
        //}
        public List<ChungTuBanHangGNhanCTietInfor> TimKiemChungTuGiaoNhanCTietPg(TimKiemChungTuFilterInfor filter)
        {
            return GetListCommand<ChungTuBanHangGNhanCTietInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemCTGNCTietPg,
                                                       filter.SoPhieu, filter.LoaiDonHang, filter.TrangThai, filter.IdTrungTam,
                                                        filter.IdKho, filter.SanPham, filter.MaHang, filter.LoaiMaHang, filter.NhanVien, clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
                                                        filter.KhachHang, filter.DiaChi, filter.CMND, filter.DienThoai, filter.GhiChu, filter.UserName, filter.SoBatDau, filter.SoKetThuc, filter.IdNhanVien);
        }
        //public List<ChungTuBanHangGNhanCTietInfor> TimKiemChungTuGiaoNhanCTietKThuatPg(TimKiemGiaoNhanFilterInfor filter)
        //{
        //    return GetListCommand<ChungTuBanHangGNhanCTietInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemCTGNCTietKThuatPg,
        //                                               filter.SoPhieu, filter.LoaiDonHang, filter.TrangThai, filter.IdTrungTam,
        //                                                filter.IdKho, filter.SanPham, filter.NhanVien, filter.DoiTac, clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
        //                                                filter.QuanHuyen, filter.PhuongTien, filter.VungMien, filter.UserName, filter.SoBatDau, filter.SoKetThuc, filter.IdNhanVien);
        //}

        //public List<ChungTuBanHangGNhanCTietInfor> TimKiemChungTuGiaoNhanCTietKThuatCTPg(TimKiemGiaoNhanFilterInfor filter)
        //{
        //    return GetListCommand<ChungTuBanHangGNhanCTietInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemCTGNCTietKThuatCTPg,
        //                                               filter.SoPhieu, filter.LoaiDonHang, filter.TrangThai, filter.IdTrungTam,
        //                                                filter.IdKho, filter.SanPham, filter.NhanVien, filter.DoiTac, clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
        //                                                filter.QuanHuyen, filter.PhuongTien, filter.VungMien, filter.UserName, filter.SoBatDau, filter.SoKetThuc, filter.IdNhanVien);
        //}

        public List<ChungTuBanHangGNhanKThuatInfor> TimKiemChungTuGiaoNhanThongKeKThuatCTPg(TimKiemGiaoNhanFilterInfor filter)
        {
            return GetListCommand<ChungTuBanHangGNhanKThuatInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemCTGNThongKeKThuatCTPg,
                                                       filter.SoPhieu, filter.LoaiDonHang, filter.TrangThai, filter.IdTrungTam,
                                                        filter.IdKho, filter.SanPham, filter.NhanVien, filter.DoiTac, clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
                                                        filter.QuanHuyen, filter.PhuongTien, filter.VungMien, filter.UserName, filter.SoBatDau, filter.SoKetThuc, filter.IdNhanVien);
        }
        public List<ChungTuBanHangChiTietBCInfor> TimKiemChungTuChiTiet(TimKiemChungTuChiTietFilterInfor filter)
        {
            return GetListCommand<ChungTuBanHangChiTietBCInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemCTiet,
                                                       filter.SoPhieu, filter.LoaiDonHang, filter.IdTrungTam, filter.IdKho, filter.SanPham, filter.MaHang, filter.LoaiMaHang, filter.NhanVien, 
                                                       clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay), filter.KhachHang, filter.GhiChu, filter.UserName);
        }
        //public List<ChungTuBanHangChiTietBCInfor> TimKiemChungTuChiTietPg(TimKiemChungTuChiTietFilterInfor filter)
        //{
        //    return GetListCommand<ChungTuBanHangChiTietBCInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemCTietPg,
        //                                               filter.SoPhieu, filter.LoaiDonHang, filter.TrangThai, filter.IdTrungTam, filter.IdKho, filter.SanPham, filter.MaHang, filter.LoaiMaHang, filter.NhanVien,
        //                                               clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay), filter.KhachHang, filter.GhiChu, filter.UserName, filter.SoBatDau,filter.SoKetThuc, filter.IdNhanVien, filter.IdNhomNguoiDung);
        //}
        public void TimKiemChungTuChiTietPg(TimKiemChungTuChiTietFilterInfor filter, DataTable dataTable)
        {
            FillToDataTable(dataTable, Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemCTietPg,
                                                       filter.SoPhieu, filter.LoaiDonHang, filter.TrangThai, filter.IdTrungTam, filter.IdKho, filter.SanPham, filter.MaHang, filter.LoaiMaHang, filter.NhanVien,
                                                       clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay), filter.KhachHang, filter.GhiChu, filter.UserName, filter.SoBatDau, filter.SoKetThuc, filter.IdNhanVien, filter.IdNhomNguoiDung);
        }
        public DataSet TimKiemChungTuChiTietAll(TimKiemChungTuChiTietFilterInfor filter)
        {
            return GetDataSetCommand("tmp", Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemCTietAll, filter.SoPhieu,
                                     filter.LoaiDonHang, filter.IdTrungTam, filter.IdKho, filter.SanPham, filter.MaHang,
                                     filter.LoaiMaHang, filter.NhanVien,
                                     clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
                                     filter.KhachHang, filter.GhiChu, filter.UserName, filter.IdNhanVien);
        }
        public List<ChungTuBanHangChiTietBCInfor> TimKiemChungTuChiTietNoKMPg(TimKiemChungTuChiTietFilterInfor filter)
        {
            return GetListCommand<ChungTuBanHangChiTietBCInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemCTietNoKMPg,
                                                       filter.SoPhieu, filter.LoaiDonHang, filter.IdTrungTam, filter.IdKho, filter.SanPham, filter.MaHang, filter.LoaiMaHang, filter.NhanVien,
                                                       clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay), filter.KhachHang, filter.GhiChu, filter.UserName, filter.SoBatDau, filter.SoKetThuc);
        }
        public DataTable TimKiemChungTuChiTietOld(TimKiemChungTuChiTietFilterInfor filter)
        {
            return GetDataTableCommand(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemCTiet,
                                                       filter.SoPhieu, filter.LoaiDonHang, filter.IdTrungTam, filter.IdKho, filter.SanPham, filter.MaHang, filter.LoaiMaHang, filter.NhanVien, 
                                                       clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay), filter.KhachHang, filter.GhiChu, filter.UserName);

        }
        public List<ChungTuBanHangChiTietHangHoaBCInfor> TimKiemChungTuChiTietMaVach(TimKiemChungTuChiTietFilterInfor filter)
        {
            return GetListCommand<ChungTuBanHangChiTietHangHoaBCInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangSearchCTietMVach,
                                                       filter.SoPhieu, filter.LoaiDonHang, filter.IdTrungTam, filter.IdKho, filter.SanPham, filter.NhanVien,
                                                       clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay), filter.KhachHang, filter.GhiChu, filter.UserName, filter.MaVach, filter.TrangThai);
        }
        public List<ChungTuBanHangChiTietHangHoaBCInfor> TimKiemChungTuChiTietMaVachPg(TimKiemChungTuChiTietFilterInfor filter)
        {
            return GetListCommand<ChungTuBanHangChiTietHangHoaBCInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangSearchCTietMVachPg,
                                                       filter.SoPhieu, filter.LoaiDonHang, filter.IdTrungTam, filter.IdKho, filter.SanPham, filter.NhanVien,
                                                       filter.TuNgay, filter.DenNgay, filter.NXTuNgay, filter.NXDenNgay, filter.KhachHang, filter.GhiChu, filter.UserName, filter.MaVach, filter.TrangThai, filter.SoBatDau, filter.SoKetThuc, filter.IdNhanVien, filter.IdNhomNguoiDung);
        }

        //public void TimKiemChungTuChiTietMaVachPg(TimKiemChungTuChiTietFilterInfor filter, DataTable dataTable)
        //{
        //    FillToDataTable(dataTable, Declare.StoreProcedureNamespace.spChungTuBanHangSearchCTietMVachPg,
        //                    filter.SoPhieu, filter.LoaiDonHang, filter.IdTrungTam, filter.IdKho, filter.SanPham,
        //                    filter.NhanVien,
        //                    clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
        //                    clsUtils.DateValue(filter.NXTuNgay), clsUtils.DateValue(filter.NXDenNgay), filter.KhachHang,
        //                    filter.GhiChu, filter.UserName, filter.MaVach, filter.TrangThai, filter.SoBatDau,
        //                    filter.SoKetThuc, filter.IdNhanVien, filter.IdNhomNguoiDung);
        //}

        public List<ChungTuBanHangChiTietHangHoaBCInfor> TimKiemChungTuChiTietChuaXuatDuPg(TimKiemChungTuChiTietFilterInfor filter)
        {
            return
                GetListCommand<ChungTuBanHangChiTietHangHoaBCInfor>(
                    Declare.StoreProcedureNamespace.spChungTuBanHangSearchCTietChuaXuatDuPg,
                    filter.SoPhieu, filter.LoaiDonHang, filter.IdTrungTam, filter.IdKho, filter.SanPham, filter.NhanVien,
                    clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
                    clsUtils.DateValue(filter.NXTuNgay), clsUtils.DateValue(filter.NXDenNgay), filter.KhachHang,
                    filter.GhiChu, filter.UserName, filter.MaVach, filter.TrangThai, filter.SoBatDau, filter.SoKetThuc, filter.IdNhanVien, filter.IdNhomNguoiDung);
        }

        public List<ChungTuBanHangChiTietHangHoaBHInfor> TimKiemChungTuChiTietMaVachBaoHanh(TimKiemChungTuChiTietFilterInfor filter)
        {
            return GetListCommand<ChungTuBanHangChiTietHangHoaBHInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangSearchCTietMVachBHanh,
                                                       filter.SoPhieu, filter.LoaiDonHang, filter.IdTrungTam, filter.IdKho, filter.SanPham, filter.NhanVien,
                                                       clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay), filter.KhachHang, filter.GhiChu, filter.UserName, filter.MaVach, filter.HangSanXuat, filter.LoaiMaHang);
        }
        //public List<ChungTuBanHangChiTietHangHoaBHInfor> TimKiemChungTuChiTietMaVachBaoHanhPg(TimKiemChungTuChiTietFilterInfor filter)
        //{
        //    return GetListCommand<ChungTuBanHangChiTietHangHoaBHInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangSearchCTietMVachBHanhPg,
        //                                               filter.SoPhieu, filter.IdTrungTam, filter.IdKho, filter.SanPham, filter.Nganh,
        //                                               clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay), filter.KhachHang, filter.UserName, filter.MaVach, filter.HangSanXuat, filter.SoBatDau, filter.SoKetThuc, filter.LoaiDonHang, filter.LoaiMaVach);
        //}

        public List<ChungTuBanHangChiTietHangHoaBHInfor> TimKiemChungTuChiTietMaVachTonKho(TimKiemChungTuChiTietFilterInfor filter)
        {
            return GetListCommand<ChungTuBanHangChiTietHangHoaBHInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangSearchCTietMVachTon,
                                                       filter.SoPhieu, filter.LoaiDonHang, filter.IdTrungTam, filter.IdKho, filter.SanPham, filter.NhanVien,
                                                       clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay), filter.KhachHang, filter.GhiChu, filter.UserName, filter.MaVach, filter.HangSanXuat, filter.LoaiMaHang);
        }
        public List<ChungTuBanHangChiTietHangHoaBHInfor> TimKiemChungTuChiTietMaVachTonKhoPg(TimKiemChungTuChiTietFilterInfor filter)
        {
            return GetListCommand<ChungTuBanHangChiTietHangHoaBHInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangSearchCTietMVachTonPg,
                                                       filter.SoPhieu, filter.IdTrungTam, filter.IdKho, filter.SanPham, filter.Nganh,
                                                       clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay), filter.KhachHang, filter.UserName, filter.MaVach, filter.HangSanXuat, filter.SoBatDau, filter.SoKetThuc, filter.LoaiMaVach);
        }

        //public List<LichSuChiTietMaVachInfor> TimKiemLichSuChiTietMaVach(TimKiemChungTuChiTietFilterInfor filter)
        //{
        //    return GetListCommand<LichSuChiTietMaVachInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangSearchLichSuMaVach,
        //                                               filter.SoPhieu, filter.LoaiDonHang, filter.IdTrungTam, filter.IdKho, filter.SanPham, filter.NhanVien,
        //                                               clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),filter.KhachHang, filter.GhiChu,
        //                                               filter.UserName, filter.MaVach, filter.HangSanXuat, filter.LoaiMaHang);
        //}
        public List<LichSuChiTietMaVachInfor> TimKiemTonChiTietMaVach(TimKiemChungTuChiTietFilterInfor filter)
        {
            return GetListCommand<LichSuChiTietMaVachInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangSearchTonMaVach,
                                                       filter.IdTrungTam, filter.IdKho, filter.SanPham, filter.MaVach);
        }
        public List<LichSuChiTietMaVachInfor> TimKiemTonChiTietMaVachPg(TimKiemChungTuChiTietFilterInfor filter)
        {
            return GetListCommand<LichSuChiTietMaVachInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangSearchTonMaVachPg,
                                                       filter.IdTrungTam, filter.IdKho, filter.SanPham, filter.MaVach, filter.SoBatDau, filter.SoKetThuc, filter.Nganh, filter.SoTon, filter.IdNhanVien, filter.LoaiDonHang);
        }
        //public List<TonSanPhamHienCoInfor> TimKiemTonChiTietSanPhamPg(TimKiemChungTuChiTietFilterInfor filter)
        //{
        //    return GetListCommand<TonSanPhamHienCoInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangSearchTonSanPhamPg,
        //                                               filter.IdTrungTam, filter.IdKho, filter.SanPham, filter.SoBatDau, filter.SoKetThuc, filter.Nganh, filter.SoTon, filter.IdNhanVien);
        //}


        
        public List<ChungTuBanHangInfor> TimKiemChungTuNoKhuyenMai(TimKiemChungTuFilterInfor filter)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemNoKMai, filter.SoPhieu, filter.LoaiDonHang, filter.IdTrungTam,
                                                       filter.IdKho, filter.SanPham, filter.MaHang, filter.LoaiMaHang, filter.NhanVien, clsUtils.DateValue(filter.TuNgay),
                                                       clsUtils.DateValue(filter.DenNgay), filter.IdDoiTuong, filter.KhachHang, filter.DiaChi, filter.CMND, filter.DienThoai, filter.GhiChu);
        }
        public List<ItemTonKhoInfor> LoadTonKhoTheoTrungTam(int idSanPham, int soTon)
        {
            return GetListCommand<ItemTonKhoInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTonKhoBySanPham, idSanPham, soTon);
        }
        public List<ChungTuBanHangInfor> SearchChungTuDieuChuyen(string soPhieuDC, string soHoaDonDC, string nhanVienGiao, string hangHoa, int idKhoDi, int idKhoDen, DateTime ngayBatDau, DateTime ngayKetThuc, int trangThai, int type)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangSearchByPDC,
                                                       soPhieuDC, soHoaDonDC, nhanVienGiao, hangHoa, idKhoDi, idKhoDen, clsUtils.DateValue(ngayBatDau), clsUtils.DateValue(ngayKetThuc), trangThai, type);
        }
        #endregion

        #region chungtu chitiet
        public List<ChungTuBanHangChiTietInfor> GetListChiTietChungTuByIdChungTu(int idChungTu)
        {
            return
                GetListCommand<ChungTuBanHangChiTietInfor>(
                    Declare.StoreProcedureNamespace.spChungTuBanHangCTietGetByCT, idChungTu);
        }
        public List<ChungTuBanHangChiTietInfor> GetListChiTietChungTuKhuyenMai(int idChungTu, int idSanPham)
        {
            return
                GetListCommand<ChungTuBanHangChiTietInfor>(
                    Declare.StoreProcedureNamespace.spChungTuBanHangCTietGetByKM, idChungTu, idSanPham);
        }
        public List<DanhSachHangXuatBanInfor> GetAllChiTietXuatKhoByIdChungTu(int idChungTu)
        {
            return
                GetListCommand<DanhSachHangXuatBanInfor>(
                    Declare.StoreProcedureNamespace.spChungTuBanHangCTietGetDaXuatByCT, idChungTu);
        }
        public List<ChungTuBanHangChiTietInfor> GetListChiTietChungTuNoKhuyenMai(int idChungTu, int idKho)
        {
            return
                GetListCommand<ChungTuBanHangChiTietInfor>(
                    Declare.StoreProcedureNamespace.spChungTuBanHangCTietGetNoKM, idChungTu, idKho);
        }
        public List<HangBanGiaoNhanChiTietInfor> GetListChiTietChungTuByListIdChungTu(string lstIdChungTu)
        {
            return
                GetListCommand<HangBanGiaoNhanChiTietInfor>(
                    Declare.StoreProcedureNamespace.spChungTuBanHangGetByListId, lstIdChungTu);
        }

        public ChungTuBanHangChiTietInfor GetChiTietChungTuByIdChiTiet(int idChiTiet)
        {
            return GetObjectCommand<ChungTuBanHangChiTietInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangCTietGetById, idChiTiet);
        }

        public int InsertChiTietChungTu(ChungTuBanHangChiTietInfor chiTietChungTu)
        {
            if (chiTietChungTu.ListChinhSachDefault != null && chiTietChungTu.ListChinhSachDefault.Count > 0 || chiTietChungTu.ChinhSach != null || chiTietChungTu.CSachChietKhau != null)
            {
                chiTietChungTu.ListIdChinhSach = ";";
                chiTietChungTu.ListSoChinhSach = ";";
                if (chiTietChungTu.CSachChietKhau != null)
                {
                    chiTietChungTu.ListIdChinhSach += chiTietChungTu.CSachChietKhau.IdDKMua + ";";
                    chiTietChungTu.ListSoChinhSach += chiTietChungTu.CSachChietKhau.SoChinhSach + ";";
                }
                if (chiTietChungTu.ChinhSach != null)
                {
                    chiTietChungTu.ListIdChinhSach += chiTietChungTu.ChinhSach.IdDKMua + ";";
                    chiTietChungTu.ListSoChinhSach += chiTietChungTu.ChinhSach.SoChinhSach + ";";
                }
                if (chiTietChungTu.ListChinhSachDefault != null && chiTietChungTu.ListChinhSachDefault.Count > 0)
                {
                    foreach (BangGiaChinhSachInfor cs in chiTietChungTu.ListChinhSachDefault)
                    {
                        chiTietChungTu.ListIdChinhSach += cs.IdDKMua + ";";
                        chiTietChungTu.ListSoChinhSach += cs.SoChinhSach + ";";
                    }
                }
            }
            if (chiTietChungTu.CungDongDonHangChinh == 1 && chiTietChungTu.InHoaDon == 0)
                chiTietChungTu.InHoaDon = 1;
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangCTietInsert, chiTietChungTu.IdChungTuChiTiet,
                           chiTietChungTu.IdChungTu, chiTietChungTu.IdSanPham, chiTietChungTu.SoLuong, chiTietChungTu.DonGia,
                           chiTietChungTu.TyleChietKhau, chiTietChungTu.TienChietKhau, chiTietChungTu.ThanhTien,
                           chiTietChungTu.TienSauChietKhau, chiTietChungTu.TyleVAT, chiTietChungTu.TienVAT,
                           chiTietChungTu.TyleThuong, chiTietChungTu.ThuongNong, chiTietChungTu.GiaTheoBangGia,
                           chiTietChungTu.IdSanPhamBan, chiTietChungTu.NoKhuyenMai, chiTietChungTu.GiaNiemYet, chiTietChungTu.GiaWebSite,
                           chiTietChungTu.GhiChu, chiTietChungTu.CungDongDonHangChinh, chiTietChungTu.LoaiHangKem, chiTietChungTu.TyLePhanBo,
                           chiTietChungTu.TyLeThanhToan, chiTietChungTu.ListIdChinhSach, chiTietChungTu.ListSoChinhSach, chiTietChungTu.InHoaDon, 
                           chiTietChungTu.TyLeDiemThuong, chiTietChungTu.SoDiemThuong, chiTietChungTu.TyLeDiemThuongMacDinh);
            return Common.IntValue(Parameters["p_IdChiTiet"].Value);
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
            if (chiTietChungTu.ListChinhSachDefault != null && chiTietChungTu.ListChinhSachDefault.Count > 0 || chiTietChungTu.ChinhSach != null || chiTietChungTu.CSachChietKhau != null)
            {
                chiTietChungTu.ListIdChinhSach = ";";
                chiTietChungTu.ListSoChinhSach = ";";
                if (chiTietChungTu.CSachChietKhau != null)
                {
                    chiTietChungTu.ListIdChinhSach += chiTietChungTu.CSachChietKhau.IdDKMua + ";";
                    chiTietChungTu.ListSoChinhSach += chiTietChungTu.CSachChietKhau.SoChinhSach + ";";
                }
                if (chiTietChungTu.ChinhSach != null)
                {
                    chiTietChungTu.ListIdChinhSach += chiTietChungTu.ChinhSach.IdDKMua + ";";
                    chiTietChungTu.ListSoChinhSach += chiTietChungTu.ChinhSach.SoChinhSach + ";";
                }
                if (chiTietChungTu.ListChinhSachDefault != null && chiTietChungTu.ListChinhSachDefault.Count > 0)
                {
                    foreach (BangGiaChinhSachInfor cs in chiTietChungTu.ListChinhSachDefault)
                    {
                        chiTietChungTu.ListIdChinhSach += cs.IdDKMua + ";";
                        chiTietChungTu.ListSoChinhSach += cs.SoChinhSach + ";";
                    }
                }
            }
            if (chiTietChungTu.CungDongDonHangChinh == 1 && chiTietChungTu.InHoaDon == 0)
                chiTietChungTu.InHoaDon = 1;
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangCTietUpdate, chiTietChungTu.IdChungTuChiTiet,
                           chiTietChungTu.IdChungTu, chiTietChungTu.IdSanPham, chiTietChungTu.SoLuong, chiTietChungTu.DonGia,
                           chiTietChungTu.TyleChietKhau, chiTietChungTu.TienChietKhau, chiTietChungTu.ThanhTien,
                           chiTietChungTu.TienSauChietKhau, chiTietChungTu.TyleVAT, chiTietChungTu.TienVAT,
                           chiTietChungTu.TyleThuong, chiTietChungTu.ThuongNong, chiTietChungTu.GiaTheoBangGia,
                           chiTietChungTu.IdSanPhamBan, chiTietChungTu.NoKhuyenMai, chiTietChungTu.GiaNiemYet, chiTietChungTu.GiaWebSite,
                           chiTietChungTu.GhiChu, chiTietChungTu.CungDongDonHangChinh, chiTietChungTu.LoaiHangKem, chiTietChungTu.TyLePhanBo,
                           chiTietChungTu.TyLeThanhToan, chiTietChungTu.ListIdChinhSach, chiTietChungTu.ListSoChinhSach, chiTietChungTu.InHoaDon,
                           chiTietChungTu.TyLeDiemThuong, chiTietChungTu.SoDiemThuong, chiTietChungTu.TyLeDiemThuongMacDinh);
        }
        public void UpdateChiTietChungTuKM(ChungTuBanHangChiTietInfor chiTietChungTu)
        {
            if (chiTietChungTu.ListChinhSachDefault != null && chiTietChungTu.ListChinhSachDefault.Count > 0 || chiTietChungTu.ChinhSach != null || chiTietChungTu.CSachChietKhau != null)
            {
                chiTietChungTu.ListIdChinhSach = ";";
                chiTietChungTu.ListSoChinhSach = ";";
                if (chiTietChungTu.CSachChietKhau != null)
                {
                    chiTietChungTu.ListIdChinhSach += chiTietChungTu.CSachChietKhau.IdDKMua + ";";
                    chiTietChungTu.ListSoChinhSach += chiTietChungTu.CSachChietKhau.SoChinhSach + ";";
                }
                if (chiTietChungTu.ChinhSach != null)
                {
                    chiTietChungTu.ListIdChinhSach += chiTietChungTu.ChinhSach.IdDKMua + ";";
                    chiTietChungTu.ListSoChinhSach += chiTietChungTu.ChinhSach.SoChinhSach + ";";
                }
                if (chiTietChungTu.ListChinhSachDefault != null && chiTietChungTu.ListChinhSachDefault.Count > 0)
                {
                    foreach (BangGiaChinhSachInfor cs in chiTietChungTu.ListChinhSachDefault)
                    {
                        chiTietChungTu.ListIdChinhSach += cs.IdDKMua + ";";
                        chiTietChungTu.ListSoChinhSach += cs.SoChinhSach + ";";
                    }
                }
            }
            if (chiTietChungTu.CungDongDonHangChinh == 1 && chiTietChungTu.InHoaDon == 0)
                chiTietChungTu.InHoaDon = 1;
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangCTietUpdate, chiTietChungTu.IdChungTuChiTiet,
                           chiTietChungTu.IdChungTu, chiTietChungTu.IdSanPham, chiTietChungTu.SoLuong, chiTietChungTu.DonGia,
                           chiTietChungTu.TyleChietKhau, chiTietChungTu.TienChietKhau, chiTietChungTu.ThanhTien,
                           chiTietChungTu.TienSauChietKhau, chiTietChungTu.TyleVAT, chiTietChungTu.TienVAT,
                           chiTietChungTu.TyleThuong, chiTietChungTu.ThuongNong, chiTietChungTu.GiaTheoBangGia,
                           chiTietChungTu.IdSanPhamBan, chiTietChungTu.NoKhuyenMai, chiTietChungTu.GiaNiemYet, chiTietChungTu.GiaWebSite,
                           chiTietChungTu.GhiChu, chiTietChungTu.CungDongDonHangChinh, chiTietChungTu.LoaiHangKem, chiTietChungTu.TyLePhanBo,
                           chiTietChungTu.TyLeThanhToan, chiTietChungTu.ListIdChinhSach, chiTietChungTu.ListSoChinhSach, chiTietChungTu.InHoaDon,
                           chiTietChungTu.TyLeDiemThuong, chiTietChungTu.SoDiemThuong, chiTietChungTu.TyLeDiemThuongMacDinh);
        }

        public void XoaKhuyenMai(int idChiTietChungTu, int isDelete)
        {
            NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangCTietXoaNoKM, idChiTietChungTu, isDelete, nguoiDung.TenDangNhap, Declare.TenMay);
        }

        #endregion

        #region chungtu chitiet hang hoa
        public List<ChungTuBanHangChiTietHangHoaInfor> GetListChiTietHangHoaByIdChungTu(int idChungTu)
        {
            return GetListCommand<ChungTuBanHangChiTietHangHoaInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangCTietHHoaGetByCTu, idChungTu);
        }
        /// <summary>
        /// Get all ma vach cua 1 chung tu (dung khi khong quan tam den so luong max ma vach
        /// </summary>
        /// <param name="idChungTu"></param>
        /// <param name="idKho"></param>
        /// <param name="maxSoLuongMaVach"></param>
        /// <returns></returns>
        public List<ChungTuBanHangChiTietHangHoaInfor> GetAllListChiTietHangHoaByIdChungTu(int idChungTu, int idKho)
        {
            return GetListCommand<ChungTuBanHangChiTietHangHoaInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangCTietHHoaGetAll, idChungTu, idKho);
        }

        /// <summary>
        /// Get all ma vach cua 1 chung tu by max(dung khi quan tam den so luong max ma vach)
        /// </summary>
        /// <param name="idChungTu"></param>
        /// <param name="idKho"></param>
        /// <returns></returns>
        public List<ChungTuBanHangChiTietHangHoaInfor> GetAllListChiTietHangHoaByMaxMaVach(int idChungTu, int idKho)
        {
            return GetListCommand<ChungTuBanHangChiTietHangHoaInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangCTietHHoaGetByMax, idChungTu, idKho);
        }

        public List<ChungTuBanHangChiTietHangHoaInfor> GetChiTietHangHoaByMaVach(string code, int idKho)
        {
            return GetListCommand<ChungTuBanHangChiTietHangHoaInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangCTietHHoaGetByMV, code, idKho);
        }

        public List<ChungTuBanHangChiTietHangHoaInfor> GetListChiTietHangHoaByPhieuDC(string soPhieuDieuChuyen, string soChungTu)
        {
            return GetListCommand<ChungTuBanHangChiTietHangHoaInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangCTietHHoaGetByDC, soPhieuDieuChuyen, soChungTu);
        }

        public void DeleteChiTietHangHoa(ChungTuBanHangChiTietHangHoaInfor chiTietHangHoa)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangCTietHHoaDelete, chiTietHangHoa.IdChungTuChiTiet, chiTietHangHoa.IdChiTietHangHoa);
        }

        public void DeleteChiTietHangHoaByChiTiet(ChungTuBanHangChiTietHangHoaInfor chiTietHangHoa)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangCTietHHoaDelByCT, chiTietHangHoa.IdChungTuChiTiet);
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
        public List<ChungTuThanhToanInfor> GetListChungTuThanhToanByIdChungTu(int idChungTu)
        {
            return GetListCommand<ChungTuThanhToanInfor>(Declare.StoreProcedureNamespace.spChungTuThanhToanGetByCT, idChungTu);
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

        #region bao cao
        public List<DanhSachBaoCaoBanHangInfor> GetListBaoCaoTongHopBanHang()
        {
            return GetListCommand<DanhSachBaoCaoBanHangInfor>(Declare.StoreProcedureNamespace.spDmBaoCao_SelectAll);
        }
        public DataSet LoadBaoCao(string store, int idTrungTam, DateTime start, DateTime end)
        {
            return GetDataSetCommand(store, idTrungTam, clsUtils.DateValue(start), clsUtils.DateValue(end));
        }
        #endregion

        public bool ExistChungTuPhaiSinh(string soChungTuGoc, int loaiChungTu)
        {
            return Convert.ToInt32(ExecuteScalar(
                @"select count(*) from tbl_chungtu 
                    where loaichungtu = :loaichungtu 
                    and sochungtugoc = :sochungtugoc",
                loaiChungTu, soChungTuGoc)) > 0;            
        }

        public bool ExistChungTuKetChuyen(string soChungTu, int loaiChungTu)
        {
            return ExistChungTuPhaiSinh(soChungTu, loaiChungTu);
        }

        public bool ExistChungTuXuatKho(string soChungTu)
        {
            return ExistChungTuPhaiSinh(soChungTu, Convert.ToInt32(TransactionType.XUAT_KHO_HANG_BAN));
        }

        public bool ValidMaVach(string lstIdDKMua, string maVach)
        {
            string sql = String.Format(@"SELECT count(*) FROM tbl_banggia_chinhsach_dkmua t WHERE t.iddkmua IN ({0}) 
                                        AND ('!!!' || t.mahangmua || '!!!') LIKE '%!!!{1}!!!%'", lstIdDKMua, maVach);
            return Convert.ToInt32(ExecuteScalar(sql)) > 0;
        }

        public bool ExistPhieuTraHangMua(string soChungTu)
        {
            return Convert.ToInt32(ExecuteScalar(
                @"select count(*) from tbl_chungtu 
                    where loaichungtu = 33 
                    and sochungtugoc = :sochungtugoc",
                soChungTu)) > 0;
        }

        public int GetAmountPermission(int idSanPham, int idKho)
        {
            return
                GetObjectCommand<int>(
                    @"select nvl(kh.soluongmavach, 10) from tbl_sanpham sp
                inner join tbl_dm_loaisanpham lsp on sp.idcha = lsp.idloaisp and sp.idsanpham = :idSanPham
                left join tbl_kho_nganhhang kh on lsp.nganh = kh.manganhhang
                and kh.idkho = :idKho", idSanPham, idKho);
        }
    }

    public class BaoCaoGiaoNhanDao : Base3Dao
    {
        private static BaoCaoGiaoNhanDao instance;
        
        private BaoCaoGiaoNhanDao()
        {
            //CRUDTableName = Declare.TableNamespace.tbl_ChungTu_ChiTiet;
            //UseCaching = true;
        }

        public static BaoCaoGiaoNhanDao Instance
        {
            get { return instance ?? (instance = new BaoCaoGiaoNhanDao()); }
        }

        internal List<ChungTuBanHangBCInfor> Search(TimKiemChungTuFilterInfor filter)
        {
            return GetListCommand<ChungTuBanHangBCInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemCTGNPg,
                                                       filter.SoPhieu, filter.LoaiDonHang, filter.TrangThai, filter.IdTrungTam,
                                                        filter.IdKho, filter.SanPham, filter.MaHang, filter.LoaiMaHang, filter.NhanVien, clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
                                                        filter.KhachHang, filter.DiaChi, filter.CMND, filter.DienThoai, filter.GhiChu, filter.UserName, filter.SoBatDau, filter.SoKetThuc, filter.IdNhanVien);
        }

        internal List<StorageInfor1> GetListComputedStorage(DateTime date, int idTrungTam)
        {
            var paras = new List<object>();

            string sqlCmd = @"select distinct idtrungtam, to_date(:runningDate, 'dd/mm/rrrr') as runningDate from tbl_chungtu t
                where (t.loaichungtu in (10,35,36)
                    or t.loaichungtu = 8 and (t.trangthai != 5 and t.sochungtugoc is not null)
                    or t.loaichungtu = 9 and (t.trangthai not in (1,3) and t.sochungtugoc is not null))
                 and (t.trangthai not in (1,3,5,12,19,20))
                 and t.ngaylap >= to_date(:runningDate, 'dd/mm/rrrr')
                 and t.ngaylap < to_date(:runningDate, 'dd/mm/rrrr') + 1";

            paras.Add(date.ToString("dd/MM/yyyy"));

            if (idTrungTam > 0)
            {
                sqlCmd += " and t.idtrungtam = :filterIdTrungTam";

                paras.Add(idTrungTam);
            }
            return GetListCommand<StorageInfor1>(sqlCmd, paras.ToArray());
        }
    }

    public class BaoCaoGiaoNhanChiTietKThuatDao : Base3Dao
    {
        private static BaoCaoGiaoNhanChiTietKThuatDao instance;

        private BaoCaoGiaoNhanChiTietKThuatDao() { }

        public static BaoCaoGiaoNhanChiTietKThuatDao Instance
        {
            get { return instance ?? (instance = new BaoCaoGiaoNhanChiTietKThuatDao()); }
        }

        internal List<ChungTuBanHangGNhanCTietInfor> Search(TimKiemGiaoNhanFilterInfor filter)
        {
            return GetListCommand<ChungTuBanHangGNhanCTietInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemCTGNCTietKThuatPg,
                                                       filter.SoPhieu, filter.LoaiDonHang, filter.TrangThai, filter.IdTrungTam,
                                                        filter.IdKho, filter.SanPham, filter.NhanVien, filter.DoiTac, clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
                                                        filter.QuanHuyen, filter.PhuongTien, filter.VungMien, filter.UserName, filter.SoBatDau, filter.SoKetThuc, filter.IdNhanVien);
        }

        internal List<StorageInfor1> GetListComputedStorage(DateTime date, int idTrungTam)
        {
            var paras = new List<object>();

            string sqlCmd = @"select distinct idtrungtam, to_date(:runningDate, 'dd/mm/rrrr') as runningDate from tbl_chungtu t
                inner join tbl_chungtu_giaonhan gn on t.idphieugiaonhan = gn.idgiaonhan
                where (t.loaichungtu in (10,35,36)
                    or t.loaichungtu = 8 and (t.trangthai NOT IN (5,20) and t.sochungtugoc is not null)
                    or t.loaichungtu = 9 and (t.trangthai not in (1,3,19) and t.sochungtugoc is not null))
                 and (t.trangthai in (9,11,22))
                 and gn.ngayphancong >= to_date(:runningDate, 'dd/mm/rrrr')
                 and gn.ngayphancong < to_date(:runningDate, 'dd/mm/rrrr') + 1";

            paras.Add(date.ToString("dd/MM/yyyy"));

            if (idTrungTam > 0)
            {
                sqlCmd += " and t.idtrungtam = :filterIdTrungTam";

                paras.Add(idTrungTam);
            }
            return GetListCommand<StorageInfor1>(sqlCmd, paras.ToArray());
        }
    }

    public class NhatKyHoatDongMaVachDao : Base3Dao
    {
        private static NhatKyHoatDongMaVachDao instance;

        private NhatKyHoatDongMaVachDao() { }

        public static NhatKyHoatDongMaVachDao Instance
        {
            get { return instance ?? (instance = new NhatKyHoatDongMaVachDao()); }
        }
        public List<LichSuChiTietMaVachInfor> TimKiemLichSuChiTietMaVach(TimKiemChungTuChiTietFilterInfor filter)
        {
            return GetListCommand<LichSuChiTietMaVachInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangSearchLichSuMaVach,
                                                       filter.SoPhieu, filter.LoaiDonHang, filter.IdTrungTam, filter.IdKho, filter.SanPham, filter.NhanVien,
                                                       clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay), filter.KhachHang, filter.GhiChu,
                                                       filter.UserName, filter.MaVach, filter.HangSanXuat, filter.LoaiMaHang);
        }
    }

    public class BaoCaoDonHangChuaXuatDuDao : Base3Dao
    {
        private static BaoCaoDonHangChuaXuatDuDao instance;

        private BaoCaoDonHangChuaXuatDuDao() { }

        public static BaoCaoDonHangChuaXuatDuDao Instance
        {
            get { return instance ?? (instance = new BaoCaoDonHangChuaXuatDuDao()); }
        }

        public List<StorageInfor1> GetListComputedStorage(DateTime date, int idTrungTam)
        {
            var paras = new List<object>();

            string sqlCmd = @"select distinct idtrungtam, to_date(:runningDate, 'dd/mm/rrrr') as runningDate from tbl_chungtu t
                where t.loaichungtu in (8,9,10,35,36)
                 and t.ngaylap >= to_date(:runningDate, 'dd/mm/rrrr')
                 and t.ngaylap < to_date(:runningDate, 'dd/mm/rrrr') + 1";

            paras.Add(date.ToString("dd/MM/yyyy"));

            if (idTrungTam > 0)
            {
                sqlCmd += " and t.idtrungtam = :filterIdTrungTam";

                paras.Add(idTrungTam);
            }

            var result = GetListCommand<StorageInfor1>(sqlCmd, paras.ToArray());

            if (!result.Exists(delegate(StorageInfor1 match) { return match.IdTrungTam == 3; }))

                result.Add(new StorageInfor1 { IdTrungTam = 3, RunningDate = date });

            if (!result.Exists(delegate(StorageInfor1 match) { return match.IdTrungTam == 9; }))

                result.Add(new StorageInfor1 { IdTrungTam = 3, RunningDate = date });

            return result;

        }

        public List<ChungTuBanHangChiTietHangHoaBCInfor> Search(TimKiemChungTuChiTietFilterInfor filter)
        {
            return
                GetListCommand<ChungTuBanHangChiTietHangHoaBCInfor>(
                    Declare.StoreProcedureNamespace.spChungTuBanHangSearchCTietChuaXuatDuPg,
                    filter.SoPhieu, filter.LoaiDonHang, filter.IdTrungTam, filter.IdKho, filter.SanPham, filter.NhanVien,
                    clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
                    clsUtils.DateValue(filter.NXTuNgay), clsUtils.DateValue(filter.NXDenNgay), filter.KhachHang,
                    filter.GhiChu, filter.UserName, filter.MaVach, filter.TrangThai, filter.SoBatDau, filter.SoKetThuc, filter.IdNhanVien, filter.IdNhomNguoiDung);
        }
    }

    public class TimKiemKhachMuaHangDao : Base3Dao
    {
        private static TimKiemKhachMuaHangDao instance;

        private TimKiemKhachMuaHangDao() { }

        public static TimKiemKhachMuaHangDao Instance
        {
            get { return instance ?? (instance = new TimKiemKhachMuaHangDao()); }
        }

        public List<StorageInfor1> GetListComputedStorage(DateTime date, int idTrungTam)
        {
            var paras = new List<object>();

            string sqlCmd = @"select distinct idtrungtam, to_date(:runningDate, 'dd/mm/rrrr') as runningDate from tbl_chungtu t
                where t.loaichungtu in (8,9,10,33,34,35,36,42,50)
                 and t.ngaylap >= to_date(:runningDate, 'dd/mm/rrrr')
                 and t.ngaylap < to_date(:runningDate, 'dd/mm/rrrr') + 1";

            paras.Add(date.ToString("dd/MM/yyyy"));

            if (idTrungTam > 0)
            {
                sqlCmd += " and t.idtrungtam = :filterIdTrungTam";

                paras.Add(idTrungTam);
            }

            var result = GetListCommand<StorageInfor1>(sqlCmd, paras.ToArray());

            if (!result.Exists(delegate(StorageInfor1 match) { return match.IdTrungTam == 3; }))

                result.Add(new StorageInfor1 { IdTrungTam = 3, RunningDate = date });

            if (!result.Exists(delegate(StorageInfor1 match) { return match.IdTrungTam == 9; }))

                result.Add(new StorageInfor1 { IdTrungTam = 3, RunningDate = date });

            return result;

        }

        public List<ChungTuBanHangInfor> Search(TimKiemChungTuFilterInfor filter)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemKHPg,
                                           filter.SoPhieu, filter.IdTrungTam, filter.IdKho, filter.NhanVien, clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
                                           filter.KhachHang, filter.CMND, filter.DienThoai, filter.MaSoThue, filter.SoBatDau, filter.SoKetThuc);
        }
    }

    public class TimKiemDonHangDao : Base3Dao
    {
        private static TimKiemDonHangDao instance;

        private TimKiemDonHangDao() { }

        public static TimKiemDonHangDao Instance
        {
            get { return instance ?? (instance = new TimKiemDonHangDao()); }
        }

        public List<StorageInfor1> GetListComputedStorage(DateTime date, int idTrungTam)
        {
            var paras = new List<object>();

            string sqlCmd = @"select distinct idtrungtam, to_date(:runningDate, 'dd/mm/rrrr') as runningDate from tbl_chungtu t
                where t.loaichungtu in (8,9,10,33,34,35,36,42,50)
                 and t.ngaylap >= to_date(:runningDate, 'dd/mm/rrrr')
                 and t.ngaylap < to_date(:runningDate, 'dd/mm/rrrr') + 1";

            paras.Add(date.ToString("dd/MM/yyyy"));

            if (idTrungTam > 0)
            {
                sqlCmd += " and t.idtrungtam = :filterIdTrungTam";

                paras.Add(idTrungTam);
            }

            var result = GetListCommand<StorageInfor1>(sqlCmd, paras.ToArray());

            if (!result.Exists(delegate(StorageInfor1 match) { return match.IdTrungTam == 3; }))

                result.Add(new StorageInfor1 { IdTrungTam = 3, RunningDate = date });

            if (!result.Exists(delegate(StorageInfor1 match) { return match.IdTrungTam == 9; }))

                result.Add(new StorageInfor1 { IdTrungTam = 3, RunningDate = date });

            return result;

        }

        public List<ChungTuBanHangInfor> Search(TimKiemChungTuFilterInfor filter)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemCTPg,
                                                       filter.SoPhieu, filter.LoaiDonHang, filter.GiaoNhan,
                                                       filter.TrangThai, filter.IdTrungTam,
                                                       filter.IdKho, filter.SanPham, filter.MaHang, filter.LoaiMaHang,
                                                       filter.NhanVien, filter.IdNhanVien, clsUtils.DateValue(filter.TuNgay),
                                                       clsUtils.DateValue(filter.DenNgay),
                                                       filter.IdDoiTuong, filter.KhachHang, filter.DiaChi, filter.CMND,
                                                       filter.DienThoai, filter.GhiChu, filter.UserName, filter.Draft,
                                                       filter.DoanhThuTu,
                                                       filter.DoanhThuDen, filter.TinhTrangThanhToan, filter.SoBatDau,
                                                       filter.SoKetThuc);
        }
    }

    public class BaoCaoTonMaVachHienCoDao : Base3Dao
    {
        private static BaoCaoTonMaVachHienCoDao instance;

        private BaoCaoTonMaVachHienCoDao() { }

        public static BaoCaoTonMaVachHienCoDao Instance
        {
            get { return instance ?? (instance = new BaoCaoTonMaVachHienCoDao()); }
        }

        public List<StorageInfor2> GetListComputedStorage(StorageInfor2 storageInfo, IFilter2 filter, int defined)
        {
            var lstParas = new List<object>();
            
            string sqlCmdFormat = @"select {0}, count(*) amount
	                    from tbl_hanghoa_chitiet hhct
	                    left join tbl_hanghoa_chitiet hhcttc
		                    on hhcttc.idkho = -hhct.idkho
	                     and hhcttc.idsanpham = hhct.idsanpham
	                     and hhcttc.mavach = hhct.mavach {1}
                     where (hhct.soluong + nvl(hhcttc.soluong, 0) > 0) and {2}
                     group by {0} order by amount";
            
            var sqlFields = "hhct.idkho";

            var sqlJoins = String.Empty;

            var sqlWheres = @"hhct.idkho > 0";

            if(storageInfo == null)
            {
                if (filter.IdKho > 0)
                {
                    sqlWheres = @"hhct.idkho = :idkho";

                    lstParas.Add(filter.IdKho);
                }
                else if (filter.IdTrungTam > 0)
                {
                    sqlJoins = "inner join tbl_dm_kho kho on kho.idkho = hhct.idkho";

                    sqlWheres += " and kho.idtrungtam = :idtrungtam";

                    lstParas.Add(filter.IdTrungTam);
                }

                var nganh = filter.Nganh == String.Empty || filter.Nganh == "-1" ? String.Empty : filter.Nganh;

                if(filter.IdSanPham > 0)
                {
                    sqlFields += ", lsp.nganh, lsp.loai, lsp.chung, lsp.nhom, lsp.model, hhct.idsanpham";

                    sqlJoins +=
                        @" inner join tbl_sanpham sp
		                    on hhct.idsanpham = sp.idsanpham
                     inner join tbl_dm_loaisanpham lsp
		                    on sp.idcha = lsp.idloaisp";

                    sqlWheres += @" and hhct.idsanpham = :idsanpham";

                    lstParas.Add(filter.IdSanPham);
                } 
                else if (!String.IsNullOrEmpty(nganh))
                {
                    sqlFields += ", lsp.nganh";

                    sqlJoins +=
                        @" inner join tbl_sanpham sp
		                    on hhct.idsanpham = sp.idsanpham
                     inner join tbl_dm_loaisanpham lsp
		                    on sp.idcha = lsp.idloaisp";

                    sqlWheres += @" and lsp.nganh = :nganh";

                    lstParas.Add(nganh);
                }
            }
            else
            {
                sqlCmdFormat = @"select {0}, count(*) amount
	                    from tbl_hanghoa_chitiet hhct
	                    left join tbl_hanghoa_chitiet hhcttc
		                    on hhcttc.idkho = -:idkho
	                     and hhcttc.idsanpham = hhct.idsanpham
	                     and hhcttc.mavach = hhct.mavach {1}
                     where (hhct.soluong + nvl(hhcttc.soluong, 0) > 0) and {2}
                     group by {0} order by amount";

                sqlFields += ", lsp.nganh";

                sqlJoins = @"inner join tbl_sanpham sp
		                    on hhct.idsanpham = sp.idsanpham
                     inner join tbl_dm_loaisanpham lsp
		                    on sp.idcha = lsp.idloaisp";

                sqlWheres = @"hhct.idkho = :idkho";

                lstParas.Add(storageInfo.IdKho);

                if(!String.IsNullOrEmpty(storageInfo.Nganh))
                {
                    sqlFields += ", lsp.loai";

                    sqlWheres += @" and lsp.nganh = :nganh";

                    lstParas.Add(storageInfo.Nganh);

                    if(!String.IsNullOrEmpty(storageInfo.Loai))
                    {
                        sqlFields += ", lsp.chung";

                        sqlWheres += @" and lsp.loai = :loai";

                        lstParas.Add(storageInfo.Loai);

                        if (!String.IsNullOrEmpty(storageInfo.Chung))
                        {
                            sqlFields += ", lsp.nhom";

                            sqlWheres += @" and lsp.chung = :chung";

                            lstParas.Add(storageInfo.Chung);

                            if (!String.IsNullOrEmpty(storageInfo.Nhom))
                            {
                                sqlFields += ", lsp.model";

                                sqlWheres += @" and lsp.nhom = :nhom";

                                lstParas.Add(storageInfo.Nhom);

                                if (!String.IsNullOrEmpty(storageInfo.Model))
                                {
                                    sqlFields += ", hhct.idsanpham";

                                    sqlWheres += @" and lsp.model = :model";

                                    lstParas.Add(storageInfo.Model);

                                    if (storageInfo.IdSanPham > 0)
                                    {
                                        sqlFields += ", hhct.idphieunhap";

                                        sqlWheres += @" and hhct.idsanpham = :idsanpham";

                                        lstParas.Add(storageInfo.IdSanPham);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if(defined == 0)
            {
                sqlWheres += " and nvl(hhct.idphieunhap, 0) <= 0";
            }
            else
            {
                sqlWheres += " and nvl(hhct.idphieunhap, 0) > 0";
            }

            sqlCmdFormat = sqlCmdFormat.Replace("select ", String.Format("select {0} defined,", defined));

            var sqlCmd = String.Format(sqlCmdFormat, sqlFields, sqlJoins, sqlWheres);

            return GetListCommand<StorageInfor2>(sqlCmd, lstParas.ToArray());
        }

        public List<LichSuChiTietMaVachInfor> Search(IFilter2 filter, StorageInfor2 storageInfo)
        {
            var fi = (TimKiemChungTuChiTietFilterInfor) filter;

            if(storageInfo == null)
            {
                return
                    GetListCommand<LichSuChiTietMaVachInfor>(
                        Declare.StoreProcedureNamespace.spChungTuBanHangSearchTonMaVachPg,
                        fi.IdTrungTam, fi.IdKho, fi.IdSanPham, 0, fi.MaVach, fi.Nganh, String.Empty, String.Empty,
                        String.Empty, String.Empty, fi.SoTon, fi.LoaiDonHang, 0);
            }

            return
                GetListCommand<LichSuChiTietMaVachInfor>(
                    Declare.StoreProcedureNamespace.spChungTuBanHangSearchTonMaVachPg,
                    fi.IdTrungTam, storageInfo.IdKho, storageInfo.IdSanPham, storageInfo.IdPhieuNhap, fi.MaVach,
                    storageInfo.Nganh, storageInfo.Loai, storageInfo.Chung, storageInfo.Nhom, storageInfo.Model,
                    fi.SoTon, fi.LoaiDonHang, storageInfo.Defined);
        }
    }

    public class BaoCaoTonHienThoiDao : Base3Dao
    {
        private static BaoCaoTonHienThoiDao instance;

        private BaoCaoTonHienThoiDao() { }

        public static BaoCaoTonHienThoiDao Instance
        {
            get { return instance ?? (instance = new BaoCaoTonHienThoiDao()); }
        }

        public List<TonSanPhamHienCoInfor> TimKiemTonChiTietSanPhamPg(TimKiemChungTuChiTietFilterInfor filter)
        {
            return GetListCommand<TonSanPhamHienCoInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangSearchTonSanPhamPg,
                                                       filter.IdTrungTam, filter.IdKho, filter.SanPham, filter.SoBatDau, filter.SoKetThuc, filter.Nganh, filter.SoTon, filter.IdNhanVien);
        }
    }

    public class BaoCaoDanhSachDonHangHangBanDao : Base3Dao
    {
        private static BaoCaoDanhSachDonHangHangBanDao instance;

        private BaoCaoDanhSachDonHangHangBanDao() { }

        public static BaoCaoDanhSachDonHangHangBanDao Instance
        {
            get { return instance ?? (instance = new BaoCaoDanhSachDonHangHangBanDao()); }
        }
        public List<ChungTuBanHangInfor> TimKiemDonHangPg(TimKiemChungTuFilterInfor filter)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemDHPg,
                                                       filter.SoPhieu, filter.LoaiDonHang, filter.GiaoNhan, filter.TrangThai, filter.IdTrungTam,
                                                        filter.IdKho, filter.SanPham, filter.MaHang, filter.LoaiMaHang, filter.NhanVien, clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
                                                        filter.IdDoiTuong, filter.KhachHang, filter.DiaChi, filter.CMND, filter.DienThoai, filter.GhiChu, filter.UserName, filter.Draft, filter.DoanhThuTu,
                                                        filter.DoanhThuDen, filter.TinhTrangThanhToan, filter.SoBatDau, filter.SoKetThuc, filter.IdNhanVien, filter.IdNhomNguoiDung);
        }
    }

    public class BaoCaoChiTietPhieuThuChiDao : Base3Dao
    {
        private static BaoCaoChiTietPhieuThuChiDao instance;

        private BaoCaoChiTietPhieuThuChiDao() { }

        public static BaoCaoChiTietPhieuThuChiDao Instance
        {
            get { return instance ?? (instance = new BaoCaoChiTietPhieuThuChiDao()); }
        }
        public List<ChungTuThanhToanInfor> TimKiemPThuCTietPg(TimKiemPhieuThuFilterInfor filter)
        {
            return GetListCommand<ChungTuThanhToanInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemPTCTietPg,
                                                       filter.SoPhieu, filter.LoaiDonHang, filter.IdTrungTam, filter.NhanVien, filter.ThuNgan,
                                                       filter.KhachHang, clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
                                                       filter.DoanhThuTu, filter.DoanhThuDen, filter.SoTienThuTu, filter.SoTienThuDen, filter.IdHinhThucThanhToan, filter.IdThoiHanThanhToan,
                                                       filter.IdNganHang, filter.GhiChu, filter.UserName, filter.LoaiPhieu, filter.TaiKhoanQuy, filter.SoBatDau, filter.SoKetThuc, filter.IdNhanVien);
        }
    }

    public class BaoCaoDanhSachPhieuThuDao : Base3Dao
    {
        private static BaoCaoDanhSachPhieuThuDao instance;

        private BaoCaoDanhSachPhieuThuDao() { }

        public static BaoCaoDanhSachPhieuThuDao Instance
        {
            get { return instance ?? (instance = new BaoCaoDanhSachPhieuThuDao()); }
        }
        public List<ChungTuBanHangInfor> TimKiemPhieuThuPg(TimKiemChungTuFilterInfor filter)
        {
            return GetListCommand<ChungTuBanHangInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTimKiemPThuPg,
                                                       filter.SoPhieu, filter.LoaiDonHang, filter.GiaoNhan, filter.TrangThai, filter.IdTrungTam,
                                                        filter.IdKho, filter.SanPham, filter.MaHang, filter.LoaiMaHang, filter.NhanVien, clsUtils.DateValue(filter.TuNgay), clsUtils.DateValue(filter.DenNgay),
                                                        filter.IdDoiTuong, filter.KhachHang, filter.DiaChi, filter.CMND, filter.DienThoai, filter.GhiChu, filter.UserName, filter.Draft, filter.DoanhThuTu,
                                                        filter.DoanhThuDen, filter.TinhTrangThanhToan, filter.SoBatDau, filter.SoKetThuc, filter.IdNhanVien);
        }
    }
}