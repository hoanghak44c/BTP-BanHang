using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.BanHang.Providers;
using QLBH.Common;
using QLBH.Core.Data;
using QLBH.Core.Providers;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBC_TongHopBanHang : DevExpress.XtraEditors.XtraForm
    {
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();

        public frmBC_TongHopBanHang()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        private void LoadDanhMuc()
        {
            List<DanhSachBaoCaoBanHangInfor> liBaoCao = BanHangDataProvider.Instance.GetListBaoCaoTongHopBanHang();
            if (liBaoCao.Count > 0)
            {
                lueDanhMuc.Properties.Columns.Clear();
                lueDanhMuc.Properties.Columns.Add(new LookUpColumnInfo("TenBaoCao", "Tên"));
                lueDanhMuc.Properties.DataSource = liBaoCao;
                lueDanhMuc.Properties.DisplayMember = "TenBaoCao";
                lueDanhMuc.Properties.ValueMember = "TenStore";
            }
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                if (lueDanhMuc.EditValue == null || String.IsNullOrEmpty(lueDanhMuc.EditValue.ToString()))
                {
                    MessageBox.Show("Chưa chọn báo cáo");
                    return;
                }
                LoadBaoCao();
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
        }

        private void LoadBaoCao()
        {
            string tenBaoCao = lueDanhMuc.Text;
            string tenStore = lueDanhMuc.EditValue.ToString();

            int idTrungTam = CommonFuns.Instance.GetIdTrungTam(bteTrungTam, nguoiDung);
            //GtidParameter trungtam = new GtidParameter("p_IdTrungTam", idTrungTam);
            //GtidParameter tungay = new GtidParameter("p_TuNgay", Convert.ToDateTime(dteStart.EditValue));
            //GtidParameter denngay = new GtidParameter("p_DenNgay", Convert.ToDateTime(dteEnd.EditValue));

            DataSet ds = BanHangDataProvider.Instance.LoadBaoCao(tenStore, idTrungTam,
                                                                 Convert.ToDateTime(dteStart.EditValue),
                                                                 Convert.ToDateTime(dteEnd.EditValue));
            gBC.DataSource = null;
            gvBC.GroupSummary.Clear();
            if (ds != null && ds.Tables.Count>=0)
            {
                gBC.DataSource = ds.Tables[0];
                gvBC.OptionsView.ColumnAutoWidth = true;
                gvBC.OptionsView.ShowFooter = true;
                gvBC.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
                new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Số giao dịch", null, "  (Tổng giao dịch = {0})")});
                gvBC.Columns["Số giao dịch"].SummaryItem.FieldName = "Số giao dịch";
                gvBC.Columns[2].SummaryItem.DisplayFormat = "{0:N0}";
                gvBC.Columns[2].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            }

            this.Text = tenBaoCao;
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            Common.DevExport2Excel(gvBC);
        }

        private void frm_BaoCaoDanhMuc_Load(object sender, EventArgs e)
        {
            LoadDanhMuc();
        }
    }
}