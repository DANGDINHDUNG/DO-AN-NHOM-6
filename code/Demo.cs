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
        private Button currentBtn;
        private Panel leftBorderBtn;
        string maso; //Biến dùng để lấy mã số admin
        public Demo(string maso)
        {
            InitializeComponent();
            this.maso = maso;
            custom();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 69);
            panelMenu.Controls.Add(leftBorderBtn);
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
            panel1.Visible = false;
        }

        private void hideMenu()
        {
            if (panelQLKSmenu.Visible == true)
                panelQLKSmenu.Visible = false;
            if (panel1.Visible == true)
                panel1.Visible = false;
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
            ActivateButton(sender, RGBColors.color2);
            showMenu(panelQLKSmenu);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Mở form doanh thu 
            openChildForm(new DoanhThu());
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

        private void button4_Click_1(object sender, EventArgs e)
        {
            openChildForm(new KhachHang());
            hideMenu();
        }

        

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
           openChildForm(new InDSNV());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
             openChildForm(new QLPhong());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            openChildForm(new KhachHang());
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            openChildForm(new Doimatkhau());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            showMenu(panel1);
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            openChildForm(new HaiCachThemPhong());
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            openChildForm(new QLThucPham());
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            openChildForm(new QLDichVu());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Dangnhap dangnhap = new Dangnhap();
            this.Hide();
            dangnhap.ShowDialog();
        }
    }
}
