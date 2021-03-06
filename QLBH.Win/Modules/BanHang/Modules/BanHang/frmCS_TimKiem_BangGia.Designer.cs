using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frmCS_TimKiem_BangGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCS_TimKiem_BangGia));
            this.repCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.cmdTimKiem = new QLBH.Core.Form.GtidButton();
            this.cmdSua = new QLBH.Core.Form.GtidButton();
            this.cmdThoat = new QLBH.Core.Form.GtidButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdExport = new QLBH.Core.Form.GtidButton();
            this.chkCuaToi = new System.Windows.Forms.CheckBox();
            this.bteTrungTam = new DevExpress.XtraEditors.ButtonEdit();
            this.txtMatHang = new QLBH.Core.Form.GtidTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkDaDuyet = new System.Windows.Forms.CheckBox();
            this.txtGhiChu = new QLBH.Core.Form.GtidTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboDuyet = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNguoiLap = new QLBH.Core.Form.GtidTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.mstHanHieuLuc = new System.Windows.Forms.DateTimePicker();
            this.mstNgayHieuLuc = new System.Windows.Forms.DateTimePicker();
            this.txtSoBangGia = new QLBH.Core.Form.GtidTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpKetQuaTimKiem = new System.Windows.Forms.GroupBox();
            this.btnNext = new QLBH.Core.Form.GtidButton();
            this.cboPage = new System.Windows.Forms.ComboBox();
            this.gListBangGia = new DevExpress.XtraGrid.GridControl();
            this.gvListBangGia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdBangGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoBangGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Draft = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DaDuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayDuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiTao = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.repCheck)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).BeginInit();
            this.grpKetQuaTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gListBangGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListBangGia)).BeginInit();
            this.SuspendLayout();
            // 
            // repCheck
            // 
            this.repCheck.AutoHeight = false;
            this.repCheck.DisplayValueChecked = "Đã duyệt";
            this.repCheck.DisplayValueUnchecked = "Chưa duyệt";
            this.repCheck.Name = "repCheck";
            this.repCheck.ValueChecked = 1;
            this.repCheck.ValueUnchecked = 0;
            // 
            // cmdTimKiem
            // 
            this.cmdTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("cmdTimKiem.Image")));
            this.cmdTimKiem.Location = new System.Drawing.Point(828, 37);
            this.cmdTimKiem.Name = "cmdTimKiem";
            this.cmdTimKiem.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdTimKiem.Size = new System.Drawing.Size(97, 30);
            this.cmdTimKiem.TabIndex = 10;
            this.cmdTimKiem.Text = "Tìm kiếm (F10)";
            this.cmdTimKiem.Click += new System.EventHandler(this.cmdTimKiem_Click);
            // 
            // cmdSua
            // 
            this.cmdSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdSua.Image = ((System.Drawing.Image)(resources.GetObject("cmdSua.Image")));
            this.cmdSua.Location = new System.Drawing.Point(12, 446);
            this.cmdSua.Name = "cmdSua";
            this.cmdSua.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdSua.Size = new System.Drawing.Size(97, 24);
            this.cmdSua.TabIndex = 2;
            this.cmdSua.Text = "&Chi tiết (F6)";
            this.cmdSua.Click += new System.EventHandler(this.cmdSua_Click);
            // 
            // cmdThoat
            // 
            this.cmdThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdThoat.Image = ((System.Drawing.Image)(resources.GetObject("cmdThoat.Image")));
            this.cmdThoat.Location = new System.Drawing.Point(842, 446);
            this.cmdThoat.Name = "cmdThoat";
            this.cmdThoat.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdThoat.Size = new System.Drawing.Size(97, 24);
            this.cmdThoat.TabIndex = 3;
            this.cmdThoat.Text = "&Thoát (F12)";
            this.cmdThoat.Click += new System.EventHandler(this.cmdThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Siêu thị";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmdExport);
            this.groupBox1.Controls.Add(this.chkCuaToi);
            this.groupBox1.Controls.Add(this.bteTrungTam);
            this.groupBox1.Controls.Add(this.txtMatHang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmdTimKiem);
            this.groupBox1.Controls.Add(this.chkDaDuyet);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboDuyet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNguoiLap);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboTrangThai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mstHanHieuLuc);
            this.groupBox1.Controls.Add(this.mstNgayHieuLuc);
            this.groupBox1.Controls.Add(this.txtSoBangGia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(940, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmdExport
            // 
            this.cmdExport.Image = ((System.Drawing.Image)(resources.GetObject("cmdExport.Image")));
            this.cmdExport.Location = new System.Drawing.Point(828, 72);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdExport.Size = new System.Drawing.Size(97, 30);
            this.cmdExport.TabIndex = 11;
            this.cmdExport.Text = "Export (F12)";
            this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // chkCuaToi
            // 
            this.chkCuaToi.AutoSize = true;
            this.chkCuaToi.Checked = true;
            this.chkCuaToi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCuaToi.Location = new System.Drawing.Point(828, 18);
            this.chkCuaToi.Name = "chkCuaToi";
            this.chkCuaToi.Size = new System.Drawing.Size(60, 17);
            this.chkCuaToi.TabIndex = 9;
            this.chkCuaToi.Text = "Của tôi";
            this.chkCuaToi.UseVisualStyleBackColor = true;
            // 
            // bteTrungTam
            // 
            this.bteTrungTam.Location = new System.Drawing.Point(89, 62);
            this.bteTrungTam.Name = "bteTrungTam";
            this.bteTrungTam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteTrungTam.Properties.Appearance.Options.UseFont = true;
            this.bteTrungTam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteTrungTam.Size = new System.Drawing.Size(285, 22);
            this.bteTrungTam.TabIndex = 2;
            this.bteTrungTam.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteTrungTam_ButtonClick);
            this.bteTrungTam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteTrungTam_KeyDown);
            this.bteTrungTam.TextChanged += new System.EventHandler(this.bteTrungTam_TextChanged);
            // 
            // txtMatHang
            // 
            this.txtMatHang.Location = new System.Drawing.Point(576, 88);
            this.txtMatHang.Name = "txtMatHang";
            this.txtMatHang.Size = new System.Drawing.Size(229, 21);
            this.txtMatHang.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 106;
            this.label2.Text = "Mặt hàng (Mã/tên)";
            // 
            // chkDaDuyet
            // 
            this.chkDaDuyet.AutoSize = true;
            this.chkDaDuyet.Location = new System.Drawing.Point(480, 66);
            this.chkDaDuyet.Name = "chkDaDuyet";
            this.chkDaDuyet.Size = new System.Drawing.Size(83, 17);
            this.chkDaDuyet.TabIndex = 104;
            this.chkDaDuyet.Text = "Tìm từ ngày";
            this.chkDaDuyet.UseVisualStyleBackColor = true;
            this.chkDaDuyet.CheckedChanged += new System.EventHandler(this.chkDaDuyet_CheckedChanged);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(89, 88);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(285, 21);
            this.txtGhiChu.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 103;
            this.label8.Text = "Ghi chú";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 101;
            this.label7.Text = "Trình trạng duyệt";
            // 
            // cboDuyet
            // 
            this.cboDuyet.FormattingEnabled = true;
            this.cboDuyet.Items.AddRange(new object[] {
            "Tất cả",
            "Chưa duyệt",
            "Đã duyệt"});
            this.cboDuyet.Location = new System.Drawing.Point(576, 37);
            this.cboDuyet.Name = "cboDuyet";
            this.cboDuyet.Size = new System.Drawing.Size(229, 21);
            this.cboDuyet.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(678, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 99;
            this.label4.Text = "đến ";
            // 
            // txtNguoiLap
            // 
            this.txtNguoiLap.Location = new System.Drawing.Point(89, 37);
            this.txtNguoiLap.Name = "txtNguoiLap";
            this.txtNguoiLap.Size = new System.Drawing.Size(285, 21);
            this.txtNguoiLap.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 98;
            this.label5.Text = "Người lập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 96;
            this.label6.Text = "Trạng thái";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Tất cả",
            "Đã xác nhận",
            "Chưa xác nhận"});
            this.cboTrangThai.Location = new System.Drawing.Point(576, 13);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(229, 21);
            this.cboTrangThai.TabIndex = 4;
            // 
            // mstHanHieuLuc
            // 
            this.mstHanHieuLuc.CustomFormat = "dd/MM/yyyy";
            this.mstHanHieuLuc.Enabled = false;
            this.mstHanHieuLuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mstHanHieuLuc.Location = new System.Drawing.Point(711, 63);
            this.mstHanHieuLuc.Name = "mstHanHieuLuc";
            this.mstHanHieuLuc.Size = new System.Drawing.Size(94, 21);
            this.mstHanHieuLuc.TabIndex = 7;
            // 
            // mstNgayHieuLuc
            // 
            this.mstNgayHieuLuc.CustomFormat = "dd/MM/yyyy";
            this.mstNgayHieuLuc.Enabled = false;
            this.mstNgayHieuLuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mstNgayHieuLuc.Location = new System.Drawing.Point(576, 63);
            this.mstNgayHieuLuc.Name = "mstNgayHieuLuc";
            this.mstNgayHieuLuc.Size = new System.Drawing.Size(94, 21);
            this.mstNgayHieuLuc.TabIndex = 6;
            // 
            // txtSoBangGia
            // 
            this.txtSoBangGia.Location = new System.Drawing.Point(89, 13);
            this.txtSoBangGia.Name = "txtSoBangGia";
            this.txtSoBangGia.Size = new System.Drawing.Size(285, 21);
            this.txtSoBangGia.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 88;
            this.label1.Text = "Số bảng giá";
            // 
            // grpKetQuaTimKiem
            // 
            this.grpKetQuaTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKetQuaTimKiem.Controls.Add(this.btnNext);
            this.grpKetQuaTimKiem.Controls.Add(this.cboPage);
            this.grpKetQuaTimKiem.Controls.Add(this.gListBangGia);
            this.grpKetQuaTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKetQuaTimKiem.ForeColor = System.Drawing.Color.Black;
            this.grpKetQuaTimKiem.Location = new System.Drawing.Point(5, 128);
            this.grpKetQuaTimKiem.Name = "grpKetQuaTimKiem";
            this.grpKetQuaTimKiem.Size = new System.Drawing.Size(940, 315);
            this.grpKetQuaTimKiem.TabIndex = 1;
            this.grpKetQuaTimKiem.TabStop = false;
            this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(783, 27);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnNext.Size = new System.Drawing.Size(121, 22);
            this.btnNext.TabIndex = 152;
            this.btnNext.Text = "Kết quả tiếp theo";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cboPage
            // 
            this.cboPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPage.AutoCompleteCustomSource.AddRange(new string[] {
            "Nhận hàng tại siêu thị",
            "Giao hàng tại nhà"});
            this.cboPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPage.FormattingEnabled = true;
            this.cboPage.Items.AddRange(new object[] {
            "50",
            "100",
            "200",
            "500",
            "1000",
            "Tất cả"});
            this.cboPage.Location = new System.Drawing.Point(731, 27);
            this.cboPage.Name = "cboPage";
            this.cboPage.Size = new System.Drawing.Size(50, 21);
            this.cboPage.TabIndex = 151;
            // 
            // gListBangGia
            // 
            this.gListBangGia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gListBangGia.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gListBangGia.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gListBangGia.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gListBangGia.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gListBangGia.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gListBangGia.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gListBangGia.Location = new System.Drawing.Point(6, 18);
            this.gListBangGia.MainView = this.gvListBangGia;
            this.gListBangGia.Name = "gListBangGia";
            this.gListBangGia.Size = new System.Drawing.Size(928, 290);
            this.gListBangGia.TabIndex = 29;
            this.gListBangGia.UseEmbeddedNavigator = true;
            this.gListBangGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListBangGia});
            this.gListBangGia.DoubleClick += new System.EventHandler(this.gListBangGia_DoubleClick);
            this.gListBangGia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gListBangGia_KeyDown);
            // 
            // gvListBangGia
            // 
            this.gvListBangGia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaTrungTam,
            this.TenTrungTam,
            this.IdBangGia,
            this.SoBangGia,
            this.NgayLap,
            this.NguoiLap,
            this.Draft,
            this.DaDuyet,
            this.NgayDuyet,
            this.NguoiTao});
            this.gvListBangGia.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvListBangGia.GridControl = this.gListBangGia;
            this.gvListBangGia.Name = "gvListBangGia";
            this.gvListBangGia.OptionsView.ShowAutoFilterRow = true;
            this.gvListBangGia.OptionsView.ShowDetailButtons = false;
            // 
            // MaTrungTam
            // 
            this.MaTrungTam.Caption = "Mã trung tâm";
            this.MaTrungTam.FieldName = "ListMaTrungTam";
            this.MaTrungTam.Name = "MaTrungTam";
            this.MaTrungTam.OptionsColumn.AllowEdit = false;
            this.MaTrungTam.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.MaTrungTam.Visible = true;
            this.MaTrungTam.VisibleIndex = 0;
            this.MaTrungTam.Width = 200;
            // 
            // TenTrungTam
            // 
            this.TenTrungTam.Caption = "Tên trung tâm";
            this.TenTrungTam.FieldName = "TenTrungTam";
            this.TenTrungTam.Name = "TenTrungTam";
            this.TenTrungTam.OptionsColumn.AllowEdit = false;
            this.TenTrungTam.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TenTrungTam.Width = 171;
            // 
            // IdBangGia
            // 
            this.IdBangGia.Caption = "Id bảng giá";
            this.IdBangGia.FieldName = "IdBangGia";
            this.IdBangGia.Name = "IdBangGia";
            this.IdBangGia.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            // 
            // SoBangGia
            // 
            this.SoBangGia.Caption = "Số bảng giá";
            this.SoBangGia.FieldName = "SoBangGia";
            this.SoBangGia.Name = "SoBangGia";
            this.SoBangGia.OptionsColumn.AllowEdit = false;
            this.SoBangGia.OptionsColumn.AllowFocus = false;
            this.SoBangGia.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.SoBangGia.OptionsColumn.AllowMove = false;
            this.SoBangGia.OptionsColumn.ReadOnly = true;
            this.SoBangGia.Visible = true;
            this.SoBangGia.VisibleIndex = 1;
            this.SoBangGia.Width = 216;
            // 
            // NgayLap
            // 
            this.NgayLap.Caption = "Ngày lập";
            this.NgayLap.FieldName = "NgayLap";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.OptionsColumn.AllowEdit = false;
            this.NgayLap.OptionsColumn.AllowFocus = false;
            this.NgayLap.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.NgayLap.OptionsColumn.AllowMove = false;
            this.NgayLap.OptionsColumn.ReadOnly = true;
            this.NgayLap.Visible = true;
            this.NgayLap.VisibleIndex = 2;
            this.NgayLap.Width = 133;
            // 
            // NguoiLap
            // 
            this.NguoiLap.Caption = "Người lập";
            this.NguoiLap.FieldName = "NguoiLap";
            this.NguoiLap.Name = "NguoiLap";
            this.NguoiLap.OptionsColumn.AllowEdit = false;
            this.NguoiLap.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.NguoiLap.Visible = true;
            this.NguoiLap.VisibleIndex = 3;
            this.NguoiLap.Width = 163;
            // 
            // Draft
            // 
            this.Draft.Caption = "Bản nháp";
            this.Draft.ColumnEdit = this.repCheck;
            this.Draft.FieldName = "Draft";
            this.Draft.Name = "Draft";
            this.Draft.OptionsColumn.AllowEdit = false;
            this.Draft.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Draft.Visible = true;
            this.Draft.VisibleIndex = 4;
            this.Draft.Width = 92;
            // 
            // DaDuyet
            // 
            this.DaDuyet.Caption = "Đã duyệt";
            this.DaDuyet.ColumnEdit = this.repCheck;
            this.DaDuyet.FieldName = "DaDuyet";
            this.DaDuyet.Name = "DaDuyet";
            this.DaDuyet.OptionsColumn.AllowEdit = false;
            this.DaDuyet.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.DaDuyet.Visible = true;
            this.DaDuyet.VisibleIndex = 5;
            this.DaDuyet.Width = 93;
            // 
            // NgayDuyet
            // 
            this.NgayDuyet.Caption = "Ngày duyệt";
            this.NgayDuyet.FieldName = "NgayDuyet";
            this.NgayDuyet.Name = "NgayDuyet";
            this.NgayDuyet.OptionsColumn.AllowEdit = false;
            this.NgayDuyet.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.NgayDuyet.Visible = true;
            this.NgayDuyet.VisibleIndex = 6;
            this.NgayDuyet.Width = 139;
            // 
            // NguoiTao
            // 
            this.NguoiTao.Caption = "Người tạo";
            this.NguoiTao.FieldName = "NguoiTao";
            this.NguoiTao.Name = "NguoiTao";
            this.NguoiTao.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.NguoiTao.Visible = true;
            this.NguoiTao.VisibleIndex = 7;
            this.NguoiTao.Width = 140;
            // 
            // frmCS_TimKiem_BangGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 475);
            this.Controls.Add(this.grpKetQuaTimKiem);
            this.Controls.Add(this.cmdThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdSua);
            this.KeyPreview = true;
            this.Name = "frmCS_TimKiem_BangGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm bảng giá bán";
            this.Load += new System.EventHandler(this.frm_TimKiem_BangGia_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_TimKiem_BangGia_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.repCheck)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).EndInit();
            this.grpKetQuaTimKiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gListBangGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListBangGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private GtidButton cmdTimKiem;
        private GtidButton cmdSua;
        private GtidButton cmdThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private GtidTextBox txtSoBangGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker mstHanHieuLuc;
        private System.Windows.Forms.DateTimePicker mstNgayHieuLuc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.GroupBox grpKetQuaTimKiem;
        private DevExpress.XtraGrid.GridControl gListBangGia;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListBangGia;
        private DevExpress.XtraGrid.Columns.GridColumn SoBangGia;
        private DevExpress.XtraGrid.Columns.GridColumn NgayLap;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiLap;
        private DevExpress.XtraGrid.Columns.GridColumn Draft;
        private DevExpress.XtraGrid.Columns.GridColumn IdBangGia;
        private GtidTextBox txtNguoiLap;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Columns.GridColumn MaTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn TenTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn NgayDuyet;
        private DevExpress.XtraGrid.Columns.GridColumn DaDuyet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboDuyet;
        private GtidTextBox txtGhiChu;
        private System.Windows.Forms.Label label8;
        private GtidTextBox txtMatHang;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiTao;
        private DevExpress.XtraEditors.ButtonEdit bteTrungTam;
        private System.Windows.Forms.CheckBox chkDaDuyet;
        private System.Windows.Forms.CheckBox chkCuaToi;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheck;
        private GtidButton cmdExport;
        private GtidButton btnNext;
        private System.Windows.Forms.ComboBox cboPage;

    }
}