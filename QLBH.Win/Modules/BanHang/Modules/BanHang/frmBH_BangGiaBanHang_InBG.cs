using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using QLBanHang.Modules.BanHang.Reports;
using QLBanHang.Modules.KhoHang.Infors;
using QLBanHang.Modules.KhoHang.Providers;
using QLBH.Common;
//using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.HeThong.Infors;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBH_BangGiaBanHang_InBG : DevExpress.XtraEditors.XtraForm
    {
        private ArrayList arrBangGiaChiTiet = new ArrayList();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();

        public frmBH_BangGiaBanHang_InBG()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        public frmBH_BangGiaBanHang_InBG(ArrayList arrBangGiaChiTiet)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.arrBangGiaChiTiet = arrBangGiaChiTiet;
        }

        private void frm_ThietLapKM_Load(object sender, EventArgs e)
        {
        }

        private void cmdDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ThietLapKM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.cmdDong_Click(sender, e);
        }

        private void btnInBG_Click(object sender, EventArgs e)
        {
            foreach (QLBanHang.Modules.BanHang.Infors.BangGiaBanChiTietInfor sp in arrBangGiaChiTiet)
            {
                BangGiaReportInfo bg;
                List<BangGiaReportInfo> liChiTiet = new List<BangGiaReportInfo>();
                bg = BangGiaReportDataProvider.Instance.SanPhamGetGiaByMaSanPham(sp.MaSanPham);
                liChiTiet = BangGiaReportDataProvider.Instance.SanPhamGetCauHinhByMaSanPham(sp.MaSanPham);
                rpt_BangGia rpt = new rpt_BangGia(bg);
                rpt.DataSource = liChiTiet;
                rpt.ShowPreview();
            } 
        }
    }
}