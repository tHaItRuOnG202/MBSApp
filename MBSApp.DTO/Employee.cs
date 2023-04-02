using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBSApp.DTO
{
    public class Employee
    {
        private string maNV;
        private string hoNV;
        private string tenNV;
        private DateTime ngaySinh;
        private string diaChi;
        private string dienThoai;

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        public string HoNV
        {
            get { return hoNV; }
            set { hoNV = value; }
        }

        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
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

        public Employee()
        {
        }

        public Employee(string maNV, string hoNV, string tenNV, DateTime ngaySinh, string diaChi, string dienThoai)
        {
            this.maNV = maNV;
            this.hoNV = hoNV;
            this.tenNV = tenNV;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.dienThoai = dienThoai;
        }
    }
}
