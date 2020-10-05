using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules;
using QLBanHang.Modules.BanHang;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.DongBoERP;
using QLBanHang.Modules.HeThong;
using QLBH.Common;
using QLBH.Core.Data;

namespace QLBanHang.TestUnits
{
    [TestClass]
    public class BH_TraLaiHangTest
    {
        public BH_TraLaiHangTest()
        {
            ConnectionUtil.Instance.IsUAT = 1;
            frmLogin frmLogin = new frmLogin();
            frmLogin.TestLogin("quantri", "khong biet dau");
        }
        #region TestSys
        [TestMethod]
        public void TestSys()
        {
            frmMain frm = new frmMain();
            frm.ShowDialog();
        }

        [TestMethod]
        public void frmDMDeNghiDoiMa()
        {
            frmDMDeNghiDoiMa frm = new frmDMDeNghiDoiMa();
            frm.ShowDialog();
        }

        [TestMethod]
        public void frmDMXacNhanDoiMa()
        {
            frmDMXacNhanDoiMa frm = new frmDMXacNhanDoiMa();
            frm.ShowDialog();
        }
        [TestMethod]
        public void frmDMDnTraHangMua()
        {
            frmDMDnTraHangMua frm = new frmDMDnTraHangMua();
            frm.ShowDialog();
        }
        [TestMethod]
        public void sysdmkt()
        {
            frmXacNhanNhapHangTraLai frm = new frmXacNhanNhapHangTraLai();
            frm.ShowDialog();
            
        }

        [TestMethod]
        public void BangGiaLichSu()
        {
            frmBH_BangGiaBanHang_LichSu frm = new frmBH_BangGiaBanHang_LichSu();
            frm.ShowDialog();
        }

        #endregion
    }
}
