namespace StudentAttendanceSystem.User_Control
{
    partial class UserControlAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlAccount));
            this.tabControlAcc = new System.Windows.Forms.TabControl();
            this.AddAccTab = new System.Windows.Forms.TabPage();
            this.comboBoxAccRole = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAccOwn = new System.Windows.Forms.TextBox();
            this.btnAccAdd = new StudentAttendanceSystem.RJButton();
            this.textBoxAccPass = new System.Windows.Forms.TextBox();
            this.textBoxAccName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchAccTab = new System.Windows.Forms.TabPage();
            this.comboBoxAccSearchBy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelACCcount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewTeacher = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxAccsearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rjButton1 = new StudentAttendanceSystem.RJButton();
            this.UpdateAccTab = new System.Windows.Forms.TabPage();
            this.UcomboAccRole = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UAccOwn = new System.Windows.Forms.TextBox();
            this.UAccPass = new System.Windows.Forms.TextBox();
            this.UAccUname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.bthAccDelete = new StudentAttendanceSystem.RJButton();
            this.btnAccupdate = new StudentAttendanceSystem.RJButton();
            this.tabControlAcc.SuspendLayout();
            this.AddAccTab.SuspendLayout();
            this.SearchAccTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacher)).BeginInit();
            this.UpdateAccTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAcc
            // 
            this.tabControlAcc.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlAcc.Controls.Add(this.AddAccTab);
            this.tabControlAcc.Controls.Add(this.SearchAccTab);
            this.tabControlAcc.Controls.Add(this.UpdateAccTab);
            this.tabControlAcc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAcc.Location = new System.Drawing.Point(0, 0);
            this.tabControlAcc.Name = "tabControlAcc";
            this.tabControlAcc.SelectedIndex = 0;
            this.tabControlAcc.Size = new System.Drawing.Size(798, 501);
            this.tabControlAcc.TabIndex = 0;
            // 
            // AddAccTab
            // 
            this.AddAccTab.BackColor = System.Drawing.Color.White;
            this.AddAccTab.Controls.Add(this.comboBoxAccRole);
            this.AddAccTab.Controls.Add(this.label3);
            this.AddAccTab.Controls.Add(this.textBoxAccOwn);
            this.AddAccTab.Controls.Add(this.btnAccAdd);
            this.AddAccTab.Controls.Add(this.textBoxAccPass);
            this.AddAccTab.Controls.Add(this.textBoxAccName);
            this.AddAccTab.Controls.Add(this.label14);
            this.AddAccTab.Controls.Add(this.label15);
            this.AddAccTab.Controls.Add(this.label16);
            this.AddAccTab.Controls.Add(this.label1);
            this.AddAccTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddAccTab.Location = new System.Drawing.Point(4, 4);
            this.AddAccTab.Name = "AddAccTab";
            this.AddAccTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddAccTab.Size = new System.Drawing.Size(790, 463);
            this.AddAccTab.TabIndex = 0;
            this.AddAccTab.Text = "Add Account";
            this.AddAccTab.Enter += new System.EventHandler(this.AddAccTab_Enter);
            this.AddAccTab.Leave += new System.EventHandler(this.AddAccTab_Leave);
            // 
            // comboBoxAccRole
            // 
            this.comboBoxAccRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.comboBoxAccRole.FormattingEnabled = true;
            this.comboBoxAccRole.Items.AddRange(new object[] {
            "Teacher",
            "Admin",
            "Others"});
            this.comboBoxAccRole.Location = new System.Drawing.Point(331, 270);
            this.comboBoxAccRole.Name = "comboBoxAccRole";
            this.comboBoxAccRole.Size = new System.Drawing.Size(157, 33);
            this.comboBoxAccRole.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label3.Location = new System.Drawing.Point(235, 270);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "Role :";
            // 
            // textBoxAccOwn
            // 
            this.textBoxAccOwn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.textBoxAccOwn.Location = new System.Drawing.Point(331, 207);
            this.textBoxAccOwn.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxAccOwn.Name = "textBoxAccOwn";
            this.textBoxAccOwn.Size = new System.Drawing.Size(263, 30);
            this.textBoxAccOwn.TabIndex = 51;
            // 
            // btnAccAdd
            // 
            this.btnAccAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.btnAccAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.btnAccAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAccAdd.BorderRadius = 20;
            this.btnAccAdd.BorderSize = 0;
            this.btnAccAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccAdd.FlatAppearance.BorderSize = 0;
            this.btnAccAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccAdd.ForeColor = System.Drawing.Color.White;
            this.btnAccAdd.Location = new System.Drawing.Point(331, 348);
            this.btnAccAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAccAdd.Name = "btnAccAdd";
            this.btnAccAdd.Size = new System.Drawing.Size(157, 56);
            this.btnAccAdd.TabIndex = 50;
            this.btnAccAdd.Text = "Add";
            this.btnAccAdd.TextColor = System.Drawing.Color.White;
            this.btnAccAdd.UseVisualStyleBackColor = false;
            this.btnAccAdd.Click += new System.EventHandler(this.btnAccAdd_Click);
            // 
            // textBoxAccPass
            // 
            this.textBoxAccPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.textBoxAccPass.Location = new System.Drawing.Point(331, 147);
            this.textBoxAccPass.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxAccPass.Name = "textBoxAccPass";
            this.textBoxAccPass.Size = new System.Drawing.Size(263, 30);
            this.textBoxAccPass.TabIndex = 49;
            // 
            // textBoxAccName
            // 
            this.textBoxAccName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.textBoxAccName.Location = new System.Drawing.Point(331, 87);
            this.textBoxAccName.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxAccName.Name = "textBoxAccName";
            this.textBoxAccName.Size = new System.Drawing.Size(263, 30);
            this.textBoxAccName.TabIndex = 48;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label14.Location = new System.Drawing.Point(221, 210);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 25);
            this.label14.TabIndex = 47;
            this.label14.Text = "Owner :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label15.Location = new System.Drawing.Point(195, 150);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 25);
            this.label15.TabIndex = 46;
            this.label15.Text = "Password :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label16.Location = new System.Drawing.Point(188, 90);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 25);
            this.label16.TabIndex = 45;
            this.label16.Text = "UserName :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 36);
            this.label1.TabIndex = 44;
            this.label1.Text = "Add Account :";
            // 
            // SearchAccTab
            // 
            this.SearchAccTab.BackColor = System.Drawing.Color.White;
            this.SearchAccTab.Controls.Add(this.comboBoxAccSearchBy);
            this.SearchAccTab.Controls.Add(this.label5);
            this.SearchAccTab.Controls.Add(this.labelACCcount);
            this.SearchAccTab.Controls.Add(this.label4);
            this.SearchAccTab.Controls.Add(this.dataGridViewTeacher);
            this.SearchAccTab.Controls.Add(this.textBoxAccsearch);
            this.SearchAccTab.Controls.Add(this.label6);
            this.SearchAccTab.Controls.Add(this.label7);
            this.SearchAccTab.Controls.Add(this.rjButton1);
            this.SearchAccTab.Location = new System.Drawing.Point(4, 4);
            this.SearchAccTab.Name = "SearchAccTab";
            this.SearchAccTab.Padding = new System.Windows.Forms.Padding(3);
            this.SearchAccTab.Size = new System.Drawing.Size(790, 463);
            this.SearchAccTab.TabIndex = 1;
            this.SearchAccTab.Text = "Search Account";
            this.SearchAccTab.Enter += new System.EventHandler(this.SearchAccTab_Enter);
            // 
            // comboBoxAccSearchBy
            // 
            this.comboBoxAccSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccSearchBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.comboBoxAccSearchBy.FormattingEnabled = true;
            this.comboBoxAccSearchBy.Items.AddRange(new object[] {
            "UserName",
            "Role",
            "Owner"});
            this.comboBoxAccSearchBy.Location = new System.Drawing.Point(573, 54);
            this.comboBoxAccSearchBy.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxAccSearchBy.Name = "comboBoxAccSearchBy";
            this.comboBoxAccSearchBy.Size = new System.Drawing.Size(199, 33);
            this.comboBoxAccSearchBy.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label5.Location = new System.Drawing.Point(431, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Search By :";
            // 
            // labelACCcount
            // 
            this.labelACCcount.AutoSize = true;
            this.labelACCcount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.labelACCcount.Location = new System.Drawing.Point(335, 431);
            this.labelACCcount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelACCcount.Name = "labelACCcount";
            this.labelACCcount.Size = new System.Drawing.Size(40, 25);
            this.labelACCcount.TabIndex = 29;
            this.labelACCcount.Text = "{?}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label4.Location = new System.Drawing.Point(198, 431);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Total Accounts :";
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
            this.Column4,
            this.Column3});
            this.dataGridViewTeacher.Location = new System.Drawing.Point(5, 109);
            this.dataGridViewTeacher.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewTeacher.Name = "dataGridViewTeacher";
            this.dataGridViewTeacher.ReadOnly = true;
            this.dataGridViewTeacher.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewTeacher.RowHeadersWidth = 51;
            this.dataGridViewTeacher.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewTeacher.ShowCellErrors = false;
            this.dataGridViewTeacher.ShowEditingIcon = false;
            this.dataGridViewTeacher.ShowRowErrors = false;
            this.dataGridViewTeacher.Size = new System.Drawing.Size(780, 309);
            this.dataGridViewTeacher.TabIndex = 27;
            this.dataGridViewTeacher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTeacher_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "username";
            this.Column1.HeaderText = "UserName";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "password";
            this.Column2.HeaderText = "Password";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "role";
            this.Column4.HeaderText = "Role";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "owner";
            this.Column3.HeaderText = "Owner";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // textBoxAccsearch
            // 
            this.textBoxAccsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.textBoxAccsearch.Location = new System.Drawing.Point(183, 54);
            this.textBoxAccsearch.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxAccsearch.Name = "textBoxAccsearch";
            this.textBoxAccsearch.Size = new System.Drawing.Size(199, 30);
            this.textBoxAccsearch.TabIndex = 25;
            this.textBoxAccsearch.TextChanged += new System.EventHandler(this.textBoxAccsearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label6.Location = new System.Drawing.Point(73, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Account :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label7.Location = new System.Drawing.Point(8, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 36);
            this.label7.TabIndex = 23;
            this.label7.Text = "Search Account :";
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
            this.rjButton1.Location = new System.Drawing.Point(368, 39);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(5);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(70, 57);
            this.rjButton1.TabIndex = 26;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // UpdateAccTab
            // 
            this.UpdateAccTab.BackColor = System.Drawing.Color.White;
            this.UpdateAccTab.Controls.Add(this.UcomboAccRole);
            this.UpdateAccTab.Controls.Add(this.label2);
            this.UpdateAccTab.Controls.Add(this.UAccOwn);
            this.UpdateAccTab.Controls.Add(this.UAccPass);
            this.UpdateAccTab.Controls.Add(this.UAccUname);
            this.UpdateAccTab.Controls.Add(this.label8);
            this.UpdateAccTab.Controls.Add(this.label9);
            this.UpdateAccTab.Controls.Add(this.label10);
            this.UpdateAccTab.Controls.Add(this.label13);
            this.UpdateAccTab.Controls.Add(this.bthAccDelete);
            this.UpdateAccTab.Controls.Add(this.btnAccupdate);
            this.UpdateAccTab.Location = new System.Drawing.Point(4, 4);
            this.UpdateAccTab.Name = "UpdateAccTab";
            this.UpdateAccTab.Padding = new System.Windows.Forms.Padding(3);
            this.UpdateAccTab.Size = new System.Drawing.Size(790, 463);
            this.UpdateAccTab.TabIndex = 2;
            this.UpdateAccTab.Text = "Update & Delete Account";
            this.UpdateAccTab.Leave += new System.EventHandler(this.UpdateAccTab_Leave);
            // 
            // UcomboAccRole
            // 
            this.UcomboAccRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UcomboAccRole.FormattingEnabled = true;
            this.UcomboAccRole.Items.AddRange(new object[] {
            "Teacher",
            "Admin",
            "Others"});
            this.UcomboAccRole.Location = new System.Drawing.Point(311, 267);
            this.UcomboAccRole.Name = "UcomboAccRole";
            this.UcomboAccRole.Size = new System.Drawing.Size(157, 33);
            this.UcomboAccRole.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label2.Location = new System.Drawing.Point(235, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 60;
            this.label2.Text = "Role :";
            // 
            // UAccOwn
            // 
            this.UAccOwn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.UAccOwn.Location = new System.Drawing.Point(311, 207);
            this.UAccOwn.Margin = new System.Windows.Forms.Padding(5);
            this.UAccOwn.Name = "UAccOwn";
            this.UAccOwn.Size = new System.Drawing.Size(263, 30);
            this.UAccOwn.TabIndex = 59;
            // 
            // UAccPass
            // 
            this.UAccPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.UAccPass.Location = new System.Drawing.Point(311, 147);
            this.UAccPass.Margin = new System.Windows.Forms.Padding(5);
            this.UAccPass.Name = "UAccPass";
            this.UAccPass.Size = new System.Drawing.Size(263, 30);
            this.UAccPass.TabIndex = 58;
            // 
            // UAccUname
            // 
            this.UAccUname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.UAccUname.Location = new System.Drawing.Point(311, 87);
            this.UAccUname.Margin = new System.Windows.Forms.Padding(5);
            this.UAccUname.Name = "UAccUname";
            this.UAccUname.Size = new System.Drawing.Size(263, 30);
            this.UAccUname.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label8.Location = new System.Drawing.Point(221, 210);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 25);
            this.label8.TabIndex = 56;
            this.label8.Text = "Owner :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label9.Location = new System.Drawing.Point(195, 150);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 25);
            this.label9.TabIndex = 55;
            this.label9.Text = "Password :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label10.Location = new System.Drawing.Point(188, 90);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 25);
            this.label10.TabIndex = 54;
            this.label10.Text = "UserName :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label13.Location = new System.Drawing.Point(4, 5);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(403, 36);
            this.label13.TabIndex = 35;
            this.label13.Text = "Update Or Delete Account :";
            // 
            // bthAccDelete
            // 
            this.bthAccDelete.BackColor = System.Drawing.Color.Firebrick;
            this.bthAccDelete.BackgroundColor = System.Drawing.Color.Firebrick;
            this.bthAccDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bthAccDelete.BorderRadius = 20;
            this.bthAccDelete.BorderSize = 0;
            this.bthAccDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bthAccDelete.FlatAppearance.BorderSize = 0;
            this.bthAccDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bthAccDelete.ForeColor = System.Drawing.Color.White;
            this.bthAccDelete.Location = new System.Drawing.Point(432, 338);
            this.bthAccDelete.Margin = new System.Windows.Forms.Padding(5);
            this.bthAccDelete.Name = "bthAccDelete";
            this.bthAccDelete.Size = new System.Drawing.Size(142, 54);
            this.bthAccDelete.TabIndex = 47;
            this.bthAccDelete.Text = "Delete";
            this.bthAccDelete.TextColor = System.Drawing.Color.White;
            this.bthAccDelete.UseVisualStyleBackColor = false;
            this.bthAccDelete.Click += new System.EventHandler(this.bthAccDelete_Click);
            // 
            // btnAccupdate
            // 
            this.btnAccupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.btnAccupdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.btnAccupdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAccupdate.BorderRadius = 20;
            this.btnAccupdate.BorderSize = 0;
            this.btnAccupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccupdate.FlatAppearance.BorderSize = 0;
            this.btnAccupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccupdate.ForeColor = System.Drawing.Color.White;
            this.btnAccupdate.Location = new System.Drawing.Point(248, 338);
            this.btnAccupdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnAccupdate.Name = "btnAccupdate";
            this.btnAccupdate.Size = new System.Drawing.Size(142, 54);
            this.btnAccupdate.TabIndex = 46;
            this.btnAccupdate.Text = "Update";
            this.btnAccupdate.TextColor = System.Drawing.Color.White;
            this.btnAccupdate.UseVisualStyleBackColor = false;
            this.btnAccupdate.Click += new System.EventHandler(this.btnAccupdate_Click);
            // 
            // UserControlAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlAcc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserControlAccount";
            this.Size = new System.Drawing.Size(798, 501);
            this.tabControlAcc.ResumeLayout(false);
            this.AddAccTab.ResumeLayout(false);
            this.AddAccTab.PerformLayout();
            this.SearchAccTab.ResumeLayout(false);
            this.SearchAccTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacher)).EndInit();
            this.UpdateAccTab.ResumeLayout(false);
            this.UpdateAccTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAcc;
        private System.Windows.Forms.TabPage AddAccTab;
        private System.Windows.Forms.TabPage SearchAccTab;
        private System.Windows.Forms.TabPage UpdateAccTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAccOwn;
        private RJButton btnAccAdd;
        private System.Windows.Forms.TextBox textBoxAccPass;
        private System.Windows.Forms.TextBox textBoxAccName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAccRole;
        private System.Windows.Forms.ComboBox comboBoxAccSearchBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelACCcount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewTeacher;
        private System.Windows.Forms.TextBox textBoxAccsearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private RJButton rjButton1;
        private System.Windows.Forms.ComboBox UcomboAccRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UAccOwn;
        private System.Windows.Forms.TextBox UAccPass;
        private System.Windows.Forms.TextBox UAccUname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private RJButton bthAccDelete;
        private RJButton btnAccupdate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
