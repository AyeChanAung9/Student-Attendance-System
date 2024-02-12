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
    public partial class UserControlStudentInfo : UserControl
    {
        //Database Connection
        public static readonly string con_string = "Data Source=AyeChanAung-PC;Initial Catalog=attendance_System;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(con_string);
        public static SqlCommand cmd;

        public UserControlStudentInfo()
        {
            InitializeComponent();
        }

        private void UserControlStudentInfo_Load(object sender, EventArgs e)
        {
            string ser = "Select * from student_info_table";
            Attendance.Attendance.DisplayAndSearchAllData(ser, dataGridViewSinfo, con_string);
            //dataGridViewClass.Columns[0].Visible = false;
            labelScount.Text = dataGridViewSinfo.Rows.Count.ToString();

            string qry = @"Select student_id,sname,sYear from student_info_table";
            cmd = new SqlCommand(qry, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataRow irow = dt.NewRow();
            irow[0] = "Select ID";
            irow[1] = "Select Name";
            irow[2] = "";
            dt.Rows.InsertAt(irow,0);

            comboBoxSIDSearch.DataSource = dt;
            comboBoxSIDSearch.ValueMember = "student_id";

            comboBoxSNameSearch.DataSource = dt;
            comboBoxSNameSearch.ValueMember = "sname";

            comboBoxSYearSearch.DataSource = dt;
            comboBoxSYearSearch.ValueMember = "sYear";
        }

        private void comboBoxSIDSearch_TextChanged(object sender, EventArgs e)
        {
            string s = "Select * from student_info_table where student_id LIKE'%" + comboBoxSIDSearch.Text + "%'; ";
            Attendance.Attendance.DisplayAndSearchAllData(s, dataGridViewSinfo, con_string);
        }

        private void comboBoxSNameSearch_TextChanged(object sender, EventArgs e)
        {
            string s = "Select * from student_info_table where sname LIKE'%" + comboBoxSNameSearch.Text + "%'; ";
            Attendance.Attendance.DisplayAndSearchAllData(s, dataGridViewSinfo, con_string);
        }

        private void comboBoxSYearSearch_TextChanged(object sender, EventArgs e)
        {
            string s = "Select * from student_info_table where sYear LIKE'%" + comboBoxSYearSearch.Text + "%'; ";
            Attendance.Attendance.DisplayAndSearchAllData(s, dataGridViewSinfo, con_string);
        }
    }
}
