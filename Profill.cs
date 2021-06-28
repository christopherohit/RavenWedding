using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010;
using Raven.DAO;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Raven
{
    public partial class Profill : Form
    {
        string Paths = Path.GetFullPath("D:/");

        string Pathstring = Path.GetFullPath("C:/");

        System.Windows.Forms.Form sd = System.Windows.Forms.Application.OpenForms["Main"];

        Point PanelMouseDownLocation;

        public PictureBox SetImage { get { return this.image; } }

        bool IsDirty { get; set; }
        bool IsDirtyImage { get; set; }

        public TextBox SetDes { get { return this.desc; } }

        public DevExpress.XtraEditors.TextEdit GetMails { get { return this.mails; } }

        public DevExpress.XtraEditors.TextEdit GetRegency { get { return this.regency; } }

        public DevExpress.XtraEditors.TextEdit Geticm { get { return this.icm; } }

        public Telerik.WinControls.UI.RadDateTimePicker GetBirth { get { return this.birth; } }

        public DevExpress.XtraEditors.TextEdit GetName { get { return this.name; } }

        public DevExpress.XtraEditors.TextEdit GetPhone { get { return this.phone; } }

        public DevExpress.XtraEditors.TextEdit GetGender { get { return this.gender; } }

        public DevExpress.XtraEditors.TextEdit GetAddress { get { return this.address; } }

        public Profill()
        {
            InitializeComponent();
            IsDirty = true;
            IsDirtyImage = true;
            panelControl1.Hide();
        }

        #region Void

        void Reload() // This Function Reload All Information
        {
            string id = ((Main)sd).ID.Text;
            ((Main)sd).GetName.Text = orname(id);
            ((Main)sd).GetImage.Image = orpic(id);
            ((Main)sd).GetCareer.Text = Regencys(id);
        }
        void CheckedSave() // Checked Unsave
        {
            string id = ((Main)sd).ID.Text;
            string nameFull = name.Text;
            string realmail = mails.Text;
            string realdesc = group.Text;
            string realicm = icm.Text;
            string realphone = phone.Text;
            string realadd = address.Text;
            DateTime realbirth = birth.Value;
            string realgen = gender.Text;
            if (IsDirty == false && IsDirtyImage == false)
            {
                var res = MessageBox.Show("We are recognize that you aren't save what you just change in your profile.\nDo you want to save it ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {

                    UpdatePes(nameFull, realgen, realphone, realadd, realicm, realbirth, realdesc, realmail, id);
                    UpdateImage();
                    IsDirty = true;
                    IsDirtyImage = true;
                }
            }
        }
        void Reset() // Return the First Time
        {
            string id = ((Main)sd).ID.Text;
            name.Text = orname(id);
            mails.Text = ormail(id);
            icm.Text = oriden(id);
            desc.Text = ordesc(id);
            phone.Text = orphone(id);
            gender.Text = orgen(id);
            birth.Value = Convert.ToDateTime(orbirth(id));
            address.Text = oraddr(id);
            image.Image = orpic(id);
        }
        void UpdateImage() // Update All Picture Change 
        {
            string cStr = "Data Source=DESKTOP-F970216;Initial Catalog=OnYourWeddingDay;Integrated Security=True";
            using (SqlConnection sql = new SqlConnection(cStr))
            {
                sql.Open();
                if (IsDirtyImage == false)
                {
                    try
                    {
                        string fileinD = Paths + image.Image.Tag.ToString();
                        byte[] bye = File.ReadAllBytes(fileinD);
                        string UpImage = "UPDATE nhanvien SET Pic = @Pic where id = @id";
                        SqlCommand command = new SqlCommand(UpImage, sql);
                        command.Parameters.AddWithValue("@id", ((Main)sd).ID.Text);
                        var binary = command.Parameters.Add("@Pic", SqlDbType.VarBinary, -1);
                        binary.Value = bye;
                        command.ExecuteNonQuery();                        
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message);
                        string fileinC = Pathstring + image.Image.Tag.ToString();
                        byte[] bye = File.ReadAllBytes(fileinC);
                        string UpImage = "UPDATE nhanvien SET Pic = @Pic where id = @id";
                        SqlCommand command = new SqlCommand(UpImage, sql);
                        command.Parameters.AddWithValue("@id", ((Main)sd).ID.Text);
                        var binary = command.Parameters.Add("@Pic", SqlDbType.VarBinary, -1);
                        binary.Value = bye;
                        command.ExecuteNonQuery();
                    }
                }
                sql.Close();
            }
        }

        #endregion

        #region Catch

        string Verify (string id)
        {
            return UpdatePe.Instances.GetPass(id);
        }
        bool UpdatePes(string name, string gender, string phone, string address, string icm, DateTime DOB, string Des, string username, string id)
        {
            return UpdatePe.Instances.UpdateInfo(name, gender, phone, address, icm, DOB, Des, username, id);
        }
        bool DeletePes(string id)
        {
            return UpdatePe.Instances.DeleteUser(id);
        }
        string orname(string id)
        {
            return UpdatePe.Instances.name(id);
        }
        string ormail(string id)
        {
            return UpdatePe.Instances.Emails(id);
        }
        string SaveOld(string id)
        {
            return UpdatePe.Instances.OldMem(id);
        }
        string orgen(string id)
        {
            return UpdatePe.Instances.Gender(id);
        }
        Image orpic(string id)
        {
            return UpdatePe.Instances.Pic(id);
        }
        string orphone(string id)
        {
            return UpdatePe.Instances.Phone(id);
        }
        string oraddr(string id)
        {
            return UpdatePe.Instances.Address(id);
        }
        string oriden(string id)
        {
            return UpdatePe.Instances.Identity(id);
        }
        string orbirth(string id)
        {
            return UpdatePe.Instances.Birthday(id);
        }
        string ordesc(string id)
        {
            return UpdatePe.Instances.Desc(id);
        }
        string Regencys(string id)
        {
            return UpdatePe.Instances.Regency(id);
        }

        #endregion

        #region UnSave Checked
        private void image_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog rm = new OpenFileDialog();
            var r = rm.ShowDialog();
            if (r == DialogResult.OK)
            {
                try
                {
                    string pathimage = rm.FileName.Replace(Paths, "");
                    image.Image = new Bitmap(Paths + pathimage);
                    image.Image.Tag = pathimage;
                    IsDirtyImage = false;
                }
                catch (Exception)
                {
                    string pathing = rm.FileName.Replace(Pathstring, "");
                    image.Image = new Bitmap(Pathstring + pathing);
                    image.Image.Tag = pathing;
                    IsDirtyImage = false;
                }
            }
        }

        private void birth_ValueChanged(object sender, EventArgs e)
        {
            if (birth.Value > birth.MaxDate)
            {
                MessageBox.Show("Your date time you picked incorrect");
                IsDirty = false;
            }
        }

        private void name_EditValueChanged(object sender, EventArgs e)
        {
            IsDirty = false;
        }

        private void mails_EditValueChanged(object sender, EventArgs e)
        {
            IsDirty = false;
        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsDirty = false;
        }

        private void address_EditValueChanged(object sender, EventArgs e)
        {
            IsDirty = false;
        }

        private void phone_EditValueChanged(object sender, EventArgs e)
        {
            IsDirty = false;
        }

        private void desc_TextChanged(object sender, EventArgs e)
        {
            IsDirty = false;
        }

        private void icm_EditValueChanged(object sender, EventArgs e)
        {
            IsDirty = false;
        }


        #endregion

        private void windowsUIButtonPanelMain_ButtonClick(object sender, ButtonEventArgs e) // Update Or Delete myseft out of system
        {
            XtraMessageBoxArgs xma = new XtraMessageBoxArgs();
            string id = ((Main)sd).ID.Text;
            string mail = mails.Text;
            string nam = name.Text;
            string gende = gender.Text;
            string mobile = phone.Text;
            string dc = address.Text;
            string cc = icm.Text;
            DateTime date = birth.Value;
            string des = desc.Text;
            string tag = ((WindowsUIButton)e.Button).Caption.ToString();
            switch (tag)
            {
                case "Save":
                    var res = MessageBox.Show("Do you want to update all of information you just chance", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.Yes)
                    {
                        UpdatePes(nam, gende, mobile, dc, cc, date, des, mail, id);
                        UpdateImage();
                        xma.Caption = "Notification";
                        xma.Text = "Your information was updated.\nPlease recheck information before exit.";
                        xma.DoNotShowAgainCheckBoxVisible = true;
                        XtraMessageBox.Show(xma);
                        IsDirty = true;
                        IsDirtyImage = true;
                        Reload();
                    }
                    else
                    {
                        break;
                    }
                    break;
                case "Save And Close":
                    var resu = MessageBox.Show("Do you want to update all of information you just chance", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resu == DialogResult.Yes)
                    {
                        UpdatePes(nam, gende, mobile, dc, cc, date, des, mail, id);
                        UpdateImage();
                        xma.Caption = "Notification";
                        xma.Text = "Your information was updated";
                        xma.DoNotShowAgainCheckBoxVisible = true;
                        XtraMessageBox.Show(xma);
                        IsDirty = true;
                        IsDirtyImage = true;
                        Reload();
                        this.Hide();
                    }
                    break;
                case "Reset Changes":
                    Reset();
                    this.ActiveControl = group;
                    break;
                case "Delete":
                    xma.Caption = "Warning Special !!!";;
                    xma.Text = "My system was recognize that you are trying to delete your account from system\nThis is a special dangerous so you need to verify\nAre you accepted ?";
                    xma.Buttons = new DialogResult[]
                        {
                            DialogResult.Yes , DialogResult.No
                        };
                    var var = XtraMessageBox.Show(xma);
                    xma.Showing += Args_Showing;
                    if (var == DialogResult.Yes)
                    {
                        panelControl1.Show();
                    }
                    break;
            }
        }

        #region Event Created by handle
        private void Args_Showing(object sender , XtraMessageShowingArgs e)
        {
            
            foreach (var control in e.Form.Controls)
            {
                SimpleButton button = control as SimpleButton;
                if (button != null)
                {
                    button.ImageOptions.SvgImageSize = new Size(16, 16);
                    button.Height = 25;
                    switch (button.DialogResult.ToString())
                    {
                        case ("Yes"):
                            
                            break;
                        case ("No"):
                            break;
                    }
                }
            }
        }

        #endregion

        private void simpleButton1_Click(object sender, EventArgs e) // Save And Delete Information of Employee
        {
            XtraMessageBoxArgs xma = new XtraMessageBoxArgs();
            string id = ((Main)sd).ID.Text;
            if (textBox1.Text == Verify(id))
            {
                string names = name.Text + "-" + mails.Text ; //EdwardCullen_cohota@icloud.com
                using (var olded = new MemoryStream())
                {
                    string paths = Paths + @"Lesson\RIT\C #\WinForm\RavenWedding\Database\User Old\" + names;
                    Directory.CreateDirectory(paths);
                    string lines = SaveOld(id);
                    StreamWriter ter = new (names + ".txt" , append: true);
                    ter.WriteLineAsync(lines);
                };
                    DeletePes(id);

                
                xma.Caption = "Last Farewell";
                xma.Text = "When you try get this acclaimed, we think that you extremely hard when do it\nHope you find a new work suitable with you than\bGoodbye !!!";
                xma.Buttons = new DialogResult[]
                    {
                        DialogResult.OK
                    };
                XtraMessageBox.Show(xma);
                try
                {
                    Process.Start(Application.StartupPath + "\\Raven.exe");
                    Process.GetCurrentProcess().Kill();
                }
                catch (Exception)
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                xma.Caption = "Error";
                xma.Text = "Failed to delete account, Something was wrong\nPlease recheck your password";
                XtraMessageBox.Show(xma);
            }
        }

        #region Move and close Verify

        private void panelControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) PanelMouseDownLocation = e.Location;
        }

        private void panelControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)

            {

                panelControl1.Left += e.X - PanelMouseDownLocation.X;

                panelControl1.Top += e.Y - PanelMouseDownLocation.Y;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panelControl1.Hide();
        }

        #endregion

        private void windowsUIButtonPanelCloseButton_ButtonClick(object sender, ButtonEventArgs e) // Save before Leave
        {
            string tag = ((WindowsUIButton)e.Button).Caption.ToString();
            switch (tag)
            {
                case "":
                    CheckedSave();
                    Reload();
                    break;
            }
            
        }

        private void Profill_FormClosing(object sender, FormClosingEventArgs e) // Save before leave
        {
            CheckedSave();
            Reload();
        }
    }
}
