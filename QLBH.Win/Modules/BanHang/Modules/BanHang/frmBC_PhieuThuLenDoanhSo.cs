using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
//using QLBanHang.Class;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraReports.Design;
using QLBanHang.Modules.BanHang.DAO;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;
using QLBH.Common.Providers;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBH.Core.Form;
using QLBH.Core.Providers;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBC_PhieuThuLenDoanhSo : DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"

        private List<ChungTuThanhToanBCInfor> liChungTuThanhToan = new List<ChungTuThanhToanBCInfor>();
        private List<ChungTuThanhToanBCInfor> liTimKiem = new List<ChungTuThanhToanBCInfor>();
        public TimKiemChungTuFilterInfor filter;
        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
        private int SoLuongHienTai = 0;
        private DataTable dataTable;

#endregion

#region "Các phương thức khởi tạo"
        public frmBC_PhieuThuLenDoanhSo()
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
                CommonFuns.Instance.LoadComboBoxPages(cboPage);
                CommonFuns.Instance.LoadTrungTam(bteTrungTam, nguoiDung);
                cboLoaiMaHang.SelectedIndex = 6;
                //gListChungTu.DataSource = liChungTuThanhToan;
                dteStart.EditValue = CommonProvider.Instance.GetSysDate();
                dteEnd.EditValue = dteStart.DateTime;
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
            repLoaiDonHang.DataSource = liLoaiDH;
            repTrangThai.DataSource = liTrangThaiDH;

            List<TrangThaiBH> liLoaiDH1 = new List<TrangThaiBH>();
            liLoaiDH1.Add(new TrangThaiBH { Id = -1, Name = "Tất cả" });
            liLoaiDH1.AddRange(liLoaiDH);
            lueLoaiDH.Properties.DataSource = liLoaiDH1;
            lueLoaiDH.EditValue = -1;

            List<TrangThaiBH> liTrangThaiDH1 = new List<TrangThaiBH>();
            liTrangThaiDH1.Add(new TrangThaiBH { Id = -1, Name = "Tất cả" });
            liTrangThaiDH1.AddRange(liTrangThaiDH);
            lueTrangThaiDH.Properties.DataSource = liTrangThaiDH1;
            lueTrangThaiDH.EditValue = -1;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                SoLuongHienTai = 0;
                SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
                liChungTuThanhToan = new List<ChungTuThanhToanBCInfor>();
                //gListChungTu.DataSource = new BindingList<ChungTuThanhToanBCInfor>(liChungTuThanhToan);
                //gvListChungTu.Columns["ParentName"].GroupIndex = 0;
                gvListChungTu.ExpandAllGroups();

                TimKiemChungTu();
            }
            catch (Exception ex)
            {
                EventLogProvider.Instance.WriteOfflineLog(ex.ToString(), "Báo cáo doanh thu.");
#if (DEBUG)
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
        }

        private void GetFilter()
        {
            if (filter == null)
                filter = new TimKiemChungTuFilterInfor();
            filter.SoPhieu = txtSoGiaoDich.Text.Trim();
            filter.LoaiDonHang = Common.IntValue(lueLoaiDH.EditValue);
            filter.TrangThai = Common.IntValue(lueTrangThaiDH.EditValue);
            filter.IdTrungTam = CommonFuns.Instance.GetIdTrungTam(bteTrungTam, nguoiDung);
            filter.IdKho = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : -1;
            filter.LoaiMaHang = cboLoaiMaHang.SelectedIndex;
            filter.MaHang = bteNganh.Text;
            filter.NhanVien = txtNhanVien.Text.Trim();
            filter.TuNgay = Convert.ToDateTime(dteStart.EditValue);
            filter.DenNgay = Convert.ToDateTime(dteEnd.EditValue);
            filter.KhachHang = txtHoTenKhachHang.Text.Trim();
            filter.UserName = CommonFuns.Instance.GetUserName();//"chkCuaToi.Checked ? nguoiDung.TenDangNhap : "";
            filter.IdNhanVien = nguoiDung.IdNhanVien;
            filter.IdNhomNguoiDung = nguoiDung.SupperUser == 1 ? -1 : nguoiDung.IdNhomNguoiDung;
        }

        private List<DMKhoCBOLoadInfo> lstKho;
        private List<DMTrungTamInfor> lstTrungTam;
        private DateTime startDate, endDate;
        private int filterIdTrungTam, filterIdKho;
        private List<QLBanHang.Modules.BanHang.DAO.StorageInfor> computedStorages;
        private bool isCompletedLoadComputedStorages;

        private void LoadComputedStorages()
        {
            isCompletedLoadComputedStorages = false;

            DateTime runningDate = startDate;

            while (runningDate <= endDate)
            {
                computedStorages.AddRange(

                    PhieuThuLenDoanhSoDataProvider.Instance.

                        GetListComputedStorage(runningDate, filterIdTrungTam, filterIdKho));

                runningDate = runningDate.AddDays(1);
            }

            isCompletedLoadComputedStorages = true;
        }

        private void LoadDuLieu()
        {
            DateTime runningDate;

            filter.SoBatDau = SoLuongHienTai;
            
            filter.SoKetThuc = SoLuongTimKiem > 0 ? SoLuongHienTai + SoLuongTimKiem : -1;

            if (dataTable == null)
            {
                dataTable = new DataTable("DoanhSo");
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

            frmProgress.Instance.Caption = "Tổng hợp doanh thu";

            frmProgress.Instance.Description = "Đang tổng hợp số liệu ...";

            if(String.IsNullOrEmpty(filter.SoPhieu))
            {
                
                int totalDays = (int)(endDate - startDate).TotalDays;

                frmProgress.Instance.Value = 0;

                runningDate = startDate;

                if (filterIdTrungTam <= 0 && filterIdKho <= 0)
                {
                    frmProgress.Instance.MaxValue = totalDays + 1;

                    while (runningDate <= endDate)
                    {
                        filter.TuNgay = filter.DenNgay = runningDate;

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

                            filter.IdKho = computedStorages[0].IdKho;

                            //liChungTuThanhToan.AddRange(BanHangDataProvider.Instance.TimKiemDoanhSoCTietPg(filter));

                            dataTable.Rows.Clear();

                            PhieuThuLenDoanhSoDataProvider.Instance.TimKiemDoanhSoCTietPg(filter, dataTable);

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
                        filter.TuNgay = filter.DenNgay = runningDate;

                        //liChungTuThanhToan.AddRange(BanHangDataProvider.Instance.TimKiemDoanhSoCTietPg(filter));

                        PhieuThuLenDoanhSoDataProvider.Instance.TimKiemDoanhSoCTietPg(filter, dataTable);

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
                        filter.TuNgay = filter.DenNgay = runningDate;

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

                            filter.IdKho = computedStorages[0].IdKho;

                            //liChungTuThanhToan.AddRange(BanHangDataProvider.Instance.TimKiemDoanhSoCTietPg(filter));

                            PhieuThuLenDoanhSoDataProvider.Instance.TimKiemDoanhSoCTietPg(filter, dataTable);

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
                        filter.TuNgay = filter.DenNgay = runningDate;

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

                            filter.IdKho = computedStorages[0].IdKho;

                            //liChungTuThanhToan.AddRange(BanHangDataProvider.Instance.TimKiemDoanhSoCTietPg(filter));

                            PhieuThuLenDoanhSoDataProvider.Instance.TimKiemDoanhSoCTietPg(filter, dataTable);

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

                //liChungTuThanhToan.AddRange(BanHangDataProvider.Instance.TimKiemDoanhSoCTietPg(filter));

                PhieuThuLenDoanhSoDataProvider.Instance.TimKiemDoanhSoCTietPg(filter, dataTable);

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

            frmProgress.Instance.Description = "Đã tổng hợp xong!";

            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            
            frmProgress.Instance.IsCompleted = true;
        }

        private void TimKiemChungTu()
        {
            try
            {
                GetFilter();
                //liChungTuThanhToan.Clear();
                //frmProgress.Instance.Description = Common.MsgProgress(SoLuongTimKiem);
                //frmProgress.Instance.MaxValue = SoLuongTimKiem;
                //frmProgress.Instance.Value = 0;
                
                startDate = filter.TuNgay.Date;

                endDate = filter.DenNgay.Date;

                filterIdTrungTam = filter.IdTrungTam;

                filterIdKho = filter.IdKho;

                computedStorages = new List<StorageInfor>();

                if(String.IsNullOrEmpty(filter.SoPhieu) &&
                    (filterIdTrungTam <= 0 || filterIdKho <= 0))
                {
                    var loadComputedStorages = new Thread(LoadComputedStorages);

                    loadComputedStorages.Start();
                }

                frmProgress.Instance.DoWork(LoadDuLieu);

                //selector.View = gvListChungTu;
                //selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                //selector.CheckMarkColumn.VisibleIndex = 0;
                //((BindingList<ChungTuThanhToanBCInfor>)gListChungTu.DataSource).ResetBindings();
                //SoLuongHienTai = liChungTuThanhToan.Count;
                //selector.ClearSelection();

                //this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + liChungTuThanhToan.Count + " phiếu)";
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
            //if (rowHandle < 0) return;
            //ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(rowHandle);

            //if ((int)LoaiGiaoDich > 0 && ct != null)
            //{
            //    this.DialogResult = DialogResult.OK;
            //}
            //else if (ct != null)
            //{
            //    if (ct.TrangThai == (int)OrderStatus.TAO_DON_HANG_ONLINE || ct.TrangThai == (int)OrderStatus.REJECT_DON_HANG_ONLINE)
            //    {
            //        frmBH_LapDonHangBanOnline frm = new frmBH_LapDonHangBanOnline(ct);
            //        frm.HideMenu();
            //        frm.ShowDialog();
            //    }
            //}
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
            //bteKhoXuat.ResetText();
            //bteKhoXuat.Tag = null;
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

        private void gvListChungTu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
        }

        private void cmdExport_Click(object sender, EventArgs e)
        {
            //Common.DevExport2Excel(gvListChungTu);
            //Common.Export2ExcelFromDevGrid<ChungTuThanhToanBCInfor>(gvListChungTu, "BCDoanhThuBanHang");
            //Common.Export2ExcelFromDevGridTest<ChungTuThanhToanBCInfor>(gvListChungTu, "BCDoanhThuBanHang");
            
            Common.Export2ExcelFromDataSource(gvListChungTu, "BCDoanhThuBanHang");
        }

        private void gvListChungTu_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //SoLuongTimKiem = Common.IntValue(cboPage.SelectedItem);
            //if (SoLuongTimKiem == 0)
            //    SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
            //if (cboPage.SelectedItem.Equals("Tất cả"))
            //{
            //    if (MessageBox.Show(Declare.msgLoadDataWrn, "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        SoLuongTimKiem = -1;
            //    }
            //    else
            //    {
            //        return;
            //    }
            //}

            //TimKiemChungTu();
        }

        private void bteKhoXuat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int idTrungTam = bteTrungTam.Tag != null ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam : 0;
            UtilFunctions.bteKhoXuat_ButtonClick(sender, e, bteKhoXuat, idTrungTam, nguoiDung.IdNhanVien);

        }

        private void bteKhoXuat_KeyDown(object sender, KeyEventArgs e)
        {
            int idTrungTam = bteTrungTam.Tag != null ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam : 0;
            UtilFunctions.bteKhoXuat_KeyDown(sender, e, bteKhoXuat, idTrungTam, nguoiDung.IdNhanVien);
        }

        private void bteKhoXuat_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteKhoXuat);
        }

        private void bteNganh_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteItemSegment_ButtonClick(sender, e, bteNganh, cboLoaiMaHang.SelectedIndex);

            //List<SegmentInfo> linhVucPrivilegeds =
            //    ((NguoiDungInfor)Declare.USER_INFOR).NganhHangNguoiDung.ConvertAll(
            //        delegate(PhanQuyenNganhHangInfor match)
            //            {
            //                return new SegmentInfo{Ma = match.MaLinhVuc, Ten = match.TenLinhVuc};
            //            });

            //List<SegmentInfo> nganhPrivilegeds =
            //    ((NguoiDungInfor)Declare.USER_INFOR).NganhHangNguoiDung.ConvertAll(
            //        delegate(PhanQuyenNganhHangInfor match)
            //        {
            //            return new SegmentInfo { Ma = match.MaNganhHang, Ten = match.TenNganhHang };
            //        });

            //List<SegmentInfo> loaiPrivilegeds =
            //    ((NguoiDungInfor)Declare.USER_INFOR).NganhHangNguoiDung.ConvertAll(
            //        delegate(PhanQuyenNganhHangInfor match)
            //        {
            //            return new SegmentInfo { Ma = match.MaLoai, Ten = match.MaLoai };
            //        });

            //Form frmLookUp = null;
            //switch (cboLoaiMaHang.SelectedIndex)
            //{
            //    case 0: frmLookUp = new frmLookUp_LinhVuc(String.Format("%{0}%", bteNganh.Text), linhVucPrivilegeds);
            //        break;
            //    case 1: frmLookUp = new frmLookUp_Nganh(String.Format("%{0}%", bteNganh.Text), nganhPrivilegeds);
            //        break;
            //    case 2: frmLookUp = new frmLookUp_Loai(String.Format("%{0}%", bteNganh.Text), loaiPrivilegeds);
            //        break;
            //    case 3: frmLookUp = new frmLookUp_Chung(String.Format("%{0}%", bteNganh.Text));
            //        break;
            //    case 4: frmLookUp = new frmLookUp_Nhom(String.Format("%{0}%", bteNganh.Text));
            //        break;
            //    case 5: frmLookUp = new frmLookUp_Model(String.Format("%{0}%", bteNganh.Text));
            //        break;
            //    case 6: frmLookUp = new frmLookUp_SanPham(String.Format("%{0}%", bteNganh.Text));
            //        break;
            //}

            //if (frmLookUp != null && frmLookUp.ShowDialog() == DialogResult.OK)
            //{
            //    if(frmLookUp is frmLookUpBaseSanPham)
            //    {
            //        bteNganh.Tag = ((frmLookUpBaseSanPham)frmLookUp).SelectedItem;
            //        bteNganh.Text = ((frmLookUpBaseSanPham)frmLookUp).SelectedItem.MaSanPham;
            //    } 
            //    else
            //    {
            //        bteNganh.Tag = ((frmLookUpBaseSegmentInfo)frmLookUp).SelectedItem;
            //        bteNganh.Text = ((frmLookUpBaseSegmentInfo)frmLookUp).SelectedItem.Ten;                    
            //    }
            //}
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