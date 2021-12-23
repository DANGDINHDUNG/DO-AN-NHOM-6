namespace form
{
    partial class Dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dangnhap));
            this.logoPnl = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DangnhapPnl = new System.Windows.Forms.Panel();
            this.userBox = new System.Windows.Forms.TextBox();
            this.Title_Lb = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pass = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.logoPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.DangnhapPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoPnl
            // 
            this.logoPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.logoPnl.Controls.Add(this.label9);
            this.logoPnl.Controls.Add(this.label13);
            this.logoPnl.Controls.Add(this.pictureBox1);
            this.logoPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoPnl.Location = new System.Drawing.Point(0, 0);
            this.logoPnl.Name = "logoPnl";
            this.logoPnl.Size = new System.Drawing.Size(282, 506);
            this.logoPnl.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // DangnhapPnl
            // 
            this.DangnhapPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.DangnhapPnl.Controls.Add(this.userBox);
            this.DangnhapPnl.Controls.Add(this.Title_Lb);
            this.DangnhapPnl.Controls.Add(this.passBox);
            this.DangnhapPnl.Controls.Add(this.cancelBtn);
            this.DangnhapPnl.Controls.Add(this.checkBox1);
            this.DangnhapPnl.Controls.Add(this.label1);
            this.DangnhapPnl.Controls.Add(this.user);
            this.DangnhapPnl.Controls.Add(this.loginBtn);
            this.DangnhapPnl.Controls.Add(this.linkLabel1);
            this.DangnhapPnl.Controls.Add(this.pass);
            this.DangnhapPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DangnhapPnl.Location = new System.Drawing.Point(282, 0);
            this.DangnhapPnl.Name = "DangnhapPnl";
            this.DangnhapPnl.Size = new System.Drawing.Size(762, 506);
            this.DangnhapPnl.TabIndex = 8;
            // 
            // userBox
            // 
            this.userBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBox.Location = new System.Drawing.Point(267, 174);
            this.userBox.Margin = new System.Windows.Forms.Padding(4);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(283, 34);
            this.userBox.TabIndex = 7;
            // 
            // Title_Lb
            // 
            this.Title_Lb.BackColor = System.Drawing.Color.Transparent;
            this.Title_Lb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Title_Lb.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Lb.ForeColor = System.Drawing.Color.Aqua;
            this.Title_Lb.Location = new System.Drawing.Point(238, 25);
            this.Title_Lb.Name = "Title_Lb";
            this.Title_Lb.Size = new System.Drawing.Size(321, 99);
            this.Title_Lb.TabIndex = 16;
            this.Title_Lb.Text = "ĐĂNG NHẬP";
            this.Title_Lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBox.Location = new System.Drawing.Point(267, 230);
            this.passBox.Margin = new System.Windows.Forms.Padding(4);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(283, 34);
            this.passBox.TabIndex = 8;
            this.passBox.UseSystemPasswordChar = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.Aqua;
            this.cancelBtn.Location = new System.Drawing.Point(711, 0);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(50, 50);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "x";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Aqua;
            this.checkBox1.Location = new System.Drawing.Point(580, 236);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(169, 30);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Hiện mật khẩu";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(105, 442);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quên mật khẩu? Lấy lại mật khẩu";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.BackColor = System.Drawing.Color.Transparent;
            this.user.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.Aqua;
            this.user.Location = new System.Drawing.Point(53, 174);
            this.user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(151, 26);
            this.user.TabIndex = 10;
            this.user.Text = "Tên đăng nhập";
            // 
            // loginBtn
            // 
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.Aqua;
            this.loginBtn.Location = new System.Drawing.Point(294, 330);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(181, 54);
            this.loginBtn.TabIndex = 12;
            this.loginBtn.Text = "Đăng nhập";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.HotPink;
            this.linkLabel1.Location = new System.Drawing.Point(455, 442);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(84, 26);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Tại đây";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.BackColor = System.Drawing.Color.Transparent;
            this.pass.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.Aqua;
            this.pass.Location = new System.Drawing.Point(105, 236);
            this.pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(99, 26);
            this.pass.TabIndex = 11;
            this.pass.Text = "Mật khẩu";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Aqua;
            this.label9.Location = new System.Drawing.Point(12, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(258, 116);
            this.label9.TabIndex = 10;
            this.label9.Text = "HOTEL";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font(".VnArabiaH", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Aqua;
            this.label13.Location = new System.Drawing.Point(16, 237);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(258, 186);
            this.label13.TabIndex = 9;
            this.label13.Text = "Aroma \r\nGarden\r\n";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dangnhap
            // 
            this.AcceptButton = this.loginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1044, 506);
            this.Controls.Add(this.DangnhapPnl);
            this.Controls.Add(this.logoPnl);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.logoPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.DangnhapPnl.ResumeLayout(false);
            this.DangnhapPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel logoPnl;
        private System.Windows.Forms.Panel DangnhapPnl;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.Label Title_Lb;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
    }
}