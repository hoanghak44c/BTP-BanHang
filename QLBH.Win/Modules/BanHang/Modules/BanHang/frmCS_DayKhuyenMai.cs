using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using QLBanHang.Class;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QLBanHang.Modules.BanHang.Reports;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.KhoHang.Infors;
using QLBanHang.Modules.KhoHang.Providers;
using QLBH.Common;
using QLBH.Common.Providers;
using QLBH.Core;
using QLBH.Core.Data;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.BanHang.Bussiness;
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmCS_DayKhuyenMai : DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"
        List<BangGiaBanChiTietBCInfor> liSanPham = new List<BangGiaBanChiTietBCInfor>();
        private List<BangGiaBanChiTietBCInfor> liTimKiem = new List<BangGiaBanChiTietBCInfor>();
        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        List<BangGiaBanChiTietBCInfor> liNoKMai = new List<BangGiaBanChiTietBCInfor>();
        private int SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
        private int SoLuongHienTai = 0;
#endregion

#region "Các phương thức khởi tạo"
        public frmCS_DayKhuyenMai()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }
#endregion

#region "Các sự kiên"
        private void frmBH_TimChungTu_Load(object sender, EventArgs e)
        {
            try
            {
                LoadNganhHang();
                DMTrungTamInfor tt = DMTrungTamDataProvider.GetTrungTamByIdInfo(Declare.IdTrungTam);
                if (tt != null)
                {
                    bteTrungTam.Text = tt.TenTrungTam;
                    bteTrungTam.Tag = tt;
                }
                chkChuaDayKM.Checked = true;
                cboPage.SelectedIndex = 0;
                //btnDongBo.Visible = (nguoiDung.SupperUser == 1 ? true : false);
                //btnDongBo.Enabled = (nguoiDung.SupperUser == 1 ? true : false);

                List<TrangThaiBH> liTrangThai = new List<TrangThaiBH>();
                liTrangThai.Add(new TrangThaiBH { Id = 0, Name = "" });
                liTrangThai.Add(new TrangThaiBH { Id = 1, Name = "Thay đổi giá" });
                repTrangThai.DataSource = liTrangThai;
                //btnTim_Click(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadNganhHang()
        {
            //int idNND = Common.Int2Bool(nguoiDung.SupperUser) ? -1 : nguoiDung.IdNhomNguoiDung;
            List<TimKiemItemInfor> liNganh = TimKiemItemDataProvider.Instance.GetAllItemsByType(-1, 1, -1, -1);//type=1: nganh hang
            liNganh.Insert(0, new TimKiemItemInfor()
                            {
                                Id = 0,
                                Ma = "",
                                Ten = "Tất cả"
                            });
            lueNganhHang.Properties.DataSource = liNganh;
            lueNganhHang.Properties.DisplayMember = "Ten";
            lueNganhHang.Properties.ValueMember = "Ma";
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            SoLuongHienTai = 0;
            SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
            liSanPham = new List<BangGiaBanChiTietBCInfor>();

            TimKiemBangGia();
        }
        private void LoadDuLieu()
        {
            int soBatDau = SoLuongHienTai;
            int soKetThuc = SoLuongTimKiem != -1 ? SoLuongHienTai + SoLuongTimKiem : -1;
            int idTrungTam = bteTrungTam.Tag != null
                                 ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam
                                 : Declare.IdTrungTam;
            int coTon = chkChuaDayKM.Checked ? 1 : 0;
            int soTon = CommonFuns.Instance.GetSoTon();

            liTimKiem = BangGiaDataProvider.Instance.GetBangGiaBanPg(idTrungTam, coTon, soBatDau, soKetThuc, txtSanPham.Text.Trim(),
                                                                     lueNganhHang.EditValue.ToString(), soTon, -1);
            liSanPham.AddRange(liTimKiem);

            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            frmProgress.Instance.IsCompleted = true;
            frmProgress.Instance.Description = "Đã xong";            
        }
        private void TimKiemBangGia()
        {
            try
            {
                frmProgress.Instance.Description = Common.MsgProgress(SoLuongTimKiem);
                frmProgress.Instance.MaxValue = SoLuongTimKiem;
                frmProgress.Instance.Value = 0;
                frmProgress.Instance.DoWork(LoadDuLieu);

                gListSanPham.DataSource = new BindingList<BangGiaBanChiTietBCInfor>(liSanPham); 
                //gvListChungTu.Columns["ParentName"].GroupIndex = 0;
                gvListSanPham.ExpandAllGroups();
                selector.View = gvListSanPham;
                selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                selector.CheckMarkColumn.VisibleIndex = 0;
                ((BindingList<BangGiaBanChiTietBCInfor>)gListSanPham.DataSource).ResetBindings();
                SoLuongHienTai = liSanPham.Count;
                selector.ClearSelection();

                this.grpKetQuaTimKiem.Text = "Tổng số mã hàng: " + liSanPham.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

#endregion


        private void frmBH_TimChungTu_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode==Keys.Enter)   
                {
                    if (!this.gListSanPham.Focused)
                    {
                        SendKeys.Send("{TAB}");
                        e.Handled = true;
                        return;
                    }
                }
                if (e.KeyCode == Keys.F3)
                    this.btnTim_Click(sender, e);
                else if (e.KeyCode == Keys.F5)
                    this.btnInBG_Click(sender, e);
                else if (e.KeyCode == Keys.F6 && btnDongBo.Enabled)
                    this.btnDong_Click(sender, e);
                else if (e.KeyCode == Keys.Escape)
                    this.btnDong_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void bteTrungTam_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteTrungTam_ButtonClick(sender, e, bteTrungTam, nguoiDung.IdNhanVien);
        }

        private void bteTrungTam_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteTrungTam_KeyDown(sender, e, bteTrungTam, nguoiDung.IdNhanVien);
        }

        private void bteTrungTam_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteTrungTam);
        }

        private void btnInBG_Click(object sender, EventArgs e)
        {
            Form frm1 = (Form)QLBHUtils.GetObject(Declare.KhoHangNamespace.frmInNoteSP, null);
            frm1.ShowDialog();
            //if (selector.selection.Count == 0) return;
            //ArrayList liSanPham = new ArrayList();
            //liSanPham.AddRange(selector.selection);
            //frmBH_BangGiaBanHang_InBG frm = new frmBH_BangGiaBanHang_InBG(liSanPham);
            //frm.ShowDialog();
        }

        private void TonChiTiet_Click(object sender, EventArgs e)
        {
            BangGiaBanChiTietBCInfor bgInfor = (BangGiaBanChiTietBCInfor)gvListSanPham.GetFocusedRow();
            if (bgInfor != null)
            {
                frmBH_BangGiaBanHang_TonCTiet frm = new frmBH_BangGiaBanHang_TonCTiet(bgInfor);
                frm.ShowDialog();
            }
        }

        private void ChinhSachApDung_Click(object sender, EventArgs e)
        {
            BangGiaBanChiTietBCInfor bgInfor = (BangGiaBanChiTietBCInfor)gvListSanPham.GetFocusedRow();
            if (bgInfor != null)
            {
                int idTrungTam = bteTrungTam.Tag != null
                                     ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam
                                     : Declare.IdTrungTam;
                DateTime ngayLap = CommonProvider.Instance.GetSysDate();

                List<BangGiaChinhSachInfor> liCSachs =
                    ChinhSachDataProvider.Instance.GetAllChinhSachDaApDung(idTrungTam, bgInfor.MaSanPham, ngayLap);
                List<BangGiaChinhSachInfor> liChinhSach = new List<BangGiaChinhSachInfor>();
                foreach (BangGiaChinhSachInfor cs in liCSachs)
                {
                    string lstMatHangKhongAD = String.Format(",{0},", cs.MatHangKhongApDung);//khong nam trong danh sach ko duoc ap dung
                    if (!lstMatHangKhongAD.Contains(String.Format(",{0},", bgInfor.IdSanPham)))
                        liChinhSach.Add(cs);
                }
                //List<BangGiaChinhSachInfor> liChinhSach =
                //    ChinhSachDataProvider.Instance.GetAllChinhSachDaApDung(bgInfor.IdTrungTam, bgInfor.MaSanPham,
                //                                                           CommonProvider.Instance.GetSysDate());

                if (liChinhSach != null && liChinhSach.Count > 0)
                {
                    BangGiaChiTietInfor bgct = new BangGiaChiTietInfor()
                                                   {
                                                      MaSanPham = bgInfor.MaSanPham,
                                                      TenSanPham = bgInfor.TenSanPham,
                                                      DonViTinh = bgInfor.TenDonViTinh,
                                                      DonGiaCoVAT = bgInfor.DonGiaCoVAT
                                                   };
                    frmCS_BangGia_ViewKhuyenMai frm = new frmCS_BangGia_ViewKhuyenMai(liChinhSach, bgct);
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không có chính sách giá cho sản phẩm này!");
                }
            }
        }

        private void LichSuThayDoiGia_Click(object sender, EventArgs e)
        {
            BangGiaBanChiTietBCInfor bgInfor = (BangGiaBanChiTietBCInfor)gvListSanPham.GetFocusedRow();
            if (bgInfor != null)
            {
                frmBH_BangGiaBanHang_LichSu frm = new frmBH_BangGiaBanHang_LichSu(bgInfor.IdTrungTam, bgInfor.IdSanPham);
                frm.ShowDialog();
            }
        }

        private void cmdExport_Click(object sender, EventArgs e)
        {
            //Common.DevExport2Excel(gvListSanPham, "BangGiaHienTai");
            Common.Export2ExcelFromDevGrid<BangGiaBanChiTietBCInfor>(gvListSanPham, "BangGiaHienTai");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SoLuongTimKiem = Common.IntValue(cboPage.SelectedItem);
            if (SoLuongTimKiem == 0)
                SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
            if (cboPage.SelectedItem.Equals("Tất cả"))
            {
                if (MessageBox.Show(Declare.msgLoadDataWrn, "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SoLuongTimKiem = -1;
                }
                else
                {
                    return;
                }
            } 

            TimKiemBangGia();
        }

        private void btnDongBo_Click(object sender, EventArgs e)
        {
            if (selector.selection.Count > 0)
            {
                liNoKMai = new List<BangGiaBanChiTietBCInfor>();
                foreach (BangGiaBanChiTietBCInfor bgct in selector.selection)
                {
                    liNoKMai.Add(bgct);
                }

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
            else
            {
                MessageBox.Show("Không có mã hàng được chọn");
            }
        }

        private void gvListSanPham_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle < 0) return;
            BangGiaBanChiTietBCInfor ct = (BangGiaBanChiTietBCInfor)gvListSanPham.GetRow(e.RowHandle);
            DateTime now = CommonProvider.Instance.GetSysDate();

            if (ct != null)// && now.CompareTo(ct.NgayCapNhatCuoi) > 60*60*24*1000)
            {
                TimeSpan tmp = now - ct.NgayCapNhatCuoi;
                if (tmp.TotalDays > 1) return;
                if (ct.DonGiaCoVAT > ct.DonGiaCoVATOld)//tang gia
                {
                    e.Appearance.BackColor = tsslTangGia.BackColor;
                    e.Appearance.ForeColor = tsslTangGia.ForeColor;
                    e.Appearance.Font = new Font("Arial", 9, FontStyle.Bold);                    
                }
                else//giam gia
                {
                    e.Appearance.BackColor = tsslGiamGia.BackColor;
                    e.Appearance.ForeColor = tsslGiamGia.ForeColor;
                    e.Appearance.Font = new Font("Arial", 9, FontStyle.Bold);                    
                    
                }
            }
        }

        private void btnDongBoAll_Click(object sender, EventArgs e)
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
                else
                {
                    MessageBox.Show("Tất cả các mã đã đồng bộ sang Oralce");
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
                    frmProgress.Instance.Description = String.Format("Đang đẩy mã {0} ....", sp.MaSanPham);
                    string kmai = "";
                    int iddkmua = 0;
                    int idTrungTam = bteTrungTam.Tag != null
                                         ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam
                                         : Declare.IdTrungTam;
                    DateTime ngayLap = CommonProvider.Instance.GetSysDate();

                    double tienKhuyenMai = CommonFuns.Instance.GetTienKhuyenMai(idTrungTam, sp.IdSanPham,
                                                                              sp.MaSanPham, ngayLap, sp.DonGiaCoVAT,
                                                                              sp.DonGiaCoVAT, sp.TyLeVAT, ref kmai, ref iddkmua);
                    try
                    {
                        BangGiaDataProvider.Instance.DongBoKhuyenMai(sp.MaSanPham, tienKhuyenMai, iddkmua);
                    }
                    catch (Exception ex)
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
    }
}