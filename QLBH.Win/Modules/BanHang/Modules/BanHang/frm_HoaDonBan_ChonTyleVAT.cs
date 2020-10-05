using System;
using System.Data;
using System.Windows.Forms;
using QLBH.Common;

namespace QLBanHang.Modules.BanHang
{
    public partial class frm_HoaDonBan_ChonTyleVAT : Form
    {
        DataTable dtTyle;
        public frm_HoaDonBan_ChonTyleVAT(DataTable dtTyle)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.dtTyle = dtTyle;
        }

        private void frm_HoaDonBan_ChonTyleVAT_Load(object sender, EventArgs e)
        {
            cboTyle.DisplayMember = "TyleVAT";
            cboTyle.ValueMember = "TyleVAT";
            cboTyle.DataSource = this.dtTyle;
            cboTyle.Refresh();
            cboTyle.Focus();
        }

        private void cboTyle_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter) {
                    double tmp = Convert.ToDouble(cboTyle.SelectedValue);
                    this.dtTyle.Rows.Clear();
                    DataRow dr = this.dtTyle.NewRow();
                    dr["TyleVAT"] = tmp;
                    this.dtTyle.Rows.Add(dr);
                    this.DialogResult = DialogResult.OK;
                }
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

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            try
            {
                double tmp = Convert.ToDouble(cboTyle.SelectedValue);
                this.dtTyle.Rows.Clear();
                DataRow dr = this.dtTyle.NewRow();
                dr["TyleVAT"] = tmp;
                this.dtTyle.Rows.Add(dr);
                this.DialogResult = DialogResult.OK;
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
    }
}