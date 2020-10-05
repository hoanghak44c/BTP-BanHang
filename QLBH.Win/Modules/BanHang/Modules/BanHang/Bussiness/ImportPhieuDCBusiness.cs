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
    public class ImportPhieuDCBusiness : ChungTuXuatKhoBusinessBase<ImportCTuDChuyenInfor, ImportCTuDChuyenCTietInfor, ImportCTuDChuyenCTietHHoaInfor>
    {
        /// <summary>
        /// Các chi tiết thanh toan của chứng từ
        /// </summary>
        public List<ChungTuThanhToanInfor> ListChungTuThanhToan;

        public ImportPhieuDCBusiness()
        {
            ChungTu = new ImportCTuDChuyenInfor
            {
                LoaiChungTu = Common.IntValue(TransactionType.XUAT_DIEU_CHUYEN),
                IdNhanVien = Declare.IdNhanVien,
                IdKho = Declare.IdKho
            };
        }
        public ImportPhieuDCBusiness(int loaiChungTu, int idNhanVien, int idKho)
        {
            ChungTu = new ImportCTuDChuyenInfor
            {
                LoaiChungTu = loaiChungTu,
                IdNhanVien = idNhanVien,
                IdKho = idKho
            };
        }

        public ImportPhieuDCBusiness(ImportCTuDChuyenInfor chungTuBanHangInfor)
            : base(chungTuBanHangInfor)
        {
            if (chungTuBanHangInfor.LoaiChungTu != Common.IntValue(TransactionType.DE_NGHI_XUAT_DIEU_CHUYEN) &&
                chungTuBanHangInfor.LoaiChungTu != Common.IntValue(TransactionType.XUAT_DIEU_CHUYEN) &&
                chungTuBanHangInfor.LoaiChungTu != Common.IntValue(TransactionType.DE_NGHI_NHAN_DIEU_CHUYEN) &&
                chungTuBanHangInfor.LoaiChungTu != Common.IntValue(TransactionType.NHAN_DIEU_CHUYEN))
            {
                throw new Exception("Không phải loại chứng từ điều chuyển");
            }
        }

        #region Overrides of ChungTuKeToanBussinessBase<ChungTuBanHangInfor,ChungTuBanHangChiTietInfor>

        /// <summary>
        /// note: Truong hop khong tach quy trinh ke toan va kho rieng thi viet lai ham sau
        /// </summary>
        /// <param name="tonKhoInfo"></param>
        protected override void CreateTonKhoCalc(HangTonKhoInfo tonKhoInfo)
        {
            TonKhoCalc = new XuatTonCalc(tonKhoInfo, ChungTuInfo.SoChungTu, ChungTuInfo.NgayLap);
        }

        protected override void CreateBusinessProvider()
        {
            BusinessKhoProvider = ImportChungTuDCDataProvider.Instance;
        }
        #endregion
    }
}
