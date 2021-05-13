using System;
using System.Drawing;
using System.Windows.Forms;

using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.RibbonBar.MDILayout
{
	public partial class Form1 : RadRibbonForm, ISupportThemeName
	{
        private int mdiChildCount = 0;

        public Form1()
        {
            InitializeComponent();

            WireEvents();

            this.AllowAero = false;

            this.radRibbonBar1.RibbonBarElement.TabStripElement.SelectedItem =
                this.radRibbonBar1.RibbonBarElement.TabStripElement.Items[0];
            this.radRibbonBar1.StartButtonImage = ResFinder.MenuIcon;
            this.radRibbonBar1.QuickAccessToolBar.InnerItem.ContentLayout.Margin = new Padding(2, 0, 2, 0);
            this.IsMdiContainer = true;
            this.MinimumSize = new Size(210, 140);
        }

        void radRibbonBarChunk2_Click(object sender, System.EventArgs e)
        {
            this.AddNewChildForm();
        }

        private void WireEvents()
        {
            this.radButtonElement5.Click += new System.EventHandler(this.radButtonElement5_Click);
            this.radRibbonBarChunk2.Click += new System.EventHandler(this.radRibbonBarChunk2_Click);
            this.radButtonElement29.Click += new System.EventHandler(this.radButtonElement29_Click);
            this.radButtonElement2.Click += new System.EventHandler(this.radButtonElement2_Click);
            this.radButtonElement3.Click += new System.EventHandler(this.radButtonElement3_Click);
            this.radButtonElement1.Click += new System.EventHandler(this.radButtonElement1_Click);
        }

        private void PrepareMDIContainerForThemeChange()
        {
            if (this.ActiveMdiChild == null)
                return;
            if (this.ActiveMdiChild.WindowState == FormWindowState.Maximized)
            {
                this.ActiveMdiChild.WindowState = FormWindowState.Normal;
            }
        }

		private void AddNewChildForm()
		{
            Form form = this.MdiChildren.Length % 2 == 0 ? new Form() : new RadForm();
            form.MdiParent = this;
            form.Text = "MDI Child Form " + (++this.mdiChildCount);
            form.Show();
            if (form is RadForm)
            {
                ThemeResolutionService.ApplyThemeToControlTree(form, this.ThemeName);
            }
		}

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            AddNewChildForm();
            AddNewChildForm();
            AddNewChildForm();
            AddNewChildForm();  
        }

        private void radButtonElement5_Click(object sender, EventArgs e)
        {
            this.AddNewChildForm();
        }

        private void radButtonElement29_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
        }

        private void radButtonElement1_Click(object sender, EventArgs e)
        {
            this.PrepareMDIContainerForThemeChange();
            ThemeResolutionService.ApplyThemeToControlTree(this, "ControlDefault");
        }

        private void radButtonElement2_Click(object sender, EventArgs e)
        {
            this.PrepareMDIContainerForThemeChange();
            ThemeResolutionService.ApplyThemeToControlTree(this, "Office2010Black");
        }

        private void radButtonElement3_Click(object sender, EventArgs e)
        {
            this.PrepareMDIContainerForThemeChange();
            ThemeResolutionService.ApplyThemeToControlTree(this, "Office2010Silver");
        }

        public void ApplyTheme(string themeName)
        {
            this.ThemeName = themeName;
            ThemeResolutionService.ApplyThemeToControlTree(this, themeName);
        }
	}
}