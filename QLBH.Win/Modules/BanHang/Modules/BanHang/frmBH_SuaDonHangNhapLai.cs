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
    public partial class frmBH_SuaDonHangNhapLai : DevExpress.XtraEditors.XtraForm
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

        public frmBH_SuaDonHangNhapLai()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.Business = new DeNghiNhapLaiHangBussiness();
        }


        #region Actions
        private void setEDFunctions()
        {
            tsbEdit.Enabled = !Updating;
            tsbConfirm.Enabled = Updating;// || TrangThaiDonHang == (int)OrderStatus.PHAN_CONG_GIAO_NHAN;//xac nhan
            tsbPrint.Enabled = !Updating;
        }

        private void setEDItems()
        {
            bteKhoXuat.Enabled = false;
            txtSoPhieuNhap.Enabled = true;
            btnSearchPhieuNhap.Enabled = true;
            txtSoPhieuNhap.Enabled = true;
            txtGhiChu.Enabled = Updating;
            lueLyDo.Enabled = Updating;
            dteNgayNhap.Enabled = false;
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
            //UpdateChungTuDetails();
            //cap nhat chung tu
            Business.SaveChungTuHeader();

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

                Updating = false;
                setEDItems();
                setEDFunctions();
            }
            else
            {
                Updating = false;
                setEDItems();
                tsbEdit.Enabled = Updating;
                tsbConfirm.Enabled = Updating;
                tsbPrint.Enabled = Updating;
            }
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

        private void smiClose_Click(object sender, EventArgs e)
        {
            if (ctugoc != null)
            {
                CommonProvider.Instance.Lock_Unlock_ChungTu(ctugoc.IdChungTu, 0); //mo khoa chung tu
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
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

                    Updating = false;
                    setEDItems();
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
        #endregion

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            try
            {
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

        private void txtSoPhieuNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnSearchPhieuNhap_Click(sender, e);
            }
        }
    }
}