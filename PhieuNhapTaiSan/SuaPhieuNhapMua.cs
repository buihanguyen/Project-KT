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

namespace PhieuNhapTaiSan
{
    public partial class SuaPhieuNhapMua : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IVT4ILO\SQLEXPRESS;Initial Catalog=KT;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataSet ds;
        DataTable dt;
        int ID = 0;
        public SuaPhieuNhapMua()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Main tl = new Form_Main();
            tl.ShowDialog();
            this.Close();
        }

        private void tbTenTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }
        private void ketnoicsdl()
        {
            con.Open();
            string sql = "select * from ts";
            SqlCommand com = new SqlCommand(sql, con); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            con.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            cbHTTToan.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            tbGia.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            tbPso.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            tbTKdu.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            tbMSTS.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }

        private void SuaPhieuNhapMua_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }
    }
}
