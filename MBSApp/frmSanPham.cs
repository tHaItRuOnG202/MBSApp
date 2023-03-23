using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MBSApp.BUS;
using MBSApp.DTO;

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
            dgvDMSanPham.DataSource = ctrl_D.ShowProducts();
            cboMaLoaiSP.DataSource = ctrl_D.ShowCategories();
            cboMaLoaiSP.DisplayMember = "TenLoaiSP";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ProductView empl = new ProductView(txtMaSP.Text, txtTenSP.Text, cboMaLoaiSP.Text,
            //            DateTime.Parse(dtpNgaySinh.Text), txtDiaChi.Text, txtDienThoai.Text);

            //    if (txtMaNV.Text == String.Empty)
            //    {
            //        Exception ex = new Exception();
            //        throw ex;
            //    }
            //    ctrl_D.AddEmployees(empl);
            //    frmDMNhanVien_Load(sender, e);
            //    txtMaNV.Text = String.Empty;
            //    txtHoNV.Text = String.Empty;
            //    txtTenNV.Text = String.Empty;
            //    txtDiaChi.Text = String.Empty;
            //    txtDienThoai.Text = String.Empty;
            //}
            //catch (SqlException)
            //{
            //    MessageBox.Show("Không được trùng mã nhân viên!");
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Bạn chưa nhập mã nhân viên");
            //}
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
    }
}
