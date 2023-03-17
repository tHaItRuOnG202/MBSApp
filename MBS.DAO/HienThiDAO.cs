using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBS.DTO;

namespace MBS.DAO
{
    public class HienThiDAO
    {
        QLBanHangDataContext db = new QLBanHangDataContext();
        ConnectionDAO cd = new ConnectionDAO();
        KhachHang cust = new KhachHang();
        //public List<KhachHang> ShowKhachHang()
        //{
        //    return db.KhachHangs.ToList();
        //}

        //public List<NhanVien> ShowNhanVien()
        //{
        //    return db.NhanViens.ToList();
        //}

        //public List<LoaiSP> ShowLoaiSP()
        //{
        //    return db.LoaiSPs.ToList();
        //}

        public DataTable ShowKhachHang()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From KhachHang";
            da = new SqlDataAdapter(query, cd.Connect());
            da.Fill(dt);
            return dt;
        }

        public DataTable ShowLoaiSP()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From LoaiSP";
            da = new SqlDataAdapter(query, cd.Connect());
            da.Fill(dt);
            return dt;
        }

        public DataTable ShowNhanVien()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From NhanVien";
            da = new SqlDataAdapter(query, cd.Connect());
            da.Fill(dt);
            return dt;
        }

        public List<ProductView> ShowSanPham()
        {
            List<ProductView> Product = new List<ProductView>();
            var sanpham = from p in db.SanPhams
                          join c in db.LoaiSPs
                          on p.MaLoaiSP equals c.MaLoaiSP
                          select new
                          {
                            p.MaSP,
                            p.TenSP,
                            c.TenLoaiSP,
                            p.DonVi,
                            p.DonGia
                          };
            foreach (var s in sanpham)
            {
                ProductView p = new ProductView();
                p.MaSP = s.MaSP;
                p.TenSP = s.TenSP;
                p.TenLoaiSP = s.TenLoaiSP;
                p.DonVi = s.DonVi;
                p.DonGia = s.DonGia;
                Product.Add(p);
            }    
            return Product;
        }

        public bool ThemKhachHang(Customer c)
        {
            cust.MaKH = c.MaKH;
            cust.TenKH = c.TenKH;
            cust.NgaySinh = c.NgaySinh;
            cust.DiaChi = c.DiaChi;
            cust.DienThoai = c.DienThoai;
            cust.Email = c.Email;

            db.KhachHangs.InsertOnSubmit(cust);
            db.SubmitChanges();

            return true;
        }

        public DataTable SearchKhachHang(string k)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From KhachHang Where TenKH like N'"+k+"%' ";
            da = new SqlDataAdapter(query, cd.Connect());
            da.Fill(dt);
            return dt;
        }
    }
}
