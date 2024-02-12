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
    public partial class UserControlDash : UserControl
    {
        //Database Connection
        public static readonly string con_string = "Data Source=AyeChanAung-PC;Initial Catalog=attendance_System;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(con_string);

        public UserControlDash()
        {
            InitializeComponent();
        }

        public void count()
        {
            labeltotalclass.Text = Attendance.Attendance.Count("select count(*) from classes_table;",con_string).ToString();
            labelTeach.Text = Attendance.Attendance.Count("select count(*) from teachers_table;", con_string).ToString();
            labelACC.Text = Attendance.Attendance.Count("select count(*) from account_table;", con_string).ToString();
            labelStudCount.Text = Attendance.Attendance.Count("select count(*) from student_info_table;", con_string).ToString();
        }

        private void UserControlDash_Load(object sender, EventArgs e)
        {
            count();
        }
    }
}
