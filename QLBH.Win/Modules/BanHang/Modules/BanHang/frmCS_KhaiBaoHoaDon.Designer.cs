using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frmCS_KhaiBaoHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCS_KhaiBaoHoaDon));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoConLai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoHienTai = new System.Windows.Forms.TextBox();
            this.txtSoKetThuc = new System.Windows.Forms.TextBox();
            this.txtKyHieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoBatDau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNganHangTT = new System.Windows.Forms.Label();
            this.btnThanhToan = new QLBH.Core.Form.GtidButton();
            this.btnClose = new QLBH.Core.Form.GtidButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoConLai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSoHienTai);
            this.groupBox1.Controls.Add(this.txtSoKetThuc);
            this.groupBox1.Controls.Add(this.txtKyHieu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSoBatDau);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblNganHangTT);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtSoConLai
            // 
            this.txtSoConLai.Location = new System.Drawing.Point(143, 123);
            this.txtSoConLai.Name = "txtSoConLai";
            this.txtSoConLai.ReadOnly = true;
            this.txtSoConLai.Size = new System.Drawing.Size(238, 21);
            this.txtSoConLai.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(52, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Số còn lại";
            // 
            // txtSoHienTai
            // 
            this.txtSoHienTai.Location = new System.Drawing.Point(143, 70);
            this.txtSoHienTai.Name = "txtSoHienTai";
            this.txtSoHienTai.Size = new System.Drawing.Size(238, 21);
            this.txtSoHienTai.TabIndex = 2;
            this.txtSoHienTai.TextChanged += new System.EventHandler(this.txtSoHienTai_TextChanged);
            this.txtSoHienTai.Leave += new System.EventHandler(this.txtSoHienTai_Leave);
            // 
            // txtSoKetThuc
            // 
            this.txtSoKetThuc.Location = new System.Drawing.Point(143, 97);
            this.txtSoKetThuc.Name = "txtSoKetThuc";
            this.txtSoKetThuc.Size = new System.Drawing.Size(238, 21);
            this.txtSoKetThuc.TabIndex = 3;
            this.txtSoKetThuc.TextChanged += new System.EventHandler(this.txtSoKetThuc_TextChanged);
            this.txtSoKetThuc.Leave += new System.EventHandler(this.txtSoKetThuc_Leave);
            // 
            // txtKyHieu
            // 
            this.txtKyHieu.Location = new System.Drawing.Point(143, 17);
            this.txtKyHieu.Name = "txtKyHieu";
            this.txtKyHieu.Size = new System.Drawing.Size(238, 21);
            this.txtKyHieu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(67, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ký hiệu";
            // 
            // txtSoBatDau
            // 
            this.txtSoBatDau.Location = new System.Drawing.Point(143, 43);
            this.txtSoBatDau.Name = "txtSoBatDau";
            this.txtSoBatDau.Size = new System.Drawing.Size(238, 21);
            this.txtSoBatDau.TabIndex = 1;
            this.txtSoBatDau.TextChanged += new System.EventHandler(this.txtSoBatDau_TextChanged);
            this.txtSoBatDau.Leave += new System.EventHandler(this.txtSoBatDau_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(49, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Số bắt đầu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(52, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Số hiện tại";
            // 
            // lblNganHangTT
            // 
            this.lblNganHangTT.AutoSize = true;
            this.lblNganHangTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNganHangTT.Location = new System.Drawing.Point(47, 100);
            this.lblNganHangTT.Name = "lblNganHangTT";
            this.lblNganHangTT.Size = new System.Drawing.Size(62, 13);
            this.lblNganHangTT.TabIndex = 22;
            this.lblNganHangTT.Text = "Số kết thúc";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.Location = new System.Drawing.Point(154, 178);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnThanhToan.Size = new System.Drawing.Size(91, 28);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "Chấp nhận";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(246, 178);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnClose.Size = new System.Drawing.Size(91, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Thoát (ESC)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCS_KhaiBaoHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 218);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCS_KhaiBaoHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khai báo số hóa đơn sử dụng";
            this.Load += new System.EventHandler(this.frmPhieuXuat_TraTienThua_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private GtidButton btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNganHangTT;
        private GtidButton btnThanhToan;
        private System.Windows.Forms.TextBox txtSoBatDau;
        private System.Windows.Forms.TextBox txtSoHienTai;
        private System.Windows.Forms.TextBox txtSoKetThuc;
        private System.Windows.Forms.TextBox txtKyHieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoConLai;
        private System.Windows.Forms.Label label2;
    }
}