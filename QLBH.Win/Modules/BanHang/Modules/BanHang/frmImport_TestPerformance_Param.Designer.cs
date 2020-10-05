using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frmImport_TestPerformance_Param
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImport_TestPerformance_Param));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoChungTu = new System.Windows.Forms.TextBox();
            this.lblSoCT = new System.Windows.Forms.Label();
            this.txtSoLanLap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboKichBanTest = new System.Windows.Forms.ComboBox();
            this.txtSoUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThoiGianHanhDong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNganHangTT = new System.Windows.Forms.Label();
            this.btnAccept = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new QLBH.Core.Form.GtidButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoChungTu);
            this.groupBox1.Controls.Add(this.lblSoCT);
            this.groupBox1.Controls.Add(this.txtSoLanLap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboKichBanTest);
            this.groupBox1.Controls.Add(this.txtSoUser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtThoiGianHanhDong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblNganHangTT);
            this.groupBox1.Location = new System.Drawing.Point(10, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtSoChungTu
            // 
            this.txtSoChungTu.Location = new System.Drawing.Point(148, 130);
            this.txtSoChungTu.Name = "txtSoChungTu";
            this.txtSoChungTu.Size = new System.Drawing.Size(237, 21);
            this.txtSoChungTu.TabIndex = 4;
            // 
            // lblSoCT
            // 
            this.lblSoCT.AutoSize = true;
            this.lblSoCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoCT.Location = new System.Drawing.Point(38, 130);
            this.lblSoCT.Name = "lblSoCT";
            this.lblSoCT.Size = new System.Drawing.Size(86, 13);
            this.lblSoCT.TabIndex = 134;
            this.lblSoCT.Text = "Số chứng từ gốc";
            // 
            // txtSoLanLap
            // 
            this.txtSoLanLap.Location = new System.Drawing.Point(244, 44);
            this.txtSoLanLap.Name = "txtSoLanLap";
            this.txtSoLanLap.Size = new System.Drawing.Size(141, 21);
            this.txtSoLanLap.TabIndex = 1;
            this.txtSoLanLap.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(38, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 124;
            this.label2.Text = "Số lần lặp";
            // 
            // cboKichBanTest
            // 
            this.cboKichBanTest.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cboKichBanTest.FormattingEnabled = true;
            this.cboKichBanTest.Items.AddRange(new object[] {
            "1. Lập đơn hàng => Thu tiền",
            "2. Lập đơn hàng => Thu tiền => Xuất kho",
            "3. Báo cáo tồn mã vạch hiện tại",
            "4. Báo cáo danh sách đơn hàng bán",
            "5. Báo cáo phiếu thu tiền",
            "6. Bảng giá hiện tại"});
            this.cboKichBanTest.Location = new System.Drawing.Point(148, 101);
            this.cboKichBanTest.Name = "cboKichBanTest";
            this.cboKichBanTest.Size = new System.Drawing.Size(237, 21);
            this.cboKichBanTest.TabIndex = 3;
            this.cboKichBanTest.SelectedIndexChanged += new System.EventHandler(this.cboKichBanTest_SelectedIndexChanged);
            // 
            // txtSoUser
            // 
            this.txtSoUser.Location = new System.Drawing.Point(244, 17);
            this.txtSoUser.Name = "txtSoUser";
            this.txtSoUser.Size = new System.Drawing.Size(141, 21);
            this.txtSoUser.TabIndex = 0;
            this.txtSoUser.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(38, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Số user thực hiện";
            // 
            // txtThoiGianHanhDong
            // 
            this.txtThoiGianHanhDong.Location = new System.Drawing.Point(244, 72);
            this.txtThoiGianHanhDong.Name = "txtThoiGianHanhDong";
            this.txtThoiGianHanhDong.Size = new System.Drawing.Size(141, 21);
            this.txtThoiGianHanhDong.TabIndex = 2;
            this.txtThoiGianHanhDong.Text = "1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(38, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Thời gian giữa các lần lặp (mili giây)";
            // 
            // lblNganHangTT
            // 
            this.lblNganHangTT.AutoSize = true;
            this.lblNganHangTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNganHangTT.Location = new System.Drawing.Point(38, 102);
            this.lblNganHangTT.Name = "lblNganHangTT";
            this.lblNganHangTT.Size = new System.Drawing.Size(96, 13);
            this.lblNganHangTT.TabIndex = 22;
            this.lblNganHangTT.Text = "Kịch bản thực hiện";
            // 
            // btnAccept
            // 
            this.btnAccept.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.Image")));
            this.btnAccept.Location = new System.Drawing.Point(127, 194);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(91, 28);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Chấp nhận";
            this.btnAccept.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(222, 194);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnClose.Size = new System.Drawing.Size(91, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Thoát (ESC)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmImport_TestPerformance_Param
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 231);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImport_TestPerformance_Param";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tham số thực hiện";
            this.Load += new System.EventHandler(this.frmPhieuXuat_TraTienThua_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private GtidButton btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNganHangTT;
        private System.Windows.Forms.TextBox txtThoiGianHanhDong;
        private System.Windows.Forms.TextBox txtSoUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboKichBanTest;
        private System.Windows.Forms.TextBox txtSoLanLap;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnAccept;
        private System.Windows.Forms.TextBox txtSoChungTu;
        private System.Windows.Forms.Label lblSoCT;
    }
}