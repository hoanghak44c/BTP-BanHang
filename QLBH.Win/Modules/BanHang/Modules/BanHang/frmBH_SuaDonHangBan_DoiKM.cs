using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc;
using QLBH.Common;
using QLBH.Common.Objects;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common.Providers;
using QLBH.Core.Providers;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBH_SuaDonHangBan_DoiKM : DevExpress.XtraEditors.XtraForm
    {
        private int IdKho;
        private int IdTrungTam;
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();

        public BangGiaBanChiTietInfor SanPhamDoi = null;
        public int NoKhuyenMai = 0;

        public frmBH_SuaDonHangBan_DoiKM()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        public frmBH_SuaDonHangBan_DoiKM(int idKho, int idTrungTam, int noKM)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.IdKho = idKho;
            this.IdTrungTam = idTrungTam;
            this.NoKhuyenMai = noKM;
        }

        private void cmdThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void frm_BangGia_ApDung_Load(object sender, EventArgs e)
        {
            txtNoKhuyenMai.Text = NoKhuyenMai.ToString();
        }

        private void cmdApDung_Click(object sender, EventArgs e)
        {
            if (SanPhamDoi == null)
            {
                MessageBox.Show("Chưa chọn sản phẩm");
                return;
            }
            NoKhuyenMai = Common.IntValue(txtNoKhuyenMai.Text);
            if (NoKhuyenMai == 0)
            {
                MessageBox.Show("Nợ khuyến mại phải > 0");
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void txtMaSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                InputDataFromCode(txtMaSanPham.Text.Trim());
            }
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            InputDataFromCode(txtMaSanPham.Text.Trim());
        }

        private void InputDataFromCode(string code)
        {
            try
            {
                if (!code.Equals(""))
                {
                    SanPhamDoi = BangGiaDataProvider.Instance.GetGiaBan(IdTrungTam, IdKho, code);
                }
                if (SanPhamDoi == null)
                {
                    frmLookUp_HangHoa frm = new frmLookUp_HangHoa(false,
                                                                  (Common.Int2Bool(nguoiDung.SupperUser)
                                                                       ? -1
                                                                       : nguoiDung.IdNhomNguoiDung), 1, -1,
                                                                  IdKho, 1);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        SanPhamDoi = BangGiaDataProvider.Instance.GetGiaBan(IdTrungTam, IdKho, frm.SelectedItem.MaSanPham);
                    }
                    else
                    {
                        return;
                    }
                }

                if (SanPhamDoi == null)
                {
                    MessageBox.Show("Giá chưa thiết lập!");
                    return;
                }
                txtComment.Text = SanPhamDoi.TenSanPham;

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
    }
}