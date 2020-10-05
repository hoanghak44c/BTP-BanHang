using QLBH.Core.Form;
namespace QLBanHang.Modules.BanHang
{
    partial class frmBC_GiaoNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBC_GiaoNhan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInPhieuGN = new QLBH.Core.Form.GtidButton();
            this.bteNganh = new DevExpress.XtraEditors.ButtonEdit();
            this.cmdExport = new QLBH.Core.Form.GtidButton();
            this.btnDong = new QLBH.Core.Form.GtidButton();
            this.btnCapNhat = new QLBH.Core.Form.GtidButton();
            this.btnTim = new QLBH.Core.Form.GtidButton();
            this.dteEnd = new DevExpress.XtraEditors.DateEdit();
            this.dteStart = new DevExpress.XtraEditors.DateEdit();
            this.lblEnd = new DevExpress.XtraEditors.LabelControl();
            this.lblStart = new DevExpress.XtraEditors.LabelControl();
            this.lueTrangThaiDH = new DevExpress.XtraEditors.LookUpEdit();
            this.lblTrangThaiDH = new DevExpress.XtraEditors.LabelControl();
            this.lueLoaiDH = new DevExpress.XtraEditors.LookUpEdit();
            this.lblTrangThaiLinhKien = new DevExpress.XtraEditors.LabelControl();
            this.cboLoaiMaHang = new System.Windows.Forms.ComboBox();
            this.bteKhoXuat = new DevExpress.XtraEditors.ButtonEdit();
            this.bteTrungTam = new DevExpress.XtraEditors.ButtonEdit();
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
            this.txtDiaChi = new QLBH.Core.Form.GtidTextBox();
            this.lblThuocXuat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTenKhachHang = new QLBH.Core.Form.GtidTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.grpKetQuaTimKiem = new System.Windows.Forms.GroupBox();
            this.gListChungTu = new DevExpress.XtraGrid.GridControl();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsChiTietGN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsInPhieuGN = new System.Windows.Forms.ToolStripMenuItem();
            this.gvListChungTu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNgayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiDonHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLoaiDonHang = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colSoGiaoDich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoChungTuGoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoPhieuDC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTienThucTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTienCoNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDoiTuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChiHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoiGiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayHenGiaoHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayPhanCong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoPhieuPhanCong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayGiaoHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoPhieuXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayGiaoXongHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Draft = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLanIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoiTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoiSua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaPhanDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTrangThaiPD = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.TinhTrangGiaoHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTinhTrangGN = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTrangThaiDH = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colGiaoNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repGiaoNhan = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repDraft = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tsslHuyClr = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslHuy = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDaGiaoXong = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTuChoi = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDangGiaoHang = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslChuaPC = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDaPhanCong = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslNLaiClr = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslNLai = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteNganh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTrangThaiDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLoaiDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhoXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).BeginInit();
            this.grpKetQuaTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gListChungTu)).BeginInit();
            this.ctxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListChungTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrangThaiPD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTinhTrangGN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrangThaiDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repGiaoNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDraft)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnInPhieuGN);
            this.groupBox1.Controls.Add(this.bteNganh);
            this.groupBox1.Controls.Add(this.cmdExport);
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.dteEnd);
            this.groupBox1.Controls.Add(this.dteStart);
            this.groupBox1.Controls.Add(this.lblEnd);
            this.groupBox1.Controls.Add(this.lblStart);
            this.groupBox1.Controls.Add(this.lueTrangThaiDH);
            this.groupBox1.Controls.Add(this.lblTrangThaiDH);
            this.groupBox1.Controls.Add(this.lueLoaiDH);
            this.groupBox1.Controls.Add(this.lblTrangThaiLinhKien);
            this.groupBox1.Controls.Add(this.cboLoaiMaHang);
            this.groupBox1.Controls.Add(this.bteKhoXuat);
            this.groupBox1.Controls.Add(this.bteTrungTam);
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
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.lblThuocXuat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtHoTenKhachHang);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnInPhieuGN
            // 
            this.btnInPhieuGN.Image = ((System.Drawing.Image)(resources.GetObject("btnInPhieuGN.Image")));
            this.btnInPhieuGN.Location = new System.Drawing.Point(892, 126);
            this.btnInPhieuGN.Name = "btnInPhieuGN";
            this.btnInPhieuGN.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnInPhieuGN.Size = new System.Drawing.Size(101, 25);
            this.btnInPhieuGN.TabIndex = 157;
            this.btnInPhieuGN.Text = "&In phiếu (F9)";
            this.btnInPhieuGN.Click += new System.EventHandler(this.cmsInPhieuGN_Click);
            // 
            // bteNganh
            // 
            this.bteNganh.Location = new System.Drawing.Point(203, 110);
            this.bteNganh.Name = "bteNganh";
            this.bteNganh.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.bteNganh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteNganh.Properties.Appearance.Options.UseBackColor = true;
            this.bteNganh.Properties.Appearance.Options.UseFont = true;
            this.bteNganh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteNganh.Size = new System.Drawing.Size(242, 21);
            this.bteNganh.TabIndex = 156;
            this.bteNganh.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteNganh_ButtonClick);
            this.bteNganh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteNganh_KeyDown);
            this.bteNganh.TextChanged += new System.EventHandler(this.bteNganh_TextChanged);
            // 
            // cmdExport
            // 
            this.cmdExport.Image = ((System.Drawing.Image)(resources.GetObject("cmdExport.Image")));
            this.cmdExport.Location = new System.Drawing.Point(892, 42);
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
            this.btnDong.Location = new System.Drawing.Point(892, 70);
            this.btnDong.Name = "btnDong";
            this.btnDong.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnDong.Size = new System.Drawing.Size(101, 25);
            this.btnDong.TabIndex = 21;
            this.btnDong.Text = "Đóng (F12)";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.Location = new System.Drawing.Point(892, 98);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnCapNhat.Size = new System.Drawing.Size(101, 25);
            this.btnCapNhat.TabIndex = 22;
            this.btnCapNhat.Text = "&Chi tiết (F6)";
            this.btnCapNhat.Click += new System.EventHandler(this.cmsChiTietGN_Click);
            // 
            // btnTim
            // 
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.Location = new System.Drawing.Point(892, 14);
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
            this.lblStart.Location = new System.Drawing.Point(503, 16);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(40, 13);
            this.lblStart.TabIndex = 144;
            this.lblStart.Text = "Từ ngày";
            // 
            // lueTrangThaiDH
            // 
            this.lueTrangThaiDH.Location = new System.Drawing.Point(93, 36);
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
            this.lblTrangThaiDH.Location = new System.Drawing.Point(1, 39);
            this.lblTrangThaiDH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTrangThaiDH.Name = "lblTrangThaiDH";
            this.lblTrangThaiDH.Size = new System.Drawing.Size(88, 13);
            this.lblTrangThaiDH.TabIndex = 141;
            this.lblTrangThaiDH.Text = "Trạng thái G.Nhận";
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
            this.cboLoaiMaHang.Location = new System.Drawing.Point(93, 110);
            this.cboLoaiMaHang.Name = "cboLoaiMaHang";
            this.cboLoaiMaHang.Size = new System.Drawing.Size(107, 21);
            this.cboLoaiMaHang.TabIndex = 7;
            // 
            // bteKhoXuat
            // 
            this.bteKhoXuat.Location = new System.Drawing.Point(93, 85);
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
            this.bteTrungTam.Location = new System.Drawing.Point(93, 60);
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
            this.label7.Location = new System.Drawing.Point(32, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 118;
            this.label7.Text = "Trung tâm";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanVien.Location = new System.Drawing.Point(93, 134);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(352, 20);
            this.txtNhanVien.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 115;
            this.label5.Text = "Nhân viên";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGhiChu.Location = new System.Drawing.Point(487, 116);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(56, 15);
            this.lblGhiChu.TabIndex = 113;
            this.lblGhiChu.Text = "Diễn giải";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(499, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 111;
            this.label10.Text = "CMND";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(552, 111);
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
            this.txtCMND.Location = new System.Drawing.Point(552, 86);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(116, 20);
            this.txtCMND.TabIndex = 15;
            this.txtCMND.Text = " ";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDienThoai.Location = new System.Drawing.Point(740, 86);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(126, 20);
            this.txtDienThoai.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(673, 89);
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
            this.label2.Location = new System.Drawing.Point(503, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 95;
            this.label2.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(552, 61);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(314, 20);
            this.txtDiaChi.TabIndex = 14;
            // 
            // lblThuocXuat
            // 
            this.lblThuocXuat.AutoSize = true;
            this.lblThuocXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuocXuat.Location = new System.Drawing.Point(32, 113);
            this.lblThuocXuat.Name = "lblThuocXuat";
            this.lblThuocXuat.Size = new System.Drawing.Size(55, 13);
            this.lblThuocXuat.TabIndex = 0;
            this.lblThuocXuat.Text = "Sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = "Họ tên";
            // 
            // txtHoTenKhachHang
            // 
            this.txtHoTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenKhachHang.Location = new System.Drawing.Point(552, 37);
            this.txtHoTenKhachHang.Name = "txtHoTenKhachHang";
            this.txtHoTenKhachHang.Size = new System.Drawing.Size(314, 20);
            this.txtHoTenKhachHang.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(38, 89);
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
            this.grpKetQuaTimKiem.Location = new System.Drawing.Point(1, 173);
            this.grpKetQuaTimKiem.Name = "grpKetQuaTimKiem";
            this.grpKetQuaTimKiem.Size = new System.Drawing.Size(1018, 334);
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
            this.repTrangThaiDH,
            this.repTinhTrangGN,
            this.repGiaoNhan,
            this.repTrangThaiPD});
            this.gListChungTu.Size = new System.Drawing.Size(1006, 309);
            this.gListChungTu.TabIndex = 0;
            this.gListChungTu.UseEmbeddedNavigator = true;
            this.gListChungTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListChungTu});
            // 
            // ctxMenu
            // 
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsChiTietGN,
            this.toolStripSeparator1,
            this.cmsInPhieuGN});
            this.ctxMenu.Name = "contextMenuStrip1";
            this.ctxMenu.Size = new System.Drawing.Size(183, 54);
            // 
            // cmsChiTietGN
            // 
            this.cmsChiTietGN.Name = "cmsChiTietGN";
            this.cmsChiTietGN.Size = new System.Drawing.Size(182, 22);
            this.cmsChiTietGN.Text = "Chi tiết giao nhận";
            this.cmsChiTietGN.Click += new System.EventHandler(this.cmsChiTietGN_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // cmsInPhieuGN
            // 
            this.cmsInPhieuGN.Name = "cmsInPhieuGN";
            this.cmsInPhieuGN.Size = new System.Drawing.Size(182, 22);
            this.cmsInPhieuGN.Text = "In phiếu giao nhận";
            this.cmsInPhieuGN.Click += new System.EventHandler(this.cmsInPhieuGN_Click);
            // 
            // gvListChungTu
            // 
            this.gvListChungTu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNgayLap,
            this.colLoaiDonHang,
            this.colSoGiaoDich,
            this.colTrungTam,
            this.colKho,
            this.colSoHoaDon,
            this.colSoChungTuGoc,
            this.colSoPhieuDC,
            this.colSoTien,
            this.colTienThucTra,
            this.colTienCoNo,
            this.colTenNhanVien,
            this.colTenDoiTuong,
            this.colDiaChiHoaDon,
            this.colNoiGiao,
            this.colNgayHenGiaoHang,
            this.NgayPhanCong,
            this.SoPhieuPhanCong,
            this.colNgayGiaoHang,
            this.colNgayXuat,
            this.colSoPhieuXuat,
            this.colNgayGiaoXongHang,
            this.Draft,
            this.GhiChu,
            this.SoLanIn,
            this.colNguoiTao,
            this.colNguoiSua,
            this.colDaPhanDon,
            this.TinhTrangGiaoHang,
            this.colTrangThai,
            this.colGiaoNhan});
            this.gvListChungTu.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvListChungTu.GridControl = this.gListChungTu;
            this.gvListChungTu.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "SoChungTu", null, "  (Tổng số  = {0})")});
            this.gvListChungTu.Name = "gvListChungTu";
            this.gvListChungTu.OptionsView.ColumnAutoWidth = false;
            this.gvListChungTu.OptionsView.ShowAutoFilterRow = true;
            this.gvListChungTu.OptionsView.ShowDetailButtons = false;
            this.gvListChungTu.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colKho, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNgayLap, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colLoaiDonHang, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSoGiaoDich, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSoHoaDon, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSoChungTuGoc, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSoPhieuDC, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSoPhieuXuat, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNgayXuat, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSoTien, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTienThucTra, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTienCoNo, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTenNhanVien, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTenDoiTuong, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDiaChiHoaDon, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNoiGiao, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNgayHenGiaoHang, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNgayGiaoHang, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNgayGiaoXongHang, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNguoiTao, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNguoiSua, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTrangThai, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.NgayPhanCong, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.SoPhieuPhanCong, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Draft, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.TinhTrangGiaoHang, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvListChungTu.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvListChungTu_FocusedRowChanged);
            this.gvListChungTu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gListChungTu_KeyDown);
            this.gvListChungTu.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvListChungTu_RowCellStyle);
            this.gvListChungTu.DoubleClick += new System.EventHandler(this.gListChungTu_DoubleClick);
            // 
            // colNgayLap
            // 
            this.colNgayLap.Caption = "Ngày lập";
            this.colNgayLap.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colNgayLap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayLap.FieldName = "NgayLap";
            this.colNgayLap.Name = "colNgayLap";
            this.colNgayLap.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNgayLap.OptionsColumn.ReadOnly = true;
            this.colNgayLap.Visible = true;
            this.colNgayLap.VisibleIndex = 0;
            this.colNgayLap.Width = 166;
            // 
            // colLoaiDonHang
            // 
            this.colLoaiDonHang.Caption = "Loại đơn hàng";
            this.colLoaiDonHang.ColumnEdit = this.repLoaiDonHang;
            this.colLoaiDonHang.FieldName = "LoaiChungTu";
            this.colLoaiDonHang.Name = "colLoaiDonHang";
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
            // colSoGiaoDich
            // 
            this.colSoGiaoDich.Caption = "Số giao dịch";
            this.colSoGiaoDich.FieldName = "SoChungTu";
            this.colSoGiaoDich.Name = "colSoGiaoDich";
            this.colSoGiaoDich.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSoGiaoDich.OptionsColumn.ReadOnly = true;
            this.colSoGiaoDich.Visible = true;
            this.colSoGiaoDich.VisibleIndex = 2;
            this.colSoGiaoDich.Width = 149;
            // 
            // colTrungTam
            // 
            this.colTrungTam.Caption = "Trung tâm";
            this.colTrungTam.FieldName = "TenTrungTam";
            this.colTrungTam.Name = "colTrungTam";
            this.colTrungTam.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTrungTam.OptionsColumn.ReadOnly = true;
            this.colTrungTam.Visible = true;
            this.colTrungTam.VisibleIndex = 3;
            this.colTrungTam.Width = 183;
            // 
            // colKho
            // 
            this.colKho.AppearanceCell.Options.UseTextOptions = true;
            this.colKho.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colKho.Caption = "Kho hàng";
            this.colKho.FieldName = "TenKho";
            this.colKho.Name = "colKho";
            this.colKho.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colKho.OptionsColumn.ReadOnly = true;
            this.colKho.Visible = true;
            this.colKho.VisibleIndex = 4;
            this.colKho.Width = 237;
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
            // colSoChungTuGoc
            // 
            this.colSoChungTuGoc.Caption = "Số chứng từ gốc";
            this.colSoChungTuGoc.FieldName = "SoChungTuGoc";
            this.colSoChungTuGoc.Name = "colSoChungTuGoc";
            this.colSoChungTuGoc.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSoChungTuGoc.OptionsColumn.ReadOnly = true;
            this.colSoChungTuGoc.Width = 118;
            // 
            // colSoPhieuDC
            // 
            this.colSoPhieuDC.Caption = "Số phiếu điều chuyển";
            this.colSoPhieuDC.FieldName = "SoPhieuDC";
            this.colSoPhieuDC.Name = "colSoPhieuDC";
            this.colSoPhieuDC.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSoPhieuDC.OptionsColumn.ReadOnly = true;
            this.colSoPhieuDC.Width = 127;
            // 
            // colSoTien
            // 
            this.colSoTien.Caption = "Giá trị đơn hàng";
            this.colSoTien.DisplayFormat.FormatString = "N0";
            this.colSoTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoTien.FieldName = "TongTienThanhToan";
            this.colSoTien.Name = "colSoTien";
            this.colSoTien.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSoTien.OptionsColumn.ReadOnly = true;
            this.colSoTien.Visible = true;
            this.colSoTien.VisibleIndex = 6;
            this.colSoTien.Width = 122;
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
            this.colTienThucTra.VisibleIndex = 7;
            this.colTienThucTra.Width = 98;
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
            this.colTienCoNo.VisibleIndex = 8;
            this.colTienCoNo.Width = 95;
            // 
            // colTenNhanVien
            // 
            this.colTenNhanVien.Caption = "Thương viên";
            this.colTenNhanVien.FieldName = "TenNhanVien";
            this.colTenNhanVien.Name = "colTenNhanVien";
            this.colTenNhanVien.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTenNhanVien.OptionsColumn.ReadOnly = true;
            this.colTenNhanVien.Visible = true;
            this.colTenNhanVien.VisibleIndex = 9;
            this.colTenNhanVien.Width = 143;
            // 
            // colTenDoiTuong
            // 
            this.colTenDoiTuong.Caption = "Khách hàng";
            this.colTenDoiTuong.FieldName = "HoTen";
            this.colTenDoiTuong.Name = "colTenDoiTuong";
            this.colTenDoiTuong.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTenDoiTuong.OptionsColumn.ReadOnly = true;
            this.colTenDoiTuong.Visible = true;
            this.colTenDoiTuong.VisibleIndex = 10;
            this.colTenDoiTuong.Width = 239;
            // 
            // colDiaChiHoaDon
            // 
            this.colDiaChiHoaDon.Caption = "Địa chỉ hóa đơn";
            this.colDiaChiHoaDon.FieldName = "DiaChiHoaDon";
            this.colDiaChiHoaDon.Name = "colDiaChiHoaDon";
            this.colDiaChiHoaDon.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colDiaChiHoaDon.OptionsColumn.ReadOnly = true;
            this.colDiaChiHoaDon.Visible = true;
            this.colDiaChiHoaDon.VisibleIndex = 11;
            this.colDiaChiHoaDon.Width = 194;
            // 
            // colNoiGiao
            // 
            this.colNoiGiao.Caption = "Địa chỉ giao hàng";
            this.colNoiGiao.FieldName = "DiaChiGiaoHang";
            this.colNoiGiao.Name = "colNoiGiao";
            this.colNoiGiao.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNoiGiao.OptionsColumn.ReadOnly = true;
            this.colNoiGiao.Visible = true;
            this.colNoiGiao.VisibleIndex = 12;
            this.colNoiGiao.Width = 222;
            // 
            // colNgayHenGiaoHang
            // 
            this.colNgayHenGiaoHang.Caption = "Ngày hẹn giao hàng";
            this.colNgayHenGiaoHang.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colNgayHenGiaoHang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayHenGiaoHang.FieldName = "NgayHenGiaoHang";
            this.colNgayHenGiaoHang.Name = "colNgayHenGiaoHang";
            this.colNgayHenGiaoHang.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNgayHenGiaoHang.OptionsColumn.ReadOnly = true;
            this.colNgayHenGiaoHang.Visible = true;
            this.colNgayHenGiaoHang.VisibleIndex = 13;
            this.colNgayHenGiaoHang.Width = 119;
            // 
            // NgayPhanCong
            // 
            this.NgayPhanCong.Caption = "Ngày phân công GN";
            this.NgayPhanCong.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.NgayPhanCong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgayPhanCong.FieldName = "NgayPhanCong";
            this.NgayPhanCong.Name = "NgayPhanCong";
            this.NgayPhanCong.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.NgayPhanCong.OptionsColumn.ReadOnly = true;
            this.NgayPhanCong.Visible = true;
            this.NgayPhanCong.VisibleIndex = 14;
            this.NgayPhanCong.Width = 129;
            // 
            // SoPhieuPhanCong
            // 
            this.SoPhieuPhanCong.Caption = "Số phân công GN";
            this.SoPhieuPhanCong.Name = "SoPhieuPhanCong";
            this.SoPhieuPhanCong.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.SoPhieuPhanCong.OptionsColumn.ReadOnly = true;
            this.SoPhieuPhanCong.Visible = true;
            this.SoPhieuPhanCong.VisibleIndex = 15;
            this.SoPhieuPhanCong.Width = 132;
            // 
            // colNgayGiaoHang
            // 
            this.colNgayGiaoHang.Caption = "Ngày giao hàng";
            this.colNgayGiaoHang.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colNgayGiaoHang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayGiaoHang.FieldName = "NgayGiaoHang";
            this.colNgayGiaoHang.Name = "colNgayGiaoHang";
            this.colNgayGiaoHang.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNgayGiaoHang.OptionsColumn.ReadOnly = true;
            this.colNgayGiaoHang.Width = 115;
            // 
            // colNgayXuat
            // 
            this.colNgayXuat.Caption = "Ngày xuất";
            this.colNgayXuat.FieldName = "NgayXuatHang";
            this.colNgayXuat.Name = "colNgayXuat";
            this.colNgayXuat.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNgayXuat.OptionsColumn.ReadOnly = true;
            this.colNgayXuat.Width = 109;
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
            // colNgayGiaoXongHang
            // 
            this.colNgayGiaoXongHang.Caption = "Ngày giao xong hàng";
            this.colNgayGiaoXongHang.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colNgayGiaoXongHang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayGiaoXongHang.FieldName = "NgayGiaoXongHang";
            this.colNgayGiaoXongHang.Name = "colNgayGiaoXongHang";
            this.colNgayGiaoXongHang.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNgayGiaoXongHang.OptionsColumn.ReadOnly = true;
            this.colNgayGiaoXongHang.Visible = true;
            this.colNgayGiaoXongHang.VisibleIndex = 16;
            this.colNgayGiaoXongHang.Width = 130;
            // 
            // Draft
            // 
            this.Draft.Caption = "Bản nháp";
            this.Draft.ColumnEdit = this.repEdit;
            this.Draft.FieldName = "DraftGN";
            this.Draft.Name = "Draft";
            this.Draft.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Draft.OptionsColumn.ReadOnly = true;
            // 
            // repEdit
            // 
            this.repEdit.AutoHeight = false;
            this.repEdit.Name = "repEdit";
            this.repEdit.ValueChecked = 1;
            this.repEdit.ValueUnchecked = 0;
            // 
            // GhiChu
            // 
            this.GhiChu.Caption = "Ghi chú đơn hàng/giao nhận";
            this.GhiChu.FieldName = "GhiChu";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.GhiChu.OptionsColumn.ReadOnly = true;
            this.GhiChu.Visible = true;
            this.GhiChu.VisibleIndex = 19;
            this.GhiChu.Width = 253;
            // 
            // SoLanIn
            // 
            this.SoLanIn.Caption = "Số lần in";
            this.SoLanIn.FieldName = "SoLanIn";
            this.SoLanIn.Name = "SoLanIn";
            this.SoLanIn.Visible = true;
            this.SoLanIn.VisibleIndex = 20;
            // 
            // colNguoiTao
            // 
            this.colNguoiTao.Caption = "Người tạo";
            this.colNguoiTao.FieldName = "NguoiTao";
            this.colNguoiTao.Name = "colNguoiTao";
            this.colNguoiTao.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNguoiTao.OptionsColumn.ReadOnly = true;
            this.colNguoiTao.Visible = true;
            this.colNguoiTao.VisibleIndex = 17;
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
            this.colNguoiSua.VisibleIndex = 18;
            this.colNguoiSua.Width = 103;
            // 
            // colDaPhanDon
            // 
            this.colDaPhanDon.Caption = "Tình trạng phân đơn";
            this.colDaPhanDon.ColumnEdit = this.repTrangThaiPD;
            this.colDaPhanDon.FieldName = "DaPhanDon";
            this.colDaPhanDon.Name = "colDaPhanDon";
            this.colDaPhanDon.OptionsColumn.ReadOnly = true;
            this.colDaPhanDon.Visible = true;
            this.colDaPhanDon.VisibleIndex = 21;
            this.colDaPhanDon.Width = 190;
            // 
            // repTrangThaiPD
            // 
            this.repTrangThaiPD.AutoHeight = false;
            this.repTrangThaiPD.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repTrangThaiPD.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.repTrangThaiPD.DisplayMember = "Name";
            this.repTrangThaiPD.Name = "repTrangThaiPD";
            this.repTrangThaiPD.ValueMember = "Id";
            // 
            // TinhTrangGiaoHang
            // 
            this.TinhTrangGiaoHang.Caption = "Tình trạng giao hàng";
            this.TinhTrangGiaoHang.ColumnEdit = this.repTinhTrangGN;
            this.TinhTrangGiaoHang.FieldName = "TinhTrangGiaoNhan";
            this.TinhTrangGiaoHang.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.TinhTrangGiaoHang.Name = "TinhTrangGiaoHang";
            this.TinhTrangGiaoHang.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TinhTrangGiaoHang.OptionsColumn.ReadOnly = true;
            this.TinhTrangGiaoHang.Visible = true;
            this.TinhTrangGiaoHang.VisibleIndex = 23;
            this.TinhTrangGiaoHang.Width = 161;
            // 
            // repTinhTrangGN
            // 
            this.repTinhTrangGN.AutoHeight = false;
            this.repTinhTrangGN.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repTinhTrangGN.DisplayMember = "Name";
            this.repTinhTrangGN.Name = "repTinhTrangGN";
            this.repTinhTrangGN.ValueMember = "Id";
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
            this.colTrangThai.VisibleIndex = 24;
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
            // colGiaoNhan
            // 
            this.colGiaoNhan.Caption = "Nơi giao hàng";
            this.colGiaoNhan.ColumnEdit = this.repGiaoNhan;
            this.colGiaoNhan.FieldName = "GiaoNhan";
            this.colGiaoNhan.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colGiaoNhan.Name = "colGiaoNhan";
            this.colGiaoNhan.OptionsColumn.AllowEdit = false;
            this.colGiaoNhan.Visible = true;
            this.colGiaoNhan.VisibleIndex = 22;
            this.colGiaoNhan.Width = 112;
            // 
            // repGiaoNhan
            // 
            this.repGiaoNhan.AutoHeight = false;
            this.repGiaoNhan.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repGiaoNhan.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.repGiaoNhan.DisplayMember = "Name";
            this.repGiaoNhan.Name = "repGiaoNhan";
            this.repGiaoNhan.ValueMember = "Id";
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
            this.tsslHuy.Size = new System.Drawing.Size(97, 17);
            this.tsslHuy.Text = "Hủy giao hàng  ";
            // 
            // tsslDaGiaoXong
            // 
            this.tsslDaGiaoXong.BackColor = System.Drawing.Color.Silver;
            this.tsslDaGiaoXong.Name = "tsslDaGiaoXong";
            this.tsslDaGiaoXong.Size = new System.Drawing.Size(24, 17);
            this.tsslDaGiaoXong.Text = "    ";
            // 
            // tsslTuChoi
            // 
            this.tsslTuChoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tsslTuChoi.Name = "tsslTuChoi";
            this.tsslTuChoi.Size = new System.Drawing.Size(83, 17);
            this.tsslTuChoi.Text = "Đã giao xong";
            // 
            // tsslDangGiaoHang
            // 
            this.tsslDangGiaoHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tsslDangGiaoHang.Name = "tsslDangGiaoHang";
            this.tsslDangGiaoHang.Size = new System.Drawing.Size(24, 17);
            this.tsslDangGiaoHang.Text = "    ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslChuaPC,
            this.toolStripStatusLabel1,
            this.tsslDaPhanCong,
            this.toolStripStatusLabel3,
            this.tsslDangGiaoHang,
            this.toolStripStatusLabel4,
            this.tsslDaGiaoXong,
            this.tsslTuChoi,
            this.tsslHuyClr,
            this.tsslHuy,
            this.tsslNLaiClr,
            this.tsslNLai});
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(1021, 22);
            this.statusStrip1.TabIndex = 108;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslChuaPC
            // 
            this.tsslChuaPC.BackColor = System.Drawing.Color.Yellow;
            this.tsslChuaPC.Name = "tsslChuaPC";
            this.tsslChuaPC.Size = new System.Drawing.Size(24, 17);
            this.tsslChuaPC.Text = "    ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(93, 17);
            this.toolStripStatusLabel1.Text = "Chờ phân công";
            // 
            // tsslDaPhanCong
            // 
            this.tsslDaPhanCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tsslDaPhanCong.Name = "tsslDaPhanCong";
            this.tsslDaPhanCong.Size = new System.Drawing.Size(24, 17);
            this.tsslDaPhanCong.Text = "    ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(87, 17);
            this.toolStripStatusLabel3.Text = "Đã phân công";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(98, 17);
            this.toolStripStatusLabel4.Text = "Đang giao hàng";
            // 
            // tsslNLaiClr
            // 
            this.tsslNLaiClr.BackColor = System.Drawing.Color.DeepPink;
            this.tsslNLaiClr.Name = "tsslNLaiClr";
            this.tsslNLaiClr.Size = new System.Drawing.Size(24, 17);
            this.tsslNLaiClr.Text = "    ";
            // 
            // tsslNLai
            // 
            this.tsslNLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tsslNLai.Name = "tsslNLai";
            this.tsslNLai.Size = new System.Drawing.Size(86, 17);
            this.tsslNLai.Text = "Nhập lại hàng";
            // 
            // frmBC_GiaoNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 532);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpKetQuaTimKiem);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmBC_GiaoNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo giao nhận";
            this.Load += new System.EventHandler(this.frmBH_TimChungTu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBH_TimChungTu_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteNganh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTrangThaiDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLoaiDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhoXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).EndInit();
            this.grpKetQuaTimKiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gListChungTu)).EndInit();
            this.ctxMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvListChungTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrangThaiPD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTinhTrangGN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrangThaiDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repGiaoNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDraft)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpKetQuaTimKiem;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblGhiChu;
        internal GtidButton btnCapNhat;
        internal GtidButton btnDong;
        private GtidButton btnTim;
        private GtidTextBox txtDiaChi;
        private GtidTextBox txtHoTenKhachHang;
        private GtidTextBox txtSoGiaoDich;
        private GtidTextBox txtDienThoai;
        private GtidTextBox txtCMND;
        private GtidTextBox txtGhiChu;
        private GtidTextBox txtNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.ButtonEdit bteTrungTam;
        private DevExpress.XtraEditors.ButtonEdit bteKhoXuat;
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
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayGiaoHang;
        private DevExpress.XtraGrid.Columns.GridColumn colNoiGiao;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repDraft;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThai;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repTrangThaiDH;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoiTao;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoiSua;
        private GtidButton cmdExport;
        private DevExpress.XtraGrid.Columns.GridColumn colSoChungTuGoc;
        private DevExpress.XtraGrid.Columns.GridColumn colSoPhieuDC;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChiHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayHenGiaoHang;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayGiaoXongHang;
        private DevExpress.XtraGrid.Columns.GridColumn SoPhieuPhanCong;
        private DevExpress.XtraGrid.Columns.GridColumn NgayPhanCong;
        private DevExpress.XtraGrid.Columns.GridColumn TinhTrangGiaoHang;
        private DevExpress.XtraGrid.Columns.GridColumn Draft;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repTinhTrangGN;
        public System.Windows.Forms.ToolStripStatusLabel tsslHuyClr;
        public System.Windows.Forms.ToolStripStatusLabel tsslHuy;
        public System.Windows.Forms.ToolStripStatusLabel tsslDaGiaoXong;
        public System.Windows.Forms.ToolStripStatusLabel tsslTuChoi;
        private System.Windows.Forms.ToolStripStatusLabel tsslDangGiaoHang;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslChuaPC;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslDaPhanCong;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripMenuItem cmsChiTietGN;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;
        private System.Windows.Forms.ToolStripStatusLabel tsslNLaiClr;
        private System.Windows.Forms.ToolStripStatusLabel tsslNLai;
        protected DevExpress.XtraEditors.ButtonEdit bteNganh;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaoNhan;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repGiaoNhan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmsInPhieuGN;
        internal GtidButton btnInPhieuGN;
        private DevExpress.XtraGrid.Columns.GridColumn SoLanIn;
        private DevExpress.XtraGrid.Columns.GridColumn colDaPhanDon;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repTrangThaiPD;
    }
}