using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MBS.BUS;
using MBS.DTO;
using MBS.DAO;

namespace MBSApp
{
    public partial class frmDMKhachHang : Form
    {
        ThemBUS ib = new ThemBUS();
        public frmDMKhachHang()
        {
            InitializeComponent();
        }

        private void frmDMKhachHang_Load(object sender, EventArgs e)
        {
            dgvDMKhachHang.DataSource = ib.ShowCustomers();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Customer c = new Customer(txtMaKhachHang.Text, txtTenkhachhang.Text,
                DateTime.Parse(dtpNgaysinh.Text), txtDiaChi.Text, txtDienThoai.Text, txtEmail.Text);
            if (ib.ThemThanhVien(c))
            {
                MessageBox.Show("Thêm thành công!");
                dgvDMKhachHang.DataSource = ib.ShowCustomers();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = ib.SearchCustomer(txtTimKiem.Text);
            dgvDMKhachHang.DataSource = dt;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvDMKhachHang.DataSource = ib.ShowCustomers();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }
    }
}
