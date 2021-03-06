using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frmBH_TinhTrangGiaoNhan_AddNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBH_TinhTrangGiaoNhan_AddNote));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTinhTrangGN = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtComment = new QLBH.Core.Form.GtidTextBox();
            this.cmdThoat = new QLBH.Core.Form.GtidButton();
            this.cmdApDung = new QLBH.Core.Form.GtidButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboTinhTrangGN);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtComment);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 231);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 131;
            this.label4.Text = "Ghi chú";
            // 
            // cboTinhTrangGN
            // 
            this.cboTinhTrangGN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhTrangGN.FormattingEnabled = true;
            this.cboTinhTrangGN.Items.AddRange(new object[] {
            "Phân công (Chưa đi giao,chờ xuất hàng)",
            "Đang giao hàng (đã xuất kho, đang đi giao)",
            "Đã giao hàng (giao nhận thành công)",
            "Hủy giao hàng (khách từ chối nhận hàng hoặc có vấn đề phát sinh)",
            "Nhập lại hàng (hàng giao bị nhập lại)"});
            this.cboTinhTrangGN.Location = new System.Drawing.Point(153, 17);
            this.cboTinhTrangGN.Name = "cboTinhTrangGN";
            this.cboTinhTrangGN.Size = new System.Drawing.Size(330, 21);
            this.cboTinhTrangGN.TabIndex = 129;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(6, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 13);
            this.label11.TabIndex = 130;
            this.label11.Text = "Trạng thái giao nhận";
            // 
            // txtComment
            // 
            this.txtComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComment.Location = new System.Drawing.Point(6, 56);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(477, 169);
            this.txtComment.TabIndex = 94;
            // 
            // cmdThoat
            // 
            this.cmdThoat.Image = ((System.Drawing.Image)(resources.GetObject("cmdThoat.Image")));
            this.cmdThoat.Location = new System.Drawing.Point(255, 251);
            this.cmdThoat.Name = "cmdThoat";
            this.cmdThoat.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdThoat.Size = new System.Drawing.Size(83, 27);
            this.cmdThoat.TabIndex = 64;
            this.cmdThoat.Text = "Thoát";
            this.cmdThoat.Click += new System.EventHandler(this.cmdThoat_Click);
            // 
            // cmdApDung
            // 
            this.cmdApDung.Image = ((System.Drawing.Image)(resources.GetObject("cmdApDung.Image")));
            this.cmdApDung.Location = new System.Drawing.Point(165, 251);
            this.cmdApDung.Name = "cmdApDung";
            this.cmdApDung.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdApDung.Size = new System.Drawing.Size(87, 27);
            this.cmdApDung.TabIndex = 63;
            this.cmdApDung.Text = "Chấp nhận";
            this.cmdApDung.Click += new System.EventHandler(this.cmdApDung_Click);
            // 
            // frmBH_TinhTrangGiaoNhan_AddNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 286);
            this.Controls.Add(this.cmdThoat);
            this.Controls.Add(this.cmdApDung);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBH_TinhTrangGiaoNhan_AddNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tình trạng giao nhận";
            this.Load += new System.EventHandler(this.frm_BangGia_ApDung_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GtidButton cmdThoat;
        private GtidButton cmdApDung;
        private System.Windows.Forms.GroupBox groupBox1;
        private GtidTextBox txtComment;
        private System.Windows.Forms.ComboBox cboTinhTrangGN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
    }
}