using System;
using System.Data;
using System.Windows.Forms;
using QLBH.Common;
using QLBH.Common.Objects;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmCS_BangGia_ApDung : DevExpress.XtraEditors.XtraForm
    {
        int g1IdBangGia;
        Utils ut = new Utils();
        public frmCS_BangGia_ApDung()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }
        public frmCS_BangGia_ApDung(int pIdBangGia)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            g1IdBangGia = pIdBangGia;
        }
        private void cmdThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            //Common.LogAction("Đóng form", "Đóng form " + this.Name, Declare.IdKho);
        }
        string g1ListIsChecked;
        private void frm_BangGia_ApDung_Load(object sender, EventArgs e)
        {
            //Common.LogAction("Mở form", "Mở form " + this.Name, Declare.IdKho);
            int loai = GetLoaiDuLieu();
            if (loai == 0)
            {
                rdTrungTam.Checked = true;
                rdShop.Checked = false;
            }
            else
            {
                rdTrungTam.Checked = false;
                rdShop.Checked = true;
            }
            LoadDuLieu(loai);
            //ut.LoadComboBox(cboTrungTam, "SELECT IdTrungTam,TenTrungTam FROM tbl_DM_TrungTam");
        }

        private int GetLoaiDuLieu()
        {
            int rs = 0;
            string sql = "Select kh.IdKho " +
                        " From tbl_DM_Kho kh Inner Join tbl_BangGia_Kho bg On kh.IdKho = bg.IdKho " +
                        " Where kh.SuDung=1 and bg.IdBangGia = " + this.g1IdBangGia;
            if (DBTools.getValue(sql) != "")
                rs = 1;
            return rs;
        }

        private void LoadDuLieu(int loai)
        {
            string sql = "";
            int i;
            bool isChecked;

            if (loai == 0)
            {
                sql = @"SELECT Convert(Varchar,IdTrungTam) + ' - ' + TenTrungTam as Ten,IdBangGia FROM tbl_DM_TrungTam Where SuDung=1 ";
            }
            else
            {
                sql = "Select Distinct Convert(Varchar,kh.IdKho) + ' - ' + kh.TenKho As Ten, bg.IdBangGia " +
                      " From tbl_DM_Kho kh Left Outer Join tbl_BangGia_Kho bg On kh.IdKho = bg.IdKho and bg.IdBangGia = " + g1IdBangGia +
                      " Where kh.SuDung=1 order by Ten";
            }

            DataTable dt = ut.getDataTable(sql);
            g1ListIsChecked = "";
            chkLstTrungTam.Items.Clear();
            foreach (DataRow r in dt.Rows)
            {
                isChecked = (Common.IntValue(r["IdBangGia"]) == g1IdBangGia);
                i = chkLstTrungTam.Items.Add(r["Ten"].ToString(), isChecked);
                if (isChecked)
                    g1ListIsChecked += i.ToString() + ",";
                //chkLstTrungTam.set//  = !isChecked;
            }
        }

        private void cmdApDung_Click(object sender, EventArgs e)
        {
            //int IdTrungTam=ut.getInt(cboTrungTam.SelectedValue) ;
            int Id;
            BangGia BG = new BangGia();

            foreach (object o in chkLstTrungTam.CheckedItems)
            {
                Id = Common.IntValue(o.ToString().Substring(0, o.ToString().IndexOf(" - ")));
                //IdTrungTam = ut.fGetID_sql(string.Format("SELECT IdTrungTam FROM tbl_DM_TrungTam WHERE TenTrungTam=N'{0}'", o.ToString()));
                if (Id > 0)
                {
                    if (rdTrungTam.Checked)
                        BG.ApDungTrungTam(g1IdBangGia, Id);//ap dung cho trung tam
                    else
                        BG.ApDungShop(g1IdBangGia, Id);//ap dung cho shop
                }
            }
            
            MessageBox.Show("Bảng giá đã được áp dụng");
            Common.LogAction("Áp dụng bảng giá", "Bảng giá " + g1IdBangGia.ToString(), Declare.IdKho);
        }

        private void chkLstTrungTam_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (g1ListIsChecked.IndexOf(e.Index.ToString() + ",") > -1)
                e.NewValue = CheckState.Checked;
        }

        private void rdTrungTam_CheckedChanged(object sender, EventArgs e)
        {
            LoadDuLieu(0);
        }

        private void rdShop_CheckedChanged(object sender, EventArgs e)
        {
            LoadDuLieu(1);
        }

        
    }
}