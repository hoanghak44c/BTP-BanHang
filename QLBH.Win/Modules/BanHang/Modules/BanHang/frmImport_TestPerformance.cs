using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
//using QLBanHang.Class;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;
using QLBH.Common.Providers;
using QLBH.Core.Data;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.BanHang.Bussiness;
using QLBH.Core.Form;
using QLBH.Core.Exceptions;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmImport_TestPerformance : DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"
        private LoaiGiaoDichBanHang LoaiGiaoDich;
        private List<ChungTuBanHangChiTietBCInfor> liChungTuChiTiet = new List<ChungTuBanHangChiTietBCInfor>();
        public TimKiemChungTuChiTietFilterInfor filter = new TimKiemChungTuChiTietFilterInfor();
        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();

        private List<MsgTest> arrImportMsg = new List<MsgTest>();
        private List<string> arrImportErr = new List<string>();
        private List<StringBuilder> arrImportOK = new List<StringBuilder>();
        private DataSet dsChungTu, dsPhieuThu, dsPhieuXuat;
        private int SoUser = 0;
        private int SoLanLap = 0;
        private int ThoiGian = 0;
        private int KichBanTest = 0;
        private string SoChungTu = "";
        private Thread[] users;
        private int Count = 0;
        private string soCT = "12345";
        private string strErr = "";
        static object syncObj = new object();


#endregion

#region "Các phương thức khởi tạo"
        public frmImport_TestPerformance()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }
#endregion

