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
    public partial class QLThucPham : Form
    {
        public string sql;

        public QLThucPham()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());

        private void QLThucPham_Load(object sender, EventArgs e)
        {
            Checked_Food(this, e);
        }

        private void Checked_Food(object sender, EventArgs e)
        {
            if (rbtnAll.Checked)
            {
                sql = "select MATP 'Mã thực phẩm', TENTP 'Tên thực phẩm', FORMAT(GIATIEN, '###,###,###') 'Giá tiền (VND)', MALTP 'Mã loại thực phẩm' from THUCPHAM order by MALTP desc";
            }
            else if (rbtnFood.Checked)
            {
                sql = "select * from THUCPHAM where MALTP = 'FOD'";
            }
            else
            {
                sql = "select * from THUCPHAM where MALTP = 'DRK' ";
            }

            GetData(sql);
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn xóa toàn bộ danh sách thực phẩm không?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                try
                {
                    using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString()))
                    {
                        connection.Open();

                        using (var command = connection.CreateCommand())
                        {

                            command.CommandText = "delete from THUCPHAM";
                            command.ExecuteNonQuery();

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            QLThucPham_Load(this, e);
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            List<string> selectedProduct = new List<string>();
            for (int i = 0; i < dgvTHUCPHAM.SelectedRows.Count; i++)
            {
                selectedProduct.Add(dgvTHUCPHAM.SelectedRows[i].Cells[1].Value.ToString());
            }

            var result = MessageBox.Show("Bạn có muốn xóa những mục đã chọn?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                try
                {
                    using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString()))
                    {
                        connection.Open();

                        using (var command = connection.CreateCommand())
                        {

                            for (int i = 0; i < selectedProduct.Count; i++)
                            {
                                command.CommandText = "delete from THUCPHAM where TENTP = N'" + selectedProduct[i] + "'";
                                command.ExecuteNonQuery();
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            QLThucPham_Load(this, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ThemThucPham themThucPham = new ThemThucPham();
            themThucPham.ShowDialog();

            QLThucPham_Load(this, e);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel Files (.xlsx*)|*.xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ToExcel(dgvTHUCPHAM, saveFileDialog1.FileName);
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
            dgvTHUCPHAM.DataSource = dt;
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

    }
}
