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
using QLBH.Core.Form;
using QLBH.Core.Exceptions;
using QLBH.Core.Providers;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBH_TinhTrangGiaoNhan : DevExpress.XtraEditors.XtraForm
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
        private bool SuaDonHangGiaoNhan = false;

        #endregion

        #region Constructor
        public frmBH_TinhTrangGiaoNhan()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            Common.SetEDControl(false, false, tsbAddKM, tsbAdd);
            tsslChuaDuyet.Text = "Từ chối đơn hàng giao nhận";
            tsslTuChoi.Text = "Chưa xác nhận phân công giao nhận";
        }
        public frmBH_TinhTrangGiaoNhan(bool suaDonHangGiaoNhan)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            Common.SetEDControl(false, false, tsbAddKM, tsbAdd);
            this.SuaDonHangGiaoNhan = suaDonHangGiaoNhan;
            tsslChuaDuyet.Text = "Từ chối đơn hàng giao nhận";
            tsslTuChoi.Text = "Chưa xác nhận phân công giao nhận";
        }
        #endregion

        #region Event

        private void frmBH_TimChungTu_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAllTrangThai();
                CommonFuns.Instance.LoadComboBoxPages(cboPage);
                CommonFuns.Instance.LoadNganhHang(lueNganh, nguoiDung, true);
                CommonFuns.Instance.LoadTrungTam(bteTrungTam, nguoiDung);
                DateTime curTime = CommonProvider.Instance.GetSysDate();
                dteStart.EditValue = new DateTime(curTime.Year, curTime.Month, curTime.Day, 0, 0, 0); ;
                dteEnd.EditValue = new DateTime(curTime.Year, curTime.Month, curTime.Day, curTime.Hour + 1, 0, 0);
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
                if (e.KeyCode == Keys.F3 && tsbAddKM.Enabled)
                    this.tsbAddKM_Click(sender, e);
                else if (e.KeyCode == Keys.F5 && tsbAdd.Enabled)
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
                txtGhiChu.ResetText();
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
            liChungTu = new List<ChungTuBanHangInfor>();

            LoadAllChungTu();
        }

        private void tsbAddKM_Click(object sender, EventArgs e)
        {
            //LoadAllChungTu();
        }
        private bool GetFromAction()
        {
            return Common.GetFormStatus("frmBH_LapDonHangGiaoNhan");
        }
        protected virtual void AddChungTuInstance() { }
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            AddChungTuInstance();
            if (GetFromAction())
                btnTimkiem_Click(sender, e);
        }

        protected void EditChungTuInstance(ChungTuBanHangInfor ct)
        {
            List<ChungTuBanHangInfor> liPCGN = new List<ChungTuBanHangInfor>();
            if (selector.selection.Count > 0)
            {
                foreach (ChungTuBanHangInfor tt in selector.selection)
                {
                    if (Declare.GiaoNhanCungKhachHang && liPCGN.Exists(delegate(ChungTuBanHangInfor h)
                    {
                        return !tt.HoTen.Equals(h.HoTen) || !tt.DiaChiGiaoHang.Equals(h.DiaChiGiaoHang);
                    }))
                    {
                        MessageBox.Show("Hệ thống chỉ cho phép phân công cho các đơn hàng của cùng khách hàng");
                        return;
                    }
                    else
                    {
                        liPCGN.Add(tt);
                    }
                }
            }
            else
                liPCGN.Add(ct);
            Common.SetFormStatus("frmBH_LapDonHangGiaoNhan", false);
            frmBH_LapDonHangGiaoNhan frm = new frmBH_LapDonHangGiaoNhan(liPCGN, true);
            frm.ShowDialog();
        }
        private void EditOrder(int rowHandle)
        {
            if (rowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(rowHandle);
            if (ct != null)
            {
                if (!CommonProvider.Instance.Check_Lock_ChungTu(ct.IdChungTu))
                {
                    MessageBox.Show("Chứng từ này đang có người cập nhật. Bạn không thể cập nhật được!");
                    return;
                }
                else
                {
                    if(!CommonProvider.Instance.Lock_Unlock_ChungTu(ct.IdChungTu, 1))//khoa chung tu
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
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            //LoadAllChungTu();
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
            CommonFuns.Instance.InPhieuGiaoNhan(ct);
        }

        private void gvListChungTu_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(e.RowHandle);
            if (ct != null)
            {
                if (e.Column.FieldName.Equals("TrangThai"))
                {
                    if (ct.TrangThai == (int)OrderStatus.REJECT_DON_HANG_GIAO_NHAN)
                    {
                        e.Appearance.BackColor = tsslChuaDuyetClr.BackColor;
                        e.Appearance.ForeColor = tsslChuaDuyetClr.ForeColor;
                    }
                    else if (ct.Draft == 1 && ct.TrangThai == (int)OrderStatus.PHAN_CONG_GIAO_NHAN)
                    {
                        e.Appearance.BackColor = tsslTuChoiClr.BackColor;
                        e.Appearance.ForeColor = tsslTuChoiClr.ForeColor;
                    }
                    else if (ct.TrangThai == (int)OrderStatus.HUY_DON_HANG)
                    {
                        e.Appearance.BackColor = tsslHuyClr.BackColor;
                        e.Appearance.ForeColor = tsslHuyClr.ForeColor;
                    }
                }

                if (e.Column.FieldName.Equals("GiaoNhan"))
                {
                    DateTime now = CommonProvider.Instance.GetSysDate();
                    if (ct.ThoiGianGiaoDen < now)
                    {
                        e.Appearance.BackColor = tsslQuaHanGiao.BackColor;
                        e.Appearance.ForeColor = tsslQuaHanGiao.ForeColor;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //LoadAllChungTu();
            //btnTimkiem_Click(sender, e);
        }

        private void cmdExport_Click(object sender, EventArgs e)
        {
            //Common.DevExport2Excel(gvListChungTu);
            Common.Export2ExcelFromDevGrid<ChungTuBanHangInfor>(gvListChungTu, "DanhSachDonHang");
        }
        #endregion

        #region Data

        private void LoadAllTrangThai()
        {
            List<TrangThaiBH> liDraft = Common.GetListTinhTrangDonHang();
            List<TrangThaiBH> liLoaiDH = Common.GetListLoaiDonHang();
            List<TrangThaiBH> liTrangThaiDH = Common.GetListTrangThaiDonHang();
            List<TrangThaiBH> liGiaoNhan = Common.GetListLoaiGiaoVan();
            //load trang thai cho grid
            repDraft.DataSource = liDraft;
            repLoaiDonHang.DataSource = liLoaiDH;
            repTrangThaiDH.DataSource = liTrangThaiDH;
            repGiaoNhan.DataSource = liGiaoNhan;

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
            liTrangThaiDH1.AddRange(Common.GetListTrangThaiDonHang(LoaiGiaoDichBanHang.PHANCONG_GIAONHAN));
            lueTrangThaiDH.Properties.DataSource = liTrangThaiDH1;
            lueTrangThaiDH.EditValue = -1;
        }

        private void LoadDuLieu()
        {
            int soBatDau = SoLuongHienTai;
            int soKetThuc = SoLuongTimKiem != -1 ? SoLuongHienTai + SoLuongTimKiem : -1;

            int idTrungTam = CommonFuns.Instance.GetIdTrungTam(bteTrungTam, nguoiDung);
            int idKho = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : -1;
            int idDoiTuong = bteKhachHang.Tag != null ? ((DMDoiTuongInfo)bteKhachHang.Tag).IdDoiTuong : -1;
            DateTime startDate = Convert.ToDateTime(dteStart.EditValue);
            DateTime endDate = Convert.ToDateTime(dteEnd.EditValue);
            int loaiDH = Common.IntValue(lueLoaiDH.EditValue);
            int trangThaiDH = Common.IntValue(lueTrangThaiDH.EditValue);
            int draft = Common.IntValue(lueDraft.EditValue);
            string ghiChu = txtGhiChu.Text.Trim();
            string nganh = lueNganh.EditValue != null ? lueNganh.EditValue.ToString() : "";
            string userName = nguoiDung.SupperUser == 1 ? "" : nguoiDung.TenDangNhap;

            if (SuaDonHangGiaoNhan)
                liTimKiem = BanHangDataProvider.Instance.LoadAllChungTuTTPhanCongGiaoNhanS(userName, idTrungTam, idKho, idDoiTuong, startDate, endDate, loaiDH,
                                                    trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, nguoiDung.IdNhanVien);
            else
                liTimKiem = BanHangDataProvider.Instance.LoadAllChungTuTTPhanCongGiaoNhan(userName, idTrungTam, idKho, idDoiTuong, startDate, endDate, loaiDH,
                                                    trangThaiDH, draft, ghiChu, nganh, soBatDau, soKetThuc, nguoiDung.IdNhanVien);

            if (soKetThuc == -1)
                liChungTu.Clear();

            liChungTu.AddRange(liTimKiem);

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
                frmProgress.Instance.DoWork(LoadDuLieu);
                //LoadDuLieu();

                gListChungTu.DataSource = null;
                gListChungTu.DataSource = new BindingList<ChungTuBanHangInfor>(liChungTu); 
                gvListChungTu.ExpandAllGroups();
                ((BindingList<ChungTuBanHangInfor>)gListChungTu.DataSource).ResetBindings();                
                ShowSelector();//show selector

                this.grpKetQuaTimKiem.Text = "Tổng số (" + liChungTu.Count + " đơn hàng)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShowSelector()
        {
            selector.View = gvListChungTu;
            selector.CheckMarkColumn.Fixed = FixedStyle.Left;
            selector.CheckMarkColumn.VisibleIndex = 0;
        }

        private void ResetTrungTam()
        {
            bteKhoXuat.ResetText();
            bteKhoXuat.Tag = null;
        }


        protected void setEDFunctions()
        {
            tsbEdit.Enabled = (ChungTu.IdChungTu > 0);/* && (Common.Int2Bool(ChungTu.Draft) &&
                              (ChungTu.TrangThai != (int)OrderStatus.PHAN_CONG_GIAO_NHAN) ||
                              ChungTu.LoaiChungTu == (int)TransactionType.DON_HANG_ONLINE &&
                              (ChungTu.TrangThai == (int)OrderStatus.XAC_NHAN_DON_HANG_ONLINE) ||
                              ChungTu.LoaiChungTu == (int)TransactionType.DON_HANG_DAT_TRUOC &&
                              (ChungTu.TrangThai == (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC));*/
            tsbDelete.Enabled = ChungTu.IdChungTu > 0;// && Common.Int2Bool(ChungTu.Draft);//xoa, huy don hang online, dat truoc
        }

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

        private void btnNext_Click(object sender, EventArgs e)
        {
            SoLuongHienTai = liChungTu.Count;
            SoLuongTimKiem = Common.IntValue(cboPage.SelectedItem);
            if (SoLuongTimKiem == 0)
                SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
            if (cboPage.SelectedItem.Equals("Tất cả"))
            {
                if (MessageBox.Show(Declare.msgLoadDataWrn, "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SoLuongTimKiem = -1;
                }
                else
                {
                    return;
                }
            } 

            LoadAllChungTu();
        }

        private void btnChiTietCT_Click(object sender, EventArgs e)
        {
            if (gvListChungTu.FocusedRowHandle < 0) return;
            ChungTuBanHangInfor ct = (ChungTuBanHangInfor)gvListChungTu.GetRow(gvListChungTu.FocusedRowHandle);
            if (ct != null)
            {
                frmBH_ViewDonHangBan frm = new frmBH_ViewDonHangBan(ct);
                frm.ShowDialog();
            }
        }

        private void tsbXacNhanGNhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (selector.selection != null && selector.selection.Count == 0) return;
                if (MessageBox.Show("Bạn có đồng ý xác nhận trạng thái các đơn hàng này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    frmBH_TinhTrangGiaoNhan_AddNote frm = new frmBH_TinhTrangGiaoNhan_AddNote();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        DateTime ngayHoanThanh = CommonProvider.Instance.GetSysDate();

                        foreach (ChungTuBanHangInfor ctu in selector.selection)
                        {
                            UpdateTinhTrangGiaoNhan(ctu, frm.TrangThaiGiaoNhan, frm.Comment, ngayHoanThanh);
                        }

                        MessageBox.Show("Cập nhật tình trạng giao nhận thành công!");
                        btnTimkiem_Click(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                EventLogProvider.Instance.WriteLog(ex.ToString()
                                    + "\nUser: " + nguoiDung.TenDangNhap
                                    + "\nMay: " + Declare.TenMay,
                                    this.Name);
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void UpdateTinhTrangGiaoNhan(ChungTuBanHangInfor ctu, int trangThai, string ghiChu, DateTime ngayHoanThanh)
        {
            ChungTuGiaoNhanInfor giaoNhan = GiaoNhanDataProvider.Instance.GetChungTuGiaoNhanGetByCT(ctu.IdChungTu);
            if (giaoNhan != null)
            {
                giaoNhan.TinhTrang = trangThai;
                giaoNhan.NgayHoanThanh = ngayHoanThanh;
                giaoNhan.GhiChu = ghiChu;
                GiaoNhanDataProvider.Instance.UpdateTinhTrangGiaoNhan(giaoNhan);
            }           
        }

    }
}