using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frmCS_TimKiem_ChinhSachGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCS_TimKiem_ChinhSachGia));
            this.cmdTimKiem = new QLBH.Core.Form.GtidButton();
            this.cmdSua = new QLBH.Core.Form.GtidButton();
            this.cmdThoat = new QLBH.Core.Form.GtidButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboLoaiCS = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dteEnd = new DevExpress.XtraEditors.DateEdit();
            this.dteStart = new DevExpress.XtraEditors.DateEdit();
            this.lblEnd = new DevExpress.XtraEditors.LabelControl();
            this.lblStart = new DevExpress.XtraEditors.LabelControl();
            this.cmdExport = new QLBH.Core.Form.GtidButton();
            this.chkCuaToi = new System.Windows.Forms.CheckBox();
            this.bteTrungTam = new DevExpress.XtraEditors.ButtonEdit();
            this.txtMatHang = new QLBH.Core.Form.GtidTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboLoaiDoiTuong = new System.Windows.Forms.ComboBox();
            this.txtGhiChu = new QLBH.Core.Form.GtidTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboDuyet = new System.Windows.Forms.ComboBox();
            this.txtNguoiLap = new QLBH.Core.Form.GtidTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.txtSoBangGia = new QLBH.Core.Form.GtidTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpKetQuaTimKiem = new System.Windows.Forms.GroupBox();
            this.btnNext = new QLBH.Core.Form.GtidButton();
            this.cboPage = new System.Windows.Forms.ComboBox();
            this.gChinhSach = new DevExpress.XtraGrid.GridControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).BeginInit();
            this.grpKetQuaTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gChinhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChinhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDoiTuongAD)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdTimKiem
            // 
            this.cmdTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("cmdTimKiem.Image")));
            this.cmdTimKiem.Location = new System.Drawing.Point(855, 37);
            this.cmdTimKiem.Name = "cmdTimKiem";
            this.cmdTimKiem.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdTimKiem.Size = new System.Drawing.Size(111, 30);
            this.cmdTimKiem.TabIndex = 11;
            this.cmdTimKiem.Text = "Tìm kiếm (F10)";
            this.cmdTimKiem.Click += new System.EventHandler(this.cmdTimKiem_Click);
            // 
            // cmdSua
            // 
            this.cmdSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdSua.Image = ((System.Drawing.Image)(resources.GetObject("cmdSua.Image")));
            this.cmdSua.Location = new System.Drawing.Point(11, 446);
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
            this.cmdThoat.Location = new System.Drawing.Point(898, 446);
            this.cmdThoat.Name = "cmdThoat";
            this.cmdThoat.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdThoat.Size = new System.Drawing.Size(104, 24);
            this.cmdThoat.TabIndex = 3;
            this.cmdThoat.Text = "&Thoát (ESC)";
            this.cmdThoat.Click += new System.EventHandler(this.cmdThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Siêu thị";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cboLoaiCS);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.dteEnd);
            this.groupBox1.Controls.Add(this.dteStart);
            this.groupBox1.Controls.Add(this.lblEnd);
            this.groupBox1.Controls.Add(this.lblStart);
            this.groupBox1.Controls.Add(this.cmdExport);
            this.groupBox1.Controls.Add(this.chkCuaToi);
            this.groupBox1.Controls.Add(this.bteTrungTam);
            this.groupBox1.Controls.Add(this.txtMatHang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmdTimKiem);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboLoaiDoiTuong);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboDuyet);
            this.groupBox1.Controls.Add(this.txtNguoiLap);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboTrangThai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSoBangGia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cboLoaiCS
            // 
            this.cboLoaiCS.FormattingEnabled = true;
            this.cboLoaiCS.Items.AddRange(new object[] {
            "Tất cả",
            "Đang tạm dừng",
            "Chưa kích hoạt",
            "Đang hoạt động"});
            this.cboLoaiCS.Location = new System.Drawing.Point(534, 114);
            this.cboLoaiCS.Name = "cboLoaiCS";
            this.cboLoaiCS.Size = new System.Drawing.Size(219, 21);
            this.cboLoaiCS.TabIndex = 148;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(459, 117);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 13);
            this.labelControl2.TabIndex = 147;
            this.labelControl2.Text = "Loại chính sách";
            // 
            // dteEnd
            // 
            this.dteEnd.EditValue = null;
            this.dteEnd.Location = new System.Drawing.Point(704, 62);
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
            this.dteEnd.Size = new System.Drawing.Size(115, 20);
            this.dteEnd.TabIndex = 8;
            // 
            // dteStart
            // 
            this.dteStart.EditValue = null;
            this.dteStart.Location = new System.Drawing.Point(534, 64);
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
            this.dteStart.Size = new System.Drawing.Size(115, 20);
            this.dteStart.TabIndex = 7;
            // 
            // lblEnd
            // 
            this.lblEnd.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEnd.Appearance.Options.UseFont = true;
            this.lblEnd.Location = new System.Drawing.Point(653, 67);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(45, 13);
            this.lblEnd.TabIndex = 146;
            this.lblEnd.Text = "đến ngày";
            // 
            // lblStart
            // 
            this.lblStart.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStart.Appearance.Options.UseFont = true;
            this.lblStart.Location = new System.Drawing.Point(487, 67);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(40, 13);
            this.lblStart.TabIndex = 145;
            this.lblStart.Text = "Từ ngày";
            // 
            // cmdExport
            // 
            this.cmdExport.Image = ((System.Drawing.Image)(resources.GetObject("cmdExport.Image")));
            this.cmdExport.Location = new System.Drawing.Point(855, 71);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdExport.Size = new System.Drawing.Size(111, 30);
            this.cmdExport.TabIndex = 12;
            this.cmdExport.Text = "Export (F12)";
            this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // chkCuaToi
            // 
            this.chkCuaToi.AutoSize = true;
            this.chkCuaToi.Checked = true;
            this.chkCuaToi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCuaToi.Location = new System.Drawing.Point(759, 116);
            this.chkCuaToi.Name = "chkCuaToi";
            this.chkCuaToi.Size = new System.Drawing.Size(60, 17);
            this.chkCuaToi.TabIndex = 10;
            this.chkCuaToi.Text = "Của tôi";
            this.chkCuaToi.UseVisualStyleBackColor = true;
            // 
            // bteTrungTam
            // 
            this.bteTrungTam.Location = new System.Drawing.Point(94, 62);
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
            this.txtMatHang.Location = new System.Drawing.Point(534, 88);
            this.txtMatHang.Name = "txtMatHang";
            this.txtMatHang.Size = new System.Drawing.Size(285, 21);
            this.txtMatHang.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 109;
            this.label2.Text = "Mặt hàng (Mã/tên)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 105;
            this.label9.Text = "Loại đối tượng";
            // 
            // cboLoaiDoiTuong
            // 
            this.cboLoaiDoiTuong.FormattingEnabled = true;
            this.cboLoaiDoiTuong.Location = new System.Drawing.Point(94, 88);
            this.cboLoaiDoiTuong.Name = "cboLoaiDoiTuong";
            this.cboLoaiDoiTuong.Size = new System.Drawing.Size(285, 21);
            this.cboLoaiDoiTuong.TabIndex = 3;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(94, 115);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(285, 21);
            this.txtGhiChu.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 103;
            this.label8.Text = "Ghi chú";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 101;
            this.label7.Text = "Trình trạng hoạt động";
            // 
            // cboDuyet
            // 
            this.cboDuyet.FormattingEnabled = true;
            this.cboDuyet.Items.AddRange(new object[] {
            "Tất cả",
            "Đang tạm dừng",
            "Chưa duyệt",
            "Đang hoạt động",
            "Từ chối"});
            this.cboDuyet.Location = new System.Drawing.Point(534, 37);
            this.cboDuyet.Name = "cboDuyet";
            this.cboDuyet.Size = new System.Drawing.Size(285, 21);
            this.cboDuyet.TabIndex = 6;
            // 
            // txtNguoiLap
            // 
            this.txtNguoiLap.Location = new System.Drawing.Point(94, 37);
            this.txtNguoiLap.Name = "txtNguoiLap";
            this.txtNguoiLap.Size = new System.Drawing.Size(285, 21);
            this.txtNguoiLap.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 98;
            this.label5.Text = "Người lập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 16);
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
            this.cboTrangThai.Location = new System.Drawing.Point(534, 13);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(285, 21);
            this.cboTrangThai.TabIndex = 5;
            // 
            // txtSoBangGia
            // 
            this.txtSoBangGia.Location = new System.Drawing.Point(94, 13);
            this.txtSoBangGia.Name = "txtSoBangGia";
            this.txtSoBangGia.Size = new System.Drawing.Size(285, 21);
            this.txtSoBangGia.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 88;
            this.label1.Text = "Số chính sách";
            // 
            // grpKetQuaTimKiem
            // 
            this.grpKetQuaTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKetQuaTimKiem.Controls.Add(this.btnNext);
            this.grpKetQuaTimKiem.Controls.Add(this.cboPage);
            this.grpKetQuaTimKiem.Controls.Add(this.gChinhSach);
            this.grpKetQuaTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKetQuaTimKiem.ForeColor = System.Drawing.Color.Black;
            this.grpKetQuaTimKiem.Location = new System.Drawing.Point(5, 152);
            this.grpKetQuaTimKiem.Name = "grpKetQuaTimKiem";
            this.grpKetQuaTimKiem.Size = new System.Drawing.Size(1004, 290);
            this.grpKetQuaTimKiem.TabIndex = 1;
            this.grpKetQuaTimKiem.TabStop = false;
            this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(846, 27);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnNext.Size = new System.Drawing.Size(121, 22);
            this.btnNext.TabIndex = 154;
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
            this.cboPage.Location = new System.Drawing.Point(794, 27);
            this.cboPage.Name = "cboPage";
            this.cboPage.Size = new System.Drawing.Size(50, 21);
            this.cboPage.TabIndex = 153;
            // 
            // gChinhSach
            // 
            this.gChinhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
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
            this.gChinhSach.Size = new System.Drawing.Size(991, 265);
            this.gChinhSach.TabIndex = 85;
            this.gChinhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChinhSach});
            this.gChinhSach.DoubleClick += new System.EventHandler(this.gChinhSach_DoubleClick);
            this.gChinhSach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gChinhSach_KeyDown);
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
            this.NgayLap.Width = 109;
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
            this.NguoiLap.Width = 109;
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
            this.DoUuTien.Width = 88;
            // 
            // MacDinh
            // 
            this.MacDinh.Caption = "Loại chính sách";
            this.MacDinh.ColumnEdit = this.repLoaiCS;
            this.MacDinh.FieldName = "MacDinh";
            this.MacDinh.Name = "MacDinh";
            this.MacDinh.OptionsColumn.AllowEdit = false;
            this.MacDinh.Visible = true;
            this.MacDinh.VisibleIndex = 4;
            this.MacDinh.Width = 111;
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
            this.DaDuyetTT.Width = 118;
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
            this.NgayHieuLuc.Width = 111;
            // 
            // HanHieuLucTT
            // 
            this.HanHieuLucTT.Caption = "Hiệu lực đến";
            this.HanHieuLucTT.FieldName = "HanHieuLucTT";
            this.HanHieuLucTT.Name = "HanHieuLucTT";
            this.HanHieuLucTT.OptionsColumn.AllowEdit = false;
            this.HanHieuLucTT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.HanHieuLucTT.Visible = true;
            this.HanHieuLucTT.VisibleIndex = 7;
            this.HanHieuLucTT.Width = 92;
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
            this.colDraft.Width = 62;
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
            this.NguoiTao.Width = 61;
            // 
            // LoaiDoiTuong
            // 
            this.LoaiDoiTuong.Caption = "Đối tượng áp dụng";
            this.LoaiDoiTuong.ColumnEdit = this.repDoiTuongAD;
            this.LoaiDoiTuong.FieldName = "LoaiDoiTuong";
            this.LoaiDoiTuong.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.LoaiDoiTuong.Name = "LoaiDoiTuong";
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
            this.repDoiTuongAD.DisplayMember = "Name";
            this.repDoiTuongAD.Name = "repDoiTuongAD";
            this.repDoiTuongAD.ValueMember = "Id";
            // 
            // frmCS_TimKiem_ChinhSachGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 475);
            this.Controls.Add(this.grpKetQuaTimKiem);
            this.Controls.Add(this.cmdSua);
            this.Controls.Add(this.cmdThoat);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "frmCS_TimKiem_ChinhSachGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm chính sách giá";
            this.Load += new System.EventHandler(this.frm_TimKiem_BangGia_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_TimKiem_BangGia_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).EndInit();
            this.grpKetQuaTimKiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gChinhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChinhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDoiTuongAD)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.GroupBox grpKetQuaTimKiem;
        private GtidTextBox txtNguoiLap;
        private System.Windows.Forms.Label label5;
        private GtidTextBox txtGhiChu;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraGrid.GridControl gChinhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChinhSach;
        private DevExpress.XtraGrid.Columns.GridColumn IdChinhSach;
        private DevExpress.XtraGrid.Columns.GridColumn SoChinhSach;
        private DevExpress.XtraGrid.Columns.GridColumn NgayLap;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiLap;
        private DevExpress.XtraGrid.Columns.GridColumn DoUuTien;
        private DevExpress.XtraGrid.Columns.GridColumn colDraft;
        private DevExpress.XtraGrid.Columns.GridColumn DaDuyetTT;
        private DevExpress.XtraGrid.Columns.GridColumn NgayHieuLuc;
        private DevExpress.XtraGrid.Columns.GridColumn HanHieuLucTT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboDuyet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboLoaiDoiTuong;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheck;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiTao;
        private GtidTextBox txtMatHang;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ButtonEdit bteTrungTam;
        private System.Windows.Forms.CheckBox chkCuaToi;
        private GtidButton cmdExport;
        private DevExpress.XtraEditors.DateEdit dteEnd;
        private DevExpress.XtraEditors.DateEdit dteStart;
        private DevExpress.XtraEditors.LabelControl lblEnd;
        private DevExpress.XtraEditors.LabelControl lblStart;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiDoiTuong;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repDoiTuongAD;
        private GtidButton btnNext;
        private System.Windows.Forms.ComboBox cboPage;
        private DevExpress.XtraGrid.Columns.GridColumn MacDinh;
        private System.Windows.Forms.ComboBox cboLoaiCS;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLoaiCS;

    }
}