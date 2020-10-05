using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
//using QLBanHang.Class;
using DevExpress.XtraGrid.Columns;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;
using QLBH.Common.Providers;
using QLBH.Core;
using QLBanHang.Modules.BanHang.Infors;
using QLBanHang.Modules.BanHang.Providers;
using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    public partial class frmBH_BangGiaBanHang : DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"
        List<BangGiaBanChiTietBCInfor> liSanPham = new List<BangGiaBanChiTietBCInfor>();
        List<BangGiaBanChiTietBCInfor> liSanPhamNoThuong = new List<BangGiaBanChiTietBCInfor>();
        private List<BangGiaBanChiTietBCInfor> liTimKiem = new List<BangGiaBanChiTietBCInfor>();
        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
        private int SoLuongHienTai = 0;
        private bool DongBoGiaWeb = false;
        private int idTrungTam, coTon;
        private string nganhHang, sanPham;
        private List<TimKiemItemInfor> liNganh;

#endregion

#region "Các phương thức khởi tạo"
        public frmBH_BangGiaBanHang()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }
        public frmBH_BangGiaBanHang(bool dongBo)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.DongBoGiaWeb = dongBo;
        }
#endregion

#region "Các sự kiên"
        private void frmBH_TimChungTu_Load(object sender, EventArgs e)
        {
            try
            {
                KeyPreview = true;
                LoadNganhHang();
                DMTrungTamInfor tt = DMTrungTamDataProvider.GetTrungTamByIdInfo(Declare.IdTrungTam);
                if (tt != null)
                {
                    bteTrungTam.Text = tt.TenTrungTam;
                    bteTrungTam.Tag = tt;
                    //bteTrungTam.Enabled = (nguoiDung.SupperUser == 1 ? true : false);
                }
                chkCoTonKho.Checked = true;
                tsbDongBoWebsite.Visible = (nguoiDung.SupperUser == 1 ? true : false);
                tsbDongBoWebsite.Enabled = (nguoiDung.SupperUser == 1 ? true : false);

                List<TrangThaiBH> liTrangThai = new List<TrangThaiBH>();
                liTrangThai.Add(new TrangThaiBH { Id = 0, Name = "" });
                liTrangThai.Add(new TrangThaiBH { Id = 1, Name = "Thay đổi giá" });
                repTrangThai.DataSource = liTrangThai;
                //btnTim_Click(sender, e);

                if (nguoiDung.SupperUser == 1 || DongBoGiaWeb)
                {
                    Common.SetEDControl(true, true, tsbDongBoWebsite);
                }
                else
                {
                    Common.SetEDControl(false, false, tsbDongBoWebsite); 
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadNganhHang()
        {
            //int idNND = Common.Int2Bool(nguoiDung.SupperUser) ? -1 : nguoiDung.IdNhomNguoiDung;
            liNganh = TimKiemItemDataProvider.Instance.GetAllItemsByType(-1, 1, -1, -1);//type=1: nganh hang
            liNganh.Insert(0, new TimKiemItemInfor()
                            {
                                Id = 0,
                                Ma = "",
                                Ten = "Tất cả"
                            });
            lueNganhHang.Properties.DataSource = liNganh;
            lueNganhHang.Properties.DisplayMember = "Ten";
            lueNganhHang.Properties.ValueMember = "Ma";
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            SoLuongHienTai = 0;
            SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
            liSanPham = new List<BangGiaBanChiTietBCInfor>();

            TimKiemBangGia();
        }

        private void LoadDuLieu()
        {
            //if (idTrungTam != (bteTrungTam.Tag != null
            //                     ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam
            //                     : Declare.IdTrungTam) ||
            //    coTon != (chkCoTonKho.Checked ? (DongBoGiaWeb ? 2 : 1) : 0) ||
            //    nganhHang != lueNganhHang.EditValue.ToString() ||
            //    sanPham != txtSanPham.Text.Trim())
            //{
            //    liSanPham.Clear();
            //    SoLuongHienTai = 0;
            //}

            int soBatDau = SoLuongHienTai;
            int soKetThuc = SoLuongTimKiem != -1 ? SoLuongHienTai + SoLuongTimKiem : -1;
            int idNhomNguoiDung = nguoiDung.SupperUser == 1 ? -1 : nguoiDung.IdNhomNguoiDung;
            idTrungTam = bteTrungTam.Tag != null
                                 ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam
                                 : Declare.IdTrungTam;

            coTon = chkCoTonKho.Checked ? (DongBoGiaWeb ? 2 : 1) : 0;
            
            nganhHang = lueNganhHang.EditValue.ToString();

            sanPham = bteSanPham.Text;

            int soTon = CommonFuns.Instance.GetSoTon();

            frmProgress.Instance.Value = 0;

            soBatDau = 0;

            soKetThuc = -1;

            if (!String.IsNullOrEmpty(sanPham))
            {
                DMSanPhamInfo sanPhamInfo = DmSanPhamProvider.Instance.GetSanPhamByMa(sanPham);

                if(sanPhamInfo != null && 
                    (!String.IsNullOrEmpty(nganhHang) && sanPhamInfo.Nganh == nganhHang ||
                    liNganh.Exists(delegate(TimKiemItemInfor match) { return match.Ma == sanPhamInfo.Nganh; })))
                {
                    frmProgress.Instance.MaxValue = 1;

                    liTimKiem = BaoCaoBangGiaHienTaiDataProvider.Instance.GetBangGiaBanPg(
                        idTrungTam, coTon, soBatDau, soKetThuc, sanPham,
                        nganhHang, soTon, idNhomNguoiDung);

                    liSanPham.AddRange(liTimKiem);

                    if (InvokeRequired) 
                        Invoke((MethodInvoker)delegate { gListSanPham.RefreshDataSource(); });
                    else
                        gListSanPham.RefreshDataSource();
                }
            }
            else if(!String.IsNullOrEmpty(nganhHang))
            {
                frmProgress.Instance.MaxValue = 1;

                liTimKiem = BaoCaoBangGiaHienTaiDataProvider.Instance.GetBangGiaBanPg(
                    idTrungTam, coTon, soBatDau, soKetThuc, sanPham,
                    nganhHang, soTon, idNhomNguoiDung);

                liSanPham.AddRange(liTimKiem);

                if (InvokeRequired)
                    Invoke((MethodInvoker)delegate { gListSanPham.RefreshDataSource(); });
                else
                    gListSanPham.RefreshDataSource();
                
            }
            else
            {
                frmProgress.Instance.MaxValue = liNganh.Count;

                foreach (TimKiemItemInfor timKiemItemInfor in liNganh)
                {
                    if(!String.IsNullOrEmpty(timKiemItemInfor.Ma))
                    {
                        nganhHang = timKiemItemInfor.Ma;

                        liTimKiem = BaoCaoBangGiaHienTaiDataProvider.Instance.GetBangGiaBanPg(
                            idTrungTam, coTon, soBatDau, soKetThuc, sanPham,
                            nganhHang, soTon, idNhomNguoiDung);

                        liSanPham.AddRange(liTimKiem);

                        if (InvokeRequired)
                            Invoke((MethodInvoker)delegate { gListSanPham.RefreshDataSource(); });
                        else
                            gListSanPham.RefreshDataSource();
                        
                    }

                    frmProgress.Instance.Value += 1;
                }
            }

            frmProgress.Instance.Description = "Đã xong";
            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            frmProgress.Instance.IsCompleted = true;
        }

        private void TimKiemBangGia()
        {
            try
            {
                liSanPham.Clear();
                gListSanPham.DataSource = liSanPham; 
                frmProgress.Instance.Description = Common.MsgProgress(SoLuongTimKiem);
                frmProgress.Instance.MaxValue = SoLuongTimKiem;
                frmProgress.Instance.Value = 0;
                frmProgress.Instance.DoWork(LoadDuLieu);

                //gListSanPham.DataSource = new BindingList<BangGiaBanChiTietBCInfor>(liSanPham); 
                //gvListChungTu.Columns["ParentName"].GroupIndex = 0;
                gvListSanPham.ExpandAllGroups();
                selector.View = gvListSanPham;
                selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                selector.CheckMarkColumn.VisibleIndex = 0;
                //((BindingList<BangGiaBanChiTietBCInfor>)gListSanPham.DataSource).ResetBindings();
                SoLuongHienTai = liSanPham.Count;
                selector.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbClose_Click(object sender, EventArgs e)
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
                if (e.KeyCode == Keys.F3)
                    this.btnTim_Click(sender, e);
                else if (e.KeyCode == Keys.F5)
                    this.tsbInBangGia_Click(sender, e);
                else if (e.KeyCode == Keys.F6 && tsbDongBoWebsite.Enabled)
                    this.tsbDongBoWebsite_Click(sender, e);
                else if (e.KeyCode == Keys.F9)
                    this.tsbTinhDiemThuong_Click(sender, e);
                else if (e.KeyCode == Keys.Escape)
                    this.tsbClose_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void bteTrungTam_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteTrungTam_ButtonClick(sender, e, bteTrungTam, nguoiDung.IdNhanVien);
        }

        private void bteTrungTam_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteTrungTam_KeyDown(sender, e, bteTrungTam, nguoiDung.IdNhanVien);
        }

        private void bteTrungTam_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteTrungTam);
        }


        private void tsbInBangGia_Click(object sender, EventArgs e)
        {
            Form frm1 = (Form)QLBHUtils.GetObject(Declare.KhoHangNamespace.frmInNoteSP, null);
            frm1.ShowDialog();
            //if (selector.selection.Count == 0) return;
            //ArrayList liSanPham = new ArrayList();
            //liSanPham.AddRange(selector.selection);
            //frmBH_BangGiaBanHang_InBG frm = new frmBH_BangGiaBanHang_InBG(liSanPham);
            //frm.ShowDialog();
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
                int idTrungTam = bteTrungTam.Tag != null
                                     ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam
                                     : Declare.IdTrungTam;
                List<BangGiaChinhSachInfor> liCSachs =
                    ChinhSachDataProvider.Instance.GetAllChinhSachApDung(idTrungTam, -2, 0, bgInfor.MaSanPham, -1);//idkho=-2: de xem chinh sach gia
                List<BangGiaChinhSachInfor> liChinhSach = new List<BangGiaChinhSachInfor>();
                foreach (BangGiaChinhSachInfor cs in liCSachs)
                {
                    string lstMatHangKhongAD = String.Format(",{0},", cs.MatHangKhongApDung);//khong nam trong danh sach ko duoc ap dung
                    if (!lstMatHangKhongAD.Contains(String.Format(",{0},", bgInfor.IdSanPham)))
                        liChinhSach.Add(cs);
                }
                //List<BangGiaChinhSachInfor> liChinhSach =
                //    ChinhSachDataProvider.Instance.GetAllChinhSachDaApDung(bgInfor.IdTrungTam, bgInfor.MaSanPham,
                //                                                           CommonProvider.Instance.GetSysDate());

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
                    MessageBox.Show(String.Format("Không có chính sách giá cho sản phẩm này!\nTỷ lệ Điểm thưởng = {0}%", bgInfor.TyLeDiemThuongMacDinh));
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

        private void tsbExport_Click(object sender, EventArgs e)
        {
            //Common.DevExport2Excel(gvListSanPham, "BangGiaHienTai");
            Common.Export2ExcelFromDevGridTest<BangGiaBanChiTietBCInfor>(gvListSanPham, "BangGiaHienTai");
        }

        private void tsbDongBoWebsite_Click(object sender, EventArgs e)
        {
            if (selector.selection.Count > 0)
            {
                List<BangGiaBanChiTietBCInfor> liBGiaCTiet = new List<BangGiaBanChiTietBCInfor>();
                foreach (BangGiaBanChiTietBCInfor bgct in selector.selection)
                {
                    liBGiaCTiet.Add(bgct);
                }
                int idTrungTam = bteTrungTam.Tag != null
                                     ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam
                                     : Declare.IdTrungTam;
                DongBoGiaWebsite sync = new DongBoGiaWebsite(idTrungTam, CommonProvider.Instance.GetSysDate(), liBGiaCTiet);

                sync.BangGiaSync();
            }
        }

        private void gvListSanPham_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                if (e.RowHandle < 0) return;
                BangGiaBanChiTietBCInfor ct = (BangGiaBanChiTietBCInfor)gvListSanPham.GetRow(e.RowHandle);
                DateTime now = CommonProvider.Instance.GetSysDate();

                if (ct != null)// && now.CompareTo(ct.NgayCapNhatCuoi) > 60*60*24*1000)
                {
                    if (ct.TyLeDiemThuong == 0 && ct.SoDiemThuong == 0)
                    {
                        e.Appearance.BackColor = tsslNoDThuong.BackColor;
                        e.Appearance.ForeColor = tsslNoDThuong.ForeColor;                        
                    }

                    TimeSpan tmp = now - ct.NgayCapNhatCuoi;
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

        private void bteSanPham_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var frmLookUpSanPham = new frmLookUp_SanPhamUsing(String.Format("%{0}%", bteSanPham.Text));

            if(frmLookUpSanPham.ShowDialog() == DialogResult.OK)
            {
                bteSanPham.Tag = frmLookUpSanPham.SelectedItem;

                bteSanPham.Text = frmLookUpSanPham.SelectedItem.MaSanPham;
            }
        }

        private void bteSanPham_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(bteSanPham.Text))
            {
                bteSanPham.Tag = null;
            }
        }

        private void bteSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                var frmLookUpSanPham = new frmLookUp_SanPhamUsing(String.Format("%{0}%", bteSanPham.Text));

                if (frmLookUpSanPham.ShowDialog() == DialogResult.OK)
                {
                    bteSanPham.Tag = frmLookUpSanPham.SelectedItem;

                    bteSanPham.Text = frmLookUpSanPham.SelectedItem.MaSanPham;
                }
            }
        }

        private void tsbTinhDiemThuong_Click(object sender, EventArgs e)
        {
            if (liSanPham.Count > 0)
            {
                liSanPhamNoThuong = new List<BangGiaBanChiTietBCInfor>();
                frmProgress.Instance.Description = "Đang cập nhật điểm thưởng ....";
                frmProgress.Instance.MaxValue = liSanPham.Count;
                frmProgress.Instance.Value = 0;
                frmProgress.Instance.DoWork(UpdateDiemThuong);

                gListSanPham.RefreshDataSource();

                //load no diem thuong
                gListSanPhamNoThuong.DataSource = new BindingList<BangGiaBanChiTietBCInfor>(liSanPhamNoThuong);
                gListSanPhamNoThuong.RefreshDataSource();
            }
        }

        private void UpdateDiemThuong()
        {
            try
            {
                foreach (BangGiaBanChiTietBCInfor bgct in liSanPham)
                {
                    frmProgress.Instance.Description = String.Format("Đang cập nhật điểm thưởng cho sản phẩm {0} ...", bgct.TenSanPham);
                    //khong dong bo gia cac truong hop sau
                    if (bgct.HangKhuyenMai == 1 || //hang khuyen mai
                        bgct.IdTrungTam == 1 || bgct.DonGiaCoVAT == 0) //trung tam bao hanh
                    {
                        frmProgress.Instance.Value += 1;
                        continue;
                    }

                    List<BangGiaChinhSachInfor> liChinhSach = ChinhSachDataProvider.Instance.GetAllChinhSachApDung(0, -1, 0, bgct.MaSanPham, -1);

                    if (liChinhSach.Count > 0)
                    {
                        bool found = false;
                        int diemThuongMacDinh = Common.IntValue(bgct.TyLeDiemThuongMacDinh * bgct.DonGiaCoVAT / 100);
                        
                        int diemThuongMax = 0;
                        //tinh diem cs thuong
                        foreach (BangGiaChinhSachInfor cs in liChinhSach)
                        {
                            if (cs.MacDinh == 1) continue;
                            //tinh diem thuong theo tung chinh sach gia                            
                            int diemThuong = 0;
                            if (cs.SoDiemThuong > 0)
                            {
                                diemThuong = cs.SoDiemThuong > diemThuongMacDinh && diemThuongMacDinh > 0
                                                  ? diemThuongMacDinh
                                                  : cs.SoDiemThuong;
                                found = true;
                            }
                            else if (cs.TyLeDiemThuong > 0)
                            {
                                diemThuong = Common.IntValue(cs.TyLeDiemThuong * bgct.DonGiaCoVAT / 100);
                                diemThuong = diemThuong > diemThuongMacDinh && diemThuongMacDinh > 0
                                                 ? diemThuongMacDinh
                                                 : diemThuong;
                                found = true;
                            }

                            if (diemThuong > diemThuongMax)
                                diemThuongMax = diemThuong;
                        }
                        //tinh diem cs mac dinh
                        foreach (BangGiaChinhSachInfor cs in liChinhSach)
                        {
                            int diemThuong = 0;
                            if (cs.MacDinh == 1)
                            {
                                //tinh diem thuong theo tung chinh sach gia                            
                                if (cs.SoDiemThuong > 0)
                                {
                                    diemThuong += cs.SoDiemThuong > diemThuongMacDinh && diemThuongMacDinh > 0
                                                      ? diemThuongMacDinh
                                                      : cs.SoDiemThuong;
                                    found = true;
                                }
                                else if (cs.TyLeDiemThuong > 0)
                                {
                                    diemThuong = Common.IntValue(cs.TyLeDiemThuong*bgct.DonGiaCoVAT/100);
                                    diemThuong = diemThuong > diemThuongMacDinh && diemThuongMacDinh > 0
                                                     ? diemThuongMacDinh
                                                     : diemThuong;
                                    found = true;
                                }
                                diemThuongMax += diemThuong;//diem thuong cong don voi cs mac dinh
                            }
                        }

                        //neu ko co cs thi lay theo diem thuong mac dinh
                        if (diemThuongMax == 0 && bgct.TyLeDiemThuongMacDinh > 0)
                        {
                            diemThuongMax = diemThuongMacDinh;
                        }
                        //lay diem thuong max
                        bgct.SoDiemThuong = diemThuongMax;

                        //tinh ty le
                        bgct.TyLeDiemThuong = bgct.DonGiaCoVAT != 0 ? bgct.SoDiemThuong * 100 / bgct.DonGiaCoVAT : 0;

                        //no diem thuong
                        if (!found)
                            liSanPhamNoThuong.Add(bgct);
                    }
                    else
                    {
                        bgct.TyLeDiemThuong = bgct.TyLeDiemThuongMacDinh;
                        bgct.SoDiemThuong = Common.IntValue(bgct.TyLeDiemThuongMacDinh * bgct.DonGiaCoVAT / 100);

                        liSanPhamNoThuong.Add(bgct);//no diem thuong
                    }
                    frmProgress.Instance.Value += 1;
                }
                frmProgress.Instance.IsCompleted = true;
                frmProgress.Instance.Description = String.Format("Đã cập nhật xong điểm thưởng cho {0} mã hàng.", frmProgress.Instance.Value);
                frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            }
            catch (Exception ex)
            {
                frmProgress.Instance.Description = "Cập nhật dữ liệu thất bại ....";
                frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
                frmProgress.Instance.IsCompleted = true;
            }
        }

        private void btnExportNoDT_Click(object sender, EventArgs e)
        {
            Common.Export2ExcelFromDevGridTest<BangGiaBanChiTietBCInfor>(gvListSanPhamNoThuong, "SanPhamKhongDiemThuong");
        }
    }
}