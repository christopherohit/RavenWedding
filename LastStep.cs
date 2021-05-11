using Raven.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Raven
{
    public partial class LastStep : Form
    {
        bool IsDirty { get; set; }
        bool IsClean { get; set; }
        string FullPath = Path.GetFullPath(@"C:\");
        string FullSelect = Path.GetFullPath(@"D:\");
 
        public LastStep()
        {
            InitializeComponent();
            cameraControl1.Hide();
            pictureBox3.Hide();
            button1.Hide();
            pictureBox4.Hide();
            IsClean = true;
            IsDirty = false;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)// Create Dialog to pick picture
        {
            pictureBox1.Show();
            ProcessImage();
            this.bunifuButton1.Hide();
            button1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e) // Create Dialog to pick picture
        {
            ProcessImage();
        }

        #region Method Select Image
        public void GetImageInD()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string ChoosePic = fileDialog.FileName.Replace(FullSelect, "");
                pictureBox1.Image = new Bitmap(FullSelect + ChoosePic);
                pictureBox1.Image.Tag = ChoosePic;
                IsDirty = true;
                IsClean = true;
            }

        }
        public void GetImageInC()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string ChoosePic = fileDialog.FileName.Replace(FullPath, "");
                pictureBox1.Image = new Bitmap(FullPath + ChoosePic);
                pictureBox1.Image.Tag = ChoosePic;
                IsDirty = false;
                IsClean = false;
            }
        }
        public void ProcessImage()
        {
            try
            {
                MessageBox.Show("We don't recommend you pick any picture drive C. It will be have some error for System \n ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GetImageInD();
            }
            catch (Exception er)
            {
                MessageBox.Show("We recognize that you choose a picture from C drive, We extremely non encourage it method\n" + er.Message + "", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GetImageInC();
            }
        }
        #endregion
        
        private void bunifuButton2_Click(object sender, EventArgs e) // Setup Button Require for Take a Photo
        {
            var res = MessageBox.Show("This app will use your camera\nDo you accept ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                cameraControl1.Show();
                pictureBox1.Hide();
                pictureBox3.Show();
                bunifuButton1.Visible = false;
                bunifuButton2.Visible = false;
            }
            else
            {

            }

            
        }

        #region Move Form
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void LastStep_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void LastStep_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void LastStep_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        private void pictureBox2_Click(object sender, EventArgs e) // Exit Form
        {
            var mes = MessageBox.Show("My System will set default image for you", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (mes == DialogResult.Yes)
            {
                SignIn Log = new SignIn();
                Log.Show();
                this.Hide();
                
            }
            else
            {

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e) // Take a picture, create a directory and save it into a folder which set name by member's name
        {
            System.Windows.Forms.Form GetName = System.Windows.Forms.Application.OpenForms["Info"];
            int i = 0;
            try
            {
                Directory.CreateDirectory(FullSelect + @"Lesson\RIT\C #\Winform\Raven\Database\User_Data\" + ((Info)GetName).SetName.Text) ;
                if (Directory.Exists(FullSelect + @"Lesson\RIT\C #\Winform\Raven\Database\User_Data\" + ((Info)GetName).SetName.Text))
                {
                sudunglai:
                    i++;
                    Directory.CreateDirectory(FullSelect + @"Lesson\RIT\C #\Winform\Raven\Database\User_Data\" + ((Info)GetName).SetName.Text + i);
                    if (Directory.Exists(FullSelect + @"Lesson\RIT\C #\Winform\Raven\Database\User_Data\" + ((Info)GetName).SetName.Text + i))
                    {
                        goto sudunglai;
                    }
                    else
                    {
                        string SetFull = FullSelect + @"Lesson\RIT\C #\Winform\Raven\Database\User_Data\" + ((Info)GetName).SetName.Text + i;
                        string SavePic = Path.Combine(SetFull, DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + "--" +
                        DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() +
                        ".jpg");
                        cameraControl1.TakeSnapshot().Save(SavePic, ImageFormat.Jpeg);
                    }
                }
                pictureBox4.Show();
                button1.Show();

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                Directory.CreateDirectory(FullPath + @"Lesson\RIT\C #\Winform\Raven\Database\User_Data\" + ((Info)GetName).SetName.Text);
                if (Directory.Exists(FullPath + @"Lesson\RIT\C #\Winform\Raven\Database\User_Data\" + ((Info)GetName).SetName.Text))
                {
                sudunglai:
                    i++;
                    Directory.CreateDirectory(FullPath + @"Lesson\RIT\C #\Winform\Raven\Database\User_Data\" + ((Info)GetName).SetName.Text + i);
                    if (Directory.Exists(FullPath + @"Lesson\RIT\C #\Winform\Raven\Database\User_Data\" + ((Info)GetName).SetName.Text + i))
                    {
                        goto sudunglai;
                    }
                    else
                    {
                        string SetFull = FullPath + @"Lesson\RIT\C #\Winform\Raven\Database\User_Data\" + ((Info)GetName).SetName.Text + i;
                        string SavePic = Path.Combine(SetFull, DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + "--" +
                        DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() +
                        ".jpg");
                        cameraControl1.TakeSnapshot().Save(SavePic, ImageFormat.Jpeg);
                    }
                }
                pictureBox4.Show();
                button1.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsClean == true && IsDirty == true)
                {
                    string file = FullSelect + pictureBox1.Image.Tag.ToString();
                    byte[] buffer = File.ReadAllBytes(file);
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
