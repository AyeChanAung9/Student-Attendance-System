namespace StudentAttendanceSystem.User_Control
{
    partial class UserControlStudentInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlStudentInfo));
            this.comboBoxSNameSearch = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelScount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewSinfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSIDSearch = new System.Windows.Forms.ComboBox();
            this.comboBoxSYearSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rjButton1 = new StudentAttendanceSystem.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSNameSearch
            // 
            this.comboBoxSNameSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.comboBoxSNameSearch.FormattingEnabled = true;
            this.comboBoxSNameSearch.Items.AddRange(new object[] {
            "Class",
            "Teacher",
            "Time"});
            this.comboBoxSNameSearch.Location = new System.Drawing.Point(502, 64);
            this.comboBoxSNameSearch.Name = "comboBoxSNameSearch";
            this.comboBoxSNameSearch.Size = new System.Drawing.Size(278, 37);
            this.comboBoxSNameSearch.TabIndex = 22;
            this.comboBoxSNameSearch.TextChanged += new System.EventHandler(this.comboBoxSNameSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label5.Location = new System.Drawing.Point(390, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Name :";
            // 
            // labelScount
            // 
            this.labelScount.AutoSize = true;
            this.labelScount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.labelScount.Location = new System.Drawing.Point(600, 632);
            this.labelScount.Name = "labelScount";
            this.labelScount.Size = new System.Drawing.Size(46, 29);
            this.labelScount.TabIndex = 20;
            this.labelScount.Text = "{?}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label4.Location = new System.Drawing.Point(347, 632);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Total Students :";
            // 
            // dataGridViewSinfo
            // 
            this.dataGridViewSinfo.AllowUserToAddRows = false;
            this.dataGridViewSinfo.AllowUserToDeleteRows = false;
            this.dataGridViewSinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSinfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSinfo.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSinfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSinfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewSinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewSinfo.Location = new System.Drawing.Point(10, 125);
            this.dataGridViewSinfo.Name = "dataGridViewSinfo";
            this.dataGridViewSinfo.ReadOnly = true;
            this.dataGridViewSinfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewSinfo.RowHeadersWidth = 51;
            this.dataGridViewSinfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSinfo.ShowCellErrors = false;
            this.dataGridViewSinfo.ShowEditingIcon = false;
            this.dataGridViewSinfo.ShowRowErrors = false;
            this.dataGridViewSinfo.Size = new System.Drawing.Size(1209, 470);
            this.dataGridViewSinfo.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "student_id";
            this.Column1.HeaderText = "Student ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 159;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sname";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 107;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sDOB";
            this.Column3.HeaderText = "Date Of Birth";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 187;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "sFname";
            this.Column4.HeaderText = "Father Name";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 189;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "sContactinfo";
            this.Column5.HeaderText = "Contact Info";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 176;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "sYear";
            this.Column6.HeaderText = "Year";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 93;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label3.Location = new System.Drawing.Point(21, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Search Student Info:";
            // 
            // comboBoxSIDSearch
            // 
            this.comboBoxSIDSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.comboBoxSIDSearch.FormattingEnabled = true;
            this.comboBoxSIDSearch.Items.AddRange(new object[] {
            "Class",
            "Teacher",
            "Time"});
            this.comboBoxSIDSearch.Location = new System.Drawing.Point(85, 64);
            this.comboBoxSIDSearch.Name = "comboBoxSIDSearch";
            this.comboBoxSIDSearch.Size = new System.Drawing.Size(278, 37);
            this.comboBoxSIDSearch.TabIndex = 23;
            this.comboBoxSIDSearch.TextChanged += new System.EventHandler(this.comboBoxSIDSearch_TextChanged);
            // 
            // comboBoxSYearSearch
            // 
            this.comboBoxSYearSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.comboBoxSYearSearch.FormattingEnabled = true;
            this.comboBoxSYearSearch.Location = new System.Drawing.Point(883, 64);
            this.comboBoxSYearSearch.Name = "comboBoxSYearSearch";
            this.comboBoxSYearSearch.Size = new System.Drawing.Size(278, 37);
            this.comboBoxSYearSearch.TabIndex = 25;
            this.comboBoxSYearSearch.TextChanged += new System.EventHandler(this.comboBoxSYearSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label1.Location = new System.Drawing.Point(799, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Year :";
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Transparent;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 8;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Image = ((System.Drawing.Image)(resources.GetObject("rjButton1.Image")));
            this.rjButton1.Location = new System.Drawing.Point(1170, 61);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(55, 44);
            this.rjButton1.TabIndex = 17;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // UserControlStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.comboBoxSYearSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSIDSearch);
            this.Controls.Add(this.comboBoxSNameSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelScount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewSinfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rjButton1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "UserControlStudentInfo";
            this.Size = new System.Drawing.Size(1235, 683);
            this.Load += new System.EventHandler(this.UserControlStudentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSNameSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelScount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewSinfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private RJButton rjButton1;
        private System.Windows.Forms.ComboBox comboBoxSIDSearch;
        private System.Windows.Forms.ComboBox comboBoxSYearSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
