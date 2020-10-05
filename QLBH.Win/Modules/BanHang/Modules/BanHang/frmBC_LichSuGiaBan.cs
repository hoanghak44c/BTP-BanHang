using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;
using QLBH.Core.Form;
using QLBH.Core.Providers;
using QLBH.Core.Exceptions;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBC_LichSuGiaBan : DevExpress.XtraEditors.XtraForm
    {
        private List<LichSuGiaBanInfor> lstSource;

        public frmBC_LichSuGiaBan()
        {
            InitializeComponent();

            dteEnd.Enabled = false;

            dteStart.Enabled = false;

            lstSource = new List<LichSuGiaBanInfor>();

            gListLichSuGia.DataSource = lstSource;

            gListLichSuGia.ContextMenu = new ContextMenu(
                new[]
                    {
                        new MenuItem("Kiểm tra chiết khấu bán hiện tại", kiemTraGiaVaChietKhauBan),
                    });
        }

        private void bteTrungTam_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var frmLookUpTrungTam = new frmLookUp_TrungTam(true, String.Format("%{0}%", bteTrungTam.Text),
                                                                          Declare.IdNhanVien);
            if(frmLookUpTrungTam.ShowDialog() == DialogResult.OK)
            {
                int maxDisplay = 3;

                bteTrungTam.Text = ",";

                if (frmLookUpTrungTam.SelectedItems.Count < maxDisplay)
                {
                    foreach (DMTrungTamInfor dmTrungTamInfor in frmLookUpTrungTam.SelectedItems)
                    {
                        bteTrungTam.Text += dmTrungTamInfor.MaTrungTam + ",";
                    }
                } 
                else
                {
                    foreach (DMTrungTamInfor dmTrungTamInfor in frmLookUpTrungTam.SelectedItems)
                    {
                        if (maxDisplay < 0) break;

                        bteTrungTam.Text += dmTrungTamInfor.MaTrungTam + ",";

                        maxDisplay -= 1;
                    }

                    bteTrungTam.Text += "...";                    
                }

                bteTrungTam.Tag = frmLookUpTrungTam.SelectedItems;
            }
        }

        private void bteSanPham_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmLookUp_SanPham frmLookUpSanPham = new frmLookUp_SanPham(true, String.Format("%{0}%", bteSanPham.Text));

            if(frmLookUpSanPham.ShowDialog() == DialogResult.OK)
            {
                int maxDisplay = 3;

                bteSanPham.Text = ",";

                if (frmLookUpSanPham.SelectedItems.Count < maxDisplay)
                {
                    foreach (DMSanPhamInfo dmSanPhamInfo in frmLookUpSanPham.SelectedItems)
                    {
                        bteSanPham.Text += dmSanPhamInfo.MaSanPham + ",";
                    }                    
                } 
                else
                {
                    foreach (DMSanPhamInfo dmSanPhamInfo in frmLookUpSanPham.SelectedItems)
                    {
                        if(maxDisplay < 0) break;

                        bteSanPham.Text += dmSanPhamInfo.MaSanPham + ",";

                        maxDisplay -= 1;
                    }

                    bteSanPham.Text += "...";
                }

                bteSanPham.Tag = frmLookUpSanPham.SelectedItems;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                frmProgress.Instance.Caption = "Lịch sử đồng bộ giá bán";

                frmProgress.Instance.Description = "Đang tổng hợp dữ liệu";

                var lstTrungTam = (List<DMTrungTamInfor>)bteTrungTam.Tag;

                var lstSanPham = (List<DMSanPhamInfo>)bteSanPham.Tag;

                var isCoThayDoi = chkCoThayDoiGia.Checked;

                var isKhongThayDoi = chkKhongThayDoi.Checked;

                if (!isCoThayDoi && !isKhongThayDoi)
                {
                    if (bteTrungTam.Tag == null || bteSanPham.Tag == null)
                    {
                        throw new ManagedException("Bạn chưa chọn điều kiện xem lịch sử.");                        
                    }

                    frmProgress.Instance.MaxValue = lstTrungTam.Count * lstSanPham.Count;
                } 
                else
                {
                    frmProgress.Instance.MaxValue = 100;
                }

                lstSource.Clear();

                gListLichSuGia.RefreshDataSource();

                frmProgress.Instance.Value = 0;

                frmProgress.Instance.DoWork(
                    delegate
                    {
                        if (!isCoThayDoi && !isKhongThayDoi)
                        {
                            foreach (DMTrungTamInfor dmTrungTamInfor in lstTrungTam)
                            {
                                foreach (DMSanPhamInfo dmSanPhamInfo in lstSanPham)
                                {
                                    lstSource.AddRange(LichSuGiaBanProvider.Instance.GetLichSuGia(dmTrungTamInfor.MaTrungTam, dmSanPhamInfo.MaSanPham));

                                    Invoke((MethodInvoker)
                                        delegate
                                        {
                                            gListLichSuGia.RefreshDataSource();
                                        });

                                    frmProgress.Instance.Value += 1;
                                }
                            }
                        } 
                        else if(isCoThayDoi)
                        {
                            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;

                            lstSource.AddRange(LichSuGiaBanProvider.Instance.GetLichSuThayDoiGia());

                            Invoke((MethodInvoker)
                                   delegate
                                       {
                                           gListLichSuGia.RefreshDataSource();
                                       });
                        }
                        else if (isKhongThayDoi)
                        {
                            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
                            
                            if(MessageBox.Show("Sẽ mất nhiều thời gian để thực hiện, bạn có đồng ý không?", "Xác nhận",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            {
                                lstSource.AddRange(LichSuGiaBanProvider.Instance.GetLichSuThayDoiGia());                                
                            }

                            Invoke((MethodInvoker)
                                   delegate
                                   {
                                       gListLichSuGia.RefreshDataSource();
                                   });
                        }
                        
                        Invoke((MethodInvoker)
                               delegate
                               {
                                   gvListLichSuGia.BestFitColumns();
                               });

                        frmProgress.Instance.Description = "Đã xong";

                        frmProgress.Instance.Value = frmProgress.Instance.MaxValue;

                        frmProgress.Instance.IsCompleted = true;
                    });
            }
            catch (ManagedException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);

                EventLogProvider.Instance.WriteOfflineLog(ex.ToString(), "Lich su gia ban");
#endif
            }
        }

        private void cmdExport_Click(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkCoThayDoiGia_CheckedChanged(object sender, EventArgs e)
        {
            if(chkCoThayDoiGia.Checked)
            {
                chkKhongThayDoi.Checked = false;
                chkKhongThayDoi.Enabled = false;
                bteTrungTam.Text = String.Empty;
                bteTrungTam.Tag = null;
                bteTrungTam.Enabled = false;
                bteSanPham.Text = String.Empty;
                bteSanPham.Tag = null;
                bteSanPham.Enabled = false;
            } 
            else
            {
                bteTrungTam.Enabled = true;
                bteSanPham.Enabled = true;
                chkKhongThayDoi.Enabled = true;
            }
        }

        private void chkKhongThayDoi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKhongThayDoi.Checked)
            {
                chkCoThayDoiGia.Checked = false;
                chkCoThayDoiGia.Enabled = false;
                bteTrungTam.Text = String.Empty;
                bteTrungTam.Tag = null;
                bteTrungTam.Enabled = false;
                bteSanPham.Text = String.Empty;
                bteSanPham.Tag = null;
                bteSanPham.Enabled = false;
            }
            else
            {
                bteTrungTam.Enabled = true;
                bteSanPham.Enabled = true;
                chkCoThayDoiGia.Enabled = true;
            }
        }

        private void kiemTraGiaVaChietKhauBan(object sender, EventArgs e)
        {
            var info = (LichSuGiaBanInfor) gvListLichSuGia.GetFocusedRow();
            
            BangGiaBanChiTietBCInfor sp = BangGiaDataProvider.Instance.GetSanPham(info.MaSanPham, info.MaTrungTam);

            int idDKMua = 0;

            double tienKhuyenMai = CommonFuns.Instance.GetTienKhuyenMai(sp.IdTrungTam, sp.IdSanPham,
                                        sp.MaSanPham, sp.DonGiaCoVAT,
                                        sp.DonGiaCoVAT, sp.TyLeVAT, ref idDKMua);

            MessageBox.Show(String.Format("Trung tâm {0} \n Mã sản phẩm {1} \n Khuyến mại {2}", 
                info.MaTrungTam, sp.MaSanPham, tienKhuyenMai));

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            BangGiaBanChiTietBCInfor sp = BangGiaDataProvider.Instance.
                GetSanPham(((DMSanPhamInfo)bteSanPham.Tag).MaSanPham, ((DMTrungTamInfor)bteTrungTam.Tag).MaTrungTam);

            int idDKMua = 0;

            double tienKhuyenMai = CommonFuns.Instance.GetTienKhuyenMai(sp.IdTrungTam, sp.IdSanPham,
                                        sp.MaSanPham, sp.DonGiaCoVAT,
                                        sp.DonGiaCoVAT, sp.TyLeVAT, ref idDKMua);

            MessageBox.Show(String.Format("Trung tâm {0} \n Mã sản phẩm {1} \n Khuyến mại {2}",
                ((DMTrungTamInfor)bteTrungTam.Tag).MaTrungTam, sp.MaSanPham, tienKhuyenMai));

        }
    }
}