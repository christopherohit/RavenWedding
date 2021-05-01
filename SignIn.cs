using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Raven.DAO;

namespace Raven
{
    public partial class SignIn : Form
    {
        public Bunifu.Framework.UI.BunifuMaterialTextbox TextBox { get { return this.name; } }
        Authical form = new Authical();
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
        public SignIn()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            if (pass.Text == "Password")
            {
                pass.isPassword = false;
            }
            else
            {
                pass.isPassword = true;
            }
            this.carousel1.TransitionSpeed = 1.1f;
            
        }
        #endregion

        #region
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void SignIn_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void SignIn_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void SignIn_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        #endregion

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {
            pass.isPassword = true;
            pass.ForeColor = Color.Black;
        }

        private void bunifuMaterialTextbox2_Click(object sender, EventArgs e)
        {
            if (pass.Text == "Password") 
            {
                pass.Text = string.Empty;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Do you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                Environment.Exit(1);
            }
            else
            {
            }
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            name.ForeColor = Color.Black;
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Enabled = false;
        }

        private void SignIn_Click(object sender, EventArgs e) //Check Form Sign Open? if yes disable it and say beep
        {
            if (Application.OpenForms.OfType<Authical>().Count() == 1)
            {
                this.Enabled = false;
                SystemSounds.Beep.Play();
            }
            else if (Application.OpenForms.OfType<Authical>().Count() < 1)
            {
                this.Enabled = true;
            }
        }

        private void carousel1_Click(object sender, EventArgs e)
        {
            carousel1.RotateAlways = false;
        }

        private void carousel1_DoubleClick(object sender, EventArgs e)
        {
            carousel1.RotateAlways = true;
        }

        private void bunifuMaterialTextbox1_Click(object sender, EventArgs e)
        {
            string username = name.Text;
            if (username == "Emails")
            {
                name.Text = string.Empty;
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string username = name.Text;
            string password = pass.Text;
            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(pass.Text))
            {
                if (string.IsNullOrWhiteSpace(name.Text))
                {
                    MessageBox.Show("We discovered that you have not entered emails in the box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(pass.Text))
                {
                    MessageBox.Show("We discovered that you have not entered password in the box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (Login(username , password))
            {
                Main main = new Main();
                this.Hide();
                main.GetName.Text = GetName(username).ToString();
                main.GetCareer.Text = GetCareer(username).ToString();
                /*main.GetImage.Image;*/
                main.ShowDialog();

            }
            else
            {
                MessageBox.Show("The username or password was incorrect, please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #region Methoddddddddddddddddddddddddddddd
        bool Login(string username, String password)
        {
            return AccountDAO.Instance.Login(username , password);
            
        }
        string GetCareer(string username)
        {
            return AccountDAO.Instance.GetCareer(username);
        }
        string GetImage(string username)
        {
            return AccountDAO.Instance.Image(username);
        }
        string GetName(string username)
        {
            return AccountDAO.Instance.GetName(username);
        }
        #endregion
        private void name_DoubleClick(object sender, EventArgs e)
        {
            name.Text = string.Empty;
        }

        private void pass_DoubleClick(object sender, EventArgs e)
        {
            pass.Text = string.Empty;
        }
    }
}
