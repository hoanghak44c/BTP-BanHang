using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.DongBoERP;
using QLBH.Common;
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    public class DongBoGiaWebsite
    {
        private int idTrungTam;
        private DateTime ngayLap;
        private List<BangGiaBanChiTietBCInfor> liBGiaCTiet;
        private string Error = "";
        private string lstMaLoi = "";
        private int CountErr = 0;

        public DongBoGiaWebsite()
        {
            
        }
        public DongBoGiaWebsite(int idTrungTam, DateTime ngayLap, List<BangGiaBanChiTietBCInfor> liBGiaCTiet)
        {
            this.idTrungTam = idTrungTam;
            this.ngayLap = ngayLap;
            this.liBGiaCTiet = liBGiaCTiet;
        }

        public DongBoGiaWebsite(DateTime ngayLap, List<BangGiaBanChiTietBCInfor> liBGiaCTiet)
        {
            this.idTrungTam = idTrungTam;
            this.ngayLap = ngayLap;
            this.liBGiaCTiet = liBGiaCTiet;
        }

        public void BangGiaSync()
        {
            try
            {
                if (liBGiaCTiet.Count > 0)
                {
                    frmProgress.Instance.Description = "Đang đẩy dữ liệu bảng giá POS lên website ....";
                    frmProgress.Instance.MaxValue = liBGiaCTiet.Count;
                    frmProgress.Instance.Value = 0;
                    frmProgress.Instance.DoWork(SyncGia2Website);
                }
            }
            catch (Exception e)
            {
                Debug.Write(e.ToString());
            }
            string msg = CountErr == 0
                             ? String.Format("Đã đẩy thành công {0} mã hàng lên website!", liBGiaCTiet.Count)
                             : String.Format("Đã đẩy xong {0} mã hàng lên website. Trong đó có {1} mã thất bại!",
                                             liBGiaCTiet.Count,
                                             CountErr);
            MessageBox.Show(msg);
            if (!String.IsNullOrEmpty(lstMaLoi))
                frmMsgBox.Instance.ShowMessage("Danh sách mã lỗi:\r\n" + lstMaLoi);
            if (!String.IsNullOrEmpty(Error))
                frmMsgBox.Instance.ShowMessage(Error);
        }

        private void SyncGia2Website()
        {
            Error = "";
            lstMaLoi = "";
            CountErr = 0;
            string maSanPham = "";
            string giaWebsite = "";
            string giaOnline = "";
            string giaNiemYet = "";
            string khuyenMai = "";
            string khuyenMaiOnline = "";
            string tonKho = "";
            try
            {
                foreach (BangGiaBanChiTietBCInfor bgct in liBGiaCTiet)
                {
                    //khong dong bo gia cac truong hop sau
                    if (bgct.HangKhuyenMai == 1 || //hang khuyen mai
                        bgct.IdTrungTam == 1) //trung tam bao hanh
                    {
                        frmProgress.Instance.Value += 1;
                        continue;
                    }

                    maSanPham = bgct.MaSanPham;
                    giaWebsite = bgct.GiaWebSite.ToString();
                    giaOnline = bgct.DonGiaCoVAT.ToString();
                    giaNiemYet = bgct.GiaNiemYet.ToString();

                    khuyenMai = GetKhuyenMai(maSanPham, bgct.IdSanPham, bgct.DonGiaCoVAT);
                    khuyenMaiOnline = khuyenMai;// GetKhuyenMaiOnline(bgct.MaSanPham);
                    tonKho = bgct.TonKho.ToString();
                    try
                    {
                        if (!BusinessSynchronize.Instance.CostSync(maSanPham, giaWebsite, giaOnline, giaNiemYet, tonKho, khuyenMai, khuyenMaiOnline))
                        {
                            CountErr++;
                            lstMaLoi = lstMaLoi +
                                    String.Format(
                                        "{6}. Mã SP[{0}] - giá website[{1}] - giá online[{2}] -  giá niêm yết[{7}] -  KM[{3}] -  KM Online[{4}] - Tonkho[{5}]\r\n",
                                        maSanPham, giaWebsite, giaOnline, khuyenMai, khuyenMaiOnline, tonKho, CountErr, giaNiemYet);
                        }

                    }
                    catch (Exception e)
                    {
                        Error = Error +
                                String.Format(
                                    "Lỗi thao tác: Mã SP[{0}] - giá website[{1}] - giá online[{2}] -  giá niêm yết[{7}] -  KM[{3}] -  KM Online[{4}] - Tonkho[{5}]:\r\n{6}\r\n",
                                    maSanPham, giaWebsite, giaOnline, khuyenMai, khuyenMaiOnline, tonKho, e.ToString(), giaNiemYet);                        
                    }
                    frmProgress.Instance.Value += 1;
                }
                frmProgress.Instance.IsCompleted = true;
                frmProgress.Instance.Description = String.Format("Đã đẩy xong {0} mã hàng lên website.", frmProgress.Instance.Value);
                frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            }
            catch (Exception ex)
            {
                frmProgress.Instance.Description = "Đẩy dữ liệu thất bại ....";
                frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
                frmProgress.Instance.IsCompleted = true;
                Error = Error +
                        String.Format(
                            "Lỗi thao tác: Mã SP[{0}] - giá website[{1}] - giá online[{2}] -  giá niêm yết[{7}] -  KM[{3}] -  KM Online[{4}] - Tonkho[{5}]:\r\n{6}\r\n",
                            maSanPham, giaWebsite, giaOnline, khuyenMai, khuyenMaiOnline, tonKho, ex.ToString(), giaNiemYet);
                Debug.Print(ex.ToString());
            }
        }

        private string GetKhuyenMai(string maSanPham, int idSanPham, double donGia)
        {
            if (ngayLap == DateTime.MinValue) return "";

            List<BangGiaChinhSachInfor> liChinhSach =
                ChinhSachDataProvider.Instance.GetAllChinhSachApDung(0, -1, 0, maSanPham, -1);
            List<KhuyenMaiWeb> lstKhuyenMai = new List<KhuyenMaiWeb>();
            List<DMTrungTamPairInfor> liTTNoWeb = DMTrungTamDataProvider.GetTrungTamNoWeb();
            List<int> lstDiemThuong = new List<int>();
            if (liChinhSach != null && liChinhSach.Count > 0)
            {
                foreach (BangGiaChinhSachInfor bgcs in liChinhSach)
                {
                    string lstMatHangKhongAD = String.Format(",{0},", bgcs.MatHangKhongApDung);//khong nam trong danh sach ko duoc ap dung
                    if (lstMatHangKhongAD.Contains(String.Format(",{0},", idSanPham)))
                        continue;
                    
                    KhuyenMaiWeb kmWeb = new KhuyenMaiWeb();
                    kmWeb.ListKMaiChiTiet = new List<string>();

                    bgcs.ListBangGiaADDKMua = KhuyenMaiDataProvider.Instance.GetBangGiaADDKMuaInforsById(bgcs.IdDKMua);
                    foreach (BangGiaADDKMuaInfor dkm in bgcs.ListBangGiaADDKMua)
                    {
                        if (String.IsNullOrEmpty(dkm.KhuyenMaiWeb))
                        {
                            List<BangGiaADKhuyenMaiInfor> lstKM = KhuyenMaiDataProvider.Instance.GetAllBangGiaKhuyenMaiADInfors(dkm.IdDKMua);
                            for (int i = 0; i < lstKM.Count; i++)
                            {
                                string km = "";
                                lstKM[i].ListKhuyenMaiChiTiet = KhuyenMaiDataProvider.Instance.GetAllKhuyenMaiWebCTietInfors(lstKM[i].IdKhuyenMai);
                                foreach (BangGiaADKhuyenMaiChiTietInfor kmct in lstKM[i].ListKhuyenMaiChiTiet)
                                {
                                    string ghichu = kmct.HetTonDungKM == 1 ? " (<b><i>khuyến mại đến khi hết hàng</i></b>)" : "";
                                    km += String.Format("<li>{0}, số lượng {1}{2}</li>", kmct.TenHangKM.Replace("\"",""), kmct.SoLuong, ghichu);                                    
                                }
                                if (!String.IsNullOrEmpty(km))
                                    kmWeb.ListKMaiChiTiet.Add(km);
                            }                            
                        }
                        else
                        {
                            string[] kms = dkm.KhuyenMaiWeb.Split("\r\n".ToCharArray());
                            string strkm = "";
                            for (int k = 0; k < kms.Length; k++)
                                strkm += String.IsNullOrEmpty(kms[k].Trim())
                                             ? String.Empty
                                             : String.Format("<li>{0}</li>", kms[k].Trim());
                            kmWeb.ListKMaiChiTiet.Add(strkm);
                        }
                    }
                    if (kmWeb.ListKMaiChiTiet.Count > 0)//neu co khuyen mai thi them vao danh sach
                    {
                        foreach (DMTrungTamPairInfor tt in liTTNoWeb)//loai bo cac trung tam ko dua len web
                        {
                            if (!String.IsNullOrEmpty(bgcs.SieuThiAD) && bgcs.SieuThiAD.Contains(tt.TenTrungTam))
                            {
                                bgcs.SieuThiAD = bgcs.SieuThiAD.Replace(tt.TenTrungTam + ";", "");
                                bgcs.SieuThiAD = bgcs.SieuThiAD.Replace(tt.TenTrungTam, "");
                            }
                        }
                        string sthi = bgcs.LoaiDoiTuong == 1
                                          ? "chỉ áp dụng Online"
                                          : (String.IsNullOrEmpty(bgcs.SieuThiAD) || bgcs.SieuThiAD.Trim().ToLower().Contains("tất cả")
                                                 ? "tại tất cả siêu thị Trần Anh"
                                                 : String.Format("tại siêu thị {0}", bgcs.SieuThiAD));
                        kmWeb.KhuyenMai = String.Format("(áp dụng từ {0} đến {1}), {2}",
                                                   Common.Date2String(bgcs.NgayHieuLuc),
                                                   Common.Date2String(bgcs.HanHieuLuc),
                                                   sthi);
                        lstKhuyenMai.Add(kmWeb);
                    }
                    //diem thuong
                    int diemThuong = Common.IntValue(bgcs.TyLeDiemThuong*donGia/100);
                    lstDiemThuong.Add(diemThuong);
                }
            }
            return GetKhuyenMaiInfor(lstKhuyenMai, lstDiemThuong);
        }
        
        /// <summary>
        /// Get thông tin km có dạng: [Khuyến mại {0}:<br/>{1}<br/>(áp dụng từ {2} đến {3}), {4}]"
        /// </summary>
        /// <param name="lstKhuyenMai"></param>
        /// <returns></returns>
        private string GetKhuyenMaiInfor(List<KhuyenMaiWeb> lstKhuyenMai, List<int> lstDiemThuong)
        {
            string khuyenMaiWeb = "";
            string luachonWeb = "";
            //if (lstKhuyenMai.Count > 1)
            //    khuyenMaiWeb = "Quý khách được chọn một trong các khuyến mại sau:<br/>";
            for (int i = 0; i < lstKhuyenMai.Count; i++)
            {
                //get km info
                if (lstKhuyenMai.Count > 1)
                {
                    khuyenMaiWeb = (i==0 ? khuyenMaiWeb : khuyenMaiWeb + "hoặc&nbsp;") +
                                   String.Format("<b>Khuyến mại {0}</b>", i + 1);
                }
                else
                    khuyenMaiWeb = "<b>Khuyến mại</b>";

                //tinh diem thuong
                khuyenMaiWeb += lstDiemThuong[i] == 0 ? ":" : String.Format(" (Điểm thưởng {0} điểm):", lstDiemThuong[i]);

                luachonWeb = "";
                //get km chi tiet
                for (int j = 0; j < lstKhuyenMai[i].ListKMaiChiTiet.Count; j++)
                {
                    if (lstKhuyenMai[i].ListKMaiChiTiet.Count > 1)
                    {
                        luachonWeb += String.Format("<i>Lựa chọn {0}:</i>", j + 1);
                    }
                    luachonWeb = luachonWeb + lstKhuyenMai[i].ListKMaiChiTiet[j];
                }
                khuyenMaiWeb += "<div style='margin-left:20px'>" +
                                (String.IsNullOrEmpty(lstKhuyenMai[i].KhuyenMai)
                                     ? luachonWeb
                                     : luachonWeb + lstKhuyenMai[i].KhuyenMai) + "</div>";
            }
            return khuyenMaiWeb;
        }

        /// <summary>
        /// Tự động đẩy giá, khuyến mại sang website
        /// </summary>
        /// <returns></returns>
        public void AutoSync()
        {
            Error = "";
            lstMaLoi = "";
            CountErr = 0;
            string maSanPham = "";
            string giaWebsite = "";
            string giaOnline = "";
            string giaNiemYet = "";
            string khuyenMai = "";
            string khuyenMaiOnline = "";
            string tonKho = "";
            try
            {
                foreach (BangGiaBanChiTietBCInfor bgct in liBGiaCTiet)
                {
                    //khong dong bo gia cac truong hop sau
                    if (bgct.HangKhuyenMai == 1 || //hang khuyen mai
                        bgct.IdTrungTam == 1) //trung tam bao hanh
                    {
                        continue;
                    }

                    maSanPham = bgct.MaSanPham;
                    giaWebsite = bgct.GiaWebSite.ToString();
                    giaOnline = bgct.DonGiaCoVAT.ToString();
                    giaNiemYet = bgct.GiaNiemYet.ToString();

                    khuyenMai = GetKhuyenMai(maSanPham, bgct.IdSanPham, bgct.DonGiaCoVAT);
                    khuyenMaiOnline = khuyenMai;// GetKhuyenMaiOnline(bgct.MaSanPham);
                    tonKho = bgct.TonKho.ToString();
                    try
                    {
                        if (!BusinessSynchronize.Instance.CostSync(maSanPham, giaWebsite, giaOnline, giaNiemYet, tonKho, khuyenMai, khuyenMaiOnline))
                        {
                            CountErr++;
                            lstMaLoi = lstMaLoi +
                                    String.Format(
                                        "{6}. Mã SP[{0}] - giá website[{1}] - giá online[{2}] -  giá niêm yết[{7}] -  KM[{3}] -  KM Online[{4}] - Tonkho[{5}]\r\n",
                                        maSanPham, giaWebsite, giaOnline, khuyenMai, khuyenMaiOnline, tonKho, CountErr, giaNiemYet);
                        
                        }

                        //cap nhat trang thai day
                        BangGiaDataProvider.Instance.UpdateTrangThaiDayWeb(maSanPham, 1);//da day web
                    }
                    catch (Exception e)
                    {
                        Error = Error +
                                String.Format(
                                    "Lỗi thao tác: Mã SP[{0}] - giá website[{1}] - giá online[{2}] -  giá niêm yết[{7}] -  KM[{3}] -  KM Online[{4}] - Tonkho[{5}]:\r\n{6}\r\n",
                                    maSanPham, giaWebsite, giaOnline, khuyenMai, khuyenMaiOnline, tonKho, e.ToString(), giaNiemYet);
                    }
                }
            }
            catch (Exception ex)
            {
                Error = Error +
                        String.Format(
                            "Lỗi thao tác: Mã SP[{0}] - giá website[{1}] - giá online[{2}] -  giá niêm yết[{7}] -  KM[{3}] -  KM Online[{4}] - Tonkho[{5}]:\r\n{6}\r\n",
                            maSanPham, giaWebsite, giaOnline, khuyenMai, khuyenMaiOnline, tonKho, ex.ToString(), giaNiemYet);
            }
        }
    }

    public class MsgTest
    {
        public string Infors { get; set; }
        public string Result { get; set; }
        public int Ok { get; set; }
        public int Fail { get; set; }
    }
    public class KhuyenMaiWeb
    {
        public string KhuyenMai { get; set; }
        public List<string> ListKMaiChiTiet { get; set; }
    }
}

