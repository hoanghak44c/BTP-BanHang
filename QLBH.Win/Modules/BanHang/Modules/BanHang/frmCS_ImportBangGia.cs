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

namespace QLBanHang.Modules.BanHang
{
    public partial class frmCS_ImportBangGia : DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"
        private LoaiGiaoDichBanHang LoaiGiaoDich;
        private List<ChungTuBanHangChiTietBCInfor> liChungTuChiTiet = new List<ChungTuBanHangChiTietBCInfor>();
        public TimKiemChungTuChiTietFilterInfor filter = new TimKiemChungTuChiTietFilterInfor();
        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private List<string> arrLoi = new List<string>();        
        private List<int> ListIdTTamSelected = new List<int>();
        private List<string> ListTenTTamSelected = new List<string>();        

        DataSet dsChungTu;
        Thread syncThread;
        private int count = 0;
        private int countOK = 0;
        private int countLoi = 0;
        private string err = "";
        private ArrayList arrXoa = new ArrayList();

#endregion

#region "Các phương thức khởi tạo"
        public frmCS_ImportBangGia()
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
                Cursor.Current = Cursors.WaitCursor;
                string sql = String.Empty;
                openFileDialog1.FileName = String.Empty;

                //openFileDialog1.Filter = "*.xls|*.xlsx";
                if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

