using System.Drawing;
using QLBH.Core.Form;
namespace QLBanHang.Modules.BanHang
{
    partial class frmBH_LapDonHangGiaoNhan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBH_LapDonHangGiaoNhan));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaSanPham = new QLBH.Core.Form.GtidTextBox();
            this.btnThemHang = new QLBH.Core.Form.GtidButton();
            this.label9 = new System.Windows.Forms.Label();
            this.grSanPhamBan = new System.Windows.Forms.GroupBox();
            this.btnXoaMaHang = new QLBH.Core.Form.GtidButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gHangGiaoVan = new DevExpress.XtraGrid.GridControl();
            this.gvHangGiaoNhan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdChungTuChiTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grHangKhuyenMai = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gHangCanXuat = new DevExpress.XtraGrid.GridControl();
            this.gvHangCanXuat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.KhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayHenGiaoHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdChiTietChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSanPhamB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaSanPhamB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPhamB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSanPhamBanB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPhamBanB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiHangHoaB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViTinhB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongBanB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrungMaVach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiDonHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLoaiDonHang = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbConfirm = new System.Windows.Forms.ToolStripButton();
            this.tsbSuaGN = new System.Windows.Forms.ToolStripButton();
            this.tsbXacNhanGN = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslInfor = new System.Windows.Forms.ToolStripLabel();
            this.label17 = new System.Windows.Forms.Label();
            this.bteKhoXuat = new DevExpress.XtraEditors.ButtonEdit();
            this.mstNgayLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox4 = new QLBH.Core.Form.GtidTextBox();
            this.textBox5 = new QLBH.Core.Form.GtidTextBox();
            this.textBox6 = new QLBH.Core.Form.GtidTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDraft = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtabHangGiaoNhan = new DevExpress.XtraTab.XtraTabControl();
            this.xtabPhanCongGiaoNhan = new DevExpress.XtraTab.XtraTabPage();
            this.mstThoiGianGiaoDen = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.mstThoiGianGiaoTu = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSoPhieuPCGN = new QLBH.Common.UserControls.UCCodeGenerate();
            this.btnGhiChu = new QLBH.Core.Form.GtidButton();
            this.cboTinhTrangGN = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGhiChuPNGN = new QLBH.Core.Form.GtidTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mstNgayHoanThanh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.mstNgayPhanCong = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.gPhanCongGiaoNhan = new DevExpress.XtraGrid.GridControl();
            this.gvPhanCongGiaoNhan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdDoiTac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaDoiTac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDoiTac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhanVienDoiTac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdQuanHuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenQuanHuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaVungMien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenVungMien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaPhuongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenPhuongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBienSoXe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiCongViec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdNhanVien2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNhanVien2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdNhanVien3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNhanVien3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdLaiXe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaLaiXe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLaiXe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnXoaPCGN = new QLBH.Core.Form.GtidButton();
            this.btnPhanCongGN = new QLBH.Core.Form.GtidButton();
            this.xtabHangKemGiaoNhan = new DevExpress.XtraTab.XtraTabPage();
            this.txtSoOrderKH = new QLBH.Common.UserControls.UCCodeGenerate();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGhiChu = new QLBH.Core.Form.GtidTextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grSanPhamBan.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gHangGiaoVan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHangGiaoNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.grHangKhuyenMai.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gHangCanXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHangCanXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhoXuat.Properties)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtabHangGiaoNhan)).BeginInit();
            this.xtabHangGiaoNhan.SuspendLayout();
            this.xtabPhanCongGiaoNhan.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gPhanCongGiaoNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhanCongGiaoNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.xtabHangKemGiaoNhan.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(765, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng tiền";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(766, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng tiền";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(765, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tổng tiền";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.RowHeadersWidth = 25;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowTemplate.Height = 20;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(874, 259);
            this.dataGridView1.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SoTT";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "Số TT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaThuoc";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã thuốc";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TenThuoc";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên thuốc";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 270;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TenDonViTinhMoi";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn4.HeaderText = "Đơn vị tính";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 66;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "HanDung";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn5.HeaderText = "Hạn dùng";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SoLuong";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn6.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 60;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DonGia";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn7.HeaderText = "Đơn giá";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "TLCK(%)";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn9.HeaderText = "Thành tiền";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaSanPham.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMaSanPham.Enabled = false;
            this.txtMaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSanPham.Location = new System.Drawing.Point(88, 19);
            this.txtMaSanPham.Multiline = true;
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(429, 26);
            this.txtMaSanPham.TabIndex = 0;
            this.txtMaSanPham.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaSanPham_KeyDown);
            this.txtMaSanPham.Leave += new System.EventHandler(this.txtMaSanPham_Leave);
            this.txtMaSanPham.Enter += new System.EventHandler(this.txtMaSanPham_Enter);
            // 
            // btnThemHang
            // 
            this.btnThemHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemHang.Enabled = false;
            this.btnThemHang.Image = ((System.Drawing.Image)(resources.GetObject("btnThemHang.Image")));
            this.btnThemHang.Location = new System.Drawing.Point(523, 18);
            this.btnThemHang.Name = "btnThemHang";
            this.btnThemHang.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnThemHang.Size = new System.Drawing.Size(101, 28);
            this.btnThemHang.TabIndex = 1;
            this.btnThemHang.Text = "&Thêm mã hàng";
            this.btnThemHang.Click += new System.EventHandler(this.btnThemHang_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(11, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sản phẩm";
            // 
            // grSanPhamBan
            // 
            this.grSanPhamBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grSanPhamBan.Controls.Add(this.txtMaSanPham);
            this.grSanPhamBan.Controls.Add(this.btnXoaMaHang);
            this.grSanPhamBan.Controls.Add(this.btnThemHang);
            this.grSanPhamBan.Controls.Add(this.tableLayoutPanel1);
            this.grSanPhamBan.Controls.Add(this.label9);
            this.grSanPhamBan.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.grSanPhamBan.ForeColor = System.Drawing.Color.Black;
            this.grSanPhamBan.Location = new System.Drawing.Point(3, 55);
            this.grSanPhamBan.Name = "grSanPhamBan";
            this.grSanPhamBan.Size = new System.Drawing.Size(1068, 233);
            this.grSanPhamBan.TabIndex = 5;
            this.grSanPhamBan.TabStop = false;
            this.grSanPhamBan.Text = "Danh sách mặt hàng kèm giao vận";
            // 
            // btnXoaMaHang
            // 
            this.btnXoaMaHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaMaHang.Enabled = false;
            this.btnXoaMaHang.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaMaHang.Image")));
            this.btnXoaMaHang.Location = new System.Drawing.Point(951, 18);
            this.btnXoaMaHang.Name = "btnXoaMaHang";
            this.btnXoaMaHang.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnXoaMaHang.Size = new System.Drawing.Size(108, 28);
            this.btnXoaMaHang.TabIndex = 2;
            this.btnXoaMaHang.Text = "Xóa mã hàng";
            this.btnXoaMaHang.Click += new System.EventHandler(this.btnXoaMaVach_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gHangGiaoVan, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 52);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1053, 175);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gHangGiaoVan
            // 
            this.gHangGiaoVan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gHangGiaoVan.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gHangGiaoVan.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gHangGiaoVan.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gHangGiaoVan.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gHangGiaoVan.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gHangGiaoVan.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gHangGiaoVan.Location = new System.Drawing.Point(3, 3);
            this.gHangGiaoVan.MainView = this.gvHangGiaoNhan;
            this.gHangGiaoVan.Name = "gHangGiaoVan";
            this.gHangGiaoVan.Size = new System.Drawing.Size(1047, 169);
            this.gHangGiaoVan.TabIndex = 0;
            this.gHangGiaoVan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHangGiaoNhan,
            this.gridView1});
            // 
            // gvHangGiaoNhan
            // 
            this.gvHangGiaoNhan.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvHangGiaoNhan.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvHangGiaoNhan.Appearance.FocusedCell.Options.UseFont = true;
            this.gvHangGiaoNhan.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvHangGiaoNhan.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvHangGiaoNhan.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvHangGiaoNhan.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvHangGiaoNhan.Appearance.Row.BackColor = System.Drawing.Color.Silver;
            this.gvHangGiaoNhan.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvHangGiaoNhan.Appearance.Row.Options.UseBackColor = true;
            this.gvHangGiaoNhan.Appearance.Row.Options.UseBorderColor = true;
            this.gvHangGiaoNhan.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvHangGiaoNhan.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvHangGiaoNhan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdChungTuChiTiet,
            this.IdSanPham,
            this.MaSanPham,
            this.TenSanPham,
            this.DonViTinh,
            this.SoLuong,
            this.GhiChu});
            this.gvHangGiaoNhan.CustomizationFormBounds = new System.Drawing.Rectangle(808, 316, 216, 178);
            this.gvHangGiaoNhan.GridControl = this.gHangGiaoVan;
            this.gvHangGiaoNhan.Name = "gvHangGiaoNhan";
            this.gvHangGiaoNhan.OptionsSelection.InvertSelection = true;
            this.gvHangGiaoNhan.OptionsSelection.MultiSelect = true;
            this.gvHangGiaoNhan.OptionsView.ColumnAutoWidth = false;
            this.gvHangGiaoNhan.OptionsView.ShowAutoFilterRow = true;
            this.gvHangGiaoNhan.OptionsView.ShowDetailButtons = false;
            this.gvHangGiaoNhan.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvHangDaXuat_CellValueChanged);
            // 
            // IdChungTuChiTiet
            // 
            this.IdChungTuChiTiet.Caption = "IdChungTuChiTiet";
            this.IdChungTuChiTiet.FieldName = "IdChungTuChiTiet";
            this.IdChungTuChiTiet.Name = "IdChungTuChiTiet";
            // 
            // IdSanPham
            // 
            this.IdSanPham.Caption = "IdSanPham";
            this.IdSanPham.FieldName = "IdSanPham";
            this.IdSanPham.Name = "IdSanPham";
            // 
            // MaSanPham
            // 
            this.MaSanPham.Caption = "Mã sản phẩm";
            this.MaSanPham.FieldName = "MaSanPham";
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.OptionsColumn.ReadOnly = true;
            this.MaSanPham.Visible = true;
            this.MaSanPham.VisibleIndex = 0;
            this.MaSanPham.Width = 130;
            // 
            // TenSanPham
            // 
            this.TenSanPham.Caption = "Tên sản phẩm";
            this.TenSanPham.FieldName = "TenSanPham";
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.OptionsColumn.ReadOnly = true;
            this.TenSanPham.Visible = true;
            this.TenSanPham.VisibleIndex = 1;
            this.TenSanPham.Width = 285;
            // 
            // DonViTinh
            // 
            this.DonViTinh.Caption = "Đơn vị tính";
            this.DonViTinh.FieldName = "DonViTinh";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.OptionsColumn.ReadOnly = true;
            this.DonViTinh.Visible = true;
            this.DonViTinh.VisibleIndex = 2;
            this.DonViTinh.Width = 90;
            // 
            // SoLuong
            // 
            this.SoLuong.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.SoLuong.AppearanceCell.Options.UseBackColor = true;
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.DisplayFormat.FormatString = "N0";
            this.SoLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 3;
            this.SoLuong.Width = 78;
            // 
            // GhiChu
            // 
            this.GhiChu.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.GhiChu.AppearanceCell.Options.UseBackColor = true;
            this.GhiChu.Caption = "Ghi chú";
            this.GhiChu.FieldName = "GhiChu";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Visible = true;
            this.GhiChu.VisibleIndex = 4;
            this.GhiChu.Width = 296;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gHangGiaoVan;
            this.gridView1.Name = "gridView1";
            // 
            // grHangKhuyenMai
            // 
            this.grHangKhuyenMai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grHangKhuyenMai.Controls.Add(this.tableLayoutPanel3);
            this.grHangKhuyenMai.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.grHangKhuyenMai.ForeColor = System.Drawing.Color.Black;
            this.grHangKhuyenMai.Location = new System.Drawing.Point(0, 352);
            this.grHangKhuyenMai.Name = "grHangKhuyenMai";
            this.grHangKhuyenMai.Size = new System.Drawing.Size(1081, 258);
            this.grHangKhuyenMai.TabIndex = 1;
            this.grHangKhuyenMai.TabStop = false;
            this.grHangKhuyenMai.Text = "Danh sách mặt hàng bán cần xuất";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.gHangCanXuat, 0, 0);
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(9, 17);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1064, 240);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // gHangCanXuat
            // 
            this.gHangCanXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gHangCanXuat.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gHangCanXuat.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gHangCanXuat.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gHangCanXuat.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gHangCanXuat.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gHangCanXuat.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gHangCanXuat.Location = new System.Drawing.Point(3, 3);
            this.gHangCanXuat.MainView = this.gvHangCanXuat;
            this.gHangCanXuat.Name = "gHangCanXuat";
            this.gHangCanXuat.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLoaiDonHang});
            this.gHangCanXuat.Size = new System.Drawing.Size(1058, 234);
            this.gHangCanXuat.TabIndex = 0;
            this.gHangCanXuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHangCanXuat,
            this.gridView3});
            // 
            // gvHangCanXuat
            // 
            this.gvHangCanXuat.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvHangCanXuat.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvHangCanXuat.Appearance.FocusedCell.Options.UseFont = true;
            this.gvHangCanXuat.Appearance.GroupRow.BackColor = System.Drawing.Color.White;
            this.gvHangCanXuat.Appearance.GroupRow.BackColor2 = System.Drawing.Color.White;
            this.gvHangCanXuat.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvHangCanXuat.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gvHangCanXuat.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvHangCanXuat.Appearance.GroupRow.Options.UseFont = true;
            this.gvHangCanXuat.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvHangCanXuat.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvHangCanXuat.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvHangCanXuat.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvHangCanXuat.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvHangCanXuat.Appearance.Row.BackColor = System.Drawing.Color.Silver;
            this.gvHangCanXuat.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvHangCanXuat.Appearance.Row.Options.UseBackColor = true;
            this.gvHangCanXuat.Appearance.Row.Options.UseBorderColor = true;
            this.gvHangCanXuat.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvHangCanXuat.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvHangCanXuat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.KhachHang,
            this.NgayLap,
            this.IdChungTu,
            this.SoChungTu,
            this.NgayHenGiaoHang,
            this.IdChiTietChungTu,
            this.IdSanPhamB,
            this.MaSanPhamB,
            this.TenSanPhamB,
            this.IdSanPhamBanB,
            this.TenSanPhamBanB,
            this.LoaiHangHoaB,
            this.DonViTinhB,
            this.SoLuongBanB,
            this.TrungMaVach,
            this.LoaiDonHang});
            this.gvHangCanXuat.CustomizationFormBounds = new System.Drawing.Rectangle(808, 316, 216, 178);
            this.gvHangCanXuat.GridControl = this.gHangCanXuat;
            this.gvHangCanXuat.GroupCount = 1;
            this.gvHangCanXuat.Name = "gvHangCanXuat";
            this.gvHangCanXuat.OptionsSelection.InvertSelection = true;
            this.gvHangCanXuat.OptionsSelection.MultiSelect = true;
            this.gvHangCanXuat.OptionsView.ColumnAutoWidth = false;
            this.gvHangCanXuat.OptionsView.ShowAutoFilterRow = true;
            this.gvHangCanXuat.OptionsView.ShowDetailButtons = false;
            this.gvHangCanXuat.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.KhachHang, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // KhachHang
            // 
            this.KhachHang.Caption = "Khách hàng";
            this.KhachHang.FieldName = "KhachHang";
            this.KhachHang.Name = "KhachHang";
            // 
            // NgayLap
            // 
            this.NgayLap.Caption = "Ngày lập";
            this.NgayLap.FieldName = "NgayLap";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Visible = true;
            this.NgayLap.VisibleIndex = 0;
            this.NgayLap.Width = 107;
            // 
            // IdChungTu
            // 
            this.IdChungTu.Caption = "IdChungTu";
            this.IdChungTu.FieldName = "IdChungTu";
            this.IdChungTu.Name = "IdChungTu";
            // 
            // SoChungTu
            // 
            this.SoChungTu.Caption = "Số giao dịch";
            this.SoChungTu.FieldName = "SoChungTu";
            this.SoChungTu.Name = "SoChungTu";
            this.SoChungTu.Visible = true;
            this.SoChungTu.VisibleIndex = 1;
            this.SoChungTu.Width = 191;
            // 
            // NgayHenGiaoHang
            // 
            this.NgayHenGiaoHang.Caption = "Ngày hẹn giao hàng";
            this.NgayHenGiaoHang.FieldName = "NgayHenGiaoHang";
            this.NgayHenGiaoHang.Name = "NgayHenGiaoHang";
            this.NgayHenGiaoHang.Visible = true;
            this.NgayHenGiaoHang.VisibleIndex = 2;
            this.NgayHenGiaoHang.Width = 158;
            // 
            // IdChiTietChungTu
            // 
            this.IdChiTietChungTu.Caption = "IdChungTuChiTiet";
            this.IdChiTietChungTu.FieldName = "IdChungTuChiTiet";
            this.IdChiTietChungTu.Name = "IdChiTietChungTu";
            // 
            // IdSanPhamB
            // 
            this.IdSanPhamB.Caption = "IdSanPham";
            this.IdSanPhamB.FieldName = "IdSanPham";
            this.IdSanPhamB.Name = "IdSanPhamB";
            // 
            // MaSanPhamB
            // 
            this.MaSanPhamB.Caption = "Mã sản phẩm";
            this.MaSanPhamB.FieldName = "MaSanPham";
            this.MaSanPhamB.Name = "MaSanPhamB";
            this.MaSanPhamB.OptionsColumn.ReadOnly = true;
            this.MaSanPhamB.Visible = true;
            this.MaSanPhamB.VisibleIndex = 3;
            this.MaSanPhamB.Width = 108;
            // 
            // TenSanPhamB
            // 
            this.TenSanPhamB.Caption = "Tên sản phẩm";
            this.TenSanPhamB.FieldName = "TenSanPham";
            this.TenSanPhamB.Name = "TenSanPhamB";
            this.TenSanPhamB.OptionsColumn.ReadOnly = true;
            this.TenSanPhamB.Visible = true;
            this.TenSanPhamB.VisibleIndex = 4;
            this.TenSanPhamB.Width = 200;
            // 
            // IdSanPhamBanB
            // 
            this.IdSanPhamBanB.Caption = "IdSanPhamBan";
            this.IdSanPhamBanB.FieldName = "IdSanPhamBan";
            this.IdSanPhamBanB.Name = "IdSanPhamBanB";
            // 
            // TenSanPhamBanB
            // 
            this.TenSanPhamBanB.Caption = "Sản phẩm bán";
            this.TenSanPhamBanB.FieldName = "TenSanPhamBan";
            this.TenSanPhamBanB.Name = "TenSanPhamBanB";
            this.TenSanPhamBanB.OptionsColumn.ReadOnly = true;
            this.TenSanPhamBanB.Visible = true;
            this.TenSanPhamBanB.VisibleIndex = 5;
            this.TenSanPhamBanB.Width = 227;
            // 
            // LoaiHangHoaB
            // 
            this.LoaiHangHoaB.Caption = "Loại hàng hóa";
            this.LoaiHangHoaB.FieldName = "LoaiHangHoa";
            this.LoaiHangHoaB.Name = "LoaiHangHoaB";
            this.LoaiHangHoaB.OptionsColumn.ReadOnly = true;
            this.LoaiHangHoaB.Visible = true;
            this.LoaiHangHoaB.VisibleIndex = 6;
            this.LoaiHangHoaB.Width = 127;
            // 
            // DonViTinhB
            // 
            this.DonViTinhB.Caption = "Đơn vị tính";
            this.DonViTinhB.FieldName = "DonViTinh";
            this.DonViTinhB.Name = "DonViTinhB";
            this.DonViTinhB.OptionsColumn.ReadOnly = true;
            this.DonViTinhB.Visible = true;
            this.DonViTinhB.VisibleIndex = 7;
            this.DonViTinhB.Width = 78;
            // 
            // SoLuongBanB
            // 
            this.SoLuongBanB.Caption = "Số lượng";
            this.SoLuongBanB.FieldName = "SoLuong";
            this.SoLuongBanB.Name = "SoLuongBanB";
            this.SoLuongBanB.OptionsColumn.ReadOnly = true;
            this.SoLuongBanB.Visible = true;
            this.SoLuongBanB.VisibleIndex = 8;
            this.SoLuongBanB.Width = 88;
            // 
            // TrungMaVach
            // 
            this.TrungMaVach.Caption = "TrungMaVach";
            this.TrungMaVach.FieldName = "TrungMaVach";
            this.TrungMaVach.Name = "TrungMaVach";
            // 
            // LoaiDonHang
            // 
            this.LoaiDonHang.Caption = "Loại đơn hàng";
            this.LoaiDonHang.ColumnEdit = this.repLoaiDonHang;
            this.LoaiDonHang.FieldName = "LoaiChungTu";
            this.LoaiDonHang.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.LoaiDonHang.Name = "LoaiDonHang";
            this.LoaiDonHang.Visible = true;
            this.LoaiDonHang.VisibleIndex = 9;
            this.LoaiDonHang.Width = 106;
            // 
            // repLoaiDonHang
            // 
            this.repLoaiDonHang.AutoHeight = false;
            this.repLoaiDonHang.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLoaiDonHang.DisplayMember = "Name";
            this.repLoaiDonHang.Name = "repLoaiDonHang";
            this.repLoaiDonHang.ValueMember = "Id";
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gHangCanXuat;
            this.gridView3.Name = "gridView3";
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(125, 150);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEdit,
            this.tsbUpdate,
            this.toolStripSeparator3,
            this.tsbDelete,
            this.tsbConfirm,
            this.tsbSuaGN,
            this.tsbXacNhanGN,
            this.toolStripSeparator2,
            this.tsbPrint,
            this.tsbSearch,
            this.toolStripSeparator4,
            this.tsbClose,
            this.toolStripSeparator1,
            this.tslInfor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1081, 25);
            this.toolStrip1.TabIndex = 86;
            this.toolStrip1.Text = "toolStrip1";
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
            // tsbUpdate
            // 
            this.tsbUpdate.Enabled = false;
            this.tsbUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdate.Image")));
            this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdate.Name = "tsbUpdate";
            this.tsbUpdate.Size = new System.Drawing.Size(98, 22);
            this.tsbUpdate.Text = "Cập nhật (F7)";
            this.tsbUpdate.Visible = false;
            this.tsbUpdate.Click += new System.EventHandler(this.tsbUpdate_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
            // tsbConfirm
            // 
            this.tsbConfirm.Image = ((System.Drawing.Image)(resources.GetObject("tsbConfirm.Image")));
            this.tsbConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConfirm.Name = "tsbConfirm";
            this.tsbConfirm.Size = new System.Drawing.Size(99, 22);
            this.tsbConfirm.Text = "Xác &nhận (F2)";
            this.tsbConfirm.Click += new System.EventHandler(this.tsbConfirm_Click);
            // 
            // tsbSuaGN
            // 
            this.tsbSuaGN.Image = ((System.Drawing.Image)(resources.GetObject("tsbSuaGN.Image")));
            this.tsbSuaGN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSuaGN.Name = "tsbSuaGN";
            this.tsbSuaGN.Size = new System.Drawing.Size(121, 22);
            this.tsbSuaGN.Text = "Sửa tình trạng GN";
            this.tsbSuaGN.Click += new System.EventHandler(this.tsbSuaGN_Click);
            // 
            // tsbXacNhanGN
            // 
            this.tsbXacNhanGN.Image = ((System.Drawing.Image)(resources.GetObject("tsbXacNhanGN.Image")));
            this.tsbXacNhanGN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbXacNhanGN.Name = "tsbXacNhanGN";
            this.tsbXacNhanGN.Size = new System.Drawing.Size(140, 22);
            this.tsbXacNhanGN.Text = "Xác nhận T.Trang GN";
            this.tsbXacNhanGN.Click += new System.EventHandler(this.tsbXacNhanGN_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // tsbSearch
            // 
            this.tsbSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearch.Image")));
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(106, 22);
            this.tsbSearch.Text = "Tìm &kiếm (F10)";
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);
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
            this.tslInfor.Size = new System.Drawing.Size(148, 22);
            this.tslInfor.Text = "Đơn hàng bán tại siêu thị";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label17.Location = new System.Drawing.Point(61, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 89;
            this.label17.Text = "Kho xuất";
            // 
            // bteKhoXuat
            // 
            this.bteKhoXuat.Enabled = false;
            this.bteKhoXuat.Location = new System.Drawing.Point(114, 5);
            this.bteKhoXuat.Name = "bteKhoXuat";
            this.bteKhoXuat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteKhoXuat.Properties.Appearance.Options.UseFont = true;
            this.bteKhoXuat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteKhoXuat.Size = new System.Drawing.Size(362, 22);
            this.bteKhoXuat.TabIndex = 0;
            this.bteKhoXuat.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteKhoXuat_ButtonClick);
            this.bteKhoXuat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteKhoXuat_KeyDown);
            this.bteKhoXuat.TextChanged += new System.EventHandler(this.bteKhoXuat_TextChanged);
            // 
            // mstNgayLapPhieu
            // 
            this.mstNgayLapPhieu.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.mstNgayLapPhieu.Enabled = false;
            this.mstNgayLapPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mstNgayLapPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mstNgayLapPhieu.Location = new System.Drawing.Point(919, 5);
            this.mstNgayLapPhieu.Name = "mstNgayLapPhieu";
            this.mstNgayLapPhieu.Size = new System.Drawing.Size(143, 20);
            this.mstNgayLapPhieu.TabIndex = 2;
            this.mstNgayLapPhieu.Value = new System.DateTime(2012, 8, 19, 0, 0, 0, 0);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label32.Location = new System.Drawing.Point(864, 8);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(49, 13);
            this.label32.TabIndex = 102;
            this.label32.Text = "Ngày lập";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label31.Location = new System.Drawing.Point(520, 8);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(64, 13);
            this.label31.TabIndex = 89;
            this.label31.Text = "Số giao dịch";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(823, 401);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(112, 20);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "0,000.00";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(824, 427);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(112, 20);
            this.textBox5.TabIndex = 11;
            this.textBox5.Text = "0,000.00";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(824, 453);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(112, 20);
            this.textBox6.TabIndex = 11;
            this.textBox6.Text = "0,000.00";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTrangThai,
            this.tsslDraft});
            this.statusStrip1.Location = new System.Drawing.Point(0, 613);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1081, 22);
            this.statusStrip1.TabIndex = 107;
            this.statusStrip1.Text = "statusStrip1";
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
            // xtabHangGiaoNhan
            // 
            this.xtabHangGiaoNhan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtabHangGiaoNhan.Location = new System.Drawing.Point(0, 29);
            this.xtabHangGiaoNhan.Name = "xtabHangGiaoNhan";
            this.xtabHangGiaoNhan.SelectedTabPage = this.xtabPhanCongGiaoNhan;
            this.xtabHangGiaoNhan.Size = new System.Drawing.Size(1081, 317);
            this.xtabHangGiaoNhan.TabIndex = 0;
            this.xtabHangGiaoNhan.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtabPhanCongGiaoNhan,
            this.xtabHangKemGiaoNhan});
            // 
            // xtabPhanCongGiaoNhan
            // 
            this.xtabPhanCongGiaoNhan.Controls.Add(this.mstThoiGianGiaoDen);
            this.xtabPhanCongGiaoNhan.Controls.Add(this.label13);
            this.xtabPhanCongGiaoNhan.Controls.Add(this.mstThoiGianGiaoTu);
            this.xtabPhanCongGiaoNhan.Controls.Add(this.label12);
            this.xtabPhanCongGiaoNhan.Controls.Add(this.txtSoPhieuPCGN);
            this.xtabPhanCongGiaoNhan.Controls.Add(this.btnGhiChu);
            this.xtabPhanCongGiaoNhan.Controls.Add(this.cboTinhTrangGN);
            this.xtabPhanCongGiaoNhan.Controls.Add(this.label11);
            this.xtabPhanCongGiaoNhan.Controls.Add(this.txtGhiChuPNGN);
            this.xtabPhanCongGiaoNhan.Controls.Add(this.label4);
            this.xtabPhanCongGiaoNhan.Controls.Add(this.mstNgayHoanThanh);
            this.xtabPhanCongGiaoNhan.Controls.Add(this.label3);
            this.xtabPhanCongGiaoNhan.Controls.Add(this.mstNgayPhanCong);
            this.xtabPhanCongGiaoNhan.Controls.Add(this.label1);
            this.xtabPhanCongGiaoNhan.Controls.Add(this.label2);
            this.xtabPhanCongGiaoNhan.Controls.Add(this.tableLayoutPanel4);
            this.xtabPhanCongGiaoNhan.Controls.Add(this.btnXoaPCGN);
            this.xtabPhanCongGiaoNhan.Controls.Add(this.btnPhanCongGN);
            this.xtabPhanCongGiaoNhan.Name = "xtabPhanCongGiaoNhan";
            this.xtabPhanCongGiaoNhan.Size = new System.Drawing.Size(1074, 289);
            this.xtabPhanCongGiaoNhan.Text = "Phân công nhân viên giao nhận";
            // 
            // mstThoiGianGiaoDen
            // 
            this.mstThoiGianGiaoDen.CustomFormat = "dd/MM/yyyy HH:mm";
            this.mstThoiGianGiaoDen.Enabled = false;
            this.mstThoiGianGiaoDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mstThoiGianGiaoDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mstThoiGianGiaoDen.Location = new System.Drawing.Point(633, 32);
            this.mstThoiGianGiaoDen.Name = "mstThoiGianGiaoDen";
            this.mstThoiGianGiaoDen.Size = new System.Drawing.Size(129, 20);
            this.mstThoiGianGiaoDen.TabIndex = 133;
            this.mstThoiGianGiaoDen.Value = new System.DateTime(2012, 8, 19, 0, 0, 0, 0);
            this.mstThoiGianGiaoDen.ValueChanged += new System.EventHandler(this.mstThoiGianGiaoDen_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label13.Location = new System.Drawing.Point(603, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label13.TabIndex = 134;
            this.label13.Text = "đến";
            // 
            // mstThoiGianGiaoTu
            // 
            this.mstThoiGianGiaoTu.CustomFormat = "dd/MM/yyyy HH:mm";
            this.mstThoiGianGiaoTu.Enabled = false;
            this.mstThoiGianGiaoTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mstThoiGianGiaoTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mstThoiGianGiaoTu.Location = new System.Drawing.Point(633, 4);
            this.mstThoiGianGiaoTu.Name = "mstThoiGianGiaoTu";
            this.mstThoiGianGiaoTu.Size = new System.Drawing.Size(129, 20);
            this.mstThoiGianGiaoTu.TabIndex = 131;
            this.mstThoiGianGiaoTu.Value = new System.DateTime(2012, 8, 19, 0, 0, 0, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label12.Location = new System.Drawing.Point(537, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 132;
            this.label12.Text = "Dự kiến đi giao từ";
            // 
            // txtSoPhieuPCGN
            // 
            this.txtSoPhieuPCGN.FieldName = "sophieuphancong";
            this.txtSoPhieuPCGN.Location = new System.Drawing.Point(81, 2);
            this.txtSoPhieuPCGN.Name = "txtSoPhieuPCGN";
            this.txtSoPhieuPCGN.Prefix = null;
            this.txtSoPhieuPCGN.Size = new System.Drawing.Size(217, 20);
            this.txtSoPhieuPCGN.TabIndex = 130;
            this.txtSoPhieuPCGN.TableName = "tbl_chungtu_giaonhan";
            // 
            // btnGhiChu
            // 
            this.btnGhiChu.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGhiChu.Appearance.Options.UseFont = true;
            this.btnGhiChu.Enabled = false;
            this.btnGhiChu.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiChu.Image")));
            this.btnGhiChu.Location = new System.Drawing.Point(936, 2);
            this.btnGhiChu.Name = "btnGhiChu";
            this.btnGhiChu.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnGhiChu.Size = new System.Drawing.Size(128, 23);
            this.btnGhiChu.TabIndex = 129;
            this.btnGhiChu.Text = "Ghi chú giao vận";
            this.btnGhiChu.Visible = false;
            this.btnGhiChu.Click += new System.EventHandler(this.btnGhiChu_Click);
            // 
            // cboTinhTrangGN
            // 
            this.cboTinhTrangGN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhTrangGN.FormattingEnabled = true;
            this.cboTinhTrangGN.Items.AddRange(new object[] {
            "Phân công (Chưa đi giao,chờ xuất hàng)",
            "Đang giao hàng (đã xuất kho, đang đi giao)",
            "Đã giao hàng (giao nhận thành công)",
            "Hủy giao hàng (khách từ chối nhận hàng hoặc có vấn đề phát sinh)",
            "Nhập lại hàng (hàng giao bị nhập lại)"});
            this.cboTinhTrangGN.Location = new System.Drawing.Point(790, 29);
            this.cboTinhTrangGN.Name = "cboTinhTrangGN";
            this.cboTinhTrangGN.Size = new System.Drawing.Size(277, 21);
            this.cboTinhTrangGN.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(787, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 13);
            this.label11.TabIndex = 128;
            this.label11.Text = "Tình trạng giao nhận";
            // 
            // txtGhiChuPNGN
            // 
            this.txtGhiChuPNGN.BackColor = System.Drawing.Color.White;
            this.txtGhiChuPNGN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChuPNGN.Location = new System.Drawing.Point(81, 29);
            this.txtGhiChuPNGN.Multiline = true;
            this.txtGhiChuPNGN.Name = "txtGhiChuPNGN";
            this.txtGhiChuPNGN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGhiChuPNGN.Size = new System.Drawing.Size(445, 54);
            this.txtGhiChuPNGN.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label4.Location = new System.Drawing.Point(37, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 111;
            this.label4.Text = "Ghi chú";
            // 
            // mstNgayHoanThanh
            // 
            this.mstNgayHoanThanh.CustomFormat = "dd/MM/yyyy HH:mm";
            this.mstNgayHoanThanh.Enabled = false;
            this.mstNgayHoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mstNgayHoanThanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mstNgayHoanThanh.Location = new System.Drawing.Point(633, 60);
            this.mstNgayHoanThanh.Name = "mstNgayHoanThanh";
            this.mstNgayHoanThanh.Size = new System.Drawing.Size(129, 20);
            this.mstNgayHoanThanh.TabIndex = 2;
            this.mstNgayHoanThanh.Value = new System.DateTime(2012, 8, 19, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label3.Location = new System.Drawing.Point(538, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 108;
            this.label3.Text = "Ngày hoàn thành";
            // 
            // mstNgayPhanCong
            // 
            this.mstNgayPhanCong.CustomFormat = "dd/MM/yyyy HH:mm";
            this.mstNgayPhanCong.Enabled = false;
            this.mstNgayPhanCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mstNgayPhanCong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mstNgayPhanCong.Location = new System.Drawing.Point(397, 4);
            this.mstNgayPhanCong.Name = "mstNgayPhanCong";
            this.mstNgayPhanCong.Size = new System.Drawing.Size(129, 20);
            this.mstNgayPhanCong.TabIndex = 1;
            this.mstNgayPhanCong.Value = new System.DateTime(2012, 8, 19, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label1.Location = new System.Drawing.Point(309, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "Ngày phân công";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label2.Location = new System.Drawing.Point(15, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 105;
            this.label2.Text = "Số phiếu PC";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.gPhanCongGiaoNhan, 0, 0);
            this.tableLayoutPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(7, 89);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1060, 214);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // gPhanCongGiaoNhan
            // 
            this.gPhanCongGiaoNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gPhanCongGiaoNhan.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gPhanCongGiaoNhan.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gPhanCongGiaoNhan.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gPhanCongGiaoNhan.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gPhanCongGiaoNhan.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gPhanCongGiaoNhan.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gPhanCongGiaoNhan.Location = new System.Drawing.Point(3, 3);
            this.gPhanCongGiaoNhan.MainView = this.gvPhanCongGiaoNhan;
            this.gPhanCongGiaoNhan.Name = "gPhanCongGiaoNhan";
            this.gPhanCongGiaoNhan.Size = new System.Drawing.Size(1054, 208);
            this.gPhanCongGiaoNhan.TabIndex = 86;
            this.gPhanCongGiaoNhan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhanCongGiaoNhan,
            this.gridView4});
            // 
            // gvPhanCongGiaoNhan
            // 
            this.gvPhanCongGiaoNhan.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvPhanCongGiaoNhan.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvPhanCongGiaoNhan.Appearance.FocusedCell.Options.UseFont = true;
            this.gvPhanCongGiaoNhan.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gvPhanCongGiaoNhan.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gvPhanCongGiaoNhan.Appearance.GroupRow.Options.UseFont = true;
            this.gvPhanCongGiaoNhan.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvPhanCongGiaoNhan.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvPhanCongGiaoNhan.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvPhanCongGiaoNhan.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvPhanCongGiaoNhan.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvPhanCongGiaoNhan.Appearance.Row.BackColor = System.Drawing.Color.Silver;
            this.gvPhanCongGiaoNhan.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvPhanCongGiaoNhan.Appearance.Row.Options.UseBackColor = true;
            this.gvPhanCongGiaoNhan.Appearance.Row.Options.UseBorderColor = true;
            this.gvPhanCongGiaoNhan.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvPhanCongGiaoNhan.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvPhanCongGiaoNhan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdChungTu,
            this.colIdNhanVien,
            this.colMaNhanVien,
            this.colHoTen,
            this.colIdDoiTac,
            this.colMaDoiTac,
            this.colTenDoiTac,
            this.colNhanVienDoiTac,
            this.colIdQuanHuyen,
            this.colTenQuanHuyen,
            this.colMaVungMien,
            this.colTenVungMien,
            this.colMaPhuongTien,
            this.colTenPhuongTien,
            this.colBienSoXe,
            this.colLoaiCongViec,
            this.colGhiChu,
            this.IdNhanVien2,
            this.MaNhanVien2,
            this.HoTen2,
            this.IdNhanVien3,
            this.MaNhanVien3,
            this.HoTen3,
            this.IdLaiXe,
            this.MaLaiXe,
            this.TenLaiXe});
            this.gvPhanCongGiaoNhan.CustomizationFormBounds = new System.Drawing.Rectangle(808, 316, 216, 178);
            this.gvPhanCongGiaoNhan.GridControl = this.gPhanCongGiaoNhan;
            this.gvPhanCongGiaoNhan.Name = "gvPhanCongGiaoNhan";
            this.gvPhanCongGiaoNhan.OptionsSelection.InvertSelection = true;
            this.gvPhanCongGiaoNhan.OptionsSelection.MultiSelect = true;
            this.gvPhanCongGiaoNhan.OptionsView.ColumnAutoWidth = false;
            this.gvPhanCongGiaoNhan.OptionsView.ShowAutoFilterRow = true;
            this.gvPhanCongGiaoNhan.OptionsView.ShowDetailButtons = false;
            // 
            // colIdChungTu
            // 
            this.colIdChungTu.Caption = "IdChungTu";
            this.colIdChungTu.FieldName = "IdChungTu";
            this.colIdChungTu.Name = "colIdChungTu";
            // 
            // colIdNhanVien
            // 
            this.colIdNhanVien.Caption = "IdNhanVien";
            this.colIdNhanVien.FieldName = "IdNhanVien";
            this.colIdNhanVien.Name = "colIdNhanVien";
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.Caption = "Mã nhân viên";
            this.colMaNhanVien.FieldName = "MaNhanVien";
            this.colMaNhanVien.Name = "colMaNhanVien";
            this.colMaNhanVien.OptionsColumn.ReadOnly = true;
            this.colMaNhanVien.Visible = true;
            this.colMaNhanVien.VisibleIndex = 0;
            this.colMaNhanVien.Width = 116;
            // 
            // colHoTen
            // 
            this.colHoTen.Caption = "Tên nhân viên Trần Anh";
            this.colHoTen.FieldName = "HoTen";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.OptionsColumn.ReadOnly = true;
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 1;
            this.colHoTen.Width = 263;
            // 
            // colIdDoiTac
            // 
            this.colIdDoiTac.Caption = "IdDoiTac";
            this.colIdDoiTac.FieldName = "IdDoiTac";
            this.colIdDoiTac.Name = "colIdDoiTac";
            // 
            // colMaDoiTac
            // 
            this.colMaDoiTac.Caption = "Mã đối tác";
            this.colMaDoiTac.FieldName = "MaDoiTac";
            this.colMaDoiTac.Name = "colMaDoiTac";
            // 
            // colTenDoiTac
            // 
            this.colTenDoiTac.Caption = "Đối tác lắp đặt";
            this.colTenDoiTac.FieldName = "TenDoiTac";
            this.colTenDoiTac.Name = "colTenDoiTac";
            this.colTenDoiTac.Visible = true;
            this.colTenDoiTac.VisibleIndex = 2;
            this.colTenDoiTac.Width = 182;
            // 
            // colNhanVienDoiTac
            // 
            this.colNhanVienDoiTac.Caption = "Nhân viên đối tác";
            this.colNhanVienDoiTac.FieldName = "NhanVienDoiTac";
            this.colNhanVienDoiTac.Name = "colNhanVienDoiTac";
            this.colNhanVienDoiTac.Visible = true;
            this.colNhanVienDoiTac.VisibleIndex = 3;
            this.colNhanVienDoiTac.Width = 161;
            // 
            // colIdQuanHuyen
            // 
            this.colIdQuanHuyen.Caption = "IdQuanHuyen";
            this.colIdQuanHuyen.FieldName = "IdQuanHuyen";
            this.colIdQuanHuyen.Name = "colIdQuanHuyen";
            // 
            // colTenQuanHuyen
            // 
            this.colTenQuanHuyen.Caption = "Quận/Huyện";
            this.colTenQuanHuyen.FieldName = "TenQuanHuyen";
            this.colTenQuanHuyen.Name = "colTenQuanHuyen";
            this.colTenQuanHuyen.Visible = true;
            this.colTenQuanHuyen.VisibleIndex = 4;
            this.colTenQuanHuyen.Width = 163;
            // 
            // colMaVungMien
            // 
            this.colMaVungMien.Caption = "MaVungMien";
            this.colMaVungMien.FieldName = "MaVungMien";
            this.colMaVungMien.Name = "colMaVungMien";
            this.colMaVungMien.OptionsColumn.ReadOnly = true;
            this.colMaVungMien.Width = 90;
            // 
            // colTenVungMien
            // 
            this.colTenVungMien.Caption = "Vùng miền";
            this.colTenVungMien.FieldName = "TenVungMien";
            this.colTenVungMien.Name = "colTenVungMien";
            this.colTenVungMien.OptionsColumn.ReadOnly = true;
            this.colTenVungMien.Visible = true;
            this.colTenVungMien.VisibleIndex = 5;
            this.colTenVungMien.Width = 92;
            // 
            // colMaPhuongTien
            // 
            this.colMaPhuongTien.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.colMaPhuongTien.AppearanceCell.Options.UseBackColor = true;
            this.colMaPhuongTien.Caption = "MaPhuongTien";
            this.colMaPhuongTien.FieldName = "MaPhuongTien";
            this.colMaPhuongTien.Name = "colMaPhuongTien";
            this.colMaPhuongTien.Width = 296;
            // 
            // colTenPhuongTien
            // 
            this.colTenPhuongTien.Caption = "Phương tiện vận chuyển";
            this.colTenPhuongTien.FieldName = "TenPhuongTien";
            this.colTenPhuongTien.Name = "colTenPhuongTien";
            this.colTenPhuongTien.OptionsColumn.ReadOnly = true;
            this.colTenPhuongTien.Visible = true;
            this.colTenPhuongTien.VisibleIndex = 6;
            this.colTenPhuongTien.Width = 146;
            // 
            // colBienSoXe
            // 
            this.colBienSoXe.Caption = "Biển số xe";
            this.colBienSoXe.FieldName = "BienSoXe";
            this.colBienSoXe.Name = "colBienSoXe";
            this.colBienSoXe.OptionsColumn.ReadOnly = true;
            this.colBienSoXe.Visible = true;
            this.colBienSoXe.VisibleIndex = 7;
            this.colBienSoXe.Width = 138;
            // 
            // colLoaiCongViec
            // 
            this.colLoaiCongViec.Caption = "Loại công việc";
            this.colLoaiCongViec.FieldName = "LoaiCongViec";
            this.colLoaiCongViec.Name = "colLoaiCongViec";
            this.colLoaiCongViec.OptionsColumn.ReadOnly = true;
            this.colLoaiCongViec.Visible = true;
            this.colLoaiCongViec.VisibleIndex = 8;
            this.colLoaiCongViec.Width = 120;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.OptionsColumn.ReadOnly = true;
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 9;
            this.colGhiChu.Width = 215;
            // 
            // IdNhanVien2
            // 
            this.IdNhanVien2.Caption = "IdNhanVien2";
            this.IdNhanVien2.FieldName = "IdNhanVien2";
            this.IdNhanVien2.Name = "IdNhanVien2";
            // 
            // MaNhanVien2
            // 
            this.MaNhanVien2.Caption = "Mã nhân viên 2";
            this.MaNhanVien2.FieldName = "MaNhanVien2";
            this.MaNhanVien2.Name = "MaNhanVien2";
            this.MaNhanVien2.OptionsColumn.ReadOnly = true;
            this.MaNhanVien2.Visible = true;
            this.MaNhanVien2.VisibleIndex = 10;
            this.MaNhanVien2.Width = 101;
            // 
            // HoTen2
            // 
            this.HoTen2.Caption = "Tên nhân viên 2";
            this.HoTen2.FieldName = "HoTen2";
            this.HoTen2.Name = "HoTen2";
            this.HoTen2.OptionsColumn.ReadOnly = true;
            this.HoTen2.Visible = true;
            this.HoTen2.VisibleIndex = 11;
            this.HoTen2.Width = 139;
            // 
            // IdNhanVien3
            // 
            this.IdNhanVien3.Caption = "IdNhanVien3";
            this.IdNhanVien3.FieldName = "IdNhanVien3";
            this.IdNhanVien3.Name = "IdNhanVien3";
            // 
            // MaNhanVien3
            // 
            this.MaNhanVien3.Caption = "Mã nhân viên 3";
            this.MaNhanVien3.FieldName = "MaNhanVien3";
            this.MaNhanVien3.Name = "MaNhanVien3";
            this.MaNhanVien3.OptionsColumn.ReadOnly = true;
            this.MaNhanVien3.Visible = true;
            this.MaNhanVien3.VisibleIndex = 12;
            this.MaNhanVien3.Width = 113;
            // 
            // HoTen3
            // 
            this.HoTen3.Caption = "Tên nhân viên 3";
            this.HoTen3.FieldName = "HoTen3";
            this.HoTen3.Name = "HoTen3";
            this.HoTen3.OptionsColumn.ReadOnly = true;
            this.HoTen3.Visible = true;
            this.HoTen3.VisibleIndex = 13;
            this.HoTen3.Width = 181;
            // 
            // IdLaiXe
            // 
            this.IdLaiXe.Caption = "IdLaiXe";
            this.IdLaiXe.FieldName = "IdLaiXe";
            this.IdLaiXe.Name = "IdLaiXe";
            // 
            // MaLaiXe
            // 
            this.MaLaiXe.Caption = "Mã lái xe";
            this.MaLaiXe.FieldName = "MaLaiXe";
            this.MaLaiXe.Name = "MaLaiXe";
            // 
            // TenLaiXe
            // 
            this.TenLaiXe.Caption = "Lái xe";
            this.TenLaiXe.FieldName = "TenLaiXe";
            this.TenLaiXe.Name = "TenLaiXe";
            this.TenLaiXe.OptionsColumn.ReadOnly = true;
            this.TenLaiXe.Visible = true;
            this.TenLaiXe.VisibleIndex = 14;
            this.TenLaiXe.Width = 169;
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.gPhanCongGiaoNhan;
            this.gridView4.Name = "gridView4";
            // 
            // btnXoaPCGN
            // 
            this.btnXoaPCGN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaPCGN.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaPCGN.Appearance.Options.UseFont = true;
            this.btnXoaPCGN.Enabled = false;
            this.btnXoaPCGN.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaPCGN.Image")));
            this.btnXoaPCGN.Location = new System.Drawing.Point(790, 60);
            this.btnXoaPCGN.Name = "btnXoaPCGN";
            this.btnXoaPCGN.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnXoaPCGN.Size = new System.Drawing.Size(130, 23);
            this.btnXoaPCGN.TabIndex = 6;
            this.btnXoaPCGN.Text = "Xóa phân công";
            this.btnXoaPCGN.Click += new System.EventHandler(this.btnXoaPCGN_Click);
            // 
            // btnPhanCongGN
            // 
            this.btnPhanCongGN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPhanCongGN.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPhanCongGN.Appearance.Options.UseFont = true;
            this.btnPhanCongGN.Enabled = false;
            this.btnPhanCongGN.Image = ((System.Drawing.Image)(resources.GetObject("btnPhanCongGN.Image")));
            this.btnPhanCongGN.Location = new System.Drawing.Point(922, 60);
            this.btnPhanCongGN.Name = "btnPhanCongGN";
            this.btnPhanCongGN.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnPhanCongGN.Size = new System.Drawing.Size(145, 23);
            this.btnPhanCongGN.TabIndex = 5;
            this.btnPhanCongGN.Text = "Phân công giao vận";
            this.btnPhanCongGN.Click += new System.EventHandler(this.btnPhanCongGN_Click);
            // 
            // xtabHangKemGiaoNhan
            // 
            this.xtabHangKemGiaoNhan.Controls.Add(this.txtSoOrderKH);
            this.xtabHangKemGiaoNhan.Controls.Add(this.cboNhanVien);
            this.xtabHangKemGiaoNhan.Controls.Add(this.label10);
            this.xtabHangKemGiaoNhan.Controls.Add(this.txtGhiChu);
            this.xtabHangKemGiaoNhan.Controls.Add(this.label8);
            this.xtabHangKemGiaoNhan.Controls.Add(this.mstNgayLapPhieu);
            this.xtabHangKemGiaoNhan.Controls.Add(this.label32);
            this.xtabHangKemGiaoNhan.Controls.Add(this.bteKhoXuat);
            this.xtabHangKemGiaoNhan.Controls.Add(this.grSanPhamBan);
            this.xtabHangKemGiaoNhan.Controls.Add(this.label31);
            this.xtabHangKemGiaoNhan.Controls.Add(this.label17);
            this.xtabHangKemGiaoNhan.Name = "xtabHangKemGiaoNhan";
            this.xtabHangKemGiaoNhan.Size = new System.Drawing.Size(1074, 288);
            this.xtabHangKemGiaoNhan.Text = "Danh sách phụ kiện kèm giao nhận";
            // 
            // txtSoOrderKH
            // 
            this.txtSoOrderKH.FieldName = "sochungtu";
            this.txtSoOrderKH.Location = new System.Drawing.Point(587, 5);
            this.txtSoOrderKH.Name = "txtSoOrderKH";
            this.txtSoOrderKH.Prefix = null;
            this.txtSoOrderKH.Size = new System.Drawing.Size(217, 20);
            this.txtSoOrderKH.TabIndex = 131;
            this.txtSoOrderKH.TableName = "tbl_chungtu";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(114, 31);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(362, 21);
            this.cboNhanVien.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(55, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 126;
            this.label10.Text = "Nhân viên";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.Color.White;
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(587, 31);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(475, 20);
            this.txtGhiChu.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label8.Location = new System.Drawing.Point(539, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 124;
            this.label8.Text = "Ghi chú";
            // 
            // frmBH_LapDonHangGiaoNhan
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 635);
            this.Controls.Add(this.xtabHangGiaoNhan);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grHangKhuyenMai);
            this.KeyPreview = true;
            this.Name = "frmBH_LapDonHangGiaoNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân công đơn hàng giao nhận";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhieuXuat_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPhieuXuat_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grSanPhamBan.ResumeLayout(false);
            this.grSanPhamBan.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gHangGiaoVan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHangGiaoNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.grHangKhuyenMai.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gHangCanXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHangCanXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhoXuat.Properties)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtabHangGiaoNhan)).EndInit();
            this.xtabHangGiaoNhan.ResumeLayout(false);
            this.xtabPhanCongGiaoNhan.ResumeLayout(false);
            this.xtabPhanCongGiaoNhan.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gPhanCongGiaoNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhanCongGiaoNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.xtabHangKemGiaoNhan.ResumeLayout(false);
            this.xtabHangKemGiaoNhan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grSanPhamBan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grHangKhuyenMai;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbUpdate;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private GtidTextBox textBox4;
        private GtidTextBox textBox5;
        private GtidTextBox textBox6;
        internal GtidButton btnThemHang;
        private GtidButton btnXoaMaHang;
        private System.Windows.Forms.ToolStripButton tsbConfirm;
        private GtidTextBox txtMaSanPham;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker mstNgayLapPhieu;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private DevExpress.XtraEditors.ButtonEdit bteKhoXuat;
        private DevExpress.XtraGrid.GridControl gHangGiaoVan;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHangGiaoNhan;
        private DevExpress.XtraGrid.Columns.GridColumn IdChungTuChiTiet;
        private DevExpress.XtraGrid.Columns.GridColumn IdSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn MaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn DonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gHangCanXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHangCanXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn IdChiTietChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn IdSanPhamB;
        private DevExpress.XtraGrid.Columns.GridColumn MaSanPhamB;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPhamB;
        private DevExpress.XtraGrid.Columns.GridColumn IdSanPhamBanB;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPhamBanB;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiHangHoaB;
        private DevExpress.XtraGrid.Columns.GridColumn DonViTinhB;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongBanB;
        private DevExpress.XtraGrid.Columns.GridColumn TrungMaVach;
        private System.Windows.Forms.ToolStripLabel tslInfor;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslTrangThai;
        private System.Windows.Forms.ToolStripStatusLabel tsslDraft;
        private DevExpress.XtraGrid.Columns.GridColumn KhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn SoChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn NgayLap;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiDonHang;
        private DevExpress.XtraGrid.Columns.GridColumn IdChungTu;
        private DevExpress.XtraTab.XtraTabControl xtabHangGiaoNhan;
        private DevExpress.XtraTab.XtraTabPage xtabPhanCongGiaoNhan;
        private DevExpress.XtraTab.XtraTabPage xtabHangKemGiaoNhan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevExpress.XtraGrid.GridControl gPhanCongGiaoNhan;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhanCongGiaoNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colIdChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colMaVungMien;
        private DevExpress.XtraGrid.Columns.GridColumn colTenVungMien;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhuongTien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private GtidButton btnXoaPCGN;
        private GtidButton btnPhanCongGN;
        private DevExpress.XtraGrid.Columns.GridColumn colTenPhuongTien;
        private DevExpress.XtraGrid.Columns.GridColumn colBienSoXe;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiCongViec;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLoaiDonHang;
        private System.Windows.Forms.DateTimePicker mstNgayPhanCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker mstNgayHoanThanh;
        private System.Windows.Forms.Label label3;
        private GtidTextBox txtGhiChuPNGN;
        private System.Windows.Forms.Label label4;
        private GtidTextBox txtGhiChu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboTinhTrangGN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripButton tsbSuaGN;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbXacNhanGN;
        private DevExpress.XtraGrid.Columns.GridColumn colIdQuanHuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colTenQuanHuyen;
        private GtidButton btnGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colNhanVienDoiTac;
        private DevExpress.XtraGrid.Columns.GridColumn NgayHenGiaoHang;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDoiTac;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDoiTac;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDoiTac;
        private QLBH.Common.UserControls.UCCodeGenerate txtSoPhieuPCGN;
        private QLBH.Common.UserControls.UCCodeGenerate txtSoOrderKH;
        private DevExpress.XtraGrid.Columns.GridColumn IdNhanVien2;
        private DevExpress.XtraGrid.Columns.GridColumn MaNhanVien2;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen2;
        private DevExpress.XtraGrid.Columns.GridColumn IdNhanVien3;
        private DevExpress.XtraGrid.Columns.GridColumn MaNhanVien3;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen3;
        private DevExpress.XtraGrid.Columns.GridColumn IdLaiXe;
        private DevExpress.XtraGrid.Columns.GridColumn MaLaiXe;
        private DevExpress.XtraGrid.Columns.GridColumn TenLaiXe;
        private System.Windows.Forms.DateTimePicker mstThoiGianGiaoDen;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker mstThoiGianGiaoTu;
        private System.Windows.Forms.Label label12;
    }
}