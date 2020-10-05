using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using QLBH.Core.Form;
namespace QLBanHang.Modules.BanHang
{
    partial class frmImport_TestPerformance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImport_TestPerformance));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStopTest = new QLBH.Core.Form.GtidButton();
            this.btnStartTest = new QLBH.Core.Form.GtidButton();
            this.btnThamSo = new QLBH.Core.Form.GtidButton();
            this.btnDong = new QLBH.Core.Form.GtidButton();
            this.grpKetQuaTimKiem = new System.Windows.Forms.GroupBox();
            this.txtSoChungTu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoLanLap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboKichBanTest = new System.Windows.Forms.ComboBox();
            this.txtSoUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThoiGianHanhDong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNganHangTT = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpKetQuaImport = new System.Windows.Forms.GroupBox();
            this.txtSession = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.btnExportErr = new QLBH.Core.Form.GtidButton();
            this.gImportErrors = new DevExpress.XtraGrid.GridControl();
            this.gvImportErrors = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Infors = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Result = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ok = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gDB = new DevExpress.XtraGrid.GridControl();
            this.gvDB = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.grpKetQuaTimKiem.SuspendLayout();
            this.grpKetQuaImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gImportErrors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvImportErrors)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnStopTest);
            this.groupBox1.Controls.Add(this.btnStartTest);
            this.groupBox1.Controls.Add(this.btnThamSo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnStopTest
            // 
            this.btnStopTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopTest.Image = ((System.Drawing.Image)(resources.GetObject("btnStopTest.Image")));
            this.btnStopTest.Location = new System.Drawing.Point(552, 17);
            this.btnStopTest.Name = "btnStopTest";
            this.btnStopTest.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnStopTest.Size = new System.Drawing.Size(213, 63);
            this.btnStopTest.TabIndex = 24;
            this.btnStopTest.Text = "Tạm dừng test performance";
            this.btnStopTest.Click += new System.EventHandler(this.btnStopTest_Click);
            // 
            // btnStartTest
            // 
            this.btnStartTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartTest.Image = ((System.Drawing.Image)(resources.GetObject("btnStartTest.Image")));
            this.btnStartTest.Location = new System.Drawing.Point(771, 17);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnStartTest.Size = new System.Drawing.Size(225, 63);
            this.btnStartTest.TabIndex = 23;
            this.btnStartTest.Text = "Thực hiện test performance";
            this.btnStartTest.Click += new System.EventHandler(this.btnImportToPOS_Click);
            // 
            // btnThamSo
            // 
            this.btnThamSo.Image = ((System.Drawing.Image)(resources.GetObject("btnThamSo.Image")));
            this.btnThamSo.Location = new System.Drawing.Point(22, 17);
            this.btnThamSo.Name = "btnThamSo";
            this.btnThamSo.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnThamSo.Size = new System.Drawing.Size(163, 63);
            this.btnThamSo.TabIndex = 20;
            this.btnThamSo.Text = "Tham số thực hiện";
            this.btnThamSo.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(912, 453);
            this.btnDong.Name = "btnDong";
            this.btnDong.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnDong.Size = new System.Drawing.Size(101, 25);
            this.btnDong.TabIndex = 21;
            this.btnDong.Text = "Đóng (F12)";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // grpKetQuaTimKiem
            // 
            this.grpKetQuaTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.grpKetQuaTimKiem.Controls.Add(this.txtSoChungTu);
            this.grpKetQuaTimKiem.Controls.Add(this.label3);
            this.grpKetQuaTimKiem.Controls.Add(this.txtSoLanLap);
            this.grpKetQuaTimKiem.Controls.Add(this.label2);
            this.grpKetQuaTimKiem.Controls.Add(this.cboKichBanTest);
            this.grpKetQuaTimKiem.Controls.Add(this.txtSoUser);
            this.grpKetQuaTimKiem.Controls.Add(this.label1);
            this.grpKetQuaTimKiem.Controls.Add(this.txtThoiGianHanhDong);
            this.grpKetQuaTimKiem.Controls.Add(this.label5);
            this.grpKetQuaTimKiem.Controls.Add(this.lblNganHangTT);
            this.grpKetQuaTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKetQuaTimKiem.ForeColor = System.Drawing.Color.Black;
            this.grpKetQuaTimKiem.Location = new System.Drawing.Point(1, 104);
            this.grpKetQuaTimKiem.Name = "grpKetQuaTimKiem";
            this.grpKetQuaTimKiem.Size = new System.Drawing.Size(327, 343);
            this.grpKetQuaTimKiem.TabIndex = 1;
            this.grpKetQuaTimKiem.TabStop = false;
            this.grpKetQuaTimKiem.Text = "Kịch bản test";
            // 
            // txtSoChungTu
            // 
            this.txtSoChungTu.Location = new System.Drawing.Point(71, 202);
            this.txtSoChungTu.Name = "txtSoChungTu";
            this.txtSoChungTu.Size = new System.Drawing.Size(237, 20);
            this.txtSoChungTu.TabIndex = 131;
            this.txtSoChungTu.TextChanged += new System.EventHandler(this.txtSoChungTu_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(19, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 132;
            this.label3.Text = "Số chứng từ";
            // 
            // txtSoLanLap
            // 
            this.txtSoLanLap.Location = new System.Drawing.Point(205, 68);
            this.txtSoLanLap.Name = "txtSoLanLap";
            this.txtSoLanLap.ReadOnly = true;
            this.txtSoLanLap.Size = new System.Drawing.Size(103, 20);
            this.txtSoLanLap.TabIndex = 129;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(19, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 130;
            this.label2.Text = "Số lần lặp";
            // 
            // cboKichBanTest
            // 
            this.cboKichBanTest.Enabled = false;
            this.cboKichBanTest.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cboKichBanTest.FormattingEnabled = true;
            this.cboKichBanTest.Items.AddRange(new object[] {
            "1. Lập đơn hàng => Thu tiền",
            "2. Lập đơn hàng => Thu tiền => Xuất kho",
            "3. Báo cáo tồn mã vạch hiện tại",
            "4. Báo cáo danh sách đơn hàng bán",
            "5. Báo cáo phiếu thu tiền",
            "6. Bảng giá hiện tại"});
            this.cboKichBanTest.Location = new System.Drawing.Point(71, 149);
            this.cboKichBanTest.Name = "cboKichBanTest";
            this.cboKichBanTest.Size = new System.Drawing.Size(237, 21);
            this.cboKichBanTest.TabIndex = 128;
            // 
            // txtSoUser
            // 
            this.txtSoUser.Location = new System.Drawing.Point(205, 36);
            this.txtSoUser.Name = "txtSoUser";
            this.txtSoUser.ReadOnly = true;
            this.txtSoUser.Size = new System.Drawing.Size(103, 20);
            this.txtSoUser.TabIndex = 123;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 127;
            this.label1.Text = "Số user thực hiện";
            // 
            // txtThoiGianHanhDong
            // 
            this.txtThoiGianHanhDong.Location = new System.Drawing.Point(205, 100);
            this.txtThoiGianHanhDong.Name = "txtThoiGianHanhDong";
            this.txtThoiGianHanhDong.ReadOnly = true;
            this.txtThoiGianHanhDong.Size = new System.Drawing.Size(103, 20);
            this.txtThoiGianHanhDong.TabIndex = 124;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(19, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 13);
            this.label5.TabIndex = 125;
            this.label5.Text = "Thời gian giữa các hành động";
            // 
            // lblNganHangTT
            // 
            this.lblNganHangTT.AutoSize = true;
            this.lblNganHangTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNganHangTT.Location = new System.Drawing.Point(19, 130);
            this.lblNganHangTT.Name = "lblNganHangTT";
            this.lblNganHangTT.Size = new System.Drawing.Size(96, 13);
            this.lblNganHangTT.TabIndex = 126;
            this.lblNganHangTT.Text = "Kịch bản thực hiện";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 459);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(38, 13);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status";
            // 
            // grpKetQuaImport
            // 
            this.grpKetQuaImport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKetQuaImport.Controls.Add(this.txtSession);
            this.grpKetQuaImport.Controls.Add(this.label4);
            this.grpKetQuaImport.Controls.Add(this.xtraTabControl2);
            this.grpKetQuaImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKetQuaImport.ForeColor = System.Drawing.Color.Black;
            this.grpKetQuaImport.Location = new System.Drawing.Point(334, 104);
            this.grpKetQuaImport.Name = "grpKetQuaImport";
            this.grpKetQuaImport.Size = new System.Drawing.Size(685, 343);
            this.grpKetQuaImport.TabIndex = 2;
            this.grpKetQuaImport.TabStop = false;
            this.grpKetQuaImport.Text = "Kết quả thực hiện";
            // 
            // txtSession
            // 
            this.txtSession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSession.Location = new System.Drawing.Point(572, 0);
            this.txtSession.Name = "txtSession";
            this.txtSession.ReadOnly = true;
            this.txtSession.Size = new System.Drawing.Size(103, 20);
            this.txtSession.TabIndex = 133;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(433, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 134;
            this.label4.Text = "Số lượng session Database";
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl2.Location = new System.Drawing.Point(6, 25);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.xtraTabPage4;
            this.xtraTabControl2.Size = new System.Drawing.Size(679, 315);
            this.xtraTabControl2.TabIndex = 1;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage4,
            this.xtraTabPage1});
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.btnExportErr);
            this.xtraTabPage4.Controls.Add(this.gImportErrors);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(672, 287);
            this.xtraTabPage4.Text = "Kết quả thực hiện";
            // 
            // btnExportErr
            // 
            this.btnExportErr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportErr.Image = ((System.Drawing.Image)(resources.GetObject("btnExportErr.Image")));
            this.btnExportErr.Location = new System.Drawing.Point(591, 269);
            this.btnExportErr.Name = "btnExportErr";
            this.btnExportErr.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnExportErr.Size = new System.Drawing.Size(77, 20);
            this.btnExportErr.TabIndex = 24;
            this.btnExportErr.Text = "Export";
            this.btnExportErr.Click += new System.EventHandler(this.btnExportErr_Click);
            // 
            // gImportErrors
            // 
            this.gImportErrors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gImportErrors.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gImportErrors.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gImportErrors.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gImportErrors.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gImportErrors.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gImportErrors.EmbeddedNavigator.TextStringFormat = "{0} / Tổng số {1}";
            this.gImportErrors.Location = new System.Drawing.Point(3, 3);
            this.gImportErrors.MainView = this.gvImportErrors;
            this.gImportErrors.Name = "gImportErrors";
            this.gImportErrors.Size = new System.Drawing.Size(666, 264);
            this.gImportErrors.TabIndex = 1;
            this.gImportErrors.UseEmbeddedNavigator = true;
            this.gImportErrors.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvImportErrors});
            // 
            // gvImportErrors
            // 
            this.gvImportErrors.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Infors,
            this.Result,
            this.Ok,
            this.Fail});
            this.gvImportErrors.GridControl = this.gImportErrors;
            this.gvImportErrors.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Ok", this.Ok, "Thành công = {0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Fail", this.Fail, "Thất bại = {0}")});
            this.gvImportErrors.Name = "gvImportErrors";
            this.gvImportErrors.OptionsNavigation.AutoFocusNewRow = true;
            this.gvImportErrors.OptionsView.ShowAutoFilterRow = true;
            this.gvImportErrors.OptionsView.ShowGroupPanel = false;
            this.gvImportErrors.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvImportErrors_RowCellStyle);
            // 
            // Infors
            // 
            this.Infors.Caption = "Thông tin User chạy";
            this.Infors.FieldName = "Infors";
            this.Infors.Name = "Infors";
            this.Infors.OptionsColumn.ReadOnly = true;
            this.Infors.Visible = true;
            this.Infors.VisibleIndex = 0;
            this.Infors.Width = 286;
            // 
            // Result
            // 
            this.Result.Caption = "Ghi chú";
            this.Result.FieldName = "Result";
            this.Result.Name = "Result";
            this.Result.OptionsColumn.ReadOnly = true;
            this.Result.Visible = true;
            this.Result.VisibleIndex = 1;
            this.Result.Width = 208;
            // 
            // Ok
            // 
            this.Ok.Caption = "Thành công";
            this.Ok.FieldName = "Ok";
            this.Ok.Name = "Ok";
            this.Ok.OptionsColumn.ReadOnly = true;
            this.Ok.Visible = true;
            this.Ok.VisibleIndex = 2;
            this.Ok.Width = 77;
            // 
            // Fail
            // 
            this.Fail.Caption = "Thất bại";
            this.Fail.FieldName = "Fail";
            this.Fail.Name = "Fail";
            this.Fail.OptionsColumn.ReadOnly = true;
            this.Fail.Visible = true;
            this.Fail.VisibleIndex = 3;
            this.Fail.Width = 74;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gDB);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(672, 287);
            this.xtraTabPage1.Text = "Session Database";
            // 
            // gDB
            // 
            this.gDB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gDB.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gDB.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gDB.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gDB.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gDB.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gDB.EmbeddedNavigator.TextStringFormat = "{0} / Tổng số {1}";
            this.gDB.Location = new System.Drawing.Point(3, 4);
            this.gDB.MainView = this.gvDB;
            this.gDB.Name = "gDB";
            this.gDB.Size = new System.Drawing.Size(666, 280);
            this.gDB.TabIndex = 2;
            this.gDB.UseEmbeddedNavigator = true;
            this.gDB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDB});
            // 
            // gvDB
            // 
            this.gvDB.GridControl = this.gDB;
            this.gvDB.Name = "gvDB";
            this.gvDB.OptionsNavigation.AutoFocusNewRow = true;
            this.gvDB.OptionsView.ColumnAutoWidth = false;
            this.gvDB.OptionsView.ShowAutoFilterRow = true;
            this.gvDB.OptionsView.ShowGroupPanel = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmImport_TestPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 481);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.grpKetQuaImport);
            this.Controls.Add(this.grpKetQuaTimKiem);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "frmImport_TestPerformance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Performance Test Tool";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBH_TimChungTu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBH_TimChungTu_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.grpKetQuaTimKiem.ResumeLayout(false);
            this.grpKetQuaTimKiem.PerformLayout();
            this.grpKetQuaImport.ResumeLayout(false);
            this.grpKetQuaImport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gImportErrors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvImportErrors)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpKetQuaTimKiem;
        internal GtidButton btnDong;
        private GtidButton btnThamSo;
        private GtidButton btnStartTest;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpKetQuaImport;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private GridControl gImportErrors;
        private GridView gvImportErrors;
        internal GtidButton btnExportErr;
        private GtidButton btnStopTest;
        private System.Windows.Forms.ComboBox cboKichBanTest;
        private System.Windows.Forms.TextBox txtSoUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThoiGianHanhDong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNganHangTT;
        private System.Windows.Forms.TextBox txtSoLanLap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoChungTu;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn Infors;
        private DevExpress.XtraGrid.Columns.GridColumn Result;
        private DevExpress.XtraGrid.Columns.GridColumn Ok;
        private DevExpress.XtraGrid.Columns.GridColumn Fail;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtSession;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private GridControl gDB;
        private GridView gvDB;
    }
}