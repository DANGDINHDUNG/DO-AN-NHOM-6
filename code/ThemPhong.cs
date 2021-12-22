using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class ThemPhong : Form
    {
        public string excelcon;
        public string sql;


        public ThemPhong()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());

        private void btnExportSampleExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel Files (.xlsx*)|*.xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ToExcel(dataGridView1, saveFileDialog1.FileName);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            List<string> listSheet = new List<string>();
            //string namefile;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Excel Files (.xlsx*)|*.xlsx*|All Files (*.*)|*.*";
            dlg.Multiselect = false;

            DialogResult dlgResult = dlg.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                txtFileName.Text = dlg.FileName;

                String filePath = txtFileName.Text;
                if (filePath.Substring(filePath.LastIndexOf('.')).ToLower() == ".xlsx")
                {
                    excelcon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties='Excel 12.0;HDR=NO;IMEX=1'";
                }
                else
                {
                    excelcon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR=NO;IMEX=1'";
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OleDbConnection conexcel = new OleDbConnection(excelcon);


            try
            {
                conexcel.Open();
                DataTable dtExcel = conexcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string sheetName = dtExcel.Rows[0]["Table_Name"].ToString();
                OleDbCommand cmdexcel1 = new OleDbCommand();
                cmdexcel1.Connection = conexcel;
                cmdexcel1.CommandText = "select F1 as MALP, F2 as TENPHONG, F3 as TRANGTHAI, F4 as GIATIEN from[" + sheetName + "]";
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = cmdexcel1;
                da.Fill(dt);
                conexcel.Close();
                dataGridView1.DataSource = dt;
                dataGridView1.Rows.RemoveAt(0);
            }
            catch (Exception ex)
            {
                conexcel.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {               
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString()))
                    {
                        connection.Open();

                        using (var command = connection.CreateCommand())
                        {
                            command.CommandText = "insert into PHONG(MALP, TENPHONG, TRANGTHAI) values ('" + dataGridView1.Rows[i].Cells[4].Value.ToString() + "', " +
                            "N'" + dataGridView1.Rows[i].Cells[5].Value.ToString() + "', N'" + dataGridView1.Rows[i].Cells[6].Value.ToString() + "')";
                            command.ExecuteNonQuery();
                        }
                    }
                }

            }
            catch 
            {
                MessageBox.Show("Phòng đã được thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
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

                for (int i = 1; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    worksheet.Cells[0 + 1, j + 1] = dataGridView1.Columns[j].HeaderText;
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
