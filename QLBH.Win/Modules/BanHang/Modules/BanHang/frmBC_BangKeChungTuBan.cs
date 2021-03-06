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
    public partial class frmBC_BangKeChungTuBan : frmBCBase
    {
        Utils ut = new Utils();

        public frmBC_BangKeChungTuBan()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            rpt = new rpt_BC_BangKeChungTuBan();
        }


        private void frmBC_BangKeChungTuBan_Load(object sender, EventArgs e)
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
            rptBanHang.Checked = true;
            
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
        string TieuDe;
        int LoaiChungTu;
        private void cmdIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (rptBanHang.Checked)
                {
                    TieuDe = "(Xuất bán)";
                    LoaiChungTu = (int)TransactionType.XUAT_BAN;
                }
                else
                {
                    TieuDe = "(Khuyến mại)";
                    LoaiChungTu = (int)TransactionType.XUAT_KHUYEN_MAI;
                }
                ShowReport("Bảng kê chứng từ hàng hóa, dịch vụ bán ra");
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
        
        protected override void OnSetParameterFields(ParameterFields myParams){
            myParams.Clear();
            ut.SetParameterReport(myParams, "pTrungTam", cboTrungTam.Text);
            ut.SetParameterReport(myParams, "pKho", cboKho.Text);
            ut.SetParameterReport(myParams, "pTuNgay", dtTuNgay.Value.ToString("dd/MM/yyyy"));
            ut.SetParameterReport(myParams, "pDenNgay", dtDenNgay.Value.ToString("dd/MM/yyyy"));
            ut.SetParameterReport(myParams, "pTieuDe",TieuDe);
            
        }
        protected override string OnSetSqlParameters(string cmdTextFormatString)
        {
            cmdTextFormatString += string.Format("(LoaiChungTu={0})", LoaiChungTu);
            if (cboTrungTam.SelectedIndex >= 0)
                cmdTextFormatString += " and tbl_DM_Kho.IdTrungTam=" + cboTrungTam.SelectedValue.ToString();
            if (cboKho.SelectedIndex >= 0)
                cmdTextFormatString += " and dbo.tbl_DM_Kho.IdKho=" + cboKho.SelectedValue.ToString();
            cmdTextFormatString += string.Format(" and tbl_ChungTu.NgayLap>='{0}' and tbl_ChungTu.NgayLap<='{1} 23:59'", ut.DateToString(dtTuNgay.Value), ut.DateToString(dtDenNgay.Value));
            //if (ut.isStringNotEmpty(txtTenSanPham.Text))
            //    cmdTextFormatString += string.Format(" and tbl_SanPham.TenSanPham like N'%{0}%' or tbl_SanPham.MaSanPham like '%{0}%'", txtTenSanPham.Text.Trim());
            cmdTextFormatString += string.Format(" Order by tbl_ChungTu.NgayLap desc, tbl_ChungTu.Soseri desc ");
            return cmdTextFormatString;
        }
        protected override void OnLoadReport()
        {
            string sql = string.Format(@"SELECT     dbo.tbl_SanPham.MaSanPham, dbo.tbl_SanPham.TenSanPham, dbo.tbl_ChungTu.NgayLap, dbo.tbl_ChungTu_Chitiet.SoLuong, 
                      dbo.tbl_ChungTu_Chitiet.DonGia, dbo.tbl_ChungTu_Chitiet.ThanhTien, (dbo.tbl_ChungTu_Chitiet.SoLuong * dbo.tbl_ChungTu_Chitiet.DonGia) 
                      * (1 - dbo.tbl_ChungTu_Chitiet.TyLeChietKhau) AS ThanhTienChuaVAT, dbo.tbl_ChungTu_Chitiet.TienChietKhau, 
                      (dbo.tbl_ChungTu_Chitiet.SoLuong * dbo.tbl_ChungTu_Chitiet.DonGia) * (1 - dbo.tbl_ChungTu_Chitiet.TyLeChietKhau) 
                      * dbo.tbl_ChungTu.TyleVAT AS TienVAT, dbo.tbl_DM_DoiTuong.TenDoiTuong, dbo.tbl_ChungTu.MaSoThue, dbo.tbl_ChungTu.SoSeri, 
                      dbo.tbl_ChungTu.TyleVAT, dbo.tbl_ChungTu.SoChungTu, dbo.tbl_PhieuXuat.SoPhieuXuat
FROM         dbo.tbl_PhieuXuat RIGHT OUTER JOIN
                      dbo.tbl_DM_DoiTuong INNER JOIN
                      dbo.tbl_ChungTu_Chitiet INNER JOIN
                      dbo.tbl_ChungTu ON dbo.tbl_ChungTu_Chitiet.IdChungTu = dbo.tbl_ChungTu.IdChungTu INNER JOIN
                      dbo.tbl_DM_Kho ON dbo.tbl_ChungTu.IdKho = dbo.tbl_DM_Kho.IdKho INNER JOIN
                      dbo.tbl_DM_TrungTam ON dbo.tbl_DM_Kho.IdTrungTam = dbo.tbl_DM_TrungTam.IdTrungTam ON 
                      dbo.tbl_DM_DoiTuong.IdDoiTuong = dbo.tbl_ChungTu.IdDoiTuong ON dbo.tbl_PhieuXuat.IdPhieuXuat = dbo.tbl_ChungTu.IdPhieuXuat LEFT OUTER JOIN
                      dbo.tbl_SanPham ON dbo.tbl_ChungTu_Chitiet.IdSanPham = dbo.tbl_SanPham.IdSanPham");
            sql += " WHERE ";
            base.SetParameterFields();
            base.SetSqlParameters(sql, CommandType.Text, "vBCBangKeChungTuBan");
        }
        private void dtTuNgay_ValueChanged(object sender, EventArgs e)
        {
            if (cboKyBaoCao.Text=="Ngày")
                dtDenNgay.Value = dtTuNgay.Value;
        }
    }
}