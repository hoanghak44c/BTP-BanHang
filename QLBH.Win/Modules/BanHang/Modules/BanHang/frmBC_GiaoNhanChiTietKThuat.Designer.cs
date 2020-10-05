using QLBH.Core.Form;
namespace QLBanHang.Modules.BanHang
{
    partial class frmBC_GiaoNhanChiTietKThuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBC_GiaoNhanChiTietKThuat));
            this.grpKetQuaTimKiem = new System.Windows.Forms.GroupBox();
            this.gListChungTu = new DevExpress.XtraGrid.GridControl();
            this.gvListChungTu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NgayPhanCong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhanVienGiaoNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhanVienGiaoNhan2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhanVienGiaoNhan3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DoiTacGiaoNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhanVienDoiTac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoPhieuPhanCong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiDonHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLoaiDonHang = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colSoGiaoDich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SanPhamBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDoiTuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoiGiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayHenGiaoHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayGiaoHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoPhieuXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayGiaoXongHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Draft = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colNguoiTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoiSua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenQuanHuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VungMien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiCongViec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhuongTienGiaoNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BienSoXe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LaiXe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TinhTrangGiaoHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTinhTrangGN = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTrangThaiDH = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repDraft = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tsslHuyClr = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslHuy = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDaGiaoXong = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTuChoi = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDangGiaoHang = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslChuaPC = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDaPhanCong = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslNLaiClr = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslNLai = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboPhuongTienGN = new System.Windows.Forms.ComboBox();
            this.lblNganHangTT = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bteQuanHuyen = new DevExpress.XtraEditors.ButtonEdit();
            this.label18 = new System.Windows.Forms.Label();
            this.cboVungMienKhach = new System.Windows.Forms.ComboBox();
            this.bteDoiTac = new DevExpress.XtraEditors.ButtonEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.bteThuongVien = new DevExpress.XtraEditors.ButtonEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTrangThaiDH = new DevExpress.XtraEditors.LabelControl();
            this.cmdExport = new QLBH.Core.Form.GtidButton();
            this.btnDong = new QLBH.Core.Form.GtidButton();
            this.btnTim = new QLBH.Core.Form.GtidButton();
            this.dteEnd = new DevExpress.XtraEditors.DateEdit();
            this.dteStart = new DevExpress.XtraEditors.DateEdit();
            this.lblEnd = new DevExpress.XtraEditors.LabelControl();
            this.lblStart = new DevExpress.XtraEditors.LabelControl();
            this.lueTrangThaiDH = new DevExpress.XtraEditors.LookUpEdit();
            this.lueLoaiDH = new DevExpress.XtraEditors.LookUpEdit();
            this.lblTrangThaiLinhKien = new DevExpress.XtraEditors.LabelControl();
            this.bteKhoXuat = new DevExpress.XtraEditors.ButtonEdit();
            this.bteTrungTam = new DevExpress.XtraEditors.ButtonEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoGiaoDich = new QLBH.Core.Form.GtidTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSanPham = new QLBH.Core.Form.GtidTextBox();
            this.lblThuocXuat = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.grpKetQuaTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gListChungTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListChungTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTinhTrangGN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrangThaiDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDraft)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteQuanHuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteDoiTac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteThuongVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTrangThaiDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLoaiDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhoXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpKetQuaTimKiem
            // 
            this.grpKetQuaTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKetQuaTimKiem.Controls.Add(this.gListChungTu);
            this.grpKetQuaTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKetQuaTimKiem.ForeColor = System.Drawing.Color.Black;
            this.grpKetQuaTimKiem.Location = new System.Drawing.Point(1, 156);
            this.grpKetQuaTimKiem.Name = "grpKetQuaTimKiem";
            this.grpKetQuaTimKiem.Size = new System.Drawing.Size(1018, 351);
            this.grpKetQuaTimKiem.TabIndex = 1;
            this.grpKetQuaTimKiem.TabStop = false;
            this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm";
            // 
            // gListChungTu
            // 
            this.gListChungTu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gListChungTu.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gListChungTu.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gListChungTu.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gListChungTu.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gListChungTu.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gListChungTu.EmbeddedNavigator.TextStringFormat = "Đơn hàng số {0} / Tổng số {1} đơn hàng";
            this.gListChungTu.Location = new System.Drawing.Point(6, 19);
            this.gListChungTu.MainView = this.gvListChungTu;
            this.gListChungTu.Name = "gListChungTu";
            this.gListChungTu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repEdit,
            this.repLoaiDonHang,
            this.repDraft,
            this.repTrangThaiDH,
            this.repTinhTrangGN});
            this.gListChungTu.Size = new System.Drawing.Size(1006, 326);
            this.gListChungTu.TabIndex = 0;
            this.gListChungTu.UseEmbeddedNavigator = true;
            this.gListChungTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListChungTu});
            // 
            // gvListChungTu
            // 
            this.gvListChungTu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NgayPhanCong,
            this.NhanVienGiaoNhan,
            this.NhanVienGiaoNhan2,
            this.NhanVienGiaoNhan3,
            this.DoiTacGiaoNhan,
            this.NhanVienDoiTac,
            this.SoPhieuPhanCong,
            this.colLoaiDonHang,
            this.colSoGiaoDich,
            this.colNgayLap,
            this.colTrungTam,
            this.colKho,
            this.colSoHoaDon,
            this.SanPhamBan,
            this.colTenNhanVien,
            this.colTenDoiTuong,
            this.colNoiGiao,
            this.colNgayHenGiaoHang,
            this.colNgayGiaoHang,
            this.colNgayXuat,
            this.colSoPhieuXuat,
            this.colNgayGiaoXongHang,
            this.Draft,
            this.colNguoiTao,
            this.colNguoiSua,
            this.TenQuanHuyen,
            this.VungMien,
            this.LoaiCongViec,
            this.PhuongTienGiaoNhan,
            this.BienSoXe,
            this.LaiXe,
            this.GhiChu,
            this.TinhTrangGiaoHang,
            this.colTrangThai});
            this.gvListChungTu.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvListChungTu.GridControl = this.gListChungTu;
            this.gvListChungTu.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "SoChungTu", null, "  (Tổng số  = {0})")});
            this.gvListChungTu.Name = "gvListChungTu";
            this.gvListChungTu.OptionsView.ColumnAutoWidth = false;
            this.gvListChungTu.OptionsView.ShowAutoFilterRow = true;
            this.gvListChungTu.OptionsView.ShowDetailButtons = false;
            this.gvListChungTu.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvListChungTu_RowCellStyle);
            // 
            // NgayPhanCong
            // 
            this.NgayPhanCong.Caption = "Ngày phân công GN";
            this.NgayPhanCong.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.NgayPhanCong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgayPhanCong.FieldName = "NgayPhanCong";
            this.NgayPhanCong.Name = "NgayPhanCong";
            this.NgayPhanCong.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.NgayPhanCong.OptionsColumn.ReadOnly = true;
            this.NgayPhanCong.Visible = true;
            this.NgayPhanCong.VisibleIndex = 0;
            this.NgayPhanCong.Width = 129;
            // 
            // NhanVienGiaoNhan
            // 
            this.NhanVienGiaoNhan.Caption = "Nhân viên giao nhận 1";
            this.NhanVienGiaoNhan.FieldName = "NhanVienGiaoNhan";
            this.NhanVienGiaoNhan.Name = "NhanVienGiaoNhan";
            this.NhanVienGiaoNhan.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.NhanVienGiaoNhan.OptionsColumn.ReadOnly = true;
            this.NhanVienGiaoNhan.Visible = true;
            this.NhanVienGiaoNhan.VisibleIndex = 1;
            this.NhanVienGiaoNhan.Width = 137;
            // 
            // NhanVienGiaoNhan2
            // 
            this.NhanVienGiaoNhan2.Caption = "Nhân viên giao nhận 2";
            this.NhanVienGiaoNhan2.FieldName = "NhanVienGiaoNhan2";
            this.NhanVienGiaoNhan2.Name = "NhanVienGiaoNhan2";
            this.NhanVienGiaoNhan2.OptionsColumn.ReadOnly = true;
            this.NhanVienGiaoNhan2.Visible = true;
            this.NhanVienGiaoNhan2.VisibleIndex = 2;
            this.NhanVienGiaoNhan2.Width = 142;
            // 
            // NhanVienGiaoNhan3
            // 
            this.NhanVienGiaoNhan3.Caption = "Nhân viên giao nhận 3";
            this.NhanVienGiaoNhan3.FieldName = "NhanVienGiaoNhan3";
            this.NhanVienGiaoNhan3.Name = "NhanVienGiaoNhan3";
            this.NhanVienGiaoNhan3.OptionsColumn.ReadOnly = true;
            this.NhanVienGiaoNhan3.Visible = true;
            this.NhanVienGiaoNhan3.VisibleIndex = 3;
            this.NhanVienGiaoNhan3.Width = 142;
            // 
            // DoiTacGiaoNhan
            // 
            this.DoiTacGiaoNhan.Caption = "Đối tác";
            this.DoiTacGiaoNhan.FieldName = "DoiTacGiaoNhan";
            this.DoiTacGiaoNhan.Name = "DoiTacGiaoNhan";
            this.DoiTacGiaoNhan.OptionsColumn.ReadOnly = true;
            this.DoiTacGiaoNhan.Visible = true;
            this.DoiTacGiaoNhan.VisibleIndex = 4;
            this.DoiTacGiaoNhan.Width = 127;
            // 
            // NhanVienDoiTac
            // 
            this.NhanVienDoiTac.Caption = "Nhân viên đối tác";
            this.NhanVienDoiTac.FieldName = "NhanVienDoiTac";
            this.NhanVienDoiTac.Name = "NhanVienDoiTac";
            this.NhanVienDoiTac.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.NhanVienDoiTac.OptionsColumn.ReadOnly = true;
            this.NhanVienDoiTac.Visible = true;
            this.NhanVienDoiTac.VisibleIndex = 5;
            this.NhanVienDoiTac.Width = 153;
            // 
            // SoPhieuPhanCong
            // 
            this.SoPhieuPhanCong.Caption = "Số phân công GN";
            this.SoPhieuPhanCong.FieldName = "SoPhieuPhanCong";
            this.SoPhieuPhanCong.Name = "SoPhieuPhanCong";
            this.SoPhieuPhanCong.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.SoPhieuPhanCong.OptionsColumn.ReadOnly = true;
            this.SoPhieuPhanCong.Visible = true;
            this.SoPhieuPhanCong.VisibleIndex = 6;
            this.SoPhieuPhanCong.Width = 132;
            // 
            // colLoaiDonHang
            // 
            this.colLoaiDonHang.Caption = "Loại đơn hàng";
            this.colLoaiDonHang.ColumnEdit = this.repLoaiDonHang;
            this.colLoaiDonHang.FieldName = "LoaiChungTu";
            this.colLoaiDonHang.Name = "colLoaiDonHang";
            this.colLoaiDonHang.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colLoaiDonHang.OptionsColumn.ReadOnly = true;
            this.colLoaiDonHang.Visible = true;
            this.colLoaiDonHang.VisibleIndex = 7;
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
            // colSoGiaoDich
            // 
            this.colSoGiaoDich.Caption = "Số giao dịch";
            this.colSoGiaoDich.FieldName = "SoChungTu";
            this.colSoGiaoDich.Name = "colSoGiaoDich";
            this.colSoGiaoDich.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSoGiaoDich.OptionsColumn.ReadOnly = true;
            this.colSoGiaoDich.Visible = true;
            this.colSoGiaoDich.VisibleIndex = 8;
            this.colSoGiaoDich.Width = 149;
            // 
            // colNgayLap
            // 
            this.colNgayLap.Caption = "Ngày lập";
            this.colNgayLap.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colNgayLap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayLap.FieldName = "NgayLap";
            this.colNgayLap.Name = "colNgayLap";
            this.colNgayLap.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNgayLap.OptionsColumn.ReadOnly = true;
            this.colNgayLap.Visible = true;
            this.colNgayLap.VisibleIndex = 9;
            this.colNgayLap.Width = 113;
            // 
            // colTrungTam
            // 
            this.colTrungTam.Caption = "Trung tâm";
            this.colTrungTam.FieldName = "TenTrungTam";
            this.colTrungTam.Name = "colTrungTam";
            this.colTrungTam.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTrungTam.OptionsColumn.ReadOnly = true;
            this.colTrungTam.Visible = true;
            this.colTrungTam.VisibleIndex = 10;
            this.colTrungTam.Width = 166;
            // 
            // colKho
            // 
            this.colKho.AppearanceCell.Options.UseTextOptions = true;
            this.colKho.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colKho.Caption = "Kho hàng";
            this.colKho.FieldName = "TenKho";
            this.colKho.Name = "colKho";
            this.colKho.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colKho.OptionsColumn.ReadOnly = true;
            this.colKho.Visible = true;
            this.colKho.VisibleIndex = 11;
            this.colKho.Width = 237;
            // 
            // colSoHoaDon
            // 
            this.colSoHoaDon.Caption = "Số hóa đơn";
            this.colSoHoaDon.FieldName = "SoSeri";
            this.colSoHoaDon.Name = "colSoHoaDon";
            this.colSoHoaDon.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSoHoaDon.OptionsColumn.ReadOnly = true;
            this.colSoHoaDon.Visible = true;
            this.colSoHoaDon.VisibleIndex = 12;
            this.colSoHoaDon.Width = 121;
            // 
            // SanPhamBan
            // 
            this.SanPhamBan.Caption = "Sản phẩm bán";
            this.SanPhamBan.FieldName = "SanPhamBan";
            this.SanPhamBan.Name = "SanPhamBan";
            this.SanPhamBan.OptionsColumn.ReadOnly = true;
            this.SanPhamBan.Visible = true;
            this.SanPhamBan.VisibleIndex = 13;
            this.SanPhamBan.Width = 264;
            // 
            // colTenNhanVien
            // 
            this.colTenNhanVien.Caption = "Thương viên";
            this.colTenNhanVien.FieldName = "TenNhanVien";
            this.colTenNhanVien.Name = "colTenNhanVien";
            this.colTenNhanVien.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTenNhanVien.OptionsColumn.ReadOnly = true;
            this.colTenNhanVien.Visible = true;
            this.colTenNhanVien.VisibleIndex = 14;
            this.colTenNhanVien.Width = 143;
            // 
            // colTenDoiTuong
            // 
            this.colTenDoiTuong.Caption = "Khách hàng";
            this.colTenDoiTuong.FieldName = "HoTen";
            this.colTenDoiTuong.Name = "colTenDoiTuong";
            this.colTenDoiTuong.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTenDoiTuong.OptionsColumn.ReadOnly = true;
            this.colTenDoiTuong.Visible = true;
            this.colTenDoiTuong.VisibleIndex = 15;
            this.colTenDoiTuong.Width = 239;
            // 
            // colNoiGiao
            // 
            this.colNoiGiao.Caption = "Địa chỉ giao hàng";
            this.colNoiGiao.FieldName = "DiaChiGiaoHang";
            this.colNoiGiao.Name = "colNoiGiao";
            this.colNoiGiao.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNoiGiao.OptionsColumn.ReadOnly = true;
            this.colNoiGiao.Visible = true;
            this.colNoiGiao.VisibleIndex = 16;
            this.colNoiGiao.Width = 222;
            // 
            // colNgayHenGiaoHang
            // 
            this.colNgayHenGiaoHang.Caption = "Ngày hẹn giao hàng";
            this.colNgayHenGiaoHang.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colNgayHenGiaoHang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayHenGiaoHang.FieldName = "NgayHenGiaoHang";
            this.colNgayHenGiaoHang.Name = "colNgayHenGiaoHang";
            this.colNgayHenGiaoHang.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNgayHenGiaoHang.OptionsColumn.ReadOnly = true;
            this.colNgayHenGiaoHang.Visible = true;
            this.colNgayHenGiaoHang.VisibleIndex = 17;
            this.colNgayHenGiaoHang.Width = 119;
            // 
            // colNgayGiaoHang
            // 
            this.colNgayGiaoHang.Caption = "Ngày giao hàng";
            this.colNgayGiaoHang.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colNgayGiaoHang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayGiaoHang.FieldName = "NgayGiaoHang";
            this.colNgayGiaoHang.Name = "colNgayGiaoHang";
            this.colNgayGiaoHang.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNgayGiaoHang.OptionsColumn.ReadOnly = true;
            this.colNgayGiaoHang.Width = 115;
            // 
            // colNgayXuat
            // 
            this.colNgayXuat.Caption = "Ngày xuất";
            this.colNgayXuat.FieldName = "NgayXuatHang";
            this.colNgayXuat.Name = "colNgayXuat";
            this.colNgayXuat.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNgayXuat.OptionsColumn.ReadOnly = true;
            this.colNgayXuat.Width = 109;
            // 
            // colSoPhieuXuat
            // 
            this.colSoPhieuXuat.Caption = "Số phiếu xuất";
            this.colSoPhieuXuat.DisplayFormat.FormatString = "dd/mm/yyyy";
            this.colSoPhieuXuat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSoPhieuXuat.FieldName = "SoPhieuXuat";
            this.colSoPhieuXuat.Name = "colSoPhieuXuat";
            this.colSoPhieuXuat.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSoPhieuXuat.OptionsColumn.ReadOnly = true;
            this.colSoPhieuXuat.Width = 120;
            // 
            // colNgayGiaoXongHang
            // 
            this.colNgayGiaoXongHang.Caption = "Ngày giao xong hàng";
            this.colNgayGiaoXongHang.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colNgayGiaoXongHang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayGiaoXongHang.FieldName = "NgayGiaoXongHang";
            this.colNgayGiaoXongHang.Name = "colNgayGiaoXongHang";
            this.colNgayGiaoXongHang.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNgayGiaoXongHang.OptionsColumn.ReadOnly = true;
            this.colNgayGiaoXongHang.Visible = true;
            this.colNgayGiaoXongHang.VisibleIndex = 18;
            this.colNgayGiaoXongHang.Width = 130;
            // 
            // Draft
            // 
            this.Draft.Caption = "Bản nháp";
            this.Draft.ColumnEdit = this.repEdit;
            this.Draft.FieldName = "DraftGN";
            this.Draft.Name = "Draft";
            this.Draft.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Draft.OptionsColumn.ReadOnly = true;
            // 
            // repEdit
            // 
            this.repEdit.AutoHeight = false;
            this.repEdit.Name = "repEdit";
            this.repEdit.ValueChecked = 1;
            this.repEdit.ValueUnchecked = 0;
            // 
            // colNguoiTao
            // 
            this.colNguoiTao.Caption = "Người tạo";
            this.colNguoiTao.FieldName = "NguoiTao";
            this.colNguoiTao.Name = "colNguoiTao";
            this.colNguoiTao.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNguoiTao.OptionsColumn.ReadOnly = true;
            this.colNguoiTao.Width = 92;
            // 
            // colNguoiSua
            // 
            this.colNguoiSua.Caption = "Người cập nhật";
            this.colNguoiSua.FieldName = "NguoiSua";
            this.colNguoiSua.Name = "colNguoiSua";
            this.colNguoiSua.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNguoiSua.OptionsColumn.ReadOnly = true;
            this.colNguoiSua.Width = 103;
            // 
            // TenQuanHuyen
            // 
            this.TenQuanHuyen.Caption = "Quận/Huyện";
            this.TenQuanHuyen.FieldName = "TenQuanHuyen";
            this.TenQuanHuyen.Name = "TenQuanHuyen";
            this.TenQuanHuyen.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TenQuanHuyen.OptionsColumn.ReadOnly = true;
            this.TenQuanHuyen.Visible = true;
            this.TenQuanHuyen.VisibleIndex = 19;
            this.TenQuanHuyen.Width = 116;
            // 
            // VungMien
            // 
            this.VungMien.Caption = "Vùng miền";
            this.VungMien.FieldName = "TenVungMien";
            this.VungMien.Name = "VungMien";
            this.VungMien.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.VungMien.OptionsColumn.ReadOnly = true;
            this.VungMien.Visible = true;
            this.VungMien.VisibleIndex = 20;
            // 
            // LoaiCongViec
            // 
            this.LoaiCongViec.Caption = "Loại công việc";
            this.LoaiCongViec.FieldName = "LoaiCongViec";
            this.LoaiCongViec.Name = "LoaiCongViec";
            this.LoaiCongViec.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.LoaiCongViec.OptionsColumn.ReadOnly = true;
            this.LoaiCongViec.Visible = true;
            this.LoaiCongViec.VisibleIndex = 21;
            this.LoaiCongViec.Width = 127;
            // 
            // PhuongTienGiaoNhan
            // 
            this.PhuongTienGiaoNhan.Caption = "Phương tiện giao nhận";
            this.PhuongTienGiaoNhan.FieldName = "TenPhuongTien";
            this.PhuongTienGiaoNhan.Name = "PhuongTienGiaoNhan";
            this.PhuongTienGiaoNhan.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.PhuongTienGiaoNhan.OptionsColumn.ReadOnly = true;
            this.PhuongTienGiaoNhan.Visible = true;
            this.PhuongTienGiaoNhan.VisibleIndex = 22;
            this.PhuongTienGiaoNhan.Width = 127;
            // 
            // BienSoXe
            // 
            this.BienSoXe.Caption = "Biển số xe";
            this.BienSoXe.FieldName = "BienSoXe";
            this.BienSoXe.Name = "BienSoXe";
            this.BienSoXe.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.BienSoXe.OptionsColumn.ReadOnly = true;
            this.BienSoXe.Visible = true;
            this.BienSoXe.VisibleIndex = 23;
            // 
            // LaiXe
            // 
            this.LaiXe.Caption = "Lái xe";
            this.LaiXe.FieldName = "LaiXe";
            this.LaiXe.Name = "LaiXe";
            this.LaiXe.OptionsColumn.ReadOnly = true;
            this.LaiXe.Visible = true;
            this.LaiXe.VisibleIndex = 24;
            this.LaiXe.Width = 140;
            // 
            // GhiChu
            // 
            this.GhiChu.Caption = "Ghi chú chi tiết giao nhận";
            this.GhiChu.FieldName = "GhiChuGN";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.GhiChu.OptionsColumn.ReadOnly = true;
            this.GhiChu.Visible = true;
            this.GhiChu.VisibleIndex = 25;
            this.GhiChu.Width = 207;
            // 
            // TinhTrangGiaoHang
            // 
            this.TinhTrangGiaoHang.Caption = "Tình trạng giao hàng";
            this.TinhTrangGiaoHang.ColumnEdit = this.repTinhTrangGN;
            this.TinhTrangGiaoHang.FieldName = "TinhTrangGiaoNhan";
            this.TinhTrangGiaoHang.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.TinhTrangGiaoHang.Name = "TinhTrangGiaoHang";
            this.TinhTrangGiaoHang.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TinhTrangGiaoHang.OptionsColumn.ReadOnly = true;
            this.TinhTrangGiaoHang.Visible = true;
            this.TinhTrangGiaoHang.VisibleIndex = 26;
            this.TinhTrangGiaoHang.Width = 161;
            // 
            // repTinhTrangGN
            // 
            this.repTinhTrangGN.AutoHeight = false;
            this.repTinhTrangGN.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repTinhTrangGN.DisplayMember = "Name";
            this.repTinhTrangGN.Name = "repTinhTrangGN";
            this.repTinhTrangGN.ValueMember = "Id";
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
            this.colTrangThai.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTrangThai.OptionsColumn.ReadOnly = true;
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
            // tsslHuyClr
            // 
            this.tsslHuyClr.BackColor = System.Drawing.Color.Red;
            this.tsslHuyClr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tsslHuyClr.Name = "tsslHuyClr";
            this.tsslHuyClr.Size = new System.Drawing.Size(24, 17);
            this.tsslHuyClr.Text = "    ";
            // 
            // tsslHuy
            // 
            this.tsslHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tsslHuy.Name = "tsslHuy";
            this.tsslHuy.Size = new System.Drawing.Size(97, 17);
            this.tsslHuy.Text = "Hủy giao hàng  ";
            // 
            // tsslDaGiaoXong
            // 
            this.tsslDaGiaoXong.BackColor = System.Drawing.Color.Silver;
            this.tsslDaGiaoXong.Name = "tsslDaGiaoXong";
            this.tsslDaGiaoXong.Size = new System.Drawing.Size(24, 17);
            this.tsslDaGiaoXong.Text = "    ";
            // 
            // tsslTuChoi
            // 
            this.tsslTuChoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tsslTuChoi.Name = "tsslTuChoi";
            this.tsslTuChoi.Size = new System.Drawing.Size(83, 17);
            this.tsslTuChoi.Text = "Đã giao xong";
            // 
            // tsslDangGiaoHang
            // 
            this.tsslDangGiaoHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tsslDangGiaoHang.Name = "tsslDangGiaoHang";
            this.tsslDangGiaoHang.Size = new System.Drawing.Size(24, 17);
            this.tsslDangGiaoHang.Text = "    ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslChuaPC,
            this.toolStripStatusLabel1,
            this.tsslDaPhanCong,
            this.toolStripStatusLabel3,
            this.tsslDangGiaoHang,
            this.toolStripStatusLabel4,
            this.tsslDaGiaoXong,
            this.tsslTuChoi,
            this.tsslHuyClr,
            this.tsslHuy,
            this.tsslNLaiClr,
            this.tsslNLai});
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(1021, 22);
            this.statusStrip1.TabIndex = 108;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslChuaPC
            // 
            this.tsslChuaPC.BackColor = System.Drawing.Color.Yellow;
            this.tsslChuaPC.Name = "tsslChuaPC";
            this.tsslChuaPC.Size = new System.Drawing.Size(24, 17);
            this.tsslChuaPC.Text = "    ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(93, 17);
            this.toolStripStatusLabel1.Text = "Chờ phân công";
            // 
            // tsslDaPhanCong
            // 
            this.tsslDaPhanCong.BackColor = System.Drawing.Color.Lime;
            this.tsslDaPhanCong.Name = "tsslDaPhanCong";
            this.tsslDaPhanCong.Size = new System.Drawing.Size(24, 17);
            this.tsslDaPhanCong.Text = "    ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(87, 17);
            this.toolStripStatusLabel3.Text = "Đã phân công";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(98, 17);
            this.toolStripStatusLabel4.Text = "Đang giao hàng";
            // 
            // tsslNLaiClr
            // 
            this.tsslNLaiClr.BackColor = System.Drawing.Color.DeepPink;
            this.tsslNLaiClr.Name = "tsslNLaiClr";
            this.tsslNLaiClr.Size = new System.Drawing.Size(24, 17);
            this.tsslNLaiClr.Text = "    ";
            // 
            // tsslNLai
            // 
            this.tsslNLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tsslNLai.Name = "tsslNLai";
            this.tsslNLai.Size = new System.Drawing.Size(86, 17);
            this.tsslNLai.Text = "Nhập lại hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cboPhuongTienGN);
            this.groupBox1.Controls.Add(this.lblNganHangTT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.bteQuanHuyen);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.cboVungMienKhach);
            this.groupBox1.Controls.Add(this.bteDoiTac);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.bteThuongVien);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblTrangThaiDH);
            this.groupBox1.Controls.Add(this.cmdExport);
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.dteEnd);
            this.groupBox1.Controls.Add(this.dteStart);
            this.groupBox1.Controls.Add(this.lblEnd);
            this.groupBox1.Controls.Add(this.lblStart);
            this.groupBox1.Controls.Add(this.lueTrangThaiDH);
            this.groupBox1.Controls.Add(this.lueLoaiDH);
            this.groupBox1.Controls.Add(this.lblTrangThaiLinhKien);
            this.groupBox1.Controls.Add(this.bteKhoXuat);
            this.groupBox1.Controls.Add(this.bteTrungTam);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSoGiaoDich);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSanPham);
            this.groupBox1.Controls.Add(this.lblThuocXuat);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(1, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 146);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            // 
            // cboPhuongTienGN
            // 
            this.cboPhuongTienGN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhuongTienGN.FormattingEnabled = true;
            this.cboPhuongTienGN.Location = new System.Drawing.Point(559, 115);
            this.cboPhuongTienGN.Name = "cboPhuongTienGN";
            this.cboPhuongTienGN.Size = new System.Drawing.Size(184, 21);
            this.cboPhuongTienGN.TabIndex = 155;
            // 
            // lblNganHangTT
            // 
            this.lblNganHangTT.AutoSize = true;
            this.lblNganHangTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNganHangTT.Location = new System.Drawing.Point(456, 119);
            this.lblNganHangTT.Name = "lblNganHangTT";
            this.lblNganHangTT.Size = new System.Drawing.Size(99, 13);
            this.lblNganHangTT.TabIndex = 156;
            this.lblNganHangTT.Text = "Phương tiện đi giao";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label6.Location = new System.Drawing.Point(751, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 154;
            this.label6.Text = "Vùng";
            // 
            // bteQuanHuyen
            // 
            this.bteQuanHuyen.Location = new System.Drawing.Point(559, 88);
            this.bteQuanHuyen.Name = "bteQuanHuyen";
            this.bteQuanHuyen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteQuanHuyen.Size = new System.Drawing.Size(314, 20);
            this.bteQuanHuyen.TabIndex = 151;
            this.bteQuanHuyen.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteQuanHuyen_ButtonClick);
            this.bteQuanHuyen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteQuanHuyen_KeyDown);
            this.bteQuanHuyen.TextChanged += new System.EventHandler(this.bteQuanHuyen_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label18.Location = new System.Drawing.Point(487, 91);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 13);
            this.label18.TabIndex = 153;
            this.label18.Text = "Quận/Huyện";
            // 
            // cboVungMienKhach
            // 
            this.cboVungMienKhach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVungMienKhach.FormattingEnabled = true;
            this.cboVungMienKhach.Location = new System.Drawing.Point(786, 115);
            this.cboVungMienKhach.Name = "cboVungMienKhach";
            this.cboVungMienKhach.Size = new System.Drawing.Size(87, 21);
            this.cboVungMienKhach.TabIndex = 152;
            // 
            // bteDoiTac
            // 
            this.bteDoiTac.Location = new System.Drawing.Point(559, 62);
            this.bteDoiTac.Name = "bteDoiTac";
            this.bteDoiTac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteDoiTac.Size = new System.Drawing.Size(314, 20);
            this.bteDoiTac.TabIndex = 149;
            this.bteDoiTac.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteDoiTac_ButtonClick);
            this.bteDoiTac.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteDoiTac_KeyDown);
            this.bteDoiTac.TextChanged += new System.EventHandler(this.bteDoiTac_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label4.Location = new System.Drawing.Point(514, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 150;
            this.label4.Text = "Đối tác";
            // 
            // bteThuongVien
            // 
            this.bteThuongVien.Location = new System.Drawing.Point(559, 37);
            this.bteThuongVien.Name = "bteThuongVien";
            this.bteThuongVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteThuongVien.Size = new System.Drawing.Size(314, 20);
            this.bteThuongVien.TabIndex = 147;
            this.bteThuongVien.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteThuongVien_ButtonClick);
            this.bteThuongVien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteThuongVien_KeyDown);
            this.bteThuongVien.TextChanged += new System.EventHandler(this.bteThuongVien_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(479, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 148;
            this.label2.Text = "Tên nhân viên";
            // 
            // lblTrangThaiDH
            // 
            this.lblTrangThaiDH.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTrangThaiDH.Appearance.Options.UseFont = true;
            this.lblTrangThaiDH.Location = new System.Drawing.Point(16, 41);
            this.lblTrangThaiDH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTrangThaiDH.Name = "lblTrangThaiDH";
            this.lblTrangThaiDH.Size = new System.Drawing.Size(69, 13);
            this.lblTrangThaiDH.TabIndex = 146;
            this.lblTrangThaiDH.Text = "T.Thái G.Nhận";
            // 
            // cmdExport
            // 
            this.cmdExport.Image = ((System.Drawing.Image)(resources.GetObject("cmdExport.Image")));
            this.cmdExport.Location = new System.Drawing.Point(892, 58);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdExport.Size = new System.Drawing.Size(101, 25);
            this.cmdExport.TabIndex = 20;
            this.cmdExport.Text = "Export (F6)";
            this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(892, 90);
            this.btnDong.Name = "btnDong";
            this.btnDong.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnDong.Size = new System.Drawing.Size(101, 25);
            this.btnDong.TabIndex = 21;
            this.btnDong.Text = "Đóng (F12)";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnTim
            // 
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.Location = new System.Drawing.Point(892, 27);
            this.btnTim.Name = "btnTim";
            this.btnTim.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnTim.Size = new System.Drawing.Size(101, 25);
            this.btnTim.TabIndex = 19;
            this.btnTim.Text = "&Tìm kiếm (F3)";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dteEnd
            // 
            this.dteEnd.EditValue = null;
            this.dteEnd.Location = new System.Drawing.Point(747, 12);
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
            this.dteEnd.Size = new System.Drawing.Size(126, 20);
            this.dteEnd.TabIndex = 11;
            // 
            // dteStart
            // 
            this.dteStart.EditValue = null;
            this.dteStart.Location = new System.Drawing.Point(559, 12);
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
            this.dteStart.Size = new System.Drawing.Size(116, 20);
            this.dteStart.TabIndex = 10;
            // 
            // lblEnd
            // 
            this.lblEnd.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEnd.Appearance.Options.UseFont = true;
            this.lblEnd.Location = new System.Drawing.Point(698, 15);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(45, 13);
            this.lblEnd.TabIndex = 145;
            this.lblEnd.Text = "đến ngày";
            // 
            // lblStart
            // 
            this.lblStart.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStart.Appearance.Options.UseFont = true;
            this.lblStart.Location = new System.Drawing.Point(515, 15);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(40, 13);
            this.lblStart.TabIndex = 144;
            this.lblStart.Text = "Từ ngày";
            // 
            // lueTrangThaiDH
            // 
            this.lueTrangThaiDH.Location = new System.Drawing.Point(92, 37);
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
            this.lueTrangThaiDH.Size = new System.Drawing.Size(352, 20);
            this.lueTrangThaiDH.TabIndex = 4;
            // 
            // lueLoaiDH
            // 
            this.lueLoaiDH.Location = new System.Drawing.Point(300, 12);
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
            this.lueLoaiDH.Size = new System.Drawing.Size(144, 20);
            this.lueLoaiDH.TabIndex = 1;
            // 
            // lblTrangThaiLinhKien
            // 
            this.lblTrangThaiLinhKien.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTrangThaiLinhKien.Appearance.Options.UseFont = true;
            this.lblTrangThaiLinhKien.Location = new System.Drawing.Point(225, 15);
            this.lblTrangThaiLinhKien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTrangThaiLinhKien.Name = "lblTrangThaiLinhKien";
            this.lblTrangThaiLinhKien.Size = new System.Drawing.Size(67, 13);
            this.lblTrangThaiLinhKien.TabIndex = 139;
            this.lblTrangThaiLinhKien.Text = "Loại đơn hàng";
            // 
            // bteKhoXuat
            // 
            this.bteKhoXuat.Location = new System.Drawing.Point(92, 88);
            this.bteKhoXuat.Name = "bteKhoXuat";
            this.bteKhoXuat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteKhoXuat.Properties.Appearance.Options.UseFont = true;
            this.bteKhoXuat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteKhoXuat.Size = new System.Drawing.Size(352, 22);
            this.bteKhoXuat.TabIndex = 6;
            this.bteKhoXuat.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteKhoXuat_ButtonClick);
            this.bteKhoXuat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteKhoXuat_KeyDown);
            this.bteKhoXuat.TextChanged += new System.EventHandler(this.bteKhoXuat_TextChanged);
            // 
            // bteTrungTam
            // 
            this.bteTrungTam.Location = new System.Drawing.Point(92, 61);
            this.bteTrungTam.Name = "bteTrungTam";
            this.bteTrungTam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteTrungTam.Properties.Appearance.Options.UseFont = true;
            this.bteTrungTam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteTrungTam.Size = new System.Drawing.Size(352, 22);
            this.bteTrungTam.TabIndex = 5;
            this.bteTrungTam.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteTrungTam_ButtonClick);
            this.bteTrungTam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteTrungTam_KeyDown);
            this.bteTrungTam.TextChanged += new System.EventHandler(this.bteTrungTam_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 118;
            this.label7.Text = "Trung tâm";
            // 
            // txtSoGiaoDich
            // 
            this.txtSoGiaoDich.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoGiaoDich.Location = new System.Drawing.Point(92, 12);
            this.txtSoGiaoDich.Name = "txtSoGiaoDich";
            this.txtSoGiaoDich.Size = new System.Drawing.Size(127, 20);
            this.txtSoGiaoDich.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "Số phiếu";
            // 
            // txtSanPham
            // 
            this.txtSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSanPham.Location = new System.Drawing.Point(92, 115);
            this.txtSanPham.Name = "txtSanPham";
            this.txtSanPham.Size = new System.Drawing.Size(352, 20);
            this.txtSanPham.TabIndex = 8;
            // 
            // lblThuocXuat
            // 
            this.lblThuocXuat.AutoSize = true;
            this.lblThuocXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuocXuat.Location = new System.Drawing.Point(30, 119);
            this.lblThuocXuat.Name = "lblThuocXuat";
            this.lblThuocXuat.Size = new System.Drawing.Size(55, 13);
            this.lblThuocXuat.TabIndex = 0;
            this.lblThuocXuat.Text = "Sản phẩm";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(36, 93);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 91;
            this.label17.Text = "Kho xuất";
            // 
            // frmBC_GiaoNhanChiTietKThuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 532);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpKetQuaTimKiem);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmBC_GiaoNhanChiTietKThuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo tổng hợp kỹ thuật giao nhận";
            this.Load += new System.EventHandler(this.frmBH_TimChungTu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBH_TimChungTu_KeyDown);
            this.grpKetQuaTimKiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gListChungTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListChungTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTinhTrangGN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrangThaiDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDraft)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteQuanHuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteDoiTac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteThuongVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTrangThaiDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLoaiDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhoXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKetQuaTimKiem;
        private DevExpress.XtraGrid.GridControl gListChungTu;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn colTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDoiTuong;
        private DevExpress.XtraGrid.Columns.GridColumn colKho;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiDonHang;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLoaiDonHang;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayLap;
        private DevExpress.XtraGrid.Columns.GridColumn colSoGiaoDich;
        private DevExpress.XtraGrid.Columns.GridColumn colSoHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn colSoPhieuXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhanVien;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayGiaoHang;
        private DevExpress.XtraGrid.Columns.GridColumn colNoiGiao;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repDraft;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThai;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repTrangThaiDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoiTao;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoiSua;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayHenGiaoHang;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayGiaoXongHang;
        private DevExpress.XtraGrid.Columns.GridColumn SoPhieuPhanCong;
        private DevExpress.XtraGrid.Columns.GridColumn NgayPhanCong;
        private DevExpress.XtraGrid.Columns.GridColumn TinhTrangGiaoHang;
        private DevExpress.XtraGrid.Columns.GridColumn Draft;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repTinhTrangGN;
        public System.Windows.Forms.ToolStripStatusLabel tsslHuyClr;
        public System.Windows.Forms.ToolStripStatusLabel tsslHuy;
        public System.Windows.Forms.ToolStripStatusLabel tsslDaGiaoXong;
        public System.Windows.Forms.ToolStripStatusLabel tsslTuChoi;
        private System.Windows.Forms.ToolStripStatusLabel tsslDangGiaoHang;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslChuaPC;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslDaPhanCong;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private DevExpress.XtraGrid.Columns.GridColumn NhanVienGiaoNhan;
        private DevExpress.XtraGrid.Columns.GridColumn VungMien;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiCongViec;
        private DevExpress.XtraGrid.Columns.GridColumn PhuongTienGiaoNhan;
        private DevExpress.XtraGrid.Columns.GridColumn BienSoXe;
        private DevExpress.XtraGrid.Columns.GridColumn TenQuanHuyen;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn NhanVienDoiTac;
        private System.Windows.Forms.ToolStripStatusLabel tsslNLaiClr;
        private System.Windows.Forms.ToolStripStatusLabel tsslNLai;
        private DevExpress.XtraGrid.Columns.GridColumn DoiTacGiaoNhan;
        private DevExpress.XtraGrid.Columns.GridColumn SanPhamBan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboPhuongTienGN;
        private System.Windows.Forms.Label lblNganHangTT;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.ButtonEdit bteQuanHuyen;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cboVungMienKhach;
        private DevExpress.XtraEditors.ButtonEdit bteDoiTac;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.ButtonEdit bteThuongVien;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LabelControl lblTrangThaiDH;
        private GtidButton cmdExport;
        internal GtidButton btnDong;
        private GtidButton btnTim;
        private DevExpress.XtraEditors.DateEdit dteEnd;
        private DevExpress.XtraEditors.DateEdit dteStart;
        private DevExpress.XtraEditors.LabelControl lblEnd;
        private DevExpress.XtraEditors.LabelControl lblStart;
        private DevExpress.XtraEditors.LookUpEdit lueTrangThaiDH;
        private DevExpress.XtraEditors.LookUpEdit lueLoaiDH;
        private DevExpress.XtraEditors.LabelControl lblTrangThaiLinhKien;
        private DevExpress.XtraEditors.ButtonEdit bteKhoXuat;
        private DevExpress.XtraEditors.ButtonEdit bteTrungTam;
        private System.Windows.Forms.Label label7;
        private GtidTextBox txtSoGiaoDich;
        private System.Windows.Forms.Label label3;
        private GtidTextBox txtSanPham;
        private System.Windows.Forms.Label lblThuocXuat;
        private System.Windows.Forms.Label label17;
        private DevExpress.XtraGrid.Columns.GridColumn NhanVienGiaoNhan2;
        private DevExpress.XtraGrid.Columns.GridColumn NhanVienGiaoNhan3;
        private DevExpress.XtraGrid.Columns.GridColumn LaiXe;
    }
}