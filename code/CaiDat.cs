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
    public partial class CaiDat : Form
    {
        public CaiDat()
        {
            InitializeComponent();
        }


        private void CaiDat_TTKS_Btn_Click(object sender, EventArgs e)
        {
            TTKS ttks = new TTKS();
            ttks.ShowDialog();
        }

        private void CaiDat_ThanhToan_Btn_Click(object sender, EventArgs e)
        {
            ThanhToan tt = new ThanhToan();
            tt.ShowDialog();
        }

        private void CaiDat_HuyPhong_Btn_Click(object sender, EventArgs e)
        {

        }

        private void CaiDat_Mang_Btn_Click(object sender, EventArgs e)
        {
            ThietLapMang tlm = new ThietLapMang();
            tlm.ShowDialog();
        }
    }
}
