using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QLBH.Common;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Core.Data;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmCS_LapChinhSachKM_ChonType : DevExpress.XtraEditors.XtraForm
    {
        public int LoaiChinhSach = 0;//0-thuong; 1-mac dinh; 2-chietkhau;
        public bool ChinhSachMacDinh = false;
        public bool ChinhSachChietKhau = false;

        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();


        public frmCS_LapChinhSachKM_ChonType()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        private void frmKhoHienTai_Load(object sender, EventArgs e)
        {
            //rdChinhSachMDinh.Enabled = ConnectionUtil.Instance.IsUAT != 1;
            rdChinhSachCKhau.Enabled = nguoiDung.SupperUser == 1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoaiChinhSach = 0;//thuong

            if (rdChinhSachMDinh.Checked)
                LoaiChinhSach = 1;
            else if (rdChinhSachCKhau.Checked)
                LoaiChinhSach = 2;

            this.DialogResult = DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}