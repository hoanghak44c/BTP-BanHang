using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBH.Common;
using QLBH.Core.Business;
using QLBH.Core.Business.Calculations;
using QLBH.Core.Infors;

namespace QLBanHang.Modules.BanHang.Bussiness
{
    public class XacNhanXuatDoiMaBussiness : ChungTuXuatKhoBusinessBase<ChungTuBanHangInfor, BHangDoiMaChiTietHHInfor, ChungTuBanHangChiTietHangHoaInfor>
    {
        public XacNhanXuatDoiMaBussiness(){ }

        public XacNhanXuatDoiMaBussiness(ChungTuBanHangInfor chungTuDoiMaInfo) : base(chungTuDoiMaInfo) { }

        #region Overrides of ChungTuKeToanBusinessBase<ChungTuDoiLinhKienLoiInfo, ChungTuChiTietBaseInfo>

        protected override void CreateBusinessProvider()
        {
            BusinessProvider = BHangXacNhanDoiMaDataProvider.Instance;
        }

        #endregion

        protected override void CreateTonKhoCalc(HangTonKhoInfo tonKhoInfo)
        {
            TonKhoCalc = new XuatTonKhongCalc(tonKhoInfo, ChungTu.SoChungTu, ChungTu.NgayXuatHang);
        }

        protected override bool ThietLapTuoiTon(HangHoa_ChiTietInfo hangHoaInfo)
        {
            hangHoaInfo.IdPhieuXuat = ChungTuInfo.IdChungTu;
            return true;
        }

        public override bool Conjunction(BHangDoiMaChiTietHHInfor chiTietChungTuInfo, ChungTuBanHangChiTietHangHoaInfor chiTietHangHoaInfo)
        {
            return chiTietChungTuInfo.IdSanPham == chiTietHangHoaInfo.IdSanPham &&
                chiTietChungTuInfo.MaVachDoi.Equals(chiTietHangHoaInfo.MaVach);
        }

        public int GetIdChiTietHangHoa(string mavach, int idsanpham, string soCTuGoc)
        {
            int idchitiethanghoa = 0;
            idchitiethanghoa = BHangDoiMaDataProvider.Instance.GetHangHoaChiTietInfor(mavach, idsanpham, soCTuGoc).IdChiTiet;
            return idchitiethanghoa;
        }
    }
}
