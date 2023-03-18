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
        QLBanHangDataContext ql = new QLBanHangDataContext();
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
            ib.ThemThanhVien(c);
            //if (ib.ThemThanhVien(c))
            //{
                //MessageBox.Show("Thêm thành công!");
                dgvDMKhachHang.DataSource = ib.ShowCustomers();
            //}
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = ib.SearchCustomer(txtTimKiem.Text);
            dgvDMKhachHang.DataSource = dt;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            //dgvDMKhachHang.DataSource = ib.ShowCustomers();
            DataTable dt = ib.SearchCustomer(txtTimKiem.Text);
            dgvDMKhachHang.DataSource = dt;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow row in dgvDMKhachHang.SelectedRows)
            //    if (!row.IsNewRow) dgvDMKhachHang.Rows.Remove(row);

            int r = dgvDMKhachHang.CurrentCell.RowIndex;

            Customer c = new Customer(dgvDMKhachHang.Rows[r].Cells[0].Value.ToString(),
                dgvDMKhachHang.Rows[r].Cells[1].Value.ToString(), DateTime.Parse(dgvDMKhachHang.Rows[r].Cells[2].Value.ToString()), dgvDMKhachHang.Rows[r].Cells[3].Value.ToString(),
                dgvDMKhachHang.Rows[r].Cells[4].Value.ToString(), dgvDMKhachHang.Rows[r].Cells[5].Value.ToString());
            ib.XoaThanhVien(c);
            //if (ib.XoaThanhVien(c))
            //{
                dgvDMKhachHang.DataSource = ib.ShowCustomers();
            //}
        }
    }
}
