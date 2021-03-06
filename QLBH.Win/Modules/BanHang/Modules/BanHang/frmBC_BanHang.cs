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
    public partial class frmBC_BanHang : frmBCBase
    {
        Utils ut = new Utils();
        string TieuDe;
        int idKho;
        DateTime dtTu, dtDen;
        public frmBC_BanHang()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            
        }


        private void frm_BaoCaoBanHang_Load(object sender, EventArgs e)
        {
            string sql;
            //sql = @"SELECT     IdTrungTam, TenTrungTam FROM tbl_DM_TrungTam";
            sql = @"SELECT  IdTrungTam, TenTrungTam FROM tbl_DM_TrungTam where SuDung=1 and (IdTrungTam in
                    (Select IdTrungTam From tbl_DM_Kho Where IdKho in
                    (Select IdKho From tbl_Kho_NhanVien Where IdNhanVien in
                    (Select IdNhanVien From tbl_DM_NguoiDung Where IdNguoiDung=" + Declare.UserId + "))) or ('admin'='" + Declare.UserName.ToLower() + "'))";
            string[] fields = { "IdTrungTam", "TenTrungTam" };
            string[] types = { "System.Int32", "System.String" };
            DataTable dt = DBTools.LoadDanhMuc(sql, "tbl_DM_TrungTam", fields, types);

            if (Declare.UserName.ToLower().Equals("admin"))
                ut.LoadComboBox(cboTrungTam, dt, 0, "");
            else
                ut.LoadComboBox1(cboTrungTam, dt);

            sql = string.Format(@"SELECT IdDoiTuong, TenDoiTuong  FROM tbl_DM_DoiTuong
                  WHERE Type IN ({0},{1}) and SuDung=1 ORDER BY TenDoiTuong", (int)CustomerType.KHACH_HANG, (int)CustomerType.DAI_LY);
            string[] fields1 = { "IdDoiTuong", "TenDoiTuong" };
            dt = DBTools.LoadDanhMuc(sql, "tbl_DM_DoiTuong", fields1, types);

            ut.LoadComboBox(cboKhachHang, dt, 0, "");
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
                //string[] fields = { "IdNhanVien", "HoTen" };
                //string[] types = { "System.Int32", "System.String" };
                //DataTable dt = DBTools.LoadDanhMuc(sql, "tbl_DM_NhanVien", fields, types);

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

            //string[] fields = { "IdKho", "TenKho" };
            //string[] types = { "System.Int32", "System.String" };
            //DataTable dt = DBTools.LoadDanhMuc(sql, "tbl_DM_Kho", fields, types);

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
                idKho = Common.IntValue(cboKho.SelectedValue);
                dtTu = dtTuNgay.Value;
                dtDen = dtDenNgay.Value;

                if (rptBanHang.Checked) {
                    TieuDe = "BÁO CÁO BÁN HÀNG";
                }
                else {
                    TieuDe = "BÁO CÁO KHUYẾN MẠI";
                }
                if (optSoHoaDon.Checked)
                    rpt = new rpt_BC_BanHang_HoangTK();
                else if (rdNhanVien.Checked)
                    rpt = new rpt_BC_BanHang_TheoNhanVien();
                else
                    rpt = new rpt_BC_BanHang_TheoMaHang_HoangTK();

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
                cmdTextFormatString += string.Format("LoaiChungTu in ({0}, {1})", (int)TransactionType.XUAT_BAN, (int)TransactionType.NHAP_TRA_LAI);
            }
            else {
                cmdTextFormatString += string.Format("LoaiChungTu in ({0}, {1})", (int)TransactionType.XUAT_KHUYEN_MAI, (int)TransactionType.TRA_LAI_KHUYEN_MAI);
            }
            //if (cboTrungTam.SelectedIndex >= 0)
            //    cmdTextFormatString += " and IdTrungTam=" + cboTrungTam.SelectedValue.ToString();
            //if (cboKho.SelectedIndex >= 0)
            //    cmdTextFormatString += " and IdKho=" + cboKho.SelectedValue.ToString();
            if (cboKhachHang.SelectedIndex > 0)
                cmdTextFormatString += " and IdDoiTuong=" + cboKhachHang.SelectedValue.ToString();
            if (cboNhanVien.SelectedIndex > 0)
                cmdTextFormatString += " and IdNhanVien=" + cboNhanVien.SelectedValue.ToString();
            if (cboSanPham.SelectedIndex > 0)
                cmdTextFormatString += " and IdSanPham=" + cboSanPham.SelectedValue.ToString();
            if (ut.isStringNotEmpty(txtTenSanPham.Text))
                cmdTextFormatString += string.Format(" and (TenSanPham like N'%{0}%' or MaSanPham like '%{0}%') ", txtTenSanPham.Text.Trim());
            if (ut.isStringNotEmpty(txtSophieu.Text))
                cmdTextFormatString += string.Format(" and SoSerie like'%{0}%'", txtSophieu.Text.Trim());
            //cmdTextFormatString += string.Format(" and NgayLap>='{0}' and NgayLap<='{1} 23:59'", ut.DateToString(dtTuNgay.Value), ut.DateToString(dtDenNgay.Value));
            if (optSoHoaDon.Checked)
                cmdTextFormatString += " ORDER BY  SoSerie";
            else
                cmdTextFormatString += " ORDER BY  MaSanPham";

            cmdTextFormatString += " , TenDoiTuong";
            
            return cmdTextFormatString;//
        }
        protected override void OnLoadReport()
        {
            string sql;
            sql = String.Format(@"SELECT * FROM
                        (SELECT kh.IdKho, ctct.IdSanPham, sp.MaSanPham, sp.TenSanPham, ct.NgayLap, ctct.SoLuong, ctct.DonGia, ctct.TienChietKhau, ct.IdDoiTuong, ct.IdNhanVien,
		                        nv.HoTen AS TenDoiTuong, ct.LoaiChungTu, ctct.SoLuong * ctct.DonGia - ctct.TienChietKhau AS ThanhTienChuaVAT, 
		                        px.SoOrderKH, ct.SoSeri as SoSerie, dt.TenDoiTuong AS KhachHang, sp.GiaNhap * ctct.SoLuong AS GiaVon
                        FROM    tbl_ChungTu_Chitiet ctct INNER JOIN tbl_ChungTu ct ON ctct.IdChungTu = ct.IdChungTu and ct.IdKho = {0} and ct.NgayLap>='{1}' and ct.NgayLap<='{2} 23:59'
		                        INNER JOIN tbl_DM_Kho kh ON ct.IdKho = kh.IdKho 
		                        LEFT OUTER JOIN tbl_DM_NhanVien nv ON nv.IdNhanVien = ct.IdNhanVien 
		                        INNER JOIN tbl_DM_DoiTuong dt ON ct.IdDoiTuong = dt.IdDoiTuong 
		                        LEFT OUTER JOIN tbl_SanPham sp ON ctct.IdSanPham = sp.IdSanPham 
		                        INNER JOIN tbl_DM_DonViTinh dvt ON sp.IdDonViTinh = dvt.IdDonViTinh 
		                        INNER JOIN tbl_PhieuXuat px ON px.IdPhieuXuat = ct.IdPhieuXuat 
                        WHERE ct.IdPhieuXuat > 0
                        UNION ALL
                        SELECT  kh.IdKho, ctct.IdSanPham, sp.MaSanPham, sp.TenSanPham, ct.NgayLap, ctct.SoLuong, ctct.DonGia, ctct.TienChietKhau, ct.IdDoiTuong, ct.IdNhanVien, 
		                        nv.HoTen AS TenDoiTuong, ct.LoaiChungTu, ctct.SoLuong * ctct.DonGia - ctct.TienChietKhau AS ThanhTienChuaVAT, 
		                        N'Xuất gộp' AS SoOrderKH, ct.SoSeri as SoSerie, dt.TenDoiTuong AS KhachHang, sp.GiaNhap * ctct.SoLuong AS GiaVon
                        FROM    tbl_ChungTu_Chitiet ctct INNER JOIN tbl_ChungTu ct ON ctct.IdChungTu = ct.IdChungTu and ct.IdKho = {0} and ct.NgayLap>='{1}' and ct.NgayLap<='{2} 23:59'
		                        INNER JOIN tbl_DM_Kho kh ON ct.IdKho = kh.IdKho 
		                        LEFT OUTER JOIN tbl_DM_NhanVien nv ON nv.IdNhanVien = ct.IdNhanVien 
		                        INNER JOIN tbl_DM_DoiTuong dt ON ct.IdDoiTuong = dt.IdDoiTuong 
		                        LEFT OUTER JOIN tbl_SanPham sp ON ctct.IdSanPham = sp.IdSanPham 
		                        INNER JOIN tbl_DM_DonViTinh dvt ON sp.IdDonViTinh = dvt.IdDonViTinh 
                        WHERE ct.ListIdPhieuXuat !='' and ct.ListIdPhieuXuat is not null
                        ) AS BCBANHANG", idKho, ut.DateToString(dtTu), ut.DateToString(dtDen));

            sql += " WHERE ";
            base.SetParameterFields();
            base.SetSqlParameters(sql, CommandType.Text, "vBCBanHang");
        }
        private void dtTuNgay_ValueChanged(object sender, EventArgs e)
        {
            if (cboKyBaoCao.Text=="Ngày")
                dtDenNgay.Value = dtTuNgay.Value;
        }
    }
}