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
using MBSApp.DAO;
using System.Data.SqlClient;

namespace MBSApp
{
    public partial class frmDMKhachHang : Form
    {
        Controller_BUS ctrl_D = new Controller_BUS();
        public frmDMKhachHang()
        {
            InitializeComponent();
        }

        private void frmDMKhachHang_Load(object sender, EventArgs e)
        {
            txtMaKhachHang.Enabled = false;
            dgvDMKhachHang.DataSource = ctrl_D.ShowCustomers();
        }

        private void ClearTxt()
        {
            txtMaKhachHang.Text = String.Empty;
            txtTenkhachhang.Text = String.Empty;
            txtDienThoai.Text = String.Empty;
            txtDienThoai.Text = String.Empty;
            txtEmail.Text = String.Empty;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Customer cust = new Customer(txtMaKhachHang.Text, txtTenkhachhang.Text,
                        DateTime.Parse(dtpNgaysinh.Text), txtDiaChi.Text, txtDienThoai.Text, txtEmail.Text);

                if (txtMaKhachHang.Text == String.Empty)
                {
                    Exception ex = new Exception();
                    throw ex;
                }
                ctrl_D.AddCustomers(cust);
                frmDMKhachHang_Load(sender, e);
                ClearTxt();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không được trùng mã khách hàng!");
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn chưa nhập mã khách hàng");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = ctrl_D.FindCustomers(txtTimKiem.Text);
            dgvDMKhachHang.DataSource = dt;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = ctrl_D.FindCustomers(txtTimKiem.Text);
            dgvDMKhachHang.DataSource = dt;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow row in dgvDMKhachHang.SelectedRows)
            //    if (!row.IsNewRow) dgvDMKhachHang.Rows.Remove(row);

            int i = dgvDMKhachHang.CurrentRow.Index;

            //for (int i = dgvDMKhachHang.CurrentRow.Index; i <= dgvDMKhachHang.SelectedRows.Count; i++)
            //{
            Customer cust = new Customer(dgvDMKhachHang.Rows[i].Cells[0].Value.ToString(),
            dgvDMKhachHang.Rows[i].Cells[1].Value.ToString(),
            DateTime.Parse(dgvDMKhachHang.Rows[i].Cells[2].Value.ToString()),
            dgvDMKhachHang.Rows[i].Cells[3].Value.ToString(),
            dgvDMKhachHang.Rows[i].Cells[4].Value.ToString(),
            dgvDMKhachHang.Rows[i].Cells[5].Value.ToString());
            ctrl_D.RemoveCustomers(cust);
            //}
            //if (ib.XoaThanhVien(c))
            //{
            dgvDMKhachHang.DataSource = ctrl_D.ShowCustomers();
            //}
            ClearTxt();
        }

        private void dgvDMKhachHang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgvDMKhachHang.CurrentRow.Index;
            txtMaKhachHang.Text = dgvDMKhachHang.Rows[i].Cells[0].Value.ToString();
            txtTenkhachhang.Text = dgvDMKhachHang.Rows[i].Cells[1].Value.ToString();
            dtpNgaysinh.Text = dgvDMKhachHang.Rows[i].Cells[2].Value.ToString();
            txtDiaChi.Text = dgvDMKhachHang.Rows[i].Cells[3].Value.ToString();
            txtDienThoai.Text = dgvDMKhachHang.Rows[i].Cells[4].Value.ToString();
            txtEmail.Text = dgvDMKhachHang.Rows[i].Cells[5].Value.ToString();
            txtMaKhachHang.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer(txtMaKhachHang.Text, txtTenkhachhang.Text,
                DateTime.Parse(dtpNgaysinh.Text), txtDiaChi.Text, txtDienThoai.Text, txtEmail.Text);
            ctrl_D.EditCustomers(cust);
            txtMaKhachHang.Enabled = false;
            dgvDMKhachHang.DataSource = ctrl_D.ShowCustomers();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text != String.Empty)
                MessageBox.Show("Không thể sửa mã!");
            else
                txtMaKhachHang.Enabled = true;
        }
    }
}
