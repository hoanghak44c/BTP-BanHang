using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBH.Common;
using QLBH.Core.Business;

namespace QLBanHang.Modules.BanHang.Bussiness
{
    public class ImportDonHangNLBussiness : ChungTuNhapKeToanBusinessBase<ChungTuBanHangInfor, ChungTuBanHangChiTietInfor>
    {
        /// <summary>
        /// Các chi tiết thanh toan của chứng từ
        /// </summary>
        public List<ChungTuThanhToanInfor> ListChungTuThanhToan;

        public ImportDonHangNLBussiness()
        {
            ChungTu = new ChungTuBanHangInfor
            {
                LoaiChungTu = Common.IntValue(TransactionType.NHAPTRAHANGMUA),
                IdNhanVien = Declare.IdNhanVien,
                IdKho = Declare.IdKho
            };
        }

        public ImportDonHangNLBussiness(int loaiChungTu, int idNhanVien, int idKho)
        {
            ChungTu = new ChungTuBanHangInfor
            {
                LoaiChungTu = loaiChungTu,
                IdNhanVien = idNhanVien,
                IdKho = idKho
            };
        }
        public ImportDonHangNLBussiness(ChungTuBanHangInfor ChungTuBanHangInfor)
            : base(ChungTuBanHangInfor)
        {
            if (ChungTuBanHangInfor.LoaiChungTu != Common.IntValue(TransactionType.NHAPTRAHANGMUA) &&
                ChungTuBanHangInfor.LoaiChungTu != Common.IntValue(TransactionType.DON_HANG_NHAP_LAI))
            {
                throw new Exception("Không phải loại chứng từ trả lại hàng bán");
            }
            ListChungTuThanhToan = ThanhToanDataProvider.Instance.LoadAllThanhToanByCTu(ChungTuInfo.IdChungTu);
        }

        protected override void CreateBusinessProvider()
        {
            BusinessKeToanKhoProvider = BanHangDataProvider.Instance;
        }

        protected override void SaveChungTuInstance()
        {
            try
            {
                //Cap nhat chung tu
                base.SaveChungTuInstance();
                //Cap nhat thanh toan
                SaveChungTuThanhToan();
            }
            catch (Exception e)
            {
                throw e;
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
    }
}
