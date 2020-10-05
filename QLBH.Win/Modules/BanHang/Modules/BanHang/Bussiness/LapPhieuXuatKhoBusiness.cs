using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBH.Common;
using QLBH.Core.Business;
using QLBH.Core.Infors;

namespace QLBanHang.Modules.BanHang.Bussiness
{
    public class LapPhieuXuatKhoBusiness : ChungTuXuatKhoBusinessBase<ChungTuBanHangInfor, ChungTuBanHangChiTietInfor, ChungTuBanHangChiTietHangHoaInfor>
    {
        public LapPhieuXuatKhoBusiness()
        {
            ChungTu = new ChungTuBanHangInfor
            {
                LoaiChungTu = Common.IntValue(TransactionType.XUAT_KHO_HANG_BAN),
                IdNhanVien = Declare.IdNhanVien,
                IdKho = Declare.IdKho
            };
        }

        public LapPhieuXuatKhoBusiness(int loaiChungTu, int idNhanVien, int idKho)
        {
            ChungTu = new ChungTuBanHangInfor
            {
                LoaiChungTu = loaiChungTu,
                IdNhanVien = idNhanVien,
                IdKho = idKho
            };
        }

        public LapPhieuXuatKhoBusiness(ChungTuBanHangInfor chungTuBanHangInfor)
            : base(chungTuBanHangInfor)
        {
            if (chungTuBanHangInfor.LoaiChungTu != Common.IntValue(TransactionType.XUAT_KHO_HANG_BAN))
            {
                throw new Exception("Không phải loại chứng từ xuất kho bán hàng");
            }
        }

        protected override void CreateBusinessProvider()
        {
            BusinessKhoProvider = LapPhieuXuatKhoDataProvider.Instance;
        }

        protected override bool ThietLapTuoiTon(HangHoa_ChiTietInfo hangHoaInfo)
        {
            hangHoaInfo.IdPhieuXuat = ChungTuInfo.IdChungTu;
            return true;
        }
    }
}
