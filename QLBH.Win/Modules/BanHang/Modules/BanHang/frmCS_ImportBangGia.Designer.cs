using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using QLBH.Core.Form;
namespace QLBanHang.Modules.BanHang
{
    partial class frmCS_ImportBangGia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCS_ImportBangGia));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImportToPOS = new QLBH.Core.Form.GtidButton();
            this.btnImportCSDL = new QLBH.Core.Form.GtidButton();
            this.btnImportExcel = new QLBH.Core.Form.GtidButton();
            this.btnDong = new QLBH.Core.Form.GtidButton();
            this.grpKetQuaTimKiem = new System.Windows.Forms.GroupBox();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gListChungTu = new DevExpress.XtraGrid.GridControl();
            this.gvListChungTu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.grpKetQuaImport = new System.Windows.Forms.GroupBox();
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.btnExportErr = new QLBH.Core.Form.GtidButton();
            this.gImportErrors = new DevExpress.XtraGrid.GridControl();
            this.gvImportErrors = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsbChiTietDonHang = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaCT = new QLBH.Core.Form.GtidButton();
            this.groupBox1.SuspendLayout();
            this.grpKetQuaTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gListChungTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListChungTu)).BeginInit();
            this.grpKetQuaImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gImportErrors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvImportErrors)).BeginInit();
            this.ctxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnImportToPOS);
            this.groupBox1.Controls.Add(this.btnImportCSDL);
            this.groupBox1.Controls.Add(this.btnImportExcel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnImportToPOS
            // 
            this.btnImportToPOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportToPOS.Image = ((System.Drawing.Image)(resources.GetObject("btnImportToPOS.Image")));
            this.btnImportToPOS.Location = new System.Drawing.Point(783, 14);
            this.btnImportToPOS.Name = "btnImportToPOS";
            this.btnImportToPOS.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnImportToPOS.Size = new System.Drawing.Size(225, 25);
            this.btnImportToPOS.TabIndex = 23;
            this.btnImportToPOS.Text = "Import dữ liệu bán hàng vào POS";
            this.btnImportToPOS.Click += new System.EventHandler(this.btnImportToPOS_Click);
            // 
            // btnImportCSDL
            // 
            this.btnImportCSDL.Image = ((System.Drawing.Image)(resources.GetObject("btnImportCSDL.Image")));
            this.btnImportCSDL.Location = new System.Drawing.Point(243, 14);
            this.btnImportCSDL.Name = "btnImportCSDL";
            this.btnImportCSDL.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnImportCSDL.Size = new System.Drawing.Size(216, 25);
            this.btnImportCSDL.TabIndex = 22;
            this.btnImportCSDL.Text = "Nạp dữ liệu bán hàng từ Database";
            this.btnImportCSDL.Click += new System.EventHandler(this.btnImportCSDL_Click);
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnImportExcel.Image")));
            this.btnImportExcel.Location = new System.Drawing.Point(22, 14);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnImportExcel.Size = new System.Drawing.Size(215, 25);
            this.btnImportExcel.TabIndex = 20;
            this.btnImportExcel.Text = "Nạp dữ liệu bán hàng từ File Excel";
            this.btnImportExcel.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(912, 526);
            this.btnDong.Name = "btnDong";
            this.btnDong.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnDong.Size = new System.Drawing.Size(101, 25);
            this.btnDong.TabIndex = 21;
            this.btnDong.Text = "Đóng (F12)";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // grpKetQuaTimKiem
            // 
            this.grpKetQuaTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKetQuaTimKiem.Controls.Add(this.xtraTabControl1);
            this.grpKetQuaTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKetQuaTimKiem.ForeColor = System.Drawing.Color.Black;
            this.grpKetQuaTimKiem.Location = new System.Drawing.Point(1, 55);
            this.grpKetQuaTimKiem.Name = "grpKetQuaTimKiem";
            this.grpKetQuaTimKiem.Size = new System.Drawing.Size(1018, 221);
            this.grpKetQuaTimKiem.TabIndex = 1;
            this.grpKetQuaTimKiem.TabStop = false;
            this.grpKetQuaTimKiem.Text = "Dữ liệu import";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(6, 15);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1012, 201);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gListChungTu);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1005, 173);
            this.xtraTabPage1.Text = "Sản phâm import";
            // 
            // gListChungTu
            // 
            this.gListChungTu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gListChungTu.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gListChungTu.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gListChungTu.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gListChungTu.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gListChungTu.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gListChungTu.EmbeddedNavigator.TextStringFormat = "{0} / Tổng số {1}";
            this.gListChungTu.Location = new System.Drawing.Point(3, 3);
            this.gListChungTu.MainView = this.gvListChungTu;
            this.gListChungTu.Name = "gListChungTu";
            this.gListChungTu.Size = new System.Drawing.Size(990, 173);
            this.gListChungTu.TabIndex = 0;
            this.gListChungTu.UseEmbeddedNavigator = true;
            this.gListChungTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListChungTu});
            // 
            // gvListChungTu
            // 
            this.gvListChungTu.GridControl = this.gListChungTu;
            this.gvListChungTu.Name = "gvListChungTu";
            this.gvListChungTu.OptionsView.ColumnAutoWidth = false;
            this.gvListChungTu.OptionsView.ShowAutoFilterRow = true;
            this.gvListChungTu.OptionsView.ShowGroupPanel = false;
            this.gvListChungTu.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvImportErrors_RowCellStyle);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(422, 532);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(38, 13);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar1.Location = new System.Drawing.Point(12, 526);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(398, 25);
            this.progressBar1.TabIndex = 12;
            // 
            // grpKetQuaImport
            // 
            this.grpKetQuaImport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKetQuaImport.Controls.Add(this.xtraTabControl2);
            this.grpKetQuaImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKetQuaImport.ForeColor = System.Drawing.Color.Black;
            this.grpKetQuaImport.Location = new System.Drawing.Point(1, 282);
            this.grpKetQuaImport.Name = "grpKetQuaImport";
            this.grpKetQuaImport.Size = new System.Drawing.Size(1018, 238);
            this.grpKetQuaImport.TabIndex = 2;
            this.grpKetQuaImport.TabStop = false;
            this.grpKetQuaImport.Text = "Kết quả import vào POS";
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl2.Location = new System.Drawing.Point(6, 16);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.xtraTabPage4;
            this.xtraTabControl2.Size = new System.Drawing.Size(1012, 216);
            this.xtraTabControl2.TabIndex = 1;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage4});
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.btnExportErr);
            this.xtraTabPage4.Controls.Add(this.gImportErrors);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(1005, 188);
            this.xtraTabPage4.Text = "Sản phẩm import bị lỗi";
            // 
            // btnExportErr
            // 
            this.btnExportErr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportErr.Image = ((System.Drawing.Image)(resources.GetObject("btnExportErr.Image")));
            this.btnExportErr.Location = new System.Drawing.Point(924, 177);
            this.btnExportErr.Name = "btnExportErr";
            this.btnExportErr.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnExportErr.Size = new System.Drawing.Size(77, 20);
            this.btnExportErr.TabIndex = 24;
            this.btnExportErr.Text = "Export";
            this.btnExportErr.Click += new System.EventHandler(this.btnExportErr_Click);
            // 
            // gImportErrors
            // 
            this.gImportErrors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gImportErrors.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gImportErrors.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gImportErrors.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gImportErrors.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gImportErrors.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gImportErrors.EmbeddedNavigator.TextStringFormat = "{0} / Tổng số {1}";
            this.gImportErrors.Location = new System.Drawing.Point(3, 3);
            this.gImportErrors.MainView = this.gvImportErrors;
            this.gImportErrors.Name = "gImportErrors";
            this.gImportErrors.Size = new System.Drawing.Size(999, 172);
            this.gImportErrors.TabIndex = 1;
            this.gImportErrors.UseEmbeddedNavigator = true;
            this.gImportErrors.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvImportErrors});
            // 
            // gvImportErrors
            // 
            this.gvImportErrors.GridControl = this.gImportErrors;
            this.gvImportErrors.Name = "gvImportErrors";
            this.gvImportErrors.OptionsView.ColumnAutoWidth = false;
            this.gvImportErrors.OptionsView.ShowAutoFilterRow = true;
            this.gvImportErrors.OptionsView.ShowGroupPanel = false;
            this.gvImportErrors.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvImportErrors_RowCellStyle);
            // 
            // ctxMenu
            // 
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbChiTietDonHang});
            this.ctxMenu.Name = "contextMenuStrip1";
            this.ctxMenu.Size = new System.Drawing.Size(167, 26);
            // 
            // tsbChiTietDonHang
            // 
            this.tsbChiTietDonHang.Name = "tsbChiTietDonHang";
            this.tsbChiTietDonHang.Size = new System.Drawing.Size(166, 22);
            this.tsbChiTietDonHang.Text = "Chi tiết đơn hàng";
            this.tsbChiTietDonHang.Click += new System.EventHandler(this.tsbChiTietDonHang_Click);
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaCT.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaCT.Image")));
            this.btnXoaCT.Location = new System.Drawing.Point(796, 526);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnXoaCT.Size = new System.Drawing.Size(110, 25);
            this.btnXoaCT.TabIndex = 22;
            this.btnXoaCT.Text = "Xóa chứng từ";
            // 
            // frmCS_ImportBangGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 554);
            this.Controls.Add(this.btnXoaCT);
            this.Controls.Add(this.grpKetQuaImport);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.grpKetQuaTimKiem);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "frmCS_ImportBangGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import dữ liêu từ VIP vào POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBH_TimChungTu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBH_TimChungTu_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.grpKetQuaTimKiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gListChungTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListChungTu)).EndInit();
            this.grpKetQuaImport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gImportErrors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvImportErrors)).EndInit();
            this.ctxMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpKetQuaTimKiem;
        internal GtidButton btnDong;
        private DevExpress.XtraGrid.GridControl gListChungTu;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListChungTu;
        private GtidButton btnImportExcel;
        private GtidButton btnImportToPOS;
        private GtidButton btnImportCSDL;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox grpKetQuaImport;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private GridControl gImportErrors;
        private GridView gvImportErrors;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem tsbChiTietDonHang;
        internal GtidButton btnXoaCT;
        internal GtidButton btnExportErr;
    }
}