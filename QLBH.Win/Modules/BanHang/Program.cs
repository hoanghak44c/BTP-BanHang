using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLBanHang.Modules;
using QLBanHang.Modules.BanHang;
using QLBH.Core.Data;

namespace QLBanHang
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ConnectionUtil.Instance.IsUAT = 3;// 1:UAT; 2:Test1; 3:Test
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            ////Application.Run(new frmImport_TestPerformance());
            Application.Run(new frmMain());
        }
    }
}
