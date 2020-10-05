using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.TheThanhVien.Providers;
using QLBH.Common;
using QLBanHang.Modules.BanHang.Bussiness;
using QLBH.Common.Providers;
using QLBH.Core.Data;
using QLBH.Core.Exceptions;
using QLBH.Core.Providers;


namespace QLBanHang.Modules.BanHang
{
    public partial class frmChiTietYeuCauNhapLaiHangMua : DevExpress.XtraEditors.XtraForm
    {
        #region Declare

        //private int KeToan = 0;
        private int Draft = -1;
        private bool Updating = false;
        private int LoaiChungTu = (int) TransactionType.NHAPTRAHANGMUA;
        private int TrangThai = (int) OrderStatus.DE_NGHI_TRA_LAI_HANG_BAN;
        //private List<NhapHangTraMuaInfor> lst=new List<NhapHangTraMuaInfor>();
        //private List<NhapHangTraChiTietHHInfor> lstnt=new List<NhapHangTraChiTietHHInfor>();
        private List<NhapHangTraChiTietHHInfor> liChiTiet = new List<NhapHangTraChiTietHHInfor>();
        private objGridMarkSelection selector = new objGridMarkSelection();
        private DeNghiNhapLaiHangBussiness Business;
        protected NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int _IdKho = Declare.IdKho;
        private int _IdTrungTam = Declare.IdTrungTam;
        private ChungTuBanHangInfor ctugoc;


        #endregion

        public frmChiTietYeuCauNhapLaiHangMua()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.Business = new DeNghiNhapLaiHangBussiness();
        }

