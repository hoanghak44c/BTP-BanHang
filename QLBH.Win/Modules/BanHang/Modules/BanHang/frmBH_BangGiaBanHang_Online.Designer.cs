using QLBH.Core.Form;
namespace QLBanHang.Modules.BanHang
{
    partial class frmBH_BangGiaBanHang_Online
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBH_BangGiaBanHang_Online));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdNapDuLieu = new QLBH.Core.Form.GtidButton();
            this.chkCoTonKho = new System.Windows.Forms.CheckBox();
            this.btnDong = new QLBH.Core.Form.GtidButton();
            this.grpKetQuaTimKiem = new System.Windows.Forms.GroupBox();
            this.gListSanPham = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TonChiTiet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ChinhSachApDung = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LichSuThayDoiGia = new System.Windows.Forms.ToolStripMenuItem();
            this.gvListSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdChiTietBangGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGiaCoVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaNiemYet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaWebSite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Model = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TonKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TonAo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repTrangThai = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslGiamGia = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTangGia = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.grpKetQuaTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gListSanPham)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrangThai)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmdNapDuLieu);
            this.groupBox1.Controls.Add(this.chkCoTonKho);
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(10, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1037, 49);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cmdNapDuLieu
            // 
            this.cmdNapDuLieu.Image = ((System.Drawing.Image)(resources.GetObject("cmdNapDuLieu.Image")));
            this.cmdNapDuLieu.Location = new System.Drawing.Point(90, 12);
            this.cmdNapDuLieu.Name = "cmdNapDuLieu";
            this.cmdNapDuLieu.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdNapDuLieu.Size = new System.Drawing.Size(117, 25);
            this.cmdNapDuLieu.TabIndex = 124;
            this.cmdNapDuLieu.Text = "Nạp dữ liệu";
            this.cmdNapDuLieu.Click += new System.EventHandler(this.cmdNapDuLieu_Click);
            // 
            // chkCoTonKho
            // 
            this.chkCoTonKho.AutoSize = true;
            this.chkCoTonKho.Checked = true;
            this.chkCoTonKho.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCoTonKho.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.chkCoTonKho.Location = new System.Drawing.Point(6, 17);
            this.chkCoTonKho.Name = "chkCoTonKho";
            this.chkCoTonKho.Size = new System.Drawing.Size(78, 17);
            this.chkCoTonKho.TabIndex = 121;
            this.chkCoTonKho.Text = "Có tồn kho";
            this.chkCoTonKho.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(213, 12);
            this.btnDong.Name = "btnDong";
            this.btnDong.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnDong.Size = new System.Drawing.Size(117, 25);
            this.btnDong.TabIndex = 120;
            this.btnDong.Text = "Thoát (ESC)";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // grpKetQuaTimKiem
            // 
            this.grpKetQuaTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKetQuaTimKiem.Controls.Add(this.gListSanPham);
            this.grpKetQuaTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKetQuaTimKiem.ForeColor = System.Drawing.Color.Black;
            this.grpKetQuaTimKiem.Location = new System.Drawing.Point(10, 62);
            this.grpKetQuaTimKiem.Name = "grpKetQuaTimKiem";
            this.grpKetQuaTimKiem.Size = new System.Drawing.Size(1037, 445);
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
            this.repEdit,
            this.repTrangThai});
            this.gListSanPham.Size = new System.Drawing.Size(1025, 420);
            this.gListSanPham.TabIndex = 30;
            this.gListSanPham.UseEmbeddedNavigator = true;
            this.gListSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListSanPham});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TonChiTiet,
            this.toolStripSeparator2,
            this.ChinhSachApDung,
            this.toolStripSeparator1,
            this.LichSuThayDoiGia});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 82);
            // 
            // TonChiTiet
            // 
            this.TonChiTiet.Name = "TonChiTiet";
            this.TonChiTiet.Size = new System.Drawing.Size(180, 22);
            this.TonChiTiet.Text = "Tồn kho chi tiết";
            this.TonChiTiet.Click += new System.EventHandler(this.TonChiTiet_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // ChinhSachApDung
            // 
            this.ChinhSachApDung.Name = "ChinhSachApDung";
            this.ChinhSachApDung.Size = new System.Drawing.Size(180, 22);
            this.ChinhSachApDung.Text = "Chính sách áp dụng";
            this.ChinhSachApDung.Click += new System.EventHandler(this.ChinhSachApDung_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // LichSuThayDoiGia
            // 
            this.LichSuThayDoiGia.Name = "LichSuThayDoiGia";
            this.LichSuThayDoiGia.Size = new System.Drawing.Size(180, 22);
            this.LichSuThayDoiGia.Text = "Lịch sử thay đổi giá";
            this.LichSuThayDoiGia.Click += new System.EventHandler(this.LichSuThayDoiGia_Click);
            // 
            // gvListSanPham
            // 
            this.gvListSanPham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdChiTietBangGia,
            this.IdTrungTam,
            this.IdSanPham,
            this.MaSanPham,
            this.TenSanPham,
            this.DonGiaCoVAT,
            this.GiaNiemYet,
            this.GiaWebSite,
            this.Nganh,
            this.Model,
            this.TonKho,
            this.TonAo});
            this.gvListSanPham.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvListSanPham.GridControl = this.gListSanPham;
            this.gvListSanPham.Name = "gvListSanPham";
            this.gvListSanPham.OptionsView.ColumnAutoWidth = false;
            this.gvListSanPham.OptionsView.ShowAutoFilterRow = true;
            this.gvListSanPham.OptionsView.ShowDetailButtons = false;
            this.gvListSanPham.OptionsView.ShowFooter = true;
            this.gvListSanPham.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvListSanPham_RowStyle);
            // 
            // IdChiTietBangGia
            // 
            this.IdChiTietBangGia.Caption = "IdChiTietBangGia";
            this.IdChiTietBangGia.FieldName = "IdChiTietBangGia";
            this.IdChiTietBangGia.Name = "IdChiTietBangGia";
            // 
            // IdTrungTam
            // 
            this.IdTrungTam.Caption = "IdTrungTam";
            this.IdTrungTam.FieldName = "IdTrungTam";
            this.IdTrungTam.Name = "IdTrungTam";
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
            this.MaSanPham.Width = 91;
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
            this.TenSanPham.Width = 240;
            // 
            // DonGiaCoVAT
            // 
            this.DonGiaCoVAT.Caption = "Giá bán lẻ";
            this.DonGiaCoVAT.DisplayFormat.FormatString = "N0";
            this.DonGiaCoVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DonGiaCoVAT.FieldName = "DonGiaCoVAT";
            this.DonGiaCoVAT.Name = "DonGiaCoVAT";
            this.DonGiaCoVAT.OptionsColumn.ReadOnly = true;
            this.DonGiaCoVAT.Visible = true;
            this.DonGiaCoVAT.VisibleIndex = 2;
            // 
            // GiaNiemYet
            // 
            this.GiaNiemYet.Caption = "Giá niêm yết";
            this.GiaNiemYet.DisplayFormat.FormatString = "N0";
            this.GiaNiemYet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaNiemYet.FieldName = "GiaNiemYet";
            this.GiaNiemYet.Name = "GiaNiemYet";
            this.GiaNiemYet.OptionsColumn.ReadOnly = true;
            this.GiaNiemYet.Visible = true;
            this.GiaNiemYet.VisibleIndex = 3;
            // 
            // GiaWebSite
            // 
            this.GiaWebSite.Caption = "Giá Website";
            this.GiaWebSite.DisplayFormat.FormatString = "N0";
            this.GiaWebSite.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaWebSite.FieldName = "GiaWebSite";
            this.GiaWebSite.Name = "GiaWebSite";
            this.GiaWebSite.OptionsColumn.ReadOnly = true;
            this.GiaWebSite.Visible = true;
            this.GiaWebSite.VisibleIndex = 4;
            // 
            // Nganh
            // 
            this.Nganh.Caption = "Ngành";
            this.Nganh.FieldName = "Nganh";
            this.Nganh.Name = "Nganh";
            this.Nganh.Visible = true;
            this.Nganh.VisibleIndex = 5;
            this.Nganh.Width = 195;
            // 
            // Model
            // 
            this.Model.Caption = "Model";
            this.Model.FieldName = "Model";
            this.Model.Name = "Model";
            this.Model.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Model.OptionsColumn.ReadOnly = true;
            this.Model.Visible = true;
            this.Model.VisibleIndex = 6;
            this.Model.Width = 166;
            // 
            // TonKho
            // 
            this.TonKho.Caption = "Tồn thật";
            this.TonKho.DisplayFormat.FormatString = "N0";
            this.TonKho.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TonKho.FieldName = "TonKho";
            this.TonKho.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.TonKho.Name = "TonKho";
            this.TonKho.OptionsColumn.ReadOnly = true;
            this.TonKho.SummaryItem.DisplayFormat = "{0:N0}";
            this.TonKho.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.TonKho.Visible = true;
            this.TonKho.VisibleIndex = 7;
            // 
            // TonAo
            // 
            this.TonAo.Caption = "Tồn ảo";
            this.TonAo.DisplayFormat.FormatString = "N0";
            this.TonAo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TonAo.FieldName = "TonAo";
            this.TonAo.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.TonAo.Name = "TonAo";
            this.TonAo.SummaryItem.DisplayFormat = "{0:N0}";
            this.TonAo.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.TonAo.Visible = true;
            this.TonAo.VisibleIndex = 8;
            // 
            // repEdit
            // 
            this.repEdit.AutoHeight = false;
            this.repEdit.Name = "repEdit";
            this.repEdit.ValueChecked = 1;
            this.repEdit.ValueUnchecked = 0;
            // 
            // repTrangThai
            // 
            this.repTrangThai.AutoHeight = false;
            this.repTrangThai.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repTrangThai.DisplayMember = "Name";
            this.repTrangThai.Name = "repTrangThai";
            this.repTrangThai.ValueMember = "Id";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslGiamGia,
            this.tsslTangGia});
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(1052, 22);
            this.statusStrip1.TabIndex = 109;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslGiamGia
            // 
            this.tsslGiamGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tsslGiamGia.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslGiamGia.ForeColor = System.Drawing.Color.Yellow;
            this.tsslGiamGia.Name = "tsslGiamGia";
            this.tsslGiamGia.Size = new System.Drawing.Size(98, 17);
            this.tsslGiamGia.Text = "   Giảm giá bán   ";
            // 
            // tsslTangGia
            // 
            this.tsslTangGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tsslTangGia.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.tsslTangGia.ForeColor = System.Drawing.Color.Navy;
            this.tsslTangGia.Name = "tsslTangGia";
            this.tsslTangGia.Size = new System.Drawing.Size(100, 17);
            this.tsslTangGia.Text = "   Tăng giá bán    ";
            // 
            // frmBH_BangGiaBanHang_Online
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 532);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpKetQuaTimKiem);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmBH_BangGiaBanHang_Online";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng giá online";
            this.Load += new System.EventHandler(this.frmBH_TimChungTu_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBH_BangGiaBanHang_Online_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBH_TimChungTu_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpKetQuaTimKiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gListSanPham)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvListSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrangThai)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpKetQuaTimKiem;
        private DevExpress.XtraGrid.GridControl gListSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListSanPham;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repEdit;
        private GtidButton btnDong;
        private DevExpress.XtraGrid.Columns.GridColumn IdChiTietBangGia;
        private DevExpress.XtraGrid.Columns.GridColumn IdTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn IdSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn MaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn DonGiaCoVAT;
        private DevExpress.XtraGrid.Columns.GridColumn GiaNiemYet;
        private DevExpress.XtraGrid.Columns.GridColumn GiaWebSite;
        private DevExpress.XtraGrid.Columns.GridColumn TonKho;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TonChiTiet;
        private System.Windows.Forms.ToolStripMenuItem ChinhSachApDung;
        private DevExpress.XtraGrid.Columns.GridColumn TonAo;
        private DevExpress.XtraGrid.Columns.GridColumn Nganh;
        private System.Windows.Forms.ToolStripMenuItem LichSuThayDoiGia;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.CheckBox chkCoTonKho;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel tsslGiamGia;
        private System.Windows.Forms.ToolStripStatusLabel tsslTangGia;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn Model;
        private GtidButton cmdNapDuLieu;
    }
}