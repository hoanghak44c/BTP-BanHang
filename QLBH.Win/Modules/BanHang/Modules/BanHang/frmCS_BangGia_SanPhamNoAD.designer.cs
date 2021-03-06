using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frmCS_BangGia_SanPhamNoAD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCS_BangGia_SanPhamNoAD));
            this.lbMaSanPham = new System.Windows.Forms.Label();
            this.cmdXoaChiTietKM = new QLBH.Core.Form.GtidButton();
            this.cmdGhiKM = new QLBH.Core.Form.GtidButton();
            this.cmdDong = new QLBH.Core.Form.GtidButton();
            this.txtSanPham = new QLBH.Core.Form.GtidTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gSanPham = new DevExpress.XtraGrid.GridControl();
            this.gvSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdDKMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiHangNoAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoaiHangNoAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdHangNoAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaHangNoAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenHangNoAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaHangSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenHangSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaMuaTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaMuaDen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnThemChiTietKM = new QLBH.Core.Form.GtidButton();
            this.label27 = new System.Windows.Forms.Label();
            this.txtHangSX = new QLBH.Core.Form.GtidTextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtMaMatHang = new QLBH.Core.Form.GtidTextBox();
            this.cboLoaiMatHang = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaSanPham
            // 
            this.lbMaSanPham.AutoSize = true;
            this.lbMaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSanPham.Location = new System.Drawing.Point(26, 19);
            this.lbMaSanPham.Name = "lbMaSanPham";
            this.lbMaSanPham.Size = new System.Drawing.Size(125, 13);
            this.lbMaSanPham.TabIndex = 50;
            this.lbMaSanPham.Text = "Thông tin chiết khấu";
            // 
            // cmdXoaChiTietKM
            // 
            this.cmdXoaChiTietKM.Image = ((System.Drawing.Image)(resources.GetObject("cmdXoaChiTietKM.Image")));
            this.cmdXoaChiTietKM.Location = new System.Drawing.Point(132, 352);
            this.cmdXoaChiTietKM.Name = "cmdXoaChiTietKM";
            this.cmdXoaChiTietKM.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdXoaChiTietKM.Size = new System.Drawing.Size(117, 25);
            this.cmdXoaChiTietKM.TabIndex = 55;
            this.cmdXoaChiTietKM.Text = "Xóa chi tiết (F8)";
            this.cmdXoaChiTietKM.Click += new System.EventHandler(this.cmdXoaChiTietKM_Click);
            // 
            // cmdGhiKM
            // 
            this.cmdGhiKM.Image = ((System.Drawing.Image)(resources.GetObject("cmdGhiKM.Image")));
            this.cmdGhiKM.Location = new System.Drawing.Point(551, 352);
            this.cmdGhiKM.Name = "cmdGhiKM";
            this.cmdGhiKM.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdGhiKM.Size = new System.Drawing.Size(78, 25);
            this.cmdGhiKM.TabIndex = 61;
            this.cmdGhiKM.Text = "&Ghi (F7)";
            this.cmdGhiKM.Click += new System.EventHandler(this.cmdGhiKM_Click);
            // 
            // cmdDong
            // 
            this.cmdDong.Image = ((System.Drawing.Image)(resources.GetObject("cmdDong.Image")));
            this.cmdDong.Location = new System.Drawing.Point(632, 352);
            this.cmdDong.Name = "cmdDong";
            this.cmdDong.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdDong.Size = new System.Drawing.Size(88, 25);
            this.cmdDong.TabIndex = 63;
            this.cmdDong.Text = "T&hoát (ESC)";
            this.cmdDong.Click += new System.EventHandler(this.cmdDong_Click);
            // 
            // txtSanPham
            // 
            this.txtSanPham.Location = new System.Drawing.Point(152, 19);
            this.txtSanPham.Multiline = true;
            this.txtSanPham.Name = "txtSanPham";
            this.txtSanPham.ReadOnly = true;
            this.txtSanPham.Size = new System.Drawing.Size(562, 54);
            this.txtSanPham.TabIndex = 65;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gSanPham);
            this.groupBox1.Location = new System.Drawing.Point(14, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 240);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách mặt hàng không áp dụng";
            // 
            // gSanPham
            // 
            this.gSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gSanPham.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gSanPham.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gSanPham.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gSanPham.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gSanPham.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gSanPham.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gSanPham.Location = new System.Drawing.Point(6, 20);
            this.gSanPham.MainView = this.gvSanPham;
            this.gSanPham.Name = "gSanPham";
            this.gSanPham.Size = new System.Drawing.Size(694, 214);
            this.gSanPham.TabIndex = 86;
            this.gSanPham.UseEmbeddedNavigator = true;
            this.gSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSanPham,
            this.gridView1});
            // 
            // gvSanPham
            // 
            this.gvSanPham.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvSanPham.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvSanPham.Appearance.FocusedCell.Options.UseFont = true;
            this.gvSanPham.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvSanPham.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvSanPham.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvSanPham.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvSanPham.Appearance.Row.BackColor = System.Drawing.Color.Silver;
            this.gvSanPham.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvSanPham.Appearance.Row.Options.UseBackColor = true;
            this.gvSanPham.Appearance.Row.Options.UseBorderColor = true;
            this.gvSanPham.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvSanPham.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvSanPham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdDKMua,
            this.LoaiHangNoAD,
            this.TenLoaiHangNoAD,
            this.IdHangNoAD,
            this.MaHangNoAD,
            this.TenHangNoAD,
            this.MaHangSX,
            this.TenHangSX,
            this.GiaMuaTu,
            this.GiaMuaDen});
            this.gvSanPham.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvSanPham.GridControl = this.gSanPham;
            this.gvSanPham.Name = "gvSanPham";
            this.gvSanPham.OptionsSelection.InvertSelection = true;
            this.gvSanPham.OptionsSelection.MultiSelect = true;
            this.gvSanPham.OptionsView.ShowDetailButtons = false;
            this.gvSanPham.OptionsView.ShowGroupPanel = false;
            // 
            // IdDKMua
            // 
            this.IdDKMua.Caption = "IdDKMua";
            this.IdDKMua.FieldName = "IdDKMua";
            this.IdDKMua.Name = "IdDKMua";
            this.IdDKMua.OptionsColumn.AllowEdit = false;
            this.IdDKMua.OptionsColumn.AllowFocus = false;
            this.IdDKMua.OptionsColumn.AllowMove = false;
            this.IdDKMua.OptionsColumn.ReadOnly = true;
            this.IdDKMua.Width = 115;
            // 
            // LoaiHangNoAD
            // 
            this.LoaiHangNoAD.Caption = "LoaiHangNoAD";
            this.LoaiHangNoAD.FieldName = "LoaiHangNoAD";
            this.LoaiHangNoAD.Name = "LoaiHangNoAD";
            this.LoaiHangNoAD.OptionsColumn.AllowEdit = false;
            this.LoaiHangNoAD.Width = 96;
            // 
            // TenLoaiHangNoAD
            // 
            this.TenLoaiHangNoAD.Caption = "Áp dụng cho";
            this.TenLoaiHangNoAD.FieldName = "TenLoaiHangNoAD";
            this.TenLoaiHangNoAD.Name = "TenLoaiHangNoAD";
            this.TenLoaiHangNoAD.OptionsColumn.AllowEdit = false;
            this.TenLoaiHangNoAD.Visible = true;
            this.TenLoaiHangNoAD.VisibleIndex = 0;
            this.TenLoaiHangNoAD.Width = 154;
            // 
            // IdHangNoAD
            // 
            this.IdHangNoAD.Caption = "IdHangNoAD";
            this.IdHangNoAD.FieldName = "IdHangNoAD";
            this.IdHangNoAD.Name = "IdHangNoAD";
            this.IdHangNoAD.Width = 89;
            // 
            // MaHangNoAD
            // 
            this.MaHangNoAD.Caption = "Mã hàng";
            this.MaHangNoAD.FieldName = "MaHangNoAD";
            this.MaHangNoAD.Name = "MaHangNoAD";
            this.MaHangNoAD.OptionsColumn.ReadOnly = true;
            this.MaHangNoAD.Visible = true;
            this.MaHangNoAD.VisibleIndex = 1;
            this.MaHangNoAD.Width = 197;
            // 
            // TenHangNoAD
            // 
            this.TenHangNoAD.Caption = "Tên hàng không áp dụng";
            this.TenHangNoAD.FieldName = "TenHangNoAD";
            this.TenHangNoAD.Name = "TenHangNoAD";
            this.TenHangNoAD.OptionsColumn.ReadOnly = true;
            this.TenHangNoAD.Visible = true;
            this.TenHangNoAD.VisibleIndex = 2;
            this.TenHangNoAD.Width = 419;
            // 
            // MaHangSX
            // 
            this.MaHangSX.Caption = "MaHangSX";
            this.MaHangSX.FieldName = "MaHangSX";
            this.MaHangSX.Name = "MaHangSX";
            this.MaHangSX.OptionsColumn.ReadOnly = true;
            // 
            // TenHangSX
            // 
            this.TenHangSX.Caption = "Tên hãng SX";
            this.TenHangSX.FieldName = "TenHangSX";
            this.TenHangSX.Name = "TenHangSX";
            this.TenHangSX.OptionsColumn.ReadOnly = true;
            this.TenHangSX.Visible = true;
            this.TenHangSX.VisibleIndex = 3;
            this.TenHangSX.Width = 212;
            // 
            // GiaMuaTu
            // 
            this.GiaMuaTu.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.GiaMuaTu.AppearanceCell.Options.UseBackColor = true;
            this.GiaMuaTu.Caption = "Giá mua từ";
            this.GiaMuaTu.DisplayFormat.FormatString = "N0";
            this.GiaMuaTu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaMuaTu.FieldName = "GiaMuaTu";
            this.GiaMuaTu.Name = "GiaMuaTu";
            this.GiaMuaTu.Visible = true;
            this.GiaMuaTu.VisibleIndex = 4;
            this.GiaMuaTu.Width = 123;
            // 
            // GiaMuaDen
            // 
            this.GiaMuaDen.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.GiaMuaDen.AppearanceCell.Options.UseBackColor = true;
            this.GiaMuaDen.Caption = "đến";
            this.GiaMuaDen.DisplayFormat.FormatString = "N0";
            this.GiaMuaDen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaMuaDen.FieldName = "GiaMuaDen";
            this.GiaMuaDen.Name = "GiaMuaDen";
            this.GiaMuaDen.Visible = true;
            this.GiaMuaDen.VisibleIndex = 5;
            this.GiaMuaDen.Width = 129;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gSanPham;
            this.gridView1.Name = "gridView1";
            // 
            // btnThemChiTietKM
            // 
            this.btnThemChiTietKM.Image = ((System.Drawing.Image)(resources.GetObject("btnThemChiTietKM.Image")));
            this.btnThemChiTietKM.Location = new System.Drawing.Point(15, 352);
            this.btnThemChiTietKM.Name = "btnThemChiTietKM";
            this.btnThemChiTietKM.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnThemChiTietKM.Size = new System.Drawing.Size(115, 25);
            this.btnThemChiTietKM.TabIndex = 72;
            this.btnThemChiTietKM.Text = "Thêm chi tiết (F5)";
            this.btnThemChiTietKM.Click += new System.EventHandler(this.btnThemChiTietKM_Click);
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(296, 330);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(47, 13);
            this.label27.TabIndex = 115;
            this.label27.Text = "Hãng SX";
            // 
            // txtHangSX
            // 
            this.txtHangSX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtHangSX.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHangSX.Location = new System.Drawing.Point(347, 326);
            this.txtHangSX.Name = "txtHangSX";
            this.txtHangSX.Size = new System.Drawing.Size(95, 23);
            this.txtHangSX.TabIndex = 114;
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(13, 330);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(21, 13);
            this.label26.TabIndex = 113;
            this.label26.Text = "Mã";
            // 
            // txtMaMatHang
            // 
            this.txtMaMatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaMatHang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMatHang.Location = new System.Drawing.Point(116, 326);
            this.txtMaMatHang.Name = "txtMaMatHang";
            this.txtMaMatHang.Size = new System.Drawing.Size(177, 23);
            this.txtMaMatHang.TabIndex = 112;
            // 
            // cboLoaiMatHang
            // 
            this.cboLoaiMatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboLoaiMatHang.AutoCompleteCustomSource.AddRange(new string[] {
            "Nhận hàng tại siêu thị",
            "Giao hàng tại nhà"});
            this.cboLoaiMatHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiMatHang.FormattingEnabled = true;
            this.cboLoaiMatHang.Items.AddRange(new object[] {
            "Lĩnh vực",
            "Ngành",
            "Loại",
            "Chủng",
            "Nhóm",
            "Model",
            "Sản phẩm"});
            this.cboLoaiMatHang.Location = new System.Drawing.Point(34, 326);
            this.cboLoaiMatHang.Name = "cboLoaiMatHang";
            this.cboLoaiMatHang.Size = new System.Drawing.Size(80, 21);
            this.cboLoaiMatHang.TabIndex = 111;
            // 
            // frmCS_BangGia_SanPhamNoAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 382);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtHangSX);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtMaMatHang);
            this.Controls.Add(this.cboLoaiMatHang);
            this.Controls.Add(this.btnThemChiTietKM);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSanPham);
            this.Controls.Add(this.cmdGhiKM);
            this.Controls.Add(this.cmdDong);
            this.Controls.Add(this.cmdXoaChiTietKM);
            this.Controls.Add(this.lbMaSanPham);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCS_BangGia_SanPhamNoAD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập sản phẩm không áp dụng";
            this.Load += new System.EventHandler(this.frm_ThietLapKM_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_ThietLapKM_KeyDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaSanPham;
        private GtidButton cmdXoaChiTietKM;
        internal GtidButton cmdGhiKM;
        internal GtidButton cmdDong;
        private GtidTextBox txtSanPham;
        private System.Windows.Forms.GroupBox groupBox1;
        private GtidButton btnThemChiTietKM;
        private DevExpress.XtraGrid.GridControl gSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn IdDKMua;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiHangNoAD;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoaiHangNoAD;
        private DevExpress.XtraGrid.Columns.GridColumn IdHangNoAD;
        private DevExpress.XtraGrid.Columns.GridColumn MaHangNoAD;
        private DevExpress.XtraGrid.Columns.GridColumn TenHangNoAD;
        private DevExpress.XtraGrid.Columns.GridColumn MaHangSX;
        private DevExpress.XtraGrid.Columns.GridColumn TenHangSX;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label27;
        private GtidTextBox txtHangSX;
        private System.Windows.Forms.Label label26;
        private GtidTextBox txtMaMatHang;
        private System.Windows.Forms.ComboBox cboLoaiMatHang;
        private DevExpress.XtraGrid.Columns.GridColumn GiaMuaTu;
        private DevExpress.XtraGrid.Columns.GridColumn GiaMuaDen;
    }
}