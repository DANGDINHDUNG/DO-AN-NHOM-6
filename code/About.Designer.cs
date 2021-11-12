
namespace form
{
    partial class About
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
            this.QLKS_Lb = new System.Windows.Forms.Label();
            this.AppIcon_Pbx = new System.Windows.Forms.PictureBox();
            this.Info_Rtb = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AppIcon_Pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // QLKS_Lb
            // 
            this.QLKS_Lb.AutoSize = true;
            this.QLKS_Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLKS_Lb.Location = new System.Drawing.Point(155, 54);
            this.QLKS_Lb.Name = "QLKS_Lb";
            this.QLKS_Lb.Size = new System.Drawing.Size(310, 38);
            this.QLKS_Lb.TabIndex = 0;
            this.QLKS_Lb.Text = "Quản Lý Khách Sạn";
            // 
            // AppIcon_Pbx
            // 
            this.AppIcon_Pbx.Location = new System.Drawing.Point(30, 29);
            this.AppIcon_Pbx.Name = "AppIcon_Pbx";
            this.AppIcon_Pbx.Size = new System.Drawing.Size(119, 91);
            this.AppIcon_Pbx.TabIndex = 1;
            this.AppIcon_Pbx.TabStop = false;
            // 
            // Info_Rtb
            // 
            this.Info_Rtb.Location = new System.Drawing.Point(30, 153);
            this.Info_Rtb.Name = "Info_Rtb";
            this.Info_Rtb.ReadOnly = true;
            this.Info_Rtb.Size = new System.Drawing.Size(435, 179);
            this.Info_Rtb.TabIndex = 3;
            this.Info_Rtb.Text = "";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 365);
            this.Controls.Add(this.Info_Rtb);
            this.Controls.Add(this.AppIcon_Pbx);
            this.Controls.Add(this.QLKS_Lb);
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppIcon_Pbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QLKS_Lb;
        private System.Windows.Forms.PictureBox AppIcon_Pbx;
        private System.Windows.Forms.RichTextBox Info_Rtb;
    }
}