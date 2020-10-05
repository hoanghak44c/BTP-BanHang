using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frmCS_BangGia_ApDungTG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCS_BangGia_ApDungTG));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkKhungGio = new System.Windows.Forms.CheckBox();
            this.nudGioDen = new System.Windows.Forms.DateTimePicker();
            this.nudGioTu = new System.Windows.Forms.DateTimePicker();
            this.cboThu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboNgay = new System.Windows.Forms.ComboBox();
            this.lblNganHangTT = new System.Windows.Forms.Label();
            this.btnThanhToan = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new QLBH.Core.Form.GtidButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkKhungGio);
            this.groupBox1.Controls.Add(this.nudGioDen);
            this.groupBox1.Controls.Add(this.nudGioTu);
            this.groupBox1.Controls.Add(this.cboThu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboNgay);
            this.groupBox1.Controls.Add(this.lblNganHangTT);
            this.groupBox1.Location = new System.Drawing.Point(10, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 130);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkKhungGio
            // 
            this.chkKhungGio.AutoSize = true;
            this.chkKhungGio.Location = new System.Drawing.Point(96, 75);
            this.chkKhungGio.Name = "chkKhungGio";
            this.chkKhungGio.Size = new System.Drawing.Size(87, 17);
            this.chkKhungGio.TabIndex = 24;
            this.chkKhungGio.Text = "Khung giờ từ";
            this.chkKhungGio.UseVisualStyleBackColor = true;
            this.chkKhungGio.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // nudGioDen
            // 
            this.nudGioDen.CustomFormat = "HH:mm";
            this.nudGioDen.Enabled = false;
            this.nudGioDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.nudGioDen.Location = new System.Drawing.Point(181, 95);
            this.nudGioDen.Name = "nudGioDen";
            this.nudGioDen.ShowUpDown = true;
            this.nudGioDen.Size = new System.Drawing.Size(52, 21);
            this.nudGioDen.TabIndex = 23;
            this.nudGioDen.Value = new System.DateTime(2012, 12, 6, 17, 34, 0, 0);
            // 
            // nudGioTu
            // 
            this.nudGioTu.CustomFormat = "HH:mm";
            this.nudGioTu.Enabled = false;
            this.nudGioTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.nudGioTu.Location = new System.Drawing.Point(96, 95);
            this.nudGioTu.Name = "nudGioTu";
            this.nudGioTu.ShowUpDown = true;
            this.nudGioTu.Size = new System.Drawing.Size(52, 21);
            this.nudGioTu.TabIndex = 10;
            // 
            // cboThu
            // 
            this.cboThu.FormattingEnabled = true;
            this.cboThu.Items.AddRange(new object[] {
            "Chủ nhật",
            "Thứ hai",
            "Thứ ba",
            "Thứ tư",
            "Thứ năm",
            "Thứ sáu",
            "Thứ bảy"});
            this.cboThu.Location = new System.Drawing.Point(97, 21);
            this.cboThu.Name = "cboThu";
            this.cboThu.Size = new System.Drawing.Size(137, 21);
            this.cboThu.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(46, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Thứ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(151, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "đến";
            // 
            // cboNgay
            // 
            this.cboNgay.FormattingEnabled = true;
            this.cboNgay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cboNgay.Location = new System.Drawing.Point(97, 47);
            this.cboNgay.Name = "cboNgay";
            this.cboNgay.Size = new System.Drawing.Size(137, 21);
            this.cboNgay.TabIndex = 20;
            // 
            // lblNganHangTT
            // 
            this.lblNganHangTT.AutoSize = true;
            this.lblNganHangTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNganHangTT.Location = new System.Drawing.Point(40, 50);
            this.lblNganHangTT.Name = "lblNganHangTT";
            this.lblNganHangTT.Size = new System.Drawing.Size(32, 13);
            this.lblNganHangTT.TabIndex = 22;
            this.lblNganHangTT.Text = "Ngày";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.Location = new System.Drawing.Point(62, 152);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(102, 28);
            this.btnThanhToan.TabIndex = 25;
            this.btnThanhToan.Text = "&Chấp nhận (F2)";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(170, 152);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnClose.Size = new System.Drawing.Size(95, 28);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Thoát (ESC)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCS_BangGia_ApDungTG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 188);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCS_BangGia_ApDungTG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn khung thời gian áp dụng";
            this.Load += new System.EventHandler(this.frmCS_BangGia_ApDungTG_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPhieuXuat_TraTienThua_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private GtidButton btnClose;
        private System.Windows.Forms.ComboBox cboThu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboNgay;
        private System.Windows.Forms.Label lblNganHangTT;
        private System.Windows.Forms.DateTimePicker nudGioTu;
        private System.Windows.Forms.DateTimePicker nudGioDen;
        private System.Windows.Forms.CheckBox chkKhungGio;
        private DevExpress.XtraEditors.SimpleButton btnThanhToan;
    }
}