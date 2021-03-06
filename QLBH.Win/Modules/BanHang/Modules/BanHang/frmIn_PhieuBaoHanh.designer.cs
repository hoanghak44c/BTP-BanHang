namespace QLBanHang.Modules.BanHang
{
    partial class frmIn_PhieuBaoHanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIn_PhieuBaoHanh));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.grvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaVach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repNgayXuLy = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colNoiMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThoiGianBH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTuNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTuNgay = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colDenNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDenNgay = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnTimOrderKH = new QLBH.Core.Form.GtidButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gPhieuXuat = new DevExpress.XtraGrid.GridControl();
            this.gvPhieuXuat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslInfor = new System.Windows.Forms.ToolStripLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mstNgayLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNgayXuLy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNgayXuLy.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTuNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTuNgay.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDenNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDenNgay.VistaTimeProperties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 14);
            this.label1.TabIndex = 24;
            this.label1.Text = "Số giao dịch";
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoPhieu.Location = new System.Drawing.Point(135, 20);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(288, 22);
            this.txtSoPhieu.TabIndex = 62;
            this.txtSoPhieu.Text = "Nhập số phiếu bảo hành ...";
            this.txtSoPhieu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoPhieu_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtDienThoai);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(340, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 133);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2. Thông tin khách hàng";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(58, 54);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(239, 21);
            this.txtEmail.TabIndex = 75;
            this.txtEmail.Text = "Nhập email khách hàng ...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 74;
            this.label11.Text = "Email";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(362, 55);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(206, 21);
            this.txtMaKH.TabIndex = 73;
            this.txtMaKH.Text = "Nhập mã khách hàng ...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(305, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 72;
            this.label10.Text = "Mã KH";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(362, 28);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(206, 21);
            this.txtDienThoai.TabIndex = 71;
            this.txtDienThoai.Text = "Nhập số điện thoại ...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "Điện thoại";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(58, 81);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(510, 44);
            this.txtDiaChi.TabIndex = 69;
            this.txtDiaChi.Text = "Nhập địa chỉ ...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 68;
            this.label7.Text = "Địa chỉ";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(58, 27);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(239, 21);
            this.txtHoTen.TabIndex = 67;
            this.txtHoTen.Text = "Nhập họ tên khách hàng ...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 66;
            this.label6.Tag = "";
            this.label6.Text = "Họ tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.grcDanhSach);
            this.groupBox2.Location = new System.Drawing.Point(3, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(912, 242);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "3. Thông tin sản phẩm";
            // 
            // grcDanhSach
            // 
            this.grcDanhSach.Location = new System.Drawing.Point(7, 20);
            this.grcDanhSach.MainView = this.grvDanhSach;
            this.grcDanhSach.Name = "grcDanhSach";
            this.grcDanhSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repNgayXuLy,
            this.repDenNgay,
            this.repTuNgay});
            this.grcDanhSach.Size = new System.Drawing.Size(898, 216);
            this.grcDanhSach.TabIndex = 1;
            this.grcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDanhSach});
            // 
            // grvDanhSach
            // 
            this.grvDanhSach.ColumnPanelRowHeight = 25;
            this.grvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenSanPham,
            this.colMaVach,
            this.colNgayMua,
            this.colNoiMua,
            this.colThoiGianBH,
            this.colTuNgay,
            this.colDenNgay,
            this.colGhiChu});
            this.grvDanhSach.GridControl = this.grcDanhSach;
            this.grvDanhSach.Name = "grvDanhSach";
            this.grvDanhSach.OptionsView.ColumnAutoWidth = false;
            this.grvDanhSach.OptionsView.ShowGroupPanel = false;
            // 
            // colTenSanPham
            // 
            this.colTenSanPham.Caption = "Tên sản phẩm";
            this.colTenSanPham.FieldName = "TenSanPham";
            this.colTenSanPham.Name = "colTenSanPham";
            this.colTenSanPham.OptionsColumn.ReadOnly = true;
            this.colTenSanPham.Visible = true;
            this.colTenSanPham.VisibleIndex = 0;
            this.colTenSanPham.Width = 200;
            // 
            // colMaVach
            // 
            this.colMaVach.Caption = "Mã vạch";
            this.colMaVach.FieldName = "MaVach";
            this.colMaVach.Name = "colMaVach";
            this.colMaVach.OptionsColumn.ReadOnly = true;
            this.colMaVach.Visible = true;
            this.colMaVach.VisibleIndex = 1;
            this.colMaVach.Width = 120;
            // 
            // colNgayMua
            // 
            this.colNgayMua.Caption = "Ngày mua";
            this.colNgayMua.ColumnEdit = this.repNgayXuLy;
            this.colNgayMua.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgayMua.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayMua.FieldName = "NgayMua";
            this.colNgayMua.Name = "colNgayMua";
            this.colNgayMua.OptionsColumn.ReadOnly = true;
            this.colNgayMua.Visible = true;
            this.colNgayMua.VisibleIndex = 2;
            this.colNgayMua.Width = 100;
            // 
            // repNgayXuLy
            // 
            this.repNgayXuLy.AutoHeight = false;
            this.repNgayXuLy.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repNgayXuLy.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repNgayXuLy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repNgayXuLy.EditFormat.FormatString = "dd/MM/yyyy";
            this.repNgayXuLy.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repNgayXuLy.Mask.EditMask = "dd/MM/yyyy";
            this.repNgayXuLy.Name = "repNgayXuLy";
            this.repNgayXuLy.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // colNoiMua
            // 
            this.colNoiMua.Caption = "Nơi mua";
            this.colNoiMua.FieldName = "NoiMua";
            this.colNoiMua.Name = "colNoiMua";
            this.colNoiMua.OptionsColumn.ReadOnly = true;
            this.colNoiMua.Visible = true;
            this.colNoiMua.VisibleIndex = 3;
            this.colNoiMua.Width = 150;
            // 
            // colThoiGianBH
            // 
            this.colThoiGianBH.Caption = "Thời gian BH";
            this.colThoiGianBH.FieldName = "ThoiGianBH";
            this.colThoiGianBH.Name = "colThoiGianBH";
            this.colThoiGianBH.OptionsColumn.ReadOnly = true;
            this.colThoiGianBH.Visible = true;
            this.colThoiGianBH.VisibleIndex = 4;
            this.colThoiGianBH.Width = 100;
            // 
            // colTuNgay
            // 
            this.colTuNgay.Caption = "Từ ngày";
            this.colTuNgay.ColumnEdit = this.repTuNgay;
            this.colTuNgay.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colTuNgay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTuNgay.FieldName = "TuNgay";
            this.colTuNgay.Name = "colTuNgay";
            this.colTuNgay.OptionsColumn.ReadOnly = true;
            this.colTuNgay.Visible = true;
            this.colTuNgay.VisibleIndex = 5;
            this.colTuNgay.Width = 100;
            // 
            // repTuNgay
            // 
            this.repTuNgay.AutoHeight = false;
            this.repTuNgay.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repTuNgay.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repTuNgay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repTuNgay.EditFormat.FormatString = "dd/MM/yyyy";
            this.repTuNgay.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repTuNgay.Mask.EditMask = "dd/MM/yyyy";
            this.repTuNgay.Name = "repTuNgay";
            this.repTuNgay.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // colDenNgay
            // 
            this.colDenNgay.Caption = "Đến ngày";
            this.colDenNgay.ColumnEdit = this.repDenNgay;
            this.colDenNgay.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colDenNgay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDenNgay.FieldName = "DenNgay";
            this.colDenNgay.Name = "colDenNgay";
            this.colDenNgay.OptionsColumn.ReadOnly = true;
            this.colDenNgay.Visible = true;
            this.colDenNgay.VisibleIndex = 6;
            this.colDenNgay.Width = 100;
            // 
            // repDenNgay
            // 
            this.repDenNgay.AutoHeight = false;
            this.repDenNgay.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repDenNgay.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repDenNgay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repDenNgay.EditFormat.FormatString = "dd/MM/yyyy";
            this.repDenNgay.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repDenNgay.Mask.EditMask = "dd/MM/yyyy";
            this.repDenNgay.Name = "repDenNgay";
            this.repDenNgay.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.OptionsColumn.ReadOnly = true;
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 7;
            this.colGhiChu.Width = 283;
            // 
            // btnTimOrderKH
            // 
            this.btnTimOrderKH.Image = ((System.Drawing.Image)(resources.GetObject("btnTimOrderKH.Image")));
            this.btnTimOrderKH.Location = new System.Drawing.Point(429, 19);
            this.btnTimOrderKH.Name = "btnTimOrderKH";
            this.btnTimOrderKH.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnTimOrderKH.Size = new System.Drawing.Size(28, 22);
            this.btnTimOrderKH.TabIndex = 78;
            this.btnTimOrderKH.Click += new System.EventHandler(this.btnTimOrderKH_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.gPhieuXuat);
            this.groupBox3.Location = new System.Drawing.Point(3, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 133);
            this.groupBox3.TabIndex = 124;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "1. Danh sách phiếu xuất";
            // 
            // gPhieuXuat
            // 
            this.gPhieuXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gPhieuXuat.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gPhieuXuat.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gPhieuXuat.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gPhieuXuat.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gPhieuXuat.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gPhieuXuat.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gPhieuXuat.Location = new System.Drawing.Point(6, 15);
            this.gPhieuXuat.MainView = this.gvPhieuXuat;
            this.gPhieuXuat.Name = "gPhieuXuat";
            this.gPhieuXuat.Size = new System.Drawing.Size(319, 112);
            this.gPhieuXuat.TabIndex = 94;
            this.gPhieuXuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhieuXuat,
            this.gridView2});
            // 
            // gvPhieuXuat
            // 
            this.gvPhieuXuat.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvPhieuXuat.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvPhieuXuat.Appearance.FocusedCell.Options.UseFont = true;
            this.gvPhieuXuat.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvPhieuXuat.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvPhieuXuat.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvPhieuXuat.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvPhieuXuat.Appearance.Row.BackColor = System.Drawing.Color.Silver;
            this.gvPhieuXuat.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvPhieuXuat.Appearance.Row.Options.UseBackColor = true;
            this.gvPhieuXuat.Appearance.Row.Options.UseBorderColor = true;
            this.gvPhieuXuat.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvPhieuXuat.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvPhieuXuat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdChungTu,
            this.SoChungTu,
            this.NgayLap,
            this.NguoiLap});
            this.gvPhieuXuat.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvPhieuXuat.GridControl = this.gPhieuXuat;
            this.gvPhieuXuat.Name = "gvPhieuXuat";
            this.gvPhieuXuat.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvPhieuXuat.OptionsSelection.MultiSelect = true;
            this.gvPhieuXuat.OptionsView.ShowDetailButtons = false;
            this.gvPhieuXuat.OptionsView.ShowGroupPanel = false;
            this.gvPhieuXuat.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvPhieuXuat_FocusedRowChanged);
            // 
            // IdChungTu
            // 
            this.IdChungTu.Caption = "IdChungTu";
            this.IdChungTu.FieldName = "IdChungTu";
            this.IdChungTu.Name = "IdChungTu";
            // 
            // SoChungTu
            // 
            this.SoChungTu.Caption = "Số phiếu xuất";
            this.SoChungTu.FieldName = "SoChungTu";
            this.SoChungTu.Name = "SoChungTu";
            this.SoChungTu.OptionsColumn.ReadOnly = true;
            this.SoChungTu.Visible = true;
            this.SoChungTu.VisibleIndex = 0;
            // 
            // NgayLap
            // 
            this.NgayLap.Caption = "Ngày xuất";
            this.NgayLap.FieldName = "NgayLap";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.OptionsColumn.ReadOnly = true;
            this.NgayLap.Visible = true;
            this.NgayLap.VisibleIndex = 1;
            // 
            // NguoiLap
            // 
            this.NguoiLap.Caption = "Người lập";
            this.NguoiLap.FieldName = "NguoiLap";
            this.NguoiLap.Name = "NguoiLap";
            this.NguoiLap.OptionsColumn.ReadOnly = true;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gPhieuXuat;
            this.gridView2.Name = "gridView2";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPrint,
            this.toolStripSeparator4,
            this.tsbClose,
            this.toolStripSeparator1,
            this.tslInfor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(921, 25);
            this.toolStrip1.TabIndex = 125;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbPrint
            // 
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(133, 22);
            this.tsbPrint.Text = "&In thẻ bảo hành (F9)";
            this.tsbPrint.Click += new System.EventHandler(this.cmdIn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbClose
            // 
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(85, 22);
            this.tsbClose.Text = "Đ&óng (F12)";
            this.tsbClose.ToolTipText = "Đóng (F12)";
            this.tsbClose.Click += new System.EventHandler(this.cmdThoat_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tslInfor
            // 
            this.tslInfor.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslInfor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslInfor.Name = "tslInfor";
            this.tslInfor.Size = new System.Drawing.Size(93, 22);
            this.tslInfor.Text = "In thẻ bảo hành";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.mstNgayLapPhieu);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.btnTimOrderKH);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtSoPhieu);
            this.groupBox4.Location = new System.Drawing.Point(3, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(912, 54);
            this.groupBox4.TabIndex = 126;
            this.groupBox4.TabStop = false;
            // 
            // mstNgayLapPhieu
            // 
            this.mstNgayLapPhieu.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.mstNgayLapPhieu.Enabled = false;
            this.mstNgayLapPhieu.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.mstNgayLapPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mstNgayLapPhieu.Location = new System.Drawing.Point(565, 20);
            this.mstNgayLapPhieu.Name = "mstNgayLapPhieu";
            this.mstNgayLapPhieu.Size = new System.Drawing.Size(118, 21);
            this.mstNgayLapPhieu.TabIndex = 80;
            this.mstNgayLapPhieu.Value = new System.DateTime(2012, 8, 19, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 79;
            this.label2.Text = "Ngày mua";
            // 
            // frmIn_PhieuBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 474);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmIn_PhieuBaoHanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmIn_PhieuBaoHanh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNgayXuLy.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNgayXuLy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTuNgay.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTuNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDenNgay.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDenNgay)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl grcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDanhSach;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repNgayXuLy;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colMaVach;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayMua;
        private DevExpress.XtraGrid.Columns.GridColumn colNoiMua;
        private DevExpress.XtraGrid.Columns.GridColumn colThoiGianBH;
        private DevExpress.XtraGrid.Columns.GridColumn colTuNgay;
        private DevExpress.XtraGrid.Columns.GridColumn colDenNgay;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repTuNgay;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repDenNgay;
        private QLBH.Core.Form.GtidButton btnTimOrderKH;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.GridControl gPhieuXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhieuXuat;
        private DevExpress.XtraGrid.Columns.GridColumn IdChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn SoChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn NgayLap;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiLap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslInfor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker mstNgayLapPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
    }
}