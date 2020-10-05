using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBC_CongNoKhachHang : DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"
        private List<CongNoBanHangInfor> liChungTuBanHang = new List<CongNoBanHangInfor>();
        private List<CongNoBanHangInfor> liTimKiem = new List<CongNoBanHangInfor>();
        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
        private int SoLuongHienTai = 0;

#endregion

#region "Các phương thức khởi tạo"
        public frmBC_CongNoKhachHang()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            gListChungTu.DataSource = liChungTuBanHang;
        }
#endregion

#region "Các sự kiên"
        private void frmBH_TimChungTu_Load(object sender, EventArgs e)
        {
            try
            {
                //TimKiemChungTu();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TimKiemChungTu();
        }

        private void LoadDuLieu()
        {
            int idKhachHang = bteKhachHang.Tag != null ? ((DMDoiTuongInfo)bteKhachHang.Tag).IdDoiTuong : 0;

            if(idKhachHang == 0)
            {
                var maxValue = BaoCaoTongHopCongNoKhachHangDataProvider.Instance.GetMaxValue();
                
                frmProgress.Instance.MaxValue = maxValue / 500 + (maxValue % 500 == 0 ? 0 : 1);

                var runningValue = 0;

                while (runningValue * 500 <= maxValue)
                {
                    liChungTuBanHang.AddRange(BaoCaoTongHopCongNoKhachHangDataProvider.Instance.LoadCongNoKhachHang

                        (idKhachHang, runningValue * 500 + 1, runningValue * 500 + 500));
                
                    Invoke((MethodInvoker)delegate
                    {
                        gListChungTu.RefreshDataSource();
                        grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + liChungTuBanHang.Count + " đối tượng)";
                    });
                    
                    runningValue += 1;

                    frmProgress.Instance.Value += 1;                    
                }
            } 
            else
            {
                liChungTuBanHang.AddRange(BaoCaoTongHopCongNoKhachHangDataProvider.Instance.LoadCongNoKhachHang(idKhachHang, 0, 0));

                Invoke((MethodInvoker)delegate
                {
                    gListChungTu.RefreshDataSource();
                    grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + liChungTuBanHang.Count + " đối tượng)";
                });
            }
            frmProgress.Instance.Description = "Đã xong";
            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            frmProgress.Instance.IsCompleted = true;
        }

        private void TimKiemChungTu()
        {
            try
            {
                liChungTuBanHang.Clear();
                gListChungTu.RefreshDataSource();
                this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + liChungTuBanHang.Count + " đối tượng)";
                frmProgress.Instance.Caption = Text;
                frmProgress.Instance.Description = "Đang tổng hợp dữ liệu...";
                frmProgress.Instance.Value = 0;
                frmProgress.Instance.DoWork(LoadDuLieu);
                gvListChungTu.ExpandAllGroups();
                selector.View = gvListChungTu;
                selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                selector.CheckMarkColumn.VisibleIndex = 0;
                selector.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

#endregion

        private void frmBH_TimChungTu_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode==Keys.Enter)   
                {
                    if (!this.gListChungTu.Focused)
                    {
                        SendKeys.Send("{TAB}");
                        e.Handled = true;
                        return;
                    }
                }
                if (e.KeyCode == Keys.F3)
                    this.btnTim_Click(sender, e);
                else if (e.KeyCode == Keys.F12)
                    this.btnDong_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void bteKhachHang_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteKhachHang);
        }

        private void bteKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteKhachHang_KeyDown(sender, e, bteKhachHang, -1);
        }

        private void bteKhachHang_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteKhachHang_ButtonClick(sender, e, bteKhachHang, -1);
        }

        private void cmdExport_Click(object sender, EventArgs e)
        {
            //Common.DevExport2Excel(gvListChungTu);
            Common.Export2ExcelFromDevGrid<CongNoBanHangInfor>(gvListChungTu, "BCCongNoKhachHang");
        }
    }
}