namespace StudentAttendanceSystem.User_Control
{
    partial class UserControlTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlTeacher));
            this.tabControlTeacher = new System.Windows.Forms.TabControl();
            this.AddTeacher = new System.Windows.Forms.TabPage();
            this.textBoxTContac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTpos = new System.Windows.Forms.TextBox();
            this.btnTAdd = new StudentAttendanceSystem.RJButton();
            this.textBoxTname = new System.Windows.Forms.TextBox();
            this.textBoxTID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTeacher = new System.Windows.Forms.TabPage();
            this.comboBoxTSearchBy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTcount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewTeacher = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxTsearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rjButton1 = new StudentAttendanceSystem.RJButton();
            this.UpdateTeacher = new System.Windows.Forms.TabPage();
            this.bthTDelete = new StudentAttendanceSystem.RJButton();
            this.btnTupdate = new StudentAttendanceSystem.RJButton();
            this.UtextBoxTContac = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.UtextBoxTDOB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.UtextBoxTPos = new System.Windows.Forms.TextBox();
            this.UtextBoxTname = new System.Windows.Forms.TextBox();
            this.UtextBoxID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxTDOB = new System.Windows.Forms.TextBox();
            this.tabControlTeacher.SuspendLayout();
            this.AddTeacher.SuspendLayout();
            this.SearchTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacher)).BeginInit();
            this.UpdateTeacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlTeacher
            // 
            this.tabControlTeacher.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlTeacher.Controls.Add(this.AddTeacher);
            this.tabControlTeacher.Controls.Add(this.SearchTeacher);
            this.tabControlTeacher.Controls.Add(this.UpdateTeacher);
            this.tabControlTeacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlTeacher.ItemSize = new System.Drawing.Size(112, 30);
            this.tabControlTeacher.Location = new System.Drawing.Point(0, 0);
            this.tabControlTeacher.Name = "tabControlTeacher";
            this.tabControlTeacher.SelectedIndex = 0;
            this.tabControlTeacher.Size = new System.Drawing.Size(1175, 694);
            this.tabControlTeacher.TabIndex = 0;
            // 
            // AddTeacher
            // 
            this.AddTeacher.BackColor = System.Drawing.Color.White;
            this.AddTeacher.Controls.Add(this.textBoxTContac);
            this.AddTeacher.Controls.Add(this.label2);
            this.AddTeacher.Controls.Add(this.textBoxTDOB);
            this.AddTeacher.Controls.Add(this.label3);
            this.AddTeacher.Controls.Add(this.textBoxTpos);
            this.AddTeacher.Controls.Add(this.btnTAdd);
            this.AddTeacher.Controls.Add(this.textBoxTname);
            this.AddTeacher.Controls.Add(this.textBoxTID);
            this.AddTeacher.Controls.Add(this.label14);
            this.AddTeacher.Controls.Add(this.label15);
            this.AddTeacher.Controls.Add(this.label16);
            this.AddTeacher.Controls.Add(this.label1);
            this.AddTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeacher.ForeColor = System.Drawing.Color.White;
            this.AddTeacher.Location = new System.Drawing.Point(4, 4);
            this.AddTeacher.Margin = new System.Windows.Forms.Padding(5);
            this.AddTeacher.Name = "AddTeacher";
            this.AddTeacher.Padding = new System.Windows.Forms.Padding(5);
            this.AddTeacher.Size = new System.Drawing.Size(1167, 656);
            this.AddTeacher.TabIndex = 0;
            this.AddTeacher.Text = "Add Teacher";
            this.AddTeacher.Enter += new System.EventHandler(this.AddTeacher_Enter);
            // 
            // textBoxTContac
            // 
            this.textBoxTContac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.textBoxTContac.Location = new System.Drawing.Point(587, 436);
            this.textBoxTContac.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxTContac.Name = "textBoxTContac";
            this.textBoxTContac.Size = new System.Drawing.Size(297, 35);
            this.textBoxTContac.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label2.Location = new System.Drawing.Point(304, 439);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 29);
            this.label2.TabIndex = 42;
            this.label2.Text = "Contact Info :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label3.Location = new System.Drawing.Point(294, 349);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 29);
            this.label3.TabIndex = 40;
            this.label3.Text = "Date Of Birth :";
            // 
            // textBoxTpos
            // 
            this.textBoxTpos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.textBoxTpos.Location = new System.Drawing.Point(587, 258);
            this.textBoxTpos.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxTpos.Name = "textBoxTpos";
            this.textBoxTpos.Size = new System.Drawing.Size(297, 35);
            this.textBoxTpos.TabIndex = 39;
            // 
            // btnTAdd
            // 
            this.btnTAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.btnTAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.btnTAdd.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnTAdd.BorderRadius = 20;
            this.btnTAdd.BorderSize = 3;
            this.btnTAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTAdd.FlatAppearance.BorderSize = 0;
            this.btnTAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTAdd.ForeColor = System.Drawing.Color.White;
            this.btnTAdd.Location = new System.Drawing.Point(505, 526);
            this.btnTAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnTAdd.Name = "btnTAdd";
            this.btnTAdd.Size = new System.Drawing.Size(174, 76);
            this.btnTAdd.TabIndex = 38;
            this.btnTAdd.Text = "Add";
            this.btnTAdd.TextColor = System.Drawing.Color.White;
            this.btnTAdd.UseVisualStyleBackColor = false;
            this.btnTAdd.Click += new System.EventHandler(this.btnTAdd_Click);
            // 
            // textBoxTname
            // 
            this.textBoxTname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.textBoxTname.Location = new System.Drawing.Point(587, 173);
            this.textBoxTname.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxTname.Name = "textBoxTname";
            this.textBoxTname.Size = new System.Drawing.Size(297, 35);
            this.textBoxTname.TabIndex = 37;
            // 
            // textBoxTID
            // 
            this.textBoxTID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.textBoxTID.Location = new System.Drawing.Point(587, 96);
            this.textBoxTID.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxTID.Name = "textBoxTID";
            this.textBoxTID.Size = new System.Drawing.Size(297, 35);
            this.textBoxTID.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label14.Location = new System.Drawing.Point(360, 261);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 29);
            this.label14.TabIndex = 35;
            this.label14.Text = "Position :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label15.Location = new System.Drawing.Point(271, 176);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(200, 29);
            this.label15.TabIndex = 34;
            this.label15.Text = "Teacher Name :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label16.Location = new System.Drawing.Point(441, 99);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 29);
            this.label16.TabIndex = 33;
            this.label16.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Add Teacher :";
            // 
            // SearchTeacher
            // 
            this.SearchTeacher.BackColor = System.Drawing.Color.White;
            this.SearchTeacher.Controls.Add(this.comboBoxTSearchBy);
            this.SearchTeacher.Controls.Add(this.label5);
            this.SearchTeacher.Controls.Add(this.labelTcount);
            this.SearchTeacher.Controls.Add(this.label4);
            this.SearchTeacher.Controls.Add(this.dataGridViewTeacher);
            this.SearchTeacher.Controls.Add(this.textBoxTsearch);
            this.SearchTeacher.Controls.Add(this.label6);
            this.SearchTeacher.Controls.Add(this.label7);
            this.SearchTeacher.Controls.Add(this.rjButton1);
            this.SearchTeacher.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SearchTeacher.Location = new System.Drawing.Point(4, 4);
            this.SearchTeacher.Margin = new System.Windows.Forms.Padding(5);
            this.SearchTeacher.Name = "SearchTeacher";
            this.SearchTeacher.Padding = new System.Windows.Forms.Padding(5);
            this.SearchTeacher.Size = new System.Drawing.Size(1167, 656);
            this.SearchTeacher.TabIndex = 1;
            this.SearchTeacher.Text = "Search Teacher";
            this.SearchTeacher.Enter += new System.EventHandler(this.SearchTeacher_Enter);
            // 
            // comboBoxTSearchBy
            // 
            this.comboBoxTSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTSearchBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.comboBoxTSearchBy.FormattingEnabled = true;
            this.comboBoxTSearchBy.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Position"});
            this.comboBoxTSearchBy.Location = new System.Drawing.Point(862, 55);
            this.comboBoxTSearchBy.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxTSearchBy.Name = "comboBoxTSearchBy";
            this.comboBoxTSearchBy.Size = new System.Drawing.Size(266, 37);
            this.comboBoxTSearchBy.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label5.Location = new System.Drawing.Point(673, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Search By :";
            // 
            // labelTcount
            // 
            this.labelTcount.AutoSize = true;
            this.labelTcount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.labelTcount.Location = new System.Drawing.Point(467, 615);
            this.labelTcount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTcount.Name = "labelTcount";
            this.labelTcount.Size = new System.Drawing.Size(46, 29);
            this.labelTcount.TabIndex = 20;
            this.labelTcount.Text = "{?}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label4.Location = new System.Drawing.Point(213, 615);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Total Teachers :";
            // 
            // dataGridViewTeacher
            // 
            this.dataGridViewTeacher.AllowUserToAddRows = false;
            this.dataGridViewTeacher.AllowUserToDeleteRows = false;
            this.dataGridViewTeacher.AllowUserToResizeColumns = false;
            this.dataGridViewTeacher.AllowUserToResizeRows = false;
            this.dataGridViewTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTeacher.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewTeacher.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTeacher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTeacher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewTeacher.Location = new System.Drawing.Point(5, 112);
            this.dataGridViewTeacher.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewTeacher.Name = "dataGridViewTeacher";
            this.dataGridViewTeacher.ReadOnly = true;
            this.dataGridViewTeacher.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewTeacher.RowHeadersWidth = 51;
            this.dataGridViewTeacher.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewTeacher.ShowCellErrors = false;
            this.dataGridViewTeacher.ShowEditingIcon = false;
            this.dataGridViewTeacher.ShowRowErrors = false;
            this.dataGridViewTeacher.Size = new System.Drawing.Size(1152, 309);
            this.dataGridViewTeacher.TabIndex = 18;
            this.dataGridViewTeacher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTeacher_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Teacher_Name";
            this.Column2.HeaderText = "Teacher Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Position";
            this.Column3.HeaderText = "Position";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DOB";
            this.Column4.HeaderText = "Date Of Birth";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Contact";
            this.Column5.HeaderText = "Contact Info";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // textBoxTsearch
            // 
            this.textBoxTsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.textBoxTsearch.Location = new System.Drawing.Point(302, 55);
            this.textBoxTsearch.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxTsearch.Name = "textBoxTsearch";
            this.textBoxTsearch.Size = new System.Drawing.Size(281, 35);
            this.textBoxTsearch.TabIndex = 16;
            this.textBoxTsearch.TextChanged += new System.EventHandler(this.textBoxTsearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label6.Location = new System.Drawing.Point(144, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Teacher :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label7.Location = new System.Drawing.Point(5, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 31);
            this.label7.TabIndex = 14;
            this.label7.Text = "Search Class:";
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
            this.rjButton1.Location = new System.Drawing.Point(593, 41);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(5);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(70, 61);
            this.rjButton1.TabIndex = 17;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // UpdateTeacher
            // 
            this.UpdateTeacher.BackColor = System.Drawing.Color.White;
            this.UpdateTeacher.Controls.Add(this.bthTDelete);
            this.UpdateTeacher.Controls.Add(this.btnTupdate);
            this.UpdateTeacher.Controls.Add(this.UtextBoxTContac);
            this.UpdateTeacher.Controls.Add(this.label8);
            this.UpdateTeacher.Controls.Add(this.UtextBoxTDOB);
            this.UpdateTeacher.Controls.Add(this.label9);
            this.UpdateTeacher.Controls.Add(this.UtextBoxTPos);
            this.UpdateTeacher.Controls.Add(this.UtextBoxTname);
            this.UpdateTeacher.Controls.Add(this.UtextBoxID);
            this.UpdateTeacher.Controls.Add(this.label10);
            this.UpdateTeacher.Controls.Add(this.label11);
            this.UpdateTeacher.Controls.Add(this.label12);
            this.UpdateTeacher.Controls.Add(this.label13);
            this.UpdateTeacher.ForeColor = System.Drawing.Color.White;
            this.UpdateTeacher.Location = new System.Drawing.Point(4, 4);
            this.UpdateTeacher.Margin = new System.Windows.Forms.Padding(5);
            this.UpdateTeacher.Name = "UpdateTeacher";
            this.UpdateTeacher.Padding = new System.Windows.Forms.Padding(5);
            this.UpdateTeacher.Size = new System.Drawing.Size(1167, 656);
            this.UpdateTeacher.TabIndex = 2;
            this.UpdateTeacher.Text = "Update & Delete Teacher";
            this.UpdateTeacher.Leave += new System.EventHandler(this.UpdateTeacher_Leave);
            // 
            // bthTDelete
            // 
            this.bthTDelete.BackColor = System.Drawing.Color.Firebrick;
            this.bthTDelete.BackgroundColor = System.Drawing.Color.Firebrick;
            this.bthTDelete.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.bthTDelete.BorderRadius = 20;
            this.bthTDelete.BorderSize = 3;
            this.bthTDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bthTDelete.FlatAppearance.BorderSize = 0;
            this.bthTDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bthTDelete.ForeColor = System.Drawing.Color.White;
            this.bthTDelete.Location = new System.Drawing.Point(699, 518);
            this.bthTDelete.Margin = new System.Windows.Forms.Padding(5);
            this.bthTDelete.Name = "bthTDelete";
            this.bthTDelete.Size = new System.Drawing.Size(192, 74);
            this.bthTDelete.TabIndex = 34;
            this.bthTDelete.Text = "Delete";
            this.bthTDelete.TextColor = System.Drawing.Color.White;
            this.bthTDelete.UseVisualStyleBackColor = false;
            this.bthTDelete.Click += new System.EventHandler(this.bthTDelete_Click);
            // 
            // btnTupdate
            // 
            this.btnTupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.btnTupdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.btnTupdate.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnTupdate.BorderRadius = 20;
            this.btnTupdate.BorderSize = 3;
            this.btnTupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTupdate.FlatAppearance.BorderSize = 0;
            this.btnTupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTupdate.ForeColor = System.Drawing.Color.White;
            this.btnTupdate.Location = new System.Drawing.Point(460, 518);
            this.btnTupdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnTupdate.Name = "btnTupdate";
            this.btnTupdate.Size = new System.Drawing.Size(181, 74);
            this.btnTupdate.TabIndex = 33;
            this.btnTupdate.Text = "Update";
            this.btnTupdate.TextColor = System.Drawing.Color.White;
            this.btnTupdate.UseVisualStyleBackColor = false;
            this.btnTupdate.Click += new System.EventHandler(this.btnTupdate_Click);
            // 
            // UtextBoxTContac
            // 
            this.UtextBoxTContac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.UtextBoxTContac.Location = new System.Drawing.Point(567, 418);
            this.UtextBoxTContac.Margin = new System.Windows.Forms.Padding(5);
            this.UtextBoxTContac.Name = "UtextBoxTContac";
            this.UtextBoxTContac.Size = new System.Drawing.Size(349, 35);
            this.UtextBoxTContac.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label8.Location = new System.Drawing.Point(284, 421);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 29);
            this.label8.TabIndex = 31;
            this.label8.Text = "Contact Info :";
            // 
            // UtextBoxTDOB
            // 
            this.UtextBoxTDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.UtextBoxTDOB.Location = new System.Drawing.Point(567, 333);
            this.UtextBoxTDOB.Margin = new System.Windows.Forms.Padding(5);
            this.UtextBoxTDOB.Name = "UtextBoxTDOB";
            this.UtextBoxTDOB.Size = new System.Drawing.Size(349, 35);
            this.UtextBoxTDOB.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label9.Location = new System.Drawing.Point(274, 336);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 29);
            this.label9.TabIndex = 29;
            this.label9.Text = "Date Of Birth :";
            // 
            // UtextBoxTPos
            // 
            this.UtextBoxTPos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.UtextBoxTPos.Location = new System.Drawing.Point(567, 251);
            this.UtextBoxTPos.Margin = new System.Windows.Forms.Padding(5);
            this.UtextBoxTPos.Name = "UtextBoxTPos";
            this.UtextBoxTPos.Size = new System.Drawing.Size(349, 35);
            this.UtextBoxTPos.TabIndex = 28;
            // 
            // UtextBoxTname
            // 
            this.UtextBoxTname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.UtextBoxTname.Location = new System.Drawing.Point(567, 175);
            this.UtextBoxTname.Margin = new System.Windows.Forms.Padding(5);
            this.UtextBoxTname.Name = "UtextBoxTname";
            this.UtextBoxTname.Size = new System.Drawing.Size(349, 35);
            this.UtextBoxTname.TabIndex = 27;
            // 
            // UtextBoxID
            // 
            this.UtextBoxID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.UtextBoxID.Location = new System.Drawing.Point(567, 102);
            this.UtextBoxID.Margin = new System.Windows.Forms.Padding(5);
            this.UtextBoxID.Name = "UtextBoxID";
            this.UtextBoxID.Size = new System.Drawing.Size(349, 35);
            this.UtextBoxID.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label10.Location = new System.Drawing.Point(340, 254);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 29);
            this.label10.TabIndex = 25;
            this.label10.Text = "Position :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label11.Location = new System.Drawing.Point(251, 178);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 29);
            this.label11.TabIndex = 24;
            this.label11.Text = "Teacher Name :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label12.Location = new System.Drawing.Point(425, 105);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 29);
            this.label12.TabIndex = 23;
            this.label12.Text = "ID :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label13.Location = new System.Drawing.Point(8, 9);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(373, 31);
            this.label13.TabIndex = 22;
            this.label13.Text = "Update Or Delete Teacher :";
            // 
            // textBoxTDOB
            // 
            this.textBoxTDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.textBoxTDOB.Location = new System.Drawing.Point(587, 346);
            this.textBoxTDOB.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxTDOB.Name = "textBoxTDOB";
            this.textBoxTDOB.Size = new System.Drawing.Size(297, 35);
            this.textBoxTDOB.TabIndex = 41;
            // 
            // UserControlTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlTeacher);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserControlTeacher";
            this.Size = new System.Drawing.Size(1175, 694);
            this.tabControlTeacher.ResumeLayout(false);
            this.AddTeacher.ResumeLayout(false);
            this.AddTeacher.PerformLayout();
            this.SearchTeacher.ResumeLayout(false);
            this.SearchTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacher)).EndInit();
            this.UpdateTeacher.ResumeLayout(false);
            this.UpdateTeacher.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTeacher;
        private System.Windows.Forms.TabPage AddTeacher;
        private System.Windows.Forms.TabPage SearchTeacher;
        private System.Windows.Forms.TabPage UpdateTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTSearchBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTcount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewTeacher;
        private System.Windows.Forms.TextBox textBoxTsearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private RJButton rjButton1;
        private System.Windows.Forms.TextBox UtextBoxTContac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox UtextBoxTDOB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox UtextBoxTPos;
        private System.Windows.Forms.TextBox UtextBoxTname;
        private System.Windows.Forms.TextBox UtextBoxID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private RJButton bthTDelete;
        private RJButton btnTupdate;
        private System.Windows.Forms.TextBox textBoxTContac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTpos;
        private RJButton btnTAdd;
        private System.Windows.Forms.TextBox textBoxTname;
        private System.Windows.Forms.TextBox textBoxTID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox textBoxTDOB;
    }
}
