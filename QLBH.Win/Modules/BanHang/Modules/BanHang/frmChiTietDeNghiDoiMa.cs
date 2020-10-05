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
    public partial class frmChiTietDeNghiDoiMa : DevExpress.XtraEditors.XtraForm
    {
        #region Declare
        private int Draft = -1;
        private int LoaiChungTu = (int) TransactionType.DOIMAHANGMUA;
        private int TrangThai = (int) OrderStatus.DE_NGHI_DOI_MA_VACH;
        private bool Updating = false;
        //private List<BHangDoiMaChiTietHHInfor> lstnt = new List<BHangDoiMaChiTietHHInfor>();
        private List<BHangDoiMaChiTietHHInfor> liChiTiet = new List<BHangDoiMaChiTietHHInfor>();
        private objGridMarkSelection selector = new objGridMarkSelection();
        private DoiMaBussiness Business;
        protected NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int _IdKho = Declare.IdKho;
        private int _IdTrungTam = Declare.IdTrungTam;
        private ChungTuBanHangInfor lockInfo;

        #endregion
        public frmChiTietDeNghiDoiMa()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            Business = new DoiMaBussiness();
        }

        public frmChiTietDeNghiDoiMa(BHangDoiMaInfor ctu)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.Business = new DoiMaBussiness(ctu);
        }
        public frmChiTietDeNghiDoiMa(ChungTuBanHangInfor ctu)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.Business = new DoiMaBussiness(ctu);
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
            tsbEdit.Enabled = !Updating && Draft != 0 && TrangThai == (int) OrderStatus.DE_NGHI_DOI_MA_VACH;
            tsbUpdate.Enabled = Updating;
            tsbDelete.Enabled = TrangThai == (int)OrderStatus.DE_NGHI_DOI_MA_VACH;
            tsbConfirm.Enabled = Updating;
            tsbPayment.Enabled = Updating;
            tsbPrint.Enabled = !Updating && Business.ChungTu.IdChungTu > 0;
        }

        private void setEDItems()
        {
            //btnSearchPhieuNhap.Enabled = Updating;
            btnSearchChungTu.Enabled = Updating;
            btnKiemTra.Enabled = Updating;
            dteNgayNhap.Enabled = false;
            //txtSoPhieuNhap.Properties = !Updating;
            txtSoPhieuXuat.Properties.ReadOnly = !Updating;
            txtSoGiaoDich.Properties.ReadOnly = !Updating;
            txtSoHoaDon.Properties.ReadOnly = !Updating;
            lueLyDo.Enabled = Updating;
            txtGhiChu.Enabled = Updating;
        }
        private void ResetAllText()
        {
            clsUtils.ResetAllText(this);
            Business = new DoiMaBussiness();
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
            lueLyDo.EditValue = 8;//No reason
        }

        private void LoadGioiTinh()
        {
            cboGioiTinh.Properties.Items.Add("Nữ");
            cboGioiTinh.Properties.Items.Add("Nam");
        }

        //Tìm kiếm phiếu xuất bán qua mã vạch(khuyến mãi or hàng mua)
        private void SearchByMaVach()
        {
            if (string.IsNullOrEmpty(txtMaVach.Text))
                throw new InvalidOperationException("Bạn chưa nhập mã vạch, không thể kiểm tra!");
            List<BHangDoiMaInfor> lst = 
                BHangDoiMaDataProvider.Instance.SearchChungTuBanHangByMaVach(txtMaVach.Text.Trim());
            if (lst.Count == 1)
            {
                txtTenSanPham.Text = lst[0].TenSanPham;
                //Business = new DoiMaBussiness(BanHangDataProvider.Instance.LoadChungTuById(lst[0].IdChungTu));
                Business = new DoiMaBussiness(lst[0]);
                LoadOldChungTuInfor(Business.ChungTu);
                LoadChiTietThanhToan(Business.ChungTu.IdChungTu);
                grcHangBan.DataSource = null;
                Business.ChungTu.IdChungTu = 0;//de tao moi phieu nhap
            }
            else if (lst.Count > 1)
            { 
                txtTenSanPham.Text = lst[0].TenSanPham;
                frmMutilPhieuXuatBan frm = new frmMutilPhieuXuatBan(lst);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    //Business = new DoiMaBussiness(BanHangDataProvider.Instance.LoadChungTuById(frm.SelectItem.IdChungTu));
                    Business = new DoiMaBussiness(frm.SelectItem);
                    LoadOldChungTuInfor(Business.ChungTu);
                    LoadChiTietThanhToan(Business.ChungTu.IdChungTu);
                    grcHangBan.DataSource = null;
                    Business.ChungTu.IdChungTu = 0;//de tao moi phieu nhap
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

            txtTongGiaTriHH.Text = Common.Double2Str(lstHD.TongTienHang);
            txtTongTienCK.Text = Common.Double2Str(lstHD.TongTienChietKhau);
            txtTongTienSauCK.Text = Common.Double2Str(lstHD.TongTienSauChietKhau);
            txtTongTienVAT.Text = Common.Double2Str(lstHD.TongTienVAT);
            txtTongTienTT.Text = Common.Double2Str(lstHD.TongTienThanhToan);
            txtTienThucTra.Text = Common.Double2Str(lstHD.TienThanhToanThuc);
            txtTienConNo.Text = Common.Double2Str(lstHD.TienConNo);
        }

        //load thanh toán phiếu xuất bán
        private void LoadChiTietThanhToan(int idchungtu)
        {
            List<ChungTuThanhToanInfor> lsttt = ThanhToanDataProvider.Instance.LoadAllThanhToanByCTu(idchungtu);
            gHinhThucThanhToan.DataSource = null;
            gHinhThucThanhToan.DataSource = lsttt;
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
            if (Business.ChungTu.IdDoiTuong != 0)
            {
                DMDoiTuongInfo doituong = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(Business.ChungTu.IdDoiTuong);
                if (doituong != null)
                {
                    txtKhachHang.Tag = doituong;
                    txtKhachHang.Text = doituong.TenDoiTuong;
                }
            }

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

            txtTongGiaTriHH.Text = Common.Double2Str(Business.ChungTu.TongTienHang);
            txtTongTienCK.Text = Common.Double2Str(Business.ChungTu.TongTienChietKhau);
            txtTongTienSauCK.Text = Common.Double2Str(Business.ChungTu.TongTienSauChietKhau);
            txtTongTienVAT.Text = Common.Double2Str(Business.ChungTu.TongTienVAT);
            txtTongTienTT.Text = Common.Double2Str(Business.ChungTu.TongTienThanhToan);
            txtTienThucTra.Text = Common.Double2Str(Business.ChungTu.TienThanhToanThuc);
            txtTienConNo.Text = Common.Double2Str(Business.ChungTu.TienConNo);
        }
        private void LoadChungTuInstance()
        {
            if (Business.ChungTu.IdChungTu != 0)
            {
                LoadChungTuHeader();
                LoadChiTietHangBan();
                ChungTuBanHangInfor ctugoc = BanHangDataProvider.Instance.LoadChungTuBySoChungTu(Business.ChungTu.SoChungTuGoc, Business.ChungTu.SoSeri);
                LoadChiTietThanhToan(ctugoc.IdChungTu);                
                if (Business.ChungTu.Draft == 0 || Business.ChungTu.TrangThai != (int)OrderStatus.DE_NGHI_DOI_MA_VACH)
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
        //loai chi tiết hàng bán
        private void LoadOldChiTietHangBan(int idchungtu)
        {
            selector.selection.Clear();
            liChiTiet = BHangDoiMaDataProvider.Instance.GetListAllChiTietHDByIdChungTu(idchungtu, 1);
            grcHangBan.DataSource = null;
            grcHangBan.DataSource = new BindingList<BHangDoiMaChiTietHHInfor>(liChiTiet);
            selector.View = grvHangBan;
            //if (loai == 0)
            //{
            //    foreach (BHangDoiMaChiTietHHInfor pt in lstnt)
            //    {
            //        selector.selection.Add(pt);
            //    }
            //}
        }
        private void LoadChiTietHangBan()
        {
            grcHangBan.DataSource = null;
            grcHangBan.DataSource = new BindingList<BHangDoiMaChiTietHHInfor>(Business.ListChiTietChungTu);
            selector.View = null;
            //selector.View = grvHangBan;
            //selector.SelectAll();
        }
        //chứng từ đã lập đề nghị
        //private void LoadChiTietHangBan(int idchungtu)
        //{
        //    lstnt.Clear();
        //    lstnt = BHangDoiMaDataProvider.Instance.GetListAllChiTietHDByIdChungTu(idchungtu);
        //    grcHangBan.DataSource = null;
        //    grcHangBan.DataSource = lstnt;
        //    if (Business.ChungTu.IdChungTu == 0)
        //        selector.View = grvHangBan;
        //    foreach (BHangDoiMaChiTietHHInfor pt in lstnt)
        //    {
        //        selector.selection.Add(pt);
        //    }
        //}


        private bool CheckException()
        {
            ChungTuBanHangInfor ctugoc = BanHangDataProvider.Instance.LoadChungTuBySoChungTu(txtSoGiaoDich.Text, -2);

            if (ctugoc != null && ctugoc.LockId == 1 && ctugoc.LockAccount != Declare.UserName)
            {
                MessageBox.Show("Đơn hàng đang được mở bởi 1 người khác. Bạn không thể thay đổi trạng thái được!");
                return false;
            }

            if (string.IsNullOrEmpty(txtSoPhieuNhap.Text))
            {
                MessageBox.Show("Số phiếu nhập đổi trả hàng không được để trống!");
                txtSoPhieuNhap.Focus();
                return false;
            }

            if (selector.selection.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm đổi trả nào!");
                return false;
            }
            if (lueLyDo.EditValue == null)
            {
                MessageBox.Show("Bạn chưa chọn lý do đổi hàng!");
                lueLyDo.Focus();
                return false;
            }
            if (bteKhoXuat.Tag == null)
            {
                MessageBox.Show("Bạn chưa chọn kho nhập đổi mã!");
                bteKhoXuat.Focus();
                return false;
            }
            //if (Business.ChungTu.IdKho != Common.IntValue(lueKho.EditValue))
            //{
            //    MessageBox.Show(String.Format("Đơn hàng xuất tại [{0}]\nKhông thể đổi mã tại [{1}] được!",Business.ChungTu.TenKho, lueKho.Text));
            //    lueKho.Focus();
            //    return false;
            //}
            return true;
        }

        private void UpdateChungTu()
        {
            //update header
            UpdateChungTuHeader();
            //update detail
            UpdateChungTuDetails();
            //cap nhat chung tu
            Business.SaveChungTu(0);
        }
        private void UpdateChungTuHeader()
        {
            Business.ChungTu.Draft = Draft;
            Business.ChungTu.LoaiChungTu = LoaiChungTu;
            Business.ChungTu.TrangThai = TrangThai;
            Business.ChungTu.SoChungTu = txtSoPhieuNhap.Text.Trim().ToUpper();
            Business.ChungTu.SoChungTuGoc = txtSoGiaoDich.Text.Trim().ToUpper();
            Business.ChungTu.IdNhanVien = nguoiDung.IdNhanVien;
            Business.ChungTu.IdKho = ((DMKhoInfo)bteKhoXuat.Tag).IdKho;
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

            Business.ChungTu.TongTienHang = Common.DoubleValue(txtTongGiaTriHH.Text);
            Business.ChungTu.TongTienChietKhau = Common.DoubleValue(txtTongTienCK.Text);
            Business.ChungTu.TongTienSauChietKhau = Common.DoubleValue(txtTongTienSauCK.Text);
            Business.ChungTu.TongTienVAT = Common.DoubleValue(txtTongTienVAT.Text);
            Business.ChungTu.TongTienThanhToan = Common.DoubleValue(txtTongTienTT.Text);
            Business.ChungTu.IdTienTe = Declare.IdTienTe;
            Business.ChungTu.TienThanhToanThuc = Common.DoubleValue(txtTienThucTra.Text);
            Business.ChungTu.TienConNo = Common.DoubleValue(txtTienConNo.Text);
            Business.ChungTu.TongTienChu = Common.ReadNumner_(txtTongTienTT.Text.Trim());

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
        private void UpdateChungTuDetails()
        {
            Business.ListChiTietChungTu.Clear();
            Business.ListChungTuChiTietHangHoa.Clear();
            foreach (BHangDoiMaChiTietHHInfor pt in selector.selection)
            {

                pt.IdChungTu = Business.ChungTu.IdChungTu;
                Business.ListChiTietChungTu.Add(pt);
                Business.ListChungTuChiTietHangHoa.Add(new ChungTuBanHangChiTietHangHoaInfor
                {
                    IdChungTuChiTiet = 0,
                    IdChiTietHangHoa = 0,
                    IdSanPham = pt.IdSanPham,
                    MaVach = pt.MaVach
                });
            }            
        }

        #endregion

        #region Events
        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            try
            {
                SearchByMaVach();
            }
            catch (Exception ex)
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
                if (!string.IsNullOrEmpty(txtSoPhieuXuat.Text) || !string.IsNullOrEmpty(txtSoGiaoDich.Text) || !string.IsNullOrEmpty(txtSoHoaDon.Text))
                {
                    List<ChungTuBanHangInfor> lstsbh = BHangDoiMaDataProvider.Instance.SearchChungTuBanHangBySoPhieu(
                        txtSoPhieuXuat.Text.Trim().ToUpper(), txtSoGiaoDich.Text.Trim().ToUpper(),
                        txtSoHoaDon.Text.Trim().ToUpper());

                    if (lstsbh.Count > 0)
                    {
                        if (CommonProvider.Instance.Lock_ChungTu(lstsbh[0]))
                        {
                            lockInfo = lstsbh[0].Clone() as ChungTuBanHangInfor;
                            Business = new DoiMaBussiness(lstsbh[0]);
                            LoadOldChungTuInfor(Business.ChungTu);
                            LoadChiTietThanhToan(Business.ChungTu.IdChungTu);
                            LoadOldChiTietHangBan(Business.ChungTu.IdChungTu);
                            Business.ChungTu.IdChungTu = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmChiTietDeNghiDoiMa_Load(object sender, EventArgs e)
        {
            LoadLyDo();
            LoadKho();
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
                tsbAdd_Click(sender, e);
            }
            txtMaVach.Focus();
            txtMaVach.SelectAll();
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
#if DEBUG
                clsUtils.MsgCanhBao(ex.ToString());
#else
                clsUtils.MsgCanhBao(ex.Message);
#endif
            }
        }

        private void smiClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion

        private void frmChiTietDeNghiDoiMa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            Updating = true;
            Draft = -1;

            ResetAllText();
            txtSoPhieuNhap.Prefix = Declare.Prefix.PhieuDeNghiDoiMa;
            txtSoPhieuNhap.ReSet();//.Text = CommonProvider.Instance.GetSoPhieu(Declare.Prefix.PhieuDeNghiDoiMa);
            dteNgayNhap.EditValue = CommonProvider.Instance.GetSysDate();
            LoadKho();

            setEDFunctions();
            setEDItems();
        }

        private bool ValidEditChungTu()
        {
            if (Business.ChungTu.IdChungTu > 0 && (Business.ChungTu.Draft == 0 || Business.ChungTu.TrangThai != (int)OrderStatus.DE_NGHI_DOI_MA_VACH))//bang gia da xac nhan
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

        private bool ValidDeleteChungTu()
        {
            if (Business.ChungTu.IdChungTu > 0 && Business.ChungTu.TrangThai != (int)OrderStatus.DE_NGHI_DOI_MA_VACH)//bang gia da xac nhan            
            {
                MessageBox.Show("Đơn hàng đã thay đổi trạng thái, không thể xóa được");
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
                    if (Business.ChungTu.IdChungTu > 0)
                    {
                        Business.DeleteChungTu();//xoa chung tu neu chua xuat
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

        private void btnSearchPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (Updating)
                {
                    if (MessageBox.Show("Dữ liệu đang cập nhật, bạn có muốn hủy bỏ không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;
                }
                BHangDoiMaInfor ct = BHangDoiMaDataProvider.Instance.SearchChungTuBanHangByPN(txtSoPhieuNhap.Text.Trim().ToUpper(), (int)TransactionType.DOIMAHANGMUA);
                if (ct != null)
                {
                    Business = new DoiMaBussiness(ct);
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

        private void txtMaVach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnKiemTra_Click(sender, e);
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

            //List<NhapHangTraChiTietHHInfor> liChiTietBaoCao = new List<NhapHangTraChiTietHHInfor>();
            //foreach (BHangDoiMaChiTietHHInfor ct in Business.ListChiTietChungTu)
            //{
            //    NhapHangTraChiTietHHInfor nl = new NhapHangTraChiTietHHInfor()
            //                                       {
            //                                           MaVach = ct.MaVach,
            //                                           MaSanPham = ct.MaSanPham,
            //                                           TenSanPham = ct.TenSanPham,
            //                                           SoLuong = ct.SoLuong,
            //                                           DonViTinh = ct.DonViTinh,
            //                                           DonGia = ct.DonGia,
            //                                           DonGiaCoVat = ct.DonGiaCoVat,
            //                                           TienSauChietKhau = ct.TienSauChietKhau,
            //                                           TienVAT = ct.TienVAT,
            //                                           ThanhTien = ct.ThanhTien
            //                                       };
            //    liChiTietBaoCao.Add(nl);
            //}
            CommonFuns.Instance.InDonHangDoiMa(hd, Business.ListChiTietChungTu);
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

        private void frmChiTietDeNghiDoiMa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (lockInfo == null) return;

            CommonProvider.Instance.UnLock_ChungTu(lockInfo);
            
            lockInfo = null;
        }
    }
}