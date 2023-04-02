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
using MBSApp.DAO;
using MBSApp.DTO;

namespace MBSApp
{
    public partial class frmHoaDonBanHang : Form
    {
        Controller_BUS ctrl_B = new Controller_BUS();
        public frmHoaDonBanHang()
        {
            InitializeComponent();
        }

        private void ClearReceipt()
        {
            cboMaHang.Text = String.Empty;
            lbTenHang.Text = String.Empty;
            lbDonVi.Text = String.Empty;
            lbDonGia.Text = String.Empty;
            lbGiamGia.Text = String.Empty;
            cboMaKH.Text = String.Empty;
            lbTenKH.Text = String.Empty;
            cboMaNhanVien.Text = String.Empty;
            lbTenNhanVien.Text = String.Empty;
        }

        private void LoadReceipt()
        {
            cboMaNhanVien.DataSource = ctrl_B.ShowEmployees();
            cboMaNhanVien.DisplayMember = "MaNV";
            cboMaKH.DataSource = ctrl_B.ShowCustomers();
            cboMaKH.DisplayMember = "MaKH";
            cboMaHang.DataSource = ctrl_B.ShowProducts();
            cboMaHang.DisplayMember = "MaSP";
        }

        private void frmHoaDonBanHang_Load(object sender, EventArgs e)
        {
            LoadReceipt();
            ClearReceipt();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            //dgvHoaDon.DataSource = ctrl_B.ShowReceipt(txtMaHoaDon.Text);
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            
        }

        private void cboMaHang_TextChanged(object sender, EventArgs e)
        {
            ReceiptDetail rd = new ReceiptDetail(cboMaHang.Text, lbTenHang.Text, "Void", 1, "Void", "Void", lbGiamGia.Text) ;
            SanPham sp = ctrl_B.GetPrById(rd);
            //GiamGia gg = ctrl_B.GetDiscByID(d);

            if (sp != null)
            {
                lbTenHang.Text = sp.TenSP;
                lbDonVi.Text = sp.DonVi;
                lbGiamGia.Text = ctrl_B.GetDistByProd(cboMaHang.Text);
                lbDonGia.Text = sp.DonGia.ToString();
            }
        }

        private void cboMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            Employee em = new Employee(cboMaNhanVien.Text, "Void", "Void", DateTime.Parse("01 / 01 / 2023"), "Void", "Void");
            NhanVien nv = ctrl_B.GetEmplByID(em);

            if (nv != null)
                lbTenNhanVien.Text = nv.HoNV.ToString() + " " + nv.TenNV.ToString();
        }

