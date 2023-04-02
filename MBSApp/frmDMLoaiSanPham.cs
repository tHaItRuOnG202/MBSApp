using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MBSApp.BUS;
using MBSApp.DTO;

namespace MBSApp
{
    public partial class frmDMLoaiSanPham : Form
    {
        Controller_BUS ctrl_D = new Controller_BUS();
        public frmDMLoaiSanPham()
        {
            InitializeComponent();
        }

        private void frmDMLoaiSanPham_Load(object sender, EventArgs e)
        {
            dgvDMSanPham.DataSource = ctrl_D.ShowCategories();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Categories cate = new Categories(txtMaLoaiSP.Text, txtTenLoaiSP.Text);

                if (txtMaLoaiSP.Text == String.Empty)
                {
                    Exception ex = new Exception();
                    throw ex;
                }
                ctrl_D.AddCategories(cate);
                frmDMLoaiSanPham_Load(sender, e);
                txtMaLoaiSP.Text = String.Empty;
                txtTenLoaiSP.Text = String.Empty;
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = dgvDMSanPham.CurrentRow.Index;

            Categories cate = new Categories(dgvDMSanPham.Rows[i].Cells[0].Value.ToString(),
            dgvDMSanPham.Rows[i].Cells[1].Value.ToString());
            ctrl_D.RemoveCategories(cate);

            dgvDMSanPham.DataSource = ctrl_D.ShowCategories();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = ctrl_D.FindCategories(txtTimKiem.Text);
            dgvDMSanPham.DataSource = dt;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = ctrl_D.FindCategories(txtTimKiem.Text);
            dgvDMSanPham.DataSource = dt;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Categories cate = new Categories(txtMaLoaiSP.Text, txtTenLoaiSP.Text);
            ctrl_D.EditCategories(cate);
            dgvDMSanPham.DataSource = ctrl_D.ShowCategories();
        }

        private void dgvDMSanPham_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgvDMSanPham.CurrentRow.Index;
            txtMaLoaiSP.Text = dgvDMSanPham.Rows[i].Cells[0].Value.ToString();
            txtTenLoaiSP.Text = dgvDMSanPham.Rows[i].Cells[1].Value.ToString();
        }
    }
}
