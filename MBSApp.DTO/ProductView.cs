using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBSApp.DTO
{
    public class ProductView
    {
        private string maSP;
        private string tenSP;
        private string tenLoaiSP;
        private string donVi;
        private string donGia;

        public string MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }

        public string TenSP
        {
            get { return tenSP; }
            set { tenSP = value; }
        }

        public string TenLoaiSP
        {
            get { return tenLoaiSP; }
            set { tenLoaiSP = value; }
        }

        public string DonVi
        {
            get { return donVi; }
            set { donVi = value; }
        }

        public string  DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        public ProductView()
        {
        }

        public ProductView(string maSP, string tenSP, string tenLoaiSP, string donVi, string donGia)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.tenLoaiSP = tenLoaiSP;
            this.donVi = donVi;
            this.donGia = donGia;
        }

    }
}
