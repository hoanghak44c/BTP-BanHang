using System;
using System.Collections.Generic;
using System.Text;
using QLBH.Core.Infors;

// Người tạo: Lê Mạnh Tuấn
// Ngày tạo :
// Ngày sửa cuối:

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class ChungTuBanHangChiTietHangHoaInfor : ChungTuChiTietHangHoaBaseInfo
    {
        public ChungTuBanHangChiTietHangHoaInfor()
        {

        }
        public ChungTuBanHangChiTietHangHoaInfor(ChungTuBanHangChiTietHangHoaInfor ct)
        {
            this.IdChungTuChiTiet = ct.IdChungTuChiTiet;
            this.IdChiTietHangHoa = ct.IdChiTietHangHoa;
            this.IdChiTietHangHoaGoc = ct.IdChiTietHangHoaGoc;
            this.MaVach = ct.MaVach;
            this.IdSanPham = ct.IdSanPham;
            this.MaSanPham = ct.MaSanPham;
            this.TenSanPham = ct.TenSanPham;
            this.DonViTinh = ct.DonViTinh;
            this.SoLuong = ct.SoLuong;
            this.TrungMaVach = ct.TrungMaVach;
            this.TienChietKhau = ct.TienChietKhau;
            this.TienVAT = ct.TienVAT;
            this.ThuongNong = ct.ThuongNong;
            this.GhiChu = ct.GhiChu;
            this.LoaiHangHoa = ct.LoaiHangHoa;
            this.IdSanPhamBan = ct.IdSanPhamBan;
            this.LoaiHangKem = ct.LoaiHangKem;
            this.MaVachMark = ct.MaVachMark;
        }
        private double _tienChietKhau;
        public double TienChietKhau
        {
            get { return _tienChietKhau; }
            set
            {
                if (_tienChietKhau != value)
                {
                    NotifyChange();
                }
                _tienChietKhau = value;
            }
        }

        private double _tienVAT;
        public double TienVAT
        {
            get { return _tienVAT; }
            set
            {
                if (_tienVAT != value)
                {
                    NotifyChange();
                }
                _tienVAT = value;
            }
        }

        private double _thuongNong;
        public double ThuongNong
        {
            get { return _thuongNong; }
            set
            {
                if (_thuongNong != value)
                {
                    NotifyChange();
                }
                _thuongNong = value;
            }
        }

        private string _ghiChu;
        public string GhiChu
        {
            get { return _ghiChu; }
            set
            {
                if (_ghiChu != value)
                {
                    NotifyChange();
                }
                _ghiChu = value;
            }
        }
        /// <summary>
        /// Duoc dung de dua ra cac thong bao den nguoi su dung
        /// </summary>
        public string TenSanPham { get; set; }

        public string MaSanPham { get; set; }

        public string DonViTinh { get; set; }

        public int TrungMaVach { get; set; }

        public string LoaiHangHoa { get; set; }//hang chinh, hang kem, khuyen mai, hang giao vao

        public int IdSanPhamBan { get; set; }

        public int LoaiHangKem { get; set; }
        public int BaoHanhHang { get; set; }
        public int BaoHanhKhach { get; set; }
        public int IdChiTietHangHoaGoc { get; set; }
        public string MaVachMark { get; set; }
        public int TuoiTon { get; set; }

    }
}
