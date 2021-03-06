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

namespace QLBanHang.Modules.BanHang
{
    public partial class frmCS_BangGia_ApDungST : DevExpress.XtraEditors.XtraForm
    {
        public List<BangGiaADShopInfor> LstBangGiaADShop = new List<BangGiaADShopInfor>();
        //public string StrBangGiaADShop = "";
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();

        private List<DMTrungTamInfor> liTrungTam = new List<DMTrungTamInfor>();

        public frmCS_BangGia_ApDungST()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            dgvShop.AutoGenerateColumns = false;
        }

        private void cmdThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void frm_BangGia_ApDung_Load(object sender, EventArgs e)
        {
            LoadDSTrungTam();
            LoadDSKho();
            //SetBangGiaADShop();
        }
        private void LoadDSTrungTam()
        {
           liTrungTam = DMTrungTamDataProvider.GetListTrungTamInfoByIdNhanVien(nguoiDung.IdNhanVien);
            if (liTrungTam.Count >=0 )
            {
                liTrungTam.Insert(0, new DMTrungTamInfor()
                                         {
                                             IdTrungTam = 0,
                                             MaTrungTam = "",
                                             TenTrungTam = "Tất cả"
                                         });
                cboTrungTam.DataSource = liTrungTam;
                cboTrungTam.DisplayMember = "TenTrungTam";
                cboTrungTam.ValueMember = "IdTrungTam";
                cboTrungTam.SelectedValue = 0;// Declare.IdTrungTam;
            }
            else
            {
                cboTrungTam.DataSource = null;
            }

            // AutoCompleteStringCollection 
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            for (int i = 0; i < liTrungTam.Count; i++)
            {
                data.Add(liTrungTam[i].TenTrungTam);
            }

            cboTrungTam.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboTrungTam.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTrungTam.AutoCompleteCustomSource = data;

        }
        private void LoadDSKho()
        {
            int idTrungTam = Common.IntValue(cboTrungTam.SelectedValue);
            List<DMKhoInfo> liKho = DMKhoDataProvider.GetListKhoInfoByTTamNVien(idTrungTam, nguoiDung.IdNhanVien);
            dgvShop.Rows.Clear();
            foreach (DMKhoInfo kh in liKho)
            {
                if (Common.Int2Bool(kh.SuDung))
                {
                    object[] arr = { 0, kh.IdKho, kh.MaKho, kh.TenKho };
                    dgvShop.Rows.Add(arr);
                }
            }
        }
        //private void SetBangGiaADShop()
        //{
        //    foreach (DataGridViewRow row in dgvShop.Rows)
        //    {
        //            if (ChinhSach.ListBangGiaADShop.Exists(delegate(BangGiaADShopInfor st)
        //            {
        //                return st.IdKho == Common.IntValue(row.Cells["colIdKho"].Value);
        //            }))
        //            {
        //                row.Cells["colApDung"].Value = true;
        //            }
        //    }         
        //}

        private void cmdApDung_Click(object sender, EventArgs e)
        {
            LstBangGiaADShop = new List<BangGiaADShopInfor>();
            //StrBangGiaADShop = "";
            //bangGia.ListBangGiaADShop.Clear();
            if (cboTrungTam.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn trung tâm áp dụng");
                cboTrungTam.Focus();
                return;
            }
            if (!LstBangGiaADShop.Exists(delegate (BangGiaADShopInfor match)
                                            {
                                                return (match.IdTrungTam ==
                                                        liTrungTam[cboTrungTam.SelectedIndex].IdTrungTam) &&
                                                       (match.IdKho == 0);

                                            }))
                LstBangGiaADShop.Add(new BangGiaADShopInfor()
                {
                    IdChinhSach = 0,
                    IdTrungTam = liTrungTam[cboTrungTam.SelectedIndex].IdTrungTam,
                    MaTrungTam = liTrungTam[cboTrungTam.SelectedIndex].MaTrungTam,
                    TenTrungTam = liTrungTam[cboTrungTam.SelectedIndex].TenTrungTam,
                    IdKho = 0,
                    MaKho = "",
                    TenKho = "",
                    SoLuongDonHang = Common.IntValue(txtSoLuongDH.Text)
                });

            if (Declare.IS_CHINHSACH_KHO)
            {
                foreach (DataGridViewRow row in dgvShop.Rows)
                {
                    if (Common.BoolValue(row.Cells["colApDung"].Value) &&
                        !LstBangGiaADShop.Exists(delegate(BangGiaADShopInfor match)
                                                     {
                                                         return (match.IdTrungTam ==
                                                                 liTrungTam[cboTrungTam.SelectedIndex].IdTrungTam) &&
                                                                (match.IdKho != 0) &&
                                                                (match.IdKho ==
                                                                 Common.IntValue(row.Cells["colIdKho"].Value));
                                                     }))
                    {
                        LstBangGiaADShop.Add(new BangGiaADShopInfor()
                                                 {
                                                     IdChinhSach = 0,
                                                     IdTrungTam = liTrungTam[cboTrungTam.SelectedIndex].IdTrungTam,
                                                     MaTrungTam = liTrungTam[cboTrungTam.SelectedIndex].MaTrungTam,
                                                     TenTrungTam = liTrungTam[cboTrungTam.SelectedIndex].TenTrungTam,
                                                     IdKho = Common.IntValue(row.Cells["colIdKho"].Value),
                                                     MaKho = row.Cells["colMaKho"].Value.ToString(),
                                                     TenKho = row.Cells["colTenKho"].Value.ToString(),
                                                     SoLuongDonHang = 0
                                                 });
                        //StrBangGiaADShop += row.Cells["colTenKho"].Value.ToString() + "[" +
                        //                           liTrungTam[cboTrungTam.SelectedIndex].TenTrungTam + "];";
                    }
                }
            }

            //MessageBox.Show("Bảng giá đã được áp dụng");
            this.DialogResult = DialogResult.OK;
            //this.Close();
            //Common.LogAction("Áp dụng bảng giá", "Bảng giá " + g1IdBangGia.ToString(), Declare.IdKho);
        }

        private void cboTrungTam_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDSKho();
        }

        private void chkChonDuyet_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvShop.Rows)
            {
                row.Cells["colApDung"].Value = chkChonDuyet.Checked;
            } 
        }

        private void dgvShop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}