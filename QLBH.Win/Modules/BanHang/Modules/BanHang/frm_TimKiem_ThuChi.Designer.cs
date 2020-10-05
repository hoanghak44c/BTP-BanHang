using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frm_TimKiem_ThuChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TimKiem_ThuChi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtNgayLapTo = new System.Windows.Forms.DateTimePicker();
            this.dtNgayLapFrom = new System.Windows.Forms.DateTimePicker();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.cboKho = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new GtidButton();
            this.txtNoiDungThuChi = new GtidTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblLoaiChi = new System.Windows.Forms.Label();
            this.cboLoaiThu = new System.Windows.Forms.ComboBox();
            this.cboDoiTuong = new System.Windows.Forms.ComboBox();
            this.txtSoTienTo = new GtidTextBox();
            this.txtSoTienFrom = new GtidTextBox();
            this.txtHoTen = new GtidTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoPhieu = new GtidTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.btnXoa = new GtidButton();
            this.btnGhi = new GtidButton();
            this.btnIn = new GtidButton();
            this.btnDong = new GtidButton();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguoiThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NganHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDungThuChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTienTe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TyGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoChungTuKem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChungTuGoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDoiTuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhThucThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm phiếu thu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtNgayLapTo);
            this.groupBox1.Controls.Add(this.dtNgayLapFrom);
            this.groupBox1.Controls.Add(this.cboNhanVien);
            this.groupBox1.Controls.Add(this.cboKho);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.txtNoiDungThuChi);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblLoaiChi);
            this.groupBox1.Controls.Add(this.cboLoaiThu);
            this.groupBox1.Controls.Add(this.cboDoiTuong);
            this.groupBox1.Controls.Add(this.txtSoTienTo);
            this.groupBox1.Controls.Add(this.txtSoTienFrom);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtSoPhieu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 163);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dtNgayLapTo
            // 
            this.dtNgayLapTo.CustomFormat = "dd/MM/yyyy";
            this.dtNgayLapTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayLapTo.Location = new System.Drawing.Point(503, 16);
            this.dtNgayLapTo.Name = "dtNgayLapTo";
            this.dtNgayLapTo.Size = new System.Drawing.Size(125, 20);
            this.dtNgayLapTo.TabIndex = 22;
            // 
            // dtNgayLapFrom
            // 
            this.dtNgayLapFrom.CustomFormat = "dd/MM/yyyy";
            this.dtNgayLapFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayLapFrom.Location = new System.Drawing.Point(331, 16);
            this.dtNgayLapFrom.Name = "dtNgayLapFrom";
            this.dtNgayLapFrom.Size = new System.Drawing.Size(125, 20);
            this.dtNgayLapFrom.TabIndex = 21;
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(73, 69);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(165, 21);
            this.cboNhanVien.TabIndex = 20;
            // 
            // cboKho
            // 
            this.cboKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKho.FormattingEnabled = true;
            this.cboKho.Location = new System.Drawing.Point(73, 17);
            this.cboKho.Name = "cboKho";
            this.cboKho.Size = new System.Drawing.Size(165, 21);
            this.cboKho.TabIndex = 19;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(566, 123);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 18;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtNoiDungThuChi
            // 
            this.txtNoiDungThuChi.Location = new System.Drawing.Point(331, 95);
            this.txtNoiDungThuChi.MaxLength = 250;
            this.txtNoiDungThuChi.Name = "txtNoiDungThuChi";
            this.txtNoiDungThuChi.Size = new System.Drawing.Size(310, 20);
            this.txtNoiDungThuChi.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(261, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Lý do thu";
            // 
            // lblLoaiChi
            // 
            this.lblLoaiChi.AutoSize = true;
            this.lblLoaiChi.Location = new System.Drawing.Point(6, 126);
            this.lblLoaiChi.Name = "lblLoaiChi";
            this.lblLoaiChi.Size = new System.Drawing.Size(45, 13);
            this.lblLoaiChi.TabIndex = 14;
            this.lblLoaiChi.Text = "Loại thu";
            // 
            // cboLoaiThu
            // 
            this.cboLoaiThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiThu.FormattingEnabled = true;
            this.cboLoaiThu.Location = new System.Drawing.Point(73, 123);
            this.cboLoaiThu.Name = "cboLoaiThu";
            this.cboLoaiThu.Size = new System.Drawing.Size(165, 21);
            this.cboLoaiThu.TabIndex = 15;
            // 
            // cboDoiTuong
            // 
            this.cboDoiTuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoiTuong.FormattingEnabled = true;
            this.cboDoiTuong.Location = new System.Drawing.Point(73, 96);
            this.cboDoiTuong.Name = "cboDoiTuong";
            this.cboDoiTuong.Size = new System.Drawing.Size(165, 21);
            this.cboDoiTuong.TabIndex = 13;
            // 
            // txtSoTienTo
            // 
            this.txtSoTienTo.Location = new System.Drawing.Point(503, 43);
            this.txtSoTienTo.MaxLength = 15;
            this.txtSoTienTo.Name = "txtSoTienTo";
            this.txtSoTienTo.Size = new System.Drawing.Size(138, 20);
            this.txtSoTienTo.TabIndex = 12;
            this.txtSoTienTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoTienTo.Leave += new System.EventHandler(this.txtSoThuc_Leave);
            this.txtSoTienTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDouble_KeyPress);
            // 
            // txtSoTienFrom
            // 
            this.txtSoTienFrom.Location = new System.Drawing.Point(331, 43);
            this.txtSoTienFrom.MaxLength = 15;
            this.txtSoTienFrom.Name = "txtSoTienFrom";
            this.txtSoTienFrom.Size = new System.Drawing.Size(134, 20);
            this.txtSoTienFrom.TabIndex = 12;
            this.txtSoTienFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoTienFrom.Leave += new System.EventHandler(this.txtSoThuc_Leave);
            this.txtSoTienFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDouble_KeyPress);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(331, 69);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(310, 20);
            this.txtHoTen.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(261, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tên";
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Location = new System.Drawing.Point(73, 43);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(165, 20);
            this.txtSoPhieu.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số phiếu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(471, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "đến";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tiền thu từ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thu từ ngày";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Đối tượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kho";
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AllowUserToOrderColumns = true;
            this.dgvResult.BackgroundColor = System.Drawing.Color.White;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.SoPhieu,
            this.NguoiThu,
            this.NgayLap,
            this.HoTen,
            this.SoTien,
            this.IdPhieu,
            this.DiaChi,
            this.SoTaiKhoan,
            this.NganHang,
            this.NoiDungThuChi,
            this.IdTienTe,
            this.TyGia,
            this.SoTienChu,
            this.SoChungTuKem,
            this.ChungTuGoc,
            this.Type,
            this.TrangThai,
            this.IdKho,
            this.IdNhanVien,
            this.IdDoiTuong,
            this.HinhThucThanhToan});
            this.dgvResult.Location = new System.Drawing.Point(12, 209);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.Size = new System.Drawing.Size(650, 214);
            this.dgvResult.TabIndex = 2;
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(238, 454);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 25);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "   &Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.Image")));
            this.btnGhi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGhi.Location = new System.Drawing.Point(154, 454);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(80, 25);
            this.btnGhi.TabIndex = 5;
            this.btnGhi.Text = "    &Cập nhật";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnIn
            // 
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(322, 454);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(80, 25);
            this.btnIn.TabIndex = 7;
            this.btnIn.Text = "  &In phiếu";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(406, 454);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(80, 25);
            this.btnDong.TabIndex = 8;
            this.btnDong.Text = "   T&hoát";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "SoTT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.STT.Width = 50;
            // 
            // SoPhieu
            // 
            this.SoPhieu.DataPropertyName = "SoPhieu";
            this.SoPhieu.HeaderText = "Số";
            this.SoPhieu.Name = "SoPhieu";
            this.SoPhieu.ReadOnly = true;
            // 
            // NguoiThu
            // 
            this.NguoiThu.DataPropertyName = "NguoiThu";
            this.NguoiThu.HeaderText = "Người thu";
            this.NguoiThu.Name = "NguoiThu";
            this.NguoiThu.ReadOnly = true;
            this.NguoiThu.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NguoiThu.Width = 150;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.NgayLap.DefaultCellStyle = dataGridViewCellStyle1;
            this.NgayLap.HeaderText = "Ngày thu";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Đối tượng";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.HoTen.Width = 200;
            // 
            // SoTien
            // 
            this.SoTien.DataPropertyName = "SoTien";
            this.SoTien.HeaderText = "Số Tiền";
            this.SoTien.Name = "SoTien";
            this.SoTien.ReadOnly = true;
            // 
            // IdPhieu
            // 
            this.IdPhieu.DataPropertyName = "IdPhieu";
            this.IdPhieu.HeaderText = "IdPhieu";
            this.IdPhieu.Name = "IdPhieu";
            this.IdPhieu.ReadOnly = true;
            this.IdPhieu.Visible = false;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "DiaChi";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Visible = false;
            // 
            // SoTaiKhoan
            // 
            this.SoTaiKhoan.DataPropertyName = "SoTaiKhoan";
            this.SoTaiKhoan.HeaderText = "SoTaiKhoan";
            this.SoTaiKhoan.Name = "SoTaiKhoan";
            this.SoTaiKhoan.ReadOnly = true;
            this.SoTaiKhoan.Visible = false;
            // 
            // NganHang
            // 
            this.NganHang.DataPropertyName = "NganHang";
            this.NganHang.HeaderText = "NganHang";
            this.NganHang.Name = "NganHang";
            this.NganHang.ReadOnly = true;
            this.NganHang.Visible = false;
            // 
            // NoiDungThuChi
            // 
            this.NoiDungThuChi.DataPropertyName = "NoiDungThuChi";
            this.NoiDungThuChi.HeaderText = "NoiDungThuChi";
            this.NoiDungThuChi.Name = "NoiDungThuChi";
            this.NoiDungThuChi.ReadOnly = true;
            this.NoiDungThuChi.Visible = false;
            // 
            // IdTienTe
            // 
            this.IdTienTe.DataPropertyName = "IdTienTe";
            this.IdTienTe.HeaderText = "IdTienTe";
            this.IdTienTe.Name = "IdTienTe";
            this.IdTienTe.ReadOnly = true;
            this.IdTienTe.Visible = false;
            // 
            // TyGia
            // 
            this.TyGia.DataPropertyName = "TyGia";
            this.TyGia.HeaderText = "TyGia";
            this.TyGia.Name = "TyGia";
            this.TyGia.ReadOnly = true;
            this.TyGia.Visible = false;
            // 
            // SoTienChu
            // 
            this.SoTienChu.DataPropertyName = "SoTienChu";
            this.SoTienChu.HeaderText = "SoTienChu";
            this.SoTienChu.Name = "SoTienChu";
            this.SoTienChu.ReadOnly = true;
            this.SoTienChu.Visible = false;
            // 
            // SoChungTuKem
            // 
            this.SoChungTuKem.DataPropertyName = "SoChungTuKem";
            this.SoChungTuKem.HeaderText = "SoChungTuKem";
            this.SoChungTuKem.Name = "SoChungTuKem";
            this.SoChungTuKem.ReadOnly = true;
            this.SoChungTuKem.Visible = false;
            // 
            // ChungTuGoc
            // 
            this.ChungTuGoc.DataPropertyName = "ChungTuGoc";
            this.ChungTuGoc.HeaderText = "ChungTuGoc";
            this.ChungTuGoc.Name = "ChungTuGoc";
            this.ChungTuGoc.ReadOnly = true;
            this.ChungTuGoc.Visible = false;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Visible = false;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "TrangThai";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Visible = false;
            // 
            // IdKho
            // 
            this.IdKho.DataPropertyName = "IdKho";
            this.IdKho.HeaderText = "IdKho";
            this.IdKho.Name = "IdKho";
            this.IdKho.ReadOnly = true;
            this.IdKho.Visible = false;
            // 
            // IdNhanVien
            // 
            this.IdNhanVien.DataPropertyName = "IdNhanVien";
            this.IdNhanVien.HeaderText = "IdNhanVien";
            this.IdNhanVien.Name = "IdNhanVien";
            this.IdNhanVien.ReadOnly = true;
            this.IdNhanVien.Visible = false;
            // 
            // IdDoiTuong
            // 
            this.IdDoiTuong.DataPropertyName = "IdDoiTuong";
            this.IdDoiTuong.HeaderText = "IdDoiTuong";
            this.IdDoiTuong.Name = "IdDoiTuong";
            this.IdDoiTuong.ReadOnly = true;
            this.IdDoiTuong.Visible = false;
            // 
            // HinhThucThanhToan
            // 
            this.HinhThucThanhToan.DataPropertyName = "HinhThucThanhToan";
            this.HinhThucThanhToan.HeaderText = "HinhThucThanhToan";
            this.HinhThucThanhToan.Name = "HinhThucThanhToan";
            this.HinhThucThanhToan.ReadOnly = true;
            this.HinhThucThanhToan.Visible = false;
            // 
            // frm_TimKiem_ThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 491);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_TimKiem_ThuChi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.frm_TimKiem_ThuChi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        internal QLBH.Core.Form.GtidButton btnXoa;
        internal QLBH.Core.Form.GtidButton btnGhi;
        internal QLBH.Core.Form.GtidButton btnIn;
        internal QLBH.Core.Form.GtidButton btnDong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoTienTo;
        private System.Windows.Forms.TextBox txtSoTienFrom;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboDoiTuong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblLoaiChi;
        private System.Windows.Forms.ComboBox cboLoaiThu;
        private System.Windows.Forms.TextBox txtNoiDungThuChi;
        private System.Windows.Forms.Label label11;
        private QLBH.Core.Form.GtidButton btnTimKiem;
        private System.Windows.Forms.ComboBox cboKho;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.DateTimePicker dtNgayLapTo;
        private System.Windows.Forms.DateTimePicker dtNgayLapFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguoiThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NganHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDungThuChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTienTe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TyGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoChungTuKem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChungTuGoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDoiTuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhThucThanhToan;
    }
}