using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QLBanHang.Modules.BanHang.Reports;
using CrystalDecisions.Shared;
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
using QLBH.Core.Providers;
using QLBH.Core.Form;
using QLBanHang.Modules.DanhMuc;
using QLBH.Core.Exceptions;

//

namespace QLBanHang.Modules.BanHang
{
    public partial class frmCS_LapChinhSachKM : DevExpress.XtraEditors.XtraForm
    {
        #region declare
        //List<BangGiaChinhSachInfor> liChinhSach = new List<BangGiaChinhSachInfor>();
        //private int IdBangGia = 0;//id bang gia
        private int IndexBG = 0;//thu tu bang gia
        private int Draft = -1;//-1:chua ton tai; 1-save, 0-confirm
        private bool IsAdded = false;
        private bool Updating = false;//false: chua sua, tao moi; 1:dang sua, tao moi
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private BangGiaChinhSachInfor chinhSach = null;
        private objGridMarkSelection selector = new objGridMarkSelection();
        private objGridMarkSelection selectorNo = new objGridMarkSelection();
        private frmCS_TimKiem_ChinhSachGia frmCS = null;
        //private objGridMarkSelection selectorCS = new objGridMarkSelection();
        #endregion
        DataSet dsChungTu;
        private List<MatHangInfor> lstMatHang = new List<MatHangInfor>();
        Utils ut = new Utils();

        public frmCS_LapChinhSachKM()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.chinhSach = new BangGiaChinhSachInfor();
        }

