using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBanHang.Modules.BanHang.Bussiness;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.BanHang;
using QLBanHang.Modules.BanHang.Reports;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.DongBoERP.Providers;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.TheThanhVien.Providers;
using QLBH.Common;
using QLBH.Common.Providers;
using QLBH.Core.Data;
using QLBH.Core.Providers;
using QLBH.Core.Exceptions;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBH_SuaDonHangTraLai : DevExpress.XtraEditors.XtraForm
    {
        #region Declare
        private int Draft = -1;
        private bool Updating = false;
        private int LoaiChungTu = (int)TransactionType.TRA_LAI_DON_HANG_BAN;
        private int TrangThai = (int)OrderStatus.TRA_LAI_DON_HANG_BAN;
        //private List<NhapHangTraMuaInfor> lst = new List<NhapHangTraMuaInfor>();
        //private List<NhapHangTraChiTietHHInfor> lstnt = new List<NhapHangTraChiTietHHInfor>();
        private LapDonHangTraLaiBussiness Business;
        protected NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int _IdKho = Declare.IdKho;
        private int _IdTrungTam = Declare.IdTrungTam;
        private int _IdTrungTamHachToan = Declare.IdTrungTamHachToan;
        bool traTruoc = false;

        #endregion
        public frmBH_SuaDonHangTraLai()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.Business = new LapDonHangTraLaiBussiness(LoaiChungTu, nguoiDung.IdNhanVien, _IdKho);
        }

        #region Actions
        private void setEDFunctions()
        {
            tsbEdit.Enabled = !Updating;// && Draft != 0;
            tsbConfirm.Enabled = Updating;
            tsbPrint.Enabled = !Updating;

            btnThanhToan.Enabled = false;
            btnXoaTT.Enabled = false;

            bteKhoXuat.Enabled = false;
            txtSoPhieuNhap.Enabled = true;
            btnSearchPhieuNhap.Enabled = true;
            txtGhiChu.Enabled = Updating;
            lueLyDo.Enabled = Updating;
            dteNgayNhap.Enabled = false;
        }

        private void ResetAllText()
        {
            clsUtils.ResetAllText(this);
            Business = new LapDonHangTraLaiBussiness();
            //lst.Clear();
            //lstnt.Clear();
            //LoadKho();
        }

        private void LoadGioiTinh()
        {
            cboGioiTinh.Properties.Items.Add("Nữ");
            cboGioiTinh.Properties.Items.Add("Nam");
        }

        //private void LoadKho()
        //{
        //    DMKhoInfo dmKho = DMKhoDataProvider.GetKhoByIdInfo(_IdKho);
        //    if (dmKho != null)
        //    {
        //        bteKhoXuat.Text = dmKho.TenKho;
        //        bteKhoXuat.Tag = dmKho;
        //    }
        //}

        private void LoadLyDo()
        {
            lueLyDo.Properties.DataSource = DMLyDoTraHangDataProvider.Instance.GetListLyDoTraHangInfo();
        }

        private void LoadOldChungTuInfor(ChungTuBanHangInfor lstHD)
        {
            grbChungTuMua.Text = "Thông tin phiếu mua hàng: " +
                     (String.IsNullOrEmpty(lstHD.TenTrungTam)
                          ? ""
                          : (lstHD.TenTrungTam + (String.IsNullOrEmpty(lstHD.TenKho) ? "" : "(" + lstHD.TenKho + ")")));
            _IdTrungTam = lstHD.IdTrungTam;
            bteKhoXuat.Tag = DMKhoDataProvider.GetKhoByIdInfo(Business.ChungTu.IdKho);
            bteKhoXuat.Text = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).TenKho : "";
            txtSoGiaoDich.Text = lstHD.SoChungTu;
            txtSoPhieuXuat.Text = lstHD.SoPhieuXuat;
            dteNgayLap.EditValue = lstHD.NgayLap;
            dteNgayXuat.EditValue = lstHD.NgayXuatHang;
            txtKiHieu.Text = lstHD.KyHieu;
            txtSoHoaDon.Text = lstHD.SoSeri;
            txtTenDoiTuong.Text = lstHD.HoTen;
            txtCongTy.Text = lstHD.CongTy;
            cboGioiTinh.SelectedIndex = lstHD.GioiTinh;
            txtCMND.Text = lstHD.SoCMND;
            txtSoDienThoai.Text = lstHD.MaSoThue;
            txtEmail.Text = lstHD.Email;
            txtDiaChiHD.Text = lstHD.DiaChiHoaDon;
            txtDiaChiGH.Text = lstHD.DiaChiGiaoHang;

            if (lstHD.IdNhanVien != 0)
            {
                DMNhanVienInfo thuongvien = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(lstHD.IdNhanVien);
                if (thuongvien != null)
                {
                    bteThuongVien.Tag = thuongvien;
                    bteThuongVien.Text = thuongvien.HoTen;
                }
            }

            if (lstHD.IdDoiTuong != 0)
            {
                DMDoiTuongInfo doituong = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(lstHD.IdDoiTuong);
                if (doituong != null)
                {
                    txtKhachHang.Tag = doituong;
                    txtKhachHang.Text = doituong.TenDoiTuong;
                }
            }
            if (lstHD.IdKhachLe != 0)
            {
                DMDoiTuongInfo khachle = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(lstHD.IdKhachLe);
                if (khachle != null)
                {
                    bteKhachLe.Tag = khachle;
                    bteKhachLe.Text = khachle.TenDoiTuong;
                }
            }

            txtTongTienTT.Text = Common.Double2Str(lstHD.TongTienThanhToan);
            txtTienThucTra.Text = Common.Double2Str(lstHD.TienThanhToanThuc);
            txtTienConNo.Text = Common.Double2Str(lstHD.TienConNo);
        }

        private void LoadChungTuHeader()
        {
            Draft = Business.ChungTu.Draft;
            TrangThai = Business.ChungTu.TrangThai;

            _IdTrungTam = Business.ChungTu.IdTrungTam;

            bteKhoXuat.Tag = DMKhoDataProvider.GetKhoByIdInfo(Business.ChungTu.IdKho);
            bteKhoXuat.Text = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).TenKho : "";

            txtSoPhieuNhap.Text = Business.ChungTu.SoChungTu;
            txtGhiChu.Text = Business.ChungTu.GhiChu;

            try
            {
                dteNgayNhap.EditValue = Business.ChungTu.NgayLap;
            }
            catch (Exception)
            {
                dteNgayNhap.EditValue = CommonProvider.Instance.GetSysDate();
            }

            lueLyDo.EditValue = Business.ChungTu.IdLyDoGiaoDich;

            grbChungTuMua.Text = "Thông tin phiếu mua hàng: " +
                     (String.IsNullOrEmpty(Business.ChungTu.TenTrungTam)
                          ? ""
                          : (Business.ChungTu.TenTrungTam + (String.IsNullOrEmpty(Business.ChungTu.TenKho) ? "" : "(" + Business.ChungTu.TenKho + ")")));
            txtSoGiaoDich.Text = Business.ChungTu.SoChungTuGoc;
            txtSoPhieuXuat.Text = Business.ChungTu.SoPhieuXuat;
            dteNgayLap.EditValue = Business.ChungTu.NgayLap;
            dteNgayXuat.EditValue = Business.ChungTu.NgayXuatHang;
            //cboCaBanHang.SelectedIndex = Business.ChungTu.CaBanHang;
            txtKiHieu.Text = Business.ChungTu.KyHieu;
            txtSoHoaDon.Text = Business.ChungTu.SoSeri;
            txtTenDoiTuong.Text = Business.ChungTu.HoTen;
            txtCongTy.Text = Business.ChungTu.CongTy;
            cboGioiTinh.SelectedIndex = Business.ChungTu.GioiTinh;
            txtCMND.Text = Business.ChungTu.SoCMND;
            txtSoDienThoai.Text = Business.ChungTu.DienThoai;
            txtEmail.Text = Business.ChungTu.Email;
            txtDiaChiHD.Text = Business.ChungTu.DiaChiHoaDon;
            txtDiaChiGH.Text = Business.ChungTu.DiaChiGiaoHang;
            if (Business.ChungTu.IdNhanVien != 0)
            {
                DMNhanVienInfo nhanvien = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(Business.ChungTu.IdNhanVien);
                if (nhanvien != null)
                {
                    bteThuongVien.Tag = nhanvien;
                    bteThuongVien.Text = nhanvien.HoTen;
                }
            }
            if (Business.ChungTu.IdDoiTuong != 0)
            {
                DMDoiTuongInfo doituong = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(Business.ChungTu.IdDoiTuong);
                if (doituong != null)
                {
                    txtKhachHang.Tag = doituong;
                    txtKhachHang.Text = doituong.TenDoiTuong;
                }
            }

            if (Business.ChungTu.IdKhachLe != 0)
            {
                DMDoiTuongInfo khachle = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(Business.ChungTu.IdKhachLe);
                if (khachle != null)
                {
                    bteKhachLe.Tag = khachle;
                    bteKhachLe.Text = khachle.TenDoiTuong;
                }
            }
            txtTongTienTT.Text = Common.Double2Str(Business.ChungTu.TongTienHang);
            txtTienThucTra.Text = Common.Double2Str(Business.ChungTu.TongTienThanhToan);
            txtTienConNo.Text = Common.Double2Str(Business.ChungTu.TongTienHang - Business.ChungTu.TongTienThanhToan);

            txtTienTraKhach.Text = Common.Double2Str(Business.ChungTu.TienThanhToanThuc);
            txtTienNoKhach.Text = Common.Double2Str(Business.ChungTu.TienConNo);
        }

        private void LoadChungTuInstance()
        {
            if (Business.ChungTu.IdChungTu != 0)
            {
                LoadChungTuHeader();
                LoadChiTietHangBan();
                LoadChiTietThanhToan();
            }
            else
            {
                ResetAllText();
            }
        }

        //loai chi tiết hàng bán(hàng nhập lại)
        private void LoadChiTietHangBan()
        {
            Business.ListChiTietChungTu =
            BanHangDataProvider.Instance.GetListChiTietChungTuByIdChungTu(Business.ChungTu.IdChungTu);

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

            gSanPhamBan.DataSource = null;
            gSanPhamBan.DataSource = new BindingList<ChungTuBanHangChiTietInfor>(Business.ListChiTietChungTu);
        }

        private void LoadChiTietThanhToan()
        {
            Business.ListChungTuThanhToan =
                ThanhToanDataProvider.Instance.LoadAllThanhToanByCTu(Business.ChungTu.IdChungTu);
            gHinhThucThanhToan.DataSource = null;
            gHinhThucThanhToan.DataSource = new BindingList<ChungTuThanhToanInfor>(Business.ListChungTuThanhToan);
        }

        // save kế toán xác nhận trả lại, trừ tồn thật
        private void UpdateChungTu()
        {
            //cap nhat thong tin chungtu
            UpdateChungTuInfor();
            //cap nhat thong tin thanh toan
            UpdateChungTuThanhToan();
            //cap nhat du lieu
            Business.SaveDonHangTraLai();

        }
        private void UpdateChungTuInfor()
        {
            Business.ChungTu.Draft = Draft;
            Business.ChungTu.LoaiChungTu = LoaiChungTu;
            if (Business.ChungTu.TrangThai == (int)OrderStatus.TAO_DON_HANG_ONLINE)                
                Business.ChungTu.TrangThai = (int)OrderStatus.TRA_LAI_DON_HANG_ONLINE;
            else if (Business.ChungTu.TrangThai == (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC)
                Business.ChungTu.TrangThai = (int) OrderStatus.TRA_LAI_DON_HANG_DAT_TRUOC;
            else
                Business.ChungTu.TrangThai = (int)OrderStatus.TRA_LAI_DON_HANG_BAN;
            Business.ChungTu.IdLyDoGiaoDich = Common.IntValue(lueLyDo.EditValue);
            Business.ChungTu.OrderType = Declare.OrderTypeTraLai;
            Business.ChungTu.GhiChu = txtGhiChu.Text;

            Business.ChungTu.SoChungTu = txtSoPhieuNhap.Text.Trim().ToUpper();
            Business.ChungTu.SoChungTuGoc = txtSoGiaoDich.Text.Trim().ToUpper();

            Business.ChungTu.SoSeri = txtSoHoaDon.Text.Trim();
            Business.ChungTu.KyHieu = txtKiHieu.Text.Trim();
            Business.ChungTu.IdDoiTuong = ((DMDoiTuongInfo)txtKhachHang.Tag).IdDoiTuong;
            Business.ChungTu.NgayHenGiaoHang = Convert.ToDateTime(dteNgayLap.EditValue);
            Business.ChungTu.NgayGiaoHang = Convert.ToDateTime(dteNgayXuat.EditValue);

            Business.ChungTu.CongTy = txtCongTy.Text;
            Business.ChungTu.HoTen = txtTenDoiTuong.Text;
            Business.ChungTu.GioiTinh = cboGioiTinh.SelectedIndex;
            Business.ChungTu.DiaChiHoaDon = txtDiaChiHD.Text;
            Business.ChungTu.DiaChiGiaoHang = txtDiaChiGH.Text;
            Business.ChungTu.DienThoai = txtSoDienThoai.Text;
            Business.ChungTu.SoCMND = txtCMND.Text;
            Business.ChungTu.Email = txtEmail.Text;
            Business.ChungTu.IdNhanVien = (bteThuongVien.Tag != null
                                               ? ((DMNhanVienInfo)bteThuongVien.Tag).IdNhanVien
                                               : 0);

            Business.ChungTu.TongTienHang = Common.DoubleValue(txtTongTienTT.Text);
            Business.ChungTu.TongTienChietKhau = 0;
            Business.ChungTu.TongTienSauChietKhau = Business.ChungTu.TongTienHang;
            Business.ChungTu.TongTienVAT = 0;
            Business.ChungTu.TongTienThanhToan = Common.DoubleValue(txtTienThucTra.Text);
            Business.ChungTu.TienThanhToanThuc = Common.DoubleValue(txtTienTraKhach.Text);
            Business.ChungTu.TienConNo = Common.DoubleValue(txtTienNoKhach.Text);

            if (Business.ChungTu.IdChungTu == 0 && Business.ListChiTietChungTu != null)
            {
                foreach (ChungTuBanHangChiTietInfor ct in Business.ListChiTietChungTu)
                {
                    ct.IdChungTu = 0;
                }
            }

            if (Business.ChungTu.IdChungTu == 0)
            {
                Business.ChungTu.NguoiTao = nguoiDung.TenDangNhap;
                Business.ChungTu.TenMayTao = Declare.TenMay;
                Business.ChungTu.NguoiSua = nguoiDung.TenDangNhap;
                Business.ChungTu.TenMaySua = Declare.TenMay;
                Business.ChungTu.NgayLap = CommonProvider.Instance.GetSysDate();
            }
            else
            {
                Business.ChungTu.NguoiSua = nguoiDung.TenDangNhap;
                Business.ChungTu.TenMaySua = Declare.TenMay;
            }
        }

        private void UpdateChungTuThanhToan()
        {
            int count = 0;
            foreach (ChungTuThanhToanInfor tt in Business.ListChungTuThanhToan)
            {
                if (tt.IdThanhToan == 0 || String.IsNullOrEmpty(tt.SoPhieu))
                {
                    tt.SoPhieu = CommonFuns.Instance.GetSoPhieuThuChi(Business.ChungTu.SoChungTu,
                                                                      Declare.Prefix.PhieuChiTien, count);
                    count++;
                }
                tt.HoTen = Business.ChungTu.HoTen;
                tt.DiaChi = Business.ChungTu.DiaChiHoaDon;
                tt.DienThoai = Business.ChungTu.DienThoai;
                tt.NoiDungThanhToan = "Chi tiền trả lại cho khách mua hàng";
                tt.IdTienTe = Declare.IdTienTe;
                tt.TyGia = 1;
                tt.SoTienChu = Common.ReadNumner_(Common.Double2Str(tt.SoTienThanhToan));

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
        #endregion

        #region Events
        private void frmChiTietYeuCauNhapLaiHangMua_Load(object sender, EventArgs e)
        {
            LoadLyDo();
            //LoadKho();
            //LoadCa();
            //LoadloaiHDBHang();
            LoadGioiTinh();

            if (Business.ChungTu.IdChungTu > 0)
            {
                LoadChungTuInstance();

                Updating = false;
                setEDFunctions();
            }
            else
            {
                Updating = false;
                tsbEdit.Enabled = Updating;
                tsbConfirm.Enabled = Updating;
                tsbPrint.Enabled = Updating;
            }
        }

        private void frmChiTietYeuCauNhapLaiHangMua_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void smiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void smiSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidChungTuInfor())
                {
                    ConnectionUtil.Instance.BeginTransaction();
                    Draft = 1;
                    //huy don hang chinh
                    HuyDonHangGoc();
                    //cap nhap don hang tra lai
                    UpdateChungTu();
                    ConnectionUtil.Instance.CommitTransaction();
                    Updating = false;
                    setEDFunctions();
                    clsUtils.MsgThongBao(Declare.msgUpdateSucc);
                }

                if (ctugoc != null)
                {
                    CommonProvider.Instance.Lock_Unlock_ChungTu(ctugoc.IdChungTu, 0); //mo khoa chung tu
                }
            }
            catch (Exception ex)
            {
                ConnectionUtil.Instance.RollbackTransaction();

                EventLogProvider.Instance.WriteLog(ex.ToString()
                                    + "\nUser: " + nguoiDung.TenDangNhap
                                    + "\nMay: " + Declare.TenMay,
                                    this.Name);
#if DEBUG
                clsUtils.MsgCanhBao(ex.ToString());
#else
                clsUtils.MsgCanhBao(ex.Message);
#endif
            }
        }

        private void HuyDonHangGoc()
        {
            ChungTuBanHangInfor ctugoc = BanHangDataProvider.Instance.LoadChungTuBySoChungTu(txtSoGiaoDich.Text, -2);
            bool dongbo = false;

            if (ctugoc != null)
            {
                if (ctugoc.TrangThai == (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC || ctugoc.TrangThai == (int)OrderStatus.TAO_DON_HANG_ONLINE)
                {
                    traTruoc = true;
                }
                //LapDonHangBusiness Business = new LapDonHangBusiness(ctugoc);
                if (ctugoc.TrangThai == (int)OrderStatus.TAO_DON_HANG_ONLINE || ctugoc.TrangThai == (int)OrderStatus.HUY_DON_HANG_ONLINE)
                {
                    ctugoc.TrangThai = (int)OrderStatus.HUY_DON_HANG_ONLINE;
                }
                else if (ctugoc.TrangThai == (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC || ctugoc.TrangThai == (int)OrderStatus.HUY_DON_HANG_DAT_TRUOC)
                {
                    ctugoc.TrangThai = (int)OrderStatus.HUY_DON_HANG_DAT_TRUOC;
                }
                else if (ctugoc.TrangThai != (int)OrderStatus.HUY_DON_HANG)
                {
                    if (ctugoc.TrangThai == (int)OrderStatus.XAC_NHAN_DON_HANG_ONLINE)
                    {
                        Business.ChungTu.TuHuy = 2;//danh dau don hang xac nhan online (khong phai don hang online) de ko len doanh thu
                        ctugoc.TuHuy = 2;
                    }                        
                    ctugoc.TrangThai = (int)OrderStatus.HUY_DON_HANG;
                    dongbo = true;
                }

                ctugoc.Draft = Draft;
                BanHangDataProvider.Instance.UpdateChungTu(ctugoc);
                if (dongbo)
                    ChungTuKhoSyncProvider.Instance.Insert(ctugoc.IdChungTu);
                //Business.SaveChungTu();
            }
        }

        private void smiComfim_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidChungTuInfor())
                {
                    ConnectionUtil.Instance.BeginTransaction();

                    //xac nhan don hang tra lai
                    UpdateChungTu();

                    ConnectionUtil.Instance.CommitTransaction();
                    Updating = false;
                    setEDFunctions();
                    clsUtils.MsgThongBao(Declare.msgUpdateSucc);
                }

                if (ctugoc != null)
                {
                    CommonProvider.Instance.Lock_Unlock_ChungTu(ctugoc.IdChungTu, 0); //mo khoa chung tu
                }
            }
            catch(ManagedException ex)
            {
                ConnectionUtil.Instance.RollbackTransaction();

                clsUtils.MsgCanhBao(ex.Message);
            }
            catch (Exception ex)
            {
                ConnectionUtil.Instance.RollbackTransaction();

                EventLogProvider.Instance.WriteLog(ex.ToString()
                                    + "\nUser: " + nguoiDung.TenDangNhap
                                    + "\nMay: " + Declare.TenMay,
                                    this.Name);
#if DEBUG
                clsUtils.MsgCanhBao(ex.ToString());
#else
                clsUtils.MsgCanhBao(ex.Message);
#endif
            }
        }

        private bool ValidChungTuInfor()
        {
            try
            {
                if (string.IsNullOrEmpty(txtSoGiaoDich.Text))
                {
                    MessageBox.Show("Số giao dịch gốc không được để trống!");
                    txtSoGiaoDich.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtSoPhieuNhap.Text))
                {
                    MessageBox.Show("Số phiếu nhập hàng trả lại không được để trống!");
                    txtSoPhieuNhap.Focus();
                    return false;
                }

                if (Business.ListChiTietChungTu.Count == 0)
                {
                    MessageBox.Show("Không có mặt hàng nào để trả lại!");
                    return false;
                }
                if (lueLyDo.EditValue == null)
                {
                    MessageBox.Show("Bạn chưa chọn lý do trả hàng!");
                    lueLyDo.Focus();
                    return false;
                }

                return true;
            }
            catch (ManagedException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void btnSearchPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (Updating)
                {
                    if (MessageBox.Show("Dữ liệu đang cập nhật, bạn có muốn hủy bỏ không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;
                }
                NhapHangTraMuaInfor ct =
                    NhapTraHangMuaDataProvider.Instance.SearchChungTuBanHangByPN(txtSoPhieuNhap.Text.Trim().ToUpper(),
                                                                                 (int)TransactionType.TRA_LAI_DON_HANG_BAN);
                if (ct != null)
                {
                    Business = new LapDonHangTraLaiBussiness(ct);
                    LoadChungTuInstance();

                    Updating = false;
                    setEDFunctions();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy chứng từ thích hợp!");
                    txtSoPhieuNhap.Text = Business.ChungTu.SoChungTu;
                }
            }
            catch (Exception ex)
            {
                EventLogProvider.Instance.WriteLog(ex.ToString()
                                    + "\nUser: " + nguoiDung.TenDangNhap
                                    + "\nMay: " + Declare.TenMay,
                                    this.Name);
#if DEBUG
                MessageBox.Show("Lỗi thao tác\n" + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi thao tác", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void smiThanhToan_Click(object sender, EventArgs e)
        {
            frmThanhToanNhapLai frm = new frmThanhToanNhapLai(Business.ChungTu, Business.ListChungTuThanhToan);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //them thanh toan
                foreach (ChungTuThanhToanInfor tt in frm.lstThanhToanSelected)
                {
                    ((BindingList<ChungTuThanhToanInfor>)gvHinhThucThanhToan.DataSource).Add(tt);
                }
                //cap nhat tien thanh toan
                UpdateTienThanhToan();
            }
        }
        #endregion

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
                        if (t != null && t.IdThanhToan > 0 && nguoiDung.IdNguoiDung != 1 && Draft == 0)
                        {
                            MessageBox.Show("Phiếu chi này đã được tạo. Không thể xóa được!");
                            return;
                        }
                    }

                    gvHinhThucThanhToan.DeleteSelectedRows();
                    UpdateTienThanhToan();
                }
            }
            catch { }
        }

        private void UpdateTienThanhToan()
        {
            double tienTraKhach = 0;
            foreach (ChungTuThanhToanInfor tt in (BindingList<ChungTuThanhToanInfor>)gvHinhThucThanhToan.DataSource)
            {
                if (tt.LoaiThanhToan != -1 && !tt.HinhThucThanhToan.ToUpper().Equals("VOUCHER"))
                    tienTraKhach += tt.SoTienThanhToan;
            }
            double tienConNo = Common.DoubleValue(txtTienThucTra.Text) - tienTraKhach;
            txtTienTraKhach.Text = Common.Double2Str(tienTraKhach);
            txtTienNoKhach.Text = Common.Double2Str(tienConNo);
        }

        private bool ValidEditChungTu()
        {
            //if (Business.ChungTu.IdChungTu > 0 && Business.ChungTu.Draft == 0)//bang gia da xac nhan
            //{
            //    return false;
            //}
            return true;
        }
        private void tsbEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Updating = true;

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

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ChungTuThanhToanInfor tt in Business.ListChungTuThanhToan)
                {
                    rpt_PhieuChiTien rp = new rpt_PhieuChiTien(tt);
                    rp.ShowPreview();
                }
            }
            catch (Exception ex)
            {
                EventLogProvider.Instance.WriteLog(ex.ToString()
                                    + "\nUser: " + nguoiDung.TenDangNhap
                                    + "\nMay: " + Declare.TenMay,
                                    this.Name);
                MessageBox.Show("Loi: " + ex.ToString());
            }
        }

        private void bteKhoXuat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteKhoXuat_ButtonClick(sender, e, bteKhoXuat, -1, nguoiDung.IdNhanVien);
        }

        private void bteKhoXuat_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteKhoXuat_KeyDown(sender, e, bteKhoXuat, -1, nguoiDung.IdNhanVien);
        }

        private void bteKhoXuat_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteKhoXuat);
        }

        private void bteKhachLe_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int idDoiTuongCha = txtKhachHang != null ? ((DMDoiTuongInfo)txtKhachHang.Tag).IdDoiTuong : -1;
            UtilFunctions.bteKhachLe_ButtonClick(sender, e, bteKhachLe, idDoiTuongCha);
        }

        private void bteKhachLe_KeyDown(object sender, KeyEventArgs e)
        {
            int idDoiTuongCha = txtKhachHang != null ? ((DMDoiTuongInfo)txtKhachHang.Tag).IdDoiTuong : -1;
            UtilFunctions.bteKhachLe_KeyDown(sender, e, bteKhachLe, idDoiTuongCha);
        }

        private void bteKhachLe_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteKhachLe);
        }

        private void bteThuongVien_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteNhanVien_ButtonClick(sender, e, bteThuongVien, -1);
        }

        private void bteThuongVien_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteNhanVien_KeyDown(sender, e, bteThuongVien, -1);
        }

        private void bteThuongVien_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteThuongVien);
        }

        private void txtKhachHang_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteKhachHang_ButtonClick(sender, e, txtKhachHang, Declare.IdLoaiKhachHang);
        }

        private void txtKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteKhachHang_KeyDown(sender, e, txtKhachHang, Declare.IdLoaiKhachHang);
        }

        private void txtKhachHang_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, txtKhachHang);
        }

        private ChungTuBanHangInfor ctugoc;

        private void frmBH_LapDonHangTraLai_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(ctugoc != null)
            {
                CommonProvider.Instance.Lock_Unlock_ChungTu(ctugoc.IdChungTu, 0); //mo khoa chung tu
            }
        }

        private void txtSoPhieuNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnSearchPhieuNhap_Click(sender, e);
            }
        }
    }
}