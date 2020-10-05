using QLBH.Core.Form;
namespace QLBanHang.Modules.BanHang
{
    partial class frmBH_TimKhachMuaHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBH_TimKhachMuaHang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdExport = new QLBH.Core.Form.GtidButton();
            this.btnDong = new QLBH.Core.Form.GtidButton();
            this.btnTim = new QLBH.Core.Form.GtidButton();
            this.dteEnd = new DevExpress.XtraEditors.DateEdit();
            this.dteStart = new DevExpress.XtraEditors.DateEdit();
            this.lblEnd = new DevExpress.XtraEditors.LabelControl();
            this.lblStart = new DevExpress.XtraEditors.LabelControl();
            this.bteKhoXuat = new DevExpress.XtraEditors.ButtonEdit();
            this.bteTrungTam = new DevExpress.XtraEditors.ButtonEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNhanVien = new QLBH.Core.Form.GtidTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaSoThue = new QLBH.Core.Form.GtidTextBox();
            this.txtCMND = new QLBH.Core.Form.GtidTextBox();
            this.txtDienThoai = new QLBH.Core.Form.GtidTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoGiaoDich = new QLBH.Core.Form.GtidTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTenKhachHang = new QLBH.Core.Form.GtidTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.grpKetQuaTimKiem = new System.Windows.Forms.GroupBox();
            this.gListChungTu = new DevExpress.XtraGrid.GridControl();
            this.gvListChungTu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDoiTuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoGiaoDich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoPhieuXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoiGiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDraft = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repLoaiDonHang = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repTrangThaiDH = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
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
            ((System.ComponentModel.ISupportInitialize)(this.repDraft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrangThaiDH)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmdExport);
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.dteEnd);
            this.groupBox1.Controls.Add(this.dteStart);
            this.groupBox1.Controls.Add(this.lblEnd);
            this.groupBox1.Controls.Add(this.lblStart);
            this.groupBox1.Controls.Add(this.bteKhoXuat);
            this.groupBox1.Controls.Add(this.bteTrungTam);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNhanVien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblGhiChu);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtMaSoThue);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.txtDienThoai);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtSoGiaoDich);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtHoTenKhachHang);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmdExport
            // 
            this.cmdExport.Image = ((System.Drawing.Image)(resources.GetObject("cmdExport.Image")));
            this.cmdExport.Location = new System.Drawing.Point(895, 49);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdExport.Size = new System.Drawing.Size(101, 25);
            this.cmdExport.TabIndex = 20;
            this.cmdExport.Text = "&Chấp nhận (F6)";
            this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // btnDong
            // 
            this.btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(895, 80);
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
            this.btnTim.Location = new System.Drawing.Point(895, 17);
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
            this.lblStart.Location = new System.Drawing.Point(507, 16);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(40, 13);
            this.lblStart.TabIndex = 144;
            this.lblStart.Text = "Từ ngày";
            // 
            // bteKhoXuat
            // 
            this.bteKhoXuat.Location = new System.Drawing.Point(93, 66);
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
            this.bteTrungTam.Location = new System.Drawing.Point(93, 38);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 118;
            this.label7.Text = "Trung tâm";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanVien.Location = new System.Drawing.Point(93, 94);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(352, 20);
            this.txtNhanVien.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 115;
            this.label5.Text = "Nhân viên";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGhiChu.Location = new System.Drawing.Point(479, 92);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(68, 15);
            this.lblGhiChu.TabIndex = 113;
            this.lblGhiChu.Text = "Mã số thuế";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(503, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 111;
            this.label10.Text = "CMND";
            // 
            // txtMaSoThue
            // 
            this.txtMaSoThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSoThue.Location = new System.Drawing.Point(552, 90);
            this.txtMaSoThue.Name = "txtMaSoThue";
            this.txtMaSoThue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMaSoThue.Size = new System.Drawing.Size(314, 20);
            this.txtMaSoThue.TabIndex = 17;
            // 
            // txtCMND
            // 
            this.txtCMND.BackColor = System.Drawing.SystemColors.Window;
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(552, 64);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(116, 20);
            this.txtCMND.TabIndex = 15;
            this.txtCMND.Text = " ";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDienThoai.Location = new System.Drawing.Point(740, 64);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(126, 20);
            this.txtDienThoai.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(673, 67);
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
            this.txtSoGiaoDich.Size = new System.Drawing.Size(352, 20);
            this.txtSoGiaoDich.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "Số phiếu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(508, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = "Họ tên";
            // 
            // txtHoTenKhachHang
            // 
            this.txtHoTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenKhachHang.Location = new System.Drawing.Point(552, 38);
            this.txtHoTenKhachHang.Name = "txtHoTenKhachHang";
            this.txtHoTenKhachHang.Size = new System.Drawing.Size(314, 20);
            this.txtHoTenKhachHang.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(39, 70);
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
            this.grpKetQuaTimKiem.Location = new System.Drawing.Point(1, 132);
            this.grpKetQuaTimKiem.Name = "grpKetQuaTimKiem";
            this.grpKetQuaTimKiem.Size = new System.Drawing.Size(1018, 375);
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
            this.gListChungTu.EmbeddedNavigator.TextStringFormat = "Đơn hàng số {0} / Tổng số {1} đơn hàng";
            this.gListChungTu.Location = new System.Drawing.Point(6, 19);
            this.gListChungTu.MainView = this.gvListChungTu;
            this.gListChungTu.Name = "gListChungTu";
            this.gListChungTu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repEdit,
            this.repLoaiDonHang,
            this.repDraft,
            this.repTrangThaiDH});
            this.gListChungTu.Size = new System.Drawing.Size(1006, 350);
            this.gListChungTu.TabIndex = 0;
            this.gListChungTu.UseEmbeddedNavigator = true;
            this.gListChungTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListChungTu});
            // 
            // gvListChungTu
            // 
            this.gvListChungTu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTrungTam,
            this.colTenDoiTuong,
            this.CMND,
            this.DienThoai,
            this.colKho,
            this.colNgayLap,
            this.colSoGiaoDich,
            this.colSoHoaDon,
            this.colSoPhieuXuat,
            this.colNgayXuat,
            this.colTenNhanVien,
            this.colSoTien,
            this.colNoiGiao,
            this.colGhiChu});
            this.gvListChungTu.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvListChungTu.GridControl = this.gListChungTu;
            this.gvListChungTu.GroupCount = 1;
            this.gvListChungTu.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "SoChungTu", null, "  (Tổng số  = {0})")});
            this.gvListChungTu.Name = "gvListChungTu";
            this.gvListChungTu.OptionsView.ColumnAutoWidth = false;
            this.gvListChungTu.OptionsView.ShowAutoFilterRow = true;
            this.gvListChungTu.OptionsView.ShowDetailButtons = false;
            this.gvListChungTu.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTrungTam, DevExpress.Data.ColumnSortOrder.Ascending)});
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
            this.colTrungTam.OptionsColumn.AllowEdit = false;
            this.colTrungTam.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTrungTam.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colTrungTam.OptionsColumn.ReadOnly = true;
            // 
            // colTenDoiTuong
            // 
            this.colTenDoiTuong.Caption = "Khách hàng";
            this.colTenDoiTuong.FieldName = "TenDoiTuong";
            this.colTenDoiTuong.Name = "colTenDoiTuong";
            this.colTenDoiTuong.OptionsColumn.AllowEdit = false;
            this.colTenDoiTuong.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTenDoiTuong.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colTenDoiTuong.OptionsColumn.ReadOnly = true;
            this.colTenDoiTuong.Visible = true;
            this.colTenDoiTuong.VisibleIndex = 0;
            this.colTenDoiTuong.Width = 245;
            // 
            // CMND
            // 
            this.CMND.Caption = "CMND";
            this.CMND.FieldName = "CMND";
            this.CMND.Name = "CMND";
            this.CMND.OptionsColumn.AllowEdit = false;
            this.CMND.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.CMND.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.CMND.OptionsColumn.ReadOnly = true;
            this.CMND.Visible = true;
            this.CMND.VisibleIndex = 1;
            this.CMND.Width = 119;
            // 
            // DienThoai
            // 
            this.DienThoai.Caption = "Điện thoại";
            this.DienThoai.FieldName = "DienThoai";
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.OptionsColumn.AllowEdit = false;
            this.DienThoai.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.DienThoai.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.DienThoai.OptionsColumn.ReadOnly = true;
            this.DienThoai.Visible = true;
            this.DienThoai.VisibleIndex = 2;
            this.DienThoai.Width = 128;
            // 
            // colKho
            // 
            this.colKho.AppearanceCell.Options.UseTextOptions = true;
            this.colKho.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colKho.Caption = "Kho hàng";
            this.colKho.FieldName = "TenKho";
            this.colKho.Name = "colKho";
            this.colKho.OptionsColumn.AllowEdit = false;
            this.colKho.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colKho.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colKho.OptionsColumn.ReadOnly = true;
            this.colKho.Visible = true;
            this.colKho.VisibleIndex = 3;
            this.colKho.Width = 228;
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
            this.colNgayLap.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colNgayLap.OptionsColumn.ReadOnly = true;
            this.colNgayLap.Visible = true;
            this.colNgayLap.VisibleIndex = 4;
            this.colNgayLap.Width = 113;
            // 
            // colSoGiaoDich
            // 
            this.colSoGiaoDich.Caption = "Số giao dịch";
            this.colSoGiaoDich.FieldName = "SoChungTu";
            this.colSoGiaoDich.Name = "colSoGiaoDich";
            this.colSoGiaoDich.OptionsColumn.AllowEdit = false;
            this.colSoGiaoDich.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSoGiaoDich.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colSoGiaoDich.OptionsColumn.ReadOnly = true;
            this.colSoGiaoDich.Visible = true;
            this.colSoGiaoDich.VisibleIndex = 5;
            this.colSoGiaoDich.Width = 149;
            // 
            // colSoHoaDon
            // 
            this.colSoHoaDon.Caption = "Số hóa đơn";
            this.colSoHoaDon.FieldName = "SoSeri";
            this.colSoHoaDon.Name = "colSoHoaDon";
            this.colSoHoaDon.OptionsColumn.AllowEdit = false;
            this.colSoHoaDon.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSoHoaDon.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colSoHoaDon.OptionsColumn.ReadOnly = true;
            this.colSoHoaDon.Visible = true;
            this.colSoHoaDon.VisibleIndex = 6;
            this.colSoHoaDon.Width = 121;
            // 
            // colSoPhieuXuat
            // 
            this.colSoPhieuXuat.Caption = "Số phiếu xuất";
            this.colSoPhieuXuat.DisplayFormat.FormatString = "dd/mm/yyyy";
            this.colSoPhieuXuat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSoPhieuXuat.FieldName = "SoPhieuXuat";
            this.colSoPhieuXuat.Name = "colSoPhieuXuat";
            this.colSoPhieuXuat.OptionsColumn.AllowEdit = false;
            this.colSoPhieuXuat.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSoPhieuXuat.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colSoPhieuXuat.OptionsColumn.ReadOnly = true;
            this.colSoPhieuXuat.Width = 120;
            // 
            // colNgayXuat
            // 
            this.colNgayXuat.Caption = "Ngày xuất";
            this.colNgayXuat.FieldName = "NgayXuatHang";
            this.colNgayXuat.Name = "colNgayXuat";
            this.colNgayXuat.OptionsColumn.AllowEdit = false;
            this.colNgayXuat.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNgayXuat.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colNgayXuat.OptionsColumn.ReadOnly = true;
            this.colNgayXuat.Width = 94;
            // 
            // colTenNhanVien
            // 
            this.colTenNhanVien.Caption = "Thương viên";
            this.colTenNhanVien.FieldName = "TenNhanVien";
            this.colTenNhanVien.Name = "colTenNhanVien";
            this.colTenNhanVien.OptionsColumn.AllowEdit = false;
            this.colTenNhanVien.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTenNhanVien.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colTenNhanVien.OptionsColumn.ReadOnly = true;
            this.colTenNhanVien.Visible = true;
            this.colTenNhanVien.VisibleIndex = 10;
            this.colTenNhanVien.Width = 143;
            // 
            // colSoTien
            // 
            this.colSoTien.Caption = "Số tiền";
            this.colSoTien.DisplayFormat.FormatString = "N0";
            this.colSoTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoTien.FieldName = "TongTienThanhToan";
            this.colSoTien.Name = "colSoTien";
            this.colSoTien.OptionsColumn.AllowEdit = false;
            this.colSoTien.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSoTien.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colSoTien.OptionsColumn.ReadOnly = true;
            this.colSoTien.Visible = true;
            this.colSoTien.VisibleIndex = 8;
            this.colSoTien.Width = 79;
            // 
            // colNoiGiao
            // 
            this.colNoiGiao.Caption = "Địa chỉ giao hàng";
            this.colNoiGiao.FieldName = "DiaChiGiaoHang";
            this.colNoiGiao.Name = "colNoiGiao";
            this.colNoiGiao.OptionsColumn.AllowEdit = false;
            this.colNoiGiao.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNoiGiao.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colNoiGiao.OptionsColumn.ReadOnly = true;
            this.colNoiGiao.Visible = true;
            this.colNoiGiao.VisibleIndex = 9;
            this.colNoiGiao.Width = 222;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi chú";
            this.colGhiChu.ColumnEdit = this.repDraft;
            this.colGhiChu.FieldName = "Draft";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.OptionsColumn.AllowEdit = false;
            this.colGhiChu.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colGhiChu.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colGhiChu.OptionsColumn.ReadOnly = true;
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 7;
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
            this.tsslTrangThai});
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(1021, 22);
            this.statusStrip1.TabIndex = 108;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslTrangThai
            // 
            this.tsslTrangThai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tsslTrangThai.Name = "tsslTrangThai";
            this.tsslTrangThai.Size = new System.Drawing.Size(124, 17);
            this.tsslTrangThai.Text = "Danh sách đơn hàng";
            // 
            // frmBH_TimKhachMuaHang
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
            this.Name = "frmBH_TimKhachMuaHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm thông tin đơn hàng bán";
            this.Load += new System.EventHandler(this.frmBH_TimChungTu_Load);
            this.Activated += new System.EventHandler(this.frmBH_TimChungTu_Activated);
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
            ((System.ComponentModel.ISupportInitialize)(this.repDraft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrangThaiDH)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpKetQuaTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblGhiChu;
        internal GtidButton btnDong;
        private GtidButton btnTim;
        private GtidTextBox txtHoTenKhachHang;
        private GtidTextBox txtSoGiaoDich;
        private GtidTextBox txtDienThoai;
        private GtidTextBox txtCMND;
        private GtidTextBox txtMaSoThue;
        private GtidTextBox txtNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.ButtonEdit bteTrungTam;
        private DevExpress.XtraEditors.DateEdit dteEnd;
        private DevExpress.XtraEditors.DateEdit dteStart;
        private DevExpress.XtraEditors.LabelControl lblEnd;
        private DevExpress.XtraEditors.LabelControl lblStart;
        private DevExpress.XtraGrid.GridControl gListChungTu;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn colTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDoiTuong;
        private DevExpress.XtraGrid.Columns.GridColumn colKho;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLoaiDonHang;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayLap;
        private DevExpress.XtraGrid.Columns.GridColumn colSoGiaoDich;
        private DevExpress.XtraGrid.Columns.GridColumn colSoHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn colSoPhieuXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTien;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colNoiGiao;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repDraft;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repTrangThaiDH;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslTrangThai;
        private GtidButton cmdExport;
        private DevExpress.XtraEditors.ButtonEdit bteKhoXuat;
        private System.Windows.Forms.Label label17;
        private DevExpress.XtraGrid.Columns.GridColumn CMND;
        private DevExpress.XtraGrid.Columns.GridColumn DienThoai;
    }
}