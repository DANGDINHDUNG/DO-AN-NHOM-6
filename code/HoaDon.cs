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
    public partial class HoaDon : Form
    {
        private string sql;
        public string name;
        public string id;
        public string day;
        public string money;
        public string amount;

        public decimal totalMoney;
        public decimal discountMoney;

        public HoaDon()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());


        private void HoaDon_Load(object sender, EventArgs e)
        {
            txbHOTEN.Text = name;
            txbCCCD.Text = id;
            txbSONGAY.Text = day;
            txbTONGTIEN.Text = money;
            txbSOLUONG.Text = amount;

            sql = "select PHONG.MALP 'Mã loại phòng', PHONG.TENPHONG 'Tên phòng', TRANGTHAI 'Trạng thái', FORMAT(GIA, '###,###,###') 'Giá tiền (VND)', NGAYDAT 'Ngày đặt', NGAYDI 'Ngày trả', THANHTOAN 'Thanh toán' from PHONG inner join LOAIPHONG on PHONG.MALP = LOAIPHONG.MALP inner join DATPHONG on PHONG.MAPHONG = DATPHONG.MAPHONG where TRANGTHAI = N'ĐÃ THUÊ' and MAKH = (select MAKH from KHACHHANG where CCCD_CMND = '" + txbCCCD.Text + "')";
            SqlCommand com = new SqlCommand(sql, connection);

            GetData(com);

            connection.Open();

            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                Check_In.Text = dr[4].ToString();
                Check_Out.Text = dr[5].ToString();
                txbTHANHTOAN.Text = dr[6].ToString();
            }
            connection.Close();
        }

        private void HoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DatPhong datPhong = new DatPhong();
            datPhong.name = txbHOTEN.Text;
            datPhong.id = txbCCCD.Text;
            datPhong.amount = txbSOLUONG.Text;
            this.Hide();
            datPhong.ShowDialog();

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
                    using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString()))
                    {
                        connection.Open();

                        using (var command = connection.CreateCommand())
                        {

                            command.CommandText = "insert into HOADON(NGAYLAP,HINHTHUCTT,TINHTIEN,MAKH,CheckIn,CheckOut,SOPHONG) " +
                                "values ('" + dateTimePicker3.Text + "', N'" + txbTHANHTOAN.Text + "', N'" + txbTHANHTIEN.Text + "', " +
                                "(select MAKH from KHACHHANG where CCCD_CMND = '" + txbCCCD.Text + "' ), '" + Check_In.Text + "', " +
                                "'" + Check_Out.Text + "', (select count(MAPHONG) from DATPHONG where MAKH = " +
                                "(select MAKH from KHACHHANG where CCCD_CMND = '" + txbCCCD.Text + "')))";
                            command.ExecuteNonQuery();

                            command.CommandText = "update DATPHONG set MAHD = (select MAHD from HOADON where MAKH = (select MAKH from KHACHHANG where CCCD_CMND = '" + txbCCCD.Text + "')) where MAKH = (select MAKH from KHACHHANG where CCCD_CMND = '" + txbCCCD.Text + "')";
                            command.ExecuteNonQuery();

                            command.CommandText = "insert into DOANHTHU(DOANHTHU,THANG,NAM) values ('" + txbTHANHTIEN.Text + "', '" + dateTimePicker3.Value.Month.ToString() + "', '" + dateTimePicker3.Value.Year.ToString() + "')";
                            command.ExecuteNonQuery();

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
    }
}
