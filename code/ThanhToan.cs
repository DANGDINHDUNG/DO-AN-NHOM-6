using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class ThanhToan : Form
    {
        public ThanhToan()
        {
            InitializeComponent();
        }

        private void TTNuaNgay_Cbx_CheckedChanged(object sender, EventArgs e)
        {
            NhanPhongTu_Dtp.Enabled = !NhanPhongTu_Dtp.Enabled;
            TraPhongDen_Dtp.Enabled = !TraPhongDen_Dtp.Enabled;
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            NhanPhongTu_Dtp.Enabled = false;
            TraPhongDen_Dtp.Enabled = false;
        }

        private void Huy_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
