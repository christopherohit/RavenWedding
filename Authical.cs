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
    public partial class Authical : Form
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
        public Authical()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        #endregion

        #region
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void Authical_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void Authical_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Authical_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        #endregion
        const string passcode = "78Q21D3QDF1D12DFS3FSS";
        System.Windows.Forms.Form Out = System.Windows.Forms.Application.OpenForms["SignIn"];
        private void labelControl4_Click(object sender, EventArgs e) // Redict to WebPage
        {
            System.Diagnostics.Process.Start("www.onyourweddingdays.com");
        }

        private void bunifuButton1_Click(object sender, EventArgs e) // Check Passcode if right cd to Sign Up Form, else message box for user
        {
            if (textBox1.Text != passcode || string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrEmpty(textBox1.Text))
            {
                
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Please fill code in blank space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Please fill code in blank space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBox1.Text != passcode)
                {
                    MessageBox.Show("Please re-check your code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if ( textBox1.Text == passcode)
            {
                SignUp signUp = new SignUp();
                Out.Hide();
                signUp.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) // Return to sign In
        {
            this.Hide();
            System.Windows.Forms.Form io = System.Windows.Forms.Application.OpenForms["SignIn"];
            io.Enabled = true;
            ((SignIn)io).carousel.RotateAlways = true;
        }
    }
}
