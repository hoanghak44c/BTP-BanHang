using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frmBC_BanHang_ThuTien
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
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboKho);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboTrungTam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(16, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cboKho
            // 
            this.cboKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKho.FormattingEnabled = true;
            this.cboKho.Location = new System.Drawing.Point(92, 50);
            this.cboKho.Name = "cboKho";
            this.cboKho.Size = new System.Drawing.Size(349, 21);
            this.cboKho.TabIndex = 62;
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
            this.label1.Location = new System.Drawing.Point(19, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Kỳ báo cáo";
            // 
            // cboKyBaoCao
            // 
            this.cboKyBaoCao.FormattingEnabled = true;
            this.cboKyBaoCao.Location = new System.Drawing.Point(85, 54);
            this.cboKyBaoCao.Name = "cboKyBaoCao";
            this.cboKyBaoCao.Size = new System.Drawing.Size(105, 21);
            this.cboKyBaoCao.TabIndex = 54;
            this.cboKyBaoCao.SelectedIndexChanged += new System.EventHandler(this.cboKyBaoCao_SelectedIndexChanged);
            // 
            // dtTuNgay
            // 
            this.dtTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTuNgay.Location = new System.Drawing.Point(223, 54);
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Size = new System.Drawing.Size(98, 21);
            this.dtTuNgay.TabIndex = 56;
            this.dtTuNgay.ValueChanged += new System.EventHandler(this.dtTuNgay_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Từ";
            // 
            // dtDenNgay
            // 
            this.dtDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDenNgay.Location = new System.Drawing.Point(359, 54);
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Size = new System.Drawing.Size(98, 21);
            this.dtDenNgay.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "đến";
            // 
            // cmdIn
            // 
            this.cmdIn.Location = new System.Drawing.Point(153, 182);
            this.cmdIn.Name = "cmdIn";
            this.cmdIn.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdIn.Size = new System.Drawing.Size(96, 27);
            this.cmdIn.TabIndex = 59;
            this.cmdIn.Text = "Xem báo cáo";
            this.cmdIn.Click += new System.EventHandler(this.cmdIn_Click);
            // 
            // cmdThoat
            // 
            this.cmdThoat.Location = new System.Drawing.Point(255, 182);
            this.cmdThoat.Name = "cmdThoat";
            this.cmdThoat.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdThoat.Size = new System.Drawing.Size(75, 27);
            this.cmdThoat.TabIndex = 60;
            this.cmdThoat.Text = "Thoát";
            this.cmdThoat.Click += new System.EventHandler(this.cmdThoat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(111, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 19);
            this.label6.TabIndex = 67;
            this.label6.Text = "BẢNG KÊ BÁN HÀNG - THU TIỀN";
            // 
            // frmBC_BanHang_ThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 228);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmdThoat);
            this.Controls.Add(this.cmdIn);
            this.Controls.Add(this.dtDenNgay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtTuNgay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboKyBaoCao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBC_BanHang_ThuTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo bán hàng - thu tiền";
            this.Load += new System.EventHandler(this.frmBC_BanHang_ThuTien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ComboBox cboKho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTrungTam;
        private System.Windows.Forms.Label label3;
        private QLBH.Core.Form.GtidButton cmdIn;
        private QLBH.Core.Form.GtidButton cmdThoat;
        private System.Windows.Forms.Label label6;
    }
}