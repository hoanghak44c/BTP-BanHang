using QLBH.Core.Form;
namespace QLBanHang.Modules.BanHang
{
    partial class frmBC_DonHangChiTiet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBC_DonHangChiTiet));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bteNganh = new DevExpress.XtraEditors.ButtonEdit();
            this.btnExportAll = new QLBH.Core.Form.GtidButton();
            this.cmdExport = new QLBH.Core.Form.GtidButton();
            this.btnDong = new QLBH.Core.Form.GtidButton();
            this.btnTim = new QLBH.Core.Form.GtidButton();
            this.dteEnd = new DevExpress.XtraEditors.DateEdit();
            this.dteStart = new DevExpress.XtraEditors.DateEdit();
            this.lblEnd = new DevExpress.XtraEditors.LabelControl();
            this.lblStart = new DevExpress.XtraEditors.LabelControl();
            this.lueTrangThaiDH = new DevExpress.XtraEditors.LookUpEdit();
            this.lblTrangThaiDH = new DevExpress.XtraEditors.LabelControl();
            this.lueLoaiDH = new DevExpress.XtraEditors.LookUpEdit();
            this.lblTrangThaiLinhKien = new DevExpress.XtraEditors.LabelControl();
            this.cboLoaiMaHang = new System.Windows.Forms.ComboBox();
            this.bteKhoXuat = new DevExpress.XtraEditors.ButtonEdit();
            this.bteTrungTam = new DevExpress.XtraEditors.ButtonEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNhanVien = new QLBH.Core.Form.GtidTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoGiaoDich = new QLBH.Core.Form.GtidTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblThuocXuat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTenKhachHang = new QLBH.Core.Form.GtidTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.grpKetQuaTimKiem = new System.Windows.Forms.GroupBox();
            this.gListChungTu = new DevExpress.XtraGrid.GridControl();
            this.gvListChungTu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNgayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoGiaoDich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiDonHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoChungTuGoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoPhieuXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLyDoTraHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdLyDoGiaoDich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colTenNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaDoiTuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDoiTuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaTheoBangGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTyleChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienSauChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyleVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoDiemThuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeDiemThuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLeDiemThuongMacDinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyleThuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThuongNong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaNiemYet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaWebSite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPhamBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ListSoChinhSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrungMaVach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoKhuyenMai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.XoaNoKM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyLePhanBo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CungDongDonHangChinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoaiHangKem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LinhVuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinhHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuanHuyenHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinhGH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuanHuyenGH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgheNghiep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebSite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLoaiDonHang = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repTrangThaiDH = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslHuyClr = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslHuy = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTuChoiClr = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTuChoi = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsbChinhSachGia = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteNganh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTrangThaiDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLoaiDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhoXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).BeginInit();
            this.grpKetQuaTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gListChungTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListChungTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrangThaiDH)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.ctxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bteNganh);
            this.groupBox1.Controls.Add(this.btnExportAll);
            this.groupBox1.Controls.Add(this.cmdExport);
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.dteEnd);
            this.groupBox1.Controls.Add(this.dteStart);
            this.groupBox1.Controls.Add(this.lblEnd);
            this.groupBox1.Controls.Add(this.lblStart);
            this.groupBox1.Controls.Add(this.lueTrangThaiDH);
            this.groupBox1.Controls.Add(this.lblTrangThaiDH);
            this.groupBox1.Controls.Add(this.lueLoaiDH);
            this.groupBox1.Controls.Add(this.lblTrangThaiLinhKien);
            this.groupBox1.Controls.Add(this.cboLoaiMaHang);
            this.groupBox1.Controls.Add(this.bteKhoXuat);
            this.groupBox1.Controls.Add(this.bteTrungTam);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNhanVien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSoGiaoDich);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblThuocXuat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtHoTenKhachHang);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // bteNganh
            // 
            this.bteNganh.Location = new System.Drawing.Point(203, 96);
            this.bteNganh.Name = "bteNganh";
            this.bteNganh.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.bteNganh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteNganh.Properties.Appearance.Options.UseBackColor = true;
            this.bteNganh.Properties.Appearance.Options.UseFont = true;
            this.bteNganh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteNganh.Size = new System.Drawing.Size(242, 21);
            this.bteNganh.TabIndex = 154;
            this.bteNganh.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteNganh_ButtonClick);
            this.bteNganh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteNganh_KeyDown);
            this.bteNganh.TextChanged += new System.EventHandler(this.bteNganh_TextChanged);
            // 
            // btnExportAll
            // 
            this.btnExportAll.Enabled = false;
            this.btnExportAll.Image = ((System.Drawing.Image)(resources.GetObject("btnExportAll.Image")));
            this.btnExportAll.Location = new System.Drawing.Point(886, 16);
            this.btnExportAll.Name = "btnExportAll";
            this.btnExportAll.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnExportAll.Size = new System.Drawing.Size(101, 25);
            this.btnExportAll.TabIndex = 146;
            this.btnExportAll.Text = "Export All (F7)";
            this.btnExportAll.Click += new System.EventHandler(this.btnExportAll_Click);
            // 
            // cmdExport
            // 
            this.cmdExport.Image = ((System.Drawing.Image)(resources.GetObject("cmdExport.Image")));
            this.cmdExport.Location = new System.Drawing.Point(886, 70);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.ShortCutKey = System.Windows.Forms.Keys.None;
            this.cmdExport.Size = new System.Drawing.Size(101, 25);
            this.cmdExport.TabIndex = 20;
            this.cmdExport.Text = "Export (F6)";
            this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(886, 97);
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
            this.btnTim.Location = new System.Drawing.Point(886, 43);
            this.btnTim.Name = "btnTim";
            this.btnTim.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnTim.Size = new System.Drawing.Size(101, 25);
            this.btnTim.TabIndex = 19;
            this.btnTim.Text = "&Tìm kiếm (F3)";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dteEnd
            // 
            this.dteEnd.EditValue = null;
            this.dteEnd.Location = new System.Drawing.Point(740, 17);
            this.dteEnd.Name = "dteEnd";
            this.dteEnd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dteEnd.Properties.Appearance.Options.UseFont = true;
            this.dteEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteEnd.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dteEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteEnd.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dteEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteEnd.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteEnd.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dteEnd.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteEnd.Size = new System.Drawing.Size(126, 20);
            this.dteEnd.TabIndex = 11;
            // 
            // dteStart
            // 
            this.dteStart.EditValue = null;
            this.dteStart.Location = new System.Drawing.Point(552, 17);
            this.dteStart.Name = "dteStart";
            this.dteStart.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dteStart.Properties.Appearance.Options.UseFont = true;
            this.dteStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteStart.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dteStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteStart.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dteStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteStart.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteStart.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dteStart.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteStart.Size = new System.Drawing.Size(116, 20);
            this.dteStart.TabIndex = 10;
            // 
            // lblEnd
            // 
            this.lblEnd.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEnd.Appearance.Options.UseFont = true;
            this.lblEnd.Location = new System.Drawing.Point(691, 21);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(45, 13);
            this.lblEnd.TabIndex = 145;
            this.lblEnd.Text = "đến ngày";
            // 
            // lblStart
            // 
            this.lblStart.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStart.Appearance.Options.UseFont = true;
            this.lblStart.Location = new System.Drawing.Point(503, 21);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(40, 13);
            this.lblStart.TabIndex = 144;
            this.lblStart.Text = "Từ ngày";
            // 
            // lueTrangThaiDH
            // 
            this.lueTrangThaiDH.Location = new System.Drawing.Point(552, 42);
            this.lueTrangThaiDH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lueTrangThaiDH.Name = "lueTrangThaiDH";
            this.lueTrangThaiDH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lueTrangThaiDH.Properties.Appearance.Options.UseFont = true;
            this.lueTrangThaiDH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTrangThaiDH.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.lueTrangThaiDH.Properties.DisplayMember = "Name";
            this.lueTrangThaiDH.Properties.NullText = "";
            this.lueTrangThaiDH.Properties.ShowFooter = false;
            this.lueTrangThaiDH.Properties.ShowHeader = false;
            this.lueTrangThaiDH.Properties.ValueMember = "Id";
            this.lueTrangThaiDH.Size = new System.Drawing.Size(314, 20);
            this.lueTrangThaiDH.TabIndex = 4;
            // 
            // lblTrangThaiDH
            // 
            this.lblTrangThaiDH.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTrangThaiDH.Appearance.Options.UseFont = true;
            this.lblTrangThaiDH.Location = new System.Drawing.Point(479, 45);
            this.lblTrangThaiDH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTrangThaiDH.Name = "lblTrangThaiDH";
            this.lblTrangThaiDH.Size = new System.Drawing.Size(67, 13);
            this.lblTrangThaiDH.TabIndex = 141;
            this.lblTrangThaiDH.Text = "Trạng thái ĐH";
            // 
            // lueLoaiDH
            // 
            this.lueLoaiDH.Location = new System.Drawing.Point(301, 17);
            this.lueLoaiDH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lueLoaiDH.Name = "lueLoaiDH";
            this.lueLoaiDH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lueLoaiDH.Properties.Appearance.Options.UseFont = true;
            this.lueLoaiDH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueLoaiDH.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.lueLoaiDH.Properties.DisplayMember = "Name";
            this.lueLoaiDH.Properties.NullText = "";
            this.lueLoaiDH.Properties.ShowFooter = false;
            this.lueLoaiDH.Properties.ShowHeader = false;
            this.lueLoaiDH.Properties.ValueMember = "Id";
            this.lueLoaiDH.Size = new System.Drawing.Size(144, 20);
            this.lueLoaiDH.TabIndex = 1;
            // 
            // lblTrangThaiLinhKien
            // 
            this.lblTrangThaiLinhKien.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTrangThaiLinhKien.Appearance.Options.UseFont = true;
            this.lblTrangThaiLinhKien.Location = new System.Drawing.Point(226, 20);
            this.lblTrangThaiLinhKien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTrangThaiLinhKien.Name = "lblTrangThaiLinhKien";
            this.lblTrangThaiLinhKien.Size = new System.Drawing.Size(67, 13);
            this.lblTrangThaiLinhKien.TabIndex = 139;
            this.lblTrangThaiLinhKien.Text = "Loại đơn hàng";
            // 
            // cboLoaiMaHang
            // 
            this.cboLoaiMaHang.AutoCompleteCustomSource.AddRange(new string[] {
            "Nhận hàng tại siêu thị",
            "Giao hàng tại nhà"});
            this.cboLoaiMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiMaHang.FormattingEnabled = true;
            this.cboLoaiMaHang.Items.AddRange(new object[] {
            "Lĩnh vực",
            "Ngành",
            "Loại",
            "Chủng",
            "Nhóm",
            "Model",
            "Sản phẩm"});
            this.cboLoaiMaHang.Location = new System.Drawing.Point(93, 96);
            this.cboLoaiMaHang.Name = "cboLoaiMaHang";
            this.cboLoaiMaHang.Size = new System.Drawing.Size(107, 21);
            this.cboLoaiMaHang.TabIndex = 7;
            // 
            // bteKhoXuat
            // 
            this.bteKhoXuat.Location = new System.Drawing.Point(93, 69);
            this.bteKhoXuat.Name = "bteKhoXuat";
            this.bteKhoXuat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteKhoXuat.Properties.Appearance.Options.UseFont = true;
            this.bteKhoXuat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteKhoXuat.Size = new System.Drawing.Size(352, 22);
            this.bteKhoXuat.TabIndex = 6;
            this.bteKhoXuat.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteKhoXuat_ButtonClick);
            this.bteKhoXuat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteKhoXuat_KeyDown);
            this.bteKhoXuat.TextChanged += new System.EventHandler(this.bteKhoXuat_TextChanged);
            // 
            // bteTrungTam
            // 
            this.bteTrungTam.Location = new System.Drawing.Point(93, 42);
            this.bteTrungTam.Name = "bteTrungTam";
            this.bteTrungTam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteTrungTam.Properties.Appearance.Options.UseFont = true;
            this.bteTrungTam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteTrungTam.Size = new System.Drawing.Size(352, 22);
            this.bteTrungTam.TabIndex = 5;
            this.bteTrungTam.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteTrungTam_ButtonClick);
            this.bteTrungTam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteTrungTam_KeyDown);
            this.bteTrungTam.TextChanged += new System.EventHandler(this.bteTrungTam_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 118;
            this.label7.Text = "Trung tâm";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanVien.Location = new System.Drawing.Point(552, 94);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(314, 20);
            this.txtNhanVien.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(490, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 115;
            this.label5.Text = "Nhân viên";
            // 
            // txtSoGiaoDich
            // 
            this.txtSoGiaoDich.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoGiaoDich.Location = new System.Drawing.Point(93, 17);
            this.txtSoGiaoDich.Name = "txtSoGiaoDich";
            this.txtSoGiaoDich.Size = new System.Drawing.Size(127, 20);
            this.txtSoGiaoDich.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "Số phiếu";
            // 
            // lblThuocXuat
            // 
            this.lblThuocXuat.AutoSize = true;
            this.lblThuocXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuocXuat.Location = new System.Drawing.Point(32, 100);
            this.lblThuocXuat.Name = "lblThuocXuat";
            this.lblThuocXuat.Size = new System.Drawing.Size(55, 13);
            this.lblThuocXuat.TabIndex = 0;
            this.lblThuocXuat.Text = "Sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(481, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = "Khách hàng";
            // 
            // txtHoTenKhachHang
            // 
            this.txtHoTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenKhachHang.Location = new System.Drawing.Point(552, 68);
            this.txtHoTenKhachHang.Name = "txtHoTenKhachHang";
            this.txtHoTenKhachHang.Size = new System.Drawing.Size(314, 20);
            this.txtHoTenKhachHang.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(38, 73);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 91;
            this.label17.Text = "Kho xuất";
            // 
            // grpKetQuaTimKiem
            // 
            this.grpKetQuaTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKetQuaTimKiem.Controls.Add(this.gListChungTu);
            this.grpKetQuaTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKetQuaTimKiem.ForeColor = System.Drawing.Color.Black;
            this.grpKetQuaTimKiem.Location = new System.Drawing.Point(1, 140);
            this.grpKetQuaTimKiem.Name = "grpKetQuaTimKiem";
            this.grpKetQuaTimKiem.Size = new System.Drawing.Size(1018, 364);
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
            this.gListChungTu.EmbeddedNavigator.TextStringFormat = "Đơn hàng số {0} / Tổng số {1} đơn hàng";
            this.gListChungTu.Location = new System.Drawing.Point(6, 19);
            this.gListChungTu.MainView = this.gvListChungTu;
            this.gListChungTu.Name = "gListChungTu";
            this.gListChungTu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repEdit,
            this.repLoaiDonHang,
            this.repTrangThaiDH});
            this.gListChungTu.Size = new System.Drawing.Size(1006, 339);
            this.gListChungTu.TabIndex = 0;
            this.gListChungTu.UseEmbeddedNavigator = true;
            this.gListChungTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListChungTu});
            // 
            // gvListChungTu
            // 
            this.gvListChungTu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNgayLap,
            this.colSoGiaoDich,
            this.colLoaiDonHang,
            this.SoChungTuGoc,
            this.colTrungTam,
            this.colKho,
            this.colSoHoaDon,
            this.NgayHoaDon,
            this.colSoPhieuXuat,
            this.colNgayXuat,
            this.colLyDoTraHang,
            this.IdLyDoGiaoDich,
            this.colTenNhanVien,
            this.colMaDoiTuong,
            this.colTenDoiTuong,
            this.colDienThoai,
            this.SoCMND,
            this.colMaSanPham,
            this.colTenSanPham,
            this.DonViTinh,
            this.colSoLuong,
            this.GiaTheoBangGia,
            this.colDonGia,
            this.colTyleChietKhau,
            this.TienChietKhau,
            this.TienSauChietKhau,
            this.TyleVAT,
            this.TienVAT,
            this.TyLeThanhToan,
            this.ThanhTien,
            this.SoDiemThuong,
            this.TyLeDiemThuong,
            this.TyLeDiemThuongMacDinh,
            this.TyleThuong,
            this.ThuongNong,
            this.GiaNiemYet,
            this.GiaWebSite,
            this.TenSanPhamBan,
            this.ListSoChinhSach,
            this.GhiChu,
            this.TrungMaVach,
            this.ChietKhau,
            this.NoKhuyenMai,
            this.XoaNoKM,
            this.TyLePhanBo,
            this.CungDongDonHangChinh,
            this.TenLoaiHangKem,
            this.LinhVuc,
            this.Nganh,
            this.NguoiTao,
            this.TrangThai,
            this.colTinhHD,
            this.colQuanHuyenHD,
            this.colTinhGH,
            this.colQuanHuyenGH,
            this.colGioiTinh,
            this.colNgheNghiep,
            this.colEmail,
            this.colWebSite});
            this.gvListChungTu.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvListChungTu.GridControl = this.gListChungTu;
            this.gvListChungTu.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "SoChungTu", null, "  (Tổng số  = {0})")});
            this.gvListChungTu.Name = "gvListChungTu";
            this.gvListChungTu.OptionsView.ColumnAutoWidth = false;
            this.gvListChungTu.OptionsView.ShowAutoFilterRow = true;
            this.gvListChungTu.OptionsView.ShowDetailButtons = false;
            this.gvListChungTu.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNgayLap, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gvListChungTu.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvListChungTu_FocusedRowChanged);
            this.gvListChungTu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gListChungTu_KeyDown);
            this.gvListChungTu.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvListChungTu_RowCellStyle);
            this.gvListChungTu.DoubleClick += new System.EventHandler(this.gListChungTu_DoubleClick);
            // 
            // colNgayLap
            // 
            this.colNgayLap.Caption = "Ngày lập";
            this.colNgayLap.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colNgayLap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayLap.FieldName = "NgayLap";
            this.colNgayLap.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colNgayLap.Name = "colNgayLap";
            this.colNgayLap.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNgayLap.OptionsColumn.ReadOnly = true;
            this.colNgayLap.Visible = true;
            this.colNgayLap.VisibleIndex = 0;
            this.colNgayLap.Width = 113;
            // 
            // colSoGiaoDich
            // 
            this.colSoGiaoDich.Caption = "Số giao dịch";
            this.colSoGiaoDich.FieldName = "SoChungTu";
            this.colSoGiaoDich.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colSoGiaoDich.Name = "colSoGiaoDich";
            this.colSoGiaoDich.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSoGiaoDich.OptionsColumn.ReadOnly = true;
            this.colSoGiaoDich.Visible = true;
            this.colSoGiaoDich.VisibleIndex = 1;
            this.colSoGiaoDich.Width = 149;
            // 
            // colLoaiDonHang
            // 
            this.colLoaiDonHang.Caption = "Loại đơn hàng";
            this.colLoaiDonHang.FieldName = "LoaiChungTu";
            this.colLoaiDonHang.Name = "colLoaiDonHang";
            this.colLoaiDonHang.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colLoaiDonHang.OptionsColumn.ReadOnly = true;
            this.colLoaiDonHang.Visible = true;
            this.colLoaiDonHang.VisibleIndex = 6;
            this.colLoaiDonHang.Width = 154;
            // 
            // SoChungTuGoc
            // 
            this.SoChungTuGoc.Caption = "Số chứng từ gốc";
            this.SoChungTuGoc.FieldName = "SoChungTuGoc";
            this.SoChungTuGoc.Name = "SoChungTuGoc";
            this.SoChungTuGoc.OptionsColumn.ReadOnly = true;
            this.SoChungTuGoc.Visible = true;
            this.SoChungTuGoc.VisibleIndex = 7;
            this.SoChungTuGoc.Width = 146;
            // 
            // colTrungTam
            // 
            this.colTrungTam.Caption = "Trung tâm";
            this.colTrungTam.FieldName = "TenTrungTam";
            this.colTrungTam.Name = "colTrungTam";
            this.colTrungTam.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTrungTam.OptionsColumn.ReadOnly = true;
            this.colTrungTam.Visible = true;
            this.colTrungTam.VisibleIndex = 8;
            this.colTrungTam.Width = 150;
            // 
            // colKho
            // 
            this.colKho.AppearanceCell.Options.UseTextOptions = true;
            this.colKho.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colKho.Caption = "Kho hàng";
            this.colKho.FieldName = "TenKho";
            this.colKho.Name = "colKho";
            this.colKho.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colKho.OptionsColumn.ReadOnly = true;
            this.colKho.Visible = true;
            this.colKho.VisibleIndex = 9;
            this.colKho.Width = 237;
            // 
            // colSoHoaDon
            // 
            this.colSoHoaDon.Caption = "Số hóa đơn";
            this.colSoHoaDon.FieldName = "SoSeri";
            this.colSoHoaDon.Name = "colSoHoaDon";
            this.colSoHoaDon.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSoHoaDon.OptionsColumn.ReadOnly = true;
            this.colSoHoaDon.Visible = true;
            this.colSoHoaDon.VisibleIndex = 10;
            this.colSoHoaDon.Width = 121;
            // 
            // NgayHoaDon
            // 
            this.NgayHoaDon.Caption = "Ngày hóa đơn";
            this.NgayHoaDon.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.NgayHoaDon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgayHoaDon.FieldName = "NgayHoaDon";
            this.NgayHoaDon.Name = "NgayHoaDon";
            this.NgayHoaDon.OptionsColumn.AllowEdit = false;
            this.NgayHoaDon.Visible = true;
            this.NgayHoaDon.VisibleIndex = 11;
            this.NgayHoaDon.Width = 114;
            // 
            // colSoPhieuXuat
            // 
            this.colSoPhieuXuat.Caption = "Số phiếu xuất";
            this.colSoPhieuXuat.FieldName = "SoPhieuXuat";
            this.colSoPhieuXuat.Name = "colSoPhieuXuat";
            this.colSoPhieuXuat.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSoPhieuXuat.OptionsColumn.ReadOnly = true;
            this.colSoPhieuXuat.Width = 120;
            // 
            // colNgayXuat
            // 
            this.colNgayXuat.Caption = "Ngày xuất";
            this.colNgayXuat.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgayXuat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayXuat.FieldName = "NgayXuatHang";
            this.colNgayXuat.Name = "colNgayXuat";
            this.colNgayXuat.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNgayXuat.OptionsColumn.ReadOnly = true;
            this.colNgayXuat.Width = 94;
            // 
            // colLyDoTraHang
            // 
            this.colLyDoTraHang.Caption = "Lý do trả hàng";
            this.colLyDoTraHang.FieldName = "LyDoTraHang";
            this.colLyDoTraHang.Name = "colLyDoTraHang";
            this.colLyDoTraHang.Visible = true;
            this.colLyDoTraHang.VisibleIndex = 14;
            this.colLyDoTraHang.Width = 117;
            // 
            // IdLyDoGiaoDich
            // 
            this.IdLyDoGiaoDich.Caption = "Xuất trả NCC";
            this.IdLyDoGiaoDich.ColumnEdit = this.repEdit;
            this.IdLyDoGiaoDich.FieldName = "IdLyDoGiaoDich";
            this.IdLyDoGiaoDich.Name = "IdLyDoGiaoDich";
            this.IdLyDoGiaoDich.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.IdLyDoGiaoDich.OptionsColumn.ReadOnly = true;
            this.IdLyDoGiaoDich.Visible = true;
            this.IdLyDoGiaoDich.VisibleIndex = 12;
            this.IdLyDoGiaoDich.Width = 82;
            // 
            // repEdit
            // 
            this.repEdit.AutoHeight = false;
            this.repEdit.Name = "repEdit";
            this.repEdit.ValueChecked = 1;
            this.repEdit.ValueUnchecked = 0;
            // 
            // colTenNhanVien
            // 
            this.colTenNhanVien.Caption = "Thương viên";
            this.colTenNhanVien.FieldName = "TenNhanVien";
            this.colTenNhanVien.Name = "colTenNhanVien";
            this.colTenNhanVien.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTenNhanVien.OptionsColumn.ReadOnly = true;
            this.colTenNhanVien.Visible = true;
            this.colTenNhanVien.VisibleIndex = 13;
            this.colTenNhanVien.Width = 143;
            // 
            // colMaDoiTuong
            // 
            this.colMaDoiTuong.Caption = "Mã khách hàng";
            this.colMaDoiTuong.FieldName = "MaDoiTuong";
            this.colMaDoiTuong.Name = "colMaDoiTuong";
            this.colMaDoiTuong.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colMaDoiTuong.OptionsColumn.ReadOnly = true;
            this.colMaDoiTuong.Visible = true;
            this.colMaDoiTuong.VisibleIndex = 15;
            this.colMaDoiTuong.Width = 96;
            // 
            // colTenDoiTuong
            // 
            this.colTenDoiTuong.Caption = "Tên khách hàng";
            this.colTenDoiTuong.FieldName = "HoTen";
            this.colTenDoiTuong.Name = "colTenDoiTuong";
            this.colTenDoiTuong.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTenDoiTuong.OptionsColumn.ReadOnly = true;
            this.colTenDoiTuong.Visible = true;
            this.colTenDoiTuong.VisibleIndex = 16;
            this.colTenDoiTuong.Width = 239;
            // 
            // colDienThoai
            // 
            this.colDienThoai.Caption = "Số điện thoại";
            this.colDienThoai.FieldName = "DienThoai";
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colDienThoai.OptionsColumn.ReadOnly = true;
            this.colDienThoai.Visible = true;
            this.colDienThoai.VisibleIndex = 17;
            this.colDienThoai.Width = 126;
            // 
            // SoCMND
            // 
            this.SoCMND.Caption = "Số CMND";
            this.SoCMND.FieldName = "SoCMND";
            this.SoCMND.Name = "SoCMND";
            this.SoCMND.Visible = true;
            this.SoCMND.VisibleIndex = 18;
            this.SoCMND.Width = 110;
            // 
            // colMaSanPham
            // 
            this.colMaSanPham.Caption = "Mã sản phẩm";
            this.colMaSanPham.FieldName = "MaSanPham";
            this.colMaSanPham.Name = "colMaSanPham";
            this.colMaSanPham.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colMaSanPham.OptionsColumn.ReadOnly = true;
            this.colMaSanPham.Visible = true;
            this.colMaSanPham.VisibleIndex = 19;
            this.colMaSanPham.Width = 118;
            // 
            // colTenSanPham
            // 
            this.colTenSanPham.Caption = "Tên sản phẩm";
            this.colTenSanPham.FieldName = "TenSanPham";
            this.colTenSanPham.Name = "colTenSanPham";
            this.colTenSanPham.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTenSanPham.OptionsColumn.ReadOnly = true;
            this.colTenSanPham.Visible = true;
            this.colTenSanPham.VisibleIndex = 20;
            this.colTenSanPham.Width = 129;
            // 
            // DonViTinh
            // 
            this.DonViTinh.Caption = "Đơn vị tính";
            this.DonViTinh.FieldName = "DonViTinh";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.DonViTinh.OptionsColumn.ReadOnly = true;
            this.DonViTinh.Visible = true;
            this.DonViTinh.VisibleIndex = 21;
            this.DonViTinh.Width = 90;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Số lượng";
            this.colSoLuong.DisplayFormat.FormatString = "N0";
            this.colSoLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSoLuong.OptionsColumn.ReadOnly = true;
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 22;
            // 
            // GiaTheoBangGia
            // 
            this.GiaTheoBangGia.Caption = "Giá theo bảng giá";
            this.GiaTheoBangGia.DisplayFormat.FormatString = "N0";
            this.GiaTheoBangGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaTheoBangGia.FieldName = "GiaTheoBangGia";
            this.GiaTheoBangGia.Name = "GiaTheoBangGia";
            this.GiaTheoBangGia.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.GiaTheoBangGia.OptionsColumn.ReadOnly = true;
            this.GiaTheoBangGia.Visible = true;
            this.GiaTheoBangGia.VisibleIndex = 23;
            this.GiaTheoBangGia.Width = 106;
            // 
            // colDonGia
            // 
            this.colDonGia.Caption = "Đơn giá";
            this.colDonGia.DisplayFormat.FormatString = "N0";
            this.colDonGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDonGia.FieldName = "DonGia";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colDonGia.OptionsColumn.ReadOnly = true;
            this.colDonGia.Visible = true;
            this.colDonGia.VisibleIndex = 24;
            this.colDonGia.Width = 107;
            // 
            // colTyleChietKhau
            // 
            this.colTyleChietKhau.Caption = "Tỷ lệ CK";
            this.colTyleChietKhau.DisplayFormat.FormatString = "N0";
            this.colTyleChietKhau.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTyleChietKhau.FieldName = "TyLeChietKhau";
            this.colTyleChietKhau.Name = "colTyleChietKhau";
            this.colTyleChietKhau.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTyleChietKhau.OptionsColumn.ReadOnly = true;
            this.colTyleChietKhau.Visible = true;
            this.colTyleChietKhau.VisibleIndex = 25;
            this.colTyleChietKhau.Width = 80;
            // 
            // TienChietKhau
            // 
            this.TienChietKhau.Caption = "Tiền CK";
            this.TienChietKhau.DisplayFormat.FormatString = "N0";
            this.TienChietKhau.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TienChietKhau.FieldName = "TienChietKhau";
            this.TienChietKhau.Name = "TienChietKhau";
            this.TienChietKhau.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TienChietKhau.OptionsColumn.ReadOnly = true;
            this.TienChietKhau.Visible = true;
            this.TienChietKhau.VisibleIndex = 26;
            this.TienChietKhau.Width = 86;
            // 
            // TienSauChietKhau
            // 
            this.TienSauChietKhau.Caption = "Giá trị trước VAT";
            this.TienSauChietKhau.DisplayFormat.FormatString = "N0";
            this.TienSauChietKhau.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TienSauChietKhau.FieldName = "TienSauChietKhau";
            this.TienSauChietKhau.Name = "TienSauChietKhau";
            this.TienSauChietKhau.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TienSauChietKhau.OptionsColumn.ReadOnly = true;
            this.TienSauChietKhau.Visible = true;
            this.TienSauChietKhau.VisibleIndex = 27;
            this.TienSauChietKhau.Width = 102;
            // 
            // TyleVAT
            // 
            this.TyleVAT.Caption = "Tỷ lệ VAT";
            this.TyleVAT.DisplayFormat.FormatString = "N0";
            this.TyleVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyleVAT.FieldName = "TyLeVAT";
            this.TyleVAT.Name = "TyleVAT";
            this.TyleVAT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TyleVAT.OptionsColumn.ReadOnly = true;
            this.TyleVAT.Visible = true;
            this.TyleVAT.VisibleIndex = 28;
            this.TyleVAT.Width = 86;
            // 
            // TienVAT
            // 
            this.TienVAT.Caption = "Tiền VAT";
            this.TienVAT.DisplayFormat.FormatString = "N0";
            this.TienVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TienVAT.FieldName = "TienVAT";
            this.TienVAT.Name = "TienVAT";
            this.TienVAT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TienVAT.OptionsColumn.ReadOnly = true;
            this.TienVAT.Visible = true;
            this.TienVAT.VisibleIndex = 29;
            this.TienVAT.Width = 95;
            // 
            // TyLeThanhToan
            // 
            this.TyLeThanhToan.Caption = "Tỷ lệ thanh toán";
            this.TyLeThanhToan.DisplayFormat.FormatString = "N0";
            this.TyLeThanhToan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyLeThanhToan.FieldName = "TyLeThanhToan";
            this.TyLeThanhToan.Name = "TyLeThanhToan";
            this.TyLeThanhToan.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TyLeThanhToan.OptionsColumn.ReadOnly = true;
            this.TyLeThanhToan.Visible = true;
            this.TyLeThanhToan.VisibleIndex = 30;
            this.TyLeThanhToan.Width = 125;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Caption = "Thành tiền";
            this.ThanhTien.DisplayFormat.FormatString = "N0";
            this.ThanhTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ThanhTien.FieldName = "ThanhTien";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.ThanhTien.OptionsColumn.ReadOnly = true;
            this.ThanhTien.Visible = true;
            this.ThanhTien.VisibleIndex = 31;
            this.ThanhTien.Width = 103;
            // 
            // SoDiemThuong
            // 
            this.SoDiemThuong.Caption = "Số điểm thưởng";
            this.SoDiemThuong.FieldName = "SoDiemThuong";
            this.SoDiemThuong.Name = "SoDiemThuong";
            this.SoDiemThuong.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.SoDiemThuong.Visible = true;
            this.SoDiemThuong.VisibleIndex = 32;
            this.SoDiemThuong.Width = 108;
            // 
            // TyLeDiemThuong
            // 
            this.TyLeDiemThuong.Caption = "Tỷ lệ điểm thưởng";
            this.TyLeDiemThuong.FieldName = "TyLeDiemThuong";
            this.TyLeDiemThuong.Name = "TyLeDiemThuong";
            this.TyLeDiemThuong.Visible = true;
            this.TyLeDiemThuong.VisibleIndex = 33;
            this.TyLeDiemThuong.Width = 111;
            // 
            // TyLeDiemThuongMacDinh
            // 
            this.TyLeDiemThuongMacDinh.Caption = "Tỷ lệ thưởng mặc định";
            this.TyLeDiemThuongMacDinh.FieldName = "TyLeDiemThuongMacDinh";
            this.TyLeDiemThuongMacDinh.Name = "TyLeDiemThuongMacDinh";
            this.TyLeDiemThuongMacDinh.Visible = true;
            this.TyLeDiemThuongMacDinh.VisibleIndex = 34;
            this.TyLeDiemThuongMacDinh.Width = 128;
            // 
            // TyleThuong
            // 
            this.TyleThuong.Caption = "Tỷ lệ thưởng nhân viên";
            this.TyleThuong.DisplayFormat.FormatString = "N0";
            this.TyleThuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TyleThuong.FieldName = "TyLeThuong";
            this.TyleThuong.Name = "TyleThuong";
            this.TyleThuong.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TyleThuong.OptionsColumn.ReadOnly = true;
            this.TyleThuong.Visible = true;
            this.TyleThuong.VisibleIndex = 35;
            this.TyleThuong.Width = 133;
            // 
            // ThuongNong
            // 
            this.ThuongNong.Caption = "Thưởng nóng nhân viên";
            this.ThuongNong.DisplayFormat.FormatString = "N0";
            this.ThuongNong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ThuongNong.FieldName = "ThuongNong";
            this.ThuongNong.Name = "ThuongNong";
            this.ThuongNong.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.ThuongNong.OptionsColumn.ReadOnly = true;
            this.ThuongNong.Visible = true;
            this.ThuongNong.VisibleIndex = 36;
            this.ThuongNong.Width = 142;
            // 
            // GiaNiemYet
            // 
            this.GiaNiemYet.Caption = "GiaNiemYet";
            this.GiaNiemYet.DisplayFormat.FormatString = "N0";
            this.GiaNiemYet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaNiemYet.FieldName = "GiaNiemYet";
            this.GiaNiemYet.Name = "GiaNiemYet";
            this.GiaNiemYet.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.GiaNiemYet.OptionsColumn.ReadOnly = true;
            // 
            // GiaWebSite
            // 
            this.GiaWebSite.Caption = "GiaWebSite";
            this.GiaWebSite.DisplayFormat.FormatString = "N0";
            this.GiaWebSite.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaWebSite.FieldName = "GiaWebSite";
            this.GiaWebSite.Name = "GiaWebSite";
            this.GiaWebSite.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.GiaWebSite.OptionsColumn.ReadOnly = true;
            // 
            // TenSanPhamBan
            // 
            this.TenSanPhamBan.Caption = "Sản phẩm bán";
            this.TenSanPhamBan.FieldName = "TenSanPhamBan";
            this.TenSanPhamBan.Name = "TenSanPhamBan";
            this.TenSanPhamBan.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TenSanPhamBan.OptionsColumn.ReadOnly = true;
            this.TenSanPhamBan.Visible = true;
            this.TenSanPhamBan.VisibleIndex = 37;
            this.TenSanPhamBan.Width = 183;
            // 
            // ListSoChinhSach
            // 
            this.ListSoChinhSach.Caption = "Số chính sách giá";
            this.ListSoChinhSach.FieldName = "ListSoChinhSach";
            this.ListSoChinhSach.Name = "ListSoChinhSach";
            this.ListSoChinhSach.Visible = true;
            this.ListSoChinhSach.VisibleIndex = 38;
            this.ListSoChinhSach.Width = 186;
            // 
            // GhiChu
            // 
            this.GhiChu.Caption = "Ghi chú";
            this.GhiChu.FieldName = "GhiChu";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.GhiChu.Visible = true;
            this.GhiChu.VisibleIndex = 39;
            // 
            // TrungMaVach
            // 
            this.TrungMaVach.Caption = "Trùng mã vạch";
            this.TrungMaVach.ColumnEdit = this.repEdit;
            this.TrungMaVach.FieldName = "TrungMaVach";
            this.TrungMaVach.Name = "TrungMaVach";
            this.TrungMaVach.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TrungMaVach.OptionsColumn.ReadOnly = true;
            this.TrungMaVach.Visible = true;
            this.TrungMaVach.VisibleIndex = 40;
            this.TrungMaVach.Width = 110;
            // 
            // ChietKhau
            // 
            this.ChietKhau.Caption = "Chiết khấu";
            this.ChietKhau.ColumnEdit = this.repEdit;
            this.ChietKhau.FieldName = "ChietKhau";
            this.ChietKhau.Name = "ChietKhau";
            this.ChietKhau.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.ChietKhau.OptionsColumn.ReadOnly = true;
            this.ChietKhau.Visible = true;
            this.ChietKhau.VisibleIndex = 41;
            this.ChietKhau.Width = 103;
            // 
            // NoKhuyenMai
            // 
            this.NoKhuyenMai.Caption = "Nợ khuyến mại";
            this.NoKhuyenMai.FieldName = "NoKhuyenMai";
            this.NoKhuyenMai.Name = "NoKhuyenMai";
            this.NoKhuyenMai.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.NoKhuyenMai.OptionsColumn.ReadOnly = true;
            this.NoKhuyenMai.Visible = true;
            this.NoKhuyenMai.VisibleIndex = 42;
            this.NoKhuyenMai.Width = 111;
            // 
            // XoaNoKM
            // 
            this.XoaNoKM.Caption = "Xóa nợ KM";
            this.XoaNoKM.FieldName = "XoaNoKM";
            this.XoaNoKM.Name = "XoaNoKM";
            this.XoaNoKM.OptionsColumn.ReadOnly = true;
            this.XoaNoKM.Visible = true;
            this.XoaNoKM.VisibleIndex = 43;
            this.XoaNoKM.Width = 87;
            // 
            // TyLePhanBo
            // 
            this.TyLePhanBo.Caption = "Tỷ lệ phân bổ (%)";
            this.TyLePhanBo.FieldName = "TyLePhanBo";
            this.TyLePhanBo.Name = "TyLePhanBo";
            this.TyLePhanBo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TyLePhanBo.OptionsColumn.ReadOnly = true;
            this.TyLePhanBo.Visible = true;
            this.TyLePhanBo.VisibleIndex = 44;
            this.TyLePhanBo.Width = 138;
            // 
            // CungDongDonHangChinh
            // 
            this.CungDongDonHangChinh.Caption = "Cùng dòng hàng chính";
            this.CungDongDonHangChinh.ColumnEdit = this.repEdit;
            this.CungDongDonHangChinh.FieldName = "CungDongDonHangChinh";
            this.CungDongDonHangChinh.Name = "CungDongDonHangChinh";
            this.CungDongDonHangChinh.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.CungDongDonHangChinh.OptionsColumn.ReadOnly = true;
            this.CungDongDonHangChinh.Visible = true;
            this.CungDongDonHangChinh.VisibleIndex = 45;
            this.CungDongDonHangChinh.Width = 150;
            // 
            // TenLoaiHangKem
            // 
            this.TenLoaiHangKem.Caption = "Loại hàng kèm";
            this.TenLoaiHangKem.FieldName = "TenLoaiHangKem";
            this.TenLoaiHangKem.Name = "TenLoaiHangKem";
            this.TenLoaiHangKem.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TenLoaiHangKem.OptionsColumn.ReadOnly = true;
            this.TenLoaiHangKem.Visible = true;
            this.TenLoaiHangKem.VisibleIndex = 46;
            this.TenLoaiHangKem.Width = 119;
            // 
            // LinhVuc
            // 
            this.LinhVuc.Caption = "Lĩnh vực";
            this.LinhVuc.FieldName = "LinhVuc";
            this.LinhVuc.Name = "LinhVuc";
            this.LinhVuc.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.LinhVuc.OptionsColumn.ReadOnly = true;
            this.LinhVuc.Visible = true;
            this.LinhVuc.VisibleIndex = 47;
            this.LinhVuc.Width = 88;
            // 
            // Nganh
            // 
            this.Nganh.Caption = "Ngành";
            this.Nganh.FieldName = "Nganh";
            this.Nganh.Name = "Nganh";
            this.Nganh.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Nganh.OptionsColumn.ReadOnly = true;
            this.Nganh.Visible = true;
            this.Nganh.VisibleIndex = 48;
            this.Nganh.Width = 102;
            // 
            // NguoiTao
            // 
            this.NguoiTao.Caption = "Người tạo";
            this.NguoiTao.FieldName = "NguoiTao";
            this.NguoiTao.Name = "NguoiTao";
            this.NguoiTao.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.NguoiTao.OptionsColumn.ReadOnly = true;
            this.NguoiTao.Visible = true;
            this.NguoiTao.VisibleIndex = 49;
            // 
            // TrangThai
            // 
            this.TrangThai.Caption = "Tình trạng đơn hàng";
            this.TrangThai.FieldName = "DienGiai";
            this.TrangThai.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TrangThai.OptionsColumn.ReadOnly = true;
            this.TrangThai.Visible = true;
            this.TrangThai.VisibleIndex = 54;
            this.TrangThai.Width = 134;
            // 
            // colTinhHD
            // 
            this.colTinhHD.Caption = "Tỉnh HD";
            this.colTinhHD.FieldName = "TinhHD";
            this.colTinhHD.Name = "colTinhHD";
            this.colTinhHD.Visible = true;
            this.colTinhHD.VisibleIndex = 50;
            // 
            // colQuanHuyenHD
            // 
            this.colQuanHuyenHD.Caption = "Huyện HD";
            this.colQuanHuyenHD.FieldName = "QuanHuyenHD";
            this.colQuanHuyenHD.Name = "colQuanHuyenHD";
            this.colQuanHuyenHD.Visible = true;
            this.colQuanHuyenHD.VisibleIndex = 51;
            // 
            // colTinhGH
            // 
            this.colTinhGH.Caption = "Tỉnh GH";
            this.colTinhGH.FieldName = "TinhGH";
            this.colTinhGH.Name = "colTinhGH";
            this.colTinhGH.Visible = true;
            this.colTinhGH.VisibleIndex = 52;
            // 
            // colQuanHuyenGH
            // 
            this.colQuanHuyenGH.Caption = "Huyện GH";
            this.colQuanHuyenGH.FieldName = "QuanHuyenGH";
            this.colQuanHuyenGH.Name = "colQuanHuyenGH";
            this.colQuanHuyenGH.Visible = true;
            this.colQuanHuyenGH.VisibleIndex = 53;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Caption = "Giới tính";
            this.colGioiTinh.FieldName = "GioiTinh";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Visible = true;
            this.colGioiTinh.VisibleIndex = 5;
            // 
            // colNgheNghiep
            // 
            this.colNgheNghiep.Caption = "Nghề nghiệp";
            this.colNgheNghiep.FieldName = "TenNgheNghiep";
            this.colNgheNghiep.Name = "colNgheNghiep";
            this.colNgheNghiep.Visible = true;
            this.colNgheNghiep.VisibleIndex = 4;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 3;
            // 
            // colWebSite
            // 
            this.colWebSite.Caption = "WebSite";
            this.colWebSite.FieldName = "WebSite";
            this.colWebSite.Name = "colWebSite";
            this.colWebSite.Visible = true;
            this.colWebSite.VisibleIndex = 2;
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
            // repTrangThaiDH
            // 
            this.repTrangThaiDH.AutoHeight = false;
            this.repTrangThaiDH.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repTrangThaiDH.DisplayMember = "Name";
            this.repTrangThaiDH.Name = "repTrangThaiDH";
            this.repTrangThaiDH.ValueMember = "Id";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslHuyClr,
            this.tsslHuy,
            this.tsslTuChoiClr,
            this.tsslTuChoi,
            this.toolStripStatusLabel7,
            this.tsslTrangThai});
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(1021, 22);
            this.statusStrip1.TabIndex = 109;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslHuyClr
            // 
            this.tsslHuyClr.BackColor = System.Drawing.Color.Red;
            this.tsslHuyClr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tsslHuyClr.Name = "tsslHuyClr";
            this.tsslHuyClr.Size = new System.Drawing.Size(19, 17);
            this.tsslHuyClr.Text = "    ";
            // 
            // tsslHuy
            // 
            this.tsslHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tsslHuy.Name = "tsslHuy";
            this.tsslHuy.Size = new System.Drawing.Size(67, 17);
            this.tsslHuy.Text = "Hủy / Khóa";
            // 
            // tsslTuChoiClr
            // 
            this.tsslTuChoiClr.BackColor = System.Drawing.Color.Yellow;
            this.tsslTuChoiClr.Name = "tsslTuChoiClr";
            this.tsslTuChoiClr.Size = new System.Drawing.Size(19, 17);
            this.tsslTuChoiClr.Text = "    ";
            // 
            // tsslTuChoi
            // 
            this.tsslTuChoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tsslTuChoi.Name = "tsslTuChoi";
            this.tsslTuChoi.Size = new System.Drawing.Size(47, 17);
            this.tsslTuChoi.Text = "Từ chối";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabel7.Text = "    ";
            // 
            // tsslTrangThai
            // 
            this.tsslTrangThai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tsslTrangThai.Name = "tsslTrangThai";
            this.tsslTrangThai.Size = new System.Drawing.Size(116, 17);
            this.tsslTrangThai.Text = "Danh sách đơn hàng";
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
            // frmBC_DonHangChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 532);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpKetQuaTimKiem);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmBC_DonHangChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết đơn hàng bán";
            this.Load += new System.EventHandler(this.frmBH_TimChungTu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBH_TimChungTu_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteNganh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTrangThaiDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLoaiDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhoXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).EndInit();
            this.grpKetQuaTimKiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gListChungTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListChungTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoaiDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrangThaiDH)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ctxMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpKetQuaTimKiem;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        internal GtidButton btnDong;
        private GtidButton btnTim;
        private GtidTextBox txtHoTenKhachHang;
        private GtidTextBox txtSoGiaoDich;
        private GtidTextBox txtNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.ButtonEdit bteTrungTam;
        private DevExpress.XtraEditors.ButtonEdit bteKhoXuat;
        private System.Windows.Forms.Label lblThuocXuat;
        private System.Windows.Forms.ComboBox cboLoaiMaHang;
        private DevExpress.XtraEditors.LookUpEdit lueLoaiDH;
        private DevExpress.XtraEditors.LabelControl lblTrangThaiLinhKien;
        private DevExpress.XtraEditors.LookUpEdit lueTrangThaiDH;
        private DevExpress.XtraEditors.LabelControl lblTrangThaiDH;
        private DevExpress.XtraEditors.DateEdit dteEnd;
        private DevExpress.XtraEditors.DateEdit dteStart;
        private DevExpress.XtraEditors.LabelControl lblEnd;
        private DevExpress.XtraEditors.LabelControl lblStart;
        private DevExpress.XtraGrid.GridControl gListChungTu;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn colTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDoiTuong;
        private DevExpress.XtraGrid.Columns.GridColumn colKho;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiDonHang;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLoaiDonHang;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayLap;
        private DevExpress.XtraGrid.Columns.GridColumn colSoGiaoDich;
        private DevExpress.XtraGrid.Columns.GridColumn colSoHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn colSoPhieuXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhanVien;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repEdit;
        private GtidButton cmdExport;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colTyleChietKhau;
        private DevExpress.XtraGrid.Columns.GridColumn TienChietKhau;
        private DevExpress.XtraGrid.Columns.GridColumn TienSauChietKhau;
        private DevExpress.XtraGrid.Columns.GridColumn TyleVAT;
        private DevExpress.XtraGrid.Columns.GridColumn TienVAT;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhTien;
        private DevExpress.XtraGrid.Columns.GridColumn TyleThuong;
        private DevExpress.XtraGrid.Columns.GridColumn ThuongNong;
        private DevExpress.XtraGrid.Columns.GridColumn DonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn GiaTheoBangGia;
        private DevExpress.XtraGrid.Columns.GridColumn GiaNiemYet;
        private DevExpress.XtraGrid.Columns.GridColumn GiaWebSite;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPhamBan;
        private DevExpress.XtraGrid.Columns.GridColumn TrungMaVach;
        private DevExpress.XtraGrid.Columns.GridColumn ChietKhau;
        private DevExpress.XtraGrid.Columns.GridColumn NoKhuyenMai;
        private DevExpress.XtraGrid.Columns.GridColumn TyLePhanBo;
        private DevExpress.XtraGrid.Columns.GridColumn CungDongDonHangChinh;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoaiHangKem;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn LinhVuc;
        private DevExpress.XtraGrid.Columns.GridColumn Nganh;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiTao;
        private DevExpress.XtraGrid.Columns.GridColumn TrangThai;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repTrangThaiDH;
        private DevExpress.XtraGrid.Columns.GridColumn colDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDoiTuong;
        private DevExpress.XtraGrid.Columns.GridColumn SoChungTuGoc;
        private DevExpress.XtraGrid.Columns.GridColumn SoCMND;
        private GtidButton btnExportAll;
        private DevExpress.XtraGrid.Columns.GridColumn IdLyDoGiaoDich;
        private DevExpress.XtraGrid.Columns.GridColumn colLyDoTraHang;
        protected DevExpress.XtraEditors.ButtonEdit bteNganh;
        private DevExpress.XtraGrid.Columns.GridColumn XoaNoKM;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel tsslHuyClr;
        public System.Windows.Forms.ToolStripStatusLabel tsslHuy;
        public System.Windows.Forms.ToolStripStatusLabel tsslTuChoiClr;
        public System.Windows.Forms.ToolStripStatusLabel tsslTuChoi;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel tsslTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhHD;
        private DevExpress.XtraGrid.Columns.GridColumn colQuanHuyenHD;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhGH;
        private DevExpress.XtraGrid.Columns.GridColumn colQuanHuyenGH;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colNgheNghiep;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colWebSite;
        private DevExpress.XtraGrid.Columns.GridColumn NgayHoaDon;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem tsbChinhSachGia;
        private DevExpress.XtraGrid.Columns.GridColumn ListSoChinhSach;
        private DevExpress.XtraGrid.Columns.GridColumn SoDiemThuong;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeDiemThuong;
        private DevExpress.XtraGrid.Columns.GridColumn TyLeDiemThuongMacDinh;
    }
}