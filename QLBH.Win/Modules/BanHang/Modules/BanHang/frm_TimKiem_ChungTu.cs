using System;
using System.Data;
using System.Windows.Forms;
using System.Globalization;
using QLBH.Common;
using QLBH.Core.Data;
//using QLBanHang.Class;

namespace QLBanHang.Modules.BanHang
{
    public partial class frm_TimKiem_ChungTu : Form
    {
        int[] _IdChungTu;
        string _cmdTextDelete = String.Empty;
        CommandType _cmdType;
        public frm_TimKiem_ChungTu()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        public frm_TimKiem_ChungTu(TransactionType TransType, int[] IdChungTu, string cmdText, CommandType cmdType)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            cboLoaiChungTu.Enabled = false;
            switch (TransType) {
                case TransactionType.XUAT_BAN: cboLoaiChungTu.Text = "Xuất bán"; break;
                case TransactionType.XUAT_HUY_TIEU_HAO: cboLoaiChungTu.Text = "Xuất hủy tiêu hao"; break;
                case TransactionType.XUAT_DIEU_CHUYEN: cboLoaiChungTu.Text = "Xuất điều chuyển"; break;
                case TransactionType.XUAT_KHAC: cboLoaiChungTu.Text = "Xuất khác"; break;
                case TransactionType.XUAT_KHUYEN_MAI: cboLoaiChungTu.Text = "Xuất khuyến mại"; break;
                case TransactionType.NHAP_TRA_LAI: cboLoaiChungTu.Text = "Nhập trả lại"; break;
                case TransactionType.TRA_LAI_KHUYEN_MAI: cboLoaiChungTu.Text = "Trả lại khuyến mại"; break;
            }
            _IdChungTu = IdChungTu;
            _cmdTextDelete = cmdText;
            if (String.IsNullOrEmpty(cmdText)) btnXoa.Enabled = false;
            _cmdType = cmdType;
        }

