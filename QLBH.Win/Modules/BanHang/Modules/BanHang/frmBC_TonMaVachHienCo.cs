using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using QLBanHang.Class;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.BanHang.Bussiness;
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBC_TonMaVachHienCo : FrmBcBase2<LichSuChiTietMaVachInfor>
    //DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"
        private List<LichSuChiTietMaVachInfor> liChungTuChiTiet = new List<LichSuChiTietMaVachInfor>();
        private List<LichSuChiTietMaVachInfor> liTimKiem = new List<LichSuChiTietMaVachInfor>();
        public TimKiemChungTuChiTietFilterInfor filter = new TimKiemChungTuChiTietFilterInfor();
        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
        private int SoLuongHienTai = 0;

#endregion

#region "Các phương thức khởi tạo"
        public frmBC_TonMaVachHienCo()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            DataProvider = BaoCaoTonMaVachHienCoDataProvider.Instance;
            filter = new TimKiemChungTuChiTietFilterInfor();
            gListChungTu.DataSource = DataSource;
        }
#endregion

#region "Các sự kiên"
        private void frmBH_TimChungTu_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAllTrangThai();
                CommonFuns.Instance.LoadNganhHang(lueNganhHang, nguoiDung, true);
                CommonFuns.Instance.LoadChonTrungTam(bteTrungTam, nguoiDung);
                //CommonFuns.Instance.LoadComboBoxPages(cboPage);
                //TimKiemChungTu2();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAllTrangThai()
        {
            List<TrangThaiBH> liLoaiDH = Common.GetListBCLoaiNhapHang();
            //load trang thai cho grid
            liLoaiDH.Insert(0, new TrangThaiBH {Id = 0, Name = "Tồn đầu kỳ (trước Golive 1/5/2013)"});
            repLoaiDonHang.DataSource = liLoaiDH;

            List<TrangThaiBH> liLoaiDH1 = new List<TrangThaiBH>();
            liLoaiDH1.Add(new TrangThaiBH { Id = -1, Name = "Tất cả" });
            liLoaiDH1.AddRange(liLoaiDH);
            lueLoaiDH.Properties.DataSource = liLoaiDH1;
            lueLoaiDH.EditValue = -1;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            //SoLuongHienTai = 0;
            //SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
            //liChungTuChiTiet = new List<LichSuChiTietMaVachInfor>(); 

            //var tblTrungTam = String.Empty;
            //DmTrungTamDAO.Instance.ParseToCsv(ref tblTrungTam, DMTrungTamDataProvider.GetListTrungTamPairInfo());
            //var tblKho = String.Empty;
            //DMKhoDAO.Instance.ParseToCsv(ref tblKho, DMKhoDataProvider.GetListDMKhoInfor());
            //var tblSanPham = String.Empty;
            //DMSanPhamDAO.Instance.ParseToCsv(ref tblSanPham, DmSanPhamProvider.Instance.GetListDmSanPhamInfoUsing());

            TimKiemChungTu();
        }

        private void GetFilter()
        {
            if (filter == null)
                filter = new TimKiemChungTuChiTietFilterInfor();
            filter.LoaiDonHang = Common.IntValue(lueLoaiDH.EditValue);
            filter.IdTrungTam = CommonFuns.Instance.GetIdTrungTam(bteTrungTam, nguoiDung);
            filter.IdKho = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : -1;
            filter.IdSanPham = bteSanPham.Tag != null ? ((DMSanPhamInfo)bteSanPham.Tag).IdSanPham : -1;
            filter.MaVach = txtMaVach.Text.Trim();
            filter.Nganh = lueNganhHang.EditValue != null
                                   ? lueNganhHang.EditValue.ToString()
                                   : (nguoiDung.SupperUser == 1 ? "" : "-1");
            filter.SoTon = CommonFuns.Instance.GetSoTon();
            filter.IdNhanVien = nguoiDung.IdNhanVien;
        }
        private void LoadDuLieu()
        {
            if(!String.IsNullOrEmpty(filter.SanPham))
            {
                DMSanPhamInfo sanPhamInfo = DmSanPhamProvider.Instance.GetSanPhamByMa(filter.SanPham);

                var liNganh = new List<TimKiemItemInfor>();
                liNganh.AddRange((List<TimKiemItemInfor>)lueNganhHang.Properties.DataSource);

                if(sanPhamInfo != null && 
                    (!String.IsNullOrEmpty(filter.Nganh) && filter.Nganh == sanPhamInfo.Nganh ||
                    liNganh.Exists(delegate (TimKiemItemInfor match) { return match.Ma == sanPhamInfo.Nganh; })))
                {
                    frmProgress.Instance.MaxValue = 1;
                    frmProgress.Instance.Value = 0;
                    filter.SoBatDau = -1;
                    filter.SoKetThuc = -1;
                    //filter.SoBatDau = SoLuongHienTai;
                    //filter.SoKetThuc = SoLuongTimKiem != -1 ? SoLuongHienTai + SoLuongTimKiem : -1;
                    liTimKiem = BanHangDataProvider.Instance.TimKiemTonChiTietMaVachPg(filter);
                    liChungTuChiTiet.AddRange(liTimKiem);                    
                }
            }
            else if (filter.IdTrungTam > 0 && filter.IdKho > 0 && 
                filter.Nganh != String.Empty && filter.Nganh != "-1")
            {
                frmProgress.Instance.MaxValue = 1;
                frmProgress.Instance.Value = 0;
                filter.SoBatDau = -1;
                filter.SoKetThuc = -1;
                //filter.SoBatDau = SoLuongHienTai;
                //filter.SoKetThuc = SoLuongTimKiem != -1 ? SoLuongHienTai + SoLuongTimKiem : -1;
                liTimKiem = BanHangDataProvider.Instance.TimKiemTonChiTietMaVachPg(filter);
                liChungTuChiTiet.AddRange(liTimKiem);
            }
            else if (filter.IdTrungTam == -1 || filter.IdKho == -1 || 
                filter.Nganh == String.Empty || filter.Nganh == "-1")
            {
                var liNganh = new List<TimKiemItemInfor>();
                var liKho = new List<DMKhoSInfo>();

                frmProgress.Instance.MaxValue = 1;
                frmProgress.Instance.Value = 0;

                if(filter.Nganh == String.Empty || filter.Nganh == "-1")
                {
                    liNganh.AddRange((List<TimKiemItemInfor>)lueNganhHang.Properties.DataSource);
                } 
                else
                {
                    liNganh.Add(new TimKiemItemInfor {Ma = filter.Nganh});
                }

                if(filter.IdKho == -1)
                {
                    liKho.AddRange(DMKhoDataProvider.Instance.GetListIdKhoTon(filter.IdTrungTam));
                }
                else
                {
                    liKho.Add(new DMKhoSInfo {IdKho = filter.IdKho, IdTrungTam = filter.IdTrungTam});
                }

                frmProgress.Instance.MaxValue = liKho.Count * liNganh.Count;
                filter.SoBatDau = -1;
                filter.SoKetThuc = -1;

                foreach (DMKhoSInfo dMKhoSInfo in liKho)
                {
                    filter.IdKho = dMKhoSInfo.IdKho;

                    filter.IdTrungTam = dMKhoSInfo.IdTrungTam;

                    var liNganhTon = DmNganhDataProvider.Instance.GetListNganhTonKho(filter.IdKho);

                    foreach (TimKiemItemInfor timKiemItemInfor in liNganh)
                    {
                        if(liNganhTon.Contains(timKiemItemInfor.Ma))
                        {
                            filter.Nganh = timKiemItemInfor.Ma;

                            liTimKiem = BanHangDataProvider.Instance.TimKiemTonChiTietMaVachPg(filter);

                            if (liTimKiem.Count > 0)
                            {
                                liChungTuChiTiet.AddRange(liTimKiem);

                                if (InvokeRequired)
                                    Invoke((MethodInvoker)delegate { gListChungTu.RefreshDataSource(); });
                                else
                                    gListChungTu.RefreshDataSource();
                            }                            
                        }
                        frmProgress.Instance.Value += 1;
                    }
                }
            }
            frmProgress.Instance.Description = "Đã xong";
            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            frmProgress.Instance.IsCompleted = true;
        }

        protected override void RefreshDataSource()
        {
            gListChungTu.RefreshDataSource();

            if (gvListChungTu.RowCount > 0)

                gvListChungTu.FocusedRowHandle = 0;

            this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + DataSource.Count + " mặt hàng)";

        }

        protected override IFilter2 GetFilter2()
        {
            if (filter == null)
                filter = new TimKiemChungTuChiTietFilterInfor();
            filter.LoaiDonHang = Common.IntValue(lueLoaiDH.EditValue);
            filter.IdTrungTam = CommonFuns.Instance.GetIdTrungTam(bteTrungTam, nguoiDung);
            filter.IdKho = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : -1;
            filter.IdSanPham = bteSanPham.Tag != null ? ((DMSanPhamInfo) bteSanPham.Tag).IdSanPham : -1;
            filter.MaVach = txtMaVach.Text.Trim();
            filter.Nganh = lueNganhHang.EditValue != null
                                   ? lueNganhHang.EditValue.ToString()
                                   : (nguoiDung.SupperUser == 1 ? "" : "-1");
            filter.SoTon = CommonFuns.Instance.GetSoTon();
            filter.IdNhanVien = nguoiDung.IdNhanVien;

            return filter;
        }

        private void TimKiemChungTu2()
        {
            try
            {
                GetFilter();
                liChungTuChiTiet.Clear();
                gListChungTu.DataSource = liChungTuChiTiet; 
                frmProgress.Instance.Description = Common.MsgProgress(SoLuongTimKiem);
                frmProgress.Instance.MaxValue = SoLuongTimKiem;
                frmProgress.Instance.Value = 0;
                frmProgress.Instance.DoWork(LoadDuLieu);

                //gListChungTu.DataSource = new BindingList<LichSuChiTietMaVachInfor>(liChungTuChiTiet); 
                //gvListChungTu.Columns["ParentName"].GroupIndex = 0;
                gvListChungTu.ExpandAllGroups();
                selector.View = gvListChungTu;
                selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                selector.CheckMarkColumn.VisibleIndex = 0;
                //((BindingList<LichSuChiTietMaVachInfor>)gListChungTu.DataSource).ResetBindings();
                SoLuongHienTai = liChungTuChiTiet.Count;
                selector.ClearSelection();

                this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + liChungTuChiTiet.Count + " mặt hàng)";
                //if (gvListChungTu.RowCount == 0)
                //{
                //    MessageBox.Show("Không có chứng từ nào thỏa mãn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}
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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            EditOrder(gvListChungTu.FocusedRowHandle);
        }

        private void gListChungTu_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter && gvListChungTu.RowCount > 0)
                {
                    EditOrder(gvListChungTu.FocusedRowHandle);
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
        private void EditOrder(int rowHandle)
        {
            return;
        }


        private void gListChungTu_DoubleClick(object sender, EventArgs e)
        {
            Point pt = gListChungTu.PointToClient(MousePosition);
            GridHitInfo hitInfo = gvListChungTu.CalcHitInfo(pt);
            if (hitInfo.InRow)
                EditOrder(hitInfo.RowHandle);
        }

#endregion


        private void frmBH_TimChungTu_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode==Keys.Enter)   
                {
                    if (!this.gListChungTu.Focused)
                    {
                        SendKeys.Send("{TAB}");
                        e.Handled = true;
                        return;
                    }
                }
                if (e.KeyCode == Keys.F3)
                    this.btnTim_Click(sender, e);
                else if (e.KeyCode == Keys.F6)
                    this.btnCapNhat_Click(sender, e);
                else if (e.KeyCode == Keys.F12)
                    this.btnDong_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }


        private void ResetTrungTam()
        {
            bteKhoXuat.ResetText();
            bteKhoXuat.Tag = null;
        }

        private void bteTrungTam_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (UtilFunctions.bteTrungTam_ButtonClick(sender, e, bteTrungTam, nguoiDung.IdNhanVien))
                ResetTrungTam();
        }

        private void bteTrungTam_KeyDown(object sender, KeyEventArgs e)
        {
            if (UtilFunctions.bteTrungTam_KeyDown(sender, e, bteTrungTam, nguoiDung.IdNhanVien))
                ResetTrungTam();
        }

        private void bteTrungTam_TextChanged(object sender, EventArgs e)
        {
            if (UtilFunctions.bteItem_TextChanged(sender, e, bteTrungTam))
                ResetTrungTam();
        }

        private void bteKhoXuat_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteKhoXuat);
        }

        private void bteKhoXuat_KeyDown(object sender, KeyEventArgs e)
        {
            int idTrungTam = bteTrungTam.Tag != null ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam : 0;
            UtilFunctions.bteKhoXuat_KeyDown(sender, e, bteKhoXuat, idTrungTam, nguoiDung.IdNhanVien);
        }

        private void bteKhoXuat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int idTrungTam = bteTrungTam.Tag != null ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam : 0;
            UtilFunctions.bteKhoXuat_ButtonClick(sender, e, bteKhoXuat, idTrungTam, nguoiDung.IdNhanVien);
        }

        private void gvListChungTu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
        }


        private void cmdExport_Click(object sender, EventArgs e)
        {
            //Common.DevExport2Excel(gvListChungTu, "TonMaVachHienCo");
            Common.Export2ExcelFromDevGrid<LichSuChiTietMaVachInfor>(gvListChungTu, "BCTonMaVachHienCo");
        }

        private void gvListChungTu_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {

        }

        private void bteSanPham_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteSanPham_ButtonClick(sender, e, bteSanPham);
        }

        private void bteSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteSanPham_KeyDown(sender, e, bteSanPham);
        }

        private void bteSanPham_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(bteSanPham.Text)) bteSanPham.Tag = null;
        }

        private void lueNganhHang_TextChanged(object sender, EventArgs e)
        {
            bteSanPham.Tag = null;
            bteSanPham.Text = lueNganhHang.Text;
        }
    }
}