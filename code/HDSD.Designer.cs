
namespace form
{
    partial class HDSD
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
            this.Title_Lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title_Lb
            // 
            this.Title_Lb.AutoSize = true;
            this.Title_Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Lb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Title_Lb.Location = new System.Drawing.Point(180, 35);
            this.Title_Lb.Name = "Title_Lb";
            this.Title_Lb.Size = new System.Drawing.Size(208, 38);
            this.Title_Lb.TabIndex = 0;
            this.Title_Lb.Text = "How To Use";
            // 
            // HDSD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.Title_Lb);
            this.Name = "HDSD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HDSD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_Lb;
    }
}