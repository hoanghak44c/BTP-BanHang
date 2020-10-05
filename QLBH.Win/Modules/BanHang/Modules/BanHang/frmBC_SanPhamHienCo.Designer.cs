using QLBH.Core.Form;
namespace QLBanHang.Modules.BanHang
{
    partial class frmBC_SanPhamHienCo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBC_SanPhamHienCo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lueNganhHang = new DevExpress.XtraEditors.LookUpEdit();
            this.lblLyDo = new DevExpress.XtraEditors.LabelControl();
            this.btnDong = new QLBH.Core.Form.GtidButton();
            this.btnTim = new QLBH.Core.Form.GtidButton();
            this.cmdExport = new QLBH.Core.Form.GtidButton();
            this.bteKhoXuat = new DevExpress.XtraEditors.ButtonEdit();
            this.bteTrungTam = new DevExpress.XtraEditors.ButtonEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaVach = new QLBH.Core.Form.GtidTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSanPham = new QLBH.Core.Form.GtidTextBox();
            this.lblThuocXuat = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.grpKetQuaTimKiem = new System.Windows.Forms.GroupBox();
            this.gListChungTu = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TonChiTiet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ChungTuLienQuan = new System.Windows.Forms.ToolStripMenuItem();
            this.ChiTietHangTrungChuyen = new System.Windows.Forms.ToolStripMenuItem();
            this.gvListChungTu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Kho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TonAo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTonTrungChuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LinhVuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repLoaiDonHang = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueNganhHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhoXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).BeginInit();
            this.grpKetQuaTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gListChungTu)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListChungTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lueNganhHang);
            this.groupBox1.Controls.Add(this.lblLyDo);
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.cmdExport);
            this.groupBox1.Controls.Add(this.bteKhoXuat);
            this.groupBox1.Controls.Add(this.bteTrungTam);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMaVach);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSanPham);
            this.groupBox1.Controls.Add(this.lblThuocXuat);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1072, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lueNganhHang
            // 
            this.lueNganhHang.Location = new System.Drawing.Point(81, 71);
            this.lueNganhHang.Name = "lueNganhHang";
            this.lueNganhHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueNganhHang.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Ten")});
            this.lueNganhHang.Properties.DisplayMember = "Ten";
            this.lueNganhHang.Properties.NullText = "";
            this.lueNganhHang.Properties.ShowFooter = false;
            this.lueNganhHang.Properties.ShowHeader = false;
            this.lueNganhHang.Properties.ValueMember = "IdLyDoTH";
            this.lueNganhHang.Size = new System.Drawing.Size(329, 20);
            this.lueNganhHang.TabIndex = 126;
            // 
            // lblLyDo
            // 
            this.lblLyDo.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLyDo.Appearance.Options.UseFont = true;
            this.lblLyDo.Location = new System.Drawing.Point(20, 74);
            this.lblLyDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblLyDo.Name = "lblLyDo";
            this.lblLyDo.Size = new System.Drawing.Size(58, 13);
            this.lblLyDo.TabIndex = 127;
            this.lblLyDo.Text = "Ngành hàng";
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(734, 67);
            this.btnDong.Name = "btnDong";
            this.btnDong.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnDong.Size = new System.Drawing.Size(101, 24);
            this.btnDong.TabIndex = 21;
            this.btnDong.Text = "Đóng (F12)";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnTim
            // 
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.Location = new System.Drawing.Point(516, 67);
            this.btnTim.Name = "btnTim";
            this.btnTim.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnTim.Size = new System.Drawing.Size(101, 24);
            this.btnTim.TabIndex = 19;
            this.btnTim.Text = "&Tìm kiếm (F3)";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cmdExport
            // 
            this.cmdExport.Image = ((System.Drawing.Image)(resources.GetObject("cmdExport.Image")));
            this.cmdExport.Location = new System.Drawing.Point(625, 67);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdExport.Size = new System.Drawing.Size(101, 24);
            this.cmdExport.TabIndex = 20;
            this.cmdExport.Text = "Export (F12)";
            this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // bteKhoXuat
            // 
            this.bteKhoXuat.Location = new System.Drawing.Point(81, 43);
            this.bteKhoXuat.Name = "bteKhoXuat";
            this.bteKhoXuat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteKhoXuat.Properties.Appearance.Options.UseFont = true;
            this.bteKhoXuat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteKhoXuat.Size = new System.Drawing.Size(329, 22);
            this.bteKhoXuat.TabIndex = 6;
            this.bteKhoXuat.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteKhoXuat_ButtonClick);
            this.bteKhoXuat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteKhoXuat_KeyDown);
            this.bteKhoXuat.TextChanged += new System.EventHandler(this.bteKhoXuat_TextChanged);
            // 
            // bteTrungTam
            // 
            this.bteTrungTam.Location = new System.Drawing.Point(81, 14);
            this.bteTrungTam.Name = "bteTrungTam";
            this.bteTrungTam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteTrungTam.Properties.Appearance.Options.UseFont = true;
            this.bteTrungTam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteTrungTam.Size = new System.Drawing.Size(329, 22);
            this.bteTrungTam.TabIndex = 5;
            this.bteTrungTam.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteTrungTam_ButtonClick);
            this.bteTrungTam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteTrungTam_KeyDown);
            this.bteTrungTam.TextChanged += new System.EventHandler(this.bteTrungTam_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 118;
            this.label7.Text = "Trung tâm";
            // 
            // txtMaVach
            // 
            this.txtMaVach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVach.Location = new System.Drawing.Point(516, 39);
            this.txtMaVach.Name = "txtMaVach";
            this.txtMaVach.Size = new System.Drawing.Size(339, 20);
            this.txtMaVach.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(454, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 115;
            this.label5.Text = "Mã vạch";
            // 
            // txtSanPham
            // 
            this.txtSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSanPham.Location = new System.Drawing.Point(516, 13);
            this.txtSanPham.Name = "txtSanPham";
            this.txtSanPham.Size = new System.Drawing.Size(339, 20);
            this.txtSanPham.TabIndex = 8;
            // 
            // lblThuocXuat
            // 
            this.lblThuocXuat.AutoSize = true;
            this.lblThuocXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuocXuat.Location = new System.Drawing.Point(455, 16);
            this.lblThuocXuat.Name = "lblThuocXuat";
            this.lblThuocXuat.Size = new System.Drawing.Size(55, 13);
            this.lblThuocXuat.TabIndex = 0;
            this.lblThuocXuat.Text = "Sản phẩm";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(26, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 91;
            this.label17.Text = "Kho xuất";
            // 
            // grpKetQuaTimKiem
            // 
            this.grpKetQuaTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKetQuaTimKiem.Controls.Add(this.gListChungTu);
            this.grpKetQuaTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKetQuaTimKiem.ForeColor = System.Drawing.Color.Black;
            this.grpKetQuaTimKiem.Location = new System.Drawing.Point(1, 110);
            this.grpKetQuaTimKiem.Name = "grpKetQuaTimKiem";
            this.grpKetQuaTimKiem.Size = new System.Drawing.Size(1072, 419);
            this.grpKetQuaTimKiem.TabIndex = 1;
            this.grpKetQuaTimKiem.TabStop = false;
            this.grpKetQuaTimKiem.Text = "Danh sách mã vạch";
            // 
            // gListChungTu
            // 
            this.gListChungTu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gListChungTu.ContextMenuStrip = this.contextMenuStrip1;
            this.gListChungTu.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gListChungTu.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gListChungTu.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gListChungTu.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gListChungTu.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gListChungTu.EmbeddedNavigator.TextStringFormat = "{0} / Tổng số {1}";
            this.gListChungTu.Location = new System.Drawing.Point(6, 19);
            this.gListChungTu.MainView = this.gvListChungTu;
            this.gListChungTu.Name = "gListChungTu";
            this.gListChungTu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repEdit,
            this.repLoaiDonHang});
            this.gListChungTu.Size = new System.Drawing.Size(1060, 394);
            this.gListChungTu.TabIndex = 0;
            this.gListChungTu.UseEmbeddedNavigator = true;
            this.gListChungTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListChungTu});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TonChiTiet,
            this.toolStripSeparator2,
            this.ChungTuLienQuan,
            this.ChiTietHangTrungChuyen});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(227, 76);
            // 
            // TonChiTiet
            // 
            this.TonChiTiet.Name = "TonChiTiet";
            this.TonChiTiet.Size = new System.Drawing.Size(226, 22);
            this.TonChiTiet.Text = "Tồn mã vạch chi tiết";
            this.TonChiTiet.Click += new System.EventHandler(this.TonChiTiet_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(223, 6);
            // 
            // ChungTuLienQuan
            // 
            this.ChungTuLienQuan.Name = "ChungTuLienQuan";
            this.ChungTuLienQuan.Size = new System.Drawing.Size(226, 22);
            this.ChungTuLienQuan.Text = "Chứng từ liên quan";
            this.ChungTuLienQuan.Click += new System.EventHandler(this.ChungTuLienQuan_Click);
            // 
            // ChiTietHangTrungChuyen
            // 
            this.ChiTietHangTrungChuyen.Name = "ChiTietHangTrungChuyen";
            this.ChiTietHangTrungChuyen.Size = new System.Drawing.Size(226, 22);
            this.ChiTietHangTrungChuyen.Text = "Chi tiết hàng trung chuyển";
            this.ChiTietHangTrungChuyen.Click += new System.EventHandler(this.ChiTietHangTrungChuyen_Click);
            // 
            // gvListChungTu
            // 
            this.gvListChungTu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdTrungTam,
            this.IdKho,
            this.TrungTam,
            this.Kho,
            this.colMaKho,
            this.IdSanPham,
            this.MaSanPham,
            this.TenSanPham,
            this.DonViTinh,
            this.SoLuong,
            this.TonAo,
            this.colTonTrungChuyen,
            this.LinhVuc,
            this.Nganh,
            this.colLoa,
            this.colChung,
            this.colNhom,
            this.colModel,
            this.colHang});
            this.gvListChungTu.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvListChungTu.GridControl = this.gListChungTu;
            this.gvListChungTu.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoLuong", null, "  (Tổng số  = {0})")});
            this.gvListChungTu.Name = "gvListChungTu";
            this.gvListChungTu.OptionsView.ColumnAutoWidth = false;
            this.gvListChungTu.OptionsView.ShowAutoFilterRow = true;
            this.gvListChungTu.OptionsView.ShowDetailButtons = false;
            this.gvListChungTu.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvListChungTu_FocusedRowChanged);
            this.gvListChungTu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gListChungTu_KeyDown);
            this.gvListChungTu.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvListChungTu_RowCellStyle);
            this.gvListChungTu.DoubleClick += new System.EventHandler(this.gListChungTu_DoubleClick);
            // 
            // IdTrungTam
            // 
            this.IdTrungTam.Caption = "IdTrungTam";
            this.IdTrungTam.FieldName = "IdTrungTam";
            this.IdTrungTam.Name = "IdTrungTam";
            // 
            // IdKho
            // 
            this.IdKho.Caption = "IdKho";
            this.IdKho.FieldName = "IdKho";
            this.IdKho.Name = "IdKho";
            // 
            // TrungTam
            // 
            this.TrungTam.Caption = "Trung tâm";
            this.TrungTam.FieldName = "TrungTam";
            this.TrungTam.Name = "TrungTam";
            this.TrungTam.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TrungTam.OptionsColumn.ReadOnly = true;
            this.TrungTam.Visible = true;
            this.TrungTam.VisibleIndex = 0;
            this.TrungTam.Width = 176;
            // 
            // Kho
            // 
            this.Kho.Caption = "Tên kho";
            this.Kho.FieldName = "Kho";
            this.Kho.Name = "Kho";
            this.Kho.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Kho.OptionsColumn.ReadOnly = true;
            this.Kho.Visible = true;
            this.Kho.VisibleIndex = 1;
            this.Kho.Width = 250;
            // 
            // colMaKho
            // 
            this.colMaKho.Caption = "Mã Kho";
            this.colMaKho.FieldName = "MaKho";
            this.colMaKho.Name = "colMaKho";
            this.colMaKho.Visible = true;
            this.colMaKho.VisibleIndex = 2;
            // 
            // IdSanPham
            // 
            this.IdSanPham.Caption = "IdSanPham";
            this.IdSanPham.FieldName = "IdSanPham";
            this.IdSanPham.Name = "IdSanPham";
            this.IdSanPham.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.IdSanPham.OptionsColumn.ReadOnly = true;
            // 
            // MaSanPham
            // 
            this.MaSanPham.Caption = "Mã sản phẩm";
            this.MaSanPham.FieldName = "MaSanPham";
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.MaSanPham.OptionsColumn.ReadOnly = true;
            this.MaSanPham.Visible = true;
            this.MaSanPham.VisibleIndex = 3;
            this.MaSanPham.Width = 138;
            // 
            // TenSanPham
            // 
            this.TenSanPham.Caption = "Tên Sản phẩm";
            this.TenSanPham.FieldName = "TenSanPham";
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TenSanPham.OptionsColumn.ReadOnly = true;
            this.TenSanPham.Visible = true;
            this.TenSanPham.VisibleIndex = 4;
            this.TenSanPham.Width = 221;
            // 
            // DonViTinh
            // 
            this.DonViTinh.Caption = "ĐVT";
            this.DonViTinh.FieldName = "DonViTinh";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.DonViTinh.OptionsColumn.ReadOnly = true;
            this.DonViTinh.Visible = true;
            this.DonViTinh.VisibleIndex = 5;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Tồn thật";
            this.SoLuong.FieldName = "TonThat";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.SoLuong.OptionsColumn.ReadOnly = true;
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 6;
            // 
            // TonAo
            // 
            this.TonAo.Caption = "Tồn ảo";
            this.TonAo.DisplayFormat.FormatString = "N0";
            this.TonAo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TonAo.FieldName = "TonAo";
            this.TonAo.Name = "TonAo";
            this.TonAo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TonAo.OptionsColumn.ReadOnly = true;
            this.TonAo.Visible = true;
            this.TonAo.VisibleIndex = 7;
            // 
            // colTonTrungChuyen
            // 
            this.colTonTrungChuyen.Caption = "Trung chuyển";
            this.colTonTrungChuyen.FieldName = "TonTrungChuyen";
            this.colTonTrungChuyen.Name = "colTonTrungChuyen";
            this.colTonTrungChuyen.Visible = true;
            this.colTonTrungChuyen.VisibleIndex = 8;
            // 
            // LinhVuc
            // 
            this.LinhVuc.Caption = "Lĩnh vực";
            this.LinhVuc.FieldName = "LinhVuc";
            this.LinhVuc.Name = "LinhVuc";
            this.LinhVuc.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.LinhVuc.OptionsColumn.ReadOnly = true;
            this.LinhVuc.Visible = true;
            this.LinhVuc.VisibleIndex = 9;
            this.LinhVuc.Width = 95;
            // 
            // Nganh
            // 
            this.Nganh.Caption = "Ngành";
            this.Nganh.FieldName = "Nganh";
            this.Nganh.Name = "Nganh";
            this.Nganh.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Nganh.OptionsColumn.ReadOnly = true;
            this.Nganh.Visible = true;
            this.Nganh.VisibleIndex = 10;
            this.Nganh.Width = 155;
            // 
            // colLoa
            // 
            this.colLoa.Caption = "Loại";
            this.colLoa.FieldName = "Loai";
            this.colLoa.Name = "colLoa";
            this.colLoa.Visible = true;
            this.colLoa.VisibleIndex = 11;
            // 
            // colChung
            // 
            this.colChung.Caption = "Chủng";
            this.colChung.FieldName = "Chung";
            this.colChung.Name = "colChung";
            this.colChung.Visible = true;
            this.colChung.VisibleIndex = 12;
            // 
            // colNhom
            // 
            this.colNhom.Caption = "Nhóm";
            this.colNhom.FieldName = "Nhom";
            this.colNhom.Name = "colNhom";
            this.colNhom.Visible = true;
            this.colNhom.VisibleIndex = 13;
            // 
            // colModel
            // 
            this.colModel.Caption = "Model";
            this.colModel.FieldName = "Model";
            this.colModel.Name = "colModel";
            this.colModel.Visible = true;
            this.colModel.VisibleIndex = 14;
            // 
            // colHang
            // 
            this.colHang.Caption = "Hãng";
            this.colHang.FieldName = "Hang";
            this.colHang.Name = "colHang";
            this.colHang.Visible = true;
            this.colHang.VisibleIndex = 15;
            // 
            // repEdit
            // 
            this.repEdit.AutoHeight = false;
            this.repEdit.Name = "repEdit";
            this.repEdit.ValueChecked = 1;
            this.repEdit.ValueUnchecked = 0;
            // 
            // repLoaiDonHang
            // 
            this.repLoaiDonHang.AutoHeight = false;
            this.repLoaiDonHang.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLoaiDonHang.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.repLoaiDonHang.DisplayMember = "Name";
            this.repLoaiDonHang.Name = "repLoaiDonHang";
            this.repLoaiDonHang.ValueMember = "Id";
            // 
            // frmBC_SanPhamHienCo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 532);
            this.Controls.Add(this.grpKetQuaTimKiem);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmBC_SanPhamHienCo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tồn kho hiện thời";
            this.Load += new System.EventHandler(this.frmBH_TimChungTu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBH_TimChungTu_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueNganhHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhoXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).EndInit();
            this.grpKetQuaTimKiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gListChungTu)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvListChungTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiDonHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpKetQuaTimKiem;
        private System.Windows.Forms.Label label17;
        internal GtidButton btnDong;
        private GtidButton btnTim;
        private GtidTextBox txtSanPham;
        private GtidTextBox txtMaVach;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.ButtonEdit bteTrungTam;
        private DevExpress.XtraEditors.ButtonEdit bteKhoXuat;
        private System.Windows.Forms.Label lblThuocXuat;
        private DevExpress.XtraGrid.GridControl gListChungTu;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListChungTu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLoaiDonHang;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repEdit;
        private GtidButton cmdExport;
        private DevExpress.XtraGrid.Columns.GridColumn IdSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn MaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn DonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn Kho;
        private DevExpress.XtraGrid.Columns.GridColumn TrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Columns.GridColumn LinhVuc;
        private DevExpress.XtraGrid.Columns.GridColumn Nganh;
        private DevExpress.XtraEditors.LookUpEdit lueNganhHang;
        private DevExpress.XtraEditors.LabelControl lblLyDo;
        private DevExpress.XtraGrid.Columns.GridColumn TonAo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TonChiTiet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ChungTuLienQuan;
        private DevExpress.XtraGrid.Columns.GridColumn IdTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn IdKho;
        private DevExpress.XtraGrid.Columns.GridColumn colTonTrungChuyen;
        private System.Windows.Forms.ToolStripMenuItem ChiTietHangTrungChuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKho;
        private DevExpress.XtraGrid.Columns.GridColumn colLoa;
        private DevExpress.XtraGrid.Columns.GridColumn colChung;
        private DevExpress.XtraGrid.Columns.GridColumn colNhom;
        private DevExpress.XtraGrid.Columns.GridColumn colModel;
        private DevExpress.XtraGrid.Columns.GridColumn colHang;
    }
}