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
    public class NhapTraHangMuaBussiness : ChungTuNhapKhoBusinessBase<ChungTuBanHangInfor, NhapHangTraChiTietHHInfor, ChungTuBanHangChiTietHangHoaInfor>
    {
        /// <summary>
        /// Các chi tiết thanh toan của chứng từ
        /// </summary>
        public List<ChungTuThanhToanInfor> ListChungTuThanhToan;

        public NhapTraHangMuaBussiness()
        {
            ChungTu = new ChungTuBanHangInfor
            {
                LoaiChungTu = Common.IntValue(TransactionType.NHAPTRAHANGMUA),
                IdNhanVien = Declare.IdNhanVien,
                IdKho = Declare.IdKho
            };
        }

        public NhapTraHangMuaBussiness(int loaiChungTu, int idNhanVien, int idKho)
        {
            ChungTu = new ChungTuBanHangInfor
            {
                LoaiChungTu = loaiChungTu,
                IdNhanVien = idNhanVien,
                IdKho = idKho
            };
        }
        public NhapTraHangMuaBussiness(ChungTuBanHangInfor ChungTuBanHangInfor)
            : base(ChungTuBanHangInfor)
        {
            //if (ChungTuBanHangInfor.LoaiChungTu != Common.IntValue(TransactionType.NHAPTRAHANGMUA))
            //{
            //    throw new Exception("Không phải loại chứng từ trả lại hàng bán");
            //}
            ListChungTuThanhToan = ThanhToanDataProvider.Instance.LoadAllThanhToanByCTu(ChungTuInfo.IdChungTu);            
        }
        protected override void CreateBusinessProvider()
        {
            BusinessKhoProvider = NhapTraHangMuaDataProvider.Instance;
        }

        protected override void SaveChungTuInstance()
        {
            //Cap nhat chung tu
            base.SaveChungTuInstance();
            //Cap nhat thanh toan
            SaveChungTuThanhToan();
        }

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
                ChungTu.IdChungTu = NhapTraHangMuaDataProvider.Instance.InsertChungTu(ChungTu);
            }
            else
            {
                NhapTraHangMuaDataProvider.Instance.UpdateChungTu(ChungTu);
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
        public override bool Conjunction(NhapHangTraChiTietHHInfor chiTietChungTuInfo, ChungTuBanHangChiTietHangHoaInfor chiTietHangHoaInfo)
        {
            return chiTietChungTuInfo.IdSanPham == chiTietHangHoaInfo.IdSanPham &&
                   chiTietChungTuInfo.IdSanPhamBan == chiTietHangHoaInfo.IdSanPhamBan &&
                   chiTietChungTuInfo.MaVach.Equals(chiTietHangHoaInfo.MaVach);
        }

        public override bool TinhLaiChiTietChungTu()
        {
            return false;
        }

        #region delete chungtu
        public void DeleteChungTuGoc(int idChungTu)
        {
            BanHangDataProvider.Instance.DeleteAllChungTu(idChungTu);
        }
        #endregion
    }
}
