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

        public DataTable LoadCustomers()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From KhachHang";
            da = new SqlDataAdapter(query, cd.Connect());
            da.Fill(dt);
            return dt;
        }

        public DataTable LoadCategories()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From LoaiSP";
            da = new SqlDataAdapter(query, cd.Connect());
            da.Fill(dt);
            return dt;
        }

        public DataTable LoadEmployees()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From NhanVien";
            da = new SqlDataAdapter(query, cd.Connect());
            da.Fill(dt);
            return dt;
        }

        public DataTable LoadProducts()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select sp.MaSP, sp.TenSP, ls.TenLoaiSP, sp.DonVi, sp.DonGia From SanPham sp, LoaiSP ls Where sp.MaLoaiSP = ls.MaLoaiSP";
            da = new SqlDataAdapter(query, cd.Connect());
            da.Fill(dt);
            return dt;
        }

        public DataTable LoadReceiptDetail(string recp)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = String.Format("Select sp.MaSP, sp.TenSP, cthd.SoLuong, sp.DonVi, sp.DonGia, km.GiamGia From SanPham sp, ChiTietHD cthd, GiamGia km Where sp.MaSP = cthd.MaSP AND sp.MaGiamGia = km.MaGiamGia AND cthd.MaHD = '{0}'", recp);
            da = new SqlDataAdapter(query, cd.Connect());
            da.Fill(dt);
            return dt;
        }

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

        public DataTable LoadDiscount()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From GiamGia";
            da = new SqlDataAdapter(query, cd.Connect());
            da.Fill(dt);
            return dt;
        }

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

        public DataTable SearchCustomers(string kw)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From KhachHang Where TenKH like N'" + kw + "%' ";
            da = new SqlDataAdapter(query, cd.Connect());
            da.Fill(dt);
            return dt;
        }

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

        public DataTable SearchEmployees(string kw)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From NhanVien Where TenNV like N'" + kw + "%' ";
            da = new SqlDataAdapter(query, cd.Connect());
            da.Fill(dt);
            return dt;
        }

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

        public void InsertCategories(Categories cate)
        {
            LoaiSP loaiSP = new LoaiSP();
            loaiSP.MaLoaiSP = cate.MaLoaiSP;
            loaiSP.TenLoaiSP = cate.TenLoaiSP;

            db = new QLBanHangDataContext();
            db.LoaiSPs.InsertOnSubmit(loaiSP);

            db.SubmitChanges();
        }

        public DataTable SearchCategories(string kw)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From LoaiSP Where TenLoaiSP like N'" + kw + "%' ";
            da = new SqlDataAdapter(query, cd.Connect());
            da.Fill(dt);
            return dt;
        }

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

        public void UpdateCategories(Categories cate)
        {
            db = new QLBanHangDataContext();
            var update = db.LoaiSPs.SingleOrDefault(id => id.MaLoaiSP == cate.MaLoaiSP);
            update.MaLoaiSP = cate.MaLoaiSP;
            update.TenLoaiSP = cate.TenLoaiSP;

            db.SubmitChanges();
        }

        public void InsertProducts(Product prod)
        {
            SanPham sanPham = new SanPham();
            sanPham.MaSP = prod.MaSP;
            sanPham.TenSP = prod.TenSP;
            sanPham.DonVi = prod.DonVi;
            sanPham.DonGia = decimal.Parse(prod.DonGia);
            sanPham.MaLoaiSP = prod.MaLoaiSP;
            sanPham.MaGiamGia = prod.MaGiamGia;

            db = new QLBanHangDataContext();
            db.SanPhams.InsertOnSubmit(sanPham);

            db.SubmitChanges();
        }


        //public void InsertProducts(ProductView pv)
        //{
        //    try
        //    {
        //        cd.Connect().Open();

        //        string query = string.Format("INSERT INTO SanPham(MaSP, TenSP, DonVi, DonGia, MaLoaiSP) VALUES(N'{0}', N'{1}', N'{2}', N'{3}', N'{4}')", pv.MaSP, pv.TenSP, pv.DonVi, pv.DonGia, pv.TenLoaiSP);

        //        SqlCommand cmd = new SqlCommand(query, cd.Connect());
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception e)
        //    {

        //    }

        //    finally
        //    {
        //        cd.Connect().Close();
        //    }


        //}

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

        public NhanVien GetEmployeeByID(Employee e)
        {
            db = new QLBanHangDataContext();
            return db.NhanViens.FirstOrDefault(nv => nv.MaNV == e.MaNV);
        }

        public KhachHang GetCustomerByID(Customer c)
        {
            db = new QLBanHangDataContext();
            return db.KhachHangs.FirstOrDefault(kh => kh.MaKH == c.MaKH);
        }


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
            return "Ngộ ha";
        }
        

        public DataTable InsertProductToReceipt(Receipt r, ReceiptDetail rd, Discount d, ProductView pv)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = string.Format("INSERT INTO ChiTietHD(MaHD, MaSP, SoLuong, DonGia, ThanhTien) VALUES(N'{0}', N'{1}', N'{2}', N'{3}', N'{4}')", r.MaHoaDon, pv.TenSP, rd.SoLuong, pv.DonGia, float.Parse(pv.DonGia) * rd.SoLuong);
            da = new SqlDataAdapter(query, cd.Connect());
            da.Fill(dt);
            return dt;
        }

    }
}
