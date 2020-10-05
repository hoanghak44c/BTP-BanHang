namespace QLBanHang.Modules.BanHang
{
    partial class frmMutilPhieuXuatBan
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
            this.grcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.grvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNgayBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoPhieuXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // grcDanhSach
            // 
            this.grcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcDanhSach.Location = new System.Drawing.Point(0, 0);
            this.grcDanhSach.MainView = this.grvDanhSach;
            this.grcDanhSach.Name = "grcDanhSach";
            this.grcDanhSach.Size = new System.Drawing.Size(779, 379);
            this.grcDanhSach.TabIndex = 0;
            this.grcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDanhSach});
            // 
            // grvDanhSach
            // 
            this.grvDanhSach.ColumnPanelRowHeight = 25;
            this.grvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNgayBan,
            this.colSoChungTu,
            this.colSoHoaDon,
            this.colSoPhieuXuat,
            this.colKhachHang});
            this.grvDanhSach.GridControl = this.grcDanhSach;
            this.grvDanhSach.Name = "grvDanhSach";
            this.grvDanhSach.OptionsView.ShowAutoFilterRow = true;
            this.grvDanhSach.OptionsView.ShowDetailButtons = false;
            this.grvDanhSach.OptionsView.ShowGroupPanel = false;
            this.grvDanhSach.DoubleClick += new System.EventHandler(this.grvDanhSach_DoubleClick);
            // 
            // colNgayBan
            // 
            this.colNgayBan.AppearanceHeader.Options.UseTextOptions = true;
            this.colNgayBan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgayBan.Caption = "Ngày bán ";
            this.colNgayBan.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgayBan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayBan.FieldName = "NgayLap";
            this.colNgayBan.Name = "colNgayBan";
            this.colNgayBan.OptionsColumn.AllowEdit = false;
            this.colNgayBan.OptionsColumn.FixedWidth = true;
            this.colNgayBan.Visible = true;
            this.colNgayBan.VisibleIndex = 0;
            this.colNgayBan.Width = 100;
            // 
            // colSoChungTu
            // 
            this.colSoChungTu.AppearanceHeader.Options.UseTextOptions = true;
            this.colSoChungTu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoChungTu.Caption = "Số giao dịch";
            this.colSoChungTu.FieldName = "SoChungTu";
            this.colSoChungTu.Name = "colSoChungTu";
            this.colSoChungTu.OptionsColumn.AllowEdit = false;
            this.colSoChungTu.Visible = true;
            this.colSoChungTu.VisibleIndex = 1;
            this.colSoChungTu.Width = 88;
            // 
            // colSoHoaDon
            // 
            this.colSoHoaDon.AppearanceHeader.Options.UseTextOptions = true;
            this.colSoHoaDon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoHoaDon.Caption = "Số hóa đơn";
            this.colSoHoaDon.FieldName = "SoSeri";
            this.colSoHoaDon.Name = "colSoHoaDon";
            this.colSoHoaDon.OptionsColumn.AllowEdit = false;
            this.colSoHoaDon.Visible = true;
            this.colSoHoaDon.VisibleIndex = 2;
            this.colSoHoaDon.Width = 88;
            // 
            // colSoPhieuXuat
            // 
            this.colSoPhieuXuat.AppearanceHeader.Options.UseTextOptions = true;
            this.colSoPhieuXuat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoPhieuXuat.Caption = "Số phiếu xuất";
            this.colSoPhieuXuat.FieldName = "SoPhieuXuat";
            this.colSoPhieuXuat.Name = "colSoPhieuXuat";
            this.colSoPhieuXuat.OptionsColumn.AllowEdit = false;
            this.colSoPhieuXuat.Visible = true;
            this.colSoPhieuXuat.VisibleIndex = 3;
            this.colSoPhieuXuat.Width = 91;
            // 
            // colKhachHang
            // 
            this.colKhachHang.AppearanceHeader.Options.UseTextOptions = true;
            this.colKhachHang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKhachHang.Caption = "Khách hàng";
            this.colKhachHang.FieldName = "TenDoiTuong";
            this.colKhachHang.Name = "colKhachHang";
            this.colKhachHang.OptionsColumn.AllowEdit = false;
            this.colKhachHang.OptionsColumn.FixedWidth = true;
            this.colKhachHang.Visible = true;
            this.colKhachHang.VisibleIndex = 4;
            this.colKhachHang.Width = 120;
            // 
            // frmMutilPhieuXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 379);
            this.Controls.Add(this.grcDanhSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMutilPhieuXuatBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMutilPhieuXuatBan_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMutilPhieuXuatBan_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayBan;
        private DevExpress.XtraGrid.Columns.GridColumn colSoChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn colSoHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn colSoPhieuXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colKhachHang;
    }
}