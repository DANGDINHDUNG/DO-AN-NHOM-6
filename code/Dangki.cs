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
                    //// Tui sửa lại tên server
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-MJ9HPF9\HOANGMAI;Initial Catalog=QLKS;Integrated Security=True");
                    connection.Open();
                    Hash256 h=new Hash256();
                    SHA256 sha256Hash = SHA256.Create();
                    string hash =h.GetHash(sha256Hash, mkBox.Text);
                    string query ="SELECT COUNT(MANV) FROM NHANVIEN WHERE TENTK!= admin"
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        int stt = reader.GetInt32(0)+1;
                    }
                    string sql = "INSERT INTO NHANVIEN(MANV,TENTK,MATKHAU,HOTEN,TUOI,NGVL,SDT,CCCD_CMND,SODONDP,LUONG)VALUES " +
                        "('SV"+stt.ToString("0")+"','"+ tdnBox.Text + "','" + hash + "','" + hotenBox.Text + "','" + tuoiBox.Text + "','"+  
                        ngvlBox.Text + "','"+ sdtBox.Text + "','" + cmndBox.Text + "','" + sodondpBox.Text + "','"+ luongBox.Text + "')";
                    SqlCommand command = new SqlCommand(sql, connection);
                    int c = command.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã đăng kí thành công", "Thông báo", MessageBoxButtons.OK);
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

        private void Dangki_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hoten_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
