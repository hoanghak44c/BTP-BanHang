using System;
using System.Data;
using System.Windows.Forms;
using QLBanHang.Modules.BanHang.Reports;
using CrystalDecisions.Shared;
using QLBH.Common;
using QLBH.Common.Objects;

namespace QLBanHang.Modules.BanHang
{
    public partial class frm_BangGia_Import : Form
    {
        //int g1IdBangGia;
        Utils ut = new Utils();
        BangGia BG;
        KetQuaImportBangGia ResultImport;
        public frm_BangGia_Import()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            
        }
        public frm_BangGia_Import(BangGia pBG)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            BG = pBG;
            
        }
        private void cmdThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            //Common.LogAction("Đóng form", "Đóng form " + this.Name, Declare.IdKho);
        }
        private void frm_BangGia_Import_Load(object sender, EventArgs e)
        {
            //Common.LogAction("Mở form", "Mở form " + this.Name, Declare.IdKho);
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string names = "";
                foreach (string filename in openFileDialog1.FileNames)
                    names += filename + ";";

                if (names.Length > 0)
                    txtFile.Text = names.Substring(0, names.Length - 1);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string tenFile = txtFile.Text;// openFileDialog1.FileName;
            string[] files = txtFile.Text.Trim().Split(";".ToCharArray());
            Cursor.Current = Cursors.WaitCursor;
            ResultImport=new KetQuaImportBangGia();
            foreach (string file in files)
            {
                if (System.IO.File.Exists(file))
                {
                    string kq = clsExcel.ImportFromExcels(BG, file,ResultImport);
                    if (kq == "")
                    {
                        MessageBox.Show("Lỗi import dữ liệu bảng giá");
                        return;
                    }
                }
               
            }
            Cursor.Current = Cursors.Default;
            if (files.Length > 0)
            {
                MessageBox.Show("Import bảng giá thành công!");
                this.DialogResult = DialogResult.OK;
                this.Close();
                if (ResultImport.SLLoi > 0)
                {
                    try
                    {
                        DataSet Ds = ut.getDataSet("Select MaSanPham,TenSanPham,'abc' as LyDo FROM tbl_SanPham Where 1=0", "vBCKetQuaImport");
                        foreach (KetQuaImportBangGiaChiTiet kq in ResultImport.LstLoi)
                        {
                            DataRow r = Ds.Tables[0].NewRow();
                            r["MaSanPham"] = kq.MaSanPham;
                            r["TenSanPham"] = kq.TenSanPham;
                            r["LyDo"] = kq.LyDo;
                            Ds.Tables[0].Rows.Add(r);
                        }
                        rpt_BC_KetQuaImport rpt = new rpt_BC_KetQuaImport();
                        rpt.SetDataSource(Ds);
                        ParameterFields myParams = new ParameterFields();
                        ut.SetParameterReport(myParams, "pTongSoDong", ResultImport.SLThanhCong + ResultImport.SLLoi);
                        ut.SetParameterReport(myParams, "pSLThanhCong", ResultImport.SLThanhCong);
                        ut.SetParameterReport(myParams, "pSLLoi", ResultImport.SLLoi);

                        Cursor.Current = Cursors.WaitCursor;
                        frm_rptPhuong frm = new frm_rptPhuong(rpt, myParams);
                        Cursor.Current = Cursors.Default;
                        frm.ShowDialog();
                    }
                    catch (System.Exception ex)
                    {
#if DEBUG
                        MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
                    }
                }
                
            }
            
        }
        

                
    }
}