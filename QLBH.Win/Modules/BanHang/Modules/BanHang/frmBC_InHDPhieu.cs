using System;
using System.Data;
using System.Windows.Forms;
using QLBanHang.Modules.BanHang.Reports;
using QLBH.Common;
using QLBH.Core.Data;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBC_InHDPhieu : DevExpress.XtraEditors.XtraForm
    {
        string SoHD_Phieu = "";
        string ReportType = "";
        string QuyenSo = "";
        GtidConnection cnn;
        GtidDataAdapter da;
        DataSet ds = new DataSet();

        public frmBC_InHDPhieu()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        public frmBC_InHDPhieu( string strReportType, string strSoPhieu)
        {
            InitializeComponent();
            ReportType = strReportType;
            SoHD_Phieu = strSoPhieu;
            Common.LoadStyle(this);
        }
        public frmBC_InHDPhieu(string strReportType, string strSoPhieu,string IdQuyen)
        {
            InitializeComponent();
            ReportType = strReportType;
            SoHD_Phieu = strSoPhieu;
            this.QuyenSo = IdQuyen;
            Common.LoadStyle(this);
        }
        private void frmBC_InHDPhieu_Load(object sender, EventArgs e)
        {
            string strCaption = "";
            string ReportFile = Declare.AppPath;
            string sql = "";
            cnn = ConnectionUtil.Instance.GetConnection();
            switch (ReportType)
            {
                case "PT":
                    {
                        strCaption = "In phiếu thu";
                        sql = " SELECT     SoPhieu, NgayLap, HoTen, DiaChi, SoTien, SoTaiKhoan, NoiDungThuChi, TyGia, SoTienChu,  SoChungTuKem, ChungTuGoc, Ngay, Thang, Nam  FROM vPhieuThu  ";
                        sql = sql + " WHERE SoPhieu = '" + SoHD_Phieu.Trim() + "'";
                        ReportFile = ReportFile + "Reports\\rptPhieuThu.rpt";
                        break;
                    }
                case "THPT": {
                        strCaption = "Tổng hợp phiếu thu";
                        sql = " SELECT     *  FROM vBCThu  ";
                        ReportFile = ReportFile + "Reports\\rptBC_Thu.rpt";
                        break;
                    }
                case "PC":
                    {
                        strCaption = "In phiếu chi";
                        sql = " SELECT     SoPhieuChi, NgayChi, SoTaiKhoan, SoTKDoiUng, LyDoChi, TienChi, TyGia, TongTienVN, TongTien_Chu, ChungTuGoc, HoTen, QuyenSo, TenTienTe, TenNhaCungCap, DiaChi, SL_ChungTuKem, ngay_chi, thang_chi, nam_chi, ngay, thang, nam  FROM vPhieuChi ";
                        sql = sql + " WHERE SoPhieuChi = '" + SoHD_Phieu.Trim() + "' and QuyenSo='"+this.QuyenSo+"'";
                        ReportFile = ReportFile + "Reports\\rptPhieuChi.rpt";
                        break;
                    }
                case "HDM":
                    {
                        this.Text = "In hóa đơn mua";
                        sql = " select * from vThongTinNhaThuoc;select * from vHoaDonMua where SoHoaDonMua=N'" + SoHD_Phieu + "';select * from vChiTiet_HoaDonMua where SoHoaDonMua=N'" + SoHD_Phieu + "'";
                        da = new GtidDataAdapter(sql, cnn);
                        da.Fill(ds);
                        ds.Tables[0].TableName = "vThongTinNhaThuoc";
                        ds.Tables[1].TableName = "vHoaDonMua";
                        ds.Tables[2].TableName = "vChiTiet_HoaDonMua";
                        ReportFile = ReportFile + "Reports\\rptHoaDonMua.rpt";
                        if (ds.Tables[1].Rows.Count > 0)
                        {
                            rptHoaDonMua rpt = new rptHoaDonMua();
                            rpt.SetDataSource(ds);
                            rptViewer.ReportSource = rpt;
                            rptViewer.RefreshReport();
                            return;
                        }
                        break;
                    }
                case "HDB":
                    {
                        this.Text = "In hóa đơn bán";
                        sql = " select * from vThongTinNhaThuoc;select * from vHoaDonBan where SoHoaDonBan=N'" + SoHD_Phieu + "';select * from vChiTiet_HoaDonBan where SoHoaDonBan=N'" + SoHD_Phieu + "'";
                        da = new GtidDataAdapter(sql, cnn);
                        da.Fill(ds);
                        ds.Tables[0].TableName = "vThongTinNhaThuoc";
                        ds.Tables[1].TableName = "vHoaDonBan";
                        ds.Tables[2].TableName = "vChiTiet_HoaDonBan";
                        ReportFile = ReportFile + "Reports\\rptHoaDonBan.rpt";
                        if (ds.Tables[1].Rows.Count > 0)
                        {
                            rptHoaDonBan rpt = new rptHoaDonBan();
                            rpt.SetDataSource(ds);
                            rptViewer.ReportSource = rpt;
                            rptViewer.RefreshReport();
                            return;
                        }
                        break;
                    }
            }
            this.Text = strCaption;

            if (!DBTools.ExistData(sql))
            {
                MessageBox.Show("Không có dữ liệu. Chọn số phiếu khác để in!", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DBTools.LoadReportFile(ReportFile, sql, rptViewer);
                this.rptViewer.RefreshReport();
            }

        }
    }
}