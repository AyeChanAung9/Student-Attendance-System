using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAttendanceSystem.User_Control
{
    public partial class UserControlManageStudents : UserControl
    {
        //Database Connection
        public static readonly string con_string = "Data Source=AyeChanAung-PC;Initial Catalog=attendance_System;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(con_string);
        public static SqlCommand cmd;


        public UserControlManageStudents()
        {
            InitializeComponent();
        }

        private void clear_textbox_upt()
        {
            UpdtxtSid.Clear();
            UpdtxtSname.Clear();
            UpdtxtSFname.Clear();
            UpdtxtSConInfo.Clear();
            UpdtxtSYear.Clear();
        }

        private void UserControlManageStudents_Load(object sender, EventArgs e)
        {
            string ser = "Select * from student_info_table";
            Attendance.Attendance.DisplayAndSearchAllData(ser, dataGridViewSinfoUpd, con_string);
            //dataGridViewClass.Columns[0].Visible = false;
            UpdlabelScount.Text = dataGridViewSinfoUpd.Rows.Count.ToString();

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
            dt.Rows.InsertAt(irow, 0);

            UpdcboxSIDSearch.DataSource = dt;
            UpdcboxSIDSearch.ValueMember = "student_id";

            UpdcboxSNameSearch.DataSource = dt;
            UpdcboxSNameSearch.ValueMember = "sname";

            UpdcboxSYearSearch.DataSource = dt;
            UpdcboxSYearSearch.ValueMember = "sYear";
        }

        private void UpdcboxSIDSearch_TextChanged(object sender, EventArgs e)
        {
            string s = "Select * from student_info_table where student_id LIKE'%" + UpdcboxSIDSearch.Text + "%'; ";
            Attendance.Attendance.DisplayAndSearchAllData(s, dataGridViewSinfoUpd, con_string);
        }

        private void UpdcboxSNameSearch_TextChanged(object sender, EventArgs e)
        {
            string s = "Select * from student_info_table where sname LIKE'%" + UpdcboxSNameSearch.Text + "%'; ";
            Attendance.Attendance.DisplayAndSearchAllData(s, dataGridViewSinfoUpd, con_string);
        }

        private void UpdcboxSYearSearch_TextChanged(object sender, EventArgs e)
        {
            string s = "Select * from student_info_table where sYear LIKE'%" + UpdcboxSYearSearch.Text + "%'; ";
            Attendance.Attendance.DisplayAndSearchAllData(s, dataGridViewSinfoUpd, con_string);
        }

        public string sid;
        public string stud_name;
        public string stud_fname;
        public string stud_dob;
        public string stud_con;
        public string stud_year;
        private void dataGridViewSinfoUpd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewSinfoUpd.Rows[e.RowIndex];

                UpdtxtSid.Text = row.Cells[0].Value.ToString();
                UpdtxtSname.Text = row.Cells[1].Value.ToString();
                UpdtxtSDOB.Text = row.Cells[2].Value.ToString();
                UpdtxtSFname.Text = row.Cells[3].Value.ToString();
                UpdtxtSConInfo.Text = row.Cells[4].Value.ToString();
                UpdtxtSYear.Text = row.Cells[5].Value.ToString();

                sid = row.Cells[0].Value.ToString();
                stud_name = row.Cells[1].Value.ToString();
                stud_dob = row.Cells[2].Value.ToString();
                stud_fname = row.Cells[3].Value.ToString();
                stud_con = row.Cells[4].Value.ToString();
                stud_year = row.Cells[5].Value.ToString();

            }
        }

        private void btnSupdate_Click(object sender, EventArgs e)
        {
            if (UpdtxtSid.Text.Trim() == string.Empty || UpdtxtSname.Text.Trim() == string.Empty || UpdtxtSDOB.Text.Trim() == string.Empty || UpdtxtSFname.Text.Trim() == string.Empty || UpdtxtSConInfo.Text.Trim() == string.Empty || UpdtxtSYear.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill out all the fields !", "Required All Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string qry = "UPDATE student_info_table SET student_id = '" + UpdtxtSid.Text + "', sname = '" + UpdtxtSname.Text + "', sDOB = '" + UpdtxtSDOB.Text + "', sFname = '" + UpdtxtSFname.Text + "', sContactinfo = '" + UpdtxtSConInfo.Text + "', sYear = '" + UpdtxtSYear.Text + "' WHERE student_id = '" + sid + "' AND sname = '" + stud_name + "' AND sDOB = '" + stud_dob + "' AND sFname = '" + stud_fname + "' AND sContactinfo = '" + stud_con + "' AND sYear = '" + stud_year + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Student Info Successfully Updated");
                clear_textbox_upt();
                string ser = "Select * from student_info_table";
                Attendance.Attendance.DisplayAndSearchAllData(ser, dataGridViewSinfoUpd, con_string);
            }
        }

        private void bthSDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do You want to Delete ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (UpdtxtSid.Text.Trim() == string.Empty || UpdtxtSname.Text.Trim() == string.Empty || UpdtxtSDOB.Text.Trim() == string.Empty || UpdtxtSFname.Text.Trim() == string.Empty || UpdtxtSConInfo.Text.Trim() == string.Empty || UpdtxtSYear.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Fill out all the fields !", "Required All Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string qry = "DELETE FROM student_info_table WHERE student_id = '" + sid + "' AND sname = '" + stud_name + "' AND sDOB = '" + stud_dob + "' AND sFname = '" + stud_fname + "' AND sContactinfo = '" + stud_con + "' AND sYear = '" + stud_year + "'";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    string ser = "Select * from student_info_table";
                    Attendance.Attendance.DisplayAndSearchAllData(ser, dataGridViewSinfoUpd, con_string);
                    MessageBox.Show("Student Info Successfully Deleted");
                    clear_textbox_upt();
                }
            }
            
        }
    }
}
