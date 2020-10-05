using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using QLBanHang.Class;
//using QLBanHang.Class.Objects;
using QLBanHang.Modules.HeThong;
using QLBH.Common;
using QLBH.Common.Providers;
using QLBH.Core.Data;
using QLBH.Common.Objects;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.BanHang.Bussiness;
using QLBH.Core.Business;
using QLBH.Core.Data;
using QLBH.Core.Infors;
using QLBH.Core.Providers;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBC_GiaoNhan_ChiTiet : DevExpress.XtraEditors.XtraForm
    {
        #region "Khai báo biến"
        private int Draft = -1;//-1:chua ton tai; 1-save, 0-confirm
        private bool Updating = false;//false: chua sua, tao moi; 1:dang sua, tao moi
                
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor) Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private List<ChungTuBanHangInfor> LstPhieuPCGN = new List<ChungTuBanHangInfor>();
        private List<HangBanGiaoNhanChiTietInfor> liHangGiaoNhan = new List<HangBanGiaoNhanChiTietInfor>();
        private int TrangThaiDonHang = (int)OrderStatus.PHAN_CONG_GIAO_NHAN;
        private int LoaiChungTu = (int) TransactionType.DON_HANG_GIAO_NHAN;
        private string ListIdChungTu = "";
        private int IdGiaoNhan;

        private ChungTuGiaoNhanInfor GiaoNhan;

        #endregion

        #region "Các phương thức khởi tạo"
        public frmBC_GiaoNhan_ChiTiet()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        public frmBC_GiaoNhan_ChiTiet(string listIdChungTu, int idGiaoNhan)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.ListIdChungTu = listIdChungTu;
            this.IdGiaoNhan = idGiaoNhan;
            //Business = new PhanCongGiaoNhanBusiness(LoaiChungTu, nguoiDung.IdNhanVien, _IdKho);
            GiaoNhan = new ChungTuGiaoNhanInfor();
        }
        #endregion

        #region "Các phương thức"
        private void LoadAllChiTietHangBan()
        {
            List<TrangThaiBH> liLoaiDH = Common.GetListLoaiDonHang();
            repLoaiDonHang.DataSource = liLoaiDH;

            liHangGiaoNhan =
                BanHangDataProvider.Instance.GetListChiTietChungTuByListIdChungTu(ListIdChungTu);
            gHangCanXuat.DataSource = new BindingList<HangBanGiaoNhanChiTietInfor>(liHangGiaoNhan);
            gvHangCanXuat.ExpandAllGroups();
        }
        private void LoadChungTuInstance()
        {
            if (GiaoNhan != null)
            {
                LoadPhieuGiaoNhanInfor();
                LoadDonHangGiaoNhanInfor();
            }
        }

        private void LoadPhieuGiaoNhanInfor()
        {
            LoadPhieuGiaoNhanHeader();
            LoadPhieuGiaoNhanDetails();
        }

        private void LoadPhieuGiaoNhanHeader()
        {
            cboTinhTrangGN.SelectedIndex = GiaoNhan.TinhTrang;
            Draft = GiaoNhan.Draft;
            txtSoPhieuPCGN.Text = GiaoNhan.SoPhieuPhanCong;
            mstNgayPhanCong.Value = GiaoNhan.NgayPhanCong;
            mstNgayHoanThanh.Value = GiaoNhan.NgayHoanThanh;
            txtGhiChuPNGN.Text = GiaoNhan.GhiChu;
        }

        private void LoadPhieuGiaoNhanDetails()
        {
            GiaoNhan.ListChiTietGiaoNhan = GiaoNhanDataProvider.Instance.GetListChungTuGNhanChiTietGetById(GiaoNhan.IdGiaoNhan);
            gPhanCongGiaoNhan.DataSource = new BindingList<ChungTuGiaoNhanChiTietInfor>(GiaoNhan.ListChiTietGiaoNhan);
            UpdateNhanVien();
        }  
 
        private void LoadDonHangGiaoNhanInfor()
        {
            ChungTuBanHangInfor dhgn = GiaoNhanDataProvider.Instance.GetDonHangGiaoNhanBySoPCGN(GiaoNhan.SoPhieuPhanCong);
            if (dhgn != null)
            {
                LoadDonHangGiaoNhanHeader(dhgn);
                LoadDonHangGiaoNhanDetails(dhgn);                
            }
        }

        private void LoadDonHangGiaoNhanHeader(ChungTuBanHangInfor dhgn)
        {
            LoaiChungTu = dhgn.LoaiChungTu;
            TrangThaiDonHang = dhgn.TrangThai;
            Draft = dhgn.Draft;

            bteKhoXuat.Tag = DMKhoDataProvider.GetKhoByIdInfo(dhgn.IdKho);
            bteKhoXuat.Text = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).TenKho : "";
            cboNhanVien.SelectedValue = dhgn.IdNhanVien;

            txtSoOrderKH.Text = dhgn.SoChungTu;
            mstNgayLapPhieu.Value = dhgn.NgayLap;
            txtGhiChu.Text = dhgn.GhiChu;
        }

        private void LoadDonHangGiaoNhanDetails(ChungTuBanHangInfor dhgn)
        {
            //Load danh sach hang ban
            gHangGiaoVan.DataSource = BanHangDataProvider.Instance.GetListChiTietChungTuByIdChungTu(dhgn.IdChungTu);
        }
        #endregion

        private void ShowInfors()
        {
            tsslTrangThai.Text = Common.GetOrderStatus(TrangThaiDonHang, Draft);
            tslInfor.Text = Common.GetEnumInfor((TransactionType) LoaiChungTu);
        }

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            try 
            {
                GiaoNhan = GiaoNhanDataProvider.Instance.GetChungTuGiaoNhanGetById(IdGiaoNhan);
                if (GiaoNhan != null)//sua => tim danh sach cac chung tu co cung phan cong giao nhan
                {
                    List<ChungTuBanHangInfor> liChungTu =
                        GiaoNhanDataProvider.Instance.GetAllChungTuByIdGiaoNhan(GiaoNhan.IdGiaoNhan);
                    LstPhieuPCGN = new List<ChungTuBanHangInfor>(liChungTu);
                    LoadChungTuInstance();
                    Updating = false;
                    setEDItems();
                    ShowInfors();
                }

                LoadAllChiTietHangBan();
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

        private void frmPhieuXuat_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //if (!this.txtGhiChu.Focused && !this.dgvSanPhamBan.Focused && !this.txtMaVach.Focused && !this.dgvHangKhuyenMai.Focused)
                //{
                //    if (e.KeyCode == Keys.Enter)
                //    {
                //        SendKeys.Send("{TAB}");
                //        e.Handled = true;
                //        return;
                //    }
                //    else if (e.KeyCode == Keys.F2)
                //    {
                //        if (this.WindowState == FormWindowState.Maximized)
                //            this.WindowState = FormWindowState.Normal;
                //        else
                //            this.WindowState = FormWindowState.Maximized;
                //        e.Handled = true;
                //        return;
                //    }
                //}
                if (e.KeyCode == Keys.F9 && tsbPrint.Enabled)
                    this.tsbPrint_Click(sender, e);
                else if (e.KeyCode == Keys.F12 && tsbClose.Enabled)
                    this.tsbClose_Click(sender, e);
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
            //phan cong giao nhan
            txtSoPhieuPCGN.Enabled = Updating;
            mstNgayPhanCong.Enabled = Updating;
            mstNgayHoanThanh.Enabled = Updating;
            txtGhiChuPNGN.Enabled = Updating;

            //don hang pcgn
            txtSoOrderKH.Enabled = Updating;
            mstNgayLapPhieu.Enabled = Updating;
            bteKhoXuat.Enabled = Updating;
            txtGhiChu.Enabled = Updating;
            cboTinhTrangGN.Enabled = Updating;
            cboNhanVien.Enabled = Updating;
        }


        private void tsbPrint_Click(object sender, EventArgs e)
        {
            if (gvHangCanXuat.RowCount == 0)
            {
                MessageBox.Show("Chưa có sản phẩm bán");
                return;
            }
            InPhieuGiaoNhan();
        }

        private void InPhieuGiaoNhan()
        {
            if (LstPhieuPCGN.Count == 0) return;
            HoaDonPCGNInfo hd = new HoaDonPCGNInfo();
            double tongtien = 0, thuctra = 0, tienno = 0;
            string sochungtu = "";
            string sohoadon = "";
            string ghichu = "";
            foreach (ChungTuBanHangInfor ct in LstPhieuPCGN)
            {
                sochungtu = sochungtu + ct.SoChungTu + ",";
                sohoadon = sohoadon + ct.SoSeri + ",";
                ghichu = ghichu + ct.GhiChu + ",";
                tongtien += ct.TongTienThanhToan;
                thuctra += ct.TienThanhToanThuc;
                tienno += ct.TienConNo;
            }
            if (LstPhieuPCGN.Count > 0)
            {
                DMNhanVienInfo nv = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(LstPhieuPCGN[0].IdNhanVien);
                hd.ThuongVien = (nv != null ? nv.HoTen : "");
            }

            hd.SoChungTu = sochungtu;
            hd.SoHoaDon = sohoadon;
            hd.NgayLap = LstPhieuPCGN[0].NgayLap;
            hd.KhachHang = LstPhieuPCGN[0].TenDoiTuong;
            hd.CongTy = LstPhieuPCGN[0].CongTy;
            hd.HoTen = LstPhieuPCGN[0].HoTen;
            hd.DiaChiHoaDon = LstPhieuPCGN[0].DiaChiHoaDon;
            hd.DiaChiGiaoHang = LstPhieuPCGN[0].DiaChiGiaoHang;
            hd.DienThoai = LstPhieuPCGN[0].DienThoai;
            DMKhoInfo dmKho = DMKhoDataProvider.GetKhoByIdInfo(LstPhieuPCGN[0].IdKho);
            if (dmKho != null)
            {
                hd.KhoXuat = dmKho.MaKho;
            }

            //hd.HinhThucThanhToan = LstPhieuPCGN[0];
            hd.CachGiaoHang = LstPhieuPCGN[0].GiaoNhan != 0 ? "Giao tại nhà khách" : "Giao tại công ty";
            hd.TongTienHang = tongtien;
            hd.TienThanhToanThuc = thuctra;
            hd.TienConNo = tienno;

            //if (ListIdChungTu.Length > 0)
            //    ListIdChungTu = ListIdChungTu.Substring(0, ListIdChungTu.Length - 1);

            hd.NhanVienKinhDoanh = "";
            foreach (ChungTuGiaoNhanChiTietInfor ct in (BindingList<ChungTuGiaoNhanChiTietInfor>)gPhanCongGiaoNhan.DataSource)
            {
                hd.NhanVienKinhDoanh += String.Format("{0}(Phương tiện: {1})", ct.HoTen, ct.TenPhuongTien) +
                                        (String.IsNullOrEmpty(ct.BienSoXe) ? "" : "/" + ct.BienSoXe) + ";";
            }
            hd.GhiChu = ghichu;
            CommonFuns.Instance.InPhieuGiaoNhan(hd, liHangGiaoNhan, -1);
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            try
            {
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

        private void gvHangDaXuat_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
        }

        private void UpdateNhanVien()
        {
            cboNhanVien.DataSource = null;
            List<DMNhanVienInfo> liNhanVien = new List<DMNhanVienInfo>();
            foreach (ChungTuGiaoNhanChiTietInfor ct in (BindingList<ChungTuGiaoNhanChiTietInfor>)gPhanCongGiaoNhan.DataSource)
            {
                DMNhanVienInfo nv = new DMNhanVienInfo();
                nv.IdNhanVien = ct.IdNhanVien;
                nv.MaNhanVien = ct.MaNhanVien;
                nv.HoTen = ct.HoTen;
                liNhanVien.Add(nv);
            }
            cboNhanVien.DataSource = liNhanVien;
            cboNhanVien.DisplayMember = "HoTen";
            cboNhanVien.ValueMember = "IdNhanVien";
            cboNhanVien.SelectedIndex = -1;
        }

        private void bteKhoXuat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void bteKhoXuat_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void bteKhoXuat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}