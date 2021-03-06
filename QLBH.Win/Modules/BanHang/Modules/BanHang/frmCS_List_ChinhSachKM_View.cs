using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QLBanHang.Modules.BanHang.Reports;
using CrystalDecisions.Shared;
using QLBH.Common;
using QLBH.Common.Objects;
using QLBH.Common.Providers;
using QLBH.Core.Data;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.DongBoERP;
using QLBH.Core.Form;
using QLBH.Core.Providers;

//

namespace QLBanHang.Modules.BanHang
{
    public partial class frmCS_List_ChinhSachKM_View : DevExpress.XtraEditors.XtraForm
    {
        #region declare
        List<BangGiaChinhSachInfor> liChinhSach = new List<BangGiaChinhSachInfor>();
        //private int IdBangGia = 0;//id bang gia
        private int IndexBG = 0;//thu tu bang gia
        private int Draft = -1;//-1:chua ton tai; 1-save, 0-confirm
        private bool IsAdded = false;
        private bool Updating = false;//false: chua sua, tao moi; 1:dang sua, tao moi
        private bool isView = false;
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private BangGiaChinhSachInfor chinhSach = null;
        private objGridMarkSelection selector = new objGridMarkSelection();
        private objGridMarkSelection selectorNo = new objGridMarkSelection();
        private frmCS_TimKiem_ChinhSachGia frmCS = null;
        //private objGridMarkSelection selectorCS = new objGridMarkSelection();
        #endregion
        private List<MatHangInfor> lstMatHang = new List<MatHangInfor>();
        Utils ut = new Utils();

        public frmCS_List_ChinhSachKM_View()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        public frmCS_List_ChinhSachKM_View(BangGiaChinhSachInfor chinhSach, List<BangGiaChinhSachInfor> liChinhSach, bool isView, frmCS_TimKiem_ChinhSachGia frmCS)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.chinhSach = chinhSach;
            this.liChinhSach = liChinhSach;
            this.isView = isView;
            this.frmCS = frmCS;
        }

