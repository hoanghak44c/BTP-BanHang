using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
//using QLBanHang.Class;
using DevExpress.XtraGrid.Views.Grid;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;
using QLBH.Core;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBH.Core.Form;
using DevExpress.XtraGrid.Views.Base;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBC_BangGiaLichSu : DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"
        List<BangGiaBanChiTietBCInfor> liSanPham = new List<BangGiaBanChiTietBCInfor>();
        private List<BangGiaBanChiTietBCInfor> liTimKiem = new List<BangGiaBanChiTietBCInfor>();
        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
        private int SoLuongHienTai = 0;
        private bool DongBoGiaWeb = false;
#endregion

#region "Các phương thức khởi tạo"
        public frmBC_BangGiaLichSu()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }
        public frmBC_BangGiaLichSu(bool dongBo)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.DongBoGiaWeb = dongBo;
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
                cboPage.SelectedIndex = 0;

                List<TrangThaiBH> liTrangThai = new List<TrangThaiBH>();
                liTrangThai.Add(new TrangThaiBH { Id = 0, Name = "" });
                liTrangThai.Add(new TrangThaiBH { Id = 1, Name = "Thay đổi giá" });
                repTrangThai.DataSource = liTrangThai;
                //btnTim_Click(sender, e);
                gvLichSu = new GridView(gListSanPham);
                gListSanPham.MainView = gvListSanPham;
                gListSanPham.LevelTree.Nodes.Add("gLichSu", gvLichSu);
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
            int coTon = 0;
            int soTon = CommonFuns.Instance.GetSoTon();
            int idNhomNguoiDung = nguoiDung.SupperUser == 1 ? -1 : nguoiDung.IdNhomNguoiDung;

            liTimKiem = BangGiaDataProvider.Instance.GetBangGiaBanPg(idTrungTam, coTon, soBatDau, soKetThuc, txtSanPham.Text.Trim(),
                                                                     lueNganhHang.EditValue.ToString(), soTon, idNhomNguoiDung);
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
                //selector.View = gvListSanPham;
                //selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                //selector.CheckMarkColumn.VisibleIndex = 0;
                ((BindingList<BangGiaBanChiTietBCInfor>)gListSanPham.DataSource).ResetBindings();
                SoLuongHienTai = liSanPham.Count;
                //selector.ClearSelection();

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
                List<BangGiaChinhSachInfor> liCSachs =
                    ChinhSachDataProvider.Instance.GetAllChinhSachApDung(0, -1, 0, bgInfor.MaSanPham, -1);
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

        private void gvListSanPham_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
        }

        private void gvListSanPham_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            e.ChildList = BangGiaDataProvider.Instance.GetAllLichSuThayDoiGiaBan(
                bteTrungTam.Tag == null ? 0 : ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam,
                Convert.ToInt32(((ColumnView)sender).GetRowCellValue(e.RowHandle, "IdSanPham")),
                Convert.ToDateTime(dteStart.EditValue),
                Convert.ToDateTime(dteEnd.EditValue)); 
        }
    }
}