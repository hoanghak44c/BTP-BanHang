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
using QLBanHang.Modules.TheThanhVien.Providers;
using QLBH.Common;
using QLBH.Common.Providers;
using QLBH.Core.Data;
using QLBH.Core.Providers;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmChiTietXacNhapHangTraLai : DevExpress.XtraEditors.XtraForm
    {
        #region Declare
        private int Draft = 0;
        private bool Updating = false;
        private int LoaiChungTu = (int) TransactionType.NHAPTRAHANGMUA;
        private int TrangThai = (int)OrderStatus.XAC_NHAN_TRA_LAI_HANG_BAN;
        //private List<NhapHangTraMuaInfor> lst = new List<NhapHangTraMuaInfor>();
        private List<NhapHangTraChiTietHHInfor> liChiTiet = new List<NhapHangTraChiTietHHInfor>();
        private NhapTraHangMuaBussiness Business;
        protected NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int _IdKho = Declare.IdKho;
        private int _IdTrungTam = Declare.IdTrungTam;

        #endregion
        public frmChiTietXacNhapHangTraLai()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.Business = new NhapTraHangMuaBussiness(LoaiChungTu, nguoiDung.IdNhanVien, _IdKho);
        }

        public frmChiTietXacNhapHangTraLai(NhapHangTraMuaInfor ctu)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.Business = new NhapTraHangMuaBussiness(ctu);
        }
        public frmChiTietXacNhapHangTraLai(ChungTuBanHangInfor ctu)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.Business = new NhapTraHangMuaBussiness(ctu);
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
            setEDFunctions();
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
            btnXoaTT.Enabled = Updating;
            btnSearchPhieuNhap.Enabled = Updating;
            lueLyDo.Enabled = Updating;
            txtGhiChu.Enabled = Updating;

            setEDItems();
        }

        private void setEDItems()
        {
            //btnSearchPhieuNhap.Enabled = Updating;
            txtSoPhieuNhap.Properties.ReadOnly = true;
            txtSoPhieuXuat.Properties.ReadOnly = true;
            txtSoGiaoDich.Properties.ReadOnly = true;
            txtSoHoaDon.Properties.ReadOnly = true;
            txtKiHieu.Properties.ReadOnly = true;

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
            Business = new NhapTraHangMuaBussiness();
            //lst.Clear();
            LoadKho();
        }

        private void LoadGioiTinh()
        {
            cboGioiTinh.Properties.Items.Add("Nữ");
            cboGioiTinh.Properties.Items.Add("Nam");
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

        private void LoadOldChungTuInfor(string sochungtugoc)
        {
            ChungTuBanHangInfor lstHD = NhapTraHangMuaDataProvider.Instance.SearchChungTuBanHangBySoCTGoc(sochungtugoc);
            if (lstHD == null) return;

            grbChungTuMua.Text = "Thông tin phiếu mua hàng: " +
                     (String.IsNullOrEmpty(lstHD.TenTrungTam)
                          ? ""
                          : (lstHD.TenTrungTam + (String.IsNullOrEmpty(lstHD.TenKho) ? "" : "(" + lstHD.TenKho + ")")));
            _IdTrungTam = lstHD.IdTrungTam;
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
            liChiTiet = new List<NhapHangTraChiTietHHInfor>();
            liChiTiet.AddRange(Business.ListChiTietChungTu);
            grcHangBan.DataSource = null;
            grcHangBan.DataSource = new BindingList<NhapHangTraChiTietHHInfor>(liChiTiet);
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

            //xoa chung tu goc truoc khi sinh phieu nhap lai
            HuyChungTuNhapLaiGoc();
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
        private void HuyChungTuNhapLaiGoc()
        {
            if (Business.ChungTu.TrangThai != (int)OrderStatus.XAC_NHAN_TRA_LAI_HANG_BAN)
            {
                DNNhapTraHangMuaBussiness dnBussiness = new DNNhapTraHangMuaBussiness(Business.ChungTu);
                dnBussiness.DeleteChungTuGoc(dnBussiness.ChungTu.IdChungTu);
                //sinh chung tu de nghi tra lai co tinh ton
                dnBussiness.ChungTu.IdChungTu = 0;
                //dnBussiness.ChungTu.TrangThai = (int)OrderStatus.XAC_NHAN_TRA_LAI_HANG_BAN;
                //dnBussiness.ChungTu.NgayXuatHang = CommonProvider.Instance.GetSysDate();

                dnBussiness.SaveChungTu();

                Business.ChungTu.IdChungTu = dnBussiness.ChungTu.IdChungTu;
                foreach (NhapHangTraChiTietHHInfor ct in dnBussiness.ListChiTietChungTu)
                {
                    NhapHangTraChiTietHHInfor t = liChiTiet.Find(delegate(NhapHangTraChiTietHHInfor m)
                    {
                        return m.IdSanPham == ct.IdSanPham &&
                               m.IdSanPhamBan == ct.IdSanPhamBan &&
                               (String.IsNullOrEmpty(m.MaVach) && String.IsNullOrEmpty(ct.MaVach) || m.MaVach.Equals(ct.MaVach)) &&
                               m.LoaiHangKem == ct.LoaiHangKem;
                    });
                    if (t != null)
                    {
                        t.IdChungTu = ct.IdChungTu;
                        t.IdChungTuChiTiet = ct.IdChungTuChiTiet;
                    }
                }
            }            
        }
        private void UpdateChungTuInfor()
        {
            Business.ChungTu.Draft = Draft;
            if (Business.ChungTu.TrangThai != (int)OrderStatus.XAC_NHAN_TRA_LAI_HANG_BAN)
            {
                Business.ChungTu.TrangThai = (int)OrderStatus.XAC_NHAN_TRA_LAI_HANG_BAN;
                Business.ChungTu.NgayXuatHang = CommonProvider.Instance.GetSysDate();
            }

            Business.ChungTu.NguoiSua = nguoiDung.TenDangNhap;
            Business.ChungTu.TenMaySua = Declare.TenMay;
            
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

            Business.ListChiTietHangHoa = new List<ChungTuBanHangChiTietHangHoaInfor>();
            Business.ListChiTietChungTu = new List<NhapHangTraChiTietHHInfor>();
            foreach (NhapHangTraChiTietHHInfor ct in liChiTiet)
            {
                if (String.IsNullOrEmpty(ct.MaVach)) continue;
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
                        MaVach = mavach[j],
                        IdSanPhamBan = ct.IdSanPhamBan,
                        SoLuong = (mavach.Length != 0 ? ct.SoLuong / mavach.Length : ct.SoLuong)
                    };
                    Business.ListChiTietHangHoa.Add(cthh);
                }
                Business.ListChiTietChungTu.Add(ct);
            }
        }

        private void UpdateChungTuThanhToan()
        {
            Business.ChungTu.TienThanhToanThuc = 0;
            int count = 0;
            foreach (ChungTuThanhToanInfor tt in Business.ListChungTuThanhToan)
            {
                if (tt.IdThanhToan == 0 || String.IsNullOrEmpty(tt.SoPhieu))
                {
                    tt.SoPhieu = CommonFuns.Instance.GetSoPhieuThuChi(Business.ChungTu.SoChungTu,
                                                                      Declare.Prefix.PhieuChiTien, count);
                    count++;
                }
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

            //Business.ChungTu.TongTienHang = 0;
            //foreach (NhapHangTraChiTietHHInfor ct in (BindingList<NhapHangTraChiTietHHInfor>)grcHangBan.DataSource)
            //{
            //    Business.ChungTu.TongTienHang += ct.ThanhTien;
            //}

            Business.ChungTu.TongTienChietKhau = 0;
            //Business.ChungTu.TongTienSauChietKhau = Business.ChungTu.TongTienHang;
            Business.ChungTu.TongTienVAT = 0;
            Business.ChungTu.TongTienThanhToan = Common.DoubleValue(txtTienThucTra.Text); 
            Business.ChungTu.TienConNo = Business.ChungTu.TongTienThanhToan - Business.ChungTu.TienThanhToanThuc;
        }
        #endregion

        #region Events
        private void frmChiTietYeuCauNhapLaiHangMua_Load(object sender, EventArgs e)
        {
            LoadLyDo();
            LoadKho();
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
                //txtSoPhieuNhap.Enabled = false;
            }
            else
            {
                Updating = false;
                setEDFunctions();                
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
                ConnectionUtil.Instance.BeginTransaction();
                Draft = 1;
                UpdateChungTu();
                ConnectionUtil.Instance.CommitTransaction();
                Updating = false;
                setEDFunctions();
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
        private void HuyDonHangGoc()
        {
            ChungTuBanHangInfor ctugoc = BanHangDataProvider.Instance.LoadChungTuBySoChungTu(txtSoGiaoDich.Text, -2);

            if (ctugoc != null)
            {
                ctugoc.TrangThai = (int) OrderStatus.TRA_LAI_DON_HANG_XUAT_KHO;
                BanHangDataProvider.Instance.UpdateChungTu(ctugoc);
            }
        }
        private void smiComfim_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionUtil.Instance.BeginTransaction();
                Draft = 0;

                //cap nhat trang thai don hang goc
                HuyDonHangGoc();

                //cap nhat don hang tra lai
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
            catch (Exception ex)
            {
                ConnectionUtil.Instance.RollbackTransaction();

                EventLogProvider.Instance.WriteOfflineLog(ex.ToString()
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
                                                                                 (int)TransactionType.NHAPTRAHANGMUA);
                if (ct != null)
                {
                    Business = new NhapTraHangMuaBussiness(ct);
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
            frmThanhToanNhapLai frm = new frmThanhToanNhapLai(Business);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //tham thanh toan
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
                        if (t != null && t.IdThanhToan > 0 && nguoiDung.IdNguoiDung != 1)
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
            ChungTuBanHangInfor cTuGoc = BanHangDataProvider.Instance.LoadChungTuBySoChTu(Business.ChungTu.SoChungTuGoc);
            hd.KhachHang = cTuGoc.TenDoiTuong;
            hd.HoTen = cTuGoc.HoTen;
            hd.DienThoai = cTuGoc.DienThoai;
            hd.CongTy = cTuGoc.CongTy;
            hd.MaSoThue = cTuGoc.MaSoThue;
            hd.DiaChiHoaDon = cTuGoc.DiaChiHoaDon;
            hd.DiaChiGiaoHang = cTuGoc.DiaChiGiaoHang;
            hd.NgayLap = Business.ChungTu.NgayLap;
            hd.NgayBan = cTuGoc.NgayLap;
            hd.SoChungTuGoc = cTuGoc.SoChungTu;
            hd.SoChungTu = Business.ChungTu.SoChungTu;

            DMKhoInfo khoXuat = DMKhoDataProvider.GetKhoByIdInfo(cTuGoc.IdKho);
            if (khoXuat != null)
            {
                hd.KhoXuat = khoXuat.MaKho;
            }

            DMKhoInfo khoNhap = DMKhoDataProvider.GetKhoByIdInfo(Business.ChungTu.IdKho);
            if (khoNhap != null)
            {
                hd.MaKhoNhapLai = khoNhap.MaKho;
                hd.TenKhoNhapLai = khoNhap.TenKho;
            }

            hd.LyDoNhapLai = lueLyDo.Text;
            hd.GhiChu = Business.ChungTu.GhiChu;
            hd.NhanVienKinhDoanh = cTuGoc.TenNhanVien;
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

        private void bteKhoXuat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteKhoXuatNhapLai_ButtonClick(sender, e, bteKhoXuat, -1, nguoiDung.IdNhanVien);
        }

        private void bteKhoXuat_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteKhoXuatNhapLai_KeyDown(sender, e, bteKhoXuat, -1, nguoiDung.IdNhanVien);
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

        private void grvHangBan_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle < 0) return;
            NhapHangTraChiTietHHInfor ct = (NhapHangTraChiTietHHInfor)grvHangBan.GetRow(e.RowHandle);
            if (ct != null && ct.GhiChu != null && (ct.GhiChu.Contains("Chưa") || ct.GhiChu.Contains("Không")))
            {
                if (e.Column.FieldName.Equals("GhiChu") || e.Column.FieldName.Equals("MaVach"))
                {
                    e.Appearance.BackColor = Color.Yellow;
                    e.Appearance.ForeColor = Color.Red;
                    e.Appearance.Font = new Font("Tahoma", 9, FontStyle.Bold);
                }
            }
        }
    }
}