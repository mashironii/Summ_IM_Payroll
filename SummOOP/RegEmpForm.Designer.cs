namespace SummOOP
{
    partial class RegEmpForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableEmployeeIntBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dTRDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dTRDataSet4 = new SummOOP.DTRDataSet4();
            this.tableEmployeeIntBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.table_EmployeeIntTableAdapter2 = new SummOOP.DTRDataSet4TableAdapters.table_EmployeeIntTableAdapter();
            this.dTRDataSet = new SummOOP.DTRDataSet();
            this.dTRDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableEmployeeIntBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.table_EmployeeIntTableAdapter = new SummOOP.DTRDataSetTableAdapters.table_EmployeeIntTableAdapter();
            this.eMPLOYEEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lASTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRSTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localDTRDataSet = new SummOOP.LocalDTRDataSet();
            this.tableEmployeeIntBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.table_EmployeeIntTableAdapter1 = new SummOOP.LocalDTRDataSetTableAdapters.table_EmployeeIntTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableEmployeeIntBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTRDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTRDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableEmployeeIntBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTRDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableEmployeeIntBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDTRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableEmployeeIntBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMPLOYEE INFORMATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 176);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(285, 49);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(12, 267);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(285, 49);
            this.textBox3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "First Name:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(122, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eMPLOYEEIDDataGridViewTextBoxColumn,
            this.lASTNAMEDataGridViewTextBoxColumn,
            this.fIRSTNAMEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableEmployeeIntBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(325, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(469, 357);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tableEmployeeIntBindingSource1
            // 
            this.tableEmployeeIntBindingSource1.DataMember = "table_EmployeeInt";
            this.tableEmployeeIntBindingSource1.DataSource = this.dTRDataSet4BindingSource;
            // 
            // dTRDataSet4BindingSource
            // 
            this.dTRDataSet4BindingSource.DataSource = this.dTRDataSet4;
            this.dTRDataSet4BindingSource.Position = 0;
            // 
            // dTRDataSet4
            // 
            this.dTRDataSet4.DataSetName = "DTRDataSet4";
            this.dTRDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(25, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 38);
            this.button2.TabIndex = 9;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 61);
            this.label5.TabIndex = 10;
            this.label5.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // table_EmployeeIntTableAdapter2
            // 
            this.table_EmployeeIntTableAdapter2.ClearBeforeFill = true;
            // 
            // dTRDataSet
            // 
            this.dTRDataSet.DataSetName = "DTRDataSet";
            this.dTRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTRDataSetBindingSource
            // 
            this.dTRDataSetBindingSource.DataSource = this.dTRDataSet;
            this.dTRDataSetBindingSource.Position = 0;
            // 
            // tableEmployeeIntBindingSource2
            // 
            this.tableEmployeeIntBindingSource2.DataMember = "table_EmployeeInt";
            this.tableEmployeeIntBindingSource2.DataSource = this.dTRDataSetBindingSource;
            // 
            // table_EmployeeIntTableAdapter
            // 
            this.table_EmployeeIntTableAdapter.ClearBeforeFill = true;
            // 
            // eMPLOYEEIDDataGridViewTextBoxColumn
            // 
            this.eMPLOYEEIDDataGridViewTextBoxColumn.DataPropertyName = "EMPLOYEE ID";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.HeaderText = "EMPLOYEE ID";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.Name = "eMPLOYEEIDDataGridViewTextBoxColumn";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lASTNAMEDataGridViewTextBoxColumn
            // 
            this.lASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LAST NAME";
            this.lASTNAMEDataGridViewTextBoxColumn.HeaderText = "LAST NAME";
            this.lASTNAMEDataGridViewTextBoxColumn.Name = "lASTNAMEDataGridViewTextBoxColumn";
            this.lASTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.lASTNAMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // fIRSTNAMEDataGridViewTextBoxColumn
            // 
            this.fIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRST NAME";
            this.fIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRST NAME";
            this.fIRSTNAMEDataGridViewTextBoxColumn.Name = "fIRSTNAMEDataGridViewTextBoxColumn";
            this.fIRSTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.fIRSTNAMEDataGridViewTextBoxColumn.Width = 175;
            // 
            // localDTRDataSet
            // 
            this.localDTRDataSet.DataSetName = "LocalDTRDataSet";
            this.localDTRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableEmployeeIntBindingSource3
            // 
            this.tableEmployeeIntBindingSource3.DataMember = "table_EmployeeInt";
            this.tableEmployeeIntBindingSource3.DataSource = this.localDTRDataSet;
            // 
            // table_EmployeeIntTableAdapter1
            // 
            this.table_EmployeeIntTableAdapter1.ClearBeforeFill = true;
            // 
            // RegEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegEmpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.RegEmpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableEmployeeIntBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTRDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTRDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableEmployeeIntBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTRDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableEmployeeIntBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDTRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableEmployeeIntBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource tableEmployeeIntBindingSource;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource dTRDataSet4BindingSource;
        private DTRDataSet4 dTRDataSet4;
        private System.Windows.Forms.BindingSource tableEmployeeIntBindingSource1;
        private DTRDataSet4TableAdapters.table_EmployeeIntTableAdapter table_EmployeeIntTableAdapter2;
        private System.Windows.Forms.BindingSource dTRDataSetBindingSource;
        private DTRDataSet dTRDataSet;
        private System.Windows.Forms.BindingSource tableEmployeeIntBindingSource2;
        private DTRDataSetTableAdapters.table_EmployeeIntTableAdapter table_EmployeeIntTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lASTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRSTNAMEDataGridViewTextBoxColumn;
        private LocalDTRDataSet localDTRDataSet;
        private System.Windows.Forms.BindingSource tableEmployeeIntBindingSource3;
        private LocalDTRDataSetTableAdapters.table_EmployeeIntTableAdapter table_EmployeeIntTableAdapter1;
    }
}