using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using QLBanHang.Class;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
    public partial class frmBH_ListChungTuBase : DevExpress.XtraEditors.XtraForm
    {
        #region Declaration

        protected List<ChungTuBanHangInfor> liChungTu = new List<ChungTuBanHangInfor>();
        private List<ChungTuBanHangInfor> liTimKiem = new List<ChungTuBanHangInfor>();

        protected ChungTuBanHangInfor ChungTu = new ChungTuBanHangInfor();
        public objGridMarkSelection selector = new objGridMarkSelection();

        protected int IdKhoSelected = Declare.IdKho;
        protected int IdTTamSelected = Declare.IdTrungTam;
        protected int IdLoaiDTSelected = Declare.IdLoaiKhachHang;
        protected int IdKHangSelected = Declare.IdKHMacDinh;
        protected int IdTruongCaSelected = Declare.IdTruongCa;
        protected int IdThuNganSelected = Declare.IdThuNgan;
        protected int IdThoiHanTTSelected = Declare.IdThoiHanThanhToan;
        protected NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
        private int SoLuongHienTai = 0;
        #endregion

        #region Constructor
        public frmBH_ListChungTuBase()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }
        #endregion

        #region Event
        protected virtual void InitLoadForm() { }
        private void frmBH_TimChungTu_Load(object sender, EventArgs e)
        {
            try
            {
                CommonFuns.Instance.LoadNganhHang(lueNganh, nguoiDung, true);
                CommonFuns.Instance.LoadTrungTam(bteTrungTam, nguoiDung);
                LoadAllTrangThai();
                //DateTime curTime = CommonProvider.Instance.GetSysDate();
                dteStart.EditValue = CommonProvider.Instance.GetSysDate();// new DateTime(curTime.Year, curTime.Month, curTime.Day, curTime.Hour, 0, 0);
                dteEnd.EditValue = dteStart.EditValue;// = new DateTime(curTime.Year, curTime.Month, curTime.Day, 0, 0, 0);
                InitLoadForm();
                btnTimkiem_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void frmBH_ListChungTuBase_Activated(object sender, EventArgs e)
        {
            //LoadAllChungTu();
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
#endif
            }
        }

        private void gvListChungTu_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Point pt = gListChungTu.PointToClient(MousePosition);
                GridHitInfo hitInfo = gvListChungTu.CalcHitInfo(pt);
                if (hitInfo.InRow)
                    EditOrder(hitInfo.RowHandle);
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
#endif
            }
        }

        private void frmBH_TimChungTu_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //if (e.KeyCode==Keys.Enter)   
                //{
                //    if (!this.gListChungTu.Focused)
                //    {
                //        SendKeys.Send("{TAB}");
                //        e.Handled = true;
                //        return;
                //    }
                //}
                if (e.KeyCode == Keys.F5 && tsbAdd.Enabled)
                    this.tsbAdd_Click(sender, e);
                else if (e.KeyCode == Keys.F6 && tsbAdd.Enabled)
                    this.tsbEdit_Click(sender, e);
                else if (e.KeyCode == Keys.F8 && tsbDelete.Enabled)
                    this.tsbDelete_Click(sender, e);
                else if (e.KeyCode == Keys.F9 && tsbPrint.Enabled)
                    this.tsbPrint_Click(sender, e);
                else if (e.KeyCode == Keys.F11 && tsbSession.Enabled)
                    this.tsbSession_Click(sender, e);
                else if (e.KeyCode == Keys.F12 && tsbClose.Enabled)
                    this.tsbClose_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvListChungTu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTu = (ChungTuBanHangInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
            if (ChungTu != null)
            {
                setEDFunctions();
                ShowInfors();
            }
        }

        private void tsbSession_Click(object sender, EventArgs e)
        {
            frmThietLapCaLamViec frm = new frmThietLapCaLamViec();//0-mac dinh: reset all trong 1 page, 1-reset trong 1 session (luu vao static), 2-resset all session (luu vao CSDL)
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.IdKhoSelected = frm.KhoSelected.IdKho;
                this.IdTTamSelected = frm.TTamSelected.IdTrungTam;
                this.IdLoaiDTSelected = frm.LoaiDTSelected.IdLoaiDT;
                this.IdKHangSelected = frm.KHangSelected.IdDoiTuong;

                bteTrungTam.Text = frm.TTamSelected.TenTrungTam;
                bteTrungTam.Tag = frm.TTamSelected;

                bteKhoXuat.Text = frm.KhoSelected.TenKho;
                bteKhoXuat.Tag = frm.KhoSelected;

                bteKhachHang.Text = frm.KHangSelected.TenDoiTuong;
                bteKhachHang.Tag = frm.KHangSelected;

                LoadAllChungTu();

                dteStart.ResetText();
                dteEnd.ResetText();
                txtSoPhieu.ResetText();
            }
        }

        private void bteKhachHang_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteKhachHang_ButtonClick(sender, e, bteKhachHang, IdLoaiDTSelected);
        }

        private void bteKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteKhachHang_KeyDown(sender, e, bteKhachHang, IdLoaiDTSelected);
        }

        private void bteKhachHang_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteKhachHang);
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

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            SoLuongHienTai = 0;
            SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
            liChungTu.Clear();
            if (gListChungTu.DataSource == null)
            {
                gListChungTu.DataSource = liChungTu;
            }

            gListChungTu.RefreshDataSource();

            LoadAllChungTu();
        }
        protected virtual bool GetFromAction()
        {
            return false;
        }
        
        protected virtual void AddChungTuInstance() { }

        protected bool IsOnline
        {
            get { return ((NguoiDungInfor)Declare.USER_INFOR).IsOnline; }
        }

        protected bool IsKinhDoanhThiTruong
        {
            get { return ((NguoiDungInfor) Declare.USER_INFOR).IsKinhDoanhThiTruong; }
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            //online duoc phep lam
            while (CommonProvider.Instance.IsKhacTinh())
            {
                if (IsOnline || IsKinhDoanhThiTruong) break;

                MessageBox.Show("Bạn đang ở tỉnh khác, cần thiết lập lại!");

                //thiet lap kho hien tai.
                var frmThietLapCaLamViec = new frmThietLapCaLamViec(2);

                if(frmThietLapCaLamViec.ShowDialog(this) ==DialogResult.Cancel)
                    return;
            }

            AddChungTuInstance();//thêm chứng từ => cập nhật trạng thái form mở

            if (GetFromAction())
                btnTimkiem_Click(sender, e);
        }

        protected virtual void EditChungTuInstance(ChungTuBanHangInfor chungTuInfor) { }

        private void EditOrder(int rowHandle)
        {
            if (rowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(rowHandle);
            if (ct!=null)
            {
                if (!CommonProvider.Instance.Check_Lock_ChungTu(ct.IdChungTu))
                {
                    MessageBox.Show("Chứng từ này đang có người cập nhật. Bạn không thể cập nhật được!");
                    return;
                }
                else
                {
                    if (!CommonProvider.Instance.Lock_Unlock_ChungTu(ct.IdChungTu, 1))//khoa chung tu
                    {
                        MessageBox.Show("Chứng từ này đang có người cập nhật. Bạn không thể cập nhật được!");
                        return;
                    }
                    EditChungTuInstance(ct);
                    if (GetFromAction())
                        btnTimkiem_Click(null, null);
                    CommonProvider.Instance.Lock_Unlock_ChungTu(ct.IdChungTu, 0);//mo chung tu                    
                }
            }            
        }
        private void tsbEdit_Click(object sender, EventArgs e)
        {
            try
            {
                EditOrder(gvListChungTu.FocusedRowHandle);
            }
            catch (ManagedException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
        }

        protected virtual void DeleteChungTuInstance() { }
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            DeleteChungTuInstance();
            if (GetFromAction())
                btnTimkiem_Click(sender, e);
        }

        protected virtual void PrintChungTuInstance() { }
        private void tsbPrint_Click(object sender, EventArgs e)
        {
            PrintChungTuInstance();
        }

        protected virtual void SetListChungTuStatus(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e) { }
        private void gvListChungTu_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            SetListChungTuStatus(sender, e);
        }

        private void cmdExport_Click(object sender, EventArgs e)
        {
            //Common.DevExport2Excel(gvListChungTu);
            Common.Export2ExcelFromDevGrid<ChungTuBanHangInfor>(gvListChungTu, "DanhSachDonHang");
        }
        #endregion

        #region Data
        protected virtual List<TrangThaiBH> GetListTrangThaiDonHang()
        {
            return null;
        }
        private void LoadAllTrangThai()
        {
            List<TrangThaiBH> liDraft = Common.GetListTinhTrangDonHang();
            List<TrangThaiBH> liLoaiDH = Common.GetListLoaiDonHang();
            List<TrangThaiBH> liTrangThaiDH = Common.GetListTrangThaiDonHang();
            //load trang thai cho grid
            repDraft.DataSource = liDraft;
            repLoaiDonHang.DataSource = liLoaiDH;
            repTrangThaiDH.DataSource = liTrangThaiDH;

            //load trang thai draft
            List<TrangThaiBH> liDraft1 = new List<TrangThaiBH>();
            liDraft1.Add(new TrangThaiBH { Id = -1, Name = "Tất cả" });
            liDraft1.AddRange(liDraft);
            lueDraft.Properties.DataSource = liDraft1;
            lueDraft.EditValue = -1;

            List<TrangThaiBH> liLoaiDH1 = new List<TrangThaiBH>();
            liLoaiDH1.Add(new TrangThaiBH { Id = -1, Name = "Tất cả" });
            liLoaiDH1.AddRange(liLoaiDH);
            lueLoaiDH.Properties.DataSource = liLoaiDH1;
            lueLoaiDH.EditValue = -1;

            List<TrangThaiBH> liTrangThaiDH1 = new List<TrangThaiBH>();
            liTrangThaiDH1.Add(new TrangThaiBH { Id = -1, Name = "Tất cả" });
            liTrangThaiDH1.AddRange(GetListTrangThaiDonHang());
            lueTrangThaiDH.Properties.DataSource = liTrangThaiDH1;
            lueTrangThaiDH.EditValue = -1;
        }
        protected virtual List<ChungTuBanHangInfor> LoadAllChungTuInstances(string userName, int idTrungTam, int idKho, int idDoiTuong, DateTime tuNgay, DateTime denNgay, int loaiDH, int trangThaiDH, int draft, string ghiChu, string nganh, int soBatDau, int soKetThuc, int idNhanVien)
        {
            return null;
        }
        private void LoadDuLieu()
        {
            int soBatDau = SoLuongHienTai;
            int soKetThuc = SoLuongTimKiem != -1 ? SoLuongHienTai + SoLuongTimKiem : -1;

            int idTrungTam = CommonFuns.Instance.GetIdTrungTam(bteTrungTam, nguoiDung);
            int idKho = bteKhoXuat.Tag != null
                            ? ((DMKhoInfo) bteKhoXuat.Tag).IdKho
                            : -1;
            int idDoiTuong = bteKhachHang.Tag != null ? ((DMDoiTuongInfo)bteKhachHang.Tag).IdDoiTuong : -1;
            DateTime startDate = Convert.ToDateTime(dteStart.DateTime);
            DateTime endDate = Convert.ToDateTime(dteEnd.DateTime);
            int loaiDH = Common.IntValue(lueLoaiDH.EditValue);
            int trangThaiDH = Common.IntValue(lueTrangThaiDH.EditValue);
            int draft = Common.IntValue(lueDraft.EditValue);
            string ghiChu = txtSoPhieu.Text.Trim();
            string nganh = lueNganh.EditValue != null ? lueNganh.EditValue.ToString() : "";
            string userName = nguoiDung.SupperUser == 1 ? "" : nguoiDung.TenDangNhap;

            int totalDays = (endDate.Date - startDate.Date).Days;

            frmProgress.Instance.MaxValue = totalDays + 1;

            var runningDate = endDate.Date;

            while (runningDate >= startDate.Date)
            {
                liTimKiem = LoadAllChungTuInstances(userName, idTrungTam, idKho, idDoiTuong, runningDate, runningDate, loaiDH,
                                                    trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, nguoiDung.IdNhanVien);

                liChungTu.AddRange(liTimKiem);

                if (InvokeRequired && liTimKiem.Count > 0)
                {
                    Invoke((MethodInvoker) delegate { gListChungTu.RefreshDataSource(); });
                }

                frmProgress.Instance.Value += 1;

                runningDate = runningDate.AddDays(-1);
            }

            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            frmProgress.Instance.IsCompleted = true;
            frmProgress.Instance.Description = "Đã xong";
        }

        private void LoadAllChungTu()
        {
            try
            {
                frmProgress.Instance.Description = Common.MsgProgress(SoLuongTimKiem); 
                frmProgress.Instance.MaxValue = SoLuongTimKiem;
                frmProgress.Instance.Value = 0;
                frmProgress.Instance.Caption = Text;
                frmProgress.Instance.DoWork(LoadDuLieu);
                //LoadDuLieu();

                //gListChungTu.DataSource = null;
                //gListChungTu.DataSource = new BindingList<ChungTuBanHangInfor>(liChungTu); 
                gvListChungTu.ExpandAllGroups();
                //((BindingList<ChungTuBanHangInfor>)gListChungTu.DataSource).ResetBindings();
                ShowSelector();//show selector

                this.grpKetQuaTimKiem.Text = "Tổng số (" + liChungTu.Count + " đơn hàng)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual bool IsShowSelector()
        {
            return false;
        }
        public void ShowSelector()
        {
            if (IsShowSelector())
            {
                selector.View = gvListChungTu;
                selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                selector.CheckMarkColumn.VisibleIndex = 0;
                selector.ClearSelection();
            }
        }
        private void ResetTrungTam()
        {
            bteKhoXuat.ResetText();
            bteKhoXuat.Tag = null;
        }

        protected virtual void setEDFunctions() { }
        private void ShowInfors()
        {
            if (ChungTu == null)
            {
                tslInfor.Text = this.Text;
                tsslTrangThai.Text = "";
            }
            else
            {
                tslInfor.Text = Common.GetEnumInfor((TransactionType) ChungTu.LoaiChungTu);
                tsslTrangThai.Text = Common.GetOrderStatus(ChungTu.TrangThai, ChungTu.Draft);
            }
        }
        #endregion
    }
}