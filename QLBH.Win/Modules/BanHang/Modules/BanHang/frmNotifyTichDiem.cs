using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using QLBH.Common;
using QLBH.Common.Objects;
using QLBH.Common.Providers;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmNotifyTichDiem : DevExpress.XtraEditors.XtraForm
    {
        private static frmNotifyTichDiem instance;
        public static frmNotifyTichDiem Instance
        {
            get { return instance ?? (instance = new frmNotifyTichDiem()); }
        }

        public frmNotifyTichDiem()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        private void cmdThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frm_BangGia_ApDung_Load(object sender, EventArgs e)
        {
        }
        public void ShowMessage(int diemDau, int diemTru, int diemThem, int tongDiem, string title)
        {
            grTitle.Text = title;
            this.lblDiemDau.Text = String.Format("Số điểm ban đầu: {0}", diemDau);
            this.lblDiemTru.Text = String.Format("Số điểm bị trừ: {0}", diemTru);
            this.lblDiemThem.Text = String.Format("Số điểm tích lũy thêm: {0}", diemThem);
            this.lblTongDiem.Text = String.Format("Tổng điểm cuối cùng: {0}", tongDiem);
            this.ShowDialog();
        }
    }
}