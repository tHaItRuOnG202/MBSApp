using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MBSApp.DTO;
using MBSApp.BUS;
using System.Data.SqlClient;

namespace MBSApp
{
    public partial class frmDMNhanVien : Form
    {
        Controller_BUS ctrl_D = new Controller_BUS();
        public frmDMNhanVien()
        {
            InitializeComponent();
        }

        private void frmDMNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            dgvDMNhanVien.DataSource = ctrl_D.ShowEmployees();
        }
        private void ClearTxt()
        {
            txtMaNV.Text = String.Empty;
            txtHoNV.Text = String.Empty;
            txtTenNV.Text = String.Empty;
            txtDiaChi.Text = String.Empty;
            txtDienThoai.Text = String.Empty;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Employee empl = new Employee(txtMaNV.Text, txtHoNV.Text, txtTenNV.Text,
                        DateTime.Parse(dtpNgaySinh.Text), txtDiaChi.Text, txtDienThoai.Text);

                if (txtMaNV.Text == String.Empty)
                {
                    Exception ex = new Exception();
                    throw ex;
                }
                ctrl_D.AddEmployees(empl);
                frmDMNhanVien_Load(sender, e);
                ClearTxt();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không được trùng mã nhân viên!");
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = ctrl_D.FindEmployees(txtTimKiem.Text);
            dgvDMNhanVien.DataSource = dt;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = ctrl_D.FindEmployees(txtTimKiem.Text);
            dgvDMNhanVien.DataSource = dt;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = dgvDMNhanVien.CurrentRow.Index;

            Employee empl = new Employee(dgvDMNhanVien.Rows[i].Cells[0].Value.ToString(),
            dgvDMNhanVien.Rows[i].Cells[1].Value.ToString(),
            dgvDMNhanVien.Rows[i].Cells[2].Value.ToString(),
            DateTime.Parse(dgvDMNhanVien.Rows[i].Cells[3].Value.ToString()),
            dgvDMNhanVien.Rows[i].Cells[4].Value.ToString(),
            dgvDMNhanVien.Rows[i].Cells[5].Value.ToString());
            ctrl_D.RemoveEmployees(empl);

            dgvDMNhanVien.DataSource = ctrl_D.ShowEmployees();
            ClearTxt();
        }

        private void dgvDMNhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgvDMNhanVien.CurrentRow.Index;
            txtMaNV.Text = dgvDMNhanVien.Rows[i].Cells[0].Value.ToString();
            txtHoNV.Text = dgvDMNhanVien.Rows[i].Cells[1].Value.ToString();
            txtTenNV.Text = dgvDMNhanVien.Rows[i].Cells[2].Value.ToString();
            dtpNgaySinh.Text = dgvDMNhanVien.Rows[i].Cells[3].Value.ToString();
            txtDiaChi.Text = dgvDMNhanVien.Rows[i].Cells[4].Value.ToString();
            txtDienThoai.Text = dgvDMNhanVien.Rows[i].Cells[5].Value.ToString();
            txtMaNV.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Employee empl = new Employee(txtMaNV.Text, txtHoNV.Text, txtTenNV.Text,
                DateTime.Parse(dtpNgaySinh.Text), txtDiaChi.Text, txtDienThoai.Text);
            ctrl_D.EditEmployees(empl);
            txtMaNV.Enabled = false;
            dgvDMNhanVien.DataSource = ctrl_D.ShowEmployees();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != String.Empty)
                MessageBox.Show("Không thể sửa mã!");
            else
                txtMaNV.Enabled = true;
        }
    }
}
