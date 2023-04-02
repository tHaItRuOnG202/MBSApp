using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBSApp.DTO
{
    public class Categories
    {
        private string maLoaiSP;
        private string tenLoaiSP;

        public string MaLoaiSP
        {
            get { return maLoaiSP; }
            set { maLoaiSP = value; }
        }
        public string TenLoaiSP
        {
            get { return tenLoaiSP; }
            set { tenLoaiSP = value; }
        }

        public Categories()
        {
        }

        public Categories(string maLoaiSP, string tenLoaiSP)
        {
            this.maLoaiSP = maLoaiSP;
            this.tenLoaiSP = tenLoaiSP;
        }
    }
}
