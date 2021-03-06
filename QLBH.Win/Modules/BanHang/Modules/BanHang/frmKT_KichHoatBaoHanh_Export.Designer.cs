﻿using QLBH.Core.Form;
namespace QLBanHang.Modules.BanHang
{
    partial class frmKT_KichHoatBaoHanh_Export
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKT_KichHoatBaoHanh_Export));
            this.cmdExport = new QLBH.Core.Form.GtidButton();
            this.btnDong = new QLBH.Core.Form.GtidButton();
            this.grpKetQuaTimKiem = new System.Windows.Forms.GroupBox();
            this.gListChungTu = new DevExpress.XtraGrid.GridControl();
            this.gvListChungTu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FromChannelCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ToChannelCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PROMOTERID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaVach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EndUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repLoaiDonHang = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repTrangThaiDH = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.grpKetQuaTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gListChungTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListChungTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrangThaiDH)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdExport
            // 
            this.cmdExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdExport.Image = ((System.Drawing.Image)(resources.GetObject("cmdExport.Image")));
            this.cmdExport.Location = new System.Drawing.Point(12, 487);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdExport.Size = new System.Drawing.Size(101, 25);
            this.cmdExport.TabIndex = 20;
            this.cmdExport.Text = "Export (F12)";
            this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(908, 487);
            this.btnDong.Name = "btnDong";
            this.btnDong.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnDong.Size = new System.Drawing.Size(101, 25);
            this.btnDong.TabIndex = 21;
            this.btnDong.Text = "Đóng (F12)";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // grpKetQuaTimKiem
            // 
            this.grpKetQuaTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKetQuaTimKiem.Controls.Add(this.gListChungTu);
            this.grpKetQuaTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKetQuaTimKiem.ForeColor = System.Drawing.Color.Black;
            this.grpKetQuaTimKiem.Location = new System.Drawing.Point(1, 5);
            this.grpKetQuaTimKiem.Name = "grpKetQuaTimKiem";
            this.grpKetQuaTimKiem.Size = new System.Drawing.Size(1018, 475);
            this.grpKetQuaTimKiem.TabIndex = 1;
            this.grpKetQuaTimKiem.TabStop = false;
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
            this.gListChungTu.Location = new System.Drawing.Point(6, 15);
            this.gListChungTu.MainView = this.gvListChungTu;
            this.gListChungTu.Name = "gListChungTu";
            this.gListChungTu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repEdit,
            this.repLoaiDonHang,
            this.repTrangThaiDH});
            this.gListChungTu.Size = new System.Drawing.Size(1006, 450);
            this.gListChungTu.TabIndex = 0;
            this.gListChungTu.UseEmbeddedNavigator = true;
            this.gListChungTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListChungTu});
            // 
            // gvListChungTu
            // 
            this.gvListChungTu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.NgayBan,
            this.FromChannelCode,
            this.ToChannelCode,
            this.PROMOTERID,
            this.colMaVach,
            this.EndUserName,
            this.DienThoai});
            this.gvListChungTu.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvListChungTu.GridControl = this.gListChungTu;
            this.gvListChungTu.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "SoChungTu", null, "  (Tổng số  = {0})")});
            this.gvListChungTu.Name = "gvListChungTu";
            this.gvListChungTu.OptionsView.ColumnAutoWidth = false;
            this.gvListChungTu.OptionsView.ShowAutoFilterRow = true;
            this.gvListChungTu.OptionsView.ShowDetailButtons = false;
            this.gvListChungTu.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.PROMOTERID, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.NgayBan, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.ToChannelCode, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvListChungTu.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvListChungTu_FocusedRowChanged);
            this.gvListChungTu.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvListChungTu_RowCellStyle);
            // 
            // STT
            // 
            this.STT.Caption = "No";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.OptionsColumn.ReadOnly = true;
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 56;
            // 
            // NgayBan
            // 
            this.NgayBan.Caption = "SALES DATE";
            this.NgayBan.DisplayFormat.FormatString = "yyyyMMdd";
            this.NgayBan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgayBan.FieldName = "SalesDate";
            this.NgayBan.Name = "NgayBan";
            this.NgayBan.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.NgayBan.Visible = true;
            this.NgayBan.VisibleIndex = 1;
            this.NgayBan.Width = 113;
            // 
            // FromChannelCode
            // 
            this.FromChannelCode.Caption = "FROM CHANNEL CODE";
            this.FromChannelCode.FieldName = "FromChannelCode";
            this.FromChannelCode.Name = "FromChannelCode";
            this.FromChannelCode.OptionsColumn.AllowFocus = false;
            this.FromChannelCode.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.FromChannelCode.OptionsColumn.AllowMove = false;
            this.FromChannelCode.OptionsColumn.ReadOnly = true;
            this.FromChannelCode.Visible = true;
            this.FromChannelCode.VisibleIndex = 2;
            this.FromChannelCode.Width = 142;
            // 
            // ToChannelCode
            // 
            this.ToChannelCode.Caption = "TO CHANNEL CODE";
            this.ToChannelCode.FieldName = "ToChannelCode";
            this.ToChannelCode.Name = "ToChannelCode";
            this.ToChannelCode.OptionsColumn.AllowFocus = false;
            this.ToChannelCode.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.ToChannelCode.OptionsColumn.AllowMove = false;
            this.ToChannelCode.OptionsColumn.ReadOnly = true;
            this.ToChannelCode.Visible = true;
            this.ToChannelCode.VisibleIndex = 3;
            this.ToChannelCode.Width = 165;
            // 
            // PROMOTERID
            // 
            this.PROMOTERID.AppearanceCell.Options.UseTextOptions = true;
            this.PROMOTERID.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.PROMOTERID.Caption = "PROMOTER ID";
            this.PROMOTERID.FieldName = "PROMOTERID";
            this.PROMOTERID.Name = "PROMOTERID";
            this.PROMOTERID.OptionsColumn.AllowFocus = false;
            this.PROMOTERID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.PROMOTERID.OptionsColumn.AllowMove = false;
            this.PROMOTERID.Visible = true;
            this.PROMOTERID.VisibleIndex = 4;
            this.PROMOTERID.Width = 237;
            // 
            // colMaVach
            // 
            this.colMaVach.Caption = "IMEI CODE/SERIAL NO";
            this.colMaVach.FieldName = "MaVach";
            this.colMaVach.Name = "colMaVach";
            this.colMaVach.OptionsColumn.ReadOnly = true;
            this.colMaVach.Visible = true;
            this.colMaVach.VisibleIndex = 5;
            this.colMaVach.Width = 146;
            // 
            // EndUserName
            // 
            this.EndUserName.Caption = "End User Name";
            this.EndUserName.FieldName = "EndUserName";
            this.EndUserName.Name = "EndUserName";
            this.EndUserName.Visible = true;
            this.EndUserName.VisibleIndex = 6;
            this.EndUserName.Width = 138;
            // 
            // DienThoai
            // 
            this.DienThoai.Caption = "End User Phone No.";
            this.DienThoai.FieldName = "DienThoai";
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.Visible = true;
            this.DienThoai.VisibleIndex = 7;
            this.DienThoai.Width = 134;
            // 
            // repEdit
            // 
            this.repEdit.AutoHeight = false;
            this.repEdit.Name = "repEdit";
            this.repEdit.ValueChecked = 1;
            this.repEdit.ValueUnchecked = 0;
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
            // repTrangThaiDH
            // 
            this.repTrangThaiDH.AutoHeight = false;
            this.repTrangThaiDH.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repTrangThaiDH.DisplayMember = "Name";
            this.repTrangThaiDH.Name = "repTrangThaiDH";
            this.repTrangThaiDH.ValueMember = "Id";
            // 
            // frmKT_KichHoatBaoHanh_Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 520);
            this.Controls.Add(this.grpKetQuaTimKiem);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.cmdExport);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmKT_KichHoatBaoHanh_Export";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kích hoạt bảo hành sản phẩm đã bán";
            this.Load += new System.EventHandler(this.frmBH_TimChungTu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBH_TimChungTu_KeyDown);
            this.grpKetQuaTimKiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gListChungTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListChungTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrangThaiDH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKetQuaTimKiem;
        internal GtidButton btnDong;
        private DevExpress.XtraGrid.GridControl gListChungTu;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn FromChannelCode;
        private DevExpress.XtraGrid.Columns.GridColumn PROMOTERID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLoaiDonHang;
        private DevExpress.XtraGrid.Columns.GridColumn NgayBan;
        private DevExpress.XtraGrid.Columns.GridColumn ToChannelCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repEdit;
        private GtidButton cmdExport;
        private DevExpress.XtraGrid.Columns.GridColumn colMaVach;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repTrangThaiDH;
        private DevExpress.XtraGrid.Columns.GridColumn EndUserName;
        private DevExpress.XtraGrid.Columns.GridColumn DienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
    }
}