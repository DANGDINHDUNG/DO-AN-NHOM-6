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
    public partial class MainForm : Form
    {
        bool check = false;
        public bool Check
        {
            set
            {
                check = value;
            }
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CaiDat cd = new CaiDat();
            cd.TopLevel = false;
            cd.Visible = true;
            cd.FormBorderStyle = FormBorderStyle.None;
            cd.Dock = DockStyle.Fill;

            InHoaDon hd = new InHoaDon();
            hd.TopLevel = false;
            hd.Visible = true;
            hd.FormBorderStyle = FormBorderStyle.None;

            TroGiup tg = new TroGiup();
            tg.TopLevel = false;
            tg.Visible = true;
            tg.FormBorderStyle = FormBorderStyle.None;

            ChucNang cn = new ChucNang();
            cn.TopLevel = false;
            cn.Visible = true;
            cn.FormBorderStyle = FormBorderStyle.None;

            DichVu dv = new DichVu();
            dv.TopLevel = false;
            dv.Visible = true;
            dv.FormBorderStyle = FormBorderStyle.None;

            QuanLy ql = new QuanLy();
            ql.TopLevel = false;
            ql.Visible = true;
            ql.FormBorderStyle = FormBorderStyle.None;

            MainTabControl.TabPages[1].Controls.Add(cn);
            MainTabControl.TabPages[2].Controls.Add(dv);
            MainTabControl.TabPages[3].Controls.Add(ql);
            MainTabControl.TabPages[4].Controls.Add(cd);
            MainTabControl.TabPages[5].Controls.Add(hd);
            MainTabControl.TabPages[6].Controls.Add(tg);

            Dangnhap frm = new Dangnhap(this);
            this.Hide();
            frm.ShowDialog();
            if (check == false)
            {
                this.Close();
            }
        }

        private void DangXuat_Pnl_Click(object sender, EventArgs e)
        {
            DialogResult dx = MessageBox.Show("Chắc chắn đăng xuất", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dx == DialogResult.OK)
            {
                Check = false;

                MainTabControl.Visible = false;
                MainTabControl.Enabled = false;
            }
        }

        private void DoiMK_Pnl_Click(object sender, EventArgs e)
        {
            Doimatkhau frm = new Doimatkhau(this);
            this.Hide();
            frm.ShowDialog();
        }

        private void GiaoDien_Pnl_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {

                MainTabControl.TabPages[0].BackColor = colorDialog.Color;
                for (int i = 1; i < MainTabControl.TabPages.Count; i++)
                {
                    foreach (Form frm in MainTabControl.TabPages[i].Controls)
                    {
                        if (frm != null)
                        {
                            frm.BackColor = colorDialog.Color;

                        }
                    }
                }
            }
        }

        private void DangNhap_Pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}