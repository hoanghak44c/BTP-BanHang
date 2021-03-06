using System;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using QLBanHang.Modules.BanHang.Reports;
using QLBH.Common;
using QLBH.Core.Form;
//using QLBanHang.Class;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBC_HangGiamGiaBan : frmBCBase
    {
        Utils ut = new Utils();
        public frmBC_HangGiamGiaBan()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            rpt = new rpt_BC_HangGiamGiaBan();
        }

        private void frmBC_DoanhThuBanHang_Load(object sender, EventArgs e)
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
        
        
        private void cmdThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdIn_Click(object sender, EventArgs e)
        {
            try {
                ShowReport("Báo cáo");
            }
            catch (System.Exception ex) {
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
        }
        protected override void OnSetParameterFields(ParameterFields myParams){
            myParams.Clear();
            ut.SetParameterReport(myParams, "pTuNgay", dtTuNgay.Value.ToString("dd/MM/yyyy"));
            ut.SetParameterReport(myParams, "pDenNgay", dtDenNgay.Value.ToString("dd/MM/yyyy"));
        }

        protected override string OnSetSqlParameters(string cmdTextFormatString)
        {

            if (cboKho.SelectedIndex >= 0)
                cmdTextFormatString += " and IdKho=" + cboKho.SelectedValue.ToString();
            if (ut.isStringNotEmpty(txtTaiKhoan.Text))
                cmdTextFormatString += string.Format(" and NguoiSua like N'%{0}%' ", txtTaiKhoan.Text.Trim());
            if (cboSanPham.SelectedIndex > 0)
                cmdTextFormatString += " and IdSanPham=" + cboSanPham.SelectedValue.ToString();
            if (ut.isStringNotEmpty(txtTenSanPham.Text))
                cmdTextFormatString += string.Format(" and (TenSanPham like N'%{0}%' or MaSanPham like '%{0}%') ", txtTenSanPham.Text.Trim());
            if (ut.isStringNotEmpty(txtSophieu.Text))
                cmdTextFormatString += string.Format(" and (SoSerie like '%{0}%' or SoPhieuXuat like '%{0}%' or SoOrderKH like '%{0}%')", txtSophieu.Text.Trim());
            cmdTextFormatString += string.Format(" and NgayXuat>='{0}' and NgayXuat<='{1} 23:59' ORDER BY  NgayXuat ", ut.DateToString(dtTuNgay.Value), ut.DateToString(dtDenNgay.Value));

            return cmdTextFormatString;
        }

        protected override void OnLoadReport()
        {
            string sql = "select * from vBCSuaGia WHERE (1=1) ";
            base.SetParameterFields();
            base.SetSqlParameters(sql, CommandType.Text, "vBCSuaGia");
        }
        private void dtTuNgay_ValueChanged(object sender, EventArgs e)
        {
            if (cboKyBaoCao.Text=="Ngày")
                dtDenNgay.Value = dtTuNgay.Value;
        }

        private void cboTrungTam_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT IdKho,TenKho FROM tbl_DM_Kho WHERE sudung=1 and IdTrungTam=" + cboTrungTam.SelectedValue.ToString() +
              " and (IdKho in (Select IdKho From tbl_Kho_NhanVien Where IdNhanVien in " +
                "(Select IdNhanVien From tbl_DM_NguoiDung Where IdNguoiDung=" + Declare.UserId + ")) or ('admin'='" + Declare.UserName.ToLower() + "'))";

            ut.LoadComboBox(cboKho, sql);//, 0, "");
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
//                sql = @"SELECT  distinct   dbo.tbl_DM_NhanVien.IdNhanVien, dbo.tbl_DM_NhanVien.HoTen
//                    FROM         dbo.tbl_DM_NhanVien INNER JOIN
//                                          dbo.tbl_Kho_NhanVien ON dbo.tbl_DM_NhanVien.IdNhanVien = dbo.tbl_Kho_NhanVien.IdNhanVien
//                    WHERE     dbo.tbl_Kho_NhanVien.IdKho = " + cboKho.SelectedValue.ToString();
//                ut.LoadComboBox(cboNhanVien, sql, 0, "");
                //LaySoPhieu(ut.getInt(cboKho.SelectedValue));
            }
            else
            {
                cboSanPham.DataSource = null;
                //LaySoPhieu(0);
            }
        }
    }
}