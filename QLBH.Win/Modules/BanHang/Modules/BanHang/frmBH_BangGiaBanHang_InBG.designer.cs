using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frmBH_BangGiaBanHang_InBG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBH_BangGiaBanHang_InBG));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdMau3 = new System.Windows.Forms.RadioButton();
            this.btnInBG = new QLBH.Core.Form.GtidButton();
            this.cmdDong = new QLBH.Core.Form.GtidButton();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.rdMau3);
            this.groupBox2.Location = new System.Drawing.Point(17, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 160);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn mẫu in";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(33, 133);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(141, 17);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.Text = "Mẫu số 3 (2 tờ Note/A4)";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(33, 105);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(141, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.Text = "Mẫu số 3 (2 tờ Note/A4)";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(33, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(141, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Mẫu số 1 (8 tờ Note/A4)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(33, 49);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(141, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "Mẫu số 2 (4 tờ Note/A4)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdMau3
            // 
            this.rdMau3.AutoSize = true;
            this.rdMau3.Location = new System.Drawing.Point(33, 77);
            this.rdMau3.Name = "rdMau3";
            this.rdMau3.Size = new System.Drawing.Size(141, 17);
            this.rdMau3.TabIndex = 0;
            this.rdMau3.Text = "Mẫu số 3 (2 tờ Note/A4)";
            this.rdMau3.UseVisualStyleBackColor = true;
            // 
            // btnInBG
            // 
            this.btnInBG.Image = ((System.Drawing.Image)(resources.GetObject("btnInBG.Image")));
            this.btnInBG.Location = new System.Drawing.Point(241, 48);
            this.btnInBG.Name = "btnInBG";
            this.btnInBG.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnInBG.Size = new System.Drawing.Size(117, 25);
            this.btnInBG.TabIndex = 120;
            this.btnInBG.Text = "&In bảng giá (F5)";
            this.btnInBG.Click += new System.EventHandler(this.btnInBG_Click);
            // 
            // cmdDong
            // 
            this.cmdDong.Image = ((System.Drawing.Image)(resources.GetObject("cmdDong.Image")));
            this.cmdDong.Location = new System.Drawing.Point(241, 79);
            this.cmdDong.Name = "cmdDong";
            this.cmdDong.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdDong.Size = new System.Drawing.Size(116, 25);
            this.cmdDong.TabIndex = 63;
            this.cmdDong.Text = "T&hoát (ESC)";
            this.cmdDong.Click += new System.EventHandler(this.cmdDong_Click);
            // 
            // frmBH_BangGiaBanHang_InBG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 182);
            this.Controls.Add(this.btnInBG);
            this.Controls.Add(this.cmdDong);
            this.Controls.Add(this.groupBox2);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBH_BangGiaBanHang_InBG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In tờ Note sản phẩm";
            this.Load += new System.EventHandler(this.frm_ThietLapKM_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_ThietLapKM_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal GtidButton cmdDong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdMau3;
        private GtidButton btnInBG;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}