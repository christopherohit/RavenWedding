using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
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
            panel2.Hide();
            pictureBox4.Hide();
            label6.Visible = false;
            bunifuTextBox2.Visible = false;
            pictureBox5.Visible = false;
            bunifuGradientPanel1.Hide();
            pictureBox7.Hide();
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
            panel2.Hide();
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
                if (!string.IsNullOrEmpty(getICM(username)))
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
                    var ez = MessageBox.Show("We recognize that you are't complete all your personal information \n Do you want to complete it", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (ez == DialogResult.Yes)
                    {
                        Info retype = new Info();
                        retype.Show();
                        retype.SetName.Text = Getame(username);
                    }
                    else
                    {
                        MessageBox.Show("it's a compulsory term");
                        SignIn New = new SignIn();
                        New.Show();
                        this.Hide();
                    }
                }

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
        bool GetPhone(string username)
        {
            return AccountDAO.Instance.GetPhone(username);
        }
        string Getame(string username)
        {
            return AccountDAO.Instance.Getame(username);
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
        string getICM(string username)
        {
            return AccountDAO.Instance.GetICM(username);
        }
        bool ChecKICM(string username)
        {
            return AccountDAO.Instance.ICMCheck(username);
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

        private void labelControl1_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        #region Panel Move
        Point PanelMouseDownLocation;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) PanelMouseDownLocation = e.Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)

            {

                panel2.Left += e.X - PanelMouseDownLocation.X;

                panel2.Top += e.Y - PanelMouseDownLocation.Y;

            }
        }
        #endregion

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel2.Hide();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox4, "This field just contain number \n Do you sure what you are typing, is right your phone ? ");
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[0-9]+$");
            if (string.IsNullOrEmpty(bunifuTextBox1.Text) == true)
            {
                pictureBox4.Hide();
            }
            else if (!reg.IsMatch(bunifuTextBox1.Text))
            {
                pictureBox4.Show();
            }
            else
            {
                pictureBox4.Hide();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = name.Text;
            if (string.IsNullOrEmpty(bunifuTextBox1.Text))
            {
                MessageBox.Show("Please fill in your phone number to recover password");
            }
            else
            {
                if (GetPhone(username))
                {
                    label2.Visible = false;
                    bunifuTextBox1.Visible = false;
                    pictureBox4.Visible = false;
                    button2.Visible = false;
                    label6.Visible = true;
                    bunifuTextBox2.Visible = true;
                    pictureBox5.Visible = true;
                    button1.Visible = true;
                    label4.Text = "4";

                }
                else
                {
                    MessageBox.Show("This phone isn't available in my system \nPlease try again", "404 Error Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    for (int i = 3; i >= 0 ; i--)
                    {
                        label4.Text = i.ToString();
                        if (label4.Text == "0")
                        {
                            bool isblock = true;
                            if (CheckBlock.instance.Block(username, isblock))
                            {
                                MessageBox.Show("Your Account was block please contact with admintrator");
                            }
                        }
                    }
                }
            }
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox5, "This field just contain number \n Do you sure what you are typing, is right your phone ? ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = name.Text;
            if (string.IsNullOrEmpty(bunifuTextBox2.Text))
            {
                MessageBox.Show("Please fill in your identificate number to recover password");
            }
            else
            {
                if (ChecKICM(username))
                {
                    bunifuGradientPanel1.Hide();
                    panel2.Show();
                }
                else
                {
                    MessageBox.Show("This phone isn't available in my system \nPlease try again", "404 Error Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    for (int i = 3; i >= 0; i--)
                    {
                        label4.Text = i.ToString();
                        if (label4.Text == "0")
                        {
                            bool isblock = true;
                            if (CheckBlock.instance.Block(username, isblock))
                            {
                                MessageBox.Show("Your Account was block please contact with admintrator");
                            }
                        }
                    }
                }
            }
        }
        #region

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) PanelMouseDownLocation = e.Location;
        }

        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)

            {

                panel2.Left += e.X - PanelMouseDownLocation.X;

                panel2.Top += e.Y - PanelMouseDownLocation.Y;

            }
        }
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            string username = name.Text;
            string pass = bunifuTextBox3.Text;
            try
            {
                if (AccountDAO.Instance.ChangePass(username, pass))
                {
                    MessageBox.Show("Update Complete\nPlease ReSign In to System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bunifuGradientPanel1.Hide();
                }
            }
            catch(Exception er)
            {
                MessageBox.Show("Update Fail\nPlease try again if it don't help solve the problem, Let's contact with Admintrator" + er.Message , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {
            if (bunifuTextBox4.Text != bunifuTextBox3.Text)
            {
                pictureBox7.Show();
            }
        }
    }
}
