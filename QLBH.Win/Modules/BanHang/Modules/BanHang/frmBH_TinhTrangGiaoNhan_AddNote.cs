using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using QLBH.Common;
using QLBH.Common.Objects;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common.Providers;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBH_TinhTrangGiaoNhan_AddNote : DevExpress.XtraEditors.XtraForm
    {
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();

        public string Comment = "";
        public int TrangThaiGiaoNhan = 0;
        public frmBH_TinhTrangGiaoNhan_AddNote()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        private void cmdThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void frm_BangGia_ApDung_Load(object sender, EventArgs e)
        {

        }

        private void cmdApDung_Click(object sender, EventArgs e)
        {
            try
            {
                TrangThaiGiaoNhan = cboTinhTrangGN.SelectedIndex;
                Comment = String.Format("--Nhận xét ({0}/{1}):\r\n{2}", nguoiDung.TenDangNhap,
                                        Common.Date2LongString(CommonProvider.Instance.GetSysDate()),
                                        txtComment.Text);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif                
            }

        }
    }
}