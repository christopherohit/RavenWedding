using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raven
{
    public partial class DesignForm : Form
    {
        bool startpaint = false;
        Graphics g;
        int? initx = null;
        int? inity = null;
        bool drawsquare = false;
        bool drawcircle = false;
        bool flag = false;
        bool isPen = false;
        bool isErease = false;
        bool isFill = false;
        bool isText = false;
        bool isPointer = false;
        bool drawratangles = false;
        public DesignForm()
        {
            InitializeComponent();
            g = Draw.CreateGraphics();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e) // Change to text
        {
            if (pictureBox3.Enabled == true)
            {
                toolTip1.SetToolTip(pictureBox3, "Text tools\nTo write text onto screen, it will help it so easy more than");
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e) // change to pencil
        {
            if (pictureBox1.Enabled == true)
            {
                toolTip1.SetToolTip(pictureBox1, "Pencil Tools\nThis to tranfer to pencil and it will you draw onto screen");
            }
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e) //Change Tool to Delete tool 
        {
            if (pictureBox2.Enabled == true)
            {
                toolTip1.SetToolTip(pictureBox2, "Erease Tools\nThis tools help your delete all draw you mistake");
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e) // check condition if user click to Square
        {
            drawsquare = true;
        }

        private void bunifuButton2_Click(object sender, EventArgs e) // check condition if user click to retangles and draw it
        {
            drawratangles = true;
        }

        private void bunifuButton3_Click(object sender, EventArgs e) // check condition if user click to Circle
        {
            drawcircle = true;
        }

        public Color CheckSelectColor() // Check user that has click into Color picker ?
        {
            if (colorPickerUIAdv1.SelectedItem == null)
            {
                var x = colorPickerUIAdv1.AutomaticColor = Color.Black;
            }
            else
            {
                var x = colorPickerUIAdv1.SelectedItem.Color;
            }
            return BackColor;
        }

        private void Draw_MouseMove(object sender, MouseEventArgs e)
        {
            if (startpaint)
            {
                
            }
        }

        private void colorPickerUIAdv1_Picked(object sender, Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            var x = colorPickerUIAdv1.SelectedItem.Color;
        }

        #region Change Cursor in App
        public void ChangeToPencil()
        {
            this.Cursor = new Cursor(Application.StartupPath + "\\Cursor1.cur");
        }
        public void ChangeToErease()
        {
            
        }
        public void ChangeToFill()
        {
            this.Cursor = new Cursor(Application.StartupPath + "\\Cursor2.cur");
        }
        public void ChangeToText()
        {
            Cursor.Current = Cursors.IBeam;
        }

        public void ChangeToPointer()
        {
            Cursor.Current = Cursors.Default;
        }
        #endregion

        

        private void Draw_MouseDown(object sender, MouseEventArgs e)
        {
            startpaint = true;
            if (drawsquare)
            {
                SolidBrush sb = new SolidBrush(CheckSelectColor());
                g.FillRectangle(sb, e.X, e.Y, int.Parse(size.Text), int.Parse(size.Text));
                startpaint = false;
                drawsquare = false;
            }
            if (drawratangles)
            {
                SolidBrush sb = new SolidBrush(CheckSelectColor());
                g.FillRectangle(sb, e.X, e.Y, 2 * int.Parse(size.Text), int.Parse(size.Text));
                startpaint = false;
                drawratangles = false;
            }
            if (drawcircle)
            {
                SolidBrush sb = new SolidBrush(CheckSelectColor());
                g.FillRectangle(sb, e.X, e.Y, int.Parse(size.Text), int.Parse(size.Text));
                startpaint = false;
                drawcircle = false;
            }
        }

        private void Draw_MouseUp(object sender, MouseEventArgs e)
        {
            startpaint = false;
            initx = null;
            inity = null;
        }

        private void Draw_MouseHover(object sender, EventArgs e) // Recognize Type of cursor when user hover it into Drawable page
        {
            if (isPen == true)
            {
                ChangeToPencil();
            }
            else if(isErease == true)
            {
                ChangeToErease();
            }
            else if (isFill == true)
            {
                ChangeToFill();
            }
            else if (isText == true)
            {
                ChangeToText();
            }
            else if (isPointer == true)
            {
                ChangeToPointer();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) // Recognize Tools Click
        {
            isPen = true;
            isPointer = false;
            isFill = false;
            isErease = false;
            isText = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e) // Recognize Tools Click
        {
            isErease = true;
            isPointer = false;
            isPen = false;
            isText = false;
            isFill = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e) // Recognize Tools Click
        {
            isText = true;
            isPen = false;
            isPointer = false;
            isErease = false;
            isFill = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e) // Recognize Tools Click
        {
            isFill = true;
            isPointer = false;
            isPen = false;
            isErease = false;
            isText = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e) // Recognize Tools Click
        {
            isPointer = true;
            isText = false;
            isPen = false;
            isFill = false;
            isErease = false;
        }
    }
}

