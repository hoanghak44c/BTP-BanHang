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
    public class XacNhanNhapDoiMaBussiness : ChungTuNhapKhoBusinessBase<ChungTuBanHangInfor, BHangDoiMaChiTietHHInfor, ChungTuBanHangChiTietHangHoaInfor>
    {
        public XacNhanNhapDoiMaBussiness(){ }

        public XacNhanNhapDoiMaBussiness(ChungTuBanHangInfor chungTuDoiMaInfo) : base(chungTuDoiMaInfo) { }

        #region Overrides of ChungTuKeToanBusinessBase<ChungTuDoiLinhKienLoiInfo, ChungTuChiTietBaseInfo>

        protected override void CreateBusinessProvider()
        {
            BusinessProvider = BHangXacNhanDoiMaDataProvider.Instance;
        }

        #endregion

        protected override void CreateTonKhoCalc(HangTonKhoInfo tonKhoInfo)
        {
            TonKhoCalc = new NhapTonKhongCalc(tonKhoInfo, ChungTu.SoChungTu, ChungTu.NgayXuatHang);
        }
    }
}
