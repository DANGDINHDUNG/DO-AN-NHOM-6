
namespace form
{
    partial class ChucNang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChucNang));
            this.DatPhong_Pnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NhanPhong_Pnl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TraPhong_Pnl = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.DatPhong_Pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.NhanPhong_Pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.TraPhong_Pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // DatPhong_Pnl
            // 
            this.DatPhong_Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DatPhong_Pnl.Controls.Add(this.label1);
            this.DatPhong_Pnl.Controls.Add(this.pictureBox1);
            this.DatPhong_Pnl.Location = new System.Drawing.Point(23, 13);
            this.DatPhong_Pnl.Name = "DatPhong_Pnl";
            this.DatPhong_Pnl.Size = new System.Drawing.Size(108, 105);
            this.DatPhong_Pnl.TabIndex = 0;
            this.DatPhong_Pnl.Click += new System.EventHandler(this.DatPhong_Pnl_Click);
            this.DatPhong_Pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.DatPhong_Pnl_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đặt Phòng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NhanPhong_Pnl
            // 
            this.NhanPhong_Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NhanPhong_Pnl.Controls.Add(this.label2);
            this.NhanPhong_Pnl.Controls.Add(this.pictureBox2);
            this.NhanPhong_Pnl.Location = new System.Drawing.Point(137, 13);
            this.NhanPhong_Pnl.Name = "NhanPhong_Pnl";
            this.NhanPhong_Pnl.Size = new System.Drawing.Size(108, 105);
            this.NhanPhong_Pnl.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhận Phòng";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // TraPhong_Pnl
            // 
            this.TraPhong_Pnl.BackColor = System.Drawing.SystemColors.Control;
            this.TraPhong_Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TraPhong_Pnl.Controls.Add(this.label3);
            this.TraPhong_Pnl.Controls.Add(this.pictureBox3);
            this.TraPhong_Pnl.Location = new System.Drawing.Point(251, 13);
            this.TraPhong_Pnl.Name = "TraPhong_Pnl";
            this.TraPhong_Pnl.Size = new System.Drawing.Size(108, 105);
            this.TraPhong_Pnl.TabIndex = 3;
            this.TraPhong_Pnl.Click += new System.EventHandler(this.TraPhong_Pnl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Trả Phòng";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(14, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // ChucNang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TraPhong_Pnl);
            this.Controls.Add(this.NhanPhong_Pnl);
            this.Controls.Add(this.DatPhong_Pnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChucNang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chức Năng";
            this.DatPhong_Pnl.ResumeLayout(false);
            this.DatPhong_Pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.NhanPhong_Pnl.ResumeLayout(false);
            this.NhanPhong_Pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.TraPhong_Pnl.ResumeLayout(false);
            this.TraPhong_Pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DatPhong_Pnl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel NhanPhong_Pnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel TraPhong_Pnl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}