        public frmChiTietYeuCauNhapLaiHangMua(NhapHangTraMuaInfor ctu)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.Business = new DeNghiNhapLaiHangBussiness(ctu);
        }
        public frmChiTietYeuCauNhapLaiHangMua(ChungTuBanHangInfor ctu)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.Business = new DeNghiNhapLaiHangBussiness(ctu);
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

            btnSearchChungTu.Enabled = nguoiDung.SupperUser != 1 ? false : enable;
            //btnSearchPhieuNhap.Enabled = nguoiDung.SupperUser != 1 ? false : true;
            //btnTimOrderKH.Visible = false;
            Updating = nguoiDung.SupperUser != 1 ? false : enable;
            setEDItems();
        }
        #region Actions
        private void setEDFunctions()
        {
            tsbAdd.Enabled = !Updating;
            tsbEdit.Enabled = !Updating && (Draft != 0 || nguoiDung.SupperUser == 1) && TrangThai == (int)OrderStatus.DE_NGHI_TRA_LAI_HANG_BAN; 
            tsbUpdate.Enabled = Updating;
            tsbDelete.Enabled = TrangThai == (int) OrderStatus.DE_NGHI_TRA_LAI_HANG_BAN;
            tsbConfirm.Enabled = Updating;
            tsbPayment.Enabled = Updating;
            tsbPrint.Enabled = !Updating;
        }

        private void setEDItems()
        {
            //btnSearchPhieuNhap.Enabled = Updating && Business.ChungTu.IdChungTu == 0;
            btnSearchChungTu.Enabled = Updating;
            btnKiemTra.Enabled = Updating;
            dteNgayNhap.Enabled = false;

            //txtSoPhieuNhap.Properties.ReadOnly = !Updating;
            txtSoPhieuXuat.Properties.ReadOnly = !Updating;
            txtSoGiaoDich.Properties.ReadOnly = !Updating && Business.ChungTu.IdChungTu == 0;
            txtSoHoaDon.Properties.ReadOnly = !Updating;
            lueLyDo.Enabled = Updating;
            txtGhiChu.Enabled = Updating;
        }

        private void ResetAllText()
        {
            clsUtils.ResetAllText(this);
            Business = new DeNghiNhapLaiHangBussiness();
            //lst.Clear();
            //lstnt.Clear();
        }

        private void LoadGioiTinh()
        {
            cboGioiTinh.Properties.Items.Add("Nữ");
            cboGioiTinh.Properties.Items.Add("Nam");
        }

        //private void LoadTinh()
        //{
        //    List<DMTinhInfor> lsttinh = DMTinhDataProvider.Instance.GetListTinhInfors();
        //}

        //private void LoadHuyenGH(int idtinh)
        //{
        //    List<DMHuyenInfor> lsthuyen = DMHuyenDataProvider.Instance.GetListHuyenByTinhInfors(idtinh);
        //}

        //private void LoadHuyenDH(int idtinh)
        //{
        //    List<DMHuyenInfor> lsthuyen = DMHuyenDataProvider.Instance.GetListHuyenByTinhInfors(idtinh);
        //}

        //private void LoadLoaiHDThue()
        //{
        //    List<DMBangKeThueInfo> lstthue = DMBangKeThueDataProvider.Instance.GetListBangKeThueInfo();
        //}

        //private void LoadloaiHDBHang()
        //{
        //    lueHDBHang.Properties.DataSource = Common.GetListLoaiDonHang();
        //}

        //private void LoadCa()
        //{
        //    List<DmCaBanHangInfor> liCaBanHang = DMCaBanHangDataProvider.Instance.GetListCaBanHangInfors();
        //    for (int i = 0; i < liCaBanHang.Count; i++ )
        //        cboCaBanHang.Properties.Items.Add(liCaBanHang[i].CaBanHang);
        //}

        //private void LoadDuAn()
        //{
        //    List<DMDuAnInfor> lstdua = DMDuAnDataProvider.Instance.GetListDuAnInfo();
        //}

        private void LoadKho()
        {
            DMKhoInfo dmKho = DMKhoDataProvider.GetKhoByIdInfo(_IdKho);
            if (dmKho != null && dmKho.SuDung == 1)
            {
                bteKhoXuat.Text = dmKho.TenKho;
                bteKhoXuat.Tag = dmKho;
            }
        }

        private void LoadLyDo()
        {
            lueLyDo.Properties.DataSource = DMLyDoTraHangDataProvider.Instance.GetListLyDoTraHangInfo();
        }

        //Tìm kiếm phiếu xuất bán qua mã vạch(khuyến mãi or hàng mua)
        private void SearchByMaVach()
        {
            if (string.IsNullOrEmpty(txtMaVach.Text))
                throw new InvalidOperationException("Bạn chưa nhập mã vạch, không thể kiểm tra!");
            List<NhapHangTraMuaInfor> lst =
                NhapTraHangMuaDataProvider.Instance.SearchChungTuBanHangByMaVach(txtMaVach.Text.Trim());

            if (lst.Count == 1)
            {
                txtTenSanPham.Text = lst[0].TenSanPham;
                Business = new DeNghiNhapLaiHangBussiness(BanHangDataProvider.Instance.LoadChungTuById(lst[0].IdChungTu));
                
                if (Business.ChungTu.TrangThai == Convert.ToInt32(OrderStatus.TRA_LAI_DON_HANG_XUAT_KHO))
                    throw new ManagedException(String.Format("Đơn hàng {0} đã bị hủy.", Business.ChungTu.SoChungTu));

                if(BanHangDataProvider.Instance.ExistPhieuTraHangMua(Business.ChungTu.SoChungTu))
                    throw new ManagedException(String.Format("Đơn hàng {0} đã có phiếu trả lại hàng mua", Business.ChungTu.SoChungTu));

                LoadOldChungTuInfor(Business.ChungTu);
                //LoadChiTietThanhToan(Business.ChungTu.IdChungTu);
                Business.ChungTu.IdChungTu = 0;
            }
            else if (lst.Count > 1)
            {
                txtTenSanPham.Text = lst[0].TenSanPham;
                frmMutilPhieuXuatBan frm = new frmMutilPhieuXuatBan(lst);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    Business =
                    new DeNghiNhapLaiHangBussiness(BanHangDataProvider.Instance.LoadChungTuById(frm.SelectItem.IdChungTu)
                        );
                    
                    if (Business.ChungTu.TrangThai == Convert.ToInt32(OrderStatus.TRA_LAI_DON_HANG_XUAT_KHO))
                        throw new ManagedException(String.Format("Đơn hàng {0} đã bị hủy.", Business.ChungTu.SoChungTu));

                    if (BanHangDataProvider.Instance.ExistPhieuTraHangMua(Business.ChungTu.SoChungTu))
                        throw new ManagedException(String.Format("Đơn hàng {0} đã có phiếu trả lại hàng mua", Business.ChungTu.SoChungTu));

                    LoadOldChungTuInfor(Business.ChungTu);
                    //LoadChiTietThanhToan(Business.ChungTu.IdChungTu);
                    Business.ChungTu.IdChungTu = 0;
                }
            }
            else
                throw new InvalidOperationException("Mã vạch này không có!");
        }

        //fill dữ liệu vào control
        private void LoadOldChungTuInfor(ChungTuBanHangInfor lstHD)
        {
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
            txtSoDienThoai.Text = lstHD.DienThoai;

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
            txtTienTraKhach.Text = "0";
            txtTienNoKhach.Text = txtTienThucTra.Text;
        }

        private void LoadChungTuHeader()
        {
            Draft = Business.ChungTu.Draft;
            TrangThai = Business.ChungTu.TrangThai;
            LoaiChungTu = Business.ChungTu.LoaiChungTu;
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
            try
            {
                dteNgayLap.EditValue = Business.ChungTu.NgayHenGiaoHang;
            }
            catch (Exception)
            {
                dteNgayLap.EditValue = CommonProvider.Instance.GetSysDate();
            }
            try
            {
                dteNgayXuat.EditValue = Business.ChungTu.NgayGiaoHang;
            }
            catch (Exception)
            {
                dteNgayXuat.EditValue = CommonProvider.Instance.GetSysDate();
            }
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
                LoadChiTietThanhToan(Business.ChungTu.IdChungTu);
                //SearchBySoChungTuGoc(Business.ChungTu.SoChungTuGoc);
                if (Business.ChungTu.Draft == 0 || Business.ChungTu.TrangThai != (int)OrderStatus.DE_NGHI_TRA_LAI_HANG_BAN)
                {
                    Updating = false;
                    setEDFunctions();
                    setEDItems();
                }
            }
            else
            {
                ResetAllText();
            }
        }

        //Khi tìm kiếm phiếu nhập lại, sẽ search phiếu xuất bán thông qua số chứng từ gốc lưu trong phiếu nhập lại
        //private void SearchBySoChungTuGoc(string sochungtugoc)
        //{
        //    ChungTuBanHangInfor ct = NhapTraHangMuaDataProvider.Instance.SearchChungTuBanHangBySoCTGoc(sochungtugoc);
        //    LoadOldChungTuInfor(ct);
        //    //LoadChiTietThanhToan(ct.IdChungTu);
        //}

        //loai chi tiết hàng bán(hàng nhập lại)
        private void LoadOldChiTietHangBan(int idchungtu)
        {
            List<NhapHangTraChiTietHHInfor> lstnt = NhapTraHangMuaDataProvider.Instance.GetListAllChiTietHDByIdChungTu(idchungtu, 1);
            //NhapHangTraChiTietHHInfor ct = null;
            liChiTiet = new List<NhapHangTraChiTietHHInfor>();
            foreach (NhapHangTraChiTietHHInfor t in Business.ListChiTietChungTu)
            {
                if (t.SoLuong == 0) continue;
                t.SoLuongOld = t.SoLuong;
                if (t.ChietKhau == 1)
                {
                    t.GhiChu = "Không tính tồn (không phải xuất kho)";
                    liChiTiet.Add(t);
                }                    
                else
                {
                    foreach (NhapHangTraChiTietHHInfor cthh in lstnt)
                    {
                        if (cthh.IdSanPham != t.IdSanPham || cthh.SoLuong == 0) continue;
                        NhapHangTraChiTietHHInfor ct = liChiTiet.Find(delegate(NhapHangTraChiTietHHInfor m)
                                                                          {
                                                                              return m.IdSanPham == cthh.IdSanPham &&
                                                                                  m.IdSanPhamBan == t.IdSanPhamBan &&
                                                                                     m.MaVach.Equals(cthh.MaVach);
                                                                          });
                        if (ct == null)
                        {
                            ct = new NhapHangTraChiTietHHInfor(cthh);
                            ct.GhiChu = "Đã xuất kho";
                            ct.IdSanPhamBan = t.IdSanPhamBan;
                            //ct.ListIdChinhSach = t.ListIdChinhSach;
                            if (cthh.SoLuong <= t.SoLuong)
                            {
                                ct.SoLuong = cthh.SoLuong;
                                t.SoLuong -= cthh.SoLuong;
                                cthh.SoLuong = 0;
                            }
                            else
                            {
                                ct.SoLuong = t.SoLuong;
                                cthh.SoLuong -= t.SoLuong;
                                t.SoLuong -= t.SoLuong;
                            }

                            ct.DonGia = t.DonGia;
                            ct.DonGiaCoVat = t.DonGiaCoVat;
                            ct.TyleChietKhau = t.TyleChietKhau;
                            ct.TienChietKhau = t.TienChietKhau * ct.SoLuong / t.SoLuongOld;
                            ct.TienSauChietKhau = t.TienSauChietKhau * ct.SoLuong / t.SoLuongOld;
                            ct.TyleVAT = t.TyleVAT;
                            ct.TienVAT = t.TienVAT * ct.SoLuong / t.SoLuongOld;
                            ct.ThanhTien = t.ThanhTien * ct.SoLuong / t.SoLuongOld;
                            ct.GiaTheoBangGia = t.GiaTheoBangGia;
                            ct.GiaNiemYet = t.GiaNiemYet;
                            ct.GiaWebSite = t.GiaWebSite;
                            ct.LoaiHangKem = t.LoaiHangKem;
                            ct.TyLePhanBo = t.TyLePhanBo;
                            ct.TyLeThanhToan = t.TyLeThanhToan;
                            ct.TyleThuong = t.TyleThuong;
                            ct.ThuongNong = t.ThuongNong;
                            liChiTiet.Add(ct);                            
                        }
                        else
                        {
                            if (cthh.SoLuong <= t.SoLuong)
                            {
                                ct.SoLuong += cthh.SoLuong;
                                t.SoLuong -= cthh.SoLuong;
                                cthh.SoLuong = 0;
                            }
                            else
                            {
                                ct.SoLuong += t.SoLuong;
                                cthh.SoLuong -= t.SoLuong;
                                t.SoLuong -= t.SoLuong;
                            }

                            ct.TienChietKhau = t.TienChietKhau * ct.SoLuong / t.SoLuongOld;
                            ct.TienSauChietKhau = t.TienSauChietKhau * ct.SoLuong / t.SoLuongOld;
                            ct.TienVAT = t.TienVAT * ct.SoLuong / t.SoLuongOld;
                            ct.ThanhTien = t.ThanhTien * ct.SoLuong / t.SoLuongOld;
                        }
                        if (t.SoLuong == 0) break;
                    }
                    if (t.SoLuong > 0)
                    {
                        t.GhiChu = "Chưa xuất kho";
                        t.TienChietKhau = t.TienChietKhau * t.SoLuong / t.SoLuongOld;
                        t.TienSauChietKhau = t.TienSauChietKhau * t.SoLuong / t.SoLuongOld;
                        t.TienVAT = t.TienVAT * t.SoLuong / t.SoLuongOld;
                        t.ThanhTien = t.ThanhTien * t.SoLuong / t.SoLuongOld;

                        liChiTiet.Add(t);
                    }
                }
            }
                
            //foreach (NhapHangTraChiTietHHInfor ctn in lstnt)
            //{
            //    ct = Business.ListChiTietChungTu.Find(
            //        delegate(NhapHangTraChiTietHHInfor t)
            //            {
            //                return t.IdSanPham == ctn.IdSanPham && t.IdSanPhamBan == 0;
            //            });
            //    if (ct != null)
            //    {
            //        ct.MaVach = ctn.MaVach;
            //        ct.GhiChu = "Đã xuất kho";
            //    }
            //    else
            //    {
            //        ct = Business.ListChiTietChungTu.Find(
            //            delegate(NhapHangTraChiTietHHInfor t)
            //            {
            //                return t.IdSanPham == ctn.IdSanPham && t.IdSanPhamBan != 0 && t.LoaiHangKem == 1;
            //            });
            //        if (ct != null)
            //        {
            //            ct.MaVach = ctn.MaVach;
            //            ct.GhiChu = "Đã xuất kho";
            //        }
            //        else
            //        {
            //            ct = Business.ListChiTietChungTu.Find(
            //                delegate(NhapHangTraChiTietHHInfor t)
            //                {
            //                    return t.IdSanPham == ctn.IdSanPham && t.IdSanPhamBan != 0 && t.LoaiHangKem == 0;
            //                });
            //            if (ct != null)
            //            {
            //                ct.MaVach = ctn.MaVach;
            //                ct.GhiChu = "Đã xuất kho";
            //            }
            //        }
            //    }
            //}
            grcHangBan.DataSource = null;
            grcHangBan.DataSource = new BindingList<NhapHangTraChiTietHHInfor>(liChiTiet);
        }

        private void LoadChiTietHangBan()
        {
            liChiTiet = new List<NhapHangTraChiTietHHInfor>();
            liChiTiet.AddRange(Business.ListChiTietChungTu);
            grcHangBan.DataSource = null;
            grcHangBan.DataSource = new BindingList<NhapHangTraChiTietHHInfor>(liChiTiet);
        }
        //load thanh toán phiếu xuất bán
        private void LoadChiTietThanhToan(int idchungtu)
        {
            List<ChungTuThanhToanInfor> lsttt = ThanhToanDataProvider.Instance.LoadAllThanhToanByCTu(idchungtu);
            gHinhThucThanhToan.DataSource = null;
            gHinhThucThanhToan.DataSource = lsttt;
        }

        private bool CheckException()
        {
            if (bteKhoXuat.Tag == null)
            {
                MessageBox.Show("Bạn chưa chọn kho nhập lại!");
                bteKhoXuat.Focus();
                return false;
            }

            if(String.IsNullOrEmpty(txtSoGiaoDich.Text))
            {
                MessageBox.Show("Bạn chưa chọn đơn hàng nhập lại!");
                txtSoGiaoDich.Focus();
                return false;
            }

            if(ctugoc != null && ctugoc.SoChungTu != txtSoGiaoDich.Text)
            {
                MessageBox.Show("Số chứng từ gốc mới thay đổi, bạn cần nạp lại chứng từ gốc!");
                txtSoGiaoDich.Focus();
                return false;                
            }

            ChungTuBanHangInfor ctugoc1 = BanHangDataProvider.Instance.LoadChungTuBySoChungTu(txtSoGiaoDich.Text, -2);

            if (ctugoc1 == null)
            {
                MessageBox.Show(String.Format("Không tồn tại đơn hàng {0}!", txtSoGiaoDich.Text));
                txtSoGiaoDich.Focus();
                return false;
            }

            if (!CommonProvider.Instance.Check_Lock_ChungTu(ctugoc1.IdChungTu))
            {
                MessageBox.Show("Đơn hàng đang được mở bởi 1 người khác. Bạn không thể thay đổi trạng thái được!");
                return false;
            }

            if (DMTrungTamDataProvider.Instance.IsCrossedOU(ctugoc1.IdTrungTam, ((DMKhoInfo)bteKhoXuat.Tag).IdTrungTam))
            {
                MessageBox.Show("Đơn hàng không cùng chi nhánh với kho nhập lại!");
                return false;
            }

            if (ctugoc1.TrangThai != (int)OrderStatus.XUAT_KHO && ctugoc1.TrangThai != (int)OrderStatus.DANG_XUAT_KHO)
            {
                MessageBox.Show("Đơn hàng không ở trạng thái xuất hoặc đang xuất nên không thể trả lại được!");
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
            //foreach (NhapHangTraChiTietHHInfor item in lstnt)
            //{
            //    if (item.DaTra > 0)
            //    {
            //        MessageBox.Show(string.Format("Mã vạch [{0}]đã trả , không thể trả tiếp!", item.MaVach));
            //        lueLyDo.Focus();
            //        return false;
            //    }
            //}
            if (ctugoc1.TrangThai != (int)OrderStatus.XUAT_KHO && ctugoc1.IdKho != ((DMKhoInfo)bteKhoXuat.Tag).IdKho)
            {
                MessageBox.Show("Đơn hàng chưa xuất hết nên hệ thống yêu cầu kho nhập lại phải trùng với kho xuất.\nVui lòng chọn lại đúng kho nhập!");
                bteKhoXuat.Focus();
                return false;                
            }

            if (!ctugoc1.SoChungTu.Equals(Business.ChungTu.SoChungTu))
            {
                MessageBox.Show("Số giao dịch không khớp với đơn hàng gốc chứa mã vạch cần trả!");
                txtSoGiaoDich.Text = Business.ChungTu.SoChungTu;
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

        //save đề nghị nhập lại, trừ tổn ảo
        private void UpdateChungTuHeader()
        {
            Business.ChungTu.Draft = Draft;
            Business.ChungTu.LoaiChungTu = LoaiChungTu;
            Business.ChungTu.TrangThai = TrangThai;
            Business.ChungTu.SoChungTu = txtSoPhieuNhap.Text.Trim().ToUpper();
            Business.ChungTu.SoChungTuGoc = txtSoGiaoDich.Text.Trim().ToUpper();
            Business.ChungTu.IdTrungTam = _IdTrungTam;
            Business.ChungTu.IdKho = ((DMKhoInfo)bteKhoXuat.Tag).IdKho;
            Business.ChungTu.IdTruongCa = nguoiDung.IdNhanVien;
            Business.ChungTu.IdLyDoGiaoDich = Common.IntValue(lueLyDo.EditValue);
            Business.ChungTu.OrderType = Declare.OrderTypeTraLai;
            Business.ChungTu.NgayLap = Convert.ToDateTime(dteNgayNhap.EditValue);
            Business.ChungTu.GhiChu = txtGhiChu.Text;

            Business.ChungTu.SoPhieuXuat = txtSoPhieuXuat.Text.Trim();
            Business.ChungTu.SoSeri = txtSoHoaDon.Text.Trim();
            Business.ChungTu.KyHieu = txtKiHieu.Text.Trim();
            Business.ChungTu.IdDoiTuong = (txtKhachHang.Tag != null
                                               ? ((DMDoiTuongInfo)txtKhachHang.Tag).IdDoiTuong
                                               : 0);
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
            Business.ChungTu.TongTienThanhToan = Common.DoubleValue(txtTienThucTra.Text);
            Business.ChungTu.TienThanhToanThuc = 0;
            Business.ChungTu.TienConNo = Business.ChungTu.TongTienThanhToan;            
        }
        private void UpdateChungTuDetails()
        {
            if (Business.ChungTu.IdChungTu == 0)
            {
                Business.ChungTu.NguoiTao = nguoiDung.TenDangNhap;
                Business.ChungTu.TenMayTao = Declare.TenMay;
                Business.ChungTu.NguoiSua = nguoiDung.TenDangNhap;
                Business.ChungTu.TenMaySua = Declare.TenMay;
                Business.ChungTu.NgayLap = CommonProvider.Instance.GetSysDate();

                Business.ListChiTietChungTu.Clear();
                foreach (NhapHangTraChiTietHHInfor pt in liChiTiet)
                {                    
                    pt.IdChungTuChiTiet = 0;
                    pt.IdChungTu = 0;
                    Business.ListChiTietChungTu.Add(pt);
                }
            }
            else
            {
                Business.ChungTu.NguoiSua = nguoiDung.TenDangNhap;
                Business.ChungTu.TenMaySua = Declare.TenMay;
            }

            //foreach (NhapHangTraChiTietHHInfor pt in lstnt)
            //{
            //    if (!Business.ListChiTietChungTu.Exists(delegate(NhapHangTraChiTietHHInfor math)
            //    {
            //        return math.IdSanPham == pt.IdSanPham;
            //    }))
            //    {
            //        pt.IdChungTuChiTiet = 0;
            //        pt.IdChungTu = Business.ChungTu.IdChungTu;
            //        Business.ListChiTietChungTu.Add(pt);
            //    }
            //    else
            //    {
            //        if (!Business.ListChiTietChungTu.Exists(delegate(NhapHangTraChiTietHHInfor math)
            //        {
            //            return math.MaVach == pt.MaVach;
            //        }))
            //        {
            //            pt.IdChungTuChiTiet = 0;
            //            pt.IdChungTu = Business.ChungTu.IdChungTu;
            //            Business.ListChiTietChungTu.Add(pt);
            //        }
            //    }
            //}
        }
        private void UpdateChungTu()
        {
            //double tongTienOld = Business.ChungTu.TongTienThanhToan;
            //double tienNoOld = Business.ChungTu.TienConNo;

            //update header
            UpdateChungTuHeader();
            //update detail
            UpdateChungTuDetails();
            //cap nhat chung tu
            Business.SaveChungTu();

            //BanHangDataProvider.Instance.UpdateCongNoKhachHang(Business.ChungTu.IdKhachLe,
            //                                                   Business.ChungTu.IdDoiTuong,
            //                                                   Business.ChungTu.TongTienThanhToan,
            //                                                   Business.ChungTu.TienConNo, tongTienOld,
            //                                                   tienNoOld, Business.ChungTu.LoaiChungTu);
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
                    setEDItems();
                    setEDFunctions();
                }
                //txtSoPhieuNhap.Enabled = false;
            }
            else
            {
                smiNew_Click(sender, e);
            }
            txtMaVach.Focus();
            txtMaVach.SelectAll();
        }

        private void frmChiTietYeuCauNhapLaiHangMua_Closing(object sender, CancelEventArgs e)
        {
            if (ctugoc != null)
            {
                CommonProvider.Instance.Lock_Unlock_ChungTu(ctugoc.IdChungTu, 0); //mo khoa chung tu
            }
        }

        private void frmChiTietYeuCauNhapLaiHangMua_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            try
            {
                SearchByMaVach();
            }
            catch(Exception ex)
            {
#if DEBUG
                clsUtils.MsgCanhBao(ex.ToString());
#else
                clsUtils.MsgCanhBao(ex.Message);
#endif
            }
        }

        private void btnSearchChungTu_Click(object sender, EventArgs e)
        {
            try
            {
                if (ctugoc != null && ctugoc.SoChungTu != txtSoGiaoDich.Text)
                {
                    CommonProvider.Instance.Lock_Unlock_ChungTu(ctugoc, 0);

                    ctugoc = null;
                }

                if (!string.IsNullOrEmpty(txtSoGiaoDich.Text))
                {
                    ctugoc =
                        NhapTraHangMuaDataProvider.Instance.SearchChungTuBanHangChuaTLBySoPhieu(Business.ChungTu.IdChungTu,
                                                                                                txtSoGiaoDich.Text.Trim());
                    if (ctugoc != null)
                    {
                        if (!CommonProvider.Instance.Check_Lock_ChungTu(ctugoc.IdChungTu))
                        {
                            MessageBox.Show("Đơn hàng đang được mở bởi 1 người khác. Bạn không thể thay đổi trạng thái được!");
                            return;
                        }

                        if (ctugoc.TrangThai != (int)OrderStatus.DANG_XUAT_KHO && ctugoc.TrangThai != (int)OrderStatus.XUAT_KHO)
                        {
                            MessageBox.Show("Đơn hàng chưa xuất kho. Không thể thực hiện được!!!\nPhải sử dụng nghiệp vụ nhập lại đơn hàng chưa xuất kho.");
                            return;
                        }

                        if (!CommonProvider.Instance.Lock_Unlock_ChungTu(ctugoc, 1))
                        {
                            MessageBox.Show("Đơn hàng đang được mở bởi 1 người khác. Bạn không thể thay đổi trạng thái được!");
                            return;
                        }

                        Business = new DeNghiNhapLaiHangBussiness((ChungTuBanHangInfor) ctugoc.Clone());
                        LoadOldChungTuInfor(Business.ChungTu);
                        //LoadChiTietThanhToan(Business.ChungTu.IdChungTu);
                        LoadOldChiTietHangBan(Business.ChungTu.IdChungTu);
                        Business.ChungTu.IdChungTu = 0;
                    }
                    else
                    {
                        MessageBox.Show("Chứng từ không hợp lệ");
                    }
                }
            }
            catch (ManagedException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                EventLogProvider.Instance.WriteOfflineLog(ex.ToString());

                MessageBox.Show(ex.Message);
#endif
            }
        }

        private void smiNew_Click(object sender, EventArgs e)
        {
            Updating = true;
            Draft = -1;
            
            ResetAllText();
            txtSoPhieuNhap.Prefix = Declare.Prefix.PhieuTraHangBan;
            txtSoPhieuNhap.ReSet();//.Text = CommonProvider.Instance.GetSoPhieu(Declare.Prefix.PhieuTraHangBan);
            dteNgayNhap.EditValue = CommonProvider.Instance.GetSysDate();
            LoadKho();

            setEDFunctions();
            setEDItems();
        }

        private void smiClose_Click(object sender, EventArgs e)
        {
            if (ctugoc != null)
            {
                CommonProvider.Instance.Lock_Unlock_ChungTu(ctugoc.IdChungTu, 0); //mo khoa chung tu
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void smiSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckException())
                {
                    ConnectionUtil.Instance.BeginTransaction();
                    Draft = 1;
                    UpdateChungTu();
                    ConnectionUtil.Instance.CommitTransaction();
                    Updating = false;
                    setEDFunctions();
                    setEDItems();
                    clsUtils.MsgThongBao(Declare.msgUpdateSucc);                    
                }
            }
            catch(ManagedException ex)
            {
                ConnectionUtil.Instance.RollbackTransaction();
                this.Close();
                MessageBox.Show(ex.Message);
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
                clsUtils.MsgCanhBao(new ManagedException(ex.Message, true).Message);
#else
                clsUtils.MsgCanhBao(new ManagedException(ex.Message).Message);
#endif
            }
        }

        private void smiComfim_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckException())
                {
                    ConnectionUtil.Instance.BeginTransaction();
                    Draft = 0;
                    UpdateChungTu();
                    ConnectionUtil.Instance.CommitTransaction();
                    Updating = false;
                    setEDFunctions();
                    setEDItems();
                    clsUtils.MsgThongBao(Declare.msgUpdateSucc);
                }
            }
            catch (ManagedException ex)
            {
                ConnectionUtil.Instance.RollbackTransaction();
                MessageBox.Show(ex.Message);
                this.Close();
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
                clsUtils.MsgCanhBao(new ManagedException(ex.Message, true).Message);
#else
                clsUtils.MsgCanhBao(new ManagedException(ex.Message).Message);
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
                    Business = new DeNghiNhapLaiHangBussiness(ct);
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

        private void grvHangBan_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //if(e.Column==colSoLuongTraBan)
            //{
            //    NhapHangTraChiTietHHInfor item = (NhapHangTraChiTietHHInfor)grvHangBan.GetRow(e.RowHandle);
            //    if (lstnt[lstnt.IndexOf(item)].SoLuong != item.SoLuongTra)
            //    {
            //        throw new InvalidOperationException("Số lượng trả phải đúng như số lượng mua!");
            //    }
            //}
            //if(e.Column.FieldName =="CheckMarkSelection")
            //{
            //    try
            //    {
            //        NhapHangTraChiTietHHInfor item = (NhapHangTraChiTietHHInfor)grvHangBan.GetRow(e.RowHandle);                    
            //    }
            //    catch (Exception ex)
            //    {
            //        clsUtils.MsgCanhBao(ex.Message);
            //    }
            //    grcHangBan.RefreshDataSource();
            //    selector.View = grvHangBan;
            //}
        }
        private bool ValidDeleteChungTu()
        {
            if (Business.ChungTu.IdChungTu > 0 && Business.ChungTu.TrangThai != (int)OrderStatus.DE_NGHI_TRA_LAI_HANG_BAN)//bang gia da xac nhan            
            {
                MessageBox.Show("Đơn hàng đã thay đổi trạng thái, không thể xóa được");
                return false;
            }
            return true;
        }
        private void smiDelete_Click(object sender, EventArgs e)
        {
            if (ValidDeleteChungTu())
            {
                DeleteChungTu();
            }
            Updating = false;
            setEDItems();
            setEDFunctions();
        }

        private void DeleteChungTu()
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn hủy đơn hàng này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ConnectionUtil.Instance.BeginTransaction();
                    Business.DeleteChungTu();
                    //if (Business.ChungTu.IdChungTu > 0)
                    //{
                    //    if (Draft == 1 && Business.ChungTu.TrangThai == (int)OrderStatus.DE_NGHI_TRA_LAI_HANG_BAN)
                    //        Business.DeleteChungTu();//xoa chung tu neu chua xuat
                    //    else
                    //    {
                    //        //restore trang thai don hang cu
                    //        Business.ChungTu.TrangThai = (int) OrderStatus.HUY_DE_NGHI_TRA_LAI;
                    //        Business.ChungTu.Draft = 0;
                    //        Business.CancelChungTu();
                    //    }
                    //}
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

        #endregion
        private bool ValidEditChungTu()
        {
            if (Business.ChungTu.IdChungTu > 0 && (Business.ChungTu.Draft == 0 && nguoiDung.SupperUser != 1 || Business.ChungTu.TrangThai != (int)OrderStatus.DE_NGHI_TRA_LAI_HANG_BAN))//bang gia da xac nhan
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
            if (grvHangBan.RowCount == 0)
            {
                MessageBox.Show("Không có dữ liệu!");
                return;
            }
            InDonHangTraLai();
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
        private void bteKhoXuat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteKhoXuatNhapLai_ButtonClick(sender, e, bteKhoXuat,
                nguoiDung.IsOnline ? Declare.IdTrungTam : -1,
                //nguoiDung.IsKinhDoanhThiTruong || nguoiDung.IsOnline ? -1 : Declare.IdTrungTam, 
                nguoiDung.IdNhanVien);
        }

        private void bteKhoXuat_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteKhoXuatNhapLai_KeyDown(sender, e, bteKhoXuat,
                nguoiDung.IsOnline ? Declare.IdTrungTam : -1,
                //nguoiDung.IsKinhDoanhThiTruong || nguoiDung.IsOnline ? -1 : Declare.IdTrungTam, 
                nguoiDung.IdNhanVien);
        }

        private void bteKhoXuat_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteKhoXuat);
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