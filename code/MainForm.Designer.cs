namespace form
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.HeThong_TabPage = new System.Windows.Forms.TabPage();
            this.DangXuat_Pnl = new System.Windows.Forms.Panel();
            this.DangXuat_Lb = new System.Windows.Forms.Label();
            this.DangXuat_Pbx = new System.Windows.Forms.PictureBox();
            this.DoiMK_Pnl = new System.Windows.Forms.Panel();
            this.DoiMK_Lb = new System.Windows.Forms.Label();
            this.DoiMK_Pbx = new System.Windows.Forms.PictureBox();
            this.GiaoDien_Pnl = new System.Windows.Forms.Panel();
            this.GiaoDien_Lb = new System.Windows.Forms.Label();
            this.GiaoDien_Pbx = new System.Windows.Forms.PictureBox();
            this.ChucNang_TabPage = new System.Windows.Forms.TabPage();
            this.TheoDoi_TabPage = new System.Windows.Forms.TabPage();
            this.QuanLy_TabPage = new System.Windows.Forms.TabPage();
            this.CaiDat_TabPage = new System.Windows.Forms.TabPage();
            this.InHoaDon_TabPage = new System.Windows.Forms.TabPage();
            this.TroGIup_TabPage = new System.Windows.Forms.TabPage();
            this.DangNhap_Pnl = new System.Windows.Forms.Panel();
            this.DangNhap_Lb = new System.Windows.Forms.Label();
            this.DangNhap_Pbx = new System.Windows.Forms.PictureBox();
            this.DangKy_Pnl = new System.Windows.Forms.Panel();
            this.DangKy_Lb = new System.Windows.Forms.Label();
            this.DangKy_Pbx = new System.Windows.Forms.PictureBox();
            this.MainTabControl.SuspendLayout();
            this.HeThong_TabPage.SuspendLayout();
            this.DangXuat_Pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DangXuat_Pbx)).BeginInit();
            this.DoiMK_Pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoiMK_Pbx)).BeginInit();
            this.GiaoDien_Pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GiaoDien_Pbx)).BeginInit();
            this.DangNhap_Pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DangNhap_Pbx)).BeginInit();
            this.DangKy_Pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DangKy_Pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.HeThong_TabPage);
            this.MainTabControl.Controls.Add(this.ChucNang_TabPage);
            this.MainTabControl.Controls.Add(this.TheoDoi_TabPage);
            this.MainTabControl.Controls.Add(this.QuanLy_TabPage);
            this.MainTabControl.Controls.Add(this.CaiDat_TabPage);
            this.MainTabControl.Controls.Add(this.InHoaDon_TabPage);
            this.MainTabControl.Controls.Add(this.TroGIup_TabPage);
            this.MainTabControl.Enabled = false;
            this.MainTabControl.Location = new System.Drawing.Point(-1, -2);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(810, 496);
            this.MainTabControl.TabIndex = 0;
            this.MainTabControl.Visible = false;
            // 
            // HeThong_TabPage
            // 
            this.HeThong_TabPage.Controls.Add(this.DangXuat_Pnl);
            this.HeThong_TabPage.Controls.Add(this.DoiMK_Pnl);
            this.HeThong_TabPage.Controls.Add(this.GiaoDien_Pnl);
            this.HeThong_TabPage.Location = new System.Drawing.Point(4, 25);
            this.HeThong_TabPage.Name = "HeThong_TabPage";
            this.HeThong_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.HeThong_TabPage.Size = new System.Drawing.Size(802, 467);
            this.HeThong_TabPage.TabIndex = 0;
            this.HeThong_TabPage.Text = "Hệ Thống";
            this.HeThong_TabPage.UseVisualStyleBackColor = true;
            // 
            // DangXuat_Pnl
            // 
            this.DangXuat_Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DangXuat_Pnl.Controls.Add(this.DangXuat_Lb);
            this.DangXuat_Pnl.Controls.Add(this.DangXuat_Pbx);
            this.DangXuat_Pnl.Location = new System.Drawing.Point(295, 7);
            this.DangXuat_Pnl.Name = "DangXuat_Pnl";
            this.DangXuat_Pnl.Size = new System.Drawing.Size(111, 114);
            this.DangXuat_Pnl.TabIndex = 10;
            this.DangXuat_Pnl.Click += new System.EventHandler(this.DangXuat_Pnl_Click);
            // 
            // DangXuat_Lb
            // 
            this.DangXuat_Lb.AutoSize = true;
            this.DangXuat_Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangXuat_Lb.Location = new System.Drawing.Point(14, 83);
            this.DangXuat_Lb.Name = "DangXuat_Lb";
            this.DangXuat_Lb.Size = new System.Drawing.Size(75, 17);
            this.DangXuat_Lb.TabIndex = 1;
            this.DangXuat_Lb.Text = "Đăng Xuất";
            this.DangXuat_Lb.Click += new System.EventHandler(this.DangXuat_Pnl_Click);
            // 
            // DangXuat_Pbx
            // 
            this.DangXuat_Pbx.Image = ((System.Drawing.Image)(resources.GetObject("DangXuat_Pbx.Image")));
            this.DangXuat_Pbx.Location = new System.Drawing.Point(17, -1);
            this.DangXuat_Pbx.Name = "DangXuat_Pbx";
            this.DangXuat_Pbx.Size = new System.Drawing.Size(67, 75);
            this.DangXuat_Pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DangXuat_Pbx.TabIndex = 0;
            this.DangXuat_Pbx.TabStop = false;
            this.DangXuat_Pbx.Click += new System.EventHandler(this.DangXuat_Pnl_Click);
            // 
            // DoiMK_Pnl
            // 
            this.DoiMK_Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DoiMK_Pnl.Controls.Add(this.DoiMK_Lb);
            this.DoiMK_Pnl.Controls.Add(this.DoiMK_Pbx);
            this.DoiMK_Pnl.Location = new System.Drawing.Point(178, 7);
            this.DoiMK_Pnl.Name = "DoiMK_Pnl";
            this.DoiMK_Pnl.Size = new System.Drawing.Size(111, 114);
            this.DoiMK_Pnl.TabIndex = 9;
            this.DoiMK_Pnl.Click += new System.EventHandler(this.DoiMK_Pnl_Click);
            // 
            // DoiMK_Lb
            // 
            this.DoiMK_Lb.AutoSize = true;
            this.DoiMK_Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoiMK_Lb.Location = new System.Drawing.Point(3, 83);
            this.DoiMK_Lb.Name = "DoiMK_Lb";
            this.DoiMK_Lb.Size = new System.Drawing.Size(93, 17);
            this.DoiMK_Lb.TabIndex = 1;
            this.DoiMK_Lb.Text = "Đổi Mật Khẩu";
            this.DoiMK_Lb.Click += new System.EventHandler(this.DoiMK_Pnl_Click);
            // 
            // DoiMK_Pbx
            // 
            this.DoiMK_Pbx.Image = ((System.Drawing.Image)(resources.GetObject("DoiMK_Pbx.Image")));
            this.DoiMK_Pbx.Location = new System.Drawing.Point(17, -1);
            this.DoiMK_Pbx.Name = "DoiMK_Pbx";
            this.DoiMK_Pbx.Size = new System.Drawing.Size(67, 75);
            this.DoiMK_Pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DoiMK_Pbx.TabIndex = 0;
            this.DoiMK_Pbx.TabStop = false;
            this.DoiMK_Pbx.Click += new System.EventHandler(this.DoiMK_Pnl_Click);
            // 
            // GiaoDien_Pnl
            // 
            this.GiaoDien_Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GiaoDien_Pnl.Controls.Add(this.GiaoDien_Lb);
            this.GiaoDien_Pnl.Controls.Add(this.GiaoDien_Pbx);
            this.GiaoDien_Pnl.Location = new System.Drawing.Point(6, 6);
            this.GiaoDien_Pnl.Name = "GiaoDien_Pnl";
            this.GiaoDien_Pnl.Size = new System.Drawing.Size(166, 114);
            this.GiaoDien_Pnl.TabIndex = 8;
            this.GiaoDien_Pnl.Click += new System.EventHandler(this.GiaoDien_Pnl_Click);
            // 
            // GiaoDien_Lb
            // 
            this.GiaoDien_Lb.AutoSize = true;
            this.GiaoDien_Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaoDien_Lb.Location = new System.Drawing.Point(14, 84);
            this.GiaoDien_Lb.Name = "GiaoDien_Lb";
            this.GiaoDien_Lb.Size = new System.Drawing.Size(136, 17);
            this.GiaoDien_Lb.TabIndex = 1;
            this.GiaoDien_Lb.Text = "Tùy Chọn Giao Diện";
            this.GiaoDien_Lb.Click += new System.EventHandler(this.GiaoDien_Pnl_Click);
            // 
            // GiaoDien_Pbx
            // 
            this.GiaoDien_Pbx.Image = ((System.Drawing.Image)(resources.GetObject("GiaoDien_Pbx.Image")));
            this.GiaoDien_Pbx.Location = new System.Drawing.Point(42, 0);
            this.GiaoDien_Pbx.Name = "GiaoDien_Pbx";
            this.GiaoDien_Pbx.Size = new System.Drawing.Size(67, 75);
            this.GiaoDien_Pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GiaoDien_Pbx.TabIndex = 0;
            this.GiaoDien_Pbx.TabStop = false;
            this.GiaoDien_Pbx.Click += new System.EventHandler(this.GiaoDien_Pnl_Click);
            // 
            // ChucNang_TabPage
            // 
            this.ChucNang_TabPage.Location = new System.Drawing.Point(4, 25);
            this.ChucNang_TabPage.Name = "ChucNang_TabPage";
            this.ChucNang_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ChucNang_TabPage.Size = new System.Drawing.Size(802, 467);
            this.ChucNang_TabPage.TabIndex = 1;
            this.ChucNang_TabPage.Text = "Chức Năng";
            this.ChucNang_TabPage.UseVisualStyleBackColor = true;
            // 
            // TheoDoi_TabPage
            // 
            this.TheoDoi_TabPage.Location = new System.Drawing.Point(4, 25);
            this.TheoDoi_TabPage.Name = "TheoDoi_TabPage";
            this.TheoDoi_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TheoDoi_TabPage.Size = new System.Drawing.Size(802, 467);
            this.TheoDoi_TabPage.TabIndex = 2;
            this.TheoDoi_TabPage.Text = "Dịch Vụ";
            this.TheoDoi_TabPage.UseVisualStyleBackColor = true;
            // 
            // QuanLy_TabPage
            // 
            this.QuanLy_TabPage.Location = new System.Drawing.Point(4, 25);
            this.QuanLy_TabPage.Name = "QuanLy_TabPage";
            this.QuanLy_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.QuanLy_TabPage.Size = new System.Drawing.Size(802, 467);
            this.QuanLy_TabPage.TabIndex = 3;
            this.QuanLy_TabPage.Text = "Quàn Lý";
            this.QuanLy_TabPage.UseVisualStyleBackColor = true;
            // 
            // CaiDat_TabPage
            // 
            this.CaiDat_TabPage.Location = new System.Drawing.Point(4, 25);
            this.CaiDat_TabPage.Name = "CaiDat_TabPage";
            this.CaiDat_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CaiDat_TabPage.Size = new System.Drawing.Size(802, 467);
            this.CaiDat_TabPage.TabIndex = 4;
            this.CaiDat_TabPage.Text = "Cài Đặt";
            this.CaiDat_TabPage.UseVisualStyleBackColor = true;
            // 
            // InHoaDon_TabPage
            // 
            this.InHoaDon_TabPage.Location = new System.Drawing.Point(4, 25);
            this.InHoaDon_TabPage.Name = "InHoaDon_TabPage";
            this.InHoaDon_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.InHoaDon_TabPage.Size = new System.Drawing.Size(802, 467);
            this.InHoaDon_TabPage.TabIndex = 5;
            this.InHoaDon_TabPage.Text = "In Hóa Đơn";
            this.InHoaDon_TabPage.UseVisualStyleBackColor = true;
            // 
            // TroGIup_TabPage
            // 
            this.TroGIup_TabPage.Location = new System.Drawing.Point(4, 25);
            this.TroGIup_TabPage.Name = "TroGIup_TabPage";
            this.TroGIup_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TroGIup_TabPage.Size = new System.Drawing.Size(802, 467);
            this.TroGIup_TabPage.TabIndex = 6;
            this.TroGIup_TabPage.Text = "Trợ Giúp";
            this.TroGIup_TabPage.UseVisualStyleBackColor = true;
            // 
            // DangNhap_Pnl
            // 
            this.DangNhap_Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DangNhap_Pnl.Controls.Add(this.DangNhap_Lb);
            this.DangNhap_Pnl.Controls.Add(this.DangNhap_Pbx);
            this.DangNhap_Pnl.Location = new System.Drawing.Point(12, 12);
            this.DangNhap_Pnl.Name = "DangNhap_Pnl";
            this.DangNhap_Pnl.Size = new System.Drawing.Size(111, 114);
            this.DangNhap_Pnl.TabIndex = 10;
            this.DangNhap_Pnl.Click += new System.EventHandler(this.DangNhap_Pnl_Click);
            this.DangNhap_Pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.DangNhap_Pnl_Paint);
            // 
            // DangNhap_Lb
            // 
            this.DangNhap_Lb.AutoSize = true;
            this.DangNhap_Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangNhap_Lb.Location = new System.Drawing.Point(14, 83);
            this.DangNhap_Lb.Name = "DangNhap_Lb";
            this.DangNhap_Lb.Size = new System.Drawing.Size(80, 17);
            this.DangNhap_Lb.TabIndex = 1;
            this.DangNhap_Lb.Text = "Đăng Nhập";
            this.DangNhap_Lb.Click += new System.EventHandler(this.DangNhap_Pnl_Click);
            // 
            // DangNhap_Pbx
            // 
            this.DangNhap_Pbx.Image = ((System.Drawing.Image)(resources.GetObject("DangNhap_Pbx.Image")));
            this.DangNhap_Pbx.Location = new System.Drawing.Point(17, -1);
            this.DangNhap_Pbx.Name = "DangNhap_Pbx";
            this.DangNhap_Pbx.Size = new System.Drawing.Size(67, 75);
            this.DangNhap_Pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DangNhap_Pbx.TabIndex = 0;
            this.DangNhap_Pbx.TabStop = false;
            this.DangNhap_Pbx.Click += new System.EventHandler(this.DangNhap_Pnl_Click);
            // 
            // DangKy_Pnl
            // 
            this.DangKy_Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DangKy_Pnl.Controls.Add(this.DangKy_Lb);
            this.DangKy_Pnl.Controls.Add(this.DangKy_Pbx);
            this.DangKy_Pnl.Location = new System.Drawing.Point(129, 12);
            this.DangKy_Pnl.Name = "DangKy_Pnl";
            this.DangKy_Pnl.Size = new System.Drawing.Size(111, 114);
            this.DangKy_Pnl.TabIndex = 11;
            this.DangKy_Pnl.Click += new System.EventHandler(this.DangKy_Pbx_Click);
            // 
            // DangKy_Lb
            // 
            this.DangKy_Lb.AutoSize = true;
            this.DangKy_Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangKy_Lb.Location = new System.Drawing.Point(22, 83);
            this.DangKy_Lb.Name = "DangKy_Lb";
            this.DangKy_Lb.Size = new System.Drawing.Size(62, 17);
            this.DangKy_Lb.TabIndex = 1;
            this.DangKy_Lb.Text = "Đăng Ký";
            this.DangKy_Lb.Click += new System.EventHandler(this.DangKy_Pbx_Click);
            // 
            // DangKy_Pbx
            // 
            this.DangKy_Pbx.Image = ((System.Drawing.Image)(resources.GetObject("DangKy_Pbx.Image")));
            this.DangKy_Pbx.Location = new System.Drawing.Point(17, 5);
            this.DangKy_Pbx.Name = "DangKy_Pbx";
            this.DangKy_Pbx.Size = new System.Drawing.Size(67, 75);
            this.DangKy_Pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DangKy_Pbx.TabIndex = 0;
            this.DangKy_Pbx.TabStop = false;
            this.DangKy_Pbx.Click += new System.EventHandler(this.DangKy_Pbx_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 506);
            this.Controls.Add(this.DangNhap_Pnl);
            this.Controls.Add(this.DangKy_Pnl);
            this.Controls.Add(this.MainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách Sạn";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainTabControl.ResumeLayout(false);
            this.HeThong_TabPage.ResumeLayout(false);
            this.DangXuat_Pnl.ResumeLayout(false);
            this.DangXuat_Pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DangXuat_Pbx)).EndInit();
            this.DoiMK_Pnl.ResumeLayout(false);
            this.DoiMK_Pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoiMK_Pbx)).EndInit();
            this.GiaoDien_Pnl.ResumeLayout(false);
            this.GiaoDien_Pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GiaoDien_Pbx)).EndInit();
            this.DangNhap_Pnl.ResumeLayout(false);
            this.DangNhap_Pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DangNhap_Pbx)).EndInit();
            this.DangKy_Pnl.ResumeLayout(false);
            this.DangKy_Pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DangKy_Pbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage HeThong_TabPage;
        private System.Windows.Forms.TabPage ChucNang_TabPage;
        private System.Windows.Forms.Panel DangXuat_Pnl;
        private System.Windows.Forms.Label DangXuat_Lb;
        private System.Windows.Forms.PictureBox DangXuat_Pbx;
        private System.Windows.Forms.Panel DoiMK_Pnl;
        private System.Windows.Forms.Label DoiMK_Lb;
        private System.Windows.Forms.PictureBox DoiMK_Pbx;
        private System.Windows.Forms.Panel GiaoDien_Pnl;
        private System.Windows.Forms.Label GiaoDien_Lb;
        private System.Windows.Forms.PictureBox GiaoDien_Pbx;
        private System.Windows.Forms.TabPage TheoDoi_TabPage;
        private System.Windows.Forms.TabPage QuanLy_TabPage;
        private System.Windows.Forms.TabPage CaiDat_TabPage;
        private System.Windows.Forms.TabPage InHoaDon_TabPage;
        private System.Windows.Forms.TabPage TroGIup_TabPage;
        private System.Windows.Forms.Panel DangNhap_Pnl;
        private System.Windows.Forms.Label DangNhap_Lb;
        private System.Windows.Forms.PictureBox DangNhap_Pbx;
        private System.Windows.Forms.Panel DangKy_Pnl;
        private System.Windows.Forms.Label DangKy_Lb;
        private System.Windows.Forms.PictureBox DangKy_Pbx;
    }
}