using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using QLBanHang.Class;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.BanHang.Bussiness;
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBC_CongNoTrungTam : DevExpress.XtraEditors.XtraForm
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
        public frmBC_CongNoTrungTam()
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
                //TimKiemChungTu();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            SoLuongHienTai = 0;
            SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
            liChungTuBanHang = new List<CongNoBanHangInfor>();

            TimKiemChungTu();
        }

        private void LoadDuLieu()
        {
            int idTrungTam = bteTrungTam.Tag != null ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam : 0;
            int idKhachHang = bteKhachHang.Tag != null ? ((DMDoiTuongInfo)bteKhachHang.Tag).IdDoiTuong : 0;

            if (idTrungTam > 0 && idKhachHang > 0)
            {
                frmProgress.Instance.MaxValue = 1;

                liChungTuBanHang.AddRange(BaoCaoTongHopCongNoTrungTamDataProvider.Instance.LoadCongNoTrungTam(idTrungTam, idKhachHang, 0, 0));

                Invoke((MethodInvoker)delegate
                {
                    gListChungTu.RefreshDataSource();
                    gvListChungTu.ExpandAllGroups();
                    this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + liChungTuBanHang.Count + " trung tâm)";
                });
            } 
            else
            {
                var lstTrungTam = new List<DMTrungTamPairInfor>();

                if(bteTrungTam.Tag != null)
                
                    lstTrungTam.Add(new DMTrungTamPairInfor { IdTrungTam = ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam });
                
                else
                
                    lstTrungTam.AddRange(DMTrungTamDataProvider.GetListTrungTamPairInfo());

                if (bteKhachHang.Tag != null)
                {
                    frmProgress.Instance.MaxValue = lstTrungTam.Count;

                    foreach (var dmTrungTamPairInfor in lstTrungTam)
                    {
                        liChungTuBanHang.AddRange(BaoCaoTongHopCongNoTrungTamDataProvider.Instance.LoadCongNoTrungTam(

                            dmTrungTamPairInfor.IdTrungTam, ((DMDoiTuongInfo)bteKhachHang.Tag).IdDoiTuong, 0, 0));

                        Invoke((MethodInvoker)delegate
                        {
                            gListChungTu.RefreshDataSource();
                            gvListChungTu.ExpandAllGroups();
                            this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + liChungTuBanHang.Count + " trung tâm)";
                        });
                        frmProgress.Instance.Value += 1;
                    }
                }
                else
                {
                    var maxValue = BaoCaoTongHopCongNoTrungTamDataProvider.Instance.GetMaxValue();

                    frmProgress.Instance.MaxValue = (maxValue / 500 + (maxValue % 500 == 0 ? 0 : 1)) * lstTrungTam.Count;

                    var runningValue = 0;

                    while (runningValue * 500 <= maxValue)
                    {
                        foreach (var dmTrungTamPairInfor in lstTrungTam)
                        {
                            liChungTuBanHang.AddRange(BaoCaoTongHopCongNoTrungTamDataProvider.Instance.LoadCongNoTrungTam(

                                dmTrungTamPairInfor.IdTrungTam, 0, runningValue * 500 + 1, runningValue * 500 + 500));

                            Invoke((MethodInvoker)delegate
                            {
                                gListChungTu.RefreshDataSource();
                                gvListChungTu.ExpandAllGroups();
                                this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + liChungTuBanHang.Count + " trung tâm)";
                            });

                            frmProgress.Instance.Value += 1;
                        }
                        runningValue += 1;
                    }
                }
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
                gvListChungTu.ExpandAllGroups();
                this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + liChungTuBanHang.Count + " trung tâm)";
                frmProgress.Instance.Caption = Text;
                frmProgress.Instance.Description = "Đang tổng hợp dữ liệu ...";
                frmProgress.Instance.Value = 0;
                frmProgress.Instance.DoWork(LoadDuLieu);
                selector.View = gvListChungTu;
                selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                selector.CheckMarkColumn.VisibleIndex = 0;
                selector.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void bteTrungTam_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteTrungTam_ButtonClick(sender, e, bteTrungTam, nguoiDung.IdNhanVien);
        }

        private void bteTrungTam_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteTrungTam_KeyDown(sender, e, bteTrungTam, nguoiDung.IdNhanVien);
        }

        private void bteTrungTam_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteTrungTam);
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
            Common.Export2ExcelFromDevGrid<CongNoBanHangInfor>(gvListChungTu, "BCCongNoTrungTam");
        }
    }
}