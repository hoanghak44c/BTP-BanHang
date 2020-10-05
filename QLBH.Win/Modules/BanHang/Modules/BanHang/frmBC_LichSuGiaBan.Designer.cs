namespace QLBanHang.Modules.BanHang
{
    partial class frmBC_LichSuGiaBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBC_LichSuGiaBan));
            this.colAtTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCheck = new QLBH.Core.Form.GtidButton();
            this.chkKhongThayDoi = new DevExpress.XtraEditors.CheckEdit();
            this.chkCoThayDoiGia = new DevExpress.XtraEditors.CheckEdit();
            this.bteSanPham = new DevExpress.XtraEditors.ButtonEdit();
            this.cmdExport = new QLBH.Core.Form.GtidButton();
            this.btnDong = new QLBH.Core.Form.GtidButton();
            this.btnTim = new QLBH.Core.Form.GtidButton();
            this.dteEnd = new DevExpress.XtraEditors.DateEdit();
            this.dteStart = new DevExpress.XtraEditors.DateEdit();
            this.lblEnd = new DevExpress.XtraEditors.LabelControl();
            this.lblStart = new DevExpress.XtraEditors.LabelControl();
            this.bteTrungTam = new DevExpress.XtraEditors.ButtonEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.lblThuocXuat = new System.Windows.Forms.Label();
            this.colIdSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLoaiDonHang = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colNganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.colLinhVuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvListLichSuGia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhuyenMai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gListLichSuGia = new DevExpress.XtraGrid.GridControl();
            this.grpKetQuaTimKiem = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkKhongThayDoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCoThayDoiGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListLichSuGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gListLichSuGia)).BeginInit();
            this.grpKetQuaTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // colAtTime
            // 
            this.colAtTime.Caption = "Đến thời điểm";
            this.colAtTime.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss tt";
            this.colAtTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colAtTime.FieldName = "AtTime";
            this.colAtTime.Name = "colAtTime";
            this.colAtTime.OptionsColumn.ReadOnly = true;
            this.colAtTime.Visible = true;
            this.colAtTime.VisibleIndex = 2;
            this.colAtTime.Width = 95;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnCheck);
            this.groupBox1.Controls.Add(this.chkKhongThayDoi);
            this.groupBox1.Controls.Add(this.chkCoThayDoiGia);
            this.groupBox1.Controls.Add(this.bteSanPham);
            this.groupBox1.Controls.Add(this.cmdExport);
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.dteEnd);
            this.groupBox1.Controls.Add(this.dteStart);
            this.groupBox1.Controls.Add(this.lblEnd);
            this.groupBox1.Controls.Add(this.lblStart);
            this.groupBox1.Controls.Add(this.bteTrungTam);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblThuocXuat);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(3, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnCheck
            // 
            this.btnCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnCheck.Image")));
            this.btnCheck.Location = new System.Drawing.Point(538, 17);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnCheck.Size = new System.Drawing.Size(101, 24);
            this.btnCheck.TabIndex = 149;
            this.btnCheck.Text = "Check";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // chkKhongThayDoi
            // 
            this.chkKhongThayDoi.Location = new System.Drawing.Point(96, 129);
            this.chkKhongThayDoi.Name = "chkKhongThayDoi";
            this.chkKhongThayDoi.Properties.Caption = "Hiển thị toàn bộ các sản phẩm không thay đổi giá, khuyến mại";
            this.chkKhongThayDoi.Size = new System.Drawing.Size(329, 18);
            this.chkKhongThayDoi.TabIndex = 148;
            this.chkKhongThayDoi.CheckedChanged += new System.EventHandler(this.chkKhongThayDoi_CheckedChanged);
            // 
            // chkCoThayDoiGia
            // 
            this.chkCoThayDoiGia.Location = new System.Drawing.Point(96, 105);
            this.chkCoThayDoiGia.Name = "chkCoThayDoiGia";
            this.chkCoThayDoiGia.Properties.Caption = "Chỉ lấy các sản phẩm có thay đổi giá, khuyến mại";
            this.chkCoThayDoiGia.Size = new System.Drawing.Size(329, 18);
            this.chkCoThayDoiGia.TabIndex = 147;
            this.chkCoThayDoiGia.CheckedChanged += new System.EventHandler(this.chkCoThayDoiGia_CheckedChanged);
            // 
            // bteSanPham
            // 
            this.bteSanPham.Location = new System.Drawing.Point(96, 48);
            this.bteSanPham.Name = "bteSanPham";
            this.bteSanPham.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteSanPham.Properties.Appearance.Options.UseFont = true;
            this.bteSanPham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteSanPham.Size = new System.Drawing.Size(329, 22);
            this.bteSanPham.TabIndex = 146;
            this.bteSanPham.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteSanPham_ButtonClick);
            // 
            // cmdExport
            // 
            this.cmdExport.Image = ((System.Drawing.Image)(resources.GetObject("cmdExport.Image")));
            this.cmdExport.Location = new System.Drawing.Point(431, 45);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdExport.Size = new System.Drawing.Size(101, 24);
            this.cmdExport.TabIndex = 20;
            this.cmdExport.Text = "Export (F12)";
            this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(431, 73);
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
            this.btnTim.Location = new System.Drawing.Point(431, 17);
            this.btnTim.Name = "btnTim";
            this.btnTim.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnTim.Size = new System.Drawing.Size(101, 24);
            this.btnTim.TabIndex = 19;
            this.btnTim.Text = "&Tìm kiếm (F3)";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dteEnd
            // 
            this.dteEnd.EditValue = null;
            this.dteEnd.Location = new System.Drawing.Point(284, 78);
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
            this.dteEnd.Size = new System.Drawing.Size(140, 20);
            this.dteEnd.TabIndex = 11;
            // 
            // dteStart
            // 
            this.dteStart.EditValue = null;
            this.dteStart.Location = new System.Drawing.Point(96, 78);
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
            this.dteStart.Size = new System.Drawing.Size(131, 20);
            this.dteStart.TabIndex = 10;
            // 
            // lblEnd
            // 
            this.lblEnd.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEnd.Appearance.Options.UseFont = true;
            this.lblEnd.Location = new System.Drawing.Point(235, 80);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(45, 13);
            this.lblEnd.TabIndex = 145;
            this.lblEnd.Text = "đến ngày";
            // 
            // lblStart
            // 
            this.lblStart.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStart.Appearance.Options.UseFont = true;
            this.lblStart.Location = new System.Drawing.Point(50, 80);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(40, 13);
            this.lblStart.TabIndex = 144;
            this.lblStart.Text = "Từ ngày";
            // 
            // bteTrungTam
            // 
            this.bteTrungTam.Location = new System.Drawing.Point(96, 20);
            this.bteTrungTam.Name = "bteTrungTam";
            this.bteTrungTam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteTrungTam.Properties.Appearance.Options.UseFont = true;
            this.bteTrungTam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteTrungTam.Size = new System.Drawing.Size(329, 22);
            this.bteTrungTam.TabIndex = 5;
            this.bteTrungTam.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteTrungTam_ButtonClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 118;
            this.label7.Text = "Trung tâm";
            // 
            // lblThuocXuat
            // 
            this.lblThuocXuat.AutoSize = true;
            this.lblThuocXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuocXuat.Location = new System.Drawing.Point(35, 52);
            this.lblThuocXuat.Name = "lblThuocXuat";
            this.lblThuocXuat.Size = new System.Drawing.Size(55, 13);
            this.lblThuocXuat.TabIndex = 0;
            this.lblThuocXuat.Text = "Sản phẩm";
            // 
            // colIdSanPham
            // 
            this.colIdSanPham.Caption = "IdSanPham";
            this.colIdSanPham.FieldName = "IdSanPham";
            this.colIdSanPham.Name = "colIdSanPham";
            this.colIdSanPham.OptionsColumn.ReadOnly = true;
            // 
            // colMaSanPham
            // 
            this.colMaSanPham.Caption = "Mã sản phẩm";
            this.colMaSanPham.FieldName = "MaSanPham";
            this.colMaSanPham.Name = "colMaSanPham";
            this.colMaSanPham.OptionsColumn.ReadOnly = true;
            this.colMaSanPham.Visible = true;
            this.colMaSanPham.VisibleIndex = 1;
            // 
            // colTenSanPham
            // 
            this.colTenSanPham.Caption = "Tên Sản phẩm";
            this.colTenSanPham.FieldName = "TenSanPham";
            this.colTenSanPham.Name = "colTenSanPham";
            this.colTenSanPham.OptionsColumn.ReadOnly = true;
            this.colTenSanPham.Width = 221;
            // 
            // repEdit
            // 
            this.repEdit.AutoHeight = false;
            this.repEdit.Name = "repEdit";
            this.repEdit.ValueChecked = 1;
            this.repEdit.ValueUnchecked = 0;
            // 
            // colTrungTam
            // 
            this.colTrungTam.Caption = "Trung tâm";
            this.colTrungTam.FieldName = "MaTrungTam";
            this.colTrungTam.Name = "colTrungTam";
            this.colTrungTam.OptionsColumn.ReadOnly = true;
            this.colTrungTam.Visible = true;
            this.colTrungTam.VisibleIndex = 0;
            this.colTrungTam.Width = 176;
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
            // colNganh
            // 
            this.colNganh.Caption = "Ngành";
            this.colNganh.FieldName = "Nganh";
            this.colNganh.Name = "colNganh";
            this.colNganh.Width = 115;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            // 
            // colLinhVuc
            // 
            this.colLinhVuc.Caption = "Lĩnh vực";
            this.colLinhVuc.FieldName = "LinhVuc";
            this.colLinhVuc.Name = "colLinhVuc";
            this.colLinhVuc.Width = 88;
            // 
            // gvListLichSuGia
            // 
            this.gvListLichSuGia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdSanPham,
            this.colTrungTam,
            this.colMaSanPham,
            this.colTenSanPham,
            this.colAtTime,
            this.colLinhVuc,
            this.colNganh,
            this.colGiaBan,
            this.colKhuyenMai});
            this.gvListLichSuGia.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvListLichSuGia.GridControl = this.gListLichSuGia;
            this.gvListLichSuGia.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoLuong", null, "  (Tổng số  = {0})")});
            this.gvListLichSuGia.Name = "gvListLichSuGia";
            this.gvListLichSuGia.OptionsView.ColumnAutoWidth = false;
            this.gvListLichSuGia.OptionsView.ShowAutoFilterRow = true;
            this.gvListLichSuGia.OptionsView.ShowDetailButtons = false;
            this.gvListLichSuGia.OptionsView.ShowFooter = true;
            // 
            // colGiaBan
            // 
            this.colGiaBan.Caption = "Giá Bán";
            this.colGiaBan.FieldName = "GiaBan";
            this.colGiaBan.Name = "colGiaBan";
            this.colGiaBan.Visible = true;
            this.colGiaBan.VisibleIndex = 3;
            // 
            // colKhuyenMai
            // 
            this.colKhuyenMai.Caption = "Khuyến Mại";
            this.colKhuyenMai.FieldName = "KhuyenMai";
            this.colKhuyenMai.Name = "colKhuyenMai";
            this.colKhuyenMai.Visible = true;
            this.colKhuyenMai.VisibleIndex = 4;
            // 
            // gListLichSuGia
            // 
            this.gListLichSuGia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gListLichSuGia.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gListLichSuGia.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gListLichSuGia.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gListLichSuGia.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gListLichSuGia.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gListLichSuGia.EmbeddedNavigator.TextStringFormat = "{0} / Tổng số {1}";
            this.gListLichSuGia.Location = new System.Drawing.Point(6, 19);
            this.gListLichSuGia.MainView = this.gvListLichSuGia;
            this.gListLichSuGia.Name = "gListLichSuGia";
            this.gListLichSuGia.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repEdit,
            this.repLoaiDonHang,
            this.repositoryItemGridLookUpEdit1});
            this.gListLichSuGia.Size = new System.Drawing.Size(757, 332);
            this.gListLichSuGia.TabIndex = 0;
            this.gListLichSuGia.UseEmbeddedNavigator = true;
            this.gListLichSuGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListLichSuGia});
            // 
            // grpKetQuaTimKiem
            // 
            this.grpKetQuaTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKetQuaTimKiem.Controls.Add(this.gListLichSuGia);
            this.grpKetQuaTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKetQuaTimKiem.ForeColor = System.Drawing.Color.Black;
            this.grpKetQuaTimKiem.Location = new System.Drawing.Point(3, 164);
            this.grpKetQuaTimKiem.Name = "grpKetQuaTimKiem";
            this.grpKetQuaTimKiem.Size = new System.Drawing.Size(769, 357);
            this.grpKetQuaTimKiem.TabIndex = 3;
            this.grpKetQuaTimKiem.TabStop = false;
            this.grpKetQuaTimKiem.Text = "Lịch sử giá trong ngày";
            // 
            // frmBC_LichSuGiaBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 533);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpKetQuaTimKiem);
            this.Name = "frmBC_LichSuGiaBan";
            this.Text = "Lịch sử đồng bộ giá bán";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkKhongThayDoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCoThayDoiGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListLichSuGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gListLichSuGia)).EndInit();
            this.grpKetQuaTimKiem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colAtTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.ButtonEdit bteSanPham;
        private QLBH.Core.Form.GtidButton cmdExport;
        internal QLBH.Core.Form.GtidButton btnDong;
        private QLBH.Core.Form.GtidButton btnTim;
        private DevExpress.XtraEditors.DateEdit dteEnd;
        private DevExpress.XtraEditors.DateEdit dteStart;
        private DevExpress.XtraEditors.LabelControl lblEnd;
        private DevExpress.XtraEditors.LabelControl lblStart;
        private DevExpress.XtraEditors.ButtonEdit bteTrungTam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblThuocXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSanPham;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colTrungTam;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLoaiDonHang;
        private DevExpress.XtraGrid.Columns.GridColumn colNganh;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colLinhVuc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListLichSuGia;
        private DevExpress.XtraGrid.GridControl gListLichSuGia;
        private System.Windows.Forms.GroupBox grpKetQuaTimKiem;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaBan;
        private DevExpress.XtraGrid.Columns.GridColumn colKhuyenMai;
        private DevExpress.XtraEditors.CheckEdit chkKhongThayDoi;
        private DevExpress.XtraEditors.CheckEdit chkCoThayDoiGia;
        private QLBH.Core.Form.GtidButton btnCheck;
    }
}