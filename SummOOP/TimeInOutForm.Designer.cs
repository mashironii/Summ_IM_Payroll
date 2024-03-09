namespace SummOOP
{
    partial class TimeInOutForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eMPLOYEEIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOGDATEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIMEINDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMisLoggedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIMEOUTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMisLoggedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALHOURSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALOVERTIMEHOURSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableAttendanceBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.dTRDataSet4 = new SummOOP.DTRDataSet4();
            this.tableAttendanceBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAttendanceBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAttendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableAttendanceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAttendanceBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOGDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIMEINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMisLoggedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIMEOUTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMisLoggedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_AttendanceTableAdapter3 = new SummOOP.DTRDataSet4TableAdapters.table_AttendanceTableAdapter();
            this.localDTRDataSet = new SummOOP.LocalDTRDataSet();
            this.tableAttendanceBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.table_AttendanceTableAdapter = new SummOOP.LocalDTRDataSetTableAdapters.table_AttendanceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAttendanceBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTRDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAttendanceBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAttendanceBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAttendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAttendanceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAttendanceBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDTRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAttendanceBindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee ID:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(21, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 49);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eMPLOYEEIDDataGridViewTextBoxColumn1,
            this.lOGDATEDataGridViewTextBoxColumn1,
            this.tIMEINDataGridViewTextBoxColumn1,
            this.aMisLoggedDataGridViewTextBoxColumn1,
            this.tIMEOUTDataGridViewTextBoxColumn1,
            this.pMisLoggedDataGridViewTextBoxColumn1,
            this.tOTALHOURSDataGridViewTextBoxColumn,
            this.tOTALOVERTIMEHOURSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableAttendanceBindingSource5;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(37, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(791, 298);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // eMPLOYEEIDDataGridViewTextBoxColumn1
            // 
            this.eMPLOYEEIDDataGridViewTextBoxColumn1.DataPropertyName = "EMPLOYEE ID";
            this.eMPLOYEEIDDataGridViewTextBoxColumn1.HeaderText = "EMPLOYEE ID";
            this.eMPLOYEEIDDataGridViewTextBoxColumn1.Name = "eMPLOYEEIDDataGridViewTextBoxColumn1";
            this.eMPLOYEEIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.eMPLOYEEIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // lOGDATEDataGridViewTextBoxColumn1
            // 
            this.lOGDATEDataGridViewTextBoxColumn1.DataPropertyName = "LOG DATE";
            this.lOGDATEDataGridViewTextBoxColumn1.HeaderText = "LOG DATE";
            this.lOGDATEDataGridViewTextBoxColumn1.Name = "lOGDATEDataGridViewTextBoxColumn1";
            this.lOGDATEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lOGDATEDataGridViewTextBoxColumn1.Width = 125;
            // 
            // tIMEINDataGridViewTextBoxColumn1
            // 
            this.tIMEINDataGridViewTextBoxColumn1.DataPropertyName = "TIME IN";
            this.tIMEINDataGridViewTextBoxColumn1.HeaderText = "TIME IN";
            this.tIMEINDataGridViewTextBoxColumn1.Name = "tIMEINDataGridViewTextBoxColumn1";
            this.tIMEINDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tIMEINDataGridViewTextBoxColumn1.Width = 125;
            // 
            // aMisLoggedDataGridViewTextBoxColumn1
            // 
            this.aMisLoggedDataGridViewTextBoxColumn1.DataPropertyName = "AM_isLogged";
            this.aMisLoggedDataGridViewTextBoxColumn1.HeaderText = "AM_isLogged";
            this.aMisLoggedDataGridViewTextBoxColumn1.Name = "aMisLoggedDataGridViewTextBoxColumn1";
            this.aMisLoggedDataGridViewTextBoxColumn1.ReadOnly = true;
            this.aMisLoggedDataGridViewTextBoxColumn1.Width = 125;
            // 
            // tIMEOUTDataGridViewTextBoxColumn1
            // 
            this.tIMEOUTDataGridViewTextBoxColumn1.DataPropertyName = "TIME OUT";
            this.tIMEOUTDataGridViewTextBoxColumn1.HeaderText = "TIME OUT";
            this.tIMEOUTDataGridViewTextBoxColumn1.Name = "tIMEOUTDataGridViewTextBoxColumn1";
            this.tIMEOUTDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tIMEOUTDataGridViewTextBoxColumn1.Width = 125;
            // 
            // pMisLoggedDataGridViewTextBoxColumn1
            // 
            this.pMisLoggedDataGridViewTextBoxColumn1.DataPropertyName = "PM_isLogged";
            this.pMisLoggedDataGridViewTextBoxColumn1.HeaderText = "PM_isLogged";
            this.pMisLoggedDataGridViewTextBoxColumn1.Name = "pMisLoggedDataGridViewTextBoxColumn1";
            this.pMisLoggedDataGridViewTextBoxColumn1.ReadOnly = true;
            this.pMisLoggedDataGridViewTextBoxColumn1.Width = 125;
            // 
            // tOTALHOURSDataGridViewTextBoxColumn
            // 
            this.tOTALHOURSDataGridViewTextBoxColumn.DataPropertyName = "TOTAL HOURS";
            this.tOTALHOURSDataGridViewTextBoxColumn.HeaderText = "TOTAL HOURS";
            this.tOTALHOURSDataGridViewTextBoxColumn.Name = "tOTALHOURSDataGridViewTextBoxColumn";
            this.tOTALHOURSDataGridViewTextBoxColumn.ReadOnly = true;
            this.tOTALHOURSDataGridViewTextBoxColumn.Visible = false;
            // 
            // tOTALOVERTIMEHOURSDataGridViewTextBoxColumn
            // 
            this.tOTALOVERTIMEHOURSDataGridViewTextBoxColumn.DataPropertyName = "TOTAL OVERTIME HOURS";
            this.tOTALOVERTIMEHOURSDataGridViewTextBoxColumn.HeaderText = "TOTAL OVERTIME HOURS";
            this.tOTALOVERTIMEHOURSDataGridViewTextBoxColumn.Name = "tOTALOVERTIMEHOURSDataGridViewTextBoxColumn";
            this.tOTALOVERTIMEHOURSDataGridViewTextBoxColumn.ReadOnly = true;
            this.tOTALOVERTIMEHOURSDataGridViewTextBoxColumn.Visible = false;
            // 
            // tableAttendanceBindingSource5
            // 
            this.tableAttendanceBindingSource5.DataMember = "table_Attendance";
            this.tableAttendanceBindingSource5.DataSource = this.dTRDataSet4;
            // 
            // dTRDataSet4
            // 
            this.dTRDataSet4.DataSetName = "DTRDataSet4";
            this.dTRDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(330, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(498, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Franklin Gothic Demi", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(655, 25);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(184, 37);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Employee ID:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(640, 62);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(201, 43);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "Employee ID:";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // eMPLOYEEIDDataGridViewTextBoxColumn
            // 
            this.eMPLOYEEIDDataGridViewTextBoxColumn.DataPropertyName = "EMPLOYEE ID";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.HeaderText = "EMPLOYEE ID";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.Name = "eMPLOYEEIDDataGridViewTextBoxColumn";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.Width = 115;
            // 
            // lOGDATEDataGridViewTextBoxColumn
            // 
            this.lOGDATEDataGridViewTextBoxColumn.DataPropertyName = "LOG DATE";
            this.lOGDATEDataGridViewTextBoxColumn.HeaderText = "LOG DATE";
            this.lOGDATEDataGridViewTextBoxColumn.Name = "lOGDATEDataGridViewTextBoxColumn";
            this.lOGDATEDataGridViewTextBoxColumn.Width = 115;
            // 
            // tIMEINDataGridViewTextBoxColumn
            // 
            this.tIMEINDataGridViewTextBoxColumn.DataPropertyName = "TIME IN";
            this.tIMEINDataGridViewTextBoxColumn.HeaderText = "TIME IN";
            this.tIMEINDataGridViewTextBoxColumn.Name = "tIMEINDataGridViewTextBoxColumn";
            this.tIMEINDataGridViewTextBoxColumn.Width = 115;
            // 
            // aMisLoggedDataGridViewTextBoxColumn
            // 
            this.aMisLoggedDataGridViewTextBoxColumn.DataPropertyName = "AM_isLogged";
            this.aMisLoggedDataGridViewTextBoxColumn.HeaderText = "AM_isLogged";
            this.aMisLoggedDataGridViewTextBoxColumn.Name = "aMisLoggedDataGridViewTextBoxColumn";
            this.aMisLoggedDataGridViewTextBoxColumn.Width = 115;
            // 
            // tIMEOUTDataGridViewTextBoxColumn
            // 
            this.tIMEOUTDataGridViewTextBoxColumn.DataPropertyName = "TIME OUT";
            this.tIMEOUTDataGridViewTextBoxColumn.HeaderText = "TIME OUT";
            this.tIMEOUTDataGridViewTextBoxColumn.Name = "tIMEOUTDataGridViewTextBoxColumn";
            this.tIMEOUTDataGridViewTextBoxColumn.Width = 115;
            // 
            // pMisLoggedDataGridViewTextBoxColumn
            // 
            this.pMisLoggedDataGridViewTextBoxColumn.DataPropertyName = "PM_isLogged";
            this.pMisLoggedDataGridViewTextBoxColumn.HeaderText = "PM_isLogged";
            this.pMisLoggedDataGridViewTextBoxColumn.Name = "pMisLoggedDataGridViewTextBoxColumn";
            this.pMisLoggedDataGridViewTextBoxColumn.Width = 115;
            // 
            // table_AttendanceTableAdapter3
            // 
            this.table_AttendanceTableAdapter3.ClearBeforeFill = true;
            // 
            // localDTRDataSet
            // 
            this.localDTRDataSet.DataSetName = "LocalDTRDataSet";
            this.localDTRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAttendanceBindingSource6
            // 
            this.tableAttendanceBindingSource6.DataMember = "table_Attendance";
            this.tableAttendanceBindingSource6.DataSource = this.localDTRDataSet;
            // 
            // table_AttendanceTableAdapter
            // 
            this.table_AttendanceTableAdapter.ClearBeforeFill = true;
            // 
            // TimeInOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TimeInOutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Time In / Out";
            this.Load += new System.EventHandler(this.TimeInOutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAttendanceBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTRDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAttendanceBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAttendanceBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAttendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAttendanceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAttendanceBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDTRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAttendanceBindingSource6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource tableAttendanceBindingSource;
        private System.Windows.Forms.BindingSource tableAttendanceBindingSource1;
        private System.Windows.Forms.BindingSource tableAttendanceBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOGDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIMEINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMisLoggedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIMEOUTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pMisLoggedDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tableAttendanceBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEEIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOGDATEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIMEINDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMisLoggedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIMEOUTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pMisLoggedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALHOURSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALOVERTIMEHOURSDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tableAttendanceBindingSource4;
        private DTRDataSet4 dTRDataSet4;
        private System.Windows.Forms.BindingSource tableAttendanceBindingSource5;
        private DTRDataSet4TableAdapters.table_AttendanceTableAdapter table_AttendanceTableAdapter3;
        private LocalDTRDataSet localDTRDataSet;
        private System.Windows.Forms.BindingSource tableAttendanceBindingSource6;
        private LocalDTRDataSetTableAdapters.table_AttendanceTableAdapter table_AttendanceTableAdapter;
    }
}