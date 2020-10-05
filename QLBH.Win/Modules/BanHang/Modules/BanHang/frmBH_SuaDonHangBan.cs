using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms;
using QLBanHang.Modules.BanHang.Reports;
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
using QLBH.Core.Providers;
using QLBanHang.Modules.DanhMuc;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBH_SuaDonHangBan : DevExpress.XtraEditors.XtraForm
    {
        #region "Khai báo biến"
        List<DmLoaiDoiTuongInfor> liLoaiDT = new List<DmLoaiDoiTuongInfor>();
        List<SuDungHoaDonInfor> liSuDungHD = new List<SuDungHoaDonInfor>();
        List<DMTinhInfor> liTinh = new List<DMTinhInfor>();
        List<DMHuyenInfor> liHuyen = new List<DMHuyenInfor>();
        List<DmNgheNghiepInfor> liNgheNghiep = new List<DmNgheNghiepInfor>();

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

        private bool IsInHoaDon = false;
        private int ChucNang = 0;//1: sua chung tu; 2: doi khuyen mai; 3: sua phieu thu; 4: sua giao van

        private BanHangBusiness Business;
        #endregion

        #region "Các phương thức khởi tạo"
        public frmBH_SuaDonHangBan()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            Business = new BanHangBusiness();
        }

        public frmBH_SuaDonHangBan(int chucNang)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            ChucNang = chucNang;
            Business = new BanHangBusiness();
            if (ChucNang == 1)
                this.Text = "Sửa thông tin đơn hàng";
            else if (ChucNang == 2)
                this.Text = "Đổi hàng nợ khuyến mại";
            else if (ChucNang == 3)
                this.Text = "Sửa phiếu thu/chi";
            else if (ChucNang == 4)
                this.Text = "Sửa thông tin giao vận";
        }

        public frmBH_SuaDonHangBan(ChungTuBanHangInfor chungTuBanHangInfor)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            Business = new BanHangBusiness(chungTuBanHangInfor);
        }


        #endregion

        #region "Các phương thức"
        /// <summary>
        /// Khoi tao don hang
        /// </summary>
        /// <returns></returns>
        private void ResetChungTuInfor()
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
                txtSoChungTuGoc.ResetText();
                txtSoPhieuDC.ResetText();
                bteThuongVien.Tag = null;
                bteThuongVien.ResetText();

                txtDienThoai.ResetText();
                txtCMND.ResetText();
                cboCaBanHang.SelectedValue = DMCaBanHangDataProvider.Instance.GetCurrentCaBanHangInfors().KyHieu;
                cboGiaoHang.SelectedIndex = 0;
                mstNgayHenGiaoHang.Value = CommonProvider.Instance.GetSysDate();
                txtGhiChu.ResetText();

                bteKhachLe.Tag = null;
                bteKhachLe.ResetText();
                //cboLoaiThe.SelectedIndex = -1;
                //txtDiemTichLuy.ResetText();
                txtCongTy.ResetText();
                txtHoTenKhachHang.ResetText();
                cboGioiTinh.SelectedIndex = 0;
                txtTuoi.ResetText();
                txtMaSoThue.ResetText();
                txtEmail.ResetText();
                txtWebSite.ResetText();

                txtDiaChi.ResetText();
                txtSoHDDaMua.ResetText();
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

        private bool ValidChungTuCommonInfor()
        {
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
            if (this.bteKhachHang.Tag == null && Business.ChungTu.LoaiChungTu != (int)TransactionType.DON_HANG_GIAO_NHAN)
            {
                MessageBox.Show("Chưa chọn khách hàng." + "\nHãy chọn khách hàng", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.bteKhachHang.Focus();
                return false;
            }
            if (txtHoTenKhachHang.Text.Trim().Equals("") && Business.ChungTu.LoaiChungTu != (int)TransactionType.DON_HANG_GIAO_NHAN)
            {
                MessageBox.Show("Tên khách hàng không được để trống", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtHoTenKhachHang.Focus();
                return false;
            }
            if (txtDiaChiHD.Text.Trim().Equals("") && Business.ChungTu.LoaiChungTu != (int)TransactionType.DON_HANG_GIAO_NHAN)
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
            //if (this.txtSoSerie.Text.Trim().Length == 0 && Business.ChungTu.LoaiChungTu != (int)TransactionType.DON_HANG_GIAO_NHAN && Business.ChungTu.LoaiChungTu != (int)TransactionType.DON_HANG_TAI_SHOP && Business.ChungTu.LoaiChungTu != (int)TransactionType.DON_HANG_ONLINE)
            //{
            //    MessageBox.Show("Số serie hóa đơn chưa nhập." + "\n" + "-Hãy nhập Số serie hóa đơn", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.txtSoSerie.Focus();
            //    return false;
            //}

            if (!String.IsNullOrEmpty(txtSoSerie.Text.Trim()))
            {
                string soseri = txtSoSerie.Text.Trim();
                string kyhieu = chkHDNhay.Checked
                                    ? "KXD"
                                    : (cboQuyen.Text.IndexOf("(") > -1
                                           ? cboQuyen.Text.Substring(0, cboQuyen.Text.IndexOf("("))
                                           : cboQuyen.Text);


                if ((Business.ChungTu.IdChungTu == 0 || Business.ChungTu.IdChungTu > 0 && (Business.ChungTu.SoSeri == null || !Business.ChungTu.SoSeri.Equals(soseri)) && !chkHDNhay.Checked) && cboQuyen.SelectedValue == null ||
                    (cboQuyen.SelectedValue != null || chkHDNhay.Checked && !String.IsNullOrEmpty(soseri)) &&
                    !SuDungHoaDonDataProvider.CheckSoHoaDon(Common.IntValue(soseri), Business.ChungTu.IdChungTu, soseri, kyhieu) && Business.ChungTu.LoaiChungTu != (int)TransactionType.DON_HANG_GIAO_NHAN)
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
            //if (this.cboLoaiHoaDon.SelectedIndex != 0 && Business.ChungTu.LoaiChungTu != (int)TransactionType.DON_HANG_GIAO_NHAN)
            //{
            //    MessageBox.Show("Đây là đơn hàng bán chịu thuế." + "\nHãy chọn lại loại hóa đơn bán", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.cboLoaiHoaDon.Focus();
            //    return false;                
            //}
            //if (Business.ListChungTuThanhToan.Count == 0 && LoaiChungTu != (int)TransactionType.DON_HANG_GIAO_NHAN && LoaiChungTu != (int)TransactionType.DON_HANG_ONLINE)
            //{
            //    MessageBox.Show("Chưa chọn thông tin thanh toán." + "\nHãy chọn hình thức thanh toán", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.btnThanhToan.Focus();
            //    return false;
            //}
            if ((Common.DoubleValue(txtTienThucTra.Text) > Common.DoubleValue(txtTongTienThanhToan.Text) || Common.DoubleValue(txtTienConNo.Text) < 0) && Business.ChungTu.LoaiChungTu != (int)TransactionType.DON_HANG_GIAO_NHAN)
            {
                MessageBox.Show("Tiền thực trả không thể lớn hơn số tiền cần thanh toán!");
                return false;
            }
            //kiem tra han muc tin dung tung khach le
            //if (bteKhachLe.Tag != null)
            //{
            //    DMDoiTuongInfo dt = (DMDoiTuongInfo)bteKhachLe.Tag;
            //    if (dt.HanMucTinDung > 0 && dt.HanMucTDConLai < Common.DoubleValue(txtTienConNo.Text))
            //    {
            //        MessageBox.Show(String.Format("Số tiền nợ đã vượt quá hạn mức tín dụng còn lại [{0}] của khách hàng {1} - {2}", Common.Double2Str(dt.HanMucTDConLai), dt.MaRieng, dt.TenDoiTuong), Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        return false;
            //    }
            //}
            ////kiem tra han muc tin dung tung khach hang
            //if (bteKhachHang.Tag != null)
            //{
            //    DMDoiTuongInfo dt = (DMDoiTuongInfo)bteKhachHang.Tag;
            //    if (dt.HanMucTinDung > 0 && dt.HanMucTDConLai < Common.DoubleValue(txtTienConNo.Text))
            //    {
            //        MessageBox.Show(String.Format("Số tiền nợ đã vượt quá hạn mức tín dụng còn lại [{0}] của khách hàng {1} - {2}", Common.Double2Str(dt.HanMucTDConLai), dt.MaDoiTuong, dt.TenDoiTuong), Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        return false;
            //    }
            //}
            if (Business.ListChungTuThanhToan.Count != 0)
            {
                foreach (ChungTuThanhToanInfor tt in Business.ListChungTuThanhToan)
                {
                    if (String.IsNullOrEmpty(tt.HinhThucThanhToan) || tt.IdHinhThucThanhToan == 0)
                    {
                        MessageBox.Show(String.Format("Phiếu thu [{0}] chưa chọn hình thức thanh toán", tt.SoPhieu));
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

        public bool ValidThanhToanInfor()
        {
            for (int i=0; i< Business.ListChungTuThanhToan.Count-1; i++)
                for (int j=i+1; j< Business.ListChungTuThanhToan.Count; j++)
                {
                    if (Business.ListChungTuThanhToan[i].SoPhieu.Equals(Business.ListChungTuThanhToan[j].SoPhieu))
                    {
                        MessageBox.Show("Số phiếu " + Business.ListChungTuThanhToan[i].SoPhieu +
                                        " bị trùng. Vui lòng kiểm tra lại");
                        return false;
                    }
                }
            
            return true;
        }

        private bool ValidChungTuInfor()
        {
            if (!ValidChungTuCommonInfor())
                return false;
            if (!ValidThanhToanInfor())
                return false;
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

        private void LoadDMTinh()
        {
            liTinh = DMTinhDataProvider.Instance.GetListTinhInfors();
            cboTinh.DataSource = liTinh;
            cboTinh.DisplayMember = "TenTinh";
            cboTinh.ValueMember = "IdTinh";
            cboTinh.SelectedIndex = -1;
        }

        private void LoadDMTinhHD()
        {
            List<DMTinhInfor> liTinhHD = new List<DMTinhInfor>();
            liTinhHD.AddRange(liTinh);
            cboTinhHD.DataSource = liTinhHD;
            cboTinhHD.DisplayMember = "TenTinh";
            cboTinhHD.ValueMember = "IdTinh";
            cboTinhHD.SelectedIndex = -1;
        }
        private void LoadDMHuyen()
        {
            liHuyen = DMHuyenDataProvider.Instance.GetListHuyenByTinhInfors(Common.IntValue(cboTinh.SelectedValue));
            cboHuyen.DataSource = liHuyen;
            cboHuyen.DisplayMember = "TenHuyen";
            cboHuyen.ValueMember = "IdHuyen";
            cboHuyen.SelectedIndex = -1;
        }

        private void LoadDMHuyenHD()
        {
            List<DMHuyenInfor> liHuyenHD = DMHuyenDataProvider.Instance.GetListHuyenByTinhInfors(Common.IntValue(cboTinhHD.SelectedValue));
            cboHuyenHD.DataSource = liHuyenHD;
            cboHuyenHD.DisplayMember = "TenHuyen";
            cboHuyenHD.ValueMember = "IdHuyen";
            cboHuyenHD.SelectedIndex = -1;
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
                bteTrungTam.Tag = tt;
                bteTrungTam.Text = tt.TenTrungTam;
                //grThongTin.Text = String.Format("Trung tâm: {0} - {1}", tt.MaTrungTam, tt.TenTrungTam);
            }
        }
        private void LoadLoaiHoaDon()
        {
            cboLoaiHoaDon.DataSource = DMLoaiHoaDonDataProvider.Instance.GetListLoaiHoaDonInfo();
            cboLoaiHoaDon.DisplayMember = "Ten";
            cboLoaiHoaDon.ValueMember = "Id";
            cboLoaiHoaDon.SelectedIndex = 0;
        }
        private void LoadLoaiDT()
        {
            liLoaiDT = DmLoaiDoiTuongDataProvider.GetListLoaiDoiTuongInfor();

            if (liLoaiDT.Count > 0)
            {
                cboCurrentLoaiDT.DataSource = liLoaiDT;
                cboCurrentLoaiDT.DisplayMember = "TenLoaiDT";
                cboCurrentLoaiDT.ValueMember = "IdLoaiDT";
                cboCurrentLoaiDT.SelectedValue = Declare.IdLoaiKhachHang;
            }
            else
            {
                cboCurrentLoaiDT.DataSource = null;
            }
        }
        private void LoadComboBoxData()
        {
            try
            {
                LoadLoaiDT();
                //LoadTrungTam();
                //LoadKhoXuat();
                //LoadOrderType();
                //LoadKhachHang();
                //LoadTienTe();
                //LoadMaVach();
                //if (Business.ChungTu.LoaiChungTu != (int)TransactionType.DON_HANG_GIAO_NHAN)
                //{
                    LoadQuyen();
                //}
                //LoadLoaiThuChi();
                //LoadDiaChiKH();
                //LoadBangKeThue();
                LoadLoaiHoaDon();
                //LoadMaDuAn();
                //LoadHinhThucTT();
                LoadDMTinh();
                LoadDMTinhHD();
                LoadDMNgheNghiep();
                LoadGioiTinh();
                //LoadThuNgan();
                //LoadTruongCa();
                //LoadThoiHanThanhToan();
                LoadCaBanHang();
                cboQuocGia.SelectedIndex = 0;
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
                    ResetChungTuInfor();
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
            chkDraft.Checked = Common.Int2Bool(Business.ChungTu.Draft);
            if (!chkDraft.Checked)
                chkDraft.Enabled = false;

            _IdTrungTam = Business.ChungTu.IdTrungTam;
            _IdTrungTamHachToan = Business.ChungTu.IdTrungTamHachToan;
            LoadTrungTam();

            bteKhoXuat.Tag = DMKhoDataProvider.GetKhoByIdInfo(Business.ChungTu.IdKho);
            bteKhoXuat.Text = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).TenKho : "";
            if (Business.ChungTu.LoaiChungTu != (int)TransactionType.DON_HANG_GIAO_NHAN)
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

            if (Business.ChungTu.LoaiChungTu != (int)TransactionType.DON_HANG_GIAO_NHAN)
            {
                chkHDNhay.Checked = Business.ChungTu.QuyenSo == -1 ? true : false;
                cboQuyen.SelectedValue = Business.ChungTu.QuyenSo;
                //txtKyHieu.Text = Business.ChungTu.KyHieu;
                txtSoSerie.Text = Business.ChungTu.SoSeri;
                //cboBangKeThue.SelectedValue = Business.ChungTu.IdBangKeThue;
                //cboLoaiHoaDon.SelectedValue = Business.ChungTu.IdLoaiHdBanHang;
                cboLoaiHoaDon.SelectedIndex = 0;
                cboMaDuAn.SelectedValue = Business.ChungTu.IdDuAn;

                bteKhachLe.Tag = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(Business.ChungTu.IdKhachLe);
                bteKhachLe.Text = bteKhachHang.Tag != null ? ((DMDoiTuongInfo) bteKhachHang.Tag).TenDoiTuong : "";
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
                cboTinh.SelectedValue = Business.ChungTu.IdTinhGH;
                cboHuyen.SelectedValue = Business.ChungTu.IdHuyenGH;
                txtDiaChi.Text = Business.ChungTu.DiaChi;
                cboTinhHD.SelectedValue = Business.ChungTu.IdTinhHD;
                cboHuyenHD.SelectedValue = Business.ChungTu.IdHuyenHD;
                txtDiaChiHD.Text = Business.ChungTu.DiaChiHD;
                txtSoHDDaMua.Text = Business.ChungTu.SoHDDaMua;
                cboNgheNghiep.SelectedValue = Business.ChungTu.IdNgheNghiep;
                cboQuocGia.SelectedIndex = Business.ChungTu.DiaChiHoaDon.Contains("Việt Nam") ? 1 : 0;
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
            //this.Text = CommonFuns.Instance.GetOrderInfor(Business.ChungTu, Updating, LoaiGiaoDichBanHang.LAP_DONHANG_BAN);
            tsslTrangThai.Text = Common.GetOrderStatus(Business.ChungTu.TrangThai, Draft);

            tslInfor.Text = "Đơn hàng bán tại siêu thị";
            if (Business.ChungTu.LoaiChungTu == (int)TransactionType.DON_HANG_TAI_SHOP)
            {
                tslInfor.Text = "Đơn hàng bán tại siêu thị";
            }
            else if (Business.ChungTu.LoaiChungTu == (int)TransactionType.DON_HANG_ONLINE)
            {
                tslInfor.Text = "Đơn hàng bán Online";
            }
            else if (Business.ChungTu.LoaiChungTu == (int)TransactionType.DON_HANG_DAT_TRUOC)
            {
                tslInfor.Text = "Đơn hàng đặt mua trước";
            }
            else if (Business.ChungTu.LoaiChungTu == (int)TransactionType.DON_HANG_GIAO_NHAN)
            {
                tslInfor.Text = "Đơn hàng kèm giao nhận";
            }
        }

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            try
            {
                chkTinhKM.Visible = (nguoiDung.SupperUser == 1) ? true : false;
                LoadComboBoxData();
                if (Business.ChungTu.IdChungTu > 0)
                {
                    LoadChungTuInstance();
                    Updating = false;
                    setEDItems();
                    setEDFunctions();                            
                    ShowInfors();                            
                }
                else
                {
                    Updating = false;
                    setEDItems();
                    tsbEdit.Enabled = Updating;
                    tsbConfirm.Enabled = Updating;// || TrangThaiDonHang == (int)OrderStatus.PHAN_CONG_GIAO_NHAN;//xac nhan
                    tsbPrint.Enabled = Updating;
                    tsbPayment.Enabled = Updating;
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
            //txtMaSanPham.Focus();
        }

        private void frmPhieuXuat_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F4 && tsbEdit.Enabled)
                    this.tsbEdit_Click(sender, e);
                else if (e.KeyCode == Keys.F5 && tsbConfirm.Enabled)
                    this.tsbConfirm_Click(sender, e);
                else if (e.KeyCode == Keys.F11 && tsbPrint.Enabled)
                    this.tsbPrint_Click(sender, e);
                else if (e.KeyCode == Keys.F9 && tsbPayment.Enabled)
                    this.tsbPayment_Click(sender, e);
                else if (e.KeyCode == Keys.F12 && tsbClose.Enabled)
                    this.tsbClose_Click(sender, e);
                else if (e.KeyCode == Keys.F10 && btnThanhToan.Enabled)
                    this.btnThanhToan_Click(sender, e);
                else if (e.KeyCode == Keys.F6 && btnSuaTToan.Enabled)
                    this.btnSuaTToan_Click(sender, e);
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


        private void tsbEdit_Click(object sender, EventArgs e)
        {
            try
            {
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

        private void setEDItems()
        {
            txtSoOrderKH.Enabled = true;
            mstNgayLapPhieu.Enabled = Updating && (ChucNang == 1);
            bteThuongVien.Enabled = Updating && (ChucNang == 1);
            bteTruongCa.Enabled = Updating && (ChucNang == 1);
            bteThuNgan.Enabled = Updating && (ChucNang == 1);
            txtDienThoai.Enabled = Updating && (ChucNang == 1);
            txtCMND.Enabled = Updating && (ChucNang == 1);
            cboCaBanHang.Enabled = Updating && (ChucNang == 1);
            if (Business.ChungTu.GiaoNhan == 1 || Business.ChungTu.GiaoNhan == 2)
                cboGiaoHang.Enabled = Updating && (Business.ChungTu.TrangThai < 9) && (ChucNang != 4);
            else
                cboGiaoHang.Enabled = Updating && ChucNang != 4;

            //chkDraft.Enabled = Updating && (Business.ChungTu.Draft == 1);
            mstNgayHenGiaoHang.Enabled = Updating && (ChucNang == 4) && (cboGiaoHang.SelectedIndex > 0 ? true : false);
            txtGhiChu.Enabled = Updating && (ChucNang == 1);
            cboLoaiHoaDon.Enabled = Updating && (ChucNang == 1);

            cboQuyen.Enabled = Updating && (ChucNang == 1);
            chkHDNhay.Enabled = Updating && (ChucNang == 1);
            btnLoadQuyen.Enabled = Updating && (ChucNang == 1);
            //txtKyHieu.Enabled = Updating;
            txtSoSerie.Enabled = Updating && (ChucNang == 1);
            dteNgayHoaDon.Enabled = Updating && (ChucNang == 1);
            txtSoPhieuDC.Enabled = Updating && (ChucNang == 1);
            //txtShipTo.Enabled = Updating;
            //cboShipTo.Enabled = Updating;
            //txtBillTo.Enabled = Updating;
            //cboShipTo.Enabled = Updating;
            //txtOrderType.Enabled = Updating;
            //cboOrderType.Enabled = Updating;
            //cboBangKeThue.Enabled = Updating;
            //cboLoaiHoaDon.Enabled = Updating;
            cboMaDuAn.Enabled = Updating && (ChucNang == 1);

            bteKhachLe.Enabled = true;// Updating && (ChucNang == 1);
            //txtDiemTichLuy.Enabled = Updating && (ChucNang == 1);
            txtCongTy.Enabled = Updating && (ChucNang == 1);
            txtHoTenKhachHang.Enabled = Updating && (ChucNang == 1);
            cboGioiTinh.Enabled = Updating && (ChucNang == 1);
            txtTuoi.Enabled = Updating && (ChucNang == 1);
            txtMaSoThue.Enabled = Updating && (ChucNang == 1);
            txtEmail.Enabled = Updating && (ChucNang == 1);
            txtWebSite.Enabled = Updating && (ChucNang == 1);
            //txtSoTaiKhoan.Enabled = Updating;
            //txtNganHang.Enabled = Updating;
            
            cboTinhHD.Enabled = Updating && (ChucNang == 1);
            cboHuyenHD.Enabled = Updating && (ChucNang == 1);
            cboQuocGia.Enabled = Updating && (ChucNang == 1);
            txtDiaChiHD.Enabled = Updating && (ChucNang == 1);
            cboTinh.Enabled = Updating && (ChucNang == 1 || ChucNang == 4);
            cboHuyen.Enabled = Updating && (ChucNang == 1 || ChucNang == 4);
            txtDiaChi.Enabled = Updating && (ChucNang == 1 || ChucNang == 4);
            txtDiaChi.Enabled = Updating && (ChucNang == 1);
            txtSoHDDaMua.Enabled = Updating && (ChucNang == 1);
            cboNgheNghiep.Enabled = Updating && (ChucNang == 1);

            btnXoaTT.Enabled = Updating && (ChucNang == 3);
            btnThanhToan.Enabled = Updating && (ChucNang == 3);
            btnSaoChep.Enabled = Updating && (ChucNang == 3);
            btnSuaTToan.Enabled = Updating && (ChucNang == 3);
            bteThoiHanThanhToan.Enabled = Updating && (ChucNang == 3);
            txtTienThucTra.ReadOnly = !Updating || (ChucNang != 3);
            txtTongTienThanhToan.ReadOnly = true;// !Updating || (ChucNang != 3);

            bteTrungTam.Enabled = Updating && (nguoiDung.SupperUser == 1);
            //btnChonKho.Enabled = Updating;
            bteKhoXuat.Enabled = (Business.ChungTu.TrangThai == (int)OrderStatus.TAO_DON_HANG_ONLINE ||
                Business.ChungTu.TrangThai == (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC) && Updating && (nguoiDung.SupperUser == 1);
            bteKhachHang.Enabled = Updating && (ChucNang != 4);
            txtMaSanPham.Enabled = Updating && (ChucNang == 2);
            txtMaSanPham.ReadOnly = !Updating || (ChucNang != 2);
            //btnThemHang.Enabled = Updating && (ChucNang == 2);

            btnThemKM.Enabled = Updating && (ChucNang == 2);
            btnChietKhau.Enabled = Updating && (ChucNang == 2);
            btnXoaSanPham.Enabled = Updating && (ChucNang == 2);
            //btnXoaKhuyenMai.Enabled = Updating;
            ThanhTien.OptionsColumn.ReadOnly = !Updating || (ChucNang != 3);// || nguoiDung.SupperUser != 1 && nguoiDung.SuaChungTu != 1;
            GhiChu.OptionsColumn.ReadOnly = !Updating || (ChucNang != 3);

            SoLuong.OptionsColumn.ReadOnly = !Updating || (ChucNang != 2);
            txtSoChungTuGoc.ReadOnly = !Updating || (ChucNang != 1);
        }

        private void setEDFunctions()
        {
            tsbEdit.Enabled = !Updating;
            tsbConfirm.Enabled = Updating;// || TrangThaiDonHang == (int)OrderStatus.PHAN_CONG_GIAO_NHAN;//xac nhan
            tsbPrint.Enabled = !Updating;
            tsbPayment.Enabled = Updating;
        }

        private bool UpdateChungTu(bool isIn)
        {
            int oldId = Business.ChungTu.IdChungTu;
            int oldTT = Business.ChungTu.TrangThai;
            string oldSCT = Business.ChungTu.SoChungTu;
            string oldSCTG = Business.ChungTu.SoChungTuGoc;
            //double tongTienOld = Business.ChungTu.TongTienThanhToan;
            //double tienNoOld = Business.ChungTu.TienConNo;
            //double tienTraTruoc = -Business.ChungTu.TienThanhToanThuc;

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (ValidChungTuInfor())
                {
                    ConnectionUtil.Instance.BeginTransaction();
                    //luu chung tu dat truoc

                    SaveChungTuInstance();
                    Business.SaveChungTu();
                    //cap nhat cong no khach hang
                    //if (Business.ChungTu.TrangThai < 4 || Business.ChungTu.TrangThai == 5)
                    //{
                    //    BanHangDataProvider.Instance.UpdateCongNoKhachHang(Business.ChungTu.IdKhachLe,
                    //                                                       Business.ChungTu.IdDoiTuong,
                    //                                                       0,
                    //                                                       -Business.ChungTu.TienThanhToanThuc, 0,
                    //                                                       tienTraTruoc, Business.ChungTu.LoaiChungTu);
                    //}
                    //else
                    //{
                    //    BanHangDataProvider.Instance.UpdateCongNoKhachHang(Business.ChungTu.IdKhachLe,
                    //                                                       Business.ChungTu.IdDoiTuong,
                    //                                                       Business.ChungTu.TongTienThanhToan,
                    //                                                       Business.ChungTu.TienConNo, tongTienOld,
                    //                                                       tienNoOld, Business.ChungTu.LoaiChungTu);                        
                    //}
                    //cap nhat so hoa don moi (chuc nang sua chung tu va khong phai hoa don tu nhay)
                    if (ChucNang == 1 && cboQuyen.SelectedIndex > 0)
                    {
                        SuDungHoaDonDataProvider.UpdateNextSoHoaDon(Business.ChungTu.QuyenSo,
                                                                    Common.IntValue(Business.ChungTu.SoSeri));
                    }
                    ConnectionUtil.Instance.CommitTransaction();
                    if (!isIn)
                    {
                        MessageBox.Show("Cập nhật đơn hàng bán thành công!");
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
            Cursor.Current = Cursors.Default;
            return false;
        }

        private void SaveChungTuInstance()
        {
            //update header
            UpdateChungTuHeader();
            //update thanh toan
            UpdateChungTuThanhToan();
            //update detail
            UpdateChungTuDetails();
        }

        private void UpdateChungTuHeader()
        {
            Business.ChungTu.NgayLap = mstNgayLapPhieu.Value;
            Business.ChungTu.NgayHoaDon = Convert.ToDateTime(dteNgayHoaDon.DateTime);
            if (bteTrungTam.Tag != null)
                Business.ChungTu.IdTrungTam = ((DMTrungTamInfor) bteTrungTam.Tag).IdTrungTam;

            if (bteKhoXuat.Tag != null)
                Business.ChungTu.IdKho = ((DMKhoInfo) bteKhoXuat.Tag).IdKho;

            if (!chkDraft.Checked)
                Business.ChungTu.Draft = Common.Bool2Int(chkDraft.Checked);

            Business.ChungTu.IdNhanVien = ((DMNhanVienInfo) bteThuongVien.Tag).IdNhanVien;            
            if (Business.ChungTu.SoSeri == null || !Business.ChungTu.SoSeri.Equals(txtSoSerie.Text.Trim()))
            {
                Business.ChungTu.QuyenSo = chkHDNhay.Checked ? -1 : Common.IntValue(cboQuyen.SelectedValue);
                Business.ChungTu.SoSeri = txtSoSerie.Text;
                Business.ChungTu.KyHieu = chkHDNhay.Checked ? "KXD" : cboQuyen.Text;
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
            //Business.ChungTu.IdLyDoGiaoDich = Common.Bool2Int(chkTraLaiNCC.Checked);
            Business.ChungTu.CongTy = txtCongTy.Text;
            Business.ChungTu.HoTen = txtHoTenKhachHang.Text;
            Business.ChungTu.DoTuoi = Common.IntValue(txtTuoi.Text);
            Business.ChungTu.GioiTinh = cboGioiTinh.SelectedIndex;
            Business.ChungTu.DiaChi = txtDiaChi.Text;
            Business.ChungTu.DienThoai = txtDienThoai.Text;
            Business.ChungTu.MaSoThue = txtMaSoThue.Text;
            //Business.ChungTu.SoTaiKhoan = txtSoTaiKhoan.Text;
            //Business.ChungTu.NganHang = txtNganHang.Text;
            //Business.ChungTu.OrderType = Declare.OrderTypeBan;//hang ban Common.IntValue(cboOrderType.SelectedValue);
            Business.ChungTu.BillTo = 0;// Common.IntValue(cboBillTo.SelectedValue);
            Business.ChungTu.ShipTo = 0;// Common.IntValue(cboShipTo.SelectedValue);
            Business.ChungTu.TongTienHang = Common.DoubleValue(txtTongTienHang.Text);
            Business.ChungTu.TongTienChietKhau = Common.DoubleValue(txtTongTienCK.Text);
            Business.ChungTu.TongTienSauChietKhau = Common.DoubleValue(txtTongTienSauCK.Text);
            Business.ChungTu.TongTienVAT = Common.DoubleValue(txtTongTienVAT.Text);
            Business.ChungTu.TongTienThanhToan = Common.DoubleValue(txtTongTienThanhToan.Text);
            Business.ChungTu.IdTienTe = Declare.IdTienTe;
            Business.ChungTu.TienThanhToanThuc = Common.DoubleValue(txtTienThucTra.Text);
            Business.ChungTu.TienConNo = Common.DoubleValue(txtTienConNo.Text);
            Business.ChungTu.TongTienChu = Common.ReadNumner_(txtTongTienThanhToan.Text.Trim());
            Business.ChungTu.HinhThucTra = bteThoiHanThanhToan.Tag != null ? ((DMLoaiThuChiInfor) bteThoiHanThanhToan.Tag).IdThuChi : 0;
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
            Business.ChungTu.IdTinhHD = Common.IntValue(cboTinhHD.SelectedValue);
            Business.ChungTu.IdHuyenHD = Common.IntValue(cboHuyenHD.SelectedValue);
            Business.ChungTu.DiaChiHD = txtDiaChiHD.Text;
            Business.ChungTu.DiaChiHoaDon = txtDiaChiHD.Text +
                                            (cboHuyenHD.SelectedIndex != -1 ? ", " + cboHuyenHD.Text : "") +
                                            (cboTinhHD.SelectedIndex != -1 ? ", " + cboTinhHD.Text : "") +
                                            (cboQuocGia.SelectedIndex > 0 ? ", " + cboQuocGia.Text : "");
            Business.ChungTu.IdTinhGH = Common.IntValue(cboTinh.SelectedValue);
            Business.ChungTu.IdHuyenGH = Common.IntValue(cboHuyen.SelectedValue);
            Business.ChungTu.DiaChiGH = txtDiaChi.Text;
            Business.ChungTu.DiaChiGiaoHang = txtDiaChi.Text +
                                            (cboHuyen.SelectedIndex != -1 ? ", " + cboHuyen.Text : "") +
                                            (cboTinh.SelectedIndex != -1 ? ", " + cboTinh.Text : "");
            Business.ChungTu.SoHDDaMua = txtSoHDDaMua.Text;
            Business.ChungTu.IdNgheNghiep = Common.IntValue(cboNgheNghiep.SelectedValue);

            //if (Business.ChungTu.IdChungTu == 0)
            //{
            //    Business.ChungTu.NguoiTao = nguoiDung.TenDangNhap;
            //    Business.ChungTu.TenMayTao = Declare.TenMay;
            //    Business.ChungTu.NguoiSua = nguoiDung.TenDangNhap;
            //    Business.ChungTu.TenMaySua = Declare.TenMay;
            //}
            //else
            //{
            //    Business.ChungTu.NguoiSua = nguoiDung.TenDangNhap;
            //    Business.ChungTu.TenMaySua = Declare.TenMay;
            //}
        }

        private void UpdateChungTuThanhToan()
        {
            //Business.ListChungTuThanhToan =
            //    ThanhToanDataProvider.Instance.ConvertListPair2Full(liChungTuThanhToanChiTiet);
            int count = 0;
            foreach (ChungTuThanhToanInfor tt in Business.ListChungTuThanhToan)
            {
                //if (tt.IdThanhToan == 0 || String.IsNullOrEmpty(tt.SoPhieu))
                //{
                //    tt.SoPhieu = CommonFuns.Instance.GetSoPhieuThuChi(Business.ChungTu.SoChungTu,
                //                                                      Declare.Prefix.PhieuThanhToan, count);
                //    count++;
                //}
                    
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
        }
        private void UpdateChungTuDetails()
        {
            if (Business.ChungTu.IdChungTu == 0 && Business.ListChiTietChungTu != null)
            {
                foreach (ChungTuBanHangChiTietInfor ct in Business.ListChiTietChungTu)
                {
                    ct.IdChungTu = 0;
                }
            }
            //BanHangDataProvider.Instance.MergeListBanKMai2ChiTiet(ref Business.ListChiTietChungTu, liChungTuBanHangChiTiet, liChungTuKhuyenMaiChiTiet);
            //Business.ListChiTietChungTu = liChungTuBanHangChiTiet;
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
                        MessageBox.Show("Chưa có đơn hàng bán. Không thể in hóa đơn được");
                        return;                        
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
            ChonCaLamViec();
            //if (gvSanPhamBan.RowCount == 0 || MessageBox.Show("Dữ liệu đang nhập, nếu chuyển thông tin thì dữ liệu đã nhập sẽ bị xóa\nBạn có đồng ý đổi thông tin hay không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    if (ChonCaLamViec())
            //        ResetData();
            //}
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

        private void cboQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboQuyen.SelectedIndex >=0) chkHDNhay.Checked = false;
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
                    Business = new BanHangBusiness(ctu);
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
                int loaiPhieu = (int) LoaiPhieuThanhToan.PHIEU_THU;
                if (Business.ChungTu.LoaiChungTu == 33 || Business.ChungTu.LoaiChungTu == 34 ||
                    Business.ChungTu.LoaiChungTu == 42 || Business.ChungTu.LoaiChungTu == 50)
                    loaiPhieu = (int) LoaiPhieuThanhToan.PHIEU_CHI;

                frmBH_ChonHinhThucTT frm = new frmBH_ChonHinhThucTT(Business.ListChungTuThanhToan,
                                                                    Business.ChungTu.SoChungTu,
                                                                    Common.DoubleValue(txtTongTienThanhToan.Text),
                                                                    Common.DoubleValue(txtTienThucTra.Text),
                                                                    Declare.KyHieuTienTe,
                                                                    nguoiDung.IdNhanVien,
                                                                    _IdTrungTam, loaiPhieu,
                                                                    (int) LoaiGiaoDichThanhToan.GIAODICH_BANHANG);
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
                    //foreach (int i in gvHinhThucThanhToan.GetSelectedRows())
                    //{
                    //    ChungTuThanhToanInfor t = (ChungTuThanhToanInfor)gvHinhThucThanhToan.GetRow(i);
                    //    if (t != null && t.IdThanhToan > 0 && nguoiDung.SupperUser != 1 && Draft == 0)
                    //    {
                    //        MessageBox.Show("Phiếu thu này đã được tạo. Không thể xóa được!");
                    //        return;
                    //    }
                    //}
                    gvHinhThucThanhToan.DeleteSelectedRows();
                    double tienThanhToan = 0;
                    foreach (ChungTuThanhToanInfor tt in (BindingList<ChungTuThanhToanInfor>)gHinhThucThanhToan.DataSource)
                    {
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
                _IdTrungTam = frm.TTamSelected.IdTrungTam;
                _IdLoaiKhachHang = frm.LoaiDTSelected.IdLoaiDT;
                _IdKhachHang = frm.KHangSelected.IdDoiTuong;
                _IdTruongCa = frm.TruongCaSelected.IdNhanVien;
                _IdThuNgan = frm.ThuNganSelected.IdNhanVien;
                _IdThoiHanThanhToan = frm.ThoiHanTTSelected.IdThuChi;

                grThongTin.Text = String.Format("Trung tâm: {0} - {1}", frm.TTamSelected.MaTrungTam, frm.TTamSelected.TenTrungTam);

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
                    if (String.IsNullOrEmpty(Business.ChungTu.SoSeri))
                        CommonProvider.Instance.Lock_Unlock_ChungTu(Business.ChungTu.IdChungTu, 0);//mo chung tu                    
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

        private void cboTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDMHuyen();
        }

        private void cboHuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //if (Common.IntValue(cboTinhHD.SelectedValue) == Common.IntValue(cboTinh.SelectedValue))
                //    cboHuyen.SelectedValue = cboHuyenHD.SelectedValue;
            }
            catch 
            {
            }
        }

        private void cboTinhHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadDMHuyenHD();
                //cboTinh.SelectedValue = cboTinhHD.SelectedValue;
            }
            catch
            {
            }
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

            //ctu.ThanhTien = ctu.SoLuong * ctu.ThanhTien / ctu.SoLuongOld;
            //ctu.TienVAT = ctu.ThanhTien * ctu.TyleVAT / TyLe / (1 + ctu.TyleVAT / TyLe);
            //ctu.TienSauChietKhau = ctu.ThanhTien / (1 + ctu.TyleVAT / TyLe);

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
                    if (ct.IdSanPhamBan == ctu.IdSanPham && (ct.LoaiHangKem == 0 || ct.LoaiHangKem == -1))
                    {
                        ct.SoLuong = ctu.SoLuongOld != 0 ? ctu.SoLuong*ct.SoLuong/ctu.SoLuongOld : 0;
                        //if (ct.ChietKhau != 1)
                        //{
                        //    ct.NoKhuyenMai = ct.TonKho > ct.SoLuong ? 0 : ct.SoLuong - ct.TonKho;
                        //}
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
            UtilFunctions.bteItem_TextChanged(sender, e, bteKhoXuat);
            //if (UtilFunctions.bteItem_TextChanged(sender, e, bteKhoXuat))
            //{
            //    if (gvSanPhamBan.RowCount > 0)
            //    {
            //        if (MessageBox.Show("Dữ liệu đang nhập, nếu chuyển thông tin thì dữ liệu đã nhập sẽ bị xóa\nBạn có đồng ý đổi thông tin hay không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //        {
            //            ResetData();
            //        }
            //        else
            //        {
            //            LoadKhoXuat();
            //        }
            //    }
            //}
        }

        private void bteKhoXuat_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteKhoXuat_KeyDown(sender, e, bteKhoXuat, -1, nguoiDung.IdNhanVien);
            //if (UtilFunctions.bteKhoXuat_KeyDown(sender, e, bteKhoXuat, -1, nguoiDung.IdNhanVien))
            //{
            //    if (gvSanPhamBan.RowCount > 0)
            //    {
            //        if (MessageBox.Show("Dữ liệu đang nhập, nếu chuyển thông tin thì dữ liệu đã nhập sẽ bị xóa\nBạn có đồng ý đổi thông tin hay không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //        {
            //            ResetData();
            //        }
            //        else
            //        {
            //            LoadKhoXuat();
            //        }
            //    }
            //}
        }

        private void bteKhoXuat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteKhoXuat_ButtonClick(sender, e, bteKhoXuat, -1, nguoiDung.IdNhanVien);
            //if (UtilFunctions.bteKhoXuat_ButtonClick(sender, e, bteKhoXuat, -1, nguoiDung.IdNhanVien))
            //{
            //    if (gvSanPhamBan.RowCount > 0)
            //    {
            //        if (MessageBox.Show("Dữ liệu đang nhập, nếu chuyển thông tin thì dữ liệu đã nhập sẽ bị xóa\nBạn có đồng ý đổi thông tin hay không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //        {
            //            ResetData();
            //        }
            //        else
            //        {
            //            LoadKhoXuat();
            //        }
            //    }
            //}
        }

        private void bteKhachHang_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteKhachHang_ButtonClick(sender, e, bteKhachHang, Common.IntValue(cboCurrentLoaiDT.SelectedValue));
        }

        private void bteKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteKhachHang_KeyDown(sender, e, bteKhachHang, Common.IntValue(cboCurrentLoaiDT.SelectedValue));
        }

        private void bteKhachHang_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteKhachHang);
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
                if (gvSanPhamBan.FocusedColumn.FieldName == "SoLuong")
                {
                    ChungTuBanHangChiTietInfor ct = (ChungTuBanHangChiTietInfor)gvSanPhamBan.GetRow(gvSanPhamBan.FocusedRowHandle);
                    if (ct == null || ct.ChietKhau != 1)
                        e.Cancel = true;
                }
                if (gvSanPhamBan.FocusedColumn.FieldName == "DonGia" || gvSanPhamBan.FocusedColumn.FieldName == "TienChietKhau" ||
                    gvSanPhamBan.FocusedColumn.FieldName == "TyLeChietKhau" || gvSanPhamBan.FocusedColumn.FieldName == "TyLeVAT" || gvSanPhamBan.FocusedColumn.FieldName == "ThanhTien")
                {
                    if (nguoiDung == null || nguoiDung.SupperUser == 0)
                        e.Cancel = true;
                }
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

        private void bteTrungTam_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteTrungTam_ButtonClick(sender, e, bteTrungTam, -1);
        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            if (Business.ChungTu.TrangThai == 1 || Business.ChungTu.TrangThai == 3 || Business.ChungTu.TrangThai == 5)
            {
                try
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng hàng này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        foreach (int i in gvSanPhamBan.GetSelectedRows())
                        {
                            ChungTuBanHangChiTietInfor ctu = (ChungTuBanHangChiTietInfor)gvSanPhamBan.GetRow(i);
                            if ((ctu.LoaiHangKem == 1 || ctu.IdSanPhamBan > 0 && ctu.LoaiHangKem == 0 && ctu.ThanhTien == 0) && nguoiDung.SupperUser != 1)
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
                                            spb.TienVAT = spb.ThanhTien * spb.TyleVAT / TyLe / (1 + spb.TyleVAT / TyLe);
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
                        if (gvSanPhamBan.RowCount == 0 && Business.ChungTu.TrangThai != (int)TransactionType.DON_HANG_DAT_TRUOC)
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
            else
            {
                ChungTuBanHangChiTietInfor ctu = (ChungTuBanHangChiTietInfor)gvSanPhamBan.GetRow(gvSanPhamBan.FocusedRowHandle);
                if (ctu != null && ctu.SoLuong > 0 && ctu.ChietKhau == 0)
                {
                    MessageBox.Show("Đơn hàng đã được xác nhận tính tồn. Không thể xóa sản phẩm được!");
                }
                else if (ctu != null && (ctu.SoLuong == 0 || ctu.ChietKhau == 1))
                {
                    gvSanPhamBan.DeleteRow(gvSanPhamBan.FocusedRowHandle);
                    UpdateSummariesInfors();
                }
            }
        }

        private void btnChietKhau_Click(object sender, EventArgs e)
        {
            //if (Business.ChungTu.TrangThai >= 11)
            //{
            //    MessageBox.Show("Đơn hàng đã xuất kho. Không thể đổi được!");
            //    return;
            //}
            if (gvSanPhamBan.FocusedRowHandle < 0) return;

            ChungTuBanHangChiTietInfor ctu = (ChungTuBanHangChiTietInfor)gvSanPhamBan.GetRow(gvSanPhamBan.FocusedRowHandle);
            if (ctu.IdSanPhamBan != 0 && ctu.SoLuong == 0 && ctu.NoKhuyenMai > 0)
            {
                frmBH_SuaDonHangBan_DoiKM frm = new frmBH_SuaDonHangBan_DoiKM(Business.ChungTu.IdKho, Business.ChungTu.IdTrungTam, ctu.NoKhuyenMai);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ctu.IdSanPham = frm.SanPhamDoi.IdSanPham;
                    ctu.MaSanPham = frm.SanPhamDoi.MaSanPham;
                    ctu.TenSanPham = frm.SanPhamDoi.TenSanPham;
                    ctu.DonViTinh = frm.SanPhamDoi.TenDonViTinh;
                    ctu.NoKhuyenMai = frm.NoKhuyenMai;
                    //ctu.SoLuong = frm.SanPhamDoi.TonAo > ctu.NoKhuyenMai ? ctu.NoKhuyenMai : 0;
                    //ctu.NoKhuyenMai = frm.SanPhamDoi.TonAo > ctu.NoKhuyenMai ? 0 : ctu.NoKhuyenMai;
                    //ctu.GhiChu = frm.SanPhamDoi.TonAo > ctu.NoKhuyenMai ? "Có hàng" : "Nợ khuyến mại";
                    ((BindingList<ChungTuBanHangChiTietInfor>)gSanPhamBan.DataSource).ResetBindings();
                }
            }
            else
            {
                MessageBox.Show("Đây không phải sản phẩm nợ khuyến mại. Không thể đổi được!");
            }
        }

        private void btnSuaTToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvHinhThucThanhToan.FocusedRowHandle < 0) return;
                ChungTuThanhToanInfor t = (ChungTuThanhToanInfor)gvHinhThucThanhToan.GetRow(gvHinhThucThanhToan.FocusedRowHandle);
                if (t != null)
                {
                    frmBH_ChonHinhThucTT frm = new frmBH_ChonHinhThucTT(t,
                                                                        Common.DoubleValue(txtTongTienThanhToan.Text),
                                                                        Common.DoubleValue(txtTienThucTra.Text),
                                                                        Declare.KyHieuTienTe);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        ((BindingList<ChungTuThanhToanInfor>) gHinhThucThanhToan.DataSource).ResetBindings();
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

        private void txtTongTienThanhToan_TextChanged(object sender, EventArgs e)
        {
            txtTienThucTra_TextChanged(sender, e);
        }

        private void txtTongTienThanhToan_Leave(object sender, EventArgs e)
        {
            this.txtTongTienThanhToan.Text = Common.Double2Str(Common.DoubleValue(this.txtTongTienThanhToan.Text.Trim()));
        }

        private void btnThemKM_Click(object sender, EventArgs e)
        {
            frmBH_SuaDonHangBan_DoiKM frm = new frmBH_SuaDonHangBan_DoiKM(Business.ChungTu.IdKho, Business.ChungTu.IdTrungTam, 0);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ChungTuBanHangChiTietInfor ctu = BanHangDataProvider.Instance.ConvertBG2SanPhamKM(frm.SanPhamDoi);
                ctu.NoKhuyenMai = frm.NoKhuyenMai;
                ctu.SoLuong = 0;
                ((BindingList<ChungTuBanHangChiTietInfor>)gSanPhamBan.DataSource).Add(ctu);
                ((BindingList<ChungTuBanHangChiTietInfor>)gSanPhamBan.DataSource).ResetBindings();
            }
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            InputDataFromCode(txtMaSanPham.Text.Trim());
        }

        private void InputDataFromCode(string code)
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
                                                                       : nguoiDung.IdNhomNguoiDung), 1, 1,
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
                else if (spb.DonGiaCoVAT == 0 && nguoiDung.SupperUser != 1)
                {
                    MessageBox.Show("Hàng khuyến mại không được phép bán!");
                    return;
                }
                else if (spb.ChietKhau != 1)
                {
                    MessageBox.Show("Chỉ thêm được mã không tính tồn!");
                    return;
                }

                ChungTuBanHangChiTietInfor ctu =
                    Business.ListChiTietChungTu.Find(delegate(ChungTuBanHangChiTietInfor match)
                    { return match.MaSanPham == spb.MaSanPham && match.IdSanPhamBan == 0; });
                if (ctu != null)
                {
                    ctu.DonGia = (ctu.DonGia * ctu.SoLuong + spb.DonGiaChuaVAT) / (ctu.SoLuong + 1);
                    ctu.SoLuong += 1;
                    UpdateValueChiTiet(ctu);
                    ((BindingList<ChungTuBanHangChiTietInfor>)gSanPhamBan.DataSource).ResetBindings();
                }
                else
                {
                    //add san pham ban
                    ChungTuBanHangChiTietInfor ct = BanHangDataProvider.Instance.ConvertBG2SanPhamBan(spb);
                    ct.IdChungTu = Business.ChungTu.IdChungTu;
                    ((BindingList<ChungTuBanHangChiTietInfor>)gSanPhamBan.DataSource).Add(ct);
                    ((BindingList<ChungTuBanHangChiTietInfor>)gSanPhamBan.DataSource).ResetBindings();
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

        private void tsbChinhSachGia_Click(object sender, EventArgs e)
        {
            CommonFuns.Instance.ShowChinhSachKM(gvSanPhamBan);
        }

        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvHinhThucThanhToan.FocusedRowHandle < 0) return;
                ChungTuThanhToanInfor t = (ChungTuThanhToanInfor)gvHinhThucThanhToan.GetRow(gvHinhThucThanhToan.FocusedRowHandle);
                if (t != null)
                {
                    ChungTuThanhToanInfor tt = new ChungTuThanhToanInfor(t);
                    tt.IdThanhToan = 0;
                    tt.SoTienThanhToan = 0;
                    tt.SoTienChu = "";
                    ((BindingList<ChungTuThanhToanInfor>)gHinhThucThanhToan.DataSource).Add(tt);
                    //txtTienThucTra.Text = Common.Double2Str(Common.DoubleValue(txtTienThucTra.Text) + tt.SoTienThanhToan);
                    //txtTienConNo.Text = Common.Double2Str(Common.DoubleValue(txtTongTienThanhToan.Text) - Common.DoubleValue(txtTienThucTra.Text));
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

        private void cboGiaoHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            mstNgayHenGiaoHang.Enabled = (cboGiaoHang.SelectedIndex > 0 ? true : false);
        }

        private void chkHDNhay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHDNhay.Checked)
                cboQuyen.SelectedIndex = -1;
        }
    }
}