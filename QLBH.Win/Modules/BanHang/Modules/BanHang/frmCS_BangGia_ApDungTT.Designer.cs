using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frmCS_BangGia_ApDungTT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCS_BangGia_ApDungTT));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtThanhToanToiThieu = new QLBH.Core.Form.GtidTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboNganHangPH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboHinhThucTT = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboThoiHanTT = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboNganHangTT = new System.Windows.Forms.ComboBox();
            this.lblNganHangTT = new System.Windows.Forms.Label();
            this.btnThanhToan = new QLBH.Core.Form.GtidButton();
            this.btnClose = new QLBH.Core.Form.GtidButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtThanhToanToiThieu);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cboNganHangPH);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboHinhThucTT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboThoiHanTT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboNganHangTT);
            this.groupBox1.Controls.Add(this.lblNganHangTT);
            this.groupBox1.Location = new System.Drawing.Point(10, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 152);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(217, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 71;
            this.label12.Text = "(%)";
            // 
            // txtThanhToanToiThieu
            // 
            this.txtThanhToanToiThieu.Location = new System.Drawing.Point(147, 123);
            this.txtThanhToanToiThieu.Name = "txtThanhToanToiThieu";
            this.txtThanhToanToiThieu.Size = new System.Drawing.Size(64, 21);
            this.txtThanhToanToiThieu.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 70;
            this.label11.Text = "Thanh toán tối thiểu";
            // 
            // cboNganHangPH
            // 
            this.cboNganHangPH.FormattingEnabled = true;
            this.cboNganHangPH.Location = new System.Drawing.Point(147, 69);
            this.cboNganHangPH.Name = "cboNganHangPH";
            this.cboNganHangPH.Size = new System.Drawing.Size(320, 21);
            this.cboNganHangPH.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(30, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ngân hàng phát hành";
            // 
            // cboHinhThucTT
            // 
            this.cboHinhThucTT.FormattingEnabled = true;
            this.cboHinhThucTT.Location = new System.Drawing.Point(147, 15);
            this.cboHinhThucTT.Name = "cboHinhThucTT";
            this.cboHinhThucTT.Size = new System.Drawing.Size(320, 21);
            this.cboHinhThucTT.TabIndex = 14;
            this.cboHinhThucTT.SelectedIndexChanged += new System.EventHandler(this.cboHinhThucTT_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(34, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Hình thức thanh toán";
            // 
            // cboThoiHanTT
            // 
            this.cboThoiHanTT.FormattingEnabled = true;
            this.cboThoiHanTT.Location = new System.Drawing.Point(147, 96);
            this.cboThoiHanTT.Name = "cboThoiHanTT";
            this.cboThoiHanTT.Size = new System.Drawing.Size(320, 21);
            this.cboThoiHanTT.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(38, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Thời hạn thanh toán";
            // 
            // cboNganHangTT
            // 
            this.cboNganHangTT.FormattingEnabled = true;
            this.cboNganHangTT.Location = new System.Drawing.Point(147, 42);
            this.cboNganHangTT.Name = "cboNganHangTT";
            this.cboNganHangTT.Size = new System.Drawing.Size(320, 21);
            this.cboNganHangTT.TabIndex = 20;
            // 
            // lblNganHangTT
            // 
            this.lblNganHangTT.AutoSize = true;
            this.lblNganHangTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNganHangTT.Location = new System.Drawing.Point(27, 45);
            this.lblNganHangTT.Name = "lblNganHangTT";
            this.lblNganHangTT.Size = new System.Drawing.Size(114, 13);
            this.lblNganHangTT.TabIndex = 22;
            this.lblNganHangTT.Text = "Ngân hàng thanh toán";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.Location = new System.Drawing.Point(158, 163);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnThanhToan.Size = new System.Drawing.Size(91, 28);
            this.btnThanhToan.TabIndex = 9;
            this.btnThanhToan.Text = "Chấp nhận";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(250, 163);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnClose.Size = new System.Drawing.Size(91, 28);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Thoát (ESC)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCS_BangGia_ApDungTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 200);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCS_BangGia_ApDungTT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn hình thức thanh toán";
            this.Load += new System.EventHandler(this.frmPhieuXuat_TraTienThua_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPhieuXuat_TraTienThua_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboThoiHanTT;
        private System.Windows.Forms.Label label6;
        private GtidButton btnClose;
        private System.Windows.Forms.ComboBox cboHinhThucTT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboNganHangTT;
        private System.Windows.Forms.Label lblNganHangTT;
        private GtidButton btnThanhToan;
        private System.Windows.Forms.ComboBox cboNganHangPH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private GtidTextBox txtThanhToanToiThieu;
        private System.Windows.Forms.Label label11;
    }
}