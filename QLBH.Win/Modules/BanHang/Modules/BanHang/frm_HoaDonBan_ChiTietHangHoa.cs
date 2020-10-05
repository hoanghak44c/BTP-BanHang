using System;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using QLBH.Common;
//using QLBanHang.Class;

namespace QLBanHang.Modules.BanHang
{
    public partial class frm_HoaDonBan_ChiTietHangHoa : Form
    {
        int IdChungTuChiTiet = 0;
        int _IdSanPham = 0;
        int rowIndex;
        double _DonGia = 0;
        string _tableChiTietHangHoa= String.Empty;
        DataGridViewCell SoluongCell;
        DataTable dtChungTuChiTietHangHoa;
        ArrayList arrTemp;
        bool TrungMaVach = false;

        public frm_HoaDonBan_ChiTietHangHoa()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        public frm_HoaDonBan_ChiTietHangHoa(int pIdSanPham, int pIdChungTuChiTiet, DataGridViewCell pSoluong, ArrayList pArrTemp, string tableChiTietHangHoa)
        {
            InitializeComponent();
            this._IdSanPham = pIdSanPham;
            this.IdChungTuChiTiet = pIdChungTuChiTiet;
            this.SoluongCell = pSoluong;
            rowIndex = pSoluong.RowIndex;
            this.arrTemp = pArrTemp;
            this._tableChiTietHangHoa = tableChiTietHangHoa;
        }

        private void frm_HoaDonBan_ChiTietHangHoa_Load(object sender, EventArgs e)
        {
            LayMaVach();
            if (IdChungTuChiTiet > 0) {
                string sql = "Select ctct.*, sp.MaSanPham, sp.TenSanPham from " + this._tableChiTietHangHoa + " ctct";
                sql += " inner join tbl_SanPham sp on sp.IdSanPham = ctct.IdSanPham";
                sql += " where ctct.IdChiTiet=" + IdChungTuChiTiet;
                DataTable dt = DBTools.getData("Temp", sql).Tables["Temp"];
                if (dt != null) {
                    lblMa.Text = dt.Rows[0]["MaSanPham"].ToString() + " - " + dt.Rows[0]["TenSanPham"].ToString();
                    _DonGia = dt.Rows[0]["DonGia"] == System.DBNull.Value ? 0 : Convert.ToDouble(dt.Rows[0]["DonGia"]);
                    lblDonGia.Text = Common.Double2Str(_DonGia);
                    lblTyLeChietKhau.Text = dt.Rows[0]["TyLeChietKhau"] == System.DBNull.Value ? "0" : dt.Rows[0]["TyLeChietKhau"].ToString();
                    lblTongSoLuong.Text = dt.Rows[0]["SoLuong"] == System.DBNull.Value ? "0" : dt.Rows[0]["SoLuong"].ToString();
                    lblTongTienChietKhau.Text = Common.Double2Str(dt.Rows[0]["TienChietKhau"] == System.DBNull.Value ? 0 : Convert.ToDouble(dt.Rows[0]["TienChietKhau"]));
                    lblTongThanhTien.Text = Common.Double2Str(dt.Rows[0]["ThanhTien"] == System.DBNull.Value ? 0 : Convert.ToDouble(dt.Rows[0]["ThanhTien"]));
                }
            }
            else {
                string sql = String.Format("select * from vSanPham where IdSanPham={0} and IdTrungTam={1} ", _IdSanPham, Declare.IdTrungTam);
                DataTable dt = DBTools.getData("Temp", sql).Tables["Temp"];
                if (dt != null & dt.Rows.Count > 0) {
                    lblMa.Text = dt.Rows[0]["MaSanPham"].ToString() + " - " + dt.Rows[0]["TenSanPham"].ToString();
                    lblTyLeChietKhau.Text = dt.Rows[0]["TyLeChietKhau"] == System.DBNull.Value ? "0" : dt.Rows[0]["TyLeChietKhau"].ToString();

                    double dongia = dt.Rows[0]["DonGiaChuaVAT"] == System.DBNull.Value ? 0 : Convert.ToDouble(dt.Rows[0]["DonGiaChuaVAT"]);
                    lblDonGia.Text = Common.Double2Str(dongia);                    
                    
                    lblTongSoLuong.Text = "1";

                    double tienchietkhau = dt.Rows[0]["TienChietKhau"] == System.DBNull.Value ? 0 : Convert.ToDouble(dt.Rows[0]["TienChietKhau"]);
                    lblTongTienChietKhau.Text = Common.Double2Str(tienchietkhau);
                    
                    lblTongThanhTien.Text = Common.Double2Str(dongia - tienchietkhau);
                }
            }

            object tmp = DBTools.ExecuteScalar(String.Format("select TrungMaVach from tbl_SanPham where IdSanPham={0}", _IdSanPham));
            if (tmp != DBNull.Value)
                TrungMaVach = (bool)tmp;


            if (this.arrTemp != null) {
                foreach (DataTable dtTemp in this.arrTemp) {
                    if (dtTemp != null && dtTemp.TableName == rowIndex.ToString()) {
                        dtChungTuChiTietHangHoa = dtTemp;
                        break;
                    }
                }
            }
            if (dtChungTuChiTietHangHoa != null) {
                dgvList.DataSource = dtChungTuChiTietHangHoa;
                dgvList.Refresh();
            }
            lblTongSoLuong.Text = TongSoLuong().ToString();
            lblTongTienChietKhau.Text = Common.Double2Str(TongTienChietKhau());
            lblTongThanhTien.Text = Common.Double2Str(TongThanhTien());
        }

