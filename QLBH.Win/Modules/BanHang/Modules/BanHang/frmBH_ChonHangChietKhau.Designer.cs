using QLBH.Core.Form;
namespace QLBanHang.Modules.BanHang
{
    partial class frmBH_ChonHangChietKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBH_ChonHangChietKhau));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gSanPhamBan = new DevExpress.XtraGrid.GridControl();
            this.gvSanPhamBan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TongTienChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoChinhSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayHieuLuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HanHieuLuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmdGhiKM = new QLBH.Core.Form.GtidButton();
            this.cmdDong = new QLBH.Core.Form.GtidButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSanPhamBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPhamBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.gSanPhamBan);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(915, 192);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // gSanPhamBan
            // 
            this.gSanPhamBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gSanPhamBan.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gSanPhamBan.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gSanPhamBan.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gSanPhamBan.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gSanPhamBan.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gSanPhamBan.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gSanPhamBan.Location = new System.Drawing.Point(4, 11);
            this.gSanPhamBan.MainView = this.gvSanPhamBan;
            this.gSanPhamBan.Name = "gSanPhamBan";
            this.gSanPhamBan.Size = new System.Drawing.Size(905, 175);
            this.gSanPhamBan.TabIndex = 87;
            this.gSanPhamBan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSanPhamBan,
            this.gridView1});
            // 
            // gvSanPhamBan
            // 
            this.gvSanPhamBan.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvSanPhamBan.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvSanPhamBan.Appearance.FocusedCell.Options.UseFont = true;
            this.gvSanPhamBan.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvSanPhamBan.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvSanPhamBan.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvSanPhamBan.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvSanPhamBan.Appearance.Row.BackColor = System.Drawing.Color.Silver;
            this.gvSanPhamBan.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvSanPhamBan.Appearance.Row.Options.UseBackColor = true;
            this.gvSanPhamBan.Appearance.Row.Options.UseBorderColor = true;
            this.gvSanPhamBan.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvSanPhamBan.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvSanPhamBan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaSanPham,
            this.TenSanPham,
            this.TienChietKhau,
            this.TyLeChietKhau,
            this.SoLuong,
            this.TongTienChietKhau,
            this.SoChinhSach,
            this.NgayHieuLuc,
            this.HanHieuLuc});
            this.gvSanPhamBan.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvSanPhamBan.GridControl = this.gSanPhamBan;
            this.gvSanPhamBan.Name = "gvSanPhamBan";
            this.gvSanPhamBan.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvSanPhamBan.OptionsView.ShowDetailButtons = false;
            this.gvSanPhamBan.OptionsView.ShowGroupPanel = false;
            this.gvSanPhamBan.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvSanPhamBan_CellValueChanged);
            this.gvSanPhamBan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvSanPhamBan_KeyDown);
            this.gvSanPhamBan.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gvSanPhamBan_ShowingEditor);
            this.gvSanPhamBan.DoubleClick += new System.EventHandler(this.gvSanPhamBan_DoubleClick);
            // 
            // MaSanPham
            // 
            this.MaSanPham.Caption = "Mã chiết khấu";
            this.MaSanPham.FieldName = "MaSanPham";
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.OptionsColumn.ReadOnly = true;
            this.MaSanPham.Visible = true;
            this.MaSanPham.VisibleIndex = 0;
            this.MaSanPham.Width = 130;
            // 
            // TenSanPham
            // 
            this.TenSanPham.Caption = "Tên chiết khấu";
            this.TenSanPham.FieldName = "TenSanPham";
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.OptionsColumn.ReadOnly = true;
            this.TenSanPham.Visible = true;
            this.TenSanPham.VisibleIndex = 1;
            this.TenSanPham.Width = 229;
            // 
            // TienChietKhau
            // 
            this.TienChietKhau.Caption = "Tiền CK";
            this.TienChietKhau.DisplayFormat.FormatString = "{0:N2}";
            this.TienChietKhau.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TienChietKhau.FieldName = "TienChietKhau";
            this.TienChietKhau.Name = "TienChietKhau";
            this.TienChietKhau.OptionsColumn.ReadOnly = true;
            this.TienChietKhau.Visible = true;
            this.TienChietKhau.VisibleIndex = 2;
            this.TienChietKhau.Width = 115;
            // 
            // TyLeChietKhau
            // 
            this.TyLeChietKhau.Caption = "Tlệ CK tối đa";
            this.TyLeChietKhau.DisplayFormat.FormatString = "N0";
            this.TyLeChietKhau.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyLeChietKhau.FieldName = "TyLeChietKhau";
            this.TyLeChietKhau.Name = "TyLeChietKhau";
            this.TyLeChietKhau.OptionsColumn.ReadOnly = true;
            this.TyLeChietKhau.Visible = true;
            this.TyLeChietKhau.VisibleIndex = 3;
            this.TyLeChietKhau.Width = 102;
            // 
            // SoLuong
            // 
            this.SoLuong.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.SoLuong.AppearanceCell.Options.UseBackColor = true;
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.DisplayFormat.FormatString = "N0";
            this.SoLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 4;
            this.SoLuong.Width = 99;
            // 
            // TongTienChietKhau
            // 
            this.TongTienChietKhau.Caption = "Tổng tiền CK";
            this.TongTienChietKhau.DisplayFormat.FormatString = "{0:N2}";
            this.TongTienChietKhau.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TongTienChietKhau.FieldName = "TongTienChietKhau";
            this.TongTienChietKhau.Name = "TongTienChietKhau";
            this.TongTienChietKhau.OptionsColumn.ReadOnly = true;
            this.TongTienChietKhau.Visible = true;
            this.TongTienChietKhau.VisibleIndex = 5;
            this.TongTienChietKhau.Width = 132;
            // 
            // SoChinhSach
            // 
            this.SoChinhSach.Caption = "Chính sách CK";
            this.SoChinhSach.FieldName = "SoChinhSach";
            this.SoChinhSach.Name = "SoChinhSach";
            this.SoChinhSach.OptionsColumn.ReadOnly = true;
            this.SoChinhSach.Visible = true;
            this.SoChinhSach.VisibleIndex = 6;
            this.SoChinhSach.Width = 152;
            // 
            // NgayHieuLuc
            // 
            this.NgayHieuLuc.Caption = "Ngày hiệu lực";
            this.NgayHieuLuc.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.NgayHieuLuc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgayHieuLuc.FieldName = "NgayHieuLuc";
            this.NgayHieuLuc.Name = "NgayHieuLuc";
            this.NgayHieuLuc.OptionsColumn.ReadOnly = true;
            this.NgayHieuLuc.Visible = true;
            this.NgayHieuLuc.VisibleIndex = 7;
            this.NgayHieuLuc.Width = 113;
            // 
            // HanHieuLuc
            // 
            this.HanHieuLuc.Caption = "Hạn hiệu lực";
            this.HanHieuLuc.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.HanHieuLuc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.HanHieuLuc.FieldName = "HanHieuLuc";
            this.HanHieuLuc.Name = "HanHieuLuc";
            this.HanHieuLuc.OptionsColumn.ReadOnly = true;
            this.HanHieuLuc.Visible = true;
            this.HanHieuLuc.VisibleIndex = 8;
            this.HanHieuLuc.Width = 104;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gSanPhamBan;
            this.gridView1.Name = "gridView1";
            // 
            // cmdGhiKM
            // 
            this.cmdGhiKM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGhiKM.Image = ((System.Drawing.Image)(resources.GetObject("cmdGhiKM.Image")));
            this.cmdGhiKM.Location = new System.Drawing.Point(356, 214);
            this.cmdGhiKM.Name = "cmdGhiKM";
            this.cmdGhiKM.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdGhiKM.Size = new System.Drawing.Size(105, 25);
            this.cmdGhiKM.TabIndex = 9;
            this.cmdGhiKM.Text = "Xác nhận (F7)";
            this.cmdGhiKM.Click += new System.EventHandler(this.btnChapNhan_Click);
            // 
            // cmdDong
            // 
            this.cmdDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDong.Image = ((System.Drawing.Image)(resources.GetObject("cmdDong.Image")));
            this.cmdDong.Location = new System.Drawing.Point(467, 214);
            this.cmdDong.Name = "cmdDong";
            this.cmdDong.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdDong.Size = new System.Drawing.Size(105, 25);
            this.cmdDong.TabIndex = 10;
            this.cmdDong.Text = "T&hoát (F12)";
            this.cmdDong.Click += new System.EventHandler(this.cmdDong_Click);
            // 
            // frmBH_ChonHangChietKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 246);
            this.Controls.Add(this.cmdGhiKM);
            this.Controls.Add(this.cmdDong);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBH_ChonHangChietKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn mã chiết khấu";
            this.Load += new System.EventHandler(this.frm_HoaDonBan_ChonTyleVAT_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gSanPhamBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPhamBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gSanPhamBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSanPhamBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        internal GtidButton cmdGhiKM;
        internal GtidButton cmdDong;
        private DevExpress.XtraGrid.Columns.GridColumn MaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TienChietKhau;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeChietKhau;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn TongTienChietKhau;
        private DevExpress.XtraGrid.Columns.GridColumn SoChinhSach;
        private DevExpress.XtraGrid.Columns.GridColumn NgayHieuLuc;
        private DevExpress.XtraGrid.Columns.GridColumn HanHieuLuc;
    }
}