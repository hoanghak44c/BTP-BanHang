using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using QLBH.Common;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.HeThong.Infors;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBH_BangGiaBanHang_TonCTiet : DevExpress.XtraEditors.XtraForm
    {
        private BangGiaBanChiTietBCInfor bgInfor = new BangGiaBanChiTietBCInfor();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();

        public frmBH_BangGiaBanHang_TonCTiet()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        public frmBH_BangGiaBanHang_TonCTiet(BangGiaBanChiTietBCInfor bgInfor)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.bgInfor = bgInfor;
        }

        private void frm_ThietLapKM_Load(object sender, EventArgs e)
        {
            LoadSanPhamInfor();
            LoadGiaSanPham();
            LoadTonChiTiet();
        }

        private void LoadSanPhamInfor()
        {
            txtSanPham.Text = bgInfor.MaSanPham + " - " + bgInfor.TenSanPham;
            txtDonViTinh.Text = bgInfor.TenDonViTinh;
            txtVAT.Text = Common.Double2Str(bgInfor.TyLeVAT);
        }

        private void LoadGiaSanPham()
        {
            List<ItemGiaBanInfor> liGiaBan = BangGiaDataProvider.Instance.LoadGiaSanPhamTheoTrungTam(bgInfor.MaSanPham);
            gChinhSach.DataSource = liGiaBan;
            gvChinhSach.ExpandAllGroups();
        }

        private void LoadTonChiTiet()
        {
            int soTon = CommonFuns.Instance.GetSoTon();
            List<ItemTonKhoInfor> liTonKho = BanHangDataProvider.Instance.LoadTonKhoTheoTrungTam(bgInfor.IdSanPham, soTon);
            gTonKho.DataSource = liTonKho;
            gvTonKho.ExpandAllGroups();

        }

        private void cmdDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ThietLapKM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.cmdDong_Click(sender, e);
        }
    }
}