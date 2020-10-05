using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
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
    public partial class frmImport_ChungTuChiTiet : DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"
        private LoaiGiaoDichBanHang LoaiGiaoDich;
        private List<ChungTuBanHangChiTietBCInfor> liChungTuChiTiet = new List<ChungTuBanHangChiTietBCInfor>();
        public TimKiemChungTuChiTietFilterInfor filter = new TimKiemChungTuChiTietFilterInfor();
        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private ArrayList arrSoChungTu = new ArrayList();
        private List<ChungTuBanHangInfor> arrCTuImport = new List<ChungTuBanHangInfor>();
        private List<ChungTuBanHangInfor> arrCTuImportErr = new List<ChungTuBanHangInfor>();
        DataSet dsChungTu, dsPhieuThu, dsPhieuXuat, dsPhieuThuThua, dsPhieuXuatThua;
        Thread syncThread;
        private int countCT = 0;
        private int countPT = 0;
        private int type = 0;
        private string err = "";
        private string info = "";
        private ArrayList arrXoa = new ArrayList();

#endregion

#region "Các phương thức khởi tạo"
        public frmImport_ChungTuChiTiet()
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
                dgSetProgressMaxValue = SetProgressMaxValue;
                dgSetProgressCurValue = SetProgressCurValue;
                dgDisableChapNhanButton = SetChapNhanButtonEnableState;
                btnImportToPOS.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            try
            {
                if (syncThread != null && syncThread.IsAlive)
                {
                    if (MessageBox.Show("Hệ thống đang thực hiện Import dữ liệu, bạn có muốn hủy không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                    syncThread.Abort();
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }
#endregion


        private void frmBH_TimChungTu_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void cmdExport_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = String.Empty;
                openFileDialog1.FileName = String.Empty;

                //openFileDialog1.Filter = "*.xls|*.xlsx";
                if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

                using (OleDbConnection oConn = new OleDbConnection())
                {
                    dsChungTu = new DataSet();
                    dsPhieuThu = new DataSet();
                    dsPhieuXuat = new DataSet();
                    oConn.ConnectionString =
                        String.Format(
                            "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=Yes\"",
                            openFileDialog1.FileName);
                    oConn.Open();
                    //load chungtu
                    sql =
                        "Select [SoChungTuGoc],[NgayLap],[MaTrungTam],[MaKho],[MaThuongVien],[KyHieuHoaDon],[SoHoaDon],[LoaiChungTu],[MaKhachHang],[CongTy],[MaSoThue],[DiaChi],[Huyen],[Tinh],[CachGiao],[NgayHenGiaoHang],[SoDienThoai],[TenKhachHang],[SoCMND],[ThoiHanThanhToan],[NgayTao],[NguoiTao],[MaSanPham],[TyLeVAT],[SoLuong],[GiaChuaVAT],[TienVAT],[TongSo] from [HoaDon$] where [SoChungTuGoc] is not null";
                    using (OleDbDataAdapter ad = new OleDbDataAdapter(sql, oConn))
                    {
                        ad.Fill(dsChungTu, "ChungTu");
                        gListChungTu.DataSource = dsChungTu.Tables["ChungTu"];
                        //gvListChungTu.Columns["SoChungTuGoc"].GroupIndex = 0;
                        gListChungTu.Refresh();

                    }
                    //load phieu thu
                    sql =
                        "Select [SoChungTuGoc],[SoPhieuThu],[NgayThu],[TaiKhoanQuy],[MaTrungTam],[MaKhachHang],[MaThe],[DuoiThe],[SoTaiKhoan],[ChuTaiKhoan],[NganHangThanhToan],[NganHangPhatHanh],[HinhThucThanhToan],[SoTienThu],[NgayLap],[MaThuNgan],[NguoiTao] from [PhieuThu$] where [SoChungTuGoc] is not null";
                    using (OleDbDataAdapter ad = new OleDbDataAdapter(sql, oConn))
                    {
                        ad.Fill(dsPhieuThu, "PhieuThu");
                        gListPhieuThu.DataSource = dsPhieuThu.Tables["PhieuThu"];
                        gListPhieuThu.Refresh();
                    }
                    //load phieu xuat
                    sql =
                        "Select [SoChungTuGoc],[SoPhieuXuat],[NgayXuat],[MaSanPham],[MaVach],[SoLuong] from [PhieuXuat$] where [SoChungTuGoc] is not null";
                    using (OleDbDataAdapter ad = new OleDbDataAdapter(sql, oConn))
                    {
                        ad.Fill(dsPhieuXuat, "PhieuXuat");
                        gListPhieuXuat.DataSource = dsPhieuXuat.Tables["PhieuXuat"];
                        gListPhieuXuat.Refresh();
                    }
                }
                frmProgress.Instance.Description = "Đang nạp chứng từ ....";
                frmProgress.Instance.MaxValue = dsChungTu.Tables["ChungTu"].Rows.Count;
                frmProgress.Instance.DoWork(ImportChungTuFromExcel);

                frmProgress.Instance.Description = "Đang nạp phiếu thu ....";
                frmProgress.Instance.MaxValue = dsPhieuThu.Tables["PhieuThu"].Rows.Count;
                frmProgress.Instance.DoWork(ImportPhieuThuFromExcel);

                frmProgress.Instance.Description = "Đang nạp phiếu xuất ....";
                frmProgress.Instance.MaxValue = dsPhieuXuat.Tables["PhieuXuat"].Rows.Count;
                frmProgress.Instance.DoWork(ImportPhieuXuatFromExcel);
                //load du lieu thua
                LoadDuLieuThua();
                grpKetQuaTimKiem.Text =
                    String.Format("Dữ liệu gốc kết xuất từ VIP: Tổng số {0} chứng từ ({1} line hàng - {2} phiếu thu - {3} mã vạch)",
                                  arrSoChungTu.Count,
                                  dsChungTu.Tables["ChungTu"].Rows.Count, dsPhieuThu.Tables["PhieuThu"].Rows.Count, dsPhieuXuat.Tables["PhieuXuat"].Rows.Count);
                btnImportToPOS.Enabled = gvListChungTu.RowCount > 0 || gvPhieuThuThua.RowCount > 0 ||
                                         gvPhieuXuatThua.RowCount > 0
                                             ? true
                                             : false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi import dữ liệu:\n" + ex.ToString());
            }
        }

        private void ImportChungTuFromExcel()
        {
            string sql = String.Empty;

            try
            {
                arrSoChungTu = new ArrayList();
                
                ConnectionUtil.Instance.BeginTransaction();
                SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(), CommandType.Text, "insert into tbl_tmp_chungtu_imp_bk (select * from tbl_tmp_chungtu_imp minus select * from tbl_tmp_chungtu_imp_bk)");
                SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(), CommandType.Text, "delete from TBL_TMP_CHUNGTU_IMP");
                foreach (DataRow ct in dsChungTu.Tables["ChungTu"].Rows)
                {
                    string soCTGoc = ct["SoChungTuGoc"].ToString();
                    if (String.IsNullOrEmpty(soCTGoc)) continue;
                    if (!arrSoChungTu.Contains(soCTGoc))
                        arrSoChungTu.Add(soCTGoc);
                    sql = "insert into TBL_TMP_CHUNGTU_IMP values('" + ct["SoChungTuGoc"] + "',to_date('" + ct["NgayLap"] + "','dd/mm/yyyy'),'" + ct["MaKho"] + "','" + ct["MaThuongVien"] + "','" + ct["SoHoaDon"] + "','" + 
                          ct["LoaiChungTu"] + "','" + ct["MaKhachHang"] + "','" + ct["CongTy"] + "','" + ct["DiaChi"] + "','" + ct["Huyen"] + "','" +
                          ct["CachGiao"] + "',to_date('" + ct["NgayHenGiaoHang"] + "','dd/mm/yyyy'),'" + ct["SoDienThoai"] + "','" + ct["TenKhachHang"] + "','" + ct["SoCMND"] + "','" + ct["ThoiHanThanhToan"] + "',to_date('" +
                          ct["NgayTao"] + "','dd/mm/yyyy'),'" + ct["NguoiTao"] + "','" + ct["MaSanPham"] + "'," + ct["TyLeVAT"] + "," + ct["SoLuong"] + "," +
                          ct["GiaChuaVAT"] + "," + ct["TienVAT"] + "," + ct["TongSo"] + ",'" + ct["MaSoThue"] + "','" + ct["Tinh"] + "','" + ct["KyHieuHoaDon"] + "', 0, '','" + ct["MaTrungTam"] + "')";

                    SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(), CommandType.Text, sql);
                    sql =
                        String.Format(
                            @"update tbl_tmp_chungtu_imp t set t.done = (select count(sochungtu) from tbl_chungtu where loaichungtu in (8,9,10,33,34,35,36,42) and sochungtugoc='{0}'),
                                        t.thoigian = (select ngaytao from tbl_chungtu where loaichungtu in (8,9,10,33,34,35,36,42) and sochungtugoc='{0}')
                                        where t.sochungtugoc = '{0}'",
                            soCTGoc);

                    SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(), CommandType.Text, sql);

                    frmProgress.Instance.Value += 1;
                }
                ConnectionUtil.Instance.CommitTransaction();
                frmProgress.Instance.IsCompleted = true;
                frmProgress.Instance.Description = "Đã import xong chứng từ";  
            }
            catch (Exception ex)
            {
                ConnectionUtil.Instance.RollbackTransaction();
                frmProgress.Instance.IsCompleted = true;
                MessageBox.Show(ex.ToString());
                Debug.Print(ex.ToString());
                Debug.Print(sql);
            }            
        }

        private void ImportPhieuThuFromExcel()
        {
            string sql = String.Empty;

            try
            {
                ConnectionUtil.Instance.BeginTransaction();
                SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(), CommandType.Text, "insert into tbl_tmp_chungtu_thanhtoan_ibk (select * from tbl_tmp_chungtu_thanhtoan_imp minus select * from tbl_tmp_chungtu_thanhtoan_ibk)");
                SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(), CommandType.Text, "delete from TBL_TMP_CHUNGTU_THANHTOAN_IMP");
                foreach (DataRow ct in dsPhieuThu.Tables["PhieuThu"].Rows)
                {
                    string soCTGoc = ct["SoChungTuGoc"].ToString();
                    if (String.IsNullOrEmpty(soCTGoc)) continue;
                    sql = "insert into TBL_TMP_CHUNGTU_THANHTOAN_IMP values('" + ct["SoChungTuGoc"] + "','" + ct["SoPhieuThu"] + "',to_date('" + ct["NgayThu"] + "','dd/mm/yyyy'),'" + ct["MaKhachHang"] + "','" + ct["MaThe"] + "','" +
                          ct["DuoiThe"] + "','" + ct["ChuTaiKhoan"] + "','" + ct["HinhThucThanhToan"] + "'," + ct["SoTienThu"] + ",'" + ct["MaThuNgan"] + "','" + ct["NguoiTao"] + "','" + ct["TaiKhoanQuy"] + "','" +
                          ct["SoTaiKhoan"] + "','" + ct["NganHangThanhToan"] + "','" + ct["NganHangPhatHanh"] + "',to_date('" + ct["NgayLap"] + "','dd/mm/yyyy'),'" + ct["MaTrungTam"] + "')";

                    SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(), CommandType.Text, sql);

                    frmProgress.Instance.Value += 1;
                }
                ConnectionUtil.Instance.CommitTransaction();
                frmProgress.Instance.IsCompleted = true;
                frmProgress.Instance.Description = "Đã import xong phiếu thu";
            }
            catch (Exception ex)
            {
                ConnectionUtil.Instance.RollbackTransaction();
                frmProgress.Instance.IsCompleted = true;
                frmMsgBox.Instance.ShowMessage("sql: " + sql + "\r\nLoi: " + ex.ToString());
                Debug.Print(ex.ToString());
                Debug.Print(sql);
            }
        }

        private void ImportPhieuXuatFromExcel()
        {
            string sql = String.Empty;

            try
            {
                ConnectionUtil.Instance.BeginTransaction();
                SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(), CommandType.Text, "insert into tbl_tmp_chungtu_xuatkho_imp_bk (select * from tbl_tmp_chungtu_xuatkho_imp minus select * from tbl_tmp_chungtu_xuatkho_imp_bk)");
                SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(), CommandType.Text, "delete from TBL_TMP_CHUNGTU_XUATKHO_IMP");
                foreach (DataRow ct in dsPhieuXuat.Tables["PhieuXuat"].Rows)
                {
                    string soCTGoc = ct["SoChungTuGoc"].ToString();
                    if (String.IsNullOrEmpty(soCTGoc)) continue;
                    sql = "insert into TBL_TMP_CHUNGTU_XUATKHO_IMP values('" + ct["SoChungTuGoc"] + "','" + ct["SoPhieuXuat"] + "',to_date('" +
                          ct["NgayXuat"] + "','dd/mm/yyyy'),'" + ct["MaSanPham"] + "','" + ct["MaVach"] + "'," + ct["SoLuong"] + ")";

                    SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(), CommandType.Text, sql);

                    frmProgress.Instance.Value += 1;
                }
                ConnectionUtil.Instance.CommitTransaction();
                frmProgress.Instance.IsCompleted = true;
                frmProgress.Instance.Description = "Đã import xong phiếu xuất";
            }
            catch (Exception ex)
            {
                ConnectionUtil.Instance.RollbackTransaction();
                frmProgress.Instance.IsCompleted = true;
                frmMsgBox.Instance.ShowMessage("sql: " + sql + "\r\nLoi: " + ex.ToString());
                Debug.Print(ex.ToString());
                Debug.Print(sql);
            }
        }

        private void btnImportCSDL_Click(object sender, EventArgs e)
        {
            try
            {
                //load chungtu
                arrSoChungTu = new ArrayList();
                string sql = "Select * from TBL_TMP_CHUNGTU_IMP";
                dsChungTu = DBTools.getData("ChungTu", sql);
                foreach (DataRow ct in dsChungTu.Tables["ChungTu"].Rows)
                {
                    string soCTGoc = ct["SoChungTuGoc"].ToString();
                    if (!String.IsNullOrEmpty(soCTGoc) && !arrSoChungTu.Contains(soCTGoc))
                        arrSoChungTu.Add(soCTGoc);
                }
                gListChungTu.DataSource = dsChungTu.Tables["ChungTu"];
                //gvListChungTu.Columns["SoChungTuGoc"].GroupIndex = 0;
                gListChungTu.Refresh();

                //load phieu thu
                sql = "Select * from TBL_TMP_CHUNGTU_THANHTOAN_IMP";
                dsPhieuThu = DBTools.getData("PhieuThu", sql);
                gListPhieuThu.DataSource = dsPhieuThu.Tables["PhieuThu"];
                gListPhieuThu.Refresh();

                sql = "Select * from TBL_TMP_CHUNGTU_XUATKHO_IMP";
                dsPhieuXuat = DBTools.getData("PhieuXuat", sql);
                gListPhieuXuat.DataSource = dsPhieuXuat.Tables["PhieuXuat"];
                gListPhieuXuat.Refresh();

                //load du lieu thua
                LoadDuLieuThua();
                grpKetQuaTimKiem.Text =
                    String.Format("Dữ liệu gốc kết xuất từ VIP: Tổng số {0} chứng từ ({1} line hàng - {2} phiếu thu - {3} mã vạch)",
                                  arrSoChungTu.Count,
                                  dsChungTu.Tables["ChungTu"].Rows.Count, dsPhieuThu.Tables["PhieuThu"].Rows.Count, dsPhieuXuat.Tables["PhieuXuat"].Rows.Count);
                btnImportToPOS.Enabled = gvListChungTu.RowCount > 0 || gvPhieuThuThua.RowCount > 0 ||
                                         gvPhieuXuatThua.RowCount > 0
                                             ? true
                                             : false;
            }
            catch (Exception ex)
            {
                frmMsgBox.Instance.ShowMessage("Loi: " + ex.ToString());
                Debug.Print(ex.ToString());
            }
        }

        private void btnImportToPOS_Click(object sender, EventArgs e)
        {
            try
            {
                //if (arrSoChungTu == null || arrSoChungTu.Count == 0 )
                //{
                //    MessageBox.Show("Không có dữ liệu import. Chọn file Excel hoặc nạp dữ liệu gốc từ CSDL");
                //    return;
                //}

                progressBar1.Value = 0;
                lblStatus.Text = "Đang import dữ liệu ...";
                arrCTuImport = new List<ChungTuBanHangInfor>();
                gListImport.DataSource = new BindingList<ChungTuBanHangInfor>(arrCTuImport);
                selector.View = gvListImport;
                selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                selector.CheckMarkColumn.VisibleIndex = 0;
                gvListImport.Columns["GhiChu"].VisibleIndex = 0;
                gvListImport.Columns["GhiChu"].Width = 400;

                //import du lieu ban
                arrCTuImportErr = new List<ChungTuBanHangInfor>();
                gImportErrors.DataSource = new BindingList<ChungTuBanHangInfor>(arrCTuImportErr);
                gvImportErrors.Columns["GhiChu"].VisibleIndex = 0;
                gvImportErrors.Columns["GhiChu"].Width = 400;

                gvPhieuThuThua.Columns[0].VisibleIndex = 0;
                gvPhieuThuThua.Columns[0].Width = 400;
                gvPhieuXuatThua.Columns[0].VisibleIndex = 0;
                gvPhieuXuatThua.Columns[0].Width = 400;

                syncThread = new Thread(ImportDuLieuToPos);
                syncThread.Start();


            }
            catch (Exception ex)
            {
                frmProgress.Instance.IsCompleted = true;
                Debug.Print(ex.ToString());
                frmMsgBox.Instance.ShowMessage("Loi: " + ex.ToString());
            }
        }
        private void ImportDuLieuToPos()
        {
            try
            {

                ChapNhanEnableState = false;
                int dem = arrSoChungTu.Count;
                if (dsPhieuThuThua != null && dsPhieuThuThua.Tables["PhieuThuThua"].Rows.Count > 0)
                    dem += dsPhieuThuThua.Tables["PhieuThuThua"].Rows.Count;
                if (dsPhieuXuatThua != null && dsPhieuXuatThua.Tables["PhieuXuatThua"].Rows.Count > 0)
                    dem += dsPhieuXuatThua.Tables["PhieuXuatThua"].Rows.Count;

                ProgressMaxValue = dem;
                ProgressCurrentValue = 0;
                //import du lieu ban
                if (arrSoChungTu.Count > 0)
                {
                    type = 0;
                    Status = "Import dữ liệu bán hàng vào POS ....";
                    countCT = 0;
                    countPT = 0;
                    foreach (string soChungTu in arrSoChungTu)
                    {
                        countCT++;
                        Status = String.Format("Đang import chứng từ số {0}: [{1}]...", countCT, soChungTu);
                        //frmProgress.Instance.Description = String.Format("Đang import chứng từ [{0}]...", soChungTu);
                        ImportChungTu(soChungTu);
                        //frmProgress.Instance.Value += 1;
                        ProgressCurrentValue += 1;
                    }
                    Status = "Import dữ liệu bàn hàng vào POS đã hoàn thành";
                }
                //import phieu thu
                if (dsPhieuThuThua != null && dsPhieuThuThua.Tables["PhieuThuThua"].Rows.Count > 0)
                {
                    type = 1;
                    Status = "Import dữ liệu phiếu thu thêm vào POS ....";
                    countCT = 0;
                    countPT = 0;

                    foreach (DataRow ct in dsPhieuThuThua.Tables["PhieuThuThua"].Rows)
                    {
                        string soCTGoc = ct["SoChungTuGoc"].ToString();
                        string soPThu = ct["SoPhieuThu"].ToString();
                        if (String.IsNullOrEmpty(soCTGoc)) continue;
                        countCT++;
                        Status = String.Format("Đang import phiếu thu [{0}] của chứng từ gốc [{1}]...", soPThu, soCTGoc);
                        info = ImportPhieuThuThua(soCTGoc, soPThu);
                        ProgressCurrentValue += 1;
                    } 
                    Status = "Import dữ liệu phiếu thu vào POS đã hoàn thành";
                }
                //import phieu thu
                if (dsPhieuXuatThua != null && dsPhieuXuatThua.Tables["PhieuXuatThua"].Rows.Count > 0)
                {
                    type = 2;
                    Status = "Import phiếu xuất thêm vào POS ....";
                    countCT = 0;
                    countPT = 0;

                    foreach (DataRow ct in dsPhieuXuatThua.Tables["PhieuXuatThua"].Rows)
                    {
                        string soCTGoc = ct["SoChungTuGoc"].ToString();
                        string soPThu = ct["SoPhieuXuat"].ToString();
                        if (String.IsNullOrEmpty(soCTGoc)) continue;
                        countCT++;
                        Status = String.Format("Đang import phiếu xuat [{0}] của chứng từ gốc [{1}]...", soPThu, soCTGoc);
                        info = ImportPhieuXuatThua(soCTGoc, soPThu);
                        ProgressCurrentValue += 1;
                    }
                    Status = "Import dữ liệu phiếu thu vào POS đã hoàn thành";
                }
                ChapNhanEnableState = true;
            }
            catch (Exception ex)
            {
                ChapNhanEnableState = true;
                //CloseFormWithThread();
                Debug.Print(ex.ToString());
                frmMsgBox.Instance.ShowMessage("Loi: " + ex.ToString());
            }                       
        }

        //private string LoadNextChungTu(string soChungTu, int begin, int indx)
        //{
        //    int next = Common.IntValue(soChungTu.Substring(begin)) + indx;
        //    string ctu = soChungTu.Substring(0, begin);

        //    string tmp = next.ToString();
        //    for (int i = 0; i < (5 - tmp.Length); i++)
        //        ctu += "0";
        //    ctu += tmp;

        //    return ctu;
        //}

        private void ImportChungTu(string soChungTu)
        {
            ChungTuBanHangInfor ctu = new ChungTuBanHangInfor();

            try
            {
                //get header
                ctu = ImportChungTuDataProvider.Instance.LoadChungTuBySoChungTuGoc(soChungTu);
                if (ctu != null)
                {
                    if (ctu.IdDoiTuong == 0 || ctu.IdKho == 0 || ctu.IdNhanVien == 0 || ctu.IdTrungTam == 0)
                    {
                        string msg = "";
                        msg += ctu.IdDoiTuong == 0 ? "Sai mã khách hàng, " : "";
                        msg += ctu.IdTrungTam == 0 ? "Sai mã trung tâm, " : "";
                        msg += ctu.IdKho == 0 ? "Sai mã kho, " : "";
                        msg += ctu.IdNhanVien == 0 ? "Sai mã nhân viên, " : "";
                        ctu.GhiChu = msg.TrimEnd(",".ToCharArray()) + "(Các mã này chưa có trong danh mục mã của POS)";
                        arrCTuImportErr.Add(ctu);
                    }
                    else if (ctu.DongBoOracle == 1)
                    {                        
                        string thu = ImportPhieuThu(ctu);
                        string xuat = ImportPhieuXuat(ctu);
                        ctu.GhiChu = String.Format("Không thành công. Chứng từ đã được import vào POS vào [{0}].", ctu.ThoiGianDongBo);
                        if (!String.IsNullOrEmpty(thu))
                            ctu.GhiChu = ctu.GhiChu + " - " + thu;
                        if (!String.IsNullOrEmpty(xuat))
                            ctu.GhiChu = ctu.GhiChu + " - " + xuat;
                        arrCTuImport.Add(ctu);
                    }
                    else
                    {
                        try
                        {
                            if (ctu.TrangThai == 7)//lap don hang
                            {
                                SaveDonHangBan(ctu);
                            }
                            else if (ctu.TrangThai == 11)//lap don hang va xuat kho
                            {
                                SaveDonHangXuatKho(ctu);
                            }
                            else if (ctu.TrangThai == 13 || ctu.TrangThai == 21)//lap don hang tra lai
                            {
                                SaveDonHangTraLai(ctu);
                            }
                            else if (ctu.TrangThai == 14)//lap don hang tra lai va nhap kho
                            {
                                SaveDonHangNhapKho(ctu);
                            }

                            SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(), CommandType.Text,
                                                      String.Format("UPDATE TBL_TMP_CHUNGTU_IMP SET DONE=1, THOIGIAN = sysdate WHERE SOCHUNGTUGOC='{0}'",
                                                          soChungTu));
                            //luu ket qua
                            ctu.GhiChu = "Thành công";
                            arrCTuImport.Add(ctu);
                        }
                        catch (ManagedException ex)
                        {
                            //MessageBox.Show(ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ctu.GhiChu = ex.ToString();
                            arrCTuImportErr.Add(ctu);

                        }
                        catch (Exception ex)
                        {
                            ctu.GhiChu = ex.ToString();
                            arrCTuImportErr.Add(ctu);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ctu.GhiChu = ex.ToString();
                arrCTuImportErr.Add(ctu);
            }
        }
        private string ImportPhieuThu(ChungTuBanHangInfor ctu)
        {
            int count = 0;
            try
            {
                //get header
                List<ChungTuThanhToanInfor> liThem =
                    ImportChungTuDataProvider.Instance.GetListChungTuThanhToanThemBySoChungTuGoc(ctu.SoChungTuGoc, ctu.IdChungTu);
                if (liThem != null && liThem.Count > 0)
                {
                    ConnectionUtil.Instance.BeginTransaction();
                    double tienThem = 0;
                    foreach (ChungTuThanhToanInfor tt in liThem)
                    {
                        //cap nhat chi tiet phieu thu
                        tt.SoPhieu = "PTI-" + tt.SoPhieu;// LoadNextChungTu(soPhieuThuGoc, 11, countPT);
                        tt.IdTienTe = Declare.IdTienTe;
                        tt.TyGia = 1;
                        tt.SoTienChu = Common.ReadNumner_(Common.Double2Str(tt.SoTienThanhToan));
                        //tt.IdTrungTamThu = ctu.IdTrungTam;
                        tienThem += tt.SoTienThanhToan;

                        tt.TenMayTao = Declare.TenMay;
                        tt.TenMaySua = Declare.TenMay;
                        tt.IdChungTu = ctu.IdChungTu;

                        //Insert thanh toan moi
                        BanHangDataProvider.Instance.InsertChungTuThanhToan(tt);
                        count++;
                    }

                    if (ctu.TienThanhToanThuc + tienThem > ctu.TongTienThanhToan || ctu.TienConNo < tienThem)
                    {
                        ConnectionUtil.Instance.RollbackTransaction();
                        return "Tổng tiền thu thêm của các phiếu thu vượt quá số tiền cần thanh toán";
                    }
                    //cap nhat so tien thu them
                    SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(), CommandType.Text,
                                              String.Format("update tbl_chungtu t set t.tienthanhtoanthuc =  t.tienthanhtoanthuc + {0}, t.tienconno = t.tienconno - {0} where idchungtu = {1}",
                                                  tienThem, ctu.IdChungTu));
                    ConnectionUtil.Instance.CommitTransaction();
                }
                else
                {
                    return "Không có thêm phiếu thu nào";
                }
            }
            catch (Exception ex)
            {
                ConnectionUtil.Instance.RollbackTransaction();
                //frmMsgBox.Instance.ShowMessage("Loi: " + ex.ToString());
                return "Loi: " + ex.ToString();
            }
            return "Thêm " + count + " phiếu thu thành công";
        }
        private string ImportPhieuThuThua(string soCTuGoc, string soPhieuThu)
        {
            try
            {
                //get header
                ChungTuBanHangInfor ctu = ImportChungTuDataProvider.Instance.LoadChungTuBanBySoChungTuGoc(soCTuGoc);
                if (ctu == null) return "Không có đơn hàng bán";
                ChungTuThanhToanInfor tt =
                    ImportChungTuDataProvider.Instance.GetChungTuThanhToanThemBySoChungTuGoc(soCTuGoc, ctu.IdChungTu, soPhieuThu);

                if (tt == null) return "Phiếu thu này đã được lập";
                ConnectionUtil.Instance.BeginTransaction();
                //cap nhat chi tiet phieu thu
                tt.SoPhieu = "PTI-" + tt.SoPhieu;// LoadNextChungTu(soPhieuThuGoc, 11, countPT);
                tt.IdTienTe = Declare.IdTienTe;
                tt.TyGia = 1;
                tt.SoTienChu = Common.ReadNumner_(Common.Double2Str(tt.SoTienThanhToan));
                //tt.IdTrungTamThu = ctu.IdTrungTam;

                tt.TenMayTao = Declare.TenMay;
                tt.TenMaySua = Declare.TenMay;
                tt.IdChungTu = ctu.IdChungTu;

                if (ctu.TienThanhToanThuc + tt.SoTienThanhToan > ctu.TongTienThanhToan || ctu.TienConNo < tt.SoTienThanhToan)
                {
                    ConnectionUtil.Instance.RollbackTransaction();
                    return String.Format("Tổng tiền thu thêm của phiếu thu {0} vượt quá số tiền cần thanh toán", tt.SoPhieu);
                }
                //Insert thanh toan moi
                BanHangDataProvider.Instance.InsertChungTuThanhToan(tt);
                //cap nhat so tien thu them
                SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(), CommandType.Text,
                                          String.Format("update tbl_chungtu t set t.tienthanhtoanthuc =  t.tienthanhtoanthuc + {0}, t.tienconno = t.tienconno - {0} where idchungtu = {1}",
                                              tt.SoTienThanhToan, ctu.IdChungTu));
                ConnectionUtil.Instance.CommitTransaction();
            }
            catch (Exception ex)
            {
                ConnectionUtil.Instance.RollbackTransaction();
                //frmMsgBox.Instance.ShowMessage("Loi: " + ex.ToString());
                return "Loi: " + ex.ToString();
            }
            return "Thêm phiếu thu thành công";
        }

        private string ImportPhieuXuat(ChungTuBanHangInfor ct)
        {
            try
            {
                //get header
                ChungTuBanHangInfor ctu = ImportChungTuDataProvider.Instance.LoadChungTuBanBySoChungTuGoc(ct.SoChungTuGoc);
                if (ctu == null) return "Không có đơn hàng bán";
                if (ctu.LoaiChungTu == (int)TransactionType.DON_HANG_TAI_SHOP && ctu.TrangThai == (int)OrderStatus.DON_HANG_BAN_TAI_SHOP ||
                    ctu.LoaiChungTu == (int)TransactionType.DON_HANG_ONLINE && ctu.TrangThai == (int)OrderStatus.DON_HANG_BAN_ONLINE)
                {
                    XuatKhoHangBanBusiness Business = new XuatKhoHangBanBusiness(ctu);

                    Business.ListChiTietHangHoa =
                        ImportChungTuDataProvider.Instance.GetListChiTietHangHoaBySoChungTuGoc(ctu.SoChungTuGoc, ctu.IdKho);
                    if (Business.ListChiTietHangHoa.Count == 0)
                    {
                        return "Không tìm thấy chi tiết phiếu xuất kho.";
                    }
                    ctu.TrangThai = (int) OrderStatus.XUAT_KHO;
                    ctu.SoPhieuXuat = String.IsNullOrEmpty(ct.SoPhieuXuat) ? "" : "XKI-" + ct.SoPhieuXuat;
                    ctu.TenMaySua = Declare.TenMay;

                    //import vao pos
                    Business.SaveChungTu();
                }
                else if (ctu.LoaiChungTu == (int)TransactionType.DON_HANG_NHAP_LAI && (ctu.TrangThai == (int)OrderStatus.DE_NGHI_TRA_LAI_HANG_BAN || 
                         ctu.TrangThai == (int)OrderStatus.XAC_NHAN_TRA_LAI_KHAC))
                {
                    NhapTraHangMuaBussiness Business = new NhapTraHangMuaBussiness(ctu);

                    Business.ListChiTietHangHoa =
                        ImportChungTuDataProvider.Instance.GetListChiTietHangHoaBySoChungTuGoc(ctu.SoChungTuGoc, ctu.IdKho);
                    if (Business.ListChiTietHangHoa.Count == 0)
                    {
                        return "Không tìm thấy chi tiết phiếu xuất kho.";
                    }
                    ctu.TrangThai = (int)OrderStatus.XAC_NHAN_TRA_LAI_HANG_BAN;
                    ctu.SoPhieuXuat = String.IsNullOrEmpty(ct.SoPhieuXuat) ? "" : "NKI-" + ct.SoPhieuXuat;
                    ctu.TenMaySua = Declare.TenMay;

                    //import vao pos
                    Business.SaveChungTu();
                }
                else
                {
                    return "Không có thêm phiếu xuất nào"; 
                }
            }
            catch (Exception ex)
            {
                //frmMsgBox.Instance.ShowMessage("Loi: " + ex.ToString());
                return "Loi: " + ex.ToString();
            }
            return "Thêm phiếu xuất thành công";
        }
        private string ImportPhieuXuatThua(string soCTuGoc, string soPhieuXuat)
        {
            try
            {
                //get header
                ChungTuBanHangInfor ctu = ImportChungTuDataProvider.Instance.LoadChungTuBanBySoChungTuGoc(soCTuGoc);
                if (ctu == null) return "Không có đơn hàng bán";
                if (ctu.LoaiChungTu == (int)TransactionType.DON_HANG_TAI_SHOP && ctu.TrangThai == (int)OrderStatus.DON_HANG_BAN_TAI_SHOP ||
                    ctu.LoaiChungTu == (int)TransactionType.DON_HANG_ONLINE && ctu.TrangThai == (int)OrderStatus.DON_HANG_BAN_ONLINE)
                {
                    XuatKhoHangBanBusiness Business = new XuatKhoHangBanBusiness(ctu);

                    Business.ListChiTietHangHoa =
                        ImportChungTuDataProvider.Instance.GetListChiTietHangHoaBySoChungTuGoc(ctu.SoChungTuGoc, ctu.IdKho);
                    if (Business.ListChiTietHangHoa.Count == 0)
                    {
                        return "Không tìm thấy chi tiết phiếu xuất kho.";
                    }
                    ctu.TrangThai = (int)OrderStatus.XUAT_KHO;
                    ctu.SoPhieuXuat = String.IsNullOrEmpty(soPhieuXuat) ? "" : "XKI-" + soPhieuXuat;
                    ctu.TenMaySua = Declare.TenMay;

                    //import vao pos
                    Business.SaveChungTu();                        
                }
                else if (ctu.LoaiChungTu == (int)TransactionType.DON_HANG_NHAP_LAI && (ctu.TrangThai == (int)OrderStatus.DE_NGHI_TRA_LAI_HANG_BAN ||
                         ctu.TrangThai == (int)OrderStatus.XAC_NHAN_TRA_LAI_KHAC))
                {
                    NhapTraHangMuaBussiness Business = new NhapTraHangMuaBussiness(ctu);

                    Business.ListChiTietHangHoa =
                        ImportChungTuDataProvider.Instance.GetListChiTietHangHoaBySoChungTuGoc(ctu.SoChungTuGoc, ctu.IdKho);
                    if (Business.ListChiTietHangHoa.Count == 0)
                    {
                        return "Không tìm thấy chi tiết phiếu xuất kho.";
                    }
                    ctu.TrangThai = (int) OrderStatus.XAC_NHAN_TRA_LAI_HANG_BAN;
                    ctu.SoPhieuXuat = String.IsNullOrEmpty(soPhieuXuat) ? "" : "NKI-" + soPhieuXuat;
                    ctu.TenMaySua = Declare.TenMay;

                    //import vao pos
                    Business.SaveChungTu();                    
                }
                else
                {
                    return "Không có thêm phiếu xuất nào";
                }
            }
            catch (Exception ex)
            {
                //frmMsgBox.Instance.ShowMessage("Loi: " + ex.ToString());
                return "Loi: " + ex.ToString();
            }
            return "Thêm phiếu xuất thành công";
        }

        private void SaveDonHangBan(ChungTuBanHangInfor ctu)
        {
            LapDonHangBusiness Business = new LapDonHangBusiness(ctu);

            Business.ListChiTietChungTu =
                ImportChungTuDataProvider.Instance.GetListChiTietChungTuBySoChungTuGoc(ctu.SoChungTuGoc);
            if (Business.ListChiTietChungTu.Count == 0)
            {
                throw new ManagedException("Không tìm thấy chi tiết đơn hàng.");
            }

            Business.ListChungTuThanhToan =
                ImportChungTuDataProvider.Instance.GetListChungTuThanhToanBySoChungTuGoc(ctu.SoChungTuGoc);

            //cap nhat chi tiet phieu thu
            double tienThu = 0;
            foreach (ChungTuThanhToanInfor tt in Business.ListChungTuThanhToan)
            {
                countPT++;
                tt.SoPhieu = "PTI-" + tt.SoPhieu;// LoadNextChungTu(soPhieuThuGoc, 11, countPT);
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
            ctu.SoChungTu = "ODI-" + ctu.SoChungTuGoc;// LoadNextChungTu(soDonHangGoc, 10, countCT);
            ctu.TenMayTao = Declare.TenMay;
            ctu.TenMaySua = Declare.TenMay;

            //import vao pos
            Business.SaveChungTu();
        }

        private void SaveDonHangTraLai(ChungTuBanHangInfor ctu)
        {
            ImportDonHangNLBussiness Business = new ImportDonHangNLBussiness(ctu);

            Business.ListChiTietChungTu =
                ImportChungTuDataProvider.Instance.GetListChiTietChungTuBySoChungTuGoc(ctu.SoChungTuGoc);
            if (Business.ListChiTietChungTu.Count == 0)
            {
                throw new ManagedException("Không tìm thấy chi tiết đơn hàng.");
            }

            Business.ListChungTuThanhToan =
                ImportChungTuDataProvider.Instance.GetListChungTuThanhToanBySoChungTuGoc(ctu.SoChungTuGoc);

            //cap nhat chi tiet phieu thu
            double tienChi = 0;
            foreach (ChungTuThanhToanInfor tt in Business.ListChungTuThanhToan)
            {
                countPT++;
                tt.SoPhieu = "PCI-" + tt.SoPhieu;// LoadNextChungTu(soPhieuThuGoc, 11, countPT);
                tt.IdTienTe = Declare.IdTienTe;
                tt.TyGia = 1;
                tt.SoTienChu = Common.ReadNumner_(Common.Double2Str(tt.SoTienThanhToan));
                //tt.IdTrungTamThu = ctu.IdTrungTam;
                tienChi += tt.SoTienThanhToan;

                tt.TenMayTao = Declare.TenMay;
                tt.TenMaySua = Declare.TenMay;
            }

            if (ctu.TongTienThanhToan < tienChi)
            {
                Business.ListChungTuThanhToan.Clear();//khong cho phep thu
                ctu.TienThanhToanThuc = 0;
                ctu.TienConNo = ctu.TongTienThanhToan;
            }
            else
            {
                ctu.TienThanhToanThuc = tienChi;
                ctu.TienConNo = ctu.TongTienThanhToan - tienChi;
            }

            ctu.SoChungTu = "NLI-" + ctu.SoChungTuGoc;// LoadNextChungTu(soDonHangGoc, 10, countCT);
            ctu.TenMayTao = Declare.TenMay;
            ctu.TenMaySua = Declare.TenMay;

            //import vao pos
            Business.SaveChungTu();
        }

        private void SaveDonHangXuatKho(ChungTuBanHangInfor ctu)
        {
            ImportDonHangBusiness Business = new ImportDonHangBusiness(ctu);

            Business.ListChiTietChungTu =
                ImportChungTuDataProvider.Instance.GetListChiTietChungTuBySoChungTuGoc(ctu.SoChungTuGoc);
            if (Business.ListChiTietChungTu.Count == 0)
            {
                throw new ManagedException("Không tìm thấy chi tiết đơn hàng.");
            }
            Business.ListChiTietHangHoa =
                ImportChungTuDataProvider.Instance.GetListChiTietHangHoaBySoChungTuGoc(ctu.SoChungTuGoc, ctu.IdKho);
            if (Business.ListChiTietHangHoa.Count == 0)
            {
                throw new ManagedException("Không tìm thấy chi tiết phiếu xuất kho.");
            }
            Business.ListChungTuThanhToan =
                ImportChungTuDataProvider.Instance.GetListChungTuThanhToanBySoChungTuGoc(ctu.SoChungTuGoc);

            //cap nhat chi tiet phieu thu
            double tienThu = 0;
            foreach (ChungTuThanhToanInfor tt in Business.ListChungTuThanhToan)
            {
                countPT++;
                tt.SoPhieu = "PTI-" + tt.SoPhieu;// LoadNextChungTu(soPhieuThuGoc, 11, countPT);
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

            ctu.SoChungTu = "ODI-" + ctu.SoChungTuGoc;// LoadNextChungTu(soDonHangGoc, 10, countCT);
            ctu.SoPhieuXuat = String.IsNullOrEmpty(ctu.SoPhieuXuat) ? "" : "XKI-" + ctu.SoPhieuXuat;
            ctu.TenMayTao = Declare.TenMay;
            ctu.TenMaySua = Declare.TenMay;

            //import vao pos
            Business.SaveChungTu();    
        }

        private void SaveDonHangNhapKho(ChungTuBanHangInfor ctu)
        {
            ImportNhapLapBusiness Business = new ImportNhapLapBusiness(ctu);

            Business.ListChiTietChungTu =
                ImportChungTuDataProvider.Instance.GetListChiTietChungTuBySoChungTuGoc(ctu.SoChungTuGoc);
            if (Business.ListChiTietChungTu.Count == 0)
            {
                throw new ManagedException("Không tìm thấy chi tiết đơn hàng.");
            }
            Business.ListChiTietHangHoa =
                ImportChungTuDataProvider.Instance.GetListChiTietHangHoaBySoChungTuGoc(ctu.SoChungTuGoc, ctu.IdKho);
            if (Business.ListChiTietHangHoa.Count == 0)
            {
                throw new ManagedException("Không tìm thấy chi tiết phiếu xuất kho.");
            }
            Business.ListChungTuThanhToan =
                ImportChungTuDataProvider.Instance.GetListChungTuThanhToanBySoChungTuGoc(ctu.SoChungTuGoc);

            //cap nhat chi tiet phieu thu
            double tienChi = 0;
            foreach (ChungTuThanhToanInfor tt in Business.ListChungTuThanhToan)
            {
                countPT++;
                tt.SoPhieu = "PCI-" + tt.SoPhieu;// LoadNextChungTu(soPhieuThuGoc, 11, countPT);
                tt.IdTienTe = Declare.IdTienTe;
                tt.TyGia = 1;
                tt.SoTienChu = Common.ReadNumner_(Common.Double2Str(tt.SoTienThanhToan));
                //tt.IdTrungTamThu = ctu.IdTrungTam;
                tienChi += tt.SoTienThanhToan;

                tt.TenMayTao = Declare.TenMay;
                tt.TenMaySua = Declare.TenMay;
            }

            if (ctu.TongTienThanhToan < tienChi)
            {
                Business.ListChungTuThanhToan.Clear();//khong cho phep thu
                ctu.TienThanhToanThuc = 0;
                ctu.TienConNo = ctu.TongTienThanhToan;
            }
            else
            {
                ctu.TienThanhToanThuc = tienChi;
                ctu.TienConNo = ctu.TongTienThanhToan - tienChi;
            }

            ctu.SoChungTu = "NLI-" + ctu.SoChungTuGoc;// LoadNextChungTu(soDonHangGoc, 10, countCT);
            ctu.SoPhieuXuat = String.IsNullOrEmpty(ctu.SoPhieuXuat) ? "" : "NKI-" + ctu.SoPhieuXuat;
            ctu.TenMayTao = Declare.TenMay;
            ctu.TenMaySua = Declare.TenMay;

            //import vao pos
            Business.SaveChungTu();
        }

        private delegate void SetStatusDelegate(string value);
        private SetStatusDelegate dgSetStatus;
        private void SetStatus(string value)
        {
            lblStatus.Text = value;
        }
        private string Status
        {
            set
            {
                this.Invoke(dgSetStatus, value);
            }
        }

        private delegate void SetProgressValueDelegate(int value);
        private SetProgressValueDelegate dgSetProgressMaxValue;
        private void SetProgressMaxValue(int value)
        {
            progressBar1.Maximum = value;
        }
        private int ProgressMaxValue
        {
            set
            {
                this.Invoke(dgSetProgressMaxValue, value);
            }
        }

        private SetProgressValueDelegate dgSetProgressCurValue;
        private void SetProgressCurValue(int value)
        {
            progressBar1.Value = value;
            if (type == 0)
            {
                ((BindingList<ChungTuBanHangInfor>) gListImport.DataSource).ResetBindings();
                gvListImport.FocusedRowHandle = gvListImport.RowCount - 1;

                ((BindingList<ChungTuBanHangInfor>) gImportErrors.DataSource).ResetBindings();
                gvImportErrors.FocusedRowHandle = gvImportErrors.RowCount - 1;

                grpKetQuaImport.Text =
                    String.Format("Kết quả import vào POS: {0}/{1} chứng từ đã xử lý({2} thành công - {3} thất bại)",
                                  arrCTuImport.Count + arrCTuImportErr.Count,
                                  arrSoChungTu.Count, arrCTuImport.Count, arrCTuImportErr.Count);
                if (progressBar1.Value == progressBar1.Maximum)
                {
                    if (arrCTuImportErr.Count > 0)
                    {
                        xtraTabControl2.SelectedTabPage = xtraTabPage4;
                    }
                    else
                    {
                        xtraTabControl2.SelectedTabPage = xtraTabPage3;
                    }

                    string msg =
                        String.Format(
                            "Tổng số chứng từ thực hiện: {0}\nTrong đó: \n- Số chứng từ import thành công: {1}\n- Số chứng từ import thất bại: {2}",
                            arrSoChungTu.Count, arrCTuImport.Count, arrCTuImportErr.Count);

                    MessageBox.Show(msg, "Import dữ liệu hoàn thành");
                }
            }
            else if (type == 1 && countCT > 0)
            {
                int ind = countCT - 1;
                dsPhieuThuThua.Tables["PhieuThuThua"].Rows[ind]["ghichu"] = info;
                xtraTabControl2.SelectedTabPage = xtraTabPage6;                
                gvPhieuThuThua.FocusedRowHandle = progressBar1.Value - 1;
            }
            else if (type == 2 && countCT > 0)
            {
                int ind = countCT - 1;
                dsPhieuXuatThua.Tables["PhieuXuatThua"].Rows[ind]["ghichu"] = info;
                xtraTabControl2.SelectedTabPage = xtraTabPage7;
                gvPhieuXuatThua.FocusedRowHandle = progressBar1.Value - 1;
            }
        }
        private int ProgressCurrentValue
        {
            set
            {
                this.Invoke(dgSetProgressCurValue, value);
            }
            get
            {
                return progressBar1.Value;
            }
        }

        private delegate void DisableChapNhanButtonDelegate(bool value);
        private DisableChapNhanButtonDelegate dgDisableChapNhanButton;
        private void SetChapNhanButtonEnableState(bool value)
        {
            btnImportToPOS.Enabled = value;
        }
        private bool ChapNhanEnableState
        {
            get { return btnImportToPOS.Enabled; }
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
            if (e.Column.FieldName.Equals("GhiChu"))
            {
                e.Appearance.BackColor = Color.Red;
                e.Appearance.ForeColor = Color.Yellow;
            }  
        }

        private void tsbChiTietDonHang_Click(object sender, EventArgs e)
        {
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListImport.GetRow(gvListImport.FocusedRowHandle);
            if (ct != null)
            {
                frmBH_LapDonHangBanTheTVien frm = new frmBH_LapDonHangBanTheTVien(ct);
                frm.HideMenu(true);
                frm.ShowDialog();
            }
        }

        private void gvListImport_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListImport.GetRow(e.RowHandle);
            if (ct != null)
            {
                if (e.Column.FieldName.Equals("GhiChu") && ct.GhiChu.Contains("Không thành công"))
                {
                    e.Appearance.BackColor = Color.Blue;
                    e.Appearance.ForeColor = Color.White;
                }  
            }
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            try
            {
                if (selector.selection.Count > 0)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa đơn hàng này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        frmProgress.Instance.Description = "Đang xóa chứng từ ....";
                        frmProgress.Instance.MaxValue = selector.selection.Count;
                        frmProgress.Instance.DoWork(XoaChungTu);

                        foreach (string soChungTu in arrXoa)
                        {
                            if (soChungTu != null)
                                arrCTuImport.RemoveAll(delegate(ChungTuBanHangInfor m)
                                                           {
                                                               return m.SoChungTu.Equals(soChungTu);
                                                           });
                        }
                        ((BindingList<ChungTuBanHangInfor>)gvListImport.DataSource).ResetBindings();
                        //for (int i = gvImportErrors.RowCount - 1; i >= 0; i--)
                        //{
                        //    ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvImportErrors.GetRow(i);
                        //    if (ct != null && arrXoa.Contains(ct.SoChungTu))
                        //        gvImportErrors.DeleteRow(i);
                        //}

                        if (!String.IsNullOrEmpty(err))
                            MessageBox.Show(err);
                    }
                }

            }
            catch (Exception ex)
            {                
                MessageBox.Show("Lỗi xóa chứng từ:\n" + ex.ToString());
            }
        }
        private void XoaChungTu()
        {
            err = "";
            arrXoa = new ArrayList();
            int count = 0;
            foreach (ChungTuBanHangInfor ctu in selector.selection)
            {
                frmProgress.Instance.Description = String.Format("Đang xóa chứng từ {0} ....", ctu.SoChungTu);
                try
                {
                    ImportChungTuDataProvider.Instance.DeleteChungTuById(ctu.IdChungTu);
                    count++;
                    arrXoa.Add(ctu.SoChungTu);
                    frmProgress.Instance.Description = String.Format("Đã xóa xong chứng từ [{0}] ....", ctu.SoChungTu);
                }
                catch (Exception e)
                {
                    err += String.Format("Lỗi xóa chứng từ [{0}]\n{1}\n", ctu.SoChungTu, e.ToString());
                    throw;
                }
                frmProgress.Instance.Value += 1;
            }
            frmProgress.Instance.IsCompleted = true;
            frmProgress.Instance.Description = String.Format("Đã xóa xong {0} chứng từ", count);
        }

        private void btnExportSucs_Click(object sender, EventArgs e)
        {
            Common.DevExport2Excel(gvListImport);
        }

        private void btnExportErr_Click(object sender, EventArgs e)
        {
            Common.DevExport2Excel(gvImportErrors);
        }

        private void btnPhieuXuatThua_Click(object sender, EventArgs e)
        {
            Common.DevExport2Excel(gvPhieuXuatThua);
        }

        private void btnPhieuThuThua_Click(object sender, EventArgs e)
        {
            Common.DevExport2Excel(gvPhieuThuThua);
        }

        private void LoadDuLieuThua()
        {
            try
            {
                //load chungtu
                string sql = "Select '' as ghichu,t.* from TBL_TMP_CHUNGTU_THANHTOAN_IMP t where sochungtugoc not in (select distinct sochungtugoc from tbl_tmp_chungtu_imp)";
                dsPhieuThuThua = DBTools.getData("PhieuThuThua", sql);
                gPhieuThuThua.DataSource = dsPhieuThuThua.Tables["PhieuThuThua"];
                gPhieuThuThua.Refresh();

                //load phieu thu
                sql = "Select '' as ghichu,t.* from TBL_TMP_CHUNGTU_XUATKHO_IMP t where sochungtugoc not in (select distinct sochungtugoc from tbl_tmp_chungtu_imp)";
                dsPhieuXuatThua = DBTools.getData("PhieuXuatThua", sql);
                gPhieuXuatThua.DataSource = dsPhieuXuatThua.Tables["PhieuXuatThua"];
                gPhieuXuatThua.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Debug.Print(ex.ToString());
            }            
        }
    }
}