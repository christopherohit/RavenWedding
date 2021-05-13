using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Primitives;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.PageView.StripView.ItemButtons
{
    /// <summary>
    /// Example beautifying 
    /// </summary>
    public partial class Form1 : ExamplesForm
    {
        private int imageIndex;
        private int pageIndex;

        public Form1()
        {
            InitializeComponent();

            this.closeButtonCheck.Checked = true;
            this.radPageView1.ViewElement.ShowItemCloseButton = true;

            for (int i = 0; i < 5; i++)
            {
                RadPageViewPage page = new RadPageViewPage();
                page.Text = PageViewImages.Names[i];
                page.Image = PageViewImages.Images[i];

                this.radPageView1.Pages.Add(page);
            }

            this.pageIndex = 6;
        }

        private void closeButtonCheck_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radPageView1.ViewElement.ShowItemCloseButton = this.closeButtonCheck.Checked;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (this.imageIndex == PageViewImages.Images.Length)
            {
                this.imageIndex = 0;
            }

            RadPageViewPage page = new RadPageViewPage();
            page.Text = "Page " + this.pageIndex++;
            page.Image = PageViewImages.Images[this.imageIndex++];

            this.radPageView1.Pages.Add(page);
            this.radPageView1.SelectedPage = page;
        }

        protected override void WireEvents()
        {
            this.closeButtonCheck.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.closeButtonCheck_ToggleStateChanged);
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
        }
    }
}