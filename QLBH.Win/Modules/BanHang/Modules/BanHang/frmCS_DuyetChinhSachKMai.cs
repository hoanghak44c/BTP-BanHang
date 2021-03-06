using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
using QLBH.Core.Providers;
using QLBH.Core.Form;
using QLBanHang.Modules.DanhMuc;

//

namespace QLBanHang.Modules.BanHang
{
    public partial class frmCS_DuyetChinhSachKMai : DevExpress.XtraEditors.XtraForm
    {
        #region declare
        //List<BangGiaChinhSachInfor> liChinhSach = new List<BangGiaChinhSachInfor>();
        //private int IdBangGia = 0;//id bang gia
        List<BangGiaCSachCTietInfor> liCSachCTiet = new List<BangGiaCSachCTietInfor>();
        private int IndCTiet = 0;//thu tu item chinh sach gia
        private int Draft = -1;//-1:chua ton tai; 1-save, 0-confirm
        private bool IsAdded = false;
        private bool Updating = false;//false: chua sua, tao moi; 1:dang sua, tao moi
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private BangGiaChinhSachInfor chinhSach = null;
        private objGridMarkSelection selector = new objGridMarkSelection();
        private objGridMarkSelection selectorNo = new objGridMarkSelection();
        private frmCS_TimKiem_ChinhSachGia frmCS = null;
        //private objGridMarkSelection selectorCS = new objGridMarkSelection();
        #endregion
        DataSet dsChungTu;
        private List<MatHangInfor> lstMatHang = new List<MatHangInfor>();
        Utils ut = new Utils();

        public frmCS_DuyetChinhSachKMai()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.chinhSach = new BangGiaChinhSachInfor();
        }

