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
        public string sql1;

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
                sql = "select Format(TONGDOANHTHU, '###,###'), THOIGIANTHUC from (select sum(DOANHTHU) as TONGDOANHTHU from DOANHTHU where day(THOIGIAN) = '" + date.ToString("dd") + "' and month(THOIGIAN) = '" + date.ToString("MM") + "' and year(THOIGIAN) = '" + date.ToString("yyyy") + "') as T, (select distinct CONCAT(day(THOIGIAN), '/', month(THOIGIAN), '/', year(THOIGIAN)) as THOIGIANTHUC from DOANHTHU where day(THOIGIAN) = '" + date.ToString("dd") + "' and month(THOIGIAN) = '" + date.ToString("MM") + "' and year(THOIGIAN) = '" + date.ToString("yyyy") + "') as T2";
                Chart(sql);
                sql1 = "select Format(sum(DOANHTHU), '###,###') 'Doanh thu (VND)', THOIGIAN 'Thời gian' from DOANHTHU where day(THOIGIAN) = '" + date.ToString("dd") + "' and month(THOIGIAN) = '" + date.ToString("MM") + "' and year(THOIGIAN) = '" + date.ToString("yyyy") + "' group by THOIGIAN";
                GetData(sql1);
            }
            else if (rbtnThisMonth.Checked)
            {
                date = DateTime.Now;
                sql = "select Format(sum(DOANHTHU), '###,###') 'Doanh thu (VND)', THOIGIAN 'Thời gian' from DOANHTHU where month(THOIGIAN) = '" + date.ToString("MM") + "' and year(THOIGIAN) = '" + date.ToString("yyyy") + "' group by THOIGIAN";
                Chart(sql);
                GetData(sql);

            }
            else if (rbtnLastMonth.Checked)
            {
                date = DateTime.Now.AddMonths(-1);
                sql = "select Format(sum(DOANHTHU), '###,###') 'Doanh thu (VND)', THOIGIAN 'Thời gian' from DOANHTHU where month(THOIGIAN) = '" + date.ToString("MM") + "' and year(THOIGIAN) = '" + date.ToString("yyyy") + "' group by THOIGIAN";
                Chart(sql);
                GetData(sql);

            }
            else if (rbtnThisYear.Checked)
            {
                date = DateTime.Now;
                sql = "select Format(sum(DOANHTHU), '###,###') 'Doanh thu (VND)', THOIGIAN 'Thời gian' from DOANHTHU where year(THOIGIAN) = '" + date.ToString("yyyy") + "' group by THOIGIAN";
                Chart(sql);
                GetData(sql);

            }
            else
            {
                date = DateTime.Now.AddYears(-1);
                sql = "select Format(sum(DOANHTHU), '###,###') 'Doanh thu (VND)', THOIGIAN 'Thời gian' from DOANHTHU where year(THOIGIAN) = '" + date.ToString("yyyy") + "' group by THOIGIAN";
                Chart(sql);
                GetData(sql);

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
                    chartControl1.Series["Doanh thu"].Points.AddPoint(Convert.ToString(dateTime), Convert.ToDouble(money));
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

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            Checked_Date(this, e);

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel Files (.xlsx*)|*.xlsx";
            saveFileDialog1.FileName = "doanh_thu";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ToExcel(dataGridView1, saveFileDialog1.FileName);
            }
        }

        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                worksheet.Name = "Quản lý khách sạn";

                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                workbook.SaveAs(fileName);
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        public void GetData(string data)
        {
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
    }
}
