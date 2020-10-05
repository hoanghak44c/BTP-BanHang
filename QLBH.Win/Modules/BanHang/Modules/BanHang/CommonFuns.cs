using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraPrinting;
using QLBanHang.Modules.BanHang.Reports;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DongBoERP;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common.Providers;
using QLBH.Core.Data;
using QLBH.Common;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.DAO;
using QLBH.Core.Form;
using QLBH.Core.Providers;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.BanHang
{
    public class CommonFuns
    {
        private static CommonFuns instance;
        public static CommonFuns Instance
        {
            get
            {
                if (instance == null) instance = new CommonFuns();
                return instance;
            }
        }

        #region load chinh sach KM
        private bool ValidThoiGian(BangGiaChinhSachInfor csg)
        {
            DateTime tmp = CommonProvider.Instance.GetSysDate();
            bool found = false;
            if (csg.ListBangGiaADThoiGian != null && csg.ListBangGiaADThoiGian.Count > 0)
            {
                foreach (BangGiaADTimeInfor tt in csg.ListBangGiaADThoiGian)
                {
                    //if (tt.Thu >= 0 && !Common.CompareDayOfWeek(tt.Thu, tmp.DayOfWeek.ToString()))
                    //{
                    //    return false;
                    //}
                    //if (tt.Ngay >= 0 && tt.Ngay != tmp.Day - 1)
                    //{
                    //    return false;
                    //}
                    //if (!String.IsNullOrEmpty(tt.GioTu) && !String.IsNullOrEmpty(tt.GioDen) && !Common.CompareInDate(tt.GioTu, tt.GioDen, tmp.Hour, tmp.Minute))
                    //{
                    //    return false;
                    //}
                    if ((tt.Thu < 0 || tt.Thu >= 0 && Common.CompareDayOfWeek(tt.Thu, tmp.DayOfWeek.ToString())) &&
                        (tt.Ngay < 0 || tt.Ngay >= 0 && tt.Ngay != tmp.Day - 1) &&
                        (String.IsNullOrEmpty(tt.GioTu) || String.IsNullOrEmpty(tt.GioDen) || 
                            !String.IsNullOrEmpty(tt.GioTu) && !String.IsNullOrEmpty(tt.GioDen) && !Common.CompareInDate(tt.GioTu, tt.GioDen, tmp.Hour, tmp.Minute)))
                    {
                        found = true;
                        break;
                    }
                }
            }
            else
            {
                found = true; 
            }
            return found;
        }

        private bool ValidSoLuongDonHang(BangGiaChinhSachInfor csg, int idTrungTam, int idKho)
        {
            //kiem tra so don hang duoc mua
            foreach (BangGiaADDKMuaInfor dkm in csg.ListBangGiaADDKMua)
            {
                if (csg.SoKhachDauNgay > 0 && csg.SoKhachDauNgay <= BanHangDataProvider.Instance.SoLuongMatHangDaMua(-1, -1, dkm.MaHangMua, dkm.LoaiHangMua, csg.NgayHieuLuc, csg.HanHieuLuc, "", "", csg.IdDKMua, 0))
                {
                    return false;
                }
                //kiem tra so don hang theo tung sieu thi
                if (csg.ListBangGiaADShop != null)
                {
                    foreach (BangGiaADShopInfor shop in csg.ListBangGiaADShop)
                    {
                        if (shop.SoLuongDonHang > 0 && shop.IdTrungTam == idTrungTam && (shop.IdKho == idKho || shop.IdKho == 0) &&
                            shop.SoLuongDonHang <= BanHangDataProvider.Instance.SoLuongMatHangDaMua((shop.IdTrungTam != 0 ? shop.IdTrungTam : -1), (shop.IdKho != 0 ? shop.IdKho : -1), dkm.MaHangMua, dkm.LoaiHangMua, csg.NgayHieuLuc, csg.HanHieuLuc, "", "", csg.IdDKMua, 0))
                        {
                            return false;
                        }
                    }
                }               
            }

            return true;
        }
        public bool ValidChinhSach(BangGiaChinhSachInfor csg, List<ChungTuBanHangChiTietInfor> liChungTu)
        {
            foreach (ChungTuBanHangChiTietInfor ct in liChungTu)
            {
                if ((csg.GiaTriMuaToiThieu > 0 || csg.GiaTriHDToiThieu > 0) && ct.ChinhSach != null && ct.ChinhSach.IdChinhSach == csg.IdChinhSach)
                    return false;
            }
            return true;
        }
        public ChungTuBanHangChiTietInfor LoadChinhSachChietKhau(int idTrungTam, int idKho, int idLoaiDoiTuong)
        {
            ChungTuBanHangChiTietInfor ct = null;
            List<BangGiaCSachCKhauInfor> lstCKhau = ChinhSachDataProvider.Instance.GetCSachCKhauApDung(idTrungTam, idKho, idLoaiDoiTuong);
            if (lstCKhau.Count > 0)
            {
                frmBH_ChonHangChietKhau frm = new frmBH_ChonHangChietKhau(lstCKhau);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ct = new ChungTuBanHangChiTietInfor()
                             {
                                 IdSanPham = frm.ChietKhau.IdSanPham,
                                 MaSanPham = frm.ChietKhau.MaSanPham,
                                 TenSanPham = frm.ChietKhau.TenSanPham,
                                 DonViTinh = frm.ChietKhau.DonViTinh,
                                 ChietKhau = 1,
                                 TyLeCSachChietKhau = frm.ChietKhau.TyLeChietKhau,
                                 SoLuong = frm.ChietKhau.SoLuong,
                                 DonGiaCoVat = frm.ChietKhau.TienChietKhau,
                                 DonGia = frm.ChietKhau.TienChietKhau/(1 + frm.ChietKhau.TyLeVAT/100),
                                 TyleChietKhau = frm.ChietKhau.TienChietKhau == 0? frm.ChietKhau.TyLeChietKhau : 0,
                                 TienChietKhau = 0,
                                 TienSauChietKhau = frm.ChietKhau.TongTienChietKhau/(1 + frm.ChietKhau.TyLeVAT/100),
                                 TyleVAT = frm.ChietKhau.TyLeVAT,
                                 TienVAT =
                                     frm.ChietKhau.TongTienChietKhau*frm.ChietKhau.TyLeVAT/
                                     ((1 + frm.ChietKhau.TyLeVAT/100)*100),
                                 ThanhTien = frm.ChietKhau.TongTienChietKhau,
                                 TenLoaiHangKem = Declare.DescHangBan,
                                 CSachChietKhau = frm.ChietKhau,
                                 InHoaDon = (frm.ChietKhau.InHoaDon == 1 ? 3: 2)
                             };
                }
            }
            return ct;
        }

        public bool LoadChinhSachKM(ChungTuBanHangChiTietInfor ct, int idTrungTam, int idKho, int idLoaiDoiTuong, int loaiKhachHang, DevExpress.XtraGrid.GridControl gSanPhamBan, List<ChungTuBanHangChiTietInfor> liChungTu)
        {
            return LoadChinhSachKM(ct, idTrungTam, idKho, idLoaiDoiTuong, loaiKhachHang, gSanPhamBan, liChungTu, false);
        }
        public bool LoadChinhSachKM(ChungTuBanHangChiTietInfor ct, int idTrungTam, int idKho, int idLoaiDoiTuong, int loaiKhachHang, DevExpress.XtraGrid.GridControl gSanPhamBan, List<ChungTuBanHangChiTietInfor> liChungTu, bool datTruoc)
        {
            bool rs = true;
            List<BangGiaChinhSachInfor> lstCSG = ChinhSachDataProvider.Instance.GetAllChinhSachApDung(idTrungTam, idKho, idLoaiDoiTuong, ct.MaSanPham, loaiKhachHang);
            if (lstCSG != null && lstCSG.Count > 0)
            {
                List<BangGiaChinhSachInfor> liChinhSach = new List<BangGiaChinhSachInfor>();
                foreach (BangGiaChinhSachInfor csg in lstCSG)
                {
                    string lstMatHangKhongAD = String.Format(",{0},", csg.MatHangKhongApDung);//khong nam trong danh sach ko duoc ap dung
                    if (!lstMatHangKhongAD.Contains(String.Format(",{0},", ct.IdSanPham)) &&
                        !liChinhSach.Exists(delegate (BangGiaChinhSachInfor cs) { return cs.IdChinhSach == csg.IdChinhSach; }) &&
                        (liChinhSach.Count == 0 || liChinhSach.Count > 0 && liChinhSach[0].DoUuTien == csg.DoUuTien))
                    {
                        csg.ListBangGiaADThoiGian = ChinhSachDataProvider.Instance.GetBangGiaADThoiGianInfor(csg.IdChinhSach);
                        if (ValidThoiGian(csg))
                        {
                            csg.ListBangGiaADShop = ChinhSachDataProvider.Instance.GetBangGiaADShopInfor(csg.IdChinhSach);
                            csg.ListBangGiaADKhach = ChinhSachDataProvider.Instance.GetBangGiaADKhachInfor(csg.IdChinhSach);
                            csg.ListBangGiaADDKMua = KhuyenMaiDataProvider.Instance.GetBangGiaADDKMuaInforsById(csg.IdDKMua);
                            if (csg.ListBangGiaADDKMua != null)
                            {
                                foreach (BangGiaADDKMuaInfor dkm in csg.ListBangGiaADDKMua)
                                {
                                    dkm.ListSanPhamDaMua = KhuyenMaiDataProvider.Instance.GetAllSanPhamDaMuaInfors(dkm.IdDKMua);
                                    dkm.ListSanPhamKem = KhuyenMaiDataProvider.Instance.GetAllSanPhamKemInfors(dkm.IdDKMua);
                                }
                            }
                            if (ValidSoLuongDonHang(csg, idTrungTam, idKho) && ValidChinhSach(csg, liChungTu))
                            {
                                csg.ListBangGiaADThanhToan = ChinhSachDataProvider.Instance.GetBangGiaADThanhToanInfor(csg.IdChinhSach);
                                liChinhSach.Add(csg);                                
                            }
                        }                        
                    }
                }
                if (liChinhSach.Count == 1)
                {
                    List<BangGiaADKhuyenMaiInfor> lstKM = KhuyenMaiDataProvider.Instance.GetAllBangGiaKhuyenMaiADInfors(liChinhSach[0].IdDKMua);
                    if (lstKM != null && lstKM.Count > 1)
                    {
                        rs = ChonChinhSachKM(liChinhSach, ct, idTrungTam, idKho, gSanPhamBan, datTruoc);
                    }
                    else if (lstKM != null && lstKM.Count == 1)
                    {
                        List<BangGiaADSPKemInfor> lstSPK = liChinhSach[0].ListBangGiaADDKMua != null
                                                               ? liChinhSach[0].ListBangGiaADDKMua[0].ListSanPhamKem
                                                               : null;
                        List<BangGiaADSPDaMuaInfor> lstSPDM = liChinhSach[0].ListBangGiaADDKMua != null
                                                               ? liChinhSach[0].ListBangGiaADDKMua[0].ListSanPhamDaMua
                                                               : null;

                        //KhuyenMaiDataProvider.Instance.GetAllSanPhamKemInfors(liChinhSach[0].IdDKMua);
                        if (lstSPK != null && lstSPK.Count > 0 || lstSPDM != null && lstSPDM.Count > 0 || liChinhSach[0].ListBangGiaADThanhToan.Count > 1 ||
                            liChinhSach[0].ListBangGiaADThanhToan.Count == 1 && !liChinhSach[0].ListBangGiaADThanhToan[0].HinhThucThanhToan.Contains("không cần theo dõi") ||
                            liChinhSach[0].GiaTriMuaToiThieu > 0 || Declare.LstTrungTamNotDefault.Contains(String.Format(";{0};", idTrungTam)))
                            rs = ChonChinhSachKM(liChinhSach, ct, idTrungTam, idKho, gSanPhamBan, datTruoc);
                        else
                            rs = ChonChinhSachKM(liChinhSach[0], ct, lstKM[0], idTrungTam, idKho, gSanPhamBan, datTruoc);
                    }
                    else
                    {
                        List<BangGiaADSPKemInfor> lstSPK = liChinhSach[0].ListBangGiaADDKMua != null
                                                               ? liChinhSach[0].ListBangGiaADDKMua[0].ListSanPhamKem
                                                               : null;
                        List<BangGiaADSPDaMuaInfor> lstSPDM = liChinhSach[0].ListBangGiaADDKMua != null
                                                               ? liChinhSach[0].ListBangGiaADDKMua[0].ListSanPhamDaMua
                                                               : null;

                        if (lstSPK != null && lstSPK.Count > 0 || lstSPDM != null && lstSPDM.Count > 0 || liChinhSach[0].ListBangGiaADThanhToan.Count > 1 ||
                            liChinhSach[0].ListBangGiaADThanhToan.Count == 1 && !liChinhSach[0].ListBangGiaADThanhToan[0].HinhThucThanhToan.Contains("không cần theo dõi") ||
                            liChinhSach[0].GiaTriMuaToiThieu > 0 || Declare.LstTrungTamNotDefault.Contains(String.Format(";{0};", idTrungTam)))
                            rs = ChonChinhSachKM(liChinhSach, ct, idTrungTam, idKho, gSanPhamBan, datTruoc);
                        else
                        {
                            if (CheckValidChinhSachKM(ct, liChinhSach[0]))
                            {
                                ct.ChinhSach = liChinhSach[0];
                                if (ct.ChinhSach.ListBangGiaADDKMua != null && ct.ChinhSach.ListBangGiaADDKMua.Count > 0)
                                {
                                    BangGiaADDKMuaInfor dkm = ct.ChinhSach.ListBangGiaADDKMua[0];
                                    ct.TyleChietKhau = dkm.TyLeChietKhau;
                                    double tienKM = dkm.TyLeChietKhau == 0
                                                        ? dkm.TienChietKhau
                                                        : dkm.TyLeChietKhau*ct.DonGiaCoVat/100;
                                    double tienCK = dkm.TienChietKhau == 0
                                                        ? tienKM
                                                        : Common.MinValues(dkm.TienChietKhau, tienKM);
                                    ct.TienChietKhau = tienCK*ct.SoLuong/(1 + ct.TyleVAT/100);
                                    ct.TienSauChietKhau = ct.DonGia*ct.SoLuong - ct.TienChietKhau;
                                    ct.TienVAT = ct.TienSauChietKhau*ct.TyleVAT/100;
                                    ct.ThanhTien = Common.DoubleValueInt(ct.DonGiaCoVat*ct.SoLuong - tienCK*ct.SoLuong);
                                }

                                ct.TyLePhanBo = liChinhSach[0].TyLePhanBo/100;
                            }
                            else
                                rs = false;
                        }
                    }
                }
                else if (liChinhSach.Count > 0)
                {
                    rs = ChonChinhSachKM(liChinhSach, ct, idTrungTam, idKho, gSanPhamBan, datTruoc);
                }
                ((BindingList<ChungTuBanHangChiTietInfor>)gSanPhamBan.DataSource).ResetBindings();
            }
            else
            {
                if (ct.SoLuong > 1 && ct.ChinhSach != null)
                    rs = false;
            }

            if (ct.ChinhSach != null)
            {
                ct.TyLeDiemThuong = ct.ChinhSach.TyLeDiemThuong;
                ct.SoDiemThuong = ct.ChinhSach.SoDiemThuong;
            }
                
            return rs;
        }

        private bool CheckValidChinhSachKM(ChungTuBanHangChiTietInfor ct, BangGiaChinhSachInfor cs)
        {
            bool rs = true;
            if (ct.SoLuong > 1 && (ct.ChinhSach != null && ct.ChinhSach.IdChinhSach != cs.IdChinhSach || ct.ChinhSach == null))
            {
                rs = false;
                MessageBox.Show("Trên một đơn hàng không thể áp dụng 2 chính sách giá khác nhau được!");
            }
                
            return rs;
        }

        private bool ChonChinhSachKM(BangGiaChinhSachInfor chinhSach, ChungTuBanHangChiTietInfor ct, BangGiaADKhuyenMaiInfor khuyenMai, int idTrungTam, int idKho, DevExpress.XtraGrid.GridControl gSanPhamBan, bool datTruoc)
        {
            if (CheckValidChinhSachKM(ct, chinhSach))
            {
                //get khuyen mai
                string msg = "";
                khuyenMai.ListKhuyenMaiChiTiet =
                    KhuyenMaiDataProvider.Instance.GetAllKhuyenMaiChiTietADInfors(khuyenMai.IdKhuyenMai, idKho,
                                                                                  ct.DonGiaCoVat);
                foreach (BangGiaADKhuyenMaiChiTietInfor kmct in khuyenMai.ListKhuyenMaiChiTiet)
                {
                    //con ton hoac het ton nhung no khuyen mai
                    if (kmct.LoaiHangKM == 6) //neu la san pham
                    {
                        if (!(kmct.NoKhuyenMai == 0 && kmct.SoLuong > kmct.TonKho && kmct.HetTonDungKM == 1))
                        {
                            BangGiaBanChiTietInfor spb = BangGiaDataProvider.Instance.GetGiaBan(idTrungTam, idKho,
                                                                                                kmct.MaHangKM);

                            if (spb != null)
                            {
                                //add san pham ban
                                ChungTuBanHangChiTietInfor ct2 = BanHangDataProvider.Instance.ConvertBG2SanPhamKM(spb);
                                ct2.CungDongDonHangChinh = kmct.InKemHD;
                                ct2.LoaiHangKem = 0;
                                ct2.TenLoaiHangKem = Declare.DescKhuyenMai;
                                ct2.SoLuong = datTruoc ? kmct.SoLuong : kmct.SoLuong - kmct.NoKhuyenMai;
                                ct2.NoKhuyenMai = datTruoc ? 0 : kmct.NoKhuyenMai;
                                ct2.IdSanPhamBan = ct.IdSanPham;
                                ct2.TenSanPhamBan = ct.TenSanPham;
                                ct2.TyleChietKhau = kmct.TyLeKM;
                                ct2.TyleVAT = Common.Int2Bool(kmct.ChietKhau) ? ct.TyleVAT /*spb.TyLeVAT*/ : 0;
                                double tienKM = kmct.TyLeKM == 0 ? kmct.SoTienKM : kmct.TyLeKM*ct.DonGiaCoVat/100;
                                double tienCK = kmct.SoTienKM == 0 ? tienKM : Common.MinValues(kmct.SoTienKM, tienKM);
                                ct2.TienChietKhau = Common.Int2Bool(kmct.ChietKhau) ? -tienCK/(1 + ct2.TyleVAT/100) : 0;
                                ct2.TienSauChietKhau = ct2.TienChietKhau;
                                ct2.ThanhTien = Common.Int2Bool(kmct.ChietKhau) ? -tienCK : tienCK;
                                ct2.TienVAT = ct2.TyleVAT*ct2.ThanhTien/(100 + ct2.TyleVAT);
                                ct2.TyLeThanhToan = kmct.TyLeThanhToan;
                                ct2.ThanhTien = ct2.ThanhTien*kmct.TyLeThanhToan/100;
                                ct2.GhiChu = Common.Int2Bool(kmct.ChietKhau)
                                                 ? "CK"
                                                 : (datTruoc
                                                        ? "Đặt trước"
                                                        : (ct2.NoKhuyenMai > 0 ? "Nợ khuyến mại" : ""));
                                ct2.TonKho = kmct.TonKho;
                                ct2.SoLuongKhuyenMai = kmct.SoLuongOld;
                                UpdateListSanPham(gSanPhamBan, ct2);
                                ct2.SoLuongOld = ct2.SoLuong;
                                //((BindingList<ChungTuBanHangChiTietInfor>) gSanPhamBan.DataSource).Add(ct2);
                            }
                            else
                            {
                                msg +=
                                    String.Format(
                                        "Sản phẩm khuyến mại [{0} - {1}] chưa có giá nên không được khuyến mại. Liên hệ ngành hàng để cập nhật giá\n",
                                        kmct.MaHangKM, kmct.TenHangKM);
                            }
                        }
                    }
                    else
                    {
                        List<BangGiaChinhSachInfor> liCSG = new List<BangGiaChinhSachInfor>();
                        liCSG.Add(chinhSach);
                        return ChonChinhSachKM(liCSG, ct, idTrungTam, idKho, gSanPhamBan, datTruoc);
                    }
                }

                ct.ChinhSach = chinhSach;
                if (ct.ChinhSach != null && ct.ChinhSach.ListBangGiaADDKMua != null && ct.ChinhSach.ListBangGiaADDKMua.Count > 0)
                {
                    BangGiaADDKMuaInfor dkm = ct.ChinhSach.ListBangGiaADDKMua[0];
                    ct.TyleChietKhau = dkm.TyLeChietKhau;
                    double tienKM = dkm.TyLeChietKhau == 0
                                        ? dkm.TienChietKhau
                                        : dkm.TyLeChietKhau*ct.DonGiaCoVat/100;
                    double tienCK = dkm.TienChietKhau == 0
                                        ? tienKM
                                        : Common.MinValues(dkm.TienChietKhau, tienKM);
                    if (tienCK != 0)
                    {
                        ct.TienChietKhau = tienCK * ct.SoLuong / (1 + ct.TyleVAT / 100);
                        ct.TienSauChietKhau = ct.DonGia * ct.SoLuong - ct.TienChietKhau;
                        ct.TienVAT = ct.TienSauChietKhau * ct.TyleVAT / 100;
                        ct.ThanhTien = Common.DoubleValueInt(ct.TienSauChietKhau + ct.TienVAT); //ct.DonGia * ct.SoLuong - tienCK * ct.SoLuong;                        
                    }
                }

                ct.TyLePhanBo = chinhSach != null ? chinhSach.TyLePhanBo/100 : 1;
                if (!String.IsNullOrEmpty(msg))
                    frmMsgBox.Instance.ShowMessage(msg);
            }
            else
            {
                return false;
            }
            return true;
        }

        private void UpdateListSanPham(DevExpress.XtraGrid.GridControl gSanPhamBan, ChungTuBanHangChiTietInfor ct)
        {
            bool found = false;
            foreach (ChungTuBanHangChiTietInfor ctu in (BindingList<ChungTuBanHangChiTietInfor>) gSanPhamBan.DataSource)
            {
                if (ctu.IdSanPham == ct.IdSanPham && ctu.IdSanPhamBan == ct.IdSanPhamBan && 
                    ctu.TyleChietKhau == ct.TyleChietKhau && ctu.TyLeThanhToan == ct.TyLeThanhToan)
                {
                    ctu.SoLuong += ct.SoLuong;
                    ctu.NoKhuyenMai += (ctu.NoKhuyenMai > 0 ? ct.SoLuong : ct.NoKhuyenMai);
                    ctu.TienChietKhau += ct.TienChietKhau;
                    ctu.TienSauChietKhau += ct.TienSauChietKhau;
                    ctu.ThanhTien += ct.ThanhTien;
                    ctu.TienVAT += ct.TienVAT;
                    ctu.GhiChu = Common.Int2Bool(ctu.ChietKhau)
                                     ? "CK"
                                     : (ctu.NoKhuyenMai > 0 ? "Nợ khuyến mại" : "");

                    ctu.SoLuongOld = ctu.SoLuong;
                    found = true;
                    break;
                }                
            }
            
            if (!found)
            {
                ((BindingList<ChungTuBanHangChiTietInfor>) gSanPhamBan.DataSource).Add(ct);
            }      
        }

        private bool ChonChinhSachKM(List<BangGiaChinhSachInfor> liChinhSach, ChungTuBanHangChiTietInfor ct, int idTrungTam, int idKho, DevExpress.XtraGrid.GridControl gSanPhamBan, bool datTruoc)
        {
            frmBH_ChonChinhSach_BanHang frm = new frmBH_ChonChinhSach_BanHang(liChinhSach, ct, idKho, idTrungTam, datTruoc);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //them san pham
                if (frm.liSanPhamSelected.Count > 0)
                {
                    foreach (ChungTuBanHangChiTietInfor sp in frm.liSanPhamSelected)
                    {
                        //if (Common.Int2Bool(sp.ChietKhau) || sp.GhiChu.Equals("CK"))
                        //    TinhChietKhau(sp);
                        //else
                        UpdateListSanPham(gSanPhamBan, sp);
                        sp.SoLuongOld = ct.SoLuong;
                        //((BindingList<ChungTuBanHangChiTietInfor>)gSanPhamBan.DataSource).Add(sp);
                    }
                }

                ct.ChinhSach = frm.ChinhSachSelected;                
                ct.ListChinhSachDefault = (ct.ChinhSach.ApDungKemMacDinh == 1 ||
                                           ct.ChinhSach.MacDinh == (int) LoaiChinhSachGia.MAC_DINH)
                                              ? frm.liChinhSachDefault
                                              : new List<BangGiaChinhSachInfor>();

                //tinh tien chiet khau
                double tyleCK = 0;
                double chietkhau = 0;
                if (ct.ChinhSach != null && ct.ChinhSach.ListBangGiaADDKMua != null && ct.ChinhSach.ListBangGiaADDKMua.Count > 0)//chinh sach thuong
                {
                    BangGiaADDKMuaInfor dkm = ct.ChinhSach.ListBangGiaADDKMua[0];
                    tyleCK += dkm.TyLeChietKhau;
                    chietkhau += dkm.TienChietKhau;
                }
                if (ct.ListChinhSachDefault != null && ct.ListChinhSachDefault.Count > 0)
                {
                    foreach (BangGiaChinhSachInfor cs in ct.ListChinhSachDefault) //chinh sach mac dinh
                    {
                        BangGiaADDKMuaInfor dkm = cs.ListBangGiaADDKMua[0];
                        tyleCK += dkm.TyLeChietKhau;
                        chietkhau += dkm.TienChietKhau;
                    }
                }
                double tienKM = tyleCK != 0 ? tyleCK * ct.DonGiaCoVat / 100 : chietkhau;
                double tienCK = (chietkhau == 0)
                                    ? tienKM
                                    : (tienKM == 0 ? chietkhau : Common.MinValues(chietkhau, tienKM));
                if (tienCK != 0)
                {
                    tienCK = tienCK * frm.SoVoucherSelected;//tinh theo so voucher CK

                    ct.TienChietKhau = tienCK * ct.SoLuong / (1 + ct.TyleVAT / 100);
                    ct.TienSauChietKhau = ct.DonGia * ct.SoLuong - ct.TienChietKhau;
                    ct.TienVAT = ct.TienSauChietKhau * ct.TyleVAT / 100;
                    ct.ThanhTien = Common.DoubleValueInt(ct.TienSauChietKhau + ct.TienVAT);//ct.DonGiaCoVat * ct.SoLuong - tienCK * ct.SoLuong;                        
                }
                //if (ct.ChinhSach.ListBangGiaADDKMua != null && ct.ChinhSach.ListBangGiaADDKMua.Count > 0)
                //{
                //    BangGiaADDKMuaInfor dkm = ct.ChinhSach.ListBangGiaADDKMua[0];
                //    ct.TyleChietKhau = dkm.TyLeChietKhau;
                //    double tienKM = dkm.TyLeChietKhau == 0
                //                        ? dkm.TienChietKhau
                //                        : dkm.TyLeChietKhau * ct.DonGiaCoVat / 100;
                //    double tienCK = dkm.TienChietKhau == 0
                //                           ? tienKM
                //                           : Common.MinValues(dkm.TienChietKhau, tienKM);
                //    if (tienCK != 0)
                //    {
                //        tienCK = tienCK * frm.SoVoucherSelected;//tinh theo so voucher CK

                //        ct.TienChietKhau = tienCK * ct.SoLuong / (1 + ct.TyleVAT / 100);
                //        ct.TienSauChietKhau = ct.DonGia * ct.SoLuong - ct.TienChietKhau;
                //        ct.TienVAT = ct.TienSauChietKhau * ct.TyleVAT / 100;
                //        ct.ThanhTien = Common.DoubleValueInt(ct.TienSauChietKhau + ct.TienVAT);//ct.DonGiaCoVat * ct.SoLuong - tienCK * ct.SoLuong;                        
                //    }
                //}

                ct.TyLePhanBo = frm.ChinhSachSelected != null ? frm.ChinhSachSelected.TyLePhanBo / 100 : 1;
            }
            else
            {
                return frm.ValidCSG;
            }
            return true;
        }

        public void TinhChietKhau(ChungTuBanHangChiTietInfor km, DevExpress.XtraGrid.GridControl gSanPhamBan)
        {
            if (km.ThanhTien < 0) return;//bo qua voi truong hop chiet khau

            //dieu chinh gia
            int TyLe = 100;
            foreach (ChungTuBanHangChiTietInfor spb in (BindingList<ChungTuBanHangChiTietInfor>)gSanPhamBan.DataSource)
            {
                if (spb.IdSanPham == km.IdSanPhamBan)
                {
                    double tlvat = spb.TyleVAT < 0 ? 0 : spb.TyleVAT;
                    double tongtien, giamgia;
                    tongtien = spb.DonGia * spb.SoLuong;
                    giamgia = spb.DonGia - Common.Round((spb.ThanhTien - km.ThanhTien) / spb.SoLuong / (1 + spb.TyleVAT / TyLe));
                    spb.TienChietKhau = giamgia * spb.SoLuong;
                    spb.TienSauChietKhau = tongtien - spb.TienChietKhau;
                    spb.TienVAT = Common.Round(spb.TienSauChietKhau * tlvat / TyLe);
                    spb.ThanhTien = spb.ThanhTien - km.ThanhTien;
                    break;
                }
            }
        }

        /// <summary>
        /// Tính giá trị khuyến mại theo ngày lập (hiện tại hoặc lịch sử)
        /// </summary>
        /// <param name="idTrungTam"></param>
        /// <param name="idSanPham"></param>
        /// <param name="maSanPham"></param>
        /// <param name="ngayLap"></param>
        /// <param name="giaBan"></param>
        /// <param name="giaCoVAT"></param>
        /// <param name="tyleVAT"></param>
        /// <param name="khuyenmai"></param>
        /// <returns></returns>
        public double GetTienKhuyenMai(int idTrungTam, int idSanPham, string maSanPham, DateTime ngayLap, double giaBan, double giaCoVAT, double tyleVAT, ref string khuyenmai, ref int idDKMua)//lay tien khuyen mai hien tai hoac lich su
        {
            double tienKM = 0;
            List<BangGiaChinhSachInfor> liChinhSach = ChinhSachDataProvider.Instance.GetAllChinhSachDaApDung(idTrungTam, maSanPham, ngayLap);

            khuyenmai = "";
            foreach (BangGiaChinhSachInfor chinhSach in liChinhSach)
            {
                //hah: bo sung truong hop loai tru
                string idSanPhamKADs = String.Format(",{0},", chinhSach.MatHangKhongApDung);
                if (idSanPhamKADs.Contains(String.Format(",{0},", idSanPham)))
                {
                    continue;
                }
                //hah: bo sung truong hop loai tru

                if (!String.IsNullOrEmpty(khuyenmai))
                    khuyenmai += ".....\r\n";
                double km = 0;
                List<BangGiaADDKMuaInfor> liDKMua = KhuyenMaiDataProvider.Instance.GetBangGiaADDKMuaInforsById(chinhSach.IdDKMua);
                foreach (BangGiaADDKMuaInfor dkm in liDKMua)
                {
                    if (dkm.TyLeChietKhau != 0 || dkm.TienChietKhau != 0)
                    {
                        km = Common.MaxValues(km, dkm.TienChietKhau, dkm.TyLeChietKhau * giaCoVAT / 100);
                        khuyenmai += (dkm.TyLeChietKhau != 0 ? "TLCK:" + dkm.TyLeChietKhau.ToString() + ";" : "") +
                                     (dkm.TienChietKhau != 0 ? "TienCK:" + dkm.TienChietKhau.ToString() + ";" : "");
                    }
                }
                List<BangGiaADKhuyenMaiInfor> lstKM = KhuyenMaiDataProvider.Instance.GetAllBangGiaKhuyenMaiADInfors(chinhSach.IdDKMua);
                for (int i = 0; i < lstKM.Count; i++)
                {
                    string km1 = "__KM:";
                    double km2 = km;
                    lstKM[i].ListKhuyenMaiChiTiet = KhuyenMaiDataProvider.Instance.GetAllKhuyenMaiChiTietADTTInfors(lstKM[i].IdKhuyenMai, 0, giaBan);
                    foreach (BangGiaADKhuyenMaiChiTietInfor kmct in lstKM[i].ListKhuyenMaiChiTiet)
                    {
                        km2 += Common.MaxValues(kmct.SoTienKM, kmct.TyLeKM * giaBan / 100, kmct.GiaVon * kmct.SoLuong);
                        string tmp = (kmct.TyLeKM != 0 ? "TLCK:" + kmct.TyLeKM.ToString() + "," : "") +
                                     (kmct.SoTienKM != 0 ? "TienCK:" + kmct.SoTienKM.ToString() + "," : "");

                        km1 += kmct.MaHangKM + (String.IsNullOrEmpty(tmp) ? ";" : "(" + tmp + ");");
                    }
                    khuyenmai += km1;
                    if (tienKM < km2)
                    {
                        tienKM = km2;
                        idDKMua = chinhSach.IdDKMua;
                    }
                        
                }
            }

            return Math.Round(tienKM / (1 + tyleVAT / 100), 5);//tien KM chua co vat
        }

        /// <summary>
        /// Tính giá trị khuyến mại hiện tại
        /// </summary>
        /// <param name="idTrungTam"></param>
        /// <param name="idSanPham"></param>
        /// <param name="maSanPham"></param>
        /// <param name="giaBan"></param>
        /// <param name="giaCoVAT"></param>
        /// <param name="tyleVAT"></param>
        /// <returns></returns>
        public double GetTienKhuyenMai(int idTrungTam, int idSanPham, string maSanPham, double giaBan, double giaCoVAT, double tyleVAT, ref int idDKMua)
        {
            double tienKM = 0;
            List<BangGiaChinhSachInfor> liChinhSach = ChinhSachDataProvider.Instance.GetAllChinhSachApDungAll(idTrungTam, maSanPham);

            foreach (BangGiaChinhSachInfor chinhSach in liChinhSach)
            {
                //hah: bo sung truong hop loai tru
                string idSanPhamKADs = String.Format(",{0},", chinhSach.MatHangKhongApDung);
                if (idSanPhamKADs.Contains(String.Format(",{0},", idSanPham)))
                {
                    continue;
                }
                //hah: bo sung truong hop loai tru

                double km = 0;
                List<BangGiaADDKMuaInfor> liDKMua = KhuyenMaiDataProvider.Instance.GetBangGiaADDKMuaInforsById(chinhSach.IdDKMua);
                foreach (BangGiaADDKMuaInfor dkm in liDKMua)
                {
                    if (dkm.TyLeChietKhau != 0 || dkm.TienChietKhau != 0)
                    {
                        km = Common.MaxValues(km, dkm.TienChietKhau, dkm.TyLeChietKhau * giaCoVAT / 100);
                    }
                }
                List<BangGiaADKhuyenMaiInfor> lstKM = KhuyenMaiDataProvider.Instance.GetAllBangGiaKhuyenMaiADInfors(chinhSach.IdDKMua);
                for (int i = 0; i < lstKM.Count; i++)
                {
                    double km2 = km;
                    lstKM[i].ListKhuyenMaiChiTiet = KhuyenMaiDataProvider.Instance.GetAllKhuyenMaiChiTietADTTInfors(lstKM[i].IdKhuyenMai, 0, giaBan);
                    foreach (BangGiaADKhuyenMaiChiTietInfor kmct in lstKM[i].ListKhuyenMaiChiTiet)
                    {
                        km2 += Common.MaxValues(kmct.SoTienKM, kmct.TyLeKM * giaBan / 100, kmct.GiaVon * kmct.SoLuong);
                    }
                    if (tienKM < km2)
                    {
                        tienKM = km2;
                        idDKMua = chinhSach.IdDKMua;
                    }                        
                }
            }

            return Math.Round(tienKM / (1 + tyleVAT / 100), 5);//tien KM chua co vat
        }

        public bool IsStopDongBoKhuyenMaiOnDemand { get; set; }

        /// <summary>
        /// Đồng bộ dữ liệu chiết khấu từ POS sang Oracle
        /// </summary>
        /// <param name="idTrungTam">Id Trung tâm cần đẩy</param>
        /// <returns></returns>
        public string DongBoKhuyenMaiOracle(int idTrungTam)
        {
            string log = "";
            try
            {
                //load các sản phẩm cần đẩy khuyến mại
                List<BangGiaBanChiTietBCInfor> liKMai =
                    BangGiaDataProvider.Instance.LoadSanPhamChuaDayKhuyenMaiOrc(idTrungTam);

                //thuc hiện đẩy khuyến mại
                foreach (BangGiaBanChiTietBCInfor sp in liKMai)
                {
                    if(IsStopDongBoKhuyenMaiOnDemand) return "Is stopped on demand.";

                    //tinh khuyen mai
                    int idDKMua = 0;
                    double tienKhuyenMai = GetTienKhuyenMai(idTrungTam, sp.IdSanPham,
                                                            sp.MaSanPham, sp.DonGiaCoVAT,
                                                            sp.DonGiaCoVAT, sp.TyLeVAT, ref idDKMua);

                    //day khuyen mai
                    BangGiaDataProvider.Instance.DongBoKhuyenMai(idTrungTam, sp.MaSanPham, tienKhuyenMai, idDKMua);
                }            
            }
            catch (Exception ex)
            {
                log = ex.ToString();
            }
            return log;
        }

        /// <summary>
        /// Đồng bộ dữ liệu chiết khấu từ POS sang Oracle
        /// </summary>
        /// <returns></returns>
        public string DongBoKhuyenMaiWebsite()
        {
            string log = "";
            try
            {
                //load các sản phẩm cần đẩy khuyến mại
                List<BangGiaBanChiTietBCInfor> liKMai =
                    BangGiaDataProvider.Instance.LoadSanPhamChuaDayKhuyenMaiWeb();

                //dong bo khuyen mai len website
                DongBoGiaWebsite sync = new DongBoGiaWebsite(CommonProvider.Instance.GetSysDate(), liKMai);

                sync.AutoSync();
            }
            catch (Exception ex)
            {
                log = ex.ToString();
            }
            return log;
        }

        public void ShowChinhSachKM(DevExpress.XtraGrid.Views.Grid.GridView gvSanPhamBan)
        {
            try
            {
                if (gvSanPhamBan.FocusedRowHandle < 0) return;
                ChungTuBanHangChiTietInfor ct = (ChungTuBanHangChiTietInfor)gvSanPhamBan.GetRow(gvSanPhamBan.FocusedRowHandle);
                if (ct != null && ct.ListIdChinhSach != null && ct.ListIdChinhSach.Length > 2)
                {
                    string lstIdDKMua = ct.ListIdChinhSach.Replace(";", ",");
                    lstIdDKMua = lstIdDKMua.TrimStart(",".ToCharArray());
                    lstIdDKMua = lstIdDKMua.TrimEnd(",".ToCharArray());
                    List<BangGiaChinhSachInfor> liCSG = ChinhSachDataProvider.Instance.LoadChinhSachByIdDKMua(lstIdDKMua);
                    if (liCSG.Count > 0)
                    {
                        frmCS_List_ChinhSachKM_View frm = new frmCS_List_ChinhSachKM_View(liCSG[0], liCSG, true, null);
                        frm.Show();
                        frm.HideMenu();
                    }
                }
                else
                {
                    MessageBox.Show("Không có chính sách khuyến mại đi kèm");
                }
            }
            catch
            {
            }
        }

        public void RoundDetailValue(ChungTuBanHangChiTietInfor ct)
        {
            ct.DonGia = Common.DoubleValueInt(ct.DonGia);
            ct.TienChietKhau = Common.DoubleValueInt(ct.TienChietKhau);
            ct.TienSauChietKhau = Common.DoubleValueInt(ct.TienSauChietKhau);
            ct.TienVAT = Common.DoubleValueInt(ct.TienVAT);
            ct.ThanhTien = Common.DoubleValueInt(ct.ThanhTien);
            ct.DonGiaCoVat = Common.DoubleValueInt(ct.DonGiaCoVat);
            ct.GiaTheoBangGia = Common.DoubleValueInt(ct.GiaTheoBangGia);
            ct.GiaNiemYet = Common.DoubleValueInt(ct.GiaNiemYet);
            ct.GiaWebSite = Common.DoubleValueInt(ct.GiaWebSite);
        }

        public string GetOrderInfor(ChungTuBanHangInfor ctu, bool Updating, LoaiGiaoDichBanHang loaiGiaoDich)
        {
            string txt = Common.GetEnumInfor<LoaiGiaoDichBanHang>(loaiGiaoDich);
            txt += ctu.IdChungTu > 0
                       ? " (" +
                         String.Format("Người lập: {0}[{1}]", ctu.NguoiTao,
                                       Common.DateTime2String(ctu.ThoiGianTao)) +
                         (!ctu.NguoiTao.Equals(ctu.NguoiSua)
                              ? String.Format(" - Người sửa cuối: {0}[{1}]", ctu.NguoiSua,
                                              Common.DateTime2String(ctu.ThoiGianSua))
                              : "") + ") "
                       : "";
            if (Updating)
                txt += " - Đang cập nhật ...";
            return txt;
        }


        public void UpdateDataValue(BangGiaChiTietInfor bgct, string lstIdTrungTam, DateTime ngayLap)
        {
            if (bgct == null) return;
            //get khuyen mai
            string[] arIdTrungTam = lstIdTrungTam.Split(",".ToCharArray());
            string khuyemai = "";
            int iddkmua = 0;
            bgct.TienKhuyenMai = GetTienKhuyenMai(Common.IntValue(arIdTrungTam[0]), bgct.IdSanPham, bgct.MaSanPham,
                                                  ngayLap,
                                                  Common.MaxValues(bgct.DonGiaCoVAT, bgct.GiaBanBuon,
                                                                   bgct.GiaBanDemo,
                                                                   bgct.GiaNhapDemoCuoi,
                                                                   bgct.GiaTonKhoBQ,
                                                                   bgct.GiaNhapHDCuoi),
                                                  bgct.DonGiaCoVAT, bgct.TyLeVAT, ref khuyemai, ref iddkmua);
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
            //update lai datagrid
            //((BindingList<BangGiaChiTietInfor>)dgvSanPham.DataSource).ResetBindings();
            //UpdateTongLoiNhuan();                   
        }
        #endregion

        #region in phieu thu
        public void InPhieuGiaoNhan(ChungTuBanHangBCInfor ct)
        {
            if (ct == null) return;
            HoaDonPCGNInfo hd = new HoaDonPCGNInfo();

            DMNhanVienInfo nv = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(ct.IdNhanVien);
            hd.ThuongVien = (nv != null ? nv.HoTen : "");

            hd.SoChungTu = ct.SoChungTu;
            hd.SoHoaDon = ct.SoSeri;
            hd.NgayLap = ct.NgayLap;
            hd.KhachHang = ct.TenDoiTuong;
            hd.CongTy = ct.CongTy;
            hd.HoTen = ct.HoTen;
            hd.DiaChiHoaDon = ct.DiaChiHoaDon;
            hd.DiaChiGiaoHang = ct.DiaChiGiaoHang;
            hd.DienThoai = ct.DienThoai;
            DMKhoInfo dmKho = DMKhoDataProvider.GetKhoByIdInfo(ct.IdKho);
            if (dmKho != null)
            {
                hd.KhoXuat = dmKho.MaKho;
            }

            //hd.HinhThucThanhToan = ct.HinhThucTra;
            hd.CachGiaoHang = ct.GiaoNhan != 0 ? "Giao tại nhà khách" : "Giao tại công ty";
            hd.TongTienHang = ct.TongTienThanhToan;
            hd.TienThanhToanThuc = ct.TienThanhToanThuc;
            hd.TienConNo = ct.TienConNo;


            hd.NhanVienKinhDoanh = "";
            List<HangBanGiaoNhanChiTietInfor> liHangGiaoNhan =
                BanHangDataProvider.Instance.GetListChiTietChungTuByListIdChungTu(ct.IdChungTu.ToString());
            ChungTuGiaoNhanInfor giaoNhan = GiaoNhanDataProvider.Instance.GetChungTuGiaoNhanGetByCT(ct.IdChungTu);
            int idGiaoNhan = 0;
            if (giaoNhan != null)
            {
                idGiaoNhan = giaoNhan.IdGiaoNhan;
                List<ChungTuGiaoNhanChiTietInfor> liGNCTiet = GiaoNhanDataProvider.Instance.GetListChungTuGNhanChiTietGetById(giaoNhan.IdGiaoNhan);
                foreach (ChungTuGiaoNhanChiTietInfor ctgn in liGNCTiet)
                {
                    hd.NhanVienKinhDoanh += String.Format("{0}(Phương tiện: {1})", ct.HoTen, ctgn.TenPhuongTien) +
                                            (String.IsNullOrEmpty(ctgn.BienSoXe) ? "" : "/" + ctgn.BienSoXe) + ";";
                }
            }

            hd.GhiChu = ct.GhiChu;
            InPhieuGiaoNhan(hd, liHangGiaoNhan, idGiaoNhan);
        }
        public void InPhieuGiaoNhan(ChungTuBanHangInfor ct)
        {
            if (ct == null) return;
            HoaDonPCGNInfo hd = new HoaDonPCGNInfo();

            DMNhanVienInfo nv = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(ct.IdNhanVien);
            hd.ThuongVien = (nv != null ? nv.HoTen : "");

            hd.SoChungTu = ct.SoChungTu;
            hd.SoHoaDon = ct.SoSeri;
            hd.NgayLap = ct.NgayLap;
            hd.KhachHang = ct.TenDoiTuong;
            hd.CongTy = ct.CongTy;
            hd.HoTen = ct.HoTen;
            hd.DiaChiHoaDon = ct.DiaChiHoaDon;
            hd.DiaChiGiaoHang = ct.DiaChiGiaoHang;
            hd.DienThoai = ct.DienThoai;
            DMKhoInfo dmKho = DMKhoDataProvider.GetKhoByIdInfo(ct.IdKho);
            if (dmKho != null)
            {
                hd.KhoXuat = dmKho.MaKho;
            }

            //hd.HinhThucThanhToan = ct.HinhThucTra;
            hd.CachGiaoHang = ct.GiaoNhan != 0 ? "Giao tại nhà khách" : "Giao tại công ty";
            hd.TongTienHang = ct.TongTienThanhToan;
            hd.TienThanhToanThuc = ct.TienThanhToanThuc;
            hd.TienConNo = ct.TienConNo;


            hd.NhanVienKinhDoanh = "";
            List<HangBanGiaoNhanChiTietInfor> liHangGiaoNhan =
                BanHangDataProvider.Instance.GetListChiTietChungTuByListIdChungTu(ct.IdChungTu.ToString());
            ChungTuGiaoNhanInfor giaoNhan = GiaoNhanDataProvider.Instance.GetChungTuGiaoNhanGetByCT(ct.IdChungTu);
            int idGiaoNhan = 0;
            if (giaoNhan != null)
            {
                idGiaoNhan = giaoNhan.IdGiaoNhan;
                List<ChungTuGiaoNhanChiTietInfor> liGNCTiet = GiaoNhanDataProvider.Instance.GetListChungTuGNhanChiTietGetById(giaoNhan.IdGiaoNhan);
                foreach (ChungTuGiaoNhanChiTietInfor ctgn in liGNCTiet)
                {
                    hd.NhanVienKinhDoanh += String.Format("{0}(Phương tiện: {1})", ct.HoTen, ctgn.TenPhuongTien) +
                                            (String.IsNullOrEmpty(ctgn.BienSoXe) ? "" : "/" + ctgn.BienSoXe) + ";";
                }
            }

            hd.GhiChu = ct.GhiChu;
            InPhieuGiaoNhan(hd, liHangGiaoNhan, idGiaoNhan);
        }
        public void InPhieuGiaoNhan(HoaDonPCGNInfo hd, List<HangBanGiaoNhanChiTietInfor> liChiTietBaoCao, int idGiaoNhan)
        {
            try
            {
                //Cap nhat so lan in phan cong giao nhan
                if (idGiaoNhan > 0)
                    GiaoNhanDataProvider.Instance.TangSoLanInGiaoNhan(idGiaoNhan);
                //In phieu giao nhan
                rpt_BC_PhieuPhanCongGiaoNhan rp = new rpt_BC_PhieuPhanCongGiaoNhan(hd);
                rp.DataSource = liChiTietBaoCao;
                rp.ShowPreview();
            }
            catch (Exception e)
            {
                MessageBox.Show("Loi: " + e.ToString());
            }
        }
        public void InPhieuGiaoNhan(HoaDonPCGNInfo hd, List<HangBanGiaoNhanChiTietInfor> liChiTietBaoCao)
        {
            try
            {
                //In phieu giao nhan
                rpt_BC_PhieuPhanCongGiaoNhan rp = new rpt_BC_PhieuPhanCongGiaoNhan(hd);
                rp.DataSource = liChiTietBaoCao;
                rp.ShowPreview();
            }
            catch (Exception e)
            {
                MessageBox.Show("Loi: " + e.ToString());
            }
        }
        public void InPhieuThu(List<ChungTuThanhToanInfor> ListChungTuThanhToan, string hangHoa, double tongTienDonHang, double tienConNo)
        {
            try
            {
                string trungTam = Declare.DienThoaiTrungTam;
                if (String.IsNullOrEmpty(trungTam))
                    trungTam =
                        DBTools.getValue("Select ListPhone From tbl_DM_TrungTam where idtrungtam = " +
                                         Declare.IdTrungTam);
                
                foreach (ChungTuThanhToanInfor tt in ListChungTuThanhToan)
                {
                    if (tt.LoaiThanhToan != -1)//khong phai voucher thi in ra
                    {
                        rpt_PhieuThuTien rp = new rpt_PhieuThuTien(tt, trungTam, hangHoa, tongTienDonHang, tienConNo);
                        rp.ShowPreview();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Loi: " + e.ToString());
            }
        }
        public void InDonHangTraLai(HoaDonPCGNInfo hd, List<NhapHangTraChiTietHHInfor> liChiTietBaoCao)
        {
            try
            {
                rpt_BC_PhieuTraLaiHang rp = new rpt_BC_PhieuTraLaiHang(hd);
                rp.DataSource = liChiTietBaoCao;
                rp.ShowPreview();
            }
            catch (Exception e)
            {
                MessageBox.Show("Loi: " + e.ToString());
            }
        }

        public void InDonHangDoiMa(HoaDonPCGNInfo hd, List<BHangDoiMaChiTietHHInfor> liChiTietBaoCao)
        {
            try
            {
                rpt_BC_PhieuDoiMaVach rp = new rpt_BC_PhieuDoiMaVach(hd);
                rp.DataSource = liChiTietBaoCao;
                rp.ShowPreview();
            }
            catch (Exception e)
            {
                MessageBox.Show("Loi: " + e.ToString());
            }
        }

        public void InHoaDon(ChungTuBanHangInfor ChungTu, List<ChungTuBanHangChiTietInfor> ListChiTietChungTu, DevExpress.XtraEditors.ButtonEdit bteKhoXuat, DevExpress.XtraEditors.ButtonEdit bteThuongVien, DevExpress.XtraEditors.ButtonEdit bteKhachHang)
        {
            frmBH_LuaChonInHoaDon frm = new frmBH_LuaChonInHoaDon(ChungTu.NgayHoaDon);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                HoaDonGTGTInfo hd = new HoaDonGTGTInfo();
                hd.SoChungTu = ChungTu.SoChungTu;
                hd.NgayLap = ChungTu.NgayHoaDon;// ChungTu.NgayLap;
                hd.TenDonVi = ChungTu.CongTy;
                hd.DiaChi = ChungTu.DiaChiHoaDon;
                hd.NguoiMuaHang = ChungTu.HoTen;
                hd.MaSoThue = ChungTu.MaSoThue;
                hd.KhoXuat = (bteKhoXuat.Tag != null) ? ((DMKhoInfo)bteKhoXuat.Tag).MaKho : "";
                hd.NhanVien = ((bteThuongVien.Tag != null) ? ((DMNhanVienInfo) bteThuongVien.Tag).MaNhanVien : "") +
                              ((bteKhachHang.Tag != null) ? " - " + ((DMDoiTuongInfo) bteKhachHang.Tag).MaDoiTuong : "");
                hd.TongTienChuaVAT = Common.Double2Str(ChungTu.TongTienSauChietKhau);
                hd.TongTienVAT = Common.Double2Str(ChungTu.TongTienVAT);
                hd.TongTienThanhToan = Common.Double2Str(ChungTu.TongTienThanhToan);
                hd.SoTienChu = Common.ReadNumner_(ChungTu.TongTienThanhToan);
                hd.SoTienThucTra = Common.Double2Str(ChungTu.TienThanhToanThuc);
                hd.SoTienConNo = Common.Double2Str(ChungTu.TienConNo);
                hd.NguoiLap = Declare.USER_INFOR != null ? ((NguoiDungInfor) Declare.USER_INFOR).TenNhanVien : "";
                DMDoiTuongInfo dt = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(ChungTu.IdDoiTuong);
                double vat0 = 0, tien0 = 0, vat5 = 0, tien5 = 0, vat10 = 0, tien10 = 0;
                foreach (ChungTuBanHangChiTietInfor ct in ListChiTietChungTu)
                {
                    //if (ct.CSachChietKhau != null) continue;
                    if (ct.ChietKhau == 1 && ct.InHoaDon > 1) continue;//ma chinh sach chiet khau
                    ct.DaInHoaDon = 0;
                    if (ct.TyleVAT == 0)
                    {
                        vat0 += ct.TienVAT;
                        tien0 += ct.TienSauChietKhau;
                    }
                    else if (ct.TyleVAT == 5)
                    {
                        vat5 += ct.TienVAT;
                        tien5 += ct.TienSauChietKhau;                        
                    }
                    else if (ct.TyleVAT == 10)
                    {
                        vat10 += ct.TienVAT;
                        tien10 += ct.TienSauChietKhau;                                                
                    }
                }
                hd.TongTienChuaVAT0 = tien0 != 0 ? Common.Double2Str(Math.Round(tien0,2)) : "";
                hd.TongTienChuaVAT5 = tien5 != 0 ? Common.Double2Str(Math.Round(tien5,2)) : "";
                hd.TongTienChuaVAT10 = tien10 != 0 ? Common.Double2Str(Math.Round(tien10,2)) : "";
                hd.TongTienVAT0 = vat0 != 0 ? Common.Double2Str(Math.Round(vat0,2)) : "";
                hd.TongTienVAT5 = vat5 != 0 ? Common.Double2Str(Math.Round(vat5,2)) : "";
                hd.TongTienVAT10 = vat10 != 0 ? Common.Double2Str(Math.Round(vat10, 2)) : "";

                rpt_HoaDonGTGT rp = new rpt_HoaDonGTGT(hd);
                
                List<ChungTuBanHangChiTietInfor> liChiTietBaoCao = new List<ChungTuBanHangChiTietInfor>();

                foreach (ChungTuBanHangChiTietInfor ct in ListChiTietChungTu)
                {
                    if (Declare.LstNotInHoaDon.Contains(";" + ct.MaSanPham + ";")/* || (ct.CSachChietKhau != null && ct.CSachChietKhau.InHoaDon == 0)*/) continue;
                    ChungTuBanHangChiTietInfor bcct = BanHangDataProvider.Instance.ConvertSanPhamBan2BaoCao(ct, false);
                    if (ct.IdSanPhamBan == 0 && ct.ChietKhau == 1 && ct.InHoaDon == 3)//theo chinh sach chiet khau
                    {
                        ct.DaInHoaDon = 1;
                        liChiTietBaoCao.Add(bcct);
                        continue;
                    }
                    if (ct.IdSanPhamBan == 0 && ct.ChietKhau == 0)// || ct.IdSanPhamBan > 0 && ct.LoaiHangKem != 0)
                    {
                        ct.DaInHoaDon = 1;
                        liChiTietBaoCao.Add(bcct);
                        foreach (ChungTuBanHangChiTietInfor km in ListChiTietChungTu)
                        {
                            if (km.IdSanPhamBan == bcct.IdSanPham && km.LoaiHangKem == 0 && km.DaInHoaDon == 0 && km.SoLuong != 0)
                            {
                                km.DaInHoaDon = 1;
                                ChungTuBanHangChiTietInfor bckm = BanHangDataProvider.Instance.ConvertSanPhamBan2BaoCao(km, false);
                                if (bckm.TyleVAT == 0) bckm.TyLeVATText = "";
                                if (bckm.ChietKhau == 1)//chiet khau thi tinh ga luon
                                {
                                    /*
                                    bcct.DonGia += bckm.ThanhTien - bckm.TienVAT;
                                    bcct.TienSauChietKhau += bckm.ThanhTien - bckm.TienVAT;
                                    bcct.DonGiaCoVat += bckm.DonGiaCoVat;
                                    bcct.TienVAT += bckm.TienVAT;
                                    bcct.ThanhTien += bckm.ThanhTien;  
                                    */
                                    bcct.DonGia += -bckm.DonGia;
                                    bcct.TienChietKhau += -bckm.TienChietKhau;
                                    bcct.TienSauChietKhau += bckm.ThanhTien - bckm.TienVAT;
                                    bcct.DonGiaCoVat += -bckm.DonGiaCoVat;
                                    bcct.TienVAT += bckm.TienVAT;
                                    bcct.ThanhTien += bckm.ThanhTien;
                                    if (bckm.InHoaDon == 1)
                                    {
                                        bckm.DonGia = 0;
                                        bckm.TienChietKhau = 0;
                                        bckm.TienSauChietKhau = 0;
                                        bckm.DonGiaCoVat = 0;
                                        bckm.TyleVAT = 0;
                                        bckm.TyLeVATText = "";
                                        bckm.TienVAT = 0;
                                        bckm.ThanhTien = 0;
                                        liChiTietBaoCao.Add(bckm);
                                    }
                                }
                                else
                                {
                                    if (frm.TypeInHd == 1)//hang KM co gia
                                    {
                                        bcct.DonGia -= bckm.DonGia;
                                        bcct.TienSauChietKhau -= bckm.TienSauChietKhau;
                                        bcct.DonGiaCoVat -= bckm.DonGiaCoVat;
                                        bcct.TienVAT -= bckm.TienVAT;
                                        bcct.ThanhTien -= bckm.ThanhTien;
                                        liChiTietBaoCao.Add(bckm);
                                    }
                                    else if (frm.TypeInHd == 2)//in KM cung dong hang chinh
                                    {
                                        bcct.TenSanPham = bcct.TenSanPham + "/" + km.TenSanPham;
                                    }
                                    else//hang km khong co gia
                                    {
                                        bckm.DonGia = 0;
                                        bckm.TienSauChietKhau = 0;
                                        bckm.DonGiaCoVat = 0;
                                        bckm.TienVAT = 0;
                                        bckm.ThanhTien = 0;
                                        liChiTietBaoCao.Add(bckm);
                                    }                                    
                                }
                            }
                        }
                    }
                    else if (ct.IdSanPhamBan > 0 && ct.LoaiHangKem != 0 && ct.SoLuong != 0)
                    {
                        ct.DaInHoaDon = 1;
                        liChiTietBaoCao.Add(bcct);                        
                    }
                }
                foreach (ChungTuBanHangChiTietInfor ct in liChiTietBaoCao)
                    if (ct.SoLuong != 0)
                        ct.DonGia = ct.TienSauChietKhau/ct.SoLuong;

                //cap nhật ngày hóa đơn
                BanHangDataProvider.Instance.CapNhatNgayInHoaDon(ChungTu.IdChungTu, ChungTu.NguoiSua, ChungTu.TenMaySua,
                                                                 frm.NgayInHoaDon);
                ChungTu.NgayHoaDon = frm.NgayInHoaDon;

                if (ChungTu.NgayHoaDon == DateTime.MinValue)
                {
                    rp.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Print, CommandVisibility.None);

                    rp.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Save, CommandVisibility.None);
                }

                //show hoa don
                rp.DataSource = liChiTietBaoCao;
                rp.ShowPreview();                
            }
        }

        public void InHoaDonKhuyenMai(ChungTuBanHangInfor ChungTu, List<ChungTuBanHangChiTietInfor> ListChiTietChungTu, DevExpress.XtraEditors.ButtonEdit bteKhoXuat, DevExpress.XtraEditors.ButtonEdit bteThuongVien, DevExpress.XtraEditors.ButtonEdit bteKhachHang)
        {
            frmBH_LuaChonInHoaDon frm = new frmBH_LuaChonInHoaDon(ChungTu.NgayHoaDon);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                HoaDonGTGTInfo hd = new HoaDonGTGTInfo();
                hd.SoChungTu = ChungTu.SoChungTu;
                hd.NgayLap = ChungTu.NgayLap;
                hd.TenDonVi = ChungTu.CongTy;
                hd.DiaChi = ChungTu.DiaChiHoaDon;
                hd.NguoiMuaHang = ChungTu.HoTen;
                hd.MaSoThue = ChungTu.MaSoThue;
                hd.KhoXuat = (bteKhoXuat.Tag != null) ? ((DMKhoInfo)bteKhoXuat.Tag).MaKho : "";
                hd.NhanVien = ((bteThuongVien.Tag != null) ? ((DMNhanVienInfo)bteThuongVien.Tag).MaNhanVien : "") +
                              ((bteKhachHang.Tag != null) ? "-" + ((DMDoiTuongInfo)bteKhachHang.Tag).MaDoiTuong : "");
                hd.TongTienChuaVAT = "";
                hd.TongTienVAT = "";
                hd.TongTienThanhToan = "";
                hd.SoTienChu = "";
                hd.SoTienThucTra = "";
                hd.SoTienConNo = "";
                hd.NguoiLap = Declare.USER_INFOR != null ? ((NguoiDungInfor)Declare.USER_INFOR).TenNhanVien : "";

                hd.TongTienChuaVAT0 = "";
                hd.TongTienChuaVAT5 = "";
                hd.TongTienChuaVAT10 = "";
                hd.TongTienVAT0 = "";
                hd.TongTienVAT5 = "";
                hd.TongTienVAT10 = "";

                rpt_HoaDonGTGT rp = new rpt_HoaDonGTGT(hd);
                List<ChungTuBanHangChiTietInfor> liChiTietBaoCao = new List<ChungTuBanHangChiTietInfor>();

                foreach (ChungTuBanHangChiTietInfor ct in ListChiTietChungTu)
                {
                    ChungTuBanHangChiTietInfor bcct = BanHangDataProvider.Instance.ConvertSanPhamBan2BaoCao(ct, true);
                    liChiTietBaoCao.Add(bcct);
                }

                //cap nhật ngày hóa đơn
                BanHangDataProvider.Instance.CapNhatNgayInHoaDon(ChungTu.IdChungTu, ChungTu.NguoiSua, ChungTu.TenMaySua,
                                                                 frm.NgayInHoaDon);
                ChungTu.NgayHoaDon = frm.NgayInHoaDon;

                if (ChungTu.NgayHoaDon == DateTime.MinValue)
                {
                    rp.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Print, CommandVisibility.None);

                    rp.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Save, CommandVisibility.None);
                }

                rp.DataSource = liChiTietBaoCao;
                rp.ShowPreview();   
            }
        }

        public static void InHoaDon(HoaDonGTGTInfo ChungTu, List<ChungTuBanHangChiTietInfor> ListChiTietChungTu)
        {
            rpt_HoaDonGTGT rp = new rpt_HoaDonGTGT(ChungTu);
            rp.DataSource = ListChiTietChungTu;
            rp.ShowPreview();
        }

        public void LoadComboBoxPages(ComboBox cboPage)
        {
            string[] values = {"50", "100", "200", "1000", "2000", "10000"};
            cboPage.Items.Clear();
            for (int i = 0; i < values.Length; i++)
                cboPage.Items.Add(values[i]);
            NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
            if (nguoiDung.SupperUser == 1 || nguoiDung.QuanTri == 1)
                cboPage.Items.Add("Tất cả");
            cboPage.SelectedIndex = 0;
        }

        public void LoadSearchCboPages(ComboBox cboPage)
        {
            string[] values = { "50", "70", "100"};
            cboPage.Items.Clear();
            for (int i = 0; i < values.Length; i++)
                cboPage.Items.Add(values[i]);
            NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
            if (nguoiDung.SupperUser == 1)// || nguoiDung.QuanTri == 1)
                cboPage.Items.Add("Tất cả");
            cboPage.SelectedIndex = 0;
        }

        public string GetUserName()
        {
            NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();

            string userName = (nguoiDung.XemBaoCao == 1 || nguoiDung.SupperUser == 1) ? "" : nguoiDung.TenDangNhap;
            return userName;
        }
        public string GetUserNameCSKH()
        {
            NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();

            string userName = (nguoiDung.NhomQuyenHan >= (int)NhomQuyenHan.GiamDocSieuThi || nguoiDung.SupperUser == 1) ? "" : nguoiDung.TenDangNhap;
            return userName;
        }
        public int GetIdNhanVien(DevExpress.XtraEditors.ButtonEdit bteNhanVien)
        {
            //NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
            //                                   ? (NguoiDungInfor)Declare.USER_INFOR
            //                                   : new NguoiDungInfor();

            //int idNhanVien = nguoiDung.IdNhanVien;
            //if (nguoiDung.XemBaoCao == 1 || nguoiDung.SupperUser == 1)
            //{
            //    idNhanVien = bteNhanVien.Tag != null ? ((DMNhanVienInfo) bteNhanVien.Tag).IdNhanVien : -1;
            //}
            //return idNhanVien;
            return bteNhanVien.Tag != null ? ((DMNhanVienInfo)bteNhanVien.Tag).IdNhanVien : -1;
        }
        public int GetSoTon()
        {
            NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();

            int soTon = nguoiDung.SupperUser == 1
                            ? -1
                            : (nguoiDung.XemTon != 0 ? nguoiDung.XemTon : Declare.SOLUONG_HIENTHI_TON);
            return soTon;
        }
        public string GetSoPhieuThuChi(string order, string pre, int count)
        {
            int ind = order.IndexOf("-");
            string tmp="", sophieu = "";
            if (ind >= 0)
            {
                tmp = order.Substring(ind + 1);
            }
            else
            {
                tmp = order;
            }
            sophieu = String.Format("{0}-{1}", pre, order);//tmp);
            if (count == 0)
                return sophieu;
            else
            {
                return String.Format("{0}-{1}", sophieu, count);
            }
        }

        public void LoadKhoXuat(DevExpress.XtraEditors.ButtonEdit bteKhoXuat, int idKho)
        {
            DMKhoInfo dmKho = DMKhoDataProvider.GetKhoByIdInfo(idKho);
            if (dmKho != null)
            {
                bteKhoXuat.Text = dmKho.TenKho;
                bteKhoXuat.Tag = dmKho;
            }
        }
        public void LoadTrungTam(DevExpress.XtraEditors.ButtonEdit bteTrungTam, NguoiDungInfor nguoiDung)
        {
            if (nguoiDung.QuanTri == 1|| nguoiDung.SupperUser == 1)
            {
                bteTrungTam.Enabled = true;
            }
            else
            {
                DMTrungTamInfor info = DMTrungTamDataProvider.GetTrungTamByIdInfo(nguoiDung.IdTrungTamHachToan);
                if (info != null)
                {
                    bteTrungTam.Text = info.TenTrungTam;
                    bteTrungTam.Tag = info;
                }

                bteTrungTam.Enabled = false;
            }
        }
        public void LoadChonTrungTam(DevExpress.XtraEditors.ButtonEdit bteTrungTam, NguoiDungInfor nguoiDung)
        {
            if (nguoiDung.QuanTri == 1 && nguoiDung.ChonTrungTamHienTai != 1 || nguoiDung.SupperUser == 1)
            {
                bteTrungTam.Enabled = true;
            }
            else
            {
                DMTrungTamInfor info = DMTrungTamDataProvider.GetTrungTamByIdInfo(nguoiDung.IdTrungTamHachToan);
                if (info != null)
                {
                    bteTrungTam.Text = info.TenTrungTam;
                    bteTrungTam.Tag = info;
                }

                bteTrungTam.Enabled = false;
            }
        }
        public void LoadAllTrungTam(DevExpress.XtraEditors.ButtonEdit bteTrungTam, NguoiDungInfor nguoiDung)
        {
            DMTrungTamInfor info = DMTrungTamDataProvider.GetTrungTamByIdInfo(nguoiDung.IdTrungTamHachToan);
            if (info != null)
            {
                bteTrungTam.Text = info.TenTrungTam;
                bteTrungTam.Tag = info;
            }

            bteTrungTam.Enabled = true;
        }
        public void LoadTrungTamBaoHanh(DevExpress.XtraEditors.ButtonEdit bteTrungTam, NguoiDungInfor nguoiDung)
        {
            if (nguoiDung.SupperUser == 1 || nguoiDung.SaleAdmin == 1)
            {
                bteTrungTam.Enabled = true;
            }
            else
            {
                DMTrungTamInfor info = DMTrungTamDataProvider.GetTrungTamByIdInfo(nguoiDung.IdTrungTamHachToan);
                if (info != null)
                {
                    bteTrungTam.Text = info.TenTrungTam;
                    bteTrungTam.Tag = info;
                }

                bteTrungTam.Enabled = false;                
            }
        }
        public int GetIdTrungTam(DevExpress.XtraEditors.ButtonEdit bteTrungTam, NguoiDungInfor nguoiDung)
        {
            int idtt = bteTrungTam.Tag != null
                           ? ((DMTrungTamInfor) bteTrungTam.Tag).IdTrungTam
                           : 0;
            //if (idtt == 0 && (nguoiDung.QuanTri == 1 || nguoiDung.SupperUser == 1))
            if (idtt == 0 && nguoiDung.SupperUser == 1)
            {
                idtt = -1;
            }
            return idtt;
        }
        public int GetIdTrungTamBaoHanh(DevExpress.XtraEditors.ButtonEdit bteTrungTam, NguoiDungInfor nguoiDung)
        {
            int idtt = bteTrungTam.Tag != null
                           ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam
                           : 0;
            //if (idtt == 0 && (nguoiDung.QuanTri == 1 || nguoiDung.SupperUser == 1))
            if (idtt == 0 && (nguoiDung.SupperUser == 1 || nguoiDung.SaleAdmin == 1))
            {
                idtt = -1;
            }
            return idtt;
        }

        //0-linhvuc,1-nganh,2-loai,3-chung,4-nhom,5-model,6-sanpham,7-hang
        public void LoadAllNganhHang(DevExpress.XtraEditors.LookUpEdit lueNganhHang, NguoiDungInfor nguoiDung)
        {
            int idNND = (nguoiDung.SupperUser == 1 || nguoiDung.SaleAdmin == 1) ? -1 : nguoiDung.IdNhomNguoiDung;
            List<TimKiemItemInfor> liNganh = TimKiemItemDataProvider.Instance.GetAllItemsByType(idNND, 1, -1, -1);//type=1: nganh hang
            liNganh.Insert(0, new TimKiemItemInfor()
                                  {
                                      Id = -1,
                                      Ma = "",
                                      Ten = "Tất cả"
                                  });

            lueNganhHang.Properties.DataSource = null;
            if (liNganh.Count > 0)
            {
                lueNganhHang.Properties.Columns.Clear();
                lueNganhHang.Properties.Columns.Add(new LookUpColumnInfo("Ten", "Tên"));
                lueNganhHang.Properties.DataSource = liNganh;
                lueNganhHang.Properties.DisplayMember = "Ten";
                lueNganhHang.Properties.ValueMember = "Ma";
                lueNganhHang.EditValue = liNganh[0].Ma;
            }
        }

        public void LoadNganhHang(DevExpress.XtraEditors.LookUpEdit lueNganhHang, NguoiDungInfor nguoiDung, bool showAll)
        {
            int idNND = (nguoiDung.SupperUser == 1 || nguoiDung.SaleAdmin == 1) ? -1 : nguoiDung.IdNhomNguoiDung;
            List<TimKiemItemInfor> liNganh = TimKiemItemDataProvider.Instance.GetAllItemsByType(idNND, 1, -1, -1);//type=1: nganh hang
            if (showAll && nguoiDung.QuanTri == 1 || idNND == -1)
            {
                liNganh.Insert(0, new TimKiemItemInfor()
                {
                    Id = -1,
                    Ma = "",
                    Ten = "Tất cả"
                });
            }
            lueNganhHang.Properties.DataSource = null;
            if (liNganh.Count > 0)
            {
                lueNganhHang.Properties.Columns.Clear();
                lueNganhHang.Properties.Columns.Add(new LookUpColumnInfo("Ten", "Tên"));
                lueNganhHang.Properties.DataSource = liNganh;
                lueNganhHang.Properties.DisplayMember = "Ten";
                lueNganhHang.Properties.ValueMember = "Ma";
                lueNganhHang.EditValue = liNganh[0].Ma;
            }
        }
        public void LoadNganhHang(DevExpress.XtraEditors.LookUpEdit lueNganhHang)
        {
            List<TimKiemItemInfor> liNganh = TimKiemItemDataProvider.Instance.GetAllItemsByType(-1, 1, -1, -1);//type=1: nganh hang
            liNganh.Insert(0, new TimKiemItemInfor()
            {
                Id = -1,
                Ma = "",
                Ten = "Tất cả"
            });

            lueNganhHang.Properties.DataSource = null;
            if (liNganh.Count > 0)
            {
                lueNganhHang.Properties.Columns.Clear();
                lueNganhHang.Properties.Columns.Add(new LookUpColumnInfo("Ten", "Tên"));
                lueNganhHang.Properties.DataSource = liNganh;
                lueNganhHang.Properties.DisplayMember = "Ten";
                lueNganhHang.Properties.ValueMember = "Ma";
                lueNganhHang.EditValue = liNganh[0].Ma;
            }
        }

        public static bool IsEditChungTu()
        {
            NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                                           ? (NguoiDungInfor)Declare.USER_INFOR
                                                           : new NguoiDungInfor();
            if (nguoiDung.SupperUser == 1 || nguoiDung.SuaChungTu == 1)
                return true;
            return false;
        }

        public static ChungTuBanHangInfor LoadKhachHangDaMua(string soDienThoai, string cmnd, string masothue)
        {
            ChungTuBanHangInfor ct = null;
            if (String.IsNullOrEmpty(soDienThoai) && String.IsNullOrEmpty(cmnd) && String.IsNullOrEmpty(masothue))
            {
                frmBH_TimKhachMuaHang frm = new frmBH_TimKhachMuaHang();
                if (frm.ShowDialog() == DialogResult.OK)
                    ct = frm.ChungTu;
            }
            else
            {
                TimKiemChungTuFilterInfor filter = new TimKiemChungTuFilterInfor();
                filter.CMND = cmnd;
                filter.DienThoai = soDienThoai;
                filter.MaSoThue = masothue;
                filter.SoBatDau = 0;
                filter.SoKetThuc = 5;

                List<ChungTuBanHangInfor> liCTu = TimKiemKhachMuaHangDataProvider.Instance.Search(filter);
                if (liCTu.Count == 1)
                {
                    ct = liCTu[0];
                }
                else
                {
                    frmBH_TimKhachMuaHang frm = new frmBH_TimKhachMuaHang(liCTu, soDienThoai, cmnd, masothue);
                    if (frm.ShowDialog() == DialogResult.OK)
                        ct = frm.ChungTu;                    
                }
            }
            return ct;
        }

        public static void LoadDMTinhAutoComplet(List<DMTinhInfor> liTinh, ComboBox cboTinh)
        {
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            foreach (DMTinhInfor t in liTinh)
            {
                data.Add(t.TenTinh);
            }

            cboTinh.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboTinh.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTinh.AutoCompleteCustomSource = data;            
        }

        public static void LoadDMHuyenAutoComplet(List<DMHuyenInfor> liHuyen, ComboBox cboHuyen)
        {
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            foreach (DMHuyenInfor h in liHuyen)
            {
                data.Add(h.TenHuyen);
            }

            cboHuyen.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboHuyen.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboHuyen.AutoCompleteCustomSource = data;
        }

        //public static bool IsDuocTichLuyDiem(ChungTuBanHangChiTietInfor ctu)
        //{
        //    //if (ctu.ChinhSach != null && ctu.ChinhSach.DuocTichLuyDiem == 0)
        //    //    return false;
        //    if (ctu.CSachChietKhau != null && ctu.CSachChietKhau.DuocTichLuyDiem == 0)
        //        return false;
        //    //if (ctu.ListChinhSachDefault != null)
        //    //{
        //    //    foreach (BangGiaChinhSachInfor cs in ctu.ListChinhSachDefault)
        //    //    {
        //    //        if (cs.DuocTichLuyDiem == 0)
        //    //            return false;
        //    //    }
        //    //}

        //    return true;
        //}

        public string GetDiemThuong(string maSanPham, int idTrungTam, double donGia)
        {
            List<BangGiaChinhSachInfor> liChinhSach =
                ChinhSachDataProvider.Instance.GetAllChinhSachApDung(idTrungTam, -1, 0, maSanPham, -1);
            int min = int.MaxValue, max = 0;
            if (liChinhSach != null && liChinhSach.Count > 0)
            {
                foreach (BangGiaChinhSachInfor bgcs in liChinhSach)
                {
                    if (bgcs.TyLeDiemThuong <= 0) continue;
                    //diem thuong
                    int diemThuong = Common.IntValue(bgcs.TyLeDiemThuong * donGia / 100);
                    if (min > diemThuong) min = diemThuong;
                    if (max < diemThuong) max = diemThuong;
                }
            }
            string stDiemThuong = "";

            if (min == max && min > 0)
                stDiemThuong = String.Format("Điểm thưởng: {0} điểm", min);
            else if (min != max && min == 0)
                stDiemThuong = String.Format("Điểm thưởng: {0} điểm", max);
            else if (min != max && min > 0)
                stDiemThuong = String.Format("Điểm thưởng: [{0} => {1}] điểm", min, max);

            return stDiemThuong;
        }
        #endregion
    }
}
