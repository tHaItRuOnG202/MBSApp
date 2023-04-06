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

namespace MBSApp
{
    public partial class frmQuanLyHoaDon : Form
    {
        Controller_BUS ctrl_B = new Controller_BUS();
        public frmQuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void frmQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = ctrl_B.ShowReceipt();
            txtTenKhachHang.Enabled = false;
            txtTenNhanVien.Enabled = false;
            txtMaHD.Enabled = false;
        }

        private void dgvHoaDon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgvHoaDon.CurrentRow.Index;
            txtMaHD.Text = dgvHoaDon.Rows[i].Cells[0].Value.ToString();
            txtTenNhanVien.Text = dgvHoaDon.Rows[i].Cells[1].Value.ToString();
            txtTenKhachHang.Text = dgvHoaDon.Rows[i].Cells[2].Value.ToString();
            dtpNgayBan.Text = dgvHoaDon.Rows[i].Cells[3].Value.ToString();
        }

        private void dgvHoaDon_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = dgvHoaDon.CurrentRow.Index;
            dgvChiTietHoaDon.DataSource = ctrl_B.ShowReceiptDetail(dgvHoaDon.Rows[rowIndex].Cells[0].Value.ToString());

            
            //MessageBox.Show(soLuong + donGia + giamGia);

            for (int j = 0; j < dgvChiTietHoaDon.RowCount - 1; j++)
            {
                string soLuong = dgvChiTietHoaDon.Rows[j].Cells[3].Value.ToString();
                string donGia = dgvChiTietHoaDon.Rows[j].Cells[5].Value.ToString();
                string giamGia = dgvChiTietHoaDon.Rows[j].Cells[6].Value.ToString();

                MessageBox.Show(soLuong + donGia + giamGia);

                string tongGiamGia = (Int32.Parse(soLuong) * double.Parse(giamGia)).ToString();
                string tongTien = (Int32.Parse(soLuong) * double.Parse(donGia) - Int32.Parse(soLuong) * double.Parse(giamGia)).ToString();

                dgvChiTietHoaDon.Rows[j].Cells[6].Value = tongGiamGia;
                dgvChiTietHoaDon.Rows[j].Cells[0].Value = tongTien;
            }             
           

            double thanhTien = 0;
            int columnIndex = dgvChiTietHoaDon.Columns["ThanhTien"].Index;
            for (int i = 0; i < dgvChiTietHoaDon.RowCount - 1; i++)
            {
                thanhTien += double.Parse(dgvChiTietHoaDon.Rows[i].Cells[columnIndex].Value.ToString());
            }
            lbTongTien.Text = thanhTien.ToString("N0") + " đ";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = ctrl_B.FindReceiptCustomers(txtTimKiem.Text);
            dgvHoaDon.DataSource = dt;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = ctrl_B.FindReceiptCustomers(txtTimKiem.Text);
            dgvHoaDon.DataSource = dt;
        }
    }
}
