using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using QLBanHang.Class;
//using QLBanHang.Class.Objects;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;
using QLBH.Common.Providers;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBH_ChonHinhThucTT : DevExpress.XtraEditors.XtraForm
    {
        public ChungTuThanhToanInfor ThanhToan = new ChungTuThanhToanInfor();
        private List<ChungTuThanhToanInfor> LstThanhToan = new List<ChungTuThanhToanInfor>();
        private string SoChungTu;

        public double TongTienThanhToan = 0;
        public double TienDaThanhToan = 0;

        private List<DMThanhToanInfor> liThanhToan = new List<DMThanhToanInfor>();
        private int IdKho;
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();

        public frmBH_ChonHinhThucTT()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }
        public frmBH_ChonHinhThucTT(List<ChungTuThanhToanInfor> lstThanhToan, string soChungTu, double tongTienThanhToan, double tienDaTra, string tienTe, int idThuNgan, int idTrungTam, int loaiPhieu, int loaiGDich)
        {
            InitializeComponent();
            Common.LoadStyle(this);

            TongTienThanhToan = tongTienThanhToan;
            TienDaThanhToan = tienDaTra;
            LstThanhToan = lstThanhToan;
            SoChungTu = soChungTu;

            ThanhToan.LoaiPhieu = loaiPhieu;
            ThanhToan.LoaiGiaoDich = loaiGDich;
            ThanhToan.IdThuNgan = idThuNgan;
            ThanhToan.IdTrungTamThu = (nguoiDung.IdTrungTamHachToan == 0 ? idTrungTam : nguoiDung.IdTrungTamHachToan);
            lblTienTe.Text = "Đơn vị tính: (" + tienTe + ")";
        }

        public frmBH_ChonHinhThucTT(ChungTuThanhToanInfor tt, double tongTienThanhToan, double tienDaTra, string tienTe)
        {
            InitializeComponent();
            Common.LoadStyle(this);

            ThanhToan = tt;

            TongTienThanhToan = tongTienThanhToan;
            TienDaThanhToan = tienDaTra - tt.SoTienThanhToan;

            lblTienTe.Text = "Đơn vị tính: (" + tienTe + ")";
        }

        private void frmPhieuXuat_TraTienThua_Load(object sender, EventArgs e)
        {
            LoadDMHinhThucThanhToan();
            LoadPhieuThu();
        }

        private string GenSoPhieu()
        {
            int count = 0;
            string soPhieu;
            while (true)
            {
                if (ThanhToan.LoaiPhieu == (int)LoaiPhieuThanhToan.PHIEU_THU)
                    soPhieu = CommonFuns.Instance.GetSoPhieuThuChi(SoChungTu, Declare.Prefix.PhieuThanhToan, count);
                else
                    soPhieu = CommonFuns.Instance.GetSoPhieuThuChi(SoChungTu, Declare.Prefix.PhieuChiTien, count);

                if (!LstThanhToan.Exists(delegate(ChungTuThanhToanInfor match) { return match.SoPhieu.Equals(soPhieu); }))
                {
                    if (!ThanhToanDataProvider.Instance.ExistSoPhieuThanhToan(soPhieu))
                        break;
                }
                    
                count++;
            }
            return soPhieu;
        }
        private void LoadTrungTam()
        {
            DMTrungTamInfor info = DMTrungTamDataProvider.GetTrungTamByIdInfo(ThanhToan.IdTrungTamThu);
            if (info != null)
            {
                bteTrungTam.Text = info.TenTrungTam;
                bteTrungTam.Tag = info;
            }            
        }
        private void LoadPhieuThu()
        {
            if (ThanhToan.IdThanhToan > 0 || !String.IsNullOrEmpty(ThanhToan.SoPhieu))
            {
                txtSoPhieu.Text = ThanhToan.SoPhieu;
                dtNgayLap.Value = ThanhToan.NgayLap;
                cboHinhThucTT.SelectedValue = ThanhToan.IdHinhThucThanhToan;
                LoadTaiKhoanQuy(-1);
                LoadNganHang(ThanhToan.IdNganHangThanhToan);
                LoadNganHangPH(ThanhToan.IdNganHangPhatHanhThe);                
            }
            else
            {
                txtSoPhieu.Text = String.IsNullOrEmpty(ThanhToan.SoPhieu) ? GenSoPhieu() : ThanhToan.SoPhieu;
                dtNgayLap.Value = CommonProvider.Instance.GetSysDate();
                if (liThanhToan.Count > 0)
                {
                    cboHinhThucTT.SelectedIndex = 0;
                    cboHinhThucTT_SelectedIndexChanged(null, null);
                }
            }
            dtNgayLap.Enabled = (nguoiDung.SupperUser == 1 ? true : false);
            bteTrungTam.Enabled = (nguoiDung.SupperUser == 1 ? true : false);

            LoadTrungTam();
            LoadThuNgan();
            LoadThoiHanThanhToan();            

            txtTongTienThanhToan.Text = Common.Double2Str(TongTienThanhToan);
            txtTienDaTra.Text = Common.Double2Str(TienDaThanhToan);
            txtTienPhaiTra.Text = Common.Double2Str(TongTienThanhToan - TienDaThanhToan);
            txtSoTienTT.Text = Common.Double2Str(ThanhToan.SoTienThanhToan);
            
            txtSoTaiKhoan.Text = ThanhToan.SoTaiKhoan;
            txtChuTaiKhoan.Text = ThanhToan.ChuTaiKhoan;

            txtMaThe.Text = ThanhToan.MaThe;
            txtDuoiThe.Text = ThanhToan.DuoiThe;

            txtSoTienTT.Focus();
            txtSoTienTT.SelectAll();
        }

        private void LoadThuNgan()
        {
            try
            {
                DMNhanVienInfo nv = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(ThanhToan.IdThuNgan);
                if (nv != null)
                {
                    bteThuNgan.Text = nv.HoTen;
                    bteThuNgan.Tag = nv;
                }
                this.bteThuNgan.Enabled = ThanhToan.IdThuNgan >= 0 ? true : false;
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

        private void LoadTaiKhoanQuy(int idTrungTamThu)
        {
            try
            {
                DMTaiKhoanQuyInfo tkQuy;

                if (idTrungTamThu > 0)
                {
                    tkQuy =
                        DMTaiKhoanQuyDataProvider.Instance.GetTaiKhoanQuyTMByTrungTam(idTrungTamThu);
                }
                else
                {
                    tkQuy =
                        DMTaiKhoanQuyDataProvider.Instance.GetTaiKhoanQuyByText(ThanhToan.TaiKhoanQuy);
                }

                if (tkQuy != null)
                {
                    bteTaiKhoanQuy.Tag = tkQuy;
                    bteTaiKhoanQuy.Text = tkQuy.TaiKhoanQuy;
                    LoadNganHang(tkQuy.IdNganHang);
                }
                else
                {
                    bteTaiKhoanQuy.Tag = null;
                    bteTaiKhoanQuy.Text = "";

                    bteNganHangTT.Tag = null;
                    bteNganHangTT.Text = ""; 
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

        private void LoadDMHinhThucThanhToan()
        {
            liThanhToan = DMThanhToanDataProvider.GetListDMThanhToanInfo();
            cboHinhThucTT.DataSource = liThanhToan;
            cboHinhThucTT.DisplayMember = "Ten";
            cboHinhThucTT.ValueMember = "IdThanhToan";
        }

        //private void LoadNganHang()
        //{
        //    liNganHangTT = DMNganHangDataProvider.Instance.GetListNganHangInfors();
        //    cboNganHangTT.DataSource = liNganHangTT;
        //    cboNganHangTT.DisplayMember = "TenNganHang";
        //    cboNganHangTT.ValueMember = "IdNganHang";

        //    DMNganHangInfor[] t = new DMNganHangInfor[liNganHangTT.Count];
        //    liNganHangTT.CopyTo(t);
        //    liNganHangPH = new List<DMNganHangInfor>(t);
        //    //liNganHangPH = DMNganHangDataProvider.Instance.GetListNganHangInfors();
        //    cboNganHangPH.DataSource = liNganHangPH;
        //    cboNganHangPH.DisplayMember = "TenNganHang";
        //    cboNganHangPH.ValueMember = "IdNganHang";
        //}

        //private void LoadTaiKhoanQuy()
        //{
        //    liTaiKhoanQuy = DMTaiKhoanQuyDataProvider.Instance.GetListTaiKhoanQuyByTrungTam(-1);
        //    cboTaiKhoanQuy.DataSource = liTaiKhoanQuy;
        //    cboTaiKhoanQuy.DisplayMember = "TaiKhoanQuy";
        //    cboTaiKhoanQuy.ValueMember = "TaiKhoanQuy";
        //}

        private void LoadThoiHanThanhToan()
        {
            int idThoiHanTT = ThanhToan.IdThoiHanThanhToan == 0
                                  ? Declare.IdThoiHanThanhToan
                                  : ThanhToan.IdThoiHanThanhToan;
            DMLoaiThuChiInfor dmLoaiThuChi = DMLoaiThuChiDataProvider.GetListDmThuChiInfoFromOid(idThoiHanTT);
            if (dmLoaiThuChi != null)
            {
                bteThoiHanThanhToan.Text = dmLoaiThuChi.Ten;
                bteThoiHanThanhToan.Tag = dmLoaiThuChi;
            }
        }

        private void txtTienThucTra_TextChanged(object sender, EventArgs e)
        {
            int loaiTT = liThanhToan[cboHinhThucTT.SelectedIndex].LoaiThanhToan;
            if (loaiTT != -1)//khac voucher => tinh tien
            {
                double tienThanhToan = Common.DoubleValue(txtSoTienTT.Text);
                double tienDaTra = TienDaThanhToan + tienThanhToan;
                double tienConNo = TongTienThanhToan - tienDaTra;
                txtTienDaTra.Text = Common.Double2Str(tienDaTra);
                txtTienPhaiTra.Text = Common.Double2Str(tienConNo);
                txtTienTraLai_Chu.Text = Common.ReadNumner_(txtSoTienTT.Text);
                //txtSoTienTT.Text = Common.Double2Str(Common.DoubleValue(txtSoTienTT.Text.Trim()));                 
            }
            else
            {
                double tienThanhToan = Common.DoubleValue(0);
                double tienDaTra = TienDaThanhToan + tienThanhToan;
                double tienConNo = TongTienThanhToan - tienDaTra;
                txtTienDaTra.Text = Common.Double2Str(tienDaTra);
                txtTienPhaiTra.Text = Common.Double2Str(tienConNo);
                txtTienTraLai_Chu.Text = Common.ReadNumner_(txtSoTienTT.Text);                
            }
        }
        private void txtTienThucTra_LostFocus(object sender, EventArgs e)
        {
            try
            {
                txtSoTienTT.Text = Common.Double2Str(Common.DoubleValue(txtSoTienTT.Text.Trim()));
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Lỗi ngoại lệ:" + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtTienThucTra_Enter(object sender, EventArgs e)
        {
            this.txtSoTienTT.Focus();
            this.txtSoTienTT.SelectAll();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidData())
                {
                    ThanhToan.SoPhieu = txtSoPhieu.Text.Trim();
                    ThanhToan.IdHinhThucThanhToan = Common.IntValue(cboHinhThucTT.SelectedValue);
                    ThanhToan.HinhThucThanhToan = liThanhToan[cboHinhThucTT.SelectedIndex].Ten;
                    ThanhToan.IdThoiHanThanhToan = ((DMLoaiThuChiInfor)bteThoiHanThanhToan.Tag).IdThuChi;
                    ThanhToan.ThoiHanThanhToan = ((DMLoaiThuChiInfor)bteThoiHanThanhToan.Tag).Ten;
                    int loaiTT = liThanhToan[cboHinhThucTT.SelectedIndex].LoaiThanhToan;
                    if (bteNganHangTT.Tag != null)
                    {
                        ThanhToan.IdNganHangThanhToan = (loaiTT != 1 && loaiTT != -1) ? ((DMNganHangInfor)bteNganHangTT.Tag).IdNganHang : 0;
                        ThanhToan.NganHangThanhToan = (loaiTT != 1 && loaiTT != -1) ? ((DMNganHangInfor)bteNganHangTT.Tag).TenNganHang : "";                        
                    }
                    if (bteNganHangPH.Tag != null)
                    {
                        ThanhToan.IdNganHangPhatHanhThe = (loaiTT != 1 && loaiTT != -1) ? ((DMNganHangInfor)bteNganHangPH.Tag).IdNganHang : 0;
                        ThanhToan.NganHangPhatHanhThe = (loaiTT != 1 && loaiTT != -1) ? ((DMNganHangInfor)bteNganHangPH.Tag).TenNganHang : "";                        
                    }
                    ThanhToan.SoTaiKhoan = (loaiTT != 1 && loaiTT != -1) ? txtSoTaiKhoan.Text : "";
                    ThanhToan.ChuTaiKhoan = (loaiTT != 1 && loaiTT != -1) ? txtChuTaiKhoan.Text : "";
                    ThanhToan.MaThe = (loaiTT != 1 && loaiTT != -1) ? txtMaThe.Text : "";
                    ThanhToan.DuoiThe = (loaiTT != 1 && loaiTT != -1) ? txtDuoiThe.Text : "";
                    ThanhToan.SoTienThanhToan = Common.DoubleValue(txtSoTienTT.Text);
                    ThanhToan.NgayLap = dtNgayLap.Value;
                    ThanhToan.IdThuNgan = bteThuNgan.Tag != null ? ((DMNhanVienInfo)bteThuNgan.Tag).IdNhanVien : 0;
                    ThanhToan.TenThuNgan = bteThuNgan.Tag != null ? ((DMNhanVienInfo)bteThuNgan.Tag).HoTen : "";
                    ThanhToan.NoiDungThanhToan = txtGhiChu.Text;
                    ThanhToan.TaiKhoanQuy = bteTaiKhoanQuy.Tag != null ? ((DMTaiKhoanQuyInfo)bteTaiKhoanQuy.Tag).TaiKhoanQuy : "";
                    ThanhToan.IdTrungTamThu = bteTrungTam.Tag != null ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam : nguoiDung.IdTrungTamHachToan;
                    ThanhToan.LoaiThanhToan = loaiTT;

                    TienDaThanhToan += loaiTT != -1 ? Common.DoubleValue(txtSoTienTT.Text) : 0;
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thông tin thanh toán không hợp lệ. Xin mời nhập lại!");
            }
        }

        private bool ValidData()
        {
            if (bteTrungTam.Tag == null)
            {
                MessageBox.Show("Trung tâm thu tiền phải chọn");
                bteTaiKhoanQuy.Focus();
                return false;
            }
            if (bteTaiKhoanQuy.Tag == null)
            {
                MessageBox.Show("Tài khoản Quỹ phải chọn");
                bteTaiKhoanQuy.Focus();
                return false;
            }
            if (cboHinhThucTT.SelectedIndex < 0 || cboHinhThucTT.SelectedValue == null ||
                String.IsNullOrEmpty(cboHinhThucTT.Text) ||
                String.IsNullOrEmpty(liThanhToan[cboHinhThucTT.SelectedIndex].Ten))
            {
                MessageBox.Show("Chọn hình thức thanh toán");
                cboHinhThucTT.Focus();
                return false;
            }
            if (bteThoiHanThanhToan.Tag == null)
            {
                MessageBox.Show("Chọn thời hạn thanh toán");
                bteThoiHanThanhToan.Focus();
                return false;
            }
            if (txtSoTienTT.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nhập số tiền thanh toán");
                txtSoTienTT.Focus();
                txtSoTienTT.SelectAll();
                return false;
            }
            if (Common.DoubleValue(txtSoTienTT.Text) <= 0)
            {
                MessageBox.Show("Số tiền thanh toán không hợp lệ");
                txtSoTienTT.Focus();
                txtSoTienTT.SelectAll();
                return false;                
            }

            int loaiTT = liThanhToan[cboHinhThucTT.SelectedIndex].LoaiThanhToan;

            if (loaiTT !=-1 && Common.DoubleValue(txtSoTienTT.Text) + TienDaThanhToan > TongTienThanhToan)
            {
                MessageBox.Show("Số tiền thanh toán không được vượt quá số tiền phải trả");
                txtSoTienTT.Focus();
                txtSoTienTT.SelectAll();
                return false;
            }

            if (loaiTT==2 && txtSoTaiKhoan.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nhập số tài khoản");
                txtSoTaiKhoan.Focus();
                txtSoTaiKhoan.SelectAll();
                return false;
            }
            if (loaiTT != 1 && loaiTT != -1 && bteNganHangTT.Tag == null)
            {
                MessageBox.Show("Chọn ngân hàng thanh toán");
                bteNganHangTT.Focus();
                return false;
            }
            if (loaiTT == 3 && bteNganHangPH.Tag == null)
            {
                MessageBox.Show("Chọn ngân hàng phát hành thẻ");
                bteNganHangPH.Focus();
                return false;
            }
            if (loaiTT == 3 && txtMaThe.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nhập mã thẻ thanh toán");
                txtMaThe.Focus();
                txtMaThe.SelectAll();
                return false;
            }
            if (loaiTT == 3 && txtDuoiThe.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nhập đuôi thẻ thanh toán");
                txtDuoiThe.Focus();
                txtDuoiThe.SelectAll();
                return false;
            }
            if (bteThuNgan.Enabled && bteThuNgan.Tag == null)
            {
                MessageBox.Show("Chưa chọn thu ngân");
                bteThuNgan.Focus();
                return false;
            }
            return true;

        }
        private void cboHinhThucTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            int loaiTT = liThanhToan[cboHinhThucTT.SelectedIndex].LoaiThanhToan;//1-tien mat;2-chuyenkhoan;3-the

            ResetThanhToan();

            txtSoTaiKhoan.Enabled = (loaiTT != 1 && loaiTT != -1) ? true : false;
            txtChuTaiKhoan.Enabled = (loaiTT != 1 && loaiTT != -1) ? true : false;
            bteNganHangTT.Properties.ReadOnly = (loaiTT != 1 && loaiTT != -1) ? false : true;
            bteNganHangPH.Properties.ReadOnly = (loaiTT != 1 && loaiTT != -1) ? false : true;
            //txtMaThe.Enabled = (loaiTT == 3 || loaiTT == 1) ? true : false;
            //txtDuoiThe.Enabled = (loaiTT == 3 || loaiTT == 1) ? true : false;

            if (loaiTT == 1 || loaiTT == -1)
            {
                //List<DMTaiKhoanQuyInfo> liQuy =
                //    DMTaiKhoanQuyDataProvider.Instance.GetListTaiKhoanQuyByTrungTam(ThanhToan.IdTrungTamThu);
                //if (liQuy.Count > 0)
                //{
                //    bteTaiKhoanQuy.Tag = liQuy[0];
                //    bteTaiKhoanQuy.Text = liQuy[0].TaiKhoanQuy;
                //    LoadNganHang(liQuy[0].IdNganHang);
                //}
                LoadTaiKhoanQuy(ThanhToan.IdTrungTamThu);
            }
            //else
            //{
            //    bteTaiKhoanQuy.Tag = null;
            //    bteTaiKhoanQuy.Text = "";
            //    bteNganHangTT.Tag = null;
            //    bteNganHangTT.Text = "";
            //}
        }

        private void ResetThanhToan()
        {
            bteTaiKhoanQuy.Tag = null;
            bteTaiKhoanQuy.Text = "";

            txtSoTaiKhoan.Text = "";
            txtChuTaiKhoan.Text = "";

            bteNganHangTT.Tag = null;
            bteNganHangTT.Text = "";

            bteNganHangPH.Tag = null;
            bteNganHangPH.Text = "";

            txtMaThe.Text = "";
            txtDuoiThe.Text = "";
        }

        private void txtSoTienTT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThanhToan_Click(sender, e);
            }
        }

        private void frmBH_ChonHinhThucTT_KeyDown(object sender, KeyEventArgs e)
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
                if (e.KeyCode == Keys.F10 && btnThanhToan.Enabled)
                    this.btnThanhToan_Click(sender, e);
                if (e.KeyCode == Keys.F2 && btnTToanHet.Enabled)
                    this.btnTToanHet_Click(sender, e);
                else if (e.KeyCode == Keys.Escape && btnThoat.Enabled)
                    this.btnThanhToan_Click(sender, e);
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

        private void frmBH_ChonHinhThucTT_Activated(object sender, EventArgs e)
        {
            txtSoTienTT.Focus();
        }

        private void bteThuNgan_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteNhanVien_ButtonClick(sender, e, bteThuNgan, IdKho);
        }

        private void bteThuNgan_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteNhanVien_KeyDown(sender, e, bteThuNgan, IdKho);
        }

        private void bteThuNgan_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteThuNgan);
        }

        private void btnTToanHet_Click(object sender, EventArgs e)
        {
            txtSoTienTT.Text = Common.Double2Str(TongTienThanhToan - TienDaThanhToan);
            txtTienThucTra_TextChanged(sender, e);
        }

        private void bteTaiKhoanQuy_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (UtilFunctions.bteTaiKhoanQuy_ButtonClick(sender, e, bteTaiKhoanQuy, (nguoiDung.SupperUser == 1 ||
                nguoiDung.IdNhomNguoiDung == 797 || //trưởng nhóm bán
                nguoiDung.IdNhomNguoiDung == 557    //nhóm kế toán tiền
                ? -1 : nguoiDung.IdTrungTamHachToan)))
            {
                int idNH = ((DMTaiKhoanQuyInfo) bteTaiKhoanQuy.Tag).IdNganHang;
                LoadNganHang(idNH);
            }
        }
        private void LoadNganHang(int idNganHang)
        {
            DMNganHangInfor nh = DMNganHangDataProvider.Instance.GetNganHangById(idNganHang);
            if (nh != null)
            {
                bteNganHangTT.Tag = nh;
                bteNganHangTT.Text = nh.TenNganHang;
            }
            else
            {
                bteNganHangTT.Tag = null;
                bteNganHangTT.Text = "";                
            }
        }

        private void LoadNganHangPH(int idNganHang)
        {
            DMNganHangInfor nh = DMNganHangDataProvider.Instance.GetNganHangById(idNganHang);
            if (nh != null)
            {
                bteNganHangPH.Tag = nh;
                bteNganHangPH.Text = nh.TenNganHang;
            }
            else
            {
                bteNganHangPH.Tag = null;
                bteNganHangPH.Text = "";
            }
        }

        private void bteTaiKhoanQuy_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteTaiKhoanQuy_KeyDown(sender, e, bteTaiKhoanQuy, (nguoiDung.SupperUser == 1 ? -1 : nguoiDung.IdTrungTamHachToan));
        }

        private void bteTaiKhoanQuy_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteTaiKhoanQuy);
        }

        private void bteNganHangTT_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteNganHang_ButtonClick(sender, e, bteNganHangTT);
        }

        private void bteNganHangTT_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteNganHang_KeyDown(sender, e, bteNganHangTT);
        }

        private void bteNganHangTT_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteNganHangTT);
        }

        private void bteNganHangPH_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteNganHang_ButtonClick(sender, e, bteNganHangPH);
        }

        private void bteNganHangPH_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteNganHang_KeyDown(sender, e, bteNganHangPH);
        }

        private void bteNganHangPH_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteNganHangPH);
        }

        private void bteThoiHanThanhToan_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteThoiHanThanhToan_ButtonClick(sender, e, bteThoiHanThanhToan);
        }

        private void bteThoiHanThanhToan_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteThoiHanThanhToan_KeyDown(sender, e, bteThoiHanThanhToan);
        }

        private void bteThoiHanThanhToan_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteThoiHanThanhToan);
        }

        private void bteTrungTam_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (UtilFunctions.bteTrungTam_ButtonClick(sender, e, bteTrungTam, nguoiDung.IdNhanVien))
            {
                if (ThanhToan != null)
                    ThanhToan.IdTrungTamThu = ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam;

                if (cboHinhThucTT.SelectedIndex >= 0)
                {
                    int loaiTT = liThanhToan[cboHinhThucTT.SelectedIndex].LoaiThanhToan;//1-tien mat;2-chuyenkhoan;3-the

                    if (loaiTT == 1)
                    {
                        LoadTaiKhoanQuy(((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam);
                    }
                    else
                    {
                        bteTaiKhoanQuy.Text = String.Empty;
                    }
                }
                else
                {
                    bteTaiKhoanQuy.Text = String.Empty;
                }
            }
        }

        private void bteTrungTam_KeyDown(object sender, KeyEventArgs e)
        {
            if (UtilFunctions.bteTrungTam_KeyDown(sender, e, bteTrungTam, nguoiDung.IdNhanVien))
            {
                if (ThanhToan != null)
                    ThanhToan.IdTrungTamThu = ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam;

                if (cboHinhThucTT.SelectedIndex >= 0)
                {
                    int loaiTT = liThanhToan[cboHinhThucTT.SelectedIndex].LoaiThanhToan;//1-tien mat;2-chuyenkhoan;3-the

                    if (loaiTT == 1)
                    {
                        LoadTaiKhoanQuy(((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam);
                    }
                    else
                    {
                        bteTaiKhoanQuy.Text = String.Empty;
                    }
                }
                else
                {
                    bteTaiKhoanQuy.Text = String.Empty;
                }
            }
        }

        private void bteTrungTam_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteTrungTam);
        }
    }
}
