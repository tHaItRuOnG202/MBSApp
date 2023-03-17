using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MBS.DTO;
using MBS.BUS;

namespace MBSApp
{
    public partial class frmDMNhanVien : Form
    {
        ThemBUS ib = new ThemBUS();
        public frmDMNhanVien()
        {
            InitializeComponent();
        }

        private void frmDMNhanVien_Load(object sender, EventArgs e)
        {
            dgvDMNhanVien.DataSource = ib.ShowEmpoyees();
        }
    }
}
