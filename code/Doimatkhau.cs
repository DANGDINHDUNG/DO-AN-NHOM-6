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
using System.Configuration;
using System.Security.Cryptography;

namespace form
{
    public partial class Doimatkhau : Form
    {
        public Doimatkhau()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            mkcBox.UseSystemPasswordChar = !mkcBox.UseSystemPasswordChar;
            mkmBox.UseSystemPasswordChar = !mkmBox.UseSystemPasswordChar;
            nlmkBox.UseSystemPasswordChar = !nlmkBox.UseSystemPasswordChar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //// Tui sửa lại tên server
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());
            connection.Open();
            Hash256 h1 = new Hash256();
            SHA256 sha256Hash1 = SHA256.Create();
            string hash1 = h1.GetHash(sha256Hash1, mkcBox.Text);
            Hash256 h = new Hash256();
            SHA256 sha256Hash = SHA256.Create();
            string hash = h.GetHash(sha256Hash, mkmBox.Text);
            string query = "select * from NHANVIEN where TENTK='" + tdnBox.Text + "'and MATKHAU='" + hash1 + "'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read() == true)
            {
                if (mkmBox.Text == mkcBox.Text)
                {
                    MessageBox.Show("Mật khẩu mới và mật khẩu cũ không được giống nhau", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (mkmBox.Text == nlmkBox.Text)
                {
                    connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());
                    connection.Open();
                    query = "update NHANVIEN set MATKHAU='" + hash + "'where TENTK='" + tdnBox.Text + "'";
                    command = new SqlCommand(query, connection);
                    int c = command.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu và nhập lại mật khẩu không giống nhau", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}