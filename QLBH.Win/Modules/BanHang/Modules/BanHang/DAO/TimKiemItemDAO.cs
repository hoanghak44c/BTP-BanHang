using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.BanHang.Infors;

namespace QLBanHang.Modules.BanHang.DAO
{
    public class TimKiemItemDAO : BaseDAO
    {
        private static TimKiemItemDAO instance;
        private TimKiemItemDAO()
        {
            //CRUDTableName = Declare.TableNamespace.BangGia;
            //UseCaching = true;
        }
        public static TimKiemItemDAO Instance
        {
            get
            {
                if (instance == null) instance = new TimKiemItemDAO();
                return instance;
            }
        }

        #region tim kiem item
        //0-linhvuc,1-nganh,2-loai,3-chung,4-nhom,5-model,6-sanpham,7-hang
        public List<TimKiemItemInfor> GetAllItemsByType(int idNhomNguoiDung, int type, int chietKhau, int suDung)
        {
            return GetListCommand<TimKiemItemInfor>(Declare.StoreProcedureNamespace.spMatHangGetAllByMaNSD, idNhomNguoiDung, type, chietKhau, suDung);
        }
        public List<TimKiemItemInfor> GetAllItemsByTypeParent(int idNhomNguoiDung, int type, string mathang, int muccha, string macha, int chietKhau, int suDung)
        {
            return GetListCommand<TimKiemItemInfor>(Declare.StoreProcedureNamespace.spMatHangGetAllByMaParent,
                                                    idNhomNguoiDung, type, mathang, muccha, macha, chietKhau, suDung);
        }
        public TimKiemItemInfor GetAllItemsByTypeandText(int idNhomNguoiDung, int type, int chietKhau, int suDung, string text)
        {
            return GetObjectCommand<TimKiemItemInfor>(Declare.StoreProcedureNamespace.spMatHangGetAllByMaNSDText, idNhomNguoiDung, type, chietKhau, suDung, text);
        }
        public TimKiemItemInfor GetItemByTypeandCode(int idNhomNguoiDung, int type, string maHang)
        {
            return GetObjectCommand<TimKiemItemInfor>(Declare.StoreProcedureNamespace.spMatHangGetItemByTypeAndCode, idNhomNguoiDung, type, maHang);
        }
        public TimKiemItemInfor GetItemChietKhauByCode(int idNhomNguoiDung, string maHang, int suDung)
        {
            return GetObjectCommand<TimKiemItemInfor>(Declare.StoreProcedureNamespace.spMatHangGetItemCKhauByCode, idNhomNguoiDung, maHang, suDung);
        }
        public TimKiemItemInfor GetHangSanXuat(string ma, string ten)
        {
            return GetObjectCommand<TimKiemItemInfor>(Declare.StoreProcedureNamespace.spMatHangGetGetHangSanXuat, ma, ten);
        }
        public SegmentInfo GetHangInfo(string ma, string ten)
        {
            return GetObjectCommand<SegmentInfo>(Declare.StoreProcedureNamespace.spMatHangGetGetHangInfo, ma, ten);
        }
        public List<BangGiaBanChiTietBCInfor> GetListSanPhamNoCKhau(int idtrungtam)
        {
            return GetListCommand<BangGiaBanChiTietBCInfor>(Declare.StoreProcedureNamespace.spSanPhamSelectNoCKhau, idtrungtam);
        }
        public List<DMSanPhamBriefInfo> GetAllMatHangByByType(int type, string ma)
        {
            return GetListCommand<DMSanPhamBriefInfo>(Declare.StoreProcedureNamespace.spMatHangGetAllMatHangByType, type, ma);
        }
        #endregion
    }
}
