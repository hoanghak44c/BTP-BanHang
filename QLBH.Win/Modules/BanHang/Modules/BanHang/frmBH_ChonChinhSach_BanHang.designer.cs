using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frmBH_ChonChinhSach_BanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBH_ChonChinhSach_BanHang));
            this.repCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repCheckKM = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.cmdGhiKM = new QLBH.Core.Form.GtidButton();
            this.cmdDong = new QLBH.Core.Form.GtidButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gKhuyenMai = new DevExpress.XtraGrid.GridControl();
            this.gvKhuyenMai = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdDKMuaKM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdKhuyenMaiKM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoKhuyenMai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DoUuTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SuDungKM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gKMChiTiet = new DevExpress.XtraGrid.GridControl();
            this.gvKMChiTiet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdChiTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdKhuyenMaiCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiHangKM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoaiHangKM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdHangKM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaHangKM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenHangKM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaHangSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenHangSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoTienKM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeKM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeThanhToanKM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoTienYeuCau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InKemHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HetTonDungKM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoKhuyenMai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SuDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTonKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChuKM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChinhSachKhuyenMaiCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.xtabCSThuong = new DevExpress.XtraTab.XtraTabPage();
            this.gChinhSach = new DevExpress.XtraGrid.GridControl();
            this.gvChinhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdChinhSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoChinhSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayHieuLuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HanHieuLucTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.xtabCSMacDinh = new DevExpress.XtraTab.XtraTabPage();
            this.gCSMacDinh = new DevExpress.XtraGrid.GridControl();
            this.gvCSMacDinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gSanPhamKem = new DevExpress.XtraGrid.GridControl();
            this.gvSanPhamKem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdDKMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiHangKem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoaiHangKem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdHangKem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaHangKem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenHangKem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaHangSXSPK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenHangSXSPK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaMuaTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaMuaDen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongSPK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeChietKhauSPK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienChietKhauSPK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TonKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrangThaiTon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTonKho = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.GhiChuSPK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtSanPham = new QLBH.Core.Form.GtidTextBox();
            this.lbMaSanPham = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gSanPham = new DevExpress.XtraGrid.GridControl();
            this.gvSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdChungTuChiTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSanPhamBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPhamBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongKM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyleChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienSauChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyleVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeThuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThuongNong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaTheoBangGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaNiemYet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaWebSite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoKhuyenMai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrungMaVach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiHangKem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLoaiHangKem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLePhanBo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnXoaHang = new QLBH.Core.Form.GtidButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdHangBanKem = new System.Windows.Forms.RadioButton();
            this.txtMaSanPham = new QLBH.Core.Form.GtidTextBox();
            this.btnThemHang = new QLBH.Core.Form.GtidButton();
            this.label9 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDraft = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslNoKhuyenMai = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslChuaCoGia = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslChinhSachMacDinh = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCSGStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaBan = new QLBH.Core.Form.GtidTextBox();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gThanhToan = new DevExpress.XtraGrid.GridControl();
            this.gvThanhToan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdChinhSachTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdHinhThucTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HinhThucThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdNganHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNganHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNganHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdNganHangPH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdThoiHanTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNganHangPH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NganHangPhatHanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThoiHanThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeThanhToanTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChuTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblSoVoucher = new System.Windows.Forms.Label();
            this.txtSoVoucher = new QLBH.Core.Form.GtidTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.repCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckKM)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gKhuyenMai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhuyenMai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gKMChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKMChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            this.xtabCSThuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gChinhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChinhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.xtabCSMacDinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCSMacDinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCSMacDinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSanPhamKem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPhamKem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTonKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gThanhToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThanhToan)).BeginInit();
            this.SuspendLayout();
            // 
            // repCheck
            // 
            this.repCheck.AutoHeight = false;
            this.repCheck.Name = "repCheck";
            this.repCheck.ValueChecked = 1;
            this.repCheck.ValueUnchecked = 0;
            // 
            // repCheckKM
            // 
            this.repCheckKM.AutoHeight = false;
            this.repCheckKM.Name = "repCheckKM";
            this.repCheckKM.ValueChecked = 1;
            this.repCheckKM.ValueUnchecked = 0;
            // 
            // cmdGhiKM
            // 
            this.cmdGhiKM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGhiKM.Image = ((System.Drawing.Image)(resources.GetObject("cmdGhiKM.Image")));
            this.cmdGhiKM.Location = new System.Drawing.Point(942, 441);
            this.cmdGhiKM.Name = "cmdGhiKM";
            this.cmdGhiKM.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdGhiKM.Size = new System.Drawing.Size(105, 25);
            this.cmdGhiKM.TabIndex = 0;
            this.cmdGhiKM.Text = "Xác nhận (F7)";
            this.cmdGhiKM.Click += new System.EventHandler(this.cmdGhiKM_Click);
            // 
            // cmdDong
            // 
            this.cmdDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDong.Image = ((System.Drawing.Image)(resources.GetObject("cmdDong.Image")));
            this.cmdDong.Location = new System.Drawing.Point(942, 472);
            this.cmdDong.Name = "cmdDong";
            this.cmdDong.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdDong.Size = new System.Drawing.Size(105, 25);
            this.cmdDong.TabIndex = 1;
            this.cmdDong.Text = "T&hoát (F12)";
            this.cmdDong.Click += new System.EventHandler(this.cmdDong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.gKhuyenMai);
            this.groupBox1.Controls.Add(this.gKMChiTiet);
            this.groupBox1.Location = new System.Drawing.Point(12, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1035, 175);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bước 2: Chọn khuyến mại";
            // 
            // gKhuyenMai
            // 
            this.gKhuyenMai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.gKhuyenMai.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gKhuyenMai.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gKhuyenMai.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gKhuyenMai.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gKhuyenMai.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gKhuyenMai.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gKhuyenMai.Location = new System.Drawing.Point(8, 20);
            this.gKhuyenMai.MainView = this.gvKhuyenMai;
            this.gKhuyenMai.Name = "gKhuyenMai";
            this.gKhuyenMai.Size = new System.Drawing.Size(276, 149);
            this.gKhuyenMai.TabIndex = 0;
            this.gKhuyenMai.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKhuyenMai,
            this.gridView3});
            // 
            // gvKhuyenMai
            // 
            this.gvKhuyenMai.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvKhuyenMai.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvKhuyenMai.Appearance.FocusedCell.Options.UseFont = true;
            this.gvKhuyenMai.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvKhuyenMai.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvKhuyenMai.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvKhuyenMai.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvKhuyenMai.Appearance.Row.BackColor = System.Drawing.Color.Silver;
            this.gvKhuyenMai.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvKhuyenMai.Appearance.Row.Options.UseBackColor = true;
            this.gvKhuyenMai.Appearance.Row.Options.UseBorderColor = true;
            this.gvKhuyenMai.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvKhuyenMai.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvKhuyenMai.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdDKMuaKM,
            this.IdKhuyenMaiKM,
            this.SoKhuyenMai,
            this.DoUuTien,
            this.SuDungKM});
            this.gvKhuyenMai.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvKhuyenMai.GridControl = this.gKhuyenMai;
            this.gvKhuyenMai.Name = "gvKhuyenMai";
            this.gvKhuyenMai.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvKhuyenMai.OptionsSelection.MultiSelect = true;
            this.gvKhuyenMai.OptionsView.ShowDetailButtons = false;
            this.gvKhuyenMai.OptionsView.ShowGroupPanel = false;
            this.gvKhuyenMai.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvKhuyenMai_FocusedRowChanged);
            // 
            // IdDKMuaKM
            // 
            this.IdDKMuaKM.Caption = "IdDKMua";
            this.IdDKMuaKM.FieldName = "IdDKMua";
            this.IdDKMuaKM.Name = "IdDKMuaKM";
            this.IdDKMuaKM.OptionsColumn.AllowEdit = false;
            this.IdDKMuaKM.OptionsColumn.AllowFocus = false;
            this.IdDKMuaKM.OptionsColumn.AllowMove = false;
            this.IdDKMuaKM.OptionsColumn.ReadOnly = true;
            this.IdDKMuaKM.Width = 115;
            // 
            // IdKhuyenMaiKM
            // 
            this.IdKhuyenMaiKM.Caption = "IdKhuyenMai";
            this.IdKhuyenMaiKM.FieldName = "IdKhuyenMai";
            this.IdKhuyenMaiKM.Name = "IdKhuyenMaiKM";
            this.IdKhuyenMaiKM.OptionsColumn.AllowEdit = false;
            this.IdKhuyenMaiKM.Width = 96;
            // 
            // SoKhuyenMai
            // 
            this.SoKhuyenMai.Caption = "Số khuyến mại";
            this.SoKhuyenMai.FieldName = "SoKhuyenMai";
            this.SoKhuyenMai.Name = "SoKhuyenMai";
            this.SoKhuyenMai.OptionsColumn.AllowEdit = false;
            this.SoKhuyenMai.Visible = true;
            this.SoKhuyenMai.VisibleIndex = 0;
            this.SoKhuyenMai.Width = 137;
            // 
            // DoUuTien
            // 
            this.DoUuTien.Caption = "Độ ưu tiên";
            this.DoUuTien.FieldName = "DoUuTien";
            this.DoUuTien.Name = "DoUuTien";
            this.DoUuTien.OptionsColumn.AllowEdit = false;
            this.DoUuTien.Visible = true;
            this.DoUuTien.VisibleIndex = 1;
            this.DoUuTien.Width = 64;
            // 
            // SuDungKM
            // 
            this.SuDungKM.Caption = "Kích hoạt";
            this.SuDungKM.ColumnEdit = this.repCheck;
            this.SuDungKM.FieldName = "SuDung";
            this.SuDungKM.Name = "SuDungKM";
            this.SuDungKM.OptionsColumn.AllowEdit = false;
            this.SuDungKM.Width = 63;
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gKhuyenMai;
            this.gridView3.Name = "gridView3";
            // 
            // gKMChiTiet
            // 
            this.gKMChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gKMChiTiet.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gKMChiTiet.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gKMChiTiet.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gKMChiTiet.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gKMChiTiet.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gKMChiTiet.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gKMChiTiet.Location = new System.Drawing.Point(290, 20);
            this.gKMChiTiet.MainView = this.gvKMChiTiet;
            this.gKMChiTiet.Name = "gKMChiTiet";
            this.gKMChiTiet.Size = new System.Drawing.Size(740, 149);
            this.gKMChiTiet.TabIndex = 1;
            this.gKMChiTiet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKMChiTiet,
            this.gridView1});
            // 
            // gvKMChiTiet
            // 
            this.gvKMChiTiet.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvKMChiTiet.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvKMChiTiet.Appearance.FocusedCell.Options.UseFont = true;
            this.gvKMChiTiet.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvKMChiTiet.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvKMChiTiet.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvKMChiTiet.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvKMChiTiet.Appearance.Row.BackColor = System.Drawing.Color.Silver;
            this.gvKMChiTiet.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvKMChiTiet.Appearance.Row.Options.UseBackColor = true;
            this.gvKMChiTiet.Appearance.Row.Options.UseBorderColor = true;
            this.gvKMChiTiet.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvKMChiTiet.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvKMChiTiet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdChiTiet,
            this.IdKhuyenMaiCT,
            this.LoaiHangKM,
            this.TenLoaiHangKM,
            this.IdHangKM,
            this.MaHangKM,
            this.TenHangKM,
            this.MaHangSX,
            this.TenHangSX,
            this.SoLuong,
            this.SoTienKM,
            this.TyLeKM,
            this.TyLeThanhToanKM,
            this.SoTienYeuCau,
            this.InKemHD,
            this.HetTonDungKM,
            this.colNoKhuyenMai,
            this.ChietKhau,
            this.SuDung,
            this.colTonKho,
            this.GhiChuKM,
            this.ChinhSachKhuyenMaiCT});
            this.gvKMChiTiet.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvKMChiTiet.GridControl = this.gKMChiTiet;
            this.gvKMChiTiet.Name = "gvKMChiTiet";
            this.gvKMChiTiet.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvKMChiTiet.OptionsSelection.MultiSelect = true;
            this.gvKMChiTiet.OptionsView.ColumnAutoWidth = false;
            this.gvKMChiTiet.OptionsView.ShowDetailButtons = false;
            this.gvKMChiTiet.OptionsView.ShowGroupPanel = false;
            this.gvKMChiTiet.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvKMChiTiet_RowCellStyle);
            this.gvKMChiTiet.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvKMChiTiet_RowStyle);
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
            // IdKhuyenMaiCT
            // 
            this.IdKhuyenMaiCT.Caption = "IdKhuyenMai";
            this.IdKhuyenMaiCT.FieldName = "IdKhuyenMai";
            this.IdKhuyenMaiCT.Name = "IdKhuyenMaiCT";
            this.IdKhuyenMaiCT.OptionsColumn.ReadOnly = true;
            this.IdKhuyenMaiCT.Width = 96;
            // 
            // LoaiHangKM
            // 
            this.LoaiHangKM.Caption = "LoaiHangKM";
            this.LoaiHangKM.FieldName = "LoaiHangKM";
            this.LoaiHangKM.Name = "LoaiHangKM";
            this.LoaiHangKM.OptionsColumn.ReadOnly = true;
            // 
            // TenLoaiHangKM
            // 
            this.TenLoaiHangKM.Caption = "Áp dụng cho";
            this.TenLoaiHangKM.FieldName = "TenLoaiHangKM";
            this.TenLoaiHangKM.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.TenLoaiHangKM.Name = "TenLoaiHangKM";
            this.TenLoaiHangKM.OptionsColumn.ReadOnly = true;
            this.TenLoaiHangKM.Visible = true;
            this.TenLoaiHangKM.VisibleIndex = 0;
            this.TenLoaiHangKM.Width = 79;
            // 
            // IdHangKM
            // 
            this.IdHangKM.Caption = "IdHangKM";
            this.IdHangKM.FieldName = "IdHangKM";
            this.IdHangKM.Name = "IdHangKM";
            this.IdHangKM.OptionsColumn.ReadOnly = true;
            this.IdHangKM.Width = 89;
            // 
            // MaHangKM
            // 
            this.MaHangKM.Caption = "Mã hàng";
            this.MaHangKM.FieldName = "MaHangKM";
            this.MaHangKM.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.MaHangKM.Name = "MaHangKM";
            this.MaHangKM.OptionsColumn.ReadOnly = true;
            this.MaHangKM.Visible = true;
            this.MaHangKM.VisibleIndex = 1;
            this.MaHangKM.Width = 94;
            // 
            // TenHangKM
            // 
            this.TenHangKM.Caption = "Tên hàng mua kèm";
            this.TenHangKM.FieldName = "TenHangKM";
            this.TenHangKM.Name = "TenHangKM";
            this.TenHangKM.OptionsColumn.ReadOnly = true;
            this.TenHangKM.Visible = true;
            this.TenHangKM.VisibleIndex = 2;
            this.TenHangKM.Width = 161;
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
            this.TenHangSX.Width = 114;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.DisplayFormat.FormatString = "N0";
            this.SoLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.OptionsColumn.ReadOnly = true;
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 4;
            this.SoLuong.Width = 81;
            // 
            // SoTienKM
            // 
            this.SoTienKM.Caption = "Số tiền CK";
            this.SoTienKM.DisplayFormat.FormatString = "N0";
            this.SoTienKM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SoTienKM.FieldName = "SoTienKM";
            this.SoTienKM.Name = "SoTienKM";
            this.SoTienKM.OptionsColumn.ReadOnly = true;
            this.SoTienKM.Visible = true;
            this.SoTienKM.VisibleIndex = 5;
            // 
            // TyLeKM
            // 
            this.TyLeKM.Caption = "Tỷ lệ CK";
            this.TyLeKM.FieldName = "TyLeKM";
            this.TyLeKM.Name = "TyLeKM";
            this.TyLeKM.OptionsColumn.ReadOnly = true;
            this.TyLeKM.Visible = true;
            this.TyLeKM.VisibleIndex = 6;
            this.TyLeKM.Width = 79;
            // 
            // TyLeThanhToanKM
            // 
            this.TyLeThanhToanKM.Caption = "Tỷ lệ thanh toán";
            this.TyLeThanhToanKM.FieldName = "TyLeThanhToan";
            this.TyLeThanhToanKM.Name = "TyLeThanhToanKM";
            this.TyLeThanhToanKM.OptionsColumn.ReadOnly = true;
            this.TyLeThanhToanKM.Visible = true;
            this.TyLeThanhToanKM.VisibleIndex = 7;
            this.TyLeThanhToanKM.Width = 113;
            // 
            // SoTienYeuCau
            // 
            this.SoTienYeuCau.Caption = "Số tiền yêu cầu";
            this.SoTienYeuCau.DisplayFormat.FormatString = "N0";
            this.SoTienYeuCau.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SoTienYeuCau.FieldName = "SoTienYeuCau";
            this.SoTienYeuCau.Name = "SoTienYeuCau";
            this.SoTienYeuCau.OptionsColumn.ReadOnly = true;
            this.SoTienYeuCau.Visible = true;
            this.SoTienYeuCau.VisibleIndex = 8;
            this.SoTienYeuCau.Width = 111;
            // 
            // InKemHD
            // 
            this.InKemHD.Caption = "In kèm HĐ";
            this.InKemHD.ColumnEdit = this.repCheckKM;
            this.InKemHD.FieldName = "InKemHD";
            this.InKemHD.Name = "InKemHD";
            this.InKemHD.OptionsColumn.ReadOnly = true;
            this.InKemHD.Width = 85;
            // 
            // HetTonDungKM
            // 
            this.HetTonDungKM.Caption = "Hết tồn dừng KM";
            this.HetTonDungKM.ColumnEdit = this.repCheckKM;
            this.HetTonDungKM.FieldName = "HetTonDungKM";
            this.HetTonDungKM.Name = "HetTonDungKM";
            this.HetTonDungKM.OptionsColumn.ReadOnly = true;
            this.HetTonDungKM.Visible = true;
            this.HetTonDungKM.VisibleIndex = 9;
            this.HetTonDungKM.Width = 119;
            // 
            // colNoKhuyenMai
            // 
            this.colNoKhuyenMai.Caption = "Nợ khuyến mại";
            this.colNoKhuyenMai.FieldName = "NoKhuyenMai";
            this.colNoKhuyenMai.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colNoKhuyenMai.Name = "colNoKhuyenMai";
            this.colNoKhuyenMai.OptionsColumn.ReadOnly = true;
            this.colNoKhuyenMai.Visible = true;
            this.colNoKhuyenMai.VisibleIndex = 11;
            this.colNoKhuyenMai.Width = 99;
            // 
            // ChietKhau
            // 
            this.ChietKhau.Caption = "Chiết khấu";
            this.ChietKhau.FieldName = "ChietKhau";
            this.ChietKhau.Name = "ChietKhau";
            this.ChietKhau.OptionsColumn.ReadOnly = true;
            // 
            // SuDung
            // 
            this.SuDung.Caption = "Kích hoạt";
            this.SuDung.ColumnEdit = this.repCheckKM;
            this.SuDung.FieldName = "SuDung";
            this.SuDung.Name = "SuDung";
            this.SuDung.OptionsColumn.ReadOnly = true;
            // 
            // colTonKho
            // 
            this.colTonKho.Caption = "TonKho";
            this.colTonKho.FieldName = "TonKho";
            this.colTonKho.Name = "colTonKho";
            // 
            // GhiChuKM
            // 
            this.GhiChuKM.Caption = "Chi chú";
            this.GhiChuKM.FieldName = "GhiChu";
            this.GhiChuKM.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.GhiChuKM.Name = "GhiChuKM";
            this.GhiChuKM.Visible = true;
            this.GhiChuKM.VisibleIndex = 12;
            this.GhiChuKM.Width = 96;
            // 
            // ChinhSachKhuyenMaiCT
            // 
            this.ChinhSachKhuyenMaiCT.Caption = "Chính sách khuyến mại";
            this.ChinhSachKhuyenMaiCT.FieldName = "ChinhSachKhuyenMai";
            this.ChinhSachKhuyenMaiCT.Name = "ChinhSachKhuyenMaiCT";
            this.ChinhSachKhuyenMaiCT.OptionsColumn.ReadOnly = true;
            this.ChinhSachKhuyenMaiCT.Visible = true;
            this.ChinhSachKhuyenMaiCT.VisibleIndex = 10;
            this.ChinhSachKhuyenMaiCT.Width = 137;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gKMChiTiet;
            this.gridView1.Name = "gridView1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.xtraTabControl2);
            this.groupBox2.Location = new System.Drawing.Point(12, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 135);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "1. Chọn chính sách áp dụng";
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl2.Location = new System.Drawing.Point(6, 20);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.xtabCSThuong;
            this.xtraTabControl2.Size = new System.Drawing.Size(435, 115);
            this.xtraTabControl2.TabIndex = 88;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtabCSThuong,
            this.xtabCSMacDinh});
            // 
            // xtabCSThuong
            // 
            this.xtabCSThuong.Controls.Add(this.gChinhSach);
            this.xtabCSThuong.Name = "xtabCSThuong";
            this.xtabCSThuong.Size = new System.Drawing.Size(428, 87);
            this.xtabCSThuong.Text = "Chính sách thường";
            // 
            // gChinhSach
            // 
            this.gChinhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gChinhSach.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gChinhSach.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gChinhSach.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gChinhSach.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gChinhSach.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gChinhSach.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gChinhSach.Location = new System.Drawing.Point(3, 3);
            this.gChinhSach.MainView = this.gvChinhSach;
            this.gChinhSach.Name = "gChinhSach";
            this.gChinhSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gChinhSach.Size = new System.Drawing.Size(422, 83);
            this.gChinhSach.TabIndex = 86;
            this.gChinhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChinhSach});
            // 
            // gvChinhSach
            // 
            this.gvChinhSach.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvChinhSach.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvChinhSach.Appearance.FocusedCell.Options.UseFont = true;
            this.gvChinhSach.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvChinhSach.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvChinhSach.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvChinhSach.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvChinhSach.Appearance.Row.BackColor = System.Drawing.Color.Silver;
            this.gvChinhSach.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvChinhSach.Appearance.Row.Options.UseBackColor = true;
            this.gvChinhSach.Appearance.Row.Options.UseBorderColor = true;
            this.gvChinhSach.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvChinhSach.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvChinhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdChinhSach,
            this.SoChinhSach,
            this.gridColumn4,
            this.NgayHieuLuc,
            this.HanHieuLucTT});
            this.gvChinhSach.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvChinhSach.GridControl = this.gChinhSach;
            this.gvChinhSach.Name = "gvChinhSach";
            this.gvChinhSach.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvChinhSach.OptionsView.ShowDetailButtons = false;
            this.gvChinhSach.OptionsView.ShowGroupPanel = false;
            this.gvChinhSach.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvChinhSach_FocusedRowChanged);
            // 
            // IdChinhSach
            // 
            this.IdChinhSach.Caption = "IdChinhSach";
            this.IdChinhSach.FieldName = "IdChinhSach";
            this.IdChinhSach.Name = "IdChinhSach";
            this.IdChinhSach.OptionsColumn.AllowEdit = false;
            this.IdChinhSach.OptionsColumn.AllowFocus = false;
            this.IdChinhSach.OptionsColumn.AllowMove = false;
            this.IdChinhSach.OptionsColumn.ReadOnly = true;
            this.IdChinhSach.Width = 115;
            // 
            // SoChinhSach
            // 
            this.SoChinhSach.Caption = "Số chính sách";
            this.SoChinhSach.FieldName = "SoChinhSach";
            this.SoChinhSach.Name = "SoChinhSach";
            this.SoChinhSach.OptionsColumn.AllowFocus = false;
            this.SoChinhSach.OptionsColumn.AllowMove = false;
            this.SoChinhSach.OptionsColumn.ReadOnly = true;
            this.SoChinhSach.Visible = true;
            this.SoChinhSach.VisibleIndex = 0;
            this.SoChinhSach.Width = 169;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Độ ưu tiên";
            this.gridColumn4.FieldName = "DoUuTien";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 83;
            // 
            // NgayHieuLuc
            // 
            this.NgayHieuLuc.Caption = "Hiệu lực từ ngày";
            this.NgayHieuLuc.FieldName = "NgayHieuLuc";
            this.NgayHieuLuc.Name = "NgayHieuLuc";
            this.NgayHieuLuc.OptionsColumn.ReadOnly = true;
            this.NgayHieuLuc.Visible = true;
            this.NgayHieuLuc.VisibleIndex = 2;
            this.NgayHieuLuc.Width = 114;
            // 
            // HanHieuLucTT
            // 
            this.HanHieuLucTT.Caption = "Hiệu lực đến";
            this.HanHieuLucTT.FieldName = "HanHieuLucTT";
            this.HanHieuLucTT.Name = "HanHieuLucTT";
            this.HanHieuLucTT.OptionsColumn.ReadOnly = true;
            this.HanHieuLucTT.Visible = true;
            this.HanHieuLucTT.VisibleIndex = 3;
            this.HanHieuLucTT.Width = 98;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // xtabCSMacDinh
            // 
            this.xtabCSMacDinh.Controls.Add(this.gCSMacDinh);
            this.xtabCSMacDinh.Name = "xtabCSMacDinh";
            this.xtabCSMacDinh.Size = new System.Drawing.Size(428, 86);
            this.xtabCSMacDinh.Text = "Chính sách mặc định";
            // 
            // gCSMacDinh
            // 
            this.gCSMacDinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gCSMacDinh.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gCSMacDinh.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gCSMacDinh.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gCSMacDinh.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gCSMacDinh.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gCSMacDinh.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gCSMacDinh.Location = new System.Drawing.Point(3, 3);
            this.gCSMacDinh.MainView = this.gvCSMacDinh;
            this.gCSMacDinh.Name = "gCSMacDinh";
            this.gCSMacDinh.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.gCSMacDinh.Size = new System.Drawing.Size(422, 81);
            this.gCSMacDinh.TabIndex = 87;
            this.gCSMacDinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCSMacDinh});
            // 
            // gvCSMacDinh
            // 
            this.gvCSMacDinh.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvCSMacDinh.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvCSMacDinh.Appearance.FocusedCell.Options.UseFont = true;
            this.gvCSMacDinh.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvCSMacDinh.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvCSMacDinh.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvCSMacDinh.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvCSMacDinh.Appearance.Row.BackColor = System.Drawing.Color.Silver;
            this.gvCSMacDinh.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvCSMacDinh.Appearance.Row.Options.UseBackColor = true;
            this.gvCSMacDinh.Appearance.Row.Options.UseBorderColor = true;
            this.gvCSMacDinh.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvCSMacDinh.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvCSMacDinh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn6});
            this.gvCSMacDinh.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvCSMacDinh.GridControl = this.gCSMacDinh;
            this.gvCSMacDinh.Name = "gvCSMacDinh";
            this.gvCSMacDinh.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvCSMacDinh.OptionsView.ShowDetailButtons = false;
            this.gvCSMacDinh.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "IdChinhSach";
            this.gridColumn1.FieldName = "IdChinhSach";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.AllowMove = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Width = 115;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Số chính sách";
            this.gridColumn2.FieldName = "SoChinhSach";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.AllowMove = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 169;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Độ ưu tiên";
            this.gridColumn3.FieldName = "DoUuTien";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 83;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Hiệu lực từ ngày";
            this.gridColumn5.FieldName = "NgayHieuLuc";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 114;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Hiệu lực đến";
            this.gridColumn6.FieldName = "HanHieuLucTT";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 98;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.ValueChecked = 1;
            this.repositoryItemCheckEdit2.ValueUnchecked = 0;
            // 
            // gSanPhamKem
            // 
            this.gSanPhamKem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gSanPhamKem.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gSanPhamKem.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gSanPhamKem.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gSanPhamKem.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gSanPhamKem.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gSanPhamKem.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gSanPhamKem.Location = new System.Drawing.Point(3, 3);
            this.gSanPhamKem.MainView = this.gvSanPhamKem;
            this.gSanPhamKem.Name = "gSanPhamKem";
            this.gSanPhamKem.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repTonKho});
            this.gSanPhamKem.Size = new System.Drawing.Size(575, 117);
            this.gSanPhamKem.TabIndex = 86;
            this.gSanPhamKem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSanPhamKem,
            this.gridView4});
            // 
            // gvSanPhamKem
            // 
            this.gvSanPhamKem.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvSanPhamKem.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvSanPhamKem.Appearance.FocusedCell.Options.UseFont = true;
            this.gvSanPhamKem.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvSanPhamKem.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvSanPhamKem.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvSanPhamKem.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvSanPhamKem.Appearance.Row.BackColor = System.Drawing.Color.Silver;
            this.gvSanPhamKem.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvSanPhamKem.Appearance.Row.Options.UseBackColor = true;
            this.gvSanPhamKem.Appearance.Row.Options.UseBorderColor = true;
            this.gvSanPhamKem.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvSanPhamKem.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvSanPhamKem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdDKMua,
            this.LoaiHangKem,
            this.TenLoaiHangKem,
            this.IdHangKem,
            this.MaHangKem,
            this.TenHangKem,
            this.MaHangSXSPK,
            this.TenHangSXSPK,
            this.GiaMuaTu,
            this.GiaMuaDen,
            this.SoLuongSPK,
            this.TyLeChietKhauSPK,
            this.TienChietKhauSPK,
            this.TonKho,
            this.TrangThaiTon,
            this.GhiChuSPK});
            this.gvSanPhamKem.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvSanPhamKem.GridControl = this.gSanPhamKem;
            this.gvSanPhamKem.Name = "gvSanPhamKem";
            this.gvSanPhamKem.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvSanPhamKem.OptionsSelection.MultiSelect = true;
            this.gvSanPhamKem.OptionsView.ColumnAutoWidth = false;
            this.gvSanPhamKem.OptionsView.ShowDetailButtons = false;
            this.gvSanPhamKem.OptionsView.ShowGroupPanel = false;
            this.gvSanPhamKem.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvSanPhamKem_CellValueChanged);
            this.gvSanPhamKem.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvSanPhamKem_RowCellStyle);
            this.gvSanPhamKem.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvSanPhamKem_RowStyle);
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
            // LoaiHangKem
            // 
            this.LoaiHangKem.Caption = "LoaiHangKem";
            this.LoaiHangKem.FieldName = "LoaiHangKem";
            this.LoaiHangKem.Name = "LoaiHangKem";
            this.LoaiHangKem.OptionsColumn.ReadOnly = true;
            this.LoaiHangKem.Width = 96;
            // 
            // TenLoaiHangKem
            // 
            this.TenLoaiHangKem.Caption = "Áp dụng cho";
            this.TenLoaiHangKem.FieldName = "TenLoaiHangKem";
            this.TenLoaiHangKem.Name = "TenLoaiHangKem";
            this.TenLoaiHangKem.OptionsColumn.ReadOnly = true;
            this.TenLoaiHangKem.Visible = true;
            this.TenLoaiHangKem.VisibleIndex = 0;
            this.TenLoaiHangKem.Width = 95;
            // 
            // IdHangKem
            // 
            this.IdHangKem.Caption = "IdHangKem";
            this.IdHangKem.FieldName = "IdHangKem";
            this.IdHangKem.Name = "IdHangKem";
            this.IdHangKem.OptionsColumn.ReadOnly = true;
            this.IdHangKem.Width = 89;
            // 
            // MaHangKem
            // 
            this.MaHangKem.Caption = "Mã hàng";
            this.MaHangKem.FieldName = "MaHangKem";
            this.MaHangKem.Name = "MaHangKem";
            this.MaHangKem.OptionsColumn.ReadOnly = true;
            this.MaHangKem.Visible = true;
            this.MaHangKem.VisibleIndex = 1;
            this.MaHangKem.Width = 84;
            // 
            // TenHangKem
            // 
            this.TenHangKem.Caption = "Tên hàng mua kèm";
            this.TenHangKem.FieldName = "TenHangKem";
            this.TenHangKem.Name = "TenHangKem";
            this.TenHangKem.OptionsColumn.ReadOnly = true;
            this.TenHangKem.Visible = true;
            this.TenHangKem.VisibleIndex = 2;
            this.TenHangKem.Width = 153;
            // 
            // MaHangSXSPK
            // 
            this.MaHangSXSPK.Caption = "MaHangSX";
            this.MaHangSXSPK.FieldName = "MaHangSX";
            this.MaHangSXSPK.Name = "MaHangSXSPK";
            this.MaHangSXSPK.OptionsColumn.ReadOnly = true;
            // 
            // TenHangSXSPK
            // 
            this.TenHangSXSPK.Caption = "Tên hãng SX";
            this.TenHangSXSPK.FieldName = "TenHangSX";
            this.TenHangSXSPK.Name = "TenHangSXSPK";
            this.TenHangSXSPK.OptionsColumn.ReadOnly = true;
            this.TenHangSXSPK.Visible = true;
            this.TenHangSXSPK.VisibleIndex = 3;
            this.TenHangSXSPK.Width = 117;
            // 
            // GiaMuaTu
            // 
            this.GiaMuaTu.Caption = "Giá mua từ";
            this.GiaMuaTu.DisplayFormat.FormatString = "N0";
            this.GiaMuaTu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaMuaTu.FieldName = "GiaMuaTu";
            this.GiaMuaTu.Name = "GiaMuaTu";
            this.GiaMuaTu.OptionsColumn.ReadOnly = true;
            this.GiaMuaTu.Visible = true;
            this.GiaMuaTu.VisibleIndex = 7;
            // 
            // GiaMuaDen
            // 
            this.GiaMuaDen.Caption = "đến";
            this.GiaMuaDen.DisplayFormat.FormatString = "N0";
            this.GiaMuaDen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaMuaDen.FieldName = "GiaMuaDen";
            this.GiaMuaDen.Name = "GiaMuaDen";
            this.GiaMuaDen.OptionsColumn.ReadOnly = true;
            this.GiaMuaDen.Visible = true;
            this.GiaMuaDen.VisibleIndex = 8;
            this.GiaMuaDen.Width = 82;
            // 
            // SoLuongSPK
            // 
            this.SoLuongSPK.Caption = "Số lượng";
            this.SoLuongSPK.DisplayFormat.FormatString = "N0";
            this.SoLuongSPK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SoLuongSPK.FieldName = "SoLuong";
            this.SoLuongSPK.Name = "SoLuongSPK";
            this.SoLuongSPK.OptionsColumn.ReadOnly = true;
            this.SoLuongSPK.Visible = true;
            this.SoLuongSPK.VisibleIndex = 4;
            this.SoLuongSPK.Width = 106;
            // 
            // TyLeChietKhauSPK
            // 
            this.TyLeChietKhauSPK.Caption = "Tỷ lệ CK";
            this.TyLeChietKhauSPK.FieldName = "TyLeChietKhau";
            this.TyLeChietKhauSPK.Name = "TyLeChietKhauSPK";
            this.TyLeChietKhauSPK.OptionsColumn.ReadOnly = true;
            this.TyLeChietKhauSPK.Visible = true;
            this.TyLeChietKhauSPK.VisibleIndex = 5;
            // 
            // TienChietKhauSPK
            // 
            this.TienChietKhauSPK.Caption = "Số tiền CK";
            this.TienChietKhauSPK.FieldName = "TienChietKhau";
            this.TienChietKhauSPK.Name = "TienChietKhauSPK";
            this.TienChietKhauSPK.OptionsColumn.ReadOnly = true;
            this.TienChietKhauSPK.Visible = true;
            this.TienChietKhauSPK.VisibleIndex = 6;
            // 
            // TonKho
            // 
            this.TonKho.Caption = "TonKho";
            this.TonKho.FieldName = "TonKho";
            this.TonKho.Name = "TonKho";
            this.TonKho.OptionsColumn.ReadOnly = true;
            // 
            // TrangThaiTon
            // 
            this.TrangThaiTon.Caption = "Có tồn kho";
            this.TrangThaiTon.ColumnEdit = this.repTonKho;
            this.TrangThaiTon.FieldName = "TrangThaiTon";
            this.TrangThaiTon.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.TrangThaiTon.Name = "TrangThaiTon";
            this.TrangThaiTon.OptionsColumn.ReadOnly = true;
            this.TrangThaiTon.Visible = true;
            this.TrangThaiTon.VisibleIndex = 9;
            this.TrangThaiTon.Width = 92;
            // 
            // repTonKho
            // 
            this.repTonKho.AutoHeight = false;
            this.repTonKho.Name = "repTonKho";
            this.repTonKho.ValueChecked = 1;
            this.repTonKho.ValueUnchecked = 0;
            // 
            // GhiChuSPK
            // 
            this.GhiChuSPK.Caption = "Chính sách KM";
            this.GhiChuSPK.FieldName = "GhiChu";
            this.GhiChuSPK.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.GhiChuSPK.Name = "GhiChuSPK";
            this.GhiChuSPK.Visible = true;
            this.GhiChuSPK.VisibleIndex = 10;
            this.GhiChuSPK.Width = 109;
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.gSanPhamKem;
            this.gridView4.Name = "gridView4";
            // 
            // txtSanPham
            // 
            this.txtSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSanPham.Location = new System.Drawing.Point(81, 13);
            this.txtSanPham.Multiline = true;
            this.txtSanPham.Name = "txtSanPham";
            this.txtSanPham.ReadOnly = true;
            this.txtSanPham.Size = new System.Drawing.Size(619, 29);
            this.txtSanPham.TabIndex = 77;
            // 
            // lbMaSanPham
            // 
            this.lbMaSanPham.AutoSize = true;
            this.lbMaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSanPham.Location = new System.Drawing.Point(12, 17);
            this.lbMaSanPham.Name = "lbMaSanPham";
            this.lbMaSanPham.Size = new System.Drawing.Size(63, 13);
            this.lbMaSanPham.TabIndex = 76;
            this.lbMaSanPham.Text = "Sản phẩm";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.gSanPham);
            this.groupBox4.Controls.Add(this.btnXoaHang);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Controls.Add(this.rdHangBanKem);
            this.groupBox4.Controls.Add(this.txtMaSanPham);
            this.groupBox4.Controls.Add(this.btnThemHang);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(12, 368);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(919, 188);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bước 3: Nhập mã sản phẩm mua kèm và sản phẩm KM";
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
            this.gSanPham.Location = new System.Drawing.Point(8, 45);
            this.gSanPham.MainView = this.gvSanPham;
            this.gSanPham.Name = "gSanPham";
            this.gSanPham.Size = new System.Drawing.Size(905, 137);
            this.gSanPham.TabIndex = 99;
            this.gSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSanPham,
            this.gridView2});
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
            this.IdChungTu,
            this.IdChungTuChiTiet,
            this.IdSanPham,
            this.MaSanPham,
            this.TenSanPham,
            this.IdSanPhamBan,
            this.TenSanPhamBan,
            this.DonViTinh,
            this.SoLuongKM,
            this.DonGia,
            this.TyleChietKhau,
            this.TienChietKhau,
            this.TienSauChietKhau,
            this.TyleVAT,
            this.TienVAT,
            this.TyLeThanhToan,
            this.ThanhTien,
            this.TyLeThuong,
            this.ThuongNong,
            this.GiaTheoBangGia,
            this.GiaNiemYet,
            this.GiaWebSite,
            this.NoKhuyenMai,
            this.TrungMaVach,
            this.colLoaiHangKem,
            this.GhiChu,
            this.colTenLoaiHangKem,
            this.TyLePhanBo});
            this.gvSanPham.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvSanPham.GridControl = this.gSanPham;
            this.gvSanPham.Name = "gvSanPham";
            this.gvSanPham.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvSanPham.OptionsSelection.MultiSelect = true;
            this.gvSanPham.OptionsView.ColumnAutoWidth = false;
            this.gvSanPham.OptionsView.ShowDetailButtons = false;
            this.gvSanPham.OptionsView.ShowGroupPanel = false;
            this.gvSanPham.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvSanPham_RowCellStyle);
            this.gvSanPham.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gvSanPham_ShowingEditor);
            // 
            // IdChungTu
            // 
            this.IdChungTu.Caption = "IdChungTu";
            this.IdChungTu.FieldName = "IdChungTu";
            this.IdChungTu.Name = "IdChungTu";
            this.IdChungTu.OptionsColumn.AllowEdit = false;
            this.IdChungTu.OptionsColumn.AllowFocus = false;
            this.IdChungTu.OptionsColumn.AllowMove = false;
            this.IdChungTu.OptionsColumn.ReadOnly = true;
            this.IdChungTu.Width = 115;
            // 
            // IdChungTuChiTiet
            // 
            this.IdChungTuChiTiet.Caption = "IdChungTuChiTiet";
            this.IdChungTuChiTiet.FieldName = "IdChungTuChiTiet";
            this.IdChungTuChiTiet.Name = "IdChungTuChiTiet";
            this.IdChungTuChiTiet.OptionsColumn.AllowEdit = false;
            this.IdChungTuChiTiet.OptionsColumn.AllowFocus = false;
            this.IdChungTuChiTiet.OptionsColumn.AllowMove = false;
            this.IdChungTuChiTiet.OptionsColumn.ReadOnly = true;
            this.IdChungTuChiTiet.Width = 234;
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
            this.MaSanPham.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.OptionsColumn.AllowEdit = false;
            this.MaSanPham.Visible = true;
            this.MaSanPham.VisibleIndex = 0;
            this.MaSanPham.Width = 99;
            // 
            // TenSanPham
            // 
            this.TenSanPham.Caption = "Tên sản phẩm";
            this.TenSanPham.FieldName = "TenSanPham";
            this.TenSanPham.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.OptionsColumn.AllowEdit = false;
            this.TenSanPham.Visible = true;
            this.TenSanPham.VisibleIndex = 1;
            this.TenSanPham.Width = 251;
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
            this.TenSanPhamBan.Caption = "TenSanPhamBan";
            this.TenSanPhamBan.FieldName = "TenSanPhamBan";
            this.TenSanPhamBan.Name = "TenSanPhamBan";
            this.TenSanPhamBan.OptionsColumn.AllowEdit = false;
            this.TenSanPhamBan.Width = 238;
            // 
            // DonViTinh
            // 
            this.DonViTinh.Caption = "Đơn vị tính";
            this.DonViTinh.FieldName = "DonViTinh";
            this.DonViTinh.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.OptionsColumn.AllowEdit = false;
            this.DonViTinh.Visible = true;
            this.DonViTinh.VisibleIndex = 2;
            this.DonViTinh.Width = 83;
            // 
            // SoLuongKM
            // 
            this.SoLuongKM.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.SoLuongKM.AppearanceCell.Options.UseBackColor = true;
            this.SoLuongKM.Caption = "Số lượng";
            this.SoLuongKM.DisplayFormat.FormatString = "N0";
            this.SoLuongKM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SoLuongKM.FieldName = "SoLuong";
            this.SoLuongKM.Name = "SoLuongKM";
            this.SoLuongKM.OptionsColumn.ReadOnly = true;
            this.SoLuongKM.Visible = true;
            this.SoLuongKM.VisibleIndex = 3;
            this.SoLuongKM.Width = 88;
            // 
            // DonGia
            // 
            this.DonGia.Caption = "Đơn giá";
            this.DonGia.DisplayFormat.FormatString = "N0";
            this.DonGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DonGia.FieldName = "DonGia";
            this.DonGia.Name = "DonGia";
            this.DonGia.OptionsColumn.AllowEdit = false;
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 4;
            this.DonGia.Width = 95;
            // 
            // TyleChietKhau
            // 
            this.TyleChietKhau.Caption = "CK (%)";
            this.TyleChietKhau.DisplayFormat.FormatString = "N0";
            this.TyleChietKhau.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyleChietKhau.FieldName = "TyleChietKhau";
            this.TyleChietKhau.Name = "TyleChietKhau";
            this.TyleChietKhau.OptionsColumn.AllowEdit = false;
            this.TyleChietKhau.Visible = true;
            this.TyleChietKhau.VisibleIndex = 5;
            this.TyleChietKhau.Width = 80;
            // 
            // TienChietKhau
            // 
            this.TienChietKhau.Caption = "Tiền CK";
            this.TienChietKhau.DisplayFormat.FormatString = "N0";
            this.TienChietKhau.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TienChietKhau.FieldName = "TienChietKhau";
            this.TienChietKhau.Name = "TienChietKhau";
            this.TienChietKhau.OptionsColumn.AllowEdit = false;
            this.TienChietKhau.Visible = true;
            this.TienChietKhau.VisibleIndex = 6;
            this.TienChietKhau.Width = 94;
            // 
            // TienSauChietKhau
            // 
            this.TienSauChietKhau.Caption = "Tiền sau CK";
            this.TienSauChietKhau.FieldName = "TienSauChietKhau";
            this.TienSauChietKhau.Name = "TienSauChietKhau";
            this.TienSauChietKhau.OptionsColumn.AllowEdit = false;
            this.TienSauChietKhau.Visible = true;
            this.TienSauChietKhau.VisibleIndex = 7;
            this.TienSauChietKhau.Width = 98;
            // 
            // TyleVAT
            // 
            this.TyleVAT.Caption = "VAT (%)";
            this.TyleVAT.DisplayFormat.FormatString = "N0";
            this.TyleVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyleVAT.FieldName = "TyleVAT";
            this.TyleVAT.Name = "TyleVAT";
            this.TyleVAT.OptionsColumn.AllowEdit = false;
            this.TyleVAT.Visible = true;
            this.TyleVAT.VisibleIndex = 8;
            this.TyleVAT.Width = 99;
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
            this.TienVAT.VisibleIndex = 9;
            this.TienVAT.Width = 95;
            // 
            // TyLeThanhToan
            // 
            this.TyLeThanhToan.Caption = "Tỷ lệ thanh toán";
            this.TyLeThanhToan.FieldName = "TyLeThanhToan";
            this.TyLeThanhToan.Name = "TyLeThanhToan";
            this.TyLeThanhToan.OptionsColumn.AllowEdit = false;
            this.TyLeThanhToan.Visible = true;
            this.TyLeThanhToan.VisibleIndex = 10;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Caption = "Thành tiền";
            this.ThanhTien.DisplayFormat.FormatString = "N0";
            this.ThanhTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ThanhTien.FieldName = "ThanhTien";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.OptionsColumn.AllowEdit = false;
            this.ThanhTien.Visible = true;
            this.ThanhTien.VisibleIndex = 11;
            this.ThanhTien.Width = 85;
            // 
            // TyLeThuong
            // 
            this.TyLeThuong.Caption = "TyLeThuong";
            this.TyLeThuong.FieldName = "TyLeThuong";
            this.TyLeThuong.Name = "TyLeThuong";
            this.TyLeThuong.OptionsColumn.AllowEdit = false;
            // 
            // ThuongNong
            // 
            this.ThuongNong.Caption = "ThuongNong";
            this.ThuongNong.FieldName = "ThuongNong";
            this.ThuongNong.Name = "ThuongNong";
            this.ThuongNong.OptionsColumn.AllowEdit = false;
            // 
            // GiaTheoBangGia
            // 
            this.GiaTheoBangGia.Caption = "GiaTheoBangGia";
            this.GiaTheoBangGia.FieldName = "GiaTheoBangGia";
            this.GiaTheoBangGia.Name = "GiaTheoBangGia";
            this.GiaTheoBangGia.OptionsColumn.AllowEdit = false;
            // 
            // GiaNiemYet
            // 
            this.GiaNiemYet.Caption = "GiaNiemYet";
            this.GiaNiemYet.FieldName = "GiaNiemYet";
            this.GiaNiemYet.Name = "GiaNiemYet";
            this.GiaNiemYet.OptionsColumn.AllowEdit = false;
            // 
            // GiaWebSite
            // 
            this.GiaWebSite.Caption = "GiaWebSite";
            this.GiaWebSite.FieldName = "GiaWebSite";
            this.GiaWebSite.Name = "GiaWebSite";
            this.GiaWebSite.OptionsColumn.AllowEdit = false;
            // 
            // NoKhuyenMai
            // 
            this.NoKhuyenMai.Caption = "NoKhuyenMai";
            this.NoKhuyenMai.FieldName = "NoKhuyenMai";
            this.NoKhuyenMai.Name = "NoKhuyenMai";
            this.NoKhuyenMai.OptionsColumn.AllowEdit = false;
            // 
            // TrungMaVach
            // 
            this.TrungMaVach.Caption = "TrungMaVach";
            this.TrungMaVach.FieldName = "TrungMaVach";
            this.TrungMaVach.Name = "TrungMaVach";
            this.TrungMaVach.OptionsColumn.AllowEdit = false;
            // 
            // colLoaiHangKem
            // 
            this.colLoaiHangKem.Caption = "LoaiHangKem";
            this.colLoaiHangKem.FieldName = "LoaiHangKem";
            this.colLoaiHangKem.Name = "colLoaiHangKem";
            // 
            // GhiChu
            // 
            this.GhiChu.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.GhiChu.AppearanceCell.Options.UseBackColor = true;
            this.GhiChu.Caption = "Ghi chú";
            this.GhiChu.FieldName = "GhiChu";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Visible = true;
            this.GhiChu.VisibleIndex = 12;
            this.GhiChu.Width = 152;
            // 
            // colTenLoaiHangKem
            // 
            this.colTenLoaiHangKem.Caption = "Loại hàng hóa";
            this.colTenLoaiHangKem.FieldName = "TenLoaiHangKem";
            this.colTenLoaiHangKem.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colTenLoaiHangKem.Name = "colTenLoaiHangKem";
            this.colTenLoaiHangKem.Visible = true;
            this.colTenLoaiHangKem.VisibleIndex = 13;
            this.colTenLoaiHangKem.Width = 100;
            // 
            // TyLePhanBo
            // 
            this.TyLePhanBo.Caption = "TyLePhanBo";
            this.TyLePhanBo.FieldName = "TyLePhanBo";
            this.TyLePhanBo.Name = "TyLePhanBo";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gSanPham;
            this.gridView2.Name = "gridView2";
            // 
            // btnXoaHang
            // 
            this.btnXoaHang.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaHang.Image")));
            this.btnXoaHang.Location = new System.Drawing.Point(768, 17);
            this.btnXoaHang.Name = "btnXoaHang";
            this.btnXoaHang.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnXoaHang.Size = new System.Drawing.Size(83, 22);
            this.btnXoaHang.TabIndex = 4;
            this.btnXoaHang.Text = "&Xóa hàng";
            this.btnXoaHang.Click += new System.EventHandler(this.btnXoaHang_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(593, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.Text = "Khuyến mại";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdHangBanKem
            // 
            this.rdHangBanKem.AutoSize = true;
            this.rdHangBanKem.Checked = true;
            this.rdHangBanKem.Location = new System.Drawing.Point(524, 19);
            this.rdHangBanKem.Name = "rdHangBanKem";
            this.rdHangBanKem.Size = new System.Drawing.Size(67, 17);
            this.rdHangBanKem.TabIndex = 1;
            this.rdHangBanKem.TabStop = true;
            this.rdHangBanKem.Text = "Mua kèm";
            this.rdHangBanKem.UseVisualStyleBackColor = true;
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSanPham.Location = new System.Drawing.Point(114, 18);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(398, 22);
            this.txtMaSanPham.TabIndex = 0;
            this.txtMaSanPham.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaSanPham_KeyDown);
            this.txtMaSanPham.Enter += new System.EventHandler(this.txtMaSanPham_Enter);
            // 
            // btnThemHang
            // 
            this.btnThemHang.Image = ((System.Drawing.Image)(resources.GetObject("btnThemHang.Image")));
            this.btnThemHang.Location = new System.Drawing.Point(679, 17);
            this.btnThemHang.Name = "btnThemHang";
            this.btnThemHang.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnThemHang.Size = new System.Drawing.Size(83, 22);
            this.btnThemHang.TabIndex = 3;
            this.btnThemHang.Text = "&Thêm hàng";
            this.btnThemHang.Click += new System.EventHandler(this.btnThemHang_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(35, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 93;
            this.label9.Text = "Sản phẩm";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTrangThai,
            this.tsslDraft,
            this.toolStripStatusLabel2,
            this.tsslNoKhuyenMai,
            this.tsslChuaCoGia,
            this.tsslChinhSachMacDinh,
            this.tsslCSGStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 561);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1059, 22);
            this.statusStrip1.TabIndex = 107;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslTrangThai
            // 
            this.tsslTrangThai.BackColor = System.Drawing.Color.Red;
            this.tsslTrangThai.Name = "tsslTrangThai";
            this.tsslTrangThai.Size = new System.Drawing.Size(129, 17);
            this.tsslTrangThai.Text = "     Không có tồn kho    ";
            // 
            // tsslDraft
            // 
            this.tsslDraft.Name = "tsslDraft";
            this.tsslDraft.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslNoKhuyenMai
            // 
            this.tsslNoKhuyenMai.ActiveLinkColor = System.Drawing.Color.Yellow;
            this.tsslNoKhuyenMai.BackColor = System.Drawing.Color.Yellow;
            this.tsslNoKhuyenMai.Name = "tsslNoKhuyenMai";
            this.tsslNoKhuyenMai.Size = new System.Drawing.Size(106, 17);
            this.tsslNoKhuyenMai.Text = "   Nợ khuyến mại   ";
            // 
            // tsslChuaCoGia
            // 
            this.tsslChuaCoGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tsslChuaCoGia.Name = "tsslChuaCoGia";
            this.tsslChuaCoGia.Size = new System.Drawing.Size(85, 17);
            this.tsslChuaCoGia.Text = "   Chưa có giá  ";
            // 
            // tsslChinhSachMacDinh
            // 
            this.tsslChinhSachMacDinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tsslChinhSachMacDinh.Name = "tsslChinhSachMacDinh";
            this.tsslChinhSachMacDinh.Size = new System.Drawing.Size(134, 17);
            this.tsslChinhSachMacDinh.Text = "   Chính sách mặc định  ";
            // 
            // tsslCSGStatus
            // 
            this.tsslCSGStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tsslCSGStatus.Name = "tsslCSGStatus";
            this.tsslCSGStatus.Size = new System.Drawing.Size(51, 17);
            this.tsslCSGStatus.Text = "Ghi chú:";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txtSanPham);
            this.groupBox5.Controls.Add(this.txtGiaBan);
            this.groupBox5.Controls.Add(this.lbMaSanPham);
            this.groupBox5.Location = new System.Drawing.Point(13, 1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1034, 48);
            this.groupBox5.TabIndex = 108;
            this.groupBox5.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(729, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Giá bán";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiaBan.Location = new System.Drawing.Point(791, 13);
            this.txtGiaBan.Multiline = true;
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.ReadOnly = true;
            this.txtGiaBan.Size = new System.Drawing.Size(224, 29);
            this.txtGiaBan.TabIndex = 79;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(459, 55);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(588, 133);
            this.xtraTabControl1.TabIndex = 87;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gSanPhamKem);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(581, 105);
            this.xtraTabPage1.Text = "Sản phẩm mua kèm";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gThanhToan);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(581, 104);
            this.xtraTabPage2.Text = "Điều kiện thanh toán";
            // 
            // gThanhToan
            // 
            this.gThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gThanhToan.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gThanhToan.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gThanhToan.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gThanhToan.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gThanhToan.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gThanhToan.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gThanhToan.Location = new System.Drawing.Point(3, 3);
            this.gThanhToan.MainView = this.gvThanhToan;
            this.gThanhToan.Name = "gThanhToan";
            this.gThanhToan.Size = new System.Drawing.Size(575, 101);
            this.gThanhToan.TabIndex = 4;
            this.gThanhToan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvThanhToan});
            // 
            // gvThanhToan
            // 
            this.gvThanhToan.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvThanhToan.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvThanhToan.Appearance.FocusedCell.Options.UseFont = true;
            this.gvThanhToan.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvThanhToan.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvThanhToan.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvThanhToan.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvThanhToan.Appearance.Row.BackColor = System.Drawing.Color.Silver;
            this.gvThanhToan.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvThanhToan.Appearance.Row.Options.UseBackColor = true;
            this.gvThanhToan.Appearance.Row.Options.UseBorderColor = true;
            this.gvThanhToan.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvThanhToan.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvThanhToan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdChinhSachTT,
            this.IdHinhThucTT,
            this.HinhThucThanhToan,
            this.IdNganHang,
            this.MaNganHang,
            this.TenNganHang,
            this.IdNganHangPH,
            this.IdThoiHanTT,
            this.MaNganHangPH,
            this.NganHangPhatHanh,
            this.ThoiHanThanhToan,
            this.TyLeThanhToanTT,
            this.GhiChuTT});
            this.gvThanhToan.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvThanhToan.GridControl = this.gThanhToan;
            this.gvThanhToan.Name = "gvThanhToan";
            this.gvThanhToan.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvThanhToan.OptionsSelection.MultiSelect = true;
            this.gvThanhToan.OptionsView.ShowDetailButtons = false;
            this.gvThanhToan.OptionsView.ShowGroupPanel = false;
            this.gvThanhToan.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvThanhToan_RowStyle);
            // 
            // IdChinhSachTT
            // 
            this.IdChinhSachTT.Caption = "IdChinhSach";
            this.IdChinhSachTT.FieldName = "IdChinhSach";
            this.IdChinhSachTT.Name = "IdChinhSachTT";
            this.IdChinhSachTT.OptionsColumn.AllowEdit = false;
            this.IdChinhSachTT.OptionsColumn.AllowFocus = false;
            this.IdChinhSachTT.OptionsColumn.AllowMove = false;
            this.IdChinhSachTT.OptionsColumn.ReadOnly = true;
            this.IdChinhSachTT.Width = 115;
            // 
            // IdHinhThucTT
            // 
            this.IdHinhThucTT.Caption = "IdHinhThucTT";
            this.IdHinhThucTT.FieldName = "IdHinhThucTT";
            this.IdHinhThucTT.Name = "IdHinhThucTT";
            this.IdHinhThucTT.OptionsColumn.AllowEdit = false;
            this.IdHinhThucTT.OptionsColumn.AllowFocus = false;
            this.IdHinhThucTT.OptionsColumn.AllowMove = false;
            this.IdHinhThucTT.OptionsColumn.ReadOnly = true;
            this.IdHinhThucTT.Width = 150;
            // 
            // HinhThucThanhToan
            // 
            this.HinhThucThanhToan.Caption = "Hình thức T.Toán";
            this.HinhThucThanhToan.FieldName = "HinhThucThanhToan";
            this.HinhThucThanhToan.Name = "HinhThucThanhToan";
            this.HinhThucThanhToan.OptionsColumn.AllowEdit = false;
            this.HinhThucThanhToan.OptionsColumn.ReadOnly = true;
            this.HinhThucThanhToan.Visible = true;
            this.HinhThucThanhToan.VisibleIndex = 0;
            this.HinhThucThanhToan.Width = 106;
            // 
            // IdNganHang
            // 
            this.IdNganHang.Caption = "IdNganHang";
            this.IdNganHang.FieldName = "IdNganHang";
            this.IdNganHang.Name = "IdNganHang";
            this.IdNganHang.OptionsColumn.AllowEdit = false;
            this.IdNganHang.OptionsColumn.ReadOnly = true;
            this.IdNganHang.Width = 168;
            // 
            // MaNganHang
            // 
            this.MaNganHang.Caption = "Mã";
            this.MaNganHang.FieldName = "MaNganHang";
            this.MaNganHang.Name = "MaNganHang";
            this.MaNganHang.OptionsColumn.AllowEdit = false;
            this.MaNganHang.OptionsColumn.ReadOnly = true;
            this.MaNganHang.Width = 64;
            // 
            // TenNganHang
            // 
            this.TenNganHang.Caption = "Ngân hàng T.Toán";
            this.TenNganHang.FieldName = "TenNganHang";
            this.TenNganHang.Name = "TenNganHang";
            this.TenNganHang.OptionsColumn.AllowEdit = false;
            this.TenNganHang.OptionsColumn.ReadOnly = true;
            this.TenNganHang.Visible = true;
            this.TenNganHang.VisibleIndex = 1;
            this.TenNganHang.Width = 112;
            // 
            // IdNganHangPH
            // 
            this.IdNganHangPH.Caption = "IdNganHangPH";
            this.IdNganHangPH.FieldName = "IdNganHangPH";
            this.IdNganHangPH.Name = "IdNganHangPH";
            this.IdNganHangPH.OptionsColumn.AllowEdit = false;
            this.IdNganHangPH.OptionsColumn.ReadOnly = true;
            // 
            // IdThoiHanTT
            // 
            this.IdThoiHanTT.Caption = "IdThoiHanTT";
            this.IdThoiHanTT.FieldName = "IdThoiHanTT";
            this.IdThoiHanTT.Name = "IdThoiHanTT";
            this.IdThoiHanTT.OptionsColumn.AllowEdit = false;
            this.IdThoiHanTT.OptionsColumn.ReadOnly = true;
            this.IdThoiHanTT.Width = 59;
            // 
            // MaNganHangPH
            // 
            this.MaNganHangPH.Caption = "MaNganHangPH";
            this.MaNganHangPH.FieldName = "MaNganHangPH";
            this.MaNganHangPH.Name = "MaNganHangPH";
            this.MaNganHangPH.OptionsColumn.AllowEdit = false;
            this.MaNganHangPH.OptionsColumn.ReadOnly = true;
            // 
            // NganHangPhatHanh
            // 
            this.NganHangPhatHanh.Caption = "Ngân hàng phát hành";
            this.NganHangPhatHanh.FieldName = "TenNganHangPH";
            this.NganHangPhatHanh.Name = "NganHangPhatHanh";
            this.NganHangPhatHanh.OptionsColumn.AllowEdit = false;
            this.NganHangPhatHanh.OptionsColumn.ReadOnly = true;
            this.NganHangPhatHanh.Visible = true;
            this.NganHangPhatHanh.VisibleIndex = 2;
            this.NganHangPhatHanh.Width = 126;
            // 
            // ThoiHanThanhToan
            // 
            this.ThoiHanThanhToan.Caption = "Thời hạn TT";
            this.ThoiHanThanhToan.FieldName = "ThoiHanThanhToan";
            this.ThoiHanThanhToan.Name = "ThoiHanThanhToan";
            this.ThoiHanThanhToan.OptionsColumn.AllowEdit = false;
            this.ThoiHanThanhToan.OptionsColumn.ReadOnly = true;
            this.ThoiHanThanhToan.Visible = true;
            this.ThoiHanThanhToan.VisibleIndex = 3;
            this.ThoiHanThanhToan.Width = 65;
            // 
            // TyLeThanhToanTT
            // 
            this.TyLeThanhToanTT.Caption = "Tỷ lệ TT";
            this.TyLeThanhToanTT.FieldName = "TyLeThanhToan";
            this.TyLeThanhToanTT.Name = "TyLeThanhToanTT";
            this.TyLeThanhToanTT.OptionsColumn.AllowEdit = false;
            this.TyLeThanhToanTT.OptionsColumn.ReadOnly = true;
            this.TyLeThanhToanTT.Visible = true;
            this.TyLeThanhToanTT.VisibleIndex = 4;
            this.TyLeThanhToanTT.Width = 77;
            // 
            // GhiChuTT
            // 
            this.GhiChuTT.Caption = "Chính sách KM";
            this.GhiChuTT.FieldName = "GhiChu";
            this.GhiChuTT.Name = "GhiChuTT";
            this.GhiChuTT.Visible = true;
            this.GhiChuTT.VisibleIndex = 5;
            // 
            // lblSoVoucher
            // 
            this.lblSoVoucher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoVoucher.AutoSize = true;
            this.lblSoVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoVoucher.Location = new System.Drawing.Point(944, 377);
            this.lblSoVoucher.Name = "lblSoVoucher";
            this.lblSoVoucher.Size = new System.Drawing.Size(88, 16);
            this.lblSoVoucher.TabIndex = 109;
            this.lblSoVoucher.Text = "Số Voucher";
            this.lblSoVoucher.Visible = false;
            // 
            // txtSoVoucher
            // 
            this.txtSoVoucher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoVoucher.BackColor = System.Drawing.Color.White;
            this.txtSoVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoVoucher.Location = new System.Drawing.Point(942, 398);
            this.txtSoVoucher.Name = "txtSoVoucher";
            this.txtSoVoucher.Size = new System.Drawing.Size(105, 22);
            this.txtSoVoucher.TabIndex = 100;
            this.txtSoVoucher.Visible = false;
            // 
            // frmBH_ChonChinhSach_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 583);
            this.Controls.Add(this.txtSoVoucher);
            this.Controls.Add(this.lblSoVoucher);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdGhiKM);
            this.Controls.Add(this.cmdDong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.KeyPreview = true;
            this.Name = "frmBH_ChonChinhSach_BanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập chính sách khuyến mại";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_ThietLapKM_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBH_ChonChinhSach_BanHang_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_ThietLapKM_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.repCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckKM)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gKhuyenMai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhuyenMai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gKMChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKMChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            this.xtabCSThuong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gChinhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChinhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.xtabCSMacDinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gCSMacDinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCSMacDinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSanPhamKem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPhamKem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTonKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gThanhToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThanhToan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal GtidButton cmdGhiKM;
        internal GtidButton cmdDong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gKMChiTiet;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKMChiTiet;
        private DevExpress.XtraGrid.Columns.GridColumn IdChiTiet;
        private DevExpress.XtraGrid.Columns.GridColumn IdKhuyenMaiCT;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoaiHangKM;
        private DevExpress.XtraGrid.Columns.GridColumn IdHangKM;
        private DevExpress.XtraGrid.Columns.GridColumn MaHangKM;
        private DevExpress.XtraGrid.Columns.GridColumn TenHangKM;
        private DevExpress.XtraGrid.Columns.GridColumn MaHangSX;
        private DevExpress.XtraGrid.Columns.GridColumn TenHangSX;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn SoTienKM;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gKhuyenMai;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKhuyenMai;
        private DevExpress.XtraGrid.Columns.GridColumn IdDKMuaKM;
        private DevExpress.XtraGrid.Columns.GridColumn IdKhuyenMaiKM;
        private DevExpress.XtraGrid.Columns.GridColumn SoKhuyenMai;
        private DevExpress.XtraGrid.Columns.GridColumn DoUuTien;
        private DevExpress.XtraGrid.Columns.GridColumn SuDungKM;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiHangKM;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeKM;
        private DevExpress.XtraGrid.Columns.GridColumn InKemHD;
        private DevExpress.XtraGrid.Columns.GridColumn HetTonDungKM;
        private DevExpress.XtraGrid.Columns.GridColumn ChietKhau;
        private DevExpress.XtraGrid.Columns.GridColumn SuDung;
        private DevExpress.XtraGrid.GridControl gSanPhamKem;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSanPhamKem;
        private DevExpress.XtraGrid.Columns.GridColumn IdDKMua;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiHangKem;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoaiHangKem;
        private DevExpress.XtraGrid.Columns.GridColumn IdHangKem;
        private DevExpress.XtraGrid.Columns.GridColumn MaHangKem;
        private DevExpress.XtraGrid.Columns.GridColumn TenHangKem;
        private DevExpress.XtraGrid.Columns.GridColumn MaHangSXSPK;
        private DevExpress.XtraGrid.Columns.GridColumn TenHangSXSPK;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongSPK;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.GridControl gChinhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChinhSach;
        private DevExpress.XtraGrid.Columns.GridColumn IdChinhSach;
        private DevExpress.XtraGrid.Columns.GridColumn SoChinhSach;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn NgayHieuLuc;
        private DevExpress.XtraGrid.Columns.GridColumn HanHieuLucTT;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private GtidTextBox txtSanPham;
        private System.Windows.Forms.Label lbMaSanPham;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdHangBanKem;
        private GtidTextBox txtMaSanPham;
        internal GtidButton btnThemHang;
        private System.Windows.Forms.Label label9;
        internal GtidButton btnXoaHang;
        private DevExpress.XtraGrid.GridControl gSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn IdChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn IdChungTuChiTiet;
        private DevExpress.XtraGrid.Columns.GridColumn IdSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn MaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn IdSanPhamBan;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPhamBan;
        private DevExpress.XtraGrid.Columns.GridColumn DonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongKM;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraGrid.Columns.GridColumn TyleChietKhau;
        private DevExpress.XtraGrid.Columns.GridColumn TienChietKhau;
        private DevExpress.XtraGrid.Columns.GridColumn TienSauChietKhau;
        private DevExpress.XtraGrid.Columns.GridColumn TyleVAT;
        private DevExpress.XtraGrid.Columns.GridColumn TienVAT;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhTien;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeThuong;
        private DevExpress.XtraGrid.Columns.GridColumn ThuongNong;
        private DevExpress.XtraGrid.Columns.GridColumn GiaTheoBangGia;
        private DevExpress.XtraGrid.Columns.GridColumn GiaNiemYet;
        private DevExpress.XtraGrid.Columns.GridColumn GiaWebSite;
        private DevExpress.XtraGrid.Columns.GridColumn NoKhuyenMai;
        private DevExpress.XtraGrid.Columns.GridColumn TrungMaVach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiHangKem;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLoaiHangKem;
        private DevExpress.XtraGrid.Columns.GridColumn TyLePhanBo;
        private DevExpress.XtraGrid.Columns.GridColumn colTonKho;
        private DevExpress.XtraGrid.Columns.GridColumn colNoKhuyenMai;
        private DevExpress.XtraGrid.Columns.GridColumn TonKho;
        private DevExpress.XtraGrid.Columns.GridColumn TrangThaiTon;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repTonKho;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslTrangThai;
        private System.Windows.Forms.ToolStripStatusLabel tsslDraft;
        private System.Windows.Forms.ToolStripStatusLabel tsslNoKhuyenMai;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheck;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckKM;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeChietKhauSPK;
        private DevExpress.XtraGrid.Columns.GridColumn TienChietKhauSPK;
        private DevExpress.XtraGrid.Columns.GridColumn SoTienYeuCau;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeThanhToanKM;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChuKM;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChuSPK;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsslChuaCoGia;
        private System.Windows.Forms.ToolStripStatusLabel tsslChinhSachMacDinh;
        private System.Windows.Forms.ToolStripStatusLabel tsslCSGStatus;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private GtidTextBox txtGiaBan;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gThanhToan;
        private DevExpress.XtraGrid.Views.Grid.GridView gvThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn IdChinhSachTT;
        private DevExpress.XtraGrid.Columns.GridColumn IdHinhThucTT;
        private DevExpress.XtraGrid.Columns.GridColumn HinhThucThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn IdNganHang;
        private DevExpress.XtraGrid.Columns.GridColumn MaNganHang;
        private DevExpress.XtraGrid.Columns.GridColumn TenNganHang;
        private DevExpress.XtraGrid.Columns.GridColumn IdNganHangPH;
        private DevExpress.XtraGrid.Columns.GridColumn IdThoiHanTT;
        private DevExpress.XtraGrid.Columns.GridColumn MaNganHangPH;
        private DevExpress.XtraGrid.Columns.GridColumn NganHangPhatHanh;
        private DevExpress.XtraGrid.Columns.GridColumn ThoiHanThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeThanhToanTT;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChuTT;
        private DevExpress.XtraGrid.Columns.GridColumn ChinhSachKhuyenMaiCT;
        private DevExpress.XtraGrid.Columns.GridColumn GiaMuaTu;
        private DevExpress.XtraGrid.Columns.GridColumn GiaMuaDen;
        private System.Windows.Forms.Label lblSoVoucher;
        private GtidTextBox txtSoVoucher;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage xtabCSThuong;
        private DevExpress.XtraTab.XtraTabPage xtabCSMacDinh;
        private DevExpress.XtraGrid.GridControl gCSMacDinh;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCSMacDinh;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
    }
}