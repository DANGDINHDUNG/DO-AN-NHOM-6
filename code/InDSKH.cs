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

namespace form
{
    public partial class InDSKH : Form
    {
        MainForm frm;
        public InDSKH(MainForm frm)
        {
            InitializeComponent();
            this.frm = frm;

        }
        private void InDSKH_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-K8QQEUE;Initial Catalog=QLKS;Integrated Security=True");
            connection.Open();
            string sql = "select * from KHACHHANG where TENTK!='ADMIN'";  
            SqlCommand com = new SqlCommand(sql, connection); 
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); 
            DataTable dt = new DataTable(); 
            da.Fill(dt);  
            connection.Close(); 
            dataGridView1.DataSource = dt;
        }

        private void InDSKH_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm.Show();
            this.Close();
        }
    }
}
