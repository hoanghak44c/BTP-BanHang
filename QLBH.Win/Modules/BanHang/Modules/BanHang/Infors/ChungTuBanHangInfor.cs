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
    public class ChungTuBanHangInfor : ChungTuBaseLockInfo
    {
        private int _quyenSo;
        public int QuyenSo
        {
            get { return _quyenSo; }
            set {
                if (_quyenSo != value)
                {
                    NotifyChange();
                }
                _quyenSo = value;
            }
        }

        private string _soSeri;
        public string SoSeri
        {
            get { return _soSeri; }
            set
            {
                if (_soSeri != value)
                {
                    NotifyChange();
                }
                _soSeri = value;
            }
        }

        private string _kyHieu;
        public string KyHieu
        {
            get { return _kyHieu; }
            set
            {
                if (_kyHieu != value)
                {
                    NotifyChange();
                }
                _kyHieu = value;
            }
        }

        private int _idDoiTuong;
        public int IdDoiTuong
        {
            get { return _idDoiTuong; }
            set
            {
                if (_idDoiTuong != value)
                {
                    NotifyChange();
                }
                _idDoiTuong = value;
            }
        }

        private string _hoTen;
        public string HoTen
        {
            get { return _hoTen; }
            set
            {
                if (_hoTen != value)
                {
                    NotifyChange();
                }
                _hoTen = value;
            }
        }

        private string _maKhach;
        public string MaKhach
        {
            get { return _maKhach; }
            set
            {
                if (_maKhach != value)
                {
                    NotifyChange();
                }
                _maKhach = value;
            }
        }

        private int _doTuoi;
        public int DoTuoi
        {
            get { return _doTuoi; }
            set
            {
                if (_doTuoi != value)
                {
                    NotifyChange();
                }
                _doTuoi = value;
            }
        }

        private int _gioiTinh;
        public int GioiTinh
        {
            get { return _gioiTinh; }
            set
            {
                if (_gioiTinh != value)
                {
                    NotifyChange();
                }
                _gioiTinh = value;
            }
        }

        private string _diaChi;
        public string DiaChi
        {
            get { return _diaChi; }
            set
            {
                if (_diaChi != value)
                {
                    NotifyChange();
                }
                _diaChi = value;
            }
        }

        private string _dienThoai;
        public string DienThoai
        {
            get { return _dienThoai; }
            set
            {
                if (_dienThoai != value)
                {
                    NotifyChange();
                }
                _dienThoai = value;
            }
        }

        private string _maSoThue;
        public string MaSoThue
        {
            get { return _maSoThue; }
            set
            {
                if (_maSoThue != value)
                {
                    NotifyChange();
                }
                _maSoThue = value;
            }
        }

        private string _soTaiKhoan;
        public string SoTaiKhoan
        {
            get { return _soTaiKhoan; }
            set
            {
                if (_soTaiKhoan != value)
                {
                    NotifyChange();
                }
                _soTaiKhoan = value;
            }
        }

        private string _nganHang;
        public string NganHang
        {
            get { return _nganHang; }
            set
            {
                if (_nganHang != value)
                {
                    NotifyChange();
                }
                _nganHang = value;
            }
        }

        private string _orderType;
        public string OrderType
        {
            get { return _orderType; }
            set
            {
                if (_orderType != value)
                {
                    NotifyChange();
                }
                _orderType = value;
            }
        }

        private int _billTo;
        public int BillTo
        {
            get { return _billTo; }
            set
            {
                if (_billTo != value)
                {
                    NotifyChange();
                }
                _billTo = value;
            }
        }

        private int _shipTo;
        public int ShipTo
        {
            get { return _shipTo; }
            set
            {
                if (_shipTo != value)
                {
                    NotifyChange();
                }
                _shipTo = value;
            }
        }

        private double _tongTienHang;
        public double TongTienHang
        {
            get { return _tongTienHang; }
            set
            {
                if (_tongTienHang != value)
                {
                    NotifyChange();
                }
                _tongTienHang = value;
            }
        }

        private double _tongTienChietKhau;
        public double TongTienChietKhau
        {
            get { return _tongTienChietKhau; }
            set
            {
                if (_tongTienChietKhau != value)
                {
                    NotifyChange();
                }
                _tongTienChietKhau = value;
            }
        }

        private double _tongTienSauChietKhau;
        public double TongTienSauChietKhau
        {
            get { return _tongTienSauChietKhau; }
            set
            {
                if (_tongTienSauChietKhau != value)
                {
                    NotifyChange();
                }
                _tongTienSauChietKhau = value;
            }
        }

        private double _tongTienVAT;
        public double TongTienVAT
        {
            get { return _tongTienVAT; }
            set
            {
                if (_tongTienVAT != value)
                {
                    NotifyChange();
                }
                _tongTienVAT = value;
            }
        }

        private double _tongTienThanhToan;
        public double TongTienThanhToan
        {
            get { return _tongTienThanhToan; }
            set
            {
                if (_tongTienThanhToan != value)
                {
                    NotifyChange();
                }
                _tongTienThanhToan = value;
            }
        }

        private int _idTienTe;
        public int IdTienTe
        {
            get { return _idTienTe; }
            set
            {
                if (_idTienTe != value)
                {
                    NotifyChange();
                }
                _idTienTe = value;
            }
        }

        private double _tyGia;
        public double TyGia
        {
            get { return _tyGia; }
            set
            {
                if (_tyGia != value)
                {
                    NotifyChange();
                }
                _tyGia = value;
            }
        }

        private double _tienThanhToanThuc;
        public double TienThanhToanThuc
        {
            get { return _tienThanhToanThuc; }
            set
            {
                if (_tienThanhToanThuc != value)
                {
                    NotifyChange();
                }
                _tienThanhToanThuc = value;
            }
        }

        private double _tienConNo;
        public double TienConNo
        {
            get { return _tienConNo; }
            set
            {
                if (_tienConNo != value)
                {
                    NotifyChange();
                }
                _tienConNo = value;
            }
        }

        private string _tongTienChu;
        public string TongTienChu
        {
            get { return _tongTienChu; }
            set
            {
                if (_tongTienChu != value)
                {
                    NotifyChange();
                }
                _tongTienChu = value;
            }
        }

        private int _hinhThucTra;
        public int HinhThucTra
        {
            get { return _hinhThucTra; }
            set
            {
                if (_hinhThucTra != value)
                {
                    NotifyChange();
                }
                _hinhThucTra = value;
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

        private int _idBangKeThue;//su dung de phan biet thanh toan voucher/the
        public int IdBangKeThue
        {
            get { return _idBangKeThue; }
            set
            {
                if (_idBangKeThue != value)
                {
                    NotifyChange();
                }
                _idBangKeThue = value;
            }
        }

        private int _idLoaiHdBanHang;
        public int IdLoaiHdBanHang
        {
            get { return _idLoaiHdBanHang; }
            set
            {
                if (_idLoaiHdBanHang != value)
                {
                    NotifyChange();
                }
                _idLoaiHdBanHang = value;
            }
        }

        private int _idDuAn;
        public int IdDuAn
        {
            get { return _idDuAn; }
            set
            {
                if (_idDuAn != value)
                {
                    NotifyChange();
                }
                _idDuAn = value;
            }
        }

        private string _soChungTuGoc;
        public string SoChungTuGoc
        {
            get { return _soChungTuGoc; }
            set
            {
                if (_soChungTuGoc != value)
                {
                    NotifyChange();
                }
                _soChungTuGoc = value;
            }
        }

        private int _idThuNgan;
        public int IdThuNgan
        {
            get { return _idThuNgan; }
            set
            {
                if (_idThuNgan != value)
                {
                    NotifyChange();
                }
                _idThuNgan = value;
            }
        }

        private string _soCMND;
        public string SoCMND
        {
            get { return _soCMND; }
            set
            {
                if (_soCMND != value)
                {
                    NotifyChange();
                }
                _soCMND = value;
            }
        }

        private int _giaoNhan;
        public int GiaoNhan
        {
            get { return _giaoNhan; }
            set
            {
                if (_giaoNhan != value)
                {
                    NotifyChange();
                }
                _giaoNhan = value;
            }
        }

        private int _idTruongCa;
        public int IdTruongCa
        {
            get { return _idTruongCa; }
            set
            {
                if (_idTruongCa != value)
                {
                    NotifyChange();
                }
                _idTruongCa = value;
            }
        }

        private int _loaiTheKhachHang;
        public int LoaiTheKhachHang
        {
            get { return _loaiTheKhachHang; }
            set
            {
                if (_loaiTheKhachHang != value)
                {
                    NotifyChange();
                }
                _loaiTheKhachHang = value;
            }
        }

        private double _soTienTichLuy;
        public double SoTienTichLuy
        {
            get { return _soTienTichLuy; }
            set
            {
                if (_soTienTichLuy != value)
                {
                    NotifyChange();
                }
                _soTienTichLuy = value;
            }
        }

        private int _caBanHang;
        public int CaBanHang
        {
            get { return _caBanHang; }
            set
            {
                if (_caBanHang != value)
                {
                    NotifyChange();
                }
                _caBanHang = value;
            }
        }

        private string _soPhieuXuat;
        public string SoPhieuXuat
        {
            get { return _soPhieuXuat; }
            set
            {
                if (_soPhieuXuat != value) NotifyChange();
                _soPhieuXuat = value;
            }
        }

        private DateTime _ngayXuatHang;
        public DateTime NgayXuatHang
        {
            get { return _ngayXuatHang; }
            set
            {
                if (_ngayXuatHang != value) NotifyChange();
                _ngayXuatHang = value;
            }
        }

        private DateTime _ngayHenGiaoHang;
        public DateTime NgayHenGiaoHang
        {
            get { return _ngayHenGiaoHang; }
            set
            {
                if (_ngayHenGiaoHang != value) NotifyChange();
                _ngayHenGiaoHang = value;
            }
        }

        private int _idNhanVienGiao;
        public int IdNhanVienGiao
        {
            get { return _idNhanVienGiao; }
            set
            {
                if (_idNhanVienGiao != value)
                {
                    NotifyChange();
                }
                _idNhanVienGiao = value;
            }
        }

        private int _cachGiaoHang;
        public int CachGiaoHang
        {
            get { return _cachGiaoHang; }
            set
            {
                if (_cachGiaoHang != value)
                {
                    NotifyChange();
                }
                _cachGiaoHang = value;
            }
        }

        private DateTime _ngayGiaoHang;
        public DateTime NgayGiaoHang
        {
            get { return _ngayGiaoHang; }
            set
            {
                if (_ngayGiaoHang != value) NotifyChange();
                _ngayGiaoHang = value;
            }
        }

        private DateTime _ngayGiaoXongHang;
        public DateTime NgayGiaoXongHang
        {
            get { return _ngayGiaoXongHang; }
            set
            {
                if (_ngayGiaoXongHang != value) NotifyChange();
                _ngayGiaoXongHang = value;
            }
        }

        private int _idKhachLe;
        public int IdKhachLe
        {
            get { return _idKhachLe; }
            set
            {
                if (_idKhachLe != value)
                {
                    NotifyChange();
                }
                _idKhachLe = value;
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                if (_email != value)
                {
                    NotifyChange();
                }
                _email = value;
            }
        }

        private string _website;
        public string Website
        {
            get { return _website; }
            set
            {
                if (_website != value)
                {
                    NotifyChange();
                }
                _website = value;
            }
        }

        private int _draft;
        public int Draft
        {
            get { return _draft; }
            set
            {
                if (_draft != value)
                {
                    NotifyChange();
                }
                _draft = value;
            }
        }

        private int _idTinhHD;
        public int IdTinhHD
        {
            get { return _idTinhHD; }
            set
            {
                if (_idTinhHD != value)
                {
                    NotifyChange();
                }
                _idTinhHD = value;
            }
        }

        private int _idHuyenHD;
        public int IdHuyenHD
        {
            get { return _idHuyenHD; }
            set
            {
                if (_idHuyenHD != value)
                {
                    NotifyChange();
                }
                _idHuyenHD = value;
            }
        }

        private string _diaChiHD;
        public string DiaChiHD
        {
            get { return _diaChiHD; }
            set
            {
                if (_diaChiHD != value)
                {
                    NotifyChange();
                }
                _diaChiHD = value;
            }
        }

        public string DiaChiHoaDon { get; set; }


        private int _idTinhGH;
        public int IdTinhGH
        {
            get { return _idTinhGH; }
            set
            {
                if (_idTinhGH != value)
                {
                    NotifyChange();
                }
                _idTinhGH = value;
            }
        }

        private int _idHuyenGH;
        public int IdHuyenGH
        {
            get { return _idHuyenGH; }
            set
            {
                if (_idHuyenGH != value)
                {
                    NotifyChange();
                }
                _idHuyenGH = value;
            }
        }

        private string _diaChiGH;
        public string DiaChiGH
        {
            get { return _diaChiGH; }
            set
            {
                if (_diaChiGH != value)
                {
                    NotifyChange();
                }
                _diaChiGH = value;
            }
        }

        public string DiaChiGiaoHang { get; set; }

        private string _soHDDaMua;
        public string SoHDDaMua
        {
            get { return _soHDDaMua; }
            set
            {
                if (_soHDDaMua != value)
                {
                    NotifyChange();
                }
                _soHDDaMua = value;
            }
        }

        private int _idNgheNghiep;
        public int IdNgheNghiep
        {
            get { return _idNgheNghiep; }
            set
            {
                if (_idNgheNghiep != value)
                {
                    NotifyChange();
                }
                _idNgheNghiep = value;
            }
        }
        private int _idLyDoGiaoDich;
        public int IdLyDoGiaoDich
        {
            get { return _idLyDoGiaoDich; }
            set
            {
                if (_idLyDoGiaoDich != value)
                {
                    NotifyChange();
                }
                _idLyDoGiaoDich = value;
            }
        }

        private string _soPhieuDC;
        public string SoPhieuDC
        {
            get { return _soPhieuDC; }
            set
            {
                if (_soPhieuDC != value)
                {
                    NotifyChange();
                }
                _soPhieuDC = value;
            }
        }

        private string _congTy;
        public string CongTy
        {
            get { return _congTy; }
            set
            {
                if (_congTy != value)
                {
                    NotifyChange();
                }
                _congTy = value;
            }
        }
        
        public int DongBoOracle { get; set; }

        public string TenTrungTam { get; set; }
        public string TenKho { get; set; }
        public string MaKho { get; set; }
        public string TenDoiTuong { get; set; }
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string ThoiGianDongBo { get; set; }//de import du lieu tu vip ve pos
        public string SanPhamBan { get; set; }
        public int TuHuy { get; set; }
        public int DaPhanDon { get; set; }//phan don giao van
        public string QuanHuyen { get; set; }
        public string GioGiaoHang { get; set; }
        public DateTime ThoiGianGiaoTu { get; set; }
        public DateTime ThoiGianGiaoDen { get; set; }
        public int DaTichDiem { get; set; }//xac dinh da duoc tich diem chua
        public string NguoiXacNhan { get; set; }//ma nguoi xac nhan
        public int IdTheThanhVien { get; set; }
        public string TheThanhVien { get; set; }//ten the thanh vien
        public int DoUuTien { get; set; }//do uu tien khi thanh toan, giao nhan
        public int SoDiemBiTru { get; set; }//so diem bi tru
        public double SoTienQuyDoi { get; set; }//so tien duoc quy doi
        public int SoDiemTichLuy { get; set; }//so diem duoc tich luy them
        public string NgheNghiep { get; set; }
        public ChungTuBanHangInfor()
        {
            
        }
        public ChungTuBanHangInfor(ChungTuBanHangInfor ct)
        {
            this.IdChungTu = ct.IdChungTu;
            this.SoChungTu = ct.SoChungTu;
            this.NgayLap = ct.NgayLap;
            this.LoaiChungTu = ct.LoaiChungTu;
            this.IdTrungTamHachToan = ct.IdTrungTamHachToan;
            this.IdKho = ct.IdKho;
            this.IdNhanVien = ct.IdNhanVien;
            this.TrangThai = ct.TrangThai;
            this.NgayHoaDon = ct.NgayHoaDon;
            this.QuyenSo = ct.QuyenSo;
            this.SoSeri = ct.SoSeri;
            this.KyHieu = ct.KyHieu;
            this.IdDoiTuong = ct.IdDoiTuong;
            this.HoTen = ct.HoTen;
            this.MaKhach = ct.MaKhach;
            this.DoTuoi = ct.DoTuoi;
            this.GioiTinh = ct.GioiTinh;
            this.DiaChi = ct.DiaChi;
            this.DienThoai = ct.DienThoai;
            this.MaSoThue = ct.MaSoThue;
            this.SoTaiKhoan = ct.SoTaiKhoan;
            this.NganHang = ct.NganHang;
            this.TongTienHang = ct.TongTienHang;
            this.TongTienChietKhau = ct.TongTienChietKhau;
            this.TongTienSauChietKhau = ct.TongTienSauChietKhau;
            this.TongTienVAT = ct.TongTienVAT;
            this.TongTienThanhToan = ct.TongTienThanhToan;
            this.TienThanhToanThuc = ct.TienThanhToanThuc;
            this.TienConNo = ct.TienConNo;
            this.TongTienChu = ct.TongTienChu;
            this.HinhThucTra = ct.HinhThucTra;
            this.GhiChu = ct.GhiChu;
            this.IdBangKeThue = ct.IdBangKeThue;
            this.IdLoaiHdBanHang = ct.IdLoaiHdBanHang;
            this.SoChungTuGoc = ct.SoChungTuGoc;
            this.IdThuNgan = ct.IdThuNgan;
            this.SoCMND = ct.SoCMND;
            this.GiaoNhan = ct.GiaoNhan;
            this.IdTruongCa = ct.IdTruongCa;
            this.CaBanHang = ct.CaBanHang;
            this.SoPhieuXuat = ct.SoPhieuXuat;
            this.NgayXuatHang = ct.NgayXuatHang;
            this.NgayHenGiaoHang = ct.NgayHenGiaoHang;
            this.IdNhanVienGiao = ct.IdNhanVienGiao;
            this.CachGiaoHang = ct.CachGiaoHang;
            this.NgayGiaoHang = ct.NgayGiaoHang;
            this.NgayGiaoXongHang = ct.NgayGiaoXongHang;
            this.IdKhachLe = ct.IdKhachLe;
            this.Email = ct.Email;
            this.Website = ct.Website;
            this.Draft = ct.Draft;
            this.IdTinhHD = ct.IdTinhHD;
            this.IdHuyenHD = ct.IdHuyenHD;
            this.DiaChiHD = ct.DiaChiHD;
            this.DiaChiHoaDon = ct.DiaChiHoaDon;
            this.IdTinhGH = ct.IdTinhGH;
            this.IdHuyenGH = ct.IdHuyenGH;
            this.DiaChiGH = ct.DiaChiGH;
            this.DiaChiGiaoHang = ct.DiaChiGiaoHang;
            this.SoHDDaMua = ct.SoHDDaMua;
            this.IdNgheNghiep = ct.IdNgheNghiep;
            this.IdLyDoGiaoDich = ct.IdLyDoGiaoDich;
            this.SoPhieuDC = ct.SoPhieuDC;
            this.CongTy = ct.CongTy;
            this.IdTrungTam = ct.IdTrungTam;
            this.NguoiTao = ct.NguoiTao;
            this.ThoiGianTao = ct.ThoiGianTao;
            this.TenMayTao = ct.TenMayTao;
            this.NguoiSua = ct.NguoiSua;
            this.ThoiGianSua = ct.ThoiGianSua;
            this.TenMaySua = ct.TenMaySua;
        }
    }
}
