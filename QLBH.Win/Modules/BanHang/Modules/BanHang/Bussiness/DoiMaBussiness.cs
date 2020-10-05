using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBH.Common;

namespace QLBanHang.Modules.BanHang.Bussiness
{
    public class DoiMaBussiness
    {
        public ChungTuBanHangInfor ChungTu;
        public List<BHangDoiMaChiTietHHInfor> ListChiTietChungTu=new List<BHangDoiMaChiTietHHInfor>();
        public List<ChungTuBanHangChiTietHangHoaInfor> ListChungTuChiTietHangHoa=new List<ChungTuBanHangChiTietHangHoaInfor>();
        public DoiMaBussiness(ChungTuBanHangInfor ChungTu)
        {
            this.ChungTu = ChungTu;
            ListChiTietChungTu = BHangDoiMaDataProvider.Instance.GetListChiTietChungTuByIdChungTu(ChungTu.IdChungTu);
            ListChungTuChiTietHangHoa = BHangDoiMaDataProvider.Instance.GetListChiTietHangHoaByIdChungTu(ChungTu.IdChungTu);
        }

        public DoiMaBussiness()
        {
            ChungTu = new ChungTuBanHangInfor
            {
                LoaiChungTu = Common.IntValue(TransactionType.DOIMAHANGMUA),
                IdNhanVien = Declare.IdNhanVien,
                IdKho = Declare.IdKho
            };           
        }

        public void SaveChungTu(int loai)
        {
            if (ChungTu.IdChungTu == 0)
                ChungTu.IdChungTu = BHangDoiMaDataProvider.Instance.InsertChungTu(ChungTu);
            else
            {
                BHangDoiMaDataProvider.Instance.UpdateChungTu(ChungTu);
            }
            if (loai == 0)
                SaveChungTuChiTiet();
            else if (loai == 1)
                SaveChungTuChiTietHangHoa();
        }

        private void SaveChungTuChiTiet()
        {
            List<BHangDoiMaChiTietHHInfor> ListChiTietChungTuOld = BHangDoiMaDataProvider.Instance.GetListChiTietChungTuByIdChungTu(ChungTu.IdChungTu);
            foreach (BHangDoiMaChiTietHHInfor pt in ListChiTietChungTuOld)
            {
                BHangDoiMaDataProvider.Instance.DeleteChiTietChungTu(pt);
            }

            foreach (BHangDoiMaChiTietHHInfor pt in ListChiTietChungTu)
            {
                pt.IdChungTu = ChungTu.IdChungTu;
                pt.IdChungTuChiTiet = BHangDoiMaDataProvider.Instance.InsertChiTietChungTu(pt);
            }
        }
        private void SaveChungTuChiTietHangHoa()
        {
            List<ChungTuBanHangChiTietHangHoaInfor> ListChungTuChiTietHangHoaOld = BHangDoiMaDataProvider.Instance.GetListChiTietHangHoaByIdChungTu(ChungTu.IdChungTu);
            foreach (ChungTuBanHangChiTietHangHoaInfor pt in ListChungTuChiTietHangHoaOld)
            {
                BHangDoiMaDataProvider.Instance.DeleteChiTietHangHoa(pt);
            }
            foreach (ChungTuBanHangChiTietHangHoaInfor pt in ListChungTuChiTietHangHoa)
            {
                //pt.IdChungTuChiTiet = GetIdChungTuChiTiet(pt.IdSanPham);
                //pt.IdChiTietHangHoa = GetIdChiTietHangHoa(pt.MaVach, pt.IdSanPham, ChungTu.IdKho);
                BHangDoiMaDataProvider.Instance.InsertChiTietHangHoa(pt);
            }
        }

        //private int GetIdChungTuChiTiet(int idsanpham)
        //{
        //    int idchungtuchitiet = 0;
        //    foreach (BHangDoiMaChiTietHHInfor pt in ListChiTietChungTu)
        //    {
        //        if (pt.IdSanPham == idsanpham)
        //        {
        //            idchungtuchitiet = pt.IdChungTuChiTiet;
        //            break;
        //        }
        //    }
        //    return idchungtuchitiet;
        //}

        //public int GetIdChiTietHangHoa(string mavach, int idsanpham, int idkho)
        //{
        //    int idchitiethanghoa = 0;
        //    idchitiethanghoa = BHangDoiMaDataProvider.Instance.GetHangHoaChiTietInfor(mavach, idsanpham, idkho).IdChiTiet;
        //    return idchitiethanghoa;
        //}

        public void DeleteChungTu()
        {
            foreach (BHangDoiMaChiTietHHInfor pt in ListChiTietChungTu)
            {
                BHangDoiMaDataProvider.Instance.DeleteChiTietChungTu(pt);
            }
            BHangDoiMaDataProvider.Instance.DeleteChungTu(ChungTu.IdChungTu);
        }
    }
}
