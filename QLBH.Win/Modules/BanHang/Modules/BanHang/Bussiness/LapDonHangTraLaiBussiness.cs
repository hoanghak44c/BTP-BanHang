using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBH.Common;
using QLBH.Common.Providers;
using QLBH.Core.Business;

namespace QLBanHang.Modules.BanHang.Bussiness
{
    public class LapDonHangTraLaiBussiness : ChungTuNhapKeToanBusinessBase<ChungTuBanHangInfor, ChungTuBanHangChiTietInfor>
    {
        /// <summary>
        /// Các chi tiết thanh toan của chứng từ
        /// </summary>
        public List<ChungTuThanhToanInfor> ListChungTuThanhToan;

        public LapDonHangTraLaiBussiness()
        {
            ChungTu = new ChungTuBanHangInfor
            {
                LoaiChungTu = Common.IntValue(TransactionType.TRA_LAI_DON_HANG_BAN),
                IdNhanVien = Declare.IdNhanVien,
                IdKho = Declare.IdKho
            };
        }

        public LapDonHangTraLaiBussiness(int loaiChungTu, int idNhanVien, int idKho)
        {
            ChungTu = new ChungTuBanHangInfor
            {
                LoaiChungTu = loaiChungTu,
                IdNhanVien = idNhanVien,
                IdKho = idKho
            };
        }
        public LapDonHangTraLaiBussiness(ChungTuBanHangInfor ChungTuBanHangInfor)
            : base(ChungTuBanHangInfor)
        {
            //if (ChungTuBanHangInfor.LoaiChungTu != Common.IntValue(TransactionType.TRA_LAI_DON_HANG_BAN) )
            //{
            //    throw new Exception("Không phải loại chứng từ trả lại hàng bán");
            //}
            ListChungTuThanhToan = ThanhToanDataProvider.Instance.LoadAllThanhToanByCTu(ChungTuInfo.IdChungTu);
        }
        public LapDonHangTraLaiBussiness(ChungTuBanHangInfor chungTuInfo, string soChungTuGoc, string taiKhoanQuy, int idTrungTamThu, int idNhanVien, int idThuNgan, double soTienCN)
        {
            ChungTu = chungTuInfo;
            ListChiTietChungTu = BanHangDataProvider.Instance.GetListChiTietChungTuByIdChungTu(ChungTu.IdChungTu);
            foreach (ChungTuBanHangChiTietInfor ct in ListChiTietChungTu)
            {
                ct.IdChungTu = 0;
            }
            //cap nhat chung tu
            ChungTu.IdChungTu = 0;
            ChungTu.LoaiChungTu = (int) TransactionType.TRA_LAI_DON_HANG_BAN;
            ChungTu.TrangThai = (int)OrderStatus.TRA_LAI_DON_HANG_DAT_TRUOC;
            ChungTu.IdLyDoGiaoDich = 0;
            ChungTu.OrderType = Declare.OrderTypeTraLai;
            ChungTu.GhiChu = "Đổi điểm công nợ để đối trừ đơn hàng DT hoàn tiền điểm thưởng";
            ChungTu.SoChungTu = "TL-" + chungTuInfo.SoChungTu;
            ChungTu.SoChungTuGoc = soChungTuGoc;
            ChungTu.NgayHenGiaoHang = CommonProvider.Instance.GetSysDate();
            ChungTu.NgayGiaoHang = ChungTu.NgayHenGiaoHang;

            ChungTu.IdNhanVien = idNhanVien;
            ChungTu.IdTrungTamHachToan = idTrungTamThu;

            ChungTu.TongTienHang = chungTuInfo.TongTienThanhToan;
            ChungTu.TongTienChietKhau = 0;
            ChungTu.TongTienSauChietKhau = chungTuInfo.TongTienHang;
            ChungTu.TongTienVAT = 0;
            ChungTu.TongTienThanhToan = chungTuInfo.TienThanhToanThuc;
            ChungTu.TienThanhToanThuc = soTienCN;
            ChungTu.TienConNo = Common.DoubleValue(ChungTu.TongTienThanhToan - soTienCN);
            ChungTu.SoTienTichLuy = 0;//so diem truoc khi bu tien
            ChungTu.SoDiemBiTru = 0;
            ChungTu.SoTienQuyDoi = 0;
            ChungTu.IdTheThanhVien = 0;
            ChungTu.SoDiemTichLuy = 0;
            ChungTu.DaTichDiem = 0;

            //tao phieu chi
            ListChungTuThanhToan = new List<ChungTuThanhToanInfor>();
            ChungTuThanhToanInfor ThanhToan = new ChungTuThanhToanInfor();
            ThanhToan.SoPhieu = "PC-" + ChungTu.SoChungTu;
            ThanhToan.IdHinhThucThanhToan = 9;//Tien mat
            ThanhToan.IdThoiHanThanhToan = 0;
            ThanhToan.SoTienThanhToan = Common.DoubleValue(soTienCN);
            ThanhToan.NgayLap = ChungTu.NgayHenGiaoHang;
            ThanhToan.IdThuNgan = idThuNgan;
            ThanhToan.NoiDungThanhToan = "Phiếu chi đổi điểm lấy công nợ";
            ThanhToan.TaiKhoanQuy = taiKhoanQuy;
            ThanhToan.IdTrungTamThu = idTrungTamThu;
            ThanhToan.LoaiPhieu = (int)LoaiPhieuThanhToan.PHIEU_CHI;
            ThanhToan.LoaiThanhToan = -1;
            ThanhToan.LoaiGiaoDich = (int)LoaiGiaoDichThanhToan.GIAODICH_BANHANG;
            ThanhToan.SoChungTuGoc = ChungTu.SoChungTu;

            ListChungTuThanhToan.Add(ThanhToan);
        }


        protected override void CreateBusinessProvider()
        {
            BusinessKeToanKhoProvider = BanHangDataProvider.Instance;
        }

        protected override void SaveChungTuInstance()
        {
            //Cap nhat chung tu
            base.SaveChungTuInstance();
            //Cap nhat thanh toan
            SaveChungTuThanhToan();
        }

        public void SaveDonHangTraLai()
        {
            SaveChungTuHeader();
            SaveChungTuDetails();
            SaveChungTuThanhToan();
        }
        private void SaveChungTuHeader()
        {
            if (ChungTu.IdChungTu == 0)//them moi
            {
                ChungTu.IdChungTu = BanHangDataProvider.Instance.InsertChungTu(ChungTu);
            }
            else
            {
                BanHangDataProvider.Instance.UpdateChungTu(ChungTu);
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
        }
    }
}
