namespace Car_Rental_System
{
    partial class Form4
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.label38 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.carRentalDataSet = new Car_Rental_System.CarRentalDataSet();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new Car_Rental_System.CarRentalDataSetTableAdapters.carTableAdapter();
            this.regNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button19 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.OrangeRed;
            this.panel4.Controls.Add(this.label40);
            this.panel4.Controls.Add(this.label39);
            this.panel4.Location = new System.Drawing.Point(4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1575, 125);
            this.panel4.TabIndex = 57;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label40.Location = new System.Drawing.Point(858, 64);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(212, 32);
            this.label40.TabIndex = 1;
            this.label40.Text = "MANAGE CAR";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label39.Location = new System.Drawing.Point(803, 16);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(331, 32);
            this.label39.TabIndex = 0;
            this.label39.Text = "CAR RENTAL SYSTEM";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.OrangeRed;
            this.label41.Location = new System.Drawing.Point(898, 148);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(119, 32);
            this.label41.TabIndex = 58;
            this.label41.Text = "Car List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regNoDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.availableDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(628, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(852, 512);
            this.dataGridView1.TabIndex = 59;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(421, 599);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(96, 52);
            this.button18.TabIndex = 79;
            this.button18.Text = "Delete";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(299, 599);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(96, 52);
            this.button17.TabIndex = 78;
            this.button17.Text = "Edit";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(164, 599);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(96, 52);
            this.button16.TabIndex = 77;
            this.button16.Text = "Add";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(191, 513);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(111, 29);
            this.label38.TabIndex = 76;
            this.label38.Text = "Available";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(317, 453);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(200, 29);
            this.textBox5.TabIndex = 75;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(191, 443);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(69, 29);
            this.label37.TabIndex = 74;
            this.label37.Text = "Price";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(191, 381);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(81, 29);
            this.label36.TabIndex = 73;
            this.label36.Text = "Model";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(191, 316);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(77, 29);
            this.label35.TabIndex = 72;
            this.label35.Text = "Brand";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(191, 246);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(90, 29);
            this.label34.TabIndex = 71;
            this.label34.Text = "RegNo";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(317, 381);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 29);
            this.textBox4.TabIndex = 70;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(317, 316);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 29);
            this.textBox3.TabIndex = 68;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(317, 246);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 29);
            this.textBox2.TabIndex = 67;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBox1.Location = new System.Drawing.Point(317, 513);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 69;
            // 
            // carRentalDataSet
            // 
            this.carRentalDataSet.DataSetName = "CarRentalDataSet";
            this.carRentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "car";
            this.carBindingSource.DataSource = this.carRentalDataSet;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // regNoDataGridViewTextBoxColumn
            // 
            this.regNoDataGridViewTextBoxColumn.DataPropertyName = "RegNo";
            this.regNoDataGridViewTextBoxColumn.HeaderText = "RegNo";
            this.regNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.regNoDataGridViewTextBoxColumn.Name = "regNoDataGridViewTextBoxColumn";
            this.regNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // availableDataGridViewTextBoxColumn
            // 
            this.availableDataGridViewTextBoxColumn.DataPropertyName = "Available";
            this.availableDataGridViewTextBoxColumn.HeaderText = "Available";
            this.availableDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.availableDataGridViewTextBoxColumn.Name = "availableDataGridViewTextBoxColumn";
            this.availableDataGridViewTextBoxColumn.Width = 125;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(299, 692);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(96, 52);
            this.button19.TabIndex = 80;
            this.button19.Text = "Back";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.panel4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private CarRentalDataSet carRentalDataSet;
        private System.Windows.Forms.BindingSource carBindingSource;
        private CarRentalDataSetTableAdapters.carTableAdapter carTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn regNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button19;
    }
}