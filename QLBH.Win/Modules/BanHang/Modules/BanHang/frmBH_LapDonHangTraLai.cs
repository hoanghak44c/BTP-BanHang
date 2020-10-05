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
    public partial class frmBH_LapDonHangTraLai : DevExpress.XtraEditors.XtraForm
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
        public frmBH_LapDonHangTraLai()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.Business = new LapDonHangTraLaiBussiness(LoaiChungTu, nguoiDung.IdNhanVien, _IdKho);
        }

        public frmBH_LapDonHangTraLai(ChungTuBanHangInfor ctu)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.Business = new LapDonHangTraLaiBussiness(ctu);
        }
        public void HideMenu()
        {
            bool enable = ValidEditChungTu();
            //toolStrip1.Enabled = nguoiDung.SupperUser != 1 ? false : true;
            tsbAdd.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbEdit.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbUpdate.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbDelete.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbConfirm.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbPayment.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbPrint.Enabled = true;

            Updating = nguoiDung.SupperUser != 1 ? false : enable;
            setEDFunctions();
        }
        #region Actions
        private void setEDFunctions()
        {
            tsbAdd.Enabled = !Updating;
            tsbEdit.Enabled = !Updating && Draft != 0;
            tsbUpdate.Enabled = Updating;
            //tsbDelete.Enabled = TrangThai == (int)OrderStatus.DE_NGHI_TRA_LAI_HANG_BAN;
            tsbConfirm.Enabled = Updating;
            tsbPayment.Enabled = Updating;
            tsbPrint.Enabled = !Updating;

            btnThanhToan.Enabled = Updating;
            btnXoaTT.Enabled = Updating;

            btnSearchPhieuNhap.Enabled = Updating;
            btnSearchChungTu.Enabled = Updating;
            dteNgayNhap.Enabled = Updating;
            txtSoPhieuNhap.Properties.ReadOnly = !Updating;
            txtSoPhieuXuat.Properties.ReadOnly = true;// !Updating;
            txtSoGiaoDich.Properties.ReadOnly = !Updating;
            txtSoHoaDon.Properties.ReadOnly = !Updating;
            lueLyDo.Enabled = Updating;
            txtGhiChu.Enabled = Updating;
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
            //double tongTienOld = Business.ChungTu.TongTienThanhToan;
            //double tienNoOld = Business.ChungTu.TienConNo;
            //double tienTraTruoc = Business.ChungTu.TienThanhToanThuc;

            //cap nhat thong tin chungtu
            UpdateChungTuInfor();
            //cap nhat thong tin thanh toan
            UpdateChungTuThanhToan();
            //cap nhat du lieu
            if (Business.ChungTu.TrangThai == (int)OrderStatus.TRA_LAI_DON_HANG_BAN)
            {
                Business.SaveChungTu();
            }                
            else
            {
                Business.SaveDonHangTraLai();
            }

            //if (traTruoc)
            //    BanHangDataProvider.Instance.UpdateCongNoKhachHang(Business.ChungTu.IdKhachLe,
            //                                                       Business.ChungTu.IdDoiTuong,
            //                                                       0,
            //                                                       0, 0,
            //                                                       -tienTraTruoc, Business.ChungTu.LoaiChungTu);
            //else
            //    BanHangDataProvider.Instance.UpdateCongNoKhachHang(Business.ChungTu.IdKhachLe,
            //                                                       Business.ChungTu.IdDoiTuong,
            //                                                       Business.ChungTu.TongTienThanhToan,
            //                                                       Business.ChungTu.TienConNo, tongTienOld,
            //                                                       tienNoOld, Business.ChungTu.LoaiChungTu);
            ////cap nhat don hang xac nhan online bi tra lai (ko len doanh thu)
            //SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(), CommandType.Text,
            //                          String.Format("update tbl_chungtu t set t.tuhuy = {0} where idchungtu = {1}", Business.ChungTu.TuHuy, Business.ChungTu.IdChungTu));
            Common.SetFormStatus(this.Name, true);
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
                //Thiet lap trang thai item
                if (ValidEditChungTu())
                    tsbEdit_Click(sender, e);
                else
                {
                    Updating = false;
                    setEDFunctions();
                }
                txtSoPhieuNhap.Enabled = false;
            }
            else
            {
                tsbAdd_Click(sender, e);
                //Updating = false;
                //setEDFunctions();
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
                    Draft = 0;

                    //huy don hang chinh
                    HuyDonHangGoc();

                    //xac nhan don hang tra lai
                    UpdateChungTu();

                    //cap nhat lai diem tich luy the
                    ChinhSachTheTVienDataProvider.Instance.UpdateDiemTichLuyTraHang(Business.ChungTu.IdChungTu);

                    //tinh tien khach phai tra lai do tru diem thuong cac don hang truoc, sau do update lai diem ve 0
                    int soDiemAm = 0;
                    int idThe = 0;
                    double tienTraLaiThe =
                        ChinhSachTheTVienDataProvider.Instance.CheckSoTienTraLai(Business.ChungTu.IdChungTu, ref soDiemAm, ref idThe);
                    if (tienTraLaiThe > 0)
                    {
                        BanHangBusiness tlaiBus = new BanHangBusiness(Business.ChungTu, tienTraLaiThe, soDiemAm, idThe);
                        tlaiBus.SaveChungTuHoanTien();
                        MessageBox.Show("Đề nghị khách hàng trả lại tiền quy đổi điểm thưởng");

                        frmBH_LapPhieuThu frm = new frmBH_LapPhieuThu(tlaiBus.ChungTu);
                        frm.ShowDialog();
                    }

                    ConnectionUtil.Instance.CommitTransaction();
                    Updating = false;
                    setEDFunctions();
                    clsUtils.MsgThongBao(Declare.msgUpdateSucc);
                }


                if (ctugoc != null)
                {
                    CommonProvider.Instance.Lock_Unlock_ChungTu(ctugoc.IdChungTu, 0); //mo khoa chung tu
                }

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
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
                ChungTuBanHangInfor ctugoc = BanHangDataProvider.Instance.LoadChungTuBySoChungTu(txtSoGiaoDich.Text, -2);

                if (ctugoc == null)
                {
                    MessageBox.Show("Số giao dịch gốc không đúng. Không tìm được đơn hàng bán");
                    return false;
                }
                if (!ctugoc.SoChungTu.Equals(Business.ChungTu.SoChungTu))
                {
                    MessageBox.Show("Số giao dịch không khớp với đơn hàng gốc chứa sản phẩm cần trả!");
                    txtSoGiaoDich.Text = Business.ChungTu.SoChungTu;
                    return false;
                }
                if (ctugoc.LockId == 1)
                {
                    if (!CommonProvider.Instance.Check_Lock_ChungTu(ctugoc.IdChungTu))
                    {
                        MessageBox.Show("Đơn hàng đang được mở bởi 1 người khác. Bạn không thể thay đổi trạng thái được!");
                        return false;
                    }
                }
                
                if (ctugoc.TrangThai == (int)OrderStatus.HUY_DON_HANG_ONLINE || ctugoc.TrangThai == (int)OrderStatus.HUY_DON_HANG_DAT_TRUOC
                     || ctugoc.TrangThai == (int)OrderStatus.HUY_DON_HANG || ctugoc.TrangThai == (int)OrderStatus.DE_NGHI_TRA_LAI_HANG_BAN
                     || ctugoc.TrangThai == (int)OrderStatus.XAC_NHAN_TRA_LAI_HANG_BAN)
                {
                    MessageBox.Show(string.Format("Đơn hàng [{0}] đã được trả lại, không thể trả tiếp!", ctugoc.SoChungTu));
                    return false;
                }
                
                if (ctugoc.TrangThai > 11)
                {
                    MessageBox.Show("Đơn hàng không ở trạng thái lập đơn hàng nên không thể trả lại được!");
                    return false;
                }

                //tinh tien khach phai tra lai do tru diem thuong cac don hang truoc
                double tienTraLaiThe =
                    ChinhSachTheTVienDataProvider.Instance.CheckTruocSoTienTraLai(txtSoGiaoDich.Text);
                if (tienTraLaiThe > 0)
                {
                    string msg =
                        String.Format(
                            "Khách hàng phải hoàn lại trả lại {0} đồng do đã quy đổi quá số điểm thưởng khi trả lại đơn hàng này!",
                            tienTraLaiThe);
                    if (MessageBox.Show(msg, "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.No)
                        return false;
                    else
                    {
                        txtGhiChu.Text = txtGhiChu.Text + "\r\n" + msg;
                    }
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
                                                                                 (int)TransactionType.NHAPTRAHANGMUA);
                if (ct != null)
                {
                    Business = new LapDonHangTraLaiBussiness(ct);
                    LoadChungTuInstance();
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
            if (Business.ChungTu.IdChungTu > 0 && Business.ChungTu.Draft == 0)//bang gia da xac nhan
            {
                return false;
            }
            return true;
        }
        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (ValidEditChungTu())
            {
                Updating = true;

                setEDFunctions();
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
        private bool ValidDeleteChungTu()
        {
            if (Business.ChungTu.IdChungTu > 0 && Draft == 0)//bang gia da xac nhan            
            {
                MessageBox.Show("Đơn hàng chưa thay đổi trạng thái, không thể xóa được");
                return false;
            }
            return true;
        }
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (ValidDeleteChungTu())
            {
                DeleteChungTu();
            }
            Updating = false;
            setEDFunctions();
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
                        Business.DeleteChungTu();
                    }
                    ConnectionUtil.Instance.CommitTransaction();
                    MessageBox.Show("Hủy đơn hàng trả lại thành công!");
                    this.Close();
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
                MessageBox.Show("Lỗi thực hiện Xóa đơn hàng\n" + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi thực hiện Xóa đơn hàng", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
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
        private void btnSearchChungTu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtSoGiaoDich.Text) || !string.IsNullOrEmpty(txtSoHoaDon.Text))
                {
                    if (ctugoc != null /*&& ctugoc.SoChungTu == txtSoGiaoDich.Text*/)
                    {
                        CommonProvider.Instance.Lock_Unlock_ChungTu(ctugoc.IdChungTu, 0); //mo khoa chung tu
                    }
                    
                    ctugoc = BanHangDataProvider.Instance.LoadChungTuBySoChungTu(txtSoGiaoDich.Text, txtSoHoaDon.Text);

                    if (ctugoc != null)
                    {
                        if (ctugoc.LockId == 1)
                        {
                            if(!CommonProvider.Instance.Check_Lock_ChungTu(ctugoc.IdChungTu))
                            {
                                MessageBox.Show("Đơn hàng đang được mở bởi 1 người khác. Bạn không thể thay đổi trạng thái được!");
                                return;
                            }
                        }

                        //có chặn trả lại chéo OU không?
                        if (CommonProvider.Instance.IsKhacTinh(Declare.IdTrungTamHachToan, DMKhoDataProvider.GetKhoByIdInfo(ctugoc.IdKho).IdTrungTam))
                        {
                            if(nguoiDung.IsOnline)
                            {
                                if(DMKhoDataProvider.Instance.IsCrossedOU(ctugoc.IdKho, Declare.IdKho))
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
                        if (String.IsNullOrEmpty(ctugoc.SoChungTuGoc) && ctugoc.TrangThai == (int)OrderStatus.DON_HANG_BAN_DAT_TRUOC)
                        {
                            MessageBox.Show("Đơn hàng đặt trước đã được kết chuyển thành đơn hàng bán. Phải trả lại đơn hàng bán đặt trước!");
                            return;
                        }
                        if (String.IsNullOrEmpty(ctugoc.SoChungTuGoc) && ctugoc.TrangThai == (int)OrderStatus.XAC_NHAN_DON_HANG_ONLINE)
                        {
                            MessageBox.Show("Đơn hàng Online đã được kết chuyển thành đơn hàng bán. Phải trả lại đơn hàng xác nhận Online!");
                            return;
                        }
                        if (ctugoc.TrangThai == (int)OrderStatus.DANG_XUAT_KHO || ctugoc.TrangThai == (int)OrderStatus.XUAT_KHO)
                        {
                            MessageBox.Show("Đơn hàng đã xuất kho, không thể trả lại riêng hóa đơn được.\nPhải trả lại cả đơn hàng!");
                            return;
                        }
                        
                        //28/02/2015 hah bổ sung
                        //Do hiện tại vẫn còn sai trạng thái, người dùng vẫn có thể làm trả lại được
                        //do đó cần check thêm trên chứng từ, sau này có thể bỏ qua
                        //1.Đối với các giao dịch OL, DT đã có XNOL, ODT rồi thì không làm trả lại nữa
                        //2.Đối với các giao dịch XNOL, ODT đã có XK rồi thì không làm trả lại nữa.
                        if (ctugoc.SoChungTu.StartsWith("OL") || ctugoc.SoChungTu.StartsWith("DT"))
                        {
                            if(BanHangDataProvider.Instance.ExistChungTuKetChuyen(ctugoc.SoChungTu, ctugoc.LoaiChungTu))
                            {
                                MessageBox.Show("Đơn hàng đã được kết chuyển thành đơn hàng bán. Phải trả lại đơn hàng bán!");
                                return;                                
                            }
                        }
                        else if (ctugoc.SoChungTu.StartsWith("XNOL") || ctugoc.SoChungTu.StartsWith("ODT"))
                        {
                            if (BanHangDataProvider.Instance.ExistChungTuXuatKho(ctugoc.SoChungTu))
                            {
                                MessageBox.Show("Đơn hàng đã được xuất kho. Phải nhập lại đơn hàng bán!");
                                return;
                            }                            
                        }

                        if (!CommonProvider.Instance.Lock_Unlock_ChungTu(ctugoc.IdChungTu, 1))//khoa chung tu
                        {
                            MessageBox.Show("Chứng từ này đang có người cập nhật. Bạn không thể cập nhật được!");
                            return;
                        }

                        //hah: bắt buộc phải clone ctugoc, nếu không sẽ không unlock ctugoc duoc
                        Business = new LapDonHangTraLaiBussiness(ctugoc.Clone() as ChungTuBanHangInfor);


                        Business.ChungTu.SoChungTuGoc = ctugoc.SoChungTu;
                        LoadOldChungTuInfor(Business.ChungTu);
                        LoadChiTietHangBan();

                        Business.ChungTu.IdChungTu = 0;
                        dteNgayNhap.EditValue = CommonProvider.Instance.GetSysDate();
                        Business.ListChungTuThanhToan = new List<ChungTuThanhToanInfor>();
                        gHinhThucThanhToan.DataSource = new BindingList<ChungTuThanhToanInfor>(Business.ListChungTuThanhToan);
                    }
                    else
                    {
                        MessageBox.Show("Số giao dịch này không đúng! Không thể trả lại được");
                    }
                }
            }
            catch (ManagedException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                EventLogProvider.Instance.WriteOfflineLog(ex.ToString());

                MessageBox.Show(ex.Message);
#endif
            }
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Updating = true;
                Draft = -1;

                ResetAllText();
                txtSoPhieuNhap.Text = CommonProvider.Instance.GetSoPhieu(Declare.Prefix.DonHangTraLai);
                dteNgayNhap.EditValue = CommonProvider.Instance.GetSysDate();

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

        private void frmBH_LapDonHangTraLai_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(ctugoc != null)
            {
                CommonProvider.Instance.Lock_Unlock_ChungTu(ctugoc.IdChungTu, 0); //mo khoa chung tu
            }
        }
    }
}