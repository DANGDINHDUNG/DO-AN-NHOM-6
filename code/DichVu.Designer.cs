
namespace form
{
    partial class DichVu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbHOTEN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTENPHONG = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxDichVu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Turquoise;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(101, -23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(830, 114);
            this.label1.TabIndex = 1;
            this.label1.Text = "DỊCH VỤ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txbHOTEN
            // 
            this.txbHOTEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbHOTEN.Location = new System.Drawing.Point(225, 120);
            this.txbHOTEN.Name = "txbHOTEN";
            this.txbHOTEN.Size = new System.Drawing.Size(207, 27);
            this.txbHOTEN.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(50, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ tên khách hàng:";
            // 
            // txbTENPHONG
            // 
            this.txbTENPHONG.FormattingEnabled = true;
            this.txbTENPHONG.Items.AddRange(new object[] {
            "TỔNG THỐNG 1",
            "TỔNG THỐNG 2",
            "V.I.P ĐƠN 1 ",
            "V.I.P ĐƠN 2",
            "V.I.P ĐƠN 3",
            "V.I.P ĐƠN 4",
            "V.I.P ĐƠN 5",
            "V.I.P ĐƠN 6",
            "V.I.P ĐƠN 7",
            "V.I.P ĐƠN 8",
            "V.I.P ĐƠN 9",
            "V.I.P ĐƠN 10",
            "V.I.P ĐÔI 1",
            "V.I.P ĐÔI 2 ",
            "V.I.P ĐÔI 3",
            "V.I.P ĐÔI 4",
            "PHỔ THÔNG ĐƠN 1",
            "PHỔ THÔNG ĐƠN 2",
            "PHỔ THÔNG ĐƠN 3",
            "PHỔ THÔNG ĐƠN 4",
            "PHỔ THÔNG ĐƠN 5",
            "PHỔ THÔNG ĐƠN 6",
            "PHỔ THÔNG ĐƠN 7",
            "PHỔ THÔNG ĐƠN 8",
            "PHỔ THÔNG ĐƠN 9",
            "PHỔ THÔNG ĐƠN 10",
            "PHỔ THÔNG ĐƠN 11",
            "PHỔ THÔNG ĐƠN 12",
            "PHỔ THÔNG ĐƠN 13",
            "PHỔ THÔNG ĐƠN 14",
            "PHỔ THÔNG ĐƠN 15",
            "PHỔ THÔNG ĐÔI 1",
            "PHỔ THÔNG ĐÔI 2",
            "PHỔ THÔNG ĐÔI 3",
            "PHỔ THÔNG ĐÔI 4",
            "PHỔ THÔNG ĐÔI 5"});
            this.txbTENPHONG.Location = new System.Drawing.Point(588, 122);
            this.txbTENPHONG.Name = "txbTENPHONG";
            this.txbTENPHONG.Size = new System.Drawing.Size(170, 24);
            this.txbTENPHONG.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(473, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên phòng:";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMoney.Location = new System.Drawing.Point(923, 180);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(0, 23);
            this.lblMoney.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(1049, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "(VND)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(812, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "Thành tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(699, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "(Lần/Giờ/Bộ)";
            // 
            // txbQuantity
            // 
            this.txbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbQuantity.Location = new System.Drawing.Point(588, 180);
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Size = new System.Drawing.Size(97, 27);
            this.txbQuantity.TabIndex = 19;
            this.txbQuantity.TextChanged += new System.EventHandler(this.txbQuantity_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(473, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Số lượng";
            // 
            // cbxDichVu
            // 
            this.cbxDichVu.FormattingEnabled = true;
            this.cbxDichVu.Location = new System.Drawing.Point(225, 183);
            this.cbxDichVu.Name = "cbxDichVu";
            this.cbxDichVu.Size = new System.Drawing.Size(207, 24);
            this.cbxDichVu.TabIndex = 17;
            this.cbxDichVu.SelectedValueChanged += new System.EventHandler(this.cbxDichVu_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(50, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tên dịch vụ:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 289);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1051, 209);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(727, 228);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(151, 41);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Hủy dịch vụ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(532, 228);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 41);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Thêm/Cập nhật";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.Location = new System.Drawing.Point(332, 228);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(151, 41);
            this.btnInvoice.TabIndex = 25;
            this.btnInvoice.Text = "Xuất hóa đơn";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 528);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxDichVu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbTENPHONG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbHOTEN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DichVu";
            this.Text = "DichVu";
            this.Load += new System.EventHandler(this.DichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbHOTEN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txbTENPHONG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxDichVu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnInvoice;
    }
}