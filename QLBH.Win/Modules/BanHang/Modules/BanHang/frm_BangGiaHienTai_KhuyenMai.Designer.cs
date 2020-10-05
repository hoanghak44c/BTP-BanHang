using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frm_BangGiaHienTai_KhuyenMai
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
            if (disposing && (components != null)) {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BangGiaHienTai_KhuyenMai));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gv = new System.Windows.Forms.DataGridView();
            this.gvKM = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdDong = new GtidButton();
            this.colIdKhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoKhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdChiTietBangGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdKhuyenMai1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKM)).BeginInit();
            this.SuspendLayout();
            // 
            // gv
            // 
            this.gv.AllowUserToAddRows = false;
            this.gv.AllowUserToDeleteRows = false;
            this.gv.AllowUserToOrderColumns = true;
            this.gv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdSanPham,
            this.IdSanPham,
            this.colMaSanPham,
            this.colTenSanPham,
            this.colDVT,
            this.colSoLuong,
            this.colTienKM,
            this.GhiChu,
            this.colIdKhuyenMai1});
            this.gv.Location = new System.Drawing.Point(12, 126);
            this.gv.Name = "gv";
            this.gv.RowHeadersVisible = false;
            this.gv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv.Size = new System.Drawing.Size(600, 143);
            this.gv.TabIndex = 7;
            // 
            // gvKM
            // 
            this.gvKM.AllowUserToAddRows = false;
            this.gvKM.AllowUserToDeleteRows = false;
            this.gvKM.AllowUserToOrderColumns = true;
            this.gvKM.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gvKM.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gvKM.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvKM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gvKM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvKM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdKhuyenMai,
            this.colSoKhuyenMai,
            this.colMoTa,
            this.colIdChiTietBangGia});
            this.gvKM.Location = new System.Drawing.Point(12, 12);
            this.gvKM.Name = "gvKM";
            this.gvKM.ReadOnly = true;
            this.gvKM.RowHeadersVisible = false;
            this.gvKM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvKM.Size = new System.Drawing.Size(600, 108);
            this.gvKM.TabIndex = 50;
            this.gvKM.SelectionChanged += new System.EventHandler(this.gvKM_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(11, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 8);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // cmdDong
            // 
            this.cmdDong.Image = ((System.Drawing.Image)(resources.GetObject("cmdDong.Image")));
            //this.cmdDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdDong.Location = new System.Drawing.Point(526, 296);
            this.cmdDong.Name = "cmdDong";
            this.cmdDong.Size = new System.Drawing.Size(86, 25);
            this.cmdDong.TabIndex = 64;
            this.cmdDong.Text = "   T&hoát (F12)";
            //this.cmdDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdDong.UseVisualStyleBackColor = true;
            this.cmdDong.Click += new System.EventHandler(this.cmdDong_Click);
            // 
            // colIdKhuyenMai
            // 
            this.colIdKhuyenMai.DataPropertyName = "IdKhuyenMai";
            dataGridViewCellStyle9.NullValue = "0";
            this.colIdKhuyenMai.DefaultCellStyle = dataGridViewCellStyle9;
            this.colIdKhuyenMai.HeaderText = "ID";
            this.colIdKhuyenMai.Name = "colIdKhuyenMai";
            this.colIdKhuyenMai.ReadOnly = true;
            this.colIdKhuyenMai.Visible = false;
            this.colIdKhuyenMai.Width = 80;
            // 
            // colSoKhuyenMai
            // 
            this.colSoKhuyenMai.DataPropertyName = "SoKhuyenMai";
            this.colSoKhuyenMai.HeaderText = "Số khuyến mại";
            this.colSoKhuyenMai.Name = "colSoKhuyenMai";
            this.colSoKhuyenMai.ReadOnly = true;
            this.colSoKhuyenMai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSoKhuyenMai.Width = 200;
            // 
            // colMoTa
            // 
            this.colMoTa.DataPropertyName = "GhiChu";
            this.colMoTa.HeaderText = "Mô tả";
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.ReadOnly = true;
            this.colMoTa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colMoTa.Width = 380;
            // 
            // colIdChiTietBangGia
            // 
            this.colIdChiTietBangGia.DataPropertyName = "IdChiTietBangGia";
            this.colIdChiTietBangGia.HeaderText = "IdChiTietBangGia";
            this.colIdChiTietBangGia.Name = "colIdChiTietBangGia";
            this.colIdChiTietBangGia.ReadOnly = true;
            this.colIdChiTietBangGia.Visible = false;
            // 
            // colIdSanPham
            // 
            this.colIdSanPham.DataPropertyName = "IdChiTiet";
            dataGridViewCellStyle3.NullValue = "0";
            this.colIdSanPham.DefaultCellStyle = dataGridViewCellStyle3;
            this.colIdSanPham.HeaderText = "IdChiTiet";
            this.colIdSanPham.Name = "colIdSanPham";
            this.colIdSanPham.ReadOnly = true;
            this.colIdSanPham.Visible = false;
            this.colIdSanPham.Width = 80;
            // 
            // IdSanPham
            // 
            this.IdSanPham.DataPropertyName = "IdSanPham";
            this.IdSanPham.HeaderText = "IdSanPham";
            this.IdSanPham.Name = "IdSanPham";
            this.IdSanPham.ReadOnly = true;
            this.IdSanPham.Visible = false;
            // 
            // colMaSanPham
            // 
            this.colMaSanPham.DataPropertyName = "MaSanPham";
            this.colMaSanPham.HeaderText = "Mã SP";
            this.colMaSanPham.Name = "colMaSanPham";
            this.colMaSanPham.ReadOnly = true;
            this.colMaSanPham.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTenSanPham
            // 
            this.colTenSanPham.DataPropertyName = "TenSanPham";
            this.colTenSanPham.HeaderText = "Tên sản phẩm";
            this.colTenSanPham.Name = "colTenSanPham";
            this.colTenSanPham.ReadOnly = true;
            this.colTenSanPham.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTenSanPham.Width = 250;
            // 
            // colDVT
            // 
            this.colDVT.DataPropertyName = "TenDonViTinh";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            this.colDVT.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDVT.HeaderText = "ĐVT";
            this.colDVT.Name = "colDVT";
            this.colDVT.ReadOnly = true;
            this.colDVT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDVT.Width = 70;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.colSoLuong.DefaultCellStyle = dataGridViewCellStyle5;
            this.colSoLuong.HeaderText = "SL";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            this.colSoLuong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSoLuong.Width = 50;
            // 
            // colTienKM
            // 
            this.colTienKM.DataPropertyName = "SoTien";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.colTienKM.DefaultCellStyle = dataGridViewCellStyle6;
            this.colTienKM.HeaderText = "Tiền KM";
            this.colTienKM.Name = "colTienKM";
            this.colTienKM.ReadOnly = true;
            this.colTienKM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "GhiChu";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            this.GhiChu.Visible = false;
            // 
            // colIdKhuyenMai1
            // 
            this.colIdKhuyenMai1.DataPropertyName = "IdKhuyenMai";
            this.colIdKhuyenMai1.HeaderText = "IdKhuyenMai";
            this.colIdKhuyenMai1.Name = "colIdKhuyenMai1";
            this.colIdKhuyenMai1.ReadOnly = true;
            this.colIdKhuyenMai1.Visible = false;
            // 
            // frm_BangGiaHienTai_KhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 336);
            this.Controls.Add(this.cmdDong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gvKM);
            this.Controls.Add(this.gv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_BangGiaHienTai_KhuyenMai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khuyến mại";
            this.Load += new System.EventHandler(this.frm_BangGiaHienTai_KhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.DataGridView gvKM;
        private System.Windows.Forms.GroupBox groupBox1;
        internal QLBH.Core.Form.GtidButton cmdDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdKhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoKhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdChiTietBangGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdKhuyenMai1;

    }
}