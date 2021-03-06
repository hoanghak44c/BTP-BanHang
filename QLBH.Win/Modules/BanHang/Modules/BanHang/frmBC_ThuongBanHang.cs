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
    public partial class frmBC_ThuongBanHang : frmBCBase
    {
        Utils ut = new Utils();
        public frmBC_ThuongBanHang()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            //optChiTiet.Checked = true;
            
        }


        private void frm_ThuongBanHang_Load(object sender, EventArgs e)
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
            dtTuNgay.Value = new DateTime(DateTime.Today.Year, 1, 1);
            dtDenNgay.Enabled = false;
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

        private void cboKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Thay doi cboSanPham
            string sql;
            if (cboKho.SelectedIndex >= 0)
            {
                sql = @"SELECT distinct dbo.tbl_SanPham.IdSanPham, dbo.tbl_SanPham.TenSanPham
                            FROM dbo.tbl_HangHoa_Chitiet INNER JOIN  dbo.tbl_SanPham ON dbo.tbl_HangHoa_Chitiet.IdSanPham = dbo.tbl_SanPham.IdSanPham
                            Where IdKho=" + cboKho.SelectedValue.ToString();
                ut.LoadComboBox(cboSanPham, sql, 0, "");
                sql = @"SELECT  distinct   dbo.tbl_DM_NhanVien.IdNhanVien, dbo.tbl_DM_NhanVien.HoTen
                    FROM         dbo.tbl_DM_NhanVien INNER JOIN
                                          dbo.tbl_Kho_NhanVien ON dbo.tbl_DM_NhanVien.IdNhanVien = dbo.tbl_Kho_NhanVien.IdNhanVien
                    WHERE     dbo.tbl_Kho_NhanVien.IdKho = " + cboKho.SelectedValue.ToString() + " order by dbo.tbl_DM_NhanVien.HoTen ";
                ut.LoadComboBox(cboNhanVien, sql, 0, "");
            }
            else
            {
                sql = @"SELECT distinct dbo.tbl_SanPham.IdSanPham, dbo.tbl_SanPham.TenSanPham
                            FROM dbo.tbl_HangHoa_Chitiet INNER JOIN  dbo.tbl_SanPham ON dbo.tbl_HangHoa_Chitiet.IdSanPham = dbo.tbl_SanPham.IdSanPham";
                if (cboTrungTam.SelectedIndex > 0)
                    sql += string.Format(" WHERE  IdKho IN (SELECT IdKho FROM tbl_DM_Kho WHERE IdTrungTam={0})", cboTrungTam.SelectedValue);
                ut.LoadComboBox(cboSanPham, sql, 0, "");

                sql = @"SELECT  distinct   dbo.tbl_DM_NhanVien.IdNhanVien, dbo.tbl_DM_NhanVien.HoTen
                    FROM         dbo.tbl_DM_NhanVien INNER JOIN
                                          dbo.tbl_Kho_NhanVien ON dbo.tbl_DM_NhanVien.IdNhanVien = dbo.tbl_Kho_NhanVien.IdNhanVien";
                if (cboTrungTam.SelectedIndex > 0)
                    sql += string.Format(" WHERE  IdKho IN (SELECT IdKho FROM tbl_DM_Kho WHERE IdTrungTam={0})", cboTrungTam.SelectedValue);
                sql += " order by dbo.tbl_DM_NhanVien.HoTen ";
                ut.LoadComboBox(cboNhanVien, sql, 0, "");
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
            //{
            //    string sql = "SELECT IdKho,TenKho FROM tbl_DM_Kho";
            //    ut.LoadComboBox(cboKho, sql, 0, "");
            //}
        }

        private void cmdThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdIn_Click(object sender, EventArgs e)
        {
            if (optChiTiet.Checked)
                rpt = new rpt_BC_ThuongNhanVien();
            else if (rdNhanVien.Checked)
                rpt = new rpt_BC_ThuongNhanVien_CT();
            else
                rpt = new rpt_BC_ThuongNhanVien_TongHop();

            try {
                ShowReport("Báo cáo thưởng nhân viên");
            }
            catch (System.Exception ex) {
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
        }

        protected override void OnSetParameterFields(ParameterFields myParams) {
            myParams.Clear();
            ut.SetParameterReport(myParams, "pTrungTam", cboTrungTam.Text);
            ut.SetParameterReport(myParams, "pKho", cboKho.Text);
            ut.SetParameterReport(myParams, "pThoiGian", String.Format("Từ ngày {0} đến ngày {1}", dtTuNgay.Value.ToString("dd/MM/yyyy"), dtDenNgay.Value.ToString("dd/MM/yyyy")));
        }

        protected override string OnSetSqlParameters(string cmdTextFormatString)
        {
//            cmdTextFormatString += string.Format(@" (TyLeThuong IS NOT NULL AND TyLeThuong <> 0 
//                            and LoaiXuatNhap IN ({0},{1}))", (int)TransactionType.XUAT_BAN, (int)TransactionType.NHAP_TRA_LAI);
            cmdTextFormatString += string.Format(@" (LoaiXuatNhap IN ({0},{1}))", (int)TransactionType.XUAT_BAN, (int)TransactionType.NHAP_TRA_LAI);
            if (cboTrungTam.SelectedIndex >= 0)
                cmdTextFormatString += " and IdTrungTam=" + cboTrungTam.SelectedValue.ToString();
            if (cboKho.SelectedIndex >= 0)
                cmdTextFormatString += " and IdKho=" + cboKho.SelectedValue.ToString();
            if (cboNhanVien.SelectedIndex > 0)
                cmdTextFormatString += " and IdNhanVien=" + cboNhanVien.SelectedValue.ToString();
            if (cboSanPham.SelectedIndex > 0)
                cmdTextFormatString += " and IdSanPham=" + cboSanPham.SelectedValue.ToString();
            if (ut.isStringNotEmpty(txtTenSanPham.Text))
                cmdTextFormatString += string.Format(" and (TenSanPham like N'%{0}%' or MaSanPham like '%{0}%') ", txtTenSanPham.Text.Trim());

            cmdTextFormatString += string.Format(" and NgayXuat>='{0}' and NgayXuat<='{1} 23:59'", ut.DateToString(dtTuNgay.Value), ut.DateToString(dtDenNgay.Value));
            cmdTextFormatString += " ORDER BY HoTen";
            return cmdTextFormatString;
        }


        protected override void OnLoadReport()
        {
            string sql = "SELECT * FROM vBaoCaoThuongBanHang WHERE ";
            base.SetParameterFields();
            base.SetSqlParameters(sql, CommandType.Text, "vBaoCaoThuongBanHang");
        }
        private void dtTuNgay_ValueChanged(object sender, EventArgs e)
        {
            if (cboKyBaoCao.Text=="Ngày")
                dtDenNgay.Value = dtTuNgay.Value;
        }

    }
}