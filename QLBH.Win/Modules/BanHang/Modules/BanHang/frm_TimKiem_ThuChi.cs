using System;
using System.Data;
using System.Windows.Forms;
using QLBanHang.Modules.BanHang.Reports;
using System.Globalization;
using QLBH.Common;
using QLBH.Core.Form;
//using QLBanHang.Class;

namespace QLBanHang.Modules.BanHang
{
    public partial class frm_TimKiem_ThuChi : frmBCBase
    {
        DataTable dtNhanVien;
        DataTable dtDoiTuong;
        DataTable dtLoaiThuChi;

        public frm_TimKiem_ThuChi()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            rpt = new rptBC_Thu();
        }

        private void frm_TimKiem_ThuChi_Load(object sender, EventArgs e)
        {
            LoadCommboNguoiNhan();
            LoadCommboKho();
            LoadCommboDoiTuong();
            LoadCommboLoaiThu();
        }

        private void LoadCommboNguoiNhan()
        {
            string str = "Select DISTINCT nv.IdNhanVien, nv.maNhanVien, nv.HoTen From tbl_DM_NhanVien nv " +
                 " Inner Join tbl_Kho_NhanVien knv On knv.IdNhanVien = nv.IdNhanVien " +
                 " Where knv.IdKho in ( Select knv1.idKho From tbl_Kho_NhanVien knv1 " +
                 " Inner Join tbl_DM_NguoiDung nd On nd.IdNhanVien = knv1.IdNhanVien " +
                 " Where nd.IdNguoiDung = " + Declare.UserId + ") and (nv.SuDung = 1)  order by nv.HoTen ASC";

            //this.dtNhanVien = DBTools.getData("tbl_DM_NhanVien", str).Tables["tbl_DM_NhanVien"];
            //if (this.dtNhanVien != null) {
            //    this.cboNhanVien.DataSource = dtNhanVien;
            //    this.cboNhanVien.DisplayMember = "HoTen";
            //    this.cboNhanVien.ValueMember = "IdNhanVien";
            //    this.cboNhanVien.SelectedIndex = -1;
            //}

            DBTools.List_LoadData(this.cboNhanVien, str, "IdNhanVien", "HoTen", " ", 0);

        }

        private void LoadCommboKho()
        {
            string str = "Select DISTINCT kh.IdKho, kh.TenKho From tbl_DM_Kho kh " +
                  " Join tbl_Kho_NhanVien knv On kh.IdKho = knv.IdKho " +
                  " Inner Join tbl_DM_NhanVien nv On knv.IdNhanVien = nv.IdNhanVien " +
                  " Inner Join tbl_DM_NguoiDung nd On nv.IdNhanVien = nd.IdNhanVien " +
                  " where kh.SuDung =1 and nd.IdNguoiDung = " + Declare.UserId + " order by kh.TenKho ASC";
            //DataTable dtKho = DBTools.getData("tbl_DM_Kho", str).Tables["tbl_DM_Kho"];
            //if (dtKho != null) {
            //    this.cboKho.DataSource = dtKho;
            //    this.cboKho.DisplayMember = "TenKho";
            //    this.cboKho.ValueMember = "IdKho";
            //    this.cboKho.SelectedIndex = -1;
            //}

            DBTools.List_LoadData(this.cboKho, str, "IdKho", "TenKho", " ", 0);

        }

        private void LoadCommboDoiTuong()
        {
            //this.dtDoiTuong = DBTools.getData("tbl_DM_DoiTuong", "Select IdDoiTuong, MaDoiTuong + ' - ' + TenDoiTuong DoiTuong From tbl_DM_DoiTuong Where SuDung = 1").Tables["tbl_DM_DoiTuong"];
            //if (this.dtDoiTuong != null) {
            //    this.cboDoiTuong.DataSource = dtDoiTuong;
            //    this.cboDoiTuong.DisplayMember = "DoiTuong";
            //    this.cboDoiTuong.ValueMember = "IdDoiTuong";
            //    this.cboDoiTuong.SelectedIndex = -1;
            //}
            string sql= "Select IdDoiTuong, MaDoiTuong + ' - ' + TenDoiTuong DoiTuong From tbl_DM_DoiTuong Where SuDung = 1";
            DBTools.List_LoadData(this.cboDoiTuong, sql, "IdDoiTuong", "DoiTuong", " ", 0);
        }

