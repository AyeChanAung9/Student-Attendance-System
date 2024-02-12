namespace StudentAttendanceSystem.User_Control
{
    partial class UserControlClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlClass));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.AddClass = new System.Windows.Forms.TabPage();
            this.btnAdd = new StudentAttendanceSystem.RJButton();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.textBoxTeacher = new System.Windows.Forms.TextBox();
            this.textBoxCname = new System.Windows.Forms.TextBox();
            this.ClassTime = new System.Windows.Forms.Label();
            this.Teacher = new System.Windows.Forms.Label();
            this.ClassName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchClass = new System.Windows.Forms.TabPage();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelcount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewClass = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxsearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rjButton1 = new StudentAttendanceSystem.RJButton();
            this.ClassUpdate = new System.Windows.Forms.TabPage();
            this.bthDelete = new StudentAttendanceSystem.RJButton();
            this.btnupdate = new StudentAttendanceSystem.RJButton();
            this.uptTime = new System.Windows.Forms.ComboBox();
            this.uptTeacher = new System.Windows.Forms.TextBox();
            this.uptname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.uptclass = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.AddClass.SuspendLayout();
            this.SearchClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).BeginInit();
            this.ClassUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add(this.AddClass);
            this.tabControl.Controls.Add(this.SearchClass);
            this.tabControl.Controls.Add(this.ClassUpdate);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(798, 501);
            this.tabControl.TabIndex = 0;
            // 
            // AddClass
            // 
            this.AddClass.BackColor = System.Drawing.Color.White;
            this.AddClass.Controls.Add(this.btnAdd);
            this.AddClass.Controls.Add(this.comboBoxTime);
            this.AddClass.Controls.Add(this.textBoxTeacher);
            this.AddClass.Controls.Add(this.textBoxCname);
            this.AddClass.Controls.Add(this.ClassTime);
            this.AddClass.Controls.Add(this.Teacher);
            this.AddClass.Controls.Add(this.ClassName);
            this.AddClass.Controls.Add(this.label1);
            this.AddClass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddClass.Location = new System.Drawing.Point(4, 4);
            this.AddClass.Name = "AddClass";
            this.AddClass.Padding = new System.Windows.Forms.Padding(3);
            this.AddClass.Size = new System.Drawing.Size(790, 463);
            this.AddClass.TabIndex = 0;
            this.AddClass.Text = "Add Class";
            this.AddClass.Enter += new System.EventHandler(this.AddClass_Enter);
            this.AddClass.Leave += new System.EventHandler(this.AddClass_Leave);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(341, 347);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 48);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Items.AddRange(new object[] {
            "8:45 am - 9:35 am",
            "9:40 am - 10:30 am",
            "10:35 am - 11:25 am",
            "11:30 am - 12:20 pm",
            "12:50 pm -1:40 pm",
            "1:45 pm - 2:35 pm",
            "2:40 pm - 3:30 pm"});
            this.comboBoxTime.Location = new System.Drawing.Point(341, 256);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(226, 33);
            this.comboBoxTime.TabIndex = 7;
            // 
            // textBoxTeacher
            // 
            this.textBoxTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.textBoxTeacher.Location = new System.Drawing.Point(341, 171);
            this.textBoxTeacher.Name = "textBoxTeacher";
            this.textBoxTeacher.Size = new System.Drawing.Size(226, 30);
            this.textBoxTeacher.TabIndex = 6;
            // 
            // textBoxCname
            // 
            this.textBoxCname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.textBoxCname.Location = new System.Drawing.Point(341, 82);
            this.textBoxCname.Name = "textBoxCname";
            this.textBoxCname.Size = new System.Drawing.Size(226, 30);
            this.textBoxCname.TabIndex = 5;
            // 
            // ClassTime
            // 
            this.ClassTime.AutoSize = true;
            this.ClassTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.ClassTime.Location = new System.Drawing.Point(189, 264);
            this.ClassTime.Name = "ClassTime";
            this.ClassTime.Size = new System.Drawing.Size(73, 25);
            this.ClassTime.TabIndex = 4;
            this.ClassTime.Text = "Time :";
            // 
            // Teacher
            // 
            this.Teacher.AutoSize = true;
            this.Teacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.Teacher.Location = new System.Drawing.Point(162, 174);
            this.Teacher.Name = "Teacher";
            this.Teacher.Size = new System.Drawing.Size(105, 25);
            this.Teacher.TabIndex = 2;
            this.Teacher.Text = "Teacher :";
            // 
            // ClassName
            // 
            this.ClassName.AutoSize = true;
            this.ClassName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.ClassName.Location = new System.Drawing.Point(132, 85);
            this.ClassName.Name = "ClassName";
            this.ClassName.Size = new System.Drawing.Size(142, 25);
            this.ClassName.TabIndex = 1;
            this.ClassName.Text = "Class Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Class :";
            // 
            // SearchClass
            // 
            this.SearchClass.BackColor = System.Drawing.Color.White;
            this.SearchClass.Controls.Add(this.comboBoxSearchBy);
            this.SearchClass.Controls.Add(this.label5);
            this.SearchClass.Controls.Add(this.labelcount);
            this.SearchClass.Controls.Add(this.label4);
            this.SearchClass.Controls.Add(this.dataGridViewClass);
            this.SearchClass.Controls.Add(this.textBoxsearch);
            this.SearchClass.Controls.Add(this.label3);
            this.SearchClass.Controls.Add(this.label2);
            this.SearchClass.Controls.Add(this.rjButton1);
            this.SearchClass.Location = new System.Drawing.Point(4, 4);
            this.SearchClass.Name = "SearchClass";
            this.SearchClass.Padding = new System.Windows.Forms.Padding(3);
            this.SearchClass.Size = new System.Drawing.Size(790, 463);
            this.SearchClass.TabIndex = 1;
            this.SearchClass.Text = "Search Class";
            this.SearchClass.Enter += new System.EventHandler(this.SearchClass_Enter);
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "Class",
            "Teacher",
            "Time"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(629, 48);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(121, 33);
            this.comboBoxSearchBy.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label5.Location = new System.Drawing.Point(498, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Search By :";
            // 
            // labelcount
            // 
            this.labelcount.AutoSize = true;
            this.labelcount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.labelcount.Location = new System.Drawing.Point(260, 435);
            this.labelcount.Name = "labelcount";
            this.labelcount.Size = new System.Drawing.Size(40, 25);
            this.labelcount.TabIndex = 11;
            this.labelcount.Text = "{?}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label4.Location = new System.Drawing.Point(127, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total Classes :";
            // 
            // dataGridViewClass
            // 
            this.dataGridViewClass.AllowUserToAddRows = false;
            this.dataGridViewClass.AllowUserToDeleteRows = false;
            this.dataGridViewClass.AllowUserToResizeColumns = false;
            this.dataGridViewClass.AllowUserToResizeRows = false;
            this.dataGridViewClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClass.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewClass.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClass.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewClass.Location = new System.Drawing.Point(6, 113);
            this.dataGridViewClass.Name = "dataGridViewClass";
            this.dataGridViewClass.ReadOnly = true;
            this.dataGridViewClass.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewClass.RowHeadersWidth = 51;
            this.dataGridViewClass.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewClass.ShowCellErrors = false;
            this.dataGridViewClass.ShowEditingIcon = false;
            this.dataGridViewClass.ShowRowErrors = false;
            this.dataGridViewClass.Size = new System.Drawing.Size(778, 306);
            this.dataGridViewClass.TabIndex = 9;
            this.dataGridViewClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClass_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "classname";
            this.Column1.HeaderText = "Class";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "teacher";
            this.Column2.HeaderText = "Teacher";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "time";
            this.Column3.HeaderText = "Time";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // textBoxsearch
            // 
            this.textBoxsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.textBoxsearch.Location = new System.Drawing.Point(184, 49);
            this.textBoxsearch.Name = "textBoxsearch";
            this.textBoxsearch.Size = new System.Drawing.Size(226, 30);
            this.textBoxsearch.TabIndex = 7;
            this.textBoxsearch.TextChanged += new System.EventHandler(this.textBoxsearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label3.Location = new System.Drawing.Point(71, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Search :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label2.Location = new System.Drawing.Point(-1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search Class:";
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
            this.rjButton1.Location = new System.Drawing.Point(434, 44);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(42, 37);
            this.rjButton1.TabIndex = 8;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // ClassUpdate
            // 
            this.ClassUpdate.BackColor = System.Drawing.Color.White;
            this.ClassUpdate.Controls.Add(this.bthDelete);
            this.ClassUpdate.Controls.Add(this.btnupdate);
            this.ClassUpdate.Controls.Add(this.uptTime);
            this.ClassUpdate.Controls.Add(this.uptTeacher);
            this.ClassUpdate.Controls.Add(this.uptname);
            this.ClassUpdate.Controls.Add(this.label6);
            this.ClassUpdate.Controls.Add(this.label7);
            this.ClassUpdate.Controls.Add(this.label8);
            this.ClassUpdate.Controls.Add(this.uptclass);
            this.ClassUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClassUpdate.Location = new System.Drawing.Point(4, 4);
            this.ClassUpdate.Name = "ClassUpdate";
            this.ClassUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.ClassUpdate.Size = new System.Drawing.Size(790, 463);
            this.ClassUpdate.TabIndex = 2;
            this.ClassUpdate.Text = "Update & Delete Class";
            this.ClassUpdate.Leave += new System.EventHandler(this.ClassUpdate_Leave);
            // 
            // bthDelete
            // 
            this.bthDelete.BackColor = System.Drawing.Color.Firebrick;
            this.bthDelete.BackgroundColor = System.Drawing.Color.Firebrick;
            this.bthDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bthDelete.BorderRadius = 20;
            this.bthDelete.BorderSize = 0;
            this.bthDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bthDelete.FlatAppearance.BorderSize = 0;
            this.bthDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bthDelete.ForeColor = System.Drawing.Color.White;
            this.bthDelete.Location = new System.Drawing.Point(483, 351);
            this.bthDelete.Name = "bthDelete";
            this.bthDelete.Size = new System.Drawing.Size(141, 48);
            this.bthDelete.TabIndex = 16;
            this.bthDelete.Text = "Delete";
            this.bthDelete.TextColor = System.Drawing.Color.White;
            this.bthDelete.UseVisualStyleBackColor = false;
            this.bthDelete.Click += new System.EventHandler(this.bthDelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.btnupdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.btnupdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnupdate.BorderRadius = 20;
            this.btnupdate.BorderSize = 0;
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(313, 351);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(141, 48);
            this.btnupdate.TabIndex = 15;
            this.btnupdate.Text = "Update";
            this.btnupdate.TextColor = System.Drawing.Color.White;
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // uptTime
            // 
            this.uptTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uptTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.uptTime.FormattingEnabled = true;
            this.uptTime.Items.AddRange(new object[] {
            "8:45 am - 9:35 am",
            "9:40 am - 10:30 am",
            "10:35 am - 11:25 am",
            "11:30 am - 12:20 pm",
            "12:50 pm -1:40 pm",
            "1:45 pm - 2:35 pm",
            "2:40 pm - 3:30 pm"});
            this.uptTime.Location = new System.Drawing.Point(345, 260);
            this.uptTime.Name = "uptTime";
            this.uptTime.Size = new System.Drawing.Size(226, 33);
            this.uptTime.TabIndex = 14;
            // 
            // uptTeacher
            // 
            this.uptTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.uptTeacher.Location = new System.Drawing.Point(345, 175);
            this.uptTeacher.Name = "uptTeacher";
            this.uptTeacher.Size = new System.Drawing.Size(226, 30);
            this.uptTeacher.TabIndex = 13;
            // 
            // uptname
            // 
            this.uptname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.uptname.Location = new System.Drawing.Point(345, 86);
            this.uptname.Name = "uptname";
            this.uptname.Size = new System.Drawing.Size(226, 30);
            this.uptname.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label6.Location = new System.Drawing.Point(193, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Time :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label7.Location = new System.Drawing.Point(166, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Teacher :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label8.Location = new System.Drawing.Point(136, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Class Name :";
            // 
            // uptclass
            // 
            this.uptclass.AutoSize = true;
            this.uptclass.BackColor = System.Drawing.Color.Transparent;
            this.uptclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uptclass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.uptclass.Location = new System.Drawing.Point(3, 4);
            this.uptclass.Name = "uptclass";
            this.uptclass.Size = new System.Drawing.Size(365, 36);
            this.uptclass.TabIndex = 8;
            this.uptclass.Text = "Update Or Delete Class :";
            // 
            // UserControlClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserControlClass";
            this.Size = new System.Drawing.Size(798, 501);
            this.tabControl.ResumeLayout(false);
            this.AddClass.ResumeLayout(false);
            this.AddClass.PerformLayout();
            this.SearchClass.ResumeLayout(false);
            this.SearchClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).EndInit();
            this.ClassUpdate.ResumeLayout(false);
            this.ClassUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage AddClass;
        private System.Windows.Forms.TabPage SearchClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ClassName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTeacher;
        private System.Windows.Forms.TextBox textBoxCname;
        private System.Windows.Forms.Label ClassTime;
        private System.Windows.Forms.Label Teacher;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private RJButton btnAdd;
        private System.Windows.Forms.TabPage ClassUpdate;
        private System.Windows.Forms.TextBox textBoxsearch;
        private System.Windows.Forms.Label label3;
        private RJButton rjButton1;
        private System.Windows.Forms.DataGridView dataGridViewClass;
        private System.Windows.Forms.Label labelcount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox uptTime;
        private System.Windows.Forms.TextBox uptTeacher;
        private System.Windows.Forms.TextBox uptname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label uptclass;
        private RJButton btnupdate;
        private RJButton bthDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