        private void cboMaKH_TextChanged(object sender, EventArgs e)
        {
            Customer cust = new Customer(cboMaKH.Text, "Void", DateTime.Parse("01 / 01 / 2023"), "Void", "Void", "Void");
            KhachHang kh = ctrl_B.GetCustByID(cust);

            if (kh != null)
                lbTenKH.Text = kh.TenKH;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dgvHoaDon.Rows.Count.ToString());
            MessageBox.Show(dgvHoaDon.Rows.ToString());
        }

        //Code của Thái
        //private void btnThem_Click(object sender, EventArgs e)
        //{
        //    Receipt r = new Receipt(txtMaHoaDon.Text, cboMaKH.Text, cboMaNhanVien.Text, DateTime.Parse(dtpNgayBan.Text));
        //    ProductView pv = new ProductView(cboMaHang.Text, lbTenHang.Text, "Void", lbDonVi.Text, lbDonGia.Text);
        //    ReceiptDetail rd = new ReceiptDetail(cboMaHang.Text, lbTenHang.Text, "Void", Int16.Parse(txtSoLuong.Text), lbDonVi.Text, lbGiamGia.Text, (Int16.Parse(txtSoLuong.Text) * Int32.Parse(lbDonGia.Text) - Int32.Parse(lbGiamGia.Text)).ToString());
        //    Discount d = new Discount("Void", lbGiamGia.Text);

        //    //if (txtSoLuong.Text != "")
        //    //{
        //    //    lbDonGia.Text = (Int16.Parse(txtSoLuong.Text) * decimal.Parse(lbDonGia.Text)).ToString();
        //    //}

        //    int rowIndex = dgvHoaDon.Rows.Add();

        //    dgvHoaDon.Rows[rowIndex].Cells[0].Value = pv.MaSP;
        //    dgvHoaDon.Rows[rowIndex].Cells[1].Value = pv.TenSP;
        //    dgvHoaDon.Rows[rowIndex].Cells[2].Value = rd.SoLuong;
        //    dgvHoaDon.Rows[rowIndex].Cells[3].Value = pv.DonGia;
        //    dgvHoaDon.Rows[rowIndex].Cells[4].Value = pv.DonVi;
        //    dgvHoaDon.Rows[rowIndex].Cells[5].Value = d.GiamGia;
        //    dgvHoaDon.Rows[rowIndex].Cells[6].Value = rd.ThanhTien;
        //}

        //Code của ChatGPT
        //private void btnThem_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Receipt r = new Receipt(txtMaHoaDon.Text, cboMaKH.Text, cboMaNhanVien.Text, DateTime.Parse(dtpNgayBan.Text));
        //        ProductView pv = new ProductView(cboMaHang.Text, lbTenHang.Text, "Void", lbDonVi.Text, lbDonGia.Text);
        //        ReceiptDetail rd = new ReceiptDetail(cboMaHang.Text, lbTenHang.Text, "Void", Int16.Parse(txtSoLuong.Text), lbDonVi.Text, lbGiamGia.Text, (Int16.Parse(txtSoLuong.Text) * decimal.Parse(lbDonGia.Text) - decimal.Parse(lbGiamGia.Text)).ToString());
        //        Discount d = new Discount("Void", lbGiamGia.Text);

        //        if (txtSoLuong.Text == "")
        //        {
        //            MessageBox.Show("Vui lòng nhập số lượng");
        //            return;
        //        }

        //        rd.SoLuong = Int16.Parse(txtSoLuong.Text);

        //        if (dgvHoaDon.Rows.Count > 1)
        //        {
        //            bool isProductExist = false;
        //            foreach (DataGridViewRow row in dgvHoaDon.Rows)
        //            {
        //                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == cboMaHang.Text)
        //                {
        //                    row.Cells[2].Value = Int16.Parse(row.Cells[2].Value.ToString()) + Int16.Parse(txtSoLuong.Text);
        //                    row.Cells[6].Value = Int16.Parse(row.Cells[2].Value.ToString()) * decimal.Parse(lbDonGia.Text) - (decimal.Parse(lbGiamGia.Text) * Int16.Parse(row.Cells[2].Value.ToString()));
        //                    isProductExist = true;
        //                    break;
        //                }
        //                if (!isProductExist)
        //                {
        //                    MessageBox.Show(rd.SoLuong.ToString(), isProductExist.ToString());
        //                    int rowIndex = dgvHoaDon.Rows.Add(pv.MaSP, pv.TenSP, rd.SoLuong, pv.DonGia, pv.DonVi, d.GiamGia, rd.ThanhTien);
        //                }
        //            }
        //        }
        //        else
        //        {
        //            int rowIndex = dgvHoaDon.Rows.Add(pv.MaSP, pv.TenSP, rd.SoLuong, pv.DonGia, pv.DonVi, d.GiamGia, rd.ThanhTien);
        //        }
        //    }
        //    catch (FormatException)
        //    {
        //        MessageBox.Show("Vui lòng nhập số lượng");
        //    }
        //}


        int count;
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Receipt r = new Receipt(txtMaHoaDon.Text, cboMaKH.Text, cboMaNhanVien.Text, DateTime.Parse(dtpNgayBan.Text));
                ProductView pv = new ProductView(cboMaHang.Text, lbTenHang.Text, "Void", lbDonVi.Text, lbDonGia.Text);
                ReceiptDetail rd = new ReceiptDetail(cboMaHang.Text, lbTenHang.Text, "Void", Int16.Parse(txtSoLuong.Text), lbDonVi.Text, lbGiamGia.Text, (Int16.Parse(txtSoLuong.Text) * decimal.Parse(lbDonGia.Text) - decimal.Parse(lbGiamGia.Text)).ToString());
                Discount d = new Discount("Void", lbGiamGia.Text);

                if (txtSoLuong.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập số lượng");
                    return;
                }

                rd.SoLuong = Int16.Parse(txtSoLuong.Text);

                if (dgvHoaDon.Rows.Count == 1)
                {
                    dgvHoaDon.Rows.Add(pv.MaSP, pv.TenSP, rd.SoLuong, pv.DonGia, pv.DonVi, d.GiamGia, rd.ThanhTien);
                    count = 1;
                    MessageBox.Show("BUG 0");
                }
                else
                {
                    for (int i = 0; i < dgvHoaDon.RowCount - 1; i++)
                    {
                        if (dgvHoaDon.Rows[i].Cells[0].Value.ToString() == pv.MaSP)
                        {
                            MessageBox.Show("Đã tồn tại");
                            count = 1;
                            break;
                        }
                        else
                        {
                            count++;
                        }
                    }

                    if (count == dgvHoaDon.RowCount)
                    {
                        dgvHoaDon.Rows.Add(pv.MaSP, pv.TenSP, rd.SoLuong, pv.DonGia, pv.DonVi, d.GiamGia, rd.ThanhTien);
                        count = 1;
                        MessageBox.Show("BUG 1");
                    }
                    dgvHoaDon.Refresh();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số lượng");
            }
        }



        private void cboMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
