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
        public string name;
        public string id;
        public DatPhong()
        {
            this.InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void DatPhong_Load(object sender, EventArgs e)
        {
            txbHOTEN.Text = name;
            txbCCCD.Text = id;
            sql = "select PHONG.MALP 'Mã phòng', PHONG.TENPHONG 'Tên phòng', TRANGTHAI 'Trạng thái', FORMAT(GIA, '###,###,###') 'Giá tiền (VND)' from PHONG inner join LOAIPHONG on PHONG.MALP = LOAIPHONG.MALP where TRANGTHAI = N'Trống'";
            GetData(sql);

        }

        private void cbxMALP_SelectedValueChanged(object sender, EventArgs e)
        {
            sql = "select PHONG.MALP 'Mã loại phòng', PHONG.TENPHONG 'Tên phòng', TRANGTHAI 'Trạng thái', FORMAT(GIA, '###,###,###') 'Giá tiền (VND)' from PHONG inner join LOAIPHONG on PHONG.MALP = LOAIPHONG.MALP where TRANGTHAI = N'Trống' and PHONG.MALP = '" + cbxMALP.Text.Substring(0, 3) + "'";
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

        }

        private void btnDatphong_Click(object sender, EventArgs e)
        {
            if (txbHOTEN.Text == string.Empty || txbTENPHONG.Text == string.Empty || cbxTHANHTOAN.Text == string.Empty)
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

                        command.CommandText = "insert into DATPHONG(MAKH,MAPHONG,NGAYDAT,NGAYDI,THANHTOAN) values ((select distinct KHACHHANG.MAKH from KHACHHANG where CCCD_CMND = N'" + txbCCCD.Text + "'), (SELECT distinct MAPHONG FROM PHONG WHERE TENPHONG = N'" + txbTENPHONG.Text + "'), '" + dateTimePicker1.Text + "', '" + dateTimePicker2.Text + "', N'" + cbxTHANHTOAN.Text + "')";
                        command.ExecuteNonQuery();

                        command.CommandText = "update PHONG set TRANGTHAI = N'ĐÃ THUÊ' where PHONG.TENPHONG = N'" + txbTENPHONG.Text + "' ";
                        command.ExecuteNonQuery();


                    }
                }
            }
            cbxMALP.Text = string.Empty;
            txbTENPHONG.Text = string.Empty;
            DatPhong_Load(this, e);
            MessageBox.Show("Bạn đã đăng kí thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txbTENPHONG.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            switch (dataGridView1.SelectedRows[0].Cells[0].Value.ToString())
            {
                case "RST":
                    {
                        cbxMALP.Text = "RST (Phòng tổng thống)";
                        break;
                    }
                case "VIP":
                    {
                        cbxMALP.Text = "VIP (Phòng V.I.P)";

                        break;
                    }
                case "NRM":
                    {
                        cbxMALP.Text = "NRM (Phòng phổ thông)";
                        break;
                    }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
