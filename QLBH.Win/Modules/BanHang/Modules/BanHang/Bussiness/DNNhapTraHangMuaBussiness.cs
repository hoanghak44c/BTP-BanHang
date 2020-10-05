using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBH.Common;
using QLBH.Core.Business;

namespace QLBanHang.Modules.BanHang.Bussiness
{
    public class DNNhapTraHangMuaBussiness : ChungTuNhapKeToanBusinessBase<ChungTuBanHangInfor, NhapHangTraChiTietHHInfor>
    {
        public DNNhapTraHangMuaBussiness()
        {
            ChungTu = new ChungTuBanHangInfor
            {
                LoaiChungTu = Common.IntValue(TransactionType.NHAPTRAHANGMUA),
                IdNhanVien = Declare.IdNhanVien,
                IdKho = Declare.IdKho
            };
        }

        public DNNhapTraHangMuaBussiness(int loaiChungTu, int idNhanVien, int idKho)
        {
            ChungTu = new ChungTuBanHangInfor
            {
                LoaiChungTu = loaiChungTu,
                IdNhanVien = idNhanVien,
                IdKho = idKho
            };
        }
        public DNNhapTraHangMuaBussiness(ChungTuBanHangInfor ChungTuBanHangInfor)
            : base(ChungTuBanHangInfor)
        {
            //if (ChungTuBanHangInfor.LoaiChungTu != Common.IntValue(TransactionType.NHAPTRAHANGMUA) &&
            //    ChungTuBanHangInfor.LoaiChungTu != Common.IntValue(TransactionType.DON_HANG_NHAP_LAI))
            //{
            //    throw new Exception("Không phải loại chứng từ trả lại hàng bán");
            //}
        }

        protected override void CreateBusinessProvider()
        {
            BusinessKeToanKhoProvider = DNNhapTraHangMuaDataProvider.Instance;
        }

        #region delete chungtu
        public void DeleteChungTuGoc(int idChungTu)
        {
            BanHangDataProvider.Instance.DeleteAllChungTu(idChungTu);
        }
        #endregion
    }
}
