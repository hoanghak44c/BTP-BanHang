using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using CrystalDecisions.Shared;
using System.Threading;
using System.Data.SqlClient;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.BanHang.Reports;
using QLBH.Common;
using QLBH.Common.Objects;
using QLBH.Core.Data;
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmIn_PhieuBaoHanh : DevExpress.XtraEditors.XtraForm
    {
        #region Declare
        private objGridMarkSelection selector = new objGridMarkSelection();
        private InPhieuBaoHanhInfor oDataSource = new InPhieuBaoHanhInfor();
        private ChungTuBanHangInfor ChungTu = new ChungTuBanHangInfor();
        private List<InPhieuBaoHanhChiTietInfor> lstLinhKien = new List<InPhieuBaoHanhChiTietInfor>();
        private List<InPhieuBaoHanhChiTietInfor> lstBaoHanh = new List<InPhieuBaoHanhChiTietInfor>();
        #endregion

        public frmIn_PhieuBaoHanh()
        {
            InitializeComponent();
            //Common.LoadStyle(this);
            //rpt = new rptIn_PhieuBaoHanh();
        }

        public frmIn_PhieuBaoHanh(ChungTuBanHangInfor ctu)
        {
            InitializeComponent();
            ChungTu = ctu;
        }

        private void LoadDataSource()
        {
            if (ChungTu != null)
            {
                txtSoPhieu.Text = ChungTu.SoChungTu;
                mstNgayLapPhieu.Value = ChungTu.NgayLap;
                txtHoTen.Text = ChungTu.HoTen;
                txtDienThoai.Text = ChungTu.DienThoai;
                txtEmail.Text = ChungTu.Email;
                txtMaKH.Text = ChungTu.MaKhach;
                txtDiaChi.Text = ChungTu.DiaChiHoaDon;
                LoadPhieuXuat(ChungTu.IdChungTu);
            }
            //else
            //{
            //    clsUtils.MsgCanhBao("Bạn đã nhập sai số đơn hàng!. Vui lòng nhập lại số đơn hàng");
            //}
        }
        private void LoadPhieuXuat(int idChungTu)
        {
            List<ChungTuBanHangInfor> liPhieuXuat = LapPhieuXuatKhoDataProvider.Instance.LoadAllPhieuXuat(idChungTu);
            gPhieuXuat.DataSource = new BindingList<ChungTuBanHangInfor>(liPhieuXuat);
            if (liPhieuXuat.Count > 0)
            {
                gvPhieuXuat.FocusedRowHandle = 0;
            }            
        }
        private void LoadChiTiet(string soChungTuGoc)
        {
            List<InPhieuBaoHanhChiTietInfor> lst = BhChungDataProvider.Instance.GetPhieuBaoHanhChiTiet(soChungTuGoc);
            lstLinhKien = new List<InPhieuBaoHanhChiTietInfor>();
            foreach (InPhieuBaoHanhChiTietInfor ct in lst)
            {
                List<InPhieuBaoHanhChiTietInfor> lk = BhChungDataProvider.Instance.GetListLinhKienBaoHanh(ct.MaVach, ct.IdSanPham, ct.IdKho, ct.NgayMua);
                lstLinhKien.AddRange(lk);
            }

            grcDanhSach.DataSource = null;
            grcDanhSach.DataSource = lst;
            selector.View = grvDanhSach;
        }

        private void GetListBaoHanh()
        {
            lstBaoHanh = new List<InPhieuBaoHanhChiTietInfor>();
            foreach (InPhieuBaoHanhChiTietInfor pt in selector.selection)
            {
                lstBaoHanh.Add(pt);
                List<InPhieuBaoHanhChiTietInfor> lk = lstLinhKien.FindAll(delegate(InPhieuBaoHanhChiTietInfor m)
                {
                    return pt.MaVach.Equals(m.MaVachGoc) &&
                           pt.IdSanPham == m.IdSanPhamGoc &&
                           pt.IdKho == m.IdKhoGoc;
                });
                lstBaoHanh.AddRange(lk);
            }
        }
        private void InPhieu()
        {
            oDataSource.IdChungTu = ChungTu.IdChungTu;
            oDataSource.SoPhieuXuat = txtSoPhieu.Text.ToUpper().Trim();
            oDataSource.TenDoiTuong = txtHoTen.Text.Trim();
            oDataSource.DienThoai = txtDienThoai.Text.Trim();
            oDataSource.MaRieng = txtMaKH.Text.Trim();
            oDataSource.DiaChi = txtDiaChi.Text.Trim();

            rptInPhieuBH rpt = new rptInPhieuBH(oDataSource, ChungTu.NgayLap);
            rpt.DataSource = lstBaoHanh;
            rpt.ShowPreview();
        }

        private void frmIn_PhieuBaoHanh_Load(object sender, EventArgs e)
        {
            clsUtils.NullColumnDateTimeGrid(repTuNgay);
            clsUtils.NullColumnDateTimeGrid(repDenNgay);
            clsUtils.NullColumnDateTimeGrid(repNgayXuLy);
            LoadDataSource();
        }
        private void cmdThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidData()
        {
            if (txtSoPhieu.Text.Trim().Equals(""))
            {
                MessageBox.Show("Phải nhập vào số phiếu bảo hành!");
                txtSoPhieu.Focus();
                return false;
            }
            if (txtHoTen.Text.Trim().Equals(""))
            {
                MessageBox.Show("Phải nhập vào họ tên khách hàng!");
                txtHoTen.Focus();
                return false;
            }
            
            return true;
        }
        private void cmdIn_Click(object sender, EventArgs e)
        {
            if (!ValidData()) return;

            try {

                if (selector.selection.Count == 0)
                    throw new InvalidOperationException("Bạn chưa chọn sản phẩm nào để in!");
                GetListBaoHanh();
                //CapNhatTheBaoHanh();
                InPhieu();
            }
            catch (System.Exception ex) {
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
        }

        private void CapNhatTheBaoHanh()
        {
            try
            {
                oDataSource.IdChungTu = ChungTu.IdChungTu;
                oDataSource.SoPhieuXuat = txtSoPhieu.Text.ToUpper().Trim();
                oDataSource.TenDoiTuong = txtHoTen.Text.Trim();
                oDataSource.DienThoai = txtDienThoai.Text.Trim();
                oDataSource.MaRieng = txtMaKH.Text.Trim();
                oDataSource.DiaChi = txtDiaChi.Text.Trim();

                foreach (InPhieuBaoHanhChiTietInfor pt in lstBaoHanh)
                {
                    GtidCommand sqlcmd = null;
                    sqlcmd = ConnectionUtil.Instance.GetConnection().CreateCommand();
                    ConnectionUtil.Instance.BeginTransaction();

                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.CommandText = "sp_BaoHanh_Insert";

                    int idPhieuXuat = oDataSource != null ? oDataSource.IdChungTu : 0;
                    string ghichu = "Số phiếu BH: " + txtSoPhieu.Text;
                    ghichu += "\r\n Khách hàng: " + txtHoTen.Text;
                    ghichu += "\r\n Nơi mua hàng: " + pt.NoiMua;

                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.AddWithValue("@IdBaoHanh", 0).Direction = ParameterDirection.Output;
                    sqlcmd.Parameters.AddWithValue("@SerialNumber", pt.MaVach).Direction = ParameterDirection.Input;
                    sqlcmd.Parameters.AddWithValue("@IdPhieuXuat", idPhieuXuat).Direction = ParameterDirection.Input;
                    sqlcmd.Parameters.AddWithValue("@NgayBatDau", pt.NgayMua).Direction = ParameterDirection.Input;
                    sqlcmd.Parameters.AddWithValue("@NgayKetThuc", pt.DenNgay).Direction = ParameterDirection.Input;
                    sqlcmd.Parameters.AddWithValue("@GhiChu", ghichu).Direction = ParameterDirection.Input;

                    DBTools.InsertRecord(sqlcmd);

                    ConnectionUtil.Instance.CommitTransaction();
                    Common.LogAction("Cập nhật phiếu bảo hành", "Số phiếu bảo hành = " + txtSoPhieu.Text, Declare.IdKho);
                }
            }
            catch (System.Exception ex)
            {
                ConnectionUtil.Instance.RollbackTransaction();
#if DEBUG
                //MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                //MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
            //return -1;
        }

        private void txtSoPhieu_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btnTimOrderKH_Click(sender, null);
            }

        }

        private void btnTimOrderKH_Click(object sender, EventArgs e)
        {
            ChungTuBanHangInfor ctu = BanHangDataProvider.Instance.LoadChungTuBySoChTu(txtSoPhieu.Text);
            if (ctu != null)
            {
                LoadDataSource();
            }
            else
            {
                clsUtils.MsgCanhBao("Bạn đã nhập sai số đơn hàng!. Vui lòng nhập lại số đơn hàng");
            }

        }

        private void gvPhieuXuat_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ChungTuBanHangInfor phieuXuat = (ChungTuBanHangInfor)gvPhieuXuat.GetRow(gvPhieuXuat.FocusedRowHandle);
            if (phieuXuat != null)
            {
                LoadChiTiet(phieuXuat.SoChungTu);
            }
        }
        //protected override void OnSetParameterFields(ParameterFields myParams){

        //    myParams.Clear();
        //    ut.SetParameterReport(myParams, "SoPhieu", txtSoPhieu.Text);
        //    ut.SetParameterReport(myParams,"ThoiHanBaoHanh",txtThoiHanBH.Text);
        //    ut.SetParameterReport(myParams, "TuNgay_Ngay", mstNgayXuat.Value.Day);
        //    ut.SetParameterReport(myParams, "TuNgay_Thang", mstNgayXuat.Value.Month);
        //    ut.SetParameterReport(myParams, "TuNgay_Nam", mstNgayXuat.Value.Year);
        //    ut.SetParameterReport(myParams, "DenNgay_Ngay", mstDenNgay.Value.Day);
        //    ut.SetParameterReport(myParams, "DenNgay_Thang", mstDenNgay.Value.Month);
        //    ut.SetParameterReport(myParams, "DenNgay_Nam", mstDenNgay.Value.Year);
        //    ut.SetParameterReport(myParams, "HoTenKH", txtHoTen.Text);
        //    ut.SetParameterReport(myParams,"DiaChiKH",txtDiaChi.Text);
        //    ut.SetParameterReport(myParams,"DienThoaiKH",txtDienThoai.Text);
        //    ut.SetParameterReport(myParams,"EmailKH",txtEmail.Text);
        //    ut.SetParameterReport(myParams,"MaKH",txtMaKH.Text);
        //    ut.SetParameterReport(myParams,"Model",txtModel.Text);
        //    ut.SetParameterReport(myParams,"SerialNumber",txtSerialNumber.Text);
        //    ut.SetParameterReport(myParams,"NgayMua",txtNgayMua.Text);
        //    ut.SetParameterReport(myParams,"NoiMua",txtNoiMua.Text);
        //}

        //protected override string OnSetSqlParameters(string cmdTextFormatString)
        //{
        //    return cmdTextFormatString;
        //}

        //protected override void OnLoadReport()
        //{
        //    string sql = string.Format(@"SELECT top 1 * from tbl_DM_Kho");
        //    base.SetParameterFields();
        //    base.SetSqlParameters(sql, CommandType.Text, "vPhieuBaoHanh");
        //}

        //private void txtThoiHanBH_TextChanged(object sender, EventArgs e)
        //{
        //    int thang = 0;
        //    try
        //    {
        //        thang = Common.IntValue(txtThoiHanBH.Text);
        //    }
        //    catch { }
        //    if (thang == 0 && txtThoiHanBH.Text != "")
        //    {
        //        MessageBox.Show("Nhập sai thời gian bảo hành. Hãy nhập lại");
        //        txtThoiHanBH.Text = "";
        //        txtThoiHanBH.Focus();
        //        return;
        //    }
        //    mstDenNgay.Value = mstNgayXuat.Value.AddMonths(thang);
        //}

        //private void cboSanPham_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    txtModel.Text = drMV[cboSanPham.SelectedIndex].Cells["TenSanPham"].Value.ToString();
        //    txtSerialNumber.Text = drMV[cboSanPham.SelectedIndex].Cells["MaVach"].Value.ToString();
        //}

        //private void mstNgayXuat_ValueChanged(object sender, EventArgs e)
        //{
        //    txtNgayMua.Text = mstNgayXuat.Text;
        //    txtThoiHanBH_TextChanged(sender, e);
        //}
        
    }
}