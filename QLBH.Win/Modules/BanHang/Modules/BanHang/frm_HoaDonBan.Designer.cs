using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frm_HoaDonBan
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HoaDonBan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnTruoc = new System.Windows.Forms.ToolStripButton();
            this.btnSau = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnCapNhat = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnIn = new System.Windows.Forms.ToolStripButton();
            this.btnTimKiem = new System.Windows.Forms.ToolStripButton();
            this.btnDong = new System.Windows.Forms.ToolStripButton();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnLoad = new GtidButton();
            this.dtNgayBan = new System.Windows.Forms.DateTimePicker();
            this.cboQuyenSo = new System.Windows.Forms.ComboBox();
            this.cboKho = new System.Windows.Forms.ComboBox();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtSoSeri = new GtidTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSoHoaDon = new GtidTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoPhieuXuat = new GtidTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaSoThue = new GtidTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDoTuoi = new GtidTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtHoTen = new GtidTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGhiChu = new GtidTextBox();
            this.txtSiteNumberBillTo = new GtidTextBox();
            this.txtDiaChi = new GtidTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDienThoai = new GtidTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoaChiTiet = new GtidButton();
            this.btnChiTietChungTu = new GtidButton();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTyLeVAT = new GtidTextBox();
            this.lblTongTienChietKhau = new System.Windows.Forms.Label();
            this.lblTongTienSauChietKhau = new System.Windows.Forms.Label();
            this.lblTongTienVAT = new System.Windows.Forms.Label();
            this.lblTongTienThanhToan = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageThongTinHoaDon = new System.Windows.Forms.TabPage();
            this.cboOrderType = new System.Windows.Forms.ComboBox();
            this.cboDoiTuong = new System.Windows.Forms.ComboBox();
            this.txtSiteNumberShipTo = new GtidTextBox();
            this.txtAddressShipTo = new GtidTextBox();
            this.txtAddressBillTo = new GtidTextBox();
            this.cboHinhThucTT = new System.Windows.Forms.ComboBox();
            this.cboHinhThucTra = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tabPageThongTinThem = new System.Windows.Forms.TabPage();
            this.txtNganHang = new GtidTextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtSoTaiKhoan = new GtidTextBox();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TyLeChietKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienChietKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdChungTuChiTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageThongTinHoaDon.SuspendLayout();
            this.tabPageThongTinThem.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTruoc,
            this.btnSau,
            this.toolStripSeparator1,
            this.btnThem,
            this.btnSua,
            this.btnCapNhat,
            this.btnXoa,
            this.btnIn,
            this.btnTimKiem,
            this.btnDong});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(847, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnTruoc
            // 
            this.btnTruoc.Image = ((System.Drawing.Image)(resources.GetObject("btnTruoc.Image")));
            this.btnTruoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(81, 22);
            this.btnTruoc.Text = "Trước (F3)";
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnSau
            // 
            this.btnSau.Image = ((System.Drawing.Image)(resources.GetObject("btnSau.Image")));
            this.btnSau.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(69, 22);
            this.btnSau.Text = "Sau (F4)";
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
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
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 22);
            this.btnXoa.Text = "Xóa (F8)";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnIn
            // 
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(60, 22);
            this.btnIn.Text = "In (F9)";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
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
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(85, 22);
            this.btnDong.Text = "Đóng (F12)";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTieuDe.Location = new System.Drawing.Point(12, 36);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(203, 24);
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Text = "HÓA ĐƠN BÁN HÀNG";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoad
            // 
            this.btnLoad.Enabled = false;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(754, 10);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(29, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "...";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dtNgayBan
            // 
            this.dtNgayBan.CustomFormat = "dd/MM/yyyy";
            this.dtNgayBan.Enabled = false;
            this.dtNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayBan.Location = new System.Drawing.Point(517, 38);
            this.dtNgayBan.Name = "dtNgayBan";
            this.dtNgayBan.Size = new System.Drawing.Size(111, 20);
            this.dtNgayBan.TabIndex = 4;
            // 
            // cboQuyenSo
            // 
            this.cboQuyenSo.BackColor = System.Drawing.Color.White;
            this.cboQuyenSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuyenSo.Enabled = false;
            this.cboQuyenSo.FormattingEnabled = true;
            this.cboQuyenSo.Location = new System.Drawing.Point(523, 10);
            this.cboQuyenSo.Name = "cboQuyenSo";
            this.cboQuyenSo.Size = new System.Drawing.Size(111, 21);
            this.cboQuyenSo.TabIndex = 5;
            this.cboQuyenSo.SelectedIndexChanged += new System.EventHandler(this.cboQuyenSo_SelectedIndexChanged);
            // 
            // cboKho
            // 
            this.cboKho.BackColor = System.Drawing.Color.White;
            this.cboKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKho.Enabled = false;
            this.cboKho.FormattingEnabled = true;
            this.cboKho.Location = new System.Drawing.Point(517, 117);
            this.cboKho.Name = "cboKho";
            this.cboKho.Size = new System.Drawing.Size(266, 21);
            this.cboKho.TabIndex = 11;
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.BackColor = System.Drawing.Color.White;
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.Enabled = false;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(517, 144);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(266, 21);
            this.cboNhanVien.TabIndex = 13;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.BackColor = System.Drawing.Color.White;
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.Enabled = false;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "",
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(289, 37);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(93, 21);
            this.cboGioiTinh.TabIndex = 18;
            // 
            // txtSoSeri
            // 
            this.txtSoSeri.BackColor = System.Drawing.Color.White;
            this.txtSoSeri.Enabled = false;
            this.txtSoSeri.Location = new System.Drawing.Point(688, 38);
            this.txtSoSeri.MaxLength = 30;
            this.txtSoSeri.Name = "txtSoSeri";
            this.txtSoSeri.Size = new System.Drawing.Size(118, 20);
            this.txtSoSeri.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(640, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Số Seri";
            // 
            // txtSoHoaDon
            // 
            this.txtSoHoaDon.BackColor = System.Drawing.Color.White;
            this.txtSoHoaDon.Enabled = false;
            this.txtSoHoaDon.Location = new System.Drawing.Point(523, 38);
            this.txtSoHoaDon.MaxLength = 30;
            this.txtSoHoaDon.Name = "txtSoHoaDon";
            this.txtSoHoaDon.Size = new System.Drawing.Size(111, 20);
            this.txtSoHoaDon.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(446, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ký hiệu HĐ";
            // 
            // txtSoPhieuXuat
            // 
            this.txtSoPhieuXuat.BackColor = System.Drawing.Color.White;
            this.txtSoPhieuXuat.Enabled = false;
            this.txtSoPhieuXuat.Location = new System.Drawing.Point(517, 12);
            this.txtSoPhieuXuat.Name = "txtSoPhieuXuat";
            this.txtSoPhieuXuat.Size = new System.Drawing.Size(231, 20);
            this.txtSoPhieuXuat.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(433, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số phiếu xuất";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(433, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ngày bán";
            // 
            // txtMaSoThue
            // 
            this.txtMaSoThue.BackColor = System.Drawing.Color.White;
            this.txtMaSoThue.Enabled = false;
            this.txtMaSoThue.Location = new System.Drawing.Point(84, 114);
            this.txtMaSoThue.MaxLength = 30;
            this.txtMaSoThue.Name = "txtMaSoThue";
            this.txtMaSoThue.Size = new System.Drawing.Size(150, 20);
            this.txtMaSoThue.TabIndex = 22;
            this.txtMaSoThue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoTuoi_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã số thuế";
            // 
            // txtDoTuoi
            // 
            this.txtDoTuoi.BackColor = System.Drawing.Color.White;
            this.txtDoTuoi.Enabled = false;
            this.txtDoTuoi.Location = new System.Drawing.Point(84, 38);
            this.txtDoTuoi.Name = "txtDoTuoi";
            this.txtDoTuoi.Size = new System.Drawing.Size(112, 20);
            this.txtDoTuoi.TabIndex = 17;
            this.txtDoTuoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoTuoi_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Độ tuổi";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.White;
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Location = new System.Drawing.Point(84, 12);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(298, 20);
            this.txtHoTen.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.Color.White;
            this.txtGhiChu.Enabled = false;
            this.txtGhiChu.Location = new System.Drawing.Point(524, 64);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(282, 64);
            this.txtGhiChu.TabIndex = 23;
            // 
            // txtSiteNumberBillTo
            // 
            this.txtSiteNumberBillTo.BackColor = System.Drawing.Color.White;
            this.txtSiteNumberBillTo.Enabled = false;
            this.txtSiteNumberBillTo.Location = new System.Drawing.Point(104, 64);
            this.txtSiteNumberBillTo.MaxLength = 15;
            this.txtSiteNumberBillTo.Name = "txtSiteNumberBillTo";
            this.txtSiteNumberBillTo.Size = new System.Drawing.Size(134, 20);
            this.txtSiteNumberBillTo.TabIndex = 6;
            this.txtSiteNumberBillTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoTuoi_KeyPress);
            this.txtSiteNumberBillTo.Validating += new System.ComponentModel.CancelEventHandler(this.txtSite_Validating);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.White;
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(84, 62);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(298, 20);
            this.txtDiaChi.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ghi chú";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.BackColor = System.Drawing.Color.White;
            this.txtDienThoai.Enabled = false;
            this.txtDienThoai.Location = new System.Drawing.Point(84, 88);
            this.txtDienThoai.MaxLength = 15;
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(150, 20);
            this.txtDienThoai.TabIndex = 21;
            this.txtDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoai_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Địa chỉ hóa đơn";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(446, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Quyển HĐ số";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(433, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kho";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(433, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Nhân viên";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(223, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điện thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách hàng";
            // 
            // btnXoaChiTiet
            // 
            this.btnXoaChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaChiTiet.Enabled = false;
            this.btnXoaChiTiet.Location = new System.Drawing.Point(621, 281);
            this.btnXoaChiTiet.Name = "btnXoaChiTiet";
            this.btnXoaChiTiet.Size = new System.Drawing.Size(75, 23);
            this.btnXoaChiTiet.TabIndex = 24;
            this.btnXoaChiTiet.Text = "Xóa chi tiết";
            this.btnXoaChiTiet.UseVisualStyleBackColor = true;
            this.btnXoaChiTiet.Click += new System.EventHandler(this.btnXoaChiTiet_Click);
            // 
            // btnChiTietChungTu
            // 
            this.btnChiTietChungTu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChiTietChungTu.Enabled = false;
            this.btnChiTietChungTu.Location = new System.Drawing.Point(703, 281);
            this.btnChiTietChungTu.Name = "btnChiTietChungTu";
            this.btnChiTietChungTu.Size = new System.Drawing.Size(117, 23);
            this.btnChiTietChungTu.TabIndex = 25;
            this.btnChiTietChungTu.Text = "Chi tiết chứng từ";
            this.btnChiTietChungTu.UseVisualStyleBackColor = true;
            this.btnChiTietChungTu.Click += new System.EventHandler(this.btnChiTietChungTu_Click);
            // 
            // dgvList
            // 
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSanPham,
            this.TenSanPham,
            this.DonViTinh,
            this.SoLuong,
            this.DonGia,
            this.TyLeChietKhau,
            this.TienChietKhau,
            this.ThanhTien,
            this.IdSanPham,
            this.IdChungTuChiTiet});
            this.dgvList.Location = new System.Drawing.Point(12, 310);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 21;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(823, 230);
            this.dgvList.TabIndex = 16;
            this.dgvList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellValueChanged);
            this.dgvList.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvList_CellValidating);
            this.dgvList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellEndEdit);
            this.dgvList.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvList_RowsRemoved);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(47, 555);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Tỷ lệ VAT (%)";
            // 
            // txtTyLeVAT
            // 
            this.txtTyLeVAT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTyLeVAT.BackColor = System.Drawing.Color.White;
            this.txtTyLeVAT.Enabled = false;
            this.txtTyLeVAT.Location = new System.Drawing.Point(121, 552);
            this.txtTyLeVAT.Name = "txtTyLeVAT";
            this.txtTyLeVAT.Size = new System.Drawing.Size(100, 20);
            this.txtTyLeVAT.TabIndex = 17;
            // 
            // lblTongTienChietKhau
            // 
            this.lblTongTienChietKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongTienChietKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienChietKhau.Location = new System.Drawing.Point(390, 555);
            this.lblTongTienChietKhau.Name = "lblTongTienChietKhau";
            this.lblTongTienChietKhau.Size = new System.Drawing.Size(111, 13);
            this.lblTongTienChietKhau.TabIndex = 5;
            this.lblTongTienChietKhau.Text = "0";
            this.lblTongTienChietKhau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTongTienSauChietKhau
            // 
            this.lblTongTienSauChietKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongTienSauChietKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienSauChietKhau.Location = new System.Drawing.Point(390, 589);
            this.lblTongTienSauChietKhau.Name = "lblTongTienSauChietKhau";
            this.lblTongTienSauChietKhau.Size = new System.Drawing.Size(111, 13);
            this.lblTongTienSauChietKhau.TabIndex = 5;
            this.lblTongTienSauChietKhau.Text = "0";
            this.lblTongTienSauChietKhau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTongTienVAT
            // 
            this.lblTongTienVAT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongTienVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienVAT.Location = new System.Drawing.Point(720, 555);
            this.lblTongTienVAT.Name = "lblTongTienVAT";
            this.lblTongTienVAT.Size = new System.Drawing.Size(115, 13);
            this.lblTongTienVAT.TabIndex = 5;
            this.lblTongTienVAT.Text = "0";
            this.lblTongTienVAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTongTienThanhToan
            // 
            this.lblTongTienThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongTienThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienThanhToan.Location = new System.Drawing.Point(720, 589);
            this.lblTongTienThanhToan.Name = "lblTongTienThanhToan";
            this.lblTongTienThanhToan.Size = new System.Drawing.Size(115, 13);
            this.lblTongTienThanhToan.TabIndex = 5;
            this.lblTongTienThanhToan.Text = "0";
            this.lblTongTienThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(259, 555);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Tổng tiền chiết khấu";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(259, 589);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(125, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "Tổng tiền sau chiết khấu";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(608, 555);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 13);
            this.label20.TabIndex = 5;
            this.label20.Text = "Tổng tiền VAT";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(608, 589);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(106, 13);
            this.label21.TabIndex = 5;
            this.label21.Text = "Tổng tiền thanh toán";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageThongTinHoaDon);
            this.tabControl1.Controls.Add(this.tabPageThongTinThem);
            this.tabControl1.Location = new System.Drawing.Point(12, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(821, 209);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPageThongTinHoaDon
            // 
            this.tabPageThongTinHoaDon.Controls.Add(this.label1);
            this.tabPageThongTinHoaDon.Controls.Add(this.btnLoad);
            this.tabPageThongTinHoaDon.Controls.Add(this.cboNhanVien);
            this.tabPageThongTinHoaDon.Controls.Add(this.dtNgayBan);
            this.tabPageThongTinHoaDon.Controls.Add(this.label8);
            this.tabPageThongTinHoaDon.Controls.Add(this.cboOrderType);
            this.tabPageThongTinHoaDon.Controls.Add(this.cboDoiTuong);
            this.tabPageThongTinHoaDon.Controls.Add(this.cboKho);
            this.tabPageThongTinHoaDon.Controls.Add(this.txtSiteNumberShipTo);
            this.tabPageThongTinHoaDon.Controls.Add(this.txtAddressShipTo);
            this.tabPageThongTinHoaDon.Controls.Add(this.txtAddressBillTo);
            this.tabPageThongTinHoaDon.Controls.Add(this.txtSiteNumberBillTo);
            this.tabPageThongTinHoaDon.Controls.Add(this.cboHinhThucTT);
            this.tabPageThongTinHoaDon.Controls.Add(this.cboHinhThucTra);
            this.tabPageThongTinHoaDon.Controls.Add(this.label26);
            this.tabPageThongTinHoaDon.Controls.Add(this.label23);
            this.tabPageThongTinHoaDon.Controls.Add(this.label22);
            this.tabPageThongTinHoaDon.Controls.Add(this.label25);
            this.tabPageThongTinHoaDon.Controls.Add(this.label12);
            this.tabPageThongTinHoaDon.Controls.Add(this.label27);
            this.tabPageThongTinHoaDon.Controls.Add(this.label7);
            this.tabPageThongTinHoaDon.Controls.Add(this.label24);
            this.tabPageThongTinHoaDon.Controls.Add(this.label14);
            this.tabPageThongTinHoaDon.Controls.Add(this.label9);
            this.tabPageThongTinHoaDon.Controls.Add(this.txtSoPhieuXuat);
            this.tabPageThongTinHoaDon.Location = new System.Drawing.Point(4, 22);
            this.tabPageThongTinHoaDon.Name = "tabPageThongTinHoaDon";
            this.tabPageThongTinHoaDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageThongTinHoaDon.Size = new System.Drawing.Size(813, 183);
            this.tabPageThongTinHoaDon.TabIndex = 0;
            this.tabPageThongTinHoaDon.Text = "Thông tin hóa đơn";
            this.tabPageThongTinHoaDon.UseVisualStyleBackColor = true;
            // 
            // cboOrderType
            // 
            this.cboOrderType.BackColor = System.Drawing.Color.White;
            this.cboOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderType.DropDownWidth = 400;
            this.cboOrderType.Enabled = false;
            this.cboOrderType.FormattingEnabled = true;
            this.cboOrderType.Location = new System.Drawing.Point(104, 37);
            this.cboOrderType.Name = "cboOrderType";
            this.cboOrderType.Size = new System.Drawing.Size(279, 21);
            this.cboOrderType.TabIndex = 11;
            // 
            // cboDoiTuong
            // 
            this.cboDoiTuong.BackColor = System.Drawing.Color.White;
            this.cboDoiTuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoiTuong.DropDownWidth = 400;
            this.cboDoiTuong.Enabled = false;
            this.cboDoiTuong.FormattingEnabled = true;
            this.cboDoiTuong.Location = new System.Drawing.Point(104, 11);
            this.cboDoiTuong.Name = "cboDoiTuong";
            this.cboDoiTuong.Size = new System.Drawing.Size(279, 21);
            this.cboDoiTuong.TabIndex = 11;
            this.cboDoiTuong.SelectedIndexChanged += new System.EventHandler(this.cboDoiTuong_SelectedIndexChanged);
            // 
            // txtSiteNumberShipTo
            // 
            this.txtSiteNumberShipTo.BackColor = System.Drawing.Color.White;
            this.txtSiteNumberShipTo.Enabled = false;
            this.txtSiteNumberShipTo.Location = new System.Drawing.Point(104, 118);
            this.txtSiteNumberShipTo.MaxLength = 15;
            this.txtSiteNumberShipTo.Name = "txtSiteNumberShipTo";
            this.txtSiteNumberShipTo.Size = new System.Drawing.Size(134, 20);
            this.txtSiteNumberShipTo.TabIndex = 10;
            this.txtSiteNumberShipTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoTuoi_KeyPress);
            this.txtSiteNumberShipTo.Validating += new System.ComponentModel.CancelEventHandler(this.txtSite_Validating);
            // 
            // txtAddressShipTo
            // 
            this.txtAddressShipTo.BackColor = System.Drawing.Color.White;
            this.txtAddressShipTo.Enabled = false;
            this.txtAddressShipTo.Location = new System.Drawing.Point(104, 144);
            this.txtAddressShipTo.Name = "txtAddressShipTo";
            this.txtAddressShipTo.Size = new System.Drawing.Size(279, 20);
            this.txtAddressShipTo.TabIndex = 12;
            this.txtAddressShipTo.Validating += new System.ComponentModel.CancelEventHandler(this.txtSite_Validating);
            // 
            // txtAddressBillTo
            // 
            this.txtAddressBillTo.BackColor = System.Drawing.Color.White;
            this.txtAddressBillTo.Enabled = false;
            this.txtAddressBillTo.Location = new System.Drawing.Point(104, 90);
            this.txtAddressBillTo.Name = "txtAddressBillTo";
            this.txtAddressBillTo.Size = new System.Drawing.Size(279, 20);
            this.txtAddressBillTo.TabIndex = 8;
            this.txtAddressBillTo.Validating += new System.ComponentModel.CancelEventHandler(this.txtSite_Validating);
            // 
            // cboHinhThucTT
            // 
            this.cboHinhThucTT.BackColor = System.Drawing.Color.White;
            this.cboHinhThucTT.Enabled = false;
            this.cboHinhThucTT.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoản"});
            this.cboHinhThucTT.Location = new System.Drawing.Point(517, 64);
            this.cboHinhThucTT.Name = "cboHinhThucTT";
            this.cboHinhThucTT.Size = new System.Drawing.Size(266, 21);
            this.cboHinhThucTT.TabIndex = 7;
            this.cboHinhThucTT.Text = "Tiền mặt";
            // 
            // cboHinhThucTra
            // 
            this.cboHinhThucTra.BackColor = System.Drawing.Color.White;
            this.cboHinhThucTra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHinhThucTra.DropDownWidth = 300;
            this.cboHinhThucTra.Enabled = false;
            this.cboHinhThucTra.Location = new System.Drawing.Point(517, 91);
            this.cboHinhThucTra.Name = "cboHinhThucTra";
            this.cboHinhThucTra.Size = new System.Drawing.Size(266, 21);
            this.cboHinhThucTra.TabIndex = 9;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(434, 95);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(68, 13);
            this.label26.TabIndex = 0;
            this.label26.Text = "Hình thức trả";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 121);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(90, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "Địa chỉ giao hàng";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 42);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "Order Type";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(433, 68);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(70, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "Hình thức TT";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(244, 120);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(50, 13);
            this.label27.TabIndex = 0;
            this.label27.Text = "(Ship To)";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(244, 68);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(42, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "(Bill To)";
            // 
            // tabPageThongTinThem
            // 
            this.tabPageThongTinThem.Controls.Add(this.txtGhiChu);
            this.tabPageThongTinThem.Controls.Add(this.txtHoTen);
            this.tabPageThongTinThem.Controls.Add(this.label6);
            this.tabPageThongTinThem.Controls.Add(this.label2);
            this.tabPageThongTinThem.Controls.Add(this.cboGioiTinh);
            this.tabPageThongTinThem.Controls.Add(this.label16);
            this.tabPageThongTinThem.Controls.Add(this.txtDoTuoi);
            this.tabPageThongTinThem.Controls.Add(this.label17);
            this.tabPageThongTinThem.Controls.Add(this.cboQuyenSo);
            this.tabPageThongTinThem.Controls.Add(this.txtNganHang);
            this.tabPageThongTinThem.Controls.Add(this.txtSoSeri);
            this.tabPageThongTinThem.Controls.Add(this.txtDiaChi);
            this.tabPageThongTinThem.Controls.Add(this.label29);
            this.tabPageThongTinThem.Controls.Add(this.label3);
            this.tabPageThongTinThem.Controls.Add(this.label11);
            this.tabPageThongTinThem.Controls.Add(this.txtDienThoai);
            this.tabPageThongTinThem.Controls.Add(this.label4);
            this.tabPageThongTinThem.Controls.Add(this.label15);
            this.tabPageThongTinThem.Controls.Add(this.txtSoHoaDon);
            this.tabPageThongTinThem.Controls.Add(this.label28);
            this.tabPageThongTinThem.Controls.Add(this.label5);
            this.tabPageThongTinThem.Controls.Add(this.txtSoTaiKhoan);
            this.tabPageThongTinThem.Controls.Add(this.txtMaSoThue);
            this.tabPageThongTinThem.Controls.Add(this.label10);
            this.tabPageThongTinThem.Location = new System.Drawing.Point(4, 22);
            this.tabPageThongTinThem.Name = "tabPageThongTinThem";
            this.tabPageThongTinThem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageThongTinThem.Size = new System.Drawing.Size(813, 183);
            this.tabPageThongTinThem.TabIndex = 1;
            this.tabPageThongTinThem.Text = "Thông tin thêm";
            this.tabPageThongTinThem.UseVisualStyleBackColor = true;
            // 
            // txtNganHang
            // 
            this.txtNganHang.BackColor = System.Drawing.Color.White;
            this.txtNganHang.Enabled = false;
            this.txtNganHang.Location = new System.Drawing.Point(525, 134);
            this.txtNganHang.Name = "txtNganHang";
            this.txtNganHang.Size = new System.Drawing.Size(281, 20);
            this.txtNganHang.TabIndex = 19;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(446, 137);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(60, 13);
            this.label29.TabIndex = 0;
            this.label29.Text = "Ngân hàng";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(11, 143);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(67, 13);
            this.label28.TabIndex = 0;
            this.label28.Text = "Số tài khoản";
            // 
            // txtSoTaiKhoan
            // 
            this.txtSoTaiKhoan.BackColor = System.Drawing.Color.White;
            this.txtSoTaiKhoan.Enabled = false;
            this.txtSoTaiKhoan.Location = new System.Drawing.Point(84, 140);
            this.txtSoTaiKhoan.MaxLength = 30;
            this.txtSoTaiKhoan.Name = "txtSoTaiKhoan";
            this.txtSoTaiKhoan.Size = new System.Drawing.Size(150, 20);
            this.txtSoTaiKhoan.TabIndex = 22;
            this.txtSoTaiKhoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoTuoi_KeyPress);
            // 
            // MaSanPham
            // 
            this.MaSanPham.DataPropertyName = "MaSanPham";
            this.MaSanPham.HeaderText = "Mã sản phẩm";
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.ReadOnly = true;
            this.MaSanPham.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // TenSanPham
            // 
            this.TenSanPham.DataPropertyName = "TenSanPham";
            this.TenSanPham.HeaderText = "Tên sản phẩm";
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.ReadOnly = true;
            this.TenSanPham.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.TenSanPham.Width = 140;
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "TenDonViTinh";
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            this.DonViTinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DonViTinh.Width = 85;
            // 
            // SoLuong
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.SoLuong.DefaultCellStyle = dataGridViewCellStyle1;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SoLuong.Width = 80;
            // 
            // DonGia
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.DonGia.DefaultCellStyle = dataGridViewCellStyle2;
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TyLeChietKhau
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.TyLeChietKhau.DefaultCellStyle = dataGridViewCellStyle3;
            this.TyLeChietKhau.HeaderText = "CK(%)";
            this.TyLeChietKhau.Name = "TyLeChietKhau";
            this.TyLeChietKhau.ReadOnly = true;
            this.TyLeChietKhau.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TyLeChietKhau.Width = 50;
            // 
            // TienChietKhau
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.TienChietKhau.DefaultCellStyle = dataGridViewCellStyle4;
            this.TienChietKhau.HeaderText = "Tiền chiết khấu";
            this.TienChietKhau.Name = "TienChietKhau";
            this.TienChietKhau.ReadOnly = true;
            this.TienChietKhau.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TienChietKhau.Width = 110;
            // 
            // ThanhTien
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.ThanhTien.DefaultCellStyle = dataGridViewCellStyle5;
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ThanhTien.Width = 110;
            // 
            // IdSanPham
            // 
            this.IdSanPham.DataPropertyName = "IdSanPham";
            this.IdSanPham.HeaderText = "IdSanPham";
            this.IdSanPham.Name = "IdSanPham";
            this.IdSanPham.Visible = false;
            // 
            // IdChungTuChiTiet
            // 
            this.IdChungTuChiTiet.HeaderText = "IdChungTuChiTiet";
            this.IdChungTuChiTiet.Name = "IdChungTuChiTiet";
            this.IdChungTuChiTiet.Visible = false;
            // 
            // frm_HoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 616);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtTyLeVAT);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblTongTienThanhToan);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblTongTienSauChietKhau);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblTongTienVAT);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblTongTienChietKhau);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.btnChiTietChungTu);
            this.Controls.Add(this.btnXoaChiTiet);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.Name = "frm_HoaDonBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn bán hàng";
            this.Load += new System.EventHandler(this.frm_HoaDonBan_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_HoaDonBan_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageThongTinHoaDon.ResumeLayout(false);
            this.tabPageThongTinHoaDon.PerformLayout();
            this.tabPageThongTinThem.ResumeLayout(false);
            this.tabPageThongTinThem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnTruoc;
        private System.Windows.Forms.ToolStripButton btnSau;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnCapNhat;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnIn;
        private System.Windows.Forms.ToolStripButton btnDong;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TextBox txtMaSoThue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboKho;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.TextBox txtSoSeri;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSoHoaDon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSoPhieuXuat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private QLBH.Core.Form.GtidButton btnXoaChiTiet;
        private QLBH.Core.Form.GtidButton btnChiTietChungTu;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DateTimePicker dtNgayBan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTyLeVAT;
        private System.Windows.Forms.Label lblTongTienChietKhau;
        private System.Windows.Forms.Label lblTongTienSauChietKhau;
        private System.Windows.Forms.Label lblTongTienVAT;
        private System.Windows.Forms.Label lblTongTienThanhToan;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private QLBH.Core.Form.GtidButton btnLoad;
        private System.Windows.Forms.TextBox txtSiteNumberBillTo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboQuyenSo;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.TextBox txtDoTuoi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageThongTinHoaDon;
        private System.Windows.Forms.TabPage tabPageThongTinThem;
        private System.Windows.Forms.TextBox txtSiteNumberShipTo;
        private System.Windows.Forms.ComboBox cboHinhThucTra;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cboHinhThucTT;
        private System.Windows.Forms.TextBox txtAddressShipTo;
        private System.Windows.Forms.TextBox txtAddressBillTo;
        private System.Windows.Forms.ComboBox cboDoiTuong;
        private System.Windows.Forms.TextBox txtNganHang;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtSoTaiKhoan;
        private System.Windows.Forms.ComboBox cboOrderType;
        private System.Windows.Forms.ToolStripButton btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TyLeChietKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienChietKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdChungTuChiTiet;
    }
}
