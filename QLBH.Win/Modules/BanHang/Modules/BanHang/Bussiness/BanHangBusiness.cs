using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.TheThanhVien.Infors;
using QLBanHang.Modules.TheThanhVien.Providers;
using QLBH.Common;
using QLBH.Core.Business;
using QLBH.Core.Data;
using QLBH.Core.Exceptions;
using QLBH.Core.Infors;

namespace QLBanHang.Modules.BanHang.Bussiness
{
    public class BanHangBusiness 
    {
        /// <summary>
        /// Cac nghiệp vụ lập đơn hàng: chỉ ghi chứng từ, không ghi tồn kho
        /// </summary>
        public ChungTuBanHangInfor ChungTu;
        public List<ChungTuBanHangChiTietInfor> ListChiTietChungTu;
        public List<ChungTuThanhToanInfor> ListChungTuThanhToan;

        public BanHangBusiness()
        {
            ChungTu = new ChungTuBanHangInfor
            {
                LoaiChungTu = Common.IntValue(TransactionType.DON_HANG_TAI_SHOP),
                IdNhanVien = Declare.IdNhanVien,
                IdKho = Declare.IdKho
            };
        }
        public BanHangBusiness(int loaiChungTu, int idNhanVien, int idKho)
        {
            ChungTu = new ChungTuBanHangInfor
            {
                LoaiChungTu = loaiChungTu,
                IdNhanVien = idNhanVien,
                IdKho = idKho
            };
        }

