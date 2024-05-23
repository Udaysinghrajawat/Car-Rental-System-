namespace Car_Rental_System
{
    partial class Form6
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carRegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carRentalDataSet2 = new Car_Rental_System.CarRentalDataSet2();
            this.label11 = new System.Windows.Forms.Label();
            this.rentalTableAdapter = new Car_Rental_System.CarRentalDataSet2TableAdapters.RentalTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 109);
            this.panel1.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1343, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(627, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rental";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Fluent Icons", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(562, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "CAR RENTAL SYSTEM";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(265, 337);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 24);
            this.comboBox2.TabIndex = 128;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(265, 276);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 127;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(265, 456);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(226, 22);
            this.dateTimePicker2.TabIndex = 126;
            this.dateTimePicker2.Value = new System.DateTime(2024, 1, 15, 19, 27, 44, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(265, 509);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(226, 22);
            this.dateTimePicker1.TabIndex = 125;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(265, 560);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(200, 29);
            this.textBox5.TabIndex = 124;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(270, 395);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 29);
            this.textBox4.TabIndex = 123;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.OrangeRed;
            this.label10.Location = new System.Drawing.Point(124, 560);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 29);
            this.label10.TabIndex = 122;
            this.label10.Text = "Fees";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.OrangeRed;
            this.label9.Location = new System.Drawing.Point(90, 502);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 29);
            this.label9.TabIndex = 121;
            this.label9.Text = "Return Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.OrangeRed;
            this.label8.Location = new System.Drawing.Point(92, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 29);
            this.label8.TabIndex = 120;
            this.label8.Text = "Rental Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(124, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 29);
            this.label6.TabIndex = 119;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(122, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 29);
            this.label7.TabIndex = 118;
            this.label7.Text = "CustID";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(265, 214);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 29);
            this.textBox1.TabIndex = 117;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(158, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 29);
            this.label4.TabIndex = 116;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(122, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 29);
            this.label5.TabIndex = 115;
            this.label5.Text = "CarReg";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.OrangeRed;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(376, 640);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 37);
            this.button4.TabIndex = 114;
            this.button4.Text = "DELETE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(163, 640);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 37);
            this.button3.TabIndex = 113;
            this.button3.Text = "ADD";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(270, 640);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 37);
            this.button1.TabIndex = 111;
            this.button1.Text = "EDIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(270, 696);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 37);
            this.button2.TabIndex = 112;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentIdDataGridViewTextBoxColumn,
            this.carRegDataGridViewTextBoxColumn,
            this.custIdDataGridViewTextBoxColumn,
            this.custNameDataGridViewTextBoxColumn,
            this.rentDateDataGridViewTextBoxColumn,
            this.returnDateDataGridViewTextBoxColumn,
            this.feesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rentalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(595, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(995, 443);
            this.dataGridView1.TabIndex = 130;
            // 
            // rentIdDataGridViewTextBoxColumn
            // 
            this.rentIdDataGridViewTextBoxColumn.DataPropertyName = "RentId";
            this.rentIdDataGridViewTextBoxColumn.HeaderText = "RentId";
            this.rentIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rentIdDataGridViewTextBoxColumn.Name = "rentIdDataGridViewTextBoxColumn";
            this.rentIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // carRegDataGridViewTextBoxColumn
            // 
            this.carRegDataGridViewTextBoxColumn.DataPropertyName = "CarReg";
            this.carRegDataGridViewTextBoxColumn.HeaderText = "CarReg";
            this.carRegDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carRegDataGridViewTextBoxColumn.Name = "carRegDataGridViewTextBoxColumn";
            this.carRegDataGridViewTextBoxColumn.Width = 125;
            // 
            // custIdDataGridViewTextBoxColumn
            // 
            this.custIdDataGridViewTextBoxColumn.DataPropertyName = "CustId";
            this.custIdDataGridViewTextBoxColumn.HeaderText = "CustId";
            this.custIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custIdDataGridViewTextBoxColumn.Name = "custIdDataGridViewTextBoxColumn";
            this.custIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // custNameDataGridViewTextBoxColumn
            // 
            this.custNameDataGridViewTextBoxColumn.DataPropertyName = "CustName";
            this.custNameDataGridViewTextBoxColumn.HeaderText = "CustName";
            this.custNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custNameDataGridViewTextBoxColumn.Name = "custNameDataGridViewTextBoxColumn";
            this.custNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // rentDateDataGridViewTextBoxColumn
            // 
            this.rentDateDataGridViewTextBoxColumn.DataPropertyName = "RentDate";
            this.rentDateDataGridViewTextBoxColumn.HeaderText = "RentDate";
            this.rentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rentDateDataGridViewTextBoxColumn.Name = "rentDateDataGridViewTextBoxColumn";
            this.rentDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // returnDateDataGridViewTextBoxColumn
            // 
            this.returnDateDataGridViewTextBoxColumn.DataPropertyName = "ReturnDate";
            this.returnDateDataGridViewTextBoxColumn.HeaderText = "ReturnDate";
            this.returnDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
            this.returnDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // feesDataGridViewTextBoxColumn
            // 
            this.feesDataGridViewTextBoxColumn.DataPropertyName = "Fees";
            this.feesDataGridViewTextBoxColumn.HeaderText = "Fees";
            this.feesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.feesDataGridViewTextBoxColumn.Name = "feesDataGridViewTextBoxColumn";
            this.feesDataGridViewTextBoxColumn.Width = 125;
            // 
            // rentalBindingSource
            // 
            this.rentalBindingSource.DataMember = "Rental";
            this.rentalBindingSource.DataSource = this.carRentalDataSet2;
            // 
            // carRentalDataSet2
            // 
            this.carRentalDataSet2.DataSetName = "CarRentalDataSet2";
            this.carRentalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.OrangeRed;
            this.label11.Location = new System.Drawing.Point(944, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 32);
            this.label11.TabIndex = 129;
            this.label11.Text = "Cars on Rent";
            // 
            // rentalTableAdapter
            // 
            this.rentalTableAdapter.ClearBeforeFill = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private CarRentalDataSet2 carRentalDataSet2;
        private System.Windows.Forms.BindingSource rentalBindingSource;
        private CarRentalDataSet2TableAdapters.RentalTableAdapter rentalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carRegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feesDataGridViewTextBoxColumn;
    }
}