        public frmCS_DuyetChinhSachKMai(BangGiaChinhSachInfor chinhSach)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.chinhSach = chinhSach;
        }

        public void HideMenu()
        {
            //toolStrip1.Visible = false;
            toolStrip1.Enabled = false;
        }

        private bool UpdateBangGia(int daduyet)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string msg = daduyet == 1 ? "Đã Duyệt bảng giá!" : "Từ chối bảng giá!";
                if (MessageBox.Show("Bạn có chắc chắn đồng ý " + msg + " này không(Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    chinhSach.DaDuyet = daduyet;
                    chinhSach.NguoiDuyet = nguoiDung.TenDangNhap;

                    ChinhSachDataProvider.Instance.DuyetBangGiaChinhSach(chinhSach);

/*                    BangGiaChinhSachInfor cs = ChinhSachDataProvider.Instance.GetBangGiaChinhSachInforById(chinhSach.IdChinhSach);
                    chinhSach.DaDuyetTT = cs.DaDuyetTT;*/
                    txtTrangThai.Text = daduyet == 1 ? "Đã duyệt" : "Bị từ chối";
  
                    Updating = false;
                    setEDItems();
                    setEDFunctions();
                    MessageBox.Show(msg);
                    this.Close();
                }
            }
            catch (Exception)
            {
                ConnectionUtil.Instance.RollbackTransaction();
                throw;
            }
            Cursor.Current = Cursors.Default;
            return false;
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

                //hien thi thong tin csg hien tai
                LoadChinhSachInfor();
                //Thiet lap trang thai item
                Updating = true;
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
        /// Enable, disable các ô nhập liệu
        /// </summary>
        private void setEDItems()
        {
            bool chkDefault = cboMacDinh.SelectedIndex == (int)LoaiChinhSachGia.MAC_DINH ? true : false;
            bool chkChietKhau = cboMacDinh.SelectedIndex == (int)LoaiChinhSachGia.CHIET_KHAU ? true : false;

            bool status = Updating;
            Updating = false;
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
            chkApDungMacDinh.Enabled = !Updating;

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

            GiaMuaTu.OptionsColumn.ReadOnly = !Updating;
            GiaMuaDen.OptionsColumn.ReadOnly = !Updating;
            InHoaDon.OptionsColumn.ReadOnly = !Updating;
            GiaMuaTu.Visible = !chkChietKhau;
            GiaMuaDen.Visible = !chkChietKhau;
            InHoaDon.Visible = chkChietKhau;
            
            TyLeChietKhau.OptionsColumn.ReadOnly = !Updating || chkDefault;
            TienChietKhau.OptionsColumn.ReadOnly = !Updating || chkDefault;
            GiaTriMuaToiThieu.OptionsColumn.ReadOnly = !Updating || chkDefault || chkChietKhau;
            SoLuongDuocMua.OptionsColumn.ReadOnly = !Updating;// || chkChietKhau.Checked;
            SoLuongToiDaDH.OptionsColumn.ReadOnly = !Updating;// || chkChietKhau.Checked;
            SoLuongPhaiMua.OptionsColumn.ReadOnly = !Updating;// || chkChietKhau.Checked;
            KhuyenMaiWeb.OptionsColumn.ReadOnly = !Updating || chkChietKhau;
            SanPhamNoAD.Visible = chkChietKhau;

            Updating = status;
        }
        /// <summary>
        /// Enable, disable các menu chức năng: Add, Save, Updade,...
        /// </summary>
        private void setEDFunctions()
        {
            btnConfirm.Enabled = Updating;
            btnStop.Enabled = Updating;
            //btnTimKiem.Enabled = !isView;
            //groupBox1.Text = String.Format("Thông tin chung: Chính sách thứ [{0}]/[{1}]", IndexBG+1, liChinhSach.Count);
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidEditBangGia())
                {
                    MessageBox.Show("Chính sách này đã được xác nhận, không thể xóa được!");
                }
                else
                {
                    DeleteBangGia();
                }
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

        private void DeleteBangGia()
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa chính sách giá này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ChinhSachDataProvider.Instance.DeleteBangGiaChinhSach(chinhSach.IdChinhSach);
                    MessageBox.Show("Xóa bảng giá thành công!");
                    this.Close();
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


        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidEditBangGia())
                {
                    MessageBox.Show("Chính sách này đã được xác nhận, không thể sửa được!");
                }
                else
                {
                    IsAdded = false;
                    Updating = true;
                    setEDItems();
                    setEDFunctions();
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

        private bool ValidEditBangGia()
        {
            if (chinhSach.IdChinhSach > 0 && (!nguoiDung.TenDangNhap.Equals(chinhSach.NguoiTao) || !Common.Int2Bool(chinhSach.Draft)) && !Common.Int2Bool(nguoiDung.SupperUser))//bang gia da xac nhan
            {
                return false;
            }
            return true;
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
                //load all danh sach san pham khong ap dung
                if (bgDKMua.ListSanPhamNoAD == null)
                {
                    bgDKMua.ListSanPhamNoAD = KhuyenMaiDataProvider.Instance.GetAllSanPhamNoADInfors(bgDKMua.IdDKMua, 0);
                }
                if (bgDKMua.ListSanPhamYesAD == null)
                {
                    bgDKMua.ListSanPhamYesAD = KhuyenMaiDataProvider.Instance.GetAllSanPhamNoADInfors(bgDKMua.IdDKMua, 1);
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


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {

                Draft = 0;
                if (UpdateBangGia(1))//duyet gia
                {
                    this.DialogResult = DialogResult.OK;
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
                //load chi tiet san pham anh huong
                LoadSanPhamAnhHuong();
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
            frmProgress.Instance.Value ++;
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

            frmProgress.Instance.Value++;
            frmProgress.Instance.Description = "nạp chi tiết khuyến mại áp dụng ...";
            LoadChiTietKhuyenMai();//load chi tiet san pham mua

            frmProgress.Instance.Value++;
            frmProgress.Instance.Description = "nạp danh sách sản phẩm ảnh hưởng ...";
            liCSachCTiet = ChinhSachDataProvider.Instance.LoadSanPhamAnhHuong(chinhSach.IdChinhSach);

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
            IndCTiet = 0;
            foreach (BangGiaADDKMuaInfor dkm in chinhSach.ListBangGiaADDKMua)
            {
                dkm.SoThuTu = ++IndCTiet;
            }
            gSanPham.DataSource = new BindingList<BangGiaADDKMuaInfor>(chinhSach.ListBangGiaADDKMua);
            selector.View = gvSanPham;
            selector.CheckMarkColumn.Fixed = FixedStyle.Left;
            selector.CheckMarkColumn.VisibleIndex = 0;
        }
        private void LoadSanPhamAnhHuong()
        {
            gChinhSachCTiet.DataSource = new BindingList<BangGiaCSachCTietInfor>(liCSachCTiet);
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
        private void btnAddST_Click(object sender, EventArgs e)
        {
            frmCS_BangGia_ApDungST frm = new frmCS_BangGia_ApDungST();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (chinhSach.ListBangGiaADShop == null)
                {
                    chinhSach.ListBangGiaADShop = new List<BangGiaADShopInfor>();
                    gSieuThiAD.DataSource = new BindingList<BangGiaADShopInfor>(chinhSach.ListBangGiaADShop);
                }

                foreach (BangGiaADShopInfor bgShop in frm.LstBangGiaADShop)
                {
                    if (!chinhSach.ListBangGiaADShop.Exists(delegate (BangGiaADShopInfor match)
                                                               {
                                                                   return
                                                                       match.IdTrungTam ==
                                                                       bgShop.IdTrungTam && match.IdKho == bgShop.IdKho || match.IdTrungTam == 0;
                                                               }))
                    {
                        if (bgShop.IdTrungTam == 0)
                        {
                            chinhSach.ListBangGiaADShop = new List<BangGiaADShopInfor>();
                            gSieuThiAD.DataSource = new BindingList<BangGiaADShopInfor>(chinhSach.ListBangGiaADShop);                            
                        }
                        bgShop.IdChinhSach = chinhSach.IdChinhSach;
                        ((BindingList<BangGiaADShopInfor>)gSieuThiAD.DataSource).Add(bgShop);
                    } 
                }
                UpdateSoLuongDonHang();
            }
        }

        private void UpdateSoLuongDonHang()
        {
            int sum = 0;
            foreach (BangGiaADShopInfor shopInfor in (BindingList<BangGiaADShopInfor>)gSieuThiAD.DataSource)
            {
                if (shopInfor.IdTrungTam > 0 && shopInfor.IdKho == 0)
                    sum += shopInfor.SoLuongDonHang;
            }
            if (sum > Common.IntValue(txtSoKhachDauNgay.Text))
                txtSoKhachDauNgay.Text = sum.ToString();
        }

        private void btnDeleteST_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvSieuThiAD.FocusedRowHandle < 0) return;

                if (MessageBox.Show("Bạn có chắc chắn xóa dữ liệu này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gvSieuThiAD.DeleteSelectedRows();
                    UpdateSoLuongDonHang();
                }
            }
            catch { }
        }

        private void btnAddTT_Click(object sender, EventArgs e)
        {
            frmCS_BangGia_ApDungTT frm = new frmCS_BangGia_ApDungTT();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BangGiaADBankInfor thanhToan = frm.ThanhToan;
                thanhToan.IdChinhSach = chinhSach.IdChinhSach;
                ((BindingList<BangGiaADBankInfor>)gThanhToan.DataSource).Add(thanhToan);
            }
        }

        private void btnDelTT_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvThanhToan.FocusedRowHandle < 0) return;

                if (MessageBox.Show("Bạn có chắc chắn xóa dữ liệu này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gvThanhToan.DeleteSelectedRows();
                }
            }
            catch { }
        }

        private void btnAddTG_Click(object sender, EventArgs e)
        {
            frmCS_BangGia_ApDungTG frm = new frmCS_BangGia_ApDungTG();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BangGiaADTimeInfor time = frm.Time;
                time.IdChinhSach = chinhSach.IdChinhSach;
                ((BindingList<BangGiaADTimeInfor>)gThoiGianAD.DataSource).Add(time);
            }
        }

        private void btnDelTG_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvThoiGianAD.FocusedRowHandle < 0) return;

                if (MessageBox.Show("Bạn có chắc chắn xóa dữ liệu này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gvThoiGianAD.DeleteSelectedRows();
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
                if (UpdateBangGia(-2))//duyet gia
                {
                    this.DialogResult = DialogResult.OK;
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (Updating)
            {
                if (MessageBox.Show("Dữ liệu đang cập nhật, bạn có muốn hủy bỏ không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            }
            search();
        }

        private void search()
        {
            frmCS_TimKiem_ChinhSachGia frm = new frmCS_TimKiem_ChinhSachGia(1);
            if (frm.ShowDialog() == DialogResult.OK && frm.ChinhSach != null)
            {
                chinhSach = frm.ChinhSach;
                //hien thi thong tin bang gia hien tai
                LoadChinhSachInfor();
                //Thiet lap trang thai item
                Updating = false;
                setEDItems();
                setEDFunctions();
            }
        }

        private void btnAddKH_Click(object sender, EventArgs e)
        {
            frmCS_BangGia_ApDungKH frm = new frmCS_BangGia_ApDungKH();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (chinhSach.ListBangGiaADKhach == null)
                {
                    chinhSach.ListBangGiaADKhach = new List<BangGiaADKhachInfor>();
                    gDoiTuong.DataSource = new BindingList<BangGiaADKhachInfor>(chinhSach.ListBangGiaADKhach);
                }

                foreach (BangGiaADKhachInfor bgKhach in frm.LstBangGiaADKhach)
                {
                    if (!chinhSach.ListBangGiaADKhach.Exists(delegate(BangGiaADKhachInfor match)
                                                                 {
                                                                     return
                                                                         match.IdLoaiDT ==
                                                                         bgKhach.IdLoaiDT &&
                                                                         match.IdDoiTuong == bgKhach.IdDoiTuong || match.IdLoaiDT == 0;
                                                                 }))
                    {
                        if (bgKhach.IdLoaiDT == 0)
                        {
                            chinhSach.ListBangGiaADKhach = new List<BangGiaADKhachInfor>();
                            gDoiTuong.DataSource = new BindingList<BangGiaADKhachInfor>(chinhSach.ListBangGiaADKhach);                            
                        }
                        bgKhach.IdChinhSach = chinhSach.IdChinhSach;
                        ((BindingList<BangGiaADKhachInfor>) gDoiTuong.DataSource).Add(bgKhach);
                    }
                }
            }
        }

        private void btnDelKH_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvDoiTuong.FocusedRowHandle < 0) return;

                if (MessageBox.Show("Bạn có chắc chắn xóa dữ liệu này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gvDoiTuong.DeleteSelectedRows();
                }
            }
            catch { }
        }

        private void gvSanPham_DoubleClick(object sender, EventArgs e)
        {
            Point pt = gSanPham.PointToClient(MousePosition);
            GridHitInfo hitInfo = gvSanPham.CalcHitInfo(pt);
            if (hitInfo.InRow)
            {
            }
        }

        private void gvSanPham_ShowingEditor(object sender, CancelEventArgs e)
        {
            //try
            //{
            //    if (gvSanPham.FocusedRowHandle < 0) return;
            //    if (gvSanPham.FocusedColumn.FieldName == "InHoaDon")
            //    {
            //        BangGiaADDKMuaInfor dkm = (BangGiaADDKMuaInfor)gvSanPham.GetRow(gvSanPham.FocusedRowHandle);
            //        if (dkm != null && dkm.LoaiHangMua != 6)
            //            e.Cancel = true;

            //    }
            //}
            //catch
            //{
            //}
        }
    }
}