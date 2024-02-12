namespace StudentAttendanceSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelback = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mini = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.labelTime = new System.Windows.Forms.Label();
            this.paneltop = new System.Windows.Forms.Panel();
            this.labelrole = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnManageStud = new System.Windows.Forms.Button();
            this.buttonAccInfo = new System.Windows.Forms.Button();
            this.buttonTInfo = new System.Windows.Forms.Button();
            this.buttonCInfo = new System.Windows.Forms.Button();
            this.buttonAReport = new System.Windows.Forms.Button();
            this.buttonSInfo = new System.Windows.Forms.Button();
            this.buttonDash = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelslide = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Date_Time = new System.Windows.Forms.Timer(this.components);
            this.userControlTeacher1 = new StudentAttendanceSystem.User_Control.UserControlTeacher();
            this.userControlDash = new StudentAttendanceSystem.User_Control.UserControlDash();
            this.userControlAttReport1 = new StudentAttendanceSystem.User_Control.UserControlAttReport();
            this.userControlTeacher = new StudentAttendanceSystem.User_Control.UserControlTeacher();
            this.userControlClass1 = new StudentAttendanceSystem.User_Control.UserControlClass();
            this.userControlAccount1 = new StudentAttendanceSystem.User_Control.UserControlAccount();
            this.userControlStudentInfo1 = new StudentAttendanceSystem.User_Control.UserControlStudentInfo();
            this.userControlManageStudents1 = new StudentAttendanceSystem.User_Control.UserControlManageStudents();
            this.panelback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.paneltop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelback
            // 
            this.panelback.Controls.Add(this.pictureBox3);
            this.panelback.Controls.Add(this.pictureBox2);
            this.panelback.Controls.Add(this.panel3);
            this.panelback.Controls.Add(this.labelTime);
            this.panelback.Controls.Add(this.paneltop);
            this.panelback.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelback.Location = new System.Drawing.Point(448, 0);
            this.panelback.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.panelback.Name = "panelback";
            this.panelback.Size = new System.Drawing.Size(1108, 247);
            this.panelback.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(50, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(301, 86);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(401, 17);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.mini);
            this.panel3.Controls.Add(this.iconButton1);
            this.panel3.Location = new System.Drawing.Point(1152, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(124, 36);
            this.panel3.TabIndex = 6;
            // 
            // mini
            // 
            this.mini.BackColor = System.Drawing.Color.White;
            this.mini.Dock = System.Windows.Forms.DockStyle.Left;
            this.mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mini.ForeColor = System.Drawing.Color.Transparent;
            this.mini.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.mini.IconColor = System.Drawing.Color.Black;
            this.mini.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mini.IconSize = 20;
            this.mini.Location = new System.Drawing.Point(0, 0);
            this.mini.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mini.Name = "mini";
            this.mini.Size = new System.Drawing.Size(68, 36);
            this.mini.TabIndex = 7;
            this.mini.UseVisualStyleBackColor = false;
            this.mini.Click += new System.EventHandler(this.mini_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(56, 0);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(68, 36);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.labelTime.Location = new System.Drawing.Point(476, 26);
            this.labelTime.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(31, 20);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "{?}";
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.paneltop.Controls.Add(this.labelrole);
            this.paneltop.Controls.Add(this.labelname);
            this.paneltop.Controls.Add(this.label4);
            this.paneltop.Controls.Add(this.label3);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paneltop.Location = new System.Drawing.Point(0, 92);
            this.paneltop.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1108, 155);
            this.paneltop.TabIndex = 0;
            // 
            // labelrole
            // 
            this.labelrole.AutoSize = true;
            this.labelrole.BackColor = System.Drawing.Color.Transparent;
            this.labelrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelrole.ForeColor = System.Drawing.Color.White;
            this.labelrole.Location = new System.Drawing.Point(715, 62);
            this.labelrole.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelrole.Name = "labelrole";
            this.labelrole.Size = new System.Drawing.Size(31, 20);
            this.labelrole.TabIndex = 4;
            this.labelrole.Text = "{?}";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = System.Drawing.Color.Transparent;
            this.labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.ForeColor = System.Drawing.Color.White;
            this.labelname.Location = new System.Drawing.Point(239, 62);
            this.labelname.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(31, 20);
            this.labelname.TabIndex = 3;
            this.labelname.Text = "{?}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(587, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Role :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(67, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Welcome :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.panel1.Controls.Add(this.btnManageStud);
            this.panel1.Controls.Add(this.buttonAccInfo);
            this.panel1.Controls.Add(this.buttonTInfo);
            this.panel1.Controls.Add(this.buttonCInfo);
            this.panel1.Controls.Add(this.buttonAReport);
            this.panel1.Controls.Add(this.buttonSInfo);
            this.panel1.Controls.Add(this.buttonDash);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 884);
            this.panel1.TabIndex = 2;
            // 
            // btnManageStud
            // 
            this.btnManageStud.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageStud.FlatAppearance.BorderSize = 0;
            this.btnManageStud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageStud.ForeColor = System.Drawing.Color.White;
            this.btnManageStud.Image = ((System.Drawing.Image)(resources.GetObject("btnManageStud.Image")));
            this.btnManageStud.Location = new System.Drawing.Point(11, 823);
            this.btnManageStud.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnManageStud.Name = "btnManageStud";
            this.btnManageStud.Size = new System.Drawing.Size(437, 80);
            this.btnManageStud.TabIndex = 9;
            this.btnManageStud.Text = "      Manage Students";
            this.btnManageStud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageStud.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageStud.UseVisualStyleBackColor = true;
            this.btnManageStud.Click += new System.EventHandler(this.btnManageStud_Click);
            // 
            // buttonAccInfo
            // 
            this.buttonAccInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAccInfo.FlatAppearance.BorderSize = 0;
            this.buttonAccInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccInfo.ForeColor = System.Drawing.Color.White;
            this.buttonAccInfo.Image = ((System.Drawing.Image)(resources.GetObject("buttonAccInfo.Image")));
            this.buttonAccInfo.Location = new System.Drawing.Point(11, 743);
            this.buttonAccInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAccInfo.Name = "buttonAccInfo";
            this.buttonAccInfo.Size = new System.Drawing.Size(437, 80);
            this.buttonAccInfo.TabIndex = 8;
            this.buttonAccInfo.Text = "      Accounts Info";
            this.buttonAccInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAccInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAccInfo.UseVisualStyleBackColor = true;
            this.buttonAccInfo.Click += new System.EventHandler(this.buttonAccInfo_Click);
            // 
            // buttonTInfo
            // 
            this.buttonTInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTInfo.FlatAppearance.BorderSize = 0;
            this.buttonTInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTInfo.ForeColor = System.Drawing.Color.White;
            this.buttonTInfo.Image = ((System.Drawing.Image)(resources.GetObject("buttonTInfo.Image")));
            this.buttonTInfo.Location = new System.Drawing.Point(11, 663);
            this.buttonTInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTInfo.Name = "buttonTInfo";
            this.buttonTInfo.Size = new System.Drawing.Size(437, 80);
            this.buttonTInfo.TabIndex = 7;
            this.buttonTInfo.Text = "      Teachers Info";
            this.buttonTInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTInfo.UseVisualStyleBackColor = true;
            this.buttonTInfo.Click += new System.EventHandler(this.buttonTInfo_Click);
            // 
            // buttonCInfo
            // 
            this.buttonCInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCInfo.FlatAppearance.BorderSize = 0;
            this.buttonCInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCInfo.ForeColor = System.Drawing.Color.White;
            this.buttonCInfo.Image = ((System.Drawing.Image)(resources.GetObject("buttonCInfo.Image")));
            this.buttonCInfo.Location = new System.Drawing.Point(11, 583);
            this.buttonCInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCInfo.Name = "buttonCInfo";
            this.buttonCInfo.Size = new System.Drawing.Size(437, 80);
            this.buttonCInfo.TabIndex = 6;
            this.buttonCInfo.Text = "       Classes Info";
            this.buttonCInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCInfo.UseVisualStyleBackColor = true;
            this.buttonCInfo.Click += new System.EventHandler(this.buttonCInfo_Click);
            // 
            // buttonAReport
            // 
            this.buttonAReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAReport.FlatAppearance.BorderSize = 0;
            this.buttonAReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAReport.ForeColor = System.Drawing.Color.White;
            this.buttonAReport.Image = ((System.Drawing.Image)(resources.GetObject("buttonAReport.Image")));
            this.buttonAReport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAReport.Location = new System.Drawing.Point(11, 503);
            this.buttonAReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAReport.Name = "buttonAReport";
            this.buttonAReport.Size = new System.Drawing.Size(437, 80);
            this.buttonAReport.TabIndex = 5;
            this.buttonAReport.Text = "       Attendance Report";
            this.buttonAReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAReport.UseVisualStyleBackColor = true;
            this.buttonAReport.Click += new System.EventHandler(this.buttonAReport_Click);
            // 
            // buttonSInfo
            // 
            this.buttonSInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSInfo.FlatAppearance.BorderSize = 0;
            this.buttonSInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSInfo.ForeColor = System.Drawing.Color.White;
            this.buttonSInfo.Image = ((System.Drawing.Image)(resources.GetObject("buttonSInfo.Image")));
            this.buttonSInfo.Location = new System.Drawing.Point(11, 423);
            this.buttonSInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSInfo.Name = "buttonSInfo";
            this.buttonSInfo.Size = new System.Drawing.Size(437, 80);
            this.buttonSInfo.TabIndex = 4;
            this.buttonSInfo.Text = "      Student Info";
            this.buttonSInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSInfo.UseVisualStyleBackColor = true;
            this.buttonSInfo.Click += new System.EventHandler(this.buttonSInfo_Click);
            // 
            // buttonDash
            // 
            this.buttonDash.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDash.FlatAppearance.BorderSize = 0;
            this.buttonDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDash.ForeColor = System.Drawing.Color.White;
            this.buttonDash.Image = ((System.Drawing.Image)(resources.GetObject("buttonDash.Image")));
            this.buttonDash.Location = new System.Drawing.Point(11, 343);
            this.buttonDash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDash.Name = "buttonDash";
            this.buttonDash.Size = new System.Drawing.Size(437, 80);
            this.buttonDash.TabIndex = 3;
            this.buttonDash.Text = "      DashBoard";
            this.buttonDash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDash.UseVisualStyleBackColor = true;
            this.buttonDash.Click += new System.EventHandler(this.buttonDash_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panelslide);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 343);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(11, 541);
            this.panel4.TabIndex = 2;
            // 
            // panelslide
            // 
            this.panelslide.BackColor = System.Drawing.Color.White;
            this.panelslide.Location = new System.Drawing.Point(0, 0);
            this.panelslide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelslide.Name = "panelslide";
            this.panelslide.Size = new System.Drawing.Size(11, 80);
            this.panelslide.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 343);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 286);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Attendance System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(128, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Date_Time
            // 
            this.Date_Time.Tick += new System.EventHandler(this.Date_Time_Tick);
            // 
            // userControlTeacher1
            // 
            this.userControlTeacher1.AutoSize = true;
            this.userControlTeacher1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userControlTeacher1.BackColor = System.Drawing.Color.White;
            this.userControlTeacher1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlTeacher1.Location = new System.Drawing.Point(536, 263);
            this.userControlTeacher1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.userControlTeacher1.Name = "userControlTeacher1";
            this.userControlTeacher1.Size = new System.Drawing.Size(0, 0);
            this.userControlTeacher1.TabIndex = 0;
            // 
            // userControlDash
            // 
            this.userControlDash.AutoSize = true;
            this.userControlDash.BackColor = System.Drawing.Color.White;
            this.userControlDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlDash.Location = new System.Drawing.Point(461, 263);
            this.userControlDash.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.userControlDash.Name = "userControlDash";
            this.userControlDash.Size = new System.Drawing.Size(1254, 732);
            this.userControlDash.TabIndex = 4;
            // 
            // userControlAttReport1
            // 
            this.userControlAttReport1.BackColor = System.Drawing.Color.White;
            this.userControlAttReport1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlAttReport1.Location = new System.Drawing.Point(462, 263);
            this.userControlAttReport1.Margin = new System.Windows.Forms.Padding(7);
            this.userControlAttReport1.Name = "userControlAttReport1";
            this.userControlAttReport1.Size = new System.Drawing.Size(1253, 732);
            this.userControlAttReport1.TabIndex = 7;
            // 
            // userControlTeacher
            // 
            this.userControlTeacher.BackColor = System.Drawing.Color.White;
            this.userControlTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlTeacher.Location = new System.Drawing.Point(462, 263);
            this.userControlTeacher.Margin = new System.Windows.Forms.Padding(5);
            this.userControlTeacher.Name = "userControlTeacher";
            this.userControlTeacher.Size = new System.Drawing.Size(1235, 732);
            this.userControlTeacher.TabIndex = 5;
            // 
            // userControlClass1
            // 
            this.userControlClass1.BackColor = System.Drawing.Color.White;
            this.userControlClass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlClass1.Location = new System.Drawing.Point(462, 263);
            this.userControlClass1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.userControlClass1.Name = "userControlClass1";
            this.userControlClass1.Size = new System.Drawing.Size(1235, 733);
            this.userControlClass1.TabIndex = 0;
            this.userControlClass1.Visible = false;
            // 
            // userControlAccount1
            // 
            this.userControlAccount1.BackColor = System.Drawing.Color.White;
            this.userControlAccount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlAccount1.Location = new System.Drawing.Point(462, 262);
            this.userControlAccount1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.userControlAccount1.Name = "userControlAccount1";
            this.userControlAccount1.Size = new System.Drawing.Size(1235, 733);
            this.userControlAccount1.TabIndex = 0;
            // 
            // userControlStudentInfo1
            // 
            this.userControlStudentInfo1.BackColor = System.Drawing.Color.White;
            this.userControlStudentInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlStudentInfo1.Location = new System.Drawing.Point(462, 263);
            this.userControlStudentInfo1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.userControlStudentInfo1.Name = "userControlStudentInfo1";
            this.userControlStudentInfo1.Size = new System.Drawing.Size(1235, 683);
            this.userControlStudentInfo1.TabIndex = 6;
            // 
            // userControlManageStudents1
            // 
            this.userControlManageStudents1.BackColor = System.Drawing.Color.White;
            this.userControlManageStudents1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlManageStudents1.Location = new System.Drawing.Point(463, 263);
            this.userControlManageStudents1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.userControlManageStudents1.Name = "userControlManageStudents1";
            this.userControlManageStudents1.Size = new System.Drawing.Size(1244, 696);
            this.userControlManageStudents1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1556, 884);
            this.Controls.Add(this.panelback);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userControlTeacher1);
            this.Controls.Add(this.userControlDash);
            this.Controls.Add(this.userControlAttReport1);
            this.Controls.Add(this.userControlTeacher);
            this.Controls.Add(this.userControlClass1);
            this.Controls.Add(this.userControlAccount1);
            this.Controls.Add(this.userControlStudentInfo1);
            this.Controls.Add(this.userControlManageStudents1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelback.ResumeLayout(false);
            this.panelback.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelback;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label labelrole;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton mini;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelslide;
        private System.Windows.Forms.Button buttonDash;
        private System.Windows.Forms.Button buttonSInfo;
        private System.Windows.Forms.Button buttonAReport;
        private System.Windows.Forms.Button buttonCInfo;
        private System.Windows.Forms.Button buttonAccInfo;
        private System.Windows.Forms.Button buttonTInfo;
        private System.Windows.Forms.Timer Date_Time;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private User_Control.UserControlClass userControlClass1;
        private User_Control.UserControlTeacher userControlTeacher1;
        private User_Control.UserControlAccount userControlAccount1;
        private User_Control.UserControlDash userControlDash;
        private User_Control.UserControlTeacher userControlTeacher;
        private User_Control.UserControlStudentInfo userControlStudentInfo1;
        private User_Control.UserControlAttReport userControlAttReport1;
        private User_Control.UserControlManageStudents userControlManageStudents1;
        private System.Windows.Forms.Button btnManageStud;
    }
}