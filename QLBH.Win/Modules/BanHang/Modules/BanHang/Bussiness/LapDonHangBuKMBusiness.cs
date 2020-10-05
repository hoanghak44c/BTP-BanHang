using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBH.Common;
using QLBH.Core.Business;

namespace QLBanHang.Modules.BanHang.Bussiness
{
    public class LapDonHangBuKMBusiness : ChungTuXuatKeToanBusinessBase<ChungTuBanHangInfor, ChungTuBanHangChiTietInfor>
    {
        /// <summary>
        /// Các chi tiết thanh toan của chứng từ
        /// </summary>
        public List<ChungTuThanhToanInfor> ListChungTuThanhToan;
        public ChungTuBanHangInfor ChungTuChinhInfor;

        public LapDonHangBuKMBusiness()
        {
            ChungTu = new ChungTuBanHangInfor
            {
                LoaiChungTu = Common.IntValue(TransactionType.DON_HANG_TAI_SHOP),
                IdNhanVien = Declare.IdNhanVien,
                IdKho = Declare.IdKho
            };
        }
        public LapDonHangBuKMBusiness(int loaiChungTu, int idNhanVien, int idKho)
        {
            ChungTu = new ChungTuBanHangInfor
            {
                LoaiChungTu = loaiChungTu,
                IdNhanVien = idNhanVien,
                IdKho = idKho
            };
        }

        public LapDonHangBuKMBusiness(ChungTuBanHangInfor chungTuBanHangInfor)
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

            ChungTu =
                BanHangDataProvider.Instance.GetChungTuBySoChungTu<ChungTuBanHangInfor>(chungTuBanHangInfor.SoChungTu) ??
                chungTuBanHangInfor;

            ListChungTuThanhToan = ThanhToanDataProvider.Instance.LoadAllThanhToanByCTu(ChungTuInfo.IdChungTu);
        }

        #region Overrides of ChungTuKeToanBussinessBase<ChungTuBanHangInfor,ChungTuBanHangChiTietInfor>

        protected override void CreateBusinessProvider()
        {
            BusinessKeToanKhoProvider = BanHangDataProvider.Instance;
        }

        protected override void SaveChungTuInstance()
        {
            //Cap nhat chung tu
            base.SaveChungTuInstance();
            //Cap nhat thanh toan
            SaveChungTuThanhToan();
            //Cap nhat chung tu chinh
            CapNhatChungTuChinh();
        }
        private void SaveChungTuThanhToan()
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
        private void CapNhatChungTuChinh()
        {
        }
        #endregion
    }
}
