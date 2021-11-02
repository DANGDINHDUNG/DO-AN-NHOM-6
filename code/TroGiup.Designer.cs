
namespace QLKS
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
            this.HDSD_Btn = new System.Windows.Forms.Button();
            this.About_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HDSD_Btn
            // 
            this.HDSD_Btn.BackColor = System.Drawing.SystemColors.Window;
            this.HDSD_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDSD_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HDSD_Btn.Location = new System.Drawing.Point(216, 129);
            this.HDSD_Btn.Name = "HDSD_Btn";
            this.HDSD_Btn.Size = new System.Drawing.Size(360, 57);
            this.HDSD_Btn.TabIndex = 6;
            this.HDSD_Btn.Text = "Hướng Dẫn Sử Dụng";
            this.HDSD_Btn.UseVisualStyleBackColor = false;
            this.HDSD_Btn.Click += new System.EventHandler(this.HDSD_Btn_Click);
            // 
            // About_Btn
            // 
            this.About_Btn.BackColor = System.Drawing.SystemColors.Window;
            this.About_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.About_Btn.Location = new System.Drawing.Point(216, 243);
            this.About_Btn.Name = "About_Btn";
            this.About_Btn.Size = new System.Drawing.Size(360, 57);
            this.About_Btn.TabIndex = 7;
            this.About_Btn.Text = "Về Quản Lý Khách Sạn";
            this.About_Btn.UseVisualStyleBackColor = false;
            this.About_Btn.Click += new System.EventHandler(this.About_Btn_Click);
            // 
            // TroGiup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.About_Btn);
            this.Controls.Add(this.HDSD_Btn);
            this.Name = "TroGiup";
            this.Text = "TroGiup";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HDSD_Btn;
        private System.Windows.Forms.Button About_Btn;
    }
}