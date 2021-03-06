using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QLBanHang.Modules.BanHang.Reports;
using CrystalDecisions.Shared;
using QLBanHang.Modules.DanhMuc;
using QLBH.Common;
using QLBH.Common.Objects;
using QLBH.Common.Providers;
using QLBH.Core.Data;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.DongBoERP;
using QLBH.Core.Form;
using QLBH.Core.Providers;
using DmSanPhamProvider = QLBanHang.Modules.DanhMuc.Providers.DmSanPhamProvider;
using System.Data.OleDb;

//

namespace QLBanHang.Modules.BanHang
{
    public partial class frmCS_LapBangGia : DevExpress.XtraEditors.XtraForm
    {
        #region declare
        private int Draft = -1;//-1:chua ton tai; 1-save, 0-confirm
        private bool IsAdded = false;
        private bool Updating = false;//false: chua sua, tao moi; 1:dang sua, tao moi
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private BangGiaInfor bangGia = null;
        private BangGiaNhapChiTietInfor gn;
        List<BangGiaBanChiTietBCInfor> liNoKMai = new List<BangGiaBanChiTietBCInfor>();
        DataSet dsChungTu;
        #endregion

        public frmCS_LapBangGia()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.bangGia = new BangGiaInfor();
        }
        public frmCS_LapBangGia(BangGiaInfor bangGia)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.bangGia = bangGia;
        }
        public void HideMenu()
        {
            toolStrip1.Visible = false;
            btnTimBangGia.Visible = false;
        }
        //public void ShowMenu()
        //{
        //    toolStrip1.Visible = true;
        //    btnTimBangGia.Visible = true;
        //}
        private void cmdCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                Draft = 1;
                if (UpdateBangGia())
                {
                    Updating = false;
                    setEDItems();
                    setEDFunctions();                   
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
        private void CopyBangGia(List<int> lstIdTrungTam, List<string> lstMaTrungTam, BangGiaInfor bangGia)
        {
            try
            {
                //loc ra cac trung tam khac voi danh sach trung tam cua bang gia
                //string[] arrTT = bangGia.ListMaTrungTam.Split(",".ToCharArray());
                //List<string> lstIdTT = new List<string>(arrTT);
                string lstIdTTamSelected = "";
                string lstMaTTamSelected = "";
                for (int i = 0; i < lstMaTrungTam.Count; i++)
                {
                    //if (!lstIdTT.Contains(lstMaTrungTam[i]))
                    //{
                        lstIdTTamSelected += lstIdTrungTam[i].ToString() + ",";
                        lstMaTTamSelected += lstMaTrungTam[i] + ",";
                    //}
                }
                if (lstIdTTamSelected.Length > 0)
                {
                    lstIdTTamSelected = lstIdTTamSelected.TrimEnd(",".ToCharArray());
                    lstMaTTamSelected = lstMaTTamSelected.TrimEnd(",".ToCharArray());
                }

                ConnectionUtil.Instance.BeginTransaction();
                BangGiaInfor bg = bangGia;                
                //copy header
                bg.Draft = 1;
                bg.IdBangGia = 0;
                bg.SoBangGia = CommonProvider.Instance.GetSoPhieu(Declare.Prefix.BangGiaBan, "tbl_BangGia", "SoBangGia");
                bg.ListIdTrungTam = lstIdTTamSelected;
                bg.ListMaTrungTam = lstMaTTamSelected;
                bg.NgayLap = mstNgayLap.Value;
                bg.NguoiLap = txtNguoiLap.Text;
                bg.GhiChu = "";
                bg.NguoiTao = nguoiDung.TenDangNhap;
                bg.IdBangGia = BangGiaDataProvider.Instance.InsertBangGia(bg);

                //copy details
                if (bg.ListBangGiaChiTiet != null)
                {
                    foreach (BangGiaChiTietInfor bgChiTiet in bg.ListBangGiaChiTiet)
                    {
                        //cap nhat bang gia chi tiet
                        bgChiTiet.IdBangGia = bg.IdBangGia;
                        bgChiTiet.NguoiCapNhat = nguoiDung.TenDangNhap;
                        bgChiTiet.IdChiTiet = BangGiaDataProvider.Instance.InsertBangGiaChiTiet(bgChiTiet);
                        UpdateDataValue(bgChiTiet);
                    }

                    ////tu dong duyet gia
                    //if (Declare.TUDONG_DUYETGIA)
                    //    BangGiaDataProvider.Instance.DuyetBangGia(bg);
                }
                ConnectionUtil.Instance.CommitTransaction();
            }
            catch (Exception)
            {
                ConnectionUtil.Instance.RollbackTransaction();
                throw;
            }
        }

        private void CopyBangGia(string lstIdTTamSelected, string lstMaTTamSelected)
        {
            try
            {
                ConnectionUtil.Instance.BeginTransaction();
                BangGiaInfor bg = bangGia;
                //copy header
                bg.Draft = 1;
                bg.IdBangGia = 0;
                bg.SoBangGia = CommonProvider.Instance.GetSoPhieu(Declare.Prefix.BangGiaBan, "tbl_BangGia", "SoBangGia");
                bg.ListIdTrungTam = lstIdTTamSelected;
                bg.ListMaTrungTam = lstMaTTamSelected;
                bg.NgayLap = mstNgayLap.Value;
                bg.NguoiLap = txtNguoiLap.Text;
                bg.GhiChu = "";
                bg.NguoiTao = nguoiDung.TenDangNhap;
                bg.IdBangGia = BangGiaDataProvider.Instance.InsertBangGia(bg);

                //copy details
                if (bg.ListBangGiaChiTiet != null)
                {
                    foreach (BangGiaChiTietInfor bgChiTiet in bg.ListBangGiaChiTiet)
                    {
                        //cap nhat bang gia chi tiet
                        bgChiTiet.IdBangGia = bg.IdBangGia;
                        bgChiTiet.NguoiCapNhat = nguoiDung.TenDangNhap;
                        bgChiTiet.IdChiTiet = BangGiaDataProvider.Instance.InsertBangGiaChiTiet(bgChiTiet);
                        UpdateDataValue(bgChiTiet);
                    }

                    ////tu dong duyet gia
                    //if (Declare.TUDONG_DUYETGIA)
                    //    BangGiaDataProvider.Instance.DuyetBangGia(bg);
                }
                ConnectionUtil.Instance.CommitTransaction();
            }
            catch (Exception)
            {
                ConnectionUtil.Instance.RollbackTransaction();
                throw;
            }
        }
        private bool UpdateBangGia()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (ValidBangGiaInfor())
                {
                    ConnectionUtil.Instance.BeginTransaction();
                    //cap nhat toan bo thong tin bang gia
                    UpdateAllDataValue();
                    //update header
                    UpdateBangGiaHeader();
                    //update header
                    UpdateBangGiaTrungTam();
                    //update detail
                    UpdateBangGiaDetails();
                    ConnectionUtil.Instance.CommitTransaction();

                    if (IsAdded)
                    {
                        MessageBox.Show("Thêm mới bảng giá thành công!");
                    }
                    else
                        MessageBox.Show("Cập nhật bảng giá thành công!");

                    return true;                    
                }
            }
            catch (Exception)
            {
                ConnectionUtil.Instance.RollbackTransaction();
                if (IsAdded && bangGia != null)
                    bangGia.IdBangGia = 0;              
                throw;
            }
            Cursor.Current = Cursors.Default;
            return false;
        }

        private void UpdateBangGiaDetails()
        {
            //them tung cai moi;
            if (bangGia.ListBangGiaChiTiet != null)
            {

                List<BangGiaChiTietInfor> oldListBGCT = BangGiaDataProvider.Instance.GetAllBangGiaChiTietInfors(bangGia.IdBangGia);
                foreach (BangGiaChiTietInfor bgct in oldListBGCT)
                {
                    if (!bangGia.ListBangGiaChiTiet.Exists(delegate(BangGiaChiTietInfor ct)
                                                              {
                                                                  return ct.IdChiTiet == bgct.IdChiTiet;
                                                              }))
                        BangGiaDataProvider.Instance.DeleteBangGiaChiTiet(bgct);
                }
                foreach (BangGiaChiTietInfor bgChiTiet in bangGia.ListBangGiaChiTiet)
                {
                    if (!bgChiTiet.IsOrigin || IsAdded)//voi nhung chi tiet them hoac sua
                    {
                        //cap nhat bang gia chi tiet
                        bgChiTiet.IdBangGia = bangGia.IdBangGia;
                        bgChiTiet.NguoiCapNhat = nguoiDung.TenDangNhap;// nguoiDung.TenNhanVien + "(" + nguoiDung.TenDangNhap + ")";
                        if (bgChiTiet.IdChiTiet == 0 || IsAdded)
                            bgChiTiet.IdChiTiet = BangGiaDataProvider.Instance.InsertBangGiaChiTiet(bgChiTiet);
                        else
                            BangGiaDataProvider.Instance.UpdateBangGiaChiTiet(bgChiTiet);

                    }
                }

                //tu dong duyet gia
                if (Declare.TUDONG_DUYETGIA && bangGia.Draft == 0)
                    BangGiaDataProvider.Instance.DuyetBangGia(bangGia);  
            }
        }

        private void UpdateBangGiaHeader()
        {
            //bg.IdBangGia = IdBangGia;
            bangGia.Draft = Draft;
            bangGia.SoBangGia = txtSoBangGia.Text;
            bangGia.NgayLap = mstNgayLap.Value;
            bangGia.NguoiLap = txtNguoiLap.Text;
            bangGia.GhiChu = txtGhiChu.Text;
            bangGia.DaDuyet = (int)TinhTrangDuyetGia.CHUA_DUYET;

            if (bangGia.IdBangGia == 0)
            {
                bangGia.NguoiTao = nguoiDung.TenDangNhap;// nguoiDung.TenNhanVien + "(" + nguoiDung.TenDangNhap + ")";
                bangGia.IdBangGia = BangGiaDataProvider.Instance.InsertBangGia(bangGia);
            }
            else
            {
                bangGia.NguoiCapNhat = nguoiDung.TenDangNhap;// nguoiDung.TenNhanVien + "(" + nguoiDung.TenDangNhap + ")";
                BangGiaDataProvider.Instance.UpdateBangGia(bangGia);
            }
        }

        private void UpdateBangGiaTrungTam()
        {
            //xoa bang gia trung tam
            BangGiaDataProvider.Instance.DeleteBangGiaTrungTam(bangGia.IdBangGia);
            //them bang gia trung tam
            string[] arrIdTTam = bangGia.ListIdTrungTam.Split(",".ToCharArray());
            foreach (string sIdTT in arrIdTTam)
            {
                int idTT = Common.IntValue(sIdTT);
                BangGiaDataProvider.Instance.InsertBangGiaTrungTam(bangGia.IdBangGia, idTT);
            }
        }

        private void UpdateAllDataValue()
        {
            double tongLoiNhuan = 0;
            if (gSanPham.DataSource == null) return;
            string[] arIdTrungTam = bangGia.ListIdTrungTam.Split(",".ToCharArray());
            string khuyemai = "";
            int iddkmua = 0;
            foreach (BangGiaChiTietInfor bgct in (BindingList<BangGiaChiTietInfor>)gSanPham.DataSource)
            {
                //get khuyen mai
                
                bgct.TienKhuyenMai = CommonFuns.Instance.GetTienKhuyenMai(Common.IntValue(arIdTrungTam[0]), bgct.IdSanPham,
                                                                          bgct.MaSanPham, mstNgayLap.Value,
                                                                          Common.MaxValues(bgct.DonGiaCoVAT,
                                                                                           bgct.GiaBanBuon,
                                                                                           bgct.GiaBanDemo,
                                                                                           bgct.GiaNhapDemoCuoi,
                                                                                           bgct.GiaTonKhoBQ,
                                                                                           bgct.GiaNhapHDCuoi),
                                                                          bgct.DonGiaCoVAT, bgct.TyLeVAT, ref khuyemai, ref iddkmua);
                bgct.IdDKMua = iddkmua;
                bgct.KhuyenMai = khuyemai;
                bgct.GiaMin = (bgct.GiaNhapHDCuoi - bgct.TienChietKhauQK + bgct.TienKhuyenMai) *
                              (1 + bgct.TyLeLNBQ * (1 - bgct.DungSaiMin / 100) / 100);
                bgct.GiaMax = (bgct.GiaNhapHDCuoi - bgct.TienChietKhauQK + bgct.TienKhuyenMai) *
                              (1 + bgct.TyLeLNBQ * (1 + bgct.DungSaiMax / 100) / 100);
                bgct.GiaBanAnToan = (bgct.GiaNhapHDCuoi - bgct.TienChietKhauQK + bgct.TienKhuyenMai) *
                                    (1 + bgct.TyLeLNBQ / 100);
                bgct.DonGiaChuaVAT = bgct.DonGiaCoVAT / (1 + bgct.TyLeVAT / 100) / (1 - bgct.TyLeChietKhau / 100);
                bgct.TienChietKhau = bgct.DonGiaChuaVAT * bgct.TyLeChietKhau / 100;
                bgct.TienVAT = bgct.DonGiaCoVAT - bgct.DonGiaChuaVAT + bgct.TienChietKhau;
                bgct.LoiNhuan = bgct.DonGiaChuaVAT - bgct.GiaNhapHDCuoi + bgct.TienChietKhauQK - bgct.TienKhuyenMai - bgct.ThuongNong;// * bgct.SoLuongBanBQ * (1 + bgct.DungSaiSLBQ / 100);
                bgct.LoiNhuanTon = bgct.DonGiaChuaVAT - bgct.GiaTonKhoBQ + bgct.TienChietKhauQK - bgct.TienKhuyenMai - bgct.ThuongNong;
                //bgct.GiaNiemYet = bgct.DonGiaCoVAT;
                //bgct.GiaWebSite = bgct.DonGiaCoVAT;
                double giaBanBuonChuaVat = bgct.GiaBanBuon / (1 + bgct.TyLeVAT / 100) / (1 - bgct.TyLeChietKhau / 100);
                bgct.LoiNhuanBB = giaBanBuonChuaVat - bgct.GiaNhapHDCuoi + bgct.TienChietKhauQK - bgct.TienKhuyenMai - bgct.ThuongNong;// * bgct.SoLuongBanBQ * (1 + bgct.DungSaiSLBQ / 100);
                bgct.LoiNhuanTon = giaBanBuonChuaVat - bgct.GiaTonKhoBQ + bgct.TienChietKhauQK - bgct.TienKhuyenMai - bgct.ThuongNong;
                double giaBanDemoChuaVat = bgct.GiaBanDemo / (1 + bgct.TyLeVAT / 100) / (1 - bgct.TyLeChietKhau / 100);
                bgct.LoiNhuanDemo = giaBanDemoChuaVat - bgct.GiaNhapDemoCuoi - bgct.ThuongNong;// * bgct.SoLuongBanBQ * (1 + bgct.DungSaiSLBQ / 100);

                //get nhom duyet
                BangGiaNhomNguoiDuyetInfor nnd = BangGiaDataProvider.Instance.GetNhomNguoiDuyetBangGiaInfor(bgct.MaSanPham, bgct.DonGiaCoVAT, bgct.GiaNhapHDCuoi,
                                                                                                            bgct.TienChietKhauQK, bgct.TienKhuyenMai, bgct.TyLeLNBQ);
                if (nnd != null)
                {
                    bgct.IdNhomDuyet = nnd.IdNhomNguoiDung;
                    bgct.NhomDuyet = nnd.TenNhomNguoiDung;
                }
                else
                {
                    bgct.IdNhomDuyet = 0;
                    bgct.NhomDuyet = "Chưa phân nhóm duyệt";
                }

                //tinh thuong nhan vien
                bgct.TyLeThuong = (bgct.DonViDoanhThu != 0 ? bgct.DonGiaCoVAT * bgct.TrongSoDoanhThu / bgct.DonViDoanhThu : 0) +
                                  (bgct.DonViLoiNhuan != 0
                                       ? (bgct.DonGiaChuaVAT - bgct.TienChietKhau - bgct.TienKhuyenMai -
                                          bgct.GiaTonKhoBQ)*
                                         bgct.TrongSoLoiNhuan / bgct.DonViLoiNhuan
                                       : 0) +
                                  (bgct.DonViKhoanTon != 0
                                       ? bgct.TonKho * bgct.GiaTonKhoBQ * bgct.TrongSoKhoanTon / bgct.DonViKhoanTon
                                       : 0);

                if (bgct.DonGiaChuaVAT > bgct.GiaMax || bgct.DonGiaChuaVAT < bgct.GiaMin)
                {
                    //Common.SetGridViewRowErrorStyle(dgvSanPham.CurrentRow);
                    bgct.DaDuyet = 0;
                }
                else
                {
                    //Common.SetGridViewRowStyle(dgvSanPham.CurrentRow);
                    bgct.DaDuyet = 1;

                }
                //update loi nhuan
                tongLoiNhuan += bgct.LoiNhuan;
            }
            //((BindingList<BangGiaChiTietInfor>)dgvSanPham.DataSource).ResetBindings();

            txtTongLoiNhuan.Text = Common.Double2Str(tongLoiNhuan);
        }

        private void UpdateDataValue(BangGiaChiTietInfor bgct)
        {
            if (bgct == null) return;
            //get khuyen mai
            string[] arIdTrungTam = bangGia.ListIdTrungTam.Split(",".ToCharArray());
            string khuyemai = "";
            int iddkmua = 0;
            bgct.TienKhuyenMai = CommonFuns.Instance.GetTienKhuyenMai(Common.IntValue(arIdTrungTam[0]), bgct.IdSanPham, bgct.MaSanPham,
                                                                      mstNgayLap.Value,
                                                                      Common.MaxValues(bgct.DonGiaCoVAT, bgct.GiaBanBuon,
                                                                                       bgct.GiaBanDemo,
                                                                                       bgct.GiaNhapDemoCuoi,
                                                                                       bgct.GiaTonKhoBQ,
                                                                                       bgct.GiaNhapHDCuoi),
                                                                      bgct.DonGiaCoVAT, bgct.TyLeVAT, ref khuyemai, ref iddkmua);
            bgct.IdDKMua = iddkmua;
            bgct.KhuyenMai = khuyemai;
            bgct.GiaMin = (bgct.GiaNhapHDCuoi - bgct.TienChietKhauQK + bgct.TienKhuyenMai) *
                          (1 + bgct.TyLeLNBQ * (1 - bgct.DungSaiMin/100) / 100);
            bgct.GiaMax = (bgct.GiaNhapHDCuoi - bgct.TienChietKhauQK + bgct.TienKhuyenMai) *
                          (1 + bgct.TyLeLNBQ * (1 + bgct.DungSaiMax/100) / 100);
            bgct.GiaBanAnToan = (bgct.GiaNhapHDCuoi - bgct.TienChietKhauQK + bgct.TienKhuyenMai) *
                                (1 + bgct.TyLeLNBQ / 100);
            bgct.DonGiaChuaVAT = bgct.DonGiaCoVAT / (1 + bgct.TyLeVAT / 100) / (1 - bgct.TyLeChietKhau / 100);
            bgct.TienChietKhau = bgct.DonGiaChuaVAT * bgct.TyLeChietKhau / 100;
            bgct.TienVAT = bgct.DonGiaCoVAT - bgct.DonGiaChuaVAT + bgct.TienChietKhau;
            //bgct.DonGiaCoVAT = bgct.DonGiaChuaVAT - bgct.TienChietKhau + bgct.TienVAT;
            bgct.LoiNhuan = bgct.DonGiaChuaVAT - bgct.GiaNhapHDCuoi + bgct.TienChietKhauQK - bgct.TienKhuyenMai - bgct.ThuongNong;// * bgct.SoLuongBanBQ * (1 + bgct.DungSaiSLBQ / 100);
            bgct.LoiNhuanTon = bgct.DonGiaChuaVAT - bgct.GiaTonKhoBQ + bgct.TienChietKhauQK - bgct.TienKhuyenMai - bgct.ThuongNong;
            bgct.GiaNiemYet = bgct.DonGiaCoVAT;
            bgct.GiaWebSite = bgct.DonGiaCoVAT;
            double giaBanBuonChuaVat = bgct.GiaBanBuon / (1 + bgct.TyLeVAT / 100) / (1 - bgct.TyLeChietKhau / 100);
            bgct.LoiNhuanBB = giaBanBuonChuaVat - bgct.GiaNhapHDCuoi + bgct.TienChietKhauQK - bgct.TienKhuyenMai - bgct.ThuongNong;// * bgct.SoLuongBanBQ * (1 + bgct.DungSaiSLBQ / 100);
            bgct.LoiNhuanTon = giaBanBuonChuaVat - bgct.GiaTonKhoBQ + bgct.TienChietKhauQK - bgct.TienKhuyenMai - bgct.ThuongNong;
            double giaBanDemoChuaVat = bgct.GiaBanDemo / (1 + bgct.TyLeVAT / 100) / (1 - bgct.TyLeChietKhau / 100);
            bgct.LoiNhuanDemo = giaBanDemoChuaVat - bgct.GiaNhapDemoCuoi - bgct.ThuongNong;// * bgct.SoLuongBanBQ * (1 + bgct.DungSaiSLBQ / 100);

            //get nhom duyet
            BangGiaNhomNguoiDuyetInfor nnd = BangGiaDataProvider.Instance.GetNhomNguoiDuyetBangGiaInfor(bgct.MaSanPham, bgct.DonGiaCoVAT, bgct.GiaNhapHDCuoi,
                                                                                                        bgct.TienChietKhauQK, bgct.TienKhuyenMai, bgct.TyLeLNBQ);
            if (nnd != null)
            {
                bgct.IdNhomDuyet = nnd.IdNhomNguoiDung;
                bgct.NhomDuyet = nnd.TenNhomNguoiDung;
            }
            else
            {
                bgct.IdNhomDuyet = 0;
                bgct.NhomDuyet = "Chưa phân nhóm duyệt";                
            }

            //tinh thuong nhan vien
            bgct.TyLeThuong = (bgct.DonViDoanhThu != 0 ? bgct.DonGiaCoVAT * bgct.TrongSoDoanhThu / bgct.DonViDoanhThu : 0) +
                              (bgct.DonViLoiNhuan != 0
                                   ? (bgct.DonGiaChuaVAT - bgct.TienChietKhau - bgct.TienKhuyenMai -
                                      bgct.GiaTonKhoBQ) *
                                     bgct.TrongSoLoiNhuan / bgct.DonViLoiNhuan
                                   : 0) +
                              (bgct.DonViKhoanTon != 0
                                   ? bgct.TonKho * bgct.GiaTonKhoBQ * bgct.TrongSoKhoanTon / bgct.DonViKhoanTon
                                   : 0);

            if (bgct.DonGiaChuaVAT > bgct.GiaMax || bgct.DonGiaChuaVAT<bgct.GiaMin)
            {
                //Common.SetGridViewRowErrorStyle(dgvSanPham.CurrentRow);
                bgct.DaDuyet = 0;
            }
            else
            {
                //Common.SetGridViewRowStyle(dgvSanPham.CurrentRow);
                bgct.DaDuyet = 1;
                
            }
            //update lai datagrid
            //((BindingList<BangGiaChiTietInfor>)dgvSanPham.DataSource).ResetBindings();
            //UpdateTongLoiNhuan();                   
        }
                    
        private void UpdateTongLoiNhuan()
        {
            double tongLoiNhuan = 0;
            foreach (BangGiaChiTietInfor bgChiTiet in  (BindingList<BangGiaChiTietInfor>)gSanPham.DataSource)
            {
                tongLoiNhuan += bgChiTiet.LoiNhuan;
            }
            txtTongLoiNhuan.Text = Common.Double2Str(tongLoiNhuan);
        }

        private void frm_BangGia_Load(object sender, EventArgs e)
        {
            try
            {
                //gan bang gia hien tai
                if (bangGia.IdBangGia > 0)
                {
                    LoadBangGiaInfor();
                    if (bangGia.Draft == 1 && nguoiDung.TenDangNhap.Equals(bangGia.NguoiTao) || nguoiDung.SupperUser == 1)
                        btnSua_Click(sender, e);
                    else
                    {
                        IsAdded = false;
                        Updating = false;
                        setEDItems();
                        setEDFunctions();
                        if (!nguoiDung.TenDangNhap.Equals(bangGia.NguoiTao))
                        {
                            HideMenu();
                            txtGhiChu.Enabled = true;
                            txtGhiChu.ReadOnly = true;
                            btnAddGhiChu.Visible = true;
                        }
                    }
                }
                else
                {
                    btnThem_Click(sender, e);
                    if (bangGia.IdBangGia == 0 && !Updating)
                        this.Close();
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

        private void LoadBangGiaInfor()
        {
            if (bangGia != null)
            {
                //load bang gia infor
                LoadBGHeader();
                LoadBGDetais();               
            }
            else
            {
                ResetBangGiaInfor();
            }
        }

        private void LoadBGHeader()
        {
            Draft = bangGia.Draft;
            txtSoBangGia.Text = bangGia.SoBangGia;
            txtTenTrungTam.Text = bangGia.ListMaTrungTam;
            chkDaDuyet.Checked = Common.Int2Bool(bangGia.DaDuyet);
            mstNgayLap.Value = bangGia.NgayLap;
            txtNguoiLap.Text = bangGia.NguoiLap;
            txtNgayDuyet.Text = Common.Date2LongString(bangGia.NgayDuyet);
            txtGhiChu.Text = bangGia.GhiChu;
        }

        private void LoadBGDetais()
        {
            bangGia.ListBangGiaChiTiet = BangGiaDataProvider.Instance.GetAllBangGiaChiTietInfors(bangGia.IdBangGia);
            gSanPham.DataSource = new BindingList<BangGiaChiTietInfor>(bangGia.ListBangGiaChiTiet)
                                        {
                                            AllowEdit = true,
                                            AllowNew = true,
                                            AllowRemove = true,
                                            RaiseListChangedEvents = true                                            
                                        };
            gvSanPham.Columns["NganhHang"].GroupIndex = 0;
            gvSanPham.ExpandAllGroups();

            UpdateTongLoiNhuan();
        }

        /// <summary>
        /// Enable, disable các ô nhập liệu
        /// </summary>
        private void setEDItems()
        {
            //bool status = Updating ? true : false;
            txtSoBangGia.Enabled = Updating && bangGia.IdBangGia == 0;
            //chkDaDuyet.Enabled = Updating && Common.Int2Bool(nguoiDung.SupperUser);
            mstNgayLap.Enabled = Updating;
            txtNguoiLap.Enabled = Updating;
            //txtNgayDuyet.Enabled = Updating;
            //txtNguoiDuyet.Enabled = Updating;
            //txtTenTrungTam.Enabled = Updating;
            txtGhiChu.Enabled = Updating;

            btnLoadSP.Enabled = Updating;
            cmdDongBoGiaNhap.Enabled = Updating;
            txtMaSanPham.Enabled = Updating;
            btnThemCT.Enabled = Updating;
            cmdXoaChiTiet.Enabled = Updating;
            //btnDayKM.Enabled = Updating;
            //btnDayKM.Visible = Common.Int2Bool(nguoiDung.SupperUser);
        }
        /// <summary>
        /// Enable, disable các menu chức năng: Add, Save, Updade,...
        /// </summary>
        private void setEDFunctions()
        {
            btnThem.Enabled = !Updating;
            btnSaoChep.Enabled = !Updating && (bangGia.IdBangGia > 0);
            btnSua.Enabled = !Updating && (Common.Int2Bool(Draft) && nguoiDung.TenDangNhap.Equals(bangGia.NguoiTao) || Common.Int2Bool(nguoiDung.SupperUser)) && (bangGia.IdBangGia > 0);
            btnCapNhat.Enabled = Updating;
            btnXoa.Enabled = Common.Int2Bool(Draft) && nguoiDung.TenDangNhap.Equals(bangGia.NguoiTao) || Common.Int2Bool(nguoiDung.SupperUser);
            btnConfirm.Enabled = Updating;
            tsbImport.Enabled = Updating;
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidEditBangGia())
                {
                    MessageBox.Show("Bảng giá này đã được xác nhận, không thể xóa được!");
                }
                else
                {
                    DeleteBangGia();
                }
                Updating = false;
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

        private void DeleteBangGia()
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa bảng giá này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bangGia.IdBangGia > 0)
                    {
                        BangGiaDataProvider.Instance.DeleteBangGia(bangGia.IdBangGia);    
                    }
                    MessageBox.Show("Xóa bảng giá thành công!");
                    this.Close();
                }                    
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi thực hiện Xóa bảng giá\n" + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi thực hiện Xóa bảng giá", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif                
            }
        }

        private void frm_BangGia_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Common.LogAction("Đóng form", "Đóng form " + this.Name, Declare.IdKho);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCS_ChonTrungTam frm = new frmCS_ChonTrungTam(true);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ResetBangGiaInfor();
                    //int idTrungTam = frm.IdTTamSelected;
                    //if (idTrungTam > 0)
                    //{
                    //    ThemMoiBangGia(frm.IdTTamSelected, frm.TenTTamSelected);

                    //    Updating = true;
                    //    setEDItems();
                    //    setEDFunctions();                        
                    //}
                    if (frm.LstIdTrungTam.Length > 0)
                    {
                        ThemMoiBangGia(frm.LstIdTrungTam, frm.LstMaTrungTam);

                        Updating = true;
                        setEDItems();
                        setEDFunctions();
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

        private void ThemMoiBangGia(string lstIdTrungTam, string lstMaTrungTam)
        {
            //khoi tao tham so bang gia
            Draft = -1;
            IsAdded = true;

            //tao bang gia moi
            //IdBangGia = 0;            
            bangGia = new BangGiaInfor();
            bangGia.ListIdTrungTam = lstIdTrungTam;
            bangGia.ListMaTrungTam = lstMaTrungTam;
            txtSoBangGia.Text = CommonProvider.Instance.GetSoPhieu(Declare.Prefix.BangGiaBan, "tbl_BangGia", "SoBangGia");
            txtTenTrungTam.Text = lstMaTrungTam;

            bangGia.ListBangGiaChiTiet = new List<BangGiaChiTietInfor>();
            gSanPham.DataSource = new BindingList<BangGiaChiTietInfor>(bangGia.ListBangGiaChiTiet)
            {
                AllowEdit = true,
                AllowNew = true,
                AllowRemove = true,
                RaiseListChangedEvents = true
            };
        }

        private void ResetBangGiaInfor()
        {
            txtSoBangGia.ResetText();
            chkDaDuyet.Checked = false;
            mstNgayLap.Value = CommonProvider.Instance.GetSysDate();
            txtNguoiLap.Text = nguoiDung.TenNhanVien;
            txtNgayDuyet.ResetText();
            txtTenTrungTam.ResetText();
            txtGhiChu.ResetText();  
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidEditBangGia())
                {
                    MessageBox.Show("Bảng giá này đã được xác nhận, không thể sửa được!");
                }
                else
                {
                    IsAdded = false;
                    Updating = true;
                    setEDItems();
                    setEDFunctions();
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

        private bool ValidEditBangGia()
        {
            if (bangGia.IdBangGia == 0 || bangGia.IdBangGia > 0 && (bangGia.DaDuyet == 0 || bangGia.DaDuyet == 2 || nguoiDung.SupperUser == 1))
            {
                return true;
            }

            return false;
        }

        private bool ValidBangGiaInfor()
        {
            //Kiem tra thong tin day du
            if (txtSoBangGia.Text.Trim().Equals(""))
            {
                MessageBox.Show("Số bảng giá chưa có. Xin mời nhập!");
                txtSoBangGia.Focus();
                return false;
            }

            //Kiem tra trung So bang gia
            if (BangGiaDataProvider.Instance.ExistBangGia(txtSoBangGia.Text.Trim(), bangGia.IdBangGia))
            {
                MessageBox.Show("Số bảng giá đã tồn tại. Mời nhập lại!");
                txtSoBangGia.Focus();
                return false;
            }
            if (bangGia.ListBangGiaChiTiet == null || bangGia.ListBangGiaChiTiet.Count==0)
            {
                MessageBox.Show("Bảng giá không có dữ liệu. Mời nhập lại!");
                return false;                
            }
            return true;
        }

        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            try
            {
                frmCS_ChonTrungTam frm = new frmCS_ChonTrungTam(true);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (frm.LstIdTrungTam.Length > 0)
                    {
                        //CopyBangGia(frm.ListIdTTamSelected, frm.ListTenTTamSelected, bangGia);
                        CopyBangGia(frm.LstIdTrungTam, frm.LstMaTrungTam);

                        MessageBox.Show("Sao chép bảng giá thành công!");
                        Updating = false;
                        setEDItems();
                        setEDFunctions();
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


        private void sExportToExcel(int LuaChon)
        {

            //Cursor.Current = Cursors.WaitCursor; 
            ////Tao thu muc C:\Temp neu chu co
            //string tmpDir=Declare.TempDirectory;
            //if (!Directory.Exists(tmpDir))
            //    Directory.CreateDirectory(tmpDir);
            //string FileName = string.Format(@"{1}\BangGia{0}.xls", DateTime.Now.Ticks, tmpDir);
            //string FileTemplate = string.Format(@"{0}\MauBangGia.xls", Application.StartupPath + "\\Temp");
            //string kq;
            //if (LuaChon==1)
            //    kq=clsExcel.ExportToExcel(g1BG,FileName,FileTemplate,"","",0);
            //else
            //    kq = clsExcel.ExportToExcel(g1BG, FileName, FileTemplate, txtMaSP.Text, txtTenSP.Text, ut.getInt(cboNganh.SelectedValue));
            //Cursor.Current = Cursors.Default;
            //if (kq != "")
            //{
            //    if (MessageBox.Show("Đã hoàn thành Export. File được export tại '" + kq + "'. Bạn có muốn mở file này không (Yes/No)?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //        Process.Start(FileName);
            //}
            //else
            //    MessageBox.Show("Lỗi Export ra excel!");

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (Updating)
            {
                if (MessageBox.Show("Dữ liệu đang cập nhật, bạn có muốn hủy bỏ không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            }
            search(sender, e);
        }
        private void search(object sender, EventArgs e)
        {
            frmCS_TimKiem_BangGia frm = new frmCS_TimKiem_BangGia(1);
            if (frm.ShowDialog() == DialogResult.OK && frm.BangGia != null)
            {
                bangGia = frm.BangGia;
                //hien thi thong tin bang gia hien tai
                LoadBangGiaInfor();
                //Thiet lap trang thai item
                Updating = false;
                setEDItems();
                setEDFunctions();
            }     
        }

        private void frm_BangGia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5 && btnThem.Enabled) 
                this.btnThem_Click(sender, e);
            else if (e.KeyCode == Keys.F6 && btnSua.Enabled)
                this.btnSua_Click(sender, e);
            else if (e.KeyCode == Keys.F7 && btnCapNhat.Enabled)
            {
                txtSoBangGia.Focus();
                this.cmdCapNhat_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F8 && btnXoa.Enabled)
                this.cmdXoa_Click(sender, e);
            else if (e.KeyCode == Keys.F10 && btnTimKiem.Enabled)
                this.btnTimKiem_Click(sender, e);
            else if (e.KeyCode == Keys.F12 && btnDong.Enabled)
                this.btnDong_Click(sender, e);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdXoaChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvSanPham.FocusedRowHandle < 0) return;
                if (MessageBox.Show("Bạn có chắc chắn xóa các sản phẩm này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gvSanPham.DeleteSelectedRows();
                    UpdateTongLoiNhuan();
                }
            }
            catch { }
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            List<DMSanPhamBriefInfo> liSanPham = new List<DMSanPhamBriefInfo>();
            DMSanPhamBriefInfo spham = DmSanPhamProvider.GetSanPhamBriefByNSDMa(txtMaSanPham.Text.Trim(),
                                                                             (nguoiDung.SupperUser == 1
                                                                                  ? -1
                                                                                  : nguoiDung.IdNhomNguoiDung));
            if (spham != null)
            {
                liSanPham.Add(spham);
            }
            else
            {
                frmLookUp_HangHoa frm = new frmLookUp_HangHoa(true,
                                                              (Common.Int2Bool(nguoiDung.SupperUser)
                                                                   ? -1
                                                                   : nguoiDung.IdNhomNguoiDung), 1, -1);
                if (frm.ShowDialog() == DialogResult.OK && frm.SelectedItems.Count > 0)
                {
                    liSanPham.AddRange(frm.SelectedItems);
                }

            }
            if (liSanPham.Count > 0)
            {
                if (gvSanPham.DataSource == null)
                {
                    bangGia.ListBangGiaChiTiet = new List<BangGiaChiTietInfor>();
                    gSanPham.DataSource = new BindingList<BangGiaChiTietInfor>(bangGia.ListBangGiaChiTiet)
                    {
                        AllowEdit = true,
                        AllowNew = true,
                        AllowRemove = true,
                        RaiseListChangedEvents = true
                    };
                }

                foreach (DMSanPhamBriefInfo sp in liSanPham)
                {
                    if (!ExistMaSanPham(sp.MaSanPham))
                    {
                        BangGiaChiTietInfor bgct = null;
                        string[] arIdTrungTam = bangGia.ListIdTrungTam.Split(",".ToCharArray());
                        BangGiaNhapChiTietInfor gn = BangGiaDataProvider.Instance.GetGiaNhapChiTietInfor(sp.MaSanPham, Common.IntValue(arIdTrungTam[0]), nguoiDung.IdNhomNguoiDung);
                        if (gn == null)
                        {
                            bgct = new BangGiaChiTietInfor()
                            {
                                NganhHang = sp.NganhHang,
                                IdSanPham = sp.IdSanPham,
                                MaSanPham = sp.MaSanPham,
                                TenSanPham = sp.TenSanPham,
                                DonViTinh = sp.TenDonViTinh,
                                TyLeVAT = sp.TyLeVAT,
                                HangKhuyenMai = sp.HangKhuyenMai
                            };
                        }
                        else
                        {
                            bgct = new BangGiaChiTietInfor(gn);
                        }

                        UpdateDataValue(bgct);
                        ((BindingList<BangGiaChiTietInfor>)gSanPham.DataSource).Add(bgct);
                    }
                }
                ((BindingList<BangGiaChiTietInfor>)gSanPham.DataSource).ResetBindings();  
                UpdateTongLoiNhuan();
            }
        } 

        private bool ExistMaSanPham(string maSP)
        {
            foreach (BangGiaChiTietInfor bg in (BindingList<BangGiaChiTietInfor>)gSanPham.DataSource)
            {
                if (bg.MaSanPham.Equals(maSP))
                    return true;
            }
            return false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            try
            {
                Draft = 0;
                if (UpdateBangGia())
                {
                    Updating = false;
                    setEDItems();
                    setEDFunctions();
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

        private void btnLoadSP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn nạp toàn bộ sản phẩm không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            List<DMSanPhamBriefInfo> liSanPham =
                QLBanHang.Modules.DanhMuc.Providers.DmSanPhamProvider.GetListSanPhamBrief(
                    (Common.Int2Bool(nguoiDung.SupperUser) ? -1 : nguoiDung.IdNguoiDung), 1, -1);
            bangGia.ListBangGiaChiTiet = new List<BangGiaChiTietInfor>();
            gSanPham.DataSource = new BindingList<BangGiaChiTietInfor>(bangGia.ListBangGiaChiTiet)
            {
                AllowEdit = true,
                AllowNew = true,
                AllowRemove = true,
                RaiseListChangedEvents = true
            };

            foreach (DMSanPhamBriefInfo sp in liSanPham)
            {
                BangGiaChiTietInfor bgct = null;
                BangGiaNhapChiTietInfor gn = BangGiaDataProvider.Instance.GetGiaNhapChiTietInfor(sp.MaSanPham, bangGia.IdTrungTam, nguoiDung.IdNhomNguoiDung);

                if (gn == null)
                {
                    bgct = new BangGiaChiTietInfor()
                    {
                        NganhHang = sp.NganhHang,
                        IdSanPham = sp.IdSanPham,
                        MaSanPham = sp.MaSanPham,
                        TenSanPham = sp.TenSanPham,
                        DonViTinh = sp.TenDonViTinh,
                        TyLeVAT = sp.TyLeVAT
                    };

                }
                else
                {
                    bgct = new BangGiaChiTietInfor(gn);
                }

                ((BindingList<BangGiaChiTietInfor>)gSanPham.DataSource).Add(bgct);
            }
            ((BindingList<BangGiaChiTietInfor>)gSanPham.DataSource).ResetBindings();
            UpdateAllDataValue();
        }

        private void LoadDuLieu()
        {
            string[] arIdTrungTam = bangGia.ListIdTrungTam.Split(",".ToCharArray());
            string listItem = "";
            foreach (BangGiaChiTietInfor bg in bangGia.ListBangGiaChiTiet)
            {
                listItem += bg.MaSanPham + ",";
            }
            if (listItem.Length > 0) listItem = listItem.Substring(0, listItem.Length - 1);
            BusinessSynchronize.Instance.GiaNhapSync(listItem);//lay gia ban

            frmProgress.Instance.Value = bangGia.ListBangGiaChiTiet.Count;
            frmProgress.Instance.Description = "Đã đồng bộ dữ liệu xong. Đang nạp dữ liệu ....";
            frmProgress.Instance.MaxValue = bangGia.ListBangGiaChiTiet.Count;

            //for (int i=0; i< bangGia.ListBangGiaChiTiet.Count; i++)
            //{
            //    BangGiaNhapChiTietInfor gn = BangGiaDataProvider.Instance.GetGiaNhapChiTietInfor(bangGia.ListBangGiaChiTiet[i].MaSanPham,
            //                                                                                    Declare.
            //                                                                                        IdTrungTam);
            //    if (gn != null)
            //    {
            //        BangGiaDataProvider.Instance.UpdateGiaNhap2BGiaCTiet(gn, bangGia.ListBangGiaChiTiet[i]);
            //    }                   
            //})

            for (int i = 0; i < bangGia.ListBangGiaChiTiet.Count; i++)
            {
                frmProgress.Instance.Value = i + 1;
                frmProgress.Instance.Description =
                    String.Format("Đang nạp dữ liệu cho sản phẩm {0}....",
                                  bangGia.ListBangGiaChiTiet[i].MaSanPham);

                gn = BangGiaDataProvider.Instance.GetGiaNhapChiTietInfor(bangGia.ListBangGiaChiTiet[i].MaSanPham, Common.IntValue(arIdTrungTam[0]), nguoiDung.IdNhomNguoiDung);

                //HAH: chưa hiểu tại sao lại phải thêm dòng này thì mới get info được!!!
                if (gn == null)
                    gn = BangGiaDataProvider.Instance.GetGiaNhapChiTietInfor(bangGia.ListBangGiaChiTiet[i].MaSanPham, Common.IntValue(arIdTrungTam[0]), nguoiDung.IdNhomNguoiDung);

                if (gn != null)
                {
                    bangGia.ListBangGiaChiTiet[i].GiaNhapHDCuoi = gn.GiaNhapHDCuoi;
                    bangGia.ListBangGiaChiTiet[i].GiaTonKhoBQ = gn.GiaTonKhoBQ;
                    bangGia.ListBangGiaChiTiet[i].TienChietKhauQK = gn.TienChietKhauQK;
                    bangGia.ListBangGiaChiTiet[i].TyLeLNBQ = gn.TyLeLNBQ;
                    bangGia.ListBangGiaChiTiet[i].SoLuongBanBQ = gn.SoLuongBanBQ;
                    bangGia.ListBangGiaChiTiet[i].DungSaiMin = gn.DungSaiMin;
                    bangGia.ListBangGiaChiTiet[i].DungSaiMax = gn.DungSaiMax;
                    bangGia.ListBangGiaChiTiet[i].TyLeVAT = gn.TyLeVAT;
                    bangGia.ListBangGiaChiTiet[i].DonViDoanhThu = gn.DonViDoanhThu;
                    bangGia.ListBangGiaChiTiet[i].TrongSoDoanhThu = gn.TrongSoDoanhThu;
                    bangGia.ListBangGiaChiTiet[i].DonViLoiNhuan = gn.DonViLoiNhuan;
                    bangGia.ListBangGiaChiTiet[i].TrongSoLoiNhuan = gn.TrongSoLoiNhuan;
                    bangGia.ListBangGiaChiTiet[i].DonViKhoanTon = gn.DonViKhoanTon;
                    bangGia.ListBangGiaChiTiet[i].TrongSoKhoanTon = gn.TrongSoKhoanTon;
                    bangGia.ListBangGiaChiTiet[i].TonKho = gn.TonKho;
                    bangGia.ListBangGiaChiTiet[i].GiaNhapDemoCuoi = gn.GiaNhapDemoCuoi;
                }
            }

            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            frmProgress.Instance.IsCompleted = true;
            frmProgress.Instance.Description = "Đã xong";
        }
        private void cmdDongBoGiaNhap_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đồng bộ toàn bộ sản phẩm từ Oracle không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            //dong bo gia nhap tu Oracle
            //BusinessSynchronize.Instance.GiaNhapSync()
            //them tung cai moi;
            if (bangGia.ListBangGiaChiTiet != null)
            {
                frmProgress.Instance.Description = "Đang đồng bộ dữ liệu ....";
                frmProgress.Instance.MaxValue = bangGia.ListBangGiaChiTiet.Count;
                frmProgress.Instance.Value = 0;
                frmProgress.Instance.DoWork(LoadDuLieu);

                ((BindingList<BangGiaChiTietInfor>)gSanPham.DataSource).ResetBindings();
                UpdateAllDataValue();
            }
        }

        private void gvSanPham_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (gvSanPham.FocusedRowHandle < 0) return;
            if (e.Column.FieldName == "DonGiaCoVAT" || e.Column.FieldName == "GiaBanBuon" || e.Column.FieldName == "GiaBanDemo" || e.Column.FieldName == "ThuongNong")
            {
                BangGiaChiTietInfor bgct = (BangGiaChiTietInfor)gvSanPham.GetRow(gvSanPham.FocusedRowHandle);
                if (e.Column.FieldName == "DonGiaCoVAT")
                {
                    bgct.GiaBanDemo = bgct.DonGiaCoVAT;
                    bgct.GiaBanBuon = bgct.DonGiaCoVAT;
                }
                UpdateDataValue(bgct);
                UpdateTongLoiNhuan();
            }
        }

        private void btnTimBangGia_Click(object sender, EventArgs e)
        {
            BangGiaInfor bg = BangGiaDataProvider.Instance.GetBangGiaInfor(txtSoBangGia.Text);

            if (bg == null)
            {
                MessageBox.Show("Không có bảng giá này");
                if (!Updating && bangGia!= null)
                    txtSoBangGia.Text = bangGia.SoBangGia;
            }
            else
            {
                bangGia = bg;
                LoadBangGiaInfor();
            }
        }

        private void gvSanPham_DoubleClick(object sender, EventArgs e)
        {
            LoadChinhSachGia();
        }

        private void btnChinhSachGia_Click(object sender, EventArgs e)
        {
            LoadChinhSachGia();
        }
        private void LoadChinhSachGia()
        {
            try
            {
                BangGiaChiTietInfor bgct = (BangGiaChiTietInfor)gvSanPham.GetRow(gvSanPham.FocusedRowHandle);

                List<BangGiaChinhSachInfor> liChinhSach =
                    ChinhSachDataProvider.Instance.GetAllChinhSachDaApDung(bangGia.IdTrungTam, bgct.MaSanPham,
                                                                           mstNgayLap.Value);
                //if (Updating)

                //    liChinhSach = ChinhSachDataProvider.Instance.GetAllChinhSachApDung(bangGia.IdTrungTam, -1, 0, bgct.MaSanPham);
                //else
                //    liChinhSach = ChinhSachDataProvider.Instance.GetAllChinhSachDaApDung(bangGia.IdTrungTam, bgct.MaSanPham, bangGia.NgayCapNhat);
                if (liChinhSach != null && liChinhSach.Count > 0)
                {
                    frmCS_BangGia_ViewKhuyenMai frm = new frmCS_BangGia_ViewKhuyenMai(liChinhSach, bgct);
                    frm.ShowDialog();
                }            
            }
            catch {}
        }

        private void btnAddGhiChu_Click(object sender, EventArgs e)
        {
            if (bangGia!=null)
            {
                frmCS_LapBangGia_AddComment frm = new frmCS_LapBangGia_AddComment(bangGia);    
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    txtGhiChu.Text += frm.Comment;
                }
            }
        }

        private void gtidButton1_Click(object sender, EventArgs e)
        {
            Common.DevExport2Excel(gvSanPham);
            //gSanPham.ShowPrintPreview();
        }

        private void gvSanPham_ShowingEditor(object sender, CancelEventArgs e)
        {
            try
            {
                BangGiaChiTietInfor bgct = (BangGiaChiTietInfor)gvSanPham.GetRow(gvSanPham.FocusedRowHandle);

                if (bgct != null && bgct.HangKhuyenMai == 1 && (gvSanPham.FocusedColumn.FieldName == "DonGiaCoVAT" || 
                    gvSanPham.FocusedColumn.FieldName == "GiaBanBuon" || gvSanPham.FocusedColumn.FieldName == "GiaBanDemo"))
                {

                    e.Cancel = true;
                }
            }
            catch
            {
            }
        }

        private void tsbImport_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string sql = String.Empty;
                openFileDialog1.FileName = String.Empty;

                //openFileDialog1.Filter = "*.xls|*.xlsx";
                if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

                using (OleDbConnection oConn = new OleDbConnection())
                {
                    dsChungTu = new DataSet();
                    oConn.ConnectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=Yes\"", openFileDialog1.FileName);
                    oConn.Open();
                    //load chungtu
                    sql = "Select [MaSanPham],[DonGiaCoVAT],[GiaBanBuon],[GiaBanDemo],[GiaNiemYet],[GiaWebSite] from [BangGia$] where [MaSanPham] is not null";
                    using (OleDbDataAdapter ad = new OleDbDataAdapter(sql, oConn))
                    {
                        ad.Fill(dsChungTu, "SanPham");
                    }
                }
                Cursor.Current = Cursors.Default;

                bangGia.ListBangGiaChiTiet = new List<BangGiaChiTietInfor>();
                gSanPham.DataSource = new BindingList<BangGiaChiTietInfor>(bangGia.ListBangGiaChiTiet);

                if (dsChungTu.Tables["SanPham"].Rows.Count == 0) return;

                frmProgress.Instance.Description = "Đang nạp dữ liệu ....";
                frmProgress.Instance.MaxValue = dsChungTu.Tables["SanPham"].Rows.Count;
                frmProgress.Instance.Value = 0;
                frmProgress.Instance.DoWork(ImportCTFromExcel);

                gSanPham.DataSource = new BindingList<BangGiaChiTietInfor>(bangGia.ListBangGiaChiTiet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi import dữ liệu:\n" + ex.ToString());
            }
        }

        private void ImportCTFromExcel()
        {
            try
            {
                int idNND = Common.Int2Bool(nguoiDung.SupperUser) ? -1 : nguoiDung.IdNhomNguoiDung;
                foreach (DataRow ct in dsChungTu.Tables["SanPham"].Rows)
                {
                    frmProgress.Instance.Value += 1;
                    if (String.IsNullOrEmpty(ct["MaSanPham"].ToString())) continue;
                    DMSanPhamBriefInfo spham = DmSanPhamProvider.GetSanPhamBriefByNSDMa(ct["MaSanPham"].ToString(), idNND);
                    if (spham != null && !ExistMaSanPham(spham.MaSanPham) && spham.HangKhuyenMai != 1)
                    {
                        BangGiaChiTietInfor bgct = null;
                        BangGiaNhapChiTietInfor gn = BangGiaDataProvider.Instance.GetGiaNhapChiTietInfor(spham.MaSanPham, bangGia.IdTrungTam, nguoiDung.IdNhomNguoiDung);
                        if (gn == null)
                        {
                            bgct = new BangGiaChiTietInfor()
                            {
                                NganhHang = spham.NganhHang,
                                IdSanPham = spham.IdSanPham,
                                MaSanPham = spham.MaSanPham,
                                TenSanPham = spham.TenSanPham,
                                DonViTinh = spham.TenDonViTinh,
                                TyLeVAT = spham.TyLeVAT,
                                HangKhuyenMai = spham.HangKhuyenMai
                            };
                        }
                        else
                        {
                            bgct = new BangGiaChiTietInfor(gn);
                        }
                        bgct.DonGiaCoVAT = Common.DoubleValue(ct["DonGiaCoVAT"]);
                        bgct.GiaBanBuon = Common.DoubleValue(ct["GiaBanBuon"]);
                        bgct.GiaBanDemo = Common.DoubleValue(ct["GiaBanDemo"]);
                                
                        UpdateDataValue(bgct);

                        if (Common.DoubleValue(ct["GiaNiemYet"]) != 0)
                            bgct.GiaNiemYet = Common.DoubleValue(ct["GiaNiemYet"]);
                        if (Common.DoubleValue(ct["GiaWebSite"]) != 0)
                            bgct.GiaWebSite = Common.DoubleValue(ct["GiaWebSite"]);

                        bangGia.ListBangGiaChiTiet.Add(bgct);
                    }
                }
                frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
                frmProgress.Instance.IsCompleted = true;
                frmProgress.Instance.Description = "Đã import xong!";
            }
            catch (Exception ex)
            {
                frmProgress.Instance.IsCompleted = true;
                throw ex;
            }
        }

        private void btnDayKM_Click(object sender, EventArgs e)
        {
            liNoKMai = TimKiemItemDataProvider.Instance.GetListSanPhamNoCKhau(Declare.IdTrungTam);

            try
            {
                if (liNoKMai.Count > 0)
                {
                    frmProgress.Instance.Description = "Đang đẩy dữ liệu mã hàng khuyến mại ....";
                    frmProgress.Instance.MaxValue = liNoKMai.Count;
                    frmProgress.Instance.Value = 0;
                    frmProgress.Instance.DoWork(SyncKhuyenMai);
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.ToString());
            }
        }

        private void SyncKhuyenMai()
        {
            try
            {
                foreach (BangGiaBanChiTietBCInfor sp in liNoKMai)
                {
                    string kmai = "";
                    int iddkmua = 0;
                    double tienKhuyenMai = CommonFuns.Instance.GetTienKhuyenMai(Declare.IdTrungTam, sp.IdSanPham,
                                                                              sp.MaSanPham, DateTime.Now,sp.DonGiaCoVAT,
                                                                              sp.DonGiaCoVAT, sp.TyLeVAT, ref kmai, ref iddkmua);

                    try
                    {
                        string sql =
                            String.Format(
                                "UPDATE tbl_tmp_giaban@qlbh_ta t SET t.khuyenmai = {0}, t.idcsachctiet = {1} where masanpham = '{2}'",
                                tienKhuyenMai, iddkmua, sp.MaSanPham);

                        SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(), CommandType.Text, sql);
                    }
                    catch 
                    {
                    }
                    frmProgress.Instance.Value += 1;
                }
                frmProgress.Instance.IsCompleted = true;
                frmProgress.Instance.Description = String.Format("Đã đẩy xong {0} mã hàng khuyến mại.", frmProgress.Instance.Value);
                frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            }
            catch (Exception ex)
            {
                frmProgress.Instance.Description = "Đẩy dữ liệu thất bại ....";
                frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
                frmProgress.Instance.IsCompleted = true;
                Debug.Print(ex.ToString());
            }
        }

        private void gvSanPham_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            try
            {
                BangGiaChiTietInfor bgct = (BangGiaChiTietInfor)gvSanPham.GetRow(gvSanPham.FocusedRowHandle);

                if (bgct.DonGiaCoVAT < 0)
                {
                    MessageBox.Show("Số lượng bán phải là số dương. Vui lòng kiểm tra lại!");
                    e.Valid = false;
                }
            }
            catch
            {
            }
        }
    }
}