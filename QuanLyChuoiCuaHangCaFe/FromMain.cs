using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChuoiCuaHangCaFe
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien fNhanVien = new frmNhanVien();
            fNhanVien.MdiParent = this;
            fNhanVien.Show();

        }

        private void chiNhánhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