                using (OleDbConnection oConn = new OleDbConnection())
                {
                    dsChungTu = new DataSet();
                    oConn.ConnectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=Yes\"", openFileDialog1.FileName);
                    oConn.Open();
                    //load chungtu
                    sql = "Select [MaSanPham],[DonGiaCoVAT],[GiaNiemYet],[GiaWebSite] from [BangGia$] where [MaSanPham] is not null";
                    using (OleDbDataAdapter ad = new OleDbDataAdapter(sql, oConn))
                    {
                        ad.Fill(dsChungTu, "ChungTu");
                        gListChungTu.DataSource = dsChungTu.Tables["ChungTu"];
                        gListChungTu.Refresh();
                    }
                }
                Cursor.Current = Cursors.Default;
                frmProgress.Instance.Description = "Đang nạp dữ liệu bảng giá ....";
                frmProgress.Instance.MaxValue = dsChungTu.Tables["ChungTu"].Rows.Count;
                frmProgress.Instance.DoWork(ImportChungTuFromExcel);

                grpKetQuaTimKiem.Text = String.Format("Dữ liệu bảng giá import: Tổng số {0} mã hàng", dsChungTu.Tables["ChungTu"].Rows.Count);
                btnImportToPOS.Enabled = gvListChungTu.RowCount > 0 ? true : false;
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
                ConnectionUtil.Instance.BeginTransaction();
                SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(), CommandType.Text, "delete from TBL_TMP_BANGGIA_BANHANG_IMP");
                count = dsChungTu.Tables["ChungTu"] != null ? dsChungTu.Tables["ChungTu"].Rows.Count : 0;
                foreach (DataRow ct in dsChungTu.Tables["ChungTu"].Rows)
                {
                    frmProgress.Instance.Value += 1;
                    if (String.IsNullOrEmpty(ct["MaSanPham"].ToString())) continue;
                    sql = "insert into TBL_TMP_BANGGIA_BANHANG_IMP values('" + ct["MaSanPham"] + "'," + ct["DonGiaCoVAT"] + "," + ct["GiaNiemYet"] + "," + ct["GiaWebSite"] + ")";
                    SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(), CommandType.Text, sql);                    
                }
                ConnectionUtil.Instance.CommitTransaction();
                frmProgress.Instance.IsCompleted = true;
                frmProgress.Instance.Description = "Đã import xong bảng giá";  
            }
            catch (Exception ex)
            {
                ConnectionUtil.Instance.RollbackTransaction();
                frmProgress.Instance.IsCompleted = true;
                Debug.Print(ex.ToString());
                Debug.Print(sql);
            }            
        }

        private void btnImportCSDL_Click(object sender, EventArgs e)
        {
            try
            {
                //load chungtu
                string sql = "Select * from TBL_TMP_BANGGIA_BANHANG_IMP";
                dsChungTu = DBTools.getData("ChungTu", sql);
                gListChungTu.DataSource = dsChungTu.Tables["ChungTu"];
                gListChungTu.Refresh();
                count = dsChungTu.Tables["ChungTu"] != null ? dsChungTu.Tables["ChungTu"].Rows.Count : 0;

                grpKetQuaTimKiem.Text = String.Format("Dữ liệu bảng giá import: Tổng số {0} mã hàng", dsChungTu.Tables["ChungTu"].Rows.Count);
                btnImportToPOS.Enabled = gvListChungTu.RowCount > 0 ? true : false;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
            }
        }

        private void btnImportToPOS_Click(object sender, EventArgs e)
        {
            if (dsChungTu.Tables["ChungTu"] == null || dsChungTu.Tables["ChungTu"].Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu import. Chọn file Excel hoặc nạp dữ liệu gốc từ CSDL");
                return;
            }

            frmCS_ChonTrungTam frm = new frmCS_ChonTrungTam(true);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ListIdTTamSelected = frm.ListIdTTamSelected;
                ListTenTTamSelected = frm.ListTenTTamSelected;

                try
                {
                    progressBar1.Value = 0;
                    lblStatus.Text = "Đang import dữ liệu ...";
                    arrLoi = new List<string>();
                    count = 0;
                    countOK = 0;
                    countLoi = 0;
                    gImportErrors.DataSource = new BindingList<string>(arrLoi);
                    gvImportErrors.Columns[0].VisibleIndex = 0;
                    gvImportErrors.Columns[0].Width = 400;
                    syncThread = new Thread(ImportDuLieuToPos);
                    syncThread.Start();
                }
                catch (Exception ex)
                {
                    frmProgress.Instance.IsCompleted = true;
                    Debug.Print(ex.ToString());
                }
            }
        }
        private void ImportDuLieuToPos()
        {
            try
            {
                ChapNhanEnableState = false;
                Status = "Import dữ liệu bảng giá vào POS ....";

                ProgressMaxValue = dsChungTu.Tables["ChungTu"].Rows.Count;
                ProgressCurrentValue = 0;

                foreach (DataRow ct in dsChungTu.Tables["ChungTu"].Rows)
                {
                    string maSanPham = ct["MaSanPham"].ToString();
                    if (String.IsNullOrEmpty(maSanPham)) continue;

                    Status = String.Format("Đang import sản phẩm [{0}]...", maSanPham);

                    string sql =
                        String.Format(
                            "select idtaxcode from tbl_dm_taxcode where idtaxcode in (select tylevat from tbl_sanpham where masanpham = '{0}')",
                            maSanPham);
                    
                    string vat = DBTools.getValue(sql);
                    if (String.IsNullOrEmpty(vat))//sai vat
                    {
                        arrLoi.Add(String.Format("Mã {0} sai tỷ lệ VAT", maSanPham));
                        countLoi++;
                    }                        
                    else
                    {
                        bool err = false;
                        foreach (int idTrungTam in ListIdTTamSelected)
                        {
                            try
                            {
                                ImportChungTuDataProvider.Instance.ImportBangGiaChiTiet(idTrungTam, maSanPham);
                            }
                            catch (Exception ex)
                            {
                                arrLoi.Add(String.Format("Lỗi import Mã {0}: {1}", maSanPham, ex.ToString()));
                                countLoi++;
                                err = true;
                                break;
                            }                            
                        }
                        if (!err)
                            countOK++;
                    }
                    SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(), CommandType.Text, sql);
                    ProgressCurrentValue += 1;
                }
                Status = "Import bảng giá vào POS đã hoàn thành";
                ChapNhanEnableState = true;
            }
            catch (Exception ex)
            {
                ChapNhanEnableState = true;
                //CloseFormWithThread();
                Debug.Print(ex.ToString());
            }                       
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
            ((BindingList<string>)gImportErrors.DataSource).ResetBindings();
            gvImportErrors.FocusedRowHandle = gvImportErrors.RowCount - 1;

            grpKetQuaImport.Text = String.Format("Kết quả import vào POS: {0}/{1} mã hàng từ đã xử lý({2} thành công - {3} thất bại)", countOK + countLoi,
                                                  dsChungTu.Tables["ChungTu"].Rows.Count, countOK, countLoi);
            if (progressBar1.Value == progressBar1.Maximum)
            {
                string msg =
                    String.Format(
                        "Tổng số mã hàng thực hiện: {0}\nTrong đó: \n- Số mã hàng import thành công: {1}\n- Số mã hàng import thất bại: {2}",
                        dsChungTu.Tables["ChungTu"].Rows.Count, countOK, countLoi);
                
                MessageBox.Show(msg,"Import dữ liệu hoàn thành");
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
        }

        private void btnExportErr_Click(object sender, EventArgs e)
        {
            Common.DevExport2Excel(gvImportErrors);
        }
    }
}