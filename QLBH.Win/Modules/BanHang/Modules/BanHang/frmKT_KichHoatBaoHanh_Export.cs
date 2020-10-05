using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using QLBanHang.Class;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBanHang.Modules.BanHang.Bussiness;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmKT_KichHoatBaoHanh_Export : DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"
        private ArrayList liChungTuChiTiet = new ArrayList();
        public TimKiemChungTuChiTietFilterInfor filter = new TimKiemChungTuChiTietFilterInfor();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
#endregion

#region "Các phương thức khởi tạo"
        public frmKT_KichHoatBaoHanh_Export()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }
        public frmKT_KichHoatBaoHanh_Export(ArrayList liSanPham)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            liChungTuChiTiet = liSanPham;
        }
#endregion

#region "Các sự kiên"
        private void frmBH_TimChungTu_Load(object sender, EventArgs e)
        {
            try
            {
                List<KichHoatBaoHanhHangInfor> liSPKichHoat = new List<KichHoatBaoHanhHangInfor>();
                int stt = 0;
                foreach (ChungTuBanHangChiTietHangHoaBHInfor sp in liChungTuChiTiet)
                {
                    KichHoatBaoHanhHangInfor spkh = new KichHoatBaoHanhHangInfor()
                                                        {
                                                            STT = ++stt,
                                                            SalesDate = sp.NgayXuatHang.AddDays(1),
                                                            FromChannelCode = sp.ChannelCode,
                                                            ToChannelCode = "EU",
                                                            PromoterId = "",
                                                            MaVach = sp.MaVach,
                                                            EndUserName = "",
                                                            DienThoai = sp.DienThoai,
                                                            IdChiTietChungTu = sp.IdChungTuChiTiet,
                                                            IdChiTietHangHoa = sp.IdChiTietHangHoa,
                                                            IdSanPham = sp.IdSanPham,
                                                            GhiChu = sp.GhiChu
                                                        };
                    liSPKichHoat.Add(spkh);

                }
                gListChungTu.DataSource = liSPKichHoat;
                //gvListChungTu.Columns["ParentName"].GroupIndex = 0;
                gvListChungTu.ExpandAllGroups();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }



#endregion


        private void frmBH_TimChungTu_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode==Keys.Enter)   
                {
                    if (!this.gListChungTu.Focused)
                    {
                        SendKeys.Send("{TAB}");
                        e.Handled = true;
                        return;
                    }
                }
                if (e.KeyCode == Keys.F12)
                    this.btnDong_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void gvListChungTu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
        }


        private void cmdExport_Click(object sender, EventArgs e)
        {
            try
            {
                //foreach (KichHoatBaoHanhHangInfor khbh in (List<KichHoatBaoHanhHangInfor>)gListChungTu.DataSource)
                //{
                //    BhBaoHanhDataProvider.Instance.KichHoatBaoHanh(khbh);
                //}

                Common.DevExport2Excel(gvListChungTu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void gvListChungTu_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {

        }

    }
}