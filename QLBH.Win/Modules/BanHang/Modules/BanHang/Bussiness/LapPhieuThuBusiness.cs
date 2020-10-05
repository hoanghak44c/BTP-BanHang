using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBH.Common;
using QLBH.Core.Business;
using QLBH.Core.Data;

namespace QLBanHang.Modules.BanHang.Bussiness
{
    public class LapPhieuThuBusiness
    {
        /// <summary>
        /// Các chi tiết thanh toan của chứng từ
        /// </summary>
        public ChungTuBanHangInfor ChungTu;
        public List<ChungTuThanhToanInfor> ListChungTuThanhToan;

        public LapPhieuThuBusiness()
        {
            ChungTu = new ChungTuBanHangInfor
            {
                LoaiChungTu = Common.IntValue(TransactionType.DON_HANG_TAI_SHOP),
                IdNhanVien = Declare.IdNhanVien,
                IdKho = Declare.IdKho
            };
        }

        public LapPhieuThuBusiness(ChungTuBanHangInfor chungTuBanHangInfor)
        {
            ChungTu =
                BanHangDataProvider.Instance.GetChungTuBySoChungTu<ChungTuBanHangInfor>(
                    chungTuBanHangInfor.SoChungTu) ?? chungTuBanHangInfor;

            ListChungTuThanhToan = ThanhToanDataProvider.Instance.LoadAllThanhToanByCTu(ChungTu.IdChungTu);
        }

        #region save chung tu
        public void SaveChungTuThuChi()
        {
            try
            {
                ConnectionUtil.Instance.BeginTransaction();
                SaveChungTuInfor();
                SaveChungTuThanhToan();
                ConnectionUtil.Instance.CommitTransaction();
            }
            catch (Exception)
            {
                ConnectionUtil.Instance.RollbackTransaction();
                throw;
            }
        }
        private void SaveChungTuInfor()
        {
            if (ChungTu.IdChungTu == 0)//them moi
            {
                ChungTu.IdChungTu = BanHangDataProvider.Instance.InsertChungTu(ChungTu);
            }
            else
            {
                BanHangDataProvider.Instance.UpdateChungTu(ChungTu);
            }
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
        #endregion
    }
}
