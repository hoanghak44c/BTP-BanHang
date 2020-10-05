using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frm_TimKiem_ChungTu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TimKiem_ChungTu));
            this.label1 = new System.Windows.Forms.Label();
            this.cboLoaiChungTu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboKho = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboDoiTuong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKyHieuHD = new GtidTextBox();
            this.txtHoTen = new GtidTextBox();
            this.txtNoiDung = new GtidTextBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.SoChungTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiChungTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoiTuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhoHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdChungTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiem = new GtidButton();
            this.btnXoa = new GtidButton();
            this.btnGhi = new GtidButton();
            this.btnDong = new GtidButton();
            this.dtNgayLapTu = new System.Windows.Forms.DateTimePicker();
            this.dtNgayLapDen = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSoSeri = new GtidTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSoPX = new GtidTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaSP = new GtidTextBox();
            this.txtTenSP = new GtidTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại chứng từ";
            // 
            // cboLoaiChungTu
            // 
            this.cboLoaiChungTu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiChungTu.FormattingEnabled = true;
            this.cboLoaiChungTu.Items.AddRange(new object[] {
            "Xuất bán",
            "Xuất điều chuyển",
            "Xuất hủy tiêu hao",
            "Xuất khác",
            "Nhập trả lại"});
            this.cboLoaiChungTu.Location = new System.Drawing.Point(90, 20);
            this.cboLoaiChungTu.Name = "cboLoaiChungTu";
            this.cboLoaiChungTu.Size = new System.Drawing.Size(188, 21);
            this.cboLoaiChungTu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kho";
            // 
            // cboKho
            // 
            this.cboKho.DropDownWidth = 300;
            this.cboKho.FormattingEnabled = true;
            this.cboKho.Location = new System.Drawing.Point(90, 46);
            this.cboKho.Name = "cboKho";
            this.cboKho.Size = new System.Drawing.Size(188, 21);
            this.cboKho.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhân viên";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownWidth = 300;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(90, 73);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(188, 21);
            this.cboNhanVien.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đối tượng";
            // 
            // cboDoiTuong
            // 
            this.cboDoiTuong.DropDownWidth = 400;
            this.cboDoiTuong.FormattingEnabled = true;
            this.cboDoiTuong.Location = new System.Drawing.Point(90, 99);
            this.cboDoiTuong.Name = "cboDoiTuong";
            this.cboDoiTuong.Size = new System.Drawing.Size(188, 21);
            this.cboDoiTuong.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên SP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ký hiệu HĐ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày lập từ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(595, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "đến";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(296, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Họ tên";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nội dung";
            // 
            // txtKyHieuHD
            // 
            this.txtKyHieuHD.Location = new System.Drawing.Point(363, 20);
            this.txtKyHieuHD.Name = "txtKyHieuHD";
            this.txtKyHieuHD.Size = new System.Drawing.Size(211, 20);
            this.txtKyHieuHD.TabIndex = 9;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(363, 71);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(211, 20);
            this.txtHoTen.TabIndex = 9;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(90, 126);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(764, 70);
            this.txtNoiDung.TabIndex = 9;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoChungTu,
            this.LoaiChungTu,
            this.NgayLap,
            this.NhanVien,
            this.DoiTuong,
            this.KhoHang,
            this.IdChungTu});
            this.dgvList.Location = new System.Drawing.Point(12, 247);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 20;
            this.dgvList.Size = new System.Drawing.Size(842, 227);
            this.dgvList.TabIndex = 10;
            // 
            // SoChungTu
            // 
            this.SoChungTu.DataPropertyName = "SoChungTu";
            this.SoChungTu.HeaderText = "Ký hiệu HĐ";
            this.SoChungTu.Name = "SoChungTu";
            this.SoChungTu.ReadOnly = true;
            // 
            // LoaiChungTu
            // 
            this.LoaiChungTu.DataPropertyName = "LoaiChungTu";
            this.LoaiChungTu.HeaderText = "Loại chứng từ";
            this.LoaiChungTu.Name = "LoaiChungTu";
            this.LoaiChungTu.ReadOnly = true;
            this.LoaiChungTu.Visible = false;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.NgayLap.DefaultCellStyle = dataGridViewCellStyle2;
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            // 
            // NhanVien
            // 
            this.NhanVien.DataPropertyName = "NhanVien";
            this.NhanVien.HeaderText = "Nhân Viên";
            this.NhanVien.Name = "NhanVien";
            this.NhanVien.ReadOnly = true;
            this.NhanVien.Width = 200;
            // 
            // DoiTuong
            // 
            this.DoiTuong.DataPropertyName = "DoiTuong";
            this.DoiTuong.HeaderText = "Đối tượng";
            this.DoiTuong.Name = "DoiTuong";
            this.DoiTuong.ReadOnly = true;
            this.DoiTuong.Width = 200;
            // 
            // KhoHang
            // 
            this.KhoHang.DataPropertyName = "KhoHang";
            this.KhoHang.HeaderText = "Kho hàng";
            this.KhoHang.Name = "KhoHang";
            this.KhoHang.ReadOnly = true;
            this.KhoHang.Width = 200;
            // 
            // IdChungTu
            // 
            this.IdChungTu.DataPropertyName = "IdChungTu";
            this.IdChungTu.HeaderText = "IdChungTu";
            this.IdChungTu.Name = "IdChungTu";
            this.IdChungTu.ReadOnly = true;
            this.IdChungTu.Visible = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(386, 207);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(381, 497);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 25);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "   &Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.Image")));
            this.btnGhi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGhi.Location = new System.Drawing.Point(297, 497);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(80, 25);
            this.btnGhi.TabIndex = 12;
            this.btnGhi.Text = "    &Cập nhật";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(467, 497);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(80, 25);
            this.btnDong.TabIndex = 14;
            this.btnDong.Text = "   T&hoát";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // dtNgayLapTu
            // 
            this.dtNgayLapTu.CustomFormat = "dd/MM/yyyy";
            this.dtNgayLapTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayLapTu.Location = new System.Drawing.Point(363, 97);
            this.dtNgayLapTu.Name = "dtNgayLapTu";
            this.dtNgayLapTu.Size = new System.Drawing.Size(211, 20);
            this.dtNgayLapTu.TabIndex = 15;
            this.dtNgayLapTu.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // dtNgayLapDen
            // 
            this.dtNgayLapDen.CustomFormat = "dd/MM/yyyy";
            this.dtNgayLapDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayLapDen.Location = new System.Drawing.Point(654, 97);
            this.dtNgayLapDen.Name = "dtNgayLapDen";
            this.dtNgayLapDen.Size = new System.Drawing.Size(200, 20);
            this.dtNgayLapDen.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(594, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Số Seri";
            // 
            // txtSoSeri
            // 
            this.txtSoSeri.Location = new System.Drawing.Point(654, 20);
            this.txtSoSeri.Name = "txtSoSeri";
            this.txtSoSeri.Size = new System.Drawing.Size(200, 20);
            this.txtSoSeri.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(595, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Số PX";
            // 
            // txtSoPX
            // 
            this.txtSoPX.Location = new System.Drawing.Point(654, 72);
            this.txtSoPX.Name = "txtSoPX";
            this.txtSoPX.Size = new System.Drawing.Size(200, 20);
            this.txtSoPX.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(593, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mã SP";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(654, 46);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(200, 20);
            this.txtMaSP.TabIndex = 9;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(363, 46);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(211, 20);
            this.txtTenSP.TabIndex = 9;
            // 
            // frm_TimKiem_ChungTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 545);
            this.ControlBox = false;
            this.Controls.Add(this.dtNgayLapDen);
            this.Controls.Add(this.dtNgayLapTu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.txtSoPX);
            this.Controls.Add(this.txtSoSeri);
            this.Controls.Add(this.txtKyHieuHD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboDoiTuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboNhanVien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboKho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboLoaiChungTu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_TimKiem_ChungTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm chứng từ";
            this.Load += new System.EventHandler(this.frm_TimKiem_ChungTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLoaiChungTu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboKho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboDoiTuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKyHieuHD;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.DataGridView dgvList;
        private QLBH.Core.Form.GtidButton btnTimKiem;
        internal QLBH.Core.Form.GtidButton btnXoa;
        internal QLBH.Core.Form.GtidButton btnGhi;
        internal QLBH.Core.Form.GtidButton btnDong;
        private System.Windows.Forms.DateTimePicker dtNgayLapTu;
        private System.Windows.Forms.DateTimePicker dtNgayLapDen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSoSeri;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSoPX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoChungTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiChungTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoiTuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhoHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdChungTu;
    }
}