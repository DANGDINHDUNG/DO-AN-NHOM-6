
namespace form
{
    partial class InHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InHoaDon));
            this.InHoaDon_Pnl = new System.Windows.Forms.Panel();
            this.InHoaDon_Lb = new System.Windows.Forms.Label();
            this.InHoaDon_Pbx = new System.Windows.Forms.PictureBox();
            this.InHoaDon_Pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InHoaDon_Pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // InHoaDon_Pnl
            // 
            this.InHoaDon_Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InHoaDon_Pnl.Controls.Add(this.InHoaDon_Lb);
            this.InHoaDon_Pnl.Controls.Add(this.InHoaDon_Pbx);
            this.InHoaDon_Pnl.Location = new System.Drawing.Point(12, 12);
            this.InHoaDon_Pnl.Name = "InHoaDon_Pnl";
            this.InHoaDon_Pnl.Size = new System.Drawing.Size(88, 114);
            this.InHoaDon_Pnl.TabIndex = 4;
            // 
            // InHoaDon_Lb
            // 
            this.InHoaDon_Lb.AutoSize = true;
            this.InHoaDon_Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InHoaDon_Lb.Location = new System.Drawing.Point(1, 84);
            this.InHoaDon_Lb.Name = "InHoaDon_Lb";
            this.InHoaDon_Lb.Size = new System.Drawing.Size(79, 17);
            this.InHoaDon_Lb.TabIndex = 3;
            this.InHoaDon_Lb.Text = "In Hóa Đơn";
            // 
            // InHoaDon_Pbx
            // 
            this.InHoaDon_Pbx.Image = ((System.Drawing.Image)(resources.GetObject("InHoaDon_Pbx.Image")));
            this.InHoaDon_Pbx.Location = new System.Drawing.Point(4, 6);
            this.InHoaDon_Pbx.Name = "InHoaDon_Pbx";
            this.InHoaDon_Pbx.Size = new System.Drawing.Size(67, 75);
            this.InHoaDon_Pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InHoaDon_Pbx.TabIndex = 0;
            this.InHoaDon_Pbx.TabStop = false;
            this.InHoaDon_Pbx.Click += new System.EventHandler(this.InHoaDon_Pbx_Click);
            // 
            // InHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InHoaDon_Pnl);
            this.Name = "InHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In Hóa Đơn";
            this.InHoaDon_Pnl.ResumeLayout(false);
            this.InHoaDon_Pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InHoaDon_Pbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InHoaDon_Pnl;
        private System.Windows.Forms.Label InHoaDon_Lb;
        private System.Windows.Forms.PictureBox InHoaDon_Pbx;
    }
}