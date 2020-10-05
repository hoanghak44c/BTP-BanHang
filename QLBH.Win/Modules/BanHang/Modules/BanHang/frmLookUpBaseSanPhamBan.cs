using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    public class frmLookUpBaseSanPhamBan : frmLookUp_BaseNew<BangGiaBanChiTietInfor>
    {
        public frmLookUpBaseSanPhamBan(){}

        public frmLookUpBaseSanPhamBan(bool isMultiSelect, List<BangGiaBanChiTietInfor> liBangGiaBanChiTiet)
            : base(isMultiSelect)
        {
            this.ListInitInfo = liBangGiaBanChiTiet;
        }

        protected override void OnLoad()
        {
            //ListInitInfo = DmSanPhamProvider.GetListSanPhamBrief(suDung, chietKhau);
        }
    }
}
