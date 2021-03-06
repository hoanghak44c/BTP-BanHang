using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frmCS_BangGia_ApDungKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCS_BangGia_ApDungKH));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboLoaiDoiTuong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvShop = new System.Windows.Forms.DataGridView();
            this.colApDung = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colIdLoaiDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaLoaiDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLoaiDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkChonDuyet = new System.Windows.Forms.CheckBox();
            this.cmdThoat = new QLBH.Core.Form.GtidButton();
            this.cmdApDung = new QLBH.Core.Form.GtidButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShop)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboLoaiDoiTuong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dgvShop);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 231);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhóm khách hàng";
            // 
            // cboLoaiDoiTuong
            // 
            this.cboLoaiDoiTuong.FormattingEnabled = true;
            this.cboLoaiDoiTuong.Location = new System.Drawing.Point(112, 17);
            this.cboLoaiDoiTuong.Name = "cboLoaiDoiTuong";
            this.cboLoaiDoiTuong.Size = new System.Drawing.Size(362, 21);
            this.cboLoaiDoiTuong.TabIndex = 86;
            this.cboLoaiDoiTuong.SelectedIndexChanged += new System.EventHandler(this.cboLoaiDoiTuong_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(12, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 87;
            this.label5.Text = "Nhóm khách hàng";
            // 
            // dgvShop
            // 
            this.dgvShop.AllowUserToAddRows = false;
            this.dgvShop.AllowUserToDeleteRows = false;
            this.dgvShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colApDung,
            this.colIdLoaiDT,
            this.colMaLoaiDT,
            this.colTenLoaiDT});
            this.dgvShop.Location = new System.Drawing.Point(6, 44);
            this.dgvShop.Name = "dgvShop";
            this.dgvShop.RowHeadersWidth = 20;
            this.dgvShop.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvShop.Size = new System.Drawing.Size(468, 176);
            this.dgvShop.TabIndex = 85;
            // 
            // colApDung
            // 
            this.colApDung.HeaderText = "Áp dụng";
            this.colApDung.Name = "colApDung";
            this.colApDung.Width = 60;
            // 
            // colIdLoaiDT
            // 
            this.colIdLoaiDT.HeaderText = "IdLoaiDT";
            this.colIdLoaiDT.Name = "colIdLoaiDT";
            this.colIdLoaiDT.Visible = false;
            // 
            // colMaLoaiDT
            // 
            this.colMaLoaiDT.HeaderText = "Mã";
            this.colMaLoaiDT.Name = "colMaLoaiDT";
            this.colMaLoaiDT.ReadOnly = true;
            this.colMaLoaiDT.Width = 120;
            // 
            // colTenLoaiDT
            // 
            this.colTenLoaiDT.HeaderText = "Nhóm khách hàng";
            this.colTenLoaiDT.Name = "colTenLoaiDT";
            this.colTenLoaiDT.ReadOnly = true;
            this.colTenLoaiDT.Width = 250;
            // 
            // chkChonDuyet
            // 
            this.chkChonDuyet.AutoSize = true;
            this.chkChonDuyet.BackColor = System.Drawing.Color.Transparent;
            this.chkChonDuyet.Location = new System.Drawing.Point(27, 251);
            this.chkChonDuyet.Name = "chkChonDuyet";
            this.chkChonDuyet.Size = new System.Drawing.Size(93, 17);
            this.chkChonDuyet.TabIndex = 84;
            this.chkChonDuyet.Text = "Chọn/Bỏ chọn";
            this.chkChonDuyet.UseVisualStyleBackColor = false;
            this.chkChonDuyet.CheckedChanged += new System.EventHandler(this.chkChonDuyet_CheckedChanged);
            // 
            // cmdThoat
            // 
            this.cmdThoat.Image = ((System.Drawing.Image)(resources.GetObject("cmdThoat.Image")));
            this.cmdThoat.Location = new System.Drawing.Point(252, 251);
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
            this.cmdApDung.Location = new System.Drawing.Point(173, 251);
            this.cmdApDung.Name = "cmdApDung";
            this.cmdApDung.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdApDung.Size = new System.Drawing.Size(78, 27);
            this.cmdApDung.TabIndex = 63;
            this.cmdApDung.Text = "Áp dụng";
            this.cmdApDung.Click += new System.EventHandler(this.cmdApDung_Click);
            // 
            // frmCS_BangGia_ApDungKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 286);
            this.Controls.Add(this.chkChonDuyet);
            this.Controls.Add(this.cmdThoat);
            this.Controls.Add(this.cmdApDung);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCS_BangGia_ApDungKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn Danh sách khách hàng được áp dụng";
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn colApDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdLoaiDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLoaiDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoaiDT;
        private System.Windows.Forms.ComboBox cboLoaiDoiTuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkChonDuyet;
    }
}