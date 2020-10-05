using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    public class frmLookUpBaseMaVach : frmLookUp_BaseNew<ChungTuBanHangChiTietHangHoaInfor>
    {
        public frmLookUpBaseMaVach(){}

        public frmLookUpBaseMaVach(bool isMultiSelect, List<ChungTuBanHangChiTietHangHoaInfor> liChungTuBanHangChiTietHangHoa)
            : base(isMultiSelect)
        {
            this.ListInitInfo = liChungTuBanHangChiTietHangHoa;
        }

        protected override void OnLoad()
        {
            //ListInitInfo = DmSanPhamProvider.GetListSanPhamBrief(suDung, chietKhau);
        }
    }
}
