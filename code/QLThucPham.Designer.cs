
namespace form
{
    partial class QLThucPham
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
            this.label7 = new System.Windows.Forms.Label();
            this.dgvTHUCPHAM = new System.Windows.Forms.DataGridView();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.rbtnFood = new System.Windows.Forms.RadioButton();
            this.rbtnDrink = new System.Windows.Forms.RadioButton();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTHUCPHAM)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Aqua;
            this.label7.Location = new System.Drawing.Point(385, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(433, 38);
            this.label7.TabIndex = 13;
            this.label7.Text = "THÔNG TIN THỰC PHẨM";
            // 
            // dgvTHUCPHAM
            // 
            this.dgvTHUCPHAM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTHUCPHAM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTHUCPHAM.Location = new System.Drawing.Point(12, 120);
            this.dgvTHUCPHAM.Name = "dgvTHUCPHAM";
            this.dgvTHUCPHAM.ReadOnly = true;
            this.dgvTHUCPHAM.RowHeadersWidth = 51;
            this.dgvTHUCPHAM.RowTemplate.Height = 24;
            this.dgvTHUCPHAM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTHUCPHAM.Size = new System.Drawing.Size(825, 545);
            this.dgvTHUCPHAM.TabIndex = 22;
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Checked = true;
            this.rbtnAll.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAll.ForeColor = System.Drawing.Color.Aqua;
            this.rbtnAll.Location = new System.Drawing.Point(15, 74);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(93, 31);
            this.rbtnAll.TabIndex = 23;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "Tất cả";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.CheckedChanged += new System.EventHandler(this.Checked_Food);
            // 
            // rbtnFood
            // 
            this.rbtnFood.AutoSize = true;
            this.rbtnFood.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFood.ForeColor = System.Drawing.Color.Aqua;
            this.rbtnFood.Location = new System.Drawing.Point(178, 74);
            this.rbtnFood.Name = "rbtnFood";
            this.rbtnFood.Size = new System.Drawing.Size(112, 31);
            this.rbtnFood.TabIndex = 24;
            this.rbtnFood.Text = "Thức ăn";
            this.rbtnFood.UseVisualStyleBackColor = true;
            this.rbtnFood.CheckedChanged += new System.EventHandler(this.Checked_Food);
            // 
            // rbtnDrink
            // 
            this.rbtnDrink.AutoSize = true;
            this.rbtnDrink.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDrink.ForeColor = System.Drawing.Color.Aqua;
            this.rbtnDrink.Location = new System.Drawing.Point(392, 74);
            this.rbtnDrink.Name = "rbtnDrink";
            this.rbtnDrink.Size = new System.Drawing.Size(115, 31);
            this.rbtnDrink.TabIndex = 25;
            this.rbtnDrink.Text = "Đồ uống";
            this.rbtnDrink.UseVisualStyleBackColor = true;
            this.rbtnDrink.CheckedChanged += new System.EventHandler(this.Checked_Food);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAll.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.ForeColor = System.Drawing.Color.Aqua;
            this.btnDeleteAll.Location = new System.Drawing.Point(880, 307);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(242, 69);
            this.btnDeleteAll.TabIndex = 26;
            this.btnDeleteAll.Text = "Xóa danh sách hiện có";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnDelete1
            // 
            this.btnDelete1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete1.ForeColor = System.Drawing.Color.Aqua;
            this.btnDelete1.Location = new System.Drawing.Point(880, 426);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(242, 69);
            this.btnDelete1.TabIndex = 27;
            this.btnDelete1.Text = "Xóa mục đã chọn";
            this.btnDelete1.UseVisualStyleBackColor = true;
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Aqua;
            this.btnAdd.Location = new System.Drawing.Point(880, 542);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(242, 69);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Thêm mới thực phẩm ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExport
            // 
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.Aqua;
            this.btnExport.Location = new System.Drawing.Point(880, 188);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(242, 69);
            this.btnExport.TabIndex = 29;
            this.btnExport.Text = "Xuất danh sách Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Aqua;
            this.button3.Location = new System.Drawing.Point(1125, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 40);
            this.button3.TabIndex = 108;
            this.button3.Text = "x";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // QLThucPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1182, 686);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete1);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.rbtnDrink);
            this.Controls.Add(this.rbtnFood);
            this.Controls.Add(this.rbtnAll);
            this.Controls.Add(this.dgvTHUCPHAM);
            this.Controls.Add(this.label7);
            this.Name = "QLThucPham";
            this.Text = "QLThucPham";
            this.Load += new System.EventHandler(this.QLThucPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTHUCPHAM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvTHUCPHAM;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.RadioButton rbtnFood;
        private System.Windows.Forms.RadioButton rbtnDrink;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnDelete1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button button3;
    }
}