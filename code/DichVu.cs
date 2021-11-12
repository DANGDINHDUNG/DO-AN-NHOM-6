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
    public partial class DichVu : Form
    {
        public DichVu()
        {
            InitializeComponent();
        }
        private void ThucAn_Pnl_Click(object sender, EventArgs e)
        {
            Food food = new Food();
            food.ShowDialog();
        }

        private void ThucUong_Pnl_Click(object sender, EventArgs e)
        {
            Drink drink = new Drink();
            drink.ShowDialog();
        }

        private void DVPhong_Pnl_Click(object sender, EventArgs e)
        {
            DVPhong dvphong = new DVPhong();
            dvphong.ShowDialog();
        }
    }
}
