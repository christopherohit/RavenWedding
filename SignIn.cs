using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Raven.DAO;
using Raven.Package;

namespace Raven
{
    public partial class SignIn : Form
    {
        
        bool IsDirty { get; set; }
        public Syncfusion.Windows.Forms.Tools.Carousel carousel { get { return this.carousel1; } }
        public Bunifu.Framework.UI.BunifuMaterialTextbox TextBox { get { return this.name; } }
        Authical form = new Authical();
        int i = 4;
        #region Eclipse Corner Form
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
        public SignIn() // Use to hide password and process about GUI
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
            this.ActiveControl = bunifuButton1;
            this.carousel1.TransitionSpeed = 1.1f;
            panel2.Hide();
            pictureBox4.Hide();
            label6.Visible = false;
            bunifuTextBox2.Visible = false;
            pictureBox5.Visible = false;
            bunifuGradientPanel1.Hide();
            pictureBox7.Hide();
            IsDirty = false;
            name.ForeColor = SystemColors.GrayText;
            name.Text = "Emails";
            pass.Text = "Password";
            pass.ForeColor = SystemColors.GrayText;     
        }
        #endregion

        #region Move Form Not Need Border
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

        private void pictureBox2_Click(object sender, EventArgs e) // Exit Form
        {
            var res = MessageBox.Show("Do you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                Environment.Exit(-1);
            }
            else
            {
            }
        }

        private void labelControl3_Click(object sender, EventArgs e) // Disable Form when open Authical
        {
            IsDirty = true;
            Authical custom = new Authical();
            custom.Show();
            this.Enabled = false;
            carousel1.RotateAlways = false;
        }

        private void SignIn_Click(object sender, EventArgs e) //Check Form Sign Open? if yes disable it and say beep
        { 
            panel2.Hide();
            if (IsDirty == true)
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
        }

        private void carousel1_Click(object sender, EventArgs e) // Stop carouse
        {
            carousel1.RotateAlways = false;
        }

        private void carousel1_DoubleClick(object sender, EventArgs e) //Restart Carousel
        {
            carousel1.RotateAlways = true;
        }

