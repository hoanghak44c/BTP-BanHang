using System.Drawing;
using QLBH.Core.Form;
namespace QLBanHang.Modules.BanHang
{
    partial class frmBH_LapPhieuChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBH_LapPhieuChi));
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
            this.grPayments = new System.Windows.Forms.GroupBox();
            this.btnThanhToanKhac = new QLBH.Core.Form.GtidButton();
            this.gHinhThucThanhToan = new DevExpress.XtraGrid.GridControl();
            this.gvHinhThucThanhToan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SoPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdHinhThucThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HinhThucThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoTienThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TaiKhoanQuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThoiHanThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdThoiHanThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoTaiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChuTaiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NganHangThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdNganHangThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaThe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DuoiThe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NganHangPhatHanhThe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdNganHangPH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenThuNgan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChuTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnXoaTT = new QLBH.Core.Form.GtidButton();
            this.btnThanhToan = new QLBH.Core.Form.GtidButton();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTienVAT = new System.Windows.Forms.Label();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.mstNgayLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.label32 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grThongTin = new System.Windows.Forms.GroupBox();
            this.bteTrungTam = new DevExpress.XtraEditors.ButtonEdit();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDiaChiGiaoHang = new QLBH.Core.Form.GtidTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bteKhachHang = new DevExpress.XtraEditors.ButtonEdit();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.bteKhoXuat = new DevExpress.XtraEditors.ButtonEdit();
            this.label17 = new System.Windows.Forms.Label();
            this.btnTimOrderKH = new QLBH.Core.Form.GtidButton();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSoSerie = new QLBH.Core.Form.GtidTextBox();
            this.txtKyHieu = new QLBH.Core.Form.GtidTextBox();
            this.txtDiaChi = new QLBH.Core.Form.GtidTextBox();
            this.txtMaSoThue = new QLBH.Core.Form.GtidTextBox();
            this.txtCMND = new QLBH.Core.Form.GtidTextBox();
            this.txtEmail = new QLBH.Core.Form.GtidTextBox();
            this.txtDienThoai = new QLBH.Core.Form.GtidTextBox();
            this.txtHoTenKhachHang = new QLBH.Core.Form.GtidTextBox();
            this.txtTuoi = new QLBH.Core.Form.GtidTextBox();
            this.txtSoOrderKH = new QLBH.Core.Form.GtidTextBox();
            this.txtTienConNo = new QLBH.Core.Form.GtidTextBox();
            this.txtTienThucTra = new QLBH.Core.Form.GtidTextBox();
            this.txtTongTienThanhToan = new QLBH.Core.Form.GtidTextBox();
            this.txtTongTienHang = new QLBH.Core.Form.GtidTextBox();
            this.textBox4 = new QLBH.Core.Form.GtidTextBox();
            this.textBox5 = new QLBH.Core.Form.GtidTextBox();
            this.textBox6 = new QLBH.Core.Form.GtidTextBox();
            this.bteThoiHanThanhToan = new DevExpress.XtraEditors.ButtonEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gHinhThucThanhToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHinhThucThanhToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.grThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhoXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteThoiHanThanhToan.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // grPayments
            // 
            this.grPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grPayments.Controls.Add(this.btnThanhToanKhac);
            this.grPayments.Controls.Add(this.gHinhThucThanhToan);
            this.grPayments.Controls.Add(this.btnXoaTT);
            this.grPayments.Controls.Add(this.btnThanhToan);
            this.grPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.grPayments.Location = new System.Drawing.Point(286, 195);
            this.grPayments.Name = "grPayments";
            this.grPayments.Size = new System.Drawing.Size(722, 282);
            this.grPayments.TabIndex = 2;
            this.grPayments.TabStop = false;
            this.grPayments.Text = "Chi tiết thanh toán";
            // 
            // btnThanhToanKhac
            // 
            this.btnThanhToanKhac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToanKhac.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThanhToanKhac.Appearance.Options.UseFont = true;
            this.btnThanhToanKhac.Enabled = false;
            this.btnThanhToanKhac.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToanKhac.Image")));
            this.btnThanhToanKhac.Location = new System.Drawing.Point(452, 248);
            this.btnThanhToanKhac.Name = "btnThanhToanKhac";
            this.btnThanhToanKhac.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnThanhToanKhac.Size = new System.Drawing.Size(132, 30);
            this.btnThanhToanKhac.TabIndex = 22;
            this.btnThanhToanKhac.Text = "Thanh toán &khác";
            this.btnThanhToanKhac.Click += new System.EventHandler(this.btnThanhToanKhac_Click);
            // 
            // gHinhThucThanhToan
            // 
            this.gHinhThucThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gHinhThucThanhToan.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gHinhThucThanhToan.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gHinhThucThanhToan.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gHinhThucThanhToan.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gHinhThucThanhToan.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gHinhThucThanhToan.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gHinhThucThanhToan.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gHinhThucThanhToan.Location = new System.Drawing.Point(6, 20);
            this.gHinhThucThanhToan.MainView = this.gvHinhThucThanhToan;
            this.gHinhThucThanhToan.Name = "gHinhThucThanhToan";
            this.gHinhThucThanhToan.Size = new System.Drawing.Size(710, 225);
            this.gHinhThucThanhToan.TabIndex = 21;
            this.gHinhThucThanhToan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHinhThucThanhToan,
            this.gridView4});
            // 
            // gvHinhThucThanhToan
            // 
            this.gvHinhThucThanhToan.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvHinhThucThanhToan.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvHinhThucThanhToan.Appearance.FocusedCell.Options.UseFont = true;
            this.gvHinhThucThanhToan.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvHinhThucThanhToan.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvHinhThucThanhToan.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvHinhThucThanhToan.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvHinhThucThanhToan.Appearance.Row.BackColor = System.Drawing.Color.Silver;
            this.gvHinhThucThanhToan.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvHinhThucThanhToan.Appearance.Row.Options.UseBackColor = true;
            this.gvHinhThucThanhToan.Appearance.Row.Options.UseBorderColor = true;
            this.gvHinhThucThanhToan.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvHinhThucThanhToan.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvHinhThucThanhToan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SoPhieu,
            this.IdHinhThucThanhToan,
            this.HinhThucThanhToan,
            this.SoTienThanhToan,
            this.TaiKhoanQuy,
            this.ThoiHanThanhToan,
            this.IdThoiHanThanhToan,
            this.SoTaiKhoan,
            this.ChuTaiKhoan,
            this.NganHangThanhToan,
            this.IdNganHangThanhToan,
            this.MaThe,
            this.DuoiThe,
            this.NganHangPhatHanhThe,
            this.IdNganHangPH,
            this.NgayLap,
            this.TenThuNgan,
            this.GhiChuTT});
            this.gvHinhThucThanhToan.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvHinhThucThanhToan.GridControl = this.gHinhThucThanhToan;
            this.gvHinhThucThanhToan.Name = "gvHinhThucThanhToan";
            this.gvHinhThucThanhToan.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvHinhThucThanhToan.OptionsSelection.MultiSelect = true;
            this.gvHinhThucThanhToan.OptionsView.ColumnAutoWidth = false;
            this.gvHinhThucThanhToan.OptionsView.ShowDetailButtons = false;
            this.gvHinhThucThanhToan.OptionsView.ShowGroupPanel = false;
            // 
            // SoPhieu
            // 
            this.SoPhieu.Caption = "Số phiếu";
            this.SoPhieu.FieldName = "SoPhieu";
            this.SoPhieu.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.SoPhieu.Name = "SoPhieu";
            this.SoPhieu.OptionsColumn.ReadOnly = true;
            this.SoPhieu.Visible = true;
            this.SoPhieu.VisibleIndex = 0;
            this.SoPhieu.Width = 109;
            // 
            // IdHinhThucThanhToan
            // 
            this.IdHinhThucThanhToan.Caption = "IdHinhThucThanhToan";
            this.IdHinhThucThanhToan.FieldName = "IdHinhThucThanhToan";
            this.IdHinhThucThanhToan.Name = "IdHinhThucThanhToan";
            this.IdHinhThucThanhToan.OptionsColumn.AllowEdit = false;
            // 
            // HinhThucThanhToan
            // 
            this.HinhThucThanhToan.Caption = "Hình thức TT";
            this.HinhThucThanhToan.FieldName = "HinhThucThanhToan";
            this.HinhThucThanhToan.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.HinhThucThanhToan.Name = "HinhThucThanhToan";
            this.HinhThucThanhToan.OptionsColumn.AllowEdit = false;
            this.HinhThucThanhToan.Visible = true;
            this.HinhThucThanhToan.VisibleIndex = 1;
            this.HinhThucThanhToan.Width = 138;
            // 
            // SoTienThanhToan
            // 
            this.SoTienThanhToan.Caption = "Số tiền";
            this.SoTienThanhToan.DisplayFormat.FormatString = "N0";
            this.SoTienThanhToan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SoTienThanhToan.FieldName = "SoTienThanhToan";
            this.SoTienThanhToan.Name = "SoTienThanhToan";
            this.SoTienThanhToan.OptionsColumn.AllowEdit = false;
            this.SoTienThanhToan.Visible = true;
            this.SoTienThanhToan.VisibleIndex = 2;
            this.SoTienThanhToan.Width = 92;
            // 
            // TaiKhoanQuy
            // 
            this.TaiKhoanQuy.Caption = "Tài khoản quỹ";
            this.TaiKhoanQuy.FieldName = "TaiKhoanQuy";
            this.TaiKhoanQuy.Name = "TaiKhoanQuy";
            this.TaiKhoanQuy.Visible = true;
            this.TaiKhoanQuy.VisibleIndex = 3;
            this.TaiKhoanQuy.Width = 158;
            // 
            // ThoiHanThanhToan
            // 
            this.ThoiHanThanhToan.Caption = "Thời hạn thanh toán";
            this.ThoiHanThanhToan.FieldName = "ThoiHanThanhToan";
            this.ThoiHanThanhToan.Name = "ThoiHanThanhToan";
            this.ThoiHanThanhToan.OptionsColumn.AllowEdit = false;
            this.ThoiHanThanhToan.Visible = true;
            this.ThoiHanThanhToan.VisibleIndex = 4;
            this.ThoiHanThanhToan.Width = 162;
            // 
            // IdThoiHanThanhToan
            // 
            this.IdThoiHanThanhToan.Caption = "IdThoiHanThanhToan";
            this.IdThoiHanThanhToan.FieldName = "IdThoiHanThanhToan";
            this.IdThoiHanThanhToan.Name = "IdThoiHanThanhToan";
            this.IdThoiHanThanhToan.OptionsColumn.AllowEdit = false;
            // 
            // SoTaiKhoan
            // 
            this.SoTaiKhoan.Caption = "Số tài khoản";
            this.SoTaiKhoan.FieldName = "SoTaiKhoan";
            this.SoTaiKhoan.Name = "SoTaiKhoan";
            this.SoTaiKhoan.OptionsColumn.AllowEdit = false;
            this.SoTaiKhoan.Visible = true;
            this.SoTaiKhoan.VisibleIndex = 5;
            this.SoTaiKhoan.Width = 128;
            // 
            // ChuTaiKhoan
            // 
            this.ChuTaiKhoan.Caption = "Chủ tài khoản";
            this.ChuTaiKhoan.FieldName = "ChuTaiKhoan";
            this.ChuTaiKhoan.Name = "ChuTaiKhoan";
            this.ChuTaiKhoan.OptionsColumn.AllowEdit = false;
            this.ChuTaiKhoan.Visible = true;
            this.ChuTaiKhoan.VisibleIndex = 6;
            this.ChuTaiKhoan.Width = 176;
            // 
            // NganHangThanhToan
            // 
            this.NganHangThanhToan.Caption = "Ngân hàng thanh toán";
            this.NganHangThanhToan.FieldName = "NganHangThanhToan";
            this.NganHangThanhToan.Name = "NganHangThanhToan";
            this.NganHangThanhToan.OptionsColumn.AllowEdit = false;
            this.NganHangThanhToan.Visible = true;
            this.NganHangThanhToan.VisibleIndex = 7;
            this.NganHangThanhToan.Width = 166;
            // 
            // IdNganHangThanhToan
            // 
            this.IdNganHangThanhToan.Caption = "IdNganHangThanhToan";
            this.IdNganHangThanhToan.FieldName = "IdNganHangThanhToan";
            this.IdNganHangThanhToan.Name = "IdNganHangThanhToan";
            this.IdNganHangThanhToan.OptionsColumn.AllowEdit = false;
            // 
            // MaThe
            // 
            this.MaThe.Caption = "Mã thẻ";
            this.MaThe.FieldName = "MaThe";
            this.MaThe.Name = "MaThe";
            this.MaThe.OptionsColumn.AllowEdit = false;
            this.MaThe.Visible = true;
            this.MaThe.VisibleIndex = 8;
            this.MaThe.Width = 95;
            // 
            // DuoiThe
            // 
            this.DuoiThe.Caption = "Đuôi thẻ";
            this.DuoiThe.FieldName = "DuoiThe";
            this.DuoiThe.Name = "DuoiThe";
            this.DuoiThe.OptionsColumn.AllowEdit = false;
            this.DuoiThe.Visible = true;
            this.DuoiThe.VisibleIndex = 9;
            this.DuoiThe.Width = 117;
            // 
            // NganHangPhatHanhThe
            // 
            this.NganHangPhatHanhThe.Caption = "Ngân hàng phát hành thẻ";
            this.NganHangPhatHanhThe.FieldName = "NganHangPhatHanhThe";
            this.NganHangPhatHanhThe.Name = "NganHangPhatHanhThe";
            this.NganHangPhatHanhThe.OptionsColumn.AllowEdit = false;
            this.NganHangPhatHanhThe.Visible = true;
            this.NganHangPhatHanhThe.VisibleIndex = 10;
            this.NganHangPhatHanhThe.Width = 195;
            // 
            // IdNganHangPH
            // 
            this.IdNganHangPH.Caption = "IdNganHangPH";
            this.IdNganHangPH.FieldName = "IdNganHangPH";
            this.IdNganHangPH.Name = "IdNganHangPH";
            this.IdNganHangPH.OptionsColumn.AllowEdit = false;
            // 
            // NgayLap
            // 
            this.NgayLap.Caption = "Ngày lập";
            this.NgayLap.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.NgayLap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgayLap.FieldName = "NgayLap";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.OptionsColumn.AllowEdit = false;
            this.NgayLap.Visible = true;
            this.NgayLap.VisibleIndex = 11;
            this.NgayLap.Width = 114;
            // 
            // TenThuNgan
            // 
            this.TenThuNgan.Caption = "Thu ngân";
            this.TenThuNgan.FieldName = "TenThuNgan";
            this.TenThuNgan.Name = "TenThuNgan";
            this.TenThuNgan.Visible = true;
            this.TenThuNgan.VisibleIndex = 12;
            this.TenThuNgan.Width = 133;
            // 
            // GhiChuTT
            // 
            this.GhiChuTT.Caption = "Ghi chú";
            this.GhiChuTT.FieldName = "NoiDungThanhToan";
            this.GhiChuTT.Name = "GhiChuTT";
            this.GhiChuTT.Visible = true;
            this.GhiChuTT.VisibleIndex = 13;
            this.GhiChuTT.Width = 179;
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.gHinhThucThanhToan;
            this.gridView4.Name = "gridView4";
            // 
            // btnXoaTT
            // 
            this.btnXoaTT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoaTT.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaTT.Appearance.Options.UseFont = true;
            this.btnXoaTT.Enabled = false;
            this.btnXoaTT.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaTT.Image")));
            this.btnXoaTT.Location = new System.Drawing.Point(5, 248);
            this.btnXoaTT.Name = "btnXoaTT";
            this.btnXoaTT.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnXoaTT.Size = new System.Drawing.Size(140, 30);
            this.btnXoaTT.TabIndex = 1;
            this.btnXoaTT.Text = "&Xóa thanh toán (F4)";
            this.btnXoaTT.Click += new System.EventHandler(this.btnXoaTT_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThanhToan.Appearance.Options.UseFont = true;
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.Location = new System.Drawing.Point(588, 248);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnThanhToan.Size = new System.Drawing.Size(128, 30);
            this.btnThanhToan.TabIndex = 0;
            this.btnThanhToan.Text = "&Thanh toán (F10)";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 13);
            this.label12.TabIndex = 103;
            this.label12.Text = "Tổng tiền đã trả lại khách";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(10, 67);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(134, 13);
            this.lblTongTien.TabIndex = 94;
            this.lblTongTien.Text = "Tổng tiền khách đã trả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 99;
            this.label8.Text = "Tổng giá trị đơn hàng";
            // 
            // lblTienVAT
            // 
            this.lblTienVAT.AutoSize = true;
            this.lblTienVAT.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienVAT.Location = new System.Drawing.Point(10, 153);
            this.lblTienVAT.Name = "lblTienVAT";
            this.lblTienVAT.Size = new System.Drawing.Size(137, 13);
            this.lblTienVAT.TabIndex = 93;
            this.lblTienVAT.Text = "Tổng tiền còn nợ khách";
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
            this.toolStripSeparator2,
            this.tsbEdit,
            this.tsbUpdate,
            this.toolStripSeparator3,
            this.tsbPrint,
            this.toolStripSeparator4,
            this.tsbClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1020, 25);
            this.toolStrip1.TabIndex = 86;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.tsbUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdate.Image")));
            this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdate.Name = "tsbUpdate";
            this.tsbUpdate.Size = new System.Drawing.Size(98, 22);
            this.tsbUpdate.Text = "Cập nhật (F7)";
            this.tsbUpdate.Click += new System.EventHandler(this.tsbUpdate_Click);
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
            // mstNgayLapPhieu
            // 
            this.mstNgayLapPhieu.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.mstNgayLapPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mstNgayLapPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mstNgayLapPhieu.Location = new System.Drawing.Point(102, 108);
            this.mstNgayLapPhieu.Name = "mstNgayLapPhieu";
            this.mstNgayLapPhieu.Size = new System.Drawing.Size(157, 20);
            this.mstNgayLapPhieu.TabIndex = 3;
            this.mstNgayLapPhieu.Value = new System.DateTime(2012, 8, 19, 0, 0, 0, 0);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label32.Location = new System.Drawing.Point(48, 111);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(49, 13);
            this.label32.TabIndex = 102;
            this.label32.Text = "Ngày lập";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label35.Location = new System.Drawing.Point(780, 89);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(44, 15);
            this.label35.TabIndex = 97;
            this.label35.Text = "CMND";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label10.Location = new System.Drawing.Point(589, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 95;
            this.label10.Text = "Điện thoại";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label31.Location = new System.Drawing.Point(33, 87);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(64, 13);
            this.label31.TabIndex = 89;
            this.label31.Text = "Số giao dịch";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label13.Location = new System.Drawing.Point(600, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 116;
            this.label13.Text = "Giới tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label1.Location = new System.Drawing.Point(590, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 114;
            this.label1.Text = "Họ tên KH";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(778, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 15);
            this.label14.TabIndex = 117;
            this.label14.Text = "Độ tuổi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(785, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 115;
            this.label2.Text = "Email";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.Enabled = false;
            this.cboGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "",
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(649, 38);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(122, 21);
            this.cboGioiTinh.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label3.Location = new System.Drawing.Point(585, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 112;
            this.label3.Text = "Mã số thuế";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label4.Location = new System.Drawing.Point(564, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 113;
            this.label4.Text = "Địa chỉ hóa đơn";
            // 
            // grThongTin
            // 
            this.grThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grThongTin.Controls.Add(this.bteTrungTam);
            this.grThongTin.Controls.Add(this.label18);
            this.grThongTin.Controls.Add(this.txtDiaChiGiaoHang);
            this.grThongTin.Controls.Add(this.label9);
            this.grThongTin.Controls.Add(this.bteKhachHang);
            this.grThongTin.Controls.Add(this.lblKhachHang);
            this.grThongTin.Controls.Add(this.bteKhoXuat);
            this.grThongTin.Controls.Add(this.label17);
            this.grThongTin.Controls.Add(this.btnTimOrderKH);
            this.grThongTin.Controls.Add(this.label19);
            this.grThongTin.Controls.Add(this.label20);
            this.grThongTin.Controls.Add(this.txtSoSerie);
            this.grThongTin.Controls.Add(this.txtKyHieu);
            this.grThongTin.Controls.Add(this.txtDiaChi);
            this.grThongTin.Controls.Add(this.label4);
            this.grThongTin.Controls.Add(this.label35);
            this.grThongTin.Controls.Add(this.txtMaSoThue);
            this.grThongTin.Controls.Add(this.txtCMND);
            this.grThongTin.Controls.Add(this.label10);
            this.grThongTin.Controls.Add(this.txtEmail);
            this.grThongTin.Controls.Add(this.txtDienThoai);
            this.grThongTin.Controls.Add(this.txtHoTenKhachHang);
            this.grThongTin.Controls.Add(this.label2);
            this.grThongTin.Controls.Add(this.txtTuoi);
            this.grThongTin.Controls.Add(this.txtSoOrderKH);
            this.grThongTin.Controls.Add(this.mstNgayLapPhieu);
            this.grThongTin.Controls.Add(this.label32);
            this.grThongTin.Controls.Add(this.label13);
            this.grThongTin.Controls.Add(this.label31);
            this.grThongTin.Controls.Add(this.label3);
            this.grThongTin.Controls.Add(this.label14);
            this.grThongTin.Controls.Add(this.label1);
            this.grThongTin.Controls.Add(this.cboGioiTinh);
            this.grThongTin.Location = new System.Drawing.Point(9, 29);
            this.grThongTin.Name = "grThongTin";
            this.grThongTin.Size = new System.Drawing.Size(999, 160);
            this.grThongTin.TabIndex = 0;
            this.grThongTin.TabStop = false;
            // 
            // bteTrungTam
            // 
            this.bteTrungTam.Enabled = false;
            this.bteTrungTam.Location = new System.Drawing.Point(102, 13);
            this.bteTrungTam.Name = "bteTrungTam";
            this.bteTrungTam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteTrungTam.Properties.Appearance.Options.UseFont = true;
            this.bteTrungTam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteTrungTam.Size = new System.Drawing.Size(332, 22);
            this.bteTrungTam.TabIndex = 131;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(15, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 13);
            this.label18.TabIndex = 132;
            this.label18.Text = "Trung tâm nhập";
            // 
            // txtDiaChiGiaoHang
            // 
            this.txtDiaChiGiaoHang.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiaChiGiaoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiGiaoHang.Location = new System.Drawing.Point(649, 133);
            this.txtDiaChiGiaoHang.Multiline = true;
            this.txtDiaChiGiaoHang.Name = "txtDiaChiGiaoHang";
            this.txtDiaChiGiaoHang.ReadOnly = true;
            this.txtDiaChiGiaoHang.Size = new System.Drawing.Size(320, 21);
            this.txtDiaChiGiaoHang.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label9.Location = new System.Drawing.Point(556, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 128;
            this.label9.Text = "Địa chỉ giao hàng";
            // 
            // bteKhachHang
            // 
            this.bteKhachHang.Location = new System.Drawing.Point(102, 61);
            this.bteKhachHang.Name = "bteKhachHang";
            this.bteKhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteKhachHang.Size = new System.Drawing.Size(332, 20);
            this.bteKhachHang.TabIndex = 1;
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblKhachHang.Location = new System.Drawing.Point(34, 64);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(63, 13);
            this.lblKhachHang.TabIndex = 126;
            this.lblKhachHang.Text = "Khách hàng";
            // 
            // bteKhoXuat
            // 
            this.bteKhoXuat.Location = new System.Drawing.Point(102, 38);
            this.bteKhoXuat.Name = "bteKhoXuat";
            this.bteKhoXuat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteKhoXuat.Size = new System.Drawing.Size(332, 20);
            this.bteKhoXuat.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label17.Location = new System.Drawing.Point(47, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 124;
            this.label17.Text = "Kho xuất";
            // 
            // btnTimOrderKH
            // 
            this.btnTimOrderKH.Enabled = false;
            this.btnTimOrderKH.Image = ((System.Drawing.Image)(resources.GetObject("btnTimOrderKH.Image")));
            this.btnTimOrderKH.Location = new System.Drawing.Point(265, 107);
            this.btnTimOrderKH.Name = "btnTimOrderKH";
            this.btnTimOrderKH.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnTimOrderKH.Size = new System.Drawing.Size(28, 23);
            this.btnTimOrderKH.TabIndex = 122;
            this.btnTimOrderKH.Visible = false;
            this.btnTimOrderKH.Click += new System.EventHandler(this.btnTimOrderKH_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label19.Location = new System.Drawing.Point(227, 136);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 13);
            this.label19.TabIndex = 121;
            this.label19.Text = "Số hóa đơn";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label20.Location = new System.Drawing.Point(55, 135);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 13);
            this.label20.TabIndex = 120;
            this.label20.Text = "Ký hiệu";
            // 
            // txtSoSerie
            // 
            this.txtSoSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoSerie.Location = new System.Drawing.Point(288, 133);
            this.txtSoSerie.Name = "txtSoSerie";
            this.txtSoSerie.Size = new System.Drawing.Size(146, 20);
            this.txtSoSerie.TabIndex = 5;
            // 
            // txtKyHieu
            // 
            this.txtKyHieu.BackColor = System.Drawing.SystemColors.Window;
            this.txtKyHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKyHieu.Location = new System.Drawing.Point(102, 132);
            this.txtKyHieu.Name = "txtKyHieu";
            this.txtKyHieu.ReadOnly = true;
            this.txtKyHieu.Size = new System.Drawing.Size(119, 20);
            this.txtKyHieu.TabIndex = 4;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(649, 109);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(320, 21);
            this.txtDiaChi.TabIndex = 13;
            // 
            // txtMaSoThue
            // 
            this.txtMaSoThue.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaSoThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSoThue.Location = new System.Drawing.Point(649, 61);
            this.txtMaSoThue.Name = "txtMaSoThue";
            this.txtMaSoThue.ReadOnly = true;
            this.txtMaSoThue.Size = new System.Drawing.Size(122, 20);
            this.txtMaSoThue.TabIndex = 9;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(829, 85);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.ReadOnly = true;
            this.txtCMND.Size = new System.Drawing.Size(140, 21);
            this.txtCMND.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtEmail.Location = new System.Drawing.Point(829, 61);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(140, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(649, 85);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.ReadOnly = true;
            this.txtDienThoai.Size = new System.Drawing.Size(122, 21);
            this.txtDienThoai.TabIndex = 11;
            // 
            // txtHoTenKhachHang
            // 
            this.txtHoTenKhachHang.BackColor = System.Drawing.SystemColors.Window;
            this.txtHoTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtHoTenKhachHang.Location = new System.Drawing.Point(649, 15);
            this.txtHoTenKhachHang.MaxLength = 55;
            this.txtHoTenKhachHang.Name = "txtHoTenKhachHang";
            this.txtHoTenKhachHang.ReadOnly = true;
            this.txtHoTenKhachHang.Size = new System.Drawing.Size(320, 20);
            this.txtHoTenKhachHang.TabIndex = 6;
            // 
            // txtTuoi
            // 
            this.txtTuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTuoi.Location = new System.Drawing.Point(829, 38);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.ReadOnly = true;
            this.txtTuoi.Size = new System.Drawing.Size(140, 20);
            this.txtTuoi.TabIndex = 8;
            // 
            // txtSoOrderKH
            // 
            this.txtSoOrderKH.BackColor = System.Drawing.Color.White;
            this.txtSoOrderKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoOrderKH.Location = new System.Drawing.Point(102, 84);
            this.txtSoOrderKH.Name = "txtSoOrderKH";
            this.txtSoOrderKH.Size = new System.Drawing.Size(332, 20);
            this.txtSoOrderKH.TabIndex = 2;
            this.txtSoOrderKH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoOrderKH_KeyDown);
            // 
            // txtTienConNo
            // 
            this.txtTienConNo.BackColor = System.Drawing.SystemColors.Control;
            this.txtTienConNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienConNo.Location = new System.Drawing.Point(102, 170);
            this.txtTienConNo.Name = "txtTienConNo";
            this.txtTienConNo.ReadOnly = true;
            this.txtTienConNo.Size = new System.Drawing.Size(157, 20);
            this.txtTienConNo.TabIndex = 3;
            this.txtTienConNo.Text = "0,000.00";
            this.txtTienConNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTienThucTra
            // 
            this.txtTienThucTra.BackColor = System.Drawing.SystemColors.Control;
            this.txtTienThucTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienThucTra.Location = new System.Drawing.Point(102, 127);
            this.txtTienThucTra.Name = "txtTienThucTra";
            this.txtTienThucTra.ReadOnly = true;
            this.txtTienThucTra.Size = new System.Drawing.Size(157, 20);
            this.txtTienThucTra.TabIndex = 2;
            this.txtTienThucTra.Text = "0,000.00";
            this.txtTienThucTra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTongTienThanhToan
            // 
            this.txtTongTienThanhToan.BackColor = System.Drawing.SystemColors.Control;
            this.txtTongTienThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTienThanhToan.Location = new System.Drawing.Point(102, 84);
            this.txtTongTienThanhToan.Name = "txtTongTienThanhToan";
            this.txtTongTienThanhToan.ReadOnly = true;
            this.txtTongTienThanhToan.Size = new System.Drawing.Size(157, 20);
            this.txtTongTienThanhToan.TabIndex = 1;
            this.txtTongTienThanhToan.Text = "0,000.00";
            this.txtTongTienThanhToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTongTienHang
            // 
            this.txtTongTienHang.BackColor = System.Drawing.SystemColors.Control;
            this.txtTongTienHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTienHang.Location = new System.Drawing.Point(102, 40);
            this.txtTongTienHang.Name = "txtTongTienHang";
            this.txtTongTienHang.ReadOnly = true;
            this.txtTongTienHang.Size = new System.Drawing.Size(157, 20);
            this.txtTongTienHang.TabIndex = 0;
            this.txtTongTienHang.Text = "0,000.00";
            this.txtTongTienHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // bteThoiHanThanhToan
            // 
            this.bteThoiHanThanhToan.Location = new System.Drawing.Point(24, 215);
            this.bteThoiHanThanhToan.Name = "bteThoiHanThanhToan";
            this.bteThoiHanThanhToan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteThoiHanThanhToan.Size = new System.Drawing.Size(235, 20);
            this.bteThoiHanThanhToan.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.bteThoiHanThanhToan);
            this.groupBox1.Controls.Add(this.txtTienConNo);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.txtTienThucTra);
            this.groupBox1.Controls.Add(this.lblTienVAT);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtTongTienHang);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblTongTien);
            this.groupBox1.Controls.Add(this.txtTongTienThanhToan);
            this.groupBox1.Location = new System.Drawing.Point(9, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 282);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thanh toán";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(7, 198);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(122, 13);
            this.label27.TabIndex = 129;
            this.label27.Text = "Thời hạn Thanh toán";
            // 
            // frmBH_LapPhieuChi
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 489);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grPayments);
            this.Controls.Add(this.grThongTin);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "frmBH_LapPhieuChi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập phiếu chi";
            this.Load += new System.EventHandler(this.frmPhieuXuat_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhieuXuatHoaDon_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPhieuXuat_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grPayments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gHinhThucThanhToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHinhThucThanhToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grThongTin.ResumeLayout(false);
            this.grThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhoXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteThoiHanThanhToan.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox grPayments;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTienVAT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbUpdate;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private GtidTextBox textBox4;
        private GtidTextBox textBox5;
        private GtidTextBox textBox6;
        private GtidTextBox txtTongTienThanhToan;
        private GtidTextBox txtTongTienHang;
        private GtidTextBox txtTienConNo;
        private GtidTextBox txtTienThucTra;
        private GtidButton btnThanhToan;
        private GtidTextBox txtTuoi;
        private GtidTextBox txtEmail;
        private GtidTextBox txtMaSoThue;
        private System.Windows.Forms.Label label13;
        private GtidTextBox txtDiaChi;
        private GtidTextBox txtHoTenKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private GtidButton btnXoaTT;
        private System.Windows.Forms.DateTimePicker mstNgayLapPhieu;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label35;
        private GtidTextBox txtCMND;
        private System.Windows.Forms.Label label10;
        private GtidTextBox txtDienThoai;
        private GtidTextBox txtSoOrderKH;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.GroupBox grThongTin;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private GtidTextBox txtSoSerie;
        private GtidTextBox txtKyHieu;
        private GtidButton btnTimOrderKH;
        private DevExpress.XtraEditors.ButtonEdit bteKhoXuat;
        private System.Windows.Forms.Label label17;
        private DevExpress.XtraEditors.ButtonEdit bteKhachHang;
        private System.Windows.Forms.Label lblKhachHang;
        private GtidTextBox txtDiaChiGiaoHang;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.ButtonEdit bteThoiHanThanhToan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label27;
        private DevExpress.XtraEditors.ButtonEdit bteTrungTam;
        private System.Windows.Forms.Label label18;
        private DevExpress.XtraGrid.GridControl gHinhThucThanhToan;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHinhThucThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn SoPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn IdHinhThucThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn HinhThucThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn SoTienThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn TaiKhoanQuy;
        private DevExpress.XtraGrid.Columns.GridColumn ThoiHanThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn IdThoiHanThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn SoTaiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn ChuTaiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn NganHangThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn IdNganHangThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn MaThe;
        private DevExpress.XtraGrid.Columns.GridColumn DuoiThe;
        private DevExpress.XtraGrid.Columns.GridColumn NganHangPhatHanhThe;
        private DevExpress.XtraGrid.Columns.GridColumn IdNganHangPH;
        private DevExpress.XtraGrid.Columns.GridColumn NgayLap;
        private DevExpress.XtraGrid.Columns.GridColumn TenThuNgan;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChuTT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private GtidButton btnThanhToanKhac;
    }
}