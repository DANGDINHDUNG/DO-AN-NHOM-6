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
    public partial class InHoaDon : Form
    {
        public InHoaDon()
        {
            InitializeComponent();
        }

        private void InHoaDon_Btn_Click(object sender, EventArgs e)
        {
            InHoaDon_Btn.Visible = false;

            HoaDon_Rtb.Text = "Sẽ viêt hóa đơn vào đây";
            HoaDon_Rtb.Visible = true;
        }
    }
}
