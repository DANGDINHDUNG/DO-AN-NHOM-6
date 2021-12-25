
namespace form
{
    partial class DoanhThu
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoanhThu));
            this.rbtnThisYear = new System.Windows.Forms.RadioButton();
            this.rbtnLastMonth = new System.Windows.Forms.RadioButton();
            this.rbtnThisMonth = new System.Windows.Forms.RadioButton();
            this.rbtnToday = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnThisYear
            // 
            this.rbtnThisYear.AutoSize = true;
            this.rbtnThisYear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbtnThisYear.ForeColor = System.Drawing.Color.Aqua;
            this.rbtnThisYear.Location = new System.Drawing.Point(708, 30);
            this.rbtnThisYear.Name = "rbtnThisYear";
            this.rbtnThisYear.Size = new System.Drawing.Size(114, 32);
            this.rbtnThisYear.TabIndex = 17;
            this.rbtnThisYear.TabStop = true;
            this.rbtnThisYear.Text = "Năm này";
            this.rbtnThisYear.UseVisualStyleBackColor = true;
            this.rbtnThisYear.CheckedChanged += new System.EventHandler(this.Checked_Date);
            // 
            // rbtnLastMonth
            // 
            this.rbtnLastMonth.AutoSize = true;
            this.rbtnLastMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbtnLastMonth.ForeColor = System.Drawing.Color.Aqua;
            this.rbtnLastMonth.Location = new System.Drawing.Point(544, 30);
            this.rbtnLastMonth.Name = "rbtnLastMonth";
            this.rbtnLastMonth.Size = new System.Drawing.Size(143, 32);
            this.rbtnLastMonth.TabIndex = 16;
            this.rbtnLastMonth.TabStop = true;
            this.rbtnLastMonth.Text = "Tháng trước";
            this.rbtnLastMonth.UseVisualStyleBackColor = true;
            this.rbtnLastMonth.CheckedChanged += new System.EventHandler(this.Checked_Date);
            // 
            // rbtnThisMonth
            // 
            this.rbtnThisMonth.AutoSize = true;
            this.rbtnThisMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbtnThisMonth.ForeColor = System.Drawing.Color.Aqua;
            this.rbtnThisMonth.Location = new System.Drawing.Point(389, 30);
            this.rbtnThisMonth.Name = "rbtnThisMonth";
            this.rbtnThisMonth.Size = new System.Drawing.Size(128, 32);
            this.rbtnThisMonth.TabIndex = 15;
            this.rbtnThisMonth.TabStop = true;
            this.rbtnThisMonth.Text = "Tháng này";
            this.rbtnThisMonth.UseVisualStyleBackColor = true;
            this.rbtnThisMonth.CheckedChanged += new System.EventHandler(this.Checked_Date);
            // 
            // rbtnToday
            // 
            this.rbtnToday.AutoSize = true;
            this.rbtnToday.Checked = true;
            this.rbtnToday.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbtnToday.ForeColor = System.Drawing.Color.Aqua;
            this.rbtnToday.Location = new System.Drawing.Point(240, 30);
            this.rbtnToday.Name = "rbtnToday";
            this.rbtnToday.Size = new System.Drawing.Size(116, 32);
            this.rbtnToday.TabIndex = 14;
            this.rbtnToday.TabStop = true;
            this.rbtnToday.Text = "Hôm nay";
            this.rbtnToday.UseVisualStyleBackColor = true;
            this.rbtnToday.CheckedChanged += new System.EventHandler(this.Checked_Date);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mốc thời gian";
            // 
            // chartControl1
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(24, 101);
            this.chartControl1.Name = "chartControl1";
            series1.Name = "Doanh thu";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(1069, 573);
            this.chartControl1.TabIndex = 18;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioButton1.ForeColor = System.Drawing.Color.Aqua;
            this.radioButton1.Location = new System.Drawing.Point(855, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(129, 32);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Năm trước";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.Checked_Date);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Aqua;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(1086, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 40);
            this.button9.TabIndex = 74;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1142, 686);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.rbtnThisYear);
            this.Controls.Add(this.rbtnLastMonth);
            this.Controls.Add(this.rbtnThisMonth);
            this.Controls.Add(this.rbtnToday);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoanhThu";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnThisYear;
        private System.Windows.Forms.RadioButton rbtnLastMonth;
        private System.Windows.Forms.RadioButton rbtnThisMonth;
        private System.Windows.Forms.RadioButton rbtnToday;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button9;
    }
}