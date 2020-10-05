using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;
using QLBanHang.Modules.BanHang.Bussiness;
using QLBH.Common.Providers;
using QLBH.Core.Data;
using QLBH.Core.Providers;
using QLBanHang.Modules.DanhMuc;


namespace QLBanHang.Modules.BanHang
{
    public partial class frmChiTietYeuCauNhapLaiKhac : DevExpress.XtraEditors.XtraForm
    {
        #region Declare

        //private int KeToan = 0;
        private int Draft = -1;
        private bool Updating = false;
        private int LoaiChungTu = (int) TransactionType.DON_HANG_NHAP_LAI;
        private int TrangThai = (int) OrderStatus.DE_NGHI_TRA_LAI_HANG_BAN;
        //private List<NhapHangTraMuaInfor> lst = new List<NhapHangTraMuaInfor>();
        //private List<NhapHangTraChiTietHHInfor> lstnt = new List<NhapHangTraChiTietHHInfor>();
        private objGridMarkSelection selector = new objGridMarkSelection();
        private DeNghiNhapLaiHangBussiness Business;
        protected NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int _IdKho = Declare.IdKho;
        private int _IdTrungTam = Declare.IdTrungTam;
        //private double TongTienThanhToan = 0;
        //private double TienThucTra = 0;
        //private double TienTraKhach = 0;
        //private double TienNoKhach = 0;

        #endregion

        public frmChiTietYeuCauNhapLaiKhac()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.Business = new DeNghiNhapLaiHangBussiness(LoaiChungTu, nguoiDung.IdNhanVien, _IdKho);
        }

