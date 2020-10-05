namespace QLBanHang.Modules.BanHang
{
    partial class frmBC_TongHopBanHang
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dteEnd = new DevExpress.XtraEditors.DateEdit();
            this.dteStart = new DevExpress.XtraEditors.DateEdit();
            this.lblEnd = new DevExpress.XtraEditors.LabelControl();
            this.lblStart = new DevExpress.XtraEditors.LabelControl();
            this.bteTrungTam = new DevExpress.XtraEditors.ButtonEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.lueDanhMuc = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnReload = new DevExpress.XtraEditors.SimpleButton();
            this.gBC = new DevExpress.XtraGrid.GridControl();
            this.gvBC = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDanhMuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gBC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBC)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.dteEnd);
            this.groupControl1.Controls.Add(this.dteStart);
            this.groupControl1.Controls.Add(this.lblEnd);
            this.groupControl1.Controls.Add(this.lblStart);
            this.groupControl1.Controls.Add(this.bteTrungTam);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.lueDanhMuc);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.btnExport);
            this.groupControl1.Controls.Add(this.btnReload);
            this.groupControl1.Location = new System.Drawing.Point(1, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(867, 87);
            this.groupControl1.TabIndex = 6;
            // 
            // dteEnd
            // 
            this.dteEnd.EditValue = null;
            this.dteEnd.Location = new System.Drawing.Point(497, 54);
            this.dteEnd.Name = "dteEnd";
            this.dteEnd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dteEnd.Properties.Appearance.Options.UseFont = true;
            this.dteEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteEnd.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dteEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteEnd.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dteEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteEnd.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteEnd.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dteEnd.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteEnd.Size = new System.Drawing.Size(126, 20);
            this.dteEnd.TabIndex = 147;
            // 
            // dteStart
            // 
            this.dteStart.EditValue = null;
            this.dteStart.Location = new System.Drawing.Point(496, 29);
            this.dteStart.Name = "dteStart";
            this.dteStart.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dteStart.Properties.Appearance.Options.UseFont = true;
            this.dteStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteStart.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dteStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteStart.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dteStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteStart.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteStart.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dteStart.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteStart.Size = new System.Drawing.Size(127, 20);
            this.dteStart.TabIndex = 146;
            // 
            // lblEnd
            // 
            this.lblEnd.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEnd.Appearance.Options.UseFont = true;
            this.lblEnd.Location = new System.Drawing.Point(448, 57);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(45, 13);
            this.lblEnd.TabIndex = 149;
            this.lblEnd.Text = "đến ngày";
            // 
            // lblStart
            // 
            this.lblStart.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStart.Appearance.Options.UseFont = true;
            this.lblStart.Location = new System.Drawing.Point(453, 32);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(40, 13);
            this.lblStart.TabIndex = 148;
            this.lblStart.Text = "Từ ngày";
            // 
            // bteTrungTam
            // 
            this.bteTrungTam.Location = new System.Drawing.Point(83, 54);
            this.bteTrungTam.Name = "bteTrungTam";
            this.bteTrungTam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteTrungTam.Properties.Appearance.Options.UseFont = true;
            this.bteTrungTam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteTrungTam.Size = new System.Drawing.Size(333, 22);
            this.bteTrungTam.TabIndex = 119;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 120;
            this.label7.Text = "Trung tâm";
            // 
            // lueDanhMuc
            // 
            this.lueDanhMuc.Location = new System.Drawing.Point(83, 29);
            this.lueDanhMuc.Name = "lueDanhMuc";
            this.lueDanhMuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDanhMuc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.lueDanhMuc.Properties.DisplayMember = "Name";
            this.lueDanhMuc.Properties.NullText = "";
            this.lueDanhMuc.Properties.ValueMember = "OID";
            this.lueDanhMuc.Size = new System.Drawing.Size(333, 20);
            this.lueDanhMuc.TabIndex = 18;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(39, 32);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(38, 13);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Báo cáo";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(653, 54);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(99, 24);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(653, 25);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(99, 24);
            this.btnReload.TabIndex = 13;
            this.btnReload.Text = "Xem báo cáo";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // gBC
            // 
            this.gBC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gBC.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gBC.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gBC.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gBC.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gBC.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gBC.EmbeddedNavigator.TextStringFormat = "{0} / Tổng số {1}";
            this.gBC.Location = new System.Drawing.Point(1, 96);
            this.gBC.MainView = this.gvBC;
            this.gBC.Name = "gBC";
            this.gBC.Size = new System.Drawing.Size(867, 314);
            this.gBC.TabIndex = 7;
            this.gBC.UseEmbeddedNavigator = true;
            this.gBC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBC});
            // 
            // gvBC
            // 
            this.gvBC.GridControl = this.gBC;
            this.gvBC.Name = "gvBC";
            this.gvBC.OptionsNavigation.AutoFocusNewRow = true;
            this.gvBC.OptionsView.ColumnAutoWidth = false;
            this.gvBC.OptionsView.ShowAutoFilterRow = true;
            // 
            // frmBC_TongHopBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 413);
            this.Controls.Add(this.gBC);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBC_TongHopBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo tổng hợp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_BaoCaoDanhMuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDanhMuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gBC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit lueDanhMuc;
        private DevExpress.XtraEditors.ButtonEdit bteTrungTam;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.DateEdit dteEnd;
        private DevExpress.XtraEditors.DateEdit dteStart;
        private DevExpress.XtraEditors.LabelControl lblEnd;
        private DevExpress.XtraEditors.LabelControl lblStart;
        private DevExpress.XtraGrid.GridControl gBC;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBC;
    }
}