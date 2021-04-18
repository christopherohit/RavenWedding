﻿using System;
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
            bunifuFlatButton1.Enabled = false;
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
        SignIn zo = new SignIn();
        
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(passbox.Text))
            {

            }
            else
            {
                if (!string.IsNullOrEmpty(labelControl1.Text) && !string.IsNullOrEmpty(labelControl2.Text))
                {

                }
                else
                {
                    bunifuFlatButton1.Enabled = false;
                }
            }
        }

        private void Mailsbox_OnValueChanged(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex rmails = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (string.IsNullOrEmpty(Mailsbox.Text))
            {
                labelControl1.Text = string.Empty;
            }
            else
            {
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
        }

        private void repassbox_OnValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(repassbox.Text))
            {
                labelControl2.Text = string.Empty;
            }
            else
            {
                if (repassbox.Text != passbox.Text)
                {
                    labelControl2.Text = "Password doesn't match.";
                }
                else
                {
                    labelControl2.Text = string.Empty;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Do you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                this.Hide();
                System.Windows.Forms.Form io = System.Windows.Forms.Application.OpenForms["SignIn"];
                io.Enabled = true;

            }
            else
            {
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                bunifuFlatButton1.Enabled = true;
            }
            else
            {
                bunifuFlatButton1.Enabled = false;
            }
        }

        private void bunifuFlatButton1_MouseMove(object sender, MouseEventArgs e)
        {
            if (bunifuFlatButton1.Enabled == false)
            {
                toolTip1.SetToolTip(bunifuFlatButton1, "You have some mistake onto fill in information. Please re-check it");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) && string.IsNullOrWhiteSpace(Mailsbox.Text) && string.IsNullOrWhiteSpace(passbox.Text))
            {
                this.Invalidate();
            }
            else
            {
                var mess = MessageBox.Show("Do you want refresh all information was fill in?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (mess == DialogResult.OK)
                {
                    this.Invalidate();
                    name.Text = string.Empty;
                    Mailsbox.Text = string.Empty;
                    passbox.Text = string.Empty;
                    repassbox.Text = string.Empty;
                    if (checkBox1.Checked == true)
                    {
                        checkBox1.Checked = false;
                    }
                }
                else
                {

                }
            }
        }

    }
}
