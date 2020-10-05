using QLBH.Core.Form;
namespace QLBanHang.Modules.BanHang
{
    partial class frmBH_ChonPhieuDieuChuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBH_ChonPhieuDieuChuyen));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoPhieuDC = new QLBH.Core.Form.GtidTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dteEnd = new DevExpress.XtraEditors.DateEdit();
            this.dteStart = new DevExpress.XtraEditors.DateEdit();
            this.lblEnd = new DevExpress.XtraEditors.LabelControl();
            this.lblStart = new DevExpress.XtraEditors.LabelControl();
            this.bteKhoXuat = new DevExpress.XtraEditors.ButtonEdit();
            this.bteTrungTam = new DevExpress.XtraEditors.ButtonEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNhanVien = new QLBH.Core.Form.GtidTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoHoaDonDC = new QLBH.Core.Form.GtidTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSanPham = new QLBH.Core.Form.GtidTextBox();
            this.lblThuocXuat = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.grpKetQuaTimKiem = new System.Windows.Forms.GroupBox();
            this.gListChungTu = new DevExpress.XtraGrid.GridControl();
            this.gvListChungTu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNgayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoPhieuDC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhanVienGiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repLoaiDonHang = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repDraft = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repTrangThaiDH = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.grpThucThi = new System.Windows.Forms.GroupBox();
            this.btnDong = new QLBH.Core.Form.GtidButton();
            this.btnTim = new QLBH.Core.Form.GtidButton();
            this.btnCapNhat = new QLBH.Core.Form.GtidButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhoXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).BeginInit();
            this.grpKetQuaTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gListChungTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListChungTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDraft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrangThaiDH)).BeginInit();
            this.grpThucThi.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtSoPhieuDC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dteEnd);
            this.groupBox1.Controls.Add(this.dteStart);
            this.groupBox1.Controls.Add(this.lblEnd);
            this.groupBox1.Controls.Add(this.lblStart);
            this.groupBox1.Controls.Add(this.bteKhoXuat);
            this.groupBox1.Controls.Add(this.bteTrungTam);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNhanVien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtSoHoaDonDC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSanPham);
            this.groupBox1.Controls.Add(this.lblThuocXuat);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(10, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(950, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtSoPhieuDC
            // 
            this.txtSoPhieuDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoPhieuDC.Location = new System.Drawing.Point(308, 40);
            this.txtSoPhieuDC.Name = "txtSoPhieuDC";
            this.txtSoPhieuDC.Size = new System.Drawing.Size(140, 20);
            this.txtSoPhieuDC.TabIndex = 146;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 147;
            this.label1.Text = "Số phiếu ĐC";
            // 
            // dteEnd
            // 
            this.dteEnd.EditValue = null;
            this.dteEnd.Location = new System.Drawing.Point(308, 14);
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
            this.dteEnd.TabIndex = 1;
            // 
            // dteStart
            // 
            this.dteStart.EditValue = null;
            this.dteStart.Location = new System.Drawing.Point(96, 14);
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
            this.dteStart.Size = new System.Drawing.Size(140, 20);
            this.dteStart.TabIndex = 0;
            // 
            // lblEnd
            // 
            this.lblEnd.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEnd.Appearance.Options.UseFont = true;
            this.lblEnd.Location = new System.Drawing.Point(254, 17);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(45, 13);
            this.lblEnd.TabIndex = 145;
            this.lblEnd.Text = "đến ngày";
            // 
            // lblStart
            // 
            this.lblStart.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Appearance.Options.UseFont = true;
            this.lblStart.Location = new System.Drawing.Point(53, 17);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(39, 13);
            this.lblStart.TabIndex = 144;
            this.lblStart.Text = "Từ ngày";
            // 
            // bteKhoXuat
            // 
            this.bteKhoXuat.Location = new System.Drawing.Point(576, 41);
            this.bteKhoXuat.Name = "bteKhoXuat";
            this.bteKhoXuat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteKhoXuat.Properties.Appearance.Options.UseFont = true;
            this.bteKhoXuat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteKhoXuat.Size = new System.Drawing.Size(352, 22);
            this.bteKhoXuat.TabIndex = 5;
            this.bteKhoXuat.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteKhoXuat_ButtonClick);
            this.bteKhoXuat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteKhoXuat_KeyDown);
            this.bteKhoXuat.TextChanged += new System.EventHandler(this.bteKhoXuat_TextChanged);
            // 
            // bteTrungTam
            // 
            this.bteTrungTam.Location = new System.Drawing.Point(576, 14);
            this.bteTrungTam.Name = "bteTrungTam";
            this.bteTrungTam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteTrungTam.Properties.Appearance.Options.UseFont = true;
            this.bteTrungTam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteTrungTam.Size = new System.Drawing.Size(352, 22);
            this.bteTrungTam.TabIndex = 4;
            this.bteTrungTam.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteTrungTam_ButtonClick);
            this.bteTrungTam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteTrungTam_KeyDown);
            this.bteTrungTam.TextChanged += new System.EventHandler(this.bteTrungTam_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(494, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 118;
            this.label7.Text = "Trung tâm xuất";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanVien.Location = new System.Drawing.Point(576, 68);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(352, 20);
            this.txtNhanVien.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(493, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 115;
            this.label5.Text = "Nhân viên xuất";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(571, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 110;
            this.label9.Text = " ";
            // 
            // txtSoHoaDonDC
            // 
            this.txtSoHoaDonDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoHoaDonDC.Location = new System.Drawing.Point(96, 40);
            this.txtSoHoaDonDC.Name = "txtSoHoaDonDC";
            this.txtSoHoaDonDC.Size = new System.Drawing.Size(140, 20);
            this.txtSoHoaDonDC.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "Số hóa đơn ĐC";
            // 
            // txtSanPham
            // 
            this.txtSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSanPham.Location = new System.Drawing.Point(96, 68);
            this.txtSanPham.Name = "txtSanPham";
            this.txtSanPham.Size = new System.Drawing.Size(352, 20);
            this.txtSanPham.TabIndex = 7;
            // 
            // lblThuocXuat
            // 
            this.lblThuocXuat.AutoSize = true;
            this.lblThuocXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuocXuat.Location = new System.Drawing.Point(37, 71);
            this.lblThuocXuat.Name = "lblThuocXuat";
            this.lblThuocXuat.Size = new System.Drawing.Size(55, 13);
            this.lblThuocXuat.TabIndex = 0;
            this.lblThuocXuat.Text = "Sản phẩm";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(523, 45);
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
            this.grpKetQuaTimKiem.Location = new System.Drawing.Point(10, 163);
            this.grpKetQuaTimKiem.Name = "grpKetQuaTimKiem";
            this.grpKetQuaTimKiem.Size = new System.Drawing.Size(950, 366);
            this.grpKetQuaTimKiem.TabIndex = 2;
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
            this.gListChungTu.EmbeddedNavigator.TextStringFormat = "Đơn hàng số {0} / Tổng số {1} đơn hàng";
            this.gListChungTu.Location = new System.Drawing.Point(6, 19);
            this.gListChungTu.MainView = this.gvListChungTu;
            this.gListChungTu.Name = "gListChungTu";
            this.gListChungTu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repEdit,
            this.repLoaiDonHang,
            this.repDraft,
            this.repTrangThaiDH});
            this.gListChungTu.Size = new System.Drawing.Size(938, 341);
            this.gListChungTu.TabIndex = 0;
            this.gListChungTu.UseEmbeddedNavigator = true;
            this.gListChungTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListChungTu});
            // 
            // gvListChungTu
            // 
            this.gvListChungTu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNgayLap,
            this.colTrungTam,
            this.colKho,
            this.colSoHoaDon,
            this.colSoPhieuDC,
            this.colTenNhanVien,
            this.colNhanVienGiao});
            this.gvListChungTu.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvListChungTu.GridControl = this.gListChungTu;
            this.gvListChungTu.Name = "gvListChungTu";
            this.gvListChungTu.OptionsView.ColumnAutoWidth = false;
            this.gvListChungTu.OptionsView.ShowAutoFilterRow = true;
            this.gvListChungTu.OptionsView.ShowDetailButtons = false;
            this.gvListChungTu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gListChungTu_KeyDown);
            this.gvListChungTu.DoubleClick += new System.EventHandler(this.gListChungTu_DoubleClick);
            // 
            // colNgayLap
            // 
            this.colNgayLap.Caption = "Ngày lập";
            this.colNgayLap.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colNgayLap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayLap.FieldName = "NgayLap";
            this.colNgayLap.Name = "colNgayLap";
            this.colNgayLap.OptionsColumn.AllowEdit = false;
            this.colNgayLap.Visible = true;
            this.colNgayLap.VisibleIndex = 0;
            this.colNgayLap.Width = 113;
            // 
            // colTrungTam
            // 
            this.colTrungTam.Caption = "Trung tâm";
            this.colTrungTam.FieldName = "TenTrungTam";
            this.colTrungTam.Name = "colTrungTam";
            this.colTrungTam.OptionsColumn.AllowEdit = false;
            this.colTrungTam.OptionsColumn.AllowFocus = false;
            this.colTrungTam.OptionsColumn.AllowMove = false;
            this.colTrungTam.OptionsColumn.ReadOnly = true;
            this.colTrungTam.Visible = true;
            this.colTrungTam.VisibleIndex = 1;
            this.colTrungTam.Width = 225;
            // 
            // colKho
            // 
            this.colKho.AppearanceCell.Options.UseTextOptions = true;
            this.colKho.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colKho.Caption = "Kho hàng";
            this.colKho.FieldName = "TenKho";
            this.colKho.Name = "colKho";
            this.colKho.OptionsColumn.AllowEdit = false;
            this.colKho.OptionsColumn.AllowFocus = false;
            this.colKho.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colKho.OptionsColumn.AllowMove = false;
            this.colKho.OptionsColumn.ReadOnly = true;
            this.colKho.Visible = true;
            this.colKho.VisibleIndex = 2;
            this.colKho.Width = 250;
            // 
            // colSoHoaDon
            // 
            this.colSoHoaDon.Caption = "Số hóa đơn";
            this.colSoHoaDon.FieldName = "SoChungTuGoc";
            this.colSoHoaDon.Name = "colSoHoaDon";
            this.colSoHoaDon.OptionsColumn.AllowFocus = false;
            this.colSoHoaDon.OptionsColumn.AllowMove = false;
            this.colSoHoaDon.OptionsColumn.ReadOnly = true;
            this.colSoHoaDon.Visible = true;
            this.colSoHoaDon.VisibleIndex = 3;
            this.colSoHoaDon.Width = 141;
            // 
            // colSoPhieuDC
            // 
            this.colSoPhieuDC.Caption = "Số phiếu điều chuyển";
            this.colSoPhieuDC.FieldName = "SoChungTu";
            this.colSoPhieuDC.Name = "colSoPhieuDC";
            this.colSoPhieuDC.OptionsColumn.ReadOnly = true;
            this.colSoPhieuDC.Visible = true;
            this.colSoPhieuDC.VisibleIndex = 4;
            this.colSoPhieuDC.Width = 140;
            // 
            // colTenNhanVien
            // 
            this.colTenNhanVien.Caption = "Nhân viên xuất";
            this.colTenNhanVien.FieldName = "TenNhanVien";
            this.colTenNhanVien.Name = "colTenNhanVien";
            this.colTenNhanVien.OptionsColumn.AllowEdit = false;
            this.colTenNhanVien.Visible = true;
            this.colTenNhanVien.VisibleIndex = 5;
            this.colTenNhanVien.Width = 132;
            // 
            // colNhanVienGiao
            // 
            this.colNhanVienGiao.Caption = "Nhân viên giao";
            this.colNhanVienGiao.FieldName = "NhanVienGiao";
            this.colNhanVienGiao.Name = "colNhanVienGiao";
            this.colNhanVienGiao.OptionsColumn.ReadOnly = true;
            this.colNhanVienGiao.Visible = true;
            this.colNhanVienGiao.VisibleIndex = 6;
            this.colNhanVienGiao.Width = 124;
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
            // repDraft
            // 
            this.repDraft.AutoHeight = false;
            this.repDraft.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repDraft.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.repDraft.DisplayMember = "Name";
            this.repDraft.Name = "repDraft";
            this.repDraft.ValueMember = "Id";
            // 
            // repTrangThaiDH
            // 
            this.repTrangThaiDH.AutoHeight = false;
            this.repTrangThaiDH.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repTrangThaiDH.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.repTrangThaiDH.DisplayMember = "Name";
            this.repTrangThaiDH.Name = "repTrangThaiDH";
            this.repTrangThaiDH.ValueMember = "Id";
            // 
            // grpThucThi
            // 
            this.grpThucThi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThucThi.Controls.Add(this.btnDong);
            this.grpThucThi.Controls.Add(this.btnTim);
            this.grpThucThi.Controls.Add(this.btnCapNhat);
            this.grpThucThi.Location = new System.Drawing.Point(10, 107);
            this.grpThucThi.Name = "grpThucThi";
            this.grpThucThi.Size = new System.Drawing.Size(950, 50);
            this.grpThucThi.TabIndex = 1;
            this.grpThucThi.TabStop = false;
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(553, 16);
            this.btnDong.Name = "btnDong";
            this.btnDong.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnDong.Size = new System.Drawing.Size(91, 25);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng (F12)";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnTim
            // 
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.Location = new System.Drawing.Point(343, 16);
            this.btnTim.Name = "btnTim";
            this.btnTim.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnTim.Size = new System.Drawing.Size(101, 25);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "&Tìm kiếm (F3)";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.Location = new System.Drawing.Point(450, 16);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnCapNhat.Size = new System.Drawing.Size(97, 25);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Đồ&ng ý (F6)";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // frmBH_ChonPhieuDieuChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 532);
            this.Controls.Add(this.grpThucThi);
            this.Controls.Add(this.grpKetQuaTimKiem);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmBH_ChonPhieuDieuChuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm đơn hàng điều chuyển đến";
            this.Load += new System.EventHandler(this.frmBH_TimChungTu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBH_TimChungTu_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhoXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).EndInit();
            this.grpKetQuaTimKiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gListChungTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListChungTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDraft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrangThaiDH)).EndInit();
            this.grpThucThi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpKetQuaTimKiem;
        private System.Windows.Forms.GroupBox grpThucThi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        internal GtidButton btnCapNhat;
        internal GtidButton btnDong;
        private GtidButton btnTim;
        private GtidTextBox txtSoHoaDonDC;
        private GtidTextBox txtSanPham;
        private GtidTextBox txtNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.ButtonEdit bteTrungTam;
        private DevExpress.XtraEditors.ButtonEdit bteKhoXuat;
        private System.Windows.Forms.Label lblThuocXuat;
        private DevExpress.XtraEditors.DateEdit dteEnd;
        private DevExpress.XtraEditors.DateEdit dteStart;
        private DevExpress.XtraEditors.LabelControl lblEnd;
        private DevExpress.XtraEditors.LabelControl lblStart;
        private DevExpress.XtraGrid.GridControl gListChungTu;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn colTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn colKho;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLoaiDonHang;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayLap;
        private DevExpress.XtraGrid.Columns.GridColumn colSoHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhanVien;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repDraft;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repTrangThaiDH;
        private DevExpress.XtraGrid.Columns.GridColumn colSoPhieuDC;
        private GtidTextBox txtSoPhieuDC;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colNhanVienGiao;
    }
}