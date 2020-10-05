using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBH.Core.Data;

namespace QLBanHang.TestUnits
{
    [TestClass]
    public class LichSuMaVachTest
    {
        public LichSuMaVachTest()
        {
            ConnectionUtil.Instance.IsUAT = 3;// 1:UAT; 2:Test1; 3:Test
        }

    }
}
