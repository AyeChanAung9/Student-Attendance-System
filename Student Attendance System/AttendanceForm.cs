using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ZXing;

namespace StudentAttendanceSystem
{
    public partial class AttendanceForm : Form
    {
        public int inde;

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

        //Camera
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;

        public AttendanceForm()
        {
            InitializeComponent();
            //for rounded corner
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //for rounded corner
        }


        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in CaptureDevice)
                comboCam.Items.Add(device.Name);

            comboCam.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();

            DateTime currentDate = DateTime.Now;
            // Formatting the date in "day/month/year" format
            string formattedDate = currentDate.ToString("dd/MM/yyyy");
            date_text.Text = formattedDate;
        }

        private void btnCamOpn_Click(object sender, EventArgs e)
        {
            //open Camera
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboCam.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalNewFrame);
            FinalFrame.Start();
        }

        private void FinalNewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            camera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader reader = new BarcodeReader();
            Result res = reader.Decode((Bitmap)camera.Image);
            try
            {
                string decode = res.ToString().Trim();
                showidtxt.Text = decode;
                if (decode != null)
                {
                    string qry = @"Select * from student_info_table where student_id ='" + showidtxt.Text + "'";
                    string enro = @"Select * from enrollment_table where eid ='" + showidtxt.Text + "'";
                    con.Open();
                    cmd = new SqlCommand(qry, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        shownametxt.Text = dr["sname"].ToString();
                        showdobtxt.Text = dr["sDOB"].ToString();
                        showfnametxt.Text = dr["sFname"].ToString();
                        showcontactxt.Text = dr["sContactinfo"].ToString();
                        showyeartxt.Text = dr["sYear"].ToString();

                    }
                    con.Close();

                    cmd = new SqlCommand(enro, con);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    comboBoxMarkClass.DataSource = dt;
                    comboBoxMarkClass.ValueMember = "eclass";
                    lblAttTime.Text = dt.Rows[inde]["etime"].ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void AttendanceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
                FinalFrame.Stop();
        }

        private void btnScanQR_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnbacktomain_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeForm WF = new WelcomeForm();
            WF.Show();
        }

        private void comboBoxMarkClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string enro = @"Select * from enrollment_table where eid ='" + showidtxt.Text + "'";
            cmd = new SqlCommand(enro, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            inde = comboBoxMarkClass.SelectedIndex;

            lblAttTime.Text = dt.Rows[inde]["etime"].ToString();
        }

        private void BtnMarkAttendance_Click(object sender, EventArgs e)
        {
            string qry = @"insert into attendance_table values ('" + showidtxt.Text + "','" + shownametxt.Text + "','" + comboBoxMarkClass.Text + "','" + lblAttTime.Text + "','" + date_text.Text + "')";
            con.Open();
            cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Attendance Save successfully");
            con.Close();
        }
    }
}
