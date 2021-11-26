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
    public partial class FormNV : Form
    {
        private Button currentBtn;
        private Panel leftBorderBtn;
        string maso; //Biến để lấy mã số nhân viên 
        public FormNV(string maso)
        {
            InitializeComponent();
            this.maso=maso;
            custom();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 69);
            panel1.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private struct RGBColors
        {
            public static Color color2 = Color.FromArgb(249, 118, 176);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(11, 7, 17);
                currentBtn.ForeColor = Color.Aqua;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void custom()
        {
            panelPhongmenu.Visible = false;
            panelDVmenu.Visible = false;
        }

        private void hideMenu()
        {
            if (panelPhongmenu.Visible == true)
                panelPhongmenu.Visible = false;
            if (panelDVmenu.Visible == true)
                panelDVmenu.Visible = false;
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
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new HuyPhong());
            hideMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            openChildForm(new DoiPhong());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            openChildForm(new DatPhong());
        }
    }
}
