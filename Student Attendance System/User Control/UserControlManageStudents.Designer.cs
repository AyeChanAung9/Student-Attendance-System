namespace StudentAttendanceSystem.User_Control
{
    partial class UserControlManageStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlManageStudents));
            this.UpdcboxSYearSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdcboxSIDSearch = new System.Windows.Forms.ComboBox();
            this.UpdcboxSNameSearch = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UpdlabelScount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewSinfoUpd = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.UpdtxtSid = new System.Windows.Forms.TextBox();
            this.UpdtxtSConInfo = new System.Windows.Forms.TextBox();
            this.UpdtxtSYear = new System.Windows.Forms.TextBox();
            this.UpdtxtSFname = new System.Windows.Forms.TextBox();
            this.UpdtxtSname = new System.Windows.Forms.TextBox();
            this.bthSDelete = new StudentAttendanceSystem.RJButton();
            this.btnSupdate = new StudentAttendanceSystem.RJButton();
            this.rjButton1 = new StudentAttendanceSystem.RJButton();
            this.UpdtxtSDOB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinfoUpd)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdcboxSYearSearch
            // 
            this.UpdcboxSYearSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.UpdcboxSYearSearch.FormattingEnabled = true;
            this.UpdcboxSYearSearch.Location = new System.Drawing.Point(903, 53);
            this.UpdcboxSYearSearch.Name = "UpdcboxSYearSearch";
            this.UpdcboxSYearSearch.Size = new System.Drawing.Size(260, 37);
            this.UpdcboxSYearSearch.TabIndex = 35;
            this.UpdcboxSYearSearch.TextChanged += new System.EventHandler(this.UpdcboxSYearSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label1.Location = new System.Drawing.Point(804, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "Year :";
            // 
            // UpdcboxSIDSearch
            // 
            this.UpdcboxSIDSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.UpdcboxSIDSearch.FormattingEnabled = true;
            this.UpdcboxSIDSearch.Items.AddRange(new object[] {
            "Class",
            "Teacher",
            "Time"});
            this.UpdcboxSIDSearch.Location = new System.Drawing.Point(130, 53);
            this.UpdcboxSIDSearch.Name = "UpdcboxSIDSearch";
            this.UpdcboxSIDSearch.Size = new System.Drawing.Size(260, 37);
            this.UpdcboxSIDSearch.TabIndex = 33;
            this.UpdcboxSIDSearch.TextChanged += new System.EventHandler(this.UpdcboxSIDSearch_TextChanged);
            // 
            // UpdcboxSNameSearch
            // 
            this.UpdcboxSNameSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.UpdcboxSNameSearch.FormattingEnabled = true;
            this.UpdcboxSNameSearch.Items.AddRange(new object[] {
            "Class",
            "Teacher",
            "Time"});
            this.UpdcboxSNameSearch.Location = new System.Drawing.Point(523, 53);
            this.UpdcboxSNameSearch.Name = "UpdcboxSNameSearch";
            this.UpdcboxSNameSearch.Size = new System.Drawing.Size(260, 37);
            this.UpdcboxSNameSearch.TabIndex = 32;
            this.UpdcboxSNameSearch.TextChanged += new System.EventHandler(this.UpdcboxSNameSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label5.Location = new System.Drawing.Point(409, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 29);
            this.label5.TabIndex = 31;
            this.label5.Text = "Name :";
            // 
            // UpdlabelScount
            // 
            this.UpdlabelScount.AutoSize = true;
            this.UpdlabelScount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdlabelScount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.UpdlabelScount.Location = new System.Drawing.Point(563, 648);
            this.UpdlabelScount.Name = "UpdlabelScount";
            this.UpdlabelScount.Size = new System.Drawing.Size(46, 29);
            this.UpdlabelScount.TabIndex = 30;
            this.UpdlabelScount.Text = "{?}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label4.Location = new System.Drawing.Point(327, 648);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 29);
            this.label4.TabIndex = 29;
            this.label4.Text = "Total Students :";
            // 
            // dataGridViewSinfoUpd
            // 
            this.dataGridViewSinfoUpd.AllowUserToAddRows = false;
            this.dataGridViewSinfoUpd.AllowUserToDeleteRows = false;
            this.dataGridViewSinfoUpd.AllowUserToResizeColumns = false;
            this.dataGridViewSinfoUpd.AllowUserToResizeRows = false;
            this.dataGridViewSinfoUpd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSinfoUpd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewSinfoUpd.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSinfoUpd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSinfoUpd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewSinfoUpd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSinfoUpd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewSinfoUpd.Location = new System.Drawing.Point(12, 100);
            this.dataGridViewSinfoUpd.Name = "dataGridViewSinfoUpd";
            this.dataGridViewSinfoUpd.ReadOnly = true;
            this.dataGridViewSinfoUpd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewSinfoUpd.RowHeadersWidth = 51;
            this.dataGridViewSinfoUpd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSinfoUpd.ShowCellErrors = false;
            this.dataGridViewSinfoUpd.ShowEditingIcon = false;
            this.dataGridViewSinfoUpd.ShowRowErrors = false;
            this.dataGridViewSinfoUpd.Size = new System.Drawing.Size(1209, 240);
            this.dataGridViewSinfoUpd.TabIndex = 28;
            this.dataGridViewSinfoUpd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSinfoUpd_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "student_id";
            this.Column1.HeaderText = "Student ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sname";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sDOB";
            this.Column3.HeaderText = "Date Of Birth";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "sFname";
            this.Column4.HeaderText = "Father Name";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "sContactinfo";
            this.Column5.HeaderText = "Contact Info";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "sYear";
            this.Column6.HeaderText = "Year";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label3.Location = new System.Drawing.Point(65, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label2.Location = new System.Drawing.Point(2, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 31);
            this.label2.TabIndex = 36;
            this.label2.Text = "Search Student Info:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label6.Location = new System.Drawing.Point(91, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 29);
            this.label6.TabIndex = 37;
            this.label6.Text = "Student ID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label7.Location = new System.Drawing.Point(666, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 29);
            this.label7.TabIndex = 38;
            this.label7.Text = "Name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label8.Location = new System.Drawing.Point(91, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 29);
            this.label8.TabIndex = 39;
            this.label8.Text = "Date Of Birth :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label9.Location = new System.Drawing.Point(666, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 29);
            this.label9.TabIndex = 40;
            this.label9.Text = "Father Name :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label10.Location = new System.Drawing.Point(91, 482);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 29);
            this.label10.TabIndex = 41;
            this.label10.Text = "Contact Info :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label11.Location = new System.Drawing.Point(666, 482);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 29);
            this.label11.TabIndex = 42;
            this.label11.Text = "Year :";
            // 
            // UpdtxtSid
            // 
            this.UpdtxtSid.Location = new System.Drawing.Point(321, 357);
            this.UpdtxtSid.Name = "UpdtxtSid";
            this.UpdtxtSid.Size = new System.Drawing.Size(263, 35);
            this.UpdtxtSid.TabIndex = 43;
            // 
            // UpdtxtSConInfo
            // 
            this.UpdtxtSConInfo.Location = new System.Drawing.Point(321, 479);
            this.UpdtxtSConInfo.Name = "UpdtxtSConInfo";
            this.UpdtxtSConInfo.Size = new System.Drawing.Size(263, 35);
            this.UpdtxtSConInfo.TabIndex = 45;
            // 
            // UpdtxtSYear
            // 
            this.UpdtxtSYear.Location = new System.Drawing.Point(866, 479);
            this.UpdtxtSYear.Name = "UpdtxtSYear";
            this.UpdtxtSYear.Size = new System.Drawing.Size(263, 35);
            this.UpdtxtSYear.TabIndex = 48;
            // 
            // UpdtxtSFname
            // 
            this.UpdtxtSFname.Location = new System.Drawing.Point(866, 417);
            this.UpdtxtSFname.Name = "UpdtxtSFname";
            this.UpdtxtSFname.Size = new System.Drawing.Size(263, 35);
            this.UpdtxtSFname.TabIndex = 47;
            // 
            // UpdtxtSname
            // 
            this.UpdtxtSname.Location = new System.Drawing.Point(866, 357);
            this.UpdtxtSname.Name = "UpdtxtSname";
            this.UpdtxtSname.Size = new System.Drawing.Size(263, 35);
            this.UpdtxtSname.TabIndex = 46;
            // 
            // bthSDelete
            // 
            this.bthSDelete.BackColor = System.Drawing.Color.Firebrick;
            this.bthSDelete.BackgroundColor = System.Drawing.Color.Firebrick;
            this.bthSDelete.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.bthSDelete.BorderRadius = 20;
            this.bthSDelete.BorderSize = 3;
            this.bthSDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bthSDelete.FlatAppearance.BorderSize = 0;
            this.bthSDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bthSDelete.ForeColor = System.Drawing.Color.White;
            this.bthSDelete.Location = new System.Drawing.Point(645, 548);
            this.bthSDelete.Margin = new System.Windows.Forms.Padding(5);
            this.bthSDelete.Name = "bthSDelete";
            this.bthSDelete.Size = new System.Drawing.Size(192, 74);
            this.bthSDelete.TabIndex = 50;
            this.bthSDelete.Text = "Delete";
            this.bthSDelete.TextColor = System.Drawing.Color.White;
            this.bthSDelete.UseVisualStyleBackColor = false;
            this.bthSDelete.Click += new System.EventHandler(this.bthSDelete_Click);
            // 
            // btnSupdate
            // 
            this.btnSupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.btnSupdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.btnSupdate.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSupdate.BorderRadius = 20;
            this.btnSupdate.BorderSize = 3;
            this.btnSupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupdate.FlatAppearance.BorderSize = 0;
            this.btnSupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupdate.ForeColor = System.Drawing.Color.White;
            this.btnSupdate.Location = new System.Drawing.Point(406, 548);
            this.btnSupdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnSupdate.Name = "btnSupdate";
            this.btnSupdate.Size = new System.Drawing.Size(181, 74);
            this.btnSupdate.TabIndex = 49;
            this.btnSupdate.Text = "Update";
            this.btnSupdate.TextColor = System.Drawing.Color.White;
            this.btnSupdate.UseVisualStyleBackColor = false;
            this.btnSupdate.Click += new System.EventHandler(this.btnSupdate_Click);
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
            this.rjButton1.Location = new System.Drawing.Point(1170, 50);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(51, 44);
            this.rjButton1.TabIndex = 27;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // UpdtxtSDOB
            // 
            this.UpdtxtSDOB.Location = new System.Drawing.Point(321, 417);
            this.UpdtxtSDOB.Name = "UpdtxtSDOB";
            this.UpdtxtSDOB.Size = new System.Drawing.Size(263, 35);
            this.UpdtxtSDOB.TabIndex = 51;
            // 
            // UserControlManageStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.UpdtxtSDOB);
            this.Controls.Add(this.bthSDelete);
            this.Controls.Add(this.btnSupdate);
            this.Controls.Add(this.UpdtxtSYear);
            this.Controls.Add(this.UpdtxtSFname);
            this.Controls.Add(this.UpdtxtSname);
            this.Controls.Add(this.UpdtxtSConInfo);
            this.Controls.Add(this.UpdtxtSid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpdcboxSYearSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdcboxSIDSearch);
            this.Controls.Add(this.UpdcboxSNameSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UpdlabelScount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewSinfoUpd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rjButton1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "UserControlManageStudents";
            this.Size = new System.Drawing.Size(1235, 683);
            this.Load += new System.EventHandler(this.UserControlManageStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinfoUpd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox UpdcboxSYearSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox UpdcboxSIDSearch;
        private System.Windows.Forms.ComboBox UpdcboxSNameSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label UpdlabelScount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewSinfoUpd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label3;
        private RJButton rjButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox UpdtxtSid;
        private System.Windows.Forms.TextBox UpdtxtSConInfo;
        private System.Windows.Forms.TextBox UpdtxtSYear;
        private System.Windows.Forms.TextBox UpdtxtSFname;
        private System.Windows.Forms.TextBox UpdtxtSname;
        private RJButton bthSDelete;
        private RJButton btnSupdate;
        private System.Windows.Forms.TextBox UpdtxtSDOB;
    }
}
