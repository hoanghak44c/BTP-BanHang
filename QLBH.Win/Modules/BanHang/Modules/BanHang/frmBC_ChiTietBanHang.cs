using System;
using System.Data;
using System.Windows.Forms;
using QLBanHang.Modules.BanHang.Reports;
using CrystalDecisions.Shared;
using QLBH.Common;
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBC_ChiTietBanHang : frmBCBase
    {
        Utils ut = new Utils();
        string TieuDe;
        public frmBC_ChiTietBanHang()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            rpt = new rpt_BC_BanHang();
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
            sql = string.Format(@"SELECT IdDoiTuong, TenDoiTuong  FROM tbl_DM_DoiTuong
                  WHERE Type IN ({0},{1})", (int)CustomerType.KHACH_HANG, (int)CustomerType.DAI_LY);
            ut.LoadComboBox(cboKhachHang, sql, 0, "");
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
        }
        private bool LaySoPhieu(int pIdKho)
        {
            string sql;
            string dk = string.Format("LoaiChungTu={0}", (int)TransactionType.XUAT_BAN);
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

        private void cboKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Thay doi cboSanPham
            if (cboKho.SelectedIndex >= 0)
            {
                string sql = @"SELECT distinct dbo.tbl_SanPham.IdSanPham, dbo.tbl_SanPham.TenSanPham
                            FROM dbo.tbl_HangHoa_Chitiet INNER JOIN  dbo.tbl_SanPham ON dbo.tbl_HangHoa_Chitiet.IdSanPham = dbo.tbl_SanPham.IdSanPham
                            Where IdKho=" + cboKho.SelectedValue.ToString();
                ut.LoadComboBox(cboSanPham, sql, 0, "");
                sql = @"SELECT  distinct   dbo.tbl_DM_NhanVien.IdNhanVien, dbo.tbl_DM_NhanVien.HoTen
                    FROM         dbo.tbl_DM_NhanVien INNER JOIN
                                          dbo.tbl_Kho_NhanVien ON dbo.tbl_DM_NhanVien.IdNhanVien = dbo.tbl_Kho_NhanVien.IdNhanVien
                    WHERE     dbo.tbl_Kho_NhanVien.IdKho = " + cboKho.SelectedValue.ToString();
                ut.LoadComboBox(cboNhanVien, sql, 0, "");
                LaySoPhieu(ut.getInt(cboKho.SelectedValue));
            }
            else
            {
                cboSanPham.DataSource = null;
                LaySoPhieu(0);
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
                if (rptBanHang.Checked) {
                    TieuDe = "BÁO CÁO BÁN HÀNG";
                }
                else {
                    TieuDe = "BÁO CÁO KHUYẾN MẠI";
                }
                ShowReport(TieuDe);
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
            ut.SetParameterReport(myParams, "pTrungTam", cboTrungTam.Text);
            ut.SetParameterReport(myParams, "pKho", cboKho.Text);
            ut.SetParameterReport(myParams, "pTuNgay", dtTuNgay.Value.ToString("dd/MM/yyyy"));
            ut.SetParameterReport(myParams, "pDenNgay", dtDenNgay.Value.ToString("dd/MM/yyyy"));
            ut.SetParameterReport(myParams, "pTieuDe", TieuDe);
        }

        protected override string OnSetSqlParameters(string cmdTextFormatString)
        {
            if (rptBanHang.Checked) {
                cmdTextFormatString += string.Format("LoaiChungTu={0}", (int)TransactionType.XUAT_BAN);
            }
            else {
                cmdTextFormatString += string.Format("LoaiChungTu={0}", (int)TransactionType.XUAT_KHUYEN_MAI);
            }
            if (cboTrungTam.SelectedIndex >= 0)
                cmdTextFormatString += " and tbl_DM_Kho.IdTrungTam=" + cboTrungTam.SelectedValue.ToString();
            if (cboKho.SelectedIndex >= 0)
                cmdTextFormatString += " and tbl_HangHoa_Chitiet.IdKho=" + cboKho.SelectedValue.ToString();
            if (cboKhachHang.SelectedIndex > 0 && rptKH.Checked)
                cmdTextFormatString += " and tbl_DM_DoiTuong.IdDoiTuong=" + cboKhachHang.SelectedValue.ToString();
            if (cboNhanVien.SelectedIndex > 0 && rptNV.Checked)
                cmdTextFormatString += " and tbl_ChungTu.IdNhanVien=" + cboNhanVien.SelectedValue.ToString();
            if (cboSanPham.SelectedIndex > 0)
                cmdTextFormatString += " and tbl_SanPham.IdSanPham=" + cboSanPham.SelectedValue.ToString();
            if (ut.isStringNotEmpty(txtTenSanPham.Text))
                cmdTextFormatString += string.Format(" and (tbl_SanPham.TenSanPham like N'%{0}%' or tbl_SanPham.MaSanPham like '%{0}%') ", txtTenSanPham.Text.Trim());
            if (ut.isStringNotEmpty(txtSophieu.Text))
                cmdTextFormatString += string.Format(" and tbl_ChungTu.SoChungTu='{0}'", txtSophieu.Text.Trim());
            cmdTextFormatString += string.Format(" and tbl_ChungTu.NgayLap>='{0}' and tbl_ChungTu.NgayLap<='{1} 23:59'", ut.DateToString(dtTuNgay.Value), ut.DateToString(dtDenNgay.Value));
            return cmdTextFormatString;
        }
        protected override void OnLoadReport()
        {
            string sql;
            if (rptNV.Checked)
                sql = @"SELECT     dbo.tbl_SanPham.MaSanPham, dbo.tbl_SanPham.TenSanPham, dbo.tbl_ChungTu.NgayLap, dbo.tbl_ChungTu_Chitiet.SoLuong, 
                      dbo.tbl_ChungTu_Chitiet.DonGia, dbo.tbl_ChungTu_Chitiet.ThanhTien, dbo.tbl_ChungTu_Chitiet.TienChietKhau, 
                      dbo.tbl_DM_NhanVien.HoTen AS TenDoiTuong,   (dbo.tbl_ChungTu_Chitiet.SoLuong * dbo.tbl_ChungTu_Chitiet.DonGia-dbo.tbl_ChungTu_Chitiet.TienChietKhau) * dbo.tbl_ChungTu.TyleVAT AS TienVAT, 
                      dbo.tbl_ChungTu.LoaiChungTu, dbo.tbl_HangHoa_Chitiet.MaVach, dbo.tbl_DM_DonViTinh.TenDonViTinh, 
                        (dbo.tbl_ChungTu_Chitiet.SoLuong * dbo.tbl_ChungTu_Chitiet.DonGia - dbo.tbl_ChungTu_Chitiet.TienChietKhau) * (1 + dbo.tbl_ChungTu.TyleVAT) 
                      AS ThanhTienCoVAT
FROM         dbo.tbl_HangHoa_Chitiet RIGHT OUTER JOIN
                      dbo.tbl_ChungTu_ChiTiet_HangHoa ON dbo.tbl_HangHoa_Chitiet.IdChiTiet = dbo.tbl_ChungTu_ChiTiet_HangHoa.IdChiTietHangHoa RIGHT OUTER JOIN
                      dbo.tbl_DM_NhanVien INNER JOIN
                      dbo.tbl_ChungTu_Chitiet INNER JOIN
                      dbo.tbl_ChungTu ON dbo.tbl_ChungTu_Chitiet.IdChungTu = dbo.tbl_ChungTu.IdChungTu INNER JOIN
                      dbo.tbl_DM_Kho ON dbo.tbl_ChungTu.IdKho = dbo.tbl_DM_Kho.IdKho INNER JOIN
                      dbo.tbl_DM_TrungTam ON dbo.tbl_DM_Kho.IdTrungTam = dbo.tbl_DM_TrungTam.IdTrungTam ON 
                      dbo.tbl_DM_NhanVien.IdNhanVien = dbo.tbl_ChungTu.IdNhanVien ON 
                      dbo.tbl_ChungTu_ChiTiet_HangHoa.IdChiTietChungTu = dbo.tbl_ChungTu_Chitiet.IdChitiet LEFT OUTER JOIN
                      dbo.tbl_SanPham INNER JOIN
                      dbo.tbl_DM_DonViTinh ON dbo.tbl_SanPham.IdDonViTinh = dbo.tbl_DM_DonViTinh.IdDonViTinh ON 
                      dbo.tbl_ChungTu_Chitiet.IdSanPham = dbo.tbl_SanPham.IdSanPham";
            else
                sql = @"SELECT     dbo.tbl_SanPham.MaSanPham, dbo.tbl_SanPham.TenSanPham, dbo.tbl_ChungTu.NgayLap, dbo.tbl_ChungTu_Chitiet.SoLuong, 
                      dbo.tbl_ChungTu_Chitiet.DonGia, dbo.tbl_ChungTu_Chitiet.ThanhTien, dbo.tbl_ChungTu_Chitiet.TienChietKhau, 
                      ((dbo.tbl_ChungTu_Chitiet.SoLuong * dbo.tbl_ChungTu_Chitiet.DonGia) 
                      * (1 - dbo.tbl_ChungTu_Chitiet.TyLeChietKhau)) * dbo.tbl_ChungTu.TyleVAT AS TienVAT, 
                      dbo.tbl_DM_DoiTuong.TenDoiTuong, dbo.tbl_HangHoa_Chitiet.MaVach, dbo.tbl_DM_DonViTinh.TenDonViTinh,
                       ((dbo.tbl_ChungTu_Chitiet.SoLuong * dbo.tbl_ChungTu_Chitiet.DonGia) 
                      * (1 - dbo.tbl_ChungTu_Chitiet.TyLeChietKhau)) * (1 + dbo.tbl_ChungTu.TyleVAT) AS ThanhTienCoVAT
FROM         dbo.tbl_HangHoa_Chitiet RIGHT OUTER JOIN
                      dbo.tbl_ChungTu_ChiTiet_HangHoa RIGHT OUTER JOIN
                      dbo.tbl_SanPham INNER JOIN
                      dbo.tbl_DM_DonViTinh ON dbo.tbl_SanPham.IdDonViTinh = dbo.tbl_DM_DonViTinh.IdDonViTinh INNER JOIN
                      dbo.tbl_DM_DoiTuong INNER JOIN
                      dbo.tbl_ChungTu_Chitiet INNER JOIN
                      dbo.tbl_ChungTu ON dbo.tbl_ChungTu_Chitiet.IdChungTu = dbo.tbl_ChungTu.IdChungTu INNER JOIN
                      dbo.tbl_DM_Kho ON dbo.tbl_ChungTu.IdKho = dbo.tbl_DM_Kho.IdKho INNER JOIN
                      dbo.tbl_DM_TrungTam ON dbo.tbl_DM_Kho.IdTrungTam = dbo.tbl_DM_TrungTam.IdTrungTam ON 
                      dbo.tbl_DM_DoiTuong.IdDoiTuong = dbo.tbl_ChungTu.IdDoiTuong ON dbo.tbl_SanPham.IdSanPham = dbo.tbl_ChungTu_Chitiet.IdSanPham ON 
                      dbo.tbl_ChungTu_ChiTiet_HangHoa.IdChiTietChungTu = dbo.tbl_ChungTu_Chitiet.IdChitiet ON 
                      dbo.tbl_HangHoa_Chitiet.IdChiTiet = dbo.tbl_ChungTu_ChiTiet_HangHoa.IdChiTietHangHoa";

            sql += " WHERE ";
            base.SetParameterFields();
            base.SetSqlParameters(sql, CommandType.Text, "vBaoCaoBanHang");
        }
        private void dtTuNgay_ValueChanged(object sender, EventArgs e)
        {
            if (cboKyBaoCao.Text=="Ngày")
                dtDenNgay.Value = dtTuNgay.Value;
        }
    }
}