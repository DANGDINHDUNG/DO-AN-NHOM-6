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
    public partial class DichVu : Form
    {
        public string sql;
        public string sql1;
        public string query;

        public decimal quantity;
        public decimal moneyService;

        public decimal totalMoney;

        public bool existsService = false;
        public DichVu()
        {
            InitializeComponent();
            dataGridView1.ForeColor = Color.Black;
        }

        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());

        // SỰ KIỆN FORM

        private void DichVu_Load(object sender, EventArgs e)
        {
            query = "select DATDV.MADV, TENDV, MAKH, FORMAT(TONGTIEN, '###,###,###') as GIATIEN from DATDV inner join DICHVU on DATDV.MADV = DICHVU.MADV";
            GetData(query);

            connection.Open();
            sql = "select TENPHONG from PHONG inner join LOAIPHONG on PHONG.MALP = LOAIPHONG.MALP order by GIA desc";
            TenPhongData(sql);

            connection.Open();
            sql1 = "select TENDV from DICHVU";
            DichVuData(sql1);

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

        private void cbxDichVu_SelectedValueChanged(object sender, EventArgs e)
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
            try
            {
                if (txbHOTEN.Text == string.Empty || txbTENPHONG.Text == string.Empty || cbxDichVu.Text == string.Empty || txbQuantity.Text == string.Empty)
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

                            if (existsService)
                            {
                                command.CommandText = "update DATDV set TONGTIEN = '" + lblMoney.Text + "' where MADV = (select MADV from DICHVU where TENDV = N'" + cbxDichVu.Text + "')";
                                command.ExecuteNonQuery();
                            }
                            else
                            {
                                command.CommandText = "insert into DATDV(MADV, MAKH, TONGTIEN) values ((select MADV from DICHVU where TENDV = N'" + cbxDichVu.Text + "'), (select MAKH from DATPHONG where TENPHONG = N'" + txbTENPHONG.Text + "'), '" + lblMoney.Text + "')";
                                command.ExecuteNonQuery();
                            }

                            existsService = false;
                        }
                    }

                    DichVu_Load(this, e);
                }
            }
            catch
            {
                MessageBox.Show("Phòng chưa được đặt. Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            if (txbHOTEN.Text == string.Empty || txbTENPHONG.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                HoaDonDV hoaDonDV = new HoaDonDV();
                hoaDonDV.name = txbHOTEN.Text;
                hoaDonDV.id = txbTENPHONG.Text;

                sql = "select sum(TONGTIEN) from DATDV where MAKH = (select MAKH from DATPHONG where TENPHONG = N'" + txbTENPHONG.Text + "')";
                SqlCommand com = new SqlCommand(sql, connection);

                connection.Open();

                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    totalMoney = Convert.ToDecimal(dr[0].ToString());
                }
                hoaDonDV.money = totalMoney;

                connection.Close();

                hoaDonDV.ShowDialog();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString()))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "delete from DATDV where MADV = (select MADV from DICHVU where TENDV = N'" + cbxDichVu.Text + "')";
                    command.ExecuteNonQuery();
                }
            }

            DichVu_Load(this, e);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            cbxDichVu.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            lblMoney.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }


        //THAO TÁC FORM 

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

        private void DichVuData(string data)
        {
            SqlCommand cmd = new SqlCommand(data, connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();

            connection.Close();

            cbxDichVu.DataSource = ds.Tables[0];
            cbxDichVu.DisplayMember = "TENDV";

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

        private void GetMoney()
        {
            quantity = Convert.ToDecimal(txbQuantity.Text);

            query = "select GIA from DICHVU where TENDV = N'" + cbxDichVu.Text + "'";

            SqlCommand com1 = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader DR1 = com1.ExecuteReader();
            if (DR1.Read())
            {
                moneyService = Convert.ToDecimal(DR1.GetValue(0));
                lblMoney.Text = (moneyService * quantity).ToString("###,###");

            }
            connection.Close();
        }

        private void CheckExists()
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == cbxDichVu.Text)
                {
                    existsService = true;
                }
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
