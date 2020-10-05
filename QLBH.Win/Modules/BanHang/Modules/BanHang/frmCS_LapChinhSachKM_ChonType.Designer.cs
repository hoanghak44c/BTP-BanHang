using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frmCS_LapChinhSachKM_ChonType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCS_LapChinhSachKM_ChonType));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.rdChinhSachCKhau = new System.Windows.Forms.RadioButton();
            this.rdChinhSachMDinh = new System.Windows.Forms.RadioButton();
            this.rdChinhSachThuong = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new QLBH.Core.Form.GtidButton();
            this.grpThucThi = new System.Windows.Forms.GroupBox();
            this.btnClose = new QLBH.Core.Form.GtidButton();
            this.GroupBox1.SuspendLayout();
            this.grpThucThi.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.rdChinhSachCKhau);
            this.GroupBox1.Controls.Add(this.rdChinhSachMDinh);
            this.GroupBox1.Controls.Add(this.rdChinhSachThuong);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(6, 7);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(471, 105);
            this.GroupBox1.TabIndex = 4;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Loại chính sách giá";
            // 
            // rdChinhSachCKhau
            // 
            this.rdChinhSachCKhau.AutoSize = true;
            this.rdChinhSachCKhau.Location = new System.Drawing.Point(42, 76);
            this.rdChinhSachCKhau.Name = "rdChinhSachCKhau";
            this.rdChinhSachCKhau.Size = new System.Drawing.Size(343, 17);
            this.rdChinhSachCKhau.TabIndex = 48;
            this.rdChinhSachCKhau.Text = "Chính sách chiết khấu, giảm giá (khai báo mã chiết khấu, giảm giá)";
            this.rdChinhSachCKhau.UseVisualStyleBackColor = true;
            // 
            // rdChinhSachMDinh
            // 
            this.rdChinhSachMDinh.AutoSize = true;
            this.rdChinhSachMDinh.Location = new System.Drawing.Point(42, 49);
            this.rdChinhSachMDinh.Name = "rdChinhSachMDinh";
            this.rdChinhSachMDinh.Size = new System.Drawing.Size(366, 17);
            this.rdChinhSachMDinh.TabIndex = 47;
            this.rdChinhSachMDinh.Text = "Chính sách mặc định (luôn được áp dụng kèm theo chính sách thường)";
            this.rdChinhSachMDinh.UseVisualStyleBackColor = true;
            // 
            // rdChinhSachThuong
            // 
            this.rdChinhSachThuong.AutoSize = true;
            this.rdChinhSachThuong.Checked = true;
            this.rdChinhSachThuong.Location = new System.Drawing.Point(42, 22);
            this.rdChinhSachThuong.Name = "rdChinhSachThuong";
            this.rdChinhSachThuong.Size = new System.Drawing.Size(355, 17);
            this.rdChinhSachThuong.TabIndex = 46;
            this.rdChinhSachThuong.TabStop = true;
            this.rdChinhSachThuong.Text = "Chính sách thông thường (khi bán hàng chỉ được chọn 1 chính sách)";
            this.rdChinhSachThuong.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(154, 18);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnUpdate.Size = new System.Drawing.Size(80, 30);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "Xác nhận";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grpThucThi
            // 
            this.grpThucThi.Controls.Add(this.btnClose);
            this.grpThucThi.Controls.Add(this.btnUpdate);
            this.grpThucThi.ForeColor = System.Drawing.Color.Black;
            this.grpThucThi.Location = new System.Drawing.Point(6, 118);
            this.grpThucThi.Name = "grpThucThi";
            this.grpThucThi.Size = new System.Drawing.Size(471, 60);
            this.grpThucThi.TabIndex = 43;
            this.grpThucThi.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(238, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "&Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCS_LapChinhSachKM_ChonType
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(483, 186);
            this.Controls.Add(this.grpThucThi);
            this.Controls.Add(this.GroupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCS_LapChinhSachKM_ChonType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn loại chính sách khuyến mại";
            this.Load += new System.EventHandler(this.frmKhoHienTai_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.grpThucThi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.GroupBox grpThucThi;
        internal GtidButton btnUpdate;
        internal GtidButton btnClose;
        private System.Windows.Forms.RadioButton rdChinhSachMDinh;
        private System.Windows.Forms.RadioButton rdChinhSachThuong;
        private System.Windows.Forms.RadioButton rdChinhSachCKhau;
    }
}