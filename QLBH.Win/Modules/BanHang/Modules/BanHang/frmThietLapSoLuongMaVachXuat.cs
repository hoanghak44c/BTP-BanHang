using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;
using QLBH.Core.Data;
using QLBH.Core.Form;
using QLBH.Core.Providers;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmThietLapSoLuongMaVachXuat : DevExpress.XtraEditors.XtraForm
    {
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();


        public frmThietLapSoLuongMaVachXuat()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        private void frmKhoHienTai_Load(object sender, EventArgs e)
        {
            LoadKho();
            LoadNganhHang();
            LoadData();
        }
        private void LoadNganhHang()
        {
            int idNND = (nguoiDung.SupperUser == 1 || nguoiDung.SaleAdmin == 1) ? -1 : nguoiDung.IdNhomNguoiDung;
            List<TimKiemItemInfor> liNganh = TimKiemItemDataProvider.Instance.GetAllItemsByType(idNND, 1, -1, -1);//type=1: nganh hang
            liNganh.Add(new TimKiemItemInfor{Ma= "ALL", Ten="Tất cả"});
            lueNganhHang.Properties.DataSource = null;
            if (liNganh.Count > 0)
            {
                lueNganhHang.Properties.Columns.Clear();
                lueNganhHang.Properties.Columns.Add(new LookUpColumnInfo("Ten", "Tên"));
                lueNganhHang.Properties.DataSource = liNganh;
                lueNganhHang.Properties.DisplayMember = "Ten";
                lueNganhHang.Properties.ValueMember = "Ma";
                lueNganhHang.EditValue = liNganh[liNganh.Count - 1].Ma;
            }            
        }
        private void LoadKho()
        {
            DMKhoInfo KhoSelected = DMKhoDataProvider.GetKhoByIdInfo(Declare.IdKho);
            if (KhoSelected != null)
            {
                bteKhoXuat.Text = KhoSelected.TenKho;
                bteKhoXuat.Tag = KhoSelected;
            }
        }

        private void frmKhoHienTai_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ShowPhieuXuat();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int idKho = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : -1;
                string nganh = lueNganhHang.EditValue != null ? lueNganhHang.EditValue.ToString() : "";
                int soLuong = Common.IntValue(txtSoTon.Text);
                ConnectionUtil.Instance.BeginTransaction();

                SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(), CommandType.Text,
                                          String.Format("delete from tbl_Kho_NganhHang where idkho = {0} and (MaNganhHang = '{1}' or '{1}' = 'ALL')", idKho, nganh));

                SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(), CommandType.Text,
                                         nganh != "ALL" ? String.Format("insert into tbl_Kho_NganhHang values({0},'{1}',{2})", idKho, nganh, soLuong)
                                         : String.Format("insert into tbl_Kho_NganhHang select {0},ma,{1} from tbl_dm_dl_nganh", idKho, soLuong));

                ConnectionUtil.Instance.CommitTransaction();
                MessageBox.Show("Thiết lập số lượng mã vạch được xuất thành công!");
            }
            catch (Exception ex)
            {
                EventLogProvider.Instance.WriteLog(ex.ToString()
                                    + "\nUser: " + nguoiDung.TenDangNhap
                                    + "\nMay: " + Declare.TenMay,
                                    this.Name);
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bteKhoXuat_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteKhoXuat);
            LoadData();
        }

        private void bteKhoXuat_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteKhoXuat_KeyDown(sender, e, bteKhoXuat, -1,
                                             nguoiDung.QuanTri == 1 || nguoiDung.SupperUser == 1
                                                 ? -1
                                                 : nguoiDung.IdNhanVien);
            LoadData();
        }

        private void bteKhoXuat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteKhoXuat_ButtonClick(sender, e, bteKhoXuat, -1,
                                                 nguoiDung.QuanTri == 1 || nguoiDung.SupperUser == 1
                                                     ? -1
                                                     : nguoiDung.IdNhanVien);
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                int idKho = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : -1;
                string nganh = lueNganhHang.EditValue != null ? lueNganhHang.EditValue.ToString() : "";
                string sql =
                    String.Format("select SoLuongMaVach from tbl_Kho_NganhHang where (idkho = {0} or {0} = -1) and (MaNganhHang = '{1}' or '{1}' = 'ALL')",
                                  idKho, nganh);
                txtSoTon.Text = DBTools.getValue(sql);
            }
            catch
            {
                txtSoTon.Text = "";
            }
        }

        private void lueNganhHang_EditValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}