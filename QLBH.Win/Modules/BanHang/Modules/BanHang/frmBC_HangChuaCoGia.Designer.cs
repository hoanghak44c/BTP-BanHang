using QLBH.Core.Form;
namespace QLBanHang.Modules.BanHang
{
    partial class frmBC_HangChuaCoGia
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBC_HangChuaCoGia));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdExport = new QLBH.Core.Form.GtidButton();
            this.btnDong = new QLBH.Core.Form.GtidButton();
            this.bteTrungTam = new DevExpress.XtraEditors.ButtonEdit();
            this.btnTim = new QLBH.Core.Form.GtidButton();
            this.label7 = new System.Windows.Forms.Label();
            this.grpKetQuaTimKiem = new System.Windows.Forms.GroupBox();
            this.gListSanPham = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TonChiTiet = new System.Windows.Forms.ToolStripMenuItem();
            this.gvListSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrungMaVach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.ChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SuDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LinhVuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TonKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TonAo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).BeginInit();
            this.grpKetQuaTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gListSanPham)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmdExport);
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Controls.Add(this.bteTrungTam);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(950, 61);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cmdExport
            // 
            this.cmdExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExport.Image = ((System.Drawing.Image)(resources.GetObject("cmdExport.Image")));
            this.cmdExport.Location = new System.Drawing.Point(741, 19);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdExport.Size = new System.Drawing.Size(101, 25);
            this.cmdExport.TabIndex = 21;
            this.cmdExport.Text = "Export (F12)";
            this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(848, 19);
            this.btnDong.Name = "btnDong";
            this.btnDong.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnDong.Size = new System.Drawing.Size(95, 25);
            this.btnDong.TabIndex = 120;
            this.btnDong.Text = "Thoát (ESC)";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // bteTrungTam
            // 
            this.bteTrungTam.Location = new System.Drawing.Point(78, 22);
            this.bteTrungTam.Name = "bteTrungTam";
            this.bteTrungTam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteTrungTam.Properties.Appearance.Options.UseFont = true;
            this.bteTrungTam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteTrungTam.Size = new System.Drawing.Size(352, 22);
            this.bteTrungTam.TabIndex = 117;
            this.bteTrungTam.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteTrungTam_ButtonClick);
            this.bteTrungTam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteTrungTam_KeyDown);
            this.bteTrungTam.TextChanged += new System.EventHandler(this.bteTrungTam_TextChanged);
            // 
            // btnTim
            // 
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.Location = new System.Drawing.Point(436, 19);
            this.btnTim.Name = "btnTim";
            this.btnTim.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnTim.Size = new System.Drawing.Size(101, 25);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "&Tìm kiếm (F3)";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 118;
            this.label7.Text = "Trung tâm";
            // 
            // grpKetQuaTimKiem
            // 
            this.grpKetQuaTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKetQuaTimKiem.Controls.Add(this.gListSanPham);
            this.grpKetQuaTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKetQuaTimKiem.ForeColor = System.Drawing.Color.Black;
            this.grpKetQuaTimKiem.Location = new System.Drawing.Point(10, 79);
            this.grpKetQuaTimKiem.Name = "grpKetQuaTimKiem";
            this.grpKetQuaTimKiem.Size = new System.Drawing.Size(950, 450);
            this.grpKetQuaTimKiem.TabIndex = 3;
            this.grpKetQuaTimKiem.TabStop = false;
            this.grpKetQuaTimKiem.Text = "Danh sách mã hàng";
            // 
            // gListSanPham
            // 
            this.gListSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gListSanPham.ContextMenuStrip = this.contextMenuStrip1;
            this.gListSanPham.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gListSanPham.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gListSanPham.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gListSanPham.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gListSanPham.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gListSanPham.EmbeddedNavigator.TextStringFormat = "Mặt hàng số {0} / Tổng số {1} mã hàng";
            this.gListSanPham.Location = new System.Drawing.Point(6, 19);
            this.gListSanPham.MainView = this.gvListSanPham;
            this.gListSanPham.Name = "gListSanPham";
            this.gListSanPham.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repEdit});
            this.gListSanPham.Size = new System.Drawing.Size(938, 425);
            this.gListSanPham.TabIndex = 30;
            this.gListSanPham.UseEmbeddedNavigator = true;
            this.gListSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListSanPham});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TonChiTiet});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 26);
            // 
            // TonChiTiet
            // 
            this.TonChiTiet.Name = "TonChiTiet";
            this.TonChiTiet.Size = new System.Drawing.Size(157, 22);
            this.TonChiTiet.Text = "Tồn kho chi tiết";
            this.TonChiTiet.Click += new System.EventHandler(this.TonChiTiet_Click);
            // 
            // gvListSanPham
            // 
            this.gvListSanPham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdSanPham,
            this.MaSanPham,
            this.TenSanPham,
            this.TenDonViTinh,
            this.TrungMaVach,
            this.ChietKhau,
            this.SuDung,
            this.LinhVuc,
            this.Nganh,
            this.TonKho,
            this.TonAo});
            this.gvListSanPham.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvListSanPham.GridControl = this.gListSanPham;
            this.gvListSanPham.Name = "gvListSanPham";
            this.gvListSanPham.OptionsView.ColumnAutoWidth = false;
            this.gvListSanPham.OptionsView.ShowAutoFilterRow = true;
            this.gvListSanPham.OptionsView.ShowDetailButtons = false;
            // 
            // IdSanPham
            // 
            this.IdSanPham.Caption = "IdSanPham";
            this.IdSanPham.FieldName = "IdSanPham";
            this.IdSanPham.Name = "IdSanPham";
            // 
            // MaSanPham
            // 
            this.MaSanPham.Caption = "Mã sản phẩm";
            this.MaSanPham.FieldName = "MaSanPham";
            this.MaSanPham.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.OptionsColumn.ReadOnly = true;
            this.MaSanPham.Visible = true;
            this.MaSanPham.VisibleIndex = 0;
            this.MaSanPham.Width = 123;
            // 
            // TenSanPham
            // 
            this.TenSanPham.Caption = "Tên sản phẩm";
            this.TenSanPham.FieldName = "TenSanPham";
            this.TenSanPham.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.OptionsColumn.ReadOnly = true;
            this.TenSanPham.Visible = true;
            this.TenSanPham.VisibleIndex = 1;
            this.TenSanPham.Width = 288;
            // 
            // TenDonViTinh
            // 
            this.TenDonViTinh.Caption = "Đơn vị tính";
            this.TenDonViTinh.FieldName = "TenDonViTinh";
            this.TenDonViTinh.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.TenDonViTinh.Name = "TenDonViTinh";
            this.TenDonViTinh.OptionsColumn.ReadOnly = true;
            this.TenDonViTinh.Visible = true;
            this.TenDonViTinh.VisibleIndex = 2;
            // 
            // TrungMaVach
            // 
            this.TrungMaVach.Caption = "Trùng mã vạch";
            this.TrungMaVach.ColumnEdit = this.repEdit;
            this.TrungMaVach.FieldName = "TrungMaVach";
            this.TrungMaVach.Name = "TrungMaVach";
            this.TrungMaVach.OptionsColumn.ReadOnly = true;
            this.TrungMaVach.Visible = true;
            this.TrungMaVach.VisibleIndex = 3;
            this.TrungMaVach.Width = 108;
            // 
            // repEdit
            // 
            this.repEdit.AutoHeight = false;
            this.repEdit.Name = "repEdit";
            this.repEdit.ValueChecked = 1;
            this.repEdit.ValueUnchecked = 0;
            // 
            // ChietKhau
            // 
            this.ChietKhau.Caption = "Chiết khấu";
            this.ChietKhau.ColumnEdit = this.repEdit;
            this.ChietKhau.FieldName = "ChietKhau";
            this.ChietKhau.Name = "ChietKhau";
            this.ChietKhau.OptionsColumn.ReadOnly = true;
            this.ChietKhau.Visible = true;
            this.ChietKhau.VisibleIndex = 4;
            this.ChietKhau.Width = 87;
            // 
            // SuDung
            // 
            this.SuDung.Caption = "Sử dụng";
            this.SuDung.ColumnEdit = this.repEdit;
            this.SuDung.FieldName = "SuDung";
            this.SuDung.Name = "SuDung";
            this.SuDung.Visible = true;
            this.SuDung.VisibleIndex = 5;
            // 
            // LinhVuc
            // 
            this.LinhVuc.Caption = "Lĩnh vực";
            this.LinhVuc.FieldName = "LinhVuc";
            this.LinhVuc.Name = "LinhVuc";
            this.LinhVuc.OptionsColumn.ReadOnly = true;
            this.LinhVuc.Visible = true;
            this.LinhVuc.VisibleIndex = 6;
            this.LinhVuc.Width = 145;
            // 
            // Nganh
            // 
            this.Nganh.Caption = "Ngành";
            this.Nganh.FieldName = "Nganh";
            this.Nganh.Name = "Nganh";
            this.Nganh.Visible = true;
            this.Nganh.VisibleIndex = 7;
            this.Nganh.Width = 154;
            // 
            // TonKho
            // 
            this.TonKho.Caption = "Tồn thật";
            this.TonKho.FieldName = "TonKho";
            this.TonKho.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.TonKho.Name = "TonKho";
            this.TonKho.OptionsColumn.ReadOnly = true;
            this.TonKho.Visible = true;
            this.TonKho.VisibleIndex = 8;
            // 
            // TonAo
            // 
            this.TonAo.Caption = "Tồn ảo";
            this.TonAo.FieldName = "TonAo";
            this.TonAo.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.TonAo.Name = "TonAo";
            this.TonAo.Visible = true;
            this.TonAo.VisibleIndex = 9;
            // 
            // frmBC_HangChuaCoGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 532);
            this.Controls.Add(this.grpKetQuaTimKiem);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmBC_HangChuaCoGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản phẩm chưa có giá";
            this.Load += new System.EventHandler(this.frmBH_TimChungTu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBH_TimChungTu_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).EndInit();
            this.grpKetQuaTimKiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gListSanPham)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvListSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpKetQuaTimKiem;
        private GtidButton btnTim;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.ButtonEdit bteTrungTam;
        private DevExpress.XtraGrid.GridControl gListSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListSanPham;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repEdit;
        private GtidButton btnDong;
        private DevExpress.XtraGrid.Columns.GridColumn IdSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn MaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TenDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn TrungMaVach;
        private DevExpress.XtraGrid.Columns.GridColumn ChietKhau;
        private DevExpress.XtraGrid.Columns.GridColumn LinhVuc;
        private DevExpress.XtraGrid.Columns.GridColumn TonKho;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TonChiTiet;
        private DevExpress.XtraGrid.Columns.GridColumn TonAo;
        private GtidButton cmdExport;
        private DevExpress.XtraGrid.Columns.GridColumn Nganh;
        private DevExpress.XtraGrid.Columns.GridColumn SuDung;
    }
}