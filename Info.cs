using Raven.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raven
{
    public partial class Info : Form
    {
        System.Windows.Forms.Form GetName = System.Windows.Forms.Application.OpenForms["SignUp"];
        System.Windows.Forms.Form GetLackName = System.Windows.Forms.Application.OpenForms["SignIn"];
        public Bunifu.Framework.UI.BunifuMaterialTextbox SetName { get { return this.name; } }
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
        public Info()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            /*tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
            ((Control)this.tabPage2).Enabled = false;*/
            /*gender.Region = new Region(new Rectangle(3, 3, gender.Width - 3, gender.Height - 7));*/
            pictureBox1.Hide();
            pictureBox3.Hide();
            gender.Properties.Items.Add("Male");
            gender.Properties.Items.Add("Female");
            gender.Properties.Items.Add("Other");            
        }


        #endregion

        #region Move Form
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

        private void pictureBox2_Click(object sender, EventArgs e) // Exit Form
        {
            var mss = MessageBox.Show("We're recognise that You have not completed filling out information yet \nIf you log out, you will need to enter your information for the first time\nDo you want exit", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (mss == DialogResult.Yes)
            {
                SignIn restore = new SignIn();
                restore.Show();
                this.Hide();
            }
            else
            {

            }
        }

        private void Info_Load(object sender, EventArgs e) // Load Form
        {
            // TODO: This line of code loads data into the 'onYourWeddingDayDataSet.Gender' table. You can move, or remove it, as needed.
        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e) // Check Phone
        {
            int check;
            if(phone.Text == string.Empty)
            {
                phone.LineIdleColor = Color.Gray;
                phone.LineFocusedColor = Color.White;
            }
            else if (!int.TryParse(phone.Text, out check))
            {
                phone.LineFocusedColor = Color.Red;
                phone.LineIdleColor = Color.Red;
            }
            else
            {
                phone.LineFocusedColor = Color.White;
                phone.LineIdleColor = Color.Gray;
            }
            Regex reg = new Regex("^[0-9]+$");
            if (string.IsNullOrEmpty(phone.Text))
            {
                pictureBox1.Hide();
            }
            else if (!reg.IsMatch(phone.Text))
            {
                pictureBox1.Show();
            }
            else
            {
                pictureBox1.Hide();
            }
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e) // DateTimePick
        {

        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e) // Check ICM
        {
            Regex reg = new Regex("^[0-9]+$");
            if (string.IsNullOrEmpty(ICM.Text))
            {
                pictureBox3.Hide();
            }
            else if (!reg.IsMatch(ICM.Text))
            {
                pictureBox3.Show();
            }
            else
            {
                pictureBox3.Hide();
            }
        }

        #region Method
        bool Update(string username  , string Gender , string Phone , string address , string icm , DateTime DOB , string Des)
        {
            return AccountDAO.Instance.UpdateInfo(username , Gender , Phone , address , icm , DOB , Des );
        }
        #endregion
        
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (((SignUp)GetName) == null)
            {
                string username = ((SignIn)GetLackName).TextBox.Text;
                string icm = ICM.Text;
                string Gender = gender.Text;
                string Phone = phone.Text;
                string address = Address.Text;
                DateTime DOB = birth.Value;
                string Des = desc.Text;
                if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(ICM.Text) || string.IsNullOrEmpty(gender.Text) || string.IsNullOrEmpty(phone.Text) || string.IsNullOrEmpty(Address.Text) || string.IsNullOrEmpty(desc.Text) || birth.Value.Year >= 1998)
                {
                    #region Check For missing
                    if (string.IsNullOrEmpty(name.Text))
                    {
                        MessageBox.Show("Please fill in blank space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrEmpty(ICM.Text))
                    {
                        MessageBox.Show("Please fill in blank space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrEmpty(gender.Text))
                    {
                        MessageBox.Show("Please fill in blank space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrEmpty(phone.Text))
                    {
                        MessageBox.Show("Please fill in blank space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrEmpty(Address.Text))
                    {
                        MessageBox.Show("Please fill in blank space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrEmpty(desc.Text))
                    {
                        MessageBox.Show("Please fill in blank space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (birth.Value.Year > 1998)
                    {
                        MessageBox.Show("System Error Please recheck", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    #endregion
                }
                else
                {
                    if (Update(username, Gender, Phone, address, icm, DOB, Des))
                    {
                        LastStep lastStep = new LastStep();
                        lastStep.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Update failed. Something was wrong, please try again later");
                    }
                }
            }
            else
            {
                string username = ((SignUp)GetName).SetMails.Text;
                string icm = ICM.Text;
                string Gender = gender.Text;
                string Phone = phone.Text;
                string address = Address.Text;
                DateTime DOB = birth.Value;
                string Des = desc.Text;
                if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(ICM.Text) || string.IsNullOrEmpty(gender.Text) || string.IsNullOrEmpty(phone.Text) || string.IsNullOrEmpty(Address.Text) || string.IsNullOrEmpty(desc.Text) || birth.Value.Year >= 1998)
                {
                    #region Check For missing
                    if (string.IsNullOrEmpty(name.Text))
                    {
                        MessageBox.Show("Please fill in blank space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrEmpty(ICM.Text))
                    {
                        MessageBox.Show("Please fill in blank space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrEmpty(gender.Text))
                    {
                        MessageBox.Show("Please fill in blank space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrEmpty(phone.Text))
                    {
                        MessageBox.Show("Please fill in blank space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrEmpty(Address.Text))
                    {
                        MessageBox.Show("Please fill in blank space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrEmpty(desc.Text))
                    {
                        MessageBox.Show("Please fill in blank space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (birth.Value.Year > 1998)
                    {
                        MessageBox.Show("System Error Please recheck", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    #endregion
                }
                else
                {
                    if (Update(username, Gender, Phone, address, icm, DOB, Des))
                    {
                        LastStep lastStep = new LastStep();
                        lastStep.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Update failed. Something was wrong, please try again later");
                    }
                }
            }
                
            
        }

        private void name_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