        private bool LayMaVach()
        {
            string str;
            str = "Select DISTINCT hh.MaVach From tbl_HangHoa_Chitiet hh " +
                  " Where hh.IdKho in (Select DISTINCT kh.IdKho From tbl_DM_Kho kh " +
                  " inner Join tbl_Kho_NhanVien knv On kh.IdKho = knv.IdKho " +
                  " inner Join tbl_DM_NhanVien nv On knv.IdNhanVien = nv.IdNhanVien " +
                  " Inner Join tbl_DM_NguoiDung nd On nv.IdNhanVien = nd.IdNhanVien " +
                  " where kh.SuDung =1 and nd.IdNguoiDung = " + Declare.UserId + ")" +
                  " and hh.IdSanPham= " + _IdSanPham.ToString() +
                  " and hh.TrangThai in (1,2,3,5)  order by hh.MaVach ASC";
            DataTable dtMaVach = DBTools.getData("tbl_HangHoa_Chitiet", str).Tables["tbl_HangHoa_Chitiet"];
            if (dtMaVach == null)
                return false;
            else {
                // AutoCompleteStringCollection 
                AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                for (int i = 0; i < dtMaVach.Rows.Count; i++)
                    data.Add(dtMaVach.Rows[i]["MaVach"].ToString());

                txtMaVach.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtMaVach.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtMaVach.AutoCompleteCustomSource = data;

                return true;
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            try {
                if (dtChungTuChiTietHangHoa != null) {
                    foreach (DataTable dt in this.arrTemp) {
                        if (dt.TableName == rowIndex.ToString()) {
                            this.arrTemp.Remove(dt);
                            break;
                        }
                    }
                    this.arrTemp.Add(dtChungTuChiTietHangHoa);
                }

                int tmp = 0;
                foreach (DataGridViewRow dgr in dgvList.Rows) {
                    tmp += int.Parse(dgr.Cells["SoLuong"].Value.ToString());
                }
                this.SoluongCell.Value = tmp;
                this.DialogResult = DialogResult.OK;
            }
            catch (System.Exception ex) {
#if DEBUG
                MessageBox.Show(ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show(ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "Select hh.IdChiTiet IdChiTietHangHoa, hh.IdSanPham, hh.MaVach, dvt.TenDonViTinh, 1 SoLuong, sp.TienChietKhau, sp.DonGiaChuaVAT - sp.TienChietKhau ThanhTien  from tbl_HangHoa_ChiTiet hh";
            sql += " inner join vSanPham sp on sp.IdSanPham = hh.IdSanPham and IdTrungTam={0}";
            sql += " inner join tbl_DM_DonViTinh dvt on sp.IdDonViTinh= dvt.IdDonViTinh";
            sql += " where hh.MaVach = N'{1}' and sp.IdSanPham={2}";
            DataTable dt = DBTools.getData(rowIndex.ToString(), String.Format(sql, Declare.IdTrungTam, txtMaVach.Text, _IdSanPham)).Tables[rowIndex.ToString()];
            if (dt == null) {
                MessageBox.Show("Không tồn tại sản phẩm có mã vạch này");
                return;
            }

            sql = String.Format("select TrungMaVach from tbl_HangHoa_ChiTiet hhct "
                    + "inner join tbl_SanPham sp on sp.IdSanPham=hhct.IdSanPham "
                    + "where hhct.MaVach=N'{0}'", txtMaVach.Text);
            bool TrungMaVach = false;
            bool.TryParse(DBTools.getValue(sql), out TrungMaVach);

            foreach (DataGridViewRow dgr in dgvList.Rows) {
                if (dgr.Cells["MaVach"].Value.ToString().Equals(txtMaVach.Text)) {
                    if (!TrungMaVach) {
                        MessageBox.Show("Loại sản phẩm này không được phép nhập trùng mã vạch");
                        return;
                    }
                    dgvList.CurrentCell = dgr.Cells["SoLuong"];
                    dgvList.CurrentCell.Value = Common.IntValue(dgvList.CurrentCell.Value.ToString()) + 1;
                    return;
                }
            }

            if (dt != null && dt.Rows.Count > 0) {
                bool existed = false;
                DataTable currentTable = null;
                foreach (DataTable dtemp in this.arrTemp) {
                    if (dtemp.TableName == rowIndex.ToString()) {
                        currentTable = dtemp;
                        existed = true;
                        break;
                    }
                }
                object[] fields = {
                        dt.Rows[0]["IdChiTietHangHoa"],
                        dt.Rows[0]["IdSanPham"],
                        dt.Rows[0]["MaVach"],
                        dt.Rows[0]["TenDonViTinh"],
                        dt.Rows[0]["SoLuong"],
                        dt.Rows[0]["TienChietKhau"],
                        dt.Rows[0]["ThanhTien"]                       
                    };

                if (existed) {
                    currentTable.Rows.Add(fields);
                    dgvList.DataSource = currentTable;
                    dgvList.Refresh();
                }
                else {
                    this.arrTemp.Add(dt);
                    dgvList.DataSource = dt;
                    dgvList.Refresh();
                }
            }
        }

        private void dgvList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvList.Columns[e.ColumnIndex].Name == "SoLuong") {
                double tienChietKhau = 0;
                if (Double.TryParse(DBTools.getValue("select TienChietKhau from tbl_SanPham where IdSanPham=" + _IdSanPham), out tienChietKhau)) {
                    dgvList.CurrentRow.Cells["TienChietKhau"].Value = Common.IntValue(dgvList.CurrentRow.Cells["SoLuong"].Value) * tienChietKhau;
                }
                dgvList.CurrentRow.Cells["ThanhTien"].Value = Common.IntValue(dgvList.CurrentRow.Cells["SoLuong"].Value) * _DonGia - tienChietKhau;
                lblTongSoLuong.Text = TongSoLuong().ToString();
                lblTongTienChietKhau.Text = Common.Double2Str(TongTienChietKhau());
                lblTongThanhTien.Text = Common.Double2Str(TongThanhTien());
            }
        }

        private int TongSoLuong() {
            int result = 0;
            foreach (DataGridViewRow dgr in dgvList.Rows) {
                result += int.Parse(dgr.Cells["SoLuong"].Value.ToString());
            }
            return result;
        }

        private double TongTienChietKhau()
        {
            double result = 0;
            foreach (DataGridViewRow dgr in dgvList.Rows) {
                if (dgr.Cells["TienChietKhau"].Value != System.DBNull.Value) {
                    result += Convert.ToDouble(dgr.Cells["TienChietKhau"].Value);
                }
            }
            return result;
        }
        private double TongThanhTien()
        {
            double result = 0;
            foreach (DataGridViewRow dgr in dgvList.Rows) {
                if (dgr.Cells["ThanhTien"].Value != System.DBNull.Value) {
                    result += Convert.ToDouble(dgr.Cells["ThanhTien"].Value);
                }
            }
            return result;
        }


    }
}