using System.Collections.Generic;
using DevExpress.XtraGrid.Columns;
using QLBanHang.Modules.BanHang.Infors;

namespace QLBanHang.Modules.BanHang
{
    public class frmLookUp_SanPhamBan : frmLookUpBaseSanPhamBan
    {
        private GridColumn ColMaSanPham;
        private GridColumn ColTenSanPham;
        private GridColumn colDonViTinh;
        private GridColumn colTonKho;

        public frmLookUp_SanPhamBan()
        {
            InitializeComponent();
        }

        public frmLookUp_SanPhamBan(bool isMultiSelect, List<BangGiaBanChiTietInfor> liBangGiaBanChiTiet, bool showTonKho)
            : base(isMultiSelect, liBangGiaBanChiTiet)
        {
            InitializeComponent();
            colTonKho.Visible = showTonKho;
        }

        private void InitializeComponent()
        {
            this.ColMaSanPham = new GridColumn();
            this.ColTenSanPham = new GridColumn();
            this.colDonViTinh = new GridColumn();
            this.colTonKho = new GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLookUp
            // 
            this.txtLookUp.Size = new System.Drawing.Size(1738, 21);
            // 
            // grvLookUp
            // 
            this.grvLookUp.Columns.AddRange(new GridColumn[] {
            this.ColMaSanPham,
            this.ColTenSanPham,
            this.colDonViTinh,
            this.colTonKho});
            // 
            // ColMaSanPham
            // 
            this.ColMaSanPham.FieldName = "MaSanPham";
            this.ColMaSanPham.Caption = "Mã Sản Phẩm";
            this.ColMaSanPham.Name = "ColMaSanPham";
            this.ColMaSanPham.OptionsColumn.AllowEdit = false;
            this.ColMaSanPham.OptionsColumn.ReadOnly = true;
            this.ColMaSanPham.Visible = true;
            //this.ColMaSanPham.Width = 120;
            // 
            // ColTenSanPham
            // 
            this.ColTenSanPham.FieldName = "TenSanPham";
            this.ColTenSanPham.Caption = "Tên Sản Phẩm";
            this.ColTenSanPham.Name = "ColTenSanPham";
            this.ColTenSanPham.OptionsColumn.AllowEdit = false;
            this.ColTenSanPham.OptionsColumn.ReadOnly = true;
            this.ColTenSanPham.Visible = true;
            //this.ColTenSanPham.Width = 437;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.FieldName = "TenDonViTinh";
            this.colDonViTinh.Caption = "Đơn vị tính";
            this.colDonViTinh.Name = "colDonViTinh";
            this.colDonViTinh.OptionsColumn.AllowEdit = false;
            this.colDonViTinh.OptionsColumn.ReadOnly = true;
            this.colDonViTinh.Visible = true;
            // 
            // colTonKho
            // 
            this.colTonKho.FieldName = "TonKho";
            this.colTonKho.Caption = "Tồn kho";
            this.colTonKho.Name = "colTonKho";
            this.colTonKho.OptionsColumn.AllowEdit = false;
            this.colTonKho.OptionsColumn.ReadOnly = true;
            this.colTonKho.Visible = true;
            // 
            // frmLookUp_SanPhamBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(787, 457);
            this.Name = "frmLookUp_SanPhamBan";
            this.Text = "Tìm kiếm nhanh sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}
