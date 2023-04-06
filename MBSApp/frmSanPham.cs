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
        
        private void ClearTxt()
        {
            txtMaSP.Text = String.Empty;
            txtTenSP.Text = String.Empty;
            txtDonGiaBan.Text = String.Empty;
            txtDonVi.Text = String.Empty;
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
            txtMaSP.Enabled = false;
            dgvDMSanPham.DataSource = ctrl_D.ShowProducts();
            cboMaLoaiSP.DataSource = ctrl_D.ShowCategories();
            cboMaLoaiSP.DisplayMember = "TenLoaiSP";
            cboMaLoaiSP.ValueMember = "MaLoaiSP";
            cbMaGiamGia.DataSource = ctrl_D.ShowDiscount();
            cbMaGiamGia.DisplayMember = "GiamGia";
            cbMaGiamGia.ValueMember = "MaGiamGia";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = ctrl_D.FindProduct(txtTimKiem.Text);
            dgvDMSanPham.DataSource = dt;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = ctrl_D.FindProduct(txtTimKiem.Text);
            dgvDMSanPham.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //try
            //{
                ProductView prv = new ProductView(txtMaSP.Text, txtTenSP.Text, cboMaLoaiSP.Text, txtDonVi.Text, txtDonGiaBan.Text);
                Product prd = new Product(txtMaSP.Text, txtTenSP.Text, txtDonVi.Text, txtDonGiaBan.Text, cboMaLoaiSP.SelectedValue.ToString(), cbMaGiamGia.SelectedValue.ToString());

                if (txtMaSP.Text == String.Empty)
                {
                    Exception ex = new Exception();
                    throw ex;
                }

                ctrl_D.AddProducts(prd);
                //{
                //    MessageBox.Show("Thành công");
                //}
                //else
                //{
                //    MessageBox.Show("Sai");
                //}
                frmSanPham_Load(sender, e);
                ClearTxt();
            //}
            //catch (SqlException)
            //{
                //MessageBox.Show("Không được trùng mã sản phẩm!");
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Bạn chưa nhập mã sản phẩm!");
            //}
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text != String.Empty)
                MessageBox.Show("Không thể sửa mã!");
            else
                txtMaSP.Enabled = true;
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            int i = dgvDMSanPham.CurrentRow.Index;

            Product prod = new Product(dgvDMSanPham.Rows[i].Cells[0].Value.ToString(),
            dgvDMSanPham.Rows[i].Cells[1].Value.ToString(),
            dgvDMSanPham.Rows[i].Cells[2].Value.ToString(),
            dgvDMSanPham.Rows[i].Cells[3].Value.ToString(),
            dgvDMSanPham.Rows[i].Cells[4].Value.ToString(),
            dgvDMSanPham.Rows[i].Cells[5].Value.ToString());
            ctrl_D.RemoveProduct(prod);

            dgvDMSanPham.DataSource = ctrl_D.ShowProducts();
            ClearTxt();
        }

        private void btnLuuSP_Click(object sender, EventArgs e)
        {
            Product prod = new Product(txtMaSP.Text, txtTenSP.Text, txtDonVi.Text, txtDonGiaBan.Text, cboMaLoaiSP.SelectedValue.ToString(), cbMaGiamGia.SelectedValue.ToString());
            ctrl_D.EditProduct(prod);
            txtMaSP.Enabled = false;
            dgvDMSanPham.DataSource = ctrl_D.ShowProducts();
        }

        private void dgvDMSanPham_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int i = dgvDMSanPham.CurrentRow.Index;

            txtMaSP.Text = dgvDMSanPham.Rows[i].Cells[0].Value.ToString();
            txtTenSP.Text = dgvDMSanPham.Rows[i].Cells[1].Value.ToString();
            cboMaLoaiSP.Text = dgvDMSanPham.Rows[i].Cells[2].Value.ToString();
            txtDonVi.Text = dgvDMSanPham.Rows[i].Cells[3].Value.ToString();
            txtDonGiaBan.Text = dgvDMSanPham.Rows[i].Cells[4].Value.ToString();
            cbMaGiamGia.Text = dgvDMSanPham.Rows[i].Cells[5].Value.ToString();

            txtMaSP.Enabled = false;
        }
    }
}
