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

        public List<ProductView> ShowProducts()
        {
            return ctrl_D.LoadProducts();
        }

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

        public void AddProducts(ProductView prod)
        {
            ctrl_D.InsertProducts(prod);
        }
    }
}
