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
    public partial class HoaDonDoAn : Form
    {
        private string sql;
        public string name;
        public string id;
        public string day;
        public string money;
        public string amount;

        public decimal totalMoney;
        public decimal discountMoney;

        public HoaDonDoAn()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());


        private void HoaDon_Load(object sender, EventArgs e)
        {
            txbHOTEN.Text = name;
            txbTENPHONG.Text = id;
            txbSOLUONG.Text = amount;
            txbTONGTIEN.Text = totalMoney.ToString("###,###");

            sql = "select MATP, TENTP, SOLUONG, MAKH, MALTP, FORMAT(TONGTIEN, '###,###,###') as GIATIEN from DATTP";
            SqlCommand com = new SqlCommand(sql, connection);

            GetData(com);           
        }

        public void GetData(SqlCommand com)
        {
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

            decimal discount = Convert.ToDecimal(comboBox1.Text) / 100;
            totalMoney = Convert.ToDecimal(txbTONGTIEN.Text);
            discountMoney = totalMoney - totalMoney * discount;
            txbTHANHTIEN.Text = discountMoney.ToString("###,###");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txbTHANHTIEN.Text == string.Empty)
            {
                return;
            }
            else
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString()))
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {

                        command.CommandText = "insert into HOADONDA(NGAYLAP, TONGTIEN, MAKH, SOLUONG) values ('" + dateTimePicker3.Text + "', '" + txbTHANHTIEN.Text + "', (select MAKH from DATPHONG where TENPHONG = N'" + txbTENPHONG.Text + "'), '" + txbSOLUONG.Text + "')";
                        command.ExecuteNonQuery();

                        command.CommandText = "insert into DOANHTHU(DOANHTHU,THANG,NAM) values ('" + txbTHANHTIEN.Text + "', '" + dateTimePicker3.Value.Month.ToString() + "', '" + dateTimePicker3.Value.Year.ToString() + "')";
                        command.ExecuteNonQuery();

                    }
                }
                MessageBox.Show("Hóa đơn đã được lưu!", "Thông báo");
            }
        }

        private void txbTIENTRA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal paidMoney = Convert.ToDecimal(txbTIENTRA.Text);
                decimal balance = paidMoney - discountMoney;
                txbTIENTHOI.Text = balance.ToString("###,###");
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng tiền tệ!", "Thông báo");
            }

        }

        private void HoaDonDoAn_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString()))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "delete from DATTP";
                    command.ExecuteNonQuery();
                }
            }

            DoAn doAn = new DoAn();
            this.Hide();
            doAn.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
