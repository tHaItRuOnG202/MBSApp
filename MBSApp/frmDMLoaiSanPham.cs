using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MBS.DAO;

namespace MBSApp
{
    public partial class frmDMLoaiSanPham : Form
    {
        HienThiDAO show = new HienThiDAO();
        public frmDMLoaiSanPham()
        {
            InitializeComponent();
        }

        private void frmDMLoaiSanPham_Load(object sender, EventArgs e)
        {
            dgvDMSanPham.DataSource = show.ShowLoaiSP();
        }
    }
}
