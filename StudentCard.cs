using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAttendanceSystem
{
    public partial class StudentCard : Form
    {
        public string Id { get; set; }
        public string sName { get; set; }
        public string DOB { get; set; }
        public string Fname { get; set; }
        public string Cont { get; set; }

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
        public StudentCard()
        {
            InitializeComponent();
            //for rounded corner
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //for rounded corner
        }

        private void StudentCard_Load(object sender, EventArgs e)
        {
            lblID.Text = Id;
            lblName.Text = sName;
            lblDOB.Text = DOB;
            lblFname.Text = Fname;
            lblContac.Text = Cont;


            //for qr code generator
            QRCoder.QRCodeGenerator Qng = new QRCoder.QRCodeGenerator();
            QRCodeData data = Qng.CreateQrCode(Id, QRCoder.QRCodeGenerator.ECCLevel.H);
            QRCode qrcode = new QRCoder.QRCode(data);
            {
                Qrbox.Image = qrcode.GetGraphic(100);
            }
        }

        private void ExitCard_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm rg = new RegistrationForm();
            rg.Show();
        }

        private void BtnEnrollForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnrollForm enroll = new EnrollForm();
            enroll.eId = lblID.Text;
            enroll.eName = lblName.Text;
            enroll.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        Bitmap bmp;
        private void card_print_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);

            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0,0, this.Size);
            printPreviewDialog1.ShowDialog();
        }
    }
}
