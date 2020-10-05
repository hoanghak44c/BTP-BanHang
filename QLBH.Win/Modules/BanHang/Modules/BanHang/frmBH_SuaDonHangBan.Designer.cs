using System.Drawing;
using QLBH.Core.Form;
namespace QLBanHang.Modules.BanHang
{
    partial class frmBH_SuaDonHangBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBH_SuaDonHangBan));
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
            this.btnThemKM = new QLBH.Core.Form.GtidButton();
            this.chkTraLaiNCC = new System.Windows.Forms.CheckBox();
            this.cboMaDuAn = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.btnChietKhau = new QLBH.Core.Form.GtidButton();
            this.lblSPBInfors = new System.Windows.Forms.Label();
            this.btnXoaSanPham = new QLBH.Core.Form.GtidButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gSanPhamBan = new DevExpress.XtraGrid.GridControl();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsbChinhSachGia = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btnTimOrderKH = new QLBH.Core.Form.GtidButton();
            this.grPayments = new System.Windows.Forms.GroupBox();
            this.btnSaoChep = new QLBH.Core.Form.GtidButton();
            this.chkVoucher = new System.Windows.Forms.CheckBox();
            this.btnSuaTToan = new QLBH.Core.Form.GtidButton();
            this.chkTinhKM = new System.Windows.Forms.CheckBox();
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
            this.bteThoiHanThanhToan = new DevExpress.XtraEditors.ButtonEdit();
            this.label27 = new System.Windows.Forms.Label();
            this.btnXoaTT = new QLBH.Core.Form.GtidButton();
            this.btnThanhToan = new QLBH.Core.Form.GtidButton();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTienConNo = new QLBH.Core.Form.GtidTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTienThucTra = new QLBH.Core.Form.GtidTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTongTienCK = new QLBH.Core.Form.GtidTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongTienThanhToan = new QLBH.Core.Form.GtidTextBox();
            this.txtTongTienSauCK = new QLBH.Core.Form.GtidTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTongTienVAT = new QLBH.Core.Form.GtidTextBox();
            this.txtTongTienHang = new QLBH.Core.Form.GtidTextBox();
            this.lblTienVAT = new System.Windows.Forms.Label();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbConfirm = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.tsbPayment = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslInfor = new System.Windows.Forms.ToolStripLabel();
            this.bteThuNgan = new DevExpress.XtraEditors.ButtonEdit();
            this.bteTruongCa = new DevExpress.XtraEditors.ButtonEdit();
            this.bteThuongVien = new DevExpress.XtraEditors.ButtonEdit();
            this.label39 = new System.Windows.Forms.Label();
            this.mstNgayHenGiaoHang = new System.Windows.Forms.DateTimePicker();
            this.cboCaBanHang = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.mstNgayLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.label32 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txtCMND = new QLBH.Core.Form.GtidTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDienThoai = new QLBH.Core.Form.GtidTextBox();
            this.txtSoOrderKH = new QLBH.Core.Form.GtidTextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtSoChungTuGoc = new QLBH.Core.Form.GtidTextBox();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblSoPhieu = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.txtDiaChiHD = new QLBH.Core.Form.GtidTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cboHuyen = new System.Windows.Forms.ComboBox();
            this.cboHuyenHD = new System.Windows.Forms.ComboBox();
            this.cboTinhHD = new System.Windows.Forms.ComboBox();
            this.cboTinh = new System.Windows.Forms.ComboBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.txtDiaChi = new QLBH.Core.Form.GtidTextBox();
            this.cboLoaiHoaDon = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cboQuyen = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnLoadQuyen = new QLBH.Core.Form.GtidButton();
            this.txtSoSerie = new QLBH.Core.Form.GtidTextBox();
            this.bteKhachLe = new DevExpress.XtraEditors.ButtonEdit();
            this.cboNgheNghiep = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoHDDaMua = new QLBH.Core.Form.GtidTextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWebSite = new QLBH.Core.Form.GtidTextBox();
            this.txtTuoi = new QLBH.Core.Form.GtidTextBox();
            this.txtEmail = new QLBH.Core.Form.GtidTextBox();
            this.txtMaSoThue = new QLBH.Core.Form.GtidTextBox();
            this.txtHoTenKhachHang = new QLBH.Core.Form.GtidTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.grThongTin = new System.Windows.Forms.GroupBox();
            this.cboGiaoHang = new System.Windows.Forms.ComboBox();
            this.dteNgayHoaDon = new DevExpress.XtraEditors.DateEdit();
            this.label38 = new System.Windows.Forms.Label();
            this.cboCurrentLoaiDT = new System.Windows.Forms.ComboBox();
            this.label37 = new System.Windows.Forms.Label();
            this.chkDraft = new System.Windows.Forms.CheckBox();
            this.bteTrungTam = new DevExpress.XtraEditors.ButtonEdit();
            this.label26 = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new QLBH.Core.Form.GtidTextBox();
            this.txtSoPhieuDC = new DevExpress.XtraEditors.ButtonEdit();
            this.label20 = new System.Windows.Forms.Label();
            this.bteKhachHang = new DevExpress.XtraEditors.ButtonEdit();
            this.bteKhoXuat = new DevExpress.XtraEditors.ButtonEdit();
            this.chkHDNhay = new System.Windows.Forms.CheckBox();
            this.textBox4 = new QLBH.Core.Form.GtidTextBox();
            this.textBox5 = new QLBH.Core.Form.GtidTextBox();
            this.textBox6 = new QLBH.Core.Form.GtidTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCongTy = new QLBH.Core.Form.GtidTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDraft = new System.Windows.Forms.ToolStripStatusLabel();
            this.label24 = new System.Windows.Forms.Label();
            this.cboQuocGia = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grSanPhamBan.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSanPhamBan)).BeginInit();
            this.ctxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPhamBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.grPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gHinhThucThanhToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHinhThucThanhToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteThoiHanThanhToan.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteThuNgan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTruongCa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteThuongVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhachLe.Properties)).BeginInit();
            this.grThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayHoaDon.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayHoaDon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPhieuDC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhoXuat.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // txtMaSanPham
            // 
            this.txtMaSanPham.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSanPham.Location = new System.Drawing.Point(91, 16);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.ReadOnly = true;
            this.txtMaSanPham.Size = new System.Drawing.Size(396, 26);
            this.txtMaSanPham.TabIndex = 1;
            this.txtMaSanPham.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaSanPham_KeyDown);
            this.txtMaSanPham.Enter += new System.EventHandler(this.txtMaSanPham_Enter);
            // 
            // btnThemHang
            // 
            this.btnThemHang.Enabled = false;
            this.btnThemHang.Image = ((System.Drawing.Image)(resources.GetObject("btnThemHang.Image")));
            this.btnThemHang.Location = new System.Drawing.Point(493, 16);
            this.btnThemHang.Name = "btnThemHang";
            this.btnThemHang.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnThemHang.Size = new System.Drawing.Size(83, 26);
            this.btnThemHang.TabIndex = 2;
            this.btnThemHang.Text = "&Thêm hàng";
            this.btnThemHang.Click += new System.EventHandler(this.btnThemHang_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(11, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "&Sản phẩm";
            // 
            // grSanPhamBan
            // 
            this.grSanPhamBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grSanPhamBan.Controls.Add(this.btnThemKM);
            this.grSanPhamBan.Controls.Add(this.chkTraLaiNCC);
            this.grSanPhamBan.Controls.Add(this.cboMaDuAn);
            this.grSanPhamBan.Controls.Add(this.txtMaSanPham);
            this.grSanPhamBan.Controls.Add(this.label29);
            this.grSanPhamBan.Controls.Add(this.btnChietKhau);
            this.grSanPhamBan.Controls.Add(this.btnThemHang);
            this.grSanPhamBan.Controls.Add(this.label9);
            this.grSanPhamBan.Controls.Add(this.lblSPBInfors);
            this.grSanPhamBan.Controls.Add(this.btnXoaSanPham);
            this.grSanPhamBan.Controls.Add(this.tableLayoutPanel1);
            this.grSanPhamBan.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.grSanPhamBan.ForeColor = System.Drawing.Color.Black;
            this.grSanPhamBan.Location = new System.Drawing.Point(0, 170);
            this.grSanPhamBan.Name = "grSanPhamBan";
            this.grSanPhamBan.Size = new System.Drawing.Size(1236, 216);
            this.grSanPhamBan.TabIndex = 0;
            this.grSanPhamBan.TabStop = false;
            this.grSanPhamBan.Text = "Danh sách mặt hàng";
            // 
            // btnThemKM
            // 
            this.btnThemKM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemKM.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemKM.Appearance.Options.UseFont = true;
            this.btnThemKM.Image = ((System.Drawing.Image)(resources.GetObject("btnThemKM.Image")));
            this.btnThemKM.Location = new System.Drawing.Point(900, 16);
            this.btnThemKM.Name = "btnThemKM";
            this.btnThemKM.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnThemKM.Size = new System.Drawing.Size(112, 26);
            this.btnThemKM.TabIndex = 37;
            this.btnThemKM.Text = "Thêm nợ K.Mại";
            this.btnThemKM.Click += new System.EventHandler(this.btnThemKM_Click);
            // 
            // chkTraLaiNCC
            // 
            this.chkTraLaiNCC.AutoSize = true;
            this.chkTraLaiNCC.Enabled = false;
            this.chkTraLaiNCC.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.chkTraLaiNCC.Location = new System.Drawing.Point(752, 22);
            this.chkTraLaiNCC.Name = "chkTraLaiNCC";
            this.chkTraLaiNCC.Size = new System.Drawing.Size(79, 17);
            this.chkTraLaiNCC.TabIndex = 36;
            this.chkTraLaiNCC.Text = "Trả lại &NCC";
            this.chkTraLaiNCC.UseVisualStyleBackColor = true;
            this.chkTraLaiNCC.Visible = false;
            // 
            // cboMaDuAn
            // 
            this.cboMaDuAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaDuAn.Enabled = false;
            this.cboMaDuAn.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cboMaDuAn.FormattingEnabled = true;
            this.cboMaDuAn.Items.AddRange(new object[] {
            "",
            "Nam",
            "Nữ"});
            this.cboMaDuAn.Location = new System.Drawing.Point(857, 19);
            this.cboMaDuAn.Name = "cboMaDuAn";
            this.cboMaDuAn.Size = new System.Drawing.Size(26, 21);
            this.cboMaDuAn.TabIndex = 5;
            this.cboMaDuAn.Visible = false;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label29.Location = new System.Drawing.Point(802, 22);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(52, 13);
            this.label29.TabIndex = 4;
            this.label29.Text = "Mã dự án";
            this.label29.Visible = false;
            // 
            // btnChietKhau
            // 
            this.btnChietKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChietKhau.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChietKhau.Appearance.Options.UseFont = true;
            this.btnChietKhau.Image = ((System.Drawing.Image)(resources.GetObject("btnChietKhau.Image")));
            this.btnChietKhau.Location = new System.Drawing.Point(1014, 16);
            this.btnChietKhau.Name = "btnChietKhau";
            this.btnChietKhau.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnChietKhau.Size = new System.Drawing.Size(107, 26);
            this.btnChietKhau.TabIndex = 6;
            this.btnChietKhau.Text = "Đổi nợ K.Mại";
            this.btnChietKhau.Click += new System.EventHandler(this.btnChietKhau_Click);
            // 
            // lblSPBInfors
            // 
            this.lblSPBInfors.AutoSize = true;
            this.lblSPBInfors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSPBInfors.Location = new System.Drawing.Point(588, 21);
            this.lblSPBInfors.Name = "lblSPBInfors";
            this.lblSPBInfors.Size = new System.Drawing.Size(146, 15);
            this.lblSPBInfors.TabIndex = 3;
            this.lblSPBInfors.Text = "Tổng số sản phẩm bán: 0";
            this.lblSPBInfors.Visible = false;
            // 
            // btnXoaSanPham
            // 
            this.btnXoaSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaSanPham.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaSanPham.Appearance.Options.UseFont = true;
            this.btnXoaSanPham.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaSanPham.Image")));
            this.btnXoaSanPham.Location = new System.Drawing.Point(1123, 16);
            this.btnXoaSanPham.Name = "btnXoaSanPham";
            this.btnXoaSanPham.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnXoaSanPham.Size = new System.Drawing.Size(107, 26);
            this.btnXoaSanPham.TabIndex = 7;
            this.btnXoaSanPham.Text = "Xóa sản phẩm";
            this.btnXoaSanPham.Click += new System.EventHandler(this.btnXoaSanPham_Click);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1223, 162);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // gSanPhamBan
            // 
            this.gSanPhamBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gSanPhamBan.ContextMenuStrip = this.ctxMenu;
            this.gSanPhamBan.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gSanPhamBan.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gSanPhamBan.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gSanPhamBan.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gSanPhamBan.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gSanPhamBan.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gSanPhamBan.Location = new System.Drawing.Point(3, 3);
            this.gSanPhamBan.MainView = this.gvSanPhamBan;
            this.gSanPhamBan.Name = "gSanPhamBan";
            this.gSanPhamBan.Size = new System.Drawing.Size(1217, 156);
            this.gSanPhamBan.TabIndex = 0;
            this.gSanPhamBan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSanPhamBan,
            this.gridView1});
            // 
            // ctxMenu
            // 
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbChinhSachGia});
            this.ctxMenu.Name = "contextMenuStrip1";
            this.ctxMenu.Size = new System.Drawing.Size(199, 26);
            // 
            // tsbChinhSachGia
            // 
            this.tsbChinhSachGia.Name = "tsbChinhSachGia";
            this.tsbChinhSachGia.Size = new System.Drawing.Size(198, 22);
            this.tsbChinhSachGia.Text = "Chính sách khuyến mại";
            this.tsbChinhSachGia.Click += new System.EventHandler(this.tsbChinhSachGia_Click);
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
            this.gvSanPhamBan.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvSanPhamBan_CellValueChanged);
            this.gvSanPhamBan.Click += new System.EventHandler(this.gvSanPhamBan_Click);
            this.gvSanPhamBan.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvSanPhamBan_RowCellStyle);
            this.gvSanPhamBan.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gvSanPhamBan_ShowingEditor);
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
            this.TenSanPham.Width = 79;
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
            this.GhiChu.VisibleIndex = 12;
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
            this.NoKhuyenMai.Caption = "Nợ khuyến mại";
            this.NoKhuyenMai.FieldName = "NoKhuyenMai";
            this.NoKhuyenMai.Name = "NoKhuyenMai";
            this.NoKhuyenMai.OptionsColumn.AllowEdit = false;
            this.NoKhuyenMai.Visible = true;
            this.NoKhuyenMai.VisibleIndex = 11;
            this.NoKhuyenMai.Width = 109;
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
            this.TenLoaiHangKem.VisibleIndex = 13;
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
            // btnTimOrderKH
            // 
            this.btnTimOrderKH.Image = ((System.Drawing.Image)(resources.GetObject("btnTimOrderKH.Image")));
            this.btnTimOrderKH.Location = new System.Drawing.Point(194, 63);
            this.btnTimOrderKH.Name = "btnTimOrderKH";
            this.btnTimOrderKH.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnTimOrderKH.Size = new System.Drawing.Size(28, 22);
            this.btnTimOrderKH.TabIndex = 4;
            this.btnTimOrderKH.Click += new System.EventHandler(this.btnTimOrderKH_Click);
            // 
            // grPayments
            // 
            this.grPayments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grPayments.Controls.Add(this.btnSaoChep);
            this.grPayments.Controls.Add(this.chkVoucher);
            this.grPayments.Controls.Add(this.btnSuaTToan);
            this.grPayments.Controls.Add(this.chkTinhKM);
            this.grPayments.Controls.Add(this.gHinhThucThanhToan);
            this.grPayments.Controls.Add(this.bteThoiHanThanhToan);
            this.grPayments.Controls.Add(this.label27);
            this.grPayments.Controls.Add(this.btnXoaTT);
            this.grPayments.Controls.Add(this.btnThanhToan);
            this.grPayments.Controls.Add(this.label15);
            this.grPayments.Controls.Add(this.txtTienConNo);
            this.grPayments.Controls.Add(this.label16);
            this.grPayments.Controls.Add(this.txtTienThucTra);
            this.grPayments.Controls.Add(this.label12);
            this.grPayments.Controls.Add(this.txtTongTienCK);
            this.grPayments.Controls.Add(this.label11);
            this.grPayments.Controls.Add(this.lblTongTien);
            this.grPayments.Controls.Add(this.txtTongTienThanhToan);
            this.grPayments.Controls.Add(this.txtTongTienSauCK);
            this.grPayments.Controls.Add(this.label8);
            this.grPayments.Controls.Add(this.txtTongTienVAT);
            this.grPayments.Controls.Add(this.txtTongTienHang);
            this.grPayments.Controls.Add(this.lblTienVAT);
            this.grPayments.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.grPayments.Location = new System.Drawing.Point(592, 388);
            this.grPayments.Name = "grPayments";
            this.grPayments.Size = new System.Drawing.Size(644, 202);
            this.grPayments.TabIndex = 3;
            this.grPayments.TabStop = false;
            this.grPayments.Text = "Thanh toán";
            // 
            // btnSaoChep
            // 
            this.btnSaoChep.Enabled = false;
            this.btnSaoChep.Image = ((System.Drawing.Image)(resources.GetObject("btnSaoChep.Image")));
            this.btnSaoChep.Location = new System.Drawing.Point(5, 120);
            this.btnSaoChep.Name = "btnSaoChep";
            this.btnSaoChep.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnSaoChep.Size = new System.Drawing.Size(93, 23);
            this.btnSaoChep.TabIndex = 22;
            this.btnSaoChep.Text = "Copy TT (F3)";
            this.btnSaoChep.Click += new System.EventHandler(this.btnSaoChep_Click);
            // 
            // chkVoucher
            // 
            this.chkVoucher.AutoSize = true;
            this.chkVoucher.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.chkVoucher.Location = new System.Drawing.Point(479, 66);
            this.chkVoucher.Name = "chkVoucher";
            this.chkVoucher.Size = new System.Drawing.Size(123, 17);
            this.chkVoucher.TabIndex = 21;
            this.chkVoucher.Text = "Thanh toán voucher";
            this.chkVoucher.UseVisualStyleBackColor = true;
            this.chkVoucher.Visible = false;
            // 
            // btnSuaTToan
            // 
            this.btnSuaTToan.Enabled = false;
            this.btnSuaTToan.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaTToan.Image")));
            this.btnSuaTToan.Location = new System.Drawing.Point(5, 146);
            this.btnSuaTToan.Name = "btnSuaTToan";
            this.btnSuaTToan.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnSuaTToan.Size = new System.Drawing.Size(93, 23);
            this.btnSuaTToan.TabIndex = 20;
            this.btnSuaTToan.Text = "Sửa TT (F6)";
            this.btnSuaTToan.Click += new System.EventHandler(this.btnSuaTToan_Click);
            // 
            // chkTinhKM
            // 
            this.chkTinhKM.AutoSize = true;
            this.chkTinhKM.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.chkTinhKM.Location = new System.Drawing.Point(413, 66);
            this.chkTinhKM.Name = "chkTinhKM";
            this.chkTinhKM.Size = new System.Drawing.Size(63, 17);
            this.chkTinhKM.TabIndex = 16;
            this.chkTinhKM.Text = "Tính KM";
            this.chkTinhKM.UseVisualStyleBackColor = true;
            this.chkTinhKM.Visible = false;
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
            this.gHinhThucThanhToan.Location = new System.Drawing.Point(102, 88);
            this.gHinhThucThanhToan.MainView = this.gvHinhThucThanhToan;
            this.gHinhThucThanhToan.Name = "gHinhThucThanhToan";
            this.gHinhThucThanhToan.Size = new System.Drawing.Size(533, 108);
            this.gHinhThucThanhToan.TabIndex = 19;
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
            // bteThoiHanThanhToan
            // 
            this.bteThoiHanThanhToan.Location = new System.Drawing.Point(478, 40);
            this.bteThoiHanThanhToan.Name = "bteThoiHanThanhToan";
            this.bteThoiHanThanhToan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteThoiHanThanhToan.Size = new System.Drawing.Size(157, 20);
            this.bteThoiHanThanhToan.TabIndex = 11;
            this.bteThoiHanThanhToan.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteThoiHanThanhToan_ButtonClick);
            this.bteThoiHanThanhToan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteThoiHanThanhToan_KeyDown);
            this.bteThoiHanThanhToan.TextChanged += new System.EventHandler(this.bteThoiHanThanhToan_TextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label27.Location = new System.Drawing.Point(412, 43);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(63, 13);
            this.label27.TabIndex = 10;
            this.label27.Text = "&Thời hạn TT";
            // 
            // btnXoaTT
            // 
            this.btnXoaTT.Enabled = false;
            this.btnXoaTT.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaTT.Image")));
            this.btnXoaTT.Location = new System.Drawing.Point(5, 172);
            this.btnXoaTT.Name = "btnXoaTT";
            this.btnXoaTT.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnXoaTT.Size = new System.Drawing.Size(93, 23);
            this.btnXoaTT.TabIndex = 18;
            this.btnXoaTT.Text = "Xóa TT";
            this.btnXoaTT.Click += new System.EventHandler(this.btnXoaTT_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.Location = new System.Drawing.Point(4, 94);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnThanhToan.Size = new System.Drawing.Size(94, 23);
            this.btnThanhToan.TabIndex = 17;
            this.btnThanhToan.Text = "T.Toán (F10)";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(404, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Tiền còn nợ";
            // 
            // txtTienConNo
            // 
            this.txtTienConNo.BackColor = System.Drawing.SystemColors.Control;
            this.txtTienConNo.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtTienConNo.Location = new System.Drawing.Point(478, 15);
            this.txtTienConNo.Name = "txtTienConNo";
            this.txtTienConNo.ReadOnly = true;
            this.txtTienConNo.Size = new System.Drawing.Size(157, 21);
            this.txtTienConNo.TabIndex = 5;
            this.txtTienConNo.Text = "0";
            this.txtTienConNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(212, 68);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Tiền thực trả";
            // 
            // txtTienThucTra
            // 
            this.txtTienThucTra.BackColor = System.Drawing.SystemColors.Control;
            this.txtTienThucTra.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtTienThucTra.Location = new System.Drawing.Point(295, 65);
            this.txtTienThucTra.Name = "txtTienThucTra";
            this.txtTienThucTra.ReadOnly = true;
            this.txtTienThucTra.Size = new System.Drawing.Size(108, 21);
            this.txtTienThucTra.TabIndex = 15;
            this.txtTienThucTra.Text = "0";
            this.txtTienThucTra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTienThucTra.TextChanged += new System.EventHandler(this.txtTienThucTra_TextChanged);
            this.txtTienThucTra.GotFocus += new System.EventHandler(this.txtTienThucTra_Enter);
            this.txtTienThucTra.LostFocus += new System.EventHandler(this.txtTienThucTra_LostFocus);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label12.Location = new System.Drawing.Point(220, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Tổng tiền C/K";
            // 
            // txtTongTienCK
            // 
            this.txtTongTienCK.BackColor = System.Drawing.SystemColors.Control;
            this.txtTongTienCK.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtTongTienCK.Location = new System.Drawing.Point(295, 15);
            this.txtTongTienCK.Name = "txtTongTienCK";
            this.txtTongTienCK.ReadOnly = true;
            this.txtTongTienCK.Size = new System.Drawing.Size(108, 21);
            this.txtTongTienCK.TabIndex = 3;
            this.txtTongTienCK.Text = "0";
            this.txtTongTienCK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Tổng tiền TT";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblTongTien.Location = new System.Drawing.Point(6, 43);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(92, 13);
            this.lblTongTien.TabIndex = 6;
            this.lblTongTien.Text = "Tổng tiền sau C/K";
            // 
            // txtTongTienThanhToan
            // 
            this.txtTongTienThanhToan.BackColor = System.Drawing.SystemColors.Control;
            this.txtTongTienThanhToan.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtTongTienThanhToan.Location = new System.Drawing.Point(102, 65);
            this.txtTongTienThanhToan.Name = "txtTongTienThanhToan";
            this.txtTongTienThanhToan.ReadOnly = true;
            this.txtTongTienThanhToan.Size = new System.Drawing.Size(108, 21);
            this.txtTongTienThanhToan.TabIndex = 13;
            this.txtTongTienThanhToan.Text = "0";
            this.txtTongTienThanhToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTongTienThanhToan.TextChanged += new System.EventHandler(this.txtTongTienThanhToan_TextChanged);
            this.txtTongTienThanhToan.Leave += new System.EventHandler(this.txtTongTienThanhToan_Leave);
            // 
            // txtTongTienSauCK
            // 
            this.txtTongTienSauCK.BackColor = System.Drawing.SystemColors.Control;
            this.txtTongTienSauCK.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtTongTienSauCK.Location = new System.Drawing.Point(102, 40);
            this.txtTongTienSauCK.Name = "txtTongTienSauCK";
            this.txtTongTienSauCK.ReadOnly = true;
            this.txtTongTienSauCK.Size = new System.Drawing.Size(108, 21);
            this.txtTongTienSauCK.TabIndex = 7;
            this.txtTongTienSauCK.Text = "0";
            this.txtTongTienSauCK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label8.Location = new System.Drawing.Point(20, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tổng giá trị HH";
            // 
            // txtTongTienVAT
            // 
            this.txtTongTienVAT.BackColor = System.Drawing.SystemColors.Control;
            this.txtTongTienVAT.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtTongTienVAT.Location = new System.Drawing.Point(295, 40);
            this.txtTongTienVAT.Name = "txtTongTienVAT";
            this.txtTongTienVAT.ReadOnly = true;
            this.txtTongTienVAT.Size = new System.Drawing.Size(108, 21);
            this.txtTongTienVAT.TabIndex = 9;
            this.txtTongTienVAT.Text = "0";
            this.txtTongTienVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTongTienHang
            // 
            this.txtTongTienHang.BackColor = System.Drawing.SystemColors.Control;
            this.txtTongTienHang.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtTongTienHang.Location = new System.Drawing.Point(102, 15);
            this.txtTongTienHang.Name = "txtTongTienHang";
            this.txtTongTienHang.ReadOnly = true;
            this.txtTongTienHang.Size = new System.Drawing.Size(108, 21);
            this.txtTongTienHang.TabIndex = 1;
            this.txtTongTienHang.Text = "0";
            this.txtTongTienHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTienVAT
            // 
            this.lblTienVAT.AutoSize = true;
            this.lblTienVAT.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblTienVAT.Location = new System.Drawing.Point(218, 43);
            this.lblTienVAT.Name = "lblTienVAT";
            this.lblTienVAT.Size = new System.Drawing.Size(74, 13);
            this.lblTienVAT.TabIndex = 8;
            this.lblTienVAT.Text = "Tổng tiền VAT";
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
            this.toolStripSeparator3,
            this.tsbConfirm,
            this.toolStripSeparator4,
            this.tsbPrint,
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
            // tsbEdit
            // 
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(69, 22);
            this.tsbEdit.Text = "Sửa (F4)";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
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
            this.tsbConfirm.Click += new System.EventHandler(this.tsbConfirm_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
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
            // tsbPayment
            // 
            this.tsbPayment.Enabled = false;
            this.tsbPayment.Image = ((System.Drawing.Image)(resources.GetObject("tsbPayment.Image")));
            this.tsbPayment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPayment.Name = "tsbPayment";
            this.tsbPayment.Size = new System.Drawing.Size(111, 22);
            this.tsbPayment.Text = "Ca làm việc (F9)";
            this.tsbPayment.Visible = false;
            this.tsbPayment.Click += new System.EventHandler(this.tsbPayment_Click);
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
            // bteThuNgan
            // 
            this.bteThuNgan.Location = new System.Drawing.Point(492, 62);
            this.bteThuNgan.Name = "bteThuNgan";
            this.bteThuNgan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteThuNgan.Size = new System.Drawing.Size(221, 20);
            this.bteThuNgan.TabIndex = 22;
            this.bteThuNgan.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteThuNgan_ButtonClick);
            this.bteThuNgan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteThuNgan_KeyDown);
            this.bteThuNgan.TextChanged += new System.EventHandler(this.bteThuNgan_TextChanged);
            // 
            // bteTruongCa
            // 
            this.bteTruongCa.Location = new System.Drawing.Point(492, 38);
            this.bteTruongCa.Name = "bteTruongCa";
            this.bteTruongCa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteTruongCa.Size = new System.Drawing.Size(320, 20);
            this.bteTruongCa.TabIndex = 20;
            this.bteTruongCa.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteTruongCa_ButtonClick);
            this.bteTruongCa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteTruongCa_KeyDown);
            this.bteTruongCa.TextChanged += new System.EventHandler(this.bteTruongCa_TextChanged);
            // 
            // bteThuongVien
            // 
            this.bteThuongVien.Location = new System.Drawing.Point(492, 15);
            this.bteThuongVien.Name = "bteThuongVien";
            this.bteThuongVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteThuongVien.Size = new System.Drawing.Size(320, 20);
            this.bteThuongVien.TabIndex = 18;
            this.bteThuongVien.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteThuongVien_ButtonClick);
            this.bteThuongVien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteThuongVien_KeyDown);
            this.bteThuongVien.TextChanged += new System.EventHandler(this.bteThuongVien_TextChanged);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label39.Location = new System.Drawing.Point(436, 64);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(52, 13);
            this.label39.TabIndex = 21;
            this.label39.Text = "Thu ngân";
            // 
            // mstNgayHenGiaoHang
            // 
            this.mstNgayHenGiaoHang.CustomFormat = "dd/MM/yyyy HH:mm";
            this.mstNgayHenGiaoHang.Enabled = false;
            this.mstNgayHenGiaoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mstNgayHenGiaoHang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mstNgayHenGiaoHang.Location = new System.Drawing.Point(1092, 61);
            this.mstNgayHenGiaoHang.Name = "mstNgayHenGiaoHang";
            this.mstNgayHenGiaoHang.Size = new System.Drawing.Size(124, 20);
            this.mstNgayHenGiaoHang.TabIndex = 33;
            this.mstNgayHenGiaoHang.Value = new System.DateTime(2012, 8, 19, 11, 33, 40, 0);
            // 
            // cboCaBanHang
            // 
            this.cboCaBanHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaBanHang.Enabled = false;
            this.cboCaBanHang.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cboCaBanHang.FormattingEnabled = true;
            this.cboCaBanHang.Items.AddRange(new object[] {
            "",
            "Ca Sáng",
            "Ca Chiều"});
            this.cboCaBanHang.Location = new System.Drawing.Point(896, 61);
            this.cboCaBanHang.Name = "cboCaBanHang";
            this.cboCaBanHang.Size = new System.Drawing.Size(92, 21);
            this.cboCaBanHang.TabIndex = 30;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label33.Location = new System.Drawing.Point(824, 65);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(68, 13);
            this.label33.TabIndex = 29;
            this.label33.Text = "Ca bán hàng";
            // 
            // mstNgayLapPhieu
            // 
            this.mstNgayLapPhieu.CustomFormat = "dd/MM/yyyy HH:mm";
            this.mstNgayLapPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mstNgayLapPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mstNgayLapPhieu.Location = new System.Drawing.Point(293, 63);
            this.mstNgayLapPhieu.Name = "mstNgayLapPhieu";
            this.mstNgayLapPhieu.Size = new System.Drawing.Size(118, 20);
            this.mstNgayLapPhieu.TabIndex = 6;
            this.mstNgayLapPhieu.Value = new System.DateTime(2012, 8, 19, 0, 0, 0, 0);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label32.Location = new System.Drawing.Point(240, 66);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(49, 13);
            this.label32.TabIndex = 5;
            this.label32.Text = "Ngày lập";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label30.Location = new System.Drawing.Point(432, 39);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(56, 13);
            this.label30.TabIndex = 19;
            this.label30.Text = "Trưởng ca";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label35.Location = new System.Drawing.Point(420, 69);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(36, 13);
            this.label35.TabIndex = 10;
            this.label35.Text = "CMND";
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCMND.Location = new System.Drawing.Point(460, 65);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(116, 21);
            this.txtCMND.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label10.Location = new System.Drawing.Point(400, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Điện thoại";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtDienThoai.Location = new System.Drawing.Point(460, 16);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(116, 21);
            this.txtDienThoai.TabIndex = 3;
            // 
            // txtSoOrderKH
            // 
            this.txtSoOrderKH.BackColor = System.Drawing.Color.White;
            this.txtSoOrderKH.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtSoOrderKH.Location = new System.Drawing.Point(91, 63);
            this.txtSoOrderKH.Name = "txtSoOrderKH";
            this.txtSoOrderKH.Size = new System.Drawing.Size(102, 21);
            this.txtSoOrderKH.TabIndex = 3;
            this.txtSoOrderKH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoOrderKH_KeyDown);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label31.Location = new System.Drawing.Point(24, 66);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(64, 13);
            this.label31.TabIndex = 2;
            this.label31.Text = "Số giao dịch";
            // 
            // txtSoChungTuGoc
            // 
            this.txtSoChungTuGoc.BackColor = System.Drawing.Color.White;
            this.txtSoChungTuGoc.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtSoChungTuGoc.Location = new System.Drawing.Point(91, 87);
            this.txtSoChungTuGoc.Name = "txtSoChungTuGoc";
            this.txtSoChungTuGoc.ReadOnly = true;
            this.txtSoChungTuGoc.Size = new System.Drawing.Size(131, 21);
            this.txtSoChungTuGoc.TabIndex = 8;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblNhanVien.Location = new System.Drawing.Point(421, 17);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(67, 13);
            this.lblNhanVien.TabIndex = 17;
            this.lblNhanVien.Text = "Thương &viên";
            // 
            // lblSoPhieu
            // 
            this.lblSoPhieu.AutoSize = true;
            this.lblSoPhieu.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblSoPhieu.Location = new System.Drawing.Point(22, 89);
            this.lblSoPhieu.Name = "lblSoPhieu";
            this.lblSoPhieu.Size = new System.Drawing.Size(66, 13);
            this.lblSoPhieu.TabIndex = 7;
            this.lblSoPhieu.Text = "Số C.Từ gốc";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label41.Location = new System.Drawing.Point(216, 117);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(50, 13);
            this.label41.TabIndex = 19;
            this.label41.Text = "Q.Huyện";
            // 
            // txtDiaChiHD
            // 
            this.txtDiaChiHD.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiaChiHD.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtDiaChiHD.Location = new System.Drawing.Point(402, 90);
            this.txtDiaChiHD.Multiline = true;
            this.txtDiaChiHD.Name = "txtDiaChiHD";
            this.txtDiaChiHD.Size = new System.Drawing.Size(174, 20);
            this.txtDiaChiHD.TabIndex = 16;
            this.txtDiaChiHD.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label18.Location = new System.Drawing.Point(216, 93);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "Q.Huyện";
            // 
            // cboHuyen
            // 
            this.cboHuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHuyen.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cboHuyen.FormattingEnabled = true;
            this.cboHuyen.Items.AddRange(new object[] {
            "Bảng giá bán lẻ",
            "Bảng giá bán buôn",
            "Bảng giá hàng demo"});
            this.cboHuyen.Location = new System.Drawing.Point(267, 114);
            this.cboHuyen.Name = "cboHuyen";
            this.cboHuyen.Size = new System.Drawing.Size(129, 21);
            this.cboHuyen.TabIndex = 20;
            // 
            // cboHuyenHD
            // 
            this.cboHuyenHD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHuyenHD.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cboHuyenHD.FormattingEnabled = true;
            this.cboHuyenHD.Items.AddRange(new object[] {
            "Bảng giá bán lẻ",
            "Bảng giá bán buôn",
            "Bảng giá hàng demo"});
            this.cboHuyenHD.Location = new System.Drawing.Point(267, 90);
            this.cboHuyenHD.Name = "cboHuyenHD";
            this.cboHuyenHD.Size = new System.Drawing.Size(129, 21);
            this.cboHuyenHD.TabIndex = 15;
            this.cboHuyenHD.SelectedIndexChanged += new System.EventHandler(this.cboHuyen_SelectedIndexChanged);
            // 
            // cboTinhHD
            // 
            this.cboTinhHD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhHD.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cboTinhHD.FormattingEnabled = true;
            this.cboTinhHD.Items.AddRange(new object[] {
            "Bảng giá bán lẻ",
            "Bảng giá bán buôn",
            "Bảng giá hàng demo"});
            this.cboTinhHD.Location = new System.Drawing.Point(91, 90);
            this.cboTinhHD.Name = "cboTinhHD";
            this.cboTinhHD.Size = new System.Drawing.Size(123, 21);
            this.cboTinhHD.TabIndex = 13;
            this.cboTinhHD.SelectedIndexChanged += new System.EventHandler(this.cboTinhHD_SelectedIndexChanged);
            // 
            // cboTinh
            // 
            this.cboTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinh.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cboTinh.FormattingEnabled = true;
            this.cboTinh.Items.AddRange(new object[] {
            "Bảng giá bán lẻ",
            "Bảng giá bán buôn",
            "Bảng giá hàng demo"});
            this.cboTinh.Location = new System.Drawing.Point(91, 114);
            this.cboTinh.Name = "cboTinh";
            this.cboTinh.Size = new System.Drawing.Size(123, 21);
            this.cboTinh.TabIndex = 18;
            this.cboTinh.SelectedIndexChanged += new System.EventHandler(this.cboTinh_SelectedIndexChanged);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label40.Location = new System.Drawing.Point(8, 93);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(80, 13);
            this.label40.TabIndex = 12;
            this.label40.Text = "ĐC h/đơn: Tỉnh";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label42.Location = new System.Drawing.Point(2, 117);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(86, 13);
            this.label42.TabIndex = 17;
            this.label42.Text = "ĐC g/hàng: Tỉnh";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiaChi.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtDiaChi.Location = new System.Drawing.Point(402, 114);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(174, 20);
            this.txtDiaChi.TabIndex = 21;
            // 
            // cboLoaiHoaDon
            // 
            this.cboLoaiHoaDon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiHoaDon.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cboLoaiHoaDon.FormattingEnabled = true;
            this.cboLoaiHoaDon.Items.AddRange(new object[] {
            "",
            "Nam",
            "Nữ"});
            this.cboLoaiHoaDon.Location = new System.Drawing.Point(492, 86);
            this.cboLoaiHoaDon.Name = "cboLoaiHoaDon";
            this.cboLoaiHoaDon.Size = new System.Drawing.Size(221, 21);
            this.cboLoaiHoaDon.TabIndex = 24;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label28.Location = new System.Drawing.Point(420, 89);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(68, 13);
            this.label28.TabIndex = 23;
            this.label28.Text = "Loại hóa đơn";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label19.Location = new System.Drawing.Point(228, 114);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 13);
            this.label19.TabIndex = 15;
            this.label19.Text = "Số hóa đơn";
            // 
            // cboQuyen
            // 
            this.cboQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuyen.Enabled = false;
            this.cboQuyen.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cboQuyen.FormattingEnabled = true;
            this.cboQuyen.Location = new System.Drawing.Point(91, 111);
            this.cboQuyen.Name = "cboQuyen";
            this.cboQuyen.Size = new System.Drawing.Size(102, 21);
            this.cboQuyen.TabIndex = 13;
            this.cboQuyen.SelectedIndexChanged += new System.EventHandler(this.cboQuyen_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label21.Location = new System.Drawing.Point(28, 113);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 13);
            this.label21.TabIndex = 11;
            this.label21.Text = "Ký hiệu HĐ";
            // 
            // btnLoadQuyen
            // 
            this.btnLoadQuyen.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadQuyen.Image")));
            this.btnLoadQuyen.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLoadQuyen.Location = new System.Drawing.Point(195, 110);
            this.btnLoadQuyen.Name = "btnLoadQuyen";
            this.btnLoadQuyen.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnLoadQuyen.Size = new System.Drawing.Size(27, 23);
            this.btnLoadQuyen.TabIndex = 14;
            this.btnLoadQuyen.Click += new System.EventHandler(this.btnLoadQuyen_Click);
            // 
            // txtSoSerie
            // 
            this.txtSoSerie.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtSoSerie.Location = new System.Drawing.Point(293, 111);
            this.txtSoSerie.Name = "txtSoSerie";
            this.txtSoSerie.Size = new System.Drawing.Size(118, 21);
            this.txtSoSerie.TabIndex = 16;
            // 
            // bteKhachLe
            // 
            this.bteKhachLe.Location = new System.Drawing.Point(91, 16);
            this.bteKhachLe.Name = "bteKhachLe";
            this.bteKhachLe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteKhachLe.Size = new System.Drawing.Size(305, 20);
            this.bteKhachLe.TabIndex = 1;
            this.bteKhachLe.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteKhachLe_ButtonClick);
            this.bteKhachLe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteKhachLe_KeyDown);
            this.bteKhachLe.TextChanged += new System.EventHandler(this.bteKhachLe_TextChanged);
            // 
            // cboNgheNghiep
            // 
            this.cboNgheNghiep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNgheNghiep.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cboNgheNghiep.FormattingEnabled = true;
            this.cboNgheNghiep.Items.AddRange(new object[] {
            "Bảng giá bán lẻ",
            "Bảng giá bán buôn",
            "Bảng giá hàng demo"});
            this.cboNgheNghiep.Location = new System.Drawing.Point(91, 138);
            this.cboNgheNghiep.Name = "cboNgheNghiep";
            this.cboNgheNghiep.Size = new System.Drawing.Size(123, 21);
            this.cboNgheNghiep.TabIndex = 23;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label23.Location = new System.Drawing.Point(21, 140);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 13);
            this.label23.TabIndex = 22;
            this.label23.Text = "Nghề nghiệp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label4.Location = new System.Drawing.Point(222, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số HĐ đ.mua";
            // 
            // txtSoHDDaMua
            // 
            this.txtSoHDDaMua.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoHDDaMua.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtSoHDDaMua.Location = new System.Drawing.Point(293, 87);
            this.txtSoHDDaMua.Name = "txtSoHDDaMua";
            this.txtSoHDDaMua.Size = new System.Drawing.Size(118, 21);
            this.txtSoHDDaMua.TabIndex = 10;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label36.Location = new System.Drawing.Point(220, 166);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(46, 13);
            this.label36.TabIndex = 30;
            this.label36.Text = "Website";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label34.Location = new System.Drawing.Point(25, 19);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(63, 13);
            this.label34.TabIndex = 0;
            this.label34.Text = "&Mã khách lẻ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label13.Location = new System.Drawing.Point(221, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Giới tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label1.Location = new System.Drawing.Point(33, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Họ tên KH";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label14.Location = new System.Drawing.Point(414, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Độ tuổi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label2.Location = new System.Drawing.Point(57, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Email";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.Enabled = false;
            this.cboGioiTinh.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "",
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(267, 138);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(129, 21);
            this.cboGioiTinh.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label3.Location = new System.Drawing.Point(403, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "M.S.Thuế";
            // 
            // txtWebSite
            // 
            this.txtWebSite.BackColor = System.Drawing.SystemColors.Window;
            this.txtWebSite.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtWebSite.Location = new System.Drawing.Point(267, 163);
            this.txtWebSite.Name = "txtWebSite";
            this.txtWebSite.Size = new System.Drawing.Size(129, 21);
            this.txtWebSite.TabIndex = 31;
            // 
            // txtTuoi
            // 
            this.txtTuoi.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtTuoi.Location = new System.Drawing.Point(460, 138);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.Size = new System.Drawing.Size(116, 21);
            this.txtTuoi.TabIndex = 27;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtEmail.Location = new System.Drawing.Point(91, 163);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(124, 21);
            this.txtEmail.TabIndex = 29;
            // 
            // txtMaSoThue
            // 
            this.txtMaSoThue.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaSoThue.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtMaSoThue.Location = new System.Drawing.Point(460, 40);
            this.txtMaSoThue.Name = "txtMaSoThue";
            this.txtMaSoThue.Size = new System.Drawing.Size(116, 21);
            this.txtMaSoThue.TabIndex = 7;
            // 
            // txtHoTenKhachHang
            // 
            this.txtHoTenKhachHang.BackColor = System.Drawing.SystemColors.Window;
            this.txtHoTenKhachHang.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtHoTenKhachHang.Location = new System.Drawing.Point(91, 65);
            this.txtHoTenKhachHang.Name = "txtHoTenKhachHang";
            this.txtHoTenKhachHang.Size = new System.Drawing.Size(305, 21);
            this.txtHoTenKhachHang.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label17.Location = new System.Drawing.Point(38, 43);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "&Kho xuất";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblKhachHang.Location = new System.Drawing.Point(829, 41);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(63, 13);
            this.lblKhachHang.TabIndex = 27;
            this.lblKhachHang.Text = "Khách hàn&g";
            // 
            // grThongTin
            // 
            this.grThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grThongTin.Controls.Add(this.cboGiaoHang);
            this.grThongTin.Controls.Add(this.dteNgayHoaDon);
            this.grThongTin.Controls.Add(this.label38);
            this.grThongTin.Controls.Add(this.cboCurrentLoaiDT);
            this.grThongTin.Controls.Add(this.label37);
            this.grThongTin.Controls.Add(this.chkDraft);
            this.grThongTin.Controls.Add(this.bteTrungTam);
            this.grThongTin.Controls.Add(this.label26);
            this.grThongTin.Controls.Add(this.lblGhiChu);
            this.grThongTin.Controls.Add(this.txtGhiChu);
            this.grThongTin.Controls.Add(this.txtSoPhieuDC);
            this.grThongTin.Controls.Add(this.label20);
            this.grThongTin.Controls.Add(this.mstNgayHenGiaoHang);
            this.grThongTin.Controls.Add(this.bteKhachHang);
            this.grThongTin.Controls.Add(this.label4);
            this.grThongTin.Controls.Add(this.btnTimOrderKH);
            this.grThongTin.Controls.Add(this.lblKhachHang);
            this.grThongTin.Controls.Add(this.cboLoaiHoaDon);
            this.grThongTin.Controls.Add(this.bteThuNgan);
            this.grThongTin.Controls.Add(this.bteKhoXuat);
            this.grThongTin.Controls.Add(this.bteTruongCa);
            this.grThongTin.Controls.Add(this.txtSoHDDaMua);
            this.grThongTin.Controls.Add(this.label28);
            this.grThongTin.Controls.Add(this.label39);
            this.grThongTin.Controls.Add(this.bteThuongVien);
            this.grThongTin.Controls.Add(this.label30);
            this.grThongTin.Controls.Add(this.label17);
            this.grThongTin.Controls.Add(this.mstNgayLapPhieu);
            this.grThongTin.Controls.Add(this.label31);
            this.grThongTin.Controls.Add(this.txtSoOrderKH);
            this.grThongTin.Controls.Add(this.label32);
            this.grThongTin.Controls.Add(this.cboCaBanHang);
            this.grThongTin.Controls.Add(this.label33);
            this.grThongTin.Controls.Add(this.lblNhanVien);
            this.grThongTin.Controls.Add(this.lblSoPhieu);
            this.grThongTin.Controls.Add(this.txtSoChungTuGoc);
            this.grThongTin.Controls.Add(this.cboQuyen);
            this.grThongTin.Controls.Add(this.btnLoadQuyen);
            this.grThongTin.Controls.Add(this.label19);
            this.grThongTin.Controls.Add(this.label21);
            this.grThongTin.Controls.Add(this.txtSoSerie);
            this.grThongTin.Controls.Add(this.chkHDNhay);
            this.grThongTin.Location = new System.Drawing.Point(0, 27);
            this.grThongTin.Name = "grThongTin";
            this.grThongTin.Size = new System.Drawing.Size(1236, 140);
            this.grThongTin.TabIndex = 1;
            this.grThongTin.TabStop = false;
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
            this.cboGiaoHang.Location = new System.Drawing.Point(990, 61);
            this.cboGiaoHang.Name = "cboGiaoHang";
            this.cboGiaoHang.Size = new System.Drawing.Size(100, 21);
            this.cboGiaoHang.TabIndex = 132;
            this.cboGiaoHang.SelectedIndexChanged += new System.EventHandler(this.cboGiaoHang_SelectedIndexChanged);
            // 
            // dteNgayHoaDon
            // 
            this.dteNgayHoaDon.EditValue = null;
            this.dteNgayHoaDon.Location = new System.Drawing.Point(493, 111);
            this.dteNgayHoaDon.Name = "dteNgayHoaDon";
            this.dteNgayHoaDon.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dteNgayHoaDon.Properties.Appearance.Options.UseFont = true;
            this.dteNgayHoaDon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgayHoaDon.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dteNgayHoaDon.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteNgayHoaDon.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dteNgayHoaDon.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteNgayHoaDon.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteNgayHoaDon.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dteNgayHoaDon.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteNgayHoaDon.Size = new System.Drawing.Size(114, 20);
            this.dteNgayHoaDon.TabIndex = 131;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label38.Location = new System.Drawing.Point(414, 114);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(74, 13);
            this.label38.TabIndex = 130;
            this.label38.Text = "Ngày hóa đơn";
            // 
            // cboCurrentLoaiDT
            // 
            this.cboCurrentLoaiDT.FormattingEnabled = true;
            this.cboCurrentLoaiDT.Location = new System.Drawing.Point(896, 14);
            this.cboCurrentLoaiDT.Name = "cboCurrentLoaiDT";
            this.cboCurrentLoaiDT.Size = new System.Drawing.Size(320, 21);
            this.cboCurrentLoaiDT.TabIndex = 107;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label37.Location = new System.Drawing.Point(817, 17);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(75, 15);
            this.label37.TabIndex = 108;
            this.label37.Text = "Loại K.Hàng";
            // 
            // chkDraft
            // 
            this.chkDraft.AutoSize = true;
            this.chkDraft.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.chkDraft.Location = new System.Drawing.Point(717, 64);
            this.chkDraft.Name = "chkDraft";
            this.chkDraft.Size = new System.Drawing.Size(99, 17);
            this.chkDraft.TabIndex = 129;
            this.chkDraft.Text = "Nháp/Xác nhận";
            this.chkDraft.UseVisualStyleBackColor = true;
            // 
            // bteTrungTam
            // 
            this.bteTrungTam.Enabled = false;
            this.bteTrungTam.Location = new System.Drawing.Point(91, 15);
            this.bteTrungTam.Name = "bteTrungTam";
            this.bteTrungTam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteTrungTam.Properties.Appearance.Options.UseFont = true;
            this.bteTrungTam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteTrungTam.Size = new System.Drawing.Size(320, 22);
            this.bteTrungTam.TabIndex = 127;
            this.bteTrungTam.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteTrungTam_ButtonClick);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(33, 18);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(55, 13);
            this.label26.TabIndex = 128;
            this.label26.Text = "Trung tâm";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblGhiChu.Location = new System.Drawing.Point(845, 92);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(47, 13);
            this.lblGhiChu.TabIndex = 34;
            this.lblGhiChu.Text = "&Diễn giải";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtGhiChu.Location = new System.Drawing.Point(896, 88);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGhiChu.Size = new System.Drawing.Size(320, 45);
            this.txtGhiChu.TabIndex = 35;
            // 
            // txtSoPhieuDC
            // 
            this.txtSoPhieuDC.Location = new System.Drawing.Point(672, 112);
            this.txtSoPhieuDC.Name = "txtSoPhieuDC";
            this.txtSoPhieuDC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtSoPhieuDC.Size = new System.Drawing.Size(140, 20);
            this.txtSoPhieuDC.TabIndex = 26;
            this.txtSoPhieuDC.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtSoPhieuDC_ButtonClick);
            this.txtSoPhieuDC.Leave += new System.EventHandler(this.txtSoPhieuDC_Leave);
            this.txtSoPhieuDC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoPhieuDC_KeyDown);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label20.Location = new System.Drawing.Point(608, 115);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 13);
            this.label20.TabIndex = 25;
            this.label20.Text = "Số phiếu ĐC";
            // 
            // bteKhachHang
            // 
            this.bteKhachHang.Location = new System.Drawing.Point(896, 38);
            this.bteKhachHang.Name = "bteKhachHang";
            this.bteKhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteKhachHang.Size = new System.Drawing.Size(320, 20);
            this.bteKhachHang.TabIndex = 28;
            this.bteKhachHang.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteKhachHang_ButtonClick);
            this.bteKhachHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteKhachHang_KeyDown);
            this.bteKhachHang.TextChanged += new System.EventHandler(this.bteKhachHang_TextChanged);
            // 
            // bteKhoXuat
            // 
            this.bteKhoXuat.Enabled = false;
            this.bteKhoXuat.Location = new System.Drawing.Point(91, 40);
            this.bteKhoXuat.Name = "bteKhoXuat";
            this.bteKhoXuat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteKhoXuat.Size = new System.Drawing.Size(320, 20);
            this.bteKhoXuat.TabIndex = 1;
            this.bteKhoXuat.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteKhoXuat_ButtonClick);
            this.bteKhoXuat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteKhoXuat_KeyDown);
            this.bteKhoXuat.TextChanged += new System.EventHandler(this.bteKhoXuat_TextChanged);
            // 
            // chkHDNhay
            // 
            this.chkHDNhay.AutoSize = true;
            this.chkHDNhay.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.chkHDNhay.Location = new System.Drawing.Point(717, 89);
            this.chkHDNhay.Name = "chkHDNhay";
            this.chkHDNhay.Size = new System.Drawing.Size(93, 17);
            this.chkHDNhay.TabIndex = 133;
            this.chkHDNhay.Text = "Hóa đơn nhảy";
            this.chkHDNhay.UseVisualStyleBackColor = true;
            this.chkHDNhay.CheckedChanged += new System.EventHandler(this.chkHDNhay_CheckedChanged);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.cboQuocGia);
            this.groupBox1.Controls.Add(this.txtCongTy);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label41);
            this.groupBox1.Controls.Add(this.txtDiaChiHD);
            this.groupBox1.Controls.Add(this.bteKhachLe);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.cboHuyen);
            this.groupBox1.Controls.Add(this.txtHoTenKhachHang);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtDienThoai);
            this.groupBox1.Controls.Add(this.cboHuyenHD);
            this.groupBox1.Controls.Add(this.cboNgheNghiep);
            this.groupBox1.Controls.Add(this.txtMaSoThue);
            this.groupBox1.Controls.Add(this.txtWebSite);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboGioiTinh);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label36);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboTinhHD);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.label42);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label40);
            this.groupBox1.Controls.Add(this.cboTinh);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.txtTuoi);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(0, 388);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 202);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách hàng";
            // 
            // txtCongTy
            // 
            this.txtCongTy.BackColor = System.Drawing.SystemColors.Window;
            this.txtCongTy.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCongTy.Location = new System.Drawing.Point(91, 40);
            this.txtCongTy.Name = "txtCongTy";
            this.txtCongTy.Size = new System.Drawing.Size(305, 21);
            this.txtCongTy.TabIndex = 5;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label22.Location = new System.Drawing.Point(43, 43);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(45, 13);
            this.label22.TabIndex = 4;
            this.label22.Text = "&Công ty";
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
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label24.Location = new System.Drawing.Point(405, 166);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(49, 13);
            this.label24.TabIndex = 32;
            this.label24.Text = "Quốc gia";
            // 
            // cboQuocGia
            // 
            this.cboQuocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuocGia.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cboQuocGia.FormattingEnabled = true;
            this.cboQuocGia.Items.AddRange(new object[] {
            "",
            "Việt Nam"});
            this.cboQuocGia.Location = new System.Drawing.Point(460, 163);
            this.cboQuocGia.Name = "cboQuocGia";
            this.cboQuocGia.Size = new System.Drawing.Size(116, 21);
            this.cboQuocGia.TabIndex = 33;
            // 
            // frmBH_SuaDonHangBan
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 615);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grPayments);
            this.Controls.Add(this.grSanPhamBan);
            this.Controls.Add(this.grThongTin);
            this.KeyPreview = true;
            this.Name = "frmBH_SuaDonHangBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa đơn hàng bán";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhieuXuat_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBH_LapDonHangBan_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPhieuXuat_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grSanPhamBan.ResumeLayout(false);
            this.grSanPhamBan.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gSanPhamBan)).EndInit();
            this.ctxMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPhamBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.grPayments.ResumeLayout(false);
            this.grPayments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gHinhThucThanhToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHinhThucThanhToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteThoiHanThanhToan.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteThuNgan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTruongCa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteThuongVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhachLe.Properties)).EndInit();
            this.grThongTin.ResumeLayout(false);
            this.grThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayHoaDon.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayHoaDon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPhieuDC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhoXuat.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grSanPhamBan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grPayments;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTienVAT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.Label lblSPBInfors;
        private System.Windows.Forms.ToolStripButton tsbPayment;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private GtidTextBox textBox4;
        private GtidTextBox textBox5;
        private GtidTextBox textBox6;
        internal GtidButton btnThemHang;
        private GtidTextBox txtTongTienThanhToan;
        private GtidTextBox txtTongTienSauCK;
        private GtidTextBox txtTongTienVAT;
        private GtidTextBox txtTongTienHang;
        private GtidTextBox txtTongTienCK;
        private GtidTextBox txtTienConNo;
        private GtidTextBox txtTienThucTra;
        private GtidButton btnXoaSanPham;
        private GtidButton btnChietKhau;
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
        private GtidButton btnLoadQuyen;
        private GtidTextBox txtSoSerie;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cboQuyen;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cboMaDuAn;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox cboLoaiHoaDon;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label34;
        private GtidTextBox txtWebSite;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.ToolStripButton tsbConfirm;
        private GtidButton btnXoaTT;
        private GtidTextBox txtMaSanPham;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.DateTimePicker mstNgayHenGiaoHang;
        private System.Windows.Forms.ComboBox cboCaBanHang;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.DateTimePicker mstNgayLapPhieu;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label35;
        private GtidTextBox txtCMND;
        private System.Windows.Forms.Label label10;
        private GtidTextBox txtDienThoai;
        private GtidButton btnTimOrderKH;
        private GtidTextBox txtSoOrderKH;
        private System.Windows.Forms.Label label31;
        private GtidTextBox txtSoChungTuGoc;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblSoPhieu;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.GroupBox grThongTin;
        private System.Windows.Forms.Label label27;
        private GtidTextBox txtDiaChiHD;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cboHuyenHD;
        private System.Windows.Forms.ComboBox cboTinhHD;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.ComboBox cboHuyen;
        private System.Windows.Forms.ComboBox cboTinh;
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
        private System.Windows.Forms.ComboBox cboNgheNghiep;
        private System.Windows.Forms.Label label23;
        private DevExpress.XtraEditors.ButtonEdit bteTruongCa;
        private DevExpress.XtraEditors.ButtonEdit bteThuongVien;
        private DevExpress.XtraEditors.ButtonEdit bteThuNgan;
        private DevExpress.XtraEditors.ButtonEdit bteKhachLe;
        private DevExpress.XtraEditors.ButtonEdit bteKhoXuat;
        private DevExpress.XtraEditors.ButtonEdit bteKhachHang;
        private DevExpress.XtraEditors.ButtonEdit bteThoiHanThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiHangKem;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoaiHangKem;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private DevExpress.XtraGrid.GridControl gHinhThucThanhToan;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHinhThucThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn IdHinhThucThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn HinhThucThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn SoTienThanhToan;
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
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.ButtonEdit txtSoPhieuDC;
        private DevExpress.XtraGrid.Columns.GridColumn TyleThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongOld;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChuTT;
        private System.Windows.Forms.CheckBox chkTinhKM;
        private DevExpress.XtraGrid.Columns.GridColumn TaiKhoanQuy;
        private System.Windows.Forms.Label lblGhiChu;
        private GtidTextBox txtGhiChu;
        private System.Windows.Forms.CheckBox chkTraLaiNCC;
        private DevExpress.XtraEditors.ButtonEdit bteTrungTam;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckBox chkDraft;
        internal System.Windows.Forms.ComboBox cboCurrentLoaiDT;
        internal System.Windows.Forms.Label label37;
        private GtidButton btnSuaTToan;
        private DevExpress.XtraGrid.Columns.GridColumn SoPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn TenThuNgan;
        private System.Windows.Forms.CheckBox chkVoucher;
        private GtidButton btnThemKM;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem tsbChinhSachGia;
        private GtidButton btnSaoChep;
        public DevExpress.XtraEditors.DateEdit dteNgayHoaDon;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ComboBox cboGiaoHang;
        private System.Windows.Forms.CheckBox chkHDNhay;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cboQuocGia;
    }
}