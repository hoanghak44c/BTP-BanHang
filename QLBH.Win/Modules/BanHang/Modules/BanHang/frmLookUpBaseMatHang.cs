using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    public class frmLookUpBaseMatHang : frmLookUp_Base<ChungTuBanHangChiTietHangHoaInfor>
    {
        public frmLookUpBaseMatHang(){}

        public frmLookUpBaseMatHang(bool isMultiSelect, List<ChungTuBanHangChiTietHangHoaInfor> liChungTuBanHangChiTietHangHoa)
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
