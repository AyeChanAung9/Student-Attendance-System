using System.Data.SqlClient;
using System.Data;
using System;

namespace StudentAttendanceSystem
{
    class DBClass
    {
        public static readonly string con_string = "Data Source=AyeChanAung-PC;Initial Catalog=attendance_System;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(con_string);

        //check user validation
        public static bool IsValid(string user, string pass)
        {
            bool isValid = false;
            
            string qry = @"Select * from account_table where username ='" + user + "' and password ='" + pass + "'";
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                isValid = true;
            }

            return isValid;

        }


    }
}
