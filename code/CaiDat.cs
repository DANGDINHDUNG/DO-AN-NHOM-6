using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class CaiDat : Form
    {
        public CaiDat()
        {
            InitializeComponent();
        }

        private void CaiDat_TTKS_Pnl_Click(object sender, EventArgs e)
        {
            TTKS ttks = new TTKS();
            ttks.ShowDialog();
        }

        private void CaiDat_ThanhToan_Pnl_Click(object sender, EventArgs e)
        {
            ThanhToan tt = new ThanhToan();
            tt.ShowDialog();
        }

        private void CaiDat_HuyPhong_Pnl_Click(object sender, EventArgs e)
        {
            HuyPhong hp = new HuyPhong();
            hp.ShowDialog();
        }

        private void CaiDat_Mang_Pnl_Click(object sender, EventArgs e)
        {
            ThietLapMang tlm = new ThietLapMang();
            tlm.ShowDialog();
        }
    }
}
