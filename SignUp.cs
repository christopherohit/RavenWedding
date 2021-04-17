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
    public partial class SignUp : Form
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
        public SignUp()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        #endregion

        #region
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void SignUp_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void SignUp_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void SignUp_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                bunifuFlatButton1.Enabled = false;
            }
            else
            {
                bunifuFlatButton1.Enabled = true;
            }
        }

        private void Mailsbox_OnValueChanged(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex rmails = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (Mailsbox.Text.Length > 0)
            {
                if (!rmails.IsMatch(Mailsbox.Text))
                {
                    labelControl1.Text = "Invalid e-mails.";
                }
                else
                {
                    labelControl1.Text = string.Empty;
                }
            }
        }

        private void repassbox_OnValueChanged(object sender, EventArgs e)
        {
            if (repassbox.Text != passbox.Text)
            {
                labelControl2.Text = "Password doesn't match. Please re-check ";
            }
            else
            {
                labelControl2.Text = string.Empty;
            }
        }
    }
}
