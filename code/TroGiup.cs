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
    public partial class TroGiup : Form
    {
        public TroGiup()
        {
            InitializeComponent();
        }

        private void About_Btn_Click(object sender, EventArgs e)
        {
            HDSD hdsd = new HDSD();
            hdsd.ShowDialog();
        }

        private void HDSD_Btn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
