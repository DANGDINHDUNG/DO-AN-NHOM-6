using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class MainForm : Form
    {
        bool check=false;
        public bool Check
        {
           set
            {
                check= value;
            }
        }
        public MainForm()
        {
            InitializeComponent();
            button3.Visible = false;
            button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dangki frm = new Dangki(this);
            this.Hide();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dangnhap frm = new Dangnhap(this);
            this.Hide();
            frm.ShowDialog();
            if (check == true)
            {
                button3.Visible = true;
                button3.Enabled = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chắc chắn đăng xuất", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            check = false;
            button3.Visible = false;
            button3.Enabled = false;
        }
    }
}
