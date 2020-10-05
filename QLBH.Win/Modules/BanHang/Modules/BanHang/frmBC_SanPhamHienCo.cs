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
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.KhoHang;
using QLBanHang.Modules.KhoHang.Infors;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.BanHang.Bussiness;
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBC_SanPhamHienCo : DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"
        private List<TonSanPhamHienCoInfor> liChungTuChiTiet = new List<TonSanPhamHienCoInfor>();
        private List<TonSanPhamHienCoInfor> liTimKiem = new List<TonSanPhamHienCoInfor>();
        public TimKiemChungTuChiTietFilterInfor filter = new TimKiemChungTuChiTietFilterInfor();
        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
        private int SoLuongHienTai = 0;

#endregion

#region "Các phương thức khởi tạo"
        public frmBC_SanPhamHienCo()
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
                CommonFuns.Instance.LoadNganhHang(lueNganhHang, nguoiDung, true);
                CommonFuns.Instance.LoadChonTrungTam(bteTrungTam, nguoiDung);
                //TimKiemChungTu();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            SoLuongHienTai = 0;
            SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
            liChungTuChiTiet = new List<TonSanPhamHienCoInfor>(); 

            TimKiemChungTu();
        }

        private void GetFilter()
        {
            if (filter == null)
                filter = new TimKiemChungTuChiTietFilterInfor();
            filter.IdTrungTam = CommonFuns.Instance.GetIdTrungTam(bteTrungTam, nguoiDung);
            filter.IdKho = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : -1;
            filter.SanPham = txtSanPham.Text.Trim();
            filter.MaVach = txtMaVach.Text.Trim();
            filter.Nganh = lueNganhHang.EditValue.ToString();
            filter.SoTon = CommonFuns.Instance.GetSoTon();
            filter.IdNhanVien = nguoiDung.IdNhanVien;
        }
        private void LoadDuLieu()
        {
            frmProgress.Instance.Value = 0;
            
            frmProgress.Instance.MaxValue = 1;
            
            filter.SoBatDau = -1;

            filter.SoKetThuc = -1;

            if (!String.IsNullOrEmpty(filter.SanPham))
            {
                var liNganh = new List<TimKiemItemInfor>();

                if(String.IsNullOrEmpty(filter.Nganh) || filter.Nganh == "-1")

                    liNganh.AddRange((List<TimKiemItemInfor>) lueNganhHang.Properties.DataSource);

                else

                    liNganh.Add(new TimKiemItemInfor {Ma = filter.Nganh});

                DMSanPhamInfo sanPhamInfo = DmSanPhamProvider.Instance.GetSanPhamByMa(filter.SanPham);
                
                if(sanPhamInfo != null && liNganh.Exists(delegate(TimKiemItemInfor match) { return match.Ma == sanPhamInfo.Nganh; }))
                {
                    liTimKiem = BaoCaoTonHienThoiDataProvider.Instance.TimKiemTonChiTietSanPhamPg(filter);

                    liChungTuChiTiet.AddRange(liTimKiem);

                    if (InvokeRequired)

                        Invoke((MethodInvoker)delegate { gListChungTu.RefreshDataSource(); });

                    else

                        gListChungTu.RefreshDataSource();                         
                }
            }
            else if(filter.IdTrungTam > 0 && filter.IdKho > 0 && !String.IsNullOrEmpty(filter.Nganh)
                && filter.Nganh != "-1")
            {
                //filter.SoBatDau = SoLuongHienTai;
                //filter.SoKetThuc = SoLuongTimKiem != -1 ? SoLuongHienTai + SoLuongTimKiem : -1;
                liTimKiem = BaoCaoTonHienThoiDataProvider.Instance.TimKiemTonChiTietSanPhamPg(filter);

                liChungTuChiTiet.AddRange(liTimKiem);

                if (InvokeRequired)
                
                    Invoke((MethodInvoker) delegate { gListChungTu.RefreshDataSource(); });
                
                else
                
                    gListChungTu.RefreshDataSource(); 
            } 
            else
            {
                var liNganh = new List<TimKiemItemInfor>();

                if(String.IsNullOrEmpty(filter.Nganh) || filter.Nganh == "-1")

                    liNganh.AddRange((List<TimKiemItemInfor>) lueNganhHang.Properties.DataSource);

                else

                    liNganh.Add(new TimKiemItemInfor {Ma = filter.Nganh});

                var liKho = new List<DMKhoSInfo>();
                
                if (filter.IdKho == -1)
                {
                    liKho.AddRange(DMKhoDataProvider.Instance.GetListIdKhoTon(filter.IdTrungTam));
                }
                else
                {
                    liKho.Add(new DMKhoSInfo {IdKho = filter.IdKho, IdTrungTam = filter.IdTrungTam});
                }
                
                frmProgress.Instance.MaxValue = liKho.Count * liNganh.Count;

                foreach (DMKhoSInfo dmKhoSInfo in liKho)
                {
                    filter.IdKho = dmKhoSInfo.IdKho;

                    filter.IdTrungTam = dmKhoSInfo.IdTrungTam;

                    var liNganhTon = DmNganhDataProvider.Instance.GetListNganhTonKho(filter.IdKho);

                    foreach (TimKiemItemInfor timKiemItemInfor in liNganh)
                    {
                        if(liNganhTon.Contains(timKiemItemInfor.Ma))
                        {
                            filter.Nganh = timKiemItemInfor.Ma;

                            liTimKiem = BaoCaoTonHienThoiDataProvider.Instance.TimKiemTonChiTietSanPhamPg(filter);
                        
                            liChungTuChiTiet.AddRange(liTimKiem);

                            if (InvokeRequired)
                            
                                Invoke((MethodInvoker)delegate { gListChungTu.RefreshDataSource(); });
                            
                            else
                            
                                gListChungTu.RefreshDataSource();
                        }

                        frmProgress.Instance.Value += 1;
                    }
                }
            }

            frmProgress.Instance.Description = "Đã xong";
            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            frmProgress.Instance.IsCompleted = true;
        }
        private void TimKiemChungTu()
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

                //gListChungTu.DataSource = new BindingList<TonSanPhamHienCoInfor>(liChungTuChiTiet); 
                //gvListChungTu.Columns["ParentName"].GroupIndex = 0;
                gvListChungTu.ExpandAllGroups();
                selector.View = gvListChungTu;
                selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                selector.CheckMarkColumn.VisibleIndex = 0;
                //((BindingList<TonSanPhamHienCoInfor>)gListChungTu.DataSource).ResetBindings();
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
            Common.Export2ExcelFromDevGrid<TonSanPhamHienCoInfor>(gvListChungTu, "BCSanPhamHienCo");
        }

        private void gvListChungTu_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {

        }

        private void TonChiTiet_Click(object sender, EventArgs e)
        {
            TonSanPhamHienCoInfor sp = (TonSanPhamHienCoInfor)gvListChungTu.GetFocusedRow();
            if (sp != null)
            {
                TonInfoBase ton = new TonInfoBase()
                                      {
                                          IdKho = sp.IdKho,
                                          IdTrungTam = 0,
                                          IdSanPham = sp.IdSanPham
                                      };
                Form frm = new frmThongKe_TonChiTietMaVach(ton);
                frm.ShowDialog();
            }
        }

        private void ChungTuLienQuan_Click(object sender, EventArgs e)
        {
            TonSanPhamHienCoInfor sp = (TonSanPhamHienCoInfor)gvListChungTu.GetFocusedRow();
            if (sp != null)
            {
                TonInfoBase ton = new TonInfoBase()
                {
                    IdKho = sp.IdKho,
                    IdTrungTam = sp.IdTrungTam,
                    IdSanPham = sp.IdSanPham
                };

                Form frm = new frmThongKe_ChungTuLienQuan(ton);
                frm.ShowDialog();
            }
        }

        private void ChiTietHangTrungChuyen_Click(object sender, EventArgs e)
        {
            TonSanPhamHienCoInfor sp = (TonSanPhamHienCoInfor)gvListChungTu.GetFocusedRow();
            if (sp != null)
            {
                TonInfoBase ton = new TonInfoBase()
                {
                    IdKho = sp.IdKho,
                    IdTrungTam = sp.IdTrungTam,
                    IdSanPham = sp.IdSanPham
                };

                Form frm = new frmThongKe_ChiTietHangTrungChuyen(ton);
                frm.ShowDialog();
            }
        }
    }
}