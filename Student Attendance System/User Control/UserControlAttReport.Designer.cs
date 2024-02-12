namespace StudentAttendanceSystem.User_Control
{
    partial class UserControlAttReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlAttReport));
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewAttR = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxAttClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAttDate = new System.Windows.Forms.ComboBox();
            this.comboBoxAttName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPresent = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblabsent = new System.Windows.Forms.Label();
            this.btnAttSearch = new StudentAttendanceSystem.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttR)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(461, 39);
            this.label2.TabIndex = 26;
            this.label2.Text = "Attendance Report Search :";
            // 
            // dataGridViewAttR
            // 
            this.dataGridViewAttR.AllowUserToAddRows = false;
            this.dataGridViewAttR.AllowUserToDeleteRows = false;
            this.dataGridViewAttR.AllowUserToResizeColumns = false;
            this.dataGridViewAttR.AllowUserToResizeRows = false;
            this.dataGridViewAttR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAttR.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewAttR.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAttR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAttR.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewAttR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewAttR.Location = new System.Drawing.Point(10, 147);
            this.dataGridViewAttR.Name = "dataGridViewAttR";
            this.dataGridViewAttR.ReadOnly = true;
            this.dataGridViewAttR.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewAttR.RowHeadersWidth = 51;
            this.dataGridViewAttR.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewAttR.ShowCellErrors = false;
            this.dataGridViewAttR.ShowEditingIcon = false;
            this.dataGridViewAttR.ShowRowErrors = false;
            this.dataGridViewAttR.Size = new System.Drawing.Size(1228, 476);
            this.dataGridViewAttR.TabIndex = 27;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "aid";
            this.Column1.HeaderText = "StudentID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "aname";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "aclass";
            this.Column3.HeaderText = "Class";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "atime";
            this.Column4.HeaderText = "Time";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "adate";
            this.Column5.HeaderText = "Date";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // comboBoxAttClass
            // 
            this.comboBoxAttClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.comboBoxAttClass.FormattingEnabled = true;
            this.comboBoxAttClass.Location = new System.Drawing.Point(900, 76);
            this.comboBoxAttClass.Name = "comboBoxAttClass";
            this.comboBoxAttClass.Size = new System.Drawing.Size(260, 44);
            this.comboBoxAttClass.TabIndex = 33;
            this.comboBoxAttClass.TextChanged += new System.EventHandler(this.comboBoxAttClass_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label1.Location = new System.Drawing.Point(794, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 36);
            this.label1.TabIndex = 32;
            this.label1.Text = "Class :";
            // 
            // comboBoxAttDate
            // 
            this.comboBoxAttDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.comboBoxAttDate.FormattingEnabled = true;
            this.comboBoxAttDate.Location = new System.Drawing.Point(139, 76);
            this.comboBoxAttDate.Name = "comboBoxAttDate";
            this.comboBoxAttDate.Size = new System.Drawing.Size(260, 44);
            this.comboBoxAttDate.TabIndex = 31;
            this.comboBoxAttDate.TextChanged += new System.EventHandler(this.comboBoxAttDate_TextChanged);
            // 
            // comboBoxAttName
            // 
            this.comboBoxAttName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.comboBoxAttName.FormattingEnabled = true;
            this.comboBoxAttName.Location = new System.Drawing.Point(524, 76);
            this.comboBoxAttName.Name = "comboBoxAttName";
            this.comboBoxAttName.Size = new System.Drawing.Size(260, 44);
            this.comboBoxAttName.TabIndex = 30;
            this.comboBoxAttName.TextChanged += new System.EventHandler(this.comboBoxAttName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label5.Location = new System.Drawing.Point(416, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 36);
            this.label5.TabIndex = 29;
            this.label5.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label3.Location = new System.Drawing.Point(43, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 36);
            this.label3.TabIndex = 28;
            this.label3.Text = "Date :";
            // 
            // lblPresent
            // 
            this.lblPresent.AutoSize = true;
            this.lblPresent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.lblPresent.Location = new System.Drawing.Point(793, 653);
            this.lblPresent.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPresent.Name = "lblPresent";
            this.lblPresent.Size = new System.Drawing.Size(55, 36);
            this.lblPresent.TabIndex = 34;
            this.lblPresent.Text = "{?}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label4.Location = new System.Drawing.Point(529, 653);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 36);
            this.label4.TabIndex = 36;
            this.label4.Text = "Current Present :";
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.lblList.Location = new System.Drawing.Point(388, 653);
            this.lblList.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(33, 36);
            this.lblList.TabIndex = 37;
            this.lblList.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label6.Location = new System.Drawing.Point(34, 653);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(346, 36);
            this.label6.TabIndex = 38;
            this.label6.Text = "Total Student in Class :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label7.Location = new System.Drawing.Point(992, 653);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 36);
            this.label7.TabIndex = 39;
            this.label7.Text = "Absent :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label8.Location = new System.Drawing.Point(794, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(452, 29);
            this.label8.TabIndex = 40;
            this.label8.Text = "Please Search with Detailed Information !";
            // 
            // lblabsent
            // 
            this.lblabsent.AutoSize = true;
            this.lblabsent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.lblabsent.Location = new System.Drawing.Point(1133, 653);
            this.lblabsent.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblabsent.Name = "lblabsent";
            this.lblabsent.Size = new System.Drawing.Size(33, 36);
            this.lblabsent.TabIndex = 41;
            this.lblabsent.Text = "0";
            // 
            // btnAttSearch
            // 
            this.btnAttSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnAttSearch.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAttSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAttSearch.BorderRadius = 8;
            this.btnAttSearch.BorderSize = 0;
            this.btnAttSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttSearch.FlatAppearance.BorderSize = 0;
            this.btnAttSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttSearch.ForeColor = System.Drawing.Color.White;
            this.btnAttSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnAttSearch.Image")));
            this.btnAttSearch.Location = new System.Drawing.Point(1168, 67);
            this.btnAttSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnAttSearch.Name = "btnAttSearch";
            this.btnAttSearch.Size = new System.Drawing.Size(70, 61);
            this.btnAttSearch.TabIndex = 35;
            this.btnAttSearch.TextColor = System.Drawing.Color.White;
            this.btnAttSearch.UseVisualStyleBackColor = false;
            this.btnAttSearch.Click += new System.EventHandler(this.btnAttSearch_Click);
            // 
            // UserControlAttReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblabsent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAttSearch);
            this.Controls.Add(this.lblPresent);
            this.Controls.Add(this.comboBoxAttClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxAttDate);
            this.Controls.Add(this.comboBoxAttName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewAttR);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "UserControlAttReport";
            this.Size = new System.Drawing.Size(1256, 694);
            this.Load += new System.EventHandler(this.UserControlAttReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewAttR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox comboBoxAttClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAttDate;
        private System.Windows.Forms.ComboBox comboBoxAttName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPresent;
        private RJButton btnAttSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblabsent;
    }
}
