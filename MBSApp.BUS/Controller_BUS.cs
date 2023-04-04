using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBSApp.DAO;
using MBSApp.DTO;

namespace MBSApp.BUS
{
    public class Controller_BUS
    {
        Controller_DAO ctrl_D = new Controller_DAO();

        public DataTable ShowEmployees()
        {
            return ctrl_D.LoadEmployees();
        }

        public DataTable ShowCustomers()
        {
            return ctrl_D.LoadCustomers();
        }

        public DataTable ShowCategories()
        {
            return ctrl_D.LoadCategories();
        }

        public DataTable ShowProducts()
        {
            return ctrl_D.LoadProducts();
        }

        public DataTable ShowDiscount()
        {
            return ctrl_D.LoadDiscount();
        }

        //public List<ProductView> ShowProducts()
        //{
        //    return ctrl_D.LoadProducts();
        //}

        public void AddCustomers(Customer ctm)
        {
            ctrl_D.InsertCustomers(ctm);
        }

        public DataTable FindCustomers(string keyword)
        {
            return ctrl_D.SearchCustomers(keyword);
        }

        public void RemoveCustomers(Customer ctm)
        {
            ctrl_D.DeleteCustomers(ctm);
        }

        public void EditCustomers(Customer ctm)
        {
            ctrl_D.UpdateCustomers(ctm);
        }

        public void AddEmployees(Employee epl)
        {
            ctrl_D.InsertEmployees(epl);
        }

        public DataTable FindEmployees(string keyword)
        {
            return ctrl_D.SearchEmployees(keyword);
        }

        public void RemoveEmployees(Employee epl)
        {
            ctrl_D.DeleteEmployees(epl);
        }

        public void EditEmployees(Employee epl)
        {
            ctrl_D.UpdateEmployees(epl);
        }

        public void AddCategories(Categories cate)
        {
            ctrl_D.InsertCategories(cate);
        }

        public DataTable FindCategories(string keyword)
        {
            return ctrl_D.SearchCategories(keyword);
        }

        public void RemoveCategories(Categories cate)
        {
            ctrl_D.DeleteCategories(cate);
        }

        public void EditCategories(Categories cate)
        {
            ctrl_D.UpdateCategories(cate);
        }

        public void AddProducts(Product prod)
        {
            ctrl_D.InsertProducts(prod);
        }

        public DataTable ShowReceipt(string recp)
        {
            return ctrl_D.LoadReceiptDetail(recp);
        }

        //public void GetPrByID(string pid)
        //{
        //    ctrl_D.GetProductByID(pid);
        //}

        //public SanPham GetPrById(string pid)
        //{
        //    return ctrl_D.GetProductByID(pid);
        //}
        public SanPham GetPrById(ReceiptDetail rd)
        {
            return ctrl_D.GetProductByID(rd);
        }

        public NhanVien GetEmplByID(Employee e)
        {
            return ctrl_D.GetEmployeeByID(e);
        }

        public KhachHang GetCustByID(Customer c)
        {
            return ctrl_D.GetCustomerByID(c);
        }

        public DataTable AddProductToReceipt(Receipt r, ReceiptDetail rd, Discount d, ProductView pv)
        {
            return ctrl_D.InsertProductToReceipt(r, rd, d, pv);
        }

        //public GiamGia GetDiscByID(Discount dc)
        //{
        //    return ctrl_D.GetDiscountByID(dc);
        //}

        public string GetDistByProd(string mgg)
        {
            return ctrl_D.GetDiscountByProduct(mgg);
        }
    }
}
