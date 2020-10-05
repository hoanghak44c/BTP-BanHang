using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Globalization;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Properties;
using CrystalDecisions.Shared;
using QLBH.Common;
using QLBH.Core.Data;
using QLBH.Core.Form;
using QLBanHang.Modules.BanHang.Reports;

namespace QLBanHang.Modules.BanHang
{
    public partial class frm_HoaDonBan : frmBCBase
    {

        bool IsEdit = false;
        int IdChungTu = 0, IdPhieuXuat = 0;
        int CurrentIndex = 0;
        int iIdChungTuChiTiet;
        int billTo=0;
        int shipTo=0;
        DataTable dtKhachHang = null;
        DataTable dtChungTu = null;
        DataTable dtSiteResource = null;
        ArrayList arrTemp = null;
        string tableChiTietHangHoa;
        Utils ut = new Utils();

        public frm_HoaDonBan()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            tableChiTietHangHoa = "tbl_ChungTu_ChiTiet";
        }

        private void frm_HoaDonBan_Load(object sender, EventArgs e)
        {
            try {
                LoadCommboNhanVien();
                LoadCommboKho();
                LoadCommboDoiTuong();
                LoadQuyenHoaDon();
                LoadHinhThucTra();
                GetChungTuData();
                LoadFormIndex();
                EnableMenuFunc();
                LoadComboOrderType();
            }
            catch (System.Exception ex) {
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

        private void GetChungTuData() {
            string sql = "select ct.*, px.SoPhieuXuat from tbl_ChungTu ct left outer join tbl_PhieuXuat px";
            sql += " on ct.IdPhieuXuat= px.IdPhieuXuat where ct.LoaiChungTu=" + (int)TransactionType.XUAT_BAN;
            sql += String.Format(" and ct.NguoiTao='{0}'", Declare.UserName);
            sql += " and ct.ThoiGianSua > '" + Declare.NgayKhoaSo.ToString(new CultureInfo("en-US")) + "'";
            sql += " and ct.ThoiGianSua >= '" + Declare.NgayLamViec.Date.ToString(new CultureInfo("en-US")) + "'";
            sql += " order by ct.ThoiGianSua desc";
            dtChungTu = DBTools.getData("tbl_ChungTu", sql).Tables["tbl_ChungTu"];
        }

        private void LoadFormIndex() {
            if (dtChungTu == null || CurrentIndex >= dtChungTu.Rows.Count) return;
            this.arrTemp = new ArrayList();
            LoadFormData(dtChungTu.Rows[CurrentIndex]);
            //if (Declare.IdTrungTam == 0) {
            //    Declare.IdTrungTam = Common.IntValue(DBTools.ExecuteScalar("select IdTrungTam from tbl_DM_Kho where IdKho=" + Declare.IdKho));
            //}

            string sql = "select sp.MaSanPham, sp.TenSanPham, dvt.TenDonViTinh, ctct.SoLuong, ctct.DonGia,";
            sql += " ctct.TyLeChietKhau, ctct.TienChietKhau, ctct.IdChiTiet,";
            sql += " ctct.ThanhTien, sp.IdSanPham from tbl_ChungTu_Chitiet ctct";
            sql += " inner join tbl_SanPham sp on ctct.IdSanPham = sp.IdSanPham";
            sql += " inner join tbl_DM_DonViTinh dvt on dvt.IdDonViTinh = sp.IdDonViTinh";
            sql += " where ctct.IdChungTu=" + IdChungTu.ToString();
            dgvList.Rows.Clear();
            DataTable dtChiTiet = DBTools.getData("Tmp", sql).Tables["Tmp"];
            if (dtChiTiet != null) {
                foreach (DataRow dr in dtChiTiet.Rows) {
                    object[] field ={
                            dr["MaSanPham"],
                            dr["TenSanPham"],
                            dr["TenDonViTinh"],
                            dr["SoLuong"],
                            dr["DonGia"],
                            dr["TyLeChietKhau"],
                            dr["TienChietKhau"],
                            dr["ThanhTien"],
                            dr["IdSanPham"],
                            dr["IdChiTiet"]
                        };

                    dgvList.Rows.Add(field);
                    LoadTempData(int.Parse(dr["IdChiTiet"].ToString()), dgvList.Rows.Count - 2);
                }
            }
            tableChiTietHangHoa = "tbl_ChungTu_ChiTiet";
        }

        private void LoadFormData(DataRow dr) {            
            cboDoiTuong.SelectedValue = dr["IdDoiTuong"];
            cboKho.SelectedValue = dr["IdKho"];
            cboNhanVien.SelectedValue = dr["IdNhanVien"];
            cboQuyenSo.SelectedValue = dr["QuyenSo"];
            cboHinhThucTra.SelectedValue = dr["HinhThucTra"];
            cboHinhThucTT.Text = dr["HinhThucThanhToan"].ToString();
            dtNgayBan.Value = (DateTime)dr["NgayLap"];
            txtHoTen.Text = dr["HoTen"] != System.DBNull.Value ? dr["HoTen"].ToString() : String.Empty;
            txtDiaChi.Text = dr["DiaChi"] != System.DBNull.Value ? dr["DiaChi"].ToString() : String.Empty;
            txtDienThoai.Text = dr["DienThoai"] != System.DBNull.Value ? dr["DienThoai"].ToString() : String.Empty;
            txtMaSoThue.Text = dr["MaSoThue"] != System.DBNull.Value ? dr["MaSoThue"].ToString() : String.Empty;
            txtDoTuoi.Text = dr["DoTuoi"] != System.DBNull.Value ? dr["DoTuoi"].ToString() : String.Empty;
            cboGioiTinh.SelectedIndex = dr["GioiTinh"] != System.DBNull.Value ? Common.IntValue(dr["GioiTinh"].ToString()) : -1;
            txtGhiChu.Text = dr["GhiChu"] != System.DBNull.Value ? dr["GhiChu"].ToString() : String.Empty;
            txtSoPhieuXuat.Text = dr["SoPhieuXuat"] != System.DBNull.Value ? dr["SoPhieuXuat"].ToString() : String.Empty;
            txtSoHoaDon.Text = dr["SoChungTu"] != System.DBNull.Value ? dr["SoChungTu"].ToString() : String.Empty;
            txtSoSeri.Text = dr["SoSeri"] != System.DBNull.Value ? dr["SoSeri"].ToString() : String.Empty;
            txtTyLeVAT.Text = dr["TyleVAT"] != System.DBNull.Value ? (Convert.ToDouble(dr["TyleVAT"]) * 100).ToString() : String.Empty;
            txtSiteNumberBillTo.Text = dr["HinhThucThanhToan"] != System.DBNull.Value ? dr["HinhThucThanhToan"].ToString() : String.Empty;
            lblTongTienChietKhau.Text = Common.Double2Str(dr["TongTienChietKhau"] == System.DBNull.Value ? 0 : Convert.ToDouble(dr["TongTienChietKhau"]));
            lblTongTienSauChietKhau.Text = Common.Double2Str(dr["TongTienSauChietKhau"] == System.DBNull.Value ? 0 : Convert.ToDouble(dr["TongTienSauChietKhau"]));
            lblTongTienVAT.Text = Common.Double2Str(dr["TongTienVAT"] == System.DBNull.Value ? 0 : Convert.ToDouble(dr["TongTienVAT"]));
            lblTongTienThanhToan.Text = Common.Double2Str(dr["TongTienThanhToan"] == System.DBNull.Value ? 0 : Convert.ToDouble(dr["TongTienThanhToan"]));
            IdChungTu = dr["IdChungTu"] == System.DBNull.Value ? 0 : Common.IntValue(dr["IdChungTu"]);
            if (dr["OrderType"] == System.DBNull.Value)
                cboOrderType.SelectedIndex = -1;
            else
                cboOrderType.SelectedValue = dr["OrderType"];
            txtSiteNumberBillTo.Text = dr["BillTo"] == System.DBNull.Value ? String.Empty : DBTools.getValue("select SiteNumber from tbl_DM_DoiTuong_DiaChi where IdDiaChi=" + dr["BillTo"].ToString());
            txtAddressBillTo.Text = dr["BillTo"] == System.DBNull.Value ? String.Empty : DBTools.getValue("select DiaChi from tbl_DM_DoiTuong_DiaChi where IdDiaChi=" + dr["BillTo"].ToString());
            txtSiteNumberShipTo.Text = dr["ShipTo"] == System.DBNull.Value ? String.Empty : DBTools.getValue("select SiteNumber from tbl_DM_DoiTuong_DiaChi where IdDiaChi=" + dr["ShipTo"].ToString());
            txtAddressShipTo.Text = dr["ShipTo"] == System.DBNull.Value ? String.Empty : DBTools.getValue("select DiaChi from tbl_DM_DoiTuong_DiaChi where IdDiaChi=" + dr["ShipTo"].ToString());
            txtSoTaiKhoan.Text = dr["SoTaiKhoan"] == DBNull.Value ? String.Empty : dr["SoTaiKhoan"].ToString();
            txtNganHang.Text = dr["NganHang"] == DBNull.Value ? String.Empty : dr["NganHang"].ToString();
            billTo = dr["BillTo"] == System.DBNull.Value ? 0 : Common.IntValue(dr["BillTo"]);
            shipTo = dr["ShipTo"] == System.DBNull.Value ? 0 : Common.IntValue(dr["ShipTo"]);
        }

        private void LoadTempData(int IdChungTuChiTiet, int rowIndex)
        {
            DataTable dtChungTuChiTietHangHoa;
            string sql = "Select hh.IdChiTiet IdChiTietHangHoa, hh.IdSanPham, hh.MaVach, dvt.TenDonViTinh, cthh.SoLuong, cthh.SoLuong * sp.TienChietKhau TienChietKhau, cthh.SoLuong * ctct.DonGia - cthh.TienChietKhau ThanhTien from tbl_ChungTu_ChiTiet_HangHoa cthh";
            sql += " inner join tbl_ChungTu_ChiTiet ctct on ctct.IdChiTiet = cthh.IdChiTietChungTu";
            sql += " inner join tbl_HangHoa_ChiTiet hh on hh.IdChiTiet = cthh.IdChiTietHangHoa";
            sql += " inner join tbl_SanPham sp on sp.IdSanPham = hh.IdSanPham";
            sql += " inner join tbl_DM_DonViTinh dvt on sp.IdDonViTinh = dvt.IdDonViTinh";
            sql += " where cthh.IdChiTietChungTu = " + IdChungTuChiTiet;
            dtChungTuChiTietHangHoa = DBTools.getData(rowIndex.ToString(), sql).Tables[rowIndex.ToString()];
            if (this.arrTemp == null) {
                this.arrTemp = new ArrayList();
            }
            this.arrTemp.Add(dtChungTuChiTietHangHoa);
        }

        private void CleanForm()
        {
            cboDoiTuong.SelectedIndex = -1;
            cboKho.SelectedIndex = -1;
            cboNhanVien.SelectedIndex = -1;
            cboHinhThucTra.SelectedIndex = -1;
            cboHinhThucTT.SelectedIndex = -1;
            cboGioiTinh.SelectedIndex = -1;
            cboQuyenSo.SelectedIndex = -1;
            dtNgayBan.Value = DateTime.Now;
            txtHoTen.Text = String.Empty;
            txtDiaChi.Text = String.Empty;
            txtDienThoai.Text = String.Empty;
            txtMaSoThue.Text = String.Empty;
            txtGhiChu.Text = String.Empty;
            txtSoHoaDon.Text = String.Empty;
            txtSoSeri.Text = String.Empty;
            txtTyLeVAT.Text = String.Empty;
            cboOrderType.SelectedIndex = -1;
            txtSiteNumberBillTo.Text = String.Empty;
            txtSiteNumberShipTo.Text = String.Empty;
            txtAddressBillTo.Text = String.Empty;
            txtAddressShipTo.Text = String.Empty;
            txtDoTuoi.Text = String.Empty;
            txtSoPhieuXuat.Text = String.Empty;
            IdChungTu = 0;
            dgvList.Rows.Clear();
            CurrentIndex = -1;
            lblTongTienChietKhau.Text = "0";
            lblTongTienSauChietKhau.Text = "0";
            lblTongTienThanhToan.Text = "0";
            lblTongTienVAT.Text = "0";
            this.arrTemp = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CleanForm();
            EnableForm(this, true);
            txtTyLeVAT.Enabled = false;
            IsEdit = true;
            EnableMenuFunc();
        }

        private void EnableForm(Control parent, bool enabled)
        {
            foreach (Control ctl in parent.Controls) {
                if (ctl.GetType() == typeof(TextBox) || ctl.GetType() == typeof(ComboBox) ||
                    ctl.GetType() == typeof(Button) || ctl.GetType() == typeof(DateTimePicker) ||
                    ctl.GetType() == typeof(DataGridView)) {
                    if(ctl != txtSoHoaDon && ctl != dgvList)
                        ctl.Enabled = enabled;
                    else if (ctl == dgvList) {
                        dgvList.Columns["MaSanPham"].ReadOnly = !enabled;
                        dgvList.Columns["SoLuong"].ReadOnly = !enabled;
                    }


                }
                if (ctl.HasChildren) {
                    EnableForm(ctl, enabled);
                }
            }
        }

        private void EnableMenuFunc() {
            btnCapNhat.Enabled = IsEdit;
            btnThem.Enabled = !IsEdit;
            btnSua.Enabled = !IsEdit & IdChungTu != 0;
            btnXoa.Enabled = IdChungTu != 0;
            btnIn.Enabled = IdChungTu != 0;
            btnTruoc.Enabled = CurrentIndex > 0;
            btnSau.Enabled = dtChungTu != null && CurrentIndex < dtChungTu.Rows.Count - 1;
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (CurrentIndex > 0) {
                if (IsEdit) {
                    if (MessageBox.Show("Dữ liệu đang cập nhật, bạn có muốn hủy bỏ không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;
                }
                CurrentIndex--;
                EnableForm(this, false);
                IsEdit = false;
                LoadFormIndex();
                EnableMenuFunc();
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (CurrentIndex < dtChungTu.Rows.Count) {
                if (IsEdit) {
                    if (MessageBox.Show("Dữ liệu đang cập nhật, bạn có muốn hủy bỏ không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;
                }
                CurrentIndex++;
                EnableForm(this, false);
                IsEdit = false;
                LoadFormIndex();
                EnableMenuFunc();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            EnableForm(this, true);
            btnLoad.Enabled = false;
            txtTyLeVAT.Enabled = false;
            IsEdit = true;
            EnableMenuFunc();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try {
                string action = "Cập nhật";
                GtidCommand sqlcmd = new GtidCommand();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                if (cboDoiTuong.SelectedIndex < 0) {
                    tabControl1.SelectTab(0);
                    cboDoiTuong.Focus();
                    MessageBox.Show("Bạn chưa chọn đối tượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cboQuyenSo.SelectedIndex < 0) {
                    tabControl1.SelectTab(0);
                    cboQuyenSo.Focus();
                    MessageBox.Show("Bạn chưa chọn quyển hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cboHinhThucTT.SelectedIndex < 0) {
                    tabControl1.SelectTab(0);
                    cboHinhThucTT.Focus();
                    MessageBox.Show("Bạn chưa chọn hình thức thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cboHinhThucTra.SelectedIndex < 0) {
                    tabControl1.SelectTab(0);
                    cboHinhThucTra.Focus();
                    MessageBox.Show("Bạn chưa chọn hình thức trả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cboKho.SelectedIndex < 0) {
                    tabControl1.SelectTab(0);
                    cboKho.Focus();
                    MessageBox.Show("Bạn chưa chọn kho", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cboNhanVien.SelectedIndex < 0) {
                    tabControl1.SelectTab(0);
                    cboNhanVien.Focus();
                    MessageBox.Show("Bạn chưa chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                if (!Common.CheckHoaDon(txtSoSeri.Text, Common.IntValue(cboQuyenSo.SelectedValue))) {
                    tabControl1.SelectTab(1);
                    txtSoSeri.Focus();
                    MessageBox.Show("Số seri này không hợp lệ. Xin vui lòng chọn số khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (isExistedSoSeri()) {
                    tabControl1.SelectTab(1);
                    txtSoSeri.Focus();
                    MessageBox.Show("Số seri này đã được sử dụng. Xin vui lòng chọn số khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (dgvList.Rows[0].IsNewRow) {
                    MessageBox.Show("Phải có ít nhất một loại sản phẩm được ghi trong hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ConnectionUtil.Instance.BeginTransaction();
                if (IdChungTu != 0) {
                    sqlcmd.CommandText = "sp_ChungTu_HoaDonBan_Update";
                    getChungTuParams(ref sqlcmd);
                    if (!DBTools.UpdateRecord(sqlcmd)) throw DBTools._LastError;

                    sqlcmd.CommandText = "sp_ChungTu_HoaDonBan_ChiTiet_Delete";
                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.AddWithValue("@IdChungTu", IdChungTu);
                    if (!DBTools.DeleteRecord(sqlcmd)) throw DBTools._LastError;
                }
                else {
                    action = "Thêm mới";
                    sqlcmd.CommandText = "sp_ChungTu_HoaDonBan_Insert";
                    getChungTuInsertParams(ref sqlcmd);
                    if (!DBTools.InsertRecord(sqlcmd)) throw DBTools._LastError;
                    IdChungTu = Common.IntValue(sqlcmd.Parameters["@IdChungTu"].Value);
                }

                Common.updateSoHoaDon(txtSoSeri.Text, Common.IntValue(cboQuyenSo.SelectedValue), txtSoHoaDon.Text);

                foreach (DataGridViewRow dgr in dgvList.Rows) {
                    if (!dgr.IsNewRow) {
                        sqlcmd.CommandText = "sp_ChungTu_HoaDonBan_ChiTiet_Insert";
                        sqlcmd.Parameters.Clear();
                        getChungTuChiTietParams(ref sqlcmd, dgr);
                        if (!DBTools.InsertRecord(sqlcmd)) throw DBTools._LastError;
                        iIdChungTuChiTiet = Common.IntValue(sqlcmd.Parameters["@IdChiTiet"].Value);
                        foreach (DataTable dt in this.arrTemp) {
                            if (dt != null && dt.TableName == dgvList.Rows.IndexOf(dgr).ToString()) {
                                foreach (DataRow dr in dt.Rows) {
                                    sqlcmd.CommandText = "sp_ChungTu_HoaDonBan_ChiTiet_HangHoa_Insert";
                                    sqlcmd.Parameters.Clear();
                                    getChungTuChiTietHangHoaParams(ref sqlcmd, dr);
                                    if (!DBTools.InsertRecord(sqlcmd)) throw DBTools._LastError;
                                }
                            }
                        }
                        dgr.Cells["IdChungTuChiTiet"].Value = iIdChungTuChiTiet;
                    }
                }

                ConnectionUtil.Instance.CommitTransaction();
                Common.LogAction(action + " hóa đơn bán", "IdChungTu " + IdChungTu, Declare.IdKho);
                MessageBox.Show(action + " thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetChungTuData();
                EnableForm(this, false);
                IsEdit = false;
                EnableMenuFunc();
            }
            catch (System.Exception ex) {
                ConnectionUtil.Instance.RollbackTransaction();
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private bool isExistedSoSeri()
        {
            GtidCommand sqlcmd = new GtidCommand();
            sqlcmd.CommandText = String.Format("select * from tbl_ChungTu where SoSeri='{0}' and IdChungTu<>{1}", txtSoSeri.Text, IdChungTu);
            sqlcmd.CommandType = CommandType.Text;
            return DBTools.ExecuteScalar(sqlcmd) != null;
        }

        private void getChungTuParams(ref GtidCommand sqlcmd) {
            sqlcmd.Parameters.AddWithValue("@IdChungTu", IdChungTu).Direction = ParameterDirection.InputOutput;
            sqlcmd.Parameters.AddWithValue("@LoaiChungTu", (int)TransactionType.XUAT_BAN);
            if (String.IsNullOrEmpty(txtSoSeri.Text)) {
                sqlcmd.Parameters.AddWithValue("@SoSeri", DBNull.Value);
            }
            else {
                sqlcmd.Parameters.AddWithValue("@SoSeri", txtSoSeri.Text);
            }
            if (String.IsNullOrEmpty(txtSoHoaDon.Text)) {
                sqlcmd.Parameters.AddWithValue("@SoChungTu", DBNull.Value);
            }
            else {
                sqlcmd.Parameters.AddWithValue("@SoChungTu", txtSoHoaDon.Text);
            }
            if (String.IsNullOrEmpty(txtSoPhieuXuat.Text)) {
                sqlcmd.Parameters.AddWithValue("@SoPhieuXuat", DBNull.Value);
            }
            else {
                sqlcmd.Parameters.AddWithValue("@SoPhieuXuat", txtSoPhieuXuat.Text);
            }
            if (String.IsNullOrEmpty(cboHinhThucTT.Text)) {
                sqlcmd.Parameters.AddWithValue("@HinhThucThanhToan", DBNull.Value);
            }
            else {
                sqlcmd.Parameters.AddWithValue("@HinhThucThanhToan", cboHinhThucTT.Text);
            }
            sqlcmd.Parameters.AddWithValue("@NgayLap", dtNgayBan.Value);
            sqlcmd.Parameters.AddWithValue("@IdKho", cboKho.SelectedValue == null ? DBNull.Value : cboKho.SelectedValue);
            sqlcmd.Parameters.AddWithValue("@IdNhanVien", cboNhanVien.SelectedValue == null ? DBNull.Value : cboNhanVien.SelectedValue);
            sqlcmd.Parameters.AddWithValue("@IdDoiTuong", cboDoiTuong.SelectedValue == null ? DBNull.Value : cboDoiTuong.SelectedValue);
            if (String.IsNullOrEmpty(txtHoTen.Text)) {
                sqlcmd.Parameters.AddWithValue("@HoTen", DBNull.Value);
            }
            else {
                sqlcmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
            }
            if (String.IsNullOrEmpty(txtDiaChi.Text)) {
                sqlcmd.Parameters.AddWithValue("@DiaChi", DBNull.Value);
            }
            else {
                sqlcmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
            }
            if (String.IsNullOrEmpty(txtDienThoai.Text)) {
                sqlcmd.Parameters.AddWithValue("@DienThoai", DBNull.Value);
            }
            else {
                sqlcmd.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text);
            }
            if (String.IsNullOrEmpty(txtMaSoThue.Text)) {
                sqlcmd.Parameters.AddWithValue("@MaSoThue", DBNull.Value);
            }
            else {
                sqlcmd.Parameters.AddWithValue("@MaSoThue", txtMaSoThue.Text);
            }
            if (!String.IsNullOrEmpty(txtNganHang.Text))
                sqlcmd.Parameters.AddWithValue("@NganHang", txtNganHang.Text);
            if (!String.IsNullOrEmpty(txtSoTaiKhoan.Text))
                sqlcmd.Parameters.AddWithValue("@SoTaiKhoan", txtSoTaiKhoan.Text);
            if (String.IsNullOrEmpty(txtDoTuoi.Text)) {
                sqlcmd.Parameters.AddWithValue("@DoTuoi", DBNull.Value);
            }
            else {
                sqlcmd.Parameters.AddWithValue("@DoTuoi", txtDoTuoi.Text);
            }
            if (cboGioiTinh.SelectedIndex < 0) {
                sqlcmd.Parameters.AddWithValue("@GioiTinh", DBNull.Value);
            }
            else {
                sqlcmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.SelectedIndex);
            }
            
            sqlcmd.Parameters.AddWithValue("@TongTienChietKhau", Common.DoubleValue(lblTongTienChietKhau.Text));
            sqlcmd.Parameters.AddWithValue("@TongTienSauChietKhau", Common.DoubleValue(lblTongTienSauChietKhau.Text));
            sqlcmd.Parameters.AddWithValue("@TyleVAT", Common.DoubleValue(txtTyLeVAT.Text)/100);
            sqlcmd.Parameters.AddWithValue("@TongTienVAT", Common.DoubleValue(lblTongTienVAT.Text));
            sqlcmd.Parameters.AddWithValue("@TongTienThanhToan", Common.DoubleValue(lblTongTienThanhToan.Text));
            if (String.IsNullOrEmpty(txtGhiChu.Text)) {
                sqlcmd.Parameters.AddWithValue("@GhiChu", DBNull.Value);
            }
            else {
                sqlcmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);
            }            
            sqlcmd.Parameters.AddWithValue("@NguoiSua", Declare.UserName);
            sqlcmd.Parameters.AddWithValue("@ThoiGianSua", DateTime.Now);
            sqlcmd.Parameters.AddWithValue("@TenMaySua", Declare.TenMay);
            sqlcmd.Parameters.AddWithValue("@OrderType", cboOrderType.SelectedValue);
            if (billTo > 0)
                sqlcmd.Parameters.AddWithValue("@BillTo", billTo);
            if (shipTo > 0)
                sqlcmd.Parameters.AddWithValue("@ShipTo", shipTo);
            sqlcmd.Parameters.AddWithValue("@HinhThucTra", cboHinhThucTra.SelectedValue);
            sqlcmd.Parameters.AddWithValue("@QuyenSo", cboQuyenSo.SelectedValue);
        }

        private void getChungTuInsertParams(ref GtidCommand sqlcmd) {
            getChungTuParams(ref sqlcmd);
            sqlcmd.Parameters.AddWithValue("@NguoiTao", Declare.UserName);
            sqlcmd.Parameters.AddWithValue("@ThoiGianTao", DateTime.Now);
            sqlcmd.Parameters.AddWithValue("@TenMayTao", Declare.TenMay);
        }

        private void getChungTuChiTietParams(ref GtidCommand sqlcmd, DataGridViewRow dgr)
        {
            sqlcmd.Parameters.AddWithValue("@IdChiTiet", 0).Direction = ParameterDirection.Output;
            sqlcmd.Parameters.AddWithValue("@IdChungTu", IdChungTu);
            sqlcmd.Parameters.AddWithValue("@IdSanPham", dgr.Cells["IdSanPham"].Value);
            sqlcmd.Parameters.AddWithValue("@SoLuong", dgr.Cells["SoLuong"].Value);
            sqlcmd.Parameters.AddWithValue("@DonGia", dgr.Cells["DonGia"].Value);
            sqlcmd.Parameters.AddWithValue("@TyLeChietKhau", dgr.Cells["TyLeChietKhau"].Value);
            sqlcmd.Parameters.AddWithValue("@TienChietKhau", dgr.Cells["TienChietKhau"].Value);
            sqlcmd.Parameters.AddWithValue("@ThanhTien", dgr.Cells["ThanhTien"].Value);
        }

        private void getChungTuChiTietHangHoaParams(ref GtidCommand sqlcmd, DataRow dr)
        {
            sqlcmd.Parameters.AddWithValue("@IdChiTietChungTu", iIdChungTuChiTiet);
            sqlcmd.Parameters.AddWithValue("@IdChiTietHangHoa", dr["IdChiTietHangHoa"]);
            sqlcmd.Parameters.AddWithValue("@SoLuong", dr["SoLuong"]);
            sqlcmd.Parameters.AddWithValue("@TienChietKhau", dr["TienChietKhau"]);
        }

        private bool isHangDaChon(string pMaSanPham, int pHang)
        {
            for (int i = 0; i < dgvList.Rows.Count - 1; i++)
                if ((pHang != i) && (dgvList.Rows[i].Cells["MaSanPham"].Value.ToString() == pMaSanPham)) {
                    return true;
                }
            return false;
        }

        private void LoadCommboNhanVien()
        {
            string str = "Select DISTINCT nv.IdNhanVien, nv.maNhanVien, nv.HoTen From tbl_DM_NhanVien nv " +
                 " Inner Join tbl_Kho_NhanVien knv On knv.IdNhanVien = nv.IdNhanVien " +
                 " Where knv.IdKho in ( Select knv1.idKho From tbl_Kho_NhanVien knv1 " +
                 " Inner Join tbl_DM_NguoiDung nd On nd.IdNhanVien = knv1.IdNhanVien " +
                 " Where nd.IdNguoiDung = " + Declare.UserId + ") and (nv.SuDung = 1)  order by nv.HoTen ASC";

            DataTable dtNhanVien = DBTools.getData("tbl_DM_NhanVien", str).Tables["tbl_DM_NhanVien"];
            if (dtNhanVien != null) {
                this.cboNhanVien.DataSource = dtNhanVien;
                this.cboNhanVien.DisplayMember = "HoTen";
                this.cboNhanVien.ValueMember = "IdNhanVien";
                this.cboNhanVien.SelectedValue = Declare.IdNhanVien;
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
                this.cboKho.DataSource = dtKho;
                this.cboKho.DisplayMember = "TenKho";
                this.cboKho.ValueMember = "IdKho";
                this.cboKho.SelectedValue = Declare.IdKho;
            }
        }

        private void LoadCommboDoiTuong()
        {
            try
            {
                string str = "Select IdDoiTuong, MaDoiTuong, TenDoiTuong, DiaChi, DienThoai, MaSoThue, IdOrderType " +
                      "from tbl_DM_DoiTuong " +
                      "where SuDung = 1 and Type <> 2 " +
                      "order by TenDoiTuong ASC";
                this.dtKhachHang = DBTools.getData("tbl_DM_DoiTuong", str).Tables["tbl_DM_DoiTuong"];
                if (this.dtKhachHang != null)
                {
                    //this.dtKhachHang.Constraints.Add("fg_KhachHang", dtKhachHang.Columns["IdKhachHang"], true);
                    this.cboDoiTuong.DataSource = this.dtKhachHang;
                    this.cboDoiTuong.DisplayMember = "TenDoiTuong";
                    this.cboDoiTuong.ValueMember = "IdDoiTuong";
                    this.cboDoiTuong.SelectedIndex = -1;
                    //this.cboKhachHang.SelectedValue = Declare.IdKHMacDinh;

                    // AutoCompleteStringCollection 
                    //AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                    //for (int i = 0; i < dtKhachHang.Rows.Count; i++)
                    //{
                    //    data.Add(dtKhachHang.Rows[i]["TenDoiTuong"].ToString());
                    //    data1.Add(dtKhachHang.Rows[i]["MaDoiTuong"].ToString());
                    //}

                    //cboDoiTuong.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    //cboDoiTuong.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    //cboDoiTuong.AutoCompleteCustomSource = data;

                    //txtMaKhachHang.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    //txtMaKhachHang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    //txtMaKhachHang.AutoCompleteCustomSource = data1;

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

        private void LoadQuyenHoaDon() {
            string sql = "select QuyenSo from tbl_SuDung_HoaDon where IdNhanVien=" + Declare.IdNhanVien;
            sql += " and SoHienTai<=SoKetThuc";
            DataTable dt = DBTools.getData("Temp", sql).Tables["Temp"];
            this.cboQuyenSo.DisplayMember = "QuyenSo";
            this.cboQuyenSo.ValueMember = "QuyenSo";
            this.cboQuyenSo.DataSource = dt;
            //this.cboQuyenSo.SelectedIndex = 0;
        }

        private void LoadHinhThucTra()
        {
            string sql = "select IdThuChi, Ten from tbl_DM_LoaiThuChi where SuDung=1 and Type=0 ";
            DataTable dt = DBTools.getData("Temp", sql).Tables["Temp"];
            this.cboHinhThucTra.DisplayMember = "Ten";
            this.cboHinhThucTra.ValueMember = "IdThuChi";
            this.cboHinhThucTra.DataSource = dt;
            //this.cboHinhThucTra.SelectedIndex = 0;
        }

        private void cboDoiTuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDoiTuong.SelectedValue == null) return;
            string sql = "Select t1.TenDoiTuong, t1.DiaChi, t1.DienThoai, t1.MaSoThue, t2.IdOrderType from tbl_DM_DoiTuong t1";
            sql += " left outer join tbl_DM_OrderType t2 on t2.IdOrderType = t1.IdOrderType";
            sql += " where t1.IdDoiTuong =" + cboDoiTuong.SelectedValue.ToString();
            DataTable dt = DBTools.getData("Temp", sql).Tables["Temp"];
            if (dt != null) {
                txtHoTen.Text = dt.Rows[0]["TenDoiTuong"] == System.DBNull.Value ? String.Empty : dt.Rows[0]["TenDoiTuong"].ToString();
                txtDiaChi.Text = dt.Rows[0]["DiaChi"] == System.DBNull.Value ? String.Empty : dt.Rows[0]["DiaChi"].ToString();
                txtDienThoai.Text = dt.Rows[0]["DienThoai"] == System.DBNull.Value ? String.Empty : dt.Rows[0]["DienThoai"].ToString();
                txtMaSoThue.Text = dt.Rows[0]["MaSoThue"] == System.DBNull.Value ? String.Empty : dt.Rows[0]["MaSoThue"].ToString();
                if (dt.Rows[0]["IdOrderType"] != System.DBNull.Value)
                    cboOrderType.SelectedValue = dt.Rows[0]["IdOrderType"];
                else
                    cboOrderType.SelectedIndex = -1;
                txtSiteNumberBillTo.Text = String.Empty;
                txtAddressBillTo.Text = String.Empty;
                txtSiteNumberShipTo.Text = String.Empty;
                txtAddressShipTo.Text = String.Empty;
                setSiteResource();                
            }
        }

        private void btnChiTietChungTu_Click(object sender, EventArgs e)
        {
            if (dgvList.CurrentRow == null) return;
            if (dgvList.CurrentRow.IsNewRow) return;
            if (dgvList.Rows.Count == 0) {
                MessageBox.Show("Không có chi tiết hóa đơn");
                return;
            }
            int IdChungTuChiTiet = Common.IntValue(dgvList.CurrentRow.Cells["IdChungTuChiTiet"].Value);
            int IdSanPham = Common.IntValue(dgvList.CurrentRow.Cells["IdSanPham"].Value);
            if (IdSanPham == 0) {
                MessageBox.Show("Bạn chưa chọn loại sản phẩm");
                return;
            }
            if (this.arrTemp == null) this.arrTemp = new ArrayList();
            frm_HoaDonBan_ChiTietHangHoa frm = new frm_HoaDonBan_ChiTietHangHoa(IdSanPham, IdChungTuChiTiet, dgvList.CurrentRow.Cells["SoLuong"], this.arrTemp, tableChiTietHangHoa);
            frm.ShowDialog();
        }

        private void btnXoaChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvList.CurrentRow == null) return;
                if (dgvList.CurrentRow.IsNewRow) return;
                if (dgvList.Rows.Count == 0) {
                    MessageBox.Show("Không có chi tiết hóa đơn");
                    return;
                }
                if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
                    return;
                }
                if (dgvList.CurrentRow.Cells["IdChungTuChiTiet"].Value != null) {
                    int IdChungTuChiTiet = Common.IntValue(dgvList.CurrentRow.Cells["IdChungTuChiTiet"].Value);
 
                    //SqlCommand sqlcmd = new SqlCommand();
                    //sqlcmd.CommandType = CommandType.StoredProcedure;
                    //sqlcmd.CommandText = "sp_ChungTu_HoaDonBan_ChiTiet_DeleteOne";
                    //sqlcmd.Parameters.AddWithValue("@IdChiTietChungTu", IdChungTuChiTiet);
                    //if (!DBTools.DeleteRecord(sqlcmd)) throw DBTools._LastError;

                    foreach (DataTable dt in arrTemp) {
                        if (dt != null && dt.TableName == IdChungTuChiTiet.ToString()) {
                            arrTemp.Remove(dt);
                        }
                    }
                    lblTongTienChietKhau.Text=Common.Double2Str(TongTienChietKhau());
                    lblTongTienSauChietKhau.Text = Common.Double2Str(TongTienSauChietKhau());
                    lblTongTienVAT.Text = Common.Double2Str(TongTienVAT());
                    lblTongTienThanhToan.Text = Common.Double2Str(TongTienThanhToan());
                }
                dgvList.Rows.Remove(dgvList.CurrentRow);
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

        private void dgvList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvList.Rows[e.RowIndex];
            if (r.Cells[e.ColumnIndex].Value == null) return;
            //Kiem tra la edit cot colMaSanPham
            if (dgvList.Columns[e.ColumnIndex].Name == "MaSanPham") {
                //KT hang da chon
                if (isHangDaChon(r.Cells[e.ColumnIndex].Value.ToString(), e.RowIndex)) {
                    MessageBox.Show("Sản phẩm này đã nhập");
                    return;
                }
                else {
                    //Kiem tra co san pham thi gan gia tri cac o IdSanPham, TenSanPham
                    //Neu khong co se mo form de chon
                    string sql = "SELECT sp.* FROM vSanPham sp";
                    sql += " WHERE MaSanPham=N'{0}' and IdTrungTam={1}";
                    DataSet ds = DBTools.getData("Temp", string.Format(sql, r.Cells[e.ColumnIndex].Value, Declare.IdTrungTam));
                    if (ds.Tables["Temp"].Rows.Count > 0) {
                        r.Cells["IdSanPham"].Value = ds.Tables[0].Rows[0]["IdSanPham"];
                        r.Cells["TenSanPham"].Value = ds.Tables[0].Rows[0]["TenSanPham"];
                        r.Cells["DonViTinh"].Value = ds.Tables[0].Rows[0]["TenDonViTinh"];
                        r.Cells["TyLeChietKhau"].Value = ds.Tables[0].Rows[0]["TyLeChietKhau"];
                        r.Cells["TienChietKhau"].Value = ds.Tables[0].Rows[0]["TienChietKhau"];
                    }
                    else {
                        double tyLeVAT;
                        if (double.TryParse(txtTyLeVAT.Text, out tyLeVAT)) {
                            if (dgvList.Rows.Count == 2 & e.RowIndex == 0) {
                                tyLeVAT = 0;
                            }                            
                        }
                        frm_Chon_SanPham frm = new frm_Chon_SanPham(r.Cells["IdSanPham"], r.Cells["MaSanPham"], r.Cells["TenSanPham"], tyLeVAT);
                        frm.ShowDialog();
                    }
                }
            }

        }

        private void dgvList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (dgvList.Columns[e.ColumnIndex].Name == "IdSanPham") {
                    string sql = "SELECT sp.* FROM vSanPham sp";
                    sql += " WHERE sp.IdSanPham={0} and IdTrungTam={1}";
                    DataSet ds = DBTools.getData("Temp", string.Format(sql, dgvList.CurrentRow.Cells[e.ColumnIndex].Value, Declare.IdTrungTam));
                    if (ds.Tables["Temp"].Rows.Count > 0) {
                        dgvList.CurrentRow.Cells["IdSanPham"].Value = ds.Tables[0].Rows[0]["IdSanPham"];
                        dgvList.CurrentRow.Cells["TenSanPham"].Value = ds.Tables[0].Rows[0]["TenSanPham"];
                        dgvList.CurrentRow.Cells["DonViTinh"].Value = ds.Tables[0].Rows[0]["TenDonViTinh"];
                        dgvList.CurrentRow.Cells["TyLeChietKhau"].Value = ds.Tables[0].Rows[0]["TyLeChietKhau"];
                        dgvList.CurrentRow.Cells["TienChietKhau"].Value = ds.Tables[0].Rows[0]["TienChietKhau"];
                        dgvList.CurrentRow.Cells["SoLuong"].Value = 1;

                        if (e.RowIndex == 0) {
                            txtTyLeVAT.Text = ds.Tables[0].Rows[0]["TyLeVAT"].ToString();
                        }
                    }
                }
                else if (dgvList.Columns[e.ColumnIndex].Name == "SoLuong") {
                    if (dgvList.CurrentRow.Cells["IdSanPham"].Value != System.DBNull.Value) {
                        int IdSanPham = Common.IntValue(dgvList.CurrentRow.Cells["IdSanPham"].Value);
                        double TienChietKhau = 0;
                        if (double.TryParse(DBTools.getValue(String.Format("Select TienChietKhau from vSanPham where IdSanPham={0} and IdTrungTam={1}", IdSanPham, Declare.IdTrungTam)), out TienChietKhau)) {
                            TienChietKhau =Common.IntValue(dgvList.CurrentRow.Cells["SoLuong"].Value) * TienChietKhau;
                            dgvList.CurrentRow.Cells["TienChietKhau"].Value = TienChietKhau;
                        }
                        if (dgvList.CurrentRow.Cells["DonGia"].Value != System.DBNull.Value) {
                            dgvList.CurrentRow.Cells["ThanhTien"].Value = Common.IntValue(dgvList.CurrentRow.Cells["SoLuong"].Value) * Convert.ToDouble(dgvList.CurrentRow.Cells["DonGia"].Value) - TienChietKhau;
                            lblTongTienChietKhau.Text = Common.Double2Str(TongTienChietKhau());
                            lblTongTienSauChietKhau.Text = Common.Double2Str(TongTienSauChietKhau());
                            lblTongTienVAT.Text = Common.Double2Str(TongTienVAT());
                            lblTongTienThanhToan.Text = Common.Double2Str(TongTienThanhToan());
                        }
                    }
                }
            }
            catch (System.Exception ex) {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private double TongTienChietKhau()
        {
            double result = 0;
            foreach (DataGridViewRow dgr in dgvList.Rows) {
                if (dgr.Cells["TienChietKhau"].Value != System.DBNull.Value) {
                    result += Convert.ToDouble(dgr.Cells["TienChietKhau"].Value);
                }
            }
            return result;
        }

        private double TongTienSauChietKhau()
        {
            double result = 0;
            foreach (DataGridViewRow dgr in dgvList.Rows) {
                if (dgr.Cells["ThanhTien"].Value != System.DBNull.Value) {
                    result += Convert.ToDouble(dgr.Cells["ThanhTien"].Value);
                }
            }
            return result;
        }

        private double TongTienVAT()
        {
            if (String.IsNullOrEmpty(txtTyLeVAT.Text)) return 0;
            return TongTienSauChietKhau() * (double.Parse(txtTyLeVAT.Text)/100);
        }

        private double TongTienThanhToan() {
            return TongTienSauChietKhau() + TongTienVAT();
        }

        private void dgvList_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (this.arrTemp == null) return;
            int index = e.RowIndex;
            for (int i = 0; i < e.RowCount; i++) {
                foreach (DataTable dt in this.arrTemp) {
                    if (dt != null && dt.TableName == index.ToString()) {
                        this.arrTemp.Remove(dt);
                        break;
                    }
                }
                index++;
            }
        }

        private void dgvList_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvList.Rows[e.RowIndex].IsNewRow) return;
            if (dgvList.Columns[e.ColumnIndex].Name == "SoLuong") {
                if (!Common.IsInteger32(e.FormattedValue.ToString())) {
                    e.Cancel = true;
                    MessageBox.Show("Chưa nhập đúng định dạng kiểu số nguyên");
                }
            }            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try {
                if (IdChungTu == 0) return;
                if (MessageBox.Show("Bạn có chắc chắn xóa chứng từ này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    GtidCommand sqlcmd = new GtidCommand();
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.CommandText = "sp_ChungTu_HoaDonBan_Delete";
                    sqlcmd.Parameters.AddWithValue("@IdChungTu", IdChungTu);
                    if (!DBTools.DeleteRecord(sqlcmd)) throw DBTools._LastError;
                    GetChungTuData();
                    if (CurrentIndex >= dtChungTu.Rows.Count) CurrentIndex--;
                    LoadFormIndex();
                }
            }
            catch (System.Exception ex) {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string soPX = txtSoPhieuXuat.Text;
            string sql = "select px.*, ct.SoChungTu, ct.SoSeri, ct.TyleVAT, ct.IdChungTu, ct.LoaiChungTu from tbl_PhieuXuat px left outer join tbl_ChungTu ct";
            sql += " on ct.IdPhieuXuat= px.IdPhieuXuat where ct.LoaiChungTu=" + (int)TransactionType.XUAT_BAN + " and px.SoPhieuXuat='" + soPX + "'";
            sql += String.Format(" and px.NguoiSua='{0}'", Declare.UserName);
            //sql += " and NgayLap > '" + Declare.NgayKhoaSo.ToString(new CultureInfo("en-US")) + "'";
            //sql += " and NgayLap >= '" + Declare.NgayLamViec.ToString(new CultureInfo("en-US")) + "'";

            DataTable dt = DBTools.getData("tbl_PhieuXuat", sql).Tables["tbl_PhieuXuat"];
            foreach (DataColumn dc in dt.Columns) {
                if (dc.ColumnName == "IdKhachHang") dc.ColumnName = "IdDoiTuong";
                if (dc.ColumnName == "NgayXuat") dc.ColumnName = "NgayLap";
            }
            if (dt.Rows.Count == 0) {
                MessageBox.Show("Không có phiếu xuất nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CleanForm();
                txtSoPhieuXuat.Text = soPX;
                return;
            }
            LoadFormData(dt.Rows[0]);
            IdChungTu = 0;
            IdPhieuXuat = Common.IntValue(dt.Rows[0]["IdPhieuXuat"]);
            sql = "select distinct TyleVAT from tbl_PhieuXuat_Chitiet where IdPhieuXuat= " + IdPhieuXuat;
            dt = DBTools.getData("Tmp", sql).Tables["Tmp"];
            double tyle = -1;
            if (dt.Rows.Count > 1) {
                Form frm = new frm_HoaDonBan_ChonTyleVAT(dt);
                if (frm.ShowDialog() == DialogResult.OK)
                    tyle = Convert.ToDouble(dt.Rows[0]["TyleVAT"]);
            }
            sql = "select sp.MaSanPham, sp.TenSanPham, dvt.TenDonViTinh, pxct.SoLuong, pxct.DonGia,";
            sql += " pxct.TyLeChietKhau, pxct.TienChietKhau, pxct.IdChiTiet,";
            sql += " pxct.ThanhTien, sp.IdSanPham from tbl_PhieuXuat_Chitiet pxct";
            sql += " inner join tbl_SanPham sp on pxct.IdSanPham = sp.IdSanPham";
            sql += " inner join tbl_DM_DonViTinh dvt on dvt.IdDonViTinh = sp.IdDonViTinh";
            sql += " where pxct.IdPhieuXuat=" + IdPhieuXuat;
            if (tyle > -1)
                sql += " and pxct.TyleVAT =" + Common.Double2Str(tyle);

            dgvList.Rows.Clear();
            DataTable dtChiTiet = DBTools.getData("Tmp", sql).Tables["Tmp"];
            if (dtChiTiet != null) {
                foreach (DataRow dr in dtChiTiet.Rows) {
                    object[] field ={
                            dr["MaSanPham"],
                            dr["TenSanPham"],
                            dr["TenDonViTinh"],
                            dr["SoLuong"],
                            dr["DonGia"],
                            dr["TyLeChietKhau"],
                            dr["TienChietKhau"],
                            dr["ThanhTien"],
                            dr["IdSanPham"],
                            dr["IdChiTiet"]
                        };

                    dgvList.Rows.Add(field);
                    LoadTempPXData(int.Parse(dr["IdChiTiet"].ToString()), dgvList.Rows.Count - 2);
                }
                tableChiTietHangHoa = "tbl_PhieuXuat_ChiTiet";
            }
        }

        private void LoadTempPXData(int IdChungTuChiTiet, int rowIndex)
        {
            DataTable dtChungTuChiTietHangHoa;
            string sql = "Select hh.IdChiTiet IdChiTietHangHoa, hh.IdSanPham, hh.MaVach, dvt.TenDonViTinh, pxhh.SoLuong, pxhh.SoLuong * sp.TienChietKhau TienChietKhau, pxhh.SoLuong * pxct.DonGia - pxhh.TienChietKhau ThanhTien from tbl_PhieuXuat_ChiTiet_HangHoa pxhh";
            sql += " inner join tbl_PhieuXuat_ChiTiet pxct on pxct.IdChiTiet = pxhh.IdChiTietPhieuXuat";
            sql += " inner join tbl_HangHoa_ChiTiet hh on hh.IdChiTiet = pxhh.IdChiTietHangHoa";
            sql += " inner join tbl_SanPham sp on sp.IdSanPham = hh.IdSanPham";
            sql += " inner join tbl_DM_DonViTinh dvt on sp.IdDonViTinh = dvt.IdDonViTinh";
            sql += " where pxhh.IdChiTietPhieuXuat = " + IdChungTuChiTiet;
            dtChungTuChiTietHangHoa = DBTools.getData(rowIndex.ToString(), sql).Tables[rowIndex.ToString()];
            if (this.arrTemp == null) {
                this.arrTemp = new ArrayList();
            }
            this.arrTemp.Add(dtChungTuChiTietHangHoa);
        }
        protected override void OnSetParameterFields(ParameterFields myParams)
        {
            myParams.Clear();
            ut.SetParameterReport(myParams, "SoSeri", txtSoSeri.Text);
            ut.SetParameterReport(myParams, "SoChungTu", txtSoHoaDon.Text);
            ut.SetParameterReport(myParams, "TenKhachHang", txtHoTen.Text);
            ut.SetParameterReport(myParams, "DiaChi", txtDiaChi.Text);
            ut.SetParameterReport(myParams, "MaSoThue", txtMaSoThue.Text);
            ut.SetParameterReport(myParams, "HinhThucThanhToan", cboHinhThucTT.Text);
            ut.SetParameterReport(myParams, "NgayLap", String.Format("                   {0}                {1}              {2}", dtNgayBan.Value.Day, dtNgayBan.Value.Month, dtNgayBan.Value.Year));
            ut.SetParameterReport(myParams, "TyleVAT", Common.DoubleValue(txtTyLeVAT.Text));
            ut.SetParameterReport(myParams, "TongTienVAT", Common.DoubleValue(lblTongTienVAT.Text));
            ut.SetParameterReport(myParams, "TongTienThanhToan", Common.DoubleValue(lblTongTienThanhToan.Text));
            ut.SetParameterReport(myParams, "SoTienChu", Common.ReadNumner_(lblTongTienThanhToan.Text));
            string sql = "select Code from tbl_DM_OrderType where IdOrderType = " + cboOrderType.SelectedValue;
            ut.SetParameterReport(myParams, "OrderType", DBTools.getValue(sql));
            sql = "select MaKho from tbl_DM_Kho where IdKho = " + cboKho.SelectedValue;
            ut.SetParameterReport(myParams, "MaKho", DBTools.getValue(sql));
            ut.SetParameterReport(myParams, "SoPhieuXuat", txtSoPhieuXuat.Text.Trim());
            ut.SetParameterReport(myParams, "MaKhachHang", cboDoiTuong.SelectedValue.ToString());
        }
        protected override string OnSetSqlParameters(string cmdTextFormatString)
        {
            return String.Format(cmdTextFormatString, IdChungTu);            
        }
        protected override void OnLoadReport()
        {
            base.SetSqlParameters("Select * from vHoaDonBan where IdChungTu={0}", CommandType.Text, "vHoaDonBan");
            base.SetParameterFields();
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            if (IdChungTu == 0) return;
            rpt = new rptHoaDonBan();
            ShowReport("Hóa đơn bán");
        }

        private void LoadComboOrderType() {
            string sql = "select IdOrderType, Code from tbl_DM_OrderType order by Code";
            DataTable dt = DBTools.getData("Temp", sql).Tables["Temp"];
            cboOrderType.DisplayMember = "Code";
            cboOrderType.ValueMember = "IdOrderType";
            cboOrderType.DataSource = dt;
        }

        private void setSiteResource() {
            string sql = "select IdDiaChi, SiteNumber, DiaChi from tbl_DM_DoiTuong_DiaChi where IdDoiTuong = " + cboDoiTuong.SelectedValue.ToString() + " order by SiteNumber";
            dtSiteResource = DBTools.getData("Sites", sql).Tables["Sites"];
            AutoCompleteStringCollection resSiteNumber = new AutoCompleteStringCollection();
            AutoCompleteStringCollection resAddress = new AutoCompleteStringCollection();
            foreach (DataRow dr in dtSiteResource.Rows) {
                resSiteNumber.Add(dr["SiteNumber"].ToString());
                resAddress.Add(dr["DiaChi"].ToString());
            }
            txtSiteNumberBillTo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSiteNumberBillTo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSiteNumberBillTo.AutoCompleteCustomSource = resSiteNumber;

            txtSiteNumberShipTo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSiteNumberShipTo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSiteNumberShipTo.AutoCompleteCustomSource = resSiteNumber;

            txtAddressShipTo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtAddressShipTo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtAddressShipTo.AutoCompleteCustomSource = resAddress;

            txtAddressBillTo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtAddressBillTo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtAddressBillTo.AutoCompleteCustomSource = resAddress;

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            const int WM_KEYDOWN = 0x100;
            const int WM_SYSKEYDOWN = 0x104;
            if ((msg.Msg == WM_KEYDOWN) || (msg.Msg == WM_SYSKEYDOWN))
            {
                switch(keyData){
                    case Keys.Control | Keys.Tab:
                        tabControl1.SelectTab((tabControl1.SelectedIndex < tabControl1.TabPages.Count - 1 ? tabControl1.SelectedIndex + 1 : 0));
                        break;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            try {
                Common.ValdateCharInTextBox_Keypress(ref sender, ref e, Common.strValidate.STR_PHONE);
            }
            catch (Exception ex) {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDoTuoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            try {
                Common.ValdateCharInTextBox_Keypress(ref sender, ref e, Common.strValidate.STR_ISNUMBER);
            }
            catch (Exception ex) {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSite_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty((sender as TextBox).Text)) return;
            int index = (sender as TextBox).AutoCompleteCustomSource.IndexOf((sender as TextBox).Text);
            if (index < 0) {
                if (Object.Equals(sender, txtSiteNumberBillTo) || Object.Equals(sender, txtSiteNumberShipTo))
                    MessageBox.Show(Resources.SiteNumberKhongHopLe);
                if (Object.Equals(sender, txtAddressBillTo) || Object.Equals(sender, txtAddressShipTo))
                    MessageBox.Show(Resources.DiaChiKhongHopLe);
                (sender as TextBox).SelectionStart = 0;
                (sender as TextBox).SelectionLength = (sender as TextBox).Text.Length;
                e.Cancel = true;
                return;
            }
            if (Object.Equals(sender, txtSiteNumberBillTo)) {
                txtAddressBillTo.Text = txtAddressBillTo.AutoCompleteCustomSource[index];
                billTo = Common.IntValue(dtSiteResource.Rows[index]["IdDiaChi"]);
            }
            if (Object.Equals(sender, txtSiteNumberShipTo)) {
                txtAddressShipTo.Text = txtAddressShipTo.AutoCompleteCustomSource[index];
                shipTo = Common.IntValue(dtSiteResource.Rows[index]["IdDiaChi"]);
            }
            if (Object.Equals(sender, txtAddressBillTo)) {
                txtSiteNumberBillTo.Text = txtSiteNumberBillTo.AutoCompleteCustomSource[index];
                billTo = Common.IntValue(dtSiteResource.Rows[index]["IdDiaChi"]);
            }
            if (Object.Equals(sender, txtAddressShipTo)) {
                txtSiteNumberShipTo.Text = txtSiteNumberShipTo.AutoCompleteCustomSource[index];
                shipTo = Common.IntValue(dtSiteResource.Rows[index]["IdDiaChi"]);
            }
        }

        private void frm_HoaDonBan_KeyDown(object sender, KeyEventArgs e)
        {
            try {
                if (e.KeyCode == Keys.Enter) {
                    if (!this.txtGhiChu.Focused) {
                        SendKeys.Send("{TAB}");
                        e.Handled = true;
                    }
                }
                if (e.KeyCode == Keys.F3 && btnTruoc.Enabled)
                    this.btnTruoc_Click(sender, e);
                else if (e.KeyCode == Keys.F4 && btnSau.Enabled)
                    this.btnSau_Click(sender, e);
                else if (e.KeyCode == Keys.F5 && btnThem.Enabled)
                    this.btnThem_Click(sender, e);
                else if (e.KeyCode == Keys.F6 && btnSua.Enabled)
                    this.btnSua_Click(sender, e);
                else if (e.KeyCode == Keys.F7 && btnCapNhat.Enabled)
                    this.btnCapNhat_Click(sender, e);
                else if (e.KeyCode == Keys.F8 && btnXoa.Enabled)
                    this.btnXoa_Click(sender, e);
                else if (e.KeyCode == Keys.F9 && btnIn.Enabled)
                    this.btnIn_Click(sender, e);
                else if (e.KeyCode == Keys.F10 && btnTimKiem.Enabled)
                    this.btnTimKiem_Click(sender, e);
                else if (e.KeyCode == Keys.F12 && btnDong.Enabled)
                    this.btnDong_Click(sender, e);
            }
            catch (System.Exception ex) {
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
        }

        private void cboQuyenSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kyhieu = String.Empty;
            string seri = String.Empty;
            Common.LoadHoaDon(ref kyhieu, ref seri, Common.IntValue(cboQuyenSo.SelectedValue), false);
            txtSoSeri.Text = seri;
            txtSoHoaDon.Text = kyhieu;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try {
                int[] _IdChungTu = new int[1] { 0 };
                Form frm = new frm_TimKiem_ChungTu(TransactionType.XUAT_BAN, _IdChungTu, "sp_ChungTu_HoaDonBan_Delete", CommandType.StoredProcedure);
                if (frm.ShowDialog() == DialogResult.OK) {
                    GetChungTuData();
                    if (_IdChungTu[0] > 0) {
                        IdChungTu = _IdChungTu[0];
                        IsEdit = true;
                    }
                    if (dtChungTu.PrimaryKey.Length == 0)
                        dtChungTu.PrimaryKey = new DataColumn[] { dtChungTu.Columns["IdChungTu"] };
                    //DataRow[] dr = dtChungTu.Select(String.Format("IdChungTu={0}", IdChungTu));
                    CurrentIndex = dtChungTu.Rows.IndexOf(dtChungTu.Rows.Find(IdChungTu));
                    //if (CurrentIndex < 0){
                    //    MessageBox.Show("Chứng từ này hiện không có");
                    //    return;
                    //}
                    LoadFormIndex();
                    EnableForm(this, true);
                    EnableMenuFunc();
                    
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
    }
}