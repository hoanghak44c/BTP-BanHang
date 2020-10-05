using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Data;
using QLBH.Common;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.DAO;
using QLBH.Core.Business;
using QLBH.Core.Form;
using QLBH.Core.Providers;
using ItemTonKhoInfor = QLBanHang.Modules.BanHang.Infors.ItemTonKhoInfor;
using QLBanHang.Modules.DanhMuc.Providers;

// <Remarks>
// Tạo ChungTuBanHangDataProvider
// Người tạo: Lê Mạnh Tuấn
// Ngày tạo : 24/07/2012
// Người sửa cuối:
// </remarks>

namespace QLBanHang.Modules.BanHang.Providers
{
    public class BanHangDataProvider : BusinessProviderBase, IBussinessKeToanKhoProvider<ChungTuBanHangInfor, ChungTuBanHangChiTietInfor>
    {
        private static BanHangDataProvider instance;
        public static BanHangDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new BanHangDataProvider();
                return instance;
            }
        }
        #region chungtu
        //public List<ChungTuBanHangInfor> LoadAllChungTu(int loaiChungTu)
        //{
        //    return BanHangDAO.Instance.LoadAllChungTu(loaiChungTu);
        //}

        //public List<ChungTuBanHangInfor> LoadAllChungTuByLoaiCT(int loaiChungTu, string userName, int idKho)
        //{
        //    return BanHangDAO.Instance.LoadAllChungTuByLoaiCT(loaiChungTu, userName, idKho);
        //}

        public List<ChungTuBanHangInfor> LoadAllChungTuDatHangOnline(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien)
        {
            return BanHangDAO.Instance.LoadAllChungTuDatHangOnline(userName, idTrungTam, idKho, idDoiTuong, tuNgay, denNgay, loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien);
        }

        public List<ChungTuBanHangInfor> LoadAllChungTuXacNhanDHOL(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien)
        {
            return BanHangDAO.Instance.LoadAllChungTuXacNhanDHOL(userName, idTrungTam, idKho, idDoiTuong, tuNgay, denNgay, loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien);
        }

        public List<ChungTuBanHangInfor> LoadAllChungTuDatTruocHangMua(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien)
        {
            return BanHangDAO.Instance.LoadAllChungTuDatTruocHangMua(userName, idTrungTam, idKho, idDoiTuong, tuNgay, denNgay, loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien);
        }

        public List<ChungTuBanHangInfor> LoadAllChungTuDatHangTaiShop(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien)
        {
            return BanHangDAO.Instance.LoadAllChungTuDatHangTaiShop(userName, idTrungTam, idKho, idDoiTuong, tuNgay, denNgay, loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien);
        }

        public List<ChungTuBanHangInfor> LoadAllChungTuBuXuatBuKhuyenMai(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien)
        {
            return BanHangDAO.Instance.LoadAllChungTuBuXuatBuKhuyenMai(userName, idTrungTam, idKho, idDoiTuong, tuNgay, denNgay, loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien);
        }

        public List<ChungTuBanHangInfor> LoadAllChungTuCanThuTien(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien)
        {
            return BanHangDAO.Instance.LoadAllChungTuCanThuTien(userName, idTrungTam, idKho, idDoiTuong, tuNgay, denNgay, loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien);
        }
        public List<ChungTuBanHangInfor> LoadAllChungTuPhanCongGiaoNhan(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien, int idHuyen)
        {
            return BanHangDAO.Instance.LoadAllChungTuPhanCongGiaoNhan(userName, idTrungTam, idKho, idDoiTuong, tuNgay, denNgay, loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien, idHuyen);
        }
        public List<ChungTuBanHangInfor> LoadAllChungTuPhanDonGiaoNhan(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien, int idHuyen)
        {
            return BanHangDAO.Instance.LoadAllChungTuPhanDonGiaoNhan(userName, idTrungTam, idKho, idDoiTuong, tuNgay, denNgay, loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien, idHuyen);
        }
        public List<ChungTuBanHangInfor> LoadAllXacNhanPhanDonGiaoNhan(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien, int idHuyen)
        {
            return BanHangDAO.Instance.LoadAllXacNhanPhanDonGiaoNhan(userName, idTrungTam, idKho, idDoiTuong, tuNgay, denNgay, loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien, idHuyen);
        }

        public List<ChungTuBanHangInfor> LoadAllChungTuTTPhanCongGiaoNhan(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien)
        {
            return BanHangDAO.Instance.LoadAllChungTuTTPhanCongGiaoNhan(userName, idTrungTam, idKho, idDoiTuong, tuNgay, denNgay, loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien);
        }

        public List<ChungTuBanHangInfor> LoadAllChungTuTTPhanCongGiaoNhanS(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien)
        {
            return BanHangDAO.Instance.LoadAllChungTuTTPhanCongGiaoNhanS(userName, idTrungTam, idKho, idDoiTuong, tuNgay, denNgay, loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien);
        }

        public List<ChungTuBanHangInfor> LoadAllChungTuXuatKhoBan(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien)
        {
            return BanHangDAO.Instance.LoadAllChungTuXuatKhoBan(userName, idTrungTam, idKho, idDoiTuong, tuNgay, denNgay, loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien);
        }

        public List<ChungTuBanHangInfor> LoadAllChungTuTraLaiHangBan(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien)
        {
            return BanHangDAO.Instance.LoadAllChungTuTraLaiHangBan(userName, idTrungTam, idKho, idDoiTuong, tuNgay, denNgay, loaiDH, trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, idNhanVien);
        }

        public ChungTuBanHangInfor LoadChungTuById(int idChungTu)
        {
            return BanHangDAO.Instance.LoadChungTuById(idChungTu);
        }
        public List<ChungTuBanHangInfor> LoadAllPhieuXuatByIdCTuGoc(int idChungTu)
        {
            return BanHangDAO.Instance.LoadAllPhieuXuatByIdCTuGoc(idChungTu);
        }
        public ChungTuBanHangInfor LoadChungTuBySoChungTu(string soChungTu, int idLoaiChungTu)
        {
            return BanHangDAO.Instance.LoadChungTuBySoChungTu(soChungTu, idLoaiChungTu);
        }
        public ChungTuBanHangInfor LoadChungTuBySoChungTu(string soChungTu, string soHoaDon)
        {
            return BanHangDAO.Instance.LoadChungTuBySoChungTu(soChungTu, soHoaDon);
        }
        public ChungTuBanHangInfor LoadChungTuBySoChTu(string soChungTu)
        {
            return BanHangDAO.Instance.LoadChungTuBySoChTu(soChungTu);
        }

        public void DeleteChungTu(int idChungTu)
        {
            BanHangDAO.Instance.DeleteChungTu(idChungTu);
        }

        public void DeleteAllChungTu(int idChungTu)
        {
            BanHangDAO.Instance.DeleteAllChungTu(idChungTu);
        }

        public void UpdateChungTu(ChungTuBanHangInfor chungTu)
        {
            BanHangDAO.Instance.UpdateChungTu(chungTu);
        }

        //public void UpdateCongNoKhachHang(int idKhachLe, int idKhachHang, double tongTien, double tienNo, double tongTienOld, double tienNoOld, int loaiChungTu)
        //{
        //    BanHangDAO.Instance.UpdateCongNoKhachHang(idKhachLe, idKhachHang, tongTien, tienNo, tongTienOld, tienNoOld, loaiChungTu);
        //}

        public void KhoaChungTu(int idChungTu, int trangThai)
        {
            BanHangDAO.Instance.KhoaChungTu(idChungTu, trangThai);
        }

        public void UpdateDaTichDiem(int idChungTu, int daTichDiem, int idTheTVien, string tenLoaiThe, int soDiemTichLuy)
        {
            BanHangDAO.Instance.UpdateDaTichDiem(idChungTu, daTichDiem, idTheTVien, tenLoaiThe, soDiemTichLuy);
        }

        public void UpdateTrangThaiChungTu(int idChungTu, int trangThai)
        {
            BanHangDAO.Instance.UpdateTrangThaiChungTu(idChungTu, trangThai);
        }

        public void UpdateTrangThaiChungTu(string soChungTu, int trangThai)
        {
            BanHangDAO.Instance.UpdateTrangThaiChungTu(soChungTu, trangThai);
        }

        public bool CheckValid_TrangThai_ChungTu(int idChungTu, string trangThai)
        {
            return BanHangDAO.Instance.CheckValid_TrangThai_ChungTu(idChungTu, trangThai);
        }

        //public bool CheckValid_TrangThai_Draft(int idChungTu)
        //{
        //    return BanHangDAO.Instance.CheckValid_TrangThai_Draft(idChungTu);
        //}

        public bool CheckValid_ChungTu_TraLai(int idChungTu)//kiem tra xem co don hang tra lai hay chua
        {
            return BanHangDAO.Instance.CheckValid_ChungTu_TraLai(idChungTu);
        }

        public int InsertChungTu(ChungTuBanHangInfor chungTu)
        {
            return BanHangDAO.Instance.InsertChungTu(chungTu);
        }

        public void CapNhatNgayInHoaDon(int idChungTu, string nguoiSua, string maySua, DateTime ngayHoaDon)
        {
            BanHangDAO.Instance.CapNhatNgayInHoaDon(idChungTu, nguoiSua, maySua, ngayHoaDon);
        }

        public ChungTuBanHangInfor LoadChungTu(int loaiChungTu, string soChungTu, int loaiTruong, int idChungTu)
        {
            List<ChungTuBanHangInfor> liCT = BanHangDAO.Instance.SearchChungTu(loaiChungTu, soChungTu, loaiTruong,
                                                                               idChungTu);
            if (liCT != null && liCT.Count > 0)
                return liCT[0];
            return null;
        }
        public bool ExistNoKhuyenMai(string soChungTu, string maSanPham, int idSanPhamBan, int soLuong)
        {
            return BanHangDAO.Instance.ExistNoKhuyenMai(soChungTu, maSanPham, idSanPhamBan, soLuong);
        }
        
        public bool ExistChungTu(int loaiChungTu, string soChungTu, int loaiTruong, int idChungTu)
        {
            return BanHangDAO.Instance.ExistChungTu(loaiChungTu, soChungTu, loaiTruong, idChungTu);
        }

        public bool ExistChungTu(int loaiChungTu, string soChungTu, int loaiTruong, int idChungTu, DateTime tuNgay, DateTime denNgay)
        {
            return BanHangDAO.Instance.ExistsChungTuByDate(loaiChungTu, soChungTu, loaiTruong, idChungTu, tuNgay, denNgay);
        }

        public bool ExistChungTuDaMua(int loaiChungTu, string soChungTu, string soCMND, string soDienThoai, double giatriHD, int ngayTruocDo, int idChungTu)
        {
            return BanHangDAO.Instance.ExistChungTuDaMua(
                loaiChungTu, soChungTu, soCMND, soDienThoai, giatriHD,
                ngayTruocDo, idChungTu);
        }

        public int SoChungTuDaMua(int idTrungTam, int idKho, string maHang, int loaiHang, DateTime tuNgay, DateTime denNgay, string soCMND, string soDienThoai)
        {
            TimKiemChungTuFilterInfor filter = new TimKiemChungTuFilterInfor();
            filter.IdTrungTam = idTrungTam;
            filter.IdKho = idKho;
            filter.MaHang = maHang;
            filter.LoaiMaHang = loaiHang;
            filter.TuNgay = tuNgay;
            filter.DenNgay = denNgay;
            filter.CMND = soCMND;
            filter.DienThoai = soDienThoai;
            return BanHangDAO.Instance.TimKiemChungTu(filter).Count;
        }
        public bool ValidMaChietKhau(int idDKMua, int idsanpham, double giaBan)
        {
            List<DMSanPhamPairInfo> liChiTiet = BanHangDAO.Instance.ValidMaChietKhau(idDKMua, idsanpham, giaBan);
            if (liChiTiet.Count > 0)
                return true;
            return false;
        }
        public int SoLuongMatHangDaMua(int idTrungTam, int idKho, string maHang, int loaiHang, DateTime tuNgay, DateTime denNgay, string soCMND, string soDienThoai, int idChinhSach, int idChungTu)
        {
            TimKiemChungTuFilterInfor filter = new TimKiemChungTuFilterInfor();
            filter.IdTrungTam = idTrungTam;
            filter.IdKho = idKho;
            filter.MaHang = maHang;
            filter.LoaiMaHang = loaiHang;
            filter.TuNgay = tuNgay;
            filter.DenNgay = denNgay;
            filter.CMND = soCMND;
            filter.DienThoai = soDienThoai;
            filter.IdChinhSach = idChinhSach;
            List<ChungTuBanHangChiTietInfor> liChiTiet = BanHangDAO.Instance.TimKiemChungTuChinhSach(filter);
            int total = 0;
            foreach (ChungTuBanHangChiTietInfor ct in liChiTiet)
            {
                if (idChungTu != ct.IdChungTu)
                    total += ct.SoLuong;
            }
            return total;
        }
        public bool ExistMatHangDaMua(string soChungTu, string maHang, int loaiHang, DateTime denNgay)
        {
            bool rs = false;
            TimKiemChungTuFilterInfor filter = new TimKiemChungTuFilterInfor();
            filter.SoPhieu = soChungTu;
            filter.MaHang = maHang;
            filter.LoaiMaHang = loaiHang;
            //filter.TuNgay = tuNgay;
            filter.DenNgay = denNgay;
            if (BanHangDAO.Instance.TimKiemChungTu(filter).Count > 0)
                rs = true;
            return rs;
        }

        public bool DaNhapTraLai(int loaiChungTu, string soChungTu, int loaiTruong)
        {
            return BanHangDAO.Instance.ExistChungTu(loaiChungTu, soChungTu, loaiTruong, 0);
        }

        public List<ChungTuThanhToanInfor> TimKiemPhieuThu(TimKiemPhieuThuFilterInfor filter)
        {
            return BanHangDAO.Instance.TimKiemPhieuThu(filter);
        }
        //public List<ChungTuThanhToanInfor> TimKiemPThuCTietPg(TimKiemPhieuThuFilterInfor filter)
        //{
        //    return BanHangDAO.Instance.TimKiemPThuCTietPg(filter);
        //}

        public List<ChungTuThanhToanBCInfor> TimKiemDoanhSoTongHopPg(TimKiemChungTuFilterInfor filter)
        {
            return BanHangDAO.Instance.TimKiemDoanhSoTongHopPg(filter);
        }

        public List<ChungTuBanHangBCTheoGioInfor> TimKiemBanHangKhungGioNganhPg(TimKiemChungTuFilterInfor filter)
        {
            return BanHangDAO.Instance.TimKiemBanHangKhungGioNganhPg(filter);
        }

        public List<ChungTuBanHangBCTheoGioInfor> TimKiemBanHangKhungGioTuanPg(TimKiemChungTuFilterInfor filter)
        {
            return BanHangDAO.Instance.TimKiemBanHangKhungGioTuanPg(filter);
        }

        public List<ChungTuThanhToanBCInfor> TimKiemDoanhSoCTietPg(TimKiemChungTuFilterInfor filter)
        {
            return BanHangDAO.Instance.TimKiemDoanhSoCTietPg(filter);
        }

        //public void TimKiemDoanhSoCTietPg(TimKiemChungTuFilterInfor filter, DataTable dataTable)
        //{
        //    BanHangDAO.Instance.TimKiemDoanhSoCTietPg(filter, dataTable);

        //    if (dataTable.PrimaryKey.Length == 0)
        //    {
        //        dataTable.PrimaryKey = new[] { dataTable.Columns["idchitiet"] };
        //    }
        //}

        public List<ChungTuBanHangInfor> TimKiemChungTu(TimKiemChungTuFilterInfor filter)
        {
            return BanHangDAO.Instance.TimKiemChungTu(filter);
        }
        public List<ChungTuBanHangInfor> TimKiemChungTuChinhSachThe(string maTrungTam, int idLoaiDoiTuong, int idChinhSachThe)
        {
            return BanHangDAO.Instance.TimKiemChungTuChinhSachThe(maTrungTam, idLoaiDoiTuong, idChinhSachThe);
        }
        //public List<ChungTuBanHangInfor> TimKiemKhachHangPg(TimKiemChungTuFilterInfor filter)
        //{
        //    return BanHangDAO.Instance.TimKiemKhachHangPg(filter);
        //}
        //public List<ChungTuBanHangInfor> TimKiemChungTuPg(TimKiemChungTuFilterInfor filter)
        //{
        //    return BanHangDAO.Instance.TimKiemChungTuPg(filter);
        //}
        //public List<ChungTuBanHangInfor> TimKiemDonHangPg(TimKiemChungTuFilterInfor filter)
        //{
        //    return BanHangDAO.Instance.TimKiemDonHangPg(filter);
        //}
        public List<ChungTuBanHangInfor> TimKiemKhoaDonHangPg(TimKiemChungTuFilterInfor filter)
        {
            return BanHangDAO.Instance.TimKiemKhoaDonHangPg(filter);
        }
        public List<ChungTuBanHangInfor> TimKiemDonHangTheThanhVien(int idKhachLe)
        {
            return BanHangDAO.Instance.TimKiemDonHangTheThanhVien(idKhachLe);
        }
        public List<ChungTuBanHangInfor> TimKiemDonHangKhachHang(int idKhachHang)
        {
            return BanHangDAO.Instance.TimKiemDonHangKhachHang(idKhachHang);
        }
        //public List<ChungTuBanHangInfor> TimKiemPhieuThuPg(TimKiemChungTuFilterInfor filter)
        //{
        //    return BanHangDAO.Instance.TimKiemPhieuThuPg(filter);
        //}
        public List<ChungTuBanHangInfor> TimKiemCongNoPg(TimKiemChungTuFilterInfor filter)
        {
            return BanHangDAO.Instance.TimKiemCongNoPg(filter);
        }
        public List<ChungTuBanHangBCInfor> TimKiemChungTuGiaoNhan(TimKiemChungTuFilterInfor filter)
        {
            return BanHangDAO.Instance.TimKiemChungTuGiaoNhan(filter);
        }
        //public List<ChungTuBanHangBCInfor> TimKiemChungTuGiaoNhanPg(TimKiemChungTuFilterInfor filter)
        //{
        //    return BanHangDAO.Instance.TimKiemChungTuGiaoNhanPg(filter);
        //}
        //public List<ChungTuBanHangGNhanCTietInfor> TimKiemChungTuGiaoNhanCTiet(TimKiemChungTuFilterInfor filter)
        //{
        //    return BanHangDAO.Instance.TimKiemChungTuGiaoNhanCTiet(filter);
        //}
        public List<ChungTuBanHangGNhanCTietInfor> TimKiemChungTuGiaoNhanCTietPg(TimKiemChungTuFilterInfor filter)
        {
            return BanHangDAO.Instance.TimKiemChungTuGiaoNhanCTietPg(filter);
        }
        //public List<ChungTuBanHangGNhanCTietInfor> TimKiemChungTuGiaoNhanCTietKThuatPg(TimKiemGiaoNhanFilterInfor filter)
        //{
        //    return BanHangDAO.Instance.TimKiemChungTuGiaoNhanCTietKThuatPg(filter);
        //}
        //public List<ChungTuBanHangGNhanCTietInfor> TimKiemChungTuGiaoNhanCTietKThuatCTPg(TimKiemGiaoNhanFilterInfor filter)
        //{
        //    return BanHangDAO.Instance.TimKiemChungTuGiaoNhanCTietKThuatCTPg(filter);
        //}
        public List<ChungTuBanHangGNhanKThuatInfor> TimKiemChungTuGiaoNhanThongKeKThuatCTPg(TimKiemGiaoNhanFilterInfor filter)
        {
            return BanHangDAO.Instance.TimKiemChungTuGiaoNhanThongKeKThuatCTPg(filter);
        }

        public List<ChungTuBanHangChiTietBCInfor> TimKiemChungTuChiTiet(TimKiemChungTuChiTietFilterInfor filter)
        {
            return BanHangDAO.Instance.TimKiemChungTuChiTiet(filter);
        }
        //public List<ChungTuBanHangChiTietBCInfor> TimKiemChungTuChiTietPg(TimKiemChungTuChiTietFilterInfor filter)
        //{
        //    return BanHangDAO.Instance.TimKiemChungTuChiTietPg(filter);
        //}
        public void TimKiemChungTuChiTietPg(TimKiemChungTuChiTietFilterInfor filter, DataTable dataTable)
        {
            BanHangDAO.Instance.TimKiemChungTuChiTietPg(filter, dataTable);

            if (dataTable.PrimaryKey.Length == 0)
            {
                dataTable.PrimaryKey = new[] { dataTable.Columns["IDCHUNGTUCHITIET"] };
            }
        }
        public DataSet TimKiemChungTuChiTietAll(TimKiemChungTuChiTietFilterInfor filter)
        {
            return BanHangDAO.Instance.TimKiemChungTuChiTietAll(filter);
        }
        public List<ChungTuBanHangChiTietBCInfor> TimKiemChungTuChiTietNoKMPg(TimKiemChungTuChiTietFilterInfor filter)
        {
            return BanHangDAO.Instance.TimKiemChungTuChiTietNoKMPg(filter);
        }
        public DataTable TimKiemChungTuChiTietOld(TimKiemChungTuChiTietFilterInfor filter)
        {
            return BanHangDAO.Instance.TimKiemChungTuChiTietOld(filter);
        }
        public List<ChungTuBanHangChiTietHangHoaBCInfor> TimKiemChungTuChiTietMaVach(TimKiemChungTuChiTietFilterInfor filter)
        {
            return BanHangDAO.Instance.TimKiemChungTuChiTietMaVach(filter);
        }
        public List<ChungTuBanHangChiTietHangHoaBCInfor> TimKiemChungTuChiTietMaVachPg(TimKiemChungTuChiTietFilterInfor filter)
        {
            return BanHangDAO.Instance.TimKiemChungTuChiTietMaVachPg(filter);
        }
        
        //public void TimKiemChungTuChiTietMaVachPg(TimKiemChungTuChiTietFilterInfor filter, DataTable dataTable)
        //{
        //    BanHangDAO.Instance.TimKiemChungTuChiTietMaVachPg(filter, dataTable);

        //    if (dataTable.PrimaryKey.Length == 0)
        //    {
        //        dataTable.PrimaryKey = new[]
        //                                   {
        //                                       dataTable.Columns["IDCHUNGTUCHITIET"],

        //                                       dataTable.Columns["IDCHITIETHANGHOA"]
        //                                   };
        //    }
        //}

        public List<ChungTuBanHangChiTietHangHoaBCInfor> TimKiemChungTuChiTietChuaXuatDuPg(TimKiemChungTuChiTietFilterInfor filter)
        {
            return BanHangDAO.Instance.TimKiemChungTuChiTietChuaXuatDuPg(filter);
        }
        public List<ChungTuBanHangChiTietHangHoaBHInfor> TimKiemChungTuChiTietMaVachBaoHanh(TimKiemChungTuChiTietFilterInfor filter)
        {
            return BanHangDAO.Instance.TimKiemChungTuChiTietMaVachBaoHanh(filter);
        }
        //public List<ChungTuBanHangChiTietHangHoaBHInfor> TimKiemChungTuChiTietMaVachBaoHanhPg(TimKiemChungTuChiTietFilterInfor filter)
        //{
        //    return BanHangDAO.Instance.TimKiemChungTuChiTietMaVachBaoHanhPg(filter);
        //}

        public List<ChungTuBanHangChiTietHangHoaBHInfor> TimKiemChungTuChiTietMaVachTonKho(TimKiemChungTuChiTietFilterInfor filter)
        {
            return BanHangDAO.Instance.TimKiemChungTuChiTietMaVachTonKho(filter);
        }
        public List<ChungTuBanHangChiTietHangHoaBHInfor> TimKiemChungTuChiTietMaVachTonKhoPg(TimKiemChungTuChiTietFilterInfor filter)
        {
            return BanHangDAO.Instance.TimKiemChungTuChiTietMaVachTonKhoPg(filter);
        }

        public List<ChungTuBanHangInfor> TimKiemChungTuNoKhuyenMai(TimKiemChungTuFilterInfor filter)
        {
            return BanHangDAO.Instance.TimKiemChungTuNoKhuyenMai(filter);
        }
        //public List<LichSuChiTietMaVachInfor> TimKiemLichSuChiTietMaVach(TimKiemChungTuChiTietFilterInfor filter)
        //{
        //    return BanHangDAO.Instance.TimKiemLichSuChiTietMaVach(filter);
        //}
        public List<LichSuChiTietMaVachInfor> TimKiemTonChiTietMaVach(TimKiemChungTuChiTietFilterInfor filter)
        {
            return BanHangDAO.Instance.TimKiemTonChiTietMaVach(filter);
        }
        public List<LichSuChiTietMaVachInfor> TimKiemTonChiTietMaVachPg(TimKiemChungTuChiTietFilterInfor filter)
        {
            return BanHangDAO.Instance.TimKiemTonChiTietMaVachPg(filter);
        }
        //public List<TonSanPhamHienCoInfor> TimKiemTonChiTietSanPhamPg(TimKiemChungTuChiTietFilterInfor filter)
        //{
        //    return BanHangDAO.Instance.TimKiemTonChiTietSanPhamPg(filter);
        //}

        /// <summary>
        /// Tìm kiếm phiếu điều chuyển
        /// </summary>
        /// <param name="soPhieuDC"></param>
        /// <param name="soHoaDonDC"></param>
        /// <param name="nhanVienGiao"></param>
        /// <param name="hangHoa"></param>
        /// <param name="idKhoDi"></param>
        /// <param name="idKhoDen"></param>
        /// <param name="ngayBatDau"></param>
        /// <param name="ngayKetThuc"></param>
        /// <param name="trangThai"></param>
        /// <param name="type">0: tìm chính xác soPhieuDC, -1: tìm dạng like</param>
        /// <returns></returns>
        public List<ChungTuBanHangInfor> SearchChungTuDieuChuyen(string soPhieuDC, string soHoaDonDC, string nhanVienGiao, string hangHoa, int idKhoDi, int idKhoDen, DateTime ngayBatDau, DateTime ngayKetThuc, int trangThai, int type)
        {
            return BanHangDAO.Instance.SearchChungTuDieuChuyen(soPhieuDC, soHoaDonDC, nhanVienGiao, hangHoa, idKhoDi, idKhoDen, ngayBatDau, ngayKetThuc, trangThai, type);
        }
        public bool ExistPhieuDieuChuyen(string soPhieuDC, int idKhoDi, int idKhoDen, int type)
        {
            List<ChungTuBanHangInfor> liPhieuDC = SearchChungTuDieuChuyen(soPhieuDC, "", "", "", idKhoDi, idKhoDen,
                                                                          DateTime.MinValue, DateTime.MinValue, -1, type);
            return liPhieuDC != null && liPhieuDC.Count > 0 ? true : false;
        }
        public string ExistListPhieuDC(string lstSoPhieuDC, int idKhoDi, int idKhoDen, int type)
        {
            string[] arrSoPhieuDC = lstSoPhieuDC.Split(";".ToCharArray());
            string invalidPDC = "";
            foreach (string pdc in arrSoPhieuDC)
            {
                if (!ExistPhieuDieuChuyen(pdc, idKhoDi, idKhoDen, type))
                {
                    invalidPDC = pdc + ";";
                }
            }

            return invalidPDC;
        }
        #endregion

        #region chungtu chitiet
        public List<ChungTuBanHangChiTietInfor> GetListChiTietChungTuByIdChungTu(int idChungTu)
        {
            return BanHangDAO.Instance.GetListChiTietChungTuByIdChungTu(idChungTu);
        }
        public List<ChungTuBanHangChiTietInfor> GetListChiTietChungTuKhuyenMai(int idChungTu, int idSanPham)
        {
            return BanHangDAO.Instance.GetListChiTietChungTuKhuyenMai(idChungTu, idSanPham);
        }
        public List<DanhSachHangXuatBanInfor> GetAllChiTietXuatKhoByIdChungTu(int idChungTu)
        {
            return BanHangDAO.Instance.GetAllChiTietXuatKhoByIdChungTu(idChungTu);
        }
        
        public List<ChungTuBanHangChiTietInfor> GetListChiTietChungTuNoKhuyenMai(int idChungTu, int idKho)
        {
            return BanHangDAO.Instance.GetListChiTietChungTuNoKhuyenMai(idChungTu, idKho);
        }

        public List<HangBanGiaoNhanChiTietInfor> GetListChiTietChungTuByListIdChungTu(string lstIdChungTu)
        {
            return BanHangDAO.Instance.GetListChiTietChungTuByListIdChungTu(lstIdChungTu);
        }

        public ChungTuBanHangChiTietInfor GetChiTietChungTuByIdChiTiet(int idChiTiet)
        {
            return BanHangDAO.Instance.GetChiTietChungTuByIdChiTiet(idChiTiet);
        }

        public int InsertChiTietChungTu(ChungTuBanHangChiTietInfor chiTietChungTu)
        {
            return BanHangDAO.Instance.InsertChiTietChungTu(chiTietChungTu);
        }

        public void DeleteChiTietChungTu(ChungTuBanHangChiTietInfor chiTietChungTu)
        {
            BanHangDAO.Instance.DeleteChiTietChungTu(chiTietChungTu);
        }

        public void DeleteChiTietChungTu(int idChiTietChungTu)
        {
            BanHangDAO.Instance.DeleteChiTietChungTu(idChiTietChungTu);
        }

        public void UpdateChiTietChungTu(ChungTuBanHangChiTietInfor chiTietChungTu)
        {
            BanHangDAO.Instance.UpdateChiTietChungTu(chiTietChungTu);
        }

        /// <summary>
        /// Xoa/Khoi phuc no khuyen mai
        /// </summary>
        /// <param name="idChiTietChungTu"></param>
        /// <param name="isDelete">1: xoa; 2:khoi phuc</param>
        public void XoaKhuyenMai(int idChiTietChungTu, int isDelete)
        {
            BanHangDAO.Instance.XoaKhuyenMai(idChiTietChungTu, isDelete);
        }
        #endregion

        #region chungtu thanh toan
        public List<ChungTuThanhToanInfor> GetListChungTuThanhToanByIdChungTu(int idChungTu)
        {
            return BanHangDAO.Instance.GetListChungTuThanhToanByIdChungTu(idChungTu);
        }


        public void DeleteChungTuThanhToanByIdChungTu(int idChungTu)
        {
            BanHangDAO.Instance.DeleteChungTuThanhToanByIdChungTu(idChungTu);
        }


        public void InsertChungTuThanhToan(ChungTuThanhToanInfor chungTuThanhToan)
        {
            BanHangDAO.Instance.InsertChungTuThanhToan(chungTuThanhToan);
        }

        #endregion

        #region bao cao
        public List<DanhSachBaoCaoBanHangInfor> GetListBaoCaoTongHopBanHang()
        {
            return BanHangDAO.Instance.GetListBaoCaoTongHopBanHang();
        }
        public DataSet LoadBaoCao(string store, int idTrungTam, DateTime start, DateTime end)
        {
            return BanHangDAO.Instance.LoadBaoCao(store, idTrungTam, start, end);
        }
        #endregion

        #region utils
        public List<ItemTonKhoInfor> LoadTonKhoTheoTrungTam(int idSanPham, int soTon)
        {
            return BanHangDAO.Instance.LoadTonKhoTheoTrungTam(idSanPham, soTon);
        }
        public void ConvertListChiTiet2BanKMai(List<ChungTuBanHangChiTietInfor> lstChiTietChungTu, ref List<ChungTuBanHangChiTietInfor> lstHangBan, ref List<ChungTuBanHangChiTietInfor> lstHangKhuyenMai)
        {
            lstHangBan = new List<ChungTuBanHangChiTietInfor>();
            lstHangKhuyenMai = new List<ChungTuBanHangChiTietInfor>();
            foreach (ChungTuBanHangChiTietInfor tmp in lstChiTietChungTu)
            {
                if (tmp.IdSanPhamBan != 0 && tmp.LoaiHangKem == 0)
                    lstHangKhuyenMai.Add(tmp);
                else
                    lstHangBan.Add(tmp);
            }
        }

        public void MergeListBanKMai2ChiTiet(ref List<ChungTuBanHangChiTietInfor> lstChiTietChungTu, List<ChungTuBanHangChiTietInfor> lstHangBan, List<ChungTuBanHangChiTietInfor> lstHangKhuyenMai)
        {
            lstChiTietChungTu = new List<ChungTuBanHangChiTietInfor>();
            lstChiTietChungTu.AddRange(lstHangBan);
            lstChiTietChungTu.AddRange(lstHangKhuyenMai);
        }
        public void ConvertListChiTiet2GiaoNhan(List<ChungTuBanHangChiTietInfor> lstChiTietChungTu, ref List<ChungTuBanHangChiTietInfor> lstHangBan, ref List<ChungTuBanHangChiTietInfor> lstHangGiaoNhan)
        {
            lstHangBan = new List<ChungTuBanHangChiTietInfor>();
            lstHangGiaoNhan = new List<ChungTuBanHangChiTietInfor>();
            foreach (ChungTuBanHangChiTietInfor tmp in lstChiTietChungTu)
            {
                if (tmp.IdSanPhamBan == -1)
                    lstHangGiaoNhan.Add(tmp);
                else
                    lstHangBan.Add(tmp);
            }
        }

        public void MergeListBanGNhan2ChiTiet(ref List<ChungTuBanHangChiTietInfor> lstChiTietChungTu, List<ChungTuBanHangChiTietInfor> lstHangBan, List<ChungTuBanHangChiTietInfor> lstHangGiaoNhan)
        {
            lstChiTietChungTu = new List<ChungTuBanHangChiTietInfor>();
            lstChiTietChungTu.AddRange(lstHangBan);
            lstChiTietChungTu.AddRange(lstHangGiaoNhan);
        }
        public void ConvertListChiTiet2HangBan(List<ChungTuBanHangChiTietInfor> lstChiTietChungTu, ref List<DanhSachHangBanChiTietInfor> lstHangBan)
        {
            lstHangBan = new List<DanhSachHangBanChiTietInfor>();
            foreach (ChungTuBanHangChiTietInfor ct in lstChiTietChungTu)
            {
                if (ct.SoLuong > 0)
                {
                    DanhSachHangBanChiTietInfor hb = new DanhSachHangBanChiTietInfor();
                    hb.IdChiTietChungTu = ct.IdChungTuChiTiet;
                    hb.IdSanPham = ct.IdSanPham;
                    hb.MaSanPham = ct.MaSanPham;
                    hb.TenSanPham = ct.TenSanPham;
                    hb.IdSanPhamBan = ct.IdSanPhamBan;
                    hb.TenSanPhamBan = ct.TenSanPhamBan;
                    hb.ChietKhau = ct.ChietKhau;
                    hb.LoaiHangHoa = (ct.IdSanPhamBan == 0
                                          ? Declare.DescHangBan
                                          : (ct.IdSanPhamBan == -1
                                                 ? Declare.DescGiaoNhan
                                                 : (ct.LoaiHangKem == 1 ? Declare.DescHangKem : Declare.DescKhuyenMai)));
                    hb.TypeHangHoa = (ct.IdSanPhamBan == 0
                                          ? 0
                                          : (ct.IdSanPhamBan == -1
                                                 ? -1
                                                 : (ct.LoaiHangKem == 1 ? 1 : 2)));
                    hb.DonViTinh = ct.DonViTinh;
                    hb.SoLuongBan = ct.SoLuong;
                    hb.SoLuongXuat = Common.Int2Bool(ct.ChietKhau) ? ct.SoLuong : 0;
                    hb.TrungMaVach = ct.TrungMaVach;
                    lstHangBan.Add(hb);
                }
            }
        }

        public ChungTuBanHangChiTietInfor ConvertBG2SanPhamBan(BangGiaBanChiTietInfor sp)
        {
            ChungTuBanHangChiTietInfor ctu = new ChungTuBanHangChiTietInfor();
            ctu.IdSanPham = sp.IdSanPham;
            ctu.MaSanPham = sp.MaSanPham;
            ctu.TenSanPham = sp.TenSanPham;
            ctu.DonViTinh = sp.TenDonViTinh;
            ctu.DonGia = sp.DonGiaChuaVAT;
            ctu.DonGiaCoVat = sp.DonGiaCoVAT;
            ctu.TyleChietKhau = 0;// sp.TyLeChietKhau;
            ctu.TienChietKhau = 0;// sp.TienChietKhau;
            ctu.SoLuong = 1;
            ctu.TienSauChietKhau = sp.DonGiaChuaVAT - 0;// sp.TienChietKhau;
            ctu.TyleVAT = sp.TyLeVAT;
            ctu.TienVAT = sp.TienVAT;
            ctu.ThanhTien = sp.DonGiaCoVAT;
            ctu.TyleThuong = sp.TyLeThuong;
            ctu.ThuongNong = sp.ThuongNong;
            ctu.TrungMaVach = sp.TrungMaVach;
            ctu.TrangThai = "";
            ctu.NoKhuyenMai = 0;
            ctu.GiaTheoBangGia = sp.DonGiaCoVAT;
            ctu.GiaNiemYet = sp.GiaNiemYet;
            ctu.GiaWebSite = sp.GiaWebSite;
            ctu.IdSanPhamBan = 0;
            ctu.TenSanPhamBan = "";
            ctu.GhiChu = "";
            ctu.LinhVuc = sp.LinhVuc;
            ctu.Nganh = sp.Nganh;
            ctu.Loai = sp.Loai;
            ctu.Chung = sp.Chung;
            ctu.Nhom = sp.Nhom;
            ctu.Hang = sp.Hang;
            ctu.Model = sp.Model;
            ctu.LoaiHangKem = 0;
            ctu.TenLoaiHangKem = Declare.DescHangBan;
            ctu.ChietKhau = sp.ChietKhau;
            ctu.TyLeThanhToan = 100;
            ctu.SoLuongOld = 1;
            ctu.TonKho = sp.TonAo;
            ctu.TyLeDiemThuongMacDinh = sp.TyLeDiemThuongMacDinh;

            return ctu;
        }

        public ChungTuBanHangChiTietInfor ConvertSanPhamBan2BaoCao(ChungTuBanHangChiTietInfor ct, bool isKM)
        {
            ChungTuBanHangChiTietInfor ctu = new ChungTuBanHangChiTietInfor();
            ctu.IdSanPham = ct.IdSanPham;
            ctu.MaSanPham = ct.MaSanPham;
            ctu.TenSanPham = ct.TenSanPham;
            ctu.DonViTinh = (ct.DonViTinh.Length > 5) ? ct.DonViTinh.Substring(0, 5) : ct.DonViTinh;
            ctu.DonGia = ct.CSachChietKhau != null ? 0 : ct.DonGia;
            ctu.DonGiaCoVat = ct.CSachChietKhau != null ? 0 : ct.DonGiaCoVat;
            ctu.TyleChietKhau = ct.CSachChietKhau != null ? 0 : ct.TyleChietKhau;
            ctu.TienChietKhau = ct.CSachChietKhau != null ? 0 : ct.TienChietKhau;
            ctu.SoLuong = ct.SoLuong;
            ctu.TienSauChietKhau = (ct.CSachChietKhau != null || isKM) ? 0 : ct.TienSauChietKhau;// sp.TienChietKhau;
            ctu.TyleVAT = (ct.CSachChietKhau != null) ? 0 : ct.TyleVAT;
            ctu.TienVAT = (ct.CSachChietKhau != null || isKM) ? 0 : ct.TienVAT;
            ctu.ThanhTien = (ct.CSachChietKhau != null || isKM) ? 0 : ct.ThanhTien;
            ctu.TyleThuong = ct.TyleThuong;
            ctu.ThuongNong = ct.ThuongNong;
            ctu.TrungMaVach = ct.TrungMaVach;
            ctu.TrangThai = ct.TrangThai;
            ctu.NoKhuyenMai = ct.NoKhuyenMai;
            ctu.GiaTheoBangGia = ct.GiaTheoBangGia;
            ctu.GiaNiemYet = ct.GiaNiemYet;
            ctu.GiaWebSite = ct.GiaWebSite;
            ctu.IdSanPhamBan = ct.IdSanPhamBan;
            ctu.TenSanPhamBan = ct.TenSanPhamBan;
            ctu.GhiChu = ct.GhiChu;
            ctu.LinhVuc = ct.LinhVuc;
            ctu.Nganh = ct.Nganh;
            ctu.Loai = ct.Loai;
            ctu.Chung = ct.Chung;
            ctu.Nhom = ct.Nhom;
            ctu.Hang = ct.Hang;
            ctu.Model = ct.Model;
            ctu.LoaiHangKem = ct.LoaiHangKem;
            ctu.TenLoaiHangKem = ct.TenLoaiHangKem;
            ctu.ChietKhau = ct.ChietKhau;
            ctu.TyLeThanhToan = ct.TyLeThanhToan;
            ctu.TyLeVATText = DmSanPhamProvider.GetSanPhamById(ctu.IdSanPham).TaxCode.Contains("KCT") ||
                (ct.IdSanPhamBan > 0 && ct.LoaiHangKem == 0 && ct.TyleVAT == 0) ? "" : ct.TyleVAT.ToString();
            
            ctu.InHoaDon = ct.InHoaDon;

            //ctu.DonGia = (ctu.IdSanPhamBan > 0 && ctu.LoaiHangKem == 0) ? 0 : ct.DonGia;
            //ctu.DonGiaCoVat = (ctu.IdSanPhamBan > 0 && ctu.LoaiHangKem == 0) ? 0 : ct.DonGiaCoVat;
            //ctu.TyleChietKhau = (ctu.IdSanPhamBan > 0 && ctu.LoaiHangKem == 0) ? 0 : ct.TyleChietKhau;
            //ctu.TienChietKhau = (ctu.IdSanPhamBan > 0 && ctu.LoaiHangKem == 0) ? 0 : ct.TienChietKhau;
            //ctu.SoLuong = ct.SoLuong;
            //ctu.TienSauChietKhau = (ctu.IdSanPhamBan > 0 && ctu.LoaiHangKem == 0) ? 0 : ct.TienSauChietKhau;// sp.TienChietKhau;
            //ctu.TyleVAT = (ctu.IdSanPhamBan > 0 && ctu.LoaiHangKem == 0) ? 0 : ct.TyleVAT;
            //ctu.TienVAT = (ctu.IdSanPhamBan > 0 && ctu.LoaiHangKem == 0) ? 0 : ct.TienVAT;
            //ctu.ThanhTien = (ctu.IdSanPhamBan > 0 && ctu.LoaiHangKem == 0) ? 0 : ct.ThanhTien;

            return ctu;
        }

        public ChungTuBanHangChiTietInfor ConvertBG2SanPhamKM(BangGiaBanChiTietInfor sp)
        {
            ChungTuBanHangChiTietInfor ctu = new ChungTuBanHangChiTietInfor();
            ctu.IdSanPham = sp.IdSanPham;
            ctu.MaSanPham = sp.MaSanPham;
            ctu.TenSanPham = sp.TenSanPham;
            ctu.DonViTinh = sp.TenDonViTinh;
            ctu.DonGia = 0;// sp.DonGiaChuaVAT;
            ctu.DonGiaCoVat = 0;// sp.DonGiaCoVAT;
            ctu.TyleChietKhau = 0;// sp.TyLeChietKhau;
            ctu.TienChietKhau = 0;// sp.TienChietKhau;
            ctu.SoLuong = 1;
            ctu.TienSauChietKhau = 0;//sp.DonGiaChuaVAT - 0;// sp.TienChietKhau;
            ctu.TyleVAT = 0;//sp.TyLeVAT;
            ctu.TienVAT = 0;//sp.TienVAT;
            ctu.ThanhTien = 0;// sp.DonGiaCoVAT;
            ctu.TyleThuong = 0;//sp.TyLeThuong;
            ctu.ThuongNong = 0;//sp.ThuongNong;
            ctu.TrungMaVach = sp.TrungMaVach;
            ctu.TrangThai = "";
            ctu.NoKhuyenMai = 0;
            ctu.GiaTheoBangGia = sp.DonGiaCoVAT;
            ctu.GiaNiemYet = sp.GiaNiemYet;
            ctu.GiaWebSite = sp.GiaWebSite;
            ctu.IdSanPhamBan = 0;
            ctu.TenSanPhamBan = "";
            ctu.GhiChu = "";
            ctu.LinhVuc = sp.LinhVuc;
            ctu.Nganh = sp.Nganh;
            ctu.Loai = sp.Loai;
            ctu.Chung = sp.Chung;
            ctu.Nhom = sp.Nhom;
            ctu.Hang = sp.Hang;
            ctu.Model = sp.Model;
            ctu.LoaiHangKem = 0;
            ctu.TenLoaiHangKem = Declare.DescKhuyenMai;
            ctu.ChietKhau = sp.ChietKhau;
            //HaH: 04/05/2013 them vao de check ton
            ctu.TonKho = sp.TonKho; 

            return ctu;
        }

        public ChungTuBanHangChiTietInfor ConvertNoKM2SanPhamKM(ChungTuBanHangChiTietInfor sp)
        {
            ChungTuBanHangChiTietInfor ctu = new ChungTuBanHangChiTietInfor();
            ctu.IdSanPham = sp.IdSanPham;
            ctu.MaSanPham = sp.MaSanPham;
            ctu.TenSanPham = sp.TenSanPham;
            ctu.DonViTinh = sp.DonViTinh;
            ctu.DonGia = 0;// sp.DonGiaChuaVAT;
            ctu.DonGiaCoVat = 0;// sp.DonGiaCoVAT;
            ctu.TyleChietKhau = 0;// sp.TyLeChietKhau;
            ctu.TienChietKhau = 0;// sp.TienChietKhau;
            ctu.SoLuong = 1;
            ctu.TienSauChietKhau = 0;//sp.DonGiaChuaVAT - 0;// sp.TienChietKhau;
            ctu.TyleVAT = 0;//sp.TyLeVAT;
            ctu.TienVAT = 0;//sp.TienVAT;
            ctu.ThanhTien = 0;// sp.DonGiaCoVAT;
            ctu.TyleThuong = 0;//sp.TyLeThuong;
            ctu.ThuongNong = 0;//sp.ThuongNong;
            ctu.TrungMaVach = sp.TrungMaVach;
            ctu.TrangThai = "";
            ctu.NoKhuyenMai = 0;
            ctu.GiaTheoBangGia = sp.GiaTheoBangGia;
            ctu.GiaNiemYet = sp.GiaNiemYet;
            ctu.GiaWebSite = sp.GiaWebSite;
            ctu.IdSanPhamBan = sp.IdSanPhamBan;
            ctu.TenSanPhamBan = sp.TenSanPhamBan;
            ctu.GhiChu = "";
            ctu.LinhVuc = sp.LinhVuc;
            ctu.Nganh = sp.Nganh;
            ctu.Loai = sp.Loai;
            ctu.Chung = sp.Chung;
            ctu.Nhom = sp.Nhom;
            ctu.Hang = sp.Hang;
            ctu.Model = sp.Model;
            ctu.LoaiHangKem = 0;
            ctu.TenLoaiHangKem = Declare.DescKhuyenMai;
            ctu.ChietKhau = sp.ChietKhau;
            //HaH: 04/05/2013 them vao de check ton
            ctu.TonKho = sp.TonKho;

            return ctu;
        }

        public ChungTuBanHangChiTietInfor ConvertBG2SanPhamGNhan(BangGiaBanChiTietInfor sp)
        {
            ChungTuBanHangChiTietInfor ctu = new ChungTuBanHangChiTietInfor();
            ctu.IdSanPham = sp.IdSanPham;
            ctu.MaSanPham = sp.MaSanPham;
            ctu.TenSanPham = sp.TenSanPham;
            ctu.DonViTinh = sp.TenDonViTinh;
            ctu.DonGia = sp.DonGiaChuaVAT;
            ctu.DonGiaCoVat = sp.DonGiaCoVAT;
            ctu.TyleChietKhau = 0;// sp.TyLeChietKhau;
            ctu.TienChietKhau = 0;// sp.TienChietKhau;
            ctu.SoLuong = 1;
            ctu.TienSauChietKhau = sp.DonGiaChuaVAT - 0;// sp.TienChietKhau;
            ctu.TyleVAT = sp.TyLeVAT;
            ctu.TienVAT = sp.TienVAT;
            ctu.ThanhTien = sp.DonGiaCoVAT;
            ctu.TyleThuong = sp.TyLeThuong;
            ctu.ThuongNong = sp.ThuongNong;
            ctu.TrungMaVach = sp.TrungMaVach;
            ctu.TrangThai = "";
            ctu.NoKhuyenMai = 0;
            ctu.GiaTheoBangGia = sp.DonGiaCoVAT;
            ctu.GiaNiemYet = sp.GiaNiemYet;
            ctu.GiaWebSite = sp.GiaWebSite;
            ctu.IdSanPhamBan = -1;
            ctu.TenSanPhamBan = "";
            ctu.GhiChu = "";
            ctu.TenLoaiHangKem = Declare.DescGiaoNhan;
            ctu.ChietKhau = sp.ChietKhau;

            return ctu;
        }

        //public ChungTuBanHangChiTietInfor ConvertKM2SanPhamBan(BangGiaHangKhuyenMaiChiTietInfor km)
        //{
        //    ChungTuBanHangChiTietInfor ctu = new ChungTuBanHangChiTietInfor();
        //    ctu.IdSanPham = km.IdSanPham;
        //    ctu.MaSanPham = km.MaSanPham;
        //    ctu.TenSanPham = km.TenSanPham;
        //    ctu.DonViTinh = km.DonViTinh;
        //    ctu.DonGia = 0;
        //    ctu.DonGiaCoVat = 0;
        //    ctu.TyleChietKhau = 0;
        //    ctu.TienChietKhau = 0;
        //    ctu.TienSauChietKhau = 0;
        //    ctu.SoLuong = Common.Int2Bool(km.ChietKhau) ? 0 : (Common.Int2Bool(km.DuHang) ? km.SoLuongKM : 0);
        //    ctu.TienSauChietKhau = 0;
        //    ctu.TyleVAT = -1;
        //    ctu.TienVAT = 0;
        //    ctu.ThanhTien = Common.Int2Bool(km.ChietKhau) ? -km.SoTienCK : km.SoTienCK;
        //    ctu.TyleThuong = 0;
        //    ctu.ThuongNong = 0;
        //    ctu.TrungMaVach = km.TrungMaVach;
        //    ctu.TrangThai = "";//Common.Int2Bool(km.DuHang) ? "" : "Nợ khuyến mại";
        //    ctu.NoKhuyenMai = Common.Int2Bool(km.ChietKhau) ? 0 : (Common.Int2Bool(km.DuHang) ? 0 : km.SoLuongKM);
        //    ctu.GiaTheoBangGia = 0;
        //    ctu.GiaNiemYet = 0;
        //    ctu.GiaWebSite = 0;
        //    ctu.GhiChu = "";
        //    ctu.TenLoaiHangKem = Declare.DescHangBan;
        //    ctu.ChietKhau = km.ChietKhau;
            
        //    return ctu;
        //}
        #endregion

        public bool ExistChungTuKetChuyen(string soChungTu, int loaiChungTu)
        {
            return BanHangDAO.Instance.ExistChungTuKetChuyen(soChungTu, loaiChungTu);
        }

        public bool ExistChungTuXuatKho(string soChungTu)
        {
            return BanHangDAO.Instance.ExistChungTuXuatKho(soChungTu);
        }
        public bool ValidMaVach(string lstIdDKMua, string maVach)
        {
            return BanHangDAO.Instance.ValidMaVach(lstIdDKMua, maVach);
        }
        public bool ExistPhieuTraHangMua(string soChungTu)
        {
            return BanHangDAO.Instance.ExistPhieuTraHangMua(soChungTu);
        }
    }

    public class BaoCaoGiaoNhanDataProvider : IBcDataProvider<ChungTuBanHangBCInfor>
    {
        private static BaoCaoGiaoNhanDataProvider instance;

        public static BaoCaoGiaoNhanDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new BaoCaoGiaoNhanDataProvider();
                return instance;
            }
        }

        #region Implementation of IBcDataProvider<ChungTuBanHangBCInfor>

        public List<StorageInfor1> GetListComputedStorage(DateTime date, int idTrungTam)
        {
            return BaoCaoGiaoNhanDao.Instance.GetListComputedStorage(date, idTrungTam);
        }

        public List<ChungTuBanHangBCInfor> Search(IFilter filter)
        {
            return BaoCaoGiaoNhanDao.Instance.Search(filter as TimKiemChungTuFilterInfor);
        }

        #endregion
    }

    public class BaoCaoGiaoNhanChiTietKThuatDataProvider : IBcDataProvider<ChungTuBanHangGNhanCTietInfor>
    {
        private static BaoCaoGiaoNhanChiTietKThuatDataProvider instance;

        public static BaoCaoGiaoNhanChiTietKThuatDataProvider Instance
        {
            get { return instance ?? (instance = new BaoCaoGiaoNhanChiTietKThuatDataProvider()); }
        }

        #region Implementation of IBcDataProvider<ChungTuBanHangGNhanCTietInfor>

        public List<StorageInfor1> GetListComputedStorage(DateTime date, int idTrungTam)
        {
            return BaoCaoGiaoNhanChiTietKThuatDao.Instance.GetListComputedStorage(date, idTrungTam);
        }

        public List<ChungTuBanHangGNhanCTietInfor> Search(IFilter filter)
        {
            return BaoCaoGiaoNhanChiTietKThuatDao.Instance.Search(filter as TimKiemGiaoNhanFilterInfor);
        }

        #endregion
    }

    public class TimKiemDonHangDataProvider : IBcDataProvider<ChungTuBanHangInfor>
    {
        private static TimKiemDonHangDataProvider instance;

        public static TimKiemDonHangDataProvider Instance
        {
            get { return instance ?? (instance = new TimKiemDonHangDataProvider()); }
        }

        #region Implementation of IBcDataProvider<ChungTuBanHangInfor>

        public List<StorageInfor1> GetListComputedStorage(DateTime date, int idTrungTam)
        {
            return TimKiemDonHangDao.Instance.GetListComputedStorage(date, idTrungTam);
        }

        public List<ChungTuBanHangInfor> Search(IFilter filter)
        {
            //return BanHangDAO.Instance.TimKiemChungTuPg(filter as TimKiemChungTuFilterInfor);
            return TimKiemDonHangDao.Instance.Search(filter as TimKiemChungTuFilterInfor);
        }

        #endregion
    }

    public class NhatKyHoatDongMaVachDataProvider
    {
        private static NhatKyHoatDongMaVachDataProvider instance;

        public static NhatKyHoatDongMaVachDataProvider Instance
        {
            get { return instance ?? (instance = new NhatKyHoatDongMaVachDataProvider()); }
        }
        public List<LichSuChiTietMaVachInfor> TimKiemLichSuChiTietMaVach(TimKiemChungTuChiTietFilterInfor filter)
        {
            return NhatKyHoatDongMaVachDao.Instance.TimKiemLichSuChiTietMaVach(filter);
        }
    }

    public class TimKiemKhachMuaHangDataProvider : IBcDataProvider<ChungTuBanHangInfor>
    {
        private static TimKiemKhachMuaHangDataProvider instance;

        public static TimKiemKhachMuaHangDataProvider Instance
        {
            get { return instance ?? (instance = new TimKiemKhachMuaHangDataProvider()); }
        }

        #region Implementation of IBcDataProvider<ChungTuBanHangInfor>

        public List<StorageInfor1> GetListComputedStorage(DateTime date, int idTrungTam)
        {
            return TimKiemKhachMuaHangDao.Instance.GetListComputedStorage(date, idTrungTam);
        }

        public List<ChungTuBanHangInfor> Search(IFilter filter)
        {
            return TimKiemKhachMuaHangDao.Instance.Search(filter as TimKiemChungTuFilterInfor);
        }

        #endregion
    }

    public class BaoCaoDonHangChuaXuatDuDataProvider : IBcDataProvider<ChungTuBanHangChiTietHangHoaBCInfor>
    {
        private static BaoCaoDonHangChuaXuatDuDataProvider instance;

        public static BaoCaoDonHangChuaXuatDuDataProvider Instance
        {
            get { return instance ?? (instance = new BaoCaoDonHangChuaXuatDuDataProvider()); }
        }

        #region Implementation of IBcDataProvider<ChungTuBanHangInfor>

        public List<StorageInfor1> GetListComputedStorage(DateTime date, int idTrungTam)
        {
            return BaoCaoDonHangChuaXuatDuDao.Instance.GetListComputedStorage(date, idTrungTam);
        }

        public List<ChungTuBanHangChiTietHangHoaBCInfor> Search(IFilter filter)
        {
            return BaoCaoDonHangChuaXuatDuDao.Instance.Search(filter as TimKiemChungTuChiTietFilterInfor);
        }

        #endregion
    }

    public class BaoCaoTonMaVachHienCoDataProvider : IBcDataProvider2<LichSuChiTietMaVachInfor>
    {
        private static BaoCaoTonMaVachHienCoDataProvider instance;

        public static BaoCaoTonMaVachHienCoDataProvider Instance
        {
            get { return instance ?? (instance = new BaoCaoTonMaVachHienCoDataProvider()); }
        }

        #region Implementation of IBcDataProvider2<LichSuChiTietMaVachInfor>

        public List<StorageInfor2> GetListComputedStorage(StorageInfor2 storageInfo, IFilter2 filter, int defined)
        {
            return BaoCaoTonMaVachHienCoDao.Instance.GetListComputedStorage(storageInfo, filter, defined);
        }

        public List<LichSuChiTietMaVachInfor> Search(IFilter2 filter, StorageInfor2 storageInfo)
        {
            return BaoCaoTonMaVachHienCoDao.Instance.Search(filter, storageInfo);
        }

        #endregion
    }

    public class BaoCaoTonHienThoiDataProvider
    {
        private static BaoCaoTonHienThoiDataProvider instance;

        public static BaoCaoTonHienThoiDataProvider Instance
        {
            get { return instance ?? (instance = new BaoCaoTonHienThoiDataProvider()); }
        }

        public List<TonSanPhamHienCoInfor> TimKiemTonChiTietSanPhamPg(TimKiemChungTuChiTietFilterInfor filter)
        {
            return BaoCaoTonHienThoiDao.Instance.TimKiemTonChiTietSanPhamPg(filter);
        }
    }

    public class BaoCaoDanhSachDonHangBanDataProvider
    {
        private static BaoCaoDanhSachDonHangBanDataProvider instance;

        public static BaoCaoDanhSachDonHangBanDataProvider Instance
        {
            get { return instance ?? (instance = new BaoCaoDanhSachDonHangBanDataProvider()); }
        }
        public List<ChungTuBanHangInfor> TimKiemDonHangPg(TimKiemChungTuFilterInfor filter)
        {
            return BaoCaoDanhSachDonHangHangBanDao.Instance.TimKiemDonHangPg(filter);
        }
    }

    public class BaoCaoChiTietPhieuThuChiDataProvider
    {
        private static BaoCaoChiTietPhieuThuChiDataProvider instance;

        public static BaoCaoChiTietPhieuThuChiDataProvider Instance
        {
            get { return instance ?? (instance = new BaoCaoChiTietPhieuThuChiDataProvider()); }
        }
        public List<ChungTuThanhToanInfor> TimKiemPThuCTietPg(TimKiemPhieuThuFilterInfor filter)
        {
            return BaoCaoChiTietPhieuThuChiDao.Instance.TimKiemPThuCTietPg(filter);
        }
    }

    public class BaoCaoDanhSachPhieuThuDataProvider
    {
        private static BaoCaoDanhSachPhieuThuDataProvider instance;

        public static BaoCaoDanhSachPhieuThuDataProvider Instance
        {
            get { return instance ?? (instance = new BaoCaoDanhSachPhieuThuDataProvider()); }
        }
        public List<ChungTuBanHangInfor> TimKiemPhieuThuPg(TimKiemChungTuFilterInfor filter)
        {
            return BaoCaoDanhSachPhieuThuDao.Instance.TimKiemPhieuThuPg(filter);
        }
    }
}