        private void bunifuMaterialTextbox1_Click(object sender, EventArgs e) // //Enpty string when click on it
        {
            string username = name.Text;
            if (username == "Emails")
            {
                name.Text = string.Empty;
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e) // Button For Login
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
                    main.GetImage.Image = GetImage(username);
                    main.ID.Text = GETID(username).ToString();
                    main.ShowDialog();
                }
                else
                {
                    // Add Feature avoid users Login into System 
                    var ez = MessageBox.Show("We recognize that you are't complete all your personal information \n Do you want to complete it", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (ez == DialogResult.Yes)
                    {
                        Info retype = new Info();
                        retype.Show();
                        retype.SetName.Text = Getame(username);
                        retype.SetName.Enabled = false;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sorry, This is one of the mandatory terms that needs to be done for the purpose of identity verification\nand for the sake of the security and safety of the system.");
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
        public string GETID(string username)
        {
            return AccountDAO.Instance.GETID(username);
        }
        public bool Login(string username, string password)
        {
            return AccountDAO.Instance.Login(username , password);
            
        }
        public bool GetPhone(string Phone) // Get out the phone of user
        {
            return AccountDAO.Instance.GetPhone(Phone);
        }
        public string Getame(string username)
        {
            return AccountDAO.Instance.Getame(username);
        }
        public string GetCareer(string username)
        {
            return AccountDAO.Instance.GetCareer(username);
        }
        public Image GetImage(string username)
        {
            return AccountDAO.Instance.Images(username);
        }
        public string GetName(string username)
        {
            return AccountDAO.Instance.GetName(username);
        }
        public string getICM(string username)
        {
            return AccountDAO.Instance.GetICM(username);
        }
        bool ChecKICM(string ICM)
        {
            return AccountDAO.Instance.ICMCheck(ICM);
        }
        #endregion

        private void name_DoubleClick(object sender, EventArgs e) // //Enpty string when click on it
        {
            name.Text = string.Empty;
        }

        private void pass_DoubleClick(object sender, EventArgs e)// //Enpty string when click on it
        {
            pass.Text = string.Empty;
        }

        private void labelControl1_Click(object sender, EventArgs e) // create Panel form Recovery password
        {
            panel2.Show();
            label2.Show();
            bunifuTextBox1.Show();
            bunifuTextBox1.Text = string.Empty;
            label3.Show();
            label4.Show();
            label5.Show();
            button2.Show();
            label6.Hide();
            bunifuTextBox2.Hide();
            pictureBox5.Hide();
            button1.Hide();
        }

        #region Panel Move
        Point PanelMouseDownLocation;
        private void panel2_MouseDown(object sender, MouseEventArgs e) // Move Panel
        {
            if (e.Button == MouseButtons.Left) PanelMouseDownLocation = e.Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e) // Move Panel
        {
            if (e.Button == MouseButtons.Left)

            {

                panel2.Left += e.X - PanelMouseDownLocation.X;

                panel2.Top += e.Y - PanelMouseDownLocation.Y;

            }
        }
        #endregion

        private void pictureBox3_Click(object sender, EventArgs e) // Hide Panel recovery password
        {
            panel2.Hide();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e) // Show tooltip when mouse hover
        {
            toolTip1.SetToolTip(pictureBox4, "This field just contain number \n Do you sure what you are typing, is right your phone ? ");
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e) // check text which tying
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
            if (pictureBox4.Visible == true)
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e) //Check Number was fill in
        {
            string username = name.Text;
            string phone = bunifuTextBox1.Text;
            try
            {
                if (string.IsNullOrEmpty(bunifuTextBox1.Text))
                {
                    MessageBox.Show("Please fill in your phone number to recover password");
                }
                else
                {
                    if (GetPhone(phone))
                    {
                        label2.Visible = false;
                        bunifuTextBox1.Visible = false;
                        pictureBox4.Visible = false;
                        button2.Visible = false;
                        label6.Visible = true;
                        bunifuTextBox2.Visible = true;
                        pictureBox5.Visible = false ;
                        button1.Visible = true;
                        label4.Text = "4";

                    }
                    else
                    {
                        i++;
                        MessageBox.Show("This phone isn't available in my system \nPlease try again", "404 Error Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        label4.Text = i.ToString();
                        if (label4.Text == "0")
                        {
                            bool isblock = true;
                            if (AccountDAO.Instance.Block(username, isblock))
                            {
                                MessageBox.Show("Your Account was block please contact with admintrator");
                            }
                        }
                    }
                }
            }
            catch (Exception CA)
            {
                if (pictureBox5.Visible == true)
                {
                    MessageBox.Show(CA.Message);
                }
            }
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e) // Show Tooltip
        {
            toolTip1.SetToolTip(pictureBox5, "This field just contain number \n Do you sure what you are typing, is right your phone ? ");
        }

        private void button1_Click(object sender, EventArgs e) // Check ICM 
        {
            string username = name.Text;
            string ICM = bunifuTextBox2.Text;
            try
            {
                if (string.IsNullOrEmpty(bunifuTextBox2.Text))
                {
                    MessageBox.Show("Please fill in your identificate number to recover password");
                }
                else
                {
                    if (ChecKICM(ICM))
                    {
                        bunifuGradientPanel1.Hide();
                        panel2.Show();
                    }
                    else
                    {
                        i++;
                        MessageBox.Show("This phone isn't available in my system \nPlease try again", "404 Error Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        label4.Text = i.ToString();
                        if (label4.Text == "0")
                        {
                            bool isblock = true;
                            if (AccountDAO.Instance.Block(username, isblock))
                            {
                                MessageBox.Show("Your Account was block please contact with admintrator");
                            }
                        }
                    }
                }
            }
            catch (Exception er)
            {
                if (pictureBox4.Visible == true)
                {
                    MessageBox.Show(er.Message);
                }
            }
        }

        #region

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e) // Move Panel
        {
            if (e.Button == MouseButtons.Left) PanelMouseDownLocation = e.Location;
        }

        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e) // Move Panel
        {
            if (e.Button == MouseButtons.Left)

            {

                panel2.Left += e.X - PanelMouseDownLocation.X;

                panel2.Top += e.Y - PanelMouseDownLocation.Y;

            }
        }
        #endregion

        private void button3_Click(object sender, EventArgs e) //Update password
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

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e) // check password is match
        {
            if (bunifuTextBox4.Text != bunifuTextBox3.Text)
            {
                pictureBox7.Show();
            }
        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e) // check ICM
        {

            Regex reg = new Regex("^[0-9]+$");
            if (string.IsNullOrEmpty(bunifuTextBox2.Text) == true)
            {
                pictureBox5.Hide();
            }
            else if (!reg.IsMatch(bunifuTextBox2.Text))
            {
                pictureBox5.Show();
            }
            else
            {
                pictureBox5.Hide();
            }
            if (pictureBox5.Visible == true)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void name_Enter(object sender, EventArgs e) // Get Hint Username
        {
            if (name.Text == "Emails")
            {
                name.Text = "";
                name.ForeColor = SystemColors.WindowText;
            }
        }

        private void name_Leave(object sender, EventArgs e) //Hide Hint Username
        {
            
            if (name.Text.Length == 0)
            {
                name.Text = "Emails";
                name.ForeColor = SystemColors.GrayText;
            }
        }

        private void pass_Enter(object sender, EventArgs e) // Get Hint Pass
        {
            if (pass.Text == "Password")
            {
                pass.Text = "";
                pass.ForeColor = SystemColors.WindowText;
                pass.isPassword = true;
            }
        }

        private void pass_Leave(object sender, EventArgs e) // Hide Hint Pass
        {
            if (pass.Text.Length == 0)
            {
                pass.Text = "Password";
                pass.ForeColor = SystemColors.GrayText;
                pass.isPassword = false;
            }
        }

        private void SignIn_KeyPress(object sender, KeyPressEventArgs e) // Event when user press Enter button it will go to next if the information which user just fill in correct
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                bunifuButton1_Click(sender, e);
            }
        }
    }
}