#region "Các sự kiên"
        private void frmBH_TimChungTu_Load(object sender, EventArgs e)
        {
            try
            {
                dgSetStatus = SetStatus;
                dgDisableChapNhanButton = SetChapNhanButtonEnableState;
                btnStartTest.Enabled = false;
                timer1.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            btnStopTest_Click(sender, e);
            this.Close();
        }
#endregion


        private void frmBH_TimChungTu_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void cmdExport_Click(object sender, EventArgs e)
        {
            frmImport_TestPerformance_Param frm = new frmImport_TestPerformance_Param(SoUser, SoLanLap, ThoiGian,
                                                                                      KichBanTest, SoChungTu);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                SoUser = frm.SoUser;
                SoLanLap = frm.SoLanLap;
                ThoiGian = frm.ThoiGian;
                KichBanTest = frm.KichBanTest;
                SoChungTu = frm.SoChungTu;
                txtSoUser.Text = Common.Double2Str(SoUser);
                txtSoLanLap.Text = Common.Double2Str(SoLanLap);
                txtThoiGianHanhDong.Text = Common.Double2Str(ThoiGian);
                cboKichBanTest.SelectedIndex = KichBanTest;
                txtSoChungTu.Text = frm.SoChungTu;

                if (KichBanTest == 0 || KichBanTest == 1)
                {
                    //txtSoChungTu.Visible = true;
                    //label3.Visible = true;
                    label3.Text = "Số chứng từ gốc";
                }                    
                else
                {
                    //txtSoChungTu.Visible = false;
                    //label3.Visible = false;
                    label3.Text = "Số lượng dữ liệu";
                }
            }

            btnStartTest.Enabled = SoUser > 0 ? true : false;
        }
        #region cac ham nghiep vu test
        /*
        1. Lập đơn hàng => Thu tiền
        2. Lập đơn hàng => Thu tiền => Xuất kho
        3. Báo cáo tồn mã vạch hiện tại
        4. Báo cáo danh sách đơn hàng bán
        5. Báo cáo phiếu thu tiền
        6. Bảng giá hiện tại
         */
        private void TestPerformance()
        {
            try
            {
                for (int i = 1; i <= SoLanLap; i++)
                {
                    switch (KichBanTest)
                    {
                        case 0:
                            LapDonHang_ThuTien(i);
                            break;
                        case 1:
                            LapDonHang_ThuTien_XuatKho(i);
                            //LapDonHang(i);
                            //ThuTien(i);
                            //XuatKho(i);
                            break;
                        case 2:
                            BaoCaoTonMaVachHienTai(i);
                            break;
                        case 3:
                            BaoCaoChiTietDonHangBan(i);
                            break;
                        case 4:
                            BaoCaoChiTietPhieuThu(i);
                            break;
                        case 5:
                            BangGiaHienTai(i);
                            break;
                        default:
                            break;
                    }
                    Thread.Sleep(ThoiGian);                    
                }
                Count++;
                //arrImportErr.Add("Xong");
                if (Count == SoUser)
                {
                    Status = "Xong. Ok!";
                    ChapNhanEnableState = true;
                    if (!String.IsNullOrEmpty(strErr))
                        MessageBox.Show(strErr);
                }
            }
            catch (Exception ex)
            {
                strErr += String.Format("\n{0} - {1}", Thread.CurrentThread.Name, ex.ToString());
                Debug.Print(ex.ToString());
            }            
        }
        private void LapDonHang_ThuTien(int stt)
        {
            object syncObj1 = new object();
            Thread thr = Thread.CurrentThread;
            Status = String.Format("{0} [Lần thực hiện thứ {1} ({2})] ...", thr.Name, stt, DateTime.Now.ToString());// String.Format("{0} đang thực hiện ...", thr.Name);
            Stopwatch watch = Stopwatch.StartNew();
            MsgTest msg = new MsgTest();
            arrImportMsg.Add(msg);
            try
            {
                msg.Infors = String.Format("{0} [Lần thực hiện thứ {1} ({2})]: {3}", thr.Name, stt,
                                           DateTime.Now.ToString(), "Lập đơn hàng => Thu tiền");
                msg.Result = "Đang load chứng từ ...";

                string soChungTu = String.IsNullOrEmpty(txtSoChungTu.Text) ? soCT : txtSoChungTu.Text.Trim();

                ChungTuBanHangInfor ctu = ImportChungTuDataProvider.Instance.LoadChungTuBySoChungTuGoc(soChungTu);
                if (ctu != null)
                {
                    LapDonHangBusiness Business = new LapDonHangBusiness(ctu);

                    msg.Result = "Đã nạp chứng từ. Đang nạp chi tiết chứng từ ...";
                    Business.ListChiTietChungTu =
                        ImportChungTuDataProvider.Instance.GetListChiTietChungTuBySoChungTuGoc(ctu.SoChungTuGoc);
                    if (Business.ListChiTietChungTu.Count == 0)
                    {
                        throw new ManagedException("Không tìm thấy chi tiết đơn hàng.");
                    }

                    msg.Result = "Đã nạp chứng từ, chi tiết chứng từ. Đang nạp phiếu thu ...";
                    Business.ListChungTuThanhToan =
                        ImportChungTuDataProvider.Instance.GetListChungTuThanhToanBySoChungTuGoc(ctu.SoChungTuGoc);

                    //cap nhat chi tiet phieu thu
                    double tienThu = 0;
                    foreach (ChungTuThanhToanInfor tt in Business.ListChungTuThanhToan)
                    {                        
                        tt.SoPhieu = String.Format("TP-{0}-{1}-{2}-{3}",
                                                  Declare.Prefix.PhieuThanhToan,
                                                  thr.Name, stt, DateTime.Now.Millisecond);
                        tt.IdTienTe = Declare.IdTienTe;
                        tt.TyGia = 1;
                        tt.SoTienChu = Common.ReadNumner_(Common.Double2Str(tt.SoTienThanhToan));
                        //tt.IdTrungTamThu = ctu.IdTrungTam;
                        tienThu += tt.SoTienThanhToan;

                        tt.TenMayTao = Declare.TenMay;
                        tt.TenMaySua = Declare.TenMay;
                    }

                    if (ctu.TongTienThanhToan < tienThu)
                    {
                        Business.ListChungTuThanhToan.Clear();//khong cho phep thu
                        ctu.TienThanhToanThuc = 0;
                        ctu.TienConNo = ctu.TongTienThanhToan;
                    }
                    else
                    {
                        ctu.TienThanhToanThuc = tienThu;
                        ctu.TienConNo = ctu.TongTienThanhToan - tienThu;
                    }
                    ctu.IdChungTu = 0;
                    ctu.SoChungTu = String.Format("TP-{0}-{1}-{2}-{3}",
                                                  Declare.Prefix.TaoDonHangBan,
                                                  thr.Name, stt, DateTime.Now.Millisecond);
                    ctu.SoPhieuXuat = String.Format("TP-{0}-{1}-{2}-{3}",
                                                  Declare.Prefix.PhieuXuatKhoHangBan,
                                                  thr.Name, stt, DateTime.Now.Millisecond);
                    ctu.TenMayTao = Declare.TenMay;
                    ctu.TenMaySua = Declare.TenMay;
                    msg.Result = "Đã nạp dữ liệu. Đang tạo đơn hàng ...";
                    //import vao pos
                    //lock (syncObj)
                    //{
                        try
                        {
                            //ConnectionUtil.Instance.BeginTransaction();
                            Business.SaveChungTu();
                            //ConnectionUtil.Instance.CommitTransaction();
                            watch.Stop();
                            msg.Result = String.Format("Thành công (Thời gian thực hiện {0})", watch.ElapsedMilliseconds);
                            msg.Ok = 1;
                            msg.Fail = 0;
                        }
                        catch (Exception ex)
                        {
                            //ConnectionUtil.Instance.RollbackTransaction();
                            watch.Stop();
                            msg.Result = String.Format("Thất bại (Thời gian {0}/err: {1})", watch.ElapsedMilliseconds, ex.ToString());
                            msg.Ok = 0;
                            msg.Fail = 1;
                        }
                    //}
                    //SaveChungTu(Business);
                    //watch.Stop();
                    //msg.Result = String.Format("Thành công (Thời gian thực hiện {0})", watch.ElapsedMilliseconds);
                    //msg.Ok = 1;
                    //msg.Fail = 0;
                }
                else
                {
                    throw new ManagedException("Không có dữ liệu!");
                }
            }
            catch (Exception ex)
            {
                
                watch.Stop();
                msg.Result = String.Format("Thất bại (Thời gian {0}/err: {1})", watch.ElapsedMilliseconds, ex.ToString());
                msg.Ok = 0;
                msg.Fail = 1;
                //CancelThread(thr);
            }
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        private void SaveChungTu(LapDonHangBusiness business)
        {
            //business.SaveChungTu();
            try
            {
                ConnectionUtil.Instance.BeginTransaction();
                business.SaveChungTu();
                ConnectionUtil.Instance.CommitTransaction();
            }
            catch 
            {
                ConnectionUtil.Instance.RollbackTransaction();
            }
        }

        private void LapDonHang_ThuTien_XuatKho(int stt)
        {
            Thread thr = Thread.CurrentThread;
            Status = String.Format("{0} [Lần thực hiện thứ {1} ({2})] ...", thr.Name, stt, DateTime.Now.ToString());// String.Format("{0} đang thực hiện ...", thr.Name);
            Stopwatch watch = Stopwatch.StartNew();
            MsgTest msg = new MsgTest();
            arrImportMsg.Add(msg);
            try
            {
                msg.Infors = String.Format("{0} [Lần thực hiện thứ {1} ({2})]: {3}", thr.Name, stt,
                                           DateTime.Now.ToString(), "Lập đơn hàng => Thu tiền => Xuất kho");
                msg.Result = "Đang load chứng từ ...";

                string soChungTu = String.IsNullOrEmpty(txtSoChungTu.Text) ? soCT : txtSoChungTu.Text.Trim();

                ChungTuBanHangInfor ctu = ImportChungTuDataProvider.Instance.LoadChungTuBySoChungTuGoc(soChungTu);
                if (ctu != null)
                {
                    ImportDonHangBusiness Business = new ImportDonHangBusiness(ctu);

                    msg.Result = "Đã nạp chứng từ. Đang nạp chi tiết chứng từ ...";
                    Business.ListChiTietChungTu =
                        ImportChungTuDataProvider.Instance.GetListChiTietChungTuBySoChungTuGoc(ctu.SoChungTuGoc);
                    if (Business.ListChiTietChungTu.Count == 0)
                    {
                        throw new ManagedException("Không tìm thấy chi tiết đơn hàng.");
                    }
                    msg.Result = "Đã nạp chứng từ, chi tiết chứng từ. Đang nạp phiếu xuất ...";
                    Business.ListChiTietHangHoa =
                        ImportChungTuDataProvider.Instance.GetListChiTietHangHoaBySoChungTuGoc(ctu.SoChungTuGoc, ctu.IdKho);
                    if (Business.ListChiTietHangHoa.Count == 0)
                    {
                        throw new ManagedException("Không tìm thấy chi tiết phiếu xuất kho.");
                    }
                    msg.Result = "Đã nạp chứng từ, chi tiết chứng từ, phiếu xuất. Đang nạp phiếu thu ...";
                    Business.ListChungTuThanhToan =
                        ImportChungTuDataProvider.Instance.GetListChungTuThanhToanBySoChungTuGoc(ctu.SoChungTuGoc);

                    //cap nhat chi tiet phieu thu
                    double tienThu = 0;
                    foreach (ChungTuThanhToanInfor tt in Business.ListChungTuThanhToan)
                    {
                        tt.SoPhieu = String.Format("TP-{0}-{1}-{2}-{3}",
                                                  Declare.Prefix.PhieuThanhToan,
                                                  thr.Name, stt, DateTime.Now.Millisecond);
                        tt.IdTienTe = Declare.IdTienTe;
                        tt.TyGia = 1;
                        tt.SoTienChu = Common.ReadNumner_(Common.Double2Str(tt.SoTienThanhToan));
                        //tt.IdTrungTamThu = ctu.IdTrungTam;
                        tienThu += tt.SoTienThanhToan;

                        tt.TenMayTao = Declare.TenMay;
                        tt.TenMaySua = Declare.TenMay;
                    }

                    if (ctu.TongTienThanhToan < tienThu)
                    {
                        Business.ListChungTuThanhToan.Clear();//khong cho phep thu
                        ctu.TienThanhToanThuc = 0;
                        ctu.TienConNo = ctu.TongTienThanhToan;
                    }
                    else
                    {
                        ctu.TienThanhToanThuc = tienThu;
                        ctu.TienConNo = ctu.TongTienThanhToan - tienThu;
                    }
                    ctu.IdChungTu = 0;
                    ctu.SoChungTu = String.Format("TP-{0}-{1}-{2}-{3}",
                                                  Declare.Prefix.TaoDonHangBan,
                                                  thr.Name, stt, DateTime.Now.Millisecond);
                    ctu.SoPhieuXuat = String.Format("TP-{0}-{1}-{2}-{3}",
                                                  Declare.Prefix.PhieuXuatKhoHangBan,
                                                  thr.Name, stt, DateTime.Now.Millisecond);
                    ctu.TenMayTao = Declare.TenMay;
                    ctu.TenMaySua = Declare.TenMay;
                    msg.Result = "Đã nạp dữ liệu. Đang tạo đơn hàng ...";
                    //import vao pos
                    //lock (syncObj)
                    //{
                        try
                        {
                            //ConnectionUtil.Instance.BeginTransaction();
                            Business.SaveChungTu();
                            //ConnectionUtil.Instance.CommitTransaction();
                            watch.Stop();
                            msg.Result = String.Format("Thành công (Thời gian thực hiện {0})", watch.ElapsedMilliseconds);
                            msg.Ok = 1;
                            msg.Fail = 0;
                        }
                        catch (Exception ex)
                        {
                            //ConnectionUtil.Instance.RollbackTransaction();
                            watch.Stop();
                            msg.Result = String.Format("Thất bại (Thời gian {0}/err: {1})", watch.ElapsedMilliseconds, ex.ToString());
                            msg.Ok = 0;
                            msg.Fail = 1;
                        }
                    //}
                }
                else
                {
                    throw new ManagedException("Không có dữ liệu!");
                }
            }
            catch (Exception ex)
            {
                watch.Stop();
                msg.Result = String.Format("Thất bại (Thời gian {0}/err: {1})", watch.ElapsedMilliseconds, ex.ToString());
                msg.Ok = 0;
                msg.Fail = 1;
                //CancelThread(thr);
            }
        }
        //private void LapDonHang(int stt)
        //{
        //    Thread thr = Thread.CurrentThread;
        //    string msg = String.Format("{0} [Lần thực hiện thứ {1} ({2})]: {3}", thr.Name, stt, DateTime.Now.ToString(),
        //                               "LapDonHang");
        //    arrImportErr.Add(msg);
        //    Status = msg;// String.Format("{0} đang thực hiện ...", thr.Name);
        //}
        //private void ThuTien(int stt)
        //{
        //    Thread thr = Thread.CurrentThread;
        //    string msg = String.Format("{0} [Lần thực hiện thứ {1} ({2})]: {3}", thr.Name, stt, DateTime.Now.ToString(),
        //                               "ThuTien");
        //    arrImportErr.Add(msg);
        //    Status = msg;// String.Format("{0} đang thực hiện ...", thr.Name);
        //}
        //private void XuatKho(int stt)
        //{
        //    Thread thr = Thread.CurrentThread;
        //    string msg = String.Format("{0} [Lần thực hiện thứ {1} ({2})]: {3}", thr.Name, stt, DateTime.Now.ToString(),
        //                               "XuatKho");
        //    arrImportErr.Add(msg);
        //    Status = msg;// String.Format("{0} đang thực hiện ...", thr.Name);
        //}
        private void BaoCaoTonMaVachHienTai(int stt)
        {
            Thread thr = Thread.CurrentThread;
            Status = String.Format("{0} [Lần thực hiện thứ {1} ({2})] ...", thr.Name, stt, DateTime.Now.ToString());// String.Format("{0} đang thực hiện ...", thr.Name);
            Stopwatch watch = Stopwatch.StartNew();
            MsgTest msg = new MsgTest();
            try
            {
                TimKiemChungTuChiTietFilterInfor filter = new TimKiemChungTuChiTietFilterInfor();
                filter.SoBatDau = 0;
                filter.SoKetThuc = Common.IntValue(SoChungTu) != 0 ? Common.IntValue(SoChungTu) : 100;//-1
                msg.Infors = String.Format("{0} [Lần thực hiện thứ {1} ({2})]: {3}", thr.Name, stt,
                                           DateTime.Now.ToString(), "BaoCaoChiTietDonHangBan");
                msg.Result = "Đang thực hiện ...";
                arrImportMsg.Add(msg);
                List<LichSuChiTietMaVachInfor> liTimKiem = BanHangDataProvider.Instance.TimKiemTonChiTietMaVachPg(filter);
                watch.Stop();
                msg.Result = String.Format("Thành công (Thời gian {0}/{1} kết quả)", watch.ElapsedMilliseconds, liTimKiem.Count);
                msg.Ok = 1;
                msg.Fail = 0;
            }
            catch (Exception ex)
            {
                watch.Stop();
                msg.Result = String.Format("Thất bại (Thời gian {0}/err: {1})", watch.ElapsedMilliseconds, ex.ToString());
                msg.Ok = 0;
                msg.Fail = 1;
                //CancelThread(thr);
            }
        }
        private void BaoCaoChiTietDonHangBan(int stt)
        {
            Thread thr = Thread.CurrentThread;
            Status = String.Format("{0} [Lần thực hiện thứ {1} ({2})] ...", thr.Name, stt, DateTime.Now.ToString());// String.Format("{0} đang thực hiện ...", thr.Name);
            Stopwatch watch = Stopwatch.StartNew();
            MsgTest msg = new MsgTest();
            try
            {
                TimKiemChungTuChiTietFilterInfor filter = new TimKiemChungTuChiTietFilterInfor();
                filter.SoBatDau = 0;
                filter.SoKetThuc = Common.IntValue(SoChungTu) != 0 ? Common.IntValue(SoChungTu) : 100;//-1
                msg.Infors = String.Format("{0} [Lần thực hiện thứ {1} ({2})]: {3}", thr.Name, stt,
                                           DateTime.Now.ToString(), "Báo cáo chi tiết đơn hàng bán");
                msg.Result = "Đang thực hiện ...";
                arrImportMsg.Add(msg);
                //List<ChungTuBanHangChiTietBCInfor> liTimKiem = BanHangDataProvider.Instance.TimKiemChungTuChiTietPg(filter);
                watch.Stop();
                //msg.Result = String.Format("Thành công (Thời gian {0}/{1} kết quả)", watch.ElapsedMilliseconds, liTimKiem.Count);
                msg.Ok = 1;
                msg.Fail = 0;
            }
            catch (Exception ex)
            {
                watch.Stop();
                msg.Result = String.Format("Thất bại (Thời gian {0}/err: {1})", watch.ElapsedMilliseconds, ex.ToString());
                msg.Ok = 0;
                msg.Fail = 1;
            }
        }
        private void BaoCaoChiTietPhieuThu(int stt)
        {
            Thread thr = Thread.CurrentThread;
            Status = String.Format("{0} [Lần thực hiện thứ {1} ({2})] ...", thr.Name, stt, DateTime.Now.ToString());// String.Format("{0} đang thực hiện ...", thr.Name);
            Stopwatch watch = Stopwatch.StartNew();
            MsgTest msg = new MsgTest(); 
            try
            {
                TimKiemPhieuThuFilterInfor filter = new TimKiemPhieuThuFilterInfor();
                filter.SoBatDau = 0;
                filter.SoKetThuc = Common.IntValue(SoChungTu) != 0 ? Common.IntValue(SoChungTu) : 100;//-1
                msg.Infors = String.Format("{0} [Lần thực hiện thứ {1} ({2})]: {3}", thr.Name, stt,
                                           DateTime.Now.ToString(), "Báo cáo chi tiết phiếu thu");
                msg.Result = "Đang thực hiện ...";
                arrImportMsg.Add(msg);
                List<ChungTuThanhToanInfor> liTimKiem = BaoCaoChiTietPhieuThuChiDataProvider.Instance.TimKiemPThuCTietPg(filter);
                watch.Stop();
                msg.Result = String.Format("Thành công (Thời gian {0}/{1} kết quả)", watch.ElapsedMilliseconds, liTimKiem.Count);
                msg.Ok = 1;
                msg.Fail = 0;
            }
            catch (Exception ex)
            {
                watch.Stop();
                msg.Result = String.Format("Thất bại (Thời gian {0}/err: {1})", watch.ElapsedMilliseconds, ex.ToString());
                msg.Ok = 0;
                msg.Fail = 1;
                //CancelThread(thr);
            }
        }
        private void BangGiaHienTai(int stt)
        {
            Thread thr = Thread.CurrentThread;
            Status = String.Format("{0} [Lần thực hiện thứ {1} ({2})] ...", thr.Name, stt, DateTime.Now.ToString());// String.Format("{0} đang thực hiện ...", thr.Name);
            Stopwatch watch = Stopwatch.StartNew();
            MsgTest msg = new MsgTest();
            try
            {
                int soBatDau = 0;
                int soKetThuc = Common.IntValue(SoChungTu) != 0 ? Common.IntValue(SoChungTu) : 100;//-1
                int idTrungTam = Declare.IdTrungTam;
                int coTon = 1;// : 0;

                msg.Infors = String.Format("{0} [Lần thực hiện thứ {1} ({2})]: {3}", thr.Name, stt,
                                           DateTime.Now.ToString(), "Bảng giá hiện tại");
                msg.Result = "Đang thực hiện ...";
                arrImportMsg.Add(msg);
                List<BangGiaBanChiTietBCInfor> liTimKiem = BangGiaDataProvider.Instance.GetBangGiaBanPg(idTrungTam, coTon, soBatDau, soKetThuc, "", "", Declare.SOLUONG_HIENTHI_TON, -1);
                watch.Stop();
                msg.Result = String.Format("Thành công (Thời gian {0}/{1} kết quả)", watch.ElapsedMilliseconds, liTimKiem.Count);
                msg.Ok = 1;
                msg.Fail = 0;
            }
            catch (Exception ex)
            {
                watch.Stop();
                msg.Result = String.Format("Thất bại (Thời gian {0}/err: {1})", watch.ElapsedMilliseconds, ex.ToString());
                msg.Ok = 0;
                msg.Fail = 1;
                //CancelThread(thr);
            }
        }
        #endregion


        private void btnImportToPOS_Click(object sender, EventArgs e)
        {
            try
            {
                if (SoUser == 0 || ThoiGian == 0 || KichBanTest < 0)
                {
                    MessageBox.Show("Chưa có tham số để test. Xin mời chọn tham số!");
                    btnThamSo.Focus();
                    return;
                }

                lblStatus.Text = "Đang thực hiện ...";
                //import du lieu ban
                arrImportMsg = new List<MsgTest>();
                gImportErrors.DataSource = new BindingList<MsgTest>(arrImportMsg);
                //gvImportErrors.Columns[0].Caption = "Ghi chú";
                gvImportErrors.Columns[0].Width = 500;

                ChapNhanEnableState = false;
                users = new Thread[SoUser];
                Count = 0;
                strErr = "";
                string hostname = Dns.GetHostName();
                for (int i = 0; i < SoUser; i++)
                {
                    users[i] = new Thread(TestPerformance);

                    users[i].Name = String.Format("User{0}/{1}", i + 1, hostname);
                    users[i].Start();
                }                
            }
            catch (Exception ex)
            {
                ChapNhanEnableState = true;
                Debug.Print(ex.ToString());
                frmMsgBox.Instance.ShowMessage("Loi: " + ex.ToString());
            }
        }

        private delegate void SetStatusDelegate(string value);
        private SetStatusDelegate dgSetStatus;
        private void SetStatus(string value)
        {
            lblStatus.Text = value;

            ((BindingList<MsgTest>)gImportErrors.DataSource).ResetBindings();
            gvImportErrors.FocusedRowHandle = arrImportErr.Count - 1;
        }
        private string Status
        {
            set
            {
                this.Invoke(dgSetStatus, value);
            }
        }

        private delegate void DisableChapNhanButtonDelegate(bool value);
        private DisableChapNhanButtonDelegate dgDisableChapNhanButton;
        private void SetChapNhanButtonEnableState(bool value)
        {
            btnStartTest.Enabled = value;
            //if (!value)
            //    btnStartTest.Enabled = false;
            //else
            //{
            //    bool finish = Count == SoUser ? true : false;
            //    //foreach (Thread th in users)
            //    //{
            //    //    if (th.IsAlive)
            //    //    {
            //    //        finish = false;
            //    //        break;
            //    //    }
            //    //}
            //    btnStartTest.Enabled = (SoUser > 0) ? finish : false;
            //}
        }
        private bool ChapNhanEnableState
        {
            get { return btnStartTest.Enabled; }
            set { this.Invoke(dgDisableChapNhanButton, value); }
        }

        private delegate void CloseFormDelegate();
        private CloseFormDelegate dgCloseForm;
        private void CloseFormWithThread()
        {
            if (dgCloseForm == null)
                dgCloseForm = new CloseFormDelegate(this.Close);
            this.Invoke(dgCloseForm);
        }

        private void gvImportErrors_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.FieldName.Equals("Result"))
            {
                if (e.CellValue != null && e.CellValue.ToString().StartsWith("Thất bại"))
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.ForeColor = Color.Yellow;
                }
            }  
        }

        private void btnExportErr_Click(object sender, EventArgs e)
        {
            Common.DevExport2Excel(gvImportErrors);
        }

        private void btnStopTest_Click(object sender, EventArgs e)
        {
            try
            {
                if (SoUser > 0)
                {
                    if (MessageBox.Show("Hệ thống đang thực hiện ..., bạn có muốn hủy không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                    foreach (Thread thr in users)
                    {
                        CancelThread(thr);
                    }
                }
                ChapNhanEnableState = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void CancelThread(Thread th)
        {
            try
            {
                if (th != null && th.IsAlive)
                    th.Abort();
            }
            catch 
            {
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string sql = "Select count(*) from v$session where username='POS' and program like 'QLB%'";
                string count = DBTools.getValue(sql);
                txtSession.Text = String.IsNullOrEmpty(count) ? "0" : count;

                string sql1 = @"select sid,serial#,user#,username,command,status,server,schemaname, osuser,process,machine,port,terminal,program,
                                       type,sql_Id,sql_child_number,sql_exec_start,action,event,state,service_name 
                                from v$session where username='POS' and program like 'QLB%'";

                DataSet ds = DBTools.getData("session", sql1);
                gDB.DataSource = ds.Tables["session"];
                gvDB.Columns[3].Width = 150;
                gvDB.Columns[5].Width = 150;
                gvDB.Columns[6].Width = 150;
                gvDB.Columns[7].Width = 150;
                gvDB.Columns[8].Width = 150;
                gvDB.Columns[9].Width = 150;
                gvDB.Columns[10].Width = 250;
                gvDB.Columns[12].Width = 150;
                gvDB.Columns[13].Width = 150;
                gvDB.Columns[18].Width = 250;
                gvDB.Columns[19].Width = 250;
                gvDB.Columns[20].Width = 150;
                gvDB.Columns[21].Width = 150;
                gDB.Refresh();                
            }
            catch 
            {
                txtSession.Text = "0";
            }
        }

        private void txtSoChungTu_TextChanged(object sender, EventArgs e)
        {
            SoChungTu = txtSoChungTu.Text.Trim();
        }
    }
}