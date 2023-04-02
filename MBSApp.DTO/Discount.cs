using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBSApp.DTO
{
    public class Discount
    {
        private string maGiamGia;
        private string giamGia;

        public string MaGiamGia
        {
            get { return maGiamGia; }
            set { giamGia = value; }
        }

        public string GiamGia
        {
            get { return giamGia; }
            set { giamGia = value; }
        }

        public Discount()
        {
        }

        public Discount(string maGiamGia, string giamGia)
        {
            this.maGiamGia = maGiamGia;
            this.giamGia = giamGia;
        }
    }
}
