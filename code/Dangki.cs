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

namespace form
{
    public partial class Dangki : Form
    {
        MainForm frm;
        public Dangki(MainForm frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void dkiBtn_Click(object sender, EventArgs e)
        {
            if (tdnBox.Text != null && mkBox.Text != null && nlmkBox.Text != null)
            {
                if (mkBox.Text == nlmkBox.Text)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-K8QQEUE;Initial Catalog=QLKS;Integrated Security=True");
                    connection.Open();
                    string sql = "INSERT INTO KHACHHANG(HOTEN,TENTK,MATKHAU,TUOI,SDT,CMND)VALUES " +
                        "('" + hotenBox.Text + "','" + tdnBox.Text + "','" + mkBox.Text + "','" + tuoiBox.Text + "','"
                        + sdtBox.Text + "','" + cmndBox.Text + "')";
                    SqlCommand command = new SqlCommand(sql, connection);
                    int c = command.ExecuteNonQuery();
                    frm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu và nhập lại mật khẩu không giống nhau", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            mkBox.UseSystemPasswordChar = false;
            nlmkBox.UseSystemPasswordChar = false;
        }

        private void huyBtn_Click(object sender, EventArgs e)
        {

           frm.Show();
           this.Close();
        }
    }
}
