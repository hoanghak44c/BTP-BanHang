using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using QLBanHang.Class;
//using QLBanHang.Class.Objects;
using QLBanHang.Modules.BanHang.Reports;
using QLBH.Common;
using QLBH.Common.Providers;
using QLBH.Core.Data;
using QLBH.Common.Objects;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.BanHang.Bussiness;
using QLBH.Core.Business;
using QLBH.Core.Data;
using QLBH.Core.Infors;
using QLBH.Core.Providers;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBH_LapPhieuChi : DevExpress.XtraEditors.XtraForm
    {
        #region "Khai báo biến"
        private int IdTrungTamSelected = Declare.IdTrungTam;
        private int IdKhoSelected = Declare.IdKho;
        private int IdKHangSelected = Declare.IdKHMacDinh;
        private int IdThoiHanTTSelected = Declare.IdThoiHanThanhToan;
        private NhapTraHangMuaBussiness Business;
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor) Declare.USER_INFOR
                                               : new NguoiDungInfor();

        //luu danh sach hinh thuc thanh toan
        private bool Updating = false;//false: chua sua, tao moi; 1:dang sua, tao moi

        #endregion

        #region "Các phương thức khởi tạo"
        public frmBH_LapPhieuChi()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.Business = new NhapTraHangMuaBussiness();
        }


        public frmBH_LapPhieuChi(NhapHangTraMuaInfor ctu)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.Business = new NhapTraHangMuaBussiness(ctu);
        }

        public void HideMenu()
        {
            toolStrip1.Enabled = false;
            btnTimOrderKH.Enabled = false;
            //btnTimOrderKH.Visible = false;
            Updating = false;
            setEDItems();
        }
        #endregion

        #region "Các phương thức"
        /// <summary>
        /// Khoi tao don hang
        /// </summary>
        /// <returns></returns>
        private void ResetChungTuInfor()
        {
            //thong tin don hang
            //IdPhieuXuat = 0;
            //TrangThaiDonHang = (int) OrderStatus.DON_HANG_BAN_TAI_SHOP;
            txtSoOrderKH.ResetText();
            mstNgayLapPhieu.Value = DateTime.Now;//.ResetText();//.Text = DateTime.Today.ToString("dd/MM/yyyy");
            txtDienThoai.ResetText();
            txtCMND.ResetText();

            txtHoTenKhachHang.ResetText();
            cboGioiTinh.SelectedIndex = -1;
            txtTuoi.ResetText();
            txtMaSoThue.ResetText();
            txtEmail.ResetText();
            txtDiaChi.ResetText();
            LoadLoaiThuChi();

            //thong tin thanh toan
            txtTongTienHang.Text = Common.Double2Str(0);
            txtTongTienThanhToan.Text = Common.Double2Str(0);
            txtTienThucTra.Text = Common.Double2Str(0);
            txtTienConNo.Text = Common.Double2Str(0);
            gHinhThucThanhToan.DataSource = null;
        }

        private void LoadKhachHang()
        {
            try
            {
                DMDoiTuongInfo dmDoiTuong = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(this.IdKHangSelected);
                if (dmDoiTuong != null)
                {
                    bteKhachHang.Text = dmDoiTuong.TenDoiTuong;
                    bteKhachHang.Tag = dmDoiTuong;
                }
            }
            catch (System.Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }


        private void LoadLoaiThuChi()
        {
            try
            {
                DMLoaiThuChiInfor dmLoaiThuChi = DMLoaiThuChiDataProvider.GetListDmThuChiInfoFromOid(IdThoiHanTTSelected);
                if (dmLoaiThuChi != null)
                {
                    bteThoiHanThanhToan.Text = dmLoaiThuChi.Ten;
                    bteThoiHanThanhToan.Tag = dmLoaiThuChi;
                }
            }
            catch (System.Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void LoadKhoXuat()
        {
            try
            {
                DMKhoInfo dmKho = DMKhoDataProvider.GetKhoByIdInfo(this.IdKhoSelected);
                if (dmKho != null)
                {
                    bteKhoXuat.Text = dmKho.TenKho;
                    bteKhoXuat.Tag = dmKho;
                }
            }
            catch (System.Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }


        private void LoadComboBoxData()
        {
            LoadKhoXuat();
            LoadKhachHang();
            LoadLoaiThuChi();
        }
        private void LoadTrungTam()
        {
            DMTrungTamInfor tt = DMTrungTamDataProvider.GetTrungTamByIdInfo(Business.ChungTu.IdTrungTam);
            if (tt != null)
            {
                bteTrungTam.Tag = tt;
                bteTrungTam.Text = tt.TenTrungTam;
                //grThongTin.Text = String.Format("Trung tâm: {0} - {1}", tt.MaTrungTam, tt.TenTrungTam);
            }
        }
        private void LoadChungTuInstance()
        {
            if (Business.ChungTu.IdChungTu!=0)
            {
                LoadChungTuHeader();
                LoadChungTuThanhToan();
            }
            else
            {
                ResetChungTuInfor();
            }
        }
        private void LoadChungTuHeader()
        {
            txtSoOrderKH.Text = Business.ChungTu.SoChungTu;
            try
            {
                mstNgayLapPhieu.Value = Business.ChungTu.NgayLap;
            }
            catch (Exception)
            {
                mstNgayLapPhieu.Value = CommonProvider.Instance.GetSysDate();
            }
            LoadTrungTam();
            txtKyHieu.Text = Business.ChungTu.KyHieu;
            txtSoSerie.Text = Business.ChungTu.SoSeri;
            bteKhoXuat.Tag = DMKhoDataProvider.GetKhoByIdInfo(Business.ChungTu.IdKho);
            bteKhoXuat.Text = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).TenKho : "";
            bteKhachHang.Tag = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(Business.ChungTu.IdDoiTuong);
            bteKhachHang.Text = bteKhachHang.Tag != null ? ((DMDoiTuongInfo)bteKhachHang.Tag).TenDoiTuong : "";
            txtDienThoai.Text = Business.ChungTu.DienThoai;
            txtCMND.Text = Business.ChungTu.SoCMND;

            txtHoTenKhachHang.Text = Business.ChungTu.HoTen;
            cboGioiTinh.SelectedIndex = Business.ChungTu.GioiTinh;
            txtTuoi.Text = Business.ChungTu.DoTuoi.ToString();
            txtMaSoThue.Text = Business.ChungTu.MaSoThue;
            txtEmail.Text = Business.ChungTu.Email;
            txtDiaChi.Text = Business.ChungTu.DiaChiHoaDon;
            txtDiaChiGiaoHang.Text = Business.ChungTu.DiaChiGiaoHang;

            txtTongTienHang.Text = Common.Double2Str(Business.ChungTu.TongTienHang);
            txtTongTienThanhToan.Text = Common.Double2Str(Business.ChungTu.TongTienThanhToan);
            txtTienThucTra.Text = Common.Double2Str(Business.ChungTu.TienThanhToanThuc);
            txtTienConNo.Text = Common.Double2Str(Business.ChungTu.TienConNo);
            bteThoiHanThanhToan.Tag = DMLoaiThuChiDataProvider.GetListDmThuChiInfoFromOid(Business.ChungTu.HinhThucTra);
            bteThoiHanThanhToan.Text = bteThoiHanThanhToan.Tag != null ? ((DMLoaiThuChiInfor)bteThoiHanThanhToan.Tag).Ten : "";
        }
        private void LoadChungTuThanhToan()
        {
            Business.ListChungTuThanhToan =
                ThanhToanDataProvider.Instance.LoadAllThanhToanByCTu(Business.ChungTu.IdChungTu);
            gHinhThucThanhToan.DataSource = new BindingList<ChungTuThanhToanInfor>(Business.ListChungTuThanhToan);
        }
        #endregion


        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            try
            {
                LoadComboBoxData();

                if (Business.ChungTu.IdChungTu > 0)
                {
                    LoadChungTuInstance();
                    if (Business.ChungTu.TienConNo <= 0)
                    {
                        Updating = false;
                        setEDItems();
                        setEDFunctions();
                    }
                    else
                    {
                        //Thiet lap trang thai item
                        tsbEdit_Click(sender, e);                        
                    }
                }
                else
                {
                    ResetChungTuInfor();
                }
            }
            catch (System.Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            } 
        }

        private void frmPhieuXuat_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //if (!this.txtGhiChu.Focused && !this.dgvSanPhamBan.Focused && !this.txtMaVach.Focused && !this.dgvHangKhuyenMai.Focused)
                //{
                //    if (e.KeyCode == Keys.Enter)
                //    {
                //        SendKeys.Send("{TAB}");
                //        e.Handled = true;
                //        return;
                //    }
                //    else if (e.KeyCode == Keys.F2)
                //    {
                //        if (this.WindowState == FormWindowState.Maximized)
                //            this.WindowState = FormWindowState.Normal;
                //        else
                //            this.WindowState = FormWindowState.Maximized;
                //        e.Handled = true;
                //        return;
                //    }
                //}
                if (e.KeyCode == Keys.F6 && tsbEdit.Enabled)
                    this.tsbEdit_Click(sender, e);
                else if (e.KeyCode == Keys.F7 && tsbUpdate.Enabled)
                    this.tsbUpdate_Click(sender, e);
                else if (e.KeyCode == Keys.F9 && tsbPrint.Enabled)
                    this.tsbPrint_Click(sender, e);
                else if (e.KeyCode == Keys.F10 && btnThanhToan.Enabled)
                    this.btnThanhToan_Click(sender, e);
                else if (e.KeyCode == Keys.F12 && tsbClose.Enabled)
                    this.tsbClose_Click(sender, e);
                else if (e.KeyCode == Keys.F4 && btnXoaTT.Enabled)
                    this.btnXoaTT_Click(sender, e);
            }
            catch (System.Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Updating = true;
                setEDItems();
                setEDFunctions();
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi thao tác\n" + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi thao tác", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }  
        }


        private void setEDItems()
        {
            //txtSoOrderKH.Enabled = Updating;
            //mstNgayLapPhieu.Enabled = Updating;
            //txtDienThoai.Enabled = Updating;
            //txtCMND.Enabled = Updating;

            //txtHoTenKhachHang.Enabled = Updating;
            //cboGioiTinh.Enabled = Updating;
            //txtTuoi.Enabled = Updating;
            //txtMaSoThue.Enabled = Updating;
            //txtEmail.Enabled = Updating;
            //txtDiaChi.Enabled = Updating;

            btnXoaTT.Enabled = Updating;
            btnThanhToan.Enabled = Updating;
            btnThanhToanKhac.Enabled = Updating && nguoiDung.SupperUser == 1;
            btnThanhToanKhac.Visible = nguoiDung.SupperUser == 1;
            //cboThoiHanThanhToan.Enabled = Updating;
        }

        private void setEDFunctions()
        {
            tsbEdit.Enabled = !Updating && (Business.ChungTu.IdChungTu > 0);
            tsbUpdate.Enabled = Updating;//cap nhat
            tsbPrint.Enabled = !Updating && (Business.ChungTu.IdChungTu > 0);
        }

        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (UpdateChungTu())
                {
                    MessageBox.Show("Cập nhật phiếu chi thành công!");

                    Updating = false;
                    setEDItems();
                    setEDFunctions();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi thao tác\n" + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi thao tác", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }   
        }

        private bool UpdateChungTu()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (ValidPhieuChi())
                {
                    SaveChungTuInstance();
                    Business.SaveChungTuThuChi();

                    return true;                    
                }
            }
            catch (Exception)
            {
                throw;
            }
            Cursor.Current = Cursors.Default;
            return false;
        }

        private bool ValidPhieuChi()
        {
            if (Common.DoubleValue(txtTienThucTra.Text) > Common.DoubleValue(txtTongTienThanhToan.Text) || Common.DoubleValue(txtTienConNo.Text) < 0)
            {
                MessageBox.Show("Tiền thực trả không thể lớn hơn số tiền cần thanh toán!");
                return false;
            }
            return true;
        }

        private void SaveChungTuInstance()
        {
            //update header
            UpdateChungTuHeader();
            //update thanh toan
            UpdateChungTuThanhToan();
        }

        private void UpdateChungTuHeader()
        {
            Business.ChungTu.TongTienThanhToan = Common.DoubleValue(txtTongTienThanhToan.Text);
            Business.ChungTu.TongTienChietKhau = 0;
            Business.ChungTu.TongTienSauChietKhau = 0;
            Business.ChungTu.TongTienVAT = 0;
            Business.ChungTu.TongTienThanhToan = Common.DoubleValue(txtTongTienThanhToan.Text);
            Business.ChungTu.IdTienTe = Declare.IdTienTe;
            Business.ChungTu.TienThanhToanThuc = Common.DoubleValue(txtTienThucTra.Text);
            Business.ChungTu.TienConNo = Common.DoubleValue(txtTienConNo.Text);
            Business.ChungTu.TongTienChu = Common.ReadNumner_(txtTienThucTra.Text.Trim());
            Business.ChungTu.HinhThucTra = bteThoiHanThanhToan.Tag != null
                                               ? ((DMLoaiThuChiInfor) bteThoiHanThanhToan.Tag).IdThuChi
                                               : 0;
        }

        private void UpdateChungTuThanhToan()
        {
            int count = 0;
            foreach (ChungTuThanhToanInfor tt in Business.ListChungTuThanhToan)
            {
                //if (tt.IdThanhToan == 0 || String.IsNullOrEmpty(tt.SoPhieu))
                //{
                //    tt.SoPhieu = CommonFuns.Instance.GetSoPhieuThuChi(Business.ChungTu.SoChungTu,
                //                                                      Declare.Prefix.PhieuChiTien, count);
                //    count++;
                //}

                //tt.IdThuNgan = Common.IntValue(cboThuNgan.SelectedValue);
                tt.HoTen = txtHoTenKhachHang.Text;
                tt.DiaChi = txtDiaChi.Text;
                tt.DienThoai = txtDienThoai.Text;
                tt.IdTienTe = Declare.IdTienTe;
                tt.TyGia = 1;
                tt.SoTienChu = Common.ReadNumner_(Common.Double2Str(tt.SoTienThanhToan));
                tt.SoChungTuGoc = Business.ChungTu.SoChungTu;

                if (tt.IdThanhToan == 0)
                {
                    tt.NguoiTao = nguoiDung.TenDangNhap;
                    tt.TenMayTao = Declare.TenMay;
                    tt.NguoiSua = nguoiDung.TenDangNhap;
                    tt.TenMaySua = Declare.TenMay;
                }
                else
                {
                    tt.NguoiSua = nguoiDung.TenDangNhap;
                    tt.TenMaySua = Declare.TenMay;
                }
            }
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (UpdateChungTu())
                {
                    foreach (ChungTuThanhToanInfor tt in Business.ListChungTuThanhToan)
                    {
                        if (tt.LoaiThanhToan != -1) //khong phai voucher thi in ra
                        {
                            rpt_PhieuChiTien rp = new rpt_PhieuChiTien(tt);
                            rp.ShowPreview();
                        }
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.ToString());
            }            
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (System.Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void btnTimOrderKH_Click(object sender, EventArgs e)
        {
            try
            {
                if (Updating)
                {
                    if (MessageBox.Show("Dữ liệu đang cập nhật, bạn có muốn hủy bỏ không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;
                }
                NhapHangTraMuaInfor ctu = NhapTraHangMuaDataProvider.Instance.SearchChungTuBanHangByPN(txtSoOrderKH.Text.Trim(), (int)TransactionType.NHAPTRAHANGMUA);
                if (ctu != null)
                {
                    Business = new NhapTraHangMuaBussiness(ctu);
                    LoadChungTuInstance();

                    Updating = false;
                    setEDItems();
                    setEDFunctions();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy chứng từ thích hợp!");
                    txtSoOrderKH.Text = Business.ChungTu.SoChungTu;
                }
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi thao tác\n" + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi thao tác", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }
        
        private void frmPhieuXuatHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            //((IMain)(this.ParentForm)).ShowTTHoaDon("");
            //frmBH_TimChungTu.SQLSearch = "";
        }

 
        private void txtSoOrderKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnTimOrderKH_Click(sender, e);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (Business.ChungTu.IdChungTu > 0)
            {
                if (Business.ChungTu.LoaiChungTu == (int)TransactionType.DON_HANG_NHAP_LAI)
                {
                    LapPhieuChiKhac();//nhap lai ko co goc
                }
                else
                {
                    LapPhieuChiNhapLai();//nhap lai co goc
                }
            }
        }

        private void LapPhieuChiNhapLai()
        {
            frmThanhToanNhapLai frm = new frmThanhToanNhapLai(Business);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //tham thanh toan
                foreach (ChungTuThanhToanInfor tt in frm.lstThanhToanSelected)
                {
                    ((BindingList<ChungTuThanhToanInfor>)gHinhThucThanhToan.DataSource).Add(tt);
                }
                //cap nhat tien thanh toan
                UpdateTienThanhToan();
            }            
        }
        private void LapPhieuChiKhac()
        {
            int IdTrungTamThu = (nguoiDung.IdTrungTamHachToan == 0 ? IdTrungTamSelected : nguoiDung.IdTrungTamHachToan);

            frmBH_ChonHinhThucTT frm = new frmBH_ChonHinhThucTT(Business.ListChungTuThanhToan,
                                                                Business.ChungTu.SoChungTu,
                                                                Common.DoubleValue(txtTongTienThanhToan.Text),
                                                                Common.DoubleValue(txtTienThucTra.Text),
                                                                Declare.KyHieuTienTe,
                                                                nguoiDung.IdNhanVien,
                                                                IdTrungTamThu, (int)LoaiPhieuThanhToan.PHIEU_CHI,
                                                                (int)LoaiGiaoDichThanhToan.GIAODICH_BANHANG);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ((BindingList<ChungTuThanhToanInfor>)gHinhThucThanhToan.DataSource).Add(frm.ThanhToan);
                txtTienThucTra.Text = Common.Double2Str(frm.TienDaThanhToan);
                txtTienConNo.Text = Common.Double2Str(frm.TongTienThanhToan - frm.TienDaThanhToan);
            }

            UpdateTienThanhToan();
        }

        private void UpdateTienThanhToan()
        {
            double tienTraKhach = 0;
            foreach (ChungTuThanhToanInfor tt in (BindingList<ChungTuThanhToanInfor>)gHinhThucThanhToan.DataSource)
            {
                if (tt.LoaiThanhToan != -1 && !tt.HinhThucThanhToan.ToUpper().Equals("VOUCHER"))
                    tienTraKhach += tt.SoTienThanhToan;
            }
            double tienConNo = Common.DoubleValue(txtTongTienThanhToan.Text) - tienTraKhach;
            txtTienThucTra.Text = Common.Double2Str(tienTraKhach);
            txtTienConNo.Text = Common.Double2Str(tienConNo);
        }
        private void btnXoaTT_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvHinhThucThanhToan.FocusedRowHandle < 0) return;
                if (MessageBox.Show("Bạn có chắc chắn xóa các mục này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (int i in gvHinhThucThanhToan.GetSelectedRows())
                    {
                        ChungTuThanhToanInfor t = (ChungTuThanhToanInfor)gvHinhThucThanhToan.GetRow(i);
                        if (t != null && t.IdThanhToan > 0 && nguoiDung.SupperUser != 1 && Business.ChungTu.Draft == 0)
                        {
                            MessageBox.Show("Phiếu chi này đã được tạo. Không thể xóa được!");
                            return;
                        }
                    }
                    gvHinhThucThanhToan.DeleteSelectedRows();
                    UpdateTienThanhToan();
                }
            }
            catch { }
        }

        private void btnThanhToanKhac_Click(object sender, EventArgs e)
        {
            if (Business.ChungTu.IdChungTu > 0)
            {
                LapPhieuChiKhac();//nhap lai ko co goc
            }
        }

    }
}