using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frmBC_SuDungHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBC_SuDungHoaDon));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoHoaDon = new QLBH.Core.Form.GtidTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdExport = new QLBH.Core.Form.GtidButton();
            this.btnTim = new QLBH.Core.Form.GtidButton();
            this.txtKyHieu = new QLBH.Core.Form.GtidTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bteTrungTam = new DevExpress.XtraEditors.ButtonEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.bteThuongVien = new DevExpress.XtraEditors.ButtonEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new QLBH.Core.Form.GtidButton();
            this.gHoaDon = new DevExpress.XtraGrid.GridControl();
            this.gvHoaDon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdQuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KyHieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoBatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoHienTai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoConLai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThemCT = new QLBH.Core.Form.GtidButton();
            this.cmdXoaChiTiet = new QLBH.Core.Form.GtidButton();
            this.btnSua = new QLBH.Core.Form.GtidButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteThuongVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtSoHoaDon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmdExport);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.txtKyHieu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bteTrungTam);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.bteThuongVien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(11, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 71);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtSoHoaDon
            // 
            this.txtSoHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoHoaDon.Location = new System.Drawing.Point(467, 40);
            this.txtSoHoaDon.Name = "txtSoHoaDon";
            this.txtSoHoaDon.Size = new System.Drawing.Size(123, 20);
            this.txtSoHoaDon.TabIndex = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 126;
            this.label2.Text = "Số hóa đơn";
            // 
            // cmdExport
            // 
            this.cmdExport.Image = ((System.Drawing.Image)(resources.GetObject("cmdExport.Image")));
            this.cmdExport.Location = new System.Drawing.Point(610, 40);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdExport.Size = new System.Drawing.Size(101, 22);
            this.cmdExport.TabIndex = 124;
            this.cmdExport.Text = "Export (F12)";
            this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // btnTim
            // 
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.Location = new System.Drawing.Point(610, 14);
            this.btnTim.Name = "btnTim";
            this.btnTim.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnTim.Size = new System.Drawing.Size(101, 22);
            this.btnTim.TabIndex = 123;
            this.btnTim.Text = "&Tìm kiếm (F3)";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtKyHieu
            // 
            this.txtKyHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKyHieu.Location = new System.Drawing.Point(467, 16);
            this.txtKyHieu.Name = "txtKyHieu";
            this.txtKyHieu.Size = new System.Drawing.Size(123, 20);
            this.txtKyHieu.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 122;
            this.label1.Text = "Ký hiệu";
            // 
            // bteTrungTam
            // 
            this.bteTrungTam.Location = new System.Drawing.Point(96, 14);
            this.bteTrungTam.Name = "bteTrungTam";
            this.bteTrungTam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteTrungTam.Properties.Appearance.Options.UseFont = true;
            this.bteTrungTam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteTrungTam.Size = new System.Drawing.Size(283, 22);
            this.bteTrungTam.TabIndex = 119;
            this.bteTrungTam.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteTrungTam_ButtonClick);
            this.bteTrungTam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteTrungTam_KeyDown);
            this.bteTrungTam.TextChanged += new System.EventHandler(this.bteTrungTam_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 120;
            this.label7.Text = "Trung tâm";
            // 
            // bteThuongVien
            // 
            this.bteThuongVien.Location = new System.Drawing.Point(96, 42);
            this.bteThuongVien.Name = "bteThuongVien";
            this.bteThuongVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteThuongVien.Size = new System.Drawing.Size(283, 20);
            this.bteThuongVien.TabIndex = 16;
            this.bteThuongVien.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteThuongVien_ButtonClick);
            this.bteThuongVien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteThuongVien_KeyDown);
            this.bteThuongVien.TextChanged += new System.EventHandler(this.bteThuongVien_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(4, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tên nhân viên";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(632, 426);
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
            this.gHoaDon.Location = new System.Drawing.Point(11, 79);
            this.gHoaDon.MainView = this.gvHoaDon;
            this.gHoaDon.Name = "gHoaDon";
            this.gHoaDon.Size = new System.Drawing.Size(720, 341);
            this.gHoaDon.TabIndex = 117;
            this.gHoaDon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHoaDon});
            // 
            // gvHoaDon
            // 
            this.gvHoaDon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdQuyen,
            this.IdNhanVien,
            this.MaNhanVien,
            this.TenNhanVien,
            this.KyHieu,
            this.SoBatDau,
            this.SoKetThuc,
            this.SoHienTai,
            this.SoConLai});
            this.gvHoaDon.GridControl = this.gHoaDon;
            this.gvHoaDon.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tong so {SoConLai}", this.SoConLai, "")});
            this.gvHoaDon.Name = "gvHoaDon";
            this.gvHoaDon.OptionsSelection.MultiSelect = true;
            this.gvHoaDon.OptionsView.ShowAutoFilterRow = true;
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
            // MaNhanVien
            // 
            this.MaNhanVien.Caption = "Mã nhân viên";
            this.MaNhanVien.FieldName = "MaNhanVien";
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Visible = true;
            this.MaNhanVien.VisibleIndex = 0;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.Caption = "Tên nhân viên";
            this.TenNhanVien.FieldName = "TenNhanVien";
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.Visible = true;
            this.TenNhanVien.VisibleIndex = 1;
            // 
            // KyHieu
            // 
            this.KyHieu.Caption = "Ký hiệu";
            this.KyHieu.FieldName = "KyHieu";
            this.KyHieu.Name = "KyHieu";
            this.KyHieu.OptionsColumn.ReadOnly = true;
            this.KyHieu.Visible = true;
            this.KyHieu.VisibleIndex = 2;
            // 
            // SoBatDau
            // 
            this.SoBatDau.Caption = "Số bắt đầu";
            this.SoBatDau.FieldName = "SoBatDau";
            this.SoBatDau.Name = "SoBatDau";
            this.SoBatDau.OptionsColumn.AllowEdit = false;
            this.SoBatDau.OptionsColumn.ReadOnly = true;
            this.SoBatDau.Visible = true;
            this.SoBatDau.VisibleIndex = 3;
            // 
            // SoKetThuc
            // 
            this.SoKetThuc.Caption = "Số kết thúc";
            this.SoKetThuc.FieldName = "SoKetThuc";
            this.SoKetThuc.Name = "SoKetThuc";
            this.SoKetThuc.OptionsColumn.AllowEdit = false;
            this.SoKetThuc.OptionsColumn.ReadOnly = true;
            this.SoKetThuc.Visible = true;
            this.SoKetThuc.VisibleIndex = 4;
            // 
            // SoHienTai
            // 
            this.SoHienTai.Caption = "Số hiện tại";
            this.SoHienTai.FieldName = "SoHienTai";
            this.SoHienTai.Name = "SoHienTai";
            this.SoHienTai.OptionsColumn.AllowEdit = false;
            this.SoHienTai.OptionsColumn.ReadOnly = true;
            this.SoHienTai.Visible = true;
            this.SoHienTai.VisibleIndex = 5;
            // 
            // SoConLai
            // 
            this.SoConLai.Caption = "Số còn lại";
            this.SoConLai.FieldName = "SoConLai";
            this.SoConLai.Name = "SoConLai";
            this.SoConLai.OptionsColumn.AllowEdit = false;
            this.SoConLai.Visible = true;
            this.SoConLai.VisibleIndex = 6;
            // 
            // btnThemCT
            // 
            this.btnThemCT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemCT.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCT.Image")));
            this.btnThemCT.Location = new System.Drawing.Point(11, 426);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnThemCT.Size = new System.Drawing.Size(93, 27);
            this.btnThemCT.TabIndex = 65;
            this.btnThemCT.Text = "Thêm chi tiết";
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // cmdXoaChiTiet
            // 
            this.cmdXoaChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdXoaChiTiet.Image = ((System.Drawing.Image)(resources.GetObject("cmdXoaChiTiet.Image")));
            this.cmdXoaChiTiet.Location = new System.Drawing.Point(193, 426);
            this.cmdXoaChiTiet.Name = "cmdXoaChiTiet";
            this.cmdXoaChiTiet.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdXoaChiTiet.Size = new System.Drawing.Size(83, 27);
            this.cmdXoaChiTiet.TabIndex = 64;
            this.cmdXoaChiTiet.Text = "Xóa chi tiết";
            this.cmdXoaChiTiet.Click += new System.EventHandler(this.cmdXoaChiTiet_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(107, 426);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnSua.Size = new System.Drawing.Size(83, 27);
            this.btnSua.TabIndex = 118;
            this.btnSua.Text = "Sửa chi tiết";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmBC_SuDungHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 464);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.gHoaDon);
            this.Controls.Add(this.btnThemCT);
            this.Controls.Add(this.cmdXoaChiTiet);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBC_SuDungHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khai báo sử dụng hóa đơn";
            this.Load += new System.EventHandler(this.frmMoSo_Load);
            this.Activated += new System.EventHandler(this.frmBC_SuDungHoaDon_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteThuongVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private QLBH.Core.Form.GtidButton btnClose;
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
        private GtidButton btnSua;
        private DevExpress.XtraGrid.Columns.GridColumn MaNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn TenNhanVien;
        private DevExpress.XtraEditors.ButtonEdit bteThuongVien;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.ButtonEdit bteTrungTam;
        private System.Windows.Forms.Label label7;
        private GtidTextBox txtKyHieu;
        private System.Windows.Forms.Label label1;
        private GtidButton btnTim;
        private GtidButton cmdExport;
        private GtidTextBox txtSoHoaDon;
        private System.Windows.Forms.Label label2;
    }
}