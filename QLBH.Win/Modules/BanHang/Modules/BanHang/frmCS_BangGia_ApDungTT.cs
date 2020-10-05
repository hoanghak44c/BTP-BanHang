using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using QLBanHang.Class;
//using QLBanHang.Class.Objects;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmCS_BangGia_ApDungTT : DevExpress.XtraEditors.XtraForm
    {
        public BangGiaADBankInfor ThanhToan = new BangGiaADBankInfor();

        private List<DMThanhToanInfor> liThanhToan = new List<DMThanhToanInfor>();
        private List<DMNganHangInfor> liNganHang = new List<DMNganHangInfor>();
        private List<DMNganHangInfor> liNganHangPH = new List<DMNganHangInfor>();
        private List<DMLoaiThuChiInfor> liThoiHanTT = new List<DMLoaiThuChiInfor>();

        public frmCS_BangGia_ApDungTT()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        private void LoadHinhThucThanhToan()
        {
            liThanhToan = DMThanhToanDataProvider.GetListDMThanhToanInfo();
            cboHinhThucTT.DataSource = liThanhToan;
            cboHinhThucTT.DisplayMember = "Ten";
            cboHinhThucTT.ValueMember = "IdThanhToan";
            if (liThanhToan.Count > 0)
                cboHinhThucTT.SelectedIndex = 0;
        }
        private void LoadThoiHanThanhToan()
        {
            liThoiHanTT = DMLoaiThuChiDataProvider.GetListLoaiThuChiInfor();
            liThoiHanTT.Insert(0, new DMLoaiThuChiInfor()
                                      {
                                          IdThuChi = 0,
                                          KyHieu = "",
                                          Ten = "Không xác định",
                                          SuDung = 1,
                                          Type = 1,
                                          GhiChu = ""
                                     });
            cboThoiHanTT.DataSource = liThoiHanTT;
            cboThoiHanTT.DisplayMember = "Ten";
            cboThoiHanTT.ValueMember = "IdThuChi";
        }

        private void LoadNganHang()
        {
            liNganHang = DMNganHangDataProvider.Instance.GetListNganHangInfors();
            liNganHang.Insert(0, new DMNganHangInfor()
                                       {
                                           IdNganHang = 0,
                                           MaNganHang = "",
                                           TenNganHang = "Tất cả"
                                       });
            cboNganHangTT.DataSource = liNganHang;
            cboNganHangTT.DisplayMember = "TenNganHang";
            cboNganHangTT.ValueMember = "IdNganHang";

            liNganHangPH = DMNganHangDataProvider.Instance.GetListNganHangInfors();
            liNganHangPH.Insert(0,new DMNganHangInfor()
                                      {
                                          IdNganHang = 0,
                                          MaNganHang = "",
                                          TenNganHang = "Tất cả"
                                      });
            cboNganHangPH.DataSource = liNganHangPH;
            cboNganHangPH.DisplayMember = "TenNganHang";
            cboNganHangPH.ValueMember = "IdNganHang";

        }

        //private void txtTienThucTra_LostFocus(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        txtSoTienTT.Text = Common.Double2Str(Common.DoubleValue(txtSoTienTT.Text.Trim()));
        //    }
        //    catch (Exception ex) 
        //    {
        //        MessageBox.Show("Lỗi ngoại lệ:" + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        //private void txtTienThucTra_Enter(object sender, EventArgs e)
        //{
        //    this.txtSoTienTT.Focus();
        //    this.txtSoTienTT.SelectAll();
        //}

        private void frmPhieuXuat_TraTienThua_Load(object sender, EventArgs e)
        {
            LoadHinhThucThanhToan();
            LoadThoiHanThanhToan();
            LoadNganHang();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void frmPhieuXuat_TraTienThua_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidData())
                {
                    ThanhToan.IdHinhThucTT = Common.IntValue(cboHinhThucTT.SelectedValue);
                    ThanhToan.HinhThucThanhToan = liThanhToan[cboHinhThucTT.SelectedIndex].Ten;
                    ThanhToan.IdThoiHanTT = Common.IntValue(cboThoiHanTT.SelectedValue);
                    ThanhToan.ThoiHanThanhToan = liThoiHanTT[cboThoiHanTT.SelectedIndex].Ten;
                    int loaiTT = liThanhToan[cboHinhThucTT.SelectedIndex].LoaiThanhToan;
                    ThanhToan.IdNganHang = (loaiTT != 1) ? Common.IntValue(cboNganHangTT.SelectedValue) : 0;
                    ThanhToan.MaNganHang = (loaiTT != 1) ? liNganHang[cboNganHangTT.SelectedIndex].MaNganHang : "";
                    ThanhToan.TenNganHang = (loaiTT != 1) ? liNganHang[cboNganHangTT.SelectedIndex].TenNganHang : "";
                    ThanhToan.IdNganHangPH = (loaiTT != 1) ? Common.IntValue(cboNganHangPH.SelectedValue) : 0;
                    ThanhToan.MaNganHangPH = (loaiTT != 1) ? liNganHangPH[cboNganHangPH.SelectedIndex].MaNganHang : "";
                    ThanhToan.TenNganHangPH = (loaiTT != 1) ? liNganHangPH[cboNganHangPH.SelectedIndex].TenNganHang : "";
                    ThanhToan.TyLeThanhToan = Common.IntValue(txtThanhToanToiThieu.Text);

                    this.DialogResult = DialogResult.OK;                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thông tin thanh toán không hợp lệ. Xin mời nhập lại!");
            }

        }
        private bool ValidData()
        {
            if (cboHinhThucTT.SelectedIndex<0)
            {
                MessageBox.Show("Chọn hình thức thanh toán");
                cboHinhThucTT.Focus();
                return false;
            }
            if (cboThoiHanTT.SelectedIndex < 0)
            {
                MessageBox.Show("Chọn thời hạn thanh toán");
                cboThoiHanTT.Focus();
                return false;
            }

            //int loaiTT = liThanhToan[cboHinhThucTT.SelectedIndex].LoaiThanhToan;
            //if (loaiTT != 1 && loaiTT != 0 && cboNganHangTT.SelectedIndex < 0)
            //{
            //    MessageBox.Show("Chọn ngân hàng thanh toán");
            //    cboNganHangTT.Focus();
            //    return false;
            //}
            return true;

        }
        private void cboHinhThucTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            int loaiTT = liThanhToan[cboHinhThucTT.SelectedIndex].LoaiThanhToan;//1-tien mat;2-chuyenkhoan;3-the
            cboNganHangTT.Enabled = (loaiTT != 1) ? true : false;
            cboNganHangPH.Enabled = (loaiTT != 1) ? true : false;
        }
    }
}