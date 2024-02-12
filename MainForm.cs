using System;
using System.Runtime.InteropServices;//for rounded corner
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
using StudentAttendanceSystem.User_Control;

namespace StudentAttendanceSystem
{
    public partial class MainForm : Form
    {
        public string username, pass;
        //Database Connection
        public static readonly string con_string = "Data Source=AyeChanAung-PC;Initial Catalog=attendance_System;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(con_string);


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]//for rounded corner
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public MainForm()
        {
            InitializeComponent();
            Date_Time.Start();
            //for rounded corner
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //for rounded corner
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            labelname.Text = username;
            
            string qry = @"Select * from account_table where username ='" + username + "' and password ='" + pass + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                labelrole.Text = dr["role"].ToString();

            }
            con.Close();


            if (labelrole.Text == "Teacher")
            { 
                buttonDash.Hide();
                buttonTInfo.Hide();
                buttonAccInfo.Hide();
                
            }

        }

        private void mini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Date_Time_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString("F");
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do You want to Log out ?", "Log Out", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Date_Time.Stop();
                this.Hide();
                WelcomeForm wf = new WelcomeForm();
                wf.Show();
            }
            
        }

        private void buttonDash_Click(object sender, EventArgs e)
        {
            moveSidePanel(buttonDash);
            userControlDash.count();
            userControlDash.Visible = true;

            userControlClass1.Visible = false;
            userControlTeacher.Visible = false;
            userControlAccount1.Visible = false;
            userControlStudentInfo1.Visible = false;
            userControlAttReport1.Visible = false;
            userControlManageStudents1.Visible = false;

        }

        private void buttonSInfo_Click(object sender, EventArgs e)
        {
            moveSidePanel(buttonSInfo);
            userControlStudentInfo1.Visible = true;

            userControlDash.Visible = false;
            userControlClass1.Visible = false;
            userControlTeacher.Visible = false;
            userControlAccount1.Visible = false;
            userControlAttReport1.Visible = false;
            userControlManageStudents1.Visible = false;
        }

        private void buttonAReport_Click(object sender, EventArgs e)
        {
            moveSidePanel(buttonAReport);
            userControlAttReport1.Visible = true;

            userControlDash.Visible = false;
            userControlClass1.Visible = false;
            userControlTeacher.Visible = false;
            userControlAccount1.Visible = false;
            userControlStudentInfo1.Visible = false;
            userControlManageStudents1.Visible = false;
        }

        private void buttonCInfo_Click(object sender, EventArgs e)
        {
            moveSidePanel(buttonCInfo);
            userControlClass1.clear_textbox_add();
            userControlClass1.Visible = true;

            userControlDash.Visible = false;
            userControlTeacher.Visible = false;
            userControlAccount1.Visible = false;
            userControlStudentInfo1.Visible = false;
            userControlAttReport1.Visible = false;
            userControlManageStudents1.Visible = false;
        }

        private void buttonTInfo_Click(object sender, EventArgs e)
        {
            moveSidePanel(buttonTInfo);
            userControlTeacher.clear_textbox_add();
            userControlTeacher.Visible = true;

            userControlDash.Visible = false;
            userControlClass1.Visible = false;
            userControlAccount1.Visible = false;
            userControlStudentInfo1.Visible = false;
            userControlAttReport1.Visible = false;
            userControlManageStudents1.Visible = false;
        }

        private void buttonAccInfo_Click(object sender, EventArgs e)
        {
            moveSidePanel(buttonAccInfo);
            userControlAccount1.clear_textbox_add();
            userControlAccount1.Visible = true;

            userControlDash.Visible = false;
            userControlClass1.Visible = false;
            userControlTeacher.Visible = false;
            userControlStudentInfo1.Visible = false;
            userControlAttReport1.Visible = false;
            userControlManageStudents1.Visible = false;
        }

        private void btnManageStud_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnManageStud);
            userControlManageStudents1.Visible = true;

            userControlAccount1.Visible = false;
            userControlDash.Visible = false;
            userControlClass1.Visible = false;
            userControlTeacher.Visible = false;
            userControlStudentInfo1.Visible = false;
            userControlAttReport1.Visible = false;
        }

        private void moveSidePanel(Control button)
        { 
            panelslide.Location = new Point(button.Location.X - button.Location.X, button.Location.Y - 343);
        }
    }
}
