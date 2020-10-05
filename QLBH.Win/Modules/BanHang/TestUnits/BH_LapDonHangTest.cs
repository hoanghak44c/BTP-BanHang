using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules;
using QLBanHang.Modules.BanHang;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.DongBoERP;
using QLBanHang.Modules.HeThong;
using QLBH.Common;
using QLBH.Core.Data;

namespace QLBanHang.TestUnits
{
    [TestClass]
    public class BH_LapDonHangTest
    {
        public BH_LapDonHangTest()
        {
            ConnectionUtil.Instance.IsUAT = 1;// 1:UAT; 2:Test1; 3:Test
            frmLogin frmLogin = new frmLogin();
            //frmLogin.TestLogin("hiennt1174", "hiennt*$");
            frmLogin.TestLogin("hangltt6", "khong biet dau");
        }

        [TestMethod]
        public void TestAR0400()
        {
            var frm = new frmBC_CongNoPOS_AR0400();
            frm.ShowDialog();
        }

        [TestMethod]
        public void TestDanhSachDonHang()
        {
            var frm = new frmBC_DonHang();
            frm.ShowDialog();
        }

        [TestMethod]
        public void TestBangGiaOnline()
        {
            var frm = new frmBH_BangGiaBanHang_Online();
            frm.ShowDialog();
        }

        [TestMethod]
        public void TestKiemTraCKBan()
        {
            frmBC_LichSuGiaBan frm = new frmBC_LichSuGiaBan();
            frm.ShowDialog();
        }

        [TestMethod]
        public void ChinhSachGia()
        {
            frmCS_TimKiem_ChinhSachGia frm = new frmCS_TimKiem_ChinhSachGia();
            frm.ShowDialog();
        }

        [TestMethod]
        public void XuatKho()
        {
            frmBH_ListPhieuXuatKho frm = new frmBH_ListPhieuXuatKho();
            frm.ShowDialog();
        }

        [TestMethod]
        public void BangGiaBanHang()
        {
            frmBH_BangGiaBanHang frm = new frmBH_BangGiaBanHang();
            frm.ShowDialog();
        }
        

