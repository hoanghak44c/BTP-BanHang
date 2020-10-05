using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using QLBanHang.Modules.BanHang.Bussiness;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;
using QLBH.Common.Providers;
using QLBH.Core.Data;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmThanhToanNhapLai : DevExpress.XtraEditors.XtraForm
    {
        #region Declare

        private ChungTuBanHangInfor ChungTu = new ChungTuBanHangInfor();
        public List<ChungTuThanhToanInfor> ListChungTuThanhToan = new List<ChungTuThanhToanInfor>();
        public List<ChungTuThanhToanInfor> lstThanhToanSelected = new List<ChungTuThanhToanInfor>();
        public objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private List<DMTaiKhoanQuyInfo> liTaiKhoanQuy = new List<DMTaiKhoanQuyInfo>();

        #endregion
        public frmThanhToanNhapLai(NhapTraHangMuaBussiness business)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.ChungTu = business.ChungTu;
            this.ListChungTuThanhToan = business.ListChungTuThanhToan;
        }
        public frmThanhToanNhapLai(ChungTuBanHangInfor ctu, List<ChungTuThanhToanInfor> liTT)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.ChungTu = ctu;
            this.ListChungTuThanhToan = liTT;
        }

        private void LoadChungTuInfor()
        {
            dtNgayLap.Value = CommonProvider.Instance.GetSysDate();
            txtSoPhieu.Text = ChungTu.SoChungTuGoc;
            txtTenDoiTuong.Text = ChungTu.HoTen;
            txtMaSoThue.Text = ChungTu.MaSoThue;
            txtEmail.Text = ChungTu.Email;
            txtDienThoai.Text = ChungTu.DienThoai;
            txtCMND.Text = ChungTu.SoCMND;
            txtDiaChi.Text = ChungTu.DiaChiHoaDon;
        }

        private void LoadTrungTam()
        {
            DMTrungTamInfor tt = DMTrungTamDataProvider.GetTrungTamByIdInfo(ChungTu.IdTrungTam);
            if (tt != null)
            {
                bteTrungTam.Tag = tt;
                bteTrungTam.Text = tt.TenTrungTam;
                //grThongTin.Text = String.Format("Trung tâm: {0} - {1}", tt.MaTrungTam, tt.TenTrungTam);
            }
        }

        private void LoadTaiKhoanQuy()
        {
            int idtrungtam = (nguoiDung.IdTrungTamHachToan == 0 ? ChungTu.IdTrungTam : nguoiDung.IdTrungTamHachToan);

            liTaiKhoanQuy = DMTaiKhoanQuyDataProvider.Instance.GetListTaiKhoanQuyByTrungTam(idtrungtam);
            cboTaiKhoanQuy.DataSource = liTaiKhoanQuy;
            cboTaiKhoanQuy.DisplayMember = "TaiKhoanQuy";
            cboTaiKhoanQuy.ValueMember = "TaiKhoanQuy";

            if (liTaiKhoanQuy != null && liTaiKhoanQuy.Count > 0)
            {
                for (int i = 0; i < liTaiKhoanQuy.Count; i++)
                {
                    if (liTaiKhoanQuy[i].IdTrungTam == idtrungtam)
                    {
                        cboTaiKhoanQuy.SelectedIndex = i;
                        break;
                    }
                }                
            }
        }

        private void LoadHinhThucThanhToan()
        {
            ChungTuBanHangInfor ctu =
                NhapTraHangMuaDataProvider.Instance.SearchChungTuBanHangBySoCTGoc(ChungTu.SoChungTuGoc);
            List<ChungTuThanhToanInfor> liThanhToan = ThanhToanDataProvider.Instance.LoadAllThanhToanByCTu(ctu.IdChungTu);
            List<ChungTuThanhToanInfor> liThanhToanGop = ThanhToanDataProvider.Instance.CombineThanhToan(liThanhToan);
            List<ChungTuThanhToanInfor> liChuaThanhToan = new List<ChungTuThanhToanInfor>();

            foreach (ChungTuThanhToanInfor tt in liThanhToanGop)
            {
                ChungTuThanhToanInfor ttoan = ListChungTuThanhToan.Find(delegate(ChungTuThanhToanInfor t)
                                                                              {
                                                                                  return tt.IdHinhThucThanhToan ==
                                                                                         t.IdHinhThucThanhToan &&
                                                                                         tt.IdTienTe == t.IdTienTe &&
                                                                                         tt.IdNganHangThanhToan ==
                                                                                         t.IdNganHangThanhToan &&
                                                                                         tt.IdNganHangPhatHanhThe ==
                                                                                         t.IdNganHangPhatHanhThe &&
                                                                                         (tt.SoTaiKhoan != null &&
                                                                                          tt.SoTaiKhoan.Equals(
                                                                                              t.SoTaiKhoan) ||
                                                                                          tt.SoTaiKhoan == null) &&
                                                                                         (tt.MaThe != null &&
                                                                                          tt.MaThe.Equals(t.MaThe) ||
                                                                                          tt.MaThe == null) &&
                                                                                         (tt.DuoiThe != null &&
                                                                                          tt.DuoiThe.Equals(t.DuoiThe) ||
                                                                                          tt.DuoiThe == null);
                                                                              });
                if (ttoan == null)
                {
                    liChuaThanhToan.Add(tt);
                }                    
                else if (tt.SoTienThanhToan != ttoan.SoTienThanhToan)
                {
                    tt.SoTienThanhToan -= ttoan.SoTienThanhToan;
                    liChuaThanhToan.Add(tt);
                }
            }
            gHinhThucThanhToan.DataSource = null;
            gHinhThucThanhToan.DataSource = liChuaThanhToan;
            gvHinhThucThanhToan.ExpandAllGroups();
            selector.View = gvHinhThucThanhToan;
            selector.CheckMarkColumn.Fixed = FixedStyle.Left;
            selector.CheckMarkColumn.VisibleIndex = 0;
        }

        private void UpdateThanhToan()
        {
            lstThanhToanSelected = new List<ChungTuThanhToanInfor>();
            int count = 0;
            foreach (ChungTuThanhToanInfor tt in selector.selection)
            {
                ChungTuThanhToanInfor oSave = new ChungTuThanhToanInfor();
                //if (tt.IdThanhToan == 0 || String.IsNullOrEmpty(tt.SoPhieu))
                //{

                oSave.SoPhieu = CommonFuns.Instance.GetSoPhieuThuChi(ChungTu.SoChungTu, Declare.Prefix.PhieuChiTien,
                                                                     count);

                    //oSave.SoPhieu = count == 0
                    //                 ? CommonProvider.Instance.GetSoPhieu(Declare.Prefix.PhieuChiTien)
                    //                 : String.Format("{0}-{1}",
                    //                                 CommonProvider.Instance.GetSoPhieu(Declare.Prefix.PhieuChiTien),
                    //                                 count);
                    count++;
                //}

                oSave.IdHinhThucThanhToan = tt.IdHinhThucThanhToan;
                oSave.HinhThucThanhToan = tt.HinhThucThanhToan;
                oSave.SoTienThanhToan = tt.SoTienThanhToan;
                oSave.ThoiHanThanhToan = tt.ThoiHanThanhToan;
                oSave.IdThoiHanThanhToan = tt.IdThoiHanThanhToan;
                oSave.SoTaiKhoan = tt.SoTaiKhoan;
                oSave.ChuTaiKhoan = tt.ChuTaiKhoan;
                oSave.NganHangThanhToan = tt.NganHangThanhToan;
                oSave.IdNganHangThanhToan = tt.IdNganHangThanhToan;
                oSave.MaThe = tt.MaThe;
                oSave.DuoiThe = tt.DuoiThe;
                oSave.NganHangPhatHanhThe = tt.NganHangPhatHanhThe;
                oSave.IdNganHangPhatHanhThe = tt.IdNganHangPhatHanhThe;
                oSave.IdThuNgan = bteThuNgan.Tag != null ? ((DMNhanVienInfo)bteThuNgan.Tag).IdNhanVien : 0;
                oSave.TenThuNgan = bteThuNgan.Tag != null ? ((DMNhanVienInfo)bteThuNgan.Tag).HoTen : "";
                oSave.NgayLap = dtNgayLap.Value;
                oSave.LoaiPhieu = (int)LoaiPhieuThanhToan.PHIEU_CHI;
                oSave.LoaiGiaoDich = (int)LoaiGiaoDichThanhToan.GIAODICH_BANHANG;
                oSave.TaiKhoanQuy = cboTaiKhoanQuy.SelectedValue != null ? cboTaiKhoanQuy.SelectedValue.ToString() : ""; //tt.TaiKhoanQuy;
                oSave.IdTrungTamThu = (nguoiDung.IdTrungTamHachToan == 0 ? ChungTu.IdTrungTam : nguoiDung.IdTrungTamHachToan);
                oSave.SoChungTuGoc = ChungTu.SoChungTu;

                lstThanhToanSelected.Add(oSave);
            }
        }

        private void LoadThuNgan()
        {
            try
            {
                DMNhanVienInfo nv = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(nguoiDung.IdNhanVien);
                if (nv != null)
                {
                    bteThuNgan.Text = nv.HoTen;
                    bteThuNgan.Tag = nv;
                }
            }
            catch (System.Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }
        private void frmThanhToanNhapLai_Load(object sender, EventArgs e)
        {
            LoadChungTuInfor();
            LoadHinhThucThanhToan();
            LoadThuNgan();
            LoadTaiKhoanQuy();
            LoadTrungTam();

            SoTienThanhToan.OptionsColumn.ReadOnly = (nguoiDung.SupperUser == 1 ? false : true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidChungTuThanhToan())
            {
                UpdateThanhToan();
                this.DialogResult = DialogResult.OK;                
            }
        }
        private bool ValidChungTuThanhToan()
        {
            if (cboTaiKhoanQuy.SelectedIndex < 0)
            {
                MessageBox.Show("Tài khoản Quỹ phải chọn");
                cboTaiKhoanQuy.Focus();
                return false;
            }
            if (selector.selection.Count == 0)
            {
                MessageBox.Show("Chưa chọn thanh toán!");
                return false;
            }
            int idtt = -1;
            foreach (ChungTuThanhToanInfor tt in selector.selection)
            {
                if (idtt == -1)
                    idtt = tt.IdHinhThucThanhToan;
                if (tt.IdHinhThucThanhToan != idtt)
                {
                    MessageBox.Show("Phải chọn các phiếu thu cùng hình thức thanh toán!");
                    return false;
                }
            }
            if (bteThuNgan.Enabled && bteThuNgan.Tag == null)
            {
                MessageBox.Show("Chưa chọn thu ngân");
                bteThuNgan.Focus();
                return false;
            }
            return true;
        }

        private void chkChonDuyet_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChonDuyet.Checked)
                selector.SelectAll();
            else
                selector.ClearSelection();
        }

        private void bteThuNgan_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteNhanVien_ButtonClick(sender, e, bteThuNgan, ChungTu.IdKho);
        }

        private void bteThuNgan_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteNhanVien_KeyDown(sender, e, bteThuNgan, ChungTu.IdKho);
        }

        private void bteThuNgan_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteThuNgan);
        }

    }
}