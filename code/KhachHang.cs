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

namespace form
{
    public partial class KhachHang : Form
    {

        // KHAI BÁO THÔNG TIN FORM
        private string sql;
        private string gender;
        private bool existsCCCD = false;
        private string s;

        public KhachHang()
        {
            this.InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // SỰ KIỆN FORM 
        private void button2_Click(object sender, EventArgs e)
        {
            if (txbHOTEN.Text == string.Empty || txbSDT.Text == string.Empty || comboBox1.Text == string.Empty || txbCCCD.Text == string.Empty)
            {
                MessageBox.Show("Chọn thông tin khách hàng trước khi thực hiện các thao tác.");
                return;
            }
            else
            {
                DatPhong datPhong = new DatPhong();
                datPhong.name = txbHOTEN.Text;
                datPhong.id = txbCCCD.Text;
                datPhong.amount = txbSOLUONG.Text;
                datPhong.ShowDialog();
            }
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            sql = "select * from KHACHHANG";
            GetData(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (txbHOTEN.Text == string.Empty || txbSDT.Text == string.Empty || comboBox1.Text == string.Empty || txbCCCD.Text == string.Empty || txbSOLUONG.Text == string.Empty)
                {
                    return;
                }
                else
                {
                    CheckCCCD();
                    Count();
                    Add();
                }
                KhachHang_Load(this, e);
                MessageBox.Show("Thêm thông tin khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbHOTEN.Text = string.Empty;
                txbSDT.Text = string.Empty;
                comboBox1.Text = "";
                txbCCCD.Text = string.Empty;
                txbSOLUONG.Text = string.Empty;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Nhập liệu thông tin không đúng định dạng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

        }           

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txbHOTEN.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txbSDT.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txbCCCD.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells[5].Value.ToString() == "Nam")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
                txbSOLUONG.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            }
            else
            {
                return;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txbHOTEN.Text == string.Empty || txbSDT.Text == string.Empty || comboBox1.Text == string.Empty || txbCCCD.Text == string.Empty)
            {
                MessageBox.Show("Chọn thông tin khách hàng trước khi thực hiện các thao tác.");
                return;
            }
            else
            {
                DoiPhong doiPhong = new DoiPhong();
                doiPhong.name = txbHOTEN.Text;
                doiPhong.id = txbCCCD.Text;
                doiPhong.amount = txbSOLUONG.Text;
                doiPhong.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txbHOTEN.Text == string.Empty || txbSDT.Text == string.Empty || comboBox1.Text == string.Empty || txbCCCD.Text == string.Empty)
            {
                MessageBox.Show("Chọn thông tin khách hàng trước khi thực hiện các thao tác.");
                return;
            }
            else
            {
                TraPhong traPhong = new TraPhong();
                traPhong.name = txbHOTEN.Text;
                traPhong.id = txbCCCD.Text;
                traPhong.ShowDialog();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sql = @"SELECT * FROM KHACHHANG WHERE HOTEN like  N'%" + textBox1.Text + "%')";
            GetData(sql);
        }

        // CÁC THAO TÁC VỚI FORM

        public void GetData(string data)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());
            connection.Open();
            string sql = data;
            SqlCommand com = new SqlCommand(sql, connection);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            dataGridView1.DataSource = dt;
        }

        private void Add()
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString()))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    if (existsCCCD)
                    {
                        command.CommandText = "update KHACHHANG set HOTEN = N'" + txbHOTEN.Text + "', TUOI = '" + comboBox1.Text + "', " +
                            "GIOITINH = N'" + gender.ToString() + "', SDT = '" + txbSDT.Text + "', SOLUONG = '" + txbSOLUONG.Text + "' " +
                            "where CCCD_CMND = '" + txbCCCD.Text + "' ";
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        command.CommandText = "insert into KHACHHANG(MAKH,HOTEN,TUOI,GIOITINH,SDT,CCCD_CMND,SOLUONG) " +
                            "values ('" + s + "', N'" + txbHOTEN.Text + "' ,'" + comboBox1.Text + "', N'" + gender.ToString() + "', " +
                            "'" + txbSDT.Text + "', '" + txbCCCD.Text + "', '" + txbSOLUONG.Text + "')";
                        command.ExecuteNonQuery();
                    }

                }
            }
        }

        private void Count()
        {
            string count = "";
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());
            connection.Open();
            string query = @"SELECT MAX(MAKH) FROM KHACHHANG";
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
                s = "KH01";
            }
            else
            {
                count = count.Substring(2);
                int stt = Convert.ToInt32(count);
                stt++;
                s = "KH" + stt.ToString("00");
            }
            connection.Close();
        }

        private void CheckCCCD()
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[3].Value.ToString() == txbCCCD.Text)
                {
                    existsCCCD = true;
                }
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                gender = ((RadioButton)sender).Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}