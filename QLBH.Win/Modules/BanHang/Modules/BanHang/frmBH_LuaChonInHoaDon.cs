using System;
using System.Windows.Forms;
//using QLBH..Modules.KhoHang.Reports;
using QLBH.Common;
using QLBH.Common.Providers;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBH_LuaChonInHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public int TypeInHd = 0;
        public DateTime NgayInHoaDon = DateTime.MinValue;

        public frmBH_LuaChonInHoaDon()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        public frmBH_LuaChonInHoaDon(DateTime ngayInHoaDon)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            NgayInHoaDon = ngayInHoaDon == DateTime.MinValue ? CommonProvider.Instance.GetSysDate() : ngayInHoaDon;
        }

        private void frmPhieuXuat_LuaChonIn_Load(object sender, EventArgs e)
        {
            rdHangKMKhongGia.Checked = true;
            mstNgayInHoaDon.Value = NgayInHoaDon;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (rdHangKMKhongGia.Checked)
                TypeInHd = 0;
            else if (rdChietKhauKM.Checked)
                TypeInHd = 1;
            else if (rdInCungDong.Checked)
                TypeInHd = 2;

            NgayInHoaDon = mstNgayInHoaDon.Value;

            DialogResult = DialogResult.OK;
        }
    }
}