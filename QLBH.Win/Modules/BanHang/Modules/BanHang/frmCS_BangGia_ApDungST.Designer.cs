using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frmCS_BangGia_ApDungST
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCS_BangGia_ApDungST));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSoLuongDH = new QLBH.Core.Form.GtidTextBox();
            this.cboTrungTam = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvShop = new System.Windows.Forms.DataGridView();
            this.colApDung = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colIdKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkChonDuyet = new System.Windows.Forms.CheckBox();
            this.cmdThoat = new QLBH.Core.Form.GtidButton();
            this.cmdApDung = new QLBH.Core.Form.GtidButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShop)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtSoLuongDH);
            this.groupBox1.Controls.Add(this.cboTrungTam);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dgvShop);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 231);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách trung tâm, siêu thị";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(339, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 13);
            this.label15.TabIndex = 93;
            this.label15.Text = "SL đơn hàng";
            // 
            // txtSoLuongDH
            // 
            this.txtSoLuongDH.Location = new System.Drawing.Point(409, 20);
            this.txtSoLuongDH.Name = "txtSoLuongDH";
            this.txtSoLuongDH.Size = new System.Drawing.Size(74, 21);
            this.txtSoLuongDH.TabIndex = 94;
            // 
            // cboTrungTam
            // 
            this.cboTrungTam.FormattingEnabled = true;
            this.cboTrungTam.Location = new System.Drawing.Point(106, 20);
            this.cboTrungTam.Name = "cboTrungTam";
            this.cboTrungTam.Size = new System.Drawing.Size(233, 21);
            this.cboTrungTam.TabIndex = 67;
            this.cboTrungTam.SelectedIndexChanged += new System.EventHandler(this.cboTrungTam_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Trung tâm, siêu thị";
            // 
            // dgvShop
            // 
            this.dgvShop.AllowUserToAddRows = false;
            this.dgvShop.AllowUserToDeleteRows = false;
            this.dgvShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colApDung,
            this.colIdKho,
            this.colMaKho,
            this.colTenKho});
            this.dgvShop.Location = new System.Drawing.Point(6, 54);
            this.dgvShop.Name = "dgvShop";
            this.dgvShop.RowHeadersWidth = 20;
            this.dgvShop.Size = new System.Drawing.Size(477, 166);
            this.dgvShop.TabIndex = 85;
            this.dgvShop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShop_CellContentClick);
            // 
            // colApDung
            // 
            this.colApDung.HeaderText = "Áp dụng";
            this.colApDung.Name = "colApDung";
            this.colApDung.Width = 60;
            // 
            // colIdKho
            // 
            this.colIdKho.HeaderText = "IdKho";
            this.colIdKho.Name = "colIdKho";
            this.colIdKho.Visible = false;
            // 
            // colMaKho
            // 
            this.colMaKho.HeaderText = "Mã";
            this.colMaKho.Name = "colMaKho";
            this.colMaKho.ReadOnly = true;
            this.colMaKho.Width = 120;
            // 
            // colTenKho
            // 
            this.colTenKho.HeaderText = "Tên kho";
            this.colTenKho.Name = "colTenKho";
            this.colTenKho.ReadOnly = true;
            this.colTenKho.Width = 270;
            // 
            // chkChonDuyet
            // 
            this.chkChonDuyet.AutoSize = true;
            this.chkChonDuyet.BackColor = System.Drawing.Color.Transparent;
            this.chkChonDuyet.Location = new System.Drawing.Point(33, 247);
            this.chkChonDuyet.Name = "chkChonDuyet";
            this.chkChonDuyet.Size = new System.Drawing.Size(93, 17);
            this.chkChonDuyet.TabIndex = 83;
            this.chkChonDuyet.Text = "Chọn/Bỏ chọn";
            this.chkChonDuyet.UseVisualStyleBackColor = false;
            this.chkChonDuyet.CheckedChanged += new System.EventHandler(this.chkChonDuyet_CheckedChanged);
            // 
            // cmdThoat
            // 
            this.cmdThoat.Image = ((System.Drawing.Image)(resources.GetObject("cmdThoat.Image")));
            this.cmdThoat.Location = new System.Drawing.Point(255, 251);
            this.cmdThoat.Name = "cmdThoat";
            this.cmdThoat.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdThoat.Size = new System.Drawing.Size(78, 27);
            this.cmdThoat.TabIndex = 64;
            this.cmdThoat.Text = "Thoát";
            this.cmdThoat.Click += new System.EventHandler(this.cmdThoat_Click);
            // 
            // cmdApDung
            // 
            this.cmdApDung.Image = ((System.Drawing.Image)(resources.GetObject("cmdApDung.Image")));
            this.cmdApDung.Location = new System.Drawing.Point(176, 251);
            this.cmdApDung.Name = "cmdApDung";
            this.cmdApDung.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdApDung.Size = new System.Drawing.Size(78, 27);
            this.cmdApDung.TabIndex = 63;
            this.cmdApDung.Text = "Áp dụng";
            this.cmdApDung.Click += new System.EventHandler(this.cmdApDung_Click);
            // 
            // frmCS_BangGia_ApDungST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 286);
            this.Controls.Add(this.chkChonDuyet);
            this.Controls.Add(this.cmdThoat);
            this.Controls.Add(this.cmdApDung);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCS_BangGia_ApDungST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn trung tâm, siêu thị được áp dụng";
            this.Load += new System.EventHandler(this.frm_BangGia_ApDung_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GtidButton cmdThoat;
        private GtidButton cmdApDung;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvShop;
        private System.Windows.Forms.ComboBox cboTrungTam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkChonDuyet;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colApDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKho;
        private System.Windows.Forms.Label label15;
        private GtidTextBox txtSoLuongDH;
    }
}