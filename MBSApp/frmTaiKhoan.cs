using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MBSApp.DAO;

namespace MBSApp
{
    public partial class frmTaiKhoan : Form
    {
        QLBanHangDataContext db;
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            //Account la Khach hang
            if (cboRoleLists.SelectedIndex == 0)
            {
                db = new QLBanHangDataContext();
                var kid = from k in db.KhachHangs
                          join u in db.TaiKhoans
                          on k.MaKH equals u.UserID

                          select new
                          {
                              u.TenDangNhap,
                              u.MatKhau
                          };

                int count = 0;
                foreach (var i in kid)
                {
                    if (txtTenDN.Text == i.TenDangNhap && txtMatKhau.Text == i.MatKhau)
                    {
                        MessageBox.Show("Successful!");
                        TrangChuMuaHang trangChuMuaHang = new TrangChuMuaHang();
                        trangChuMuaHang.ShowDialog();
                        break;
                    }
                    else
                    {
                        count++;
                    }
                    if (kid.Count() == count)
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                        break;
                    }
                }
            }

            //Account là nhân viên
            if (cboRoleLists.SelectedIndex == 1)
            {
                db = new QLBanHangDataContext();
                var nvid = from n in db.NhanViens
                           join u in db.TaiKhoans
                           on n.MaNV equals u.UserID

                           select new
                           {
                               u.TenDangNhap,
                               u.MatKhau
                           };

                int count = 0;
                foreach (var n in nvid)
                {
                    if (txtTenDN.Text == n.TenDangNhap && txtMatKhau.Text == n.MatKhau)
                    {
                        //MessageBox.Show(n.TenDangNhap, n.MatKhau);
                        MessageBox.Show("Successful!");
                        frmTrangChu frmTrangChu = new frmTrangChu();
                        frmTrangChu.ShowDialog();
                        break;
                    }
                    else
                    {
                        count++;
                    }
                    if (nvid.Count() == count)
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                        break;
                    }    
                }
            }
        }
    }
}