        public frmChiTietYeuCauNhapLaiKhac(NhapHangTraMuaInfor ctu)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.Business = new DeNghiNhapLaiHangBussiness(ctu);
        }
        public frmChiTietYeuCauNhapLaiKhac(ChungTuBanHangInfor ctu)
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

            //btnSearchPhieuNhap.Enabled = nguoiDung.SupperUser != 1 ? false : true;
            //btnTimOrderKH.Visible = false;
            Updating = nguoiDung.SupperUser != 1 ? false : enable;
            setEDItems();
        }
        #region Actions
        private void setEDFunctions()
        {
            tsbAdd.Enabled = !Updating;
            tsbEdit.Enabled = !Updating && Draft != 0 && TrangThai == (int)OrderStatus.DE_NGHI_TRA_LAI_HANG_BAN; 
            tsbUpdate.Enabled = Updating;
            tsbDelete.Enabled = TrangThai == (int) OrderStatus.DE_NGHI_TRA_LAI_HANG_BAN;
            tsbConfirm.Enabled = Updating;
            tsbPayment.Enabled = Updating;
            tsbPrint.Enabled = !Updating;
        }

        private void setEDItems()
        {
            //btnSearchPhieuNhap.Enabled = Updating;
            btnKiemTra.Enabled = Updating;
            //txtSoPhieuNhap.Properties.ReadOnly = !Updating;
            txtSoPhieuXuat.Properties.ReadOnly = !Updating;
            txtSoGiaoDich.Properties.ReadOnly = !Updating;
            txtSoHoaDon.Properties.ReadOnly = !Updating;

            bteKhoXuat.Enabled = Updating;
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
            txtKiHieu.Enabled = Updating;
            bteThuongVien.Enabled = Updating;
            txtMaSanPham.Enabled = Updating;
            bteKhachLe.Enabled = Updating;
            txtCongTy.Enabled = Updating;
            txtTenDoiTuong.Enabled = Updating;
            cboGioiTinh.Enabled = Updating;
            txtCMND.Enabled = Updating;
            txtSoDienThoai.Enabled = Updating;
            txtEmail.Enabled = Updating;
            txtDiaChiHD.Enabled = Updating;
            txtDiaChiGH.Enabled = Updating;
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
            //for (int i = 0; i < liCaBanHang.Count; i++ )
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

        private void SearchByMaVach()
        {
            DMSanPhamBriefInfo spb = null;
            if (!string.IsNullOrEmpty(txtMaSanPham.Text))
                spb = QLBanHang.Modules.DanhMuc.Providers.DmSanPhamProvider.GetSanPhamBriefByNSDMa(txtMaSanPham.Text.Trim(),
                                                                             (nguoiDung.SupperUser == 1
                                                                                  ? -1
                                                                                  : nguoiDung.IdNhomNguoiDung));
            if (spb == null)
            {
                frmLookUp_HangHoa frm = new frmLookUp_HangHoa(false,
                                                              (Common.Int2Bool(nguoiDung.SupperUser)
                                                                   ? -1
                                                                   : nguoiDung.IdNhomNguoiDung), 1, -1,
                                                              -1, -1);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    spb = frm.SelectedItem;
                }
            }

            if (spb == null) return;
            txtTenSanPham.Text = spb.TenSanPham;
            NhapHangTraChiTietHHInfor ctu = Business.ListChiTietChungTu.Find(delegate(NhapHangTraChiTietHHInfor match)
                                            { return match.MaSanPham == spb.MaSanPham && spb.TrungMaVach == 1; });
            if (ctu != null)
            {
                ctu.SoLuong += 1;
                ctu.SoLuongTra += 1;
                ((BindingList<NhapHangTraChiTietHHInfor>)grcHangBan.DataSource).ResetBindings();
            }
            else
            {
                ctu = new NhapHangTraChiTietHHInfor(spb);
                ctu.IdChungTu = Business.ChungTu.IdChungTu;
                ((BindingList<NhapHangTraChiTietHHInfor>)grcHangBan.DataSource).Add(ctu);
                ((BindingList<NhapHangTraChiTietHHInfor>)grcHangBan.DataSource).ResetBindings();
            }
            //UpdateSummariesInfors();
        }

        private void LoadChungTuInstance()
        {
            if (Business.ChungTu.IdChungTu != 0)
            {
                LoadChungTuHeader();
                LoadChiTietHangBan();
                LoadChiTietThanhToan(Business.ChungTu.IdChungTu);
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

        //loai chi tiết hàng bán(hàng nhập lại)
        private void LoadChiTietHangBan()
        {
            //lstnt.Clear();
            //lstnt = NhapTraHangMuaDataProvider.Instance.GetListAllChiTietHDByIdChungTu(idchungtu, loai);
            grcHangBan.DataSource = null;
            grcHangBan.DataSource = new BindingList<NhapHangTraChiTietHHInfor>(Business.ListChiTietChungTu);
            ////selector.View = grvHangBan;
            //if(loai==0)
            //{
            //    foreach (NhapHangTraChiTietHHInfor pt in lstnt)
            //    {
            //        selector.selection.Add(pt);
            //    }
            //}
            //UpdateSummariesInfors();
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
            foreach (NhapHangTraChiTietHHInfor item in Business.ListChiTietChungTu)
            {
                if (item.DaTra > 0)
                {
                    MessageBox.Show(string.Format("Mã vạch [{0}]đã trả , không thể trả tiếp!", item.MaVach));
                    lueLyDo.Focus();
                    return false;
                }
            }
            if (bteKhoXuat.Tag == null)
            {
                MessageBox.Show("Bạn chưa chọn kho nhập lại!");
                bteKhoXuat.Focus();
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
            if (this.txtKhachHang.Tag == null)
            {
                MessageBox.Show("Chưa chọn khách hàng." + "\nHãy chọn khách hàng", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtKhachHang.Focus();
                return false;
            }

            foreach (NhapHangTraChiTietHHInfor ct in Business.ListChiTietChungTu)
            {
                if (String.IsNullOrEmpty(ct.MaVach))
                {
                    MessageBox.Show(String.Format("Sản phẩm [{0} - {1}] chưa nhập mã vạch", ct.MaSanPham, ct.TenSanPham));
                    return false;
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

                foreach (NhapHangTraChiTietHHInfor pt in Business.ListChiTietChungTu)
                {
                    pt.IdChungTu = 0;
                }
            }
            else
            {
                Business.ChungTu.NguoiSua = nguoiDung.TenDangNhap;
                Business.ChungTu.TenMaySua = Declare.TenMay;
            }

            //foreach (NhapHangTraChiTietHHInfor pt in Business.ListChiTietChungTu)
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
            txtMaSanPham.Focus();
            txtMaSanPham.SelectAll();
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

        private void smiNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (bteKhoXuat.Tag == null)
                {
                    MessageBox.Show("Chưa chọn kho nhập lại");
                }
                ThemMoiDonHang();

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
        private void ThemMoiDonHang()
        {
            Draft = -1;

            ResetAllText();
            txtSoPhieuNhap.Prefix = Declare.Prefix.PhieuNhapLaiKhac;
            txtSoPhieuNhap.ReSet();//.Text = CommonProvider.Instance.GetSoPhieu(Declare.Prefix.PhieuNhapLaiKhac);
            dteNgayNhap.EditValue = CommonProvider.Instance.GetSysDate();

            LoaiChungTu = (int)TransactionType.DON_HANG_NHAP_LAI;
            TrangThai = (int)OrderStatus.DE_NGHI_TRA_LAI_HANG_BAN;
            Business = new DeNghiNhapLaiHangBussiness(LoaiChungTu, nguoiDung.IdNhanVien, ((DMKhoInfo)bteKhoXuat.Tag).IdKho);

            Business.ListChiTietChungTu = new List<NhapHangTraChiTietHHInfor>(); 

            grcHangBan.DataSource = null;
            grcHangBan.DataSource = new BindingList<NhapHangTraChiTietHHInfor>(Business.ListChiTietChungTu);           
        }

        private void smiClose_Click(object sender, EventArgs e)
        {
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
            if (Business.ChungTu.IdChungTu > 0 && Business.ChungTu.TrangThai != (int)OrderStatus.DE_NGHI_TRA_LAI_HANG_BAN)// && !CommonFuns.IsEditChungTu())//bang gia da xac nhan            
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
            if (Business.ChungTu.IdChungTu > 0 && (Business.ChungTu.Draft == 0 || Business.ChungTu.TrangThai != (int)OrderStatus.DE_NGHI_TRA_LAI_HANG_BAN))//bang gia da xac nhan
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
        private void txtMaSanPham_Enter(object sender, EventArgs e)
        {
            this.txtMaSanPham.Focus();
            this.txtMaSanPham.SelectAll();
        }

        private void txtMaSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SearchByMaVach();
            }
        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng hàng này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    grvHangBan.DeleteSelectedRows();

                    //UpdateSummariesInfors();
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

        private void grvHangBan_ShowingEditor(object sender, CancelEventArgs e)
        {
            try
            {
                if (grvHangBan.FocusedColumn.FieldName == "SoLuong")
                {
                    NhapHangTraChiTietHHInfor ct =
                        (NhapHangTraChiTietHHInfor) grvHangBan.GetRow(grvHangBan.FocusedRowHandle);
                    if (ct != null && ct.TrungMaVach == 0)
                        e.Cancel = true;
                }
            }
            catch
            {
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
    }
}