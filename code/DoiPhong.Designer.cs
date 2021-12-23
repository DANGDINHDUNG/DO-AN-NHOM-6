
namespace form
{
    partial class DoiPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiPhong));
            this.cbxTHANHTOAN = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxMALP = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.txbTENPHONG = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnCAPNHAT = new System.Windows.Forms.Button();
            this.txbSOLUONG = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCCCD = new System.Windows.Forms.Label();
            this.txbHOTEN = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxTHANHTOAN
            // 
            this.cbxTHANHTOAN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTHANHTOAN.FormattingEnabled = true;
            this.cbxTHANHTOAN.Items.AddRange(new object[] {
            "Tiền mặt",
            "VISA"});
            this.cbxTHANHTOAN.Location = new System.Drawing.Point(200, 506);
            this.cbxTHANHTOAN.Name = "cbxTHANHTOAN";
            this.cbxTHANHTOAN.Size = new System.Drawing.Size(176, 24);
            this.cbxTHANHTOAN.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Aqua;
            this.label10.Location = new System.Drawing.Point(12, 509);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 21);
            this.label10.TabIndex = 49;
            this.label10.Text = "Hình thức thanh toán";
            // 
            // cbxMALP
            // 
            this.cbxMALP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMALP.FormattingEnabled = true;
            this.cbxMALP.Items.AddRange(new object[] {
            "RST0 (Phòng tổng thống)",
            "VIP1 (Phòng V.I.P đơn)",
            "VIP2 (Phòng V.I.P đôi)",
            "NRM1 (Phòng phổ thông đơn)",
            "NRM2 (Phòng phổ thông đôi)"});
            this.cbxMALP.Location = new System.Drawing.Point(130, 341);
            this.cbxMALP.Name = "cbxMALP";
            this.cbxMALP.Size = new System.Drawing.Size(246, 24);
            this.cbxMALP.TabIndex = 47;
            this.cbxMALP.SelectedValueChanged += new System.EventHandler(this.cbxMALP_SelectedValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(404, 128);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(517, 134);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Aqua;
            this.button3.Location = new System.Drawing.Point(231, 566);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 46);
            this.button3.TabIndex = 45;
            this.button3.Text = "Hoàn thành";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txbTENPHONG
            // 
            this.txbTENPHONG.Location = new System.Drawing.Point(130, 388);
            this.txbTENPHONG.Name = "txbTENPHONG";
            this.txbTENPHONG.Size = new System.Drawing.Size(246, 22);
            this.txbTENPHONG.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Aqua;
            this.label9.Location = new System.Drawing.Point(13, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 21);
            this.label9.TabIndex = 42;
            this.label9.Text = "Tên phòng";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "MM/dd/yyyy HH:mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(130, 470);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(246, 22);
            this.dateTimePicker2.TabIndex = 41;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 430);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(246, 22);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Aqua;
            this.label8.Location = new System.Drawing.Point(13, 470);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 21);
            this.label8.TabIndex = 39;
            this.label8.Text = "Ngày Đi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Aqua;
            this.label7.Location = new System.Drawing.Point(13, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 21);
            this.label7.TabIndex = 38;
            this.label7.Text = "Ngày Đến";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Aqua;
            this.label6.Location = new System.Drawing.Point(13, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 21);
            this.label6.TabIndex = 37;
            this.label6.Text = "Loại Phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Aqua;
            this.label5.Location = new System.Drawing.Point(8, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 27);
            this.label5.TabIndex = 36;
            this.label5.Text = "Thông tin Phòng ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 27);
            this.label2.TabIndex = 34;
            this.label2.Text = "Thông tin liên lạc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(234, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 43);
            this.label1.TabIndex = 33;
            this.label1.Text = "ĐỔI PHÒNG KHÁCH SẠN";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(404, 331);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(517, 295);
            this.dataGridView2.TabIndex = 53;
            this.dataGridView2.Click += new System.EventHandler(this.dataGridView2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(401, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 27);
            this.label4.TabIndex = 54;
            this.label4.Text = "Phòng sẵn có";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Aqua;
            this.label11.Location = new System.Drawing.Point(399, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 27);
            this.label11.TabIndex = 55;
            this.label11.Text = "Phòng hiện tại";
            // 
            // btnDown
            // 
            this.btnDown.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDown.ForeColor = System.Drawing.Color.Aqua;
            this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
            this.btnDown.Location = new System.Drawing.Point(804, 275);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(56, 37);
            this.btnDown.TabIndex = 57;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUp.ForeColor = System.Drawing.Color.Aqua;
            this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
            this.btnUp.Location = new System.Drawing.Point(659, 275);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(56, 37);
            this.btnUp.TabIndex = 58;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnCAPNHAT
            // 
            this.btnCAPNHAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCAPNHAT.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCAPNHAT.ForeColor = System.Drawing.Color.Aqua;
            this.btnCAPNHAT.Location = new System.Drawing.Point(17, 566);
            this.btnCAPNHAT.Name = "btnCAPNHAT";
            this.btnCAPNHAT.Size = new System.Drawing.Size(148, 46);
            this.btnCAPNHAT.TabIndex = 59;
            this.btnCAPNHAT.Text = "Cập nhật";
            this.btnCAPNHAT.UseVisualStyleBackColor = true;
            this.btnCAPNHAT.Click += new System.EventHandler(this.btnCAPNHAT_Click);
            // 
            // txbSOLUONG
            // 
            this.txbSOLUONG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbSOLUONG.ForeColor = System.Drawing.Color.Aqua;
            this.txbSOLUONG.Location = new System.Drawing.Point(130, 239);
            this.txbSOLUONG.Name = "txbSOLUONG";
            this.txbSOLUONG.Size = new System.Drawing.Size(227, 22);
            this.txbSOLUONG.TabIndex = 65;
            this.txbSOLUONG.Text = "à";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(13, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 64;
            this.label3.Text = "Số lượng";
            // 
            // txbCCCD
            // 
            this.txbCCCD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbCCCD.ForeColor = System.Drawing.Color.Aqua;
            this.txbCCCD.Location = new System.Drawing.Point(130, 185);
            this.txbCCCD.Name = "txbCCCD";
            this.txbCCCD.Size = new System.Drawing.Size(227, 22);
            this.txbCCCD.TabIndex = 63;
            this.txbCCCD.Text = "à";
            // 
            // txbHOTEN
            // 
            this.txbHOTEN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbHOTEN.ForeColor = System.Drawing.Color.Aqua;
            this.txbHOTEN.Location = new System.Drawing.Point(130, 128);
            this.txbHOTEN.Name = "txbHOTEN";
            this.txbHOTEN.Size = new System.Drawing.Size(227, 22);
            this.txbHOTEN.TabIndex = 62;
            this.txbHOTEN.Text = "ádf";
            this.txbHOTEN.Click += new System.EventHandler(this.txbHOTEN_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label.ForeColor = System.Drawing.Color.Aqua;
            this.label.Location = new System.Drawing.Point(13, 187);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(122, 21);
            this.label.TabIndex = 61;
            this.label.Text = "CMND/CCCD";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.Color.Aqua;
            this.label12.Location = new System.Drawing.Point(13, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 21);
            this.label12.TabIndex = 60;
            this.label12.Text = "Họ và tên";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Aqua;
            this.button9.Location = new System.Drawing.Point(877, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 40);
            this.button9.TabIndex = 66;
            this.button9.Text = "x";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // DoiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(933, 637);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.txbSOLUONG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbCCCD);
            this.Controls.Add(this.txbHOTEN);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnCAPNHAT);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.cbxTHANHTOAN);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbxMALP);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txbTENPHONG);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DoiPhong";
            this.Text = "DoiPhong";
            this.Load += new System.EventHandler(this.DoiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxTHANHTOAN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxMALP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txbTENPHONG;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnCAPNHAT;
        private System.Windows.Forms.Label txbSOLUONG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txbCCCD;
        private System.Windows.Forms.Label txbHOTEN;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button9;
    }
}