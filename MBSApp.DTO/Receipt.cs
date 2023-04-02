using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBSApp.DTO
{
    public class Receipt
    {
        private string maHoaDon;
        private string maKhachHang;
        private string maNhanVien;
        private DateTime ngayLap;

        public string MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }

        public string MaKhachHang
        {
            get { return maKhachHang; }
            set { maKhachHang = value; }
        }

        public string MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }

        public DateTime NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }

        public Receipt()
        {
        }

        public Receipt(string maHoaDon, string maKhachHang, string maNhanVien, DateTime ngayLap)
        {
            this.maHoaDon = maHoaDon;
            this.maKhachHang = maKhachHang;
            this.maNhanVien = maNhanVien;
            this.ngayLap = ngayLap;
        }
    }
}
