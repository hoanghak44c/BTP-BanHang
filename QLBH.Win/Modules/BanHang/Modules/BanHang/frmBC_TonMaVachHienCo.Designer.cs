using QLBH.Core.Form;
namespace QLBanHang.Modules.BanHang
{
    partial class frmBC_TonMaVachHienCo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBC_TonMaVachHienCo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bteSanPham = new DevExpress.XtraEditors.ButtonEdit();
            this.lueLoaiDH = new DevExpress.XtraEditors.LookUpEdit();
            this.lblTrangThaiLinhKien = new DevExpress.XtraEditors.LabelControl();
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
            this.lblThuocXuat = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.grpKetQuaTimKiem = new System.Windows.Forms.GroupBox();
            this.gListChungTu = new DevExpress.XtraGrid.GridControl();
            this.gvListChungTu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Kho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaVach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrungChuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoPhieuNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoChungTuGoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNhaCungCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LinhVuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Loai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLoaiDonHang = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.NgayTon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLoaiDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNganhHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhoXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).BeginInit();
            this.grpKetQuaTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gListChungTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListChungTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bteSanPham);
            this.groupBox1.Controls.Add(this.lueLoaiDH);
            this.groupBox1.Controls.Add(this.lblTrangThaiLinhKien);
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
            // bteSanPham
            // 
            this.bteSanPham.Location = new System.Drawing.Point(537, 15);
            this.bteSanPham.Name = "bteSanPham";
            this.bteSanPham.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteSanPham.Properties.Appearance.Options.UseFont = true;
            this.bteSanPham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteSanPham.Size = new System.Drawing.Size(320, 22);
            this.bteSanPham.TabIndex = 142;
            this.bteSanPham.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteSanPham_ButtonClick);
            this.bteSanPham.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteSanPham_KeyDown);
            this.bteSanPham.TextChanged += new System.EventHandler(this.bteSanPham_TextChanged);
            // 
            // lueLoaiDH
            // 
            this.lueLoaiDH.Location = new System.Drawing.Point(537, 71);
            this.lueLoaiDH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lueLoaiDH.Name = "lueLoaiDH";
            this.lueLoaiDH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lueLoaiDH.Properties.Appearance.Options.UseFont = true;
            this.lueLoaiDH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueLoaiDH.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.lueLoaiDH.Properties.DisplayMember = "Name";
            this.lueLoaiDH.Properties.NullText = "";
            this.lueLoaiDH.Properties.ShowFooter = false;
            this.lueLoaiDH.Properties.ShowHeader = false;
            this.lueLoaiDH.Properties.ValueMember = "Id";
            this.lueLoaiDH.Size = new System.Drawing.Size(320, 20);
            this.lueLoaiDH.TabIndex = 140;
            // 
            // lblTrangThaiLinhKien
            // 
            this.lblTrangThaiLinhKien.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTrangThaiLinhKien.Appearance.Options.UseFont = true;
            this.lblTrangThaiLinhKien.Location = new System.Drawing.Point(442, 74);
            this.lblTrangThaiLinhKien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTrangThaiLinhKien.Name = "lblTrangThaiLinhKien";
            this.lblTrangThaiLinhKien.Size = new System.Drawing.Size(91, 13);
            this.lblTrangThaiLinhKien.TabIndex = 141;
            this.lblTrangThaiLinhKien.Text = "Loại giao dịch nhập";
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
            this.lueNganhHang.Size = new System.Drawing.Size(320, 20);
            this.lueNganhHang.TabIndex = 126;
            this.lueNganhHang.TextChanged += new System.EventHandler(this.lueNganhHang_TextChanged);
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
            this.btnDong.Location = new System.Drawing.Point(875, 68);
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
            this.btnTim.Location = new System.Drawing.Point(875, 12);
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
            this.cmdExport.Location = new System.Drawing.Point(875, 40);
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
            this.bteKhoXuat.Size = new System.Drawing.Size(320, 22);
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
            this.bteTrungTam.Size = new System.Drawing.Size(320, 22);
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
            this.txtMaVach.Location = new System.Drawing.Point(537, 43);
            this.txtMaVach.Name = "txtMaVach";
            this.txtMaVach.Size = new System.Drawing.Size(320, 20);
            this.txtMaVach.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(484, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 115;
            this.label5.Text = "Mã vạch";
            // 
            // lblThuocXuat
            // 
            this.lblThuocXuat.AutoSize = true;
            this.lblThuocXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuocXuat.Location = new System.Drawing.Point(478, 17);
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
            this.repLoaiDonHang});
            this.gListChungTu.Size = new System.Drawing.Size(1060, 394);
            this.gListChungTu.TabIndex = 0;
            this.gListChungTu.UseEmbeddedNavigator = true;
            this.gListChungTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListChungTu});
            // 
            // gvListChungTu
            // 
            this.gvListChungTu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TrungTam,
            this.Kho,
            this.IdSanPham,
            this.MaSanPham,
            this.TenSanPham,
            this.DonViTinh,
            this.MaVach,
            this.SoLuong,
            this.colTrungChuyen,
            this.NgayNhap,
            this.SoPO,
            this.SoPhieuNhap,
            this.SoChungTuGoc,
            this.TenNhaCungCap,
            this.LinhVuc,
            this.Nganh,
            this.Loai,
            this.LoaiChungTu,
            this.NgayTon});
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
            this.MaSanPham.VisibleIndex = 2;
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
            this.TenSanPham.VisibleIndex = 3;
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
            this.DonViTinh.VisibleIndex = 4;
            // 
            // MaVach
            // 
            this.MaVach.Caption = "Mã vạch";
            this.MaVach.FieldName = "MaVach";
            this.MaVach.Name = "MaVach";
            this.MaVach.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.MaVach.OptionsColumn.ReadOnly = true;
            this.MaVach.Visible = true;
            this.MaVach.VisibleIndex = 5;
            this.MaVach.Width = 120;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.SoLuong.OptionsColumn.ReadOnly = true;
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 6;
            this.SoLuong.Width = 77;
            // 
            // colTrungChuyen
            // 
            this.colTrungChuyen.Caption = "Trung chuyển";
            this.colTrungChuyen.FieldName = "TrungChuyen";
            this.colTrungChuyen.Name = "colTrungChuyen";
            this.colTrungChuyen.Visible = true;
            this.colTrungChuyen.VisibleIndex = 7;
            this.colTrungChuyen.Width = 96;
            // 
            // NgayNhap
            // 
            this.NgayNhap.Caption = "Ngày nhập";
            this.NgayNhap.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.NgayNhap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgayNhap.FieldName = "Ngay";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.NgayNhap.OptionsColumn.ReadOnly = true;
            this.NgayNhap.Visible = true;
            this.NgayNhap.VisibleIndex = 8;
            this.NgayNhap.Width = 92;
            // 
            // SoPO
            // 
            this.SoPO.Caption = "Số PO";
            this.SoPO.FieldName = "SoSeri";
            this.SoPO.Name = "SoPO";
            this.SoPO.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.SoPO.OptionsColumn.ReadOnly = true;
            this.SoPO.Visible = true;
            this.SoPO.VisibleIndex = 9;
            this.SoPO.Width = 95;
            // 
            // SoPhieuNhap
            // 
            this.SoPhieuNhap.Caption = "Số phiếu nhập";
            this.SoPhieuNhap.FieldName = "SoChungTu";
            this.SoPhieuNhap.Name = "SoPhieuNhap";
            this.SoPhieuNhap.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.SoPhieuNhap.OptionsColumn.ReadOnly = true;
            this.SoPhieuNhap.Visible = true;
            this.SoPhieuNhap.VisibleIndex = 10;
            this.SoPhieuNhap.Width = 105;
            // 
            // SoChungTuGoc
            // 
            this.SoChungTuGoc.Caption = "Số chứng từ gốc";
            this.SoChungTuGoc.FieldName = "SoChungTuGoc";
            this.SoChungTuGoc.Name = "SoChungTuGoc";
            this.SoChungTuGoc.Visible = true;
            this.SoChungTuGoc.VisibleIndex = 11;
            this.SoChungTuGoc.Width = 104;
            // 
            // TenNhaCungCap
            // 
            this.TenNhaCungCap.Caption = "Nhà cung cấp";
            this.TenNhaCungCap.FieldName = "TenNhaCungCap";
            this.TenNhaCungCap.Name = "TenNhaCungCap";
            this.TenNhaCungCap.Visible = true;
            this.TenNhaCungCap.VisibleIndex = 12;
            this.TenNhaCungCap.Width = 160;
            // 
            // LinhVuc
            // 
            this.LinhVuc.Caption = "Lĩnh vực";
            this.LinhVuc.FieldName = "LinhVuc";
            this.LinhVuc.Name = "LinhVuc";
            this.LinhVuc.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.LinhVuc.OptionsColumn.ReadOnly = true;
            this.LinhVuc.Visible = true;
            this.LinhVuc.VisibleIndex = 13;
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
            this.Nganh.VisibleIndex = 14;
            this.Nganh.Width = 155;
            // 
            // Loai
            // 
            this.Loai.Caption = "Loại";
            this.Loai.FieldName = "Loai";
            this.Loai.Name = "Loai";
            this.Loai.OptionsColumn.ReadOnly = true;
            this.Loai.Visible = true;
            this.Loai.VisibleIndex = 15;
            this.Loai.Width = 157;
            // 
            // LoaiChungTu
            // 
            this.LoaiChungTu.Caption = "Loại giao dịch nhập hàng";
            this.LoaiChungTu.ColumnEdit = this.repLoaiDonHang;
            this.LoaiChungTu.FieldName = "LoaiChungTu";
            this.LoaiChungTu.Name = "LoaiChungTu";
            this.LoaiChungTu.OptionsColumn.ReadOnly = true;
            this.LoaiChungTu.Visible = true;
            this.LoaiChungTu.VisibleIndex = 16;
            this.LoaiChungTu.Width = 175;
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
            // NgayTon
            // 
            this.NgayTon.Caption = "Tuổi tồn (ngày)";
            this.NgayTon.FieldName = "NgayTon";
            this.NgayTon.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.NgayTon.Name = "NgayTon";
            this.NgayTon.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.NgayTon.OptionsColumn.ReadOnly = true;
            this.NgayTon.Visible = true;
            this.NgayTon.VisibleIndex = 17;
            this.NgayTon.Width = 89;
            // 
            // frmBC_TonMaVachHienCo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 532);
            this.Controls.Add(this.grpKetQuaTimKiem);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmBC_TonMaVachHienCo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tồn mã vạch hiện có";
            this.Load += new System.EventHandler(this.frmBH_TimChungTu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBH_TimChungTu_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLoaiDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNganhHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhoXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).EndInit();
            this.grpKetQuaTimKiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gListChungTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListChungTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiDonHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpKetQuaTimKiem;
        private System.Windows.Forms.Label label17;
        internal GtidButton btnDong;
        private GtidButton btnTim;
        private GtidTextBox txtMaVach;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.ButtonEdit bteTrungTam;
        private DevExpress.XtraEditors.ButtonEdit bteKhoXuat;
        private System.Windows.Forms.Label lblThuocXuat;
        private DevExpress.XtraGrid.GridControl gListChungTu;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListChungTu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLoaiDonHang;
        private GtidButton cmdExport;
        private DevExpress.XtraGrid.Columns.GridColumn IdSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn MaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn MaVach;
        private DevExpress.XtraGrid.Columns.GridColumn DonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn Kho;
        private DevExpress.XtraGrid.Columns.GridColumn TrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Columns.GridColumn LinhVuc;
        private DevExpress.XtraGrid.Columns.GridColumn Nganh;
        private DevExpress.XtraEditors.LookUpEdit lueNganhHang;
        private DevExpress.XtraEditors.LabelControl lblLyDo;
        private DevExpress.XtraGrid.Columns.GridColumn SoPO;
        private DevExpress.XtraGrid.Columns.GridColumn SoPhieuNhap;
        private DevExpress.XtraGrid.Columns.GridColumn NgayNhap;
        private DevExpress.XtraGrid.Columns.GridColumn NgayTon;
        private DevExpress.XtraGrid.Columns.GridColumn TenNhaCungCap;
        private DevExpress.XtraGrid.Columns.GridColumn SoChungTuGoc;
        private DevExpress.XtraEditors.LookUpEdit lueLoaiDH;
        private DevExpress.XtraEditors.LabelControl lblTrangThaiLinhKien;
        private DevExpress.XtraGrid.Columns.GridColumn Loai;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn colTrungChuyen;
        private DevExpress.XtraEditors.ButtonEdit bteSanPham;
    }
}