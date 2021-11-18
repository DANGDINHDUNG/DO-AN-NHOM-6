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

namespace DOAN
{
    public partial class InDSNV : Form
    {
        bool gt = true;
        public InDSNV()
        {
            InitializeComponent();
            cbx();
        }


        private void InDSNV_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-K8QQEUE;Initial Catalog=QL;Integrated Security=True");
            connection.Open();
            string sql = @"SELECT * FROM NHANVIEN WHERE MANV!='ADM'";
            SqlCommand com = new SqlCommand(sql, connection);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            dataGridView1.DataSource = dt;
        }

        private void NEW()
        {
            manvBx = hotenBx = sdtBx = cmndBx  = luongBx = sodonBx = tentkBx = mkBx = null;
            comboBox1.Text = "";
            dateTimePicker1 = new DateTimePicker();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void cbx()
        {
            for(int i=18;i<=100;i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (row.Cells[0].Value != null)
            {
                manvBx.Text = row.Cells[0].Value.ToString();
            }
            if (row.Cells[1].Value != null)
            {
                tentkBx.Text = row.Cells[1].Value.ToString();
            }
            if (row.Cells[2].Value != null)
            {
                mkBx.Text = row.Cells[2].Value.ToString();
            }
            if (row.Cells[3].Value != null)
            {
                hotenBx.Text = row.Cells[3].Value.ToString();
            }
            if (row.Cells[4].Value != null)
            {
                comboBox1.Text = row.Cells[4].Value.ToString();

            }
            if (row.Cells[5].Value != null)
            {

            }
            if (row.Cells[6].Value != null)
            {
                sdtBx.Text = row.Cells[6].Value.ToString();
            }
            if (row.Cells[7].Value != null)
            {
                cmndBx.Text = row.Cells[7].Value.ToString();
            }
            if (row.Cells[8].Value != null)
            {
                sodonBx.Text = row.Cells[8].Value.ToString();
            }
            if (row.Cells[9].Value != null)
            {
                luongBx.Text = row.Cells[9].Value.ToString();
            }

        }

        private void delRow(string manv)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-K8QQEUE;Initial Catalog=QL;Integrated Security=True");
            connection.Open();
            string query = @"delete FROM nhanvien where manv='" +manv+ "'";
            SqlCommand command = new SqlCommand(query, connection);
            int c = command.ExecuteNonQuery();
        }

        private void updateRow(string manv)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn muốn xóa tài khoản này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dl == DialogResult.Yes)
            {
                delRow(manvBx.Text);
            }
            InDSNV_Load(this, e);
            NEW();
        }
    }
}