        public frmCS_LapChinhSachKM(BangGiaChinhSachInfor chinhSach)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.chinhSach = chinhSach;
        }

        public void HideMenu()
        {
            //toolStrip1.Visible = false;
            toolStrip1.Enabled = false;
        }
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
            catch(ManagedException ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show(ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif                
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

        private bool UpdateBangGia()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (ValidBangGiaInfor())
                {
                    ConnectionUtil.Instance.BeginTransaction();
                    //update infor
                    UpdateChinhSachTHInfor();
                    //update header
                    UpdateBangGiaHeader();
                    //update shop
                    UpdateBangGiaADShop();
                    //update customer
                    UpdateBangGiaADKhach();
                    //update thoi gian
                    UpdateBangGiaADThoiGian();
                    //update thanh toan
                    UpdateBangGiaADThanhToan();
                    //Update san pham
                    UpdateBangGiaADDKMua();
                    ConnectionUtil.Instance.CommitTransaction();

                    BangGiaChinhSachInfor cs = ChinhSachDataProvider.Instance.GetBangGiaChinhSachInforById(chinhSach.IdChinhSach);
                    chinhSach.DaDuyetTT = cs.DaDuyetTT;
                    txtTrangThai.Text = chinhSach.DaDuyetTT;

                    if (IsAdded)
                    {
                        MessageBox.Show("Thêm mới chính sách giá thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật chính sách giá thành công!");
                    }
                        
                    //LoadAllBangGia();

                    return true;                    
                }
            }
            catch (Exception)
            {
                ConnectionUtil.Instance.RollbackTransaction();
                if (IsAdded && chinhSach != null)
                    chinhSach.IdChinhSach = 0;              
                throw;
            }
            Cursor.Current = Cursors.Default;
            return false;
        }

        private void UpdateChinhSachTHInfor()
        {
            chinhSach.ChinhSachAD = chinhSach != null ? chinhSach.GhiChu : txtGhiChu.Text;
            //update sieu thị AD
            chinhSach.SieuThiAD = "";
            if (chinhSach.ListBangGiaADShop != null)
            {
                foreach (BangGiaADShopInfor bgShop in chinhSach.ListBangGiaADShop)
                {
                    chinhSach.SieuThiAD += bgShop.TenTrungTam + (!String.IsNullOrEmpty(bgShop.MaKho) ? String.Format("({0});", bgShop.MaKho) : ";") + "\r\n";
                }
            }

            //update doi tuong AD
            chinhSach.DoiTuongAD = "";
            if (chinhSach.ListBangGiaADKhach != null)
            {
                foreach (BangGiaADKhachInfor bgKhach in chinhSach.ListBangGiaADKhach)
                {
                    chinhSach.DoiTuongAD += bgKhach.TenLoaiDT + (!String.IsNullOrEmpty(bgKhach.MaDoiTuong) ? String.Format("({0});", bgKhach.MaDoiTuong) : ";") + "\r\n";
                }
            }

            //update thoi gian AD
            chinhSach.ThoiGianAD = String.Format("HieuLuc: {0}-{1}", mstNgayHieuLuc.Value.ToString(),
                                                  mstHanHieuLuc.Value.ToString());
            if (chinhSach.ListBangGiaADThoiGian != null)
            {
                foreach (BangGiaADTimeInfor bgTime in chinhSach.ListBangGiaADThoiGian)
                {
                    chinhSach.ThoiGianAD += !String.IsNullOrEmpty(bgTime.DayOfMonth) ? String.Format("DayOfMonth: {0} |", bgTime.DayOfMonth) : "";
                    chinhSach.ThoiGianAD += !String.IsNullOrEmpty(bgTime.DayOfWeek) ? String.Format("DayOfWeek: {0} |", bgTime.DayOfWeek) : "";
                    chinhSach.ThoiGianAD += bgTime.Thu != 0 ? String.Format("Thu: {0} |", bgTime.Thu) : "";
                    chinhSach.ThoiGianAD += bgTime.Ngay != 0 ? String.Format("Ngay: {0} |", bgTime.Ngay) : "";
                    chinhSach.ThoiGianAD += !String.IsNullOrEmpty(bgTime.GioTu) ? String.Format("TuGio: {0} |", bgTime.GioTu) : "";
                    chinhSach.ThoiGianAD += !String.IsNullOrEmpty(bgTime.GioDen) ? String.Format("DenGio: {0} |", bgTime.GioDen) : "" + "\r\n";
                }
            }

            //update thanh toan;
            chinhSach.ThanhToanAD = "";
            if (chinhSach.ListBangGiaADThanhToan != null)
            {
                foreach (BangGiaADBankInfor bgBank in chinhSach.ListBangGiaADThanhToan)
                {
                    chinhSach.ThanhToanAD += bgBank.HinhThucThanhToan + (!String.IsNullOrEmpty(bgBank.TenNganHang) ? String.Format("(NHangTToan:{0});", bgBank.TenNganHang) : "");
                    chinhSach.ThanhToanAD += !String.IsNullOrEmpty(bgBank.TenNganHangPH) ? String.Format("(NHangPHanh:{0});", bgBank.TenNganHangPH) : "";
                    chinhSach.ThanhToanAD += (!String.IsNullOrEmpty(bgBank.ThoiHanThanhToan) ? String.Format("(THanTToan:{0});", bgBank.ThoiHanThanhToan) : "");
                    chinhSach.ThanhToanAD += (bgBank.TyLeThanhToan == 0 ? String.Format("(TLeTToan:{0}%);", bgBank.TyLeThanhToan) : "") + "\r\n";
                }
            }

            //update mota khac
            chinhSach.MotaKhac = "";
            chinhSach.MotaKhac += (cboMacDinh.SelectedIndex == (int)LoaiChinhSachGia.MAC_DINH
                                       ? "Chính sách mặc định;"
                                       : (cboMacDinh.SelectedIndex == (int)LoaiChinhSachGia.CHIET_KHAU ? "Chính sách chiết khấu;" : "chính sách thường;"));
            chinhSach.MotaKhac += (chinhSach.ApDungKemMacDinh == 1 ? "Kèm CSG mặc định;" : "");
            chinhSach.MotaKhac += (chkDuyNhatCMND.Checked ? "Duy nhất CMND;" : "");
            chinhSach.MotaKhac += (chkDuyNhatSDT.Checked ? "Duy nhất Số ĐT;" : "");
            chinhSach.MotaKhac += (Common.DoubleValue(txtGiaTriHDToiThieu.Text.Trim()) != 0 ? String.Format("Giá trị HĐ tối thiểu: {0};", txtGiaTriHDToiThieu.Text.Trim()) : "");
            chinhSach.MotaKhac += (Common.DoubleValue(txtThanhToanToiThieu.Text.Trim()) != 0 ? String.Format("Tỷ lệ T.Toán tối thiểu: {0};", txtThanhToanToiThieu.Text.Trim()) : "");
            chinhSach.MotaKhac += (Common.DoubleValue(txtSoTienTToanTThieu.Text.Trim()) != 0 ? String.Format("Số tiền T.Toán tối thiểu: {0};", txtSoTienTToanTThieu.Text.Trim()) : "");
            chinhSach.MotaKhac += (Common.DoubleValue(txtGiaTriDHDaMua.Text.Trim()) != 0 ? String.Format("Giá trị HĐ đã mua: {0};", txtGiaTriDHDaMua.Text.Trim()) : "");
            chinhSach.MotaKhac += (Common.DoubleValue(txtThoiHanMua.Text.Trim()) != 0 ? String.Format("Thời hạn đã mua: {0} ngày;", txtThoiHanMua.Text.Trim()) : "");
        }

        private void UpdateBangGiaADShop()
        {
            //xoa het cai cu
            ChinhSachDataProvider.Instance.DeleteBangGiaADShop(chinhSach.IdChinhSach);

            //them tung cai moi;
            if (chinhSach.ListBangGiaADShop != null)
            {
                foreach (BangGiaADShopInfor bgShop in chinhSach.ListBangGiaADShop)
                {
                    bgShop.IdChinhSach = chinhSach.IdChinhSach;
                    ChinhSachDataProvider.Instance.InsertBangGiaADShop(bgShop);
                }                
            }
        }

        private void UpdateBangGiaADKhach()
        {
            //xoa het cai cu
            ChinhSachDataProvider.Instance.DeleteBangGiaADKhach(chinhSach.IdChinhSach);

            //them tung cai moi;
            if (chinhSach.ListBangGiaADKhach != null)
            {
                foreach (BangGiaADKhachInfor bgKhach in chinhSach.ListBangGiaADKhach)
                {
                    bgKhach.IdChinhSach = chinhSach.IdChinhSach;
                    ChinhSachDataProvider.Instance.InsertBangGiaADKhach(bgKhach);
                }
            }
        }

        private void UpdateBangGiaADThoiGian()
        {
            //xoa het cai cu
            ChinhSachDataProvider.Instance.DeleteBangGiaADThoiGian(chinhSach.IdChinhSach);

            //them tung cai moi;
            if (chinhSach.ListBangGiaADThoiGian != null)
            {
                foreach (BangGiaADTimeInfor bgTime in chinhSach.ListBangGiaADThoiGian)
                {
                    bgTime.IdChinhSach = chinhSach.IdChinhSach;
                    ChinhSachDataProvider.Instance.InsertBangGiaADThoiGian(bgTime);
                }
            }
        }

        private void UpdateBangGiaADThanhToan()
        {
            //xoa het cai cu
            ChinhSachDataProvider.Instance.DeleteBangGiaADThanhToan(chinhSach.IdChinhSach);

            //them tung cai moi;
            if (chinhSach.ListBangGiaADThanhToan != null)
            {
                foreach (BangGiaADBankInfor bgBank in chinhSach.ListBangGiaADThanhToan)
                {
                    bgBank.IdChinhSach = chinhSach.IdChinhSach;
                    ChinhSachDataProvider.Instance.InsertBangGiaADThanhToan(bgBank);
                }
            }
        }

        private void UpdateBangGiaHeader()
        {
            chinhSach.Draft = Draft;
            chinhSach.SoChinhSach = txtSoChinhSachGia.Text;
            chinhSach.NgayLap = mstNgayLap.Value;
            chinhSach.NguoiLap = txtNguoiLap.Text;
            chinhSach.GhiChu = txtGhiChu.Text;
            chinhSach.DoUuTien = Common.IntValue(nudDoUuTien.Value);
            chinhSach.LoaiDoiTuong = Common.Bool2Int(chkOnline.Checked);
            chinhSach.MacDinh = cboMacDinh.SelectedIndex;//0: binh thuong, 1 mac dinh, 2 chiet khau
            chinhSach.ApDungKemMacDinh = Common.Bool2Int(chkApDungMacDinh.Checked);

            chinhSach.NgayHieuLuc = mstNgayHieuLuc.Value;
            chinhSach.HanHieuLuc = mstHanHieuLuc.Value;
            chinhSach.SoKhachDauNgay = Common.IntValue(txtSoKhachDauNgay.Text);

            chinhSach.ThanhToanToiThieu = Common.DoubleValue(txtThanhToanToiThieu.Text.Trim());
            chinhSach.SoTienTToanToiThieu = Common.DoubleValue(txtSoTienTToanTThieu.Text.Trim());

            chinhSach.DuyNhatCMND = Common.Bool2Int(chkDuyNhatCMND.Checked);
            chinhSach.DuyNhatSDT = Common.Bool2Int(chkDuyNhatSDT.Checked);
            chinhSach.GioiTinh = cboGioiTinh.SelectedIndex;
            chinhSach.DoTuoiTu = Common.IntValue(txtTuoiTu.Text.Trim());
            chinhSach.DoTuoiDen = Common.IntValue(txtTuoiDen.Text.Trim());
            chinhSach.GiaTriHDToiThieu = Common.DoubleValue(txtGiaTriHDToiThieu.Text.Trim());
            chinhSach.GiaTriDHDaMua = Common.DoubleValue(txtGiaTriDHDaMua.Text.Trim());
            chinhSach.ThoiHanMua = Common.IntValue(txtThoiHanMua.Text.Trim());
            chinhSach.IdNgheNghiep = Common.IntValue(cboNgheNghiep.SelectedValue);
            chinhSach.IdTinh = Common.IntValue(cboTinh.SelectedValue);
            chinhSach.IdHuyen = Common.IntValue(cboHuyen.SelectedValue);

            chinhSach.MatHangKhongApDung = "";
            foreach (MatHangInfor mh in ((BindingList<MatHangInfor>)gDanhSachKhongAD.DataSource))
            {
                chinhSach.MatHangKhongApDung = chinhSach.MatHangKhongApDung + mh.IdMatHang.ToString() + ",";
            }
            if (!String.IsNullOrEmpty(chinhSach.MatHangKhongApDung))
                chinhSach.MatHangKhongApDung = chinhSach.MatHangKhongApDung.TrimEnd(",".ToCharArray());

            if (chinhSach.IdChinhSach == 0)
            {
                chinhSach.NguoiTao = nguoiDung.TenDangNhap;
                chinhSach.IdChinhSach = ChinhSachDataProvider.Instance.InsertBangGiaChinhSach(chinhSach);
            }
            else
            {
                chinhSach.NguoiCapNhat = nguoiDung.TenDangNhap;
                ChinhSachDataProvider.Instance.UpdateBangGiaChinhSach(chinhSach);
            }
        }

        private void UpdateBangGiaADDKMua()
        {
            //them tung cai moi;
            if (chinhSach.ListBangGiaADDKMua != null)
            {
                int stt = 0;
                //xoa khuyen mai cu
                KhuyenMaiDataProvider.Instance.DeleteBGKhuyenMaiByChinhSach(chinhSach.IdChinhSach);
                
                List<BangGiaADDKMuaInfor> oldListDKM = KhuyenMaiDataProvider.Instance.GetAllBangGiaADDKMuaInfors(chinhSach.IdChinhSach);

                foreach (BangGiaADDKMuaInfor dkm in oldListDKM)
                {
                    if (!chinhSach.ListBangGiaADDKMua.Exists(delegate(BangGiaADDKMuaInfor dk)
                                                                 {
                                                                     return dk.IdDKMua == dkm.IdDKMua;
                                                                 }))
                        KhuyenMaiDataProvider.Instance.DeleteBangGiaADDKMua(dkm);
                }

                foreach (BangGiaADDKMuaInfor bgDKMua in chinhSach.ListBangGiaADDKMua)
                {
                    if (!bgDKMua.IsOrigin || IsAdded)//voi nhung chi tiet them hoac sua
                    {
                        //cap nhat bang gia chi tiet
                        bgDKMua.IdChinhSach = chinhSach.IdChinhSach;
                        if (bgDKMua.IdDKMua == 0 || IsAdded)
                            bgDKMua.IdDKMua = KhuyenMaiDataProvider.Instance.InsertBangGiaADDKMua(bgDKMua);
                        else
                            KhuyenMaiDataProvider.Instance.UpdateBangGiaADDKMua(bgDKMua);

                        //cap nhat khuyen mai
                        //KhuyenMaiDataProvider.Instance.DeleteBGKhuyenMaiByDKMua(bgDKMua.IdDKMua);
                        //them khuyen mai moi);
                        if (bgDKMua.ListKhuyenMai != null)
                        {
                            foreach (BangGiaADKhuyenMaiInfor bgkm in bgDKMua.ListKhuyenMai)
                            {
                                //insert km header
                                bgkm.IdDKMua = bgDKMua.IdDKMua;
                                bgkm.SoKhuyenMai = Common.GetSoPhieuKM(chinhSach.SoChinhSach, ++stt);
                                bgkm.IdKhuyenMai = KhuyenMaiDataProvider.Instance.InsertBGKhuyenMai(bgkm);
                                //insert km detail
                                foreach (BangGiaADKhuyenMaiChiTietInfor kmct in bgkm.ListKhuyenMaiChiTiet)
                                {
                                    kmct.IdKhuyenMai = bgkm.IdKhuyenMai;
                                    kmct.IdChiTiet = KhuyenMaiDataProvider.Instance.InsertKhuyenMaiChiTiet(kmct);
                                }
                                //if (!bgkm.IsOrigin || IsAdded)
                                //{
                                //    //cap nhat khuyen mai header
                                //    bgkm.IdDKMua = bgDKMua.IdDKMua;
                                //    if (bgkm.IdKhuyenMai == 0 || IsAdded)
                                //        bgkm.IdKhuyenMai = KhuyenMaiDataProvider.Instance.InsertBGKhuyenMai(bgkm);
                                //    else
                                //        KhuyenMaiDataProvider.Instance.UpdateBGKhuyenMai(bgkm);

                                //    //cap nhat khuyen mai detail  
                                //    if (bgkm.ListKhuyenMaiChiTiet != null)
                                //    {
                                //        foreach (BangGiaADKhuyenMaiChiTietInfor kmct in bgkm.ListKhuyenMaiChiTiet)
                                //        {
                                //            if (!kmct.IsOrigin || IsAdded)
                                //            {
                                //                kmct.IdKhuyenMai = bgkm.IdKhuyenMai;
                                //                if (kmct.IdChiTiet == 0 || IsAdded)
                                //                    kmct.IdChiTiet = KhuyenMaiDataProvider.Instance.InsertKhuyenMaiChiTiet(kmct);
                                //                else
                                //                    KhuyenMaiDataProvider.Instance.UpdateKhuyenMaiChiTiet(kmct);
                                //            }
                                //        }
                                //    }
                                //}
                            }
                        }

                        //cap nhat san pham kem
                        //xoa du lieu cu
                        KhuyenMaiDataProvider.Instance.DeleteBGiaChiTietSanPhamKem(bgDKMua.IdDKMua);
                        if (bgDKMua.ListSanPhamKem != null)
                        {
                            //them du lieu moi
                            foreach (BangGiaADSPKemInfor spk in bgDKMua.ListSanPhamKem)
                            {
                                spk.IdDKMua = bgDKMua.IdDKMua;
                                KhuyenMaiDataProvider.Instance.InsertBGiaADSanPhamKem(spk);
                            }
                        }
                        //cap nhat san pham da mua
                        //xoa du lieu cu
                        KhuyenMaiDataProvider.Instance.DeleteBGiaChiTietSanPhamDaMua(bgDKMua.IdDKMua);
                        if (bgDKMua.ListSanPhamDaMua != null)
                        {
                            //them du lieu moi
                            foreach (BangGiaADSPDaMuaInfor spdm in bgDKMua.ListSanPhamDaMua)
                            {
                                spdm.IdDKMua = bgDKMua.IdDKMua;
                                KhuyenMaiDataProvider.Instance.InsertBGiaADSanPhamDaMua(spdm);
                            }
                        }
                        //cap nhat san pham khong ap dung
                        //xoa du lieu cu ko ap dung + co ap dung
                        KhuyenMaiDataProvider.Instance.DeleteBGiaChiTietSanPhamNoAD(bgDKMua.IdDKMua);
                        if (bgDKMua.ListSanPhamNoAD != null)
                        {
                            //them du lieu moi
                            foreach (BangGiaADSPNoADInfor noad in bgDKMua.ListSanPhamNoAD)
                            {
                                noad.IdDKMua = bgDKMua.IdDKMua;
                                KhuyenMaiDataProvider.Instance.InsertBGiaADSanPhamNoAD(noad,0);
                            }
                        }
                        //cap nhat san pham co ap dung
                        if (bgDKMua.ListSanPhamYesAD != null)
                        {
                            //them du lieu moi
                            foreach (BangGiaADSPNoADInfor noad in bgDKMua.ListSanPhamYesAD)
                            {
                                noad.IdDKMua = bgDKMua.IdDKMua;
                                KhuyenMaiDataProvider.Instance.InsertBGiaADSanPhamNoAD(noad, 1);
                            }
                        }
                    }
                }
            }            
        }

        private void LoadAllDanhMuc()
        {
            LoadDMNgheNghiep();
            LoadDMCachGiaoHang();
            LoadDMTinh();
        }

        private void frm_BangGia_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAllDanhMuc();
                if (chinhSach.IdChinhSach > 0)
                {
                    LoadChinhSachInfor();
                    if (chinhSach.Draft == 1 && nguoiDung.TenDangNhap.Equals(chinhSach.NguoiTao) || nguoiDung.SupperUser == 1)
                        btnSua_Click(sender, e);
                    else
                    {
                        IsAdded = false;
                        Updating = false;
                        setEDItems();
                        setEDFunctions();
                        if (!nguoiDung.TenDangNhap.Equals(chinhSach.NguoiTao))
                        {
                            HideMenu();
                            txtGhiChu.Enabled = true;
                            txtGhiChu.ReadOnly = true;
                        }
                    }
                }
                else
                {
                    btnThem_Click(sender, e);
                    if (chinhSach.IdChinhSach == 0 && !Updating)
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

        /// <summary>
        /// Enable, disable các ô nhập liệu
        /// </summary>
        private void setEDItems()
        {
            bool chkDefault = cboMacDinh.SelectedIndex == (int)LoaiChinhSachGia.MAC_DINH ? true : false;
            bool chkChietKhau = cboMacDinh.SelectedIndex == (int)LoaiChinhSachGia.CHIET_KHAU ? true : false;

            //bool status = Updating ? true : false;
            txtSoChinhSachGia.ReadOnly = !Updating;
            nudDoUuTien.Enabled = Updating;
            //chkDaDuyet.Enabled = Updating && Common.Int2Bool(nguoiDung.SupperUser);
            chkOnline.Enabled = Updating;
            mstNgayLap.Enabled = Updating;
            txtNguoiLap.ReadOnly = !Updating;
            //txtNgayDuyet.Enabled = Updating;
            //txtNguoiDuyet.Enabled = Updating;
            txtGhiChu.Enabled = Updating;
            chkApDungMacDinh.Enabled = Updating;

            //gSieuThiAD.Enabled = Updating;
            btnAddST.Enabled = Updating;
            btnDeleteST.Enabled = Updating;

            //selectorKH.CheckMarkColumn.VisibleIndex = Updating ? 0 : -1;
            //gDoiTuong.Enabled = Updating;
            btnAddKH.Enabled = Updating;
            btnDelKH.Enabled = Updating;

            //gThoiGianAD.Enabled = Updating;
            mstNgayHieuLuc.Enabled = Updating;
            mstHanHieuLuc.Enabled = Updating;// && chkVoHan.Checked;
            //chkVoHan.Enabled = Updating;
            txtSoKhachDauNgay.Enabled = Updating;
            btnAddTG.Enabled = Updating;
            btnDelTG.Enabled = Updating;

            //gThanhToan.Enabled = Updating;
            btnAddTT.Enabled = Updating;
            btnDelTT.Enabled = Updating;
            txtThanhToanToiThieu.Enabled = Updating;

            chkDuyNhatCMND.Enabled = Updating;
            chkDuyNhatSDT.Enabled = Updating;
            txtTuoiTu.Enabled = Updating && !chkDefault;
            txtTuoiDen.Enabled = Updating && !chkDefault;
            txtGiaTriHDToiThieu.Enabled = Updating;
            txtGiaTriDHDaMua.Enabled = Updating;
            txtThoiHanMua.Enabled = Updating;
            cboNgheNghiep.Enabled = Updating && !chkDefault;
            cboGiaoHang.Enabled = Updating && !chkDefault;
            cboGioiTinh.Enabled = Updating && !chkDefault;
            cboTinh.Enabled = Updating && !chkDefault;
            cboHuyen.Enabled = Updating && !chkDefault;

            cboLoaiMatHang.Enabled = Updating && !chkChietKhau;
            txtMaMatHang.Enabled = Updating;
            txtHangSX.Enabled = Updating && !chkChietKhau;
            txtMaSanPhamNo.Enabled = Updating && !chkChietKhau;
            GiaMuaTu.OptionsColumn.ReadOnly = !Updating;
            GiaMuaDen.OptionsColumn.ReadOnly = !Updating;
            InHoaDon.OptionsColumn.ReadOnly = !Updating;
            GiaMuaTu.Visible = !chkChietKhau;
            GiaMuaDen.Visible = !chkChietKhau;
            InHoaDon.Visible = chkChietKhau;
            MaVachApDung.Visible = !chkChietKhau;
            TyLeDiemThuong.Visible = !chkChietKhau;
            SoLuongToiDaCK.Visible = false;

            MaVachApDung.OptionsColumn.ReadOnly = !Updating || chkDefault || chkChietKhau;
            TyLeDiemThuong.OptionsColumn.ReadOnly = !Updating || chkDefault || chkChietKhau;
            TyLeChietKhau.OptionsColumn.ReadOnly = !Updating;// || chkDefault.Checked;
            TienChietKhau.OptionsColumn.ReadOnly = !Updating;// || chkDefault.Checked;
            GiaTriMuaToiThieu.OptionsColumn.ReadOnly = !Updating || chkDefault || chkChietKhau;
            SoLuongDuocMua.OptionsColumn.ReadOnly = !Updating;// || chkChietKhau.Checked;
            SoLuongToiDaDH.OptionsColumn.ReadOnly = !Updating;// || chkChietKhau.Checked;
            SoLuongPhaiMua.OptionsColumn.ReadOnly = !Updating;// || chkChietKhau.Checked;
            KhuyenMaiWeb.OptionsColumn.ReadOnly = !Updating || chkChietKhau;
            SanPhamNoAD.Visible = chkChietKhau;

            MaVachApDung.AppearanceCell.BackColor = (chkDefault || chkChietKhau) ? Color.DarkGray : Color.White;
            TyLeDiemThuong.AppearanceCell.BackColor = MaVachApDung.AppearanceCell.BackColor;
            GiaTriMuaToiThieu.AppearanceCell.BackColor = MaVachApDung.AppearanceCell.BackColor;

            btnThemCT.Enabled = Updating;
            cmdXoaChiTiet.Enabled = Updating;
            btnImportCT.Enabled = Updating && !chkChietKhau;
            btnThemCTNo.Enabled = Updating && !chkChietKhau;
            btnXoaCTNo.Enabled = Updating && !chkChietKhau;
            btnImportCTNo.Enabled = Updating && !chkChietKhau;
            btnThietLapSPDaMua.Enabled = Updating && !chkChietKhau;
            btnThietLapSPKem.Enabled = Updating && !chkDefault;// && !chkChietKhau.Checked;
            btnThietLapSPKem.Text = chkChietKhau ? "Thiết lập mã áp dụng" : "Thiết lập hàng mua &kèm";
            cmdThietLapKM.Enabled = Updating;// && !chkChietKhau.Checked;
            cmdThietLapKM.Text = chkChietKhau ? "Thiết lập mã loại trừ" : "Thiết lập k&huyến mại";            
        }
        /// <summary>
        /// Enable, disable các menu chức năng: Add, Save, Updade,...
        /// </summary>
        private void setEDFunctions()
        {
            btnThem.Enabled = !Updating;
            btnSaoChep.Enabled = !Updating && chinhSach.IdChinhSach > 0;
            btnSua.Enabled = !Updating && chinhSach.IdChinhSach > 0 && (nguoiDung.TenDangNhap.Equals(chinhSach.NguoiTao) && Common.Int2Bool(Draft) || Common.Int2Bool(nguoiDung.SupperUser));
            btnCapNhat.Enabled = Updating;
            //btnXoa.Enabled = !Updating && (Common.Int2Bool(Draft) || Common.Int2Bool(nguoiDung.SupperUser)) && (liChinhSach.Count > 0);
            btnXoa.Enabled =  nguoiDung.TenDangNhap.Equals(chinhSach.NguoiTao) && Common.Int2Bool(Draft) || Common.Int2Bool(nguoiDung.SupperUser);
            btnConfirm.Enabled = Updating;
            //btnTimKiem.Enabled = !Updating;
            btnDefault.Enabled = (chinhSach != null) && (chinhSach.IdChinhSach > 0) && (chinhSach.MacDinh == 0) &&
                                 (nguoiDung.TenDangNhap.Equals(chinhSach.NguoiTao) || nguoiDung.SupperUser == 1) && ConnectionUtil.Instance.IsUAT != 1;
            btnStop.Enabled = !Updating && !Common.Int2Bool(Draft) && (chinhSach != null) && (chinhSach.IdChinhSach > 0) &&
                              (chinhSach.DaDuyet == 1 || chinhSach.DaDuyet == -1) && (nguoiDung.TenDangNhap.Equals(chinhSach.NguoiTao) || nguoiDung.SupperUser == 1);
            btnStop.Text = (chinhSach != null && chinhSach.DaDuyet == -1) ? "Kích hoạt(F11)" : "Tạm &dừng (F11)";
            //btnTimKiem.Enabled = !isView;
            //groupBox1.Text = String.Format("Thông tin chung: Chính sách thứ [{0}]/[{1}]", IndexBG+1, liChinhSach.Count);
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidEditBangGia())
                {
                    MessageBox.Show("Chính sách này đã được xác nhận, không thể xóa được!");
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
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa chính sách giá này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ChinhSachDataProvider.Instance.DeleteBangGiaChinhSach(chinhSach.IdChinhSach);
                    MessageBox.Show("Xóa bảng giá thành công!");
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


        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCS_LapChinhSachKM_ChonType frm = new frmCS_LapChinhSachKM_ChonType();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ThemMoiBangGia(frm.LoaiChinhSach);

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

        private void ThemMoiBangGia(int loaiChinhSach)
        {
            //khoi tao tham so bang gia
            //Draft = -1;
            IsAdded = true;
            cboLoaiMatHang.SelectedIndex = 6;
            //tao bang gia moi
            //IdBangGia = 0;
            
            chinhSach = new BangGiaChinhSachInfor();
            ResetBangGiaInfor();
            txtSoChinhSachGia.Text = CommonProvider.Instance.GetSoPhieu(Declare.Prefix.ChinhSachBanHang, "tbl_BangGia_ChinhSach", "SoChinhSach");
            cboMacDinh.SelectedIndex = loaiChinhSach;
            if (loaiChinhSach == (int)LoaiChinhSachGia.THONG_THUONG)
            {
                chkApDungMacDinh.Visible = true;
                chkApDungMacDinh.Checked = true;
            }
            else
            {
                chkApDungMacDinh.Visible = false;
                chkApDungMacDinh.Checked = false;
            }

            //
            chinhSach.ListBangGiaADShop = new List<BangGiaADShopInfor>();
            gSieuThiAD.DataSource = new BindingList<BangGiaADShopInfor>(chinhSach.ListBangGiaADShop);

            chinhSach.ListBangGiaADKhach = new List<BangGiaADKhachInfor>();
            gDoiTuong.DataSource = new BindingList<BangGiaADKhachInfor>(chinhSach.ListBangGiaADKhach);

            chinhSach.ListBangGiaADThoiGian = new List<BangGiaADTimeInfor>();
            gThoiGianAD.DataSource = new BindingList<BangGiaADTimeInfor>(chinhSach.ListBangGiaADThoiGian);

            chinhSach.ListBangGiaADThanhToan = new List<BangGiaADBankInfor>();
            gThanhToan.DataSource = new BindingList<BangGiaADBankInfor>(chinhSach.ListBangGiaADThanhToan);

            chinhSach.ListBangGiaADDKMua = new List<BangGiaADDKMuaInfor>();
            gSanPham.DataSource = null;
            gSanPham.DataSource = new BindingList<BangGiaADDKMuaInfor>(chinhSach.ListBangGiaADDKMua);

            selector.View = null;
            selector.View = gvSanPham;
            selector.CheckMarkColumn.Fixed = FixedStyle.Left;
            selector.CheckMarkColumn.VisibleIndex = 0;

            lstMatHang = new List<MatHangInfor>();
            gDanhSachKhongAD.DataSource = new BindingList<MatHangInfor>(lstMatHang);

            selectorNo.View = null;
            selectorNo.View = gvDanhSachKhongAD;
        }

        private void ResetBangGiaInfor()
        {
            txtSoChinhSachGia.ResetText();
            nudDoUuTien.Value = 0;
            txtTrangThai.ResetText();
            chkDaDuyet.Checked = false;
            chkOnline.Checked = false;
            mstNgayLap.Value = CommonProvider.Instance.GetSysDate();
            txtNguoiLap.Text = nguoiDung.TenNhanVien;
            txtNgayDuyet.ResetText();
            //txtNguoiDuyet.ResetText();
            txtGhiChu.ResetText();

            //chkAllDT.Checked = false;
            mstNgayHieuLuc.Value = CommonProvider.Instance.GetSysDate();
            mstHanHieuLuc.Value = CommonProvider.Instance.GetSysDate().AddDays(1) ;
            //chkVoHan.Checked = false;
            txtSoKhachDauNgay.ResetText();
            
            txtThanhToanToiThieu.ResetText();

            chkDuyNhatCMND.Checked = false;
            chkDuyNhatSDT.Checked = false;
            cboGioiTinh.SelectedIndex = 0;
            cboGiaoHang.SelectedIndex = -1;
            txtTuoiTu.ResetText();
            txtTuoiDen.ResetText();
            txtGiaTriHDToiThieu.ResetText();
            txtGiaTriDHDaMua.ResetText();
            txtThoiHanMua.ResetText();
            cboNgheNghiep.SelectedIndex = -1;
            cboTinh.SelectedIndex = -1;
            cboHuyen.SelectedIndex = -1;

            gSieuThiAD.DataSource = null;
            //selectorKH.ClearSelection();
            //gDoiTuong.DataSource = null;
            gThoiGianAD.DataSource = null;
            gThanhToan.DataSource = null;
            gSanPham.DataSource = null;
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidEditBangGia())
                {
                    MessageBox.Show("Chính sách này đã được xác nhận, không thể sửa được!");
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
            if (chinhSach.IdChinhSach > 0 && (!nguoiDung.TenDangNhap.Equals(chinhSach.NguoiTao) || !Common.Int2Bool(chinhSach.Draft)) && !Common.Int2Bool(nguoiDung.SupperUser))//bang gia da xac nhan
            {
                return false;
            }
            return true;
        }

        private bool ValidBangGiaInfor()
        {
            //Kiem tra thong tin day du
            if (!ut.isStringNotEmpty(txtSoChinhSachGia.Text))
            {
                MessageBox.Show("Số chính sách giá chưa có.Xin mời nhập!");
                txtSoChinhSachGia.Focus();
                return false;
            }

            if (ut.getDate(mstHanHieuLuc.Value) < ut.getDate(mstNgayHieuLuc.Value))
            {
                MessageBox.Show("Hạn hiêu lực không được trước ngày hiệu lực!");
                mstHanHieuLuc.Focus();
                return false;
            }
            //Kiem tra trung So bang gia
            if (ChinhSachDataProvider.Instance.ExistBangGiaChinhSach(txtSoChinhSachGia.Text.Trim(), chinhSach.IdChinhSach))
            {
                MessageBox.Show("Số chính sách giá đã tồn tại. Mời nhập lại!");
                txtSoChinhSachGia.Focus();
                return false;
            }
            if (gvSanPham.RowCount == 0)
            {
                MessageBox.Show("Bảng giá không có dữ liệu. Mời nhập lại!");
                return false;
            }
            if (gvSieuThiAD.RowCount == 0)
            {
                MessageBox.Show("Bảng giá chưa áp dụng cho siêu thị nào. Mời nhập lại!");
                tabChinhSach.SelectedTab = tabSieuThiAD;
                return false;
            }
            if (gvDoiTuong.RowCount == 0)
            {
                MessageBox.Show("Bảng giá chưa áp dụng cho đối tượng nào. Mời nhập lại!");
                tabChinhSach.SelectedTab = tabKhachHangAD;
                return false;
            }
            //kiem tra su hop le cua tung item
            for (int i=0; i<chinhSach.ListBangGiaADDKMua.Count; i++)
            {
                if (chinhSach.ListBangGiaADDKMua[i].GiaMuaTu == chinhSach.ListBangGiaADDKMua[i].GiaMuaDen && chinhSach.ListBangGiaADDKMua[i].GiaMuaTu != 0)
                {
                    MessageBox.Show(String.Format("Khoảng giá [{0}, {0}] trùng nhau. Xin mời nhập lại",
                                                  chinhSach.ListBangGiaADDKMua[i].GiaMuaTu));
                    return false;
                }
                for (int j=0; j<chinhSach.ListBangGiaADDKMua.Count; j++)
                {
                    if (i!=j && chinhSach.ListBangGiaADDKMua[i].MaHangMua.Equals(chinhSach.ListBangGiaADDKMua[j].MaHangMua) &&
                        chinhSach.ListBangGiaADDKMua[i].LoaiHangMua == chinhSach.ListBangGiaADDKMua[j].LoaiHangMua &&
                        (chinhSach.ListBangGiaADDKMua[i].MaHangSX == null && chinhSach.ListBangGiaADDKMua[j].MaHangSX == null || 
                            chinhSach.ListBangGiaADDKMua[i].MaHangSX != null && chinhSach.ListBangGiaADDKMua[i].MaHangSX.Equals(chinhSach.ListBangGiaADDKMua[j].MaHangSX)) &&
                        (chinhSach.ListBangGiaADDKMua[i].GiaMuaTu <= chinhSach.ListBangGiaADDKMua[j].GiaMuaTu && chinhSach.ListBangGiaADDKMua[j].GiaMuaTu <= chinhSach.ListBangGiaADDKMua[i].GiaMuaDen && chinhSach.ListBangGiaADDKMua[j].GiaMuaTu != 0 ||
                        chinhSach.ListBangGiaADDKMua[i].GiaMuaTu <= chinhSach.ListBangGiaADDKMua[j].GiaMuaDen && chinhSach.ListBangGiaADDKMua[j].GiaMuaDen <= chinhSach.ListBangGiaADDKMua[i].GiaMuaDen && chinhSach.ListBangGiaADDKMua[j].GiaMuaDen !=0))
                    {
                        string msg =
                            String.Format(
                                "Mặt hàng: {0}, hãng: {1} có 2 khoảng giá trùng nhau [{2}, {3}] và [{4}, {5}]. Xin mời thiết lập lại!",
                                chinhSach.ListBangGiaADDKMua[i].TenHangMua,
                                chinhSach.ListBangGiaADDKMua[i].TenHangSX, chinhSach.ListBangGiaADDKMua[i].GiaMuaTu,
                                chinhSach.ListBangGiaADDKMua[i].GiaMuaDen,
                                chinhSach.ListBangGiaADDKMua[j].GiaMuaTu, chinhSach.ListBangGiaADDKMua[j].GiaMuaDen);
                        MessageBox.Show(msg);
                        return false;
                    }
                }
                //check diem thuong
                if (!BangGiaDiemThuongDataProvider.Instance.ValidData(chinhSach.ListBangGiaADDKMua[i]))
                {
                    MessageBox.Show(String.Format("Loại hàng: {0} - Mã hàng {1} - Tên hàng {2} có tỷ điểm thưởng không hợp lệ. Xin mời kiểm tra lại",
                                                  chinhSach.ListBangGiaADDKMua[i].TenLoaiHangMua, chinhSach.ListBangGiaADDKMua[i].MaHangMua, chinhSach.ListBangGiaADDKMua[i].TenHangMua));
                    return false;                    
                }
            }
            //kiem tra so luong don hang
            int sum = 0;
            foreach (BangGiaADShopInfor shopInfor in (BindingList<BangGiaADShopInfor>)gSieuThiAD.DataSource)
            {
                if (shopInfor.IdTrungTam > 0 && shopInfor.IdKho == 0)
                    sum += shopInfor.SoLuongDonHang;
            }
            if (sum > Common.IntValue(txtSoKhachDauNgay.Text))
            {
                MessageBox.Show("Tổng số đơn hàng trên toàn siêu thị không được nhỏ hơn số lượng đơn hàng trên 1 siêu thị!");
                return false;
            }

            return true;
        }


        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            try
            {
                SaoChepBangGia();

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
        private void SaoChepBangGia()
        {
            //Draft = -1;
            IsAdded = true;
            //IdBangGia = 0;

            chinhSach.IdChinhSach = 0;//de sao chep
            chinhSach.NguoiTao = nguoiDung.TenDangNhap;
            txtSoChinhSachGia.Text = CommonProvider.Instance.GetSoPhieu(Declare.Prefix.ChinhSachBanHang, "tbl_BangGia_ChinhSach", "SoChinhSach");
            mstNgayHieuLuc.Value = CommonProvider.Instance.GetSysDate();
            mstHanHieuLuc.Value = CommonProvider.Instance.GetSysDate().AddDays(1);
            //chkVoHan.Checked = false;
            //chkBanBuon.Checked = false;
            chkDaDuyet.Checked = false;
            chkOnline.Checked = false;
            mstNgayLap.Value = CommonProvider.Instance.GetSysDate();
            txtNguoiLap.Text = nguoiDung.TenNhanVien;
            txtNgayDuyet.ResetText();
            //txtNguoiDuyet.ResetText();
            txtGhiChu.ResetText();

            //LoadChinhSachKhuyenMai();//load thong tin chi tiet chinh sach khuyen mai
        }
        private void LoadChiTietKhuyenMai()
        {
            foreach (BangGiaADDKMuaInfor bgDKMua in chinhSach.ListBangGiaADDKMua)
            {
                //load khuyen mai
                if (bgDKMua.ListKhuyenMai == null)
                {
                    //load all danh sach khuyen mai
                    bgDKMua.ListKhuyenMai = KhuyenMaiDataProvider.Instance.GetAllBangGiaKhuyenMaiInfors(bgDKMua.IdDKMua);
                    for (int i = 0; i < bgDKMua.ListKhuyenMai.Count; i++)
                    {
                        bgDKMua.ListKhuyenMai[i].ListKhuyenMaiChiTiet = KhuyenMaiDataProvider.Instance.GetAllKhuyenMaiChiTietInfors(bgDKMua.ListKhuyenMai[i].IdKhuyenMai);
                    }
                }
                //foreach (BangGiaADKhuyenMaiInfor km in bgDKMua.ListKhuyenMai)
                //{
                //    km.SoKhuyenMai = "";
                //}
                //load san pham kem
                if (bgDKMua.ListSanPhamKem == null)
                {
                    bgDKMua.ListSanPhamKem = KhuyenMaiDataProvider.Instance.GetAllSanPhamKemInfors(bgDKMua.IdDKMua);
                }
                //load all danh sach san pham da mua
                if (bgDKMua.ListSanPhamDaMua == null)
                {                    
                    bgDKMua.ListSanPhamDaMua = KhuyenMaiDataProvider.Instance.GetAllSanPhamDaMuaInfors(bgDKMua.IdDKMua);
                }
                //load all danh sach san pham khong ap dung
                if (bgDKMua.ListSanPhamNoAD == null)
                {
                    bgDKMua.ListSanPhamNoAD = KhuyenMaiDataProvider.Instance.GetAllSanPhamNoADInfors(bgDKMua.IdDKMua, 0);
                }
                if (bgDKMua.ListSanPhamYesAD == null)
                {
                    bgDKMua.ListSanPhamYesAD = KhuyenMaiDataProvider.Instance.GetAllSanPhamNoADInfors(bgDKMua.IdDKMua, 1);
                }             
            }            
        }

        private void frm_BangGia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5 && btnThem.Enabled) 
                this.btnThem_Click(sender, e);
            else if (e.KeyCode == Keys.F6 && btnSua.Enabled)
                this.btnSua_Click(sender, e);
            else if (e.KeyCode == Keys.F7 && btnCapNhat.Enabled)
                this.cmdCapNhat_Click(sender, e);
            else if (e.KeyCode == Keys.F8 && btnXoa.Enabled)
                this.cmdXoa_Click(sender, e);
            else if (e.KeyCode == Keys.F9 && btnXoa.Enabled)
                this.btnSaoChep_Click(sender, e);
            else if (e.KeyCode == Keys.F11 && btnXoa.Enabled)
                this.btnStop_Click(sender, e);
            else if (e.KeyCode == Keys.F12 && btnDong.Enabled)
                this.btnDong_Click(sender, e);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void chkVoHan_CheckedChanged(object sender, EventArgs e)
        {
            //mstHanHieuLuc.Enabled = chkVoHan.Checked;
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

        #region Show chinh sach infor
        private void LoadChinhSachInfor()
        {
            if (chinhSach != null)
            {
                frmProgress.Instance.Description = "Đang nạp dữ liệu ...";
                frmProgress.Instance.MaxValue = 10;
                frmProgress.Instance.Value = 0;
                frmProgress.Instance.DoWork(LoadDuLieu);

                //load thong tin chung
                LoadChinhSachHeader();
                //load sieu thi ap dung
                LoadSieuThiApDung();
                //load khach hang ap dung
                LoadKhachHangApDung();
                //load thoi gian ap dung
                LoadThoiGianApDung();
                //load thanh toan ap dung
                LoadThanhToanApDung();
                //load chi tiet san pham mua
                LoadSanPhamMuaApDung();
            }
            else
            {
                ResetBangGiaInfor();
            }
        }

        private void LoadDuLieu()
        {
            frmProgress.Instance.Description = "nạp danh sách mặt hàng không áp dụng ...";
            lstMatHang = new List<MatHangInfor>();
            if (!String.IsNullOrEmpty(chinhSach.MatHangKhongApDung))
            {
                //string sql = chinhSach.MatHangKhongApDung.Replace(",", "','");
                //sql = "'" + sql + "'";
                lstMatHang = ChinhSachDataProvider.Instance.GetAllMatHangKhongApDung(chinhSach.MatHangKhongApDung);
            }
            frmProgress.Instance.Value ++;
            frmProgress.Instance.Description = "nạp danh sách siêu thị áp dụng ...";
            chinhSach.ListBangGiaADShop = ChinhSachDataProvider.Instance.GetBangGiaADShopInfor(chinhSach.IdChinhSach);

            frmProgress.Instance.Value++;
            frmProgress.Instance.Description = "nạp danh sách khách hàng áp dụng ...";
            chinhSach.ListBangGiaADKhach = ChinhSachDataProvider.Instance.GetBangGiaADKhachInfor(chinhSach.IdChinhSach);

            frmProgress.Instance.Value++;
            frmProgress.Instance.Description = "nạp danh sách thời gian áp dụng ...";
            chinhSach.ListBangGiaADThoiGian = ChinhSachDataProvider.Instance.GetBangGiaADThoiGianInfor(chinhSach.IdChinhSach);

            frmProgress.Instance.Value++;
            frmProgress.Instance.Description = "nạp danh sách hình thức thanh toán áp dụng ...";
            chinhSach.ListBangGiaADThanhToan = ChinhSachDataProvider.Instance.GetBangGiaADThanhToanInfor(chinhSach.IdChinhSach);

            frmProgress.Instance.Value++;
            frmProgress.Instance.Description = "nạp danh sách khuyến mại áp dụng ...";
            chinhSach.ListBangGiaADDKMua = KhuyenMaiDataProvider.Instance.GetAllBangGiaADDKMuaInfors(chinhSach.IdChinhSach);
            LoadChiTietKhuyenMai();//load chi tiet san pham mua

            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            frmProgress.Instance.IsCompleted = true;
            frmProgress.Instance.Description = "Đã xong";
        }
        private void LoadChinhSachHeader()
        {
            //thong tin chung
            Draft = chinhSach.Draft;
            txtSoChinhSachGia.Text = chinhSach.SoChinhSach;
            mstNgayLap.Value = chinhSach.NgayLap;
            txtNguoiLap.Text = chinhSach.NguoiLap;
            txtGhiChu.Text = chinhSach.GhiChu;
            nudDoUuTien.Value = chinhSach.DoUuTien;
            txtTrangThai.Text = chinhSach.DaDuyetTT;
            chkDaDuyet.Checked = Common.Int2Bool(chinhSach.DaDuyet);
            chkOnline.Checked = Common.Int2Bool(chinhSach.LoaiDoiTuong);
            cboMacDinh.SelectedIndex = chinhSach.MacDinh;
            chkApDungMacDinh.Checked = Common.Int2Bool(chinhSach.ApDungKemMacDinh);
            chkApDungMacDinh.Visible = chinhSach.MacDinh == (int) LoaiChinhSachGia.THONG_THUONG ? true : false;

            txtSoKhachDauNgay.Text = chinhSach.SoKhachDauNgay.ToString();
            txtThanhToanToiThieu.Text = chinhSach.ThanhToanToiThieu.ToString();
            txtSoTienTToanTThieu.Text = Common.Double2Str(chinhSach.SoTienTToanToiThieu);

            //dieu kien khac
            chkDuyNhatCMND.Checked = Common.Int2Bool(chinhSach.DuyNhatCMND);
            chkDuyNhatSDT.Checked = Common.Int2Bool(chinhSach.DuyNhatSDT);
            txtTuoiTu.Text = chinhSach.DoTuoiTu.ToString();
            txtTuoiDen.Text = chinhSach.DoTuoiDen.ToString();
            cboGiaoHang.SelectedValue = chinhSach.CachGiaoHang;
            cboGioiTinh.SelectedIndex = chinhSach.GioiTinh;
            cboTinh.SelectedValue = chinhSach.IdTinh;
            cboHuyen.SelectedValue = chinhSach.IdHuyen;
            cboNgheNghiep.SelectedValue = chinhSach.IdNgheNghiep;
            txtGiaTriHDToiThieu.Text = Common.Double2Str(chinhSach.GiaTriHDToiThieu);
            txtGiaTriDHDaMua.Text = Common.Double2Str(chinhSach.GiaTriDHDaMua);
            txtThoiHanMua.Text = chinhSach.ThoiHanMua.ToString();
                
            gDanhSachKhongAD.DataSource = new BindingList<MatHangInfor>(lstMatHang);
            selectorNo.View = null;
            selectorNo.View = gvDanhSachKhongAD;
        }
        private void LoadSanPhamMuaApDung()
        {
            gSanPham.DataSource = new BindingList<BangGiaADDKMuaInfor>(chinhSach.ListBangGiaADDKMua);
            selector.View = gvSanPham;
            selector.CheckMarkColumn.Fixed = FixedStyle.Left;
            selector.CheckMarkColumn.VisibleIndex = 0;
            cboLoaiMatHang.SelectedIndex = 6;
        }
        private void LoadSieuThiApDung()
        {
            gSieuThiAD.DataSource = new BindingList<BangGiaADShopInfor>(chinhSach.ListBangGiaADShop);
        }
        private void LoadThoiGianApDung()
        {
            mstNgayHieuLuc.Value = chinhSach.NgayHieuLuc;
            mstHanHieuLuc.Value = chinhSach.HanHieuLuc;
            txtSoKhachDauNgay.Text = chinhSach.SoKhachDauNgay.ToString();

            gThoiGianAD.DataSource = new BindingList<BangGiaADTimeInfor>(chinhSach.ListBangGiaADThoiGian);
        }
        private void LoadThanhToanApDung()
        {
            txtThanhToanToiThieu.Text = chinhSach.ThanhToanToiThieu.ToString();
            gThanhToan.DataSource = new BindingList<BangGiaADBankInfor>(chinhSach.ListBangGiaADThanhToan);
        }
        private void LoadKhachHangApDung()
        {
            gDoiTuong.DataSource = new BindingList<BangGiaADKhachInfor>(chinhSach.ListBangGiaADKhach);
        }

        #endregion
        private void btnAddST_Click(object sender, EventArgs e)
        {
            frmCS_BangGia_ApDungST frm = new frmCS_BangGia_ApDungST();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (chinhSach.ListBangGiaADShop == null)
                {
                    chinhSach.ListBangGiaADShop = new List<BangGiaADShopInfor>();
                    gSieuThiAD.DataSource = new BindingList<BangGiaADShopInfor>(chinhSach.ListBangGiaADShop);
                }

                foreach (BangGiaADShopInfor bgShop in frm.LstBangGiaADShop)
                {
                    if (!chinhSach.ListBangGiaADShop.Exists(delegate (BangGiaADShopInfor match)
                                                               {
                                                                   return
                                                                       match.IdTrungTam ==
                                                                       bgShop.IdTrungTam && match.IdKho == bgShop.IdKho || match.IdTrungTam == 0;
                                                               }))
                    {
                        if (bgShop.IdTrungTam == 0)
                        {
                            chinhSach.ListBangGiaADShop = new List<BangGiaADShopInfor>();
                            gSieuThiAD.DataSource = new BindingList<BangGiaADShopInfor>(chinhSach.ListBangGiaADShop);                            
                        }
                        bgShop.IdChinhSach = chinhSach.IdChinhSach;
                        ((BindingList<BangGiaADShopInfor>)gSieuThiAD.DataSource).Add(bgShop);
                    } 
                }
                UpdateSoLuongDonHang();
            }
        }

        private void UpdateSoLuongDonHang()
        {
            int sum = 0;
            foreach (BangGiaADShopInfor shopInfor in (BindingList<BangGiaADShopInfor>)gSieuThiAD.DataSource)
            {
                if (shopInfor.IdTrungTam > 0 && shopInfor.IdKho == 0)
                    sum += shopInfor.SoLuongDonHang;
            }
            if (sum > Common.IntValue(txtSoKhachDauNgay.Text))
                txtSoKhachDauNgay.Text = sum.ToString();
        }

        private void btnDeleteST_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvSieuThiAD.FocusedRowHandle < 0) return;

                if (MessageBox.Show("Bạn có chắc chắn xóa dữ liệu này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gvSieuThiAD.DeleteSelectedRows();
                    UpdateSoLuongDonHang();
                }
            }
            catch { }
        }

        private void btnAddTT_Click(object sender, EventArgs e)
        {
            frmCS_BangGia_ApDungTT frm = new frmCS_BangGia_ApDungTT();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BangGiaADBankInfor thanhToan = frm.ThanhToan;
                thanhToan.IdChinhSach = chinhSach.IdChinhSach;
                ((BindingList<BangGiaADBankInfor>)gThanhToan.DataSource).Add(thanhToan);
            }
        }

        private void btnDelTT_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvThanhToan.FocusedRowHandle < 0) return;

                if (MessageBox.Show("Bạn có chắc chắn xóa dữ liệu này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gvThanhToan.DeleteSelectedRows();
                }
            }
            catch { }
        }

        private void btnAddTG_Click(object sender, EventArgs e)
        {
            frmCS_BangGia_ApDungTG frm = new frmCS_BangGia_ApDungTG();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BangGiaADTimeInfor time = frm.Time;
                time.IdChinhSach = chinhSach.IdChinhSach;
                ((BindingList<BangGiaADTimeInfor>)gThoiGianAD.DataSource).Add(time);
            }
        }

        private void btnDelTG_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvThoiGianAD.FocusedRowHandle < 0) return;

                if (MessageBox.Show("Bạn có chắc chắn xóa dữ liệu này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gvThoiGianAD.DeleteSelectedRows();
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

        private void LoadDMNgheNghiep()
        {
            try
            {
                List<DmNgheNghiepInfor> liNgheNghiep = DMNgheNghiepDataProvider.Instance.GetListNgheNghiepInfors();
                cboNgheNghiep.DataSource = liNgheNghiep;
                cboNgheNghiep.DisplayMember = "TenNgheNghiep";
                cboNgheNghiep.ValueMember = "IdNgheNghiep";
                cboNgheNghiep.SelectedIndex = -1;
            }
            catch
            {
            }
        }

        private void LoadDMCachGiaoHang()
        {
            try
            {
                List<DMCachGiaoHangInfo> liGiaoHang = DMCachGiaoHangDataProvider.Instance.GetListCachGiaoHangInfo();
                cboGiaoHang.DataSource = liGiaoHang;
                cboGiaoHang.DisplayMember = "Ten";
                cboGiaoHang.ValueMember = "IdCachGiaoHang";
                cboGiaoHang.SelectedIndex = -1;
            }
            catch
            {
            }
        }

        private void LoadDMTinh()
        {
            try
            {
                List<DMTinhInfor> liTinh = DMTinhDataProvider.Instance.GetListTinhInfors();
                cboTinh.DataSource = liTinh;
                cboTinh.DisplayMember = "TenTinh";
                cboTinh.ValueMember = "IdTinh";
                cboTinh.SelectedIndex = -1;
            }
            catch
            {
            }           
        }

        private void LoadDMHuyen()
        {
            try
            {

                List<DMHuyenInfor> liHuyen = DMHuyenDataProvider.Instance.GetListHuyenByTinhInfors(Common.IntValue(cboTinh.SelectedValue));
                cboHuyen.DataSource = liHuyen;
                cboHuyen.DisplayMember = "TenHuyen";
                cboHuyen.ValueMember = "IdHuyen";
                cboHuyen.SelectedIndex = -1;
            }
            catch
            {
            }
        }

        private void cboTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDMHuyen();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn dừng chính sách giá này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string msg = "";
                    if (chinhSach.DaDuyet == 1)
                    {
                        chinhSach.DaDuyet = -1;
                        msg = "Tạm dừng chính sách giá thành công!";
                    }                       
                    else if (chinhSach.DaDuyet == -1)
                    {
                        chinhSach.DaDuyet = 1;
                        msg = "Kích hoạt chính sách giá thành công!";
                    }

                    chinhSach.NguoiDuyet = nguoiDung.TenDangNhap;
                    ChinhSachDataProvider.Instance.DuyetBangGiaChinhSach(chinhSach);
                    BangGiaChinhSachInfor cs = ChinhSachDataProvider.Instance.GetBangGiaChinhSachInforById(chinhSach.IdChinhSach);
                    chinhSach.DaDuyetTT = cs.DaDuyetTT;
                    txtTrangThai.Text = chinhSach.DaDuyetTT;
                    Updating = false;
                    setEDItems();
                    setEDFunctions();
                    MessageBox.Show(msg);
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

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            List<MatHangInfor> liMatHang = new List<MatHangInfor>();
            int idNND = Common.Int2Bool(nguoiDung.SupperUser) ? -1 : nguoiDung.IdNhomNguoiDung;

            if (cboMacDinh.SelectedIndex == (int)LoaiChinhSachGia.CHIET_KHAU)// chkChietKhau.Checked)//chinh sach chiet khau
            {
                TimKiemItemInfor item = TimKiemItemDataProvider.Instance.GetItemChietKhauByCode(idNND, txtMaMatHang.Text.Trim(), 1);

                if (item != null)
                {
                    MatHangInfor mh = new MatHangInfor();
                    mh.MaMatHang = item.Ma;
                    mh.TenMatHang = item.Ten;
                    mh.IdMatHang = item.Id;
                    mh.ChietKhau = item.ChietKhau;
                    mh.LoaiMatHang = cboLoaiMatHang.SelectedIndex;
                    mh.TenLoaiMatHang = cboLoaiMatHang.SelectedItem.ToString();

                    liMatHang.Add(mh);
                }
                else
                {
                    frmLookUp_HangHoa frm = new frmLookUp_HangHoa(true, idNND, 1, 1);
                    if (frm.ShowDialog() == DialogResult.OK && frm.SelectedItems.Count > 0)
                    {
                        foreach (DMSanPhamBriefInfo sp in frm.SelectedItems)
                        {
                            MatHangInfor mh = new MatHangInfor();
                            mh.MaMatHang = sp.MaSanPham;
                            mh.TenMatHang = sp.TenSanPham;
                            mh.IdMatHang = sp.IdSanPham;
                            mh.ChietKhau = sp.ChietKhau;
                            mh.LoaiMatHang = cboLoaiMatHang.SelectedIndex;
                            mh.TenLoaiMatHang = cboLoaiMatHang.SelectedItem.ToString();

                            liMatHang.Add(mh);                            
                        }
                    }
                }
            }
            else
            {
                TimKiemItemInfor item = TimKiemItemDataProvider.Instance.GetItemByTypeandCode(idNND, cboLoaiMatHang.SelectedIndex, txtMaMatHang.Text.Trim());

                if (item != null)
                {
                    MatHangInfor mh = new MatHangInfor();
                    mh.MaMatHang = item.Ma;
                    mh.TenMatHang = item.Ten;
                    mh.LoaiMatHang = cboLoaiMatHang.SelectedIndex;
                    mh.TenLoaiMatHang = cboLoaiMatHang.SelectedItem.ToString();
                    mh.IdMatHang = item.Id;
                    mh.ChietKhau = item.ChietKhau;
                    mh.MaHangSX = "";
                    mh.TenHangSX = "";

                    TimKiemItemInfor hsx = TimKiemItemDataProvider.Instance.GetItemByTypeandCode(idNND, 7,
                                                                                                 txtHangSX.Text);
                    if (hsx != null)
                    {
                        mh.MaHangSX = hsx.Ma;
                        mh.TenHangSX = hsx.Ten;
                    }
                    liMatHang.Add(mh);
                }
                else
                {
                    frmLookUp_MatHang frm = new frmLookUp_MatHang();
                    if (frm.ShowDialog() == DialogResult.OK && frm.SelectedItems.Count > 0)
                    {
                        liMatHang.AddRange(frm.SelectedItems);
                    }
                }
            }

            if (liMatHang.Count > 0)
            {
                if (gvSanPham.DataSource == null)
                {
                    chinhSach.ListBangGiaADDKMua = new List<BangGiaADDKMuaInfor>();
                    gSanPham.DataSource = new BindingList<BangGiaADDKMuaInfor>(chinhSach.ListBangGiaADDKMua)
                                              {
                                                  AllowEdit = true,
                                                  AllowNew = true,
                                                  AllowRemove = true,
                                                  RaiseListChangedEvents = true
                                              };
                }

                foreach (MatHangInfor mh in liMatHang)
                {
                    if (!ExistMaSanPham(mh.LoaiMatHang, mh.MaMatHang, mh.MaHangSX))
                    {

                        ((BindingList<BangGiaADDKMuaInfor>) gSanPham.DataSource).Add(new BangGiaADDKMuaInfor()
                                                                                         {
                                                                                             IdChinhSach = chinhSach.IdChinhSach,
                                                                                             LoaiHangMua = mh.LoaiMatHang,
                                                                                             TenLoaiHangMua = mh.TenLoaiMatHang,
                                                                                             MaHangMua = mh.MaMatHang,
                                                                                             TenHangMua = mh.TenMatHang,
                                                                                             MaHangSX = mh.MaHangSX,
                                                                                             TenHangSX = mh.TenHangSX,
                                                                                             TyLePhanBo = 100
                                                                                         });
                    }
                }
                //((BindingList<BangGiaChiTietInfor>)gSanPham.DataSource).ResetBindings();
            }
        }

        private bool ExistMaSanPham(int loaiMH, string maMH, string maHSX)
        {
            //foreach (BangGiaADDKMuaInfor dk in (BindingList<BangGiaADDKMuaInfor>)gSanPham.DataSource)
            //{
            //    if (dk.LoaiHangMua == loaiMH && dk.MaHangMua.Equals(maMH) && dk.MaHangSX.Equals(maHSX))
            //        return true;
            //}
            return false;
        }

        private bool ExistMaSanPham(string maMH)
        {
            foreach (MatHangInfor mh in (BindingList<MatHangInfor>)gDanhSachKhongAD.DataSource)
            {
                if (mh.MaMatHang.Equals(maMH))
                    return true;
            }
            return false;
        }

        private bool ExistMaSanPham(string maMH, List<MatHangInfor> lstMaHang)
        {
            foreach (MatHangInfor mh in lstMaHang)
            {
                if (mh.MaMatHang.Equals(maMH))
                    return true;
            }
            return false;
        }

        private void cmdXoaChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                if (selector.SelectedCount > 0)
                {
                    if (MessageBox.Show("Bạn có chắc chắn xóa các items này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        foreach (BangGiaADDKMuaInfor dkm in selector.selection)
                        {
                            ((BindingList<BangGiaADDKMuaInfor>) gSanPham.DataSource).Remove(dkm);
                        }
                    }
                }
                else
                {
                    if (gvSanPham.FocusedRowHandle >= 0)
                    {
                        if (MessageBox.Show("Bạn có chắc chắn xóa các items này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            BangGiaADDKMuaInfor dkm = (BangGiaADDKMuaInfor)gvSanPham.GetRow(gvSanPham.FocusedRowHandle);
                            ((BindingList<BangGiaADDKMuaInfor>)gSanPham.DataSource).Remove(dkm);
                        }
                    }
                }
                //if (gvSanPham.FocusedRowHandle < 0) return;
                //if (MessageBox.Show("Bạn có chắc chắn xóa các items này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                //{
                //    gvSanPham.DeleteSelectedRows();
                //}
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

        private void btnThietLapSPKem_Click(object sender, EventArgs e)
        {
            if (cboMacDinh.SelectedIndex == (int)LoaiChinhSachGia.CHIET_KHAU)// chkChietKhau.Checked)
                ThietLapLoaiTru(true);
            else
                ThietLapSanPhamKem();
        }

        private void ThietLapSanPhamKem()
        {
            try
            {
                if (gvSanPham.FocusedRowHandle >= 0)
                {
                    BangGiaADDKMuaInfor dkm = (BangGiaADDKMuaInfor)gvSanPham.GetRow(gvSanPham.FocusedRowHandle);
                    frmCS_BangGia_SanPhamKem frm = new frmCS_BangGia_SanPhamKem(dkm, btnThietLapSPKem.Enabled);
                    frm.ShowDialog();
                    //                    if (frm.ShowDialog() == DialogResult.OK)
                    ((BindingList<BangGiaADDKMuaInfor>)gSanPham.DataSource).ResetBindings();
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
        private void cmdThietLapKM_Click(object sender, EventArgs e)
        {
            if (cboMacDinh.SelectedIndex == (int)LoaiChinhSachGia.CHIET_KHAU)// chkChietKhau.Checked)
                ThietLapLoaiTru(false);
            else
                ThietLapKhuyenMai();
        }

        private void ThietLapKhuyenMai()
        {
            try
            {
                List<BangGiaADDKMuaInfor> liDKMua = new List<BangGiaADDKMuaInfor>();
                if (selector.SelectedCount > 0)
                {
                    foreach (BangGiaADDKMuaInfor dkm in selector.selection)
                    {
                        liDKMua.Add(dkm);
                    }
                }
                else
                {
                    if (gvSanPham.FocusedRowHandle >= 0)
                    {
                        BangGiaADDKMuaInfor dkm = (BangGiaADDKMuaInfor)gvSanPham.GetRow(gvSanPham.FocusedRowHandle);
                        liDKMua.Add(dkm);
                    }
                }
                bool chkDefault = cboMacDinh.SelectedIndex == (int)LoaiChinhSachGia.MAC_DINH ? true : false;
                frmCS_BangGia_KhuyenMai frm = new frmCS_BangGia_KhuyenMai(liDKMua, cmdThietLapKM.Enabled, txtSoChinhSachGia.Text, chkDefault);
                frm.ShowDialog();
                //                    if (frm.ShowDialog() == DialogResult.OK)
                ((BindingList<BangGiaADDKMuaInfor>)gvSanPham.DataSource).ResetBindings();
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
        /// <summary>
        /// Thiết lập sản phẩm loại trừ hoặc áp dụng
        /// </summary>
        /// <param name="isApDung">true: áp dụng, false: loại trừ</param>
        private void ThietLapLoaiTru(bool isApDung)
        {
            try
            {
                if (gvSanPham.FocusedRowHandle >= 0)
                {
                    BangGiaADDKMuaInfor dkm = (BangGiaADDKMuaInfor)gvSanPham.GetRow(gvSanPham.FocusedRowHandle);
                    bool isEnable = isApDung ? btnThietLapSPKem.Enabled : cmdThietLapKM.Enabled;
                    frmCS_BangGia_SanPhamNoAD frm = new frmCS_BangGia_SanPhamNoAD(dkm, isEnable, isApDung);
                    frm.ShowDialog();
                    //                    if (frm.ShowDialog() == DialogResult.OK)
                    ((BindingList<BangGiaADDKMuaInfor>)gSanPham.DataSource).ResetBindings();
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


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (Updating)
            {
                if (MessageBox.Show("Dữ liệu đang cập nhật, bạn có muốn hủy bỏ không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            }
            search();
        }

        private void search()
        {
            frmCS_TimKiem_ChinhSachGia frm = new frmCS_TimKiem_ChinhSachGia(1);
            if (frm.ShowDialog() == DialogResult.OK && frm.ChinhSach != null)
            {
                chinhSach = frm.ChinhSach;
                //hien thi thong tin bang gia hien tai
                LoadChinhSachInfor();
                //Thiet lap trang thai item
                Updating = false;
                setEDItems();
                setEDFunctions();
            }
        }

        private void btnAddKH_Click(object sender, EventArgs e)
        {
            frmCS_BangGia_ApDungKH frm = new frmCS_BangGia_ApDungKH();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (chinhSach.ListBangGiaADKhach == null)
                {
                    chinhSach.ListBangGiaADKhach = new List<BangGiaADKhachInfor>();
                    gDoiTuong.DataSource = new BindingList<BangGiaADKhachInfor>(chinhSach.ListBangGiaADKhach);
                }

                foreach (BangGiaADKhachInfor bgKhach in frm.LstBangGiaADKhach)
                {
                    if (!chinhSach.ListBangGiaADKhach.Exists(delegate(BangGiaADKhachInfor match)
                                                                 {
                                                                     return
                                                                         match.IdLoaiDT ==
                                                                         bgKhach.IdLoaiDT &&
                                                                         match.IdDoiTuong == bgKhach.IdDoiTuong || match.IdLoaiDT == 0;
                                                                 }))
                    {
                        if (bgKhach.IdLoaiDT == 0)
                        {
                            chinhSach.ListBangGiaADKhach = new List<BangGiaADKhachInfor>();
                            gDoiTuong.DataSource = new BindingList<BangGiaADKhachInfor>(chinhSach.ListBangGiaADKhach);                            
                        }
                        bgKhach.IdChinhSach = chinhSach.IdChinhSach;
                        ((BindingList<BangGiaADKhachInfor>) gDoiTuong.DataSource).Add(bgKhach);
                    }
                }
            }
        }

        private void btnDelKH_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvDoiTuong.FocusedRowHandle < 0) return;

                if (MessageBox.Show("Bạn có chắc chắn xóa dữ liệu này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gvDoiTuong.DeleteSelectedRows();
                }
            }
            catch { }
        }

        private void gvSanPham_DoubleClick(object sender, EventArgs e)
        {
            Point pt = gSanPham.PointToClient(MousePosition);
            GridHitInfo hitInfo = gvSanPham.CalcHitInfo(pt);
            if (hitInfo.InRow)
            {
                if (hitInfo.Column.FieldName == "KhuyenMai" || hitInfo.Column.FieldName == "SanPhamNoAD")
                    cmdThietLapKM_Click(sender, e);
                else if (hitInfo.Column.FieldName == "SanPhamKem" || hitInfo.Column.FieldName == "SanPhamYesAD")// && !chkChietKhau.Checked)
                    btnThietLapSPKem_Click(sender, e);
                else if (hitInfo.Column.FieldName == "SanPhamDaMua" && cboMacDinh.SelectedIndex != (int)LoaiChinhSachGia.CHIET_KHAU)//!chkChietKhau.Checked)
                    btnThietLapSPDaMua_Click(sender, e);
            }
        }

        private void btnThietLapSPDaMua_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvSanPham.FocusedRowHandle >= 0)
                {
                    BangGiaADDKMuaInfor dkm = (BangGiaADDKMuaInfor)gvSanPham.GetRow(gvSanPham.FocusedRowHandle);
                    frmCS_BangGia_SanPhamDaMua frm = new frmCS_BangGia_SanPhamDaMua(dkm, btnThietLapSPDaMua.Enabled);
                    frm.ShowDialog();
                    //                    if (frm.ShowDialog() == DialogResult.OK)
                    ((BindingList<BangGiaADDKMuaInfor>)gSanPham.DataSource).ResetBindings();
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

        private void btnDefault_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn thiết lập mặc định cho chính sách này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cboMacDinh.SelectedIndex = (int)LoaiChinhSachGia.MAC_DINH;
                    chinhSach.MacDinh = cboMacDinh.SelectedIndex; 
                    ChinhSachDataProvider.Instance.ThietLapMacDinhChinhSach(chinhSach);
                    Updating = false;
                    setEDItems();
                    setEDFunctions();
                    MessageBox.Show("Đã thiết lập chính sách khuyến mại mặc định thành công!");
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

        private void btnThemCTNo_Click(object sender, EventArgs e)
        {
            List<MatHangInfor> liMatHang = new List<MatHangInfor>();
            int idNND = Common.Int2Bool(nguoiDung.SupperUser) ? -1 : nguoiDung.IdNhomNguoiDung;
            TimKiemItemInfor item = TimKiemItemDataProvider.Instance.GetItemByTypeandCode(idNND, 6, txtMaSanPhamNo.Text.Trim());

            if (item != null)
            {
                MatHangInfor mh = new MatHangInfor();
                mh.MaMatHang = item.Ma;
                mh.TenMatHang = item.Ten;
                mh.IdMatHang = item.Id;

                liMatHang.Add(mh);
            }
            else
            {
                frmLookUp_HangHoa frm = new frmLookUp_HangHoa(true,
                                                              (Common.Int2Bool(nguoiDung.SupperUser)
                                                                   ? -1
                                                                   : nguoiDung.IdNhomNguoiDung), 1, -1);

                if (frm.ShowDialog() == DialogResult.OK && frm.SelectedItems.Count > 0)
                {
                    foreach (DMSanPhamBriefInfo sp in frm.SelectedItems)
                    {
                        MatHangInfor mh = new MatHangInfor();
                        mh.MaMatHang = sp.MaSanPham;
                        mh.TenMatHang = sp.TenSanPham;
                        mh.IdMatHang = sp.IdSanPham;

                        liMatHang.Add(mh);                        
                    }
                }
            }

            if (liMatHang.Count > 0)
            {
                if (gDanhSachKhongAD.DataSource == null)
                {
                    gDanhSachKhongAD.DataSource = new BindingList<MatHangInfor>();
                }

                foreach (MatHangInfor mh in liMatHang)
                {
                    if (!ExistMaSanPham(mh.MaMatHang))
                    {
                        ((BindingList<MatHangInfor>)gDanhSachKhongAD.DataSource).Add(mh);
                    }
                }
            }
        }

        private void btnXoaCTNo_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectorNo.SelectedCount > 0)
                {
                    if (MessageBox.Show("Bạn có chắc chắn xóa các items này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        foreach (MatHangInfor dkm in selector.selection)
                        {
                            ((BindingList<MatHangInfor>)gDanhSachKhongAD.DataSource).Remove(dkm);
                        }
                    }
                }
                else
                {
                    if (gvDanhSachKhongAD.FocusedRowHandle >= 0)
                    {
                        if (MessageBox.Show("Bạn có chắc chắn xóa các items này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            MatHangInfor dkm = (MatHangInfor)gvDanhSachKhongAD.GetRow(gvDanhSachKhongAD.FocusedRowHandle);
                            ((BindingList<MatHangInfor>)gDanhSachKhongAD.DataSource).Remove(dkm);
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
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void btnImportCT_Click(object sender, EventArgs e)
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
                    sql = "Select [MaSanPham],[HangSX],[GiaMuaTu],[GiaMuaDen],[TyLeChietKhau],[TienChietKhau],[GiaTriMuaToiThieu],[SoLuongDuocMua],[SoLuongToiDaDH],[SoLuongPhaiMua] from [SPhamAD$] where [MaSanPham] is not null";
                    using (OleDbDataAdapter ad = new OleDbDataAdapter(sql, oConn))
                    {
                        ad.Fill(dsChungTu, "SanPham");
                    }
                }
                Cursor.Current = Cursors.Default;

                chinhSach.ListBangGiaADDKMua = new List<BangGiaADDKMuaInfor>();
                gSanPham.DataSource = new BindingList<BangGiaADDKMuaInfor>(chinhSach.ListBangGiaADDKMua);

                if (dsChungTu.Tables["SanPham"].Rows.Count == 0) return;

                frmProgress.Instance.Description = "Đang nạp dữ liệu ....";
                frmProgress.Instance.MaxValue = dsChungTu.Tables["SanPham"].Rows.Count;
                frmProgress.Instance.Value = 0;
                frmProgress.Instance.DoWork(ImportCTFromExcel);

                gSanPham.DataSource = new BindingList<BangGiaADDKMuaInfor>(chinhSach.ListBangGiaADDKMua);
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
                    TimKiemItemInfor item = TimKiemItemDataProvider.Instance.GetItemByTypeandCode(idNND, 6, ct["MaSanPham"].ToString());
                    if (item != null)
                    {
                        string maHang = Common.StringValue(ct["HangSX"]);
                        if (!ExistMaSanPham(6, item.Ma, maHang))
                        {
                            TimKiemItemInfor hsx = new TimKiemItemInfor();
                            if (!String.IsNullOrEmpty(maHang))
                                hsx = TimKiemItemDataProvider.Instance.GetItemByTypeandCode(idNND, 7, maHang);
                            chinhSach.ListBangGiaADDKMua.Add(new BangGiaADDKMuaInfor()
                            {
                                IdChinhSach = chinhSach.IdChinhSach,
                                LoaiHangMua = 6,
                                TenLoaiHangMua = "Sản phẩm",
                                MaHangMua = item.Ma,
                                TenHangMua = item.Ten,
                                MaHangSX = (hsx == null || String.IsNullOrEmpty(hsx.Ma) ? "" : hsx.Ma),
                                TenHangSX = (hsx == null || String.IsNullOrEmpty(hsx.Ten) ? "" : hsx.Ten),
                                GiaMuaTu = Common.DoubleValue(ct["GiaMuaTu"]),
                                GiaMuaDen = Common.DoubleValue(ct["GiaMuaDen"]),
                                TyLeChietKhau = Common.DoubleValue(ct["TyLeChietKhau"]),
                                TienChietKhau = Common.DoubleValue(ct["TienChietKhau"]),
                                GiaTriMuaToiThieu = Common.DoubleValue(ct["GiaTriMuaToiThieu"]),
                                SoLuongDuocMua = Common.IntValue(ct["SoLuongDuocMua"]),
                                SoLuongToiDaDH = Common.IntValue(ct["SoLuongToiDaDH"]),
                                SoLuongPhaiMua = Common.IntValue(ct["SoLuongPhaiMua"]),
                                TyLePhanBo = 100
                            });
                        }                        
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

        private void btnImportCTNo_Click(object sender, EventArgs e)
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
                    sql = "Select [MaSanPham] from [SPhamKhongAD$] where [MaSanPham] is not null";
                    using (OleDbDataAdapter ad = new OleDbDataAdapter(sql, oConn))
                    {
                        ad.Fill(dsChungTu, "SanPham");
                    }
                }
                Cursor.Current = Cursors.Default;

                lstMatHang = new List<MatHangInfor>();

                if (dsChungTu.Tables["SanPham"].Rows.Count == 0) return;

                frmProgress.Instance.Description = "Đang nạp dữ liệu ....";
                frmProgress.Instance.MaxValue = dsChungTu.Tables["SanPham"].Rows.Count;
                frmProgress.Instance.Value = 0;
                frmProgress.Instance.DoWork(ImportCTNoADFromExcel);

                gDanhSachKhongAD.DataSource = new BindingList<MatHangInfor>(lstMatHang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi import dữ liệu:\n" + ex.ToString());
            }
        }

        private void ImportCTNoADFromExcel()
        {
            string sql = String.Empty;

            try
            {
                int idNND = Common.Int2Bool(nguoiDung.SupperUser) ? -1 : nguoiDung.IdNhomNguoiDung;
                foreach (DataRow ct in dsChungTu.Tables["SanPham"].Rows)
                {
                    frmProgress.Instance.Value += 1;
                    if (String.IsNullOrEmpty(ct["MaSanPham"].ToString())) continue;
                    TimKiemItemInfor item = TimKiemItemDataProvider.Instance.GetItemByTypeandCode(idNND, 6, ct["MaSanPham"].ToString());
                    if (item != null)
                    {
                        MatHangInfor mh = new MatHangInfor();
                        mh.MaMatHang = item.Ma;
                        mh.TenMatHang = item.Ten;
                        mh.IdMatHang = item.Id;

                        if (!ExistMaSanPham(mh.MaMatHang, lstMatHang))
                        {
                            lstMatHang.Add(mh);
                        }
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

        private void gvSanPham_ShowingEditor(object sender, CancelEventArgs e)
        {
            //try
            //{
            //    if (gvSanPham.FocusedRowHandle < 0) return;
            //    if (gvSanPham.FocusedColumn.FieldName == "InHoaDon")
            //    {
            //        BangGiaADDKMuaInfor dkm = (BangGiaADDKMuaInfor)gvSanPham.GetRow(gvSanPham.FocusedRowHandle);
            //        if (dkm != null && dkm.LoaiHangMua != 6)
            //            e.Cancel = true;

            //    }
            //}
            //catch
            //{
            //}
        }
        //private void gtidButton1_Click(object sender, EventArgs e)
        //{
        //    foreach (BangGiaChinhSachInfor cs in liChinhSach)
        //    {
        //        cs.ChinhSachAD = cs != null ? cs.GhiChu : txtGhiChu.Text;
        //        //update sieu thị AD
        //        cs.SieuThiAD = "";
        //        if (cs.ListBangGiaADShop != null)
        //        {
        //            foreach (BangGiaADShopInfor bgShop in cs.ListBangGiaADShop)
        //            {
        //                cs.SieuThiAD += bgShop.TenTrungTam + (!String.IsNullOrEmpty(bgShop.MaKho) ? String.Format("({0});", bgShop.MaKho) : "") + "\r\n";
        //            }
        //        }

        //        //update doi tuong AD
        //        cs.DoiTuongAD = "";
        //        if (cs.ListBangGiaADKhach != null)
        //        {
        //            foreach (BangGiaADKhachInfor bgKhach in chinhSach.ListBangGiaADKhach)
        //            {
        //                cs.DoiTuongAD += bgKhach.TenLoaiDT + (!String.IsNullOrEmpty(bgKhach.MaDoiTuong) ? String.Format("({0});", bgKhach.MaDoiTuong) : "") + "\r\n";
        //            }
        //        }

        //        //update thoi gian AD
        //        cs.ThoiGianAD = "";
        //        if (cs.ListBangGiaADThoiGian != null)
        //        {
        //            foreach (BangGiaADTimeInfor bgTime in chinhSach.ListBangGiaADThoiGian)
        //            {
        //                cs.ThoiGianAD += !String.IsNullOrEmpty(bgTime.DayOfMonth) ? String.Format("DayOfMonth: {0} |", bgTime.DayOfMonth) : "";
        //                cs.ThoiGianAD += !String.IsNullOrEmpty(bgTime.DayOfWeek) ? String.Format("DayOfWeek: {0} |", bgTime.DayOfWeek) : "";
        //                cs.ThoiGianAD += bgTime.Thu != 0 ? String.Format("Thu: {0} |", bgTime.Thu) : "";
        //                cs.ThoiGianAD += bgTime.Ngay != 0 ? String.Format("Ngay: {0} |", bgTime.Ngay) : "";
        //                cs.ThoiGianAD += !String.IsNullOrEmpty(bgTime.GioTu) ? String.Format("From: {0} |", bgTime.GioTu) : "";
        //                cs.ThoiGianAD += !String.IsNullOrEmpty(bgTime.GioDen) ? String.Format("To: {0} |", bgTime.GioDen) : "" + "\r\n";
        //            }
        //        }

        //        //update thanh toan;
        //        cs.ThanhToanAD = "";
        //        if (chinhSach.ListBangGiaADThanhToan != null)
        //        {
        //            foreach (BangGiaADBankInfor bgBank in chinhSach.ListBangGiaADThanhToan)
        //            {
        //                cs.ThanhToanAD += bgBank.HinhThucThanhToan + (!String.IsNullOrEmpty(bgBank.TenNganHang) ? String.Format("(NHangTToan:{0});", bgBank.TenNganHang) : "");
        //                cs.ThanhToanAD += !String.IsNullOrEmpty(bgBank.TenNganHangPH) ? String.Format("(NHangPHanh:{0});", bgBank.TenNganHangPH) : "";
        //                cs.ThanhToanAD += (!String.IsNullOrEmpty(bgBank.ThoiHanThanhToan) ? String.Format("(THanTToan:{0});", bgBank.ThoiHanThanhToan) : "");
        //                cs.ThanhToanAD += (bgBank.TyLeThanhToan == 0 ? String.Format("(TLeTToan:{0}%);", bgBank.TyLeThanhToan) : "") + "\r\n";
        //            }
        //        }

        //        //update mota khac
        //        cs.MotaKhac = "";
        //        cs.MotaKhac += (chinhSach.DuyNhatCMND == 1 ? "Duy nhất CMND;" : "");
        //        cs.MotaKhac += (chinhSach.DuyNhatSDT == 1 ? "Duy nhất Số ĐT;" : "");
        //        cs.MotaKhac += (chinhSach.GiaTriHDToiThieu != 0 ? String.Format("Giá trị HĐ tối thiểu: {0};", Common.Double2Str(chinhSach.GiaTriHDToiThieu)) : "");
        //        cs.MotaKhac += (chinhSach.ThanhToanToiThieu != 0 ? String.Format("Thanh toán tối thiểu: {0};", Common.Double2Str(chinhSach.ThanhToanToiThieu)) : "");
        //        cs.MotaKhac += (chinhSach.GiaTriDHDaMua != 0 ? String.Format("Giá trị HĐ đã mua: {0};", Common.Double2Str(chinhSach.GiaTriDHDaMua)) : "");
        //        cs.MotaKhac += (chinhSach.ThoiHanMua != 0 ? String.Format("Thời hạn đã mua: {0} ngày;", Common.Double2Str(chinhSach.ThoiHanMua)) : "");

        //        ChinhSachDataProvider.Instance.UpdateBangGiaChinhSach(cs);

        //        //cs.ListBangGiaADDKMua = KhuyenMaiDataProvider.Instance.GetAllBangGiaADDKMuaInfors(cs.IdChinhSach);
        //        //foreach (BangGiaADDKMuaInfor dkm in cs.ListBangGiaADDKMua)
        //        //{
        //        //    dkm.ListKhuyenMai = KhuyenMaiDataProvider.Instance.GetAllBangGiaKhuyenMaiInfors(dkm.IdDKMua);
        //        //    for (int i = 0; i < dkm.ListKhuyenMai.Count; i++)
        //        //    {
        //        //        dkm.ListKhuyenMai[i].ListKhuyenMaiChiTiet =
        //        //            KhuyenMaiDataProvider.Instance.GetAllKhuyenMaiChiTietInfors(
        //        //                dkm.ListKhuyenMai[i].IdKhuyenMai);

        //        //        string khuyenMaiMa = "";
        //        //        string khuyenMai = "";
        //        //        foreach (BangGiaADKhuyenMaiChiTietInfor kmct in dkm.ListKhuyenMai[i].ListKhuyenMaiChiTiet)
        //        //        {
        //        //            khuyenMai += kmct.TenHangKM +
        //        //                         (kmct.SoLuong > 1 ? (";SLuong:" + kmct.SoLuong) : "") +
        //        //                         (kmct.SoTienKM > 0 ? (";TienKM:" + kmct.SoTienKM) : "") +
        //        //                         (kmct.TyLeKM > 0 ? (";TyleKM:" + kmct.TyLeKM + "%") : "") +
        //        //                         (kmct.SoTienYeuCau > 0 ? (";TienYC:" + kmct.SoTienYeuCau) : "") +
        //        //                         (";ThanhToan:" + kmct.TyLeThanhToan) + "\r\n";

        //        //            khuyenMaiMa += kmct.MaHangKM +
        //        //                           (kmct.SoLuong > 1 ? (";SLuong:" + kmct.SoLuong) : "") +
        //        //                           (kmct.SoTienKM > 0 ? (";TienKM:" + kmct.SoTienKM) : "") +
        //        //                           (kmct.TyLeKM > 0 ? (";TyleKM:" + kmct.TyLeKM + "%") : "") +
        //        //                           (kmct.SoTienYeuCau > 0 ? (";TienYC:" + kmct.SoTienYeuCau) : "") +
        //        //                           (";ThanhToan:" + kmct.TyLeThanhToan) + "\r\n";
        //        //        }
        //        //        dkm.KhuyenMaiMa = khuyenMaiMa;
        //        //        dkm.KhuyenMai = khuyenMai;
        //        //    }
        //        //}             
        //    }
        //}
    }
}