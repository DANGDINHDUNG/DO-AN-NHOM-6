
namespace QLKS
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
            this.InHoaDon_Btn = new System.Windows.Forms.Button();
            this.HoaDon_Rtb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // InHoaDon_Btn
            // 
            this.InHoaDon_Btn.BackColor = System.Drawing.SystemColors.Window;
            this.InHoaDon_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InHoaDon_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InHoaDon_Btn.Location = new System.Drawing.Point(288, 23);
            this.InHoaDon_Btn.Name = "InHoaDon_Btn";
            this.InHoaDon_Btn.Size = new System.Drawing.Size(229, 57);
            this.InHoaDon_Btn.TabIndex = 6;
            this.InHoaDon_Btn.Text = "In Hóa Đơn";
            this.InHoaDon_Btn.UseVisualStyleBackColor = false;
            this.InHoaDon_Btn.Click += new System.EventHandler(this.InHoaDon_Btn_Click);
            // 
            // HoaDon_Rtb
            // 
            this.HoaDon_Rtb.Location = new System.Drawing.Point(12, 50);
            this.HoaDon_Rtb.Name = "HoaDon_Rtb";
            this.HoaDon_Rtb.Size = new System.Drawing.Size(776, 388);
            this.HoaDon_Rtb.TabIndex = 7;
            this.HoaDon_Rtb.Text = "";
            this.HoaDon_Rtb.Visible = false;
            // 
            // InHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InHoaDon_Btn);
            this.Controls.Add(this.HoaDon_Rtb);
            this.Name = "InHoaDon";
            this.Text = "InHoaDon";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InHoaDon_Btn;
        private System.Windows.Forms.RichTextBox HoaDon_Rtb;
    }
}