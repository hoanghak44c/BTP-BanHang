using System;
using System.Collections;
using System.Collections.Generic;
using QLBH.Core.Data;
using QLBH.Common;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.DAO;
using QLBH.Core.Business;
using QLBH.Core.Providers;

// <Remarks>
// Tạo ChungTuBanHangDataProvider
// Người tạo: Lê Mạnh Tuấn
// Ngày tạo : 24/07/2012
// Người sửa cuối:
// </remarks>

namespace QLBanHang.Modules.BanHang.Providers
{
    public class LapPhieuXuatKhoDataProvider : BusinessProviderBase, IBussinessKhoProvider<ChungTuBanHangInfor, ChungTuBanHangChiTietInfor, ChungTuBanHangChiTietHangHoaInfor>
        , IBussinessKeToanKhoProvider<ChungTuBanHangInfor, ChungTuBanHangChiTietInfor>
    {
        private static LapPhieuXuatKhoDataProvider instance;
        public static LapPhieuXuatKhoDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new LapPhieuXuatKhoDataProvider();
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

        //public List<ChungTuBanHangInfor> LoadAllChungTuDatHangOnline(string userName, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu)
        //{
        //    return BanHangDAO.Instance.LoadAllChungTuDatHangOnline(userName, idKho, idDoiTuong, tuNgay, denNgay, loaiDH, trangThaiDH, draft, ghiChu);
        //}

        //public List<ChungTuBanHangInfor> LoadAllChungTuXacNhanDHOL(string userName, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu)
        //{
        //    return BanHangDAO.Instance.LoadAllChungTuXacNhanDHOL(userName, idKho, idDoiTuong, tuNgay, denNgay, loaiDH, trangThaiDH, draft, ghiChu);
        //}

        //public List<ChungTuBanHangInfor> LoadAllChungTuDatTruocHangMua(string userName, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu)
        //{
        //    return BanHangDAO.Instance.LoadAllChungTuDatTruocHangMua(userName, idKho, idDoiTuong, tuNgay, denNgay, loaiDH, trangThaiDH, draft, ghiChu);
        //}

        //public List<ChungTuBanHangInfor> LoadAllChungTuDatHangTaiShop(string userName, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu)
        //{
        //    return BanHangDAO.Instance.LoadAllChungTuDatHangTaiShop(userName, idKho, idDoiTuong, tuNgay, denNgay, loaiDH, trangThaiDH, draft, ghiChu);
        //}

        //public List<ChungTuBanHangInfor> LoadAllChungTuPhanCongGiaoNhan(string userName, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu)
        //{
        //    return BanHangDAO.Instance.LoadAllChungTuPhanCongGiaoNhan(userName, idKho, idDoiTuong, tuNgay, denNgay, loaiDH, trangThaiDH, draft, ghiChu);
        //}

        //public List<ChungTuBanHangInfor> LoadAllChungTuXuatKhoBan(string userName, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu)
        //{
        //    return BanHangDAO.Instance.LoadAllChungTuXuatKhoBan(userName, idKho, idDoiTuong, tuNgay, denNgay, loaiDH, trangThaiDH, draft, ghiChu);
        //}

        public List<ChungTuBanHangInfor> LoadAllPhieuXuat(int idChungTu)
        {
            return BanHangDAO.Instance.LoadAllPhieuXuat(idChungTu);
        }

        public ChungTuBanHangInfor LoadChungTuById(int idChungTu)
        {
            return BanHangDAO.Instance.LoadChungTuById(idChungTu);
        }

        public void DeleteChungTu(int idChungTu)
        {
            BanHangDAO.Instance.DeleteChungTu(idChungTu);
        }

        public void UpdateChungTu(ChungTuBanHangInfor chungTu)
        {
            BanHangDAO.Instance.UpdateChungTu(chungTu);
        }

        public int InsertChungTu(ChungTuBanHangInfor chungTu)
        {
            return BanHangDAO.Instance.InsertChungTu(chungTu);
        }

        //public ChungTuBanHangInfor LoadChungTu(int loaiChungTu, string soChungTu, int loaiTruong, int idChungTu)
        //{
        //    List<ChungTuBanHangInfor> liCT = BanHangDAO.Instance.SearchChungTu(loaiChungTu, soChungTu, loaiTruong,
        //                                                                       idChungTu);
        //    if (liCT != null && liCT.Count > 0)
        //        return liCT[0];
        //    return null;
        //}
        //public bool ExistChungTu(int loaiChungTu, string soChungTu, int loaiTruong, int idChungTu)
        //{
        //    bool rs = false;
        //    if (BanHangDAO.Instance.SearchChungTu(loaiChungTu, soChungTu, loaiTruong, idChungTu).Count > 0)
        //        rs = true;
        //    return rs;
        //}
        //public bool ExistChungTu(int loaiChungTu, string soChungTu, int loaiTruong, int idChungTu, DateTime tuNgay, DateTime denNgay)
        //{
        //    bool rs = false;
        //    if (BanHangDAO.Instance.SearchChungTuByDate(loaiChungTu, soChungTu, loaiTruong, idChungTu, tuNgay, denNgay).Count > 0)
        //        rs = true;
        //    return rs;
        //}
        //public bool ExistChungTuDaMua(int loaiChungTu, string soChungTu, string soCMND, string soDienThoai, double giatriHD, int ngayTruocDo, int idChungTu)
        //{
        //    bool rs = false;
        //    if (BanHangDAO.Instance.SearchChungTuDaMua(loaiChungTu, soChungTu, soCMND, soDienThoai, giatriHD, ngayTruocDo, idChungTu).Count > 0)
        //        rs = true;
        //    return rs;
        //}
        //public bool DaNhapTraLai(int loaiChungTu, string soChungTu, int loaiTruong)
        //{
        //    bool rs = false;
        //    if (BanHangDAO.Instance.SearchChungTu(loaiChungTu, soChungTu, loaiTruong, 0).Count > 0)
        //        rs = true;
        //    return rs;
        //}

        //public List<ChungTuTimKiemInfor> TimKiemChungTu(TimKiemChungTuFilterInfor filter)
        //{
        //    return BanHangDAO.Instance.TimKiemChungTu(filter);
        //}

        #endregion

        #region chungtu chitiet
        public List<ChungTuBanHangChiTietInfor> GetListChiTietChungTuByIdChungTu(int idChungTu)
        {
            return Origin(BanHangDAO.Instance.GetListChiTietChungTuByIdChungTu(idChungTu));
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

        public void UpdateChiTietChungTu(ChungTuBanHangChiTietInfor chiTietChungTu)
        {
            BanHangDAO.Instance.UpdateChiTietChungTu(chiTietChungTu);
        }

        //public void ConvertListChiTiet2BanKMai(List<ChungTuBanHangChiTietInfor> lstChiTietChungTu, ref List<ChungTuBanHangChiTietInfor> lstHangBan, ref List<ChungTuBanHangChiTietInfor> lstHangKhuyenMai)
        //{
        //    lstHangBan = new List<ChungTuBanHangChiTietInfor>();
        //    lstHangKhuyenMai = new List<ChungTuBanHangChiTietInfor>();
        //    foreach (ChungTuBanHangChiTietInfor tmp in lstChiTietChungTu)
        //    {
        //        if (tmp.IdSanPhamBan != 0 && tmp.LoaiHangKem == 0)
        //            lstHangKhuyenMai.Add(tmp);
        //        else
        //            lstHangBan.Add(tmp);
        //    }
        //}

        //public void MergeListBanKMai2ChiTiet(ref List<ChungTuBanHangChiTietInfor> lstChiTietChungTu, List<ChungTuBanHangChiTietInfor> lstHangBan, List<ChungTuBanHangChiTietInfor> lstHangKhuyenMai)
        //{
        //    lstChiTietChungTu = new List<ChungTuBanHangChiTietInfor>();
        //    lstChiTietChungTu.AddRange(lstHangBan);
        //    lstChiTietChungTu.AddRange(lstHangKhuyenMai);
        //}
        //public void ConvertListChiTiet2GiaoNhan(List<ChungTuBanHangChiTietInfor> lstChiTietChungTu, ref List<ChungTuBanHangChiTietInfor> lstHangBan, ref List<ChungTuBanHangChiTietInfor> lstHangGiaoNhan)
        //{
        //    lstHangBan = new List<ChungTuBanHangChiTietInfor>();
        //    lstHangGiaoNhan = new List<ChungTuBanHangChiTietInfor>();
        //    foreach (ChungTuBanHangChiTietInfor tmp in lstChiTietChungTu)
        //    {
        //        if (tmp.IdSanPhamBan == -1)
        //            lstHangGiaoNhan.Add(tmp);
        //        else
        //            lstHangBan.Add(tmp);
        //    }
        //}

        //public void MergeListBanGNhan2ChiTiet(ref List<ChungTuBanHangChiTietInfor> lstChiTietChungTu, List<ChungTuBanHangChiTietInfor> lstHangBan, List<ChungTuBanHangChiTietInfor> lstHangGiaoNhan)
        //{
        //    lstChiTietChungTu = new List<ChungTuBanHangChiTietInfor>();
        //    lstChiTietChungTu.AddRange(lstHangBan);
        //    lstChiTietChungTu.AddRange(lstHangGiaoNhan);
        //}
        //public void ConvertListChiTiet2HangBan(List<ChungTuBanHangChiTietInfor> lstChiTietChungTu, ref List<DanhSachHangBanChiTietInfor> lstHangBan)
        //{
        //    lstHangBan = new List<DanhSachHangBanChiTietInfor>();
        //    foreach (ChungTuBanHangChiTietInfor ct in lstChiTietChungTu)
        //    {
        //        if (ct.SoLuong > 0)
        //        {
        //            DanhSachHangBanChiTietInfor hb = new DanhSachHangBanChiTietInfor();
        //            hb.IdChiTietChungTu = ct.IdChungTuChiTiet;
        //            hb.IdSanPham = ct.IdSanPham;
        //            hb.MaSanPham = ct.MaSanPham;
        //            hb.TenSanPham = ct.TenSanPham;
        //            hb.IdSanPhamBan = ct.IdSanPhamBan;
        //            hb.TenSanPhamBan = ct.TenSanPhamBan;
        //            hb.ChietKhau = ct.ChietKhau;
        //            hb.LoaiHangHoa = (ct.IdSanPhamBan == 0
        //                                  ? Declare.DescHangBan
        //                                  : (ct.IdSanPhamBan == -1
        //                                         ? Declare.DescGiaoNhan
        //                                         : (ct.LoaiHangKem == 1 ? Declare.DescHangKem : Declare.DescKhuyenMai)));
        //            hb.TypeHangHoa = (ct.IdSanPhamBan == 0
        //                                  ? 0
        //                                  : (ct.IdSanPhamBan == -1
        //                                         ? -1
        //                                         : (ct.LoaiHangKem == 1 ? 1 : 2)));
        //            hb.DonViTinh = ct.DonViTinh;
        //            hb.SoLuongBan = ct.SoLuong;
        //            hb.SoLuongXuat = Common.Int2Bool(ct.ChietKhau) ? ct.SoLuong : 0;
        //            hb.TrungMaVach = ct.TrungMaVach;
        //            lstHangBan.Add(hb);
        //        }
        //    }
        //}
        #endregion

        #region chungtu chitiet hang hoa
        public List<ChungTuBanHangChiTietHangHoaInfor> GetListChiTietHangHoaByIdChungTu(int idChungTu)
        {
            return Origin(BanHangDAO.Instance.GetListChiTietHangHoaByIdChungTu(idChungTu));
        }

        public List<ChungTuBanHangChiTietHangHoaInfor> GetAllListChiTietHangHoaByIdChungTu(int idChungTu, int idKho)
        {
            return Origin(BanHangDAO.Instance.GetAllListChiTietHangHoaByIdChungTu(idChungTu, idKho));
        }

        public List<ChungTuBanHangChiTietHangHoaInfor> GetAllListChiTietHangHoaByMaxMaVach(int idChungTu, int idKho)
        {
            return Origin(BanHangDAO.Instance.GetAllListChiTietHangHoaByMaxMaVach(idChungTu, idKho));
        }

        public List<ChungTuBanHangChiTietHangHoaInfor> GetChiTietHangHoaByMaVach(string code, int idKho)
        {
            return Origin(BanHangDAO.Instance.GetChiTietHangHoaByMaVach(code, idKho));
        }

        public List<ChungTuBanHangChiTietHangHoaInfor> GetListChiTietHangHoaByPhieuDC(string soPhieuDieuChuyen, string soChungTu)
        {
            return BanHangDAO.Instance.GetListChiTietHangHoaByPhieuDC(soPhieuDieuChuyen, soChungTu);
        }

        public void DeleteChiTietHangHoa(ChungTuBanHangChiTietHangHoaInfor chiTietHangHoa)
        {
            BanHangDAO.Instance.DeleteChiTietHangHoa(chiTietHangHoa);
        }

        public void DeleteChiTietHangHoaByChiTiet(ChungTuBanHangChiTietHangHoaInfor chiTietHangHoa)
        {
            BanHangDAO.Instance.DeleteChiTietHangHoaByChiTiet(chiTietHangHoa);
        }

        public void InsertChiTietHangHoa(ChungTuBanHangChiTietHangHoaInfor chiTietHangHoa)
        {
            BanHangDAO.Instance.InsertChiTietHangHoa(chiTietHangHoa);
        }

        public void UpdateChiTietHangHoa(ChungTuBanHangChiTietHangHoaInfor chiTietHangHoa)
        {
            BanHangDAO.Instance.UpdateChiTietHangHoa(chiTietHangHoa);
        }
        #endregion


        #region chungtu thanh toan
        //public List<ChungTuThanhToanInfor> GetListChungTuThanhToanByIdChungTu(int idChungTu)
        //{
        //    return BanHangDAO.Instance.GetListChungTuThanhToanByIdChungTu(idChungTu);
        //}


        //public void DeleteChungTuThanhToanByIdChungTu(int idChungTu)
        //{
        //    BanHangDAO.Instance.DeleteChungTuThanhToanByIdChungTu(idChungTu);
        //}


        //public void InsertChungTuThanhToan(ChungTuThanhToanInfor chungTuThanhToan)
        //{
        //    BanHangDAO.Instance.InsertChungTuThanhToan(chungTuThanhToan);
        //}

        //public ChungTuBanHangChiTietInfor ConvertBG2SanPhamBan(BangGiaBanChiTietInfor sp)
        //{
        //    ChungTuBanHangChiTietInfor ctu = new ChungTuBanHangChiTietInfor();
        //    ctu.IdSanPham = sp.IdSanPham;
        //    ctu.MaSanPham = sp.MaSanPham;
        //    ctu.TenSanPham = sp.TenSanPham;
        //    ctu.DonViTinh = sp.TenDonViTinh;
        //    ctu.DonGia = sp.DonGiaChuaVAT;
        //    ctu.TyleChietKhau = 0;// sp.TyLeChietKhau;
        //    ctu.TienChietKhau = 0;// sp.TienChietKhau;
        //    ctu.SoLuong = 1;
        //    ctu.TienSauChietKhau = sp.DonGiaChuaVAT - 0;// sp.TienChietKhau;
        //    ctu.TyleVAT = sp.TyLeVAT;
        //    ctu.TienVAT = sp.TienVAT;
        //    ctu.ThanhTien = sp.DonGiaCoVAT;
        //    ctu.TyleThuong = sp.TyLeThuong;
        //    ctu.ThuongNong = sp.ThuongNong;
        //    ctu.TrungMaVach = sp.TrungMaVach;
        //    ctu.TrangThai = "";
        //    ctu.NoKhuyenMai = 0;
        //    ctu.GiaTheoBangGia = sp.DonGiaCoVAT;
        //    ctu.GiaNiemYet = sp.GiaNiemYet;
        //    ctu.GiaWebSite = sp.GiaWebSite;
        //    ctu.IdSanPhamBan = 0;
        //    ctu.TenSanPhamBan = "";
        //    ctu.GhiChu = "";
        //    ctu.LinhVuc = sp.LinhVuc;
        //    ctu.Nganh = sp.Nganh;
        //    ctu.Loai = sp.Loai;
        //    ctu.Chung = sp.Chung;
        //    ctu.Nhom = sp.Nhom;
        //    ctu.Hang = sp.Hang;
        //    ctu.Model = sp.Model;
        //    ctu.LoaiHangKem = 0;
        //    ctu.TenLoaiHangKem = Declare.DescHangBan;
        //    ctu.ChietKhau = sp.ChietKhau;

        //    return ctu;
        //}

        //public ChungTuBanHangChiTietInfor ConvertBG2SanPhamKM(BangGiaBanChiTietInfor sp)
        //{
        //    ChungTuBanHangChiTietInfor ctu = new ChungTuBanHangChiTietInfor();
        //    ctu.IdSanPham = sp.IdSanPham;
        //    ctu.MaSanPham = sp.MaSanPham;
        //    ctu.TenSanPham = sp.TenSanPham;
        //    ctu.DonViTinh = sp.TenDonViTinh;
        //    ctu.DonGia = 0;// sp.DonGiaChuaVAT;
        //    ctu.TyleChietKhau = 0;// sp.TyLeChietKhau;
        //    ctu.TienChietKhau = 0;// sp.TienChietKhau;
        //    ctu.SoLuong = 1;
        //    ctu.TienSauChietKhau = 0;//sp.DonGiaChuaVAT - 0;// sp.TienChietKhau;
        //    ctu.TyleVAT = 0;//sp.TyLeVAT;
        //    ctu.TienVAT = 0;//sp.TienVAT;
        //    ctu.ThanhTien = sp.DonGiaCoVAT;
        //    ctu.TyleThuong = 0;//sp.TyLeThuong;
        //    ctu.ThuongNong = 0;//sp.ThuongNong;
        //    ctu.TrungMaVach = sp.TrungMaVach;
        //    ctu.TrangThai = "";
        //    ctu.NoKhuyenMai = 0;
        //    ctu.GiaTheoBangGia = sp.DonGiaCoVAT;
        //    ctu.GiaNiemYet = sp.GiaNiemYet;
        //    ctu.GiaWebSite = sp.GiaWebSite;
        //    ctu.IdSanPhamBan = 0;
        //    ctu.TenSanPhamBan = "";
        //    ctu.GhiChu = "";
        //    ctu.LinhVuc = sp.LinhVuc;
        //    ctu.Nganh = sp.Nganh;
        //    ctu.Loai = sp.Loai;
        //    ctu.Chung = sp.Chung;
        //    ctu.Nhom = sp.Nhom;
        //    ctu.Hang = sp.Hang;
        //    ctu.Model = sp.Model;
        //    ctu.LoaiHangKem = 0;
        //    ctu.TenLoaiHangKem = Declare.DescKhuyenMai;
        //    ctu.ChietKhau = sp.ChietKhau;

        //    return ctu;
        //}

        //public ChungTuBanHangChiTietInfor ConvertBG2SanPhamGNhan(BangGiaBanChiTietInfor sp)
        //{
        //    ChungTuBanHangChiTietInfor ctu = new ChungTuBanHangChiTietInfor();
        //    ctu.IdSanPham = sp.IdSanPham;
        //    ctu.MaSanPham = sp.MaSanPham;
        //    ctu.TenSanPham = sp.TenSanPham;
        //    ctu.DonViTinh = sp.TenDonViTinh;
        //    ctu.DonGia = sp.DonGiaChuaVAT;
        //    ctu.TyleChietKhau = 0;// sp.TyLeChietKhau;
        //    ctu.TienChietKhau = 0;// sp.TienChietKhau;
        //    ctu.SoLuong = 1;
        //    ctu.TienSauChietKhau = sp.DonGiaChuaVAT - 0;// sp.TienChietKhau;
        //    ctu.TyleVAT = sp.TyLeVAT;
        //    ctu.TienVAT = sp.TienVAT;
        //    ctu.ThanhTien = sp.DonGiaCoVAT;
        //    ctu.TyleThuong = sp.TyLeThuong;
        //    ctu.ThuongNong = sp.ThuongNong;
        //    ctu.TrungMaVach = sp.TrungMaVach;
        //    ctu.TrangThai = "";
        //    ctu.NoKhuyenMai = 0;
        //    ctu.GiaTheoBangGia = sp.DonGiaCoVAT;
        //    ctu.GiaNiemYet = sp.GiaNiemYet;
        //    ctu.GiaWebSite = sp.GiaWebSite;
        //    ctu.IdSanPhamBan = -1;
        //    ctu.TenSanPhamBan = "";
        //    ctu.GhiChu = "";
        //    ctu.TenLoaiHangKem = Declare.DescGiaoNhan;
        //    ctu.ChietKhau = sp.ChietKhau;

        //    return ctu;
        //}

        //public ChungTuBanHangChiTietInfor ConvertKM2SanPhamBan(BangGiaHangKhuyenMaiChiTietInfor km)
        //{
        //    ChungTuBanHangChiTietInfor ctu = new ChungTuBanHangChiTietInfor();
        //    ctu.IdSanPham = km.IdSanPham;
        //    ctu.MaSanPham = km.MaSanPham;
        //    ctu.TenSanPham = km.TenSanPham;
        //    ctu.DonViTinh = km.DonViTinh;
        //    ctu.DonGia = 0;
        //    ctu.TyleChietKhau = 0;
        //    ctu.TienChietKhau = 0;
        //    ctu.TienSauChietKhau = 0;
        //    ctu.SoLuong = Common.Int2Bool(km.ChietKhau) ? 0 : (Common.Int2Bool(km.DuHang) ? km.SoLuongKM : 0);
        //    ctu.TienSauChietKhau = 0;
        //    ctu.TyleVAT = -1;
        //    ctu.TienVAT = 0;
        //    ctu.ThanhTien = Common.Int2Bool(km.ChietKhau) ? -km.SoTienCK : km.SoLuongKM;
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

        public int GetAmountPermission(int idSanPham, int idKho)
        {
            return BanHangDAO.Instance.GetAmountPermission(idSanPham, idKho);
        }
    }
}
