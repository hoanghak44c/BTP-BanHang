using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using QLBanHang.Class;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QLBanHang.Modules.BanHang.Reports;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.KhoHang.Infors;
using QLBanHang.Modules.KhoHang.Providers;
using QLBH.Common;
using QLBH.Common.Providers;
using QLBH.Core.Data;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.BanHang.Bussiness;
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBC_HangChuaCoGia : DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"
        List<SanPhamKhongCoGiaBCInfor> liSanPham = new List<SanPhamKhongCoGiaBCInfor>();
        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();

#endregion

#region "Các phương thức khởi tạo"
        public frmBC_HangChuaCoGia()
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
                DMTrungTamInfor tt = DMTrungTamDataProvider.GetTrungTamByIdInfo(Declare.IdTrungTam);
                if (tt != null)
                {
                    bteTrungTam.Text = tt.TenTrungTam;
                    bteTrungTam.Tag = tt;
                }
                //btnTim_Click(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TimKiemBangGia();
        }
        private void LoadDuLieu()
        {
            int idTrungTam = bteTrungTam.Tag != null
                                 ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam
                                 : Declare.IdTrungTam;
            liSanPham = BangGiaDataProvider.Instance.GetSanPhamKhongCoGia(idTrungTam);

            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            frmProgress.Instance.IsCompleted = true;
            frmProgress.Instance.Description = "Đã xong";            
        }
        private void TimKiemBangGia()
        {
            try
            {
                frmProgress.Instance.Description = "Đang lấy dữ liệu...";
                frmProgress.Instance.MaxValue = 100;
                frmProgress.Instance.Value = 0;
                frmProgress.Instance.DoWork(LoadDuLieu);

                gListSanPham.DataSource = liSanPham;
                //gvListChungTu.Columns["ParentName"].GroupIndex = 0;
                gvListSanPham.ExpandAllGroups();
                selector.View = gvListSanPham;
                selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                selector.CheckMarkColumn.VisibleIndex = 0;

                this.grpKetQuaTimKiem.Text = "Tổng số mã hàng: " + liSanPham.Count;
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
                    if (!this.gListSanPham.Focused)
                    {
                        SendKeys.Send("{TAB}");
                        e.Handled = true;
                        return;
                    }
                }
                if (e.KeyCode == Keys.F3)
                    this.btnTim_Click(sender, e);
                else if (e.KeyCode == Keys.F5)
                    this.btnInBG_Click(sender, e);
                else if (e.KeyCode == Keys.Escape)
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

        private void btnInBG_Click(object sender, EventArgs e)
        {
            if (selector.selection.Count == 0) return;
            ArrayList liSanPham = new ArrayList();
            liSanPham.AddRange(selector.selection);
            frmBH_BangGiaBanHang_InBG frm = new frmBH_BangGiaBanHang_InBG(liSanPham);
            frm.ShowDialog();
        }

        private void TonChiTiet_Click(object sender, EventArgs e)
        {
            SanPhamKhongCoGiaBCInfor sp = (SanPhamKhongCoGiaBCInfor)gvListSanPham.GetFocusedRow();
            BangGiaBanChiTietBCInfor bgInfor = new BangGiaBanChiTietBCInfor()
                                                   {
                                                       IdSanPham = sp.IdSanPham,
                                                       MaSanPham = sp.MaSanPham,
                                                       TenSanPham = sp.TenSanPham,
                                                       MaDonViTinh = sp.MaDonViTinh,
                                                       TenDonViTinh = sp.TenSanPham
                                                   };
            if (bgInfor != null)
            {
                frmBH_BangGiaBanHang_TonCTiet frm = new frmBH_BangGiaBanHang_TonCTiet(bgInfor);
                frm.ShowDialog();
            }
        }

        private void cmdExport_Click(object sender, EventArgs e)
        {
            //Common.DevExport2Excel(gvListSanPham);
            Common.Export2ExcelFromDevGrid<SanPhamKhongCoGiaBCInfor>(gvListSanPham, "BCHangChuaCoGia");
        }
    }
}