using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBSApp.DTO;

namespace MBSApp.DAO
{
    public class Controller_DAO
    {
        QLBanHangDataContext db;
        Connection_DAO cd = new Connection_DAO();

        //Load khách hàng
        public DataTable LoadCustomers()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From KhachHang";
            da = new SqlDataAdapter(query, cd.Connect());
            da.Fill(dt);
            return dt;
        }

        //Load danh mục sản phẩm
        public DataTable LoadCategories()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From LoaiSP";
            da = new SqlDataAdapter(query, cd.Connect());
            da.Fill(dt);
            return dt;
        }

        //Load nhân viên
        public DataTable LoadEmployees()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From NhanVien";
            da = new SqlDataAdapter(query, cd.Connect());
            da.Fill(dt);
            return dt;
        }

        //Load sản phẩm
        public DataTable LoadProducts()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select sp.MaSP, sp.TenSP, ls.TenLoaiSP, sp.DonVi, sp.DonGia, gg.GiamGia From SanPham sp, LoaiSP ls, GiamGia gg Where sp.MaLoaiSP = ls.MaLoaiSP And gg.MaGiamGia = sp.MaGiamGia";
            da = new SqlDataAdapter(query, cd.Connect());
            da.Fill(dt);
            return dt;
        }

        //Load hóa đơn
        //public DataTable LoadReceipt()
        //{
        //    SqlDataAdapter da;
        //    DataTable dt = new DataTable();
        //    string query = "Select * From HoaDon";
        //    da = new SqlDataAdapter(query, cd.Connect());
        //    da.Fill(dt);
        //    return dt;
        //}

        //LoadHoaDonV2
        public DataTable LoadReceipt()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = String.Format("Select hd.MaHD, CONCAT(nv.HoNV, ' ', nv.TenNV) as TenNhanVien, kh.TenKH, hd.NgayLapHD From HoaDon hd, NhanVien nv, KhachHang kh Where hd.MaNV = nv.MaNV And hd.MaKH = kh.MaKH");
            da = new SqlDataAdapter(query, cd.Connect());
            da.Fill(dt);
            return dt;
        }

        //Load chi tiết hóa đơn
        public DataTable LoadReceiptDetail(string recp)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = String.Format("Select sp.MaSP, sp.TenSP, cthd.SoLuong, sp.DonVi, sp.DonGia, km.GiamGia From SanPham sp, ChiTietHD cthd, GiamGia km Where sp.MaSP = cthd.MaSP AND sp.MaGiamGia = km.MaGiamGia AND cthd.MaHD = '{0}'", recp);
            da = new SqlDataAdapter(query, cd.Connect());
            da.Fill(dt);
            return dt;
        }

        //Load sản phẩm bằng LinQ
        //public List<ProductView> LoadProducts()
        //{
        //    List<ProductView> Product = new List<ProductView>();
        //    db = new QLBanHangDataContext();
        //    var sanpham = from p in db.SanPhams
        //                  join c in db.LoaiSPs
        //                  on p.MaLoaiSP equals c.MaLoaiSP
        //                  select new
        //                  {
        //                      p.MaSP,
        //                      p.TenSP,
        //                      c.TenLoaiSP,
        //                      p.DonVi,
        //                      p.DonGia,
        //                      p.HinhSP
        //                  };
        //    foreach (var sp in sanpham)
        //    {
        //        ProductView product = new ProductView();
        //        product.MaSP = sp.MaSP;
        //        product.TenSP = sp.TenSP;
        //        product.TenLoaiSP = sp.TenLoaiSP;
        //        product.DonVi = sp.DonVi;
        //        product.DonGia = sp.DonGia;
        //        Product.Add(product);
        //    }
        //    return Product;
        //}

        //Load giảm giá
        public DataTable LoadDiscount()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From GiamGia";
            da = new SqlDataAdapter(query, cd.Connect());
            da.Fill(dt);
            return dt;
        }

        //Thêm 1 khách hàng
        public void InsertCustomers(Customer cust)
        {
            KhachHang khachHang = new KhachHang();
            khachHang.MaKH = cust.MaKH;
            khachHang.TenKH = cust.TenKH;
            khachHang.NgaySinh = cust.NgaySinh;
            khachHang.DiaChi = cust.DiaChi;
            khachHang.DienThoai = cust.DienThoai;
            khachHang.Email = cust.Email;

            db = new QLBanHangDataContext();
            db.KhachHangs.InsertOnSubmit(khachHang);

            db.SubmitChanges();
        }

        //Tìm kiếm khách hàng theo tên
        public DataTable SearchCustomers(string kw)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From KhachHang Where TenKH like N'" + kw + "%' ";
            da = new SqlDataAdapter(query, cd.Connect());
            da.Fill(dt);
            return dt;
        }

        //Tìm kiếm hóa đơn theo khách hàng
        public DataTable SearchReceiptCustomers(string kw)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select hd.MaHD, CONCAT(nv.HoNV, ' ', nv.TenNV) as TenNhanVien, kh.TenKH, hd.NgayLapHD From HoaDon hd, NhanVien nv, KhachHang kh Where hd.MaNV = nv.MaNV And hd.MaKH = kh.MaKH And kh.TenKH like N'" + kw + "%' ";

            da = new SqlDataAdapter(query, cd.Connect());
            da.Fill(dt);
            return dt;
        }

        //Xóa 1 khách hàng
        public void DeleteCustomers(Customer cust)
        {
            KhachHang khachHang = new KhachHang();
            khachHang.MaKH = cust.MaKH;
            khachHang.TenKH = cust.TenKH;
            khachHang.NgaySinh = cust.NgaySinh;
            khachHang.DiaChi = cust.DiaChi;
            khachHang.DienThoai = cust.DienThoai;
            khachHang.Email = cust.Email;

            db = new QLBanHangDataContext();
            db.KhachHangs.Attach(khachHang);
            db.KhachHangs.DeleteOnSubmit(khachHang);
            db.SubmitChanges();
        }

        //Cập nhật thông tin 1 khách hàng
        public void UpdateCustomers(Customer cust)
        {
            db = new QLBanHangDataContext();
            var update = db.KhachHangs.SingleOrDefault(id => id.MaKH == cust.MaKH);
            update.MaKH = cust.MaKH;
            update.TenKH = cust.TenKH;
            update.NgaySinh = cust.NgaySinh;
            update.DiaChi = cust.DiaChi;
            update.DienThoai = cust.DienThoai;
            update.Email = cust.Email;

            db.SubmitChanges();
        }

        //Thêm 1 nhân viên
        public void InsertEmployees(Employee empl)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.MaNV = empl.MaNV;
            nhanVien.HoNV = empl.HoNV;
            nhanVien.TenNV = empl.TenNV;
            nhanVien.NgaySinh = empl.NgaySinh;
            nhanVien.DiaChi = empl.DiaChi;
            nhanVien.DienThoai = empl.DienThoai;

            db = new QLBanHangDataContext();
            db.NhanViens.InsertOnSubmit(nhanVien);

            db.SubmitChanges();
        }

        //Tìm kiếm nhân viên theo tên
        public DataTable SearchEmployees(string kw)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From NhanVien Where TenNV like N'" + kw + "%' ";
            da = new SqlDataAdapter(query, cd.Connect());
            da.Fill(dt);
            return dt;
        }

        //Xóa 1 nhân viên
        public void DeleteEmployees(Employee empl)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.MaNV = empl.MaNV;
            nhanVien.HoNV = empl.HoNV;
            nhanVien.TenNV = empl.TenNV;
            nhanVien.NgaySinh = empl.NgaySinh;
            nhanVien.DiaChi = empl.DiaChi;
            nhanVien.DienThoai = empl.DienThoai;

            db = new QLBanHangDataContext();
            db.NhanViens.Attach(nhanVien);
            db.NhanViens.DeleteOnSubmit(nhanVien);
            db.SubmitChanges();
        }

        //Câp nhật thông tin 1 nhân viên
        public void UpdateEmployees(Employee empl)
        {
            db = new QLBanHangDataContext();
            var update = db.NhanViens.SingleOrDefault(id => id.MaNV == empl.MaNV);
            update.MaNV = empl.MaNV;
            update.HoNV = empl.HoNV;
            update.TenNV = empl.TenNV;
            update.NgaySinh = empl.NgaySinh;
            update.DiaChi = empl.DiaChi;
            update.DienThoai = empl.DienThoai;

            db.SubmitChanges();
        }

        //Thêm 1 danh mục sản phẩm
        public void InsertCategories(Categories cate)
        {
            LoaiSP loaiSP = new LoaiSP();
            loaiSP.MaLoaiSP = cate.MaLoaiSP;
            loaiSP.TenLoaiSP = cate.TenLoaiSP;

            db = new QLBanHangDataContext();
            db.LoaiSPs.InsertOnSubmit(loaiSP);

            db.SubmitChanges();
        }

        //Tìm kiếm danh mục sản phẩm theo tên
        public DataTable SearchCategories(string kw)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From LoaiSP Where TenLoaiSP like N'" + kw + "%' ";
            da = new SqlDataAdapter(query, cd.Connect());
            da.Fill(dt);
            return dt;
        }

        //Xóa 1 danh mục sản phẩm
        public void DeleteCategories(Categories cate)
        {
            LoaiSP loaiSP = new LoaiSP();
            loaiSP.MaLoaiSP = cate.MaLoaiSP;
            loaiSP.TenLoaiSP = cate.TenLoaiSP;

            db = new QLBanHangDataContext();
            db.LoaiSPs.Attach(loaiSP);
            db.LoaiSPs.DeleteOnSubmit(loaiSP);
            db.SubmitChanges();
        }

        //Cập nhật thông tin 1 danh mục sản phẩm
        public void UpdateCategories(Categories cate)
        {
            db = new QLBanHangDataContext();
            var update = db.LoaiSPs.SingleOrDefault(id => id.MaLoaiSP == cate.MaLoaiSP);
            update.MaLoaiSP = cate.MaLoaiSP;
            update.TenLoaiSP = cate.TenLoaiSP;

            db.SubmitChanges();
        }

        //Thêm 1 sản phẩm
        public void InsertProducts(Product prod)
        {
            SanPham sanPham = new SanPham();
            sanPham.MaSP = prod.MaSP;
            sanPham.TenSP = prod.TenSP;
            sanPham.DonVi = prod.DonVi;
            sanPham.DonGia = prod.DonGia;
            sanPham.MaLoaiSP = prod.MaLoaiSP;
            sanPham.MaGiamGia = prod.MaGiamGia;

            db = new QLBanHangDataContext();
            db.SanPhams.InsertOnSubmit(sanPham);

            db.SubmitChanges();
        }

        //Xóa 1 sản phẩm
        public void DeleteProducts(Product prod)
        {

            //SanPham sanPham = new SanPham();
            //sanPham.MaSP = prod.MaSP;
            //sanPham.TenSP = prod.TenSP;
            //sanPham.DonVi = prod.DonVi;
            //sanPham.DonGia = prod.DonGia;
            //sanPham.MaLoaiSP = prod.MaLoaiSP;
            //sanPham.MaGiamGia = prod.MaGiamGia;

            //db = new QLBanHangDataContext();
            //db.SanPhams.Attach(sanPham);
            //db.SanPhams.DeleteOnSubmit(sanPham);

            //db.SubmitChanges();

            db = new QLBanHangDataContext();

            // Tải lại sản phẩm từ cơ sở dữ liệu
            SanPham sanPham = db.SanPhams.FirstOrDefault(p => p.MaSP == prod.MaSP);

            // Nếu sản phẩm tồn tại, thực hiện xóa
            if (sanPham != null)
            {
                db.SanPhams.DeleteOnSubmit(sanPham);
                db.SubmitChanges();
            }
        }

        //Cập nhật thông tin 1 sản phẩm
        public void UpdateProduct(Product prod)
        {
            db = new QLBanHangDataContext();
            var update = db.SanPhams.SingleOrDefault(id => id.MaSP == prod.MaSP);
            update.MaSP = prod.MaSP;
            update.TenSP = prod.TenSP;
            update.DonVi = prod.DonVi;
            update.DonGia = prod.DonGia;
            update.MaLoaiSP = prod.MaLoaiSP;
            update.MaGiamGia = prod.MaGiamGia;

            db.SubmitChanges();
        }

        //Tìm kiếm sản phẩm
        public DataTable SearchProducts(string kw)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From SanPham Where TenSP like N'" + kw + "%' ";
            da = new SqlDataAdapter(query, cd.Connect());
            da.Fill(dt);
            return dt;
        }

        //Lấy sản phẩm bằng id
        public SanPham GetProductByID(ReceiptDetail rd)
        {
            db = new QLBanHangDataContext();
            return db.SanPhams.FirstOrDefault(sp => sp.MaSP == rd.MaSP);

            //if (row != null)
            //{
            //    var product = new SanPham()
            //    {
            //        TenSP = row.TenSP,
            //        DonGia = row.DonGia
            //    };
            //    return product;
            //}
            //else
            //{
            //    return null;
            //}

        }

        //Lấy nhân viên bằng id
        public NhanVien GetEmployeeByID(Employee e)
        {
            db = new QLBanHangDataContext();
            return db.NhanViens.FirstOrDefault(nv => nv.MaNV == e.MaNV);
        }

        //Lấy khác hàng bằng id
        public KhachHang GetCustomerByID(Customer c)
        {
            db = new QLBanHangDataContext();
            return db.KhachHangs.FirstOrDefault(kh => kh.MaKH == c.MaKH);
        }

        //Lấy giảm giá của sản phẩm
        public string GetDiscountByProduct(string cmbMaSP)
        {
            // Lấy mã sản phẩm từ ComboBox
            string txtMa, txtKQ;
            // Tìm sản phẩm trong danh sách sản phẩm
            SanPham selectedProduct = db.SanPhams.FirstOrDefault(p => p.MaSP == cmbMaSP);

            // Nếu tìm thấy sản phẩm, hiển thị tên sản phẩm trên Textbox txtTenSP
            if (selectedProduct != null)
            {
                txtMa = selectedProduct.MaGiamGia;
                GiamGia selectedProduct2 = db.GiamGias.FirstOrDefault(p => p.MaGiamGia == txtMa);
                if (selectedProduct2 != null)
                {
                    txtKQ = selectedProduct2.GiamGia1;
                    return txtKQ;
                }
            }
            return "Không có giảm giá!";
        }

        //Thêm 1 hóa đơn
        public void InsertReceipt(string idRec, string idCust, string idEmpl, DateTime dateSale)
        {
            string query = string.Format("INSERT INTO HoaDon(MaHD, MaKH, MaNV, NgayLapHD) VALUES(N'{0}', N'{1}', N'{2}', '{3}')", idRec, idCust, idEmpl, dateSale);

            using (SqlConnection connection = cd.Connect())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        //Thêm 1 sản phẩm vào chi tiết hóa đơn
        public void InsertReceiptDetail(string idRec, string idPro, string quantity, string uPrice, string totalPrice)
        {
            string query = string.Format("INSERT INTO ChiTietHD(MaHD, MaSP, SoLuong, DonGia, ThanhTien) VALUES(N'{0}', N'{1}', N'{2}', N'{3}', N'{4}')", idRec, idPro, quantity, uPrice, totalPrice);

            using (SqlConnection connection = cd.Connect())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        
    }
}
