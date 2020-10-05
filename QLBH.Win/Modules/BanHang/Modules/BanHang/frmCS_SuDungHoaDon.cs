using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QLBanHang.Modules.BanHang;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmCS_SuDungHoaDon : Form
    {
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private List<SuDungHoaDonInfor> liHoaDonDeleted = new List<SuDungHoaDonInfor>();
        public frmCS_SuDungHoaDon()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        private void frmMoSo_Load(object sender, EventArgs e)
        {
            txtNhanVien.Text = nguoiDung.TenNhanVien;
            LoadAllHoaDon();
        }

        public void LoadAllHoaDon()
        {
            try
            {
                List<SuDungHoaDonInfor> liSuDungHD =
                    SuDungHoaDonDataProvider.Instance.SearchSuDungHoaDonByUser(nguoiDung.IdNhanVien, "", 0, 0);
                                                                               /*txtKyHieu.Text.Trim(),
                                                                               Common.IntValue(txtSoHoaDon.Text.Trim()),
                                                                               Common.Bool2Int(chkChuaSuDung.Checked));*/

                gHoaDon.DataSource = new BindingList<SuDungHoaDonInfor>(liSuDungHD);
            }
            catch (Exception)
            {
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            string str = "";
            try
            {
                //xoa cac hoa don bi xoa
                foreach (SuDungHoaDonInfor hde in liHoaDonDeleted)
                {
                    if (hde.IdQuyen != 0)
                        SuDungHoaDonDataProvider.Instance.Delete(hde);
                }
                
                //cap nhat danh sach hoa don hien co
                foreach (SuDungHoaDonInfor hd in (BindingList<SuDungHoaDonInfor>)gHoaDon.DataSource)
                {
                    if (!hd.Modified) continue;

                    if (String.Format("{0}({1};{2})", hd.KyHieu, hd.SoBatDau, hd.SoKetThuc).Length > 30)
                    {
                        MessageBox.Show(String.Format("Khai báo sử dụng hóa đơn {0} không hợp lệ!",
                            String.Format("{0}({1};{2})", hd.KyHieu, hd.SoBatDau, hd.SoKetThuc)));
                        continue;
                    }

                    if (ValidHoaDon2(hd.IdNhanVien, hd.IdQuyen, hd.KyHieu, hd.SoBatDau, hd.SoKetThuc))
                    {
                        if (hd.IdQuyen == 0)
                            SuDungHoaDonDataProvider.Instance.Insert(hd);
                        else
                            SuDungHoaDonDataProvider.Instance.Update(hd);
                    }
                }

                MessageBox.Show("Cập nhật sử hóa đơn thành công", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cmdXoaChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvHoaDon.FocusedRowHandle < 0) return;
                if (MessageBox.Show("Bạn có chắc chắn xóa mục này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (gvHoaDon.GetSelectedRows().Length == 0 && gvHoaDon.FocusedRowHandle >=0)
                    {
                        SuDungHoaDonInfor hd = (SuDungHoaDonInfor)gvHoaDon.GetRow(gvHoaDon.FocusedRowHandle);
                        if (hd != null && hd.SoConLai <= 0) liHoaDonDeleted.Add(hd);                        
                    }
                    else
                    {
                        foreach (int t in gvHoaDon.GetSelectedRows())
                        {
                            SuDungHoaDonInfor hd = (SuDungHoaDonInfor)gvHoaDon.GetRow(t);
                            if (hd != null) liHoaDonDeleted.Add(hd);
                        }                        
                    }
                    
                    gvHoaDon.DeleteSelectedRows();
                }
            }
            catch { }
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            frmCS_KhaiBaoHoaDon frm = new frmCS_KhaiBaoHoaDon();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (ValidHoaDon(nguoiDung.IdNhanVien, 0, frm.KyHieu, frm.SoBatDau, frm.SoKetThuc))
                {
                    SuDungHoaDonInfor hoadon = new SuDungHoaDonInfor();

                    hoadon.IdNhanVien = nguoiDung.IdNhanVien;
                    hoadon.KyHieu = frm.KyHieu;
                    hoadon.SoBatDau = frm.SoBatDau;
                    hoadon.SoKetThuc = frm.SoKetThuc;
                    hoadon.SoHienTai = frm.SoHienTai;
                    hoadon.SoConLai = frm.SoConLai;
                    hoadon.Modified = true;

                    ((BindingList<SuDungHoaDonInfor>)gHoaDon.DataSource).Add(hoadon);
                    ((BindingList<SuDungHoaDonInfor>)gHoaDon.DataSource).ResetBindings();
                }
            }
        }

        private void gvHoaDon_DoubleClick(object sender, EventArgs e)
        {
            Point pt = gHoaDon.PointToClient(MousePosition);
            GridHitInfo hitInfo = gvHoaDon.CalcHitInfo(pt);
            if (hitInfo.InRow)
                EditObject(hitInfo.RowHandle);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                EditObject(gvHoaDon.FocusedRowHandle);
            }
            catch { }
        }
        private void EditObject(int rowHandle)
        {
            if (rowHandle < 0) return;
            SuDungHoaDonInfor hoadon = (SuDungHoaDonInfor)gvHoaDon.GetRow(rowHandle);
            if (hoadon.SoConLai > 0)
                EditObject(hoadon);
            else
            {
                MessageBox.Show("Số hóa đơn này đã được dùng, không thể sửa lại");
            }

        }
        private void EditObject(SuDungHoaDonInfor hoadon)
        {
            frmCS_KhaiBaoHoaDon frm = new frmCS_KhaiBaoHoaDon(hoadon);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (ValidHoaDon(hoadon.IdNhanVien, hoadon.IdQuyen, frm.KyHieu, frm.SoBatDau, frm.SoKetThuc))
                {
                    hoadon.KyHieu = frm.KyHieu;
                    hoadon.SoBatDau = frm.SoBatDau;
                    hoadon.SoKetThuc = frm.SoKetThuc;
                    hoadon.SoHienTai = frm.SoHienTai;
                    hoadon.SoConLai = frm.SoConLai;
                    hoadon.Modified = true;
                }
            }
        }

        //private void UpdateHoaDon(SuDungHoaDonInfor hoadon, bool isAdd)
        //{
        //    foreach (SuDungHoaDonInfor hd in (BindingList<SuDungHoaDonInfor>)gHoaDon.DataSource)
        //    {
        //        if ((hd.IdQuyen != hoadon.IdQuyen || hd.IdQuyen == 0 && hoadon.IdQuyen == 0)
        //            && hd.KyHieu.Equals(hoadon.KyHieu) && (hoadon.SoBatDau <= hd.SoKetThuc && hoadon.SoBatDau >= hd.SoBatDau ||
        //            hoadon.SoKetThuc >= hd.SoBatDau && hoadon.SoKetThuc <= hd.SoKetThuc))
        //        {
        //            MessageBox.Show("Số hóa đơn này đã được khai báo");
        //            return;
        //        }
        //    }
        //    if (isAdd)
        //        ((BindingList<SuDungHoaDonInfor>)gHoaDon.DataSource).Add(hoadon);
        //}

        private bool ValidHoaDon(int idNhanVien, int idQuyen, string kyHieu, int soBatDau, int soKetThuc)
        {
            //kiem tra trong danh sach hoa don cua cung user
            foreach (SuDungHoaDonInfor hd in (BindingList<SuDungHoaDonInfor>)gHoaDon.DataSource)
            {
                if ((hd.IdQuyen != idQuyen || hd.IdQuyen == 0 && idQuyen == 0) &&
                    hd.KyHieu.Equals(kyHieu) && (hd.SoBatDau <= soBatDau && soBatDau <=hd.SoKetThuc ||
                    hd.SoBatDau <= soKetThuc && soKetThuc <= hd.SoKetThuc || soBatDau <= hd.SoBatDau && hd.SoBatDau <= soKetThuc ||
                    soBatDau <= hd.SoKetThuc && hd.SoKetThuc <= soKetThuc))
                {
                    MessageBox.Show(String.Format("Số hóa đơn [{0}, {1}] và [{2}, {3}] không hợp lệ (bị trùng nhau)", soBatDau, soKetThuc, hd.SoBatDau, hd.SoKetThuc));
                    return false;
                }
            }

            //kiem tra trong danh sach hoa don cua user khac
            if (SuDungHoaDonDataProvider.Instance.IsUsedByUser(idNhanVien, kyHieu, soBatDau, soKetThuc))
            {
                MessageBox.Show(String.Format("Số hóa đơn [{0}, {1}] đã được sử dụng bởi người khác", soBatDau, soKetThuc));
                return false;                
            }

            if (SuDungHoaDonDataProvider.Instance.IsUsedByQuyen(idQuyen, kyHieu, soBatDau, soKetThuc))
            {
                MessageBox.Show(String.Format("Số hóa đơn [{0}, {1}] đã được sử dụng bởi quyển khác", soBatDau, soKetThuc));
                return false;
            }

            return true;
        }

        private bool ValidHoaDon2(int idNhanVien, int idQuyen, string kyHieu, int soBatDau, int soKetThuc)
        {
            if (SuDungHoaDonDataProvider.Instance.IsUsedByQuyen(idQuyen, kyHieu, soBatDau, soKetThuc))
            {
                MessageBox.Show(String.Format("Số hóa đơn [{0}, {1}] đã được sử dụng bởi quyển khác", soBatDau, soKetThuc));
                return false;
            }

            //kiem tra trong danh sach hoa don cua user khac
            if (SuDungHoaDonDataProvider.Instance.IsUsedByUser(idNhanVien, kyHieu, soBatDau, soKetThuc))
            {
                MessageBox.Show(String.Format("Số hóa đơn [{0}, {1}] đã được sử dụng bởi người khác", soBatDau, soKetThuc));
                return false;
            }

            return true;
        }

        //private void btnTim_Click(object sender, EventArgs e)
        //{
        //    LoadAllHoaDon();
        //}
    }
}