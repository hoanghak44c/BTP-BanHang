using System;
using System.Data;
using System.Windows.Forms;
using QLBanHang.Modules.BanHang.Reports;
using CrystalDecisions.Shared;
using QLBH.Common;
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBC_DoanhThuBanHang : frmBCBase
    {       
        
        Utils ut = new Utils();

        public frmBC_DoanhThuBanHang()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            rpt = new rptBC_DoanhThuBanHang();
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
        
        private void cboTrungTam_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT IdKho,TenKho FROM tbl_DM_Kho WHERE sudung=1 and IdTrungTam=" + cboTrungTam.SelectedValue.ToString() +
                          " and (IdKho in (Select IdKho From tbl_Kho_NhanVien Where IdNhanVien in " +
                            "(Select IdNhanVien From tbl_DM_NguoiDung Where IdNguoiDung=" + Declare.UserId + ")) or ('admin'='" + Declare.UserName.ToLower() + "'))";

            ut.LoadComboBox(cboKho, sql);//, 0, "");
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
        protected override void OnSetParameterFields(ParameterFields myParams){
            myParams.Clear();
            ut.SetParameterReport(myParams, "pTrungTam", cboTrungTam.Text);
            ut.SetParameterReport(myParams, "pDate", String.Format("Từ ngày {0} đến ngày {1}", dtTuNgay.Value.ToString("dd/MM/yyyy"), dtDenNgay.Value.ToString("dd/MM/yyyy")));
        }

        protected override string OnSetSqlParameters(string cmdTextFormatString)
        {
            cmdTextFormatString += string.Format("NgayLap>='{0}' and NgayLap<='{1} 23:59'", ut.DateToString(dtTuNgay.Value), ut.DateToString(dtDenNgay.Value));
            if (cboTrungTam.SelectedIndex >= 0)
                cmdTextFormatString += " and dbo.tbl_DM_TrungTam.IdTrungTam=" + cboTrungTam.SelectedValue.ToString();
            if (cboKho.SelectedIndex >= 0)
                cmdTextFormatString += string.Format(" and dbo.tbl_DM_Kho.IdKho={0}", cboKho.SelectedValue);
            if (cboLoaiGD.SelectedIndex==1)
                cmdTextFormatString += string.Format(" and LoaiChungTu in ({0}, {1})", (int)TransactionType.XUAT_BAN, (int)TransactionType.XUAT_KHUYEN_MAI);
            else if (cboLoaiGD.SelectedIndex == 2)
                cmdTextFormatString += string.Format(" and LoaiChungTu in ({0}, {1})", (int)TransactionType.NHAP_TRA_LAI, (int)TransactionType.TRA_LAI_KHUYEN_MAI);
            else
                cmdTextFormatString += string.Format(" and LoaiChungTu in ({0}, {1}, {2}, {3})", (int)TransactionType.XUAT_BAN, (int)TransactionType.XUAT_KHUYEN_MAI, (int)TransactionType.NHAP_TRA_LAI, (int)TransactionType.TRA_LAI_KHUYEN_MAI);
            return cmdTextFormatString;
        }

        protected override void OnLoadReport()
        {
            string sql = string.Format(@"SELECT     dbo.tbl_ChungTu.LoaiChungTu, dbo.tbl_ChungTu.NgayLap, CASE WHEN LoaiChungTu = 1 OR
                      LoaiChungTu = 9 THEN dbo.tbl_ChungTu.SoSeri WHEN LoaiChungTu = 3 OR
                      LoaiChungTu = 10 THEN dbo.tbl_ChungTu.SoChungTuTraLai END AS SoSeri, dbo.tbl_ChungTu.HoTen + ' - ' + dbo.tbl_ChungTu.GhiChu AS TenDoiTuong,
                       CASE LoaiChungTu WHEN 1 THEN N'Xuất bán' WHEN 9 THEN N'Khuyến mại' WHEN 3 THEN N'Nhập trả lại' WHEN 10 THEN N'Nhập lại khuyến mại' END
                       AS DienGiai, dbo.tbl_ChungTu.TongTienThanhToan * CASE WHEN LoaiChungTu = 1 OR
                      LoaiChungTu = 9 THEN 1 WHEN LoaiChungTu = 3 OR
                      LoaiChungTu = 10 THEN - 1 END AS TienPhaiThu, (dbo.tbl_ChungTu.TongTienThanhToan - ISNULL(dbo.tbl_ChungTu.TienConNo, 0)) 
                      * CASE WHEN LoaiChungTu = 1 OR
                      LoaiChungTu = 9 THEN 1 WHEN LoaiChungTu = 3 OR
                      LoaiChungTu = 10 THEN - 1 END AS TienDaThu, ISNULL(dbo.tbl_ChungTu.TienConNo, 0) * CASE WHEN LoaiChungTu = 1 OR
                      LoaiChungTu = 9 THEN 1 WHEN LoaiChungTu = 3 OR
                      LoaiChungTu = 10 THEN - 1 END AS ConLai, dbo.tbl_DM_Kho.IdKho, dbo.tbl_DM_Kho.TenKho, dbo.tbl_DM_Kho.IdTrungTam, 
                      dbo.tbl_DM_TrungTam.TenTrungTam
FROM         dbo.tbl_ChungTu INNER JOIN
                      dbo.tbl_DM_DoiTuong ON dbo.tbl_DM_DoiTuong.IdDoiTuong = dbo.tbl_ChungTu.IdDoiTuong INNER JOIN
                      dbo.tbl_DM_Kho ON dbo.tbl_DM_Kho.IdKho = dbo.tbl_ChungTu.IdKho INNER JOIN
                      dbo.tbl_DM_TrungTam ON dbo.tbl_DM_TrungTam.IdTrungTam = dbo.tbl_DM_Kho.IdTrungTam");
            sql += " WHERE ";
            base.SetParameterFields();
            base.SetSqlParameters(sql, CommandType.Text, "vBaoCaoDoanhThu");
        }
        private void dtTuNgay_ValueChanged(object sender, EventArgs e)
        {
            if (cboKyBaoCao.Text=="Ngày")
                dtDenNgay.Value = dtTuNgay.Value;
        }
    }
}