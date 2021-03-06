using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QLBanHang.Modules.BanHang.Reports;
using CrystalDecisions.Shared;
using QLBH.Common;
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBC_GDBanHang : frmBCBase
    {
        Utils ut = new Utils();
        TransactionType _transType = TransactionType.XUAT_BAN;
        public frmBC_GDBanHang()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            rpt = new rpt_BC_GDBanHang();
        }
        public frmBC_GDBanHang(TransactionType TransType)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            _transType = TransType;
            rpt = new rpt_BC_GDBanHang();
        }


        private void frm_BaoCaoBanHang_Load(object sender, EventArgs e)
        {
            string sql;
            //sql = @"SELECT     IdTrungTam, TenTrungTam FROM tbl_DM_TrungTam";
            sql = @"SELECT  IdTrungTam, TenTrungTam FROM tbl_DM_TrungTam where SuDung=1 and (IdTrungTam in
                    (Select IdTrungTam From tbl_DM_Kho Where IdKho in
                    (Select IdKho From tbl_Kho_NhanVien Where IdNhanVien in
                    (Select IdNhanVien From tbl_DM_NguoiDung Where IdNguoiDung=" + Declare.UserId + "))) or ('admin'='" + Declare.UserName.ToLower() + "'))";

            if (Declare.UserName.ToLower().Equals("admin"))
                ut.LoadComboBox(cboTrungTam, sql, 0, "");
            else
                ut.LoadComboBox1(cboTrungTam, sql);
            //----------------
            cboKyBaoCao.Items.Add("Ngày");
            for(int i=1;i<13;i++)
                cboKyBaoCao.Items.Add("Tháng " + i.ToString());
            for (int i = 1; i<=4; i++)
                cboKyBaoCao.Items.Add("Quý " + i.ToString());
            cboKyBaoCao.Items.Add("Năm");
            cboKyBaoCao.Items.Add("Tùy chọn");
            //----------------
            dtTuNgay.Enabled = false;
            dtDenNgay.Enabled = false;
            dtTuNgay.Value = new DateTime(DateTime.Today.Year, 1, 1);
            LaySoPhieu(0);
            setFormTitle();
        }
        private void setFormTitle()
        {
            switch (_transType)
            {
                case TransactionType.XUAT_BAN:
                    this.Text = "Báo cáo xuất bán hàng hóa";
                    lblTitle.Text = "CHI TIẾT GIAO DỊCH BÁN HÀNG";
                    break;
                case TransactionType.NHAP_TRA_LAI:
                    this.Text = "Báo cáo nhập hàng trả lại";
                    lblTitle.Text = "CHI TIẾT GIAO DỊCH NHẬP TRẢ LẠI";
                    break;
                case TransactionType.XUAT_HUY_TIEU_HAO:
                    this.Text = "Báo cáo xuất hủy hàng hóa";
                    lblTitle.Text = "CHI TIẾT GIAO DỊCH XUẤT HỦY TIÊU HAO";
                    break;
            }
            lblTitle.Location = new Point((this.Width - lblTitle.Width) / 2, lblTitle.Location.Y);
        }
        private bool LaySoPhieu(int pIdKho)
        {
            string sql;
            string dk = string.Format("LoaiChungTu={0}", (int)_transType);
            if (pIdKho > 0)
                dk += " and IdKho=" + pIdKho.ToString();
            sql = "SELECT SoChungTu  FROM dbo.tbl_ChungTu WHERE " + dk + " ORDER BY SoChungTu";
            DataTable dt = ut.getDataTable(sql);
            // AutoCompleteStringCollection 
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            for (int i = 0; i < dt.Rows.Count; i++)
                data.Add(dt.Rows[i]["SoChungTu"].ToString());
            txtSophieu.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSophieu.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSophieu.AutoCompleteCustomSource = data;

            return true;
        }           
        private void cboKyBaoCao_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nam=DateTime.Today.Year;
            dtDenNgay.Enabled = false;
            dtTuNgay.Enabled = false;
            if (cboKyBaoCao.Text == "Ngày")
            {
                dtTuNgay.Enabled = true;
                dtTuNgay.Value = DateTime.Today;
                dtDenNgay.Value = dtTuNgay.Value;
            }
            else if (cboKyBaoCao.Text.IndexOf("Tháng") >= 0)
            {
                int thang = int.Parse(cboKyBaoCao.Text.Substring(6));
                dtTuNgay.Value = new DateTime(nam, thang, 1);
                dtDenNgay.Value = new DateTime(nam, thang, DateTime.DaysInMonth(nam, thang));
            }
            else if (cboKyBaoCao.Text.IndexOf("Quý") >= 0)
            {
                int quy = int.Parse(cboKyBaoCao.Text.Substring(4));
                int thangdau=(quy-1)*3 + 1;
                int thangcuoi=(quy-1)* 3 + 3;
                dtTuNgay.Value = new DateTime(nam, thangdau, 1);
                dtDenNgay.Value = new DateTime(nam, thangcuoi, DateTime.DaysInMonth(nam, thangcuoi));
            }
            else if (cboKyBaoCao.Text == "Năm")
            {
                dtTuNgay.Value = new DateTime(nam, 1, 1);
                dtDenNgay.Value = new DateTime(nam, 12, 31);
            }
            else
            {
                dtTuNgay.Enabled = true;
                dtDenNgay.Enabled = true;
            }
        }


        private void cboTrungTam_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboTrungTam.SelectedIndex > 0)
            //{
            string sql = "SELECT IdKho,TenKho FROM tbl_DM_Kho WHERE sudung=1 and IdTrungTam=" + cboTrungTam.SelectedValue.ToString() +
                          " and (IdKho in (Select IdKho From tbl_Kho_NhanVien Where IdNhanVien in " +
                            "(Select IdNhanVien From tbl_DM_NguoiDung Where IdNguoiDung=" + Declare.UserId + ")) or ('admin'='" + Declare.UserName.ToLower() + "'))";

            ut.LoadComboBox(cboKho, sql);//, 0, "");
            //}
            //else
            //    cboKho.DataSource = null;
        }

        private void cboTrungTam_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdIn_Click(object sender, EventArgs e)
        {
            try {
                ShowReport("Chi tiết giao dịch bán hàng theo chứng từ");
            }
            catch (System.Exception ex) {
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
        }

        protected override void OnSetParameterFields(ParameterFields myParams)
        {
            myParams.Clear();
            switch (_transType) {
                case TransactionType.XUAT_BAN:
                    ut.SetParameterReport(myParams, "pTitle", "CHI TIẾT GIAO DỊCH BÁN HÀNG");
                    break;
                case TransactionType.NHAP_TRA_LAI:
                    ut.SetParameterReport(myParams, "pTitle", "CHI TIẾT GIAO DỊCH NHẬP TRẢ LẠI");
                    break;
                case TransactionType.XUAT_HUY_TIEU_HAO:
                    ut.SetParameterReport(myParams, "pTitle", "CHI TIẾT GIAO DỊCH XUẤT HỦY TIÊU HAO");
                    break;
            }
            ut.SetParameterReport(myParams, "pTrungTam", cboTrungTam.Text);
            ut.SetParameterReport(myParams, "pTuNgay", dtTuNgay.Value.ToString("dd/MM/yyyy"));
            ut.SetParameterReport(myParams, "pDenNgay", dtDenNgay.Value.ToString("dd/MM/yyyy"));
        }

        protected override string OnSetSqlParameters(string cmdTextFormatString)
        {
            switch (_transType) {
                case TransactionType.XUAT_BAN:
                    cmdTextFormatString += string.Format("(LoaiChungTu={0} or LoaiChungTu={1})", (int)TransactionType.XUAT_BAN, (int)TransactionType.XUAT_KHUYEN_MAI);
                    break;
                default:
                    cmdTextFormatString += string.Format("LoaiChungTu={0}", (int)_transType);
                    break;
            }
            if (cboTrungTam.SelectedIndex >= 0)
                cmdTextFormatString += " and tbl_DM_Kho.IdTrungTam=" + cboTrungTam.SelectedValue.ToString();
            if (cboKho.SelectedIndex >= 0)
                cmdTextFormatString += " and tbl_DM_Kho.IdKho=" + cboKho.SelectedValue.ToString();
            if (cboSanPham.SelectedIndex > 0)
                cmdTextFormatString += " and tbl_SanPham.IdSanPham=" + cboSanPham.SelectedValue.ToString();
            if (ut.isStringNotEmpty(txtTenSanPham.Text))
                cmdTextFormatString += string.Format(" and (tbl_SanPham.TenSanPham like N'%{0}%' or tbl_SanPham.MaSanPham like '%{0}%') ", txtTenSanPham.Text.Trim());
            if (ut.isStringNotEmpty(txtSophieu.Text))
                cmdTextFormatString += string.Format(" and (tbl_ChungTu.SoChungTu='{0}' or tbl_ChungTu.SoSeri='{0}') ", txtSophieu.Text.Trim());
            cmdTextFormatString += string.Format(" and tbl_ChungTu.NgayLap>='{0}' and tbl_ChungTu.NgayLap<='{1} 23:59'", ut.DateToString(dtTuNgay.Value), ut.DateToString(dtDenNgay.Value));

            return cmdTextFormatString;
        }

        protected override void OnLoadReport()
        {
            string sql;
            sql = string.Format(@"SELECT     dbo.tbl_DM_TrungTam.IdTrungTam, dbo.tbl_DM_TrungTam.TenTrungTam, dbo.tbl_ChungTu.NgayLap, dbo.tbl_ChungTu.SoChungTu, 
                      dbo.tbl_ChungTu.GhiChu, dbo.tbl_SanPham.MaSanPham, dbo.tbl_SanPham.TenSanPham, dbo.tbl_DM_Kho.MaKho, 
                      dbo.tbl_DM_DonViTinh.TenDonViTinh, dbo.tbl_ChungTu_Chitiet.SoLuong, dbo.tbl_ChungTu_Chitiet.DonGia, dbo.tbl_ChungTu_Chitiet.ThanhTien, 
                      dbo.tbl_ChungTu_Chitiet.TienChietKhau, (dbo.tbl_ChungTu_Chitiet.SoLuong * dbo.tbl_ChungTu_Chitiet.DonGia - dbo.tbl_ChungTu_Chitiet.TienChietKhau)
                       * dbo.tbl_ChungTu.TyleVAT AS TienVAT, (dbo.tbl_ChungTu_Chitiet.SoLuong * dbo.tbl_ChungTu_Chitiet.DonGia - dbo.tbl_ChungTu_Chitiet.TienChietKhau)
                       * (1 + dbo.tbl_ChungTu.TyleVAT) AS ThanhTienCoVAT, dbo.tbl_ChungTu.SoSeri
FROM         dbo.tbl_DM_DonViTinh INNER JOIN
                      dbo.tbl_SanPham ON dbo.tbl_DM_DonViTinh.IdDonViTinh = dbo.tbl_SanPham.IdDonViTinh INNER JOIN
                      dbo.tbl_ChungTu_Chitiet INNER JOIN
                      dbo.tbl_ChungTu ON dbo.tbl_ChungTu_Chitiet.IdChungTu = dbo.tbl_ChungTu.IdChungTu INNER JOIN
                      dbo.tbl_DM_Kho ON dbo.tbl_ChungTu.IdKho = dbo.tbl_DM_Kho.IdKho ON 
                      dbo.tbl_SanPham.IdSanPham = dbo.tbl_ChungTu_Chitiet.IdSanPham INNER JOIN
                      dbo.tbl_DM_TrungTam ON dbo.tbl_DM_Kho.IdTrungTam = dbo.tbl_DM_TrungTam.IdTrungTam");
            sql += " WHERE ";
            base.SetParameterFields();
            base.SetSqlParameters(sql, CommandType.Text, "vGDBanHang");
        }
        private void dtTuNgay_ValueChanged(object sender, EventArgs e)
        {
            if (cboKyBaoCao.Text=="Ngày")
                dtDenNgay.Value = dtTuNgay.Value;
        }

        private void cboKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Thay doi cboSanPham
            if (cboKho.SelectedIndex > 0)
            {
                string sql = @"SELECT distinct dbo.tbl_SanPham.IdSanPham, dbo.tbl_SanPham.TenSanPham
                            FROM dbo.tbl_HangHoa_Chitiet INNER JOIN  dbo.tbl_SanPham ON dbo.tbl_HangHoa_Chitiet.IdSanPham = dbo.tbl_SanPham.IdSanPham
                            Where IdKho=" + cboKho.SelectedValue.ToString();
                ut.LoadComboBox(cboSanPham, sql, 0, "");
                sql = @"SELECT  distinct   dbo.tbl_DM_NhanVien.IdNhanVien, dbo.tbl_DM_NhanVien.HoTen
                    FROM         dbo.tbl_DM_NhanVien INNER JOIN
                                          dbo.tbl_Kho_NhanVien ON dbo.tbl_DM_NhanVien.IdNhanVien = dbo.tbl_Kho_NhanVien.IdNhanVien
                    WHERE     dbo.tbl_Kho_NhanVien.IdKho = " + cboKho.SelectedValue.ToString();
                LaySoPhieu(ut.getInt(cboKho.SelectedValue));
            }
            else
            {
                cboSanPham.DataSource = null;
                LaySoPhieu(0);
            }
        }
    }
}