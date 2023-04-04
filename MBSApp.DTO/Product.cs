using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBSApp.DTO
{
    public class Product
    {
        private string maSP;
        private string tenSP;
        private string donVi;
        private string donGia;
        private string maLoaiSP;
        private string maGiamGia;

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

        public string DonVi
        {
            get { return donVi; }
            set { donVi = value; }
        }

        public string DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        public string MaLoaiSP
        {
            get { return maLoaiSP; }
            set { maLoaiSP = value; }
        }

        public string MaGiamGia
        {
            get { return maGiamGia; }
            set { maGiamGia = value; }
        }

        public Product()
        {
        }

        public Product(string maSP, string tenSP, string donVi, string donGia, string maLoaiSP, string maGiamGia)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.donVi = donVi;
            this.donGia = donGia;
            this.maLoaiSP = maLoaiSP;
            this.maGiamGia = maGiamGia;
        }

    }
}
