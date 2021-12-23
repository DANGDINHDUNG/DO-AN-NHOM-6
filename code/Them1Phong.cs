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
    public partial class Them1Phong : Form
    {
        public string sql;

        public decimal money;
        public Them1Phong()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());

        private void Them1Phong_Load(object sender, EventArgs e)
        {

            connection.Open();
            sql = "select MALP from LOAIPHONG";
            ComboBoxData(sql);
        }
        private void cbxMALP_TextChanged(object sender, EventArgs e)
        {
            sql = "select GIA from LOAIPHONG where MALP = '" + cbxMALP.Text + "'";
            SqlCommand com = new SqlCommand(sql, connection);

            connection.Open();

            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                money = Convert.ToDecimal(dr.GetValue(0));
                txbGIATIEN.Text = money.ToString("###,###");
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

            cbxMALP.DataSource = ds.Tables[0];
            cbxMALP.DisplayMember = "MALP";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbTENPHONG.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString()))
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "INSERT INTO PHONG(TENPHONG,TRANGTHAI,MALP) VALUES (N'" + txbTENPHONG.Text + "', N'TRỐNG', '" + cbxMALP.Text + "')";
                        command.ExecuteNonQuery();

                        MessageBox.Show("Thêm phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxMALP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
