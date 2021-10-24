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
    public partial class Dangnhap : Form
    {
        
        MainForm frm;
        public Dangnhap(MainForm frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-K8QQEUE;Initial Catalog=QLKS;Integrated Security=True");
            connection.Open();
            string tk = userBox.Text;
            string mk = passBox.Text;

                string query = "select *from KHACHHANG where TENTK='" + tk + "'and MATKHAU='" + mk + "'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read() == true)
                {
                // Ham xu ly cho main form
                    MessageBox.Show("Bạn đã đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
                    frm.Check = true;
                    frm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tên hoặc mật khẩu", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dangki frm = new Dangki(this.frm);
            frm.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            passBox.UseSystemPasswordChar = false;
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            frm.Show();
            this.Close();
        }
    }
}