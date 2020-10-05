using QLBH.Core.Form;
namespace QLBanHang.Modules.BanHang
{
    partial class frmBC_ChinhSachGiaChiTiet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBC_ChinhSachGiaChiTiet));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkHieuLuc = new System.Windows.Forms.CheckBox();
            this.chkDiemThuong = new System.Windows.Forms.CheckBox();
            this.lueNganhHang = new DevExpress.XtraEditors.LookUpEdit();
            this.lblLyDo = new DevExpress.XtraEditors.LabelControl();
            this.txtSanPham = new QLBH.Core.Form.GtidTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdExport = new QLBH.Core.Form.GtidButton();
            this.btnDong = new QLBH.Core.Form.GtidButton();
            this.bteTrungTam = new DevExpress.XtraEditors.ButtonEdit();
            this.btnTim = new QLBH.Core.Form.GtidButton();
            this.label7 = new System.Windows.Forms.Label();
            this.grpKetQuaTimKiem = new System.Windows.Forms.GroupBox();
            this.gListSanPham = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TonChiTiet = new System.Windows.Forms.ToolStripMenuItem();
            this.ChinhSachApDung = new System.Windows.Forms.ToolStripMenuItem();
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
            this.TyLeThuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThuongNong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrungMaVach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.TyLeDiemThuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoDiemThuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeDiemThuongMacDinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KhuyenMai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repMemoEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.LinhVuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueNganhHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).BeginInit();
            this.grpKetQuaTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gListSanPham)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repMemoEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkHieuLuc);
            this.groupBox1.Controls.Add(this.chkDiemThuong);
            this.groupBox1.Controls.Add(this.lueNganhHang);
            this.groupBox1.Controls.Add(this.lblLyDo);
            this.groupBox1.Controls.Add(this.txtSanPham);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmdExport);
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Controls.Add(this.bteTrungTam);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1077, 87);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // chkHieuLuc
            // 
            this.chkHieuLuc.AutoSize = true;
            this.chkHieuLuc.Checked = true;
            this.chkHieuLuc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHieuLuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHieuLuc.Location = new System.Drawing.Point(691, 47);
            this.chkHieuLuc.Name = "chkHieuLuc";
            this.chkHieuLuc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkHieuLuc.Size = new System.Drawing.Size(92, 17);
            this.chkHieuLuc.TabIndex = 129;
            this.chkHieuLuc.Text = "Đang hiệu lực";
            this.chkHieuLuc.UseVisualStyleBackColor = true;
            // 
            // chkDiemThuong
            // 
            this.chkDiemThuong.AutoSize = true;
            this.chkDiemThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDiemThuong.Location = new System.Drawing.Point(543, 48);
            this.chkDiemThuong.Name = "chkDiemThuong";
            this.chkDiemThuong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkDiemThuong.Size = new System.Drawing.Size(101, 17);
            this.chkDiemThuong.TabIndex = 128;
            this.chkDiemThuong.Text = "Có điểm thưởng";
            this.chkDiemThuong.UseVisualStyleBackColor = true;
            // 
            // lueNganhHang
            // 
            this.lueNganhHang.Location = new System.Drawing.Point(543, 21);
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
            this.lueNganhHang.Size = new System.Drawing.Size(258, 20);
            this.lueNganhHang.TabIndex = 126;
            // 
            // lblLyDo
            // 
            this.lblLyDo.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLyDo.Appearance.Options.UseFont = true;
            this.lblLyDo.Location = new System.Drawing.Point(482, 25);
            this.lblLyDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblLyDo.Name = "lblLyDo";
            this.lblLyDo.Size = new System.Drawing.Size(58, 13);
            this.lblLyDo.TabIndex = 127;
            this.lblLyDo.Text = "Ngành hàng";
            // 
            // txtSanPham
            // 
            this.txtSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSanPham.Location = new System.Drawing.Point(88, 49);
            this.txtSanPham.Name = "txtSanPham";
            this.txtSanPham.Size = new System.Drawing.Size(352, 20);
            this.txtSanPham.TabIndex = 124;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 122;
            this.label1.Text = "Sản phẩm";
            // 
            // cmdExport
            // 
            this.cmdExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExport.Image = ((System.Drawing.Image)(resources.GetObject("cmdExport.Image")));
            this.cmdExport.Location = new System.Drawing.Point(969, 52);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdExport.Size = new System.Drawing.Size(101, 25);
            this.cmdExport.TabIndex = 21;
            this.cmdExport.Text = "Export (F12)";
            this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(969, 19);
            this.btnDong.Name = "btnDong";
            this.btnDong.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnDong.Size = new System.Drawing.Size(101, 25);
            this.btnDong.TabIndex = 120;
            this.btnDong.Text = "Thoát (ESC)";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // bteTrungTam
            // 
            this.bteTrungTam.Location = new System.Drawing.Point(88, 19);
            this.bteTrungTam.Name = "bteTrungTam";
            this.bteTrungTam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteTrungTam.Properties.Appearance.Options.UseFont = true;
            this.bteTrungTam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteTrungTam.Size = new System.Drawing.Size(352, 22);
            this.bteTrungTam.TabIndex = 117;
            this.bteTrungTam.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteTrungTam_ButtonClick);
            this.bteTrungTam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteTrungTam_KeyDown);
            this.bteTrungTam.TextChanged += new System.EventHandler(this.bteTrungTam_TextChanged);
            // 
            // btnTim
            // 
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.Location = new System.Drawing.Point(807, 19);
            this.btnTim.Name = "btnTim";
            this.btnTim.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnTim.Size = new System.Drawing.Size(101, 25);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "&Tìm kiếm (F3)";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 118;
            this.label7.Text = "Trung tâm";
            // 
            // grpKetQuaTimKiem
            // 
            this.grpKetQuaTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKetQuaTimKiem.Controls.Add(this.gListSanPham);
            this.grpKetQuaTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKetQuaTimKiem.ForeColor = System.Drawing.Color.Black;
            this.grpKetQuaTimKiem.Location = new System.Drawing.Point(10, 105);
            this.grpKetQuaTimKiem.Name = "grpKetQuaTimKiem";
            this.grpKetQuaTimKiem.Size = new System.Drawing.Size(1077, 424);
            this.grpKetQuaTimKiem.TabIndex = 3;
            this.grpKetQuaTimKiem.TabStop = false;
            this.grpKetQuaTimKiem.Text = "Danh sách mã hàng";
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
            this.gListSanPham.Location = new System.Drawing.Point(6, 19);
            this.gListSanPham.MainView = this.gvListSanPham;
            this.gListSanPham.Name = "gListSanPham";
            this.gListSanPham.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repEdit,
            this.repMemoEdit});
            this.gListSanPham.Size = new System.Drawing.Size(1065, 399);
            this.gListSanPham.TabIndex = 30;
            this.gListSanPham.UseEmbeddedNavigator = true;
            this.gListSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListSanPham});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TonChiTiet,
            this.ChinhSachApDung});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // TonChiTiet
            // 
            this.TonChiTiet.Name = "TonChiTiet";
            this.TonChiTiet.Size = new System.Drawing.Size(180, 22);
            this.TonChiTiet.Text = "Tồn kho chi tiết";
            // 
            // ChinhSachApDung
            // 
            this.ChinhSachApDung.Name = "ChinhSachApDung";
            this.ChinhSachApDung.Size = new System.Drawing.Size(180, 22);
            this.ChinhSachApDung.Text = "Chính sách áp dụng";
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
            this.TyLeThuong,
            this.ThuongNong,
            this.TrungMaVach,
            this.TyLeDiemThuong,
            this.SoDiemThuong,
            this.TyLeDiemThuongMacDinh,
            this.ChietKhau,
            this.KhuyenMai,
            this.LinhVuc,
            this.Nganh});
            this.gvListSanPham.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvListSanPham.GridControl = this.gListSanPham;
            this.gvListSanPham.Name = "gvListSanPham";
            this.gvListSanPham.OptionsView.ColumnAutoWidth = false;
            this.gvListSanPham.OptionsView.ShowAutoFilterRow = true;
            this.gvListSanPham.OptionsView.ShowDetailButtons = false;
            // 
            // IdChiTietBangGia
            // 
            this.IdChiTietBangGia.AppearanceCell.Options.UseTextOptions = true;
            this.IdChiTietBangGia.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.IdChiTietBangGia.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.IdChiTietBangGia.Caption = "IdChiTietBangGia";
            this.IdChiTietBangGia.FieldName = "IdChiTietBangGia";
            this.IdChiTietBangGia.Name = "IdChiTietBangGia";
            this.IdChiTietBangGia.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.IdChiTietBangGia.OptionsColumn.ReadOnly = true;
            // 
            // IdTrungTam
            // 
            this.IdTrungTam.AppearanceCell.Options.UseTextOptions = true;
            this.IdTrungTam.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.IdTrungTam.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.IdTrungTam.Caption = "IdTrungTam";
            this.IdTrungTam.FieldName = "IdTrungTam";
            this.IdTrungTam.Name = "IdTrungTam";
            this.IdTrungTam.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.IdTrungTam.OptionsColumn.ReadOnly = true;
            // 
            // IdSanPham
            // 
            this.IdSanPham.AppearanceCell.Options.UseTextOptions = true;
            this.IdSanPham.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.IdSanPham.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.IdSanPham.Caption = "IdSanPham";
            this.IdSanPham.FieldName = "IdSanPham";
            this.IdSanPham.Name = "IdSanPham";
            this.IdSanPham.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.IdSanPham.OptionsColumn.ReadOnly = true;
            // 
            // MaSanPham
            // 
            this.MaSanPham.AppearanceCell.Options.UseTextOptions = true;
            this.MaSanPham.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.MaSanPham.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.MaSanPham.Caption = "Mã sản phẩm";
            this.MaSanPham.FieldName = "MaSanPham";
            this.MaSanPham.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.MaSanPham.OptionsColumn.ReadOnly = true;
            this.MaSanPham.Visible = true;
            this.MaSanPham.VisibleIndex = 0;
            this.MaSanPham.Width = 91;
            // 
            // TenSanPham
            // 
            this.TenSanPham.AppearanceCell.Options.UseTextOptions = true;
            this.TenSanPham.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.TenSanPham.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TenSanPham.Caption = "Tên sản phẩm";
            this.TenSanPham.FieldName = "TenSanPham";
            this.TenSanPham.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TenSanPham.OptionsColumn.ReadOnly = true;
            this.TenSanPham.Visible = true;
            this.TenSanPham.VisibleIndex = 1;
            this.TenSanPham.Width = 240;
            // 
            // TenDonViTinh
            // 
            this.TenDonViTinh.AppearanceCell.Options.UseTextOptions = true;
            this.TenDonViTinh.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.TenDonViTinh.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TenDonViTinh.Caption = "Đơn vị tính";
            this.TenDonViTinh.FieldName = "TenDonViTinh";
            this.TenDonViTinh.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.TenDonViTinh.Name = "TenDonViTinh";
            this.TenDonViTinh.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TenDonViTinh.OptionsColumn.ReadOnly = true;
            this.TenDonViTinh.Visible = true;
            this.TenDonViTinh.VisibleIndex = 2;
            // 
            // GiaNhapHDCuoi
            // 
            this.GiaNhapHDCuoi.AppearanceCell.Options.UseTextOptions = true;
            this.GiaNhapHDCuoi.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.GiaNhapHDCuoi.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.GiaNhapHDCuoi.Caption = "Giá nhập HĐ cuối";
            this.GiaNhapHDCuoi.DisplayFormat.FormatString = "N0";
            this.GiaNhapHDCuoi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaNhapHDCuoi.FieldName = "GiaNhapHDCuoi";
            this.GiaNhapHDCuoi.Name = "GiaNhapHDCuoi";
            this.GiaNhapHDCuoi.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.GiaNhapHDCuoi.OptionsColumn.ReadOnly = true;
            this.GiaNhapHDCuoi.Width = 111;
            // 
            // GiaNhapDemoCuoi
            // 
            this.GiaNhapDemoCuoi.AppearanceCell.Options.UseTextOptions = true;
            this.GiaNhapDemoCuoi.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.GiaNhapDemoCuoi.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.GiaNhapDemoCuoi.Caption = "Giá nhập Demo cuối";
            this.GiaNhapDemoCuoi.DisplayFormat.FormatString = "N0";
            this.GiaNhapDemoCuoi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaNhapDemoCuoi.FieldName = "GiaNhapDemoCuoi";
            this.GiaNhapDemoCuoi.Name = "GiaNhapDemoCuoi";
            this.GiaNhapDemoCuoi.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.GiaNhapDemoCuoi.OptionsColumn.ReadOnly = true;
            this.GiaNhapDemoCuoi.Width = 107;
            // 
            // GiaTonKhoBQ
            // 
            this.GiaTonKhoBQ.AppearanceCell.Options.UseTextOptions = true;
            this.GiaTonKhoBQ.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.GiaTonKhoBQ.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.GiaTonKhoBQ.Caption = "Giá tồn kho BQ";
            this.GiaTonKhoBQ.DisplayFormat.FormatString = "N0";
            this.GiaTonKhoBQ.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaTonKhoBQ.FieldName = "GiaTonKhoBQ";
            this.GiaTonKhoBQ.Name = "GiaTonKhoBQ";
            this.GiaTonKhoBQ.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.GiaTonKhoBQ.OptionsColumn.ReadOnly = true;
            this.GiaTonKhoBQ.Width = 124;
            // 
            // DonGiaChuaVAT
            // 
            this.DonGiaChuaVAT.AppearanceCell.Options.UseTextOptions = true;
            this.DonGiaChuaVAT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.DonGiaChuaVAT.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.DonGiaChuaVAT.Caption = "Giá chưa VAT";
            this.DonGiaChuaVAT.DisplayFormat.FormatString = "N0";
            this.DonGiaChuaVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DonGiaChuaVAT.FieldName = "DonGiaChuaVAT";
            this.DonGiaChuaVAT.Name = "DonGiaChuaVAT";
            this.DonGiaChuaVAT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.DonGiaChuaVAT.OptionsColumn.ReadOnly = true;
            this.DonGiaChuaVAT.Visible = true;
            this.DonGiaChuaVAT.VisibleIndex = 3;
            this.DonGiaChuaVAT.Width = 88;
            // 
            // TyLeVAT
            // 
            this.TyLeVAT.AppearanceCell.Options.UseTextOptions = true;
            this.TyLeVAT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.TyLeVAT.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TyLeVAT.Caption = "Tỷ lệ VAT";
            this.TyLeVAT.DisplayFormat.FormatString = "N0";
            this.TyLeVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyLeVAT.FieldName = "TyLeVAT";
            this.TyLeVAT.Name = "TyLeVAT";
            this.TyLeVAT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TyLeVAT.OptionsColumn.ReadOnly = true;
            this.TyLeVAT.Visible = true;
            this.TyLeVAT.VisibleIndex = 4;
            // 
            // TienVAT
            // 
            this.TienVAT.AppearanceCell.Options.UseTextOptions = true;
            this.TienVAT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.TienVAT.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TienVAT.Caption = "Tiền VAT";
            this.TienVAT.DisplayFormat.FormatString = "N0";
            this.TienVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TienVAT.FieldName = "TienVAT";
            this.TienVAT.Name = "TienVAT";
            this.TienVAT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TienVAT.OptionsColumn.ReadOnly = true;
            this.TienVAT.Visible = true;
            this.TienVAT.VisibleIndex = 5;
            // 
            // DonGiaCoVAT
            // 
            this.DonGiaCoVAT.AppearanceCell.Options.UseTextOptions = true;
            this.DonGiaCoVAT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.DonGiaCoVAT.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.DonGiaCoVAT.Caption = "Giá bán lẻ";
            this.DonGiaCoVAT.DisplayFormat.FormatString = "N0";
            this.DonGiaCoVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DonGiaCoVAT.FieldName = "DonGiaCoVAT";
            this.DonGiaCoVAT.Name = "DonGiaCoVAT";
            this.DonGiaCoVAT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.DonGiaCoVAT.OptionsColumn.ReadOnly = true;
            this.DonGiaCoVAT.Visible = true;
            this.DonGiaCoVAT.VisibleIndex = 6;
            // 
            // GiaBanBuon
            // 
            this.GiaBanBuon.AppearanceCell.Options.UseTextOptions = true;
            this.GiaBanBuon.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.GiaBanBuon.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.GiaBanBuon.Caption = "Giá bán buôn";
            this.GiaBanBuon.DisplayFormat.FormatString = "N0";
            this.GiaBanBuon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaBanBuon.FieldName = "GiaBanBuon";
            this.GiaBanBuon.Name = "GiaBanBuon";
            this.GiaBanBuon.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.GiaBanBuon.OptionsColumn.ReadOnly = true;
            this.GiaBanBuon.Visible = true;
            this.GiaBanBuon.VisibleIndex = 7;
            // 
            // GiaBanDemo
            // 
            this.GiaBanDemo.AppearanceCell.Options.UseTextOptions = true;
            this.GiaBanDemo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.GiaBanDemo.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.GiaBanDemo.Caption = "Giá bán Demo";
            this.GiaBanDemo.DisplayFormat.FormatString = "N0";
            this.GiaBanDemo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaBanDemo.FieldName = "GiaBanDemo";
            this.GiaBanDemo.Name = "GiaBanDemo";
            this.GiaBanDemo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.GiaBanDemo.OptionsColumn.ReadOnly = true;
            this.GiaBanDemo.Visible = true;
            this.GiaBanDemo.VisibleIndex = 8;
            this.GiaBanDemo.Width = 107;
            // 
            // GiaNiemYet
            // 
            this.GiaNiemYet.AppearanceCell.Options.UseTextOptions = true;
            this.GiaNiemYet.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.GiaNiemYet.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.GiaNiemYet.Caption = "Giá niêm yết";
            this.GiaNiemYet.DisplayFormat.FormatString = "N0";
            this.GiaNiemYet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaNiemYet.FieldName = "GiaNiemYet";
            this.GiaNiemYet.Name = "GiaNiemYet";
            this.GiaNiemYet.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.GiaNiemYet.OptionsColumn.ReadOnly = true;
            this.GiaNiemYet.Visible = true;
            this.GiaNiemYet.VisibleIndex = 9;
            // 
            // GiaWebSite
            // 
            this.GiaWebSite.AppearanceCell.Options.UseTextOptions = true;
            this.GiaWebSite.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.GiaWebSite.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.GiaWebSite.Caption = "Giá Website";
            this.GiaWebSite.DisplayFormat.FormatString = "N0";
            this.GiaWebSite.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaWebSite.FieldName = "GiaWebSite";
            this.GiaWebSite.Name = "GiaWebSite";
            this.GiaWebSite.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.GiaWebSite.OptionsColumn.ReadOnly = true;
            this.GiaWebSite.Visible = true;
            this.GiaWebSite.VisibleIndex = 10;
            // 
            // TyLeThuong
            // 
            this.TyLeThuong.AppearanceCell.Options.UseTextOptions = true;
            this.TyLeThuong.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.TyLeThuong.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TyLeThuong.Caption = "Tỷ lệ thưởng";
            this.TyLeThuong.DisplayFormat.FormatString = "N0";
            this.TyLeThuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyLeThuong.FieldName = "TyLeThuong";
            this.TyLeThuong.Name = "TyLeThuong";
            this.TyLeThuong.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TyLeThuong.OptionsColumn.ReadOnly = true;
            this.TyLeThuong.Visible = true;
            this.TyLeThuong.VisibleIndex = 11;
            // 
            // ThuongNong
            // 
            this.ThuongNong.AppearanceCell.Options.UseTextOptions = true;
            this.ThuongNong.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.ThuongNong.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ThuongNong.Caption = "Thưởng nóng";
            this.ThuongNong.DisplayFormat.FormatString = "N0";
            this.ThuongNong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ThuongNong.FieldName = "ThuongNong";
            this.ThuongNong.Name = "ThuongNong";
            this.ThuongNong.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.ThuongNong.OptionsColumn.ReadOnly = true;
            this.ThuongNong.Visible = true;
            this.ThuongNong.VisibleIndex = 12;
            this.ThuongNong.Width = 106;
            // 
            // TrungMaVach
            // 
            this.TrungMaVach.AppearanceCell.Options.UseTextOptions = true;
            this.TrungMaVach.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.TrungMaVach.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TrungMaVach.Caption = "Trùng mã vạch";
            this.TrungMaVach.ColumnEdit = this.repEdit;
            this.TrungMaVach.FieldName = "TrungMaVach";
            this.TrungMaVach.Name = "TrungMaVach";
            this.TrungMaVach.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TrungMaVach.OptionsColumn.ReadOnly = true;
            this.TrungMaVach.Visible = true;
            this.TrungMaVach.VisibleIndex = 13;
            this.TrungMaVach.Width = 108;
            // 
            // repEdit
            // 
            this.repEdit.AutoHeight = false;
            this.repEdit.Name = "repEdit";
            this.repEdit.ValueChecked = 1;
            this.repEdit.ValueUnchecked = 0;
            // 
            // TyLeDiemThuong
            // 
            this.TyLeDiemThuong.Caption = "Tỷ lệ điểm thưởng";
            this.TyLeDiemThuong.FieldName = "TyLeDiemThuong";
            this.TyLeDiemThuong.Name = "TyLeDiemThuong";
            this.TyLeDiemThuong.Width = 107;
            // 
            // SoDiemThuong
            // 
            this.SoDiemThuong.Caption = "Số điểm thưởng";
            this.SoDiemThuong.FieldName = "SoDiemThuong";
            this.SoDiemThuong.Name = "SoDiemThuong";
            this.SoDiemThuong.SummaryItem.DisplayFormat = "{0:N0}";
            this.SoDiemThuong.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.SoDiemThuong.Width = 119;
            // 
            // TyLeDiemThuongMacDinh
            // 
            this.TyLeDiemThuongMacDinh.Caption = "TLệ điểm thưởng mặc định";
            this.TyLeDiemThuongMacDinh.FieldName = "TyLeDiemThuongMacDinh";
            this.TyLeDiemThuongMacDinh.Name = "TyLeDiemThuongMacDinh";
            this.TyLeDiemThuongMacDinh.Width = 127;
            // 
            // ChietKhau
            // 
            this.ChietKhau.AppearanceCell.Options.UseTextOptions = true;
            this.ChietKhau.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.ChietKhau.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ChietKhau.Caption = "Chiết khấu";
            this.ChietKhau.ColumnEdit = this.repEdit;
            this.ChietKhau.FieldName = "ChietKhau";
            this.ChietKhau.Name = "ChietKhau";
            this.ChietKhau.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.ChietKhau.OptionsColumn.ReadOnly = true;
            this.ChietKhau.Visible = true;
            this.ChietKhau.VisibleIndex = 14;
            this.ChietKhau.Width = 87;
            // 
            // KhuyenMai
            // 
            this.KhuyenMai.AppearanceCell.Options.UseTextOptions = true;
            this.KhuyenMai.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.KhuyenMai.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.KhuyenMai.Caption = "Sản phẩm khuyến mại";
            this.KhuyenMai.ColumnEdit = this.repMemoEdit;
            this.KhuyenMai.FieldName = "ChinhSachKhuyenMai";
            this.KhuyenMai.Name = "KhuyenMai";
            this.KhuyenMai.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.KhuyenMai.OptionsColumn.ReadOnly = true;
            this.KhuyenMai.Visible = true;
            this.KhuyenMai.VisibleIndex = 15;
            this.KhuyenMai.Width = 340;
            // 
            // repMemoEdit
            // 
            this.repMemoEdit.Name = "repMemoEdit";
            // 
            // LinhVuc
            // 
            this.LinhVuc.Caption = "Lĩnh vực";
            this.LinhVuc.FieldName = "LinhVuc";
            this.LinhVuc.Name = "LinhVuc";
            this.LinhVuc.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.LinhVuc.OptionsColumn.ReadOnly = true;
            this.LinhVuc.Visible = true;
            this.LinhVuc.VisibleIndex = 16;
            this.LinhVuc.Width = 100;
            // 
            // Nganh
            // 
            this.Nganh.Caption = "Ngành";
            this.Nganh.FieldName = "Nganh";
            this.Nganh.Name = "Nganh";
            this.Nganh.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Nganh.OptionsColumn.ReadOnly = true;
            this.Nganh.Visible = true;
            this.Nganh.VisibleIndex = 17;
            this.Nganh.Width = 124;
            // 
            // frmBC_ChinhSachGiaChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 532);
            this.Controls.Add(this.grpKetQuaTimKiem);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmBC_ChinhSachGiaChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chính sách giá chi tiết";
            this.Load += new System.EventHandler(this.frmBH_TimChungTu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBH_TimChungTu_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueNganhHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).EndInit();
            this.grpKetQuaTimKiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gListSanPham)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvListSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repMemoEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpKetQuaTimKiem;
        private GtidButton btnTim;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.ButtonEdit bteTrungTam;
        private DevExpress.XtraGrid.GridControl gListSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListSanPham;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repEdit;
        private GtidButton btnDong;
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TonChiTiet;
        private System.Windows.Forms.ToolStripMenuItem ChinhSachApDung;
        private DevExpress.XtraGrid.Columns.GridColumn DonGiaChuaVAT;
        private DevExpress.XtraGrid.Columns.GridColumn TienVAT;
        private GtidButton cmdExport;
        private DevExpress.XtraGrid.Columns.GridColumn KhuyenMai;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn LinhVuc;
        private DevExpress.XtraGrid.Columns.GridColumn Nganh;
        private GtidTextBox txtSanPham;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repMemoEdit;
        private DevExpress.XtraEditors.LookUpEdit lueNganhHang;
        private DevExpress.XtraEditors.LabelControl lblLyDo;
        private System.Windows.Forms.CheckBox chkDiemThuong;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeDiemThuong;
        private DevExpress.XtraGrid.Columns.GridColumn SoDiemThuong;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeDiemThuongMacDinh;
        private System.Windows.Forms.CheckBox chkHieuLuc;
    }
}