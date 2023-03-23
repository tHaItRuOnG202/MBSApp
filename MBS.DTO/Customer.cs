using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBSApp.DTO
{
    public class Customer
    {
        private string maKH;
        private string tenKH;
        private DateTime ngaySinh;
        private string diaChi;
        private string dienThoai;
        private string email;

        public string MaKH
        {
            get { return maKH;  }
            set { maKH = value; }
        }

        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string DienThoai
        {
            get { return dienThoai; }
            set { dienThoai = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Customer()
        {
        }

        public Customer(string maKH, string tenKH, DateTime ngaySinh, string diaChi, string dienThoai, string email)
        {
            this.maKH = maKH;
            this.tenKH = tenKH;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.dienThoai = dienThoai;
            this.email = email;
        }
    }
}
