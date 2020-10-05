using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using QLBH.Core.Data;
using QLBH.Common;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.DAO;

// <Remarks>
// Tạo BangGiaDataProvider
// Người tạo: Lê Mạnh Tuấn
// Ngày tạo : 24/07/2012
// Người sửa cuối:
// </remarks>

namespace QLBanHang.Modules.BanHang.Providers
{
    public class BaoCaoTongHopCongNoKhachHangDataProvider
    {
        private static BaoCaoTongHopCongNoKhachHangDataProvider instance;

        public static BaoCaoTongHopCongNoKhachHangDataProvider Instance
        {
            get { return instance ?? (instance = new BaoCaoTongHopCongNoKhachHangDataProvider()); }
        }
        public List<CongNoBanHangInfor> LoadCongNoKhachHang(int idKhachHang, int soBatDau, int soKetThuc)
        {
            return BaoCaoTongHopCongNoKhachHangDao.Instance.LoadCongNoKhachHang(idKhachHang, soBatDau, soKetThuc);
        }
        public int GetMaxValue()
        {
            return BaoCaoTongHopCongNoKhachHangDao.Instance.GetMaxValue();
        }
    }
    public class BaoCaoTongHopCongNoTrungTamDataProvider
    {
        private static BaoCaoTongHopCongNoTrungTamDataProvider instance;

        public static BaoCaoTongHopCongNoTrungTamDataProvider Instance
        {
            get { return instance ?? (instance = new BaoCaoTongHopCongNoTrungTamDataProvider()); }
        }
        public List<CongNoBanHangInfor> LoadCongNoTrungTam(int idTrungTam, int idKhachHang, int soBatDau, int soKetThuc)
        {
            return BaoCaoTongHopCongNoTrungTamDao.Instance.LoadCongNoTrungTam(idTrungTam, idKhachHang, soBatDau, soKetThuc);
        }

        public int GetMaxValue()
        {
            return BaoCaoTongHopCongNoTrungTamDao.Instance.GetMaxValue();
        }
    }

    public class ThanhToanDataProvider
    {
        private static ThanhToanDataProvider instance;
        public static ThanhToanDataProvider Instance
        {
            get { return instance ?? (instance = new ThanhToanDataProvider()); }
        }

        public List<ChungTuThanhToanInfor> LoadAllThanhToan()
        {
            return ThanhToanDAO.Instance.LoadAllThanhToan();
        }
        public List<ChungTuThanhToanInfor> LoadAllThanhToanByCTu(int idChungTu)
        {
            return ThanhToanDAO.Instance.LoadAllThanhToanByCTu(idChungTu);
        }
        public ChungTuThanhToanInfor LoadAllThanhToanById(int idThanhToan)
        {
            return ThanhToanDAO.Instance.LoadThanhToanById(idThanhToan);
        }

        public void Update(ChungTuThanhToanInfor thanhToan)
        {
            ThanhToanDAO.Instance.Update(thanhToan);
        }

        public int Insert(ChungTuThanhToanInfor thanhToan)
        {
            return ThanhToanDAO.Instance.Insert(thanhToan);
        }

        public void Delete(int idThanhToan)
        {
            ThanhToanDAO.Instance.Delete(idThanhToan);
        }

        public void DeleteAll(int idChungTu)
        {
            ThanhToanDAO.Instance.DeleteAll(idChungTu);
        }

        public ChungTuThanhToanPairInfor ConvertFull2Pair(ChungTuThanhToanInfor full)
        {
            ChungTuThanhToanPairInfor pair = new ChungTuThanhToanPairInfor();
            pair.IdHinhThucThanhToan = full.IdHinhThucThanhToan;
            pair.HinhThucThanhToan = full.HinhThucThanhToan;
            pair.SoTienThanhToan = full.SoTienThanhToan;
            pair.ThoiHanThanhToan = full.ThoiHanThanhToan;
            pair.IdThoiHanThanhToan = full.IdThoiHanThanhToan;
            pair.SoTaiKhoan = full.SoTaiKhoan;
            pair.NganHangThanhToan = full.NganHangThanhToan;
            pair.IdNganHangThanhToan = full.IdNganHangThanhToan;
            pair.MaThe = full.MaThe;
            pair.DuoiThe = full.DuoiThe;
            pair.NganHangPhatHanhThe = full.NganHangPhatHanhThe;
            pair.IdNganHangPhatHanhThe = full.IdNganHangPhatHanhThe;
            pair.NgayLap = full.NgayLap;
            pair.LoaiPhieu = full.LoaiPhieu;
            pair.LoaiGiaoDich = full.LoaiGiaoDich;

            return pair;
        }

        public List<ChungTuThanhToanPairInfor> ConvertListFull2Pair(List<ChungTuThanhToanInfor> full)
        {
            List<ChungTuThanhToanPairInfor>  pair = new List<ChungTuThanhToanPairInfor>();
            foreach (ChungTuThanhToanInfor tt in full)
            {
                ChungTuThanhToanPairInfor tmp = new ChungTuThanhToanPairInfor();
                tmp.IdHinhThucThanhToan = tt.IdHinhThucThanhToan;
                tmp.HinhThucThanhToan = tt.HinhThucThanhToan;
                tmp.SoTienThanhToan = tt.SoTienThanhToan;
                tmp.ThoiHanThanhToan = tt.ThoiHanThanhToan;
                tmp.IdThoiHanThanhToan = tt.IdThoiHanThanhToan;
                tmp.SoTaiKhoan = tt.SoTaiKhoan;
                tmp.NganHangThanhToan = tt.NganHangThanhToan;
                tmp.IdNganHangThanhToan = tt.IdNganHangThanhToan;
                tmp.MaThe = tt.MaThe;
                tmp.DuoiThe = tt.DuoiThe;
                tmp.NganHangPhatHanhThe = tt.NganHangPhatHanhThe;
                tmp.IdNganHangPhatHanhThe = tt.IdNganHangPhatHanhThe;
                tmp.NgayLap = tt.NgayLap;
                tmp.LoaiPhieu = tt.LoaiPhieu;
                tmp.LoaiGiaoDich = tt.LoaiGiaoDich; 
                pair.Add(tmp);
            }
            return pair;
        }


