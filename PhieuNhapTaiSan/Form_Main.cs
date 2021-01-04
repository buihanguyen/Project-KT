using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhieuNhapTaiSan
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhapMua nm = new NhapMua();
            nm.ShowDialog();
            this.Close();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhapMua tl = new NhapMua();
            tl.ShowDialog();
            this.Close();
        }

        private void btnThanhLy_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThanhLy tl = new ThanhLy();
            tl.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            khauhao tl = new khauhao();
            tl.ShowDialog();
            this.Close();
        }
    }
}
