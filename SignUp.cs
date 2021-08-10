using DevExpress.XtraEditors;
using Raven.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raven
{
    public partial class SignUp : Form
    {
        string Paths = Path.GetFullPath(@"D:\");
        public Bunifu.Framework.UI.BunifuMetroTextbox Setname { get { return this.name; } }
        public Bunifu.Framework.UI.BunifuMetroTextbox SetMails { get { return this.Mailsbox; } }
        #region Round Corner
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
            panel1.Hide();
        }
        #endregion

        #region Move Form
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

        public static string GetCode() // Create Random Code to Send to user
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789";
            Random rand = new Random();
            int num = rand.Next(8, 8);
            return chars[num].ToString();
        }

        SignIn zo = new SignIn();
        
        private void bunifuFlatButton1_Click(object sender, EventArgs e) // Trigger For Register Emails
        {
            if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(passbox.Text) || string.IsNullOrEmpty(Mailsbox.Text))
            {
                bunifuFlatButton1.Enabled = false;
            }
            else
            {
                Recycle();
                panel1.Show();
                ReturnOut();
            }
        }
        public void Recycle()  // Divide Syntax code Send Emails
        {
            MailAddress from = new MailAddress("59510710666@st.utc2.edu.vn", "Nathasiania");
            MailAddress to = new MailAddress(Mailsbox.Text, "Customer");
            SendEmail("Verify Your Emails", from, to);
        }

        protected void SendEmail(string _subbject , MailAddress _from , MailAddress _to) // Send Emails
        {
            string text = "";
            SmtpClient smtpClient = new SmtpClient("Mailhost");
            MailMessage mail;
            Text = GetCode();
            mail = new MailMessage();
            mail.From = _from;
            mail.To.Add(_to);
            mail.Subject = _subbject;
            mail.Body = Text;
            mail.IsBodyHtml = true;
            smtpClient.Send(mail);
            mail.Dispose();
        }

        #region Method
        bool InsertUser(string fullname , string mails , string pass)
        {
            return AccountDAO.Instance.InsertUser(fullname, mails, pass);
        }
        #endregion

        private void Mailsbox_OnValueChanged(object sender, EventArgs e) // Check Mails
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

        private void repassbox_OnValueChanged(object sender, EventArgs e) // Check Pass is Match
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

        private void pictureBox1_Click(object sender, EventArgs e) // Exit SignUp
        {
            var res = MessageBox.Show("Do you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                this.Hide();
                SignIn IU = new SignIn();
                IU.Show();
                this.Hide();

            }
            else
            {
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) // Check Box With Agreed With Term
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

        private void bunifuFlatButton1_MouseMove(object sender, MouseEventArgs e) // Show Tip For User
        {
            if (bunifuFlatButton1.Enabled == false)
            {
                toolTip1.SetToolTip(bunifuFlatButton1, "You have some mistake onto fill in information. Please re-check it");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e) // Refresh Form
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

        private void pictureBox3_Click(object sender, EventArgs e) // Refuse provide Code which was send to your mails
        {
            panel1.Hide();
            ReturnIn();
        }

        private void bunifuButton2_Click(object sender, EventArgs e) // Move to next Form
        {
            XtraMessageBoxArgs mess = new XtraMessageBoxArgs();

            if (textEdit1.Text == GetCode())
            {
                string sname = name.Text;
                string smail = Mailsbox.Text;
                string spass = passbox.Text;
                if (InsertUser(sname, smail, spass))
                {
                    Info StepForm = new Info();
                    StepForm.Show();
                    StepForm.SetName.Text = name.Text;
                    this.Hide();
                }
            }
            else
            {
                mess.Caption = "Error";
                mess.Icon = new Icon(@"D:\Lesson\RIT\C #\WinForm\RavenWedding\Pic\Icon\error-7-xl.png");
                mess.Text = "The code you just type has wrong\nPlease recheck your emails and ensure that it same with the code which you has receive.";
                mess.Buttons = new DialogResult[]
                {
                    DialogResult.Yes, DialogResult.No
                };
                var x = XtraMessageBox.Show(mess);
            }
        }
        public void ReturnOut() // Disable everything not needed
        {
            name.Enabled = false;
            Mailsbox.Enabled = false;
            passbox.Enabled = false;
            repassbox.Enabled = false;
            checkBox1.Enabled = false;
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            bunifuFlatButton1.Enabled = false;
        }

        public void ReturnIn() // Enable Every thing to origin
        {
            name.Enabled = true;
            Mailsbox.Enabled = true;
            passbox.Enabled = true;
            repassbox.Enabled = true;
            checkBox1.Enabled = true;
            bunifuFlatButton1.Enabled = true;
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
        }

        private void SignUp_Click(object sender, EventArgs e) // Check the system ensure that when you type the code of mails no anyone can active or Enable
        {
            if (panel1.Visible == true)
            {
                this.panel1.Hide();
                panel1.Show();
                ReturnOut();
            }
        }

        #region Move Panel
        Point PanelMouseDownLocation;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) PanelMouseDownLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)

            {

                panel1.Left += e.X - PanelMouseDownLocation.X;

                panel1.Top += e.Y - PanelMouseDownLocation.Y;

            }
        }
        #endregion

        private void pictureBox4_Click(object sender, EventArgs e) // Resend code to Emails
        {
            GetCode();
            Recycle();
        }
    }
}
