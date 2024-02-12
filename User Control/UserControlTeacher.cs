using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Xml.Linq;


namespace StudentAttendanceSystem.User_Control
{
    public partial class UserControlTeacher : UserControl
    {
        //Database Connection
        public static readonly string con_string = "Data Source=AyeChanAung-PC;Initial Catalog=attendance_System;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(con_string);

        private string CID;
        public string Id;
        public string teacher_name;
        public string Pos;
        public string DOB;
        public string Contac;


        public UserControlTeacher()
        {
            InitializeComponent();
        }

        public void clear_textbox_add()
        {
            textBoxTID.Clear();
            textBoxTname.Clear();
            textBoxTpos.Clear();
            textBoxTDOB.Clear();
            textBoxTContac.Clear();

            tabControlTeacher.SelectedTab = AddTeacher;
        }

        private void clear_textbox_upt()
        {
            UtextBoxID.Clear();
            UtextBoxTname.Clear();
            UtextBoxTPos.Clear();
            UtextBoxTDOB.Clear();
            UtextBoxTContac.Clear();
            CID = "";
        }

        private void btnTAdd_Click(object sender, EventArgs e)
        {
            if ( textBoxTID.Text.Trim() == string.Empty || textBoxTname.Text.Trim() == string.Empty || textBoxTpos.Text.Trim() == string.Empty || textBoxTDOB.Text.Trim() == string.Empty || textBoxTContac.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill out all the fields !", "Required All Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string qry = @"insert into teachers_table values('" + textBoxTID.Text + "','" + textBoxTname.Text + "','" + textBoxTpos.Text + "','" + textBoxTDOB.Text + "','" + textBoxTContac.Text + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Teacher Successfully Added");
                clear_textbox_add();
            }
        }

        private void UpdateTeacher_Leave(object sender, EventArgs e)
        {
            clear_textbox_upt();
        }

        private void SearchTeacher_Enter(object sender, EventArgs e)
        {
            textBoxTsearch.Clear();
            comboBoxTSearchBy.SelectedIndex = -1;
            string ser = "Select * from teachers_table";
            Attendance.Attendance.DisplayAndSearchAllData(ser, dataGridViewTeacher, con_string);
            //dataGridViewClass.Columns[0].Visible = false;
            labelTcount.Text = dataGridViewTeacher.Rows.Count.ToString();
        }

        private void AddTeacher_Enter(object sender, EventArgs e)
        {
            clear_textbox_add();
        }

        private void textBoxTsearch_TextChanged(object sender, EventArgs e)
        {
            string s = "Select * from teachers_table where Teacher_Name LIKE'%" + textBoxTsearch.Text + "%'; ";
            Attendance.Attendance.DisplayAndSearchAllData(s, dataGridViewTeacher, con_string);

            if (comboBoxTSearchBy.SelectedIndex == 0)
            {
                string chg0 = "Select * from teachers_table where ID LIKE'%" + textBoxTsearch.Text + "%'; ";
                Attendance.Attendance.DisplayAndSearchAllData(chg0, dataGridViewTeacher, con_string);
            }

            if (comboBoxTSearchBy.SelectedIndex == 1)
            {
                string chg2 = "Select * from teachers_table where Teacher_Name LIKE'%" + textBoxTsearch.Text + "%'; ";
                Attendance.Attendance.DisplayAndSearchAllData(chg2, dataGridViewTeacher, con_string);
            }

            if (comboBoxTSearchBy.SelectedIndex == 2)
            {
                string chg1 = "Select * from teachers_table where Position LIKE'%" + textBoxTsearch.Text + "%'; ";
                Attendance.Attendance.DisplayAndSearchAllData(chg1, dataGridViewTeacher, con_string);
            }

            if (comboBoxTSearchBy.SelectedIndex == 3)
            {
                string chg2 = "Select * from teachers_table where DOB LIKE'%" + textBoxTsearch.Text + "%'; ";
                Attendance.Attendance.DisplayAndSearchAllData(chg2, dataGridViewTeacher, con_string);
            }

            if (comboBoxTSearchBy.SelectedIndex == 4)
            {
                string chg2 = "Select * from teachers_table where Contact LIKE'%" + textBoxTsearch.Text + "%'; ";
                Attendance.Attendance.DisplayAndSearchAllData(chg2, dataGridViewTeacher, con_string);
            }
            
        }

        private void dataGridViewTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewTeacher.Rows[e.RowIndex];
                CID = row.Cells[0].Value.ToString();
                UtextBoxID.Text = row.Cells[0].Value.ToString();
                UtextBoxTname.Text = row.Cells[1].Value.ToString();
                UtextBoxTPos.Text = row.Cells[2].Value.ToString();
                UtextBoxTDOB.Text = row.Cells[3].Value.ToString();
                UtextBoxTContac.Text = row.Cells[4].Value.ToString();

                Id = row.Cells[0].Value.ToString();
                teacher_name = row.Cells[1].Value.ToString();
                Pos = row.Cells[2].Value.ToString();
                DOB = row.Cells[3].Value.ToString();
                Contac = row.Cells[4].Value.ToString();
            }
        }

        private void btnTupdate_Click(object sender, EventArgs e)
        {
            if (CID != "")
            {
                if (UtextBoxID.Text.Trim() == string.Empty || UtextBoxTname.Text.Trim() == string.Empty || UtextBoxTPos.Text.Trim() == string.Empty || UtextBoxTDOB.Text.Trim() == string.Empty || UtextBoxTContac.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Fill out all the fields !", "Required All Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string qry = "UPDATE teachers_table SET ID = '" + UtextBoxID.Text + "', Teacher_Name = '" + UtextBoxTname.Text + "', Position = '" + UtextBoxTPos.Text + "', DOB = '" + UtextBoxTDOB.Text + "', Contact = '" + UtextBoxTContac.Text + "' WHERE ID = '" + Id + "' AND Teacher_Name = '" + teacher_name + "' AND Position = '" + Pos + "' AND DOB = '" + DOB + "' AND Contact = '" + Contac + "'";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Teacher Successfully Updated");
                    clear_textbox_upt();
                }
            }
            else
            {
                MessageBox.Show("Select row from table first !", "Required to select row", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void bthTDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do You want to Delete ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (CID != "")
                {
                    if (UtextBoxID.Text.Trim() == string.Empty || UtextBoxTname.Text.Trim() == string.Empty || UtextBoxTPos.Text.Trim() == string.Empty || UtextBoxTDOB.Text.Trim() == string.Empty || UtextBoxTContac.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Please Fill out all the fields !", "Required All Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        string qry = "DELETE FROM teachers_table WHERE ID = '" + Id + "' AND Teacher_Name = '" + teacher_name + "' AND Position = '" + Pos + "' AND DOB = '" + DOB + "' AND Contact = '" + Contac + "'";
                        SqlCommand cmd = new SqlCommand(qry, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Teacher Successfully Deleted");
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
