using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBanHang.Modules.BanHang.Infors;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmMutilPhieuXuatBan : DevExpress.XtraEditors.XtraForm
    {
        #region Declare

        private List<NhapHangTraMuaInfor> lst = new List<NhapHangTraMuaInfor>();
       
        public NhapHangTraMuaInfor SelectItem = new NhapHangTraMuaInfor();
        #endregion

        public frmMutilPhieuXuatBan(List<NhapHangTraMuaInfor> lst)
        {
            InitializeComponent();
            this.lst = lst;
        }
        public frmMutilPhieuXuatBan(List<BHangDoiMaInfor> lst)
        {
            InitializeComponent();
            this.lst = new List<NhapHangTraMuaInfor>();
            foreach (BHangDoiMaInfor hdm in lst)
            {
                this.lst.Add(hdm);
            }
        }

        private void LoadDataSource()
        {
            grcDanhSach.DataSource = lst;
        }

        private void Save(int rowhandle)
        {
            if (rowhandle < 0) return;
            SelectItem = (NhapHangTraMuaInfor) grvDanhSach.GetRow(rowhandle);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmMutilPhieuXuatBan_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
                this.Close();
            if(e.KeyCode==Keys.Enter)
                Save(grvDanhSach.FocusedRowHandle);
        }

        private void frmMutilPhieuXuatBan_Load(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void grvDanhSach_DoubleClick(object sender, EventArgs e)
        {
            Save(grvDanhSach.FocusedRowHandle);
        }
    }
}