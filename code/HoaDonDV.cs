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
    public partial class HoaDonDV : Form
    {
        private string sql;
        public string name;
        public string id;
        public string day;
        public string amount;

        public decimal totalMoney;
        public decimal discountMoney;
        public decimal money;

        public HoaDonDV()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());


        private void HoaDon_Load(object sender, EventArgs e)
        {
            txbHOTEN.Text = name;
            txbTENPHONG.Text = id;
            txbTONGTIEN.Text = money.ToString("###,###");

            sql = "select DATDV.MADV, TENDV, MAKH, FORMAT(TONGTIEN, '###,###,###') as GIATIEN from DATDV inner join DICHVU on DATDV.MADV = DICHVU.MADV where MAKH = (select MAKH from DATPHONG where TENPHONG = N'" + txbTENPHONG.Text + "')";
            SqlCommand com = new SqlCommand(sql, connection);

            GetData(com);

        }

        private void HoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString()))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "delete from DATDV";
                    command.ExecuteNonQuery();
                }
            }
            DichVu dichVu = new DichVu();

            this.Hide();
            dichVu.ShowDialog();

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
            try
            {
                if (txbTHANHTIEN.Text == string.Empty)
                {
                    return;
                }
                else
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString()))
                        {
                            connection.Open();

                            using (var command = connection.CreateCommand())
                            {

                                command.CommandText = "insert into HOADON(MADV,NGAYLAP,TINHTIEN,MAKH) values ('" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "', '" + dateTimePicker3.Text + "', '" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "', (select MAKH from DATPHONG where TENPHONG = N'" + txbTENPHONG.Text + "'))";
                                command.ExecuteNonQuery();

                                command.CommandText = "insert into DOANHTHU(DOANHTHU,THANG,NAM) values ('" + txbTHANHTIEN.Text + "', '" + dateTimePicker3.Value.Month.ToString() + "', '" + dateTimePicker3.Value.Year.ToString() + "')";
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                    MessageBox.Show("Hóa đơn đã được lưu!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
