using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frmBH_BangGiaBanHang_TonCTiet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBH_BangGiaBanHang_TonCTiet));
            this.cmdDong = new QLBH.Core.Form.GtidButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gTonKho = new DevExpress.XtraGrid.GridControl();
            this.gvTonKho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTonThat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTonAo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCheckKM = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gChinhSach = new DevExpress.XtraGrid.GridControl();
            this.gvChinhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBanLe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBanBuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBanDemo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.txtSanPham = new QLBH.Core.Form.GtidTextBox();
            this.lbMaSanPham = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDonViTinh = new QLBH.Core.Form.GtidTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtVAT = new QLBH.Core.Form.GtidTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gTonKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTonKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckKM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gChinhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChinhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdDong
            // 
            this.cmdDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDong.Image = ((System.Drawing.Image)(resources.GetObject("cmdDong.Image")));
            this.cmdDong.Location = new System.Drawing.Point(634, 572);
            this.cmdDong.Name = "cmdDong";
            this.cmdDong.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdDong.Size = new System.Drawing.Size(86, 25);
            this.cmdDong.TabIndex = 63;
            this.cmdDong.Text = "T&hoát (ESC)";
            this.cmdDong.Click += new System.EventHandler(this.cmdDong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.gTonKho);
            this.groupBox1.Location = new System.Drawing.Point(4, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 341);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết tồn kho";
            // 
            // gTonKho
            // 
            this.gTonKho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gTonKho.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gTonKho.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gTonKho.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gTonKho.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gTonKho.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gTonKho.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gTonKho.Location = new System.Drawing.Point(6, 17);
            this.gTonKho.MainView = this.gvTonKho;
            this.gTonKho.Name = "gTonKho";
            this.gTonKho.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCheckKM});
            this.gTonKho.Size = new System.Drawing.Size(719, 318);
            this.gTonKho.TabIndex = 92;
            this.gTonKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTonKho,
            this.gridView1});
            // 
            // gvTonKho
            // 
            this.gvTonKho.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvTonKho.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvTonKho.Appearance.FocusedCell.Options.UseFont = true;
            this.gvTonKho.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvTonKho.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvTonKho.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvTonKho.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvTonKho.Appearance.Row.BackColor = System.Drawing.Color.Silver;
            this.gvTonKho.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvTonKho.Appearance.Row.Options.UseBackColor = true;
            this.gvTonKho.Appearance.Row.Options.UseBorderColor = true;
            this.gvTonKho.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvTonKho.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvTonKho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTrungTam,
            this.colTenTrungTam,
            this.colIdKho,
            this.colMaKho,
            this.colTenKho,
            this.colTonThat,
            this.colTonAo});
            this.gvTonKho.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvTonKho.GridControl = this.gTonKho;
            this.gvTonKho.GroupCount = 1;
            this.gvTonKho.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TonThat", null, "(Tồn thật = {0})"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TonAo", null, "(Tồn ảo = {0})")});
            this.gvTonKho.Name = "gvTonKho";
            this.gvTonKho.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvTonKho.OptionsSelection.MultiSelect = true;
            this.gvTonKho.OptionsView.ColumnAutoWidth = false;
            this.gvTonKho.OptionsView.ShowDetailButtons = false;
            this.gvTonKho.OptionsView.ShowFooter = true;
            this.gvTonKho.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTenTrungTam, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdTrungTam
            // 
            this.colIdTrungTam.Caption = "IdTrungTam";
            this.colIdTrungTam.FieldName = "IdTrungTam";
            this.colIdTrungTam.Name = "colIdTrungTam";
            this.colIdTrungTam.OptionsColumn.ReadOnly = true;
            // 
            // colTenTrungTam
            // 
            this.colTenTrungTam.Caption = "Trung tâm";
            this.colTenTrungTam.FieldName = "TenTrungTam";
            this.colTenTrungTam.Name = "colTenTrungTam";
            this.colTenTrungTam.OptionsColumn.ReadOnly = true;
            this.colTenTrungTam.Visible = true;
            this.colTenTrungTam.VisibleIndex = 0;
            this.colTenTrungTam.Width = 180;
            // 
            // colIdKho
            // 
            this.colIdKho.Caption = "IdKho";
            this.colIdKho.FieldName = "IdKho";
            this.colIdKho.Name = "colIdKho";
            this.colIdKho.OptionsColumn.ReadOnly = true;
            // 
            // colMaKho
            // 
            this.colMaKho.Caption = "Mã kho";
            this.colMaKho.FieldName = "MaKho";
            this.colMaKho.Name = "colMaKho";
            this.colMaKho.OptionsColumn.ReadOnly = true;
            this.colMaKho.Width = 96;
            // 
            // colTenKho
            // 
            this.colTenKho.Caption = "Tên kho";
            this.colTenKho.FieldName = "TenKho";
            this.colTenKho.Name = "colTenKho";
            this.colTenKho.OptionsColumn.ReadOnly = true;
            this.colTenKho.Visible = true;
            this.colTenKho.VisibleIndex = 0;
            this.colTenKho.Width = 454;
            // 
            // colTonThat
            // 
            this.colTonThat.Caption = "Tồn kho";
            this.colTonThat.FieldName = "TonThat";
            this.colTonThat.Name = "colTonThat";
            this.colTonThat.OptionsColumn.ReadOnly = true;
            this.colTonThat.SummaryItem.DisplayFormat = "{0}";
            this.colTonThat.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTonThat.Visible = true;
            this.colTonThat.VisibleIndex = 1;
            this.colTonThat.Width = 96;
            // 
            // colTonAo
            // 
            this.colTonAo.Caption = "Tồn ảo";
            this.colTonAo.FieldName = "TonAo";
            this.colTonAo.Name = "colTonAo";
            this.colTonAo.OptionsColumn.ReadOnly = true;
            this.colTonAo.SummaryItem.DisplayFormat = "{0}";
            this.colTonAo.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTonAo.Visible = true;
            this.colTonAo.VisibleIndex = 2;
            this.colTonAo.Width = 107;
            // 
            // repCheckKM
            // 
            this.repCheckKM.AutoHeight = false;
            this.repCheckKM.Name = "repCheckKM";
            this.repCheckKM.ValueChecked = 1;
            this.repCheckKM.ValueUnchecked = 0;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gTonKho;
            this.gridView1.Name = "gridView1";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.gChinhSach);
            this.groupBox2.Location = new System.Drawing.Point(4, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(731, 156);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giá bán";
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
            this.gChinhSach.Location = new System.Drawing.Point(6, 17);
            this.gChinhSach.MainView = this.gvChinhSach;
            this.gChinhSach.Name = "gChinhSach";
            this.gChinhSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gChinhSach.Size = new System.Drawing.Size(718, 133);
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
            this.IdTrungTam,
            this.TenTrungTam,
            this.GiaBanLe,
            this.GiaBanBuon,
            this.GiaBanDemo});
            this.gvChinhSach.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvChinhSach.GridControl = this.gChinhSach;
            this.gvChinhSach.Name = "gvChinhSach";
            this.gvChinhSach.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvChinhSach.OptionsView.ShowDetailButtons = false;
            this.gvChinhSach.OptionsView.ShowGroupPanel = false;
            // 
            // IdTrungTam
            // 
            this.IdTrungTam.Caption = "IdTrungTam";
            this.IdTrungTam.FieldName = "IdTrungTam";
            this.IdTrungTam.Name = "IdTrungTam";
            this.IdTrungTam.OptionsColumn.ReadOnly = true;
            // 
            // TenTrungTam
            // 
            this.TenTrungTam.Caption = "Trung tâm";
            this.TenTrungTam.FieldName = "TenTrungTam";
            this.TenTrungTam.Name = "TenTrungTam";
            this.TenTrungTam.OptionsColumn.ReadOnly = true;
            this.TenTrungTam.Visible = true;
            this.TenTrungTam.VisibleIndex = 0;
            // 
            // GiaBanLe
            // 
            this.GiaBanLe.Caption = "Giá bán lẻ";
            this.GiaBanLe.FieldName = "GiaBanLe";
            this.GiaBanLe.Name = "GiaBanLe";
            this.GiaBanLe.OptionsColumn.ReadOnly = true;
            this.GiaBanLe.Visible = true;
            this.GiaBanLe.VisibleIndex = 1;
            // 
            // GiaBanBuon
            // 
            this.GiaBanBuon.Caption = "Giá bán buôn";
            this.GiaBanBuon.FieldName = "GiaBanBuon";
            this.GiaBanBuon.Name = "GiaBanBuon";
            this.GiaBanBuon.OptionsColumn.ReadOnly = true;
            this.GiaBanBuon.Visible = true;
            this.GiaBanBuon.VisibleIndex = 2;
            // 
            // GiaBanDemo
            // 
            this.GiaBanDemo.Caption = "Giá bán Demo";
            this.GiaBanDemo.FieldName = "GiaBanDemo";
            this.GiaBanDemo.Name = "GiaBanDemo";
            this.GiaBanDemo.OptionsColumn.ReadOnly = true;
            this.GiaBanDemo.Visible = true;
            this.GiaBanDemo.VisibleIndex = 3;
            this.GiaBanDemo.Width = 130;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // txtSanPham
            // 
            this.txtSanPham.BackColor = System.Drawing.SystemColors.Window;
            this.txtSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSanPham.Location = new System.Drawing.Point(88, 12);
            this.txtSanPham.Multiline = true;
            this.txtSanPham.Name = "txtSanPham";
            this.txtSanPham.ReadOnly = true;
            this.txtSanPham.Size = new System.Drawing.Size(464, 45);
            this.txtSanPham.TabIndex = 77;
            // 
            // lbMaSanPham
            // 
            this.lbMaSanPham.AutoSize = true;
            this.lbMaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSanPham.Location = new System.Drawing.Point(19, 12);
            this.lbMaSanPham.Name = "lbMaSanPham";
            this.lbMaSanPham.Size = new System.Drawing.Size(63, 13);
            this.lbMaSanPham.TabIndex = 76;
            this.lbMaSanPham.Text = "Sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label4.Location = new System.Drawing.Point(558, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 135;
            this.label4.Text = "Đơn vị tính";
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.BackColor = System.Drawing.SystemColors.Window;
            this.txtDonViTinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDonViTinh.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonViTinh.Location = new System.Drawing.Point(624, 16);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.ReadOnly = true;
            this.txtDonViTinh.Size = new System.Drawing.Size(102, 15);
            this.txtDonViTinh.TabIndex = 133;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label19.Location = new System.Drawing.Point(565, 41);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 13);
            this.label19.TabIndex = 134;
            this.label19.Text = "Tỷ lệ VAT";
            // 
            // txtVAT
            // 
            this.txtVAT.BackColor = System.Drawing.SystemColors.Window;
            this.txtVAT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVAT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVAT.Location = new System.Drawing.Point(624, 41);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.ReadOnly = true;
            this.txtVAT.Size = new System.Drawing.Size(102, 15);
            this.txtVAT.TabIndex = 132;
            this.txtVAT.Text = "VAT";
            // 
            // frmBH_BangGiaBanHang_TonCTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 603);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(this.txtSanPham);
            this.Controls.Add(this.lbMaSanPham);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdDong);
            this.Controls.Add(this.groupBox2);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBH_BangGiaBanHang_TonCTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập chính sách khuyến mại";
            this.Load += new System.EventHandler(this.frm_ThietLapKM_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_ThietLapKM_KeyDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gTonKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTonKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckKM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gChinhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChinhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal GtidButton cmdDong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gTonKho;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTonKho;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckKM;
        private DevExpress.XtraGrid.GridControl gChinhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChinhSach;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private GtidTextBox txtSanPham;
        private System.Windows.Forms.Label lbMaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn IdTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn TenTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBanLe;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBanBuon;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBanDemo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn colIdKho;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKho;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKho;
        private DevExpress.XtraGrid.Columns.GridColumn colTonThat;
        private DevExpress.XtraGrid.Columns.GridColumn colTonAo;
        private System.Windows.Forms.Label label4;
        private GtidTextBox txtDonViTinh;
        private System.Windows.Forms.Label label19;
        private GtidTextBox txtVAT;
    }
}