        private void frm_TimKiem_ChungTu_Load(object sender, EventArgs e)
        {
            LoadCommboKho();
            LoadCommboDoiTuong();
            LoadCommboNguoiNhan();
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
                dtKho.Rows.InsertAt(dtKho.NewRow(), 0);
                this.cboKho.DataSource = dtKho;
                this.cboKho.DisplayMember = "TenKho";
                this.cboKho.ValueMember = "IdKho";
                this.cboKho.SelectedIndex = -1;
            }
        }

        private void LoadCommboDoiTuong()
        {
            DataTable dtDoiTuong = DBTools.getData("tbl_DM_DoiTuong", "Select IdDoiTuong, MaDoiTuong + ' - ' + TenDoiTuong DoiTuong From tbl_DM_DoiTuong Where SuDung = 1").Tables["tbl_DM_DoiTuong"];
            if (dtDoiTuong != null) {
                dtDoiTuong.Rows.InsertAt(dtDoiTuong.NewRow(), 0);
                this.cboDoiTuong.DataSource = dtDoiTuong;
                this.cboDoiTuong.DisplayMember = "DoiTuong";
                this.cboDoiTuong.ValueMember = "IdDoiTuong";
                this.cboDoiTuong.SelectedIndex = -1;
            }
        }

        private void LoadCommboNguoiNhan()
        {
            string str = "Select DISTINCT nv.IdNhanVien, nv.maNhanVien, nv.HoTen From tbl_DM_NhanVien nv " +
                 " Inner Join tbl_Kho_NhanVien knv On knv.IdNhanVien = nv.IdNhanVien " +
                 " Where knv.IdKho in ( Select knv1.idKho From tbl_Kho_NhanVien knv1 " +
                 " Inner Join tbl_DM_NguoiDung nd On nd.IdNhanVien = knv1.IdNhanVien " +
                 " Where nd.IdNguoiDung = " + Declare.UserId + ") and (nv.SuDung = 1)  order by nv.HoTen ASC";

            DataTable dtNhanVien = DBTools.getData("tbl_DM_NhanVien", str).Tables["tbl_DM_NhanVien"];
            if (dtNhanVien != null) {
                dtNhanVien.Rows.InsertAt(dtNhanVien.NewRow(), 0);
                this.cboNhanVien.DataSource = dtNhanVien;
                this.cboNhanVien.DisplayMember = "HoTen";
                this.cboNhanVien.ValueMember = "IdNhanVien";
                this.cboNhanVien.SelectedValue = Declare.IdNhanVien;
            }
        }

        private string Condition() {
            string dk = "1=1";
            TransactionType loaiCT = TransactionType.XUAT_KHAC;
            switch (cboLoaiChungTu.Text) {
                case "Xuất bán": loaiCT = TransactionType.XUAT_BAN; break;
                case "Xuất hủy tiêu hao": loaiCT = TransactionType.XUAT_HUY_TIEU_HAO; break;
                case "Xuất điều chuyển": loaiCT = TransactionType.XUAT_DIEU_CHUYEN; break;
                case "Xuất khác": loaiCT = TransactionType.XUAT_KHAC; break;
                case "Xuất khuyến mại": loaiCT = TransactionType.XUAT_KHUYEN_MAI; break;
                case "Nhập trả lại": loaiCT = TransactionType.NHAP_TRA_LAI; break;
                case "Trả lại khuyến mại": loaiCT = TransactionType.TRA_LAI_KHUYEN_MAI; break;
            }
            if (!String.IsNullOrEmpty(cboLoaiChungTu.Text)) {
                dk += String.Format(" and t1.LoaiChungTu={0}", (int)loaiCT);
            }

            if (cboKho.SelectedIndex > 0) {
                dk += String.Format(" and t2.IdKho={0}", cboKho.SelectedValue);
            }

            if (cboNhanVien.SelectedIndex > 0) {
                dk += String.Format(" and t1.IdNhanVien={0}", cboNhanVien.SelectedValue);
            }

            if (cboDoiTuong.SelectedIndex > 0) {
                dk += String.Format(" and t1.IdDoiTuong='{0}'", cboDoiTuong.SelectedValue);
            }

            if (!String.IsNullOrEmpty(txtMaSP.Text)) {
                dk += String.Format(" and sp.MaSanPham like '{0}'", txtMaSP.Text);
            }

            if (!String.IsNullOrEmpty(txtTenSP.Text)) {
                dk += String.Format(" and sp.TenSanPham like N'{0}'", txtTenSP.Text);
            }

            if (!String.IsNullOrEmpty(txtSoPX.Text)) {
                dk += String.Format(" and px.SoPhieuXuat like '{0}'", txtSoPX.Text);
            }

            if (!String.IsNullOrEmpty(txtKyHieuHD.Text)) {
                dk += String.Format(" and t1.SoChungTu like '{0}'", txtKyHieuHD.Text);
            }

            if (!String.IsNullOrEmpty(txtSoSeri.Text)) {
                dk += String.Format(" and t1.SoSeri like '{0}'", txtSoSeri.Text);
            }

            dk += String.Format(" and CONVERT(varchar(8), t1.NgayLap,112) between {0} and {1}", getDateValue(dtNgayLapTu.Value), getDateValue(dtNgayLapDen.Value));
            if (!String.IsNullOrEmpty(txtHoTen.Text)) {
                dk += String.Format(" and t1.HoTen like N'{0}'", txtHoTen.Text);
            }
            return dk;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "select distinct t1.IdChungTu, t1.SoChungTu, t1.NgayLap, case t1.LoaiChungTu ";
            sql += String.Format(" when {0} then N'Xuất bán'", (int)TransactionType.XUAT_BAN );
            sql += String.Format(" when {0} then N'Nhập trả lại'", (int)TransactionType.NHAP_TRA_LAI);
            sql += String.Format(" when {0} then N'Xuất điều chuyển'", (int)TransactionType.XUAT_DIEU_CHUYEN);
            sql += String.Format(" when {0} then N'Xuất hủy tiêu hao'", (int)TransactionType.XUAT_HUY_TIEU_HAO);
            sql += String.Format(" when {0} then N'Xuất khác' end LoaiChungTu,", (int)TransactionType.XUAT_KHAC);
            sql += " nv.HoTen NhanVien, dt.TenDoiTuong DoiTuong, kho.TenKho KhoHang";
            sql += " from tbl_ChungTu t1 inner join tbl_ChungTu_ChiTiet t2";
            sql += " on t1.IdChungTu = t2.IdChungTu ";
            sql += " and t1.ThoiGianSua > '" + Declare.NgayKhoaSo.ToString(new CultureInfo("en-US")) + "'";
            sql += " and t1.ThoiGianSua >= '" + Declare.NgayLamViec.Date.ToString(new CultureInfo("en-US")) + "'";
            sql += " inner join tbl_DM_NhanVien nv on t1.IdNhanVien = nv.IdNhanVien";
            sql += " inner join tbl_DM_Kho kho on kho.IdKho = t1.IdKho";
            sql += " left outer join tbl_DM_DoiTuong dt on t1.IdDoiTuong = dt.IdDoiTuong";
            sql += " inner join tbl_SanPham sp on sp.IdSanPham = t2.IdSanPham";
            sql += " left outer join tbl_PhieuXuat px on t1.IdPhieuXuat = px.IdPhieuXuat";
            sql += " where " + Condition();
            sql += " order by t1.ThoiGianSua desc";
            DataTable dt = DBTools.getData("tbl_ChungTu", sql).Tables["tbl_ChungTu"];
            dgvList.DataSource = dt;
            dgvList.Refresh();
        }

        private string getDateValue(DateTime d)
        {
            string result = d.Year.ToString();
            result += d.Month >= 10 ? d.Month.ToString() : "0" + d.Month.ToString();
            result += d.Day >= 10 ? d.Day.ToString() : "0" + d.Day.ToString();
            return result;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            try {
                if (dgvList.CurrentRow == null) return;
                Form frm = null;
                if (dgvList.CurrentRow.Cells["IdChungTu"].Value != null) {
                    _IdChungTu[0] = Common.IntValue(dgvList.CurrentRow.Cells["IdChungTu"].Value);
                    this.DialogResult = DialogResult.OK;
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try {
                if (dgvList.CurrentRow == null) return;
                if(String.IsNullOrEmpty(_cmdTextDelete)) {
                    MessageBox.Show("Lệnh xóa hóa đơn này chưa được thiết lập");
                    return;
                }
                if (MessageBox.Show("Bạn có chắc chắn xóa hóa đơn này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

                if (dgvList.CurrentRow.Cells["LoaiChungTu"].Value != null) {
                    GtidCommand sqlcmd = new GtidCommand();
                    sqlcmd.CommandType = _cmdType;
                    sqlcmd.CommandText = _cmdTextDelete;
                    ConnectionUtil.Instance.BeginTransaction();
                    sqlcmd.Parameters.AddWithValue("@IdChungTu", int.Parse(dgvList.CurrentRow.Cells["IdChungTu"].Value.ToString()));
                    if (!DBTools.DeleteRecord(sqlcmd)) throw DBTools._LastError;
                    ConnectionUtil.Instance.CommitTransaction();
                }
            }
            catch (System.Exception ex) {
                ConnectionUtil.Instance.RollbackTransaction();
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}