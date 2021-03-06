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
using System.Configuration;

namespace form
{
    public partial class Dangki : Form
    {
        public Dangki()
        {
            InitializeComponent();
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
        private bool Check(string txt)
        {
            long num;
            if (long.TryParse(txt, out num))
                return true;
            else
                return false;
        }

        private void count()
        {
            string count = "";
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());

            connection.Open();
            string query = @"SELECT MAX(MANV) FROM NHANVIEN WHERE MANV!= 'ADM'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        count = reader.GetString(0);
                    }
                }
            }

            if (count == "")
            {
                s = "NV01";
            }
            else
            {
                count = count.Substring(2);
                int stt = Convert.ToInt32(count);
                stt++;
                s = "NV" + stt.ToString("00");
            }
            connection.Close();
        }

        private void add()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());
            connection.Open();
            Hash256 h = new Hash256();
            SHA256 sha256Hash = SHA256.Create();
            string hash = h.GetHash(sha256Hash, mkBox.Text);
            string ngay = ngvlDtp.Value.ToString("MM/dd/yyyy");
            string gioitinh = "Nam";
            if (NamRbtn.Checked == true)
            {
                gioitinh = "Nam";
            }
            else gioitinh = "Nữ";
            string sql = "INSERT INTO NHANVIEN(MANV,TENTK,MATKHAU,HOTEN,TUOI,SDT,CCCD_CMND,NGVL,GIOITINH)VALUES " +
    "('" + s + "','" + tdnBox.Text + "','" + hash + "',N'" + hotenBox.Text + "','" + tuoiBox.Text + "','" +
     sdtBox.Text + "','" + cmndBox.Text + "','" + ngay + "',N'" + gioitinh + "')";
            SqlCommand command = new SqlCommand(sql, connection);
            int c = command.ExecuteNonQuery();
        }



        private void dkiBtn_Click(object sender, EventArgs e)
        {
            if (tdnBox.Text == string.Empty || mkBox.Text == string.Empty || nlmkBox.Text == string.Empty || hotenBox.Text == string.Empty || tuoiBox.Text == string.Empty || cmndBox.Text == string.Empty || sdtBox.Text == string.Empty || !Check(sdtBox.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (mkBox.Text == nlmkBox.Text)
                {

                    count();
                    add();
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
            Dangnhap frm = new Dangnhap();
            this.Hide();
            frm.ShowDialog();
        }
        private void Dangki_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void DangkyPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void logoPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void NuRbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NamRbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Title_Lb_Click(object sender, EventArgs e)
        {

        }

        private void nlmkBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mkBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tdnBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sdtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmndBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tuoiBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hotenBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void hoten_Click_1(object sender, EventArgs e)
        {

        }
    }
}