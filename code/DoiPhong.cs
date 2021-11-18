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
    public partial class DoiPhong : Form
    {
        private string sql;
        private string sql1;
        public string name;
        public string id;
        public DoiPhong()
        {
            this.InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            dataGridView2.DataSource = dt;
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
            dataGridView1.DataSource = dt;
        }

        private void DoiPhong_Load(object sender, EventArgs e)
        {
            txbHOTEN.Text = name;
            txbCCCD.Text = id;

            sql = "select PHONG.MALP 'Mã phòng', PHONG.TENPHONG 'Tên phòng', TRANGTHAI 'Trạng thái', FORMAT(GIA, '###,###,###') 'Giá tiền (VND)' from PHONG inner join LOAIPHONG on PHONG.MALP = LOAIPHONG.MALP where TRANGTHAI = N'Trống'";
            GetData(sql);

            sql1 = "select PHONG.MALP 'Mã phòng', PHONG.TENPHONG 'Tên phòng', TRANGTHAI 'Trạng thái', FORMAT(GIA, '###,###,###') 'Giá tiền (VND)' from PHONG inner join LOAIPHONG on PHONG.MALP = LOAIPHONG.MALP inner join DATPHONG on PHONG.MAPHONG = DATPHONG.MAPHONG where TRANGTHAI = N'ĐÃ THUÊ' and MAKH = (select MAKH from KHACHHANG where CCCD_CMND = '" + txbCCCD.Text + "')";
            GetData1(sql1);
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            txbTENPHONG.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            switch (dataGridView2.SelectedRows[0].Cells[0].Value.ToString())
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

        private void cbxMALP_SelectedValueChanged(object sender, EventArgs e)
        {
            sql = "select PHONG.MALP 'Mã loại phòng', PHONG.TENPHONG 'Tên phòng', TRANGTHAI 'Trạng thái', FORMAT(GIA, '###,###,###') 'Giá tiền (VND)' from PHONG inner join LOAIPHONG on PHONG.MALP = LOAIPHONG.MALP where TRANGTHAI = N'Trống' and PHONG.MALP = '" + cbxMALP.Text.Substring(0, 3) + "'";
            GetData(sql);

            sql1 = "select PHONG.MALP 'Mã loại phòng', PHONG.TENPHONG 'Tên phòng', TRANGTHAI 'Trạng thái', FORMAT(GIA, '###,###,###') 'Giá tiền (VND)' from PHONG inner join LOAIPHONG on PHONG.MALP = LOAIPHONG.MALP inner join DATPHONG on PHONG.MAPHONG = DATPHONG.MAPHONG where TRANGTHAI = N'ĐÃ THUÊ' and MAKH = (select MAKH from KHACHHANG where CCCD_CMND = '" + txbCCCD.Text + "') and PHONG.MALP = '" + cbxMALP.Text.Substring(0, 3) + "'";
            GetData1(sql1);
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

        private void btnDown_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.Enabled = true;
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString()))
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {

                        command.CommandText = "delete from DATPHONG where MAPHONG = (select MAPHONG from PHONG where TENPHONG = '" + txbTENPHONG.Text + "')";
                        command.ExecuteNonQuery();

                        command.CommandText = "update PHONG set TRANGTHAI = N'Trống' where PHONG.TENPHONG = N'" + txbTENPHONG.Text + "' ";
                        command.ExecuteNonQuery();


                    }
                }
                txbTENPHONG.Text = string.Empty;
                MessageBox.Show("Bạn vừa hủy một phòng đã đặt", "Đổi phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DoiPhong_Load(this, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Tên phòng muốn đổi chưa đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbTENPHONG.Text == string.Empty)
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
                DoiPhong_Load(this, e);
                MessageBox.Show("Bạn đã đổi phòng thành công", "Đổi phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Thông tin phòng chưa hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}