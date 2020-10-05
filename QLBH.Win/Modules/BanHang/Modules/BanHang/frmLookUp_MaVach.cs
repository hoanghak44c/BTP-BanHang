using System.Collections.Generic;
using DevExpress.XtraGrid.Columns;
using QLBanHang.Modules.BanHang.Infors;

namespace QLBanHang.Modules.BanHang
{
    public class frmLookUp_MaVach : frmLookUpBaseMaVach
    {
        private GridColumn colMaVach;
        private GridColumn ColMaSanPham;
        private GridColumn ColTenSanPham;
        private GridColumn colDonViTinh;
        private GridColumn colTonKho;
        private GridColumn colTuoiTon;

        public frmLookUp_MaVach()
        {
            InitializeComponent();
        }

        public frmLookUp_MaVach(bool isMultiSelect, List<ChungTuBanHangChiTietHangHoaInfor> liChungTuBanHangChiTietHangHoa, bool showTonKho)
            : base(isMultiSelect, liChungTuBanHangChiTietHangHoa)
        {
            InitializeComponent();
            colTonKho.Visible = showTonKho;
        }

        protected override string[] LookUpPropertyNames()
        {
            return new []{"MaVach"};
        }

        public string SearchValue
        {
            get { return txtLookUp.Text; }
        }

        public int ResultCount
        {
            get { return listResult.Count; }
        }

        private void InitializeComponent()
        {
            this.colMaVach = new GridColumn();
            this.ColMaSanPham = new GridColumn();
            this.ColTenSanPham = new GridColumn();
            this.colDonViTinh = new GridColumn();
            this.colTonKho = new GridColumn();
            this.colTuoiTon = new GridColumn();
            
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLookUp
            // 
            this.txtLookUp.Size = new System.Drawing.Size(1980, 21);
            // 
            // grvLookUp
            // 
            this.grvLookUp.Columns.AddRange(new GridColumn[] {
            this.colMaVach,
            this.ColMaSanPham,
            this.ColTenSanPham,
            this.colDonViTinh,
            this.colTonKho,
            this.colTuoiTon});
            //this.grvLookUp.RowHeadersWidth = 25;
            //this.grvLookUp.Size = new System.Drawing.Size(774, 393);
            // 
            // colMaVach
            // 
            this.colMaVach.FieldName = "MaVachMark";
            this.colMaVach.Caption = "Mã vạch";
            this.colMaVach.Name = "colMaVach";
            this.colMaVach.OptionsColumn.AllowEdit = false;
            this.colMaVach.OptionsColumn.ReadOnly = true;
            this.colMaVach.Visible = true;

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
            //this.ColTenSanPham.Width = 330;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.FieldName = "DonViTinh";
            this.colDonViTinh.Caption = "Đơn vị tính";
            this.colDonViTinh.Name = "colDonViTinh";
            this.colDonViTinh.OptionsColumn.AllowEdit = false;
            this.colDonViTinh.OptionsColumn.ReadOnly = true;
            this.colDonViTinh.Visible = true;
            // 
            // colTonKho
            // 
            this.colTonKho.FieldName = "SoLuong";
            this.colTonKho.Caption = "Tồn kho";
            this.colTonKho.Name = "colTonKho";
            this.colTonKho.OptionsColumn.AllowEdit = false;
            this.colTonKho.OptionsColumn.ReadOnly = true;
            this.colTonKho.Visible = true;
            // 
            // colTuoiTon
            // 
            this.colTuoiTon.FieldName = "TuoiTon";
            this.colTuoiTon.Caption = "Tuổi tồn";
            this.colTuoiTon.Name = "colTuoiTon";
            this.colTuoiTon.OptionsColumn.AllowEdit = false;
            this.colTuoiTon.OptionsColumn.ReadOnly = true;
            this.colTuoiTon.Visible = true;
            // 
            // frmLookUp_MaVach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(780, 457);
            this.Name = "frmLookUp_MaVach";
            this.Text = "Tìm kiếm nhanh mã vạch";
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}
