
namespace form
{
    partial class HuyPhong
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
            this.DSPhong_Lb = new System.Windows.Forms.Label();
            this.DSPhong_Dgv = new System.Windows.Forms.DataGridView();
            this.HuyPhong_Btn = new System.Windows.Forms.Button();
            this.Thoat_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DSPhong_Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // DSPhong_Lb
            // 
            this.DSPhong_Lb.AutoSize = true;
            this.DSPhong_Lb.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSPhong_Lb.Location = new System.Drawing.Point(93, 34);
            this.DSPhong_Lb.Name = "DSPhong_Lb";
            this.DSPhong_Lb.Size = new System.Drawing.Size(413, 36);
            this.DSPhong_Lb.TabIndex = 7;
            this.DSPhong_Lb.Text = "DANH SÁCH PHÒNG ĐÃ ĐẶT";
            // 
            // DSPhong_Dgv
            // 
            this.DSPhong_Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSPhong_Dgv.Location = new System.Drawing.Point(12, 99);
            this.DSPhong_Dgv.Name = "DSPhong_Dgv";
            this.DSPhong_Dgv.RowHeadersWidth = 51;
            this.DSPhong_Dgv.RowTemplate.Height = 24;
            this.DSPhong_Dgv.Size = new System.Drawing.Size(602, 210);
            this.DSPhong_Dgv.TabIndex = 8;
            // 
            // HuyPhong_Btn
            // 
            this.HuyPhong_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuyPhong_Btn.Location = new System.Drawing.Point(146, 363);
            this.HuyPhong_Btn.Name = "HuyPhong_Btn";
            this.HuyPhong_Btn.Size = new System.Drawing.Size(115, 48);
            this.HuyPhong_Btn.TabIndex = 9;
            this.HuyPhong_Btn.Text = "Hủy Phòng";
            this.HuyPhong_Btn.UseVisualStyleBackColor = true;
            // 
            // Thoat_Btn
            // 
            this.Thoat_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat_Btn.Location = new System.Drawing.Point(359, 363);
            this.Thoat_Btn.Name = "Thoat_Btn";
            this.Thoat_Btn.Size = new System.Drawing.Size(115, 48);
            this.Thoat_Btn.TabIndex = 10;
            this.Thoat_Btn.Text = "Thoát";
            this.Thoat_Btn.UseVisualStyleBackColor = true;
            this.Thoat_Btn.Click += new System.EventHandler(this.Thoat_Btn_Click);
            // 
            // HuyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 450);
            this.Controls.Add(this.Thoat_Btn);
            this.Controls.Add(this.HuyPhong_Btn);
            this.Controls.Add(this.DSPhong_Dgv);
            this.Controls.Add(this.DSPhong_Lb);
            this.Name = "HuyPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hủy Phòng";
            ((System.ComponentModel.ISupportInitialize)(this.DSPhong_Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DSPhong_Lb;
        private System.Windows.Forms.DataGridView DSPhong_Dgv;
        private System.Windows.Forms.Button HuyPhong_Btn;
        private System.Windows.Forms.Button Thoat_Btn;
    }
}