namespace StudentAttendanceSystem
{
    partial class StudentCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentCard));
            this.Qrbox = new System.Windows.Forms.PictureBox();
            this.ExitCard = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblContac = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnEnrollForm = new StudentAttendanceSystem.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.card_print = new StudentAttendanceSystem.RJButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Qrbox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Qrbox
            // 
            this.Qrbox.Location = new System.Drawing.Point(59, 67);
            this.Qrbox.Margin = new System.Windows.Forms.Padding(4);
            this.Qrbox.Name = "Qrbox";
            this.Qrbox.Size = new System.Drawing.Size(187, 181);
            this.Qrbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Qrbox.TabIndex = 0;
            this.Qrbox.TabStop = false;
            // 
            // ExitCard
            // 
            this.ExitCard.BackColor = System.Drawing.Color.Transparent;
            this.ExitCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitCard.ForeColor = System.Drawing.Color.Transparent;
            this.ExitCard.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.ExitCard.IconColor = System.Drawing.Color.Black;
            this.ExitCard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExitCard.IconSize = 20;
            this.ExitCard.Location = new System.Drawing.Point(9, 8);
            this.ExitCard.Margin = new System.Windows.Forms.Padding(4);
            this.ExitCard.Name = "ExitCard";
            this.ExitCard.Size = new System.Drawing.Size(45, 30);
            this.ExitCard.TabIndex = 7;
            this.ExitCard.UseVisualStyleBackColor = false;
            this.ExitCard.Click += new System.EventHandler(this.ExitCard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SandyBrown;
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 39);
            this.label1.TabIndex = 18;
            this.label1.Text = "Student Card";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SandyBrown;
            this.label2.Location = new System.Drawing.Point(60, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Student ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SandyBrown;
            this.label4.Location = new System.Drawing.Point(60, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Student Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SandyBrown;
            this.label5.Location = new System.Drawing.Point(60, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 29);
            this.label5.TabIndex = 24;
            this.label5.Text = "Date Of Birth :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SandyBrown;
            this.label6.Location = new System.Drawing.Point(60, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 29);
            this.label6.TabIndex = 25;
            this.label6.Text = "Father Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SandyBrown;
            this.label7.Location = new System.Drawing.Point(60, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 29);
            this.label7.TabIndex = 26;
            this.label7.Text = "Contact Info :";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.White;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblID.Location = new System.Drawing.Point(285, 67);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(111, 29);
            this.lblID.TabIndex = 27;
            this.lblID.Text = "_______";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblName.Location = new System.Drawing.Point(285, 107);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(111, 29);
            this.lblName.TabIndex = 28;
            this.lblName.Text = "_______";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.BackColor = System.Drawing.Color.White;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblDOB.Location = new System.Drawing.Point(285, 145);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(111, 29);
            this.lblDOB.TabIndex = 29;
            this.lblDOB.Text = "_______";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.BackColor = System.Drawing.Color.White;
            this.lblFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblFname.Location = new System.Drawing.Point(285, 182);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(111, 29);
            this.lblFname.TabIndex = 30;
            this.lblFname.Text = "_______";
            // 
            // lblContac
            // 
            this.lblContac.AutoSize = true;
            this.lblContac.BackColor = System.Drawing.Color.White;
            this.lblContac.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContac.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblContac.Location = new System.Drawing.Point(285, 219);
            this.lblContac.Name = "lblContac";
            this.lblContac.Size = new System.Drawing.Size(111, 29);
            this.lblContac.TabIndex = 31;
            this.lblContac.Text = "_______";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SandyBrown;
            this.label3.Location = new System.Drawing.Point(170, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 29);
            this.label3.TabIndex = 32;
            this.label3.Text = "Enroll Class :";
            // 
            // BtnEnrollForm
            // 
            this.BtnEnrollForm.BackColor = System.Drawing.Color.SandyBrown;
            this.BtnEnrollForm.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.BtnEnrollForm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnEnrollForm.BorderRadius = 20;
            this.BtnEnrollForm.BorderSize = 0;
            this.BtnEnrollForm.FlatAppearance.BorderSize = 0;
            this.BtnEnrollForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnrollForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnrollForm.ForeColor = System.Drawing.Color.White;
            this.BtnEnrollForm.Location = new System.Drawing.Point(381, 288);
            this.BtnEnrollForm.Name = "BtnEnrollForm";
            this.BtnEnrollForm.Size = new System.Drawing.Size(122, 47);
            this.BtnEnrollForm.TabIndex = 33;
            this.BtnEnrollForm.Text = "Enroll";
            this.BtnEnrollForm.TextColor = System.Drawing.Color.White;
            this.BtnEnrollForm.UseVisualStyleBackColor = false;
            this.BtnEnrollForm.Click += new System.EventHandler(this.BtnEnrollForm_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Qrbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(560, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 356);
            this.panel1.TabIndex = 34;
            // 
            // card_print
            // 
            this.card_print.BackColor = System.Drawing.Color.Snow;
            this.card_print.BackgroundColor = System.Drawing.Color.Snow;
            this.card_print.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.card_print.BorderRadius = 20;
            this.card_print.BorderSize = 0;
            this.card_print.FlatAppearance.BorderSize = 0;
            this.card_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.card_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card_print.ForeColor = System.Drawing.Color.White;
            this.card_print.Image = ((System.Drawing.Image)(resources.GetObject("card_print.Image")));
            this.card_print.Location = new System.Drawing.Point(12, 293);
            this.card_print.Name = "card_print";
            this.card_print.Size = new System.Drawing.Size(85, 47);
            this.card_print.TabIndex = 35;
            this.card_print.TextColor = System.Drawing.Color.White;
            this.card_print.UseVisualStyleBackColor = false;
            this.card_print.Click += new System.EventHandler(this.card_print_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // StudentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(848, 356);
            this.Controls.Add(this.card_print);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnEnrollForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblContac);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitCard);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentCard";
            this.Load += new System.EventHandler(this.StudentCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Qrbox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Qrbox;
        private FontAwesome.Sharp.IconButton ExitCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblContac;
        private System.Windows.Forms.Label label3;
        private RJButton BtnEnrollForm;
        private System.Windows.Forms.Panel panel1;
        private RJButton card_print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}