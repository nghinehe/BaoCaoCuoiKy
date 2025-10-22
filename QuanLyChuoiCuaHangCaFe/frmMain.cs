using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmNhanVien")
                {
                    f.Activate();
                    return;
                }
             }

            frmNhanVien fNhanVien = new frmNhanVien();
            fNhanVien.MdiParent = this;
            fNhanVien.Show();

        }

        private void chiNhánhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmChiNhanh")
                {
                    f.Activate();
                    return;
                }
            }
            frmChiNhanh fChiNhanh = new frmChiNhanh();
            fChiNhanh.MdiParent = this;
            fChiNhanh.Show();
 


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmNhanVien")
                {
                    f.Activate();
                    return;
                }
            }

            frmNhanVien fNhanVien = new frmNhanVien();
            fNhanVien.MdiParent = this;
            fNhanVien.Show();

        }

        private void sảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmSanPham")
                {
                    f.Activate();
                    return;
                }
            }
            frmSanPham fSanPham = new frmSanPham();
            fSanPham.MdiParent = this;
            fSanPham.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmHoaDon")
                {
                    f.Activate();
                    return;
                }
            }
            frmHoaDon fHoaDon = new frmHoaDon();
            fHoaDon.MdiParent = this;
            fHoaDon.Show();
        }

        private void CNtoolStripButton2_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmChiNhanh")
                {
                    f.Activate();
                    return;
                }
            }
            frmChiNhanh fChiNhanh = new frmChiNhanh();
            fChiNhanh.MdiParent = this;
            fChiNhanh.Show();

        }

        private void SPtoolStripButton3_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmSanPham")
                {
                    f.Activate();
                    return;
                }
            }
            frmSanPham fSanPham = new frmSanPham();
            fSanPham.MdiParent = this;
            fSanPham.Show();
        }

        private void HDtoolStripButton4_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmHoaDon")
                {
                    f.Activate();
                    return;
                }
            }
            frmHoaDon fHoaDon = new frmHoaDon();
            fHoaDon.MdiParent = this;
            fHoaDon.Show();
        }
    }
}
