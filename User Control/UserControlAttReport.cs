using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAttendanceSystem.User_Control
{
    public partial class UserControlAttReport : UserControl
    {
        //Database Connection
        public static readonly string con_string = "Data Source=AyeChanAung-PC;Initial Catalog=attendance_System;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(con_string);
        public static SqlCommand cmd;
        public UserControlAttReport()
        {
            InitializeComponent();
        }

        private void UserControlAttReport_Load(object sender, EventArgs e)
        {
            string ser = "Select * from attendance_table";
            Attendance.Attendance.DisplayAndSearchAllData(ser, dataGridViewAttR, con_string);
            //dataGridViewClass.Columns[0].Visible = false;

            string qry = @"Select aname,aclass,adate from attendance_table";
            cmd = new SqlCommand(qry, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataRow irow = dt.NewRow();
            irow[0] = "Select Name";
            irow[1] = "";
            irow[2] = "Select Date";
            dt.Rows.InsertAt(irow, 0);

            comboBoxAttDate.DataSource = dt;
            comboBoxAttDate.ValueMember = "adate";

            comboBoxAttName.DataSource = dt;
            comboBoxAttName.ValueMember = "aname";

            comboBoxAttClass.DataSource = dt;
            comboBoxAttClass.ValueMember = "aclass";
        }

        private void comboBoxAttDate_TextChanged(object sender, EventArgs e)
        {
            string s = "Select * from attendance_table where adate LIKE'%" + comboBoxAttDate.Text + "%'; ";
            Attendance.Attendance.DisplayAndSearchAllData(s, dataGridViewAttR, con_string);
            lblPresent.Text = dataGridViewAttR.Rows.Count.ToString();
        }

        private void comboBoxAttName_TextChanged(object sender, EventArgs e)
        {
            string s = "Select * from attendance_table where aname LIKE'%" + comboBoxAttName.Text + "%'; ";
            Attendance.Attendance.DisplayAndSearchAllData(s, dataGridViewAttR, con_string);
            
        }

        private void comboBoxAttClass_TextChanged(object sender, EventArgs e)
        {
            string s = "Select * from attendance_table where aclass LIKE'%" + comboBoxAttClass.Text + "%'; ";
            Attendance.Attendance.DisplayAndSearchAllData(s, dataGridViewAttR, con_string);
            
        }

        private void btnAttSearch_Click(object sender, EventArgs e)
        {
            string s = "Select * from attendance_table where adate = '" + comboBoxAttDate.Text + "' OR aname = '" + comboBoxAttName.Text + "' OR aclass = '" + comboBoxAttClass.Text + "'";
            Attendance.Attendance.DisplayAndSearchAllData(s, dataGridViewAttR, con_string);
            int p = dataGridViewAttR.Rows.Count;
            lblPresent.Text = p.ToString();

            string qry = "Select * from enrollment_table where ename = '" + comboBoxAttName.Text + "' OR eclass = '" + comboBoxAttClass.Text + "'";
            cmd = new SqlCommand(qry, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            int t = dt.Rows.Count;
            lblList.Text = t.ToString();

            int a = t - p;
            lblabsent.Text = a.ToString();
        }
    }
}
