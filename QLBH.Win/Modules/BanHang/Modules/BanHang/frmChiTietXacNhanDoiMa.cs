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
using QLBanHang.Modules.KhoHang.Infors;
using QLBH.Common;
using QLBH.Common.Providers;
using QLBH.Core.Data;
using QLBH.Core.Providers;
using QLBH.Core.Exceptions;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmChiTietXacNhanDoiMa : DevExpress.XtraEditors.XtraForm
    {
        #region Declare
        private int Draft = 0;
        private int TrangThai = (int) OrderStatus.XAC_NHAN_DOI_MA_VACH;
        private bool Updating = false;

        //private List<BHangDoiMaChiTietHHInfor> lstnt = new List<BHangDoiMaChiTietHHInfor>();
        private List<BHangDoiMaChiTietHHInfor> liChiTiet = new List<BHangDoiMaChiTietHHInfor>();
        private objGridMarkSelection selector = new objGridMarkSelection();
        private XacNhanNhapDoiMaBussiness NhapDoiMaBusiness;
        private XacNhanXuatDoiMaBussiness XuatDoiMaBusiness;
        protected NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int _IdKho = Declare.IdKho;
        private int _IdTrungTam = Declare.IdTrungTam;

        #endregion

        public frmChiTietXacNhanDoiMa()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            XuatDoiMaBusiness = new XacNhanXuatDoiMaBussiness();
        }

        public frmChiTietXacNhanDoiMa(BHangDoiMaInfor ctu)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.XuatDoiMaBusiness = new XacNhanXuatDoiMaBussiness(ctu);
        }
        public frmChiTietXacNhanDoiMa(ChungTuBanHangInfor ctu)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.XuatDoiMaBusiness = new XacNhanXuatDoiMaBussiness(ctu);
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

            //btnTimOrderKH.Visible = false;
            Updating = nguoiDung.SupperUser != 1 ? false : enable;
            setEDItems();
        }
        #region Actions
        private void setEDFunctions()
        {
            tsbEdit.Enabled = !Updating && (Draft != 0 || XuatDoiMaBusiness.ChungTu.TrangThai == (int)OrderStatus.DE_NGHI_DOI_MA_VACH);
            tsbUpdate.Enabled = Updating;
            tsbDelete.Enabled = nguoiDung.SupperUser == 1 && TrangThai == (int)OrderStatus.XAC_NHAN_DOI_MA_VACH;
            tsbConfirm.Enabled = Updating;
            tsbPayment.Enabled = Updating;
            tsbPrint.Enabled = !Updating;
        }

        private void setEDItems()
        {
            bteKhoXuat.Enabled = false;
            lueLyDo.Enabled = Updating;
            dteNgayNhap.Enabled = false;
            txtSoPhieuNhap.Properties.ReadOnly = true;// !Updating;
            txtGhiChu.Enabled = Updating;
            colMaVachDoi.OptionsColumn.ReadOnly = !Updating;
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

        private void LoadGioiTinh()
        {
            cboGioiTinh.Properties.Items.Add("Nữ");
            cboGioiTinh.Properties.Items.Add("Nam");
        }

        private void LoadChungTuHeader()
        {
            //Draft = Business.ChungTu.Draft;
            //TrangThai = Business.ChungTu.TrangThai;
            _IdTrungTam = XuatDoiMaBusiness.ChungTu.IdTrungTam;

            bteKhoXuat.Tag = DMKhoDataProvider.GetKhoByIdInfo(XuatDoiMaBusiness.ChungTu.IdKho);
            bteKhoXuat.Text = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).TenKho : "";

            txtSoPhieuNhap.Text = XuatDoiMaBusiness.ChungTu.SoChungTu;
            txtGhiChu.Text = XuatDoiMaBusiness.ChungTu.GhiChu;
            try
            {
                dteNgayNhap.EditValue = XuatDoiMaBusiness.ChungTu.NgayLap;
            }
            catch (Exception)
            {
                dteNgayNhap.EditValue = CommonProvider.Instance.GetSysDate();
            }

            try
            {
                dteNgayXacNhan.EditValue = XuatDoiMaBusiness.ChungTu.NgayXuatHang;
            }
            catch (Exception)
            {
                dteNgayXacNhan.EditValue = CommonProvider.Instance.GetSysDate();
            }

            lueLyDo.EditValue = XuatDoiMaBusiness.ChungTu.IdLyDoGiaoDich;

            if (XuatDoiMaBusiness.ChungTu.IdDoiTuong != 0)
            {
                DMDoiTuongInfo doituong = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(XuatDoiMaBusiness.ChungTu.IdDoiTuong);
                if (doituong != null)
                {
                    txtKhachHang.Tag = doituong;
                    txtKhachHang.Text = doituong.TenDoiTuong;
                }
            }

            grbChungTuMua.Text = "Thông tin phiếu mua hàng: " +
                     (String.IsNullOrEmpty(XuatDoiMaBusiness.ChungTu.TenTrungTam)
                          ? ""
                          : (XuatDoiMaBusiness.ChungTu.TenTrungTam + (String.IsNullOrEmpty(XuatDoiMaBusiness.ChungTu.TenKho) ? "" : "(" + XuatDoiMaBusiness.ChungTu.TenKho + ")")));
            txtSoGiaoDich.Text = XuatDoiMaBusiness.ChungTu.SoChungTuGoc;
            txtSoPhieuXuat.Text = XuatDoiMaBusiness.ChungTu.SoPhieuXuat;
            try
            {
                dteNgayLap.EditValue = XuatDoiMaBusiness.ChungTu.NgayHenGiaoHang;
            }
            catch (Exception)
            {
                dteNgayLap.EditValue = CommonProvider.Instance.GetSysDate();
            }
            try
            {
                dteNgayXuat.EditValue = XuatDoiMaBusiness.ChungTu.NgayGiaoHang;
            }
            catch (Exception)
            {
                dteNgayXuat.EditValue = CommonProvider.Instance.GetSysDate();
            }
            //cboCaBanHang.SelectedIndex = Business.ChungTu.CaBanHang;
            txtKiHieu.Text = XuatDoiMaBusiness.ChungTu.KyHieu;
            txtSoHoaDon.Text = XuatDoiMaBusiness.ChungTu.SoSeri;
            txtTenDoiTuong.Text = XuatDoiMaBusiness.ChungTu.HoTen;
            txtCongTy.Text = XuatDoiMaBusiness.ChungTu.CongTy;
            cboGioiTinh.SelectedIndex = XuatDoiMaBusiness.ChungTu.GioiTinh;
            txtCMND.Text = XuatDoiMaBusiness.ChungTu.SoCMND;
            txtSoDienThoai.Text = XuatDoiMaBusiness.ChungTu.DienThoai;
            txtEmail.Text = XuatDoiMaBusiness.ChungTu.Email;
            txtDiaChiHD.Text = XuatDoiMaBusiness.ChungTu.DiaChiHoaDon;
            txtDiaChiGH.Text = XuatDoiMaBusiness.ChungTu.DiaChiGiaoHang;

            if (XuatDoiMaBusiness.ChungTu.IdNhanVien != 0)
            {
                DMNhanVienInfo nhanvien = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(XuatDoiMaBusiness.ChungTu.IdNhanVien);
                if (nhanvien != null)
                {
                    bteThuongVien.Tag = nhanvien;
                    bteThuongVien.Text = nhanvien.HoTen;
                }
            }

            if (XuatDoiMaBusiness.ChungTu.IdDoiTuong != 0)
            {
                DMDoiTuongInfo doituong = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(XuatDoiMaBusiness.ChungTu.IdDoiTuong);
                if (doituong != null)
                {
                    txtKhachHang.Tag = doituong;
                    txtKhachHang.Text = doituong.TenDoiTuong;
                }
            }

            if (XuatDoiMaBusiness.ChungTu.IdKhachLe != 0)
            {
                DMDoiTuongInfo khachle = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(XuatDoiMaBusiness.ChungTu.IdKhachLe);
                if (khachle != null)
                {
                    bteKhachLe.Tag = khachle;
                    bteKhachLe.Text = khachle.TenDoiTuong;
                }
            }

            txtTongGiaTriHH.Text = Common.Double2Str(XuatDoiMaBusiness.ChungTu.TongTienHang);
            txtTongTienCK.Text = Common.Double2Str(XuatDoiMaBusiness.ChungTu.TongTienChietKhau);
            txtTongTienSauCK.Text = Common.Double2Str(XuatDoiMaBusiness.ChungTu.TongTienSauChietKhau);
            txtTongTienVAT.Text = Common.Double2Str(XuatDoiMaBusiness.ChungTu.TongTienVAT);
            txtTongTienTT.Text = Common.Double2Str(XuatDoiMaBusiness.ChungTu.TongTienThanhToan);
            txtTienThucTra.Text = Common.Double2Str(XuatDoiMaBusiness.ChungTu.TienThanhToanThuc);
            txtTienConNo.Text = Common.Double2Str(XuatDoiMaBusiness.ChungTu.TienConNo);
        }
        private void LoadChungTuInstance()
        {
            if (XuatDoiMaBusiness.ChungTu.IdChungTu != 0)
            {
                LoadChungTuHeader();
                LoadChiTietHangBan();
                ChungTuBanHangInfor ctugoc = BanHangDataProvider.Instance.LoadChungTuBySoChungTu(XuatDoiMaBusiness.ChungTu.SoChungTuGoc, XuatDoiMaBusiness.ChungTu.SoSeri);
                LoadChiTietThanhToan(ctugoc.IdChungTu);

                if (XuatDoiMaBusiness.ChungTu.Draft == 0 || XuatDoiMaBusiness.ChungTu.TrangThai != (int)OrderStatus.DE_NGHI_DOI_MA_VACH)
                {
                    Updating = false;
                    setEDFunctions();
                    setEDItems();
                }
            }
        }

        //load thanh toán phiếu xuất bán
        private void LoadChiTietThanhToan(int idchungtu)
        {
            List<ChungTuThanhToanInfor> lsttt = ThanhToanDataProvider.Instance.LoadAllThanhToanByCTu(idchungtu);
            gHinhThucThanhToan.DataSource = null;
            gHinhThucThanhToan.DataSource = lsttt;
        }

        //chứng từ đã lập đề nghị
        private void LoadChiTietHangBan()
        {
            liChiTiet = BHangDoiMaDataProvider.Instance.GetListAllChiTietHDByIdChungTuXN(XuatDoiMaBusiness.ChungTu.IdChungTu);
            foreach (BHangDoiMaChiTietHHInfor ct in liChiTiet)
            {
                ct.IdKho = BHangDoiMaDataProvider.Instance.GetIdKhoNhapDoiMa(ct.MaVach, ct.IdSanPham,
                                                                             XuatDoiMaBusiness.ChungTu.SoChungTuGoc);
            }
            grcHangBan.DataSource = null;
            grcHangBan.DataSource = liChiTiet;
            selector.View = null;
            //selector.SelectAll();
        }

        //load đã đổi
        //private void LoadChiTiet(int idchungtu)
        //{
        //    lstnt.Clear();
        //    liChiTiet = BHangDoiMaDataProvider.Instance.GetListAllChiTietHDByIdChungTuXN(idchungtu);
        //    grcHangBan.DataSource = null;
        //    grcHangBan.DataSource = liChiTiet;
        //    //selector.View = grvHangBan;
        //    foreach (BHangDoiMaChiTietHHInfor pt in lstnt)
        //    {
        //        selector.selection.Add(pt);
        //    }
        //}

        private bool CheckException()
        {
            foreach (BHangDoiMaChiTietHHInfor pt in liChiTiet)
            {
                if (string.IsNullOrEmpty(pt.MaVachDoi))
                {
                    MessageBox.Show("Bạn chưa nhập đủ số mã vạch đổi!");
                    return false;
                }
            }

            return true;
        }
        private void UpdateChungTu()
        {
            //tao chung tu xuat ma moi
            UpdateXuatDoiMa();
            //tao chung tu nhap ma cu
            UpdateNhapDoiMa();
            //cap nhat thong tin doi ma vao phieu goc
            UpdatePhieuXuatGoc();
        }

        private void UpdateXuatDoiMa()
        {
            XuatDoiMaBusiness.ChungTu.Draft = Draft;
            if (XuatDoiMaBusiness.ChungTu.TrangThai != (int)OrderStatus.XAC_NHAN_DOI_MA_VACH)
            {
                XuatDoiMaBusiness.ChungTu.NgayXuatHang = CommonProvider.Instance.GetSysDate();
            }

            XuatDoiMaBusiness.ChungTu.TrangThai = (int)OrderStatus.XAC_NHAN_DOI_MA_VACH;
            XuatDoiMaBusiness.ChungTu.GhiChu = txtGhiChu.Text;
            XuatDoiMaBusiness.ChungTu.NguoiSua = nguoiDung.TenDangNhap;
            XuatDoiMaBusiness.ChungTu.TenMaySua = Declare.TenMay;

            XuatDoiMaBusiness.ListChiTietChungTu = new List<BHangDoiMaChiTietHHInfor>();
            XuatDoiMaBusiness.ListChiTietHangHoa = new List<ChungTuBanHangChiTietHangHoaInfor>();
            foreach (BHangDoiMaChiTietHHInfor pt in liChiTiet)
            {
                BHangDoiMaChiTietHHInfor ct =
                    XuatDoiMaBusiness.ListChiTietChungTu.Find(delegate(BHangDoiMaChiTietHHInfor match)
                                                                  { return match.IdSanPham == pt.IdSanPham &&
                                                                      match.MaVachDoi == pt.MaVachDoi; });

                if (ct != null)
                    ct.SoLuong += pt.SoLuong;
                else
                {
                    ct = new BHangDoiMaChiTietHHInfor(pt);
                    XuatDoiMaBusiness.ListChiTietChungTu.Add(ct);
                }
                pt.IdCtietHhoaGoc = XuatDoiMaBusiness.GetIdChiTietHangHoa(pt.MaVach, pt.IdSanPham, XuatDoiMaBusiness.ChungTu.SoChungTuGoc);

                if (XuatDoiMaBusiness.ListChiTietHangHoa.Exists(delegate(ChungTuBanHangChiTietHangHoaInfor match)
                                                                    {
                                                                        return match.IdSanPham == ct.IdSanPham &&
                                                                               match.MaVach == pt.MaVachDoi;
                                                                    }))

                    XuatDoiMaBusiness.ListChiTietHangHoa.Find(delegate(ChungTuBanHangChiTietHangHoaInfor match)
                                                                  {
                                                                      return match.IdSanPham == ct.IdSanPham &&
                                                                             match.MaVach == pt.MaVachDoi;
                                                                  }).SoLuong += pt.SoLuong;
                else
                    XuatDoiMaBusiness.ListChiTietHangHoa.
                        Add(new ChungTuBanHangChiTietHangHoaInfor
                                {
                                    IdChungTuChiTiet = ct.IdChungTuChiTiet,
                                    IdSanPham = ct.IdSanPham,
                                    MaVach = pt.MaVachDoi,
                                    SoLuong = pt.SoLuong,
                                    IdChiTietHangHoaGoc = pt.IdCtietHhoaGoc
                                });
            }
            XuatDoiMaBusiness.SaveChungTu();//tao chung tu nhap doi ma
        }

        private void UpdateNhapDoiMa()
        {
            NhapDoiMaBusiness = new XacNhanNhapDoiMaBussiness();

            NhapDoiMaBusiness.ChungTu = new ChungTuBanHangInfor(XuatDoiMaBusiness.ChungTu);
            NhapDoiMaBusiness.ChungTu.IdChungTu = 0;//tạo mới chứng từ
            NhapDoiMaBusiness.ChungTu.SoChungTuGoc = NhapDoiMaBusiness.ChungTu.SoChungTu;
            NhapDoiMaBusiness.ChungTu.SoChungTu = NhapDoiMaBusiness.ChungTu.SoChungTuGoc.Replace(Declare.Prefix.PhieuDeNghiDoiMa,
                                                               Declare.Prefix.PhieuXacNhanDoiMa);
            NhapDoiMaBusiness.ChungTu.LoaiChungTu = (int)TransactionType.NHAPDOIMAHANGMUA;
            NhapDoiMaBusiness.ChungTu.NgayLap = NhapDoiMaBusiness.ChungTu.NgayXuatHang;

            NhapDoiMaBusiness.ChungTu.NguoiTao = nguoiDung.TenDangNhap;
            NhapDoiMaBusiness.ChungTu.TenMayTao = Declare.TenMay;

            NhapDoiMaBusiness.ListChiTietChungTu = new List<BHangDoiMaChiTietHHInfor>();
            NhapDoiMaBusiness.ListChiTietHangHoa = new List<ChungTuBanHangChiTietHangHoaInfor>();

            foreach (BHangDoiMaChiTietHHInfor pt in liChiTiet)
            {
                BHangDoiMaChiTietHHInfor ct =
                    NhapDoiMaBusiness.ListChiTietChungTu.Find(delegate(BHangDoiMaChiTietHHInfor match)
                    { return match.IdSanPham == pt.IdSanPham; });

                if (ct != null)
                    ct.SoLuong += pt.SoLuong;
                else
                {
                    ct = new BHangDoiMaChiTietHHInfor(pt);
                    ct.IdChungTu = 0;
                    NhapDoiMaBusiness.ListChiTietChungTu.Add(ct);
                }

                if (NhapDoiMaBusiness.ListChiTietHangHoa.Exists(delegate(ChungTuBanHangChiTietHangHoaInfor match)
                {
                    return match.IdSanPham == ct.IdSanPham &&
                           match.MaVach == pt.MaVach;
                }))
                    NhapDoiMaBusiness.ListChiTietHangHoa.Find(delegate(ChungTuBanHangChiTietHangHoaInfor match)
                    {
                        return match.IdSanPham == ct.IdSanPham &&
                               match.MaVach == pt.MaVach;
                    }).SoLuong += pt.SoLuong;
                else
                    NhapDoiMaBusiness.ListChiTietHangHoa.Add(new ChungTuBanHangChiTietHangHoaInfor
                    {
                        IdChungTuChiTiet = ct.IdChungTuChiTiet,
                        IdSanPham = ct.IdSanPham,
                        MaVach = pt.MaVach,
                        SoLuong = pt.SoLuong
                    });

                
            }
            NhapDoiMaBusiness.SaveChungTu();//tao chung tu xuat doi ma
        }

        private void UpdatePhieuXuatGoc()
        {
            foreach (BHangDoiMaChiTietHHInfor pt in liChiTiet)
            {
                //cap nhat mavach, don hang goc lien quan chung tu doi ma
                UpdateChiTietHangHoaXuatGoc(pt, XuatDoiMaBusiness.ChungTu.IdKho, XuatDoiMaBusiness.ChungTu.SoChungTuGoc);

                //cap nhat bao hanh
                UpdateBaoHanh(pt.MaVach, pt.MaVachDoi, XuatDoiMaBusiness.ChungTu.SoChungTuGoc);

                //cap nhat lich su doi ma
                LichSuDoiMaInfor lsdm = new LichSuDoiMaInfor()
                                            {
                                                ID = 0,
                                                IdSanPhamCu = pt.IdSanPham,
                                                IdSanPhamMoi = pt.IdSanPham,
                                                MaVachCu = pt.MaVach,
                                                MaVachMoi = pt.MaVachDoi,
                                                NgayDoiMa = XuatDoiMaBusiness.ChungTu.NgayXuatHang,
                                                SoChungTuDoiMa = XuatDoiMaBusiness.ChungTu.SoChungTu,
                                                SoChungTuGoc = XuatDoiMaBusiness.ChungTu.SoChungTuGoc
                                            };
                BHangDoiMaDataProvider.Instance.InsertLichSuDoiMa(lsdm);
            }
        }

        private void UpdateChiTietHangHoaXuatGoc(BHangDoiMaChiTietHHInfor ct, int idKhoDoi, string soCtuGoc)
        {
            //update lai chung tu goc: idkhodieuchuyen(ctu) va idchitiethanghoa(ctu_ctiet_hanghoa)
            BHangDoiMaDataProvider.Instance.UpdateChungTuChiTietHHDoiMa(ct.MaVach, ct.MaVachDoi, ct.IdSanPham,idKhoDoi, soCtuGoc);
        }

        private void UpdateBaoHanh(string mavach,string mavachdoi,string soCtuGoc)
        {
            BhBaoHanhInfor item = BhBaoHanhDataProvider.Instance.SearchMaVach(mavach, soCtuGoc);
            if (item != null)
            {
                BhBaoHanhDataProvider.Instance.UpdateMaVachBaoHanh(item.IdBaoHanh, mavachdoi);
            }
        }

        private void CheckMaVachDoi(int rowhandle)
        {
            if (bteKhoXuat.Tag == null)
            {
                throw new ManagedException("Phải chọn kho nhập đổi hàng bán!");
            }
            BHangDoiMaChiTietHHInfor item = (BHangDoiMaChiTietHHInfor) grvHangBan.GetRow(rowhandle);

            if (BHangDoiMaDataProvider.Instance.CheckSoLuongHangHoaChiTiet(((DMKhoInfo)bteKhoXuat.Tag).IdKho,
                                                                           item.IdSanPham, item.MaVachDoi) == 0)
            {
                liChiTiet[liChiTiet.IndexOf(item)].MaVachDoi = string.Empty;
                grcHangBan.RefreshDataSource();
                throw new ManagedException("Mã vạch này không có hoặc đã hết hàng!");
            }
        }

        #endregion

        #region Events
        private void frmChiTietXacNhanDoiMa_Load(object sender, EventArgs e)
        {
            LoadLyDo();
            LoadKho();
            LoadGioiTinh();

            if (XuatDoiMaBusiness.ChungTu.IdChungTu > 0)
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
                Updating = false;
                setEDFunctions();
            }
        }

        private void frmChiTietXacNhanDoiMa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
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
                setEDItems();
                clsUtils.MsgThongBao(Declare.msgUpdateSucc);
            }
            catch (ManagedException ex)
            {
                ConnectionUtil.Instance.RollbackTransaction();
#if DEBUG
                clsUtils.MsgCanhBao(ex.ToString());
#else
                clsUtils.MsgCanhBao(ex.Message);
#endif
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
            catch (ManagedException ex)
            {
                ConnectionUtil.Instance.RollbackTransaction();
#if DEBUG
                clsUtils.MsgCanhBao(ex.ToString());
#else
                clsUtils.MsgCanhBao(ex.Message);
#endif
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
            this.Close();
        }

        private void grvHangBan_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if(e.Column==colMaVachDoi)
            {
                try
                {
                    CheckMaVachDoi(e.RowHandle);
                }
                catch (ManagedException ex)
                {
                    clsUtils.MsgCanhBao(ex.Message);
                }
                catch (Exception ex)
                {
                    EventLogProvider.Instance.WriteLog(ex.ToString()
                                        + "\nUser: " + nguoiDung.TenDangNhap
                                        + "\nMay: " + Declare.TenMay,
                                        this.Name);

                    clsUtils.MsgCanhBao(ex.Message);
                }

            }
        }
        #endregion

        private bool ValidEditChungTu()
        {
            if (XuatDoiMaBusiness.ChungTu.IdChungTu > 0 && XuatDoiMaBusiness.ChungTu.Draft == 0 && XuatDoiMaBusiness.ChungTu.TrangThai == (int)OrderStatus.XAC_NHAN_DOI_MA_VACH)//bang gia da xac nhan
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
            if (XuatDoiMaBusiness.ChungTu.IdChungTu > 0 && XuatDoiMaBusiness.ChungTu.TrangThai == (int)OrderStatus.DE_NGHI_TRA_LAI_HANG_BAN)//bang gia da xac nhan            
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
                    if (XuatDoiMaBusiness.ChungTu.IdChungTu > 0)
                    {
                        XuatDoiMaBusiness.DeleteChungTu();//xoa chung tu neu chua xuat
                    }
                    ConnectionUtil.Instance.CommitTransaction();
                    MessageBox.Show("Hủy đơn hàng thành công!");
                    this.Close();
                }
            }
            catch (ManagedException ex)
            {
                ConnectionUtil.Instance.RollbackTransaction();
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
            catch (Exception ex)
            {
                ConnectionUtil.Instance.RollbackTransaction();
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
            if (XuatDoiMaBusiness.ChungTu.IdChungTu == 0) return;
            HoaDonPCGNInfo hd = new HoaDonPCGNInfo();
            ChungTuBanHangInfor cTuGoc = BanHangDataProvider.Instance.LoadChungTuBySoChTu(XuatDoiMaBusiness.ChungTu.SoChungTuGoc);
            hd.KhachHang = cTuGoc.TenDoiTuong;
            hd.HoTen = cTuGoc.HoTen;
            hd.DienThoai = cTuGoc.DienThoai;
            hd.CongTy = cTuGoc.CongTy;
            hd.MaSoThue = cTuGoc.MaSoThue;
            hd.DiaChiHoaDon = cTuGoc.DiaChiHoaDon;
            hd.DiaChiGiaoHang = cTuGoc.DiaChiGiaoHang;
            hd.NgayLap = XuatDoiMaBusiness.ChungTu.NgayLap;
            hd.NgayBan = cTuGoc.NgayLap;
            hd.SoChungTuGoc = cTuGoc.SoChungTu;
            hd.SoChungTu = XuatDoiMaBusiness.ChungTu.SoChungTu;

            DMKhoInfo khoXuat = DMKhoDataProvider.GetKhoByIdInfo(cTuGoc.IdKho);
            if (khoXuat != null)
            {
                hd.KhoXuat = khoXuat.MaKho;
            }

            DMKhoInfo khoNhap = DMKhoDataProvider.GetKhoByIdInfo(XuatDoiMaBusiness.ChungTu.IdKho);
            if (khoNhap != null)
            {
                hd.MaKhoNhapLai = khoNhap.MaKho;
                hd.TenKhoNhapLai = khoNhap.TenKho;
            }

            hd.LyDoNhapLai = lueLyDo.Text;
            hd.GhiChu = XuatDoiMaBusiness.ChungTu.GhiChu;
            hd.NhanVienKinhDoanh = cTuGoc.TenNhanVien;
            hd.SoHoaDon = XuatDoiMaBusiness.ChungTu.SoSeri;

            //hd.HinhThucThanhToan = LstPhieuPCGN[0];
            hd.CachGiaoHang = XuatDoiMaBusiness.ChungTu.GiaoNhan == 1 ? "Giao tại nhà khách" : "Giao tại công ty";
            hd.TongTienHang = XuatDoiMaBusiness.ChungTu.TongTienHang;
            hd.TienThanhToanThuc = XuatDoiMaBusiness.ChungTu.TienThanhToanThuc;
            hd.TienConNo = XuatDoiMaBusiness.ChungTu.TienConNo;

            CommonFuns.Instance.InDonHangDoiMa(hd, liChiTiet);
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