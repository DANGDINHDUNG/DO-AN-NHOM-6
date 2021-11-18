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
        private string sql;
        private string gender;
        private bool existsCCCD = false;
        public KhachHang()
        {
            this.InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (txbHOTEN.Text == string.Empty || txbSDT.Text == string.Empty || comboBox1.Text == string.Empty || txbCCCD.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng điền đây đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DatPhong datPhong = new DatPhong();
                datPhong.name = txbHOTEN.Text;
                datPhong.id = txbCCCD.Text;
                datPhong.ShowDialog();
            }
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            sql = "select * from KHACHHANG";
            GetData(sql);
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbHOTEN.Text == string.Empty || txbSDT.Text == string.Empty ||  comboBox1.Text == string.Empty || txbCCCD.Text == string.Empty)
            {
                return;
            }
            else
            {
                CheckCCCD();
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString()))
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        if (existsCCCD)
                        {
                            command.CommandText = "update KHACHHANG set HOTEN = N'" + txbHOTEN.Text + "', TUOI = '" + comboBox1.Text + "', GIOITINH = N'" + gender.ToString() + "', SDT = '" + txbSDT.Text +"' where CCCD_CMND = '" + txbCCCD.Text + "'";
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            command.CommandText = "insert into KHACHHANG(MAKH,HOTEN,TUOI,GIOITINH,SDT,CCCD_CMND) values (('KH' + cast((select count(MAKH) + 1 from KHACHHANG) as varchar(2))), N'" + txbHOTEN.Text + "' ,'" + comboBox1.Text + "', N'" + gender.ToString() + "', '" + txbSDT.Text + "', '" + txbCCCD.Text + "')";
                            command.ExecuteNonQuery();
                        }
                        
                    }
                }
            }
            KhachHang_Load(this, e);
            MessageBox.Show("Thêm thông tin khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txbHOTEN.Text = string.Empty;
            txbSDT.Text = string.Empty;
            comboBox1.Text = "";
            txbCCCD.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                gender = ((RadioButton)sender).Text;
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
            }
            else
            {
                return;
            }
            
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
    }
}
