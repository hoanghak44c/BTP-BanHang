using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms;
using QLBanHang.Modules.BanHang.Reports;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.TheThanhVien;
using QLBanHang.Modules.TheThanhVien.Infors;
using QLBanHang.Modules.TheThanhVien.Providers;
using QLBH.Common;
using QLBH.Common.Providers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.BanHang.Bussiness;
using QLBH.Core.Data;
using QLBH.Core.Providers;
using QLBanHang.Modules.DanhMuc;
using QLBH.Core.Exceptions;
using UtilFunctions = QLBanHang.Modules.HeThong.UtilFunctions;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBH_LapDonHangBanTheTVien : DevExpress.XtraEditors.XtraForm
    {
        #region "Khai báo biến"
        List<SuDungHoaDonInfor> liSuDungHD = new List<SuDungHoaDonInfor>();
        List<DmNgheNghiepInfor> liNgheNghiep = new List<DmNgheNghiepInfor>();
        private List<BangGiaBanChiTietInfor> liBangGiaBan = new List<BangGiaBanChiTietInfor>();

        private bool ApDungTheThanhVien = false;  

        private int IdTheThanhVien = 0;
        private int IdLoaiTheThanhVien = 0;
        private string TheThanhVien = "";
        private string NguoiXacNhan = "";        
        private double SoTienQuyDoi = 0;
        private int SoDiemBanDau = 0;
        private int SoDiemTichLuy = 0;
        private int SoDiemBiTru = 0;
        private int DoUuTien = 0;
        private double HeSoTienRaDiem = Declare.HE_SO_DOI_TIEN_RA_DIEM;

        private int TyLe = 100;
        private int SLChitietOld = 1;
        private int Draft = -1;//-1:chua ton tai; 1-save, 0-confirm
        private bool IsAdded = false;
        private bool Updating = false;//false: chua sua, tao moi; 1:dang sua, tao moi
        private bool Rejected = false;

        private int _IdKho = Declare.IdKho;
        private int _IdTrungTam = Declare.IdTrungTam;
        private int _IdTrungTamHachToan = Declare.IdTrungTamHachToan;
        private int _IdLoaiKhachHang = Declare.IdLoaiKhachHang;
        private int _IdKhachHang = Declare.IdKHMacDinh;
        private int _IdTruongCa = Declare.IdTruongCa;
        private int _IdThuNgan = Declare.IdThuNgan;
        private int _IdThoiHanThanhToan = Declare.IdThoiHanThanhToan;
        private ChungTuBanHangInfor DTHoanTien = null;

        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();

        private int TrangThaiDonHang = (int)OrderStatus.DON_HANG_BAN_TAI_SHOP;
        private int LoaiChungTu = (int)TransactionType.DON_HANG_TAI_SHOP;
        private bool IsInHoaDon = false;

        private LapDonHangBusiness Business;
        #endregion

        #region "Các phương thức khởi tạo"
        public frmBH_LapDonHangBanTheTVien()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            Business = new LapDonHangBusiness(LoaiChungTu, nguoiDung.IdNhanVien, _IdKho);
        }

        public frmBH_LapDonHangBanTheTVien(int loaiChungTu)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.LoaiChungTu = loaiChungTu;
            Business = new LapDonHangBusiness(LoaiChungTu, nguoiDung.IdNhanVien, _IdKho);
        }

        public frmBH_LapDonHangBanTheTVien(ChungTuBanHangInfor chungTuBanHangInfor)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            Business = new LapDonHangBusiness(chungTuBanHangInfor);
            LoaiChungTu = chungTuBanHangInfor.LoaiChungTu;
            TrangThaiDonHang = chungTuBanHangInfor.TrangThai;
            _IdKhachHang = chungTuBanHangInfor.IdDoiTuong;
        }

        public void HideMenu(bool isInHoaDon)
        {
            bool enable = ValidEditChungTu();
            //toolStrip1.Enabled = nguoiDung.SupperUser != 1 ? false : true;
            tsbAdd.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbEdit.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbCopy.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbUpdate.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbDelete.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbConfirm.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbPayment.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbPrint.Enabled = true;

            btnTimOrderKH.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            //btnTimOrderKH.Visible = false;
            Updating = nguoiDung.SupperUser != 1 ? false : enable;
            this.IsInHoaDon = isInHoaDon;
            setEDItems();
        }
        public void DisableMenu()
        {
            toolStrip1.Enabled = false;
            Updating = false;
            setEDItems();
        }
        #endregion

        #region "Các phương thức"
        private void UpdateTrangThaiChungTu()
        {
            //if (tsbConfirm.Enabled && !tsbUpdate.Enabled) return;
            if (TrangThaiDonHang == (int)OrderStatus.PHAN_CONG_GIAO_NHAN)
            {
                if (Rejected)
                    TrangThaiDonHang = (int)OrderStatus.REJECT_DON_HANG_GIAO_NHAN;
                else
                {
                    TrangThaiDonHang = (int)OrderStatus.XAC_NHAN_DON_HANG_GIAO_NHAN;
                    mstNgayLapPhieu.Value = CommonProvider.Instance.GetSysDate();
                    _IdTrungTamHachToan = Declare.IdTrungTamHachToan;
                }                    
            }
            else if (TrangThaiDonHang == (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC)
            {
                TrangThaiDonHang = (int) OrderStatus.DON_HANG_BAN_DAT_TRUOC;
                mstNgayLapPhieu.Value = CommonProvider.Instance.GetSysDate();
                _IdTrungTamHachToan = Declare.IdTrungTamHachToan;
            }
            else if (TrangThaiDonHang == (int)OrderStatus.XAC_NHAN_DON_HANG_ONLINE)
            {
                TrangThaiDonHang = (int)OrderStatus.DON_HANG_BAN_ONLINE;
                Business.ChungTu.NgayXuatHang = CommonProvider.Instance.GetSysDate();
                mstNgayLapPhieu.Value = CommonProvider.Instance.GetSysDate();                
                _IdTrungTamHachToan = Declare.IdTrungTamHachToan;
            }
        }

        //private void RestoreTrangThaiChungTu()
        //{
        //    if (TrangThaiDonHang == (int)OrderStatus.XAC_NHAN_DON_HANG_GIAO_NHAN)
        //    {
        //        TrangThaiDonHang = (int)OrderStatus.HUY_DON_HANG;
        //    }
        //    else if (TrangThaiDonHang == (int)OrderStatus.DON_HANG_BAN_TAI_SHOP)
        //    {
        //        TrangThaiDonHang = (int)OrderStatus.HUY_DON_HANG;
        //    }
        //    else if (TrangThaiDonHang == (int)OrderStatus.DON_HANG_BAN_DAT_TRUOC)
        //    {
        //        TrangThaiDonHang = (int) OrderStatus.HUY_DON_HANG;// TAO_DON_HANG_DAT_TRUOC;
        //    }
        //    else if (TrangThaiDonHang == (int)OrderStatus.DON_HANG_BAN_ONLINE)
        //    {
        //        TrangThaiDonHang = (int)OrderStatus.HUY_DON_HANG;
        //    }
        //}

        /// <summary>
        /// Khoi tao don hang
        /// </summary>
        /// <returns></returns>
        private void ResetChungTuInfor(ChungTuBanHangInfor oldCT)
        {
            try
            {
                LoadTrungTam();
                LoadKhoXuat();
                LoadKhachHang();
                LoadThuNgan();
                LoadTruongCa();
                LoadThoiHanThanhToan();

                txtSoOrderKH.ResetText();
                mstNgayLapPhieu.Value = CommonProvider.Instance.GetSysDate(); //.ResetText();//.Text = DateTime.Today.ToString("dd/MM/yyyy");
                dteNgayHoaDon.EditValue = null;
                txtSoChungTuGoc.ResetText();
                txtSoPhieuDC.ResetText();
                bteThuongVien.Tag = null;
                bteThuongVien.ResetText();

                txtDienThoai.Text = (oldCT == null ? "" : oldCT.DienThoai);
                txtCMND.Text = (oldCT == null ? "" : oldCT.SoCMND);
                cboCaBanHang.SelectedValue = DMCaBanHangDataProvider.Instance.GetCurrentCaBanHangInfors().KyHieu;
                cboGiaoHang.SelectedIndex = 0;
                mstNgayHenGiaoHang.Value = CommonProvider.Instance.GetSysDate();
                txtGhiChu.ResetText();

                bteKhachLe.Tag = null;// (oldCT == null ? null : DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(oldCT.IdKhachLe));
                bteKhachLe.Text = "";//(bteKhachLe.Tag != null ? ((DMDoiTuongInfo) bteKhachLe.Tag).TenDoiTuong : "");
                //cboLoaiThe.SelectedIndex = -1;
                //txtDiemTichLuy.ResetText();
                txtCongTy.Text = (oldCT == null ? "" : oldCT.CongTy);
                txtHoTenKhachHang.Text = (oldCT == null ? "" : oldCT.HoTen);
                cboGioiTinh.SelectedIndex = (oldCT == null ? 0 : oldCT.GioiTinh);
                txtTuoi.Text = (oldCT == null ? "" : oldCT.DoTuoi.ToString());
                txtMaSoThue.Text = (oldCT == null ? "" : oldCT.MaSoThue);
                txtEmail.Text = (oldCT == null ? "" : oldCT.Email);
                txtWebSite.Text = (oldCT == null ? "" : oldCT.Website);

                UtilFunctions.LoadTinhThanh(bteTinh, (oldCT == null ? 0 : oldCT.IdTinhGH));
                UtilFunctions.LoadQuanHuyen(bteHuyen, (oldCT == null ? 0 : oldCT.IdHuyenGH));
                txtDiaChi.Text = (oldCT == null ? "" : oldCT.DiaChi);
                UtilFunctions.LoadTinhThanh(bteTinhHD, (oldCT == null ? 0 : oldCT.IdTinhHD));
                UtilFunctions.LoadQuanHuyen(bteHuyenHD, (oldCT == null ? 0 : oldCT.IdHuyenHD));
                txtDiaChiHD.Text = (oldCT == null ? "" : oldCT.DiaChiHD);
                txtSoHDDaMua.ResetText();
                cboNgheNghiep.SelectedValue = (oldCT == null ? 0 : oldCT.IdNgheNghiep);

                LoadThoiHanThanhToan();

                LoadQuyen();

                //thong tin san pham
                gSanPhamBan.DataSource = null;
                txtMaSanPham.Text = "";
                txtMaSanPham.Focus();
                txtMaSanPham.SelectAll();

                //thong tin thanh toan
                txtTongTienHang.Text = Common.Double2Str(0);
                txtTongTienCK.Text = Common.Double2Str(0);
                txtTongTienSauCK.Text = Common.Double2Str(0);
                txtTongTienVAT.Text = Common.Double2Str(0);
                txtTongTienThanhToan.Text = Common.Double2Str(0);
                txtTienThucTra.Text = Common.Double2Str(0);
                txtTienConNo.Text = Common.Double2Str(0);
                gHinhThucThanhToan.DataSource = null;

                ResetTheInfor();
            }
            catch(Exception ex)
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

        private void ResetTheInfor()
        {
            ApDungTheThanhVien = false;
            bteKhachLe.Tag = null;
            bteKhachLe.Text = "";

            this.NguoiXacNhan = "";
            this.IdTheThanhVien = 0;
            this.IdLoaiTheThanhVien = 0;
            this.DoUuTien = 0;
            this.TheThanhVien = "";
            this.SoDiemTichLuy = 0;
            this.SoDiemBiTru = 0;
            this.SoTienQuyDoi = 0;
            this.HeSoTienRaDiem = 0;
            
            //2015/08/05 hah: bo sung them reset tren chung tu trong cac truong hop sao chep
            this.Business.ChungTu.IdTheThanhVien = 0;
            this.Business.ChungTu.TheThanhVien = "";
            this.Business.ChungTu.SoTienTichLuy = 0;
            this.Business.ChungTu.SoTienQuyDoi = 0;
            this.Business.ChungTu.DoUuTien = 0;
            this.DTHoanTien = null;

            if (Business.ListChiTietChungTu != null && Business.ListChiTietChungTu.Count > 0)
            {
                for (int i = Business.ListChiTietChungTu.Count - 1; i >= 0; i--)
                {
                    if (Business.ListChiTietChungTu[i].MaSanPham.EndsWith(Declare.MA_DOI_DIEM))
                        Business.ListChiTietChungTu.RemoveAt(i);
                }
                gSanPhamBan.DataSource = new BindingList<ChungTuBanHangChiTietInfor>(Business.ListChiTietChungTu);
            }
        }
        private bool ValidChungTuCommonInfor()
        {
            //Kiem tra dung trang thai don hang hay khong
            if (!BanHangDataProvider.Instance.CheckValid_TrangThai_ChungTu(Business.ChungTu.IdChungTu, "2,4,5,6,7,8"))//trang thai dang xuat hoac da xuat
            {
                MessageBox.Show("Trạng thái đơn hàng đã thay đổi!\nKhông thể thực hiện giao dịch này được", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //
            //Sự hợp lệ của thông tin hàng xuất
            //
            if (Business.ListChiTietChungTu.Count == 0 || gvSanPhamBan.RowCount == 0)
            {
                MessageBox.Show("Danh sách hàng bán không có." + "\nHãy nhập dữ liệu hàng bán", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.btnThanhToan.Focus();
                return false;
            }
            //
            //Sự hợp lệ của thông tin kho xuất
            //
            if (this.bteKhoXuat.Tag == null)
            {
                MessageBox.Show("Phải chọn kho xuất." + "\nHãy chọn kho xuất", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.bteKhoXuat.Focus();
                return false;
            }
            if (this.bteThuongVien.Tag == null)
            {
                MessageBox.Show("Chưa chọn nhân viên." + "\n" + "-Hãy chọn nhân viên", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.bteThuongVien.Focus();
                return false;
            }
            //
            //Sự hợp lệ của thông tin khách hàng
            //
            if (this.bteKhachHang.Tag == null && LoaiChungTu != (int)TransactionType.DON_HANG_GIAO_NHAN)
            {
                MessageBox.Show("Chưa chọn khách hàng." + "\nHãy chọn khách hàng", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.bteKhachHang.Focus();
                return false;
            }
            if (txtHoTenKhachHang.Text.Trim().Equals("") && LoaiChungTu != (int)TransactionType.DON_HANG_GIAO_NHAN)
            {
                MessageBox.Show("Tên khách hàng không được để trống", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtHoTenKhachHang.Focus();
                return false;
            }
            if (txtDiaChiHD.Text.Trim().Equals("") && LoaiChungTu != (int)TransactionType.DON_HANG_GIAO_NHAN)
            {
                MessageBox.Show("Địa chỉ khách hàng không được để trống", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtDiaChiHD.Focus();
                return false;
            }
            //
            //Sự hợp lệ của thông tin số phiếu xuất
            //
            if (this.txtSoOrderKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Số giao dịch chưa nhập." + "\nHãy nhập số giao dịch", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtSoOrderKH.Focus();
                return false;
            }
            //Kiem tra trung so phieu
            if (BanHangDataProvider.Instance.ExistChungTu(Business.ChungTu.LoaiChungTu, txtSoOrderKH.Text.Trim(), (int)SearchOrderType.SOCHUNGTU, Business.ChungTu.IdChungTu))//trung sochungtu
            {
                MessageBox.Show("Số phiếu này đã có." + "\nHãy nhập lại", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtSoOrderKH.Focus();
                return false;
            }
            ////Kiem tra hop le hoa don
            if (this.txtSoSerie.Text.Trim().Length == 0 && LoaiChungTu == (int)TransactionType.DON_HANG_BU_KHUYEN_MAI)//LoaiChungTu != (int)TransactionType.DON_HANG_GIAO_NHAN && LoaiChungTu != (int)TransactionType.DON_HANG_TAI_SHOP && LoaiChungTu != (int)TransactionType.DON_HANG_ONLINE)
            {
                MessageBox.Show("Số serie hóa đơn chưa nhập." + "\n" + "-Hãy nhập Số serie hóa đơn", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtSoSerie.Focus();
                return false;
            }
            if (!String.IsNullOrEmpty(txtSoSerie.Text.Trim()))
            {
                string soseri = txtSoSerie.Text.Trim();
                string kyhieu = cboQuyen.Text.IndexOf("(") > -1
                                    ? cboQuyen.Text.Substring(0, cboQuyen.Text.IndexOf("("))
                                    : cboQuyen.Text;

                if ((Business.ChungTu.IdChungTu == 0 || Business.ChungTu.IdChungTu > 0 && (Business.ChungTu.SoSeri == null || !Business.ChungTu.SoSeri.Equals(soseri))) && cboQuyen.SelectedValue == null || cboQuyen.SelectedValue != null &&
                    !SuDungHoaDonDataProvider.CheckSoHoaDon(Common.IntValue(soseri), Business.ChungTu.IdChungTu, soseri, kyhieu) && LoaiChungTu != (int)TransactionType.DON_HANG_GIAO_NHAN)
                {
                    MessageBox.Show("Chưa chọn ký hiệu hoặc số hóa đơn này không sử dụng được.\nHãy nhập số hóa đơn khác", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtSoSerie.Focus();
                    return false;
                }
            }
            //if (this.bteThoiHanThanhToan.Tag == null && LoaiChungTu != (int)TransactionType.DON_HANG_GIAO_NHAN)
            //{
            //    MessageBox.Show("Chưa chọn thông tin thời hạn thanh toán." + "\nHãy chọn thời hạn thanh toán", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.bteThoiHanThanhToan.Focus();
            //    return false;
            //}
            if (this.cboLoaiHoaDon.SelectedIndex != 0 && LoaiChungTu != (int)TransactionType.DON_HANG_GIAO_NHAN)
            {
                MessageBox.Show("Đây là đơn hàng bán chịu thuế." + "\nHãy chọn lại loại hóa đơn bán", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboLoaiHoaDon.Focus();
                return false;                
            }
            //if (Business.ListChungTuThanhToan.Count == 0 && LoaiChungTu != (int)TransactionType.DON_HANG_GIAO_NHAN && LoaiChungTu != (int)TransactionType.DON_HANG_ONLINE)
            //{
            //    MessageBox.Show("Chưa chọn thông tin thanh toán." + "\nHãy chọn hình thức thanh toán", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.btnThanhToan.Focus();
            //    return false;
            //}
            if ((Common.DoubleValue(txtTienThucTra.Text) > Common.DoubleValue(txtTongTienThanhToan.Text) || Common.DoubleValue(txtTienConNo.Text) < 0) && LoaiChungTu != (int)TransactionType.DON_HANG_GIAO_NHAN)
            {
                MessageBox.Show("Tiền thực trả không thể lớn hơn số tiền cần thanh toán!");
                return false;
            }
            //kiem tra han muc tin dung tung khach le
            if (bteKhachLe.Tag != null)
            {
                DMDoiTuongInfo dt = (DMDoiTuongInfo)bteKhachLe.Tag;
                double tienConNo = Common.DoubleValue(txtTienConNo.Text);
                if (dt.HanMucTinDung > 0 && tienConNo > 0 && dt.HanMucTDConLai < tienConNo && Business.ChungTu.IdChungTu == 0)
                {
                    MessageBox.Show(String.Format("Số tiền nợ đã vượt quá hạn mức tín dụng còn lại [{0}] của khách hàng {1} - {2}", Common.Double2Str(dt.HanMucTDConLai), dt.MaRieng, dt.TenDoiTuong), Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            //kiem tra han muc tin dung tung khach hang
            if (bteKhachHang.Tag != null)
            {
                DMDoiTuongInfo dt = (DMDoiTuongInfo)bteKhachHang.Tag;
                double tienConNo = Common.DoubleValue(txtTienConNo.Text);
                if (dt.HanMucTinDung > 0 && tienConNo > 0 && dt.HanMucTDConLai < tienConNo && Business.ChungTu.IdChungTu == 0)
                {
                    MessageBox.Show(String.Format("Số tiền nợ đã vượt quá hạn mức tín dụng còn lại [{0}] của khách hàng {1} - {2}", Common.Double2Str(dt.HanMucTDConLai), dt.MaDoiTuong, dt.TenDoiTuong), Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            
            //hah: bo sung 16/01/2014
            if (Business.ChungTu.IdChungTu == 0 && this.cboGiaoHang.SelectedIndex > 0 && mstNgayHenGiaoHang.Value < CommonProvider.Instance.GetSysDate())
            {
                MessageBox.Show("Ngày giao hàng không thể chọn thời điểm quá khứ!", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.mstNgayHenGiaoHang.Focus();
                return false;                
            }

            if (this.cboGiaoHang.SelectedIndex > 0 && mstNgayLapPhieu.Value > mstNgayHenGiaoHang.Value)
            {
                MessageBox.Show("Ngày giao hàng không thể trước ngày lập phiếu được." + "\nHãy nhập lại ngày giao hàng", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.mstNgayHenGiaoHang.Focus();
                return false;
            }

            if (Business.ListChungTuThanhToan.Count != 0)
            {
                foreach (ChungTuThanhToanInfor tt in Business.ListChungTuThanhToan)
                {
                    if (String.IsNullOrEmpty(tt.HinhThucThanhToan) || tt.IdHinhThucThanhToan == 0)
                    {
                        MessageBox.Show(String.Format("Phiếu thu [{0}] chưa chọn hình thức thanh toán",tt.SoPhieu));
                        return false;
                    }
                    List<ChungTuThanhToanInfor> arTT =
                        Business.ListChungTuThanhToan.FindAll(
                            delegate(ChungTuThanhToanInfor match) { return match.SoPhieu.Equals(tt.SoPhieu); });
                    if (arTT.Count > 1)
                    {
                        MessageBox.Show(String.Format("Phiếu thu [{0}] bị trùng nhiều lần", tt.SoPhieu));
                        return false;
                    }
                }
            }


            return true;
        }

        private bool ValidCTThanhToan(ChungTuBanHangChiTietInfor ct)
        {
            List<BangGiaChinhSachInfor> liChinhSach = new List<BangGiaChinhSachInfor>();
            if (ct.ChinhSach != null) liChinhSach.Add(ct.ChinhSach);
            if (ct.ListChinhSachDefault != null && ct.ListChinhSachDefault.Count > 0)
                liChinhSach.AddRange(ct.ListChinhSachDefault);

            foreach (BangGiaChinhSachInfor cs in liChinhSach)
            {
                double tongTienHang = 0;
                foreach (
                    ChungTuBanHangChiTietInfor ctu in (BindingList<ChungTuBanHangChiTietInfor>) gSanPhamBan.DataSource)
                {
                    if ((ctu.IdSanPhamBan == 0 || ctu.LoaiHangKem == 1) && !Common.Int2Bool(ctu.ChietKhau))
                    {
                        tongTienHang += ctu.ThanhTien;
                    }
                }
                //kiem tra dieu kien gia tri don hang dua tren san pham chinh
                if (cs.GiaTriHDToiThieu > tongTienHang)
                {
                    MessageBox.Show(
                        String.Format("Giá trị đơn hàng chưa đạt yêu cầu tối thiểu [{0}]",
                                      Common.Double2Str(cs.GiaTriHDToiThieu)), Declare.titleNotice,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                //kiem tra so tien thanh toan toi thieu
                if (cs.SoTienTToanToiThieu > Common.DoubleValue(txtTienThucTra.Text))
                {
                    MessageBox.Show(
                        String.Format("Chưa đủ số tiền thanh toán tối [{0}]",
                                      Common.Double2Str(cs.SoTienTToanToiThieu)), Declare.titleNotice,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                //kiem tra dieu kien thanh toan toi thieu
                double tyleTT = Common.DoubleValue(txtTongTienThanhToan.Text) == 0
                                    ? 100
                                    : Common.DoubleValue(txtTienThucTra.Text)*100/
                                      Common.DoubleValue(txtTongTienThanhToan.Text);

                if (cs.ThanhToanToiThieu > tyleTT)
                {
                    MessageBox.Show(
                        String.Format("Giá trị thanh toán phải đạt tối thiểu {0}%", cs.ThanhToanToiThieu),
                        Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            return true;
        }

        private bool ValideDonHangDaMua(ChungTuBanHangChiTietInfor ct)
        {
            List<BangGiaChinhSachInfor> liChinhSach = new List<BangGiaChinhSachInfor>();
            if (ct.ChinhSach != null) liChinhSach.Add(ct.ChinhSach);
            if (ct.ListChinhSachDefault != null && ct.ListChinhSachDefault.Count > 0)
                liChinhSach.AddRange(ct.ListChinhSachDefault);

            foreach (BangGiaChinhSachInfor cs in liChinhSach)
            {
                //kiem  tra hd da mua
                if (cs.GiaTriDHDaMua > 0)
                {
                    if (String.IsNullOrEmpty(txtSoHDDaMua.Text))
                    {
                        MessageBox.Show("Phải nhập vào đơn hàng đã mua!");
                        this.txtSoHDDaMua.Focus();
                        return false;
                    }

                    if (!BanHangDataProvider.Instance.ExistChungTuDaMua(Business.ChungTu.LoaiChungTu,
                                                                        txtSoHDDaMua.Text.Trim(), txtCMND.Text.Trim(),
                                                                        txtDienThoai.Text.Trim(), cs.GiaTriDHDaMua,
                                                                        cs.ThoiHanMua, Business.ChungTu.IdChungTu))
                    {
                        MessageBox.Show(
                            String.Format("Cần có HĐ mua đã có giá trị tối thiểu {0} đã mua trước đó {1} ngày!",
                                          cs.GiaTriDHDaMua, cs.ThoiHanMua), Declare.titleNotice,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txtSoHDDaMua.Focus();
                        return false;
                    }
                    if (BanHangDataProvider.Instance.ExistChungTu(-1, txtSoHDDaMua.Text.Trim(),
                                                                  (int)SearchOrderType.SOHDDAMUA,
                                                                  Business.ChungTu.IdChungTu))
                    {
                        MessageBox.Show(
                            String.Format("Số Hóa đơn {0} đã được sử dụng để mua rồi, Xin hãy chọn Hóa đơn khác!",
                                          txtSoHDDaMua.Text.Trim()), Declare.titleNotice, MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.txtSoHDDaMua.Focus();
                        return false;
                    }
                }
                //kiem tra don hang da mua
                if (cs.ListBangGiaADDKMua == null) return true;
                foreach (BangGiaADDKMuaInfor dkm in cs.ListBangGiaADDKMua)
                {
                    foreach (BangGiaADSPDaMuaInfor spm in dkm.ListSanPhamDaMua)
                    {
                        if (String.IsNullOrEmpty(txtSoHDDaMua.Text))
                        {
                            MessageBox.Show("Phải nhập vào đơn hàng đã mua!");
                            this.txtSoHDDaMua.Focus();
                            return false;
                        }

                        if (
                            !BanHangDataProvider.Instance.ExistMatHangDaMua(txtSoHDDaMua.Text.Trim(), spm.MaHangDaMua,
                                                                            spm.LoaiHangDaMua,
                                                                            CommonProvider.Instance.GetSysDate().AddDays
                                                                                (-cs.ThoiHanMua)))
                        {
                            MessageBox.Show(
                                String.Format("Chỉ áp dụng với các đơn hàng đã mua mặt hàng {0}!", spm.TenHangDaMua),
                                Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        
        private bool ValideCTChinhSachChung(ChungTuBanHangChiTietInfor ct)
        {
            List<BangGiaChinhSachInfor> liChinhSach = new List<BangGiaChinhSachInfor>();
            if (ct.ChinhSach != null) liChinhSach.Add(ct.ChinhSach);
            if (ct.ListChinhSachDefault != null && ct.ListChinhSachDefault.Count > 0)
                liChinhSach.AddRange(ct.ListChinhSachDefault);

            foreach (BangGiaChinhSachInfor cs in liChinhSach)
            {
                //kiem tra duy nhat CMND
                if (Common.Int2Bool(cs.DuyNhatCMND) && txtCMND.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Chương trình này yêu cầu phải nhập vào Số CMND", Declare.titleNotice,
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCMND.Focus();
                    return false;
                }
                if (Common.Int2Bool(cs.DuyNhatCMND) &&
                    BanHangDataProvider.Instance.ExistChungTu(Business.ChungTu.LoaiChungTu, txtCMND.Text.Trim(),
                                                              (int) SearchOrderType.SOCMND, Business.ChungTu.IdChungTu,
                                                              cs.NgayHieuLuc, cs.HanHieuLuc))
                {
                    MessageBox.Show("Số CMND này đã được sử dụng", Declare.titleNotice, MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    txtCMND.Focus();
                    return false;
                }
                //kiem tra duy nhat sdt
                if (Common.Int2Bool(cs.DuyNhatSDT) && txtDienThoai.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Chương trình này yêu cầu phải nhập vào Số điện thoại", Declare.titleNotice,
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDienThoai.Focus();
                    return false;
                } //phai kiem tra theo san pham nua
                if (Common.Int2Bool(cs.DuyNhatSDT) &&
                    BanHangDataProvider.Instance.ExistChungTu(Business.ChungTu.LoaiChungTu, txtDienThoai.Text.Trim(),
                                                              (int) SearchOrderType.SODIENTHOAI, Business.ChungTu.IdChungTu, 
                                                              cs.NgayHieuLuc, cs.HanHieuLuc))
                {
                    MessageBox.Show("Số điện thoại này đã được sử dụng", Declare.titleNotice, MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    txtDienThoai.Focus();
                    return false;
                }
            }
            if (ct.ChinhSach == null) return true;
            //kiem tra do tuoi
            if (ct.ChinhSach.DoTuoiTu > 0 && txtTuoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chương trình này yêu cầu phải nhập vào độ tuổi", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTuoi.Focus();
                return false;
            }
            if (ct.ChinhSach.DoTuoiTu > 0 && (Common.IntValue(txtTuoi.Text) < ct.ChinhSach.DoTuoiTu || Common.IntValue(txtTuoi.Text) > ct.ChinhSach.DoTuoiDen))
            {
                MessageBox.Show(String.Format("Độ tuổi phải nằm trong khoảng [{0} - {1}]", ct.ChinhSach.DoTuoiTu, ct.ChinhSach.DoTuoiDen), Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTuoi.Focus();
                return false;
            }
            //kiem tra gioi tinh
            if (ct.ChinhSach.GioiTinh > 0 && cboGioiTinh.SelectedIndex <= 0)
            {
                MessageBox.Show("Chương trình này yêu cầu phải chọn giới tính", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboGioiTinh.Focus();
                return false;
            }
            if (ct.ChinhSach.GioiTinh > 0 && ct.ChinhSach.GioiTinh != cboGioiTinh.SelectedIndex)
            {
                MessageBox.Show(String.Format("Giới tính phải là {0}", cboGioiTinh.Items[ct.ChinhSach.GioiTinh]), Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboGioiTinh.Focus();
                return false;
            }
            //kiem tra nghe nghiep
            if (ct.ChinhSach.IdNgheNghiep > 0 && cboNgheNghiep.SelectedIndex == -1)
            {
                MessageBox.Show("Chương trình này yêu cầu phải chọn nghề nghiệp", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboNgheNghiep.Focus();
                return false;
            }
            if (ct.ChinhSach.IdNgheNghiep > 0 && ct.ChinhSach.IdNgheNghiep != Common.IntValue(cboNgheNghiep.SelectedValue))
            {
                DmNgheNghiepInfor nn = liNgheNghiep.Find(delegate(DmNgheNghiepInfor t)
                {
                    return t.IdNgheNghiep == ct.ChinhSach.IdNgheNghiep;
                });
                MessageBox.Show(String.Format("Chỉ áp dụng cho đối tượng là {0}", nn.TenNgheNghiep), Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboNgheNghiep.Focus();
                return false;
            }

            return true;
        }
        private bool ValideCTDiaDiem(ChungTuBanHangChiTietInfor ct)
        {
            if (ct.ChinhSach == null) return true;
            //kiem tra dia diem
            if (ct.ChinhSach.IdTinh > 0 && bteTinh.Tag == null)
            {
                MessageBox.Show("Chương trình này yêu cầu phải chọn tỉnh", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                bteTinh.Focus();
                return false;
            }
            if (ct.ChinhSach.IdTinh > 0 && bteTinh.Tag != null && ct.ChinhSach.IdTinh != ((DMTinhInfor)bteTinh.Tag).IdTinh)
            {
                DMTinhInfor tinh = DMTinhDataProvider.Instance.GetTinhThanhById(ct.ChinhSach.IdTinh);
                MessageBox.Show(String.Format("Chỉ áp dụng cho tỉnh {0}", tinh.TenTinh), Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                bteTinh.Focus();
                return false;
            }
            if (ct.ChinhSach.IdHuyen > 0 && bteHuyen.Tag == null)
            {
                MessageBox.Show("Chương trình này yêu cầu phải chọn huyện", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                bteHuyen.Focus();
                return false;
            }
            if (ct.ChinhSach.IdHuyen > 0 && bteHuyen.Tag != null && ct.ChinhSach.IdHuyen != ((DMHuyenInfor)bteHuyen.Tag).IdTinh)
            {
                DMHuyenInfor huyen = DMHuyenDataProvider.Instance.GetQuanHuyenById(ct.ChinhSach.IdHuyen);
                MessageBox.Show(String.Format("Chỉ áp dụng cho huyện {0}", huyen.TenHuyen), Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                bteHuyen.Focus();
                return false;
            }
            return true;
        }

        private bool ValidHinhThucThanhToan(ChungTuBanHangChiTietInfor ct)
        {
            chkVoucher.Checked = false;

            List<BangGiaChinhSachInfor> liChinhSach = new List<BangGiaChinhSachInfor>();
            if (ct.ChinhSach != null) liChinhSach.Add(ct.ChinhSach);
            if (ct.ListChinhSachDefault != null && ct.ListChinhSachDefault.Count > 0)
                liChinhSach.AddRange(ct.ListChinhSachDefault);

            bool found = false;

            foreach (BangGiaChinhSachInfor cs in liChinhSach)
            {
                if (cs.ListBangGiaADThanhToan != null)
                {
                    foreach (BangGiaADBankInfor ttoan in cs.ListBangGiaADThanhToan)
                    {
                        double soTienTT = 0;

                        if (ttoan.HinhThucThanhToan.Contains("không cần theo dõi") &&
                            (Business.ListChungTuThanhToan.Count == 0) &&
                            (ttoan.IdNganHang == 0) && (ttoan.IdNganHangPH == 0) && (ttoan.IdThoiHanTT == 0))
                        {
                            found = true;
                            break;
                        }

                        if (ttoan.HinhThucThanhToan.ToUpper().Equals("VOUCHER"))
                        {
                            chkVoucher.Checked = true;
                            found = true;
                            break;
                        }
                        foreach (ChungTuThanhToanInfor ctu in Business.ListChungTuThanhToan)
                        {
                            if ((ctu.IdHinhThucThanhToan == ttoan.IdHinhThucTT ||
                                 ttoan.HinhThucThanhToan.Contains("không cần theo dõi")) &&
                                (ctu.IdThoiHanThanhToan == ttoan.IdThoiHanTT || ttoan.IdThoiHanTT == 0) &&
                                (ttoan.IdNganHang == 0 || ctu.IdNganHangThanhToan == ttoan.IdNganHang) &&
                                (ttoan.IdNganHangPH == 0 || ctu.IdNganHangPhatHanhThe == ttoan.IdNganHangPH))
                            {
                                found = true;
                                soTienTT += ctu.SoTienThanhToan;
                                //break;
                            }
                        }
                        if (!found)
                        {
                            MessageBox.Show(
                                String.Format(
                                    "Phải có hình thức thanh toán [{0}]\nNgân hàng thanh toán [{1}]\nNgân hàng phát hành [{2}]\nThời hạn thanh toán [{3}]",
                                    ttoan.HinhThucThanhToan, ttoan.TenNganHang, ttoan.TenNganHangPH,
                                    ttoan.ThoiHanThanhToan));
                            return false;
                        }
                        double tyLeTT = ct.ThanhTien == 0 ? 100 : soTienTT*100/ct.ThanhTien;
                        if (tyLeTT < ttoan.TyLeThanhToan)
                        {
                            MessageBox.Show(
                                String.Format(
                                    "Sản phẩm [{0}] phải thanh toán bằng hình thức thanh toán [{1}]\nNgân hàng thanh toán [{2}]\nNgân hàng phát hành [{3}]\nThời hạn thanh toán [{4}]\nThanh toán tối thiểu [{5}%]",
                                    ct.TenSanPham, ttoan.HinhThucThanhToan, ttoan.TenNganHang, ttoan.TenNganHangPH,
                                    ttoan.ThoiHanThanhToan, ttoan.TyLeThanhToan));
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        private bool ValidSoLuongDonHang(ChungTuBanHangChiTietInfor ct)
        {
            List<BangGiaChinhSachInfor> liChinhSach = new List<BangGiaChinhSachInfor>();
            if (ct.ChinhSach != null) liChinhSach.Add(ct.ChinhSach);
            if (ct.ListChinhSachDefault != null && ct.ListChinhSachDefault.Count > 0)
                liChinhSach.AddRange(ct.ListChinhSachDefault);
            foreach (BangGiaChinhSachInfor cs in liChinhSach)
            {
                //kiem tra so luong hang ban tren 1 don hang););
                if (cs.ListBangGiaADDKMua != null)
                {
                    foreach (BangGiaADDKMuaInfor dkm in cs.ListBangGiaADDKMua)
                    {
                        //so luong toi thieu 1 lan phai mua
                        if (dkm.SoLuongPhaiMua > 0 && ct.SoLuong < dkm.SoLuongPhaiMua)
                        {
                            MessageBox.Show(String.Format("Sản phẩm [{0}] phải mua với số lượng ít nhất là {1} {2}", ct.TenSanPham, dkm.SoLuongPhaiMua, ct.DonViTinh));
                            return false;
                        }
                        //so luong toi da 1 lan duoc mua
                        if (dkm.SoLuongToiDaDH > 0 && dkm.SoLuongToiDaDH < ct.SoLuong)
                        {
                            MessageBox.Show(String.Format("Sản phẩm [{0}] được mua 1 lần với số lượng nhiều nhất là {1} {2}",
                                                          ct.TenSanPham, dkm.SoLuongToiDaDH, ct.DonViTinh));
                            return false;
                        }
                        if (dkm.SoLuongDuocMua > 0 && (ct.SoLuong > dkm.SoLuongDuocMua || /*(!txtCMND.Text.Trim().Equals("") || !txtDienThoai.Text.Trim().Equals("")) &&*/ dkm.SoLuongDuocMua <= BanHangDataProvider.Instance.SoLuongMatHangDaMua(-1, -1, ct.MaSanPham, 6, ct.ChinhSach.NgayHieuLuc, ct.ChinhSach.HanHieuLuc, txtCMND.Text.Trim(), txtDienThoai.Text.Trim(), dkm.IdDKMua, Business.ChungTu.IdChungTu)))
                        {
                            MessageBox.Show(String.Format("Sản phẩm [{0}] được mua số lượng nhiều nhất là {1} {2}",
                                                          ct.TenSanPham, dkm.SoLuongDuocMua, ct.DonViTinh));
                            return false;
                        }
                    }
                }                
            }

            ////kiem tra so don hang duoc mua
            //if (ct.ChinhSach.SoKhachDauNgay > 0 && ct.ChinhSach.SoKhachDauNgay <= BanHangDataProvider.Instance.SoChungTuDaMua(-1, -1, ct.MaSanPham, 6, ct.ChinhSach.NgayHieuLuc, ct.ChinhSach.HanHieuLuc, "", ""))
            //{
            //    MessageBox.Show(
            //        String.Format("Số lượng đơn hàng đã vượt giới hạn cho phép [{0} đơn hàng]",
            //                      ct.ChinhSach.SoKhachDauNgay), Declare.titleNotice, MessageBoxButtons.OK,
            //        MessageBoxIcon.Information);
            //    return false;
            //}
            ////kiem tra so don hang theo tung sieu thi
            //if (ct.ChinhSach.ListBangGiaADShop != null)
            //{
            //    foreach (BangGiaADShopInfor shop in ct.ChinhSach.ListBangGiaADShop)
            //    {
            //        if (shop.SoLuongDonHang > 0 && shop.IdTrungTam == _IdTrungTam && (shop.IdKho == ((DMKhoInfo)bteKhoXuat.Tag).IdKho || shop.IdKho == 0) &&
            //            shop.SoLuongDonHang <= BanHangDataProvider.Instance.SoChungTuDaMua(shop.IdTrungTam, shop.IdKho, ct.MaSanPham, 6, ct.ChinhSach.NgayHieuLuc, ct.ChinhSach.HanHieuLuc, "", ""))
            //        {
            //            MessageBox.Show(
            //                String.Format("Số lượng đơn hàng đã vượt giới hạn cho phép [{0} đơn hàng của kho {1} - Trung tâm: {2}]",
            //                              shop.SoLuongDonHang, shop.TenKho, shop.TenTrungTam), Declare.titleNotice, MessageBoxButtons.OK,
            //                MessageBoxIcon.Information);
            //        }
            //    }
            //}
            return true;
        }
        private bool CheckTonKho(ChungTuBanHangChiTietInfor ct, int idKho)
        {
            if (ct.ChietKhau == 1) return true;
            BangGiaBanChiTietInfor spb;
            spb = liBangGiaBan.Find(delegate(BangGiaBanChiTietInfor match)
            {
                return (match.MaSanPham.Equals(ct.MaSanPham));
            });
            if (spb == null)
            {
                spb = BangGiaDataProvider.Instance.GetGiaBan(_IdTrungTam, idKho, ct.MaSanPham);
                liBangGiaBan.Add(spb);
            }
            if (ct.IdSanPhamBan == 0 || ct.IdSanPhamBan != 0 && ct.LoaiHangKem == 1)
            {
                if (ct.SoLuong > spb.TonKho)
                {
                    MessageBox.Show(String.Format("Sản phẩm {0} không đủ tồn để xuất!", ct.TenSanPham));
                    return false;
                }
                else
                {
                    spb.TonKho -= ct.SoLuong;
                }
            }
            else if (ct.IdSanPhamBan != 0 && ct.LoaiHangKem == 0)
            {
                if (ct.SoLuong > spb.TonKho)
                {
                    if (MessageBox.Show(String.Format("Sản phẩm khuyến mại {0} không đủ tồn để xuất!\n Bạn có đồng ý nợ khuyến mại (Yes/No)?", ct.TenSanPham), "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ct.NoKhuyenMai = ct.SoLuong - spb.TonKho;
                        ct.SoLuong = spb.TonKho;
                        spb.TonKho = 0;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    spb.TonKho -= ct.SoLuong;
                }
            }
            return true;
        }

        private bool ValidSoLuongChietKhau(ChungTuBanHangChiTietInfor ct)
        {
            if (ct.CSachChietKhau.TongTienChietKhau > 0)
            {
                //kiem tra so luong chiet khau
                if (ct.CSachChietKhau.SoLuongPhaiMua > 0 && ct.CSachChietKhau.SoLuongPhaiMua > ct.SoLuong)
                {
                    MessageBox.Show(String.Format("Số lượng chiết khấu phải lớn hơn {0}",
                                                  ct.CSachChietKhau.SoLuongPhaiMua));
                    return false;
                }
                if (ct.CSachChietKhau.SoLuongToiDaDH > 0 && ct.CSachChietKhau.SoLuongToiDaDH < ct.SoLuong)
                {
                    MessageBox.Show(String.Format("Số lượng chiết khấu tối đa không vượt quá {0}",
                                                  ct.CSachChietKhau.SoLuongToiDaDH));
                    return false;
                }
                //kiem tra so tien chiet khau co vuot qua ty le % tren don hang hay khong
                if (ct.TyLeCSachChietKhau != 0)
                {
                    double tyleCK = Common.DoubleValue(txtTongTienThanhToan.Text) == 0
                                        ? 0
                                        : ct.ThanhTien*100/Common.DoubleValue(txtTongTienThanhToan.Text);

                    if (Math.Abs(ct.TyLeCSachChietKhau) < tyleCK && ct.TyLeCSachChietKhau != -1)
                    {
                        MessageBox.Show(String.Format("Tỷ lệ chiết khấu vượt quá {0}% giá trị đơn hàng",
                                                      ct.TyLeCSachChietKhau));
                        return false;
                    }
                }
            }
            return true;
        }

        private bool ValidChungTuChietKhauInfor(ChungTuBanHangChiTietInfor ct)
        {
                //kiem tra duy nhat CMND
            if (Common.Int2Bool(ct.CSachChietKhau.DuyNhatCMND) && txtCMND.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chương trình chiết khấu này yêu cầu phải nhập vào Số CMND", Declare.titleNotice,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCMND.Focus();
                return false;
            }
            if (Common.Int2Bool(ct.CSachChietKhau.DuyNhatCMND) &&
                    BanHangDataProvider.Instance.ExistChungTu(Business.ChungTu.LoaiChungTu, txtCMND.Text.Trim(),
                                                              (int)SearchOrderType.SOCMND, Business.ChungTu.IdChungTu,
                                                              ct.CSachChietKhau.NgayHieuLuc, ct.CSachChietKhau.HanHieuLuc))
            {
                MessageBox.Show("Số CMND này đã được sử dụng", Declare.titleNotice, MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtCMND.Focus();
                return false;
            }
            //kiem tra duy nhat sdt
            if (Common.Int2Bool(ct.CSachChietKhau.DuyNhatSDT) && txtDienThoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chương trình này yêu cầu phải nhập vào Số điện thoại", Declare.titleNotice,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDienThoai.Focus();
                return false;
            }
            //phai kiem tra theo san pham nua
            if (Common.Int2Bool(ct.CSachChietKhau.DuyNhatSDT) &&
                    BanHangDataProvider.Instance.ExistChungTu(Business.ChungTu.LoaiChungTu, txtDienThoai.Text.Trim(),
                                                              (int)SearchOrderType.SODIENTHOAI, Business.ChungTu.IdChungTu,
                                                              ct.CSachChietKhau.NgayHieuLuc, ct.CSachChietKhau.HanHieuLuc))
            {
                MessageBox.Show("Số điện thoại này đã được sử dụng", Declare.titleNotice, MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtDienThoai.Focus();
                return false;
            }
            return true;
        }

        private bool ValidDonHangChietKhau(ChungTuBanHangChiTietInfor ct)
        {
            int count = 0;
            double amount = 0;
            int tongSL = 0;
            foreach (ChungTuBanHangChiTietInfor ctu in (BindingList<ChungTuBanHangChiTietInfor>)gvSanPhamBan.DataSource)
            {
                if (ctu.ChietKhau != 1 && (ctu.IdSanPhamBan == 0 || ctu.LoaiHangKem == 1))//(hang chinh + hang kem) không phải là chiết khâu
                {
                    bool validSP = true;
                    if (!ctu.ApDungChietKhau)
                    {
                        validSP = BanHangDataProvider.Instance.ValidMaChietKhau(ct.CSachChietKhau.IdDKMua,
                                                                                ctu.IdSanPham, ctu.DonGiaCoVat);
                    }
                    if (!validSP)
                    {
                        MessageBox.Show(String.Format("Chương trình chiết khấu này không áp dụng cho sản phẩm:\n{0}-{1}",
                              ctu.MaSanPham, ctu.TenSanPham));
                        return false;
                    }
                    else
                    //if (ctu.ApDungChietKhau)
                    {
                        //kiem tra so luong chiet khau
                        if (ct.CSachChietKhau.SoLuongPhaiMua > 0 && ct.CSachChietKhau.SoLuongPhaiMua > ctu.SoLuong)
                        {
                            MessageBox.Show(String.Format("Số lượng mặt hàng mua phải lớn hơn {0}",
                                                          ct.CSachChietKhau.SoLuongPhaiMua));
                            return false;
                        }
                        if (ct.CSachChietKhau.SoLuongToiDaDH > 0 && ct.CSachChietKhau.SoLuongToiDaDH < ctu.SoLuong)
                        {
                            MessageBox.Show(String.Format("Số lượng mặt hàng mua tối đa không vượt quá {0}",
                                                          ct.CSachChietKhau.SoLuongToiDaDH));
                            return false;
                        }

                        count++;
                        amount += ctu.ThanhTien;
                        tongSL += ctu.SoLuong;
                        ctu.ApDungChietKhau = true;
                    }
                }
            }

            if (count == 0)
            {
                MessageBox.Show(String.Format("Mã chiết khấu [{0}-{1}] không áp dụng cho các sản phẩm này", ct.MaSanPham, ct.TenSanPham));
                return false;
            }
            if (ct.CSachChietKhau.GiaTriHDToiThieu > 0 && ct.CSachChietKhau.GiaTriHDToiThieu > amount)
            {
                MessageBox.Show(
                    String.Format("Giá trị đơn hàng chưa đạt yêu cầu tối thiểu [{0}] để được chiết khấu [{1}-{2}]",
                                  ct.CSachChietKhau.GiaTriHDToiThieu, ct.MaSanPham, ct.TenSanPham));
                return false;
            }
            //kiem tra so luong mat hang duoc mua
            if (ct.CSachChietKhau.TongTienChietKhau == 0 && ct.CSachChietKhau.TyLeChietKhau > 0)
            {
                //if (ct.CSachChietKhau.SoLuongPhaiMua > 0 && ct.CSachChietKhau.SoLuongPhaiMua > tongSL)
                //{
                //    MessageBox.Show(String.Format("Số lượng mà hàng được mua phải lớn hơn {0}",
                //                                  ct.CSachChietKhau.SoLuongPhaiMua));
                //    return false;
                //}
                //if (ct.CSachChietKhau.SoLuongToiDaDH > 0 && ct.CSachChietKhau.SoLuongToiDaDH < tongSL)
                //{
                //    MessageBox.Show(String.Format("Số lượng mặt hàng được mua tối đa không vượt quá {0}",
                //                                  ct.CSachChietKhau.SoLuongToiDaDH));
                //    return false;
                //}
                if (ct.CSachChietKhau.SoLuongDuocMua > 0 && (tongSL > ct.CSachChietKhau.SoLuongDuocMua || (!txtCMND.Text.Trim().Equals("") || !txtDienThoai.Text.Trim().Equals("")) && ct.CSachChietKhau.SoLuongDuocMua <= BanHangDataProvider.Instance.SoLuongMatHangDaMua(-1, -1, ct.MaSanPham, 6, ct.CSachChietKhau.NgayHieuLuc, ct.CSachChietKhau.HanHieuLuc, txtCMND.Text.Trim(), txtDienThoai.Text.Trim(), ct.CSachChietKhau.IdDKMua, Business.ChungTu.IdChungTu)))
                {
                    MessageBox.Show(String.Format("Tổng số lượng mặt hàng được mua tối đa không vượt quá {0}",
                                                  ct.CSachChietKhau.SoLuongDuocMua));
                    return false;
                }
            }
            return true;
        }

        private bool ValidChungTuInfor()
        {
            if (!ValidChungTuCommonInfor())
                return false;
            //double tongTienThanhToan = Common.DoubleValue(txtTongTienThanhToan.Text);
            liBangGiaBan = new List<BangGiaBanChiTietInfor>();

            foreach (ChungTuBanHangChiTietInfor ct in Business.ListChiTietChungTu)
            {
                if (ct.MaSanPham.EndsWith(Declare.MA_DOI_DIEM))//diem tich luy
                {
                    continue;
                }
                if ((ct.IdSanPhamBan == 0/* || ct.IdSanPhamBan > 0 && ct.LoaiHangKem != 0*/) && !Declare.LstSuaGiaBan.Contains(";" + ct.MaSanPham + ";") && (ct.ChietKhau != 1) && (ct.DonGiaCoVat == 0 && ct.GiaTheoBangGia == 0 || ct.ThanhTien == 0 && ct.GiaTheoBangGia != 0/*CK don hang*//*tongTienThanhToan == 0*/) && nguoiDung.SupperUser != 1)
                {
                    MessageBox.Show("Không thể xuất sản phẩm có giá bằng 0");
                    return false;
                }
                if ((Business.ChungTu.LoaiChungTu == (int)TransactionType.DON_HANG_DAT_TRUOC) && Declare.LstSuaCKhauKoLenODT.Contains(";" + ct.MaSanPham + ";") && nguoiDung.SupperUser != 1)
                {
                    MessageBox.Show(String.Format("Đơn hàng ODT không thể có mã hàng sau:\n{0}-{1}", ct.MaSanPham,
                                                  ct.TenSanPham));
                    return false;
                }
                if ((Business.ChungTu.LoaiChungTu == (int)TransactionType.DON_HANG_TAI_SHOP) && Declare.LstSuaCKhauKoLenOD.Contains(";" + ct.MaSanPham + ";") && nguoiDung.SupperUser != 1)
                {
                    MessageBox.Show(String.Format("Đơn hàng OD không thể có mã hàng sau:\n{0}-{1}", ct.MaSanPham,
                                                  ct.TenSanPham));
                    return false;
                }
                if (TrangThaiDonHang == (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC)
                {
                    if (!CheckTonKho(ct, ((DMKhoInfo)this.bteKhoXuat.Tag).IdKho))
                        return false;
                }
                //kiem tra dieu kien tung chinh sach
                if (ct.ChinhSach != null || ct.ListChinhSachDefault != null && ct.ListChinhSachDefault.Count > 0)
                {
                    //chinh sach ban hang
                    if (!ValideCTChinhSachChung(ct))
                        return false;
                    //so luong don hang
                    if (!ValidSoLuongDonHang(ct))
                        return false;
                    //dieu kien thanh toan
                    if (!ValidCTThanhToan(ct))
                        return false;
                    //don hang da mua
                    if (!ValideDonHangDaMua(ct))
                        return false;                    
                    //hinh thuc thanh toan
                    if (!ValidHinhThucThanhToan(ct))
                        return false;
                    //dia diem ap dung
                    if (!ValideCTDiaDiem(ct))
                        return false;
                }
                //kiem tra dieu kien chiet khau
                if (ct.CSachChietKhau != null)
                {
                    //kiem tra dieu kien chiet khau
                    if (!ValidChungTuChietKhauInfor(ct))
                        return false;
                    //kiem tra so luong chiet khau
                    if (!ValidSoLuongChietKhau(ct))
                        return false;
                    //kiem tra don hang chiet khau
                    if (!ValidDonHangChietKhau(ct))
                        return false;                    
                }
            }

            if (cboGiaoHang.SelectedIndex < 1 && MessageBox.Show("Đơn hàng chưa xác nhận đi giao!!!\nBạn có đồng ý xác nhận không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return false;
            }
            Common.FormatText(this);

            return true;
        }

        private void LoadKhachHang()
        {
            DMDoiTuongInfo dmDoiTuong = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(_IdKhachHang);
            if (dmDoiTuong != null)
            {
                bteKhachHang.Text = dmDoiTuong.TenDoiTuong;
                bteKhachHang.Tag = dmDoiTuong;
                LoadDoiTuongInfor(dmDoiTuong);
            }
        }

        private void LoadQuyen()
        {
            int idNhanVien = nguoiDung.IdNhanVien;
            liSuDungHD = SuDungHoaDonDataProvider.Instance.LoadSuDungHoaDonEmpty(idNhanVien);

            if (liSuDungHD.Count > 0)
            {
                cboQuyen.DataSource = liSuDungHD;
                cboQuyen.DisplayMember = "KyHieu";
                cboQuyen.ValueMember = "IdQuyen";

                //LoadHoaDon(false);
            }
        }

        private void LoadHoaDon(bool show)
        {
            string serie = "";
            try
            {
                int ind = cboQuyen.SelectedIndex;
                string tmp = liSuDungHD[ind].SoHienTai.ToString();
                for (int i = 0; i < (Declare.DoDaiHoaDon - tmp.Length); i++)
                    serie += "0";
                serie += tmp;

                txtSoSerie.Text = serie;
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


        private void LoadThoiHanThanhToan()
        {
            DMLoaiThuChiInfor dmLoaiThuChi = DMLoaiThuChiDataProvider.GetListDmThuChiInfoFromOid(_IdThoiHanThanhToan);
            if (dmLoaiThuChi != null)
            {
                bteThoiHanThanhToan.Text = dmLoaiThuChi.Ten;
                bteThoiHanThanhToan.Tag = dmLoaiThuChi;
            }
        }
        private void LoadThuNgan()
        {
            DMNhanVienInfo nv = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(_IdThuNgan);
            if (nv != null)
            {
                bteThuNgan.Text = nv.HoTen;
                bteThuNgan.Tag = nv;
            }
        }
        private void LoadTruongCa()
        {
            DMNhanVienInfo nv = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(_IdTruongCa);
            if (nv != null)
            {
                bteTruongCa.Text = nv.HoTen;
                bteTruongCa.Tag = nv;
            }
        }

        private void LoadDMNgheNghiep()
        {
            liNgheNghiep = DMNgheNghiepDataProvider.Instance.GetListNgheNghiepInfors();
            cboNgheNghiep.DataSource = liNgheNghiep;
            cboNgheNghiep.DisplayMember = "TenNgheNghiep";
            cboNgheNghiep.ValueMember = "IdNgheNghiep";
            cboNgheNghiep.SelectedIndex = -1;            
        }

        private void LoadKhoXuat()
        {
            DMKhoInfo dmKho = DMKhoDataProvider.GetKhoByIdInfo(_IdKho);
            if (dmKho != null)
            {
                bteKhoXuat.Text = dmKho.TenKho;
                bteKhoXuat.Tag = dmKho;
            }
        }

        private void LoadTrungTam()
        {
            DMTrungTamInfor tt = DMTrungTamDataProvider.GetTrungTamByIdInfo(_IdTrungTam);
            if (tt != null)
            {
                grThongTin.Text = String.Format("Trung tâm: {0} - {1}", tt.MaTrungTam, tt.TenTrungTam);
            }
        }

        private void LoadLoaiHoaDon()
        {
            cboLoaiHoaDon.DataSource = DMLoaiHoaDonDataProvider.Instance.GetListLoaiHoaDonInfo();
            cboLoaiHoaDon.DisplayMember = "Ten";
            cboLoaiHoaDon.ValueMember = "Id";
            cboLoaiHoaDon.SelectedIndex = 0;
        }

        private void LoadMaDuAn()
        {
            List<DMDuAnInfor> liDuAn = DMDuAnDataProvider.Instance.GetListDuAnInfo();
            cboMaDuAn.DataSource = liDuAn;
            cboMaDuAn.DisplayMember = "TenDuAn";
            cboMaDuAn.ValueMember = "IdDuAn";
            cboMaDuAn.SelectedIndex = -1;
        }

        private void LoadComboBoxData()
        {
            try
            {
                LoadTrungTam();
                LoadKhoXuat();
                //LoadOrderType();
                LoadKhachHang();
                //LoadTienTe();
                //LoadMaVach();
                if (LoaiChungTu != (int)TransactionType.DON_HANG_GIAO_NHAN)
                {
                    LoadQuyen();
                }
                //LoadLoaiThuChi();
                //LoadDiaChiKH();
                //LoadBangKeThue();
                LoadLoaiHoaDon();
                //LoadMaDuAn();
                //LoadHinhThucTT();
                LoadDMNgheNghiep();
                LoadGioiTinh();
                LoadThuNgan();
                LoadTruongCa();
                LoadThoiHanThanhToan();
                LoadCaBanHang();
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
               
        private void LoadCaBanHang()
        {
            List<DmCaBanHangInfor> liCaBanHang = DMCaBanHangDataProvider.Instance.GetListCaBanHangInfors();
            if (liCaBanHang != null)
            {
                cboCaBanHang.DataSource = liCaBanHang;
                cboCaBanHang.DisplayMember = "CaBanHang";
                cboCaBanHang.ValueMember = "KyHieu";
            }
        }

        private void LoadGioiTinh()
        {
            cboGioiTinh.SelectedIndex = 0;
        }

        private void LoadChungTuInstance()
        {
            try
            {
                if (Business.ChungTu.IdChungTu != 0)
                {
                    LoadChungTuHeader();
                    LoadChungTuThanhToan();
                    LoadChungTuDetails();
                }
                else
                {
                    ResetChungTuInfor(null);
                }                
            }
            catch (Exception ex)
            {
                EventLogProvider.Instance.WriteLog(ex.ToString()
                                    + "\nUser: " + nguoiDung.TenDangNhap
                                    + "\nMay: " + Declare.TenMay
                                    + "\nIdChungTu: " + Business.ChungTu.IdChungTu.ToString()
                                    + "\nSoChungTu: " + Business.ChungTu.SoChungTu,
                                    this.Name);
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void LoadChungTuHeader()
        {
            LoaiChungTu = Business.ChungTu.LoaiChungTu;
            TrangThaiDonHang = Business.ChungTu.TrangThai;
            Draft = Business.ChungTu.Draft;

            _IdTrungTam = Business.ChungTu.IdTrungTam;
            _IdTrungTamHachToan = Business.ChungTu.IdTrungTamHachToan;
            LoadTrungTam();

            bteKhoXuat.Tag = DMKhoDataProvider.GetKhoByIdInfo(Business.ChungTu.IdKho);
            bteKhoXuat.Text = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).TenKho : "";
            if (LoaiChungTu != (int)TransactionType.DON_HANG_GIAO_NHAN)
            {
                bteKhachHang.Tag = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(Business.ChungTu.IdDoiTuong);
                bteKhachHang.Text = bteKhachHang.Tag != null ? ((DMDoiTuongInfo)bteKhachHang.Tag).TenDoiTuong : "";
            }
            chkTraLaiNCC.Checked = Common.Int2Bool(Business.ChungTu.IdLyDoGiaoDich);
            txtSoOrderKH.Text = Business.ChungTu.SoChungTu;
            mstNgayLapPhieu.Value = Business.ChungTu.NgayLap;
            if (Business.ChungTu.NgayHoaDon != DateTime.MinValue)
            {
                dteNgayHoaDon.EditValue = Business.ChungTu.NgayHoaDon;
            }
            else
            {
                dteNgayHoaDon.EditValue = null;
            }
            txtSoChungTuGoc.Text = Business.ChungTu.SoChungTuGoc; 
            //if (LoaiChungTu == (int)TransactionType.DON_HANG_DAT_TRUOC && TrangThaiDonHang == (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC)// &&
            //    //TrangThaiDonHang != (int)OrderStatus.DON_HANG_BAN_ONLINE && TrangThaiDonHang != (int)OrderStatus.XAC_NHAN_DON_HANG_GIAO_NHAN)
            //{
            //    txtSoChungTuGoc.Text = Business.ChungTu.SoChungTu;
            //}
            //else
            //{
            //    txtSoChungTuGoc.Text = Business.ChungTu.SoChungTuGoc;    
            //}            
            
            txtSoPhieuDC.Text = Business.ChungTu.SoPhieuDC;

            bteThuongVien.Tag = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(Business.ChungTu.IdNhanVien);
            bteThuongVien.Text = bteThuongVien.Tag != null ? ((DMNhanVienInfo)bteThuongVien.Tag).HoTen : "";
            bteTruongCa.Tag = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(Business.ChungTu.IdTruongCa);
            bteTruongCa.Text = bteTruongCa.Tag != null ? ((DMNhanVienInfo)bteTruongCa.Tag).HoTen : "";
            bteThuNgan.Tag = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(Business.ChungTu.IdThuNgan);
            bteThuNgan.Text = bteThuNgan.Tag != null ? ((DMNhanVienInfo)bteThuNgan.Tag).HoTen : "";
            txtDienThoai.Text = Business.ChungTu.DienThoai;
            txtCMND.Text = Business.ChungTu.SoCMND;

            cboCaBanHang.SelectedIndex = Business.ChungTu.CaBanHang;
            cboGiaoHang.SelectedIndex = Business.ChungTu.GiaoNhan;
            try
            {
                mstNgayHenGiaoHang.Value = Business.ChungTu.NgayHenGiaoHang;
            }
            catch
            {
                mstNgayHenGiaoHang.Value = CommonProvider.Instance.GetSysDate();
            }
            
            txtGhiChu.Text = Business.ChungTu.GhiChu;
            chkVoucher.Checked = Common.Int2Bool(Business.ChungTu.IdBangKeThue);

            if (LoaiChungTu != (int)TransactionType.DON_HANG_GIAO_NHAN)
            {
                cboQuyen.SelectedValue = Business.ChungTu.QuyenSo;
                //txtKyHieu.Text = Business.ChungTu.KyHieu;
                txtSoSerie.Text = Business.ChungTu.SoSeri;
                //cboBangKeThue.SelectedValue = Business.ChungTu.IdBangKeThue;
                //cboLoaiHoaDon.SelectedValue = Business.ChungTu.IdLoaiHdBanHang;
                cboLoaiHoaDon.SelectedIndex = 0;
                cboMaDuAn.SelectedValue = Business.ChungTu.IdDuAn;

                bteKhachLe.Tag = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(Business.ChungTu.IdKhachLe);
                bteKhachLe.Text = bteKhachLe.Tag != null ? ((DMDoiTuongInfo)bteKhachLe.Tag).MaRieng : "";
                //cboLoaiThe.SelectedValue = Business.ChungTu.LoaiTheKhachHang;
                //txtDiemTichLuy.Text = Common.Double2Str(Business.ChungTu.SoTienTichLuy);
                txtCongTy.Text = Business.ChungTu.CongTy;
                txtHoTenKhachHang.Text = Business.ChungTu.HoTen;
                cboGioiTinh.SelectedIndex = Business.ChungTu.GioiTinh > 2 ? 0 : Business.ChungTu.GioiTinh;
                txtTuoi.Text = Business.ChungTu.DoTuoi.ToString();
                txtMaSoThue.Text = Business.ChungTu.MaSoThue;
                txtEmail.Text = Business.ChungTu.Email;
                txtWebSite.Text = Business.ChungTu.Website;
                //txtSoTaiKhoan.Text = Business.ChungTu.SoTaiKhoan;
                //txtNganHang.Text = Business.ChungTu.NganHang;
                UtilFunctions.LoadTinhThanh(bteTinh, Business.ChungTu.IdTinhGH);
                UtilFunctions.LoadQuanHuyen(bteHuyen, Business.ChungTu.IdHuyenGH);
                txtDiaChi.Text = Business.ChungTu.DiaChi;
                UtilFunctions.LoadTinhThanh(bteTinhHD, Business.ChungTu.IdTinhHD);
                UtilFunctions.LoadQuanHuyen(bteHuyenHD, Business.ChungTu.IdHuyenHD);
                txtDiaChiHD.Text = Business.ChungTu.DiaChiHD;
                txtSoHDDaMua.Text = Business.ChungTu.SoHDDaMua;
                cboNgheNghiep.SelectedValue = Business.ChungTu.IdNgheNghiep;
            }
            txtTongTienHang.Text = Common.Double2Str(Business.ChungTu.TongTienHang);
            txtTongTienCK.Text = Common.Double2Str(Business.ChungTu.TongTienChietKhau);
            txtTongTienSauCK.Text = Common.Double2Str(Business.ChungTu.TongTienSauChietKhau);
            txtTongTienVAT.Text = Common.Double2Str(Business.ChungTu.TongTienVAT);
            txtTongTienThanhToan.Text = Common.Double2Str(Business.ChungTu.TongTienThanhToan);
            txtTienThucTra.Text = Common.Double2Str(Business.ChungTu.TienThanhToanThuc);
            txtTienConNo.Text = Common.Double2Str(Business.ChungTu.TienConNo);
            bteThoiHanThanhToan.Tag = DMLoaiThuChiDataProvider.GetListDmThuChiInfoFromOid(Business.ChungTu.HinhThucTra);
            bteThoiHanThanhToan.Text = bteThoiHanThanhToan.Tag != null ? ((DMLoaiThuChiInfor)bteThoiHanThanhToan.Tag).Ten : "";
        }
        private void LoadChungTuThanhToan()
        {
            Business.ListChungTuThanhToan =
                ThanhToanDataProvider.Instance.LoadAllThanhToanByCTu(Business.ChungTu.IdChungTu);
            //liChungTuThanhToanChiTiet = ThanhToanDataProvider.Instance.ConvertListFull2Pair(Business.ListChungTuThanhToan);
            gHinhThucThanhToan.DataSource = new BindingList<ChungTuThanhToanInfor>(Business.ListChungTuThanhToan);
        }
        private void LoadChungTuDetails()
        {
            if (Business.ListChiTietChungTu != null)
            {
                foreach (ChungTuBanHangChiTietInfor ct in Business.ListChiTietChungTu)
                {
                    if (ct.IdSanPhamBan == 0)
                        ct.TenLoaiHangKem = Declare.DescHangBan;
                    else if (ct.LoaiHangKem == 0)
                        ct.TenLoaiHangKem = Declare.DescKhuyenMai;
                    else if (ct.LoaiHangKem == 1)
                        ct.TenLoaiHangKem = Declare.DescHangKem;
                    ct.SoLuongOld = ct.SoLuong;
                    if (ct.IdSanPhamBan == 0 && ct.ChietKhau == 1 && ct.ThanhTien > 0)
                        ct.TyLeCSachChietKhau = -1;//de khong tinh lai chiet khau nua
                }
                //BanHangDataProvider.Instance.ConvertListChiTiet2BanKMai(Business.ListChiTietChungTu,
                //                                                        ref liChungTuBanHangChiTiet,
                //                                                        ref liChungTuKhuyenMaiChiTiet);
                gSanPhamBan.DataSource = new BindingList<ChungTuBanHangChiTietInfor>(Business.ListChiTietChungTu);
                //gSanPhamBan.DataSource = new BindingList<ChungTuBanHangChiTietInfor>(liChungTuBanHangChiTiet);
                //gHangKhuyenMai.DataSource = new BindingList<ChungTuBanHangChiTietInfor>(liChungTuKhuyenMaiChiTiet);
            }
        }
        #endregion

        private void ShowInfors()
        {
            this.Text = CommonFuns.Instance.GetOrderInfor(Business.ChungTu, Updating, LoaiGiaoDichBanHang.LAP_DONHANG_BAN);
            tsslTrangThai.Text = Common.GetOrderStatus(TrangThaiDonHang, Draft);

            tslInfor.Text = "Đơn hàng bán tại siêu thị";
            if (LoaiChungTu == (int)TransactionType.DON_HANG_TAI_SHOP)
            {
                tsbEdit.Text = "&Sửa (F6)";
                tslInfor.Text = "Đơn hàng bán tại siêu thị";
            }
            else if (LoaiChungTu == (int)TransactionType.DON_HANG_ONLINE)
            {
                tsbEdit.Text = "Chuyển ĐH &Online (F6)";
                tslInfor.Text = "Đơn hàng bán Online";
            }
            else if (LoaiChungTu == (int)TransactionType.DON_HANG_DAT_TRUOC)
            {
                tsbEdit.Text = "Chuyển ĐH &Đặt trước (F6)";
                tslInfor.Text = "Đơn hàng đặt mua trước";
            }
            else if (LoaiChungTu == (int)TransactionType.DON_HANG_GIAO_NHAN)
            {
                tsbEdit.Text = "Xác nhận &ĐH giao nhận (F6)";
                tslInfor.Text = "Đơn hàng kèm giao nhận";
            }

            if (TrangThaiDonHang == (int)OrderStatus.PHAN_CONG_GIAO_NHAN)
                tsbDelete.Text = "&Từ chối (F8)";
            else
                tsbDelete.Text = "&Hủy (F8)";

        }

        private void frmBH_LapDonHangBan_Load(object sender, EventArgs e)
        {
            try
            {
                //chkTinhKM.Visible = (nguoiDung.SupperUser == 1) ? true : false;
                lblDTHoanTien.Text = "";
                if (CommonProvider.Instance.IsKhacTinh() && IsKinhDoanhThiTruong)
                {
                    tsbAdd.Enabled = false;
                    tsbConfirm.Enabled = false;
                }

                LoadComboBoxData();
                if (Business.ChungTu.IdChungTu > 0)
                {
                    LoadChungTuInstance();
                    //Thiet lap trang thai item
                    if (ValidEditChungTu())
                        tsbEdit_Click(sender, e);
                    else
                    {
                        IsAdded = false;
                        Updating = false;
                        setEDItems();
                        setEDFunctions();                            
                        //if (nguoiDung.SupperUser == 1)
                        //{
                        //    EnableSuaGia();
                        //}

                        ShowInfors();                            
                    }
                }
                else
                {
                    tsbAdd_Click(sender, e);
                    //tsbSaoChepDHKhac_Click(sender, e);
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
            txtMaSanPham.Focus();

        }

        private void EnableSuaGia()
        {
            Updating = true;
            //set menu
            tsbAdd.Enabled = false;//them moi, chuyen don hang online, don dat hang truoc
            tsbCopy.Enabled = false;
            tsbEdit.Enabled = false;
            tsbUpdate.Enabled = false;
            tsbDelete.Enabled = false;
            tsbConfirm.Enabled = true;
            tsbPrint.Enabled = false;
            tsbPayment.Enabled = TrangThaiDonHang != (int)OrderStatus.PHAN_CONG_GIAO_NHAN;
            //set item
            //if (TrangThaiDonHang == (int)OrderStatus.XAC_NHAN_DON_HANG_GIAO_NHAN && nguoiDung.SupperUser == 1)
            //{
                btnXoaSanPham.Enabled = true;
                btnThemHang.Enabled = true;
                txtMaSanPham.Enabled = true;
            //}
            cboQuyen.Enabled = Updating;
            btnLoadQuyen.Enabled = Updating;
            txtSoSerie.Enabled = Updating;
            txtGhiChu.Enabled = true;
            ThanhTien.OptionsColumn.ReadOnly = false;
            GhiChu.OptionsColumn.ReadOnly = false;
            btnThanhToan.Enabled = true;
            btnXoaTT.Enabled = true;
            txtSoPhieuDC.Enabled = true;
        }

        private void frmBH_LapDonHangBan_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //if (!this.txtGhiChu.Focused && !this.dgvSanPhamBan.Focused && !this.txtMaVach.Focused && !this.dgvHangKhuyenMai.Focused)
                //{
                //    if (e.KeyCode == Keys.Enter)
                //    {
                //        SendKeys.Send("{TAB}");
                //        e.Handled = true;
                //        return;
                //    }
                //    else if (e.KeyCode == Keys.F2)
                //    {
                //        if (this.WindowState == FormWindowState.Maximized)
                //            this.WindowState = FormWindowState.Normal;
                //        else
                //            this.WindowState = FormWindowState.Maximized;
                //        e.Handled = true;
                //        return;
                //    }
                //}
                if (e.KeyCode == Keys.F3 && tsbAdd.Enabled)
                    this.tsbAdd_Click(sender, e);
                else if (e.KeyCode == Keys.F4 && tsbEdit.Enabled)
                    this.tsbEdit_Click(sender, e);
                else if (e.KeyCode == Keys.F2 && tsbUpdate.Enabled)
                    this.tsbUpdate_Click(sender, e);
                else if (e.KeyCode == Keys.F5 && tsbUpdate.Enabled)
                    this.tsbConfirm_Click(sender, e);
                else if (e.KeyCode == Keys.F8 && tsbDelete.Enabled)
                    this.tsbDelete_Click(sender, e);
                else if (e.KeyCode == Keys.F11 && tsbPrint.Enabled)
                    this.tsbPrint_Click(sender, e);
                else if (e.KeyCode == Keys.F9 && tsbPayment.Enabled)
                    this.tsbPayment_Click(sender, e);
                else if (e.KeyCode == Keys.F12 && tsbClose.Enabled)
                    this.tsbClose_Click(sender, e);
                else if (e.KeyCode == Keys.F10 && btnThanhToan.Enabled)
                    this.btnThanhToan_Click(sender, e);
                else if (e.KeyCode == Keys.F7 && tsbCapPhatThe.Enabled)
                    this.tsbCapPhatThe_Click(sender, e);
                
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

        private void InputDataFromCode(string code)
        {
            try
            {
                int IdKhoSelected = bteKhoXuat.Tag != null ? ((DMKhoInfo) bteKhoXuat.Tag).IdKho : 0;
                int IdTTamSelected = _IdTrungTam;

                if (_IdTrungTam == 0 || bteKhoXuat.Tag == null || _IdLoaiKhachHang == 0)
                {
                    MessageBox.Show("Phải chọn trung tâm và khách hàng");
                    return;
                }
                BangGiaBanChiTietInfor spb = null;
                if (!code.Equals(""))
                {
                    spb = BangGiaDataProvider.Instance.GetGiaBan(IdTTamSelected, IdKhoSelected, code);
                }
                if (spb == null)
                {
                    frmLookUp_HangHoa frm = new frmLookUp_HangHoa(false,
                                                                  (Common.Int2Bool(nguoiDung.SupperUser)
                                                                       ? -1
                                                                       : nguoiDung.IdNhomNguoiDung), 1, -1,
                                                                  IdKhoSelected, 1);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        spb = BangGiaDataProvider.Instance.GetGiaBan(IdTTamSelected, IdKhoSelected, frm.SelectedItem.MaSanPham);
                    }
                    else
                    {
                        return;
                    }
                }

                if (spb == null)
                {
                    MessageBox.Show("Giá chưa thiết lập!");
                    return;
                }
                //else if (spb.DonGiaCoVAT == 0 && nguoiDung.SupperUser != 1)
                //{
                //    MessageBox.Show("Hàng khuyến mại không được phép bán!");
                //    return;
                //}
                else if (spb.ChietKhau != 1 && spb.TonKho == 0)
                {
                    MessageBox.Show("Hàng đã hết tồn kho!");
                    return;
                }

                ChungTuBanHangChiTietInfor ctu =
                    Business.ListChiTietChungTu.Find(delegate(ChungTuBanHangChiTietInfor match)
                    { return match.MaSanPham == spb.MaSanPham && match.IdSanPhamBan == 0; });

                //hah: check đơn hàng đã xác nhận thì không sửa
                //if (TrangThaiDonHang != (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC &&
                //    !BanHangDataProvider.Instance.CheckValid_TrangThai_Draft(Business.ChungTu.IdChungTu))
                //{
                //    MessageBox.Show("Đơn hàng đã được xác nhận!");
                //    return;
                //}

                if (ctu != null)
                {
                    if (spb.ChietKhau != 1 && spb.TonKho < ctu.SoLuong+1)
                    {
                        MessageBox.Show("Không đủ hàng để xuất!");
                        return;                        
                    }
                    ChungTuBanHangChiTietInfor bk = (ChungTuBanHangChiTietInfor)ctu.Clone();
                    ctu.DonGia = (ctu.DonGia * ctu.SoLuong + spb.DonGiaChuaVAT) / (ctu.SoLuong + 1);
                    ctu.SoLuong += 1;
                    UpdateValueChiTiet(ctu);
                    ctu.SoLuongOld = ctu.SoLuong;
                    ((BindingList<ChungTuBanHangChiTietInfor>)gSanPhamBan.DataSource).ResetBindings();

                    if (!CommonFuns.Instance.LoadChinhSachKM(ctu, IdTTamSelected, IdKhoSelected, _IdLoaiKhachHang, (int)LoaiKhachHang.KHACH_TRUC_TIEP,
                                                        gSanPhamBan, Business.ListChiTietChungTu))
                    {
                        ctu.DonGia = bk.DonGia;
                        ctu.SoLuong = bk.SoLuong;
                        ctu.SoLuongOld = bk.SoLuongOld;
                        ctu.ThanhTien = bk.ThanhTien;
                        ctu.TienVAT = bk.TienVAT;
                        ctu.NoKhuyenMai = bk.NoKhuyenMai;
                        UpdateValueChiTiet(ctu);
                        ((BindingList<ChungTuBanHangChiTietInfor>)gSanPhamBan.DataSource).ResetBindings();
                    }
                }
                else
                {
                    //add san pham ban
                    ChungTuBanHangChiTietInfor ct = BanHangDataProvider.Instance.ConvertBG2SanPhamBan(spb);
                    ct.IdChungTu = Business.ChungTu.IdChungTu;
                    ((BindingList<ChungTuBanHangChiTietInfor>)gSanPhamBan.DataSource).Add(ct);
                    ((BindingList<ChungTuBanHangChiTietInfor>)gSanPhamBan.DataSource).ResetBindings();
                    //add khuyen mai
                    CommonFuns.Instance.LoadChinhSachKM(ct, IdTTamSelected, IdKhoSelected, _IdLoaiKhachHang, (int)LoaiKhachHang.KHACH_TRUC_TIEP,
                                                        gSanPhamBan, Business.ListChiTietChungTu);
                }

                UpdateSummariesInfors();
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

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            //hah: check đơn hàng đã xác nhận thì không sửa
            //if (TrangThaiDonHang != (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC &&
            //    !BanHangDataProvider.Instance.CheckValid_TrangThai_Draft(Business.ChungTu.IdChungTu))
            //{
            //    return;
            //}

            InputDataFromCode(txtMaSanPham.Text.Trim());
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (CommonProvider.Instance.IsKhacTinh() && IsKinhDoanhThiTruong)
                {
                    throw new ManagedException("Bạn đang ở tỉnh khác, không thể tạo đơn hàng");
                }

                if (_IdTrungTam == 0 || _IdLoaiKhachHang == 0 || bteKhoXuat.Tag == null || bteKhachHang.Tag == null)
                {
                    if (!ChonCaLamViec())
                        return;
                }
                ThemMoiDonHang(null);

                Updating = true;
                setEDItems();
                setEDFunctions();
                ShowInfors();
            }
            catch (ManagedException ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show(ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
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

        private void ThemMoiDonHang(ChungTuBanHangInfor old)
        {
            Draft = -1;
            IsAdded = true;
            ApDungTheThanhVien = false;
            ResetTheInfor();
            ResetChungTuInfor(old);
            LoaiChungTu = (int)TransactionType.DON_HANG_TAI_SHOP;
            TrangThaiDonHang = (int)OrderStatus.DON_HANG_BAN_TAI_SHOP;
            Business = new LapDonHangBusiness(LoaiChungTu, nguoiDung.IdNhanVien, ((DMKhoInfo) bteKhoXuat.Tag).IdKho);

            txtSoOrderKH.Prefix = Declare.Prefix.TaoDonHangBan;
            txtSoOrderKH.ReSet();//.Text = CommonProvider.Instance.GetSoPhieu(Declare.Prefix.TaoDonHangBan);
            _IdTrungTamHachToan = nguoiDung.IdTrungTamHachToan == 0 ? Declare.IdTrungTamHachToan : nguoiDung.IdTrungTamHachToan;

            Business.ListChiTietChungTu = new List<ChungTuBanHangChiTietInfor>();
            gSanPhamBan.DataSource = new BindingList<ChungTuBanHangChiTietInfor>(Business.ListChiTietChungTu);

            Business.ListChungTuThanhToan = new List<ChungTuThanhToanInfor>();
            gHinhThucThanhToan.DataSource = new BindingList<ChungTuThanhToanInfor>(Business.ListChungTuThanhToan);
        }
        private void tsbEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidEditChungTu())
                {
                    IsAdded = false;
                    Updating = true;
                    ApDungTheThanhVien = false;
                    setEDItems();
                    setEDFunctions();
                    ShowInfors();
                    if (LoaiChungTu == (int)TransactionType.DON_HANG_ONLINE)
                    {
                        mstNgayLapPhieu.Enabled = false;
                        bteThuongVien.Enabled = false;
                        //bteTruongCa.Enabled = false;
                        //bteThuNgan.Enabled = false;
                        txtDienThoai.Enabled = false;
                        txtCMND.Enabled = false;
                        //chkGiaoHang.Enabled = false;
                        //mstNgayHenGiaoHang.Enabled = false;
                        txtGhiChu.Enabled = false;

                        txtSoPhieuDC.Enabled = false;
                        cboMaDuAn.Enabled = false;

                        bteKhachLe.Enabled = false;
                        //txtDiemTichLuy.Enabled = false;
                        txtCongTy.Enabled = false;
                        txtHoTenKhachHang.Enabled = false;
                        cboGioiTinh.Enabled = false;
                        txtTuoi.Enabled = false;
                        txtMaSoThue.Enabled = false;
                        txtEmail.Enabled = false;
                        txtWebSite.Enabled = false;
                        txtDiaChi.Enabled = false;
                        bteTinhHD.Enabled = false;
                        bteHuyenHD.Enabled = false;
                        txtDiaChiHD.Enabled = false;
                        bteTinh.Enabled = false;
                        bteHuyen.Enabled = false;
                        txtDiaChi.Enabled = false;
                        txtSoHDDaMua.Enabled = false;

                        bteThoiHanThanhToan.Enabled = false;
                        bteKhoXuat.Enabled = false;
                        bteKhachHang.Enabled = false;
                        txtMaSanPham.Enabled = false;
                        btnThemHang.Enabled = false;

                        //btnChietKhau.Enabled = false;
                        btnXoaSanPham.Enabled = false;
                    }
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
        private bool ValidEditChungTu()
        {
            if (Business.ChungTu.IdChungTu == 0 || Business.ChungTu.IdChungTu > 0 && (
                    (LoaiChungTu == (int)TransactionType.DON_HANG_TAI_SHOP || LoaiChungTu == (int)TransactionType.DON_HANG_BU_KHUYEN_MAI) && TrangThaiDonHang == (int)OrderStatus.DON_HANG_BAN_TAI_SHOP && (Draft == 1 || nguoiDung.SupperUser == 1 || String.IsNullOrEmpty(Business.ChungTu.SoSeri)) ||
                      LoaiChungTu == (int)TransactionType.DON_HANG_GIAO_NHAN && ((TrangThaiDonHang == (int)OrderStatus.DON_HANG_BAN_TAI_SHOP || TrangThaiDonHang == (int)OrderStatus.XAC_NHAN_DON_HANG_GIAO_NHAN) && (Draft == 1 || nguoiDung.SupperUser == 1) || TrangThaiDonHang == (int)OrderStatus.PHAN_CONG_GIAO_NHAN) ||
                    LoaiChungTu == (int)TransactionType.DON_HANG_ONLINE && (TrangThaiDonHang == (int)OrderStatus.DON_HANG_BAN_ONLINE && (Draft == 1 || nguoiDung.SupperUser == 1 || String.IsNullOrEmpty(Business.ChungTu.SoSeri)) || TrangThaiDonHang == (int)OrderStatus.XAC_NHAN_DON_HANG_ONLINE) ||
                    LoaiChungTu == (int)TransactionType.DON_HANG_DAT_TRUOC && (TrangThaiDonHang == (int)OrderStatus.DON_HANG_BAN_DAT_TRUOC && (Draft == 1 || nguoiDung.SupperUser == 1 || String.IsNullOrEmpty(Business.ChungTu.SoSeri)) || TrangThaiDonHang == (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC)))
            {
                return true;
            }
            return false;
        }

        private void setEDKhachHangItems(bool isThe)
        {
            btnSaoChep.Enabled = !isThe;
            bteKhachLe.Properties.ReadOnly = true;// !Updating || LoaiChungTu != (int)TransactionType.DON_HANG_TAI_SHOP;
            bteKhachLe.Enabled = false;
            txtHoTenKhachHang.ReadOnly = isThe;
            //txtDiemTichLuy.ReadOnly = isThe;
            //txtCongTy.ReadOnly = isThe;

            txtDienThoai.ReadOnly = isThe;
            txtCMND.ReadOnly = isThe;

            cboGioiTinh.Enabled = !isThe;
            txtTuoi.ReadOnly = isThe;
            txtMaSoThue.ReadOnly = isThe;
            txtEmail.ReadOnly = isThe;
            txtWebSite.ReadOnly = isThe;
            bteTinhHD.Properties.ReadOnly = isThe;
            bteHuyenHD.Properties.ReadOnly = isThe;
            txtDiaChiHD.ReadOnly = isThe;
            cboNgheNghiep.Enabled = !isThe;
            //btnDoiDiemCN.Enabled = isThe;
        }
        private void setEDItems()
        {
            //txtSoOrderKH.Enabled = Updating && Business.ChungTu.IdChungTu == 0;// && CommonFuns.IsEditSoChungTu();
            mstNgayLapPhieu.Enabled = false;
            dteNgayHoaDon.Enabled = false;
            bteThuongVien.Properties.ReadOnly = !Updating;
            bteTruongCa.Properties.ReadOnly = !Updating;
            bteThuNgan.Properties.ReadOnly = !Updating;
            txtDienThoai.ReadOnly = !Updating;
            txtCMND.ReadOnly = !Updating;
            cboCaBanHang.Enabled = Updating;
            cboGiaoHang.Enabled = Updating;
            mstNgayHenGiaoHang.Enabled = Updating;
            txtGhiChu.ReadOnly = !Updating;
            cboLoaiHoaDon.Enabled = Updating;

            cboQuyen.Enabled = Updating;
            btnLoadQuyen.Enabled = Updating;
            //txtKyHieu.Enabled = Updating;
            txtSoSerie.ReadOnly = !Updating;
            txtSoPhieuDC.Properties.ReadOnly = !Updating;
            //txtShipTo.Enabled = Updating;
            //cboShipTo.Enabled = Updating;
            //txtBillTo.Enabled = Updating;
            //cboShipTo.Enabled = Updating;
            //txtOrderType.Enabled = Updating;
            //cboOrderType.Enabled = Updating;
            //cboBangKeThue.Enabled = Updating;
            //cboLoaiHoaDon.Enabled = Updating;
            cboMaDuAn.Enabled = Updating;

            bteKhachLe.Properties.ReadOnly = true;// !Updating || LoaiChungTu != (int)TransactionType.DON_HANG_TAI_SHOP;
            //txtDiemTichLuy.ReadOnly = !Updating;
            txtCongTy.ReadOnly = !Updating;
            
            cboGioiTinh.Enabled = Updating;
            txtTuoi.ReadOnly = !Updating;
            txtMaSoThue.ReadOnly = !Updating;
            txtEmail.ReadOnly = !Updating;
            txtWebSite.ReadOnly = !Updating;
            //txtSoTaiKhoan.Enabled = Updating;
            //txtNganHang.Enabled = Updating;
            txtDiaChi.ReadOnly = !Updating;
            bteTinhHD.Properties.ReadOnly = !Updating;
            bteHuyenHD.Properties.ReadOnly = !Updating;
            txtDiaChiHD.ReadOnly = !Updating;
            bteTinh.Properties.ReadOnly = !Updating;
            bteHuyen.Properties.ReadOnly = !Updating;
            txtDiaChi.ReadOnly = !Updating;
            txtSoHDDaMua.ReadOnly = !Updating;
            cboNgheNghiep.Enabled = Updating;

            btnXoaTT.Enabled = Updating;
            btnThanhToan.Enabled = Updating;
            btnSuaTToan.Enabled = Updating;
            bteThoiHanThanhToan.Properties.ReadOnly = !Updating;

            //bteKhoXuat.Properties.ReadOnly = !Updating;
            //bteKhachHang.Properties.ReadOnly = !Updating;
            //txtMaSanPham.ReadOnly = !Updating;
            //btnThemHang.Enabled = Updating;

            //btnChonKho.Enabled = Updating;
            bteKhoXuat.Properties.ReadOnly = !Updating || Draft == 0 && TrangThaiDonHang != (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC;
            bteKhachHang.Properties.ReadOnly = !Updating || LoaiChungTu != (int)TransactionType.DON_HANG_TAI_SHOP;
            txtMaSanPham.Enabled = Updating && (Draft != 0 || TrangThaiDonHang == (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC);
            btnThemHang.Enabled = Updating && (Draft != 0 || TrangThaiDonHang == (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC);

            btnSaoChep.Enabled = Updating;
            btnDoiDiemCN.Enabled = Common.IsEnableDoiDiemTien(_IdTrungTam) & Updating;
            btnDoiDiemRaTien.Enabled = Common.IsEnableDoiDiemTien(_IdTrungTam) & Updating && (Draft != 0 || TrangThaiDonHang == (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC || TrangThaiDonHang == (int)OrderStatus.XAC_NHAN_DON_HANG_ONLINE);
            btnChietKhau.Enabled = Updating && (Draft != 0 || TrangThaiDonHang == (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC || TrangThaiDonHang == (int)OrderStatus.XAC_NHAN_DON_HANG_ONLINE);
            btnXoaSanPham.Enabled = Updating && (Draft != 0 || TrangThaiDonHang == (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC || TrangThaiDonHang == (int)OrderStatus.XAC_NHAN_DON_HANG_ONLINE);
            //btnXoaKhuyenMai.Enabled = Updating;
            SoLuong.OptionsColumn.ReadOnly = !Updating || Draft == 0 && TrangThaiDonHang != (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC;
            ThanhTien.OptionsColumn.ReadOnly = !Updating;// || nguoiDung.SupperUser != 1 && nguoiDung.SuaChungTu != 1;
            GhiChu.OptionsColumn.ReadOnly = !Updating;
            GhiChuTT.OptionsColumn.ReadOnly = !Updating;

            if (LoaiChungTu==(int)TransactionType.DON_HANG_TAI_SHOP)
            {
                txtSoChungTuGoc.ReadOnly = !Updating;
            }
            if (Business.ChungTu.DaTichDiem == (int)TrangThaiTichDiem.DA_TICH_DIEM || Business.ChungTu.DaTichDiem == (int)TrangThaiTichDiem.CHO_DUYET_TICH_DIEM)
            {
                //chkCKNganhHang.Enabled = false;
                btnDoiDiemRaTien.Enabled = false;
                bteKhachLe.Enabled = false;
                txtHoTenKhachHang.ReadOnly = true;
                tsbCapPhatThe.Enabled = false;
            }
            else
            {
                txtHoTenKhachHang.ReadOnly = !Updating;
            }

            bool isEnabled = Common.IsEnableDoiDiemTien(_IdTrungTam);
            lblDTHoanTien.Visible = isEnabled;
            btnDoiDiemCN.Visible = isEnabled;
            btnDoiDiemRaTien.Visible = isEnabled;            
        }

        private void setEDFunctions()
        {
            tsbAdd.Enabled = !Updating;//them moi, chuyen don hang online, don dat hang truoc
            tsbCopy.Enabled = !Updating && (Business.ChungTu.IdChungTu > 0) &&
                              (LoaiChungTu == (int)TransactionType.DON_HANG_TAI_SHOP) &&
                              (TrangThaiDonHang != (int)OrderStatus.PHAN_CONG_GIAO_NHAN);
            tsbEdit.Enabled = !Updating && ValidEditChungTu();
            tsbUpdate.Enabled = Updating && (Draft != 0 || nguoiDung.SupperUser == 1);// || (TrangThaiDonHang != (int)OrderStatus.PHAN_CONG_GIAO_NHAN);//cap nhat
            tsbDelete.Enabled = ValidDeleteChungTu();
            tsbConfirm.Enabled = Updating;// || TrangThaiDonHang == (int)OrderStatus.PHAN_CONG_GIAO_NHAN;//xac nhan
            
            tsbPrint.Enabled = !Updating && (Business.ChungTu.IdChungTu > 0) && (Draft == 0 || nguoiDung.SupperUser == 1);
            tsbPayment.Enabled = Updating && (TrangThaiDonHang != (int)OrderStatus.PHAN_CONG_GIAO_NHAN);
            //if (Business.ChungTu.DaTichDiem == (int)TrangThaiTichDiem.DA_TICH_DIEM || Business.ChungTu.DaTichDiem == (int)TrangThaiTichDiem.CHO_DUYET_TICH_DIEM)
            //{
            //    tsbCapPhatThe.Enabled = false;
            //}
            //else
            //{
            //    tsbCapPhatThe.Enabled = Updating;
            //}
            Common.SetEDControl(false, false, tsbCapPhatThe);
        }

        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Draft = 1;
                if (UpdateChungTu(false))
                {
                    Updating = false;
                    setEDItems();
                    setEDFunctions();
                    ShowInfors();
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

        private bool UpdateChungTu(bool isIn)
        {
            int oldId = Business.ChungTu.IdChungTu;
            int oldTT = Business.ChungTu.TrangThai;
            string oldSCT = Business.ChungTu.SoChungTu;
            string oldSCTG = Business.ChungTu.SoChungTuGoc;
            //double tongTienOld = Business.ChungTu.TongTienThanhToan;
            //double tienNoOld = Business.ChungTu.TienConNo;
            //double tienTraTruoc = Business.ChungTu.TienThanhToanThuc;
            //bool traTruoc = false;

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (ValidChungTuInfor())
                {
                    ConnectionUtil.Instance.BeginTransaction();
                    //luu chung tu dat truoc
                    if (TrangThaiDonHang == (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC)
                    {
                        //cap nhat don hang goc
                        BanHangDataProvider.Instance.UpdateTrangThaiChungTu(Business.ChungTu.IdChungTu, (int)OrderStatus.DON_HANG_BAN_DAT_TRUOC);

                        //tao don hnag dat truoc hang ban
                        IsAdded = true;
                        Business.ChungTu.IdChungTu = 0;//tao chung tu moi
                        txtSoOrderKH.Text = "O" + Business.ChungTu.SoChungTu;
                        txtSoChungTuGoc.Text = Business.ChungTu.SoChungTu;
                    }

                    //if (TrangThaiDonHang == (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC)// || TrangThaiDonHang == (int)OrderStatus.TAO_DON_HANG_ONLINE)
                    //{
                    //    traTruoc = true;
                    //}

                    SaveChungTuInstance();
                    Business.SaveChungTu();
                    //cap nhat cong no khach hang
                    //if (traTruoc)
                    //    BanHangDataProvider.Instance.UpdateCongNoKhachHang(Business.ChungTu.IdKhachLe,
                    //                                                       Business.ChungTu.IdDoiTuong,
                    //                                                       0, tienTraTruoc, 0, 0, 
                    //                                                       Business.ChungTu.LoaiChungTu);

                    //BanHangDataProvider.Instance.UpdateCongNoKhachHang(Business.ChungTu.IdKhachLe,
                    //                                                   Business.ChungTu.IdDoiTuong,
                    //                                                   Business.ChungTu.TongTienThanhToan,
                    //                                                   Business.ChungTu.TienConNo, tongTienOld,
                    //                                                   tienNoOld, Business.ChungTu.LoaiChungTu);
                    //cap nhat so hoa don moi
                    SuDungHoaDonDataProvider.UpdateNextSoHoaDon(Business.ChungTu.QuyenSo,
                                                                Common.IntValue(Business.ChungTu.SoSeri));
                    //cap nhat diem tich luy
                    int soDiemTLuy  = 0;
                    bool showMsg = false;
                    if (ApDungTheThanhVien && this.IdTheThanhVien > 0 && bteKhachLe.Tag != null)
                    {
                        //he so tich diem theo chinh sach the
                        //string maTrungTam = DMTrungTamDataProvider.GetTrungTamByIdInfo(Business.ChungTu.IdTrungTam).MaTrungTam;
                        //double heSoTichDiem = ChinhSachTheTVienDataProvider.Instance.LoadHeSoApDung(maTrungTam, this.IdLoaiTheThanhVien, 
                        //                                                                            ((DMDoiTuongInfo)bteKhachHang.Tag).IdLoaiDoiTuong,
                        //                                                                            Business.ChungTu.TongTienThanhToan);
                        //double doanhSoHienTai = ((DMDoiTuongInfo) bteKhachLe.Tag).GiaTriMuaHang;
                        //soDiemTLuy = 
                        //ChinhSachTheTVienDataProvider.Instance.UpdateDiemTichLuyMuaHang(this.IdTheThanhVien, Business.ChungTu.IdChungTu,
                        //                                                                doanhSoHienTai, Business.ChungTu.TongTienThanhToan,
                        //                                                                this.SoDiemBiTru, this.SoTienQuyDoi,
                        //                                                                this.HeSoTienRaDiem, heSoTichDiem);
                        soDiemTLuy = TinhDiemTichLuy(this.IdTheThanhVien, Business.ChungTu.IdChungTu, this.SoDiemBiTru, this.SoTienQuyDoi);
                        showMsg = true;
                    }
                    //if (chkCKNganhHang.Checked)
                    //{
                    //    BanHangDataProvider.Instance.UpdateDaTichDiem(Business.ChungTu.IdChungTu, (int)TrangThaiTichDiem.DA_XIN_CHIET_KHAU);//danh dau don hang xin chiet khau
                    //}

                    //update diem duoc dung
                    ChinhSachTheTVienDataProvider.Instance.UpdateDiemDuocDung(Business.ChungTu.IdChungTu);

                    ConnectionUtil.Instance.CommitTransaction();

                    if (!isIn)
                    {
                        string title = "Cập nhật đơn hàng bán thành công!";
                        if (IsAdded)
                            title = "Lập đơn hàng bán thành công!";

                        if (showMsg && soDiemTLuy > 0)
                        {
                            if (DTHoanTien != null)
                                MessageBox.Show("Giá trị điểm thưởng vượt quá số tiền hoàn lại nên không đổi công nợ được");

                            frmNotifyTichDiem.Instance.ShowMessage(this.SoDiemTichLuy, this.SoDiemBiTru, soDiemTLuy,
                                                                   (this.SoDiemTichLuy - this.SoDiemBiTru + soDiemTLuy),
                                                                   title);

                        }
                        else
                            MessageBox.Show(title);
                    }

                    return true;
                }
            }
            catch (Exception)
            {
                ConnectionUtil.Instance.RollbackTransaction();
                Business.ChungTu.IdChungTu = oldId;
                Business.ChungTu.TrangThai = oldTT;
                Business.ChungTu.SoChungTu = oldSCT;
                Business.ChungTu.SoChungTuGoc = oldSCTG;
                txtSoOrderKH.Text = oldSCT;
                this.Close();
                throw;
            }
            Common.SetFormStatus(this.Name, true);
            Cursor.Current = Cursors.Default;
            return false;
        }
        private int TinhDiemTichLuy(int idThe, int idChungTu, int soDiemBiTru, double soTienQuyDoi)
        {
            int soDiemTichLuy= 0;
            if (Business.ChungTu.IdChungTu > 0 && Business.ListChiTietChungTu != null && soTienQuyDoi == 0)
            {
                foreach (ChungTuBanHangChiTietInfor ct in Business.ListChiTietChungTu)
                {
                    int diemThuongMacDinh = Common.IntValue(ct.TyLeDiemThuongMacDinh*ct.ThanhTien/100);
                    if (ct.SoDiemThuong > 0)
                    {
                        soDiemTichLuy += ct.SoDiemThuong > diemThuongMacDinh && diemThuongMacDinh > 0
                                             ? diemThuongMacDinh
                                             : ct.SoDiemThuong;
                    }
                    else if (ct.TyLeDiemThuong > 0)
                    {
                        int diemThuong = Common.IntValue(ct.TyLeDiemThuong*ct.ThanhTien/100);
                        soDiemTichLuy += diemThuong > diemThuongMacDinh && diemThuongMacDinh > 0
                                             ? diemThuongMacDinh
                                             : diemThuong;
                    }
                    else if (ct.TyLeDiemThuongMacDinh > 0)
                    {
                        soDiemTichLuy += diemThuongMacDinh;
                    }
                }
            }
            //neu co diem thuong va yeu cau quy doi thanh phieu tri de bu tru phieu thu hoan tien
            double soTienCN = soDiemTichLuy * Declare.HE_SO_DOI_DIEM_RA_TIEN;
            if (DTHoanTien != null && soTienCN > 0 && soTienCN <= DTHoanTien.TongTienThanhToan)
            {
                TaoPhieuChiTraLai(soTienCN);
                return 0;
            }
            else//nguoc lai thi cap nhat diem tich luy
                ChinhSachTheTVienDataProvider.Instance.UpdateDiemTichLuyMuaHang(idThe, idChungTu, soDiemBiTru,
                                                                                soTienQuyDoi, soDiemTichLuy);

            return soDiemTichLuy;
        }
        //tao phieu chi va don hang tra lai bu vao phieu thu hoan tien diem thuong
        private void TaoPhieuChiTraLai(double soTienCN)
        {
            //huy don hang dt
            DTHoanTien.TrangThai = (int)OrderStatus.HUY_DON_HANG_DAT_TRUOC;
            BanHangDataProvider.Instance.UpdateChungTu(DTHoanTien);

            //lap don hang tra lai
            DMTaiKhoanQuyInfo tkQuy = DMTaiKhoanQuyDataProvider.Instance.GetTaiKhoanQuyTMByTrungTam(Business.ChungTu.IdTrungTam);
            string taiKhoanQuy = tkQuy != null ? tkQuy.TaiKhoanQuy : "";

            LapDonHangTraLaiBussiness tlaiBus = new LapDonHangTraLaiBussiness(DTHoanTien.Clone() as ChungTuBanHangInfor, Business.ChungTu.SoChungTu, 
                                                taiKhoanQuy, Business.ChungTu.IdTrungTam, Business.ChungTu.IdNhanVien, Business.ChungTu.IdThuNgan, soTienCN);


            tlaiBus.SaveDonHangTraLai();
            MessageBox.Show("Tạo đơn hàng trả lại đỏi điểm thành công nợ đối trừ cho đơn hàng hoàn tiền điểm thưởng " +
                            DTHoanTien.SoChungTu);
        }
        private void SaveChungTuInstance()
        {
            UpdateChietKhau();
            //RecalculateInfors();
            UpdateTrangThaiChungTu();
            //update header
            UpdateChungTuHeader();
            //update thanh toan
            UpdateChungTuThanhToan();
            //update detail
            UpdateChungTuDetails();
            //update diem tich luy the thanh vien
            //UpdateDiemTichLuy();
        }
        //private void UpdateDiemTichLuy()
        //{
        //    CapNhatDiemTichLuyDataProvider.Instance.UpdateDiemTichLuy(IdTheThanhVien, Business.ChungTu.TongTienThanhToan,
        //                                                              SoDiemBiTru, Business.ChungTu.NguoiSua,
        //                                                              Business.ChungTu.TenMaySua);
        //}
        private void UpdateDoiDiemRaTien()
        {
            //tinh tong tien CK
            double tongTienCK = 0;
            double tongTien = 0;
            foreach (ChungTuBanHangChiTietInfor ct in Business.ListChiTietChungTu)
            {
                if (ct.MaSanPham.EndsWith(Declare.MA_DOI_DIEM))//diem tich luy
                {
                    tongTienCK += ct.ThanhTien;
                    continue;
                }

                if (ct.CSachChietKhau == null && ct.TyLeCSachChietKhau == 0 && (ct.IdSanPhamBan == 0 || ct.LoaiHangKem == 1) && !ct.MaSanPham.EndsWith(Declare.MA_DOI_DIEM))
                    tongTien += ct.ThanhTien;
            }
            //1. Tính tiền Chiết khấu chia deu cho cac mat hang
            if (tongTienCK > 0 && tongTien > 0)
            {
                if (tongTienCK > tongTien)
                    tongTienCK = tongTien;
                foreach (ChungTuBanHangChiTietInfor ct in Business.ListChiTietChungTu)
                {
                    if (ct.CSachChietKhau == null && ct.TyLeCSachChietKhau == 0 &&
                        (ct.IdSanPhamBan == 0 || ct.LoaiHangKem == 1)
                         && !ct.MaSanPham.EndsWith(Declare.MA_DOI_DIEM))
                    {
                        double ck = Common.DoubleValueInt(ct.ThanhTien * tongTienCK / tongTien);

                        ct.ThanhTien = ct.ThanhTien - ck;
                        //spb.DonGiaCoVat = spb.ThanhTien / spb.SoLuong;
                        ct.TienVAT = ct.ThanhTien * ct.TyleVAT / TyLe / (1 + ct.TyleVAT / TyLe);
                        ct.TienSauChietKhau = ct.ThanhTien / (1 + ct.TyleVAT / TyLe);
                        ct.DonGia = (ct.TienSauChietKhau + ct.TienChietKhau) / ct.SoLuong;
                    }
                }
            }         
        }
        private void UpdateChietKhau()
        {
            if (Draft == 1) return;//neu xac nhan don hang thi tinh lai chiet khau
            //tinh tong tien CK
            double tongTienCK = 0;
            double tongTien = 0;
            double tyLeCK = 0;
            foreach (ChungTuBanHangChiTietInfor ct in Business.ListChiTietChungTu)
            {
                if (ct.CSachChietKhau != null && ct.TyLeCSachChietKhau != -1)
                {
                    if (ct.ThanhTien > 0)
                        tongTienCK += ct.ThanhTien; //có tiền thì ưu tiên tiền CK
                    else
                        tyLeCK += ct.CSachChietKhau.TyLeChietKhau; //không có thì lấy theo tỷ lệ CK
                    ct.TyLeCSachChietKhau = -1; // -ct.TyLeCSachChietKhau;
                }

                if (ct.CSachChietKhau == null && ct.TyLeCSachChietKhau == 0 && (ct.IdSanPhamBan == 0 || ct.LoaiHangKem == 1) && ct.ApDungChietKhau)
                    tongTien += ct.ThanhTien;
            }  
            //1. Tính tiền Chiết khấu chia deu cho cac mat hang
            if (tongTienCK > 0 && tongTien > 0)
            {
                if (tongTienCK > tongTien)
                    tongTienCK = tongTien;
                foreach (ChungTuBanHangChiTietInfor ct in Business.ListChiTietChungTu)
                {
                    if (ct.CSachChietKhau == null && ct.TyLeCSachChietKhau == 0 &&
                        (ct.IdSanPhamBan == 0 || ct.LoaiHangKem == 1)
                         && ct.ApDungChietKhau)
                    {
                        double ck = Common.DoubleValueInt(ct.ThanhTien*tongTienCK/tongTien);

                        ct.ThanhTien = ct.ThanhTien - ck;
                        //spb.DonGiaCoVat = spb.ThanhTien / spb.SoLuong;
                        ct.TienVAT = ct.ThanhTien*ct.TyleVAT/TyLe/(1 + ct.TyleVAT/TyLe);
                        ct.TienSauChietKhau = ct.ThanhTien/(1 + ct.TyleVAT/TyLe);
                        ct.DonGia = (ct.TienSauChietKhau + ct.TienChietKhau)/ct.SoLuong;
                    }
                }
            }
            //2. Tính tỷ lệ Chiết khấu cho cac mat hang
            if (tyLeCK > 0)
            {
                foreach (ChungTuBanHangChiTietInfor ct in Business.ListChiTietChungTu)
                {
                    if (ct.CSachChietKhau == null && ct.TyLeCSachChietKhau == 0 &&
                        (ct.IdSanPhamBan == 0 || ct.LoaiHangKem == 1)
                        && ct.ApDungChietKhau)
                    {
                        double ck = Common.DoubleValueInt(ct.ThanhTien * tyLeCK / 100);

                        ct.ThanhTien = ct.ThanhTien - ck;
                        //spb.DonGiaCoVat = spb.ThanhTien / spb.SoLuong;
                        ct.TienVAT = ct.ThanhTien * ct.TyleVAT / TyLe / (1 + ct.TyleVAT / TyLe);
                        ct.TienSauChietKhau = ct.ThanhTien / (1 + ct.TyleVAT / TyLe);
                        ct.DonGia = (ct.TienSauChietKhau + ct.TienChietKhau) / ct.SoLuong;
                    }
                }
            }

            //3. Tinh chiet khau do doi diem thanh tien
            UpdateDoiDiemRaTien();

            //4. cap nhat tong so tien
            UpdateSummariesInfors();
        }
        private void UpdateChungTuHeader()
        {
            //if (ApDungTheThanhVien && DTHoanTien == null)
            //{
            //    Business.ChungTu.DaTichDiem = this.IdTheThanhVien > 0
            //                                      ? (int) TrangThaiTichDiem.DA_TICH_DIEM
            //                                      : (int) TrangThaiTichDiem.CHUA_TICH_DIEM;
            //    Business.ChungTu.NguoiXacNhan = this.NguoiXacNhan;
            //    Business.ChungTu.IdTheThanhVien = this.IdTheThanhVien;
            //    Business.ChungTu.DoUuTien = this.DoUuTien;
            //    Business.ChungTu.TheThanhVien = this.TheThanhVien;
            //    Business.ChungTu.SoDiemBiTru = this.SoDiemBiTru;
            //    Business.ChungTu.SoTienQuyDoi = this.SoTienQuyDoi;
            //    Business.ChungTu.SoTienTichLuy = this.SoDiemTichLuy;//so diem tich luy ban dau

            //    if (this.SoTienQuyDoi > 0)
            //        txtGhiChu.Text = txtGhiChu.Text +
            //                         String.Format("\r\nSố điểm đổi: {0}\r\nSố tiền quy đổi: {1}", this.SoDiemBiTru,
            //                                       this.SoTienQuyDoi);
            //}
            //else
            //{
            //    Business.ChungTu.DaTichDiem = 0;
            //}

            if (ApDungTheThanhVien && this.SoTienQuyDoi > 0)
                txtGhiChu.Text = txtGhiChu.Text +
                                 String.Format("\r\nSố điểm đổi: {0}\r\nSố tiền quy đổi: {1}", this.SoDiemBiTru,
                                               this.SoTienQuyDoi);

            Business.ChungTu.SoChungTu = txtSoOrderKH.Text;
            Business.ChungTu.NgayLap = mstNgayLapPhieu.Value;
            if (String.IsNullOrEmpty(Business.ChungTu.SoSeri) && !String.IsNullOrEmpty(txtSoSerie.Text))
            {
                Business.ChungTu.NgayHoaDon =  CommonProvider.Instance.GetSysDate();
                dteNgayHoaDon.EditValue = Business.ChungTu.NgayHoaDon;
            }

            Business.ChungTu.LoaiChungTu = LoaiChungTu;
            Business.ChungTu.TrangThai = TrangThaiDonHang;
            Business.ChungTu.IdTrungTam = _IdTrungTam;
            Business.ChungTu.IdTrungTamHachToan = _IdTrungTamHachToan;
            Business.ChungTu.IdKho = ((DMKhoInfo) bteKhoXuat.Tag).IdKho;
            Business.ChungTu.IdNhanVien = ((DMNhanVienInfo) bteThuongVien.Tag).IdNhanVien;            
            if (Business.ChungTu.SoSeri == null || !Business.ChungTu.SoSeri.Equals(txtSoSerie.Text.Trim()))
            {
                Business.ChungTu.QuyenSo = Common.IntValue(cboQuyen.SelectedValue);
                Business.ChungTu.SoSeri = txtSoSerie.Text;
                Business.ChungTu.KyHieu = cboQuyen.Text;
            }
            if (String.IsNullOrEmpty(txtSoSerie.Text.Trim()))
            {
                Business.ChungTu.QuyenSo = 0;
                Business.ChungTu.SoSeri = "";
                Business.ChungTu.KyHieu = "";                
            }
            Business.ChungTu.SoChungTuGoc = txtSoChungTuGoc.Text;
            Business.ChungTu.SoPhieuDC = txtSoPhieuDC.Text;
            Business.ChungTu.IdDoiTuong = ((DMDoiTuongInfo) bteKhachHang.Tag).IdDoiTuong;
            Business.ChungTu.IdLyDoGiaoDich = Common.Bool2Int(chkTraLaiNCC.Checked);
            Business.ChungTu.CongTy = txtCongTy.Text;
            Business.ChungTu.HoTen = txtHoTenKhachHang.Text;
            Business.ChungTu.DoTuoi = Common.IntValue(txtTuoi.Text);
            Business.ChungTu.GioiTinh = cboGioiTinh.SelectedIndex;
            Business.ChungTu.DiaChi = txtDiaChi.Text;
            Business.ChungTu.DienThoai = txtDienThoai.Text;
            Business.ChungTu.MaSoThue = txtMaSoThue.Text;
            //Business.ChungTu.SoTaiKhoan = txtSoTaiKhoan.Text;
            //Business.ChungTu.NganHang = txtNganHang.Text;
            Business.ChungTu.OrderType = Declare.OrderTypeBan;//hang ban Common.IntValue(cboOrderType.SelectedValue);
            Business.ChungTu.BillTo = 0;// Common.IntValue(cboBillTo.SelectedValue);
            Business.ChungTu.ShipTo = 0;// Common.IntValue(cboShipTo.SelectedValue);
            Business.ChungTu.HinhThucTra = bteThoiHanThanhToan.Tag != null ? ((DMLoaiThuChiInfor) bteThoiHanThanhToan.Tag).IdThuChi : 0;

            Business.ChungTu.GhiChu = txtGhiChu.Text;
            Business.ChungTu.IdBangKeThue = Common.Bool2Int(chkVoucher.Checked);
            Business.ChungTu.IdLoaiHdBanHang = Common.IntValue(cboLoaiHoaDon.SelectedValue);
            Business.ChungTu.IdDuAn = Common.IntValue(cboMaDuAn.SelectedValue);
            Business.ChungTu.IdThuNgan = bteThuNgan.Tag != null ? ((DMNhanVienInfo)bteThuNgan.Tag).IdNhanVien : 0;
            Business.ChungTu.SoCMND = txtCMND.Text;
            Business.ChungTu.GiaoNhan = cboGiaoHang.SelectedIndex;
            Business.ChungTu.IdTruongCa = bteTruongCa.Tag != null ? ((DMNhanVienInfo)bteTruongCa.Tag).IdNhanVien : 0;
            //Business.ChungTu.LoaiTheKhachHang = Common.IntValue(cboLoaiThe.SelectedValue);
            //Business.ChungTu.SoTienTichLuy = Common.DoubleValue(txtDiemTichLuy.Text);
            Business.ChungTu.CaBanHang = cboCaBanHang.SelectedIndex;
            Business.ChungTu.NgayHenGiaoHang = mstNgayHenGiaoHang.Value;
            Business.ChungTu.IdKhachLe = bteKhachLe.Tag != null ? ((DMDoiTuongInfo)bteKhachLe.Tag).IdDoiTuong : 0;
            Business.ChungTu.Email = txtEmail.Text;
            Business.ChungTu.Website = txtWebSite.Text;
            Business.ChungTu.Draft = Draft;
            Business.ChungTu.IdTinhHD = bteTinhHD.Tag != null ? ((DMTinhInfor)bteTinhHD.Tag).IdTinh : 0;
            Business.ChungTu.IdHuyenHD = bteHuyenHD.Tag != null ? ((DMHuyenInfor)bteHuyenHD.Tag).IdHuyen : 0; 
            Business.ChungTu.DiaChiHD = txtDiaChiHD.Text;
            Business.ChungTu.DiaChiHoaDon = txtDiaChiHD.Text +
                                            (bteHuyenHD.Tag != null ? ", " + ((DMHuyenInfor)bteHuyenHD.Tag).TenHuyen : "") +
                                            (bteTinhHD.Tag != null ? ", " + ((DMTinhInfor)bteTinhHD.Tag).TenTinh : "");
            Business.ChungTu.IdTinhGH = bteTinh.Tag != null ? ((DMTinhInfor)bteTinh.Tag).IdTinh : 0;
            Business.ChungTu.IdHuyenGH = bteHuyen.Tag != null ? ((DMHuyenInfor)bteHuyen.Tag).IdHuyen : 0; 
            Business.ChungTu.DiaChiGH = txtDiaChi.Text;
            Business.ChungTu.DiaChiGiaoHang = txtDiaChi.Text +
                                            (bteHuyen.Tag != null ? ", " + ((DMHuyenInfor)bteHuyen.Tag).TenHuyen : "") +
                                            (bteTinh.Tag != null ? ", " + ((DMTinhInfor)bteTinh.Tag).TenTinh : "");
            Business.ChungTu.SoHDDaMua = txtSoHDDaMua.Text;
            Business.ChungTu.IdNgheNghiep = Common.IntValue(cboNgheNghiep.SelectedValue);

            if (Business.ChungTu.IdChungTu == 0)
            {
                Business.ChungTu.NguoiTao = nguoiDung.TenDangNhap;
                Business.ChungTu.TenMayTao = Declare.TenMay;
                Business.ChungTu.NguoiSua = nguoiDung.TenDangNhap;
                Business.ChungTu.TenMaySua = Declare.TenMay;
            }
            else
            {
                Business.ChungTu.NguoiSua = nguoiDung.TenDangNhap;
                Business.ChungTu.TenMaySua = Declare.TenMay;
            }
        }

        private void UpdateChungTuThanhToan()
        {
            Business.ChungTu.TienThanhToanThuc = 0;
            foreach (ChungTuThanhToanInfor tt in Business.ListChungTuThanhToan)
            {                   
                if (tt.IdThuNgan == 0)
                {
                    tt.IdThuNgan = bteThuNgan.Tag != null ? ((DMNhanVienInfo)bteThuNgan.Tag).IdNhanVien : 0;
                    tt.TenThuNgan = bteThuNgan.Tag != null ? ((DMNhanVienInfo)bteThuNgan.Tag).HoTen : "";                    
                }
                tt.HoTen = txtHoTenKhachHang.Text;
                tt.DiaChi = txtDiaChi.Text;
                tt.DienThoai = txtDienThoai.Text;
                tt.IdTienTe = Declare.IdTienTe;
                tt.TyGia = 1;
                tt.SoTienChu = Common.ReadNumner_(Common.Double2Str(tt.SoTienThanhToan));
                tt.SoChungTuGoc = Business.ChungTu.SoChungTu;

                if (tt.LoaiThanhToan != -1 && !String.IsNullOrEmpty(tt.HinhThucThanhToan) && !tt.HinhThucThanhToan.ToUpper().Equals("VOUCHER"))
                    Business.ChungTu.TienThanhToanThuc += tt.SoTienThanhToan;

                if (tt.IdThanhToan == 0)
                {
                    tt.NguoiTao = nguoiDung.TenDangNhap;
                    tt.TenMayTao = Declare.TenMay;
                    tt.NguoiSua = nguoiDung.TenDangNhap;
                    tt.TenMaySua = Declare.TenMay;
                }
                else
                {
                    tt.NguoiSua = nguoiDung.TenDangNhap;
                    tt.TenMaySua = Declare.TenMay;
                }
            }

            Business.ChungTu.TongTienHang = 0;
            Business.ChungTu.TongTienChietKhau = 0;
            Business.ChungTu.TongTienSauChietKhau = 0;
            Business.ChungTu.TongTienVAT = 0;
            Business.ChungTu.TongTienThanhToan = 0;
            foreach (ChungTuBanHangChiTietInfor ctu in (BindingList<ChungTuBanHangChiTietInfor>)gSanPhamBan.DataSource)
            {
                if ((ctu.CSachChietKhau != null || ctu.TyLeCSachChietKhau != 0 || ctu.MaSanPham.EndsWith(Declare.MA_DOI_DIEM)) && Draft == 0)//khong tinh den ma hang chinh sach chiet khau
                    continue;

                if (ctu.IdSanPhamBan == 0 || ctu.LoaiHangKem == 1 || Common.Int2Bool(ctu.ChietKhau) || chkTinhKM.Checked)//spc hoac hang kem hoac km
                {
                    Business.ChungTu.TongTienHang += ctu.SoLuong * ctu.DonGia;
                    Business.ChungTu.TongTienChietKhau += Common.Int2Bool(ctu.ChietKhau) ? -ctu.TienChietKhau : ctu.TienChietKhau;
                    Business.ChungTu.TongTienSauChietKhau += ctu.TienSauChietKhau;
                    Business.ChungTu.TongTienVAT += ctu.TienVAT;
                    Business.ChungTu.TongTienThanhToan += ctu.ThanhTien;
                }
            }
            
            if (Business.ChungTu.TongTienThanhToan < Business.ChungTu.TienThanhToanThuc)
                throw new ManagedException("Tiền thực trả không được vượt quá tổng tiền thanh toán!!!");

            Business.ChungTu.TienConNo = Business.ChungTu.TongTienThanhToan - Business.ChungTu.TienThanhToanThuc;
            Business.ChungTu.IdTienTe = Declare.IdTienTe;
            Business.ChungTu.TongTienChu = Common.ReadNumner_(Common.Double2Str(Business.ChungTu.TongTienThanhToan));
        }
        private void UpdateChungTuDetails()
        {
            if (Business.ChungTu.IdChungTu == 0 && Business.ListChiTietChungTu != null)
            {
                for (int i = Business.ListChiTietChungTu.Count - 1; i >= 0; i--)
                {
                    if (Business.ListChiTietChungTu[i].MaSanPham.EndsWith(Declare.MA_DOI_DIEM))//diem tich luy
                    {
                        Business.ListChiTietChungTu.RemoveAt(i);
                    }
                    else
                    {
                        Business.ListChiTietChungTu[i].IdChungTu = 0;
                    }
                }
            }
            //BanHangDataProvider.Instance.MergeListBanKMai2ChiTiet(ref Business.ListChiTietChungTu, liChungTuBanHangChiTiet, liChungTuKhuyenMaiChiTiet);
            //Business.ListChiTietChungTu = liChungTuBanHangChiTiet;
        }
        private bool ValidDeleteChungTu()
        {
            if ((Draft != 0/* || nguoiDung.SupperUser == 1*/) && ( 
                TrangThaiDonHang == (int)OrderStatus.DON_HANG_BAN_TAI_SHOP))//|| TrangThaiDonHang == (int)OrderStatus.DON_HANG_BAN_ONLINE ||
                //TrangThaiDonHang == (int)OrderStatus.DON_HANG_BAN_DAT_TRUOC || TrangThaiDonHang == (int)OrderStatus.XAC_NHAN_DON_HANG_GIAO_NHAN))
            {
                return true;
            }
            return false;
        }
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidDeleteChungTu())
                {
                    DeleteChungTu();
                }
                else
                {
                    MessageBox.Show("Đơn hàng đã xác nhận. Không thể hủy được");
                }

                Updating = false;
                setEDItems();
                setEDFunctions();
                ShowInfors();
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

        private void DeleteChungTu()
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn hủy đơn hàng này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ConnectionUtil.Instance.BeginTransaction();
                    if (Business.ChungTu.IdChungTu > 0)
                    {
                        double tongTienOld = Business.ChungTu.TongTienThanhToan;
                        double tienNoOld = Business.ChungTu.TienConNo;

                        //xoa chung tu
                        Business.DeleteChungTu();//xoa chung tu neu chua xuat
                        //cap nhat lai cong no
                        //BanHangDataProvider.Instance.UpdateCongNoKhachHang(Business.ChungTu.IdKhachLe,
                        //                                                   Business.ChungTu.IdDoiTuong,
                        //                                                   0,
                        //                                                   0, tongTienOld,
                        //                                                   tienNoOld, Business.ChungTu.LoaiChungTu);
                    }
                    ConnectionUtil.Instance.CommitTransaction();
                    MessageBox.Show("Hủy đơn hàng thành công!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                ConnectionUtil.Instance.RollbackTransaction();
                throw;
#if DEBUG
                MessageBox.Show("Lỗi thực hiện Xóa đơn hàng\n" + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi thực hiện Xóa đơn hàng", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }
        private void tsbPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsInHoaDon)
                {
                    if (Business.ChungTu.IdChungTu == 0 || Business.ChungTu.Draft == 1)
                    {
                        MessageBox.Show("Đơn hàng chưa được xác nhận. Không thể in được!");
                        return;
                    }
                }
                else
                {
                    if (String.IsNullOrEmpty(Business.ChungTu.SoSeri))
                    {
                        MessageBox.Show("Chưa có số hóa đơn. Không thể in hóa đơn được");
                        //return;
                    }
                }

                if (gvSanPhamBan.RowCount == 0 || Business.ChungTu.IdChungTu == 0)
                {
                    MessageBox.Show("Chưa có đơn hàng bán. Không thể in hóa đơn được");
                    return;
                }
                //in hoa don tai chinh
                if (!String.IsNullOrEmpty(Business.ChungTu.SoSeri))
                    CommonFuns.Instance.InHoaDon(Business.ChungTu, Business.ListChiTietChungTu, bteKhoXuat,
                                                 bteThuongVien, bteKhachHang);
                //in phieu thu tien);
                if (Business.ListChungTuThanhToan != null && Business.ListChungTuThanhToan.Count > 0 && MessageBox.Show("Có in kèm phiếu thu hay không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string hanghoa = "";
                    foreach (ChungTuBanHangChiTietInfor ct in Business.ListChiTietChungTu)
                    {
                        if (ct.TenSanPham.Length < Declare.CHIEUDAI_TENHANG)
                        {
                            hanghoa += ct.TenSanPham;
                        } 
                        else
                        {
                            string tenSanPham = ct.TenSanPham;

                            while (tenSanPham.Length > Declare.CHIEUDAI_TENHANG)
                            {
                                tenSanPham = tenSanPham.Substring(0, tenSanPham.LastIndexOf(' '));
                            }
                            hanghoa += tenSanPham + "...";
                        }
                        hanghoa += ";";

                        //hanghoa += (ct.TenSanPham.Length < Declare.CHIEUDAI_TENHANG
                        //                ? ct.TenSanPham
                        //                : ct.TenSanPham.Substring(0, Declare.CHIEUDAI_TENHANG) + "...") + ";";
                    }

                    CommonFuns.Instance.InPhieuThu(Business.ListChungTuThanhToan, hanghoa, Business.ChungTu.TongTienThanhToan, Business.ChungTu.TienConNo);
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

        private void tsbPayment_Click(object sender, EventArgs e)
        {
            if (gvSanPhamBan.RowCount == 0 || MessageBox.Show("Dữ liệu đang nhập, nếu chuyển thông tin thì dữ liệu đã nhập sẽ bị xóa\nBạn có đồng ý đổi thông tin hay không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (ChonCaLamViec())
                    ResetData();
            }
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (Business.ChungTu.IdChungTu > 0 && Business.ChungTu.Draft == 1 && MessageBox.Show("Đơn hàng mới lưu nháp, chưa được xác nhận!!\n\nCác bộ phận khác sẽ không nhìn thấy được!!!\n\nBạn có đồng ý thoát chức năng này không? (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    CommonProvider.Instance.Lock_Unlock_ChungTu(Business.ChungTu.IdChungTu, 0);//mo chung tu                    
                    return;
                }
                this.Close();
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

        private void UpdateSummariesInfors()
        {
            try
            {
                double tongTienHang = 0;
                double tongTienCK = 0;
                double tongTienSauCK = 0;
                double tongTienVAT = 0;
                double tongThanhTien = 0;
                double tienThucTra = Common.DoubleValue(this.txtTienThucTra.Text.Trim());
                foreach (ChungTuBanHangChiTietInfor ctu in (BindingList<ChungTuBanHangChiTietInfor>)gSanPhamBan.DataSource)
                {
                    if (ctu.CSachChietKhau != null || ctu.TyLeCSachChietKhau != 0 || ctu.MaSanPham.EndsWith(Declare.MA_DOI_DIEM))//khong tinh den ma hang chinh sach chiet khau
                        continue;
                    //CommonFuns.Instance.RoundDetailValue(ctu);
                    if (ctu.IdSanPhamBan == 0 || ctu.LoaiHangKem == 1 || Common.Int2Bool(ctu.ChietKhau) || chkTinhKM.Checked)//spc hoac hang kem hoac km
                    {
                        tongTienHang += ctu.SoLuong * ctu.DonGia;
                        tongTienCK += Common.Int2Bool(ctu.ChietKhau) ? -ctu.TienChietKhau : ctu.TienChietKhau;
                        tongTienSauCK += ctu.TienSauChietKhau;
                        tongTienVAT += ctu.TienVAT;
                        tongThanhTien += ctu.ThanhTien;
                    }
                }
                ((BindingList<ChungTuBanHangChiTietInfor>)gSanPhamBan.DataSource).ResetBindings();

                this.txtTongTienHang.Text = Common.Double2Str(Common.DoubleValueInt(tongTienHang));
                this.txtTongTienCK.Text = Common.Double2Str(Common.DoubleValueInt(tongTienCK));
                this.txtTongTienSauCK.Text = Common.Double2Str(Common.DoubleValueInt(tongTienSauCK));
                this.txtTongTienVAT.Text = Common.Double2Str(Common.DoubleValueInt(tongTienVAT));
                this.txtTongTienThanhToan.Text = Common.Double2Str(Common.DoubleValueInt(tongThanhTien));
                this.txtTienConNo.Text = Common.Double2Str(Common.DoubleValueInt(tongThanhTien - tienThucTra));

                //chkCKNganhHang.Checked = !duocTichDiem;//don hang khong duoc tich diem nghia la da xin chiet khau
                //btnDoiDiemRaTien.Enabled = duocTichDiem;
                //if (!duocTichDiem)
                //    ResetTheInfor();
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

        private void txtTienThucTra_TextChanged(object sender, EventArgs e)
        {
            double tienThanhToan = Common.DoubleValue(txtTongTienThanhToan.Text.Trim());
            double tienThucTra = Common.DoubleValue(txtTienThucTra.Text.Trim());
            double tienConNo = tienThanhToan - tienThucTra;
            txtTienConNo.Text = Common.Double2Str(tienConNo);
        }
        private void txtTienThucTra_LostFocus(object sender, EventArgs e)
        {
            try
            {
                this.txtTienThucTra.Text = Common.Double2Str(Common.DoubleValue(this.txtTienThucTra.Text.Trim()));
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
        private void txtTienThucTra_Enter(object sender, EventArgs e)
        {
            try
            {
                this.txtTienThucTra.Focus();
                this.txtTienThucTra.SelectAll();
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
        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng hàng này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (int i in gvSanPhamBan.GetSelectedRows())
                    {
                        ChungTuBanHangChiTietInfor ctu = (ChungTuBanHangChiTietInfor)gvSanPhamBan.GetRow(i);
                        if (ctu.MaSanPham.EndsWith(Declare.MA_DOI_DIEM))
                        {
                            ApDungTheThanhVien = false;
                            this.NguoiXacNhan = "";
                            this.IdTheThanhVien = 0;
                            this.IdLoaiTheThanhVien = 0;
                            this.DoUuTien = 0;
                            this.TheThanhVien = "";
                            this.SoDiemBiTru = 0;
                            this.SoTienQuyDoi = 0;
                            this.HeSoTienRaDiem = 0;

                            setEDKhachHangItems(false);
                            gvSanPhamBan.DeleteRow(i);
                            return;                            
                        }
                        if (ctu.CSachChietKhau != null || ctu.TyLeCSachChietKhau != 0)//xoa rieng ma hang chinh sach chiet khau
                        {
                            gvSanPhamBan.DeleteRow(i);
                            continue;
                        }
                        if (ctu.CSachChietKhau == null && ctu.TyLeCSachChietKhau == 0 && LoaiChungTu == (int)TransactionType.DON_HANG_ONLINE)
                            continue;

                        //if (ctu.LoaiHangKem == 1 || ctu.ChietKhau == 1 && ctu.IdSanPhamBan > 0) continue;//khong cho phep xoa hang mem hoac ck
                        if ((ctu.LoaiHangKem == 1 || ctu.IdSanPhamBan > 0 && ctu.LoaiHangKem == 0 && ctu.ThanhTien == 0) && nguoiDung.SupperUser != 1)
                        //|| ctu.ChietKhau != 1 && Draft == 0 && Business.ChungTu.IdChungTu > 0)
                            continue;//khong cho phep xoa hang kem hoac khuyen mai
                        if (ctu.IdSanPhamBan == 0)//xoa hang chinh
                        {
                            //xoa cac KM va sp kem
                            for (int j = gvSanPhamBan.RowCount; j >= 0; j--)
                            {
                                ChungTuBanHangChiTietInfor sp = (ChungTuBanHangChiTietInfor)gvSanPhamBan.GetRow(j);
                                if (sp != null && sp.IdSanPhamBan == ctu.IdSanPham)
                                    gvSanPhamBan.DeleteRow(j);
                            }
                        }
                        else if (ctu.LoaiHangKem == 1)//xoa hang kem
                        {
                            foreach (ChungTuBanHangChiTietInfor spb in (BindingList<ChungTuBanHangChiTietInfor>)gSanPhamBan.DataSource)
                            {
                                if (spb.IdSanPham == ctu.IdSanPhamBan)
                                {
                                    //xoa cac KM va sp kem
                                    for (int j = gvSanPhamBan.RowCount; j >= 0; j--)
                                    {
                                        ChungTuBanHangChiTietInfor sp = (ChungTuBanHangChiTietInfor)gvSanPhamBan.GetRow(j);
                                        if (sp != null && sp.IdSanPhamBan == spb.IdSanPham && sp.IdSanPham != ctu.IdSanPham)
                                            gvSanPhamBan.DeleteRow(j);
                                    }
                                    spb.ChinhSach = null;
                                    break;
                                }
                            }                                
                            
                        }
                        else//xoa san pham khuyen mai
                        {
                            if (ctu.ThanhTien > 0 && ctu.ChietKhau != 1)//dieu chinh lai gia cua san pham ban
                            {
                                //dieu chinh gia
                                foreach (ChungTuBanHangChiTietInfor spb in (BindingList<ChungTuBanHangChiTietInfor>)gSanPhamBan.DataSource)
                                {
                                    if (spb.IdSanPham == ctu.IdSanPhamBan && spb.SoLuong != 0)
                                    {
                                        spb.ThanhTien = spb.ThanhTien - ctu.ThanhTien;
                                        //spb.DonGiaCoVat = spb.ThanhTien / spb.SoLuong;
                                        spb.TienVAT = spb.ThanhTien*spb.TyleVAT/TyLe/(1 + spb.TyleVAT/TyLe);
                                        spb.TienSauChietKhau = spb.ThanhTien / (1 + spb.TyleVAT / TyLe);
                                        spb.DonGia = (spb.TienSauChietKhau + spb.TienChietKhau) / spb.SoLuong;
                                        
                                        ((BindingList<ChungTuBanHangChiTietInfor>)gSanPhamBan.DataSource).ResetBindings();
                                        break;
                                    }
                                }
                            }
                            else if (ctu.ChietKhau == 1)//xoa dong chiet khau => xoa hang chinh
                            {
                                foreach (ChungTuBanHangChiTietInfor spb in (BindingList<ChungTuBanHangChiTietInfor>)gSanPhamBan.DataSource)
                                {
                                    if (spb.IdSanPham == ctu.IdSanPhamBan)
                                    {
                                        //xoa cac KM va sp kem
                                        for (int j = gvSanPhamBan.RowCount; j >= 0; j--)
                                        {
                                            ChungTuBanHangChiTietInfor sp = (ChungTuBanHangChiTietInfor)gvSanPhamBan.GetRow(j);
                                            if (sp != null && sp.IdSanPhamBan == spb.IdSanPham && sp.IdSanPham != ctu.IdSanPham)
                                                gvSanPhamBan.DeleteRow(j);
                                        }
                                        spb.ChinhSach = null;
                                        break;
                                    }
                                }                                
                            }
                        }

                        gvSanPhamBan.DeleteRow(i);
                    }
                    //gvSanPhamBan.DeleteSelectedRows();
                    UpdateSummariesInfors();
                    //if (count == 0)
                    //    MessageBox.Show("Không có dòng chiết khấu nào được xóa!");
                    if (gvSanPhamBan.RowCount == 0 && LoaiChungTu != (int)TransactionType.DON_HANG_DAT_TRUOC)
                    {
                        //xoa hinh thuc thanh toan
                        Business.ListChungTuThanhToan = new List<ChungTuThanhToanInfor>();
                        gHinhThucThanhToan.DataSource = new BindingList<ChungTuThanhToanInfor>(Business.ListChungTuThanhToan);

                        //thong tin thanh toan
                        txtTongTienHang.Text = Common.Double2Str(0);
                        txtTongTienCK.Text = Common.Double2Str(0);
                        txtTongTienSauCK.Text = Common.Double2Str(0);
                        txtTongTienVAT.Text = Common.Double2Str(0);
                        txtTongTienThanhToan.Text = Common.Double2Str(0);
                        txtTienThucTra.Text = Common.Double2Str(0);
                        txtTienConNo.Text = Common.Double2Str(0);
                    }
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

        private void cboQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHoaDon(cboQuyen.Enabled);
        }

        private void btnLoadQuyen_Click(object sender, EventArgs e)
        {
            frmCS_SuDungHoaDon frm = new frmCS_SuDungHoaDon();
            if (frm.ShowDialog() == DialogResult.OK)
                LoadQuyen();
        }


        private void btnTimOrderKH_Click(object sender, EventArgs e)
        {
            try
            {
                if (Updating)
                {
                    if (MessageBox.Show("Dữ liệu đang cập nhật, bạn có muốn hủy bỏ không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;
                }
                ChungTuBanHangInfor ctu = BanHangDataProvider.Instance.LoadChungTu(-1, txtSoOrderKH.Text.Trim(), 1, 0);
                if (ctu != null)
                {
                    Business = new LapDonHangBusiness(ctu);
                    LoadChungTuInstance();

                    Updating = false;
                    setEDItems();
                    setEDFunctions();

                    if (nguoiDung.SupperUser == 1)
                    {
                        EnableSuaGia();
                    }
                    ShowInfors();            
                }
                else
                {
                    MessageBox.Show("Không tìm thấy chứng từ thích hợp!");
                    txtSoOrderKH.Text = Business.ChungTu.SoChungTu;
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

        private void txtSoOrderKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnTimOrderKH_Click(sender, e);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                double tongTienCK = 0;
                double tongTien = 0;
                double tyLeCK = 0;
                double tienTT = 0;
                foreach (ChungTuBanHangChiTietInfor ct in Business.ListChiTietChungTu)
                {
                    if (ct.MaSanPham.EndsWith(Declare.MA_DOI_DIEM))//diem tich luy
                    {
                        tongTienCK += ct.ThanhTien;
                        continue;
                    }

                    if (ct.CSachChietKhau != null)
                    {
                        if (ct.ThanhTien > 0)
                            tongTienCK += ct.ThanhTien; //có tiền thì ưu tiên tiền CK
                        else
                            tyLeCK += ct.CSachChietKhau.TyLeChietKhau; //không có thì lấy theo tỷ lệ CK

                        foreach (ChungTuBanHangChiTietInfor ctu in (BindingList<ChungTuBanHangChiTietInfor>)gvSanPhamBan.DataSource)
                        {
                            if (ctu.ChietKhau != 1 && (ctu.IdSanPhamBan == 0 || ctu.LoaiHangKem == 1))//(hang chinh + hang kem) không phải là chiết khâu
                            {
                                if (ctu.ApDungChietKhau || BanHangDataProvider.Instance.ValidMaChietKhau(ct.CSachChietKhau.IdDKMua, ctu.IdSanPham, ctu.DonGiaCoVat))
                                    ctu.ApDungChietKhau = true;
                            }
                        }
                    }
                }

                if (tyLeCK > 0)
                {
                    foreach (ChungTuBanHangChiTietInfor ct in Business.ListChiTietChungTu)
                    {
                        if (ct.CSachChietKhau == null && ct.TyLeCSachChietKhau == 0 &&
                            (ct.IdSanPhamBan == 0 || ct.LoaiHangKem == 1)
                            && ct.ApDungChietKhau)
                        {
                            tienTT += ct.ThanhTien;
                        }
                    }

                    tongTienCK += Common.DoubleValueInt((tienTT - tongTienCK) * tyLeCK / 100);
                }

                tongTien = Common.DoubleValue(txtTongTienThanhToan.Text) - tongTienCK;

                if (tongTien <= 0) return;
                //if (Common.DoubleValue(txtTongTienThanhToan.Text) == Common.DoubleValue(txtTienThucTra.Text))
                //{
                //    MessageBox.Show("Đơn hàng này đã thanh toán đủ tiền. Không thể thanh toán thêm nữa");
                //    return;
                //}
                frmBH_ChonHinhThucTT frm = new frmBH_ChonHinhThucTT(Business.ListChungTuThanhToan,
                                                                    txtSoOrderKH.Text,
                                                                    tongTien,
                                                                    Common.DoubleValue(txtTienThucTra.Text),
                                                                    Declare.KyHieuTienTe,
                                                                    nguoiDung.IdNhanVien,
                                                                    _IdTrungTam, (int)LoaiPhieuThanhToan.PHIEU_THU,
                                                                    (int)LoaiGiaoDichThanhToan.GIAODICH_BANHANG);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ((BindingList<ChungTuThanhToanInfor>)gHinhThucThanhToan.DataSource).Add(frm.ThanhToan);
                    txtTienThucTra.Text = Common.Double2Str(frm.TienDaThanhToan);
                    txtTienConNo.Text = Common.Double2Str(frm.TongTienThanhToan - frm.TienDaThanhToan);
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

        private void btnXoaTT_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvHinhThucThanhToan.FocusedRowHandle < 0) return;
                if (MessageBox.Show("Bạn có chắc chắn xóa các mục này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (int i in gvHinhThucThanhToan.GetSelectedRows())
                    {
                        ChungTuThanhToanInfor t = (ChungTuThanhToanInfor)gvHinhThucThanhToan.GetRow(i);
                        if (t != null && t.IdThanhToan > 0 && nguoiDung.SupperUser != 1 && Draft == 0)
                        {
                            MessageBox.Show("Phiếu thu này đã được tạo. Không thể xóa được!");
                            return;
                        }
                    }
                    gvHinhThucThanhToan.DeleteSelectedRows();
                    double tienThanhToan = 0;
                    foreach (ChungTuThanhToanInfor tt in (BindingList<ChungTuThanhToanInfor>)gHinhThucThanhToan.DataSource)
                    {
                        if (tt.LoaiThanhToan != -1 && !tt.HinhThucThanhToan.ToUpper().Equals("VOUCHER"))
                            tienThanhToan += tt.SoTienThanhToan;
                    }
                    double tienConNo = Common.DoubleValue(txtTongTienThanhToan.Text) - tienThanhToan;
                    txtTienThucTra.Text = Common.Double2Str(tienThanhToan);
                    txtTienConNo.Text = Common.Double2Str(tienConNo);
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

        private bool ChonCaLamViec()
        {
            frmThietLapCaLamViec frm = new frmThietLapCaLamViec();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                _IdKho = frm.KhoSelected.IdKho;
                _IdTrungTam = frm.TTamSelected.IdTrungTam;
                _IdLoaiKhachHang = frm.LoaiDTSelected.IdLoaiDT;
                _IdKhachHang = frm.KHangSelected.IdDoiTuong;
                _IdTruongCa = frm.TruongCaSelected.IdNhanVien;
                _IdThuNgan = frm.ThuNganSelected.IdNhanVien;
                _IdThoiHanThanhToan = frm.ThoiHanTTSelected.IdThuChi;

                grThongTin.Text = String.Format("Trung tâm: {0} - {1}", frm.TTamSelected.MaTrungTam, frm.TTamSelected.TenTrungTam);

                bteKhoXuat.Text = frm.KhoSelected.TenKho;
                bteKhoXuat.Tag = frm.KhoSelected;

                bteKhachHang.Text = frm.KHangSelected.TenDoiTuong;
                bteKhachHang.Tag = frm.KHangSelected;

                bteTruongCa.Text = frm.TruongCaSelected.HoTen;
                bteTruongCa.Tag = frm.TruongCaSelected;

                bteThuNgan.Text = frm.ThuNganSelected.HoTen;
                bteThuNgan.Tag = frm.ThuNganSelected;

                bteThoiHanThanhToan.Text = frm.ThoiHanTTSelected.Ten;
                bteThoiHanThanhToan.Tag = frm.ThoiHanTTSelected;

                return true;
            }
            return false;
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

        private void txtMaSanPham_Leave(object sender, EventArgs e)
        {
            //if (!txtMaSanPham.Text.Trim().Equals(""))
            //{
            //    InputDataFromCode(txtMaSanPham.Text.Trim());
            //}
        }

        private void tsbCopy_Click(object sender, EventArgs e)
        {
            try
            {
                if (_IdTrungTam == 0 || _IdLoaiKhachHang == 0 || bteKhoXuat.Tag == null || bteKhachHang.Tag == null)
                {
                    if (!ChonCaLamViec())
                        return;
                }

                SaoChepDonHang();

                Updating = true;
                setEDItems();
                setEDFunctions();
                ShowInfors();
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

        private void SaoChepDonHang()
        {
            Draft = -1;
            IsAdded = true;
            LoaiChungTu = (int)TransactionType.DON_HANG_TAI_SHOP;
            TrangThaiDonHang = (int)OrderStatus.DON_HANG_BAN_TAI_SHOP;
            Business.ChungTu.IdChungTu = 0;
            ResetTheInfor();

            txtSoOrderKH.Prefix = Declare.Prefix.TaoDonHangBan;
            txtSoOrderKH.ReSet();//.Text = CommonProvider.Instance.GetSoPhieu(Declare.Prefix.TaoDonHangBan);
            mstNgayLapPhieu.Value = CommonProvider.Instance.GetSysDate();
            cboCaBanHang.SelectedValue = DMCaBanHangDataProvider.Instance.GetCurrentCaBanHangInfors().KyHieu;
            mstNgayHenGiaoHang.Value = CommonProvider.Instance.GetSysDate();
            LoadQuyen();
            txtGhiChu.ResetText();

            Business.ListChiTietChungTu = new List<ChungTuBanHangChiTietInfor>();
            gSanPhamBan.DataSource = new BindingList<ChungTuBanHangChiTietInfor>(Business.ListChiTietChungTu);

            Business.ListChungTuThanhToan = new List<ChungTuThanhToanInfor>();
            gHinhThucThanhToan.DataSource = new BindingList<ChungTuThanhToanInfor>(Business.ListChungTuThanhToan);

            txtTongTienHang.Text = Common.Double2Str(0);
            txtTongTienCK.Text = Common.Double2Str(0);
            txtTongTienSauCK.Text = Common.Double2Str(0);
            txtTongTienVAT.Text = Common.Double2Str(0);
            txtTongTienThanhToan.Text = Common.Double2Str(0);
            txtTienThucTra.Text = Common.Double2Str(0);
            txtTienConNo.Text = Common.Double2Str(0);
        }

        private void tsbConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (CommonProvider.Instance.IsKhacTinh() && IsKinhDoanhThiTruong)
                {
                    throw new ManagedException("Bạn đang ở tỉnh khác, không thể xác nhận đơn hàng");
                }

                Draft = 0;
                if (UpdateChungTu(false))
                {
                    Updating = false;
                    setEDItems();
                    setEDFunctions();
                    ShowInfors();
                    if (String.IsNullOrEmpty(Business.ChungTu.SoSeri))
                        CommonProvider.Instance.Lock_Unlock_ChungTu(Business.ChungTu.IdChungTu, 0);//mo chung tu                    
                }
            }
            catch (ManagedException ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show(ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
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

        private void LoadDoiTuongInfor(DMDoiTuongInfo dt)
        {
            txtHoTenKhachHang.Text = dt.TenDoiTuong;
            cboGioiTinh.SelectedIndex = dt.GioiTinh > 2 ? 0 : dt.GioiTinh;
            txtTuoi.Text = dt.DoTuoi.ToString();
            txtDiaChi.Text = dt.DiaChi;
            txtDienThoai.Text = dt.DienThoai;
            txtEmail.Text = dt.Email;
            txtWebSite.Text = dt.WebSite;
            txtMaSoThue.Text = dt.MaSoThue;
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            //txtDiaChi.Text = txtDiaChiHD.Text;
        }

        private void UpdateValueChiTiet(ChungTuBanHangChiTietInfor ctu)
        {
            UpdateValueChiTiet(ctu, 1);
        }

        private void UpdateValueChiTiet(ChungTuBanHangChiTietInfor ctu, int type)
        {
            if (type == 1)//change soluong
            {
                ctu.ThanhTien = Common.DoubleValueInt(ctu.SoLuong * ctu.ThanhTien / ctu.SoLuongOld);
                ctu.TienVAT = Common.DoubleValueInt(ctu.SoLuong * ctu.TienVAT / ctu.SoLuongOld);
                ctu.TienSauChietKhau = ctu.ThanhTien - ctu.TienVAT;// Common.DoubleValueInt(ctu.ThanhTien / (1 + ctu.TyleVAT / TyLe));

                ctu.TienChietKhau = Common.DoubleValueInt(ctu.DonGia * ctu.SoLuong) - ctu.TienSauChietKhau;

            }
            else//change cac cot khac
            {
                ctu.ThanhTien = Common.DoubleValueInt(ctu.SoLuong * ctu.ThanhTien / ctu.SoLuongOld);
                ctu.TienVAT = Common.DoubleValueInt(ctu.ThanhTien * ctu.TyleVAT / TyLe / (1 + ctu.TyleVAT / TyLe));
                ctu.TienSauChietKhau = ctu.ThanhTien - ctu.TienVAT;// Common.DoubleValueInt(ctu.ThanhTien / (1 + ctu.TyleVAT / TyLe));

                ctu.TienChietKhau = Common.DoubleValueInt(ctu.DonGia * ctu.SoLuong) - ctu.TienSauChietKhau;

            }
            if (Math.Abs(ctu.TienChietKhau) <= 2)
            {
                ctu.TienChietKhau = 0;
                ctu.DonGia = (ctu.TienSauChietKhau + ctu.TienChietKhau) / ctu.SoLuong;
            }  
            //if (ctu.TienChietKhau > 0)
            //{
            //    ctu.DonGia = (ctu.TienSauChietKhau + ctu.TienChietKhau) / ctu.SoLuong;
            //    ctu.TyleChietKhau = ctu.TienChietKhau * TyLe / ctu.DonGia / ctu.SoLuong;
            //}
            //else if (ctu.TyleChietKhau < TyLe)
            //{
            //    //ctu.TienChietKhau = ctu.TienSauChietKhau * ctu.TyleChietKhau / (1 + ctu.TyleChietKhau / TyLe);
            //    //ctu.DonGia = (ctu.TienSauChietKhau + ctu.TienChietKhau) / ctu.SoLuong;
            //    ctu.DonGia = ctu.TienSauChietKhau*TyLe/ctu.SoLuong/(TyLe - ctu.TyleChietKhau);
            //    ctu.TienChietKhau = ctu.TienSauChietKhau*ctu.TyleChietKhau/(TyLe - ctu.TyleChietKhau);
            //}
        }

        /// <summary>
        /// UpdateDataValues
        /// </summary>
        /// <param name="type">1: thay doi so luong; !=1 thay doi cac cot khac: thanh tien, dongia,..</param>
        private void UpdateDataValues(int type)
        {
            if (gvSanPhamBan.FocusedRowHandle < 0) return;

            ChungTuBanHangChiTietInfor ctu = (ChungTuBanHangChiTietInfor)gvSanPhamBan.GetRow(gvSanPhamBan.FocusedRowHandle);
            UpdateValueChiTiet(ctu, type);
            if (ctu.IdSanPhamBan == 0)
            {
                foreach (ChungTuBanHangChiTietInfor ct in (BindingList<ChungTuBanHangChiTietInfor>)gvSanPhamBan.DataSource)
                {
                    if (ct.IdSanPhamBan == ctu.IdSanPham && (ct.LoaiHangKem == 0 || ct.LoaiHangKem == 1))
                    {
                        int tmp = ctu.SoLuong * ct.SoLuongKhuyenMai;

                        if (ct.ChietKhau != 1 && ct.LoaiHangKem == 0)
                        {
                            ct.SoLuong = ct.TonKho > tmp ? tmp : ct.TonKho;
                            ct.NoKhuyenMai = tmp - ct.SoLuong;// ct.TonKho > tmp ? 0 : tmp - ct.TonKho;
                        }
                        else
                        {
                            ct.SoLuong = ctu.SoLuongOld != 0 ? ctu.SoLuong * ct.SoLuong / ctu.SoLuongOld : 0;
                        }
                        ct.TienChietKhau = ctu.SoLuongOld != 0 ? ctu.SoLuong * ct.TienChietKhau / ctu.SoLuongOld : 0;
                        ct.TienSauChietKhau = ctu.SoLuongOld != 0 ? ctu.SoLuong * ct.TienSauChietKhau / ctu.SoLuongOld : 0;
                        ct.ThanhTien = ctu.SoLuongOld != 0 ? ctu.SoLuong * ct.ThanhTien / ctu.SoLuongOld : 0;
                        ct.TienVAT = ctu.SoLuongOld != 0 ? ctu.SoLuong * ct.TienVAT / ctu.SoLuongOld : 0;

                        ct.SoLuongOld = ct.SoLuong;
                    }
                }
            }

            ctu.SoLuongOld = ctu.SoLuong;            

            UpdateSummariesInfors();
            //SLChitietOld = spb.SoLuong;            
        }

        private void gvSanPhamBan_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "SoLuong")
            {
                UpdateDataValues(1);
            }
            else if (/*e.Column.FieldName == "TyLeChietKhau" || e.Column.FieldName == "TienChietKhau" || e.Column.FieldName == "TyLeVAT" ||*/ e.Column.FieldName == "ThanhTien")
            {
                UpdateDataValues(2);
            }          
        }

        private void gvSanPhamBan_Click(object sender, EventArgs e)
        {
            if (gvSanPhamBan.FocusedRowHandle < 0) return;
            ChungTuBanHangChiTietInfor ctu =
                (ChungTuBanHangChiTietInfor)gvSanPhamBan.GetRow(gvSanPhamBan.FocusedRowHandle);
            txtMaSanPham.Text = ctu.MaSanPham;
        }

        private void bteKhoXuat_TextChanged(object sender, EventArgs e)
        {
            //hah: check đơn hàng đã xác nhận thì không sửa
            //if (TrangThaiDonHang != (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC &&
            //    !BanHangDataProvider.Instance.CheckValid_TrangThai_Draft(Business.ChungTu.IdChungTu))
            //{
            //    bteKhoXuat.Properties.ReadOnly = true;
            //    return;
            //}


            if (UtilFunctions.bteItem_TextChanged(sender, e, bteKhoXuat) &&
                TrangThaiDonHang != (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC)
            {
                if (gvSanPhamBan.RowCount > 0)
                {
                    if (MessageBox.Show("Dữ liệu đang nhập, nếu chuyển thông tin thì dữ liệu đã nhập sẽ bị xóa\nBạn có đồng ý đổi thông tin hay không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ResetData();
                    }
                    else
                    {
                        LoadKhoXuat();
                    }
                }
            }
        }

        private void bteKhoXuat_KeyDown(object sender, KeyEventArgs e)
        {
            //hah: check đơn hàng đã xác nhận thì không sửa
            //if (TrangThaiDonHang != (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC &&
            //    !BanHangDataProvider.Instance.CheckValid_TrangThai_Draft(Business.ChungTu.IdChungTu))
            //{
            //    bteKhoXuat.Properties.ReadOnly = true;
            //    return;
            //}


            if (UtilFunctions.bteKhoXuat_KeyDown(sender, e, bteKhoXuat, -1, nguoiDung.IdNhanVien) &&
                TrangThaiDonHang != (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC)
            {
                if (gvSanPhamBan.RowCount > 0)
                {
                    if (MessageBox.Show("Dữ liệu đang nhập, nếu chuyển thông tin thì dữ liệu đã nhập sẽ bị xóa\nBạn có đồng ý đổi thông tin hay không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ResetData();
                    }
                    else
                    {
                        LoadKhoXuat();
                    }
                }
            }
        }

        private void bteKhoXuat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //hah: check đơn hàng đã xác nhận thì không sửa
            //if (TrangThaiDonHang != (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC &&
            //    !BanHangDataProvider.Instance.CheckValid_TrangThai_Draft(Business.ChungTu.IdChungTu))
            //{
            //    bteKhoXuat.Properties.ReadOnly = true;
            //    return;
            //}



            if (UtilFunctions.bteKhoXuat_ButtonClick(sender, e, bteKhoXuat, -1, nguoiDung.IdNhanVien) &&
                TrangThaiDonHang != (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC)
            {
                if (gvSanPhamBan.RowCount > 0)
                {
                    if (MessageBox.Show("Dữ liệu đang nhập, nếu chuyển thông tin thì dữ liệu đã nhập sẽ bị xóa\nBạn có đồng ý đổi thông tin hay không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ResetData();
                    }
                    else
                    {
                        LoadKhoXuat();
                    }
                }
            }
        }

        private void bteKhachHang_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //hah: check đơn hàng đã xác nhận thì không sửa
            //if (TrangThaiDonHang != (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC &&
            //    !BanHangDataProvider.Instance.CheckValid_TrangThai_Draft(Business.ChungTu.IdChungTu))
            //{
            //    bteKhachHang.Properties.ReadOnly = true;
            //    return;
            //}

            if (UtilFunctions.bteKhachHang_ButtonClick(sender, e, bteKhachHang, _IdLoaiKhachHang))
            {
                if (gvSanPhamBan.RowCount > 0)
                {
                    if (MessageBox.Show("Dữ liệu đang nhập, nếu chuyển thông tin thì dữ liệu đã nhập sẽ bị xóa\nBạn có đồng ý đổi thông tin hay không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ResetData();
                    }
                    else
                    {
                        LoadKhachHang();
                    }                    
                }
            }
        }

        private void bteKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            //hah: check đơn hàng đã xác nhận thì không sửa
            //if (TrangThaiDonHang != (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC &&
            //    !BanHangDataProvider.Instance.CheckValid_TrangThai_Draft(Business.ChungTu.IdChungTu))
            //{
            //    bteKhachHang.Properties.ReadOnly = true;
            //    return;
            //}

            if (UtilFunctions.bteKhachHang_KeyDown(sender, e, bteKhachHang, _IdLoaiKhachHang))
            {
                if (gvSanPhamBan.RowCount > 0)
                {
                    if (MessageBox.Show("Dữ liệu đang nhập, nếu chuyển thông tin thì dữ liệu đã nhập sẽ bị xóa\nBạn có đồng ý đổi thông tin hay không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ResetData();
                    }
                    else
                    {
                        LoadKhachHang();
                    }
                }

            }
        }

        private void bteKhachHang_TextChanged(object sender, EventArgs e)
        {
            //hah: check đơn hàng đã xác nhận thì không sửa
            //if (TrangThaiDonHang != (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC &&
            //    !BanHangDataProvider.Instance.CheckValid_TrangThai_Draft(Business.ChungTu.IdChungTu))
            //{
            //    bteKhachHang.Properties.ReadOnly = true;
            //    return;
            //}

            if (UtilFunctions.bteItem_TextChanged(sender, e, bteKhachHang))
            {
                if (gvSanPhamBan.RowCount > 0)
                {
                    if (MessageBox.Show("Dữ liệu đang nhập, nếu chuyển thông tin thì dữ liệu đã nhập sẽ bị xóa\nBạn có đồng ý đổi thông tin hay không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ResetData();
                    }
                    else
                    {
                        LoadKhachHang();
                    }
                }
            }
        }

        private void bteThuongVien_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int IdKhoSelected = bteKhoXuat.Tag != null ? ((DMKhoInfo) bteKhoXuat.Tag).IdKho : 0;
            UtilFunctions.bteNhanVien_ButtonClick(sender, e, bteThuongVien, IdKhoSelected);
        }

        private void bteThuongVien_KeyDown(object sender, KeyEventArgs e)
        {
            int IdKhoSelected = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : 0;
            UtilFunctions.bteNhanVien_KeyDown(sender, e, bteThuongVien, IdKhoSelected);
        }

        private void bteThuongVien_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteThuongVien);
        }

        private void bteTruongCa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int IdKhoSelected = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : 0;
            UtilFunctions.bteTruongCa_ButtonClick(sender, e, bteTruongCa, IdKhoSelected);
        }

        private void bteTruongCa_KeyDown(object sender, KeyEventArgs e)
        {
            int IdKhoSelected = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : 0;
            UtilFunctions.bteTruongCa_KeyDown(sender, e, bteTruongCa, IdKhoSelected);
        }

        private void bteTruongCa_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteTruongCa);
        }

        private void bteThuNgan_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int IdKhoSelected = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : 0;
            UtilFunctions.bteNhanVien_ButtonClick(sender, e, bteThuNgan, IdKhoSelected);
        }

        private void bteThuNgan_KeyDown(object sender, KeyEventArgs e)
        {
            int IdKhoSelected = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : 0;
            UtilFunctions.bteNhanVien_KeyDown(sender, e, bteThuNgan, IdKhoSelected);
        }

        private void bteThuNgan_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteThuNgan);
        }

        private void bteThoiHanThanhToan_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteThoiHanThanhToan_ButtonClick(sender, e, bteThoiHanThanhToan);
        }

        private void bteThoiHanThanhToan_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteThoiHanThanhToan_KeyDown(sender, e, bteThoiHanThanhToan);
        }

        private void bteThoiHanThanhToan_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteThoiHanThanhToan);
        }

        private void LoadKhachLeInfo()
        {
            DMHoSoKhachHangInfo kle = (DMHoSoKhachHangInfo)bteKhachHang.Tag;
            if (kle != null)
            {
                txtHoTenKhachHang.Text = kle.TenDoiTuong;
                cboGioiTinh.SelectedIndex = kle.GioiTinh > 2 ? 0 : kle.GioiTinh; 
                txtTuoi.Text = kle.DoTuoi.ToString();
                txtMaSoThue.Text = kle.MaSoThue;
                txtEmail.Text = kle.Email;
                txtWebSite.Text = kle.WebSite;
                UtilFunctions.LoadTinhThanh(bteTinhHD, kle.IdTinh);
                UtilFunctions.LoadQuanHuyen(bteHuyenHD, kle.IdHuyen);
                txtDiaChiHD.Text = kle.DiaChi;
            }
        }
        private void bteKhachLe_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //int idDoiTuongCha = bteKhachHang != null ? ((DMDoiTuongInfo)bteKhachHang.Tag).IdDoiTuong : -1;
            //UtilFunctions.bteKhachLe_ButtonClick(sender, e, bteKhachLe, idDoiTuongCha);
            //LoadKhachLeInfo();
        }

        private void bteKhachLe_KeyDown(object sender, KeyEventArgs e)
        {
            //int idDoiTuongCha = bteKhachHang != null ? ((DMDoiTuongInfo)bteKhachHang.Tag).IdDoiTuong : -1;
            //UtilFunctions.bteKhachLe_KeyDown(sender, e, bteKhachLe, idDoiTuongCha);
            //LoadKhachLeInfo();
        }

        private void bteKhachLe_TextChanged(object sender, EventArgs e)
        {
            //UtilFunctions.bteItem_TextChanged(sender, e, bteKhachLe);
        }

        private void ResetData()
        {
            Business.ListChiTietChungTu = new List<ChungTuBanHangChiTietInfor>();
            gSanPhamBan.DataSource = new BindingList<ChungTuBanHangChiTietInfor>(Business.ListChiTietChungTu);

            Business.ListChungTuThanhToan = new List<ChungTuThanhToanInfor>();
            gHinhThucThanhToan.DataSource = new BindingList<ChungTuThanhToanInfor>(Business.ListChungTuThanhToan);

            txtTienThucTra.Text = "0";
            txtTienConNo.Text = txtTongTienThanhToan.Text;
        }

        private void gvSanPhamBan_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle < 0) return;
            ChungTuBanHangChiTietInfor ct = (ChungTuBanHangChiTietInfor)gvSanPhamBan.GetRow(e.RowHandle);
            if (ct != null && ct.NoKhuyenMai > 0)
            {
                if (e.Column.FieldName.Equals("TenLoaiHangKem"))
                {
                    e.Appearance.BackColor = Color.Yellow;
                    e.Appearance.ForeColor = Color.Red;
                    e.Appearance.Font = new Font("Tahoma", 9, FontStyle.Bold);
                }   
            }
        }

        private void CheckSoPhieuDieuChuyen()
        {
            if (txtSoPhieuDC.Text.Equals("")) return;
            int idKhoDi = -1;
            int idKhoDen = bteKhoXuat.Tag != null ? ((DMKhoInfo) bteKhoXuat.Tag).IdKho : -1;
            string validPDC = BanHangDataProvider.Instance.ExistListPhieuDC(txtSoPhieuDC.Text, idKhoDi, idKhoDen, 0);//tim chinh xac
            if (!validPDC.Equals(""))
            {
                if (MessageBox.Show(String.Format("Số phiếu [{0}] không tồn tại! Bạn có muốn nhập lại không (Yes/No)?", validPDC), "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    frmBH_ChonPhieuDieuChuyen frm = new frmBH_ChonPhieuDieuChuyen(txtSoPhieuDC.Text, idKhoDi, idKhoDen);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        txtSoPhieuDC.Text = frm.ListPhieuDieuChuyen;
                    }
                }
                else
                {
                    txtSoPhieuDC.Text = "";
                }
            }            
        }

        private void txtSoPhieuDC_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int idKhoDi = -1;
            int idKhoDen = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : -1;

            frmBH_ChonPhieuDieuChuyen frm = new frmBH_ChonPhieuDieuChuyen(txtSoPhieuDC.Text, idKhoDi, idKhoDen);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtSoPhieuDC.Text = frm.ListPhieuDieuChuyen;
            }
        }

        private void txtSoPhieuDC_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                CheckSoPhieuDieuChuyen();
            }
        }

        private void txtSoPhieuDC_Leave(object sender, EventArgs e)
        {
            CheckSoPhieuDieuChuyen();
        }

        private void gvSanPhamBan_ShowingEditor(object sender, CancelEventArgs e)
        {
            try
            {
                if (gvSanPhamBan.FocusedRowHandle < 0) return;
                if (gvSanPhamBan.FocusedColumn.FieldName == "SoLuong")
                {
                    ChungTuBanHangChiTietInfor ct = (ChungTuBanHangChiTietInfor)gvSanPhamBan.GetRow(gvSanPhamBan.FocusedRowHandle);
                    if (ct != null && ct.IdSanPhamBan > 0 || ct.CSachChietKhau != null || ct.TyLeCSachChietKhau > 0)
                        e.Cancel = true;

                    //hah: check đơn hàng đã xác nhận thì không sửa
                    //if (!BanHangDataProvider.Instance.CheckValid_TrangThai_Draft(Business.ChungTu.IdChungTu))
                    //{
                    //    e.Cancel = true;
                    //}
                }
                if (gvSanPhamBan.FocusedColumn.FieldName == "ThanhTien")
                {
                    ChungTuBanHangChiTietInfor ct = (ChungTuBanHangChiTietInfor)gvSanPhamBan.GetRow(gvSanPhamBan.FocusedRowHandle);
                    if ((ct == null || ct.ChietKhau != 1 && !Declare.LstSuaGiaBan.Contains(";" + ct.MaSanPham + ";") || ct.ChietKhau == 1 && !Declare.LstSuaCKhauKoLenODT.Contains(";" + ct.MaSanPham + ";") || ct.IdSanPhamBan > 0) && nguoiDung.SupperUser != 1 && nguoiDung.SuaChungTu != 1)
                        e.Cancel = true;
                }
                //if (gvSanPhamBan.FocusedColumn.FieldName == "DonGia" || gvSanPhamBan.FocusedColumn.FieldName == "TienChietKhau" ||
                //    gvSanPhamBan.FocusedColumn.FieldName == "TyLeChietKhau" || gvSanPhamBan.FocusedColumn.FieldName == "TyLeVAT" || gvSanPhamBan.FocusedColumn.FieldName == "ThanhTien")
                //{
                //    if (nguoiDung == null || nguoiDung.SupperUser != 1 && nguoiDung.SuaChungTu != 1)
                //        e.Cancel = true;
                //}
            }
            catch
            {
            }
        }

        private void frmBH_LapDonHangBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Business.ChungTu.IdChungTu > 0 && Business.ChungTu.Draft == 1 && MessageBox.Show("Đơn hàng mới lưu nháp, chưa được xác nhận!!\n\nCác bộ phận khác sẽ không nhìn thấy được!!!\n\nBạn có đồng ý thoát chức năng này không? (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                CommonProvider.Instance.Lock_Unlock_ChungTu(Business.ChungTu.IdChungTu, 0);//mo chung tu                    
                e.Cancel = true;
            }            
        }

        private void btnGenSCT_Click(object sender, EventArgs e)
        {
            CommonProvider.Instance.GetSoPhieu(Declare.Prefix.TaoDonHangBan);
        }

        private void btnSuaTToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvHinhThucThanhToan.FocusedRowHandle < 0) return;
                ChungTuThanhToanInfor t = (ChungTuThanhToanInfor)gvHinhThucThanhToan.GetRow(gvHinhThucThanhToan.FocusedRowHandle);
                if (t != null && t.IdThanhToan > 0 && nguoiDung.SupperUser != 1 && Draft == 0)
                {
                    MessageBox.Show("Phiếu thu này đã được tạo. Không thể sửa được!");
                    return;
                }

                double tongTien = Common.DoubleValue(txtTongTienThanhToan.Text);

                if (Business.ChungTu.IdChungTu == 0)
                {
                    double tongTienCK = 0;
                    double tyLeCK = 0;
                    double tienTT = 0;
                    foreach (ChungTuBanHangChiTietInfor ct in Business.ListChiTietChungTu)
                    {
                        if (ct.MaSanPham.EndsWith(Declare.MA_DOI_DIEM))//diem tich luy
                        {
                            tongTienCK += ct.ThanhTien;
                            continue;
                        }

                        if (ct.CSachChietKhau != null)
                        {
                            if (ct.ThanhTien > 0)
                                tongTienCK += ct.ThanhTien; //có tiền thì ưu tiên tiền CK
                            else
                                tyLeCK += ct.CSachChietKhau.TyLeChietKhau; //không có thì lấy theo tỷ lệ CK

                            foreach (ChungTuBanHangChiTietInfor ctu in (BindingList<ChungTuBanHangChiTietInfor>)gvSanPhamBan.DataSource)
                            {
                                if (ctu.ChietKhau != 1 && (ctu.IdSanPhamBan == 0 || ctu.LoaiHangKem == 1))//(hang chinh + hang kem) không phải là chiết khâu
                                {
                                    if (ctu.ApDungChietKhau || BanHangDataProvider.Instance.ValidMaChietKhau(ct.CSachChietKhau.IdDKMua, ctu.IdSanPham, ctu.DonGiaCoVat))
                                        ctu.ApDungChietKhau = true;
                                }
                            }
                        }
                    }

                    if (tyLeCK > 0)
                    {
                        foreach (ChungTuBanHangChiTietInfor ct in Business.ListChiTietChungTu)
                        {
                            if (ct.CSachChietKhau == null && ct.TyLeCSachChietKhau == 0 &&
                                (ct.IdSanPhamBan == 0 || ct.LoaiHangKem == 1)
                                && ct.ApDungChietKhau)
                            {
                                tienTT += ct.ThanhTien;
                            }
                        }

                        tongTienCK += Common.DoubleValueInt((tienTT - tongTienCK) * tyLeCK / 100);
                    }

                    tongTien = Common.DoubleValue(txtTongTienThanhToan.Text) - tongTienCK;
                }


                if (t != null)
                {
                    frmBH_ChonHinhThucTT frm = new frmBH_ChonHinhThucTT(t,
                                                                        tongTien,
                                                                        Common.DoubleValue(txtTienThucTra.Text),
                                                                        Declare.KyHieuTienTe);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        ((BindingList<ChungTuThanhToanInfor>)gHinhThucThanhToan.DataSource).ResetBindings();
                        txtTienThucTra.Text = Common.Double2Str(frm.TienDaThanhToan);
                        txtTienConNo.Text = Common.Double2Str(frm.TongTienThanhToan - frm.TienDaThanhToan);
                    }
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

        private void chkTraLaiNCC_Click(object sender, EventArgs e)
        {
            DMDoiTuongInfo dt = (DMDoiTuongInfo) bteKhachHang.Tag;
            if ((dt == null || dt.Type == 1) && chkTraLaiNCC.Checked)
            {
                MessageBox.Show("Không phải đối tượng nhà cung cấp. Không thể chọn tham số này được");
                chkTraLaiNCC.Checked = false;
            }
        }

        private void tsbChinhSachGia_Click(object sender, EventArgs e)
        {
            CommonFuns.Instance.ShowChinhSachKM(gvSanPhamBan);
        }

        private void btnChietKhau_Click(object sender, EventArgs e)
        {
            try
            {
                int IdKhoSelected = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : 0;
                int IdTTamSelected = _IdTrungTam;

                if (_IdTrungTam == 0 || bteKhoXuat.Tag == null || _IdLoaiKhachHang == 0)
                {
                    MessageBox.Show("Phải chọn trung tâm và khách hàng");
                    return;
                }
                ChungTuBanHangChiTietInfor ct = CommonFuns.Instance.LoadChinhSachChietKhau(IdTTamSelected, IdKhoSelected, _IdLoaiKhachHang);
                if (ct != null)
                {
                    ChungTuBanHangChiTietInfor ctu =
                        Business.ListChiTietChungTu.Find(delegate(ChungTuBanHangChiTietInfor match)
                        { return match.MaSanPham == ct.MaSanPham; });
                    if (ctu != null)
                    {
                        MessageBox.Show("Mã chiết khấu này đã được áp dụng!");
                        return;
                    }
                    else
                    {
                        //add san pham ban
                        ct.IdChungTu = Business.ChungTu.IdChungTu;
                        ((BindingList<ChungTuBanHangChiTietInfor>)gSanPhamBan.DataSource).Add(ct);
                        ((BindingList<ChungTuBanHangChiTietInfor>)gSanPhamBan.DataSource).ResetBindings();
                    }

                    UpdateSummariesInfors();                    
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

        private void tsbSaoChepDHKhac_Click(object sender, EventArgs e)
        {
            try
            {
                if (_IdTrungTam == 0 || _IdLoaiKhachHang == 0 || bteKhoXuat.Tag == null || bteKhachHang.Tag == null)
                {
                    if (!ChonCaLamViec())
                        return;
                }

                frmBH_TimChungTu frm = new frmBH_TimChungTu(true);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ThemMoiDonHang(frm.ChungTu);//sao chep don hang tu chung tu goc

                    Updating = true;
                    setEDItems();
                    setEDFunctions();
                    ShowInfors();                    
                }
                else
                {
                    tsbAdd_Click(sender, e);
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

        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            ChungTuBanHangInfor ct = CommonFuns.LoadKhachHangDaMua(txtDienThoai.Text.Trim(), txtCMND.Text.Trim(), txtMaSoThue.Text);
            if (ct != null)
            {
                txtDienThoai.Text = ct.DienThoai;
                txtCMND.Text = ct.SoCMND;
                if (!ApDungTheThanhVien && this.IdTheThanhVien == 0)
                {
                    bteKhachLe.Tag = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(ct.IdKhachLe);
                    bteKhachLe.Text = (bteKhachLe.Tag != null ? ((DMDoiTuongInfo)bteKhachLe.Tag).TenDoiTuong : "");
                    txtHoTenKhachHang.Text = ct.HoTen;

                    cboGioiTinh.SelectedIndex = ct.GioiTinh > 2 ? 0 : ct.GioiTinh;
                    txtTuoi.Text = ct.DoTuoi.ToString();
                }
                txtCongTy.Text = ct.CongTy;
                txtMaSoThue.Text = ct.MaSoThue;
                txtEmail.Text = ct.Email;
                txtWebSite.Text = ct.Website;

                UtilFunctions.LoadTinhThanh(bteTinh, ct.IdTinhGH);
                UtilFunctions.LoadQuanHuyen(bteHuyen, ct.IdHuyenGH);
                txtDiaChi.Text = ct.DiaChi;
                UtilFunctions.LoadTinhThanh(bteTinhHD, ct.IdTinhHD);
                UtilFunctions.LoadQuanHuyen(bteHuyenHD, ct.IdHuyenHD);

                txtDiaChiHD.Text = ct.DiaChiHD;
                cboNgheNghiep.SelectedValue = ct.IdNgheNghiep;
            }
        }

        private void cboGiaoHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            mstNgayHenGiaoHang.Enabled = (cboGiaoHang.SelectedIndex > 0 ? true : false);
        }

        private void bteTinhHD_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteTinhThanh_ButtonClick(sender, e, bteTinhHD, bteHuyenHD);
        }

        private void bteTinhHD_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteTinhThanh_KeyDown(sender, e, bteTinhHD, bteHuyenHD);
        }

        private void bteTinhHD_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteTinhThanh_TextChanged(sender, e, bteTinhHD, bteHuyenHD);
        }

        private void bteTinh_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteTinhThanh_ButtonClick(sender, e, bteTinh, bteHuyen);
        }

        private void bteTinh_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteTinhThanh_KeyDown(sender, e, bteTinh, bteHuyen);
        }

        private void bteTinh_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteTinhThanh_TextChanged(sender, e, bteTinh, bteHuyen);
        }

        private void bteHuyenHD_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int idTinh = bteTinhHD.Tag != null ? ((DMTinhInfor) bteTinhHD.Tag).IdTinh : 0;
            UtilFunctions.bteQuanHuyen_ButtonClick(sender, e, bteHuyenHD, idTinh);
        }

        private void bteHuyenHD_KeyDown(object sender, KeyEventArgs e)
        {
            int idTinh = bteTinhHD.Tag != null ? ((DMTinhInfor)bteTinhHD.Tag).IdTinh : 0;
            UtilFunctions.bteQuanHuyen_KeyDown(sender, e, bteHuyenHD, idTinh);
        }

        private void bteHuyenHD_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteHuyenHD);
        }

        private void bteHuyen_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int idTinh = bteTinh.Tag != null ? ((DMTinhInfor)bteTinh.Tag).IdTinh : 0;
            UtilFunctions.bteQuanHuyen_ButtonClick(sender, e, bteHuyen, idTinh);
        }

        private void bteHuyen_KeyDown(object sender, KeyEventArgs e)
        {
            int idTinh = bteTinh.Tag != null ? ((DMTinhInfor)bteTinh.Tag).IdTinh : 0;
            UtilFunctions.bteQuanHuyen_KeyDown(sender, e, bteHuyen, idTinh);
        }

        private void bteHuyen_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteHuyenHD);
        }

        private void gvSanPhamBan_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gvSanPhamBan.FocusedColumn.Name != "SoLuong" || gvSanPhamBan.FocusedColumn.OptionsColumn.ReadOnly) return;
            ChungTuBanHangChiTietInfor ct = (ChungTuBanHangChiTietInfor)gvSanPhamBan.GetRow(gvSanPhamBan.FocusedRowHandle);
            int soluong = Common.IntValue(e.Value);
            if (soluong <= 0)
            {
                MessageBox.Show("Số lượng bán phải là số dương. Vui lòng kiểm tra lại!");
                e.Valid = false;
            }            
            else if (soluong > ct.TonKho && ct.ChietKhau == 0)
            {
                MessageBox.Show("Số lượng bán vượt quá số tồn kho. Vui lòng kiểm tra lại!");
                e.Valid = false;                
            }
        }

        private bool IsOnline
        {
            get { return ((NguoiDungInfor)Declare.USER_INFOR).IsOnline; }
        }

        private bool IsKinhDoanhThiTruong
        {
            get { return ((NguoiDungInfor)Declare.USER_INFOR).IsKinhDoanhThiTruong; }
        }

        
        private void btnDoiDiemRaTien_Click(object sender, EventArgs e)
        {
            //if (this.bteKhachHang.Tag == null)
            //{
            //    MessageBox.Show("Chưa chọn khách hàng." + "\nHãy chọn khách hàng", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.bteKhachHang.Focus();
            //    return;
            //}
            if (ApDungTheThanhVien || this.IdTheThanhVien > 0)
            {
                MessageBox.Show("Đã đăng ký tích điểm, đổi điểm cho đơn hàng rồi. Không thể thực hiện nữa!!!", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int idCha = ((DMDoiTuongInfo) bteKhachHang.Tag).IdDoiTuong;
            double giaTriDonHang = Common.DoubleValue(txtTongTienThanhToan.Text);
            frmTH_TheThanhVienDoiDiem frm = new frmTH_TheThanhVienDoiDiem(idCha, giaTriDonHang);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                setEDKhachHangItems(true);
                //chkCKNganhHang.Enabled = false;
                //update thong tin khach hang
                if (bteKhachHang.Tag == null)
                    UtilFunctions.LoadDoiTuong(bteKhachHang, frm.KhachHang.IdCha);

                bteKhachLe.Tag = frm.KhachHang;
                bteKhachLe.Text = frm.KhachHang.MaRieng;

                txtCongTy.Text = frm.KhachHang.NguoiLienLac;
                txtHoTenKhachHang.Text = frm.KhachHang.TenDoiTuong;
                txtDienThoai.Text = frm.KhachHang.DienThoai;
                txtCMND.Text = frm.KhachHang.SoCMND;
                cboGioiTinh.SelectedIndex = frm.KhachHang.GioiTinh > 2 ? 0 : frm.KhachHang.GioiTinh;
                cboNgheNghiep.SelectedValue = frm.KhachHang.IdNgheNghiep;
                txtTuoi.Text = frm.KhachHang.DoTuoi.ToString();
                txtMaSoThue.Text = frm.KhachHang.MaSoThue;
                txtEmail.Text = frm.KhachHang.Email;
                txtWebSite.Text = frm.KhachHang.WebSite;

                //UtilFunctions.LoadTinhThanh(bteTinh, frm.KhachHang.IdTinh);
                //UtilFunctions.LoadQuanHuyen(bteHuyen, frm.KhachHang.IdHuyen);
                //txtDiaChi.Text = frm.KhachHang.DiaChi;
                UtilFunctions.LoadTinhThanh(bteTinhHD, frm.KhachHang.IdTinh);
                UtilFunctions.LoadQuanHuyen(bteHuyenHD, frm.KhachHang.IdHuyen);
                txtDiaChiHD.Text = frm.KhachHang.DiaChi;

                if (frm.DuocTichDiem)
                {
                    ApDungTheThanhVien = true;

                    this.NguoiXacNhan = frm.NguoiXacNhan;
                    this.IdTheThanhVien = frm.TheThanhVien.IdThe;
                    this.IdLoaiTheThanhVien = frm.TheThanhVien.IdLoaiThe;
                    this.DoUuTien = frm.TheThanhVien.DoUuTien;
                    this.TheThanhVien = frm.TheThanhVien.TenLoaiThe;
                    this.SoDiemTichLuy = frm.TheThanhVien.SoDiemTichLuy;
                    this.SoDiemBiTru = frm.SoDiemBiTru;
                    this.SoTienQuyDoi = frm.SoTienQuyDoi;
                    this.HeSoTienRaDiem = frm.HeSoTienRaDiem;

                    if (frm.SoTienQuyDoi > 0)
                    {
                        ChungTuBanHangChiTietInfor ct = new ChungTuBanHangChiTietInfor();
                        ct.MaSanPham = Declare.MA_DOI_DIEM;
                        ct.TenSanPham = Declare.TEN_DOI_DIEM;
                        ct.SoLuong = 1;
                        ct.ThanhTien = frm.SoTienQuyDoi;

                        //add san pham ban
                        ct.IdChungTu = Business.ChungTu.IdChungTu;
                        ((BindingList<ChungTuBanHangChiTietInfor>)gSanPhamBan.DataSource).Add(ct);
                        ((BindingList<ChungTuBanHangChiTietInfor>)gSanPhamBan.DataSource).ResetBindings();
                    }                  
                }
                else
                {
                    this.NguoiXacNhan = "";
                    this.IdTheThanhVien = 0;
                    this.IdLoaiTheThanhVien = 0;
                    this.DoUuTien = 0;
                    this.TheThanhVien = "";
                    this.SoDiemTichLuy = 0;
                    this.SoDiemBiTru = 0;
                    this.SoTienQuyDoi = 0;
                    this.HeSoTienRaDiem = 0;
                    setEDKhachHangItems(false);
                }
            }
        }


        private void tsbCapPhatThe_Click(object sender, EventArgs e)
        {
            if (ApDungTheThanhVien || this.IdTheThanhVien > 0)
            {
                MessageBox.Show("Đã đăng ký tích điểm, đổi điểm cho đơn hàng rồi. Không thể tạo thẻ thành viên nữa!!!", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DMHoSoKhachHangInfo khachHang = new DMHoSoKhachHangInfo();
            khachHang.Type = (int)LoaiDoiTuong.KHACH_HANG;

            khachHang.IdCha = bteKhachHang.Tag == null ? 0 : ((DMDoiTuongInfo)bteKhachHang.Tag).IdDoiTuong;
            khachHang.IdLoaiDoiTuong = bteKhachHang.Tag == null ? 0 : ((DMDoiTuongInfo) bteKhachHang.Tag).IdLoaiDoiTuong;
            khachHang.MaDoiTuong = bteKhachHang.Tag == null ? "" : ((DMDoiTuongInfo)bteKhachHang.Tag).MaDoiTuong;
            khachHang.TenDoiTuong = txtHoTenKhachHang.Text;
            khachHang.DoTuoi = Common.IntValue(txtTuoi.Text);
            khachHang.GioiTinh = cboGioiTinh.SelectedIndex;
            khachHang.DiaChi = txtDiaChiHD.Text;
            khachHang.DienThoai = txtDienThoai.Text;
            khachHang.MaSoThue = txtMaSoThue.Text;
            khachHang.SoCMND = txtCMND.Text;
            khachHang.Email = txtEmail.Text;
            khachHang.WebSite = txtWebSite.Text;
            khachHang.IdTinh = bteTinhHD.Tag != null ? ((DMTinhInfor)bteTinhHD.Tag).IdTinh : 0;
            khachHang.IdHuyen = bteHuyenHD.Tag != null ? ((DMHuyenInfor)bteHuyenHD.Tag).IdHuyen : 0;
            khachHang.DiaChi = txtDiaChiHD.Text;
            khachHang.NgheNghiep = cboNgheNghiep.Text;
            khachHang.NguonThamChieu = (int) NoiTaoTheThanhVien.POS;
            khachHang.NoiDangKyNhanThe = _IdTrungTam;
            khachHang.SuDung = 1;
            khachHang.DaLaThanhVien = 1;


            frmTH_CapTheKhachHang frm = new frmTH_CapTheKhachHang(khachHang);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ApDungTheThanhVien = true;
                //chkCKNganhHang.Enabled = false;
                //update thong tin khach hang
                if (bteKhachHang.Tag == null)
                    UtilFunctions.LoadDoiTuong(bteKhachHang, frm.KhachHang.IdCha);

                bteKhachLe.Tag = frm.KhachHang;
                bteKhachLe.Text = frm.KhachHang.MaRieng;
                bteKhachLe.Enabled = false;

                txtHoTenKhachHang.Text = frm.KhachHang.TenDoiTuong;
                txtHoTenKhachHang.ReadOnly = true;

                txtDienThoai.Text = frm.KhachHang.DienThoai;
                txtCMND.Text = frm.KhachHang.SoCMND;

                //txtHoTenKhachHang.Text = frm.KhachHang.NguoiLienLac;
                cboGioiTinh.SelectedIndex = frm.KhachHang.GioiTinh > 2 ? 0 : frm.KhachHang.GioiTinh;
                txtTuoi.Text = frm.KhachHang.DoTuoi.ToString();
                txtMaSoThue.Text = frm.KhachHang.MaSoThue;
                txtEmail.Text = frm.KhachHang.Email;
                txtWebSite.Text = frm.KhachHang.WebSite;

                UtilFunctions.LoadTinhThanh(bteTinh, frm.KhachHang.IdTinh);
                UtilFunctions.LoadQuanHuyen(bteHuyen, frm.KhachHang.IdHuyen);
                txtDiaChi.Text = frm.KhachHang.DiaChi;
                UtilFunctions.LoadTinhThanh(bteTinhHD, frm.KhachHang.IdTinh);
                UtilFunctions.LoadQuanHuyen(bteHuyenHD, frm.KhachHang.IdHuyen);
                txtDiaChiHD.Text = frm.KhachHang.DiaChi;

                this.IdTheThanhVien = frm.TheThanhVien.IdThe;
                this.IdLoaiTheThanhVien = frm.TheThanhVien.IdLoaiThe;
                this.DoUuTien = frm.TheThanhVien.DoUuTien;
                this.TheThanhVien = frm.TheThanhVien.TenLoaiThe;

                HeSoDoiDiemInfo heso = HeSoDoiDiemDataProvider.Instance.LoadHeSoDoiDiem();
                this.HeSoTienRaDiem = heso != null ? heso.GiaTriDoiTienRaDiem : Declare.HE_SO_DOI_TIEN_RA_DIEM;
            }
        }

        private void btnDoiDiemCN_Click(object sender, EventArgs e)
        {
            if (!ApDungTheThanhVien)
            {
                MessageBox.Show("Chưa có thông tin thẻ tích điểm. Vui lòng nhập thông tin thẻ thành viên!", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } 
            this.DTHoanTien = null;
            this.lblDTHoanTien.Text = "";
            InputBox input = new InputBox("Nhập đơn hàng OD", "Nhập đơn hàng bù tiền điểm thưởng:");
            if (input.ShowDialog() == DialogResult.OK)
            {
                string soCTuDT = input.TextData;
                if (!soCTuDT.StartsWith("DT-"))
                {
                    MessageBox.Show("Đây không phải đơn hàng DT trả lại tiền quy đổi điểm thưởng");
                    return;
                }

                ChungTuBanHangInfor ctugoc = BanHangDataProvider.Instance.LoadChungTuBySoChungTu(soCTuDT, "");

                if (ctugoc != null)
                {
                    if (ctugoc.LockId == 1)
                    {
                        if (!CommonProvider.Instance.Check_Lock_ChungTu(ctugoc.IdChungTu))
                        {
                            MessageBox.Show("Đơn hàng đang được mở bởi 1 người khác. Bạn không thể thay đổi trạng thái được!");
                            return;
                        }
                    }

                    //có chặn trả lại chéo OU không?
                    if (CommonProvider.Instance.IsKhacTinh(Declare.IdTrungTamHachToan, DMKhoDataProvider.GetKhoByIdInfo(ctugoc.IdKho).IdTrungTam))
                    {
                        if (nguoiDung.IsOnline)
                        {
                            if (DMKhoDataProvider.Instance.IsCrossedOU(ctugoc.IdKho, Declare.IdKho))
                            {
                                MessageBox.Show("Đơn hàng được xuất ở chi nhánh khác, không thể trả lại được.");

                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Đơn hàng được xuất ở chi nhánh khác, không thể trả lại được.");

                            return;
                        }
                    }

                    if (ctugoc.TrangThai == (int)OrderStatus.HUY_DON_HANG_ONLINE || ctugoc.TrangThai == (int)OrderStatus.HUY_DON_HANG_DAT_TRUOC ||
                        ctugoc.TrangThai == (int)OrderStatus.HUY_DON_HANG)
                    {
                        MessageBox.Show("Đơn hàng đã hủy, không thể trả lại được!");
                        return;
                    }


                    if (!CommonProvider.Instance.Lock_Unlock_ChungTu(ctugoc.IdChungTu, 1))//khoa chung tu
                    {
                        MessageBox.Show("Chứng từ này đang có người cập nhật. Bạn không thể cập nhật được!");
                        return;
                    }

                    this.DTHoanTien = ctugoc;
                    this.lblDTHoanTien.Text = String.Format("Đơn hoàn tiền: {0}", soCTuDT);
                }
                else
                {
                    MessageBox.Show("Số giao dịch này không đúng! Không thể trả lại được");
                    return;
                }
            }
        }
    }
}