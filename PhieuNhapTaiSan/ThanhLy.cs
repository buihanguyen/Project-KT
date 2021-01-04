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
    public partial class ThanhLy : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IVT4ILO\SQLEXPRESS;Initial Catalog=KT;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        DataView dv;
        int ID = 0;
        public ThanhLy()
        {
            InitializeComponent();
        }
        private void ketnoicsdl()
        {
            con.Open();
            string sql = "select * from ts where pso like 'XTS%'";
            SqlCommand com = new SqlCommand(sql, con); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu

            da.Fill(dt);  // đổ dữ liệu vào kho
            con.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }
        private void LoadTKduDBCombox()
        {
            con.Open();
            string sql = "select MaTK from TK where MaTK like 'N%'";
            SqlCommand com = new SqlCommand(sql, con); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataSet ds = new DataSet(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(ds);  // đổ dữ liệu vào kho
            cbTkdu.DataSource = ds.Tables[0];
            ////cbTkdu.DisplayMember = "MaTK";
            con.Close();  // đóng kết nối

        }

        private void LoadTKhoanDBCombox()
        {
            con.Open();
            string sql = "select MaTK,TenMaTK from TK";
            SqlCommand com = new SqlCommand(sql, con); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataSet ds = new DataSet(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(ds);  // đổ dữ liệu vào kho
            cbTK.DataSource = ds.Tables[0];
            cbTK.DisplayMember = "MaTK";
            cbTK.ValueMember = "TenMaTK";
            tbTenTaiKhoan.DataBindings.Add("Text", cbTK.DataSource, "TenMaTK");
            tbDes1.DataBindings.Add("Text", cbTK.DataSource, "TenMaTK");
            con.Close();  // đóng kết nối

        }

        private void LoadKHangDBCombox()
        {
            con.Open();
            string sql = "select MSKH,TENKH, dchi from DMKH";
            SqlCommand com = new SqlCommand(sql, con); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataSet ds = new DataSet(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(ds);  // đổ dữ liệu vào kho
            comboMKH.DataSource = ds.Tables[0];
            comboMKH.DisplayMember = "MSKH";
            comboMKH.ValueMember = "TENKH";
            comboMKH.ValueMember = "dchi";
            tbTenKH.DataBindings.Add("Text", comboMKH.DataSource, "TENKH");
            tbDiaChi.DataBindings.Add("Text", comboMKH.DataSource, "dchi");
            con.Close();  // đóng kết nối

        }
        public DataTable XemDL(string sql)
        {
        

            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            adap.Fill(dt);

            return dt;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbPso.Text != "" & tbMSTS.Text != "" & cbTkdu.Text != "" & tbGia.Text != "")
            {
                con.Open();
                /*string sql = string.Format("INSERT INTO[KT].[dbo].[TS](tkdu, MSTS, st, pso) VALUES", tbPso.Text,tbMSTS.Text,cbTkdu.Text,tbGia.Text);

                SqlCommand cmd = new SqlCommand(sql, con);*/

                SqlCommand cmd = new SqlCommand("INSERT INTO [KT].[dbo].[TS](tkdu,MSTS,st,pso) VALUES " +
                    "    ('" + cbTkdu.Text + "','" + tbMSTS.Text + "','" + tbGia.Text + "','" + tbPso.Text + "');", con);
                cmd.ExecuteNonQuery();


                /*SqlCommand cmd2 = new SqlCommand("INSERT INTO [KT].[dbo].[PH](pso,MSKH,ten,ldo,diachi) VALUES " +
                    "    ('" + tbPso.Text + "','" + tbDonVi.Text + "','" + tbLyDo.Text + "','" + tbDiaChi.Text  + "');", con);

                cmd2.ExecuteNonQuery();*/

                con.Close();
                MessageBox.Show("Dữ liệu đã được thêm vào ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ThanhLy_Load(object sender, EventArgs e)
        {
            XemDL("select * from ts ");
            ketnoicsdl();
            this.LoadTKduDBCombox();
            this.LoadTKhoanDBCombox();
            this.LoadKHangDBCombox();
        }

        private void tbCong_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTienHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbTriGia_Click(object sender, EventArgs e)
        {

        }

        private void tbDes1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = XemDL("select * from ts where pso like '%" + txtKeyword.Text.Trim() + "%' ");
        }

        private void comboMKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            float sotien = Convert.ToInt32(tbGia.Text);
            float thue = Convert.ToInt32(tbVAT.Text);

            float kq = Convert.ToInt32(sotien * (thue / 100));
            float trigia = Convert.ToInt32(sotien + kq);
            tbTriGia.Text = trigia.ToString();
            tbThue.Text = kq.ToString();
            tbTienHang.Text = sotien.ToString();
            tbCong.Text = sotien.ToString();
        }

        private void tbPso_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTkdu_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* this.LoadTKduDBCombox();*/
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Main m = new Form_Main();
            m.ShowDialog();
            this.Close();
        }
    }
}
