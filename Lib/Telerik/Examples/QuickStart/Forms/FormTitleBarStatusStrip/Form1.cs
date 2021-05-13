using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Telerik.Examples.WinControls.Forms.AboutBox;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Forms.FormTitleBarStatusStrip
{
    /// <summary>
    /// example form
    /// </summary>
    public partial class Form1 : ExamplesRadForm, ISupportThemeName, ICustomThemeExamplesForm
    {
        private RadToolTip toolTip;
        private int textPadding = 3;

        /// <summary>
        /// default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            this.FormElement.TitleBar.HelpButton.Visibility = ElementVisibility.Visible;
            this.radGridView1.TableElement.RowHeight = 60;
            this.radGridView1.TableElement.Text = "";
        }

        protected override void WireEvents()
        {
            this.timer1.Tick += new EventHandler(this.timer1_Tick);
            this.radMenuItem26.Click += new EventHandler(this.OnRadMenuItemChangeTheme_Click);
            this.radMenuItem22.Click += new EventHandler(this.OnRadMenuItemChangeTheme_Click);
            this.radMenuItem17.Click += new EventHandler(this.radMenuItem17_Click);
            this.radMenuItem12.Click += new EventHandler(this.OnRadMenuItemChangeTheme_Click);
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.toolTip != null)
            {
                this.toolTip.Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.radProgressBarElement1.Value1 < this.radProgressBarElement1.Maximum)
            {
                this.radProgressBarElement1.Value1++;
            }
            else
            {
                this.radProgressBarElement1.Value1 = this.radProgressBarElement1.Minimum;
            }
        }

        private void OnRadMenuItemChangeTheme_Click(object sender, EventArgs e)
        {
            RadMenuItem menuItem = (RadMenuItem)sender;

            foreach (RadMenuItem sibling in menuItem.HierarchyParent.Items)
            {
                sibling.IsChecked = false;
            }

            menuItem.IsChecked = true;

            string themeName = (string)(menuItem).Tag;
            ChangeThemeName(this, themeName);
        }

        private void ChangeThemeName(Control control, string themeName)
        {
            IComponentTreeHandler radControl = control as IComponentTreeHandler;
            if (radControl != null)
            {
                radControl.ThemeName = themeName;
            }

            foreach (Control child in control.Controls)
            {
                ChangeThemeName(child, themeName);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.employeesTableAdapter.Fill(this.northwindDataSet.Employees);
        }

        private void radMenuItem17_Click(object sender, EventArgs e)
        {
            RadAboutBox1 aboutBox = new RadAboutBox1();

            aboutBox.ThemeName = this.ThemeName;
            aboutBox.ShowDialog(this);
        }

        public void ApplyTheme(string themeName)
        {
            ThemeResolutionService.ApplyThemeToControlTree(this, themeName);
        }

        private void radMenu1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string text = "RadMenu is used to build attractive navigation systems.";
            this.ProcessHelpRequestedEvent(text, this.radMenu1, 4000);
        }

        private void radGridView1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string text = "RadGridView is complex control that allows you to display and edit tabular data from many different kinds of data sources.";
            this.ProcessHelpRequestedEvent(text, this.radGridView1, 4500);
        }

        private void radPageView1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string text = "RadPageView represents a control that has a collection of pages and displays one page at a time.";
            this.ProcessHelpRequestedEvent(text, this.radPageView1, 4500);
        }

        private void radStatusBar1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string text = "RadStatusStrip provides a status area that can be composed of any number of RadElement types:" + Environment.NewLine +
                                                                "buttons, repeat buttons, image buttons, labels, panels, progress bars and separators.";
            this.ProcessHelpRequestedEvent(text, this.radStatusBar1, 4500);
        }

        private void RadioButton_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string text = "RadRadioButton replaces the WinForms RadioButton control and adds robust data binding, state management, and design options.";
            this.ProcessHelpRequestedEvent(text, sender as RadRadioButton, 4000);
        }

        private void CheckBox_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string text = "RadCheckBox is designed to provide an interface element that can represent an on or off state using a check mark.";
            this.ProcessHelpRequestedEvent(text, sender as RadCheckBox, 4000);
        }

        private void Button_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string text = "RadButton gives you full control over the visual appearance." + Environment.NewLine + "RadButton supports themes, images, text(HTML like text) and backgrounds";

            this.ProcessHelpRequestedEvent(text, sender as RadButton, 4000);
        }

        private void ProcessHelpRequestedEvent(string text, RadControl control, int duration)
        {
            Point mouseLocation = control.PointToClient(Control.MousePosition);
            RadElement visualItem = control.ElementTree.GetElementAtPoint(mouseLocation);
            if (visualItem != null)
            {
                string type = visualItem.GetType().Name;
                text = "Element under mouse is: " + type + Environment.NewLine + text;
            }

            this.ShowToolTip(text, duration);
        }

        private void ShowToolTip(string text, int duration)
        {
            if (this.toolTip != null)
            {
                this.toolTip.Hide();
                this.toolTip.Draw -= toolTip_Draw;
                this.toolTip.Popup -= toolTip_Popup;
                this.toolTip = null;
            }

            this.toolTip = new RadToolTip();
            this.toolTip.OwnerDraw = true;
            this.toolTip.Draw += toolTip_Draw;
            this.toolTip.Popup += toolTip_Popup;

            this.toolTip.Show(text, Control.MousePosition, duration);
        }

        private void toolTip_Popup(object sender, PopupEventArgs e)
        {
            // Add some space for text padding.
            e.ToolTipSize = new Size(e.ToolTipSize.Width + 2 * this.textPadding, e.ToolTipSize.Height + 2 * this.textPadding);
        }

        private void toolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            Size toolTipSize = e.Bounds.Size;

            LinearGradientBrush gradientBrush =
                new LinearGradientBrush(e.Bounds.Location, new Point(e.Bounds.Left, e.Bounds.Top + toolTipSize.Height), Color.FromArgb(253, 253, 253), Color.FromArgb(227, 227, 239));
            e.Graphics.FillRectangle(gradientBrush, new Rectangle(e.Bounds.Location, toolTipSize));
            e.DrawBorder();
            Rectangle textBounds = new Rectangle(e.Bounds.Location, toolTipSize);
            textBounds.X += textPadding;
            textBounds.Y += textPadding;
            e.Graphics.DrawString(e.ToolTipText, new Font("Segoe UI", 9f), Brushes.Black, textBounds.Location);
        }
    }
}
