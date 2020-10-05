using DevExpress.Utils;
using QLBH.Core.Form;
namespace QLBanHang.Modules.BanHang
{
    partial class frmCS_ListChinhSachKMai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCS_ListChinhSachKMai));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDefault = new System.Windows.Forms.ToolStripButton();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslInfor = new System.Windows.Forms.ToolStripLabel();
            this.grpKetQuaTimKiem = new System.Windows.Forms.GroupBox();
            this.gChinhSach = new DevExpress.XtraGrid.GridControl();
            this.gvChinhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdChinhSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoChinhSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DoUuTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MacDinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLoaiCS = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.DuocTichLuyDiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.DaDuyetTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayHieuLuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HanHieuLucTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDraft = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiDuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiDoiTuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDoiTuongAD = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.btnNext = new QLBH.Core.Form.GtidButton();
            this.cboPage = new System.Windows.Forms.ComboBox();
            this.chkChonDuyet = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslChuaDuyetClr = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslChuaDuyet = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTuChoiClr = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTuChoi = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDraft = new System.Windows.Forms.ToolStripStatusLabel();
            this.grThongTin = new System.Windows.Forms.GroupBox();
            this.cboLoaiCS = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.cboDuyet = new System.Windows.Forms.ComboBox();
            this.txtMatHang = new QLBH.Core.Form.GtidTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
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
            this.toolStrip1.SuspendLayout();
            this.grpKetQuaTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gChinhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChinhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDoiTuongAD)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.grThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbEdit,
            this.tsbDelete,
            this.toolStripSeparator3,
            this.btnDefault,
            this.btnStop,
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
            // btnDefault
            // 
            this.btnDefault.Image = ((System.Drawing.Image)(resources.GetObject("btnDefault.Image")));
            this.btnDefault.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(100, 22);
            this.btnDefault.Text = "&Mặc định (F9)";
            this.btnDefault.ToolTipText = "Tạm &dừng (F11)";
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnStop
            // 
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(111, 22);
            this.btnStop.Text = "Tạm &dừng (F11)";
            this.btnStop.ToolTipText = "Tạm &dừng (F11)";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
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
            this.tslInfor.Size = new System.Drawing.Size(188, 22);
            this.tslInfor.Text = "Thiết lập chính sách khuyến mại";
            // 
            // grpKetQuaTimKiem
            // 
            this.grpKetQuaTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKetQuaTimKiem.Controls.Add(this.gChinhSach);
            this.grpKetQuaTimKiem.Controls.Add(this.btnNext);
            this.grpKetQuaTimKiem.Controls.Add(this.cboPage);
            this.grpKetQuaTimKiem.Controls.Add(this.chkChonDuyet);
            this.grpKetQuaTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKetQuaTimKiem.ForeColor = System.Drawing.Color.Black;
            this.grpKetQuaTimKiem.Location = new System.Drawing.Point(0, 106);
            this.grpKetQuaTimKiem.Name = "grpKetQuaTimKiem";
            this.grpKetQuaTimKiem.Size = new System.Drawing.Size(1209, 401);
            this.grpKetQuaTimKiem.TabIndex = 3;
            this.grpKetQuaTimKiem.TabStop = false;
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
            this.gChinhSach.Location = new System.Drawing.Point(6, 14);
            this.gChinhSach.MainView = this.gvChinhSach;
            this.gChinhSach.Name = "gChinhSach";
            this.gChinhSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCheck,
            this.repDoiTuongAD,
            this.repLoaiCS});
            this.gChinhSach.Size = new System.Drawing.Size(1197, 360);
            this.gChinhSach.TabIndex = 155;
            this.gChinhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChinhSach});
            this.gChinhSach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gListChungTu_KeyDown);
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
            this.NgayLap,
            this.NguoiLap,
            this.DoUuTien,
            this.MacDinh,
            this.DuocTichLuyDiem,
            this.DaDuyetTT,
            this.NgayHieuLuc,
            this.HanHieuLucTT,
            this.colDraft,
            this.NguoiTao,
            this.NguoiDuyet,
            this.LoaiDoiTuong});
            this.gvChinhSach.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvChinhSach.GridControl = this.gChinhSach;
            this.gvChinhSach.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "SoChinhSach", null, "   (Tổng số = {0})")});
            this.gvChinhSach.Name = "gvChinhSach";
            this.gvChinhSach.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvChinhSach.OptionsView.ShowAutoFilterRow = true;
            this.gvChinhSach.OptionsView.ShowDetailButtons = false;
            this.gvChinhSach.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvListChungTu_FocusedRowChanged);
            this.gvChinhSach.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvChinhSach_RowCellStyle);
            this.gvChinhSach.DoubleClick += new System.EventHandler(this.gvListChungTu_DoubleClick);
            // 
            // IdChinhSach
            // 
            this.IdChinhSach.Caption = "IdChinhSach";
            this.IdChinhSach.FieldName = "IdChinhSach";
            this.IdChinhSach.Name = "IdChinhSach";
            this.IdChinhSach.OptionsColumn.AllowEdit = false;
            this.IdChinhSach.OptionsColumn.AllowFocus = false;
            this.IdChinhSach.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
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
            this.SoChinhSach.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.SoChinhSach.OptionsColumn.AllowMove = false;
            this.SoChinhSach.OptionsColumn.ReadOnly = true;
            this.SoChinhSach.Visible = true;
            this.SoChinhSach.VisibleIndex = 0;
            this.SoChinhSach.Width = 163;
            // 
            // NgayLap
            // 
            this.NgayLap.Caption = "Ngày lập";
            this.NgayLap.FieldName = "NgayLap";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.OptionsColumn.AllowEdit = false;
            this.NgayLap.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.NgayLap.Visible = true;
            this.NgayLap.VisibleIndex = 1;
            this.NgayLap.Width = 85;
            // 
            // NguoiLap
            // 
            this.NguoiLap.Caption = "Người lập";
            this.NguoiLap.FieldName = "NguoiLap";
            this.NguoiLap.Name = "NguoiLap";
            this.NguoiLap.OptionsColumn.AllowEdit = false;
            this.NguoiLap.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.NguoiLap.Visible = true;
            this.NguoiLap.VisibleIndex = 2;
            this.NguoiLap.Width = 100;
            // 
            // DoUuTien
            // 
            this.DoUuTien.Caption = "Độ ưu tiên";
            this.DoUuTien.FieldName = "DoUuTien";
            this.DoUuTien.Name = "DoUuTien";
            this.DoUuTien.OptionsColumn.AllowEdit = false;
            this.DoUuTien.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.DoUuTien.Visible = true;
            this.DoUuTien.VisibleIndex = 3;
            this.DoUuTien.Width = 66;
            // 
            // MacDinh
            // 
            this.MacDinh.Caption = "Loại chính sách";
            this.MacDinh.ColumnEdit = this.repLoaiCS;
            this.MacDinh.FieldName = "MacDinh";
            this.MacDinh.Name = "MacDinh";
            this.MacDinh.OptionsColumn.AllowEdit = false;
            this.MacDinh.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.MacDinh.OptionsColumn.ReadOnly = true;
            this.MacDinh.Visible = true;
            this.MacDinh.VisibleIndex = 4;
            this.MacDinh.Width = 100;
            // 
            // repLoaiCS
            // 
            this.repLoaiCS.AutoHeight = false;
            this.repLoaiCS.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLoaiCS.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.repLoaiCS.DisplayMember = "Name";
            this.repLoaiCS.Name = "repLoaiCS";
            this.repLoaiCS.ValueMember = "Id";
            // 
            // DuocTichLuyDiem
            // 
            this.DuocTichLuyDiem.Caption = "Được tích điểm";
            this.DuocTichLuyDiem.ColumnEdit = this.repCheck;
            this.DuocTichLuyDiem.FieldName = "DuocTichLuyDiem";
            this.DuocTichLuyDiem.Name = "DuocTichLuyDiem";
            this.DuocTichLuyDiem.Visible = true;
            this.DuocTichLuyDiem.VisibleIndex = 6;
            this.DuocTichLuyDiem.Width = 86;
            // 
            // repCheck
            // 
            this.repCheck.AutoHeight = false;
            this.repCheck.Name = "repCheck";
            this.repCheck.ValueChecked = 1;
            this.repCheck.ValueUnchecked = 0;
            // 
            // DaDuyetTT
            // 
            this.DaDuyetTT.Caption = "Trạng thái";
            this.DaDuyetTT.FieldName = "DaDuyetTT";
            this.DaDuyetTT.Name = "DaDuyetTT";
            this.DaDuyetTT.OptionsColumn.AllowEdit = false;
            this.DaDuyetTT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.DaDuyetTT.Visible = true;
            this.DaDuyetTT.VisibleIndex = 5;
            this.DaDuyetTT.Width = 114;
            // 
            // NgayHieuLuc
            // 
            this.NgayHieuLuc.Caption = "Hiệu lực từ ngày";
            this.NgayHieuLuc.FieldName = "NgayHieuLuc";
            this.NgayHieuLuc.Name = "NgayHieuLuc";
            this.NgayHieuLuc.OptionsColumn.AllowEdit = false;
            this.NgayHieuLuc.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.NgayHieuLuc.Visible = true;
            this.NgayHieuLuc.VisibleIndex = 7;
            this.NgayHieuLuc.Width = 96;
            // 
            // HanHieuLucTT
            // 
            this.HanHieuLucTT.Caption = "Hiệu lực đến";
            this.HanHieuLucTT.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss PM";
            this.HanHieuLucTT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.HanHieuLucTT.FieldName = "HanHieuLucTT";
            this.HanHieuLucTT.Name = "HanHieuLucTT";
            this.HanHieuLucTT.OptionsColumn.AllowEdit = false;
            this.HanHieuLucTT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.HanHieuLucTT.Visible = true;
            this.HanHieuLucTT.VisibleIndex = 8;
            this.HanHieuLucTT.Width = 77;
            // 
            // colDraft
            // 
            this.colDraft.Caption = "Bản nháp";
            this.colDraft.ColumnEdit = this.repCheck;
            this.colDraft.FieldName = "Draft";
            this.colDraft.Name = "colDraft";
            this.colDraft.OptionsColumn.AllowEdit = false;
            this.colDraft.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colDraft.Visible = true;
            this.colDraft.VisibleIndex = 9;
            this.colDraft.Width = 66;
            // 
            // NguoiTao
            // 
            this.NguoiTao.Caption = "Người tạo";
            this.NguoiTao.FieldName = "NguoiTao";
            this.NguoiTao.Name = "NguoiTao";
            this.NguoiTao.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.NguoiTao.Visible = true;
            this.NguoiTao.VisibleIndex = 10;
            this.NguoiTao.Width = 80;
            // 
            // NguoiDuyet
            // 
            this.NguoiDuyet.Caption = "Người duyệt";
            this.NguoiDuyet.FieldName = "NguoiDuyet";
            this.NguoiDuyet.Name = "NguoiDuyet";
            this.NguoiDuyet.Visible = true;
            this.NguoiDuyet.VisibleIndex = 11;
            this.NguoiDuyet.Width = 87;
            // 
            // LoaiDoiTuong
            // 
            this.LoaiDoiTuong.Caption = "Đối tượng áp dụng";
            this.LoaiDoiTuong.ColumnEdit = this.repDoiTuongAD;
            this.LoaiDoiTuong.FieldName = "LoaiDoiTuong";
            this.LoaiDoiTuong.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.LoaiDoiTuong.Name = "LoaiDoiTuong";
            this.LoaiDoiTuong.OptionsColumn.AllowEdit = false;
            this.LoaiDoiTuong.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.LoaiDoiTuong.Visible = true;
            this.LoaiDoiTuong.VisibleIndex = 12;
            this.LoaiDoiTuong.Width = 112;
            // 
            // repDoiTuongAD
            // 
            this.repDoiTuongAD.AutoHeight = false;
            this.repDoiTuongAD.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repDoiTuongAD.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.repDoiTuongAD.DisplayMember = "Name";
            this.repDoiTuongAD.Name = "repDoiTuongAD";
            this.repDoiTuongAD.ValueMember = "Id";
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
            this.toolStripStatusLabel1,
            this.tsslTrangThai,
            this.tsslChuaDuyetClr,
            this.tsslChuaDuyet,
            this.tsslTuChoiClr,
            this.tsslTuChoi,
            this.tsslDraft});
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(1209, 22);
            this.statusStrip1.TabIndex = 107;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabel1.Text = "Trạng thái: ";
            // 
            // tsslTrangThai
            // 
            this.tsslTrangThai.Name = "tsslTrangThai";
            this.tsslTrangThai.Size = new System.Drawing.Size(92, 17);
            this.tsslTrangThai.Text = "đang hoạt động";
            // 
            // tsslChuaDuyetClr
            // 
            this.tsslChuaDuyetClr.BackColor = System.Drawing.Color.Blue;
            this.tsslChuaDuyetClr.ForeColor = System.Drawing.Color.White;
            this.tsslChuaDuyetClr.Name = "tsslChuaDuyetClr";
            this.tsslChuaDuyetClr.Size = new System.Drawing.Size(19, 17);
            this.tsslChuaDuyetClr.Text = "    ";
            // 
            // tsslChuaDuyet
            // 
            this.tsslChuaDuyet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tsslChuaDuyet.Name = "tsslChuaDuyet";
            this.tsslChuaDuyet.Size = new System.Drawing.Size(68, 17);
            this.tsslChuaDuyet.Text = "Chưa duyệt";
            // 
            // tsslTuChoiClr
            // 
            this.tsslTuChoiClr.BackColor = System.Drawing.Color.Yellow;
            this.tsslTuChoiClr.Name = "tsslTuChoiClr";
            this.tsslTuChoiClr.Size = new System.Drawing.Size(19, 17);
            this.tsslTuChoiClr.Text = "    ";
            // 
            // tsslTuChoi
            // 
            this.tsslTuChoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tsslTuChoi.Name = "tsslTuChoi";
            this.tsslTuChoi.Size = new System.Drawing.Size(47, 17);
            this.tsslTuChoi.Text = "Từ chối";
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
            this.grThongTin.Controls.Add(this.cboLoaiCS);
            this.grThongTin.Controls.Add(this.labelControl2);
            this.grThongTin.Controls.Add(this.cboTrangThai);
            this.grThongTin.Controls.Add(this.cboDuyet);
            this.grThongTin.Controls.Add(this.txtMatHang);
            this.grThongTin.Controls.Add(this.label2);
            this.grThongTin.Controls.Add(this.labelControl1);
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
            // cboLoaiCS
            // 
            this.cboLoaiCS.FormattingEnabled = true;
            this.cboLoaiCS.Items.AddRange(new object[] {
            "Tất cả",
            "Đang tạm dừng",
            "Chưa kích hoạt",
            "Đang hoạt động"});
            this.cboLoaiCS.Location = new System.Drawing.Point(717, 41);
            this.cboLoaiCS.Name = "cboLoaiCS";
            this.cboLoaiCS.Size = new System.Drawing.Size(130, 21);
            this.cboLoaiCS.TabIndex = 145;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(642, 44);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 13);
            this.labelControl2.TabIndex = 144;
            this.labelControl2.Text = "Loại chính sách";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Tất cả",
            "Đã xác nhận",
            "Chưa xác nhận"});
            this.cboTrangThai.Location = new System.Drawing.Point(936, 41);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(130, 21);
            this.cboTrangThai.TabIndex = 143;
            // 
            // cboDuyet
            // 
            this.cboDuyet.FormattingEnabled = true;
            this.cboDuyet.Items.AddRange(new object[] {
            "Tất cả",
            "Đang tạm dừng",
            "Chưa duyệt",
            "Đang hoạt động",
            "Từ chối"});
            this.cboDuyet.Location = new System.Drawing.Point(509, 41);
            this.cboDuyet.Name = "cboDuyet";
            this.cboDuyet.Size = new System.Drawing.Size(130, 21);
            this.cboDuyet.TabIndex = 142;
            // 
            // txtMatHang
            // 
            this.txtMatHang.Location = new System.Drawing.Point(936, 14);
            this.txtMatHang.Name = "txtMatHang";
            this.txtMatHang.Size = new System.Drawing.Size(266, 21);
            this.txtMatHang.TabIndex = 140;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(865, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 141;
            this.label2.Text = "Mã/tên hàng";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(886, 44);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 139;
            this.labelControl1.Text = "Xác nhận";
            // 
            // lblTrangThaiLinhKien
            // 
            this.lblTrangThaiLinhKien.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTrangThaiLinhKien.Appearance.Options.UseFont = true;
            this.lblTrangThaiLinhKien.Location = new System.Drawing.Point(404, 44);
            this.lblTrangThaiLinhKien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTrangThaiLinhKien.Name = "lblTrangThaiLinhKien";
            this.lblTrangThaiLinhKien.Size = new System.Drawing.Size(101, 13);
            this.lblTrangThaiLinhKien.TabIndex = 137;
            this.lblTrangThaiLinhKien.Text = "Trạng thái hoạt động";
            // 
            // dteEnd
            // 
            this.dteEnd.EditValue = null;
            this.dteEnd.Location = new System.Drawing.Point(717, 14);
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
            this.dteStart.Location = new System.Drawing.Point(509, 14);
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
            this.btnTimkiem.Location = new System.Drawing.Point(1086, 39);
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
            this.lblEnd.Location = new System.Drawing.Point(668, 17);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(45, 13);
            this.lblEnd.TabIndex = 131;
            this.lblEnd.Text = "đến ngày";
            // 
            // lblStart
            // 
            this.lblStart.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStart.Appearance.Options.UseFont = true;
            this.lblStart.Location = new System.Drawing.Point(465, 17);
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
            this.bteTrungTam.Size = new System.Drawing.Size(300, 22);
            this.bteTrungTam.TabIndex = 0;
            this.bteTrungTam.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteTrungTam_ButtonClick);
            this.bteTrungTam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteTrungTam_KeyDown);
            this.bteTrungTam.TextChanged += new System.EventHandler(this.bteTrungTam_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 125;
            this.label7.Text = "Trung tâm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 123;
            this.label1.Text = "Số chính sách";
            // 
            // txtSoBangGia
            // 
            this.txtSoBangGia.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtSoBangGia.Location = new System.Drawing.Point(86, 41);
            this.txtSoBangGia.Name = "txtSoBangGia";
            this.txtSoBangGia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSoBangGia.Size = new System.Drawing.Size(300, 21);
            this.txtSoBangGia.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmCS_ListChinhSachKMai
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
            this.Name = "frmCS_ListChinhSachKMai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập chính sách khuyến mại";
            this.Load += new System.EventHandler(this.frmBH_TimChungTu_Load);
            this.Activated += new System.EventHandler(this.frmCS_ListBangGia_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBH_TimChungTu_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpKetQuaTimKiem.ResumeLayout(false);
            this.grpKetQuaTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gChinhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChinhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDoiTuongAD)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grThongTin.ResumeLayout(false);
            this.grThongTin.PerformLayout();
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox grpKetQuaTimKiem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslDraft;
        private System.Windows.Forms.GroupBox grThongTin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private GtidTextBox txtSoBangGia;
        private DevExpress.XtraEditors.DateEdit dteEnd;
        private DevExpress.XtraEditors.DateEdit dteStart;
        private GtidSimpleButton btnTimkiem;
        private DevExpress.XtraEditors.LabelControl lblEnd;
        private DevExpress.XtraEditors.LabelControl lblStart;
        private DevExpress.XtraEditors.LabelControl lblTrangThaiLinhKien;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraEditors.ButtonEdit bteTrungTam;
        private System.Windows.Forms.CheckBox chkChonDuyet;
        private System.Windows.Forms.ToolStripLabel tslInfor;
        private System.Windows.Forms.Timer timer1;
        private GtidButton btnNext;
        private System.Windows.Forms.ComboBox cboPage;
        private GtidTextBox txtMatHang;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gChinhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChinhSach;
        private DevExpress.XtraGrid.Columns.GridColumn IdChinhSach;
        private DevExpress.XtraGrid.Columns.GridColumn SoChinhSach;
        private DevExpress.XtraGrid.Columns.GridColumn NgayLap;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiLap;
        private DevExpress.XtraGrid.Columns.GridColumn DoUuTien;
        private DevExpress.XtraGrid.Columns.GridColumn colDraft;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheck;
        private DevExpress.XtraGrid.Columns.GridColumn DaDuyetTT;
        private DevExpress.XtraGrid.Columns.GridColumn NgayHieuLuc;
        private DevExpress.XtraGrid.Columns.GridColumn HanHieuLucTT;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiTao;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiDoiTuong;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repDoiTuongAD;
        private System.Windows.Forms.ComboBox cboDuyet;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private DevExpress.XtraGrid.Columns.GridColumn MacDinh;
        private System.Windows.Forms.ToolStripButton btnDefault;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLoaiCS;
        private System.Windows.Forms.ComboBox cboLoaiCS;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public System.Windows.Forms.ToolStripStatusLabel tsslChuaDuyetClr;
        public System.Windows.Forms.ToolStripStatusLabel tsslChuaDuyet;
        public System.Windows.Forms.ToolStripStatusLabel tsslTuChoiClr;
        public System.Windows.Forms.ToolStripStatusLabel tsslTuChoi;
        private System.Windows.Forms.ToolStripStatusLabel tsslTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn DuocTichLuyDiem;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiDuyet;
    }
}