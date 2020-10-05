using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
//using QLBanHang.Class;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QLBanHang.Modules.BanHang.DAO;
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
using QLBH.Core.Exceptions;
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBC_DonHangChiTietXuatKho : DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"
        private List<ChungTuBanHangChiTietHangHoaBCInfor> liChungTuChiTiet = new List<ChungTuBanHangChiTietHangHoaBCInfor>();
        private List<ChungTuBanHangChiTietHangHoaBCInfor> liTimKiem = new List<ChungTuBanHangChiTietHangHoaBCInfor>();
        public TimKiemChungTuChiTietFilterInfor filter = new TimKiemChungTuChiTietFilterInfor();
        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
        private int SoLuongHienTai = 0;

#endregion

#region "Các phương thức khởi tạo"
        public frmBC_DonHangChiTietXuatKho()
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
                CommonFuns.Instance.LoadTrungTam(bteTrungTam, nguoiDung);
                //TimKiemChungTu();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadAllTrangThai()
        {
            List<TrangThaiBH> liLoaiDH = Common.GetListBCLoaiDonHang();
            List<TrangThaiBH> liTrangThaiDH = Common.GetListBCTrangThaiDonHang();
            //load trang thai cho grid
            liLoaiDH.Add(new TrangThaiBH { Id = -2, Name = "Xuất trả nhà cung cấp" });
            repLoaiDonHang.DataSource = liLoaiDH;
            repTrangThaiDH.DataSource = liTrangThaiDH;

            List<TrangThaiBH> liLoaiDH1 = new List<TrangThaiBH>();
            liLoaiDH1.Add(new TrangThaiBH { Id = -1, Name = "Tất cả" });
            liLoaiDH1.AddRange(liLoaiDH);
            lueLoaiDH.Properties.DataSource = liLoaiDH1;
            lueLoaiDH.EditValue = -1;

            List<TrangThaiBH> liTrangThaiDH1 = new List<TrangThaiBH>();
            liTrangThaiDH1.Add(new TrangThaiBH { Id = -1, Name = "Tất cả" });
            liTrangThaiDH1.Add(new TrangThaiBH { Id = 0, Name = "Chưa xuất kho" });
            liTrangThaiDH1.Add(new TrangThaiBH { Id = 1, Name = "Đã xuất kho" });
            lueTrangThaiDH.Properties.DataSource = liTrangThaiDH1;
            lueTrangThaiDH.EditValue = -1;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            SoLuongHienTai = 0;
            SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
            liChungTuChiTiet = new List<ChungTuBanHangChiTietHangHoaBCInfor>();

            TimKiemChungTu();
        }

        private void GetFilter()
        {
            var sysDate = CommonProvider.Instance.GetSysDate();

            if (filter == null)
                filter = new TimKiemChungTuChiTietFilterInfor();
            filter.SoPhieu = txtSoGiaoDich.Text.Trim();
            filter.LoaiDonHang = Common.IntValue(lueLoaiDH.EditValue);
            filter.TrangThai = Common.IntValue(lueTrangThaiDH.EditValue);
            filter.IdTrungTam = CommonFuns.Instance.GetIdTrungTam(bteTrungTam, nguoiDung);
            filter.IdKho = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : -1;
            filter.SanPham = txtSanPham.Text.Trim();
            filter.NhanVien = txtNhanVien.Text.Trim();
            filter.TuNgay = dteStart.EditValue == null ? sysDate.AddDays(-sysDate.Day) : Convert.ToDateTime(dteStart.EditValue);
            filter.DenNgay = dteEnd.EditValue == null ? sysDate : Convert.ToDateTime(dteEnd.EditValue);
            filter.NXTuNgay = dteNXStart.EditValue == null ? sysDate.AddDays(-sysDate.Day) : Convert.ToDateTime(dteNXStart.EditValue);
            filter.NXDenNgay = dteNXEnd.EditValue == null ? sysDate : Convert.ToDateTime(dteNXEnd.EditValue);
            filter.KhachHang = txtHoTenKhachHang.Text.Trim();
            filter.GhiChu = "";
            filter.UserName = CommonFuns.Instance.GetUserName();//"chkCuaToi.Checked ? nguoiDung.TenDangNhap : "";
            filter.MaVach = txtMaVach.Text;
            filter.IdNhanVien = nguoiDung.IdNhanVien;
            filter.IdNhomNguoiDung = nguoiDung.SupperUser == 1 ? -1 : nguoiDung.IdNhomNguoiDung;
        }

        private DataTable dataTable;

        private void LoadDuLieu()
        {
            DateTime runningDate;

            filter.SoBatDau = SoLuongHienTai;

            filter.SoKetThuc = SoLuongTimKiem != -1 ? SoLuongHienTai + SoLuongTimKiem : -1;

            if (dataTable == null)
            {
                dataTable = new DataTable("ChiTietXuatKho");
            }
            else
            {
                dataTable.Rows.Clear();
            }

            if (InvokeRequired)

                Invoke((MethodInvoker)
                       delegate
                           {
                               gListChungTu.DataSource = null;

                               gListChungTu.RefreshDataSource();
                           });

            frmProgress.Instance.Caption = "Chi tiết xuất kho";

            frmProgress.Instance.Description = "Đang nạp dữ liệu ...";

            if (String.IsNullOrEmpty(filter.SoPhieu))
            {
                int totalDays = (int)(endDate - startDate).TotalDays;

                frmProgress.Instance.Value = 0;

                runningDate = startDate;

                if (filterIdTrungTam <= 0 && filterIdKho <= 0)
                {
                    frmProgress.Instance.MaxValue = totalDays + 1;

                    while (runningDate <= endDate)
                    {
                        if(isBelongNgayLap)
                            
                            filter.TuNgay = filter.DenNgay = runningDate;

                        else

                            filter.NXTuNgay = filter.NXDenNgay = runningDate;
                    
                        while (computedStorages.Count == 0 && !isCompletedLoadComputedStorages)
                        {
                            Thread.CurrentThread.Join(500);
                        }

                        while (computedStorages.FindAll(
                            delegate (StorageInfor match)
                                {
                                    return match.RunningDate.Date == runningDate.Date;
                                }).Count > 0)
                        {
                            filter.IdTrungTam = computedStorages[0].IdTrungTam;

                            dataTable.Rows.Clear();

                            DonHangChiTietXuatKhoDataProvider.Instance.TimKiemChungTuChiTietMaVachPg(filter, dataTable);

                            if (InvokeRequired)

                                Invoke((MethodInvoker)
                                       delegate
                                       {
                                           if (gListChungTu.DataSource == null)

                                               gListChungTu.DataSource = dataTable.Copy();

                                           else

                                               (gListChungTu.DataSource as DataTable).Merge(dataTable.Copy());

                                           (gvListChungTu.DataSource as DataView).Sort = "NGAYLAP DESC";

                                           gListChungTu.RefreshDataSource();

                                           if (gvListChungTu.RowCount > 0)

                                               gvListChungTu.FocusedRowHandle = 0;

                                           this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + (gListChungTu.DataSource as DataTable).Rows.Count + " phiếu)";
                                       });

                            computedStorages.RemoveAt(0);

                            frmProgress.Instance.MaxValue = frmProgress.Instance.Value + computedStorages.Count;

                            frmProgress.Instance.Value += 1;
                        }

                        runningDate = runningDate.AddDays(1);
                    }
                } 
                else if(filterIdTrungTam > 0 && filterIdKho > 0)
                {
                    frmProgress.Instance.MaxValue = totalDays + 1;
    
                    while (runningDate <= endDate)
                    {
                        if (isBelongNgayLap)

                            filter.TuNgay = filter.DenNgay = runningDate;

                        else

                            filter.NXTuNgay = filter.NXDenNgay = runningDate;


                        DonHangChiTietXuatKhoDataProvider.Instance.TimKiemChungTuChiTietMaVachPg(filter, dataTable);

                        Invoke((MethodInvoker)
                               delegate
                                   {
                                       gListChungTu.DataSource = dataTable.Copy();

                                       (gvListChungTu.DataSource as DataView).Sort = "NGAYLAP DESC";

                                       gListChungTu.RefreshDataSource();

                                       if (gvListChungTu.RowCount > 0)

                                           gvListChungTu.FocusedRowHandle = 0;

                                       this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + dataTable.Rows.Count +
                                                                    " phiếu)";
                                   });

                        frmProgress.Instance.MaxValue = frmProgress.Instance.Value + computedStorages.Count;

                        frmProgress.Instance.Value += 1;

                        runningDate = runningDate.AddDays(1);
                    }
                }
                else if(filterIdTrungTam > 0 && filterIdKho <= 0)
                {
                    frmProgress.Instance.MaxValue = totalDays + 1;

                    while (runningDate <= endDate)
                    {
                        if (isBelongNgayLap)

                            filter.TuNgay = filter.DenNgay = runningDate;

                        else

                            filter.NXTuNgay = filter.NXDenNgay = runningDate;


                        while (computedStorages.Count == 0 && !isCompletedLoadComputedStorages)
                        {
                            Thread.CurrentThread.Join(500);
                        }

                        while (computedStorages.FindAll(
                            delegate(StorageInfor match)
                            {
                                return match.RunningDate.Date == runningDate.Date;
                            }).Count > 0)
                        {
                            filter.IdTrungTam = computedStorages[0].IdTrungTam;

                            DonHangChiTietXuatKhoDataProvider.Instance.TimKiemChungTuChiTietMaVachPg(filter, dataTable);

                            Invoke((MethodInvoker)
                                   delegate
                                   {
                                       gListChungTu.DataSource = dataTable.Copy();

                                       (gvListChungTu.DataSource as DataView).Sort = "NGAYLAP DESC";

                                       gListChungTu.RefreshDataSource();

                                       if (gvListChungTu.RowCount > 0)

                                           gvListChungTu.FocusedRowHandle = 0;

                                       this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + dataTable.Rows.Count + " phiếu)";
                                   });

                            computedStorages.RemoveAt(0);

                            frmProgress.Instance.MaxValue = frmProgress.Instance.Value + computedStorages.Count;

                            frmProgress.Instance.Value += 1;
                        }

                        runningDate = runningDate.AddDays(1);
                    }
                }
                else if(filterIdTrungTam <= 0 && filterIdKho > 0)
                {
                    frmProgress.Instance.MaxValue = totalDays + 1;

                    while (runningDate <= endDate)
                    {
                        if (isBelongNgayLap)

                            filter.TuNgay = filter.DenNgay = runningDate;

                        else

                            filter.NXTuNgay = filter.NXDenNgay = runningDate;

                        while (computedStorages.Count == 0 && !isCompletedLoadComputedStorages)
                        {
                            Thread.CurrentThread.Join(500);
                        }

                        while (computedStorages.FindAll(
                            delegate(StorageInfor match)
                            {
                                return match.RunningDate.Date == runningDate.Date;
                            }).Count > 0)
                        {
                            filter.IdTrungTam = computedStorages[0].IdTrungTam;

                            DonHangChiTietXuatKhoDataProvider.Instance.TimKiemChungTuChiTietMaVachPg(filter, dataTable);

                            Invoke((MethodInvoker)
                                   delegate
                                   {
                                       gListChungTu.DataSource = dataTable.Copy();

                                       (gvListChungTu.DataSource as DataView).Sort = "NGAYLAP DESC";

                                       gListChungTu.RefreshDataSource();

                                       if (gvListChungTu.RowCount > 0)

                                           gvListChungTu.FocusedRowHandle = 0;

                                       this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + dataTable.Rows.Count + " phiếu)";
                                   });

                            computedStorages.RemoveAt(0);

                            frmProgress.Instance.MaxValue = frmProgress.Instance.Value + computedStorages.Count;

                            frmProgress.Instance.Value += 1;
                        }

                        runningDate = runningDate.AddDays(1);
                    }
                }
            }
            else
            {
                frmProgress.Instance.MaxValue = 1;

                frmProgress.Instance.Value = 0;

                DonHangChiTietXuatKhoDataProvider.Instance.TimKiemChungTuChiTietMaVachPg(filter, dataTable);

                Invoke((MethodInvoker)
                       delegate
                       {
                           gListChungTu.DataSource = dataTable.Copy();

                           (gvListChungTu.DataSource as DataView).Sort = "NGAYLAP DESC";

                           gListChungTu.RefreshDataSource();

                           this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + dataTable.Rows.Count + " phiếu)";
                       });

                frmProgress.Instance.Value += 1;
            }

            //liTimKiem = BanHangDataProvider.Instance.TimKiemChungTuChiTietMaVachPg(filter);
            
            //liChungTuChiTiet.AddRange(liTimKiem);

            //liChungTuChiTiet = BanHangDataProvider.Instance.TimKiemChungTuChiTietMaVach(filter);
            //liChungTuChiTiet = BanHangDataProvider.Instance.TimKiemChungTuChiTiet(filter);
            //dsChungTuChiTiet = BanHangDataProvider.Instance.TimKiemChungTuChiTietOld(filter);

            frmProgress.Instance.Description = "Đã tổng hợp xong!";

            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;

            frmProgress.Instance.IsCompleted = true;
        }

        private DateTime startDate, endDate;
        private int filterIdTrungTam, filterIdKho;
        private List<QLBanHang.Modules.BanHang.DAO.StorageInfor> computedStorages;
        private bool isCompletedLoadComputedStorages;
        private bool isBelongNgayLap, isBelongNgayNhapXuat;
        
        private void LoadComputedStorages()
        {
            isCompletedLoadComputedStorages = false;

            DateTime runningDate = startDate;

            while (runningDate <= endDate)
            {
                computedStorages.AddRange(

                    DonHangChiTietXuatKhoDataProvider.Instance.

                    GetListComputedStorage(isBelongNgayNhapXuat ? "ngayxuathang" : "ngaylap",  runningDate, filterIdTrungTam, filterIdKho));

                runningDate = runningDate.AddDays(1);
            }

            isCompletedLoadComputedStorages = true;
        }

        private void TimKiemChungTu()
        {
            try
            {
                if (dteStart.EditValue == null && dteNXStart.EditValue == null)

                    throw new ManagedException("Chưa xác định khoảng thời gian");

                GetFilter();

                if (filter.DenNgay.Subtract(filter.TuNgay).TotalDays < 0)

                    throw new ManagedException("Khoảng thời gian lập không hợp lệ");

                if (filter.NXDenNgay.Subtract(filter.NXTuNgay).TotalDays < 0)

                    throw new ManagedException("Khoảng thời gian nhập xuất không hợp lệ");

                isBelongNgayLap = dteStart.EditValue != null;

                isBelongNgayNhapXuat = dteNXStart.EditValue != null;

                if (dteStart.EditValue != null && dteNXStart.EditValue != null)
                {
                    isBelongNgayLap = filter.DenNgay.Subtract(filter.TuNgay).TotalDays <
                                      filter.NXDenNgay.Subtract(filter.NXTuNgay).TotalDays;

                    isBelongNgayNhapXuat = filter.NXDenNgay.Subtract(filter.NXTuNgay).TotalDays <=
                                           filter.DenNgay.Subtract(filter.TuNgay).TotalDays;
                }
                
                if (isBelongNgayLap)
                {
                    startDate = filter.TuNgay;
                    endDate = filter.DenNgay;
                    filter.NXTuNgay = filter.NXDenNgay = DateTime.MinValue;
                }

                if (isBelongNgayNhapXuat)
                {
                    startDate = filter.NXTuNgay;
                    endDate = filter.NXDenNgay;
                    filter.TuNgay = filter.DenNgay = DateTime.MinValue;
                }

                filterIdTrungTam = filter.IdTrungTam;

                filterIdKho = filter.IdKho;

                computedStorages = new List<StorageInfor>();

                if(filter.IdTrungTam <= 0)
                {
                    var loadComputeStorages = new Thread(LoadComputedStorages);

                    loadComputeStorages.Start();
                }

                frmProgress.Instance.Description = Common.MsgProgress(SoLuongTimKiem);
                frmProgress.Instance.MaxValue = SoLuongTimKiem;
                frmProgress.Instance.Value = 0;
                frmProgress.Instance.DoWork(LoadDuLieu);

                //gListChungTu.DataSource = null;
                //gListChungTu.DataSource = new BindingList<ChungTuBanHangChiTietHangHoaBCInfor>(liChungTuChiTiet);
                //gvListChungTu.Columns["ParentName"].GroupIndex = 0;
                //gvListChungTu.ExpandAllGroups();
                selector.View = gvListChungTu;
                selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                selector.CheckMarkColumn.VisibleIndex = 0;
                //((BindingList<ChungTuBanHangChiTietHangHoaBCInfor>)gListChungTu.DataSource).ResetBindings();
                //SoLuongHienTai = liChungTuChiTiet.Count;
                selector.ClearSelection();

                //this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + liChungTuChiTiet.Count + " mặt hàng)";
                //if (gvListChungTu.RowCount == 0)
                //{
                //    MessageBox.Show("Không có chứng từ nào thỏa mãn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}
            }
            catch (ManagedException ex)
            {
                MessageBox.Show(ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            EditOrder(gvListChungTu.FocusedRowHandle);
        }

        private void gListChungTu_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter && gvListChungTu.RowCount > 0)
                {
                    EditOrder(gvListChungTu.FocusedRowHandle);
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
        private void EditOrder(int rowHandle)
        {
            return;
        }


        private void gListChungTu_DoubleClick(object sender, EventArgs e)
        {
            Point pt = gListChungTu.PointToClient(MousePosition);
            GridHitInfo hitInfo = gvListChungTu.CalcHitInfo(pt);
            if (hitInfo.InRow)
                EditOrder(hitInfo.RowHandle);
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
                else if (e.KeyCode == Keys.F6)
                    this.btnCapNhat_Click(sender, e);
                else if (e.KeyCode == Keys.F12)
                    this.btnDong_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }


        private void ResetTrungTam()
        {
            bteKhoXuat.ResetText();
            bteKhoXuat.Tag = null;
        }

        private void bteTrungTam_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (UtilFunctions.bteTrungTam_ButtonClick(sender, e, bteTrungTam, nguoiDung.IdNhanVien))
                ResetTrungTam();
        }

        private void bteTrungTam_KeyDown(object sender, KeyEventArgs e)
        {
            if (UtilFunctions.bteTrungTam_KeyDown(sender, e, bteTrungTam, nguoiDung.IdNhanVien))
                ResetTrungTam();
        }

        private void bteTrungTam_TextChanged(object sender, EventArgs e)
        {
            if (UtilFunctions.bteItem_TextChanged(sender, e, bteTrungTam))
                ResetTrungTam();
        }

        private void bteKhoXuat_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteKhoXuat);
        }

        private void bteKhoXuat_KeyDown(object sender, KeyEventArgs e)
        {
            int idTrungTam = bteTrungTam.Tag != null ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam : 0;
            UtilFunctions.bteKhoXuat_KeyDown(sender, e, bteKhoXuat, idTrungTam, nguoiDung.IdNhanVien);
        }

        private void bteKhoXuat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int idTrungTam = bteTrungTam.Tag != null ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam : 0;
            UtilFunctions.bteKhoXuat_ButtonClick(sender, e, bteKhoXuat, idTrungTam, nguoiDung.IdNhanVien);
        }

        private void gvListChungTu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
        }


        private void cmdExport_Click(object sender, EventArgs e)
        {
            //Common.DevExport2Excel(gvListChungTu, "BCDonHangChiTietXuatKho");
            Common.Export2ExcelFromDataSource(gvListChungTu, "BCDonHangChiTietXuatKho");
        }

        private void gvListChungTu_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {

        }
    }
}