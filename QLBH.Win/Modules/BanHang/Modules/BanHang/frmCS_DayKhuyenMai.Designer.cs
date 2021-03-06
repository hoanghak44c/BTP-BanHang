﻿using QLBH.Core.Form;
namespace QLBanHang.Modules.BanHang
{
    partial class frmCS_DayKhuyenMai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCS_DayKhuyenMai));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDongBoAll = new QLBH.Core.Form.GtidButton();
            this.lueNganhHang = new DevExpress.XtraEditors.LookUpEdit();
            this.lblLyDo = new DevExpress.XtraEditors.LabelControl();
            this.txtSanPham = new QLBH.Core.Form.GtidTextBox();
            this.lblThuocXuat = new System.Windows.Forms.Label();
            this.chkChuaDayKM = new System.Windows.Forms.CheckBox();
            this.btnDong = new QLBH.Core.Form.GtidButton();
            this.bteTrungTam = new DevExpress.XtraEditors.ButtonEdit();
            this.btnTim = new QLBH.Core.Form.GtidButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDongBo = new QLBH.Core.Form.GtidButton();
            this.cmdExport = new QLBH.Core.Form.GtidButton();
            this.grpKetQuaTimKiem = new System.Windows.Forms.GroupBox();
            this.btnNext = new QLBH.Core.Form.GtidButton();
            this.cboPage = new System.Windows.Forms.ComboBox();
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
            this.TenDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaNhapHDCuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaNhapDemoCuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaTonKhoBQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGiaChuaVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGiaCoVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBanBuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBanDemo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaNiemYet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaWebSite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeThuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThuongNong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrungMaVach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.ChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LinhVuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Model = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTrangThai = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslGiamGia = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTangGia = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueNganhHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).BeginInit();
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
            this.groupBox1.Controls.Add(this.btnDongBoAll);
            this.groupBox1.Controls.Add(this.lueNganhHang);
            this.groupBox1.Controls.Add(this.lblLyDo);
            this.groupBox1.Controls.Add(this.txtSanPham);
            this.groupBox1.Controls.Add(this.lblThuocXuat);
            this.groupBox1.Controls.Add(this.chkChuaDayKM);
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Controls.Add(this.bteTrungTam);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(10, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1037, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnDongBoAll
            // 
            this.btnDongBoAll.Image = ((System.Drawing.Image)(resources.GetObject("btnDongBoAll.Image")));
            this.btnDongBoAll.Location = new System.Drawing.Point(784, 42);
            this.btnDongBoAll.Name = "btnDongBoAll";
            this.btnDongBoAll.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnDongBoAll.Size = new System.Drawing.Size(240, 25);
            this.btnDongBoAll.TabIndex = 127;
            this.btnDongBoAll.Text = "Đồng bộ toàn bộ mã hàng chưa đẩy";
            this.btnDongBoAll.Click += new System.EventHandler(this.btnDongBoAll_Click);
            // 
            // lueNganhHang
            // 
            this.lueNganhHang.Location = new System.Drawing.Point(488, 14);
            this.lueNganhHang.Name = "lueNganhHang";
            this.lueNganhHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueNganhHang.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Ten")});
            this.lueNganhHang.Properties.DisplayMember = "Ten";
            this.lueNganhHang.Properties.NullText = "";
            this.lueNganhHang.Properties.ShowFooter = false;
            this.lueNganhHang.Properties.ShowHeader = false;
            this.lueNganhHang.Properties.ValueMember = "IdLyDoTH";
            this.lueNganhHang.Size = new System.Drawing.Size(290, 20);
            this.lueNganhHang.TabIndex = 124;
            // 
            // lblLyDo
            // 
            this.lblLyDo.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLyDo.Appearance.Options.UseFont = true;
            this.lblLyDo.Location = new System.Drawing.Point(427, 19);
            this.lblLyDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblLyDo.Name = "lblLyDo";
            this.lblLyDo.Size = new System.Drawing.Size(58, 13);
            this.lblLyDo.TabIndex = 125;
            this.lblLyDo.Text = "Ngành hàng";
            // 
            // txtSanPham
            // 
            this.txtSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSanPham.Location = new System.Drawing.Point(74, 42);
            this.txtSanPham.Name = "txtSanPham";
            this.txtSanPham.Size = new System.Drawing.Size(318, 20);
            this.txtSanPham.TabIndex = 123;
            // 
            // lblThuocXuat
            // 
            this.lblThuocXuat.AutoSize = true;
            this.lblThuocXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuocXuat.Location = new System.Drawing.Point(10, 45);
            this.lblThuocXuat.Name = "lblThuocXuat";
            this.lblThuocXuat.Size = new System.Drawing.Size(55, 13);
            this.lblThuocXuat.TabIndex = 122;
            this.lblThuocXuat.Text = "Sản phẩm";
            // 
            // chkChuaDayKM
            // 
            this.chkChuaDayKM.AutoSize = true;
            this.chkChuaDayKM.Checked = true;
            this.chkChuaDayKM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChuaDayKM.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.chkChuaDayKM.Location = new System.Drawing.Point(488, 45);
            this.chkChuaDayKM.Name = "chkChuaDayKM";
            this.chkChuaDayKM.Size = new System.Drawing.Size(78, 17);
            this.chkChuaDayKM.TabIndex = 121;
            this.chkChuaDayKM.Text = "Có tồn kho";
            this.chkChuaDayKM.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(907, 12);
            this.btnDong.Name = "btnDong";
            this.btnDong.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnDong.Size = new System.Drawing.Size(117, 25);
            this.btnDong.TabIndex = 120;
            this.btnDong.Text = "Thoát (ESC)";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // bteTrungTam
            // 
            this.bteTrungTam.Location = new System.Drawing.Point(74, 14);
            this.bteTrungTam.Name = "bteTrungTam";
            this.bteTrungTam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteTrungTam.Properties.Appearance.Options.UseFont = true;
            this.bteTrungTam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteTrungTam.Size = new System.Drawing.Size(318, 22);
            this.bteTrungTam.TabIndex = 117;
            this.bteTrungTam.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteTrungTam_ButtonClick);
            this.bteTrungTam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteTrungTam_KeyDown);
            this.bteTrungTam.TextChanged += new System.EventHandler(this.bteTrungTam_TextChanged);
            // 
            // btnTim
            // 
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.Location = new System.Drawing.Point(784, 12);
            this.btnTim.Name = "btnTim";
            this.btnTim.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnTim.Size = new System.Drawing.Size(117, 25);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "&Tìm kiếm (F3)";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 118;
            this.label7.Text = "Trung tâm";
            // 
            // btnDongBo
            // 
            this.btnDongBo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDongBo.Image = ((System.Drawing.Image)(resources.GetObject("btnDongBo.Image")));
            this.btnDongBo.Location = new System.Drawing.Point(136, 385);
            this.btnDongBo.Name = "btnDongBo";
            this.btnDongBo.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnDongBo.Size = new System.Drawing.Size(185, 25);
            this.btnDongBo.TabIndex = 126;
            this.btnDongBo.Text = "Đồng bộ mã được chọn (F6)";
            this.btnDongBo.Click += new System.EventHandler(this.btnDongBo_Click);
            // 
            // cmdExport
            // 
            this.cmdExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdExport.Image = ((System.Drawing.Image)(resources.GetObject("cmdExport.Image")));
            this.cmdExport.Location = new System.Drawing.Point(13, 385);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdExport.Size = new System.Drawing.Size(117, 25);
            this.cmdExport.TabIndex = 21;
            this.cmdExport.Text = "Export (F12)";
            this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // grpKetQuaTimKiem
            // 
            this.grpKetQuaTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKetQuaTimKiem.Controls.Add(this.btnNext);
            this.grpKetQuaTimKiem.Controls.Add(this.btnDongBo);
            this.grpKetQuaTimKiem.Controls.Add(this.cboPage);
            this.grpKetQuaTimKiem.Controls.Add(this.gListSanPham);
            this.grpKetQuaTimKiem.Controls.Add(this.cmdExport);
            this.grpKetQuaTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKetQuaTimKiem.ForeColor = System.Drawing.Color.Black;
            this.grpKetQuaTimKiem.Location = new System.Drawing.Point(10, 88);
            this.grpKetQuaTimKiem.Name = "grpKetQuaTimKiem";
            this.grpKetQuaTimKiem.Size = new System.Drawing.Size(1037, 419);
            this.grpKetQuaTimKiem.TabIndex = 3;
            this.grpKetQuaTimKiem.TabStop = false;
            this.grpKetQuaTimKiem.Text = "Danh sách mã hàng";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(909, 388);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnNext.Size = new System.Drawing.Size(121, 22);
            this.btnNext.TabIndex = 152;
            this.btnNext.Text = "Kết quả tiếp theo";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cboPage
            // 
            this.cboPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPage.AutoCompleteCustomSource.AddRange(new string[] {
            "Nhận hàng tại siêu thị",
            "Giao hàng tại nhà"});
            this.cboPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPage.FormattingEnabled = true;
            this.cboPage.Items.AddRange(new object[] {
            "50",
            "100",
            "200",
            "500",
            "1000",
            "Tất cả"});
            this.cboPage.Location = new System.Drawing.Point(857, 388);
            this.cboPage.Name = "cboPage";
            this.cboPage.Size = new System.Drawing.Size(50, 21);
            this.cboPage.TabIndex = 151;
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
            this.gListSanPham.Size = new System.Drawing.Size(1025, 363);
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
            this.TenDonViTinh,
            this.GiaNhapHDCuoi,
            this.GiaNhapDemoCuoi,
            this.GiaTonKhoBQ,
            this.DonGiaChuaVAT,
            this.TyLeVAT,
            this.TienVAT,
            this.DonGiaCoVAT,
            this.GiaBanBuon,
            this.GiaBanDemo,
            this.GiaNiemYet,
            this.GiaWebSite,
            this.TyLeThuong,
            this.ThuongNong,
            this.TrungMaVach,
            this.ChietKhau,
            this.LinhVuc,
            this.Nganh,
            this.Model,
            this.GhiChu});
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
            // TenDonViTinh
            // 
            this.TenDonViTinh.Caption = "Đơn vị tính";
            this.TenDonViTinh.FieldName = "TenDonViTinh";
            this.TenDonViTinh.Name = "TenDonViTinh";
            this.TenDonViTinh.OptionsColumn.ReadOnly = true;
            this.TenDonViTinh.Visible = true;
            this.TenDonViTinh.VisibleIndex = 2;
            // 
            // GiaNhapHDCuoi
            // 
            this.GiaNhapHDCuoi.Caption = "Giá nhập HĐ cuối";
            this.GiaNhapHDCuoi.DisplayFormat.FormatString = "N0";
            this.GiaNhapHDCuoi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaNhapHDCuoi.FieldName = "GiaNhapHDCuoi";
            this.GiaNhapHDCuoi.Name = "GiaNhapHDCuoi";
            this.GiaNhapHDCuoi.OptionsColumn.ReadOnly = true;
            this.GiaNhapHDCuoi.Width = 111;
            // 
            // GiaNhapDemoCuoi
            // 
            this.GiaNhapDemoCuoi.Caption = "Giá nhập Demo cuối";
            this.GiaNhapDemoCuoi.DisplayFormat.FormatString = "N0";
            this.GiaNhapDemoCuoi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaNhapDemoCuoi.FieldName = "GiaNhapDemoCuoi";
            this.GiaNhapDemoCuoi.Name = "GiaNhapDemoCuoi";
            this.GiaNhapDemoCuoi.OptionsColumn.ReadOnly = true;
            this.GiaNhapDemoCuoi.Width = 107;
            // 
            // GiaTonKhoBQ
            // 
            this.GiaTonKhoBQ.Caption = "Giá tồn kho BQ";
            this.GiaTonKhoBQ.DisplayFormat.FormatString = "N0";
            this.GiaTonKhoBQ.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaTonKhoBQ.FieldName = "GiaTonKhoBQ";
            this.GiaTonKhoBQ.Name = "GiaTonKhoBQ";
            this.GiaTonKhoBQ.OptionsColumn.ReadOnly = true;
            this.GiaTonKhoBQ.Width = 124;
            // 
            // DonGiaChuaVAT
            // 
            this.DonGiaChuaVAT.Caption = "Giá chưa VAT";
            this.DonGiaChuaVAT.DisplayFormat.FormatString = "N0";
            this.DonGiaChuaVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DonGiaChuaVAT.FieldName = "DonGiaChuaVAT";
            this.DonGiaChuaVAT.Name = "DonGiaChuaVAT";
            this.DonGiaChuaVAT.Visible = true;
            this.DonGiaChuaVAT.VisibleIndex = 3;
            this.DonGiaChuaVAT.Width = 88;
            // 
            // TyLeVAT
            // 
            this.TyLeVAT.Caption = "Tỷ lệ VAT";
            this.TyLeVAT.DisplayFormat.FormatString = "N0";
            this.TyLeVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyLeVAT.FieldName = "TyLeVAT";
            this.TyLeVAT.Name = "TyLeVAT";
            this.TyLeVAT.OptionsColumn.ReadOnly = true;
            this.TyLeVAT.Visible = true;
            this.TyLeVAT.VisibleIndex = 4;
            // 
            // TienVAT
            // 
            this.TienVAT.Caption = "Tiền VAT";
            this.TienVAT.DisplayFormat.FormatString = "N0";
            this.TienVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TienVAT.FieldName = "TienVAT";
            this.TienVAT.Name = "TienVAT";
            this.TienVAT.Visible = true;
            this.TienVAT.VisibleIndex = 5;
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
            this.DonGiaCoVAT.VisibleIndex = 6;
            // 
            // GiaBanBuon
            // 
            this.GiaBanBuon.Caption = "Giá bán buôn";
            this.GiaBanBuon.DisplayFormat.FormatString = "N0";
            this.GiaBanBuon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaBanBuon.FieldName = "GiaBanBuon";
            this.GiaBanBuon.Name = "GiaBanBuon";
            this.GiaBanBuon.OptionsColumn.ReadOnly = true;
            this.GiaBanBuon.Visible = true;
            this.GiaBanBuon.VisibleIndex = 7;
            // 
            // GiaBanDemo
            // 
            this.GiaBanDemo.Caption = "Giá bán Demo";
            this.GiaBanDemo.DisplayFormat.FormatString = "N0";
            this.GiaBanDemo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaBanDemo.FieldName = "GiaBanDemo";
            this.GiaBanDemo.Name = "GiaBanDemo";
            this.GiaBanDemo.OptionsColumn.ReadOnly = true;
            this.GiaBanDemo.Visible = true;
            this.GiaBanDemo.VisibleIndex = 8;
            this.GiaBanDemo.Width = 107;
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
            this.GiaNiemYet.VisibleIndex = 9;
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
            this.GiaWebSite.VisibleIndex = 10;
            // 
            // TyLeThuong
            // 
            this.TyLeThuong.Caption = "Tỷ lệ thưởng";
            this.TyLeThuong.DisplayFormat.FormatString = "N0";
            this.TyLeThuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyLeThuong.FieldName = "TyLeThuong";
            this.TyLeThuong.Name = "TyLeThuong";
            this.TyLeThuong.OptionsColumn.ReadOnly = true;
            this.TyLeThuong.Visible = true;
            this.TyLeThuong.VisibleIndex = 11;
            // 
            // ThuongNong
            // 
            this.ThuongNong.Caption = "Thưởng nóng";
            this.ThuongNong.DisplayFormat.FormatString = "N0";
            this.ThuongNong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ThuongNong.FieldName = "ThuongNong";
            this.ThuongNong.Name = "ThuongNong";
            this.ThuongNong.OptionsColumn.ReadOnly = true;
            this.ThuongNong.Visible = true;
            this.ThuongNong.VisibleIndex = 12;
            this.ThuongNong.Width = 106;
            // 
            // TrungMaVach
            // 
            this.TrungMaVach.Caption = "Trùng mã vạch";
            this.TrungMaVach.ColumnEdit = this.repEdit;
            this.TrungMaVach.FieldName = "TrungMaVach";
            this.TrungMaVach.Name = "TrungMaVach";
            this.TrungMaVach.OptionsColumn.ReadOnly = true;
            this.TrungMaVach.Visible = true;
            this.TrungMaVach.VisibleIndex = 13;
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
            this.ChietKhau.VisibleIndex = 14;
            this.ChietKhau.Width = 87;
            // 
            // LinhVuc
            // 
            this.LinhVuc.Caption = "Lĩnh vực";
            this.LinhVuc.FieldName = "LinhVuc";
            this.LinhVuc.Name = "LinhVuc";
            this.LinhVuc.OptionsColumn.ReadOnly = true;
            this.LinhVuc.Visible = true;
            this.LinhVuc.VisibleIndex = 15;
            this.LinhVuc.Width = 115;
            // 
            // Nganh
            // 
            this.Nganh.Caption = "Ngành";
            this.Nganh.FieldName = "Nganh";
            this.Nganh.Name = "Nganh";
            this.Nganh.Visible = true;
            this.Nganh.VisibleIndex = 16;
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
            this.Model.VisibleIndex = 17;
            this.Model.Width = 166;
            // 
            // GhiChu
            // 
            this.GhiChu.Caption = "Ghi chú";
            this.GhiChu.ColumnEdit = this.repTrangThai;
            this.GhiChu.FieldName = "GhiChu";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.OptionsColumn.AllowEdit = false;
            this.GhiChu.Visible = true;
            this.GhiChu.VisibleIndex = 18;
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
            // frmCS_DayKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 532);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpKetQuaTimKiem);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCS_DayKhuyenMai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đẩy khuyến mại sang Oracle";
            this.Load += new System.EventHandler(this.frmBH_TimChungTu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBH_TimChungTu_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueNganhHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).EndInit();
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
        private GtidButton btnTim;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.ButtonEdit bteTrungTam;
        private DevExpress.XtraGrid.GridControl gListSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListSanPham;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repEdit;
        private GtidButton btnDong;
        private DevExpress.XtraGrid.Columns.GridColumn IdChiTietBangGia;
        private DevExpress.XtraGrid.Columns.GridColumn IdTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn IdSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn MaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TenDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn GiaNhapHDCuoi;
        private DevExpress.XtraGrid.Columns.GridColumn GiaNhapDemoCuoi;
        private DevExpress.XtraGrid.Columns.GridColumn GiaTonKhoBQ;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeVAT;
        private DevExpress.XtraGrid.Columns.GridColumn DonGiaCoVAT;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBanBuon;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBanDemo;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeThuong;
        private DevExpress.XtraGrid.Columns.GridColumn ThuongNong;
        private DevExpress.XtraGrid.Columns.GridColumn TrungMaVach;
        private DevExpress.XtraGrid.Columns.GridColumn ChietKhau;
        private DevExpress.XtraGrid.Columns.GridColumn GiaNiemYet;
        private DevExpress.XtraGrid.Columns.GridColumn GiaWebSite;
        private DevExpress.XtraGrid.Columns.GridColumn LinhVuc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TonChiTiet;
        private System.Windows.Forms.ToolStripMenuItem ChinhSachApDung;
        private DevExpress.XtraGrid.Columns.GridColumn DonGiaChuaVAT;
        private DevExpress.XtraGrid.Columns.GridColumn TienVAT;
        private GtidButton cmdExport;
        private DevExpress.XtraGrid.Columns.GridColumn Nganh;
        private System.Windows.Forms.ToolStripMenuItem LichSuThayDoiGia;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.CheckBox chkChuaDayKM;
        private GtidTextBox txtSanPham;
        private System.Windows.Forms.Label lblThuocXuat;
        private GtidButton btnNext;
        private System.Windows.Forms.ComboBox cboPage;
        private DevExpress.XtraEditors.LookUpEdit lueNganhHang;
        private DevExpress.XtraEditors.LabelControl lblLyDo;
        private GtidButton btnDongBo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel tsslGiamGia;
        private System.Windows.Forms.ToolStripStatusLabel tsslTangGia;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn Model;
        private GtidButton btnDongBoAll;
    }
}