using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frmPhieuThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuThu));
            this.lblSoPhieu = new System.Windows.Forms.Label();
            this.lblNguoiNop = new System.Windows.Forms.Label();
            this.lblLoaiChi = new System.Windows.Forms.Label();
            this.lblTK = new System.Windows.Forms.Label();
            this.lblLyDo = new System.Windows.Forms.Label();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.lblNgayChi = new System.Windows.Forms.Label();
            this.lblNhaCC = new System.Windows.Forms.Label();
            this.lblLoaiTien = new System.Windows.Forms.Label();
            this.lblTyGia = new System.Windows.Forms.Label();
            this.cboNguoiNhan = new System.Windows.Forms.ComboBox();
            this.cboLoaiThu = new System.Windows.Forms.ComboBox();
            this.cboDoiTuong = new System.Windows.Forms.ComboBox();
            this.cboLoaiTien = new System.Windows.Forms.ComboBox();
            this.btnCapNhat = new QLBH.Core.Form.GtidButton();
            this.btnThemMoi = new QLBH.Core.Form.GtidButton();
            this.grbPhieuThu = new System.Windows.Forms.GroupBox();
            this.txtNganHang = new QLBH.Core.Form.GtidTextBox();
            this.txtSoTaiKhoan = new QLBH.Core.Form.GtidTextBox();
            this.txtSoTienChu = new QLBH.Core.Form.GtidTextBox();
            this.txtNoiDungThuChi = new QLBH.Core.Form.GtidTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoChungTuKem = new QLBH.Core.Form.GtidTextBox();
            this.txtSoTien = new QLBH.Core.Form.GtidTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTyGia = new QLBH.Core.Form.GtidTextBox();
            this.txtChungTuGoc = new QLBH.Core.Form.GtidTextBox();
            this.lblCTKT = new System.Windows.Forms.Label();
            this.lblCTKem = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboHinhThucThanhToan = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new QLBH.Core.Form.GtidTextBox();
            this.txtSoPhieu = new QLBH.Core.Form.GtidTextBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHoTen = new QLBH.Core.Form.GtidTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNhomDoiTuong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboKho = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbPrev = new System.Windows.Forms.ToolStripButton();
            this.tsbNext = new System.Windows.Forms.ToolStripButton();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.grbPhieuThu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSoPhieu
            // 
            this.lblSoPhieu.AutoSize = true;
            this.lblSoPhieu.Location = new System.Drawing.Point(10, 28);
            this.lblSoPhieu.Name = "lblSoPhieu";
            this.lblSoPhieu.Size = new System.Drawing.Size(48, 13);
            this.lblSoPhieu.TabIndex = 0;
            this.lblSoPhieu.Text = "Số phiếu";
            // 
            // lblNguoiNop
            // 
            this.lblNguoiNop.AutoSize = true;
            this.lblNguoiNop.Location = new System.Drawing.Point(4, 73);
            this.lblNguoiNop.Name = "lblNguoiNop";
            this.lblNguoiNop.Size = new System.Drawing.Size(83, 13);
            this.lblNguoiNop.TabIndex = 0;
            this.lblNguoiNop.Text = "Người nhận tiền";
            // 
            // lblLoaiChi
            // 
            this.lblLoaiChi.AutoSize = true;
            this.lblLoaiChi.Location = new System.Drawing.Point(420, 73);
            this.lblLoaiChi.Name = "lblLoaiChi";
            this.lblLoaiChi.Size = new System.Drawing.Size(45, 13);
            this.lblLoaiChi.TabIndex = 0;
            this.lblLoaiChi.Text = "Loại thu";
            // 
            // lblTK
            // 
            this.lblTK.AutoSize = true;
            this.lblTK.Location = new System.Drawing.Point(6, 21);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(66, 13);
            this.lblTK.TabIndex = 0;
            this.lblTK.Text = "Số tài khoản";
            // 
            // lblLyDo
            // 
            this.lblLyDo.AutoSize = true;
            this.lblLyDo.Location = new System.Drawing.Point(10, 58);
            this.lblLyDo.Name = "lblLyDo";
            this.lblLyDo.Size = new System.Drawing.Size(39, 13);
            this.lblLyDo.TabIndex = 0;
            this.lblLyDo.Text = "Địa chỉ";
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Location = new System.Drawing.Point(5, 149);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(40, 13);
            this.lblSoTien.TabIndex = 0;
            this.lblSoTien.Text = "Số tiền";
            // 
            // lblNgayChi
            // 
            this.lblNgayChi.AutoSize = true;
            this.lblNgayChi.Location = new System.Drawing.Point(10, 54);
            this.lblNgayChi.Name = "lblNgayChi";
            this.lblNgayChi.Size = new System.Drawing.Size(49, 13);
            this.lblNgayChi.TabIndex = 0;
            this.lblNgayChi.Text = "Ngày lập";
            // 
            // lblNhaCC
            // 
            this.lblNhaCC.AutoSize = true;
            this.lblNhaCC.Location = new System.Drawing.Point(11, 25);
            this.lblNhaCC.Name = "lblNhaCC";
            this.lblNhaCC.Size = new System.Drawing.Size(25, 13);
            this.lblNhaCC.TabIndex = 0;
            this.lblNhaCC.Text = "Tên";
            // 
            // lblLoaiTien
            // 
            this.lblLoaiTien.AutoSize = true;
            this.lblLoaiTien.Location = new System.Drawing.Point(334, 150);
            this.lblLoaiTien.Name = "lblLoaiTien";
            this.lblLoaiTien.Size = new System.Drawing.Size(47, 13);
            this.lblLoaiTien.TabIndex = 0;
            this.lblLoaiTien.Text = "Loại tiền";
            // 
            // lblTyGia
            // 
            this.lblTyGia.AutoSize = true;
            this.lblTyGia.Location = new System.Drawing.Point(509, 150);
            this.lblTyGia.Name = "lblTyGia";
            this.lblTyGia.Size = new System.Drawing.Size(36, 13);
            this.lblTyGia.TabIndex = 0;
            this.lblTyGia.Text = "Tỷ giá";
            // 
            // cboNguoiNhan
            // 
            this.cboNguoiNhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNguoiNhan.FormattingEnabled = true;
            this.cboNguoiNhan.Location = new System.Drawing.Point(92, 70);
            this.cboNguoiNhan.Name = "cboNguoiNhan";
            this.cboNguoiNhan.Size = new System.Drawing.Size(298, 21);
            this.cboNguoiNhan.TabIndex = 10;
            this.cboNguoiNhan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboNguoiNhan_KeyDown);
            // 
            // cboLoaiThu
            // 
            this.cboLoaiThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiThu.FormattingEnabled = true;
            this.cboLoaiThu.Location = new System.Drawing.Point(471, 70);
            this.cboLoaiThu.Name = "cboLoaiThu";
            this.cboLoaiThu.Size = new System.Drawing.Size(207, 21);
            this.cboLoaiThu.TabIndex = 11;
            this.cboLoaiThu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboLoaiThu_KeyDown);
            // 
            // cboDoiTuong
            // 
            this.cboDoiTuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoiTuong.FormattingEnabled = true;
            this.cboDoiTuong.Location = new System.Drawing.Point(69, 20);
            this.cboDoiTuong.Name = "cboDoiTuong";
            this.cboDoiTuong.Size = new System.Drawing.Size(165, 21);
            this.cboDoiTuong.TabIndex = 2;
            this.cboDoiTuong.SelectedIndexChanged += new System.EventHandler(this.cboDoiTuong_SelectedIndexChanged);
            // 
            // cboLoaiTien
            // 
            this.cboLoaiTien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiTien.FormattingEnabled = true;
            this.cboLoaiTien.Location = new System.Drawing.Point(388, 146);
            this.cboLoaiTien.Name = "cboLoaiTien";
            this.cboLoaiTien.Size = new System.Drawing.Size(93, 21);
            this.cboLoaiTien.TabIndex = 14;
            this.cboLoaiTien.SelectedIndexChanged += new System.EventHandler(this.cboLoaiTien_SelectedIndexChanged);
            this.cboLoaiTien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboLoaiTien_KeyDown);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(0, 19);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 0;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(0, 19);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 0;
            // 
            // grbPhieuThu
            // 
            this.grbPhieuThu.Controls.Add(this.txtNganHang);
            this.grbPhieuThu.Controls.Add(this.txtSoTaiKhoan);
            this.grbPhieuThu.Controls.Add(this.txtSoTienChu);
            this.grbPhieuThu.Controls.Add(this.txtNoiDungThuChi);
            this.grbPhieuThu.Controls.Add(this.label4);
            this.grbPhieuThu.Controls.Add(this.label1);
            this.grbPhieuThu.Controls.Add(this.txtSoChungTuKem);
            this.grbPhieuThu.Controls.Add(this.txtSoTien);
            this.grbPhieuThu.Controls.Add(this.label5);
            this.grbPhieuThu.Controls.Add(this.lblNguoiNop);
            this.grbPhieuThu.Controls.Add(this.txtTyGia);
            this.grbPhieuThu.Controls.Add(this.txtChungTuGoc);
            this.grbPhieuThu.Controls.Add(this.lblCTKT);
            this.grbPhieuThu.Controls.Add(this.lblCTKem);
            this.grbPhieuThu.Controls.Add(this.lblTK);
            this.grbPhieuThu.Controls.Add(this.lblSoTien);
            this.grbPhieuThu.Controls.Add(this.label6);
            this.grbPhieuThu.Controls.Add(this.lblLoaiChi);
            this.grbPhieuThu.Controls.Add(this.lblLoaiTien);
            this.grbPhieuThu.Controls.Add(this.lblTyGia);
            this.grbPhieuThu.Controls.Add(this.cboHinhThucThanhToan);
            this.grbPhieuThu.Controls.Add(this.cboLoaiThu);
            this.grbPhieuThu.Controls.Add(this.cboNguoiNhan);
            this.grbPhieuThu.Controls.Add(this.cboLoaiTien);
            this.grbPhieuThu.Location = new System.Drawing.Point(12, 188);
            this.grbPhieuThu.Name = "grbPhieuThu";
            this.grbPhieuThu.Size = new System.Drawing.Size(692, 232);
            this.grbPhieuThu.TabIndex = 2;
            this.grbPhieuThu.TabStop = false;
            this.grbPhieuThu.Text = "Chi tiết";
            // 
            // txtNganHang
            // 
            this.txtNganHang.Location = new System.Drawing.Point(92, 44);
            this.txtNganHang.Name = "txtNganHang";
            this.txtNganHang.Size = new System.Drawing.Size(586, 21);
            this.txtNganHang.TabIndex = 9;
            // 
            // txtSoTaiKhoan
            // 
            this.txtSoTaiKhoan.Location = new System.Drawing.Point(93, 18);
            this.txtSoTaiKhoan.Name = "txtSoTaiKhoan";
            this.txtSoTaiKhoan.Size = new System.Drawing.Size(297, 21);
            this.txtSoTaiKhoan.TabIndex = 7;
            this.txtSoTaiKhoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTaiKhoan_KeyPress);
            // 
            // txtSoTienChu
            // 
            this.txtSoTienChu.Location = new System.Drawing.Point(92, 172);
            this.txtSoTienChu.Name = "txtSoTienChu";
            this.txtSoTienChu.Size = new System.Drawing.Size(586, 21);
            this.txtSoTienChu.TabIndex = 16;
            // 
            // txtNoiDungThuChi
            // 
            this.txtNoiDungThuChi.Location = new System.Drawing.Point(92, 97);
            this.txtNoiDungThuChi.MaxLength = 250;
            this.txtNoiDungThuChi.Multiline = true;
            this.txtNoiDungThuChi.Name = "txtNoiDungThuChi";
            this.txtNoiDungThuChi.Size = new System.Drawing.Size(586, 43);
            this.txtNoiDungThuChi.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Số tiền chữ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ngân hàng";
            // 
            // txtSoChungTuKem
            // 
            this.txtSoChungTuKem.Location = new System.Drawing.Point(92, 198);
            this.txtSoChungTuKem.MaxLength = 15;
            this.txtSoChungTuKem.Name = "txtSoChungTuKem";
            this.txtSoChungTuKem.Size = new System.Drawing.Size(227, 21);
            this.txtSoChungTuKem.TabIndex = 17;
            this.txtSoChungTuKem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoChungTuKem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCTKem_KeyPress);
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(92, 146);
            this.txtSoTien.MaxLength = 15;
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(227, 21);
            this.txtSoTien.TabIndex = 13;
            this.txtSoTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoTien.TextChanged += new System.EventHandler(this.txtSoTien_TextChanged);
            this.txtSoTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDouble_KeyPress);
            this.txtSoTien.LostFocus += new System.EventHandler(this.txtSoThuc_LostFocus);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lý do thu";
            // 
            // txtTyGia
            // 
            this.txtTyGia.Location = new System.Drawing.Point(553, 146);
            this.txtTyGia.MaxLength = 15;
            this.txtTyGia.Name = "txtTyGia";
            this.txtTyGia.Size = new System.Drawing.Size(125, 21);
            this.txtTyGia.TabIndex = 15;
            this.txtTyGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTyGia.TextChanged += new System.EventHandler(this.txtTyGia_TextChanged);
            this.txtTyGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDouble_KeyPress);
            this.txtTyGia.LostFocus += new System.EventHandler(this.txtSoThuc_LostFocus);
            // 
            // txtChungTuGoc
            // 
            this.txtChungTuGoc.Location = new System.Drawing.Point(388, 198);
            this.txtChungTuGoc.MaxLength = 250;
            this.txtChungTuGoc.Name = "txtChungTuGoc";
            this.txtChungTuGoc.Size = new System.Drawing.Size(290, 21);
            this.txtChungTuGoc.TabIndex = 18;
            // 
            // lblCTKT
            // 
            this.lblCTKT.AutoSize = true;
            this.lblCTKT.Location = new System.Drawing.Point(336, 202);
            this.lblCTKT.Name = "lblCTKT";
            this.lblCTKT.Size = new System.Drawing.Size(40, 13);
            this.lblCTKT.TabIndex = 0;
            this.lblCTKT.Text = "CT gốc";
            // 
            // lblCTKem
            // 
            this.lblCTKem.AutoSize = true;
            this.lblCTKem.Location = new System.Drawing.Point(5, 202);
            this.lblCTKem.Name = "lblCTKem";
            this.lblCTKem.Size = new System.Drawing.Size(82, 13);
            this.lblCTKem.TabIndex = 0;
            this.lblCTKem.Text = "Số CT kèm theo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hình thức TT";
            // 
            // cboHinhThucThanhToan
            // 
            this.cboHinhThucThanhToan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHinhThucThanhToan.FormattingEnabled = true;
            this.cboHinhThucThanhToan.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoản"});
            this.cboHinhThucThanhToan.Location = new System.Drawing.Point(471, 17);
            this.cboHinhThucThanhToan.Name = "cboHinhThucThanhToan";
            this.cboHinhThucThanhToan.Size = new System.Drawing.Size(207, 21);
            this.cboHinhThucThanhToan.TabIndex = 8;
            this.cboHinhThucThanhToan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboLoaiThu_KeyDown);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(69, 46);
            this.txtDiaChi.MaxLength = 250;
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(399, 52);
            this.txtDiaChi.TabIndex = 4;
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Location = new System.Drawing.Point(66, 21);
            this.txtSoPhieu.MaxLength = 10;
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(125, 21);
            this.txtSoPhieu.TabIndex = 5;
            this.txtSoPhieu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCTKem_KeyPress);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTieuDe.Location = new System.Drawing.Point(14, 34);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(150, 24);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "LẬP PHIẾU THU";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtNgayLap);
            this.groupBox1.Controls.Add(this.txtSoPhieu);
            this.groupBox1.Controls.Add(this.lblSoPhieu);
            this.groupBox1.Controls.Add(this.lblNgayChi);
            this.groupBox1.Location = new System.Drawing.Point(499, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 110);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chứng từ";
            // 
            // dtNgayLap
            // 
            this.dtNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayLap.Location = new System.Drawing.Point(66, 47);
            this.dtNgayLap.Name = "dtNgayLap";
            this.dtNgayLap.Size = new System.Drawing.Size(125, 21);
            this.dtNgayLap.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Controls.Add(this.cboDoiTuong);
            this.groupBox2.Controls.Add(this.lblNhaCC);
            this.groupBox2.Controls.Add(this.lblLyDo);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Location = new System.Drawing.Point(12, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 109);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đối tượng";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(240, 20);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(228, 21);
            this.txtHoTen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhóm đối tượng";
            // 
            // cboNhomDoiTuong
            // 
            this.cboNhomDoiTuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhomDoiTuong.FormattingEnabled = true;
            this.cboNhomDoiTuong.Items.AddRange(new object[] {
            "Khách hàng",
            "Đại lý",
            "Đối tác",
            "Nhân viên",
            "Đối tượng khác"});
            this.cboNhomDoiTuong.Location = new System.Drawing.Point(559, 37);
            this.cboNhomDoiTuong.Name = "cboNhomDoiTuong";
            this.cboNhomDoiTuong.Size = new System.Drawing.Size(145, 21);
            this.cboNhomDoiTuong.TabIndex = 1;
            this.cboNhomDoiTuong.SelectedIndexChanged += new System.EventHandler(this.cboNhomDoiTuong_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(244, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kho";
            // 
            // cboKho
            // 
            this.cboKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKho.FormattingEnabled = true;
            this.cboKho.Location = new System.Drawing.Point(294, 37);
            this.cboKho.Name = "cboKho";
            this.cboKho.Size = new System.Drawing.Size(145, 21);
            this.cboKho.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPrev,
            this.tsbNext,
            this.tsbAdd,
            this.tsbEdit,
            this.tsbUpdate,
            this.tsbDelete,
            this.tsbPrint,
            this.tsbClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(716, 25);
            this.toolStrip1.TabIndex = 87;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbPrev
            // 
            this.tsbPrev.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrev.Image")));
            this.tsbPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrev.Name = "tsbPrev";
            this.tsbPrev.Size = new System.Drawing.Size(85, 22);
            this.tsbPrev.Text = "&Trước (F3)";
            this.tsbPrev.Click += new System.EventHandler(this.tsbPrev_Click);
            // 
            // tsbNext
            // 
            this.tsbNext.Image = ((System.Drawing.Image)(resources.GetObject("tsbNext.Image")));
            this.tsbNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNext.Name = "tsbNext";
            this.tsbNext.Size = new System.Drawing.Size(74, 22);
            this.tsbNext.Text = "S&au (F4)";
            this.tsbNext.Click += new System.EventHandler(this.tsbNext_Click);
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(109, 22);
            this.tsbAdd.Text = "Thêm &mới (F5)";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(75, 22);
            this.tsbEdit.Text = "&Sửa (F6)";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbUpdate
            // 
            this.tsbUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdate.Image")));
            this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdate.Name = "tsbUpdate";
            this.tsbUpdate.Size = new System.Drawing.Size(102, 22);
            this.tsbUpdate.Text = "Cập nhật (F7)";
            this.tsbUpdate.Click += new System.EventHandler(this.tsbUpdate_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(73, 22);
            this.tsbDelete.Text = "&Xóa (F8)";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbPrint
            // 
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(96, 22);
            this.tsbPrint.Text = "&In phiếu (F9)";
            this.tsbPrint.Click += new System.EventHandler(this.tsbPrint_Click);
            // 
            // tsbClose
            // 
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(89, 22);
            this.tsbClose.Text = "Đ&óng (F12)";
            this.tsbClose.ToolTipText = "Đóng (F12)";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // frmPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 430);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cboKho);
            this.Controls.Add(this.cboNhomDoiTuong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.grbPhieuThu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPhieuThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu thu";
            this.Load += new System.EventHandler(this.frmPhieuThu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPhieuThu_KeyDown);
            this.grbPhieuThu.ResumeLayout(false);
            this.grbPhieuThu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal QLBH.Core.Form.GtidButton btnCapNhat;
        private System.Windows.Forms.TableLayoutPanel tbllaypalThucThi;
        internal QLBH.Core.Form.GtidButton btnThemMoi;
        private System.Windows.Forms.Label lblSoPhieu;
        private System.Windows.Forms.Label lblNguoiNop;
        private System.Windows.Forms.Label lblLoaiChi;
        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.Label lblLyDo;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.Label lblNgayChi;
        private System.Windows.Forms.Label lblNhaCC;
        private System.Windows.Forms.Label lblLoaiTien;
        private System.Windows.Forms.Label lblTyGia;
        private System.Windows.Forms.ComboBox cboNguoiNhan;
        private System.Windows.Forms.ComboBox cboLoaiThu;
        private System.Windows.Forms.ComboBox cboDoiTuong;
        private System.Windows.Forms.ComboBox cboLoaiTien;
        private System.Windows.Forms.GroupBox grbPhieuThu;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblCTKT;
        private System.Windows.Forms.Label lblCTKem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboNhomDoiTuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboKho;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboHinhThucThanhToan;
        private System.Windows.Forms.DateTimePicker dtNgayLap;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbPrev;
        private System.Windows.Forms.ToolStripButton tsbNext;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbUpdate;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private GtidTextBox txtSoPhieu;
        private GtidTextBox txtDiaChi;
        private GtidTextBox txtChungTuGoc;
        private GtidTextBox txtTyGia;
        private GtidTextBox txtSoChungTuKem;
        private GtidTextBox txtSoTien;
        private GtidTextBox txtSoTienChu;
        private GtidTextBox txtNganHang;
        private GtidTextBox txtSoTaiKhoan;
        private GtidTextBox txtHoTen;
        private GtidTextBox txtNoiDungThuChi;


    }
}