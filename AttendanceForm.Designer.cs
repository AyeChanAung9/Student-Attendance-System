namespace StudentAttendanceSystem
{
    partial class AttendanceForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnScanQR = new StudentAttendanceSystem.RJButton();
            this.btnCamOpn = new StudentAttendanceSystem.RJButton();
            this.camera = new System.Windows.Forms.PictureBox();
            this.comboCam = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.showyeartxt = new System.Windows.Forms.Label();
            this.showcontactxt = new System.Windows.Forms.Label();
            this.showfnametxt = new System.Windows.Forms.Label();
            this.showdobtxt = new System.Windows.Forms.Label();
            this.shownametxt = new System.Windows.Forms.Label();
            this.showidtxt = new System.Windows.Forms.Label();
            this.comboBoxMarkClass = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAttTime = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnbacktomain = new StudentAttendanceSystem.RJButton();
            this.BtnMarkAttendance = new StudentAttendanceSystem.RJButton();
            this.date_text = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.camera)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnScanQR);
            this.panel1.Controls.Add(this.btnCamOpn);
            this.panel1.Controls.Add(this.camera);
            this.panel1.Controls.Add(this.comboCam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 613);
            this.panel1.TabIndex = 0;
            // 
            // btnScanQR
            // 
            this.btnScanQR.BackColor = System.Drawing.Color.CadetBlue;
            this.btnScanQR.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.btnScanQR.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnScanQR.BorderRadius = 20;
            this.btnScanQR.BorderSize = 0;
            this.btnScanQR.FlatAppearance.BorderSize = 0;
            this.btnScanQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScanQR.ForeColor = System.Drawing.Color.White;
            this.btnScanQR.Location = new System.Drawing.Point(75, 432);
            this.btnScanQR.Name = "btnScanQR";
            this.btnScanQR.Size = new System.Drawing.Size(186, 80);
            this.btnScanQR.TabIndex = 3;
            this.btnScanQR.Text = "ScanQR";
            this.btnScanQR.TextColor = System.Drawing.Color.White;
            this.btnScanQR.UseVisualStyleBackColor = false;
            this.btnScanQR.Click += new System.EventHandler(this.btnScanQR_Click);
            // 
            // btnCamOpn
            // 
            this.btnCamOpn.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCamOpn.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.btnCamOpn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCamOpn.BorderRadius = 20;
            this.btnCamOpn.BorderSize = 0;
            this.btnCamOpn.FlatAppearance.BorderSize = 0;
            this.btnCamOpn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamOpn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCamOpn.ForeColor = System.Drawing.Color.White;
            this.btnCamOpn.Location = new System.Drawing.Point(62, 328);
            this.btnCamOpn.Name = "btnCamOpn";
            this.btnCamOpn.Size = new System.Drawing.Size(213, 80);
            this.btnCamOpn.TabIndex = 2;
            this.btnCamOpn.Text = "OpenCamera";
            this.btnCamOpn.TextColor = System.Drawing.Color.White;
            this.btnCamOpn.UseVisualStyleBackColor = false;
            this.btnCamOpn.Click += new System.EventHandler(this.btnCamOpn_Click);
            // 
            // camera
            // 
            this.camera.Location = new System.Drawing.Point(12, 58);
            this.camera.Name = "camera";
            this.camera.Size = new System.Drawing.Size(300, 250);
            this.camera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.camera.TabIndex = 1;
            this.camera.TabStop = false;
            // 
            // comboCam
            // 
            this.comboCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCam.FormattingEnabled = true;
            this.comboCam.Location = new System.Drawing.Point(12, 12);
            this.comboCam.Name = "comboCam";
            this.comboCam.Size = new System.Drawing.Size(300, 37);
            this.comboCam.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.CadetBlue;
            this.label7.Location = new System.Drawing.Point(376, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 29);
            this.label7.TabIndex = 36;
            this.label7.Text = "Contact Info :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.CadetBlue;
            this.label6.Location = new System.Drawing.Point(366, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 29);
            this.label6.TabIndex = 35;
            this.label6.Text = "Father Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CadetBlue;
            this.label5.Location = new System.Drawing.Point(364, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 29);
            this.label5.TabIndex = 34;
            this.label5.Text = "Date Of Birth :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CadetBlue;
            this.label4.Location = new System.Drawing.Point(349, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 29);
            this.label4.TabIndex = 33;
            this.label4.Text = "Student Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CadetBlue;
            this.label3.Location = new System.Drawing.Point(435, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 29);
            this.label3.TabIndex = 32;
            this.label3.Text = "Roll No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(392, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "Student ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(557, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 39);
            this.label1.TabIndex = 41;
            this.label1.Text = "Student Attendance Info";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.CadetBlue;
            this.label8.Location = new System.Drawing.Point(337, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 29);
            this.label8.TabIndex = 43;
            this.label8.Text = "Academic Year :";
            // 
            // showyeartxt
            // 
            this.showyeartxt.AutoSize = true;
            this.showyeartxt.BackColor = System.Drawing.Color.White;
            this.showyeartxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showyeartxt.ForeColor = System.Drawing.Color.CadetBlue;
            this.showyeartxt.Location = new System.Drawing.Point(586, 413);
            this.showyeartxt.Name = "showyeartxt";
            this.showyeartxt.Size = new System.Drawing.Size(111, 29);
            this.showyeartxt.TabIndex = 51;
            this.showyeartxt.Text = "_______";
            // 
            // showcontactxt
            // 
            this.showcontactxt.AutoSize = true;
            this.showcontactxt.BackColor = System.Drawing.Color.White;
            this.showcontactxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showcontactxt.ForeColor = System.Drawing.Color.CadetBlue;
            this.showcontactxt.Location = new System.Drawing.Point(578, 350);
            this.showcontactxt.Name = "showcontactxt";
            this.showcontactxt.Size = new System.Drawing.Size(111, 29);
            this.showcontactxt.TabIndex = 50;
            this.showcontactxt.Text = "_______";
            // 
            // showfnametxt
            // 
            this.showfnametxt.AutoSize = true;
            this.showfnametxt.BackColor = System.Drawing.Color.White;
            this.showfnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showfnametxt.ForeColor = System.Drawing.Color.CadetBlue;
            this.showfnametxt.Location = new System.Drawing.Point(584, 288);
            this.showfnametxt.Name = "showfnametxt";
            this.showfnametxt.Size = new System.Drawing.Size(111, 29);
            this.showfnametxt.TabIndex = 49;
            this.showfnametxt.Text = "_______";
            // 
            // showdobtxt
            // 
            this.showdobtxt.AutoSize = true;
            this.showdobtxt.BackColor = System.Drawing.Color.White;
            this.showdobtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showdobtxt.ForeColor = System.Drawing.Color.CadetBlue;
            this.showdobtxt.Location = new System.Drawing.Point(586, 234);
            this.showdobtxt.Name = "showdobtxt";
            this.showdobtxt.Size = new System.Drawing.Size(111, 29);
            this.showdobtxt.TabIndex = 48;
            this.showdobtxt.Text = "_______";
            // 
            // shownametxt
            // 
            this.shownametxt.AutoSize = true;
            this.shownametxt.BackColor = System.Drawing.Color.White;
            this.shownametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shownametxt.ForeColor = System.Drawing.Color.CadetBlue;
            this.shownametxt.Location = new System.Drawing.Point(585, 176);
            this.shownametxt.Name = "shownametxt";
            this.shownametxt.Size = new System.Drawing.Size(111, 29);
            this.shownametxt.TabIndex = 47;
            this.shownametxt.Text = "_______";
            // 
            // showidtxt
            // 
            this.showidtxt.AutoSize = true;
            this.showidtxt.BackColor = System.Drawing.Color.White;
            this.showidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showidtxt.ForeColor = System.Drawing.Color.CadetBlue;
            this.showidtxt.Location = new System.Drawing.Point(580, 100);
            this.showidtxt.Name = "showidtxt";
            this.showidtxt.Size = new System.Drawing.Size(111, 29);
            this.showidtxt.TabIndex = 45;
            this.showidtxt.Text = "_______";
            // 
            // comboBoxMarkClass
            // 
            this.comboBoxMarkClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMarkClass.ForeColor = System.Drawing.Color.SandyBrown;
            this.comboBoxMarkClass.FormattingEnabled = true;
            this.comboBoxMarkClass.Location = new System.Drawing.Point(902, 168);
            this.comboBoxMarkClass.Name = "comboBoxMarkClass";
            this.comboBoxMarkClass.Size = new System.Drawing.Size(470, 37);
            this.comboBoxMarkClass.TabIndex = 53;
            this.comboBoxMarkClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarkClass_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SandyBrown;
            this.label9.Location = new System.Drawing.Point(896, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(389, 29);
            this.label9.TabIndex = 52;
            this.label9.Text = "Select Class to Mark Attendance";
            // 
            // lblAttTime
            // 
            this.lblAttTime.AutoSize = true;
            this.lblAttTime.BackColor = System.Drawing.Color.White;
            this.lblAttTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttTime.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblAttTime.Location = new System.Drawing.Point(974, 306);
            this.lblAttTime.Name = "lblAttTime";
            this.lblAttTime.Size = new System.Drawing.Size(46, 29);
            this.lblAttTime.TabIndex = 55;
            this.lblAttTime.Text = "{?}";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SandyBrown;
            this.label10.Location = new System.Drawing.Point(974, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(236, 29);
            this.label10.TabIndex = 54;
            this.label10.Text = "Time for The Class";
            // 
            // btnbacktomain
            // 
            this.btnbacktomain.BackColor = System.Drawing.Color.Silver;
            this.btnbacktomain.BackgroundColor = System.Drawing.Color.Silver;
            this.btnbacktomain.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnbacktomain.BorderRadius = 20;
            this.btnbacktomain.BorderSize = 0;
            this.btnbacktomain.FlatAppearance.BorderSize = 0;
            this.btnbacktomain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbacktomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbacktomain.ForeColor = System.Drawing.Color.White;
            this.btnbacktomain.Location = new System.Drawing.Point(941, 488);
            this.btnbacktomain.Name = "btnbacktomain";
            this.btnbacktomain.Size = new System.Drawing.Size(186, 80);
            this.btnbacktomain.TabIndex = 42;
            this.btnbacktomain.Text = "Home";
            this.btnbacktomain.TextColor = System.Drawing.Color.White;
            this.btnbacktomain.UseVisualStyleBackColor = false;
            this.btnbacktomain.Click += new System.EventHandler(this.btnbacktomain_Click);
            // 
            // BtnMarkAttendance
            // 
            this.BtnMarkAttendance.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnMarkAttendance.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.BtnMarkAttendance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnMarkAttendance.BorderRadius = 20;
            this.BtnMarkAttendance.BorderSize = 0;
            this.BtnMarkAttendance.FlatAppearance.BorderSize = 0;
            this.BtnMarkAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMarkAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMarkAttendance.ForeColor = System.Drawing.Color.White;
            this.BtnMarkAttendance.Location = new System.Drawing.Point(602, 488);
            this.BtnMarkAttendance.Name = "BtnMarkAttendance";
            this.BtnMarkAttendance.Size = new System.Drawing.Size(229, 80);
            this.BtnMarkAttendance.TabIndex = 4;
            this.BtnMarkAttendance.Text = "Mark Attendance";
            this.BtnMarkAttendance.TextColor = System.Drawing.Color.White;
            this.BtnMarkAttendance.UseVisualStyleBackColor = false;
            this.BtnMarkAttendance.Click += new System.EventHandler(this.BtnMarkAttendance_Click);
            // 
            // date_text
            // 
            this.date_text.AutoSize = true;
            this.date_text.BackColor = System.Drawing.Color.White;
            this.date_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_text.ForeColor = System.Drawing.Color.SandyBrown;
            this.date_text.Location = new System.Drawing.Point(1083, 22);
            this.date_text.Name = "date_text";
            this.date_text.Size = new System.Drawing.Size(31, 20);
            this.date_text.TabIndex = 56;
            this.date_text.Text = "{?}";
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 613);
            this.Controls.Add(this.date_text);
            this.Controls.Add(this.BtnMarkAttendance);
            this.Controls.Add(this.lblAttTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxMarkClass);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.showyeartxt);
            this.Controls.Add(this.showcontactxt);
            this.Controls.Add(this.showfnametxt);
            this.Controls.Add(this.showdobtxt);
            this.Controls.Add(this.shownametxt);
            this.Controls.Add(this.showidtxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnbacktomain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AttendanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttendanceForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AttendanceForm_FormClosing);
            this.Load += new System.EventHandler(this.AttendanceForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.camera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox camera;
        private System.Windows.Forms.ComboBox comboCam;
        private RJButton btnCamOpn;
        private RJButton btnScanQR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private RJButton btnbacktomain;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label showyeartxt;
        private System.Windows.Forms.Label showcontactxt;
        private System.Windows.Forms.Label showfnametxt;
        private System.Windows.Forms.Label showdobtxt;
        private System.Windows.Forms.Label shownametxt;
        private System.Windows.Forms.Label showidtxt;
        private System.Windows.Forms.ComboBox comboBoxMarkClass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAttTime;
        private System.Windows.Forms.Label label10;
        private RJButton BtnMarkAttendance;
        private System.Windows.Forms.Label date_text;
    }
}