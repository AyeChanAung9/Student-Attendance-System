using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace StudentAttendanceSystem.User_Control
{
    public partial class UserControlClass : UserControl
    {
        //Database Connection
        public static readonly string con_string = "Data Source=AyeChanAung-PC;Initial Catalog=attendance_System;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(con_string);

        private string CID;
        private string name;
        private string teacher;
        private string time;


        public UserControlClass()
        {
            InitializeComponent();
        }

        public void clear_textbox_add()
        { 
            textBoxCname.Clear();
            textBoxTeacher.Clear();

            tabControl.SelectedTab = AddClass;
        }

        private void clear_textbox_upt()
        {
            uptTeacher.Clear();
            uptname.Clear();
            CID = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBoxCname.Text.Trim() == string.Empty || textBoxTeacher.Text.Trim() == string.Empty || comboBoxTime.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill out all the fields !","Required All Fields",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {
                string qry = @"insert into classes_table values('" + textBoxCname.Text + "','" + textBoxTeacher.Text + "','" + comboBoxTime.Text + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Class Successfully Added");
                clear_textbox_add();
            }
            
        }

        private void ClassUpdate_Leave(object sender, EventArgs e)
        {
            clear_textbox_upt();
        }

        private void SearchClass_Enter(object sender, EventArgs e)
        {
            textBoxsearch.Clear();
            comboBoxSearchBy.SelectedIndex = -1;
            string ser = "Select * from classes_table";
            Attendance.Attendance.DisplayAndSearchAllData(ser, dataGridViewClass,con_string);
            //dataGridViewClass.Columns[0].Visible = false;
            labelcount.Text = dataGridViewClass.Rows.Count.ToString();

        }

        private void AddClass_Enter(object sender, EventArgs e)
        {
            clear_textbox_upt();
        }

        private void AddClass_Leave(object sender, EventArgs e)
        {
            clear_textbox_add();
        }

        private void textBoxsearch_TextChanged(object sender, EventArgs e)
        {
            string s = "Select * from classes_table where classname LIKE'%" + textBoxsearch.Text + "%'; ";
            Attendance.Attendance.DisplayAndSearchAllData(s, dataGridViewClass, con_string);

            if (comboBoxSearchBy.SelectedIndex == 0)
            {
                string chg0 = "Select * from classes_table where classname LIKE'%" + textBoxsearch.Text + "%'; ";
                Attendance.Attendance.DisplayAndSearchAllData(chg0, dataGridViewClass, con_string);
            }

            if (comboBoxSearchBy.SelectedIndex == 1)
            {
                string chg1 = "Select * from classes_table where teacher LIKE'%" + textBoxsearch.Text + "%'; ";
                Attendance.Attendance.DisplayAndSearchAllData(chg1, dataGridViewClass, con_string);
            }

            if (comboBoxSearchBy.SelectedIndex == 2)
            {
                string chg2 = "Select * from classes_table where time LIKE'%" + textBoxsearch.Text + "%'; ";
                Attendance.Attendance.DisplayAndSearchAllData(chg2, dataGridViewClass, con_string);
            }

        }

        private void dataGridViewClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewClass.Rows[e.RowIndex];
                CID = row.Cells[0].Value.ToString();
                uptname.Text = row.Cells[0].Value.ToString();
                uptTeacher.Text = row.Cells[1].Value.ToString();
                uptTime.Text = row.Cells[2].Value.ToString();

                name = row.Cells[0].Value.ToString();
                teacher = row.Cells[1].Value.ToString();
                time = row.Cells[2].Value.ToString();

            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (CID != "")
            {
                if (uptname.Text.Trim() == string.Empty || uptTeacher.Text.Trim() == string.Empty || uptTime.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Fill out all the fields !", "Required All Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string qry = "UPDATE classes_table SET classname = '" + uptname.Text + "', teacher = '" + uptTeacher.Text + "', time = '" + uptTime.Text + "' WHERE classname = '" + name + "' AND teacher = '" + teacher + "' AND time = '" + time + "'";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Class Successfully Updated");
                    clear_textbox_upt();
                }
            }
            else
            {
                MessageBox.Show("Select row from table first !", "Required to select row", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void bthDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do You want to Delete ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (CID != "")
                {
                    if (uptname.Text.Trim() == string.Empty || uptTeacher.Text.Trim() == string.Empty || uptTime.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Please Fill out all the fields !", "Required All Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        string qry = "DELETE FROM classes_table WHERE classname = '" + uptname.Text + "' AND teacher = '" + uptTeacher.Text + "' AND time = '" + uptTime.Text + "'";
                        SqlCommand cmd = new SqlCommand(qry, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Class Successfully Deleted");
                        clear_textbox_upt();
                    }
                }
                else
                {
                    MessageBox.Show("Select row from table first !", "Required to select row", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            
        }
    }
}
