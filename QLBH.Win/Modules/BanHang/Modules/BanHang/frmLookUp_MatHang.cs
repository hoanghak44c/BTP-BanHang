using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmLookUp_MatHang : DevExpress.XtraEditors.XtraForm
    {
        private objGridMarkSelection selectorMH = new objGridMarkSelection();

        private List<TimKiemItemInfor> liItems = new List<TimKiemItemInfor>();
        private List<TimKiemItemInfor> liHang = new List<TimKiemItemInfor>();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();

        private string sNewSearch = "%%";
        public List<MatHangInfor> SelectedItems = new List<MatHangInfor>();
        private bool showAll = false;

        public frmLookUp_MatHang()
        {
            InitializeComponent();
        }
        public frmLookUp_MatHang(bool showAll)
        {
            InitializeComponent();
            this.showAll = showAll;
        }

        private void frmLookUp_MatHang_Load(object sender, EventArgs e)
        {
            cboGiaoHang.SelectedIndex = 6;
            LoadHangSX();
            txtMatHang.Text = sNewSearch;
            txtMatHang.Focus();
        }

        private void cboGiaoHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void LoadHangSX()
        {
            int idNND = (Common.Int2Bool(nguoiDung.SupperUser) || this.showAll) ? -1 : nguoiDung.IdNhomNguoiDung;
            liHang = TimKiemItemDataProvider.Instance.GetAllItemsByType(idNND, 7, -1, -1);//type=7: hang sx
            liHang.Insert(0, new TimKiemItemInfor()
                                 {
                                     Id = 0,
                                     Ma = "",
                                     Ten = "",
                                     Nhom = "",
                                     ChietKhau = 0
                                 });
            gHang.DataSource = liHang;
            gvHang.ExpandAllGroups();
            gvHang.SelectRow(0);
        }
        private void LoadMatHang()
        {
            int type = cboGiaoHang.SelectedIndex;
            int muccha = cboMucCha.SelectedIndex;
            int idNND = (Common.Int2Bool(nguoiDung.SupperUser) || this.showAll) ? -1 : nguoiDung.IdNhomNguoiDung;
            liItems = TimKiemItemDataProvider.Instance.GetAllItemsByTypeParent(idNND, type, txtMatHang.Text.Trim(), muccha, bteNganh.Text, -1, 1);
            Nhom.Caption = cboGiaoHang.SelectedIndex == 0
                               ? ""
                               : cboGiaoHang.Items[cboGiaoHang.SelectedIndex - 1].ToString();
            if (cboGiaoHang.SelectedIndex == 5)
                Nhom.Caption = cboGiaoHang.Items[2].ToString();
            gMatHang.DataSource = liItems;
            gvMatHang.ExpandAllGroups();
            selectorMH.View = gvMatHang;
            selectorMH.CheckMarkColumn.VisibleIndex = 0;
        }

        private void txtMatHang_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string pattern = txtMatHang.Text.Trim().Replace("%", ""); 
                List<TimKiemItemInfor> liMH = new List<TimKiemItemInfor>();
                if (txtMatHang.Text.StartsWith("%") && txtMatHang.Text.EndsWith("%"))
                {
                    pattern = txtMatHang.Text.TrimStart('%').TrimEnd('%').ToLower();
                    liMH = liItems.FindAll(delegate(TimKiemItemInfor match)
                    {
                        return match.Ma.ToLower().Contains(pattern) || match.Ten.ToLower().Contains(pattern);
                    });
                }
                else if (txtMatHang.Text.StartsWith("%"))
                {
                    pattern = txtMatHang.Text.TrimStart('%').ToLower();
                    liMH = liItems.FindAll(delegate(TimKiemItemInfor match)
                    {
                        return match.Ma.ToLower().EndsWith(pattern) || match.Ten.ToLower().EndsWith(pattern);
                    });
                }
                else if (txtMatHang.Text.EndsWith("%"))
                {
                    pattern = txtMatHang.Text.TrimEnd('%').ToLower();
                    liMH = liItems.FindAll(delegate(TimKiemItemInfor match)
                    {
                        return match.Ma.ToLower().StartsWith(pattern) || match.Ten.ToLower().StartsWith(pattern);
                    });
                }
                else if (txtMatHang.Text.Trim() != String.Empty)
                {
                    pattern = txtMatHang.Text.Trim().Replace("%", "");
                    liMH = liItems.FindAll(delegate(TimKiemItemInfor match)
                    {
                        return match.Ma.ToLower().Contains(pattern) || match.Ten.ToLower().Contains(pattern);
                    });
                }
                else
                    liMH = liItems;

                gMatHang.DataSource = liMH;
                gvMatHang.ExpandAllGroups();
                selectorMH.View = gvMatHang;
                selectorMH.CheckMarkColumn.VisibleIndex = 0;
            }
            catch {}
        }

        private void txtHangSX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string pattern = txtHangSX.Text.Trim().Replace("%","");
                List<TimKiemItemInfor> liHSX = new List<TimKiemItemInfor>();
                liHSX = liHang.FindAll(delegate(TimKiemItemInfor match)
                {
                    return match.Ma.Contains(pattern) || match.Ten.Contains(pattern);
                });
                gHang.DataSource = liHSX;
                gvHang.ExpandAllGroups();
            }
            catch {}
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            SelectedItems = new List<MatHangInfor>();
            if (selectorMH.selection.Count == 0)
            {
                if (gvHang.FocusedRowHandle > 0)
                {
                    TimKiemItemInfor item = (TimKiemItemInfor)gvHang.GetRow(gvHang.FocusedRowHandle);
                    MatHangInfor mh = new MatHangInfor();
                    mh.MaHangSX = item.Ma;
                    mh.TenHangSX = item.Ten;
                    SelectedItems.Add(mh);
                }
            }
            else
            {
                foreach (TimKiemItemInfor item in selectorMH.selection)
                {
                    MatHangInfor mh = new MatHangInfor();
                    mh.MaMatHang = item.Ma;
                    mh.TenMatHang = item.Ten;
                    mh.LoaiMatHang = cboGiaoHang.SelectedIndex;
                    mh.TenLoaiMatHang = cboGiaoHang.SelectedItem.ToString();
                    mh.IdMatHang = item.Id;
                    mh.ChietKhau = item.ChietKhau;
                    mh.MaHangSX = "";
                    mh.TenHangSX = "";

                    TimKiemItemInfor hsx = (TimKiemItemInfor)gvHang.GetRow(gvHang.FocusedRowHandle);
                    if (hsx != null && !String.IsNullOrEmpty(hsx.Ma))
                    {
                        mh.MaHangSX = hsx.Ma;
                        mh.TenHangSX = hsx.Ten;
                    }
                    SelectedItems.Add(mh);                  
                }                
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void gvHang_DoubleClick(object sender, EventArgs e)
        {
            btnAccept_Click(sender, e);
        }

        private void gvMatHang_DoubleClick(object sender, EventArgs e)
        {
            btnAccept_Click(sender, e);
        }

        private void gvMatHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (gvMatHang.FocusedRowHandle < 0) return;
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                if (selectorMH.IsRowSelected(gvMatHang.FocusedRowHandle))
                    selectorMH.SelectRow(gvMatHang.FocusedRowHandle, false);
                else
                    selectorMH.SelectRow(gvMatHang.FocusedRowHandle, true);
            }
        }

        private void frmLookUp_MatHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2 && btnAccept.Enabled)
                btnAccept_Click(sender, e);
            else if (e.KeyCode == Keys.Escape && btnClose.Enabled)
                btnClose_Click(sender, e);
            else if (e.KeyCode == Keys.F4)
                txtMatHang.Focus();
        }

        private void chkAllDT_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllDT.Checked)
                selectorMH.SelectAll();
            else
                selectorMH.ClearSelection();
        }

        private void frmLookUp_MatHang_Activated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMatHang.Text)) txtMatHang.Text = sNewSearch;
            txtMatHang.Focus();
            if (!String.IsNullOrEmpty(txtMatHang.Text))
            {
                txtMatHang.SelectionStart = txtMatHang.Text.Length - 1;
                //txtMatHang.SelectionLength = txtMatHang.Text.Length - 2; 
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadMatHang();
        }

        private void bteNganh_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteItemSegment_ButtonClick(sender, e, bteNganh, cboMucCha.SelectedIndex);
        }

        private void bteNganh_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteItemSegment_KeyDown(sender, e, bteNganh, cboMucCha.SelectedIndex);
        }

        private void bteNganh_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteNganh);
        }
    }
}