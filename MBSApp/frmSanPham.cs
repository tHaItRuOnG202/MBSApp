using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MBSApp.BUS;
using MBSApp.DTO;
using MBSApp.DAO;

namespace MBSApp
{
    public partial class frmSanPham : Form
    {
        Controller_BUS ctrl_D = new Controller_BUS();
        public frmSanPham()
        {
            InitializeComponent();
        }

        //Chua viet duoc trong DAO nen phai viet trong GUI
        //public void ShowSanPham()
        //{
        //    var sanpham = from p in db.SanPhams
        //                  join c in db.LoaiSPs
        //                  on p.MaLoaiSP equals c.MaLoaiSP
        //                  select new
        //                  {
        //                      p.MaSP,
        //                      p.TenSP,
        //                      c.TenLoaiSP,
        //                      p.DonVi,
        //                      p.DonGia
        //                  };
        //    dgvDMSanPham.DataSource = sanpham;

        //}

        //Da viet duoc tren DAO
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            //string[] files = Directory.GetFiles(Application.StartupPath + "\\Resources\\");
            //foreach (string file in files)
            //{
            //    Image HinhSP = Image.FromFile(file);
            //}
            dgvDMSanPham.DataSource = ctrl_D.ShowProducts();
            cboMaLoaiSP.DataSource = ctrl_D.ShowCategories();
            cboMaLoaiSP.DisplayMember = "TenLoaiSP";
            cboMaLoaiSP.ValueMember = "MaLoaiSP";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {

        }

        private void dgvDMSanPham_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void cboMaLoaiSP_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                ProductView prv = new ProductView(txtMaSP.Text, txtTenSP.Text, cboMaLoaiSP.Text, txtDonVi.Text, txtDonGiaBan.Text);
                /*
                if (txtMaSP.Text == String.Empty)
                {
                    Exception ex = new Exception();
                    throw ex;
                }*/

                ctrl_D.AddProducts(prv);
                //{
                //    MessageBox.Show("thanh cong");
                //}
                //else
                //{
                //    MessageBox.Show("sai");
                //}
                frmSanPham_Load(sender, e);
                //txtMaSP.Text = String.Empty;
                //txtTenSP.Text = String.Empty;
                //txtDonGiaBan.Text = String.Empty;
                //txtDonVi.Text = String.Empty;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không được trùng mã sản phẩm!");
            }
            //catch (Exception)
            //{
            //    MessageBox.Show("Bạn chưa nhập mã sản phẩm!");
            //}
        }
    }
}
