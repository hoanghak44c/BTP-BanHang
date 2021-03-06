using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frmBC_HangGiamGiaBan
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboKyBaoCao = new System.Windows.Forms.ComboBox();
            this.dtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdIn = new GtidButton();
            this.cmdThoat = new GtidButton();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTenSanPham = new GtidTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSophieu = new GtidTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboSanPham = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboKho = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTrungTam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new GtidTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Kỳ báo cáo";
            // 
            // cboKyBaoCao
            // 
            this.cboKyBaoCao.FormattingEnabled = true;
            this.cboKyBaoCao.Location = new System.Drawing.Point(86, 48);
            this.cboKyBaoCao.Name = "cboKyBaoCao";
            this.cboKyBaoCao.Size = new System.Drawing.Size(105, 21);
            this.cboKyBaoCao.TabIndex = 54;
            this.cboKyBaoCao.SelectedIndexChanged += new System.EventHandler(this.cboKyBaoCao_SelectedIndexChanged);
            // 
            // dtTuNgay
            // 
            this.dtTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTuNgay.Location = new System.Drawing.Point(224, 48);
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Size = new System.Drawing.Size(98, 20);
            this.dtTuNgay.TabIndex = 56;
            this.dtTuNgay.ValueChanged += new System.EventHandler(this.dtTuNgay_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Từ";
            // 
            // dtDenNgay
            // 
            this.dtDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDenNgay.Location = new System.Drawing.Point(360, 48);
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Size = new System.Drawing.Size(98, 20);
            this.dtDenNgay.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "đến";
            // 
            // cmdIn
            // 
            this.cmdIn.Location = new System.Drawing.Point(145, 281);
            this.cmdIn.Name = "cmdIn";
            this.cmdIn.Size = new System.Drawing.Size(96, 27);
            this.cmdIn.TabIndex = 59;
            this.cmdIn.Text = "Xem báo cáo";
            //this.cmdIn.UseVisualStyleBackColor = true;
            this.cmdIn.Click += new System.EventHandler(this.cmdIn_Click);
            // 
            // cmdThoat
            // 
            this.cmdThoat.Location = new System.Drawing.Point(247, 281);
            this.cmdThoat.Name = "cmdThoat";
            this.cmdThoat.Size = new System.Drawing.Size(107, 27);
            this.cmdThoat.TabIndex = 60;
            this.cmdThoat.Text = "Thoát";
            //this.cmdThoat.UseVisualStyleBackColor = true;
            this.cmdThoat.Click += new System.EventHandler(this.cmdThoat_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(157, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 19);
            this.label9.TabIndex = 61;
            this.label9.Text = "BÁO CÁO SỬA GIÁ BÁN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTaiKhoan);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtTenSanPham);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtSophieu);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboSanPham);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboKho);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboTrungTam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(20, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 192);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(294, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 13);
            this.label11.TabIndex = 74;
            this.label11.Text = "(gõ %mã hoặc tên%)";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(92, 136);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(196, 20);
            this.txtTenSanPham.TabIndex = 73;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 69;
            this.label10.Text = "Tài khoản";
            // 
            // txtSophieu
            // 
            this.txtSophieu.Location = new System.Drawing.Point(92, 163);
            this.txtSophieu.Name = "txtSophieu";
            this.txtSophieu.Size = new System.Drawing.Size(196, 20);
            this.txtSophieu.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "Số phiếu";
            // 
            // cboSanPham
            // 
            this.cboSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSanPham.FormattingEnabled = true;
            this.cboSanPham.Location = new System.Drawing.Point(92, 108);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new System.Drawing.Size(349, 21);
            this.cboSanPham.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Sản phẩm";
            // 
            // cboKho
            // 
            this.cboKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKho.FormattingEnabled = true;
            this.cboKho.Location = new System.Drawing.Point(92, 50);
            this.cboKho.Name = "cboKho";
            this.cboKho.Size = new System.Drawing.Size(349, 21);
            this.cboKho.TabIndex = 62;
            this.cboKho.SelectedIndexChanged += new System.EventHandler(this.cboKho_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Kho";
            // 
            // cboTrungTam
            // 
            this.cboTrungTam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrungTam.FormattingEnabled = true;
            this.cboTrungTam.Location = new System.Drawing.Point(92, 23);
            this.cboTrungTam.Name = "cboTrungTam";
            this.cboTrungTam.Size = new System.Drawing.Size(349, 21);
            this.cboTrungTam.TabIndex = 60;
            this.cboTrungTam.SelectedIndexChanged += new System.EventHandler(this.cboTrungTam_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Trung tâm";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(92, 80);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(196, 20);
            this.txtTaiKhoan.TabIndex = 75;
            // 
            // frmBC_HangGiamGiaBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 316);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmdThoat);
            this.Controls.Add(this.cmdIn);
            this.Controls.Add(this.dtDenNgay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtTuNgay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboKyBaoCao);
            this.Controls.Add(this.label1);
            this.Name = "frmBC_HangGiamGiaBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo sửa giá bán";
            this.Load += new System.EventHandler(this.frmBC_DoanhThuBanHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboKyBaoCao;
        private System.Windows.Forms.DateTimePicker dtTuNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtDenNgay;
        private System.Windows.Forms.Label label2;
        private QLBH.Core.Form.GtidButton cmdIn;
        private QLBH.Core.Form.GtidButton cmdThoat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSophieu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboSanPham;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboKho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTrungTam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaiKhoan;
    }
}