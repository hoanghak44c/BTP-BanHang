using System.Drawing;
using QLBH.Core.Form;
namespace QLBanHang.Modules.BanHang
{
    partial class frmBH_ViewDonHangBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBH_ViewDonHangBan));
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
            this.grSanPhamBan = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gSanPhamBan = new DevExpress.XtraGrid.GridControl();
            this.gvSanPhamBan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdChungTuChiTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSanPhamBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPhamBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyleChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienSauChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyleVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyleThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeThuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThuongNong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaTheoBangGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaNiemYet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaWebSite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoKhuyenMai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrungMaVach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiHangKem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoaiHangKem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLePhanBo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongOld = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbCopy = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbConfirm = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPayment = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslInfor = new System.Windows.Forms.ToolStripLabel();
            this.bteThuongVien = new DevExpress.XtraEditors.ButtonEdit();
            this.mstNgayHenGiaoHang = new System.Windows.Forms.DateTimePicker();
            this.mstNgayLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.label32 = new System.Windows.Forms.Label();
            this.txtSoOrderKH = new QLBH.Core.Form.GtidTextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtSoChungTuGoc = new QLBH.Core.Form.GtidTextBox();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblSoPhieu = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.txtDiaChi = new QLBH.Core.Form.GtidTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSoSerie = new QLBH.Core.Form.GtidTextBox();
            this.bteKhachLe = new DevExpress.XtraEditors.ButtonEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoHDDaMua = new QLBH.Core.Form.GtidTextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTenKhachHang = new QLBH.Core.Form.GtidTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.grThongTin = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboGiaoHang = new System.Windows.Forms.ComboBox();
            this.txtCongTy = new QLBH.Core.Form.GtidTextBox();
            this.txtSoPhieuDC = new QLBH.Core.Form.GtidTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new QLBH.Core.Form.GtidTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.bteKhachHang = new DevExpress.XtraEditors.ButtonEdit();
            this.bteKhoXuat = new DevExpress.XtraEditors.ButtonEdit();
            this.textBox4 = new QLBH.Core.Form.GtidTextBox();
            this.textBox5 = new QLBH.Core.Form.GtidTextBox();
            this.textBox6 = new QLBH.Core.Form.GtidTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDraft = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grSanPhamBan.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSanPhamBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPhamBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteThuongVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhachLe.Properties)).BeginInit();
            this.grThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhoXuat.Properties)).BeginInit();
            this.statusStrip1.SuspendLayout();
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
            // grSanPhamBan
            // 
            this.grSanPhamBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grSanPhamBan.Controls.Add(this.tableLayoutPanel1);
            this.grSanPhamBan.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.grSanPhamBan.ForeColor = System.Drawing.Color.Black;
            this.grSanPhamBan.Location = new System.Drawing.Point(0, 147);
            this.grSanPhamBan.Name = "grSanPhamBan";
            this.grSanPhamBan.Size = new System.Drawing.Size(1236, 443);
            this.grSanPhamBan.TabIndex = 0;
            this.grSanPhamBan.TabStop = false;
            this.grSanPhamBan.Text = "Danh sách mặt hàng";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gSanPhamBan, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1223, 417);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // gSanPhamBan
            // 
            this.gSanPhamBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gSanPhamBan.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gSanPhamBan.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gSanPhamBan.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gSanPhamBan.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gSanPhamBan.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gSanPhamBan.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gSanPhamBan.Location = new System.Drawing.Point(3, 3);
            this.gSanPhamBan.MainView = this.gvSanPhamBan;
            this.gSanPhamBan.Name = "gSanPhamBan";
            this.gSanPhamBan.Size = new System.Drawing.Size(1217, 411);
            this.gSanPhamBan.TabIndex = 0;
            this.gSanPhamBan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSanPhamBan,
            this.gridView1});
            // 
            // gvSanPhamBan
            // 
            this.gvSanPhamBan.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvSanPhamBan.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvSanPhamBan.Appearance.FocusedCell.Options.UseFont = true;
            this.gvSanPhamBan.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvSanPhamBan.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvSanPhamBan.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvSanPhamBan.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvSanPhamBan.Appearance.Row.BackColor = System.Drawing.Color.Silver;
            this.gvSanPhamBan.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvSanPhamBan.Appearance.Row.Options.UseBackColor = true;
            this.gvSanPhamBan.Appearance.Row.Options.UseBorderColor = true;
            this.gvSanPhamBan.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvSanPhamBan.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvSanPhamBan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdChungTu,
            this.IdChungTuChiTiet,
            this.IdSanPham,
            this.MaSanPham,
            this.TenSanPham,
            this.IdSanPhamBan,
            this.TenSanPhamBan,
            this.DonViTinh,
            this.SoLuong,
            this.DonGia,
            this.TyleChietKhau,
            this.TienChietKhau,
            this.TienSauChietKhau,
            this.TyleVAT,
            this.TienVAT,
            this.TyleThanhToan,
            this.ThanhTien,
            this.GhiChu,
            this.TyLeThuong,
            this.ThuongNong,
            this.GiaTheoBangGia,
            this.GiaNiemYet,
            this.GiaWebSite,
            this.NoKhuyenMai,
            this.TrungMaVach,
            this.LoaiHangKem,
            this.TenLoaiHangKem,
            this.TyLePhanBo,
            this.SoLuongOld});
            this.gvSanPhamBan.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvSanPhamBan.GridControl = this.gSanPhamBan;
            this.gvSanPhamBan.Name = "gvSanPhamBan";
            this.gvSanPhamBan.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvSanPhamBan.OptionsView.ColumnAutoWidth = false;
            this.gvSanPhamBan.OptionsView.ShowDetailButtons = false;
            this.gvSanPhamBan.OptionsView.ShowGroupPanel = false;
            // 
            // IdChungTu
            // 
            this.IdChungTu.Caption = "IdChungTu";
            this.IdChungTu.FieldName = "IdChungTu";
            this.IdChungTu.Name = "IdChungTu";
            this.IdChungTu.OptionsColumn.AllowEdit = false;
            this.IdChungTu.OptionsColumn.AllowFocus = false;
            this.IdChungTu.OptionsColumn.AllowMove = false;
            this.IdChungTu.OptionsColumn.ReadOnly = true;
            this.IdChungTu.Width = 115;
            // 
            // IdChungTuChiTiet
            // 
            this.IdChungTuChiTiet.Caption = "IdChungTuChiTiet";
            this.IdChungTuChiTiet.FieldName = "IdChungTuChiTiet";
            this.IdChungTuChiTiet.Name = "IdChungTuChiTiet";
            this.IdChungTuChiTiet.OptionsColumn.AllowEdit = false;
            this.IdChungTuChiTiet.OptionsColumn.AllowFocus = false;
            this.IdChungTuChiTiet.OptionsColumn.AllowMove = false;
            this.IdChungTuChiTiet.OptionsColumn.ReadOnly = true;
            this.IdChungTuChiTiet.Width = 234;
            // 
            // IdSanPham
            // 
            this.IdSanPham.Caption = "IdSanPham";
            this.IdSanPham.FieldName = "IdSanPham";
            this.IdSanPham.Name = "IdSanPham";
            this.IdSanPham.OptionsColumn.AllowEdit = false;
            this.IdSanPham.Width = 96;
            // 
            // MaSanPham
            // 
            this.MaSanPham.Caption = "Mã sản phẩm";
            this.MaSanPham.FieldName = "MaSanPham";
            this.MaSanPham.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.OptionsColumn.ReadOnly = true;
            this.MaSanPham.Visible = true;
            this.MaSanPham.VisibleIndex = 0;
            this.MaSanPham.Width = 99;
            // 
            // TenSanPham
            // 
            this.TenSanPham.Caption = "Tên sản phẩm";
            this.TenSanPham.FieldName = "TenSanPham";
            this.TenSanPham.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.OptionsColumn.ReadOnly = true;
            this.TenSanPham.Visible = true;
            this.TenSanPham.VisibleIndex = 1;
            this.TenSanPham.Width = 251;
            // 
            // IdSanPhamBan
            // 
            this.IdSanPhamBan.Caption = "IdSanPhamBan";
            this.IdSanPhamBan.FieldName = "IdSanPhamBan";
            this.IdSanPhamBan.Name = "IdSanPhamBan";
            this.IdSanPhamBan.OptionsColumn.AllowEdit = false;
            this.IdSanPhamBan.Width = 95;
            // 
            // TenSanPhamBan
            // 
            this.TenSanPhamBan.Caption = "TenSanPhamBan";
            this.TenSanPhamBan.FieldName = "TenSanPhamBan";
            this.TenSanPhamBan.Name = "TenSanPhamBan";
            this.TenSanPhamBan.OptionsColumn.AllowEdit = false;
            this.TenSanPhamBan.Width = 238;
            // 
            // DonViTinh
            // 
            this.DonViTinh.Caption = "Đơn vị tính";
            this.DonViTinh.FieldName = "DonViTinh";
            this.DonViTinh.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.OptionsColumn.ReadOnly = true;
            this.DonViTinh.Visible = true;
            this.DonViTinh.VisibleIndex = 2;
            this.DonViTinh.Width = 83;
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
            this.SoLuong.Width = 73;
            // 
            // DonGia
            // 
            this.DonGia.Caption = "Đơn giá";
            this.DonGia.DisplayFormat.FormatString = "N0";
            this.DonGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DonGia.FieldName = "DonGia";
            this.DonGia.Name = "DonGia";
            this.DonGia.OptionsColumn.ReadOnly = true;
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 4;
            this.DonGia.Width = 95;
            // 
            // TyleChietKhau
            // 
            this.TyleChietKhau.Caption = "CK (%)";
            this.TyleChietKhau.DisplayFormat.FormatString = "N0";
            this.TyleChietKhau.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyleChietKhau.FieldName = "TyleChietKhau";
            this.TyleChietKhau.Name = "TyleChietKhau";
            this.TyleChietKhau.OptionsColumn.ReadOnly = true;
            this.TyleChietKhau.Visible = true;
            this.TyleChietKhau.VisibleIndex = 5;
            this.TyleChietKhau.Width = 80;
            // 
            // TienChietKhau
            // 
            this.TienChietKhau.Caption = "Tiền CK";
            this.TienChietKhau.DisplayFormat.FormatString = "N0";
            this.TienChietKhau.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TienChietKhau.FieldName = "TienChietKhau";
            this.TienChietKhau.Name = "TienChietKhau";
            this.TienChietKhau.OptionsColumn.ReadOnly = true;
            this.TienChietKhau.Visible = true;
            this.TienChietKhau.VisibleIndex = 6;
            this.TienChietKhau.Width = 94;
            // 
            // TienSauChietKhau
            // 
            this.TienSauChietKhau.Caption = "Tiền sau CK";
            this.TienSauChietKhau.DisplayFormat.FormatString = "N0";
            this.TienSauChietKhau.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TienSauChietKhau.FieldName = "TienSauChietKhau";
            this.TienSauChietKhau.Name = "TienSauChietKhau";
            this.TienSauChietKhau.OptionsColumn.ReadOnly = true;
            this.TienSauChietKhau.Visible = true;
            this.TienSauChietKhau.VisibleIndex = 7;
            this.TienSauChietKhau.Width = 98;
            // 
            // TyleVAT
            // 
            this.TyleVAT.Caption = "VAT (%)";
            this.TyleVAT.DisplayFormat.FormatString = "N0";
            this.TyleVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyleVAT.FieldName = "TyleVAT";
            this.TyleVAT.Name = "TyleVAT";
            this.TyleVAT.OptionsColumn.ReadOnly = true;
            this.TyleVAT.Visible = true;
            this.TyleVAT.VisibleIndex = 8;
            this.TyleVAT.Width = 99;
            // 
            // TienVAT
            // 
            this.TienVAT.Caption = "Tiền VAT";
            this.TienVAT.DisplayFormat.FormatString = "N0";
            this.TienVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TienVAT.FieldName = "TienVAT";
            this.TienVAT.Name = "TienVAT";
            this.TienVAT.OptionsColumn.ReadOnly = true;
            this.TienVAT.Visible = true;
            this.TienVAT.VisibleIndex = 9;
            this.TienVAT.Width = 95;
            // 
            // TyleThanhToan
            // 
            this.TyleThanhToan.Caption = "Tỷ lệ thanh toán";
            this.TyleThanhToan.DisplayFormat.FormatString = "N0";
            this.TyleThanhToan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyleThanhToan.FieldName = "TyLeThanhToan";
            this.TyleThanhToan.Name = "TyleThanhToan";
            this.TyleThanhToan.OptionsColumn.AllowEdit = false;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Caption = "Thành tiền";
            this.ThanhTien.DisplayFormat.FormatString = "N0";
            this.ThanhTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ThanhTien.FieldName = "ThanhTien";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Visible = true;
            this.ThanhTien.VisibleIndex = 10;
            this.ThanhTien.Width = 85;
            // 
            // GhiChu
            // 
            this.GhiChu.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.GhiChu.AppearanceCell.Options.UseBackColor = true;
            this.GhiChu.Caption = "Ghi chú";
            this.GhiChu.FieldName = "GhiChu";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Visible = true;
            this.GhiChu.VisibleIndex = 11;
            this.GhiChu.Width = 367;
            // 
            // TyLeThuong
            // 
            this.TyLeThuong.Caption = "TyLeThuong";
            this.TyLeThuong.FieldName = "TyLeThuong";
            this.TyLeThuong.Name = "TyLeThuong";
            this.TyLeThuong.OptionsColumn.AllowEdit = false;
            // 
            // ThuongNong
            // 
            this.ThuongNong.Caption = "ThuongNong";
            this.ThuongNong.FieldName = "ThuongNong";
            this.ThuongNong.Name = "ThuongNong";
            this.ThuongNong.OptionsColumn.AllowEdit = false;
            // 
            // GiaTheoBangGia
            // 
            this.GiaTheoBangGia.Caption = "GiaTheoBangGia";
            this.GiaTheoBangGia.FieldName = "GiaTheoBangGia";
            this.GiaTheoBangGia.Name = "GiaTheoBangGia";
            this.GiaTheoBangGia.OptionsColumn.AllowEdit = false;
            // 
            // GiaNiemYet
            // 
            this.GiaNiemYet.Caption = "GiaNiemYet";
            this.GiaNiemYet.FieldName = "GiaNiemYet";
            this.GiaNiemYet.Name = "GiaNiemYet";
            this.GiaNiemYet.OptionsColumn.AllowEdit = false;
            // 
            // GiaWebSite
            // 
            this.GiaWebSite.Caption = "GiaWebSite";
            this.GiaWebSite.FieldName = "GiaWebSite";
            this.GiaWebSite.Name = "GiaWebSite";
            this.GiaWebSite.OptionsColumn.AllowEdit = false;
            // 
            // NoKhuyenMai
            // 
            this.NoKhuyenMai.Caption = "NoKhuyenMai";
            this.NoKhuyenMai.FieldName = "NoKhuyenMai";
            this.NoKhuyenMai.Name = "NoKhuyenMai";
            this.NoKhuyenMai.OptionsColumn.AllowEdit = false;
            // 
            // TrungMaVach
            // 
            this.TrungMaVach.Caption = "TrungMaVach";
            this.TrungMaVach.FieldName = "TrungMaVach";
            this.TrungMaVach.Name = "TrungMaVach";
            this.TrungMaVach.OptionsColumn.AllowEdit = false;
            // 
            // LoaiHangKem
            // 
            this.LoaiHangKem.Caption = "LoaiHangKem";
            this.LoaiHangKem.FieldName = "LoaiHangKem";
            this.LoaiHangKem.Name = "LoaiHangKem";
            this.LoaiHangKem.OptionsColumn.AllowEdit = false;
            // 
            // TenLoaiHangKem
            // 
            this.TenLoaiHangKem.Caption = "Loại mặt hàng";
            this.TenLoaiHangKem.FieldName = "TenLoaiHangKem";
            this.TenLoaiHangKem.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.TenLoaiHangKem.Name = "TenLoaiHangKem";
            this.TenLoaiHangKem.OptionsColumn.ReadOnly = true;
            this.TenLoaiHangKem.Visible = true;
            this.TenLoaiHangKem.VisibleIndex = 12;
            this.TenLoaiHangKem.Width = 108;
            // 
            // TyLePhanBo
            // 
            this.TyLePhanBo.Caption = "TyLePhanBo";
            this.TyLePhanBo.FieldName = "TyLePhanBo";
            this.TyLePhanBo.Name = "TyLePhanBo";
            // 
            // SoLuongOld
            // 
            this.SoLuongOld.Caption = "gridColumn1";
            this.SoLuongOld.FieldName = "SoLuongOld";
            this.SoLuongOld.Name = "SoLuongOld";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gSanPhamBan;
            this.gridView1.Name = "gridView1";
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
            this.tsbCopy,
            this.tsbEdit,
            this.tsbUpdate,
            this.tsbDelete,
            this.toolStripSeparator3,
            this.tsbConfirm,
            this.tsbPrint,
            this.toolStripSeparator4,
            this.tsbPayment,
            this.toolStripSeparator5,
            this.tsbClose,
            this.toolStripSeparator1,
            this.tslInfor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1236, 25);
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
            // 
            // tsbCopy
            // 
            this.tsbCopy.Image = ((System.Drawing.Image)(resources.GetObject("tsbCopy.Image")));
            this.tsbCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCopy.Name = "tsbCopy";
            this.tsbCopy.Size = new System.Drawing.Size(75, 22);
            this.tsbCopy.Text = "Sao chép";
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(69, 22);
            this.tsbEdit.Text = "Sửa (F4)";
            // 
            // tsbUpdate
            // 
            this.tsbUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdate.Image")));
            this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdate.Name = "tsbUpdate";
            this.tsbUpdate.Size = new System.Drawing.Size(98, 22);
            this.tsbUpdate.Text = "Cập nhật (F2)";
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(72, 22);
            this.tsbDelete.Text = "Hủy (F8)";
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
            this.tsbConfirm.Text = "Xác nhận (F5)";
            // 
            // tsbPrint
            // 
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(99, 22);
            this.tsbPrint.Text = "In phiếu (F11)";
            this.tsbPrint.Click += new System.EventHandler(this.tsbPrint_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbPayment
            // 
            this.tsbPayment.Image = ((System.Drawing.Image)(resources.GetObject("tsbPayment.Image")));
            this.tsbPayment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPayment.Name = "tsbPayment";
            this.tsbPayment.Size = new System.Drawing.Size(111, 22);
            this.tsbPayment.Text = "Ca làm việc (F9)";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbClose
            // 
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(85, 22);
            this.tsbClose.Text = "Đ&óng (F12)";
            this.tsbClose.ToolTipText = "Đóng (F12)";
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
            // bteThuongVien
            // 
            this.bteThuongVien.Location = new System.Drawing.Point(501, 15);
            this.bteThuongVien.Name = "bteThuongVien";
            this.bteThuongVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteThuongVien.Size = new System.Drawing.Size(320, 20);
            this.bteThuongVien.TabIndex = 18;
            // 
            // mstNgayHenGiaoHang
            // 
            this.mstNgayHenGiaoHang.CustomFormat = "dd/MM/yyyy HH:mm";
            this.mstNgayHenGiaoHang.Enabled = false;
            this.mstNgayHenGiaoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mstNgayHenGiaoHang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mstNgayHenGiaoHang.Location = new System.Drawing.Point(1063, 63);
            this.mstNgayHenGiaoHang.Name = "mstNgayHenGiaoHang";
            this.mstNgayHenGiaoHang.Size = new System.Drawing.Size(161, 20);
            this.mstNgayHenGiaoHang.TabIndex = 33;
            this.mstNgayHenGiaoHang.Value = new System.DateTime(2012, 8, 19, 11, 33, 40, 0);
            // 
            // mstNgayLapPhieu
            // 
            this.mstNgayLapPhieu.CustomFormat = "dd/MM/yyyy HH:mm";
            this.mstNgayLapPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mstNgayLapPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mstNgayLapPhieu.Location = new System.Drawing.Point(293, 38);
            this.mstNgayLapPhieu.Name = "mstNgayLapPhieu";
            this.mstNgayLapPhieu.Size = new System.Drawing.Size(118, 20);
            this.mstNgayLapPhieu.TabIndex = 6;
            this.mstNgayLapPhieu.Value = new System.DateTime(2012, 8, 19, 0, 0, 0, 0);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label32.Location = new System.Drawing.Point(240, 41);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(49, 13);
            this.label32.TabIndex = 5;
            this.label32.Text = "Ngày lập";
            // 
            // txtSoOrderKH
            // 
            this.txtSoOrderKH.BackColor = System.Drawing.Color.White;
            this.txtSoOrderKH.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtSoOrderKH.Location = new System.Drawing.Point(91, 38);
            this.txtSoOrderKH.Name = "txtSoOrderKH";
            this.txtSoOrderKH.Size = new System.Drawing.Size(131, 21);
            this.txtSoOrderKH.TabIndex = 3;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label31.Location = new System.Drawing.Point(24, 41);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(64, 13);
            this.label31.TabIndex = 2;
            this.label31.Text = "Số giao dịch";
            // 
            // txtSoChungTuGoc
            // 
            this.txtSoChungTuGoc.BackColor = System.Drawing.Color.White;
            this.txtSoChungTuGoc.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtSoChungTuGoc.Location = new System.Drawing.Point(91, 62);
            this.txtSoChungTuGoc.Name = "txtSoChungTuGoc";
            this.txtSoChungTuGoc.ReadOnly = true;
            this.txtSoChungTuGoc.Size = new System.Drawing.Size(131, 21);
            this.txtSoChungTuGoc.TabIndex = 8;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblNhanVien.Location = new System.Drawing.Point(428, 17);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(67, 13);
            this.lblNhanVien.TabIndex = 17;
            this.lblNhanVien.Text = "Thương &viên";
            // 
            // lblSoPhieu
            // 
            this.lblSoPhieu.AutoSize = true;
            this.lblSoPhieu.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblSoPhieu.Location = new System.Drawing.Point(22, 64);
            this.lblSoPhieu.Name = "lblSoPhieu";
            this.lblSoPhieu.Size = new System.Drawing.Size(66, 13);
            this.lblSoPhieu.TabIndex = 7;
            this.lblSoPhieu.Text = "Số C.Từ gốc";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label42.Location = new System.Drawing.Point(827, 90);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(89, 13);
            this.label42.TabIndex = 17;
            this.label42.Text = "Địa chỉ giao hàng";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiaChi.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtDiaChi.Location = new System.Drawing.Point(919, 87);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(305, 20);
            this.txtDiaChi.TabIndex = 21;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label19.Location = new System.Drawing.Point(26, 90);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 13);
            this.label19.TabIndex = 15;
            this.label19.Text = "Số hóa đơn";
            // 
            // txtSoSerie
            // 
            this.txtSoSerie.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtSoSerie.Location = new System.Drawing.Point(91, 87);
            this.txtSoSerie.Name = "txtSoSerie";
            this.txtSoSerie.Size = new System.Drawing.Size(131, 21);
            this.txtSoSerie.TabIndex = 16;
            // 
            // bteKhachLe
            // 
            this.bteKhachLe.Location = new System.Drawing.Point(683, 38);
            this.bteKhachLe.Name = "bteKhachLe";
            this.bteKhachLe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteKhachLe.Size = new System.Drawing.Size(138, 20);
            this.bteKhachLe.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label4.Location = new System.Drawing.Point(223, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số HĐ đ.mua";
            // 
            // txtSoHDDaMua
            // 
            this.txtSoHDDaMua.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoHDDaMua.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtSoHDDaMua.Location = new System.Drawing.Point(293, 62);
            this.txtSoHDDaMua.Name = "txtSoHDDaMua";
            this.txtSoHDDaMua.Size = new System.Drawing.Size(118, 21);
            this.txtSoHDDaMua.TabIndex = 10;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label34.Location = new System.Drawing.Point(635, 41);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(42, 13);
            this.label34.TabIndex = 0;
            this.label34.Text = "&Mã K.lẻ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label1.Location = new System.Drawing.Point(861, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Họ tên KH";
            // 
            // txtHoTenKhachHang
            // 
            this.txtHoTenKhachHang.BackColor = System.Drawing.SystemColors.Window;
            this.txtHoTenKhachHang.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtHoTenKhachHang.Location = new System.Drawing.Point(919, 38);
            this.txtHoTenKhachHang.Name = "txtHoTenKhachHang";
            this.txtHoTenKhachHang.Size = new System.Drawing.Size(305, 21);
            this.txtHoTenKhachHang.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label17.Location = new System.Drawing.Point(38, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "&Kho xuất";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblKhachHang.Location = new System.Drawing.Point(433, 39);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(63, 13);
            this.lblKhachHang.TabIndex = 27;
            this.lblKhachHang.Text = "Khách hàn&g";
            // 
            // grThongTin
            // 
            this.grThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grThongTin.Controls.Add(this.label2);
            this.grThongTin.Controls.Add(this.cboGiaoHang);
            this.grThongTin.Controls.Add(this.txtCongTy);
            this.grThongTin.Controls.Add(this.txtSoPhieuDC);
            this.grThongTin.Controls.Add(this.label22);
            this.grThongTin.Controls.Add(this.lblGhiChu);
            this.grThongTin.Controls.Add(this.bteKhachLe);
            this.grThongTin.Controls.Add(this.txtHoTenKhachHang);
            this.grThongTin.Controls.Add(this.mstNgayHenGiaoHang);
            this.grThongTin.Controls.Add(this.txtGhiChu);
            this.grThongTin.Controls.Add(this.label1);
            this.grThongTin.Controls.Add(this.label20);
            this.grThongTin.Controls.Add(this.label42);
            this.grThongTin.Controls.Add(this.bteKhachHang);
            this.grThongTin.Controls.Add(this.label34);
            this.grThongTin.Controls.Add(this.txtDiaChi);
            this.grThongTin.Controls.Add(this.label4);
            this.grThongTin.Controls.Add(this.lblKhachHang);
            this.grThongTin.Controls.Add(this.bteKhoXuat);
            this.grThongTin.Controls.Add(this.txtSoHDDaMua);
            this.grThongTin.Controls.Add(this.bteThuongVien);
            this.grThongTin.Controls.Add(this.label17);
            this.grThongTin.Controls.Add(this.mstNgayLapPhieu);
            this.grThongTin.Controls.Add(this.label31);
            this.grThongTin.Controls.Add(this.txtSoOrderKH);
            this.grThongTin.Controls.Add(this.label32);
            this.grThongTin.Controls.Add(this.lblNhanVien);
            this.grThongTin.Controls.Add(this.lblSoPhieu);
            this.grThongTin.Controls.Add(this.txtSoChungTuGoc);
            this.grThongTin.Controls.Add(this.label19);
            this.grThongTin.Controls.Add(this.txtSoSerie);
            this.grThongTin.Location = new System.Drawing.Point(0, 27);
            this.grThongTin.Name = "grThongTin";
            this.grThongTin.Size = new System.Drawing.Size(1236, 114);
            this.grThongTin.TabIndex = 1;
            this.grThongTin.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label2.Location = new System.Drawing.Point(858, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 113;
            this.label2.Text = "Giao nhận";
            // 
            // cboGiaoHang
            // 
            this.cboGiaoHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGiaoHang.Enabled = false;
            this.cboGiaoHang.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cboGiaoHang.FormattingEnabled = true;
            this.cboGiaoHang.Items.AddRange(new object[] {
            "Không giao",
            "Siêu thị giao",
            "Kho tổng giao"});
            this.cboGiaoHang.Location = new System.Drawing.Point(919, 63);
            this.cboGiaoHang.Name = "cboGiaoHang";
            this.cboGiaoHang.Size = new System.Drawing.Size(107, 21);
            this.cboGiaoHang.TabIndex = 112;
            // 
            // txtCongTy
            // 
            this.txtCongTy.BackColor = System.Drawing.SystemColors.Window;
            this.txtCongTy.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCongTy.Location = new System.Drawing.Point(919, 13);
            this.txtCongTy.Name = "txtCongTy";
            this.txtCongTy.Size = new System.Drawing.Size(305, 21);
            this.txtCongTy.TabIndex = 5;
            // 
            // txtSoPhieuDC
            // 
            this.txtSoPhieuDC.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoPhieuDC.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtSoPhieuDC.Location = new System.Drawing.Point(293, 87);
            this.txtSoPhieuDC.Name = "txtSoPhieuDC";
            this.txtSoPhieuDC.Size = new System.Drawing.Size(118, 21);
            this.txtSoPhieuDC.TabIndex = 36;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label22.Location = new System.Drawing.Point(871, 16);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(45, 13);
            this.label22.TabIndex = 4;
            this.label22.Text = "&Công ty";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblGhiChu.Location = new System.Drawing.Point(449, 65);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(47, 13);
            this.lblGhiChu.TabIndex = 34;
            this.lblGhiChu.Text = "&Diễn giải";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtGhiChu.Location = new System.Drawing.Point(501, 61);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGhiChu.Size = new System.Drawing.Size(320, 47);
            this.txtGhiChu.TabIndex = 35;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label20.Location = new System.Drawing.Point(222, 91);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 13);
            this.label20.TabIndex = 25;
            this.label20.Text = "Số phiếu ĐC";
            // 
            // bteKhachHang
            // 
            this.bteKhachHang.Location = new System.Drawing.Point(501, 38);
            this.bteKhachHang.Name = "bteKhachHang";
            this.bteKhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteKhachHang.Size = new System.Drawing.Size(131, 20);
            this.bteKhachHang.TabIndex = 28;
            // 
            // bteKhoXuat
            // 
            this.bteKhoXuat.Location = new System.Drawing.Point(91, 15);
            this.bteKhoXuat.Name = "bteKhoXuat";
            this.bteKhoXuat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteKhoXuat.Size = new System.Drawing.Size(320, 20);
            this.bteKhoXuat.TabIndex = 1;
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
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.tsslTrangThai,
            this.tsslDraft});
            this.statusStrip1.Location = new System.Drawing.Point(0, 593);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1236, 22);
            this.statusStrip1.TabIndex = 106;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Yellow;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabel1.Text = "    ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(112, 17);
            this.toolStripStatusLabel2.Text = "Nợ khuyến mại        ";
            // 
            // tsslTrangThai
            // 
            this.tsslTrangThai.Name = "tsslTrangThai";
            this.tsslTrangThai.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslDraft
            // 
            this.tsslDraft.Name = "tsslDraft";
            this.tsslDraft.Size = new System.Drawing.Size(0, 17);
            // 
            // frmBH_ViewDonHangBan
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 615);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grSanPhamBan);
            this.Controls.Add(this.grThongTin);
            this.KeyPreview = true;
            this.Name = "frmBH_ViewDonHangBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết đơn hàng bán";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grSanPhamBan.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gSanPhamBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPhamBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteThuongVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhachLe.Properties)).EndInit();
            this.grThongTin.ResumeLayout(false);
            this.grThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhoXuat.Properties)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.GroupBox grSanPhamBan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbUpdate;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripButton tsbPayment;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private GtidTextBox textBox4;
        private GtidTextBox textBox5;
        private GtidTextBox textBox6;
        private GtidTextBox txtDiaChi;
        private GtidTextBox txtHoTenKhachHang;
        private System.Windows.Forms.Label label1;
        private GtidTextBox txtSoSerie;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ToolStripButton tsbConfirm;
        private System.Windows.Forms.DateTimePicker mstNgayHenGiaoHang;
        private System.Windows.Forms.DateTimePicker mstNgayLapPhieu;
        private System.Windows.Forms.Label label32;
        private GtidTextBox txtSoOrderKH;
        private System.Windows.Forms.Label label31;
        private GtidTextBox txtSoChungTuGoc;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblSoPhieu;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.GroupBox grThongTin;
        private System.Windows.Forms.ToolStripButton tsbCopy;
        private System.Windows.Forms.Label label42;
        private DevExpress.XtraGrid.GridControl gSanPhamBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSanPhamBan;
        private DevExpress.XtraGrid.Columns.GridColumn IdChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn IdChungTuChiTiet;
        private DevExpress.XtraGrid.Columns.GridColumn IdSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn MaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn IdSanPhamBan;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPhamBan;
        private DevExpress.XtraGrid.Columns.GridColumn DonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraGrid.Columns.GridColumn TyleChietKhau;
        private DevExpress.XtraGrid.Columns.GridColumn TienChietKhau;
        private DevExpress.XtraGrid.Columns.GridColumn TienSauChietKhau;
        private DevExpress.XtraGrid.Columns.GridColumn TyleVAT;
        private DevExpress.XtraGrid.Columns.GridColumn TienVAT;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhTien;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeThuong;
        private DevExpress.XtraGrid.Columns.GridColumn ThuongNong;
        private DevExpress.XtraGrid.Columns.GridColumn GiaTheoBangGia;
        private DevExpress.XtraGrid.Columns.GridColumn GiaNiemYet;
        private DevExpress.XtraGrid.Columns.GridColumn GiaWebSite;
        private DevExpress.XtraGrid.Columns.GridColumn NoKhuyenMai;
        private DevExpress.XtraGrid.Columns.GridColumn TrungMaVach;
        private System.Windows.Forms.Label label4;
        private GtidTextBox txtSoHDDaMua;
        private DevExpress.XtraEditors.ButtonEdit bteThuongVien;
        private DevExpress.XtraEditors.ButtonEdit bteKhachLe;
        private DevExpress.XtraEditors.ButtonEdit bteKhoXuat;
        private DevExpress.XtraEditors.ButtonEdit bteKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiHangKem;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoaiHangKem;
        private System.Windows.Forms.ToolStripLabel tslInfor;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslTrangThai;
        private System.Windows.Forms.ToolStripStatusLabel tsslDraft;
        private DevExpress.XtraGrid.Columns.GridColumn TyLePhanBo;
        private System.Windows.Forms.Label label20;
        private GtidTextBox txtCongTy;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private DevExpress.XtraGrid.Columns.GridColumn TyleThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongOld;
        private System.Windows.Forms.Label lblGhiChu;
        private GtidTextBox txtGhiChu;
        private GtidTextBox txtSoPhieuDC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboGiaoHang;
    }
}