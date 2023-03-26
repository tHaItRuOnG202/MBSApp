using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MBSApp
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void TrangChu_Paint(object sender, PaintEventArgs e)
        {
            string slogan = "TRANG CHỦ QUẢN LÝ BÁN HÀNG DI ĐỘNG";
            Rectangle rect = new Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height);
            LinearGradientBrush lgbrush = new LinearGradientBrush(rect, Color.FromArgb(207, 244, 210), Color.FromArgb(86, 197, 150), 1);
            HatchBrush hbr = new HatchBrush(HatchStyle.DottedDiamond, Color.AliceBlue, Color.DarkGreen);
            Font font = new Font("Tahoma", 45, FontStyle.Bold);
            StringFormat format = new StringFormat();
            format.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            e.Graphics.FillRectangle(lgbrush, rect);
            e.Graphics.DrawString(slogan, font, hbr, rect, format);
        }

        private void mnuLoaiSP_Click(object sender, EventArgs e)
        {
            frmDMLoaiSanPham frmDMLoaiSanPham = new frmDMLoaiSanPham();
            frmDMLoaiSanPham.ShowDialog();
        }

        private void mnuNV_Click(object sender, EventArgs e)
        {
            frmDMNhanVien frmDMNhanVien = new frmDMNhanVien();
            frmDMNhanVien.ShowDialog();
        }

        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham frmSanPham = new frmSanPham();
            frmSanPham.ShowDialog();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmDMKhachHang frmDMKhachHang = new frmDMKhachHang();
            frmDMKhachHang.ShowDialog();
        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            frmHoaDonBanHang frmHoaDonBanHang = new frmHoaDonBanHang();
            frmHoaDonBanHang.ShowDialog();
        }

        private void mnuFindHoaDon_Click(object sender, EventArgs e)
        {
            frmTimHoaDon frmTimHoaDon = new frmTimHoaDon();
            frmTimHoaDon.ShowDialog();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
