using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frmCS_BangGia_ApDung
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
            this.label3 = new System.Windows.Forms.Label();
            this.chkLstTrungTam = new System.Windows.Forms.CheckedListBox();
            this.rdTrungTam = new System.Windows.Forms.RadioButton();
            this.rdShop = new System.Windows.Forms.RadioButton();
            this.cmdThoat = new QLBH.Core.Form.GtidButton();
            this.cmdApDung = new QLBH.Core.Form.GtidButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Áp dụng bảng giá cho các";
            // 
            // chkLstTrungTam
            // 
            this.chkLstTrungTam.CheckOnClick = true;
            this.chkLstTrungTam.FormattingEnabled = true;
            this.chkLstTrungTam.Location = new System.Drawing.Point(10, 43);
            this.chkLstTrungTam.Name = "chkLstTrungTam";
            this.chkLstTrungTam.Size = new System.Drawing.Size(447, 148);
            this.chkLstTrungTam.TabIndex = 70;
            this.chkLstTrungTam.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkLstTrungTam_ItemCheck);
            // 
            // rdTrungTam
            // 
            this.rdTrungTam.AutoSize = true;
            this.rdTrungTam.Location = new System.Drawing.Point(179, 12);
            this.rdTrungTam.Name = "rdTrungTam";
            this.rdTrungTam.Size = new System.Drawing.Size(74, 17);
            this.rdTrungTam.TabIndex = 71;
            this.rdTrungTam.TabStop = true;
            this.rdTrungTam.Text = "Trung tâm";
            this.rdTrungTam.UseVisualStyleBackColor = true;
            this.rdTrungTam.CheckedChanged += new System.EventHandler(this.rdTrungTam_CheckedChanged);
            // 
            // rdShop
            // 
            this.rdShop.AutoSize = true;
            this.rdShop.Location = new System.Drawing.Point(278, 12);
            this.rdShop.Name = "rdShop";
            this.rdShop.Size = new System.Drawing.Size(81, 17);
            this.rdShop.TabIndex = 72;
            this.rdShop.TabStop = true;
            this.rdShop.Text = "Shop bán lẻ";
            this.rdShop.UseVisualStyleBackColor = true;
            this.rdShop.CheckedChanged += new System.EventHandler(this.rdShop_CheckedChanged);
            // 
            // cmdThoat
            // 
            this.cmdThoat.Location = new System.Drawing.Point(236, 208);
            this.cmdThoat.Name = "cmdThoat";
            this.cmdThoat.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdThoat.Size = new System.Drawing.Size(78, 27);
            this.cmdThoat.TabIndex = 64;
            this.cmdThoat.Text = "Thoát";
            this.cmdThoat.Click += new System.EventHandler(this.cmdThoat_Click);
            // 
            // cmdApDung
            // 
            this.cmdApDung.Location = new System.Drawing.Point(152, 208);
            this.cmdApDung.Name = "cmdApDung";
            this.cmdApDung.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdApDung.Size = new System.Drawing.Size(78, 27);
            this.cmdApDung.TabIndex = 63;
            this.cmdApDung.Text = "Áp dụng";
            this.cmdApDung.Click += new System.EventHandler(this.cmdApDung_Click);
            // 
            // frmCS_BangGia_ApDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 245);
            this.Controls.Add(this.rdShop);
            this.Controls.Add(this.rdTrungTam);
            this.Controls.Add(this.chkLstTrungTam);
            this.Controls.Add(this.cmdThoat);
            this.Controls.Add(this.cmdApDung);
            this.Controls.Add(this.label3);
            this.Name = "frmCS_BangGia_ApDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Áp dụng chính sách giá";
            this.Load += new System.EventHandler(this.frm_BangGia_ApDung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private QLBH.Core.Form.GtidButton cmdThoat;
        private QLBH.Core.Form.GtidButton cmdApDung;
        private System.Windows.Forms.CheckedListBox chkLstTrungTam;
        private System.Windows.Forms.RadioButton rdTrungTam;
        private System.Windows.Forms.RadioButton rdShop;
    }
}