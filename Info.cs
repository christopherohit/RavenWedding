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
    public partial class Info : Form
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
        public Info()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            /*tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
            ((Control)this.tabPage2).Enabled = false;*/
            sfComboBox1.Region = new Region(new Rectangle(3, 3, sfComboBox1.Width - 3, sfComboBox1.Height - 7));
        }


        #endregion

        #region
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

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            

        }

        private void Info_Load(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {
            int check;
            if(bunifuMaterialTextbox5.Text == string.Empty)
            {
                bunifuMaterialTextbox5.LineIdleColor = Color.Gray;
                bunifuMaterialTextbox5.LineFocusedColor = Color.White;
            }
            else if (!int.TryParse(bunifuMaterialTextbox5.Text, out check))
            {
                bunifuMaterialTextbox5.LineFocusedColor = Color.Red;
                bunifuMaterialTextbox5.LineIdleColor = Color.Red;
            }
            else
            {
                bunifuMaterialTextbox5.LineFocusedColor = Color.White;
                bunifuMaterialTextbox5.LineIdleColor = Color.Gray;
            }
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }
    }
}
