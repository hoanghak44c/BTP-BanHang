using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frmCS_ChonTrungTam
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCS_ChonTrungTam));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.chkChon = new System.Windows.Forms.CheckBox();
            this.dgvShop = new System.Windows.Forms.DataGridView();
            this.colApDung = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colIdTrungTam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaTrungTam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenTrungTam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new QLBH.Core.Form.GtidButton();
            this.grpThucThi = new System.Windows.Forms.GroupBox();
            this.btnClose = new QLBH.Core.Form.GtidButton();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShop)).BeginInit();
            this.grpThucThi.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Controls.Add(this.chkChon);
            this.GroupBox1.Controls.Add(this.dgvShop);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(8, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(537, 250);
            this.GroupBox1.TabIndex = 4;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Chọn trung tâm cần tạo bảng giá";
            // 
            // chkChon
            // 
            this.chkChon.AutoSize = true;
            this.chkChon.Location = new System.Drawing.Point(431, 14);
            this.chkChon.Name = "chkChon";
            this.chkChon.Size = new System.Drawing.Size(94, 17);
            this.chkChon.TabIndex = 45;
            this.chkChon.Text = "chọn/bỏ chọn";
            this.chkChon.UseVisualStyleBackColor = true;
            this.chkChon.CheckedChanged += new System.EventHandler(this.chkChon_CheckedChanged);
            // 
            // dgvShop
            // 
            this.dgvShop.AllowUserToAddRows = false;
            this.dgvShop.AllowUserToDeleteRows = false;
            this.dgvShop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colApDung,
            this.colIdTrungTam,
            this.colMaTrungTam,
            this.colTenTrungTam});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShop.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShop.Location = new System.Drawing.Point(8, 34);
            this.dgvShop.Name = "dgvShop";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShop.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShop.RowHeadersWidth = 20;
            this.dgvShop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShop.Size = new System.Drawing.Size(520, 207);
            this.dgvShop.TabIndex = 86;
            this.dgvShop.DoubleClick += new System.EventHandler(this.dgvShop_DoubleClick);
            // 
            // colApDung
            // 
            this.colApDung.HeaderText = "Áp dụng";
            this.colApDung.Name = "colApDung";
            this.colApDung.Width = 60;
            // 
            // colIdTrungTam
            // 
            this.colIdTrungTam.HeaderText = "IdTrungTam";
            this.colIdTrungTam.Name = "colIdTrungTam";
            this.colIdTrungTam.Visible = false;
            // 
            // colMaTrungTam
            // 
            this.colMaTrungTam.HeaderText = "Mã";
            this.colMaTrungTam.Name = "colMaTrungTam";
            this.colMaTrungTam.ReadOnly = true;
            this.colMaTrungTam.Width = 120;
            // 
            // colTenTrungTam
            // 
            this.colTenTrungTam.HeaderText = "Tên trung tâm";
            this.colTenTrungTam.Name = "colTenTrungTam";
            this.colTenTrungTam.ReadOnly = true;
            this.colTenTrungTam.Width = 300;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Trung tâm";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(179, 17);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnUpdate.Size = new System.Drawing.Size(80, 25);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "Xác nhận";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grpThucThi
            // 
            this.grpThucThi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThucThi.Controls.Add(this.btnClose);
            this.grpThucThi.Controls.Add(this.btnUpdate);
            this.grpThucThi.ForeColor = System.Drawing.Color.Black;
            this.grpThucThi.Location = new System.Drawing.Point(8, 263);
            this.grpThucThi.Name = "grpThucThi";
            this.grpThucThi.Size = new System.Drawing.Size(537, 50);
            this.grpThucThi.TabIndex = 43;
            this.grpThucThi.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(263, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnClose.Size = new System.Drawing.Size(80, 25);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "&Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCS_ChonTrungTam
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(549, 319);
            this.Controls.Add(this.grpThucThi);
            this.Controls.Add(this.GroupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCS_ChonTrungTam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn trung tâm";
            this.Load += new System.EventHandler(this.frmKhoHienTai_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShop)).EndInit();
            this.grpThucThi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.GroupBox grpThucThi;
        internal GtidButton btnUpdate;
        internal System.Windows.Forms.Label label2;
        internal GtidButton btnClose;
        private System.Windows.Forms.CheckBox chkChon;
        private System.Windows.Forms.DataGridView dgvShop;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colApDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdTrungTam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTrungTam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTrungTam;
    }
}