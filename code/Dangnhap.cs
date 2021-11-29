using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Configuration;

namespace form
{
    public partial class Dangnhap : Form
    {
        string maso;
        public Dangnhap()
        {
            InitializeComponent();
            this.frm = frm;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        private void loginBtn_Click(object sender, EventArgs e)
        {
            //// Tui sửa lại tên server
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());
            connection.Open();
            string tk = userBox.Text;
            string mk = passBox.Text;
            Hash256 h = new Hash256();
            SHA256 sha256Hash = SHA256.Create();
            string hash = h.GetHash(sha256Hash, passBox.Text);
            string query = "select MANV from NHANVIEN where TENTK='" + tk + "'and MATKHAU='" + hash + "'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();*/
            if (reader.Read() == true)
            {
                MessageBox.Show("Bạn đã đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
                maso = reader.GetString(0);
                this.Hide();
                if(maso=="ADM")
                {
                    Demo frm=new Demo(maso);
                    frm.ShowDialog();
                }
                else
                {
                    FormNV frm=new FormNV(maso);
                    frm.ShowDialog();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên hoặc mật khẩu", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            QuenMK frm = new QuenMK();
            frm.ShowDialog();
            this.close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            passBox.UseSystemPasswordChar = !passBox.UseSystemPasswordChar;
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            frm.Show();
        }
    }
}
