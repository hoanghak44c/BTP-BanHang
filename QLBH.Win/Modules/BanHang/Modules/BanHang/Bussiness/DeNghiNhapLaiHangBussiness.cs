using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBH.Common;
using QLBH.Core.Business;

namespace QLBanHang.Modules.BanHang.Bussiness
{
    public class DeNghiNhapLaiHangBussiness
    {
        /// <summary>
        /// Cac nghiệp vụ lập đơn hàng: chỉ ghi chứng từ, không ghi tồn kho
        /// </summary>
        public ChungTuBanHangInfor ChungTu;
        public List<NhapHangTraChiTietHHInfor> ListChiTietChungTu;
        //public List<ChungTuThanhToanInfor> ListChungTuThanhToan;

        public DeNghiNhapLaiHangBussiness()
        {
            ChungTu = new ChungTuBanHangInfor
            {
                LoaiChungTu = Common.IntValue(TransactionType.NHAPTRAHANGMUA),
                IdNhanVien = Declare.IdNhanVien,
                IdKho = Declare.IdKho
            };
        }

        public DeNghiNhapLaiHangBussiness(int loaiChungTu, int idNhanVien, int idKho)
        {
            ChungTu = new ChungTuBanHangInfor
            {
                LoaiChungTu = loaiChungTu,
                IdNhanVien = idNhanVien,
                IdKho = idKho
            };
        }
        public DeNghiNhapLaiHangBussiness(ChungTuBanHangInfor chungTuBanHangInfor)
        {
            ChungTu = chungTuBanHangInfor;
            ListChiTietChungTu = DNNhapTraHangMuaDataProvider.Instance.GetListChiTietChungTuByIdChungTu(ChungTu.IdChungTu);
        }

        #region save chung tu
        public void SaveChungTu()
        {
            SaveChungTuHeader();
            SaveChungTuDetails();
        }
        public void SaveChungTuHeader()
        {
            if (ChungTu.IdChungTu == 0)//them moi
            {
                ChungTu.IdChungTu = DNNhapTraHangMuaDataProvider.Instance.InsertChungTu(ChungTu);
            }
            else
            {
                DNNhapTraHangMuaDataProvider.Instance.UpdateChungTu(ChungTu);
            }
        }

        private void SaveChungTuDetails()
        {
            List<NhapHangTraChiTietHHInfor> listOrigin =
                DNNhapTraHangMuaDataProvider.Instance.GetListChiTietChungTuByIdChungTu(ChungTu.IdChungTu);

            //xoa nhung cai cu
            foreach (NhapHangTraChiTietHHInfor originInfo in listOrigin)
            {
                if (!ListChiTietChungTu.Exists(delegate(NhapHangTraChiTietHHInfor match)
                {
                    return match.IdChungTuChiTiet == originInfo.IdChungTuChiTiet;
                }))
                {
                    DNNhapTraHangMuaDataProvider.Instance.DeleteChiTietChungTu(originInfo);
                }
            }

            //them hoac cap nhat cai moi
            foreach (NhapHangTraChiTietHHInfor newInfo in ListChiTietChungTu)
            {
                NhapHangTraChiTietHHInfor originInfo = listOrigin.Find(
                    delegate(NhapHangTraChiTietHHInfor match)
                    {
                        return match.IdChungTuChiTiet == newInfo.IdChungTuChiTiet;
                    });

                if (originInfo != null)
                {
                    if (!newInfo.IsOrigin)
                        DNNhapTraHangMuaDataProvider.Instance.UpdateChiTietChungTu(newInfo);
                }
                else
                {
                    newInfo.IdChungTu = ChungTu.IdChungTu;
                    newInfo.IdChungTuChiTiet = DNNhapTraHangMuaDataProvider.Instance.InsertChiTietChungTu(newInfo);
                }
            }
        }
        #endregion

        #region delete chungtu
        public void DeleteChungTu()
        {
            BanHangDataProvider.Instance.DeleteAllChungTu(ChungTu.IdChungTu);
        }
        #endregion
    }
}
