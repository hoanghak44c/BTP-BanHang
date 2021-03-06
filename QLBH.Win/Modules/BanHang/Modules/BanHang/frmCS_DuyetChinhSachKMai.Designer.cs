using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frmCS_DuyetChinhSachKMai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCS_DuyetChinhSachKMai));
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mstHanHieuLuc = new System.Windows.Forms.DateTimePicker();
            this.mstNgayHieuLuc = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.btnTimKiem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDong = new System.Windows.Forms.ToolStripButton();
            this.chkVoHan = new System.Windows.Forms.CheckBox();
            this.tabChinhSach = new System.Windows.Forms.TabControl();
            this.tabSieuThiAD = new System.Windows.Forms.TabPage();
            this.gSieuThiAD = new DevExpress.XtraGrid.GridControl();
            this.gvSieuThiAD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdChinhSachST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongDonHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtSoKhachDauNgay = new QLBH.Core.Form.GtidTextBox();
            this.btnDeleteST = new QLBH.Core.Form.GtidButton();
            this.btnAddST = new QLBH.Core.Form.GtidButton();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNgayDuyet = new QLBH.Core.Form.GtidTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabKhachHangAD = new System.Windows.Forms.TabPage();
            this.btnDelKH = new QLBH.Core.Form.GtidButton();
            this.btnAddKH = new QLBH.Core.Form.GtidButton();
            this.gDoiTuong = new DevExpress.XtraGrid.GridControl();
            this.gvDoiTuong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdChinhSachKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdLoaiDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaLoaiDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoaiDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdDoiTuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaDoiTuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDoiTuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabThoiGianAD = new System.Windows.Forms.TabPage();
            this.label24 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gThoiGianAD = new DevExpress.XtraGrid.GridControl();
            this.gvThoiGianAD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdChinhSachTG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Thu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DayOfWeek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DayOfMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioDen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelTG = new QLBH.Core.Form.GtidButton();
            this.btnAddTG = new QLBH.Core.Form.GtidButton();
            this.tabThanhToan = new System.Windows.Forms.TabPage();
            this.txtSoTienTToanTThieu = new QLBH.Core.Form.GtidTextBox();
            this.gThanhToan = new DevExpress.XtraGrid.GridControl();
            this.gvThanhToan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdChinhSachTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdHinhThucTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HinhThucThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdNganHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNganHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNganHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdNganHangPH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdThoiHanTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNganHangPH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NganHangPhatHanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThoiHanThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelTT = new QLBH.Core.Form.GtidButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTT = new QLBH.Core.Form.GtidButton();
            this.label12 = new System.Windows.Forms.Label();
            this.txtThanhToanToiThieu = new QLBH.Core.Form.GtidTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabDKKhac = new System.Windows.Forms.TabPage();
            this.txtThoiHanMua = new QLBH.Core.Form.GtidTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGiaTriDHDaMua = new QLBH.Core.Form.GtidTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboGiaoHang = new System.Windows.Forms.ComboBox();
            this.cboNgheNghiep = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboHuyen = new System.Windows.Forms.ComboBox();
            this.cboTinh = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtGiaTriHDToiThieu = new QLBH.Core.Form.GtidTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtTuoiDen = new QLBH.Core.Form.GtidTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTuoiTu = new QLBH.Core.Form.GtidTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.chkDuyNhatSDT = new System.Windows.Forms.CheckBox();
            this.chkDuyNhatCMND = new System.Windows.Forms.CheckBox();
            this.gSanPham = new DevExpress.XtraGrid.GridControl();
            this.gvSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdDKMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdChinhSachDK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiHangMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoaiHangMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdHangMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaHangMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenHangMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaHangSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenHangSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaVachApDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaMuaTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaMuaDen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeDiemThuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoDiemThuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongToiDaCK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaTriMuaToiThieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongDuocMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongToiDaDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongPhaiMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SanPhamKemMa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SanPhamDaMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repMemoEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.SanPhamKem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KhuyenMaiMa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KhuyenMai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KhuyenMaiWeb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SanPhamNoADMa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SanPhamNoAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SanPhamYesADMa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SanPhamYesAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLePhanBo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtabListApDung = new DevExpress.XtraTab.XtraTabPage();
            this.xtabListNotApDung = new DevExpress.XtraTab.XtraTabPage();
            this.gDanhSachKhongAD = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSachKhongAD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdChinhSachNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSanPhamNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaSanPhamNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPhamNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtabListTongHop = new DevExpress.XtraTab.XtraTabPage();
            this.gChinhSachCTiet = new DevExpress.XtraGrid.GridControl();
            this.gvChinhSachCTiet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NganhHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdChiTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdBangGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.csIdDKMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.csIdSPKem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGiaCoVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBanBuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBanDemo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repKhuyenMai = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.DonGiaChuaVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaNhapHDCuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaNhapDemoCuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaTonKhoBQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienChietKhauQK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienKhuyenMai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeLNBQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DungSaiMin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DungSaiMax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaMin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaMax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBanAnToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongBanBQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DungSaiSLBQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThuongNong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeThuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoiNhuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoiNhuanTon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoiNhuanBB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoiNhuanTonBB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoiNhuanDemo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiCapNhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkApDungMacDinh = new System.Windows.Forms.CheckBox();
            this.cboMacDinh = new System.Windows.Forms.ComboBox();
            this.chkOnline = new System.Windows.Forms.CheckBox();
            this.txtGhiChu = new QLBH.Core.Form.GtidTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoChinhSachGia = new QLBH.Core.Form.GtidTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTrangThai = new QLBH.Core.Form.GtidTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.mstNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNguoiLap = new QLBH.Core.Form.GtidTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.nudDoUuTien = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.chkDaDuyet = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.tabChinhSach.SuspendLayout();
            this.tabSieuThiAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSieuThiAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSieuThiAD)).BeginInit();
            this.tabKhachHangAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDoiTuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDoiTuong)).BeginInit();
            this.tabThoiGianAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gThoiGianAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThoiGianAD)).BeginInit();
            this.tabThanhToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gThanhToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThanhToan)).BeginInit();
            this.tabDKKhac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repMemoEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtabListApDung.SuspendLayout();
            this.xtabListNotApDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDanhSachKhongAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachKhongAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.xtabListTongHop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gChinhSachCTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChinhSachCTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repKhuyenMai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDoUuTien)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Thiết lập chính sách giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Hiệu lực từ ngày";
            // 
            // mstHanHieuLuc
            // 
            this.mstHanHieuLuc.CustomFormat = "dd/MM/yyyy HH:mm";
            this.mstHanHieuLuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mstHanHieuLuc.Location = new System.Drawing.Point(398, 6);
            this.mstHanHieuLuc.Name = "mstHanHieuLuc";
            this.mstHanHieuLuc.Size = new System.Drawing.Size(145, 21);
            this.mstHanHieuLuc.TabIndex = 2;
            // 
            // mstNgayHieuLuc
            // 
            this.mstNgayHieuLuc.CustomFormat = "dd/MM/yyyy HH:mm ";
            this.mstNgayHieuLuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mstNgayHieuLuc.Location = new System.Drawing.Point(97, 6);
            this.mstNgayHieuLuc.Name = "mstNgayHieuLuc";
            this.mstNgayHieuLuc.Size = new System.Drawing.Size(145, 21);
            this.mstNgayHieuLuc.TabIndex = 0;
            this.mstNgayHieuLuc.Value = new System.DateTime(2012, 11, 11, 21, 48, 0, 0);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConfirm,
            this.toolStripSeparator2,
            this.btnStop,
            this.btnTimKiem,
            this.toolStripSeparator1,
            this.btnDong});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1063, 25);
            this.toolStrip1.TabIndex = 47;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(81, 22);
            this.btnConfirm.Text = "Duyệt (F2)";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnStop
            // 
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(90, 22);
            this.btnStop.Text = "Từ chối (F8)";
            this.btnStop.ToolTipText = "Tạm &dừng (F11)";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(106, 22);
            this.btnTimKiem.Text = "Tìm kiếm (F10)";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(85, 22);
            this.btnDong.Text = "Đóng (F12)";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // chkVoHan
            // 
            this.chkVoHan.AutoSize = true;
            this.chkVoHan.Checked = true;
            this.chkVoHan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVoHan.Location = new System.Drawing.Point(248, 6);
            this.chkVoHan.Name = "chkVoHan";
            this.chkVoHan.Size = new System.Drawing.Size(73, 17);
            this.chkVoHan.TabIndex = 1;
            this.chkVoHan.Text = "Đến ngày";
            this.chkVoHan.UseVisualStyleBackColor = true;
            this.chkVoHan.Visible = false;
            this.chkVoHan.CheckedChanged += new System.EventHandler(this.chkVoHan_CheckedChanged);
            // 
            // tabChinhSach
            // 
            this.tabChinhSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabChinhSach.Controls.Add(this.tabSieuThiAD);
            this.tabChinhSach.Controls.Add(this.tabKhachHangAD);
            this.tabChinhSach.Controls.Add(this.tabThoiGianAD);
            this.tabChinhSach.Controls.Add(this.tabThanhToan);
            this.tabChinhSach.Controls.Add(this.tabDKKhac);
            this.tabChinhSach.Location = new System.Drawing.Point(488, 29);
            this.tabChinhSach.Name = "tabChinhSach";
            this.tabChinhSach.SelectedIndex = 0;
            this.tabChinhSach.Size = new System.Drawing.Size(566, 204);
            this.tabChinhSach.TabIndex = 1;
            // 
            // tabSieuThiAD
            // 
            this.tabSieuThiAD.Controls.Add(this.gSieuThiAD);
            this.tabSieuThiAD.Controls.Add(this.txtSoKhachDauNgay);
            this.tabSieuThiAD.Controls.Add(this.btnDeleteST);
            this.tabSieuThiAD.Controls.Add(this.btnAddST);
            this.tabSieuThiAD.Controls.Add(this.label15);
            this.tabSieuThiAD.Controls.Add(this.txtNgayDuyet);
            this.tabSieuThiAD.Controls.Add(this.label16);
            this.tabSieuThiAD.Location = new System.Drawing.Point(4, 22);
            this.tabSieuThiAD.Name = "tabSieuThiAD";
            this.tabSieuThiAD.Padding = new System.Windows.Forms.Padding(3);
            this.tabSieuThiAD.Size = new System.Drawing.Size(558, 178);
            this.tabSieuThiAD.TabIndex = 3;
            this.tabSieuThiAD.Text = "Siêu thị áp dụng";
            this.tabSieuThiAD.UseVisualStyleBackColor = true;
            // 
            // gSieuThiAD
            // 
            this.gSieuThiAD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gSieuThiAD.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gSieuThiAD.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gSieuThiAD.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gSieuThiAD.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gSieuThiAD.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gSieuThiAD.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gSieuThiAD.Location = new System.Drawing.Point(6, 6);
            this.gSieuThiAD.MainView = this.gvSieuThiAD;
            this.gSieuThiAD.Name = "gSieuThiAD";
            this.gSieuThiAD.Size = new System.Drawing.Size(549, 135);
            this.gSieuThiAD.TabIndex = 3;
            this.gSieuThiAD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSieuThiAD});
            // 
            // gvSieuThiAD
            // 
            this.gvSieuThiAD.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvSieuThiAD.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvSieuThiAD.Appearance.FocusedCell.Options.UseFont = true;
            this.gvSieuThiAD.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvSieuThiAD.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvSieuThiAD.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvSieuThiAD.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvSieuThiAD.Appearance.Row.BackColor = System.Drawing.Color.Silver;
            this.gvSieuThiAD.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvSieuThiAD.Appearance.Row.Options.UseBackColor = true;
            this.gvSieuThiAD.Appearance.Row.Options.UseBorderColor = true;
            this.gvSieuThiAD.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvSieuThiAD.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvSieuThiAD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdChinhSachST,
            this.IdTrungTam,
            this.MaTrungTam,
            this.TenTrungTam,
            this.IdKho,
            this.MaKho,
            this.TenKho,
            this.SoLuongDonHang});
            this.gvSieuThiAD.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvSieuThiAD.GridControl = this.gSieuThiAD;
            this.gvSieuThiAD.Name = "gvSieuThiAD";
            this.gvSieuThiAD.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvSieuThiAD.OptionsSelection.MultiSelect = true;
            this.gvSieuThiAD.OptionsView.ShowDetailButtons = false;
            this.gvSieuThiAD.OptionsView.ShowGroupPanel = false;
            // 
            // IdChinhSachST
            // 
            this.IdChinhSachST.Caption = "IdChinhSach";
            this.IdChinhSachST.FieldName = "IdChinhSach";
            this.IdChinhSachST.Name = "IdChinhSachST";
            this.IdChinhSachST.OptionsColumn.AllowEdit = false;
            this.IdChinhSachST.OptionsColumn.AllowFocus = false;
            this.IdChinhSachST.OptionsColumn.AllowMove = false;
            this.IdChinhSachST.OptionsColumn.ReadOnly = true;
            this.IdChinhSachST.Width = 115;
            // 
            // IdTrungTam
            // 
            this.IdTrungTam.Caption = "IdTrungTam";
            this.IdTrungTam.FieldName = "IdTrungTam";
            this.IdTrungTam.Name = "IdTrungTam";
            this.IdTrungTam.OptionsColumn.AllowEdit = false;
            this.IdTrungTam.OptionsColumn.AllowFocus = false;
            this.IdTrungTam.OptionsColumn.AllowMove = false;
            this.IdTrungTam.OptionsColumn.ReadOnly = true;
            this.IdTrungTam.Width = 150;
            // 
            // MaTrungTam
            // 
            this.MaTrungTam.Caption = "Mã siêu thị";
            this.MaTrungTam.FieldName = "MaTrungTam";
            this.MaTrungTam.Name = "MaTrungTam";
            this.MaTrungTam.OptionsColumn.AllowEdit = false;
            this.MaTrungTam.Visible = true;
            this.MaTrungTam.VisibleIndex = 0;
            // 
            // TenTrungTam
            // 
            this.TenTrungTam.Caption = "Tên siêu thị";
            this.TenTrungTam.FieldName = "TenTrungTam";
            this.TenTrungTam.Name = "TenTrungTam";
            this.TenTrungTam.OptionsColumn.AllowEdit = false;
            this.TenTrungTam.Visible = true;
            this.TenTrungTam.VisibleIndex = 1;
            this.TenTrungTam.Width = 146;
            // 
            // IdKho
            // 
            this.IdKho.FieldName = "IdKho";
            this.IdKho.Name = "IdKho";
            // 
            // MaKho
            // 
            this.MaKho.Caption = "Mã kho";
            this.MaKho.FieldName = "MaKho";
            this.MaKho.Name = "MaKho";
            this.MaKho.OptionsColumn.AllowEdit = false;
            this.MaKho.Visible = true;
            this.MaKho.VisibleIndex = 2;
            this.MaKho.Width = 78;
            // 
            // TenKho
            // 
            this.TenKho.Caption = "Tên kho";
            this.TenKho.FieldName = "TenKho";
            this.TenKho.Name = "TenKho";
            this.TenKho.OptionsColumn.AllowEdit = false;
            this.TenKho.Visible = true;
            this.TenKho.VisibleIndex = 3;
            this.TenKho.Width = 135;
            // 
            // SoLuongDonHang
            // 
            this.SoLuongDonHang.Caption = "SL đơn hàng";
            this.SoLuongDonHang.FieldName = "SoLuongDonHang";
            this.SoLuongDonHang.Name = "SoLuongDonHang";
            this.SoLuongDonHang.OptionsColumn.AllowEdit = false;
            this.SoLuongDonHang.Visible = true;
            this.SoLuongDonHang.VisibleIndex = 4;
            this.SoLuongDonHang.Width = 82;
            // 
            // txtSoKhachDauNgay
            // 
            this.txtSoKhachDauNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoKhachDauNgay.Location = new System.Drawing.Point(481, 148);
            this.txtSoKhachDauNgay.Name = "txtSoKhachDauNgay";
            this.txtSoKhachDauNgay.Size = new System.Drawing.Size(74, 21);
            this.txtSoKhachDauNgay.TabIndex = 2;
            // 
            // btnDeleteST
            // 
            this.btnDeleteST.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteST.Appearance.Options.UseFont = true;
            this.btnDeleteST.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteST.Image")));
            this.btnDeleteST.Location = new System.Drawing.Point(37, 145);
            this.btnDeleteST.Name = "btnDeleteST";
            this.btnDeleteST.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnDeleteST.Size = new System.Drawing.Size(27, 27);
            this.btnDeleteST.TabIndex = 1;
            this.btnDeleteST.Click += new System.EventHandler(this.btnDeleteST_Click);
            // 
            // btnAddST
            // 
            this.btnAddST.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddST.Appearance.Options.UseFont = true;
            this.btnAddST.Image = ((System.Drawing.Image)(resources.GetObject("btnAddST.Image")));
            this.btnAddST.Location = new System.Drawing.Point(6, 145);
            this.btnAddST.Name = "btnAddST";
            this.btnAddST.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnAddST.Size = new System.Drawing.Size(27, 27);
            this.btnAddST.TabIndex = 0;
            this.btnAddST.Click += new System.EventHandler(this.btnAddST_Click);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(343, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 13);
            this.label15.TabIndex = 91;
            this.label15.Text = "Tổng số đơn hàng áp dụng";
            // 
            // txtNgayDuyet
            // 
            this.txtNgayDuyet.Location = new System.Drawing.Point(221, 148);
            this.txtNgayDuyet.Multiline = true;
            this.txtNgayDuyet.Name = "txtNgayDuyet";
            this.txtNgayDuyet.ReadOnly = true;
            this.txtNgayDuyet.Size = new System.Drawing.Size(44, 21);
            this.txtNgayDuyet.TabIndex = 91;
            this.txtNgayDuyet.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(152, 156);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 90;
            this.label16.Text = "Ngày duyệt";
            this.label16.Visible = false;
            // 
            // tabKhachHangAD
            // 
            this.tabKhachHangAD.Controls.Add(this.btnDelKH);
            this.tabKhachHangAD.Controls.Add(this.btnAddKH);
            this.tabKhachHangAD.Controls.Add(this.gDoiTuong);
            this.tabKhachHangAD.Location = new System.Drawing.Point(4, 22);
            this.tabKhachHangAD.Name = "tabKhachHangAD";
            this.tabKhachHangAD.Size = new System.Drawing.Size(558, 178);
            this.tabKhachHangAD.TabIndex = 4;
            this.tabKhachHangAD.Text = "Đối tượng khách hàng";
            this.tabKhachHangAD.UseVisualStyleBackColor = true;
            // 
            // btnDelKH
            // 
            this.btnDelKH.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelKH.Appearance.Options.UseFont = true;
            this.btnDelKH.Image = ((System.Drawing.Image)(resources.GetObject("btnDelKH.Image")));
            this.btnDelKH.Location = new System.Drawing.Point(37, 145);
            this.btnDelKH.Name = "btnDelKH";
            this.btnDelKH.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnDelKH.Size = new System.Drawing.Size(27, 27);
            this.btnDelKH.TabIndex = 1;
            this.btnDelKH.Click += new System.EventHandler(this.btnDelKH_Click);
            // 
            // btnAddKH
            // 
            this.btnAddKH.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddKH.Appearance.Options.UseFont = true;
            this.btnAddKH.Image = ((System.Drawing.Image)(resources.GetObject("btnAddKH.Image")));
            this.btnAddKH.Location = new System.Drawing.Point(6, 145);
            this.btnAddKH.Name = "btnAddKH";
            this.btnAddKH.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnAddKH.Size = new System.Drawing.Size(27, 27);
            this.btnAddKH.TabIndex = 0;
            this.btnAddKH.Click += new System.EventHandler(this.btnAddKH_Click);
            // 
            // gDoiTuong
            // 
            this.gDoiTuong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gDoiTuong.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gDoiTuong.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gDoiTuong.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gDoiTuong.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gDoiTuong.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gDoiTuong.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gDoiTuong.Location = new System.Drawing.Point(6, 6);
            this.gDoiTuong.MainView = this.gvDoiTuong;
            this.gDoiTuong.Name = "gDoiTuong";
            this.gDoiTuong.Size = new System.Drawing.Size(549, 136);
            this.gDoiTuong.TabIndex = 2;
            this.gDoiTuong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDoiTuong});
            // 
            // gvDoiTuong
            // 
            this.gvDoiTuong.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvDoiTuong.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvDoiTuong.Appearance.FocusedCell.Options.UseFont = true;
            this.gvDoiTuong.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvDoiTuong.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvDoiTuong.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvDoiTuong.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvDoiTuong.Appearance.Row.BackColor = System.Drawing.Color.Silver;
            this.gvDoiTuong.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvDoiTuong.Appearance.Row.Options.UseBackColor = true;
            this.gvDoiTuong.Appearance.Row.Options.UseBorderColor = true;
            this.gvDoiTuong.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvDoiTuong.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvDoiTuong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdChinhSachKH,
            this.IdLoaiDT,
            this.MaLoaiDT,
            this.TenLoaiDT,
            this.IdDoiTuong,
            this.MaDoiTuong,
            this.TenDoiTuong});
            this.gvDoiTuong.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvDoiTuong.GridControl = this.gDoiTuong;
            this.gvDoiTuong.Name = "gvDoiTuong";
            this.gvDoiTuong.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvDoiTuong.OptionsSelection.MultiSelect = true;
            this.gvDoiTuong.OptionsView.ShowDetailButtons = false;
            this.gvDoiTuong.OptionsView.ShowGroupPanel = false;
            // 
            // IdChinhSachKH
            // 
            this.IdChinhSachKH.Caption = "IdChinhSach";
            this.IdChinhSachKH.FieldName = "IdChinhSach";
            this.IdChinhSachKH.Name = "IdChinhSachKH";
            this.IdChinhSachKH.OptionsColumn.AllowEdit = false;
            this.IdChinhSachKH.OptionsColumn.AllowFocus = false;
            this.IdChinhSachKH.OptionsColumn.AllowMove = false;
            this.IdChinhSachKH.OptionsColumn.ReadOnly = true;
            this.IdChinhSachKH.Width = 115;
            // 
            // IdLoaiDT
            // 
            this.IdLoaiDT.Caption = "IdLoaiDT";
            this.IdLoaiDT.FieldName = "IdLoaiDT";
            this.IdLoaiDT.Name = "IdLoaiDT";
            this.IdLoaiDT.OptionsColumn.AllowEdit = false;
            this.IdLoaiDT.OptionsColumn.AllowFocus = false;
            this.IdLoaiDT.OptionsColumn.AllowMove = false;
            this.IdLoaiDT.OptionsColumn.ReadOnly = true;
            this.IdLoaiDT.Width = 150;
            // 
            // MaLoaiDT
            // 
            this.MaLoaiDT.Caption = "Mã nhóm";
            this.MaLoaiDT.FieldName = "MaLoaiDT";
            this.MaLoaiDT.Name = "MaLoaiDT";
            this.MaLoaiDT.OptionsColumn.AllowEdit = false;
            this.MaLoaiDT.Visible = true;
            this.MaLoaiDT.VisibleIndex = 0;
            this.MaLoaiDT.Width = 246;
            // 
            // TenLoaiDT
            // 
            this.TenLoaiDT.Caption = "Nhóm khách hàng";
            this.TenLoaiDT.FieldName = "TenLoaiDT";
            this.TenLoaiDT.Name = "TenLoaiDT";
            this.TenLoaiDT.OptionsColumn.AllowEdit = false;
            this.TenLoaiDT.Visible = true;
            this.TenLoaiDT.VisibleIndex = 1;
            this.TenLoaiDT.Width = 374;
            // 
            // IdDoiTuong
            // 
            this.IdDoiTuong.Caption = "IdDoiTuong";
            this.IdDoiTuong.FieldName = "IdDoiTuong";
            this.IdDoiTuong.Name = "IdDoiTuong";
            // 
            // MaDoiTuong
            // 
            this.MaDoiTuong.Caption = "Mã khách";
            this.MaDoiTuong.FieldName = "MaDoiTuong";
            this.MaDoiTuong.Name = "MaDoiTuong";
            this.MaDoiTuong.OptionsColumn.AllowEdit = false;
            this.MaDoiTuong.Visible = true;
            this.MaDoiTuong.VisibleIndex = 2;
            this.MaDoiTuong.Width = 267;
            // 
            // TenDoiTuong
            // 
            this.TenDoiTuong.Caption = "Tên khách hàng";
            this.TenDoiTuong.FieldName = "TenDoiTuong";
            this.TenDoiTuong.Name = "TenDoiTuong";
            this.TenDoiTuong.OptionsColumn.AllowEdit = false;
            this.TenDoiTuong.Visible = true;
            this.TenDoiTuong.VisibleIndex = 3;
            this.TenDoiTuong.Width = 273;
            // 
            // tabThoiGianAD
            // 
            this.tabThoiGianAD.Controls.Add(this.label24);
            this.tabThoiGianAD.Controls.Add(this.label2);
            this.tabThoiGianAD.Controls.Add(this.gThoiGianAD);
            this.tabThoiGianAD.Controls.Add(this.btnDelTG);
            this.tabThoiGianAD.Controls.Add(this.btnAddTG);
            this.tabThoiGianAD.Controls.Add(this.chkVoHan);
            this.tabThoiGianAD.Controls.Add(this.mstHanHieuLuc);
            this.tabThoiGianAD.Controls.Add(this.label4);
            this.tabThoiGianAD.Controls.Add(this.mstNgayHieuLuc);
            this.tabThoiGianAD.Location = new System.Drawing.Point(4, 22);
            this.tabThoiGianAD.Name = "tabThoiGianAD";
            this.tabThoiGianAD.Padding = new System.Windows.Forms.Padding(3);
            this.tabThoiGianAD.Size = new System.Drawing.Size(558, 178);
            this.tabThoiGianAD.TabIndex = 1;
            this.tabThoiGianAD.Text = "Thời gian áp dụng";
            this.tabThoiGianAD.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(342, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(52, 13);
            this.label24.TabIndex = 91;
            this.label24.Text = "đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 14);
            this.label2.TabIndex = 79;
            this.label2.Text = "Khung giờ áp dụng";
            // 
            // gThoiGianAD
            // 
            this.gThoiGianAD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gThoiGianAD.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gThoiGianAD.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gThoiGianAD.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gThoiGianAD.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gThoiGianAD.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gThoiGianAD.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gThoiGianAD.Location = new System.Drawing.Point(97, 47);
            this.gThoiGianAD.MainView = this.gvThoiGianAD;
            this.gThoiGianAD.Name = "gThoiGianAD";
            this.gThoiGianAD.Size = new System.Drawing.Size(387, 123);
            this.gThoiGianAD.TabIndex = 5;
            this.gThoiGianAD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvThoiGianAD});
            // 
            // gvThoiGianAD
            // 
            this.gvThoiGianAD.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvThoiGianAD.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvThoiGianAD.Appearance.FocusedCell.Options.UseFont = true;
            this.gvThoiGianAD.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvThoiGianAD.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvThoiGianAD.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvThoiGianAD.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvThoiGianAD.Appearance.Row.BackColor = System.Drawing.Color.Silver;
            this.gvThoiGianAD.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvThoiGianAD.Appearance.Row.Options.UseBackColor = true;
            this.gvThoiGianAD.Appearance.Row.Options.UseBorderColor = true;
            this.gvThoiGianAD.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvThoiGianAD.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvThoiGianAD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdChinhSachTG,
            this.Thu,
            this.DayOfWeek,
            this.Ngay,
            this.DayOfMonth,
            this.GioTu,
            this.GioDen});
            this.gvThoiGianAD.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvThoiGianAD.GridControl = this.gThoiGianAD;
            this.gvThoiGianAD.Name = "gvThoiGianAD";
            this.gvThoiGianAD.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvThoiGianAD.OptionsSelection.MultiSelect = true;
            this.gvThoiGianAD.OptionsView.ShowDetailButtons = false;
            this.gvThoiGianAD.OptionsView.ShowGroupPanel = false;
            // 
            // IdChinhSachTG
            // 
            this.IdChinhSachTG.Caption = "IdChinhSach";
            this.IdChinhSachTG.FieldName = "IdChinhSach";
            this.IdChinhSachTG.Name = "IdChinhSachTG";
            this.IdChinhSachTG.OptionsColumn.AllowEdit = false;
            this.IdChinhSachTG.OptionsColumn.AllowFocus = false;
            this.IdChinhSachTG.OptionsColumn.AllowMove = false;
            this.IdChinhSachTG.OptionsColumn.ReadOnly = true;
            this.IdChinhSachTG.Width = 115;
            // 
            // Thu
            // 
            this.Thu.Caption = "Thứ";
            this.Thu.FieldName = "Thu";
            this.Thu.Name = "Thu";
            this.Thu.OptionsColumn.AllowEdit = false;
            this.Thu.Width = 113;
            // 
            // DayOfWeek
            // 
            this.DayOfWeek.Caption = "Thứ";
            this.DayOfWeek.FieldName = "DayOfWeek";
            this.DayOfWeek.Name = "DayOfWeek";
            this.DayOfWeek.OptionsColumn.AllowEdit = false;
            this.DayOfWeek.Visible = true;
            this.DayOfWeek.VisibleIndex = 0;
            // 
            // Ngay
            // 
            this.Ngay.Caption = "Ngày";
            this.Ngay.FieldName = "Ngay";
            this.Ngay.Name = "Ngay";
            this.Ngay.OptionsColumn.AllowEdit = false;
            this.Ngay.Width = 91;
            // 
            // DayOfMonth
            // 
            this.DayOfMonth.Caption = "Ngày";
            this.DayOfMonth.FieldName = "DayOfMonth";
            this.DayOfMonth.Name = "DayOfMonth";
            this.DayOfMonth.OptionsColumn.AllowEdit = false;
            this.DayOfMonth.Visible = true;
            this.DayOfMonth.VisibleIndex = 1;
            // 
            // GioTu
            // 
            this.GioTu.Caption = "Giờ từ";
            this.GioTu.FieldName = "GioTu";
            this.GioTu.Name = "GioTu";
            this.GioTu.OptionsColumn.AllowEdit = false;
            this.GioTu.Visible = true;
            this.GioTu.VisibleIndex = 2;
            this.GioTu.Width = 84;
            // 
            // GioDen
            // 
            this.GioDen.Caption = "Giờ đến";
            this.GioDen.FieldName = "GioDen";
            this.GioDen.Name = "GioDen";
            this.GioDen.OptionsColumn.AllowEdit = false;
            this.GioDen.Visible = true;
            this.GioDen.VisibleIndex = 3;
            this.GioDen.Width = 82;
            // 
            // btnDelTG
            // 
            this.btnDelTG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelTG.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelTG.Appearance.Options.UseFont = true;
            this.btnDelTG.Image = ((System.Drawing.Image)(resources.GetObject("btnDelTG.Image")));
            this.btnDelTG.Location = new System.Drawing.Point(501, 103);
            this.btnDelTG.Name = "btnDelTG";
            this.btnDelTG.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnDelTG.Size = new System.Drawing.Size(27, 27);
            this.btnDelTG.TabIndex = 4;
            this.btnDelTG.Click += new System.EventHandler(this.btnDelTG_Click);
            // 
            // btnAddTG
            // 
            this.btnAddTG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTG.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTG.Appearance.Options.UseFont = true;
            this.btnAddTG.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTG.Image")));
            this.btnAddTG.Location = new System.Drawing.Point(501, 74);
            this.btnAddTG.Name = "btnAddTG";
            this.btnAddTG.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnAddTG.Size = new System.Drawing.Size(27, 27);
            this.btnAddTG.TabIndex = 3;
            this.btnAddTG.Click += new System.EventHandler(this.btnAddTG_Click);
            // 
            // tabThanhToan
            // 
            this.tabThanhToan.Controls.Add(this.txtSoTienTToanTThieu);
            this.tabThanhToan.Controls.Add(this.gThanhToan);
            this.tabThanhToan.Controls.Add(this.btnDelTT);
            this.tabThanhToan.Controls.Add(this.label1);
            this.tabThanhToan.Controls.Add(this.btnAddTT);
            this.tabThanhToan.Controls.Add(this.label12);
            this.tabThanhToan.Controls.Add(this.txtThanhToanToiThieu);
            this.tabThanhToan.Controls.Add(this.label11);
            this.tabThanhToan.Location = new System.Drawing.Point(4, 22);
            this.tabThanhToan.Name = "tabThanhToan";
            this.tabThanhToan.Size = new System.Drawing.Size(558, 178);
            this.tabThanhToan.TabIndex = 5;
            this.tabThanhToan.Text = "Thanh toán";
            this.tabThanhToan.UseVisualStyleBackColor = true;
            // 
            // txtSoTienTToanTThieu
            // 
            this.txtSoTienTToanTThieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoTienTToanTThieu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienTToanTThieu.Location = new System.Drawing.Point(439, 150);
            this.txtSoTienTToanTThieu.Name = "txtSoTienTToanTThieu";
            this.txtSoTienTToanTThieu.Size = new System.Drawing.Size(115, 22);
            this.txtSoTienTToanTThieu.TabIndex = 100;
            // 
            // gThanhToan
            // 
            this.gThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gThanhToan.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gThanhToan.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gThanhToan.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gThanhToan.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gThanhToan.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gThanhToan.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gThanhToan.Location = new System.Drawing.Point(5, 22);
            this.gThanhToan.MainView = this.gvThanhToan;
            this.gThanhToan.Name = "gThanhToan";
            this.gThanhToan.Size = new System.Drawing.Size(549, 120);
            this.gThanhToan.TabIndex = 96;
            this.gThanhToan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvThanhToan});
            // 
            // gvThanhToan
            // 
            this.gvThanhToan.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvThanhToan.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvThanhToan.Appearance.FocusedCell.Options.UseFont = true;
            this.gvThanhToan.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvThanhToan.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvThanhToan.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvThanhToan.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvThanhToan.Appearance.Row.BackColor = System.Drawing.Color.Silver;
            this.gvThanhToan.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvThanhToan.Appearance.Row.Options.UseBackColor = true;
            this.gvThanhToan.Appearance.Row.Options.UseBorderColor = true;
            this.gvThanhToan.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvThanhToan.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvThanhToan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdChinhSachTT,
            this.IdHinhThucTT,
            this.HinhThucThanhToan,
            this.IdNganHang,
            this.MaNganHang,
            this.TenNganHang,
            this.IdNganHangPH,
            this.IdThoiHanTT,
            this.MaNganHangPH,
            this.NganHangPhatHanh,
            this.ThoiHanThanhToan,
            this.TyLeThanhToan});
            this.gvThanhToan.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvThanhToan.GridControl = this.gThanhToan;
            this.gvThanhToan.Name = "gvThanhToan";
            this.gvThanhToan.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvThanhToan.OptionsSelection.MultiSelect = true;
            this.gvThanhToan.OptionsView.ShowDetailButtons = false;
            this.gvThanhToan.OptionsView.ShowGroupPanel = false;
            // 
            // IdChinhSachTT
            // 
            this.IdChinhSachTT.Caption = "IdChinhSach";
            this.IdChinhSachTT.FieldName = "IdChinhSach";
            this.IdChinhSachTT.Name = "IdChinhSachTT";
            this.IdChinhSachTT.OptionsColumn.AllowEdit = false;
            this.IdChinhSachTT.OptionsColumn.AllowFocus = false;
            this.IdChinhSachTT.OptionsColumn.AllowMove = false;
            this.IdChinhSachTT.OptionsColumn.ReadOnly = true;
            this.IdChinhSachTT.Width = 115;
            // 
            // IdHinhThucTT
            // 
            this.IdHinhThucTT.Caption = "IdHinhThucTT";
            this.IdHinhThucTT.FieldName = "IdHinhThucTT";
            this.IdHinhThucTT.Name = "IdHinhThucTT";
            this.IdHinhThucTT.OptionsColumn.AllowEdit = false;
            this.IdHinhThucTT.OptionsColumn.AllowFocus = false;
            this.IdHinhThucTT.OptionsColumn.AllowMove = false;
            this.IdHinhThucTT.OptionsColumn.ReadOnly = true;
            this.IdHinhThucTT.Width = 150;
            // 
            // HinhThucThanhToan
            // 
            this.HinhThucThanhToan.Caption = "Hình thức T.Toán";
            this.HinhThucThanhToan.FieldName = "HinhThucThanhToan";
            this.HinhThucThanhToan.Name = "HinhThucThanhToan";
            this.HinhThucThanhToan.OptionsColumn.AllowEdit = false;
            this.HinhThucThanhToan.OptionsColumn.ReadOnly = true;
            this.HinhThucThanhToan.Visible = true;
            this.HinhThucThanhToan.VisibleIndex = 0;
            this.HinhThucThanhToan.Width = 106;
            // 
            // IdNganHang
            // 
            this.IdNganHang.Caption = "IdNganHang";
            this.IdNganHang.FieldName = "IdNganHang";
            this.IdNganHang.Name = "IdNganHang";
            this.IdNganHang.OptionsColumn.AllowEdit = false;
            this.IdNganHang.OptionsColumn.ReadOnly = true;
            this.IdNganHang.Width = 168;
            // 
            // MaNganHang
            // 
            this.MaNganHang.Caption = "Mã";
            this.MaNganHang.FieldName = "MaNganHang";
            this.MaNganHang.Name = "MaNganHang";
            this.MaNganHang.OptionsColumn.AllowEdit = false;
            this.MaNganHang.OptionsColumn.ReadOnly = true;
            this.MaNganHang.Width = 64;
            // 
            // TenNganHang
            // 
            this.TenNganHang.Caption = "Ngân hàng T.Toán";
            this.TenNganHang.FieldName = "TenNganHang";
            this.TenNganHang.Name = "TenNganHang";
            this.TenNganHang.OptionsColumn.AllowEdit = false;
            this.TenNganHang.OptionsColumn.ReadOnly = true;
            this.TenNganHang.Visible = true;
            this.TenNganHang.VisibleIndex = 1;
            this.TenNganHang.Width = 112;
            // 
            // IdNganHangPH
            // 
            this.IdNganHangPH.Caption = "IdNganHangPH";
            this.IdNganHangPH.FieldName = "IdNganHangPH";
            this.IdNganHangPH.Name = "IdNganHangPH";
            this.IdNganHangPH.OptionsColumn.AllowEdit = false;
            this.IdNganHangPH.OptionsColumn.ReadOnly = true;
            // 
            // IdThoiHanTT
            // 
            this.IdThoiHanTT.Caption = "IdThoiHanTT";
            this.IdThoiHanTT.FieldName = "IdThoiHanTT";
            this.IdThoiHanTT.Name = "IdThoiHanTT";
            this.IdThoiHanTT.OptionsColumn.AllowEdit = false;
            this.IdThoiHanTT.OptionsColumn.ReadOnly = true;
            this.IdThoiHanTT.Width = 59;
            // 
            // MaNganHangPH
            // 
            this.MaNganHangPH.Caption = "MaNganHangPH";
            this.MaNganHangPH.FieldName = "MaNganHangPH";
            this.MaNganHangPH.Name = "MaNganHangPH";
            this.MaNganHangPH.OptionsColumn.AllowEdit = false;
            this.MaNganHangPH.OptionsColumn.ReadOnly = true;
            // 
            // NganHangPhatHanh
            // 
            this.NganHangPhatHanh.Caption = "Ngân hàng phát hành";
            this.NganHangPhatHanh.FieldName = "TenNganHangPH";
            this.NganHangPhatHanh.Name = "NganHangPhatHanh";
            this.NganHangPhatHanh.OptionsColumn.AllowEdit = false;
            this.NganHangPhatHanh.OptionsColumn.ReadOnly = true;
            this.NganHangPhatHanh.Visible = true;
            this.NganHangPhatHanh.VisibleIndex = 2;
            this.NganHangPhatHanh.Width = 126;
            // 
            // ThoiHanThanhToan
            // 
            this.ThoiHanThanhToan.Caption = "Thời hạn TT";
            this.ThoiHanThanhToan.FieldName = "ThoiHanThanhToan";
            this.ThoiHanThanhToan.Name = "ThoiHanThanhToan";
            this.ThoiHanThanhToan.OptionsColumn.AllowEdit = false;
            this.ThoiHanThanhToan.OptionsColumn.ReadOnly = true;
            this.ThoiHanThanhToan.Visible = true;
            this.ThoiHanThanhToan.VisibleIndex = 3;
            this.ThoiHanThanhToan.Width = 65;
            // 
            // TyLeThanhToan
            // 
            this.TyLeThanhToan.Caption = "Tỷ lệ TT";
            this.TyLeThanhToan.FieldName = "TyLeThanhToan";
            this.TyLeThanhToan.Name = "TyLeThanhToan";
            this.TyLeThanhToan.OptionsColumn.AllowEdit = false;
            this.TyLeThanhToan.OptionsColumn.ReadOnly = true;
            this.TyLeThanhToan.Visible = true;
            this.TyLeThanhToan.VisibleIndex = 4;
            this.TyLeThanhToan.Width = 77;
            // 
            // btnDelTT
            // 
            this.btnDelTT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelTT.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelTT.Appearance.Options.UseFont = true;
            this.btnDelTT.Image = ((System.Drawing.Image)(resources.GetObject("btnDelTT.Image")));
            this.btnDelTT.Location = new System.Drawing.Point(36, 146);
            this.btnDelTT.Name = "btnDelTT";
            this.btnDelTT.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnDelTT.Size = new System.Drawing.Size(27, 27);
            this.btnDelTT.TabIndex = 95;
            this.btnDelTT.Click += new System.EventHandler(this.btnDelTT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 99;
            this.label1.Text = "Hình thức thanh toán";
            // 
            // btnAddTT
            // 
            this.btnAddTT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddTT.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTT.Appearance.Options.UseFont = true;
            this.btnAddTT.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTT.Image")));
            this.btnAddTT.Location = new System.Drawing.Point(5, 146);
            this.btnAddTT.Name = "btnAddTT";
            this.btnAddTT.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnAddTT.Size = new System.Drawing.Size(27, 27);
            this.btnAddTT.TabIndex = 94;
            this.btnAddTT.Click += new System.EventHandler(this.btnAddTT_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(316, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 13);
            this.label12.TabIndex = 98;
            this.label12.Text = "Số tiền T.Toán tối thiểu";
            // 
            // txtThanhToanToiThieu
            // 
            this.txtThanhToanToiThieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThanhToanToiThieu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhToanToiThieu.Location = new System.Drawing.Point(242, 150);
            this.txtThanhToanToiThieu.Name = "txtThanhToanToiThieu";
            this.txtThanhToanToiThieu.Size = new System.Drawing.Size(68, 22);
            this.txtThanhToanToiThieu.TabIndex = 93;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(129, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 13);
            this.label11.TabIndex = 97;
            this.label11.Text = "Tỷ lệ T.Toán tối thiểu";
            // 
            // tabDKKhac
            // 
            this.tabDKKhac.Controls.Add(this.txtThoiHanMua);
            this.tabDKKhac.Controls.Add(this.label8);
            this.tabDKKhac.Controls.Add(this.txtGiaTriDHDaMua);
            this.tabDKKhac.Controls.Add(this.label7);
            this.tabDKKhac.Controls.Add(this.cboGiaoHang);
            this.tabDKKhac.Controls.Add(this.cboNgheNghiep);
            this.tabDKKhac.Controls.Add(this.label5);
            this.tabDKKhac.Controls.Add(this.label22);
            this.tabDKKhac.Controls.Add(this.label3);
            this.tabDKKhac.Controls.Add(this.cboHuyen);
            this.tabDKKhac.Controls.Add(this.cboTinh);
            this.tabDKKhac.Controls.Add(this.label21);
            this.tabDKKhac.Controls.Add(this.label20);
            this.tabDKKhac.Controls.Add(this.cboGioiTinh);
            this.tabDKKhac.Controls.Add(this.txtGiaTriHDToiThieu);
            this.tabDKKhac.Controls.Add(this.label19);
            this.tabDKKhac.Controls.Add(this.txtTuoiDen);
            this.tabDKKhac.Controls.Add(this.label18);
            this.tabDKKhac.Controls.Add(this.txtTuoiTu);
            this.tabDKKhac.Controls.Add(this.label17);
            this.tabDKKhac.Controls.Add(this.chkDuyNhatSDT);
            this.tabDKKhac.Controls.Add(this.chkDuyNhatCMND);
            this.tabDKKhac.Location = new System.Drawing.Point(4, 22);
            this.tabDKKhac.Name = "tabDKKhac";
            this.tabDKKhac.Size = new System.Drawing.Size(558, 178);
            this.tabDKKhac.TabIndex = 2;
            this.tabDKKhac.Text = "Điều kiện khác";
            this.tabDKKhac.UseVisualStyleBackColor = true;
            // 
            // txtThoiHanMua
            // 
            this.txtThoiHanMua.Location = new System.Drawing.Point(404, 82);
            this.txtThoiHanMua.Name = "txtThoiHanMua";
            this.txtThoiHanMua.Size = new System.Drawing.Size(138, 21);
            this.txtThoiHanMua.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 91;
            this.label8.Text = "Thời hạn đã mua (ngày)";
            // 
            // txtGiaTriDHDaMua
            // 
            this.txtGiaTriDHDaMua.Location = new System.Drawing.Point(404, 57);
            this.txtGiaTriDHDaMua.Name = "txtGiaTriDHDaMua";
            this.txtGiaTriDHDaMua.Size = new System.Drawing.Size(138, 21);
            this.txtGiaTriDHDaMua.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 89;
            this.label7.Text = "Giá trị đơn hàng đã mua";
            // 
            // cboGiaoHang
            // 
            this.cboGiaoHang.AutoCompleteCustomSource.AddRange(new string[] {
            "Nhận hàng tại siêu thị",
            "Giao hàng tại nhà"});
            this.cboGiaoHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGiaoHang.FormattingEnabled = true;
            this.cboGiaoHang.Items.AddRange(new object[] {
            "Tất cả",
            "Nhận hàng tại siêu thị",
            "Giao hàng tại nhà"});
            this.cboGiaoHang.Location = new System.Drawing.Point(404, 108);
            this.cboGiaoHang.Name = "cboGiaoHang";
            this.cboGiaoHang.Size = new System.Drawing.Size(112, 21);
            this.cboGiaoHang.TabIndex = 11;
            this.cboGiaoHang.Visible = false;
            // 
            // cboNgheNghiep
            // 
            this.cboNgheNghiep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNgheNghiep.FormattingEnabled = true;
            this.cboNgheNghiep.Items.AddRange(new object[] {
            "Bảng giá bán lẻ",
            "Bảng giá bán buôn",
            "Bảng giá hàng demo"});
            this.cboNgheNghiep.Location = new System.Drawing.Point(90, 108);
            this.cboNgheNghiep.Name = "cboNgheNghiep";
            this.cboNgheNghiep.Size = new System.Drawing.Size(168, 21);
            this.cboNgheNghiep.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 87;
            this.label5.Text = "Cách giao hàng";
            this.label5.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(18, 111);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(67, 13);
            this.label22.TabIndex = 70;
            this.label22.Text = "Nghề nghiệp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 86;
            this.label3.Text = "Quận/Huyện";
            // 
            // cboHuyen
            // 
            this.cboHuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHuyen.FormattingEnabled = true;
            this.cboHuyen.Items.AddRange(new object[] {
            "Bảng giá bán lẻ",
            "Bảng giá bán buôn",
            "Bảng giá hàng demo"});
            this.cboHuyen.Location = new System.Drawing.Point(90, 83);
            this.cboHuyen.Name = "cboHuyen";
            this.cboHuyen.Size = new System.Drawing.Size(168, 21);
            this.cboHuyen.TabIndex = 6;
            // 
            // cboTinh
            // 
            this.cboTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinh.FormattingEnabled = true;
            this.cboTinh.Items.AddRange(new object[] {
            "Bảng giá bán lẻ",
            "Bảng giá bán buôn",
            "Bảng giá hàng demo"});
            this.cboTinh.Location = new System.Drawing.Point(90, 58);
            this.cboTinh.Name = "cboTinh";
            this.cboTinh.Size = new System.Drawing.Size(168, 21);
            this.cboTinh.TabIndex = 5;
            this.cboTinh.SelectedIndexChanged += new System.EventHandler(this.cboTinh_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(2, 61);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 13);
            this.label21.TabIndex = 68;
            this.label21.Text = "Tỉnh/Thành phố";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(39, 33);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 13);
            this.label20.TabIndex = 67;
            this.label20.Text = "Giới tính";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.AutoCompleteCustomSource.AddRange(new string[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "",
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(90, 33);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(112, 21);
            this.cboGioiTinh.TabIndex = 4;
            // 
            // txtGiaTriHDToiThieu
            // 
            this.txtGiaTriHDToiThieu.Location = new System.Drawing.Point(404, 32);
            this.txtGiaTriHDToiThieu.Name = "txtGiaTriHDToiThieu";
            this.txtGiaTriHDToiThieu.Size = new System.Drawing.Size(138, 21);
            this.txtGiaTriHDToiThieu.TabIndex = 8;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(274, 35);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(125, 13);
            this.label19.TabIndex = 64;
            this.label19.Text = "Giá trị đơn hàng tối thiểu";
            // 
            // txtTuoiDen
            // 
            this.txtTuoiDen.Location = new System.Drawing.Point(492, 7);
            this.txtTuoiDen.Name = "txtTuoiDen";
            this.txtTuoiDen.Size = new System.Drawing.Size(50, 21);
            this.txtTuoiDen.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(461, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 13);
            this.label18.TabIndex = 62;
            this.label18.Text = "đến";
            // 
            // txtTuoiTu
            // 
            this.txtTuoiTu.Location = new System.Drawing.Point(404, 7);
            this.txtTuoiTu.Name = "txtTuoiTu";
            this.txtTuoiTu.Size = new System.Drawing.Size(50, 21);
            this.txtTuoiTu.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(343, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Độ tuổi từ";
            // 
            // chkDuyNhatSDT
            // 
            this.chkDuyNhatSDT.AutoSize = true;
            this.chkDuyNhatSDT.Enabled = false;
            this.chkDuyNhatSDT.Location = new System.Drawing.Point(139, 9);
            this.chkDuyNhatSDT.Name = "chkDuyNhatSDT";
            this.chkDuyNhatSDT.Size = new System.Drawing.Size(134, 17);
            this.chkDuyNhatSDT.TabIndex = 1;
            this.chkDuyNhatSDT.Text = "Duy nhất số điện thoai";
            this.chkDuyNhatSDT.UseVisualStyleBackColor = true;
            // 
            // chkDuyNhatCMND
            // 
            this.chkDuyNhatCMND.AutoSize = true;
            this.chkDuyNhatCMND.Enabled = false;
            this.chkDuyNhatCMND.Location = new System.Drawing.Point(6, 9);
            this.chkDuyNhatCMND.Name = "chkDuyNhatCMND";
            this.chkDuyNhatCMND.Size = new System.Drawing.Size(102, 17);
            this.chkDuyNhatCMND.TabIndex = 0;
            this.chkDuyNhatCMND.Text = "Duy nhất CMND";
            this.chkDuyNhatCMND.UseVisualStyleBackColor = true;
            // 
            // gSanPham
            // 
            this.gSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gSanPham.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gSanPham.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gSanPham.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gSanPham.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gSanPham.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gSanPham.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gSanPham.Location = new System.Drawing.Point(3, 3);
            this.gSanPham.MainView = this.gvSanPham;
            this.gSanPham.Name = "gSanPham";
            this.gSanPham.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repMemoEdit,
            this.repCheck});
            this.gSanPham.Size = new System.Drawing.Size(1051, 281);
            this.gSanPham.TabIndex = 8;
            this.gSanPham.UseEmbeddedNavigator = true;
            this.gSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSanPham,
            this.gridView1});
            // 
            // gvSanPham
            // 
            this.gvSanPham.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvSanPham.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvSanPham.Appearance.FocusedCell.Options.UseFont = true;
            this.gvSanPham.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvSanPham.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvSanPham.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvSanPham.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvSanPham.Appearance.Row.BackColor = System.Drawing.Color.Silver;
            this.gvSanPham.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvSanPham.Appearance.Row.Options.UseBackColor = true;
            this.gvSanPham.Appearance.Row.Options.UseBorderColor = true;
            this.gvSanPham.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvSanPham.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvSanPham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdDKMua,
            this.IdChinhSachDK,
            this.LoaiHangMua,
            this.TenLoaiHangMua,
            this.IdHangMua,
            this.MaHangMua,
            this.TenHangMua,
            this.MaHangSX,
            this.TenHangSX,
            this.MaVachApDung,
            this.GiaMuaTu,
            this.GiaMuaDen,
            this.TyLeDiemThuong,
            this.SoDiemThuong,
            this.TyLeChietKhau,
            this.TienChietKhau,
            this.SoLuongToiDaCK,
            this.GiaTriMuaToiThieu,
            this.SoLuongDuocMua,
            this.SoLuongToiDaDH,
            this.SoLuongPhaiMua,
            this.SanPhamKemMa,
            this.SanPhamDaMua,
            this.SanPhamKem,
            this.KhuyenMaiMa,
            this.KhuyenMai,
            this.KhuyenMaiWeb,
            this.SanPhamNoADMa,
            this.SanPhamNoAD,
            this.SanPhamYesADMa,
            this.SanPhamYesAD,
            this.TyLePhanBo,
            this.InHoaDon});
            this.gvSanPham.CustomizationFormBounds = new System.Drawing.Rectangle(808, 316, 216, 178);
            this.gvSanPham.GridControl = this.gSanPham;
            this.gvSanPham.Name = "gvSanPham";
            this.gvSanPham.OptionsSelection.InvertSelection = true;
            this.gvSanPham.OptionsSelection.MultiSelect = true;
            this.gvSanPham.OptionsView.ColumnAutoWidth = false;
            this.gvSanPham.OptionsView.ShowAutoFilterRow = true;
            this.gvSanPham.OptionsView.ShowDetailButtons = false;
            this.gvSanPham.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gvSanPham_ShowingEditor);
            this.gvSanPham.DoubleClick += new System.EventHandler(this.gvSanPham_DoubleClick);
            // 
            // IdDKMua
            // 
            this.IdDKMua.Caption = "IdDKMua";
            this.IdDKMua.FieldName = "IdDKMua";
            this.IdDKMua.Name = "IdDKMua";
            this.IdDKMua.OptionsColumn.AllowEdit = false;
            this.IdDKMua.OptionsColumn.AllowFocus = false;
            this.IdDKMua.OptionsColumn.AllowMove = false;
            this.IdDKMua.OptionsColumn.ReadOnly = true;
            this.IdDKMua.Width = 115;
            // 
            // IdChinhSachDK
            // 
            this.IdChinhSachDK.Caption = "IdChinhSach";
            this.IdChinhSachDK.FieldName = "IdChinhSach";
            this.IdChinhSachDK.Name = "IdChinhSachDK";
            this.IdChinhSachDK.OptionsColumn.AllowEdit = false;
            this.IdChinhSachDK.OptionsColumn.AllowFocus = false;
            this.IdChinhSachDK.OptionsColumn.AllowMove = false;
            this.IdChinhSachDK.OptionsColumn.ReadOnly = true;
            this.IdChinhSachDK.Width = 234;
            // 
            // LoaiHangMua
            // 
            this.LoaiHangMua.Caption = "LoaiHangMua";
            this.LoaiHangMua.FieldName = "LoaiHangMua";
            this.LoaiHangMua.Name = "LoaiHangMua";
            this.LoaiHangMua.OptionsColumn.AllowEdit = false;
            this.LoaiHangMua.Width = 96;
            // 
            // TenLoaiHangMua
            // 
            this.TenLoaiHangMua.Caption = "Áp dụng cho";
            this.TenLoaiHangMua.FieldName = "TenLoaiHangMua";
            this.TenLoaiHangMua.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.TenLoaiHangMua.Name = "TenLoaiHangMua";
            this.TenLoaiHangMua.OptionsColumn.AllowEdit = false;
            this.TenLoaiHangMua.Visible = true;
            this.TenLoaiHangMua.VisibleIndex = 0;
            this.TenLoaiHangMua.Width = 99;
            // 
            // IdHangMua
            // 
            this.IdHangMua.Caption = "IdHangMua";
            this.IdHangMua.FieldName = "IdHangMua";
            this.IdHangMua.Name = "IdHangMua";
            this.IdHangMua.Width = 89;
            // 
            // MaHangMua
            // 
            this.MaHangMua.Caption = "Mã hàng";
            this.MaHangMua.FieldName = "MaHangMua";
            this.MaHangMua.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.MaHangMua.Name = "MaHangMua";
            this.MaHangMua.OptionsColumn.ReadOnly = true;
            this.MaHangMua.Visible = true;
            this.MaHangMua.VisibleIndex = 1;
            this.MaHangMua.Width = 95;
            // 
            // TenHangMua
            // 
            this.TenHangMua.Caption = "Tên hàng mua";
            this.TenHangMua.FieldName = "TenHangMua";
            this.TenHangMua.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.TenHangMua.Name = "TenHangMua";
            this.TenHangMua.OptionsColumn.ReadOnly = true;
            this.TenHangMua.Visible = true;
            this.TenHangMua.VisibleIndex = 2;
            this.TenHangMua.Width = 238;
            // 
            // MaHangSX
            // 
            this.MaHangSX.Caption = "MaHangSX";
            this.MaHangSX.FieldName = "MaHangSX";
            this.MaHangSX.Name = "MaHangSX";
            this.MaHangSX.OptionsColumn.AllowEdit = false;
            // 
            // TenHangSX
            // 
            this.TenHangSX.Caption = "Tên hãng SX";
            this.TenHangSX.FieldName = "TenHangSX";
            this.TenHangSX.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.TenHangSX.Name = "TenHangSX";
            this.TenHangSX.OptionsColumn.AllowEdit = false;
            this.TenHangSX.Visible = true;
            this.TenHangSX.VisibleIndex = 3;
            this.TenHangSX.Width = 166;
            // 
            // MaVachApDung
            // 
            this.MaVachApDung.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.MaVachApDung.AppearanceCell.Options.UseBackColor = true;
            this.MaVachApDung.Caption = "Mã vạch áp dụng (ngăn cách bởi !!!)";
            this.MaVachApDung.FieldName = "MaVachApDung";
            this.MaVachApDung.Name = "MaVachApDung";
            this.MaVachApDung.Visible = true;
            this.MaVachApDung.VisibleIndex = 4;
            this.MaVachApDung.Width = 253;
            // 
            // GiaMuaTu
            // 
            this.GiaMuaTu.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.GiaMuaTu.AppearanceCell.Options.UseBackColor = true;
            this.GiaMuaTu.Caption = "Giá bán từ";
            this.GiaMuaTu.DisplayFormat.FormatString = "N0";
            this.GiaMuaTu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaMuaTu.FieldName = "GiaMuaTu";
            this.GiaMuaTu.Name = "GiaMuaTu";
            this.GiaMuaTu.Visible = true;
            this.GiaMuaTu.VisibleIndex = 5;
            // 
            // GiaMuaDen
            // 
            this.GiaMuaDen.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.GiaMuaDen.AppearanceCell.Options.UseBackColor = true;
            this.GiaMuaDen.Caption = "đến";
            this.GiaMuaDen.DisplayFormat.FormatString = "N0";
            this.GiaMuaDen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaMuaDen.FieldName = "GiaMuaDen";
            this.GiaMuaDen.Name = "GiaMuaDen";
            this.GiaMuaDen.Visible = true;
            this.GiaMuaDen.VisibleIndex = 6;
            // 
            // TyLeDiemThuong
            // 
            this.TyLeDiemThuong.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.TyLeDiemThuong.AppearanceCell.Options.UseBackColor = true;
            this.TyLeDiemThuong.Caption = "Tỷ lệ tích điểm thưởng";
            this.TyLeDiemThuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyLeDiemThuong.FieldName = "TyLeDiemThuong";
            this.TyLeDiemThuong.Name = "TyLeDiemThuong";
            this.TyLeDiemThuong.Visible = true;
            this.TyLeDiemThuong.VisibleIndex = 7;
            this.TyLeDiemThuong.Width = 137;
            // 
            // SoDiemThuong
            // 
            this.SoDiemThuong.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.SoDiemThuong.AppearanceCell.Options.UseBackColor = true;
            this.SoDiemThuong.Caption = "Số điểm thưởng";
            this.SoDiemThuong.DisplayFormat.FormatString = "N0";
            this.SoDiemThuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SoDiemThuong.FieldName = "SoDiemThuong";
            this.SoDiemThuong.Name = "SoDiemThuong";
            this.SoDiemThuong.Visible = true;
            this.SoDiemThuong.VisibleIndex = 8;
            this.SoDiemThuong.Width = 106;
            // 
            // TyLeChietKhau
            // 
            this.TyLeChietKhau.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.TyLeChietKhau.AppearanceCell.Options.UseBackColor = true;
            this.TyLeChietKhau.Caption = "Tỷ lệ Chiết khấu";
            this.TyLeChietKhau.FieldName = "TyLeChietKhau";
            this.TyLeChietKhau.Name = "TyLeChietKhau";
            this.TyLeChietKhau.Visible = true;
            this.TyLeChietKhau.VisibleIndex = 9;
            this.TyLeChietKhau.Width = 104;
            // 
            // TienChietKhau
            // 
            this.TienChietKhau.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.TienChietKhau.AppearanceCell.Options.UseBackColor = true;
            this.TienChietKhau.Caption = "Tiền chiết khấu";
            this.TienChietKhau.DisplayFormat.FormatString = "N0";
            this.TienChietKhau.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TienChietKhau.FieldName = "TienChietKhau";
            this.TienChietKhau.Name = "TienChietKhau";
            this.TienChietKhau.Visible = true;
            this.TienChietKhau.VisibleIndex = 10;
            this.TienChietKhau.Width = 115;
            // 
            // SoLuongToiDaCK
            // 
            this.SoLuongToiDaCK.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.SoLuongToiDaCK.AppearanceCell.Options.UseBackColor = true;
            this.SoLuongToiDaCK.Caption = "SLượng tối đa voucher CK";
            this.SoLuongToiDaCK.DisplayFormat.FormatString = "N0";
            this.SoLuongToiDaCK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SoLuongToiDaCK.FieldName = "SoLuongToiDaCK";
            this.SoLuongToiDaCK.Name = "SoLuongToiDaCK";
            this.SoLuongToiDaCK.Visible = true;
            this.SoLuongToiDaCK.VisibleIndex = 11;
            this.SoLuongToiDaCK.Width = 155;
            // 
            // GiaTriMuaToiThieu
            // 
            this.GiaTriMuaToiThieu.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.GiaTriMuaToiThieu.AppearanceCell.Options.UseBackColor = true;
            this.GiaTriMuaToiThieu.Caption = "Giá trị/Đ.Hàng tối thiểu";
            this.GiaTriMuaToiThieu.DisplayFormat.FormatString = "N0";
            this.GiaTriMuaToiThieu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaTriMuaToiThieu.FieldName = "GiaTriMuaToiThieu";
            this.GiaTriMuaToiThieu.Name = "GiaTriMuaToiThieu";
            this.GiaTriMuaToiThieu.ToolTip = "Giá trị sản phẩm chính + sản phẩm kèm tối thiểu";
            this.GiaTriMuaToiThieu.Visible = true;
            this.GiaTriMuaToiThieu.VisibleIndex = 12;
            this.GiaTriMuaToiThieu.Width = 143;
            // 
            // SoLuongDuocMua
            // 
            this.SoLuongDuocMua.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.SoLuongDuocMua.AppearanceCell.Options.UseBackColor = true;
            this.SoLuongDuocMua.Caption = "Tổng SL được mua cả C.Trình/1 Người";
            this.SoLuongDuocMua.DisplayFormat.FormatString = "N0";
            this.SoLuongDuocMua.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SoLuongDuocMua.FieldName = "SoLuongDuocMua";
            this.SoLuongDuocMua.Name = "SoLuongDuocMua";
            this.SoLuongDuocMua.ToolTip = "Tổng số lượng 1 người được mua trong cả 1 chương trình";
            this.SoLuongDuocMua.Visible = true;
            this.SoLuongDuocMua.VisibleIndex = 13;
            this.SoLuongDuocMua.Width = 202;
            // 
            // SoLuongToiDaDH
            // 
            this.SoLuongToiDaDH.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.SoLuongToiDaDH.AppearanceCell.Options.UseBackColor = true;
            this.SoLuongToiDaDH.Caption = "SLượng tối đa 1 lần được mua/1 Đ.Hàng";
            this.SoLuongToiDaDH.FieldName = "SoLuongToiDaDH";
            this.SoLuongToiDaDH.Name = "SoLuongToiDaDH";
            this.SoLuongToiDaDH.Visible = true;
            this.SoLuongToiDaDH.VisibleIndex = 14;
            this.SoLuongToiDaDH.Width = 206;
            // 
            // SoLuongPhaiMua
            // 
            this.SoLuongPhaiMua.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.SoLuongPhaiMua.AppearanceCell.Options.UseBackColor = true;
            this.SoLuongPhaiMua.Caption = "SLượng tối thiêu 1 lần phải mua/1 Đ.Hàng";
            this.SoLuongPhaiMua.DisplayFormat.FormatString = "N0";
            this.SoLuongPhaiMua.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SoLuongPhaiMua.FieldName = "SoLuongPhaiMua";
            this.SoLuongPhaiMua.Name = "SoLuongPhaiMua";
            this.SoLuongPhaiMua.Visible = true;
            this.SoLuongPhaiMua.VisibleIndex = 15;
            this.SoLuongPhaiMua.Width = 227;
            // 
            // SanPhamKemMa
            // 
            this.SanPhamKemMa.Caption = "SanPhamKemMa";
            this.SanPhamKemMa.FieldName = "SanPhamKemMa";
            this.SanPhamKemMa.Name = "SanPhamKemMa";
            this.SanPhamKemMa.OptionsColumn.AllowEdit = false;
            this.SanPhamKemMa.Width = 125;
            // 
            // SanPhamDaMua
            // 
            this.SanPhamDaMua.Caption = "Mặt hàng đã mua";
            this.SanPhamDaMua.ColumnEdit = this.repMemoEdit;
            this.SanPhamDaMua.FieldName = "SanPhamDaMua";
            this.SanPhamDaMua.Name = "SanPhamDaMua";
            this.SanPhamDaMua.OptionsColumn.AllowEdit = false;
            this.SanPhamDaMua.Visible = true;
            this.SanPhamDaMua.VisibleIndex = 16;
            this.SanPhamDaMua.Width = 138;
            // 
            // repMemoEdit
            // 
            this.repMemoEdit.Name = "repMemoEdit";
            // 
            // SanPhamKem
            // 
            this.SanPhamKem.Caption = "Mặt hàng mua kèm";
            this.SanPhamKem.ColumnEdit = this.repMemoEdit;
            this.SanPhamKem.FieldName = "SanPhamKem";
            this.SanPhamKem.Name = "SanPhamKem";
            this.SanPhamKem.OptionsColumn.AllowEdit = false;
            this.SanPhamKem.Visible = true;
            this.SanPhamKem.VisibleIndex = 17;
            this.SanPhamKem.Width = 137;
            // 
            // KhuyenMaiMa
            // 
            this.KhuyenMaiMa.Caption = "KhuyenMaiMa";
            this.KhuyenMaiMa.FieldName = "KhuyenMaiMa";
            this.KhuyenMaiMa.Name = "KhuyenMaiMa";
            this.KhuyenMaiMa.OptionsColumn.AllowEdit = false;
            this.KhuyenMaiMa.Width = 95;
            // 
            // KhuyenMai
            // 
            this.KhuyenMai.Caption = "Khuyến mại";
            this.KhuyenMai.ColumnEdit = this.repMemoEdit;
            this.KhuyenMai.FieldName = "KhuyenMai";
            this.KhuyenMai.Name = "KhuyenMai";
            this.KhuyenMai.OptionsColumn.AllowEdit = false;
            this.KhuyenMai.Visible = true;
            this.KhuyenMai.VisibleIndex = 18;
            this.KhuyenMai.Width = 127;
            // 
            // KhuyenMaiWeb
            // 
            this.KhuyenMaiWeb.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.KhuyenMaiWeb.AppearanceCell.Options.UseBackColor = true;
            this.KhuyenMaiWeb.Caption = "Khuyến mại Website";
            this.KhuyenMaiWeb.FieldName = "KhuyenMaiWeb";
            this.KhuyenMaiWeb.Name = "KhuyenMaiWeb";
            this.KhuyenMaiWeb.Visible = true;
            this.KhuyenMaiWeb.VisibleIndex = 19;
            this.KhuyenMaiWeb.Width = 244;
            // 
            // SanPhamNoADMa
            // 
            this.SanPhamNoADMa.Caption = "SanPhamNoADMa";
            this.SanPhamNoADMa.FieldName = "SanPhamNoADMa";
            this.SanPhamNoADMa.Name = "SanPhamNoADMa";
            this.SanPhamNoADMa.OptionsColumn.AllowEdit = false;
            this.SanPhamNoADMa.Width = 213;
            // 
            // SanPhamNoAD
            // 
            this.SanPhamNoAD.Caption = "Mặt hàng không áp dụng";
            this.SanPhamNoAD.FieldName = "SanPhamNoAD";
            this.SanPhamNoAD.Name = "SanPhamNoAD";
            this.SanPhamNoAD.OptionsColumn.AllowEdit = false;
            this.SanPhamNoAD.Visible = true;
            this.SanPhamNoAD.VisibleIndex = 20;
            this.SanPhamNoAD.Width = 151;
            // 
            // SanPhamYesADMa
            // 
            this.SanPhamYesADMa.Caption = "SanPhamYesADMa";
            this.SanPhamYesADMa.FieldName = "SanPhamYesADMa";
            this.SanPhamYesADMa.Name = "SanPhamYesADMa";
            // 
            // SanPhamYesAD
            // 
            this.SanPhamYesAD.Caption = "Mặt hàng được áp dụng";
            this.SanPhamYesAD.FieldName = "SanPhamYesAD";
            this.SanPhamYesAD.Name = "SanPhamYesAD";
            this.SanPhamYesAD.OptionsColumn.AllowEdit = false;
            this.SanPhamYesAD.Visible = true;
            this.SanPhamYesAD.VisibleIndex = 21;
            this.SanPhamYesAD.Width = 172;
            // 
            // TyLePhanBo
            // 
            this.TyLePhanBo.Caption = "Tỷ lệ phân bổ";
            this.TyLePhanBo.DisplayFormat.FormatString = "N0";
            this.TyLePhanBo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyLePhanBo.FieldName = "TyLePhanBo";
            this.TyLePhanBo.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.TyLePhanBo.Name = "TyLePhanBo";
            this.TyLePhanBo.OptionsColumn.AllowEdit = false;
            this.TyLePhanBo.Visible = true;
            this.TyLePhanBo.VisibleIndex = 23;
            // 
            // InHoaDon
            // 
            this.InHoaDon.Caption = "In hóa đơn";
            this.InHoaDon.ColumnEdit = this.repCheck;
            this.InHoaDon.FieldName = "InHoaDon";
            this.InHoaDon.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.InHoaDon.Name = "InHoaDon";
            this.InHoaDon.Visible = true;
            this.InHoaDon.VisibleIndex = 22;
            // 
            // repCheck
            // 
            this.repCheck.AutoHeight = false;
            this.repCheck.Name = "repCheck";
            this.repCheck.ValueChecked = 1;
            this.repCheck.ValueUnchecked = 0;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gSanPham;
            this.gridView1.Name = "gridView1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 239);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtabListApDung;
            this.xtraTabControl1.Size = new System.Drawing.Size(1064, 287);
            this.xtraTabControl1.TabIndex = 101;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtabListApDung,
            this.xtabListNotApDung,
            this.xtabListTongHop});
            // 
            // xtabListApDung
            // 
            this.xtabListApDung.Controls.Add(this.gSanPham);
            this.xtabListApDung.Name = "xtabListApDung";
            this.xtabListApDung.Size = new System.Drawing.Size(1057, 259);
            this.xtabListApDung.Text = "Danh sách mặt hàng áp dụng";
            // 
            // xtabListNotApDung
            // 
            this.xtabListNotApDung.Controls.Add(this.gDanhSachKhongAD);
            this.xtabListNotApDung.Name = "xtabListNotApDung";
            this.xtabListNotApDung.Size = new System.Drawing.Size(1057, 259);
            this.xtabListNotApDung.Text = "Danh sách mặt hàng không áp dụng";
            // 
            // gDanhSachKhongAD
            // 
            this.gDanhSachKhongAD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gDanhSachKhongAD.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gDanhSachKhongAD.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gDanhSachKhongAD.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gDanhSachKhongAD.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gDanhSachKhongAD.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gDanhSachKhongAD.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gDanhSachKhongAD.Location = new System.Drawing.Point(3, 3);
            this.gDanhSachKhongAD.MainView = this.gvDanhSachKhongAD;
            this.gDanhSachKhongAD.Name = "gDanhSachKhongAD";
            this.gDanhSachKhongAD.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.gDanhSachKhongAD.Size = new System.Drawing.Size(1049, 253);
            this.gDanhSachKhongAD.TabIndex = 9;
            this.gDanhSachKhongAD.UseEmbeddedNavigator = true;
            this.gDanhSachKhongAD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSachKhongAD,
            this.gridView3});
            // 
            // gvDanhSachKhongAD
            // 
            this.gvDanhSachKhongAD.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvDanhSachKhongAD.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvDanhSachKhongAD.Appearance.FocusedCell.Options.UseFont = true;
            this.gvDanhSachKhongAD.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvDanhSachKhongAD.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvDanhSachKhongAD.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvDanhSachKhongAD.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvDanhSachKhongAD.Appearance.Row.BackColor = System.Drawing.Color.Silver;
            this.gvDanhSachKhongAD.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvDanhSachKhongAD.Appearance.Row.Options.UseBackColor = true;
            this.gvDanhSachKhongAD.Appearance.Row.Options.UseBorderColor = true;
            this.gvDanhSachKhongAD.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvDanhSachKhongAD.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvDanhSachKhongAD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdChinhSachNo,
            this.IdSanPhamNo,
            this.MaSanPhamNo,
            this.TenSanPhamNo});
            this.gvDanhSachKhongAD.CustomizationFormBounds = new System.Drawing.Rectangle(808, 316, 216, 178);
            this.gvDanhSachKhongAD.GridControl = this.gDanhSachKhongAD;
            this.gvDanhSachKhongAD.Name = "gvDanhSachKhongAD";
            this.gvDanhSachKhongAD.OptionsSelection.InvertSelection = true;
            this.gvDanhSachKhongAD.OptionsSelection.MultiSelect = true;
            this.gvDanhSachKhongAD.OptionsView.ColumnAutoWidth = false;
            this.gvDanhSachKhongAD.OptionsView.ShowAutoFilterRow = true;
            this.gvDanhSachKhongAD.OptionsView.ShowDetailButtons = false;
            // 
            // IdChinhSachNo
            // 
            this.IdChinhSachNo.Caption = "IdChinhSach";
            this.IdChinhSachNo.FieldName = "IdChinhSach";
            this.IdChinhSachNo.Name = "IdChinhSachNo";
            this.IdChinhSachNo.OptionsColumn.AllowEdit = false;
            this.IdChinhSachNo.OptionsColumn.AllowFocus = false;
            this.IdChinhSachNo.OptionsColumn.AllowMove = false;
            this.IdChinhSachNo.OptionsColumn.ReadOnly = true;
            this.IdChinhSachNo.Width = 234;
            // 
            // IdSanPhamNo
            // 
            this.IdSanPhamNo.Caption = "IdSanPham";
            this.IdSanPhamNo.FieldName = "IdMatHang";
            this.IdSanPhamNo.Name = "IdSanPhamNo";
            this.IdSanPhamNo.Width = 89;
            // 
            // MaSanPhamNo
            // 
            this.MaSanPhamNo.Caption = "Mã sản phẩm";
            this.MaSanPhamNo.FieldName = "MaMatHang";
            this.MaSanPhamNo.Name = "MaSanPhamNo";
            this.MaSanPhamNo.OptionsColumn.ReadOnly = true;
            this.MaSanPhamNo.Visible = true;
            this.MaSanPhamNo.VisibleIndex = 0;
            this.MaSanPhamNo.Width = 200;
            // 
            // TenSanPhamNo
            // 
            this.TenSanPhamNo.Caption = "Tên sản phẩm";
            this.TenSanPhamNo.FieldName = "TenMatHang";
            this.TenSanPhamNo.Name = "TenSanPhamNo";
            this.TenSanPhamNo.OptionsColumn.ReadOnly = true;
            this.TenSanPhamNo.Visible = true;
            this.TenSanPhamNo.VisibleIndex = 1;
            this.TenSanPhamNo.Width = 850;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gDanhSachKhongAD;
            this.gridView3.Name = "gridView3";
            // 
            // xtabListTongHop
            // 
            this.xtabListTongHop.Controls.Add(this.gChinhSachCTiet);
            this.xtabListTongHop.Name = "xtabListTongHop";
            this.xtabListTongHop.Size = new System.Drawing.Size(1057, 259);
            this.xtabListTongHop.Text = "Tổng hợp chính sách giá";
            // 
            // gChinhSachCTiet
            // 
            this.gChinhSachCTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gChinhSachCTiet.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gChinhSachCTiet.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gChinhSachCTiet.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gChinhSachCTiet.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gChinhSachCTiet.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gChinhSachCTiet.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gChinhSachCTiet.Location = new System.Drawing.Point(3, 3);
            this.gChinhSachCTiet.MainView = this.gvChinhSachCTiet;
            this.gChinhSachCTiet.Name = "gChinhSachCTiet";
            this.gChinhSachCTiet.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repKhuyenMai});
            this.gChinhSachCTiet.Size = new System.Drawing.Size(1051, 252);
            this.gChinhSachCTiet.TabIndex = 9;
            this.gChinhSachCTiet.UseEmbeddedNavigator = true;
            this.gChinhSachCTiet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChinhSachCTiet,
            this.gridView4});
            // 
            // gvChinhSachCTiet
            // 
            this.gvChinhSachCTiet.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvChinhSachCTiet.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvChinhSachCTiet.Appearance.FocusedCell.Options.UseFont = true;
            this.gvChinhSachCTiet.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvChinhSachCTiet.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvChinhSachCTiet.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvChinhSachCTiet.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvChinhSachCTiet.Appearance.Row.BackColor = System.Drawing.Color.Silver;
            this.gvChinhSachCTiet.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvChinhSachCTiet.Appearance.Row.Options.UseBackColor = true;
            this.gvChinhSachCTiet.Appearance.Row.Options.UseBorderColor = true;
            this.gvChinhSachCTiet.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvChinhSachCTiet.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvChinhSachCTiet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NganhHang,
            this.IdChiTiet,
            this.IdBangGia,
            this.csIdDKMua,
            this.csIdSPKem,
            this.IdSanPham,
            this.MaSanPham,
            this.TenSanPham,
            this.DonViTinh,
            this.LoaiSanPham,
            this.DonGiaCoVAT,
            this.GiaBanBuon,
            this.GiaBanDemo,
            this.gridColumn1,
            this.DonGiaChuaVAT,
            this.gridColumn2,
            this.gridColumn3,
            this.TyLeVAT,
            this.TienVAT,
            this.GiaNhapHDCuoi,
            this.GiaNhapDemoCuoi,
            this.GiaTonKhoBQ,
            this.TienChietKhauQK,
            this.TienKhuyenMai,
            this.TyLeLNBQ,
            this.DungSaiMin,
            this.DungSaiMax,
            this.GiaMin,
            this.GiaMax,
            this.GiaBanAnToan,
            this.SoLuongBanBQ,
            this.DungSaiSLBQ,
            this.ThuongNong,
            this.TyLeThuong,
            this.LoiNhuan,
            this.LoiNhuanTon,
            this.LoiNhuanBB,
            this.LoiNhuanTonBB,
            this.LoiNhuanDemo,
            this.NguoiCapNhat});
            this.gvChinhSachCTiet.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvChinhSachCTiet.GridControl = this.gChinhSachCTiet;
            this.gvChinhSachCTiet.GroupCount = 1;
            this.gvChinhSachCTiet.Name = "gvChinhSachCTiet";
            this.gvChinhSachCTiet.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvChinhSachCTiet.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvChinhSachCTiet.OptionsSelection.InvertSelection = true;
            this.gvChinhSachCTiet.OptionsSelection.MultiSelect = true;
            this.gvChinhSachCTiet.OptionsView.ColumnAutoWidth = false;
            this.gvChinhSachCTiet.OptionsView.ShowAutoFilterRow = true;
            this.gvChinhSachCTiet.OptionsView.ShowDetailButtons = false;
            this.gvChinhSachCTiet.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.NganhHang, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // NganhHang
            // 
            this.NganhHang.Caption = "Ngành hàng";
            this.NganhHang.FieldName = "NganhHang";
            this.NganhHang.Name = "NganhHang";
            this.NganhHang.OptionsColumn.AllowEdit = false;
            this.NganhHang.OptionsColumn.ReadOnly = true;
            // 
            // IdChiTiet
            // 
            this.IdChiTiet.Caption = "IdChiTiet";
            this.IdChiTiet.FieldName = "IdChiTiet";
            this.IdChiTiet.Name = "IdChiTiet";
            this.IdChiTiet.OptionsColumn.AllowEdit = false;
            this.IdChiTiet.OptionsColumn.AllowFocus = false;
            this.IdChiTiet.OptionsColumn.AllowMove = false;
            this.IdChiTiet.OptionsColumn.ReadOnly = true;
            this.IdChiTiet.Width = 115;
            // 
            // IdBangGia
            // 
            this.IdBangGia.Caption = "IdBangGia";
            this.IdBangGia.FieldName = "IdChinhSach";
            this.IdBangGia.Name = "IdBangGia";
            this.IdBangGia.OptionsColumn.AllowEdit = false;
            this.IdBangGia.OptionsColumn.AllowFocus = false;
            this.IdBangGia.OptionsColumn.AllowMove = false;
            this.IdBangGia.OptionsColumn.ReadOnly = true;
            this.IdBangGia.Width = 234;
            // 
            // csIdDKMua
            // 
            this.csIdDKMua.Caption = "IdDKMua";
            this.csIdDKMua.FieldName = "IdDKMua";
            this.csIdDKMua.Name = "csIdDKMua";
            // 
            // csIdSPKem
            // 
            this.csIdSPKem.Caption = "IdSPKem";
            this.csIdSPKem.FieldName = "IdSPKem";
            this.csIdSPKem.Name = "csIdSPKem";
            // 
            // IdSanPham
            // 
            this.IdSanPham.Caption = "IdSanPham";
            this.IdSanPham.FieldName = "IdSanPham";
            this.IdSanPham.Name = "IdSanPham";
            this.IdSanPham.Width = 89;
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
            this.MaSanPham.Width = 114;
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
            this.TenSanPham.Width = 261;
            // 
            // DonViTinh
            // 
            this.DonViTinh.Caption = "ĐVT";
            this.DonViTinh.FieldName = "DonViTinh";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.OptionsColumn.AllowEdit = false;
            this.DonViTinh.Width = 72;
            // 
            // LoaiSanPham
            // 
            this.LoaiSanPham.Caption = "Loại sản phẩm ảnh hưởng";
            this.LoaiSanPham.FieldName = "LoaiSanPham";
            this.LoaiSanPham.Name = "LoaiSanPham";
            this.LoaiSanPham.Visible = true;
            this.LoaiSanPham.VisibleIndex = 2;
            this.LoaiSanPham.Width = 178;
            // 
            // DonGiaCoVAT
            // 
            this.DonGiaCoVAT.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.DonGiaCoVAT.AppearanceCell.Options.UseBackColor = true;
            this.DonGiaCoVAT.Caption = "Giá bán có VAT";
            this.DonGiaCoVAT.DisplayFormat.FormatString = "N0";
            this.DonGiaCoVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DonGiaCoVAT.FieldName = "DonGiaCoVAT";
            this.DonGiaCoVAT.Name = "DonGiaCoVAT";
            this.DonGiaCoVAT.Visible = true;
            this.DonGiaCoVAT.VisibleIndex = 3;
            this.DonGiaCoVAT.Width = 99;
            // 
            // GiaBanBuon
            // 
            this.GiaBanBuon.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.GiaBanBuon.AppearanceCell.Options.UseBackColor = true;
            this.GiaBanBuon.Caption = "Giá bán buôn";
            this.GiaBanBuon.DisplayFormat.FormatString = "N0";
            this.GiaBanBuon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaBanBuon.FieldName = "GiaBanBuon";
            this.GiaBanBuon.Name = "GiaBanBuon";
            this.GiaBanBuon.Visible = true;
            this.GiaBanBuon.VisibleIndex = 4;
            this.GiaBanBuon.Width = 125;
            // 
            // GiaBanDemo
            // 
            this.GiaBanDemo.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.GiaBanDemo.AppearanceCell.Options.UseBackColor = true;
            this.GiaBanDemo.Caption = "Giá bán Demo";
            this.GiaBanDemo.DisplayFormat.FormatString = "N0";
            this.GiaBanDemo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaBanDemo.FieldName = "GiaBanDemo";
            this.GiaBanDemo.Name = "GiaBanDemo";
            this.GiaBanDemo.Visible = true;
            this.GiaBanDemo.VisibleIndex = 5;
            this.GiaBanDemo.Width = 111;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.gridColumn1.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn1.Caption = "Khuyến mại website";
            this.gridColumn1.ColumnEdit = this.repKhuyenMai;
            this.gridColumn1.FieldName = "KhuyenMai";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 238;
            // 
            // repKhuyenMai
            // 
            this.repKhuyenMai.Name = "repKhuyenMai";
            // 
            // DonGiaChuaVAT
            // 
            this.DonGiaChuaVAT.Caption = "Giá bán chưa VAT";
            this.DonGiaChuaVAT.DisplayFormat.FormatString = "N0";
            this.DonGiaChuaVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DonGiaChuaVAT.FieldName = "DonGiaChuaVAT";
            this.DonGiaChuaVAT.Name = "DonGiaChuaVAT";
            this.DonGiaChuaVAT.OptionsColumn.AllowEdit = false;
            this.DonGiaChuaVAT.Visible = true;
            this.DonGiaChuaVAT.VisibleIndex = 6;
            this.DonGiaChuaVAT.Width = 109;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tỷ lệ chiết khấu";
            this.gridColumn2.DisplayFormat.FormatString = "N0";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn2.FieldName = "TyLeChietKhau";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Width = 106;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tiền chiết khấu";
            this.gridColumn3.DisplayFormat.FormatString = "N0";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn3.FieldName = "TienChietKhau";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Width = 105;
            // 
            // TyLeVAT
            // 
            this.TyLeVAT.Caption = "Tỷ lệ VAT";
            this.TyLeVAT.DisplayFormat.FormatString = "N0";
            this.TyLeVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyLeVAT.FieldName = "TyLeVAT";
            this.TyLeVAT.Name = "TyLeVAT";
            this.TyLeVAT.OptionsColumn.AllowEdit = false;
            this.TyLeVAT.Visible = true;
            this.TyLeVAT.VisibleIndex = 7;
            this.TyLeVAT.Width = 80;
            // 
            // TienVAT
            // 
            this.TienVAT.Caption = "Tiền VAT";
            this.TienVAT.DisplayFormat.FormatString = "N0";
            this.TienVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TienVAT.FieldName = "TienVAT";
            this.TienVAT.Name = "TienVAT";
            this.TienVAT.OptionsColumn.AllowEdit = false;
            this.TienVAT.Visible = true;
            this.TienVAT.VisibleIndex = 8;
            // 
            // GiaNhapHDCuoi
            // 
            this.GiaNhapHDCuoi.Caption = "Giá nhập HĐ cuối";
            this.GiaNhapHDCuoi.DisplayFormat.FormatString = "N0";
            this.GiaNhapHDCuoi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaNhapHDCuoi.FieldName = "GiaNhapHDCuoi";
            this.GiaNhapHDCuoi.Name = "GiaNhapHDCuoi";
            this.GiaNhapHDCuoi.OptionsColumn.AllowEdit = false;
            this.GiaNhapHDCuoi.Visible = true;
            this.GiaNhapHDCuoi.VisibleIndex = 9;
            this.GiaNhapHDCuoi.Width = 122;
            // 
            // GiaNhapDemoCuoi
            // 
            this.GiaNhapDemoCuoi.Caption = "Giá nhập Demo cuối";
            this.GiaNhapDemoCuoi.DisplayFormat.FormatString = "N0";
            this.GiaNhapDemoCuoi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaNhapDemoCuoi.FieldName = "GiaNhapDemoCuoi";
            this.GiaNhapDemoCuoi.Name = "GiaNhapDemoCuoi";
            this.GiaNhapDemoCuoi.OptionsColumn.AllowEdit = false;
            this.GiaNhapDemoCuoi.Visible = true;
            this.GiaNhapDemoCuoi.VisibleIndex = 10;
            this.GiaNhapDemoCuoi.Width = 124;
            // 
            // GiaTonKhoBQ
            // 
            this.GiaTonKhoBQ.Caption = "Giá tồn kho BQ";
            this.GiaTonKhoBQ.DisplayFormat.FormatString = "N0";
            this.GiaTonKhoBQ.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaTonKhoBQ.FieldName = "GiaTonKhoBQ";
            this.GiaTonKhoBQ.Name = "GiaTonKhoBQ";
            this.GiaTonKhoBQ.OptionsColumn.AllowEdit = false;
            this.GiaTonKhoBQ.Visible = true;
            this.GiaTonKhoBQ.VisibleIndex = 11;
            this.GiaTonKhoBQ.Width = 111;
            // 
            // TienChietKhauQK
            // 
            this.TienChietKhauQK.Caption = "Tiền chiết khấu QK";
            this.TienChietKhauQK.DisplayFormat.FormatString = "N0";
            this.TienChietKhauQK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TienChietKhauQK.FieldName = "TienChietKhauQK";
            this.TienChietKhauQK.Name = "TienChietKhauQK";
            this.TienChietKhauQK.OptionsColumn.AllowEdit = false;
            this.TienChietKhauQK.Visible = true;
            this.TienChietKhauQK.VisibleIndex = 12;
            this.TienChietKhauQK.Width = 115;
            // 
            // TienKhuyenMai
            // 
            this.TienKhuyenMai.Caption = "Tiền khuyến mại";
            this.TienKhuyenMai.DisplayFormat.FormatString = "N0";
            this.TienKhuyenMai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TienKhuyenMai.FieldName = "TienKhuyenMai";
            this.TienKhuyenMai.Name = "TienKhuyenMai";
            this.TienKhuyenMai.OptionsColumn.AllowEdit = false;
            this.TienKhuyenMai.Visible = true;
            this.TienKhuyenMai.VisibleIndex = 13;
            this.TienKhuyenMai.Width = 109;
            // 
            // TyLeLNBQ
            // 
            this.TyLeLNBQ.Caption = "Tỷ lệ LNBQ";
            this.TyLeLNBQ.DisplayFormat.FormatString = "N2";
            this.TyLeLNBQ.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyLeLNBQ.FieldName = "TyLeLNBQ";
            this.TyLeLNBQ.Name = "TyLeLNBQ";
            this.TyLeLNBQ.OptionsColumn.AllowEdit = false;
            this.TyLeLNBQ.Visible = true;
            this.TyLeLNBQ.VisibleIndex = 14;
            this.TyLeLNBQ.Width = 88;
            // 
            // DungSaiMin
            // 
            this.DungSaiMin.Caption = "Dung sai MIN";
            this.DungSaiMin.DisplayFormat.FormatString = "N0";
            this.DungSaiMin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DungSaiMin.FieldName = "DungSaiMin";
            this.DungSaiMin.Name = "DungSaiMin";
            this.DungSaiMin.OptionsColumn.AllowEdit = false;
            this.DungSaiMin.Visible = true;
            this.DungSaiMin.VisibleIndex = 15;
            this.DungSaiMin.Width = 89;
            // 
            // DungSaiMax
            // 
            this.DungSaiMax.Caption = "Dung sai MAX";
            this.DungSaiMax.DisplayFormat.FormatString = "N0";
            this.DungSaiMax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DungSaiMax.FieldName = "DungSaiMax";
            this.DungSaiMax.Name = "DungSaiMax";
            this.DungSaiMax.OptionsColumn.AllowEdit = false;
            this.DungSaiMax.Visible = true;
            this.DungSaiMax.VisibleIndex = 16;
            this.DungSaiMax.Width = 88;
            // 
            // GiaMin
            // 
            this.GiaMin.Caption = "Giá MIN";
            this.GiaMin.DisplayFormat.FormatString = "N0";
            this.GiaMin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaMin.FieldName = "GiaMin";
            this.GiaMin.Name = "GiaMin";
            this.GiaMin.OptionsColumn.AllowEdit = false;
            this.GiaMin.Visible = true;
            this.GiaMin.VisibleIndex = 17;
            // 
            // GiaMax
            // 
            this.GiaMax.Caption = "Giá MAX";
            this.GiaMax.DisplayFormat.FormatString = "N0";
            this.GiaMax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaMax.FieldName = "GiaMax";
            this.GiaMax.Name = "GiaMax";
            this.GiaMax.OptionsColumn.AllowEdit = false;
            this.GiaMax.Visible = true;
            this.GiaMax.VisibleIndex = 18;
            this.GiaMax.Width = 82;
            // 
            // GiaBanAnToan
            // 
            this.GiaBanAnToan.Caption = "Giá bán an toàn";
            this.GiaBanAnToan.DisplayFormat.FormatString = "N0";
            this.GiaBanAnToan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaBanAnToan.FieldName = "GiaBanAnToan";
            this.GiaBanAnToan.Name = "GiaBanAnToan";
            this.GiaBanAnToan.OptionsColumn.AllowEdit = false;
            this.GiaBanAnToan.Visible = true;
            this.GiaBanAnToan.VisibleIndex = 19;
            this.GiaBanAnToan.Width = 109;
            // 
            // SoLuongBanBQ
            // 
            this.SoLuongBanBQ.Caption = "Số lượng bán BQ";
            this.SoLuongBanBQ.DisplayFormat.FormatString = "N2";
            this.SoLuongBanBQ.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SoLuongBanBQ.FieldName = "SoLuongBanBQ";
            this.SoLuongBanBQ.Name = "SoLuongBanBQ";
            this.SoLuongBanBQ.OptionsColumn.AllowEdit = false;
            this.SoLuongBanBQ.Visible = true;
            this.SoLuongBanBQ.VisibleIndex = 20;
            this.SoLuongBanBQ.Width = 111;
            // 
            // DungSaiSLBQ
            // 
            this.DungSaiSLBQ.Caption = "Dung sai SLBQ";
            this.DungSaiSLBQ.DisplayFormat.FormatString = "N2";
            this.DungSaiSLBQ.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DungSaiSLBQ.FieldName = "DungSaiSLBQ";
            this.DungSaiSLBQ.Name = "DungSaiSLBQ";
            this.DungSaiSLBQ.OptionsColumn.AllowEdit = false;
            this.DungSaiSLBQ.Visible = true;
            this.DungSaiSLBQ.VisibleIndex = 21;
            this.DungSaiSLBQ.Width = 104;
            // 
            // ThuongNong
            // 
            this.ThuongNong.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.ThuongNong.AppearanceCell.Options.UseBackColor = true;
            this.ThuongNong.Caption = "Thưởng nóng";
            this.ThuongNong.DisplayFormat.FormatString = "N0";
            this.ThuongNong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ThuongNong.FieldName = "ThuongNong";
            this.ThuongNong.Name = "ThuongNong";
            this.ThuongNong.Visible = true;
            this.ThuongNong.VisibleIndex = 22;
            this.ThuongNong.Width = 85;
            // 
            // TyLeThuong
            // 
            this.TyLeThuong.Caption = "Tỷ lệ thưởng";
            this.TyLeThuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyLeThuong.FieldName = "TyLeThuong";
            this.TyLeThuong.Name = "TyLeThuong";
            this.TyLeThuong.OptionsColumn.AllowEdit = false;
            this.TyLeThuong.Width = 95;
            // 
            // LoiNhuan
            // 
            this.LoiNhuan.Caption = "Lợi nhuận";
            this.LoiNhuan.DisplayFormat.FormatString = "N0";
            this.LoiNhuan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.LoiNhuan.FieldName = "LoiNhuan";
            this.LoiNhuan.Name = "LoiNhuan";
            this.LoiNhuan.OptionsColumn.AllowEdit = false;
            this.LoiNhuan.Visible = true;
            this.LoiNhuan.VisibleIndex = 23;
            this.LoiNhuan.Width = 99;
            // 
            // LoiNhuanTon
            // 
            this.LoiNhuanTon.Caption = "Lợi nhuận tồn BQ";
            this.LoiNhuanTon.DisplayFormat.FormatString = "N0";
            this.LoiNhuanTon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.LoiNhuanTon.FieldName = "LoiNhuanTon";
            this.LoiNhuanTon.Name = "LoiNhuanTon";
            this.LoiNhuanTon.OptionsColumn.AllowEdit = false;
            this.LoiNhuanTon.Visible = true;
            this.LoiNhuanTon.VisibleIndex = 24;
            this.LoiNhuanTon.Width = 103;
            // 
            // LoiNhuanBB
            // 
            this.LoiNhuanBB.Caption = "Lợi nhuận BB";
            this.LoiNhuanBB.DisplayFormat.FormatString = "N0";
            this.LoiNhuanBB.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.LoiNhuanBB.FieldName = "LoiNhuanBB";
            this.LoiNhuanBB.Name = "LoiNhuanBB";
            this.LoiNhuanBB.OptionsColumn.AllowEdit = false;
            this.LoiNhuanBB.Visible = true;
            this.LoiNhuanBB.VisibleIndex = 25;
            this.LoiNhuanBB.Width = 120;
            // 
            // LoiNhuanTonBB
            // 
            this.LoiNhuanTonBB.Caption = "Lợi nhuận tồn BB";
            this.LoiNhuanTonBB.DisplayFormat.FormatString = "N0";
            this.LoiNhuanTonBB.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.LoiNhuanTonBB.FieldName = "LoiNhuanTonBB";
            this.LoiNhuanTonBB.Name = "LoiNhuanTonBB";
            this.LoiNhuanTonBB.OptionsColumn.AllowEdit = false;
            this.LoiNhuanTonBB.Visible = true;
            this.LoiNhuanTonBB.VisibleIndex = 26;
            this.LoiNhuanTonBB.Width = 99;
            // 
            // LoiNhuanDemo
            // 
            this.LoiNhuanDemo.Caption = "Lợi nhuận Demo";
            this.LoiNhuanDemo.DisplayFormat.FormatString = "N0";
            this.LoiNhuanDemo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.LoiNhuanDemo.FieldName = "LoiNhuanDemo";
            this.LoiNhuanDemo.Name = "LoiNhuanDemo";
            this.LoiNhuanDemo.OptionsColumn.AllowEdit = false;
            this.LoiNhuanDemo.Visible = true;
            this.LoiNhuanDemo.VisibleIndex = 27;
            this.LoiNhuanDemo.Width = 99;
            // 
            // NguoiCapNhat
            // 
            this.NguoiCapNhat.Caption = "Người cập nhật";
            this.NguoiCapNhat.FieldName = "NguoiCapNhat";
            this.NguoiCapNhat.Name = "NguoiCapNhat";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.gChinhSachCTiet;
            this.gridView4.Name = "gridView4";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkApDungMacDinh);
            this.groupBox1.Controls.Add(this.cboMacDinh);
            this.groupBox1.Controls.Add(this.chkOnline);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSoChinhSachGia);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTrangThai);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.mstNgayLap);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtNguoiLap);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.nudDoUuTien);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.chkDaDuyet);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(470, 204);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // chkApDungMacDinh
            // 
            this.chkApDungMacDinh.AutoSize = true;
            this.chkApDungMacDinh.Location = new System.Drawing.Point(239, 95);
            this.chkApDungMacDinh.Name = "chkApDungMacDinh";
            this.chkApDungMacDinh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkApDungMacDinh.Size = new System.Drawing.Size(193, 17);
            this.chkApDungMacDinh.TabIndex = 96;
            this.chkApDungMacDinh.Text = "Có kết hợp với chính sách mặc định";
            this.chkApDungMacDinh.UseVisualStyleBackColor = true;
            // 
            // cboMacDinh
            // 
            this.cboMacDinh.AutoCompleteCustomSource.AddRange(new string[] {
            "Nhận hàng tại siêu thị",
            "Giao hàng tại nhà"});
            this.cboMacDinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMacDinh.Enabled = false;
            this.cboMacDinh.FormattingEnabled = true;
            this.cboMacDinh.Items.AddRange(new object[] {
            "Chính sách thông thường",
            "Chính sách áp dụng mặc định",
            "Chính sách chiết khấu theo đơn hàng"});
            this.cboMacDinh.Location = new System.Drawing.Point(239, 67);
            this.cboMacDinh.Name = "cboMacDinh";
            this.cboMacDinh.Size = new System.Drawing.Size(221, 21);
            this.cboMacDinh.TabIndex = 95;
            // 
            // chkOnline
            // 
            this.chkOnline.AutoSize = true;
            this.chkOnline.Enabled = false;
            this.chkOnline.Location = new System.Drawing.Point(199, 45);
            this.chkOnline.Name = "chkOnline";
            this.chkOnline.Size = new System.Drawing.Size(116, 17);
            this.chkOnline.TabIndex = 2;
            this.chkOnline.Text = "Chỉ áp dụng Online";
            this.chkOnline.UseVisualStyleBackColor = true;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(88, 117);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(372, 83);
            this.txtGhiChu.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ghi chú";
            // 
            // txtSoChinhSachGia
            // 
            this.txtSoChinhSachGia.Location = new System.Drawing.Point(88, 17);
            this.txtSoChinhSachGia.Multiline = true;
            this.txtSoChinhSachGia.Name = "txtSoChinhSachGia";
            this.txtSoChinhSachGia.Size = new System.Drawing.Size(372, 21);
            this.txtSoChinhSachGia.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 87;
            this.label10.Text = "Số chính sách";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(88, 67);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.ReadOnly = true;
            this.txtTrangThai.Size = new System.Drawing.Size(145, 21);
            this.txtTrangThai.TabIndex = 5;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(26, 70);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 13);
            this.label23.TabIndex = 94;
            this.label23.Text = "Trạng thái";
            // 
            // mstNgayLap
            // 
            this.mstNgayLap.CustomFormat = "dd/MM/yyyy";
            this.mstNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mstNgayLap.Location = new System.Drawing.Point(88, 42);
            this.mstNgayLap.Name = "mstNgayLap";
            this.mstNgayLap.Size = new System.Drawing.Size(97, 21);
            this.mstNgayLap.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 83;
            this.label13.Text = "Ngày lập";
            // 
            // txtNguoiLap
            // 
            this.txtNguoiLap.Location = new System.Drawing.Point(88, 92);
            this.txtNguoiLap.Name = "txtNguoiLap";
            this.txtNguoiLap.Size = new System.Drawing.Size(145, 21);
            this.txtNguoiLap.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 81;
            this.label14.Text = "Người lập";
            // 
            // nudDoUuTien
            // 
            this.nudDoUuTien.Location = new System.Drawing.Point(420, 43);
            this.nudDoUuTien.Name = "nudDoUuTien";
            this.nudDoUuTien.Size = new System.Drawing.Size(40, 21);
            this.nudDoUuTien.TabIndex = 3;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(335, 48);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(77, 13);
            this.label25.TabIndex = 88;
            this.label25.Text = "Thứ tự ưu tiên";
            // 
            // chkDaDuyet
            // 
            this.chkDaDuyet.AutoSize = true;
            this.chkDaDuyet.Enabled = false;
            this.chkDaDuyet.Location = new System.Drawing.Point(6, 167);
            this.chkDaDuyet.Name = "chkDaDuyet";
            this.chkDaDuyet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkDaDuyet.Size = new System.Drawing.Size(71, 17);
            this.chkDaDuyet.TabIndex = 92;
            this.chkDaDuyet.Text = "Đã duyệt";
            this.chkDaDuyet.UseVisualStyleBackColor = true;
            this.chkDaDuyet.Visible = false;
            // 
            // frmCS_DuyetChinhSachKMai
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 531);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.tabChinhSach);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label9);
            this.KeyPreview = true;
            this.Name = "frmCS_DuyetChinhSachKMai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duyệt chính sách khuyến mại";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_BangGia_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_BangGia_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabChinhSach.ResumeLayout(false);
            this.tabSieuThiAD.ResumeLayout(false);
            this.tabSieuThiAD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSieuThiAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSieuThiAD)).EndInit();
            this.tabKhachHangAD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gDoiTuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDoiTuong)).EndInit();
            this.tabThoiGianAD.ResumeLayout(false);
            this.tabThoiGianAD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gThoiGianAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThoiGianAD)).EndInit();
            this.tabThanhToan.ResumeLayout(false);
            this.tabThanhToan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gThanhToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThanhToan)).EndInit();
            this.tabDKKhac.ResumeLayout(false);
            this.tabDKKhac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repMemoEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtabListApDung.ResumeLayout(false);
            this.xtabListNotApDung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gDanhSachKhongAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachKhongAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.xtabListTongHop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gChinhSachCTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChinhSachCTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repKhuyenMai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDoUuTien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker mstHanHieuLuc;
        private System.Windows.Forms.DateTimePicker mstNgayHieuLuc;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDong;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.CheckBox chkVoHan;
        private System.Windows.Forms.TabControl tabChinhSach;
        private System.Windows.Forms.TabPage tabThoiGianAD;
        private System.Windows.Forms.TabPage tabDKKhac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkDuyNhatSDT;
        private System.Windows.Forms.CheckBox chkDuyNhatCMND;
        private GtidTextBox txtGiaTriHDToiThieu;
        private System.Windows.Forms.Label label19;
        private GtidTextBox txtTuoiDen;
        private System.Windows.Forms.Label label18;
        private GtidTextBox txtTuoiTu;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ComboBox cboHuyen;
        private System.Windows.Forms.ComboBox cboTinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboNgheNghiep;
        private System.Windows.Forms.ComboBox cboGiaoHang;
        private System.Windows.Forms.Label label5;
        private GtidTextBox txtGiaTriDHDaMua;
        private System.Windows.Forms.Label label7;
        private GtidTextBox txtThoiHanMua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabSieuThiAD;
        private System.Windows.Forms.TabPage tabKhachHangAD;
        private System.Windows.Forms.TabPage tabThanhToan;
        private DevExpress.XtraGrid.GridControl gSieuThiAD;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSieuThiAD;
        private DevExpress.XtraGrid.Columns.GridColumn IdChinhSachST;
        private DevExpress.XtraGrid.Columns.GridColumn IdTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn MaTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn TenTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn MaKho;
        private DevExpress.XtraGrid.Columns.GridColumn TenKho;
        private DevExpress.XtraGrid.Columns.GridColumn IdKho;
        private DevExpress.XtraGrid.GridControl gDoiTuong;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDoiTuong;
        private DevExpress.XtraGrid.Columns.GridColumn IdChinhSachKH;
        private DevExpress.XtraGrid.Columns.GridColumn IdLoaiDT;
        private DevExpress.XtraGrid.Columns.GridColumn MaLoaiDT;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoaiDT;
        private DevExpress.XtraGrid.GridControl gThoiGianAD;
        private DevExpress.XtraGrid.Views.Grid.GridView gvThoiGianAD;
        private DevExpress.XtraGrid.Columns.GridColumn IdChinhSachTG;
        private DevExpress.XtraGrid.Columns.GridColumn Thu;
        private DevExpress.XtraGrid.Columns.GridColumn Ngay;
        private DevExpress.XtraGrid.Columns.GridColumn GioTu;
        private DevExpress.XtraGrid.Columns.GridColumn GioDen;
        private GtidTextBox txtSoKhachDauNgay;
        private System.Windows.Forms.Label label15;
        private DevExpress.XtraGrid.Columns.GridColumn DayOfWeek;
        private GtidTextBox txtNgayDuyet;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DevExpress.XtraGrid.Columns.GridColumn DayOfMonth;
        private System.Windows.Forms.ToolStripButton btnStop;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongDonHang;
        private DevExpress.XtraGrid.GridControl gSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn IdDKMua;
        private DevExpress.XtraGrid.Columns.GridColumn IdChinhSachDK;
        private DevExpress.XtraGrid.Columns.GridColumn IdHangMua;
        private DevExpress.XtraGrid.Columns.GridColumn MaHangMua;
        private DevExpress.XtraGrid.Columns.GridColumn TenHangMua;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiHangMua;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoaiHangMua;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongDuocMua;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongPhaiMua;
        private DevExpress.XtraGrid.Columns.GridColumn SanPhamKem;
        private DevExpress.XtraGrid.Columns.GridColumn SanPhamKemMa;
        private DevExpress.XtraGrid.Columns.GridColumn KhuyenMaiMa;
        private DevExpress.XtraGrid.Columns.GridColumn KhuyenMai;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn TenHangSX;
        private DevExpress.XtraGrid.Columns.GridColumn MaHangSX;
        private DevExpress.XtraGrid.Columns.GridColumn GiaMuaTu;
        private DevExpress.XtraGrid.Columns.GridColumn GiaMuaDen;
        private DevExpress.XtraGrid.Columns.GridColumn TyLePhanBo;
        private System.Windows.Forms.ToolStripButton btnTimKiem;
        private DevExpress.XtraGrid.Columns.GridColumn IdDoiTuong;
        private DevExpress.XtraGrid.Columns.GridColumn MaDoiTuong;
        private DevExpress.XtraGrid.Columns.GridColumn TenDoiTuong;
        private DevExpress.XtraGrid.Columns.GridColumn SanPhamDaMua;
        private System.Windows.Forms.Label label24;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongToiDaDH;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeChietKhau;
        private DevExpress.XtraGrid.Columns.GridColumn TienChietKhau;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repMemoEdit;
        private DevExpress.XtraGrid.Columns.GridColumn KhuyenMaiWeb;
        private GtidTextBox txtSoTienTToanTThieu;
        private DevExpress.XtraGrid.GridControl gThanhToan;
        private DevExpress.XtraGrid.Views.Grid.GridView gvThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn IdChinhSachTT;
        private DevExpress.XtraGrid.Columns.GridColumn IdHinhThucTT;
        private DevExpress.XtraGrid.Columns.GridColumn HinhThucThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn IdNganHang;
        private DevExpress.XtraGrid.Columns.GridColumn MaNganHang;
        private DevExpress.XtraGrid.Columns.GridColumn TenNganHang;
        private DevExpress.XtraGrid.Columns.GridColumn IdNganHangPH;
        private DevExpress.XtraGrid.Columns.GridColumn IdThoiHanTT;
        private DevExpress.XtraGrid.Columns.GridColumn MaNganHangPH;
        private DevExpress.XtraGrid.Columns.GridColumn NganHangPhatHanh;
        private DevExpress.XtraGrid.Columns.GridColumn ThoiHanThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeThanhToan;
        private GtidButton btnDelTT;
        private System.Windows.Forms.Label label1;
        private GtidButton btnAddTT;
        private System.Windows.Forms.Label label12;
        private GtidTextBox txtThanhToanToiThieu;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtabListApDung;
        private DevExpress.XtraTab.XtraTabPage xtabListNotApDung;
        private DevExpress.XtraGrid.GridControl gDanhSachKhongAD;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachKhongAD;
        private DevExpress.XtraGrid.Columns.GridColumn IdChinhSachNo;
        private DevExpress.XtraGrid.Columns.GridColumn IdSanPhamNo;
        private DevExpress.XtraGrid.Columns.GridColumn MaSanPhamNo;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPhamNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn GiaTriMuaToiThieu;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraGrid.Columns.GridColumn SanPhamNoAD;
        private DevExpress.XtraGrid.Columns.GridColumn SanPhamNoADMa;
        private DevExpress.XtraGrid.Columns.GridColumn SanPhamYesADMa;
        private DevExpress.XtraGrid.Columns.GridColumn SanPhamYesAD;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheck;
        private DevExpress.XtraGrid.Columns.GridColumn InHoaDon;
        private DevExpress.XtraTab.XtraTabPage xtabListTongHop;
        private DevExpress.XtraGrid.GridControl gChinhSachCTiet;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChinhSachCTiet;
        private DevExpress.XtraGrid.Columns.GridColumn NganhHang;
        private DevExpress.XtraGrid.Columns.GridColumn IdChiTiet;
        private DevExpress.XtraGrid.Columns.GridColumn IdBangGia;
        private DevExpress.XtraGrid.Columns.GridColumn IdSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn MaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn DonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn DonGiaCoVAT;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBanBuon;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBanDemo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repKhuyenMai;
        private DevExpress.XtraGrid.Columns.GridColumn DonGiaChuaVAT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeVAT;
        private DevExpress.XtraGrid.Columns.GridColumn TienVAT;
        private DevExpress.XtraGrid.Columns.GridColumn GiaNhapHDCuoi;
        private DevExpress.XtraGrid.Columns.GridColumn GiaNhapDemoCuoi;
        private DevExpress.XtraGrid.Columns.GridColumn GiaTonKhoBQ;
        private DevExpress.XtraGrid.Columns.GridColumn TienChietKhauQK;
        private DevExpress.XtraGrid.Columns.GridColumn TienKhuyenMai;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeLNBQ;
        private DevExpress.XtraGrid.Columns.GridColumn DungSaiMin;
        private DevExpress.XtraGrid.Columns.GridColumn DungSaiMax;
        private DevExpress.XtraGrid.Columns.GridColumn GiaMin;
        private DevExpress.XtraGrid.Columns.GridColumn GiaMax;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBanAnToan;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongBanBQ;
        private DevExpress.XtraGrid.Columns.GridColumn DungSaiSLBQ;
        private DevExpress.XtraGrid.Columns.GridColumn ThuongNong;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeThuong;
        private DevExpress.XtraGrid.Columns.GridColumn LoiNhuan;
        private DevExpress.XtraGrid.Columns.GridColumn LoiNhuanTon;
        private DevExpress.XtraGrid.Columns.GridColumn LoiNhuanBB;
        private DevExpress.XtraGrid.Columns.GridColumn LoiNhuanTonBB;
        private DevExpress.XtraGrid.Columns.GridColumn LoiNhuanDemo;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiCapNhat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn csIdDKMua;
        private DevExpress.XtraGrid.Columns.GridColumn csIdSPKem;
        private GtidButton btnDeleteST;
        private GtidButton btnAddST;
        private GtidButton btnDelKH;
        private GtidButton btnAddKH;
        private GtidButton btnDelTG;
        private GtidButton btnAddTG;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeDiemThuong;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongToiDaCK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkApDungMacDinh;
        private System.Windows.Forms.ComboBox cboMacDinh;
        private System.Windows.Forms.CheckBox chkOnline;
        private GtidTextBox txtGhiChu;
        private System.Windows.Forms.Label label6;
        private GtidTextBox txtSoChinhSachGia;
        private System.Windows.Forms.Label label10;
        private GtidTextBox txtTrangThai;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker mstNgayLap;
        private System.Windows.Forms.Label label13;
        private GtidTextBox txtNguoiLap;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudDoUuTien;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.CheckBox chkDaDuyet;
        private DevExpress.XtraGrid.Columns.GridColumn MaVachApDung;
        private DevExpress.XtraGrid.Columns.GridColumn SoDiemThuong;
    }
}
