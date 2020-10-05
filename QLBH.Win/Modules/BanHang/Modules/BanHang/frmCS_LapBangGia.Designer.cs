using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frmCS_LapBangGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCS_LapBangGia));
            this.label9 = new System.Windows.Forms.Label();
            this.txtGhiChu = new QLBH.Core.Form.GtidTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoBangGia = new QLBH.Core.Form.GtidTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSaoChep = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnCapNhat = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbImport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTimKiem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDong = new System.Windows.Forms.ToolStripButton();
            this.cmdXoaChiTiet = new QLBH.Core.Form.GtidButton();
            this.txtTongLoiNhuan = new QLBH.Core.Form.GtidTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btnThemCT = new QLBH.Core.Form.GtidButton();
            this.chkDaDuyet = new System.Windows.Forms.CheckBox();
            this.txtNgayDuyet = new QLBH.Core.Form.GtidTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNguoiLap = new QLBH.Core.Form.GtidTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.mstNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.btnLoadSP = new QLBH.Core.Form.GtidButton();
            this.cmdDongBoGiaNhap = new QLBH.Core.Form.GtidButton();
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
            this.DonGiaCoVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBanBuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBanDemo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaNiemYet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaWebSite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KhuyenMai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repKhuyenMai = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.DonGiaChuaVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaNhapHDCuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaNhapDemoCuoi = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.ThuongNong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeThuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoiNhuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoiNhuanTon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoiNhuanBB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoiNhuanTonBB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoiNhuanDemo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhomDuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiDuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DaDuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.NguoiCapNhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdNhomDuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDayKM = new QLBH.Core.Form.GtidButton();
            this.btnAddGhiChu = new QLBH.Core.Form.GtidButton();
            this.txtTenTrungTam = new QLBH.Core.Form.GtidTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimBangGia = new QLBH.Core.Form.GtidButton();
            this.btnChinhSachGia = new QLBH.Core.Form.GtidButton();
            this.gtidButton1 = new QLBH.Core.Form.GtidButton();
            this.txtMaSanPham = new QLBH.Core.Form.GtidTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repKhuyenMai)).BeginInit();
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
            this.txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhiChu.Location = new System.Drawing.Point(608, 17);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGhiChu.Size = new System.Drawing.Size(431, 77);
            this.txtGhiChu.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 20);
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
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Số bảng giá";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btnThem,
            this.btnSaoChep,
            this.btnSua,
            this.btnCapNhat,
            this.btnXoa,
            this.btnConfirm,
            this.toolStripSeparator2,
            this.tsbImport,
            this.toolStripSeparator4,
            this.btnTimKiem,
            this.toolStripSeparator3,
            this.btnDong});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1063, 25);
            this.toolStrip1.TabIndex = 47;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 22);
            this.btnThem.Text = "Thêm (F5)";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSaoChep
            // 
            this.btnSaoChep.Image = ((System.Drawing.Image)(resources.GetObject("btnSaoChep.Image")));
            this.btnSaoChep.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaoChep.Name = "btnSaoChep";
            this.btnSaoChep.Size = new System.Drawing.Size(98, 22);
            this.btnSaoChep.Text = "&Sao chép (F9)";
            this.btnSaoChep.Click += new System.EventHandler(this.btnSaoChep_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(69, 22);
            this.btnSua.Text = "Sửa (F6)";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(98, 22);
            this.btnCapNhat.Text = "Cập nhật (F7)";
            this.btnCapNhat.Click += new System.EventHandler(this.cmdCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 22);
            this.btnXoa.Text = "Xóa (F8)";
            this.btnXoa.Click += new System.EventHandler(this.cmdXoa_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(99, 22);
            this.btnConfirm.Text = "Xác &nhận (F2)";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbImport
            // 
            this.tsbImport.Image = ((System.Drawing.Image)(resources.GetObject("tsbImport.Image")));
            this.tsbImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImport.Name = "tsbImport";
            this.tsbImport.Size = new System.Drawing.Size(86, 22);
            this.tsbImport.Text = "Import (F3)";
            this.tsbImport.Click += new System.EventHandler(this.tsbImport_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(106, 22);
            this.btnTimKiem.Text = "Tìm kiếm (F10)";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(85, 22);
            this.btnDong.Text = "Đóng (F12)";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // cmdXoaChiTiet
            // 
            this.cmdXoaChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdXoaChiTiet.Image = ((System.Drawing.Image)(resources.GetObject("cmdXoaChiTiet.Image")));
            this.cmdXoaChiTiet.Location = new System.Drawing.Point(342, 450);
            this.cmdXoaChiTiet.Name = "cmdXoaChiTiet";
            this.cmdXoaChiTiet.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdXoaChiTiet.Size = new System.Drawing.Size(83, 27);
            this.cmdXoaChiTiet.TabIndex = 2;
            this.cmdXoaChiTiet.Text = "Xóa chi tiết";
            this.cmdXoaChiTiet.Click += new System.EventHandler(this.cmdXoaChiTiet_Click);
            // 
            // txtTongLoiNhuan
            // 
            this.txtTongLoiNhuan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongLoiNhuan.Location = new System.Drawing.Point(912, 186);
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
            this.label23.Location = new System.Drawing.Point(820, 190);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(89, 13);
            this.label23.TabIndex = 72;
            this.label23.Text = "Tổng lợi nhuận";
            this.label23.Visible = false;
            // 
            // btnThemCT
            // 
            this.btnThemCT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemCT.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCT.Image")));
            this.btnThemCT.Location = new System.Drawing.Point(246, 450);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnThemCT.Size = new System.Drawing.Size(93, 27);
            this.btnThemCT.TabIndex = 1;
            this.btnThemCT.Text = "Thêm chi tiết";
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // chkDaDuyet
            // 
            this.chkDaDuyet.AutoSize = true;
            this.chkDaDuyet.Enabled = false;
            this.chkDaDuyet.Location = new System.Drawing.Point(367, 100);
            this.chkDaDuyet.Name = "chkDaDuyet";
            this.chkDaDuyet.Size = new System.Drawing.Size(71, 17);
            this.chkDaDuyet.TabIndex = 5;
            this.chkDaDuyet.Text = "Đã duyệt";
            this.chkDaDuyet.UseVisualStyleBackColor = true;
            // 
            // txtNgayDuyet
            // 
            this.txtNgayDuyet.Location = new System.Drawing.Point(99, 99);
            this.txtNgayDuyet.Multiline = true;
            this.txtNgayDuyet.Name = "txtNgayDuyet";
            this.txtNgayDuyet.ReadOnly = true;
            this.txtNgayDuyet.Size = new System.Drawing.Size(200, 21);
            this.txtNgayDuyet.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(306, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 83;
            this.label13.Text = "Ngày lập";
            // 
            // txtNguoiLap
            // 
            this.txtNguoiLap.Location = new System.Drawing.Point(99, 72);
            this.txtNguoiLap.Name = "txtNguoiLap";
            this.txtNguoiLap.Size = new System.Drawing.Size(200, 21);
            this.txtNguoiLap.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 81;
            this.label14.Text = "Người lập";
            // 
            // mstNgayLap
            // 
            this.mstNgayLap.CustomFormat = "dd/MM/yyyy";
            this.mstNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mstNgayLap.Location = new System.Drawing.Point(367, 73);
            this.mstNgayLap.Name = "mstNgayLap";
            this.mstNgayLap.Size = new System.Drawing.Size(97, 21);
            this.mstNgayLap.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 79;
            this.label11.Text = "Ngày duyệt";
            // 
            // btnLoadSP
            // 
            this.btnLoadSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadSP.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadSP.Image")));
            this.btnLoadSP.Location = new System.Drawing.Point(582, 450);
            this.btnLoadSP.Name = "btnLoadSP";
            this.btnLoadSP.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnLoadSP.Size = new System.Drawing.Size(151, 27);
            this.btnLoadSP.TabIndex = 5;
            this.btnLoadSP.Text = "Nạp danh mục sản phẩm";
            this.btnLoadSP.Visible = false;
            this.btnLoadSP.Click += new System.EventHandler(this.btnLoadSP_Click);
            // 
            // cmdDongBoGiaNhap
            // 
            this.cmdDongBoGiaNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdDongBoGiaNhap.Image = ((System.Drawing.Image)(resources.GetObject("cmdDongBoGiaNhap.Image")));
            this.cmdDongBoGiaNhap.Location = new System.Drawing.Point(428, 450);
            this.cmdDongBoGiaNhap.Name = "cmdDongBoGiaNhap";
            this.cmdDongBoGiaNhap.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdDongBoGiaNhap.Size = new System.Drawing.Size(152, 27);
            this.cmdDongBoGiaNhap.TabIndex = 3;
            this.cmdDongBoGiaNhap.Text = "Đồng bộ giá nhập Oracle";
            this.cmdDongBoGiaNhap.Click += new System.EventHandler(this.cmdDongBoGiaNhap_Click);
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
            this.gSanPham.Location = new System.Drawing.Point(11, 173);
            this.gSanPham.MainView = this.gvSanPham;
            this.gSanPham.Name = "gSanPham";
            this.gSanPham.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCheck,
            this.repKhuyenMai});
            this.gSanPham.Size = new System.Drawing.Size(1044, 271);
            this.gSanPham.TabIndex = 8;
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
            this.DonGiaCoVAT,
            this.GiaBanBuon,
            this.GiaBanDemo,
            this.GiaNiemYet,
            this.GiaWebSite,
            this.KhuyenMai,
            this.DonGiaChuaVAT,
            this.TyLeChietKhau,
            this.TienChietKhau,
            this.TyLeVAT,
            this.TienVAT,
            this.GiaNhapHDCuoi,
            this.GiaNhapDemoCuoi,
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
            this.ThuongNong,
            this.TyLeThuong,
            this.LoiNhuan,
            this.LoiNhuanTon,
            this.LoiNhuanBB,
            this.LoiNhuanTonBB,
            this.LoiNhuanDemo,
            this.NhomDuyet,
            this.NguoiDuyet,
            this.DaDuyet,
            this.NguoiCapNhat,
            this.IdNhomDuyet});
            this.gvSanPham.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvSanPham.GridControl = this.gSanPham;
            this.gvSanPham.GroupCount = 1;
            this.gvSanPham.Name = "gvSanPham";
            this.gvSanPham.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvSanPham.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvSanPham.OptionsSelection.InvertSelection = true;
            this.gvSanPham.OptionsSelection.MultiSelect = true;
            this.gvSanPham.OptionsView.ColumnAutoWidth = false;
            this.gvSanPham.OptionsView.ShowAutoFilterRow = true;
            this.gvSanPham.OptionsView.ShowDetailButtons = false;
            this.gvSanPham.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.NganhHang, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvSanPham.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gvSanPham_ValidatingEditor);
            this.gvSanPham.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvSanPham_CellValueChanged);
            this.gvSanPham.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gvSanPham_ShowingEditor);
            this.gvSanPham.DoubleClick += new System.EventHandler(this.gvSanPham_DoubleClick);
            // 
            // NganhHang
            // 
            this.NganhHang.Caption = "Ngành hàng";
            this.NganhHang.FieldName = "NganhHang";
            this.NganhHang.Name = "NganhHang";
            this.NganhHang.OptionsColumn.AllowEdit = false;
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
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.OptionsColumn.AllowEdit = false;
            this.DonViTinh.Width = 72;
            // 
            // LoaiSanPham
            // 
            this.LoaiSanPham.Caption = "Loại sản phẩm";
            this.LoaiSanPham.FieldName = "LoaiSanPham";
            this.LoaiSanPham.Name = "LoaiSanPham";
            this.LoaiSanPham.Width = 96;
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
            this.DonGiaCoVAT.VisibleIndex = 2;
            this.DonGiaCoVAT.Width = 99;
            // 
            // GiaBanBuon
            // 
            this.GiaBanBuon.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.GiaBanBuon.AppearanceCell.Options.UseBackColor = true;
            this.GiaBanBuon.Caption = "Giá bán buôn";
            this.GiaBanBuon.DisplayFormat.FormatString = "N0";
            this.GiaBanBuon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaBanBuon.FieldName = "GiaBanBuon";
            this.GiaBanBuon.Name = "GiaBanBuon";
            this.GiaBanBuon.Visible = true;
            this.GiaBanBuon.VisibleIndex = 3;
            this.GiaBanBuon.Width = 125;
            // 
            // GiaBanDemo
            // 
            this.GiaBanDemo.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.GiaBanDemo.AppearanceCell.Options.UseBackColor = true;
            this.GiaBanDemo.Caption = "Giá bán Demo";
            this.GiaBanDemo.DisplayFormat.FormatString = "N0";
            this.GiaBanDemo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaBanDemo.FieldName = "GiaBanDemo";
            this.GiaBanDemo.Name = "GiaBanDemo";
            this.GiaBanDemo.Visible = true;
            this.GiaBanDemo.VisibleIndex = 4;
            this.GiaBanDemo.Width = 111;
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
            this.GiaNiemYet.VisibleIndex = 5;
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
            this.GiaWebSite.VisibleIndex = 6;
            this.GiaWebSite.Width = 90;
            // 
            // KhuyenMai
            // 
            this.KhuyenMai.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.KhuyenMai.AppearanceCell.Options.UseBackColor = true;
            this.KhuyenMai.Caption = "Khuyến mại website";
            this.KhuyenMai.ColumnEdit = this.repKhuyenMai;
            this.KhuyenMai.FieldName = "KhuyenMai";
            this.KhuyenMai.Name = "KhuyenMai";
            this.KhuyenMai.Width = 238;
            // 
            // repKhuyenMai
            // 
            this.repKhuyenMai.Name = "repKhuyenMai";
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
            this.DonGiaChuaVAT.VisibleIndex = 7;
            this.DonGiaChuaVAT.Width = 109;
            // 
            // TyLeChietKhau
            // 
            this.TyLeChietKhau.Caption = "Tỷ lệ chiết khấu";
            this.TyLeChietKhau.DisplayFormat.FormatString = "N0";
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
            this.TyLeVAT.DisplayFormat.FormatString = "N0";
            this.TyLeVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyLeVAT.FieldName = "TyLeVAT";
            this.TyLeVAT.Name = "TyLeVAT";
            this.TyLeVAT.OptionsColumn.AllowEdit = false;
            this.TyLeVAT.Visible = true;
            this.TyLeVAT.VisibleIndex = 8;
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
            this.TienVAT.VisibleIndex = 9;
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
            this.GiaNhapHDCuoi.VisibleIndex = 10;
            this.GiaNhapHDCuoi.Width = 122;
            // 
            // GiaNhapDemoCuoi
            // 
            this.GiaNhapDemoCuoi.Caption = "Giá nhập Demo cuối";
            this.GiaNhapDemoCuoi.DisplayFormat.FormatString = "N0";
            this.GiaNhapDemoCuoi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaNhapDemoCuoi.FieldName = "GiaNhapDemoCuoi";
            this.GiaNhapDemoCuoi.Name = "GiaNhapDemoCuoi";
            this.GiaNhapDemoCuoi.OptionsColumn.AllowEdit = false;
            this.GiaNhapDemoCuoi.Visible = true;
            this.GiaNhapDemoCuoi.VisibleIndex = 11;
            this.GiaNhapDemoCuoi.Width = 124;
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
            this.GiaTonKhoBQ.VisibleIndex = 12;
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
            this.TienChietKhauQK.VisibleIndex = 13;
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
            this.TienKhuyenMai.VisibleIndex = 14;
            this.TienKhuyenMai.Width = 109;
            // 
            // TyLeLNBQ
            // 
            this.TyLeLNBQ.Caption = "Tỷ lệ LNBQ";
            this.TyLeLNBQ.DisplayFormat.FormatString = "N2";
            this.TyLeLNBQ.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyLeLNBQ.FieldName = "TyLeLNBQ";
            this.TyLeLNBQ.Name = "TyLeLNBQ";
            this.TyLeLNBQ.OptionsColumn.AllowEdit = false;
            this.TyLeLNBQ.Visible = true;
            this.TyLeLNBQ.VisibleIndex = 15;
            this.TyLeLNBQ.Width = 88;
            // 
            // DungSaiMin
            // 
            this.DungSaiMin.Caption = "Dung sai MIN";
            this.DungSaiMin.DisplayFormat.FormatString = "N0";
            this.DungSaiMin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DungSaiMin.FieldName = "DungSaiMin";
            this.DungSaiMin.Name = "DungSaiMin";
            this.DungSaiMin.OptionsColumn.AllowEdit = false;
            this.DungSaiMin.Visible = true;
            this.DungSaiMin.VisibleIndex = 16;
            this.DungSaiMin.Width = 89;
            // 
            // DungSaiMax
            // 
            this.DungSaiMax.Caption = "Dung sai MAX";
            this.DungSaiMax.DisplayFormat.FormatString = "N0";
            this.DungSaiMax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DungSaiMax.FieldName = "DungSaiMax";
            this.DungSaiMax.Name = "DungSaiMax";
            this.DungSaiMax.OptionsColumn.AllowEdit = false;
            this.DungSaiMax.Visible = true;
            this.DungSaiMax.VisibleIndex = 17;
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
            this.GiaMin.VisibleIndex = 18;
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
            this.GiaMax.VisibleIndex = 19;
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
            this.GiaBanAnToan.VisibleIndex = 20;
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
            this.SoLuongBanBQ.VisibleIndex = 21;
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
            this.DungSaiSLBQ.VisibleIndex = 22;
            this.DungSaiSLBQ.Width = 104;
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
            this.ThuongNong.VisibleIndex = 23;
            this.ThuongNong.Width = 85;
            // 
            // TyLeThuong
            // 
            this.TyLeThuong.Caption = "Tỷ lệ thưởng";
            this.TyLeThuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyLeThuong.FieldName = "TyLeThuong";
            this.TyLeThuong.Name = "TyLeThuong";
            this.TyLeThuong.OptionsColumn.AllowEdit = false;
            this.TyLeThuong.Width = 95;
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
            this.LoiNhuan.VisibleIndex = 24;
            this.LoiNhuan.Width = 99;
            // 
            // LoiNhuanTon
            // 
            this.LoiNhuanTon.Caption = "Lợi nhuận tồn BQ";
            this.LoiNhuanTon.DisplayFormat.FormatString = "N0";
            this.LoiNhuanTon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.LoiNhuanTon.FieldName = "LoiNhuanTon";
            this.LoiNhuanTon.Name = "LoiNhuanTon";
            this.LoiNhuanTon.OptionsColumn.AllowEdit = false;
            this.LoiNhuanTon.Visible = true;
            this.LoiNhuanTon.VisibleIndex = 25;
            this.LoiNhuanTon.Width = 103;
            // 
            // LoiNhuanBB
            // 
            this.LoiNhuanBB.Caption = "Lợi nhuận BB";
            this.LoiNhuanBB.DisplayFormat.FormatString = "N0";
            this.LoiNhuanBB.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.LoiNhuanBB.FieldName = "LoiNhuanBB";
            this.LoiNhuanBB.Name = "LoiNhuanBB";
            this.LoiNhuanBB.OptionsColumn.AllowEdit = false;
            this.LoiNhuanBB.Visible = true;
            this.LoiNhuanBB.VisibleIndex = 26;
            this.LoiNhuanBB.Width = 120;
            // 
            // LoiNhuanTonBB
            // 
            this.LoiNhuanTonBB.Caption = "Lợi nhuận tồn BB";
            this.LoiNhuanTonBB.DisplayFormat.FormatString = "N0";
            this.LoiNhuanTonBB.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.LoiNhuanTonBB.FieldName = "LoiNhuanTonBB";
            this.LoiNhuanTonBB.Name = "LoiNhuanTonBB";
            this.LoiNhuanTonBB.OptionsColumn.AllowEdit = false;
            this.LoiNhuanTonBB.Visible = true;
            this.LoiNhuanTonBB.VisibleIndex = 27;
            this.LoiNhuanTonBB.Width = 99;
            // 
            // LoiNhuanDemo
            // 
            this.LoiNhuanDemo.Caption = "Lợi nhuận Demo";
            this.LoiNhuanDemo.DisplayFormat.FormatString = "N0";
            this.LoiNhuanDemo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.LoiNhuanDemo.FieldName = "LoiNhuanDemo";
            this.LoiNhuanDemo.Name = "LoiNhuanDemo";
            this.LoiNhuanDemo.OptionsColumn.AllowEdit = false;
            this.LoiNhuanDemo.Visible = true;
            this.LoiNhuanDemo.VisibleIndex = 28;
            this.LoiNhuanDemo.Width = 99;
            // 
            // NhomDuyet
            // 
            this.NhomDuyet.Caption = "Nhóm duyệt giá";
            this.NhomDuyet.FieldName = "NhomDuyet";
            this.NhomDuyet.Name = "NhomDuyet";
            this.NhomDuyet.OptionsColumn.AllowEdit = false;
            this.NhomDuyet.Visible = true;
            this.NhomDuyet.VisibleIndex = 29;
            this.NhomDuyet.Width = 109;
            // 
            // NguoiDuyet
            // 
            this.NguoiDuyet.Caption = "Người duyệt";
            this.NguoiDuyet.FieldName = "NguoiDuyet";
            this.NguoiDuyet.Name = "NguoiDuyet";
            this.NguoiDuyet.OptionsColumn.AllowEdit = false;
            this.NguoiDuyet.Visible = true;
            this.NguoiDuyet.VisibleIndex = 30;
            this.NguoiDuyet.Width = 89;
            // 
            // DaDuyet
            // 
            this.DaDuyet.Caption = "Đã duyệt";
            this.DaDuyet.ColumnEdit = this.repCheck;
            this.DaDuyet.FieldName = "DaDuyet";
            this.DaDuyet.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.DaDuyet.Name = "DaDuyet";
            this.DaDuyet.OptionsColumn.AllowEdit = false;
            this.DaDuyet.Visible = true;
            this.DaDuyet.VisibleIndex = 31;
            this.DaDuyet.Width = 70;
            // 
            // repCheck
            // 
            this.repCheck.AutoHeight = false;
            this.repCheck.Name = "repCheck";
            this.repCheck.ValueChecked = 1;
            this.repCheck.ValueUnchecked = 0;
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
            // gridView1
            // 
            this.gridView1.GridControl = this.gSanPham;
            this.gridView1.Name = "gridView1";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnDayKM);
            this.groupBox2.Controls.Add(this.btnAddGhiChu);
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
            this.groupBox2.Size = new System.Drawing.Size(1045, 135);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chung";
            // 
            // btnDayKM
            // 
            this.btnDayKM.Image = ((System.Drawing.Image)(resources.GetObject("btnDayKM.Image")));
            this.btnDayKM.Location = new System.Drawing.Point(734, 100);
            this.btnDayKM.Name = "btnDayKM";
            this.btnDayKM.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnDayKM.Size = new System.Drawing.Size(120, 28);
            this.btnDayKM.TabIndex = 96;
            this.btnDayKM.Text = "Đẩy khuyến mại";
            this.btnDayKM.Visible = false;
            this.btnDayKM.Click += new System.EventHandler(this.btnDayKM_Click);
            // 
            // btnAddGhiChu
            // 
            this.btnAddGhiChu.Image = ((System.Drawing.Image)(resources.GetObject("btnAddGhiChu.Image")));
            this.btnAddGhiChu.Location = new System.Drawing.Point(608, 100);
            this.btnAddGhiChu.Name = "btnAddGhiChu";
            this.btnAddGhiChu.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnAddGhiChu.Size = new System.Drawing.Size(120, 28);
            this.btnAddGhiChu.TabIndex = 7;
            this.btnAddGhiChu.Text = "Thêm ghi chú";
            this.btnAddGhiChu.Visible = false;
            this.btnAddGhiChu.Click += new System.EventHandler(this.btnAddGhiChu_Click);
            // 
            // txtTenTrungTam
            // 
            this.txtTenTrungTam.Location = new System.Drawing.Point(99, 46);
            this.txtTenTrungTam.Name = "txtTenTrungTam";
            this.txtTenTrungTam.ReadOnly = true;
            this.txtTenTrungTam.Size = new System.Drawing.Size(365, 21);
            this.txtTenTrungTam.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 49);
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
            // btnChinhSachGia
            // 
            this.btnChinhSachGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChinhSachGia.Image = ((System.Drawing.Image)(resources.GetObject("btnChinhSachGia.Image")));
            this.btnChinhSachGia.Location = new System.Drawing.Point(912, 450);
            this.btnChinhSachGia.Name = "btnChinhSachGia";
            this.btnChinhSachGia.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnChinhSachGia.Size = new System.Drawing.Size(144, 27);
            this.btnChinhSachGia.TabIndex = 6;
            this.btnChinhSachGia.Text = "Xem chi tiết khuyến mại";
            this.btnChinhSachGia.Click += new System.EventHandler(this.btnChinhSachGia_Click);
            // 
            // gtidButton1
            // 
            this.gtidButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gtidButton1.Image = ((System.Drawing.Image)(resources.GetObject("gtidButton1.Image")));
            this.gtidButton1.Location = new System.Drawing.Point(828, 450);
            this.gtidButton1.Name = "gtidButton1";
            this.gtidButton1.ShortCutKey = System.Windows.Forms.Keys.None;
            this.gtidButton1.Size = new System.Drawing.Size(81, 27);
            this.gtidButton1.TabIndex = 7;
            this.gtidButton1.Text = "Export";
            this.gtidButton1.Click += new System.EventHandler(this.gtidButton1_Click);
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaSanPham.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSanPham.Location = new System.Drawing.Point(42, 452);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(200, 23);
            this.txtMaSanPham.TabIndex = 96;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "Mã SP";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmCS_LapBangGia
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 483);
            this.Controls.Add(this.txtMaSanPham);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gtidButton1);
            this.Controls.Add(this.btnChinhSachGia);
            this.Controls.Add(this.txtTongLoiNhuan);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.cmdDongBoGiaNhap);
            this.Controls.Add(this.btnLoadSP);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThemCT);
            this.Controls.Add(this.cmdXoaChiTiet);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gSanPham);
            this.KeyPreview = true;
            this.Name = "frmCS_LapBangGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập bảng giá bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_BangGia_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_BangGia_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_BangGia_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repKhuyenMai)).EndInit();
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnCapNhat;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnDong;
        private System.Windows.Forms.ToolStripButton btnSaoChep;
        private System.Windows.Forms.ToolStripButton btnTimKiem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private GtidTextBox txtGhiChu;
        private GtidTextBox txtSoBangGia;
        private GtidButton cmdXoaChiTiet;
        private GtidButton btnThemCT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private GtidTextBox txtNguoiLap;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker mstNgayLap;
        private System.Windows.Forms.CheckBox chkDaDuyet;
        private GtidTextBox txtNgayDuyet;
        private GtidTextBox txtTongLoiNhuan;
        private System.Windows.Forms.Label label23;
        private GtidButton btnLoadSP;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private GtidButton cmdDongBoGiaNhap;
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
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheck;
        private GtidButton btnChinhSachGia;
        private DevExpress.XtraGrid.Columns.GridColumn IdNhomDuyet;
        private DevExpress.XtraGrid.Columns.GridColumn NhomDuyet;
        private GtidButton btnAddGhiChu;
        private GtidButton gtidButton1;
        private DevExpress.XtraGrid.Columns.GridColumn GiaNhapDemoCuoi;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBanDemo;
        private DevExpress.XtraGrid.Columns.GridColumn LoiNhuanDemo;
        private GtidTextBox txtMaSanPham;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn KhuyenMai;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repKhuyenMai;
        private System.Windows.Forms.ToolStripButton tsbImport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private GtidButton btnDayKM;
    }
}
