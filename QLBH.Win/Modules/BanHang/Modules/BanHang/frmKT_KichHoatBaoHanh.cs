using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
//using QLBanHang.Class;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QLBanHang.Modules.BanHang.DAO;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmKT_KichHoatBaoHanh : DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"
        private List<ChungTuBanHangChiTietHangHoaBHInfor> liChungTuChiTiet = new List<ChungTuBanHangChiTietHangHoaBHInfor>();
        private List<ChungTuBanHangChiTietHangHoaBHInfor> liTimKiem = new List<ChungTuBanHangChiTietHangHoaBHInfor>();

        public TimKiemChungTuChiTietFilterInfor filter = new TimKiemChungTuChiTietFilterInfor();
        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
        private int SoLuongHienTai = 0;

#endregion

#region "Các phương thức khởi tạo"
        public frmKT_KichHoatBaoHanh()
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
                CommonFuns.Instance.LoadTrungTamBaoHanh(bteTrungTam, nguoiDung);
                CommonFuns.Instance.LoadNganhHang(lueLoaiSanPham, nguoiDung, false);

                dteEnd.DateTime = Declare.SYSDATE;
                
                dteStart.DateTime = dteEnd.DateTime.AddDays(-1);

                LoadAllTrangThai();
                LoadHangDefault();
                //TimKiemChungTu();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadHangDefault()
        {
            SegmentInfo hangSX = TimKiemItemDataProvider.Instance.GetHangInfo("", Declare.HangBaoHanhDefault);
            if (hangSX != null)
            {
                bteHangSanXuat.Tag = hangSX;
                bteHangSanXuat.Text = hangSX.Ten;
            }
        }

        private void LoadAllTrangThai()
        {
            List<TrangThaiBH> liLoaiDH = Common.GetListLoaiDonHang();
            List<TrangThaiBH> liTrangThaiDH = Common.GetListTrangThaiDonHang();
            //load trang thai cho grid
            repLoaiDonHang.DataSource = liLoaiDH;
            repTrangThaiDH.DataSource = liTrangThaiDH;

            List<TrangThaiBH> liLoaiGD = new List<TrangThaiBH>();
            liLoaiGD.Add(new TrangThaiBH { Id = 0, Name = "Xuất bán" });
            liLoaiGD.Add(new TrangThaiBH { Id = 1, Name = "Nhập lại" });
            repLoaiGiaoDich.DataSource = liLoaiGD;

            //load trang thai draft
            List<TrangThaiBH> liLoaiGD1 = new List<TrangThaiBH>();
            liLoaiGD1.Add(new TrangThaiBH { Id = -1, Name = "Tất cả" });
            liLoaiGD1.AddRange(liLoaiGD);
            lueLoaiGiaoDich.Properties.DataSource = liLoaiGD1;
            lueLoaiGiaoDich.EditValue = -1;

            List<TrangThaiBH> liLoaiMV = new List<TrangThaiBH>();
            liLoaiMV.Add(new TrangThaiBH { Id = -1, Name = "Tất cả" });
            liLoaiMV.Add(new TrangThaiBH { Id = 0, Name = "Số IMEI" });
            liLoaiMV.Add(new TrangThaiBH { Id = 1, Name = "Số Serial Number" });
            lueLoaiMaVach.Properties.DataSource = liLoaiMV;
            lueLoaiMaVach.EditValue = -1;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            SoLuongHienTai = 0;
            SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
            liChungTuChiTiet = new List<ChungTuBanHangChiTietHangHoaBHInfor>();

            TimKiemChungTu();
        }

        private void GetFilter()
        {
            if (filter == null)
                filter = new TimKiemChungTuChiTietFilterInfor();
            filter.SoPhieu = txtSoGiaoDich.Text.Trim();
            filter.TrangThai = 1;//da xuat kho
            filter.LoaiDonHang = Common.IntValue(lueLoaiGiaoDich.EditValue);
            filter.IdTrungTam = CommonFuns.Instance.GetIdTrungTamBaoHanh(bteTrungTam, nguoiDung); 
            filter.IdKho = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : -1;
            filter.SanPham = txtSanPham.Text.Trim();
            filter.TuNgay = Convert.ToDateTime(dteStart.EditValue);
            filter.DenNgay = Convert.ToDateTime(dteEnd.EditValue);
            filter.KhachHang = txtHoTenKhachHang.Text.Trim();
            filter.GhiChu = "";
            filter.UserName = "";//"chkCuaToi.Checked ? nguoiDung.TenDangNhap : "";
            filter.MaVach = txtMaVach.Text;
            filter.LoaiMaVach = Common.IntValue(lueLoaiMaVach.EditValue);
            filter.HangSanXuat = bteHangSanXuat.Tag != null
                                     ? ((SegmentInfo) bteHangSanXuat.Tag).Ma
                                     : (nguoiDung.SupperUser == 1 ? "" : "-1");
            filter.Nganh = lueLoaiSanPham.EditValue != null
                                   ? lueLoaiSanPham.EditValue.ToString()
                                   : ((nguoiDung.SupperUser == 1 || nguoiDung.SaleAdmin == 1) ? "" : "-1");
            //filter.LoaiMaHang = Common.IntValue(lueLoaiSanPham.EditValue);
        }

        private DateTime startDate, endDate;
        private int filterIdTrungTam, filterIdKho;
        private List<DMKhoInfo> liKho;
        private List<QLBanHang.Modules.BanHang.DAO.StorageInfor> computedStorages;
        private bool isCompletedLoadComputedStorages;

        private void LoadComputedStorages()
        {
            isCompletedLoadComputedStorages = false;

            DateTime runningDate = startDate;

            while (runningDate <= endDate)
            {
                computedStorages.AddRange(

                    KichHoatBaoHanhDataProvider.Instance.

                        GetListComputedStorage(runningDate, filterIdTrungTam, filterIdKho));

                runningDate = runningDate.AddDays(1);
            }

            isCompletedLoadComputedStorages = true;
        }

        private void LoadDuLieu()
        {
            frmProgress.Instance.Value = 0;

            frmProgress.Instance.MaxValue = 1;

            frmProgress.Instance.Caption = "Tổng hợp dữ liệu";

            frmProgress.Instance.Description = "Đang tổng hợp dữ liệu ...";

            if(!String.IsNullOrEmpty(filter.SoPhieu))
            {
                filter.SoBatDau = filter.SoKetThuc = -1;

                liTimKiem = KichHoatBaoHanhDataProvider.Instance.TimKiemChungTuChiTietMaVachBaoHanhPg(filter);

                liChungTuChiTiet.Clear();

                liChungTuChiTiet.AddRange(liTimKiem);

                if (gListChungTu.InvokeRequired)

                    Invoke((MethodInvoker)
                           delegate
                           {
                               gListChungTu.RefreshDataSource();
                           });
                else

                    gListChungTu.RefreshDataSource();
                
            }
            else if (filterIdTrungTam <= 0 || filterIdKho <= 0)
            {
                filter.SoBatDau = filter.SoKetThuc = -1;

                var totalDays = (int)(endDate - startDate).TotalDays;

                DateTime runningDate = startDate;

                frmProgress.Instance.MaxValue = totalDays + 1;

                liChungTuChiTiet.Clear();

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

                        liTimKiem = KichHoatBaoHanhDataProvider.Instance.TimKiemChungTuChiTietMaVachBaoHanhPg(filter);

                        liChungTuChiTiet.AddRange(liTimKiem);

                        if (InvokeRequired)

                            Invoke((MethodInvoker)
                                   delegate
                                   {
                                       gListChungTu.RefreshDataSource();

                                       if (gvListChungTu.RowCount > 0)

                                           gvListChungTu.FocusedRowHandle = 0;

                                       this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + liChungTuChiTiet.Count + " mặt hàng)";
                                   });

                        computedStorages.RemoveAt(0);

                        frmProgress.Instance.MaxValue = frmProgress.Instance.Value + computedStorages.Count;

                        frmProgress.Instance.Value += 1;
                    }

                    runningDate = runningDate.AddDays(1);
                }

            }

            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;

            frmProgress.Instance.Description = "Đã xong";

            frmProgress.Instance.IsCompleted = true;
        }

        private void TimKiemChungTu()
        {
            try
            {
                GetFilter();
                
                liChungTuChiTiet.Clear();
                
                gListChungTu.DataSource = liChungTuChiTiet;

                startDate = dteStart.DateTime.Date;

                endDate = dteEnd.DateTime.Date;
                
                filterIdTrungTam = filter.IdTrungTam;

                filterIdKho = filter.IdKho;

                computedStorages = new List<StorageInfor>();

                if (String.IsNullOrEmpty(filter.SoPhieu) &&
                    (filter.IdTrungTam <= 0 || filter.IdKho <= 0))
                {
                    var loadComputedStorages = new Thread(LoadComputedStorages);

                    loadComputedStorages.Start();
                }

                //frmProgress.Instance.Description = Common.MsgProgress(SoLuongTimKiem);
                //frmProgress.Instance.MaxValue = SoLuongTimKiem;
                //frmProgress.Instance.Value = 0;
                frmProgress.Instance.DoWork(LoadDuLieu);

                //gListChungTu.DataSource = new BindingList<ChungTuBanHangChiTietHangHoaBHInfor>(liChungTuChiTiet);
                gvListChungTu.ExpandAllGroups();
                selector.View = gvListChungTu;
                selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                selector.CheckMarkColumn.VisibleIndex = 0;
                //((BindingList<ChungTuBanHangChiTietHangHoaBHInfor>)gListChungTu.DataSource).ResetBindings();
                SoLuongHienTai = liChungTuChiTiet.Count;
                selector.ClearSelection();

                this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + liChungTuChiTiet.Count + " mặt hàng)";
                //if (gvListChungTu.RowCount == 0)
                //{
                //    MessageBox.Show("Không có chứng từ nào thỏa mãn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}
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
            //Common.DevExport2Excel(gvListChungTu);
            if (selector.selection.Count==0)
            {
                MessageBox.Show("Chưa chọn sản phẩm nào!");
            }
            else
            {
                ArrayList liSanPham = new ArrayList();
                liSanPham.AddRange(selector.selection);
                if (Common.IntValue(lueLoaiSanPham.EditValue) == 1)//cac san pham khac
                {
                    frmKT_KichHoatBaoHanh_Mobile_Export frm = new frmKT_KichHoatBaoHanh_Mobile_Export(liSanPham);
                    frm.ShowDialog();                                        
                }
                else
                {
                    frmKT_KichHoatBaoHanh_Mobile_Export frm = new frmKT_KichHoatBaoHanh_Mobile_Export(liSanPham);
                    //frmKT_KichHoatBaoHanh_Export frm = new frmKT_KichHoatBaoHanh_Export(liSanPham);
                    frm.ShowDialog();                                        
                }
            }
        }

        private void gvListChungTu_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            ChungTuBanHangChiTietHangHoaBHInfor ct = (ChungTuBanHangChiTietHangHoaBHInfor)gvListChungTu.GetRow(e.RowHandle);
            if (ct != null)
            {
                if (ct.LoaiGiaoDich == 1 && (e.Column.FieldName.Equals("LoaiGiaoDich") || e.Column.FieldName.Equals("TenKho") || e.Column.FieldName.Equals("NgayLap")))
                {
                    e.Appearance.BackColor = tsslGiamGia.BackColor;
                    e.Appearance.ForeColor = tsslGiamGia.ForeColor;
                    //e.Appearance.Font = new Font("Arial", 9, FontStyle.Italic);
                }
            }
        }

        private void bteHangSanXuat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteHangSanXuat_ButtonClick(sender, e, bteHangSanXuat);
        }

        private void bteHangSanXuat_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteHangSanXuat_KeyDown(sender, e, bteHangSanXuat);
        }

        private void bteHangSanXuat_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteHangSanXuat);
        }

        private void frmKT_KichHoatBaoHanh_Activated(object sender, EventArgs e)
        {
            //if (liChungTuChiTiet.Count>0)
            //{
            //    TimKiemChungTu();
            //}
        }

        private void gvListChungTu_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            //ChungTuBanHangChiTietHangHoaBHInfor ct = (ChungTuBanHangChiTietHangHoaBHInfor)gvListChungTu.GetRow(e.RowHandle);
            //if (ct != null)
            //{
            //    if (ct.LoaiGiaoDich == 1)
            //    {
            //        e.Appearance.BackColor = tsslGiamGia.BackColor;
            //        e.Appearance.ForeColor = tsslGiamGia.ForeColor;
            //        //e.Appearance.Font = new Font("Arial", 9, FontStyle.Italic);
            //    }
            //}
        }
    }
}