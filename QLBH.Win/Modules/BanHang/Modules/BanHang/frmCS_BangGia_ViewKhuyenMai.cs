using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using QLBH.Common;
using QLBH.Common.Objects;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common.Providers;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmCS_BangGia_ViewKhuyenMai : DevExpress.XtraEditors.XtraForm
    {
        private int IdKhoSelected = Declare.IdKho;
        List<BangGiaChinhSachInfor> liChinhSach = new List<BangGiaChinhSachInfor>();
        BangGiaChiTietInfor BangGiaChiTiet = new BangGiaChiTietInfor();
        public List<ChungTuBanHangChiTietInfor> liSanPhamKemSelected = new List<ChungTuBanHangChiTietInfor>();
        public List<ChungTuBanHangChiTietInfor> liSanPhamKMSelected = new List<ChungTuBanHangChiTietInfor>();
        public BangGiaChinhSachInfor ChinhSachSelected = new BangGiaChinhSachInfor();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();

        public frmCS_BangGia_ViewKhuyenMai()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        public frmCS_BangGia_ViewKhuyenMai(List<BangGiaChinhSachInfor> lics, BangGiaChiTietInfor bgct)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.liChinhSach = lics;
            this.BangGiaChiTiet = bgct;
        }

        private void frm_ThietLapKM_Load(object sender, EventArgs e)
        {
            LoadSanPhamInfor();
            LoadDSChinhSach();
        }

        private void LoadSanPhamInfor()
        {
            txtSanPham.Text = BangGiaChiTiet.MaSanPham + " - " + BangGiaChiTiet.TenSanPham + "[" + BangGiaChiTiet.DonViTinh + "]";
            txtGiaBan.Text = Common.Double2Str(BangGiaChiTiet.DonGiaCoVAT);
        }

        private void LoadDSChinhSach()
        {
            gChinhSach.DataSource = new BindingList<BangGiaChinhSachInfor>(liChinhSach);
        }

        private void cmdDong_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        private void frm_ThietLapKM_KeyDown(object sender, KeyEventArgs e)
        {
 
        }

  
        private void gvKhuyenMai_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvKhuyenMai.FocusedRowHandle <0) return;
            BangGiaADKhuyenMaiInfor bgkm = (BangGiaADKhuyenMaiInfor)gvKhuyenMai.GetRow(gvKhuyenMai.FocusedRowHandle);

            gKMChiTiet.DataSource = new BindingList<BangGiaADKhuyenMaiChiTietInfor>(bgkm.ListKhuyenMaiChiTiet)
            {
                AllowEdit = true,
                AllowNew = true,
                AllowRemove = true,
                RaiseListChangedEvents = true
            };
        }

        private void gvChinhSach_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvChinhSach.FocusedRowHandle < 0) return;

            ChinhSachSelected = (BangGiaChinhSachInfor)gvChinhSach.GetRow(gvChinhSach.FocusedRowHandle);

            if (ChinhSachSelected == null) return;

            gKhuyenMai.DataSource = new BindingList<BangGiaADKhuyenMaiInfor>();
            gKMChiTiet.DataSource = new BindingList<BangGiaADKhuyenMaiChiTietInfor>();

            //get khuyen mai
            List<BangGiaADKhuyenMaiInfor> lstKM = KhuyenMaiDataProvider.Instance.GetAllBangGiaKhuyenMaiADInfors(ChinhSachSelected.IdDKMua);
            for (int i = 0; i < lstKM.Count; i++)
            {
                lstKM[i].ListKhuyenMaiChiTiet =
                    KhuyenMaiDataProvider.Instance.GetAllKhuyenMaiChiTietADTTInfors(lstKM[i].IdKhuyenMai, IdKhoSelected,
                                                                                  BangGiaChiTiet.DonGiaCoVAT);
            }

            gKhuyenMai.DataSource = new BindingList<BangGiaADKhuyenMaiInfor>(lstKM);
            gKhuyenMai.Focus();
            if (lstKM.Count > 0)
            {
                gvKhuyenMai.SelectRow(0);
            }

            List<BangGiaADDKMuaInfor> liDKMua = KhuyenMaiDataProvider.Instance.GetBangGiaADDKMuaInforsById(ChinhSachSelected.IdDKMua);
            if (liDKMua != null && liDKMua.Count > 0)
            {
                double dt = (liDKMua[0].SoDiemThuong > 0)
                                ? liDKMua[0].SoDiemThuong
                                : (liDKMua[0].TyLeDiemThuong > 0
                                       ? liDKMua[0].TyLeDiemThuong*BangGiaChiTiet.DonGiaCoVAT/100
                                       : 0);
                string strDiemThuong = "0";
                if (dt != 0)
                {
                    strDiemThuong = Common.Double2Str(dt);
                    if (liDKMua[0].TyLeDiemThuong > 0)
                        strDiemThuong = String.Format("{0} ({1}%)", strDiemThuong, liDKMua[0].TyLeDiemThuong);
                    else
                    {
                        if (BangGiaChiTiet.DonGiaCoVAT > 0)
                            strDiemThuong = String.Format("{0} ({1}%)", strDiemThuong, Common.DoubleValueInt(dt * 100 / liDKMua[0].TyLeDiemThuong * BangGiaChiTiet.DonGiaCoVAT));
                        else
                            strDiemThuong = String.Format("{0}", strDiemThuong);
                    }
                }
                    
                txtDiemThuong.Text = strDiemThuong;
                txtTyleCK.Text = Common.Double2Str(liDKMua[0].TyLeChietKhau);
                txtTienCK.Text = Common.Double2Str(liDKMua[0].TienChietKhau);
            }
            lblSieuThiAD.Text = ChinhSachSelected.LoaiDoiTuong == 1
                              ? "chỉ áp dụng Online"
                              : (String.IsNullOrEmpty(ChinhSachSelected.SieuThiAD) || ChinhSachSelected.SieuThiAD.Trim().Equals("Tất cả")
                                     ? "tại tất cả siêu thị Trần Anh"
                                     : String.Format("tại siêu thị {0}", ChinhSachSelected.SieuThiAD));
        }
    }
}