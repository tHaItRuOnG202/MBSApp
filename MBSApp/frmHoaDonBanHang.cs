using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        public static string HoTen = "";
        public static string MaNV = "";
        public frmHoaDonBanHang()
        {
            frmTaiKhoan f = new frmTaiKhoan();
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
            lbMaNV.Text = String.Empty;
            //cboMaNhanVien.Text = String.Empty;
            lbTenNhanVien.Text = String.Empty;
        }

        private void LoadReceipt()
        {
            //cboMaNhanVien.DataSource = ctrl_B.ShowEmployees();
            //cboMaNhanVien.DisplayMember = "MaNV";
            cboMaKH.DataSource = ctrl_B.ShowCustomers();
            cboMaKH.DisplayMember = "MaKH";
            cboMaHang.DataSource = ctrl_B.ShowProducts();
            cboMaHang.DisplayMember = "MaSP";
        }

        private void frmHoaDonBanHang_Load(object sender, EventArgs e)
        {
            LoadReceipt();
            ClearReceipt();
            lbMaNV.Text = MaNV;
            lbTenNhanVien.Text = HoTen;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            string idHD = txtMaHoaDon.Text;
            string idKH = cboMaKH.Text;
            string idNV = lbMaNV.Text;
            DateTime dateTime = DateTime.Parse(dtpNgayBan.Text);
            ctrl_B.AddReceipt(idHD, idKH, idNV, dateTime);

            for(int i = 0; i < dgvHoaDon.RowCount - 1; i++)
            {
                string idPro = dgvHoaDon.Rows[i].Cells[0].Value.ToString();
                string quantity = dgvHoaDon.Rows[i].Cells[2].Value.ToString();
                string uPrice = dgvHoaDon.Rows[i].Cells[3].Value.ToString();
                string totalPrice = dgvHoaDon.Rows[i].Cells[6].Value.ToString();
                //decimal uPrice = decimal.Parse(row.Cells[3].ToString());
                //decimal totalPrice = decimal.Parse(row.Cells[6].ToString());

                ctrl_B.AddReceiptDetail(idHD, idPro, quantity, uPrice, totalPrice);
            }
            MessageBox.Show("Thêm hóa đơn thành công!");
            //ctrl_B.AddReceiptDetail(idHD, idPro, quantity, uPrice, totalPrice);
        }

        private void cboMaHang_TextChanged(object sender, EventArgs e)
        {
            ReceiptDetail rd = new ReceiptDetail(cboMaHang.Text, lbTenHang.Text, "Void", 1, "Void", "Void", lbGiamGia.Text) ;
            SanPham sp = ctrl_B.GetPrById(rd);

            if (sp != null)
            {
                lbTenHang.Text = sp.TenSP;
                lbDonVi.Text = sp.DonVi;
                lbGiamGia.Text = ctrl_B.GetDistByProd(cboMaHang.Text);
                lbDonGia.Text = sp.DonGia;
            }
        }

        private void cboMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            //Employee em = new Employee(cboMaNhanVien.Text, "Void", "Void", DateTime.Parse("01 / 01 / 2023"), "Void", "Void");
            //NhanVien nv = ctrl_B.GetEmplByID(em);

            //if (nv != null)
            //    lbTenNhanVien.Text = nv.HoNV.ToString() + " " + nv.TenNV.ToString();
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
            try
            {
                bool isNull = DatagridviewCheck();
                //int sl = dgvHoaDon.RowCount;
                //MessageBox.Show("Không có gì để xóa!" + isNull + sl);
                if (isNull == true)
                {
                    MessageBox.Show("Chưa có sản phẩm nào để xóa");
                }
                else
                {
                    int rowIndex = dgvHoaDon.CurrentCell.RowIndex;
                    if (dgvHoaDon.CurrentCell.Value == null)
                    {
                        MessageBox.Show("Không có gì để xóa!");
                    }
                    //if (dgvHoaDon.Rows[rowIndex].Cells[0].Value.ToString() == String.Empty || dgvHoaDon.Rows[rowIndex].Cells[0].Value == null)
                    //{
                    //    MessageBox.Show("Không có gì để xóa!");
                    //}
                    else
                    {
                        dgvHoaDon.Rows.RemoveAt(rowIndex);
                    }
                    double thanhTien = 0;
                    int columnIndex = dgvHoaDon.Columns["TongTien"].Index;
                    for (int i = 0; i < dgvHoaDon.RowCount - 1; i++)
                    {
                        thanhTien += double.Parse(dgvHoaDon.Rows[i].Cells[columnIndex].Value.ToString());
                    }
                    lbTongTien.Text = thanhTien.ToString("N0") + " đ"; 
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool DatagridviewCheck()
        {
            bool isNull = false;
            for (int i = 0; i <= dgvHoaDon.RowCount - 1; i++)
            {
                for (int j = 0; j < dgvHoaDon.ColumnCount; j++)
                {
                    //if (dgvHoaDon.Rows[i].Cells[j].Value == null || dgvHoaDon.Rows[i].Cells[j].Value == DBNull.Value)
                    if(dgvHoaDon.RowCount == 1)
                    {
                        isNull = true;
                    }
                }
                if (isNull)
                    break;
            }    
            return isNull;
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
                //Receipt r = new Receipt(txtMaHoaDon.Text, cboMaKH.Text, lbMaNV.Text, DateTime.Parse(dtpNgayBan.Text));
                //ProductView pv = new ProductView(cboMaHang.Text, lbTenHang.Text, "Void", lbDonVi.Text, lbDonGia.Text);
                //ReceiptDetail rd = new ReceiptDetail(cboMaHang.Text, lbTenHang.Text, "Void", Int16.Parse(txtSoLuong.Text), lbDonVi.Text, lbGiamGia.Text, (Int16.Parse(txtSoLuong.Text) * decimal.Parse(lbDonGia.Text) - decimal.Parse(lbGiamGia.Text)).ToString());
                //Discount d = new Discount("Void", lbGiamGia.Text);

                if (txtMaHoaDon.Text == String.Empty)
                {
                    MessageBox.Show("Vui lòng nhập mã hóa đơn!");
                    return;
                }

                if (cboMaHang.Text == String.Empty)
                {
                    MessageBox.Show("Vui chọn mặt hàng!");
                    return;
                }

                if (txtSoLuong.Text == String.Empty)
                {
                    MessageBox.Show("Vui lòng nhập số lượng!");
                    return;
                }


                //rd.SoLuong = Int16.Parse(txtSoLuong.Text);

                string maSP = cboMaHang.Text;
                string tenSP = lbTenHang.Text;
                string soLuong = txtSoLuong.Text;
                string donGia = lbDonGia.Text;
                string donVi = lbDonVi.Text;
                string giamGia = lbGiamGia.Text;
                string tien = (Int16.Parse(txtSoLuong.Text) * decimal.Parse(lbDonGia.Text) - decimal.Parse(lbGiamGia.Text)).ToString();

                if (dgvHoaDon.Rows.Count == 1)
                {
                    dgvHoaDon.Rows.Add(maSP, tenSP, soLuong, donGia, donVi, giamGia, tien);
                    count = 1;
                    MessageBox.Show("Thêm sản phẩm mới thành công!");
                }
                else
                {
                    for (int i = 0; i < dgvHoaDon.RowCount - 1; i++)
                    {
                        if (dgvHoaDon.Rows[i].Cells[0].Value.ToString() == maSP)
                        {
                            MessageBox.Show("Sản phẩm đã tồn tại");
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
                        dgvHoaDon.Rows.Add(maSP, tenSP, soLuong, donGia, donVi, giamGia, tien);
                        count = 1;
                        MessageBox.Show("Sản phẩm mới đã được thêm vào!");
                    }
                }

                double thanhTien = 0;
                int columnIndex = dgvHoaDon.Columns["TongTien"].Index;
                for (int i = 0; i < dgvHoaDon.RowCount - 1; i++)
                {
                    thanhTien += double.Parse(dgvHoaDon.Rows[i].Cells[columnIndex].Value.ToString());
                }
                lbTongTien.Text = thanhTien.ToString("N0") +" đ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void dgvHoaDon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        //{
        //    int i = dgvHoaDon.CurrentCell.RowIndex;
        //    string soLuong = dgvHoaDon.Rows[i].Cells[2].Value.ToString();
        //    string donGia = dgvHoaDon.Rows[i].Cells[4].Value.ToString();
        //    string giamGia = dgvHoaDon.Rows[i].Cells[5].Value.ToString();

        //    dgvHoaDon.Rows[i].Cells[6].Value = ((Int16.Parse(soLuong) * decimal.Parse(donGia)) - (Int16.Parse(soLuong) * decimal.Parse(giamGia))).ToString();
        //}

        private void dgvHoaDon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvHoaDon.CurrentCell.Value == null)
                {
                    MessageBox.Show("Bạn chưa nhập số lượng!");
                    dgvHoaDon.CurrentCell.Value = 1;

                }
                else
                {
                    int rowIndex = dgvHoaDon.CurrentCell.RowIndex;

                    string soLuong = dgvHoaDon.Rows[rowIndex].Cells[2].Value.ToString();
                    string donGia = dgvHoaDon.Rows[rowIndex].Cells[3].Value.ToString();
                    string giamGia = dgvHoaDon.Rows[rowIndex].Cells[5].Value.ToString();
                    //MessageBox.Show(soLuong + donGia + giamGia);

                    string tongGiamGia = (Int32.Parse(soLuong) * double.Parse(giamGia)).ToString();
                    string tongTien = (Int32.Parse(soLuong) * double.Parse(donGia) - Int32.Parse(soLuong) * double.Parse(giamGia)).ToString();
                    dgvHoaDon.Rows[rowIndex].Cells[5].Value = tongGiamGia;
                    dgvHoaDon.Rows[rowIndex].Cells[6].Value = tongTien;

                    double thanhTien = 0;
                    int columnIndex = dgvHoaDon.Columns["TongTien"].Index;
                    for (int i = 0; i < dgvHoaDon.RowCount - 1; i++)
                    {
                        thanhTien += double.Parse(dgvHoaDon.Rows[i].Cells[columnIndex].Value.ToString());
                    }
                    lbTongTien.Text = thanhTien.ToString("N0") + " đ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            dgvHoaDon.Rows.Clear();
        }
    }
}
