using QLBH.Core.Form;
namespace QLBanHang.Modules.BanHang
{
    partial class frmBH_ListDonHangGiaoNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBH_ListDonHangGiaoNhan));
            this.gListChungTu = new DevExpress.XtraGrid.GridControl();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gvListChungTu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDoiTuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiDonHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLoaiDonHang = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colNgayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoGiaoDich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayGiaoHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioHenGiaoHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoiGiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuanHuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoChungTuGoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoPhieuDC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoPhieuXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSanPhamBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repMEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colGhiChuGN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTienThucTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTienCoNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoiTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoiSua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDraft = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colGiaoNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repGiaoNhan = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTrangThaiDH = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbTimKiem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSession = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslInfor = new System.Windows.Forms.ToolStripLabel();
            this.grpKetQuaTimKiem = new System.Windows.Forms.GroupBox();
            this.btnNext = new QLBH.Core.Form.GtidButton();
            this.cboPage = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslHuyClr = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslHuy = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslChuaDuyetClr = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslChuaDuyet = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTuChoiClr = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTuChoi = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grThongTin = new System.Windows.Forms.GroupBox();
            this.cboDenGio = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboTuGio = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bteQuanHuyen = new DevExpress.XtraEditors.ButtonEdit();
            this.label18 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lueNganh = new DevExpress.XtraEditors.LookUpEdit();
            this.lblNganh = new DevExpress.XtraEditors.LabelControl();
            this.lueDraft = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lueLoaiDH = new DevExpress.XtraEditors.LookUpEdit();
            this.lblTrangThaiLinhKien = new DevExpress.XtraEditors.LabelControl();
            this.lueTrangThaiDH = new DevExpress.XtraEditors.LookUpEdit();
            this.lblTrangThaiDH = new DevExpress.XtraEditors.LabelControl();
            this.bteKhachHang = new DevExpress.XtraEditors.ButtonEdit();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.dteEnd = new DevExpress.XtraEditors.DateEdit();
            this.dteStart = new DevExpress.XtraEditors.DateEdit();
            this.lblEnd = new DevExpress.XtraEditors.LabelControl();
            this.lblStart = new DevExpress.XtraEditors.LabelControl();
            this.bteKhoXuat = new DevExpress.XtraEditors.ButtonEdit();
            this.bteTrungTam = new DevExpress.XtraEditors.ButtonEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoPhieu = new QLBH.Core.Form.GtidTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gListChungTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListChungTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repMEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDraft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repGiaoNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrangThaiDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.grpKetQuaTimKiem.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboDenGio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTuGio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteQuanHuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNganh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDraft.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLoaiDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTrangThaiDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhoXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gListChungTu
            // 
            this.gListChungTu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gListChungTu.ContextMenuStrip = this.ctxMenu;
            this.gListChungTu.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gListChungTu.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gListChungTu.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gListChungTu.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gListChungTu.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gListChungTu.EmbeddedNavigator.TextStringFormat = "Đơn hàng số {0} / Tổng số {1} đơn hàng";
            this.gListChungTu.Location = new System.Drawing.Point(6, 14);
            this.gListChungTu.MainView = this.gvListChungTu;
            this.gListChungTu.Name = "gListChungTu";
            this.gListChungTu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repEdit,
            this.repLoaiDonHang,
            this.repDraft,
            this.repTrangThaiDH,
            this.repMEdit,
            this.repGiaoNhan});
            this.gListChungTu.Size = new System.Drawing.Size(1197, 355);
            this.gListChungTu.TabIndex = 0;
            this.gListChungTu.UseEmbeddedNavigator = true;
            this.gListChungTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListChungTu});
            this.gListChungTu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gListChungTu_KeyDown);
            // 
            // ctxMenu
            // 
            this.ctxMenu.Name = "contextMenuStrip1";
            this.ctxMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // gvListChungTu
            // 
            this.gvListChungTu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTrungTam,
            this.colTenDoiTuong,
            this.colKho,
            this.colLoaiDonHang,
            this.colNgayLap,
            this.colSoGiaoDich,
            this.colNgayGiaoHang,
            this.GioHenGiaoHang,
            this.colNoiGiao,
            this.QuanHuyen,
            this.SoChungTuGoc,
            this.colSoHoaDon,
            this.NgayHoaDon,
            this.SoPhieuDC,
            this.colSoPhieuXuat,
            this.colNgayXuat,
            this.colSanPhamBan,
            this.colGhiChuGN,
            this.colDienThoai,
            this.colSoTien,
            this.colTienThucTra,
            this.colTienCoNo,
            this.colTenNhanVien,
            this.colNguoiTao,
            this.colNguoiSua,
            this.colGhiChu,
            this.colGiaoNhan,
            this.colTrangThai});
            this.gvListChungTu.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvListChungTu.GridControl = this.gListChungTu;
            this.gvListChungTu.GroupCount = 2;
            this.gvListChungTu.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "SoChungTu", null, "  (Số đơn  = {0})")});
            this.gvListChungTu.Name = "gvListChungTu";
            this.gvListChungTu.OptionsView.ColumnAutoWidth = false;
            this.gvListChungTu.OptionsView.ShowAutoFilterRow = true;
            this.gvListChungTu.OptionsView.ShowDetailButtons = false;
            this.gvListChungTu.OptionsView.ShowFooter = true;
            this.gvListChungTu.OptionsView.ShowGroupedColumns = true;
            this.gvListChungTu.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTrungTam, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTenDoiTuong, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colKho, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvListChungTu.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvListChungTu_FocusedRowChanged);
            this.gvListChungTu.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvListChungTu_RowCellStyle);
            this.gvListChungTu.DoubleClick += new System.EventHandler(this.gvListChungTu_DoubleClick);
            // 
            // colTrungTam
            // 
            this.colTrungTam.Caption = "Trung tâm";
            this.colTrungTam.FieldName = "TenTrungTam";
            this.colTrungTam.Name = "colTrungTam";
            this.colTrungTam.OptionsColumn.AllowEdit = false;
            this.colTrungTam.OptionsColumn.AllowFocus = false;
            this.colTrungTam.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTrungTam.OptionsColumn.ReadOnly = true;
            // 
            // colTenDoiTuong
            // 
            this.colTenDoiTuong.Caption = "Khách hàng";
            this.colTenDoiTuong.FieldName = "TenDoiTuong";
            this.colTenDoiTuong.Name = "colTenDoiTuong";
            this.colTenDoiTuong.OptionsColumn.AllowEdit = false;
            this.colTenDoiTuong.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colKho
            // 
            this.colKho.AppearanceCell.Options.UseTextOptions = true;
            this.colKho.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colKho.Caption = "Kho hàng";
            this.colKho.FieldName = "TenKho";
            this.colKho.Name = "colKho";
            this.colKho.OptionsColumn.AllowEdit = false;
            this.colKho.OptionsColumn.AllowFocus = false;
            this.colKho.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colKho.OptionsColumn.ReadOnly = true;
            this.colKho.Visible = true;
            this.colKho.VisibleIndex = 2;
            this.colKho.Width = 237;
            // 
            // colLoaiDonHang
            // 
            this.colLoaiDonHang.Caption = "Loại đơn hàng";
            this.colLoaiDonHang.ColumnEdit = this.repLoaiDonHang;
            this.colLoaiDonHang.FieldName = "LoaiChungTu";
            this.colLoaiDonHang.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colLoaiDonHang.Name = "colLoaiDonHang";
            this.colLoaiDonHang.OptionsColumn.AllowEdit = false;
            this.colLoaiDonHang.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colLoaiDonHang.Visible = true;
            this.colLoaiDonHang.VisibleIndex = 1;
            this.colLoaiDonHang.Width = 154;
            // 
            // repLoaiDonHang
            // 
            this.repLoaiDonHang.AutoHeight = false;
            this.repLoaiDonHang.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLoaiDonHang.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.repLoaiDonHang.DisplayMember = "Name";
            this.repLoaiDonHang.Name = "repLoaiDonHang";
            this.repLoaiDonHang.ValueMember = "Id";
            // 
            // colNgayLap
            // 
            this.colNgayLap.Caption = "Ngày lập";
            this.colNgayLap.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colNgayLap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayLap.FieldName = "NgayLap";
            this.colNgayLap.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colNgayLap.Name = "colNgayLap";
            this.colNgayLap.OptionsColumn.AllowEdit = false;
            this.colNgayLap.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNgayLap.Visible = true;
            this.colNgayLap.VisibleIndex = 0;
            this.colNgayLap.Width = 113;
            // 
            // colSoGiaoDich
            // 
            this.colSoGiaoDich.Caption = "Số giao dịch";
            this.colSoGiaoDich.FieldName = "SoChungTu";
            this.colSoGiaoDich.Name = "colSoGiaoDich";
            this.colSoGiaoDich.OptionsColumn.AllowFocus = false;
            this.colSoGiaoDich.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSoGiaoDich.OptionsColumn.ReadOnly = true;
            this.colSoGiaoDich.SummaryItem.DisplayFormat = "Số đơn = {0:N0}";
            this.colSoGiaoDich.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.colSoGiaoDich.Visible = true;
            this.colSoGiaoDich.VisibleIndex = 3;
            this.colSoGiaoDich.Width = 113;
            // 
            // colNgayGiaoHang
            // 
            this.colNgayGiaoHang.Caption = "Ngày hẹn giao hàng";
            this.colNgayGiaoHang.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colNgayGiaoHang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayGiaoHang.FieldName = "NgayHenGiaoHang";
            this.colNgayGiaoHang.Name = "colNgayGiaoHang";
            this.colNgayGiaoHang.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNgayGiaoHang.OptionsColumn.ReadOnly = true;
            this.colNgayGiaoHang.Visible = true;
            this.colNgayGiaoHang.VisibleIndex = 4;
            this.colNgayGiaoHang.Width = 118;
            // 
            // GioHenGiaoHang
            // 
            this.GioHenGiaoHang.Caption = "Giờ hẹn giao";
            this.GioHenGiaoHang.FieldName = "GioGiaoHang";
            this.GioHenGiaoHang.Name = "GioHenGiaoHang";
            this.GioHenGiaoHang.OptionsColumn.AllowEdit = false;
            this.GioHenGiaoHang.Visible = true;
            this.GioHenGiaoHang.VisibleIndex = 5;
            this.GioHenGiaoHang.Width = 84;
            // 
            // colNoiGiao
            // 
            this.colNoiGiao.Caption = "Địa chỉ";
            this.colNoiGiao.FieldName = "DiaChiGiaoHang";
            this.colNoiGiao.Name = "colNoiGiao";
            this.colNoiGiao.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNoiGiao.OptionsColumn.ReadOnly = true;
            this.colNoiGiao.Visible = true;
            this.colNoiGiao.VisibleIndex = 6;
            this.colNoiGiao.Width = 238;
            // 
            // QuanHuyen
            // 
            this.QuanHuyen.Caption = "Quận/Huyện";
            this.QuanHuyen.FieldName = "QuanHuyen";
            this.QuanHuyen.Name = "QuanHuyen";
            this.QuanHuyen.OptionsColumn.ReadOnly = true;
            this.QuanHuyen.Visible = true;
            this.QuanHuyen.VisibleIndex = 7;
            this.QuanHuyen.Width = 117;
            // 
            // SoChungTuGoc
            // 
            this.SoChungTuGoc.Caption = "Số chứng từ gốc";
            this.SoChungTuGoc.FieldName = "SoChungTuGoc";
            this.SoChungTuGoc.Name = "SoChungTuGoc";
            this.SoChungTuGoc.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.SoChungTuGoc.OptionsColumn.ReadOnly = true;
            this.SoChungTuGoc.Visible = true;
            this.SoChungTuGoc.VisibleIndex = 8;
            this.SoChungTuGoc.Width = 117;
            // 
            // colSoHoaDon
            // 
            this.colSoHoaDon.Caption = "Số hóa đơn";
            this.colSoHoaDon.FieldName = "SoSeri";
            this.colSoHoaDon.Name = "colSoHoaDon";
            this.colSoHoaDon.OptionsColumn.AllowFocus = false;
            this.colSoHoaDon.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSoHoaDon.OptionsColumn.ReadOnly = true;
            this.colSoHoaDon.Visible = true;
            this.colSoHoaDon.VisibleIndex = 9;
            this.colSoHoaDon.Width = 104;
            // 
            // NgayHoaDon
            // 
            this.NgayHoaDon.Caption = "Ngày hóa đơn";
            this.NgayHoaDon.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.NgayHoaDon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgayHoaDon.FieldName = "NgayHoaDon";
            this.NgayHoaDon.Name = "NgayHoaDon";
            this.NgayHoaDon.OptionsColumn.AllowEdit = false;
            this.NgayHoaDon.Visible = true;
            this.NgayHoaDon.VisibleIndex = 10;
            this.NgayHoaDon.Width = 110;
            // 
            // SoPhieuDC
            // 
            this.SoPhieuDC.Caption = "Số phiếu DC";
            this.SoPhieuDC.FieldName = "SoPhieuDC";
            this.SoPhieuDC.Name = "SoPhieuDC";
            this.SoPhieuDC.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.SoPhieuDC.OptionsColumn.ReadOnly = true;
            this.SoPhieuDC.Visible = true;
            this.SoPhieuDC.VisibleIndex = 11;
            this.SoPhieuDC.Width = 121;
            // 
            // colSoPhieuXuat
            // 
            this.colSoPhieuXuat.Caption = "Số phiếu xuất";
            this.colSoPhieuXuat.DisplayFormat.FormatString = "dd/mm/yyyy";
            this.colSoPhieuXuat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSoPhieuXuat.FieldName = "SoPhieuXuat";
            this.colSoPhieuXuat.Name = "colSoPhieuXuat";
            this.colSoPhieuXuat.OptionsColumn.AllowFocus = false;
            this.colSoPhieuXuat.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSoPhieuXuat.OptionsColumn.ReadOnly = true;
            this.colSoPhieuXuat.Width = 129;
            // 
            // colNgayXuat
            // 
            this.colNgayXuat.Caption = "Ngày xuất";
            this.colNgayXuat.FieldName = "NgayXuatHang";
            this.colNgayXuat.Name = "colNgayXuat";
            this.colNgayXuat.OptionsColumn.AllowEdit = false;
            this.colNgayXuat.OptionsColumn.AllowFocus = false;
            this.colNgayXuat.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNgayXuat.OptionsColumn.ReadOnly = true;
            this.colNgayXuat.Width = 121;
            // 
            // colSanPhamBan
            // 
            this.colSanPhamBan.Caption = "Sản phẩm bán";
            this.colSanPhamBan.ColumnEdit = this.repMEdit;
            this.colSanPhamBan.FieldName = "SanPhamBan";
            this.colSanPhamBan.Name = "colSanPhamBan";
            this.colSanPhamBan.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSanPhamBan.OptionsColumn.ReadOnly = true;
            this.colSanPhamBan.Visible = true;
            this.colSanPhamBan.VisibleIndex = 12;
            this.colSanPhamBan.Width = 267;
            // 
            // repMEdit
            // 
            this.repMEdit.Name = "repMEdit";
            // 
            // colGhiChuGN
            // 
            this.colGhiChuGN.Caption = "Ghi chú";
            this.colGhiChuGN.ColumnEdit = this.repMEdit;
            this.colGhiChuGN.FieldName = "GhiChu";
            this.colGhiChuGN.Name = "colGhiChuGN";
            this.colGhiChuGN.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colGhiChuGN.OptionsColumn.ReadOnly = true;
            this.colGhiChuGN.Visible = true;
            this.colGhiChuGN.VisibleIndex = 13;
            this.colGhiChuGN.Width = 253;
            // 
            // colDienThoai
            // 
            this.colDienThoai.Caption = "Điện thoại KH";
            this.colDienThoai.FieldName = "DienThoai";
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colDienThoai.OptionsColumn.ReadOnly = true;
            this.colDienThoai.Visible = true;
            this.colDienThoai.VisibleIndex = 14;
            this.colDienThoai.Width = 124;
            // 
            // colSoTien
            // 
            this.colSoTien.Caption = "Số tiền";
            this.colSoTien.DisplayFormat.FormatString = "N0";
            this.colSoTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoTien.FieldName = "TongTienThanhToan";
            this.colSoTien.Name = "colSoTien";
            this.colSoTien.OptionsColumn.AllowEdit = false;
            this.colSoTien.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSoTien.SummaryItem.DisplayFormat = "Numeric \"N0\"";
            this.colSoTien.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSoTien.Visible = true;
            this.colSoTien.VisibleIndex = 15;
            this.colSoTien.Width = 109;
            // 
            // colTienThucTra
            // 
            this.colTienThucTra.Caption = "Đã trả";
            this.colTienThucTra.DisplayFormat.FormatString = "N0";
            this.colTienThucTra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTienThucTra.FieldName = "TienThanhToanThuc";
            this.colTienThucTra.Name = "colTienThucTra";
            this.colTienThucTra.OptionsColumn.AllowEdit = false;
            this.colTienThucTra.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTienThucTra.SummaryItem.DisplayFormat = "Numeric \"N0\"";
            this.colTienThucTra.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTienThucTra.Visible = true;
            this.colTienThucTra.VisibleIndex = 16;
            this.colTienThucTra.Width = 94;
            // 
            // colTienCoNo
            // 
            this.colTienCoNo.Caption = "Còn nợ";
            this.colTienCoNo.DisplayFormat.FormatString = "N0";
            this.colTienCoNo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTienCoNo.FieldName = "TienConNo";
            this.colTienCoNo.Name = "colTienCoNo";
            this.colTienCoNo.OptionsColumn.AllowEdit = false;
            this.colTienCoNo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTienCoNo.SummaryItem.DisplayFormat = "Numeric \"N0\"";
            this.colTienCoNo.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTienCoNo.Visible = true;
            this.colTienCoNo.VisibleIndex = 17;
            this.colTienCoNo.Width = 100;
            // 
            // colTenNhanVien
            // 
            this.colTenNhanVien.Caption = "Thương viên";
            this.colTenNhanVien.FieldName = "TenNhanVien";
            this.colTenNhanVien.Name = "colTenNhanVien";
            this.colTenNhanVien.OptionsColumn.AllowEdit = false;
            this.colTenNhanVien.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTenNhanVien.Visible = true;
            this.colTenNhanVien.VisibleIndex = 18;
            this.colTenNhanVien.Width = 143;
            // 
            // colNguoiTao
            // 
            this.colNguoiTao.Caption = "Người tạo";
            this.colNguoiTao.FieldName = "NguoiTao";
            this.colNguoiTao.Name = "colNguoiTao";
            this.colNguoiTao.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNguoiTao.Visible = true;
            this.colNguoiTao.VisibleIndex = 19;
            this.colNguoiTao.Width = 105;
            // 
            // colNguoiSua
            // 
            this.colNguoiSua.Caption = "Người sửa cuối";
            this.colNguoiSua.FieldName = "NguoiSua";
            this.colNguoiSua.Name = "colNguoiSua";
            this.colNguoiSua.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNguoiSua.Visible = true;
            this.colNguoiSua.VisibleIndex = 20;
            this.colNguoiSua.Width = 108;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Bản nháp";
            this.colGhiChu.ColumnEdit = this.repDraft;
            this.colGhiChu.FieldName = "Draft";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.OptionsColumn.AllowEdit = false;
            this.colGhiChu.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 21;
            this.colGhiChu.Width = 91;
            // 
            // repDraft
            // 
            this.repDraft.AutoHeight = false;
            this.repDraft.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repDraft.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.repDraft.DisplayMember = "Name";
            this.repDraft.Name = "repDraft";
            this.repDraft.ValueMember = "Id";
            // 
            // colGiaoNhan
            // 
            this.colGiaoNhan.Caption = "Nơi giao nhận";
            this.colGiaoNhan.ColumnEdit = this.repGiaoNhan;
            this.colGiaoNhan.FieldName = "GiaoNhan";
            this.colGiaoNhan.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colGiaoNhan.Name = "colGiaoNhan";
            this.colGiaoNhan.OptionsColumn.AllowEdit = false;
            this.colGiaoNhan.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colGiaoNhan.Visible = true;
            this.colGiaoNhan.VisibleIndex = 22;
            this.colGiaoNhan.Width = 116;
            // 
            // repGiaoNhan
            // 
            this.repGiaoNhan.AutoHeight = false;
            this.repGiaoNhan.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repGiaoNhan.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.repGiaoNhan.DisplayMember = "Name";
            this.repGiaoNhan.Name = "repGiaoNhan";
            this.repGiaoNhan.ValueMember = "Id";
            // 
            // colTrangThai
            // 
            this.colTrangThai.AppearanceCell.Options.UseTextOptions = true;
            this.colTrangThai.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTrangThai.Caption = "Trạng thái đơn hàng";
            this.colTrangThai.ColumnEdit = this.repTrangThaiDH;
            this.colTrangThai.FieldName = "TrangThai";
            this.colTrangThai.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.OptionsColumn.AllowEdit = false;
            this.colTrangThai.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTrangThai.Visible = true;
            this.colTrangThai.VisibleIndex = 23;
            this.colTrangThai.Width = 144;
            // 
            // repTrangThaiDH
            // 
            this.repTrangThaiDH.AutoHeight = false;
            this.repTrangThaiDH.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repTrangThaiDH.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.repTrangThaiDH.DisplayMember = "Name";
            this.repTrangThaiDH.Name = "repTrangThaiDH";
            this.repTrangThaiDH.ValueMember = "Id";
            // 
            // repEdit
            // 
            this.repEdit.AutoHeight = false;
            this.repEdit.Name = "repEdit";
            this.repEdit.ValueChecked = 1;
            this.repEdit.ValueUnchecked = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbEdit,
            this.tsbDelete,
            this.toolStripSeparator3,
            this.tsbPrint,
            this.toolStripSeparator4,
            this.tsbTimKiem,
            this.toolStripSeparator6,
            this.tsbExport,
            this.toolStripSeparator2,
            this.tsbSession,
            this.toolStripSeparator5,
            this.tsbClose,
            this.toolStripSeparator1,
            this.tslInfor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1209, 25);
            this.toolStrip1.TabIndex = 87;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(94, 22);
            this.tsbAdd.Text = "Tạo &mới (F5)";
            this.tsbAdd.ToolTipText = "Làm mới (F5)";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(107, 22);
            this.tsbEdit.Text = "&Phân công (F6)";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(72, 22);
            this.tsbDelete.Text = "&Hủy (F8)";
            this.tsbDelete.Visible = false;
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator3.Visible = false;
            // 
            // tsbPrint
            // 
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(149, 22);
            this.tsbPrint.Text = "&In phiếu giao nhận (F9)";
            this.tsbPrint.Click += new System.EventHandler(this.tsbPrint_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbTimKiem
            // 
            this.tsbTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("tsbTimKiem.Image")));
            this.tsbTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTimKiem.Name = "tsbTimKiem";
            this.tsbTimKiem.Size = new System.Drawing.Size(100, 22);
            this.tsbTimKiem.Text = "&Tìm kiếm (F3)";
            this.tsbTimKiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbExport
            // 
            this.tsbExport.Image = ((System.Drawing.Image)(resources.GetObject("tsbExport.Image")));
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(137, 22);
            this.tsbExport.Text = "Kết xuất báo cáo (F2)";
            this.tsbExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSession
            // 
            this.tsbSession.Image = ((System.Drawing.Image)(resources.GetObject("tsbSession.Image")));
            this.tsbSession.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSession.Name = "tsbSession";
            this.tsbSession.Size = new System.Drawing.Size(117, 22);
            this.tsbSession.Text = "Ca làm việc (F11)";
            this.tsbSession.Click += new System.EventHandler(this.tsbSession_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbClose
            // 
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(85, 22);
            this.tsbClose.Text = "Đ&óng (F12)";
            this.tsbClose.ToolTipText = "Đóng (F12)";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tslInfor
            // 
            this.tslInfor.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslInfor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslInfor.Name = "tslInfor";
            this.tslInfor.Size = new System.Drawing.Size(124, 22);
            this.tslInfor.Text = "Danh sách đơn hàng";
            // 
            // grpKetQuaTimKiem
            // 
            this.grpKetQuaTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKetQuaTimKiem.Controls.Add(this.btnNext);
            this.grpKetQuaTimKiem.Controls.Add(this.cboPage);
            this.grpKetQuaTimKiem.Controls.Add(this.gListChungTu);
            this.grpKetQuaTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKetQuaTimKiem.ForeColor = System.Drawing.Color.Black;
            this.grpKetQuaTimKiem.Location = new System.Drawing.Point(0, 132);
            this.grpKetQuaTimKiem.Name = "grpKetQuaTimKiem";
            this.grpKetQuaTimKiem.Size = new System.Drawing.Size(1209, 375);
            this.grpKetQuaTimKiem.TabIndex = 1;
            this.grpKetQuaTimKiem.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(1049, 26);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnNext.Size = new System.Drawing.Size(121, 22);
            this.btnNext.TabIndex = 152;
            this.btnNext.Text = "Kết quả tiếp theo";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cboPage
            // 
            this.cboPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.cboPage.Location = new System.Drawing.Point(997, 26);
            this.cboPage.Name = "cboPage";
            this.cboPage.Size = new System.Drawing.Size(50, 21);
            this.cboPage.TabIndex = 151;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslHuyClr,
            this.tsslHuy,
            this.tsslChuaDuyetClr,
            this.tsslChuaDuyet,
            this.tsslTuChoiClr,
            this.tsslTuChoi,
            this.toolStripStatusLabel7,
            this.tsslTrangThai});
            this.statusStrip1.Location = new System.Drawing.Point(0, 508);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(1209, 24);
            this.statusStrip1.TabIndex = 107;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslHuyClr
            // 
            this.tsslHuyClr.BackColor = System.Drawing.Color.Red;
            this.tsslHuyClr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tsslHuyClr.Name = "tsslHuyClr";
            this.tsslHuyClr.Size = new System.Drawing.Size(19, 19);
            this.tsslHuyClr.Text = "    ";
            // 
            // tsslHuy
            // 
            this.tsslHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tsslHuy.Name = "tsslHuy";
            this.tsslHuy.Size = new System.Drawing.Size(62, 19);
            this.tsslHuy.Text = "Hủy phiếu";
            // 
            // tsslChuaDuyetClr
            // 
            this.tsslChuaDuyetClr.BackColor = System.Drawing.Color.Blue;
            this.tsslChuaDuyetClr.ForeColor = System.Drawing.Color.White;
            this.tsslChuaDuyetClr.Name = "tsslChuaDuyetClr";
            this.tsslChuaDuyetClr.Size = new System.Drawing.Size(19, 19);
            this.tsslChuaDuyetClr.Text = "    ";
            // 
            // tsslChuaDuyet
            // 
            this.tsslChuaDuyet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tsslChuaDuyet.Name = "tsslChuaDuyet";
            this.tsslChuaDuyet.Size = new System.Drawing.Size(68, 19);
            this.tsslChuaDuyet.Text = "Chưa duyệt";
            // 
            // tsslTuChoiClr
            // 
            this.tsslTuChoiClr.BackColor = System.Drawing.Color.Yellow;
            this.tsslTuChoiClr.Name = "tsslTuChoiClr";
            this.tsslTuChoiClr.Size = new System.Drawing.Size(19, 19);
            this.tsslTuChoiClr.Text = "    ";
            // 
            // tsslTuChoi
            // 
            this.tsslTuChoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tsslTuChoi.Name = "tsslTuChoi";
            this.tsslTuChoi.Size = new System.Drawing.Size(47, 19);
            this.tsslTuChoi.Text = "Từ chối";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripStatusLabel7.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel7.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(23, 19);
            this.toolStripStatusLabel7.Text = "    ";
            // 
            // tsslTrangThai
            // 
            this.tsslTrangThai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tsslTrangThai.Name = "tsslTrangThai";
            this.tsslTrangThai.Size = new System.Drawing.Size(0, 19);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grThongTin
            // 
            this.grThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grThongTin.Controls.Add(this.cboDenGio);
            this.grThongTin.Controls.Add(this.cboTuGio);
            this.grThongTin.Controls.Add(this.label4);
            this.grThongTin.Controls.Add(this.label3);
            this.grThongTin.Controls.Add(this.bteQuanHuyen);
            this.grThongTin.Controls.Add(this.label18);
            this.grThongTin.Controls.Add(this.label2);
            this.grThongTin.Controls.Add(this.lueNganh);
            this.grThongTin.Controls.Add(this.lblNganh);
            this.grThongTin.Controls.Add(this.lueDraft);
            this.grThongTin.Controls.Add(this.labelControl1);
            this.grThongTin.Controls.Add(this.lueLoaiDH);
            this.grThongTin.Controls.Add(this.lblTrangThaiLinhKien);
            this.grThongTin.Controls.Add(this.lueTrangThaiDH);
            this.grThongTin.Controls.Add(this.lblTrangThaiDH);
            this.grThongTin.Controls.Add(this.bteKhachHang);
            this.grThongTin.Controls.Add(this.lblKhachHang);
            this.grThongTin.Controls.Add(this.dteEnd);
            this.grThongTin.Controls.Add(this.dteStart);
            this.grThongTin.Controls.Add(this.lblEnd);
            this.grThongTin.Controls.Add(this.lblStart);
            this.grThongTin.Controls.Add(this.bteKhoXuat);
            this.grThongTin.Controls.Add(this.bteTrungTam);
            this.grThongTin.Controls.Add(this.label7);
            this.grThongTin.Controls.Add(this.label1);
            this.grThongTin.Controls.Add(this.txtSoPhieu);
            this.grThongTin.Location = new System.Drawing.Point(0, 28);
            this.grThongTin.Name = "grThongTin";
            this.grThongTin.Size = new System.Drawing.Size(1209, 98);
            this.grThongTin.TabIndex = 108;
            this.grThongTin.TabStop = false;
            // 
            // cboDenGio
            // 
            this.cboDenGio.Location = new System.Drawing.Point(957, 16);
            this.cboDenGio.Name = "cboDenGio";
            this.cboDenGio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDenGio.Properties.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cboDenGio.Size = new System.Drawing.Size(45, 20);
            this.cboDenGio.TabIndex = 158;
            // 
            // cboTuGio
            // 
            this.cboTuGio.Location = new System.Drawing.Point(875, 16);
            this.cboTuGio.Name = "cboTuGio";
            this.cboTuGio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTuGio.Properties.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cboTuGio.Size = new System.Drawing.Size(45, 20);
            this.cboTuGio.TabIndex = 157;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label4.Location = new System.Drawing.Point(918, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 154;
            this.label4.Text = "đến giờ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label3.Location = new System.Drawing.Point(835, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 151;
            this.label3.Text = "Từ giờ";
            // 
            // bteQuanHuyen
            // 
            this.bteQuanHuyen.Location = new System.Drawing.Point(875, 41);
            this.bteQuanHuyen.Name = "bteQuanHuyen";
            this.bteQuanHuyen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteQuanHuyen.Size = new System.Drawing.Size(322, 20);
            this.bteQuanHuyen.TabIndex = 148;
            this.bteQuanHuyen.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteQuanHuyen_ButtonClick);
            this.bteQuanHuyen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteQuanHuyen_KeyDown);
            this.bteQuanHuyen.TextChanged += new System.EventHandler(this.bteQuanHuyen_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label18.Location = new System.Drawing.Point(804, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 13);
            this.label18.TabIndex = 149;
            this.label18.Text = "Quận/Huyện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label2.Location = new System.Drawing.Point(1012, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 147;
            this.label2.Text = "Số phiếu";
            // 
            // lueNganh
            // 
            this.lueNganh.Location = new System.Drawing.Point(875, 68);
            this.lueNganh.Name = "lueNganh";
            this.lueNganh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueNganh.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Ten")});
            this.lueNganh.Properties.DisplayMember = "Ten";
            this.lueNganh.Properties.NullText = "";
            this.lueNganh.Properties.ValueMember = "Ma";
            this.lueNganh.Size = new System.Drawing.Size(322, 20);
            this.lueNganh.TabIndex = 146;
            // 
            // lblNganh
            // 
            this.lblNganh.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNganh.Appearance.Options.UseFont = true;
            this.lblNganh.Location = new System.Drawing.Point(814, 71);
            this.lblNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblNganh.Name = "lblNganh";
            this.lblNganh.Size = new System.Drawing.Size(58, 13);
            this.lblNganh.TabIndex = 145;
            this.lblNganh.Text = "Ngành hàng";
            // 
            // lueDraft
            // 
            this.lueDraft.Location = new System.Drawing.Point(662, 41);
            this.lueDraft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lueDraft.Name = "lueDraft";
            this.lueDraft.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lueDraft.Properties.Appearance.Options.UseFont = true;
            this.lueDraft.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDraft.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.lueDraft.Properties.DisplayMember = "Name";
            this.lueDraft.Properties.NullText = "";
            this.lueDraft.Properties.ShowFooter = false;
            this.lueDraft.Properties.ShowHeader = false;
            this.lueDraft.Properties.ValueMember = "Id";
            this.lueDraft.Size = new System.Drawing.Size(130, 20);
            this.lueDraft.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(615, 44);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 139;
            this.labelControl1.Text = "Xác nhận";
            // 
            // lueLoaiDH
            // 
            this.lueLoaiDH.Location = new System.Drawing.Point(482, 41);
            this.lueLoaiDH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lueLoaiDH.Name = "lueLoaiDH";
            this.lueLoaiDH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lueLoaiDH.Properties.Appearance.Options.UseFont = true;
            this.lueLoaiDH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueLoaiDH.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.lueLoaiDH.Properties.DisplayMember = "Name";
            this.lueLoaiDH.Properties.NullText = "";
            this.lueLoaiDH.Properties.ShowFooter = false;
            this.lueLoaiDH.Properties.ShowHeader = false;
            this.lueLoaiDH.Properties.ValueMember = "Id";
            this.lueLoaiDH.Size = new System.Drawing.Size(130, 20);
            this.lueLoaiDH.TabIndex = 5;
            // 
            // lblTrangThaiLinhKien
            // 
            this.lblTrangThaiLinhKien.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTrangThaiLinhKien.Appearance.Options.UseFont = true;
            this.lblTrangThaiLinhKien.Location = new System.Drawing.Point(406, 44);
            this.lblTrangThaiLinhKien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTrangThaiLinhKien.Name = "lblTrangThaiLinhKien";
            this.lblTrangThaiLinhKien.Size = new System.Drawing.Size(67, 13);
            this.lblTrangThaiLinhKien.TabIndex = 137;
            this.lblTrangThaiLinhKien.Text = "Loại đơn hàng";
            // 
            // lueTrangThaiDH
            // 
            this.lueTrangThaiDH.Location = new System.Drawing.Point(482, 68);
            this.lueTrangThaiDH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lueTrangThaiDH.Name = "lueTrangThaiDH";
            this.lueTrangThaiDH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lueTrangThaiDH.Properties.Appearance.Options.UseFont = true;
            this.lueTrangThaiDH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTrangThaiDH.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.lueTrangThaiDH.Properties.DisplayMember = "Name";
            this.lueTrangThaiDH.Properties.NullText = "";
            this.lueTrangThaiDH.Properties.ShowFooter = false;
            this.lueTrangThaiDH.Properties.ShowHeader = false;
            this.lueTrangThaiDH.Properties.ValueMember = "Id";
            this.lueTrangThaiDH.Size = new System.Drawing.Size(310, 20);
            this.lueTrangThaiDH.TabIndex = 7;
            // 
            // lblTrangThaiDH
            // 
            this.lblTrangThaiDH.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTrangThaiDH.Appearance.Options.UseFont = true;
            this.lblTrangThaiDH.Location = new System.Drawing.Point(406, 71);
            this.lblTrangThaiDH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTrangThaiDH.Name = "lblTrangThaiDH";
            this.lblTrangThaiDH.Size = new System.Drawing.Size(67, 13);
            this.lblTrangThaiDH.TabIndex = 135;
            this.lblTrangThaiDH.Text = "Trạng thái ĐH";
            // 
            // bteKhachHang
            // 
            this.bteKhachHang.Location = new System.Drawing.Point(86, 68);
            this.bteKhachHang.Name = "bteKhachHang";
            this.bteKhachHang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteKhachHang.Properties.Appearance.Options.UseFont = true;
            this.bteKhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteKhachHang.Size = new System.Drawing.Size(310, 22);
            this.bteKhachHang.TabIndex = 2;
            this.bteKhachHang.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteKhachHang_ButtonClick);
            this.bteKhachHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteKhachHang_KeyDown);
            this.bteKhachHang.TextChanged += new System.EventHandler(this.bteKhachHang_TextChanged);
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHang.Location = new System.Drawing.Point(15, 71);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(65, 13);
            this.lblKhachHang.TabIndex = 132;
            this.lblKhachHang.Text = "Khách hàng";
            // 
            // dteEnd
            // 
            this.dteEnd.EditValue = null;
            this.dteEnd.Location = new System.Drawing.Point(662, 14);
            this.dteEnd.Name = "dteEnd";
            this.dteEnd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dteEnd.Properties.Appearance.Options.UseFont = true;
            this.dteEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteEnd.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dteEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteEnd.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dteEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteEnd.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteEnd.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dteEnd.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteEnd.Size = new System.Drawing.Size(130, 20);
            this.dteEnd.TabIndex = 4;
            // 
            // dteStart
            // 
            this.dteStart.EditValue = null;
            this.dteStart.Location = new System.Drawing.Point(482, 14);
            this.dteStart.Name = "dteStart";
            this.dteStart.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dteStart.Properties.Appearance.Options.UseFont = true;
            this.dteStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteStart.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dteStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteStart.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dteStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteStart.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteStart.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dteStart.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteStart.Size = new System.Drawing.Size(130, 20);
            this.dteStart.TabIndex = 3;
            // 
            // lblEnd
            // 
            this.lblEnd.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEnd.Appearance.Options.UseFont = true;
            this.lblEnd.Location = new System.Drawing.Point(615, 17);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(45, 13);
            this.lblEnd.TabIndex = 131;
            this.lblEnd.Text = "đến ngày";
            // 
            // lblStart
            // 
            this.lblStart.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStart.Appearance.Options.UseFont = true;
            this.lblStart.Location = new System.Drawing.Point(433, 17);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(40, 13);
            this.lblStart.TabIndex = 130;
            this.lblStart.Text = "Từ ngày";
            // 
            // bteKhoXuat
            // 
            this.bteKhoXuat.Location = new System.Drawing.Point(86, 41);
            this.bteKhoXuat.Name = "bteKhoXuat";
            this.bteKhoXuat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteKhoXuat.Properties.Appearance.Options.UseFont = true;
            this.bteKhoXuat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteKhoXuat.Size = new System.Drawing.Size(310, 22);
            this.bteKhoXuat.TabIndex = 1;
            this.bteKhoXuat.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteKhoXuat_ButtonClick);
            this.bteKhoXuat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteKhoXuat_KeyDown);
            this.bteKhoXuat.TextChanged += new System.EventHandler(this.bteKhoXuat_TextChanged);
            // 
            // bteTrungTam
            // 
            this.bteTrungTam.Location = new System.Drawing.Point(86, 14);
            this.bteTrungTam.Name = "bteTrungTam";
            this.bteTrungTam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteTrungTam.Properties.Appearance.Options.UseFont = true;
            this.bteTrungTam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteTrungTam.Size = new System.Drawing.Size(310, 22);
            this.bteTrungTam.TabIndex = 0;
            this.bteTrungTam.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteTrungTam_ButtonClick);
            this.bteTrungTam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteTrungTam_KeyDown);
            this.bteTrungTam.TextChanged += new System.EventHandler(this.bteTrungTam_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 125;
            this.label7.Text = "Trung tâm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 123;
            this.label1.Text = "Kho xuất";
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtSoPhieu.Location = new System.Drawing.Point(1062, 14);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSoPhieu.Size = new System.Drawing.Size(135, 21);
            this.txtSoPhieu.TabIndex = 8;
            // 
            // frmBH_ListDonHangGiaoNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 532);
            this.Controls.Add(this.grThongTin);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grpKetQuaTimKiem);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmBH_ListDonHangGiaoNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân công giao nhận";
            this.Load += new System.EventHandler(this.frmBH_TimChungTu_Load);
            this.Activated += new System.EventHandler(this.frmBH_ListChungTuBase_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBH_TimChungTu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gListChungTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListChungTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repMEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDraft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repGiaoNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrangThaiDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpKetQuaTimKiem.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grThongTin.ResumeLayout(false);
            this.grThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboDenGio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTuGio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteQuanHuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNganh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDraft.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLoaiDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTrangThaiDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhoXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStripButton tsbAdd;
        public System.Windows.Forms.ToolStripButton tsbEdit;
        public System.Windows.Forms.ToolStripButton tsbDelete;
        public System.Windows.Forms.ToolStripButton tsbPrint;
        public System.Windows.Forms.ToolStripButton tsbSession;
        public DevExpress.XtraGrid.GridControl gListChungTu;
        public DevExpress.XtraGrid.Views.Grid.GridView gvListChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn colTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn colKho;
        private DevExpress.XtraGrid.Columns.GridColumn colSoGiaoDich;
        private DevExpress.XtraGrid.Columns.GridColumn colSoHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayLap;
        private DevExpress.XtraGrid.Columns.GridColumn colSoPhieuXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiDonHang;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTien;
        private DevExpress.XtraGrid.Columns.GridColumn colTienThucTra;
        private DevExpress.XtraGrid.Columns.GridColumn colTienCoNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDoiTuong;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaoNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayGiaoHang;
        private DevExpress.XtraGrid.Columns.GridColumn colNoiGiao;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslInfor;
        private System.Windows.Forms.GroupBox grpKetQuaTimKiem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslTrangThai;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhanVien;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLoaiDonHang;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repDraft;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repTrangThaiDH;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraGrid.Columns.GridColumn SoChungTuGoc;
        private DevExpress.XtraGrid.Columns.GridColumn SoPhieuDC;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoiTao;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoiSua;
        public System.Windows.Forms.ToolStripStatusLabel tsslHuyClr;
        public System.Windows.Forms.ToolStripStatusLabel tsslHuy;
        public System.Windows.Forms.ToolStripStatusLabel tsslChuaDuyetClr;
        public System.Windows.Forms.ToolStripStatusLabel tsslChuaDuyet;
        public System.Windows.Forms.ToolStripStatusLabel tsslTuChoiClr;
        public System.Windows.Forms.ToolStripStatusLabel tsslTuChoi;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        protected GtidButton btnNext;
        protected System.Windows.Forms.ComboBox cboPage;
        private System.Windows.Forms.GroupBox grThongTin;
        private DevExpress.XtraEditors.LookUpEdit lueNganh;
        private DevExpress.XtraEditors.LabelControl lblNganh;
        private DevExpress.XtraEditors.LookUpEdit lueDraft;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lueLoaiDH;
        private DevExpress.XtraEditors.LabelControl lblTrangThaiLinhKien;
        private DevExpress.XtraEditors.LookUpEdit lueTrangThaiDH;
        private DevExpress.XtraEditors.LabelControl lblTrangThaiDH;
        private DevExpress.XtraEditors.ButtonEdit bteKhachHang;
        private System.Windows.Forms.Label lblKhachHang;
        public DevExpress.XtraEditors.DateEdit dteEnd;
        public DevExpress.XtraEditors.DateEdit dteStart;
        private DevExpress.XtraEditors.LabelControl lblEnd;
        private DevExpress.XtraEditors.LabelControl lblStart;
        private DevExpress.XtraEditors.ButtonEdit bteKhoXuat;
        private DevExpress.XtraEditors.ButtonEdit bteTrungTam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private GtidTextBox txtSoPhieu;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn colSanPhamBan;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChuGN;
        private DevExpress.XtraGrid.Columns.GridColumn colDienThoai;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repMEdit;
        private DevExpress.XtraGrid.Columns.GridColumn NgayHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn GioHenGiaoHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.ButtonEdit bteQuanHuyen;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ToolStripButton tsbTimKiem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private DevExpress.XtraEditors.ComboBoxEdit cboDenGio;
        private DevExpress.XtraEditors.ComboBoxEdit cboTuGio;
        private DevExpress.XtraGrid.Columns.GridColumn QuanHuyen;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repGiaoNhan;
    }
}