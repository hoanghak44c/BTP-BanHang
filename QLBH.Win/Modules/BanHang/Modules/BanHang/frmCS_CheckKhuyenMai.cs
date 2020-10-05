using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
using QLBH.Core;
using QLBH.Core.Data;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.BanHang.Bussiness;
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmCS_CheckKhuyenMai : DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"
        List<BangGiaChinhSachInfor> liResult = new List<BangGiaChinhSachInfor>();
        public BangGiaChinhSachInfor ChinhSach = null;
        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
#endregion

#region "Các phương thức khởi tạo"
        public frmCS_CheckKhuyenMai()
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
                LoadAllTrangThai();
                mstThoiGian.Value = DateTime.Now;
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

        private void LoadAllTrangThai()
        {
            List<TrangThaiBH> liLoaiChinhSach = Common.GetLoaiChinhSachGia();
            repLoaiCS.DataSource = liLoaiChinhSach;

            List<TrangThaiBH> liLoaiKhachHang = Common.GetListLoaiKhachHang();
            repDoiTuongAD.DataSource = liLoaiKhachHang;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(bteSanPham.Text))
            {
                MessageBox.Show("Phải nhập vào mã sản phẩm cần kiểm tra");
                bteSanPham.Focus();
                return;
            }

            TimKiemBangGia();
        }
        private void LoadDuLieu()
        {
            string maSanPham = bteSanPham.Text;
            int idTrungTam = bteTrungTam.Tag != null
                                 ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam
                                 : Declare.IdTrungTam;
            DateTime thoiGian = mstThoiGian.Value;

            liResult = ChinhSachDataProvider.Instance.GetAllChinhSachDaApDung(idTrungTam, maSanPham, thoiGian);

            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            frmProgress.Instance.IsCompleted = true;
            frmProgress.Instance.Description = "Đã xong";            
        }
        private void TimKiemBangGia()
        {
            try
            {
                frmProgress.Instance.Description = "Đang nạp dữ liệu";
                frmProgress.Instance.MaxValue = 1;
                frmProgress.Instance.Value = 0;
                frmProgress.Instance.DoWork(LoadDuLieu);

                gChinhSach.DataSource = new BindingList<BangGiaChinhSachInfor>(liResult); 
                //gvListChungTu.Columns["ParentName"].GroupIndex = 0;
                //gvChinhSach.ExpandAllGroups();
                //selector.View = gvChinhSach;
                //selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                //selector.CheckMarkColumn.VisibleIndex = 0;
                //((BindingList<BangGiaChinhSachInfor>)gChinhSach.DataSource).ResetBindings();
                //selector.ClearSelection();
                UpdateTienKM();

                this.grpKetQuaTimKiem.Text = "Tổng số chính sách: " + liResult.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTienKM()
        {
            double tienKM = 0;
            if (liResult != null && liResult.Count > 0)
            {
                string maSanPham = bteSanPham.Text;
                int idTrungTam = bteTrungTam.Tag != null
                                     ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam
                                     : Declare.IdTrungTam;
                DateTime thoiGian = mstThoiGian.Value;

                BangGiaBanChiTietInfor bgia = BangGiaDataProvider.Instance.GetGiaBanTheoThoiGian(idTrungTam, thoiGian, maSanPham);
                int idSanPham = bgia != null ? bgia.IdSanPham : 0;
                double giaCoVAT = bgia != null ? bgia.DonGiaCoVAT : 0;
                double tyleVAT = bgia != null ? bgia.TyLeVAT : 0;

                txtSanPham.Visible = true;
                txtSanPham.Text = String.Format("Sản phẩm: {0}", bgia.TenSanPham);
                txtDonGia.Visible = true;
                txtDonGia.Text = String.Format("Đơn giá có VAT: {0} -  VAT: {1}", Common.Double2Str(giaCoVAT), tyleVAT);                

                foreach (BangGiaChinhSachInfor chinhSach in liResult)
                {
                    string idSanPhamKADs = String.Format(",{0},", chinhSach.MatHangKhongApDung);
                    if (idSanPhamKADs.Contains(String.Format(",{0},", idSanPham)))
                    {
                        continue;
                    }

                    double km = 0;
                    List<BangGiaADDKMuaInfor> liDKMua = KhuyenMaiDataProvider.Instance.GetBangGiaADDKMuaInforsById(chinhSach.IdDKMua);
                    foreach (BangGiaADDKMuaInfor dkm in liDKMua)
                    {
                        if (dkm.TyLeChietKhau != 0 || dkm.TienChietKhau != 0)
                        {
                            km = Common.MaxValues(km, dkm.TienChietKhau, dkm.TyLeChietKhau * giaCoVAT / 100);
                        }
                    }
                    List<BangGiaADKhuyenMaiInfor> lstKM = KhuyenMaiDataProvider.Instance.GetAllBangGiaKhuyenMaiADInfors(chinhSach.IdDKMua);
                    for (int i = 0; i < lstKM.Count; i++)
                    {
                        double km2 = km;
                        lstKM[i].ListKhuyenMaiChiTiet = KhuyenMaiDataProvider.Instance.GetAllKhuyenMaiChiTietADTTInfors(lstKM[i].IdKhuyenMai, 0, giaCoVAT);
                        foreach (BangGiaADKhuyenMaiChiTietInfor kmct in lstKM[i].ListKhuyenMaiChiTiet)
                        {
                            km2 += Common.MaxValues(kmct.SoTienKM, kmct.TyLeKM * giaCoVAT / 100, kmct.GiaVon * kmct.SoLuong);
                        }
                        if (tienKM < km2)
                        {
                            tienKM = km2;
                        }
                    }
                }

                tienKM = Math.Round(tienKM / (1 + tyleVAT / 100), 5);//tien KM chua co vat
            }
            else
            {
                txtSanPham.Visible = false;
                txtDonGia.Visible = false;
            }

            txtSoTienKM.Text = Common.Double2Str(tienKM);
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
                    if (!this.gChinhSach.Focused)
                    {
                        SendKeys.Send("{TAB}");
                        e.Handled = true;
                        return;
                    }
                }
                if (e.KeyCode == Keys.F3)
                    this.btnTim_Click(sender, e);
                else if (e.KeyCode == Keys.F5)
                    this.cmdExport_Click(sender, e);
                else if (e.KeyCode == Keys.F6)
                    this.btnDong_Click(sender, e);
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

        private void ChinhSachApDung_Click(object sender, EventArgs e)
        {
            btnDongBo_Click(sender, e);
        }

        private void cmdExport_Click(object sender, EventArgs e)
        {
            //Common.DevExport2Excel(gvListSanPham, "BangGiaHienTai");
            Common.Export2ExcelFromDevGrid<BangGiaBanChiTietBCInfor>(gvChinhSach, "ChinhSachApDung");
        }


        private void btnDongBo_Click(object sender, EventArgs e)
        {
            frmCS_List_ChinhSachKM_View frm = new frmCS_List_ChinhSachKM_View(ChinhSach, liResult, true);
            //frm.HideMenu();
            frm.Show();
        }


        private void bteSanPham_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                UtilFunctions.bteSanPham_ButtonClick(sender, e, bteSanPham);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bteSanPham_TextChanged(object sender, EventArgs e)
        {
            try
            {
                UtilFunctions.bteItem_TextChanged(sender, e, bteSanPham);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bteSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                UtilFunctions.bteSanPham_KeyDown(sender, e, bteSanPham);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}