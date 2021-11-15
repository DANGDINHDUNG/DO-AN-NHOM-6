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
    public partial class DatPhong : Form
    {
        private string sql;
        private int stt = 0;
        private string gender;
        public DatPhong()
        {
            this.InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void DatPhong_Load(object sender, EventArgs e)
        {
            
            sql = "select PHONG.MALP 'Mã phòng', PHONG.TENPHONG 'Tên phòng', TRANGTHAI 'Trạng thái', GIA 'Giá tiền (VND)' from PHONG inner join LOAIPHONG on PHONG.MALP = LOAIPHONG.MALP where TRANGTHAI = N'Trống'";
            GetData(sql);

        }

        private void cbxMALP_SelectedValueChanged(object sender, EventArgs e)
        {
            sql = "select PHONG.MALP 'Mã loại phòng', PHONG.TENPHONG 'Tên phòng', TRANGTHAI 'Trạng thái', GIA 'Giá tiền (VND)' from PHONG inner join LOAIPHONG on PHONG.MALP = LOAIPHONG.MALP where TRANGTHAI = N'Trống' and PHONG.MALP = '" + cbxMALP.Text.Substring(0, 3) + "'" ;
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxMALP.Text == string.Empty)
                {
                    txbTENPHONG.Text = "";
                }
                else
                {
                    txbTENPHONG.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnDatphong_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString()))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "update PHONG set TRANGTHAI = N'ĐÃ THUÊ' where PHONG.TENPHONG = '" + txbTENPHONG.Text + "' ";
                    command.ExecuteNonQuery();

                    command.CommandText = "insert into KHACHHANG(MAKH,HOTEN,TUOI,GIOITINH,SDT,CCCD_CMND) values ('null', N'" + txbHOTEN.Text + "' ,'" + comboBox1.Text + "', N'" + gender.ToString() + "', '" + txbSDT.Text + "', '" + txbCCCD.Text + "')";
                    command.ExecuteNonQuery();

                    command.CommandText = "update KHACHHANG set MAKH = 'KH' + cast((select count(MAKH) + 1 from KHACHHANG) as varchar(2)) where HOTEN = '" + txbHOTEN.Text + "'";
                    command.ExecuteNonQuery();
                }
            }
            
            MessageBox.Show("Bạn đã đăng kí thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                gender = ((RadioButton)sender).Text;
        }
    }
}

