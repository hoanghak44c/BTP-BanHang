using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frmCS_Duyet_BangGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCS_Duyet_BangGia));
            this.label9 = new System.Windows.Forms.Label();
            this.txtGhiChu = new QLBH.Core.Form.GtidTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoBangGia = new QLBH.Core.Form.GtidTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnTruoc = new System.Windows.Forms.ToolStripButton();
            this.btnSau = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTimKiem = new System.Windows.Forms.ToolStripButton();
            this.btnIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExport = new System.Windows.Forms.ToolStripSplitButton();
            this.btnExport1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExport2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDong = new System.Windows.Forms.ToolStripButton();
            this.tsbInfors = new System.Windows.Forms.ToolStripLabel();
            this.txtTongLoiNhuan = new QLBH.Core.Form.GtidTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.chkDaDuyet = new System.Windows.Forms.CheckBox();
            this.txtNgayDuyet = new QLBH.Core.Form.GtidTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNguoiLap = new QLBH.Core.Form.GtidTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.mstNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.gSanPham = new DevExpress.XtraGrid.GridControl();
            this.gvSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NganhHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdChiTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdBangGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaNhapHDCuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaTonKhoBQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienChietKhauQK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienKhuyenMai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeLNBQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DungSaiMin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DungSaiMax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaMin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaMax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBanAnToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongBanBQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DungSaiSLBQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGiaChuaVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGiaCoVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBanBuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeThuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThuongNong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoiNhuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoiNhuanTon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoiNhuanBB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoiNhuanTonBB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaNiemYet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaWebSite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DaDuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.NguoiDuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiCapNhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdNhomDuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhomDuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTenTrungTam = new QLBH.Core.Form.GtidTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimBangGia = new QLBH.Core.Form.GtidButton();
            this.chkChonDuyet = new System.Windows.Forms.CheckBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChinhSachGia = new QLBH.Core.Form.GtidButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Thiết lập chính sách giá";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(99, 98);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(925, 37);
            this.txtGhiChu.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ghi chú";
            // 
            // txtSoBangGia
            // 
            this.txtSoBangGia.Location = new System.Drawing.Point(99, 19);
            this.txtSoBangGia.Name = "txtSoBangGia";
            this.txtSoBangGia.Size = new System.Drawing.Size(331, 21);
            this.txtSoBangGia.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Số bảng giá";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTruoc,
            this.btnSau,
            this.toolStripSeparator1,
            this.btnSua,
            this.btnConfirm,
            this.toolStripSeparator2,
            this.btnTimKiem,
            this.btnIn,
            this.toolStripSeparator3,
            this.btnExport,
            this.toolStripSeparator4,
            this.btnDong,
            this.tsbInfors});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1063, 25);
            this.toolStrip1.TabIndex = 47;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnTruoc
            // 
            this.btnTruoc.Image = ((System.Drawing.Image)(resources.GetObject("btnTruoc.Image")));
            this.btnTruoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(85, 22);
            this.btnTruoc.Text = "Trước (F3)";
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnSau
            // 
            this.btnSau.Image = ((System.Drawing.Image)(resources.GetObject("btnSau.Image")));
            this.btnSau.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(74, 22);
            this.btnSau.Text = "Sau (F4)";
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 22);
            this.btnSua.Text = "Sửa (F6)";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(83, 22);
            this.btnConfirm.Text = "Duyệt (F2)";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(110, 22);
            this.btnTimKiem.Text = "Tìm kiếm (F10)";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnIn
            // 
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(37, 22);
            this.btnIn.Text = "In";
            this.btnIn.ToolTipText = "In";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnExport
            // 
            this.btnExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExport1,
            this.btnExport2});
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(114, 22);
            this.btnExport.Text = "Kết xuất Excel";
            this.btnExport.Visible = false;
            // 
            // btnExport1
            // 
            this.btnExport1.Name = "btnExport1";
            this.btnExport1.Size = new System.Drawing.Size(315, 22);
            this.btnExport1.Text = "1. Toàn bộ bảng giá";
            this.btnExport1.Click += new System.EventHandler(this.btnExport1_Click);
            // 
            // btnExport2
            // 
            this.btnExport2.Name = "btnExport2";
            this.btnExport2.Size = new System.Drawing.Size(315, 22);
            this.btnExport2.Text = "2. Chỉ export các sản phẩm trong danh sách";
            this.btnExport2.Click += new System.EventHandler(this.btnExport2_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator4.Visible = false;
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(89, 22);
            this.btnDong.Text = "Đóng (F12)";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // tsbInfors
            // 
            this.tsbInfors.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbInfors.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbInfors.ForeColor = System.Drawing.Color.Maroon;
            this.tsbInfors.Name = "tsbInfors";
            this.tsbInfors.Size = new System.Drawing.Size(141, 22);
            this.tsbInfors.Text = "Có 5 bảng giá cần duyệt";
            this.tsbInfors.Click += new System.EventHandler(this.tsbInfors_Click);
            // 
            // txtTongLoiNhuan
            // 
            this.txtTongLoiNhuan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongLoiNhuan.Location = new System.Drawing.Point(912, 192);
            this.txtTongLoiNhuan.Name = "txtTongLoiNhuan";
            this.txtTongLoiNhuan.ReadOnly = true;
            this.txtTongLoiNhuan.Size = new System.Drawing.Size(138, 21);
            this.txtTongLoiNhuan.TabIndex = 73;
            this.txtTongLoiNhuan.Visible = false;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(820, 196);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(89, 13);
            this.label23.TabIndex = 72;
            this.label23.Text = "Tổng lợi nhuận";
            this.label23.Visible = false;
            // 
            // chkDaDuyet
            // 
            this.chkDaDuyet.AutoSize = true;
            this.chkDaDuyet.Enabled = false;
            this.chkDaDuyet.Location = new System.Drawing.Point(681, 44);
            this.chkDaDuyet.Name = "chkDaDuyet";
            this.chkDaDuyet.Size = new System.Drawing.Size(71, 17);
            this.chkDaDuyet.TabIndex = 85;
            this.chkDaDuyet.Text = "Đã duyệt";
            this.chkDaDuyet.UseVisualStyleBackColor = true;
            // 
            // txtNgayDuyet
            // 
            this.txtNgayDuyet.Location = new System.Drawing.Point(681, 71);
            this.txtNgayDuyet.Multiline = true;
            this.txtNgayDuyet.Name = "txtNgayDuyet";
            this.txtNgayDuyet.ReadOnly = true;
            this.txtNgayDuyet.Size = new System.Drawing.Size(343, 21);
            this.txtNgayDuyet.TabIndex = 84;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(38, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 83;
            this.label13.Text = "Ngày lập";
            // 
            // txtNguoiLap
            // 
            this.txtNguoiLap.Location = new System.Drawing.Point(99, 71);
            this.txtNguoiLap.Name = "txtNguoiLap";
            this.txtNguoiLap.ReadOnly = true;
            this.txtNguoiLap.Size = new System.Drawing.Size(331, 21);
            this.txtNguoiLap.TabIndex = 80;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 81;
            this.label14.Text = "Người lập";
            // 
            // mstNgayLap
            // 
            this.mstNgayLap.CustomFormat = "dd/MM/yyyy";
            this.mstNgayLap.Enabled = false;
            this.mstNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mstNgayLap.Location = new System.Drawing.Point(99, 44);
            this.mstNgayLap.Name = "mstNgayLap";
            this.mstNgayLap.Size = new System.Drawing.Size(97, 21);
            this.mstNgayLap.TabIndex = 82;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(606, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 79;
            this.label11.Text = "Ngày duyệt";
            // 
            // gSanPham
            // 
            this.gSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gSanPham.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gSanPham.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gSanPham.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gSanPham.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gSanPham.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gSanPham.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gSanPham.Location = new System.Drawing.Point(12, 181);
            this.gSanPham.MainView = this.gvSanPham;
            this.gSanPham.Name = "gSanPham";
            this.gSanPham.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCheck});
            this.gSanPham.Size = new System.Drawing.Size(1044, 263);
            this.gSanPham.TabIndex = 84;
            this.gSanPham.UseEmbeddedNavigator = true;
            this.gSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSanPham,
            this.gridView1});
            // 
            // gvSanPham
            // 
            this.gvSanPham.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvSanPham.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvSanPham.Appearance.FocusedCell.Options.UseFont = true;
            this.gvSanPham.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvSanPham.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvSanPham.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvSanPham.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvSanPham.Appearance.Row.BackColor = System.Drawing.Color.Silver;
            this.gvSanPham.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvSanPham.Appearance.Row.Options.UseBackColor = true;
            this.gvSanPham.Appearance.Row.Options.UseBorderColor = true;
            this.gvSanPham.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvSanPham.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvSanPham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NganhHang,
            this.IdChiTiet,
            this.IdBangGia,
            this.IdSanPham,
            this.MaSanPham,
            this.TenSanPham,
            this.DonViTinh,
            this.LoaiSanPham,
            this.GiaNhapHDCuoi,
            this.GiaTonKhoBQ,
            this.TienChietKhauQK,
            this.TienKhuyenMai,
            this.TyLeLNBQ,
            this.DungSaiMin,
            this.DungSaiMax,
            this.GiaMin,
            this.GiaMax,
            this.GiaBanAnToan,
            this.SoLuongBanBQ,
            this.DungSaiSLBQ,
            this.DonGiaChuaVAT,
            this.TyLeChietKhau,
            this.TienChietKhau,
            this.TyLeVAT,
            this.TienVAT,
            this.DonGiaCoVAT,
            this.GiaBanBuon,
            this.TyLeThuong,
            this.ThuongNong,
            this.LoiNhuan,
            this.LoiNhuanTon,
            this.LoiNhuanBB,
            this.LoiNhuanTonBB,
            this.GiaNiemYet,
            this.GiaWebSite,
            this.DaDuyet,
            this.NguoiDuyet,
            this.NguoiCapNhat,
            this.IdNhomDuyet,
            this.NhomDuyet});
            this.gvSanPham.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvSanPham.GridControl = this.gSanPham;
            this.gvSanPham.GroupCount = 1;
            this.gvSanPham.Name = "gvSanPham";
            this.gvSanPham.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvSanPham.OptionsSelection.MultiSelect = true;
            this.gvSanPham.OptionsView.ColumnAutoWidth = false;
            this.gvSanPham.OptionsView.ShowAutoFilterRow = true;
            this.gvSanPham.OptionsView.ShowDetailButtons = false;
            this.gvSanPham.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.NganhHang, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvSanPham.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvSanPham_CellValueChanged);
            this.gvSanPham.DoubleClick += new System.EventHandler(this.gvSanPham_DoubleClick);
            // 
            // NganhHang
            // 
            this.NganhHang.Caption = "Ngành hàng";
            this.NganhHang.FieldName = "NganhHang";
            this.NganhHang.Name = "NganhHang";
            this.NganhHang.OptionsColumn.AllowEdit = false;
            this.NganhHang.OptionsColumn.AllowFocus = false;
            this.NganhHang.OptionsColumn.ReadOnly = true;
            // 
            // IdChiTiet
            // 
            this.IdChiTiet.Caption = "IdChiTiet";
            this.IdChiTiet.FieldName = "IdChiTiet";
            this.IdChiTiet.Name = "IdChiTiet";
            this.IdChiTiet.OptionsColumn.AllowEdit = false;
            this.IdChiTiet.OptionsColumn.AllowFocus = false;
            this.IdChiTiet.OptionsColumn.AllowMove = false;
            this.IdChiTiet.OptionsColumn.ReadOnly = true;
            this.IdChiTiet.Width = 115;
            // 
            // IdBangGia
            // 
            this.IdBangGia.Caption = "IdBangGia";
            this.IdBangGia.FieldName = "IdBangGia";
            this.IdBangGia.Name = "IdBangGia";
            this.IdBangGia.OptionsColumn.AllowEdit = false;
            this.IdBangGia.OptionsColumn.AllowFocus = false;
            this.IdBangGia.OptionsColumn.AllowMove = false;
            this.IdBangGia.OptionsColumn.ReadOnly = true;
            this.IdBangGia.Width = 234;
            // 
            // IdSanPham
            // 
            this.IdSanPham.Caption = "IdSanPham";
            this.IdSanPham.FieldName = "IdSanPham";
            this.IdSanPham.Name = "IdSanPham";
            this.IdSanPham.Width = 89;
            // 
            // MaSanPham
            // 
            this.MaSanPham.Caption = "Mã sản phẩm";
            this.MaSanPham.FieldName = "MaSanPham";
            this.MaSanPham.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.OptionsColumn.ReadOnly = true;
            this.MaSanPham.Visible = true;
            this.MaSanPham.VisibleIndex = 0;
            this.MaSanPham.Width = 114;
            // 
            // TenSanPham
            // 
            this.TenSanPham.Caption = "Tên sản phẩm";
            this.TenSanPham.FieldName = "TenSanPham";
            this.TenSanPham.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.OptionsColumn.ReadOnly = true;
            this.TenSanPham.Visible = true;
            this.TenSanPham.VisibleIndex = 1;
            this.TenSanPham.Width = 261;
            // 
            // DonViTinh
            // 
            this.DonViTinh.Caption = "ĐVT";
            this.DonViTinh.FieldName = "DonViTinh";
            this.DonViTinh.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.OptionsColumn.AllowEdit = false;
            this.DonViTinh.Visible = true;
            this.DonViTinh.VisibleIndex = 2;
            this.DonViTinh.Width = 89;
            // 
            // LoaiSanPham
            // 
            this.LoaiSanPham.Caption = "Loại sản phẩm";
            this.LoaiSanPham.FieldName = "LoaiSanPham";
            this.LoaiSanPham.Name = "LoaiSanPham";
            this.LoaiSanPham.Width = 96;
            // 
            // GiaNhapHDCuoi
            // 
            this.GiaNhapHDCuoi.Caption = "Giá nhập HĐ cuối";
            this.GiaNhapHDCuoi.DisplayFormat.FormatString = "N0";
            this.GiaNhapHDCuoi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaNhapHDCuoi.FieldName = "GiaNhapHDCuoi";
            this.GiaNhapHDCuoi.Name = "GiaNhapHDCuoi";
            this.GiaNhapHDCuoi.OptionsColumn.AllowEdit = false;
            this.GiaNhapHDCuoi.Visible = true;
            this.GiaNhapHDCuoi.VisibleIndex = 3;
            this.GiaNhapHDCuoi.Width = 122;
            // 
            // GiaTonKhoBQ
            // 
            this.GiaTonKhoBQ.Caption = "Giá tồn kho BQ";
            this.GiaTonKhoBQ.DisplayFormat.FormatString = "N0";
            this.GiaTonKhoBQ.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaTonKhoBQ.FieldName = "GiaTonKhoBQ";
            this.GiaTonKhoBQ.Name = "GiaTonKhoBQ";
            this.GiaTonKhoBQ.OptionsColumn.AllowEdit = false;
            this.GiaTonKhoBQ.Visible = true;
            this.GiaTonKhoBQ.VisibleIndex = 4;
            this.GiaTonKhoBQ.Width = 111;
            // 
            // TienChietKhauQK
            // 
            this.TienChietKhauQK.Caption = "Tiền chiết khấu QK";
            this.TienChietKhauQK.DisplayFormat.FormatString = "N0";
            this.TienChietKhauQK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TienChietKhauQK.FieldName = "TienChietKhauQK";
            this.TienChietKhauQK.Name = "TienChietKhauQK";
            this.TienChietKhauQK.OptionsColumn.AllowEdit = false;
            this.TienChietKhauQK.Visible = true;
            this.TienChietKhauQK.VisibleIndex = 5;
            this.TienChietKhauQK.Width = 115;
            // 
            // TienKhuyenMai
            // 
            this.TienKhuyenMai.Caption = "Tiền khuyến mại";
            this.TienKhuyenMai.DisplayFormat.FormatString = "N0";
            this.TienKhuyenMai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TienKhuyenMai.FieldName = "TienKhuyenMai";
            this.TienKhuyenMai.Name = "TienKhuyenMai";
            this.TienKhuyenMai.OptionsColumn.AllowEdit = false;
            this.TienKhuyenMai.Visible = true;
            this.TienKhuyenMai.VisibleIndex = 6;
            this.TienKhuyenMai.Width = 109;
            // 
            // TyLeLNBQ
            // 
            this.TyLeLNBQ.Caption = "Tỷ lệ LNBQ";
            this.TyLeLNBQ.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyLeLNBQ.FieldName = "TyLeLNBQ";
            this.TyLeLNBQ.Name = "TyLeLNBQ";
            this.TyLeLNBQ.OptionsColumn.AllowEdit = false;
            this.TyLeLNBQ.Visible = true;
            this.TyLeLNBQ.VisibleIndex = 7;
            this.TyLeLNBQ.Width = 88;
            // 
            // DungSaiMin
            // 
            this.DungSaiMin.Caption = "Dung sai MIN";
            this.DungSaiMin.DisplayFormat.FormatString = "N2";
            this.DungSaiMin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DungSaiMin.FieldName = "DungSaiMin";
            this.DungSaiMin.Name = "DungSaiMin";
            this.DungSaiMin.OptionsColumn.AllowEdit = false;
            this.DungSaiMin.Visible = true;
            this.DungSaiMin.VisibleIndex = 8;
            this.DungSaiMin.Width = 89;
            // 
            // DungSaiMax
            // 
            this.DungSaiMax.Caption = "Dung sai MAX";
            this.DungSaiMax.DisplayFormat.FormatString = "N2";
            this.DungSaiMax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DungSaiMax.FieldName = "DungSaiMax";
            this.DungSaiMax.Name = "DungSaiMax";
            this.DungSaiMax.OptionsColumn.AllowEdit = false;
            this.DungSaiMax.Visible = true;
            this.DungSaiMax.VisibleIndex = 9;
            this.DungSaiMax.Width = 88;
            // 
            // GiaMin
            // 
            this.GiaMin.Caption = "Giá MIN";
            this.GiaMin.DisplayFormat.FormatString = "N0";
            this.GiaMin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaMin.FieldName = "GiaMin";
            this.GiaMin.Name = "GiaMin";
            this.GiaMin.OptionsColumn.AllowEdit = false;
            this.GiaMin.Visible = true;
            this.GiaMin.VisibleIndex = 10;
            // 
            // GiaMax
            // 
            this.GiaMax.Caption = "Giá MAX";
            this.GiaMax.DisplayFormat.FormatString = "N0";
            this.GiaMax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaMax.FieldName = "GiaMax";
            this.GiaMax.Name = "GiaMax";
            this.GiaMax.OptionsColumn.AllowEdit = false;
            this.GiaMax.Visible = true;
            this.GiaMax.VisibleIndex = 11;
            this.GiaMax.Width = 82;
            // 
            // GiaBanAnToan
            // 
            this.GiaBanAnToan.Caption = "Giá bán an toàn";
            this.GiaBanAnToan.DisplayFormat.FormatString = "N0";
            this.GiaBanAnToan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaBanAnToan.FieldName = "GiaBanAnToan";
            this.GiaBanAnToan.Name = "GiaBanAnToan";
            this.GiaBanAnToan.OptionsColumn.AllowEdit = false;
            this.GiaBanAnToan.Visible = true;
            this.GiaBanAnToan.VisibleIndex = 12;
            this.GiaBanAnToan.Width = 109;
            // 
            // SoLuongBanBQ
            // 
            this.SoLuongBanBQ.Caption = "Số lượng bán BQ";
            this.SoLuongBanBQ.DisplayFormat.FormatString = "N2";
            this.SoLuongBanBQ.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SoLuongBanBQ.FieldName = "SoLuongBanBQ";
            this.SoLuongBanBQ.Name = "SoLuongBanBQ";
            this.SoLuongBanBQ.OptionsColumn.AllowEdit = false;
            this.SoLuongBanBQ.Visible = true;
            this.SoLuongBanBQ.VisibleIndex = 13;
            this.SoLuongBanBQ.Width = 111;
            // 
            // DungSaiSLBQ
            // 
            this.DungSaiSLBQ.Caption = "Dung sai SLBQ";
            this.DungSaiSLBQ.DisplayFormat.FormatString = "N2";
            this.DungSaiSLBQ.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DungSaiSLBQ.FieldName = "DungSaiSLBQ";
            this.DungSaiSLBQ.Name = "DungSaiSLBQ";
            this.DungSaiSLBQ.OptionsColumn.AllowEdit = false;
            this.DungSaiSLBQ.Visible = true;
            this.DungSaiSLBQ.VisibleIndex = 14;
            this.DungSaiSLBQ.Width = 104;
            // 
            // DonGiaChuaVAT
            // 
            this.DonGiaChuaVAT.Caption = "Giá bán chưa VAT";
            this.DonGiaChuaVAT.DisplayFormat.FormatString = "N0";
            this.DonGiaChuaVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DonGiaChuaVAT.FieldName = "DonGiaChuaVAT";
            this.DonGiaChuaVAT.Name = "DonGiaChuaVAT";
            this.DonGiaChuaVAT.OptionsColumn.AllowEdit = false;
            this.DonGiaChuaVAT.Visible = true;
            this.DonGiaChuaVAT.VisibleIndex = 15;
            this.DonGiaChuaVAT.Width = 109;
            // 
            // TyLeChietKhau
            // 
            this.TyLeChietKhau.Caption = "Tỷ lệ chiết khấu";
            this.TyLeChietKhau.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyLeChietKhau.FieldName = "TyLeChietKhau";
            this.TyLeChietKhau.Name = "TyLeChietKhau";
            this.TyLeChietKhau.Width = 106;
            // 
            // TienChietKhau
            // 
            this.TienChietKhau.Caption = "Tiền chiết khấu";
            this.TienChietKhau.DisplayFormat.FormatString = "N0";
            this.TienChietKhau.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TienChietKhau.FieldName = "TienChietKhau";
            this.TienChietKhau.Name = "TienChietKhau";
            this.TienChietKhau.OptionsColumn.AllowEdit = false;
            this.TienChietKhau.Width = 105;
            // 
            // TyLeVAT
            // 
            this.TyLeVAT.Caption = "Tỷ lệ VAT";
            this.TyLeVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyLeVAT.FieldName = "TyLeVAT";
            this.TyLeVAT.Name = "TyLeVAT";
            this.TyLeVAT.OptionsColumn.AllowEdit = false;
            this.TyLeVAT.Visible = true;
            this.TyLeVAT.VisibleIndex = 16;
            this.TyLeVAT.Width = 80;
            // 
            // TienVAT
            // 
            this.TienVAT.Caption = "Tiền VAT";
            this.TienVAT.DisplayFormat.FormatString = "N0";
            this.TienVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TienVAT.FieldName = "TienVAT";
            this.TienVAT.Name = "TienVAT";
            this.TienVAT.OptionsColumn.AllowEdit = false;
            this.TienVAT.Visible = true;
            this.TienVAT.VisibleIndex = 17;
            // 
            // DonGiaCoVAT
            // 
            this.DonGiaCoVAT.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.DonGiaCoVAT.AppearanceCell.Options.UseBackColor = true;
            this.DonGiaCoVAT.Caption = "Giá bán có VAT";
            this.DonGiaCoVAT.DisplayFormat.FormatString = "N0";
            this.DonGiaCoVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DonGiaCoVAT.FieldName = "DonGiaCoVAT";
            this.DonGiaCoVAT.Name = "DonGiaCoVAT";
            this.DonGiaCoVAT.Visible = true;
            this.DonGiaCoVAT.VisibleIndex = 18;
            this.DonGiaCoVAT.Width = 99;
            // 
            // GiaBanBuon
            // 
            this.GiaBanBuon.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.GiaBanBuon.AppearanceCell.Options.UseBackColor = true;
            this.GiaBanBuon.Caption = "Giá bán buôn";
            this.GiaBanBuon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaBanBuon.FieldName = "GiaBanBuon";
            this.GiaBanBuon.Name = "GiaBanBuon";
            this.GiaBanBuon.Visible = true;
            this.GiaBanBuon.VisibleIndex = 19;
            this.GiaBanBuon.Width = 125;
            // 
            // TyLeThuong
            // 
            this.TyLeThuong.Caption = "Tỷ lệ thưởng";
            this.TyLeThuong.FieldName = "TyLeThuong";
            this.TyLeThuong.Name = "TyLeThuong";
            this.TyLeThuong.OptionsColumn.AllowEdit = false;
            this.TyLeThuong.Width = 95;
            // 
            // ThuongNong
            // 
            this.ThuongNong.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.ThuongNong.AppearanceCell.Options.UseBackColor = true;
            this.ThuongNong.Caption = "Thưởng nóng";
            this.ThuongNong.DisplayFormat.FormatString = "N0";
            this.ThuongNong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ThuongNong.FieldName = "ThuongNong";
            this.ThuongNong.Name = "ThuongNong";
            this.ThuongNong.Visible = true;
            this.ThuongNong.VisibleIndex = 20;
            this.ThuongNong.Width = 85;
            // 
            // LoiNhuan
            // 
            this.LoiNhuan.Caption = "Lợi nhuận";
            this.LoiNhuan.DisplayFormat.FormatString = "N0";
            this.LoiNhuan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.LoiNhuan.FieldName = "LoiNhuan";
            this.LoiNhuan.Name = "LoiNhuan";
            this.LoiNhuan.OptionsColumn.AllowEdit = false;
            this.LoiNhuan.Visible = true;
            this.LoiNhuan.VisibleIndex = 21;
            this.LoiNhuan.Width = 99;
            // 
            // LoiNhuanTon
            // 
            this.LoiNhuanTon.Caption = "Lợi nhuận tồn BQ";
            this.LoiNhuanTon.FieldName = "LoiNhuanTon";
            this.LoiNhuanTon.Name = "LoiNhuanTon";
            this.LoiNhuanTon.OptionsColumn.AllowEdit = false;
            this.LoiNhuanTon.Visible = true;
            this.LoiNhuanTon.VisibleIndex = 22;
            // 
            // LoiNhuanBB
            // 
            this.LoiNhuanBB.Caption = "Lợi nhuận BB";
            this.LoiNhuanBB.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.LoiNhuanBB.FieldName = "LoiNhuanBB";
            this.LoiNhuanBB.Name = "LoiNhuanBB";
            this.LoiNhuanBB.OptionsColumn.AllowEdit = false;
            this.LoiNhuanBB.Visible = true;
            this.LoiNhuanBB.VisibleIndex = 23;
            this.LoiNhuanBB.Width = 120;
            // 
            // LoiNhuanTonBB
            // 
            this.LoiNhuanTonBB.Caption = "Lợi nuận tồn BB";
            this.LoiNhuanTonBB.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.LoiNhuanTonBB.FieldName = "LoiNhuanTonBB";
            this.LoiNhuanTonBB.Name = "LoiNhuanTonBB";
            this.LoiNhuanTonBB.OptionsColumn.AllowEdit = false;
            this.LoiNhuanTonBB.Visible = true;
            this.LoiNhuanTonBB.VisibleIndex = 24;
            this.LoiNhuanTonBB.Width = 99;
            // 
            // GiaNiemYet
            // 
            this.GiaNiemYet.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.GiaNiemYet.AppearanceCell.Options.UseBackColor = true;
            this.GiaNiemYet.Caption = "Giá niêm yết";
            this.GiaNiemYet.DisplayFormat.FormatString = "N0";
            this.GiaNiemYet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaNiemYet.FieldName = "GiaNiemYet";
            this.GiaNiemYet.Name = "GiaNiemYet";
            this.GiaNiemYet.Visible = true;
            this.GiaNiemYet.VisibleIndex = 25;
            this.GiaNiemYet.Width = 85;
            // 
            // GiaWebSite
            // 
            this.GiaWebSite.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.GiaWebSite.AppearanceCell.Options.UseBackColor = true;
            this.GiaWebSite.Caption = "Giá website";
            this.GiaWebSite.DisplayFormat.FormatString = "N0";
            this.GiaWebSite.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaWebSite.FieldName = "GiaWebSite";
            this.GiaWebSite.Name = "GiaWebSite";
            this.GiaWebSite.Visible = true;
            this.GiaWebSite.VisibleIndex = 26;
            this.GiaWebSite.Width = 90;
            // 
            // DaDuyet
            // 
            this.DaDuyet.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.DaDuyet.AppearanceCell.Options.UseBackColor = true;
            this.DaDuyet.Caption = "Đã duyệt";
            this.DaDuyet.ColumnEdit = this.repCheck;
            this.DaDuyet.FieldName = "DaDuyet";
            this.DaDuyet.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.DaDuyet.Name = "DaDuyet";
            this.DaDuyet.Visible = true;
            this.DaDuyet.VisibleIndex = 28;
            this.DaDuyet.Width = 89;
            // 
            // repCheck
            // 
            this.repCheck.AutoHeight = false;
            this.repCheck.Name = "repCheck";
            this.repCheck.ValueChecked = 1;
            this.repCheck.ValueUnchecked = 0;
            // 
            // NguoiDuyet
            // 
            this.NguoiDuyet.Caption = "Người duyệt";
            this.NguoiDuyet.FieldName = "NguoiDuyet";
            this.NguoiDuyet.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.NguoiDuyet.Name = "NguoiDuyet";
            this.NguoiDuyet.OptionsColumn.AllowEdit = false;
            this.NguoiDuyet.Visible = true;
            this.NguoiDuyet.VisibleIndex = 29;
            this.NguoiDuyet.Width = 89;
            // 
            // NguoiCapNhat
            // 
            this.NguoiCapNhat.Caption = "Người cập nhật";
            this.NguoiCapNhat.FieldName = "NguoiCapNhat";
            this.NguoiCapNhat.Name = "NguoiCapNhat";
            // 
            // IdNhomDuyet
            // 
            this.IdNhomDuyet.Caption = "IdNhomDuyet";
            this.IdNhomDuyet.FieldName = "IdNhomDuyet";
            this.IdNhomDuyet.Name = "IdNhomDuyet";
            // 
            // NhomDuyet
            // 
            this.NhomDuyet.Caption = "Nhóm duyệt giá";
            this.NhomDuyet.FieldName = "NhomDuyet";
            this.NhomDuyet.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.NhomDuyet.Name = "NhomDuyet";
            this.NhomDuyet.Visible = true;
            this.NhomDuyet.VisibleIndex = 27;
            this.NhomDuyet.Width = 92;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gSanPham;
            this.gridView1.Name = "gridView1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTenTrungTam);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnTimBangGia);
            this.groupBox2.Controls.Add(this.txtGhiChu);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtSoBangGia);
            this.groupBox2.Controls.Add(this.chkDaDuyet);
            this.groupBox2.Controls.Add(this.mstNgayLap);
            this.groupBox2.Controls.Add(this.txtNguoiLap);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtNgayDuyet);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1045, 143);
            this.groupBox2.TabIndex = 80;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chung";
            // 
            // txtTenTrungTam
            // 
            this.txtTenTrungTam.Location = new System.Drawing.Point(681, 18);
            this.txtTenTrungTam.Name = "txtTenTrungTam";
            this.txtTenTrungTam.ReadOnly = true;
            this.txtTenTrungTam.Size = new System.Drawing.Size(343, 21);
            this.txtTenTrungTam.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(613, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 95;
            this.label2.Text = "Trung tâm";
            // 
            // btnTimBangGia
            // 
            this.btnTimBangGia.Image = ((System.Drawing.Image)(resources.GetObject("btnTimBangGia.Image")));
            this.btnTimBangGia.Location = new System.Drawing.Point(436, 17);
            this.btnTimBangGia.Name = "btnTimBangGia";
            this.btnTimBangGia.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnTimBangGia.Size = new System.Drawing.Size(28, 23);
            this.btnTimBangGia.TabIndex = 93;
            this.btnTimBangGia.Click += new System.EventHandler(this.btnTimBangGia_Click);
            // 
            // chkChonDuyet
            // 
            this.chkChonDuyet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkChonDuyet.AutoSize = true;
            this.chkChonDuyet.BackColor = System.Drawing.Color.Transparent;
            this.chkChonDuyet.Location = new System.Drawing.Point(782, 456);
            this.chkChonDuyet.Name = "chkChonDuyet";
            this.chkChonDuyet.Size = new System.Drawing.Size(102, 17);
            this.chkChonDuyet.TabIndex = 85;
            this.chkChonDuyet.Text = "Duyệt/Bỏ duyệt";
            this.chkChonDuyet.UseVisualStyleBackColor = false;
            this.chkChonDuyet.CheckedChanged += new System.EventHandler(this.chkChonDuyet_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(14, 457);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 16);
            this.labelControl1.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 16);
            this.label3.TabIndex = 87;
            this.label3.Text = "Tổng số mã hàng cần duyệt:";
            // 
            // btnChinhSachGia
            // 
            this.btnChinhSachGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChinhSachGia.Image = ((System.Drawing.Image)(resources.GetObject("btnChinhSachGia.Image")));
            this.btnChinhSachGia.Location = new System.Drawing.Point(890, 450);
            this.btnChinhSachGia.Name = "btnChinhSachGia";
            this.btnChinhSachGia.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnChinhSachGia.Size = new System.Drawing.Size(161, 27);
            this.btnChinhSachGia.TabIndex = 88;
            this.btnChinhSachGia.Text = "Xem chi tiết chính sách giá";
            this.btnChinhSachGia.Click += new System.EventHandler(this.btnChinhSachGia_Click);
            // 
            // frmCS_Duyet_BangGia
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 483);
            this.Controls.Add(this.btnChinhSachGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.chkChonDuyet);
            this.Controls.Add(this.txtTongLoiNhuan);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gSanPham);
            this.KeyPreview = true;
            this.Name = "frmCS_Duyet_BangGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duyệt bảng giá bán hàng";
            this.Load += new System.EventHandler(this.frm_BangGia_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_BangGia_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_BangGia_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnTruoc;
        private System.Windows.Forms.ToolStripButton btnSau;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnDong;
        private System.Windows.Forms.ToolStripButton btnTimKiem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSplitButton btnExport;
        private System.Windows.Forms.ToolStripMenuItem btnExport1;
        private System.Windows.Forms.ToolStripMenuItem btnExport2;
        private System.Windows.Forms.ToolStripButton btnIn;
        private GtidTextBox txtGhiChu;
        private GtidTextBox txtSoBangGia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private GtidTextBox txtNguoiLap;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker mstNgayLap;
        private System.Windows.Forms.CheckBox chkDaDuyet;
        private GtidTextBox txtNgayDuyet;
        private GtidTextBox txtTongLoiNhuan;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private DevExpress.XtraGrid.GridControl gSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn NganhHang;
        private DevExpress.XtraGrid.Columns.GridColumn IdChiTiet;
        private DevExpress.XtraGrid.Columns.GridColumn IdBangGia;
        private DevExpress.XtraGrid.Columns.GridColumn IdSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn MaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn DonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn GiaNhapHDCuoi;
        private DevExpress.XtraGrid.Columns.GridColumn GiaTonKhoBQ;
        private DevExpress.XtraGrid.Columns.GridColumn TienChietKhauQK;
        private DevExpress.XtraGrid.Columns.GridColumn TienKhuyenMai;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeLNBQ;
        private DevExpress.XtraGrid.Columns.GridColumn DungSaiMin;
        private DevExpress.XtraGrid.Columns.GridColumn DungSaiMax;
        private DevExpress.XtraGrid.Columns.GridColumn GiaMin;
        private DevExpress.XtraGrid.Columns.GridColumn GiaMax;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBanAnToan;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongBanBQ;
        private DevExpress.XtraGrid.Columns.GridColumn DungSaiSLBQ;
        private DevExpress.XtraGrid.Columns.GridColumn DonGiaChuaVAT;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeChietKhau;
        private DevExpress.XtraGrid.Columns.GridColumn TienChietKhau;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeVAT;
        private DevExpress.XtraGrid.Columns.GridColumn TienVAT;
        private DevExpress.XtraGrid.Columns.GridColumn DonGiaCoVAT;
        private DevExpress.XtraGrid.Columns.GridColumn LoiNhuan;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeThuong;
        private DevExpress.XtraGrid.Columns.GridColumn ThuongNong;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiCapNhat;
        private DevExpress.XtraGrid.Columns.GridColumn DaDuyet;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiDuyet;
        private DevExpress.XtraGrid.Columns.GridColumn GiaNiemYet;
        private DevExpress.XtraGrid.Columns.GridColumn GiaWebSite;
        private DevExpress.XtraGrid.Columns.GridColumn LoiNhuanBB;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBanBuon;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.Columns.GridColumn LoiNhuanTonBB;
        private GtidButton btnTimBangGia;
        private GtidTextBox txtTenTrungTam;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn LoiNhuanTon;
        private System.Windows.Forms.CheckBox chkChonDuyet;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripLabel tsbInfors;
        private GtidButton btnChinhSachGia;
        private DevExpress.XtraGrid.Columns.GridColumn IdNhomDuyet;
        private DevExpress.XtraGrid.Columns.GridColumn NhomDuyet;
    }
}
