using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using QLBH.Common;
using QLBH.Core.Form;
using QLBH.Core.Infors;

// Người tạo: Lê Mạnh Tuấn
// Ngày tạo :
// Ngày sửa cuối:

namespace QLBanHang.Modules.BanHang.Infors
{
    [Serializable]
    public class TimKiemChungTuFilterInfor : NotifyInfo, IFilter
    {
        private string soPhieu;
        public string SoPhieu
        {
            get { return soPhieu; }
            set
            {
                if(soPhieu != value) NotifyChange();
                soPhieu = value;
            }
        }

        private int loaiDonHang;
        public int LoaiDonHang
        {
            get { return loaiDonHang; }
            set
            {
                if(loaiDonHang != value) NotifyChange();
                loaiDonHang = value;
            }
        }

        private int giaoNhan;
        public int GiaoNhan
        {
            get { return giaoNhan; } 
            set
            {
                if(giaoNhan != value) NotifyChange();
                giaoNhan = value;
            }
        }

        private int trangThai;
        public int TrangThai
        {
            get { return trangThai; }
            set
            {
                if(trangThai != value) NotifyChange();
                trangThai = value;
            }
        }

        private int idTrungTam;
        public int IdTrungTam
        {
            get { return idTrungTam; }
            set
            {
                if(idTrungTam != value) NotifyChange();
                idTrungTam = value;
            }
        }

        private int idKho;
        public int IdKho
        {
            get { return idKho; }
            set
            {
                if(idKho != value) NotifyChange();
                idKho = value;
            }
        }

        private string sanPham;
        public string SanPham
        {
            get { return sanPham; }
            set
            {
                if(sanPham != value) NotifyChange();
                sanPham = value;
            }
        }

        private string maHang;
        public string MaHang
        {
            get { return maHang; }
            set
            {
                if(maHang != value) NotifyChange();
                maHang = value;
            }
        }

        private int loaiMaHang;
        public int LoaiMaHang
        {
            get { return loaiMaHang; }
            set
            {
                if(loaiMaHang != value) NotifyChange();
                loaiMaHang = value;
            }
        }

        private string nhanVien;
        public string NhanVien
        {
            get { return nhanVien; }
            set
            {
                if(nhanVien != value) NotifyChange();
                nhanVien = value;
            }
        }

        private DateTime tuNgay;
        public DateTime TuNgay
        {
            get { return tuNgay; }
            set
            {
                if(tuNgay != value) NotifyChange();
                tuNgay = value;
            }
        }

        private DateTime denNgay;
        public DateTime DenNgay
        {
            get { return denNgay; }
            set
            {
                if(denNgay != value) NotifyChange();
                denNgay = value;
            }
        }

        private int khungGio;
        public int KhungGio
        {
            get { return khungGio; }
            set
            {
                if (khungGio != value) NotifyChange();
                khungGio = value;
            }
        }

        private int thu;
        public int Thu
        {
            get { return thu; }
            set
            {
                if (thu != value) NotifyChange();
                thu = value;
            }
        }

        private int idDoiTuong;
        public int IdDoiTuong
        {
            get { return idDoiTuong; }
            set
            {
                if(idDoiTuong != value) NotifyChange();
                idDoiTuong = value;
            }
        }

        private string khachHang;
        public string KhachHang
        {
            get { return khachHang; }
            set
            {
                if(khachHang != value) NotifyChange();
                khachHang = value;
            }
        }

        private string diaChi;
        public string DiaChi
        {
            get { return diaChi; }
            set
            {
                if(diaChi != value) NotifyChange();
                diaChi = value;
            }
        }

        private string cmnd;
        public string CMND
        {
            get { return cmnd; }
            set
            {
                if(cmnd != value) NotifyChange();
                cmnd = value;
            }
        }

        private string dienThoai;
        public string DienThoai
        {
            get { return dienThoai; }
            set
            {
                if(dienThoai != value) NotifyChange();
                dienThoai = value;
            }
        }

        private string maSoThue;
        public string MaSoThue
        {
            get { return maSoThue; }
            set
            {
                if (maSoThue != value) NotifyChange();
                maSoThue = value;
            }
        }

        private string ghiChu;
        public string GhiChu
        {
            get { return ghiChu; }
            set
            {
                if(ghiChu != value) NotifyChange();
                ghiChu = value;
            }
        }

        private string userName;
        public string UserName
        {
            get { return userName; }
            set
            {
                if(userName != value) NotifyChange();
                userName = value;
            }
        }

        private int draft;
        public int Draft
        {
            get { return draft; }
            set
            {
                if(draft != value) NotifyChange();
                draft = value;
            }
        }

        private double doanhThuTu;
        public double DoanhThuTu
        {
            get { return doanhThuTu; }
            set
            {
                if(doanhThuTu != value) NotifyChange();
                doanhThuTu = value;
            }
        }

        private double doanhThuDen;
        public double DoanhThuDen
        {
            get { return doanhThuDen; }
            set
            {
                if(doanhThuDen != value) NotifyChange();
                doanhThuDen = value;
            }
        }

        private int tinhTrangThanhToan;
        public int TinhTrangThanhToan
        {
            get { return tinhTrangThanhToan; }
            set
            {
                if(tinhTrangThanhToan != value) NotifyChange();
                tinhTrangThanhToan = value;
            }
        }

        public int SoBatDau { get; set; }
        public int SoKetThuc { get; set; }

        private int idChinhSach;
        public int IdChinhSach
        {
            get { return idChinhSach; }
            set
            {
                if(idChinhSach != value) NotifyChange();
                idChinhSach = value;
            }
        }

        private int idNhanVien;
        public int IdNhanVien
        {
            get { return idNhanVien; }
            set
            {
                if(idNhanVien != value) NotifyChange();
                idNhanVien = value;
            }
        }
        public int IdNhomNguoiDung { get; set; }
        public TimKiemChungTuFilterInfor()
        {
            soPhieu = null;
            loaiDonHang = -1;
            giaoNhan = -1;
            trangThai = -1;
            idTrungTam = -1;
            idKho = -1;
            sanPham = null;
            maHang = null;
            loaiMaHang = -1;
            nhanVien = null;
            tuNgay = (DateTime)SqlDateTime.Null;
            denNgay = (DateTime)SqlDateTime.Null;
            idDoiTuong = -1;
            khachHang = null;
            diaChi = null;
            cmnd = null;
            dienThoai = null;
            ghiChu = null;
            userName = null;
            draft = -1;
            doanhThuTu = 0;
            doanhThuDen = 0;
            tinhTrangThanhToan = 0;
            SoBatDau = 0;
            SoKetThuc = Declare.SOLUONG_TIMKIEM;
            idChinhSach = -1;
            idNhanVien = -1;
            IdNhomNguoiDung = 0;
        }
    }
}
