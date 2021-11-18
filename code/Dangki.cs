using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace form
{
    public partial class Dangki : Form
    {
        MainForm frm;
        public Dangki(MainForm frm)
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

       string s;
        
        private void count()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-K8QQEUE;Initial Catalog=QL;Integrated Security=True");
            connection.Open();            
            string query = @"SELECT MAX(MANV) FROM NHANVIEN WHERE MANV!= 'ADM'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            string str="", count="";
            if (reader.Read() == true)
            {
                count = reader.GetString(0);
            }
            str = count.Substring(2);
            if (str == "")
            {
                s = "NV01";
            }
            else
            {
                int stt = Convert.ToInt32(str);
                stt ++;
                s = "NV" + stt.ToString("00");
            }
            connection.Close();
        }

        private void them()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-K8QQEUE;Initial Catalog=QL;Integrated Security=True");
            connection.Open();
            Hash256 h = new Hash256();
            SHA256 sha256Hash = SHA256.Create();
            string hash = h.GetHash(sha256Hash, mkBox.Text);
            string ngay = ngvlDtp.Value.ToString("dd/MM/yyyy");
            string gioitinh = "Nam";
            if (NamRbtn.Checked == true)
            {
                gioitinh = "Nam";
            }
            else gioitinh = "Nữ";
            string sql = "INSERT INTO NHANVIEN(MANV,TENTK,MATKHAU,HOTEN,TUOI,SDT,CCCD_CMND,NGVL,LUONG,GIOITINH)VALUES " +
    "('" + s + "','" + tdnBox.Text + "','" + hash + "',N'" + hotenBox.Text + "','" + tuoiBox.Text + "','" +
     sdtBox.Text + "','" + cmndBox.Text + "','" + ngay + "','" + luongBox.Text + "',N'"+gioitinh+ "')";
            SqlCommand command = new SqlCommand(sql, connection);
            int c = command.ExecuteNonQuery();
        }
        private void dkiBtn_Click(object sender, EventArgs e)
        {
            if (tdnBox.Text != null && mkBox.Text != null && nlmkBox.Text != null)
            {
                if (mkBox.Text == nlmkBox.Text)
                {

                    count();
                    them();
                    MessageBox.Show("Bạn đã đăng kí thành công", "Thông báo", MessageBoxButtons.OK);
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
            mkBox.UseSystemPasswordChar = !mkBox.UseSystemPasswordChar;
            nlmkBox.UseSystemPasswordChar = !nlmkBox.UseSystemPasswordChar;
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dangnhap frm = new Dangnhap(this.frm);
            this.Hide();
            frm.ShowDialog();
        }
        private void Dangki_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm.ShowDialog();
            this.Close();
        }
    }
}
