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

namespace StudentAttendanceSystem
{
    public partial class EnrollForm : Form
    {
        public string eId { get; set; }
        public string eName { get; set; }

        public int ind;

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

        public EnrollForm()
        {
            InitializeComponent();
            //for rounded corner
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //for rounded corner
        }

        private void EnrollForm_Load(object sender, EventArgs e)
        {
            lbleid.Text = eId;
            lblename.Text = eName;

            string qry = @"Select classname,time from classes_table";
            cmd = new SqlCommand(qry, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxSelectClass.DataSource = dt;
            comboBoxSelectClass.ValueMember = "classname";

            lblshowEtime.Text = dt.Rows[ind]["time"].ToString();

        }

        private void comboBoxSelectClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qry = @"Select classname,time from classes_table";
            cmd = new SqlCommand(qry, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            ind = comboBoxSelectClass.SelectedIndex;
            lblshowEtime.Text = dt.Rows[ind]["time"].ToString();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeForm wf = new WelcomeForm();
            wf.Show();
        }

        private void EnrollBtn_Click(object sender, EventArgs e)
        {
            string qry = @"insert into enrollment_table values ('" + lbleid.Text + "','" + lblename.Text + "','" + comboBoxSelectClass.Text + "','" + lblshowEtime.Text + "')";
            con.Open();
            cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Class Enroll Successfully");
            con.Close();
        }
    }
}
