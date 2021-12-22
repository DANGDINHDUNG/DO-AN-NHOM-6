﻿using System;
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
    public partial class TraPhong : Form
    {
        private string sql;
        private string query;
        public string name;
        public string id;

        public decimal paidMoney, sum;
        public decimal lateDay;

        public int lateHour;

        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());

        public TraPhong()
        {
            InitializeComponent();
        }


        //  SỰ KIỆN FORM


        private void TraPhong_Load(object sender, EventArgs e)
        {
            txbHOTEN.Text = name;
            txbCCCD.Text = id;
            sql = "select PHONG.MALP 'Mã loại phòng', PHONG.TENPHONG 'Tên phòng', TRANGTHAI 'Trạng thái', FORMAT(GIA, '###,###,###') 'Giá tiền (VND)', NGAYDAT 'Ngày đặt', NGAYDI 'Ngày trả' from PHONG inner join LOAIPHONG on PHONG.MALP = LOAIPHONG.MALP inner join DATPHONG on PHONG.MAPHONG = DATPHONG.MAPHONG where TRANGTHAI = N'ĐÃ THUÊ' and MAKH = (select MAKH from KHACHHANG where CCCD_CMND = '" + txbCCCD.Text + "')";
            SqlCommand com = new SqlCommand(sql, connection);

            GetData(com);

            connection.Open();

            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                dateTimePicker1.Text = dr[5].ToString();
            }
            connection.Close();

            query = "select TINHTIEN from HOADON where MAKH = (select MAKH from KHACHHANG where CCCD_CMND = '" + txbCCCD.Text + "')";

            SqlCommand com1 = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader DR1 = com1.ExecuteReader();
            if (DR1.Read())
            {
                paidMoney = Convert.ToDecimal(DR1.GetValue(0));
            }
            txbCHIPHIDATRA.Text = paidMoney.ToString("###,###");

            connection.Close();
        }
        
        public void GetData(SqlCommand com)
        {
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            dataGridView1.DataSource = dt;
        }

        private void bntHUY_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString()))
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {

                        command.CommandText = "insert into DOANHTHU(DOANHTHU,THANG,NAM) values ('" + txbPHUPHI.Text + "', '" + dateTimePicker2.Value.Month.ToString() + "', '" + dateTimePicker2.Value.Year.ToString() + "')";
                        command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            this.Close();
        }

        private void btnTRAPHONG_Click(object sender, EventArgs e)
        {
            btnHUY.Enabled = false;
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString()))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {

                    command.CommandText = "update PHONG set TRANGTHAI = N'TRỐNG' where TENPHONG in (select TENPHONG from DATPHONG where MAKH = (select MAKH from KHACHHANG where CCCD_CMND = '" + txbCCCD.Text + "'))";
                    command.ExecuteNonQuery();

                    command.CommandText = "delete from DATPHONG where MAKH = (select MAKH from KHACHHANG where CCCD_CMND = '" + txbCCCD.Text + "')";
                    command.ExecuteNonQuery();

                }
            }

            TimeSpan timeSpan = dateTimePicker2.Value - dateTimePicker1.Value;
            int diffDays = timeSpan.Days;
            lateDay = Convert.ToDecimal(diffDays);
            lateHour = Int32.Parse(Check_Out2.Text) - Int32.Parse(Check_Out1.Text);
            if (lateHour < 0)
            {
                lateHour = 0;
            }

            sum = 0;

            if (lateDay == 0)
            {
                if (int.Parse(Check_Out2.Text) > 12 && int.Parse(Check_Out2.Text) <= 15)
                {
                    sum = paidMoney * (decimal)0.3;
                }
                else if (int.Parse(Check_Out2.Text) > 15 && int.Parse(Check_Out2.Text) <= 18)
                {
                    sum = paidMoney * (decimal)0.5;

                }
                else if (int.Parse(Check_Out2.Text) > 18)
                {
                    sum = paidMoney;
                }
            }
            else if (lateHour == 0)
            {               
                sum = (paidMoney * lateDay);
            }
            else
            {
                if (int.Parse(Check_Out2.Text) > 12 && int.Parse(Check_Out2.Text) <= 15)
                {
                    sum = (paidMoney * lateDay) * (decimal)0.3;
                }
                else if (int.Parse(Check_Out2.Text) > 15 && int.Parse(Check_Out2.Text) <= 18)
                {
                    sum = (paidMoney * lateDay) * (decimal)0.5;

                }
                else if (int.Parse(Check_Out2.Text) > 18)
                {
                    sum = (paidMoney * lateDay);
                }
            }
            txbPHUPHI.Text = sum.ToString("###,###");

            MessageBox.Show("Thời gian Check Out đã trễ:  " + lateDay.ToString() + " NGÀY,  " + lateHour.ToString() + " GIỜ.\nTiền trễ Check Out là: " + txbPHUPHI.Text + " VND", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            TraPhong_Load(this, e);

        }
    }
}
