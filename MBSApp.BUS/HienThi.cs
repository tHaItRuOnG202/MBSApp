using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBSApp.DAO;

namespace MBSApp.BUS
{
    public class HienThi
    {
        QLBanHangDataContext db = new QLBanHangDataContext();
        public List<KhachHang> ShowKhachHang ()
        {
            return db.KhachHangs.ToList();
        }    
    }
}
