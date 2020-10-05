using QLBH.Core.Form;
namespace QLBanHang.Modules.BanHang
{
    partial class frmCS_ThietLapDiemThuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCS_ThietLapDiemThuong));
            this.grpKetQuaTimKiem = new System.Windows.Forms.GroupBox();
            this.gListData = new DevExpress.XtraGrid.GridControl();
            this.gvListData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeThuongTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeThuongDen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtThuongDen = new QLBH.Core.Form.GtidTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThuongTu = new QLBH.Core.Form.GtidTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bteNganh = new DevExpress.XtraEditors.ButtonEdit();
            this.cboLoaiMaHang = new System.Windows.Forms.ComboBox();
            this.lblThuocXuat = new System.Windows.Forms.Label();
            this.btnImportCT = new QLBH.Core.Form.GtidButton();
            this.btnThemCT = new QLBH.Core.Form.GtidButton();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.btnTim = new QLBH.Core.Form.GtidButton();
            this.bteTrungTam = new DevExpress.XtraEditors.ButtonEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.gListDataLSu = new DevExpress.XtraGrid.GridControl();
            this.gvListDataLSu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new QLBH.Core.Form.GtidButton();
            this.grpKetQuaTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gListData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteNganh.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gListDataLSu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListDataLSu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpKetQuaTimKiem
            // 
            this.grpKetQuaTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKetQuaTimKiem.Controls.Add(this.gListData);
            this.grpKetQuaTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKetQuaTimKiem.ForeColor = System.Drawing.Color.Black;
            this.grpKetQuaTimKiem.Location = new System.Drawing.Point(3, 3);
            this.grpKetQuaTimKiem.Name = "grpKetQuaTimKiem";
            this.grpKetQuaTimKiem.Size = new System.Drawing.Size(953, 443);
            this.grpKetQuaTimKiem.TabIndex = 1;
            this.grpKetQuaTimKiem.TabStop = false;
            // 
            // gListData
            // 
            this.gListData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gListData.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gListData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gListData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gListData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gListData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gListData.EmbeddedNavigator.TextStringFormat = "{0} / {1}";
            this.gListData.Location = new System.Drawing.Point(6, 19);
            this.gListData.MainView = this.gvListData;
            this.gListData.Name = "gListData";
            this.gListData.Size = new System.Drawing.Size(941, 418);
            this.gListData.TabIndex = 0;
            this.gListData.UseEmbeddedNavigator = true;
            this.gListData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListData});
            // 
            // gvListData
            // 
            this.gvListData.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gvListData.Appearance.FooterPanel.Options.UseFont = true;
            this.gvListData.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvListData.Appearance.GroupPanel.Options.UseFont = true;
            this.gvListData.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvListData.Appearance.GroupRow.Options.UseFont = true;
            this.gvListData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaSanPham,
            this.TenSanPham,
            this.TyLeThuongTu,
            this.TyLeThuongDen});
            this.gvListData.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvListData.GridControl = this.gListData;
            this.gvListData.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TienSauChietKhau", null, "{0:N0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TienVAT", null, "{0:N0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ThanhTien", null, "{0:N0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TienChietKhau", null, "{0:N0}")});
            this.gvListData.Name = "gvListData";
            this.gvListData.OptionsView.ShowAutoFilterRow = true;
            this.gvListData.OptionsView.ShowDetailButtons = false;
            this.gvListData.OptionsView.ShowFooter = true;
            this.gvListData.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvListChungTu_RowCellStyle);
            // 
            // MaSanPham
            // 
            this.MaSanPham.Caption = "Mã sản phẩm";
            this.MaSanPham.FieldName = "MaSanPham";
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.OptionsColumn.ReadOnly = true;
            this.MaSanPham.Visible = true;
            this.MaSanPham.VisibleIndex = 0;
            this.MaSanPham.Width = 137;
            // 
            // TenSanPham
            // 
            this.TenSanPham.Caption = "Tên sản phẩm";
            this.TenSanPham.FieldName = "TenSanPham";
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.OptionsColumn.ReadOnly = true;
            this.TenSanPham.Visible = true;
            this.TenSanPham.VisibleIndex = 1;
            this.TenSanPham.Width = 402;
            // 
            // TyLeThuongTu
            // 
            this.TyLeThuongTu.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.TyLeThuongTu.AppearanceHeader.Options.UseBackColor = true;
            this.TyLeThuongTu.Caption = "Tỷ lệ thưởng từ (%)";
            this.TyLeThuongTu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyLeThuongTu.FieldName = "TyLeThuongTu";
            this.TyLeThuongTu.Name = "TyLeThuongTu";
            this.TyLeThuongTu.Visible = true;
            this.TyLeThuongTu.VisibleIndex = 2;
            this.TyLeThuongTu.Width = 152;
            // 
            // TyLeThuongDen
            // 
            this.TyLeThuongDen.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.TyLeThuongDen.AppearanceHeader.Options.UseBackColor = true;
            this.TyLeThuongDen.Caption = "Tỷ lệ thưởng đến (%)";
            this.TyLeThuongDen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyLeThuongDen.FieldName = "TyLeThuongDen";
            this.TyLeThuongDen.Name = "TyLeThuongDen";
            this.TyLeThuongDen.Visible = true;
            this.TyLeThuongDen.VisibleIndex = 3;
            this.TyLeThuongDen.Width = 179;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(966, 512);
            this.xtraTabControl1.TabIndex = 3;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtThuongDen);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Controls.Add(this.txtThuongTu);
            this.xtraTabPage1.Controls.Add(this.label3);
            this.xtraTabPage1.Controls.Add(this.bteNganh);
            this.xtraTabPage1.Controls.Add(this.cboLoaiMaHang);
            this.xtraTabPage1.Controls.Add(this.lblThuocXuat);
            this.xtraTabPage1.Controls.Add(this.btnImportCT);
            this.xtraTabPage1.Controls.Add(this.btnThemCT);
            this.xtraTabPage1.Controls.Add(this.grpKetQuaTimKiem);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(959, 484);
            this.xtraTabPage1.Text = "Thiết lập khung tỷ lệ tích điểm";
            // 
            // txtThuongDen
            // 
            this.txtThuongDen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtThuongDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThuongDen.Location = new System.Drawing.Point(611, 457);
            this.txtThuongDen.Name = "txtThuongDen";
            this.txtThuongDen.Size = new System.Drawing.Size(53, 20);
            this.txtThuongDen.TabIndex = 162;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(567, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 161;
            this.label1.Text = "đến (%)";
            // 
            // txtThuongTu
            // 
            this.txtThuongTu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtThuongTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThuongTu.Location = new System.Drawing.Point(511, 457);
            this.txtThuongTu.Name = "txtThuongTu";
            this.txtThuongTu.Size = new System.Drawing.Size(53, 20);
            this.txtThuongTu.TabIndex = 159;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(432, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 160;
            this.label3.Text = "Tỷ lệ thưởng từ";
            // 
            // bteNganh
            // 
            this.bteNganh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bteNganh.Location = new System.Drawing.Point(181, 456);
            this.bteNganh.Name = "bteNganh";
            this.bteNganh.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.bteNganh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteNganh.Properties.Appearance.Options.UseBackColor = true;
            this.bteNganh.Properties.Appearance.Options.UseFont = true;
            this.bteNganh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteNganh.Size = new System.Drawing.Size(242, 21);
            this.bteNganh.TabIndex = 158;
            this.bteNganh.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteNganh_ButtonClick);
            this.bteNganh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteNganh_KeyDown);
            this.bteNganh.TextChanged += new System.EventHandler(this.bteNganh_TextChanged);
            // 
            // cboLoaiMaHang
            // 
            this.cboLoaiMaHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboLoaiMaHang.AutoCompleteCustomSource.AddRange(new string[] {
            "Nhận hàng tại siêu thị",
            "Giao hàng tại nhà"});
            this.cboLoaiMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiMaHang.FormattingEnabled = true;
            this.cboLoaiMaHang.Items.AddRange(new object[] {
            "Sản phẩm"});
            this.cboLoaiMaHang.Location = new System.Drawing.Point(75, 456);
            this.cboLoaiMaHang.Name = "cboLoaiMaHang";
            this.cboLoaiMaHang.Size = new System.Drawing.Size(103, 21);
            this.cboLoaiMaHang.TabIndex = 157;
            // 
            // lblThuocXuat
            // 
            this.lblThuocXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblThuocXuat.AutoSize = true;
            this.lblThuocXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuocXuat.Location = new System.Drawing.Point(4, 459);
            this.lblThuocXuat.Name = "lblThuocXuat";
            this.lblThuocXuat.Size = new System.Drawing.Size(67, 13);
            this.lblThuocXuat.TabIndex = 156;
            this.lblThuocXuat.Text = "Mã hàng AD";
            // 
            // btnImportCT
            // 
            this.btnImportCT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImportCT.Image = ((System.Drawing.Image)(resources.GetObject("btnImportCT.Image")));
            this.btnImportCT.Location = new System.Drawing.Point(739, 456);
            this.btnImportCT.Name = "btnImportCT";
            this.btnImportCT.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnImportCT.Size = new System.Drawing.Size(62, 22);
            this.btnImportCT.TabIndex = 106;
            this.btnImportCT.Text = "&Import";
            this.btnImportCT.Visible = false;
            // 
            // btnThemCT
            // 
            this.btnThemCT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemCT.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCT.Image")));
            this.btnThemCT.Location = new System.Drawing.Point(671, 456);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnThemCT.Size = new System.Drawing.Size(62, 22);
            this.btnThemCT.TabIndex = 102;
            this.btnThemCT.Text = "&Thêm";
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.btnTim);
            this.xtraTabPage2.Controls.Add(this.bteTrungTam);
            this.xtraTabPage2.Controls.Add(this.label7);
            this.xtraTabPage2.Controls.Add(this.gListDataLSu);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.PageVisible = false;
            this.xtraTabPage2.Size = new System.Drawing.Size(959, 483);
            this.xtraTabPage2.Text = "Lịch sử thiết lập";
            // 
            // btnTim
            // 
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.Location = new System.Drawing.Point(460, 9);
            this.btnTim.Name = "btnTim";
            this.btnTim.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnTim.Size = new System.Drawing.Size(101, 25);
            this.btnTim.TabIndex = 123;
            this.btnTim.Text = "&Tìm kiếm (F3)";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // bteTrungTam
            // 
            this.bteTrungTam.Location = new System.Drawing.Point(127, 11);
            this.bteTrungTam.Name = "bteTrungTam";
            this.bteTrungTam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteTrungTam.Properties.Appearance.Options.UseFont = true;
            this.bteTrungTam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteTrungTam.Size = new System.Drawing.Size(322, 22);
            this.bteTrungTam.TabIndex = 121;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 122;
            this.label7.Text = "Ngành hàng";
            // 
            // gListDataLSu
            // 
            this.gListDataLSu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gListDataLSu.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gListDataLSu.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gListDataLSu.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gListDataLSu.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gListDataLSu.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gListDataLSu.EmbeddedNavigator.TextStringFormat = "{0} / {1}";
            this.gListDataLSu.Location = new System.Drawing.Point(9, 44);
            this.gListDataLSu.MainView = this.gvListDataLSu;
            this.gListDataLSu.Name = "gListDataLSu";
            this.gListDataLSu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemLookUpEdit3,
            this.repositoryItemCheckEdit1});
            this.gListDataLSu.Size = new System.Drawing.Size(891, 438);
            this.gListDataLSu.TabIndex = 1;
            this.gListDataLSu.UseEmbeddedNavigator = true;
            this.gListDataLSu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListDataLSu});
            // 
            // gvListDataLSu
            // 
            this.gvListDataLSu.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gvListDataLSu.Appearance.FooterPanel.Options.UseFont = true;
            this.gvListDataLSu.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvListDataLSu.Appearance.GroupPanel.Options.UseFont = true;
            this.gvListDataLSu.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvListDataLSu.Appearance.GroupRow.Options.UseFont = true;
            this.gvListDataLSu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn5});
            this.gvListDataLSu.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvListDataLSu.GridControl = this.gListDataLSu;
            this.gvListDataLSu.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TienSauChietKhau", null, "{0:N0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TienVAT", null, "{0:N0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ThanhTien", null, "{0:N0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TienChietKhau", null, "{0:N0}")});
            this.gvListDataLSu.Name = "gvListDataLSu";
            this.gvListDataLSu.OptionsView.ShowAutoFilterRow = true;
            this.gvListDataLSu.OptionsView.ShowDetailButtons = false;
            this.gvListDataLSu.OptionsView.ShowFooter = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã sản phẩm";
            this.gridColumn1.FieldName = "MaSanPham";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 165;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên sản phẩm";
            this.gridColumn2.FieldName = "TenSanPham";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 592;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.gridColumn4.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn4.Caption = "Tỷ lệ thưởng từ";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "TyLeThuongTu";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 233;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.gridColumn5.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn5.Caption = "Tỷ lệ thưởng đến";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn5.FieldName = "TyLeThuongDen";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 244;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.repositoryItemLookUpEdit1.DisplayMember = "Name";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "Id";
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.DisplayMember = "Name";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "Id";
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.DisplayMember = "Name";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.ValueMember = "Id";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(773, 530);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 28);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(881, 530);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnClose.Size = new System.Drawing.Size(93, 28);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Thoát (ESC)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCS_ThietLapDiemThuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 568);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.xtraTabControl1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCS_ThietLapDiemThuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập tỷ lệ điểm thưởng";
            this.Load += new System.EventHandler(this.frmBH_TimChungTu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBH_TimChungTu_KeyDown);
            this.grpKetQuaTimKiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gListData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteNganh.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gListDataLSu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListDataLSu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKetQuaTimKiem;
        private DevExpress.XtraGrid.GridControl gListData;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListData;
        private DevExpress.XtraGrid.Columns.GridColumn MaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeThuongTu;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeThuongDen;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private GtidButton btnClose;
        private DevExpress.XtraGrid.GridControl gListDataLSu;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListDataLSu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.ButtonEdit bteTrungTam;
        private System.Windows.Forms.Label label7;
        private GtidButton btnTim;
        private GtidButton btnImportCT;
        protected DevExpress.XtraEditors.ButtonEdit bteNganh;
        private System.Windows.Forms.ComboBox cboLoaiMaHang;
        private System.Windows.Forms.Label lblThuocXuat;
        private GtidButton btnThemCT;
        private GtidTextBox txtThuongDen;
        private System.Windows.Forms.Label label1;
        private GtidTextBox txtThuongTu;
        private System.Windows.Forms.Label label3;
    }
}