using QLBH.Core.Form;
namespace QLBanHang.Modules.BanHang
{
    partial class frmBH_TimChungTu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBH_TimChungTu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bteNganh = new DevExpress.XtraEditors.ButtonEdit();
            this.cmdExport = new QLBH.Core.Form.GtidButton();
            this.chkCuaToi = new System.Windows.Forms.CheckBox();
            this.btnDong = new QLBH.Core.Form.GtidButton();
            this.lueDraft = new DevExpress.XtraEditors.LookUpEdit();
            this.btnXoaDL = new QLBH.Core.Form.GtidButton();
            this.btnTim = new QLBH.Core.Form.GtidButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dteEnd = new DevExpress.XtraEditors.DateEdit();
            this.dteStart = new DevExpress.XtraEditors.DateEdit();
            this.lblEnd = new DevExpress.XtraEditors.LabelControl();
            this.lblStart = new DevExpress.XtraEditors.LabelControl();
            this.lueTrangThaiDH = new DevExpress.XtraEditors.LookUpEdit();
            this.lblTrangThaiDH = new DevExpress.XtraEditors.LabelControl();
            this.lueLoaiDH = new DevExpress.XtraEditors.LookUpEdit();
            this.lblTrangThaiLinhKien = new DevExpress.XtraEditors.LabelControl();
            this.cboLoaiMaHang = new System.Windows.Forms.ComboBox();
            this.bteKhachHang = new DevExpress.XtraEditors.ButtonEdit();
            this.bteKhoXuat = new DevExpress.XtraEditors.ButtonEdit();
            this.bteTrungTam = new DevExpress.XtraEditors.ButtonEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.cboGiaoNhan = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNhanVien = new QLBH.Core.Form.GtidTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGhiChu = new QLBH.Core.Form.GtidTextBox();
            this.txtCMND = new QLBH.Core.Form.GtidTextBox();
            this.txtDienThoai = new QLBH.Core.Form.GtidTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoGiaoDich = new QLBH.Core.Form.GtidTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSoThue = new QLBH.Core.Form.GtidTextBox();
            this.lblThuocXuat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTenKhachHang = new QLBH.Core.Form.GtidTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.grpKetQuaTimKiem = new System.Windows.Forms.GroupBox();
            this.gListChungTu = new DevExpress.XtraGrid.GridControl();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gvListChungTu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDoiTuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiDonHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLoaiDonHang = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colNgayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoGiaoDich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoChungTuGoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoPhieuDC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoPhieuXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTienThucTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTienCoNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaoNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colNgayGiaoHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoiGiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDraft = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colNguoiTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoiSua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTrangThaiDH = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslHuyClr = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslHuy = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTuChoiClr = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTuChoi = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteNganh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDraft.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTrangThaiDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLoaiDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhoXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).BeginInit();
            this.grpKetQuaTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gListChungTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListChungTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDraft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrangThaiDH)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bteNganh);
            this.groupBox1.Controls.Add(this.cmdExport);
            this.groupBox1.Controls.Add(this.chkCuaToi);
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Controls.Add(this.lueDraft);
            this.groupBox1.Controls.Add(this.btnXoaDL);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.dteEnd);
            this.groupBox1.Controls.Add(this.dteStart);
            this.groupBox1.Controls.Add(this.lblEnd);
            this.groupBox1.Controls.Add(this.lblStart);
            this.groupBox1.Controls.Add(this.lueTrangThaiDH);
            this.groupBox1.Controls.Add(this.lblTrangThaiDH);
            this.groupBox1.Controls.Add(this.lueLoaiDH);
            this.groupBox1.Controls.Add(this.lblTrangThaiLinhKien);
            this.groupBox1.Controls.Add(this.cboLoaiMaHang);
            this.groupBox1.Controls.Add(this.bteKhachHang);
            this.groupBox1.Controls.Add(this.bteKhoXuat);
            this.groupBox1.Controls.Add(this.bteTrungTam);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cboGiaoNhan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNhanVien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblGhiChu);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.txtDienThoai);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtSoGiaoDich);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaSoThue);
            this.groupBox1.Controls.Add(this.lblThuocXuat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtHoTenKhachHang);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.lblKhachHang);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // bteNganh
            // 
            this.bteNganh.Location = new System.Drawing.Point(203, 132);
            this.bteNganh.Name = "bteNganh";
            this.bteNganh.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.bteNganh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteNganh.Properties.Appearance.Options.UseBackColor = true;
            this.bteNganh.Properties.Appearance.Options.UseFont = true;
            this.bteNganh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteNganh.Size = new System.Drawing.Size(242, 21);
            this.bteNganh.TabIndex = 155;
            this.bteNganh.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteNganh_ButtonClick);
            this.bteNganh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteNganh_KeyDown);
            this.bteNganh.TextChanged += new System.EventHandler(this.bteNganh_TextChanged);
            // 
            // cmdExport
            // 
            this.cmdExport.Image = ((System.Drawing.Image)(resources.GetObject("cmdExport.Image")));
            this.cmdExport.Location = new System.Drawing.Point(892, 74);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdExport.Size = new System.Drawing.Size(101, 25);
            this.cmdExport.TabIndex = 20;
            this.cmdExport.Text = "&Export (F6)";
            this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // chkCuaToi
            // 
            this.chkCuaToi.AutoSize = true;
            this.chkCuaToi.Checked = true;
            this.chkCuaToi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCuaToi.Location = new System.Drawing.Point(892, 14);
            this.chkCuaToi.Name = "chkCuaToi";
            this.chkCuaToi.Size = new System.Drawing.Size(59, 17);
            this.chkCuaToi.TabIndex = 18;
            this.chkCuaToi.Text = "Của tôi";
            this.chkCuaToi.UseVisualStyleBackColor = true;
            this.chkCuaToi.Visible = false;
            // 
            // btnDong
            // 
            this.btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(892, 105);
            this.btnDong.Name = "btnDong";
            this.btnDong.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnDong.Size = new System.Drawing.Size(101, 25);
            this.btnDong.TabIndex = 21;
            this.btnDong.Text = "Đóng (F12)";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // lueDraft
            // 
            this.lueDraft.Location = new System.Drawing.Point(301, 35);
            this.lueDraft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lueDraft.Name = "lueDraft";
            this.lueDraft.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lueDraft.Properties.Appearance.Options.UseFont = true;
            this.lueDraft.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDraft.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.lueDraft.Properties.DisplayMember = "Name";
            this.lueDraft.Properties.NullText = "";
            this.lueDraft.Properties.ShowFooter = false;
            this.lueDraft.Properties.ShowHeader = false;
            this.lueDraft.Properties.ValueMember = "Id";
            this.lueDraft.Size = new System.Drawing.Size(144, 20);
            this.lueDraft.TabIndex = 3;
            // 
            // btnXoaDL
            // 
            this.btnXoaDL.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDL.Image")));
            this.btnXoaDL.Location = new System.Drawing.Point(892, 137);
            this.btnXoaDL.Name = "btnXoaDL";
            this.btnXoaDL.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnXoaDL.Size = new System.Drawing.Size(101, 25);
            this.btnXoaDL.TabIndex = 22;
            this.btnXoaDL.Text = "&Xóa DL (F8)";
            this.btnXoaDL.Visible = false;
            // 
            // btnTim
            // 
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.Location = new System.Drawing.Point(892, 42);
            this.btnTim.Name = "btnTim";
            this.btnTim.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnTim.Size = new System.Drawing.Size(101, 25);
            this.btnTim.TabIndex = 19;
            this.btnTim.Text = "&Tìm kiếm (F3)";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(251, 37);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 147;
            this.labelControl1.Text = "Xác nhận";
            // 
            // dteEnd
            // 
            this.dteEnd.EditValue = null;
            this.dteEnd.Location = new System.Drawing.Point(740, 12);
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
            this.dteStart.Location = new System.Drawing.Point(552, 12);
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
            this.dteStart.Size = new System.Drawing.Size(116, 20);
            this.dteStart.TabIndex = 10;
            // 
            // lblEnd
            // 
            this.lblEnd.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEnd.Appearance.Options.UseFont = true;
            this.lblEnd.Location = new System.Drawing.Point(691, 16);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(45, 13);
            this.lblEnd.TabIndex = 145;
            this.lblEnd.Text = "đến ngày";
            // 
            // lblStart
            // 
            this.lblStart.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStart.Appearance.Options.UseFont = true;
            this.lblStart.Location = new System.Drawing.Point(505, 16);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(40, 13);
            this.lblStart.TabIndex = 144;
            this.lblStart.Text = "Từ ngày";
            // 
            // lueTrangThaiDH
            // 
            this.lueTrangThaiDH.Location = new System.Drawing.Point(93, 58);
            this.lueTrangThaiDH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lueTrangThaiDH.Name = "lueTrangThaiDH";
            this.lueTrangThaiDH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lueTrangThaiDH.Properties.Appearance.Options.UseFont = true;
            this.lueTrangThaiDH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTrangThaiDH.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.lueTrangThaiDH.Properties.DisplayMember = "Name";
            this.lueTrangThaiDH.Properties.NullText = "";
            this.lueTrangThaiDH.Properties.ShowFooter = false;
            this.lueTrangThaiDH.Properties.ShowHeader = false;
            this.lueTrangThaiDH.Properties.ValueMember = "Id";
            this.lueTrangThaiDH.Size = new System.Drawing.Size(352, 20);
            this.lueTrangThaiDH.TabIndex = 4;
            // 
            // lblTrangThaiDH
            // 
            this.lblTrangThaiDH.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTrangThaiDH.Appearance.Options.UseFont = true;
            this.lblTrangThaiDH.Location = new System.Drawing.Point(20, 61);
            this.lblTrangThaiDH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTrangThaiDH.Name = "lblTrangThaiDH";
            this.lblTrangThaiDH.Size = new System.Drawing.Size(67, 13);
            this.lblTrangThaiDH.TabIndex = 141;
            this.lblTrangThaiDH.Text = "Trạng thái ĐH";
            // 
            // lueLoaiDH
            // 
            this.lueLoaiDH.Location = new System.Drawing.Point(301, 12);
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
            this.lueLoaiDH.Size = new System.Drawing.Size(144, 20);
            this.lueLoaiDH.TabIndex = 1;
            // 
            // lblTrangThaiLinhKien
            // 
            this.lblTrangThaiLinhKien.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTrangThaiLinhKien.Appearance.Options.UseFont = true;
            this.lblTrangThaiLinhKien.Location = new System.Drawing.Point(226, 15);
            this.lblTrangThaiLinhKien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTrangThaiLinhKien.Name = "lblTrangThaiLinhKien";
            this.lblTrangThaiLinhKien.Size = new System.Drawing.Size(67, 13);
            this.lblTrangThaiLinhKien.TabIndex = 139;
            this.lblTrangThaiLinhKien.Text = "Loại đơn hàng";
            // 
            // cboLoaiMaHang
            // 
            this.cboLoaiMaHang.AutoCompleteCustomSource.AddRange(new string[] {
            "Nhận hàng tại siêu thị",
            "Giao hàng tại nhà"});
            this.cboLoaiMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiMaHang.FormattingEnabled = true;
            this.cboLoaiMaHang.Items.AddRange(new object[] {
            "Lĩnh vực",
            "Ngành",
            "Loại",
            "Chủng",
            "Nhóm",
            "Model",
            "Sản phẩm"});
            this.cboLoaiMaHang.Location = new System.Drawing.Point(93, 132);
            this.cboLoaiMaHang.Name = "cboLoaiMaHang";
            this.cboLoaiMaHang.Size = new System.Drawing.Size(107, 21);
            this.cboLoaiMaHang.TabIndex = 7;
            // 
            // bteKhachHang
            // 
            this.bteKhachHang.Location = new System.Drawing.Point(552, 35);
            this.bteKhachHang.Name = "bteKhachHang";
            this.bteKhachHang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteKhachHang.Properties.Appearance.Options.UseFont = true;
            this.bteKhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteKhachHang.Size = new System.Drawing.Size(314, 22);
            this.bteKhachHang.TabIndex = 12;
            this.bteKhachHang.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteKhachHang_ButtonClick);
            this.bteKhachHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteKhachHang_KeyDown);
            this.bteKhachHang.TextChanged += new System.EventHandler(this.bteKhachHang_TextChanged);
            // 
            // bteKhoXuat
            // 
            this.bteKhoXuat.Location = new System.Drawing.Point(93, 107);
            this.bteKhoXuat.Name = "bteKhoXuat";
            this.bteKhoXuat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteKhoXuat.Properties.Appearance.Options.UseFont = true;
            this.bteKhoXuat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteKhoXuat.Size = new System.Drawing.Size(352, 22);
            this.bteKhoXuat.TabIndex = 6;
            this.bteKhoXuat.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteKhoXuat_ButtonClick);
            this.bteKhoXuat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteKhoXuat_KeyDown);
            this.bteKhoXuat.TextChanged += new System.EventHandler(this.bteKhoXuat_TextChanged);
            // 
            // bteTrungTam
            // 
            this.bteTrungTam.Location = new System.Drawing.Point(93, 82);
            this.bteTrungTam.Name = "bteTrungTam";
            this.bteTrungTam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteTrungTam.Properties.Appearance.Options.UseFont = true;
            this.bteTrungTam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteTrungTam.Size = new System.Drawing.Size(352, 22);
            this.bteTrungTam.TabIndex = 5;
            this.bteTrungTam.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteTrungTam_ButtonClick);
            this.bteTrungTam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteTrungTam_KeyDown);
            this.bteTrungTam.TextChanged += new System.EventHandler(this.bteTrungTam_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 121;
            this.label11.Text = "Giao nhận";
            // 
            // cboGiaoNhan
            // 
            this.cboGiaoNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboGiaoNhan.FormattingEnabled = true;
            this.cboGiaoNhan.Items.AddRange(new object[] {
            "Tất cả",
            "Nhận hàng tại siêu thị",
            "Giao nhận tại nhà khách"});
            this.cboGiaoNhan.Location = new System.Drawing.Point(93, 35);
            this.cboGiaoNhan.Name = "cboGiaoNhan";
            this.cboGiaoNhan.Size = new System.Drawing.Size(127, 21);
            this.cboGiaoNhan.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 118;
            this.label7.Text = "Trung tâm";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanVien.Location = new System.Drawing.Point(93, 156);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(352, 20);
            this.txtNhanVien.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 115;
            this.label5.Text = "Nhân viên";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGhiChu.Location = new System.Drawing.Point(489, 139);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(56, 15);
            this.lblGhiChu.TabIndex = 113;
            this.lblGhiChu.Text = "Diễn giải";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(501, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 111;
            this.label10.Text = "CMND";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(552, 134);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGhiChu.Size = new System.Drawing.Size(314, 42);
            this.txtGhiChu.TabIndex = 17;
            // 
            // txtCMND
            // 
            this.txtCMND.BackColor = System.Drawing.SystemColors.Window;
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(552, 109);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(116, 20);
            this.txtCMND.TabIndex = 15;
            this.txtCMND.Text = " ";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDienThoai.Location = new System.Drawing.Point(740, 109);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(126, 20);
            this.txtDienThoai.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(673, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 108;
            this.label8.Text = "Điện thoại";
            // 
            // txtSoGiaoDich
            // 
            this.txtSoGiaoDich.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoGiaoDich.Location = new System.Drawing.Point(93, 12);
            this.txtSoGiaoDich.Name = "txtSoGiaoDich";
            this.txtSoGiaoDich.Size = new System.Drawing.Size(127, 20);
            this.txtSoGiaoDich.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "Số phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(485, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 95;
            this.label2.Text = "Mã số thuế";
            // 
            // txtMaSoThue
            // 
            this.txtMaSoThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSoThue.Location = new System.Drawing.Point(552, 84);
            this.txtMaSoThue.Name = "txtMaSoThue";
            this.txtMaSoThue.Size = new System.Drawing.Size(314, 20);
            this.txtMaSoThue.TabIndex = 14;
            // 
            // lblThuocXuat
            // 
            this.lblThuocXuat.AutoSize = true;
            this.lblThuocXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuocXuat.Location = new System.Drawing.Point(32, 135);
            this.lblThuocXuat.Name = "lblThuocXuat";
            this.lblThuocXuat.Size = new System.Drawing.Size(55, 13);
            this.lblThuocXuat.TabIndex = 0;
            this.lblThuocXuat.Text = "Sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(506, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = "Họ tên";
            // 
            // txtHoTenKhachHang
            // 
            this.txtHoTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenKhachHang.Location = new System.Drawing.Point(552, 60);
            this.txtHoTenKhachHang.Name = "txtHoTenKhachHang";
            this.txtHoTenKhachHang.Size = new System.Drawing.Size(314, 20);
            this.txtHoTenKhachHang.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(38, 111);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 91;
            this.label17.Text = "Kho xuất";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHang.Location = new System.Drawing.Point(480, 38);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(65, 13);
            this.lblKhachHang.TabIndex = 0;
            this.lblKhachHang.Text = "Khách hàng";
            // 
            // grpKetQuaTimKiem
            // 
            this.grpKetQuaTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKetQuaTimKiem.Controls.Add(this.gListChungTu);
            this.grpKetQuaTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKetQuaTimKiem.ForeColor = System.Drawing.Color.Black;
            this.grpKetQuaTimKiem.Location = new System.Drawing.Point(1, 196);
            this.grpKetQuaTimKiem.Name = "grpKetQuaTimKiem";
            this.grpKetQuaTimKiem.Size = new System.Drawing.Size(1018, 311);
            this.grpKetQuaTimKiem.TabIndex = 1;
            this.grpKetQuaTimKiem.TabStop = false;
            this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm";
            // 
            // gListChungTu
            // 
            this.gListChungTu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gListChungTu.ContextMenuStrip = this.ctxMenu;
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
            this.gListChungTu.Size = new System.Drawing.Size(1006, 286);
            this.gListChungTu.TabIndex = 0;
            this.gListChungTu.UseEmbeddedNavigator = true;
            this.gListChungTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListChungTu});
            // 
            // ctxMenu
            // 
            this.ctxMenu.Name = "contextMenuStrip1";
            this.ctxMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // gvListChungTu
            // 
            this.gvListChungTu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTrungTam,
            this.colTenDoiTuong,
            this.colKho,
            this.colLoaiDonHang,
            this.colNgayLap,
            this.colSoGiaoDich,
            this.colSoChungTuGoc,
            this.colSoHoaDon,
            this.NgayHoaDon,
            this.colSoPhieuDC,
            this.colSoPhieuXuat,
            this.colNgayXuat,
            this.colTenNhanVien,
            this.colSoTien,
            this.colTienThucTra,
            this.colTienCoNo,
            this.colGiaoNhan,
            this.colNgayGiaoHang,
            this.colNoiGiao,
            this.colGhiChu,
            this.colNguoiTao,
            this.colNguoiSua,
            this.colTrangThai});
            this.gvListChungTu.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvListChungTu.GridControl = this.gListChungTu;
            this.gvListChungTu.GroupCount = 2;
            this.gvListChungTu.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "SoChungTu", null, "  (Tổng số  = {0})")});
            this.gvListChungTu.Name = "gvListChungTu";
            this.gvListChungTu.OptionsView.ColumnAutoWidth = false;
            this.gvListChungTu.OptionsView.ShowAutoFilterRow = true;
            this.gvListChungTu.OptionsView.ShowDetailButtons = false;
            this.gvListChungTu.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTrungTam, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTenDoiTuong, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colKho, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvListChungTu.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvListChungTu_FocusedRowChanged);
            this.gvListChungTu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvListChungTu_KeyDown);
            this.gvListChungTu.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvListChungTu_RowCellStyle);
            this.gvListChungTu.DoubleClick += new System.EventHandler(this.gvListChungTu_DoubleClick);
            // 
            // colTrungTam
            // 
            this.colTrungTam.Caption = "Trung tâm";
            this.colTrungTam.FieldName = "TenTrungTam";
            this.colTrungTam.Name = "colTrungTam";
            this.colTrungTam.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTrungTam.OptionsColumn.ReadOnly = true;
            // 
            // colTenDoiTuong
            // 
            this.colTenDoiTuong.Caption = "Khách hàng";
            this.colTenDoiTuong.FieldName = "TenDoiTuong";
            this.colTenDoiTuong.Name = "colTenDoiTuong";
            this.colTenDoiTuong.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTenDoiTuong.OptionsColumn.ReadOnly = true;
            // 
            // colKho
            // 
            this.colKho.AppearanceCell.Options.UseTextOptions = true;
            this.colKho.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colKho.Caption = "Kho hàng";
            this.colKho.FieldName = "TenKho";
            this.colKho.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colKho.Name = "colKho";
            this.colKho.OptionsColumn.AllowEdit = false;
            this.colKho.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colKho.OptionsColumn.ReadOnly = true;
            this.colKho.Visible = true;
            this.colKho.VisibleIndex = 0;
            this.colKho.Width = 237;
            // 
            // colLoaiDonHang
            // 
            this.colLoaiDonHang.Caption = "Loại đơn hàng";
            this.colLoaiDonHang.ColumnEdit = this.repLoaiDonHang;
            this.colLoaiDonHang.FieldName = "LoaiChungTu";
            this.colLoaiDonHang.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colLoaiDonHang.Name = "colLoaiDonHang";
            this.colLoaiDonHang.OptionsColumn.AllowEdit = false;
            this.colLoaiDonHang.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colLoaiDonHang.OptionsColumn.ReadOnly = true;
            this.colLoaiDonHang.Visible = true;
            this.colLoaiDonHang.VisibleIndex = 1;
            this.colLoaiDonHang.Width = 154;
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
            // colNgayLap
            // 
            this.colNgayLap.Caption = "Ngày lập";
            this.colNgayLap.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colNgayLap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayLap.FieldName = "NgayLap";
            this.colNgayLap.Name = "colNgayLap";
            this.colNgayLap.OptionsColumn.AllowEdit = false;
            this.colNgayLap.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNgayLap.OptionsColumn.ReadOnly = true;
            this.colNgayLap.Visible = true;
            this.colNgayLap.VisibleIndex = 2;
            this.colNgayLap.Width = 113;
            // 
            // colSoGiaoDich
            // 
            this.colSoGiaoDich.Caption = "Số giao dịch";
            this.colSoGiaoDich.FieldName = "SoChungTu";
            this.colSoGiaoDich.Name = "colSoGiaoDich";
            this.colSoGiaoDich.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSoGiaoDich.OptionsColumn.ReadOnly = true;
            this.colSoGiaoDich.Visible = true;
            this.colSoGiaoDich.VisibleIndex = 3;
            this.colSoGiaoDich.Width = 149;
            // 
            // colSoChungTuGoc
            // 
            this.colSoChungTuGoc.Caption = "Số chứng từ gốc";
            this.colSoChungTuGoc.FieldName = "SoChungTuGoc";
            this.colSoChungTuGoc.Name = "colSoChungTuGoc";
            this.colSoChungTuGoc.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSoChungTuGoc.OptionsColumn.ReadOnly = true;
            this.colSoChungTuGoc.Visible = true;
            this.colSoChungTuGoc.VisibleIndex = 4;
            this.colSoChungTuGoc.Width = 127;
            // 
            // colSoHoaDon
            // 
            this.colSoHoaDon.Caption = "Số hóa đơn";
            this.colSoHoaDon.FieldName = "SoSeri";
            this.colSoHoaDon.Name = "colSoHoaDon";
            this.colSoHoaDon.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSoHoaDon.OptionsColumn.ReadOnly = true;
            this.colSoHoaDon.Visible = true;
            this.colSoHoaDon.VisibleIndex = 5;
            this.colSoHoaDon.Width = 121;
            // 
            // NgayHoaDon
            // 
            this.NgayHoaDon.Caption = "Ngày hóa đơn";
            this.NgayHoaDon.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.NgayHoaDon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgayHoaDon.FieldName = "NgayHoaDon";
            this.NgayHoaDon.Name = "NgayHoaDon";
            this.NgayHoaDon.OptionsColumn.AllowEdit = false;
            this.NgayHoaDon.Visible = true;
            this.NgayHoaDon.VisibleIndex = 6;
            this.NgayHoaDon.Width = 116;
            // 
            // colSoPhieuDC
            // 
            this.colSoPhieuDC.Caption = "Số phiếu điều chuyển";
            this.colSoPhieuDC.FieldName = "SoPhieuDC";
            this.colSoPhieuDC.Name = "colSoPhieuDC";
            this.colSoPhieuDC.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSoPhieuDC.OptionsColumn.ReadOnly = true;
            this.colSoPhieuDC.Visible = true;
            this.colSoPhieuDC.VisibleIndex = 7;
            this.colSoPhieuDC.Width = 142;
            // 
            // colSoPhieuXuat
            // 
            this.colSoPhieuXuat.Caption = "Số phiếu xuất";
            this.colSoPhieuXuat.DisplayFormat.FormatString = "dd/mm/yyyy";
            this.colSoPhieuXuat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSoPhieuXuat.FieldName = "SoPhieuXuat";
            this.colSoPhieuXuat.Name = "colSoPhieuXuat";
            this.colSoPhieuXuat.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSoPhieuXuat.OptionsColumn.ReadOnly = true;
            this.colSoPhieuXuat.Width = 120;
            // 
            // colNgayXuat
            // 
            this.colNgayXuat.Caption = "Ngày xuất";
            this.colNgayXuat.FieldName = "NgayXuatHang";
            this.colNgayXuat.Name = "colNgayXuat";
            this.colNgayXuat.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNgayXuat.OptionsColumn.ReadOnly = true;
            this.colNgayXuat.Width = 94;
            // 
            // colTenNhanVien
            // 
            this.colTenNhanVien.Caption = "Thương viên";
            this.colTenNhanVien.FieldName = "TenNhanVien";
            this.colTenNhanVien.Name = "colTenNhanVien";
            this.colTenNhanVien.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTenNhanVien.OptionsColumn.ReadOnly = true;
            this.colTenNhanVien.Visible = true;
            this.colTenNhanVien.VisibleIndex = 15;
            this.colTenNhanVien.Width = 143;
            // 
            // colSoTien
            // 
            this.colSoTien.Caption = "Số tiền";
            this.colSoTien.DisplayFormat.FormatString = "N0";
            this.colSoTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoTien.FieldName = "TongTienThanhToan";
            this.colSoTien.Name = "colSoTien";
            this.colSoTien.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSoTien.OptionsColumn.ReadOnly = true;
            this.colSoTien.Visible = true;
            this.colSoTien.VisibleIndex = 9;
            this.colSoTien.Width = 79;
            // 
            // colTienThucTra
            // 
            this.colTienThucTra.Caption = "Đã trả";
            this.colTienThucTra.DisplayFormat.FormatString = "N0";
            this.colTienThucTra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTienThucTra.FieldName = "TienThanhToanThuc";
            this.colTienThucTra.Name = "colTienThucTra";
            this.colTienThucTra.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTienThucTra.OptionsColumn.ReadOnly = true;
            this.colTienThucTra.Visible = true;
            this.colTienThucTra.VisibleIndex = 10;
            this.colTienThucTra.Width = 82;
            // 
            // colTienCoNo
            // 
            this.colTienCoNo.Caption = "Còn nợ";
            this.colTienCoNo.DisplayFormat.FormatString = "N0";
            this.colTienCoNo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTienCoNo.FieldName = "TienConNo";
            this.colTienCoNo.Name = "colTienCoNo";
            this.colTienCoNo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTienCoNo.OptionsColumn.ReadOnly = true;
            this.colTienCoNo.Visible = true;
            this.colTienCoNo.VisibleIndex = 11;
            this.colTienCoNo.Width = 87;
            // 
            // colGiaoNhan
            // 
            this.colGiaoNhan.Caption = "Giao nhận";
            this.colGiaoNhan.ColumnEdit = this.repEdit;
            this.colGiaoNhan.FieldName = "GiaoNhan";
            this.colGiaoNhan.Name = "colGiaoNhan";
            this.colGiaoNhan.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colGiaoNhan.OptionsColumn.ReadOnly = true;
            this.colGiaoNhan.Visible = true;
            this.colGiaoNhan.VisibleIndex = 12;
            // 
            // repEdit
            // 
            this.repEdit.AutoHeight = false;
            this.repEdit.Name = "repEdit";
            this.repEdit.ValueChecked = 1;
            this.repEdit.ValueUnchecked = 0;
            // 
            // colNgayGiaoHang
            // 
            this.colNgayGiaoHang.Caption = "Ngày hẹn giao hàng";
            this.colNgayGiaoHang.FieldName = "NgayHenGiaoHang";
            this.colNgayGiaoHang.Name = "colNgayGiaoHang";
            this.colNgayGiaoHang.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNgayGiaoHang.OptionsColumn.ReadOnly = true;
            this.colNgayGiaoHang.Visible = true;
            this.colNgayGiaoHang.VisibleIndex = 13;
            this.colNgayGiaoHang.Width = 163;
            // 
            // colNoiGiao
            // 
            this.colNoiGiao.Caption = "Địa chỉ giao hàng";
            this.colNoiGiao.FieldName = "DiaChiGiaoHang";
            this.colNoiGiao.Name = "colNoiGiao";
            this.colNoiGiao.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNoiGiao.OptionsColumn.ReadOnly = true;
            this.colNoiGiao.Visible = true;
            this.colNoiGiao.VisibleIndex = 14;
            this.colNoiGiao.Width = 222;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi chú";
            this.colGhiChu.ColumnEdit = this.repDraft;
            this.colGhiChu.FieldName = "Draft";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colGhiChu.OptionsColumn.ReadOnly = true;
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 8;
            this.colGhiChu.Width = 141;
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
            // colNguoiTao
            // 
            this.colNguoiTao.Caption = "Người tạo";
            this.colNguoiTao.FieldName = "NguoiTao";
            this.colNguoiTao.Name = "colNguoiTao";
            this.colNguoiTao.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNguoiTao.OptionsColumn.ReadOnly = true;
            this.colNguoiTao.Visible = true;
            this.colNguoiTao.VisibleIndex = 16;
            this.colNguoiTao.Width = 92;
            // 
            // colNguoiSua
            // 
            this.colNguoiSua.Caption = "Người cập nhật";
            this.colNguoiSua.FieldName = "NguoiSua";
            this.colNguoiSua.Name = "colNguoiSua";
            this.colNguoiSua.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNguoiSua.OptionsColumn.ReadOnly = true;
            this.colNguoiSua.Visible = true;
            this.colNguoiSua.VisibleIndex = 17;
            this.colNguoiSua.Width = 103;
            // 
            // colTrangThai
            // 
            this.colTrangThai.AppearanceCell.Options.UseTextOptions = true;
            this.colTrangThai.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTrangThai.Caption = "Trạng thái đơn hàng";
            this.colTrangThai.ColumnEdit = this.repTrangThaiDH;
            this.colTrangThai.FieldName = "TrangThai";
            this.colTrangThai.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTrangThai.OptionsColumn.ReadOnly = true;
            this.colTrangThai.Visible = true;
            this.colTrangThai.VisibleIndex = 18;
            this.colTrangThai.Width = 144;
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
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslHuyClr,
            this.tsslHuy,
            this.tsslTuChoiClr,
            this.tsslTuChoi,
            this.toolStripStatusLabel7,
            this.tsslTrangThai});
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(1021, 22);
            this.statusStrip1.TabIndex = 108;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslHuyClr
            // 
            this.tsslHuyClr.BackColor = System.Drawing.Color.Red;
            this.tsslHuyClr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tsslHuyClr.Name = "tsslHuyClr";
            this.tsslHuyClr.Size = new System.Drawing.Size(24, 17);
            this.tsslHuyClr.Text = "    ";
            // 
            // tsslHuy
            // 
            this.tsslHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tsslHuy.Name = "tsslHuy";
            this.tsslHuy.Size = new System.Drawing.Size(70, 17);
            this.tsslHuy.Text = "Hủy / Khóa";
            // 
            // tsslTuChoiClr
            // 
            this.tsslTuChoiClr.BackColor = System.Drawing.Color.Yellow;
            this.tsslTuChoiClr.Name = "tsslTuChoiClr";
            this.tsslTuChoiClr.Size = new System.Drawing.Size(24, 17);
            this.tsslTuChoiClr.Text = "    ";
            // 
            // tsslTuChoi
            // 
            this.tsslTuChoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tsslTuChoi.Name = "tsslTuChoi";
            this.tsslTuChoi.Size = new System.Drawing.Size(51, 17);
            this.tsslTuChoi.Text = "Từ chối";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(24, 17);
            this.toolStripStatusLabel7.Text = "    ";
            // 
            // tsslTrangThai
            // 
            this.tsslTrangThai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tsslTrangThai.Name = "tsslTrangThai";
            this.tsslTrangThai.Size = new System.Drawing.Size(124, 17);
            this.tsslTrangThai.Text = "Danh sách đơn hàng";
            // 
            // frmBH_TimChungTu
            // 
            this.AcceptButton = this.cmdExport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDong;
            this.ClientSize = new System.Drawing.Size(1021, 532);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpKetQuaTimKiem);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmBH_TimChungTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm đơn hàng bán";
            this.Load += new System.EventHandler(this.frmBH_TimChungTu_Load);
            this.Activated += new System.EventHandler(this.frmBH_TimChungTu_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBH_TimChungTu_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteNganh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDraft.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTrangThaiDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLoaiDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhoXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).EndInit();
            this.grpKetQuaTimKiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gListChungTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListChungTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDraft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrangThaiDH)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpKetQuaTimKiem;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblGhiChu;
        internal GtidButton btnXoaDL;
        internal GtidButton btnDong;
        private GtidButton btnTim;
        private GtidTextBox txtMaSoThue;
        private GtidTextBox txtHoTenKhachHang;
        private GtidTextBox txtSoGiaoDich;
        private GtidTextBox txtDienThoai;
        private GtidTextBox txtCMND;
        private GtidTextBox txtGhiChu;
        private GtidTextBox txtNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboGiaoNhan;
        private DevExpress.XtraEditors.ButtonEdit bteTrungTam;
        private DevExpress.XtraEditors.ButtonEdit bteKhoXuat;
        private DevExpress.XtraEditors.ButtonEdit bteKhachHang;
        private System.Windows.Forms.Label lblThuocXuat;
        private System.Windows.Forms.ComboBox cboLoaiMaHang;
        private DevExpress.XtraEditors.LookUpEdit lueLoaiDH;
        private DevExpress.XtraEditors.LabelControl lblTrangThaiLinhKien;
        private DevExpress.XtraEditors.LookUpEdit lueTrangThaiDH;
        private DevExpress.XtraEditors.LabelControl lblTrangThaiDH;
        private DevExpress.XtraEditors.DateEdit dteEnd;
        private DevExpress.XtraEditors.DateEdit dteStart;
        private DevExpress.XtraEditors.LabelControl lblEnd;
        private DevExpress.XtraEditors.LabelControl lblStart;
        private DevExpress.XtraEditors.LookUpEdit lueDraft;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gListChungTu;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn colTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDoiTuong;
        private DevExpress.XtraGrid.Columns.GridColumn colKho;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiDonHang;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLoaiDonHang;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayLap;
        private DevExpress.XtraGrid.Columns.GridColumn colSoGiaoDich;
        private DevExpress.XtraGrid.Columns.GridColumn colSoHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn colSoPhieuXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTien;
        private DevExpress.XtraGrid.Columns.GridColumn colTienThucTra;
        private DevExpress.XtraGrid.Columns.GridColumn colTienCoNo;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaoNhan;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayGiaoHang;
        private DevExpress.XtraGrid.Columns.GridColumn colNoiGiao;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repDraft;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThai;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repTrangThaiDH;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.CheckBox chkCuaToi;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoiTao;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoiSua;
        private GtidButton cmdExport;
        private DevExpress.XtraGrid.Columns.GridColumn colSoChungTuGoc;
        private DevExpress.XtraGrid.Columns.GridColumn colSoPhieuDC;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel tsslHuyClr;
        public System.Windows.Forms.ToolStripStatusLabel tsslHuy;
        public System.Windows.Forms.ToolStripStatusLabel tsslTuChoiClr;
        public System.Windows.Forms.ToolStripStatusLabel tsslTuChoi;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel tsslTrangThai;
        protected DevExpress.XtraEditors.ButtonEdit bteNganh;
        private DevExpress.XtraGrid.Columns.GridColumn NgayHoaDon;
    }
}