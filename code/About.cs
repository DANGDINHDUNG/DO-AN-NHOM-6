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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            Info_Rtb.Text += "Phần mềm Quản Lý Khách Sạn version 1.0.0.0\n\n\n";
            Info_Rtb.Text += "Giáo viên hướng dẫn: Nguyễn Tấn Toàn\n";
            Info_Rtb.Text += "Danh sách thành viên nhóm 6:\n";
            Info_Rtb.Text += "20520456 – Đặng Đình Dũng (Nhóm trưởng)\n";
            Info_Rtb.Text += "20520406 – Nguyễn Gia Bảo\n";
            Info_Rtb.Text += "20520544 – Nguyễn Huỳnh Gia Huy\n";
            Info_Rtb.Text += "20520626 – Dương Hoàng Mai\n";
            Info_Rtb.Text += "20520737 – Châu Vĩnh Sinh\n";

        }
    }
}
