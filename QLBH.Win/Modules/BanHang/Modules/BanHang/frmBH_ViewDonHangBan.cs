using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms;
using QLBanHang.Modules.BanHang.Reports;
using QLBanHang.Modules.HeThong;
using QLBH.Common;
using QLBH.Common.Providers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.BanHang.Bussiness;
using QLBH.Core.Data;
using QLBH.Core.Providers;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBH_ViewDonHangBan : DevExpress.XtraEditors.XtraForm
    {
        #region "Khai báo biến"
        List<SuDungHoaDonInfor> liSuDungHD = new List<SuDungHoaDonInfor>();
        List<DMTinhInfor> liTinh = new List<DMTinhInfor>();
        List<DMHuyenInfor> liHuyen = new List<DMHuyenInfor>();
        List<DmNgheNghiepInfor> liNgheNghiep = new List<DmNgheNghiepInfor>();

        private ChungTuBanHangInfor ChungTu = new ChungTuBanHangInfor();
        private List<ChungTuBanHangChiTietInfor> liChungTuChiTiet = new List<ChungTuBanHangChiTietInfor>();

        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();

        #endregion

        #region "Các phương thức khởi tạo"
        public frmBH_ViewDonHangBan()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        public frmBH_ViewDonHangBan(ChungTuBanHangInfor chungTuBanHangInfor)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            ChungTu = chungTuBanHangInfor;
        }
        #endregion

        #region "Các phương thức"
        private void LoadKhachHang()
        {
            DMDoiTuongInfo dmDoiTuong = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(ChungTu.IdDoiTuong);
            if (dmDoiTuong != null)
            {
                bteKhachHang.Text = dmDoiTuong.TenDoiTuong;
                bteKhachHang.Tag = dmDoiTuong;
            }
        }

        private void LoadKhoXuat()
        {
            DMKhoInfo dmKho = DMKhoDataProvider.GetKhoByIdInfo(ChungTu.IdKho);
            if (dmKho != null)
            {
                bteKhoXuat.Text = dmKho.TenKho;
                bteKhoXuat.Tag = dmKho;
            }
        }

        private void LoadTrungTam()
        {
            DMTrungTamInfor tt = DMTrungTamDataProvider.GetTrungTamByIdInfo(ChungTu.IdTrungTam);
            if (tt != null)
            {
                grThongTin.Text = String.Format("Trung tâm: {0} - {1}", tt.MaTrungTam, tt.TenTrungTam);
            }
        }
               
        private void LoadChungTuInstance()
        {
            try
            {
                if (ChungTu != null)
                {
                    LoadChungTuHeader();
                    LoadChungTuDetails();
                }             
            }
            catch 
            {
            }
        }

        private void LoadChungTuHeader()
        {
            LoadTrungTam();
            LoadKhoXuat();
            LoadKhachHang();

            txtSoOrderKH.Text = ChungTu.SoChungTu;
            mstNgayLapPhieu.Value = ChungTu.NgayLap;
            txtSoChungTuGoc.Text = ChungTu.SoChungTuGoc;    
            
            txtSoPhieuDC.Text = ChungTu.SoPhieuDC;

            bteThuongVien.Tag = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(ChungTu.IdNhanVien);
            bteThuongVien.Text = bteThuongVien.Tag != null ? ((DMNhanVienInfo)bteThuongVien.Tag).HoTen : "";
            cboGiaoHang.SelectedIndex = ChungTu.GiaoNhan;

            try
            {
                mstNgayHenGiaoHang.Value = ChungTu.NgayHenGiaoHang;
            }
            catch
            {
                mstNgayHenGiaoHang.Value = CommonProvider.Instance.GetSysDate();
            }
            
            txtGhiChu.Text = ChungTu.GhiChu;

            txtSoSerie.Text = ChungTu.SoSeri;
            bteKhachLe.Tag = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(ChungTu.IdKhachLe);
            bteKhachLe.Text = bteKhachHang.Tag != null ? ((DMDoiTuongInfo) bteKhachHang.Tag).TenDoiTuong : "";
            txtCongTy.Text = ChungTu.CongTy;
            txtHoTenKhachHang.Text = ChungTu.HoTen;
            txtDiaChi.Text = ChungTu.DiaChi;
            txtSoHDDaMua.Text = ChungTu.SoHDDaMua;
        }

        private void LoadChungTuDetails()
        {
            liChungTuChiTiet = BanHangDataProvider.Instance.GetListChiTietChungTuByIdChungTu(ChungTu.IdChungTu);
            if (liChungTuChiTiet != null)
            {
                foreach (ChungTuBanHangChiTietInfor ct in liChungTuChiTiet)
                {
                    if (ct.IdSanPhamBan == 0)
                        ct.TenLoaiHangKem = Declare.DescHangBan;
                    else if (ct.LoaiHangKem == 0)
                        ct.TenLoaiHangKem = Declare.DescKhuyenMai;
                    else if (ct.LoaiHangKem == 1)
                        ct.TenLoaiHangKem = Declare.DescHangKem;
                    ct.SoLuongOld = ct.SoLuong;
                }
                gSanPhamBan.DataSource = new BindingList<ChungTuBanHangChiTietInfor>(liChungTuChiTiet);
            }
        }

        private void setEDItems()
        {
            txtSoOrderKH.Enabled = false;
            mstNgayLapPhieu.Enabled = false;
            bteThuongVien.Enabled = false;
            cboGiaoHang.Enabled = false;
            mstNgayHenGiaoHang.Enabled = false;
            txtGhiChu.Enabled = false;

            txtSoSerie.Enabled = false;
            txtSoPhieuDC.Enabled = false;
            bteKhachLe.Enabled = false;
            txtCongTy.Enabled = false;
            txtHoTenKhachHang.Enabled = false;
            txtDiaChi.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSoHDDaMua.Enabled = false;

            bteKhoXuat.Enabled = false;
            bteKhachHang.Enabled = false;

            SoLuong.OptionsColumn.ReadOnly = false;
            ThanhTien.OptionsColumn.ReadOnly = false;
            GhiChu.OptionsColumn.ReadOnly = false;
            txtSoChungTuGoc.ReadOnly = false;

            toolStrip1.Enabled = false;
        }
        #endregion

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            try
            {
                if (ChungTu.IdChungTu > 0)
                {
                    LoadChungTuInstance();
                    setEDItems();
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

        private void tsbPrint_Click(object sender, EventArgs e)
        {

        }
    }
}