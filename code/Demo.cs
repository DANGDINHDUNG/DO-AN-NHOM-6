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
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
            custom();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            hideMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new InDSNV());
            hideMenu();
        }
        private void custom()
        {
            panelQLKSmenu.Visible = false;
            panelDTmenu.Visible = false;
        }

        private void hideMenu()
        {
            if (panelQLKSmenu.Visible == true)
                panelQLKSmenu.Visible = false;
            if (panelDTmenu.Visible == true)
                panelDTmenu.Visible = false;
        }

        private void showMenu(Panel menu)
        {
            if (menu.Visible == false)
            {
                hideMenu();
                menu.Visible = true;
            }
            else
                menu.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showMenu(panelQLKSmenu);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showMenu(panelDTmenu);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Form DoanhThu 
            //openChildForm(new DoanhThu());  
            hideMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
