namespace StudentAttendanceSystem
{
    partial class EnrollForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnrollForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblename = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbleid = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSelectClass = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblshowEtime = new System.Windows.Forms.Label();
            this.rjButton1 = new StudentAttendanceSystem.RJButton();
            this.EnrollBtn = new StudentAttendanceSystem.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 613);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 591);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SandyBrown;
            this.label2.Location = new System.Drawing.Point(549, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Welcome ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SandyBrown;
            this.label1.Location = new System.Drawing.Point(672, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 39);
            this.label1.TabIndex = 22;
            this.label1.Text = "Enroll Classes Form";
            // 
            // lblename
            // 
            this.lblename.AutoSize = true;
            this.lblename.BackColor = System.Drawing.Color.White;
            this.lblename.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblename.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblename.Location = new System.Drawing.Point(695, 82);
            this.lblename.Name = "lblename";
            this.lblename.Size = new System.Drawing.Size(46, 29);
            this.lblename.TabIndex = 23;
            this.lblename.Text = "{?}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SandyBrown;
            this.label3.Location = new System.Drawing.Point(641, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "Student ID :";
            // 
            // lbleid
            // 
            this.lbleid.AutoSize = true;
            this.lbleid.BackColor = System.Drawing.Color.White;
            this.lbleid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleid.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbleid.Location = new System.Drawing.Point(809, 139);
            this.lbleid.Name = "lbleid";
            this.lbleid.Size = new System.Drawing.Size(46, 29);
            this.lbleid.TabIndex = 25;
            this.lbleid.Text = "{?}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SandyBrown;
            this.label4.Location = new System.Drawing.Point(549, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Select Classes to Enroll";
            // 
            // comboBoxSelectClass
            // 
            this.comboBoxSelectClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectClass.ForeColor = System.Drawing.Color.SandyBrown;
            this.comboBoxSelectClass.FormattingEnabled = true;
            this.comboBoxSelectClass.Location = new System.Drawing.Point(908, 205);
            this.comboBoxSelectClass.Name = "comboBoxSelectClass";
            this.comboBoxSelectClass.Size = new System.Drawing.Size(250, 37);
            this.comboBoxSelectClass.TabIndex = 27;
            this.comboBoxSelectClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectClass_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SandyBrown;
            this.label5.Location = new System.Drawing.Point(610, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 29);
            this.label5.TabIndex = 28;
            this.label5.Text = "Time for this Class";
            // 
            // lblshowEtime
            // 
            this.lblshowEtime.AutoSize = true;
            this.lblshowEtime.BackColor = System.Drawing.Color.White;
            this.lblshowEtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshowEtime.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblshowEtime.Location = new System.Drawing.Point(895, 297);
            this.lblshowEtime.Name = "lblshowEtime";
            this.lblshowEtime.Size = new System.Drawing.Size(46, 29);
            this.lblshowEtime.TabIndex = 29;
            this.lblshowEtime.Text = "{?}";
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Silver;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Silver;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(883, 454);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(196, 93);
            this.rjButton1.TabIndex = 33;
            this.rjButton1.Text = "Home";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // EnrollBtn
            // 
            this.EnrollBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.EnrollBtn.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.EnrollBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.EnrollBtn.BorderRadius = 20;
            this.EnrollBtn.BorderSize = 0;
            this.EnrollBtn.FlatAppearance.BorderSize = 0;
            this.EnrollBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnrollBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnrollBtn.ForeColor = System.Drawing.Color.White;
            this.EnrollBtn.Location = new System.Drawing.Point(646, 454);
            this.EnrollBtn.Name = "EnrollBtn";
            this.EnrollBtn.Size = new System.Drawing.Size(194, 93);
            this.EnrollBtn.TabIndex = 32;
            this.EnrollBtn.Text = "Enroll";
            this.EnrollBtn.TextColor = System.Drawing.Color.White;
            this.EnrollBtn.UseVisualStyleBackColor = false;
            this.EnrollBtn.Click += new System.EventHandler(this.EnrollBtn_Click);
            // 
            // EnrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1244, 613);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.EnrollBtn);
            this.Controls.Add(this.lblshowEtime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxSelectClass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbleid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EnrollForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnrollForm";
            this.Load += new System.EventHandler(this.EnrollForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbleid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSelectClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblshowEtime;
        private RJButton rjButton1;
        private RJButton EnrollBtn;
    }
}