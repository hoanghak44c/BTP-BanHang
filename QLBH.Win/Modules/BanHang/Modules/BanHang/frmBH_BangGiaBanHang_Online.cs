using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;
using QLBH.Common.Providers;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBH_BangGiaBanHang_Online : DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"
        List<BangGiaBanChiTietBCInfor> liSanPham = new List<BangGiaBanChiTietBCInfor>();
        private List<BangGiaBanChiTietBCInfor> liTimKiem = new List<BangGiaBanChiTietBCInfor>();
        //private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
        private int SoLuongHienTai = 0;
        private bool DongBoGiaWeb = false;
        private int idTrungTam, coTon;
        private string nganhHang, sanPham;
        private DateTime lastSync;
        private bool loadingAll;
#endregion

#region "Các phương thức khởi tạo"
        public frmBH_BangGiaBanHang_Online()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }
#endregion

#region "Các sự kiên"
        private void frmBH_TimChungTu_Load(object sender, EventArgs e)
        {
            try
            {
                chkCoTonKho.Checked = true;
                List<TrangThaiBH> liTrangThai = new List<TrangThaiBH>();
                liTrangThai.Add(new TrangThaiBH { Id = 0, Name = "" });
                liTrangThai.Add(new TrangThaiBH { Id = 1, Name = "Thay đổi giá" });
                repTrangThai.DataSource = liTrangThai;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void LoadDuLieu()
        {
            int soBatDau = SoLuongHienTai;
            int soKetThuc = SoLuongTimKiem != -1 ? SoLuongHienTai + SoLuongTimKiem : -1;

            idTrungTam = Declare.IdTrungTam;

            coTon = chkCoTonKho.Checked ? (DongBoGiaWeb ? 2 : 1) : 0;

            sanPham = String.Empty;

            int soTon = CommonFuns.Instance.GetSoTon();

            liTimKiem = BaoCaoBangGiaOnlineDataProvider.Instance.GetBangGiaBanOnline(idTrungTam, coTon, sanPham, nganhHang, soTon, DateTime.MinValue);

            liSanPham.AddRange(liTimKiem);

            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            frmProgress.Instance.IsCompleted = true;
            frmProgress.Instance.Description = "Đã xong";            
        }
        
        private void TimKiemBangGia()
        {
            try
            {
                loadingAll = true;
                liSanPham.Clear();
                lastSync = CommonProvider.Instance.GetSysDate();

                frmProgress.Instance.Description = Common.MsgProgress(SoLuongTimKiem);
                frmProgress.Instance.MaxValue = SoLuongTimKiem;
                frmProgress.Instance.Value = 0;
                frmProgress.Instance.DoWork(LoadDuLieu);

                gListSanPham.DataSource = new BindingList<BangGiaBanChiTietBCInfor>(liSanPham); 
                //gvListChungTu.Columns["ParentName"].GroupIndex = 0;
                gvListSanPham.ExpandAllGroups();
                //selector.View = gvListSanPham;
                //selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                //selector.CheckMarkColumn.VisibleIndex = 0;
                ((BindingList<BangGiaBanChiTietBCInfor>)gListSanPham.DataSource).ResetBindings();
                SoLuongHienTai = liSanPham.Count;
                //selector.ClearSelection();

                this.grpKetQuaTimKiem.Text = "Tổng số mã hàng: " + liSanPham.Count;

                loadingAll = false;
                
                //var syncThread = new Thread(SyncBG);
                
                //syncThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void SyncBG()
        //{
        //    int soTon = CommonFuns.Instance.GetSoTon();

        //    while (!loadingAll)
        //    {
        //        idTrungTam = Declare.IdTrungTam;

        //        coTon = chkCoTonKho.Checked ? (DongBoGiaWeb ? 2 : 1) : 0;

        //        sanPham = String.Empty;//txtSanPham.Text.Trim();

        //        liSanPham.Sort(delegate (BangGiaBanChiTietBCInfor sp1, BangGiaBanChiTietBCInfor sp2)
        //                           {
        //                               return sp1.NgayCapNhatCuoi < sp2.NgayCapNhatCuoi ? 1 :
        //                                   sp1.NgayCapNhatCuoi == sp2.NgayCapNhatCuoi ? 0 : -1;
        //                           });

        //        lastSync = liSanPham.Count > 0 ? liSanPham[0].NgayCapNhatCuoi : DateTime.MinValue;

        //        if (!BangGiaDataProvider.Instance.IsBangGiaBanOnlineChanged(lastSync))
        //        {
        //            Thread.CurrentThread.Join(5000);

        //            continue;
        //        }

        //        liTimKiem = BangGiaDataProvider.Instance.GetBangGiaBanOnline(idTrungTam, coTon, sanPham, nganhHang, soTon, lastSync);

        //        liTimKiem.ForEach(
        //            delegate(BangGiaBanChiTietBCInfor action)
        //                {
        //                    var sp = liSanPham.Find(
        //                        delegate(BangGiaBanChiTietBCInfor match)
        //                            {
        //                                return match.IdSanPham == action.IdSanPham;
        //                            });

        //                    if(sp == null)
        //                    {
        //                        liSanPham.Add(new BangGiaBanChiTietBCInfor
        //                                          {
        //                                              IdSanPham = action.IdSanPham,
        //                                              NgayCapNhatCuoi = action.NgayCapNhatCuoi,
        //                                              Nganh = action.Nganh,
        //                                              GiaNiemYet = action.GiaNiemYet,
        //                                              GiaWebSite = action.GiaWebSite,
        //                                              DonGiaCoVAT = action.DonGiaCoVAT,
        //                                              TonAo = action.TonAo,
        //                                              TonKho = action.TonKho,
        //                                              LinhVuc = action.LinhVuc,
        //                                              Model = action.Model,
        //                                              MaSanPham = action.MaSanPham,
        //                                              TenSanPham = action.TenSanPham
        //                                          }); 
        //                    } 
        //                    else
        //                    {
        //                        sp.NgayCapNhatCuoi = action.NgayCapNhatCuoi;
        //                        sp.Nganh = action.Nganh;
        //                        sp.GiaNiemYet = action.GiaNiemYet;
        //                        sp.GiaWebSite = action.GiaWebSite;
        //                        sp.DonGiaCoVAT = action.DonGiaCoVAT;
        //                        sp.TonAo = action.TonAo;
        //                        sp.TonKho = action.TonKho;
        //                        sp.LinhVuc = action.LinhVuc;
        //                        sp.Model = action.Model;
        //                        sp.MaSanPham = action.MaSanPham;
        //                        sp.TenSanPham = action.TenSanPham;
        //                    }
        //                });

        //        Invoke((MethodInvoker)delegate 
        //        {
        //            gListSanPham.RefreshDataSource();
        //            gvListSanPham.ApplyColumnsFilter();
        //        });
        //    }
        //}

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
                    if (!this.gListSanPham.Focused)
                    {
                        SendKeys.Send("{TAB}");
                        e.Handled = true;
                        return;
                    }
                }
                else if (e.KeyCode == Keys.Escape)
                    this.btnDong_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void TonChiTiet_Click(object sender, EventArgs e)
        {
            BangGiaBanChiTietBCInfor bgInfor = (BangGiaBanChiTietBCInfor)gvListSanPham.GetFocusedRow();
            if (bgInfor != null)
            {
                frmBH_BangGiaBanHang_TonCTiet frm = new frmBH_BangGiaBanHang_TonCTiet(bgInfor);
                frm.ShowDialog();
            }
        }

        private void ChinhSachApDung_Click(object sender, EventArgs e)
        {
            BangGiaBanChiTietBCInfor bgInfor = (BangGiaBanChiTietBCInfor)gvListSanPham.GetFocusedRow();
            if (bgInfor != null)
            {
                int idTrungTam = Declare.IdTrungTam;
                List<BangGiaChinhSachInfor> liCSachs =
                    ChinhSachDataProvider.Instance.GetAllChinhSachApDung(idTrungTam, -2, 0, bgInfor.MaSanPham, -1);//idkho=-2: de xem chinh sach gia
                List<BangGiaChinhSachInfor> liChinhSach = new List<BangGiaChinhSachInfor>();
                foreach (BangGiaChinhSachInfor cs in liCSachs)
                {
                    string lstMatHangKhongAD = String.Format(",{0},", cs.MatHangKhongApDung);//khong nam trong danh sach ko duoc ap dung
                    if (!lstMatHangKhongAD.Contains(String.Format(",{0},", bgInfor.IdSanPham)))
                        liChinhSach.Add(cs);
                }
                
                if (liChinhSach != null && liChinhSach.Count > 0)
                {
                    BangGiaChiTietInfor bgct = new BangGiaChiTietInfor()
                                                   {
                                                      MaSanPham = bgInfor.MaSanPham,
                                                      TenSanPham = bgInfor.TenSanPham,
                                                      DonViTinh = bgInfor.TenDonViTinh,
                                                      DonGiaCoVAT = bgInfor.DonGiaCoVAT
                                                   };
                    frmCS_BangGia_ViewKhuyenMai frm = new frmCS_BangGia_ViewKhuyenMai(liChinhSach, bgct);
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không có chính sách giá cho sản phẩm này!");
                }
            }
        }

        private void LichSuThayDoiGia_Click(object sender, EventArgs e)
        {
            BangGiaBanChiTietBCInfor bgInfor = (BangGiaBanChiTietBCInfor)gvListSanPham.GetFocusedRow();
            if (bgInfor != null)
            {
                frmBH_BangGiaBanHang_LichSu frm = new frmBH_BangGiaBanHang_LichSu(bgInfor.IdTrungTam, bgInfor.IdSanPham);
                frm.ShowDialog();
            }
        }

       private void gvListSanPham_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                if (e.RowHandle < 0) return;
                BangGiaBanChiTietBCInfor ct = (BangGiaBanChiTietBCInfor)gvListSanPham.GetRow(e.RowHandle);

                if (ct != null)// && now.CompareTo(ct.NgayCapNhatCuoi) > 60*60*24*1000)
                {
                    TimeSpan tmp = lastSync - ct.NgayCapNhatCuoi;
                    if (tmp.TotalDays > 1) return;
                    if (ct.DonGiaCoVAT > ct.DonGiaCoVATOld)//tang gia
                    {
                        e.Appearance.BackColor = tsslTangGia.BackColor;
                        e.Appearance.ForeColor = tsslTangGia.ForeColor;
                        e.Appearance.Font = new Font("Arial", 9, FontStyle.Bold);
                    }
                    else//giam gia
                    {
                        e.Appearance.BackColor = tsslGiamGia.BackColor;
                        e.Appearance.ForeColor = tsslGiamGia.ForeColor;
                        e.Appearance.Font = new Font("Arial", 9, FontStyle.Bold);

                    }
                }                
            }
            catch
            {
                
            }

        }

       private void cmdNapDuLieu_Click(object sender, EventArgs e)
       {
           SoLuongTimKiem = -1;

           TimKiemBangGia();
       }

       private void frmBH_BangGiaBanHang_Online_FormClosing(object sender, FormClosingEventArgs e)
       {
           loadingAll = true;
       }
    }
}