
namespace QuanLyKhachSan
{
    partial class ThietLapMang
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
            this.IP_lb = new System.Windows.Forms.Label();
            this.Cong_Lb = new System.Windows.Forms.Label();
            this.IP_Tbx = new System.Windows.Forms.TextBox();
            this.Cong_Tbx = new System.Windows.Forms.TextBox();
            this.Huy_Btn = new System.Windows.Forms.Button();
            this.Luu_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IP_lb
            // 
            this.IP_lb.AutoSize = true;
            this.IP_lb.Location = new System.Drawing.Point(53, 53);
            this.IP_lb.Name = "IP_lb";
            this.IP_lb.Size = new System.Drawing.Size(79, 17);
            this.IP_lb.TabIndex = 0;
            this.IP_lb.Text = "IP Máy Chủ";
            // 
            // Cong_Lb
            // 
            this.Cong_Lb.AutoSize = true;
            this.Cong_Lb.Location = new System.Drawing.Point(53, 117);
            this.Cong_Lb.Name = "Cong_Lb";
            this.Cong_Lb.Size = new System.Drawing.Size(41, 17);
            this.Cong_Lb.TabIndex = 1;
            this.Cong_Lb.Text = "Cổng";
            // 
            // IP_Tbx
            // 
            this.IP_Tbx.Location = new System.Drawing.Point(148, 50);
            this.IP_Tbx.Name = "IP_Tbx";
            this.IP_Tbx.Size = new System.Drawing.Size(145, 22);
            this.IP_Tbx.TabIndex = 2;
            // 
            // Cong_Tbx
            // 
            this.Cong_Tbx.Location = new System.Drawing.Point(148, 114);
            this.Cong_Tbx.Name = "Cong_Tbx";
            this.Cong_Tbx.Size = new System.Drawing.Size(145, 22);
            this.Cong_Tbx.TabIndex = 3;
            // 
            // Huy_Btn
            // 
            this.Huy_Btn.Location = new System.Drawing.Point(212, 177);
            this.Huy_Btn.Name = "Huy_Btn";
            this.Huy_Btn.Size = new System.Drawing.Size(81, 26);
            this.Huy_Btn.TabIndex = 20;
            this.Huy_Btn.Text = "Hủy";
            this.Huy_Btn.UseVisualStyleBackColor = true;
            this.Huy_Btn.Click += new System.EventHandler(this.Huy_Btn_Click);
            // 
            // Luu_Btn
            // 
            this.Luu_Btn.Location = new System.Drawing.Point(101, 177);
            this.Luu_Btn.Name = "Luu_Btn";
            this.Luu_Btn.Size = new System.Drawing.Size(81, 26);
            this.Luu_Btn.TabIndex = 19;
            this.Luu_Btn.Text = "Lưu";
            this.Luu_Btn.UseVisualStyleBackColor = true;
            // 
            // ThietLapMang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 243);
            this.Controls.Add(this.Huy_Btn);
            this.Controls.Add(this.Luu_Btn);
            this.Controls.Add(this.Cong_Tbx);
            this.Controls.Add(this.IP_Tbx);
            this.Controls.Add(this.Cong_Lb);
            this.Controls.Add(this.IP_lb);
            this.Name = "ThietLapMang";
            this.Text = "ThietLapMang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IP_lb;
        private System.Windows.Forms.Label Cong_Lb;
        private System.Windows.Forms.TextBox IP_Tbx;
        private System.Windows.Forms.TextBox Cong_Tbx;
        private System.Windows.Forms.Button Huy_Btn;
        private System.Windows.Forms.Button Luu_Btn;
    }
}