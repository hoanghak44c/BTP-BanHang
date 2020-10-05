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
    public class ImportDonHangBusiness : ChungTuXuatKhoBusinessBase<ChungTuBanHangInfor, ChungTuBanHangChiTietInfor, ChungTuBanHangChiTietHangHoaInfor>
    {
        /// <summary>
        /// Các chi tiết thanh toan của chứng từ
        /// </summary>
        public List<ChungTuThanhToanInfor> ListChungTuThanhToan;

        public ImportDonHangBusiness()
        {
            ChungTu = new ChungTuBanHangInfor
            {
                LoaiChungTu = Common.IntValue(TransactionType.DON_HANG_TAI_SHOP),
                IdNhanVien = Declare.IdNhanVien,
                IdKho = Declare.IdKho
            };
        }
        public ImportDonHangBusiness(int loaiChungTu, int idNhanVien, int idKho)
        {
            ChungTu = new ChungTuBanHangInfor
            {
                LoaiChungTu = loaiChungTu,
                IdNhanVien = idNhanVien,
                IdKho = idKho
            };
        }

        public ImportDonHangBusiness(ChungTuBanHangInfor chungTuBanHangInfor)
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
            ListChungTuThanhToan = ThanhToanDataProvider.Instance.LoadAllThanhToanByCTu(ChungTuInfo.IdChungTu);
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
            BusinessKhoProvider = ImportChungTuDataProvider.Instance;
        }

        protected override void SaveChungTuInstance()
        {
            //Cap nhat chung tu
            base.SaveChungTuInstance();
            //Cap nhat thanh toan
            SaveChungTuThanhToan();
        }

        public void SaveChungTuThanhToan()
        {
            List<ChungTuThanhToanInfor> listOrigin =
                ThanhToanDataProvider.Instance.LoadAllThanhToanByCTu(ChungTu.IdChungTu);

            //xoa nhung cai cu
            foreach (ChungTuThanhToanInfor originInfo in listOrigin)
            {
                if (!ListChungTuThanhToan.Exists(delegate(ChungTuThanhToanInfor match)
                {
                    return match.IdThanhToan == originInfo.IdThanhToan;
                }))
                {
                    ThanhToanDataProvider.Instance.Delete(originInfo.IdThanhToan);
                }
            }
            //them hoac cap nhat cai moi
            foreach (ChungTuThanhToanInfor cttt in ListChungTuThanhToan)
            {
                ChungTuThanhToanInfor originInfo = listOrigin.Find(
                    delegate(ChungTuThanhToanInfor match)
                    {
                        return match.IdThanhToan == cttt.IdThanhToan;
                    });

                if (originInfo != null)
                {
                    ThanhToanDataProvider.Instance.Update(cttt);
                }
                else
                {
                    cttt.IdChungTu = ChungTu.IdChungTu;
                    cttt.IdThanhToan = ThanhToanDataProvider.Instance.Insert(cttt);
                }
            }
        }
        #endregion
    }
}
