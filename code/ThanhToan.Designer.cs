
namespace form
{
    partial class ThanhToan
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
            this.QuyDinh_Lb = new System.Windows.Forms.Label();
            this.TraPhongTruoc_Lb = new System.Windows.Forms.Label();
            this.NhanPhongSau_Lb = new System.Windows.Forms.Label();
            this.TTNuaNgay_Cbx = new System.Windows.Forms.CheckBox();
            this.NhanPhongTu_Lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NhanPhongTu_Dtp = new System.Windows.Forms.DateTimePicker();
            this.TraPhongTu_Dtp = new System.Windows.Forms.DateTimePicker();
            this.NhanPhongDen_Lb = new System.Windows.Forms.Label();
            this.TraPhongDen_Lb = new System.Windows.Forms.Label();
            this.NhanPhongDen_Dtp = new System.Windows.Forms.DateTimePicker();
            this.TraPhongDen_Dtp = new System.Windows.Forms.DateTimePicker();
            this.TraPhongTruoc_Dtp = new System.Windows.Forms.DateTimePicker();
            this.NhanPhongSau_Dtp = new System.Windows.Forms.DateTimePicker();
            this.Luu_Btn = new System.Windows.Forms.Button();
            this.Huy_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuyDinh_Lb
            // 
            this.QuyDinh_Lb.AutoSize = true;
            this.QuyDinh_Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuyDinh_Lb.Location = new System.Drawing.Point(195, 33);
            this.QuyDinh_Lb.Name = "QuyDinh_Lb";
            this.QuyDinh_Lb.Size = new System.Drawing.Size(172, 18);
            this.QuyDinh_Lb.TabIndex = 1;
            this.QuyDinh_Lb.Text = "Quy Định Cách Tính Tiền";
            // 
            // TraPhongTruoc_Lb
            // 
            this.TraPhongTruoc_Lb.AutoSize = true;
            this.TraPhongTruoc_Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TraPhongTruoc_Lb.Location = new System.Drawing.Point(123, 83);
            this.TraPhongTruoc_Lb.Name = "TraPhongTruoc_Lb";
            this.TraPhongTruoc_Lb.Size = new System.Drawing.Size(120, 18);
            this.TraPhongTruoc_Lb.TabIndex = 2;
            this.TraPhongTruoc_Lb.Text = "Trả Phòng Trước";
            // 
            // NhanPhongSau_Lb
            // 
            this.NhanPhongSau_Lb.AutoSize = true;
            this.NhanPhongSau_Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhanPhongSau_Lb.Location = new System.Drawing.Point(123, 129);
            this.NhanPhongSau_Lb.Name = "NhanPhongSau_Lb";
            this.NhanPhongSau_Lb.Size = new System.Drawing.Size(107, 18);
            this.NhanPhongSau_Lb.TabIndex = 3;
            this.NhanPhongSau_Lb.Text = "Trả Phòng Sau";
            // 
            // TTNuaNgay_Cbx
            // 
            this.TTNuaNgay_Cbx.AutoSize = true;
            this.TTNuaNgay_Cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTNuaNgay_Cbx.Location = new System.Drawing.Point(198, 187);
            this.TTNuaNgay_Cbx.Name = "TTNuaNgay_Cbx";
            this.TTNuaNgay_Cbx.Size = new System.Drawing.Size(159, 22);
            this.TTNuaNgay_Cbx.TabIndex = 4;
            this.TTNuaNgay_Cbx.Text = "Tính Tiền Nửa Ngày";
            this.TTNuaNgay_Cbx.UseVisualStyleBackColor = true;
            this.TTNuaNgay_Cbx.CheckedChanged += new System.EventHandler(this.TTNuaNgay_Cbx_CheckedChanged);
            // 
            // NhanPhongTu_Lb
            // 
            this.NhanPhongTu_Lb.AutoSize = true;
            this.NhanPhongTu_Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhanPhongTu_Lb.Location = new System.Drawing.Point(65, 250);
            this.NhanPhongTu_Lb.Name = "NhanPhongTu_Lb";
            this.NhanPhongTu_Lb.Size = new System.Drawing.Size(111, 18);
            this.NhanPhongTu_Lb.TabIndex = 5;
            this.NhanPhongTu_Lb.Text = "Nhận Phòng Từ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Trả Phòng Từ";
            // 
            // NhanPhongTu_Dtp
            // 
            this.NhanPhongTu_Dtp.CustomFormat = "hh:mm:ss tt";
            this.NhanPhongTu_Dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhanPhongTu_Dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NhanPhongTu_Dtp.Location = new System.Drawing.Point(198, 247);
            this.NhanPhongTu_Dtp.Name = "NhanPhongTu_Dtp";
            this.NhanPhongTu_Dtp.ShowUpDown = true;
            this.NhanPhongTu_Dtp.Size = new System.Drawing.Size(116, 22);
            this.NhanPhongTu_Dtp.TabIndex = 7;
            // 
            // TraPhongTu_Dtp
            // 
            this.TraPhongTu_Dtp.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TraPhongTu_Dtp.CustomFormat = "hh:mm:ss tt";
            this.TraPhongTu_Dtp.Enabled = false;
            this.TraPhongTu_Dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TraPhongTu_Dtp.Location = new System.Drawing.Point(198, 308);
            this.TraPhongTu_Dtp.Name = "TraPhongTu_Dtp";
            this.TraPhongTu_Dtp.ShowUpDown = true;
            this.TraPhongTu_Dtp.Size = new System.Drawing.Size(116, 22);
            this.TraPhongTu_Dtp.TabIndex = 8;
            this.TraPhongTu_Dtp.Value = new System.DateTime(2021, 11, 3, 0, 0, 0, 0);
            // 
            // NhanPhongDen_Lb
            // 
            this.NhanPhongDen_Lb.AutoSize = true;
            this.NhanPhongDen_Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhanPhongDen_Lb.Location = new System.Drawing.Point(332, 251);
            this.NhanPhongDen_Lb.Name = "NhanPhongDen_Lb";
            this.NhanPhongDen_Lb.Size = new System.Drawing.Size(35, 18);
            this.NhanPhongDen_Lb.TabIndex = 9;
            this.NhanPhongDen_Lb.Text = "Đến";
            // 
            // TraPhongDen_Lb
            // 
            this.TraPhongDen_Lb.AutoSize = true;
            this.TraPhongDen_Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TraPhongDen_Lb.Location = new System.Drawing.Point(332, 312);
            this.TraPhongDen_Lb.Name = "TraPhongDen_Lb";
            this.TraPhongDen_Lb.Size = new System.Drawing.Size(35, 18);
            this.TraPhongDen_Lb.TabIndex = 10;
            this.TraPhongDen_Lb.Text = "Đến";
            // 
            // NhanPhongDen_Dtp
            // 
            this.NhanPhongDen_Dtp.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhanPhongDen_Dtp.CustomFormat = "hh:mm:ss tt";
            this.NhanPhongDen_Dtp.Enabled = false;
            this.NhanPhongDen_Dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NhanPhongDen_Dtp.Location = new System.Drawing.Point(389, 247);
            this.NhanPhongDen_Dtp.Name = "NhanPhongDen_Dtp";
            this.NhanPhongDen_Dtp.ShowUpDown = true;
            this.NhanPhongDen_Dtp.Size = new System.Drawing.Size(115, 22);
            this.NhanPhongDen_Dtp.TabIndex = 11;
            this.NhanPhongDen_Dtp.Value = new System.DateTime(2021, 11, 3, 0, 0, 0, 0);
            // 
            // TraPhongDen_Dtp
            // 
            this.TraPhongDen_Dtp.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TraPhongDen_Dtp.CustomFormat = "hh:mm:ss tt";
            this.TraPhongDen_Dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TraPhongDen_Dtp.Location = new System.Drawing.Point(389, 308);
            this.TraPhongDen_Dtp.Name = "TraPhongDen_Dtp";
            this.TraPhongDen_Dtp.ShowUpDown = true;
            this.TraPhongDen_Dtp.Size = new System.Drawing.Size(115, 22);
            this.TraPhongDen_Dtp.TabIndex = 12;
            // 
            // TraPhongTruoc_Dtp
            // 
            this.TraPhongTruoc_Dtp.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TraPhongTruoc_Dtp.CustomFormat = "hh:mm:ss tt";
            this.TraPhongTruoc_Dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TraPhongTruoc_Dtp.Location = new System.Drawing.Point(276, 83);
            this.TraPhongTruoc_Dtp.Name = "TraPhongTruoc_Dtp";
            this.TraPhongTruoc_Dtp.ShowUpDown = true;
            this.TraPhongTruoc_Dtp.Size = new System.Drawing.Size(114, 22);
            this.TraPhongTruoc_Dtp.TabIndex = 13;
            this.TraPhongTruoc_Dtp.Value = new System.DateTime(2021, 11, 3, 0, 0, 0, 0);
            // 
            // NhanPhongSau_Dtp
            // 
            this.NhanPhongSau_Dtp.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhanPhongSau_Dtp.CustomFormat = "hh:mm:ss tt";
            this.NhanPhongSau_Dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NhanPhongSau_Dtp.Location = new System.Drawing.Point(276, 129);
            this.NhanPhongSau_Dtp.Name = "NhanPhongSau_Dtp";
            this.NhanPhongSau_Dtp.ShowUpDown = true;
            this.NhanPhongSau_Dtp.Size = new System.Drawing.Size(114, 22);
            this.NhanPhongSau_Dtp.TabIndex = 14;
            this.NhanPhongSau_Dtp.Value = new System.DateTime(2021, 11, 3, 0, 0, 0, 0);
            // 
            // Luu_Btn
            // 
            this.Luu_Btn.Location = new System.Drawing.Point(114, 368);
            this.Luu_Btn.Name = "Luu_Btn";
            this.Luu_Btn.Size = new System.Drawing.Size(116, 26);
            this.Luu_Btn.TabIndex = 17;
            this.Luu_Btn.Text = "Lưu";
            this.Luu_Btn.UseVisualStyleBackColor = true;
            // 
            // Huy_Btn
            // 
            this.Huy_Btn.Location = new System.Drawing.Point(311, 368);
            this.Huy_Btn.Name = "Huy_Btn";
            this.Huy_Btn.Size = new System.Drawing.Size(116, 26);
            this.Huy_Btn.TabIndex = 18;
            this.Huy_Btn.Text = "Hủy";
            this.Huy_Btn.UseVisualStyleBackColor = true;
            this.Huy_Btn.Click += new System.EventHandler(this.Huy_Btn_Click);
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 427);
            this.Controls.Add(this.Huy_Btn);
            this.Controls.Add(this.Luu_Btn);
            this.Controls.Add(this.NhanPhongSau_Dtp);
            this.Controls.Add(this.TraPhongTruoc_Dtp);
            this.Controls.Add(this.TraPhongDen_Dtp);
            this.Controls.Add(this.NhanPhongDen_Dtp);
            this.Controls.Add(this.TraPhongDen_Lb);
            this.Controls.Add(this.NhanPhongDen_Lb);
            this.Controls.Add(this.TraPhongTu_Dtp);
            this.Controls.Add(this.NhanPhongTu_Dtp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NhanPhongTu_Lb);
            this.Controls.Add(this.TTNuaNgay_Cbx);
            this.Controls.Add(this.NhanPhongSau_Lb);
            this.Controls.Add(this.TraPhongTruoc_Lb);
            this.Controls.Add(this.QuyDinh_Lb);
            this.Name = "ThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh Toán";
            this.Load += new System.EventHandler(this.ThanhToan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuyDinh_Lb;
        private System.Windows.Forms.Label TraPhongTruoc_Lb;
        private System.Windows.Forms.Label NhanPhongSau_Lb;
        private System.Windows.Forms.CheckBox TTNuaNgay_Cbx;
        private System.Windows.Forms.Label NhanPhongTu_Lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker NhanPhongTu_Dtp;
        private System.Windows.Forms.DateTimePicker TraPhongTu_Dtp;
        private System.Windows.Forms.Label NhanPhongDen_Lb;
        private System.Windows.Forms.Label TraPhongDen_Lb;
        private System.Windows.Forms.DateTimePicker NhanPhongDen_Dtp;
        private System.Windows.Forms.DateTimePicker TraPhongDen_Dtp;
        private System.Windows.Forms.DateTimePicker TraPhongTruoc_Dtp;
        private System.Windows.Forms.DateTimePicker NhanPhongSau_Dtp;
        private System.Windows.Forms.Button Luu_Btn;
        private System.Windows.Forms.Button Huy_Btn;
    }
}