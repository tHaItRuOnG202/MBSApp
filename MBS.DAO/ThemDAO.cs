using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBS.DTO;

namespace MBS.DAO
{
    public class ThemDAO
    {
        QLBanHangDataContext db = new QLBanHangDataContext();
        //public bool ThemKhachHang(Customer c)
        //{
        //    KhachHang cust = new KhachHang();
        //    cust.MaKH = c.MaKH;
        //    cust.TenKH = c.TenKH;
        //    cust.NgaySinh = c.NgaySinh;
        //    cust.DiaChi = c.DiaChi;
        //    cust.DienThoai = c.DienThoai;
        //    cust.Email = c.Email;

        //    db.KhachHangs.InsertOnSubmit(cust);
        //    db.SubmitChanges();

        //    return true;
        //}
    }
}
