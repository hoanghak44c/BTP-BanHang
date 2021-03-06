using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frmCS_BangGia_ChuaDuyet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCS_BangGia_ChuaDuyet));
            this.label9 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRefress = new System.Windows.Forms.ToolStripButton();
            this.btnDong = new System.Windows.Forms.ToolStripButton();
            this.txtTongLoiNhuan = new QLBH.Core.Form.GtidTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.gSanPham = new DevExpress.XtraGrid.GridControl();
            this.gvSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TenTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoBangGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NganhHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdChiTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdBangGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaNhapHDCuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaTonKhoBQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienChietKhauQK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienKhuyenMai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeLNBQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DungSaiMin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DungSaiMax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaMin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaMax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBanAnToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongBanBQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DungSaiSLBQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGiaChuaVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGiaCoVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBanBuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeThuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThuongNong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoiNhuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoiNhuanTon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoiNhuanBB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoiNhuanTonBB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaNiemYet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaWebSite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DaDuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.NguoiDuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiCapNhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdNhomDuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhomDuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Draft = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Thiết lập chính sách giá";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefress,
            this.btnDong});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1063, 25);
            this.toolStrip1.TabIndex = 47;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnRefress
            // 
            this.btnRefress.Image = ((System.Drawing.Image)(resources.GetObject("btnRefress.Image")));
            this.btnRefress.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefress.Name = "btnRefress";
            this.btnRefress.Size = new System.Drawing.Size(91, 22);
            this.btnRefress.Text = "&Nạp lại (F5)";
            this.btnRefress.Click += new System.EventHandler(this.btnRefress_Click);
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(89, 22);
            this.btnDong.Text = "Đóng (F12)";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // txtTongLoiNhuan
            // 
            this.txtTongLoiNhuan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongLoiNhuan.Location = new System.Drawing.Point(912, 192);
            this.txtTongLoiNhuan.Name = "txtTongLoiNhuan";
            this.txtTongLoiNhuan.ReadOnly = true;
            this.txtTongLoiNhuan.Size = new System.Drawing.Size(138, 21);
            this.txtTongLoiNhuan.TabIndex = 73;
            this.txtTongLoiNhuan.Visible = false;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(820, 196);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(89, 13);
            this.label23.TabIndex = 72;
            this.label23.Text = "Tổng lợi nhuận";
            this.label23.Visible = false;
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
            this.gSanPham.Location = new System.Drawing.Point(12, 28);
            this.gSanPham.MainView = this.gvSanPham;
            this.gSanPham.Name = "gSanPham";
            this.gSanPham.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCheck});
            this.gSanPham.Size = new System.Drawing.Size(1044, 416);
            this.gSanPham.TabIndex = 84;
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
            this.TenTrungTam,
            this.SoBangGia,
            this.NganhHang,
            this.IdChiTiet,
            this.IdBangGia,
            this.IdSanPham,
            this.MaSanPham,
            this.TenSanPham,
            this.DonViTinh,
            this.LoaiSanPham,
            this.GiaNhapHDCuoi,
            this.GiaTonKhoBQ,
            this.TienChietKhauQK,
            this.TienKhuyenMai,
            this.TyLeLNBQ,
            this.DungSaiMin,
            this.DungSaiMax,
            this.GiaMin,
            this.GiaMax,
            this.GiaBanAnToan,
            this.SoLuongBanBQ,
            this.DungSaiSLBQ,
            this.DonGiaChuaVAT,
            this.TyLeChietKhau,
            this.TienChietKhau,
            this.TyLeVAT,
            this.TienVAT,
            this.DonGiaCoVAT,
            this.GiaBanBuon,
            this.TyLeThuong,
            this.ThuongNong,
            this.LoiNhuan,
            this.LoiNhuanTon,
            this.LoiNhuanBB,
            this.LoiNhuanTonBB,
            this.GiaNiemYet,
            this.GiaWebSite,
            this.DaDuyet,
            this.NguoiDuyet,
            this.NguoiCapNhat,
            this.IdNhomDuyet,
            this.NhomDuyet,
            this.Draft});
            this.gvSanPham.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvSanPham.GridControl = this.gSanPham;
            this.gvSanPham.GroupCount = 3;
            this.gvSanPham.Name = "gvSanPham";
            this.gvSanPham.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvSanPham.OptionsSelection.MultiSelect = true;
            this.gvSanPham.OptionsView.ColumnAutoWidth = false;
            this.gvSanPham.OptionsView.ShowAutoFilterRow = true;
            this.gvSanPham.OptionsView.ShowDetailButtons = false;
            this.gvSanPham.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.TenTrungTam, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.SoBangGia, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.NganhHang, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // TenTrungTam
            // 
            this.TenTrungTam.Caption = "Trung tâm";
            this.TenTrungTam.FieldName = "TenTrungTam";
            this.TenTrungTam.Name = "TenTrungTam";
            this.TenTrungTam.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            // 
            // SoBangGia
            // 
            this.SoBangGia.Caption = "Bảng giá";
            this.SoBangGia.FieldName = "SoBangGia";
            this.SoBangGia.Name = "SoBangGia";
            this.SoBangGia.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            // 
            // NganhHang
            // 
            this.NganhHang.Caption = "Ngành hàng";
            this.NganhHang.FieldName = "NganhHang";
            this.NganhHang.Name = "NganhHang";
            this.NganhHang.OptionsColumn.AllowEdit = false;
            this.NganhHang.OptionsColumn.AllowFocus = false;
            this.NganhHang.OptionsColumn.ReadOnly = true;
            // 
            // IdChiTiet
            // 
            this.IdChiTiet.Caption = "IdChiTiet";
            this.IdChiTiet.FieldName = "IdChiTiet";
            this.IdChiTiet.Name = "IdChiTiet";
            this.IdChiTiet.OptionsColumn.AllowEdit = false;
            this.IdChiTiet.OptionsColumn.AllowFocus = false;
            this.IdChiTiet.OptionsColumn.AllowMove = false;
            this.IdChiTiet.OptionsColumn.ReadOnly = true;
            this.IdChiTiet.Width = 115;
            // 
            // IdBangGia
            // 
            this.IdBangGia.Caption = "IdBangGia";
            this.IdBangGia.FieldName = "IdBangGia";
            this.IdBangGia.Name = "IdBangGia";
            this.IdBangGia.OptionsColumn.AllowEdit = false;
            this.IdBangGia.OptionsColumn.AllowFocus = false;
            this.IdBangGia.OptionsColumn.AllowMove = false;
            this.IdBangGia.OptionsColumn.ReadOnly = true;
            this.IdBangGia.Width = 234;
            // 
            // IdSanPham
            // 
            this.IdSanPham.Caption = "IdSanPham";
            this.IdSanPham.FieldName = "IdSanPham";
            this.IdSanPham.Name = "IdSanPham";
            this.IdSanPham.Width = 89;
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
            this.MaSanPham.Width = 114;
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
            this.TenSanPham.Width = 261;
            // 
            // DonViTinh
            // 
            this.DonViTinh.Caption = "ĐVT";
            this.DonViTinh.FieldName = "DonViTinh";
            this.DonViTinh.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.OptionsColumn.AllowEdit = false;
            this.DonViTinh.Visible = true;
            this.DonViTinh.VisibleIndex = 2;
            this.DonViTinh.Width = 89;
            // 
            // LoaiSanPham
            // 
            this.LoaiSanPham.Caption = "Loại sản phẩm";
            this.LoaiSanPham.FieldName = "LoaiSanPham";
            this.LoaiSanPham.Name = "LoaiSanPham";
            this.LoaiSanPham.Visible = true;
            this.LoaiSanPham.VisibleIndex = 3;
            this.LoaiSanPham.Width = 96;
            // 
            // GiaNhapHDCuoi
            // 
            this.GiaNhapHDCuoi.Caption = "Giá nhập HĐ cuối";
            this.GiaNhapHDCuoi.DisplayFormat.FormatString = "N0";
            this.GiaNhapHDCuoi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaNhapHDCuoi.FieldName = "GiaNhapHDCuoi";
            this.GiaNhapHDCuoi.Name = "GiaNhapHDCuoi";
            this.GiaNhapHDCuoi.OptionsColumn.AllowEdit = false;
            this.GiaNhapHDCuoi.Visible = true;
            this.GiaNhapHDCuoi.VisibleIndex = 4;
            this.GiaNhapHDCuoi.Width = 122;
            // 
            // GiaTonKhoBQ
            // 
            this.GiaTonKhoBQ.Caption = "Giá tồn kho BQ";
            this.GiaTonKhoBQ.DisplayFormat.FormatString = "N0";
            this.GiaTonKhoBQ.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaTonKhoBQ.FieldName = "GiaTonKhoBQ";
            this.GiaTonKhoBQ.Name = "GiaTonKhoBQ";
            this.GiaTonKhoBQ.OptionsColumn.AllowEdit = false;
            this.GiaTonKhoBQ.Visible = true;
            this.GiaTonKhoBQ.VisibleIndex = 5;
            this.GiaTonKhoBQ.Width = 111;
            // 
            // TienChietKhauQK
            // 
            this.TienChietKhauQK.Caption = "Tiền chiết khấu QK";
            this.TienChietKhauQK.DisplayFormat.FormatString = "N0";
            this.TienChietKhauQK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TienChietKhauQK.FieldName = "TienChietKhauQK";
            this.TienChietKhauQK.Name = "TienChietKhauQK";
            this.TienChietKhauQK.OptionsColumn.AllowEdit = false;
            this.TienChietKhauQK.Visible = true;
            this.TienChietKhauQK.VisibleIndex = 6;
            this.TienChietKhauQK.Width = 115;
            // 
            // TienKhuyenMai
            // 
            this.TienKhuyenMai.Caption = "Tiền khuyến mại";
            this.TienKhuyenMai.DisplayFormat.FormatString = "N0";
            this.TienKhuyenMai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TienKhuyenMai.FieldName = "TienKhuyenMai";
            this.TienKhuyenMai.Name = "TienKhuyenMai";
            this.TienKhuyenMai.OptionsColumn.AllowEdit = false;
            this.TienKhuyenMai.Visible = true;
            this.TienKhuyenMai.VisibleIndex = 7;
            this.TienKhuyenMai.Width = 109;
            // 
            // TyLeLNBQ
            // 
            this.TyLeLNBQ.Caption = "Tỷ lệ LNBQ";
            this.TyLeLNBQ.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyLeLNBQ.FieldName = "TyLeLNBQ";
            this.TyLeLNBQ.Name = "TyLeLNBQ";
            this.TyLeLNBQ.OptionsColumn.AllowEdit = false;
            this.TyLeLNBQ.Visible = true;
            this.TyLeLNBQ.VisibleIndex = 8;
            this.TyLeLNBQ.Width = 88;
            // 
            // DungSaiMin
            // 
            this.DungSaiMin.Caption = "Dung sai MIN";
            this.DungSaiMin.DisplayFormat.FormatString = "N2";
            this.DungSaiMin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DungSaiMin.FieldName = "DungSaiMin";
            this.DungSaiMin.Name = "DungSaiMin";
            this.DungSaiMin.OptionsColumn.AllowEdit = false;
            this.DungSaiMin.Visible = true;
            this.DungSaiMin.VisibleIndex = 9;
            this.DungSaiMin.Width = 89;
            // 
            // DungSaiMax
            // 
            this.DungSaiMax.Caption = "Dung sai MAX";
            this.DungSaiMax.DisplayFormat.FormatString = "N2";
            this.DungSaiMax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DungSaiMax.FieldName = "DungSaiMax";
            this.DungSaiMax.Name = "DungSaiMax";
            this.DungSaiMax.OptionsColumn.AllowEdit = false;
            this.DungSaiMax.Visible = true;
            this.DungSaiMax.VisibleIndex = 10;
            this.DungSaiMax.Width = 88;
            // 
            // GiaMin
            // 
            this.GiaMin.Caption = "Giá MIN";
            this.GiaMin.DisplayFormat.FormatString = "N0";
            this.GiaMin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaMin.FieldName = "GiaMin";
            this.GiaMin.Name = "GiaMin";
            this.GiaMin.OptionsColumn.AllowEdit = false;
            this.GiaMin.Visible = true;
            this.GiaMin.VisibleIndex = 11;
            // 
            // GiaMax
            // 
            this.GiaMax.Caption = "Giá MAX";
            this.GiaMax.DisplayFormat.FormatString = "N0";
            this.GiaMax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaMax.FieldName = "GiaMax";
            this.GiaMax.Name = "GiaMax";
            this.GiaMax.OptionsColumn.AllowEdit = false;
            this.GiaMax.Visible = true;
            this.GiaMax.VisibleIndex = 12;
            this.GiaMax.Width = 82;
            // 
            // GiaBanAnToan
            // 
            this.GiaBanAnToan.Caption = "Giá bán an toàn";
            this.GiaBanAnToan.DisplayFormat.FormatString = "N0";
            this.GiaBanAnToan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaBanAnToan.FieldName = "GiaBanAnToan";
            this.GiaBanAnToan.Name = "GiaBanAnToan";
            this.GiaBanAnToan.OptionsColumn.AllowEdit = false;
            this.GiaBanAnToan.Visible = true;
            this.GiaBanAnToan.VisibleIndex = 13;
            this.GiaBanAnToan.Width = 109;
            // 
            // SoLuongBanBQ
            // 
            this.SoLuongBanBQ.Caption = "Số lượng bán BQ";
            this.SoLuongBanBQ.DisplayFormat.FormatString = "N2";
            this.SoLuongBanBQ.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SoLuongBanBQ.FieldName = "SoLuongBanBQ";
            this.SoLuongBanBQ.Name = "SoLuongBanBQ";
            this.SoLuongBanBQ.OptionsColumn.AllowEdit = false;
            this.SoLuongBanBQ.Visible = true;
            this.SoLuongBanBQ.VisibleIndex = 14;
            this.SoLuongBanBQ.Width = 111;
            // 
            // DungSaiSLBQ
            // 
            this.DungSaiSLBQ.Caption = "Dung sai SLBQ";
            this.DungSaiSLBQ.DisplayFormat.FormatString = "N2";
            this.DungSaiSLBQ.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DungSaiSLBQ.FieldName = "DungSaiSLBQ";
            this.DungSaiSLBQ.Name = "DungSaiSLBQ";
            this.DungSaiSLBQ.OptionsColumn.AllowEdit = false;
            this.DungSaiSLBQ.Visible = true;
            this.DungSaiSLBQ.VisibleIndex = 15;
            this.DungSaiSLBQ.Width = 104;
            // 
            // DonGiaChuaVAT
            // 
            this.DonGiaChuaVAT.Caption = "Giá bán chưa VAT";
            this.DonGiaChuaVAT.DisplayFormat.FormatString = "N0";
            this.DonGiaChuaVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DonGiaChuaVAT.FieldName = "DonGiaChuaVAT";
            this.DonGiaChuaVAT.Name = "DonGiaChuaVAT";
            this.DonGiaChuaVAT.OptionsColumn.AllowEdit = false;
            this.DonGiaChuaVAT.Visible = true;
            this.DonGiaChuaVAT.VisibleIndex = 16;
            this.DonGiaChuaVAT.Width = 109;
            // 
            // TyLeChietKhau
            // 
            this.TyLeChietKhau.Caption = "Tỷ lệ chiết khấu";
            this.TyLeChietKhau.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyLeChietKhau.FieldName = "TyLeChietKhau";
            this.TyLeChietKhau.Name = "TyLeChietKhau";
            this.TyLeChietKhau.Width = 106;
            // 
            // TienChietKhau
            // 
            this.TienChietKhau.Caption = "Tiền chiết khấu";
            this.TienChietKhau.DisplayFormat.FormatString = "N0";
            this.TienChietKhau.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TienChietKhau.FieldName = "TienChietKhau";
            this.TienChietKhau.Name = "TienChietKhau";
            this.TienChietKhau.OptionsColumn.AllowEdit = false;
            this.TienChietKhau.Width = 105;
            // 
            // TyLeVAT
            // 
            this.TyLeVAT.Caption = "Tỷ lệ VAT";
            this.TyLeVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyLeVAT.FieldName = "TyLeVAT";
            this.TyLeVAT.Name = "TyLeVAT";
            this.TyLeVAT.OptionsColumn.AllowEdit = false;
            this.TyLeVAT.Visible = true;
            this.TyLeVAT.VisibleIndex = 17;
            this.TyLeVAT.Width = 80;
            // 
            // TienVAT
            // 
            this.TienVAT.Caption = "Tiền VAT";
            this.TienVAT.DisplayFormat.FormatString = "N0";
            this.TienVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TienVAT.FieldName = "TienVAT";
            this.TienVAT.Name = "TienVAT";
            this.TienVAT.OptionsColumn.AllowEdit = false;
            this.TienVAT.Visible = true;
            this.TienVAT.VisibleIndex = 18;
            // 
            // DonGiaCoVAT
            // 
            this.DonGiaCoVAT.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.DonGiaCoVAT.AppearanceCell.Options.UseBackColor = true;
            this.DonGiaCoVAT.Caption = "Giá bán có VAT";
            this.DonGiaCoVAT.DisplayFormat.FormatString = "N0";
            this.DonGiaCoVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DonGiaCoVAT.FieldName = "DonGiaCoVAT";
            this.DonGiaCoVAT.Name = "DonGiaCoVAT";
            this.DonGiaCoVAT.Visible = true;
            this.DonGiaCoVAT.VisibleIndex = 19;
            this.DonGiaCoVAT.Width = 99;
            // 
            // GiaBanBuon
            // 
            this.GiaBanBuon.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.GiaBanBuon.AppearanceCell.Options.UseBackColor = true;
            this.GiaBanBuon.Caption = "Giá bán buôn";
            this.GiaBanBuon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaBanBuon.FieldName = "GiaBanBuon";
            this.GiaBanBuon.Name = "GiaBanBuon";
            this.GiaBanBuon.Visible = true;
            this.GiaBanBuon.VisibleIndex = 20;
            this.GiaBanBuon.Width = 125;
            // 
            // TyLeThuong
            // 
            this.TyLeThuong.Caption = "Tỷ lệ thưởng";
            this.TyLeThuong.FieldName = "TyLeThuong";
            this.TyLeThuong.Name = "TyLeThuong";
            this.TyLeThuong.OptionsColumn.AllowEdit = false;
            this.TyLeThuong.Width = 95;
            // 
            // ThuongNong
            // 
            this.ThuongNong.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.ThuongNong.AppearanceCell.Options.UseBackColor = true;
            this.ThuongNong.Caption = "Thưởng nóng";
            this.ThuongNong.DisplayFormat.FormatString = "N0";
            this.ThuongNong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ThuongNong.FieldName = "ThuongNong";
            this.ThuongNong.Name = "ThuongNong";
            this.ThuongNong.Visible = true;
            this.ThuongNong.VisibleIndex = 21;
            this.ThuongNong.Width = 85;
            // 
            // LoiNhuan
            // 
            this.LoiNhuan.Caption = "Lợi nhuận";
            this.LoiNhuan.DisplayFormat.FormatString = "N0";
            this.LoiNhuan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.LoiNhuan.FieldName = "LoiNhuan";
            this.LoiNhuan.Name = "LoiNhuan";
            this.LoiNhuan.OptionsColumn.AllowEdit = false;
            this.LoiNhuan.Visible = true;
            this.LoiNhuan.VisibleIndex = 22;
            this.LoiNhuan.Width = 99;
            // 
            // LoiNhuanTon
            // 
            this.LoiNhuanTon.Caption = "Lợi nhuận tồn BQ";
            this.LoiNhuanTon.FieldName = "LoiNhuanTon";
            this.LoiNhuanTon.Name = "LoiNhuanTon";
            this.LoiNhuanTon.OptionsColumn.AllowEdit = false;
            this.LoiNhuanTon.Visible = true;
            this.LoiNhuanTon.VisibleIndex = 23;
            // 
            // LoiNhuanBB
            // 
            this.LoiNhuanBB.Caption = "Lợi nhuận BB";
            this.LoiNhuanBB.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.LoiNhuanBB.FieldName = "LoiNhuanBB";
            this.LoiNhuanBB.Name = "LoiNhuanBB";
            this.LoiNhuanBB.OptionsColumn.AllowEdit = false;
            this.LoiNhuanBB.Visible = true;
            this.LoiNhuanBB.VisibleIndex = 24;
            this.LoiNhuanBB.Width = 120;
            // 
            // LoiNhuanTonBB
            // 
            this.LoiNhuanTonBB.Caption = "Lợi nuận tồn BB";
            this.LoiNhuanTonBB.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.LoiNhuanTonBB.FieldName = "LoiNhuanTonBB";
            this.LoiNhuanTonBB.Name = "LoiNhuanTonBB";
            this.LoiNhuanTonBB.OptionsColumn.AllowEdit = false;
            this.LoiNhuanTonBB.Visible = true;
            this.LoiNhuanTonBB.VisibleIndex = 25;
            this.LoiNhuanTonBB.Width = 99;
            // 
            // GiaNiemYet
            // 
            this.GiaNiemYet.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.GiaNiemYet.AppearanceCell.Options.UseBackColor = true;
            this.GiaNiemYet.Caption = "Giá niêm yết";
            this.GiaNiemYet.DisplayFormat.FormatString = "N0";
            this.GiaNiemYet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaNiemYet.FieldName = "GiaNiemYet";
            this.GiaNiemYet.Name = "GiaNiemYet";
            this.GiaNiemYet.Visible = true;
            this.GiaNiemYet.VisibleIndex = 26;
            this.GiaNiemYet.Width = 85;
            // 
            // GiaWebSite
            // 
            this.GiaWebSite.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.GiaWebSite.AppearanceCell.Options.UseBackColor = true;
            this.GiaWebSite.Caption = "Giá website";
            this.GiaWebSite.DisplayFormat.FormatString = "N0";
            this.GiaWebSite.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaWebSite.FieldName = "GiaWebSite";
            this.GiaWebSite.Name = "GiaWebSite";
            this.GiaWebSite.Visible = true;
            this.GiaWebSite.VisibleIndex = 27;
            this.GiaWebSite.Width = 90;
            // 
            // DaDuyet
            // 
            this.DaDuyet.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.DaDuyet.AppearanceCell.Options.UseBackColor = true;
            this.DaDuyet.Caption = "Đã duyệt";
            this.DaDuyet.ColumnEdit = this.repCheck;
            this.DaDuyet.FieldName = "DaDuyet";
            this.DaDuyet.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.DaDuyet.Name = "DaDuyet";
            this.DaDuyet.Visible = true;
            this.DaDuyet.VisibleIndex = 30;
            this.DaDuyet.Width = 89;
            // 
            // repCheck
            // 
            this.repCheck.AutoHeight = false;
            this.repCheck.Name = "repCheck";
            this.repCheck.ValueChecked = 1;
            this.repCheck.ValueUnchecked = 0;
            // 
            // NguoiDuyet
            // 
            this.NguoiDuyet.Caption = "Người duyệt";
            this.NguoiDuyet.FieldName = "NguoiDuyet";
            this.NguoiDuyet.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.NguoiDuyet.Name = "NguoiDuyet";
            this.NguoiDuyet.OptionsColumn.AllowEdit = false;
            this.NguoiDuyet.Width = 89;
            // 
            // NguoiCapNhat
            // 
            this.NguoiCapNhat.Caption = "Người tạo";
            this.NguoiCapNhat.FieldName = "NguoiCapNhat";
            this.NguoiCapNhat.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.NguoiCapNhat.Name = "NguoiCapNhat";
            this.NguoiCapNhat.Visible = true;
            this.NguoiCapNhat.VisibleIndex = 28;
            // 
            // IdNhomDuyet
            // 
            this.IdNhomDuyet.Caption = "IdNhomDuyet";
            this.IdNhomDuyet.FieldName = "IdNhomDuyet";
            this.IdNhomDuyet.Name = "IdNhomDuyet";
            // 
            // NhomDuyet
            // 
            this.NhomDuyet.Caption = "Nhóm duyệt giá";
            this.NhomDuyet.FieldName = "NhomDuyet";
            this.NhomDuyet.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.NhomDuyet.Name = "NhomDuyet";
            this.NhomDuyet.Visible = true;
            this.NhomDuyet.VisibleIndex = 31;
            this.NhomDuyet.Width = 92;
            // 
            // Draft
            // 
            this.Draft.Caption = "Draft";
            this.Draft.ColumnEdit = this.repCheck;
            this.Draft.FieldName = "Draft";
            this.Draft.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.Draft.Name = "Draft";
            this.Draft.Visible = true;
            this.Draft.VisibleIndex = 29;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gSanPham;
            this.gridView1.Name = "gridView1";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(14, 457);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 16);
            this.labelControl1.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 16);
            this.label3.TabIndex = 87;
            this.label3.Text = "Tổng số mã hàng cần duyệt:";
            // 
            // frmCS_BangGia_ChuaDuyet
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 483);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtTongLoiNhuan);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gSanPham);
            this.KeyPreview = true;
            this.Name = "frmCS_BangGia_ChuaDuyet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sản phẩm chưa duyệt giá";
            this.Load += new System.EventHandler(this.frm_BangGia_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDong;
        private GtidTextBox txtTongLoiNhuan;
        private System.Windows.Forms.Label label23;
        private DevExpress.XtraGrid.GridControl gSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn NganhHang;
        private DevExpress.XtraGrid.Columns.GridColumn IdChiTiet;
        private DevExpress.XtraGrid.Columns.GridColumn IdBangGia;
        private DevExpress.XtraGrid.Columns.GridColumn IdSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn MaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn DonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn GiaNhapHDCuoi;
        private DevExpress.XtraGrid.Columns.GridColumn GiaTonKhoBQ;
        private DevExpress.XtraGrid.Columns.GridColumn TienChietKhauQK;
        private DevExpress.XtraGrid.Columns.GridColumn TienKhuyenMai;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeLNBQ;
        private DevExpress.XtraGrid.Columns.GridColumn DungSaiMin;
        private DevExpress.XtraGrid.Columns.GridColumn DungSaiMax;
        private DevExpress.XtraGrid.Columns.GridColumn GiaMin;
        private DevExpress.XtraGrid.Columns.GridColumn GiaMax;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBanAnToan;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongBanBQ;
        private DevExpress.XtraGrid.Columns.GridColumn DungSaiSLBQ;
        private DevExpress.XtraGrid.Columns.GridColumn DonGiaChuaVAT;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeChietKhau;
        private DevExpress.XtraGrid.Columns.GridColumn TienChietKhau;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeVAT;
        private DevExpress.XtraGrid.Columns.GridColumn TienVAT;
        private DevExpress.XtraGrid.Columns.GridColumn DonGiaCoVAT;
        private DevExpress.XtraGrid.Columns.GridColumn LoiNhuan;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeThuong;
        private DevExpress.XtraGrid.Columns.GridColumn ThuongNong;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiCapNhat;
        private DevExpress.XtraGrid.Columns.GridColumn DaDuyet;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiDuyet;
        private DevExpress.XtraGrid.Columns.GridColumn GiaNiemYet;
        private DevExpress.XtraGrid.Columns.GridColumn GiaWebSite;
        private DevExpress.XtraGrid.Columns.GridColumn LoiNhuanBB;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBanBuon;
        private DevExpress.XtraGrid.Columns.GridColumn LoiNhuanTonBB;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn LoiNhuanTon;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheck;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn IdNhomDuyet;
        private DevExpress.XtraGrid.Columns.GridColumn NhomDuyet;
        private DevExpress.XtraGrid.Columns.GridColumn TenTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn SoBangGia;
        private System.Windows.Forms.ToolStripButton btnRefress;
        private DevExpress.XtraGrid.Columns.GridColumn Draft;
    }
}
