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

namespace MBSApp
{
    public partial class frmDMLoaiSanPham : Form
    {
        ThemBUS ib = new ThemBUS();
        public frmDMLoaiSanPham()
        {
            InitializeComponent();
        }

        private void frmDMLoaiSanPham_Load(object sender, EventArgs e)
        {
            dgvDMSanPham.DataSource = ib.ShowCategories();
        }
    }
}
