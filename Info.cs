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

namespace Raven
{
    public partial class Info : Form
    {
        #region
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,     // x-coordinate of upper-left corner
                int nTopRect,      // y-coordinate of upper-left corner
                int nRightRect,    // x-coordinate of lower-right corner
                int nBottomRect,   // y-coordinate of lower-right corner
                int nWidthEllipse, // width of ellipse
                int nHeightEllipse // height of ellipse
            );
        public Info()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            /*tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
            ((Control)this.tabPage2).Enabled = false;*/
        }


        #endregion

        #region
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void Info_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void Info_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Info_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }


        #endregion

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn == true)
            {
                this.BackColor = Color.Black;
                pictureBox2.Image = Image.FromFile(@"D:\Lesson\RIT\C #\Winform\Raven\Pic\x-mark-48.ico");
                pictureBox2.BackColor = Color.Black;
            }
            else if (toggleSwitch1.IsOn == false)
            {
                this.BackColor = Color.White;
                pictureBox2.Image = Image.FromFile(@"D:\Lesson\RIT\C #\Winform\Raven\Pic\cancel.png");
                pictureBox2.BackColor = Color.White;
            }

        }
    }
}
