using System;
using System.Windows.Forms;
using QLBH.Common;

namespace QLBanHang.Modules.BanHang
{
    public partial class frm_BangGiaHienTai_KhuyenMai : Form
    {
        int IdChiTietBangGia = 0;
        int IdKhuyenMai = 0;
        public frm_BangGiaHienTai_KhuyenMai(int pIdChiTietBangGia)
        {
            InitializeComponent();
            IdChiTietBangGia = pIdChiTietBangGia;
        }

        private void frm_BangGiaHienTai_KhuyenMai_Load(object sender, EventArgs e)
        {
            gvKM.DataSource = DBTools.getData("tbl_KhuyenMai", String.Format("select * from tbl_KhuyenMai where IdChiTietBangGia={0}", IdChiTietBangGia)).Tables["tbl_KhuyenMai"];
        }

        private void gvKM_SelectionChanged(object sender, EventArgs e)
        {
            IdKhuyenMai = Common.IntValue(gvKM.CurrentRow.Cells["colIdKhuyenMai"].Value);
            gv.DataSource = DBTools.getData("tbl_KhuyenMai_Chitiet", String.Format(@"select kmct.*, sp.MaSanPham, sp.TenSanPham, dvt.TenDonViTinh from tbl_KhuyenMai_Chitiet kmct
                inner join tbl_SanPham sp on kmct.IdSanPham = sp.IdSanPham
                inner join tbl_DM_DonViTinh dvt on dvt.IdDonViTinh = sp.IdDonViTinh
                where IdKhuyenMai={0}", IdKhuyenMai)).Tables["tbl_KhuyenMai_Chitiet"];
        }

        private void cmdDong_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}