        public BanHangBusiness(ChungTuBanHangInfor chungTuBanHangInfor)
        {
            ChungTu = BanHangDataProvider.Instance.GetChungTuBySoChungTu<ChungTuBanHangInfor>(chungTuBanHangInfor.SoChungTu) ??
                      chungTuBanHangInfor;

            ListChiTietChungTu = BanHangDataProvider.Instance.GetListChiTietChungTuByIdChungTu(ChungTu.IdChungTu);
            ListChungTuThanhToan = ThanhToanDataProvider.Instance.LoadAllThanhToanByCTu(ChungTu.IdChungTu);
        }
        public BanHangBusiness(ChungTuBanHangInfor ctu, double tienTraLaiThe, int soDiemAm, int idThe)
        {
            int Vat = 10 / 100;

            //chungtu
            ChungTu = new ChungTuBanHangInfor(ctu);
            ChungTu.IdChungTu = 0;
            ChungTu.LoaiChungTu = (int) TransactionType.DON_HANG_DAT_TRUOC;
            ChungTu.TrangThai = (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC;
            ChungTu.SoChungTu = "DT-" + ChungTu.SoChungTu;
            ChungTu.OrderType = Declare.OrderTypeBan;
            ChungTu.GhiChu = "Đơn hàng DT hoàn tiền điểm thưởng";
            ChungTu.TongTienHang = tienTraLaiThe / (1 + Vat);
            ChungTu.TongTienChietKhau = 0;
            ChungTu.TongTienSauChietKhau = tienTraLaiThe/(1 + Vat);
            ChungTu.TongTienVAT = tienTraLaiThe/(1 + Vat)*Vat;
            ChungTu.TongTienThanhToan = tienTraLaiThe;
            ChungTu.TienThanhToanThuc = 0;
            ChungTu.TienConNo = tienTraLaiThe;
            ChungTu.IdLyDoGiaoDich = -1;//danh dau don hang thu tien diem thuong am
            ChungTu.SoTienTichLuy = soDiemAm;//so diem truoc khi bu tien
            ChungTu.SoDiemBiTru = 0;
            ChungTu.SoTienQuyDoi = 0;
            ChungTu.IdTheThanhVien = idThe;
            ChungTu.SoDiemTichLuy = -soDiemAm;
            ChungTu.DaTichDiem = 1;
            ChungTu.IdTrungTamHachToan = ChungTu.IdTrungTam;

            //chungtu chitiet
            HeSoDoiDiemInfo heso = HeSoDoiDiemDataProvider.Instance.LoadHeSoDoiDiem();
            ChungTuBanHangChiTietInfor ct = new ChungTuBanHangChiTietInfor()
                                                {
                                                    IdSanPham = heso.IdSanPham,
                                                    MaSanPham = heso.MaHoanTien,
                                                    TenSanPham = heso.TenSanPham,
                                                    SoLuong = 1,
                                                    DonGiaCoVat = tienTraLaiThe,
                                                    DonGia = tienTraLaiThe / (1 + Vat),
                                                    TyleChietKhau = 0,
                                                    TienChietKhau = 0,
                                                    TienSauChietKhau = tienTraLaiThe / (1 + Vat),
                                                    TyleVAT = 10,
                                                    TienVAT = tienTraLaiThe / (1 + Vat) * Vat,
                                                    ThanhTien = tienTraLaiThe
                                                };

            ListChiTietChungTu = new List<ChungTuBanHangChiTietInfor>();
            ListChiTietChungTu.Add(ct);
            ListChungTuThanhToan = new List<ChungTuThanhToanInfor>();
        }
        #region save chung tu
        //private bool isOwnTran;
        //public void SaveChungTu()
        //{
        //    try
        //    {
        //        isOwnTran = false;
        //        if (!ConnectionUtil.Instance.IsInTransaction)
        //        {
        //            ConnectionUtil.Instance.BeginTransaction();
        //            isOwnTran = true;
        //        }
        //        SaveChungTuInstance();
        //        if (ConnectionUtil.Instance.IsInTransaction && isOwnTran)
        //            ConnectionUtil.Instance.CommitTransaction();
        //    }
        //    catch (Exception)
        //    {
        //        if (ConnectionUtil.Instance.IsInTransaction && isOwnTran)
        //            ConnectionUtil.Instance.RollbackTransaction();
        //        throw;
        //    }
        //}
        public void SaveChungTuHoanTien()
        {
            SaveChungTuHeader();
            SaveChungTuDetails();
        }
        public void SaveChungTu()
        {
            SaveChungTuHeader();
            SaveChungTuDetails();
            SaveChungTuThanhToan();
            SavePhieuXuatKho();
        }
        private void SaveChungTuHeader()
        {
            if (ChungTu.IdChungTu == 0)//them moi
            {
                ChungTu.IdChungTu = BanHangDataProvider.Instance.InsertChungTu(ChungTu);
            }                
            else
            {
                ChungTuBanHangInfor chungTuOrigin =
                    BanHangDataProvider.Instance.GetChungTuBySoChungTu<ChungTuBanHangInfor>(ChungTu.SoChungTu);
                
                if(chungTuOrigin.LockId == 1)
                {
                    if(ChungTu.LockAccount != chungTuOrigin.LockAccount ||
                        ChungTu.LockMachine != chungTuOrigin.LockMachine)
                    {
                        throw new ManagedException(
                            String.Format(
                                "Chứng từ đang bị lock bởi người dùng {0} tại máy {1}, không thể thực hiện giao dịch.",
                                chungTuOrigin.LockAccount, chungTuOrigin.LockMachine));
                    }

                    if(ChungTu.ProcessId != chungTuOrigin.ProcessId)
                    {
                        throw new ManagedException(
                            "Chứng từ đang bị lock bởi ứng dụng khác, không thể thực hiện giao dịch.");
                    }
                }

                BanHangDataProvider.Instance.UpdateChungTu(ChungTu);
            }
        }
        private void SavePhieuXuatKho()
        {
            List<ChungTuBanHangInfor> liPX =
                BanHangDataProvider.Instance.LoadAllPhieuXuatByIdCTuGoc(ChungTu.IdChungTu);
            if (liPX == null || liPX.Count == 0) return;

            foreach (ChungTuBanHangInfor px in liPX)
            {
                px.SoSeri = ChungTu.SoChungTu;
                px.IdTrungTam = ChungTu.IdTrungTam;
                px.QuyenSo = ChungTu.QuyenSo;
                px.SoSeri = ChungTu.SoSeri;
                px.KyHieu = ChungTu.KyHieu;
                px.SoPhieuDC = ChungTu.SoPhieuDC;
                px.IdDoiTuong = ChungTu.IdDoiTuong;
                px.CongTy = ChungTu.CongTy;
                px.HoTen = ChungTu.CongTy;
                px.DoTuoi = ChungTu.DoTuoi;
                px.GioiTinh = ChungTu.GioiTinh;
                px.DiaChi = ChungTu.DiaChi;
                px.DienThoai = ChungTu.DienThoai;
                px.MaSoThue = ChungTu.MaSoThue;

                px.TongTienHang = ChungTu.TongTienHang;
                px.TongTienChietKhau = ChungTu.TongTienChietKhau;
                px.TongTienSauChietKhau = ChungTu.TongTienSauChietKhau;
                px.TongTienVAT = ChungTu.TongTienVAT;
                px.TongTienThanhToan = ChungTu.TongTienThanhToan;
                px.IdTienTe = ChungTu.IdTienTe;
                px.TienThanhToanThuc = ChungTu.TongTienThanhToan;
                px.TienConNo = ChungTu.TienConNo;
                px.TongTienChu = ChungTu.TongTienChu;
                px.HinhThucTra = ChungTu.HinhThucTra;
                px.IdLoaiHdBanHang = ChungTu.IdLoaiHdBanHang;
                px.IdDuAn = ChungTu.IdDuAn;
                px.SoCMND = ChungTu.SoCMND;
                px.GiaoNhan = ChungTu.GiaoNhan;
                px.IdTruongCa = ChungTu.IdTruongCa;
                px.LoaiTheKhachHang = ChungTu.LoaiTheKhachHang;
                px.SoTienTichLuy = ChungTu.SoTienTichLuy;
                px.CaBanHang = ChungTu.CaBanHang;
                px.NgayHenGiaoHang = ChungTu.NgayHenGiaoHang;
                px.IdKhachLe = ChungTu.IdKhachLe;
                px.Email = ChungTu.Email;
                px.Website = ChungTu.Website;
                px.Draft = ChungTu.Draft;
                px.IdTinhHD = ChungTu.IdTinhHD;
                px.IdHuyenHD = ChungTu.IdHuyenHD;
                px.DiaChiHD = ChungTu.DiaChiHD;
                px.DiaChiHoaDon = ChungTu.DiaChiHoaDon;
                px.IdTinhGH = ChungTu.IdTinhGH;
                px.IdHuyenGH = ChungTu.IdHuyenGH;
                px.DiaChiGH = ChungTu.DiaChiGH;
                px.DiaChiGiaoHang = ChungTu.DiaChiGiaoHang;
                px.SoHDDaMua = ChungTu.SoHDDaMua;
                px.IdNgheNghiep = ChungTu.IdNgheNghiep;

                BanHangDataProvider.Instance.UpdateChungTu(px);
            }
        }
        private void SaveChungTuDetails()
        {
            List<ChungTuBanHangChiTietInfor> listOrigin =
                BanHangDataProvider.Instance.GetListChiTietChungTuByIdChungTu(ChungTu.IdChungTu);

            //xoa nhung cai cu
            foreach (ChungTuBanHangChiTietInfor originInfo in listOrigin)
            {
                if (!ListChiTietChungTu.Exists(delegate(ChungTuBanHangChiTietInfor match)
                                                   {
                                                       return match.IdChungTuChiTiet == originInfo.IdChungTuChiTiet;
                                                   }))
                {
                    BanHangDataProvider.Instance.DeleteChiTietChungTu(originInfo);
                }
            }

            //them hoac cap nhat cai moi
            foreach (ChungTuBanHangChiTietInfor newInfo in ListChiTietChungTu)
            {
                ChungTuBanHangChiTietInfor originInfo = listOrigin.Find(
                    delegate(ChungTuBanHangChiTietInfor match)
                        {
                            return match.IdChungTuChiTiet == newInfo.IdChungTuChiTiet;
                        });

                if (originInfo != null)
                {
                    if (!newInfo.IsOrigin)
                        BanHangDataProvider.Instance.UpdateChiTietChungTu(newInfo);
                }
                else
                {
                    newInfo.IdChungTu = ChungTu.IdChungTu;
                    newInfo.IdChungTuChiTiet = BanHangDataProvider.Instance.InsertChiTietChungTu(newInfo);
                }
            }
        }
        private void SaveChungTuThanhToan()
        {
            List<ChungTuThanhToanInfor> listOrigin =
                ThanhToanDataProvider.Instance.LoadAllThanhToanByCTu(ChungTu.IdChungTu);

            //xoa nhung cai cu
            foreach (ChungTuThanhToanInfor originInfo in listOrigin)
            {
                if (!ListChungTuThanhToan.Exists(delegate(ChungTuThanhToanInfor match)
                                                   {
                                                       return match.IdThanhToan == originInfo.IdThanhToan;
                                                   }))
                {
                    ThanhToanDataProvider.Instance.Delete(originInfo.IdThanhToan);
                }
            }
            //them hoac cap nhat cai moi
            foreach (ChungTuThanhToanInfor cttt in ListChungTuThanhToan)
            {
                ChungTuThanhToanInfor originInfo = listOrigin.Find(
                    delegate(ChungTuThanhToanInfor match)
                    {
                        return match.IdThanhToan == cttt.IdThanhToan;
                    });

                if (originInfo != null)
                {
                    ThanhToanDataProvider.Instance.Update(cttt);
                }
                else
                {
                    cttt.IdChungTu = ChungTu.IdChungTu;
                    cttt.IdThanhToan = ThanhToanDataProvider.Instance.Insert(cttt);
                }
            }
            ////Xoa thanh toan cu
            //BanHangDataProvider.Instance.DeleteChungTuThanhToanByIdChungTu(ChungTu.IdChungTu);
            ////Insert thanh toan moi
            //foreach (ChungTuThanhToanInfor cttt in ListChungTuThanhToan)
            //{
            //    cttt.IdChungTu = ChungTu.IdChungTu;
            //    BanHangDataProvider.Instance.InsertChungTuThanhToan(cttt);
            //}
        }
        #endregion

        #region delete chungtu
        private void DeleteChungTu()
        {
            if (ChungTu.LoaiChungTu == (int)TransactionType.DON_HANG_ONLINE)
            {
                if (ChungTu.TrangThai == (int)OrderStatus.TAO_DON_HANG_ONLINE)
                    BanHangDataProvider.Instance.DeleteChungTu(ChungTu.IdChungTu);
            }
            else if (ChungTu.LoaiChungTu == (int)TransactionType.DON_HANG_DAT_TRUOC)
            {
                if (ChungTu.TrangThai == (int)OrderStatus.TAO_DON_HANG_DAT_TRUOC)
                    BanHangDataProvider.Instance.DeleteChungTu(ChungTu.IdChungTu);
                
            }
            else if (ChungTu.LoaiChungTu == (int)TransactionType.DON_HANG_TAI_SHOP)
            {
                if (ChungTu.TrangThai == (int)OrderStatus.DON_HANG_BAN_TAI_SHOP)
                    BanHangDataProvider.Instance.DeleteChungTu(ChungTu.IdChungTu);                
            }
            
        }
        #endregion
    }
}
