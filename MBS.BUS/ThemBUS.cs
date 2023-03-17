using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBS.DAO;
using MBS.DTO;

namespace MBS.BUS
{
    public class ThemBUS
    {
        HienThiDAO load = new HienThiDAO();

        public DataTable ShowEmpoyees()
        {
            return load.ShowNhanVien();
        }

        public DataTable ShowCustomers()
        {
            return load.ShowKhachHang();
        }

        public DataTable ShowCategories()
        {
            return load.ShowLoaiSP();
        }

        public List<ProductView> ShowProducts()
        {
            return load.ShowSanPham();
        }

        public bool ThemThanhVien(Customer c)
        {
            return load.ThemKhachHang(c);
        }

        public DataTable SearchCustomer(string kw)
        {
            return load.SearchKhachHang(kw);
        }
}
