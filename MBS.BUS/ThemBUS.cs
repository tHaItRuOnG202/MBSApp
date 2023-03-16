using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBS.DAO;
using MBS.DTO;

namespace MBS.BUS
{
    public class ThemBUS
    {
        HienThiDAO add = new HienThiDAO();

        public bool ThemThanhVien(Customer c)
        {
            return add.ThemKhachHang(c);
        }
    }
}
