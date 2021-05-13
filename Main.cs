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

namespace Raven
{
    public partial class Main : Form
    {
        public Label GetName { get { return this.bunifuCustomLabel1; } }
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
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            DashPanel.Show(); 
        }
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

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
            bunifuCustomLabel1.BackColor = Color.Black;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void radPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
