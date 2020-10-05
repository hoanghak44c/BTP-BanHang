using QLBH.Core.Form;
namespace QLBanHang.Modules.BanHang
{
    partial class frmBC_LichSuMaVach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBC_LichSuMaVach));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bteSanPham = new DevExpress.XtraEditors.ButtonEdit();
            this.cmdExport = new QLBH.Core.Form.GtidButton();
            this.btnDong = new QLBH.Core.Form.GtidButton();
            this.btnTim = new QLBH.Core.Form.GtidButton();
            this.dteEnd = new DevExpress.XtraEditors.DateEdit();
            this.dteStart = new DevExpress.XtraEditors.DateEdit();
            this.lblEnd = new DevExpress.XtraEditors.LabelControl();
            this.lblStart = new DevExpress.XtraEditors.LabelControl();
            this.lueLoaiGiaoDich = new DevExpress.XtraEditors.LookUpEdit();
            this.lblTrangThaiDH = new DevExpress.XtraEditors.LabelControl();
            this.bteKhoXuat = new DevExpress.XtraEditors.ButtonEdit();
            this.bteTrungTam = new DevExpress.XtraEditors.ButtonEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaVach = new QLBH.Core.Form.GtidTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoGiaoDich = new QLBH.Core.Form.GtidTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblThuocXuat = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.grpKetQuaTimKiem = new System.Windows.Forms.GroupBox();
            this.gListChungTu = new DevExpress.XtraGrid.GridControl();
            this.gvListChungTu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaVach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Kho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiGiaoDich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoSeri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoChungTuGoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LinhVuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repLoaiDonHang = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLoaiGiaoDich.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhoXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).BeginInit();
            this.grpKetQuaTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gListChungTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListChungTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bteSanPham);
            this.groupBox1.Controls.Add(this.cmdExport);
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.dteEnd);
            this.groupBox1.Controls.Add(this.dteStart);
            this.groupBox1.Controls.Add(this.lblEnd);
            this.groupBox1.Controls.Add(this.lblStart);
            this.groupBox1.Controls.Add(this.lueLoaiGiaoDich);
            this.groupBox1.Controls.Add(this.lblTrangThaiDH);
            this.groupBox1.Controls.Add(this.bteKhoXuat);
            this.groupBox1.Controls.Add(this.bteTrungTam);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMaVach);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSoGiaoDich);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblThuocXuat);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // bteSanPham
            // 
            this.bteSanPham.Location = new System.Drawing.Point(96, 75);
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
            this.cmdExport.Location = new System.Drawing.Point(886, 45);
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
            this.btnDong.Location = new System.Drawing.Point(886, 73);
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
            this.btnTim.Location = new System.Drawing.Point(886, 17);
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
            this.dteEnd.Location = new System.Drawing.Point(718, 48);
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
            this.dteEnd.Size = new System.Drawing.Size(126, 20);
            this.dteEnd.TabIndex = 11;
            // 
            // dteStart
            // 
            this.dteStart.EditValue = null;
            this.dteStart.Location = new System.Drawing.Point(530, 48);
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
            this.dteStart.Size = new System.Drawing.Size(122, 20);
            this.dteStart.TabIndex = 10;
            // 
            // lblEnd
            // 
            this.lblEnd.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEnd.Appearance.Options.UseFont = true;
            this.lblEnd.Location = new System.Drawing.Point(669, 50);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(45, 13);
            this.lblEnd.TabIndex = 145;
            this.lblEnd.Text = "đến ngày";
            // 
            // lblStart
            // 
            this.lblStart.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStart.Appearance.Options.UseFont = true;
            this.lblStart.Location = new System.Drawing.Point(484, 50);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(40, 13);
            this.lblStart.TabIndex = 144;
            this.lblStart.Text = "Từ ngày";
            // 
            // lueLoaiGiaoDich
            // 
            this.lueLoaiGiaoDich.Location = new System.Drawing.Point(718, 21);
            this.lueLoaiGiaoDich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lueLoaiGiaoDich.Name = "lueLoaiGiaoDich";
            this.lueLoaiGiaoDich.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lueLoaiGiaoDich.Properties.Appearance.Options.UseFont = true;
            this.lueLoaiGiaoDich.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueLoaiGiaoDich.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.lueLoaiGiaoDich.Properties.DisplayMember = "Name";
            this.lueLoaiGiaoDich.Properties.NullText = "";
            this.lueLoaiGiaoDich.Properties.ShowFooter = false;
            this.lueLoaiGiaoDich.Properties.ShowHeader = false;
            this.lueLoaiGiaoDich.Properties.ValueMember = "Id";
            this.lueLoaiGiaoDich.Size = new System.Drawing.Size(126, 20);
            this.lueLoaiGiaoDich.TabIndex = 4;
            // 
            // lblTrangThaiDH
            // 
            this.lblTrangThaiDH.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTrangThaiDH.Appearance.Options.UseFont = true;
            this.lblTrangThaiDH.Location = new System.Drawing.Point(653, 23);
            this.lblTrangThaiDH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTrangThaiDH.Name = "lblTrangThaiDH";
            this.lblTrangThaiDH.Size = new System.Drawing.Size(64, 13);
            this.lblTrangThaiDH.TabIndex = 141;
            this.lblTrangThaiDH.Text = "Loại giao dịch";
            // 
            // bteKhoXuat
            // 
            this.bteKhoXuat.Location = new System.Drawing.Point(96, 47);
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
            this.bteTrungTam.Location = new System.Drawing.Point(96, 20);
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
            this.label7.Location = new System.Drawing.Point(35, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 118;
            this.label7.Text = "Trung tâm";
            // 
            // txtMaVach
            // 
            this.txtMaVach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVach.Location = new System.Drawing.Point(530, 76);
            this.txtMaVach.Name = "txtMaVach";
            this.txtMaVach.Size = new System.Drawing.Size(314, 20);
            this.txtMaVach.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(475, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 115;
            this.label5.Text = "Mã vạch";
            // 
            // txtSoGiaoDich
            // 
            this.txtSoGiaoDich.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoGiaoDich.Location = new System.Drawing.Point(530, 21);
            this.txtSoGiaoDich.Name = "txtSoGiaoDich";
            this.txtSoGiaoDich.Size = new System.Drawing.Size(122, 20);
            this.txtSoGiaoDich.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(475, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "Số phiếu";
            // 
            // lblThuocXuat
            // 
            this.lblThuocXuat.AutoSize = true;
            this.lblThuocXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuocXuat.Location = new System.Drawing.Point(35, 79);
            this.lblThuocXuat.Name = "lblThuocXuat";
            this.lblThuocXuat.Size = new System.Drawing.Size(55, 13);
            this.lblThuocXuat.TabIndex = 0;
            this.lblThuocXuat.Text = "Sản phẩm";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(37, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 91;
            this.label17.Text = "Kho hàng";
            // 
            // grpKetQuaTimKiem
            // 
            this.grpKetQuaTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKetQuaTimKiem.Controls.Add(this.gListChungTu);
            this.grpKetQuaTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKetQuaTimKiem.ForeColor = System.Drawing.Color.Black;
            this.grpKetQuaTimKiem.Location = new System.Drawing.Point(1, 119);
            this.grpKetQuaTimKiem.Name = "grpKetQuaTimKiem";
            this.grpKetQuaTimKiem.Size = new System.Drawing.Size(1018, 410);
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
            this.repEdit,
            this.repLoaiDonHang,
            this.repositoryItemGridLookUpEdit1});
            this.gListChungTu.Size = new System.Drawing.Size(1006, 385);
            this.gListChungTu.TabIndex = 0;
            this.gListChungTu.UseEmbeddedNavigator = true;
            this.gListChungTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListChungTu});
            // 
            // gvListChungTu
            // 
            this.gvListChungTu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdSanPham,
            this.MaSanPham,
            this.TenSanPham,
            this.MaVach,
            this.DonViTinh,
            this.SoLuong,
            this.Ngay,
            this.colTrangThai,
            this.Kho,
            this.colMaKho,
            this.TrungTam,
            this.SoChungTu,
            this.colLoaiGiaoDich,
            this.SoSeri,
            this.SoChungTuGoc,
            this.LinhVuc,
            this.Nganh});
            this.gvListChungTu.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvListChungTu.GridControl = this.gListChungTu;
            this.gvListChungTu.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoLuong", null, "  (Tổng số  = {0})")});
            this.gvListChungTu.Name = "gvListChungTu";
            this.gvListChungTu.OptionsView.ColumnAutoWidth = false;
            this.gvListChungTu.OptionsView.ShowAutoFilterRow = true;
            this.gvListChungTu.OptionsView.ShowDetailButtons = false;
            this.gvListChungTu.OptionsView.ShowFooter = true;
            this.gvListChungTu.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvListChungTu_FocusedRowChanged);
            this.gvListChungTu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gListChungTu_KeyDown);
            this.gvListChungTu.DoubleClick += new System.EventHandler(this.gListChungTu_DoubleClick);
            // 
            // IdSanPham
            // 
            this.IdSanPham.Caption = "IdSanPham";
            this.IdSanPham.FieldName = "IdSanPham";
            this.IdSanPham.Name = "IdSanPham";
            this.IdSanPham.OptionsColumn.ReadOnly = true;
            // 
            // MaSanPham
            // 
            this.MaSanPham.Caption = "Mã sản phẩm";
            this.MaSanPham.FieldName = "MaSanPham";
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.OptionsColumn.ReadOnly = true;
            this.MaSanPham.Visible = true;
            this.MaSanPham.VisibleIndex = 0;
            // 
            // TenSanPham
            // 
            this.TenSanPham.Caption = "Tên Sản phẩm";
            this.TenSanPham.FieldName = "TenSanPham";
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.OptionsColumn.ReadOnly = true;
            this.TenSanPham.Visible = true;
            this.TenSanPham.VisibleIndex = 1;
            this.TenSanPham.Width = 221;
            // 
            // MaVach
            // 
            this.MaVach.Caption = "Mã vạch";
            this.MaVach.FieldName = "MaVach";
            this.MaVach.Name = "MaVach";
            this.MaVach.OptionsColumn.ReadOnly = true;
            this.MaVach.Visible = true;
            this.MaVach.VisibleIndex = 2;
            this.MaVach.Width = 120;
            // 
            // DonViTinh
            // 
            this.DonViTinh.Caption = "ĐVT";
            this.DonViTinh.FieldName = "DonViTinh";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.OptionsColumn.ReadOnly = true;
            this.DonViTinh.Visible = true;
            this.DonViTinh.VisibleIndex = 3;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.OptionsColumn.ReadOnly = true;
            this.SoLuong.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 4;
            // 
            // Ngay
            // 
            this.Ngay.Caption = "Ngày";
            this.Ngay.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss tt";
            this.Ngay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Ngay.FieldName = "Ngay";
            this.Ngay.Name = "Ngay";
            this.Ngay.OptionsColumn.ReadOnly = true;
            this.Ngay.Visible = true;
            this.Ngay.VisibleIndex = 5;
            this.Ngay.Width = 95;
            // 
            // colTrangThai
            // 
            this.colTrangThai.Caption = "Trạng thái";
            this.colTrangThai.FieldName = "TrangThai";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Visible = true;
            this.colTrangThai.VisibleIndex = 14;
            // 
            // Kho
            // 
            this.Kho.Caption = "Kho thực hiện";
            this.Kho.FieldName = "Kho";
            this.Kho.Name = "Kho";
            this.Kho.OptionsColumn.ReadOnly = true;
            this.Kho.Visible = true;
            this.Kho.VisibleIndex = 6;
            this.Kho.Width = 171;
            // 
            // colMaKho
            // 
            this.colMaKho.Caption = "Mã kho";
            this.colMaKho.FieldName = "MaKho";
            this.colMaKho.Name = "colMaKho";
            this.colMaKho.Visible = true;
            this.colMaKho.VisibleIndex = 8;
            // 
            // TrungTam
            // 
            this.TrungTam.Caption = "Trung tâm";
            this.TrungTam.FieldName = "TrungTam";
            this.TrungTam.Name = "TrungTam";
            this.TrungTam.OptionsColumn.ReadOnly = true;
            this.TrungTam.Visible = true;
            this.TrungTam.VisibleIndex = 7;
            this.TrungTam.Width = 176;
            // 
            // SoChungTu
            // 
            this.SoChungTu.Caption = "Số giao dịch";
            this.SoChungTu.FieldName = "SoChungTu";
            this.SoChungTu.Name = "SoChungTu";
            this.SoChungTu.OptionsColumn.ReadOnly = true;
            this.SoChungTu.Visible = true;
            this.SoChungTu.VisibleIndex = 9;
            this.SoChungTu.Width = 89;
            // 
            // colLoaiGiaoDich
            // 
            this.colLoaiGiaoDich.Caption = "Loại Giao Dịch";
            this.colLoaiGiaoDich.FieldName = "LoaiGiaoDich";
            this.colLoaiGiaoDich.Name = "colLoaiGiaoDich";
            this.colLoaiGiaoDich.Visible = true;
            this.colLoaiGiaoDich.VisibleIndex = 15;
            // 
            // SoSeri
            // 
            this.SoSeri.Caption = "Số hóa đơn";
            this.SoSeri.FieldName = "SoSeri";
            this.SoSeri.Name = "SoSeri";
            this.SoSeri.OptionsColumn.ReadOnly = true;
            this.SoSeri.Visible = true;
            this.SoSeri.VisibleIndex = 10;
            this.SoSeri.Width = 90;
            // 
            // SoChungTuGoc
            // 
            this.SoChungTuGoc.Caption = "Số chứng từ gốc";
            this.SoChungTuGoc.FieldName = "SoChungTuGoc";
            this.SoChungTuGoc.Name = "SoChungTuGoc";
            this.SoChungTuGoc.OptionsColumn.ReadOnly = true;
            this.SoChungTuGoc.Visible = true;
            this.SoChungTuGoc.VisibleIndex = 11;
            this.SoChungTuGoc.Width = 116;
            // 
            // LinhVuc
            // 
            this.LinhVuc.Caption = "Lĩnh vực";
            this.LinhVuc.FieldName = "LinhVuc";
            this.LinhVuc.Name = "LinhVuc";
            this.LinhVuc.Visible = true;
            this.LinhVuc.VisibleIndex = 12;
            this.LinhVuc.Width = 88;
            // 
            // Nganh
            // 
            this.Nganh.Caption = "Ngành";
            this.Nganh.FieldName = "Nganh";
            this.Nganh.Name = "Nganh";
            this.Nganh.Visible = true;
            this.Nganh.VisibleIndex = 13;
            this.Nganh.Width = 115;
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
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // frmBC_LichSuMaVach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 532);
            this.Controls.Add(this.grpKetQuaTimKiem);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmBC_LichSuMaVach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch sử chi tiết mã vạch";
            this.Load += new System.EventHandler(this.frmBH_TimChungTu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBH_TimChungTu_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLoaiGiaoDich.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhoXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).EndInit();
            this.grpKetQuaTimKiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gListChungTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListChungTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpKetQuaTimKiem;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label3;
        internal GtidButton btnDong;
        private GtidButton btnTim;
        private GtidTextBox txtSoGiaoDich;
        private GtidTextBox txtMaVach;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.ButtonEdit bteTrungTam;
        private DevExpress.XtraEditors.ButtonEdit bteKhoXuat;
        private System.Windows.Forms.Label lblThuocXuat;
        private DevExpress.XtraEditors.LookUpEdit lueLoaiGiaoDich;
        private DevExpress.XtraEditors.LabelControl lblTrangThaiDH;
        private DevExpress.XtraEditors.DateEdit dteEnd;
        private DevExpress.XtraEditors.DateEdit dteStart;
        private DevExpress.XtraEditors.LabelControl lblEnd;
        private DevExpress.XtraEditors.LabelControl lblStart;
        private DevExpress.XtraGrid.GridControl gListChungTu;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListChungTu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLoaiDonHang;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repEdit;
        private GtidButton cmdExport;
        private DevExpress.XtraGrid.Columns.GridColumn IdSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn MaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn MaVach;
        private DevExpress.XtraGrid.Columns.GridColumn DonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn Ngay;
        private DevExpress.XtraGrid.Columns.GridColumn Kho;
        private DevExpress.XtraGrid.Columns.GridColumn TrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn SoChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn SoSeri;
        private DevExpress.XtraGrid.Columns.GridColumn SoChungTuGoc;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Columns.GridColumn LinhVuc;
        private DevExpress.XtraGrid.Columns.GridColumn Nganh;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKho;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThai;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.ButtonEdit bteSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiGiaoDich;
    }
}