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
        private string sql1;

        public decimal sum, money, day;
        public string name;
        public string id;
        public string amount;
        public string checkIn;
        public string checkOut;
        public DatPhong()
        {
            this.InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            sum = 0;
            dataGridView1.ForeColor = Color.Black;
            dataGridView2.ForeColor = Color.Black;
        }

        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());

        private void DatPhong_Load(object sender, EventArgs e)
        {
            connection.Open();

            sql1 = "select MALP from LOAIPHONG";
            ComboBoxData(sql1);

            sql = "select PHONG.MALP 'Mã loại phòng', PHONG.TENPHONG 'Tên phòng', TRANGTHAI 'Trạng thái', FORMAT(GIA, '###,###,###') 'Giá tiền (VND)' from PHONG inner join LOAIPHONG on PHONG.MALP = LOAIPHONG.MALP where TRANGTHAI = N'Trống'";
            GetData(sql);

            sql1 = "select PHONG.MALP 'Mã loại phòng', PHONG.TENPHONG 'Tên phòng', TRANGTHAI 'Trạng thái', FORMAT(GIA, '###,###,###') 'Giá tiền (VND)', NGAYDAT 'Ngày đặt', NGAYDI 'Ngày trả' from PHONG inner join LOAIPHONG on PHONG.MALP = LOAIPHONG.MALP inner join DATPHONG on PHONG.MAPHONG = DATPHONG.MAPHONG where TRANGTHAI = N'ĐÃ THUÊ' and MAKH = (select MAKH from KHACHHANG where CCCD_CMND = '" + txbCCCD.Text + "')";
            GetData1(sql1);

            GetSum();


        }

        private void cbxMALP_SelectedValueChanged(object sender, EventArgs e)
        {
            sql = "select PHONG.MALP 'Mã loại phòng', PHONG.TENPHONG 'Tên phòng', TRANGTHAI 'Trạng thái', FORMAT(GIA, '###,###,###') 'Giá tiền (VND)' from PHONG inner join LOAIPHONG on PHONG.MALP = LOAIPHONG.MALP where TRANGTHAI = N'Trống' and PHONG.MALP = '" + cbxMALP.Text.Substring(0, 4) + "'";
            GetData(sql);

        }

        private void btnDatphong_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbHOTEN.Text == string.Empty || txbTENPHONG.Text == string.Empty || cbxTHANHTOAN.Text == string.Empty)
                {
                    MessageBox.Show("Chưa đủ thông tin để tiến hành đặt phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    CheckIn();
                    CheckOut();

                    using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString()))
                    {
                        connection.Open();

                        using (var command = connection.CreateCommand())
                        {

                            command.CommandText = "insert into DATPHONG(MAPHONG,TENPHONG,NGAYDAT,NGAYDI,THANHTOAN) values ((SELECT distinct MAPHONG FROM PHONG WHERE TENPHONG = N'" + txbTENPHONG.Text + "'), N'" + txbTENPHONG.Text + "', '" + checkIn + "', '" + checkOut + "', N'" + cbxTHANHTOAN.Text + "')";
                            command.ExecuteNonQuery();

                            command.CommandText = "update PHONG set TRANGTHAI = N'ĐÃ THUÊ' where PHONG.TENPHONG = N'" + txbTENPHONG.Text + "' ";
                            command.ExecuteNonQuery();

                            command.CommandText = "update DATPHONG set MAKH = (select distinct KHACHHANG.MAKH from KHACHHANG where CCCD_CMND = N'" + txbCCCD.Text + "') where DATPHONG.TENPHONG = N'" + txbTENPHONG.Text + "' ";
                            command.ExecuteNonQuery();

                        }
                    }

                    cbxMALP.Text = string.Empty;
                    txbTENPHONG.Text = string.Empty;
                    DatPhong_Load(this, e);
                    MessageBox.Show("Bạn đã đăng kí thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txbTENPHONG.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            cbxMALP.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString()))
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {

                        command.CommandText = "delete from DATPHONG where MAPHONG = (select MAPHONG from PHONG where TENPHONG = N'" + txbTENPHONG.Text + "')";
                        command.ExecuteNonQuery();

                        command.CommandText = "update PHONG set TRANGTHAI = N'TRỐNG' where PHONG.TENPHONG = N'" + txbTENPHONG.Text + "' ";
                        command.ExecuteNonQuery();


                    }
                }
                txbTENPHONG.Text = string.Empty;
                DatPhong_Load(this, e);
                MessageBox.Show("Bạn vừa hủy một phòng đã đặt", "Đổi phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("Tên phòng muốn đổi chưa đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHOADON_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.name = txbHOTEN.Text;
            hoaDon.id = txbCCCD.Text;
            hoaDon.amount = txbSOLUONG.Text;
            hoaDon.day = txbSONGAY.Text;
            hoaDon.money = txbTONGTIEN.Text;
            this.Hide();
            hoaDon.ShowDialog();
        }

        private void CheckIn()
        {
            checkIn = dateTimePicker1.Text + " " + Check_In.Text + ":00";
        }
        private void CheckOut()
        {
            checkOut = dateTimePicker2.Text + " " + Check_Out.Text + ":00";
        }

        private void GetSum()
        {
            TimeSpan timeSpan = dateTimePicker2.Value - dateTimePicker1.Value;
            sum = 0;
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                money = Convert.ToDecimal(dataGridView2.Rows[i].Cells[3].Value.ToString());
                int diffDays = timeSpan.Days + 1;
                day = Convert.ToDecimal(diffDays);


                if (int.Parse(Check_In.Text) >= 5 && int.Parse(Check_In.Text) < 9)
                {
                    sum += (money * day) + (money * (decimal)0.5);
                }
                else if (int.Parse(Check_In.Text) >= 9 && int.Parse(Check_In.Text) < 14)
                {
                    sum += (money * day) + (money * (decimal)0.3);

                }
                else
                {
                    sum += (money * day);
                }
            }
            txbTONGTIEN.Text = sum.ToString("###,###");
            txbSONGAY.Text = day.ToString();

        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            txbTENPHONG.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            dateTimePicker2.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
            cbxMALP.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
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

        private void btnInformation_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            this.Hide();
            khachHang.ShowDialog();

            txbHOTEN.Text = khachHang.GetName();
            txbCCCD.Text = khachHang.GetCode();
            txbSOLUONG.Text = khachHang.GetQuantity();
            this.Show();

            DatPhong_Load(this, e);
            
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public void GetData1(string data)
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
            dataGridView2.DataSource = dt;
        }

        private void ComboBoxData(string data)
        {
            SqlCommand cmd = new SqlCommand(data, connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();

            connection.Close();

            cbxMALP.DataSource = ds.Tables[0];
            cbxMALP.DisplayMember = "MALP";

        }

    }
}