        public ChungTuThanhToanInfor ConvertPair2Full(ChungTuThanhToanPairInfor pair)
        {
            ChungTuThanhToanInfor full = new ChungTuThanhToanInfor();
            full.IdHinhThucThanhToan = pair.IdHinhThucThanhToan;
            full.HinhThucThanhToan = pair.HinhThucThanhToan;
            full.SoTienThanhToan = pair.SoTienThanhToan;
            full.ThoiHanThanhToan = pair.ThoiHanThanhToan;
            full.IdThoiHanThanhToan = pair.IdThoiHanThanhToan;
            full.SoTaiKhoan = pair.SoTaiKhoan;
            full.NganHangThanhToan = pair.NganHangThanhToan;
            full.IdNganHangThanhToan = pair.IdNganHangThanhToan;
            full.MaThe = pair.MaThe;
            full.DuoiThe = pair.DuoiThe;
            full.NganHangPhatHanhThe = pair.NganHangPhatHanhThe;
            full.IdNganHangPhatHanhThe = pair.IdNganHangPhatHanhThe;
            full.NgayLap = pair.NgayLap;
            full.LoaiPhieu = pair.LoaiPhieu;
            full.LoaiGiaoDich = pair.LoaiGiaoDich;

            return full;
        }

        public List<ChungTuThanhToanInfor> ConvertListPair2Full(List<ChungTuThanhToanPairInfor> pair)
        {
            List<ChungTuThanhToanInfor> full = new List<ChungTuThanhToanInfor>();
            foreach (ChungTuThanhToanPairInfor tt in pair)
            {
                ChungTuThanhToanInfor tmp = new ChungTuThanhToanInfor();
                tmp.IdHinhThucThanhToan = tt.IdHinhThucThanhToan;
                tmp.HinhThucThanhToan = tt.HinhThucThanhToan;
                tmp.SoTienThanhToan = tt.SoTienThanhToan;
                tmp.ThoiHanThanhToan = tt.ThoiHanThanhToan;
                tmp.IdThoiHanThanhToan = tt.IdThoiHanThanhToan;
                tmp.SoTaiKhoan = tt.SoTaiKhoan;
                tmp.NganHangThanhToan = tt.NganHangThanhToan;
                tmp.IdNganHangThanhToan = tt.IdNganHangThanhToan;
                tmp.MaThe = tt.MaThe;
                tmp.DuoiThe = tt.DuoiThe;
                tmp.NganHangPhatHanhThe = tt.NganHangPhatHanhThe;
                tmp.IdNganHangPhatHanhThe = tt.IdNganHangPhatHanhThe;
                tmp.NgayLap = tt.NgayLap;
                tmp.LoaiPhieu = tt.LoaiPhieu;
                tmp.LoaiGiaoDich = tt.LoaiGiaoDich;

                full.Add(tmp);
            }
            return full;
        }

        public List<ChungTuThanhToanInfor> CombineThanhToan(List<ChungTuThanhToanInfor> liThanhToan)
        {
            List<ChungTuThanhToanInfor> liThanhToanGop = new List<ChungTuThanhToanInfor>();
            try
            {
                foreach (ChungTuThanhToanInfor tt in liThanhToan)
                {
                    ChungTuThanhToanInfor ttoan = liThanhToanGop.Find(delegate(ChungTuThanhToanInfor t)
                                                                          {
                                                                              return tt.IdHinhThucThanhToan ==
                                                                                     t.IdHinhThucThanhToan &&
                                                                                     tt.IdTienTe == t.IdTienTe &&
                                                                                     tt.IdNganHangThanhToan ==
                                                                                     t.IdNganHangThanhToan &&
                                                                                     tt.IdNganHangPhatHanhThe ==
                                                                                     t.IdNganHangPhatHanhThe &&
                                                                                     (tt.SoTaiKhoan != null &&
                                                                                      tt.SoTaiKhoan.Equals(t.SoTaiKhoan) ||
                                                                                      tt.SoTaiKhoan == null) &&
                                                                                     (tt.MaThe != null &&
                                                                                      tt.MaThe.Equals(t.MaThe) ||
                                                                                      tt.MaThe == null) &&
                                                                                     (tt.DuoiThe != null &&
                                                                                      tt.DuoiThe.Equals(t.DuoiThe) ||
                                                                                      tt.DuoiThe == null);
                                                                          });
                    if (ttoan == null)
                        liThanhToanGop.Add(tt);
                    else
                    {
                        ttoan.SoTienThanhToan += tt.SoTienThanhToan;
                        ttoan.SoTienChu = Common.ReadNumner_(Common.Double2Str(ttoan.SoTienThanhToan));
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
            }

            return liThanhToanGop;
        }

        public bool ExistSoPhieuThanhToan(string soPhieu)
        {
            return ThanhToanDAO.Instance.ExistSoPhieuThanhToan(soPhieu);
        }
    }
}
