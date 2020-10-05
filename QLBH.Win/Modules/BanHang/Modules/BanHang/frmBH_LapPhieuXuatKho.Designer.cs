using System.Drawing;
using QLBH.Core.Form;
namespace QLBanHang.Modules.BanHang
{
    partial class frmBH_LapPhieuXuatKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBH_LapPhieuXuatKho));
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
            this.btnXoaMaVach = new QLBH.Core.Form.GtidButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gHangDaXuat = new DevExpress.XtraGrid.GridControl();
            this.gvHangDaXuat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdChiTietHangHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdChungTuChiTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaVach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiHangHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThuongNong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bteNhanVien = new DevExpress.XtraEditors.ButtonEdit();
            this.grHangKhuyenMai = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gHangCanXuat = new DevExpress.XtraGrid.GridControl();
            this.gvHangCanXuat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdChiTietChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSanPhamB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaSanPhamB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPhamB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViTinhB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrungMaVach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.SoLuongBanB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongChuaXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongDangXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbConfirm = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.tsbPrintBH = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslInfor = new System.Windows.Forms.ToolStripLabel();
            this.label17 = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.grThongTin = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGhiChu = new QLBH.Core.Form.GtidTextBox();
            this.bteKhachHang = new DevExpress.XtraEditors.ButtonEdit();
            this.bteKhoXuat = new DevExpress.XtraEditors.ButtonEdit();
            this.txtDiaChi = new QLBH.Core.Form.GtidTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDienThoai = new QLBH.Core.Form.GtidTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTenKhachHang = new QLBH.Core.Form.GtidTextBox();
            this.mstNgayLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.label32 = new System.Windows.Forms.Label();
            this.btnTimOrderKH = new QLBH.Core.Form.GtidButton();
            this.txtSoOrderKH = new QLBH.Core.Form.GtidTextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSoPhieu = new System.Windows.Forms.Label();
            this.lblNgayXuat = new System.Windows.Forms.Label();
            this.mstNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.textBox4 = new QLBH.Core.Form.GtidTextBox();
            this.textBox5 = new QLBH.Core.Form.GtidTextBox();
            this.textBox6 = new QLBH.Core.Form.GtidTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDraft = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboDoiTac = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSoPhieu = new QLBH.Common.UserControls.UCCodeGenerate();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGhiChuXuat = new QLBH.Core.Form.GtidTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gPhieuXuat = new DevExpress.XtraGrid.GridControl();
            this.gvPhieuXuat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grSanPhamBan.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gHangDaXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHangDaXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteNhanVien.Properties)).BeginInit();
            this.grHangKhuyenMai.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gHangCanXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHangCanXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.grThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhoXuat.Properties)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
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
            this.txtMaSanPham.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMaSanPham.Enabled = false;
            this.txtMaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSanPham.Location = new System.Drawing.Point(88, 19);
            this.txtMaSanPham.Multiline = true;
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(519, 26);
            this.txtMaSanPham.TabIndex = 0;
            this.txtMaSanPham.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaSanPham_KeyDown);
            this.txtMaSanPham.Leave += new System.EventHandler(this.txtMaSanPham_Leave);
            this.txtMaSanPham.Enter += new System.EventHandler(this.txtMaSanPham_Enter);
            // 
            // btnThemHang
            // 
            this.btnThemHang.Enabled = false;
            this.btnThemHang.Image = ((System.Drawing.Image)(resources.GetObject("btnThemHang.Image")));
            this.btnThemHang.Location = new System.Drawing.Point(613, 18);
            this.btnThemHang.Name = "btnThemHang";
            this.btnThemHang.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnThemHang.Size = new System.Drawing.Size(93, 28);
            this.btnThemHang.TabIndex = 1;
            this.btnThemHang.Text = "&Thêm mã vạch";
            this.btnThemHang.Click += new System.EventHandler(this.btnThemHang_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(11, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã vạch";
            // 
            // grSanPhamBan
            // 
            this.grSanPhamBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grSanPhamBan.Controls.Add(this.txtMaSanPham);
            this.grSanPhamBan.Controls.Add(this.btnXoaMaVach);
            this.grSanPhamBan.Controls.Add(this.btnThemHang);
            this.grSanPhamBan.Controls.Add(this.tableLayoutPanel1);
            this.grSanPhamBan.Controls.Add(this.label9);
            this.grSanPhamBan.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.grSanPhamBan.ForeColor = System.Drawing.Color.Black;
            this.grSanPhamBan.Location = new System.Drawing.Point(322, 150);
            this.grSanPhamBan.Name = "grSanPhamBan";
            this.grSanPhamBan.Size = new System.Drawing.Size(829, 257);
            this.grSanPhamBan.TabIndex = 0;
            this.grSanPhamBan.TabStop = false;
            this.grSanPhamBan.Text = "Danh sách mặt hàng đã xuất kho";
            // 
            // btnXoaMaVach
            // 
            this.btnXoaMaVach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaMaVach.Enabled = false;
            this.btnXoaMaVach.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaMaVach.Image")));
            this.btnXoaMaVach.Location = new System.Drawing.Point(711, 17);
            this.btnXoaMaVach.Name = "btnXoaMaVach";
            this.btnXoaMaVach.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnXoaMaVach.Size = new System.Drawing.Size(108, 28);
            this.btnXoaMaVach.TabIndex = 2;
            this.btnXoaMaVach.Text = "Xóa mã vạch";
            this.btnXoaMaVach.Click += new System.EventHandler(this.btnXoaMaVach_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gHangDaXuat, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 52);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 199F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(812, 199);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gHangDaXuat
            // 
            this.gHangDaXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gHangDaXuat.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gHangDaXuat.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gHangDaXuat.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gHangDaXuat.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gHangDaXuat.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gHangDaXuat.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gHangDaXuat.Location = new System.Drawing.Point(3, 3);
            this.gHangDaXuat.MainView = this.gvHangDaXuat;
            this.gHangDaXuat.Name = "gHangDaXuat";
            this.gHangDaXuat.Size = new System.Drawing.Size(806, 193);
            this.gHangDaXuat.TabIndex = 0;
            this.gHangDaXuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHangDaXuat,
            this.gridView1});
            // 
            // gvHangDaXuat
            // 
            this.gvHangDaXuat.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvHangDaXuat.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvHangDaXuat.Appearance.FocusedCell.Options.UseFont = true;
            this.gvHangDaXuat.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvHangDaXuat.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvHangDaXuat.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvHangDaXuat.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvHangDaXuat.Appearance.Row.BackColor = System.Drawing.Color.Silver;
            this.gvHangDaXuat.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvHangDaXuat.Appearance.Row.Options.UseBackColor = true;
            this.gvHangDaXuat.Appearance.Row.Options.UseBorderColor = true;
            this.gvHangDaXuat.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvHangDaXuat.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvHangDaXuat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdChiTietHangHoa,
            this.IdChungTuChiTiet,
            this.IdSanPham,
            this.MaVach,
            this.MaSanPham,
            this.TenSanPham,
            this.DonViTinh,
            this.SoLuong,
            this.LoaiHangHoa,
            this.GhiChu,
            this.TienChietKhau,
            this.TienVAT,
            this.ThuongNong});
            this.gvHangDaXuat.CustomizationFormBounds = new System.Drawing.Rectangle(808, 316, 216, 178);
            this.gvHangDaXuat.GridControl = this.gHangDaXuat;
            this.gvHangDaXuat.Name = "gvHangDaXuat";
            this.gvHangDaXuat.OptionsSelection.InvertSelection = true;
            this.gvHangDaXuat.OptionsSelection.MultiSelect = true;
            this.gvHangDaXuat.OptionsView.ColumnAutoWidth = false;
            this.gvHangDaXuat.OptionsView.ShowAutoFilterRow = true;
            this.gvHangDaXuat.OptionsView.ShowDetailButtons = false;
            this.gvHangDaXuat.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvHangDaXuat_CellValueChanged);
            // 
            // IdChiTietHangHoa
            // 
            this.IdChiTietHangHoa.Caption = "IdChiTietHangHoa";
            this.IdChiTietHangHoa.FieldName = "IdChiTietHangHoa";
            this.IdChiTietHangHoa.Name = "IdChiTietHangHoa";
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
            // MaVach
            // 
            this.MaVach.Caption = "Mã vạch";
            this.MaVach.FieldName = "MaVach";
            this.MaVach.Name = "MaVach";
            this.MaVach.OptionsColumn.ReadOnly = true;
            this.MaVach.Visible = true;
            this.MaVach.VisibleIndex = 0;
            this.MaVach.Width = 175;
            // 
            // MaSanPham
            // 
            this.MaSanPham.Caption = "Mã sản phẩm";
            this.MaSanPham.FieldName = "MaSanPham";
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.OptionsColumn.ReadOnly = true;
            this.MaSanPham.Visible = true;
            this.MaSanPham.VisibleIndex = 1;
            this.MaSanPham.Width = 139;
            // 
            // TenSanPham
            // 
            this.TenSanPham.Caption = "Tên sản phẩm";
            this.TenSanPham.FieldName = "TenSanPham";
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.OptionsColumn.ReadOnly = true;
            this.TenSanPham.Visible = true;
            this.TenSanPham.VisibleIndex = 2;
            this.TenSanPham.Width = 285;
            // 
            // DonViTinh
            // 
            this.DonViTinh.Caption = "Đơn vị tính";
            this.DonViTinh.FieldName = "DonViTinh";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.OptionsColumn.ReadOnly = true;
            this.DonViTinh.Visible = true;
            this.DonViTinh.VisibleIndex = 3;
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
            this.SoLuong.VisibleIndex = 4;
            this.SoLuong.Width = 87;
            // 
            // LoaiHangHoa
            // 
            this.LoaiHangHoa.Caption = "Loại hàng hóa";
            this.LoaiHangHoa.FieldName = "LoaiHangHoa";
            this.LoaiHangHoa.Name = "LoaiHangHoa";
            this.LoaiHangHoa.OptionsColumn.AllowEdit = false;
            this.LoaiHangHoa.Width = 128;
            // 
            // GhiChu
            // 
            this.GhiChu.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.GhiChu.AppearanceCell.Options.UseBackColor = true;
            this.GhiChu.Caption = "Ghi chú";
            this.GhiChu.FieldName = "GhiChu";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Visible = true;
            this.GhiChu.VisibleIndex = 5;
            this.GhiChu.Width = 296;
            // 
            // TienChietKhau
            // 
            this.TienChietKhau.Caption = "TienChietKhau";
            this.TienChietKhau.FieldName = "TienChietKhau";
            this.TienChietKhau.Name = "TienChietKhau";
            // 
            // TienVAT
            // 
            this.TienVAT.Caption = "TienVAT";
            this.TienVAT.FieldName = "TienVAT";
            this.TienVAT.Name = "TienVAT";
            // 
            // ThuongNong
            // 
            this.ThuongNong.Caption = "ThuongNong";
            this.ThuongNong.FieldName = "ThuongNong";
            this.ThuongNong.Name = "ThuongNong";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gHangDaXuat;
            this.gridView1.Name = "gridView1";
            // 
            // bteNhanVien
            // 
            this.bteNhanVien.Location = new System.Drawing.Point(97, 81);
            this.bteNhanVien.Name = "bteNhanVien";
            this.bteNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteNhanVien.Properties.Appearance.Options.UseFont = true;
            this.bteNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteNhanVien.Size = new System.Drawing.Size(213, 22);
            this.bteNhanVien.TabIndex = 6;
            this.bteNhanVien.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteNhanVien_ButtonClick);
            this.bteNhanVien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteNhanVien_KeyDown);
            this.bteNhanVien.TextChanged += new System.EventHandler(this.bteNhanVien_TextChanged);
            // 
            // grHangKhuyenMai
            // 
            this.grHangKhuyenMai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grHangKhuyenMai.Controls.Add(this.tableLayoutPanel3);
            this.grHangKhuyenMai.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.grHangKhuyenMai.ForeColor = System.Drawing.Color.Black;
            this.grHangKhuyenMai.Location = new System.Drawing.Point(0, 413);
            this.grHangKhuyenMai.Name = "grHangKhuyenMai";
            this.grHangKhuyenMai.Size = new System.Drawing.Size(1151, 197);
            this.grHangKhuyenMai.TabIndex = 2;
            this.grHangKhuyenMai.TabStop = false;
            this.grHangKhuyenMai.Text = "Thông tin chi tiết đơn hàng bán";
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
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1134, 174);
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
            this.repEdit});
            this.gHangCanXuat.Size = new System.Drawing.Size(1128, 168);
            this.gHangCanXuat.TabIndex = 87;
            this.gHangCanXuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHangCanXuat,
            this.gridView3});
            // 
            // gvHangCanXuat
            // 
            this.gvHangCanXuat.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvHangCanXuat.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvHangCanXuat.Appearance.FocusedCell.Options.UseFont = true;
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
            this.IdChiTietChungTu,
            this.IdSanPhamB,
            this.MaSanPhamB,
            this.TenSanPhamB,
            this.DonViTinhB,
            this.TrungMaVach,
            this.SoLuongBanB,
            this.SoLuongXuat,
            this.SoLuongChuaXuat,
            this.SoLuongDangXuat});
            this.gvHangCanXuat.CustomizationFormBounds = new System.Drawing.Rectangle(808, 316, 216, 178);
            this.gvHangCanXuat.GridControl = this.gHangCanXuat;
            this.gvHangCanXuat.Name = "gvHangCanXuat";
            this.gvHangCanXuat.OptionsSelection.InvertSelection = true;
            this.gvHangCanXuat.OptionsSelection.MultiSelect = true;
            this.gvHangCanXuat.OptionsView.ColumnAutoWidth = false;
            this.gvHangCanXuat.OptionsView.ShowAutoFilterRow = true;
            this.gvHangCanXuat.OptionsView.ShowDetailButtons = false;
            // 
            // IdChiTietChungTu
            // 
            this.IdChiTietChungTu.Caption = "IdChiTietChungTu";
            this.IdChiTietChungTu.FieldName = "IdChiTietChungTu";
            this.IdChiTietChungTu.Name = "IdChiTietChungTu";
            // 
            // IdSanPhamB
            // 
            this.IdSanPhamB.Caption = "IdSanPham";
            this.IdSanPhamB.FieldName = "IdSanPham";
            this.IdSanPhamB.Name = "IdSanPhamB";
            this.IdSanPhamB.OptionsColumn.ReadOnly = true;
            // 
            // MaSanPhamB
            // 
            this.MaSanPhamB.Caption = "Mã sản phẩm";
            this.MaSanPhamB.FieldName = "MaSanPham";
            this.MaSanPhamB.Name = "MaSanPhamB";
            this.MaSanPhamB.OptionsColumn.ReadOnly = true;
            this.MaSanPhamB.Visible = true;
            this.MaSanPhamB.VisibleIndex = 0;
            this.MaSanPhamB.Width = 146;
            // 
            // TenSanPhamB
            // 
            this.TenSanPhamB.Caption = "Tên sản phẩm";
            this.TenSanPhamB.FieldName = "TenSanPham";
            this.TenSanPhamB.Name = "TenSanPhamB";
            this.TenSanPhamB.OptionsColumn.ReadOnly = true;
            this.TenSanPhamB.Visible = true;
            this.TenSanPhamB.VisibleIndex = 1;
            this.TenSanPhamB.Width = 320;
            // 
            // DonViTinhB
            // 
            this.DonViTinhB.Caption = "Đơn vị tính";
            this.DonViTinhB.FieldName = "DonViTinh";
            this.DonViTinhB.Name = "DonViTinhB";
            this.DonViTinhB.OptionsColumn.ReadOnly = true;
            this.DonViTinhB.Visible = true;
            this.DonViTinhB.VisibleIndex = 2;
            this.DonViTinhB.Width = 96;
            // 
            // TrungMaVach
            // 
            this.TrungMaVach.Caption = "TrungMaVach";
            this.TrungMaVach.ColumnEdit = this.repEdit;
            this.TrungMaVach.FieldName = "TrungMaVach";
            this.TrungMaVach.Name = "TrungMaVach";
            this.TrungMaVach.OptionsColumn.ReadOnly = true;
            this.TrungMaVach.Visible = true;
            this.TrungMaVach.VisibleIndex = 3;
            this.TrungMaVach.Width = 92;
            // 
            // repEdit
            // 
            this.repEdit.AutoHeight = false;
            this.repEdit.Name = "repEdit";
            // 
            // SoLuongBanB
            // 
            this.SoLuongBanB.Caption = "Số lượng bán";
            this.SoLuongBanB.FieldName = "SoLuongBan";
            this.SoLuongBanB.Name = "SoLuongBanB";
            this.SoLuongBanB.OptionsColumn.ReadOnly = true;
            this.SoLuongBanB.Visible = true;
            this.SoLuongBanB.VisibleIndex = 4;
            this.SoLuongBanB.Width = 103;
            // 
            // SoLuongXuat
            // 
            this.SoLuongXuat.Caption = "Số lượng đã xuất";
            this.SoLuongXuat.FieldName = "SoLuongDaXuat";
            this.SoLuongXuat.Name = "SoLuongXuat";
            this.SoLuongXuat.OptionsColumn.ReadOnly = true;
            this.SoLuongXuat.Visible = true;
            this.SoLuongXuat.VisibleIndex = 5;
            this.SoLuongXuat.Width = 104;
            // 
            // SoLuongChuaXuat
            // 
            this.SoLuongChuaXuat.Caption = "Số lượng chưa xuất";
            this.SoLuongChuaXuat.FieldName = "SoLuongChuaXuat";
            this.SoLuongChuaXuat.Name = "SoLuongChuaXuat";
            this.SoLuongChuaXuat.OptionsColumn.ReadOnly = true;
            this.SoLuongChuaXuat.Visible = true;
            this.SoLuongChuaXuat.VisibleIndex = 6;
            this.SoLuongChuaXuat.Width = 111;
            // 
            // SoLuongDangXuat
            // 
            this.SoLuongDangXuat.Caption = "Số lượng đang xuất";
            this.SoLuongDangXuat.FieldName = "SoLuongDangXuat";
            this.SoLuongDangXuat.Name = "SoLuongDangXuat";
            this.SoLuongDangXuat.OptionsColumn.ReadOnly = true;
            this.SoLuongDangXuat.Visible = true;
            this.SoLuongDangXuat.VisibleIndex = 7;
            this.SoLuongDangXuat.Width = 112;
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
            this.tsbAdd,
            this.tsbEdit,
            this.tsbUpdate,
            this.tsbDelete,
            this.toolStripSeparator3,
            this.tsbConfirm,
            this.tsbPrint,
            this.tsbPrintBH,
            this.toolStripSeparator2,
            this.tsbSearch,
            this.toolStripSeparator4,
            this.tsbClose,
            this.toolStripSeparator1,
            this.tslInfor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1151, 25);
            this.toolStrip1.TabIndex = 86;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(94, 22);
            this.tsbAdd.Text = "Tạo mới (F3)";
            this.tsbAdd.ToolTipText = "Làm mới (F5)";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(69, 22);
            this.tsbEdit.Text = "&Sửa (F4)";
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
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(70, 22);
            this.tsbDelete.Text = "&Xóa (F8)";
            this.tsbDelete.Visible = false;
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbConfirm
            // 
            this.tsbConfirm.Image = ((System.Drawing.Image)(resources.GetObject("tsbConfirm.Image")));
            this.tsbConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConfirm.Name = "tsbConfirm";
            this.tsbConfirm.Size = new System.Drawing.Size(99, 22);
            this.tsbConfirm.Text = "Xác &nhận (F5)";
            this.tsbConfirm.Click += new System.EventHandler(this.tsbConfirm_Click);
            // 
            // tsbPrint
            // 
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(141, 22);
            this.tsbPrint.Text = "&In phiếu xuất kho (F9)";
            this.tsbPrint.Click += new System.EventHandler(this.tsbPrint_Click);
            // 
            // tsbPrintBH
            // 
            this.tsbPrintBH.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrintBH.Image")));
            this.tsbPrintBH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrintBH.Name = "tsbPrintBH";
            this.tsbPrintBH.Size = new System.Drawing.Size(152, 22);
            this.tsbPrintBH.Text = "In phiếu bảo hành (F11)";
            this.tsbPrintBH.Click += new System.EventHandler(this.tsbPrintBH_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.label17.Location = new System.Drawing.Point(39, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 89;
            this.label17.Text = "Kho xuất";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblKhachHang.Location = new System.Drawing.Point(26, 68);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(63, 13);
            this.lblKhachHang.TabIndex = 77;
            this.lblKhachHang.Text = "Khách hàng";
            // 
            // grThongTin
            // 
            this.grThongTin.Controls.Add(this.label3);
            this.grThongTin.Controls.Add(this.txtGhiChu);
            this.grThongTin.Controls.Add(this.bteKhachHang);
            this.grThongTin.Controls.Add(this.bteKhoXuat);
            this.grThongTin.Controls.Add(this.txtDiaChi);
            this.grThongTin.Controls.Add(this.label4);
            this.grThongTin.Controls.Add(this.label10);
            this.grThongTin.Controls.Add(this.txtDienThoai);
            this.grThongTin.Controls.Add(this.label1);
            this.grThongTin.Controls.Add(this.txtHoTenKhachHang);
            this.grThongTin.Controls.Add(this.mstNgayLapPhieu);
            this.grThongTin.Controls.Add(this.label32);
            this.grThongTin.Controls.Add(this.btnTimOrderKH);
            this.grThongTin.Controls.Add(this.lblKhachHang);
            this.grThongTin.Controls.Add(this.txtSoOrderKH);
            this.grThongTin.Controls.Add(this.label17);
            this.grThongTin.Controls.Add(this.label31);
            this.grThongTin.Location = new System.Drawing.Point(0, 29);
            this.grThongTin.Name = "grThongTin";
            this.grThongTin.Size = new System.Drawing.Size(846, 115);
            this.grThongTin.TabIndex = 1;
            this.grThongTin.TabStop = false;
            this.grThongTin.Text = "Thông tin đơn hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label3.Location = new System.Drawing.Point(463, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 123;
            this.label3.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtGhiChu.Location = new System.Drawing.Point(511, 67);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ReadOnly = true;
            this.txtGhiChu.Size = new System.Drawing.Size(327, 42);
            this.txtGhiChu.TabIndex = 122;
            // 
            // bteKhachHang
            // 
            this.bteKhachHang.Enabled = false;
            this.bteKhachHang.Location = new System.Drawing.Point(97, 65);
            this.bteKhachHang.Name = "bteKhachHang";
            this.bteKhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteKhachHang.Size = new System.Drawing.Size(330, 20);
            this.bteKhachHang.TabIndex = 7;
            // 
            // bteKhoXuat
            // 
            this.bteKhoXuat.Enabled = false;
            this.bteKhoXuat.Location = new System.Drawing.Point(97, 15);
            this.bteKhoXuat.Name = "bteKhoXuat";
            this.bteKhoXuat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteKhoXuat.Size = new System.Drawing.Size(330, 20);
            this.bteKhoXuat.TabIndex = 0;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.Control;
            this.txtDiaChi.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtDiaChi.Location = new System.Drawing.Point(511, 14);
            this.txtDiaChi.MaxLength = 55;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(327, 21);
            this.txtDiaChi.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label4.Location = new System.Drawing.Point(466, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 120;
            this.label4.Text = "Địa chỉ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label10.Location = new System.Drawing.Point(449, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 118;
            this.label10.Text = "Điện thoại";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtDienThoai.Location = new System.Drawing.Point(511, 40);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.ReadOnly = true;
            this.txtDienThoai.Size = new System.Drawing.Size(144, 21);
            this.txtDienThoai.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label1.Location = new System.Drawing.Point(34, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 116;
            this.label1.Text = "Họ tên KH";
            // 
            // txtHoTenKhachHang
            // 
            this.txtHoTenKhachHang.BackColor = System.Drawing.SystemColors.Window;
            this.txtHoTenKhachHang.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtHoTenKhachHang.Location = new System.Drawing.Point(97, 89);
            this.txtHoTenKhachHang.MaxLength = 55;
            this.txtHoTenKhachHang.Name = "txtHoTenKhachHang";
            this.txtHoTenKhachHang.ReadOnly = true;
            this.txtHoTenKhachHang.Size = new System.Drawing.Size(330, 21);
            this.txtHoTenKhachHang.TabIndex = 8;
            // 
            // mstNgayLapPhieu
            // 
            this.mstNgayLapPhieu.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.mstNgayLapPhieu.Enabled = false;
            this.mstNgayLapPhieu.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstNgayLapPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mstNgayLapPhieu.Location = new System.Drawing.Point(309, 39);
            this.mstNgayLapPhieu.Name = "mstNgayLapPhieu";
            this.mstNgayLapPhieu.Size = new System.Drawing.Size(118, 20);
            this.mstNgayLapPhieu.TabIndex = 3;
            this.mstNgayLapPhieu.Value = new System.DateTime(2012, 8, 19, 0, 0, 0, 0);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label32.Location = new System.Drawing.Point(252, 42);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(49, 13);
            this.label32.TabIndex = 102;
            this.label32.Text = "Ngày lập";
            // 
            // btnTimOrderKH
            // 
            this.btnTimOrderKH.Enabled = false;
            this.btnTimOrderKH.Image = ((System.Drawing.Image)(resources.GetObject("btnTimOrderKH.Image")));
            this.btnTimOrderKH.Location = new System.Drawing.Point(433, 14);
            this.btnTimOrderKH.Name = "btnTimOrderKH";
            this.btnTimOrderKH.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnTimOrderKH.Size = new System.Drawing.Size(28, 23);
            this.btnTimOrderKH.TabIndex = 2;
            this.btnTimOrderKH.Visible = false;
            this.btnTimOrderKH.Click += new System.EventHandler(this.btnTimOrderKH_Click);
            // 
            // txtSoOrderKH
            // 
            this.txtSoOrderKH.BackColor = System.Drawing.Color.White;
            this.txtSoOrderKH.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtSoOrderKH.Location = new System.Drawing.Point(97, 39);
            this.txtSoOrderKH.Name = "txtSoOrderKH";
            this.txtSoOrderKH.Size = new System.Drawing.Size(149, 21);
            this.txtSoOrderKH.TabIndex = 1;
            this.txtSoOrderKH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoOrderKH_KeyDown);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label31.Location = new System.Drawing.Point(25, 42);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(64, 13);
            this.label31.TabIndex = 89;
            this.label31.Text = "Số giao dịch";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(97, 112);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(213, 21);
            this.cboNhanVien.TabIndex = 121;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label2.Location = new System.Drawing.Point(11, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 120;
            this.label2.Text = "Nhân viên giao";
            // 
            // lblSoPhieu
            // 
            this.lblSoPhieu.AutoSize = true;
            this.lblSoPhieu.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblSoPhieu.Location = new System.Drawing.Point(16, 26);
            this.lblSoPhieu.Name = "lblSoPhieu";
            this.lblSoPhieu.Size = new System.Drawing.Size(73, 13);
            this.lblSoPhieu.TabIndex = 75;
            this.lblSoPhieu.Text = "Số phiếu xuất";
            // 
            // lblNgayXuat
            // 
            this.lblNgayXuat.AutoSize = true;
            this.lblNgayXuat.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblNgayXuat.Location = new System.Drawing.Point(32, 55);
            this.lblNgayXuat.Name = "lblNgayXuat";
            this.lblNgayXuat.Size = new System.Drawing.Size(57, 13);
            this.lblNgayXuat.TabIndex = 74;
            this.lblNgayXuat.Text = "Ngày xuất";
            // 
            // mstNgayXuat
            // 
            this.mstNgayXuat.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.mstNgayXuat.Enabled = false;
            this.mstNgayXuat.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.mstNgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mstNgayXuat.Location = new System.Drawing.Point(97, 51);
            this.mstNgayXuat.Name = "mstNgayXuat";
            this.mstNgayXuat.Size = new System.Drawing.Size(149, 21);
            this.mstNgayXuat.TabIndex = 5;
            this.mstNgayXuat.Value = new System.DateTime(2012, 8, 19, 11, 33, 40, 0);
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
            this.statusStrip1.Size = new System.Drawing.Size(1151, 22);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.cboDoiTac);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtSoPhieu);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtGhiChuXuat);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.bteNhanVien);
            this.groupBox1.Controls.Add(this.lblSoPhieu);
            this.groupBox1.Controls.Add(this.mstNgayXuat);
            this.groupBox1.Controls.Add(this.cboNhanVien);
            this.groupBox1.Controls.Add(this.lblNgayXuat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 257);
            this.groupBox1.TabIndex = 122;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết phiếu xuất";
            // 
            // cboDoiTac
            // 
            this.cboDoiTac.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cboDoiTac.FormattingEnabled = true;
            this.cboDoiTac.Location = new System.Drawing.Point(97, 145);
            this.cboDoiTac.Name = "cboDoiTac";
            this.cboDoiTac.Size = new System.Drawing.Size(213, 21);
            this.cboDoiTac.TabIndex = 134;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label12.Location = new System.Drawing.Point(25, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 133;
            this.label12.Text = "Đối tác giao";
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.FieldName = "sochungtu";
            this.txtSoPhieu.Location = new System.Drawing.Point(97, 20);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Prefix = null;
            this.txtSoPhieu.Size = new System.Drawing.Size(213, 21);
            this.txtSoPhieu.TabIndex = 132;
            this.txtSoPhieu.TableName = "tbl_chungtu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label11.Location = new System.Drawing.Point(47, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 125;
            this.label11.Text = "Ghi chú";
            // 
            // txtGhiChuXuat
            // 
            this.txtGhiChuXuat.BackColor = System.Drawing.SystemColors.Window;
            this.txtGhiChuXuat.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtGhiChuXuat.Location = new System.Drawing.Point(97, 176);
            this.txtGhiChuXuat.Multiline = true;
            this.txtGhiChuXuat.Name = "txtGhiChuXuat";
            this.txtGhiChuXuat.Size = new System.Drawing.Size(213, 70);
            this.txtGhiChuXuat.TabIndex = 124;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label8.Location = new System.Drawing.Point(37, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 122;
            this.label8.Text = "Người lập";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.gPhieuXuat);
            this.groupBox2.Location = new System.Drawing.Point(848, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 116);
            this.groupBox2.TabIndex = 123;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phiếu xuất";
            // 
            // gPhieuXuat
            // 
            this.gPhieuXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gPhieuXuat.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gPhieuXuat.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gPhieuXuat.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gPhieuXuat.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gPhieuXuat.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gPhieuXuat.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gPhieuXuat.Location = new System.Drawing.Point(6, 15);
            this.gPhieuXuat.MainView = this.gvPhieuXuat;
            this.gPhieuXuat.Name = "gPhieuXuat";
            this.gPhieuXuat.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCheck});
            this.gPhieuXuat.Size = new System.Drawing.Size(291, 96);
            this.gPhieuXuat.TabIndex = 94;
            this.gPhieuXuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhieuXuat,
            this.gridView2});
            // 
            // gvPhieuXuat
            // 
            this.gvPhieuXuat.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvPhieuXuat.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvPhieuXuat.Appearance.FocusedCell.Options.UseFont = true;
            this.gvPhieuXuat.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvPhieuXuat.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvPhieuXuat.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvPhieuXuat.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvPhieuXuat.Appearance.Row.BackColor = System.Drawing.Color.Silver;
            this.gvPhieuXuat.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvPhieuXuat.Appearance.Row.Options.UseBackColor = true;
            this.gvPhieuXuat.Appearance.Row.Options.UseBorderColor = true;
            this.gvPhieuXuat.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvPhieuXuat.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvPhieuXuat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdChungTu,
            this.SoChungTu,
            this.NgayLap,
            this.NguoiLap});
            this.gvPhieuXuat.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvPhieuXuat.GridControl = this.gPhieuXuat;
            this.gvPhieuXuat.Name = "gvPhieuXuat";
            this.gvPhieuXuat.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvPhieuXuat.OptionsSelection.MultiSelect = true;
            this.gvPhieuXuat.OptionsView.ShowDetailButtons = false;
            this.gvPhieuXuat.OptionsView.ShowGroupPanel = false;
            this.gvPhieuXuat.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvPhieuXuat_FocusedRowChanged);
            // 
            // IdChungTu
            // 
            this.IdChungTu.Caption = "IdChungTu";
            this.IdChungTu.FieldName = "IdChungTu";
            this.IdChungTu.Name = "IdChungTu";
            // 
            // SoChungTu
            // 
            this.SoChungTu.Caption = "Số phiếu xuất";
            this.SoChungTu.FieldName = "SoChungTu";
            this.SoChungTu.Name = "SoChungTu";
            this.SoChungTu.OptionsColumn.ReadOnly = true;
            this.SoChungTu.Visible = true;
            this.SoChungTu.VisibleIndex = 0;
            // 
            // NgayLap
            // 
            this.NgayLap.Caption = "Ngày xuất";
            this.NgayLap.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.NgayLap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgayLap.FieldName = "NgayLap";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.OptionsColumn.ReadOnly = true;
            this.NgayLap.Visible = true;
            this.NgayLap.VisibleIndex = 1;
            // 
            // NguoiLap
            // 
            this.NguoiLap.Caption = "Người lập";
            this.NguoiLap.FieldName = "NguoiLap";
            this.NguoiLap.Name = "NguoiLap";
            this.NguoiLap.OptionsColumn.ReadOnly = true;
            // 
            // repCheck
            // 
            this.repCheck.AutoHeight = false;
            this.repCheck.Name = "repCheck";
            this.repCheck.ValueChecked = 1;
            this.repCheck.ValueUnchecked = 0;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gPhieuXuat;
            this.gridView2.Name = "gridView2";
            // 
            // frmBH_LapPhieuXuatKho
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 635);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grHangKhuyenMai);
            this.Controls.Add(this.grSanPhamBan);
            this.Controls.Add(this.grThongTin);
            this.KeyPreview = true;
            this.Name = "frmBH_LapPhieuXuatKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập phiếu xuất kho";
            this.Load += new System.EventHandler(this.frmPhieuXuat_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPhieuXuat_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grSanPhamBan.ResumeLayout(false);
            this.grSanPhamBan.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gHangDaXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHangDaXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteNhanVien.Properties)).EndInit();
            this.grHangKhuyenMai.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gHangCanXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHangCanXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grThongTin.ResumeLayout(false);
            this.grThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhoXuat.Properties)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
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
        private GtidButton btnXoaMaVach;
        private System.Windows.Forms.ToolStripButton tsbConfirm;
        private GtidTextBox txtMaSanPham;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.GroupBox grThongTin;
        private System.Windows.Forms.DateTimePicker mstNgayLapPhieu;
        private System.Windows.Forms.Label label32;
        private GtidTextBox txtSoOrderKH;
        private GtidButton btnTimOrderKH;
        private System.Windows.Forms.DateTimePicker mstNgayXuat;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lblNgayXuat;
        private System.Windows.Forms.Label lblSoPhieu;
        private System.Windows.Forms.Label label1;
        private GtidTextBox txtHoTenKhachHang;
        private System.Windows.Forms.Label label10;
        private GtidTextBox txtDienThoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private GtidTextBox txtDiaChi;
        private DevExpress.XtraEditors.ButtonEdit bteKhoXuat;
        private DevExpress.XtraEditors.ButtonEdit bteNhanVien;
        private DevExpress.XtraEditors.ButtonEdit bteKhachHang;
        private DevExpress.XtraGrid.GridControl gHangDaXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHangDaXuat;
        private DevExpress.XtraGrid.Columns.GridColumn IdChiTietHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn IdChungTuChiTiet;
        private DevExpress.XtraGrid.Columns.GridColumn IdSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn MaVach;
        private DevExpress.XtraGrid.Columns.GridColumn MaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn DonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn TienChietKhau;
        private DevExpress.XtraGrid.Columns.GridColumn TienVAT;
        private DevExpress.XtraGrid.Columns.GridColumn ThuongNong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gHangCanXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHangCanXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn IdChiTietChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn IdSanPhamB;
        private DevExpress.XtraGrid.Columns.GridColumn MaSanPhamB;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPhamB;
        private DevExpress.XtraGrid.Columns.GridColumn DonViTinhB;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongBanB;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongXuat;
        private DevExpress.XtraGrid.Columns.GridColumn TrungMaVach;
        private System.Windows.Forms.ToolStripLabel tslInfor;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslTrangThai;
        private System.Windows.Forms.ToolStripStatusLabel tsslDraft;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label label3;
        private GtidTextBox txtGhiChu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private DevExpress.XtraGrid.GridControl gPhieuXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhieuXuat;
        private DevExpress.XtraGrid.Columns.GridColumn IdChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn SoChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn NgayLap;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiLap;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheck;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiHangHoa;
        private System.Windows.Forms.Label label11;
        private GtidTextBox txtGhiChuXuat;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongChuaXuat;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongDangXuat;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repEdit;
        private QLBH.Common.UserControls.UCCodeGenerate txtSoPhieu;
        private System.Windows.Forms.ToolStripButton tsbPrintBH;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ComboBox cboDoiTac;
        private System.Windows.Forms.Label label12;
    }
}