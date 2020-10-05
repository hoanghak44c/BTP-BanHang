using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frmBH_LuaChonInHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBH_LuaChonInHoaDon));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdHangKMKhongGia = new System.Windows.Forms.RadioButton();
            this.rdChietKhauKM = new System.Windows.Forms.RadioButton();
            this.rdInCungDong = new System.Windows.Forms.RadioButton();
            this.mstNgayInHoaDon = new System.Windows.Forms.DateTimePicker();
            this.label32 = new System.Windows.Forms.Label();
            this.btnClose = new QLBH.Core.Form.GtidButton();
            this.btnPrint = new QLBH.Core.Form.GtidButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdHangKMKhongGia);
            this.groupBox1.Controls.Add(this.rdChietKhauKM);
            this.groupBox1.Controls.Add(this.rdInCungDong);
            this.groupBox1.Location = new System.Drawing.Point(16, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 123);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rdHangKMKhongGia
            // 
            this.rdHangKMKhongGia.AutoSize = true;
            this.rdHangKMKhongGia.Checked = true;
            this.rdHangKMKhongGia.Location = new System.Drawing.Point(26, 24);
            this.rdHangKMKhongGia.Name = "rdHangKMKhongGia";
            this.rdHangKMKhongGia.Size = new System.Drawing.Size(424, 17);
            this.rdHangKMKhongGia.TabIndex = 2;
            this.rdHangKMKhongGia.TabStop = true;
            this.rdHangKMKhongGia.Text = "Hàng khuyến mại không có giá (vd: hàng chính 10,000,000đ; hàng khuyến mại: 0đ)";
            this.rdHangKMKhongGia.UseVisualStyleBackColor = true;
            // 
            // rdChietKhauKM
            // 
            this.rdChietKhauKM.AutoSize = true;
            this.rdChietKhauKM.Location = new System.Drawing.Point(26, 56);
            this.rdChietKhauKM.Name = "rdChietKhauKM";
            this.rdChietKhauKM.Size = new System.Drawing.Size(425, 17);
            this.rdChietKhauKM.TabIndex = 1;
            this.rdChietKhauKM.Text = "Hàng khuyến mại có giá (vd: hàng chính: 9,000,000đ; hàng khuyến mại:1,000,000)";
            this.rdChietKhauKM.UseVisualStyleBackColor = true;
            // 
            // rdInCungDong
            // 
            this.rdInCungDong.AutoSize = true;
            this.rdInCungDong.Location = new System.Drawing.Point(26, 88);
            this.rdInCungDong.Name = "rdInCungDong";
            this.rdInCungDong.Size = new System.Drawing.Size(436, 17);
            this.rdInCungDong.TabIndex = 0;
            this.rdInCungDong.Text = "Hàng chính và khuyến mại in cùng 1 dòng (vd: hàng chính + khuyến mại: 10,000,000)" +
                "";
            this.rdInCungDong.UseVisualStyleBackColor = true;
            // 
            // mstNgayInHoaDon
            // 
            this.mstNgayInHoaDon.CustomFormat = "dd/MM/yyyy HH:mm";
            this.mstNgayInHoaDon.Enabled = false;
            this.mstNgayInHoaDon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstNgayInHoaDon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mstNgayInHoaDon.Location = new System.Drawing.Point(120, 139);
            this.mstNgayInHoaDon.Name = "mstNgayInHoaDon";
            this.mstNgayInHoaDon.Size = new System.Drawing.Size(147, 22);
            this.mstNgayInHoaDon.TabIndex = 8;
            this.mstNgayInHoaDon.Value = new System.DateTime(2012, 8, 19, 0, 0, 0, 0);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(20, 143);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(96, 13);
            this.label32.TabIndex = 7;
            this.label32.Text = "Ngày in hóa đơn";
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(419, 138);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnClose.Size = new System.Drawing.Size(75, 25);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(340, 138);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnPrint.Size = new System.Drawing.Size(75, 25);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "In phiếu";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmBH_LuaChonInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 171);
            this.Controls.Add(this.mstNgayInHoaDon);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBH_LuaChonInHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn hình thức In hóa đơn";
            this.Load += new System.EventHandler(this.frmPhieuXuat_LuaChonIn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private QLBH.Core.Form.GtidButton btnPrint;
        private QLBH.Core.Form.GtidButton btnClose;
        private System.Windows.Forms.RadioButton rdInCungDong;
        private System.Windows.Forms.RadioButton rdHangKMKhongGia;
        private System.Windows.Forms.RadioButton rdChietKhauKM;
        private System.Windows.Forms.DateTimePicker mstNgayInHoaDon;
        private System.Windows.Forms.Label label32;
    }
}