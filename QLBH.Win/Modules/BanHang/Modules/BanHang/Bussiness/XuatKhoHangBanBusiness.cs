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
    public class XuatKhoHangBanBusiness : ChungTuXuatKhoBusinessBase<ChungTuBanHangInfor, ChungTuBanHangChiTietInfor, ChungTuBanHangChiTietHangHoaInfor>
    {
        public XuatKhoHangBanBusiness()
        {
            ChungTu = new ChungTuBanHangInfor
            {
                LoaiChungTu = Common.IntValue(TransactionType.DON_HANG_TAI_SHOP),
                IdNhanVien = Declare.IdNhanVien,
                IdKho = Declare.IdKho
            };
        }

        public XuatKhoHangBanBusiness(int loaiChungTu, int idNhanVien, int idKho)
        {
            ChungTu = new ChungTuBanHangInfor
            {
                LoaiChungTu = loaiChungTu,
                IdNhanVien = idNhanVien,
                IdKho = idKho
            };
        }

        public XuatKhoHangBanBusiness(ChungTuBanHangInfor chungTuBanHangInfor)
            : base(chungTuBanHangInfor)
        {
            if (chungTuBanHangInfor.LoaiChungTu != Common.IntValue(TransactionType.DON_HANG_TAI_SHOP) &&
                chungTuBanHangInfor.LoaiChungTu != Common.IntValue(TransactionType.DON_HANG_ONLINE) &&
                chungTuBanHangInfor.LoaiChungTu != Common.IntValue(TransactionType.DON_HANG_DAT_TRUOC) &&
                chungTuBanHangInfor.LoaiChungTu != Common.IntValue(TransactionType.DON_HANG_GIAO_NHAN) &&
                chungTuBanHangInfor.LoaiChungTu != Common.IntValue(TransactionType.DON_HANG_BU_KHUYEN_MAI))
            {
                throw new Exception("Không phải loại chứng từ bán hàng");
            }
        }

        protected override void CreateBusinessProvider()
        {
            BusinessKhoProvider = XuatKhoDataProvider.Instance;
        }

        public override bool Conjunction(ChungTuBanHangChiTietInfor chiTietChungTuInfo, ChungTuBanHangChiTietHangHoaInfor chiTietHangHoaInfo)
        {
            return chiTietChungTuInfo.IdSanPham == chiTietHangHoaInfo.IdSanPham &&
                chiTietChungTuInfo.IdSanPhamBan == chiTietHangHoaInfo.IdSanPhamBan &&
                chiTietChungTuInfo.LoaiHangKem == chiTietHangHoaInfo.LoaiHangKem;
        }
    }
}
