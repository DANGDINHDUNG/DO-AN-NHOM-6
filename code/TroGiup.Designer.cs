
namespace form
{
    partial class TroGiup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TroGiup));
            this.HDSD_Pnl = new System.Windows.Forms.Panel();
            this.HDSD_Lb = new System.Windows.Forms.Label();
            this.HDSD_Pbx = new System.Windows.Forms.PictureBox();
            this.About_Pnl = new System.Windows.Forms.Panel();
            this.About_Lb = new System.Windows.Forms.Label();
            this.About_Pbx = new System.Windows.Forms.PictureBox();
            this.HDSD_Pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HDSD_Pbx)).BeginInit();
            this.About_Pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.About_Pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // HDSD_Pnl
            // 
            this.HDSD_Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HDSD_Pnl.Controls.Add(this.HDSD_Lb);
            this.HDSD_Pnl.Controls.Add(this.HDSD_Pbx);
            this.HDSD_Pnl.Location = new System.Drawing.Point(12, 12);
            this.HDSD_Pnl.Name = "HDSD_Pnl";
            this.HDSD_Pnl.Size = new System.Drawing.Size(143, 114);
            this.HDSD_Pnl.TabIndex = 11;
            this.HDSD_Pnl.Click += new System.EventHandler(this.HDSD_Pnl_Click);
            // 
            // HDSD_Lb
            // 
            this.HDSD_Lb.AutoSize = true;
            this.HDSD_Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDSD_Lb.Location = new System.Drawing.Point(1, 84);
            this.HDSD_Lb.Name = "HDSD_Lb";
            this.HDSD_Lb.Size = new System.Drawing.Size(139, 17);
            this.HDSD_Lb.TabIndex = 1;
            this.HDSD_Lb.Text = "Hướng Dẫn Sử Dụng";
            this.HDSD_Lb.Click += new System.EventHandler(this.HDSD_Pnl_Click);
            // 
            // HDSD_Pbx
            // 
            this.HDSD_Pbx.Image = ((System.Drawing.Image)(resources.GetObject("HDSD_Pbx.Image")));
            this.HDSD_Pbx.Location = new System.Drawing.Point(24, 0);
            this.HDSD_Pbx.Name = "HDSD_Pbx";
            this.HDSD_Pbx.Size = new System.Drawing.Size(91, 75);
            this.HDSD_Pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HDSD_Pbx.TabIndex = 0;
            this.HDSD_Pbx.TabStop = false;
            this.HDSD_Pbx.Click += new System.EventHandler(this.HDSD_Pnl_Click);
            // 
            // About_Pnl
            // 
            this.About_Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.About_Pnl.Controls.Add(this.About_Lb);
            this.About_Pnl.Controls.Add(this.About_Pbx);
            this.About_Pnl.Location = new System.Drawing.Point(161, 12);
            this.About_Pnl.Name = "About_Pnl";
            this.About_Pnl.Size = new System.Drawing.Size(163, 114);
            this.About_Pnl.TabIndex = 12;
            this.About_Pnl.Click += new System.EventHandler(this.About_Pnl_Click);
            // 
            // About_Lb
            // 
            this.About_Lb.AutoSize = true;
            this.About_Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About_Lb.Location = new System.Drawing.Point(3, 84);
            this.About_Lb.Name = "About_Lb";
            this.About_Lb.Size = new System.Drawing.Size(156, 17);
            this.About_Lb.TabIndex = 2;
            this.About_Lb.Text = "Về Quản Lý Khách Sạn";
            this.About_Lb.Click += new System.EventHandler(this.About_Pnl_Click);
            // 
            // About_Pbx
            // 
            this.About_Pbx.Image = ((System.Drawing.Image)(resources.GetObject("About_Pbx.Image")));
            this.About_Pbx.Location = new System.Drawing.Point(40, -1);
            this.About_Pbx.Name = "About_Pbx";
            this.About_Pbx.Size = new System.Drawing.Size(81, 75);
            this.About_Pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.About_Pbx.TabIndex = 0;
            this.About_Pbx.TabStop = false;
            this.About_Pbx.Click += new System.EventHandler(this.About_Pnl_Click);
            // 
            // TroGiup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.About_Pnl);
            this.Controls.Add(this.HDSD_Pnl);
            this.Name = "TroGiup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trợ Giúp";
            this.HDSD_Pnl.ResumeLayout(false);
            this.HDSD_Pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HDSD_Pbx)).EndInit();
            this.About_Pnl.ResumeLayout(false);
            this.About_Pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.About_Pbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel HDSD_Pnl;
        private System.Windows.Forms.Label HDSD_Lb;
        private System.Windows.Forms.PictureBox HDSD_Pbx;
        private System.Windows.Forms.Panel About_Pnl;
        private System.Windows.Forms.Label About_Lb;
        private System.Windows.Forms.PictureBox About_Pbx;
    }
}