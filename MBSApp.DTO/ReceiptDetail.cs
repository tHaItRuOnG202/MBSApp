using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBSApp.DTO
{
    public class ReceiptDetail
    {
        private string maSP;
        private string tenSP;
        private string donVi;
        private int soLuong;
        private string donGia;
        private string giamGia;
        private string thanhTien;

        public string MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }

        public string TenKH
        {
            get { return tenSP; }
            set { tenSP = value; }
        }

        public string DonVi
        {
            get { return donVi; }
            set { donVi = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public string DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        public string GiamGia
        {
            get { return giamGia; }
            set { giamGia = value; }
        }

        public string ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }

        public ReceiptDetail()
        {
        }

        public ReceiptDetail(string maSP, string tenSP, string donVi, int soLuong, string donGia, string giamGia, string thanhTien)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.donVi = donVi;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.giamGia = giamGia;
            this.thanhTien = thanhTien;
        }
    }
}
