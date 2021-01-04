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
    public partial class khauhao : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IVT4ILO\SQLEXPRESS;Initial Catalog=KT;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataSet ds;
        DataTable dt;
        int ID = 0;
        public khauhao()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ketnoicsdl()
        {
            con.Open();
            string sql = "select tkdu, MSTS, st, nsdung from ts";
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
            ketnoicsdl();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Đóng_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Main tl = new Form_Main();
            tl.ShowDialog();
            this.Close();
        }

        /*public void TinhtongKH()
        {
            int sc = dataGridView1.Rows.Count;
            float thanhtien = 0;
            string soHoaDon = "abc";
            for (int i = 0; i < sc - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells['SoHoaDon'].Value.ToString() == st)
                {
                    thanhtien += float.Parse(dataGridView1.Rows[i].Cells['thanhtien'].Value.ToString());
                }
            }
        }*/
    }
}
