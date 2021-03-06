using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frm_BangGia_Import
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImport = new QLBH.Core.Form.GtidButton();
            this.btnBrowse = new QLBH.Core.Form.GtidButton();
            this.txtFile = new QLBH.Core.Form.GtidTextBox();
            this.cmdThoat = new QLBH.Core.Form.GtidButton();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Excel|*.xls";
            this.openFileDialog1.Multiselect = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Chọn file";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(236, 64);
            this.btnImport.Name = "btnImport";
            this.btnImport.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnImport.Size = new System.Drawing.Size(78, 27);
            this.btnImport.TabIndex = 68;
            this.btnImport.Text = "Import";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(528, 30);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnBrowse.Size = new System.Drawing.Size(78, 27);
            this.btnBrowse.TabIndex = 67;
            this.btnBrowse.Text = "Browse..";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(61, 34);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(461, 20);
            this.txtFile.TabIndex = 66;
            // 
            // cmdThoat
            // 
            this.cmdThoat.Location = new System.Drawing.Point(320, 64);
            this.cmdThoat.Name = "cmdThoat";
            this.cmdThoat.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdThoat.Size = new System.Drawing.Size(78, 27);
            this.cmdThoat.TabIndex = 64;
            this.cmdThoat.Text = "Thoát";
            this.cmdThoat.Click += new System.EventHandler(this.cmdThoat_Click);
            // 
            // frm_BangGia_Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 112);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdThoat);
            this.Name = "frm_BangGia_Import";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import chính sách giá";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLBH.Core.Form.GtidButton cmdThoat;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private QLBH.Core.Form.GtidButton btnBrowse;
        private QLBH.Core.Form.GtidButton btnImport;
        private GtidTextBox txtFile;
    }
}