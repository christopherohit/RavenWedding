using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraBars.ToastNotifications;
using DevExpress.Data;
using System.Windows.Forms;
using Raven.DAO;

namespace Raven
{
    public partial class Main : Form
    {
        public Label GetName { get { return this.bunifuCustomLabel1; } }
        public DevExpress.XtraEditors.LabelControl GETID { get { return this.labelControl1; } }
        public Label GetCareer { get { return this.bunifuCustomLabel2; } }
        public Bunifu.UI.WinForms.BunifuPictureBox GetImage { get { return this.bunifuPictureBox1; } }
        Timer t1 = new Timer();

        public Main()
        {
            InitializeComponent();            
        }
        public Main(DataTable data)
        {
            InitializeComponent();
            

        }

        #region
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onYourWeddingDayDataSet1.DoanhThu' table. You can move, or remove it, as needed.
            this.doanhThuTableAdapter.Fill(this.onYourWeddingDayDataSet1.DoanhThu);
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            DashPanel.Show(); 
        }

        #region Animation
        void fadeIn(object sender, EventArgs e) // FadeIn Animation
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }
        void fadeOut(object sender, EventArgs e) // FadeOut Animation
        {
            if (Opacity <= 0)     //check if opacity is 0
            {
                t1.Stop();    //if it is, we stop the timer
                Close();   //and we try to close the form
            }
            else
                Opacity -= 0.05;
        }
        #endregion

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Do you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                t1.Tick += new EventHandler(fadeOut);  //this calls the fade out function
                t1.Start();
                Environment.Exit(1);
                
            }
            else
            {
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void bunifuShadowPanel2_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();

            //...

            ((Panel)sender).Region = new Region(gp); //even border, backcolor...

            gp.Dispose();
        }
        public void DrawRoundRect(Graphics g, Pen p, float X, float Y, float width, float height, float radius) // Create Shadow For Panel
        {
            GraphicsPath gp = new GraphicsPath();
            //Upper-right arc:
            gp.AddArc(X + width - (radius * 2), Y, radius * 2, radius * 2, 270, 90);
            //Lower-right arc:
            gp.AddArc(X + width - (radius * 2), Y + height - (radius * 2), radius * 2, radius * 2, 0, 90);
            //Lower-left arc:
            gp.AddArc(X, Y + height - (radius * 2), radius * 2, radius * 2, 90, 90);
            //Upper-left arc:
            gp.AddArc(X, Y, radius * 2, radius * 2, 180, 90);
            gp.CloseFigure();
            g.DrawPath(p, gp);
            gp.Dispose();
        }

        private void bunifuCustomLabel1_MouseHover(object sender, EventArgs e) // Create animation
        {
            bunifuCustomLabel1.Font = new Font(bunifuCustomLabel1.Font.Name, bunifuCustomLabel1.Font.SizeInPoints, FontStyle.Underline);
            bunifuCustomLabel1.BackColor = Color.BlueViolet;
        }

        private void bunifuCustomLabel1_MouseLeave(object sender, EventArgs e) // Create animation
        {
            bunifuCustomLabel1.Font = new Font(bunifuCustomLabel1.Font.Name, bunifuCustomLabel1.Font.SizeInPoints, FontStyle.Regular);
            bunifuCustomLabel1.BackColor = Color.White;
        }

        private void radPanel1_Click(object sender, EventArgs e)
        {

        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            string ID = labelControl1.Text;
            System.Windows.Forms.Form TakeEmails = System.Windows.Forms.Application.OpenForms["SignIn"];
            string username = ((SignIn)TakeEmails).TextBox.Text;
            
            Profile Info = new Profile();
            Info.GetBirth.Value = Convert.ToDateTime(GetDates(username).ToString());
            Info.GetName.Text = Getame(username).ToString();
            Info.GetRegency.Text = GetCareers(username).ToString();
            Info.SetDes.Text = Des(username).ToString();
            Info.GetPhone.Text = Phone(username).ToString();
            Info.Geticm.Text = getICM(username).ToString();
            Info.GetGender.Text = GetGender(username).ToString();
            Info.GetMails.Text = GetMails(ID).ToString();
            Info.GetAddress.Text = GetAddress(username).ToString();
            Info.SetImage.Image = GetImages(username);
            Info.ShowDialog();
        }

        #region Method
        string GetMails(string ID)
        {
            return AccountDAO.Instance.Emails(ID);
        }
        string GetAddress(string username)
        {
            return AccountDAO.Instance.GetAddress(username);
        }
        string GetGender(string username)
        {
            return AccountDAO.Instance.GetGender(username);
        }
        string GetDates(string username)
        {
            return AccountDAO.Instance.GetDate(username);
        }
        bool GetPhone(string Phone)
        {
            return AccountDAO.Instance.GetPhone(Phone);
        }
        string Getame(string username)
        {
            return AccountDAO.Instance.Getame(username);
        }
        string GetCareers(string username)
        {
            return AccountDAO.Instance.GetCareer(username);
        }
        Image GetImages(string username)
        {
            return AccountDAO.Instance.Images(username);
        }
        string Phone(string username)
        {
            return AccountDAO.Instance.SetPhone(username);
        }
        string getICM(string username)
        {
            return AccountDAO.Instance.GetICM(username);
        }
        bool ChecKICM(string ICM)
        {
            return AccountDAO.Instance.ICMCheck(ICM);
        }
        string Des(string username)
        {
            return AccountDAO.Instance.GetDes(username);
        }
        #endregion

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
