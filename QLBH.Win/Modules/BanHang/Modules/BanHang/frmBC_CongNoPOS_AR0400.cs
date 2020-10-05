using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;
using QLBH.Common.Providers;
using QLBH.Core.Exceptions;
using QLBH.Core.Form;
using QLBH.Core.Providers;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBC_CongNoPOS_AR0400 : DevExpress.XtraEditors.XtraForm
    {
        private List<DMTrungTamInfor> lstTrungTam;

        private List<DMKhoInfo> lstKho;

        private DateTime startDate, endDate, runningDate;

        private int idKho, idTrungTam, idDoiTuong, idNhanVien, totalSteps;

        private List<CongNoPosAr0400Info> lstResult;

        private int conNo;

        public frmBC_CongNoPOS_AR0400()
        {
            InitializeComponent();
        }

        private void bteKhachHang_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var frmLookUp = new frmLookUp_KhachHang(String.Format("%{0}%", bteKhachHang.Text));

            if(frmLookUp.ShowDialog() == DialogResult.OK)
            {
                bteKhachHang.Text = frmLookUp.SelectedItem.MaDoiTuong;

                bteKhachHang.Tag = frmLookUp.SelectedItem;
            }
        }

        private void bteTrungTam_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var frmLookUpTrungTam = new frmLookUp_TrungTam(true, String.Format("%{0}%", bteTrungTam.Text));

            if(frmLookUpTrungTam.ShowDialog() == DialogResult.OK)
            {
                int index = 0;

                foreach (DMTrungTamInfor dmTrungTamInfor in frmLookUpTrungTam.SelectedItems)
                {
                    bteTrungTam.Text += dmTrungTamInfor.MaTrungTam + ", ";

                    index++;

                    if (index > 3)
                    {
                        bteTrungTam.Text += "...";

                        break;
                    }
                }

                bteTrungTam.Tag = frmLookUpTrungTam.SelectedItems;
            }
        }

        private void bteThuongVien_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var frmLookUpThuongVien = new frmLookUp_NhanVien(String.Format("{0}", bteThuongVien.Text));

            if(frmLookUpThuongVien.ShowDialog()== DialogResult.OK)
            {
                bteThuongVien.Text = frmLookUpThuongVien.SelectedItem.MaNhanVien;

                bteThuongVien.Tag = frmLookUpThuongVien.SelectedItem;
            }
        }

        private void bteKho_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var frmLookUpKho = new frmLookUp_Kho(true, String.Format("%{0}%", bteKho.Text));

            if (frmLookUpKho.ShowDialog() == DialogResult.OK)
            {
                int index = 0;

                foreach (DMKhoInfo dmKhoInfo in frmLookUpKho.SelectedItems)
                {
                    bteKho.Text += dmKhoInfo.MaKho + ", ";

                    index++;

                    if (index > 3)
                    {
                        bteKho.Text += "...";
                        
                        break;
                    }
                }

                bteKho.Tag = frmLookUpKho.SelectedItems;
            }
        }

        private void bteKhachHang_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(bteKhachHang.Text))
            {
                bteKhachHang.Tag = null;
            }
        }

        private void bteTrungTam_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(bteTrungTam.Text))
            {
                bteTrungTam.Tag = null;
            }
        }

        private void bteThuongVien_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(bteThuongVien.Text))
            {
                bteThuongVien.Tag = null;
            }
        }

        private void bteKho_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(bteKho.Text))
            {
                bteKho.Tag = null;
            }
        }

        private void LoadData()
        {
            try
            {
                lstResult.AddRange(CongNoPosAr0400Provider.Instance.GetReport(
                    idDoiTuong,
                    idNhanVien,
                    idKho,
                    idTrungTam,
                    runningDate, conNo));

                gListChungTu.RefreshDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

                throw;
            }
        }

        private void LoadDuLieu()
        {
            try
            {
                frmProgress.Instance.Caption = "Tổng hợp công nợ";

                frmProgress.Instance.MaxValue = totalSteps;

                frmProgress.Instance.MinValue = 0;

                frmProgress.Instance.Value = 0;

                runningDate = endDate;

                frmProgress.Instance.Description = "Đang tổng hợp số liệu ...";

                //const string strFormat = "Đang tổng hợp số liệu ngày {0}, {1}";

                while (runningDate >= startDate)
                {
                    if (lstKho == null || lstKho.Count == 0)
                    {
                        foreach (DMTrungTamInfor dmTrungTamInfor in lstTrungTam)
                        {
                            //frmProgress.Instance.Description = String.Format(strFormat, runningDate.ToString("dd/MM/yyyy"), dmTrungTamInfor.MaTrungTam);

                            idKho = 0;

                            idTrungTam = dmTrungTamInfor.IdTrungTam;

                            LoadData();

                            frmProgress.Instance.Value += 1;

                            Thread.CurrentThread.Join(500);
                        }
                    }
                    else
                    {
                        foreach (DMKhoInfo dmKhoInfo in lstKho)
                        {
                            //frmProgress.Instance.Description = String.Format(strFormat, runningDate.ToString("dd/MM/yyyy"), dmKhoInfo.MaKho);

                            idKho = dmKhoInfo.IdKho;

                            idTrungTam = dmKhoInfo.IdTrungTam;

                            LoadData();

                            frmProgress.Instance.Value += 1;
 
                            Thread.CurrentThread.Join(500);
                        }
                    }

                    runningDate = runningDate.AddDays(-1);
                }
                frmProgress.Instance.Description = "Đã tổng hợp xong!";
                frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
                frmProgress.Instance.IsCompleted = true;
            }
            catch (Exception ex)
            {
                frmProgress.Instance.Description = "Tổng hợp lỗi!";
                frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
                frmProgress.Instance.IsCompleted = true;
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                lstResult.Clear();

                gListChungTu.RefreshDataSource();
                
                lstTrungTam = (List<DMTrungTamInfor>)bteTrungTam.Tag;

                if (lstTrungTam == null || lstTrungTam.Count == 0) throw new ManagedException("Bạn chưa chọn trung tâm");

                lstKho = (List<DMKhoInfo>)bteKho.Tag;

                idDoiTuong = bteKhachHang.Tag == null ? 0 : ((DMDoiTuongInfo) bteKhachHang.Tag).IdDoiTuong;

                idNhanVien = bteThuongVien.Tag == null ? 0 : ((DMNhanVienInfo) bteThuongVien.Tag).IdNhanVien;

                startDate = dteStart.DateTime;

                endDate = dteEnd.DateTime;

                conNo = chkConNo.Checked ? 1 : 0;

                var totalDays = (int)(dteEnd.DateTime - dteStart.DateTime).TotalDays;

                totalSteps = totalDays * (lstKho == null || lstKho.Count == 0 ? lstTrungTam.Count : lstKho.Count);

                frmProgress.Instance.DoWork(LoadDuLieu);
            }
            catch (ManagedException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                EventLogProvider.Instance.WriteOfflineLog(ex.ToString(), "AR0400");

            }
        }

        private void frmBC_CongNoPOS_AR0400_Load(object sender, EventArgs e)
        {
            dteEnd.EditValue = CommonProvider.Instance.GetSysDate();

            dteStart.EditValue = dteEnd.EditValue;

            lstResult = new List<CongNoPosAr0400Info>();

            gListChungTu.DataSource = lstResult;

            chkConNo.Checked = true;

            if (((NguoiDungInfor)Declare.USER_INFOR).SupperUser != 1 &&
                ((NguoiDungInfor)Declare.USER_INFOR).IdNhomNguoiDung != 547 &&
                ((NguoiDungInfor)Declare.USER_INFOR).IdNhomNguoiDung != 797)
            {
                lstTrungTam = new List<DMTrungTamInfor>
                                  {
                                      DMTrungTamDataProvider.GetTrungTamByIdInfo(
                                          ((NguoiDungInfor) Declare.USER_INFOR).IdTrungTamHachToan)
                                  };

                bteTrungTam.Text = lstTrungTam[0].MaTrungTam;

                bteTrungTam.Tag = lstTrungTam;

                bteTrungTam.Enabled = false;

                bteKho.Enabled = false;
            }
        }

        private void cmdExport_Click(object sender, EventArgs e)
        {
            Common.Export2ExcelFromDevGridTest<CongNoPosAr0400Info>(gvListChungTu, "Công nợ POS - AR0400");
        }
    }
}