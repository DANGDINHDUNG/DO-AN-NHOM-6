﻿using System;
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
    public partial class Doimatkhau : Form
    {
        MainForm frm;
        public Doimatkhau(MainForm frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            mkcBox.UseSystemPasswordChar = false;
            mkmBox.UseSystemPasswordChar = false;
            nlmkBox.UseSystemPasswordChar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-K8QQEUE;Initial Catalog=QLKS;Integrated Security=True");
            connection.Open();
            string query = "select *from KHACHHANG where TENTK='" + tdnBox.Text + "'and MATKHAU='" + mkcBox.Text + "'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read() == true)
            {
                if(mkmBox.Text == mkcBox.Text)
                {
                    MessageBox.Show("Mật khẩu mới và mật khẩu cũ không được giống nhau", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }
                else if(mkmBox.Text == nlmkBox.Text)
                {
                    connection = new SqlConnection(@"Data Source=DESKTOP-K8QQEUE;Initial Catalog=QLKS;Integrated Security=True");
                    connection.Open();
                    query = "update KHACHHANG set MATKHAU='" + mkmBox.Text + "'where TENTK='" + tdnBox.Text + "'";
                    command = new SqlCommand(query, connection);
                    int c = command.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK);
                    frm.Show();
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
            frm.Show();
            this.Close();
        }
    }
}