using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using QLBanHang.Modules.BanHang.Reports;
using CrystalDecisions.Shared;
using QLBH.Common;
using QLBH.Common.Objects;
using QLBH.Common.Providers;
using QLBH.Core.Data;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.DongBoERP;
//

namespace QLBanHang.Modules.BanHang
{
    public partial class frmCS_BangGia_ChuaDuyet : DevExpress.XtraEditors.XtraForm
    {
        public frmCS_BangGia_ChuaDuyet()
        {
            InitializeComponent();
            Common.LoadStyle(this);            
        }

        private void frm_BangGia_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadData()
        {
            try
            {
                List<BangGiaChiTietNoDuyetInfor> liBGCTiet =
                    BangGiaDataProvider.Instance.GetAllBangGiaChiTietNoDuyetInfors();
                gSanPham.DataSource = new BindingList<BangGiaChiTietNoDuyetInfor>(liBGCTiet);
                //gvSanPham.Columns["NganhHang"].GroupIndex = 0;
                gvSanPham.ExpandAllGroups();
                label3.Text = "Tổng số mã cần duyệt: " + liBGCTiet.Count.ToString();
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }            
        }

        private void btnRefress_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}