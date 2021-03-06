using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc;
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
    public partial class frmBH_ChonChinhSach_BanHang : DevExpress.XtraEditors.XtraForm
    {
        private int IdKhoSelected = Declare.IdKho;
        private int IdTTamSelected = Declare.IdTrungTam;
        private List<BangGiaADBankInfor> liThanhToan = new List<BangGiaADBankInfor>();
        private List<BangGiaBanChiTietInfor> liBangGiaBan = new List<BangGiaBanChiTietInfor>();
        private List<BangGiaChinhSachInfor> liChinhSach = new List<BangGiaChinhSachInfor>();
        public List<BangGiaChinhSachInfor> liChinhSachDefault = new List<BangGiaChinhSachInfor>();
        private List<BangGiaADSPKemInfor> liSPKemDefault = new List<BangGiaADSPKemInfor>();
        private List<BangGiaADKhuyenMaiChiTietInfor> liKMCTietDefault = new List<BangGiaADKhuyenMaiChiTietInfor>();
        private ChungTuBanHangChiTietInfor CTu = new ChungTuBanHangChiTietInfor();
        public List<ChungTuBanHangChiTietInfor> liSanPhamSelected = new List<ChungTuBanHangChiTietInfor>();
        public BangGiaChinhSachInfor ChinhSachSelected = new BangGiaChinhSachInfor();
        public int SoVoucherSelected = 1;
        private int SoVoucherMax = 1;
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();

        private string strMuaKem = "Mua kèm";
        private string strKhuyenMai = "Khuyến Mại";
        private bool IsLoadCK = false;
        private bool DatTruoc = false;
        public bool ValidCSG = true;//để chặn không cho phép 2 chính sách giá cùng trên đơn hàng
        private int Chose = 0;

        public frmBH_ChonChinhSach_BanHang()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        //public frmBH_ChonChinhSach_BanHang(List<BangGiaChinhSachInfor> lics, ChungTuBanHangChiTietInfor ctu, int idKho, int idTrungTam)
        //{
        //    InitializeComponent();
        //    Common.LoadStyle(this);
        //    this.CTu = ctu;
        //    this.IdKhoSelected = idKho;
        //    this.IdTTamSelected = idTrungTam;

        //    this.liChinhSach = lics;
        //}

        public frmBH_ChonChinhSach_BanHang(List<BangGiaChinhSachInfor> lics, ChungTuBanHangChiTietInfor ctu, int idKho, int idTrungTam, bool datTruoc)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.CTu = ctu;
            this.IdKhoSelected = idKho;
            this.IdTTamSelected = idTrungTam;
            this.liChinhSach = new List<BangGiaChinhSachInfor>();
            this.liChinhSachDefault = new List<BangGiaChinhSachInfor>();
            foreach (BangGiaChinhSachInfor cs in lics)
            {
                if (cs.MacDinh == 1)
                {
                    this.liChinhSachDefault.Add(cs);
                    string ghichu = String.Format("{0} (mặc định)", cs.SoChinhSach);

                    //load thanh toan
                    foreach (BangGiaADBankInfor tt in cs.ListBangGiaADThanhToan)
                    {
                        tt.GhiChu = ghichu;
                        liThanhToan.Add(tt);
                    }

                    //load san pham kem default
                    List<BangGiaADSPKemInfor> lstSPK = KhuyenMaiDataProvider.Instance.GetAllSanPhamKemADInfors(cs.IdDKMua, IdKhoSelected);
                    foreach (BangGiaADSPKemInfor spk in lstSPK)
                    {
                        spk.GhiChu = ghichu;
                        liSPKemDefault.Add(spk);
                    }

                    //load khuyen mai default => load KM dau tien
                    List<BangGiaADKhuyenMaiInfor> lstKM = KhuyenMaiDataProvider.Instance.GetAllBangGiaKhuyenMaiADInfors(cs.IdDKMua);
                    if (lstKM.Count > 0)
                    {
                        List<BangGiaADKhuyenMaiChiTietInfor> lstKMCTiet = KhuyenMaiDataProvider.Instance.GetAllKhuyenMaiChiTietADInfors(lstKM[0].IdKhuyenMai, IdKhoSelected, CTu.DonGiaCoVat);
                        foreach (BangGiaADKhuyenMaiChiTietInfor kmct in lstKMCTiet)
                        {
                            kmct.ChinhSachKhuyenMai = ghichu;
                            liKMCTietDefault.Add(kmct);
                        }
                    }
                }                    
                else
                    this.liChinhSach.Add(cs);
            }
            this.DatTruoc = datTruoc;
        }

        private bool ValidKhuyenMai()
        {
            this.SoVoucherSelected = 1;
            if (txtSoVoucher.Visible)
            {
                int soVoucher = Common.IntValue(txtSoVoucher.Text);
                if (soVoucher == 0 || soVoucher > this.SoVoucherMax)
                {
                    MessageBox.Show(String.Format("Số Voucher phải trong khoảng từ 1 đến {0}.", this.SoVoucherMax));
                    txtSoVoucher.Focus();
                    return false;
                }
                else
                {
                    this.SoVoucherSelected = soVoucher;
                }
            }
            if (CTu.SoLuong > 1 && (CTu.ChinhSach != null && CTu.ChinhSach.IdChinhSach != ChinhSachSelected.IdChinhSach || CTu.ChinhSach == null))
            {
                MessageBox.Show("Trên một đơn hàng không thể áp dụng 2 chính sách giá khác nhau được!");
                return false;
            }
            //kiem tra san pham mua kem
            if (gSanPhamKem.DataSource != null)
            {
                //kiem tra gia tri hang chinh + hang kem
                //List<BangGiaChinhSachInfor> lstCS = new List<BangGiaChinhSachInfor>();
                //if (ChinhSachSelected != null) lstCS.Add(ChinhSachSelected);
                //if (liChinhSachDefault != null && liChinhSachDefault.Count > 0)
                //    lstCS.AddRange(liChinhSachDefault);

                double tongTien = CTu.ThanhTien;//san pham chinh
                foreach (BangGiaADSPKemInfor spk in (BindingList<BangGiaADSPKemInfor>)gSanPhamKem.DataSource)
                {
                    int count = 0;
                    foreach (ChungTuBanHangChiTietInfor ct in liSanPhamSelected)
                    {
                        if ((ct.LoaiHangKem == 1) &&
                            (spk.GiaMuaTu == 0 || (spk.GiaMuaTu > 0) && (spk.GiaMuaTu <= ct.DonGiaCoVat)) &&
                            (spk.GiaMuaDen == 0 || (spk.GiaMuaDen > 0) && (spk.GiaMuaDen >= ct.DonGiaCoVat)) &&
                            (spk.MaHangKem == null ||
                             spk.LoaiHangKem == 0 && spk.MaHangKem.Equals(ct.LinhVuc) && (String.IsNullOrEmpty(spk.MaHangSX) || spk.MaHangSX.Equals(ct.Hang)) ||
                             spk.LoaiHangKem == 1 && spk.MaHangKem.Equals(ct.Nganh) && (String.IsNullOrEmpty(spk.MaHangSX) || spk.MaHangSX.Equals(ct.Hang)) ||
                             spk.LoaiHangKem == 2 && spk.MaHangKem.Equals(ct.Loai) && (String.IsNullOrEmpty(spk.MaHangSX) || spk.MaHangSX.Equals(ct.Hang)) ||
                             spk.LoaiHangKem == 3 && spk.MaHangKem.Equals(ct.Chung) && (String.IsNullOrEmpty(spk.MaHangSX) || spk.MaHangSX.Equals(ct.Hang)) ||
                             spk.LoaiHangKem == 4 && spk.MaHangKem.Equals(ct.Nhom) && (String.IsNullOrEmpty(spk.MaHangSX) || spk.MaHangSX.Equals(ct.Hang)) ||
                             spk.LoaiHangKem == 5 && spk.MaHangKem.Equals(ct.Model) && (String.IsNullOrEmpty(spk.MaHangSX) || spk.MaHangSX.Equals(ct.Hang)) ||
                             spk.LoaiHangKem == 6 && spk.MaHangKem.Equals(ct.MaSanPham)))/* &&
                             (spk.MaHangSX == null || spk.MaHangSX.Equals("") || !spk.MaHangSX.Equals("") &&
                             spk.MaHangSX.Equals(ct.Hang)))*/
                        {
                            count += ct.SoLuong;
                            if (ChinhSachSelected == null || !String.Format(",{0},", ChinhSachSelected.MatHangKhongApDung).Contains(String.Format(",{0},", ct.IdSanPham)))
                                tongTien += ct.ThanhTien;//san pham kem

                            ct.TyleChietKhau = spk.TyLeChietKhau;
                            double tienKM = spk.TyLeChietKhau == 0
                                                ? spk.TienChietKhau
                                                : spk.TyLeChietKhau * ct.DonGiaCoVat * ct.SoLuong / 100;
                            double tienCK = spk.TienChietKhau == 0
                                                   ? tienKM
                                                   : Common.MinValues(spk.TienChietKhau, tienKM);
                            ct.TienChietKhau = tienCK/** ct.SoLuong*/ / (1 + ct.TyleVAT / 100);
                            ct.TienSauChietKhau = ct.DonGia * ct.SoLuong - ct.TienChietKhau;
                            ct.TienVAT = ct.TienSauChietKhau * ct.TyleVAT / 100;
                            ct.ThanhTien = ct.DonGiaCoVat * ct.SoLuong - tienCK;
                            ct.TyLePhanBo = spk.TyLePhanBo/100;//lay ty le phan bo
                            if (!DatTruoc)
                            {
                                BangGiaBanChiTietInfor bg = liBangGiaBan.Find(delegate(BangGiaBanChiTietInfor match)
                                                                                  {
                                                                                      return
                                                                                          match.MaSanPham.Equals(
                                                                                              ct.MaSanPham);
                                                                                  });
                                if (bg != null && bg.ChietKhau != 1 && GetTonConLai(bg) < 0)
                                {
                                    MessageBox.Show(string.Format("Mã hàng {0} không có đủ hàng trong kho!",
                                                                  ct.MaSanPham));
                                    return false;
                                    //bg.TonKho -= ct.SoLuong;
                                    //if (bg.TonKho < 0)
                                    //{
                                    //    MessageBox.Show(string.Format("Mã hàng {0} không có đủ hàng trong kho!",
                                    //                                  ct.MaSanPham));
                                    //    return false;
                                    //}
                                }
                            }
                        }
                    }
                    if (spk.SoLuong > 0 && count != spk.SoLuong)
                    {
                        MessageBox.Show("Phải nhập đầy đủ mã sản phẩm mua kèm");
                        return false;
                    }
                }

                if (ChinhSachSelected != null && tongTien < ChinhSachSelected.GiaTriMuaToiThieu)
                {
                    MessageBox.Show(
                        String.Format(
                            "Tổng giá trị mua hàng được tính là [{0}].\nChưa đạt giá trị mua tối thiểu [{1}]",
                            Common.Double2Str(tongTien), Common.Double2Str(ChinhSachSelected.GiaTriMuaToiThieu)));
                    return false;                        
                }
            }

            foreach (ChungTuBanHangChiTietInfor ct in liSanPhamSelected)
            {
                ct.DaInHoaDon = 0;
            }
            //Kiem tra san pham khuyen mai
            if (gKMChiTiet.DataSource != null)
            {
                foreach (BangGiaADKhuyenMaiChiTietInfor kmct in (BindingList<BangGiaADKhuyenMaiChiTietInfor>)gKMChiTiet.DataSource)
                {
                    int count = 0;
                    List<ChungTuBanHangChiTietInfor> lct =
                        liSanPhamSelected.FindAll(delegate(ChungTuBanHangChiTietInfor match)
                        {
                            return (match.LoaiHangKem == 0) &&
                                (kmct.MaHangKM == null ||
                                 kmct.LoaiHangKM == 0 && kmct.MaHangKM.Equals(match.LinhVuc) && (String.IsNullOrEmpty(kmct.MaHangSX) || kmct.MaHangSX.Equals(match.Hang)) ||
                                 kmct.LoaiHangKM == 1 && kmct.MaHangKM.Equals(match.Nganh) && (String.IsNullOrEmpty(kmct.MaHangSX) || kmct.MaHangSX.Equals(match.Hang)) ||
                                 kmct.LoaiHangKM == 2 && kmct.MaHangKM.Equals(match.Loai) && (String.IsNullOrEmpty(kmct.MaHangSX) || kmct.MaHangSX.Equals(match.Hang)) ||
                                 kmct.LoaiHangKM == 3 && kmct.MaHangKM.Equals(match.Chung) && (String.IsNullOrEmpty(kmct.MaHangSX) || kmct.MaHangSX.Equals(match.Hang)) ||
                                 kmct.LoaiHangKM == 4 && kmct.MaHangKM.Equals(match.Nhom) && (String.IsNullOrEmpty(kmct.MaHangSX) || kmct.MaHangSX.Equals(match.Hang)) ||
                                 kmct.LoaiHangKM == 5 && kmct.MaHangKM.Equals(match.Model) && (String.IsNullOrEmpty(kmct.MaHangSX) || kmct.MaHangSX.Equals(match.Hang)) ||
                                 kmct.LoaiHangKM == 6 && kmct.MaHangKM.Equals(match.MaSanPham));/* &&
                                (kmct.MaHangSX == null || kmct.MaHangSX.Equals("") ||
                                 !kmct.MaHangSX.Equals("") &&
                                 kmct.MaHangSX.Equals(match.Hang));*/
                        });
                    bool datruKM = false;
                    foreach (ChungTuBanHangChiTietInfor ct in lct)
                    {
                        ct.DaInHoaDon = 1;//danh dau da kiem tra
                        ct.CungDongDonHangChinh = kmct.InKemHD;
                        count += ct.SoLuong;
                        //BangGiaBanChiTietInfor bg = liBangGiaBan.Find(delegate(BangGiaBanChiTietInfor match)
                        //{
                        //    return match.MaSanPham.Equals(ct.MaSanPham);
                        //});
                        //if (bg != null)
                        //{
                        //    ct.NoKhuyenMai = bg.TonKho > ct.SoLuong ? 0 : (ct.SoLuong - bg.TonKho);
                        //}
                        if (!datruKM)
                        {
                            ct.TyleChietKhau = kmct.TyLeKM;
                            double tienKM = kmct.TyLeKM == 0 ? kmct.SoTienKM : kmct.TyLeKM * CTu.DonGiaCoVat / 100;
                            double tienCK = kmct.SoTienKM == 0 ? tienKM : Common.MinValues(kmct.SoTienKM, tienKM);
                            ct.TienChietKhau = Common.Int2Bool(kmct.ChietKhau) ? -tienCK/(1 + ct.TyleVAT / 100) : 0;
                            ct.TienSauChietKhau = ct.TienChietKhau;
                            ct.ThanhTien = Common.Int2Bool(kmct.ChietKhau) ? -tienCK : tienCK;
                            ct.TienVAT = ct.TyleVAT * ct.ThanhTien / (100 + ct.TyleVAT);
                            ct.TyLeThanhToan = kmct.TyLeThanhToan;
                            ct.ThanhTien = ct.ThanhTien * kmct.TyLeThanhToan / 100;
                            datruKM = true;
                        }
                    }
                    if ((count != kmct.SoLuong && kmct.NoKhuyenMai == 0 || count != kmct.TonKho && kmct.NoKhuyenMai > 0) && !DatTruoc)
                    {
                        MessageBox.Show("Sản phẩm khuyến mại không phù hợp!");
                        return false;
                    }
                }
                foreach (ChungTuBanHangChiTietInfor ct in liSanPhamSelected)
                {
                    if (ct.DaInHoaDon != 1 && ct.LoaiHangKem == 0)
                    {
                        MessageBox.Show(String.Format("Sản phẩm [{0} - {1}] không nằm trong danh sách khuyến mại", ct.MaSanPham, ct.TenSanPham));
                        return false;
                    }
                }
            }

            return true;
        }

        private void frm_ThietLapKM_Load(object sender, EventArgs e)
        {
            LoadSanPhamInfor();
            LoadDSChinhSach();
        }

        private void LoadSanPhamInfor()
        {
            txtSanPham.Text = CTu.MaSanPham + " - " + CTu.TenSanPham + "[" + CTu.DonViTinh + "]";
            txtGiaBan.Text = Common.Double2Str(CTu.ThanhTien);
        }

        private void LoadDSChinhSach()
        {            
            if (liChinhSach.Count > 0)
            {
                gChinhSach.DataSource = new BindingList<BangGiaChinhSachInfor>(liChinhSach); 
                if (liChinhSachDefault.Count > 0)
                {
                    gCSMacDinh.Enabled = false;
                    gCSMacDinh.DataSource = new BindingList<BangGiaChinhSachInfor>(liChinhSachDefault);
                }
                else
                {
                    xtabCSMacDinh.Visible = false;
                }
            }
            else if (liChinhSachDefault.Count > 0)
            {
                liChinhSach.Add(liChinhSachDefault[0]);
                xtabCSThuong.Text = "Chính sách mặc định";
                gChinhSach.DataSource = new BindingList<BangGiaChinhSachInfor>(liChinhSach);

                liChinhSachDefault.RemoveAt(0);
                if (liChinhSachDefault.Count > 0)
                {
                    gCSMacDinh.Enabled = false;
                    gCSMacDinh.DataSource = new BindingList<BangGiaChinhSachInfor>(liChinhSachDefault);
                }
                else
                {
                    xtabCSMacDinh.Visible = false;
                }

                //get sanpham mua kem
                gSanPhamKem.DataSource = new BindingList<BangGiaADSPKemInfor>(liSPKemDefault);
                xtraTabControl1.SelectedTabPage = xtraTabPage1;

                gThanhToan.DataSource = new BindingList<BangGiaADBankInfor>(liThanhToan);
                if (liSPKemDefault.Count == 0 && liThanhToan.Count > 0)
                {
                    xtraTabControl1.SelectedTabPage = xtraTabPage2;
                }

                //get khuyen mai
                gKMChiTiet.DataSource = new BindingList<BangGiaADKhuyenMaiChiTietInfor>(liKMCTietDefault);
                LoadSanPhamBanKem();

                if (liSPKemDefault.Count == 0)
                    cmdDong.Visible = false;
            }
        }

        private void cmdDong_Click(object sender, EventArgs e)
        {
            if (Chose == 0)
            {
                if (CTu.SoLuong > 1 && CTu.ChinhSach != null)
                    ValidCSG = false;
                Chose = 2;

                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void cmdGhiKM_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidKhuyenMai())
                {
                    Chose = 1;
                    this.DialogResult = DialogResult.OK;
                }
                else if (liChinhSachDefault.Count > 0)
                {
                    if (MessageBox.Show("Chính sách mặc định đang có hiệu lực. Bạn có đồng ý áp dụng không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        this.ChinhSachSelected = null;
                        this.liSanPhamSelected = new List<ChungTuBanHangChiTietInfor>();
                        Chose = 1;
                        this.DialogResult = DialogResult.OK;
                    }                    
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        
        private void frm_ThietLapKM_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F7 && cmdGhiKM.Enabled)
                    this.cmdGhiKM_Click(sender, e);
                else if (e.KeyCode == Keys.F12 && cmdDong.Enabled)
                    this.cmdDong_Click(sender, e);
            }
            catch (System.Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        //private bool ExistMaSanPham(int loaiMH, string maMH, string maHSX)
        //{
        //    foreach (BangGiaADKhuyenMaiChiTietInfor dk in (BindingList<BangGiaADKhuyenMaiChiTietInfor>)gKMChiTiet.DataSource)
        //    {
        //        if (dk.LoaiHangKM == loaiMH && dk.MaHangKM.Equals(maMH) && dk.MaHangSX.Equals(maHSX))
        //            return true;
        //    }
        //    return false;
        //}

        private void gvKhuyenMai_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //if (gvKhuyenMai.FocusedRowHandle <0) return;
            List<BangGiaADKhuyenMaiChiTietInfor> lstKMaiCTiet = new List<BangGiaADKhuyenMaiChiTietInfor>();
            lstKMaiCTiet.AddRange(liKMCTietDefault);

            BangGiaADKhuyenMaiInfor bgkm = (BangGiaADKhuyenMaiInfor)gvKhuyenMai.GetRow(gvKhuyenMai.FocusedRowHandle);

            if (bgkm != null)
            {
                foreach (BangGiaADKhuyenMaiChiTietInfor kmct in bgkm.ListKhuyenMaiChiTiet)
                {
                    kmct.ChinhSachKhuyenMai = String.Format("{0}", ChinhSachSelected.SoChinhSach);
                    lstKMaiCTiet.Add(kmct);
                }                
            }
            
            gKMChiTiet.DataSource = new BindingList<BangGiaADKhuyenMaiChiTietInfor>(lstKMaiCTiet)
            {
                AllowEdit = true,
                AllowNew = true,
                AllowRemove = true,
                RaiseListChangedEvents = true
            };
            LoadSanPhamBanKem();
        }

        private void gvChinhSach_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvChinhSach.FocusedRowHandle < 0 || !gChinhSach.Enabled) return;

            ChinhSachSelected = (BangGiaChinhSachInfor)gvChinhSach.GetRow(gvChinhSach.FocusedRowHandle);
            if (ChinhSachSelected  == null) return;

            gSanPhamKem.DataSource = new BindingList<BangGiaADSPKemInfor>();
            gKhuyenMai.DataSource = new BindingList<BangGiaADKhuyenMaiInfor>();
            gKMChiTiet.DataSource = new BindingList<BangGiaADKhuyenMaiChiTietInfor>();

            tsslCSGStatus.Text = "Ghi chú: " + ChinhSachSelected.GhiChu;

            //get sanpham mua kem
            List<BangGiaADSPKemInfor> lstSPKem = new List<BangGiaADSPKemInfor>();
            lstSPKem.AddRange(liSPKemDefault);

            List<BangGiaADSPKemInfor> lstSPK = KhuyenMaiDataProvider.Instance.GetAllSanPhamKemADInfors(ChinhSachSelected.IdDKMua, IdKhoSelected);
            foreach (BangGiaADSPKemInfor spk in lstSPK)
            {
                spk.GhiChu = String.Format("{0}", ChinhSachSelected.SoChinhSach);
                lstSPKem.Add(spk);
            }

            gSanPhamKem.DataSource = new BindingList<BangGiaADSPKemInfor>(lstSPKem);
            gSanPhamKem.Focus();

            //get thanh toan
            List<BangGiaADBankInfor> lstThanhToan = new List<BangGiaADBankInfor>();
            lstThanhToan.AddRange(liThanhToan);
            foreach (BangGiaADBankInfor tt in ChinhSachSelected.ListBangGiaADThanhToan)
            {
                tt.GhiChu = String.Format("{0}", ChinhSachSelected.SoChinhSach);
                lstThanhToan.Add(tt);
            }
            gThanhToan.DataSource = new BindingList<BangGiaADBankInfor>(lstThanhToan);

            if (lstSPKem.Count > 0 || lstThanhToan.Count == 0)
            {
                xtraTabControl1.SelectedTabPage = xtraTabPage1;
            }
            else if (lstThanhToan.Count > 0)
            {
                xtraTabControl1.SelectedTabPage = xtraTabPage2;                
            }

            //get khuyen mai
            List<BangGiaADKhuyenMaiInfor> lstKM = KhuyenMaiDataProvider.Instance.GetAllBangGiaKhuyenMaiADInfors(ChinhSachSelected.IdDKMua);
            for (int i = 0; i < lstKM.Count; i++)
            {
                lstKM[i].ListKhuyenMaiChiTiet = KhuyenMaiDataProvider.Instance.GetAllKhuyenMaiChiTietADInfors(lstKM[i].IdKhuyenMai, IdKhoSelected, CTu.DonGiaCoVat);
            }

            gKhuyenMai.DataSource = new BindingList<BangGiaADKhuyenMaiInfor>(lstKM);
            gKhuyenMai.Focus();
            if (lstKM.Count > 0)
            {
                gvKhuyenMai.SelectRow(0);
                gvKhuyenMai_FocusedRowChanged(sender, e);
            }
            else
            {
                gvKhuyenMai_FocusedRowChanged(sender, e);
            }
            LoadSanPhamBanKem();
            LoadChinhSachInfor();
        }

        private void LoadChinhSachInfor()
        {
            lblSoVoucher.Visible = false;
            txtSoVoucher.Visible = false;

            string giaBan = Common.Double2Str(CTu.ThanhTien);
            if (ChinhSachSelected.ListBangGiaADDKMua.Count > 0)
            {
                BangGiaADDKMuaInfor dkMua = ChinhSachSelected.ListBangGiaADDKMua[0];
                if (dkMua.TyLeChietKhau != 0)
                    giaBan += String.Format("[TLệ CKhấu({0}%)]",dkMua.TyLeChietKhau);
                if (dkMua.TienChietKhau != 0)
                    giaBan += String.Format("[Tiền CKhấu({0})]",Common.Double2Str(dkMua.TienChietKhau));

                txtGiaBan.Text = giaBan;

                if (ChinhSachSelected.ListBangGiaADDKMua[0].SoLuongToiDaCK > 1)
                {
                    lblSoVoucher.Visible = true;
                    txtSoVoucher.Visible = true;

                    txtSoVoucher.Text = "1";
                    this.SoVoucherMax = ChinhSachSelected.ListBangGiaADDKMua[0].SoLuongToiDaCK;
                }
            }            
        }

        private void gvSanPhamKem_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (gvSanPhamKem.FocusedRowHandle < 0) return;
            BangGiaADSPKemInfor bgct = (BangGiaADSPKemInfor)gvSanPhamKem.GetRow(gvSanPhamKem.FocusedRowHandle);
            LoadSanPhamBanKem();
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            InputDataFromCode(txtMaSanPham.Text.Trim());
        }

        private void txtMaSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                InputDataFromCode(txtMaSanPham.Text.Trim());
            }
        }

        private void txtMaSanPham_Enter(object sender, EventArgs e)
        {
            this.txtMaSanPham.Focus();
            this.txtMaSanPham.SelectAll();
        }

        private void LoadSanPhamBanKem()
        {            
            liSanPhamSelected = new List<ChungTuBanHangChiTietInfor>();
            gSanPham.DataSource = new BindingList<ChungTuBanHangChiTietInfor>(liSanPhamSelected);
            //foreach (ChungTuBanHangChiTietInfor ct in (BindingList<ChungTuBanHangChiTietInfor>)gSanPham.DataSource)
            //{
            //    if (ct.LoaiHangKem==1)
            //    {
            //        ((BindingList<ChungTuBanHangChiTietInfor>) gSanPham.DataSource).Remove(ct);
            //    }
            //}

            foreach (BangGiaADSPKemInfor spk in (BindingList<BangGiaADSPKemInfor>)gSanPhamKem.DataSource)
            {
                if (spk.LoaiHangKem == 6)//neu la san pham va co du ton
                {
                    if (spk.TrangThaiTon == 1)
                    {
                        BangGiaBanChiTietInfor spb;
                        spb = liBangGiaBan.Find(delegate(BangGiaBanChiTietInfor match)
                                                    {
                                                        return (match.MaSanPham.Equals(spk.MaHangKem));
                                                    });
                        if (spb == null)
                        {
                            spb = BangGiaDataProvider.Instance.GetGiaBan(IdTTamSelected, IdKhoSelected, spk.MaHangKem);
                        }

                        if (spb != null)
                        {
                            liBangGiaBan.Add(spb);
                            //add san pham ban
                            ChungTuBanHangChiTietInfor ct = BanHangDataProvider.Instance.ConvertBG2SanPhamBan(spb);
                            ct.Hang = spk.MaHangSX;
                            ct.LoaiHangKem = 1;
                            ct.TenLoaiHangKem = Declare.DescHangKem;
                            ct.SoLuong = spk.SoLuong;
                            ct.IdSanPhamBan = CTu.IdSanPham;
                            ct.TenSanPhamBan = CTu.TenSanPham;
                            ct.TyleChietKhau = spk.TyLeChietKhau;
                            double tienKM = spk.TyLeChietKhau == 0
                                                ? spk.TienChietKhau
                                                : spk.TyLeChietKhau*ct.DonGiaCoVat*ct.SoLuong/100;
                            double tienCK = spk.TienChietKhau == 0
                                                   ? tienKM
                                                   : Common.MinValues(spk.TienChietKhau, tienKM);
                            ct.TienChietKhau = tienCK/**ct.SoLuong*//(1 + ct.TyleVAT/100);
                            ct.TienSauChietKhau = ct.DonGia*ct.SoLuong - ct.TienChietKhau;
                            ct.TienVAT = ct.TienSauChietKhau*ct.TyleVAT/100;
                            ct.ThanhTien = ct.DonGiaCoVat*ct.SoLuong - tienCK;
                            ct.TyLePhanBo = spk.TyLePhanBo/100;
                            ct.SoLuongOld = ct.SoLuong;

                            ((BindingList<ChungTuBanHangChiTietInfor>) gSanPham.DataSource).Add(ct);
                        }
                        else
                        {
                            spk.GhiChu = "Chưa có giá";
                        }
                    }
                }
            }
            
            if (gKMChiTiet.DataSource == null) return;
            
            foreach (BangGiaADKhuyenMaiChiTietInfor kmct in (BindingList<BangGiaADKhuyenMaiChiTietInfor>)gKMChiTiet.DataSource)
            {
                //con ton hoac het ton nhung no khuyen mai
                if (kmct.LoaiHangKM == 6)
                {
                    //if (kmct.NoKhuyenMai == 0 || kmct.NoKhuyenMai > 0 && kmct.HetTonDungKM == 0 || DatTruoc) //neu la san pham
                    //{
                        BangGiaBanChiTietInfor spb;
                        spb = liBangGiaBan.Find(delegate(BangGiaBanChiTietInfor match)
                                                    {
                                                        return (match.MaSanPham.Equals(kmct.MaHangKM));
                                                    });
                        if (spb == null)
                        {
                            spb = BangGiaDataProvider.Instance.GetGiaBan(IdTTamSelected, IdKhoSelected, kmct.MaHangKM);

                        }

                        if (spb != null)
                        {
                            liBangGiaBan.Add(spb);
                            //add san pham ban
                            ChungTuBanHangChiTietInfor ct = BanHangDataProvider.Instance.ConvertBG2SanPhamKM(spb);
                            ct.CungDongDonHangChinh = kmct.InKemHD;
                            ct.Hang = kmct.MaHangSX;
                            ct.LoaiHangKem = 0;
                            ct.TenLoaiHangKem = Declare.DescKhuyenMai;
                            ct.SoLuong = DatTruoc ? kmct.SoLuong : kmct.SoLuong - kmct.NoKhuyenMai;
                            ct.NoKhuyenMai = DatTruoc ? 0 : kmct.NoKhuyenMai;
                            ct.IdSanPhamBan = CTu.IdSanPham;
                            ct.TenSanPhamBan = CTu.TenSanPham;
                            ct.TyleChietKhau = kmct.TyLeKM;
                            ct.TyleVAT = Common.Int2Bool(kmct.ChietKhau) ? CTu.TyleVAT/*spb.TyLeVAT*/ : 0;
                            double tienKM = kmct.TyLeKM == 0 ? kmct.SoTienKM : kmct.TyLeKM * CTu.DonGiaCoVat / 100;
                            double tienCK = kmct.SoTienKM == 0 ? tienKM : Common.MinValues(kmct.SoTienKM, tienKM);
                            ct.TienChietKhau = Common.Int2Bool(kmct.ChietKhau) ? -tienCK/(1 + ct.TyleVAT/100) : 0;
                            ct.TienSauChietKhau = ct.TienChietKhau;
                            ct.ThanhTien = Common.Int2Bool(kmct.ChietKhau) ? -tienCK : tienCK;
                            ct.TienVAT = ct.TyleVAT*ct.ThanhTien/(100 + ct.TyleVAT);
                            ct.TyLeThanhToan = kmct.TyLeThanhToan;
                            ct.ThanhTien = ct.ThanhTien * kmct.TyLeThanhToan / 100;
                            ct.GhiChu = Common.Int2Bool(kmct.ChietKhau)
                                            ? "CK"
                                            : (DatTruoc ? "Đặt trước" : (ct.NoKhuyenMai > 0 ? "Nợ khuyến mại" : ""));

                            ct.SoLuongOld = ct.SoLuong;
                            ct.SoLuongKhuyenMai = kmct.SoLuongOld;
                            ((BindingList<ChungTuBanHangChiTietInfor>) gSanPham.DataSource).Add(ct);
                        }
                        else
                        {
                            kmct.GhiChu = "Chưa có giá";
                        }
                    //}
                }
            }
        }

        private void InputDataFromCode(string code)
        {
            try
            {
                DMSanPhamBriefInfo sp = DmSanPhamProvider.GetSanPhamBriefByNSDMa(code, nguoiDung.IdNhomNguoiDung);
                if (sp == null)
                {
                    frmLookUp_HangHoa frm = new frmLookUp_HangHoa(false,
                                                                  (Common.Int2Bool(nguoiDung.SupperUser)
                                                                       ? -1
                                                                       : nguoiDung.IdNhomNguoiDung), 1, -1);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        sp = frm.SelectedItem;
                    }
                }

                if (sp != null)
                {
                    BangGiaBanChiTietInfor spb;
                    spb = liBangGiaBan.Find(delegate(BangGiaBanChiTietInfor match)
                                                {
                                                    return (match.MaSanPham.Equals(code));
                                                });
                    if (spb == null)
                    {
                        spb = BangGiaDataProvider.Instance.GetGiaBan(IdTTamSelected, IdKhoSelected, sp.MaSanPham);
                    }

                    if (spb == null)
                    {
                        MessageBox.Show("Giá chưa thiết lập!");
                        return;
                    }
                    else if (!DatTruoc && spb.ChietKhau != 1 && GetTonConLai(spb) <= 0)
                    {
                        MessageBox.Show("Hàng đã hết tồn kho!");
                        return;                        
                    }

                    liBangGiaBan.Add(spb);
                    int isHangKem = (rdHangBanKem.Checked ? 1 : 0);
                    string tenHangKem = (rdHangBanKem.Checked ? strMuaKem : strKhuyenMai);
                    ChungTuBanHangChiTietInfor ctu = liSanPhamSelected.Find(delegate(ChungTuBanHangChiTietInfor match)
                                                                                {
                                                                                    return (match.MaSanPham.Equals(spb.MaSanPham) && match.LoaiHangKem == isHangKem);
                                                                                });
                    if (ctu != null)
                    {
                        ctu.SoLuong += 1;
                        ctu.TienSauChietKhau += spb.DonGiaChuaVAT;
                        ctu.TienVAT += spb.TienVAT;
                        ctu.ThanhTien += spb.DonGiaCoVAT;
                        ctu.ThuongNong += spb.ThuongNong;
                        ctu.NoKhuyenMai = (spb.TonKho >= ctu.SoLuong || DatTruoc || rdHangBanKem.Checked) ? 0 : ctu.SoLuong - spb.TonKho;
                        ctu.GhiChu = Common.Int2Bool(spb.ChietKhau) ? "CK" : (ctu.NoKhuyenMai > 0 ? "Nợ khuyến mại" : "");
                        ctu.SoLuongOld = ctu.SoLuong;
                        
                        ((BindingList<ChungTuBanHangChiTietInfor>) gSanPham.DataSource).ResetBindings();
                    }
                    else
                    {
                        //add san pham ban
                        ChungTuBanHangChiTietInfor ct = null;
                        if (rdHangBanKem.Checked)
                            ct = BanHangDataProvider.Instance.ConvertBG2SanPhamBan(spb);
                        else
                        {
                            ct = BanHangDataProvider.Instance.ConvertBG2SanPhamKM(spb);
                            ct.TyleVAT = Common.Int2Bool(spb.ChietKhau) ? spb.TyLeVAT : 0;
                            //if (liSanPhamSelected.Exists(delegate (ChungTuBanHangChiTietInfor match)
                            //                                 {
                            //                                     return
                            //                                         match.MaSanPham.Equals(ct.MaSanPham) && match.LoaiHangKem == 0;
                            //                                 }))
                            //{
                            //    ct.TyleChietKhau = 0;
                            //}
                        }
                        ct.NoKhuyenMai = (spb.TonKho >= ct.SoLuong || DatTruoc || rdHangBanKem.Checked) ? 0 : ct.SoLuong - spb.TonKho;    
                        ct.LoaiHangKem = isHangKem;
                        ct.TenLoaiHangKem = tenHangKem;
                        ct.IdSanPhamBan = CTu.IdSanPham;
                        ct.TenSanPhamBan = CTu.TenSanPham;
                        ct.GhiChu = Common.Int2Bool(spb.ChietKhau) ? "CK" : (ct.NoKhuyenMai > 0 ? "Nợ khuyến mại" : "");
                        ct.SoLuongOld = ct.SoLuong;
                        ((BindingList<ChungTuBanHangChiTietInfor>) gSanPham.DataSource).Add(ct);
                    }
                    //spb.TonKho = spb.TonKho - 1;
                }
            }
            catch (System.Exception ex)
            {
#if DEBUG
                //MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                //MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private int GetTonConLai(BangGiaBanChiTietInfor spb)
        {
            int ton = spb.TonKho;
            foreach (ChungTuBanHangChiTietInfor ct in (BindingList<ChungTuBanHangChiTietInfor>) gSanPham.DataSource)
            {
                if (ct.IdSanPham == spb.IdSanPham)
                    ton = ton - ct.SoLuong;
            }
            return ton;
        }

        private void btnXoaHang_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvSanPham.FocusedRowHandle < 0) return;
                if (MessageBox.Show("Bạn có chắc chắn xóa các sản phẩm này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gvSanPham.DeleteSelectedRows();
                }
            }
            catch { }
        }

        private void gvSanPhamKem_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle < 0) return;
            BangGiaADSPKemInfor spk = (BangGiaADSPKemInfor)gvSanPhamKem.GetRow(e.RowHandle);
            if (spk != null && (spk.TrangThaiTon == 0 || !String.IsNullOrEmpty(spk.GhiChu)))
            {
                if (e.Column.FieldName.Equals("TrangThaiTon") && spk.TrangThaiTon == 0)
                {
                    e.Appearance.BackColor = tsslTrangThai.BackColor;
                    e.Appearance.ForeColor = Color.DarkBlue;
                    e.Appearance.Font = new Font("Tahoma", 9, FontStyle.Bold);
                }
                if (e.Column.FieldName.Equals("GhiChu") && !String.IsNullOrEmpty(spk.GhiChu))
                {
                    e.Appearance.BackColor = tsslChuaCoGia.BackColor;
                    e.Appearance.ForeColor = Color.DarkBlue;
                    e.Appearance.Font = new Font("Tahoma", 9, FontStyle.Bold);
                }
            }
        }

        private void gvKMChiTiet_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle < 0) return;
            BangGiaADKhuyenMaiChiTietInfor kmct = (BangGiaADKhuyenMaiChiTietInfor)gvKMChiTiet.GetRow(e.RowHandle);
            if (kmct != null && (kmct.NoKhuyenMai > 0 || !String.IsNullOrEmpty(kmct.GhiChu)))
            {
                if (e.Column.FieldName.Equals("NoKhuyenMai") && kmct.NoKhuyenMai > 0)
                {
                    e.Appearance.BackColor = kmct.HetTonDungKM == 0
                                                 ? tsslNoKhuyenMai.BackColor
                                                 : tsslTrangThai.BackColor;
                    e.Appearance.ForeColor = Color.DarkBlue;
                    e.Appearance.Font = new Font("Tahoma", 9, FontStyle.Bold);
                }
                if (e.Column.FieldName.Equals("GhiChu") && !String.IsNullOrEmpty(kmct.GhiChu))
                {
                    e.Appearance.BackColor = tsslChuaCoGia.BackColor;
                    e.Appearance.ForeColor = Color.DarkBlue;
                    e.Appearance.Font = new Font("Tahoma", 9, FontStyle.Bold);
                }
            }
        }

        private void gvSanPham_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle < 0) return;
            ChungTuBanHangChiTietInfor ct = (ChungTuBanHangChiTietInfor)gvSanPham.GetRow(e.RowHandle);
            if (ct != null && ct.NoKhuyenMai > 0)
            {
                if (e.Column.FieldName.Equals("TenLoaiHangKem"))
                {
                    e.Appearance.BackColor = tsslNoKhuyenMai.BackColor;
                    e.Appearance.ForeColor = Color.Red;
                    e.Appearance.Font = new Font("Tahoma",9,FontStyle.Bold);
                }                    
            }
        }

        private void gvSanPham_ShowingEditor(object sender, CancelEventArgs e)
        {
            try
            {
                if (gvSanPham.FocusedColumn.FieldName == "GhiChu")// && IsChietKhau(gvSanPham.FocusedRowHandle))
                {
                    ChungTuBanHangChiTietInfor ct = (ChungTuBanHangChiTietInfor)gvSanPham.GetRow(gvSanPham.FocusedRowHandle);
                    if (ct != null && ct.NoKhuyenMai > 0)
                        e.Cancel = true;
                }
            }
            catch
            {
            }
        }

        private void gvSanPhamKem_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            BangGiaADSPKemInfor spk = (BangGiaADSPKemInfor)gvSanPhamKem.GetRow(e.RowHandle);
            if (spk != null && spk.GhiChu != null && spk.GhiChu.Contains("(mặc định)"))
            {
                e.Appearance.BackColor = tsslChinhSachMacDinh.BackColor;
            }
        }

        private void gvKMChiTiet_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            BangGiaADKhuyenMaiChiTietInfor km = (BangGiaADKhuyenMaiChiTietInfor)gvKMChiTiet.GetRow(e.RowHandle);
            if (km != null && km.ChinhSachKhuyenMai != null && km.ChinhSachKhuyenMai.Contains("(mặc định)"))
            {
                e.Appearance.BackColor = tsslChinhSachMacDinh.BackColor;
            }
        }

        private void gvThanhToan_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            BangGiaADBankInfor tt = (BangGiaADBankInfor)gvThanhToan.GetRow(e.RowHandle);
            if (tt != null && tt.GhiChu != null && tt.GhiChu.Contains("(mặc định)"))
            {
                e.Appearance.BackColor = tsslChinhSachMacDinh.BackColor;
            }
        }

        private void frmBH_ChonChinhSach_BanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            cmdDong_Click(sender, e);
        }
    }
}