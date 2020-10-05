using QLBH.Core.Form;
namespace QLBanHang.Modules.BanHang
{
    partial class frmBC_TongHopKhungGioNganh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBC_TongHopKhungGioNganh));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lueKhungGio = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bteNganh = new DevExpress.XtraEditors.ButtonEdit();
            this.lblThuocXuat = new System.Windows.Forms.Label();
            this.cmdExport = new QLBH.Core.Form.GtidButton();
            this.btnDong = new QLBH.Core.Form.GtidButton();
            this.btnTim = new QLBH.Core.Form.GtidButton();
            this.dteEnd = new DevExpress.XtraEditors.DateEdit();
            this.dteStart = new DevExpress.XtraEditors.DateEdit();
            this.lblEnd = new DevExpress.XtraEditors.LabelControl();
            this.lblStart = new DevExpress.XtraEditors.LabelControl();
            this.lueLoaiDH = new DevExpress.XtraEditors.LookUpEdit();
            this.lblTrangThaiLinhKien = new DevExpress.XtraEditors.LabelControl();
            this.bteTrungTam = new DevExpress.XtraEditors.ButtonEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.grpKetQuaTimKiem = new System.Windows.Forms.GroupBox();
            this.gListChungTu = new DevExpress.XtraGrid.GridControl();
            this.gvListChungTu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.KhungGio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repKhungGio = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.Ngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NganhHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienSauChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLoaiDonHang = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repLoaiPhieu = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repTrangThai = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueKhungGio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteNganh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLoaiDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).BeginInit();
            this.grpKetQuaTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gListChungTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListChungTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repKhungGio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrangThai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lueKhungGio);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.bteNganh);
            this.groupBox1.Controls.Add(this.lblThuocXuat);
            this.groupBox1.Controls.Add(this.cmdExport);
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.dteEnd);
            this.groupBox1.Controls.Add(this.dteStart);
            this.groupBox1.Controls.Add(this.lblEnd);
            this.groupBox1.Controls.Add(this.lblStart);
            this.groupBox1.Controls.Add(this.lueLoaiDH);
            this.groupBox1.Controls.Add(this.lblTrangThaiLinhKien);
            this.groupBox1.Controls.Add(this.bteTrungTam);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lueKhungGio
            // 
            this.lueKhungGio.Location = new System.Drawing.Point(566, 40);
            this.lueKhungGio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lueKhungGio.Name = "lueKhungGio";
            this.lueKhungGio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lueKhungGio.Properties.Appearance.Options.UseFont = true;
            this.lueKhungGio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueKhungGio.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.lueKhungGio.Properties.DisplayMember = "Name";
            this.lueKhungGio.Properties.NullText = "";
            this.lueKhungGio.Properties.ShowFooter = false;
            this.lueKhungGio.Properties.ShowHeader = false;
            this.lueKhungGio.Properties.ValueMember = "Id";
            this.lueKhungGio.Size = new System.Drawing.Size(314, 20);
            this.lueKhungGio.TabIndex = 156;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(515, 43);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 157;
            this.labelControl1.Text = "Khung giờ";
            // 
            // bteNganh
            // 
            this.bteNganh.Location = new System.Drawing.Point(104, 42);
            this.bteNganh.Name = "bteNganh";
            this.bteNganh.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.bteNganh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteNganh.Properties.Appearance.Options.UseBackColor = true;
            this.bteNganh.Properties.Appearance.Options.UseFont = true;
            this.bteNganh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteNganh.Size = new System.Drawing.Size(314, 21);
            this.bteNganh.TabIndex = 155;
            this.bteNganh.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteNganh_ButtonClick);
            this.bteNganh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteNganh_KeyDown);
            this.bteNganh.TextChanged += new System.EventHandler(this.bteNganh_TextChanged);
            // 
            // lblThuocXuat
            // 
            this.lblThuocXuat.AutoSize = true;
            this.lblThuocXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuocXuat.Location = new System.Drawing.Point(34, 45);
            this.lblThuocXuat.Name = "lblThuocXuat";
            this.lblThuocXuat.Size = new System.Drawing.Size(66, 13);
            this.lblThuocXuat.TabIndex = 154;
            this.lblThuocXuat.Text = "Ngành hàng";
            // 
            // cmdExport
            // 
            this.cmdExport.Image = ((System.Drawing.Image)(resources.GetObject("cmdExport.Image")));
            this.cmdExport.Location = new System.Drawing.Point(673, 67);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdExport.Size = new System.Drawing.Size(101, 25);
            this.cmdExport.TabIndex = 20;
            this.cmdExport.Text = "Export (F12)";
            this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(780, 67);
            this.btnDong.Name = "btnDong";
            this.btnDong.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnDong.Size = new System.Drawing.Size(101, 25);
            this.btnDong.TabIndex = 21;
            this.btnDong.Text = "Đóng (F12)";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnTim
            // 
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.Location = new System.Drawing.Point(566, 67);
            this.btnTim.Name = "btnTim";
            this.btnTim.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnTim.Size = new System.Drawing.Size(101, 25);
            this.btnTim.TabIndex = 19;
            this.btnTim.Text = "&Tìm kiếm (F3)";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dteEnd
            // 
            this.dteEnd.EditValue = null;
            this.dteEnd.Location = new System.Drawing.Point(754, 12);
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
            this.dteStart.Location = new System.Drawing.Point(566, 14);
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
            this.dteStart.Size = new System.Drawing.Size(126, 20);
            this.dteStart.TabIndex = 10;
            // 
            // lblEnd
            // 
            this.lblEnd.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEnd.Appearance.Options.UseFont = true;
            this.lblEnd.Location = new System.Drawing.Point(705, 15);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(45, 13);
            this.lblEnd.TabIndex = 145;
            this.lblEnd.Text = "đến ngày";
            // 
            // lblStart
            // 
            this.lblStart.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStart.Appearance.Options.UseFont = true;
            this.lblStart.Location = new System.Drawing.Point(522, 17);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(40, 13);
            this.lblStart.TabIndex = 144;
            this.lblStart.Text = "Từ ngày";
            // 
            // lueLoaiDH
            // 
            this.lueLoaiDH.Location = new System.Drawing.Point(104, 68);
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
            this.lueLoaiDH.Size = new System.Drawing.Size(314, 20);
            this.lueLoaiDH.TabIndex = 1;
            // 
            // lblTrangThaiLinhKien
            // 
            this.lblTrangThaiLinhKien.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTrangThaiLinhKien.Appearance.Options.UseFont = true;
            this.lblTrangThaiLinhKien.Location = new System.Drawing.Point(32, 71);
            this.lblTrangThaiLinhKien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTrangThaiLinhKien.Name = "lblTrangThaiLinhKien";
            this.lblTrangThaiLinhKien.Size = new System.Drawing.Size(67, 13);
            this.lblTrangThaiLinhKien.TabIndex = 139;
            this.lblTrangThaiLinhKien.Text = "Loại đơn hàng";
            // 
            // bteTrungTam
            // 
            this.bteTrungTam.Location = new System.Drawing.Point(104, 14);
            this.bteTrungTam.Name = "bteTrungTam";
            this.bteTrungTam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteTrungTam.Properties.Appearance.Options.UseFont = true;
            this.bteTrungTam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteTrungTam.Size = new System.Drawing.Size(314, 22);
            this.bteTrungTam.TabIndex = 5;
            this.bteTrungTam.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteTrungTam_ButtonClick);
            this.bteTrungTam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteTrungTam_KeyDown);
            this.bteTrungTam.TextChanged += new System.EventHandler(this.bteTrungTam_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 118;
            this.label7.Text = "Trung tâm bán";
            // 
            // grpKetQuaTimKiem
            // 
            this.grpKetQuaTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKetQuaTimKiem.Controls.Add(this.gListChungTu);
            this.grpKetQuaTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKetQuaTimKiem.ForeColor = System.Drawing.Color.Black;
            this.grpKetQuaTimKiem.Location = new System.Drawing.Point(1, 111);
            this.grpKetQuaTimKiem.Name = "grpKetQuaTimKiem";
            this.grpKetQuaTimKiem.Size = new System.Drawing.Size(1018, 416);
            this.grpKetQuaTimKiem.TabIndex = 1;
            this.grpKetQuaTimKiem.TabStop = false;
            this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm";
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
            this.gListChungTu.EmbeddedNavigator.TextStringFormat = "{0} / {1}";
            this.gListChungTu.Location = new System.Drawing.Point(6, 19);
            this.gListChungTu.MainView = this.gvListChungTu;
            this.gListChungTu.Name = "gListChungTu";
            this.gListChungTu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLoaiDonHang,
            this.repLoaiPhieu,
            this.repTrangThai,
            this.repCheckEdit,
            this.repKhungGio});
            this.gListChungTu.Size = new System.Drawing.Size(1006, 391);
            this.gListChungTu.TabIndex = 0;
            this.gListChungTu.UseEmbeddedNavigator = true;
            this.gListChungTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListChungTu});
            // 
            // gvListChungTu
            // 
            this.gvListChungTu.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvListChungTu.Appearance.FooterPanel.Options.UseFont = true;
            this.gvListChungTu.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvListChungTu.Appearance.GroupPanel.Options.UseFont = true;
            this.gvListChungTu.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvListChungTu.Appearance.GroupRow.Options.UseFont = true;
            this.gvListChungTu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.KhungGio,
            this.Ngay,
            this.NganhHang,
            this.TenTrungTam,
            this.SoLuong,
            this.TienChietKhau,
            this.TienSauChietKhau,
            this.TienVAT,
            this.ThanhTien});
            this.gvListChungTu.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvListChungTu.GridControl = this.gListChungTu;
            this.gvListChungTu.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TienSauChietKhau", this.TienSauChietKhau, "{0:N0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TienVAT", this.TienVAT, "{0:N0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ThanhTien", this.ThanhTien, "{0:N0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TienChietKhau", this.TienChietKhau, "{0:N0}")});
            this.gvListChungTu.Name = "gvListChungTu";
            this.gvListChungTu.OptionsView.ShowAutoFilterRow = true;
            this.gvListChungTu.OptionsView.ShowDetailButtons = false;
            this.gvListChungTu.OptionsView.ShowFooter = true;
            this.gvListChungTu.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvListChungTu_FocusedRowChanged);
            this.gvListChungTu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gListChungTu_KeyDown);
            this.gvListChungTu.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvListChungTu_RowCellStyle);
            this.gvListChungTu.DoubleClick += new System.EventHandler(this.gListChungTu_DoubleClick);
            // 
            // KhungGio
            // 
            this.KhungGio.Caption = "Khung giờ";
            this.KhungGio.ColumnEdit = this.repKhungGio;
            this.KhungGio.FieldName = "KhungGio";
            this.KhungGio.Name = "KhungGio";
            this.KhungGio.Visible = true;
            this.KhungGio.VisibleIndex = 0;
            this.KhungGio.Width = 76;
            // 
            // repKhungGio
            // 
            this.repKhungGio.AutoHeight = false;
            this.repKhungGio.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repKhungGio.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.repKhungGio.DisplayMember = "Name";
            this.repKhungGio.Name = "repKhungGio";
            this.repKhungGio.ValueMember = "Id";
            // 
            // Ngay
            // 
            this.Ngay.Caption = "Ngày";
            this.Ngay.FieldName = "Ngay";
            this.Ngay.Name = "Ngay";
            this.Ngay.Visible = true;
            this.Ngay.VisibleIndex = 1;
            this.Ngay.Width = 77;
            // 
            // NganhHang
            // 
            this.NganhHang.Caption = "Ngành hàng";
            this.NganhHang.FieldName = "NganhHang";
            this.NganhHang.Name = "NganhHang";
            this.NganhHang.Visible = true;
            this.NganhHang.VisibleIndex = 2;
            this.NganhHang.Width = 101;
            // 
            // TenTrungTam
            // 
            this.TenTrungTam.Caption = "Trung tâm";
            this.TenTrungTam.FieldName = "TenTrungTam";
            this.TenTrungTam.Name = "TenTrungTam";
            this.TenTrungTam.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TenTrungTam.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.TenTrungTam.OptionsColumn.ReadOnly = true;
            this.TenTrungTam.Visible = true;
            this.TenTrungTam.VisibleIndex = 3;
            this.TenTrungTam.Width = 233;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.DisplayFormat.FormatString = "N0";
            this.SoLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 4;
            this.SoLuong.Width = 56;
            // 
            // TienChietKhau
            // 
            this.TienChietKhau.Caption = "Tiền Chiết khấu";
            this.TienChietKhau.DisplayFormat.FormatString = "N0";
            this.TienChietKhau.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TienChietKhau.FieldName = "TienChietKhau";
            this.TienChietKhau.Name = "TienChietKhau";
            this.TienChietKhau.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TienChietKhau.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.TienChietKhau.OptionsColumn.ReadOnly = true;
            this.TienChietKhau.SummaryItem.DisplayFormat = "{0:N0}";
            this.TienChietKhau.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.TienChietKhau.Visible = true;
            this.TienChietKhau.VisibleIndex = 5;
            this.TienChietKhau.Width = 128;
            // 
            // TienSauChietKhau
            // 
            this.TienSauChietKhau.Caption = "Thành tiền trước VAT";
            this.TienSauChietKhau.DisplayFormat.FormatString = "N0";
            this.TienSauChietKhau.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TienSauChietKhau.FieldName = "ThanhTienTruocVAT";
            this.TienSauChietKhau.Name = "TienSauChietKhau";
            this.TienSauChietKhau.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TienSauChietKhau.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.TienSauChietKhau.OptionsColumn.ReadOnly = true;
            this.TienSauChietKhau.SummaryItem.DisplayFormat = "{0:N0}";
            this.TienSauChietKhau.SummaryItem.FieldName = "TienSauChietKhau";
            this.TienSauChietKhau.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.TienSauChietKhau.Visible = true;
            this.TienSauChietKhau.VisibleIndex = 6;
            this.TienSauChietKhau.Width = 116;
            // 
            // TienVAT
            // 
            this.TienVAT.Caption = "Tiền VAT";
            this.TienVAT.DisplayFormat.FormatString = "N0";
            this.TienVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TienVAT.FieldName = "TienVAT";
            this.TienVAT.Name = "TienVAT";
            this.TienVAT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TienVAT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.TienVAT.OptionsColumn.ReadOnly = true;
            this.TienVAT.SummaryItem.DisplayFormat = "{0:N0}";
            this.TienVAT.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.TienVAT.Visible = true;
            this.TienVAT.VisibleIndex = 7;
            this.TienVAT.Width = 67;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Caption = "Thành tiền có VAT";
            this.ThanhTien.DisplayFormat.FormatString = "N0";
            this.ThanhTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ThanhTien.FieldName = "ThanhTienSauVAT";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.ThanhTien.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.ThanhTien.OptionsColumn.ReadOnly = true;
            this.ThanhTien.SummaryItem.DisplayFormat = "{0:N0}";
            this.ThanhTien.SummaryItem.FieldName = "ThanhTien";
            this.ThanhTien.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.ThanhTien.Visible = true;
            this.ThanhTien.VisibleIndex = 8;
            this.ThanhTien.Width = 131;
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
            // repLoaiPhieu
            // 
            this.repLoaiPhieu.AutoHeight = false;
            this.repLoaiPhieu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLoaiPhieu.DisplayMember = "Name";
            this.repLoaiPhieu.Name = "repLoaiPhieu";
            this.repLoaiPhieu.ValueMember = "Id";
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
            // repCheckEdit
            // 
            this.repCheckEdit.AutoHeight = false;
            this.repCheckEdit.Name = "repCheckEdit";
            this.repCheckEdit.ValueChecked = 1;
            this.repCheckEdit.ValueUnchecked = 0;
            // 
            // frmBC_TongHopKhungGioNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 532);
            this.Controls.Add(this.grpKetQuaTimKiem);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmBC_TongHopKhungGioNganh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo tổng hợp khung giờ theo ngành";
            this.Load += new System.EventHandler(this.frmBH_TimChungTu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBH_TimChungTu_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueKhungGio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteNganh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLoaiDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).EndInit();
            this.grpKetQuaTimKiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gListChungTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListChungTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repKhungGio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrangThai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpKetQuaTimKiem;
        internal GtidButton btnDong;
        private GtidButton btnTim;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.ButtonEdit bteTrungTam;
        private DevExpress.XtraEditors.LookUpEdit lueLoaiDH;
        private DevExpress.XtraEditors.LabelControl lblTrangThaiLinhKien;
        private DevExpress.XtraEditors.DateEdit dteEnd;
        private DevExpress.XtraEditors.DateEdit dteStart;
        private DevExpress.XtraEditors.LabelControl lblEnd;
        private DevExpress.XtraEditors.LabelControl lblStart;
        private DevExpress.XtraGrid.GridControl gListChungTu;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListChungTu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLoaiDonHang;
        private GtidButton cmdExport;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLoaiPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn TenTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn TienChietKhau;
        private DevExpress.XtraGrid.Columns.GridColumn TienSauChietKhau;
        private DevExpress.XtraGrid.Columns.GridColumn TienVAT;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhTien;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repTrangThai;
        protected DevExpress.XtraEditors.ButtonEdit bteNganh;
        private System.Windows.Forms.Label lblThuocXuat;
        private DevExpress.XtraEditors.LookUpEdit lueKhungGio;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn KhungGio;
        private DevExpress.XtraGrid.Columns.GridColumn Ngay;
        private DevExpress.XtraGrid.Columns.GridColumn NganhHang;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repKhungGio;
    }
}