using QLBH.Core.Form;
namespace QLBanHang.Modules.BanHang
{
    partial class frmCS_CheckKhuyenMai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCS_CheckKhuyenMai));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDonGia = new System.Windows.Forms.Label();
            this.txtSanPham = new System.Windows.Forms.Label();
            this.bteSanPham = new DevExpress.XtraEditors.ButtonEdit();
            this.mstThoiGian = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblThuocXuat = new System.Windows.Forms.Label();
            this.bteTrungTam = new DevExpress.XtraEditors.ButtonEdit();
            this.btnTim = new QLBH.Core.Form.GtidButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDong = new QLBH.Core.Form.GtidButton();
            this.btnDongBo = new QLBH.Core.Form.GtidButton();
            this.cmdExport = new QLBH.Core.Form.GtidButton();
            this.grpKetQuaTimKiem = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoTienKM = new QLBH.Core.Form.GtidTextBox();
            this.gChinhSach = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ChinhSachApDung = new System.Windows.Forms.ToolStripMenuItem();
            this.gvChinhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdChinhSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoChinhSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DoUuTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MacDinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLoaiCS = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.DaDuyetTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayHieuLuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HanHieuLucTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDraft = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.NguoiTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiDoiTuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDoiTuongAD = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).BeginInit();
            this.grpKetQuaTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gChinhSach)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvChinhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDoiTuongAD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtSanPham);
            this.groupBox1.Controls.Add(this.bteSanPham);
            this.groupBox1.Controls.Add(this.mstThoiGian);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblThuocXuat);
            this.groupBox1.Controls.Add(this.bteTrungTam);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(10, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1037, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtDonGia
            // 
            this.txtDonGia.AutoSize = true;
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(683, 42);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(72, 15);
            this.txtDonGia.TabIndex = 156;
            this.txtDonGia.Text = "Giá có VAT: ";
            this.txtDonGia.Visible = false;
            // 
            // txtSanPham
            // 
            this.txtSanPham.AutoSize = true;
            this.txtSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSanPham.Location = new System.Drawing.Point(683, 18);
            this.txtSanPham.Name = "txtSanPham";
            this.txtSanPham.Size = new System.Drawing.Size(64, 15);
            this.txtSanPham.TabIndex = 155;
            this.txtSanPham.Text = "Sản phẩm";
            this.txtSanPham.Visible = false;
            // 
            // bteSanPham
            // 
            this.bteSanPham.Location = new System.Drawing.Point(96, 41);
            this.bteSanPham.Name = "bteSanPham";
            this.bteSanPham.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.bteSanPham.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteSanPham.Properties.Appearance.Options.UseBackColor = true;
            this.bteSanPham.Properties.Appearance.Options.UseFont = true;
            this.bteSanPham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteSanPham.Size = new System.Drawing.Size(318, 21);
            this.bteSanPham.TabIndex = 154;
            this.bteSanPham.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteSanPham_ButtonClick);
            this.bteSanPham.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteSanPham_KeyDown);
            this.bteSanPham.TextChanged += new System.EventHandler(this.bteSanPham_TextChanged);
            // 
            // mstThoiGian
            // 
            this.mstThoiGian.CustomFormat = "dd/MM/yyyy HH:mm";
            this.mstThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mstThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mstThoiGian.Location = new System.Drawing.Point(500, 13);
            this.mstThoiGian.Name = "mstThoiGian";
            this.mstThoiGian.Size = new System.Drawing.Size(129, 20);
            this.mstThoiGian.TabIndex = 128;
            this.mstThoiGian.Value = new System.DateTime(2012, 8, 19, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label1.Location = new System.Drawing.Point(441, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 129;
            this.label1.Text = "Thời gian";
            // 
            // lblThuocXuat
            // 
            this.lblThuocXuat.AutoSize = true;
            this.lblThuocXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuocXuat.Location = new System.Drawing.Point(32, 45);
            this.lblThuocXuat.Name = "lblThuocXuat";
            this.lblThuocXuat.Size = new System.Drawing.Size(55, 13);
            this.lblThuocXuat.TabIndex = 122;
            this.lblThuocXuat.Text = "Sản phẩm";
            // 
            // bteTrungTam
            // 
            this.bteTrungTam.Location = new System.Drawing.Point(96, 14);
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
            this.btnTim.Location = new System.Drawing.Point(500, 39);
            this.btnTim.Name = "btnTim";
            this.btnTim.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnTim.Size = new System.Drawing.Size(129, 25);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "&Kiểm tra (F3)";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 118;
            this.label7.Text = "Trung tâm";
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(913, 398);
            this.btnDong.Name = "btnDong";
            this.btnDong.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnDong.Size = new System.Drawing.Size(117, 25);
            this.btnDong.TabIndex = 120;
            this.btnDong.Text = "Thoát (ESC)";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnDongBo
            // 
            this.btnDongBo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDongBo.Image = ((System.Drawing.Image)(resources.GetObject("btnDongBo.Image")));
            this.btnDongBo.Location = new System.Drawing.Point(129, 398);
            this.btnDongBo.Name = "btnDongBo";
            this.btnDongBo.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnDongBo.Size = new System.Drawing.Size(185, 25);
            this.btnDongBo.TabIndex = 126;
            this.btnDongBo.Text = "Xem chi tiết khuyến mại (F6)";
            this.btnDongBo.Click += new System.EventHandler(this.btnDongBo_Click);
            // 
            // cmdExport
            // 
            this.cmdExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdExport.Image = ((System.Drawing.Image)(resources.GetObject("cmdExport.Image")));
            this.cmdExport.Location = new System.Drawing.Point(6, 398);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdExport.Size = new System.Drawing.Size(117, 25);
            this.cmdExport.TabIndex = 21;
            this.cmdExport.Text = "Export (F12)";
            this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // grpKetQuaTimKiem
            // 
            this.grpKetQuaTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKetQuaTimKiem.Controls.Add(this.label2);
            this.grpKetQuaTimKiem.Controls.Add(this.txtSoTienKM);
            this.grpKetQuaTimKiem.Controls.Add(this.gChinhSach);
            this.grpKetQuaTimKiem.Controls.Add(this.btnDongBo);
            this.grpKetQuaTimKiem.Controls.Add(this.cmdExport);
            this.grpKetQuaTimKiem.Controls.Add(this.btnDong);
            this.grpKetQuaTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKetQuaTimKiem.ForeColor = System.Drawing.Color.Black;
            this.grpKetQuaTimKiem.Location = new System.Drawing.Point(10, 88);
            this.grpKetQuaTimKiem.Name = "grpKetQuaTimKiem";
            this.grpKetQuaTimKiem.Size = new System.Drawing.Size(1037, 432);
            this.grpKetQuaTimKiem.TabIndex = 3;
            this.grpKetQuaTimKiem.TabStop = false;
            this.grpKetQuaTimKiem.Text = "Danh sách chính sách khuyến mại áp dụng";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(510, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 13);
            this.label2.TabIndex = 158;
            this.label2.Text = "Tổng số tiền khuyến mại đẩy sang Oracle";
            // 
            // txtSoTienKM
            // 
            this.txtSoTienKM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoTienKM.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtSoTienKM.Location = new System.Drawing.Point(757, 400);
            this.txtSoTienKM.Name = "txtSoTienKM";
            this.txtSoTienKM.ReadOnly = true;
            this.txtSoTienKM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSoTienKM.Size = new System.Drawing.Size(146, 21);
            this.txtSoTienKM.TabIndex = 157;
            // 
            // gChinhSach
            // 
            this.gChinhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gChinhSach.ContextMenuStrip = this.contextMenuStrip1;
            this.gChinhSach.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gChinhSach.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gChinhSach.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gChinhSach.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gChinhSach.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gChinhSach.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gChinhSach.Location = new System.Drawing.Point(6, 19);
            this.gChinhSach.MainView = this.gvChinhSach;
            this.gChinhSach.Name = "gChinhSach";
            this.gChinhSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCheck,
            this.repDoiTuongAD,
            this.repLoaiCS});
            this.gChinhSach.Size = new System.Drawing.Size(1024, 373);
            this.gChinhSach.TabIndex = 156;
            this.gChinhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChinhSach});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChinhSachApDung});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(220, 26);
            // 
            // ChinhSachApDung
            // 
            this.ChinhSachApDung.Name = "ChinhSachApDung";
            this.ChinhSachApDung.Size = new System.Drawing.Size(219, 22);
            this.ChinhSachApDung.Text = "Chi tiết chính sách áp dụng";
            this.ChinhSachApDung.Click += new System.EventHandler(this.ChinhSachApDung_Click);
            // 
            // gvChinhSach
            // 
            this.gvChinhSach.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvChinhSach.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvChinhSach.Appearance.FocusedCell.Options.UseFont = true;
            this.gvChinhSach.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvChinhSach.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvChinhSach.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvChinhSach.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvChinhSach.Appearance.Row.BackColor = System.Drawing.Color.Silver;
            this.gvChinhSach.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvChinhSach.Appearance.Row.Options.UseBackColor = true;
            this.gvChinhSach.Appearance.Row.Options.UseBorderColor = true;
            this.gvChinhSach.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvChinhSach.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvChinhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdChinhSach,
            this.SoChinhSach,
            this.NgayLap,
            this.NguoiLap,
            this.DoUuTien,
            this.MacDinh,
            this.DaDuyetTT,
            this.NgayHieuLuc,
            this.HanHieuLucTT,
            this.colDraft,
            this.NguoiTao,
            this.LoaiDoiTuong});
            this.gvChinhSach.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvChinhSach.GridControl = this.gChinhSach;
            this.gvChinhSach.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "SoChinhSach", null, "   (Tổng số = {0})")});
            this.gvChinhSach.Name = "gvChinhSach";
            this.gvChinhSach.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvChinhSach.OptionsView.ShowAutoFilterRow = true;
            this.gvChinhSach.OptionsView.ShowDetailButtons = false;
            // 
            // IdChinhSach
            // 
            this.IdChinhSach.Caption = "IdChinhSach";
            this.IdChinhSach.FieldName = "IdChinhSach";
            this.IdChinhSach.Name = "IdChinhSach";
            this.IdChinhSach.OptionsColumn.AllowEdit = false;
            this.IdChinhSach.OptionsColumn.AllowFocus = false;
            this.IdChinhSach.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.IdChinhSach.OptionsColumn.AllowMove = false;
            this.IdChinhSach.OptionsColumn.ReadOnly = true;
            this.IdChinhSach.Width = 115;
            // 
            // SoChinhSach
            // 
            this.SoChinhSach.Caption = "Số chính sách";
            this.SoChinhSach.FieldName = "SoChinhSach";
            this.SoChinhSach.Name = "SoChinhSach";
            this.SoChinhSach.OptionsColumn.AllowFocus = false;
            this.SoChinhSach.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.SoChinhSach.OptionsColumn.AllowMove = false;
            this.SoChinhSach.OptionsColumn.ReadOnly = true;
            this.SoChinhSach.Visible = true;
            this.SoChinhSach.VisibleIndex = 0;
            this.SoChinhSach.Width = 179;
            // 
            // NgayLap
            // 
            this.NgayLap.Caption = "Ngày lập";
            this.NgayLap.FieldName = "NgayLap";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.OptionsColumn.AllowEdit = false;
            this.NgayLap.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.NgayLap.Visible = true;
            this.NgayLap.VisibleIndex = 1;
            this.NgayLap.Width = 94;
            // 
            // NguoiLap
            // 
            this.NguoiLap.Caption = "Người lập";
            this.NguoiLap.FieldName = "NguoiLap";
            this.NguoiLap.Name = "NguoiLap";
            this.NguoiLap.OptionsColumn.AllowEdit = false;
            this.NguoiLap.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.NguoiLap.Visible = true;
            this.NguoiLap.VisibleIndex = 2;
            this.NguoiLap.Width = 110;
            // 
            // DoUuTien
            // 
            this.DoUuTien.Caption = "Độ ưu tiên";
            this.DoUuTien.FieldName = "DoUuTien";
            this.DoUuTien.Name = "DoUuTien";
            this.DoUuTien.OptionsColumn.AllowEdit = false;
            this.DoUuTien.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.DoUuTien.Visible = true;
            this.DoUuTien.VisibleIndex = 3;
            this.DoUuTien.Width = 74;
            // 
            // MacDinh
            // 
            this.MacDinh.Caption = "Loại chính sách";
            this.MacDinh.ColumnEdit = this.repLoaiCS;
            this.MacDinh.FieldName = "MacDinh";
            this.MacDinh.Name = "MacDinh";
            this.MacDinh.OptionsColumn.AllowEdit = false;
            this.MacDinh.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.MacDinh.OptionsColumn.ReadOnly = true;
            this.MacDinh.Visible = true;
            this.MacDinh.VisibleIndex = 4;
            this.MacDinh.Width = 110;
            // 
            // repLoaiCS
            // 
            this.repLoaiCS.AutoHeight = false;
            this.repLoaiCS.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLoaiCS.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.repLoaiCS.DisplayMember = "Name";
            this.repLoaiCS.Name = "repLoaiCS";
            this.repLoaiCS.ValueMember = "Id";
            // 
            // DaDuyetTT
            // 
            this.DaDuyetTT.Caption = "Trạng thái";
            this.DaDuyetTT.FieldName = "DaDuyetTT";
            this.DaDuyetTT.Name = "DaDuyetTT";
            this.DaDuyetTT.OptionsColumn.AllowEdit = false;
            this.DaDuyetTT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.DaDuyetTT.Visible = true;
            this.DaDuyetTT.VisibleIndex = 5;
            this.DaDuyetTT.Width = 125;
            // 
            // NgayHieuLuc
            // 
            this.NgayHieuLuc.Caption = "Hiệu lực từ ngày";
            this.NgayHieuLuc.FieldName = "NgayHieuLuc";
            this.NgayHieuLuc.Name = "NgayHieuLuc";
            this.NgayHieuLuc.OptionsColumn.AllowEdit = false;
            this.NgayHieuLuc.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.NgayHieuLuc.Visible = true;
            this.NgayHieuLuc.VisibleIndex = 6;
            this.NgayHieuLuc.Width = 116;
            // 
            // HanHieuLucTT
            // 
            this.HanHieuLucTT.Caption = "Hiệu lực đến";
            this.HanHieuLucTT.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss PM";
            this.HanHieuLucTT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.HanHieuLucTT.FieldName = "HanHieuLucTT";
            this.HanHieuLucTT.Name = "HanHieuLucTT";
            this.HanHieuLucTT.OptionsColumn.AllowEdit = false;
            this.HanHieuLucTT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.HanHieuLucTT.Visible = true;
            this.HanHieuLucTT.VisibleIndex = 7;
            this.HanHieuLucTT.Width = 95;
            // 
            // colDraft
            // 
            this.colDraft.Caption = "Bản nháp";
            this.colDraft.ColumnEdit = this.repCheck;
            this.colDraft.FieldName = "Draft";
            this.colDraft.Name = "colDraft";
            this.colDraft.OptionsColumn.AllowEdit = false;
            this.colDraft.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colDraft.Visible = true;
            this.colDraft.VisibleIndex = 8;
            this.colDraft.Width = 63;
            // 
            // repCheck
            // 
            this.repCheck.AutoHeight = false;
            this.repCheck.Name = "repCheck";
            this.repCheck.ValueChecked = 1;
            this.repCheck.ValueUnchecked = 0;
            // 
            // NguoiTao
            // 
            this.NguoiTao.Caption = "Người tạo";
            this.NguoiTao.FieldName = "NguoiTao";
            this.NguoiTao.Name = "NguoiTao";
            this.NguoiTao.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.NguoiTao.Visible = true;
            this.NguoiTao.VisibleIndex = 9;
            this.NguoiTao.Width = 74;
            // 
            // LoaiDoiTuong
            // 
            this.LoaiDoiTuong.Caption = "Đối tượng áp dụng";
            this.LoaiDoiTuong.ColumnEdit = this.repDoiTuongAD;
            this.LoaiDoiTuong.FieldName = "LoaiDoiTuong";
            this.LoaiDoiTuong.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.LoaiDoiTuong.Name = "LoaiDoiTuong";
            this.LoaiDoiTuong.OptionsColumn.AllowEdit = false;
            this.LoaiDoiTuong.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.LoaiDoiTuong.Visible = true;
            this.LoaiDoiTuong.VisibleIndex = 10;
            this.LoaiDoiTuong.Width = 134;
            // 
            // repDoiTuongAD
            // 
            this.repDoiTuongAD.AutoHeight = false;
            this.repDoiTuongAD.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repDoiTuongAD.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.repDoiTuongAD.DisplayMember = "Name";
            this.repDoiTuongAD.Name = "repDoiTuongAD";
            this.repDoiTuongAD.ValueMember = "Id";
            // 
            // frmCS_CheckKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 532);
            this.Controls.Add(this.grpKetQuaTimKiem);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCS_CheckKhuyenMai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiểm tra chính sách khuyến mại";
            this.Load += new System.EventHandler(this.frmBH_TimChungTu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBH_TimChungTu_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).EndInit();
            this.grpKetQuaTimKiem.ResumeLayout(false);
            this.grpKetQuaTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gChinhSach)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvChinhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDoiTuongAD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpKetQuaTimKiem;
        private GtidButton btnTim;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.ButtonEdit bteTrungTam;
        private GtidButton btnDong;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ChinhSachApDung;
        private GtidButton cmdExport;
        private System.Windows.Forms.Label lblThuocXuat;
        private GtidButton btnDongBo;
        private System.Windows.Forms.DateTimePicker mstThoiGian;
        private System.Windows.Forms.Label label1;
        protected DevExpress.XtraEditors.ButtonEdit bteSanPham;
        private DevExpress.XtraGrid.GridControl gChinhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChinhSach;
        private DevExpress.XtraGrid.Columns.GridColumn IdChinhSach;
        private DevExpress.XtraGrid.Columns.GridColumn SoChinhSach;
        private DevExpress.XtraGrid.Columns.GridColumn NgayLap;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiLap;
        private DevExpress.XtraGrid.Columns.GridColumn DoUuTien;
        private DevExpress.XtraGrid.Columns.GridColumn MacDinh;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLoaiCS;
        private DevExpress.XtraGrid.Columns.GridColumn DaDuyetTT;
        private DevExpress.XtraGrid.Columns.GridColumn NgayHieuLuc;
        private DevExpress.XtraGrid.Columns.GridColumn HanHieuLucTT;
        private DevExpress.XtraGrid.Columns.GridColumn colDraft;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheck;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiTao;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiDoiTuong;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repDoiTuongAD;
        private System.Windows.Forms.Label label2;
        private GtidTextBox txtSoTienKM;
        private System.Windows.Forms.Label txtDonGia;
        private System.Windows.Forms.Label txtSanPham;
    }
}