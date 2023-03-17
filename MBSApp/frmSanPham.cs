using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MBS.BUS;
using MBS.DTO;

namespace MBSApp
{
    public partial class frmSanPham : Form
    {
        ThemBUS ib = new ThemBUS();
        public frmSanPham()
        {
            InitializeComponent();
        }

        //Chua viet duoc trong DAO nen phai viet trong GUI
        //public void ShowSanPham()
        //{
        //    var sanpham = from p in db.SanPhams
        //                  join c in db.LoaiSPs
        //                  on p.MaLoaiSP equals c.MaLoaiSP
        //                  select new
        //                  {
        //                      p.MaSP,
        //                      p.TenSP,
        //                      c.TenLoaiSP,
        //                      p.DonVi,
        //                      p.DonGia
        //                  };
        //    dgvDMSanPham.DataSource = sanpham;

        //}

        //Da viet duoc tren DAO
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            dgvDMSanPham.DataSource = ib.ShowProducts();
            
        }
    }
}
