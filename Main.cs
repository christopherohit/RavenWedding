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
using DevExpress.XtraBars.Docking2010;
using Raven.DAO;
using System.Drawing.Imaging;

namespace Raven
{

    public partial class Main : Form
    {
        string Paths = Path.GetFullPath("C:/");
        public Label GetName { get { return this.bunifuCustomLabel1; } }
        public Label GetCareer { get { return this.bunifuCustomLabel2; } }
        public Bunifu.UI.WinForms.BunifuPictureBox GetImage { get { return this.bunifuPictureBox1; } }
        public DevExpress.XtraEditors.LabelControl ID { get { return this.labelControl1; } }
        Timer t1 = new Timer();

        #region Void

        void Exit() // Function exit form i declare to resample more than it will help me save a large of time to rewrite it
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

        void Function_Create_Save_Pic() // Create and change place to save image of screen capture
        {
            string path = Paths + @"Capture_Screen";
            Bitmap capturescreen = new Bitmap(1024, 768, PixelFormat.Format32bppArgb);
            Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
            Graphics capturegraphics = Graphics.FromImage(capturescreen);
            capturegraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
            capturescreen.Save(path, ImageFormat.Jpeg);
            MessageBox.Show("Screen has been captured\nIt was save at " + path);
        }

        void CaptureScreen() // Save Capture Screen
        {
            try
            {
                string path = Paths + @"Capture_Screen";
                if (Directory.Exists(path))
                {
                    Function_Create_Save_Pic();
                }
                else
                {
                    Directory.CreateDirectory(path);
                    Function_Create_Save_Pic();
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        void Main_Menu(MouseEventArgs e) // Show Menu when user use right click anywhere
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu cm = new ContextMenu();

                cm.MenuItems.Add(new MenuItem("Back", new EventHandler(Back_Click)));
                cm.MenuItems.Add(new MenuItem("Reload", new EventHandler(Reload_Click)));
                cm.MenuItems.Add(new MenuItem("Go to       Ctrl + H", new EventHandler(Goto_Click)));
                cm.MenuItems.Add(new MenuItem("Capture the screen", new EventHandler(CaptureScreen_Click)));
                cm.MenuItems.Add(new MenuItem("Change personal picture", new EventHandler(ChangePicture_Click)));
                
                cm.MenuItems[0].Enabled = false;
                cm.MenuItems[2].Enabled = false;
                cm.Show(this, new Point(e.X, e.Y));
            }
        }

        void Refreshs() // Refresh Form And Update information of Employee When this system Recognize a change of it in Database
        {
            System.Windows.Forms.Form io = System.Windows.Forms.Application.OpenForms["SignIn"];
            string orginEmails = ((SignIn)io).TextBox.Text;
            bunifuPictureBox1.Image = ((SignIn)io).GetImage(orginEmails);
            bunifuCustomLabel1.Text = ((SignIn)io).GetName(orginEmails);
            bunifuCustomLabel2.Text = ((SignIn)io).GetCareer(orginEmails);
            labelControl1.Text = ((SignIn)io).GETID(orginEmails);
        }

        #endregion

        public Main()
        {
            InitializeComponent();
        }

        #region Method

        string OriginalName(string id) // Take out name of member
        {
            return UpdatePe.Instances.name(id);
        }
        
        Image OriginalPic(string id) // Take out Personal Picture of Employee 
        {
            return UpdatePe.Instances.Pic(id);
        }

        string OriginalRegency (string id) // Take out Regency or Career of Employee
        {
            return UpdatePe.Instances.Regency(id);
        }

        #endregion

        #region Move Panel 
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || Cursor.Current == Cursors.SizeAll)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || Cursor.Current == Cursors.SizeAll)
            {
                if (dragging)
                {
                    Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                    this.Location = Point.Add(dragFormPoint, new Size(dif));
                }
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || Cursor.Current == Cursors.SizeAll)
            {
                dragging = false;
            }
        }
        #endregion

        private void Main_Load(object sender, EventArgs e) // Load Main Form and Process Event Animation
        {
            // TODO: This line of code loads data into the 'onYourWeddingDayDataSet1.DoanhThu' table. You can move, or remove it, as needed.
            this.doanhThuTableAdapter.Fill(this.onYourWeddingDayDataSet1.DoanhThu);
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();
            panelControl1.Hide();
        }
        
        private void bunifuButton1_Click(object sender, EventArgs e) // Show Panel
        {
            xtraTabPage1.Show();
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

        private void pictureBox2_Click(object sender, EventArgs e) // Exit Form
        {
            Exit();
        }

        private void bunifuShadowPanel2_Paint(object sender, PaintEventArgs e) // Unknow Function
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

        private void bunifuButton7_Click(object sender, EventArgs e) // Tranfers to Profile
        {
            string ID = labelControl1.Text;
            System.Windows.Forms.Form TakeEmails = System.Windows.Forms.Application.OpenForms["SignIn"];
            string username = ((SignIn)TakeEmails).TextBox.Text;
            
            Profill Info = new Profill();
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
            Info.Show();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radPanel1_Click_1(object sender, EventArgs e) // Show task view form to display which it has include
        {
            TaskForm ti = new TaskForm();
            ti.Show();
            this.Hide();
        }

        private void radPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        #region Move To
        private void pagerEvents2_CustomizePagerItem(object sender, DevExpress.Utils.CustomizePagerItemEventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            xtraTabPage2.Show();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            xtraTabPage3.Show();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            xtraTabPage4.Show();
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            xtraTabPage5.Show();
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            xtraTabPage6.Show();
        }

        private void pagerEvents1_CustomizePagerItem(object sender, DevExpress.Utils.CustomizePagerItemEventArgs e)
        {

        }
        #endregion

        private void bunifuButton8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        #region Menu Right Click

        private void ChangePicture_Click(object sender , EventArgs e)
        {
            
        }

        private void Goto_Click(object sender , EventArgs e) // Create Text to Find and Go to
        {

        }

        private void CaptureScreen_Click(object sender , EventArgs e) // Event Screen Shoot
        {
            CaptureScreen();
        }

        private void Restore_Click(object sender , EventArgs e) // Return Normal size of Form
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void Back_Click(object sender , EventArgs e) // Non Feature
        {
            //Do nothing in here because i hasn't non ideal to do it but i ensure that it will work on nearest future
        }

        private void Reload_Click(object sender , EventArgs e) // Refresh Form 
        {
            Refreshs();
        }

        private void Move_Click(object sender , EventArgs e) //Change Icon of cursor which use to move form 
        {
            Cursor.Current = Cursors.SizeAll;
        }

        private void Size_Click(object sender , EventArgs e) // Change Size of Frame's Program
        {
            // Do nothing because i don't have any ideal to develope it and it will be exist as soon as posible
        }

        private void Minimize_Click(object sender , EventArgs e) // Minimize Form
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Maximize_Click(object sender , EventArgs e) // Maximize Form
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void Close_Click(object sender , EventArgs e) // Exit Form
        {
            Exit();
        }

        #endregion

        private void panel2_MouseClick(object sender, MouseEventArgs e) // Create main menu right click
        {
            Main_Menu(e);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e) // Event Right Click on top of Taskbar
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu cm = new ContextMenu();
                cm.MenuItems.Add(new MenuItem("Restore", new EventHandler(Restore_Click)));
                cm.MenuItems.Add(new MenuItem("Move", new EventHandler(Move_Click)));
                cm.MenuItems.Add(new MenuItem("Size", new EventHandler(Size_Click)));
                cm.MenuItems.Add(new MenuItem("Minimize", new EventHandler(Minimize_Click)));
                cm.MenuItems.Add(new MenuItem("Maximize", new EventHandler(Maximize_Click)));
                cm.MenuItems.Add(new MenuItem("Close      Alt+F4", new EventHandler(Close_Click)));
                if (this.WindowState == FormWindowState.Normal)
                {
                    cm.MenuItems[3].Enabled = true;
                    cm.MenuItems[4].Enabled = true;
                    cm.MenuItems[2].Enabled = false;

                }
                else if (this.WindowState == FormWindowState.Minimized)
                {
                    cm.MenuItems[3].Enabled = false;
                    cm.MenuItems[1].Enabled = false;
                    cm.MenuItems[2].Enabled = false;
                }
                else if (this.WindowState == FormWindowState.Maximized)
                {
                    cm.MenuItems[4].Enabled = false;
                    cm.MenuItems[1].Enabled = false;
                    cm.MenuItems[2].Enabled = false;
                }
                cm.Show(this , new Point(e.X, e.Y));
            }
        }

        private void Main_KeyPress(object sender, KeyPressEventArgs e) // Process Event When user press button Esc
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                Cursor.Current = Cursors.Default;
                Refreshs();
            }
        }

        #region Notification

        private void pictureBox6_Click(object sender, EventArgs e) // Hide notification
        {
            panelControl1.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e) // Show Notification
        {
            panelControl1.Show();
            panelControl2.Show();
        }

        private void labelControl5_MouseHover(object sender, EventArgs e) // Set font when user hover mouse this range
        {
            label5.Font = new Font(label5.Font.Name, label5.Font.SizeInPoints, FontStyle.Underline);
        }

        private void labelControl5_MouseLeave(object sender, EventArgs e) // Set font when user hover mouse this range
        {
            label5.Font = new Font(label5.Font.Name, label5.Font.SizeInPoints, FontStyle.Regular);
        }

        private void labelControl10_MouseHover(object sender, EventArgs e) // set font when user hover mouse this range
        {
            label10.Font = new Font(label10.Font.Name, label10.Font.SizeInPoints, FontStyle.Underline);
        }

        private void labelControl10_MouseLeave(object sender, EventArgs e) // set font when user hover mouse this range
        {
            label10.Font = new Font(label10.Font.Name, label10.Font.SizeInPoints, FontStyle.Regular);
        }

        private void pictureBox6_Click_1(object sender, EventArgs e) // Hide notification
        {
            panelControl1.Hide();
        }
    }
}
#endregion