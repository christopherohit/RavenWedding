using System;
using System.Drawing;
using System.Windows.Forms;

using Telerik.QuickStart.WinControls;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Forms.MDIMenuMerge
{
    /// <summary>
    /// example form
    /// </summary>
    public partial class Form1 : ExamplesRadForm, ISupportThemeName
    {
        private static Size ChildSize = new Size(580, 200);
        /// <summary>
        /// default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            this.Text = "RadForm MDI Parent with RadMenu";
        }

        protected override void WireEvents()
        {
            this.radMenuItem4.Click += new EventHandler(this.radMenuItem4_Click);
            this.radMenuItem5.Click += new EventHandler(this.radMenuItem5_Click);
            this.radMenuItem7.Click += new EventHandler(this.radMenuItem7_Click);
            this.radMenuItem8.Click += new EventHandler(this.radMenuItem8_Click);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Form child1 = new Form();
            child1.Size = ChildSize;
            child1.Text = "Standard Windows Form1 with no menu";
            child1.MdiParent = this;
            child1.Show();

            RadChildForm2 child4 = new RadChildForm2();
            child4.Size = ChildSize;
            child4.Text = "RadForm2 with no menu";
            child4.MdiParent = this;
            child4.Show();
            ThemeResolutionService.ApplyThemeToControlTree(child4, this.ThemeName);

            RadChildForm child2 = new RadChildForm();
            child2.Size = ChildSize;
            child2.Text = "RadForm3 with RadMenu";
            child2.MdiParent = this;
            child2.Show();
            ThemeResolutionService.ApplyThemeToControlTree(child2, this.ThemeName);
        }

        private void radMenuItem7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radMenuItem5_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            { 
                this.ActiveMdiChild.Close(); 
            }
        }

        private void radMenuItem8_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
        }

        int i = 4;

        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            RadChildForm2 child = new RadChildForm2();
            child.Size = ChildSize;
            child.Text = "RadForm" + i.ToString();
            child.MdiParent = this;
            child.Show();
            ThemeResolutionService.ApplyThemeToControlTree(child, this.ThemeName);
            i++;
        }

        public void ApplyTheme(string themeName)
        {
            this.ThemeName = themeName;
            ThemeResolutionService.ApplyThemeToControlTree(this, themeName);
        }
    }
}