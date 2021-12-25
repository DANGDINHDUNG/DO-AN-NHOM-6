using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class DoanhThu : Form
    {
        public string day;
        public string sql;

        public string money;
        public string dateTime;

        public DateTime date;


        public DoanhThu()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            Checked_Date(this, e);
        }

        private void Checked_Date(object sender, EventArgs e)
        {
            chartControl1.Series["Doanh thu"].Points.Clear();
            if (rbtnToday.Checked)
            {
                date = DateTime.Now;
                sql = "select sum(DOANHTHU), THOIGIAN from DOANHTHU where THOIGIAN = '" + date.ToString("MM/dd/yyyy") + "' group by THOIGIAN";
                Chart(sql);
            }
            else if (rbtnThisMonth.Checked)
            {
                date = DateTime.Now;
                sql = "select sum(DOANHTHU), THOIGIAN from DOANHTHU where month(THOIGIAN) = '" + date.ToString("MM") + "' and year(THOIGIAN) = '" + date.ToString("yyyy") + "' group by THOIGIAN";
                Chart(sql);
            }
            else if (rbtnLastMonth.Checked)
            {
                date = DateTime.Now.AddMonths(-1);
                sql = "select sum(DOANHTHU), THOIGIAN from DOANHTHU where month(THOIGIAN) = '" + date.ToString("MM") + "' and year(THOIGIAN) = '" + date.ToString("yyyy") + "' group by THOIGIAN";
                Chart(sql);
            }
            else if (rbtnThisYear.Checked)
            {
                date = DateTime.Now;
                sql = "select sum(DOANHTHU), THOIGIAN from DOANHTHU where year(THOIGIAN) = '" + date.ToString("yyyy") + "' group by THOIGIAN";
                Chart(sql);
            }
            else
            {
                date = DateTime.Now.AddYears(-1);
                sql = "select sum(DOANHTHU), THOIGIAN from DOANHTHU where year(THOIGIAN) = '" + date.ToString("yyyy") + "' group by THOIGIAN";
                Chart(sql);
            }
        }

        private void Chart(string data)
        {
            connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(data, connection);
                SqlDataReader reader;

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    money = reader[0].ToString();
                    dateTime = reader[1].ToString();
                    chartControl1.Series["Doanh thu"].Points.AddPoint(Convert.ToDateTime(dateTime), Convert.ToDouble(money));
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
