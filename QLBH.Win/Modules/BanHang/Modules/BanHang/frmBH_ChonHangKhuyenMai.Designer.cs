using QLBH.Core.Form;
namespace QLBanHang.Modules.BanHang
{
    partial class frmBH_ChonHangKhuyenMai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBH_ChonHangKhuyenMai));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gSanPhamBan = new DevExpress.XtraGrid.GridControl();
            this.gvSanPhamBan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSanPhamBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPhamBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoKhuyenMai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmdGhiKM = new QLBH.Core.Form.GtidButton();
            this.cmdDong = new QLBH.Core.Form.GtidButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSanPhamBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPhamBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(742, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sản phẩm này khuyến mại cho nhiều sản phẩm chính. Chọn sản phẩm chính cần xuất";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gSanPhamBan);
            this.groupBox1.Location = new System.Drawing.Point(3, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 142);
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
            this.gSanPhamBan.Size = new System.Drawing.Size(744, 125);
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
            this.IdSanPham,
            this.MaSanPham,
            this.TenSanPham,
            this.IdSanPhamBan,
            this.TenSanPhamBan,
            this.NoKhuyenMai,
            this.GhiChu});
            this.gvSanPhamBan.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvSanPhamBan.GridControl = this.gSanPhamBan;
            this.gvSanPhamBan.Name = "gvSanPhamBan";
            this.gvSanPhamBan.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvSanPhamBan.OptionsView.ShowDetailButtons = false;
            this.gvSanPhamBan.OptionsView.ShowGroupPanel = false;
            this.gvSanPhamBan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvSanPhamBan_KeyDown);
            this.gvSanPhamBan.DoubleClick += new System.EventHandler(this.gvSanPhamBan_DoubleClick);
            // 
            // IdSanPham
            // 
            this.IdSanPham.Caption = "IdSanPham";
            this.IdSanPham.FieldName = "IdSanPham";
            this.IdSanPham.Name = "IdSanPham";
            this.IdSanPham.OptionsColumn.AllowEdit = false;
            this.IdSanPham.Width = 96;
            // 
            // MaSanPham
            // 
            this.MaSanPham.Caption = "Mã sản phẩm";
            this.MaSanPham.FieldName = "MaSanPham";
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.OptionsColumn.AllowEdit = false;
            this.MaSanPham.Visible = true;
            this.MaSanPham.VisibleIndex = 0;
            this.MaSanPham.Width = 120;
            // 
            // TenSanPham
            // 
            this.TenSanPham.Caption = "Tên sản phẩm";
            this.TenSanPham.FieldName = "TenSanPham";
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.OptionsColumn.AllowEdit = false;
            this.TenSanPham.Visible = true;
            this.TenSanPham.VisibleIndex = 1;
            this.TenSanPham.Width = 306;
            // 
            // IdSanPhamBan
            // 
            this.IdSanPhamBan.Caption = "IdSanPhamBan";
            this.IdSanPhamBan.FieldName = "IdSanPhamBan";
            this.IdSanPhamBan.Name = "IdSanPhamBan";
            this.IdSanPhamBan.OptionsColumn.AllowEdit = false;
            this.IdSanPhamBan.Width = 95;
            // 
            // TenSanPhamBan
            // 
            this.TenSanPhamBan.Caption = "Sản phẩm chính";
            this.TenSanPhamBan.FieldName = "TenSanPhamBan";
            this.TenSanPhamBan.Name = "TenSanPhamBan";
            this.TenSanPhamBan.OptionsColumn.AllowEdit = false;
            this.TenSanPhamBan.Visible = true;
            this.TenSanPhamBan.VisibleIndex = 2;
            this.TenSanPhamBan.Width = 365;
            // 
            // NoKhuyenMai
            // 
            this.NoKhuyenMai.Caption = "Nợ khuyến mại";
            this.NoKhuyenMai.FieldName = "NoKhuyenMai";
            this.NoKhuyenMai.Name = "NoKhuyenMai";
            this.NoKhuyenMai.OptionsColumn.AllowEdit = false;
            this.NoKhuyenMai.Visible = true;
            this.NoKhuyenMai.VisibleIndex = 3;
            this.NoKhuyenMai.Width = 231;
            // 
            // GhiChu
            // 
            this.GhiChu.Caption = "Ghi chú";
            this.GhiChu.FieldName = "GhiChu";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.OptionsColumn.ReadOnly = true;
            this.GhiChu.Visible = true;
            this.GhiChu.VisibleIndex = 4;
            this.GhiChu.Width = 154;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gSanPhamBan;
            this.gridView1.Name = "gridView1";
            // 
            // cmdGhiKM
            // 
            this.cmdGhiKM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGhiKM.Image = ((System.Drawing.Image)(resources.GetObject("cmdGhiKM.Image")));
            this.cmdGhiKM.Location = new System.Drawing.Point(277, 181);
            this.cmdGhiKM.Name = "cmdGhiKM";
            this.cmdGhiKM.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdGhiKM.Size = new System.Drawing.Size(105, 25);
            this.cmdGhiKM.TabIndex = 9;
            this.cmdGhiKM.Text = "Xác nhận (F7)";
            this.cmdGhiKM.Click += new System.EventHandler(this.btnChapNhan_Click);
            // 
            // cmdDong
            // 
            this.cmdDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDong.Image = ((System.Drawing.Image)(resources.GetObject("cmdDong.Image")));
            this.cmdDong.Location = new System.Drawing.Point(388, 181);
            this.cmdDong.Name = "cmdDong";
            this.cmdDong.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdDong.Size = new System.Drawing.Size(105, 25);
            this.cmdDong.TabIndex = 10;
            this.cmdDong.Text = "T&hoát (F12)";
            this.cmdDong.Click += new System.EventHandler(this.cmdDong_Click);
            // 
            // frmBH_ChonHangKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 214);
            this.Controls.Add(this.cmdGhiKM);
            this.Controls.Add(this.cmdDong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBH_ChonHangKhuyenMai";
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gSanPhamBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSanPhamBan;
        private DevExpress.XtraGrid.Columns.GridColumn IdSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn MaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn IdSanPhamBan;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPhamBan;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn NoKhuyenMai;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        internal GtidButton cmdGhiKM;
        internal GtidButton cmdDong;
    }
}