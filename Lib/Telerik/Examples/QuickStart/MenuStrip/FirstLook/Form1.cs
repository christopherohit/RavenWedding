using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.Themes.Design;
using Telerik.WinControls.UI;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.Primitives;

namespace Telerik.Examples.WinControls.MenuStrip.FirstLook
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            this.radMenu1.MenuElement.MenuBorder.Visibility = ElementVisibility.Hidden;
            this.SelectedControl = radMenu1;
            this.radMenu1.MenuElement.MenuFill.Visibility = ElementVisibility.Collapsed;

        }



        private void radMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Menu item '" + (sender as RadMenuItemBase).Text + "' is clicked.");
        }

        private RadButtonElement selectedButton = null;
       

        private void radButton1_Click(object sender, EventArgs e)
        {
            if (this.selectedButton != null)
            {
                selectedButton.BorderElement.ResetValue(RadItem.ForeColorProperty, ValueResetFlags.Local);
                selectedButton.BorderElement.ResetValue(RadItem.VisibilityProperty, ValueResetFlags.Local);
            }

            this.selectedButton = (sender as RadButton).ButtonElement;

            selectedButton.BorderElement.Visibility = ElementVisibility.Visible;
            selectedButton.BorderElement.ForeColor = Color.Red;

            this.menuBurn.Enabled = true;
            this.menuEmail.Enabled = true;
            this.menuOpenWidth.Enabled = true;
            this.menuPrint.Enabled = true;
        }

        protected override void WireEvents()
        {
            this.radMenuItem17.Click += new System.EventHandler(this.radMenuItem_Click);
            this.radMenuItem18.Click += new System.EventHandler(this.radMenuItem_Click);
            this.radMenuItem22.Click += new System.EventHandler(this.radMenuItem_Click);
            this.radMenuItem1_1.Click += new System.EventHandler(this.radMenuItem_Click);
            this.radMenuItem2_1.Click += new System.EventHandler(this.radMenuItem_Click);
            this.radMenuItem2_2.Click += new System.EventHandler(this.radMenuItem_Click);
            this.radMenuItem2_3.Click += new System.EventHandler(this.radMenuItem_Click);
            this.radMenuItem2_4.Click += new System.EventHandler(this.radMenuItem_Click);
            this.radMenuItem2_5.Click += new System.EventHandler(this.radMenuItem_Click);
            this.radMenuItem4_1.Click += new System.EventHandler(this.radMenuItem_Click);
            this.radMenuItem4_2.Click += new System.EventHandler(this.radMenuItem_Click);
            this.radMenuItem5_1.Click += new System.EventHandler(this.radMenuItem_Click);
            this.radMenuItem1_3.Click += new System.EventHandler(this.radMenuItem_Click);
            this.radMenuItem1_4.Click += new System.EventHandler(this.radMenuItem_Click);
            this.radMenuItem1_5.Click += new System.EventHandler(this.radMenuItem_Click);
            this.radMenuItem1_6.Click += new System.EventHandler(this.radMenuItem_Click);
            this.radMenuItem1_7.Click += new System.EventHandler(this.radMenuItem_Click);
            this.radMenuItem1_8.Click += new System.EventHandler(this.radMenuItem_Click);
            this.radMenuItem2_6.Click += new System.EventHandler(this.radMenuItem_Click);
            this.radMenuItem2_7.Click += new System.EventHandler(this.radMenuItem_Click);
            this.radMenuItem3_1.Click += new System.EventHandler(this.radMenuItem_Click);
            this.radMenuItem3_2.Click += new System.EventHandler(this.radMenuItem_Click);
            this.radMenuItem3_3.Click += new System.EventHandler(this.radMenuItem_Click);
            this.radMenuItem4_3.Click += new System.EventHandler(this.radMenuItem_Click);
            this.radMenuItem5_2.Click += new System.EventHandler(this.radMenuItem_Click);
            this.radMenuItem6_1.Click += new System.EventHandler(this.radMenuItem_Click);
            this.radMenuItem6_2.Click += new System.EventHandler(this.radMenuItem_Click);
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            this.radButton2.Click += new System.EventHandler(this.radButton1_Click);
            this.radButton3.Click += new System.EventHandler(this.radButton1_Click);
            this.radButton4.Click += new System.EventHandler(this.radButton1_Click);
            this.radMenu1.ThemeNameChanged += new ThemeNameChangedEventHandler(radMenu1_ThemeNameChanged);
        }

        void radMenu1_ThemeNameChanged(object source, ThemeNameChangedEventArgs args)
        {
            if (this.radMenu1.ThemeName == "Office2007Black")
            {
                foreach (RadMenuItem item in this.radMenu1.Items)
                {
                    item.Layout.Text.ForeColor = Color.Black;
                }
            }
            else
            {
                foreach (RadMenuItem item in this.radMenu1.Items)
                {
                    item.Layout.Text.ResetValue(VisualElement.ForeColorProperty, ValueResetFlags.Local);
                }
            }
        }
    }
}