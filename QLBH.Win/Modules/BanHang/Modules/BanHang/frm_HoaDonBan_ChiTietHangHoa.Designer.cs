using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frm_HoaDonBan_ChiTietHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HoaDonBan_ChiTietHangHoa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnThem = new GtidButton();
            this.txtMaVach = new GtidTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.MaVach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienChietKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdChiTietHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemove = new GtidButton();
            this.btnXoa = new GtidButton();
            this.btnGhi = new GtidButton();
            this.btnDong = new GtidButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblTyLeChietKhau = new System.Windows.Forms.Label();
            this.lblTongTienChietKhau = new System.Windows.Forms.Label();
            this.lblTongThanhTien = new System.Windows.Forms.Label();
            this.lblTongSoLuong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTieuDe.Location = new System.Drawing.Point(9, 16);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(63, 13);
            this.lblTieuDe.TabIndex = 2;
            this.lblTieuDe.Text = "Sản phẩm";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            //this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(380, 71);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 44);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "    &Thêm hàng";
            //this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaVach
            // 
            this.txtMaVach.BackColor = System.Drawing.Color.PowderBlue;
            this.txtMaVach.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaVach.Location = new System.Drawing.Point(88, 71);
            this.txtMaVach.Name = "txtMaVach";
            this.txtMaVach.Size = new System.Drawing.Size(270, 44);
            this.txtMaVach.TabIndex = 15;
            this.txtMaVach.Text = "01234567890";
            this.txtMaVach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mã vạch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Đơn giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tỷ lệ chiết khấu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(904, -23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã vạch";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaVach,
            this.DonViTinh,
            this.SoLuong,
            this.TienChietKhau,
            this.ThanhTien,
            this.IdSanPham,
            this.IdChiTietHangHoa});
            this.dgvList.Location = new System.Drawing.Point(13, 121);
            this.dgvList.Name = "dgvList";
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(621, 187);
            this.dgvList.TabIndex = 17;
            this.dgvList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellValueChanged);
            // 
            // MaVach
            // 
            this.MaVach.DataPropertyName = "MaVach";
            this.MaVach.HeaderText = "Mã vạch";
            this.MaVach.Name = "MaVach";
            this.MaVach.ReadOnly = true;
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "TenDonViTinh";
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.SoLuong.DefaultCellStyle = dataGridViewCellStyle1;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // TienChietKhau
            // 
            this.TienChietKhau.DataPropertyName = "TienChietKhau";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.TienChietKhau.DefaultCellStyle = dataGridViewCellStyle2;
            this.TienChietKhau.HeaderText = "Tiền CK";
            this.TienChietKhau.Name = "TienChietKhau";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.ThanhTien.DefaultCellStyle = dataGridViewCellStyle3;
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // IdSanPham
            // 
            this.IdSanPham.DataPropertyName = "IdSanPham";
            this.IdSanPham.HeaderText = "IdSanPham";
            this.IdSanPham.Name = "IdSanPham";
            this.IdSanPham.Visible = false;
            // 
            // IdChiTietHangHoa
            // 
            this.IdChiTietHangHoa.DataPropertyName = "IdChiTietHangHoa";
            this.IdChiTietHangHoa.HeaderText = "IdChiTietHangHoa";
            this.IdChiTietHangHoa.Name = "IdChiTietHangHoa";
            this.IdChiTietHangHoa.Visible = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(24, 314);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(30, 25);
            this.btnRemove.TabIndex = 20;
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(278, 371);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 25);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "   &Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnGhi
            // 
            this.btnGhi.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.Image")));
            this.btnGhi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGhi.Location = new System.Drawing.Point(194, 371);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(80, 25);
            this.btnGhi.TabIndex = 18;
            this.btnGhi.Text = "    &Cập nhật";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(364, 371);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(80, 25);
            this.btnDong.TabIndex = 21;
            this.btnDong.Text = "   T&hoát";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tổng số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tổng tiền chiết khấu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tổng thành tiền";
            // 
            // lblMa
            // 
            this.lblMa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblMa.Location = new System.Drawing.Point(85, 16);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(63, 13);
            this.lblMa.TabIndex = 2;
            this.lblMa.Text = "Sản phẩm";
            this.lblMa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDonGia
            // 
            this.lblDonGia.Location = new System.Drawing.Point(554, 16);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(80, 14);
            this.lblDonGia.TabIndex = 14;
            this.lblDonGia.Text = "Đơn giá";
            this.lblDonGia.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTyLeChietKhau
            // 
            this.lblTyLeChietKhau.Location = new System.Drawing.Point(551, 40);
            this.lblTyLeChietKhau.Name = "lblTyLeChietKhau";
            this.lblTyLeChietKhau.Size = new System.Drawing.Size(83, 13);
            this.lblTyLeChietKhau.TabIndex = 14;
            this.lblTyLeChietKhau.Text = "Tỷ lệ chiết khấu";
            this.lblTyLeChietKhau.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTongTienChietKhau
            // 
            this.lblTongTienChietKhau.Location = new System.Drawing.Point(529, 317);
            this.lblTongTienChietKhau.Name = "lblTongTienChietKhau";
            this.lblTongTienChietKhau.Size = new System.Drawing.Size(105, 13);
            this.lblTongTienChietKhau.TabIndex = 14;
            this.lblTongTienChietKhau.Text = "Tổng tiền chiết khấu";
            this.lblTongTienChietKhau.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTongThanhTien
            // 
            this.lblTongThanhTien.Location = new System.Drawing.Point(529, 345);
            this.lblTongThanhTien.Name = "lblTongThanhTien";
            this.lblTongThanhTien.Size = new System.Drawing.Size(105, 13);
            this.lblTongThanhTien.TabIndex = 14;
            this.lblTongThanhTien.Text = "Tổng thành tiền";
            this.lblTongThanhTien.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTongSoLuong
            // 
            this.lblTongSoLuong.AutoSize = true;
            this.lblTongSoLuong.Location = new System.Drawing.Point(315, 317);
            this.lblTongSoLuong.Name = "lblTongSoLuong";
            this.lblTongSoLuong.Size = new System.Drawing.Size(75, 13);
            this.lblTongSoLuong.TabIndex = 14;
            this.lblTongSoLuong.Text = "Tổng số lượng";
            // 
            // frm_HoaDonBan_ChiTietHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 408);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMaVach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTyLeChietKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTongThanhTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTongTienChietKhau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lblTongSoLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_HoaDonBan_ChiTietHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết hàng hóa bán";
            this.Load += new System.EventHandler(this.frm_HoaDonBan_ChiTietHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        internal QLBH.Core.Form.GtidButton btnThem;
        private System.Windows.Forms.TextBox txtMaVach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvList;
        internal QLBH.Core.Form.GtidButton btnRemove;
        internal QLBH.Core.Form.GtidButton btnXoa;
        internal QLBH.Core.Form.GtidButton btnGhi;
        internal QLBH.Core.Form.GtidButton btnDong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblTyLeChietKhau;
        private System.Windows.Forms.Label lblTongTienChietKhau;
        private System.Windows.Forms.Label lblTongThanhTien;
        private System.Windows.Forms.Label lblTongSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVach;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienChietKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdChiTietHangHoa;
    }
}