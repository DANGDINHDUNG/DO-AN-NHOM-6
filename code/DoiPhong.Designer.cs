﻿
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
            this.txbCCCD = new System.Windows.Forms.Label();
            this.txbHOTEN = new System.Windows.Forms.Label();
            this.cbxTHANHTOAN = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txbCCCD
            // 
            this.txbCCCD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbCCCD.Location = new System.Drawing.Point(157, 174);
            this.txbCCCD.Name = "txbCCCD";
            this.txbCCCD.Size = new System.Drawing.Size(246, 22);
            this.txbCCCD.TabIndex = 52;
            this.txbCCCD.Text = "42357";
            // 
            // txbHOTEN
            // 
            this.txbHOTEN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbHOTEN.Location = new System.Drawing.Point(157, 113);
            this.txbHOTEN.Name = "txbHOTEN";
            this.txbHOTEN.Size = new System.Drawing.Size(246, 22);
            this.txbHOTEN.TabIndex = 51;
            // 
            // cbxTHANHTOAN
            // 
            this.cbxTHANHTOAN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTHANHTOAN.FormattingEnabled = true;
            this.cbxTHANHTOAN.Items.AddRange(new object[] {
            "Tiền mặt ",
            "Chuyển khoản"});
            this.cbxTHANHTOAN.Location = new System.Drawing.Point(175, 451);
            this.cbxTHANHTOAN.Name = "cbxTHANHTOAN";
            this.cbxTHANHTOAN.Size = new System.Drawing.Size(111, 24);
            this.cbxTHANHTOAN.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 454);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 17);
            this.label10.TabIndex = 49;
            this.label10.Text = "Hình thức thanh toán";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label.Location = new System.Drawing.Point(25, 174);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(109, 19);
            this.label.TabIndex = 48;
            this.label.Text = "CMND/CCCD";
            // 
            // cbxMALP
            // 
            this.cbxMALP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMALP.FormattingEnabled = true;
            this.cbxMALP.Items.AddRange(new object[] {
            "RST (Phòng tổng thống)",
            "VIP (Phòng V.I.P)",
            "NRM (Phòng phổ thông)"});
            this.cbxMALP.Location = new System.Drawing.Point(154, 283);
            this.cbxMALP.Name = "cbxMALP";
            this.cbxMALP.Size = new System.Drawing.Size(246, 24);
            this.cbxMALP.TabIndex = 47;
            this.cbxMALP.SelectedValueChanged += new System.EventHandler(this.cbxMALP_SelectedValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(434, 91);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(605, 130);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(198, 504);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 37);
            this.button3.TabIndex = 45;
            this.button3.Text = "Hoàn thành";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txbTENPHONG
            // 
            this.txbTENPHONG.Location = new System.Drawing.Point(152, 326);
            this.txbTENPHONG.Name = "txbTENPHONG";
            this.txbTENPHONG.Size = new System.Drawing.Size(246, 22);
            this.txbTENPHONG.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Tên phòng";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(153, 408);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(109, 22);
            this.dateTimePicker2.TabIndex = 41;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 368);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 22);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Ngày Đi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Ngày Đến";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Loại Phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 27);
            this.label5.TabIndex = 36;
            this.label5.Text = "Thông tin Phòng ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(25, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 27);
            this.label2.TabIndex = 34;
            this.label2.Text = "Thông tin liên lạc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "ĐỔI PHÒNG KHÁCH SẠN";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(434, 297);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(605, 258);
            this.dataGridView2.TabIndex = 53;
            this.dataGridView2.Click += new System.EventHandler(this.dataGridView2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 27);
            this.label4.TabIndex = 54;
            this.label4.Text = "Phòng sẵn có";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(855, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 27);
            this.label11.TabIndex = 55;
            this.label11.Text = "Phòng hiện tại";
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
            this.btnDown.Location = new System.Drawing.Point(774, 240);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(56, 37);
            this.btnDown.TabIndex = 57;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUp.ForeColor = System.Drawing.Color.Black;
            this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
            this.btnUp.Location = new System.Drawing.Point(663, 240);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(56, 37);
            this.btnUp.TabIndex = 58;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // DoiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 574);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txbCCCD);
            this.Controls.Add(this.txbHOTEN);
            this.Controls.Add(this.cbxTHANHTOAN);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label);
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
            this.Controls.Add(this.label3);
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

        private System.Windows.Forms.Label txbCCCD;
        private System.Windows.Forms.Label txbHOTEN;
        private System.Windows.Forms.ComboBox cbxTHANHTOAN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
    }
}