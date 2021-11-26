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

namespace DOAN
{
    public partial class QuenMK : Form
    {
        public QuenMK()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            mkmBx.UseSystemPasswordChar = !mkmBx.UseSystemPasswordChar;
        }

        private void check()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-K8QQEUE;Initial Catalog=QL;Integrated Security=True");
            connection.Open();
            string query = "select * from NHANVIEN where TENTK='" + tdnBx.Text + "'and CCCD_CMND='" + cmndBx.Text + "'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read() == true)
            {
                change_pass();
            }
            else
            {
                MessageBox.Show("Không tồn tại tài khoản", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void change_pass()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-K8QQEUE;Initial Catalog=QLKS;Integrated Security=True");
            connection.Open();
            string query = "update NHANVIEN set MATKHAU='" + mkmBx.Text + "'where TENTK='" + tdnBx.Text + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int c = command.ExecuteNonQuery();
            MessageBox.Show("Bạn đã đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            check();
        }
    }
}
