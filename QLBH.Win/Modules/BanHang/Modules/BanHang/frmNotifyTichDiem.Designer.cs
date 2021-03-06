using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frmNotifyTichDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotifyTichDiem));
            this.grTitle = new System.Windows.Forms.GroupBox();
            this.lblTongDiem = new DevExpress.XtraEditors.LabelControl();
            this.lblDiemThem = new DevExpress.XtraEditors.LabelControl();
            this.lblDiemTru = new DevExpress.XtraEditors.LabelControl();
            this.lblDiemDau = new DevExpress.XtraEditors.LabelControl();
            this.cmdThoat = new QLBH.Core.Form.GtidButton();
            this.grTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // grTitle
            // 
            this.grTitle.Controls.Add(this.lblTongDiem);
            this.grTitle.Controls.Add(this.lblDiemThem);
            this.grTitle.Controls.Add(this.lblDiemTru);
            this.grTitle.Controls.Add(this.lblDiemDau);
            this.grTitle.ForeColor = System.Drawing.Color.Green;
            this.grTitle.Location = new System.Drawing.Point(15, 9);
            this.grTitle.Margin = new System.Windows.Forms.Padding(4);
            this.grTitle.Name = "grTitle";
            this.grTitle.Padding = new System.Windows.Forms.Padding(4);
            this.grTitle.Size = new System.Drawing.Size(331, 134);
            this.grTitle.TabIndex = 66;
            this.grTitle.TabStop = false;
            this.grTitle.Text = "Lập đơn bán thành công";
            // 
            // lblTongDiem
            // 
            this.lblTongDiem.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDiem.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblTongDiem.Appearance.Options.UseFont = true;
            this.lblTongDiem.Appearance.Options.UseForeColor = true;
            this.lblTongDiem.Location = new System.Drawing.Point(55, 106);
            this.lblTongDiem.Margin = new System.Windows.Forms.Padding(4);
            this.lblTongDiem.Name = "lblTongDiem";
            this.lblTongDiem.Size = new System.Drawing.Size(135, 16);
            this.lblTongDiem.TabIndex = 6;
            this.lblTongDiem.Text = "Tổng điểm cuối cùng:";
            // 
            // lblDiemThem
            // 
            this.lblDiemThem.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemThem.Appearance.Options.UseFont = true;
            this.lblDiemThem.Location = new System.Drawing.Point(55, 77);
            this.lblDiemThem.Margin = new System.Windows.Forms.Padding(4);
            this.lblDiemThem.Name = "lblDiemThem";
            this.lblDiemThem.Size = new System.Drawing.Size(129, 16);
            this.lblDiemThem.TabIndex = 4;
            this.lblDiemThem.Text = "Số điểm tích lũy thêm:";
            // 
            // lblDiemTru
            // 
            this.lblDiemTru.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemTru.Appearance.Options.UseFont = true;
            this.lblDiemTru.Location = new System.Drawing.Point(55, 51);
            this.lblDiemTru.Margin = new System.Windows.Forms.Padding(4);
            this.lblDiemTru.Name = "lblDiemTru";
            this.lblDiemTru.Size = new System.Drawing.Size(87, 16);
            this.lblDiemTru.TabIndex = 3;
            this.lblDiemTru.Text = "Số điểm bị trừ:";
            // 
            // lblDiemDau
            // 
            this.lblDiemDau.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemDau.Appearance.Options.UseFont = true;
            this.lblDiemDau.Location = new System.Drawing.Point(55, 25);
            this.lblDiemDau.Margin = new System.Windows.Forms.Padding(4);
            this.lblDiemDau.Name = "lblDiemDau";
            this.lblDiemDau.Size = new System.Drawing.Size(102, 16);
            this.lblDiemDau.TabIndex = 2;
            this.lblDiemDau.Text = "Số điểm ban đầu:";
            // 
            // cmdThoat
            // 
            this.cmdThoat.Image = ((System.Drawing.Image)(resources.GetObject("cmdThoat.Image")));
            this.cmdThoat.Location = new System.Drawing.Point(135, 150);
            this.cmdThoat.Margin = new System.Windows.Forms.Padding(4);
            this.cmdThoat.Name = "cmdThoat";
            this.cmdThoat.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdThoat.Size = new System.Drawing.Size(90, 26);
            this.cmdThoat.TabIndex = 64;
            this.cmdThoat.Text = "Đóng";
            this.cmdThoat.Click += new System.EventHandler(this.cmdThoat_Click);
            // 
            // frmNotifyTichDiem
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 181);
            this.ControlBox = false;
            this.Controls.Add(this.cmdThoat);
            this.Controls.Add(this.grTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNotifyTichDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin tích lũy điểm thưởng";
            this.Load += new System.EventHandler(this.frm_BangGia_ApDung_Load);
            this.grTitle.ResumeLayout(false);
            this.grTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GtidButton cmdThoat;
        private System.Windows.Forms.GroupBox grTitle;
        private DevExpress.XtraEditors.LabelControl lblDiemTru;
        private DevExpress.XtraEditors.LabelControl lblDiemDau;
        private DevExpress.XtraEditors.LabelControl lblTongDiem;
        private DevExpress.XtraEditors.LabelControl lblDiemThem;
    }
}