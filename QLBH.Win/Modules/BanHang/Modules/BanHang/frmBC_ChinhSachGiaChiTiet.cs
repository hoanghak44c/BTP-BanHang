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
    public partial class frmBC_ChinhSachGiaChiTiet : DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"
        List<BangGiaBanChiTietBCInfor> liSanPham = new List<BangGiaBanChiTietBCInfor>();
        private List<BangGiaBanChiTietBCInfor> liTimKiem = new List<BangGiaBanChiTietBCInfor>();
        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
        private int SoLuongHienTai = 0;

#endregion

#region "Các phương thức khởi tạo"
        public frmBC_ChinhSachGiaChiTiet()
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
                LoadNganhHang();
                DMTrungTamInfor tt = DMTrungTamDataProvider.GetTrungTamByIdInfo(Declare.IdTrungTam);
                if (tt != null)
                {
                    bteTrungTam.Text = tt.TenTrungTam;
                    bteTrungTam.Tag = tt;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadNganhHang()
        {
            //int idNND = Common.Int2Bool(nguoiDung.SupperUser) ? -1 : nguoiDung.IdNhomNguoiDung;
            List<TimKiemItemInfor> liNganh = TimKiemItemDataProvider.Instance.GetAllItemsByType(-1, 1, -1, -1);//type=1: nganh hang
            liNganh.Insert(0, new TimKiemItemInfor()
            {
                Id = 0,
                Ma = "",
                Ten = "Tất cả"
            });
            lueNganhHang.Properties.DataSource = liNganh;
            lueNganhHang.Properties.DisplayMember = "Ten";
            lueNganhHang.Properties.ValueMember = "Ma";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            SoLuongHienTai = 0;
            SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
            liSanPham = new List<BangGiaBanChiTietBCInfor>();

            TimKiemBangGia();
        }

        private void LoadDuLieu()
        {
            int idTrungTam = bteTrungTam.Tag != null
                                 ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam
                                 : Declare.IdTrungTam;
            int soBatDau = SoLuongHienTai;
            int soKetThuc = SoLuongTimKiem != -1 ? SoLuongHienTai + SoLuongTimKiem : -1;
            int diemThuong = chkDiemThuong.Checked ? 1 : 0;
            int hieuLuc = chkHieuLuc.Checked ? 1 : 0;
            liTimKiem = BangGiaDataProvider.Instance.GetChinhSachGiaBanPg(idTrungTam, soBatDau, soKetThuc,
                                                                          txtSanPham.Text, lueNganhHang.EditValue.ToString(), diemThuong, hieuLuc);
            liSanPham.AddRange(liTimKiem);

            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            frmProgress.Instance.IsCompleted = true;
            frmProgress.Instance.Description = "Đã xong";
        }
        private void TimKiemBangGia()
        {
            try
            {
                frmProgress.Instance.Description = SoLuongTimKiem != -1
                                                       ? String.Format("Đang lấy {0} chứng từ tiếp theo...",
                                                                       SoLuongTimKiem)
                                                       : "Đang lấy toàn bộ chứng từ...";
                frmProgress.Instance.MaxValue = SoLuongTimKiem;
                frmProgress.Instance.Value = 0;
                frmProgress.Instance.DoWork(LoadDuLieu);

                gListSanPham.DataSource = new BindingList<BangGiaBanChiTietBCInfor>(liSanPham); 
                //gvListChungTu.Columns["ParentName"].GroupIndex = 0;
                gvListSanPham.ExpandAllGroups();
                selector.View = gvListSanPham;
                selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                selector.CheckMarkColumn.VisibleIndex = 0;

                ((BindingList<BangGiaBanChiTietBCInfor>)gListSanPham.DataSource).ResetBindings();
                SoLuongHienTai = liSanPham.Count;
                selector.ClearSelection();

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
 
        private void cmdExport_Click(object sender, EventArgs e)
        {
            //Common.DevExport2Excel(gvListSanPham);
            Common.Export2ExcelFromDevGrid<BangGiaBanChiTietBCInfor>(gvListSanPham, "BCChiTietChinhSachKM");
        }
    }
}