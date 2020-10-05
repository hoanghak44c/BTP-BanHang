using System;
using System.Collections;
using System.Collections.Generic;
using QLBanHang.Modules.DanhMuc.Infors;
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

    public class TimKiemItemDataProvider
    {
        private static TimKiemItemDataProvider instance;
        public static TimKiemItemDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new TimKiemItemDataProvider();
                return instance;
            }
        }


        #region tim kiem item
        //0-linhvuc,1-nganh,2-loai,3-chung,4-nhom,5-model,6-sanpham,7-hang
        public List<TimKiemItemInfor> GetAllItemsByType(int idNhomNguoiDung, int type, int chietKhau, int suDung)
        {
            return TimKiemItemDAO.Instance.GetAllItemsByType(idNhomNguoiDung, type, chietKhau, suDung);
        }
        public List<TimKiemItemInfor> GetAllItemsByTypeParent(int idNhomNguoiDung, int type, string mathang, int muccha, string macha, int chietKhau, int suDung)
        {
            return TimKiemItemDAO.Instance.GetAllItemsByTypeParent(idNhomNguoiDung, type, mathang, muccha, macha, chietKhau, suDung);
        }
        public TimKiemItemInfor GetAllItemsByTypeandText(int idNhomNguoiDung, int type, int chietKhau, int suDung, string text)
        {
            return TimKiemItemDAO.Instance.GetAllItemsByTypeandText(idNhomNguoiDung, type, chietKhau, suDung, text);
        }
        public TimKiemItemInfor GetItemByTypeandCode(int idNhomNguoiDung, int type, string maHang)
        {
            return TimKiemItemDAO.Instance.GetItemByTypeandCode(idNhomNguoiDung, type, maHang);
        }
        public TimKiemItemInfor GetItemChietKhauByCode(int idNhomNguoiDung, string maHang, int suDung)
        {
            return TimKiemItemDAO.Instance.GetItemChietKhauByCode(idNhomNguoiDung, maHang, suDung);
        }
        public TimKiemItemInfor GetHangSanXuat(string ma, string ten)
        {
            return TimKiemItemDAO.Instance.GetHangSanXuat(ma, ten);
        }
        public SegmentInfo GetHangInfo(string ma, string ten)
        {
            return TimKiemItemDAO.Instance.GetHangInfo(ma, ten);
        }
        public List<BangGiaBanChiTietBCInfor> GetListSanPhamNoCKhau(int idtrungtam)
        {
            return TimKiemItemDAO.Instance.GetListSanPhamNoCKhau(idtrungtam);
        }
        public List<DMSanPhamBriefInfo> GetAllMatHangByByType(int type, string ma)
        {
            return TimKiemItemDAO.Instance.GetAllMatHangByByType(type, ma);
        }
        #endregion

    }
}