        #region TestSys
        [TestMethod]
        public void TestSys()
        { 
            frmMain frm = new frmMain();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestTimCT()
        {
            frmBH_TimChungTu frm = new frmBH_TimChungTu();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestPerformance()
        {
            frmImport_TestPerformance frm = new frmImport_TestPerformance();
            frm.ShowDialog();
        }

        [TestMethod]
        public void TestDongBoItemCost()
        {
            string items = @"154.0431.14278,
154.0431.25451,
154.0431.23024,
154.0431.14277,
154.0431.14276,
154.0431.25270,
154.0431.23021,
154.0431.14280,
154.0431.23023,
154.0431.25452,
154.0431.25762,
154.0431.25761,
154.0431.25763,
154.0431.25453,
154.0431.23022,
154.0431.14086,
154.0431.23027,
154.0431.23025,
154.0431.14281,
154.0431.25450,
154.0431.23020,
154.0431.14084,
154.0418.24646,
154.0418.23985,
154.0418.12701,
154.0418.24892,
154.0418.24645,
154.0418.22975,
154.0418.24893,
154.0418.25546,
154.0418.12917,
154.0418.12696,
154.0418.23523,
159.0452.15140,
154.0418.12918,
125.0319.6542,
125.0319.6541,
125.0319.6536,
125.0319.6557,
114.0299.23254,
154.0424.23993,
133.0347.6910,
133.0347.6873,
133.0347.7324,
133.0347.7323,
133.0347.7322,
137.0351.7729,
137.0351.22689,
137.0351.7730,
137.0351.7730,
137.0351.7729,
154.0434.14387,
154.0434.14415,
154.0434.14416,
148.0396.24101,
148.0396.23438,
148.0396.24102,
148.0396.24104,
148.0396.24103,
148.0396.23439,
148.0396.10010,
148.0396.10004,
148.0396.10002,
148.0396.10003,
148.0396.23437,
148.0396.24934,
148.0396.23743,
227.0697.20750,
227.0691.20710,
149.0375.23784,
148.0391.8657,
148.0391.8667,
148.0391.8653,
148.0391.8654,
148.0396.23437,
148.0396.23439,
148.0396.23438,
237.0722.21458,
125.0319.6564,
227.0697.20933,
227.0691.20910,
227.0697.20936,
227.0697.20932,
227.0691.20912,
227.0693.23672,
227.0697.20934,
227.0693.20921,
227.0691.20911,
227.0697.20935,
227.0693.20922,
227.0693.23668,
227.0691.20913,
154.0422.23988,
154.0422.23989,
148.0380.424,
195.0549.23681,
195.0549.24109,
195.0549.23677,
154.0425.13405,
154.0425.13407,
154.0425.23112,
154.0425.23111,
154.0425.22722,
154.0425.13385,
154.0425.24215,
154.0425.13380,
154.0425.13387,
154.0425.13396,
154.0425.13382,
154.0425.13391,
154.0425.13393,
154.0425.13400,
154.0425.13399,
154.0425.24220,
154.0425.25542,
154.0425.1178,
154.0425.24221,
154.0425.24222,
154.0425.24215,
154.0425.24214,
154.0425.24220,
154.0425.24219,
154.0425.24217,
154.0425.24216,
154.0425.24221,
154.0425.24222";
            //string sql = @"delete tbl_tmp_gianhap@qlbh_ta where masanpham in (" + items + ")";
            //SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(), CommandType.Text, sql);
            items = items.Replace("\r\n", "");
            BusinessSynchronize.Instance.GiaNhapSync(items);//lay gia ban
            //for (int i = 0; i < 10; i++)
            //{
            //    BangGiaNhapChiTietInfor gn = BangGiaDataProvider.Instance.GetGiaNhapChiTietInfor("125.0319.6541", 45, 1);
            //    Assert.AreEqual(gn != null, true);                
            //}
        }

        [TestMethod]
        public void TestDonHangBanOnline()
        {
            frmBH_ListDonHangOnline frm = new frmBH_ListDonHangOnline();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestDonHangBan()
        {
            frmBH_ListDonHangBanTheTVien frm = new frmBH_ListDonHangBanTheTVien();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestImportDLBanHang()
        {
            //Stopwatch watch = Stopwatch.StartNew();
            //for (int i=0; i<10; i++)
            //{
            //    Console.WriteLine(i);
            //    Thread.Sleep(10);
            //}
            //watch.Stop();
            //Console.WriteLine(watch.ElapsedMilliseconds);
            frmImport_ChungTuChiTiet frm = new frmImport_ChungTuChiTiet();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestCopy()
        {
            try
            {
                double r = 103005.5;
                double t = Common.DoubleValueInt(10.4);
                t = Common.DoubleValueInt(10.5);
                t = Common.DoubleValueInt(10.55);
                string s = Common.Double2Str(r);// "10,300.5";
                double s1 = Common.DoubleValue(s);
                MessageBox.Show(s1.ToString());

                //DateTime t = DateTime.Now;
                //DateTime t1 = new DateTime(2013,5,20,11,30,50,0);
                //MessageBox.Show(t.ToString() + ":" + t1.ToString() + ":" + t.CompareTo(t1));
                //Console.ReadKey();
                //List<DMNganHangInfor> liNganHangTT = DMNganHangDataProvider.Instance.GetListNganHangInfors();
                //DMNganHangInfor[] t = new DMNganHangInfor[liNganHangTT.Count];

                //liNganHangTT.CopyTo(t);
                //List<DMNganHangInfor> liNganHangPH = new List<DMNganHangInfor>(t);
                //MessageBox.Show(liNganHangPH.Count.ToString()); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }
        }

        [TestMethod]
        public void TestGetSoChungTu()
        {
            ChungTuBanHangInfor result= BanHangDataProvider.Instance.GetChungTuBySoChungTu<ChungTuBanHangInfor>("XXX");
            Assert.AreNotEqual(result, null);
        }

        [TestMethod]
        public void TestBaoCaoChiTietGiaoNhan()
        {
            frmBC_GiaoNhanChiTiet frm = new frmBC_GiaoNhanChiTiet();
            frm.ShowDialog();
        }

        [TestMethod]
        public void TestBaoCaoGiaoNhan()
        {
            frmBC_GiaoNhan frm = new frmBC_GiaoNhan();
            frm.ShowDialog();
        }

        [TestMethod]
        public void TestBaoCaoGiaoNhanChiTietKThuat()
        {
            frmBC_GiaoNhanChiTietKThuat frm = new frmBC_GiaoNhanChiTietKThuat();
            frm.ShowDialog();
        }

        [TestMethod]
        public void TestGiaoNhanChiTietKThuatCT()
        {
            frmBC_GiaoNhanChiTietKThuatCT frm = new frmBC_GiaoNhanChiTietKThuatCT();
            frm.ShowDialog();
        }

        [TestMethod]
        public void TestBaoCaoDoanhThu()
        {
            frmBC_PhieuThuLenDoanhSo frm = new frmBC_PhieuThuLenDoanhSo();
            frm.ShowDialog();
        }

        [TestMethod]
        public void Test_TongHopDoanhThu()
        {

            frmBC_TongHopDoanhThu frm = new frmBC_TongHopDoanhThu();
            frm.ShowDialog();
        }

        [TestMethod]
        public void Test_KichHoatBaoHanh()
        {

            frmKT_KichHoatBaoHanh frm = new frmKT_KichHoatBaoHanh();
            frm.ShowDialog();
        }
        
        [TestMethod]
        public void Test_SanPhamHienCo()
        {
            frmBC_SanPhamHienCo frm = new frmBC_SanPhamHienCo();
            frm.ShowDialog();
        }
        [TestMethod]
        public void Test_TonMaVachHienCo()
        {
            frmBC_TonMaVachHienCo frm = new frmBC_TonMaVachHienCo();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestChiTietDonHangBan()
        {
            frmBC_DonHangChiTiet frm = new frmBC_DonHangChiTiet();
            frm.ShowDialog();
        }

        [TestMethod]
        public void TestFindLastIndex()
        {
            List<int> tmp= new List<int>{1,2,3,4,5,6};
            Assert.AreEqual(tmp.FindLastIndex(4,delegate(int match) { return match == 6; }), 5);
        }

        [TestMethod]
        public void TestKhaiBaoHoaDon()
        {
            frmCS_SuDungHoaDon frm = new frmCS_SuDungHoaDon();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestThietLapSoLuongMaVachXuat()
        {
            var frm = new frmThietLapSoLuongMaVachXuat();
            frm.ShowDialog();
        }
        
        #endregion
    }
}
