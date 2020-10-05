namespace QLBanHang.Modules.BanHang
{
    partial class frmLookUp_MatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLookUp_MatHang));
            this.chkAllDT = new System.Windows.Forms.CheckBox();
            this.gMatHang = new DevExpress.XtraGrid.GridControl();
            this.gvMatHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Nhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ma = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtMatHang = new QLBH.Core.Form.GtidTextBox();
            this.cboGiaoHang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bteNganh = new DevExpress.XtraEditors.ButtonEdit();
            this.btnTim = new QLBH.Core.Form.GtidButton();
            this.cboMucCha = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHangSX = new QLBH.Core.Form.GtidTextBox();
            this.gHang = new DevExpress.XtraGrid.GridControl();
            this.gvHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAccept = new QLBH.Core.Form.GtidButton();
            this.btnClose = new QLBH.Core.Form.GtidButton();
            ((System.ComponentModel.ISupportInitialize)(this.gMatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMatHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteNganh.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHang)).BeginInit();
            this.SuspendLayout();
            // 
            // chkAllDT
            // 
            this.chkAllDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAllDT.AutoSize = true;
            this.chkAllDT.Location = new System.Drawing.Point(15, 465);
            this.chkAllDT.Name = "chkAllDT";
            this.chkAllDT.Size = new System.Drawing.Size(99, 17);
            this.chkAllDT.TabIndex = 2;
            this.chkAllDT.Text = "Chọn / Bỏ chọn";
            this.chkAllDT.UseVisualStyleBackColor = true;
            this.chkAllDT.CheckedChanged += new System.EventHandler(this.chkAllDT_CheckedChanged);
            // 
            // gMatHang
            // 
            this.gMatHang.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gMatHang.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gMatHang.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gMatHang.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gMatHang.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gMatHang.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gMatHang.Location = new System.Drawing.Point(15, 74);
            this.gMatHang.MainView = this.gvMatHang;
            this.gMatHang.Name = "gMatHang";
            this.gMatHang.Size = new System.Drawing.Size(537, 379);
            this.gMatHang.TabIndex = 92;
            this.gMatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMatHang});
            // 
            // gvMatHang
            // 
            this.gvMatHang.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvMatHang.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvMatHang.Appearance.FocusedCell.Options.UseFont = true;
            this.gvMatHang.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvMatHang.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvMatHang.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvMatHang.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvMatHang.Appearance.Row.BackColor = System.Drawing.Color.Silver;
            this.gvMatHang.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvMatHang.Appearance.Row.Options.UseBackColor = true;
            this.gvMatHang.Appearance.Row.Options.UseBorderColor = true;
            this.gvMatHang.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvMatHang.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvMatHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Nhom,
            this.Ma,
            this.Ten});
            this.gvMatHang.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvMatHang.GridControl = this.gMatHang;
            this.gvMatHang.GroupCount = 1;
            this.gvMatHang.Name = "gvMatHang";
            this.gvMatHang.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvMatHang.OptionsView.ShowDetailButtons = false;
            this.gvMatHang.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Nhom, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvMatHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvMatHang_KeyDown);
            this.gvMatHang.DoubleClick += new System.EventHandler(this.gvMatHang_DoubleClick);
            // 
            // Nhom
            // 
            this.Nhom.Caption = "Mức cha";
            this.Nhom.FieldName = "Nhom";
            this.Nhom.Name = "Nhom";
            this.Nhom.Visible = true;
            this.Nhom.VisibleIndex = 2;
            // 
            // Ma
            // 
            this.Ma.Caption = "Mã";
            this.Ma.FieldName = "Ma";
            this.Ma.Name = "Ma";
            this.Ma.OptionsColumn.ReadOnly = true;
            this.Ma.Visible = true;
            this.Ma.VisibleIndex = 0;
            this.Ma.Width = 202;
            // 
            // Ten
            // 
            this.Ten.Caption = "Tên";
            this.Ten.FieldName = "Ten";
            this.Ten.Name = "Ten";
            this.Ten.OptionsColumn.AllowEdit = false;
            this.Ten.OptionsColumn.ReadOnly = true;
            this.Ten.Visible = true;
            this.Ten.VisibleIndex = 1;
            this.Ten.Width = 405;
            // 
            // txtMatHang
            // 
            this.txtMatHang.Location = new System.Drawing.Point(194, 47);
            this.txtMatHang.Name = "txtMatHang";
            this.txtMatHang.Size = new System.Drawing.Size(358, 21);
            this.txtMatHang.TabIndex = 1;
            this.txtMatHang.TextChanged += new System.EventHandler(this.txtMatHang_TextChanged);
            // 
            // cboGiaoHang
            // 
            this.cboGiaoHang.AutoCompleteCustomSource.AddRange(new string[] {
            "Nhận hàng tại siêu thị",
            "Giao hàng tại nhà"});
            this.cboGiaoHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGiaoHang.FormattingEnabled = true;
            this.cboGiaoHang.Items.AddRange(new object[] {
            "Lĩnh vực",
            "Ngành",
            "Loại",
            "Chủng",
            "Nhóm",
            "Model",
            "Sản phẩm"});
            this.cboGiaoHang.Location = new System.Drawing.Point(84, 47);
            this.cboGiaoHang.Name = "cboGiaoHang";
            this.cboGiaoHang.Size = new System.Drawing.Size(107, 21);
            this.cboGiaoHang.TabIndex = 0;
            this.cboGiaoHang.SelectedIndexChanged += new System.EventHandler(this.cboGiaoHang_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 94;
            this.label5.Text = "Tìm kiếm theo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bteNganh);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.cboMucCha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 457);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm mã hàng";
            // 
            // bteNganh
            // 
            this.bteNganh.Location = new System.Drawing.Point(188, 18);
            this.bteNganh.Name = "bteNganh";
            this.bteNganh.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.bteNganh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteNganh.Properties.Appearance.Options.UseBackColor = true;
            this.bteNganh.Properties.Appearance.Options.UseFont = true;
            this.bteNganh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteNganh.Size = new System.Drawing.Size(260, 21);
            this.bteNganh.TabIndex = 157;
            this.bteNganh.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteNganh_ButtonClick);
            this.bteNganh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteNganh_KeyDown);
            this.bteNganh.TextChanged += new System.EventHandler(this.bteNganh_TextChanged);
            // 
            // btnTim
            // 
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.Location = new System.Drawing.Point(450, 17);
            this.btnTim.Name = "btnTim";
            this.btnTim.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnTim.Size = new System.Drawing.Size(96, 23);
            this.btnTim.TabIndex = 98;
            this.btnTim.Text = "&Tìm kiếm (F3)";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cboMucCha
            // 
            this.cboMucCha.AutoCompleteCustomSource.AddRange(new string[] {
            "Nhận hàng tại siêu thị",
            "Giao hàng tại nhà"});
            this.cboMucCha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMucCha.FormattingEnabled = true;
            this.cboMucCha.Items.AddRange(new object[] {
            "Lĩnh vực",
            "Ngành",
            "Loại",
            "Chủng",
            "Nhóm",
            "Model"});
            this.cboMucCha.Location = new System.Drawing.Point(78, 18);
            this.cboMucCha.Name = "cboMucCha";
            this.cboMucCha.Size = new System.Drawing.Size(107, 21);
            this.cboMucCha.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 97;
            this.label1.Text = "Mức cha";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHangSX);
            this.groupBox2.Controls.Add(this.gHang);
            this.groupBox2.Location = new System.Drawing.Point(566, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 456);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm hãng sản xuất";
            // 
            // txtHangSX
            // 
            this.txtHangSX.Location = new System.Drawing.Point(6, 20);
            this.txtHangSX.Name = "txtHangSX";
            this.txtHangSX.Size = new System.Drawing.Size(369, 21);
            this.txtHangSX.TabIndex = 0;
            this.txtHangSX.TextChanged += new System.EventHandler(this.txtHangSX_TextChanged);
            // 
            // gHang
            // 
            this.gHang.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gHang.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gHang.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gHang.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gHang.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gHang.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gHang.Location = new System.Drawing.Point(6, 46);
            this.gHang.MainView = this.gvHang;
            this.gHang.Name = "gHang";
            this.gHang.Size = new System.Drawing.Size(369, 404);
            this.gHang.TabIndex = 99;
            this.gHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHang});
            // 
            // gvHang
            // 
            this.gvHang.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvHang.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvHang.Appearance.FocusedCell.Options.UseFont = true;
            this.gvHang.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvHang.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvHang.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvHang.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvHang.Appearance.Row.BackColor = System.Drawing.Color.Silver;
            this.gvHang.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvHang.Appearance.Row.Options.UseBackColor = true;
            this.gvHang.Appearance.Row.Options.UseBorderColor = true;
            this.gvHang.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvHang.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaH,
            this.TenH});
            this.gvHang.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvHang.GridControl = this.gHang;
            this.gvHang.Name = "gvHang";
            this.gvHang.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvHang.OptionsView.ShowDetailButtons = false;
            this.gvHang.OptionsView.ShowGroupPanel = false;
            this.gvHang.DoubleClick += new System.EventHandler(this.gvHang_DoubleClick);
            // 
            // MaH
            // 
            this.MaH.Caption = "Mã";
            this.MaH.FieldName = "Ma";
            this.MaH.Name = "MaH";
            this.MaH.OptionsColumn.ReadOnly = true;
            this.MaH.Visible = true;
            this.MaH.VisibleIndex = 0;
            this.MaH.Width = 202;
            // 
            // TenH
            // 
            this.TenH.Caption = "Tên";
            this.TenH.FieldName = "Ten";
            this.TenH.Name = "TenH";
            this.TenH.OptionsColumn.ReadOnly = true;
            this.TenH.Visible = true;
            this.TenH.VisibleIndex = 1;
            this.TenH.Width = 405;
            // 
            // btnAccept
            // 
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAccept.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.Image")));
            this.btnAccept.Location = new System.Drawing.Point(738, 465);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnAccept.Size = new System.Drawing.Size(111, 28);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "&Chấp nhận (F2)";
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(850, 465);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnClose.Size = new System.Drawing.Size(91, 28);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Thoát (ESC)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmLookUp_MatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 499);
            this.Controls.Add(this.chkAllDT);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtMatHang);
            this.Controls.Add(this.cboGiaoHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gMatHang);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLookUp_MatHang";
            this.Text = "Tìm kiếm mặt hàng";
            this.Load += new System.EventHandler(this.frmLookUp_MatHang_Load);
            this.Activated += new System.EventHandler(this.frmLookUp_MatHang_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLookUp_MatHang_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gMatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMatHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteNganh.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAllDT;
        private DevExpress.XtraGrid.GridControl gMatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMatHang;
        private DevExpress.XtraGrid.Columns.GridColumn Ma;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private QLBH.Core.Form.GtidTextBox txtMatHang;
        private System.Windows.Forms.ComboBox cboGiaoHang;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Columns.GridColumn Nhom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private QLBH.Core.Form.GtidTextBox txtHangSX;
        private DevExpress.XtraGrid.GridControl gHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHang;
        private DevExpress.XtraGrid.Columns.GridColumn MaH;
        private DevExpress.XtraGrid.Columns.GridColumn TenH;
        private QLBH.Core.Form.GtidButton btnAccept;
        private QLBH.Core.Form.GtidButton btnClose;
        private System.Windows.Forms.ComboBox cboMucCha;
        private System.Windows.Forms.Label label1;
        private QLBH.Core.Form.GtidButton btnTim;
        protected DevExpress.XtraEditors.ButtonEdit bteNganh;
    }
}