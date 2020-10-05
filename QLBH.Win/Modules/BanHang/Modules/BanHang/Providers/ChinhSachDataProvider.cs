using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using QLBH.Common.Providers;
using QLBH.Core.Data;
using QLBH.Common;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.DAO;
using QLBH.Core.Providers;

// <Remarks>
// Tạo BangGiaDataProvider
// Người tạo: Lê Mạnh Tuấn
// Ngày tạo : 24/07/2012
// Người sửa cuối:
// </remarks>

namespace QLBanHang.Modules.BanHang.Providers
{

    public class ChinhSachDataProvider : BusinessProviderBase
    {

        private static ChinhSachDataProvider instance;
        public static ChinhSachDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new ChinhSachDataProvider();
                return instance;
            }
        }

        #region chinh sach gia load
        public List<BangGiaChinhSachInfor> LoadAllChinhSach()
        {
            return ChinhSachGiaDAO.Instance.LoadAllChinhSach();
        }
        public List<BangGiaChinhSachInfor> LoadChinhSachByNSD(string nguoiDung)
        {
            return ChinhSachGiaDAO.Instance.LoadChinhSachByNSD(nguoiDung);
        }
        public List<BangGiaChinhSachInfor> LoadChinhSachByIdDKMua(string lstIdDKMua)
        {
            return ChinhSachGiaDAO.Instance.LoadChinhSachByIdDKMua(lstIdDKMua);
        }
        public List<BangGiaChinhSachInfor> LoadChinhSachByTT(string nguoiDung, int draft)
        {
            return ChinhSachGiaDAO.Instance.LoadChinhSachByTT(nguoiDung, draft);
        }
        public BangGiaChinhSachInfor GetBangGiaChinhSachInforById(int idChinhSach)
        {
            return ChinhSachGiaDAO.Instance.GetBangGiaChinhSachInforById(idChinhSach);
        }
        public List<BangGiaChinhSachInfor> TimKiemChinhSachGia(TimKiemBangGiaFilterInfor filter)
        {
            return ChinhSachGiaDAO.Instance.TimKiemChinhSachGia(filter);
        }
        public List<BangGiaChinhSachInfor> LoadChinhSachGiaNoDuyetPg(TimKiemBangGiaFilterInfor filter)
        {
            return ChinhSachGiaDAO.Instance.LoadChinhSachGiaNoDuyetPg(filter);
        }
        public List<BangGiaChinhSachInfor> SearchChinhSachGiaPg(TimKiemBangGiaFilterInfor filter)
        {
            return ChinhSachGiaDAO.Instance.SearchChinhSachGiaPg(filter);
        }
        public List<BangGiaChinhSachInfor> TimKiemChinhSachGiaPg(TimKiemBangGiaFilterInfor filter)
        {
            return ChinhSachGiaDAO.Instance.TimKiemChinhSachGiaPg(filter);
        }
        public List<BangGiaChinhSachBCInfor> TimKiemChinhSachGiaTongHop(TimKiemBangGiaFilterInfor filter)
        {
            return ChinhSachGiaDAO.Instance.TimKiemChinhSachGiaTongHop(filter);
        }
        public List<BangGiaChinhSachBCInfor> TimKiemChinhSachGiaTongHopPg(TimKiemBangGiaFilterInfor filter)
        {
            return ChinhSachGiaDAO.Instance.TimKiemChinhSachGiaTongHopPg(filter);
        }
        public List<BangGiaCSachCKhauInfor> GetCSachCKhauApDung(int idTrungTam, int idKho, int idLoaiDT)
        {
            return ChinhSachGiaDAO.Instance.GetCSachCKhauApDung(idTrungTam, idKho, idLoaiDT);
        }
        public List<BangGiaChinhSachInfor> GetAllChinhSachApDung(int idTrungTam, int idKho, int idLoaiDT, string maSanPham, int loaiKhachHang)
        {
            return ChinhSachGiaDAO.Instance.GetAllChinhSachApDung(idTrungTam, idKho, idLoaiDT, maSanPham, loaiKhachHang);
        }
        public List<BangGiaChinhSachInfor> GetAllChinhSachApDungAll(int idTrungTam, string maSanPham)
        {
            return ChinhSachGiaDAO.Instance.GetAllChinhSachApDungAll(idTrungTam, maSanPham);
        }
        public List<BangGiaChinhSachInfor> GetAllChinhSachDaApDung(int idTrungTam, string maSanPham, DateTime ngayTao)
        {
            return ChinhSachGiaDAO.Instance.GetAllChinhSachDaApDung(idTrungTam, maSanPham, ngayTao);
        }
        public List<MatHangInfor> GetAllMatHangKhongApDung(string lstMatHang)
        {
            return ChinhSachGiaDAO.Instance.GetAllMatHangKhongApDung(lstMatHang);
        }
        public List<BangGiaCSachCTietInfor> LoadSanPhamAnhHuong(int idChinhSach)
        {
            return ChinhSachGiaDAO.Instance.LoadSanPhamAnhHuong(idChinhSach);
        }
        #endregion

        #region chinh sach ap dung load
        public List<BangGiaADShopInfor> GetBangGiaADShopInfor(int idChinhSach)
        {
            return ChinhSachGiaDAO.Instance.GetBangGiaADShopInfor(idChinhSach);
        }
        public List<BangGiaADKhachInfor> GetBangGiaADKhachInfor(int idChinhSach)
        {
            return ChinhSachGiaDAO.Instance.GetBangGiaADKhachInfor(idChinhSach);
        }
        public List<BangGiaADTimeInfor> GetBangGiaADThoiGianInfor(int idChinhSach)
        {
            return ChinhSachGiaDAO.Instance.GetBangGiaADThoiGianInfor(idChinhSach);
        }
        public List<BangGiaADBankInfor> GetBangGiaADThanhToanInfor(int idChinhSach)
        {
            return ChinhSachGiaDAO.Instance.GetBangGiaADThanhToanInfor(idChinhSach);
        }
        #endregion

        #region bang gia chinh sach update
        public void UpdateBangGiaChinhSach(BangGiaChinhSachInfor bgcs)
        {
            ChinhSachGiaDAO.Instance.UpdateBangGiaChinhSach(bgcs);
        }

        public void UpdateBangGiaChinhSachNoDuyet(BangGiaChinhSachInfor bgcs)
        {
            ChinhSachGiaDAO.Instance.UpdateBangGiaChinhSachNoDuyet(bgcs);
        }

        public int InsertBangGiaChinhSach(BangGiaChinhSachInfor bgcs)
        {
            return ChinhSachGiaDAO.Instance.InsertBangGiaChinhSach(bgcs);
        }

        public int InsertBangGiaChinhSachNoDuyet(BangGiaChinhSachInfor bgcs)
        {
            return ChinhSachGiaDAO.Instance.InsertBangGiaChinhSachNoDuyet(bgcs);
        }

        public void DeleteBangGiaChinhSach(int idChinhSach)
        {
            ChinhSachGiaDAO.Instance.DeleteBangGiaChinhSach(idChinhSach);
        }

        public bool ExistBangGiaChinhSach(string soChinhSach, int idChinhSach)
        {
            bool rs = false;
            if (ChinhSachGiaDAO.Instance.ExistBangGiaChinhSach(soChinhSach, idChinhSach).Count > 0)
                rs = true;
            return rs;
        }
        
        public void DuyetBangGiaChinhSach(BangGiaChinhSachInfor bgcs)
        {
            ChinhSachGiaDAO.Instance.DuyetBangGiaChinhSach(bgcs);
        }
        public void ThietLapMacDinhChinhSach(BangGiaChinhSachInfor bgcs)
        {
            ChinhSachGiaDAO.Instance.ThietLapMacDinhChinhSach(bgcs);
        }
        #endregion

        #region bang gia doi tuong ap dung update
        public void InsertBangGiaADShop(BangGiaADShopInfor bgShop)
        {
            ChinhSachGiaDAO.Instance.InsertBangGiaADShop(bgShop);
        }

        public void InsertBangGiaADKhach(BangGiaADKhachInfor bgKhach)
        {
            ChinhSachGiaDAO.Instance.InsertBangGiaADKhach(bgKhach);
        }

        public void DeleteBangGiaADShop(int idChinhSach)
        {
            ChinhSachGiaDAO.Instance.DeleteBangGiaADShop(idChinhSach);
        }

        public void InsertBangGiaADThoiGian(BangGiaADTimeInfor bgTime)
        {
            ChinhSachGiaDAO.Instance.InsertBangGiaADThoiGian(bgTime);
        }

        public void InsertBangGiaADThanhToan(BangGiaADBankInfor bgBank)
        {
            ChinhSachGiaDAO.Instance.InsertBangGiaADThanhToan(bgBank);
        }

        public void InsertSanPhamAnhHuong(BangGiaCSachCTietInfor bg)
        {
            ChinhSachGiaDAO.Instance.InsertSanPhamAnhHuong(bg);
        }

        public void DeleteBangGiaADKhach(int idChinhSach)
        {
            ChinhSachGiaDAO.Instance.DeleteBangGiaADKhach(idChinhSach);
        }

        public void DeleteBangGiaADThoiGian(int idChinhSach)
        {
            ChinhSachGiaDAO.Instance.DeleteBangGiaADThoiGian(idChinhSach);
        }

        public void DeleteBangGiaADThanhToan(int idChinhSach)
        {
            ChinhSachGiaDAO.Instance.DeleteBangGiaADThanhToan(idChinhSach);
        }
        public void DeleteSanPhamAnhHuong(int idChinhSach)
        {
            ChinhSachGiaDAO.Instance.DeleteSanPhamAnhHuong(idChinhSach);
        }

        #endregion
    }
}
