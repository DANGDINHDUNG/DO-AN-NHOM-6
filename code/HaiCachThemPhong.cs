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
    public partial class HaiCachThemPhong : Form
    {
        public HaiCachThemPhong()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            this.Width = childForm.Width + 733;
            this.Height = Math.Max(childForm.Height, 231);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new Them1Phong());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            openChildForm(new ThemPhong());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
