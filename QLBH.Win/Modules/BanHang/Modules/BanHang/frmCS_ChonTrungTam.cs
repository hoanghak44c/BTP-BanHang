using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QLBH.Common;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong.Infors;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmCS_ChonTrungTam : DevExpress.XtraEditors.XtraForm
    {
        bool MultiSelected = false;
        List<DMTrungTamInfor> liTrungTam = new List<DMTrungTamInfor>();
        public int IdTTamSelected = Declare.IdTrungTam;
        public string TenTTamSelected = Declare.TenTrungTam;
        public List<int> ListIdTTamSelected = new List<int>();
        public List<string> ListTenTTamSelected = new List<string>();
        public string LstIdTrungTam = "";
        public string LstMaTrungTam = "";
        public string LstTenTrungTam = "";

        public frmCS_ChonTrungTam()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }
        public frmCS_ChonTrungTam(bool multiSelected)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            MultiSelected = multiSelected;
        }

        private void frmKhoHienTai_Load(object sender, EventArgs e)
        {
            LoadTrungTam();
            colApDung.Visible = MultiSelected;
            chkChon.Visible = MultiSelected;
            dgvShop.MultiSelect = MultiSelected;
        }

        private void LoadTrungTam()
        {
            int idNhanVien = ((NguoiDungInfor) Declare.USER_INFOR).IdNhanVien;
            liTrungTam = DMTrungTamDataProvider.GetListTrungTamInfoByIdNhanVien(idNhanVien);

            if (liTrungTam.Count>0)
            {
                foreach (DMTrungTamInfor tt in liTrungTam)
                {
                    if (Common.Int2Bool(tt.SuDung))
                    {
                        object[] arr = { 0, tt.IdTrungTam, tt.MaTrungTam, tt.TenTrungTam };
                        dgvShop.Rows.Add(arr);
                    }
                }
            }
            else
            {
                dgvShop.Rows.Clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MultiSelected)
            {
                foreach (DataGridViewRow row in dgvShop.Rows)
                {
                    if (Common.BoolValue(row.Cells["colApDung"].Value))
                    {
                        ListIdTTamSelected.Add(Common.IntValue(row.Cells["colIdTrungTam"].Value));
                        ListTenTTamSelected.Add(row.Cells["colTenTrungTam"].Value.ToString());
                        LstIdTrungTam += row.Cells["colIdTrungTam"].Value.ToString() + ",";
                        LstMaTrungTam += row.Cells["colMaTrungTam"].Value.ToString() + ",";
                        LstTenTrungTam += row.Cells["colTenTrungTam"].Value.ToString() + ",";
                    }
                }  
                if (LstIdTrungTam.Length > 0)
                {
                    LstIdTrungTam = LstIdTrungTam.TrimEnd(",".ToCharArray());
                    LstMaTrungTam = LstMaTrungTam.TrimEnd(",".ToCharArray());
                    LstTenTrungTam = LstTenTrungTam.TrimEnd(",".ToCharArray());
                }
            }
            else
            {
                if (dgvShop.SelectedRows.Count>0)
                {
                    DataGridViewRow row = dgvShop.SelectedRows[0];
                    if (row != null)
                    {
                        IdTTamSelected = Common.IntValue(row.Cells["colIdTrungTam"].Value);
                        TenTTamSelected = row.Cells["colTenTrungTam"].Value.ToString();
                    }                    
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void chkChon_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvShop.Rows)
            {
                row.Cells["colApDung"].Value = chkChon.Checked;
            }           
        }

        private void dgvShop_DoubleClick(object sender, EventArgs e)
        {
            btnUpdate_Click(sender, e);
        }
    }
}