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
using System.Security.Cryptography;
using System.Configuration;

namespace form
{
    public partial class QuenMK : Form
    {
        public QuenMK()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            mkmBx.UseSystemPasswordChar = !mkmBx.UseSystemPasswordChar;
        }

        private void check()
        {
            connection.Open();
            string query = "select * from NHANVIEN where TENTK='" + tdnBx.Text + "'and CCCD_CMND='" + cmndBx.Text + "'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read() == true)
            {
                connection.Close();
                change_pass();

                Dangnhap dangnhap = new Dangnhap();
                this.Hide();

                dangnhap.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không tồn tại tài khoản", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();

        }
        private void change_pass()
        {
            connection.Open();
            Hash256 h = new Hash256();
            SHA256 sha256Hash = SHA256.Create();
            string hash = h.GetHash(sha256Hash, mkmBx.Text);
            string query = "update NHANVIEN set MATKHAU='" + hash + "'where TENTK='" + tdnBx.Text + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int c = command.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Bạn đã đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            check();

            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dangnhap dangnhap = new Dangnhap();
            this.Hide();

            dangnhap.ShowDialog();
        }
    }
}