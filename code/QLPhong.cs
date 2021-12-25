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
    public partial class QLPhong : Form
    {
        public string sql;
        public bool existsRoomCode = false;

        public QLPhong()
        {
            InitializeComponent();
            dgvLOAIPHONG.ForeColor = Color.Black;
            dgvPHONG.DefaultCellStyle.Font = new Font("Segoe UI", 12, GraphicsUnit.Pixel);
            dgvLOAIPHONG.DefaultCellStyle.Font = new Font("Segoe UI", 12, GraphicsUnit.Pixel);
            dgvPHONG.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, GraphicsUnit.Pixel);
        }

        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());


        private void QLPhong_Load(object sender, EventArgs e)
        {
            sql = "select MALP 'Mã loại phòng', TENLP 'Tên loại phòng', FORMAT(GIA, '###,###,###') 'Giá tiền (VND)' from LOAIPHONG order by GIA desc";
            GetData(sql);

            sql = "select PHONG.MALP 'Mã LP', PHONG.TENPHONG 'Tên phòng', TRANGTHAI 'Trạng thái', FORMAT(GIA, '###,###,###') 'Giá tiền (VND)' from PHONG inner join LOAIPHONG on PHONG.MALP = LOAIPHONG.MALP where TRANGTHAI = N'Trống' order by GIA desc";
            GetData1(sql);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn xóa toàn bộ mã loại phòng?\n('YES' để xóa toàn bộ, 'NO' để xóa mã loại phòng đã chọn)", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString()))
                    {
                        connection.Open();

                        using (var command = connection.CreateCommand())
                        {

                            command.CommandText = "delete from LOAIPHONG";
                            command.ExecuteNonQuery();

                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Để tránh xảy ra lỗi, vui lòng xóa hết danh sách phòng được thêm vào để có thể tiến hành thao tác xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (result == DialogResult.No)
            {
                try
                {
                    if (txbMALP.Text == string.Empty || txbTENLP.Text == string.Empty || txbGIA.Text == string.Empty)
                    {
                        MessageBox.Show("Vui lòng chọn loại phòng cần xóa để có thể tiến hành thao tác xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString()))
                        {
                            connection.Open();

                            using (var command = connection.CreateCommand())
                            {

                                command.CommandText = "delete from LOAIPHONG where MALP = '" + txbMALP.Text + "'";
                                command.ExecuteNonQuery();

                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Để tránh xảy ra lỗi, vui lòng xóa hết danh sách phòng có cùng mã loại phòng '" + txbMALP.Text + "' được thêm vào để có thể tiến hành thao tác xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            QLPhong_Load(this, e);
        }
        private bool Check(string txt)
        {
            long num;
            if (long.TryParse(txt, out num))
                return true;
            else
                return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txbMALP.Text == string.Empty || txbTENLP.Text == string.Empty || txbGIA.Text == string.Empty || !Check(txbGIA.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin để có thể thêm mã phòng mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString()))
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {

                        CheckExists();

                        if (existsRoomCode)
                        {
                            command.CommandText = "update LOAIPHONG set TENLP = N'" + txbTENLP.Text + "', GIA = '" + txbGIA.Text + "' where MALP = '" + txbMALP.Text + "'";
                            command.ExecuteNonQuery();

                            MessageBox.Show("Cập nhật loại phòng '" + txbMALP.Text + "' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            existsRoomCode = false;
                        }
                        else
                        {
                            command.CommandText = "insert into LOAIPHONG(MALP, TENLP, GIA) values ('" + txbMALP.Text + "', N'" + txbTENLP.Text + "', '" + txbGIA.Text + "')";
                            command.ExecuteNonQuery();

                            MessageBox.Show("Thêm mới loại phòng '" + txbMALP.Text + "' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            QLPhong_Load(this, e);
        }

        private void dgvLOAIPHONG_Click(object sender, EventArgs e)
        {
            txbMALP.Text = dgvLOAIPHONG.SelectedRows[0].Cells[0].Value.ToString();
            txbTENLP.Text = dgvLOAIPHONG.SelectedRows[0].Cells[1].Value.ToString();
            txbGIA.Text = dgvLOAIPHONG.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn xóa toàn bộ danh sách phòng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString()))
                    {
                        connection.Open();

                        using (var command = connection.CreateCommand())
                        {

                            command.CommandText = "delete from PHONG";
                            command.ExecuteNonQuery();

                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Để tránh xảy ra lỗi, các phòng phải ở trong trạng thái trống để có thể tiến hành thao tác xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            QLPhong_Load(this, e);
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            List<string> selectedRoom = new List<string>();
            for (int i = 0; i < dgvPHONG.SelectedRows.Count; i++)
            {
                selectedRoom.Add(dgvPHONG.SelectedRows[i].Cells[1].Value.ToString());
            }

            var result = MessageBox.Show("Bạn có muốn xóa những phòng đã chọn?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                try
                {
                    using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString()))
                    {
                        connection.Open();

                        using (var command = connection.CreateCommand())
                        {

                            for (int i = 0; i < selectedRoom.Count; i++)
                            {
                                command.CommandText = "delete from PHONG where TENPHONG = N'" + selectedRoom[i] + "'";
                                command.ExecuteNonQuery();
                            }

                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Để tránh xảy ra lỗi, các phòng phải ở trong trạng thái trống để có thể tiến hành thao tác xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            QLPhong_Load(this, e);
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            HaiCachThemPhong haiCachThemPhong = new HaiCachThemPhong();
            haiCachThemPhong.ShowDialog();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel Files (.xlsx*)|*.xlsx";
            saveFileDialog1.FileName = "danh_sach_phong";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ToExcel(dgvPHONG, saveFileDialog1.FileName);
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
            dgvLOAIPHONG.DataSource = dt;
        }

        public void GetData1(string data)
        {
            connection.Open();
            string sql = data;
            SqlCommand com = new SqlCommand(sql, connection);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            dgvPHONG.DataSource = dt;
        }

        private void CheckExists()
        {
            for (int i = 0; i < dgvLOAIPHONG.Rows.Count - 1; i++)
            {
                if (dgvLOAIPHONG.Rows[i].Cells[0].Value.ToString() == txbMALP.Text)
                {
                    existsRoomCode = true;
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
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
