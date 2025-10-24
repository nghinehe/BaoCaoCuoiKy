using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyChuoiCuaHangCaFe
{
    public partial class frmNhanVien : Form
    {
        SqlConnection ketNoi;
        SqlDataAdapter boDocGhi;
        DataSet dsNV;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCN_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            string chuoiKN = "Data Source=LAPTOP-PGJIPCT2;Initial Catalog=QuanLyChuoiCuaHangCafe;Integrated Security=True;Encrypt=False";
            ketNoi = new SqlConnection(chuoiKN);
            string sqlCommand = "SELECT * FROM NhanVien";
            boDocGhi = new SqlDataAdapter(sqlCommand, ketNoi);

            dsNV = new DataSet();

            boDocGhi.Fill(dsNV);

            dgvNhanVien.DataSource = dsNV.Tables[0];
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int idRow = dgvNhanVien.CurrentRow.Index;

            txtMaNV.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtTenNV.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            txtChiNhanh.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();

        }

        private void lblQLNhanVien_Click(object sender, EventArgs e)
        {

        }
    }
}
