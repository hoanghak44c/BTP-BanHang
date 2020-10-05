using QLBH.Core.Form;
namespace QLBanHang.Modules.BanHang
{
    partial class frmBC_CongNoKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBC_CongNoKhachHang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdExport = new QLBH.Core.Form.GtidButton();
            this.btnDong = new QLBH.Core.Form.GtidButton();
            this.btnTim = new QLBH.Core.Form.GtidButton();
            this.bteKhachHang = new DevExpress.XtraEditors.ButtonEdit();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.grpKetQuaTimKiem = new System.Windows.Forms.GroupBox();
            this.gListChungTu = new DevExpress.XtraGrid.GridControl();
            this.gvListChungTu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdDoiTuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaDoiTuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDoiTuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TongHanMucTinDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HanMucTinDungConLai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CongNoBanHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayCapNhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLoaiDonHang = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repLoaiPhieu = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhachHang.Properties)).BeginInit();
            this.grpKetQuaTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gListChungTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListChungTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiPhieu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmdExport);
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.bteKhachHang);
            this.groupBox1.Controls.Add(this.lblKhachHang);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmdExport
            // 
            this.cmdExport.Image = ((System.Drawing.Image)(resources.GetObject("cmdExport.Image")));
            this.cmdExport.Location = new System.Drawing.Point(551, 19);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdExport.Size = new System.Drawing.Size(101, 25);
            this.cmdExport.TabIndex = 20;
            this.cmdExport.Text = "Export (F12)";
            this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(658, 19);
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
            this.btnTim.Location = new System.Drawing.Point(444, 19);
            this.btnTim.Name = "btnTim";
            this.btnTim.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnTim.Size = new System.Drawing.Size(101, 25);
            this.btnTim.TabIndex = 19;
            this.btnTim.Text = "&Tìm kiếm (F3)";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // bteKhachHang
            // 
            this.bteKhachHang.Location = new System.Drawing.Point(115, 19);
            this.bteKhachHang.Name = "bteKhachHang";
            this.bteKhachHang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteKhachHang.Properties.Appearance.Options.UseFont = true;
            this.bteKhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteKhachHang.Size = new System.Drawing.Size(314, 22);
            this.bteKhachHang.TabIndex = 12;
            this.bteKhachHang.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteKhachHang_ButtonClick);
            this.bteKhachHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteKhachHang_KeyDown);
            this.bteKhachHang.TextChanged += new System.EventHandler(this.bteKhachHang_TextChanged);
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHang.Location = new System.Drawing.Point(44, 23);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(65, 13);
            this.lblKhachHang.TabIndex = 0;
            this.lblKhachHang.Text = "Khách hàng";
            // 
            // grpKetQuaTimKiem
            // 
            this.grpKetQuaTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKetQuaTimKiem.Controls.Add(this.gListChungTu);
            this.grpKetQuaTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKetQuaTimKiem.ForeColor = System.Drawing.Color.Black;
            this.grpKetQuaTimKiem.Location = new System.Drawing.Point(1, 70);
            this.grpKetQuaTimKiem.Name = "grpKetQuaTimKiem";
            this.grpKetQuaTimKiem.Size = new System.Drawing.Size(1018, 459);
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
            this.gListChungTu.EmbeddedNavigator.TextStringFormat = "{0} / {1}";
            this.gListChungTu.Location = new System.Drawing.Point(6, 19);
            this.gListChungTu.MainView = this.gvListChungTu;
            this.gListChungTu.Name = "gListChungTu";
            this.gListChungTu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLoaiDonHang,
            this.repLoaiPhieu});
            this.gListChungTu.Size = new System.Drawing.Size(1006, 434);
            this.gListChungTu.TabIndex = 0;
            this.gListChungTu.UseEmbeddedNavigator = true;
            this.gListChungTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListChungTu});
            // 
            // gvListChungTu
            // 
            this.gvListChungTu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdDoiTuong,
            this.MaDoiTuong,
            this.TenDoiTuong,
            this.TongHanMucTinDung,
            this.HanMucTinDungConLai,
            this.CongNoBanHang,
            this.NgayCapNhat});
            this.gvListChungTu.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvListChungTu.GridControl = this.gListChungTu;
            this.gvListChungTu.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "SoChungTu", null, "  (Tổng số đơn hàng = {0})"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TongTienThanhToan", null, "  (Tổng doanh thu = {0})"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TienThanhToanThuc", null, "  (Số tiền thu = {0})"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TienConNo", null, "  (Tiền còn nợ = {0})")});
            this.gvListChungTu.Name = "gvListChungTu";
            this.gvListChungTu.OptionsView.ShowAutoFilterRow = true;
            this.gvListChungTu.OptionsView.ShowDetailButtons = false;
            this.gvListChungTu.OptionsView.ShowFooter = true;
            // 
            // IdDoiTuong
            // 
            this.IdDoiTuong.Caption = "IdDoiTuong";
            this.IdDoiTuong.FieldName = "IdDoiTuong";
            this.IdDoiTuong.Name = "IdDoiTuong";
            this.IdDoiTuong.OptionsColumn.ReadOnly = true;
            // 
            // MaDoiTuong
            // 
            this.MaDoiTuong.Caption = "Mã khách hàng";
            this.MaDoiTuong.FieldName = "MaDoiTuong";
            this.MaDoiTuong.Name = "MaDoiTuong";
            this.MaDoiTuong.OptionsColumn.ReadOnly = true;
            this.MaDoiTuong.Visible = true;
            this.MaDoiTuong.VisibleIndex = 0;
            this.MaDoiTuong.Width = 145;
            // 
            // TenDoiTuong
            // 
            this.TenDoiTuong.Caption = "Tên khách hàng";
            this.TenDoiTuong.FieldName = "TenDoiTuong";
            this.TenDoiTuong.Name = "TenDoiTuong";
            this.TenDoiTuong.OptionsColumn.ReadOnly = true;
            this.TenDoiTuong.Visible = true;
            this.TenDoiTuong.VisibleIndex = 1;
            this.TenDoiTuong.Width = 351;
            // 
            // TongHanMucTinDung
            // 
            this.TongHanMucTinDung.Caption = "Tổng hạn mức tín dụng";
            this.TongHanMucTinDung.DisplayFormat.FormatString = "N0";
            this.TongHanMucTinDung.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TongHanMucTinDung.FieldName = "TongHanMucTinDung";
            this.TongHanMucTinDung.Name = "TongHanMucTinDung";
            this.TongHanMucTinDung.OptionsColumn.ReadOnly = true;
            this.TongHanMucTinDung.SummaryItem.DisplayFormat = "{0:N0}";
            this.TongHanMucTinDung.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.TongHanMucTinDung.Visible = true;
            this.TongHanMucTinDung.VisibleIndex = 2;
            this.TongHanMucTinDung.Width = 161;
            // 
            // HanMucTinDungConLai
            // 
            this.HanMucTinDungConLai.Caption = "Hạn mức còn lại";
            this.HanMucTinDungConLai.DisplayFormat.FormatString = "N0";
            this.HanMucTinDungConLai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.HanMucTinDungConLai.FieldName = "HanMucTinDungConLai";
            this.HanMucTinDungConLai.Name = "HanMucTinDungConLai";
            this.HanMucTinDungConLai.OptionsColumn.ReadOnly = true;
            this.HanMucTinDungConLai.SummaryItem.DisplayFormat = "{0:N0}";
            this.HanMucTinDungConLai.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.HanMucTinDungConLai.Visible = true;
            this.HanMucTinDungConLai.VisibleIndex = 3;
            this.HanMucTinDungConLai.Width = 160;
            // 
            // CongNoBanHang
            // 
            this.CongNoBanHang.Caption = "Công nợ khách hàng";
            this.CongNoBanHang.DisplayFormat.FormatString = "N0";
            this.CongNoBanHang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.CongNoBanHang.FieldName = "CongNoBanHang";
            this.CongNoBanHang.Name = "CongNoBanHang";
            this.CongNoBanHang.OptionsColumn.ReadOnly = true;
            this.CongNoBanHang.SummaryItem.DisplayFormat = "{0:N0}";
            this.CongNoBanHang.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.CongNoBanHang.Visible = true;
            this.CongNoBanHang.VisibleIndex = 4;
            this.CongNoBanHang.Width = 173;
            // 
            // NgayCapNhat
            // 
            this.NgayCapNhat.Caption = "Ngày cập nhật";
            this.NgayCapNhat.DisplayFormat.FormatString = "dd/mm/yyyy HH:mm:ss";
            this.NgayCapNhat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgayCapNhat.FieldName = "NgayCapNhat";
            this.NgayCapNhat.Name = "NgayCapNhat";
            this.NgayCapNhat.OptionsColumn.ReadOnly = true;
            this.NgayCapNhat.Visible = true;
            this.NgayCapNhat.VisibleIndex = 5;
            this.NgayCapNhat.Width = 186;
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
            // repLoaiPhieu
            // 
            this.repLoaiPhieu.AutoHeight = false;
            this.repLoaiPhieu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLoaiPhieu.DisplayMember = "Name";
            this.repLoaiPhieu.Name = "repLoaiPhieu";
            this.repLoaiPhieu.ValueMember = "Id";
            // 
            // frmBC_CongNoKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 532);
            this.Controls.Add(this.grpKetQuaTimKiem);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmBC_CongNoKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách công nợ khách hàng";
            this.Load += new System.EventHandler(this.frmBH_TimChungTu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBH_TimChungTu_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhachHang.Properties)).EndInit();
            this.grpKetQuaTimKiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gListChungTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListChungTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiPhieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpKetQuaTimKiem;
        private System.Windows.Forms.Label lblKhachHang;
        internal GtidButton btnDong;
        private GtidButton btnTim;
        private DevExpress.XtraEditors.ButtonEdit bteKhachHang;
        private DevExpress.XtraGrid.GridControl gListChungTu;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListChungTu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLoaiDonHang;
        private GtidButton cmdExport;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLoaiPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn IdDoiTuong;
        private DevExpress.XtraGrid.Columns.GridColumn MaDoiTuong;
        private DevExpress.XtraGrid.Columns.GridColumn TenDoiTuong;
        private DevExpress.XtraGrid.Columns.GridColumn TongHanMucTinDung;
        private DevExpress.XtraGrid.Columns.GridColumn HanMucTinDungConLai;
        private DevExpress.XtraGrid.Columns.GridColumn CongNoBanHang;
        private DevExpress.XtraGrid.Columns.GridColumn NgayCapNhat;
    }
}