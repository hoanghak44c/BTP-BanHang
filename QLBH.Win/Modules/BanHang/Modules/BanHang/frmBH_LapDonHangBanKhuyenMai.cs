using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.HeThong;
using QLBH.Common;
using QLBH.Common.Providers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.BanHang.Bussiness;
using QLBH.Core.Data;
using QLBanHang.Modules.BanHang.Reports;
using QLBH.Core.Providers;
using QLBH.Core.Exceptions;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBH_LapDonHangBanKhuyenMai : DevExpress.XtraEditors.XtraForm
    {
        #region "Khai báo biến"
        List<SuDungHoaDonInfor> liSuDungHD = new List<SuDungHoaDonInfor>();
        List<DMTinhInfor> liTinh = new List<DMTinhInfor>();
        List<DMHuyenInfor> liHuyen = new List<DMHuyenInfor>();
        List<DmNgheNghiepInfor> liNgheNghiep = new List<DmNgheNghiepInfor>();
        List<ChungTuBanHangChiTietInfor> liChungTuChiTiet = new List<ChungTuBanHangChiTietInfor>();

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
        
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();

        private int TrangThaiDonHang = (int)OrderStatus.DON_HANG_BAN_TAI_SHOP;
        private int LoaiChungTu = (int) TransactionType.DON_HANG_BU_KHUYEN_MAI;

        private LapDonHangBuKMBusiness Business;
        private bool IsInHoaDon = false;
        #endregion

        #region "Các phương thức khởi tạo"
        public frmBH_LapDonHangBanKhuyenMai()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            Business = new LapDonHangBuKMBusiness(LoaiChungTu, nguoiDung.IdNhanVien, _IdKho);
        }

        public frmBH_LapDonHangBanKhuyenMai(int loaiChungTu)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.LoaiChungTu = loaiChungTu;
            Business = new LapDonHangBuKMBusiness(LoaiChungTu, nguoiDung.IdNhanVien, _IdKho);
        }

        public frmBH_LapDonHangBanKhuyenMai(ChungTuBanHangInfor chungTuBanHangInfor)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            Business = new LapDonHangBuKMBusiness(chungTuBanHangInfor);
        }

        public void HideMenu(bool isInHoaDon)
        {
            bool enable = ValidEditChungTu();
            //toolStrip1.Enabled = nguoiDung.SupperUser != 1 ? false : true;
            //btnTimOrderKH.Enabled = nguoiDung.SupperUser != 1 ? false : true;
            ////btnTimOrderKH.Visible = false;
            //Updating = nguoiDung.SupperUser != 1 ? false : true;
            //this.IsInHoaDon = isInHoaDon;
            //setEDItems();
            //toolStrip1.Enabled = nguoiDung.SupperUser != 1 ? false : true;
            tsbAdd.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbEdit.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
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
        #endregion

        #region "Các phương thức"
        private void UpdateTrangThaiChungTu()
        {
            TrangThaiDonHang = (int)OrderStatus.DON_HANG_BAN_TAI_SHOP;
        }

        private void RestoreTrangThaiChungTu()
        {
            TrangThaiDonHang = (int)OrderStatus.HUY_DON_HANG;
        }

        /// <summary>
        /// Khoi tao don hang
        /// </summary>
        /// <returns></returns>
        private void ResetChungTuInfor()
        {
            LoadTrungTam();
            LoadKhoXuat();
            LoadKhachHang();
            LoadThuNgan();
            LoadTruongCa();
            LoadThoiHanThanhToan();
            //thong tin don hang
            //IdPhieuXuat = 0;
            //TrangThaiDonHang = (int) OrderStatus.DON_HANG_BAN_TAI_SHOP;
            txtSoOrderKH.ResetText();
            mstNgayLapPhieu.Value = CommonProvider.Instance.GetSysDate(); //.ResetText();//.Text = DateTime.Today.ToString("dd/MM/yyyy");
            dteNgayHoaDon.EditValue = null;
            //txtSoChungTuGoc.ResetText();
            txtSoPhieuDC.ResetText();
            bteThuongVien.Tag = null;
            bteThuongVien.ResetText();
            //bteTruongCa.Tag = null;
            //bteTruongCa.ResetText();
            //bteThuNgan.Tag = null;
            //bteThuNgan.ResetText();
            //txtDienThoai.ResetText();
            //txtCMND.ResetText();
            cboCaBanHang.SelectedValue = DMCaBanHangDataProvider.Instance.GetCurrentCaBanHangInfors().KyHieu;
            cboGiaoHang.SelectedIndex = 0;
            mstNgayHenGiaoHang.Value = CommonProvider.Instance.GetSysDate();
            txtGhiChu.ResetText();

            //txtBillTo.ResetText();
            //txtShipTo.ResetText();
            //txtOrderType.ResetText();

            //bteKhachLe.Tag = null;
            //bteKhachLe.ResetText();
            //cboLoaiThe.SelectedIndex = -1;
            //txtDiemTichLuy.ResetText();
            //txtCongTy.ResetText();
            //txtHoTenKhachHang.ResetText();
            //cboGioiTinh.SelectedIndex = 0;
            //txtTuoi.ResetText();
            //txtMaSoThue.ResetText();
            //txtEmail.ResetText();
            //txtWebSite.ResetText();
            //txtSoTaiKhoan.ResetText();
            //txtNganHang.ResetText();
            //txtDiaChi.ResetText();
            //LoadThoiHanThanhToan();

            LoadQuyen();

            //thong tin san pham
            gSanPhamBan.DataSource = null;
            txtMaSanPham.Text = "";
            txtMaSanPham.Focus();
            txtMaSanPham.SelectAll();

            //thong tin thanh toan
            //txtTongTienHang.Text = Common.Double2Str(0);
            //txtTongTienCK.Text = Common.Double2Str(0);
            //txtTongTienSauCK.Text = Common.Double2Str(0);
            //txtTongTienVAT.Text = Common.Double2Str(0);
            //txtTongTienThanhToan.Text = Common.Double2Str(0);
            //txtTienThucTra.Text = Common.Double2Str(0);
            txtTienConNo.Text = Common.Double2Str(0);
            gHinhThucThanhToan.DataSource = null;
        }

        private bool ValidChungTuCommonInfor()
        {
            if (txtSoChungTuGoc.Text.Trim().Equals(""))
            {
                MessageBox.Show("Chưa nhập số đơn hàng chính", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (txtHoTenKhachHang.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên khách hàng không được để trống", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtHoTenKhachHang.Focus();
                return false;
            }
            if (txtDiaChiHD.Text.Trim().Equals(""))
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
            //Kiem tra hop le hoa don
            if (this.txtSoSerie.Text.Trim().Length == 0)
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
            //if (this.bteThoiHanThanhToan.Tag == null)
            //{
            //    MessageBox.Show("Chưa chọn thông tin thời hạn thanh toán." + "\nHãy chọn thời hạn thanh toán", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.bteThoiHanThanhToan.Focus();
            //    return false;
            //}
            if (this.cboLoaiHoaDon.SelectedIndex != 1)
            {
                MessageBox.Show("Đây là đơn hàng khuyến mại." + "\nHãy chọn lại loại hóa đơn bán", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboLoaiHoaDon.Focus();
                return false;
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
            return true;
        }

        private bool ValideChungTuChiTietInfor(ChungTuBanHangChiTietInfor ct)
        {
            if (!BanHangDataProvider.Instance.ExistNoKhuyenMai(txtSoChungTuGoc.Text, ct.MaSanPham, ct.IdSanPhamBan, ct.SoLuong))//trung sochungtu
            {
                MessageBox.Show(String.Format("Sản phẩm [{0} - {1}] không phải hàng khuyến mại hoặc số lượng vượt quá nợ khuyến mại của đơn hàng chính", ct.MaSanPham, ct.TenSanPham), Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            } 
            if (ct.SoLuong > ct.TonKho)
            {
                MessageBox.Show(String.Format("Sản phẩm [{0} - {1}] không còn đủ tồn trong kho để xuất", ct.MaSanPham, ct.TenSanPham), Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;                
            }
            if (ct.SoLuong == 0)
            {
                MessageBox.Show(String.Format("Sản phẩm [{0} - {1}] không thể xuất với số lượng [{2}]", ct.MaSanPham, ct.TenSanPham, ct.SoLuong), Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool ValidChungTuInfor()
        {
            if (!ValidChungTuCommonInfor())
                return false;

            foreach (ChungTuBanHangChiTietInfor ct in Business.ListChiTietChungTu)
            {
                if (!ValideChungTuChiTietInfor(ct))
                    return false;
            }

            return true;
        }

        private void LoadKhachHang()
        {
            try
            {
                DMDoiTuongInfo dmDoiTuong = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(_IdKhachHang);
                if (dmDoiTuong != null)
                {
                    bteKhachHang.Text = dmDoiTuong.TenDoiTuong;
                    bteKhachHang.Tag = dmDoiTuong;
                    LoadDoiTuongInfor(dmDoiTuong);
                }
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

        private void LoadQuyen()
        {
            try
            {
                int idNhanVien = nguoiDung.IdNhanVien;
                liSuDungHD = SuDungHoaDonDataProvider.Instance.LoadSuDungHoaDonEmpty(idNhanVien);

                if (liSuDungHD.Count > 0)
                {
                    cboQuyen.DataSource = liSuDungHD;
                    cboQuyen.DisplayMember = "KyHieu";
                    cboQuyen.ValueMember = "IdQuyen";

                    LoadHoaDon(false);
                }
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
            try
            {
                DMLoaiThuChiInfor dmLoaiThuChi = DMLoaiThuChiDataProvider.GetListDmThuChiInfoFromOid(_IdThoiHanThanhToan);
                if (dmLoaiThuChi != null)
                {
                    bteThoiHanThanhToan.Text = dmLoaiThuChi.Ten;
                    bteThoiHanThanhToan.Tag = dmLoaiThuChi;
                }
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
        private void LoadThuNgan()
        {
            try
            {
                DMNhanVienInfo nv = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(_IdThuNgan);
                if (nv != null)
                {
                    bteThuNgan.Text = nv.HoTen;
                    bteThuNgan.Tag = nv;
                }
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
        private void LoadTruongCa()
        {
            try
            {
                DMNhanVienInfo nv = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(_IdTruongCa);
                if (nv != null)
                {
                    bteTruongCa.Text = nv.HoTen;
                    bteTruongCa.Tag = nv;
                }
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

        private void LoadDMNgheNghiep()
        {
            try
            {
                liNgheNghiep = DMNgheNghiepDataProvider.Instance.GetListNgheNghiepInfors();
                cboNgheNghiep.DataSource = liNgheNghiep;
                cboNgheNghiep.DisplayMember = "TenNgheNghiep";
                cboNgheNghiep.ValueMember = "IdNgheNghiep";
                cboNgheNghiep.SelectedIndex = -1;
            }
            catch
            {
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

        private void LoadKhoXuat()
        {
            try
            {
                DMKhoInfo dmKho = DMKhoDataProvider.GetKhoByIdInfo(_IdKho);
                if (dmKho != null)
                {
                    bteKhoXuat.Text = dmKho.TenKho;
                    bteKhoXuat.Tag = dmKho;
                }
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

        //        private void LoadBangKeThue()
        //        {
        //            try
        //            {
        //                cboBangKeThue.DataSource = DMBangKeThueDataProvider.Instance.GetListBangKeThueInfo();
        //                cboBangKeThue.DisplayMember = "Ten";
        //                cboBangKeThue.ValueMember = "Id";
        //            }
        //            catch (System.Exception ex)
        //            {
        //#if DEBUG
        //                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //#else
        //                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //#endif
        //            }
        //        }

        private void LoadLoaiHoaDon()
        {
            try
            {
                cboLoaiHoaDon.DataSource = DMLoaiHoaDonDataProvider.Instance.GetListLoaiHoaDonInfo();
                cboLoaiHoaDon.DisplayMember = "Ten";
                cboLoaiHoaDon.ValueMember = "Id";
                cboLoaiHoaDon.SelectedIndex = 0;
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

        private void LoadMaDuAn()
        {
            try
            {
                List<DMDuAnInfor> liDuAn = DMDuAnDataProvider.Instance.GetListDuAnInfo();
                cboMaDuAn.DataSource = liDuAn;
                cboMaDuAn.DisplayMember = "TenDuAn";
                cboMaDuAn.ValueMember = "IdDuAn";
                cboMaDuAn.SelectedIndex = -1;
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

        private void LoadComboBoxData()
        {
            LoadTrungTam();
            LoadKhoXuat();
            //LoadOrderType();
            LoadKhachHang();
            //LoadTienTe();
            //LoadMaVach();
            LoadQuyen();
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

        private void LoadCaBanHang()
        {
            try
            {
                List<DmCaBanHangInfor> liCaBanHang = DMCaBanHangDataProvider.Instance.GetListCaBanHangInfors();
                if (liCaBanHang != null)
                {
                    cboCaBanHang.DataSource = liCaBanHang;
                    cboCaBanHang.DisplayMember = "CaBanHang";
                    cboCaBanHang.ValueMember = "KyHieu";
                }
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

        private void LoadGioiTinh()
        {
            cboGioiTinh.SelectedIndex = 0;
        }

        private void LoadChungTuInstance()
        {
            if (Business.ChungTu.IdChungTu != 0)
            {
                LoadChungTuHeader();
                LoadChungTuThanhToan();
                LoadChungTuDetails();
            }
            else
            {
                ResetChungTuInfor();
            }
        }
        private void LoadDonHangChinh(ChungTuBanHangInfor ctu)
        {
            _IdTrungTam = ctu.IdTrungTam;//lay theo trung tam cua don hang khuyen mai
            if (DMTrungTamDataProvider.Instance.IsCrossedOU(_IdTrungTam, Declare.IdTrungTam))
            {
                throw new ManagedException("Đơn hàng chính phải thuộc cùng chi nhánh.");
            }
            bteKhachHang.Tag = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(ctu.IdDoiTuong);
            bteKhachHang.Text = bteKhachHang.Tag != null ? ((DMDoiTuongInfo)bteKhachHang.Tag).TenDoiTuong : "";

            txtDienThoai.Text = ctu.DienThoai;
            txtCMND.Text = ctu.SoCMND;

            cboLoaiHoaDon.SelectedIndex = 1;//.SelectedValue = ctu.IdLoaiHdBanHang;
            cboMaDuAn.SelectedValue = ctu.IdDuAn;

            bteKhachLe.Tag = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(ctu.IdKhachLe);
            bteKhachLe.Text = bteKhachHang.Tag != null ? ((DMDoiTuongInfo)bteKhachHang.Tag).TenDoiTuong : "";
            //cboLoaiThe.SelectedValue = ctu.LoaiTheKhachHang;
            //txtDiemTichLuy.Text = Common.Double2Str(ctu.SoTienTichLuy);
            txtCongTy.Text = ctu.CongTy;
            txtHoTenKhachHang.Text = ctu.HoTen;
            cboGioiTinh.SelectedIndex = ctu.GioiTinh;
            txtTuoi.Text = ctu.DoTuoi.ToString();
            txtMaSoThue.Text = ctu.MaSoThue;
            txtEmail.Text = ctu.Email;
            txtWebSite.Text = ctu.Website;
            //txtSoTaiKhoan.Text = Business.ChungTu.SoTaiKhoan;
            //txtNganHang.Text = Business.ChungTu.NganHang;
            UtilFunctions.LoadTinhThanh(bteTinh, ctu.IdTinhGH);
            UtilFunctions.LoadQuanHuyen(bteHuyen, ctu.IdHuyenGH);
            txtDiaChi.Text = ctu.DiaChi;
            UtilFunctions.LoadTinhThanh(bteTinhHD, ctu.IdTinhHD);
            UtilFunctions.LoadQuanHuyen(bteHuyenHD, ctu.IdHuyenHD);
            txtDiaChiHD.Text = ctu.DiaChiHD;
            txtSoHDDaMua.Text = ctu.SoSeri;
            txtSoChungTuGoc.Text = ctu.SoChungTu;
            cboNgheNghiep.SelectedValue = ctu.IdNgheNghiep;

            txtTongTienHang.Text = Common.Double2Str(0);
            txtTongTienCK.Text = Common.Double2Str(0);
            txtTongTienSauCK.Text = Common.Double2Str(0);
            txtTongTienVAT.Text = Common.Double2Str(0);
            txtTongTienThanhToan.Text = Common.Double2Str(0);
            txtTienThucTra.Text = Common.Double2Str(0);
            txtTienConNo.Text = Common.Double2Str(0);
        }
        private void LoadNoKhuyenMai(ChungTuBanHangInfor ctu, int idKho)
        {
            Business.ListChiTietChungTu = BanHangDataProvider.Instance.GetListChiTietChungTuNoKhuyenMai(ctu.IdChungTu, idKho);
            
            gSanPhamBan.DataSource = new BindingList<ChungTuBanHangChiTietInfor>(Business.ListChiTietChungTu);

            liChungTuChiTiet = ChungTuBanHangChiTietInfor.CopyList(Business.ListChiTietChungTu);
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
            bteKhachHang.Tag = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(Business.ChungTu.IdDoiTuong);
            bteKhachHang.Text = bteKhachHang.Tag != null ? ((DMDoiTuongInfo)bteKhachHang.Tag).TenDoiTuong : "";

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
            mstNgayHenGiaoHang.Value = Business.ChungTu.NgayHenGiaoHang;
            txtGhiChu.Text = Business.ChungTu.GhiChu;

            cboQuyen.SelectedValue = Business.ChungTu.QuyenSo;
            //txtKyHieu.Text = Business.ChungTu.KyHieu;
            txtSoSerie.Text = Business.ChungTu.SoSeri;
            //cboBangKeThue.SelectedValue = Business.ChungTu.IdBangKeThue;
            cboLoaiHoaDon.SelectedValue = Business.ChungTu.IdLoaiHdBanHang;
            cboMaDuAn.SelectedValue = Business.ChungTu.IdDuAn;

            bteKhachLe.Tag = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(Business.ChungTu.IdKhachLe);
            bteKhachLe.Text = bteKhachLe.Tag != null ? ((DMDoiTuongInfo)bteKhachLe.Tag).TenDoiTuong : "";
            //cboLoaiThe.SelectedValue = Business.ChungTu.LoaiTheKhachHang;
            //txtDiemTichLuy.Text = Common.Double2Str(Business.ChungTu.SoTienTichLuy);
            txtCongTy.Text = Business.ChungTu.CongTy;
            txtHoTenKhachHang.Text = Business.ChungTu.HoTen;
            cboGioiTinh.SelectedIndex = Business.ChungTu.GioiTinh;
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
            this.Text = CommonFuns.Instance.GetOrderInfor(Business.ChungTu, Updating, LoaiGiaoDichBanHang.XUAT_BU_KHUYEN_MAI);
            tsslTrangThai.Text = Common.GetOrderStatus(TrangThaiDonHang, Draft);
            tslInfor.Text = "Đơn hàng xuất bù khuyến mại";
        }

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            try
            {
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
                    }
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
            txtMaSanPham.Focus();

        }

        private void frmPhieuXuat_KeyDown(object sender, KeyEventArgs e)
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
                else if (e.KeyCode == Keys.F5 && tsbEdit.Enabled)
                    this.tsbConfirm_Click(sender, e);
                else if (e.KeyCode == Keys.F2 && tsbUpdate.Enabled)
                    this.tsbUpdate_Click(sender, e);
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
                int IdKhoSelected = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : 0;
                int IdTTamSelected = _IdTrungTam;

                if (_IdTrungTam == 0 || bteKhoXuat.Tag == null || _IdLoaiKhachHang == 0)
                {
                    MessageBox.Show("Phải chọn kho và khách hàng");
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
                else if (spb.TonKho == 0)
                {
                    MessageBox.Show("Hàng đã hết tồn kho!");
                    return;
                }

                List<ChungTuBanHangChiTietInfor> liCT = liChungTuChiTiet.FindAll(delegate(ChungTuBanHangChiTietInfor match)
                                                                                     {
                                                                                         return
                                                                                             match.MaSanPham.Equals(
                                                                                                 spb.MaSanPham);
                                                                                     });
                ChungTuBanHangChiTietInfor nokm;
                if (liCT.Count == 0)
                {
                    MessageBox.Show(String.Format("Sản phẩm [{0} - {1}] không phải hàng nợ khuyến mại!", spb.MaSanPham,
                                                  spb.TenSanPham));
                    return;                    
                } 
                else if (liCT.Count == 1)
                {
                    nokm = liCT[0];
                }
                else
                {
                    frmBH_ChonHangKhuyenMai frm = new frmBH_ChonHangKhuyenMai(liCT);
                    if (frm.ShowDialog() ==  DialogResult.OK)
                    {
                        nokm = frm.ChungTuChiTiet;
                    }
                    else
                    {
                        return;
                    }
                }
                ChungTuBanHangChiTietInfor ctu =
                    Business.ListChiTietChungTu.Find(delegate(ChungTuBanHangChiTietInfor match)
                                                         {
                                                             return match.MaSanPham == nokm.MaSanPham &&
                                                                    match.IdSanPhamBan == nokm.IdSanPhamBan;
                                                         });
                if (ctu != null)
                {
                    if (spb.TonKho < ctu.SoLuong + 1)
                    {
                        MessageBox.Show("Không đủ hàng để xuất!");
                        return;
                    }
                    ctu.SoLuong += 1;
                    ((BindingList<ChungTuBanHangChiTietInfor>)gSanPhamBan.DataSource).ResetBindings();
                    SLChitietOld = ctu.SoLuong;
                }
                else
                {
                    //add san pham ban
                    ChungTuBanHangChiTietInfor km = BanHangDataProvider.Instance.ConvertNoKM2SanPhamKM(nokm);
                    km.TonKho = spb.TonKho;
                    km.IdChungTu = Business.ChungTu.IdChungTu;
                    ((BindingList<ChungTuBanHangChiTietInfor>)gSanPhamBan.DataSource).Add(km);
                    ((BindingList<ChungTuBanHangChiTietInfor>)gSanPhamBan.DataSource).ResetBindings();
                    SLChitietOld = km.SoLuong;
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

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            InputDataFromCode(txtMaSanPham.Text.Trim());
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (_IdTrungTam == 0 || _IdLoaiKhachHang == 0 || bteKhoXuat.Tag == null || bteKhachHang.Tag == null)
                {
                    if (!ChonCaLamViec())
                        return;
                }

                frmBH_ChonDonHangKhuyenMai frm = new frmBH_ChonDonHangKhuyenMai();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadDonHangChinh(frm.DonHangChinh);
                    ThemMoiDonHang();
                    LoadNoKhuyenMai(frm.DonHangChinh, Business.ChungTu.IdKho);
                    Business.ChungTuChinhInfor = frm.DonHangChinh;
                    Updating = true;
                    setEDItems();
                    setEDFunctions();
                    ShowInfors();
                }
                else
                    this.Close();
            }
            catch(ManagedException ex)
            {
                MessageBox.Show(ex.Message);
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

        private void ThemMoiDonHang()
        {
            Draft = -1;
            IsAdded = true;
            ResetChungTuInfor();
            LoaiChungTu = (int) TransactionType.DON_HANG_BU_KHUYEN_MAI;
            TrangThaiDonHang = (int)OrderStatus.DON_HANG_BAN_TAI_SHOP;
            Business = new LapDonHangBuKMBusiness(LoaiChungTu, nguoiDung.IdNhanVien, ((DMKhoInfo)bteKhoXuat.Tag).IdKho);

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
        private bool ValidEditChungTu()
        {
            if (Business.ChungTu.IdChungTu == 0 || Business.ChungTu.IdChungTu > 0 &&
                (TrangThaiDonHang == (int)OrderStatus.DON_HANG_BAN_TAI_SHOP && (Draft == 1 || nguoiDung.SupperUser == 1)))
            {
                return true;
            }

            return false;
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
            //txtShipTo.Enabled = Updating;
            //cboShipTo.Enabled = Updating;
            //txtBillTo.Enabled = Updating;
            //cboShipTo.Enabled = Updating;
            //txtOrderType.Enabled = Updating;
            //cboOrderType.Enabled = Updating;
            //cboBangKeThue.Enabled = Updating;
            //cboLoaiHoaDon.Enabled = Updating;
            cboMaDuAn.Enabled = Updating;

            bteKhachLe.Properties.ReadOnly = !Updating;
            //txtDiemTichLuy.ReadOnly = !Updating;
            txtCongTy.ReadOnly = !Updating;
            txtHoTenKhachHang.ReadOnly = !Updating;
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

            //btnXoaTT.Enabled = Updating;
            //btnThanhToan.Enabled = Updating;
            //bteThoiHanThanhToan.Enabled = Updating;

            //btnChonKho.Enabled = Updating;
            bteKhoXuat.Properties.ReadOnly = !Updating;
            bteKhachHang.Properties.ReadOnly = !Updating;
            txtMaSanPham.Enabled = false;//Updating;
            btnThemHang.Enabled = false;//Updating;

            btnChietKhau.Enabled = false;//Updating;
            btnXoaSanPham.Enabled = Updating;
            //btnXoaKhuyenMai.Enabled = Updating;
        }

        private void setEDFunctions()
        {
            tsbAdd.Enabled = !Updating;//them moi, chuyen don hang online, don dat hang truoc
            tsbEdit.Enabled = !Updating && ValidEditChungTu();
            tsbUpdate.Enabled = Updating;// || (TrangThaiDonHang != (int)OrderStatus.PHAN_CONG_GIAO_NHAN);//cap nhat
            tsbDelete.Enabled = ValidDeleteChungTu();
            tsbConfirm.Enabled = Updating;//xac nhan
            tsbPrint.Enabled = !Updating && (Business.ChungTu.IdChungTu > 0) && (Draft == 0 || nguoiDung.SupperUser == 1);
            tsbPayment.Enabled = Updating;
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
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (ValidChungTuInfor())
                {
                    ConnectionUtil.Instance.BeginTransaction();

                    SaveChungTuInstance();
                    Business.SaveChungTu();
                    SuDungHoaDonDataProvider.UpdateNextSoHoaDon(Business.ChungTu.QuyenSo,
                                                                Common.IntValue(Business.ChungTu.SoSeri));

                    ConnectionUtil.Instance.CommitTransaction();

                    if (!isIn)
                    {
                        if (IsAdded)
                        {
                            MessageBox.Show("Lập đơn hàng xuất bù khuyến mại thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật đơn hàng xuất bù khuyến mại thành công!");
                        }
                    }

                    return true;
                }
            }
            catch (Exception)
            {
                ConnectionUtil.Instance.RollbackTransaction();
                Business.ChungTu.IdChungTu = oldId;
                this.Close();
                throw;
            }
            Common.SetFormStatus(this.Name, true);
            Cursor.Current = Cursors.Default;
            return false;
        }

        private void SaveChungTuInstance()
        {
            //RecalculateInfors();
            //update trang thai don hang
            UpdateTrangThaiChungTu();
            //update header
            UpdateChungTuHeader();
            //update thanh toan
            UpdateChungTuThanhToan();
            //update detail
            UpdateChungTuDetails();
        }

        private void UpdateChungTuHeader()
        {
            Business.ChungTu.SoChungTu = txtSoOrderKH.Text;
            Business.ChungTu.NgayLap = mstNgayLapPhieu.Value;
            if (String.IsNullOrEmpty(Business.ChungTu.SoSeri) && !String.IsNullOrEmpty(txtSoSerie.Text))
            {
                Business.ChungTu.NgayHoaDon = CommonProvider.Instance.GetSysDate();
                dteNgayHoaDon.EditValue = Business.ChungTu.NgayHoaDon;
            }
            Business.ChungTu.LoaiChungTu = LoaiChungTu;
            Business.ChungTu.TrangThai = TrangThaiDonHang;
            Business.ChungTu.IdTrungTam = _IdTrungTam;
            Business.ChungTu.IdTrungTamHachToan = _IdTrungTamHachToan;
            Business.ChungTu.IdKho = ((DMKhoInfo)bteKhoXuat.Tag).IdKho;
            Business.ChungTu.IdNhanVien = ((DMNhanVienInfo)bteThuongVien.Tag).IdNhanVien;
            Business.ChungTu.QuyenSo = Common.IntValue(cboQuyen.SelectedValue);
            Business.ChungTu.SoSeri = txtSoSerie.Text;
            Business.ChungTu.KyHieu = cboQuyen.Text;
            Business.ChungTu.SoChungTuGoc = txtSoChungTuGoc.Text;
            Business.ChungTu.SoPhieuDC = txtSoPhieuDC.Text;
            Business.ChungTu.IdDoiTuong = ((DMDoiTuongInfo)bteKhachHang.Tag).IdDoiTuong;
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
            Business.ChungTu.HinhThucTra = bteThoiHanThanhToan.Tag != null ? ((DMLoaiThuChiInfor)bteThoiHanThanhToan.Tag).IdThuChi : 0;
            Business.ChungTu.GhiChu = txtGhiChu.Text;
            //Business.ChungTu.IdBangKeThue = Common.IntValue(cboBangKeThue.SelectedValue);
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
                if (ctu.IdSanPhamBan == 0 || ctu.LoaiHangKem == 1 || Common.Int2Bool(ctu.ChietKhau))//spc hoac hang kem hoac km
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
            foreach (ChungTuBanHangChiTietInfor ct in Business.ListChiTietChungTu)
            {
                ct.NoKhuyenMai = 0;
            }
            //BanHangDataProvider.Instance.MergeListBanKMai2ChiTiet(ref Business.ListChiTietChungTu, liChungTuBanHangChiTiet, liChungTuKhuyenMaiChiTiet);
            //Business.ListChiTietChungTu = liChungTuBanHangChiTiet;
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
                    MessageBox.Show("Đơn hàng đã thay đổi trạng thái không thể sửa được");
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
                        //restore trang thai don hang cu
                        if (Draft == 1 && TrangThaiDonHang == (int)OrderStatus.DON_HANG_BAN_TAI_SHOP)
                            Business.DeleteChungTu();//xoa chung tu neu chua xuat
                        else
                        {
                            //khoi phuc trang thai chungtu
                            RestoreTrangThaiChungTu();

                            //restore trang thai don hang cu
                            Business.ChungTu.TrangThai = TrangThaiDonHang;
                            Business.ChungTu.Draft = 0;
                            Business.CancelChungTu();
                        }
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
                    MessageBox.Show("Chưa có số hóa đơn bán. Không thể in hóa đơn được");
                    return;
                }
            }
            if (gvSanPhamBan.RowCount == 0 || Business.ChungTu.IdChungTu == 0 || Business.ListChiTietChungTu.Count == 0)
            {
                MessageBox.Show("Chưa có sản phẩm bán");
                return;
            }
            //in hoa don tai chinh
            CommonFuns.Instance.InHoaDonKhuyenMai(Business.ChungTu, Business.ListChiTietChungTu, bteKhoXuat, bteThuongVien, bteKhachHang);
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

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng hàng này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (int i in gvSanPhamBan.GetSelectedRows())
                {
                    gvSanPhamBan.DeleteRow(i);
                }
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
                    Business = new LapDonHangBuKMBusiness(ctu);
                    LoadChungTuInstance();

                    Updating = false;
                    setEDItems();
                    setEDFunctions();
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
                //if (Common.DoubleValue(txtTongTienThanhToan.Text) == Common.DoubleValue(txtTienThucTra.Text))
                //{
                //    MessageBox.Show("Đơn hàng này đã thanh toán đủ tiền. Không thể thanh toán thêm nữa");
                //    return;
                //}
                frmBH_ChonHinhThucTT frm = new frmBH_ChonHinhThucTT(Business.ListChungTuThanhToan,
                                                                    txtSoOrderKH.Text,
                                                                    Common.DoubleValue(txtTongTienThanhToan.Text),
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
            catch { }
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
 
        private void tsbConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Draft = 0;
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
#if DEBUG
                MessageBox.Show("Lỗi thao tác\n" + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi thao tác", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void LoadDoiTuongInfor(DMDoiTuongInfo dt)
        {
            txtHoTenKhachHang.Text = dt.TenDoiTuong;
            cboGioiTinh.SelectedIndex = dt.GioiTinh;
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

        private void gvSanPhamBan_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            ChungTuBanHangChiTietInfor ct = (ChungTuBanHangChiTietInfor)gvSanPhamBan.GetRow(gvSanPhamBan.FocusedRowHandle);
            if (ct != null)
            {
                ct.GhiChu = ct.SoLuong <= ct.TonKho ? "Đủ hàng" : "Không đủ hàng";
                if (Common.IntValue(ct.SoLuong) <= 0)
                    ct.SoLuong = 0;
            }
            
            //    double tyleVAT = ctu.TyleVAT < 0 ? 0 : ctu.TyleVAT;
            //    double tongtien = ctu.SoLuong * ctu.DonGia;
            //    ctu.TienChietKhau = Common.Round(tongtien * ctu.TyleChietKhau / TyLe);
            //    ctu.TienSauChietKhau = tongtien - ctu.TienChietKhau;
            //    ctu.TienVAT = Common.Round(ctu.TienSauChietKhau * tyleVAT / TyLe);
            //    ctu.ThanhTien = ctu.TienSauChietKhau + ctu.TienVAT;

            //if (gvSanPhamBan.FocusedRowHandle < 0) return;
            //if (e.Column.FieldName == "SoLuong" || e.Column.FieldName == "DonGia" || e.Column.FieldName == "TyleChietKhau" || e.Column.FieldName == "TyleVAT")
            //{
            //    ChungTuBanHangChiTietInfor ctu = (ChungTuBanHangChiTietInfor)gvSanPhamBan.GetRow(gvSanPhamBan.FocusedRowHandle);
            //    double tyleVAT = ctu.TyleVAT < 0 ? 0 : ctu.TyleVAT;
            //    double tongtien = ctu.SoLuong * ctu.DonGia;

            //    ctu.TienChietKhau = Common.Round(tongtien * ctu.TyleChietKhau / TyLe);
            //    ctu.TienSauChietKhau = tongtien - ctu.TienChietKhau;
            //    ctu.TienVAT = Common.Round(ctu.TienSauChietKhau * tyleVAT / TyLe);
            //    ctu.ThanhTien = ctu.TienSauChietKhau + ctu.TienVAT;
            //}

            //if (e.Column.FieldName == "SoLuong")
            //{
            //    ChungTuBanHangChiTietInfor spb = (ChungTuBanHangChiTietInfor)gvSanPhamBan.GetRow(gvSanPhamBan.FocusedRowHandle);
            //    int slnew = spb.SoLuong;
            //    foreach (ChungTuBanHangChiTietInfor ct in (BindingList<ChungTuBanHangChiTietInfor>)gvSanPhamBan.DataSource)
            //    {
            //        if (ct.IdSanPhamBan == spb.IdSanPham)
            //        {
            //            ct.SoLuong = spb.SoLuong * ct.SoLuong / SLChitietOld;
            //            ct.ThanhTien = spb.SoLuong * ct.ThanhTien / SLChitietOld;
            //            ct.NoKhuyenMai = spb.SoLuong * ct.NoKhuyenMai / SLChitietOld;
            //        }
            //    }
            //    SLChitietOld = spb.SoLuong;
            //}
            //UpdateSummariesInfors();
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
            if (UtilFunctions.bteItem_TextChanged(sender, e, bteKhoXuat))
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
            if (UtilFunctions.bteKhoXuat_KeyDown(sender, e, bteKhoXuat, -1, nguoiDung.IdNhanVien))
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
            if (UtilFunctions.bteKhoXuat_ButtonClick(sender, e, bteKhoXuat, -1, nguoiDung.IdNhanVien))
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
            int IdKhoSelected = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : 0;
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

        private void bteKhachLe_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //int idDoiTuongCha = bteKhachHang != null ? ((DMDoiTuongInfo)bteKhachHang.Tag).IdDoiTuong : -1;
            //UtilFunctions.bteKhachLe_ButtonClick(sender, e, bteKhachLe, idDoiTuongCha);
        }

        private void bteKhachLe_KeyDown(object sender, KeyEventArgs e)
        {
            //int idDoiTuongCha = bteKhachHang != null ? ((DMDoiTuongInfo)bteKhachHang.Tag).IdDoiTuong : -1;
            //UtilFunctions.bteKhachLe_KeyDown(sender, e, bteKhachLe, idDoiTuongCha);
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
            int idKhoDen = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : -1;
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

        private void txtSoPhieuDC_Leave(object sender, EventArgs e)
        {
            CheckSoPhieuDieuChuyen();
        }

        private void txtSoPhieuDC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckSoPhieuDieuChuyen();
            }
        }

        private void frmBH_LapDonHangBanKhuyenMai_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Business.ChungTu.IdChungTu > 0 && Business.ChungTu.Draft == 1 && MessageBox.Show("Đơn hàng mới lưu nháp, chưa được xác nhận!!\n\nCác bộ phận khác sẽ không nhìn thấy được!!!\n\nBạn có đồng ý thoát chức năng này không? (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                CommonProvider.Instance.Lock_Unlock_ChungTu(Business.ChungTu.IdChungTu, 0);//mo chung tu                    
                e.Cancel = true;
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
            int idTinh = bteTinhHD.Tag != null ? ((DMTinhInfor)bteTinhHD.Tag).IdTinh : 0;
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
            else if (soluong > ct.SoLuongOld)
            {
                MessageBox.Show("Số lượng bán vượt quá số lượng nợ khuyến mại. Vui lòng kiểm tra lại!");
                e.Valid = false;
            }
        }
    }
}