using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frm_HoaDonBan_ChonTyleVAT
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboTyle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChapNhan = new GtidButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trong phiếu xuất này có nhiều tỷ lệ VAT khác nhau, bạn hãy chọn một trong các tỷ " +
                "lệ bên dưới";
            // 
            // cboTyle
            // 
            this.cboTyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTyle.FormattingEnabled = true;
            this.cboTyle.Location = new System.Drawing.Point(72, 56);
            this.cboTyle.Name = "cboTyle";
            this.cboTyle.Size = new System.Drawing.Size(121, 21);
            this.cboTyle.TabIndex = 1;
            this.cboTyle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboTyle_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tỷ lệ VAT";
            // 
            // btnChapNhan
            // 
            this.btnChapNhan.Location = new System.Drawing.Point(199, 54);
            this.btnChapNhan.Name = "btnChapNhan";
            this.btnChapNhan.Size = new System.Drawing.Size(75, 23);
            this.btnChapNhan.TabIndex = 3;
            this.btnChapNhan.Text = "Chấp nhận";
            //this.btnChapNhan.UseVisualStyleBackColor = true;
            this.btnChapNhan.Click += new System.EventHandler(this.btnChapNhan_Click);
            // 
            // frm_HoaDonBan_ChonTyleVAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 101);
            this.Controls.Add(this.btnChapNhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTyle);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_HoaDonBan_ChonTyleVAT";
            this.Text = "Chọn tỷ lệ thuế";
            this.Load += new System.EventHandler(this.frm_HoaDonBan_ChonTyleVAT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTyle;
        private System.Windows.Forms.Label label2;
        private QLBH.Core.Form.GtidButton btnChapNhan;
    }
}