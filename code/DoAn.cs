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
    public partial class DoAn : Form
    {
        public string sql;
        public string sql1;
        public string sql2;
        public string query;

        public decimal quantity;
        public decimal moneyProduct;
        public decimal totalMoney;

        public bool existsProduct = false;
        public DoAn()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());

        //SỰ KIỆN FORM

        private void DichVu_Load(object sender, EventArgs e)
        {
            sql = "select TENTP, SOLUONG, MAKH, MALTP, FORMAT(TONGTIEN, '###,###,###') as GIATIEN from DATTP";
            GetData(sql);

            connection.Open();

            sql2 = "select TENPHONG from PHONG inner join LOAIPHONG on PHONG.MALP = LOAIPHONG.MALP order by GIA desc";
            TenPhongData(sql2);

        }

        private void Checked_Food(object sender, EventArgs e)
        {
            connection.Open();

            if (rbtnFood.Checked)
            {
                sql1 = "select TENTP from THUCPHAM where MALTP = 'FOD'";
                ComboBoxData(sql1);

            }
            else
            {
                sql1 = "select TENTP from THUCPHAM where MALTP = 'DRK'";
                ComboBoxData(sql1);

            }
        }

        private void txbQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GetMoney();
            }
            catch
            {
            }
        }

        private void cbxProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                GetMoney();
            }
            catch
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbHOTEN.Text == string.Empty || txbTENPHONG.Text == string.Empty || cbxProduct.Text == string.Empty || txbQuantity.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                CheckExists();

                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString()))
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {

                        if (existsProduct)
                        {
                            command.CommandText = "update DATTP set SOLUONG = '" + txbQuantity.Text + "', TONGTIEN = '" + lblMoney.Text + "' where TENTP = N'" + cbxProduct.Text + "'";
                            command.ExecuteNonQuery();
                        }
                        else
                        {                           
                            command.CommandText = "insert into DATTP(MAKH, MATP, TENTP, SOLUONG, MALTP, TONGTIEN) values ((select MAKH from DATPHONG where TENPHONG = N'" + txbTENPHONG.Text + "'), (select MATP from THUCPHAM where TENTP = N'" + cbxProduct.Text + "'), N'" + cbxProduct.Text + "', '" + txbQuantity.Text + "', (select MALTP from THUCPHAM where TENTP = N'" + cbxProduct.Text + "'), '" + lblMoney.Text + "')";
                            command.ExecuteNonQuery();
                        }

                    }
                }

                DichVu_Load(this, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString()))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "delete from DATTP where TENTP = N'" + cbxProduct.Text + "'";
                    command.ExecuteNonQuery();
                }
            }

            DichVu_Load(this, e);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txbQuantity.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            cbxProduct.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            lblMoney.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {

            if (txbHOTEN.Text == string.Empty || txbTENPHONG.Text == string.Empty || lblMoney.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                HoaDonDoAn hoaDonDoAn = new HoaDonDoAn();
                hoaDonDoAn.name = txbHOTEN.Text;
                hoaDonDoAn.id = txbTENPHONG.Text;

                sql = "select sum(SOLUONG), sum(TONGTIEN) from DATTP where MAKH = (select MAKH from DATPHONG where TENPHONG = N'" + txbTENPHONG.Text + "')";
                SqlCommand com = new SqlCommand(sql, connection);

                connection.Open();

                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    hoaDonDoAn.amount = dr[0].ToString();
                    totalMoney = Convert.ToDecimal(dr[1].ToString());
                }
                hoaDonDoAn.totalMoney = totalMoney;

                connection.Close();
                this.Hide();

                hoaDonDoAn.ShowDialog();

            }
        }

        // THAO TÁC FORM

        private void GetMoney()
        {
            quantity = Convert.ToDecimal(txbQuantity.Text);

            query = "select GIATIEN from THUCPHAM where TENTP = N'" + cbxProduct.Text + "'";

            SqlCommand com1 = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader DR1 = com1.ExecuteReader();
            if (DR1.Read())
            {
                moneyProduct = Convert.ToDecimal(DR1.GetValue(0));
                lblMoney.Text = (moneyProduct * quantity).ToString("###,###");

            }
            connection.Close();
        }

        private void ComboBoxData(string data)
        {
            SqlCommand cmd = new SqlCommand(data, connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();

            connection.Close();

            cbxProduct.DataSource = ds.Tables[0];
            cbxProduct.DisplayMember = "TENTP";

        }

        private void TenPhongData(string data)
        {
            SqlCommand cmd = new SqlCommand(data, connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();

            connection.Close();

            txbTENPHONG.DataSource = ds.Tables[0];
            txbTENPHONG.DisplayMember = "TENPHONG";

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

        private void CheckExists()
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == cbxProduct.Text)
                {
                    existsProduct = true;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
