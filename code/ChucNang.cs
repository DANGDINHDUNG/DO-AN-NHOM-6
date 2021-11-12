using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class ChucNang : Form
    {
        public ChucNang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DatPhong_Pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DatPhong_Pnl_Click(object sender, EventArgs e)
        {
            DatPhong dp = new DatPhong();
            dp.ShowDialog();
        }

        private void TraPhong_Pnl_Click(object sender, EventArgs e)
        {
            TraPhong tp = new TraPhong();
            tp.ShowDialog();
        }
    }
}
