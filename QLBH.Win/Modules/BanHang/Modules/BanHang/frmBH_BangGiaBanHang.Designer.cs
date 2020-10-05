using QLBH.Core.Form;
namespace QLBanHang.Modules.BanHang
{
    partial class frmBH_BangGiaBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBH_BangGiaBanHang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bteSanPham = new DevExpress.XtraEditors.ButtonEdit();
            this.lueNganhHang = new DevExpress.XtraEditors.LookUpEdit();
            this.lblLyDo = new DevExpress.XtraEditors.LabelControl();
            this.lblThuocXuat = new System.Windows.Forms.Label();
            this.chkCoTonKho = new System.Windows.Forms.CheckBox();
            this.bteTrungTam = new DevExpress.XtraEditors.ButtonEdit();
            this.btnTim = new QLBH.Core.Form.GtidButton();
            this.label7 = new System.Windows.Forms.Label();
            this.gListSanPham = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TonChiTiet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ChinhSachApDung = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LichSuThayDoiGia = new System.Windows.Forms.ToolStripMenuItem();
            this.gvListSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdChiTietBangGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaNhapHDCuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaNhapDemoCuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaTonKhoBQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGiaChuaVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGiaCoVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBanBuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBanDemo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaNiemYet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaWebSite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoDiemThuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeDiemThuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeDiemThuongMacDinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeThuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThuongNong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrungMaVach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.ChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LinhVuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Model = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTrangThai = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.TonKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TonAo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhuyenMai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslGiamGia = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTangGia = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslNoDThuong = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbTinhDiemThuong = new System.Windows.Forms.ToolStripButton();
            this.tsbDongBoWebsite = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbInBangGia = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tslInfor = new System.Windows.Forms.ToolStripLabel();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtabListApDung = new DevExpress.XtraTab.XtraTabPage();
            this.xtabListNotApDung = new DevExpress.XtraTab.XtraTabPage();
            this.btnExportNoDT = new QLBH.Core.Form.GtidButton();
            this.gListSanPhamNoThuong = new DevExpress.XtraGrid.GridControl();
            this.gvListSanPhamNoThuong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdChiTietBangGia1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdTrungTam1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSanPham1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaSanPham1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPham1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDonViTinh1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaNhapHDCuoi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaNhapDemoCuoi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaTonKhoBQ1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGiaChuaVAT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeVAT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienVAT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGiaCoVAT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeDiemThuongMacDinh1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrungMaVach1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.ChietKhau1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TonKho1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TonAo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhuyenMai1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNganhHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gListSanPham)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrangThai)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtabListApDung.SuspendLayout();
            this.xtabListNotApDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gListSanPhamNoThuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListSanPhamNoThuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bteSanPham);
            this.groupBox1.Controls.Add(this.lueNganhHang);
            this.groupBox1.Controls.Add(this.lblLyDo);
            this.groupBox1.Controls.Add(this.lblThuocXuat);
            this.groupBox1.Controls.Add(this.chkCoTonKho);
            this.groupBox1.Controls.Add(this.bteTrungTam);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(10, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1100, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // bteSanPham
            // 
            this.bteSanPham.Location = new System.Drawing.Point(94, 41);
            this.bteSanPham.Name = "bteSanPham";
            this.bteSanPham.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteSanPham.Properties.Appearance.Options.UseFont = true;
            this.bteSanPham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteSanPham.Size = new System.Drawing.Size(318, 22);
            this.bteSanPham.TabIndex = 127;
            this.bteSanPham.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteSanPham_ButtonClick);
            this.bteSanPham.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bteSanPham_KeyPress);
            this.bteSanPham.TextChanged += new System.EventHandler(this.bteSanPham_TextChanged);
            // 
            // lueNganhHang
            // 
            this.lueNganhHang.Location = new System.Drawing.Point(520, 14);
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
            this.lueNganhHang.Size = new System.Drawing.Size(322, 20);
            this.lueNganhHang.TabIndex = 124;
            // 
            // lblLyDo
            // 
            this.lblLyDo.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLyDo.Appearance.Options.UseFont = true;
            this.lblLyDo.Location = new System.Drawing.Point(459, 19);
            this.lblLyDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblLyDo.Name = "lblLyDo";
            this.lblLyDo.Size = new System.Drawing.Size(58, 13);
            this.lblLyDo.TabIndex = 125;
            this.lblLyDo.Text = "Ngành hàng";
            // 
            // lblThuocXuat
            // 
            this.lblThuocXuat.AutoSize = true;
            this.lblThuocXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuocXuat.Location = new System.Drawing.Point(30, 45);
            this.lblThuocXuat.Name = "lblThuocXuat";
            this.lblThuocXuat.Size = new System.Drawing.Size(55, 13);
            this.lblThuocXuat.TabIndex = 122;
            this.lblThuocXuat.Text = "Sản phẩm";
            // 
            // chkCoTonKho
            // 
            this.chkCoTonKho.AutoSize = true;
            this.chkCoTonKho.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.chkCoTonKho.Location = new System.Drawing.Point(520, 41);
            this.chkCoTonKho.Name = "chkCoTonKho";
            this.chkCoTonKho.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkCoTonKho.Size = new System.Drawing.Size(78, 17);
            this.chkCoTonKho.TabIndex = 121;
            this.chkCoTonKho.Text = "Có tồn kho";
            this.chkCoTonKho.UseVisualStyleBackColor = true;
            // 
            // bteTrungTam
            // 
            this.bteTrungTam.Location = new System.Drawing.Point(94, 14);
            this.bteTrungTam.Name = "bteTrungTam";
            this.bteTrungTam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteTrungTam.Properties.Appearance.Options.UseFont = true;
            this.bteTrungTam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteTrungTam.Size = new System.Drawing.Size(318, 22);
            this.bteTrungTam.TabIndex = 117;
            this.bteTrungTam.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteTrungTam_ButtonClick);
            this.bteTrungTam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteTrungTam_KeyDown);
            this.bteTrungTam.TextChanged += new System.EventHandler(this.bteTrungTam_TextChanged);
            // 
            // btnTim
            // 
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.Location = new System.Drawing.Point(856, 12);
            this.btnTim.Name = "btnTim";
            this.btnTim.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnTim.Size = new System.Drawing.Size(101, 24);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "&Tìm kiếm (F3)";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 118;
            this.label7.Text = "Trung tâm";
            // 
            // gListSanPham
            // 
            this.gListSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gListSanPham.ContextMenuStrip = this.contextMenuStrip1;
            this.gListSanPham.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gListSanPham.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gListSanPham.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gListSanPham.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gListSanPham.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gListSanPham.EmbeddedNavigator.TextStringFormat = "Mặt hàng số {0} / Tổng số {1} mã hàng";
            this.gListSanPham.Location = new System.Drawing.Point(3, 3);
            this.gListSanPham.MainView = this.gvListSanPham;
            this.gListSanPham.Name = "gListSanPham";
            this.gListSanPham.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repEdit,
            this.repTrangThai});
            this.gListSanPham.Size = new System.Drawing.Size(1087, 409);
            this.gListSanPham.TabIndex = 30;
            this.gListSanPham.UseEmbeddedNavigator = true;
            this.gListSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListSanPham});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TonChiTiet,
            this.toolStripSeparator2,
            this.ChinhSachApDung,
            this.toolStripSeparator1,
            this.LichSuThayDoiGia});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 82);
            // 
            // TonChiTiet
            // 
            this.TonChiTiet.Name = "TonChiTiet";
            this.TonChiTiet.Size = new System.Drawing.Size(188, 22);
            this.TonChiTiet.Text = "Tồn kho chi tiết";
            this.TonChiTiet.Click += new System.EventHandler(this.TonChiTiet_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(185, 6);
            // 
            // ChinhSachApDung
            // 
            this.ChinhSachApDung.Name = "ChinhSachApDung";
            this.ChinhSachApDung.Size = new System.Drawing.Size(188, 22);
            this.ChinhSachApDung.Text = "Chính sách áp dụng";
            this.ChinhSachApDung.Click += new System.EventHandler(this.ChinhSachApDung_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // LichSuThayDoiGia
            // 
            this.LichSuThayDoiGia.Name = "LichSuThayDoiGia";
            this.LichSuThayDoiGia.Size = new System.Drawing.Size(188, 22);
            this.LichSuThayDoiGia.Text = "Lịch sử thay đổi giá";
            this.LichSuThayDoiGia.Click += new System.EventHandler(this.LichSuThayDoiGia_Click);
            // 
            // gvListSanPham
            // 
            this.gvListSanPham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdChiTietBangGia,
            this.IdTrungTam,
            this.IdSanPham,
            this.MaSanPham,
            this.TenSanPham,
            this.TenDonViTinh,
            this.GiaNhapHDCuoi,
            this.GiaNhapDemoCuoi,
            this.GiaTonKhoBQ,
            this.DonGiaChuaVAT,
            this.TyLeVAT,
            this.TienVAT,
            this.DonGiaCoVAT,
            this.GiaBanBuon,
            this.GiaBanDemo,
            this.GiaNiemYet,
            this.GiaWebSite,
            this.SoDiemThuong,
            this.TyLeDiemThuong,
            this.TyLeDiemThuongMacDinh,
            this.TyLeThuong,
            this.ThuongNong,
            this.TrungMaVach,
            this.ChietKhau,
            this.LinhVuc,
            this.Nganh,
            this.Model,
            this.GhiChu,
            this.TonKho,
            this.TonAo,
            this.colKhuyenMai});
            this.gvListSanPham.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvListSanPham.GridControl = this.gListSanPham;
            this.gvListSanPham.Name = "gvListSanPham";
            this.gvListSanPham.OptionsView.ColumnAutoWidth = false;
            this.gvListSanPham.OptionsView.ShowAutoFilterRow = true;
            this.gvListSanPham.OptionsView.ShowDetailButtons = false;
            this.gvListSanPham.OptionsView.ShowFooter = true;
            this.gvListSanPham.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvListSanPham_RowStyle);
            // 
            // IdChiTietBangGia
            // 
            this.IdChiTietBangGia.Caption = "IdChiTietBangGia";
            this.IdChiTietBangGia.FieldName = "IdChiTietBangGia";
            this.IdChiTietBangGia.Name = "IdChiTietBangGia";
            // 
            // IdTrungTam
            // 
            this.IdTrungTam.Caption = "IdTrungTam";
            this.IdTrungTam.FieldName = "IdTrungTam";
            this.IdTrungTam.Name = "IdTrungTam";
            // 
            // IdSanPham
            // 
            this.IdSanPham.Caption = "IdSanPham";
            this.IdSanPham.FieldName = "IdSanPham";
            this.IdSanPham.Name = "IdSanPham";
            // 
            // MaSanPham
            // 
            this.MaSanPham.Caption = "Mã sản phẩm";
            this.MaSanPham.FieldName = "MaSanPham";
            this.MaSanPham.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.OptionsColumn.ReadOnly = true;
            this.MaSanPham.Visible = true;
            this.MaSanPham.VisibleIndex = 0;
            this.MaSanPham.Width = 91;
            // 
            // TenSanPham
            // 
            this.TenSanPham.Caption = "Tên sản phẩm";
            this.TenSanPham.FieldName = "TenSanPham";
            this.TenSanPham.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.OptionsColumn.ReadOnly = true;
            this.TenSanPham.Visible = true;
            this.TenSanPham.VisibleIndex = 1;
            this.TenSanPham.Width = 240;
            // 
            // TenDonViTinh
            // 
            this.TenDonViTinh.Caption = "Đơn vị tính";
            this.TenDonViTinh.FieldName = "TenDonViTinh";
            this.TenDonViTinh.Name = "TenDonViTinh";
            this.TenDonViTinh.OptionsColumn.ReadOnly = true;
            this.TenDonViTinh.Visible = true;
            this.TenDonViTinh.VisibleIndex = 2;
            // 
            // GiaNhapHDCuoi
            // 
            this.GiaNhapHDCuoi.Caption = "Giá nhập HĐ cuối";
            this.GiaNhapHDCuoi.DisplayFormat.FormatString = "N0";
            this.GiaNhapHDCuoi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaNhapHDCuoi.FieldName = "GiaNhapHDCuoi";
            this.GiaNhapHDCuoi.Name = "GiaNhapHDCuoi";
            this.GiaNhapHDCuoi.OptionsColumn.ReadOnly = true;
            this.GiaNhapHDCuoi.Width = 111;
            // 
            // GiaNhapDemoCuoi
            // 
            this.GiaNhapDemoCuoi.Caption = "Giá nhập Demo cuối";
            this.GiaNhapDemoCuoi.DisplayFormat.FormatString = "N0";
            this.GiaNhapDemoCuoi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaNhapDemoCuoi.FieldName = "GiaNhapDemoCuoi";
            this.GiaNhapDemoCuoi.Name = "GiaNhapDemoCuoi";
            this.GiaNhapDemoCuoi.OptionsColumn.ReadOnly = true;
            this.GiaNhapDemoCuoi.Width = 107;
            // 
            // GiaTonKhoBQ
            // 
            this.GiaTonKhoBQ.Caption = "Giá tồn kho BQ";
            this.GiaTonKhoBQ.DisplayFormat.FormatString = "N0";
            this.GiaTonKhoBQ.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaTonKhoBQ.FieldName = "GiaTonKhoBQ";
            this.GiaTonKhoBQ.Name = "GiaTonKhoBQ";
            this.GiaTonKhoBQ.OptionsColumn.ReadOnly = true;
            this.GiaTonKhoBQ.Width = 124;
            // 
            // DonGiaChuaVAT
            // 
            this.DonGiaChuaVAT.Caption = "Giá chưa VAT";
            this.DonGiaChuaVAT.DisplayFormat.FormatString = "N0";
            this.DonGiaChuaVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DonGiaChuaVAT.FieldName = "DonGiaChuaVAT";
            this.DonGiaChuaVAT.Name = "DonGiaChuaVAT";
            this.DonGiaChuaVAT.Visible = true;
            this.DonGiaChuaVAT.VisibleIndex = 3;
            this.DonGiaChuaVAT.Width = 88;
            // 
            // TyLeVAT
            // 
            this.TyLeVAT.Caption = "Tỷ lệ VAT";
            this.TyLeVAT.DisplayFormat.FormatString = "N0";
            this.TyLeVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyLeVAT.FieldName = "TyLeVAT";
            this.TyLeVAT.Name = "TyLeVAT";
            this.TyLeVAT.OptionsColumn.ReadOnly = true;
            this.TyLeVAT.Visible = true;
            this.TyLeVAT.VisibleIndex = 4;
            // 
            // TienVAT
            // 
            this.TienVAT.Caption = "Tiền VAT";
            this.TienVAT.DisplayFormat.FormatString = "N0";
            this.TienVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TienVAT.FieldName = "TienVAT";
            this.TienVAT.Name = "TienVAT";
            this.TienVAT.Visible = true;
            this.TienVAT.VisibleIndex = 5;
            // 
            // DonGiaCoVAT
            // 
            this.DonGiaCoVAT.Caption = "Giá bán lẻ";
            this.DonGiaCoVAT.DisplayFormat.FormatString = "N0";
            this.DonGiaCoVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DonGiaCoVAT.FieldName = "DonGiaCoVAT";
            this.DonGiaCoVAT.Name = "DonGiaCoVAT";
            this.DonGiaCoVAT.OptionsColumn.ReadOnly = true;
            this.DonGiaCoVAT.Visible = true;
            this.DonGiaCoVAT.VisibleIndex = 6;
            // 
            // GiaBanBuon
            // 
            this.GiaBanBuon.Caption = "Giá bán buôn";
            this.GiaBanBuon.DisplayFormat.FormatString = "N0";
            this.GiaBanBuon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaBanBuon.FieldName = "GiaBanBuon";
            this.GiaBanBuon.Name = "GiaBanBuon";
            this.GiaBanBuon.OptionsColumn.ReadOnly = true;
            this.GiaBanBuon.Visible = true;
            this.GiaBanBuon.VisibleIndex = 7;
            // 
            // GiaBanDemo
            // 
            this.GiaBanDemo.Caption = "Giá bán Demo";
            this.GiaBanDemo.DisplayFormat.FormatString = "N0";
            this.GiaBanDemo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaBanDemo.FieldName = "GiaBanDemo";
            this.GiaBanDemo.Name = "GiaBanDemo";
            this.GiaBanDemo.OptionsColumn.ReadOnly = true;
            this.GiaBanDemo.Visible = true;
            this.GiaBanDemo.VisibleIndex = 8;
            this.GiaBanDemo.Width = 107;
            // 
            // GiaNiemYet
            // 
            this.GiaNiemYet.Caption = "Giá niêm yết";
            this.GiaNiemYet.DisplayFormat.FormatString = "N0";
            this.GiaNiemYet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaNiemYet.FieldName = "GiaNiemYet";
            this.GiaNiemYet.Name = "GiaNiemYet";
            this.GiaNiemYet.OptionsColumn.ReadOnly = true;
            this.GiaNiemYet.Visible = true;
            this.GiaNiemYet.VisibleIndex = 9;
            // 
            // GiaWebSite
            // 
            this.GiaWebSite.Caption = "Giá Website";
            this.GiaWebSite.DisplayFormat.FormatString = "N0";
            this.GiaWebSite.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaWebSite.FieldName = "GiaWebSite";
            this.GiaWebSite.Name = "GiaWebSite";
            this.GiaWebSite.OptionsColumn.ReadOnly = true;
            this.GiaWebSite.Visible = true;
            this.GiaWebSite.VisibleIndex = 10;
            // 
            // SoDiemThuong
            // 
            this.SoDiemThuong.Caption = "Số điểm thưởng";
            this.SoDiemThuong.FieldName = "SoDiemThuong";
            this.SoDiemThuong.Name = "SoDiemThuong";
            this.SoDiemThuong.Visible = true;
            this.SoDiemThuong.VisibleIndex = 11;
            this.SoDiemThuong.Width = 94;
            // 
            // TyLeDiemThuong
            // 
            this.TyLeDiemThuong.Caption = "Tỷ lệ điểm thưởng (%)";
            this.TyLeDiemThuong.DisplayFormat.FormatString = "N2";
            this.TyLeDiemThuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyLeDiemThuong.FieldName = "TyLeDiemThuong";
            this.TyLeDiemThuong.Name = "TyLeDiemThuong";
            this.TyLeDiemThuong.Visible = true;
            this.TyLeDiemThuong.VisibleIndex = 12;
            this.TyLeDiemThuong.Width = 124;
            // 
            // TyLeDiemThuongMacDinh
            // 
            this.TyLeDiemThuongMacDinh.Caption = "Tỷ lệ điểm thưởng mặc định (%)";
            this.TyLeDiemThuongMacDinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyLeDiemThuongMacDinh.FieldName = "TyLeDiemThuongMacDinh";
            this.TyLeDiemThuongMacDinh.Name = "TyLeDiemThuongMacDinh";
            this.TyLeDiemThuongMacDinh.Visible = true;
            this.TyLeDiemThuongMacDinh.VisibleIndex = 13;
            this.TyLeDiemThuongMacDinh.Width = 147;
            // 
            // TyLeThuong
            // 
            this.TyLeThuong.Caption = "Tỷ lệ thưởng";
            this.TyLeThuong.DisplayFormat.FormatString = "N0";
            this.TyLeThuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyLeThuong.FieldName = "TyLeThuong";
            this.TyLeThuong.Name = "TyLeThuong";
            this.TyLeThuong.OptionsColumn.ReadOnly = true;
            // 
            // ThuongNong
            // 
            this.ThuongNong.Caption = "Thưởng nóng";
            this.ThuongNong.DisplayFormat.FormatString = "N0";
            this.ThuongNong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ThuongNong.FieldName = "ThuongNong";
            this.ThuongNong.Name = "ThuongNong";
            this.ThuongNong.OptionsColumn.ReadOnly = true;
            this.ThuongNong.Visible = true;
            this.ThuongNong.VisibleIndex = 14;
            this.ThuongNong.Width = 106;
            // 
            // TrungMaVach
            // 
            this.TrungMaVach.Caption = "Trùng mã vạch";
            this.TrungMaVach.ColumnEdit = this.repEdit;
            this.TrungMaVach.FieldName = "TrungMaVach";
            this.TrungMaVach.Name = "TrungMaVach";
            this.TrungMaVach.OptionsColumn.ReadOnly = true;
            this.TrungMaVach.Visible = true;
            this.TrungMaVach.VisibleIndex = 15;
            this.TrungMaVach.Width = 108;
            // 
            // repEdit
            // 
            this.repEdit.AutoHeight = false;
            this.repEdit.Name = "repEdit";
            this.repEdit.ValueChecked = 1;
            this.repEdit.ValueUnchecked = 0;
            // 
            // ChietKhau
            // 
            this.ChietKhau.Caption = "Chiết khấu";
            this.ChietKhau.ColumnEdit = this.repEdit;
            this.ChietKhau.FieldName = "ChietKhau";
            this.ChietKhau.Name = "ChietKhau";
            this.ChietKhau.OptionsColumn.ReadOnly = true;
            this.ChietKhau.Visible = true;
            this.ChietKhau.VisibleIndex = 16;
            this.ChietKhau.Width = 87;
            // 
            // LinhVuc
            // 
            this.LinhVuc.Caption = "Lĩnh vực";
            this.LinhVuc.FieldName = "LinhVuc";
            this.LinhVuc.Name = "LinhVuc";
            this.LinhVuc.OptionsColumn.ReadOnly = true;
            this.LinhVuc.Visible = true;
            this.LinhVuc.VisibleIndex = 17;
            this.LinhVuc.Width = 115;
            // 
            // Nganh
            // 
            this.Nganh.Caption = "Ngành";
            this.Nganh.FieldName = "Nganh";
            this.Nganh.Name = "Nganh";
            this.Nganh.Visible = true;
            this.Nganh.VisibleIndex = 18;
            this.Nganh.Width = 195;
            // 
            // Model
            // 
            this.Model.Caption = "Model";
            this.Model.FieldName = "Model";
            this.Model.Name = "Model";
            this.Model.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Model.OptionsColumn.ReadOnly = true;
            this.Model.Visible = true;
            this.Model.VisibleIndex = 19;
            this.Model.Width = 166;
            // 
            // GhiChu
            // 
            this.GhiChu.Caption = "Ghi chú";
            this.GhiChu.ColumnEdit = this.repTrangThai;
            this.GhiChu.FieldName = "GhiChu";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.OptionsColumn.AllowEdit = false;
            this.GhiChu.Visible = true;
            this.GhiChu.VisibleIndex = 20;
            // 
            // repTrangThai
            // 
            this.repTrangThai.AutoHeight = false;
            this.repTrangThai.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repTrangThai.DisplayMember = "Name";
            this.repTrangThai.Name = "repTrangThai";
            this.repTrangThai.ValueMember = "Id";
            // 
            // TonKho
            // 
            this.TonKho.Caption = "Tồn thật";
            this.TonKho.DisplayFormat.FormatString = "N0";
            this.TonKho.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TonKho.FieldName = "TonKho";
            this.TonKho.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.TonKho.Name = "TonKho";
            this.TonKho.OptionsColumn.ReadOnly = true;
            this.TonKho.SummaryItem.DisplayFormat = "{0:N0}";
            this.TonKho.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.TonKho.Visible = true;
            this.TonKho.VisibleIndex = 22;
            // 
            // TonAo
            // 
            this.TonAo.Caption = "Tồn ảo";
            this.TonAo.DisplayFormat.FormatString = "N0";
            this.TonAo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TonAo.FieldName = "TonAo";
            this.TonAo.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.TonAo.Name = "TonAo";
            this.TonAo.SummaryItem.DisplayFormat = "{0:N0}";
            this.TonAo.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.TonAo.Visible = true;
            this.TonAo.VisibleIndex = 23;
            // 
            // colKhuyenMai
            // 
            this.colKhuyenMai.Caption = "Khuyến mại";
            this.colKhuyenMai.FieldName = "KhuyenMai";
            this.colKhuyenMai.Name = "colKhuyenMai";
            this.colKhuyenMai.Visible = true;
            this.colKhuyenMai.VisibleIndex = 21;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslGiamGia,
            this.tsslTangGia,
            this.tsslNoDThuong});
            this.statusStrip1.Location = new System.Drawing.Point(0, 555);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(1115, 22);
            this.statusStrip1.TabIndex = 109;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslGiamGia
            // 
            this.tsslGiamGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tsslGiamGia.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslGiamGia.ForeColor = System.Drawing.Color.Yellow;
            this.tsslGiamGia.Name = "tsslGiamGia";
            this.tsslGiamGia.Size = new System.Drawing.Size(98, 17);
            this.tsslGiamGia.Text = "   Giảm giá bán   ";
            // 
            // tsslTangGia
            // 
            this.tsslTangGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tsslTangGia.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.tsslTangGia.ForeColor = System.Drawing.Color.Navy;
            this.tsslTangGia.Name = "tsslTangGia";
            this.tsslTangGia.Size = new System.Drawing.Size(100, 17);
            this.tsslTangGia.Text = "   Tăng giá bán    ";
            // 
            // tsslNoDThuong
            // 
            this.tsslNoDThuong.BackColor = System.Drawing.Color.Yellow;
            this.tsslNoDThuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslNoDThuong.Name = "tsslNoDThuong";
            this.tsslNoDThuong.Size = new System.Drawing.Size(148, 17);
            this.tsslNoDThuong.Text = "  Không có điểm thưởng  ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.tsbTinhDiemThuong,
            this.tsbDongBoWebsite,
            this.toolStripSeparator3,
            this.tsbInBangGia,
            this.tsbExport,
            this.tsbClose,
            this.toolStripSeparator7,
            this.tslInfor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1115, 25);
            this.toolStrip1.TabIndex = 110;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator6.Visible = false;
            // 
            // tsbTinhDiemThuong
            // 
            this.tsbTinhDiemThuong.Image = ((System.Drawing.Image)(resources.GetObject("tsbTinhDiemThuong.Image")));
            this.tsbTinhDiemThuong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTinhDiemThuong.Name = "tsbTinhDiemThuong";
            this.tsbTinhDiemThuong.Size = new System.Drawing.Size(146, 22);
            this.tsbTinhDiemThuong.Text = "Tính điểm thưởng (F9)";
            this.tsbTinhDiemThuong.Click += new System.EventHandler(this.tsbTinhDiemThuong_Click);
            // 
            // tsbDongBoWebsite
            // 
            this.tsbDongBoWebsite.Image = ((System.Drawing.Image)(resources.GetObject("tsbDongBoWebsite.Image")));
            this.tsbDongBoWebsite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDongBoWebsite.Name = "tsbDongBoWebsite";
            this.tsbDongBoWebsite.Size = new System.Drawing.Size(141, 22);
            this.tsbDongBoWebsite.Text = "Đồng bộ Website (F6)";
            this.tsbDongBoWebsite.Click += new System.EventHandler(this.tsbDongBoWebsite_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbInBangGia
            // 
            this.tsbInBangGia.Image = ((System.Drawing.Image)(resources.GetObject("tsbInBangGia.Image")));
            this.tsbInBangGia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInBangGia.Name = "tsbInBangGia";
            this.tsbInBangGia.Size = new System.Drawing.Size(109, 22);
            this.tsbInBangGia.Text = "In bảng giá (F5)";
            this.tsbInBangGia.Click += new System.EventHandler(this.tsbInBangGia_Click);
            // 
            // tsbExport
            // 
            this.tsbExport.Image = ((System.Drawing.Image)(resources.GetObject("tsbExport.Image")));
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(121, 22);
            this.tsbExport.Text = "Kết xuất Excel (F3)";
            this.tsbExport.Click += new System.EventHandler(this.tsbExport_Click);
            // 
            // tsbClose
            // 
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(85, 22);
            this.tsbClose.Text = "Đ&óng (F12)";
            this.tsbClose.ToolTipText = "Đóng (F12)";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // tslInfor
            // 
            this.tslInfor.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslInfor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslInfor.Name = "tslInfor";
            this.tslInfor.Size = new System.Drawing.Size(100, 22);
            this.tslInfor.Text = "Bảng giá hiện tại";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(10, 111);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtabListApDung;
            this.xtraTabControl1.Size = new System.Drawing.Size(1100, 441);
            this.xtraTabControl1.TabIndex = 111;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtabListApDung,
            this.xtabListNotApDung});
            // 
            // xtabListApDung
            // 
            this.xtabListApDung.Controls.Add(this.gListSanPham);
            this.xtabListApDung.Name = "xtabListApDung";
            this.xtabListApDung.Size = new System.Drawing.Size(1093, 413);
            this.xtabListApDung.Text = "Danh sách giá hiện tại các sản phẩm";
            // 
            // xtabListNotApDung
            // 
            this.xtabListNotApDung.Controls.Add(this.btnExportNoDT);
            this.xtabListNotApDung.Controls.Add(this.gListSanPhamNoThuong);
            this.xtabListNotApDung.Name = "xtabListNotApDung";
            this.xtabListNotApDung.Size = new System.Drawing.Size(1093, 412);
            this.xtabListNotApDung.Text = "Danh sách mặt hàng không có điểm thưởng";
            // 
            // btnExportNoDT
            // 
            this.btnExportNoDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportNoDT.Image = ((System.Drawing.Image)(resources.GetObject("btnExportNoDT.Image")));
            this.btnExportNoDT.Location = new System.Drawing.Point(958, 10);
            this.btnExportNoDT.Name = "btnExportNoDT";
            this.btnExportNoDT.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnExportNoDT.Size = new System.Drawing.Size(121, 22);
            this.btnExportNoDT.TabIndex = 153;
            this.btnExportNoDT.Text = "Kết xuất Excel";
            this.btnExportNoDT.Visible = false;
            this.btnExportNoDT.Click += new System.EventHandler(this.btnExportNoDT_Click);
            // 
            // gListSanPhamNoThuong
            // 
            this.gListSanPhamNoThuong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gListSanPhamNoThuong.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gListSanPhamNoThuong.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gListSanPhamNoThuong.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gListSanPhamNoThuong.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gListSanPhamNoThuong.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gListSanPhamNoThuong.EmbeddedNavigator.TextStringFormat = "Mặt hàng số {0} / Tổng số {1} mã hàng";
            this.gListSanPhamNoThuong.Location = new System.Drawing.Point(3, 3);
            this.gListSanPhamNoThuong.MainView = this.gvListSanPhamNoThuong;
            this.gListSanPhamNoThuong.Name = "gListSanPhamNoThuong";
            this.gListSanPhamNoThuong.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemLookUpEdit1});
            this.gListSanPhamNoThuong.Size = new System.Drawing.Size(1087, 407);
            this.gListSanPhamNoThuong.TabIndex = 104;
            this.gListSanPhamNoThuong.UseEmbeddedNavigator = true;
            this.gListSanPhamNoThuong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListSanPhamNoThuong});
            // 
            // gvListSanPhamNoThuong
            // 
            this.gvListSanPhamNoThuong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdChiTietBangGia1,
            this.IdTrungTam1,
            this.IdSanPham1,
            this.MaSanPham1,
            this.TenSanPham1,
            this.TenDonViTinh1,
            this.GiaNhapHDCuoi1,
            this.GiaNhapDemoCuoi1,
            this.GiaTonKhoBQ1,
            this.DonGiaChuaVAT1,
            this.TyLeVAT1,
            this.TienVAT1,
            this.DonGiaCoVAT1,
            this.TyLeDiemThuongMacDinh1,
            this.TrungMaVach1,
            this.ChietKhau1,
            this.TonKho1,
            this.TonAo1,
            this.colKhuyenMai1});
            this.gvListSanPhamNoThuong.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvListSanPhamNoThuong.GridControl = this.gListSanPhamNoThuong;
            this.gvListSanPhamNoThuong.Name = "gvListSanPhamNoThuong";
            this.gvListSanPhamNoThuong.OptionsView.ColumnAutoWidth = false;
            this.gvListSanPhamNoThuong.OptionsView.ShowAutoFilterRow = true;
            this.gvListSanPhamNoThuong.OptionsView.ShowDetailButtons = false;
            this.gvListSanPhamNoThuong.OptionsView.ShowFooter = true;
            // 
            // IdChiTietBangGia1
            // 
            this.IdChiTietBangGia1.Caption = "IdChiTietBangGia";
            this.IdChiTietBangGia1.FieldName = "IdChiTietBangGia";
            this.IdChiTietBangGia1.Name = "IdChiTietBangGia1";
            // 
            // IdTrungTam1
            // 
            this.IdTrungTam1.Caption = "IdTrungTam";
            this.IdTrungTam1.FieldName = "IdTrungTam";
            this.IdTrungTam1.Name = "IdTrungTam1";
            // 
            // IdSanPham1
            // 
            this.IdSanPham1.Caption = "IdSanPham";
            this.IdSanPham1.FieldName = "IdSanPham";
            this.IdSanPham1.Name = "IdSanPham1";
            // 
            // MaSanPham1
            // 
            this.MaSanPham1.Caption = "Mã sản phẩm";
            this.MaSanPham1.FieldName = "MaSanPham";
            this.MaSanPham1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.MaSanPham1.Name = "MaSanPham1";
            this.MaSanPham1.OptionsColumn.ReadOnly = true;
            this.MaSanPham1.Visible = true;
            this.MaSanPham1.VisibleIndex = 0;
            this.MaSanPham1.Width = 91;
            // 
            // TenSanPham1
            // 
            this.TenSanPham1.Caption = "Tên sản phẩm";
            this.TenSanPham1.FieldName = "TenSanPham";
            this.TenSanPham1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.TenSanPham1.Name = "TenSanPham1";
            this.TenSanPham1.OptionsColumn.ReadOnly = true;
            this.TenSanPham1.Visible = true;
            this.TenSanPham1.VisibleIndex = 1;
            this.TenSanPham1.Width = 240;
            // 
            // TenDonViTinh1
            // 
            this.TenDonViTinh1.Caption = "Đơn vị tính";
            this.TenDonViTinh1.FieldName = "TenDonViTinh";
            this.TenDonViTinh1.Name = "TenDonViTinh1";
            this.TenDonViTinh1.OptionsColumn.ReadOnly = true;
            this.TenDonViTinh1.Visible = true;
            this.TenDonViTinh1.VisibleIndex = 2;
            // 
            // GiaNhapHDCuoi1
            // 
            this.GiaNhapHDCuoi1.Caption = "Giá nhập HĐ cuối";
            this.GiaNhapHDCuoi1.DisplayFormat.FormatString = "N0";
            this.GiaNhapHDCuoi1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaNhapHDCuoi1.FieldName = "GiaNhapHDCuoi";
            this.GiaNhapHDCuoi1.Name = "GiaNhapHDCuoi1";
            this.GiaNhapHDCuoi1.OptionsColumn.ReadOnly = true;
            this.GiaNhapHDCuoi1.Width = 111;
            // 
            // GiaNhapDemoCuoi1
            // 
            this.GiaNhapDemoCuoi1.Caption = "Giá nhập Demo cuối";
            this.GiaNhapDemoCuoi1.DisplayFormat.FormatString = "N0";
            this.GiaNhapDemoCuoi1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaNhapDemoCuoi1.FieldName = "GiaNhapDemoCuoi";
            this.GiaNhapDemoCuoi1.Name = "GiaNhapDemoCuoi1";
            this.GiaNhapDemoCuoi1.OptionsColumn.ReadOnly = true;
            this.GiaNhapDemoCuoi1.Width = 107;
            // 
            // GiaTonKhoBQ1
            // 
            this.GiaTonKhoBQ1.Caption = "Giá tồn kho BQ";
            this.GiaTonKhoBQ1.DisplayFormat.FormatString = "N0";
            this.GiaTonKhoBQ1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaTonKhoBQ1.FieldName = "GiaTonKhoBQ";
            this.GiaTonKhoBQ1.Name = "GiaTonKhoBQ1";
            this.GiaTonKhoBQ1.OptionsColumn.ReadOnly = true;
            this.GiaTonKhoBQ1.Width = 124;
            // 
            // DonGiaChuaVAT1
            // 
            this.DonGiaChuaVAT1.Caption = "Giá chưa VAT";
            this.DonGiaChuaVAT1.DisplayFormat.FormatString = "N0";
            this.DonGiaChuaVAT1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DonGiaChuaVAT1.FieldName = "DonGiaChuaVAT";
            this.DonGiaChuaVAT1.Name = "DonGiaChuaVAT1";
            this.DonGiaChuaVAT1.Visible = true;
            this.DonGiaChuaVAT1.VisibleIndex = 3;
            this.DonGiaChuaVAT1.Width = 88;
            // 
            // TyLeVAT1
            // 
            this.TyLeVAT1.Caption = "Tỷ lệ VAT";
            this.TyLeVAT1.DisplayFormat.FormatString = "N0";
            this.TyLeVAT1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyLeVAT1.FieldName = "TyLeVAT";
            this.TyLeVAT1.Name = "TyLeVAT1";
            this.TyLeVAT1.OptionsColumn.ReadOnly = true;
            this.TyLeVAT1.Visible = true;
            this.TyLeVAT1.VisibleIndex = 4;
            // 
            // TienVAT1
            // 
            this.TienVAT1.Caption = "Tiền VAT";
            this.TienVAT1.DisplayFormat.FormatString = "N0";
            this.TienVAT1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TienVAT1.FieldName = "TienVAT";
            this.TienVAT1.Name = "TienVAT1";
            this.TienVAT1.Visible = true;
            this.TienVAT1.VisibleIndex = 5;
            // 
            // DonGiaCoVAT1
            // 
            this.DonGiaCoVAT1.Caption = "Giá bán lẻ";
            this.DonGiaCoVAT1.DisplayFormat.FormatString = "N0";
            this.DonGiaCoVAT1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DonGiaCoVAT1.FieldName = "DonGiaCoVAT";
            this.DonGiaCoVAT1.Name = "DonGiaCoVAT1";
            this.DonGiaCoVAT1.OptionsColumn.ReadOnly = true;
            this.DonGiaCoVAT1.Visible = true;
            this.DonGiaCoVAT1.VisibleIndex = 6;
            // 
            // TyLeDiemThuongMacDinh1
            // 
            this.TyLeDiemThuongMacDinh1.Caption = "Tỷ lệ điểm thưởng mặc định (%)";
            this.TyLeDiemThuongMacDinh1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyLeDiemThuongMacDinh1.FieldName = "TyLeDiemThuongMacDinh";
            this.TyLeDiemThuongMacDinh1.Name = "TyLeDiemThuongMacDinh1";
            this.TyLeDiemThuongMacDinh1.Visible = true;
            this.TyLeDiemThuongMacDinh1.VisibleIndex = 7;
            this.TyLeDiemThuongMacDinh1.Width = 147;
            // 
            // TrungMaVach1
            // 
            this.TrungMaVach1.Caption = "Trùng mã vạch";
            this.TrungMaVach1.ColumnEdit = this.repositoryItemCheckEdit1;
            this.TrungMaVach1.FieldName = "TrungMaVach";
            this.TrungMaVach1.Name = "TrungMaVach1";
            this.TrungMaVach1.OptionsColumn.ReadOnly = true;
            this.TrungMaVach1.Visible = true;
            this.TrungMaVach1.VisibleIndex = 8;
            this.TrungMaVach1.Width = 108;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // ChietKhau1
            // 
            this.ChietKhau1.Caption = "Chiết khấu";
            this.ChietKhau1.ColumnEdit = this.repositoryItemCheckEdit1;
            this.ChietKhau1.FieldName = "ChietKhau";
            this.ChietKhau1.Name = "ChietKhau1";
            this.ChietKhau1.OptionsColumn.ReadOnly = true;
            this.ChietKhau1.Visible = true;
            this.ChietKhau1.VisibleIndex = 9;
            this.ChietKhau1.Width = 87;
            // 
            // TonKho1
            // 
            this.TonKho1.Caption = "Tồn thật";
            this.TonKho1.DisplayFormat.FormatString = "N0";
            this.TonKho1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TonKho1.FieldName = "TonKho";
            this.TonKho1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.TonKho1.Name = "TonKho1";
            this.TonKho1.OptionsColumn.ReadOnly = true;
            this.TonKho1.SummaryItem.DisplayFormat = "{0:N0}";
            this.TonKho1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.TonKho1.Visible = true;
            this.TonKho1.VisibleIndex = 11;
            // 
            // TonAo1
            // 
            this.TonAo1.Caption = "Tồn ảo";
            this.TonAo1.DisplayFormat.FormatString = "N0";
            this.TonAo1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TonAo1.FieldName = "TonAo";
            this.TonAo1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.TonAo1.Name = "TonAo1";
            this.TonAo1.SummaryItem.DisplayFormat = "{0:N0}";
            this.TonAo1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.TonAo1.Visible = true;
            this.TonAo1.VisibleIndex = 12;
            // 
            // colKhuyenMai1
            // 
            this.colKhuyenMai1.Caption = "Khuyến mại";
            this.colKhuyenMai1.FieldName = "KhuyenMai";
            this.colKhuyenMai1.Name = "colKhuyenMai1";
            this.colKhuyenMai1.Visible = true;
            this.colKhuyenMai1.VisibleIndex = 10;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DisplayMember = "Name";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "Id";
            // 
            // frmBH_BangGiaBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 577);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmBH_BangGiaBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng giá hiện tại";
            this.Load += new System.EventHandler(this.frmBH_TimChungTu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBH_TimChungTu_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNganhHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gListSanPham)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvListSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrangThai)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtabListApDung.ResumeLayout(false);
            this.xtabListNotApDung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gListSanPhamNoThuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListSanPhamNoThuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private GtidButton btnTim;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.ButtonEdit bteTrungTam;
        private DevExpress.XtraGrid.GridControl gListSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListSanPham;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repEdit;
        private DevExpress.XtraGrid.Columns.GridColumn IdChiTietBangGia;
        private DevExpress.XtraGrid.Columns.GridColumn IdTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn IdSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn MaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TenDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn GiaNhapHDCuoi;
        private DevExpress.XtraGrid.Columns.GridColumn GiaNhapDemoCuoi;
        private DevExpress.XtraGrid.Columns.GridColumn GiaTonKhoBQ;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeVAT;
        private DevExpress.XtraGrid.Columns.GridColumn DonGiaCoVAT;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBanBuon;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBanDemo;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeThuong;
        private DevExpress.XtraGrid.Columns.GridColumn ThuongNong;
        private DevExpress.XtraGrid.Columns.GridColumn TrungMaVach;
        private DevExpress.XtraGrid.Columns.GridColumn ChietKhau;
        private DevExpress.XtraGrid.Columns.GridColumn GiaNiemYet;
        private DevExpress.XtraGrid.Columns.GridColumn GiaWebSite;
        private DevExpress.XtraGrid.Columns.GridColumn LinhVuc;
        private DevExpress.XtraGrid.Columns.GridColumn TonKho;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TonChiTiet;
        private System.Windows.Forms.ToolStripMenuItem ChinhSachApDung;
        private DevExpress.XtraGrid.Columns.GridColumn TonAo;
        private DevExpress.XtraGrid.Columns.GridColumn DonGiaChuaVAT;
        private DevExpress.XtraGrid.Columns.GridColumn TienVAT;
        private DevExpress.XtraGrid.Columns.GridColumn Nganh;
        private System.Windows.Forms.ToolStripMenuItem LichSuThayDoiGia;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.CheckBox chkCoTonKho;
        private System.Windows.Forms.Label lblThuocXuat;
        private DevExpress.XtraEditors.LookUpEdit lueNganhHang;
        private DevExpress.XtraEditors.LabelControl lblLyDo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel tsslGiamGia;
        private System.Windows.Forms.ToolStripStatusLabel tsslTangGia;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn Model;
        private DevExpress.XtraGrid.Columns.GridColumn colKhuyenMai;
        private DevExpress.XtraEditors.ButtonEdit bteSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeDiemThuongMacDinh;
        private DevExpress.XtraGrid.Columns.GridColumn SoDiemThuong;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeDiemThuong;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripLabel tslInfor;
        private System.Windows.Forms.ToolStripButton tsbTinhDiemThuong;
        private System.Windows.Forms.ToolStripButton tsbDongBoWebsite;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbInBangGia;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.ToolStripStatusLabel tsslNoDThuong;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtabListApDung;
        private DevExpress.XtraTab.XtraTabPage xtabListNotApDung;
        private GtidButton btnExportNoDT;
        private DevExpress.XtraGrid.GridControl gListSanPhamNoThuong;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListSanPhamNoThuong;
        private DevExpress.XtraGrid.Columns.GridColumn IdChiTietBangGia1;
        private DevExpress.XtraGrid.Columns.GridColumn IdTrungTam1;
        private DevExpress.XtraGrid.Columns.GridColumn IdSanPham1;
        private DevExpress.XtraGrid.Columns.GridColumn MaSanPham1;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPham1;
        private DevExpress.XtraGrid.Columns.GridColumn TenDonViTinh1;
        private DevExpress.XtraGrid.Columns.GridColumn GiaNhapHDCuoi1;
        private DevExpress.XtraGrid.Columns.GridColumn GiaNhapDemoCuoi1;
        private DevExpress.XtraGrid.Columns.GridColumn GiaTonKhoBQ1;
        private DevExpress.XtraGrid.Columns.GridColumn DonGiaChuaVAT1;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeVAT1;
        private DevExpress.XtraGrid.Columns.GridColumn TienVAT1;
        private DevExpress.XtraGrid.Columns.GridColumn DonGiaCoVAT1;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeDiemThuongMacDinh1;
        private DevExpress.XtraGrid.Columns.GridColumn TrungMaVach1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn ChietKhau1;
        private DevExpress.XtraGrid.Columns.GridColumn TonKho1;
        private DevExpress.XtraGrid.Columns.GridColumn TonAo1;
        private DevExpress.XtraGrid.Columns.GridColumn colKhuyenMai1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    }
}