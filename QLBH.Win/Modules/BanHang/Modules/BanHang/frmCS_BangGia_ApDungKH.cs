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
    public partial class frmCS_BangGia_ApDungKH : DevExpress.XtraEditors.XtraForm
    {
        public List<BangGiaADKhachInfor> LstBangGiaADKhach = new List<BangGiaADKhachInfor>();
        List<DmLoaiDoiTuongInfor> liLoaiDT = new List<DmLoaiDoiTuongInfor>();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();

        public frmCS_BangGia_ApDungKH()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        private void cmdThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
//            this.Close();
            //Common.LogAction("Đóng form", "Đóng form " + this.Name, Declare.IdKho);
        }
        private void frm_BangGia_ApDung_Load(object sender, EventArgs e)
        {
            LoadLoaiDoiTuong();
            LoadDoiTuong();
            //SetBangGiaADShop();
        }
        private void LoadLoaiDoiTuong()
        {
            liLoaiDT = DmLoaiDoiTuongDataProvider.GetListLoaiDoiTuongInfor();
            if (liLoaiDT.Count >= 0)
            {
                liLoaiDT.Insert(0,new DmLoaiDoiTuongInfor()
                                      {
                                          IdLoaiDT = 0,
                                          MaLoaiDT = "",
                                          TenLoaiDT = "Tất cả"
                                      });
                cboLoaiDoiTuong.DataSource = liLoaiDT;
                cboLoaiDoiTuong.DisplayMember = "TenLoaiDT";
                cboLoaiDoiTuong.ValueMember = "IdLoaiDT";
                cboLoaiDoiTuong.SelectedValue = 0;// Declare.IdLoaiKhachHang;
            }
            else
            {
                cboLoaiDoiTuong.DataSource = null;
            }
        }


        private void LoadDoiTuong()
        {
            int idLoaiDT = Common.IntValue(cboLoaiDoiTuong.SelectedValue);
            List<DMDoiTuongPairInfo> liLoaiDT = DmDoiTuongProvider.GetCboDmDoiTuongByLoaiDT(idLoaiDT);
            dgvShop.Rows.Clear();
            foreach (DMDoiTuongPairInfo dt in liLoaiDT)
            {
                if (Common.Int2Bool(dt.SuDung))
                {
                    object[] arr = { 0, dt.IdDoiTuong, dt.MaDoiTuong, dt.TenDoiTuong };
                    dgvShop.Rows.Add(arr);
                }
            }
        }

        //private void SetBangGiaADShop()
        //{
        //    foreach (DataGridViewRow row in dgvShop.Rows)
        //    {
        //        if (chinhSach.ListBangGiaADKhach.Exists(delegate(BangGiaADKhachInfor st)
        //            {
        //                return st.IdLoaiDT == Common.IntValue(row.Cells["colIdLoaiDT"].Value);
        //            }))
        //            {
        //                row.Cells["colApDung"].Value = true;
        //            }
        //    }         
        //}

        private void cmdApDung_Click(object sender, EventArgs e)
        {
            LstBangGiaADKhach = new List<BangGiaADKhachInfor>();
            //chinhSach.KhachHangApDung = "";
            //bangGia.ListBangGiaADShop.Clear();
            if (cboLoaiDoiTuong.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn loại khách hàng áp dụng");
                cboLoaiDoiTuong.Focus();
                return;
            }
            if (!LstBangGiaADKhach.Exists(delegate(BangGiaADKhachInfor match)
                                              {
                                                  return (match.IdLoaiDT ==
                                                          liLoaiDT[cboLoaiDoiTuong.SelectedIndex].IdLoaiDT) &&
                                                         (match.IdDoiTuong == 0);

                                              }))
                LstBangGiaADKhach.Add(new BangGiaADKhachInfor()
                                          {
                                              IdChinhSach = 0,
                                              IdLoaiDT = liLoaiDT[cboLoaiDoiTuong.SelectedIndex].IdLoaiDT,
                                              MaLoaiDT = liLoaiDT[cboLoaiDoiTuong.SelectedIndex].MaLoaiDT,
                                              TenLoaiDT = liLoaiDT[cboLoaiDoiTuong.SelectedIndex].TenLoaiDT,
                                              IdDoiTuong = 0,
                                              MaDoiTuong = "",
                                              TenDoiTuong = ""
                                          });
            if (Declare.IS_CHINHSACH_KHACHHANG)
            {
                foreach (DataGridViewRow row in dgvShop.Rows)
                {
                    if (Common.BoolValue(row.Cells["colApDung"].Value) &&
                        !LstBangGiaADKhach.Exists(delegate(BangGiaADKhachInfor match)
                                                      {
                                                          return (match.IdLoaiDT ==
                                                                  liLoaiDT[cboLoaiDoiTuong.SelectedIndex].IdLoaiDT &&
                                                                  (match.IdDoiTuong != 0) &&
                                                                  (match.IdDoiTuong ==
                                                                   Common.IntValue(row.Cells["colIdLoaiDT"].Value)));
                                                      }))
                    {
                        LstBangGiaADKhach.Add(new BangGiaADKhachInfor()
                                                  {
                                                      IdChinhSach = 0,
                                                      IdLoaiDT = liLoaiDT[cboLoaiDoiTuong.SelectedIndex].IdLoaiDT,
                                                      MaLoaiDT = liLoaiDT[cboLoaiDoiTuong.SelectedIndex].MaLoaiDT,
                                                      TenLoaiDT = liLoaiDT[cboLoaiDoiTuong.SelectedIndex].TenLoaiDT,
                                                      IdDoiTuong = Common.IntValue(row.Cells["colIdLoaiDT"].Value),
                                                      MaDoiTuong = row.Cells["colMaLoaiDT"].Value.ToString(),
                                                      TenDoiTuong = row.Cells["colTenLoaiDT"].Value.ToString()
                                                  });
                        //chinhSach.KhachHangApDung += row.Cells["colTenLoaiDT"].Value.ToString() + ";";
                    }
                }
            }
            //MessageBox.Show("Bảng giá đã được áp dụng");
            this.DialogResult = DialogResult.OK;
            //this.Close();
            //Common.LogAction("Áp dụng bảng giá", "Bảng giá " + g1IdBangGia.ToString(), Declare.IdKho);
        }

        private void chkChonDuyet_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvShop.Rows)
            {
                row.Cells["colApDung"].Value = chkChonDuyet.Checked;
            } 
        }

        private void cboLoaiDoiTuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDoiTuong();
        }
    }
}