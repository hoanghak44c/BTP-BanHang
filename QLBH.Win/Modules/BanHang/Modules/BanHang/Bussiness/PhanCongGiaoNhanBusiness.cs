using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBH.Common;
using QLBH.Core.Business;

namespace QLBanHang.Modules.BanHang.Bussiness
{
    public class PhanCongGiaoNhanBusiness : ChungTuXuatKeToanBusinessBase<ChungTuBanHangInfor, ChungTuBanHangChiTietInfor>
    {
        public PhanCongGiaoNhanBusiness()
        {
            ChungTu = new ChungTuBanHangInfor
            {
                LoaiChungTu = Common.IntValue(TransactionType.DON_HANG_GIAO_NHAN),
                IdNhanVien = Declare.IdNhanVien,
                IdKho = Declare.IdKho
            };
        }
        public PhanCongGiaoNhanBusiness(int loaiChungTu, int idNhanVien, int idKho)
        {
            ChungTu = new ChungTuBanHangInfor
            {
                LoaiChungTu = loaiChungTu,
                IdNhanVien = idNhanVien,
                IdKho = idKho
            };
        }

        public PhanCongGiaoNhanBusiness(ChungTuBanHangInfor chungTuBanHangInfor)
            : base(chungTuBanHangInfor)
        {
            if (chungTuBanHangInfor.LoaiChungTu != Common.IntValue(TransactionType.DON_HANG_GIAO_NHAN))
            {
                throw new Exception("Không phải loại chứng từ giao nhận");
            }
        }

        #region Overrides of ChungTuKeToanBussinessBase<ChungTuBanHangInfor,ChungTuBanHangChiTietInfor>

        protected override void CreateBusinessProvider()
        {
            BusinessKeToanKhoProvider = BanHangDataProvider.Instance;
        }
        #endregion
    }
}