        public frmCS_List_ChinhSachKM_View(BangGiaChinhSachInfor chinhSach, List<BangGiaChinhSachInfor> liChinhSach, bool isView)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.chinhSach = chinhSach;
            this.liChinhSach = liChinhSach;
            this.isView = isView;
        }

        public void HideMenu()
        {
            //toolStrip1.Visible = false;
            toolStrip1.Enabled = false;
        }

        private void LoadAllDanhMuc()
        {
            LoadDMNgheNghiep();
            LoadDMCachGiaoHang();
            LoadDMTinh();
        }

        private void frm_BangGia_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAllDanhMuc();
                if (liChinhSach == null || liChinhSach.Count == 0)
                    LoadAllBangGia();
                //gan bang gia hien tai
                if (chinhSach != null)
                {
                    LoadIndexBG();
                }
                else if (liChinhSach.Count > 0)
                {
                    IndexBG = 0;
                    chinhSach = liChinhSach[IndexBG];
                }
                //hien thi thong tin bang gia hien tai
                LoadChinhSachInfor();
                //Thiet lap trang thai item
                Updating = false;
                setEDItems();
                setEDFunctions();
            }
            catch (Exception ex)
            {
                EventLogProvider.Instance.WriteLog(ex.ToString()
                                    + "\nUser: " + nguoiDung.TenDangNhap
                                    + "\nMay: " + Declare.TenMay,
                                    this.Name);
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        /// <summary>
        /// Load all bảng giá. 
        /// Nếu count > 1 => hiển thị bảng giá số 0 hoặc bảng giá hiện tại (nếu chọn từ form tìm kiếm)
        /// </summary>
        private void LoadAllBangGia()
        {
            if (Common.Int2Bool(nguoiDung.SupperUser))
                liChinhSach = ChinhSachDataProvider.Instance.LoadAllChinhSach();
            else
                liChinhSach = ChinhSachDataProvider.Instance.LoadChinhSachByNSD(nguoiDung.TenDangNhap);
        }

        private void LoadIndexBG()
        {
            if (chinhSach != null && liChinhSach != null)
            {
                for (int i = 0; i < liChinhSach.Count; i++)
                {
                    if (liChinhSach[i].IdChinhSach == chinhSach.IdChinhSach)
                    {
                        IndexBG = i;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Enable, disable các ô nhập liệu
        /// </summary>
        private void setEDItems()
        {
            bool chkDefault = cboMacDinh.SelectedIndex == (int)LoaiChinhSachGia.MAC_DINH ? true : false;
            bool chkChietKhau = cboMacDinh.SelectedIndex == (int)LoaiChinhSachGia.CHIET_KHAU ? true : false;

            //bool status = Updating ? true : false;
            txtSoChinhSachGia.ReadOnly = !Updating;
            nudDoUuTien.Enabled = Updating;
            //chkDaDuyet.Enabled = Updating && Common.Int2Bool(nguoiDung.SupperUser);
            chkOnline.Enabled = Updating;
            mstNgayLap.Enabled = Updating;
            txtNguoiLap.ReadOnly = !Updating;
            //txtNgayDuyet.Enabled = Updating;
            //txtNguoiDuyet.Enabled = Updating;
            txtGhiChu.Enabled = Updating;
            chkApDungMacDinh.Enabled = Updating;

            //gSieuThiAD.Enabled = Updating;
            btnAddST.Enabled = Updating;
            btnDeleteST.Enabled = Updating;

            //selectorKH.CheckMarkColumn.VisibleIndex = Updating ? 0 : -1;
            //gDoiTuong.Enabled = Updating;
            btnAddKH.Enabled = Updating;
            btnDelKH.Enabled = Updating;

            //gThoiGianAD.Enabled = Updating;
            mstNgayHieuLuc.Enabled = Updating;
            mstHanHieuLuc.Enabled = Updating;// && chkVoHan.Checked;
            //chkVoHan.Enabled = Updating;
            txtSoKhachDauNgay.Enabled = Updating;
            btnAddTG.Enabled = Updating;
            btnDelTG.Enabled = Updating;

            //gThanhToan.Enabled = Updating;
            btnAddTT.Enabled = Updating;
            btnDelTT.Enabled = Updating;
            txtThanhToanToiThieu.Enabled = Updating;

            chkDuyNhatCMND.Enabled = Updating;
            chkDuyNhatSDT.Enabled = Updating;
            txtTuoiTu.Enabled = Updating && !chkDefault;
            txtTuoiDen.Enabled = Updating && !chkDefault;
            txtGiaTriHDToiThieu.Enabled = Updating;
            txtGiaTriDHDaMua.Enabled = Updating;
            txtThoiHanMua.Enabled = Updating;
            cboNgheNghiep.Enabled = Updating && !chkDefault;
            cboGiaoHang.Enabled = Updating && !chkDefault;
            cboGioiTinh.Enabled = Updating && !chkDefault;
            cboTinh.Enabled = Updating && !chkDefault;
            cboHuyen.Enabled = Updating && !chkDefault;

            cboLoaiMatHang.Enabled = Updating && !chkChietKhau;
            txtMaMatHang.Enabled = Updating;
            txtHangSX.Enabled = Updating && !chkChietKhau;
            //txtMaSanPhamNo.Enabled = Updating && !chkChietKhau;
            GiaMuaTu.OptionsColumn.ReadOnly = !Updating;
            GiaMuaDen.OptionsColumn.ReadOnly = !Updating;
            //InHoaDon.OptionsColumn.ReadOnly = !Updating;
            GiaMuaTu.Visible = !chkChietKhau;
            GiaMuaDen.Visible = !chkChietKhau;
            //InHoaDon.Visible = chkChietKhau;
            MaVachApDung.Visible = !chkChietKhau;
            TyLeDiemThuong.Visible = !chkChietKhau;
            SoLuongToiDaCK.Visible = false;

            MaVachApDung.OptionsColumn.ReadOnly = !Updating || chkDefault || chkChietKhau;
            TyLeDiemThuong.OptionsColumn.ReadOnly = !Updating || chkDefault || chkChietKhau;
            TyLeChietKhau.OptionsColumn.ReadOnly = !Updating;// || chkDefault.Checked;
            TienChietKhau.OptionsColumn.ReadOnly = !Updating;// || chkDefault.Checked;
            GiaTriMuaToiThieu.OptionsColumn.ReadOnly = !Updating || chkDefault || chkChietKhau;
            SoLuongDuocMua.OptionsColumn.ReadOnly = !Updating;// || chkChietKhau.Checked;
            SoLuongToiDaDH.OptionsColumn.ReadOnly = !Updating;// || chkChietKhau.Checked;
            SoLuongPhaiMua.OptionsColumn.ReadOnly = !Updating;// || chkChietKhau.Checked;
            KhuyenMaiWeb.OptionsColumn.ReadOnly = !Updating || chkChietKhau;
            SanPhamNoAD.Visible = chkChietKhau;

            MaVachApDung.AppearanceCell.BackColor = (chkDefault || chkChietKhau) ? Color.DarkGray : Color.White;
            TyLeDiemThuong.AppearanceCell.BackColor = MaVachApDung.AppearanceCell.BackColor;
            GiaTriMuaToiThieu.AppearanceCell.BackColor = MaVachApDung.AppearanceCell.BackColor;

            btnThemCT.Enabled = Updating;
            cmdXoaChiTiet.Enabled = Updating;
            btnImportCT.Enabled = Updating && !chkChietKhau;
            btnThemCTNo.Enabled = Updating && !chkChietKhau;
            btnXoaCTNo.Enabled = Updating && !chkChietKhau;
            btnImportCTNo.Enabled = Updating && !chkChietKhau;
            btnThietLapSPDaMua.Enabled = Updating && !chkChietKhau;
            btnThietLapSPKem.Enabled = Updating && !chkDefault;// && !chkChietKhau.Checked;
            btnThietLapSPKem.Text = chkChietKhau ? "Thiết lập mã áp dụng" : "Thiết lập hàng mua &kèm";
            cmdThietLapKM.Enabled = Updating;// && !chkChietKhau.Checked;
            cmdThietLapKM.Text = chkChietKhau ? "Thiết lập mã loại trừ" : "Thiết lập k&huyến mại";  
        }
        /// <summary>
        /// Enable, disable các menu chức năng: Add, Save, Updade,...
        /// </summary>
        private void setEDFunctions()
        {
            btnTruoc.Enabled = IndexBG > 0;// ? true : false;
            btnSau.Enabled = IndexBG < (liChinhSach.Count - 1);// ? true : false;
            //btnTimKiem.Enabled = !Updating;
            btnDefault.Enabled = (chinhSach != null) && (chinhSach.IdChinhSach > 0) && (chinhSach.MacDinh == 0) &&
                                 (nguoiDung.TenDangNhap.Equals(chinhSach.NguoiTao) || nguoiDung.SupperUser == 1) && ConnectionUtil.Instance.IsUAT != 1;
            btnStop.Enabled = !Updating && !Common.Int2Bool(Draft) && (chinhSach != null) && (chinhSach.IdChinhSach > 0) &&
                              (chinhSach.DaDuyet == 1 || chinhSach.DaDuyet == -1) && (nguoiDung.TenDangNhap.Equals(chinhSach.NguoiTao) || nguoiDung.SupperUser == 1);
            btnStop.Text = (chinhSach != null && chinhSach.DaDuyet == -1) ? "Kích hoạt(F11)" : "Tạm &dừng (F11)";
            groupBox1.Text = String.Format("Thông tin chung: Chính sách thứ [{0}]/[{1}]", IndexBG+1, liChinhSach.Count);
        }

        private void ResetBangGiaInfor()
        {
            txtSoChinhSachGia.ResetText();
            nudDoUuTien.Value = 0;
            txtTrangThai.ResetText();
            chkDaDuyet.Checked = false;
            chkOnline.Checked = false;
            mstNgayLap.Value = CommonProvider.Instance.GetSysDate();
            txtNguoiLap.Text = nguoiDung.TenNhanVien;
            txtNgayDuyet.ResetText();
            //txtNguoiDuyet.ResetText();
            txtGhiChu.ResetText();

            //chkAllDT.Checked = false;
            mstNgayHieuLuc.Value = CommonProvider.Instance.GetSysDate();
            mstHanHieuLuc.Value = CommonProvider.Instance.GetSysDate().AddDays(1) ;
            //chkVoHan.Checked = false;
            txtSoKhachDauNgay.ResetText();
            
            txtThanhToanToiThieu.ResetText();

            chkDuyNhatCMND.Checked = false;
            chkDuyNhatSDT.Checked = false;
            cboGioiTinh.SelectedIndex = 0;
            cboGiaoHang.SelectedIndex = -1;
            txtTuoiTu.ResetText();
            txtTuoiDen.ResetText();
            txtGiaTriHDToiThieu.ResetText();
            txtGiaTriDHDaMua.ResetText();
            txtThoiHanMua.ResetText();
            cboNgheNghiep.SelectedIndex = -1;
            cboTinh.SelectedIndex = -1;
            cboHuyen.SelectedIndex = -1;

            gSieuThiAD.DataSource = null;
            //selectorKH.ClearSelection();
            //gDoiTuong.DataSource = null;
            gThoiGianAD.DataSource = null;
            gThanhToan.DataSource = null;
            gSanPham.DataSource = null;
        }


        private void LoadChiTietKhuyenMai()
        {
            foreach (BangGiaADDKMuaInfor bgDKMua in chinhSach.ListBangGiaADDKMua)
            {
                //load khuyen mai
                if (bgDKMua.ListKhuyenMai == null)
                {
                    //load all danh sach khuyen mai
                    bgDKMua.ListKhuyenMai = KhuyenMaiDataProvider.Instance.GetAllBangGiaKhuyenMaiInfors(bgDKMua.IdDKMua);
                    for (int i = 0; i < bgDKMua.ListKhuyenMai.Count; i++)
                    {
                        bgDKMua.ListKhuyenMai[i].ListKhuyenMaiChiTiet = KhuyenMaiDataProvider.Instance.GetAllKhuyenMaiChiTietInfors(bgDKMua.ListKhuyenMai[i].IdKhuyenMai);
                    }
                }
                //foreach (BangGiaADKhuyenMaiInfor km in bgDKMua.ListKhuyenMai)
                //{
                //    km.SoKhuyenMai = "";
                //}
                //load san pham kem
                if (bgDKMua.ListSanPhamKem == null)
                {
                    bgDKMua.ListSanPhamKem = KhuyenMaiDataProvider.Instance.GetAllSanPhamKemInfors(bgDKMua.IdDKMua);
                }
                //load all danh sach san pham da mua
                if (bgDKMua.ListSanPhamDaMua == null)
                {                    
                    bgDKMua.ListSanPhamDaMua = KhuyenMaiDataProvider.Instance.GetAllSanPhamDaMuaInfors(bgDKMua.IdDKMua);
                }                
            }            
        }

        private void frm_BangGia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12 && btnDong.Enabled)
                this.btnDong_Click(sender, e);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void chkVoHan_CheckedChanged(object sender, EventArgs e)
        {
            //mstHanHieuLuc.Enabled = chkVoHan.Checked;
        }



        #region Show chinh sach infor
        private void LoadChinhSachInfor()
        {
            if (chinhSach != null)
            {
                frmProgress.Instance.Description = "Đang nạp dữ liệu ...";
                frmProgress.Instance.MaxValue = 10;
                frmProgress.Instance.Value = 0;
                frmProgress.Instance.DoWork(LoadDuLieu);

                //load thong tin chung
                LoadChinhSachHeader();
                //load sieu thi ap dung
                LoadSieuThiApDung();
                //load khach hang ap dung
                LoadKhachHangApDung();
                //load thoi gian ap dung
                LoadThoiGianApDung();
                //load thanh toan ap dung
                LoadThanhToanApDung();
                //load chi tiet san pham mua
                LoadSanPhamMuaApDung();
            }
            else
            {
                ResetBangGiaInfor();
            }
        }
        private void LoadDuLieu()
        {
            frmProgress.Instance.Description = "nạp danh sách mặt hàng không áp dụng ...";
            lstMatHang = new List<MatHangInfor>();
            if (!String.IsNullOrEmpty(chinhSach.MatHangKhongApDung))
            {
                //string sql = chinhSach.MatHangKhongApDung.Replace(",", "','");
                //sql = "'" + sql + "'";
                lstMatHang = ChinhSachDataProvider.Instance.GetAllMatHangKhongApDung(chinhSach.MatHangKhongApDung);
            }
            frmProgress.Instance.Value++;
            frmProgress.Instance.Description = "nạp danh sách siêu thị áp dụng ...";
            chinhSach.ListBangGiaADShop = ChinhSachDataProvider.Instance.GetBangGiaADShopInfor(chinhSach.IdChinhSach);

            frmProgress.Instance.Value++;
            frmProgress.Instance.Description = "nạp danh sách khách hàng áp dụng ...";
            chinhSach.ListBangGiaADKhach = ChinhSachDataProvider.Instance.GetBangGiaADKhachInfor(chinhSach.IdChinhSach);

            frmProgress.Instance.Value++;
            frmProgress.Instance.Description = "nạp danh sách thời gian áp dụng ...";
            chinhSach.ListBangGiaADThoiGian = ChinhSachDataProvider.Instance.GetBangGiaADThoiGianInfor(chinhSach.IdChinhSach);

            frmProgress.Instance.Value++;
            frmProgress.Instance.Description = "nạp danh sách hình thức thanh toán áp dụng ...";
            chinhSach.ListBangGiaADThanhToan = ChinhSachDataProvider.Instance.GetBangGiaADThanhToanInfor(chinhSach.IdChinhSach);

            frmProgress.Instance.Value++;
            frmProgress.Instance.Description = "nạp danh sách khuyến mại áp dụng ...";
            chinhSach.ListBangGiaADDKMua = KhuyenMaiDataProvider.Instance.GetAllBangGiaADDKMuaInfors(chinhSach.IdChinhSach);
            LoadChiTietKhuyenMai();//load chi tiet san pham mua

            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            frmProgress.Instance.IsCompleted = true;
            frmProgress.Instance.Description = "Đã xong";
        }
        private void LoadChinhSachHeader()
        {
            //thong tin chung
            Draft = chinhSach.Draft;
            txtSoChinhSachGia.Text = chinhSach.SoChinhSach;
            mstNgayLap.Value = chinhSach.NgayLap;
            txtNguoiLap.Text = chinhSach.NguoiLap;
            txtGhiChu.Text = chinhSach.GhiChu;
            nudDoUuTien.Value = chinhSach.DoUuTien;
            txtTrangThai.Text = chinhSach.DaDuyetTT;
            chkDaDuyet.Checked = Common.Int2Bool(chinhSach.DaDuyet);
            chkOnline.Checked = Common.Int2Bool(chinhSach.LoaiDoiTuong);
            cboMacDinh.SelectedIndex = chinhSach.MacDinh;
            chkApDungMacDinh.Checked = Common.Int2Bool(chinhSach.ApDungKemMacDinh);
            chkApDungMacDinh.Visible = chinhSach.MacDinh == (int)LoaiChinhSachGia.THONG_THUONG ? true : false;

            txtSoKhachDauNgay.Text = chinhSach.SoKhachDauNgay.ToString();
            txtThanhToanToiThieu.Text = chinhSach.ThanhToanToiThieu.ToString();
            txtSoTienTToanTThieu.Text = Common.Double2Str(chinhSach.SoTienTToanToiThieu);

            //dieu kien khac
            chkDuyNhatCMND.Checked = Common.Int2Bool(chinhSach.DuyNhatCMND);
            chkDuyNhatSDT.Checked = Common.Int2Bool(chinhSach.DuyNhatSDT);
            txtTuoiTu.Text = chinhSach.DoTuoiTu.ToString();
            txtTuoiDen.Text = chinhSach.DoTuoiDen.ToString();
            cboGiaoHang.SelectedValue = chinhSach.CachGiaoHang;
            cboGioiTinh.SelectedIndex = chinhSach.GioiTinh;
            cboTinh.SelectedValue = chinhSach.IdTinh;
            cboHuyen.SelectedValue = chinhSach.IdHuyen;
            cboNgheNghiep.SelectedValue = chinhSach.IdNgheNghiep;
            txtGiaTriHDToiThieu.Text = Common.Double2Str(chinhSach.GiaTriHDToiThieu);
            txtGiaTriDHDaMua.Text = Common.Double2Str(chinhSach.GiaTriDHDaMua);
            txtThoiHanMua.Text = chinhSach.ThoiHanMua.ToString();

            gDanhSachKhongAD.DataSource = new BindingList<MatHangInfor>(lstMatHang);
            selectorNo.View = null;
            selectorNo.View = gvDanhSachKhongAD;
        }
        private void LoadSanPhamMuaApDung()
        {
            gSanPham.DataSource = new BindingList<BangGiaADDKMuaInfor>(chinhSach.ListBangGiaADDKMua);
            selector.View = gvSanPham;
            selector.CheckMarkColumn.Fixed = FixedStyle.Left;
            selector.CheckMarkColumn.VisibleIndex = 0;
            LoadChiTietKhuyenMai();//load chi tiet san pham mua
        }
        private void LoadSieuThiApDung()
        {
            gSieuThiAD.DataSource = new BindingList<BangGiaADShopInfor>(chinhSach.ListBangGiaADShop);
        }
        private void LoadThoiGianApDung()
        {
            mstNgayHieuLuc.Value = chinhSach.NgayHieuLuc;
            mstHanHieuLuc.Value = chinhSach.HanHieuLuc;
            txtSoKhachDauNgay.Text = chinhSach.SoKhachDauNgay.ToString();

            gThoiGianAD.DataSource = new BindingList<BangGiaADTimeInfor>(chinhSach.ListBangGiaADThoiGian);
        }
        private void LoadThanhToanApDung()
        {
            txtThanhToanToiThieu.Text = chinhSach.ThanhToanToiThieu.ToString();
            gThanhToan.DataSource = new BindingList<BangGiaADBankInfor>(chinhSach.ListBangGiaADThanhToan);
        }
        private void LoadKhachHangApDung()
        {
            gDoiTuong.DataSource = new BindingList<BangGiaADKhachInfor>(chinhSach.ListBangGiaADKhach);
        }

        #endregion
        private void LoadDMNgheNghiep()
        {
            try
            {
                List<DmNgheNghiepInfor> liNgheNghiep = DMNgheNghiepDataProvider.Instance.GetListNgheNghiepInfors();
                cboNgheNghiep.DataSource = liNgheNghiep;
                cboNgheNghiep.DisplayMember = "TenNgheNghiep";
                cboNgheNghiep.ValueMember = "IdNgheNghiep";
                cboNgheNghiep.SelectedIndex = -1;
            }
            catch
            {
            }
        }

        private void LoadDMCachGiaoHang()
        {
            try
            {
                List<DMCachGiaoHangInfo> liGiaoHang = DMCachGiaoHangDataProvider.Instance.GetListCachGiaoHangInfo();
                cboGiaoHang.DataSource = liGiaoHang;
                cboGiaoHang.DisplayMember = "Ten";
                cboGiaoHang.ValueMember = "IdCachGiaoHang";
                cboGiaoHang.SelectedIndex = -1;
            }
            catch
            {
            }
        }

        private void LoadDMTinh()
        {
            try
            {
                List<DMTinhInfor> liTinh = DMTinhDataProvider.Instance.GetListTinhInfors();
                cboTinh.DataSource = liTinh;
                cboTinh.DisplayMember = "TenTinh";
                cboTinh.ValueMember = "IdTinh";
                cboTinh.SelectedIndex = -1;
            }
            catch
            {
            }           
        }

        private void LoadDMHuyen()
        {
            try
            {

                List<DMHuyenInfor> liHuyen = DMHuyenDataProvider.Instance.GetListHuyenByTinhInfors(Common.IntValue(cboTinh.SelectedValue));
                cboHuyen.DataSource = liHuyen;
                cboHuyen.DisplayMember = "TenHuyen";
                cboHuyen.ValueMember = "IdHuyen";
                cboHuyen.SelectedIndex = -1;
            }
            catch
            {
            }
        }

        private void cboTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDMHuyen();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn dừng chính sách giá này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string msg = "";
                    if (chinhSach.DaDuyet == 1)
                    {
                        chinhSach.DaDuyet = -1;
                        msg = "Tạm dừng chính sách giá thành công!";
                    }                       
                    else if (chinhSach.DaDuyet == -1)
                    {
                        chinhSach.DaDuyet = 1;
                        msg = "Kích hoạt chính sách giá thành công!";
                    }

                    chinhSach.NguoiDuyet = nguoiDung.TenDangNhap;

                    ChinhSachDataProvider.Instance.DuyetBangGiaChinhSach(chinhSach);
                    BangGiaChinhSachInfor cs = ChinhSachDataProvider.Instance.GetBangGiaChinhSachInforById(chinhSach.IdChinhSach);
                    chinhSach.DaDuyetTT = cs.DaDuyetTT;
                    txtTrangThai.Text = chinhSach.DaDuyetTT;
                    Updating = false;
                    setEDItems();
                    setEDFunctions();
                    MessageBox.Show(msg);
                }
            }
            catch (Exception ex)
            {
                EventLogProvider.Instance.WriteLog(ex.ToString()
                                    + "\nUser: " + nguoiDung.TenDangNhap
                                    + "\nMay: " + Declare.TenMay,
                                    this.Name);
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            try
            {
                if (IndexBG < liChinhSach.Count - 1)
                {
                    if (Updating)
                    {
                        if (MessageBox.Show("Dữ liệu đang cập nhật, bạn có muốn hủy bỏ không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                            return;
                    }

                    IndexBG++;
                    IsAdded = false;
                    chinhSach = liChinhSach[IndexBG];
                    LoadChinhSachInfor();

                    Updating = false;
                    setEDItems();
                    setEDFunctions();
                    if (frmCS != null)
                        frmCS.setRowFocus(IndexBG);
                }
            }
            catch (Exception ex)
            {
                EventLogProvider.Instance.WriteLog(ex.ToString()
                                    + "\nUser: " + nguoiDung.TenDangNhap
                                    + "\nMay: " + Declare.TenMay,
                                    this.Name);
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }        
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            try
            {
                if (IndexBG > 0)
                {
                    if (Updating)
                    {
                        if (MessageBox.Show("Dữ liệu đang cập nhật, bạn có muốn hủy bỏ không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                            return;
                    }

                    IndexBG--;
                    IsAdded = false;
                    chinhSach = liChinhSach[IndexBG];
                    LoadChinhSachInfor();

                    Updating = false;
                    setEDItems();
                    setEDFunctions();
                    if (frmCS != null)
                        frmCS.setRowFocus(IndexBG);
                }
            }
            catch (Exception ex)
            {
                EventLogProvider.Instance.WriteLog(ex.ToString()
                                    + "\nUser: " + nguoiDung.TenDangNhap
                                    + "\nMay: " + Declare.TenMay,
                                    this.Name);
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void btnThietLapSPKem_Click(object sender, EventArgs e)
        {
            if (cboMacDinh.SelectedIndex == (int)LoaiChinhSachGia.CHIET_KHAU)// chkChietKhau.Checked)
                ThietLapLoaiTru(true);
            else
                ThietLapSanPhamKem();
        }

        private void ThietLapSanPhamKem()
        {
            try
            {
                if (gvSanPham.FocusedRowHandle >= 0)
                {
                    BangGiaADDKMuaInfor dkm = (BangGiaADDKMuaInfor)gvSanPham.GetRow(gvSanPham.FocusedRowHandle);
                    frmCS_BangGia_SanPhamKem frm = new frmCS_BangGia_SanPhamKem(dkm, btnThietLapSPKem.Enabled);
                    frm.ShowDialog();
                    //                    if (frm.ShowDialog() == DialogResult.OK)
                    ((BindingList<BangGiaADDKMuaInfor>)gSanPham.DataSource).ResetBindings();
                }
            }
            catch (Exception ex)
            {
                EventLogProvider.Instance.WriteLog(ex.ToString()
                                    + "\nUser: " + nguoiDung.TenDangNhap
                                    + "\nMay: " + Declare.TenMay,
                                    this.Name);
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }
        private void cmdThietLapKM_Click(object sender, EventArgs e)
        {
            if (cboMacDinh.SelectedIndex == (int)LoaiChinhSachGia.CHIET_KHAU)// chkChietKhau.Checked)
                ThietLapLoaiTru(false);
            else
                ThietLapKhuyenMai();
        }
        /// <summary>
        /// Thiết lập sản phẩm loại trừ hoặc áp dụng
        /// </summary>
        /// <param name="isApDung">true: áp dụng, false: loại trừ</param>
        private void ThietLapLoaiTru(bool isApDung)
        {
            try
            {
                if (gvSanPham.FocusedRowHandle >= 0)
                {
                    BangGiaADDKMuaInfor dkm = (BangGiaADDKMuaInfor)gvSanPham.GetRow(gvSanPham.FocusedRowHandle);
                    bool isEnable = isApDung ? btnThietLapSPKem.Enabled : cmdThietLapKM.Enabled;
                    frmCS_BangGia_SanPhamNoAD frm = new frmCS_BangGia_SanPhamNoAD(dkm, isEnable, isApDung);
                    frm.ShowDialog();
                    //                    if (frm.ShowDialog() == DialogResult.OK)
                    ((BindingList<BangGiaADDKMuaInfor>)gSanPham.DataSource).ResetBindings();
                }
            }
            catch (Exception ex)
            {
                EventLogProvider.Instance.WriteLog(ex.ToString()
                                    + "\nUser: " + nguoiDung.TenDangNhap
                                    + "\nMay: " + Declare.TenMay,
                                    this.Name);
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }
        private void ThietLapKhuyenMai()
        {
            try
            {
                List<BangGiaADDKMuaInfor> liDKMua = new List<BangGiaADDKMuaInfor>();
                if (selector.SelectedCount > 0)
                {
                    foreach (BangGiaADDKMuaInfor dkm in selector.selection)
                    {
                        liDKMua.Add(dkm);
                    }
                }
                else
                {
                    if (gvSanPham.FocusedRowHandle >= 0)
                    {
                        BangGiaADDKMuaInfor dkm = (BangGiaADDKMuaInfor)gvSanPham.GetRow(gvSanPham.FocusedRowHandle);
                        liDKMua.Add(dkm);
                    }
                }
                bool chkDefault = cboMacDinh.SelectedIndex == (int)LoaiChinhSachGia.MAC_DINH ? true : false;
                frmCS_BangGia_KhuyenMai frm = new frmCS_BangGia_KhuyenMai(liDKMua, cmdThietLapKM.Enabled, txtSoChinhSachGia.Text, chkDefault);
                frm.ShowDialog();
                //                    if (frm.ShowDialog() == DialogResult.OK)
                ((BindingList<BangGiaADDKMuaInfor>)gvSanPham.DataSource).ResetBindings();
            }
            catch (Exception ex)
            {
                EventLogProvider.Instance.WriteLog(ex.ToString()
                                    + "\nUser: " + nguoiDung.TenDangNhap
                                    + "\nMay: " + Declare.TenMay,
                                    this.Name);
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void gvSanPham_DoubleClick(object sender, EventArgs e)
        {
            Point pt = gSanPham.PointToClient(MousePosition);
            GridHitInfo hitInfo = gvSanPham.CalcHitInfo(pt);
            if (hitInfo.InRow)
            {
                if (hitInfo.Column.FieldName == "KhuyenMai" || hitInfo.Column.FieldName == "SanPhamNoAD")
                    cmdThietLapKM_Click(sender, e);
                else if (hitInfo.Column.FieldName == "SanPhamKem" || hitInfo.Column.FieldName == "SanPhamYesAD")
                    btnThietLapSPKem_Click(sender, e);
                else if (hitInfo.Column.FieldName == "SanPhamDaMua")
                    btnThietLapSPDaMua_Click(sender, e);
            }
        }

        private void btnThietLapSPDaMua_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvSanPham.FocusedRowHandle >= 0)
                {
                    BangGiaADDKMuaInfor dkm = (BangGiaADDKMuaInfor)gvSanPham.GetRow(gvSanPham.FocusedRowHandle);
                    frmCS_BangGia_SanPhamDaMua frm = new frmCS_BangGia_SanPhamDaMua(dkm, btnThietLapSPDaMua.Enabled);
                    frm.ShowDialog();
                    //                    if (frm.ShowDialog() == DialogResult.OK)
                    ((BindingList<BangGiaADDKMuaInfor>)gSanPham.DataSource).ResetBindings();
                }
            }
            catch (Exception ex)
            {
                EventLogProvider.Instance.WriteLog(ex.ToString()
                                    + "\nUser: " + nguoiDung.TenDangNhap
                                    + "\nMay: " + Declare.TenMay,
                                    this.Name);
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn thiết lập mặc định cho chính sách này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cboMacDinh.SelectedIndex = (int)LoaiChinhSachGia.MAC_DINH;
                    chinhSach.MacDinh = cboMacDinh.SelectedIndex; 
                    ChinhSachDataProvider.Instance.ThietLapMacDinhChinhSach(chinhSach);
                    Updating = false;
                    setEDItems();
                    setEDFunctions();
                    MessageBox.Show("Đã thiết lập chính sách khuyến mại mặc định thành công!");
                }
            }
            catch (Exception ex)
            {
                EventLogProvider.Instance.WriteLog(ex.ToString()
                                    + "\nUser: " + nguoiDung.TenDangNhap
                                    + "\nMay: " + Declare.TenMay,
                                    this.Name);
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }
    }
}