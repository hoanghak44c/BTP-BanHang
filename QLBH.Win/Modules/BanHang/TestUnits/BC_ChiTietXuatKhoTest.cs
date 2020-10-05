using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules.BanHang;
using QLBanHang.Modules.HeThong;
using QLBH.Core.Data;

namespace QLBanHang.TestUnits
{
    [TestClass]
    public class BC_ChiTietXuatKhoTest
    {
        public BC_ChiTietXuatKhoTest()
        {
            ConnectionUtil.Instance.IsUAT = 1;// 1:UAT; 2:Test1; 3:Test
            frmLogin frmLogin = new frmLogin();
            //frmLogin.TestLogin("tuanlm", "tuanlm123");
            frmLogin.TestLogin("quantri", "khong biet dau");
        }

        [TestMethod]
        public void TestBaoCaoChiTietXuatKho()
        {
            var frm = new frmBC_DonHangChiTietXuatKho();

            frm.ShowDialog();
        }
    }
}