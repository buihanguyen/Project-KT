using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PhieuNhapTaiSan
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-MCG6S6JA\SQLEXPRESS;Initial Catalog=Taisan_HTTTKT;Integrated Security=True;");

        SqlDataAdapter adpt;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }
      

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTkdu.Text != "" & txtMSTS.Text != "" & txtst.Text != "" & txtPSO.Text != "")
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO [Taisan_HTTTKT].[dbo].[TS](tkdu,MSTS,st,pso) VALUES " +
                    "    ('" + txtTkdu.Text + "','" + txtMSTS.Text + "','" + txtst.Text + "','" + txtPSO.Text + "');", con);
                
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Dữ liệu đã được thêm vào ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
