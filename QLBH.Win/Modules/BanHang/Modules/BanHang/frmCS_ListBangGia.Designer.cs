using QLBH.Core.Form;
namespace QLBanHang.Modules.BanHang
{
    partial class frmCS_ListBangGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCS_ListBangGia));
            this.gListBangGia = new DevExpress.XtraGrid.GridControl();
            this.gvListBangGia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdBangGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoBangGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LstIdTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LstMaTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Draft = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDraft = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.TongSoMatHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoMatHangChuaDuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoMatHangDaDuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayDuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.NguoiTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DaDuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTrangThai = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslInfor = new System.Windows.Forms.ToolStripLabel();
            this.grpKetQuaTimKiem = new System.Windows.Forms.GroupBox();
            this.btnNext = new QLBH.Core.Form.GtidButton();
            this.cboPage = new System.Windows.Forms.ComboBox();
            this.chkChonDuyet = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslDaPhanCong = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslHuyClr = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslHuy = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDraft = new System.Windows.Forms.ToolStripStatusLabel();
            this.grThongTin = new System.Windows.Forms.GroupBox();
            this.chkCuaToi = new System.Windows.Forms.CheckBox();
            this.lueDraft = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lueDuyet = new DevExpress.XtraEditors.LookUpEdit();
            this.lblTrangThaiLinhKien = new DevExpress.XtraEditors.LabelControl();
            this.dteEnd = new DevExpress.XtraEditors.DateEdit();
            this.dteStart = new DevExpress.XtraEditors.DateEdit();
            this.btnTimkiem = new QLBH.Core.Form.GtidSimpleButton();
            this.lblEnd = new DevExpress.XtraEditors.LabelControl();
            this.lblStart = new DevExpress.XtraEditors.LabelControl();
            this.bteTrungTam = new DevExpress.XtraEditors.ButtonEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoBangGia = new QLBH.Core.Form.GtidTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gListBangGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListBangGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDraft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateEdit.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrangThai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.grpKetQuaTimKiem.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueDraft.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDuyet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gListBangGia
            // 
            this.gListBangGia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gListBangGia.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gListBangGia.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gListBangGia.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gListBangGia.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gListBangGia.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gListBangGia.EmbeddedNavigator.TextStringFormat = "Bảng giá số {0} / Tổng số {1} bảng giá";
            this.gListBangGia.Location = new System.Drawing.Point(6, 14);
            this.gListBangGia.MainView = this.gvListBangGia;
            this.gListBangGia.Name = "gListBangGia";
            this.gListBangGia.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repEdit,
            this.repDraft,
            this.repDateEdit,
            this.repTrangThai});
            this.gListBangGia.Size = new System.Drawing.Size(1197, 360);
            this.gListBangGia.TabIndex = 29;
            this.gListBangGia.UseEmbeddedNavigator = true;
            this.gListBangGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListBangGia});
            this.gListBangGia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gListChungTu_KeyDown);
            // 
            // gvListBangGia
            // 
            this.gvListBangGia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdBangGia,
            this.SoBangGia,
            this.LstIdTrungTam,
            this.LstMaTrungTam,
            this.NgayLap,
            this.NguoiLap,
            this.Draft,
            this.TongSoMatHang,
            this.SoMatHangChuaDuyet,
            this.SoMatHangDaDuyet,
            this.NgayDuyet,
            this.NguoiTao,
            this.GhiChu,
            this.DaDuyet});
            this.gvListBangGia.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvListBangGia.GridControl = this.gListBangGia;
            this.gvListBangGia.Name = "gvListBangGia";
            this.gvListBangGia.OptionsView.ColumnAutoWidth = false;
            this.gvListBangGia.OptionsView.ShowAutoFilterRow = true;
            this.gvListBangGia.OptionsView.ShowDetailButtons = false;
            this.gvListBangGia.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvListChungTu_FocusedRowChanged);
            this.gvListBangGia.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvListBangGia_RowCellStyle);
            this.gvListBangGia.DoubleClick += new System.EventHandler(this.gvListChungTu_DoubleClick);
            // 
            // IdBangGia
            // 
            this.IdBangGia.Caption = "IdBangGia";
            this.IdBangGia.FieldName = "IdBangGia";
            this.IdBangGia.Name = "IdBangGia";
            this.IdBangGia.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            // 
            // SoBangGia
            // 
            this.SoBangGia.Caption = "Số bảng giá";
            this.SoBangGia.FieldName = "SoBangGia";
            this.SoBangGia.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.SoBangGia.Name = "SoBangGia";
            this.SoBangGia.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.SoBangGia.OptionsColumn.ReadOnly = true;
            this.SoBangGia.Visible = true;
            this.SoBangGia.VisibleIndex = 0;
            this.SoBangGia.Width = 134;
            // 
            // LstIdTrungTam
            // 
            this.LstIdTrungTam.Caption = "LstIdTrungTam";
            this.LstIdTrungTam.FieldName = "ListIdTrungTam";
            this.LstIdTrungTam.Name = "LstIdTrungTam";
            this.LstIdTrungTam.OptionsColumn.AllowEdit = false;
            this.LstIdTrungTam.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.LstIdTrungTam.Width = 107;
            // 
            // LstMaTrungTam
            // 
            this.LstMaTrungTam.Caption = "Trung tâm";
            this.LstMaTrungTam.FieldName = "ListMaTrungTam";
            this.LstMaTrungTam.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.LstMaTrungTam.Name = "LstMaTrungTam";
            this.LstMaTrungTam.OptionsColumn.AllowEdit = false;
            this.LstMaTrungTam.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.LstMaTrungTam.Visible = true;
            this.LstMaTrungTam.VisibleIndex = 1;
            this.LstMaTrungTam.Width = 172;
            // 
            // NgayLap
            // 
            this.NgayLap.Caption = "Ngày lập";
            this.NgayLap.FieldName = "NgayLap";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.OptionsColumn.AllowEdit = false;
            this.NgayLap.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.NgayLap.Visible = true;
            this.NgayLap.VisibleIndex = 2;
            this.NgayLap.Width = 121;
            // 
            // NguoiLap
            // 
            this.NguoiLap.Caption = "Người lập";
            this.NguoiLap.FieldName = "NguoiLap";
            this.NguoiLap.Name = "NguoiLap";
            this.NguoiLap.OptionsColumn.AllowEdit = false;
            this.NguoiLap.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.NguoiLap.Visible = true;
            this.NguoiLap.VisibleIndex = 3;
            this.NguoiLap.Width = 115;
            // 
            // Draft
            // 
            this.Draft.Caption = "Ghi chú";
            this.Draft.ColumnEdit = this.repDraft;
            this.Draft.FieldName = "Draft";
            this.Draft.Name = "Draft";
            this.Draft.OptionsColumn.AllowEdit = false;
            this.Draft.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Draft.Visible = true;
            this.Draft.VisibleIndex = 4;
            this.Draft.Width = 111;
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
            // TongSoMatHang
            // 
            this.TongSoMatHang.Caption = "Tổng số mặt hàng";
            this.TongSoMatHang.FieldName = "TongSoMatHang";
            this.TongSoMatHang.Name = "TongSoMatHang";
            this.TongSoMatHang.OptionsColumn.AllowEdit = false;
            this.TongSoMatHang.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TongSoMatHang.Visible = true;
            this.TongSoMatHang.VisibleIndex = 5;
            this.TongSoMatHang.Width = 128;
            // 
            // SoMatHangChuaDuyet
            // 
            this.SoMatHangChuaDuyet.Caption = "Chưa duyệt";
            this.SoMatHangChuaDuyet.FieldName = "SoMatHangChuaDuyet";
            this.SoMatHangChuaDuyet.Name = "SoMatHangChuaDuyet";
            this.SoMatHangChuaDuyet.OptionsColumn.AllowEdit = false;
            this.SoMatHangChuaDuyet.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.SoMatHangChuaDuyet.Visible = true;
            this.SoMatHangChuaDuyet.VisibleIndex = 6;
            this.SoMatHangChuaDuyet.Width = 92;
            // 
            // SoMatHangDaDuyet
            // 
            this.SoMatHangDaDuyet.Caption = "Đã duyệt";
            this.SoMatHangDaDuyet.FieldName = "SoMatHangDaDuyet";
            this.SoMatHangDaDuyet.Name = "SoMatHangDaDuyet";
            this.SoMatHangDaDuyet.OptionsColumn.AllowEdit = false;
            this.SoMatHangDaDuyet.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.SoMatHangDaDuyet.Visible = true;
            this.SoMatHangDaDuyet.VisibleIndex = 7;
            this.SoMatHangDaDuyet.Width = 89;
            // 
            // NgayDuyet
            // 
            this.NgayDuyet.Caption = "Ngày duyệt";
            this.NgayDuyet.ColumnEdit = this.repDateEdit;
            this.NgayDuyet.FieldName = "NgayDuyet";
            this.NgayDuyet.Name = "NgayDuyet";
            this.NgayDuyet.OptionsColumn.AllowEdit = false;
            this.NgayDuyet.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.NgayDuyet.Visible = true;
            this.NgayDuyet.VisibleIndex = 8;
            this.NgayDuyet.Width = 95;
            // 
            // repDateEdit
            // 
            this.repDateEdit.AutoHeight = false;
            this.repDateEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repDateEdit.Name = "repDateEdit";
            this.repDateEdit.NullDate = "1/1/0001";
            this.repDateEdit.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // NguoiTao
            // 
            this.NguoiTao.Caption = "Người tạo";
            this.NguoiTao.FieldName = "NguoiTao";
            this.NguoiTao.Name = "NguoiTao";
            this.NguoiTao.OptionsColumn.AllowEdit = false;
            this.NguoiTao.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.NguoiTao.Visible = true;
            this.NguoiTao.VisibleIndex = 9;
            this.NguoiTao.Width = 95;
            // 
            // GhiChu
            // 
            this.GhiChu.Caption = "Ghi chú";
            this.GhiChu.FieldName = "GhiChu";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.GhiChu.OptionsColumn.ReadOnly = true;
            this.GhiChu.Visible = true;
            this.GhiChu.VisibleIndex = 10;
            this.GhiChu.Width = 195;
            // 
            // DaDuyet
            // 
            this.DaDuyet.Caption = "Trạng thái duyệt";
            this.DaDuyet.ColumnEdit = this.repTrangThai;
            this.DaDuyet.FieldName = "DaDuyet";
            this.DaDuyet.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.DaDuyet.Name = "DaDuyet";
            this.DaDuyet.OptionsColumn.AllowEdit = false;
            this.DaDuyet.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.DaDuyet.Visible = true;
            this.DaDuyet.VisibleIndex = 11;
            this.DaDuyet.Width = 138;
            // 
            // repTrangThai
            // 
            this.repTrangThai.AutoHeight = false;
            this.repTrangThai.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repTrangThai.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.repTrangThai.DisplayMember = "Name";
            this.repTrangThai.Name = "repTrangThai";
            this.repTrangThai.ValueMember = "Id";
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
            this.tsbEdit.Size = new System.Drawing.Size(69, 22);
            this.tsbEdit.Text = "&Sửa (F6)";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(70, 22);
            this.tsbDelete.Text = "&Xóa (F8)";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbPrint
            // 
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(93, 22);
            this.tsbPrint.Text = "&In phiếu (F9)";
            this.tsbPrint.Click += new System.EventHandler(this.tsbPrint_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
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
            this.tslInfor.Size = new System.Drawing.Size(130, 22);
            this.tslInfor.Text = "Thiết lập bảng giá bán";
            // 
            // grpKetQuaTimKiem
            // 
            this.grpKetQuaTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKetQuaTimKiem.Controls.Add(this.btnNext);
            this.grpKetQuaTimKiem.Controls.Add(this.cboPage);
            this.grpKetQuaTimKiem.Controls.Add(this.chkChonDuyet);
            this.grpKetQuaTimKiem.Controls.Add(this.gListBangGia);
            this.grpKetQuaTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKetQuaTimKiem.ForeColor = System.Drawing.Color.Black;
            this.grpKetQuaTimKiem.Location = new System.Drawing.Point(0, 106);
            this.grpKetQuaTimKiem.Name = "grpKetQuaTimKiem";
            this.grpKetQuaTimKiem.Size = new System.Drawing.Size(1209, 401);
            this.grpKetQuaTimKiem.TabIndex = 3;
            this.grpKetQuaTimKiem.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(1081, 377);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnNext.Size = new System.Drawing.Size(121, 22);
            this.btnNext.TabIndex = 154;
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
            this.cboPage.Location = new System.Drawing.Point(1029, 377);
            this.cboPage.Name = "cboPage";
            this.cboPage.Size = new System.Drawing.Size(50, 21);
            this.cboPage.TabIndex = 153;
            // 
            // chkChonDuyet
            // 
            this.chkChonDuyet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkChonDuyet.AutoSize = true;
            this.chkChonDuyet.BackColor = System.Drawing.Color.Transparent;
            this.chkChonDuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChonDuyet.Location = new System.Drawing.Point(29, 380);
            this.chkChonDuyet.Name = "chkChonDuyet";
            this.chkChonDuyet.Size = new System.Drawing.Size(96, 17);
            this.chkChonDuyet.TabIndex = 84;
            this.chkChonDuyet.Text = "Chọn/Bỏ chọn";
            this.chkChonDuyet.UseVisualStyleBackColor = false;
            this.chkChonDuyet.CheckedChanged += new System.EventHandler(this.chkChonDuyet_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslDaPhanCong,
            this.toolStripStatusLabel3,
            this.tsslHuyClr,
            this.tsslHuy,
            this.tsslTrangThai,
            this.tsslDraft});
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(1209, 22);
            this.statusStrip1.TabIndex = 107;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslDaPhanCong
            // 
            this.tsslDaPhanCong.BackColor = System.Drawing.Color.Blue;
            this.tsslDaPhanCong.ForeColor = System.Drawing.Color.Yellow;
            this.tsslDaPhanCong.Name = "tsslDaPhanCong";
            this.tsslDaPhanCong.Size = new System.Drawing.Size(19, 17);
            this.tsslDaPhanCong.Text = "    ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(81, 17);
            this.toolStripStatusLabel3.Text = "Đồng ý duyệt ";
            // 
            // tsslHuyClr
            // 
            this.tsslHuyClr.BackColor = System.Drawing.Color.Yellow;
            this.tsslHuyClr.ForeColor = System.Drawing.Color.Navy;
            this.tsslHuyClr.Name = "tsslHuyClr";
            this.tsslHuyClr.Size = new System.Drawing.Size(19, 17);
            this.tsslHuyClr.Text = "    ";
            // 
            // tsslHuy
            // 
            this.tsslHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tsslHuy.Name = "tsslHuy";
            this.tsslHuy.Size = new System.Drawing.Size(86, 17);
            this.tsslHuy.Text = "Từ chối duyệt  ";
            // 
            // tsslTrangThai
            // 
            this.tsslTrangThai.Name = "tsslTrangThai";
            this.tsslTrangThai.Size = new System.Drawing.Size(105, 17);
            this.tsslTrangThai.Text = "Tạo mới đơn hàng";
            // 
            // tsslDraft
            // 
            this.tsslDraft.Name = "tsslDraft";
            this.tsslDraft.Size = new System.Drawing.Size(0, 17);
            // 
            // grThongTin
            // 
            this.grThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grThongTin.Controls.Add(this.chkCuaToi);
            this.grThongTin.Controls.Add(this.lueDraft);
            this.grThongTin.Controls.Add(this.labelControl1);
            this.grThongTin.Controls.Add(this.lueDuyet);
            this.grThongTin.Controls.Add(this.lblTrangThaiLinhKien);
            this.grThongTin.Controls.Add(this.dteEnd);
            this.grThongTin.Controls.Add(this.dteStart);
            this.grThongTin.Controls.Add(this.btnTimkiem);
            this.grThongTin.Controls.Add(this.lblEnd);
            this.grThongTin.Controls.Add(this.lblStart);
            this.grThongTin.Controls.Add(this.bteTrungTam);
            this.grThongTin.Controls.Add(this.label7);
            this.grThongTin.Controls.Add(this.label1);
            this.grThongTin.Controls.Add(this.txtSoBangGia);
            this.grThongTin.Location = new System.Drawing.Point(0, 28);
            this.grThongTin.Name = "grThongTin";
            this.grThongTin.Size = new System.Drawing.Size(1209, 72);
            this.grThongTin.TabIndex = 0;
            this.grThongTin.TabStop = false;
            // 
            // chkCuaToi
            // 
            this.chkCuaToi.AutoSize = true;
            this.chkCuaToi.Checked = true;
            this.chkCuaToi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCuaToi.Location = new System.Drawing.Point(896, 16);
            this.chkCuaToi.Name = "chkCuaToi";
            this.chkCuaToi.Size = new System.Drawing.Size(60, 17);
            this.chkCuaToi.TabIndex = 6;
            this.chkCuaToi.Text = "Của tôi";
            this.chkCuaToi.UseVisualStyleBackColor = true;
            // 
            // lueDraft
            // 
            this.lueDraft.Location = new System.Drawing.Point(739, 41);
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
            this.lueDraft.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(689, 44);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 139;
            this.labelControl1.Text = "Xác nhận";
            // 
            // lueDuyet
            // 
            this.lueDuyet.Location = new System.Drawing.Point(540, 41);
            this.lueDuyet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lueDuyet.Name = "lueDuyet";
            this.lueDuyet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lueDuyet.Properties.Appearance.Options.UseFont = true;
            this.lueDuyet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDuyet.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.lueDuyet.Properties.DisplayMember = "Name";
            this.lueDuyet.Properties.NullText = "";
            this.lueDuyet.Properties.ShowFooter = false;
            this.lueDuyet.Properties.ShowHeader = false;
            this.lueDuyet.Properties.ValueMember = "Id";
            this.lueDuyet.Size = new System.Drawing.Size(130, 20);
            this.lueDuyet.TabIndex = 4;
            // 
            // lblTrangThaiLinhKien
            // 
            this.lblTrangThaiLinhKien.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTrangThaiLinhKien.Appearance.Options.UseFont = true;
            this.lblTrangThaiLinhKien.Location = new System.Drawing.Point(438, 44);
            this.lblTrangThaiLinhKien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTrangThaiLinhKien.Name = "lblTrangThaiLinhKien";
            this.lblTrangThaiLinhKien.Size = new System.Drawing.Size(93, 13);
            this.lblTrangThaiLinhKien.TabIndex = 137;
            this.lblTrangThaiLinhKien.Text = "Tình trạng bảng giá";
            // 
            // dteEnd
            // 
            this.dteEnd.EditValue = null;
            this.dteEnd.Location = new System.Drawing.Point(739, 14);
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
            this.dteEnd.TabIndex = 3;
            // 
            // dteStart
            // 
            this.dteStart.EditValue = null;
            this.dteStart.Location = new System.Drawing.Point(540, 14);
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
            this.dteStart.TabIndex = 2;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimkiem.Appearance.Options.UseFont = true;
            this.btnTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.Image")));
            this.btnTimkiem.Location = new System.Drawing.Point(896, 38);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.ShortCutKey = System.Windows.Forms.Keys.F9;
            this.btnTimkiem.Size = new System.Drawing.Size(111, 23);
            this.btnTimkiem.TabIndex = 7;
            this.btnTimkiem.Text = "Lọc";
            this.btnTimkiem.ToolTip = "F9";
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // lblEnd
            // 
            this.lblEnd.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEnd.Appearance.Options.UseFont = true;
            this.lblEnd.Location = new System.Drawing.Point(688, 17);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(45, 13);
            this.lblEnd.TabIndex = 131;
            this.lblEnd.Text = "đến ngày";
            // 
            // lblStart
            // 
            this.lblStart.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStart.Appearance.Options.UseFont = true;
            this.lblStart.Location = new System.Drawing.Point(491, 17);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(40, 13);
            this.lblStart.TabIndex = 130;
            this.lblStart.Text = "Từ ngày";
            // 
            // bteTrungTam
            // 
            this.bteTrungTam.Location = new System.Drawing.Point(86, 14);
            this.bteTrungTam.Name = "bteTrungTam";
            this.bteTrungTam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteTrungTam.Properties.Appearance.Options.UseFont = true;
            this.bteTrungTam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteTrungTam.Size = new System.Drawing.Size(320, 22);
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
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 123;
            this.label1.Text = "Số bảng giá";
            // 
            // txtSoBangGia
            // 
            this.txtSoBangGia.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtSoBangGia.Location = new System.Drawing.Point(86, 41);
            this.txtSoBangGia.Name = "txtSoBangGia";
            this.txtSoBangGia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSoBangGia.Size = new System.Drawing.Size(320, 21);
            this.txtSoBangGia.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmCS_ListBangGia
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
            this.Name = "frmCS_ListBangGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách bảng giá";
            this.Load += new System.EventHandler(this.frmBH_TimChungTu_Load);
            this.Activated += new System.EventHandler(this.frmCS_ListBangGia_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBH_TimChungTu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gListBangGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListBangGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDraft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateEdit.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrangThai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpKetQuaTimKiem.ResumeLayout(false);
            this.grpKetQuaTimKiem.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grThongTin.ResumeLayout(false);
            this.grThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueDraft.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDuyet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStripButton tsbAdd;
        public System.Windows.Forms.ToolStripButton tsbEdit;
        public System.Windows.Forms.ToolStripButton tsbDelete;
        public System.Windows.Forms.ToolStripButton tsbPrint;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListBangGia;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox grpKetQuaTimKiem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslTrangThai;
        private System.Windows.Forms.ToolStripStatusLabel tsslDraft;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repEdit;
        private System.Windows.Forms.GroupBox grThongTin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private GtidTextBox txtSoBangGia;
        private DevExpress.XtraEditors.DateEdit dteEnd;
        private DevExpress.XtraEditors.DateEdit dteStart;
        private GtidSimpleButton btnTimkiem;
        private DevExpress.XtraEditors.LabelControl lblEnd;
        private DevExpress.XtraEditors.LabelControl lblStart;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repDraft;
        private DevExpress.XtraEditors.LookUpEdit lueDuyet;
        private DevExpress.XtraEditors.LabelControl lblTrangThaiLinhKien;
        private DevExpress.XtraEditors.LookUpEdit lueDraft;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gListBangGia;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraEditors.ButtonEdit bteTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn LstIdTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn LstMaTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn IdBangGia;
        private DevExpress.XtraGrid.Columns.GridColumn SoBangGia;
        private DevExpress.XtraGrid.Columns.GridColumn NgayLap;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiLap;
        private DevExpress.XtraGrid.Columns.GridColumn Draft;
        private DevExpress.XtraGrid.Columns.GridColumn DaDuyet;
        private DevExpress.XtraGrid.Columns.GridColumn NgayDuyet;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiTao;
        private System.Windows.Forms.CheckBox chkChonDuyet;
        private DevExpress.XtraGrid.Columns.GridColumn TongSoMatHang;
        private DevExpress.XtraGrid.Columns.GridColumn SoMatHangChuaDuyet;
        private DevExpress.XtraGrid.Columns.GridColumn SoMatHangDaDuyet;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repDateEdit;
        private System.Windows.Forms.CheckBox chkCuaToi;
        private System.Windows.Forms.ToolStripLabel tslInfor;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;
        private GtidButton btnNext;
        private System.Windows.Forms.ComboBox cboPage;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repTrangThai;
        private System.Windows.Forms.ToolStripStatusLabel tsslDaPhanCong;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        public System.Windows.Forms.ToolStripStatusLabel tsslHuyClr;
        public System.Windows.Forms.ToolStripStatusLabel tsslHuy;
    }
}