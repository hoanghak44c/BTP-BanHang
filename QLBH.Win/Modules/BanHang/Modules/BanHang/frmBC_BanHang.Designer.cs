using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frmBC_BanHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.txtTenSanPham = new QLBH.Core.Form.GtidTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSophieu = new QLBH.Core.Form.GtidTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboSanPham = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboKho = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTrungTam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboKyBaoCao = new System.Windows.Forms.ComboBox();
            this.dtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdIn = new QLBH.Core.Form.GtidButton();
            this.cmdThoat = new QLBH.Core.Form.GtidButton();
            this.label9 = new System.Windows.Forms.Label();
            this.grp = new System.Windows.Forms.GroupBox();
            this.rdNhanVien = new System.Windows.Forms.RadioButton();
            this.optMaHang = new System.Windows.Forms.RadioButton();
            this.optSoHoaDon = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rptKhuyenMai = new System.Windows.Forms.RadioButton();
            this.rptBanHang = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.grp.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cboNhanVien);
            this.groupBox1.Controls.Add(this.txtTenSanPham);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtSophieu);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboSanPham);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboKhachHang);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboKho);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboTrungTam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(17, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(294, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 74;
            this.label11.Text = "(gõ %mã hoặc tên%)";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(92, 106);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(349, 21);
            this.cboNhanVien.TabIndex = 70;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(92, 162);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(196, 21);
            this.txtTenSanPham.TabIndex = 73;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 69;
            this.label10.Text = "Nhân viên";
            // 
            // txtSophieu
            // 
            this.txtSophieu.Location = new System.Drawing.Point(92, 189);
            this.txtSophieu.Name = "txtSophieu";
            this.txtSophieu.Size = new System.Drawing.Size(196, 21);
            this.txtSophieu.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "Số phiếu";
            // 
            // cboSanPham
            // 
            this.cboSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSanPham.FormattingEnabled = true;
            this.cboSanPham.Location = new System.Drawing.Point(92, 134);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new System.Drawing.Size(349, 21);
            this.cboSanPham.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Sản phẩm";
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(92, 77);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(349, 21);
            this.cboKhachHang.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Khách hàng";
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
            this.label5.Size = new System.Drawing.Size(25, 13);
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
            this.cboTrungTam.Click += new System.EventHandler(this.cboTrungTam_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Trung tâm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Kỳ báo cáo";
            // 
            // cboKyBaoCao
            // 
            this.cboKyBaoCao.FormattingEnabled = true;
            this.cboKyBaoCao.Location = new System.Drawing.Point(86, 93);
            this.cboKyBaoCao.Name = "cboKyBaoCao";
            this.cboKyBaoCao.Size = new System.Drawing.Size(105, 21);
            this.cboKyBaoCao.TabIndex = 54;
            this.cboKyBaoCao.SelectedIndexChanged += new System.EventHandler(this.cboKyBaoCao_SelectedIndexChanged);
            // 
            // dtTuNgay
            // 
            this.dtTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTuNgay.Location = new System.Drawing.Point(224, 93);
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Size = new System.Drawing.Size(98, 21);
            this.dtTuNgay.TabIndex = 56;
            this.dtTuNgay.ValueChanged += new System.EventHandler(this.dtTuNgay_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Từ";
            // 
            // dtDenNgay
            // 
            this.dtDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDenNgay.Location = new System.Drawing.Point(360, 93);
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Size = new System.Drawing.Size(98, 21);
            this.dtDenNgay.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "đến";
            // 
            // cmdIn
            // 
            this.cmdIn.Location = new System.Drawing.Point(166, 393);
            this.cmdIn.Name = "cmdIn";
            this.cmdIn.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdIn.Size = new System.Drawing.Size(96, 27);
            this.cmdIn.TabIndex = 59;
            this.cmdIn.Text = "Xem báo cáo";
            this.cmdIn.Click += new System.EventHandler(this.cmdIn_Click);
            // 
            // cmdThoat
            // 
            this.cmdThoat.Location = new System.Drawing.Point(268, 393);
            this.cmdThoat.Name = "cmdThoat";
            this.cmdThoat.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdThoat.Size = new System.Drawing.Size(75, 27);
            this.cmdThoat.TabIndex = 60;
            this.cmdThoat.Text = "Thoát";
            this.cmdThoat.Click += new System.EventHandler(this.cmdThoat_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(105, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(292, 19);
            this.label9.TabIndex = 61;
            this.label9.Text = "BÁO CÁO BÁN HÀNG/KHUYẾN MẠI";
            // 
            // grp
            // 
            this.grp.Controls.Add(this.rdNhanVien);
            this.grp.Controls.Add(this.optMaHang);
            this.grp.Controls.Add(this.optSoHoaDon);
            this.grp.Location = new System.Drawing.Point(20, 344);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(456, 43);
            this.grp.TabIndex = 64;
            this.grp.TabStop = false;
            this.grp.Text = "Báo cáo theo";
            // 
            // rdNhanVien
            // 
            this.rdNhanVien.AutoSize = true;
            this.rdNhanVien.Checked = true;
            this.rdNhanVien.Location = new System.Drawing.Point(160, 19);
            this.rdNhanVien.Name = "rdNhanVien";
            this.rdNhanVien.Size = new System.Drawing.Size(134, 17);
            this.rdNhanVien.TabIndex = 66;
            this.rdNhanVien.TabStop = true;
            this.rdNhanVien.Text = "Chi tiết theo nhân viên";
            this.rdNhanVien.UseVisualStyleBackColor = true;
            // 
            // optMaHang
            // 
            this.optMaHang.AutoSize = true;
            this.optMaHang.Location = new System.Drawing.Point(311, 19);
            this.optMaHang.Name = "optMaHang";
            this.optMaHang.Size = new System.Drawing.Size(66, 17);
            this.optMaHang.TabIndex = 65;
            this.optMaHang.Text = "Mã hàng";
            this.optMaHang.UseVisualStyleBackColor = true;
            // 
            // optSoHoaDon
            // 
            this.optSoHoaDon.AutoSize = true;
            this.optSoHoaDon.Location = new System.Drawing.Point(59, 19);
            this.optSoHoaDon.Name = "optSoHoaDon";
            this.optSoHoaDon.Size = new System.Drawing.Size(79, 17);
            this.optSoHoaDon.TabIndex = 64;
            this.optSoHoaDon.Text = "Số hóa đơn";
            this.optSoHoaDon.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rptKhuyenMai);
            this.groupBox2.Controls.Add(this.rptBanHang);
            this.groupBox2.Location = new System.Drawing.Point(20, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 38);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại báo cáo";
            // 
            // rptKhuyenMai
            // 
            this.rptKhuyenMai.AutoSize = true;
            this.rptKhuyenMai.Location = new System.Drawing.Point(252, 17);
            this.rptKhuyenMai.Name = "rptKhuyenMai";
            this.rptKhuyenMai.Size = new System.Drawing.Size(120, 17);
            this.rptKhuyenMai.TabIndex = 65;
            this.rptKhuyenMai.Text = "Báo cáo khuyến mại";
            this.rptKhuyenMai.UseVisualStyleBackColor = true;
            // 
            // rptBanHang
            // 
            this.rptBanHang.AutoSize = true;
            this.rptBanHang.Checked = true;
            this.rptBanHang.Location = new System.Drawing.Point(55, 17);
            this.rptBanHang.Name = "rptBanHang";
            this.rptBanHang.Size = new System.Drawing.Size(111, 17);
            this.rptBanHang.TabIndex = 64;
            this.rptBanHang.TabStop = true;
            this.rptBanHang.Text = "Báo cáo bán hàng";
            this.rptBanHang.UseVisualStyleBackColor = true;
            // 
            // frmBC_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 431);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmdThoat);
            this.Controls.Add(this.cmdIn);
            this.Controls.Add(this.dtDenNgay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtTuNgay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboKyBaoCao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grp);
            this.Name = "frmBC_BanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo bán hàng";
            this.Load += new System.EventHandler(this.frm_BaoCaoBanHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboKyBaoCao;
        private System.Windows.Forms.DateTimePicker dtTuNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtDenNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSanPham;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboKho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTrungTam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private QLBH.Core.Form.GtidButton cmdIn;
        private QLBH.Core.Form.GtidButton cmdThoat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.RadioButton optMaHang;
        private System.Windows.Forms.RadioButton optSoHoaDon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rptKhuyenMai;
        private System.Windows.Forms.RadioButton rptBanHang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rdNhanVien;
        private GtidTextBox txtSophieu;
        private GtidTextBox txtTenSanPham;
    }
}