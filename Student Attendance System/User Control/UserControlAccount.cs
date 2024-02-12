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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Xml.Linq;

namespace StudentAttendanceSystem.User_Control
{
    public partial class UserControlAccount : UserControl
    {

        //Database Connection
        public static readonly string con_string = "Data Source=AyeChanAung-PC;Initial Catalog=attendance_System;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(con_string);

        private string CID;
        public string username;
        public string pass;
        public string own;
        public string role;
 

        public UserControlAccount()
        {
            InitializeComponent();
        }

        public void clear_textbox_add()
        {
            textBoxAccName.Clear();
            textBoxAccPass.Clear();
            textBoxAccOwn.Clear();

            tabControlAcc.SelectedTab = AddAccTab;
        }

        private void clear_textbox_upt()
        {
            UAccUname.Clear();
            UAccPass.Clear();
            UAccOwn.Clear();
           
            CID = "";
        }

        private void btnAccAdd_Click(object sender, EventArgs e)
        {
            if (textBoxAccName.Text.Trim() == string.Empty || textBoxAccPass.Text.Trim() == string.Empty || textBoxAccOwn.Text.Trim() == string.Empty || comboBoxAccRole.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill out all the fields !", "Required All Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string qry = @"insert into account_table values('" + textBoxAccName.Text + "','" + textBoxAccPass.Text + "','" + comboBoxAccRole.Text + "','" + textBoxAccOwn.Text +"')";
                con.Open();
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Teacher Successfully Added");
                clear_textbox_add();
            }
        }

        private void UpdateAccTab_Leave(object sender, EventArgs e)
        {
            clear_textbox_upt();
        }

        private void SearchAccTab_Enter(object sender, EventArgs e)
        {
            textBoxAccsearch.Clear();
            comboBoxAccSearchBy.SelectedIndex = -1;
            string ser = "Select * from account_table";
            Attendance.Attendance.DisplayAndSearchAllData(ser, dataGridViewTeacher, con_string);
            //dataGridViewClass.Columns[0].Visible = false;
            labelACCcount.Text = dataGridViewTeacher.Rows.Count.ToString();
        }

        private void AddAccTab_Enter(object sender, EventArgs e)
        {
            clear_textbox_upt();
        }

        private void AddAccTab_Leave(object sender, EventArgs e)
        {
            clear_textbox_add();
        }

        private void textBoxAccsearch_TextChanged(object sender, EventArgs e)
        {
            string s = "Select * from account_table where username LIKE'%" + textBoxAccsearch.Text + "%'; ";
            Attendance.Attendance.DisplayAndSearchAllData(s, dataGridViewTeacher, con_string);

            if (comboBoxAccSearchBy.SelectedIndex == 0)
            {
                string chg0 = "Select * from account_table where username LIKE'%" + textBoxAccsearch.Text + "%'; ";
                Attendance.Attendance.DisplayAndSearchAllData(chg0, dataGridViewTeacher, con_string);
            }

            if (comboBoxAccSearchBy.SelectedIndex == 1)
            {
                string chg1 = "Select * from account_table where role LIKE'%" + textBoxAccsearch.Text + "%'; ";
                Attendance.Attendance.DisplayAndSearchAllData(chg1, dataGridViewTeacher, con_string);
            }

            if (comboBoxAccSearchBy.SelectedIndex == 2)
            {
                string chg2 = "Select * from account_table where owner LIKE'%" + textBoxAccsearch.Text + "%'; ";
                Attendance.Attendance.DisplayAndSearchAllData(chg2, dataGridViewTeacher, con_string);
            }

        }

        private void dataGridViewTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewTeacher.Rows[e.RowIndex];
                CID = row.Cells[0].Value.ToString();
                UAccUname.Text = row.Cells[0].Value.ToString();
                UAccPass.Text = row.Cells[1].Value.ToString();
                
                UAccOwn.Text = row.Cells[3].Value.ToString();
                UcomboAccRole.Text = row.Cells[2].ToString();


                username = row.Cells[0].Value.ToString();
                pass = row.Cells[1].Value.ToString();
                role = row.Cells[2].Value.ToString();
                own = row.Cells[3].Value.ToString();

            }
        }

        private void btnAccupdate_Click(object sender, EventArgs e)
        {
            if (CID != "")
            {
                if (UAccUname.Text.Trim() == string.Empty || UAccPass.Text.Trim() == string.Empty || UAccOwn.Text.Trim() == string.Empty || UcomboAccRole.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Fill out all the fields !", "Required All Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string qry = "UPDATE account_table SET username = '" + UAccUname.Text + "', password = '" + UAccPass.Text + "', role = '" + UcomboAccRole.Text +"', owner = '" + UAccOwn.Text + "' WHERE username = '" + username + "' AND password = '" + pass + "' AND role = '" + role + "' AND owner = '" + own + "'";
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

        private void bthAccDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do You want to Delete ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (CID != "")
                {
                    if (UAccUname.Text.Trim() == string.Empty || UAccPass.Text.Trim() == string.Empty || UAccOwn.Text.Trim() == string.Empty || UcomboAccRole.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Please Fill out all the fields !", "Required All Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        string qry = "DELETE FROM account_table WHERE username = '" + username + "' AND password = '" + pass + "' AND role = '" + role + "' AND owner = '" + own + "'";
                        SqlCommand cmd = new SqlCommand(qry, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Account Successfully Deleted");
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
