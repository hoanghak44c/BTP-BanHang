using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frmCS_SuDungHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCS_SuDungHoaDon));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new QLBH.Core.Form.GtidButton();
            this.btnClose = new QLBH.Core.Form.GtidButton();
            this.gHoaDon = new DevExpress.XtraGrid.GridControl();
            this.gvHoaDon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdQuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KyHieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoBatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoHienTai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoConLai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThemCT = new QLBH.Core.Form.GtidButton();
            this.cmdXoaChiTiet = new QLBH.Core.Form.GtidButton();
            this.btnSua = new QLBH.Core.Form.GtidButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNhanVien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 55);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(125, 19);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.ReadOnly = true;
            this.txtNhanVien.Size = new System.Drawing.Size(378, 20);
            this.txtNhanVien.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhân viên";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(411, 310);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnSave.Size = new System.Drawing.Size(90, 27);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Cập nhật";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(504, 310);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnClose.Size = new System.Drawing.Size(90, 27);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gHoaDon
            // 
            this.gHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gHoaDon.Location = new System.Drawing.Point(6, 64);
            this.gHoaDon.MainView = this.gvHoaDon;
            this.gHoaDon.Name = "gHoaDon";
            this.gHoaDon.Size = new System.Drawing.Size(588, 240);
            this.gHoaDon.TabIndex = 117;
            this.gHoaDon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHoaDon});
            // 
            // gvHoaDon
            // 
            this.gvHoaDon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdQuyen,
            this.IdNhanVien,
            this.KyHieu,
            this.SoBatDau,
            this.SoKetThuc,
            this.SoHienTai,
            this.SoConLai,
            this.TrangThai});
            this.gvHoaDon.GridControl = this.gHoaDon;
            this.gvHoaDon.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tong so {SoConLai}", this.SoConLai, "")});
            this.gvHoaDon.Name = "gvHoaDon";
            this.gvHoaDon.OptionsSelection.MultiSelect = true;
            this.gvHoaDon.OptionsView.ShowAutoFilterRow = true;
            this.gvHoaDon.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.TrangThai, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvHoaDon.DoubleClick += new System.EventHandler(this.gvHoaDon_DoubleClick);
            // 
            // IdQuyen
            // 
            this.IdQuyen.Caption = "IdQuyen";
            this.IdQuyen.FieldName = "IdQuyen";
            this.IdQuyen.Name = "IdQuyen";
            // 
            // IdNhanVien
            // 
            this.IdNhanVien.Caption = "IdNhanVien";
            this.IdNhanVien.FieldName = "IdNhanVien";
            this.IdNhanVien.Name = "IdNhanVien";
            // 
            // KyHieu
            // 
            this.KyHieu.Caption = "Ký hiệu";
            this.KyHieu.FieldName = "KyHieu";
            this.KyHieu.Name = "KyHieu";
            this.KyHieu.OptionsColumn.ReadOnly = true;
            this.KyHieu.Visible = true;
            this.KyHieu.VisibleIndex = 0;
            // 
            // SoBatDau
            // 
            this.SoBatDau.Caption = "Số bắt đầu";
            this.SoBatDau.FieldName = "SoBatDau";
            this.SoBatDau.Name = "SoBatDau";
            this.SoBatDau.OptionsColumn.AllowEdit = false;
            this.SoBatDau.OptionsColumn.ReadOnly = true;
            this.SoBatDau.Visible = true;
            this.SoBatDau.VisibleIndex = 1;
            // 
            // SoKetThuc
            // 
            this.SoKetThuc.Caption = "Số kết thúc";
            this.SoKetThuc.FieldName = "SoKetThuc";
            this.SoKetThuc.Name = "SoKetThuc";
            this.SoKetThuc.OptionsColumn.AllowEdit = false;
            this.SoKetThuc.OptionsColumn.ReadOnly = true;
            this.SoKetThuc.Visible = true;
            this.SoKetThuc.VisibleIndex = 2;
            // 
            // SoHienTai
            // 
            this.SoHienTai.Caption = "Số hiện tại";
            this.SoHienTai.FieldName = "SoHienTai";
            this.SoHienTai.Name = "SoHienTai";
            this.SoHienTai.OptionsColumn.AllowEdit = false;
            this.SoHienTai.OptionsColumn.ReadOnly = true;
            this.SoHienTai.Visible = true;
            this.SoHienTai.VisibleIndex = 3;
            // 
            // SoConLai
            // 
            this.SoConLai.Caption = "Số còn lại";
            this.SoConLai.FieldName = "SoConLai";
            this.SoConLai.Name = "SoConLai";
            this.SoConLai.OptionsColumn.AllowEdit = false;
            this.SoConLai.Visible = true;
            this.SoConLai.VisibleIndex = 4;
            // 
            // TrangThai
            // 
            this.TrangThai.Caption = "Trạng thái";
            this.TrangThai.FieldName = "TrangThai";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Visible = true;
            this.TrangThai.VisibleIndex = 5;
            // 
            // btnThemCT
            // 
            this.btnThemCT.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCT.Image")));
            this.btnThemCT.Location = new System.Drawing.Point(7, 310);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnThemCT.Size = new System.Drawing.Size(93, 27);
            this.btnThemCT.TabIndex = 65;
            this.btnThemCT.Text = "Thêm chi tiết";
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // cmdXoaChiTiet
            // 
            this.cmdXoaChiTiet.Image = ((System.Drawing.Image)(resources.GetObject("cmdXoaChiTiet.Image")));
            this.cmdXoaChiTiet.Location = new System.Drawing.Point(189, 310);
            this.cmdXoaChiTiet.Name = "cmdXoaChiTiet";
            this.cmdXoaChiTiet.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdXoaChiTiet.Size = new System.Drawing.Size(83, 27);
            this.cmdXoaChiTiet.TabIndex = 64;
            this.cmdXoaChiTiet.Text = "Xóa chi tiết";
            this.cmdXoaChiTiet.Click += new System.EventHandler(this.cmdXoaChiTiet_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(103, 310);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnSua.Size = new System.Drawing.Size(83, 27);
            this.btnSua.TabIndex = 118;
            this.btnSua.Text = "Sửa chi tiết";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmCS_SuDungHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 345);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.gHoaDon);
            this.Controls.Add(this.btnThemCT);
            this.Controls.Add(this.cmdXoaChiTiet);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCS_SuDungHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khai báo sử dụng hóa đơn";
            this.Load += new System.EventHandler(this.frmMoSo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private QLBH.Core.Form.GtidButton btnSave;
        private QLBH.Core.Form.GtidButton btnClose;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl gHoaDon;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn IdQuyen;
        private DevExpress.XtraGrid.Columns.GridColumn IdNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn KyHieu;
        private DevExpress.XtraGrid.Columns.GridColumn SoBatDau;
        private DevExpress.XtraGrid.Columns.GridColumn SoKetThuc;
        private DevExpress.XtraGrid.Columns.GridColumn SoHienTai;
        private DevExpress.XtraGrid.Columns.GridColumn SoConLai;
        private GtidButton btnThemCT;
        private GtidButton cmdXoaChiTiet;
        private System.Windows.Forms.TextBox txtNhanVien;
        private GtidButton btnSua;
        private DevExpress.XtraGrid.Columns.GridColumn TrangThai;
    }
}