using DevExpress.XtraEditors.Camera;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Raven
{
    public partial class LastStep : Form
    {
        bool IsDirty { get; set; }
        string FullPath = Path.GetFullPath(@"C:\");
        string FullSelect = Path.GetFullPath(@"D:\");
        System.Windows.Forms.Form GetData = System.Windows.Forms.Application.OpenForms["Info"];
 
        public LastStep()
        {
            InitializeComponent();
            cameraControl1.Hide();
            button1.Hide();
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
        public void GetImageInD() // Choose Image From D drive
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string ChoosePic = fileDialog.FileName.Replace(FullSelect, "");
                pictureBox1.Image = new Bitmap(FullSelect + ChoosePic);
                pictureBox1.Image.Tag = ChoosePic;
                IsDirty = false;
            }

        }
        public void GetImageInC() // Choose Image From C Drive
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string ChoosePic = fileDialog.FileName.Replace(FullPath, "");
                pictureBox1.Image = new Bitmap(FullPath + ChoosePic);
                pictureBox1.Image.Tag = ChoosePic;
                IsDirty = false;
            }
        }
        public void ProcessImage() //Message Suggest to choose Drive
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
        
        private void bunifuButton2_Click(object sender, EventArgs e) // Setup ANd Take a Photo
        {
            int i = 0;
            var res = MessageBox.Show("This app will use your camera\nDo you accept ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                IsDirty = true;
                using (var r= new MemoryStream())
                {
                    string path = FullSelect + @"Lesson\RIT\C #\WinForm\RavenWedding\Database\User Pic\" + ((Info)GetData).SetName.Text;
                    string t = ((Info)GetData).SetName.Text;

                    TakePictureDialog d = new TakePictureDialog();
                    if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (Directory.Exists(path))
                        {
                        sudunglai:
                            i++;
                            var ex = MessageBox.Show("The directory: " + path + i + " had exist\nDo you want to continue ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (ex == DialogResult.Yes)
                            {
                                if (Directory.Exists(path + i))
                                {
                                    goto sudunglai;
                                }
                                else
                                {
                                    Directory.CreateDirectory(path + i);
                                    Image ima = d.Image;
                                    ima.Save(path + i + @"\" + t + ".jpg");
                                }
                            }
                        }
                        else
                        {
                            
                            Directory.CreateDirectory(path);
                            Image image = d.Image;
                            image.Save(path + @"\" + t + ".jpg");
                            pictureBox1.Image.Tag = image;
                        }
                    }
                }
                //cameraControl1.Show();
                pictureBox1.Show();
                button1.Show();
                //pictureBox3.Show();
                bunifuButton1.Visible = true;
                bunifuButton2.Visible = true;
            }
            else
            {
                IsDirty = false;
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

        
        private void button1_Click(object sender, EventArgs e) //Update Image
        {
            string cStr = "Data Source=DESKTOP-7CBSM7T;Initial Catalog=OnYourWeddingDay;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(cStr))
            {
                if (IsDirty == false)
                {
                    try
                    {
                        string file = FullPath + pictureBox1.Image.Tag.ToString();
                        byte[] bytes = File.ReadAllBytes(file);
                        string UpImage = "UPDATE nhanvien set Pic = @image where Phone = @phone";
                        SqlCommand command = new SqlCommand(UpImage, con);
                        command.Parameters.AddWithValue("@phone", ((Info)GetData).GetPhone.Text);
                        var binary = command.Parameters.Add("@image", SqlDbType.VarBinary, -1);
                        binary.Value = bytes;
                    }
                    catch (Exception)
                    {
                        string file = FullSelect + pictureBox1.Image.Tag.ToString();
                        byte[] bytes = File.ReadAllBytes(file);
                        string UpImage = "UPDATE nhanvien set Pic = @image where Phone = @phone";
                        SqlCommand command = new SqlCommand(UpImage, con);
                        command.Parameters.AddWithValue("@phone", ((Info)GetData).GetPhone.Text);
                        var binary = command.Parameters.Add("@image", SqlDbType.VarBinary, -1);
                        binary.Value = bytes;
                    }
                }
                else
                {
                    string file = pictureBox1.Image.Tag.ToString();
                    byte[] bytes = File.ReadAllBytes(file);
                    string UpSefl = "UPDATE nhanvien set Pic = @image where Phone = @phone";
                    SqlCommand cm = new SqlCommand(UpSefl, con);
                    cm.Parameters.AddWithValue("@phone", ((Info)GetData).GetPhone.Text);
                    var binary = cm.Parameters.Add("@image", SqlDbType.VarBinary, -1);
                    binary.Value = bytes;
                }
            };
        }

    }
}
