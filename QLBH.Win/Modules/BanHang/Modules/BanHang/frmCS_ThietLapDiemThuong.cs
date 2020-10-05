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
using QLBanHang.Modules.DanhMuc.Base;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.KhoHang.DAO;
using QLBH.Common;
using QLBH.Common.Providers;
using QLBH.Core.Data;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.BanHang.Bussiness;
using QLBH.Core.Form;
using QLBH.Core.Providers;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmCS_ThietLapDiemThuong : DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"

        private List<BangGiaDiemThuongInfor> liDuLieu = new List<BangGiaDiemThuongInfor>();
        private List<BangGiaDiemThuongInfor> liTimKiem = new List<BangGiaDiemThuongInfor>();
        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
        private int SoLuongHienTai = 0;

#endregion

#region "Các phương thức khởi tạo"
        public frmCS_ThietLapDiemThuong()
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
                LoadAllDuLieu();
                cboLoaiMaHang.SelectedIndex = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadAllDuLieu()
        {
            try
            {
                liDuLieu = BangGiaDiemThuongDataProvider.Instance.LoadAllKhoangDiemThuong();

                gListData.DataSource = new BindingList<BangGiaDiemThuongInfor>(liDuLieu);
                //gvListChungTu.Columns["ParentName"].GroupIndex = 0;
                gvListData.ExpandAllGroups();
                selector.View = gvListData;
                selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                selector.CheckMarkColumn.VisibleIndex = 0;
                ((BindingList<BangGiaDiemThuongInfor>)gListData.DataSource).ResetBindings();
                selector.ClearSelection();

                this.grpKetQuaTimKiem.Text = String.Format("Tổng số bản ghi: {0}", liDuLieu.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                SoLuongHienTai = 0;
                SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
                liTimKiem = new List<BangGiaDiemThuongInfor>();

                TimKiemChungTu();
            }
            catch (Exception ex)
            {
                EventLogProvider.Instance.WriteOfflineLog(ex.ToString(), "Thiết lập điểm thưởng.");
#if (DEBUG)
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
        }

        private void GetFilter()
        {

        }

        private void LoadDuLieu()
        {
            //filter.SoBatDau = SoLuongHienTai;
            //filter.SoKetThuc = SoLuongTimKiem != -1 ? SoLuongHienTai + SoLuongTimKiem : -1;
            //liTimKiem = BanHangDataProvider.Instance.TimKiemDoanhSoTongHopPg(filter);
            //liChungTuThanhToan.AddRange(liTimKiem);

            //frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            //frmProgress.Instance.IsCompleted = true;
            //frmProgress.Instance.Description = "Đã xong";
        }

        private void TimKiemChungTu()
        {
            try
            {
                //GetFilter();
                //frmProgress.Instance.Description = "Đang nạp dữ liệu ...";
                //frmProgress.Instance.MaxValue = SoLuongTimKiem;
                //frmProgress.Instance.Value = 0;
                //frmProgress.Instance.DoWork(LoadDuLieu);

                //gListData.DataSource = new BindingList<ChungTuThanhToanBCInfor>(liChungTuThanhToan);
                ////gvListChungTu.Columns["ParentName"].GroupIndex = 0;
                //gvListData.ExpandAllGroups();
                //selector.View = gvListData;
                //selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                //selector.CheckMarkColumn.VisibleIndex = 0;
                //((BindingList<ChungTuThanhToanBCInfor>)gListData.DataSource).ResetBindings();
                //SoLuongHienTai = liChungTuThanhToan.Count;
                //selector.ClearSelection();

                //this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + liChungTuThanhToan.Count + " phiếu)";
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
                    if (!this.gListData.Focused)
                    {
                        SendKeys.Send("{TAB}");
                        e.Handled = true;
                        return;
                    }
                }
                if (e.KeyCode == Keys.F3)
                    this.btnTim_Click(sender, e);
                else if (e.KeyCode == Keys.F6)
                    this.btnUpdate_Click(sender, e);
                else if (e.KeyCode == Keys.F12)
                    this.btnClose_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }


        private void gvListChungTu_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
        }


        private void btnClose_Click(object sender, EventArgs e)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                frmProgress.Instance.Description = "Đang cập nhật dữ liệu ...";
                frmProgress.Instance.MaxValue = liDuLieu.Count;
                frmProgress.Instance.Value = 0;
                frmProgress.Instance.DoWork(UpdateDuLieu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
        private void UpdateDuLieu()
        {
            for (int i = 0; i < liDuLieu.Count; i++)
            {
                frmProgress.Instance.Description = String.Format("Lĩnh vực [{0}] - Ngành hàng [{1}] - Loại[{2}] ...",
                                                                 liDuLieu[i].TenLinhVuc, liDuLieu[i].TenNganhHang,
                                                                 liDuLieu[i].TenLoai);
                BangGiaDiemThuongDataProvider.Instance.Update(liDuLieu[i]);
                frmProgress.Instance.Value += 1;
            }

            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            frmProgress.Instance.IsCompleted = true;
            frmProgress.Instance.Description = "Đã xong";            
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            if (bteNganh.Tag == null)
            {
                MessageBox.Show("Phải nhập vào mã hàng!");
                bteNganh.Focus();
            }
            else
            {
                //if (cboLoaiMaHang.SelectedIndex == 0)//linh vuc
                //{
                //    foreach (BangGiaDiemThuongInfor dt in liDuLieu)
                //    {
                //        if (dt.MaLinhVuc == bteNganh.Text)
                //        {
                //            dt.TyLeThuongTu = Common.DoubleValue(txtThuongTu.Text);
                //            dt.TyLeThuongDen = Common.DoubleValue(txtThuongDen.Text);
                //        }
                //    }
                //}
                //else if (cboLoaiMaHang.SelectedIndex == 0)//nganh
                //{
                //    foreach (BangGiaDiemThuongInfor dt in liDuLieu)
                //    {
                //        if (dt.MaNganhHang == bteNganh.Text)
                //        {
                //            dt.TyLeThuongTu = Common.DoubleValue(txtThuongTu.Text);
                //            dt.TyLeThuongDen = Common.DoubleValue(txtThuongDen.Text);
                //        }
                //    }                    
                //}
                //else if (cboLoaiMaHang.SelectedIndex == 0)//loai
                //{
                //    foreach (BangGiaDiemThuongInfor dt in liDuLieu)
                //    {
                //        if (dt.MaLoai == bteNganh.Text)
                //        {
                //            dt.TyLeThuongTu = Common.DoubleValue(txtThuongTu.Text);
                //            dt.TyLeThuongDen = Common.DoubleValue(txtThuongDen.Text);
                //            break;
                //        }
                //    }                     
                //}
                BangGiaDiemThuongInfor dt = new BangGiaDiemThuongInfor();
                dt.MaSanPham = bteNganh.Text;
                dt.TyLeThuongTu = Common.DoubleValue(txtThuongTu.Text);
                dt.TyLeThuongDen = Common.DoubleValue(txtThuongDen.Text);
                BangGiaDiemThuongDataProvider.Instance.Update(dt);
                liDuLieu.Add(dt);
                ((BindingList<BangGiaDiemThuongInfor>)gListData.DataSource).ResetBindings();
                MessageBox.Show("Cập nhật dữ liệu thành công!");
            }
        }

        private void bteNganh_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteItemSegment_ButtonClick(sender, e, bteNganh, cboLoaiMaHang.SelectedIndex);
        }

        private void bteNganh_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteItemSegment_KeyDown(sender, e, bteNganh, cboLoaiMaHang.SelectedIndex);
        }

        private void bteNganh_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteNganh);
        }
    }
}