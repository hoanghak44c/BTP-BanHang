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
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;
using QLBH.Common.Providers;
using QLBH.Core.Data;
using QLBH.Core.Providers;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmChiTietXacNhapLaiKhac : DevExpress.XtraEditors.XtraForm
    {
        #region Declare
        private int Draft = -1;
        private bool Updating = false;
        private int LoaiChungTu = (int)TransactionType.DON_HANG_NHAP_LAI;
        private int TrangThai = (int) OrderStatus.XAC_NHAN_TRA_LAI_HANG_BAN;
        //private List<NhapHangTraMuaInfor> lst = new List<NhapHangTraMuaInfor>();
        //private List<NhapHangTraChiTietHHInfor> lstnt = new List<NhapHangTraChiTietHHInfor>();
        private XacNhanNhapLaiKhacBussiness Business;
        protected NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int _IdKho = Declare.IdKho;
        private int _IdTrungTam = Declare.IdTrungTam;
        private double TienKhachTra = 0;

        #endregion
        public frmChiTietXacNhapLaiKhac()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.Business = new XacNhanNhapLaiKhacBussiness(LoaiChungTu, nguoiDung.IdNhanVien, _IdKho);
        }

        public frmChiTietXacNhapLaiKhac(NhapHangTraMuaInfor ctu)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.Business = new XacNhanNhapLaiKhacBussiness(ctu);
        }
        public frmChiTietXacNhapLaiKhac(ChungTuBanHangInfor ctu)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.Business = new XacNhanNhapLaiKhacBussiness(ctu);
        }
        public void HideMenu()
        {
            bool enable = ValidEditChungTu();
            //toolStrip1.Enabled = nguoiDung.SupperUser != 1 ? false : true;
            tsbEdit.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbUpdate.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbDelete.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbConfirm.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbPayment.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            tsbPrint.Enabled = true;

            //btnSearchPhieuNhap.Enabled = nguoiDung.SupperUser != 1 ? false : true;
            //btnTimOrderKH.Visible = false;
            Updating = nguoiDung.SupperUser != 1 ? false : enable;
            setEDItems();
        }
        #region Actions
        private void setEDFunctions()
        {
            tsbEdit.Enabled = !Updating && (Draft != 0 || Business.ChungTu.TrangThai == (int) OrderStatus.DE_NGHI_TRA_LAI_HANG_BAN);
            tsbUpdate.Enabled = Updating;
            tsbDelete.Enabled = Business.ChungTu.TrangThai == (int) OrderStatus.XAC_NHAN_TRA_LAI_HANG_BAN;
            tsbConfirm.Enabled = Updating;
            tsbPayment.Enabled = Updating;
            tsbPrint.Enabled = !Updating;

            btnThanhToan.Enabled = Updating;
            btnSuaTToan.Enabled = Updating;
            btnXoaTT.Enabled = Updating;
            btnSearchPhieuNhap.Enabled = Updating;
            lueLyDo.Enabled = Updating;
            txtGhiChu.Enabled = Updating;
        }

        private void setEDItems()
        {
            //btnSearchPhieuNhap.Enabled = Updating;
            //txtSoPhieuNhap.Properties.ReadOnly = !Updating;
            txtSoPhieuXuat.Properties.ReadOnly = true;
            txtSoGiaoDich.Properties.ReadOnly = true;
            txtSoHoaDon.Properties.ReadOnly = true;

            bteKhoXuat.Enabled = false;
            dteNgayNhap.Enabled = false;
            lueLyDo.Enabled = Updating;
            txtGhiChu.Enabled = Updating;
            //txtSoGiaoDich.Enabled = Updating;
            //txtSoPhieuNhap.Enabled = Updating;
            //txtSoPhieuXuat.Enabled = Updating;
            //txtSoHoaDon.Enabled = Updating;
            txtKhachHang.Enabled = Updating;
            dteNgayLap.Enabled = Updating;
            dteNgayXuat.Enabled = Updating;
            //txtKiHieu.Enabled = Updating;
            bteThuongVien.Enabled = Updating;
            bteKhachLe.Enabled = Updating;
            txtCongTy.Enabled = Updating;
            txtTenDoiTuong.Enabled = Updating;
            cboGioiTinh.Enabled = Updating;
            txtCMND.Enabled = Updating;
            txtSoDienThoai.Enabled = Updating;
            txtEmail.Enabled = Updating;
            txtDiaChiHD.Enabled = Updating;
            txtDiaChiGH.Enabled = Updating;
            txtTongTienTT.Enabled = Updating;
            txtTienThucTra.Enabled = Updating;
        }

        private void ResetAllText()
        {
            clsUtils.ResetAllText(this);
            //lst.Clear();
            //lstnt.Clear();
            LoadKho();
        }

        private void LoadGioiTinh()
        {
            cboGioiTinh.Properties.Items.Add("Nữ");
            cboGioiTinh.Properties.Items.Add("Nam");
        }

        private void LoadCa()
        {
            //List<DmCaBanHangInfor> liCaBanHang = DMCaBanHangDataProvider.Instance.GetListCaBanHangInfors();
            //for (int i = 0; i < liCaBanHang.Count; i++)
            //    cboCaBanHang.Properties.Items.Add(liCaBanHang[i].CaBanHang);
        }

        private void LoadKho()
        {
            DMKhoInfo dmKho = DMKhoDataProvider.GetKhoByIdInfo(_IdKho);
            if (dmKho != null)
            {
                bteKhoXuat.Text = dmKho.TenKho;
                bteKhoXuat.Tag = dmKho;
            }
        }

        private void LoadLyDo()
        {
            lueLyDo.Properties.DataSource = DMLyDoTraHangDataProvider.Instance.GetListLyDoTraHangInfo();
        }

        private void LoadChungTuInstance()
        {
            if (Business.ChungTu.IdChungTu != 0)
            {
                LoadChungTuHeader();
                LoadChiTietHangBan();
                LoadChiTietThanhToan(Business.ChungTu.IdChungTu);
            }
            else
            {
                ResetAllText();
            }         
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

            try
            {
                dteNgayXacNhan.EditValue = Business.ChungTu.NgayXuatHang;
            }
            catch (Exception)
            {
                dteNgayXacNhan.EditValue = CommonProvider.Instance.GetSysDate();
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

        //loai chi tiết hàng bán(hàng nhập lại)
        private void LoadChiTietHangBan()
        {
            grcHangBan.DataSource = null;
            grcHangBan.DataSource = new BindingList<NhapHangTraChiTietHHInfor>(Business.ListChiTietChungTu);
        }

        private void LoadChiTietThanhToan(int idchungtu)
        {
            Business.ListChungTuThanhToan =
                ThanhToanDataProvider.Instance.LoadAllThanhToanByCTu(idchungtu);
            gHinhThucThanhToan.DataSource = null;
            gHinhThucThanhToan.DataSource = new BindingList<ChungTuThanhToanInfor>(Business.ListChungTuThanhToan);
        }

        // save kế toán xác nhận trả lại, trừ tồn thật
        private void UpdateChungTu()
        {
            //double tongTienOld = Business.ChungTu.TongTienThanhToan;
            //double tienNoOld = Business.ChungTu.TienConNo;

            //xoa chung tu goc truoc khi sinh phieu nhap lai
            if (Business.ChungTu.TrangThai != (int)OrderStatus.XAC_NHAN_TRA_LAI_HANG_BAN)
                Business.DeleteChungTuGoc(Business.ChungTu.IdChungTu);
            //cap nhat thong tin chungtu
            UpdateChungTuInfor();
            //cap nhat thong tin thanh toan
            UpdateChungTuThanhToan();
            //cap nhat du lieu
            Business.SaveChungTu();

            //BanHangDataProvider.Instance.UpdateCongNoKhachHang(Business.ChungTu.IdKhachLe,
            //                                                   Business.ChungTu.IdDoiTuong,
            //                                                   Business.ChungTu.TongTienThanhToan,
            //                                                   Business.ChungTu.TienConNo, tongTienOld,
            //                                                   tienNoOld, Business.ChungTu.LoaiChungTu);
        }
        private void UpdateChungTuInfor()
        {
            Business.ChungTu.Draft = Draft;
            if (Business.ChungTu.TrangThai != (int)OrderStatus.XAC_NHAN_TRA_LAI_HANG_BAN)
            {
                Business.ChungTu.IdChungTu = 0;//sinh chung tu xac nhan
                Business.ChungTu.NgayXuatHang = CommonProvider.Instance.GetSysDate();
                Business.ChungTu.TrangThai = (int)OrderStatus.XAC_NHAN_TRA_LAI_HANG_BAN;                
            }

            Business.ChungTu.NguoiSua = nguoiDung.TenDangNhap;
            Business.ChungTu.TenMaySua = Declare.TenMay;
            Business.ChungTu.SoChungTu = txtSoPhieuNhap.Text.Trim().ToUpper();
            Business.ChungTu.SoChungTuGoc = txtSoGiaoDich.Text.Trim().ToUpper();
            //Business.ChungTu.IdNhanVien = nguoiDung.IdNhanVien;
            //Business.ChungTu.IdTrungTam = _IdTrungTam;
            //Business.ChungTu.IdKho = ((DMKhoInfo)bteKhoXuat.Tag).IdKho;
            Business.ChungTu.IdLyDoGiaoDich = Common.IntValue(lueLyDo.EditValue);
            Business.ChungTu.OrderType = Declare.OrderTypeTraLai;
            Business.ChungTu.NgayLap = Convert.ToDateTime(dteNgayNhap.EditValue);
            Business.ChungTu.GhiChu = txtGhiChu.Text;

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

            Business.ListChiTietHangHoa = new List<ChungTuBanHangChiTietHangHoaInfor>();
            foreach (NhapHangTraChiTietHHInfor ct in Business.ListChiTietChungTu)
            {
                string[] mavach = ct.MaVach.Split(';');
                for (int j = 0; j < mavach.Length; j++)
                {
                    ChungTuBanHangChiTietHangHoaInfor cthh = new ChungTuBanHangChiTietHangHoaInfor()
                    {
                        IdChungTuChiTiet = ct.IdChungTuChiTiet,
                        IdSanPham = ct.IdSanPham,
                        MaSanPham = ct.MaSanPham,
                        TenSanPham = ct.TenSanPham,
                        DonViTinh = ct.DonViTinh,
                        MaVach = mavach[j].Trim(),
                        SoLuong = (mavach.Length != 0 ? ct.SoLuong / mavach.Length : ct.SoLuong)
                    };
                    Business.ListChiTietHangHoa.Add(cthh);
                }
            }
            ////foreach (NhapHangTraChiTietHHInfor pt in Business.ListChiTietChungTu)
            ////{
            ////    pt.MaVach = "";
            ////}
            //foreach (NhapHangTraChiTietHHInfor pt in (BindingList<NhapHangTraChiTietHHInfor>)grcHangBan.DataSource)
            //{
            //    if (!Business.ListChiTietHangHoa.Exists(delegate(ChungTuBanHangChiTietHangHoaInfor math)
            //                                                        {
            //                                                            return math.MaVach == pt.MaVach && math.IdSanPham == pt.IdSanPham;
            //                                                        }))
            //        Business.ListChiTietHangHoa.Add(new ChungTuBanHangChiTietHangHoaInfor
            //                                                     {
            //                                                         IdChungTuChiTiet = pt.IdChungTuChiTiet,
            //                                                         IdSanPham = pt.IdSanPham,
            //                                                         MaVach = pt.MaVach,
            //                                                         SoLuong = pt.SoLuong
            //                                                     });
            //}
        }

        private void UpdateChungTuThanhToan()
        {
            Business.ChungTu.TienThanhToanThuc = 0;
            foreach (ChungTuThanhToanInfor tt in Business.ListChungTuThanhToan)
            {
                //tt.SoPhieu = CommonProvider.Instance.GetSoPhieu(Declare.Prefix.PhieuChiTien);
                tt.HoTen = Business.ChungTu.HoTen;
                tt.DiaChi = Business.ChungTu.DiaChiHoaDon;
                tt.DienThoai = Business.ChungTu.DienThoai;
                tt.NoiDungThanhToan = "Chi tiền trả lại cho khách mua hàng";
                tt.IdTienTe = Declare.IdTienTe;
                tt.TyGia = 1;
                tt.SoTienChu = Common.ReadNumner_(Common.Double2Str(tt.SoTienThanhToan));
                tt.SoChungTuGoc = Business.ChungTu.SoChungTu;

                if (tt.LoaiThanhToan != -1 && !tt.HinhThucThanhToan.ToUpper().Equals("VOUCHER"))
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
            foreach (NhapHangTraChiTietHHInfor ct in (BindingList<NhapHangTraChiTietHHInfor>)grcHangBan.DataSource)
            {
                Business.ChungTu.TongTienHang += ct.ThanhTien;
            }

            Business.ChungTu.TongTienChietKhau = 0;
            Business.ChungTu.TongTienSauChietKhau = Business.ChungTu.TongTienHang;
            Business.ChungTu.TongTienVAT = 0;
            Business.ChungTu.TongTienThanhToan = TienKhachTra;
            Business.ChungTu.TienConNo = Business.ChungTu.TongTienThanhToan - Business.ChungTu.TienThanhToanThuc;
        }
        #endregion

        #region Events
        private void frmChiTietYeuCauNhapLaiHangMua_Load(object sender, EventArgs e)
        {
            LoadLyDo();
            LoadKho();
            //LoadCa();
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
                    setEDItems();
                }
                //txtSoPhieuNhap.Enabled = false;
            }
            else
            {
                Updating = false;
                setEDFunctions();
                setEDItems();
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
                if (!ValidData()) return;
                ConnectionUtil.Instance.BeginTransaction();
                Draft = 1;
                UpdateChungTu();
                ConnectionUtil.Instance.CommitTransaction();
                Updating = false;
                setEDFunctions();
                setEDItems();
                clsUtils.MsgThongBao(Declare.msgUpdateSucc);
            }
            catch (Exception ex)
            {
                ConnectionUtil.Instance.RollbackTransaction();

                EventLogProvider.Instance.WriteLog(ex.ToString()
                                    + "\nUser: " + nguoiDung.TenDangNhap
                                    + "\nMay: " + Declare.TenMay,
                                    this.Name);
                this.Close();
#if DEBUG
                clsUtils.MsgCanhBao(ex.ToString());
#else
                clsUtils.MsgCanhBao(ex.Message);
#endif
            }
        }
        private bool ValidData()
        {            
            if (Common.DoubleValue(txtTienThucTra.Text) == 0 && MessageBox.Show("Tiền khách trả để trống. Bạn có chắc chắn như vậy không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return false;
            }
            return true;
        }

        private void smiComfim_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidData()) return;
                ConnectionUtil.Instance.BeginTransaction();
                Draft = 0;
                UpdateChungTu();
                ConnectionUtil.Instance.CommitTransaction();
                Updating = false;
                setEDFunctions();
                setEDItems();
                clsUtils.MsgThongBao(Declare.msgUpdateSucc);
            }
            catch (Exception ex)
            {
                ConnectionUtil.Instance.RollbackTransaction();

                EventLogProvider.Instance.WriteLog(ex.ToString()
                                    + "\nUser: " + nguoiDung.TenDangNhap
                                    + "\nMay: " + Declare.TenMay,
                                    this.Name);
                this.Close();
#if DEBUG
                clsUtils.MsgCanhBao(ex.ToString());
#else
                clsUtils.MsgCanhBao(ex.Message);
#endif
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
                                                                                 (int)TransactionType.DON_HANG_NHAP_LAI);
                if (ct != null)
                {
                    Business = new XacNhanNhapLaiKhacBussiness(ct);
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
            try
            {
                int IdTrungTamThu = (nguoiDung.IdTrungTamHachToan == 0 ? _IdTrungTam : nguoiDung.IdTrungTamHachToan);

                frmBH_ChonHinhThucTT frm = new frmBH_ChonHinhThucTT(Business.ListChungTuThanhToan,
                                                                    txtSoPhieuNhap.Text,
                                                                    Common.DoubleValue(txtTienThucTra.Text),
                                                                    Common.DoubleValue(txtTienTraKhach.Text),
                                                                    Declare.KyHieuTienTe,
                                                                    nguoiDung.IdNhanVien,
                                                                    IdTrungTamThu, (int)LoaiPhieuThanhToan.PHIEU_CHI,
                                                                    (int)LoaiGiaoDichThanhToan.GIAODICH_BANHANG);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ((BindingList<ChungTuThanhToanInfor>)gHinhThucThanhToan.DataSource).Add(frm.ThanhToan);
                    txtTienTraKhach.Text = Common.Double2Str(frm.TienDaThanhToan);
                    txtTienNoKhach.Text = Common.Double2Str(frm.TongTienThanhToan - frm.TienDaThanhToan);
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
                            MessageBox.Show("Phiếu thu này đã được tạo. Không thể xóa được!");
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
            if (Business.ChungTu.IdChungTu > 0 && Business.ChungTu.Draft == 0 && Business.ChungTu.TrangThai != (int)OrderStatus.DE_NGHI_TRA_LAI_HANG_BAN)//bang gia da xac nhan
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
                setEDItems();
            }
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            try
            {
                InDonHangTraLai();
                if (Business.ListChungTuThanhToan != null && MessageBox.Show("Có in kèm phiếu thu hay không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (ChungTuThanhToanInfor tt in Business.ListChungTuThanhToan)
                    {
                        if (tt.LoaiThanhToan != -1)//khong phai voucher thi in ra
                        {
                            rpt_PhieuChiTien rp = new rpt_PhieuChiTien(tt);
                            rp.ShowPreview();
                        }
                    }
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

        private void InDonHangTraLai()
        {
            if (Business.ChungTu.IdChungTu == 0) return;
            HoaDonPCGNInfo hd = new HoaDonPCGNInfo();
            hd.KhachHang = Business.ChungTu.TenDoiTuong;
            hd.HoTen = Business.ChungTu.HoTen;
            hd.DienThoai = Business.ChungTu.DienThoai;
            hd.CongTy = Business.ChungTu.CongTy;
            hd.MaSoThue = Business.ChungTu.MaSoThue;
            hd.DiaChiHoaDon = Business.ChungTu.DiaChiHoaDon;
            hd.DiaChiGiaoHang = Business.ChungTu.DiaChiGiaoHang;
            hd.NgayLap = Business.ChungTu.NgayLap;
            hd.NgayBan = Convert.ToDateTime(dteNgayLap.EditValue);
            hd.SoChungTuGoc = txtSoGiaoDich.Text;
            hd.SoChungTu = Business.ChungTu.SoChungTu;

            ChungTuBanHangInfor cTuGoc = BanHangDataProvider.Instance.LoadChungTuBySoChTu(Business.ChungTu.SoChungTuGoc);
            if (cTuGoc != null)
            {
                DMKhoInfo khoXuat = DMKhoDataProvider.GetKhoByIdInfo(cTuGoc.IdKho);
                if (khoXuat != null)
                {
                    hd.KhoXuat = khoXuat.MaKho;
                }
            }

            DMKhoInfo khoNhap = DMKhoDataProvider.GetKhoByIdInfo(Business.ChungTu.IdKho);
            if (khoNhap != null)
            {
                hd.MaKhoNhapLai = khoNhap.MaKho;
                hd.TenKhoNhapLai = khoNhap.TenKho;
            }

            hd.LyDoNhapLai = lueLyDo.Text;
            hd.GhiChu = Business.ChungTu.GhiChu;
            hd.NhanVienKinhDoanh = Business.ChungTu.TenNhanVien;
            hd.SoHoaDon = Business.ChungTu.SoSeri;


            //hd.HinhThucThanhToan = LstPhieuPCGN[0];
            hd.CachGiaoHang = Business.ChungTu.GiaoNhan == 1 ? "Giao tại nhà khách" : "Giao tại công ty";
            hd.TongTienHang = Business.ChungTu.TongTienHang;
            hd.TienThanhToanThuc = Business.ChungTu.TienThanhToanThuc;
            hd.TienConNo = Business.ChungTu.TienConNo;

            CommonFuns.Instance.InDonHangTraLai(hd, Business.ListChiTietChungTu);
        }

        private bool ValidDeleteChungTu()
        {
            if (Business.ChungTu.IdChungTu > 0 && Business.ChungTu.TrangThai == (int)OrderStatus.DE_NGHI_TRA_LAI_HANG_BAN)//bang gia da xac nhan            
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
            setEDItems();
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
                        Business.ChungTu.TrangThai = (int)OrderStatus.DE_NGHI_TRA_LAI_HANG_BAN;
                        Business.ChungTu.Draft = 0;
                        Business.CancelChungTu();
                    }
                    ConnectionUtil.Instance.CommitTransaction();
                    MessageBox.Show("Hủy đơn hàng thành công!");
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

        private void txtTongTienTT_EditValueChanged(object sender, EventArgs e)
        {
            UpdateGiaTriDonHang();
        }

        private void txtTienThucTra_EditValueChanged(object sender, EventArgs e)
        {
            UpdateGiaTriDonHang();
        }

        private void UpdateGiaTriDonHang()
        {
            double tongTienHang = Common.DoubleValue(txtTongTienTT.Text);
            TienKhachTra = Common.DoubleValue(txtTienThucTra.Text);
            double tienTraKhach = Common.DoubleValue(txtTienTraKhach.Text);
            txtTienConNo.Text = Common.Double2Str(tongTienHang - TienKhachTra);
            txtTienNoKhach.Text = Common.Double2Str(TienKhachTra - tienTraKhach);
        }

        private void txtTongTienTT_Leave(object sender, EventArgs e)
        {
            txtTongTienTT.Text = Common.Double2Str(Common.DoubleValue(txtTongTienTT.Text.Trim()));
        }

        private void txtTienThucTra_Leave(object sender, EventArgs e)
        {
            txtTienThucTra.Text = Common.Double2Str(Common.DoubleValue(txtTienThucTra.Text.Trim()));
        }

        private void grvHangBan_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "ThanhTien")
            {
                if (grvHangBan.FocusedRowHandle < 0) return;
                try
                {
                    NhapHangTraChiTietHHInfor ctu = (NhapHangTraChiTietHHInfor)grvHangBan.GetRow(grvHangBan.FocusedRowHandle);
                    ctu.TienVAT = ctu.ThanhTien * ctu.TyleVAT / 100 / (1 + ctu.TyleVAT / 100);
                    ctu.TienSauChietKhau = ctu.ThanhTien / (1 + ctu.TyleVAT / 100);
                    ctu.DonGia = ctu.TienSauChietKhau / ctu.SoLuong;

                    double tongThanhTien = 0;
                    foreach (NhapHangTraChiTietHHInfor ct in (BindingList<NhapHangTraChiTietHHInfor>)grcHangBan.DataSource)
                    {
                        CommonFuns.Instance.RoundDetailValue(ct);
                        tongThanhTien += ct.ThanhTien;
                    }
                    txtTongTienTT.Text = Common.Double2Str(tongThanhTien);
                    double tienThucTra = Common.DoubleValue(txtTienThucTra.Text);
                    double tienTraKhach = Common.DoubleValue(txtTienTraKhach.Text);
                    txtTienConNo.Text = Common.Double2Str(tongThanhTien - tienThucTra);
                    txtTienNoKhach.Text = Common.Double2Str(tienThucTra - tienTraKhach);
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

        private void btnSuaTToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvHinhThucThanhToan.FocusedRowHandle < 0) return;
                ChungTuThanhToanInfor t = (ChungTuThanhToanInfor)gvHinhThucThanhToan.GetRow(gvHinhThucThanhToan.FocusedRowHandle);
                if (t != null && t.IdThanhToan > 0 && nguoiDung.SupperUser != 1 && Business.ChungTu.Draft == 0)
                {
                    MessageBox.Show("Phiếu chi này đã được tạo. Không thể sửa được!");
                    return;
                }
                if (t != null)
                {
                    frmBH_ChonHinhThucTT frm = new frmBH_ChonHinhThucTT(t,
                                                                        Common.DoubleValue(txtTienThucTra.Text),
                                                                        Common.DoubleValue(txtTienTraKhach.Text),
                                                                        Declare.KyHieuTienTe);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        ((BindingList<ChungTuThanhToanInfor>)gHinhThucThanhToan.DataSource).ResetBindings();
                        txtTienTraKhach.Text = Common.Double2Str(frm.TienDaThanhToan);
                        txtTienNoKhach.Text = Common.Double2Str(frm.TongTienThanhToan - frm.TienDaThanhToan);
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
    }
}