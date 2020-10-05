using System;
using System.Data;
using System.Windows.Forms;
using System.Globalization;
using QLBanHang.Modules.BanHang.Reports;
using QLBanHang.Properties;
using QLBH.Common;
using QLBH.Core.Data;
using QLBH.Core.Form;
using QLBanHang.Modules.DanhMuc;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmPhieuThu : frmBCBase
    {
#region "Khai báo biến"
        DataTable dtPhieuThu;
        DataTable dtNhanVien;
        DataTable dtNhaCungCap;
        DataTable dtLoaiThuChi;
        DataTable dtTienTe;
        DataGridViewRow currentRow;

        int IdPhieu = 0;
        int CurrentIndex = 0;
        bool Updating = false;
        string strStatus = "M";
  
#endregion

#region "Các phương thức khởi tạo"
        public frmPhieuThu()
        {
            InitializeComponent();
            strStatus = "M";
            Common.LoadStyle(this);
            GetAllItem();
        }

        public frmPhieuThu(string sStatus, DataGridViewRow currentRow)
        {
            InitializeComponent();
            this.strStatus = sStatus;
            this.currentRow = currentRow;
            Common.LoadStyle(this);
            rpt = new rptPhieuThu();
        }

        private void frmPhieuThu_Load(object sender, EventArgs e)
        {
            ComboData();
            if (dtPhieuThu != null && dtPhieuThu.Rows.Count > 0) {
                LoadFormData(dtPhieuThu.Rows[0]);
            }
            EnableMenuFunc();
            EnableForm(this, false);
        }        
#endregion

#region "Các phương thức"
        
        private void ComboData()
        {
            LoadCommboKho();
            LoadCommboNguoiNhan();
            LoadCommboLoaiThu();
            LoadCommboLoaiTien();       
        }

        private void LoadCommboNguoiNhan()
        {
            string str = "Select DISTINCT nv.IdNhanVien, nv.maNhanVien, nv.HoTen From tbl_DM_NhanVien nv " +
                 " Inner Join tbl_Kho_NhanVien knv On knv.IdNhanVien = nv.IdNhanVien " +
                 " Where knv.IdKho in ( Select knv1.idKho From tbl_Kho_NhanVien knv1 " +
                 " Inner Join tbl_DM_NguoiDung nd On nd.IdNhanVien = knv1.IdNhanVien " +
                 " Where nd.IdNguoiDung = " + Declare.UserId + ") and (nv.SuDung = 1)  order by nv.HoTen ASC";

            this.dtNhanVien = DBTools.getData("tbl_DM_NhanVien", str).Tables["tbl_DM_NhanVien"];
            if (this.dtNhanVien != null) {
                this.cboNguoiNhan.DisplayMember = "HoTen";
                this.cboNguoiNhan.ValueMember = "IdNhanVien";
                this.cboNguoiNhan.DataSource = dtNhanVien;
                this.cboNguoiNhan.SelectedValue = Declare.UserId;
                this.cboNguoiNhan.Refresh();
            }
        }

        private void LoadCommboNhanVien()
        {
            string str = "Select DISTINCT nv.IdNhanVien, nv.maNhanVien, nv.HoTen From tbl_DM_NhanVien nv " +
                 " Inner Join tbl_Kho_NhanVien knv On knv.IdNhanVien = nv.IdNhanVien " +
                 " Where knv.IdKho in ( Select knv1.idKho From tbl_Kho_NhanVien knv1 " +
                 " Inner Join tbl_DM_NguoiDung nd On nd.IdNhanVien = knv1.IdNhanVien " +
                 " Where nd.IdNguoiDung = " + Declare.UserId + ") and (nv.SuDung = 1)  order by nv.HoTen ASC";

            this.dtNhanVien = DBTools.getData("tbl_DM_NhanVien", str).Tables["tbl_DM_NhanVien"];
            if (this.dtNhanVien != null) {
                this.cboDoiTuong.DisplayMember = "HoTen";
                this.cboDoiTuong.ValueMember = "IdNhanVien";
                this.cboDoiTuong.DataSource = dtNhanVien;
                this.cboDoiTuong.Refresh();
            }
        }

        private void LoadCommboKho()
        {
            string str = "Select DISTINCT kh.IdKho, kh.MaKho, kh.TenKho From tbl_DM_Kho kh " +
                  " Join tbl_Kho_NhanVien knv On kh.IdKho = knv.IdKho " +
                  " Inner Join tbl_DM_NhanVien nv On knv.IdNhanVien = nv.IdNhanVien " +
                  " Inner Join tbl_DM_NguoiDung nd On nv.IdNhanVien = nd.IdNhanVien " +
                  " where kh.SuDung =1 and nd.IdNguoiDung = " + Declare.UserId + " order by kh.TenKho ASC";
            DataTable dtKho = DBTools.getData("tbl_DM_Kho", str).Tables["tbl_DM_Kho"];
            if (dtKho != null) {
                this.cboKho.DisplayMember = "TenKho";
                this.cboKho.ValueMember = "IdKho";
                this.cboKho.DataSource = dtKho;
                this.cboKho.SelectedIndex = 0;
            }
        }

        private void LoadCommboDoiTuong(int type)
        {
            this.dtNhaCungCap = DBTools.getData("tbl_DM_DoiTuong", "Select IdDoiTuong, MaDoiTuong + ' - ' + TenDoiTuong DoiTuong From tbl_DM_DoiTuong Where SuDung = 1 and Type = " + type).Tables["tbl_DM_DoiTuong"];
            if (this.dtNhaCungCap != null)
            {
                this.cboDoiTuong.DisplayMember = "DoiTuong";
                this.cboDoiTuong.ValueMember = "IdDoiTuong";
                this.cboDoiTuong.DataSource = dtNhaCungCap;
                this.cboDoiTuong.Refresh();
            }
        }

        private void LoadCommboLoaiThu()
        {
            this.dtLoaiThuChi = DBTools.getData("tbl_DM_LoaiThuChi", " Select IdThuChi, Ten From tbl_DM_LoaiThuChi Where SuDung = 1 and Type = 0 ").Tables["tbl_DM_LoaiThuChi"];
            if (this.dtLoaiThuChi != null)
            {
                this.cboLoaiThu.DisplayMember = "Ten";
                this.cboLoaiThu.ValueMember = "IdThuChi";
                this.cboLoaiThu.DataSource = dtLoaiThuChi;
                this.cboLoaiThu.Refresh();
            }
        }

        private void LoadCommboLoaiTien()
        {
            this.dtTienTe = DBTools.getData("tbl_DM_TienTe", " Select IdTienTe, TenTienTe From tbl_DM_TienTe Where SuDung = 1 ").Tables["tbl_DM_TienTe"];
            if (this.dtTienTe != null)
            {
                this.cboLoaiTien.DisplayMember = "TenTienTe";
                this.cboLoaiTien.ValueMember = "IdTienTe";
                this.cboLoaiTien.DataSource = this.dtTienTe;
                this.cboLoaiTien.SelectedIndex = 0;
            }
        }        

        private bool ValidateBefore()
        {
            if (cboKho.SelectedIndex < 0) {
                MessageBox.Show(Resources.KhoChuaNhap, Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboKho.Focus();
                return false;
            }
            if (cboNhomDoiTuong.SelectedIndex < 0) {
                MessageBox.Show(Resources.NhomDoiTuongChuaNhap, Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboNhomDoiTuong.Focus();
                return false;
            }
            //
            //Sư hơp lệ của thông tin số phiếu
            //
            if (txtSoPhieu.Text == "") {
                MessageBox.Show(Resources.SoPhieuChuaNhap, Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoPhieu.Focus();
                return false;
            }
            else {
                if (this.IdPhieu == 0) {
                    if (DBTools.ExecuteScalar("select SoPhieu from tbl_ThuChi where SoPhieu='" + txtSoPhieu.Text + "'") != null) {
                        MessageBox.Show(Resources.SoPhieuDaDung, Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSoPhieu.Focus();
                        return false;
                    }
                }
            }
            if (String.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show(Resources.TenDoiTuongChuaNhap, Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
                return false;
            }

            //
            //Sự hợp lệ của thông tin nhà cung cấp
            //
            if (this.cboDoiTuong.Text.Trim().Length == 0 && txtHoTen.Text.Trim().Length == 0) {
                MessageBox.Show(Declare.msgNotNull_NCC, Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboDoiTuong.Focus();
                return false;
            }

            //
            //Sự hợp lệ của thông tin ngày chi
            //

            if (dtNgayLap.Value.Date > Common.ParseDate(Common.GetCurrentDate()))
            {
                MessageBox.Show(Declare.msgNotGreater_NC, Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtNgayLap.Focus();
                return false;
            }
            //
            //Sự hợp lệ của thông tin người nhận
            //
            if (this.cboNguoiNhan.Text.Trim().Length == 0)
            {
                MessageBox.Show(Declare.msgfrmPhieuXuat_ChuaNhapNhanVien, Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboNguoiNhan.Focus();
                return false;
            }
            //
            //Sự hợp lệ của thông tin loại chi
            //
            if (this.cboLoaiThu.Text.Trim().Length == 0)
            {
                MessageBox.Show(Declare.msgNotNull_LoaiChi, Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cboLoaiThu.Focus();
                return false;
            }
            //
            //Sự hợp lệ của thông tin số tiền chi
            //
            if (this.txtSoTien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Số tiền chưa nhập." + "\n" + "-Hãy nhập số tiền thu", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtSoTien.Focus();
                return false;
            }
            if (!Common.ValidateDouble(this.txtSoTien.Text.Trim()))
            {
                MessageBox.Show("Số tiền phải có kiểu số." + "\n" + "-Hãy nhập  lại số tiền thu", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtSoTien.Focus();
                return false;
            }
            if (Common.DoubleValue(this.txtSoTien.Text.Trim()) <= 0)
            {
                MessageBox.Show("Số tiền phải lớn hơn 0." + "\n" + "- Hãy nhập lại số tiền thu", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtSoTien.Focus();
                return false;
            }
            //
            //Sự hợp lệ của thông tin loại tiền
            //
            if (this.cboLoaiTien.Text.Trim().Length == 0)
            {
                MessageBox.Show(Declare.msgNotNull_LoaiTien, Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cboLoaiTien.Focus();
                return false;
            }
            //
            //Sự hợp lệ của thông tin tỷ giá
            //
            if (this.cboLoaiTien.Text.Trim().Length != 0)
            {
                if (this.txtTyGia.Text.Length==0)
                {
                    MessageBox.Show(Declare.msgNotNull_TyGia, Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtTyGia.Focus();
                    return false;
                }
            }
            if(!Common.ValidateDouble(this.txtTyGia.Text.Trim()))
            {
                MessageBox.Show("Tỷ giá tiền tệ phải có kiểu số."+"\n"+"- Hãy nhập lại tỷ giá", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtTyGia.Focus();
                return false;  
            }
            Double TyGia=Common.DoubleValue(this.txtTyGia.Text.Trim());
            if (TyGia<=0)
            {
                MessageBox.Show("Tỷ giá tiền tệ phải lớn hơn 0." + "\n" + "- Hãy nhập lại tỷ giá", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtTyGia.Focus();
                return false;
            }
            if (this.cboLoaiTien.Text.Trim().ToUpper() == "VND" || this.cboLoaiTien.Text.Trim().ToUpper() == "VNĐ")
            {
                if (TyGia != 1)
                {
                    MessageBox.Show("Tỷ giá tiền tệ đối với VND hoặc VNĐ không thể khác 1." + "\n" + "- Hãy nhập lại tỷ giá", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtTyGia.Focus();
                    return false;
                }
            }
            //
            //Sự hợp lệ của thông tin số chứng từ kèm theo
            //
            if (txtSoChungTuKem.Text.Trim().Length>0)
            {
                string sCTKem = Common.ReplaceComDot(txtSoChungTuKem.Text.Trim()).Replace("00", "");
                if (!Common.IsNumeric2(sCTKem))
                {
                    MessageBox.Show(Declare.msgIsNumeric_CTKem, Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtSoChungTuKem.Focus();
                    return false;
                }
                else
                {
                    if (!Common.IsInteger16(txtSoChungTuKem.Text.Trim()))
                    {
                        MessageBox.Show(Declare.msgIsInteger16_CTKem, Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtSoChungTuKem.Focus();
                        return false;
                    }

                    if (Common.IntValue(txtSoChungTuKem.Text.Trim()) > 32767)
                    {
                        MessageBox.Show(Declare.msgNotHi_CTKem, Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtSoChungTuKem.Focus();
                        return false;
                    }
                    if (Common.IntValue(txtSoChungTuKem.Text.Trim()) < -32768)
                    {
                        MessageBox.Show(Declare.msgNotLo_CTKem, Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtSoChungTuKem.Focus();
                        return false;
                    }
                }
            }
            return true;
        }

        private void Form_Refresh()
        {
            IdPhieu = 0;
            Updating = false;
            this.txtSoPhieu.Text = "";
            this.dtNgayLap.Value = DateTime.Now;
            this.cboNguoiNhan.SelectedIndex = -1;
            this.cboDoiTuong.SelectedIndex = -1;
            this.cboLoaiThu.SelectedIndex = -1;
            this.cboKho.SelectedIndex = -1;
            this.cboNhomDoiTuong.SelectedIndex = -1;
            this.txtDiaChi.Text = "";   
            this.txtSoChungTuKem.Text = "";
            this.txtChungTuGoc.Text = "";
            this.txtSoTien.Text = "";
            this.cboLoaiTien.SelectedValue = Declare.IdTienTe;
            txtTyGia.Text = DBTools.getValue("select TyGia from tbl_DM_TienTe where IdTienTe=" + cboLoaiTien.SelectedValue);
            if (!String.IsNullOrEmpty(txtTyGia.Text)) {
                txtTyGia.Text = Common.Double2Str(Convert.ToDouble(txtTyGia.Text));
            }
            this.txtSoTienChu.Text = "";
            this.strStatus = "M";
            this.txtSoPhieu.ReadOnly = false;
            this.txtSoTaiKhoan.Text = "";
            this.txtNoiDungThuChi.Text = "";
            this.txtNganHang.Text = "";
            this.txtHoTen.Text = String.Empty;
        }

        private void GetAllItem() {
            string sql = "SELECT IdPhieu, SoPhieu, NgayLap, IdKho, IdNhanVien, IdDoiTuong, HoTen, DiaChi, SoTaiKhoan, NganHang, NoiDungThuChi, SoTien, IdTienTe, TyGia, "
                     + " SoTienChu, SoChungTuKem, ChungTuGoc, HinhThucThanhToan, Type, TrangThai, IdThuChi, DoiTuongType"
                     + " FROM tbl_ThuChi ";
                     //+ " where NgayLap > '" + Declare.NgayKhoaSo.ToString(new CultureInfo("en-US")) + "'"
                     //+ " and NgayLap >= '" + Declare.NgayLamViec.ToString(new CultureInfo("en-US")) + "'";
            dtPhieuThu = DBTools.getData("Temp", sql).Tables["Temp"];
        }

        private void LoadFormData(DataRow currentRow)
        {
            //if (currentRow["IdDoiTuong"] != null) {
            //    string typeDoiTuong = DBTools.getValue(String.Format("select Type from tbl_DM_DoiTuong where IdDoiTuong={0}", currentRow["IdDoiTuong"]));
            //    if (!String.IsNullOrEmpty(typeDoiTuong)) {
            //        LoadCommboDoiTuong(int.Parse(typeDoiTuong));
            //        cboNhomDoiTuong.SelectedIndex = int.Parse(typeDoiTuong);
            //    }
            //    else {
            //        LoadCommboNguoiNhan();
            //        cboNhomDoiTuong.SelectedIndex = 3;
            //    }
            //}
            //else {
            //    cboNhomDoiTuong.SelectedIndex = 4;
            //}
            cboNhomDoiTuong.SelectedIndex = currentRow["DoiTuongType"] == DBNull.Value
                                                ? -1
                                                : int.Parse(currentRow["DoiTuongType"].ToString());
            IdPhieu = int.Parse(currentRow["IdPhieu"].ToString());
            cboKho.SelectedValue = currentRow["IdKho"];
            cboLoaiThu.SelectedValue = currentRow["IdThuChi"];
            cboDoiTuong.SelectedValue = currentRow["IdDoiTuong"];
            cboLoaiTien.SelectedValue = currentRow["IdTienTe"];
            cboNguoiNhan.SelectedValue = currentRow["IdNhanVien"];
            cboHinhThucThanhToan.SelectedText = currentRow["HinhThucThanhToan"] == DBNull.Value ? String.Empty : currentRow["HinhThucThanhToan"].ToString();
            txtHoTen.Text = currentRow["HoTen"].ToString();
            txtDiaChi.Text = currentRow["DiaChi"].ToString();
            txtSoPhieu.Text = currentRow["SoPhieu"].ToString();
            dtNgayLap.Value = (DateTime)currentRow["NgayLap"];
            txtSoTaiKhoan.Text = currentRow["SoTaiKhoan"].ToString();
            txtNganHang.Text = currentRow["NganHang"].ToString();
            txtNoiDungThuChi.Text = currentRow["NoiDungThuChi"].ToString();
            txtSoTien.Text = currentRow["SoTien"].ToString();
            txtTyGia.Text = currentRow["TyGia"].ToString();
            txtSoTienChu.Text = currentRow["SoTienChu"].ToString();
            txtSoChungTuKem.Text = currentRow["SoChungTuKem"].ToString();
            txtChungTuGoc.Text = currentRow["ChungTuGoc"].ToString();
        }

        private void EnableMenuFunc()
        {
            tsbUpdate.Enabled = Updating;
            tsbAdd.Enabled = !Updating;
            tsbEdit.Enabled = !Updating & IdPhieu != 0;
            tsbDelete.Enabled = IdPhieu != 0;
            tsbPrint.Enabled = IdPhieu != 0;
            tsbPrev.Enabled = CurrentIndex > 0;
            tsbNext.Enabled = dtPhieuThu != null && CurrentIndex < dtPhieuThu.Rows.Count - 1;
        }

        private void EnableForm(Control parent, bool enabled)
        {
            foreach (Control ctl in parent.Controls) {
                if (ctl.GetType() == typeof(TextBox) || ctl.GetType() == typeof(ComboBox) ||
                    ctl.GetType() == typeof(Button) || ctl.GetType() == typeof(DateTimePicker) ||
                    ctl.GetType() == typeof(DataGridView)) {
                    ctl.Enabled = enabled;
                }
                if (ctl.HasChildren) {
                    EnableForm(ctl, enabled);
                }
            }
        }

        private void getSqlParams(ref GtidCommand SqlCmd)
        {
            SqlCmd.Parameters.AddWithValue("@IdPhieu", IdPhieu).Direction = ParameterDirection.InputOutput;
            SqlCmd.Parameters.AddWithValue("@SoPhieu", txtSoPhieu.Text.Trim());
            SqlCmd.Parameters.AddWithValue("@NgayLap", this.dtNgayLap.Value.ToString(new CultureInfo("en-US")));
            SqlCmd.Parameters.AddWithValue("@IdKho", cboKho.SelectedValue);
            SqlCmd.Parameters.AddWithValue("@IdNhanVien", cboNguoiNhan.SelectedValue);
            SqlCmd.Parameters.AddWithValue("@IdDoiTuong", cboDoiTuong.SelectedValue);
            SqlCmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text.ToString());
            SqlCmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
            SqlCmd.Parameters.AddWithValue("@SoTaiKhoan", txtSoTaiKhoan.Text);
            SqlCmd.Parameters.AddWithValue("@NganHang", txtNganHang.Text);
            SqlCmd.Parameters.AddWithValue("@NoiDungThuChi", txtNoiDungThuChi.Text);
            SqlCmd.Parameters.AddWithValue("@SoTien", Common.DoubleValue(txtSoTien.Text.Trim()));
            SqlCmd.Parameters.AddWithValue("@IdTienTe", int.Parse(cboLoaiTien.SelectedValue.ToString()));
            SqlCmd.Parameters.AddWithValue("@TyGia", Common.DoubleValue(txtTyGia.Text.Trim()));
            SqlCmd.Parameters.AddWithValue("@SoTienChu", Common.ReadNumner_(txtSoTienChu.Text));
            SqlCmd.Parameters.AddWithValue("@SoChungTuKem", txtSoChungTuKem.Text.Trim());
            SqlCmd.Parameters.AddWithValue("@ChungTuGoc", txtChungTuGoc.Text.Trim());
            SqlCmd.Parameters.AddWithValue("@HinhThucThanhToan", cboHinhThucThanhToan.SelectedItem == null ? System.DBNull.Value : cboHinhThucThanhToan.SelectedItem);
            //SqlCmd.Parameters.AddWithValue("@Type", 0);
            SqlCmd.Parameters.AddWithValue("@IdThuChi", cboLoaiThu.SelectedValue);
            SqlCmd.Parameters.AddWithValue("@DoiTuongType", cboNhomDoiTuong.SelectedIndex);
            if (IdPhieu > 0) {
                SqlCmd.Parameters.AddWithValue("@NguoiSua", Declare.UserName);
                SqlCmd.Parameters.AddWithValue("@NgaySua", DateTime.Now);
                SqlCmd.Parameters.AddWithValue("@TenMaySua", Declare.TenMay);
            }
            else {
                SqlCmd.Parameters.AddWithValue("@NguoiTao", Declare.UserName);
                SqlCmd.Parameters.AddWithValue("@NgayTao", DateTime.Now);
                SqlCmd.Parameters.AddWithValue("@TenMayTao", Declare.TenMay);
            }
        }

#endregion

#region "Các sự kiện"

        private bool IsUnLock(int IdPhieu)
        {
            return (bool)DBTools.ExecuteScalar("Select TrangThai from tbl_ThuChi where IdPhieu="+ IdPhieu);
        }

        private void txtSoThuc_LostFocus(object sender, EventArgs e)
        {
            try
            {
                TextBox txt = (TextBox)sender;
                if (Common.ValidateDouble(txt.Text.Trim()))
                {
                    txt.Text = Common.Double2Str(Common.DoubleValue(txt.Text.Trim()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtCTKem_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.ValdateCharInTextBox_Keypress(ref sender, ref e, Common.strValidate.STR_ISNUMBER);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtDouble_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.ValdateCharInTextBox_Keypress(ref sender, ref e, Common.strValidate.STR_ISDOUBLE);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtKyTuSoVaChuCai_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.ValdateCharInTextBox_Keypress(ref sender, ref e, Common.strValidate.STR_CHAR_A_Z_a_z_0_9);
                Common.ValdateCharInTextBox_Keypress(ref sender, ref e, Common.strValidate.STR_TOUPPER);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void frmPhieuThu_KeyDown(object sender, KeyEventArgs e)
        {
            try {
                if (e.KeyCode == Keys.Enter) {
                    if (!this.txtDiaChi.Focused && !this.txtNoiDungThuChi.Focused) {
                        SendKeys.Send("{TAB}");
                        e.Handled = true;
                    }
                }
                if (e.KeyCode == Keys.F3 && tsbPrev.Enabled)
                    this.tsbPrev_Click(sender, e);
                else if (e.KeyCode == Keys.F4 && tsbNext.Enabled)
                    this.tsbNext_Click(sender, e);
                else if (e.KeyCode == Keys.F5 && tsbAdd.Enabled)
                    this.tsbAdd_Click(sender, e);
                else if (e.KeyCode == Keys.F6 && tsbEdit.Enabled)
                    this.tsbEdit_Click(sender, e);
                else if (e.KeyCode == Keys.F7 && tsbUpdate.Enabled)
                    this.tsbUpdate_Click(sender, e);
                else if (e.KeyCode == Keys.F8 && tsbDelete.Enabled)
                    this.tsbDelete_Click(sender, e);
                else if (e.KeyCode == Keys.F9 && tsbPrint.Enabled)
                    this.tsbPrint_Click(sender, e);
                else if (e.KeyCode == Keys.F12 && tsbClose.Enabled)
                    this.tsbClose_Click(sender, e);
            }
            catch (System.Exception ex) {
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
        }

        private void cboNguoiNhan_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F4)
                {
                    frmDM_NhanVien frm = new frmDM_NhanVien();
                    frm.ShowDialog();

                    int Index = this.cboNguoiNhan.SelectedIndex;
                    this.LoadCommboNguoiNhan();

                    if (Index < this.cboNguoiNhan.Items.Count - 1)
                        this.cboNguoiNhan.SelectedIndex = Index;
                    else
                        this.cboNguoiNhan.SelectedIndex = this.cboNguoiNhan.Items.Count - 1;

                    e.Handled = true;
                    frm.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ:" + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }               

        private void cboLoaiThu_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F4)
                {
                    frmDM_Chung frm = new frmDM_Chung("frmDM_LoaiChi");
                    frm.ShowDialog();

                    int Index = this.cboLoaiThu.SelectedIndex;
                    this.LoadCommboLoaiThu();

                    if (Index < this.cboLoaiThu.Items.Count - 1)
                        this.cboLoaiThu.SelectedIndex = Index;
                    else
                        this.cboLoaiThu.SelectedIndex = this.cboLoaiThu.Items.Count - 1;

                    e.Handled = true;
                    frm.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ:" + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cboLoaiTien_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F4)
                {
                    frmDM_Chung frm = new frmDM_Chung("frmDM_TienTe");
                    frm.ShowDialog();

                    int Index = this.cboLoaiTien.SelectedIndex;
                    this.LoadCommboLoaiTien();

                    if (Index < this.cboLoaiTien.Items.Count - 1)
                        this.cboLoaiTien.SelectedIndex = Index;
                    else
                        this.cboLoaiTien.SelectedIndex = this.cboLoaiTien.Items.Count - 1;

                    e.Handled = true;
                    frm.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ:" + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cboNhomDoiTuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                cboDoiTuong.DropDownStyle = ComboBoxStyle.DropDownList;
                cboDoiTuong.DataSource = null;
                cboDoiTuong.Items.Clear();
                if (cboNhomDoiTuong.SelectedIndex == 3) {
                    LoadCommboNhanVien();
                    return;
                }

                if (cboNhomDoiTuong.SelectedIndex == 4) {
                    return;
                }

                LoadCommboDoiTuong(cboNhomDoiTuong.SelectedIndex);
            }
            catch (System.Exception ex) {
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
        }

        private void cboDoiTuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = String.Empty;
            txtHoTen.Text = String.Empty;
            txtDiaChi.Text = String.Empty;

            if (cboNhomDoiTuong.SelectedIndex == 4) {
                return;
            }
            else if (cboNhomDoiTuong.SelectedIndex == 3) {
                sql = "Select HoTen, DiaChi from tbl_DM_NhanVien where IdNhanVien=" + cboDoiTuong.SelectedValue;
            }
            else {
                sql = String.Format("Select TenDoiTuong, DiaChi from tbl_DM_DoiTuong where IdDoiTuong={0} and Type={1}", cboDoiTuong.SelectedValue, cboNhomDoiTuong.SelectedIndex);
            }
            DataTable dt = DBTools.getData("Temp", sql).Tables["Temp"];
            if (dt != null && dt.Rows.Count > 0)
            {
                txtHoTen.Text = dt.Rows[0][0].ToString();
                txtDiaChi.Text = dt.Rows[0][1].ToString();
            }
        }

        private void cboLoaiTien_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                if (this.cboLoaiTien.DisplayMember.ToString().Length > 0 && this.cboLoaiTien.ValueMember.ToString().Length > 0) {
                    if (this.cboLoaiTien.SelectedIndex == -1)
                        return;
                    string strLoaiTien = cboLoaiTien.Text;
                    if (strLoaiTien == "VND") {
                        txtTyGia.Text = "1";
                    }
                    else {
                        txtTyGia.Text = DBTools.getValue("select TyGia from tbl_DM_TienTe where IdTienTe=" + cboLoaiTien.SelectedValue);
                        if (!String.IsNullOrEmpty(txtTyGia.Text)) {
                            txtTyGia.Text = Common.Double2Str(Convert.ToDouble(txtTyGia.Text));
                        }
                    }
                }
            }
            catch (System.Exception ex) {
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
        }

        private void txtTyGia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double tygia = Convert.ToDouble(txtTyGia.Text.Trim());
                double tien = Convert.ToDouble(txtSoTien.Text.Trim());
                //txtTongTienVN.Text=Convert.ToString(tygia*tien);
                //txtSoTienChu.Text = Common.ReadNumner_(Common.Double2Str(Common.DoubleValue(txtTongTienVN.Text.Trim())));
            }
            catch
            {}
        }

        private void txtSoTien_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtSoTienChu.Text = Common.ReadNumner_(Common.Double2Str(Common.DoubleValue(txtSoTien.Text.Trim())));
            }
            catch(Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void tsbPrev_Click(object sender, EventArgs e)
        {
            if (CurrentIndex > 0) {
                if (Updating) {
                    if (MessageBox.Show("Dữ liệu đang cập nhật, bạn có muốn hủy bỏ không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;
                }
                CurrentIndex--;
                EnableForm(this, false);
                Updating = false;
                LoadFormData(dtPhieuThu.Rows[CurrentIndex]);
                EnableMenuFunc();
            }
        }

        private void tsbNext_Click(object sender, EventArgs e)
        {
            if (CurrentIndex < dtPhieuThu.Rows.Count) {
                if (Updating) {
                    if (MessageBox.Show("Dữ liệu đang cập nhật, bạn có muốn hủy bỏ không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;
                }
                CurrentIndex++;
                EnableForm(this, false);
                Updating = false;
                LoadFormData(dtPhieuThu.Rows[CurrentIndex]);
                EnableMenuFunc();
            }
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            Form_Refresh();
            EnableForm(this, true);
            Updating = true;
            EnableMenuFunc();
            txtSoPhieu.Text = Common.TaoSoPhieuTuDong("PT", "tbl_ThuChi", "SoPhieu");
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (!IsUnLock(IdPhieu)) {
                MessageBox.Show("Phiếu thu này  đã bị khóa. Hãy liên hệ với người quản trị", Declare.titleWarning, MessageBoxButtons.OK);
                return;
            }
            EnableForm(this, true);
            Updating = true;
            EnableMenuFunc();
        }

        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            try {
                if (!ValidateBefore()) return;

                GtidCommand SqlCmd = ConnectionUtil.Instance.GetConnection().CreateCommand();
                ConnectionUtil.Instance.BeginTransaction();

                int IdKho = int.Parse(cboKho.SelectedValue.ToString());

                if (IdPhieu == 0) {
                    SqlCmd.CommandText = "sp_tbl_ThuChi_Insert";
                    SqlCmd.CommandType = CommandType.StoredProcedure;
                    getSqlParams(ref SqlCmd);

                    if (DBTools.InsertRecord(SqlCmd)) {
                        IdPhieu = int.Parse(SqlCmd.Parameters["@IdPhieu"].Value.ToString());
                        Common.LogAction("Tạo mới " + this.Text.ToLower(), "Completed. IdPhieu=" + IdPhieu, IdKho);
                        this.txtSoPhieu.ReadOnly = true;
                        ConnectionUtil.Instance.CommitTransaction();
                        MessageBox.Show("Thêm mới phiếu thu thành công.", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CurrentIndex = dtPhieuThu.Rows.Count;
                    }
                    else {
                        Common.LogAction("Tạo mới " + this.Text.ToLower(), "Failed.", IdKho);
                        ConnectionUtil.Instance.RollbackTransaction();
                        MessageBox.Show("Lỗi thực hiện thêm mới phiếu thu." + "\n" + (DBTools._LastError != null ? DBTools._LastError.Message : ""), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                }
                else {
                    SqlCmd.CommandText = "sp_tbl_ThuChi_Update";
                    SqlCmd.CommandType = CommandType.StoredProcedure;
                    getSqlParams(ref SqlCmd);

                    if (DBTools.UpdateRecord(SqlCmd)) {
                        Common.LogAction("Cập nhật " + this.Text.ToLower(), "Completed. IdPhieu=" + IdPhieu, IdKho);

                        MessageBox.Show("Cập nhật phiếu thu thành công.", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ConnectionUtil.Instance.CommitTransaction();
                        if (currentRow != null) {
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else {
                        ConnectionUtil.Instance.RollbackTransaction();
                        Common.LogAction("Cập nhật " + this.Text.ToLower(), "Failed. IdPhieu=" + IdPhieu, IdKho);
                        MessageBox.Show("Lỗi thực hiện quá trình cập nhật." + "\n" + (DBTools._LastError != null ? DBTools._LastError.Message : ""), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                EnableForm(this, false);
                Updating = false;
                GetAllItem();
                EnableMenuFunc();
                //if (IdPhieu == 0) CurrentIndex = dtPhieuThu.Rows.Count - 1;
                //IdPhieu = int.Parse(SqlCmd.Parameters["@IdPhieu"].Value.ToString());
                LoadFormData(dtPhieuThu.Rows[CurrentIndex]);
            }
            catch (System.Exception ex) {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            try {
                if (IdPhieu == 0) return;
                if (!IsUnLock(IdPhieu)) {
                    MessageBox.Show("Phiếu thu này  đã bị khóa. Hãy liên hệ với người quản trị", Declare.titleWarning, MessageBoxButtons.OK);
                    return;
                }

                if (this.txtSoPhieu.Text.Trim().Equals("")) {
                    MessageBox.Show(Declare.msgfrmPhieuXuat_KhongCoPhieuXoa, Declare.titleWarning, MessageBoxButtons.OK);
                    this.txtSoPhieu.Focus();
                    return;
                }
                int IdKho = int.Parse(DBTools.getValue("Select IdKho from tbl_ThuChi where IdPhieu=" + IdPhieu.ToString()));

                if (MessageBox.Show("Bạn có chắc chắn xóa phiếu thu này.", Declare.titleNotice, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    if (DBTools.ExecuteQuery(String.Format("Delete from tbl_ThuChi where IdPhieu={0}", IdPhieu), CommandType.Text) == null) {
                        Common.LogAction("Xóa " + this.Text.ToLower(), "Failed. IdPhieu=" + IdPhieu, IdKho);
                        MessageBox.Show("Lỗi thực hiện xóa phiếu thu.", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else {
                        Form_Refresh();
                        Common.LogAction("Xóa " + this.Text.ToLower(), "Completed. IdPhieu=" + IdPhieu, IdKho);
                        MessageBox.Show("Thực hiện xóa phiếu thu thành công.", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                GetAllItem();
                EnableMenuFunc();
                EnableForm(this, false);
                if (CurrentIndex >= dtPhieuThu.Rows.Count) CurrentIndex--;
                if (dtPhieuThu.Rows.Count > 0) {
                    LoadFormData(dtPhieuThu.Rows[CurrentIndex]);
                }
                else {
                    Form_Refresh();
                }
            }
            catch (Exception ex) {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ:" + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show(ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }         
        }
        protected override string OnSetSqlParameters(string cmdTextFormatString)
        {
            cmdTextFormatString = String.Format(cmdTextFormatString, txtSoPhieu.Text.Trim());
            return cmdTextFormatString;
        }
        protected override void OnLoadReport()
        {
            string sql = " SELECT     SoPhieu, NgayLap, HoTen, DiaChi, SoTien, SoTaiKhoan, NoiDungThuChi, TyGia, SoTienChu,  SoChungTuKem, ChungTuGoc, Ngay, Thang, Nam  FROM vPhieuThu  ";
            sql = sql + " WHERE SoPhieu = '{0}'";
            base.SetSqlParameters(sql, CommandType.Text, "vPhieuThu");
        }
        private void tsbPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IdPhieu == 0)
                {
                    MessageBox.Show("Không có dữ liệu để in.", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                ShowReport("Phiếu thu");
            }
            catch (System.Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            try {
                Common.ValdateCharInTextBox_Keypress(ref sender, ref e, Common.strValidate.STR_ISNUMBER);
            }
            catch (Exception ex) {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }


#endregion

    }
}

