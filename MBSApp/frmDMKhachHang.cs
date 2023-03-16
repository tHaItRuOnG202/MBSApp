using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MBS.DAO;
using MBS.BUS;
using MBS.DTO;

namespace MBSApp
{
    public partial class frmDMKhachHang : Form
    {
        HienThiDAO show = new HienThiDAO();
        ThemBUS thembus = new ThemBUS();
        public frmDMKhachHang()
        {
            InitializeComponent();
        }

        private void frmDMKhachHang_Load(object sender, EventArgs e)
        {
            dgvDMKhachHang.DataSource = show.ShowKhachHang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Customer c = new Customer(txtMaKhachHang.Text, txtTenkhachhang.Text,
                DateTime.Parse(dtpNgaysinh.Text), txtDiaChi.Text, txtDienThoai.Text, txtEmail.Text);
            if (thembus.ThemThanhVien(c))
            {
                MessageBox.Show("Thêm thành công!");
                dgvDMKhachHang.DataSource = show.ShowKhachHang();
            }
        }
    }
}