        private void LoadCommboLoaiThu()
        {
            //this.dtLoaiThuChi = DBTools.getData("tbl_DM_LoaiThuChi", " Select IdThuChi, Ten From tbl_DM_LoaiThuChi Where SuDung = 1 and Type = 0 ").Tables["tbl_DM_LoaiThuChi"];
            //if (this.dtLoaiThuChi != null) {
            //    this.cboLoaiThu.DataSource = dtLoaiThuChi;
            //    this.cboLoaiThu.DisplayMember = "Ten";
            //    this.cboLoaiThu.ValueMember = "IdThuChi";
            //    this.cboLoaiThu.SelectedIndex = -1;
            //}
            string sql = "Select IdThuChi, Ten From tbl_DM_LoaiThuChi Where SuDung = 1 and Type = 0 ";
            DBTools.List_LoadData(this.cboLoaiThu, sql, "IdThuChi", "Ten", " ", 0);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try {
                LoadData();
            }
            catch (System.Exception ex) {
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
        }

        private void LoadData(){
            string sql = "select pt.*, nv.HoTen NguoiThu from tbl_ThuChi pt inner join tbl_DM_NhanVien nv on pt.IdNhanVien= nv.IdNhanVien where " + Condition();
            DataTable dt = DBTools.getData("tbl_ThuChi", sql).Tables["tbl_ThuChi"];
            dt.Columns.Add("SoTT", System.Type.GetType("System.Int16"));
            for (int i = 0; i <= dt.Rows.Count - 1; i++) {
                dt.DefaultView[i]["SoTT"] = i + 1;
            }
            dgvResult.DataSource = dt.DefaultView;
            dgvResult.Refresh();
        }

        private string Condition()
        {
            string dk = "1=1";
            if (cboKho.SelectedItem != null && (cboKho.SelectedItem as ListItem).ItemData != 0) {
                dk += String.Format(" and pt.IdKho= N'{0}'", (cboKho.SelectedItem as ListItem).ItemData);
            }

            if (cboLoaiThu.SelectedItem != null && (cboLoaiThu.SelectedItem as ListItem).ItemData != 0) {
                dk += String.Format(" and pt.Type= {0}", (cboLoaiThu.SelectedItem as ListItem).ItemData);
            }

            if (cboDoiTuong.SelectedItem != null && (cboDoiTuong.SelectedItem as ListItem).ItemData != 0) {
                dk += String.Format(" and pt.IdDoiTuong= N'{0}'", (cboDoiTuong.SelectedItem as ListItem).ItemData);
            }

            if (cboNhanVien.SelectedItem != null && (cboNhanVien.SelectedItem as ListItem).ItemData != 0) {
                dk += String.Format(" and pt.IdNhanVien= N'{0}'", (cboNhanVien.SelectedItem as ListItem).ItemData);
            }

            if (!String.IsNullOrEmpty(txtSoPhieu.Text)) {
                dk += String.Format(" and pt.SoPhieu like '%{0}%'", txtSoPhieu.Text);
            }

            if (!String.IsNullOrEmpty(txtHoTen.Text)) {
                dk += String.Format(" and pt.HoTen like N'%{0}%'", txtHoTen.Text);
            }

            if (!String.IsNullOrEmpty(txtNoiDungThuChi.Text)) {
                dk += String.Format(" and pt.NoiDungThuChi like N'%{0}%'", txtNoiDungThuChi.Text);
            }

            //if (mtbNgayLapFrom.Text.Trim() != "/  /" && mtbNgayLapTo.Text.Trim() != "/  /") {
            //    DateTime dateFrom = Common.ParseDate(mtbNgayLapFrom.Text.Trim());
            //    DateTime dateTo = Common.ParseDate(mtbNgayLapTo.Text.Trim());
            //    dk += String.Format(" and CONVERT(varchar(8), tbl_ThuChi.NgayLap,112) between {0} and {1}", getDateValue(dateFrom), getDateValue(dateTo));
            //}
            //else if (mtbNgayLapFrom.Text.Trim() != "/  /") {
            //    DateTime dateFrom = Common.ParseDate(mtbNgayLapFrom.Text.Trim());
            //    dk += String.Format(" and CONVERT(varchar(8), tbl_ThuChi.NgayLap,112) >= {0} ", getDateValue(dateFrom));
            //}
            //else if (mtbNgayLapTo.Text.Trim() != "/  /") {
            //    DateTime dateTo = Common.ParseDate(mtbNgayLapTo.Text.Trim());
            //    dk += String.Format(" and CONVERT(varchar(8), tbl_ThuChi.NgayLap,112) <= {0}", getDateValue(dateTo));
            //}

            dk += String.Format(" and pt.NgayLap between '{0}' and '{1}'", dtNgayLapFrom.Value.Date.ToString(new CultureInfo("en-US")), dtNgayLapTo.Value.Date.AddHours(24).ToString(new CultureInfo("en-US")));

            if (!String.IsNullOrEmpty(txtSoTienFrom.Text) && !String.IsNullOrEmpty(txtSoTienTo.Text)) {
                dk += String.Format(" and pt.SoTien between {0} and {1}", Convert.ToDouble(txtSoTienFrom.Text), Convert.ToDouble(txtSoTienTo.Text));
            }
            else if (!String.IsNullOrEmpty(txtSoTienFrom.Text)) {
                dk += String.Format(" and pt.SoTien >= {0}", Convert.ToDouble(txtSoTienFrom.Text));
            }
            else if (!String.IsNullOrEmpty(txtSoTienTo.Text)) {
                dk += String.Format(" and pt.SoTien <= {0}", Convert.ToDouble(txtSoTienTo.Text));
            }
            return dk;
        }

        private bool IsUnLock()
        {
            return (bool)dgvResult.CurrentRow.Cells["TrangThai"].Value;
        }

        private string getDateValue(DateTime d) {
            string result = d.Year.ToString();
            result += d.Month >= 10 ? d.Month.ToString() : "0" + d.Month.ToString();
            result += d.Day >= 10 ? d.Day.ToString() : "0" + d.Day.ToString();
            return result;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (!IsUnLock()) {
                MessageBox.Show("Phiếu thu này đã bị khóa. Bạn hãy liên hệ với người quản trị.", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmPhieuThu frm = new frmPhieuThu("S", dgvResult.CurrentRow);
            frm.ShowDialog();
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try {
                if (dgvResult.CurrentRow == null) {
                    return;
                }
                if (!IsUnLock()) {
                    MessageBox.Show("Phiếu thu này đã bị khóa. Bạn hãy liên hệ với người quản trị.", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int IdKho = int.Parse(dgvResult.CurrentRow.Cells["IdKho"].Value.ToString());
                if (MessageBox.Show("Bạn có chắc chắn xóa phiếu thu này.", Declare.titleNotice, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    if (DBTools.ExecuteQuery(String.Format("Delete from tbl_ThuChi where IdPhieu={0}", dgvResult.CurrentRow.Cells["IdPhieu"].Value), CommandType.Text) == null) {
                        Common.LogAction("Xóa " + this.Text.ToLower(), String.Format("Failed. IdPhieu={0}", dgvResult.CurrentRow.Cells["IdPhieu"].Value), IdKho);
                        MessageBox.Show("Lỗi thực hiện xóa phiếu thu.", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else {
                        LoadData();
                        Common.LogAction("Xóa " + this.Text.ToLower(), String.Format("Completed. IdPhieu={0}", dgvResult.CurrentRow.Cells["IdPhieu"].Value), IdKho);
                        MessageBox.Show("Thực hiện xóa phiếu thu thành công.", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Lỗi ngoại lệ:" + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        protected override string OnSetSqlParameters(string cmdTextFormatString)
        {
            cmdTextFormatString = String.Format(cmdTextFormatString, Condition());
            return cmdTextFormatString;
        }

        protected override void OnLoadReport()
        {
            string sql = " SELECT     TOP (100) PERCENT pt.SoPhieu, pt.NgayLap, pt.SoTien, lt.Ten AS LoaiThu, pt.HoTen AS KhachHang, nv.HoTen AS NhanVien, pt.NoiDungThuChi";
            sql += " FROM         dbo.tbl_ThuChi AS pt INNER JOIN";
            sql += " dbo.tbl_DM_LoaiThuChi AS lt ON pt.Type = lt.IdThuChi INNER JOIN";
            sql += " dbo.tbl_DM_NhanVien AS nv ON pt.IdNhanVien = nv.IdNhanVien";
            sql += " WHERE     (lt.Type = 0)AND {0}";
            sql += " ORDER BY pt.NgayLap DESC";
            base.SetSqlParameters(sql, CommandType.Text, "vBCThu");
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvResult.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để in.", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                ShowReport("Tim kiem Phiếu thu");
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

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDouble_KeyPress(object sender, KeyPressEventArgs e)
        {
            try {
                Common.ValdateCharInTextBox_Keypress(ref sender, ref e, Common.strValidate.STR_ISDOUBLE);
            }
            catch (Exception ex) {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtSoThuc_Leave(object sender, EventArgs e)
        {
            try {
                TextBox txt = (TextBox)sender;
                if (Common.ValidateDouble(txt.Text.Trim())) {
                    txt.Text = Common.Double2Str(Common.DoubleValue(txt.Text.Trim()));
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtNgay_Leave(object sender, EventArgs e)
        {
            if ((sender as MaskedTextBox).Text.Trim().Length < 10 && (sender as MaskedTextBox).Text.Trim() != "/  /") {
                MessageBox.Show("Ngày nhập sai." + "\n" + "-Hãy nhập lại ngày", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                (sender as MaskedTextBox).Focus();
                return;
            }
            if ((sender as MaskedTextBox).Text.Trim().Length == 10) {
                if (!Common.IsValidDate((sender as MaskedTextBox).Text.Trim())) {
                    MessageBox.Show(Declare.msgDateTimeValid, Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    (sender as MaskedTextBox).Focus();
                    return;
                }
            }
        }


    }
}