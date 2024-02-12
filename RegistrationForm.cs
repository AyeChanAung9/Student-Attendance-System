using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentAttendanceSystem
{
    public partial class RegistrationForm : Form
    {
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

        //Database Connection
        public static readonly string con_string = "Data Source=AyeChanAung-PC;Initial Catalog=attendance_System;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(con_string);
        public static SqlCommand cmd;

        public RegistrationForm()
        {
            InitializeComponent();
            //for rounded corner
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //for rounded corner
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeForm wf = new WelcomeForm();
            wf.Show();
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            string qry = @"insert into student_info_table values ('" + SIDtxt.Text + "','" + Snametxt.Text + "','" + SDOBtxt.Text + "','" + SFnametxt.Text + "','" + Scontactxt.Text + "','" + SYeartxt.Text +"')";
            con.Open();
            try 
            {
                cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Register Successfully");

                this.Hide();
                StudentCard sc = new StudentCard();
                sc.Id = SIDtxt.Text;
                sc.sName = Snametxt.Text;
                sc.DOB = SDOBtxt.Text;
                sc.Fname = SFnametxt.Text;
                sc.Cont = Scontactxt.Text;
                sc.Show();
            }
            catch (Exception ex)
            {
                if (ex is SqlException sqlEx)
                {
                    MessageBox.Show("Student with this ID already exists. Please confirm your ID at Student Council.");
                }
                else
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            con.Close();
            

            

        }
    }
}
